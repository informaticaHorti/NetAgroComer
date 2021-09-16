
Imports DevExpress.XtraEditors

Public Class FrmCambioAgricultor
    Inherits FrConsulta

    Dim AlbEntrada_His As New E_AlbEntrada_his(Idusuario, cn)
    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)


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

        ParamTx(TxDato1, Agricultores.AGR_IdAgricultor, Lb1, True)
        ParamTx(TxDato2, Nothing, Lb2, , Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato3, Nothing, Lb3, , Cdatos.TiposCampo.Fecha)

        ParamTx(TxDato4, Agricultores.AGR_IdAgricultor, Lb4, True)
        ParamTx(TxDato5, TipoAgricultor.TPA_idtipo, Lb5, True)

        AsociarControles(TxDato1, BtBusca1, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb_1)
        AsociarControles(TxDato4, BtBusca4, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb_4)
        AsociarControles(TxDato5, BtBusca5, TipoAgricultor.btBusca, TipoAgricultor, TipoAgricultor.TPA_nombre, Lb_5)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbTipo.Text = ""
        LbTotalKilos.Text = 0.ToString("#,##0.00")
        LbTotalImporte.Text = 0.ToString("#,##0.00")

    End Sub



    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub


    Private Sub CargaGrid()

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbEntrada_His.AEH_id, "IdAlbHis")
        consulta.SelCampo(AlbEntrada.AEN_Fecha, "Fecha", AlbEntrada_His.AEH_idalbaran, AlbEntrada.AEN_IdAlbaran)
        consulta.SelCampo(AlbEntrada_His.AEH_idproveedor, "IdAgricultor")
        consulta.SelCampo(Agricultores.AGR_Nombre, "Agricultor", AlbEntrada_His.AEH_idproveedor, Agricultores.AGR_IdAgricultor)
        consulta.SelCampo(AlbEntrada_His.AEH_kilos, "Kilos")
        consulta.SelCampo(AlbEntrada_His.AEH_totalalbaran, "Importe")
        consulta.WheCampo(AlbEntrada_His.AEH_idproveedor, "=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then consulta.WheCampo(AlbEntrada.AEN_Fecha, ">=", TxDato2.Text)
        If TxDato3.Text.Trim <> "" Then consulta.WheCampo(AlbEntrada.AEN_Fecha, "<=", TxDato3.Text)

        Dim sql As String = consulta.SQL & vbCrLf
        sql = sql & " AND COALESCE(AEH_IdFactura, 0) = 0" & vbCrLf
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
        GridView1.OptionsBehavior.Editable = False

        Try

            For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

                Select Case c.FieldName.ToUpper.Trim

                    Case "IDALBHIS"
                        'c.Visible = False
                        c.Width = 70

                    Case "FECHA"
                        c.Width = 80

                    Case "IDAGRICULTOR"
                        c.Width = 60
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "00000"
                        c.Caption = "CodAgr"

                    Case "KILOS", "IMPORTE"
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



    Private Sub FrmCambioAgricultorComprador_Load(sender As Object, e As System.EventArgs) Handles Me.Load

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

            Dim Agricultor As New E_Agricultores(Idusuario, cn)
            If Agricultor.LeerId(TxDato1.Text) Then

                TxDato4.Text = TxDato1.Text
                TxDato4.Validar(True)

                Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)
                If TipoAgricultor.LeerId(Agricultor.AGR_IdTipo.Valor) Then
                    LbTipo.Text = TipoAgricultor.TPA_nombre.Valor
                End If

            End If

        End If


    End Sub


    Private Sub CalculaTotales()

        Dim TotalKilos As Decimal = 0
        Dim TotalImporte As Decimal = 0

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                If row("S") = True Then

                    TotalKilos = TotalKilos + VaDec(row("Kilos"))
                    TotalImporte = TotalImporte + VaDec(row("Importe"))

                End If
            End If
        Next

        LbTotalKilos.Text = TotalKilos.ToString("#,##0.00")
        LbTotalImporte.Text = TotalImporte.ToString("#,##0.00")

    End Sub


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()

        Dim lst As New List(Of String)
        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                If row("S") = True Then
                    Dim IdAlbHis As String = row("IdAlbHis").ToString
                    lst.Add(IdAlbHis)
                End If
            End If

        Next

        If lst.Count = 0 Then
            MsgBox("No hay albaranes seleccionados, ni se ha cambiado el tipo del agricultor")
            Exit Sub
        End If




        If XtraMessageBox.Show("ATENCIÓN: se recontabilizarán los albaranes. ¿Desea realizar los cambios a los albaranes marcados?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


            Dim Agricutores As New E_Agricultores(Idusuario, cn)
            Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)

            If Agricultores.LeerId(TxDato4.Text) Then

                If TipoAgricultor.LeerId(TxDato5.Text) Then


                    For Each IdAlbHis As String In lst

                        Try

                            Dim AlbEntrada_His As New E_AlbEntrada_his(Idusuario, cn)
                            If AlbEntrada_His.LeerId(IdAlbHis) Then

                                'Actualiza idproveedor del albaran_his
                                AlbEntrada_His.AEH_idproveedor.Valor = TxDato4.Text

                                'Actualizo CuotaIVA, CuotaRe, TipoIVA, TipoRe, PoRet, TotalAlbaran
                                Dim PorIva As Decimal = VaDec(TipoAgricultor.TPA_poriva.Valor)
                                Dim TipoRet As String = (TipoAgricultor.TPA_tiporet.Valor & "").Trim.ToUpper
                                Dim PorRet As Decimal = VaDec(TipoAgricultor.TPA_porret.Valor)
                                Dim GastosComerciales As Decimal = CalculaGastosComerciales(IdAlbHis)
                                Dim CuotaIVa As Decimal = VaDec(AlbEntrada_His.AEH_baseimponible.Valor) * PorIva / 100
                                Dim CuotaRet As Decimal = VaDec(AlbEntrada_His.AEH_baseimponible.Valor) * PorRet / 100
                                Dim TotalAlbaran As Decimal = VaDec(AlbEntrada_His.AEH_baseimponible.Valor) + CuotaIVa - CuotaRet - GastosComerciales

                                AlbEntrada_His.AEH_tipoiva.Valor = PorIva
                                AlbEntrada_His.AEH_tiporet.Valor = TipoRet
                                AlbEntrada_His.AEH_poret.Valor = PorRet
                                AlbEntrada_His.AEH_cuotaiva.Valor = CuotaIVa
                                AlbEntrada_His.AEH_cuotaret.Valor = CuotaRet
                                AlbEntrada_His.AEH_totalalbaran.Valor = TotalAlbaran

                                AlbEntrada_His.Actualizar()


                                'Recontabilizar
                               

                            Else
                                err.Muestraerror("Error al leer el AlbHis con Id: " & IdAlbHis, "FrmCambioAgricultor.Auxiliar", "Error al leer el AlbHis con Id: " & IdAlbHis)
                            End If

                        Catch ex As Exception
                            err.Muestraerror("Error al actualizar el AlbEntrada_His con Id: " & IdAlbHis, "FrmCambioAgricultor.Auxiliar", ex.Message)
                        End Try
                        

                    Next

                    MsgBox("Terminado!")
                    Grid.DataSource = Nothing
                    LbTotalKilos.Text = 0.ToString("#,##0.00")
                    LbTotalImporte.Text = 0.ToString("#,##0.00")

                Else
                    err.Muestraerror("Error al leer el Tipo de Agricultor con Id: " & TxDato5.Text, "FrmCambioAgricultor.Auxiliar", "Error al leer el Tipo de Agricultor con Id: " & TxDato5.Text)
                End If

            Else
                err.Muestraerror("Error al leer el Agricultor con Id: " & TxDato4.Text, "FrmCambioAgricultor.Auxiliar", "Error al leer el Agricultor con Id: " & TxDato4.Text)
            End If


        End If



    End Sub


    Private Function CalculaGastosComerciales(IdAlbHis As String) As Decimal

        Dim GastosComerciales As Decimal = 0

        'Cálculo Kilos/Bultos/ImpVenta para base gastos
        Dim Kilos As Decimal = 0
        Dim Bultos As Decimal = 0
        Dim ImpVenta As Decimal = 0

        Dim sqlGastos As String = "SELECT SUM(AHL_kilos) AS Kilos, SUM(AHL_Bultos) AS Bultos, sum(AHL_Kilos * AHL_precio) as ImpVenta FROM AlbEntrada_HisLineas WHERE AHL_IdAlbHis = " & IdAlbHis
        Dim dtGastos As DataTable = AlbEntrada_His.MiConexion.ConsultaSQL(sqlGastos)

        If Not IsNothing(dtGastos) Then
            If dtGastos.Rows.Count > 0 Then
                Kilos = VaDec(dtGastos.Rows(0)("Kilos"))
                Bultos = VaDec(dtGastos.Rows(0)("Bultos"))
                ImpVenta = VaDec(dtGastos.Rows(0)("ImpVenta"))
            End If
        End If

        'Cálculo del importe de los gastos comerciales según el tipo de gasto
        Dim sqlCom As String = "SELECT AHG_Tipo as Tipo, AHG_Valor as Valor FROM AlbEntrada_HisGastos WHERE AHG_IdAlbHis = " & IdAlbHis & " AND AHG_Factura_Comercial = 'C'"
        Dim dtCom As DataTable = AlbEntrada_His.MiConexion.ConsultaSQL(sqlCom)

        For Each row As DataRow In dtCom.Rows

            Dim Tipo As String = (row("Tipo").ToString & "").Trim.ToUpper
            Dim Valor As Decimal = VaDec(row("Valor"))

            Dim ImporteGasto As Decimal = 0

            Select Case Tipo

                Case "K"
                    ImporteGasto = Kilos * Valor
                Case "B"
                    ImporteGasto = Bultos * Valor
                Case "%"
                    ImporteGasto = ImpVenta * Valor / 100
                Case "I"
                    ImporteGasto = Valor

            End Select

            GastosComerciales = GastosComerciales + ImporteGasto

        Next



        Return GastosComerciales

    End Function


    Private Sub TxDato4_Valida(edicion As System.Boolean) Handles TxDato4.Valida

        If edicion Then

            TxDato5.Text = ""

            Dim Agricultor As New E_Agricultores(Idusuario, cn)
            If Agricultor.LeerId(TxDato4.Text) Then

                TxDato5.Text = Agricultor.AGR_IdTipo.Valor
                TxDato5.Validar(True)

            End If

        End If

    End Sub


    Public Overrides Sub Imprimir()


        LineasDescripcion.Clear()


        Dim DeAcreedor As String = "Agricultor: " & TxDato1.Text & " - " & Lb_1.Text
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato2.Text, TxDato3.Text)


        LineasDescripcion.Add(DeAcreedor)
        If fechas <> "" Then LineasDescripcion.Add(fechas)


        MyBase.Imprimir()

    End Sub


End Class
