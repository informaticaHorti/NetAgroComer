Imports DevExpress.XtraEditors


Public Class FrmPedidos
    Inherits FrMantenimiento


    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Clientes_descargas As New E_ClientesDescargas(Idusuario, cn)

    Dim CategoriasComercial As New E_CategoriasComercial(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)

    Dim pedidos As New E_Pedidos(Idusuario, cn)
    Dim pedidos_lineas As New E_Pedidos_lineas(Idusuario, cn)
    Dim pedidos_almacen As New E_pedidos_almacen(Idusuario, cn)
    ' Dim pedidos_mensajes As New E_pedidos_mensajes(Idusuario, cn)
    Dim usuarios As New E_Usuarios(Idusuario, CnComun)

    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
    Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Tiposporte As New E_TiposPorte(Idusuario, cn)
    Dim Moneda As New E_Moneda(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)

    Dim Valorespventa As New E_valorespventa(Idusuario, cn)
    Dim Envasespalets As New E_EnvasesPalets(Idusuario, cn)


    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))

    Dim MiCentro As String
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim _iddomicilio As Integer


    Dim _sqlGenerosF3 As String = Generos.BtBuscaGenerosCliente.CL_ConsultaSql
    Dim _sqlCategoriasF3 As String = CategoriasComercial.BtBuscaComCliente.CL_ConsultaSql
    Dim _sqlConfeccionF3 As String = GenerosSalida.BtBuscaXconfecCliente.CL_ConsultaSql




    Private Sub ParametrosFrm()

        EntidadFrm = pedidos


        Dim lc As New List(Of Object)
        ListaControles = lc



        LbPuntoVenta.CL_ControlAsociado = TxPedido
        LbNomPv.CL_ControlAsociado = TxPedido
        CampoClave = 0 ' ultimo campo de la clave

        ParamTx(TxPedido, pedidos.PED_pedido, LbPedido, True)
        TxPedido.Autonumerico = True
        ParamTx(TxFecha, pedidos.PED_fechapedido, LbFecha, True)
        ParamTx(TxFeSalida, pedidos.PED_fechasalida, LbFesalida, True)
        ParamTx(TxFechaLlegada, pedidos.PED_FechaLlegada, LbFechaLlegada)
        ParamTx(TxCliente, pedidos.PED_idcliente, LbCliente, True)
        ParamTx(TxDomicilio, Nothing, LbDomicilio, False)
        ParamTx(TxTransportista, pedidos.PED_idtransportista, LbTransportista, False)
        ParamTx(TxMatricula, pedidos.PED_matriculacamion, LbMatricula, False)
        ParamTx(TxRemolque, pedidos.PED_matricularemolque, LbRemolque, False)
        ParamTx(TxMovilChofer, pedidos.PED_MovilChofer, LbMovilChofer)
        ParamTx(TxTransporteRapido, pedidos.PED_TransporteRapidoSN, LbTransporteRapido, True, , , , "SN")
        ParamTx(TxReferencia, pedidos.PED_referencia, LbReferencia, False)
        ParamTx(TxTipoPorte, pedidos.PED_idporte, LbTipoPorte, True)
        ParamTx(TxDivisa, pedidos.PED_iddivisa, LbDivisa, False)
        ParamTx(TxValorCambio, pedidos.PED_valorcambio, LbValorCambio, False)


        ParamTx(TxBESTELLNR, pedidos.PED_BESTELLNR, LbBestellnr, False)
        ParamTx(TxObs1, pedidos.PED_obs1, Lb8, False)
        ParamTx(TxObs2, pedidos.PED_obs2, Lb8, False)
        ParamTx(TxObs3, pedidos.PED_obs3, Lb8, False)


        ParamTx(TxGenero, pedidos_lineas.PEL_idgenero, LbGenero, True)
        ParamTx(TxCategoria, pedidos_lineas.PEL_idcategoria, LbCategoria, True)
        ParamTx(TxNomCategoria, pedidos_lineas.PEL_nomcate, LbCategoria, True)


        ParamTx(TxConfeccion, pedidos_lineas.PEL_idtipoconfeccion, LbConfeccion, True)
        ParamTx(TxPresentacion, pedidos_lineas.PEL_idgensal, LbPresentacion, True)

        ParamTx(TxTipoPalet, pedidos_lineas.PEL_idtipopalet, LbTipopalet, True)
        ParamTx(TxMarca, pedidos_lineas.PEL_idmarca, LbMarca, True)

        ParamTx(TxPalets, pedidos_lineas.PEL_palets, LbPalets, True)
        ParamTx(TxBulPalet, pedidos_lineas.PEL_bultospalet, LbBulpalet, True)
        ParamTx(TxBultos, pedidos_lineas.PEL_Bultos, LbBultos, True, Cdatos.TiposCampo.Importe)
        ParamTx(TxKilBul, pedidos_lineas.PEL_kilosbulto, LbKibul, True)
        ParamTx(TxKilos, pedidos_lineas.PEL_kilos, LbKilos, True, Cdatos.TiposCampo.Importe)
        ParamTx(TxKilosBrutos, pedidos_lineas.PEL_KilosBrutos, LbKilosbrutos, True, Cdatos.TiposCampo.Importe)
        ParamTx(TxPiezaBul, pedidos_lineas.PEL_piezasbulto, LbPiezaBul, False)
        ParamTx(TxPiezas, pedidos_lineas.PEL_piezas, LbPiezas, False, Cdatos.TiposCampo.Importe)
        ParamTx(TxPrecio, pedidos_lineas.PEL_precio, LbPrecio, False)
        ParamTx(TxKBP, pedidos_lineas.PEL_tipoprecio, LbKBP, True, , , , "KBP")

        ParamTx(TxObslote, pedidos_lineas.PEL_obslote, LbObsLote, False)
        ParamTx(TxObsCon1, pedidos_lineas.PEL_obsconfec1, LbObsConfeccion, False)
        ParamTx(TxObscon2, pedidos_lineas.PEL_obsconfec2, LbObsConfeccion, False)
        ParamTx(TxCalidad, pedidos_lineas.PEL_calidad, LbCalidad, False)
        ParamTx(TxMaxDias, pedidos_lineas.PEL_maxdias, LbMaxdias, False)
        ParamTx(TxReserva, pedidos_lineas.PEL_reservapalets, LbReserva, False)


        ParamTx(TxAlma1, Nothing, LbAlmacen, False)
        ParamTx(TxPalet1, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxAlma2, Nothing, LbAlmacen, False, Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPalet2, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxAlma3, Nothing, LbAlmacen, False, Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPalet3, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxAlma4, Nothing, LbAlmacen, False, Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPalet4, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxProveedor, pedidos_lineas.PEL_idproveedor, LbProveedor, False)
        ParamTx(TxPaletProveedor, pedidos_lineas.PEL_paletsproveedor, LbPaletProveedor, False)
        ParamTx(TxPrecioProveedor, pedidos_lineas.PEL_precioproveedor, LbPrecioProveedor, False)

        ParamTx(TxObsEti1, pedidos_lineas.PEL_obseti1, LbObsEtiquetas, False)
        ParamTx(TxObseti2, pedidos_lineas.PEL_obseti2, LbObsEtiquetas, False)

        ParamChk(ChkGeneraTrabajo, pedidos_lineas.PEL_generatrabajo, "S", "N")
        ParamChk(ChkRequierAprobacion, pedidos_lineas.PEL_requiereaprobacion, "S", "N")

        ParamTx(TxMarcaEti, pedidos_lineas.PEL_idmarcaetiqueta, LbMarcaEti, False)
        ParamTx(TxMarcaMaterial, pedidos_lineas.PEL_idmarcamaterial, LbMarcaMaterial, False)





        AsociarControles(TxPedido, BtBuscaPedido, pedidos.btBusca, pedidos)

        AsociarGrid(ClGrid1, TxGenero, TxMarcaMaterial, pedidos_lineas)

        PropiedadesCamposGr(ClGrid1, "PEL_idlinea", "PEL_idlinea", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Presentacion", "Presentacion", True, 150)
        PropiedadesCamposGr(ClGrid1, "Categoria", "Categoria", True, 50)
        PropiedadesCamposGr(ClGrid1, "Marca", "Marca", True, 50)
        PropiedadesCamposGr(ClGrid1, "TipoPalet", "TipoPalet", True, 50)
        PropiedadesCamposGr(ClGrid1, "Palets", "Palets", True, 15, True)
        PropiedadesCamposGr(ClGrid1, "Bultos", "Bultos", True, 15, True)
        PropiedadesCamposGr(ClGrid1, "Coeficiente", "Coef.Carga", True, 25, True, "#,##0.00", "{0:n2}")
        PropiedadesCamposGr(ClGrid1, "PaletsTransporte", "Palets Trans.", True, 25, True, "#,##0.00", "{0:n2}")



        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False





        AsociarControles(TxCliente, BtBuscaCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomCliente)
        BtBuscaCliente.CL_BuscarEnTodosLosCampos = True

        AsociarControles(TxDomicilio, BtBuscaDestino, Clientes_descargas.btBusca, Clientes_descargas)

        AsociarControles(TxGenero, BtBuscaGenero, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomGenero)
        AsociarControles(TxCategoria, BtBuscaCat, CategoriasComercial.BtBuscaCom, CategoriasComercial, Nothing, Nothing)
        AsociarControles(TxMarca, BtBuscaMarca, Marcas.BtBuscaXconfec, Marcas, Marcas.MAR_Nombre, LbNomMarca)
        '        AsociarControles(TxConfeccion, BtBuscaTconf, GenerosSalida.btBusca, ConfecEnvase, ConfecEnvase.CEV_Nombre, LbNomConfeccion)

        'TODO: Juanjo, ver con Miguel
        AsociarControles(TxPresentacion, BtBuscaTconf, GenerosSalida.BtBuscaXconfec, GenerosSalida, GenerosSalida.GES_Nombre, LbNomPresenta)
        'AsociarControles(TxConfeccion, BtBuscaTconf, ConfecEnvase.btBusca, ConfecEnvase, ConfecEnvase.CEV_Nombre, LbNomConfeccion)

        AsociarControles(TxPresentacion, BtBuscaPresenta, GenerosSalida.BtBuscaXconfec, GenerosSalida, GenerosSalida.GES_Nombre, LbNomPresenta)
        AsociarControles(TxTipoPalet, BtBuscaTpalet, ConfecPalet.btBusca, ConfecPalet, ConfecPalet.CPA_Nombre, LbNomTpalet)

        AsociarControles(TxTipoPorte, BtBuscaPorte, Tiposporte.btBusca, Tiposporte, Tiposporte.TPO_Nombre, LbNomPorte)
        AsociarControles(TxDivisa, BtBuscaDivisa, Moneda.btBusca, Moneda, Moneda.MON_Nombre, LbNomDivisa)
        '    AsociarControles(TxDato_11, BtBuscaConfec, GenerosSalida.btBusca, ConfecEnvase, ConfecEnvase.CEV_Nombre, Lb24)
        '    AsociarControles(TxDato2, BtBusca2, GenerosSalida.BtBuscaXconfec, GenerosSalida, GenerosSalida.GES_Nombre, Lb5)

        AsociarControles(TxTransportista, BtBuscaTransportista, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomTransporte)

        AsociarControles(TxAlma1, BtBuscaAlm1, PuntoVenta.btBusca, PuntoVenta, PuntoVenta.Nombre, LbNomAlm1)
        AsociarControles(TxAlma2, BtBuscaAlm2, PuntoVenta.btBusca, PuntoVenta, PuntoVenta.Nombre, LbNomAlm2)
        AsociarControles(TxAlma3, BtBuscaAlm3, PuntoVenta.btBusca, PuntoVenta, PuntoVenta.Nombre, LbNomAlm3)
        AsociarControles(TxAlma4, BtBuscaAlm4, PuntoVenta.btBusca, PuntoVenta, PuntoVenta.Nombre, LbNomAlm4)

        AsociarControles(TxProveedor, BtBuscaProveedor, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNomPro)

        AsociarControles(TxMarcaEti, BtBuscaMarcaEti, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, LbNomMarcaEti)
        AsociarControles(TxMarcaMaterial, BtBuscaMarcaMaterial, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, LbNomMarcaMat)


        BtBuscaTransportista.CL_Filtro = "TIPO='PV'"

        '  BtBuscaMarca.CL_Filtro = "Env='S'"
        BtBuscaMarcaMaterial.CL_Filtro = "Mat='S'"
        BtBuscaMarcaEti.CL_Filtro = "Eti='S'"


        ' BotonesAvance1.Mientidad = EntidadFrm
        ' BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        ' BotonesAvance1.Formulario = Me

        tt.SetToolTip(BtNuevo, "Nuevo")
        tt.SetToolTip(btImportarDatosPedido, "Importar datos de un pedido previo")

        FiltroEntidad.Add(pedidos.PED_idcentro.NombreCampo, MiMaletin.IdCentro.ToString)
        FiltroEntidad.Add(pedidos.PED_ejercicio.NombreCampo, MiMaletin.Ejercicio.ToString)

    End Sub

    Public Overrides Sub ControlClave()
        ' componemos la clave

        Dim i As Integer
        If TxPedido.Text = "+" Then
            LbId.Text = "+"
        Else
            i = pedidos.LeerPedido(Lbejer.Text, MiCentro, TxPedido.Text)
            If i > 0 Then
                LbId.Text = i.ToString

            Else
                If MsgBox("Registro inexistente. Desea crear uno nuevo", vbYesNo) = vbYes Then
                    '                    LbId.Text = Cobros.MaxId
                    LbId.Text = "+"
                Else
                    LbId.Text = ""
                End If

            End If

        End If

        If LbId.Text <> "" Then
            CargaLineasGrid()
        End If

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

        PintaPuntoVenta(pedidos.PED_idpuntoventa.Valor)
        Lbejer.Text = pedidos.PED_ejercicio.Valor
        _iddomicilio = VaInt(pedidos.PED_iddestino.Valor)
        If _iddomicilio > 0 Then
            If Clientes_descargas.LeerId(_iddomicilio.ToString) = True Then
                TxDomicilio.Text = Clientes_descargas.CLD_numero.Valor
                LbNomDestino.Text = Clientes_descargas.CLD_Domicilio.Valor
            End If
        End If


        ' llenar el grid
        CargaLineasGrid()


        RevisaCliente()

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)

        LbTotalPalets.Text = ""
        LbNomMarcaEti.Text = ""
        LbNomMarcaMat.Text = ""
        LbNomAlm1.Text = ""
        LbNomAlm2.Text = ""
        LbNomAlm3.Text = ""
        LbNomAlm4.Text = ""
        LbNomPro.Text = ""

        LbCoeficiente.Text = ""

        MyBase.Entidad_a_DatosLin(Grid)

        Dim indice As Integer = ClGrid1.GridView.FocusedRowHandle
        Dim row As DataRow = ClGrid1.GridView.GetDataRow(indice)

        If Not IsNothing(row) Then
            LbCoeficiente.Text = (row("Coeficiente").ToString() & "").Trim
        End If

        Cargalineasalmacen(pedidos_lineas.PEL_idlinea.Valor)
        SumaPaletsAlmacen()

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean


        If Val(LbTotalPalets.Text) <> Val(TxPalets.Text) Then
            MsgBox("Error en palets")
            Return False
        End If


        If LbId.Text = "+" Then
            LbId.Text = pedidos.MaxId
            If TxPedido.Text = "+" Then
                TxPedido.Text = pedidos.MaxIdCampa(Val(Lbejer.Text), Val(MiCentro))
            End If
        End If

        pedidos.PED_ejercicio.Valor = Lbejer.Text
        pedidos.PED_idpuntoventa.Valor = LbPuntoVenta.Text
        pedidos.PED_idcentro.Valor = MiCentro
        pedidos.PED_iddestino.Valor = _iddomicilio.ToString


        If (pedidos_lineas.PEL_calidad.Valor & "").Trim = "" Then pedidos_lineas.PEL_calidad.Valor = "B"
        pedidos_lineas.PEL_idpedido.Valor = LbId.Text

        pedidos_lineas.PEL_PaletsTransporte.Valor = VaDec(TxPalets.Text) * VaDec(LbCoeficiente.Text)


        SqlGrid()
        r = MyBase.GuardarLineas(Gr)
        'CalculoTotales()

        Return r

    End Function


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()


        'If VaInt(LbId.Text) > 0 Then
        '    GeneraLineasClientes(LbId.Text)
        'End If


    End Sub


    Private Sub CargaLineasGrid()
        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)

        'CalculoTotales()
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
        Dim Dt As New DataTable


        CONSULTA.SelCampo(pedidos_lineas.PEL_idlinea, "PEL_idlinea")
        '       CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Producto", pedidos_lineas.PEL_idgenero)
        CONSULTA.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", pedidos_lineas.PEL_idgensal)
        CONSULTA.SelCampo(pedidos_lineas.PEL_nomcate, "Categoria")
        CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", pedidos_lineas.PEL_idmarca)
        CONSULTA.SelCampo(ConfecPalet.CPA_Nombre, "TipoPalet", pedidos_lineas.PEL_idtipopalet)
        CONSULTA.SelCampo(pedidos_lineas.PEL_palets, "Palets")
        CONSULTA.SelCampo(pedidos_lineas.PEL_Bultos, "Bultos")
        CONSULTA.SelCampo(ConfecPalet.CPA_Coeficiente, "Coeficiente")
        CONSULTA.SelCampo(pedidos_lineas.PEL_PaletsTransporte, "PaletsTransporte")


        CONSULTA.WheCampo(pedidos_lineas.PEL_idpedido, "=", id)
        sql = CONSULTA.SQL
        sql = sql + " order by PEL_idlinea"



        ClGrid1.Consulta = sql


    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString Then
            MsgBox("no se puede modificar el pedido")
            Exit Sub
        End If

        MyBase.BAnular_Click(sender, e)
    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString Then
            MsgBox("no se puede modificar el pedido")
            Exit Sub
        End If

        MyBase.BModificar_Click(sender, e)

    End Sub


    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNuevo.Click
        If TxPedido.Text = "" And TxPedido.Enabled = True Then
            TxPedido.Text = "+"
            Siguiente(0)
        End If
    End Sub


    Private Sub PintaPuntoVenta(ByVal idpv As String)
        LbPuntoVenta.Text = idpv

        If PuntoVenta.LeerId(idpv) = True Then
            LbNomPv.Text = PuntoVenta.Nombre.Valor
            MiCentro = PuntoVenta.IdCentro.Valor
        Else
            LbNomPv.Text = ""
            MiCentro = ""
        End If

    End Sub


    Public Overrides Sub Borralin(gr As ClGrid)
        MyBase.Borralin(gr)

        LbTotalPalets.Text = ""
        LbNomMarcaEti.Text = ""
        LbNomMarcaMat.Text = ""
        LbNomAlm1.Text = ""
        LbNomAlm2.Text = ""
        LbNomAlm3.Text = ""
        LbNomAlm4.Text = ""
        LbNomPro.Text = ""

        LbCoeficiente.Text = ""

        ChkGeneraTrabajo.CheckState = CheckState.Checked

        TxKilosBrutos.ReadOnly = True

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        'Log("Terminado borrapan clase base")


        PintaPuntoVenta(MiMaletin.IdPuntoVenta)
        Lbejer.Text = MiMaletin.Ejercicio

        ChkGeneraTrabajo.Checked = True

        TxKilosBrutos.ReadOnly = True

    End Sub


    Public Overrides Sub Guardar()

        pedidos.PED_idpuntoventa.Valor = LbPuntoVenta.Text
        pedidos.PED_ejercicio.Valor = Lbejer.Text
        pedidos.PED_idcentro.Valor = MiCentro

        Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
        Dim IdDomicilio As Integer = ClientesDescargas.LeerDomi(TxCliente.Text, TxDomicilio.Text)
        If IdDomicilio > 0 Then
            pedidos.PED_iddestino.Valor = IdDomicilio
        End If


        MyBase.Guardar()

    End Sub


    Private Sub TxGenero_Valida(ByVal edicion As Boolean) Handles TxGenero.Valida

        FiltroConfeccion()

        If edicion = True Then

            BtBuscaCat.CL_Filtro = ""
            If Generos.LeerId(TxGenero.Text) = True Then
                BtBuscaCat.CL_Filtro = "idfamilia=" + Generos.idfamiliagenero
            End If

            If TxTipoPalet.Text.Trim = "" Then

                Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
                Dim IdDomicilio As Integer = ClientesDescargas.LeerDomi(VaInt(TxCliente.Text), VaInt(TxDomicilio.Text))
                If IdDomicilio > 0 Then
                    If ClientesDescargas.LeerId(IdDomicilio) Then
                        If VaInt(ClientesDescargas.CLD_IdConfecPalet.Valor) > 0 Then
                            TxTipoPalet.Text = ClientesDescargas.CLD_IdConfecPalet.Valor
                            TxTipoPalet.Validar(True)
                        End If
                    End If

                End If

            End If

        End If


    End Sub


    Private Sub TxDato_11_Valida(ByVal edicion As Boolean) Handles TxConfeccion.Valida

        FiltroConfeccion()

        If ConfecEnvase.LeerId(TxConfeccion.Text) = True Then
            LbNomConfeccion.Text = ConfecEnvase.CEV_Nombre.Valor
        Else
            If edicion = True Then
                TxConfeccion.MiError = True
                Exit Sub
            End If
        End If

        If edicion = True Then
            Dim dt As New DataTable
            dt = GenerosSalida.LeerGensalida(TxGenero.Text, TxConfeccion.Text)
            If Not dt Is Nothing Then
                If dt.Rows.Count = 1 And TxPresentacion.Text = "" Then
                    TxPresentacion.Text = dt.Rows(0)("GES_idgensal").ToString
                End If
            End If
        End If


        If edicion Then
            CalculoKilosBrutos()
        End If

    End Sub


    Private Sub TxPresentacion_Valida(ByVal edicion As Boolean) Handles TxPresentacion.Valida

        If TxPresentacion.Text <> "" Then
            BtBuscaMarca.CL_Filtro = "idpresentacion=" + TxPresentacion.Text
        End If

        If GenerosSalida.LeerId(TxPresentacion.Text) = True Then

            If GenerosSalida.GES_pedirmarcaeti.Valor = "S" Then
                TxMarcaEti.ClParam.Obligatorio = True
            Else
                TxMarcaEti.ClParam.Obligatorio = False
            End If
            If GenerosSalida.GES_pedirmarcamat.Valor = "S" Then
                TxMarcaMaterial.ClParam.Obligatorio = True
            Else
                TxMarcaMaterial.ClParam.Obligatorio = False
            End If


            TxConfeccion.Text = GenerosSalida.GES_Idconfec.Valor
            TxConfeccion.Validar(False)



            If TxPresentacion.HaCambiado = True Then


                If VaInt(TxGenero.Text) <> VaInt(GenerosSalida.GES_IdGenero.Valor) Then
                    MsgBox("No coincide el genero")
                    TxPresentacion.MiError = True
                End If

                If VaInt(TxConfeccion.Text) <> VaInt(GenerosSalida.GES_Idconfec.Valor) Then
                    MsgBox("No coincide la confeccion")
                    TxPresentacion.MiError = True
                End If

                If GenerosSalida.GES_Activo.Valor = "N" Then
                    MsgBox("No activo")
                    TxPresentacion.MiError = True
                End If

                If Not TxPresentacion.MiError Then

                    TxKilBul.Text = VaDec(GenerosSalida.GES_KilosXBulto.Valor).ToString("#,##0.00")
                    TxKilBul.Validar(True)

                    TxPiezaBul.Text = VaInt(GenerosSalida.GES_PiezasXBulto.Valor).ToString
                    TxPiezaBul.Validar(True)


                    If TxMarca.Text = "" Then
                        If VaInt(GenerosSalida.GES_idmarcaenvase.Valor) > 0 Then
                            TxMarca.Text = GenerosSalida.GES_idmarcaenvase.Valor
                            TxMarca.Validar(True)
                        End If
                    End If

                    If TxMarcaMaterial.Text = "" Then
                        If VaInt(GenerosSalida.GES_idmarcamaterial.Valor) Then
                            TxMarcaMaterial.Text = GenerosSalida.GES_idmarcamaterial.Valor
                            TxMarcaMaterial.Validar(True)
                        End If
                    End If

                    If TxMarcaEti.Text = "" Then
                        If VaInt(GenerosSalida.GES_idmarcaetiqueta.Valor) > 0 Then
                            TxMarcaEti.Text = GenerosSalida.GES_idmarcaetiqueta.Valor
                            TxMarcaEti.Validar(True)
                        End If
                    End If


                End If

            End If

        End If

    End Sub


    Private Sub TxDato_19_Valida(ByVal edicion As Boolean) Handles TxCategoria.Valida
        FiltroConfeccion()
        If edicion = True Then
            If CategoriasComercial.LeerId(TxCategoria.Text) = True Then
                TxNomCategoria.Text = CategoriasComercial.CAC_Nombre.Valor
            End If
        End If
    End Sub


    Private Sub TxDato_21_Valida(ByVal edicion As Boolean) Handles TxMarca.Valida
        If edicion = True Then
        End If
    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirPedidoCliente(LbId.Text, TipoImpresion.Preliminar)
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirPedidoCliente(LbId.Text, TipoImpresion.ImpresoraPorDefecto)
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar3()
        MyBase.BotonAuxiliar3()


        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirPedidoProveedor(LbId.Text, TipoImpresion.Preliminar)
        End If

    End Sub


    Private Sub FrmPedidos_Load(sender As Object, e As System.EventArgs) Handles Me.Load

      


        BTaux1.Visible = True
        BTaux1.Text = "Imprimir"
        BTaux1.Image = PictureBox1.Image

        BtAux2.Visible = True
        BtAux2.Text = "I.Directa"
        BtAux2.Image = PictureBox2.Image

        BtAux3.Visible = True
        BtAux3.Text = "I. Pedidos Prov."
        BtAux3.Image = PictureBox1.Image
        BtAux3.Width = 110

        Button1.Text = "Proforma"
        Button1.Image = PictureBox1.Image
        Button1.Visible = True

        Dim BTaux4 As New ClButton
        BTaux4.TextAlign = ContentAlignment.BottomCenter
        BTaux4.ImageAlign = ContentAlignment.TopCenter
        BTaux4.Text = "Ped.Cliente"
        BTaux4.Image = PictureBox2.Image
        BTaux4.Size = BtAux3.Size
        BTaux4.Dock = DockStyle.Right
        BTaux4.BackColor = BtAux2.BackColor
        

        Panel1.Controls.Add(BTaux4)

        BTaux4.BringToFront()

    End Sub


    Private Sub TxDomicilio_Valida(edicion As Boolean) Handles TxDomicilio.Valida
        If TxDomicilio.Text = "" Then
            TxDomicilio.Text = "1"
        End If
        _iddomicilio = Clientes_descargas.LeerDomi(TxCliente.Text, TxDomicilio.Text)
        If _iddomicilio > 0 Then

            If Clientes_descargas.LeerId(_iddomicilio) = True Then

                LbNomDestino.Text = Clientes_descargas.CLD_Domicilio.Valor
                If edicion = True Then
                    TxTipoPorte.Text = Clientes_descargas.CLD_idtipoporte.Valor
                End If

                If edicion Then
                    If TxTransportista.Text.Trim = "" Then
                        Dim IdTransportista As String = Clientes_descargas.CLD_IdTransportista.Valor
                        If VaInt(IdTransportista) > 0 Then
                            TxTransportista.Text = Clientes_descargas.CLD_IdTransportista.Valor
                            TxTransportista.Validar(True)
                        End If
                    End If
                End If

                If TxTransporteRapido.Text = "" Then
                    Dim TransporteRapido As String = "N"
                    If (Clientes_descargas.CLD_TransporteRapidoSN.Valor & "").Trim.ToUpper <> "" Then
                        TxTransporteRapido.Text = (Clientes_descargas.CLD_TransporteRapidoSN.Valor & "").Trim
                    End If
                End If

            End If
        Else
            TxDomicilio.MiError = True
            MsgBox("Domicilio inexistente")
        End If
    End Sub


    Private Sub TxCliente_Valida(edicion As Boolean) Handles TxCliente.Valida

        BtBuscaDestino.CL_Filtro = "IDCLIENTE=" + TxCliente.Text

        If edicion Then

            RevisaCliente()

            If TxDivisa.Text.Trim = "" Then
                TxDivisa.Text = Clientes.CLI_Iddivisa.Valor
                TxDivisa.Validar(edicion)
            End If
            
        End If


    End Sub


    Private Sub RevisaCliente()

        Dim Clientes As New E_Clientes(Idusuario, cn)
        If VaInt(TxCliente.Text) > 0 Then
            If Clientes.LeerId(TxCliente.Text) Then

                Dim Actualizado As String = (Clientes.CLI_DatosActualizadosSN.Valor & "").Trim.ToUpper
                Dim Bloqueado As String = (Clientes.CLI_Bloqueo.Valor & "").Trim.ToUpper

                If Actualizado <> "S" Then
                    XtraMessageBox.Show("DATOS DE CLIENTE NO ACTUALIZADOS," & vbCrLf & "POR FAVOR, REVISAR", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

                If Bloqueado = "S" Then
                    XtraMessageBox.Show("CLIENTE BLOQUEADO" & vbCrLf & Clientes.CLI_Bloqueocausa.Valor, "CLIENTE BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TxCliente.MiError = True
                End If

            End If
        End If

    End Sub


    Public Overrides Sub DespuesdeGuardarLinea(gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)

        GuardarPaletsAlmacen()

    End Sub


    Private Sub GuardarPaletsAlmacen()

        Dim idlineapedido As Integer
        idlineapedido = VaInt(pedidos_lineas.PEL_idlinea.Valor)
        If idlineapedido > 0 Then
            pedidos_almacen.Borralineas(idlineapedido)

            CreaLineaAlmacen(idlineapedido, TxAlma1.Text, TxPalet1.Text)
            CreaLineaAlmacen(idlineapedido, TxAlma2.Text, TxPalet2.Text)
            CreaLineaAlmacen(idlineapedido, TxAlma3.Text, TxPalet3.Text)
            CreaLineaAlmacen(idlineapedido, TxAlma4.Text, TxPalet4.Text)

        End If

    End Sub


    Private Sub CreaLineaAlmacen(idlineapedido As Integer, idalmacen As String, palet As String)

        If VaInt(idalmacen) > 0 And VaDec(palet) > 0 Then
            pedidos_almacen.VaciaEntidad()
            Dim id As Integer = pedidos_almacen.MaxId
            pedidos_almacen.PAC_id.Valor = id
            pedidos_almacen.PAC_idlineapedido.Valor = idlineapedido.ToString
            pedidos_almacen.PAC_idalmacen.Valor = idalmacen
            pedidos_almacen.PAC_palets.Valor = palet
            pedidos_almacen.Insertar()
        End If
    End Sub


    Private Sub Cargalineasalmacen(IdlineaPedido As Integer)
        Dim l As Integer
        If IdlineaPedido > 0 Then
            TxAlma1.Text = ""
            TxAlma2.Text = ""
            TxAlma3.Text = ""
            TxAlma4.Text = ""

            TxPalet1.Text = ""
            TxPalet2.Text = ""
            TxPalet3.Text = ""
            TxPalet4.Text = ""


            Dim sql As String = "Select PAC_IDALMACEN as idalmacen, PAC_PALETS as palets FROM pedidos_almacen where PAC_idlineapedido=" + IdlineaPedido.ToString
            Dim dt As DataTable = pedidos_almacen.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                For Each rw In dt.Rows
                    l = l + 1
                    Select Case l
                        Case 1
                            TxAlma1.Text = rw("idalmacen").ToString
                            TxPalet1.Text = rw("palets").ToString
                            TxAlma1.Validar(False)
                        Case 2
                            TxAlma2.Text = rw("idalmacen").ToString
                            TxPalet2.Text = rw("palets").ToString
                            TxAlma2.Validar(False)
                        Case 3
                            TxAlma3.Text = rw("idalmacen").ToString
                            TxPalet3.Text = rw("palets").ToString
                            TxAlma3.Validar(False)

                        Case 4
                            TxAlma4.Text = rw("idalmacen").ToString
                            TxPalet4.Text = rw("palets").ToString
                            TxAlma4.Validar(False)


                    End Select



                Next
            End If
        End If
    End Sub

    Private Sub CalculoPiezas()
        If VaInt(TxBulPalet.Text) > 0 Then
            TxBultos.Text = Format(VaInt(TxPalets.Text) * VaInt(TxBulPalet.Text), "#,###")
        End If
        If VaInt(TxKilBul.Text) > 0 Then
            TxKilos.Text = Format(VaInt(TxBultos.Text) * VaDec(TxKilBul.Text), "#,###")
        End If
        If VaInt(TxPiezaBul.Text) > 0 Then
            TxPiezas.Text = Format(VaInt(TxBultos.Text) * VaInt(TxPiezaBul.Text), "#,###")
        End If
    End Sub


    Private Sub TxPalets_Valida(edicion As Boolean) Handles TxPalets.Valida

        If edicion = True Then

            CalculoPiezas()

            If TxBulPalet.Text = "" Then
                Dim MaxBul As Integer

                MaxBul = Envasespalets.MaxBultosPalet(TxConfeccion.Text, TxTipoPalet.Text)
                If MaxBul > 0 Then
                    TxBulPalet.Text = MaxBul.ToString
                End If

            End If


            CalculoKilosBrutos()

        End If

        SumaPaletsAlmacen()

        If VaInt(LbTotalPalets.Text) = 0 Then

            TxAlma1.Text = MiCentro
            TxPalet1.Text = TxPalets.Text
            If TxCalidad.Text = "" Then TxCalidad.Text = Clientes_descargas.CLD_calidad.Valor
            If TxMaxDias.Text = "" Then TxMaxDias.Text = Clientes_descargas.CLD_maxdias.Valor
            If TxReserva.Text = "" Then TxReserva.Text = Clientes_descargas.CLD_reservapalets.Valor

        End If



    End Sub


    Private Sub TxBulPalet_Valida(edicion As Boolean) Handles TxBulPalet.Valida

        If edicion = True Then

            Dim MaxBul As Integer
            MaxBul = Envasespalets.MaxBultosPalet(TxConfeccion.Text, TxTipoPalet.Text)

            If MaxBul > 0 And VaInt(TxBulPalet.Text) > MaxBul Then
                MsgBox("Bultos incorrectos para este palet")
                TxBulPalet.MiError = True
            End If

            CalculoPiezas()
            CalculoKilosBrutos()

        End If

    End Sub


    Private Sub TxBultos_Valida(edicion As Boolean) Handles TxBultos.Valida

        If edicion = True Then
            CalculoPiezas()
            CalculoKilosBrutos()
        End If

    End Sub


    Private Sub TxKilBul_Valida(edicion As Boolean) Handles TxKilBul.Valida

        If edicion = True Then
            CalculoPiezas()
            CalculoKilosBrutos()
        End If

    End Sub


    Private Sub TxKilos_Valida(edicion As Boolean) Handles TxKilos.Valida

        If edicion = True Then
            CalculoPiezas()
            CalculoKilosBrutos()
        End If

    End Sub


    Private Sub TxPiezaBul_Valida(edicion As Boolean) Handles TxPiezaBul.Valida

        If edicion = True Then
            CalculoPiezas()
        End If

    End Sub


    Private Sub CalculoKilosBrutos()

        Dim KilosNetos As Decimal = VaDec(TxKilos.Text)
        Dim Bultos As Decimal = VaDec(TxBultos.Text)

        Dim KilosBrutos As Decimal = pedidos.ObtenerKilosBrutos(KilosNetos, Bultos, TxConfeccion.Text, TxTipoPalet.Text)
        TxKilosBrutos.Text = VaInt(KilosBrutos).ToString("#,###")

    End Sub


    Private Sub TxDivisa_Valida(edicion As Boolean) Handles TxDivisa.Valida

        If edicion = True Then

            If VaInt(TxDivisa.Text) = 0 Then
                TxDivisa.Text = "1"
                TxDivisa.Validar(True)
            End If

            If TxValorCambio.Text.Trim = "" Then TxValorCambio.Text = VaDec(Moneda.MON_Cambio.Valor).ToString("#,##0.000000")

        End If

    End Sub


    Private Sub TxValorCambio_Valida(edicion As Boolean) Handles TxValorCambio.Valida

        If edicion = True Then
            If VaInt(TxValorCambio.Text) = 0 Then
                TxValorCambio.Text = "1"
            End If
        End If

    End Sub


    'Private Sub TxKBP_Valida(edicion As Boolean) Handles TxKBP.Valida
    '    If edicion = True Then
    '        If TxKBP.Text <> "P" And TxKBP.Text <> "B" Then
    '            TxKBP.Text = "K"
    '        End If
    '    End If
    'End Sub


    Private Sub TxAlma1_Valida(edicion As Boolean) Handles TxAlma1.Valida
        If edicion = True Then
            If TxAlma1.Text = "" Then
                LbNomAlm1.Text = ""
                TxPalet1.Text = ""
                TxAlma1.Siguiente = TxAlma2.Orden
            End If
        End If
    End Sub


    Private Sub TxAlma2_Valida(edicion As Boolean) Handles TxAlma2.Valida

        If edicion = True Then
            If TxAlma2.Text = "" Then
                LbNomAlm2.Text = ""
                TxPalet2.Text = ""
                TxAlma2.Siguiente = TxAlma3.Orden
            End If
        End If

    End Sub


    Private Sub TxAlma3_Valida(edicion As Boolean) Handles TxAlma3.Valida

        If edicion = True Then
            If TxAlma3.Text = "" Then
                LbNomAlm3.Text = ""
                TxPalet3.Text = ""
                TxAlma3.Siguiente = TxAlma4.Orden
            End If
        End If

    End Sub


    Private Sub TxAlma4_Valida(edicion As Boolean) Handles TxAlma4.Valida
        If edicion = True Then
            If TxAlma4.Text = "" Then
                LbNomAlm4.Text = ""
                TxPalet4.Text = ""
                TxAlma4.Siguiente = TxProveedor.Orden
            End If
        End If

    End Sub

    Private Sub SumaPaletsAlmacen()
        Dim p As Double
        p = VaDec(TxPalet1.Text) + VaDec(TxPalet2.Text) + VaDec(TxPalet3.Text) + VaDec(TxPalet4.Text) + VaDec(TxPaletProveedor.Text)
        LbTotalPalets.Text = p.ToString
    End Sub


    Private Sub TxPalet1_Valida(edicion As Boolean) Handles TxPalet1.Valida
        If edicion = True Then
            SumaPaletsAlmacen()
        End If
    End Sub


    Private Sub TxPalet2_Valida(edicion As Boolean) Handles TxPalet2.Valida
        If edicion = True Then
            SumaPaletsAlmacen()
        End If
    End Sub


    Private Sub TxPalet3_Valida(edicion As Boolean) Handles TxPalet3.Valida
        If edicion = True Then
            SumaPaletsAlmacen()
        End If
    End Sub


    Private Sub TxPalet4_Valida(edicion As Boolean) Handles TxPalet4.Valida
        If edicion = True Then
            SumaPaletsAlmacen()
        End If

    End Sub


    Private Sub TxPaletProveedor_Valida(edicion As Boolean) Handles TxPaletProveedor.Valida
        If edicion = True Then
            SumaPaletsAlmacen()
        End If
    End Sub


    Private Sub FiltroConfeccion()

        If TxGenero.Text <> "" Then

            BtBuscaTconf.CL_Filtro = "idgenero=" + TxGenero.Text
            BtBuscaPresenta.CL_Filtro = "idgenero=" + TxGenero.Text

            If TxCategoria.Text <> "" Then

                BtBuscaTconf.CL_Filtro = "idgenero=" + TxGenero.Text + " AND idcategoria=" + TxCategoria.Text
                BtBuscaPresenta.CL_Filtro = "idgenero=" + TxGenero.Text + " AND idcategoria=" + TxCategoria.Text

                If TxConfeccion.Text <> "" Then
                    BtBuscaPresenta.CL_Filtro = "idgenero=" + TxGenero.Text + " AND idcategoria=" + TxCategoria.Text + " and idconfec=" + TxConfeccion.Text
                End If

            End If

        End If

    End Sub


    Private Sub TxPrecioProveedor_Valida(edicion As Boolean) Handles TxPrecioProveedor.Valida
        If edicion = True Then
            If Val(LbTotalPalets.Text) <> Val(TxPalets.Text) Then
                MsgBox("Error en palets")
            End If
        End If
    End Sub


    Private Sub ClButton1_Click_1(sender As System.Object, e As System.EventArgs) Handles ClButton1.Click
        If VaInt(pedidos_lineas.PEL_idlinea.Valor) > 0 Then
            Dim frm As New FrDocs
            frm.Init(EntidadFrm.NombreBd, pedidos_lineas.NombreTabla, pedidos_lineas.PEL_idlinea.Valor)
            frm.ShowDialog()
        Else
            MsgBox("Asignar el documento despues de guardar la linea")
        End If

    End Sub

    Private Sub BtMensajes_Click(sender As System.Object, e As System.EventArgs) Handles BtMensajes.Click
        If VaInt(pedidos_lineas.PEL_idlinea.Valor) > 0 Then
            Dim frm As New FrMMensajesEntidad
            FrMMensajesEntidad.Init(pedidos_lineas.NombreTabla, pedidos_lineas.PEL_idlinea.Valor, "Pedido: " & TxPedido.Text & " " & TxFecha.Text & " " & LbNomCliente.Text)
            FrMMensajesEntidad.ShowDialog()
        End If
    End Sub


    Private Sub TxCalidad_Valida(edicion As Boolean) Handles TxCalidad.Valida
        If TxCalidad.Text <> "A" And TxCalidad.Text <> "C" And TxCalidad.Text <> "D" And TxCalidad.Text <> "E" Then
            TxCalidad.Text = "B"
        End If
    End Sub


    Private Sub TxMaxDias_Valida(edicion As Boolean) Handles TxMaxDias.Valida
        If TxMaxDias.Text = "" Then
            TxMaxDias.Text = "1"
        End If
    End Sub

    'Private Sub TxReserva_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxReserva.TextChanged
    '    If TxReserva.Text <> "N" Then
    '        TxReserva.Text = "S"
    '    End If
    'End Sub

    Private Sub TxReserva_Valida(edicion As System.Boolean) Handles TxReserva.Valida
        If TxReserva.Text <> "N" Then
            TxReserva.Text = "S"
        End If
    End Sub


    Private Sub btImportarDatosPedido_Click(sender As System.Object, e As System.EventArgs) Handles btImportarDatosPedido.Click


        If TxPedido.Text = "" Then
            TxPedido.Text = "+"
        End If




        If VaInt(TxCliente.Text) > 0 Then

            TxCliente.Validar(True)

            If Not TxCliente.MiError Then

                Dim consulta As New Cdatos.E_select
                consulta.SelCampo(pedidos.PED_idpedido, "IdPedido")
                consulta.SelCampo(pedidos.PED_pedido, "Pedido")
                consulta.SelCampo(pedidos.PED_fechasalida, "Fecha")
                consulta.SelCampo(pedidos.PED_ejercicio, "Ejercicio")
                consulta.SelCampo(pedidos.PED_idcliente, "Codigo")
                consulta.SelCampo(Clientes.CLI_Nombre, "Nombre", pedidos.PED_idcliente)
                consulta.SelCampo(pedidos.PED_referencia, "Referencia")
                consulta.WheCampo(pedidos.PED_idcentro, "=", MiMaletin.IdCentro.ToString)
                consulta.WheCampo(pedidos.PED_idcliente, "=", TxCliente.Text)


                Dim sql As String = consulta.SQL & vbCrLf
                sql = sql & " ORDER BY PED_FechaPedido DESC"

                Dim dt As DataTable = pedidos.MiConexion.ConsultaSQL(sql)


                Dim lst As New List(Of Parametros)
                lst.Add(New Parametros("IdPedido", False, "", -1))



                Dim f As New FrConsultaGenerica(dt, lst, "Pedidos pendientes")
                f.ShowDialog()
                If Not RowDePaso Is Nothing Then

                    Dim IdPedidoOrigen As String = RowDePaso("IdPedido").ToString & ""
                    Dim PedidoOrigen As New E_Pedidos(Idusuario, cn)
                    Dim Descargas As New E_ClientesDescargas(Idusuario, cn)

                    If PedidoOrigen.LeerId(IdPedidoOrigen) Then

                        'Toma datos de la cabecera del pedido
                        TxDomicilio.Text = "1"
                        If VaInt(PedidoOrigen.PED_iddestino.Valor) > 0 Then
                            If Descargas.LeerId(PedidoOrigen.PED_iddestino.Valor) = True Then
                                TxDomicilio.Text = Descargas.CLD_numero.Valor
                            End If
                        End If
                        If VaInt(PedidoOrigen.PED_idporte.Valor) > 0 Then TxTipoPorte.Text = PedidoOrigen.PED_idporte.Valor
                        If VaInt(PedidoOrigen.PED_idtransportista.Valor) Then TxTransportista.Text = PedidoOrigen.PED_idtransportista.Valor
                        If VaInt(PedidoOrigen.PED_iddivisa.Valor) > 0 Then TxDivisa.Text = PedidoOrigen.PED_iddivisa.Valor
                        If VaDec(PedidoOrigen.PED_valorcambio.Valor) > 0 Then TxValorCambio.Text = PedidoOrigen.PED_valorcambio.Valor
                        TxMatricula.Text = PedidoOrigen.PED_matriculacamion.Valor & ""
                        TxRemolque.Text = PedidoOrigen.PED_matricularemolque.Valor & ""

                        TxDomicilio.Validar(True)
                        TxTipoPorte.Validar(True)
                        TxTransportista.Validar(True)
                        TxDivisa.Validar(True)
                        TxValorCambio.Validar(True)
                        TxMatricula.Validar(True)
                        TxRemolque.Validar(True)


                        'Guarda cabecera
                        If LbId.Text = "+" Then
                            LbId.Text = pedidos.MaxId
                            If TxPedido.Text = "+" Then
                                TxPedido.Text = pedidos.MaxIdCampa(Val(Lbejer.Text), Val(MiCentro))
                            End If
                        End If

                        pedidos.PED_ejercicio.Valor = Lbejer.Text
                        pedidos.PED_idpuntoventa.Valor = LbPuntoVenta.Text
                        pedidos.PED_idcentro.Valor = MiCentro
                        pedidos.PED_iddestino.Valor = _iddomicilio.ToString


                        If GuardarCabecera(ListaControles.Count - 1, True) Then

                            'Genera líneas pedido
                            Dim sqlLineas As String = "SELECT * FROM Pedidos_lineas WHERE PEL_IdPedido = " & IdPedidoOrigen
                            Dim dtLineas As DataTable = pedidos.MiConexion.ConsultaSQL(sqlLineas)

                            If Not IsNothing(dtLineas) Then

                                For Each row As DataRow In dtLineas.Rows

                                    Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)
                                    Pedidos_Lineas.PEL_idlinea.Valor = Pedidos_Lineas.MaxId()
                                    Pedidos_Lineas.PEL_idpedido.Valor = LbId.Text
                                    Pedidos_Lineas.PEL_idgenero.Valor = row("PEL_IdGenero").ToString & ""
                                    Pedidos_Lineas.PEL_idtipoconfeccion.Valor = row("PEL_IdTipoConfeccion").ToString & ""
                                    Pedidos_Lineas.PEL_idgensal.Valor = row("PEL_IdGenSal").ToString & ""
                                    Pedidos_Lineas.PEL_idcategoria.Valor = row("PEL_IdCategoria").ToString & ""
                                    Pedidos_Lineas.PEL_nomcate.Valor = row("PEL_NomCate").ToString & ""
                                    Pedidos_Lineas.PEL_idmarca.Valor = row("PEL_IdMarca").ToString & ""
                                    Pedidos_Lineas.PEL_idtipopalet.Valor = row("PEL_IdTipoPalet").ToString & ""
                                    Pedidos_Lineas.PEL_palets.Valor = row("PEL_Palets").ToString & ""
                                    Pedidos_Lineas.PEL_bultospalet.Valor = row("PEL_BultosPalet").ToString & ""
                                    Pedidos_Lineas.PEL_kilosbulto.Valor = row("PEL_KilosBulto").ToString & ""
                                    Pedidos_Lineas.PEL_piezasbulto.Valor = row("PEL_PiezasBulto").ToString & ""
                                    Pedidos_Lineas.PEL_precio.Valor = row("PEL_Precio").ToString & ""
                                    Pedidos_Lineas.PEL_tipoprecio.Valor = row("PEL_TipoPrecio").ToString & ""
                                    Pedidos_Lineas.PEL_Bultos.Valor = row("PEL_Bultos").ToString & ""
                                    Pedidos_Lineas.PEL_kilos.Valor = row("PEL_Kilos").ToString & ""
                                    Pedidos_Lineas.PEL_piezas.Valor = row("PEL_Piezas").ToString & ""
                                    Pedidos_Lineas.PEL_idproveedor.Valor = row("PEL_IdProveedor").ToString & ""
                                    Pedidos_Lineas.PEL_precioproveedor.Valor = row("PEL_PrecioProveedor").ToString & ""
                                    Pedidos_Lineas.PEL_paletsproveedor.Valor = row("PEL_PaletsProveedor").ToString & ""
                                    Pedidos_Lineas.PEL_obslote.Valor = row("PEL_ObsLote").ToString & ""
                                    Pedidos_Lineas.PEL_obsconfec1.Valor = row("PEL_ObsConfec1").ToString & ""
                                    Pedidos_Lineas.PEL_obsconfec2.Valor = row("PEL_ObsConfec2").ToString & ""
                                    Pedidos_Lineas.PEL_obseti1.Valor = row("PEL_ObsEti1").ToString & ""
                                    Pedidos_Lineas.PEL_obseti2.Valor = row("PEL_ObsEti2").ToString & ""
                                    Pedidos_Lineas.PEL_generatrabajo.Valor = row("PEL_GeneraTrabajo").ToString & ""
                                    Pedidos_Lineas.PEL_requiereaprobacion.Valor = row("PEL_RequiereAprobacion").ToString & ""
                                    Pedidos_Lineas.PEL_idmarcaetiqueta.Valor = row("PEL_IdMarcaEtiqueta").ToString & ""
                                    Pedidos_Lineas.PEL_idmarcamaterial.Valor = row("PEL_IdMarcaMaterial").ToString & ""
                                    Pedidos_Lineas.PEL_calidad.Valor = row("PEL_Calidad").ToString & ""
                                    Pedidos_Lineas.PEL_maxdias.Valor = row("PEL_MaxDias").ToString & ""
                                    Pedidos_Lineas.PEL_reservapalets.Valor = row("PEL_ReservaPalets").ToString & ""
                                    Pedidos_Lineas.Insertar()

                                    Dim SqlLineasAlm As String = "Select * from pedidos_almacen where PAC_idlineapedido= " & row("PEL_idlinea").ToString
                                    Dim pedidos_almacen As New E_pedidos_almacen(Idusuario, cn)
                                    Dim dtalma As DataTable = pedidos_almacen.MiConexion.ConsultaSQL(SqlLineasAlm)
                                    If Not dtalma Is Nothing Then
                                        For Each rwal In dtalma.Rows
                                            pedidos_almacen.PAC_id.Valor = pedidos_almacen.MaxId
                                            pedidos_almacen.PAC_idlineapedido.Valor = Pedidos_Lineas.PEL_idlinea.Valor
                                            pedidos_almacen.PAC_idalmacen.Valor = rwal("PAC_idalmacen").ToString
                                            pedidos_almacen.PAC_palets.Valor = rwal("PAC_palets").ToString
                                            pedidos_almacen.PAC_estadoetiqueta.Valor = "0"
                                            pedidos_almacen.Insertar()
                                        Next

                                    End If

                                Next

                            End If


                            CargaLineasGrid()

                        Else
                            MsgBox("Error al guardar el pedido")
                        End If

                    End If

                End If

            End If


            

        Else

            MsgBox("Debe introducir un cliente primero")

        End If


    End Sub

    Private Sub TxCliente_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxCliente.EnabledChanged

        btImportarDatosPedido.Enabled = TxCliente.Enabled

    End Sub


    Protected Overrides Sub Button1_Click()

        'Proforma
        If VaInt(LbId.Text) > 0 Then

            C1_ImprimirProformaPedido(LbId.Text, TipoImpresion.Preliminar)

        End If

    End Sub


    'Private Sub btCartelon_Click(sender As System.Object, e As System.EventArgs) Handles btCartelon.Click

    '    'pel_idlinea
    '    Dim row As DataRow = ClGrid1.GridView.GetFocusedDataRow()
    '    If Not IsNothing(row) Then
    '        Dim IdLinea As String = (row("PEL_IdLinea").ToString & "").Trim
    '        If VaInt(IdLinea) > 0 Then

    '            Dim frm As New FrmCartelones
    '            frm.InitPedido(IdLinea)
    '            frm.ShowDialog()

    '        End If
    '    End If

    'End Sub


    
    Private Sub BtImpPedido_Click(sender As System.Object, e As System.EventArgs) Handles BtImpPedido.Click
        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirPedidoCliente(LbId.Text, TipoImpresion.Preliminar, , , , True)
        End If
    End Sub


    Private Sub btPredefinido_Click(sender As System.Object, e As System.EventArgs) Handles btPredefinido.Click


        If VaInt(TxCliente.Text) > 0 Then

            Dim IdDomicilio As Integer = 0

            Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
            IdDomicilio = ClientesDescargas.LeerDomi(TxCliente.Text, TxDomicilio.Text)


            If LbId.Text = "+" Then


                If LbId.Text = "+" Then
                    LbId.Text = pedidos.MaxId
                    If TxPedido.Text = "+" Then
                        TxPedido.Text = pedidos.MaxIdCampa(Val(Lbejer.Text), Val(MiCentro))
                    End If
                End If

                pedidos.PED_ejercicio.Valor = Lbejer.Text
                pedidos.PED_idpuntoventa.Valor = LbPuntoVenta.Text
                pedidos.PED_idcentro.Valor = MiCentro
                If IdDomicilio > 0 Then
                    pedidos.PED_iddestino.Valor = IdDomicilio
                End If


                If Not GuardarCabecera(ListaControles.Count - 1, False) = True Then
                    'MsgBox("Error al guardar la cabecera del pedido")
                    Exit Sub
                End If


            End If



            If VaInt(LbId.Text) > 0 Then

                Dim frm As New FrmPedidosPredefinidos(LbId.Text, TxCliente.Text, IdDomicilio, LbPuntoVenta.Text)
                frm.ShowDialog()

                CargaLineasGrid()

            End If


            TxGenero.Select()
            TxGenero.Focus()

        Else
            MsgBox("Debe introducir un cliente primero")
        End If


    End Sub


    Private Sub TxGenero_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxGenero.EnabledChanged

        btPredefinido.Enabled = TxGenero.Enabled
        btAñadirACliente.Enabled = TxGenero.Enabled

    End Sub


    Private Sub TxTipoPalet_Valida(edicion As System.Boolean) Handles TxTipoPalet.Valida

        If edicion Then

            CalculoKilosBrutos()

            If VaInt(TxTipoPalet.Text) > 0 Then
                Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)
                If ConfecPalet.LeerId(TxTipoPalet.Text) Then
                    LbCoeficiente.Text = VaDec(ConfecPalet.CPA_Coeficiente.Valor).ToString("#,##0.00")
                End If
            End If

        End If

    End Sub



    Private Sub btDesbloquearKgBrutos_Click(sender As System.Object, e As System.EventArgs) Handles btDesbloquearKgBrutos.Click

        If TxKilosBrutos.Enabled Then
            TxKilosBrutos.ReadOnly = False
            TxKilosBrutos.Select()
            TxKilosBrutos.Focus()
        End If

    End Sub


    Private Sub btAñadirACliente_Click(sender As System.Object, e As System.EventArgs) Handles btAñadirACliente.Click

        If VaDec(LbId.Text) > 0 Then

            Dim IdLineaPedido As String = (pedidos_lineas.PEL_idlinea.Valor & "").Trim
            If VaDec(IdLineaPedido) > 0 Then
                GuardarLineaEnPedidosCliente(IdLineaPedido)
            End If

        End If

    End Sub


    'Private Sub GeneraLineasClientes(Idpedido As Integer)

    '    Dim pedidos_clientes As New E_Pedidos_Clientes(Idusuario, cn)
    '    If pedidos.LeerId(Idpedido.ToString) = True Then

    '        Dim idcliente As Integer = VaInt(pedidos.PED_idcliente.Valor)
    '        Dim fecha As String = pedidos.PED_fechapedido.Valor
    '        Dim sql As String = "Select PEL_idlinea as idlinea from PEDIDOS_LINEAS WHERE PEL_idpedido = " + Idpedido.ToString

    '        Dim dt As DataTable = pedidos.MiConexion.ConsultaSQL(sql)
    '        If Not dt Is Nothing Then
    '            For Each rw In dt.Rows
    '                Dim idlinea As Integer = VaInt(rw("idlinea"))
    '                pedidos_clientes.InsertarLinea(idcliente, idlinea, fecha)
    '            Next
    '        End If

    '    End If


    'End Sub


    Private Sub GuardarLineaEnPedidosCliente(IdLineaPedido As String)

        If VaDec(LbId.Text) > 0 Then

            'Busca la línea del pedido y la inserta en pedidos clientes()
            If XtraMessageBox.Show("¿Desea añadir los datos de la línea del pedido a los pedidos predefinidos del cliente?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)
                If Pedidos_Lineas.LeerId(IdLineaPedido) Then

                    Dim Pedidos As New E_Pedidos(Idusuario, cn)
                    If Pedidos.LeerId(LbId.Text) Then

                        Dim IdCliente As String = (Pedidos.PED_idcliente.Valor & "").Trim
                        Dim IdDomicilio As String = (Pedidos.PED_iddestino.Valor & "").Trim
                        Dim fecha As String = (Pedidos.PED_fechapedido.Valor & "").Trim

                        Dim Pedidos_Clientes As New E_Pedidos_Clientes(Idusuario, cn)
                        Pedidos_Clientes.InsertarLinea(IdCliente, IdDomicilio, IdLineaPedido, fecha)

                    Else
                        MsgBox("No se pudo localizar el pedido con Id.: " & LbId.Text)
                    End If

                End If

            End If

        End If

    End Sub


    Private Sub TxGenero_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxGenero.KeyDown

        If TxGenero.Enabled Then

            Select Case e.KeyCode
                Case Keys.F3


                    Dim sql As String = _sqlGenerosF3 & " AND PCC_IdCliente = " & TxCliente.Text & " AND PCC_IdDomicilio = " & _iddomicilio.ToString
                    Dim dt As DataTable = pedidos.MiConexion.ConsultaSQL(sql)


                    Dim Frb As New FrBuscar
                    Frb.InitCol(Generos.BtBuscaGenerosCliente.CL_ParamBusqueda, 0)
                    Frb.InitDta(dt, Generos.BtBuscaGenerosCliente.CL_CampoOrden, Generos.BtBuscaGenerosCliente.CL_Filtro, Generos.BtBuscaGenerosCliente.CL_ch1000)
                    Frb.Width = 1024
                    Frb.ShowDialog()

                    If Not IsNothing(BuscarRow) Then
                        TxGenero.Text = BuscarRow("IdGenero")
                        TxGenero.Validar(False)
                    End If



            End Select

        End If

    End Sub


    Private Sub TxCategoria_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxCategoria.KeyDown


        If TxCategoria.Enabled Then

            Select Case e.KeyCode
                Case Keys.F3

                    Dim sql As String = _sqlCategoriasF3 & " AND PCC_IdCliente = " & TxCliente.Text & " AND PCC_IdDomicilio = " & _iddomicilio.ToString & " AND PCC_IdGenero = " & TxGenero.Text
                    Dim Generos As New E_Generos(Idusuario, cn)
                    If Generos.LeerId(TxGenero.Text) = True Then
                        sql = sql & " AND FAC_IdFamilia = " & Generos.idfamiliagenero
                    End If

                    Dim dt As DataTable = pedidos.MiConexion.ConsultaSQL(sql)

                    Dim Frb As New FrBuscar
                    Frb.InitCol(CategoriasComercial.BtBuscaComCliente.CL_ParamBusqueda, 250)
                    Frb.InitDta(dt, CategoriasComercial.BtBuscaComCliente.CL_CampoOrden, CategoriasComercial.BtBuscaComCliente.CL_Filtro, CategoriasComercial.BtBuscaComCliente.CL_ch1000)
                    Frb.Width = 1024
                    Frb.ShowDialog()

                    If Not IsNothing(BuscarRow) Then
                        TxCategoria.Text = BuscarRow("IdCategoria")
                        TxCategoria.Validar(False)
                    End If

            End Select


        End If

    End Sub


    Private Sub TxConfeccion_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxConfeccion.KeyDown

        Select Case e.KeyCode

            Case Keys.F2

                Dim v As String
                If Not TxPresentacion.ClParam.BtBusca Is Nothing Then
                    v = TxPresentacion.ClParam.BtBusca.Enlazar

                    If v <> "" Then
                        TxPresentacion.Text = v
                        TxPresentacion.Validar(False)
                        TxTipoPalet.Focus()
                    End If
                End If


            Case Keys.F3

                Dim sql As String = _sqlConfeccionF3 & " AND PCC_IdCliente = " & TxCliente.Text & " AND PCC_IdDomicilio = " & _iddomicilio.ToString & " AND PCC_IdGenero = " & TxGenero.Text & " AND PCC_IdCategoria = " & TxCategoria.Text
                sql = sql & " AND GES_IdGenero = " & TxGenero.Text & " AND GCA_Codigo = " & TxCategoria.Text
                Dim dt As DataTable = pedidos.MiConexion.ConsultaSQL(sql)

                Dim Frb As New FrBuscar
                Frb.InitCol(GenerosSalida.BtBuscaXconfecCliente.CL_ParamBusqueda, 250)
                Frb.InitDta(dt, GenerosSalida.BtBuscaXconfecCliente.CL_CampoOrden, GenerosSalida.BtBuscaXconfecCliente.CL_Filtro, GenerosSalida.BtBuscaXconfecCliente.CL_ch1000)
                Frb.Width = 1024
                Frb.ShowDialog()

                If Not IsNothing(BuscarRow) Then
                    TxPresentacion.Text = BuscarRow("IdPresenta")
                    TxPresentacion.Validar(False)
                    TxTipoPalet.Focus()
                End If

        End Select


    End Sub


    Private Sub FrmPedidos_NoImpresionDirecta() Handles MyBase.NoImpresionDirecta


        If Modificando Then

            If XtraMessageBox.Show("¿Imprimir etiqueta por defecto?", "IMPRIMIR ETIQUETA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                ImprimeEtiquetaPedido()

            End If

        End If


    End Sub


    Private Sub ImprimeEtiquetaPedido()

        Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)
        If ValoresUsuario.LeerId(Idusuario.ToString) Then

            Dim Impresora As String = (ValoresUsuario.VUS_ImpresoraEtiquetaCMR.Valor & "").Trim
            If Impresora <> "" Then

                Dim Ejercicio As String = VaInt(pedidos.PED_ejercicio.Valor).ToString
                Dim IdCentro As String = VaInt(pedidos.PED_idcentro.Valor).ToString
                Dim NumPedido As String = VaInt(pedidos.PED_pedido.Valor).ToString

                C1_ImprimirEtiquetaPedido(Ejercicio, IdCentro, NumPedido, Impresora, TipoImpresion.ImpresoraSeleccionada)

            End If

        End If

    End Sub


    Private Sub btEtiquetaPedido_Click(sender As System.Object, e As System.EventArgs) Handles btEtiquetaPedido.Click

        If VaDec(LbId.Text) > 0 Then
            ImprimeEtiquetaPedido()
        End If

    End Sub


    Private Sub TxTransportista_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxTransportista.EnabledChanged

        btTransportistaHabitual.Enabled = TxTransportista.Enabled

    End Sub


    Private Sub btTransportistaHabitual_Click(sender As System.Object, e As System.EventArgs) Handles btTransportistaHabitual.Click

        If XtraMessageBox.Show("¿Desea actualizar el transportista habitual de este centro de descarga de este cliente?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
            Dim IdDomicilio As Integer = ClientesDescargas.LeerDomi(TxCliente.Text, TxDomicilio.Text)
            If IdDomicilio > 0 Then

                If ClientesDescargas.LeerId(IdDomicilio.ToString) Then
                    ClientesDescargas.CLD_IdTransportista.Valor = TxTransportista.Text
                    ClientesDescargas.Actualizar()
                End If

            End If

        End If

    End Sub

End Class