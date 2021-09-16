Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmConsultaFacturasRecibidas
    Inherits FrConsulta


    Dim FacturasRecibidas As New E_Facturasrecibidas(Idusuario, cn)
    Dim Cuentas As New E_Cuentas(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))



    Dim err As New Errores

    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, FacturasRecibidas.FRR_fechafactura, Lb1)
        ParamTx(TxDato2, FacturasRecibidas.FRR_fechafactura, Lb2)
        ParamTx(TxDato3, Cuentas.NumeroCuenta, Lb3, , Cdatos.TiposCampo.Cuenta)
        ParamTx(TxDato4, Cuentas.NumeroCuenta, Lb4, , Cdatos.TiposCampo.Cuenta)
        

        AsociarControles(TxDato3, BtBusca3, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lb_3)
        AsociarControles(TxDato4, BtBusca4, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lb_4)


    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)
        CbEmpresas = ComboEmpresas(CbEmpresas, MiMaletin.IdEmpresaCTB)
        cbCentro = ComboCentro(cbCentro, MiMaletin.IdCentro)
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxDato1.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato2.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim sqlWhere As String = ""
        If TxDato1.Text <> "" Then sqlWhere = " WHERE FRR_FechaFactura >= '" & TxDato1.Text & "'" & vbCrLf
        If TxDato2.Text <> "" Then
            If sqlWhere = "" Then
                sqlWhere = " WHERE FRR_FechaFactura <= '" & TxDato2.Text & "'" & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND FRR_FechaFactura <= '" & TxDato2.Text & "'" & vbCrLf
            End If
        End If

        If TxDato3.Text <> "" Then
            If sqlWhere = "" Then
                sqlWhere = " WHERE FRR_IdCuenta >= '" & TxDato3.Text & "'" & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND FRR_IdCuenta >= '" & TxDato3.Text & "'" & vbCrLf
            End If
        End If
        If TxDato4.Text <> "" Then
            If sqlWhere = "" Then
                sqlWhere = " WHERE FRR_IdCuenta <= '" & TxDato4.Text & "'" & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND FRR_IdCuenta <= '" & TxDato4.Text & "'" & vbCrLf
            End If
        End If

        If sqlWhere = "" Then
            sqlWhere = " WHERE " + CadenaWhereLista(FacturasRecibidas.FRR_IdEmpresa, ListadeCombo(CbEmpresas))
        Else
            sqlWhere = sqlWhere & " AND " + CadenaWhereLista(FacturasRecibidas.FRR_IdEmpresa, ListadeCombo(CbEmpresas))

        End If

        If sqlWhere = "" Then
            sqlWhere = " WHERE " + CadenaWhereLista(FacturasRecibidas.FRR_idcentro, ListadeCombo(cbCentro))
        Else
            sqlWhere = sqlWhere & " AND " + CadenaWhereLista(FacturasRecibidas.FRR_idcentro, ListadeCombo(cbCentro))

        End If


        Dim sql As String = ""
        sql = sql & " SELECT IdFactura, Factura, Entrada, CE, Fecha, IdProveedor, IdCuenta, CU.Nombre as Proveedor," & vbCrLf
        sql = sql & " Base, CuotaIva, CuotaRet," & vbCrLf
        sql = sql & " TotalFactura, IdAlbaran, Albaran, FechaAlbaran, SUM(TotalAlb) as TotalAlb, Referencia" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT FRR_Id as IdFactura, FRR_NumeroFactura as Factura, FRR_Numero as Entrada, FRR_IdCentro as CE, FRR_FechaFactura as Fecha," & vbCrLf
        sql = sql & " FRR_IdProveedor as IdProveedor, FRR_IdCuenta as IdCuenta," & vbCrLf
        sql = sql & " COALESCE(FRR_Base1,0) + COALESCE(FRR_Base2,0) + COALESCE(FRR_Base3,0) + COALESCE(FRR_Base4,0) as Base," & vbCrLf
        sql = sql & " COALESCE(FRR_Cuota1,0) + COALESCE(FRR_Cuota2,0) + COALESCE(FRR_Cuota3,0) + COALESCE(FRR_Cuota4,0) as CuotaIva," & vbCrLf
        sql = sql & " FRR_CuotaRet as CuotaRet, FRR_TotalFac as TotalFactura, " & vbCrLf
        sql = sql & " IdAlbaran, Albaran, FechaAlbaran, TotalAlb, Referencia" & vbCrLf
        sql = sql & " FROM FacturasRecibidas" & vbCrLf
        sql = sql & " LEFT JOIN (" & vbCrLf

        'Compra de Género
        sql = sql & " SELECT AEH_IdAlbaran as IdAlbaran, AEH_IdFacturaFirme as IdFactura," & vbCrLf
        sql = sql & " AEN_Albaran as Albaran, AEN_Fecha as FechaAlbaran, AEH_BaseImponible as TotalAlb, AEN_Referencia as Referencia" & vbCrLf
        Sql = Sql & " FROM AlbEntrada_His" & vbCrLf
        Sql = Sql & " LEFT JOIN AlbEntrada ON AEH_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        'Gastos de Compra
        Sql = Sql & " UNION ALL" & vbCrLf
        Sql = Sql & " SELECT AHG_IdAlbaran as IdAlbaran, AHG_IdFacturaProveedor as IdFactura," & vbCrLf
        Sql = Sql & " AEN_Albaran as Albaran, AEN_Fecha as FechaAlbaran, AHG_Importe as TotalAlb, AEN_Referencia as Referencia" & vbCrLf
        Sql = Sql & " FROM AlbEntrada_HisGastos" & vbCrLf
        Sql = Sql & " LEFT JOIN AlbEntrada ON AHG_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        Sql = Sql & " UNION ALL" & vbCrLf
        'Gastos de Ventas 1
        Sql = Sql & " SELECT ASG_IdAlbaran as IdAlbaran, ASA_IdFactura as IdFactura," & vbCrLf
        sql = sql & " ASA_Albaran as Albaran, ASA_FechaSalida as FechaAlbaran, ASG_Importegastoeuros as TotalAlb, ASA_Referencia as Referencia" & vbCrLf
        sql = sql & " FROM AlbSalida_Gastos" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida ON ASA_IdAlbaran = ASG_IdAlbaran" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        'Gastos de Ventas 2
        sql = sql & " SELECT AAG_IdAlbaran as IdAlbaran, AAH_IdFactura as IdFactura," & vbCrLf
        sql = sql & " AAH_Albaran as Albaran, AAH_FechaSalida as FechaAlbaran, AAG_ImporteGasto as TotalAlb, '' as Referencia" & vbCrLf
        sql = sql & " FROM AlbSalidaALH_Gastos" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalidaALH ON AAH_IdAlbaran = AAG_IdAlbaran" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        'Gastos materiales
        sql = sql & " SELECT AMA_IdAlb as IdAlbaran, AMA_IdFactura as IdFactura," & vbCrLf
        sql = sql & " AMA_Numero as Albaran, AMA_Fecha as Fecha, AMA_Importe as TotalAlb, AMA_Referencia as Referencia" & vbCrLf
        sql = sql & " FROM AlbMaterial" & vbCrLf
        Sql = Sql & " ) AS G" & vbCrLf
        sql = sql & " ON IdFactura = FRR_Id" & vbCrLf
        sql = sql & sqlWhere
        sql = sql & " ) AS X" & vbCrLf
        sql = sql & " LEFT JOIN " & ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".dbo.Cuentas CU ON CU.NumeroCuenta = X.IdCuenta" & vbCrLf
        sql = sql & " GROUP BY IdFactura, Factura, Entrada, CE, Fecha, IdProveedor, IdCuenta, CU.Nombre, " & vbCrLf
        sql = sql & " Base, CuotaIva, CuotaRet, TotalFactura, IdAlbaran, Albaran, FechaAlbaran, Referencia" & vbCrLf

        sql = sql & " ORDER BY Fecha, IdFactura, FechaAlbaran, IdAlbaran" & vbCrLf



        GridView1.Columns.Clear()
        Dim dt As DataTable = FacturasRecibidas.MiConexion.ConsultaSQL(sql)

        Grid.DataSource = dt

        'AñadeResumenCampo("Base", "{0:n2}")
        'AñadeResumenCampo("CuotaIva", "{0:n2}")
        'AñadeResumenCampo("TotalFactura", "{0:n2}")
        'AñadeResumenCampo("Importe", "{0:n2}")


        AjustaColumnas()

    End Sub


    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDPROVEEDOR", "IDALBARAN", "ENTRADA", "IDFACTURA", "IDCUENTA"
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                
                Case "BASE", "CUOTAIVA", "TOTALFACTURA", "TOTALALB"
                    c.Width = 90
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

                Case "FECHA", "FECHAALBARAN"
                    c.Width = 85
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            End Select
        Next


    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then


                '                ImprimirInformeConsultaFacturasRecibidas(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text)
                Dim listado As New Listado_ConsultaFacturasRecibidas(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, TipoImpresion.Preliminar)
                listado.ImprimirListado()

            Else
                bDatos = False
            End If
        Else
            bDatos = False
        End If
        If Not bDatos Then
            MessageBox.Show("No hay datos que imprimir")
        End If

    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato1.Text, TxDato2.Text)
        Dim cuentas As String = FiltroDesdeHasta("Cta. Prov.", TxDato3.Text, TxDato4.Text)


        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If cuentas <> "" Then LineasDescripcion.Add(cuentas)


        MyBase.Imprimir()
    End Sub


   

End Class