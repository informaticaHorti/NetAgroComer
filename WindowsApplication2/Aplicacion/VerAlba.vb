Public Class VerAlba

    Dim idAlbaran As String
    Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
    Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Albentrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)
    Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
    Dim Albentrada_hislineas As New E_AlbEntrada_hislineas(Idusuario, cn)
    Dim Albentrada_hisgastos As New E_albentrada_hisgastos(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim TiposdeGastoAgri As New E_TiposdeGastoAgri(Idusuario, cn)


    Public Sub init(ByVal IdAlb As String)

        idAlbaran = IdAlb

        CargaGrid()

    End Sub


    Private Sub CargaGrid()

        CargaLineas()
        CargaLineasCla()
        CargaHistorico()
        CargaHistoricoLineas()
        CargaHistoricoGastos()

        AjustaColumnas()


    End Sub


    Private Sub AjustaColumnas()

        Dim columna As DevExpress.XtraGrid.Columns.GridColumn

        With GridViewLineasEntrada.Columns
            columna = .ColumnByFieldName("KgNetos")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "#,###"
                columna.MinWidth = 60
                AñadeResumenCampo(GridViewLineasEntrada, "KgNetos", "{0:n0}")
            End If
            columna = .ColumnByFieldName("Bultos")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "#,###"
                columna.MinWidth = 60
                AñadeResumenCampo(GridViewLineasEntrada, "Bultos", "{0:n0}")
            End If
            columna = .ColumnByFieldName("Piezas")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "#,###"
                columna.MinWidth = 60
                AñadeResumenCampo(GridViewLineasEntrada, "Piezas", "{0:n0}")
            End If

        End With

        With GridViewLineasClasificadas.Columns
            columna = .ColumnByFieldName("Id")
            If Not IsNothing(columna) Then columna.Visible = False

            columna = .ColumnByFieldName("KgNetos")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "#,###"
                columna.MinWidth = 60
                AñadeResumenCampo(GridViewLineasClasificadas, "KgNetos", "{0:n0}")
            End If

            columna = .ColumnByFieldName("Bultos")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "#,###"
                columna.MinWidth = 60
                AñadeResumenCampo(GridViewLineasClasificadas, "Bultos", "{0:n0}")
            End If

            columna = .ColumnByFieldName("Piezas")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "#,###"
                columna.MinWidth = 60
                AñadeResumenCampo(GridViewLineasClasificadas, "Piezas", "{0:n0}")
            End If


        End With

        With GridViewCabeceraHistorico.Columns
            columna = .ColumnByFieldName("IdAlbaran")
            If Not IsNothing(columna) Then columna.Visible = False
            columna = .ColumnByFieldName("Prov")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "00000"
            End If
            columna = .ColumnByFieldName("ImporteGen")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "#,##0.00"
                columna.MinWidth = 60
                AñadeResumenCampo(GridViewCabeceraHistorico, "ImporteGen", "{0:n2}")
            End If
            columna = .ColumnByFieldName("TGastosFac")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "#,##0.00"
                columna.MinWidth = 60
                AñadeResumenCampo(GridViewCabeceraHistorico, "TGastosFac", "{0:n2}")
            End If
            columna = .ColumnByFieldName("TGastosCom")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "#,##0.00"
                columna.MinWidth = 60
                AñadeResumenCampo(GridViewCabeceraHistorico, "TGastosCom", "{0:n2}")
            End If
        End With

        With GridViewLineasHistorico.Columns
            columna = .ColumnByFieldName("IdAlbaran")
            If Not IsNothing(columna) Then columna.Visible = False
            columna = .ColumnByFieldName("Prov")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "00000"
            End If
            columna = .ColumnByFieldName("Kilos")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "#,###"
                columna.MinWidth = 60
                AñadeResumenCampo(GridViewLineasHistorico, "Kilos", "{0:n0}")
            End If

            columna = .ColumnByFieldName("Bultos")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "#,###"
                columna.MinWidth = 60
                AñadeResumenCampo(GridViewLineasHistorico, "Bultos", "{0:n0}")
            End If

            columna = .ColumnByFieldName("Piezas")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "#,###"
                columna.MinWidth = 60
                AñadeResumenCampo(GridViewLineasHistorico, "Piezas", "{0:n0}")
            End If

            columna = .ColumnByFieldName("Precio")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "#,##0.00"
                columna.MinWidth = 60
            End If

            columna = .ColumnByFieldName("ImporteGenero")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "#,###.00"
                columna.MinWidth = 60
                AñadeResumenCampo(GridViewLineasHistorico, "ImporteGenero", "{0:n2}")
            End If

        End With

        With GridViewGastosHistorico.Columns
            columna = .ColumnByFieldName("Codigo")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "00000"
            End If
            columna = .ColumnByFieldName("Valor")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "#,##0.00000"
                columna.MinWidth = 60
            End If
            columna = .ColumnByFieldName("Importe")
            If Not IsNothing(columna) Then
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                columna.DisplayFormat.FormatString = "#,##0.00000"
                columna.MinWidth = 60
                AñadeResumenCampo(GridViewGastosHistorico, "Importe", "{0:n5}")
            End If
        End With




        GridViewLineasEntrada.BestFitColumns()
        GridViewLineasClasificadas.BestFitColumns()
        GridViewCabeceraHistorico.BestFitColumns()
        GridViewLineasHistorico.BestFitColumns()
        GridViewGastosHistorico.BestFitColumns()


    End Sub


    Private Sub CargaLineas()

        Dim consulta As New Cdatos.E_select
        Dim dt As New DataTable

        consulta.SelCampo(Albentrada_lineas.AEL_idlinea, "IdLinea")
        consulta.SelCampo(Albentrada_lineas.AEL_kilosnetos, "KgNetos")
        consulta.SelCampo(Albentrada_lineas.AEL_muestreo, "Muestreo")
        consulta.SelCampo(Albentrada_lineas.AEL_bultos, "Bultos")
        consulta.SelCampo(Albentrada_lineas.AEL_piezas, "Piezas")
        consulta.SelCampo(Albentrada_lineas.AEL_precio, "Precio")
        consulta.SelCampo(Albentrada_lineas.AEL_tipoprecio, "Tipoprecio")

        consulta.WheCampo(Albentrada_lineas.AEL_idalbaran, "=", idAlbaran)

        Dim sql As String = consulta.SQL & vbCrLf & " ORDER BY IdLinea"
        dt = Albentrada_lineas.MiConexion.ConsultaSQL(sql)
        GridLineasEntrada.DataSource = dt

    End Sub


    Private Sub CargaLineasCla()

        Dim consulta As New Cdatos.E_select
        Dim dt As New DataTable

        consulta.SelCampo(Albentrada_lineascla.ALC_id, "Id")
        consulta.SelCampo(Albentrada_lineascla.ALC_idlineaentrada, "IdLineaEntrada")
        consulta.SelCampo(Albentrada_lineascla.ALC_idcategoria, "IdCat")
        consulta.SelCampo(Albentrada_lineascla.ALC_kilosnetos, "KgNetos")
        consulta.SelCampo(Albentrada_lineascla.ALC_bultos, "Bultos")
        consulta.SelCampo(Albentrada_lineascla.ALC_piezas, "Piezas")
        consulta.SelCampo(Albentrada_lineascla.ALC_precio, "Precio")
        'consulta.SelCampo(Albentrada_lineascla.ALC_muestreo)
        consulta.WheCampo(Albentrada_lineascla.ALC_idalbaran, "=", idAlbaran)

        Dim sql As String = consulta.SQL & vbCrLf & " ORDER BY IdLineaEntrada"
        dt = Albentrada_lineascla.MiConexion.ConsultaSQL(sql)
        GridLineasClasificadas.DataSource = dt


    End Sub


    Private Sub CargaHistorico()

        Dim consulta As New Cdatos.E_select
        Dim dt As New DataTable

        consulta.SelCampo(Albentrada_his.AEH_idalbaran, "IdAlbaran")
        consulta.SelCampo(Albentrada_his.AEH_idproveedor, "Prov")
        consulta.SelCampo(Agricultores.AGR_Nombre, "Nombre", Albentrada_his.AEH_idproveedor)
        consulta.SelCampo(Albentrada_his.AEH_importegenero, "ImporteGen")
        consulta.SelCampo(Albentrada_his.AEH_tgastosfac, "TGastosFac")
        consulta.SelCampo(Albentrada_his.AEH_tgastoscom, "TGastosCom")
        consulta.WheCampo(Albentrada_his.AEH_idalbaran, "=", idAlbaran)
        dt = Albentrada_his.MiConexion.ConsultaSQL(consulta.SQL)
        GridCabeceraHistorico.DataSource = dt

    End Sub


    Private Sub CargaHistoricoLineas()

        Dim consulta As New Cdatos.E_select
        Dim dt As New DataTable

        consulta.SelCampo(Albentrada_hislineas.AHL_idalbaran, "IdAlbaran")
        consulta.SelCampo(Albentrada_hislineas.AHL_idlineaentrada, "IdLineaEntrada")
        consulta.SelCampo(Albentrada_his.AEH_idproveedor, "Prov", Albentrada_hislineas.AHL_idalbhis)
        consulta.SelCampo(Agricultores.AGR_Nombre, "Nombre", Albentrada_his.AEH_idproveedor)
        consulta.SelCampo(Albentrada_hislineas.AHL_idgenero, "IdGen")
        consulta.SelCampo(Albentrada_hislineas.AHL_idcategoria, "IdCat")
        consulta.SelCampo(Albentrada_hislineas.AHL_kilos, "Kilos")
        consulta.SelCampo(Albentrada_hislineas.AHL_bultos, "Bultos")
        consulta.SelCampo(Albentrada_hislineas.AHL_piezas, "Piezas")
        consulta.SelCampo(Albentrada_hislineas.AHL_precio, "Precio")
        consulta.SelCampo(Albentrada_hislineas.AHL_importegenero, "ImporteGenero")
        consulta.WheCampo(Albentrada_his.AEH_idalbaran, "=", idAlbaran)
        dt = Albentrada_hislineas.MiConexion.ConsultaSQL(consulta.SQL)
        GridLineasHistorico.DataSource = dt

    End Sub


    Private Sub CargaHistoricoGastos()

        Dim consulta As New Cdatos.E_select
        Dim dt As New DataTable

        consulta.SelCampo(Albentrada_hisgastos.AHG_idalbhis, "IdAlbH")
        consulta.SelCampo(Albentrada_his.AEH_idproveedor, "Codigo", Albentrada_hisgastos.AHG_idalbhis)
        consulta.SelCampo(Albentrada_hisgastos.AHG_idgasto, "IdGasto")
        consulta.SelCampo(TiposdeGastoAgri.TGA_Nombre, "Gasto", Albentrada_hisgastos.AHG_idgasto)
        consulta.SelCampo(Albentrada_hisgastos.AHG_valor, "Valor")
        consulta.SelCampo(Albentrada_hisgastos.AHG_tipo, "Tipo")
        consulta.SelCampo(Albentrada_hisgastos.AHG_importe, "Importe")
        consulta.SelCampo(Albentrada_hisgastos.AHG_factura_comercial, "FC")
        consulta.WheCampo(Albentrada_hisgastos.AHG_idalbaran, "=", idAlbaran)
        dt = Albentrada_hisgastos.MiConexion.ConsultaSQL(consulta.SQL)
        GridGastosHistorico.DataSource = dt

    End Sub




    Private Sub BConsultar_Click(sender As System.Object, e As System.EventArgs)
        CargaGrid()
    End Sub

    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub
End Class