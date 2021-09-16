Imports System.Drawing

Public Class FrmHiAlbSal
    Inherits FrMantenimiento


    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Categorias As New E_CategoriasSalida(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
    Dim Albsalida As New E_AlbSalida(Idusuario, cn)
    Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
    Dim Albsalida_gastos As New E_albsalida_gastos(Idusuario, cn)
    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
    ' Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim GastosComercio As New E_GastosComercio(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Pedidos As New E_Pedidos(Idusuario, cn)
    Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    Dim OrigenGastos As New E_OrigenGastos(Idusuario, cn)
    Dim Tipoprecio As String = ""

    Dim Valorespventa As New E_valorespventa(Idusuario, cn)

    Dim FacturasRecibidas As New E_Facturasrecibidas(Idusuario, cn)
    Dim Moneda As New E_Moneda(Idusuario, cn)
    Dim Facturas As New E_Facturas(Idusuario, cn)
    Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)


    Dim Transportistas As New E_Transportistas(Idusuario, cn)


    'Dim _idpedido As Integer



    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim MiCentro As String
    'Dim Envases As New E_Envases(Idusuario, cn)





    Private Sub ParametrosFrm()
        EntidadFrm = Albsalida


        Dim lc As New List(Of Object)
        ListaControles = lc



        LbPuntoVenta.CL_ControlAsociado = TxDato_1
        LbNomPv.CL_ControlAsociado = TxDato_1
        CampoClave = 0 ' ultimo campo de la clave

        ParamTx(TxDato_1, Albsalida.ASA_albaran, Lb_1, True)
        'ParamTx(TxPedido, Nothing, Lb_3)

        ParamTx(TxDato_2, Albsalida.ASA_fechasalida, Lb_2, True)
        TxDato_1.Autonumerico = False
        ' ParamTx(TxDato_3, Nothing, Lb_3, False)
        ParamTx(TxDato1, Albsalida.ASA_tipofc, Lb2, True, , , , "FC")

        ParamTx(TxCliente, Albsalida.ASA_idcliente, Lb_4, True)
        'ParamTx(TxDomicilio, Albsalida.ASA_iddomicilio, Lb_5, False)
        ParamTx(TxDomicilio, Nothing, LbDescarga, False)

        ParamTx(TxDato_6, Albsalida.ASA_iddivisa, Lb_6, True)
        ParamTx(TxDato_7, Albsalida.ASA_valorcambio, Lb_7, True)
        ParamTx(TxDato4, Albsalida.ASA_observaciones, Lb19)


        ParamTx(TxTransportista, Albsalida.ASA_idtransportista, LbTransportista, False)
        ParamTx(TxDato2, Albsalida.ASA_matriculacamion, Lb14, False)
        ParamTx(TxDato_8, Albsalida.ASA_matricularemolque, Lb_8, False)

        ParamTx(TxMovilChofer, Albsalida.ASA_movilchofer, LbMovilChofer, False)
        ParamTx(TxNumRegTemp, Albsalida.ASA_numregtemperatura, LbNumRegTemp, False)

        ParamTx(TxDato_27, Albsalida_lineas.ASL_precio, Lb_27, False)
        ParamTx(TxDato_28, Albsalida_lineas.ASL_tipoprecio, Lb_27, False, , , , "KBP")
        ParamTx(TxDato_29, Albsalida_lineas.ASL_precioestimado, Lb_29, False)
        ParamTx(TxDato_30, Albsalida_lineas.ASL_tipoprecioestimado, Lb_29, False, , , , "KBP")

        AsociarControles(TxDato_1, BtBuscaAlbaran, Albsalida.btBusca, Albsalida)
        BtBuscaAlbaran.CL_Filtro = "Emp=" + MiMaletin.IdEmpresaCTB.ToString

        AsociarControles(TxDato_6, BtBusca2, Moneda.btBusca, Moneda, Moneda.MON_Nombre, Lbnom_6)
        AsociarControles(TxTransportista, BtBuscaTransportista, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNom_Transportista)
        BtBuscaTransportista.CL_Filtro = "TIPO='PV'"

        AsociarControles(TxDomicilio, BtBuscaDestino, ClientesDescargas.btBusca, ClientesDescargas)


        AsociarGrid(ClGrid1, TxDato_27, TxDato_30, Albsalida_lineas)
        ClGrid1.AñadirLinea = False

        PropiedadesCamposGr(ClGrid1, "ASL_idlinea", "ASL_idlinea", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 10)
        PropiedadesCamposGr(ClGrid1, "Producto", "Producto", True, 50)
        PropiedadesCamposGr(ClGrid1, "Envase", "Envase", True, 50)
        PropiedadesCamposGr(ClGrid1, "Categoria", "Categoria", True, 50)
        PropiedadesCamposGr(ClGrid1, "Palets", "Palets", True, 15, False)
        PropiedadesCamposGr(ClGrid1, "Bultos", "Bultos", True, 15, False)
        PropiedadesCamposGr(ClGrid1, "Kilos", "Kilos", True, 15, False, "#0.00")
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 15, False, "#0.0000")
        PropiedadesCamposGr(ClGrid1, "Tp", "Tp", True, 10)




        ParamTx(TxDato22, Albsalida_gastos.ASG_idgasto, Lb32, True)
        ParamCb_Copia(CbBox2, Albsalida_gastos.ASG_tipokbp, Lb8, Combos.ComboGastos)
        ParamTx(TxDato10, Albsalida_gastos.ASG_valorgasto, Lb12, False)
        ParamTx(TxDato5, Albsalida_gastos.ASG_tipofc, Lb13, True)
        ParamTx(TxDato11, Albsalida_gastos.ASG_idacreedor, Lb7, False)

        AsociarGrid(ClGrid2, TxDato22, TxDato11, Albsalida_gastos)

        PropiedadesCamposGr(ClGrid2, "ASG_id", "ASG_id", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid2, "Gasto", "Gasto", True, 30)
        PropiedadesCamposGr(ClGrid2, "Valor", "Valor", True, 10, False, "#0.0000")
        PropiedadesCamposGr(ClGrid2, "KBP", "KBP", True, 10)
        PropiedadesCamposGr(ClGrid2, "FC", "FC", True, 10)
        PropiedadesCamposGr(ClGrid2, "Importe", "Importe", True, 15, True, "#,###0.00")


        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False





        AsociarControles(TxCliente, BtBuscaCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lbnom_4)
        'AsociarControles(TxDato_3, BtBuscaPedidos, Pedidos.btBusca, Pedidos, Pedidos.PED_pedido, Nothing)
        'BtBuscaPedidos.CL_DevuelveCampo = "Pedido"
        'BtBuscaPedidos.CL_BuscaAlb = False

        AsociarControles(TxDato22, BtBuscaGasto, GastosComercio.btBusca, GastosComercio, GastosComercio.GCO_Nombre, Lb1)
        AsociarControles(TxDato11, BtBuscaAcreedor, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomAcreedor)

        ' BotonesAvance1.Mientidad = EntidadFrm
        ' BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        ' BotonesAvance1.Formulario = Me

        Lb_26.CL_ControlAsociado = TxDato_27



        FiltroEntidad.Add(Albsalida.ASA_idcentro.NombreCampo, MiMaletin.IdCentro.ToString)
        FiltroEntidad.Add(Albsalida.ASA_ejercicio.NombreCampo, MiMaletin.Ejercicio.ToString)
        FiltroEntidad.Add(Albsalida.ASA_IdEmpresa.NombreCampo, MiMaletin.IdEmpresaCTB.ToString)

    End Sub


    Private Sub FrmHiAlbSal_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BTaux1.Visible = True
        BTaux1.Text = "Imprimir"
        BTaux1.Image = PictureBox1.Image

        BtAux2.Visible = True
        BtAux2.Text = "I.Directa"
        BtAux2.Image = PictureBox2.Image

        BtAux3.Text = "Enviar cliente"
        BtAux3.Width = 90
        BtAux3.Image = NetAgro.My.Resources.Resources.App_xf_mail_16x16_32
        BtAux3.Visible = True

        tt.SetToolTip(btModificarTipoFianzaValeEnvase, "Modificar Tipo Fianza del vale de envases")

    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave

        Dim i As Integer
        If TxDato_1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = Albsalida.LeerAlb(Lbejer.Text, MiCentro, VaInt(TxDato_1.Text))
            If i > 0 Then
                LbId.Text = i.ToString

            Else
                ' If MsgBox("Registro inexistente. Desea crear uno nuevo", vbYesNo) = vbYes Then
                '                    LbId.Text = Cobros.MaxId
                'LbId.Text = "+"
                'Else
                'LbId.Text = ""
                'End If

            End If

        End If

        If LbId.Text <> "" Then
            CargaLineasGrid()
        End If

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()


        PintaPuntoVenta(Albsalida.ASA_idpuntoventa.Valor)
        Lbejer.Text = Albsalida.ASA_ejercicio.Valor

        LbFactura.Text = ""
        If VaInt(Albsalida.ASA_idfactura.Valor) > 0 Then
            If Facturas.LeerId(Albsalida.ASA_idfactura.Valor) = True Then
                LbFactura.Text = Facturas.FRA_serie.Valor & "  " & Facturas.FRA_factura.Valor
            End If
        End If

        LbReferencia.Text = Albsalida.ASA_referencia.Valor
        LbNumeroRegistro.Text = Clientes.CLI_NumeroRegistro.Valor
        LbRefValoracion.Text = Albsalida.ASA_refvaloracion.Valor


        Dim IdDomicilio As Integer = VaInt(Albsalida.ASA_iddomicilio.Valor)
        If IdDomicilio > 0 Then
            If ClientesDescargas.LeerId(IdDomicilio.ToString) = True Then
                TxDomicilio.Text = ClientesDescargas.CLD_numero.Valor
                LbnomDestino.Text = ClientesDescargas.CLD_Domicilio.Valor
            End If
        End If


        '_idpedido = VaInt(Albsalida.ASA_idpedido.Valor)
        'If _idpedido > 0 Then
        '    Dim Pedidos As New E_Pedidos(Idusuario, cn)
        '    If Pedidos.LeerId(_idpedido.ToString) = True Then
        '        TxPedido.Text = Pedidos.PED_pedido.Valor
        '        TxPedido.Validar(False)
        '    End If
        'End If


        LbNom_BESTELLNR.Text = ""
        If VaInt(Albsalida.ASA_idpedido.Valor) > 0 Then
            Dim Pedidos As New E_Pedidos(Idusuario, cn)
            If Pedidos.LeerId(Albsalida.ASA_idpedido.Valor) Then
                LbNom_BESTELLNR.Text = Pedidos.PED_BESTELLNR.Valor
                LbPedido.Text = "Pedido Nº: " & Pedidos.PED_pedido.Valor
            End If
        End If





        ' llenar el grid
        CargaLineasGrid()

    End Sub


    'Private Sub TxPedido_Valida(edicion As Boolean) Handles TxPedido.Valida


    '    If TxPedido.Text <> "" Then
    '        _idpedido = Pedidos.LeerPedido(Lbejer.Text, MiMaletin.IdCentro, TxPedido.Text)
    '        If _idpedido > 0 Then
    '            If Pedidos.LeerId(_idpedido) = True Then
    '                If Clientes.LeerId(Pedidos.PED_idcliente.Valor) Then
    '                    LbNomPedido.Text = Clientes.CLI_Nombre.Valor
    '                End If
    '                If edicion = True Then
    '                    If TxDato_1.Text = "" Then
    '                        Dim albaran As String = albaranesdelpedido(_idpedido)
    '                        If VaInt(albaran) = 0 Then
    '                            TxDato_1.Text = "+"
    '                            LbId.Text = "+"
    '                        Else
    '                            If Albsalida.LeerId(albaran) = True Then
    '                                LbId.Text = albaran
    '                                TxDato_1.Text = Albsalida.ASA_albaran.Valor
    '                                Me.Siguiente(0)

    '                                Exit Sub
    '                            End If
    '                        End If
    '                    Else
    '                        If LbId.Text = "+" Then

    '                            If TieneAlbaranes(_idpedido) = True Then
    '                                MsgBox("Atencion, este pedido ya tiene albaranes asignados")

    '                            End If


    '                        End If

    '                    End If


    '                    TxDato_4.Text = Pedidos.PED_idcliente.Valor
    '                    TxTipoPorte.Text = Pedidos.PED_idporte.Valor
    '                    If ClientesDescargas.LeerId(Pedidos.PED_iddestino.Valor) = True Then
    '                        TxDomicilio.Text = ClientesDescargas.CLD_numero.Valor
    '                    End If
    '                    TxDato_9.Text = Clientes.CLI_FC.Valor
    '                    TxDivisa.Text = Pedidos.PED_iddivisa.Valor
    '                    TxValorCambio.Text = Pedidos.PED_valorcambio.Valor
    '                    If VaInt(Pedidos.PED_idtransportista.Valor) > 0 Then
    '                        TxDato_6.Text = Pedidos.PED_idtransportista.Valor
    '                    End If
    '                    If Pedidos.PED_matriculacamion.Valor <> "" Then
    '                        TxDato_7.Text = Pedidos.PED_matriculacamion.Valor
    '                    End If
    '                    If Pedidos.PED_matricularemolque.Valor <> "" Then
    '                        TxDato_8.Text = Pedidos.PED_matricularemolque.Valor
    '                    End If
    '                    If Pedidos.PED_referencia.Valor <> "" Then
    '                        TxDato_5.Text = Pedidos.PED_referencia.Valor
    '                    End If
    '                End If

    '            End If

    '        Else
    '            TxPedido.MiError = True
    '            MsgBox("Pedido inexistente")
    '        End If

    '    End If
    'End Sub



    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)

        If Grid Is ClGrid2 Then
            If VaInt(TxDato11.Text) = 0 Then
                LbNomAcreedor.Text = ""
            End If

            Grid.LineaBloqueada = False
            If VaInt(Albsalida_gastos.ASG_idfactura.Valor) > 0 Then
                If FacturasRecibidas.LeerId(Albsalida_gastos.ASG_idfactura.Valor) = True Then
                    Grid.LineaBloqueada = True

                    'Número factura
                    LbNuFactura.Text = FacturasRecibidas.FRR_numerofactura.Valor

                End If
            End If
        End If


        MyBase.Entidad_a_DatosLin(Grid)

        If Grid Is ClGrid1 Then
            If Generos.LeerId(Albsalida_lineas.ASL_idgenero.Valor) = True Then
                Lbnom_10.Text = Generos.GEN_NombreGenero.Valor
            End If
            If ConfecEnvase.LeerId(Albsalida_lineas.ASL_idtipoconfeccion.Valor) = True Then
                Lbnom_11.Text = ConfecEnvase.CEV_Nombre.Valor
            End If
            If GenerosSalida.LeerId(Albsalida_lineas.ASL_idgensal.Valor) = True Then
                Lbnom_18.Text = GenerosSalida.GES_Nombre.Valor
            End If
            Lbnom_19.Text = Albsalida_lineas.ASL_categoria.Valor
            If Marcas.LeerId(Albsalida_lineas.ASL_idmarca.Valor) = True Then
                Lbnom_21.Text = Marcas.MAR_Nombre.Valor
            End If

            LbPalets.Text = Albsalida_lineas.ASL_palets.Valor
            LbBultos.Text = Albsalida_lineas.ASL_bultos.Valor
            LbKbrutos.Text = Albsalida_lineas.ASL_kilosbrutos.Valor
            LbKnetos.Text = Albsalida_lineas.ASL_kilosnetos.Valor
            LbKCliente.Text = Albsalida_lineas.ASL_kiloscliente.Valor
            LbPiezas.Text = Albsalida_lineas.ASL_piezas.Valor

        End If
    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean
        Dim igenero As Double
        Dim igeneroestimado As Double
        Dim u As Double
        Dim igasto As Double



        If LbId.Text = "+" Then
            LbId.Text = Albsalida.MaxId
            If TxDato_1.Text = "+" Then
                TxDato_1.Text = Albsalida.MaxIdCampa(Val(Lbejer.Text), Val(MiCentro))
            End If
        End If

        '        Dim IDPEDIDO As Integer = Pedidos.LeerPedido(Lbejer.Text, MiCentro, VaInt(TxDato_3.Text))
        '        Albsalida.ASA_idpedido.Valor = IDPEDIDO

        If Gr Is ClGrid1 Then
            Albsalida.ASA_ejercicio.Valor = Lbejer.Text
            Albsalida.ASA_idpuntoventa.Valor = LbPuntoVenta.Text
            Albsalida.ASA_idcentro.Valor = MiCentro


            Albsalida_lineas.ASL_idalbaran.Valor = LbId.Text
            u = 0
            Select Case TxDato_28.Text
                Case "K"
                    u = VaDec(Albsalida_lineas.ASL_kiloscliente.Valor)
                Case "B"
                    u = VaDec(Albsalida_lineas.ASL_bultos.Valor)
                Case "P"
                    u = VaDec(Albsalida_lineas.ASL_piezas.Valor)

            End Select
            igenero = u * VaDec(TxDato_27.Text)

            u = 0
            Select Case TxDato_30.Text
                Case "K"
                    u = VaDec(Albsalida_lineas.ASL_kiloscliente.Valor)
                Case "B"
                    u = VaDec(Albsalida_lineas.ASL_bultos.Valor)
                Case "P"
                    u = VaDec(Albsalida_lineas.ASL_piezas.Valor)

            End Select

            igeneroestimado = u * VaDec(TxDato_29.Text)

            Albsalida_lineas.ASL_importegenero.Valor = igenero.ToString


            Albsalida_lineas.ASL_paletsvendidos.Valor = LbPalets.Text
            Albsalida_lineas.ASL_bultosvendidos.Valor = LbBultos.Text
            Albsalida_lineas.ASL_kilosvendidos.Valor = LbKCliente.Text
            Albsalida_lineas.ASL_piezasvendidas.Valor = LbPiezas.Text
            Albsalida_lineas.ASL_precioventa.Valor = TxDato_29.Text ' igualo el precio vta del precio estimado
            Albsalida_lineas.ASL_tipopreciovta.Valor = TxDato_30.Text
            Albsalida_lineas.ASL_importegenerovta.Valor = igeneroestimado.ToString ' importe de vta = importe estimado
            Albsalida_lineas.ASL_importegeneroestimado.Valor = igeneroestimado.ToString
        End If
        If Gr Is ClGrid2 Then
            Albsalida_gastos.ASG_idalbaran.Valor = LbId.Text

            Select Case CbBox2.SelectedValue
                Case "B"
                    igasto = VaDec(LbTbultos.Text) * VaDec(TxDato10.Text)
                Case "K"
                    igasto = VaDec(LbTkilos.Text) * VaDec(TxDato10.Text)
                Case "P"
                    igasto = VaDec(LbTpalets.Text) * VaDec(TxDato10.Text)
                Case "%"
                    igasto = VaDec(LbTVenta.Text) * VaDec(TxDato10.Text) / 100
                Case "I"
                    igasto = VaDec(TxDato10.Text)


            End Select
            If VaDec(TxDato_7.Text) = 0 Then
                TxDato_7.Text = "1"
            End If
            Albsalida_gastos.ASG_importegastodivisa.Valor = igasto.ToString
            Albsalida_gastos.ASG_importegastoeuros.Valor = StDec(igasto * VaDec(TxDato_7.Text))
        End If



        SqlGrid()
        r = MyBase.GuardarLineas(Gr)


        If Gr Is ClGrid1 Then
            ' actualizar los gastos por si han cambiado el importe, los kilos, los bultos .......
            Agro_CalculoGastosTotalesAlbaran(LbId.Text, VaDec(TxDato_7.Text))

        End If
        CalculoTotales()

        Return r

    End Function

    Public Overrides Sub DespuesdeGuardar()

        Agro_CalculoGastosTotalesAlbaran(LbId.Text, VaDec(TxDato_7.Text))
        'Agro_GeneraGastosLineas(LbId.Text, VaDec(TxDato_7.Text))


        MyBase.DespuesdeGuardar()


        Dim IdCliente As String = (Albsalida.ASA_idcliente.Valor & "").Trim
        Dim IdDomicilio As String = VaInt(Albsalida.ASA_iddomicilio.Valor).ToString

        'Albsalida.CrearValeEnvasesSalida(LbId.Text, "S", Clientes.CLI_FacturaEnvaseComercio.Valor, IdCliente, IdDomicilio)
        'Albsalida.CrearValeEnvasesSalida(LbId.Text, "N", Clientes.CLI_FacturaEnvaseComercio.Valor, IdCliente, IdDomicilio)

        Albsalida.CrearValeEnvasesSalida(LbId.Text, "S", IdCliente, IdDomicilio)
        Albsalida.CrearValeEnvasesSalida(LbId.Text, "N", IdCliente, IdDomicilio)


        If VaDec(LbId.Text) > 0 Then

            Dim IdVale As String = Albsalida.ASA_idvaleenvase.Valor

            'Mostrar Vale
            If VaInt(IdVale) > 0 Then

                Dim frm As New FrmValeEnvase("SC")
                frm.init(IdVale)
                frm.ShowDialog()

            End If

        End If


    End Sub


    Private Sub CargaLineasGrid()
        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)
        ClGrid2.Nlinea = -1
        Cargalineas(ClGrid2)
        CalculoTotales()


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
        Dim Dt As New DataTable


        CONSULTA.SelCampo(Albsalida_lineas.ASL_idlinea, "ASL_idlinea")
        CONSULTA.SelCampo(Albsalida_lineas.ASL_idgenero, "Codigo")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Producto", Albsalida_lineas.ASL_idgenero)
        CONSULTA.SelCampo(ConfecEnvase.CEV_Nombre, "Envase", Albsalida_lineas.ASL_idtipoconfeccion)
        CONSULTA.SelCampo(Albsalida_lineas.ASL_categoria, "Categoria")
        CONSULTA.SelCampo(Albsalida_lineas.ASL_palets, "Palets")
        CONSULTA.SelCampo(Albsalida_lineas.ASL_bultos, "Bultos")
        CONSULTA.SelCampo(Albsalida_lineas.ASL_kiloscliente, "Kilos")
        CONSULTA.SelCampo(Albsalida_lineas.ASL_precio, "Precio")
        CONSULTA.SelCampo(Albsalida_lineas.ASL_tipoprecio, "TP")
        CONSULTA.WheCampo(Albsalida_lineas.ASL_idalbaran, "=", id)
        sql = CONSULTA.SQL
        sql = sql + " order by ASL_IdLinea"


        ClGrid1.Consulta = sql


        Dim CONSULTA2 As New Cdatos.E_select

        CONSULTA2.SelCampo(Albsalida_gastos.ASG_id, "ASG_id")
        CONSULTA2.SelCampo(GastosComercio.GCO_Nombre, "Gasto", Albsalida_gastos.ASG_idgasto)
        CONSULTA2.SelCampo(Albsalida_gastos.ASG_valorgasto, "Valor")
        CONSULTA2.SelCampo(Albsalida_gastos.ASG_tipokbp, "KBP")
        CONSULTA2.SelCampo(Albsalida_gastos.ASG_tipofc, "FC")
        CONSULTA2.SelCampo(Albsalida_gastos.ASG_importegastodivisa, "Importe")
        CONSULTA2.WheCampo(Albsalida_gastos.ASG_idalbaran, "=", id)

        sql = CONSULTA2.SQL
        sql = sql + " order by ASG_id"

        ClGrid2.Consulta = sql


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
        If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString Then
            MsgBox("no se puede anular el albarán")
            Exit Sub
        End If

        If Albsalida.ASA_fechavaloracion.Valor <> "01/01/1900" And Albsalida.ASA_tipofc.Valor <> "F" Then
            MsgBox("Albaran valorado. Debe anular la valoracion para poder anularlo")
            Exit Sub
        End If

        If VaInt(Albsalida.ASA_idfactura.Valor) <> 0 Then
            MsgBox("Albarán facturado")
            Exit Sub
        End If

        Dim f As String = Albsalida_gastos.GastosFacturados(LbId.Text)
        If f <> "" Then
            MsgBox(f)
            Exit Sub
        End If

        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
        If ValeEnvases.LineasFacturadas(Albsalida.ASA_idvaleenvase.Valor) Then
            MsgBox("No se puede anular el albarán, el vale de envases tiene líneas facturadas")
            Exit Sub
        End If

        MyBase.BAnular_Click(sender, e)
    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString Then
            MsgBox("no se puede modificar el albarán")
            Exit Sub
        End If

        If Albsalida.ASA_fechavaloracion.Valor <> "01/01/1900" And Albsalida.ASA_tipofc.Valor <> "F" Then
            MsgBox("Albaran valorado. Debe anular la valoracion para poder modificarlo")
            Exit Sub
        End If

        If VaInt(Albsalida.ASA_idfactura.Valor) <> 0 Then
            MsgBox("Albarán facturado")
            Exit Sub
        End If

        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
        If ValeEnvases.LineasFacturadas(Albsalida.ASA_idvaleenvase.Valor) Then
            MsgBox("No se puede modificar el albarán, el vale de envases tiene líneas facturadas")
            Exit Sub
        End If


        MyBase.BModificar_Click(sender, e)

    End Sub

    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxDato_1.Text = "" And TxDato_1.Enabled = True Then
            TxDato_1.Text = "+"
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

    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)
        If gr Is ClGrid1 Then
            Lbnom_10.Text = ""
            Lbnom_11.Text = ""
            Lbnom_18.Text = ""
            Lbnom_19.Text = ""
            Lbnom_21.Text = ""
            LbPalets.Text = ""
            LbBultos.Text = ""
            LbKbrutos.Text = ""
            LbKnetos.Text = ""
            LbKCliente.Text = ""
            LbPiezas.Text = ""
        ElseIf gr Is ClGrid2 Then
            LbNuFactura.Text = ""
            LbNomAcreedor.Text = ""
        End If

    End Sub


    Public Overrides Sub BorraPan()

        MyBase.BorraPan()

        PintaPuntoVenta(MiMaletin.IdPuntoVenta)
        Lbejer.Text = MiMaletin.Ejercicio

        LbFactura.Text = ""
        LbReferencia.Text = ""
        LbNumeroRegistro.Text = ""
        LbRefValoracion.Text = ""
        LbNom_BESTELLNR.Text = ""
        LbPedido.Text = ""

    End Sub


    Private Sub CalculoTotales()

        Dim sql As String

        sql = "Select sum(ASL_kiloscliente) as kilos, "
        sql = sql + " sum(ASL_palets) as palets, "
        sql = sql + " sum(ASL_bultos) as bultos, "
        sql = sql + " sum(ASL_importegenero) as igenero, "
        sql = sql + " sum(ASL_importegenerovta) as igenerovta "


        sql = sql + " from albsalida_lineas where ASL_idalbaran=" + LbId.Text

        Dim dt As DataTable = Albsalida_lineas.MiConexion.ConsultaSQL(sql)

        LbTVenta.Text = ""
        LbTEnvase.Text = ""
        LbTkilos.Text = ""
        LbTbultos.Text = ""
        LbTpalets.Text = ""
        LbTotDivisa.Text = ""
        LbTotEuros.Text = ""

        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                LbTVenta.Text = Format(VaDec(dt.Rows(0)("igenerovta")), "#,###0.00")
                LbImpSalida.Text = Format(VaDec(dt.Rows(0)("igenero")), "#,###0.00")
                LbTkilos.Text = Format(VaDec(dt.Rows(0)("kilos")), "#,###")
                LbTbultos.Text = dt.Rows(0)("bultos").ToString
                LbTpalets.Text = dt.Rows(0)("palets").ToString

            End If
        End If

        Dim gf As Double = 0
        Dim gc As Double = 0

        sql = "Select * from albsalida_gastos where ASG_idalbaran=" + LbId.Text
        Dim dtg As DataTable = Albsalida_gastos.MiConexion.ConsultaSQL(sql)
        If Not dtg Is Nothing Then
            For Each rw In dtg.Rows
                Select Case rw("ASG_tipofc").ToString
                    Case "F"
                        gf = gf + VaDec(rw("ASG_importegastodivisa"))

                    Case "C"
                        gc = gc + VaDec(rw("ASG_importegastoeuros"))

                End Select
            Next
        End If

        ImporteEnvases()
        LbGastosFac.Text = Format(gf, "#,###0.00")
        LbGastosCom.Text = Format(gc, "#,###0.00")
        LbTotDivisa.Text = Format(VaDec(LbTVenta.Text) + VaDec(LbTEnvase.Text) - gf, "#,###0.00")
        LbTotEuros.Text = Format(VaDec(LbTotDivisa.Text) * VaDec(TxDato_7.Text), "#,###0.00")


    End Sub

    Private Sub ImporteEnvases()
        Dim sql As String

        LbTEnvase.Text = ""
        sql = "SELECT SUM(VEL_RETIRA*VEL_PRECIORETIRA)-SUM(VEL_ENTREGA*VEL_PRECIOENTREGA) AS ienvases FROM valeenvases_lineas where VEL_IDVALE=" + Albsalida.ASA_idvaleenvase.Valor
        Dim dte As DataTable = Albsalida.MiConexion.ConsultaSQL(sql)
        If Not dte Is Nothing Then
            If dte.Rows.Count > 0 Then
                LbTEnvase.Text = Format(VaDec(dte.Rows(0)(0)), "#,###0.00")
            End If
        End If

    End Sub

    Public Overrides Sub Guardar()

        Albsalida.ASA_idpuntoventa.Valor = LbPuntoVenta.Text
        Albsalida.ASA_ejercicio.Valor = Lbejer.Text
        Albsalida.ASA_idcentro.Valor = MiCentro

        Dim IdDomicilio As Integer = ClientesDescargas.LeerDomi(txcliente.text, TxDomicilio.Text)
        Albsalida.ASA_iddomicilio.Valor = IdDomicilio.ToString

        MyBase.Guardar()

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim id As Integer = 0
        id = VaInt(Albsalida.ASA_idvaleenvase.Valor)
        If id = 0 Then
            id = ValeEnvases.LeerVale(MiMaletin.Ejercicio, MiMaletin.IdCentro, "SC", TxDato_1.Text)
        End If

        If id > 0 Then
            Dim fr As New FrmValeEnvase("SC")
            'fr.InitTipoVale("SC")
            fr.init(id)
            fr.ShowDialog()
            ImporteEnvases()
            Albsalida.ASA_idvaleenvase.Valor = id.ToString
        Else
            MsgBox("no encuentro el vale")
        End If
    End Sub

    Private Sub TxDato22_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato22.TextChanged

    End Sub

    Private Sub TxDato22_Valida(ByVal edicion As Boolean) Handles TxDato22.Valida
        If GastosComercio.LeerId(TxDato22.Text) = True Then
            If OrigenGastos.LeerId(GastosComercio.GCO_idgrupo.Valor) Then
                BtBuscaAcreedor.CL_Filtro = "TIPO='" + OrigenGastos.ORG_tipo.Valor + "'"
            End If
            If edicion = True Then
                If CbBox2.SelectedValue Is Nothing Then
                    CbBox2.SelectedValue = GastosComercio.GCO_Tipobkp.Valor
                End If
                TxDato5.Text = GastosComercio.GCO_Tipogastofc.Valor
                If TxDato11.Text = "" Then
                    TxDato11.Text = GastosComercio.GCO_idacreedor.Valor
                End If
            End If
        End If

    End Sub


    Private Sub TxDato_28_Valida(ByVal edicion As Boolean) Handles TxDato_28.Valida
        If edicion = True Then
            If TxDato_28.Text = "" Then
                TxDato_28.Text = "K"
            End If
        End If
    End Sub



    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()


        If VaDec(LbId.Text) > 0 Then
            Dim impresora As New Printing.PrinterSettings
            C1_ImprimirAlbaranSalida(LbId.Text, TipoImpresion.Preliminar, 0)
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()


        If VaDec(LbId.Text) > 0 Then
            Dim impresora As New Printing.PrinterSettings
            C1_ImprimirAlbaranSalida(LbId.Text, TipoImpresion.ImpresoraPorDefecto, 0)
        End If

    End Sub


    'Public Overrides Sub BotonAuxiliar3()
    '    MyBase.BotonAuxiliar3()

    '    If VaDec(LbId.Text) > 0 Then

    '        C1_EnviarAlbaranSalida(LbId.Text)

    '    End If

    'End Sub




    Private Sub TxDato_6_Valida(edicion As System.Boolean) Handles TxDato_6.Valida

        If edicion Then
            If TxDato_7.Text.Trim = "" Then
                TxDato_7.Text = VaDec(Moneda.MON_Cambio.Valor).ToString("#,##0.000000")
                LbTotEuros.Text = Format(VaDec(LbTotDivisa.Text) * VaDec(TxDato_7.Text), "#,###0.00")
            End If
        End If

    End Sub

    Private Sub TxDato_7_Valida(edicion As System.Boolean) Handles TxDato_7.Valida
        If edicion Then
            LbTotEuros.Text = Format(VaDec(LbTotDivisa.Text) * VaDec(TxDato_7.Text), "#,###0.00")
        End If
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)

        '        If TxDato_3.Enabled Then
        ' BuscaPedidos()
        ' End If


    End Sub

    Private Sub TxDato_3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        '        If e.KeyCode = Keys.F2 And TxDato_3.Enabled Then
        ' BuscaPedidos()
        ' End If
    End Sub

    'Private Sub BuscaPedidos()

    '    Dim FrBuscaAlb As New FrBuscaAlb("Pedidos")
    '    Dim BtBusca As BtBusca = Pedidos.btBusca

    '    FrBuscaAlb.InitCodigo(BtBusca.CL_ConsultaSql, Pedidos, BtBusca.CL_campocodigo, BtBusca.CL_camponombre, BtBusca.CL_dfecha, BtBusca.CL_hfecha, BtBusca.CL_ParamBusqueda)
    '    FrBuscaAlb.InitFiltro(BtBusca.CL_Filtro)
    '    FrBuscaAlb.ShowDialog()

    '    If Not BuscarRow Is Nothing Then

    '        Try
    '            TxDato_3.Text = BuscarRow("Pedido").ToString

    '        Catch ex As Exception
    '            TxDato_3.Text = ""
    '        End Try

    '        Siguiente(TxDato_3.Orden)
    '        'TxDato_3.Validar(True)

    '    End If

    'End Sub
    Public Overrides Sub ImpresionDirecta()

        BotonAuxiliar1()

    End Sub

    Private Sub TxDato_4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxCliente.TextChanged

    End Sub

    Private Sub TxCliente_Valida(edicion As Boolean) Handles TxCliente.Valida

        If Clientes.LeerId(TxCliente.Text) = True Then

            Tipoprecio = Clientes.CLI_KB.Valor

            If edicion Then
                LbNumeroRegistro.Text = Clientes.CLI_NumeroRegistro.Valor
            End If

        End If


        If TxCliente.Text.Trim = "" Then
            BtBuscaDestino.CL_Filtro = ""
        Else
            BtBuscaDestino.CL_Filtro = "IDCLIENTE=" + TxCliente.Text
        End If


        If edicion Then

            If TxDato_6.Text.Trim = "" Then
                TxDato_6.Text = Clientes.CLI_Iddivisa.Valor
                TxDato_6.Validar(edicion)
            End If

        End If

    End Sub


    Private Sub TxDato_27_Valida(edicion As Boolean) Handles TxDato_27.Valida

        If edicion = True Then
            If TxDato_28.Text = "" Then
                TxDato_28.Text = Tipoprecio
            End If
        End If
    End Sub

    Private Sub TxDato_29_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato_29.TextChanged

    End Sub

    Private Sub TxDato_29_Valida(edicion As Boolean) Handles TxDato_29.Valida
        If edicion = True Then
            If VaDec(TxDato_29.Text) = 0 Then
                TxDato_29.Text = TxDato_27.Text
            End If

            If TxDato1.Text = "F" Then
                If VaDec(TxDato_29.Text) <> VaDec(TxDato_27.Text) Then
                    MsgBox("Albaran en firme. El precio estimado debe ser el de salida")
                    TxDato_29.Text = TxDato_27.Text

                End If
                TxDato_30.Text = TxDato_28.Text

            End If
        End If

    End Sub

    Private Sub TxDato5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato5.TextChanged

    End Sub

    Private Sub TxDato5_Valida(edicion As Boolean) Handles TxDato5.Valida
        If edicion = True Then
            If TxDato5.Text <> "C" Then
                TxDato5.Text = "F"
            End If
        End If
    End Sub


    Private Sub TxDomicilio_Valida(edicion As System.Boolean) Handles TxDomicilio.Valida

        Dim IdDomicilio As Integer = ClientesDescargas.LeerDomi(TxCliente.Text, TxDomicilio.Text)
        If IdDomicilio > 0 Then
            If ClientesDescargas.LeerId(IdDomicilio) = True Then
                LbnomDestino.Text = ClientesDescargas.CLD_Domicilio.Valor
                TxDomicilio.MiError = False
            Else
                TxDomicilio.MiError = True
            End If
        End If

    End Sub

    Private Sub TxDato_28_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato_28.TextChanged

    End Sub

    Private Sub TxDato_30_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato_30.TextChanged

    End Sub

    Private Sub TxDato_30_Valida(edicion As Boolean) Handles TxDato_30.Valida
        If edicion = True Then
            If TxDato_30.Text = "" Then
                TxDato_30.Text = TxDato_28.Text
            End If
        End If
    End Sub


    Public Overrides Sub BotonAuxiliar3()

        If VaDec(LbId.Text) > 0 Then
            C1_EnviarAlbaranSalida(LbId.Text)
            MsgBox("Enviado!")
        End If

    End Sub


    Private Sub BtBuscaPedido_Click(sender As System.Object, e As System.EventArgs) Handles BtBuscaPedido.Click
        BuscaPEd()
    End Sub


    Private Sub BuscaPEd()

        Dim lst As New List(Of Parametros)
        Dim Fedia As String = TxDato_2.Text
        If Fedia = "" Then
            Fedia = Format(Now, "dd/MM/yyyy")
        End If


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Pedidos.PED_idpedido, "idpedido")
        consulta.SelCampo(Pedidos.PED_pedido, "Pedido")
        consulta.SelCampo(Pedidos.PED_fechasalida, "FechaSalida")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", Pedidos.PED_idcliente)
        consulta.SelCampo(Pedidos.PED_referencia, "Referencia")
        consulta.SelCampo(Pedidos.PED_matriculacamion, "Matricula")
        consulta.SelCampo(Transportistas.TTA_Nombre, "Transportista", Pedidos.PED_idtransportista)
        consulta.SelCampo(Albsalida.ASA_albaran, "Albaran", Pedidos.PED_idpedido, Albsalida.ASA_idpedido)
        consulta.WheCampo(Albsalida.ASA_idcentro, "=", MiMaletin.IdCentro.ToString)
        consulta.WheCampo(Albsalida.ASA_ejercicio, "=", MiMaletin.Ejercicio.ToString)

        Dim sql As String = consulta.SQL
        sql = sql & " AND COALESCE(ASA_idpedido,0) > 0"

        Dim dt As DataTable = Pedidos.MiConexion.ConsultaSQL(SQL)
        If Not IsNothing(dt) Then
            dt.Columns.Add("Palets", GetType(Decimal))
            For Each rw In dt.Rows
                rw("Palets") = PaletsPedidos(VaInt(rw("idpedido")))
            Next
        End If



        lst.Add(New Parametros("idpedido", False, "", -1))
        lst.Add(New Parametros("Pedido", False, "", 100))
        lst.Add(New Parametros("FechaSalida", False, "", 150))
        lst.Add(New Parametros("Cliente", False, "", 300))
        lst.Add(New Parametros("Referencia", False, "", 200))
        lst.Add(New Parametros("Matricula", False, "", 200))
        lst.Add(New Parametros("Transportista", False, "", 200))
        lst.Add(New Parametros("Albaran", False, "", 100))
        lst.Add(New Parametros("Palets", True, "{0:n0}", 100))



        Dim f As New FrConsultaGenerica(dt, lst, "Pedidos pendientes del dia")
        f.ShowDialog()

        If TxDato_1.Enabled Then
            If Not IsNothing(RowDePaso) Then
                Dim IdAlbaran As Integer = VaInt(RowDePaso("Albaran"))
                If IdAlbaran > 0 Then
                    TxDato_1.Text = IdAlbaran.ToString
                    Siguiente(TxDato_1.Orden)
                End If
            End If
        End If



    End Sub


    Private Function PaletsPedidos(idpedido As Integer) As Decimal
        Dim ret As Decimal = 0
        Dim sql As String = "Select sum(PEL_PALETS) as palets from pedidos_lineas where pel_idpedido=" + idpedido.ToString
        Dim dt As DataTable = Pedidos.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            ret = VaDec(dt.Rows(0)("palets"))
        End If
        Return ret
    End Function


    Private Sub TxDato_1_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxDato_1.EnabledChanged
        BtBuscaPedido.Enabled = TxDato_1.Enabled
    End Sub


    Private Sub TxDato_2_Valida(edicion As System.Boolean) Handles TxDato_2.Valida

        If edicion = True Then
            Dim E As String = ControlaFecha(TxDato_2.Text)
            If E <> "" Then
                MsgBox(E)
                TxDato_2.MiError = True
            End If
        End If

    End Sub


    Private Sub btPrecios_Click(sender As System.Object, e As System.EventArgs) Handles btPrecios.Click

        If Modificando = True Then
            Dim frm As New FrmCambioPreciosAlbaran(LbId.Text)
            frm.ShowDialog()
            CargaLineasGrid()
        End If

    End Sub


    Private Sub BtVpalets_Click(sender As System.Object, e As System.EventArgs) Handles BtVpalets.Click

        If VaInt(Albsalida_lineas.ASL_idlinea.Valor) > 0 Then

            Dim idlineasalida As Integer = VaInt(Albsalida_lineas.ASL_idlinea.Valor)
            If idlineasalida > 0 Then
                Dim lst As New List(Of Parametros)
                lst.Add(New Parametros("Serie", False, "", 100))
                lst.Add(New Parametros("Palet", False, "", 150))
                lst.Add(New Parametros("Fecha", False, "", 200))
                lst.Add(New Parametros("Producto", False, "", 400))
                lst.Add(New Parametros("Bultos", True, "", 200))
                lst.Add(New Parametros("Kilos", True, "", 200))
                lst.Add(New Parametros("Norma", False, "", 200))

                Dim dt As DataTable = DTPaletsDelAlbaran(idlineasalida)

                If Not dt Is Nothing Then
                    If dt.Rows.Count > 0 Then
                        Dim f As New FrConsultaGenerica(dt, lst, "Palets del albarán")
                        f.ShowDialog()
                    Else
                        MsgBox("No hay palets asociados a esta línea de albarán")
                    End If
                End If
            Else
                MsgBox("Debe crear primero la linea de albarán")
                Exit Sub

            End If

        End If


    End Sub


    Private Function DTPaletsDelAlbaran(idlineasalida As Integer) As DataTable

        Dim consulta As New Cdatos.E_select
        Dim Palets As New E_palets(Idusuario, cn)
        Dim Palets_lineas As New E_palets_lineas(Idusuario, cn)

        consulta.SelCampo(Palets_lineas.PLL_idpalet)
        consulta.SelCampo(Palets.PAL_palet, "Palet", Palets_lineas.PLL_idpalet, Palets.PAL_idpalet)
        consulta.SelCampo(Palets.PAL_fecha, "Fecha")
        consulta.SelCampo(GenerosSalida.GES_DescripcionAlb, "Producto", Palets_lineas.PLL_idgensal)
        consulta.SelCampo(Palets_lineas.PLL_bultos, "Bultos")
        consulta.SelCampo(Palets_lineas.PLL_kiloscliente, "Kilos")
        consulta.WheCampo(Palets_lineas.PLL_IdLineaSalida, "=", idlineasalida.ToString)
        consulta.WheCampo(Palets.PAL_palet, ">", "0")

        Dim sql As String = consulta.SQL


        Dim dt As DataTable = Palets_lineas.MiConexion.ConsultaSQL(sql)

        Return dt

    End Function


    Private Sub btModificarTipoFianzaValeEnvase_Click(sender As System.Object, e As System.EventArgs) Handles btModificarTipoFianzaValeEnvase.Click

        If VaDec(LbId.Text) > 0 Then
            If VaDec(Albsalida.ASA_idvaleenvase.Valor) > 0 Then

                Dim fr As New FrmModificarTipoFianzaEnvase("SC")
                fr.init(Albsalida.ASA_idvaleenvase.Valor)
                fr.ShowDialog()

            End If
        End If

    End Sub

End Class