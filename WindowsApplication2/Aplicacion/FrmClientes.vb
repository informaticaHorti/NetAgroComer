
Imports DevExpress.XtraEditors
'Imports Microsoft.VisualBasic.powerpacks.printing


Public Class FrmClientes
    Inherits FrMantenimiento

    Dim Pais As New E_Paises(Idusuario, CnComun)
    Dim Idiomas As New E_Idiomas(Idusuario, CnComun)
    Dim Monedas As New E_Moneda(Idusuario, cn)
    Dim NifDelegaciones As New E_NifDelegaciones(Idusuario, CnComun)
    Dim NifMail As New E_NifMail(Idusuario, CnComun)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim GastosClientes As New E_GastosClientes(Idusuario, cn)
    Dim gastoscomercio As New E_GastosComercio(Idusuario, cn)
    Dim TiposClientes As New E_Tiposclientes(Idusuario, cn)
    Dim Vendedores As New E_Vendedores(Idusuario, cn)
    Dim Observaciones As New E_Observaciones(Idusuario, cn)
    Dim DomiciliosDescarga As New E_ClientesDescargas(Idusuario, cn)
    Dim Zonas As New E_Zonas(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Primero As Boolean
    Dim OrigenGastos As New E_OrigenGastos(Idusuario, cn)
    Dim FormasPago As New E_FormasPago(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim ClientesPrograma As New E_ClientesPrograma(Idusuario, cn)
    Dim TiposPorte As New E_TiposPorte(Idusuario, cn)
    Dim TarifaPorte As New E_TarifaPortes(Idusuario, cn)
    Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)

    Dim _dtAlb As New DataTable
    Dim _dtFac As New DataTable


    Private _bCrearNIF As Boolean = False


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        GridDescargas.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        parametrosfrm()

    End Sub


    Private Sub parametrosfrm()
        EntidadFrm = Clientes


        Dim lc As New List(Of Object)
        ListaControles = lc

        'Datos basicos
        ParamTx(TxDato1, Clientes.CLI_Codigo, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato3, Clientes.CLI_Nif, Lb3)
        ParamTx(TxDato2, Clientes.CLI_Nombre, Lb2, True)
        ParamTx(TxDF_13, Clientes.CLI_Domicilio, LbDF_13)
        ParamTx(TxDF_14, Clientes.CLI_Poblacion, LbDF_14)
        ParamTx(TxDF_15, Clientes.CLI_Provincia, LbDF_15)
        ParamTx(TxDF_16, Clientes.CLI_CPostal, LbDF_16)
        ParamTx(TxDF_17, Clientes.CLI_IdZona, LbDF_17)
        ParamTx(TxPaisCliente, Clientes.CLI_IdPais, LbDF_18, True)
        ParamTx(TxDF_19, Clientes.CLI_Telefono1, LbDF_19)
        ParamTx(TxDF_20, Clientes.CLI_Telefono2, LbDF_20)
        ParamTx(TxDF_21, Clientes.CLI_Fax, LbDF_21)
        ParamTx(TxDF_22, Clientes.CLI_Mail, LbDF_22)
        ParamChk(ChkQuincenas, Clientes.CLI_Quincenasfax, "S", "N")

        ParamTx(TxDF_23, Clientes.CLI_Ididioma, LbDF_23, True)
        ParamTx(TxDF_24, Clientes.CLI_Iddivisa, LbDF_24, True)
        ParamTx(TxDF_25, Clientes.CLI_IdVendedor, LbDF_25, True)
        ParamTx(TxDF_26, Clientes.CLI_IdTipo, LbDF_26, True)
        ParamTx(TxDf_27, Clientes.CLI_FechaAlta, Lbdf_27, False)
        ParamChk(ChkContrato, Clientes.CLI_Contrato, "S", "N")
        ParamChk(ChBloqueado, Clientes.CLI_Bloqueo, "S", "N")
        ParamTx(TxDf_29, Clientes.CLI_Bloqueocausa, Nothing, False)
        ParamTx(TxDf_30, Clientes.CLI_IdFormaPago, Lbdf_30)
        ParamTx(TxNumeroRegistro, Clientes.CLI_NumeroRegistro, LbNumeroRegistro)
        ParamChk(ChkDatosEnCMR, Clientes.CLI_DatosEnCMR, "S", "N")
        ParamChk(ChkDatosActualizados, Clientes.CLI_DatosActualizadosSN, "S", "N")




        'Observaciones
        'ParamTx(TxDato_31, Nothing, Lb_31, False, Cdatos.TiposCampo.Cadena, 0, 4000)



        ParamTx(TxTipoFC, Clientes.CLI_FC, Lb6, True)
        ParamTx(TxTipoPrecio, Clientes.CLI_KB, Lb12, True)
        ParamTx(TxFacturaEnvases, Clientes.CLI_FacturaEnvaseComercio, Lb13, True)

        ParamTx(TxTipoPorteCliente, Clientes.CLI_idtipoporte, Lb11, True)
        ParamTx(TxOrigenDestinoCliente, Clientes.CLI_origendestino, Lb14, True)
        ParamChk(ChkDesglosarLotes, Clientes.CLI_DesglosarLotes, "S", "N")
        ParamChk(chkGGNEnFactura, Clientes.CLI_GGNEnFacturas, "S", "N")
        ParamChk(ChkForzarGGN, Clientes.CLI_ForzarGGNEnFacturas, "S", "N")

        ParamTx(TxDato8, GastosClientes.GCL_IdGasto, Lb20)
        ParamTx(TxDato7, GastosClientes.GCL_ValorGasto, Lb18)
        ParamCb_Copia(CbFaccom, GastosClientes.GCL_TipoAFC, Lb8, Combos.ComboFacCom)

        ParamTx(TxDato_44, GastosClientes.GCL_IdAcreedor, Lb_44)


        ParamChk(ChAsegurado, Clientes.CLI_Asegurado, "S", "N")
        ParamTx(TxContrato, Clientes.CLI_NumeroContrato, LbContrato)
        ParamTx(TxFechaSolicitud, Clientes.CLI_FechaSolicitud, LbFechaSol)
        ParamTx(TxImpSolicitado, Clientes.CLI_ImporteSolicitado, LbImpSol)
        ParamTx(TxImpConcedido, Clientes.CLI_ImporteConcedido, LbImpCon)
        ParamTx(TxRiesgoMax, Clientes.CLI_RiesgoMaximo, LbRiesgoMax)


        ParamTx(TxMailAlbaranesCliente1, Clientes.CLI_emailalba1, Lb23, True)
        ParamTx(TxMailAlbaranesCliente2, Clientes.CLI_emailalba2, Lb23)
        ParamTx(TxMailAlbaranesCliente3, Clientes.CLI_emailalba3, Lb23)

        ParamTx(TxMailFacturasCliente1, Clientes.CLI_emailped1, Lb22, True)
        ParamTx(TxMailFacturasCliente2, Clientes.CLI_emailped2, Lb22)
        ParamTx(TxMailFacturasCliente3, Clientes.CLI_emailped3, Lb22)



        'Domicilios descarga
        ParamTx(TxDato_20, DomiciliosDescarga.CLD_Domicilio, Lb_20, True)
        ParamTx(TxDato_22, DomiciliosDescarga.CLD_Poblacion, Lb_22, False)
        ParamTx(TxDato_23, DomiciliosDescarga.CLD_Provincia, Lb_23, False)

        ParamTx(TxLugarEntrega, DomiciliosDescarga.CLD_LugarEntregaCMR, LbLugarEntrega, False)

        ParamTx(TxPaisDescarga, DomiciliosDescarga.CLD_IdPais, Lb_24, True)
        ParamTx(TxDato_25, DomiciliosDescarga.CLD_Telefono1, Lb_25, False)
        ParamTx(TxDato_26, DomiciliosDescarga.CLD_Telefono2, Lb_26, False)
        ParamTx(TxTipoPorteDescarga, DomiciliosDescarga.CLD_idtipoporte, Lb17, True)
        ParamTx(TxOrigenDestinoDescarga, DomiciliosDescarga.CLD_origendestino, Lb15, True)
        ParamTx(TxOpEnvio, DomiciliosDescarga.CLD_OpcionEnvio, LbOpEnvio, True, , , , "EFT")
        ParamTx(TxDato_28, DomiciliosDescarga.CLD_Observaciones, Lb_28, False)

        ParamTx(TxCalidad, DomiciliosDescarga.CLD_calidad, LbCalidad, False)
        ParamTx(TxMaxDias, DomiciliosDescarga.CLD_maxdias, LbMaxdias, False)
        ParamTx(TxTarifaPorteDescargas, DomiciliosDescarga.CLD_IdTarifaPortes, LbTarifa, True)
        ParamTx(TxReserva, DomiciliosDescarga.CLD_reservapalets, LbReserva, False)
        ParamTx(TxTipoPaletDescarga, DomiciliosDescarga.CLD_IdConfecPalet, LbTipoPalet, True)
        ParamTx(TxTransportista, DomiciliosDescarga.CLD_IdTransportista, LbTransportista)
        ParamTx(TxTransporteRapido, DomiciliosDescarga.CLD_TransporteRapidoSN, LbTransporteRapido)


        ParamTx(TxMailAlbaranesDescargas1, DomiciliosDescarga.CLD_emailalba1, Lb7, True)
        ParamTx(TxMailAlbaranesDescargas2, DomiciliosDescarga.CLD_emailalba2, Lb7, False)
        ParamTx(TxMailAlbaranesDescargas3, DomiciliosDescarga.CLD_emailalba3, Lb7, False)

        ParamTx(TxMailFacturasDescargas1, DomiciliosDescarga.CLD_emailped1, Lb9, True)
        ParamTx(TxMailFacturasDescargas2, DomiciliosDescarga.CLD_emailped2, Lb9, False)
        ParamTx(TxMailFacturasDescargas3, DomiciliosDescarga.CLD_emailped3, Lb9, False)




        'Datos basicos
        AsociarControles(TxDato1, BtBuscaCliente, Clientes.btBusca, EntidadFrm)
        'AsociarControles(TxDato3, BtBuscaNif, Nif.btBusca, Nif)
        AsociarControles(TxDF_17, BtBuscaDF_17, Zonas.btBusca, Zonas, Zonas.ZON_Nombre, LbNomDF_17)
        AsociarControles(TxPaisCliente, BtBuscaDF_18, Pais.btBusca, Pais, Pais.Nombre, LbNomDF_18)
        AsociarControles(TxDF_23, BtBuscaDF_23, Idiomas.btBusca, Idiomas, Idiomas.Nombre, LbNomDF_23)
        AsociarControles(TxDF_24, BtBuscaDF_24, Monedas.btBusca, Monedas, Monedas.MON_Nombre, LbNomDF_24)
        AsociarControles(TxDF_25, BtBuscaDF_25, Vendedores.btBusca, Vendedores, Vendedores.VED_nombre, LbNomDF_25)
        AsociarControles(TxDF_26, BtBuscaDF_26, TiposClientes.btBusca, TiposClientes, TiposClientes.TPC_nombre, LbNomDF_26)
        AsociarControles(TxDf_30, BtBuscadf_30, FormasPago.btBusca, FormasPago, FormasPago.Nombre, Lbnomdf_30)
        AsociarControles(TxTipoPaletDescarga, BtBuscaTipoPalet, ConfecPalet.btBusca, ConfecPalet, ConfecPalet.CPA_Nombre, LbNomTipoPalet)


        'Domicilios descargas
        AsociarControles(TxPaisDescarga, BtBuscaPais, Pais.btBusca, Pais, Pais.Nombre, LbNom_24)
        AsociarControles(TxTransportista, BtBuscaTransportista, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNom_Transportista)


        '
        AsociarControles(TxDato8, BtBuscaGastoFac, gastoscomercio.btBusca, gastoscomercio, gastoscomercio.GCO_Nombre, Lb19)
        AsociarControles(TxDato_44, BtBuscaAcreedor, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, Lbnom_44)

        AsociarControles(TxTipoPorteCliente, BtTipoPorte, TiposPorte.btBusca, TiposPorte, TiposPorte.TPO_Nombre, LbTipoPorte)
        AsociarControles(TxTipoPorteDescarga, BtTipoPorte2, TiposPorte.btBusca, TiposPorte, TiposPorte.TPO_Nombre, LbTipoPorte2)
        AsociarControles(TxTarifaPorteDescargas, BtTarifa, TarifaPorte.btBusca, TarifaPorte, TarifaPorte.TPV_Nombre, LbNomTarifa)

        AsociarGrid(ClGrid2, TxDato8, TxDato_44, GastosClientes)
        AsociarGrid(GridDescargas, TxDato_20, TxMailFacturasDescargas3, DomiciliosDescarga)



        PropiedadesCamposGr(ClGrid2, "GCL_Idlinea", "", False, 0)
        PropiedadesCamposGr(ClGrid2, GastosClientes.GCL_IdGasto.NombreCampo, "Gasto", True, 50)
        PropiedadesCamposGr(ClGrid2, GastosClientes.GCL_ValorGasto.NombreCampo, "Valor", True, 100, False, "#0.000000")
        PropiedadesCamposGr(ClGrid2, "Tipo", "Tipo", True, 20)
        PropiedadesCamposGr(ClGrid2, "Fc", "Fc", True, 20)
        PropiedadesCamposGr(ClGrid2, "Gasto", "Nombre", True, 150)



        PropiedadesCamposGr(GridDescargas, "CLD_Id", "", False)
        PropiedadesCamposGr(GridDescargas, "Num", "Num", True, 30)
        PropiedadesCamposGr(GridDescargas, "Domicilio", "Domicilio", True, 150)
        PropiedadesCamposGr(GridDescargas, "Poblacion", "Poblacion", True, 100)
        PropiedadesCamposGr(GridDescargas, "Provincia", "Provincia", True, 100)


        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


        BtBuscaTransportista.CL_Filtro = "TIPO='PV'"

        'LbTipoKBP.CL_ControlAsociado = TxDato8.Text
    End Sub


    Public Overrides Sub ControlClave()
        MyBase.ControlClave()


        CargaLineasDescargas()
        CargaLineasGridGastosCom()

    End Sub

    Private Sub FrmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Primero = True

        Primero = False

        XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(0)

        'BTaux1.Visible = True
        'BTaux1.Text = "Imprimir ficha"
        'BTaux1.Width = 90
        'BTaux1.Image = Global.NetAgro.My.Resources.Action_file_quick_print_16x16_32



    End Sub


    Public Overrides Sub BorraPan()

        MyBase.BorraPan()




        GridAsociados.DataSource = Nothing

        LbFacPtes.Text = ""
        LbAlbPtes.Text = ""
        LbTotRiesgo.Text = ""
        LbDisponible.Text = ""
        _dtAlb = Nothing
        _dtFac = Nothing

        _bCrearNIF = False
        CargaGridFRm()

    End Sub







    Public Overrides Sub Entidad_a_DatosLin(Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)
        If Grid Is GridDescargas Then
            LbNudomi.Text = DomiciliosDescarga.CLD_numero.Valor
        End If
    End Sub


    Public Overrides Sub Borralin(gr As ClGrid)
        MyBase.Borralin(gr)
        If gr Is GridDescargas Then
            LbNudomi.Text = ""
        End If

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

        ' llenar el grid


        Me.Enabled = False

        Try

            CargaGridFRm()

            CargaAsociados()
            CargaLineasDescargas()
            CargaLineasGridGastosCom()
            CargaFacturas()


        Catch ex As Exception
        End Try


        Me.Enabled = True



        If VaInt(TxDato8.Text) = 0 Then
            TxDato8.Text = ""
        End If
        If VaInt(TxDato_44.Text) = 0 Then
            TxDato_44.Text = ""
        End If



    End Sub


    Private Sub CargaFacturas()

        Dim facturas As New E_Facturas(Idusuario, cn)
        Dim Pendiente As Decimal = 0

        _dtFac = facturas.FacturasPendientes(VaInt(LbId.Text), Pendiente)
        LbFacPtes.Text = Pendiente.ToString("#,###0.00")

        _dtAlb = facturas.AlbaranesPendientes(VaInt(LbId.Text), Pendiente)
        LbAlbPtes.Text = Pendiente.ToString("#,###0.00")

        CalculaDisponible()

    End Sub

    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean

        'asociar cabecera con lineas
        GastosClientes.GCL_IdCliente.Valor = TxDato1.Text
        DomiciliosDescarga.CLD_IdCliente.Valor = TxDato1.Text

        If Gr Is ClGrid2 Then
            GastosClientes.GCL_TipoAFC.Valor = "C"
        ElseIf (Gr Is GridDescargas) Then
            If VaInt(DomiciliosDescarga.CLD_numero.Valor) = 0 Then
                DomiciliosDescarga.CLD_numero.Valor = DomiciliosDescarga.MaxNumero(LbId.Text).ToString
            End If

        End If



        CargaLineasDescargas(False)
        CargaLineasGridGastosCom(False)
        'CargaDatosTarifa()


        Return MyBase.GuardarLineas(Gr)

    End Function


    Public Overrides Sub Guardar()


        If _bCrearNIF Then
            TxDato3.MiError = False
            TxDato3.BackColor = Color.White
        End If

        GuardarCh()

        MyBase.Guardar()
        CargaGridFRm()
    End Sub


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()

        SincronizarClientes(LbId.Text)
        GeneraDomicilio(LbId.Text, "1") ' genero el domicilio 1 si no existe

    End Sub










    Private Sub CargaAsociados()

        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(Clientes.CLI_Codigo, "Codigo")
        CONSULTA.SelCampo(Clientes.CLI_Nombre, "Cliente")
        CONSULTA.WheCampo(Clientes.CLI_Nif, "=", TxDato3.Text)

        Dim sql As String = CONSULTA.SQL & vbCrLf & " ORDER BY CLI_Nombre" & vbCrLf
        Dim dt As DataTable = Clientes.MiConexion.ConsultaSQL(sql)


        GridAsociados.DataSource = dt

        With GridViewAsociados.Columns
            If Not IsNothing(.ColumnByFieldName("Codigo")) Then
                .ColumnByFieldName("Codigo").Width = 55
                .ColumnByFieldName("Codigo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .ColumnByFieldName("Codigo").DisplayFormat.FormatString = "00000"
            End If
        End With


    End Sub


    Private Sub CargaLineasDescargas(Optional bCargar As Boolean = True)

        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 
        If VaInt(TxDato1.Text) = 0 Then Exit Sub


        Dim sql As String = "Select CLD_Id,CLD_Numero as Num, CLD_Domicilio as Domicilio, CLD_Poblacion as Poblacion,CLD_Provincia as Provincia  from ClientesDescargas where CLD_IdCliente = " + TxDato1.Text
        sql = sql & " order by CLD_NUMERO"
        GridDescargas.Consulta = sql

        If bCargar Then
            GridDescargas.Nlinea = -1
            Cargalineas(GridDescargas)
        End If


    End Sub




    Private Sub CargaLineasGridGastosCom(Optional bCargar As Boolean = True)
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 
        If VaInt(TxDato1.Text) = 0 Then Exit Sub

        Dim sql As String
        sql = "Select GCL_Idlinea, GastosClientes.GCL_idgasto as codigo, gastoscomercio.GCO_nombre as Gasto, GCL_valorgasto, gastoscomercio.GCO_tipobkp as Tipo,gastosclientes.GCL_tipoAFC as Fc from gastosclientes,gastoscomercio where gastosclientes.GCL_idcliente=" + TxDato1.Text + "and GastosClientes.GCL_tipoAFC<>'A' and GastosClientes.GCL_idgasto=gastoscomercio.GCO_idgasto  order by GCL_idlinea"
        ClGrid2.Consulta = sql

        If bCargar Then
            ClGrid2.Nlinea = -1
            Cargalineas(ClGrid2)
        End If


    End Sub











    Private Sub CbCentrosExp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Primero = False Then

            CargaLineasGridGastosCom()

            If TxDato8.Visible = True And TxDato8.Enabled = True Then
                TxDato8.Focus()
            End If

        End If

    End Sub





    Protected Overrides Sub BModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MyBase.BModificar_Click(sender, e)

    End Sub


    Private Sub TxObservaciones_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            XtraTabControl1.SelectedTabPageIndex = 3
            TxTipoPrecio.Select()
            TxTipoPrecio.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            XtraTabControl1.SelectedTabPageIndex = 1
            GridDescargas.Select()
            GridDescargas.Focus()
            GridDescargas.GridView.FocusedRowHandle = GridDescargas.GridView.RowCount - 1
        End If

    End Sub











    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        If VaInt(LbId.Text) > 0 Then

            Dim frm As New FrmContactos("Cliente", LbId.Text)
            frm.init(LbId.Text)
            frm.ShowDialog()
        End If

    End Sub

    Private Sub TxDato5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxDato5_Valida(ByVal edicion As Boolean)
    End Sub

    Private Sub TxDato4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxDato8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato8.TextChanged

    End Sub

    Private Sub TxDato8_Valida(ByVal edicion As Boolean) Handles TxDato8.Valida

        If gastoscomercio.LeerId(TxDato8.Text) = True Then
            If OrigenGastos.LeerId(gastoscomercio.GCO_idgrupo.Valor) Then
                BtBuscaAcreedor.CL_Filtro = "TIPO='" + OrigenGastos.ORG_tipo.Valor + "'"
            End If
            If edicion = True Then

                LbTipoKBP.Text = gastoscomercio.GCO_Tipobkp.Valor
                If CbFaccom.SelectedValue Is Nothing Then
                    CbFaccom.SelectedValue = gastoscomercio.GCO_Tipogastofc.Valor
                End If
                If TxDato_44.Text = "" Then
                    TxDato_44.Text = gastoscomercio.GCO_idacreedor.Valor
                End If
            End If
        End If
    End Sub

    Private Sub TxDato_9_Valida(edicion As System.Boolean) Handles TxTipoFC.Valida
        If edicion Then
            If TxTipoFC.Text <> "F" Then
                TxTipoFC.Text = "C"
            End If

        End If
    End Sub

    Private Sub TxDato3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato3.TextChanged

    End Sub

    Private Sub TxDato_9_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxTipoFC.TextChanged

    End Sub

    Private Sub TxDato9_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxTipoPrecio.TextChanged

    End Sub

    Private Sub TxDato9_Valida(edicion As Boolean) Handles TxTipoPrecio.Valida
        If edicion = True Then
            If TxTipoPrecio.Text <> "B" Then
                TxTipoPrecio.Text = "K"
            End If
        End If

    End Sub

    Private Sub TxDato3_AntesDeValidarEnlace() Handles TxDato3.AntesDeValidarEnlace
        Dim letra As String = ObtenerLetraDNI_NIE(TxDato3.Text)
        TxDato3.Text = TxDato3.Text & letra
    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        'Me.PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        'PrintForm1.Print()

        'Dim pf As New PrintForm
        'pf.Form = Me
        'pf.PrintAction = PrintToPrinter
        'pf.Print()

    End Sub




    Private Sub BtObserva_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub BtObserva_Click_1(sender As System.Object, e As System.EventArgs) Handles BtObserva.Click
        If Val(LbId.Text) > 0 Then
            Dim frm As New FrmObserva
            frm.init("CLI", LbId.Text)
            frm.ShowDialog()
        End If
    End Sub


    Private Sub CargaGridFRm()

        Dim dt As New DataTable
        Dim sql As String
        sql = "Select NOR_IdNorma as Codigo, NOR_nombre as Nombre from NormasCalidad order by NOR_IdNorma"
        dt = EntidadFrm.MiConexion.ConsultaSQL(sql)

        ChPrograma.DataSource = dt
        ChPrograma.ValueMember = "Codigo"
        ChPrograma.DisplayMember = "Nombre"


        ChPrograma.CheckOnClick = True


        If Val(LbId.Text) > 0 Then
            For indice As Integer = 0 To ChPrograma.ItemCount - 1

                '   If ChOrigen.GetItemChecked(indice) = True Then
                ' MsgBox("Checked: " & row("Nombre").ToString)
                ' End If

                Dim row As DataRowView = ChPrograma.GetItem(indice)
                Dim a As String = row("Codigo").ToString
                If ClientesPrograma.LeerCliente_programa(LbId.Text, a) > 0 Then
                    ChPrograma.SetItemChecked(indice, True)

                End If
            Next
        End If


    End Sub

    Private Sub GuardarCh()
        BorrarGastos()
        For Each row As DataRowView In ChPrograma.CheckedItems

            ClientesPrograma.VaciaEntidad()
            Dim id As Integer = ClientesPrograma.MaxId
            ClientesPrograma.CPR_id.Valor = id.ToString
            ClientesPrograma.CPR_idcliente.Valor = LbId.Text
            ClientesPrograma.CPR_idprograma.Valor = row("Codigo").ToString
            ClientesPrograma.Insertar()

        Next

    End Sub

    Private Sub BorrarGastos()
        If Val(LbId.Text) > 0 Then
            Dim sql As String = "delete from clientesprograma where CPR_idcliente=" + LbId.Text
            ClientesPrograma.MiConexion.ConsultaSQL(sql)
        End If

    End Sub

    Private Sub GeneraDomicilio(idcliente As String, ndom As String)

        If idcliente = "" Then Exit Sub
        If DomiciliosDescarga.LeerDomi(idcliente, ndom) = 0 Then
            If Clientes.LeerId(idcliente) = True Then
                Dim id As Integer = DomiciliosDescarga.MaxId
                DomiciliosDescarga.VaciaEntidad()
                DomiciliosDescarga.CLD_Id.Valor = id.ToString
                DomiciliosDescarga.CLD_IdCliente.Valor = idcliente
                DomiciliosDescarga.CLD_Domicilio.Valor = Clientes.CLI_Domicilio.Valor
                DomiciliosDescarga.CLD_CPostal.Valor = Clientes.CLI_CPostal.Valor
                DomiciliosDescarga.CLD_IdPais.Valor = Clientes.CLI_IdPais.Valor
                DomiciliosDescarga.CLD_idtipoporte.Valor = Clientes.CLI_idtipoporte.Valor
                DomiciliosDescarga.CLD_Poblacion.Valor = Clientes.CLI_Poblacion.Valor
                DomiciliosDescarga.CLD_Provincia.Valor = Clientes.CLI_Provincia.Valor
                DomiciliosDescarga.CLD_Telefono1.Valor = Clientes.CLI_Telefono1.Valor
                DomiciliosDescarga.CLD_Telefono2.Valor = Clientes.CLI_Fax.Valor
                DomiciliosDescarga.CLD_origendestino.Valor = Clientes.CLI_origendestino.Valor
                DomiciliosDescarga.CLD_emailalba1.Valor = Clientes.CLI_emailalba1.Valor
                DomiciliosDescarga.CLD_emailalba2.Valor = Clientes.CLI_emailalba2.Valor
                DomiciliosDescarga.CLD_emailalba3.Valor = Clientes.CLI_emailalba3.Valor
                DomiciliosDescarga.CLD_emailped1.Valor = Clientes.CLI_emailped1.Valor
                DomiciliosDescarga.CLD_emailped2.Valor = Clientes.CLI_emailped2.Valor
                DomiciliosDescarga.CLD_emailped3.Valor = Clientes.CLI_emailped3.Valor
                DomiciliosDescarga.CLD_numero.Valor = ndom
                DomiciliosDescarga.Insertar()

            End If
        End If




    End Sub

    Private Sub TxDato_20_GotFocus(sender As Object, e As System.EventArgs) Handles TxDato_20.GotFocus
        If VaInt(LbNudomi.Text) = 0 And TxDato_20.Enabled = True Then
            BtCopiar.Visible = True
        Else
            If BtCopiar.Visible = True Then
                BtCopiar.Visible = False
            End If
        End If
    End Sub

    Private Sub TxDato_20_LostFocus(sender As Object, e As System.EventArgs) Handles TxDato_20.LostFocus

    End Sub

    Private Sub TxDato_20_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato_20.TextChanged

    End Sub

    Private Sub BtCopiar_Click(sender As System.Object, e As System.EventArgs) Handles BtCopiar.Click
        If MsgBox("Desea copiar los datos de cliente", vbYesNo) = vbYes Then
            TxDato_20.Text = TxDF_13.Text
            TxDato_22.Text = TxDF_14.Text
            TxDato_23.Text = TxDF_15.Text
            TxPaisDescarga.Text = TxPaisCliente.Text
            TxDato_25.Text = TxDF_19.Text
            TxDato_26.Text = TxDF_21.Text
            TxTipoPorteDescarga.Text = TxTipoPorteCliente.Text
            TxOrigenDestinoDescarga.Text = TxOrigenDestinoCliente.Text
            TxMailAlbaranesDescargas1.Text = TxMailAlbaranesCliente1.Text
            TxMailAlbaranesDescargas2.Text = TxMailAlbaranesCliente2.Text
            TxMailAlbaranesDescargas3.Text = TxMailAlbaranesCliente3.Text
            TxMailFacturasDescargas1.Text = TxMailFacturasCliente1.Text
            TxMailFacturasDescargas2.Text = TxMailFacturasCliente2.Text
            TxMailFacturasDescargas3.Text = TxMailFacturasCliente3.Text
            TxDato_20.Focus()

        End If
    End Sub

    Private Sub TxDato_20_Valida(edicion As Boolean) Handles TxDato_20.Valida
        If edicion = True Then
            If BtCopiar.Visible = True Then
                BtCopiar.Visible = False
            End If
        End If
    End Sub

    Private Sub TxCalidad_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxCalidad.TextChanged

    End Sub

    Private Sub TxCalidad_Valida(edicion As Boolean) Handles TxCalidad.Valida
        If TxCalidad.Text <> "A" And TxCalidad.Text <> "C" And TxCalidad.Text <> "D" And TxCalidad.Text = "E" Then
            TxCalidad.Text = "B"
        End If
    End Sub

    Private Sub TxMaxDias_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxMaxDias.TextChanged

    End Sub

    Private Sub TxMaxDias_Valida(edicion As Boolean) Handles TxMaxDias.Valida
        If TxMaxDias.Text = "" Then
            TxMaxDias.Text = "1"

        End If
    End Sub

    Private Sub TxReserva_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxReserva.TextChanged
      
    End Sub

    Private Sub TxReserva_Valida(edicion As Boolean) Handles TxReserva.Valida
        If TxReserva.Text <> "N" Then
            TxReserva.Text = "S"
        End If
    End Sub

    Private Sub TxOpEnvio_Valida(edicion As System.Boolean) Handles TxOpEnvio.Valida
        If edicion Then
            If TxOpEnvio.Text.Trim = "" Then TxOpEnvio.Text = "E"
        End If
    End Sub

    Private Sub ClButton1_Click(sender As System.Object, e As System.EventArgs) Handles ClButton1.Click
        If LbId.Text <> "" Then
            GuardarCh()
            Dim frm As New FrmGeneraTraza
            frm.initCliente(LbId.Text)
            frm.ShowDialog()

        End If
    End Sub

    Private Sub TxImpConcedido_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxImpConcedido.TextChanged

    End Sub

    Private Sub TxImpConcedido_Valida(edicion As Boolean) Handles TxImpConcedido.Valida
        If edicion = True Then
            If VaDec(TxRiesgoMax.Text) = 0 Then
                TxRiesgoMax.Text = TxImpConcedido.Text
            End If
        End If
    End Sub

    Private Sub CalculaDisponible()
        Dim i As Decimal = 0
        i = VaDec(TxRiesgoMax.Text)
        LbTotRiesgo.Text = (VaDec(LbFacPtes.Text) + VaDec(LbAlbPtes.Text)).ToString("#,###0.00")
        i = i - VaDec(LbFacPtes.Text)
        i = i - VaDec(LbAlbPtes.Text)
        LbDisponible.Text = i.ToString("#,###0.00")
    End Sub

    Private Sub TxRiesgoMax_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxRiesgoMax.TextChanged

    End Sub

    Private Sub TxRiesgoMax_Valida(edicion As Boolean) Handles TxRiesgoMax.Valida
        If edicion = True Then
            CalculaDisponible()

        End If
    End Sub

    Private Sub BtAlbaranes_Click(sender As System.Object, e As System.EventArgs) Handles BtAlbaranes.Click
        If VaInt(LbId.Text) > 0 Then
            Dim lst As New List(Of Parametros)
            lst.Add(New Parametros("idalbaran", False, "", -1))
            lst.Add(New Parametros("Albaran", False, "", 100))
            lst.Add(New Parametros("Fecha", False, "", 150))
            lst.Add(New Parametros("Referencia", False, "", 150))
            lst.Add(New Parametros("RefValoracion", False, "", 150))
            lst.Add(New Parametros("Cambio", False, "{0:n6}", 100))
            lst.Add(New Parametros("Importe", True, "{0:n2}", 150))


            Dim f As New FrConsultaGenerica(_dtAlb, lst, "Albaranes pendientes de facturar")
            f.ShowDialog()

        End If
    End Sub

    Private Sub BtFacturas_Click(sender As System.Object, e As System.EventArgs) Handles BtFacturas.Click
        If VaInt(LbId.Text) > 0 Then
            Dim lst As New List(Of Parametros)
            lst.Add(New Parametros("idfactura", False, "", -1))
            lst.Add(New Parametros("Fecha", False, "", 150))
            lst.Add(New Parametros("Serie", False, "", 100))
            lst.Add(New Parametros("Factura", False, "", 100))
            lst.Add(New Parametros("importe", False, "", -1))
            lst.Add(New Parametros("Referencia", False, "", 150))
            lst.Add(New Parametros("Cambio", False, "{0:n6}", 100))
            lst.Add(New Parametros("Pendiente", True, "{0:n2}", 150))


            Dim f As New FrConsultaGenerica(_dtFac, lst, "Facturas pendientes de cobro")
            f.ShowDialog()
        End If
    End Sub


    Private Sub TxDato3_Valida(edicion As System.Boolean) Handles TxDato3.Valida

        If edicion Then

            If TxDato3.Text.Trim <> "" And NuevoRegistro Then

                Dim lst As New List(Of String)


                Dim CONSULTA As New Cdatos.E_select
                CONSULTA.SelCampo(Clientes.CLI_Codigo, "IdCliente")
                CONSULTA.WheCampo(Clientes.CLI_Nif, "=", TxDato3.Text)

                Dim dt As DataTable = Clientes.MiConexion.ConsultaSQL(CONSULTA.SQL)
                If Not IsNothing(dt) Then

                    If dt.Rows.Count > 0 Then

                        For Each row As DataRow In dt.Rows

                            Dim IdCliente As String = (row("IdCliente").ToString & "").Trim
                            lst.Add(IdCliente)

                        Next

                    End If

                End If


                If lst.Count > 0 Then

                    Dim texto As String = CadenaWhereLista_CAMPO("", Cdatos.TiposCampo.Entero, lst)
                    MsgBox("El NIF introducido ya existe en el siguiente cliente: " & texto.Replace("=", ""))

                End If


            End If

        End If


    End Sub

    Private Sub btFianzas_Click(sender As System.Object, e As System.EventArgs) Handles btFianzas.Click
        If VaInt(LbId.Text) > 0 Then

            Dim row As DataRow = GridDescargas.GridView.GetFocusedDataRow()
            If Not IsNothing(row) Then

                If VaDec(row("CLD_Id")) > 0 And Modificando Then

                    Dim IdDomicilio As String = (row("CLD_Id").ToString & "").Trim
                    If VaInt(IdDomicilio) > 0 Then


                        Dim Cliente As String = TxDato1.Text & " - " & TxDato2.Text
                        Dim Domicilio As String = (row("Num").ToString & "").Trim & " - " & (row("Domicilio").ToString & "").Trim

                        Dim frm As New FrmDomiciliosFianzas(IdDomicilio, Domicilio, Cliente)
                        frm.ShowDialog()

                    End If

                End If

            End If

        End If

    End Sub


    Private Sub TxDato2_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxDato2.EnabledChanged
        ChPrograma.Enabled = TxDato2.Enabled
    End Sub


    'Private Sub TxLugarEntrega_Valida(edicion As System.Boolean) Handles TxLugarEntrega.Valida
    '    If edicion Then
    '        If ChkDatosEnCMR.Checked Then
    '            If TxLugarEntrega.Text.Trim = "" Then
    '                MsgBox("Si los datos del cliente van a aparecer en el CMR, el lugar de entre")
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub btFianzasEnvases_Click(sender As System.Object, e As System.EventArgs) Handles btFianzasEnvases.Click
        If Val(LbId.Text) > 0 Then
            Dim frm As New FrmFianzasEnvases
            frm.init(LbId.Text)
            frm.ShowDialog()
        End If
    End Sub


End Class
