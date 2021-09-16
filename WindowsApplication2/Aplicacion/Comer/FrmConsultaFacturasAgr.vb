
Public Class FrmConsultaFacturasAgr

    Inherits FrConsulta




    Dim Agricultor As New E_Agricultores(Idusuario, cn)
    Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)
    Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDeFecha, Nothing, LbDFecha, True, Cdatos.TiposCampo.Fecha, True)
        ParamTx(TxaFecha, Nothing, LbAFecha, True, Cdatos.TiposCampo.Fecha, True)
        ParamTx(TxDAgricultor, Nothing, LbdAgricultor, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxAAgricultor, Nothing, LbaAgricultor, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        cbCentro = ComboCentro(cbCentro, MiMaletin.IdCentro)

        AsociarControles(TxDAgricultor, BtBuscaagr1, Agricultor.btBusca, Agricultor, Agricultor.AGR_Nombre, LbnomAgr1)
        AsociarControles(TxAAgricultor, BtBuscaAgr2, Agricultor.btBusca, Agricultor, Agricultor.AGR_Nombre, LbNomAgr2)


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


    End Sub





    Private Sub FrmExtractoEnvasesPorMaterial_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        BInforme.Visible = False
      



        '  GridView1.Appearance.GroupRow.Font = nueva_fuente

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub



    Private Sub CargaGrid()

        Dim Consulta As New Cdatos.E_select

        Consulta.SelCampo(FacturaAgr.FGR_idempresa, "Emp")
        Consulta.SelCampo(FacturaAgr.FGR_serie, "Serie")
        Consulta.SelCampo(FacturaAgr.FGR_numerofactura, "Numero")
        Consulta.SelCampo(FacturaAgr.FGR_fecha, "Fecha")
        Consulta.SelCampo(FacturaAgr.FGR_Idagricultor, "CodAgr")
        Consulta.SelCampo(Agricultor.AGR_Nombre, "Agricultor", FacturaAgr.FGR_Idagricultor)
        Consulta.SelCampo(FacturaAgr.FGR_Igenero, "Igenero")
        Consulta.SelCampo(FacturaAgr.FGR_otrosgastos, "Gastos")
        Consulta.SelCampo(FacturaAgr.FGR_porcomision, "Com")
        Consulta.SelCampo(FacturaAgr.FGR_comision, "Canon")
        Consulta.SelCampo(FacturaAgr.FGR_BaseImponible, "BaseImp")
        Consulta.SelCampo(FacturaAgr.FGR_iva, "IVA")
        Consulta.SelCampo(FacturaAgr.FGR_CuotaIva, "CuotaIva")
        Consulta.SelCampo(FacturaAgr.FGR_Baseretencion, "BaseRet")
        Consulta.SelCampo(FacturaAgr.FGR_retencion, "Ret")
        Consulta.SelCampo(FacturaAgr.FGR_cuotaretencion, "CuotaRet")
        Consulta.SelCampo(TipoAgricultor.TPA_FondoOperativoSN, "FondoOpSN", Agricultor.AGR_IdTipo)
        Consulta.SelCampo(FacturaAgr.FGR_fondo, "Fondo")
        Consulta.SelCampo(FacturaAgr.FGR_cuotafondo, "CuotaFondo")
        Consulta.SelCampo(FacturaAgr.FGR_PorContingencia, "Cont")
        Consulta.SelCampo(FacturaAgr.FGR_CuotaContingencia, "Contingencia")
        Consulta.SelCampo(FacturaAgr.FGR_TotalFactura, "TotalFactura")

        If TxDAgricultor.Text <> "" Then
            Consulta.WheCampo(FacturaAgr.FGR_Idagricultor, ">=", TxDAgricultor.Text)
        End If
        If TxAAgricultor.Text <> "" Then
            Consulta.WheCampo(FacturaAgr.FGR_Idagricultor, "<=", TxAAgricultor.Text)
        End If
        If TxDeFecha.Text <> "" Then
            Consulta.WheCampo(FacturaAgr.FGR_fecha, ">=", TxDeFecha.Text)
        End If
        If TxaFecha.Text <> "" Then
            Consulta.WheCampo(FacturaAgr.FGR_fecha, "<=", TxaFecha.Text)
        End If



        Dim sql As String = Consulta.SQL
        Dim whe As String = Consulta.Whe
        Dim Prefijo As String = " WHERE "
        If whe <> "" Then
            Prefijo = " AND "
        End If

        sql = sql + CadenaWhereLista(FacturaAgr.FGR_idcentro, ListadeCombo(cbCentro), Prefijo) & vbCrLf
        sql = sql + " order by fgr_FECHA"

        Dim DT As DataTable = FacturaAgr.MiConexion.ConsultaSQL(sql)


        Grid.DataSource = DT
        AjustaColumnas()



    End Sub


    Private Sub AjustaColumnas()


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

             
                Case "FECHA"
                    c.Width = 75
                Case "SERIE"
                    c.Width = 75
                Case "FACTURA"
                    c.Width = 75
                Case "AGRICULTOR"
                    'c.Width = 400
                Case "IGENERO", "GASTOS", "CANON", "BASEIMP", "CUOTAIVA", "BASERET", "CUOTARET", "CUOTAFONDO", "TOTALFACTURA", "CONTINGENCIA"
                    c.MinWidth = 90
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n2}"
                Case "COM", "IVA", "RET", "FONDO", "CONT"
                    c.Caption = "%" & c.FieldName
                    c.MinWidth = 50
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n2}"

                Case "FONDOOPSN"
                    c.Caption = "F.Op"
                    c.MinWidth = 35
                    c.MaxWidth = 35
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case "CODAGR"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.MinWidth = 45
                    c.MaxWidth = 45

            End Select

        Next

        AñadeResumenCampo("Igenero", "{0:n2}")
        AñadeResumenCampo("Gastos", "{0:n2}")
        AñadeResumenCampo("Canon", "{0:n2}")
        AñadeResumenCampo("BaseImp", "{0:n2}")
        AñadeResumenCampo("CuotaIva", "{0:n2}")
        AñadeResumenCampo("BaseRet", "{0:n2}")
        AñadeResumenCampo("CuotaRet", "{0:n2}")
        AñadeResumenCampo("CuotaFondo", "{0:n2}")
        AñadeResumenCampo("Contingencia", "{0:n2}")
        AñadeResumenCampo("TotalFactura", "{0:n2}")

    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDeFecha.Text, TxaFecha.Text)
        Dim agricultores As String = FiltroDesdeHasta("Agricultor", TxDAgricultor.Text, TxAAgricultor.Text)

        If fechas.Trim <> "" Then LineasDescripcion.Add(fechas)
        If agricultores.Trim <> "" Then LineasDescripcion.Add(agricultores)


        MyBase.Imprimir()

    End Sub
   

    Protected Overrides Sub GridView1_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs)
        MyBase.GridView1_CustomColumnDisplayText(sender, e)

        If e.Column.FieldName.ToUpper.Trim = "FONDOOPSN" Then

            Dim row As DataRow = GridView1.GetDataRow(e.RowHandle)
            If Not IsNothing(row) Then

                If e.DisplayText.Trim & "" = "" Then
                    e.DisplayText = "N"
                End If

            End If

        End If

    End Sub
    
End Class