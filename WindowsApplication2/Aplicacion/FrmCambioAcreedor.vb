
Imports DevExpress.XtraEditors

Public Class FrmCambioAcreedor
    Inherits FrConsulta

    Dim AlbEntrada_HisGastos As New E_albentrada_hisgastos(Idusuario, cn)
    Dim AlbEntrada_His As New E_AlbEntrada_his(Idusuario, cn)
    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)


    Private err As New Errores()


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Acreedores.ACR_Codigo, Lb1, True)
        ParamTx(TxDato3, Nothing, Lb3, , Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato4, Nothing, Lb4, , Cdatos.TiposCampo.Fecha)

        ParamTx(TxDato2, Acreedores.ACR_Codigo, Lb2, True)

        AsociarControles(TxDato1, BtBusca1, Acreedores.btBusca, Acreedores, Acreedores.ACR_Nombre, Lb_1)
        AsociarControles(TxDato2, BtBusca2, Acreedores.btBusca, Acreedores, Acreedores.ACR_Nombre, Lb_2)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbTotalImporte.Text = 0.ToString("#,##0.00")

    End Sub



    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub


    Private Sub CargaGrid()

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbEntrada_HisGastos.AHG_id, "IdAlbHisGasto")
        consulta.SelCampo(AlbEntrada.AEN_Albaran, "Albaran", AlbEntrada_HisGastos.AHG_idalbaran, AlbEntrada.AEN_IdAlbaran)
        consulta.SelCampo(AlbEntrada.AEN_IdCentro, "CE")
        consulta.SelCampo(AlbEntrada.AEN_Fecha, "Fecha")
        consulta.SelCampo(AlbEntrada_His.AEH_idproveedor, "IdAgricultor", AlbEntrada_HisGastos.AHG_idalbhis, AlbEntrada_His.AEH_id)
        consulta.SelCampo(Agricultores.AGR_Nombre, "Agricultor", AlbEntrada_His.AEH_idproveedor, Agricultores.AGR_IdAgricultor)
        consulta.SelCampo(AlbEntrada_HisGastos.AHG_importe, "ImpGasto")
        consulta.WheCampo(AlbEntrada_HisGastos.AHG_idacreedor, "=", TxDato1.Text)
        If TxDato3.Text.Trim <> "" Then consulta.WheCampo(AlbEntrada.AEN_Fecha, ">=", TxDato3.Text)
        If TxDato4.Text.Trim <> "" Then consulta.WheCampo(AlbEntrada.AEN_Fecha, "<=", TxDato4.Text)

        Dim sql As String = consulta.SQL & vbCrLf
        sql = sql & " AND COALESCE(AHG_IdFacturaProveedor, 0) = 0" & vbCrLf
        sql = sql & " ORDER BY AEN_Fecha" & vbCrLf


        Dim dt As DataTable = AlbEntrada_His.MiConexion.ConsultaSQL(sql)


        Dim colSel As New DataColumn("S", GetType(Boolean))
        colSel.DefaultValue = False
        dt.Columns.Add(colSel)


        Grid.DataSource = Nothing
        GridView1.Columns.Clear()

        Grid.DataSource = dt
        AjustaColumnas()



    End Sub



    Private Sub AjustaColumnas()

        GridView1.BestFitColumns()

        Try

            For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

                Select Case c.FieldName.ToUpper.Trim

                    Case "IDALBHISGASTO"
                        c.Visible = False
                        c.Width = 70

                    Case "FECHA"
                        c.Width = 80

                    Case "CE"
                        c.Width = 25

                    Case "ALBARAN"
                        c.Width = 75

                    Case "IDAGRICULTOR"
                        c.Width = 60
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "00000"
                        c.Caption = "CodAgr"

                    Case "IMPGASTO"
                        c.Width = 85
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0.00"

                    Case "S"
                        c.Width = 25
                        c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                        c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                End Select

            Next


        Catch ex As Exception
            err.Muestraerror("Error al ajustar la columna", "AjustaColumnas", ex.Message)
        End Try


    End Sub



    Private Sub FrmCambioAcreedor_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False


        BtAux.Text = "Realizar cambios"
        BtAux.Width = 120
        BtAux.Image = NetAgro.My.Resources.Resources.App_kservices_16x16_32
        BtAux.Visible = True


    End Sub



    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

        If column.FieldName.ToUpper.Trim = "S" Then

            If row("S") = True Then
                row("S") = False
            Else
                row("S") = True
            End If

            CalculaTotales()

        End If



    End Sub


    Private Sub BtSelNinguno_Click(sender As System.Object, e As System.EventArgs) Handles BtSelNinguno.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = False
            End If
        Next

        CalculaTotales()

    End Sub

    Private Sub BtSelTodos_Click(sender As System.Object, e As System.EventArgs) Handles BtSelTodos.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = True
            End If
        Next

        CalculaTotales()

    End Sub




    Private Sub TxDato1_Valida(edicion As System.Boolean) Handles TxDato1.Valida

        If edicion Then

            Dim Acreedor As New E_Acreedores(Idusuario, cn)
            If Acreedor.LeerId(TxDato1.Text) Then

                TxDato2.Text = TxDato1.Text
                TxDato2.Validar(True)

            End If

        End If


    End Sub


    Private Sub CalculaTotales()

        Dim TotalImporte As Decimal = 0

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                If row("S") = True Then

                    TotalImporte = TotalImporte + VaDec(row("ImpGasto"))

                End If
            End If
        Next

        LbTotalImporte.Text = TotalImporte.ToString("#,##0.00")

    End Sub


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()

        Dim lst As New List(Of String)
        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                If row("S") = True Then
                    Dim IdAlbHisGasto As String = row("IdAlbHisGasto").ToString
                    lst.Add(IdAlbHisGasto)
                End If
            End If

        Next

        If lst.Count = 0 Then
            MsgBox("No hay albaranes seleccionados")
            Exit Sub
        End If




        If XtraMessageBox.Show("¿Desea realizar los cambios a los albaranes marcados?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim Acreedores As New E_Acreedores(Idusuario, cn)
            If Acreedores.LeerId(TxDato2.Text) Then


                For Each IdAlbHisGasto As String In lst

                    Try

                        Dim AlbEntrada_HisGastos As New E_albentrada_hisgastos(Idusuario, cn)
                        If AlbEntrada_HisGastos.LeerId(IdAlbHisGasto) Then

                            'Actualiza idproveedor del albaran_his
                            AlbEntrada_HisGastos.AHG_idacreedor.Valor = TxDato2.Text
                            AlbEntrada_HisGastos.Actualizar()

                        Else
                            err.Muestraerror("Error al leer el AlbEntrada_HisGasto con Id: " & IdAlbHisGasto, "FrmCambioAcreedor.Auxiliar", "Error al leer el AlbEntrada_HisGasto con Id: " & IdAlbHisGasto)
                        End If

                    Catch ex As Exception
                        err.Muestraerror("Error al actualizar el AlbEntrada_HisGasto con Id: " & IdAlbHisGasto, "FrmCambioAcreedor.Auxiliar", ex.Message)
                    End Try


                Next

                MsgBox("Terminado!")

                Grid.DataSource = Nothing
                LbTotalImporte.Text = 0.ToString("#,##0.00")

            Else
                err.Muestraerror("Error al leer el Acreedor con Id: " & TxDato2.Text, "FrmCambioAcreedor.Auxiliar", "Error al leer el Acreedor con Id: " & TxDato2.Text)
            End If


        End If


    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()


        Dim DeAcreedor As String = "Acreedor: " & TxDato1.Text & " - " & Lb_1.Text
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato3.Text, TxDato4.Text)


        LineasDescripcion.Add(DeAcreedor)
        If fechas <> "" Then LineasDescripcion.Add(fechas)


        MyBase.Imprimir()

    End Sub


End Class
