Imports DevExpress.XtraEditors

Public Class FrmHiAlbCompra
    Inherits FrMantenimiento


    Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
    Dim Albentrada_hislineas As New E_AlbEntrada_hislineas(Idusuario, cn)
    Dim Albentrada_hisgastos As New E_albentrada_hisgastos(Idusuario, cn)
    Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
  
    Dim Acreedores As New E_Acreedores(Idusuario, cn)


    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Tiposdegastoagri As New E_TiposdeGastoAgri(Idusuario, cn)
    Dim OrigenGastos As New E_OrigenGastos(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim FamiliasDescuentos As New E_FamiliasDescuentos(Idusuario, cn)
    Dim PventaUsuario As New E_PventaUsuario(Idusuario, cn)
    Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
    Dim CentroRecogida As New E_centrosrecogida(Idusuario, cn)
    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)


    Dim FacturasRecibidas As New E_Facturasrecibidas(Idusuario, cn)


    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Idtarifa As Integer
    Dim DtoMerma As Double




    Private Sub ParametrosFrm()
        EntidadFrm = Albentrada_his


        Dim lc As New List(Of Object)
        ListaControles = lc



        'TxDato15.Autonumerico = True
        LbCentroRec.CL_ControlAsociado = TxDato1
        LbNomCentroRec.CL_ControlAsociado = TxDato1
        CampoClave = 1 ' ultimo campo de la clave

        ParamTx(TxDato15, Albentrada.AEN_Albaran, Lb20, True)
        ParamTx(TxDato1, Albentrada_his.AEH_nmed, Lb20, False)
        ParamTx(TxDato6, Albentrada.AEN_Fecha, Lb9, True)
        ParamTx(TxDato3, Albentrada_his.AEH_idproveedor, Lb3, True)

        ParamTx(TxDato4, Albentrada_hislineas.AHL_idgenero, Lb5, True)
        ParamTx(TxDato13, Albentrada_hislineas.AHL_idcategoria, Lb25, False)
        ParamTx(TxDato5, Albentrada_hislineas.AHL_idenvase, Lb11, False)

        ParamTx(TxDato14, Albentrada_hislineas.AHL_idtipoconfeccion, Lb19, False)
        ParamTx(TxDato16, Albentrada_hislineas.AHL_idmarca, Lb27, False)
        ParamTx(TxDato19, Albentrada_hislineas.AHL_idpalet, Lb31, False)

        ParamTx(TxDato18, Albentrada_hislineas.AHL_palets, Lb28, False)
        ParamTx(TxDato8, Albentrada_hislineas.AHL_bultos, Lb16, False)
        ParamTx(TxDato2, Albentrada_hislineas.AHL_kilos, Lb14, False)
        ParamTx(TxPiezas, Albentrada_hislineas.AHL_piezas, LbPiezas, False)
        ParamTx(TxDato7, Albentrada_hislineas.AHL_precio, Lb2, False)
        ParamTx(Txkbp, Albentrada_hislineas.AHL_tipoprecio, Lb2, False)
        ParamTx(TxDato12, Albentrada_hislineas.AHL_precioenvase, Lb6, False)

        ParamTx(TxDato9, Albentrada_hislineas.AHL_muestreo, Lb30, False)




        AsociarGrid(ClGrid1, TxDato4, TxDato9, Albentrada_hislineas)

        PropiedadesCamposGr(ClGrid1, "AHL_id", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Genero", "Genero", False, 10)
        PropiedadesCamposGr(ClGrid1, "NombreGenero", "NombreGenero", True, 50)
        PropiedadesCamposGr(ClGrid1, "Categoria", "Categoria", True, 10)
        PropiedadesCamposGr(ClGrid1, "Kilos", "Kilos", True, 10, True, "#0.00")
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 10, False, "#0.00")
        PropiedadesCamposGr(ClGrid1, "ImporteGenero", "ImporteGenero", True, 10, True, "#0.00")


        ParamTx(TxDato22, Albentrada_hisgastos.AHG_idgasto, Lb32, True)
        ParamCb_Copia(CbBox2, Albentrada_hisgastos.AHG_tipo, Lb8, Combos.ComboGastos)
        ParamTx(TxDato10, Albentrada_hisgastos.AHG_valor, Lb12, False)
        ParamCb_Copia(CbBox3, Albentrada_hisgastos.AHG_factura_comercial, Lb13, Combos.ComboFacComAgri)
        ParamTx(TxDato11, Albentrada_hisgastos.AHG_idacreedor, Lb7, False)

        AsociarGrid(ClGrid2, TxDato22, TxDato11, Albentrada_hisgastos)

        PropiedadesCamposGr(ClGrid2, "AHG_id", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid2, "Gasto", "Gasto", True, 30)
        PropiedadesCamposGr(ClGrid2, "Valor", "Valor", True, 10, False, "#0.0000")
        PropiedadesCamposGr(ClGrid2, "FC", "Fc", True, 10)
        PropiedadesCamposGr(ClGrid2, "Tipo", "Tipo", True, 10)

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False




        AsociarControles(TxDato15, BtBusca1, Albentrada_his.btBusca, Albentrada_his)
        BtBusca1.CL_Filtro = PventaUsuario.FiltroPventaGrid("PV", "")
        BtBusca1.CL_xCentro = False
        AsociarControles(TxDato3, BtBuscaAgricultor, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb26)

        AsociarControles(TxDato4, BtBuscaGenero, Generos.btBusca, Generos, Generos.GEN_NombreGenero, Lb4)
        AsociarControles(TxDato13, BtBuscaCat, Categorias.bTBuscaEnt, Categorias, Categorias.CAE_CategoriaCalibre, Lb24)

        AsociarControles(TxDato5, BtBuscaEnvase, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb10)

        AsociarControles(TxDato14, BtBuscaTconf, ConfecEnvase.btBusca, ConfecEnvase, ConfecEnvase.CEV_Nombre, Lb17)
        AsociarControles(TxDato16, BtBuscaMarca, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, Lb21)
        AsociarControles(TxDato19, BtBuscaEnvase, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb29)

        AsociarControles(TxDato22, BtBuscaGasto, Tiposdegastoagri.btBusca, Tiposdegastoagri, Tiposdegastoagri.TGA_Nombre, Lb18)
        AsociarControles(TxDato11, BtBuscaAcreedor, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomAcreedor)


        BAnular.Visible = False
        BModificar.Visible = False
        BGuardar.Visible = False

        FiltroEntidad.Add(Albentrada_his.AEH_idempresa.NombreCampo, MiMaletin.IdEmpresaCTB.ToString)

    End Sub

    Public Overrides Sub ControlClave()
        ' componemos la clave



        Dim i As Integer
        '        If TxDato15.Text = "+" Then
        ' LbId.Text = "+"
        ' Else

        i = Albentrada_his.LeerAlb(MiMaletin.Ejercicio.ToString, TxDato15.Text, TxDato1.Text)
        If i > 0 Then
            LbId.Text = i.ToString

        Else

            MsgBox("No se pueden añadir albaranes desde el histórico")
            LbId.Text = ""
            'If MsgBox("Registro inexistente. Desea crear uno nuevo", vbYesNo) = vbYes Then
            '    '                    LbId.Text = Cobros.MaxId
            '    LbId.Text = "+"
            'Else
            '    LbId.Text = ""
            'End If

        End If

        'End If

        If LbId.Text <> "" Then
            CargaLineasGrid()
        End If


    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

        If Albentrada.LeerId(Albentrada_his.AEH_idalbaran.Valor) = True Then
            LbFC.Text = Albentrada.AEN_TipoFCS.Valor
            TxDato15.Text = Albentrada.AEN_Albaran.Valor
            TxDato1.Text = Albentrada_his.AEH_nmed.Valor
            TxDato6.Text = Albentrada.AEN_Fecha.Valor
        End If

        ' llenar el grid
        CargaLineasGrid()

        Dim facturaagr As New E_FacturaAgr(Idusuario, cn)
        Dim facturasrecibidas As New E_Facturasrecibidas(Idusuario, cn)
        Select Case LbFC.Text
            Case "F"
                If VaInt(Albentrada_his.AEH_idfacturafirme.Valor) > 0 Then
                    If facturasrecibidas.LeerId(Albentrada_his.AEH_idfacturafirme.Valor) = True Then
                        LbSerie.Text = ""
                        LbNufac.Text = facturasrecibidas.FRR_numerofactura.Valor
                    End If
                End If
            Case Else
                If VaInt(Albentrada_his.AEH_idfactura.Valor) > 0 Then
                    If facturaagr.LeerId(Albentrada_his.AEH_idfactura.Valor) = True Then
                        LbSerie.Text = facturaagr.FGR_serie.Valor
                        LbNufac.Text = facturaagr.FGR_numerofactura.Valor
                    End If
                End If
        End Select
        'If VaInt(Albentrada_his.AEH_idfactura.Valor) > 0 Then
        '    If LbFC.Text = "F" Then
        '        If facturasrecibidas.LeerId(Albentrada_his.AEH_idfactura.Valor) = True Then
        '            LbSerie.Text = ""
        '            LbNufac.Text = facturasrecibidas.FRR_numerofactura.Valor
        '        End If
        '    Else
        '        If facturaagr.LeerId(Albentrada_his.AEH_idfactura.Valor) = True Then
        '            LbSerie.Text = facturaagr.FGR_serie.Valor
        '            LbNufac.Text = facturaagr.FGR_numerofactura.Valor
        '        End If
        '    End If
        'End If



    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)

        If gr Is ClGrid2 Then
            LbNuFactura.Text = ""
        End If

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(Grid As ClGrid)

        If Grid Is ClGrid2 Then
            Grid.LineaBloqueada = False
            LbNuFactura.Text = ""
            If VaInt(Albentrada_hisgastos.AHG_idfacturaproveedor.Valor) > 0 Then
                If FacturasRecibidas.LeerId(Albentrada_hisgastos.AHG_idfacturaproveedor.Valor) = True Then
                    Grid.LineaBloqueada = True

                    'Número factura
                    LbNuFactura.Text = FacturasRecibidas.FRR_numero.Valor + " - " + FacturasRecibidas.FRR_numerofactura.Valor

                End If
            End If
        End If

        MyBase.Entidad_a_DatosLin(Grid)
    End Sub

    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean
        If LbId.Text = "+" Then
            LbId.Text = Albentrada_his.MaxId
            If TxDato15.Text = "+" Then
                TxDato15.Text = Albentrada.MaxIdCampa(MiMaletin.Ejercicio, MiMaletin.IdCentro)
            End If
        End If


        Albentrada_hislineas.AHL_idalbhis.Valor = LbId.Text
        Albentrada_hisgastos.AHG_idalbhis.Valor = LbId.Text

        Albentrada_hislineas.AHL_idalbaran.Valor = Albentrada_his.AEH_idalbaran.Valor
        Albentrada_hisgastos.AHG_idalbaran.Valor = Albentrada_his.AEH_idalbaran.Valor


        SqlGrid()
        CalculoTotales()
        r = MyBase.GuardarLineas(Gr)
        Return r

    End Function


    Public Overrides Sub DespuesdeAnular()
        Dim c As New Contabilizacion.clAsientos
        MyBase.DespuesdeAnular()
    End Sub


    Public Overrides Sub Guardar()


     
            MyBase.Guardar()
      
    End Sub


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()


        GrabaGastos()


    End Sub


    Public Overrides Sub DespuesdeCargarLineas(ByVal gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)

    End Sub


    Private Sub CargaLineasGrid()

        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)

        ClGrid2.Nlinea = -1
        Cargalineas(ClGrid2)
        CalculoTotales()

    End Sub


    Private Sub SqlGrid()

        Dim id As String

        If LbId.Text = "+" Then
            id = "-1"
        Else
            id = LbId.Text
        End If
        Dim sql As String
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(Albentrada_hislineas.AHL_id, "")
        CONSULTA.SelCampo(Albentrada_hislineas.AHL_idgenero, "Genero")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "NombreGenero", Albentrada_hislineas.AHL_idgenero)
        CONSULTA.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", Albentrada_hislineas.AHL_idcategoria)
        CONSULTA.SelCampo(Albentrada_hislineas.AHL_bultos, "Bultos")
        CONSULTA.SelCampo(Albentrada_hislineas.AHL_kilos, "Kilos")
        CONSULTA.SelCampo(Albentrada_hislineas.AHL_precio, "Precio")
        CONSULTA.SelCampo(Albentrada_hislineas.AHL_precioenvase, "PrecioEnvase")
        CONSULTA.SelCampo(Albentrada_hislineas.AHL_importegenero, "ImporteGenero")
        CONSULTA.WheCampo(Albentrada_hislineas.AHL_idalbhis, "=", id)
        sql = CONSULTA.SQL
        sql = sql + " order by AHL_id"

        ClGrid1.Consulta = sql


        Dim CONSULTA2 As New Cdatos.E_select

        CONSULTA2.SelCampo(Albentrada_hisgastos.AHG_id, "")
        CONSULTA2.SelCampo(Tiposdegastoagri.TGA_Nombre, "Gasto", Albentrada_hisgastos.AHG_idgasto)
        CONSULTA2.SelCampo(Albentrada_hisgastos.AHG_valor, "Valor")
        CONSULTA2.SelCampo(Albentrada_hisgastos.AHG_factura_comercial, "FC")
        CONSULTA2.SelCampo(Albentrada_hisgastos.AHG_tipo, "Tipo")
        '       CONSULTA2.SelCampo(Albentrada_hisgastos.AHG_importe, "Importe")
        CONSULTA2.WheCampo(Albentrada_hisgastos.AHG_idalbhis, "=", id)
        sql = CONSULTA2.SQL
        sql = sql + " order by AHG_id"

        ClGrid2.Consulta = sql

    End Sub


    Public Overrides Sub BorraPan()

     
        LbFC.Text = ""
        LbSerie.Text = ""
        LbNufac.Text = ""


        MyBase.BorraPan()
        PintaPuntoVenta(MiMaletin.IdPuntoVenta, MiMaletin.IdCentroRecogida, MiMaletin.IdCentro.ToString, "", MiMaletin.Ejercicio.ToString)

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub

    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ' If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString Then
        'MsgBox("no se puede anular el albarán")
        'Exit Sub
        'End If

        If VaInt(Albentrada_his.AEH_idfactura.Valor) > 0 Or VaInt(Albentrada_his.AEH_idfacturafirme.Valor) > 0 Then
            MsgBox("Albarán facturado")
            Exit Sub
        End If



        Dim f As String

        f = Albentrada_his.GastosFacturados(Albentrada_his.AEH_idalbaran.Valor)
        If f <> "" Then
            MsgBox("Gastos " + f + " facturados")
            Exit Sub

        End If

        MyBase.BAnular_Click(sender, e)
    End Sub
    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ' If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString Then
        ' MsgBox("no se puede modificar el albarán")
        ' Exit Sub
        ' End If

        If VaInt(Albentrada_his.AEH_idfactura.Valor) > 0 Or VaInt(Albentrada_his.AEH_idfacturafirme.Valor) > 0 Then
            MsgBox("Albarán facturado")
            Exit Sub
        End If



        'TODO: Ver lista
        'Dim f As String
        'f = Albentrada_his.GastosFacturados(Albentrada_his.AEH_idalbaran.Valor)
        'If f <> "" Then
        '    MsgBox("Gastos " + f + " facturados")
        '    Exit Sub

        'End If

        MyBase.BModificar_Click(sender, e)

    End Sub


    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxDato15.Text = "" And TxDato15.Enabled = True Then
            TxDato15.Text = "+"
            Siguiente(0)
        End If
    End Sub

    Private Sub PintaPuntoVenta(ByVal idpv As String, ByVal idcr As String, ByVal idcentro As String, ByVal asiento As String, ByVal ejercicio As String)

        LbCentroRec.Text = idcr
        If CentroRecogida.LeerId(idcr) = True Then
            LbNomCentroRec.Text = CentroRecogida.CER_Nombre.Valor
        Else
            LbNomCentroRec.Text = ""
        End If

     




    End Sub

    Private Sub CalculoTotales()

        Dim tk As Double
        Dim iventa As Double
        'Dim Importe As Double
        Dim Ienvase As Double


        Dim tb As Double

        'Dim Dt As DataTable = CType(ClGrid1.Grid.DataSource, DataTable)

        'If Not Dt Is Nothing Then
        '    For Each Dr As DataRow In Dt.Rows
        '        Importe = VaDec(Dr("Kilos")) * VaDec(Dr("Precio"))
        '        Importe = Importe + VaDec(Dr("Bultos")) * VaDec(Dr("PrecioEnvase"))
        '        Dr("Importe") = Importe
        '    Next
        'End If
        'ClGrid1.GridView.RefreshData()
        tk = 0
        iventa = 0
        Ienvase = 0

        Dim sql As String
        Dim dt2 As New DataTable
        If VaInt(LbId.Text) = 0 Then Exit Sub

        sql = "Select sum(AHL_kilos) AS TKILOS, sum(AHL_Bultos) AS TBULTOS, Sum(AHL_IMPORTEGENERO) as igenero,sum(AHL_Bultos * AHL_precioenvase) as Ienvase from albentrada_hislineas where AHL_idalbhis=" + LbId.Text
        dt2 = Albentrada_hislineas.MiConexion.ConsultaSQL(sql)
        If Not dt2 Is Nothing Then
            If dt2.Rows.Count > 0 Then

                tk = VaDec(dt2.Rows(0)("TKILOS"))
                tb = VaDec(dt2.Rows(0)("TBULTOS"))
                iventa = VaDec(dt2.Rows(0)("Igenero"))
                Ienvase = VaDec(dt2.Rows(0)("Ienvase"))

            End If


            sql = "Select * from albentrada_hisgastos where AHG_idalbhis=" + LbId.Text
            dt2 = Albentrada_hisgastos.MiConexion.ConsultaSQL(sql)
            Dim i As Double
            Dim gc As Double
            Dim gf As Double

            For Each dr As DataRow In dt2.Rows
                i = 0
                Select Case dr("AHG_tipo")

                    Case "K"
                        i = tk * VaDec(dr("AHG_valor"))
                    Case "B"
                        i = tb * VaDec(dr("AHG_valor"))
                    Case "%"
                        i = iventa * VaDec(dr("AHG_valor")) / 100
                    Case "I"
                        i = VaDec(dr("AHG_valor"))

                End Select

                If dr("AHG_factura_comercial") = "F" Then
                    gf = gf + i
                Else
                    gc = gc + i
                End If

            Next
            LbIventa.Text = Format(iventa + Ienvase, "#,###0.00")
            LbGastosFac.Text = Format(gf, "#,###0.00")
            LbGastosCom.Text = Format(gc, "#,###0.00")

        End If
    End Sub

    Private Sub GrabaGastos()

        Dim tk As Double
        Dim iventa As Double
        Dim ienvase As Double
        Dim tb As Double
        Dim i As Double


        Dim sql As String
        Dim dt2 As New DataTable

        sql = "Select sum(AHL_kilos) AS TKILOS,sum(AHL_Bultos) AS TBULTOS,Sum(AHL_importegenero) as Iventa,sum(AHL_bultos * AHL_precioenvase) as Ienvase from albentrada_hislineas where AHL_idalbhis=" + LbId.Text
        dt2 = Albentrada_hislineas.MiConexion.ConsultaSQL(sql)

        If dt2.Rows.Count > 0 Then

            tk = VaDec(dt2.Rows(0)("TKILOS"))
            tb = VaDec(dt2.Rows(0)("TBULTOS"))
            iventa = VaDec(dt2.Rows(0)("Iventa"))
            ienvase = VaDec(dt2.Rows(0)("Ienvase"))
        End If

        Dim gc As Double
        Dim gf As Double

        sql = "Select * from albentrada_hisgastos where AHG_idalbhis=" + LbId.Text
        dt2 = Albentrada_hisgastos.MiConexion.ConsultaSQL(sql)
        If Not dt2 Is Nothing Then

            For Each dr As DataRow In dt2.Rows
                i = 0
                Select Case dr("AHG_tipo")

                    Case "K"
                        i = tk * VaDec(dr("AHG_valor"))
                    Case "B"
                        i = tb * VaDec(dr("AHG_valor"))
                    Case "%"
                        i = iventa * VaDec(dr("AHG_valor")) / 100
                    Case "I"
                        i = VaDec(dr("AHG_valor"))

                End Select

                If dr("AHG_factura_comercial") = "F" Then
                    gf = gf + i
                Else
                    gc = gc + i
                End If

                If Albentrada_hisgastos.LeerId(dr("AHG_ID").ToString) = True Then
                    Albentrada_hisgastos.AHG_importe.Valor = i.ToString
                    Albentrada_hisgastos.Actualizar()
                End If

            Next
        End If

        If Albentrada_his.LeerId(LbId.Text) = True Then

            Albentrada_his.AEH_importegenero.Valor = iventa.ToString
            Albentrada_his.AEH_baseimponible.Valor = (iventa + ienvase - gf).ToString

            Dim Cuota As Double
            Dim baseret As Double
            Dim iret As Double
            Dim tf As Double

            Cuota = (iventa + ienvase - gf) * VaDec(Albentrada_his.AEH_tipoiva.Valor) / 100
            Albentrada_his.AEH_cuotaiva.Valor = Cuota.ToString
            If Albentrada_his.AEH_tiporet.Valor = "B" Then
                baseret = (iventa + ienvase - gf)
            Else
                baseret = iventa + ienvase - gf + Cuota
            End If
            iret = (baseret * VaDec(Albentrada_his.AEH_poret.Valor) / 100)
            Albentrada_his.AEH_cuotaret.Valor = iret.ToString
            tf = iventa + ienvase - gf + Cuota - iret - gc
            Albentrada_his.AEH_totalalbaran.Valor = tf.ToString
            Albentrada_his.AEH_kilos.Valor = tk.ToString
            Albentrada_his.Actualizar()
        End If
    End Sub

    Private Sub TxDato7_Valida(ByVal edicion As Boolean) Handles TxDato7.Valida
        CalculoTotales()
    End Sub


    Private Sub TxDato10_Valida(ByVal edicion As Boolean) Handles TxDato10.Valida
        CalculoTotales()
    End Sub

    Private Sub TxDato17_Valida(ByVal edicion As Boolean)
        CalculoTotales()

    End Sub

    Private Sub TxDato20_Valida(ByVal edicion As Boolean)
        CalculoTotales()

    End Sub

    Private Sub TxDato23_Valida(ByVal edicion As Boolean)
        CalculoTotales()

    End Sub

    Private Sub TxDato21_Valida(ByVal edicion As Boolean)
        CalculoTotales()

    End Sub

    Private Sub TxDato22_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato22.TextChanged

    End Sub

    Private Sub TxDato22_Valida(ByVal edicion As Boolean) Handles TxDato22.Valida
        If Tiposdegastoagri.LeerId(TxDato22.Text) = True Then
            If OrigenGastos.LeerId(Tiposdegastoagri.TGA_idgrupo.Valor) Then
                BtBuscaAcreedor.CL_Filtro = "TIPO='" + OrigenGastos.ORG_tipo.Valor + "'"
            End If
            If edicion = True Then
                If CbBox2.SelectedValue Is Nothing Then
                    CbBox2.SelectedValue = Tiposdegastoagri.TGA_Tipo.Valor
                End If
                If CbBox3.SelectedValue Is Nothing Then
                    CbBox3.SelectedValue = Tiposdegastoagri.TGA_tipogastofc.Valor
                End If
                If TxDato11.Text = "" Then
                    TxDato11.Text = Tiposdegastoagri.TGA_idacreedor.Valor
                End If
            End If
        End If


    End Sub


    Private Sub TxDato4_Valida(ByVal edicion As Boolean) Handles TxDato4.Valida
        If edicion = True Then
            BtBuscaCat.CL_Filtro = "idfamilia" = Generos.idfamiliagenero
        End If
    End Sub

    
    Private Sub TxDato6_Valida(edicion As System.Boolean) Handles TxDato6.Valida

        If edicion = True Then
            Dim E As String = ControlaFecha(TxDato6.Text)
            If E <> "" Then
                MsgBox(E)
                TxDato6.MiError = True
            End If
        End If

    End Sub
End Class