Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmSalidasFianzasEnvases
    Inherits FrConsulta


    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Envase As New E_Envases(Idusuario, cn)

    Dim err As New Errores

    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDesdeProveedor, Acreedores.ACR_Codigo, LbDesdeProveedor)
        ParamTx(TxHastaProveedor, Acreedores.ACR_Codigo, LbHastaProveedorFianza)
        ParamTx(TxDesdeFecha, ValeEnvases.VEV_Fecha, LbDesdeFecha, True)
        ParamTx(TxHastaFecha, ValeEnvases.VEV_Fecha, LbHastaFecha, True)

        ParamTx(TxDEnvase, Envase.ENV_IdEnvase, LbDEnvase)
        ParamTx(TxAEnvase, Envase.ENV_IdEnvase, LbAEnvase)

        ParamTx(TxIdCliente, Clientes.CLI_Codigo, LbCliente, False)


        AsociarControles(TxDesdeProveedor, BtBuscaDesdeProveedor, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomDesdeProveedor)
        BtBuscaDesdeProveedor.CL_Filtro = "TIPO='MA'"
        AsociarControles(TxHastaProveedor, BtBuscaHastaProveedor, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomHastaProveedor)
        BtBuscaHastaProveedor.CL_Filtro = "TIPO='MA'"


        AsociarControles(TxDEnvase, BtBuscaDEnvase, Envase.btBusca, Envase, Envase.ENV_Nombre, LbNomDEnvase)
        AsociarControles(TxAEnvase, BtBuscaAEnvase, Envase.btBusca, Envase, Envase.ENV_Nombre, LbNomAEnvase)

        AsociarControles(TxIdCliente, BtBuscaCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNombreCliente)

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxDesdeFecha.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxHastaFecha.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        If VaDate(TxDesdeFecha.Text) = VaDate("") Or VaDate(TxHastaFecha.Text) = VaDate("") Then
            MsgBox("Debe introducir fechas válidas")
            Exit Sub
        End If


        Dim sql As String = "SELECT VEV_Fecha as Fecha, VEV_Idcentro as CE, VEV_Concepto as Concepto, ASA_Albaran as Albaran, ASA_Referencia as Referencia,ASA_MatriculaRemolque as Matricula,ASA_IdCliente as IdCliente, CLI_Nombre as Cliente," & vbCrLf
        sql = sql & " VEL_IdEnvase as IdEnvase, ENV_Nombre as Envase, ENV_CodigoFianza as CodFianza, VEL_Entrega as Entrega, VEL_Retira as Retira," & vbCrLf
        sql = sql & " VEL_PrecioEntrega as PrecioEntrega, VEL_PrecioRetira as PrecioRetira, CLD_Domicilio as DomicilioDescarga," & vbCrLf
        sql = sql & " COALESCE(VEL_Retira * VEL_PrecioRetira, 0) - COALESCE(VEL_Entrega * VEL_PrecioEntrega, 0) as Importe," & vbCrLf
        sql = sql & " ASA_IdFactura as IdFactura, FRA_Serie + '-' + CAST(FRA_Factura as char) as Factura," & vbCrLf
        sql = sql & " VEL_IdFacturarecibida as IdFacturaRecibida, FRR_NumeroFactura as FacturaR, FRR_fechaCTB as FechaFac, DFZ_CodigoFianza as CodFianzaDom" & vbCrLf
        sql = sql & " FROM AlbSalida" & vbCrLf
        sql = sql & " LEFT JOIN ValeEnvases_Lineas ON ASA_IdValeEnvase = VEL_IdVale" & vbCrLf
        sql = sql & " LEFT JOIN ValeEnvases ON VEV_IdVale = VEL_IdVale" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = VEL_IdEnvase" & vbCrLf
        sql = sql & " LEFT JOIN Clientes ON ASA_IdCliente = CLI_IdCliente" & vbCrLf
        sql = sql & " LEFT JOIN Facturas ON FRA_IdFactura = ASA_IdFactura" & vbCrLf
        sql = sql & " LEFT JOIN FacturasRecibidas ON VEL_IdFacturaRecibida = FRR_Id" & vbCrLf
        sql = sql & " LEFT JOIN ClientesDescargas ON CLD_Id = ASA_iddomicilio" & vbCrLf
        sql = sql & " LEFT JOIN DomiciliosFianzas ON (DFZ_IdDomicilio = ASA_iddomicilio AND DFZ_IdEnvase = VEL_IdEnvase)" & vbCrLf
        sql = sql & " WHERE VEV_Fecha >= '" & TxDesdeFecha.Text & "'" & vbCrLf
        sql = sql & " AND VEV_Fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf

        If TxDesdeProveedor.Text.Trim <> "" Then sql = sql & " AND ENV_IdAcreedorFianza >= " & TxDesdeProveedor.Text & vbCrLf
        If TxHastaProveedor.Text.Trim <> "" Then sql = sql & " AND ENV_IdAcreedorFianza <= " & TxHastaProveedor.Text & vbCrLf

        If TxDEnvase.Text.Trim <> "" Then sql = sql & " AND VEL_IdEnvase >= " & TxDEnvase.Text & vbCrLf
        If TxAEnvase.Text.Trim <> "" Then sql = sql & " AND VEL_IdEnvase <= " & TxAEnvase.Text & vbCrLf

        If RbSiFacturados.Checked Then
            sql = sql & " AND (ASA_IdFactura > 0 )" & vbCrLf
        ElseIf RbNoFacturados.Checked Then
            sql = sql & " AND (COALESCE(ASA_IdFactura,0) = 0 )" & vbCrLf
        End If
        If RbSifacProv.Checked Then
            sql = sql & " AND ( VEL_IdFacturaRecibida > 0)" & vbCrLf
        ElseIf RbNoFacPro.Checked Then
            sql = sql & " AND ( COALESCE(VEL_IdFacturaRecibida,0) = 0)" & vbCrLf
        End If

        If VaInt(TxIdCliente.Text) > 0 Then
            sql = sql & " AND ASA_IdCliente = " & TxIdCliente.Text & vbCrLf
        End If

        Select Case True
            Case RbSiprecio.Checked
                sql = sql + " AND VEL_PRECIORETIRA > 0 "

            Case RbNoprecio.Checked
                sql = sql + " AND VEL_PRECIORETIRA = 0 "
        End Select
        sql = sql & " UNION ALL" & vbCrLf

        sql = sql & " SELECT VEV_Fecha as Fecha, VEV_Idcentro as CE, VEV_Concepto as Concepto, 0 as Albaran,VEV_Referencia as Referencia,VEV_Matricula as Matricula,VEV_Codigo as IdCliente, CLI_Nombre as Cliente," & vbCrLf
        sql = sql & " VEL_IdEnvase as IdEnvase, ENV_Nombre as Envase, ENV_CodigoFianza as CodFianza, VEL_Entrega as Entrega, VEL_Retira as Retira," & vbCrLf
        sql = sql & " VEL_PrecioEntrega as PrecioEntrega, VEL_PrecioRetira as PrecioRetira, '' as DomicilioDescarga," & vbCrLf
        sql = sql & " COALESCE(VEL_Retira * VEL_PrecioRetira, 0) - COALESCE(VEL_Entrega * VEL_PrecioEntrega, 0) as Importe," & vbCrLf
        sql = sql & " VEV_IdFactura as IdFactura, FRA_Serie + '-' + CAST(FRA_Factura as char) as Factura," & vbCrLf
        sql = sql & " VEL_IdFacturarecibida as IdFacturaRecibida, FRR_NumeroFactura as FacturaR, FRR_fechaCTB as FechaFac, DFZ_CodigoFianza as CodFianzaDom" & vbCrLf
        sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN ValeEnvases ON VEV_IdVale = VEL_IdVale" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = VEL_IdEnvase" & vbCrLf
        sql = sql & " LEFT JOIN Clientes ON VEV_Codigo = CLI_IdCliente" & vbCrLf
        sql = sql & " LEFT JOIN Facturas ON FRA_IdFactura = VEV_IdFactura" & vbCrLf
        sql = sql & " LEFT JOIN FacturasRecibidas ON VEL_IdFacturaRecibida = FRR_Id" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida ON ASA_IdValeEnvase = VEL_IdVale" & vbCrLf
        sql = sql & " LEFT JOIN DomiciliosFianzas ON (DFZ_IdDomicilio = ASA_iddomicilio AND DFZ_IdEnvase = VEL_IdEnvase)" & vbCrLf
        sql = sql & " WHERE VEV_Operacion = 'CC'" & vbCrLf
        sql = sql & " AND VEV_Fecha >= '" & TxDesdeFecha.Text & "'" & vbCrLf
        sql = sql & " AND VEV_Fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf
        If TxDesdeProveedor.Text.Trim <> "" Then sql = sql & " AND ENV_IdAcreedorFianza >= " & TxDesdeProveedor.Text & vbCrLf
        If TxHastaProveedor.Text.Trim <> "" Then sql = sql & " AND ENV_IdAcreedorFianza <= " & TxHastaProveedor.Text & vbCrLf

        If TxDEnvase.Text.Trim <> "" Then sql = sql & " AND VEL_IdEnvase >= " & TxDEnvase.Text & vbCrLf
        If TxAEnvase.Text.Trim <> "" Then sql = sql & " AND VEL_IdEnvase <= " & TxAEnvase.Text & vbCrLf

        If RbSiFacturados.Checked Then
            sql = sql & " AND (VEV_IdFactura > 0 )" & vbCrLf
        ElseIf RbNoFacturados.Checked Then
            sql = sql & " AND (COALESCE(VEV_IdFactura,0) = 0 ) " & vbCrLf
        End If
        If RbSifacProv.Checked Then
            sql = sql & " AND ( VEL_IdFacturaRecibida > 0)" & vbCrLf
        ElseIf RbNoFacPro.Checked Then
            sql = sql & " AND ( COALESCE(VEL_IdFacturaRecibida,0) = 0)" & vbCrLf
        End If

        If VaInt(TxIdCliente.Text) > 0 Then
            sql = sql & " AND VEV_Codigo = " & TxIdCliente.Text & vbCrLf
        End If

        Select Case True
            Case RbSiprecio.Checked
                sql = sql + " AND VEL_PRECIORETIRA > 0 "

            Case RbNoprecio.Checked
                sql = sql + " AND VEL_PRECIORETIRA = 0 "
        End Select


        sql = "SELECT Fecha, CE, Concepto, Albaran, Referencia,Matricula,IdCliente, Cliente, DomicilioDescarga, IdEnvase, Envase, CodFianza, SUM(Entrega) as Entrega, SUM(Retira) as Retira, " & vbCrLf & _
            " PrecioEntrega, PrecioRetira, SUM(Importe) as Importe, IdFactura, Factura, IdFacturaRecibida, FacturaR, FechaFac, CodFianzaDom" & vbCrLf & _
            " FROM ( " & vbCrLf & sql & vbCrLf & " ) as G" & vbCrLf & _
            " GROUP BY Fecha, CE, Concepto, Albaran,Referencia,Matricula,IdCliente, Cliente, DomicilioDescarga, IdEnvase, Envase, CodFianza, PrecioEntrega, PrecioRetira, IdFactura, factura, IdFacturaRecibida, FacturaR, FechaFac, CodFianzaDom" & vbCrLf
        sql = sql & " ORDER BY Fecha, CE" & vbCrLf


        GridView1.Columns.Clear()
        Dim dt As DataTable = ValeEnvases.MiConexion.ConsultaSQL(sql)

        Grid.DataSource = dt
        AjustaColumnas()


    End Sub


    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDCLIENTE", "IDENVASE", "IDFACTURA", "IDFACTURARECIBIDA"
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CE"
                    c.MinWidth = 25
                    c.MaxWidth = 25

                Case "ENTREGA", "RETIRA"
                    c.Width = 90
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

                Case "CODFIANZA", "CODFIANZADOM"
                    c.Width = 75

                Case "FECHA", "FECHAFAC", "MATRICULA"
                    c.MinWidth = 75
                    c.MaxWidth = 75

                Case "ALBARAN"
                    c.Width = 75

                Case "IMPORTE"
                    c.Width = 110
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

                Case "PRECIOENTREGA"
                    c.Caption = "P.Entrega"
                    c.Width = 80
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.000000"

                Case "PRECIORETIRA"
                    c.Caption = "P.Retira"
                    c.Width = 80
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.000000"

                Case "FACTURA"
                    c.Width = 90


                Case "FACTURAR"
                    c.Caption = "FraRecibida"
                    c.Width = 90




            End Select
        Next


        AñadeResumenCampo("Entrega", "{0:n2}")
        AñadeResumenCampo("Retira", "{0:n2}")
        AñadeResumenCampo("Importe", "{0:n2}")

    End Sub



    Public Overrides Sub Imprimir()


        LineasDescripcion.Clear()

        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDesdeFecha.Text, TxHastaFecha.Text)
        Dim cuentas As String = FiltroDesdeHasta("Acreedor Fianza", TxDesdeProveedor.Text, TxHastaProveedor.Text)

        Dim strFacturados As String() = {"SI", "NO", "TODOS"}
        Dim rbFacturados As RadioButton() = {RbSiFacturados, RbNoFacturados, RbTodosFacturados}
        Dim Facturados As String = FiltroRadioButton("Facturados", rbFacturados, strFacturados)

        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If cuentas <> "" Then LineasDescripcion.Add(cuentas)
        If Facturados <> "" Then LineasDescripcion.Add(Facturados)
        If TxIdCliente.Text <> "" Then LineasDescripcion.Add("Cliente: " & LbNombreCliente.Text)


        MyBase.Imprimir()

    End Sub




End Class