Imports DevExpress.XtraEditors

Public Class FrmValoraAlb
    Inherits FrMantenimiento




    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Categorias As New E_CategoriasSalida(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Albsalida As New E_AlbSalida(Idusuario, cn)
    Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
    Dim OrigenGastos As New E_OrigenGastos(Idusuario, cn)
    Dim Albsalida_gastos As New E_albsalida_gastos(Idusuario, cn)
    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
    Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim GastosComercio As New E_GastosComercio(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Pedidos As New E_Pedidos(Idusuario, cn)

    Dim Valorespventa As New E_valorespventa(Idusuario, cn)
    Dim FacturasRecibidas As New E_Facturasrecibidas(Idusuario, cn)
    Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)


    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim MiCentro As String
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Moneda As New E_Moneda(Idusuario, cn)
    Dim _Idreclama As Integer = 0



    Private Class Desglose

        Public Class LineaDesglose
            Public Bultos As Integer = 0
            Public Kilos As Decimal = 0
            Public Piezas As Integer = 0
            Public Precio As Decimal = 0
            Public Tipo As String = ""
            Public Importe As Decimal = 0

            Public Sub New()

            End Sub

            Public Sub New(Bultos As Integer, Kilos As Decimal, piezas As Integer, precio As Decimal, tipo As String, importe As Decimal)
                Me.Bultos = Bultos
                Me.Kilos = Kilos
                Me.Piezas = piezas
                Me.Precio = precio
                Me.Tipo = tipo
                Me.Importe = importe
            End Sub

        End Class

        Public Linea As New List(Of LineaDesglose)

        Public Sub New(frm As FrmValoraAlb)

            For indice As Integer = 0 To 5
                Linea.Add(New LineaDesglose)
            Next



            With frm

                'En la línea 0 guardo la línea madre

                '0
                Linea(0).Bultos = VaInt(.TxDato2.Text)
                Linea(0).Kilos = VaDec(.TxDato3.Text)
                Linea(0).Piezas = VaInt(.TxDato4.Text)
                Linea(0).Precio = VaDec(.TxDato_27.Text)
                Linea(0).Tipo = .TxDato_28.Text.Trim
                Linea(0).Importe = VaDec(.TxDato_30.Text)


                '1
                Linea(1).Bultos = VaInt(.TxBul1.Text)
                Linea(1).Kilos = VaDec(.TxKil1.Text)
                Linea(1).Piezas = VaInt(.TxPieza1.Text)
                Linea(1).Precio = VaDec(.TxPrecio1.Text)
                Linea(1).Tipo = .TxTipo1.Text.Trim
                Linea(1).Importe = VaDec(.TxImporte1.Text)

                '2
                Linea(2).Bultos = VaInt(.TxBul2.Text)
                Linea(2).Kilos = VaDec(.TxKil2.Text)
                Linea(2).Piezas = VaInt(.TxPieza2.Text)
                Linea(2).Precio = VaDec(.TxPrecio2.Text)
                Linea(2).Tipo = .TxTipo2.Text.Trim
                Linea(2).Importe = VaDec(.TxImporte2.Text)

                '3
                Linea(3).Bultos = VaInt(.TxBul3.Text)
                Linea(3).Kilos = VaDec(.TxKil3.Text)
                Linea(3).Piezas = VaInt(.TxPieza3.Text)
                Linea(3).Precio = VaDec(.TxPrecio3.Text)
                Linea(3).Tipo = .TxTipo3.Text.Trim
                Linea(3).Importe = VaDec(.TxImporte3.Text)

                '4
                Linea(4).Bultos = VaInt(.TxBul4.Text)
                Linea(4).Kilos = VaDec(.TxKil4.Text)
                Linea(4).Piezas = VaInt(.TxPieza4.Text)
                Linea(4).Precio = VaDec(.TxPrecio4.Text)
                Linea(4).Tipo = .TxTipo4.Text.Trim
                Linea(4).Importe = VaDec(.TxImporte4.Text)

                '5
                Linea(5).Bultos = VaInt(.TxBul5.Text)
                Linea(5).Kilos = VaDec(.TxKil5.Text)
                Linea(5).Piezas = VaInt(.TxPieza5.Text)
                Linea(5).Precio = VaDec(.TxPrecio5.Text)
                Linea(5).Tipo = VaDec(.TxTipo5.Text)
                Linea(5).Importe = VaDec(.TxImporte5.Text)


            End With


        End Sub

    End Class




    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub




    Private Sub ParametrosFrm()
        EntidadFrm = Albsalida


        Dim lc As New List(Of Object)
        ListaControles = lc



        LbPuntoVenta.CL_ControlAsociado = TxDato_1
        LbNomPv.CL_ControlAsociado = TxDato_1
        CampoClave = 0 ' ultimo campo de la clave

        ParamTx(TxDato_1, Albsalida.ASA_albaran, Lb_1, True)
        ParamTx(TxDato1, Albsalida.ASA_fechavaloracion, Lb2, False)

        TxDato_1.Autonumerico = False
        ParamTx(TxDato5, Albsalida.ASA_refvaloracion, Lb16, False)

        ParamTx(TxDato_6, Albsalida.ASA_iddivisa, Lb_6, True)
        ParamTx(TxDato_7, Albsalida.ASA_valorcambio, Lb_7, True)


        ParamTx(TxDato2, Albsalida_lineas.ASL_bultosvendidos, Lb_23, False)





        ParamTx(TxDato3, Albsalida_lineas.ASL_kilosvendidos, Lb6, False, , 0)
        ParamTx(TxDato4, Albsalida_lineas.ASL_piezasvendidas, Lb_26, False)
        ParamTx(TxDato_27, Albsalida_lineas.ASL_precioventa, Lb_27, False)
        ParamTx(TxDato_28, Albsalida_lineas.ASL_tipopreciovta, Lb_27, True)
        ParamTx(TxDato_30, Albsalida_lineas.ASL_importegenerovta, Lb_27, False, , 2)

        AsociarControles(TxDato_1, BtBuscaAlbaran, Albsalida.btBusca, Albsalida)
        BtBuscaAlbaran.CL_Filtro = "EMP=" + MiMaletin.IdEmpresaCTB.ToString
        AsociarControles(TxDato_6, BtBusca6, Moneda.btBusca, Moneda, Moneda.MON_Nombre, Lbnom_6)


        AsociarGrid(ClGrid1, TxDato2, TxDato_30, Albsalida_lineas)

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


        ClGrid1.AñadirLinea = False

        ParamTx(TxDato22, Albsalida_gastos.ASG_idgasto, Lb32, True)
        ParamCb_Copia(CbBox2, Albsalida_gastos.ASG_tipokbp, Lb8, Combos.ComboGastos)
        ParamTx(TxDato10, Albsalida_gastos.ASG_valorgasto, Lb12, False)
        ParamTx(TxDato6, Albsalida_gastos.ASG_tipofc, Lb13, True)
        ParamTx(TxDato11, Albsalida_gastos.ASG_idacreedor, Lb7, False)

        AsociarGrid(ClGrid2, TxDato22, TxDato11, Albsalida_gastos)

        PropiedadesCamposGr(ClGrid2, "ASG_id", "ASG_id", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid2, "Gasto", "Gasto", True, 30)
        PropiedadesCamposGr(ClGrid2, "Valor", "Valor", True, 10, False, "#0.0000")
        PropiedadesCamposGr(ClGrid2, "KBP", "KBP", True, 10)
        PropiedadesCamposGr(ClGrid2, "FC", "FC", True, 10)
        PropiedadesCamposGr(ClGrid2, "Importe", "Importe", True, 15, True)


        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False


        ParamTx(TxBul1, Nothing, Lb_23, False, Cdatos.TiposCampo.Entero, 0, 6)
        ParamTx(TxKil1, Nothing, Lb_23, False, Cdatos.TiposCampo.Importe, 0, 8)
        ParamTx(TxPieza1, Nothing, Lb_23, False, Cdatos.TiposCampo.Entero, 0, 6)
        ParamTx(TxPrecio1, Nothing, Lb_23, False, Cdatos.TiposCampo.Importe, 4, 10)
        ParamTx(TxTipo1, Nothing, Lb_23, False, Cdatos.TiposCampo.Cadena, 1, , "KBP")
        ParamTx(TxImporte1, Nothing, Lb_23, False, Cdatos.TiposCampo.Importe, 2, 10)

        ParamTx(TxBul2, Nothing, Lb_23, False, Cdatos.TiposCampo.Entero, 0, 6)
        ParamTx(TxKil2, Nothing, Lb_23, False, Cdatos.TiposCampo.Importe, 0, 8)
        ParamTx(TxPieza2, Nothing, Lb_23, False, Cdatos.TiposCampo.Entero, 0, 6)
        ParamTx(TxPrecio2, Nothing, Lb_23, False, Cdatos.TiposCampo.Importe, 4, 10)
        ParamTx(TxTipo2, Nothing, Lb_23, False, Cdatos.TiposCampo.Cadena, 1, , "KBP")
        ParamTx(TxImporte2, Nothing, Lb_23, False, Cdatos.TiposCampo.Importe, 2, 10)


        ParamTx(TxBul3, Nothing, Lb_23, False, Cdatos.TiposCampo.Entero, 0, 6)
        ParamTx(TxKil3, Nothing, Lb_23, False, Cdatos.TiposCampo.Importe, 0, 8)
        ParamTx(TxPieza3, Nothing, Lb_23, False, Cdatos.TiposCampo.Entero, 0, 6)
        ParamTx(TxPrecio3, Nothing, Lb_23, False, Cdatos.TiposCampo.Importe, 4, 10)
        ParamTx(TxTipo3, Nothing, Lb_23, False, Cdatos.TiposCampo.Cadena, 1, , "KBP")
        ParamTx(TxImporte3, Nothing, Lb_23, False, Cdatos.TiposCampo.Importe, 2, 10)

        ParamTx(TxBul4, Nothing, Lb_23, False, Cdatos.TiposCampo.Entero, 0, 6)
        ParamTx(TxKil4, Nothing, Lb_23, False, Cdatos.TiposCampo.Importe, 0, 8)
        ParamTx(TxPieza4, Nothing, Lb_23, False, Cdatos.TiposCampo.Entero, 0, 6)
        ParamTx(TxPrecio4, Nothing, Lb_23, False, Cdatos.TiposCampo.Importe, 4, 10)
        ParamTx(TxTipo4, Nothing, Lb_23, False, Cdatos.TiposCampo.Cadena, 1, , "KBP")
        ParamTx(TxImporte4, Nothing, Lb_23, False, Cdatos.TiposCampo.Importe, 2, 10)

        ParamTx(TxBul5, Nothing, Lb_23, False, Cdatos.TiposCampo.Entero, 0, 6)
        ParamTx(TxKil5, Nothing, Lb_23, False, Cdatos.TiposCampo.Importe, 0, 8)
        ParamTx(TxPieza5, Nothing, Lb_23, False, Cdatos.TiposCampo.Entero, 0, 6)
        ParamTx(TxPrecio5, Nothing, Lb_23, False, Cdatos.TiposCampo.Importe, 4, 10)
        ParamTx(TxTipo5, Nothing, Lb_23, False, Cdatos.TiposCampo.Cadena, 1, , "KBP")
        ParamTx(TxImporte5, Nothing, Lb_23, False, Cdatos.TiposCampo.Importe, 2, 10)





        AsociarControles(TxDato22, BtBuscaGasto, GastosComercio.btBusca, GastosComercio, GastosComercio.GCO_Nombre, Lb1)
        AsociarControles(TxDato11, BtBuscaAcreedor, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomAcreedor)

        ' BotonesAvance1.Mientidad = EntidadFrm
        ' BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        ' BotonesAvance1.Formulario = Me

        Lb_26.CL_ControlAsociado = TxDato_27
        BAnular.Visible = False



        FiltroEntidad.Add(Albsalida.ASA_ejercicio.NombreCampo, MiMaletin.Ejercicio.ToString)
        FiltroEntidad.Add(Albsalida.ASA_IdEmpresa.NombreCampo, MiMaletin.IdEmpresaCTB.ToString)


    End Sub


    Private Sub FrmValoraAlb_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BTaux1.Visible = True
        BTaux1.Text = "Imprimir"
        BTaux1.Image = PictureBox1.Image

        BtAux2.Visible = True
        BtAux2.Text = "I.Directa"
        BtAux2.Image = PictureBox2.Image

    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)

        MyBase.Borralin(gr)
        If gr Is ClGrid1 Then
            Lbnom_10.Text = ""
            Lbnom_11.Text = ""

            Lbnom_19.Text = ""
            Lbnom_21.Text = ""

            LbPalets.Text = ""
            LbBultos.Text = ""
            LbKCliente.Text = ""
            LbPiezas.Text = ""
            LbPrecio.Text = ""
            LbPEstimado.Text = ""
            LbTipoPrecio.Text = "K"
            LbImporteSal.Text = ""
            LbPEstimado.Text = ""
            LbDifBul.Text = ""
            LbDifKil.Text = ""
            LbDifPiezas.Text = ""
            LbDifImporte.Text = ""

            TxBul1.Text = ""
            TxBul2.Text = ""
            TxBul3.Text = ""
            TxBul4.Text = ""
            TxBul5.Text = ""

            TxKil1.Text = ""
            TxKil2.Text = ""
            TxKil3.Text = ""
            TxKil4.Text = ""
            TxKil5.Text = ""

            TxPieza1.Text = ""
            TxPieza2.Text = ""
            TxPieza3.Text = ""
            TxPieza4.Text = ""
            TxPieza5.Text = ""

            TxPrecio1.Text = ""
            TxPrecio2.Text = ""
            TxPrecio3.Text = ""
            TxPrecio4.Text = ""
            TxPrecio5.Text = ""

            TxTipo1.Text = ""
            TxTipo2.Text = ""
            TxTipo3.Text = ""
            TxTipo4.Text = ""
            TxTipo5.Text = ""

            TxImporte1.Text = ""
            TxImporte2.Text = ""
            TxImporte3.Text = ""
            TxImporte4.Text = ""
            TxImporte5.Text = ""


        ElseIf gr Is ClGrid2 Then
            LbNuFactura.Text = ""
        End If

    End Sub
    Public Overrides Sub ControlClave()
        ' componemos la clave

        Dim i As Integer
        If TxDato_1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = Albsalida.LeerAlb(Lbejer.Text, MiCentro, TxDato_1.Text)
            If i > 0 Then
                LbId.Text = i.ToString
                If Albsalida.ASA_tipofc.Valor <> "C" Then
                    MsgBox("Albaran firme. No se puede valorar")
                    LbId.Text = ""
                End If

            Else


                '     If MsgBox("Registro inexistente. Desea crear uno nuevo", vbYesNo) = vbYes Then
                '                    LbId.Text = Cobros.MaxId
                ' LbId.Text = "+"
                ' Else
                ' LbId.Text = ""
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

        LbFechaSalida.Text = Albsalida.ASA_fechasalida.Valor
        _Idreclama = TieneReclamaciones(VaInt(LbId.Text))
        If _Idreclama > 0 Then
            BtReclama.Visible = True
        Else
            BtReclama.Visible = False
        End If
        If Clientes.LeerId(Albsalida.ASA_idcliente.Valor) = True Then
            LbCliente.Text = Clientes.CLI_Nombre.Valor

            RevisaCliente()


            If VaInt(TxDato_6.Text) = 0 Then
                TxDato_6.Text = Clientes.CLI_Iddivisa.Valor
                TxDato_6.Validar(False)

                Dim Moneda As New E_Moneda(Idusuario, cn)
                If Moneda.LeerId(Clientes.CLI_Iddivisa.Valor) Then
                    TxDato_7.Text = VaDec(Moneda.MON_Cambio.Valor).ToString("#,##0.000000")
                    TxDato_7.Validar(False)
                End If
            End If

        End If
        If Albsalida.ASA_fechavaloracion.Valor <> "01/01/1900" Then
            BtAnularValoracion.Visible = True
        Else
            BtAnularValoracion.Visible = False
        End If
        ' llenar el grid
        CargaLineasGrid()

    End Sub


    Private Sub RevisaCliente()

        Dim Clientes As New E_Clientes(Idusuario, cn)
        If VaInt(Albsalida.ASA_idcliente.Valor) > 0 Then
            If Clientes.LeerId(Albsalida.ASA_idcliente.Valor) Then

                Dim Actualizado As String = (Clientes.CLI_DatosActualizadosSN.Valor & "").Trim.ToUpper
                If Actualizado <> "S" Then
                    XtraMessageBox.Show("DATOS DE CLIENTE NO ACTUALIZADOS," & vbCrLf & "POR FAVOR, REVISAR", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            End If
        End If

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)


        If Grid Is ClGrid2 Then
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

            Dim IdLineaAlbSalida As String = (Albsalida_lineas.ASL_idlinea.Valor & "").Trim
            If VaInt(IdLineaAlbSalida) > 0 Then
                BorraDesglose()
                CargaLineasDesglose(IdLineaAlbSalida)
            End If


            OcultaPanelKilos()


            If Generos.LeerId(Albsalida_lineas.ASL_idgenero.Valor) = True Then
                Lbnom_10.Text = Generos.GEN_NombreGenero.Valor
            End If
            If ConfecEnvase.LeerId(Albsalida_lineas.ASL_idtipoconfeccion.Valor) = True Then
                Lbnom_11.Text = ConfecEnvase.CEV_Nombre.Valor
            End If
            '  If ConfecPalet.LeerId(Albsalida_lineas.ASL_idtipopalet.Valor) = True Then
            ' Lbnom_18.Text = ConfecPalet.CPA_Nombre.Valor
            'End If
            Lbnom_19.Text = Albsalida_lineas.ASL_categoria.Valor
            If Marcas.LeerId(Albsalida_lineas.ASL_idmarca.Valor) = True Then
                Lbnom_21.Text = Marcas.MAR_Nombre.Valor
            End If

            LbPalets.Text = Albsalida_lineas.ASL_palets.Valor
            LbBultos.Text = Albsalida_lineas.ASL_bultos.Valor
            LbKCliente.Text = Format(VaInt(Albsalida_lineas.ASL_kiloscliente.Valor), "#,###")
            LbPiezas.Text = Albsalida_lineas.ASL_piezas.Valor
            LbPrecio.Text = Albsalida_lineas.ASL_precio.Valor
            LbPEstimado.Text = Albsalida_lineas.ASL_precioestimado.Valor
            LbTipoPrecio.Text = Albsalida_lineas.ASL_tipoprecio.Valor
            LbImporteSal.Text = Format(VaDec(Albsalida_lineas.ASL_importegenero.Valor), "#,###0.00")
            Imprimediflinea()
        End If
    End Sub


    Private Sub OcultaPanelKilos()

        PanelKilos.Visible = False

        TxBul1.Enabled = False
        TxBul2.Enabled = False
        TxBul3.Enabled = False
        TxBul4.Enabled = False
        TxBul5.Enabled = False

        TxKil1.Enabled = False
        TxKil2.Enabled = False
        TxKil3.Enabled = False
        TxKil4.Enabled = False
        TxKil5.Enabled = False

        TxPieza1.Enabled = False
        TxPieza2.Enabled = False
        TxPieza3.Enabled = False
        TxPieza4.Enabled = False
        TxPieza5.Enabled = False

        TxPrecio1.Enabled = False
        TxPrecio2.Enabled = False
        TxPrecio3.Enabled = False
        TxPrecio4.Enabled = False
        TxPrecio5.Enabled = False

        'TxTipo1.Enabled = False

    End Sub


    Private Sub MuestraPanelKilos()

        TxBul1.Enabled = True
        TxBul2.Enabled = True
        TxBul3.Enabled = True
        TxBul4.Enabled = True
        TxBul5.Enabled = True

        TxKil1.Enabled = True
        TxKil2.Enabled = True
        TxKil3.Enabled = True
        TxKil4.Enabled = True
        TxKil5.Enabled = True

        TxPieza1.Enabled = True
        TxPieza2.Enabled = True
        TxPieza3.Enabled = True
        TxPieza4.Enabled = True
        TxPieza5.Enabled = True

        TxPrecio1.Enabled = True
        TxPrecio2.Enabled = True
        TxPrecio3.Enabled = True
        TxPrecio4.Enabled = True
        TxPrecio5.Enabled = True

        PanelKilos.Visible = True

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas

        Dim r As Boolean
        Dim igenero As Double
        Dim u As Double
        Dim igasto As Double



        If LbId.Text = "+" Then
            LbId.Text = Albsalida.MaxId
            If TxDato_1.Text = "+" Then
                TxDato_1.Text = Albsalida.MaxIdCampa(Val(Lbejer.Text), Val(MiCentro))
            End If
        End If



        If Gr Is ClGrid1 Then

            Albsalida.ASA_ejercicio.Valor = Lbejer.Text
            Albsalida.ASA_idpuntoventa.Valor = LbPuntoVenta.Text
            Albsalida.ASA_idcentro.Valor = MiCentro


            Albsalida_lineas.ASL_idalbaran.Valor = LbId.Text
            u = 0
            Select Case TxDato_28.Text
                Case "K"
                    u = VaDec(TxDato3.Text)
                Case "B"
                    u = VaDec(TxDato2.Text)
                Case "P"
                    u = VaDec(TxDato4.Text)

            End Select
            igenero = u * VaDec(TxDato_27.Text)
            Albsalida_lineas.ASL_importegenerovta.Valor = igenero.ToString
            Albsalida_lineas.ASL_paletsvendidos.Valor = Albsalida_lineas.ASL_palets.Valor
            Albsalida_lineas.ASL_observaciones.Valor = Mid(TxObs.Text, 1, 250)

            Cargalineas(ClGrid2)
            CalculoTotales()

        End If



        If Gr Is ClGrid2 Then

            Albsalida_gastos.ASG_idalbaran.Valor = LbId.Text

            Select Case CbBox2.SelectedValue
                Case "B"
                    igasto = VaDec(LbTbultosVen.Text) * VaDec(TxDato10.Text)
                Case "K"
                    igasto = VaDec(LbTkilosVen.Text) * VaDec(TxDato10.Text)
                Case "P"
                    'igasto = VaDec(LbTpiezasVen.Text) * VaDec(TxDato10.Text)
                    igasto = VaDec(LbTPaletsSal.Text) * VaDec(TxDato10.Text)
                Case "%"
                    igasto = VaDec(LbTVentaVen.Text) * VaDec(TxDato10.Text) / 100
                Case "I"
                    igasto = VaDec(TxDato10.Text)


            End Select
            If VaDec(TxDato_7.Text) = 0 Then
                TxDato_7.Text = "1"
            End If
            Albsalida_gastos.ASG_importegastodivisa.Valor = igasto.ToString
            Albsalida_gastos.ASG_importegastoeuros.Valor = StDec(igasto * VaDec(TxDato_7.Text))
        End If


        If Gr Is ClGrid1 Then

            'Almaceno las líneas de desglose
            Dim DesgloseLineas As Desglose = New Desglose(Me)
            Dim IdLineaAlbSalida As String = Albsalida_lineas.ASL_idlinea.Valor & ""


            SqlGrid()
            r = MyBase.GuardarLineas(Gr)


            'Una vez que se ha creado el idlinea, guardo los desgloses que he almacenado

            GuardaLineasDesglose(IdLineaAlbSalida, DesgloseLineas)


            ' actualizar los gastos por si han cambiado el importe, los kilos, los bultos .......
            Agro_CalculoGastosTotalesAlbaran(LbId.Text, VaDec(TxDato_7.Text))


        Else

            SqlGrid()
            r = MyBase.GuardarLineas(Gr)

        End If





        CalculoTotales()

        Return r

    End Function





    Public Overrides Sub DespuesdeGuardarLinea(ByVal gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)

        'If gr Is ClGrid1 Then
        '    Dim IdLineaAlbSalida As String = Albsalida_lineas.ASL_idlinea.Valor & ""
        '    GuardaLineasDesglose(IdLineaAlbSalida)
        'End If


    End Sub


    Public Overrides Sub DespuesdeGuardar()

        Agro_CalculoGastosTotalesAlbaran(LbId.Text, VaDec(TxDato_7.Text))

        MyBase.DespuesdeGuardar()


        If NuevoRegistro Then
            C1_ImprimirValoracionAlbaran(LbId.Text, TipoImpresion.ImpresoraPorDefecto)
        Else
            If XtraMessageBox.Show("¿Desea imprimir la valoración?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                C1_ImprimirValoracionAlbaran(LbId.Text, TipoImpresion.ImpresoraPorDefecto)
            End If
        End If


        'Dim frm As New FrmComprobarPalets(LbId.Text)
        'frm.MdiParent = Me.MdiParent
        'frm.Show()


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
        Dim Dt As New DataTable


        CONSULTA.SelCampo(Albsalida_lineas.ASL_idlinea, "ASL_idlinea")
        CONSULTA.SelCampo(Albsalida_lineas.ASL_idgenero, "Codigo")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Producto", Albsalida_lineas.ASL_idgenero)
        CONSULTA.SelCampo(ConfecEnvase.CEV_Nombre, "Envase", Albsalida_lineas.ASL_idtipoconfeccion)
        CONSULTA.SelCampo(Albsalida_lineas.ASL_categoria, "Categoria")
        CONSULTA.SelCampo(Albsalida_lineas.ASL_paletsvendidos, "Palets")
        CONSULTA.SelCampo(Albsalida_lineas.ASL_bultosvendidos, "Bultos")
        CONSULTA.SelCampo(Albsalida_lineas.ASL_kilosvendidos, "Kilos")
        CONSULTA.SelCampo(Albsalida_lineas.ASL_precioventa, "Precio")
        CONSULTA.SelCampo(Albsalida_lineas.ASL_tipopreciovta, "TP")
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


    Private Sub CargaLineasDesglose(ByVal IdLineaAlbSalida As String)

        Dim AlbSalida_Lineas_Desglose As New E_AlbSalida_Lineas_Desglose(Idusuario, cn)
        Dim dt As DataTable = AlbSalida_Lineas_Desglose.DesgloseLinea(IdLineaAlbSalida)

        Dim lineas As Integer = 0

        If Not IsNothing(dt) Then

            lineas = dt.Rows.Count

            For indice As Integer = 0 To dt.Rows.Count - 1
                If indice < 5 Then

                    Dim row As DataRow = dt.Rows(indice)

                    Select Case indice

                        Case 0
                            TxBul1.Text = VaInt(row("ASD_BultosVendidos"))
                            TxKil1.Text = VaDec(row("ASD_KilosVendidos"))
                            TxPieza1.Text = VaInt(row("ASD_PiezasVendidas"))
                            TxPrecio1.Text = VaDec(row("ASD_PrecioVenta"))
                            TxTipo1.Text = (row("ASD_TipoKBP").ToString & "").Trim
                            TxImporte1.Text = VaDec(row("ASD_ImporteVenta"))
                        Case 1
                            TxBul2.Text = VaInt(row("ASD_BultosVendidos"))
                            TxKil2.Text = VaDec(row("ASD_KilosVendidos"))
                            TxPieza2.Text = VaInt(row("ASD_PiezasVendidas"))
                            TxPrecio2.Text = VaDec(row("ASD_PrecioVenta"))
                            TxTipo2.Text = (row("ASD_TipoKBP").ToString & "").Trim
                            TxImporte2.Text = VaDec(row("ASD_ImporteVenta"))
                        Case 2
                            TxBul3.Text = VaInt(row("ASD_BultosVendidos"))
                            TxKil3.Text = VaDec(row("ASD_KilosVendidos"))
                            TxPieza3.Text = VaInt(row("ASD_PiezasVendidas"))
                            TxPrecio3.Text = VaDec(row("ASD_PrecioVenta"))
                            TxTipo3.Text = (row("ASD_TipoKBP").ToString & "").Trim
                            TxImporte3.Text = VaDec(row("ASD_ImporteVenta"))

                        Case 3
                            TxBul4.Text = VaInt(row("ASD_BultosVendidos"))
                            TxKil4.Text = VaDec(row("ASD_KilosVendidos"))
                            TxPieza4.Text = VaInt(row("ASD_PiezasVendidas"))
                            TxPrecio4.Text = VaDec(row("ASD_PrecioVenta"))
                            TxTipo4.Text = (row("ASD_TipoKBP").ToString & "").Trim
                            TxImporte4.Text = VaDec(row("ASD_ImporteVenta"))

                        Case 4
                            TxBul5.Text = VaInt(row("ASD_BultosVendidos"))
                            TxKil5.Text = VaDec(row("ASD_KilosVendidos"))
                            TxPieza5.Text = VaInt(row("ASD_PiezasVendidas"))
                            TxPrecio5.Text = VaDec(row("ASD_PrecioVenta"))
                            TxTipo5.Text = (row("ASD_TipoKBP").ToString & "").Trim
                            TxImporte5.Text = VaDec(row("ASD_ImporteVenta"))


                    End Select


                End If
            Next
        End If


        TxObs.Text = Albsalida_lineas.ASL_observaciones.Valor
        SumarValoracion()

    End Sub


    'Private Sub GuardaLineasDesglose(ByVal IdLineaAlbSalida As String)

    '    'Borra datos anteriores
    '    Dim AlbSalida_Lineas_Desglose As New E_AlbSalida_Lineas_Desglose(Idusuario, cn)
    '    AlbSalida_Lineas_Desglose.BorrarDesgloseLinea(IdLineaAlbSalida)


    '    'Si no existe desglose, introducir una sóla línea

    '    If VaDec(TxImporte1.Text) = 0 And VaDec(TxImporte2.Text) = 0 And VaDec(TxImporte3.Text) = 0 And VaDec(TxImporte4.Text) = 0 And VaDec(TxImporte5.Text) = 0 Then

    '        AlbSalida_Lineas_Desglose.ASD_Id.Valor = AlbSalida_Lineas_Desglose.MaxId()
    '        AlbSalida_Lineas_Desglose.ASD_IdLineaAlbSalida.Valor = IdLineaAlbSalida
    '        AlbSalida_Lineas_Desglose.ASD_IdAlbaran.Valor = LbId.Text
    '        AlbSalida_Lineas_Desglose.ASD_BultosVendidos.Valor = VaInt(TxDato2.Text)
    '        AlbSalida_Lineas_Desglose.ASD_KilosVendidos.Valor = VaDec(TxDato3.Text)
    '        AlbSalida_Lineas_Desglose.ASD_PiezasVendidas.Valor = VaInt(TxDato4.Text)
    '        AlbSalida_Lineas_Desglose.ASD_PrecioVenta.Valor = VaDec(TxDato_27.Text)
    '        AlbSalida_Lineas_Desglose.ASD_TipoKBP.Valor = TxDato_28.Text
    '        AlbSalida_Lineas_Desglose.ASD_ImporteVenta.Valor = TxDato_30.Text
    '        AlbSalida_Lineas_Desglose.Insertar()

    '    Else
    '        'Si existe desglose, introducirlas todas
    '        If VaDec(TxBul1.Text) <> 0 Or VaDec(TxKil1.Text) <> 0 Or VaDec(TxPieza1.Text) <> 0 Or VaDec(TxImporte1.Text) <> 0 Then
    '            AlbSalida_Lineas_Desglose = New E_AlbSalida_Lineas_Desglose(Idusuario, cn)
    '            AlbSalida_Lineas_Desglose.ASD_Id.Valor = AlbSalida_Lineas_Desglose.MaxId()
    '            AlbSalida_Lineas_Desglose.ASD_IdLineaAlbSalida.Valor = IdLineaAlbSalida
    '            AlbSalida_Lineas_Desglose.ASD_IdAlbaran.Valor = LbId.Text
    '            AlbSalida_Lineas_Desglose.ASD_BultosVendidos.Valor = VaInt(TxBul1.Text)
    '            AlbSalida_Lineas_Desglose.ASD_KilosVendidos.Valor = VaDec(TxKil1.Text)
    '            AlbSalida_Lineas_Desglose.ASD_PiezasVendidas.Valor = VaInt(TxPieza1.Text)
    '            AlbSalida_Lineas_Desglose.ASD_PrecioVenta.Valor = VaDec(TxPrecio1.Text)
    '            AlbSalida_Lineas_Desglose.ASD_TipoKBP.Valor = TxTipo1.Text
    '            AlbSalida_Lineas_Desglose.ASD_ImporteVenta.Valor = TxImporte1.Text
    '            AlbSalida_Lineas_Desglose.Insertar()
    '        End If
    '        If VaDec(TxBul2.Text) <> 0 Or VaDec(TxKil2.Text) <> 0 Or VaDec(TxPieza2.Text) <> 0 Or VaDec(TxImporte2.Text) <> 0 Then
    '            AlbSalida_Lineas_Desglose = New E_AlbSalida_Lineas_Desglose(Idusuario, cn)
    '            AlbSalida_Lineas_Desglose.ASD_Id.Valor = AlbSalida_Lineas_Desglose.MaxId()
    '            AlbSalida_Lineas_Desglose.ASD_IdLineaAlbSalida.Valor = IdLineaAlbSalida
    '            AlbSalida_Lineas_Desglose.ASD_IdAlbaran.Valor = LbId.Text
    '            AlbSalida_Lineas_Desglose.ASD_BultosVendidos.Valor = VaInt(TxBul2.Text)
    '            AlbSalida_Lineas_Desglose.ASD_KilosVendidos.Valor = VaDec(TxKil2.Text)
    '            AlbSalida_Lineas_Desglose.ASD_PiezasVendidas.Valor = VaInt(TxPieza2.Text)
    '            AlbSalida_Lineas_Desglose.ASD_PrecioVenta.Valor = VaDec(TxPrecio2.Text)
    '            AlbSalida_Lineas_Desglose.ASD_TipoKBP.Valor = TxTipo2.Text
    '            AlbSalida_Lineas_Desglose.ASD_ImporteVenta.Valor = TxImporte2.Text
    '            AlbSalida_Lineas_Desglose.Insertar()
    '        End If
    '        If VaDec(TxBul3.Text) <> 0 Or VaDec(TxKil3.Text) <> 0 Or VaDec(TxPieza3.Text) <> 0 Or VaDec(TxImporte3.Text) <> 0 Then
    '            AlbSalida_Lineas_Desglose = New E_AlbSalida_Lineas_Desglose(Idusuario, cn)
    '            AlbSalida_Lineas_Desglose.ASD_Id.Valor = AlbSalida_Lineas_Desglose.MaxId()
    '            AlbSalida_Lineas_Desglose.ASD_IdLineaAlbSalida.Valor = IdLineaAlbSalida
    '            AlbSalida_Lineas_Desglose.ASD_IdAlbaran.Valor = LbId.Text
    '            AlbSalida_Lineas_Desglose.ASD_BultosVendidos.Valor = VaInt(TxBul3.Text)
    '            AlbSalida_Lineas_Desglose.ASD_KilosVendidos.Valor = VaDec(TxKil3.Text)
    '            AlbSalida_Lineas_Desglose.ASD_PiezasVendidas.Valor = VaInt(TxPieza3.Text)
    '            AlbSalida_Lineas_Desglose.ASD_PrecioVenta.Valor = VaDec(TxPrecio3.Text)
    '            AlbSalida_Lineas_Desglose.ASD_TipoKBP.Valor = TxTipo3.Text
    '            AlbSalida_Lineas_Desglose.ASD_ImporteVenta.Valor = TxImporte3.Text
    '            AlbSalida_Lineas_Desglose.Insertar()
    '        End If
    '        If VaDec(TxBul4.Text) <> 0 Or VaDec(TxKil4.Text) <> 0 Or VaDec(TxPieza4.Text) <> 0 Or VaDec(TxImporte4.Text) <> 0 Then
    '            AlbSalida_Lineas_Desglose = New E_AlbSalida_Lineas_Desglose(Idusuario, cn)
    '            AlbSalida_Lineas_Desglose.ASD_Id.Valor = AlbSalida_Lineas_Desglose.MaxId()
    '            AlbSalida_Lineas_Desglose.ASD_IdLineaAlbSalida.Valor = IdLineaAlbSalida
    '            AlbSalida_Lineas_Desglose.ASD_IdAlbaran.Valor = LbId.Text
    '            AlbSalida_Lineas_Desglose.ASD_BultosVendidos.Valor = VaInt(TxBul4.Text)
    '            AlbSalida_Lineas_Desglose.ASD_KilosVendidos.Valor = VaDec(TxKil4.Text)
    '            AlbSalida_Lineas_Desglose.ASD_PiezasVendidas.Valor = VaInt(TxPieza4.Text)
    '            AlbSalida_Lineas_Desglose.ASD_PrecioVenta.Valor = VaDec(TxPrecio4.Text)
    '            AlbSalida_Lineas_Desglose.ASD_TipoKBP.Valor = TxTipo4.Text
    '            AlbSalida_Lineas_Desglose.ASD_ImporteVenta.Valor = TxImporte4.Text
    '            AlbSalida_Lineas_Desglose.Insertar()
    '        End If
    '        If VaDec(TxBul5.Text) <> 0 Or VaDec(TxKil5.Text) <> 0 Or VaDec(TxPieza5.Text) <> 0 Or VaDec(TxImporte5.Text) <> 0 Then
    '            AlbSalida_Lineas_Desglose = New E_AlbSalida_Lineas_Desglose(Idusuario, cn)
    '            AlbSalida_Lineas_Desglose.ASD_Id.Valor = AlbSalida_Lineas_Desglose.MaxId()
    '            AlbSalida_Lineas_Desglose.ASD_IdLineaAlbSalida.Valor = IdLineaAlbSalida
    '            AlbSalida_Lineas_Desglose.ASD_IdAlbaran.Valor = LbId.Text
    '            AlbSalida_Lineas_Desglose.ASD_BultosVendidos.Valor = VaInt(TxBul5.Text)
    '            AlbSalida_Lineas_Desglose.ASD_KilosVendidos.Valor = VaDec(TxKil5.Text)
    '            AlbSalida_Lineas_Desglose.ASD_PiezasVendidas.Valor = VaInt(TxPieza5.Text)
    '            AlbSalida_Lineas_Desglose.ASD_PrecioVenta.Valor = VaDec(TxPrecio5.Text)
    '            AlbSalida_Lineas_Desglose.ASD_TipoKBP.Valor = TxTipo5.Text
    '            AlbSalida_Lineas_Desglose.ASD_ImporteVenta.Valor = TxImporte5.Text
    '            AlbSalida_Lineas_Desglose.Insertar()
    '        End If


    '    End If


    'End Sub


    Private Sub GuardaLineasDesglose(ByVal IdLineaAlbSalida As String, Desglose As Desglose)

        'Borra datos anteriores
        Dim AlbSalida_Lineas_Desglose As New E_AlbSalida_Lineas_Desglose(Idusuario, cn)
        AlbSalida_Lineas_Desglose.BorrarDesgloseLinea(IdLineaAlbSalida)


        'Si no existe desglose, introducir una sóla línea

        If Desglose.Linea(1).Importe = 0 And Desglose.Linea(2).Importe = 0 And Desglose.Linea(3).Importe = 0 And Desglose.Linea(4).Importe = 0 And Desglose.Linea(5).Importe = 0 Then

            With Desglose.Linea(0)

                AlbSalida_Lineas_Desglose.ASD_Id.Valor = AlbSalida_Lineas_Desglose.MaxId()
                AlbSalida_Lineas_Desglose.ASD_IdLineaAlbSalida.Valor = IdLineaAlbSalida
                AlbSalida_Lineas_Desglose.ASD_IdAlbaran.Valor = LbId.Text
                AlbSalida_Lineas_Desglose.ASD_BultosVendidos.Valor = .Bultos.ToString
                AlbSalida_Lineas_Desglose.ASD_KilosVendidos.Valor = .Kilos.ToString
                AlbSalida_Lineas_Desglose.ASD_PiezasVendidas.Valor = .Piezas.ToString
                AlbSalida_Lineas_Desglose.ASD_PrecioVenta.Valor = .Precio.ToString
                AlbSalida_Lineas_Desglose.ASD_TipoKBP.Valor = .Tipo
                AlbSalida_Lineas_Desglose.ASD_ImporteVenta.Valor = .Importe.ToString
                AlbSalida_Lineas_Desglose.Insertar()

            End With

        Else
            'Si existe desglose, introducirlas todas
            If Desglose.Linea(1).Bultos <> 0 Or Desglose.Linea(1).Kilos <> 0 Or Desglose.Linea(1).Piezas <> 0 Or Desglose.Linea(1).Importe <> 0 Then

                With Desglose.Linea(1)

                    AlbSalida_Lineas_Desglose = New E_AlbSalida_Lineas_Desglose(Idusuario, cn)
                    AlbSalida_Lineas_Desglose.ASD_Id.Valor = AlbSalida_Lineas_Desglose.MaxId()
                    AlbSalida_Lineas_Desglose.ASD_IdLineaAlbSalida.Valor = IdLineaAlbSalida
                    AlbSalida_Lineas_Desglose.ASD_IdAlbaran.Valor = LbId.Text
                    AlbSalida_Lineas_Desglose.ASD_BultosVendidos.Valor = .Bultos.ToString
                    AlbSalida_Lineas_Desglose.ASD_KilosVendidos.Valor = .Kilos.ToString
                    AlbSalida_Lineas_Desglose.ASD_PiezasVendidas.Valor = .Piezas.ToString
                    AlbSalida_Lineas_Desglose.ASD_PrecioVenta.Valor = .Precio.ToString
                    AlbSalida_Lineas_Desglose.ASD_TipoKBP.Valor = .Tipo
                    AlbSalida_Lineas_Desglose.ASD_ImporteVenta.Valor = .Importe.ToString
                    AlbSalida_Lineas_Desglose.Insertar()

                End With


            End If
            If Desglose.Linea(2).Bultos <> 0 Or Desglose.Linea(2).Kilos <> 0 Or Desglose.Linea(2).Piezas <> 0 Or Desglose.Linea(2).Importe <> 0 Then

                With Desglose.Linea(2)

                    AlbSalida_Lineas_Desglose = New E_AlbSalida_Lineas_Desglose(Idusuario, cn)
                    AlbSalida_Lineas_Desglose.ASD_Id.Valor = AlbSalida_Lineas_Desglose.MaxId()
                    AlbSalida_Lineas_Desglose.ASD_IdLineaAlbSalida.Valor = IdLineaAlbSalida
                    AlbSalida_Lineas_Desglose.ASD_IdAlbaran.Valor = LbId.Text
                    AlbSalida_Lineas_Desglose.ASD_BultosVendidos.Valor = .Bultos.ToString
                    AlbSalida_Lineas_Desglose.ASD_KilosVendidos.Valor = .Kilos.ToString
                    AlbSalida_Lineas_Desglose.ASD_PiezasVendidas.Valor = .Piezas.ToString
                    AlbSalida_Lineas_Desglose.ASD_PrecioVenta.Valor = .Precio.ToString
                    AlbSalida_Lineas_Desglose.ASD_TipoKBP.Valor = .Tipo
                    AlbSalida_Lineas_Desglose.ASD_ImporteVenta.Valor = .Importe.ToString
                    AlbSalida_Lineas_Desglose.Insertar()

                End With

            End If
            If Desglose.Linea(3).Bultos <> 0 Or Desglose.Linea(3).Kilos <> 0 Or Desglose.Linea(3).Piezas <> 0 Or Desglose.Linea(3).Importe <> 0 Then

                With Desglose.Linea(3)

                    AlbSalida_Lineas_Desglose = New E_AlbSalida_Lineas_Desglose(Idusuario, cn)
                    AlbSalida_Lineas_Desglose.ASD_Id.Valor = AlbSalida_Lineas_Desglose.MaxId()
                    AlbSalida_Lineas_Desglose.ASD_IdLineaAlbSalida.Valor = IdLineaAlbSalida
                    AlbSalida_Lineas_Desglose.ASD_IdAlbaran.Valor = LbId.Text
                    AlbSalida_Lineas_Desglose.ASD_BultosVendidos.Valor = .Bultos.ToString
                    AlbSalida_Lineas_Desglose.ASD_KilosVendidos.Valor = .Kilos.ToString
                    AlbSalida_Lineas_Desglose.ASD_PiezasVendidas.Valor = .Piezas.ToString
                    AlbSalida_Lineas_Desglose.ASD_PrecioVenta.Valor = .Precio.ToString
                    AlbSalida_Lineas_Desglose.ASD_TipoKBP.Valor = .Tipo
                    AlbSalida_Lineas_Desglose.ASD_ImporteVenta.Valor = .Importe.ToString
                    AlbSalida_Lineas_Desglose.Insertar()

                End With

            End If
            If Desglose.Linea(4).Bultos <> 0 Or Desglose.Linea(4).Kilos <> 0 Or Desglose.Linea(4).Piezas <> 0 Or Desglose.Linea(4).Importe <> 0 Then

                With Desglose.Linea(4)

                    AlbSalida_Lineas_Desglose = New E_AlbSalida_Lineas_Desglose(Idusuario, cn)
                    AlbSalida_Lineas_Desglose.ASD_Id.Valor = AlbSalida_Lineas_Desglose.MaxId()
                    AlbSalida_Lineas_Desglose.ASD_IdLineaAlbSalida.Valor = IdLineaAlbSalida
                    AlbSalida_Lineas_Desglose.ASD_IdAlbaran.Valor = LbId.Text
                    AlbSalida_Lineas_Desglose.ASD_BultosVendidos.Valor = .Bultos.ToString
                    AlbSalida_Lineas_Desglose.ASD_KilosVendidos.Valor = .Kilos.ToString
                    AlbSalida_Lineas_Desglose.ASD_PiezasVendidas.Valor = .Piezas.ToString
                    AlbSalida_Lineas_Desglose.ASD_PrecioVenta.Valor = .Precio.ToString
                    AlbSalida_Lineas_Desglose.ASD_TipoKBP.Valor = .Tipo
                    AlbSalida_Lineas_Desglose.ASD_ImporteVenta.Valor = .Importe.ToString
                    AlbSalida_Lineas_Desglose.Insertar()

                End With

            End If
            If Desglose.Linea(5).Bultos <> 0 Or Desglose.Linea(5).Kilos <> 0 Or Desglose.Linea(5).Piezas <> 0 Or Desglose.Linea(5).Importe <> 0 Then

                With Desglose.Linea(5)

                    AlbSalida_Lineas_Desglose = New E_AlbSalida_Lineas_Desglose(Idusuario, cn)
                    AlbSalida_Lineas_Desglose.ASD_Id.Valor = AlbSalida_Lineas_Desglose.MaxId()
                    AlbSalida_Lineas_Desglose.ASD_IdLineaAlbSalida.Valor = IdLineaAlbSalida
                    AlbSalida_Lineas_Desglose.ASD_IdAlbaran.Valor = LbId.Text
                    AlbSalida_Lineas_Desglose.ASD_BultosVendidos.Valor = .Bultos.ToString
                    AlbSalida_Lineas_Desglose.ASD_KilosVendidos.Valor = .Kilos.ToString
                    AlbSalida_Lineas_Desglose.ASD_PiezasVendidas.Valor = .Piezas.ToString
                    AlbSalida_Lineas_Desglose.ASD_PrecioVenta.Valor = .Precio.ToString
                    AlbSalida_Lineas_Desglose.ASD_TipoKBP.Valor = .Tipo
                    AlbSalida_Lineas_Desglose.ASD_ImporteVenta.Valor = .Importe.ToString
                    AlbSalida_Lineas_Desglose.Insertar()

                End With

            End If


        End If


    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        'If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString Then
        '    MsgBox("no se puede anular el albarán")
        '    Exit Sub
        'End If

        If VaInt(Albsalida.ASA_idfactura.Valor) <> 0 Then
            MsgBox("Albarán facturado")
            Exit Sub
        End If

        MyBase.BAnular_Click(sender, e)

    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        ' si está facturado, no se puede modificar
        'If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString Then
        '    MsgBox("no se puede modificar el albarán")
        '    Exit Sub
        'End If


        If VaInt(Albsalida.ASA_idfactura.Valor) <> 0 Then
            MsgBox("Albarán facturado")
            Exit Sub
        End If


        MyBase.BModificar_Click(sender, e)

    End Sub

    Protected Overrides Sub BGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If VaInt(Albsalida.ASA_idfactura.Valor) <> 0 Then
            MsgBox("Albarán facturado")
            Exit Sub
        End If

        MyBase.BGuardar_Click(sender, e)
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


    Public Overrides Sub BorraPan()

        MyBase.BorraPan()
        BtAnularValoracion.Visible = False
        PintaPuntoVenta(MiMaletin.IdPuntoVenta)
        Lbejer.Text = MiMaletin.Ejercicio
        BtReclama.Visible = False
        _Idreclama = 0
        BorraDesglose()

    End Sub


    Private Sub BorraDesglose()

        TxBul1.Text = ""
        TxBul2.Text = ""
        TxBul3.Text = ""
        TxBul4.Text = ""
        TxBul5.Text = ""

        TxKil1.Text = ""
        TxKil2.Text = ""
        TxKil3.Text = ""
        TxKil4.Text = ""
        TxKil5.Text = ""

        TxPieza1.Text = ""
        TxPieza2.Text = ""
        TxPieza3.Text = ""
        TxPieza4.Text = ""
        TxPieza5.Text = ""

        TxPrecio1.Text = ""
        TxPrecio2.Text = ""
        TxPrecio3.Text = ""
        TxPrecio4.Text = ""
        TxPrecio5.Text = ""

        TxTipo1.Text = TxDato_28.Text

        LbTBulV.Text = ""
        LbTKilV.Text = ""
        LbTPzaV.Text = ""
        LbTimporte.Text = ""

        OcultaPanelKilos()


    End Sub



    Private Sub CalculoLinea()
        Dim i As Double


        Select Case TxDato_28.Text
            Case "K"
                i = VaDec(TxDato3.Text) * VaDec(TxDato_27.Text)
            Case "B"
                i = VaDec(TxDato2.Text) * VaDec(TxDato_27.Text)
            Case "P"
                i = VaDec(TxDato4.Text) * VaDec(TxDato_27.Text)
        End Select
        TxDato_30.Text = Format(i, "#,###0.00")
        Imprimediflinea()

    End Sub
    Private Sub CalculoPrecioLinea()
        Dim i As Double
        Select Case TxDato_28.Text
            Case "K"
                If VaDec(TxDato3.Text) <> 0 Then
                    i = VaDec(TxDato_30.Text) / VaDec(TxDato3.Text)
                End If

            Case "B"
                If VaDec(TxDato2.Text) <> 0 Then
                    i = VaDec(TxDato_30.Text) / VaDec(TxDato2.Text)
                End If
            Case "P"
                If VaDec(TxDato4.Text) <> 0 Then
                    i = VaDec(TxDato_30.Text) / VaDec(TxDato4.Text)
                End If
        End Select
        TxDato_27.Text = Format(i, "#,###0.0000")
        Imprimediflinea()
    End Sub
    Private Sub Imprimediflinea()
        LbDifBul.Text = (VaInt(TxDato2.Text) - VaInt(LbBultos.Text)).ToString
        LbDifKil.Text = Format(VaDec(TxDato3.Text) - VaDec(LbKCliente.Text), "#,###")
        LbDifPiezas.Text = (VaInt(TxDato4.Text) - VaInt(LbPiezas.Text)).ToString
        LbDifImporte.Text = Format(VaDec(TxDato_30.Text) - VaDec(LbImporteSal.Text), "#,###0.00")

    End Sub

    Private Sub CalculoTotales()

        Dim sql As String

        sql = "Select sum(ASL_kiloscliente) as kilos, "
        sql = sql + " sum(ASL_palets) as palets, "
        sql = sql + " sum(ASL_bultos) as bultos, "
        sql = sql + " sum(ASL_piezas) as piezas, "
        sql = sql + " sum(ASL_importegenero) as igenero, "

        sql = sql + " sum(ASL_paletsvendidos) as paletsvta, "
        sql = sql + " sum(ASL_kilosvendidos) as kilosvta, "
        sql = sql + " sum(ASL_bultosvendidos) as bultosvta, "
        sql = sql + " sum(ASL_piezasvendidas) as piezasvta, "
        sql = sql + " sum(ASL_importegenerovta) as igenerovta "


        sql = sql + " from albsalida_lineas where ASL_idalbaran=" + LbId.Text

        Dim dt As DataTable = Albsalida_lineas.MiConexion.ConsultaSQL(sql)

        LbTVentaVen.Text = ""
        LbTEnvaseVen.Text = ""
        LbTkilosVen.Text = ""
        LbTbultosVen.Text = ""
        LbTpiezasVen.Text = ""

        LbTventaSal.Text = ""
        LbTkilosSal.Text = ""
        LbTBultosSal.Text = ""
        LbtPiezasSal.Text = ""

        LbTVentaDif.Text = ""
        LbTkilosDif.Text = ""
        LbTbultosDif.Text = ""
        LbTpiezasDif.Text = ""

        LbTotDivisa.Text = ""
        LbTotEuros.Text = ""


        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                LbTventaSal.Text = Format(VaDec(dt.Rows(0)("igenero")), "#,###0.00")
                LbTkilosSal.Text = Format(VaDec(dt.Rows(0)("kilos")), "#,###")
                LbTBultosSal.Text = dt.Rows(0)("bultos").ToString
                LbtPiezasSal.Text = dt.Rows(0)("piezas").ToString
                LbTPaletsSal.Text = dt.Rows(0)("palets").ToString

                LbTVentaVen.Text = Format(VaDec(dt.Rows(0)("igenerovta")), "#,###0.00")
                '  LbTEnvaseVen.Text = Format(VaDec(dt.Rows(0)("ipaletvta")) + VaDec(dt.Rows(0)("ienvasevta")), "#,###0.00")
                LbTkilosVen.Text = Format(VaDec(dt.Rows(0)("kilosvta")), "#,###")
                LbTbultosVen.Text = dt.Rows(0)("bultosvta").ToString
                LbTpiezasVen.Text = dt.Rows(0)("piezasvta").ToString


                LbTVentaDif.Text = Format(VaDec(LbTVentaVen.Text) - VaDec(LbTventaSal.Text), "#,###0.00")
                LbTkilosDif.Text = Format(VaDec(LbTkilosVen.Text) - VaDec(LbTkilosSal.Text), "#,###0.00")
                LbTbultosDif.Text = Format(VaDec(LbTbultosVen.Text) - VaDec(LbTBultosSal.Text), "#,###")
                LbTpiezasDif.Text = Format(VaDec(LbTpiezasVen.Text) - VaDec(LbtPiezasSal.Text), "#,###")
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

        TotalEnvases()
        LbGastosFac.Text = Format(gf, "#,###0.00")
        LbGastosCom.Text = Format(gc, "#,###0.00")
        LbTotDivisa.Text = Format(VaDec(LbTVentaVen.Text) + VaDec(LbTEnvaseVen.Text) - gf, "#,###0.00")
        LbTotEuros.Text = Format(VaDec(LbTotDivisa.Text) * VaDec(TxDato_7.Text), "#,###0.00")


    End Sub


    Private Sub TotalEnvases()
        Dim sql As String
        LbTEnvaseVen.Text = ""
        sql = "SELECT SUM(VEL_RETIRA*VEL_PRECIORETIRA)-SUM(VEL_ENTREGA*VEL_PRECIOENTREGA) AS ienvases FROM valeenvases_lineas where VEL_IDVALE=" + Albsalida.ASA_idvaleenvase.Valor
        Dim dte As DataTable = Albsalida.MiConexion.ConsultaSQL(sql)
        If Not dte Is Nothing Then
            If dte.Rows.Count > 0 Then
                LbTEnvaseVen.Text = Format(VaDec(dte.Rows(0)(0)), "#,###0.00")
            End If
        End If

    End Sub



    Public Overrides Sub Guardar()

        Albsalida.ASA_idpuntoventa.Valor = LbPuntoVenta.Text
        Albsalida.ASA_ejercicio.Valor = Lbejer.Text
        Albsalida.ASA_idcentro.Valor = MiCentro

        MyBase.Guardar()

    End Sub


    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub TxDato5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub TxDato2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato2.TextChanged

    End Sub

    Private Sub TxDato2_Valida(ByVal edicion As Boolean) Handles TxDato2.Valida

        If edicion = True Then

            If TxDato2.Text = "" Then
                TxDato2.Text = LbBultos.Text
            End If

            CalculoLinea()

            TxDato2.Siguiente = TxDato3.Orden

            'If TxDato2.MiError Then
            '    TxDato2.Select()
            '    TxDato2.Focus()
            'Else
            '    TxDato3.Select()
            '    TxDato3.Focus()
            'End If

        End If

    End Sub

    Private Sub TxDato3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato3.TextChanged

    End Sub

    Private Sub TxDato3_Valida(ByVal edicion As Boolean) Handles TxDato3.Valida
        If edicion = True Then
            If TxDato3.Text = "" Then
                TxDato3.Text = LbKCliente.Text
            End If
            CalculoLinea()
        End If

    End Sub

    Private Sub TxDato4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato4.TextChanged

    End Sub

    Private Sub TxDato4_Valida(ByVal edicion As Boolean) Handles TxDato4.Valida
        If edicion = True Then
            If TxDato4.Text = "" Then
                TxDato4.Text = LbPiezas.Text
            End If
            CalculoLinea()
        End If

    End Sub

    Private Sub TxDato_27_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_27.TextChanged

    End Sub

    Private Sub TxDato_27_Valida(ByVal edicion As Boolean) Handles TxDato_27.Valida
        If edicion = True Then
            If TxDato_27.Text = "" Then
                TxDato_27.Text = LbPrecio.Text
            End If
            CalculoLinea()
        End If

    End Sub

    Private Sub TxDato_28_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_28.TextChanged

    End Sub

    Private Sub TxDato_28_Valida(ByVal edicion As Boolean) Handles TxDato_28.Valida

        If edicion = True Then
            If TxDato_28.Text = "" Then
                TxDato_28.Text = LbTipoPrecio.Text
            End If
            CalculoLinea()
        End If

    End Sub

    Private Sub TxDato_29_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub LbDifPPalet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxDato_30_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub BtAnularValoracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAnularValoracion.Click
        ' si está facturado , no se puede anular

        If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString Then
            MsgBox("No se puede anular el albarán de otro punto de venta")
            Exit Sub
        End If

        If VaInt(Albsalida.ASA_idfactura.Valor) <> 0 Then
            MsgBox("Albarán facturado")
            Exit Sub
        End If

        If MsgBox("Desea anular la valoración", vbYesNo) = vbYes Then
            AnulaValoracion()
            BorraPan()
        End If
    End Sub


    Private Sub AnulaValoracion()

        Dim sql As String
        sql = "update albsalida_lineas set ASL_bultosvendidos=ASL_bultos, "
        sql = sql + " ASL_kilosvendidos=ASL_kiloscliente, "
        sql = sql + " ASL_piezasvendidas=ASL_piezas, "
        sql = sql + " ASL_paletsvendidos=ASL_palets, "
        sql = sql + " ASL_precioventa=ASL_precioestimado,"
        sql = sql + " ASL_tipopreciovta=ASL_tipoprecioestimado,"
        sql = sql + " ASL_importegenerovta=ASL_importegeneroestimado"
        sql = sql + " where asl_idalbaran=" + LbId.Text
        Albsalida_lineas.MiConexion.OrdenSql(sql)


        Agro_CalculoGastosTotalesAlbaran(LbId.Text, VaDec(TxDato_7.Text))
        'Agro_GeneraGastosLineas(LbId.Text, VaDec(TxDato_7.Text))

        Albsalida.ASA_fechavaloracion.Valor = ""
        Albsalida.Actualizar()

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Albsalida_lineas.ASL_idlinea, "id")
        consulta.WheCampo(Albsalida_lineas.ASL_idalbaran, "=", LbId.Text)
        sql = consulta.SQL
        Dim dt As DataTable = Albsalida_lineas.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                Dim AlbSalida_Lineas_Desglose As New E_AlbSalida_Lineas_Desglose(Idusuario, cn)
                Dim idlineaalbsalida As String = rw("id").ToString
                AlbSalida_Lineas_Desglose.BorrarDesgloseLinea(idlineaalbsalida)

            Next
        End If


    End Sub

    Private Sub TxDato1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato1.TextChanged

    End Sub

    Private Sub TxDato1_Valida(ByVal edicion As Boolean) Handles TxDato1.Valida
        If edicion = True Then
            If TxDato1.Text = "" Then
                TxDato1.Text = Now.ToShortDateString
            End If

        End If
    End Sub


    Private Sub TxDato_7_Valida(ByVal edicion As Boolean) Handles TxDato_7.Valida
        If edicion = True Then
            CalculoTotales()
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim id As Integer = 0
        id = VaInt(Albsalida.ASA_idvaleenvase.Valor)
        If id = 0 Then
            id = ValeEnvases.LeerVale(MiMaletin.Ejercicio, MiMaletin.IdCentro, "SC", TxDato_1.Text)
        End If

        If id > 0 Then
            Dim fr As New FrmValeEnvase("SC")
            ' fr.InitTipoVale("SC")
            fr.init(id)
            fr.ShowDialog()
            TotalEnvases()
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
                TxDato6.Text = GastosComercio.GCO_Tipogastofc.Valor

                If TxDato11.Text = "" Then
                    TxDato11.Text = GastosComercio.GCO_idacreedor.Valor
                End If
                If TxDato11.Text = "0" Then
                    TxDato11.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub TxBul1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxBul1.TextChanged
        If TxBul1.Text.Trim = "" Then
            Dim a As String = " "
        End If
    End Sub




    Private Sub BtDesgloseValoracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtDesgloseValoracion.Click

        'BorraDesglose()

        If VaInt(LbId.Text) > 0 Then

            Dim IdLineaAlbSalida As String = ""

            If ClGrid1.GridView.FocusedRowHandle >= 0 Then
                Try
                    IdLineaAlbSalida = (ClGrid1.GridView.GetDataRow(ClGrid1.GridView.FocusedRowHandle)("ASL_idlinea").ToString & "").Trim
                Catch ex As Exception
                End Try

            End If

            If VaInt(IdLineaAlbSalida) > 0 Then

                'CargaLineasDesglose(IdLineaAlbSalida)
                MuestraPanelKilos()

                TxBul1.Select()
                TxBul1.Focus()

            End If

        End If



    End Sub


    Private Sub ValidaBultos(ByRef Txd As TxDato)

        SumarValoracion()

        '  If Txd.Text = "" And Txd.Name.ToUpper.Trim.StartsWith("TXBUL") Then
        ' BtSumakilos.Focus()
        ' End If

    End Sub


    Private Sub TerminaPanelKilos()
        Dim preciomedio As Double

        SumarValoracion()

        TxDato_28.Text = TxTipo1.Text
        TxDato2.Text = LbTBulV.Text
        TxDato3.Text = LbTKilV.Text
        TxDato4.Text = LbTPzaV.Text
        TxDato_30.Text = LbTimporte.Text

        Select Case TxDato_28.Text
            Case "K"
                If VaDec(TxDato3.Text) <> 0 Then
                    preciomedio = VaDec(LbTimporte.Text) / VaDec(TxDato3.Text)
                End If
            Case "B"
                If VaDec(TxDato2.Text) <> 0 Then
                    preciomedio = VaDec(LbTimporte.Text) / VaDec(TxDato2.Text)
                End If
            Case "P"
                If VaDec(TxDato4.Text) <> 0 Then
                    preciomedio = VaDec(LbTimporte.Text) / VaDec(TxDato4.Text)
                End If

        End Select
        TxDato_27.Text = preciomedio.ToString


        OcultaPanelKilos()
        Siguiente(TxDato_30.Orden)

    End Sub


    Private Sub SumarValoracion()

        Dim bultos As Integer = 0
        Dim kilos As Integer = 0
        Dim piezas As Integer = 0
        Dim importe As Double = 0

        For Each tx As Control In Me.ListaControles
            If TypeOf (tx) Is TxDato Then
                If tx.Name.ToUpper.Trim.StartsWith("TXBUL") Then
                    bultos = bultos + VaInt(tx.Text)
                ElseIf tx.Name.ToUpper.Trim.StartsWith("TXKIL") Then
                    kilos = kilos + VaDec(tx.Text)
                ElseIf tx.Name.ToUpper.Trim.StartsWith("TXPIEZA") Then
                    piezas = piezas + VaInt(tx.Text)
                ElseIf tx.Name.ToUpper.Trim.StartsWith("TXIMPORTE") Then
                    importe = importe + VaDec(tx.Text)
                End If
            End If
        Next





        LbTBulV.Text = bultos.ToString("#,##0")
        LbTKilV.Text = kilos.ToString("#,##0")
        LbTPzaV.Text = piezas.ToString("#,##0")
        LbTimporte.Text = importe.ToString("#,##0.00")

    End Sub


    Private Sub BtSumakilos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSumakilos.Click

        If TxBul1.Enabled Then
            TerminaPanelKilos()
        Else
            OcultaPanelKilos()
        End If

    End Sub


    Private Sub Dlinea(ByVal linea As Integer, ByVal Calcuimporte As Boolean)
        Select Case linea
            Case 1
                Vlinea(TxBul1, TxKil1, TxPieza1, TxTipo1, TxPrecio1, TxImporte1, Calcuimporte)
            Case 2
                Vlinea(TxBul2, TxKil2, TxPieza2, TxTipo2, TxPrecio2, TxImporte2, Calcuimporte)
            Case 3
                Vlinea(TxBul3, TxKil3, TxPieza3, TxTipo3, TxPrecio3, TxImporte3, Calcuimporte)
            Case 4
                Vlinea(TxBul4, TxKil4, TxPieza4, TxTipo4, TxPrecio4, TxImporte4, Calcuimporte)
            Case 5
                Vlinea(TxBul5, TxKil5, TxPieza5, TxTipo5, TxPrecio5, TxImporte5, Calcuimporte)

        End Select
    End Sub
    Private Sub Vlinea(ByRef TxBul As TxDato, ByRef TxKil As TxDato, ByRef txPie As TxDato, ByRef txtipo As TxDato, ByRef Txprecio As TxDato, ByRef tximporte As TxDato, ByVal Calcuimporte As Boolean)
        Dim i As Double = 0
        Dim BUL As Double
        Dim KIL As Double
        Dim PIE As Double
        Dim IMP As Double
        Dim PRE As Double
        Dim TIP As String = ""
        BUL = VaDec(TxBul.Text)
        KIL = VaDec(TxKil.Text)
        PIE = VaDec(txPie.Text)
        TIP = txtipo.Text
        PRE = VaDec(Txprecio.Text)
        IMP = VaDec(tximporte.Text)


        If Calcuimporte = True Then
            Select Case TIP
                Case "B"
                    i = BUL * PRE
                Case "P"
                    i = PIE * PRE
                Case "K"
                    i = KIL * PRE
            End Select
            IMP = i
            tximporte.Text = IMP.ToString
        Else
            Select Case TIP
                Case "B"
                    If BUL <> 0 Then
                        i = IMP / BUL
                    End If
                Case "P"
                    If PIE <> 0 Then
                        i = IMP / PIE
                    End If
                Case "K"
                    If KIL <> 0 Then
                        i = IMP / KIL
                    End If
            End Select
            PRE = i
            Txprecio.Text = PRE.ToString
        End If
    End Sub


    Private Sub TxBul1_Valida(ByVal edicion As Boolean) Handles TxBul1.Valida
        If edicion Then

            If VaDec(LbBultos.Text) <> 0 Then

                Dim KXB As Decimal = VaDec(LbKCliente.Text) / VaDec(LbBultos.Text)
                Dim PXB As Decimal = VaDec(LbPiezas.Text) / VaDec(LbBultos.Text)

                TxKil1.Text = Int(VaDec(TxBul1.Text) * KXB).ToString
                TxPieza1.Text = Int(VaDec(TxBul1.Text) * PXB).ToString

            End If

            Dlinea(1, True)
            ValidaBultos(TxBul1)
        End If
    End Sub


    Private Sub TxBul2_Valida(ByVal edicion As Boolean) Handles TxBul2.Valida
        If edicion Then

            If VaDec(LbBultos.Text) <> 0 Then

                Dim KXB As Decimal = VaDec(LbKCliente.Text) / VaDec(LbBultos.Text)
                Dim PXB As Decimal = VaDec(LbPiezas.Text) / VaDec(LbBultos.Text)

                TxKil2.Text = Int(VaDec(TxBul2.Text) * KXB).ToString
                TxPieza2.Text = Int(VaDec(TxBul2.Text) * PXB).ToString

            End If

            Dlinea(2, True)
            ValidaBultos(TxBul2)

        End If
    End Sub


    Private Sub TxBul3_Valida(ByVal edicion As System.Boolean) Handles TxBul3.Valida
        If edicion Then

            If VaDec(LbBultos.Text) <> 0 Then

                Dim KXB As Double = VaDec(LbKCliente.Text) / VaDec(LbBultos.Text)
                Dim PXB As Decimal = VaDec(LbPiezas.Text) / VaDec(LbBultos.Text)

                TxKil3.Text = Int(VaDec(TxBul3.Text) * KXB).ToString
                TxPieza3.Text = Int(VaDec(TxBul3.Text) * PXB).ToString

            End If

            Dlinea(3, True)
            ValidaBultos(TxBul3)

        End If
    End Sub


    Private Sub TxBul4_Valida(ByVal edicion As System.Boolean) Handles TxBul4.Valida
        If edicion Then

            If VaDec(LbBultos.Text) <> 0 Then

                Dim KXB As Double = VaDec(LbKCliente.Text) / VaDec(LbBultos.Text)
                Dim PXB As Decimal = VaDec(LbPiezas.Text) / VaDec(LbBultos.Text)

                TxKil4.Text = Int(VaDec(TxBul4.Text) * KXB).ToString
                TxPieza4.Text = Int(VaDec(TxBul4.Text) * PXB).ToString

            End If

            Dlinea(4, True)
            ValidaBultos(TxBul4)

        End If
    End Sub


    Private Sub TxBul5_Valida(ByVal edicion As System.Boolean) Handles TxBul5.Valida
        If edicion Then

            If VaDec(LbBultos.Text) <> 0 Then

                Dim KXB As Double = VaDec(LbKCliente.Text) / VaDec(LbBultos.Text)
                Dim PXB As Decimal = VaDec(LbPiezas.Text) / VaDec(LbBultos.Text)

                TxKil5.Text = Int(VaDec(TxBul5.Text) * KXB).ToString
                TxPieza5.Text = Int(VaDec(TxBul5.Text) * PXB).ToString

            End If

            Dlinea(5, True)
            ValidaBultos(TxBul5)

        End If
    End Sub


    Private Sub TxKil1_Valida(ByVal edicion As Boolean) Handles TxKil1.Valida
        If edicion Then
            Dlinea(1, True)
            ValidaBultos(TxKil1)
        End If
    End Sub


    Private Sub TxKil2_Valida(ByVal edicion As Boolean) Handles TxKil2.Valida
        If edicion Then
            Dlinea(2, True)
            ValidaBultos(TxKil2)
        End If
    End Sub


    Private Sub TxKil3_Valida(ByVal edicion As System.Boolean) Handles TxKil3.Valida
        If edicion Then
            Dlinea(3, True)
            ValidaBultos(TxKil3)
        End If
    End Sub


    Private Sub TxKil4_Valida(ByVal edicion As System.Boolean) Handles TxKil4.Valida
        If edicion Then
            Dlinea(4, True)
            ValidaBultos(TxKil4)
        End If
    End Sub


    Private Sub TxKil5_Valida(ByVal edicion As System.Boolean) Handles TxKil5.Valida
        If edicion Then
            Dlinea(5, True)
            ValidaBultos(TxKil5)
        End If
    End Sub


    Private Sub TxPieza1_Valida(ByVal edicion As Boolean) Handles TxPieza1.Valida
        If edicion Then
            Dlinea(1, True)
            ValidaBultos(TxPieza1)
        End If
    End Sub


    Private Sub TxPieza2_Valida(ByVal edicion As Boolean) Handles TxPieza2.Valida
        If edicion Then
            Dlinea(2, True)
            ValidaBultos(TxPieza2)
        End If
    End Sub


    Private Sub TxPieza3_Valida(ByVal edicion As System.Boolean) Handles TxPieza3.Valida
        If edicion Then
            Dlinea(3, True)
            ValidaBultos(TxPieza3)
        End If
    End Sub


    Private Sub TxPieza4_Valida(ByVal edicion As System.Boolean) Handles TxPieza4.Valida
        If edicion Then
            Dlinea(4, True)
            ValidaBultos(TxPieza4)
        End If
    End Sub


    Private Sub TxPieza5_Valida(ByVal edicion As System.Boolean) Handles TxPieza5.Valida
        If edicion Then
            Dlinea(5, True)
            ValidaBultos(TxPieza5)
        End If
    End Sub


    Private Sub TxPrecio1_Valida(ByVal edicion As Boolean) Handles TxPrecio1.Valida
        If edicion Then

            Dlinea(1, True)
            ValidaBultos(TxPrecio1)
        End If
    End Sub


    Private Sub TxPrecio2_Valida(ByVal edicion As Boolean) Handles TxPrecio2.Valida
        If edicion Then
            Dlinea(2, True)
            ValidaBultos(TxPrecio2)
        End If
    End Sub


    Private Sub TxPrecio3_Valida(ByVal edicion As System.Boolean) Handles TxPrecio3.Valida
        If edicion Then
            Dlinea(3, True)
            ValidaBultos(TxPrecio3)
        End If
    End Sub


    Private Sub TxPrecio4_Valida(ByVal edicion As System.Boolean) Handles TxPrecio4.Valida
        If edicion Then
            Dlinea(4, True)
            ValidaBultos(TxPrecio4)
        End If
    End Sub


    Private Sub TxPrecio5_Valida(ByVal edicion As System.Boolean) Handles TxPrecio5.Valida
        If edicion Then
            Dlinea(5, True)
            ValidaBultos(TxPrecio5)
            If Not TxPrecio5.MiError Then
                TerminaPanelKilos()
            End If
        End If
    End Sub

    Private Sub TxBul1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxBul1.Enter

        If TxBul1.Enabled = False Then
            BGuardar.Select()
            BGuardar.Focus()
        End If

    End Sub


    Private Sub TxTipo1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxTipo1.TextChanged

    End Sub

    Private Sub TxPrecio1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxPrecio1.TextChanged

    End Sub

    Private Sub TxTipo1_Valida(ByVal edicion As Boolean) Handles TxTipo1.Valida
        If edicion Then
            If TxTipo1.Text = "" Then
                TxTipo1.Text = LbTipoPrecio.Text
            End If
            Dlinea(1, True)
            ValidaBultos(TxTipo1)
        End If

    End Sub

    Private Sub TxTipo2_Valida(ByVal edicion As Boolean) Handles TxTipo2.Valida
        If edicion Then
            If TxTipo2.Text = "" Then
                TxTipo2.Text = TxTipo1.Text
            End If

            Dlinea(2, True)
            ValidaBultos(TxTipo2)
        End If

    End Sub

    Private Sub TxTipo3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxTipo3.TextChanged

    End Sub

    Private Sub TxTipo3_Valida(ByVal edicion As Boolean) Handles TxTipo3.Valida
        If edicion Then
            If TxTipo3.Text = "" Then
                TxTipo3.Text = TxTipo1.Text
            End If

            Dlinea(3, True)
            ValidaBultos(TxTipo3)
        End If

    End Sub

    Private Sub TxTipo4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxTipo4.TextChanged

    End Sub

    Private Sub TxTipo4_Valida(ByVal edicion As Boolean) Handles TxTipo4.Valida
        If edicion Then
            If TxTipo4.Text = "" Then
                TxTipo4.Text = TxTipo1.Text
            End If

            Dlinea(4, True)
            ValidaBultos(TxTipo4)
        End If

    End Sub

    Private Sub TxTipo5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxTipo5.TextChanged

    End Sub

    Private Sub TxTipo5_Valida(ByVal edicion As Boolean) Handles TxTipo5.Valida
        If edicion Then
            If TxTipo5.Text = "" Then
                TxTipo5.Text = TxTipo1.Text
            End If

            Dlinea(5, True)
            ValidaBultos(TxTipo5)
        End If

    End Sub

    Private Sub TxImporte1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxImporte1.TextChanged

    End Sub

    Private Sub TxImporte1_Valida(ByVal edicion As Boolean) Handles TxImporte1.Valida
        If edicion Then
            Dlinea(1, False)
            ValidaBultos(TxImporte1)
        End If

    End Sub

    Private Sub TxImporte2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxImporte2.TextChanged

    End Sub

    Private Sub TxImporte2_Valida(ByVal edicion As Boolean) Handles TxImporte2.Valida
        If edicion Then
            Dlinea(2, False)
            ValidaBultos(TxImporte2)
        End If

    End Sub

    Private Sub TxImporte3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxImporte3.TextChanged

    End Sub

    Private Sub TxImporte3_Valida(ByVal edicion As Boolean) Handles TxImporte3.Valida
        If edicion Then
            Dlinea(3, False)
            ValidaBultos(TxImporte3)
        End If

    End Sub

    Private Sub TxImporte4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxImporte4.TextChanged

    End Sub

    Private Sub TxImporte4_Valida(ByVal edicion As Boolean) Handles TxImporte4.Valida
        If edicion Then
            Dlinea(4, False)
            ValidaBultos(TxImporte4)
        End If

    End Sub

    Private Sub TxImporte5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxImporte5.TextChanged

    End Sub

    Private Sub TxImporte5_Valida(ByVal edicion As Boolean) Handles TxImporte5.Valida
        If edicion Then
            Dlinea(5, False)
            ValidaBultos(TxImporte5)
        End If

    End Sub

    Private Sub TxDato_30_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_30.TextChanged

    End Sub

    Private Sub TxDato_30_Valida(ByVal edicion As Boolean) Handles TxDato_30.Valida
        If edicion = True Then
            CalculoPrecioLinea()
        End If
    End Sub

    Private Sub TxBul2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxBul2.TextChanged

    End Sub

    Private Sub TxBul3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxBul3.TextChanged

    End Sub

    Private Sub TxBul4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxBul4.TextChanged

    End Sub

    Private Sub TxBul5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxBul5.TextChanged

    End Sub

    Private Sub TxTipo2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxTipo2.TextChanged

    End Sub

    Private Sub TxDato_6_Valida(edicion As System.Boolean) Handles TxDato_6.Valida

        If edicion Then

            Dim Moneda As New E_Moneda(Idusuario, cn)
            If Moneda.LeerId(TxDato_6.Text) Then
                TxDato_7.Text = VaDec(Moneda.MON_Cambio.Valor).ToString("#,##0.000000")
                TxDato_7.Validar(True)
            End If

        End If

    End Sub


    Private Sub TxBul1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxBul1.KeyDown

        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If

    End Sub
    Private Sub TxBul2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxBul2.KeyDown

        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If

    End Sub
    Private Sub TxBul3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxBul3.KeyDown

        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If

    End Sub
    Private Sub TxBul4_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxBul4.KeyDown

        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If

    End Sub
    Private Sub TxBul5_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxBul5.KeyDown

        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If

    End Sub



    Private Sub TxKil1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxKil1.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxKil2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxKil2.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxKil3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxKil3.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxKil4_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxKil4.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxKil5_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxKil5.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub




    Private Sub TxPieza1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPieza1.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxPieza2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPieza2.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxPieza3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPieza3.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxPieza4_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPieza4.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxPieza5_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPieza5.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub




    Private Sub TxPrecio1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPrecio1.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxPrecio2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPrecio2.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxPrecio3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPrecio3.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxPrecio4_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPrecio4.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxPrecio5_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPrecio5.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub





    Private Sub TxTipo1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxTipo1.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxTipo2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxTipo2.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxTipo3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxTipo3.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxTipo4_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxTipo4.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxTipo5_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxTipo5.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub




    Private Sub TxImporte1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImporte1.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxImporte2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImporte2.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxImporte3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImporte3.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxImporte4_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImporte4.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub
    Private Sub TxImporte5_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImporte5.KeyDown
        If e.KeyCode = Keys.F2 Then
            TerminaPanelKilos()
        End If
    End Sub



    Private Sub TxDato6_Valida(edicion As Boolean) Handles TxDato6.Valida
        If edicion = True Then
            If TxDato6.Text <> "C" Then
                TxDato6.Text = "F"
            End If
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirValoracionAlbaran(LbId.Text, TipoImpresion.Preliminar)
        End If


    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirValoracionAlbaran(LbId.Text, TipoImpresion.ImpresoraPorDefecto)
        End If

    End Sub

    Private Sub TxDato11_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato11.TextChanged

    End Sub

    Private Sub ClButton1_Click(sender As System.Object, e As System.EventArgs) Handles ClButton1.Click
        If Albsalida.ASA_fechavaloracion.Valor = "01/01/1900" Then
            If MsgBox("Desea copiar los gastos del cliente", vbYesNo) = vbYes Then
                Dim OrigenDestino As String = "O"
                Dim IdTarifporte As Integer
                Dim tiposportes As New E_TiposPorte(Idusuario, cn)
                Dim clientesdescargas As New E_ClientesDescargas(Idusuario, cn)
                If tiposportes.LeerId(Albsalida.ASA_idtipoporte.Valor) = True Then
                    OrigenDestino = tiposportes.TPO_OrigenDestino.Valor
                End If
                If clientesdescargas.LeerId(Albsalida.ASA_iddomicilio.Valor) = True Then
                    IdTarifporte = VaInt(clientesdescargas.CLD_IdTarifaPortes.Valor)
                End If
                Agro_CopiarGastosCliente(LbId.Text, Albsalida.ASA_idcliente.Valor, Albsalida.ASA_idcentro.Valor, VaDec(Albsalida.ASA_valorcambio.Valor), VaDec(LbTkilosSal.Text), VaDec(LbTBultosSal.Text), VaDec(LbTPaletsSal.Text), VaDec(LbTventaSal.Text), OrigenDestino, IdTarifporte, VaInt(Albsalida.ASA_idtransportista.Valor))
                Cargalineas(ClGrid2)
                CalculoTotales()
            End If
        Else
            MsgBox("Albaran ya valorado")
        End If
    End Sub

    Private Sub TxPrecio5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxPrecio5.TextChanged

    End Sub

    Private Sub TxDato2_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxDato2.EnabledChanged
        BtDesgloseValoracion.Enabled = TxDato2.Enabled
    End Sub

    Private Function TieneReclamaciones(idalbaran As Integer) As Integer
        Dim ret As Integer = 0

        Dim reclama As New E_Reclama(Idusuario, cn)
        Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(reclama.RCL_Idreclama, "idreclama")
        consulta.SelCampo(Albsalida_lineas.ASL_idalbaran, "idalbaran", reclama.RCL_Idlinalb)
        consulta.WheCampo(Albsalida_lineas.ASL_idalbaran, "=", idalbaran.ToString)
        Dim sql As String = consulta.SQL
        Dim dt As DataTable = reclama.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = VaInt(dt.Rows(0)("idreclama"))

            End If
        End If

        Return ret

    End Function

    Private Sub TxDato_1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato_1.TextChanged

    End Sub

    Private Sub BtReclama_Click(sender As System.Object, e As System.EventArgs) Handles BtReclama.Click
        If _Idreclama <> 0 Then
            Dim frm As New FrmReclamacion
            frm.init(_Idreclama.ToString)
            frm.ShowDialog()
        End If
    End Sub
End Class