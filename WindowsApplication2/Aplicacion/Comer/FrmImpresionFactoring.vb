
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports System.Collections.Generic


Public Class FrmImpresionFactoring
    Inherits FrConsulta


    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, CnCtb)
    Dim FormasPago As New E_FormasPago(Idusuario, CnCtb)
    Dim RemesasFactoring_Lineas As New E_RemesasFactoring_Lineas(Idusuario, cn)
    Dim RemesasFactoring As New E_RemesasFactoring(Idusuario, cn)

    Dim _cargando As Boolean = True


    Dim err As New Errores


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, AlbSalida.ASA_fechasalida, Lb1, True)
        ParamTx(TxDato2, AlbSalida.ASA_fechasalida, Lb2, True)
        ParamTx(TxDato3, Clientes.CLI_Codigo, Lb3)
        ParamTx(TxDato4, Clientes.CLI_Codigo, Lb4)
        ParamTx(TxDato5, Clientes.CLI_IdFormaPago, Lb5, True)
        

        AsociarControles(TxDato3, BtBusca3, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb_3)
        AsociarControles(TxDato4, BtBusca4, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb_4)
        AsociarControles(TxDato5, BtBusca5, FormasPago.btBusca, FormasPago, FormasPago.Nombre, Lb_5)

        cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Text = "Imp.Alb."
        BInforme.Image = NetAgro.My.Resources.Action_file_quick_print_16x16_32


        BtAux.Text = "Generar remesa"
        BtAux.Width = 120
        BtAux.Image = NetAgro.My.Resources.App_kservices_16x16_32
        BtAux.Visible = True


        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)


        _cargando = False

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        BtAux.Enabled = chkSoloPendientes.Checked

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxDato1.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato2.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        If TxDato5.Text.Trim = "" Then
            MsgBox("Debe introducir una forma de pago")
            Exit Sub
        End If


        Dim sqlWhere As String = ""

        'Fechas
        If TxDato1.Text.Trim <> "" Then sqlWhere = " WHERE ASA_FechaSalida >= '" & TxDato1.Text & "'" & vbCrLf
        If TxDato2.Text.Trim <> "" Then
            If sqlWhere = "" Then
                sqlWhere = " WHERE ASA_FechaSalida <= '" & TxDato2.Text & "'" & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND ASA_FechaSalida <= '" & TxDato2.Text & "'" & vbCrLf
            End If
        End If

        'Clientes
        If TxDato3.Text.Trim <> "" Then
            If sqlWhere = "" Then
                sqlWhere = " WHERE ASA_IdCliente >= '" & TxDato3.Text & "' " & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND ASA_IdCliente >= '" & TxDato3.Text & "' " & vbCrLf
            End If
        End If
        If TxDato4.Text.Trim <> "" Then
            If sqlWhere = "" Then
                sqlWhere = " WHERE ASA_IdCliente <= '" & TxDato4.Text & "'" & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND ASA_IdCliente <= '" & TxDato4.Text & "'" & vbCrLf
            End If
        End If

        'Forma de Pago (Clientes)
        If TxDato5.Text <> "" Then
            If sqlWhere = "" Then
                sqlWhere = " WHERE CLI_IdFormaPago = " & TxDato5.Text & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND CLI_IdFormaPago = " & TxDato5.Text & vbCrLf
            End If
        End If

        'PVenta
        Dim lstPuntoVenta As List(Of String) = ListadeCombo(cbPuntoVenta)
        If lstPuntoVenta.Count > 0 Then
            If sqlWhere = "" Then
                sqlWhere = CadenaWhereLista(AlbSalida.ASA_idpuntoventa, lstPuntoVenta, " WHERE ")
            Else
                sqlWhere = sqlWhere & CadenaWhereLista(AlbSalida.ASA_idpuntoventa, lstPuntoVenta, " AND ")
            End If
        End If

        'Sólo pendientes
        If chkSoloPendientes.Checked Then
            If sqlWhere = "" Then
                sqlWhere = " WHERE COALESCE(REF_Remesa,0) = 0" & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND COALESCE(REF_Remesa,0) = 0" & vbCrLf
            End If

        End If



        Dim sql As String = "SELECT ASA_IdAlbaran as IdAlbaran, ASA_Albaran as Albaran, ASA_IdCentro as CE, ASA_Factoring as FactoringSN, " & vbCrLf
        sql = sql & " ASA_FechaSalida as Fecha, ASA_IdCliente as IdCliente, CLI_Nombre as Cliente," & vbCrLf
        sql = sql & " (SELECT SUM(ASL_ImporteGeneroVta) FROM AlbSalida_Lineas WHERE ASL_IdAlbaran = ASA_IdAlbaran) * COALESCE(ASA_ValorCambio,1) as Importe," & vbCrLf
        sql = sql & " (SELECT SUM(ASC_GastoF) FROM AlbSalida_LineasCostes WHERE ASC_IdAlbaran = ASA_IdAlbaran) as GastoF," & vbCrLf
        sql = sql & " (COALESCE((SELECT SUM(COALESCE(ASL_ImporteGeneroVta,0)) FROM AlbSalida_Lineas WHERE ASL_IdAlbaran = ASA_IdAlbaran),0) + " & vbCrLf
        sql = sql & " COALESCE((SELECT SUM(COALESCE(VEL_Retira,0) * COALESCE(VEL_PrecioRetira,0)) - SUM(COALESCE(VEL_Entrega,0) * COALESCE(VEL_PrecioEntrega,0)) FROM ValeEnvases_Lineas WHERE VEL_IdVale = ASA_IdValeEnvase),0) - " & vbCrLf
        sql = sql & " COALESCE((SELECT SUM(COALESCE(ASG_ImporteGastoDivisa,0)) FROM AlbSalida_Gastos WHERE ASG_TipoFC = 'F' AND ASG_IdAlbaran = ASA_IdAlbaran),0)) * COALESCE(ASA_ValorCambio,1) as Total," & vbCrLf
        sql = sql & " REF_Remesa as Remesa" & vbCrLf
        sql = sql & " FROM AlbSalida" & vbCrLf
        sql = sql & " LEFT JOIN Clientes ON CLI_IdCliente = ASA_IdCliente" & vbCrLf
        sql = sql & " LEFT JOIN RemesasFactoring_Lineas ON RFL_IdAlbaran = ASA_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN RemesasFactoring ON REF_IdRemesa = RFL_IdRemesa" & vbCrLf
        sql = sql & sqlWhere
        sql = sql & " ORDER BY ASA_FechaSalida, ASA_IdCliente" & vbCrLf



        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)

        Dim ColSel As New DataColumn("S", GetType(Boolean))
        ColSel.DefaultValue = False
        dt.Columns.Add(ColSel)


        For Each row As DataRow In dt.Rows
            Dim FactoringSN As String = (row("FactoringSN").ToString & "").Trim.ToUpper
            If FactoringSN = "S" Then
                row("S") = True
            End If
        Next



        Grid.DataSource = dt

        AjustaColumnas()




    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDALBARAN", "FACTORINGSN"
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "FECHA"
                    c.MinWidth = 75
                    c.MaxWidth = 75
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                Case "IDCLIENTE"
                    c.Caption = "CodCli"
                    c.MinWidth = 55
                    c.MaxWidth = 55

                Case "IMPORTE", "GASTOF", "TOTAL"
                    c.Width = 85
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

                Case "S"
                    c.MinWidth = 20
                    c.MaxWidth = 20

                Case "REMESA"
                    c.Width = 70

            End Select
        Next

    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                bDatos = False

                For Each row As DataRow In dt.Rows
                    If row("S") = True Then
                        bDatos = True
                        Exit For
                    End If
                Next
            Else
                bDatos = False
            End If
        Else
            bDatos = False
        End If


        If bDatos Then
            For Each row As DataRow In dt.Rows
                If row("S") = True Then
                    Dim IdAlbaran As String = (row("IdAlbaran").ToString & "").Trim
                    VB6_ImprimirAlbaranFactoring(IdAlbaran)
                End If
            Next
        Else
            MessageBox.Show("No hay datos que imprimir")
        End If

    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato1.Text, TxDato2.Text)
        Dim clientes As String = FiltroDesdeHasta("Cliente", TxDato3.Text, TxDato4.Text)
        Dim puntosventa As String = FiltroCheckedComboBox("Punto de venta", cbPuntoVenta)

        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If clientes <> "" Then LineasDescripcion.Add(clientes)
        If puntosventa <> "" Then LineasDescripcion.Add(puntosventa)


        MyBase.Imprimir()

    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)


        If Not IsNothing(row) Then
            If column.FieldName.Trim.ToUpper = "S" Then

                Dim IdAlbaran As String = row("IdAlbaran").ToString & ""
                If VaInt(IdAlbaran) > 0 Then

                    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
                    If AlbSalida.LeerId(IdAlbaran) Then

                        Dim FactoringSN As String = "N"
                        If row("S") = True Then
                            FactoringSN = "S"
                        Else
                            FactoringSN = "N"
                        End If


                        Select Case row("S")
                            Case True
                                If CompruebaAlbaranRemesado(row("IdAlbaran")) Then
                                    row("S") = False
                                    FactoringSN = "N"
                                End If
                            Case False
                                row("S") = True
                                FactoringSN = "S"
                        End Select

                        AlbSalida.ASA_Factoring.Valor = FactoringSN
                        AlbSalida.Actualizar()

                    End If

                End If

            End If

        End If

        
    End Sub


    Private Function CompruebaAlbaranRemesado(IdAlbaran As String) As Boolean

        Dim bRes As Boolean = True

        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(RemesasFactoring_Lineas.RFL_Id, "IdLinea")
        CONSULTA.SelCampo(RemesasFactoring.REF_Remesa, "Remesa", RemesasFactoring_Lineas.RFL_IdRemesa, RemesasFactoring.REF_IdRemesa)
        CONSULTA.SelCampo(RemesasFactoring.REF_Campa, "Campa")
        CONSULTA.SelCampo(RemesasFactoring.REF_IdCentro, "CE")
        CONSULTA.WheCampo(RemesasFactoring_Lineas.RFL_IdAlbaran, "=", IdAlbaran)

        Dim dt As DataTable = RemesasFactoring.MiConexion.ConsultaSQL(CONSULTA.SQL)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                bRes = False

                Dim Remesa As String = (dt.Rows(0)("Remesa").ToString & "").Trim
                Dim Campa As String = (dt.Rows(0)("Campa").ToString & "").Trim
                Dim CE As String = (dt.Rows(0)("CE").ToString & "").Trim

                MsgBox("El albarán ya está remesado en la remesa " & Remesa & ", en el centro " & CE & ", en la campaña " & Campa & "." & vbCrLf & "Para que este albarán deje de ser de factoring, primero deberá quitarlo de la remesa.")

            End If
        End If



        Return bRes

    End Function


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()

        Dim bDatos As Boolean = True
        Dim dt As DataTable = Grid.DataSource
        Dim lstAlbaranes As New List(Of String)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                bDatos = False

                For Each row As DataRow In dt.Rows
                    If row("S") = True Then
                        bDatos = True

                        Dim IdAlbaran As String = (row("IdAlbaran").ToString & "").Trim
                        lstAlbaranes.Add(IdAlbaran)

                    End If
                Next

            Else
                bDatos = False
            End If
        Else
            bDatos = False
        End If


        If bDatos Then
            Dim frm As New FrmRemesasFactoring
            frm.InitAlbaranes(lstAlbaranes)
            frm.ShowDialog()

        Else
            MsgBox("No hay ningún albarán seleccionado")
        End If


        Consultar()


    End Sub


    Private Sub chkSoloPendientes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSoloPendientes.CheckedChanged

        BtAux.Enabled = chkSoloPendientes.Checked

        If Not _cargando Then
            Consultar()
        End If


    End Sub
End Class