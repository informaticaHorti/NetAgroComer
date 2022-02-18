Imports DevExpress.XtraEditors

Public Class FrmEntradas
    Inherits FrMantenimiento


    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim AlbEntrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim AlbEntrada_lineas_Busqueda As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim AlbEntrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)
    Dim AlbEntrada_lineaskilos As New E_AlbEntrada_lineaskilos(Idusuario, cn)
    Dim AlbEntrada_gastos As New E_albentrada_gastos(Idusuario, cn)
    Dim Pventausuario As New E_PventaUsuario(Idusuario, cn)

    Dim BloqueoCultivos As New E_BloqueoCultivos(Idusuario, cn)

    Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim AgricultorGastos As New E_AgricultorGastos(Idusuario, cn)
    Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)
    Dim Tiposdegastoagri As New E_TiposdeGastoAgri(Idusuario, cn)
    Dim Origengastos As New E_OrigenGastos(Idusuario, cn)
    Dim Medianeria As New E_Medianeria(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim Confecenvase As New E_ConfecEnvase(Idusuario, cn)
    Dim Confecpalet As New E_ConfecPalet(Idusuario, cn)
    Dim FamiliasCategorias As New E_FamiliasCategorias(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)

    Dim Lotes As New E_Lotes(Idusuario, cn)

    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Subfamilias As New E_Subfamilias(Idusuario, cn)
    Dim FamiliasDescuentos As New E_FamiliasDescuentos(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)

    Dim DAT_ENTRADAS As New E_DAT_ENTRADAS(Idusuario, cn)

    Dim Idmuestreo As Integer
    Dim Idmedianeria As Integer



    Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)
    Dim Mi_idcentro As String

    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Idtarifa As Integer
    Dim DtoMerma As Double


    Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)

    Dim Palet_Predeterminado As String = ""



    Private Sub ParametrosFrm()

        EntidadFrm = AlbEntrada



        Dim lc As New List(Of Object)
        ListaControles = lc


        ParamTx(TxDato1, AlbEntrada.AEN_albaran, Lb1, True)
        TxDato1.Autonumerico = True
        LbPuntoVenta.CL_ControlAsociado = TxDato1
        LbNomPv.CL_ControlAsociado = TxDato1
        LbCrecogida.CL_ControlAsociado = TxDato1
        LbNomCr.CL_ControlAsociado = TxDato1
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato6, AlbEntrada.AEN_Fecha, Lb9, True)

        'ParamTx(TxBuscarPorPartida, AlbEntrada_lineas_Busqueda.AEL_muestreo, LbBuscarPorPartida)

        TxBuscarPorPartida.ClForm = Me
        TxBuscarPorPartida.ClParam = New Cdatos.PropiedadesTx
        TxBuscarPorPartida.ClParam.Tipo = AlbEntrada_lineas_Busqueda.AEL_muestreo.TipoBd
        TxBuscarPorPartida.ClParam.Longitud = AlbEntrada_lineas_Busqueda.AEL_muestreo.Longitud
        TxBuscarPorPartida.ClParam.Exclusivos = "0123456789"




        ParamTx(TxDato20, AlbEntrada.AEN_referencia, Lb60, False)
        ParamTx(TxDato3, AlbEntrada.AEN_IdAgricultor, Lb3, True)
        'ParamTx(LbFCS, AlbEntrada.AEN_TipoFCS, Lb56, True, , , , "FCS")
        ParamTx(TxDato23, AlbEntrada.AEN_matricula, Lb64, False)
        ParamTx(TxDato18, Nothing, Lb21, False)
        ParamTx(TxDato_6, AlbEntrada.AEN_IdTransportista, Lb_6, False)

        ParamTx(TxLocalizadorDAT, AlbEntrada.AEN_LocalizadorDAT, LbLocalizadorDAT)


        Lb3.Text = "Proveedor."


        ParamTx(TxIdGasto1, Nothing, Lb27, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxVgasto1, Nothing, Lb28, False, Cdatos.TiposCampo.Importe, 5, 18)
        ParamTx(TxAcreedor1, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)

        ParamTx(TxIdGasto2, Nothing, Lb27, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxVgasto2, Nothing, Lb28, False, Cdatos.TiposCampo.Importe, 5, 18)
        ParamTx(TxAcreedor2, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)

        ParamTx(TxIdGasto3, Nothing, Lb27, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)

        ParamTx(TxVgasto3, Nothing, Lb28, False, Cdatos.TiposCampo.Importe, 5, 18)
        ParamTx(TxAcreedor3, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)

        ParamTx(TxIdGasto4, Nothing, Lb27, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxVgasto4, Nothing, Lb28, False, Cdatos.TiposCampo.Importe, 5, 18)
        ParamTx(TxAcreedor4, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)


        'Género no es obligatorio, siempre y cuando pongamos el origen
        'ParamTx(TxDato4, AlbEntrada_lineas.AEL_idgenero, Lb5, True)
        ParamTx(TxGenero, AlbEntrada_lineas.AEL_idgenero, Lb5, True)
        ParamTx(TxCultivo, AlbEntrada_lineas.AEL_idcultivo, LbCultivo, False)
        ParamTx(TxControlado, AlbEntrada_lineas.AEL_Controlado, LbControlado, , , , , "SN")
        ParamTx(TxCalidad, AlbEntrada_lineas.AEL_Calidad, LbCalidad, False, Cdatos.TiposCampo.Cadena, , , "ABCDE")


        ParamTx(TxDato13, AlbEntrada_lineas.AEL_idcategoria, Lb25, False)
        ParamTx(TxDato2, AlbEntrada_lineas.AEL_idpalet, Lb6, False)
        ParamTx(TxDato5, AlbEntrada_lineas.AEL_idenvase, Lb11, True)
        ParamTx(TxMarca, AlbEntrada_lineas.AEL_idmarca, LbMarca, False)



        ParamTx(TxKil1, Nothing, Lb34, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxBul1, Nothing, Lb34, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxKil2, Nothing, Lb35, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxBul2, Nothing, Lb35, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxKil3, Nothing, Lb36, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxBul3, Nothing, Lb36, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxKil4, Nothing, Lb37, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxBul4, Nothing, Lb37, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxKil5, Nothing, Lb38, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxBul5, Nothing, Lb38, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxKil6, Nothing, Lb39, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxBul6, Nothing, Lb39, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxKil7, Nothing, Lb40, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxBul7, Nothing, Lb40, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxKil8, Nothing, Lb41, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxBul8, Nothing, Lb41, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxKil9, Nothing, Lb41_, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxBul9, Nothing, Lb41_, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxKil10, Nothing, Lb42_, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxBul10, Nothing, Lb42_, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxKil11, Nothing, Lb43_, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxBul11, Nothing, Lb43_, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxKil12, Nothing, Lb44_, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxBul12, Nothing, Lb44_, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxKil13, Nothing, Lb45_, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxBul13, Nothing, Lb45_, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxKil14, Nothing, Lb46_, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxBul14, Nothing, Lb46_, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxKil15, Nothing, Lb47_, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxBul15, Nothing, Lb47_, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxKil16, Nothing, Lb48_, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxBul16, Nothing, Lb48_, False, Cdatos.TiposCampo.Entero, 0, 4)


        ParamTx(TxDato9, AlbEntrada_lineas.AEL_kilosbrutos, Lb12, False)
        ParamTx(TxDato7, AlbEntrada_lineas.AEL_palets, Lb15, False)
        ParamTx(TxDato8, AlbEntrada_lineas.AEL_bultos, Lb16, False)
        ParamTx(TxDato10, AlbEntrada_lineas.AEL_taramanual, Lb13, False)
        ParamTx(TxDato24, AlbEntrada_lineas.AEL_piezas, Lb58, False)
        ' ParamTx(LbPartida, AlbEntrada_lineas.AEL_muestreo, Lb30, True)
        ParamTx(TxDato19, AlbEntrada_lineas.AEL_precio, Lb59, False)
        ' ParamTx(TxDato22, AlbEntrada_lineas.AEL_tipoprecio, Lb59, False, , , , "KBP")
        ParamTx(TxDato17, AlbEntrada_lineas.AEL_observaciones, Lb45, False)
        ParamTx(TxDato15, AlbEntrada_lineas.AEL_envasepropio, Lb55, False)


        LbKnetos.CL_ControlAsociado = TxDato10 ' para que lo borre en en borralin
        LbTaraEnv.CL_ControlAsociado = TxDato10

        LbTaraPalet.CL_ControlAsociado = TxDato10
        LbTaraEnvase.CL_ControlAsociado = TxDato10
        Lb42.CL_ControlAsociado = TxDato10


        AsociarGrid(ClGrid1, TxGenero, TxDato15, AlbEntrada_lineas)

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        PropiedadesCamposGr(ClGrid1, "AEL_idlinea", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Genero", "Genero", True, 10)
        PropiedadesCamposGr(ClGrid1, "NombreGenero", "Nombre_Genero", True, 50)
        PropiedadesCamposGr(ClGrid1, "Envase", "Envase", True, 50)
        PropiedadesCamposGr(ClGrid1, "Bultos", "Bultos", True, 10, True, "#0")
        PropiedadesCamposGr(ClGrid1, "Kilos", "KilosNetos", True, 10, True, "#0.00")
        PropiedadesCamposGr(ClGrid1, "Partida", "Partida", True, 10)
        PropiedadesCamposGr(ClGrid1, "NombreEnvase", "NombreEnvase", False)
        PropiedadesCamposGr(ClGrid1, "NombreCategoria", "NombreCategoria", False)
        PropiedadesCamposGr(ClGrid1, "FondoOp", "FondoOp", True, 10)



        AsociarControles(TxDato1, BtBuscaAlbaran, AlbEntrada.btBusca, EntidadFrm)
        AsociarControles(TxDato3, BtBuscaAgricultor, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb19)
        AsociarControles(TxDato18, BtBuscaMedianero, Medianeria.btBusca, Medianeria)
        AsociarControles(TxDato_6, BtBusca_6, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, Lb_nom6)
        BtBusca_6.CL_Filtro = "TIPO='PO'"

        AsociarControles(TxIdGasto1, BtBuscaGasto1, Tiposdegastoagri.btBusca, Tiposdegastoagri, Tiposdegastoagri.TGA_Nombre, LbNomGasto1)
        AsociarControles(TxIdGasto2, BtBuscaGasto2, Tiposdegastoagri.btBusca, Tiposdegastoagri, Tiposdegastoagri.TGA_Nombre, LbNomGasto2)
        AsociarControles(TxIdGasto3, BtBuscaGasto3, Tiposdegastoagri.btBusca, Tiposdegastoagri, Tiposdegastoagri.TGA_Nombre, LbNomGasto3)
        AsociarControles(TxIdGasto4, BtBuscaGasto4, Tiposdegastoagri.btBusca, Tiposdegastoagri, Tiposdegastoagri.TGA_Nombre, LbNomGasto4)

        AsociarControles(TxAcreedor1, BtBuscaAcreedor1, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomAcreedor1)
        AsociarControles(TxAcreedor2, BtBuscaAcreedor2, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomAcreedor2)
        AsociarControles(TxAcreedor3, BtBuscaAcreedor3, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomAcreedor3)
        AsociarControles(TxAcreedor4, BtBuscaAcreedor4, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomAcreedor4)

        AsociarControles(TxGenero, BtBuscaGenero, Generos.btBusca, Generos, Generos.GEN_NombreGenero, Lb4)
        AsociarControles(TxDato13, BtBuscaCat, CategoriasEntrada.bTBuscaEnt, CategoriasEntrada, CategoriasEntrada.CAE_CategoriaCalibre, Lb24)

        AsociarControles(TxDato2, BtBuscaPalet, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb2)
        AsociarControles(TxDato5, BtBuscaEnvase, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb10)
        AsociarControles(TxMarca, BtBuscaMarca, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, LbNomMarca)

        AsociarControles(TxLocalizadorDAT, BtBuscaLocalizador, DAT_ENTRADAS.btBusca, DAT_ENTRADAS, DAT_ENTRADAS.DAT_Localizador, , "Buscador de localizadores")


        BtBuscaPalet.CL_Filtro = "TIPO='P'"
        BtBuscaEnvase.CL_Filtro = "TIPO='E'"



        tt.SetToolTip(BtNuevo, "Nuevo")
        tt.SetToolTip(BtPalets, "Introducir palets")
        tt.SetToolTip(BtSumakilos, "Sumar kilos y actualizar datos")

        tt.SetToolTip(LbBascu1, "Cambiar a báscula 1")
        tt.SetToolTip(LbBascu2, "Cambiar a báscula 2")
        tt.SetToolTip(LbBascu3, "Cambiar a báscula 3")
        tt.SetToolTip(LbBascu4, "Cambiar a báscula 4")

        tt.SetToolTip(BtDetallesAlbaran, "Ver detalles albarán")

        tt.SetToolTip(btImprimirPartida, "Imprimir partida")
        tt.SetToolTip(btImprimirCartelon, "Imprimir cartelón")

        'BtBuscaAlbaran.CL_Filtro = "Confeccionada <> 'S' " + Pventausuario.FiltroPventaGrid("PV", "AND")
        BtBuscaAlbaran.CL_Filtro = "Directa <> 'S' " + Pventausuario.FiltroPventaGrid("PV", "AND")
        BtBuscaAlbaran.CL_xCentro = False


        FiltroEntidad.Add(AlbEntrada.AEN_IdCentro.NombreCampo, MiMaletin.IdCentro.ToString)
        FiltroEntidad.Add(AlbEntrada.AEN_Campa.NombreCampo, MiMaletin.Ejercicio.ToString)


    End Sub


    Private Sub FrmEntradas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Palet_Predeterminado = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.PALET_ENTRADA_PREDETERMINADO)

    End Sub


    Public Overrides Sub ControlClave()


        ' componemos la clave
        Dim i As Integer
        If TxDato1.Text = "+" Then
            LbId.Text = "+"
        Else

            i = AlbEntrada.LeerAlb(CInt(LbCampa.Text), Mi_idcentro, VaInt(TxDato1.Text))


            If i > 0 Then

                LbId.Text = i.ToString

                'If VaInt(AlbEntrada.AEN_IdPuntoVenta.Valor) <> VaInt(LbPuntoVenta.Text) Then
                '    MsgBox("No coincide el punto de venta")
                '    LbId.Text = ""
                '    TxDato1.Text = ""
                '    Exit Sub
                'End If

                If (AlbEntrada.AEN_EntradaConfeccionada.Valor & "").ToUpper.Trim = "S" Then
                    MsgBox("La entrada es directa")
                    LbId.Text = ""
                    TxDato1.Text = ""
                    Exit Sub
                End If

            Else
                LbId.Text = AlbEntrada.MaxId
            End If

        End If

        CargaLineasGrid()

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)


        Idmuestreo = AlbEntrada_lineas.AEL_muestreo.Valor
        LBPARTIDA.Text = Idmuestreo.ToString

        Lb42.Text = AlbEntrada_lineas.AEL_taraporce.Valor
        LbTaraPalet.Text = AlbEntrada_lineas.AEL_tarapalet.Valor
        LbTaraEnvase.Text = AlbEntrada_lineas.AEL_taraenvase.Valor

        LbTaraEnv.Text = TotalTara.ToString
        PintaKilosNetos()
        CargaKilosPalets(AlbEntrada_lineas.AEL_idlinea.Valor)
        LbCampaCultivo.Text = AlbEntrada_lineas.AEL_campacultivo.Valor
        pintacultivos()
        btImprimirPartida.Enabled = True


        LbFCS.Text = (AlbEntrada.AEN_TipoFCS.Valor & "").Trim


        If AlbEntrada_lineas.AEL_fechamuestreo.Valor <> "01/01/1900" Then
            LbMuestreado.Text = "MUESTREADO"
            LbMuestreado.Visible = True
            Grid.LineaBloqueada = True
            BloquearCamposLineas(True, Grid)
        Else
            LbMuestreado.Visible = False
            Grid.LineaBloqueada = False
            ' If Modificando = True Then
            ' BloquearCamposLineas(False, Grid)
            'End If
        End If

        LbTipoPrecio.Text = AlbEntrada_lineas.AEL_tipoprecio.Valor

        LbIdCalidad.Text = AlbEntrada_lineas.AEL_idprograma.Valor
        MuestraProgramaCalidad()


        MuestraFacturaAgr()


    End Sub


    Private Sub MuestraProgramaCalidad()

        If VaInt(LbIdCalidad.Text) > 0 Then
            Dim ProgramaCalidadTecnicos As New E_ProgramaCalidadTecnicos(Idusuario, cn)
            If ProgramaCalidadTecnicos.LeerId(LbIdCalidad.Text) Then
                LbPcalidad.Text = ProgramaCalidadTecnicos.PCT_Nombre.Valor
            End If
        End If


    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()


        PintaPuntoVenta(AlbEntrada.AEN_idpuntoventa.Valor)
        PintaCrecogida(AlbEntrada.AEN_idrecogida.Valor)
        LbBascula.Text = AlbEntrada.AEN_idbascula.Valor
        LbCampa.Text = AlbEntrada.AEN_Campa.Valor

        Idmedianeria = VaInt(AlbEntrada.AEN_IdMedianeria.Valor)
        TxDato18.Text = ""
        LbNomMedianero.Text = ""
        If Idmedianeria > 0 Then
            If Medianeria.LeerId(Idmedianeria) = True Then
                TxDato18.Text = Medianeria.MED_Numero.Valor
                LbNomMedianero.Text = Medianeria.MED_Nombre.Valor
            End If
        End If
        CargaGastosAlbaran()
        ' llenar el grid
        CargaLineasGrid()

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas


        Dim r As Boolean

        If LbId.Text = "+" Then
            LbId.Text = AlbEntrada.MaxId
            If TxDato1.Text = "+" Then
                TxDato1.Text = AlbEntrada.MaxIdCampa(Val(LbCampa.Text), Mi_idcentro)

            End If
            AlbEntrada.AEN_FechaHora.Valor = Now.ToString
        End If

        AlbEntrada.AEN_IdAlbaran.Valor = LbId.Text
        AlbEntrada.AEN_Campa.Valor = LbCampa.Text
        AlbEntrada.AEN_IdCentro.Valor = Mi_idcentro.ToString
        AlbEntrada.AEN_IdPuntoVenta.Valor = LbPuntoVenta.Text
        AlbEntrada.AEN_IdRecogida.Valor = LbCrecogida.Text
        AlbEntrada.AEN_idbascula.Valor = LbBascula.Text

        If LbFCS.Text.Trim <> "F" And LbFCS.Text.Trim <> "S" Then LbFCS.Text = "C"
        AlbEntrada.AEN_TipoFCS.Valor = LbFCS.Text.Trim

        AlbEntrada.AEN_IdMedianeria.Valor = Idmedianeria.ToString
        AlbEntrada_lineas.AEL_idalbaran.Valor = LbId.Text
        AlbEntrada_lineas.AEL_kilosnetos.Valor = LbKnetos.Text
        AlbEntrada_lineas.AEL_albaran.Valor = TxDato1.Text
        AlbEntrada_lineas.AEL_taraporce.Valor = Lb42.Text
        AlbEntrada_lineas.AEL_taraenvase.Valor = LbTaraEnvase.Text
        AlbEntrada_lineas.AEL_tarapalet.Valor = LbTaraPalet.Text
        AlbEntrada_lineas.AEL_campacultivo.Valor = LbCampaCultivo.Text
        AlbEntrada_lineas.AEL_idtipoconfeccion.Valor = ""
        AlbEntrada_lineas.AEL_tipoprecio.Valor = "K"


        If (AlbEntrada_lineas.AEL_IdUbicacionPV.Valor & "").Trim = "" Then
            AlbEntrada_lineas.AEL_IdUbicacionPV.Valor = LbPuntoVenta.Text
        End If


        AlbEntrada_lineas.AEL_idprograma.Valor = LbIdCalidad.Text


        Dim LineaTraspaso As String = ""



        SqlGrid()

        r = MyBase.GuardarLineas(Gr)



        Return r

    End Function


    Public Overrides Sub DespuesdeGuardarLinea(ByVal gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)


        GrabaKilosPalets(AlbEntrada_lineas.AEL_idlinea.Valor)

        'Agro_ActualizaLineaCla(LbCampa.Text, AlbEntrada_lineas.AEL_idlinea.Valor, TxDato16.Text, TxDato6.Text)
        AlbEntrada_lineas.ActualizaPartida(LbCampa.Text, AlbEntrada_lineas.AEL_muestreo.Valor, AlbEntrada_lineas.AEL_idlinea.Valor)


        'Actualiza la fecha de inicio de recoleccion real del cultivo (si procede)
        ActualizaFechaInicioRecoleccionRealCultivo(TxCultivo.Text, TxDato6.Text)


        If Ventorno.Normalizada = False Then
            If XtraMessageBox.Show("¿Desea imprimir el ticket?", "Ticket", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


                Dim CopiasBoletinMuestreo As Integer = 2
                Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)
                If CentrosRecogida.LeerId(LbCrecogida.Text) Then
                    CopiasBoletinMuestreo = VaInt(CentrosRecogida.CER_CopiasBoletinMuestreo.Valor)
                    If CopiasBoletinMuestreo = 0 Then CopiasBoletinMuestreo = 2
                End If

                C1_ImprimirBoletinMuestreo(AlbEntrada_lineas.AEL_idlinea.Valor, TipoImpresion.ImpresoraPorDefecto, CopiasBoletinMuestreo)

            End If
        End If

        If XtraMessageBox.Show("¿Imprimir el cartelón?", "Cartelón", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            C1_ImprimirCartelonPartida(AlbEntrada_lineas.AEL_idlinea.Valor, TipoImpresion.ImpresoraPorDefecto)
        End If


        Dim frm As New FrmColorEtiqueta(AlbEntrada_lineas.AEL_Calidad.Valor)
        frm.ShowDialog()


    End Sub


    Public Overrides Sub DespuesdeGuardar()
        Dim IdVale As String = ""

        GrabaGastosAlbaran()
        AlbEntrada.CrearValeEnvasesComercio(LbId.Text)
        Agro_GeneraAlbaranEntrada(VaInt(LbId.Text))


        If AlbEntrada.LeerId(LbId.Text) = True Then
            IdVale = AlbEntrada.AEN_IdValeEnvase.Valor
            AlbEntrada.Actualizar()
        End If



        Dim IdAlbaran As String = LbId.Text
        Dim localizador As String = TxLocalizadorDAT.Text

        MyBase.DespuesdeGuardar()



        If XtraMessageBox.Show("¿Desea imprimir el albarán?", "Albarán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim CopiasAlbaranEntrada As Integer = 2
            Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)
            If CentrosRecogida.LeerId(LbCrecogida.Text) Then
                CopiasAlbaranEntrada = VaInt(CentrosRecogida.CER_CopiasAlbaranEntrada.Valor)
                If CopiasAlbaranEntrada = 0 Then CopiasAlbaranEntrada = 2
            End If

            C1_ImprimirAlbaraEntrada(LbId.Text, TipoImpresion.ImpresoraSeleccionada, CopiasAlbaranEntrada)

        End If


        If NuevoRegistro Then
            If ChkImprimirValeGastos.Checked Then C1_ImprimirValeGastosEntrada(LbId.Text, TipoImpresion.ImpresoraSeleccionada)
        Else
            If XtraMessageBox.Show("¿Desea imprimir el vale de gastos?", "Vale de gastos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                C1_ImprimirValeGastosEntrada(LbId.Text, TipoImpresion.ImpresoraSeleccionada)
            End If
        End If


        'Mostrar Vale
        If VaInt(IdVale) > 0 Then

            Dim frm As New FrmValeEnvase("EB")
            frm.init(IdVale)
            frm.ShowDialog()

            If NuevoRegistro Then
                If ChkImprimirValeEnvases.Checked Then C1_ImprimirValeEnvases(IdVale, TipoImpresion.ImpresoraSeleccionada)
            End If

        End If



        If (NuevoRegistro And localizador <> "") Or E_DAT_ENTRADAS.LocalizadorPendiente(localizador) Then

            Dim Peso As Integer = E_AlbEntrada.PesoNetoTotal(IdAlbaran)
            E_DAT_ENTRADAS.Actualizar_DAT_ENTRADA(IdAlbaran, localizador, Peso)

        ElseIf localizador = "" Then

            'Modificación y localizador está vacío, así que desasociamos todos los localizadores que pudiera tener este albarán
            E_DAT_ENTRADAS.EliminarLocalizadorAlbaran(IdAlbaran)

        End If



    End Sub


    Private Sub CargaKilosPalets(ByVal id As String)

        Dim bultos(17) As Integer
        Dim kilos(17) As Double
        Dim i As Integer = 0

        Dim sql As String = "select * from albentrada_lineaskilos where ALK_idlineaentrada=" & id.ToString
        Dim dt As DataTable = AlbEntrada_lineaskilos.MiConexion.ConsultaSQL(sql)

        If Not Dt Is Nothing Then
            If dt.Rows.Count > 0 Then

                For Each rw As DataRow In dt.Rows
                    i = i + 1
                    If i <= 16 Then
                        bultos(i) = rw("ALK_bultos")
                        kilos(i) = rw("ALK_kilos")
                    End If
                Next
            End If
        End If

        If i = 0 Then
            i = 1
            bultos(i) = AlbEntrada_lineas.AEL_bultos.Valor
            kilos(i) = AlbEntrada_lineas.AEL_kilosbrutos.Valor
        End If


        For n As Integer = 1 To 16

            Dim k As Control() = Me.Controls.Find("TxKil" & n.ToString, True)
            If k.Length = 1 Then
                Dim tx As TxDato = k(0)
                tx.Text = kilos(n).ToString
                tx.Validar(False)
            End If

            Dim b As Control() = Me.Controls.Find("TxBul" & n.ToString, True)
            If b.Length = 1 Then
                Dim tx As TxDato = b(0)
                tx.Text = bultos(n).ToString
                tx.Validar(False)
            End If

        Next

    End Sub


    Private Sub GrabaKilosPalets(ByVal id As String)


        Dim bultos(17) As Integer
        Dim kilos(17) As Double

        Dim sql As String = "Delete from albentrada_lineaskilos where ALK_idlineaentrada=" & id.ToString
        AlbEntrada_lineaskilos.MiConexion.ConsultaSQL(sql)

        For i As Integer = 1 To 16

            Dim k As Control() = Me.Controls.Find("TxKil" & i.ToString, True)
            If k.Length = 1 Then
                Dim tx As TxDato = k(0)
                kilos(i) = VaDec(tx.Text)
            End If

            Dim b As Control() = Me.Controls.Find("TxBul" & i.ToString, True)
            If b.Length = 1 Then
                Dim tx As TxDato = b(0)
                bultos(i) = VaInt(tx.Text)
            End If

        Next

        For i As Integer = 1 To 16
            If bultos(i) <> 0 Or kilos(i) <> 0 Then
                AlbEntrada_lineaskilos.VaciaEntidad()
                AlbEntrada_lineaskilos.ALK_id.Valor = AlbEntrada_lineaskilos.MaxId
                AlbEntrada_lineaskilos.ALK_idlineaentrada.Valor = id
                AlbEntrada_lineaskilos.ALK_bultos.Valor = bultos(i).ToString
                AlbEntrada_lineaskilos.ALK_kilos.Valor = kilos(i).ToString
                AlbEntrada_lineaskilos.Insertar()
            End If
        Next


    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)

        If PanelKilos.Visible = True Then
            PanelKilos.Visible = False
        End If

        Idmuestreo = 0

        LbNomCultivo.Text = ""
        LbMuestreado.Visible = False
        LbNomCultivo.Text = ""
        LBPARTIDA.Text = ""

        LbIdCalidad.Text = ""
        LbPcalidad.Text = ""
        LbTipoPrecio.Text = ""

        TxCultivo.Siguiente = TxControlado.Orden

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        TxBuscarPorPartida.Text = ""

        LbCampa.Text = MiMaletin.Ejercicio.ToString
        PintaPuntoVenta(MiMaletin.IdPuntoVenta)
        PintaCrecogida(MiMaletin.IdCentroRecogida)
        PintaNbascula(Val(FnRight(Me.Text, 1)))
        Idmedianeria = 0
        btImprimirPartida.Enabled = False
        LbCampaCultivo.Text = MiMaletin.EjercicioTecnicos.ToString
        BModificar.Enabled = True
        BAnular.Enabled = True
        BGuardar.Enabled = True

        LbBascula.Text = IdBasculaEntrada.ToString

        LbSerie.Text = ""
        LbFactura.Text = ""


        LbColorEtiqueta.BackColor = Color.White

        BtBuscaLocalizador.CL_Filtro = ""


    End Sub


    Private Sub CargaLineasGrid()
        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)
    End Sub


    Private Sub SqlGrid()


        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
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


        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_idlinea, "")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_muestreo, "Partida")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_idgenero, "Genero")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "NombreGenero", AlbEntrada_lineas.AEL_idgenero)
        CONSULTA.SelCampo(Envases.ENV_Nombre, "Envase", AlbEntrada_lineas.AEL_idenvase)
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_bultos, "Bultos")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_kilosnetos, "Kilos")
        CONSULTA.SelCampo(AlbEntrada.AEN_IdAgricultor, "IdAgricultor", AlbEntrada_lineas.AEL_idalbaran, AlbEntrada.AEN_IdAlbaran)
        CONSULTA.SelCampo(Agricultores.AGR_IdTipo, "IdTipoAgricultor", AlbEntrada.AEN_IdAgricultor)
        CONSULTA.SelCampo(TipoAgricultor.TPA_FondoOperativoSN, "FondoOp", Agricultores.AGR_IdTipo)
        CONSULTA.WheCampo(AlbEntrada_lineas.AEL_idalbaran, "=", id)
        sql = CONSULTA.SQL
        sql = sql + " order by AEL_Idlinea"

        ClGrid1.Consulta = sql

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()

        BTaux1.Visible = True
        BTaux1.Text = "Imprimir"
        BTaux1.Image = PictureBox1.Image

        BtAux2.Visible = True
        BtAux2.Text = "I.Directa"
        BtAux2.Image = PictureBox2.Image

    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If LbId.Text = "" Then Exit Sub


        If AlbEntrada_lineas.LineasMuestreadas(LbId.Text) = True Then
            MsgBox("No se puede anular el albarán: lineas muestreadas")
            Exit Sub
        End If


        Dim f As String = Albentrada_his.AlbaranFacturado(LbId.Text)
        If f <> "" Then
            MsgBox("Albaranes: " + f + " facturados ")
            Exit Sub
        End If


        f = Albentrada_his.GastosFacturados(LbId.Text)
        If f <> "" Then
            MsgBox("Gastos " + f + " facturados")
            Exit Sub

        End If

        MyBase.BAnular_Click(sender, e)

    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)


        If LbId.Text = "" Then Exit Sub


        If AlbEntrada_lineas.LineasMuestreadas(LbId.Text) = True Then
            MsgBox("No se puede MODIFICAR el albarán: lineas muestreadas")
            Exit Sub
        End If


        Dim f As String = Albentrada_his.AlbaranFacturado(LbId.Text)
        If f <> "" Then
            MsgBox("Albaranes: " + f + " facturados ")
            Exit Sub

        End If


        f = Albentrada_his.GastosFacturados(LbId.Text)
        If f <> "" Then
            MsgBox("Gastos " + f + " facturados")
            Exit Sub

        End If


        MyBase.BModificar_Click(sender, e)

    End Sub


    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNuevo.Click
        If TxDato1.Text = "" And TxDato1.Enabled = True Then
            TxDato1.Text = "+"
            Siguiente(0)
        End If
    End Sub


    Private Sub TxDato2_Valida(ByVal edicion As Boolean) Handles TxDato2.Valida

        If edicion = True Then

            If TxDato2.Text.Trim = "" Then
                TxDato2.Text = Palet_Predeterminado
                'TxDato2.Validar(True)
            End If

            PintaTaraPalet()
            'TxDato2.Siguiente = TxDato9.Orden
            TxDato2.Siguiente = TxDato5.Orden

        End If

    End Sub

    Private Sub PintaTaraPalet()

        If Envases.LeerId(TxDato2.Text) = True Then
            LbTaraPalet.Text = Envases.ENV_TaraEntrada.Valor
        End If

        LbTaraEnv.Text = TotalTara.ToString
        PintaKilosNetos()

    End Sub

    Private Function TotalTara() As Double

        Dim t As Double
        Dim Kn As Double = 0

        t = VaDec(TxDato7.Text) * VaDec(LbTaraPalet.Text)
        t = t + VaDec(TxDato8.Text) * VaDec(LbTaraEnvase.Text)
        If VaDec(TxDato9.Text) <> 0 Then
            Kn = VaDec(TxDato9.Text) - t
            t = t + Kn * VaDec(Lb42.Text) / 100
        End If
        t = Math.Round(t, 2)

        Return t

    End Function


    Private Sub TxDato5_Valida(ByVal edicion As Boolean) Handles TxDato5.Valida
        If edicion = True Then

            PintaTaraEnvase()

            TxDato5.Siguiente = TxMarca.Orden

        End If
    End Sub


    Private Sub PintaTaraEnvase()

        Dim TaraEntrada As Decimal = 0
        LbTaraEnvase.Text = ""

        If Envases.LeerId(TxDato5.Text) = True Then
            LbTaraEnvase.Text = Envases.ENV_TaraEntrada.Valor
        End If

        LbTaraEnv.Text = TotalTara.ToString
        PintaKilosNetos()

    End Sub

    Private Sub TxDato7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxDato7.KeyDown
        If e.KeyCode = Keys.F2 Then
            PanelPalet()
        End If
    End Sub


    Private Sub TxDato7_Valida(ByVal edicion As Boolean) Handles TxDato7.Valida
        If edicion = True Then
            LbTaraEnv.Text = TotalTara.ToString
            PintaKilosNetos()

        End If
    End Sub


    Private Sub TxDato8_Valida(ByVal edicion As Boolean) Handles TxDato8.Valida
        If edicion = True Then
            LbTaraEnv.Text = TotalTara.ToString
            PintaKilosNetos()
        End If
    End Sub

    Private Sub PintaKilosNetos()

        Dim k As Integer = 0
        k = (VaDec(TxDato9.Text) - VaDec(LbTaraEnv.Text) - VaDec(TxDato10.Text)).ToString
        LbKnetos.Text = k.ToString

    End Sub


    Private Sub TxDato9_Valida(ByVal edicion As Boolean) Handles TxDato9.Valida
        If edicion = True Then
            LbTaraEnv.Text = TotalTara.ToString
            PintaKilosNetos()
        End If
    End Sub


    Private Sub TxDato10_Valida(ByVal edicion As Boolean) Handles TxDato10.Valida
        PintaKilosNetos()
    End Sub


    Private Sub TxDato3_Valida(ByVal edicion As Boolean) Handles TxDato3.Valida


        Dim nif As String = ""

        BtBuscaMedianero.CL_Filtro = "IdAgricultor=" + TxDato3.Text

        If Agricultores.LeerId(TxDato3.Text) = True Then


            nif = (Agricultores.AGR_Nif.Valor & "").Trim.Replace("-", "").Replace(".", "").Replace(" ", "")


            If edicion = True Then

                LbFCS.Text = Agricultores.AGR_tipofcs.Valor & ""
                If LbFCS.Text.Trim <> "F" And LbFCS.Text.Trim <> "S" Then LbFCS.Text = "C"

                'If LbFCS.Text = "" Then
                '    LbFCS.Text = Agricultores.AGR_tipofcs.Valor
                'End If

                'DatosGasto()

                If Agricultores.AGR_TextoMensaje1.Valor.Trim <> "" Or Agricultores.AGR_TextoMensaje2.Valor.Trim <> "" Then
                    MsgBox(Agricultores.AGR_TextoMensaje1.Valor & Chr(13) & Chr(10) + Agricultores.AGR_TextoMensaje2.Valor)
                    'MsgBox(Agricultores.AGR_TextoMensaje1.Valor & Chr(13) & Chr(10) + Agricultores.AGR_TextoMensaje2.Valor & vbCrLf & "ATENCIÓN: SE HAN ALCANZADO LAS 1200TM QS ENTRADAS" & vbCrLf & "REALIZAR TOMA DE MUESTRA ANALÍTICA QS")
                End If


                ComprobarBloqueoCuenta()



                If Agricultores.AGR_Bloqueado.Valor = "S" Then
                    MsgBox("Código bloqueado")
                    TxDato3.MiError = True
                End If

                Dim CentroRecogida As New E_centrosrecogida(Idusuario, cn)
                CentroRecogida.LeerId(Agricultores.AGR_idcrecogida.Valor)

                If VaInt(LbCrecogida.Text) = 0 Then
                    LbCrecogida.Text = Agricultores.AGR_idcrecogida.Valor.ToString
                    LbNomCr.Text = CentroRecogida.CER_Nombre.Valor.ToString
                ElseIf Not LbCrecogida.Text.Equals(Agricultores.AGR_idcrecogida.Valor.ToString) Then
                    If XtraMessageBox.Show("Desea cambiar el Centro de Recogida a """ & CentroRecogida.CER_Nombre.Valor.ToString & """", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        LbCrecogida.Text = Agricultores.AGR_idcrecogida.Valor.ToString
                        LbNomCr.Text = CentroRecogida.CER_Nombre.Valor.ToString
                    End If
                End If
            End If

        End If


        Dim fechafiltro As String = TxDato6.Text
        If VaDate(TxDato6.Text) > VaDate("") Then
            fechafiltro = DateAdd(DateInterval.Day, -1, VaDate(TxDato6.Text)).ToString("dd/MM/yyyy")
        End If

        BtBuscaLocalizador.CL_Filtro = "Fecha >= '" & fechafiltro & "' AND NIF = '" & nif & "'"


    End Sub


    Private Sub ComprobarBloqueoCuenta()

        Dim Cta As String = "400" & VaInt(TxDato3.Text).ToString("00000000")
        Dim BloqueoCuenta As New E_BloqueoCuentas(Idusuario, cn)
        If BloqueoCuenta.LeerId(Cta) Then

            'Si existe el bloqueo a la cuenta
            Dim Aviso As String = (BloqueoCuenta.AvisoSN.Valor & "").Trim
            Dim Mensaje As String = (BloqueoCuenta.Aviso.Valor & "").Trim

            If Aviso = "S" And Mensaje <> "" Then
                MsgBox(BloqueoCuenta.Aviso.Valor)
            End If

        End If

    End Sub



    Private Sub PintaPuntoVenta(ByVal PV As Integer)

        LbPuntoVenta.Text = PV.ToString
        If PuntoVenta.LeerId(LbPuntoVenta.Text) = True Then
            LbNomPv.Text = PuntoVenta.Nombre.Valor
            MI_IDCENTRO = PuntoVenta.IdCentro.Valor
        Else
            LbNomPv.Text = ""
        End If

    End Sub


    Private Sub PintaCrecogida(ByVal CR As Integer)

        LbCrecogida.Text = CR.ToString
        If CentrosRecogida.LeerId(LbCrecogida.Text) = True Then
            LbNomCr.Text = CentrosRecogida.CER_Nombre.Valor
        Else
            LbNomCr.Text = ""
        End If

    End Sub


    Private Sub SumarPalets()

        Dim palet As Integer
        Dim bultos As Integer
        Dim kilos As Decimal
        For Each tx As Control In Me.ListaControles
            If TypeOf (tx) Is TxDato Then
                Select Case UCase(tx.Name).Substring(0, 5)
                    Case "TXBUL"
                        If Val(tx.Text) > 0 Then
                            palet = palet + 1
                            bultos = bultos + Val(tx.Text)
                        End If
                    Case "TXKIL"
                        kilos = kilos + VaDec(tx.Text)
                End Select
            End If
        Next
        TxDato7.Text = palet.ToString
        TxDato8.Text = bultos.ToString
        TxDato9.Text = kilos.ToString
        LbTaraEnv.Text = TotalTara.ToString
        PintaKilosNetos()

    End Sub


    Private Sub BtPalets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtPalets.Click
        PanelPalet()
    End Sub


    Private Sub PanelPalet()

        If TxDato7.Enabled = True Then
            If PanelKilos.Visible = False Then
                PanelKilos.Visible = True
                TxKil1.Focus()
            Else
                PanelKilos.Visible = False
                TxDato9.Select()
                TxDato9.Focus()
            End If
        End If

    End Sub


    Private Sub BtSumakilos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSumakilos.Click

        SumarPalets()

        PanelKilos.Visible = False
        TxDato9.Select()
        TxDato9.Focus()

    End Sub


    Private Sub ValidarKilosPalet(ByRef Txd As TxDato)
        If VaInt(Txd.Text) = 0 Then
            SumarPalets()
            PanelKilos.Visible = False
            Txd.Siguiente = TxDato9.Orden
        End If
    End Sub


    Private Sub SumaKilos()

        Dim totalKilos As Decimal = (VaDec(TxKil1.Text)) + (VaDec(TxKil2.Text)) + (VaDec(TxKil3.Text)) + (VaDec(TxKil4.Text)) +
            (VaDec(TxKil5.Text)) + (VaDec(TxKil6.Text)) + (VaDec(TxKil7.Text)) + (VaDec(TxKil8.Text)) + (VaDec(TxKil9.Text)) +
            (VaDec(TxKil10.Text)) + (VaDec(TxKil11.Text)) + (VaDec(TxKil12.Text)) + (VaDec(TxKil13.Text)) + (VaDec(TxKil14.Text)) +
            (VaDec(TxKil15.Text)) + (VaDec(TxKil16.Text))
        LbTKilos.Text = totalKilos.ToString("#,##0.00")

    End Sub


    Private Sub TxKil1_Valida(ByVal edicion As Boolean) Handles TxKil1.Valida
        If edicion = True Then
            ValidarKilosPalet(TxKil1)
        End If
        SumaKilos()
    End Sub


    Private Sub TxKil2_Valida(ByVal edicion As Boolean) Handles TxKil2.Valida
        If edicion = True Then
            ValidarKilosPalet(TxKil2)
        End If
        SumaKilos()
    End Sub


    Private Sub TxKil3_Valida(ByVal edicion As Boolean) Handles TxKil3.Valida
        If edicion = True Then
            ValidarKilosPalet(TxKil3)
        End If
        SumaKilos()
    End Sub


    Private Sub TxKil4_Valida(ByVal edicion As Boolean) Handles TxKil4.Valida
        If edicion = True Then
            ValidarKilosPalet(TxKil4)
        End If
        SumaKilos()
    End Sub


    Private Sub TxKil5_Valida(ByVal edicion As Boolean) Handles TxKil5.Valida
        If edicion = True Then
            ValidarKilosPalet(TxKil5)
        End If
        SumaKilos()
    End Sub


    Private Sub TxKil6_Valida(ByVal edicion As Boolean) Handles TxKil6.Valida
        If edicion = True Then
            ValidarKilosPalet(TxKil6)
        End If
        SumaKilos()
    End Sub


    Private Sub TxKil7_Valida(ByVal edicion As Boolean) Handles TxKil7.Valida
        If edicion = True Then
            ValidarKilosPalet(TxKil7)
        End If
        SumaKilos()
    End Sub


    Private Sub TxKil8_Valida(ByVal edicion As Boolean) Handles TxKil8.Valida
        If edicion = True Then
            ValidarKilosPalet(TxKil8)
        End If
        SumaKilos()
    End Sub

    Private Sub TxKil9_Valida(ByVal edicion As Boolean) Handles TxKil9.Valida
        If edicion = True Then
            ValidarKilosPalet(TxKil9)
        End If
        SumaKilos()
    End Sub

    Private Sub TxKil10_Valida(ByVal edicion As Boolean) Handles TxKil10.Valida
        If edicion = True Then
            ValidarKilosPalet(TxKil10)
        End If
        SumaKilos()
    End Sub

    Private Sub TxKil11_Valida(ByVal edicion As Boolean) Handles TxKil11.Valida
        If edicion = True Then
            ValidarKilosPalet(TxKil11)
        End If
        SumaKilos()
    End Sub


    Private Sub TxKil12_Valida(ByVal edicion As Boolean) Handles TxKil12.Valida
        If edicion = True Then
            ValidarKilosPalet(TxKil12)
        End If
        SumaKilos()
    End Sub

    Private Sub TxKil13_Valida(ByVal edicion As Boolean) Handles TxKil13.Valida
        If edicion = True Then
            ValidarKilosPalet(TxKil13)
        End If
        SumaKilos()
    End Sub

    Private Sub TxKil14_Valida(ByVal edicion As Boolean) Handles TxKil14.Valida
        If edicion = True Then
            ValidarKilosPalet(TxKil14)
        End If
        SumaKilos()
    End Sub

    Private Sub TxKil15_Valida(ByVal edicion As Boolean) Handles TxKil15.Valida
        If edicion = True Then
            ValidarKilosPalet(TxKil15)
        End If
        SumaKilos()
    End Sub

    Private Sub TxKil16_Valida(ByVal edicion As Boolean) Handles TxKil16.Valida
        If edicion = True Then
            ValidarKilosPalet(TxKil16)
        End If
        SumaKilos()
    End Sub


    Private Sub TxGenero_Valida(ByVal edicion As Boolean) Handles TxGenero.Valida

        Dim dt As New DataTable
        Dim idfamilia As String = ""
        Dim idSUBfamilia As String = ""
        Dim IdCultivo As Integer = 0

        AsociarControles(TxDato13, BtBuscaCat, CategoriasEntrada.bTBuscaEnt, CategoriasEntrada, CategoriasEntrada.CAE_CategoriaCalibre, Lb24)

        If Generos.LeerId(TxGenero.Text) = True Then
            idSUBfamilia = Generos.GEN_IdsubFamilia.Valor
            If Subfamilias.LeerId(idSUBfamilia) = True Then
                idfamilia = Subfamilias.SFA_idfamilia.Valor
                BtBuscaCat.CL_Filtro = "idfamilia=" + idfamilia
            End If
        End If

        If edicion = True Then

            Lb42.Text = ""

            If Generos.LeerId(TxGenero.Text) = True Then
                If Subfamilias.LeerId(Generos.GEN_IdsubFamilia.Valor) = True Then

                    Dim Agricultores As New E_Agricultores(Idusuario, cn)
                    If Agricultores.LeerId(TxDato3.Text) Then
                        Dim IdCentroRecogida As String = (Agricultores.AGR_idcrecogida.Valor & "").Trim
                        dt = FamiliasDescuentos.LeerDescuentos(VaInt(Subfamilias.SFA_idfamilia.Valor), VaInt(IdCentroRecogida))
                    End If

                End If


                If Not dt Is Nothing Then

                    If dt.Rows.Count > 0 Then

                        If LbFCS.Text = "C" Then
                            Lb42.Text = dt.Rows(0)("FAD_dtobascula").ToString
                        ElseIf LbFCS.Text = "F" Then
                            Lb42.Text = dt.Rows(0)("FAD_dtobasculafirme").ToString
                        ElseIf LbFCS.Text = "S" Then
                            Lb42.Text = dt.Rows(0)("FAD_dtobasculafirmesinclasif").ToString
                        End If

                    End If


                End If


                If TxDato5.Text = "" Then
                    TxDato5.Text = Generos.GEN_IdEnvase.Valor
                    TxDato5.Validar(False)
                End If

                idSUBfamilia = Generos.GEN_IdsubFamilia.Valor
                If Subfamilias.LeerId(idSUBfamilia) = True Then
                    idfamilia = Subfamilias.SFA_idfamilia.Valor
                    BtBuscaCat.CL_Filtro = "idfamilia=" + idfamilia
                End If

                If VaInt(Generos.GEN_Idcategoria.Valor) > 0 Then
                    TxDato13.Text = Generos.GEN_Idcategoria.Valor
                    TxDato13.Validar(False)
                End If

            End If




            If EsTecnicosNet() Then
                CompruebaCultivo_NET(edicion)
            Else
                CompruebaCultivo_VB6()
            End If


        End If

    End Sub


    Private Sub CompruebaCultivo_NET(edicion As Boolean)

        'Comprueba si hay un sólo cultivo que coincida con el género y lo pone por defecto
        Dim IdCultivoUnico As String = ""
        If ComprobarGeneroCultivo(IdCultivoUnico) Then
            If IdCultivoUnico <> "" Then
                TxCultivo.Text = IdCultivoUnico
                TxCultivo.Validar(edicion)
            End If
        End If

    End Sub


    Private Sub CompruebaCultivo_VB6()


        Dim Codprin As String = Fnc0(TxDato3.Text, 5)
        Dim CampaFincas As String = Fnc0(VaInt(LbCampaCultivo.Text), 2)
        Dim Genero As String = Fnc0(TxGenero.Text, 5)


        Dim sql As String = " select distinct g.cdcampa, g.cdfinca, isnull(datos_fincas.nombre, '') as nombre " & vbCrLf
        sql = sql & " from ( " & vbCrLf
        sql = sql & " select cdcampa, cdfinca from datos_fincas " & vbCrLf
        sql = sql & " where (datos_fincas.cdagricultor='" & Codprin & "') " & vbCrLf
        sql = sql & " and (datos_fincas.cdcampa='" & CampaFincas & "') " & vbCrLf
        sql = sql & " union all " & vbCrLf
        sql = sql & " select cdcampa, cdfinca from invernaderos_sigpac " & vbCrLf
        sql = sql & " where (invernaderos_sigpac.cdagricultor='" & Codprin & "') " & vbCrLf
        sql = sql & " and (invernaderos_sigpac.cdcampa='" & CampaFincas & "') " & vbCrLf
        sql = sql & " ) as g" & vbCrLf
        sql = sql & " left outer join datos_fincas on " & vbCrLf
        sql = sql & " datos_fincas.cdcampa = g.cdcampa and " & vbCrLf
        sql = sql & " datos_fincas.cdfinca = g.cdfinca " & vbCrLf
        sql = sql & " order by g.cdfinca " & vbCrLf

        Dim dt As DataTable = cnFincasVB6.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows

                If VaInt(Genero) = 0 Then
                    sql = "SELECT cultivos_lineas.idcultivo " & vbCrLf
                    sql = sql & " FROM cultivos_lineas " & vbCrLf
                    sql = sql & " WHERE (cultivos_lineas.cdcampa='" & CampaFincas & "') " & vbCrLf
                    sql = sql & " AND (cultivos_lineas.cdfinca='" & Trim(row("cdfinca").ToString) & "') " & vbCrLf
                Else
                    sql = "SELECT DISTINCT cultivos_lineas.idcultivo " & vbCrLf
                    sql = sql & " FROM cultivos_lineas " & vbCrLf
                    sql = sql & " LEFT JOIN generos_por_cultivo on cultivos_lineas.cdgenero = generos_por_cultivo.cdcultivo " & vbCrLf
                    sql = sql & " WHERE (cultivos_lineas.cdcampa='" & CampaFincas & "') " & vbCrLf
                    sql = sql & " AND (cultivos_lineas.cdfinca='" & Trim(row("cdfinca").ToString) & "') " & vbCrLf
                    sql = sql & " AND (generos_por_cultivo.cdgenalm='" & Genero & "') " & vbCrLf
                End If


                Dim dtc As DataTable = cnFincasVB6.ConsultaSQL(sql)
                If Not dtc Is Nothing Then
                    If dtc.Rows.Count = 1 Then

                        Dim IdCultivo As String = dtc.Rows(0)("IdCultivo").ToString & ""
                        TxCultivo.Text = IdCultivo
                        TxCultivo.Validar(True)

                    End If
                End If

            Next
        End If



    End Sub


    Public Overrides Sub Guardar()

        If LbFCS.Text.Trim <> "F" And LbFCS.Text.Trim <> "S" Then LbFCS.Text = "C"
        AlbEntrada.AEN_TipoFCS.Valor = LbFCS.Text.Trim
        AlbEntrada.AEN_EntradaConfeccionada.Valor = "N"


        AlbEntrada.AEN_IdMedianeria.Valor = Idmedianeria.ToString

        'Hora de la entrada
        If NuevoRegistro Then AlbEntrada.AEN_HoraEntrada.Valor = Now.ToString("HH:mm")


        MyBase.Guardar()

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtDetallesAlbaran.Click
        Dim frm As New VerAlba
        frm.init(LbId.Text)
        frm.ShowDialog()
    End Sub


    Private Sub LbBascu2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbBascu2.Click
        CambiaBascula(2)
    End Sub

    Private Sub LbBascu1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbBascu1.Click
        CambiaBascula(1)
    End Sub

    Private Sub LbBascu3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbBascu3.Click
        CambiaBascula(3)
    End Sub

    Private Sub LbBascu4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbBascu4.Click
        CambiaBascula(4)
    End Sub



    Private Sub BtBuscaCultivo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtBuscaCultivo.Click
        BuscaCultivos()
    End Sub


    Private Sub BuscaCultivos()

        If EsTecnicosNet() Then
            Dim frm As New FrmEntradaFincas_NET
            frm.Init(TxDato3.Text, TxGenero.Text, TxCultivo.Text)
            frm.ShowDialog()
        Else
            Dim frm As New FrmEntradaFincas_VB6
            frm.Init(TxDato3.Text, VaInt(LbCampaCultivo.Text), VaInt(TxGenero.Text), TxDato6.Text)
            frm.ShowDialog()
        End If




        If Not RowDePaso Is Nothing Then
            If TxCultivo.Enabled = True Then
                TxCultivo.Text = VaInt(RowDePaso("idcultivo")).ToString
            End If
        End If

    End Sub


    Private Sub pintacultivos()


    End Sub


    Private Function Autorizado(ByVal idfinca As String, ByVal idagricultor As String) As Boolean


        Dim ret As Boolean = True


        Return ret

    End Function


    Private Function CompruebaPosibleGastoDuplicado() As Boolean

        Dim bPosibleGastoDuplicado As Boolean = False
        Dim DcGastoFacturable As New Dictionary(Of Integer, Integer)
        Dim IdGasto As Integer = 0
        Dim FC As String = ""


        For numero As Integer = 1 To 4

            Select Case numero

                Case 1
                    IdGasto = VaInt(TxIdGasto1.Text)
                    FC = (LbDto1.Text.Trim)
                Case 2
                    IdGasto = VaInt(TxIdGasto2.Text)
                    FC = (LbDto2.Text.Trim)
                Case 3
                    IdGasto = VaInt(TxIdGasto3.Text)
                    FC = (LbDto3.Text.Trim)
                Case 4
                    IdGasto = VaInt(TxIdGasto4.Text)
                    FC = (LbDto4.Text.Trim)

            End Select


            If IdGasto > 0 And FC = "F" Then
                If DcGastoFacturable.ContainsKey(IdGasto) Then
                    bPosibleGastoDuplicado = True
                Else
                    DcGastoFacturable(IdGasto) = IdGasto
                End If
            End If

        Next


        Dim bVolverAGastos As Boolean = False
        If bPosibleGastoDuplicado Then
            If MessageBox.Show("Un Gasto está aparentemente duplicado, ¿está seguro de que es correcto?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                bVolverAGastos = False
            Else
                bVolverAGastos = True
            End If
        End If

        If bVolverAGastos Then
            TxIdGasto1.Select()
            TxIdGasto1.Focus()
        End If



        Return bVolverAGastos

    End Function


    Private Sub TxIdGasto4_Valida(ByVal edicion As Boolean) Handles TxIdGasto4.Valida

        If VaInt(TxIdGasto4.Text) > 0 Then

            If Tiposdegastoagri.LeerId(TxIdGasto4.Text) = True Then
                If Origengastos.LeerId(Tiposdegastoagri.TGA_idgrupo.Valor) = True Then
                    BtBuscaAcreedor4.CL_Filtro = "TIPO='" + Origengastos.ORG_tipo.Valor + "'"
                End If
            End If
        End If

        If edicion = True Then

            If TxIdGasto4.Text = "" Then

                LbNomGasto4.Text = ""
                LbTipGasto4.Text = ""
                TxVgasto4.Text = ""
                LbDto4.Text = ""
                TxAcreedor4.Text = ""
                LbNomAcreedor4.Text = ""
                TxIdGasto4.Siguiente = TxGenero.Orden

            End If

            If CompruebaPosibleGastoDuplicado() Then TxIdGasto4.Siguiente = TxIdGasto1.Orden

        Else
            If VaInt(TxIdGasto4.Text) > 0 Then
                LbTipGasto4.Text = Tiposdegastoagri.TGA_Tipo.Valor
                LbDto4.Text = Tiposdegastoagri.TGA_tipogastofc.Valor
            End If
        End If


    End Sub


    Private Sub TxIdGasto3_Valida(ByVal edicion As Boolean) Handles TxIdGasto3.Valida

        If VaInt(TxIdGasto3.Text) > 0 Then

            If Tiposdegastoagri.LeerId(TxIdGasto3.Text) = True Then
                If Origengastos.LeerId(Tiposdegastoagri.TGA_idgrupo.Valor) = True Then
                    BtBuscaAcreedor3.CL_Filtro = "TIPO='" + Origengastos.ORG_tipo.Valor + "'"
                End If
            End If
        End If

        If edicion = True Then
            If TxIdGasto3.Text = "" Then
                LbNomGasto3.Text = ""
                LbTipGasto3.Text = ""
                TxVgasto3.Text = ""
                LbDto3.Text = ""
                TxAcreedor3.Text = ""
                LbNomAcreedor3.Text = ""

                If CompruebaPosibleGastoDuplicado() Then
                    TxIdGasto3.Siguiente = TxIdGasto1.Orden
                ElseIf TxIdGasto3.Text = "" Then
                    TxIdGasto3.Siguiente = TxGenero.Orden
                Else
                    TxIdGasto3.Siguiente = TxIdGasto4.Orden
                End If


            Else
                If VaInt(TxIdGasto3.Text) > 0 Then
                    LbTipGasto3.Text = Tiposdegastoagri.TGA_Tipo.Valor
                    LbDto3.Text = Tiposdegastoagri.TGA_tipogastofc.Valor
                End If
            End If

        End If

    End Sub


    Private Sub TxIdGasto2_Valida(ByVal edicion As Boolean) Handles TxIdGasto2.Valida
        If VaInt(TxIdGasto2.Text) > 0 Then

            If Tiposdegastoagri.LeerId(TxIdGasto2.Text) = True Then
                If Origengastos.LeerId(Tiposdegastoagri.TGA_idgrupo.Valor) = True Then
                    BtBuscaAcreedor1.CL_Filtro = "TIPO='" + Origengastos.ORG_tipo.Valor + "'"
                End If
            End If
        End If

        If edicion = True Then
            If TxIdGasto2.Text = "" Then
                LbNomGasto2.Text = ""
                LbTipGasto2.Text = ""
                TxVgasto2.Text = ""
                LbDto2.Text = ""
                TxAcreedor2.Text = ""
                LbNomAcreedor2.Text = ""

                If TxIdGasto2.Text = "" Then
                    TxIdGasto2.Siguiente = TxGenero.Orden
                Else
                    TxIdGasto2.Siguiente = TxIdGasto3.Orden
                End If
            Else
                If VaInt(TxIdGasto2.Text) > 0 Then
                    LbTipGasto2.Text = Tiposdegastoagri.TGA_Tipo.Valor
                    LbDto2.Text = Tiposdegastoagri.TGA_tipogastofc.Valor
                End If
            End If

        End If

    End Sub


    Private Sub TxIdGasto1_Valida(ByVal edicion As Boolean) Handles TxIdGasto1.Valida

        If VaInt(TxIdGasto1.Text) > 0 Then

            If Tiposdegastoagri.LeerId(TxIdGasto1.Text) = True Then
                If Origengastos.LeerId(Tiposdegastoagri.TGA_idgrupo.Valor) = True Then
                    BtBuscaAcreedor1.CL_Filtro = "TIPO='" + Origengastos.ORG_tipo.Valor + "'"
                End If
            End If
        End If

        If edicion = True Then
            If TxIdGasto1.Text = "" Then
                LbNomGasto1.Text = ""
                LbTipGasto1.Text = ""
                TxVgasto1.Text = ""
                LbDto1.Text = ""
                TxAcreedor1.Text = ""
                LbNomAcreedor1.Text = ""

                If TxIdGasto1.Text = "" Then
                    TxIdGasto1.Siguiente = TxGenero.Orden
                Else
                    TxIdGasto1.Siguiente = TxIdGasto2.Orden
                End If
            Else
                If VaInt(TxIdGasto1.Text) > 0 Then
                    LbTipGasto1.Text = Tiposdegastoagri.TGA_Tipo.Valor
                    LbDto1.Text = Tiposdegastoagri.TGA_tipogastofc.Valor
                End If
            End If

        End If
    End Sub


    Private Sub GrabaGastosAlbaran()

        If Val(LbId.Text) = 0 Then Exit Sub
        Dim sql As String = "Delete from albentrada_gastos where AEG_idalbaran=" + LbId.Text
        Dim i As Integer = 0
        AlbEntrada_gastos.MiConexion.OrdenSql(sql)

        If VaInt(TxIdGasto1.Text) > 0 Then
            AlbEntrada_gastos.VaciaEntidad()
            i = AlbEntrada_gastos.MaxId
            AlbEntrada_gastos.AEG_Id.Valor = i.ToString
            AlbEntrada_gastos.AEG_IdAlbaran.Valor = LbId.Text
            AlbEntrada_gastos.AEG_IdGasto.Valor = TxIdGasto1.Text
            AlbEntrada_gastos.AEG_Tipo.Valor = LbTipGasto1.Text
            AlbEntrada_gastos.AEG_Gasto.Valor = TxVgasto1.Text
            AlbEntrada_gastos.AEG_IdAcreedor.Valor = TxAcreedor1.Text
            AlbEntrada_gastos.AEG_TipoFC.Valor = LbDto1.Text

            AlbEntrada_gastos.Insertar()
        End If

        If VaInt(TxIdGasto2.Text) > 0 Then
            AlbEntrada_gastos.VaciaEntidad()
            i = AlbEntrada_gastos.MaxId
            AlbEntrada_gastos.AEG_Id.Valor = i.ToString
            AlbEntrada_gastos.AEG_IdAlbaran.Valor = LbId.Text
            AlbEntrada_gastos.AEG_IdGasto.Valor = TxIdGasto2.Text
            AlbEntrada_gastos.AEG_Tipo.Valor = LbTipGasto2.Text
            AlbEntrada_gastos.AEG_Gasto.Valor = TxVgasto2.Text
            AlbEntrada_gastos.AEG_IdAcreedor.Valor = TxAcreedor2.Text
            AlbEntrada_gastos.AEG_TipoFC.Valor = LbDto2.Text

            AlbEntrada_gastos.Insertar()
        End If

        If VaInt(TxIdGasto3.Text) > 0 Then
            AlbEntrada_gastos.VaciaEntidad()
            i = AlbEntrada_gastos.MaxId
            AlbEntrada_gastos.AEG_Id.Valor = i.ToString
            AlbEntrada_gastos.AEG_IdAlbaran.Valor = LbId.Text
            AlbEntrada_gastos.AEG_IdGasto.Valor = TxIdGasto3.Text
            AlbEntrada_gastos.AEG_Tipo.Valor = LbTipGasto3.Text
            AlbEntrada_gastos.AEG_Gasto.Valor = TxVgasto3.Text
            AlbEntrada_gastos.AEG_IdAcreedor.Valor = TxAcreedor3.Text
            AlbEntrada_gastos.AEG_TipoFC.Valor = LbDto3.Text

            AlbEntrada_gastos.Insertar()
        End If

        If VaInt(TxIdGasto4.Text) > 0 Then
            AlbEntrada_gastos.VaciaEntidad()
            i = AlbEntrada_gastos.MaxId
            AlbEntrada_gastos.AEG_Id.Valor = i.ToString
            AlbEntrada_gastos.AEG_IdAlbaran.Valor = LbId.Text
            AlbEntrada_gastos.AEG_IdGasto.Valor = TxIdGasto4.Text
            AlbEntrada_gastos.AEG_Tipo.Valor = LbTipGasto4.Text
            AlbEntrada_gastos.AEG_Gasto.Valor = TxVgasto4.Text
            AlbEntrada_gastos.AEG_IdAcreedor.Valor = TxAcreedor4.Text
            AlbEntrada_gastos.AEG_TipoFC.Valor = LbDto4.Text

            AlbEntrada_gastos.Insertar()
        End If

    End Sub


    Private Sub CargaGastosAlbaran()

        Dim dt As New DataTable
        Dim Consulta As New Cdatos.E_select
        Dim x As Integer = 0

        If Val(LbId.Text) = 0 Then Exit Sub


        Consulta.SelCampo(AlbEntrada_gastos.AEG_IdGasto, "IdGasto")
        Consulta.SelCampo(Tiposdegastoagri.TGA_Nombre, "gasto", AlbEntrada_gastos.AEG_IdGasto)
        Consulta.SelCampo(Origengastos.ORG_tipo, "origen", Tiposdegastoagri.TGA_idgrupo)
        Consulta.SelCampo(AlbEntrada_gastos.AEG_Tipo, "tipo")
        Consulta.SelCampo(AlbEntrada_gastos.AEG_Gasto, "valor")
        Consulta.SelCampo(AlbEntrada_gastos.AEG_IdAcreedor, "idacreedor")
        Consulta.SelCampo(AlbEntrada_gastos.AEG_TipoFC, "tipofc")
        Consulta.WheCampo(AlbEntrada_gastos.AEG_IdAlbaran, "=", LbId.Text)
        dt = AlbEntrada_gastos.MiConexion.ConsultaSQL(Consulta.SQL)

        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                x = x + 1
                Select Case x
                    Case 1
                        TxIdGasto1.Text = rw("idgasto").ToString
                        LbNomGasto1.Text = rw("gasto")
                        LbTipGasto1.Text = rw("tipo")
                        TxVgasto1.Text = rw("valor")
                        TxAcreedor1.Text = rw("idacreedor").ToString
                        If VaInt(TxAcreedor1.Text) = 0 Then
                            TxAcreedor1.Text = ""
                        Else
                            If Acreedores.LeerId(TxAcreedor1.Text) = True Then
                                LbNomAcreedor1.Text = Acreedores.ACR_Nombre.valor
                            End If
                        End If
                        BtBuscaAcreedor1.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"
                        LbDto1.Text = rw("tipofc").ToString

                    Case 2
                        TxIdGasto2.Text = rw("idgasto").ToString
                        LbNomGasto2.Text = rw("gasto")
                        LbTipGasto2.Text = rw("tipo")
                        TxVgasto2.Text = rw("valor")
                        TxAcreedor2.Text = rw("idacreedor").ToString
                        If VaInt(TxAcreedor2.Text) = 0 Then
                            TxAcreedor2.Text = ""
                        Else
                            If Acreedores.LeerId(TxAcreedor2.Text) = True Then
                                LbNomAcreedor2.Text = Acreedores.ACR_Nombre.Valor
                            End If
                        End If

                        BtBuscaAcreedor2.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"
                        LbDto2.Text = rw("tipofc").ToString

                    Case 3
                        TxIdGasto3.Text = rw("idgasto").ToString
                        LbNomGasto3.Text = rw("gasto")
                        LbTipGasto3.Text = rw("tipo")
                        TxVgasto3.Text = rw("valor")
                        TxAcreedor3.Text = rw("idacreedor").ToString
                        BtBuscaAcreedor3.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"
                        If VaInt(TxAcreedor3.Text) = 0 Then
                            TxAcreedor3.Text = ""
                        Else
                            If Acreedores.LeerId(TxAcreedor3.Text) = True Then
                                LbNomAcreedor3.Text = Acreedores.ACR_Nombre.Valor
                            End If

                        End If

                        LbDto3.Text = rw("tipofc").ToString
                    Case 4
                        TxIdGasto4.Text = rw("idgasto").ToString
                        LbNomGasto4.Text = rw("gasto")
                        LbTipGasto4.Text = rw("tipo")
                        TxVgasto4.Text = rw("valor")
                        TxAcreedor4.Text = rw("idacreedor").ToString
                        BtBuscaAcreedor4.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"
                        If VaInt(TxAcreedor4.Text) = 0 Then
                            TxAcreedor4.Text = ""
                        Else
                            If Acreedores.LeerId(TxAcreedor4.Text) = True Then
                                LbNomAcreedor4.Text = Acreedores.ACR_Nombre.Valor
                            End If

                        End If
                        LbDto4.Text = rw("tipofc").ToString


                End Select

            Next
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()


        'Preliminar, no se usa printVB6
        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirAlbaraEntrada(LbId.Text, TipoImpresion.Preliminar, 0)
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()


        If VaInt(LbId.Text) > 0 Then

            Dim CopiasAlbaranEntrada As Integer = 2
            Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)
            If CentrosRecogida.LeerId(LbCrecogida.Text) Then
                CopiasAlbaranEntrada = VaInt(CentrosRecogida.CER_CopiasAlbaranEntrada.Valor)
                If CopiasAlbaranEntrada = 0 Then CopiasAlbaranEntrada = 2
            End If

            C1_ImprimirAlbaraEntrada(LbId.Text, TipoImpresion.ImpresoraSeleccionada, CopiasAlbaranEntrada)

        End If


    End Sub


    Public Overrides Sub TeclaFuncion(ByVal Tecla As System.Windows.Forms.Keys, ByVal obj As Object)
        MyBase.TeclaFuncion(Tecla, obj)

        Select Case Tecla
            Case Keys.F5
                CambiaBascula(1)
            Case Keys.F6
                CambiaBascula(2)
            Case Keys.F7
                CambiaBascula(3)
            Case Keys.F8
                CambiaBascula(4)

        End Select
    End Sub


    Private Sub btImprimirPartida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimirPartida.Click

        If ClGrid1.GridView.FocusedRowHandle >= 0 Then

            Dim row As DataRow = ClGrid1.GridView.GetFocusedDataRow()
            If Not IsNothing(row) Then

                Dim err As New Errores

                Try

                    If VaInt(row("AEL_IdLinea")) > 0 Then

                        Dim CopiasBoletinMuestreo As Integer = 2
                        Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)
                        If CentrosRecogida.LeerId(LbCrecogida.Text) Then
                            CopiasBoletinMuestreo = VaInt(CentrosRecogida.CER_CopiasBoletinMuestreo.Valor)
                            If CopiasBoletinMuestreo = 0 Then CopiasBoletinMuestreo = 2
                        End If

                        C1_ImprimirBoletinMuestreo(AlbEntrada_lineas.AEL_idlinea.Valor, TipoImpresion.ImpresoraPorDefecto, CopiasBoletinMuestreo)

                    End If

                Catch ex As Exception
                    err.Muestraerror("Error al imprimir", "Button5_Click", ex.Message)
                End Try

            End If

        End If

    End Sub


    Private Sub btImprimirCartelon_Click(sender As System.Object, e As System.EventArgs) Handles btImprimirCartelon.Click

        If ClGrid1.GridView.FocusedRowHandle >= 0 Then

            Dim row As DataRow = ClGrid1.GridView.GetFocusedDataRow()
            If Not IsNothing(row) Then

                Dim err As New Errores

                Try

                    If VaInt(row("AEL_IdLinea")) > 0 Then

                        C1_ImprimirCartelonPartida(AlbEntrada_lineas.AEL_idlinea.Valor, TipoImpresion.ImpresoraPorDefecto)

                    End If

                Catch ex As Exception
                    err.Muestraerror("Error al imprimir", "Button5_Click", ex.Message)
                End Try

            End If

        End If

    End Sub


    Private Sub CambiaBascula(ByVal nb As Integer)


        Dim s As Integer

        For Each formulario As Form In Me.MdiParent.MdiChildren
            If formulario.Text = "Entrada " + nb.ToString Then
                formulario.Focus()
                s = nb
            End If
        Next

        If s = 0 Then
            Dim frm As New FrmEntradas
            frm.MdiParent = Me.MdiParent
            frm.Text = "Entrada " + nb.ToString
            frm.Show()
        End If

    End Sub


    Private Sub TxDato12_Valida(ByVal edicion As Boolean)


        If edicion = True Then
            PintaTaraPalet()
        End If

    End Sub


    Private Sub TxDato11_Valida(ByVal edicion As Boolean)

        If edicion = True Then
            PintaTaraEnvase()
        End If

    End Sub


    Private Function PrecioPorKilo(ByVal FacturaEnvase As Integer, ByVal IdlineaSalida As String, ByVal Kilos As String, ByVal Bultos As String, ByVal PrecioK As String, ByVal PrecioBulto As String) As Decimal

        Dim ret As Decimal
        Dim sql As String
        Dim i As Decimal = VaDec(Kilos) * VaDec(PrecioK)


        If FacturaEnvase > 1 Then
            i = i + VaDec(Bultos) * VaDec(PrecioBulto)
        End If


        Dim gf As Decimal = 0

        sql = "Select sum(AAG_valorgasto) as gasto from albsalidaalh_gastos where AAG_idlinea=" + IdlineaSalida
        Dim dt2 As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)

        If Not dt2 Is Nothing Then
            If dt2.Rows.Count > 0 Then
                gf = VaDec(dt2.Rows(0)("gasto"))
            End If
        End If

        If VaDec(Kilos) > 0 Then
            ret = i / VaDec(Kilos) + gf
        End If

        Return ret


    End Function

    Private Sub TxBul1_Valida(edicion As System.Boolean) Handles TxBul1.Valida
        SumaBultos()
    End Sub
    Private Sub TxBul2_Valida(edicion As System.Boolean) Handles TxBul2.Valida
        SumaBultos()
    End Sub
    Private Sub TxBul3_Valida(edicion As System.Boolean) Handles TxBul3.Valida
        SumaBultos()
    End Sub
    Private Sub TxBul4_Valida(edicion As System.Boolean) Handles TxBul4.Valida
        SumaBultos()
    End Sub
    Private Sub TxBul5_Valida(edicion As System.Boolean) Handles TxBul5.Valida
        SumaBultos()
    End Sub
    Private Sub TxBul6_Valida(edicion As System.Boolean) Handles TxBul6.Valida
        SumaBultos()
    End Sub
    Private Sub TxBul7_Valida(edicion As System.Boolean) Handles TxBul7.Valida
        SumaBultos()
    End Sub
    Private Sub TxBul8_Valida(edicion As System.Boolean) Handles TxBul8.Valida
        SumaBultos()
    End Sub
    Private Sub TxBul9_Valida(edicion As System.Boolean) Handles TxBul9.Valida
        SumaBultos()
    End Sub
    Private Sub TxBul10_Valida(edicion As System.Boolean) Handles TxBul10.Valida
        SumaBultos()
    End Sub
    Private Sub TxBul11_Valida(edicion As System.Boolean) Handles TxBul11.Valida
        SumaBultos()
    End Sub
    Private Sub TxBul12_Valida(edicion As System.Boolean) Handles TxBul12.Valida
        SumaBultos()
    End Sub
    Private Sub TxBul13_Valida(edicion As System.Boolean) Handles TxBul13.Valida
        SumaBultos()
    End Sub
    Private Sub TxBul14_Valida(edicion As System.Boolean) Handles TxBul14.Valida
        SumaBultos()
    End Sub
    Private Sub TxBul15_Valida(edicion As System.Boolean) Handles TxBul15.Valida
        SumaBultos()
    End Sub
    Private Sub TxBul16_Valida(edicion As System.Boolean) Handles TxBul16.Valida
        If edicion Then CierraPanelKilos()
    End Sub


    Private Sub SumaBultos()

        Dim totalBultos As Decimal = VaDec(TxBul1.Text) + VaDec(TxBul2.Text) + VaDec(TxBul3.Text) + VaDec(TxBul4.Text) + VaDec(TxBul5.Text) +
            VaDec(TxBul6.Text) + VaDec(TxBul7.Text) + VaDec(TxBul8.Text) + VaDec(TxBul9.Text) + VaDec(TxBul10.Text) + VaDec(TxBul11.Text) +
            VaDec(TxBul12.Text) + VaDec(TxBul13.Text) + VaDec(TxBul14.Text) + VaDec(TxBul15.Text) + VaDec(TxBul16.Text)
        LbTBultos.Text = totalBultos.ToString("#,##0")

    End Sub


    Private Sub CierraPanelKilos()

        SumaBultos()

        SumarPalets()
        PanelKilos.Visible = False
        TxDato7.Select()
        TxDato7.Focus()

    End Sub


    Private Sub TxKil_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxKil8.KeyDown, TxKil7.KeyDown, TxKil6.KeyDown, TxKil5.KeyDown, TxKil4.KeyDown, TxKil3.KeyDown, TxKil2.KeyDown, TxKil1.KeyDown,
        TxKil9.KeyDown, TxKil10.KeyDown, TxKil11.KeyDown, TxKil12.KeyDown, TxKil13.KeyDown, TxKil14.KeyDown, TxKil15.KeyDown, TxKil16.KeyDown

        If e.KeyCode = Keys.F2 Then
            CierraPanelKilos()
        End If

    End Sub

    Private Sub TxBul_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxBul8.KeyDown, TxBul7.KeyDown, TxBul6.KeyDown, TxBul5.KeyDown, TxBul4.KeyDown, TxBul3.KeyDown, TxBul2.KeyDown, TxBul1.KeyDown,
        TxBul9.KeyDown, TxBul10.KeyDown, TxBul11.KeyDown, TxBul12.KeyDown, TxBul13.KeyDown, TxBul14.KeyDown, TxBul15.KeyDown, TxBul16.KeyDown

        If e.KeyCode = Keys.F2 Then
            CierraPanelKilos()
        End If

    End Sub

    Private Sub TxDato9_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato9.KeyDown
        If e.KeyCode = Keys.Up Then
            TxMarca.Select()
            TxMarca.Focus()
        End If
    End Sub

    Private Sub TxDato18_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btImprimirValeEnvases_Click(sender As System.Object, e As System.EventArgs) Handles btImprimirValeEnvases.Click

        Dim IdVale As String = AlbEntrada.AEN_IdValeEnvase.Valor

        If VaInt(IdVale) > 0 Then
            C1_ImprimirValeEnvases(IdVale, TipoImpresion.ImpresoraSeleccionada)
        End If

    End Sub

    Private Sub btImprimirValeGastos_Click(sender As System.Object, e As System.EventArgs) Handles btImprimirValeGastos.Click

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirValeGastosEntrada(LbId.Text, TipoImpresion.ImpresoraSeleccionada)
        End If

    End Sub


    Private Sub TxDato15_Valida(edicion As Boolean) Handles TxDato15.Valida
        If edicion = True Then
            If TxDato15.Text <> "N" Then
                TxDato15.Text = "S"
            End If
        End If
    End Sub


    Private Sub btGenerarVales_Click_1(sender As System.Object, e As System.EventArgs) Handles btGenerarVales.Click

        If VaInt(LbId.Text) = 0 Then Exit Sub


        If MsgBox("Desea generar el vale de envases", vbYesNo) = vbNo Then
            Exit Sub

        End If

        AlbEntrada.CrearValeEnvasesComercio(LbId.Text)
        MsgBox("Vale de envase generado")


    End Sub


    Private Sub TxDato18_Valida(edicion As Boolean) Handles TxDato18.Valida

        If TxDato18.Text <> "" Then
            Idmedianeria = Medianeria.LeerMedianeria(TxDato3.Text, TxDato18.Text)
            If Idmedianeria = 0 Then
                If edicion = True Then
                    MsgBox("Medianeria inexistente ")
                    TxDato18.MiError = True
                End If

            Else
                If Medianeria.LeerId(Idmedianeria) = True Then
                    LbNomMedianero.Text = Medianeria.MED_Nombre.Valor
                    If Medianeria.MED_IdAgricultor.Valor <> TxDato3.Text Then
                        MsgBox("Medianeria no coincide con proveedor")
                        TxDato18.MiError = True
                    End If
                End If
            End If
        End If


    End Sub


    'Private Sub TxDato22_Valida(edicion As Boolean)
    '    If TxDato22.Text <> "B" And TxDato22.Text <> "P" Then
    '        TxDato22.Text = "K"
    '    End If
    'End Sub


    Private Sub TxDato11_Valida1(edicion As Boolean) Handles TxCalidad.Valida

        If edicion = True Then
            If TxCalidad.Text = "" Then
                TxCalidad.Text = "B"
            End If
        End If

        Select Case TxCalidad.Text

            Case "A"
                LbColorEtiqueta.BackColor = Color.FromArgb(92, 166, 68)
            Case "B"
                LbColorEtiqueta.BackColor = Color.Gold
            Case "C"
                LbColorEtiqueta.BackColor = Color.Red
            Case Is > "C"
                LbColorEtiqueta.BackColor = Color.Red
            Case Else
                LbColorEtiqueta.BackColor = Color.White

        End Select

    End Sub


    Private Sub TxCultivo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxCultivo.KeyDown
        If e.KeyCode = Keys.F2 Then
            BuscaCultivos()
        End If
    End Sub


    Private Sub TxCultivo_Valida(edicion As Boolean) Handles TxCultivo.Valida


        If Not CultivoBloqueado(TxCultivo.Text) Then

            If Not CultivoBloqueadoTemporalmente(TxCultivo.Text) Then

                Leercultivo(TxCultivo.Text, edicion)
                'Si no hay cultivo, mantenemos lo que hubiera en controlado
                'If edicion = True Then
                '    If VaInt(TxCultivo.Text) = 0 Then
                '        TxControlado.Text = "N"
                '        TxControlado.Validar(edicion)
                '    End If
                'End If

            Else
                'TxCultivo.MiError = True
                MsgBox("ATENCIÓN: Cultivo bloqueado temporalmente")
            End If

        Else
            MsgBox("ATENCIÓN: Cultivo bloqueado")
        End If


    End Sub


    Private Sub Leercultivo(idcultivo As String, edicion As Boolean)

        If EsTecnicosNet() Then
            LeerCultivo_NET(idcultivo, edicion)
        Else
            LeerCultivo_VB6(idcultivo, edicion)
        End If

    End Sub


    Private Function CultivoBloqueado(IdCultivo As String) As Boolean

        Dim bRes As Boolean = False

        Dim Cultivos As New E_Cultivos(Idusuario, cnFincasNET)
        If Cultivos.LeerId(IdCultivo) Then

            Dim Bloqueado As String = (Cultivos.CUL_Bloquear.Valor & "").Trim
            bRes = (Bloqueado = "S")

        End If

        Return bRes

    End Function


    Private Function CultivoBloqueadoTemporalmente(IdCultivo As String) As Boolean

        Dim bRes As Boolean = False


        If VaInt(IdCultivo) > 0 Then

            Dim Ahora As DateTime = Now
            Dim FechaHoy As String = Ahora.ToString("dd/MM/yyyy")
            Dim HoraHoy As String = Ahora.ToString("HH:mm")

            Dim sql As String = "SELECT BCU_IdBloqueo as IdBloqueo, BCU_DeFecha as DesdeFecha, BCU_AFecha as HastaFecha, BCU_DeHora as DesdeHora, BCU_AHora as HastaHora" & vbCrLf
            sql = sql & " FROM BloqueoCultivos" & vbCrLf
            sql = sql & " WHERE BCU_IdCultivo = " & IdCultivo & vbCrLf
            sql = sql & " AND '" & FechaHoy & "' BETWEEN BCU_DeFecha AND BCU_AFecha" & vbCrLf
            'sql = sql & " AND '" & HoraHoy & "' BETWEEN BCU_DeHora AND BCU_AHora" & vbCrLf

            Dim dt As DataTable = BloqueoCultivos.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim row As DataRow = dt.Rows(0)

                    Dim DesdeFecha As String = VaDate(row("DesdeFecha")).ToString("dd/MM/yyyy")
                    Dim HastaFecha As String = VaDate(row("HastaFecha")).ToString("dd/MM/yyyy")
                    Dim DesdeHora As String = (row("DesdeHora").ToString & "").Trim
                    Dim HastaHora As String = (row("HastaHora").ToString & "").Trim

                    Dim Desde As DateTime = VaTime(DesdeFecha & " " & DesdeHora & ":00")
                    Dim Hasta As DateTime = VaTime(HastaFecha & " " & HastaHora & ":59")

                    If Ahora >= Desde And Ahora <= Hasta Then
                        bRes = True
                    Else
                        bRes = False
                    End If

                Else
                    bRes = False
                End If
            End If

        End If


        Return bRes

    End Function


    Private Sub LeerCultivo_VB6(IdCultivo As String, edicion As String)

        Dim g As String = ""

        If VaInt(IdCultivo) > 0 Then


            Dim cdGenero As String = ""
            Dim cdFinca As String = ""
            Dim cdNave As String = ""

            NombreGeneroCultivo(LbCampaCultivo.Text, IdCultivo, cdGenero, cdFinca, cdNave)
            g = InvernaderosFincas(cdFinca, cdNave, LbCampaCultivo.Text).Trim


            Dim controlado As String = ""
            Dim IdPrograma As String = ProgramaCalidadCultivo(LbCampaCultivo.Text, IdCultivo, controlado)

            If edicion Then
                If VaInt(LbCalidad.Text) = 0 Then
                    LbIdCalidad.Text = VaInt(IdPrograma).ToString
                    MuestraProgramaCalidad()
                End If
            End If


            If controlado.Trim.ToUpper = "S" Then
                TxControlado.Text = "S"
            Else
                TxControlado.Text = "N"
            End If

            TxControlado.Validar(True)
            TxCultivo.Siguiente = TxCalidad.Orden



            Dim bPermitido As Boolean = False

            'Cultivos permitidos para ese género
            Dim sqlLote As String = "SELECT CdCultivo FROM Generos_por_cultivo WHERE CdGenAlm = '" & VaInt(TxGenero.Text).ToString("00000") & "'"
            Dim dtLote As DataTable = cnFincasVB6.ConsultaSQL(sqlLote)
            If Not IsNothing(dtLote) Then
                For Each row As DataRow In dtLote.Rows

                    Dim CdCultivo As String = (row("CdCultivo").ToString & "").Trim
                    If VaInt(CdCultivo) = VaInt(cdGenero) Then
                        bPermitido = True
                        Exit For
                    End If

                Next
            End If

            If Not bPermitido Then
                MsgBox("El cultivo no tiene el mismo genero que la línea de entrada")
                TxCultivo.MiError = True
            End If


            If g <> "" Then
                LbNomCultivo.Text = g
            Else

                LbNomCultivo.Text = ""

                If edicion = True Then
                    TxCultivo.MiError = True
                    MsgBox("Cultivo inexistente")
                End If

            End If


        End If

    End Sub


    Private Sub LeerCultivo_NET(IdCultivo As String, edicion As String)

        If VaInt(IdCultivo) > 0 Then


            Dim Genero As String = ""
            Dim Variedad As String = ""
            Dim IdPrograma As String = ""
            Dim Controlado As String = ""
            Dim TipoCultivo As String = ""
            Dim Nave As String = ""
            Dim Campa As String = ""
            Dim CalidadEntradas As String = ""
            Dim bCultivoEncontrado As Boolean = DatosCultivo(IdCultivo, Genero, Variedad, IdPrograma, Controlado, TipoCultivo, Nave, Campa, CalidadEntradas)



            'Nombre cultivo
            LbNomCultivo.Text = Genero & " - " & Variedad


            If edicion Then

                If Not bCultivoEncontrado Then
                    TxCultivo.MiError = True
                    MsgBox("Cultivo inexistente")
                End If

                'Programa de calidad 
                LbIdCalidad.Text = VaInt(IdPrograma).ToString
                MuestraProgramaCalidad()


                'Comprobar que el género de la entrada está dentro del género del cultivo
                Dim bPermitido As Boolean = ComprobarGeneroCultivo("")
                If Not bPermitido Then
                    MsgBox("El cultivo no tiene el mismo genero que la línea de entrada")
                    TxCultivo.MiError = True
                End If


                'Calidad por defecto
                If TxCalidad.Text.Trim = "" Then
                    TxCalidad.Text = CalidadEntradas
                End If


            End If



            If Controlado.Trim.ToUpper = "S" Then
                TxControlado.Text = "S"
            Else
                TxControlado.Text = "N"
            End If

        End If

    End Sub


    Private Function ComprobarGeneroCultivo(Optional ByRef IdCultivoUnico As String = "") As Boolean

        Dim bRes As Boolean = False

        Dim dt As DataTable = ObtenerCultivos(TxDato3.Text, TxGenero.Text, True)


        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows

                Dim IdGeneroAgro As String = (row("IdGeneroAgro").ToString & "").Trim
                If VaInt(IdGeneroAgro) = VaInt(TxGenero.Text) Then
                    bRes = True

                    'Comprueba si hay un sólo cultivo
                    Dim IdCultivo As String = (row("IdCultivo").ToString & "").Trim
                    If dt.Rows.Count = 1 Then
                        IdCultivoUnico = IdCultivo
                    End If

                    Exit For
                End If

            Next

        End If




        Return bRes

    End Function



    Private Sub PintaNbascula(ByVal Bascula As Integer)

        LbBascu1.BackColor = Color.White
        LbBascu2.BackColor = Color.White
        LbBascu3.BackColor = Color.White
        LbBascu4.BackColor = Color.White

        Select Case Bascula
            Case 1
                LbBascu1.BackColor = Color.LightGreen
            Case 2
                LbBascu2.BackColor = Color.LightGreen
            Case 3
                LbBascu3.BackColor = Color.LightGreen
            Case 4
                LbBascu4.BackColor = Color.LightGreen
        End Select

    End Sub



    Private Sub TxControlado_Valida(edicion As System.Boolean) Handles TxControlado.Valida

        If edicion Then

            If TxControlado.Text = "" Then TxControlado.Text = "N"
            If TxCultivo.Text.Trim = "" Then CalculaProgramaCalidad()

        End If

    End Sub


    Private Sub CalculaProgramaCalidad()

        'Si tiene cultivo asociado, se deja como está.
        'Si no tiene cultivo asociado:
        '   1) Si controlado = "S", el programa de calidad = 1 (GLOBALGAP)
        '   2) Si controlado = "N", el programa de calidad = 3 (NO CONTROLADO)


        If VaInt(TxCultivo.Text) = 0 Then

            If TxControlado.Text.Trim.ToUpper = "S" Then
                'LbIdCalidad.Text = "1"

                Dim IdPrograma As String = "1"

                Dim ValoresPVenta As New E_valorespventa(Idusuario, cn)
                If ValoresPVenta.LeerId(MiMaletin.IdPuntoVenta.ToString) Then
                    If (ValoresPVenta.VPV_EcologicoSN.Valor & "").Trim = "S" Then
                        IdPrograma = "15"
                    End If
                End If
                LbIdCalidad.Text = IdPrograma

            Else
                LbIdCalidad.Text = "3"
            End If
            MuestraProgramaCalidad()

        End If


    End Sub



    Private Sub btBuscaPartidas_Click(sender As System.Object, e As System.EventArgs) Handles btBuscaPartidas.Click
        EnlazaBusquedaPartidas()
    End Sub


    Private Sub EnlazaBusquedaPartidas()

        Dim sql As String = AlbEntrada_lineas.btBusca.CL_ConsultaSql
        Dim dt As DataTable = AlbEntrada_lineas.MiConexion.ConsultaSQL(sql)

        Dim Frb As New FrBuscar
        Frb.InitCol(AlbEntrada_lineas.btBusca.CL_ParamBusqueda, 0)
        Frb.InitDta(dt, AlbEntrada_lineas.btBusca.CL_CampoOrden, AlbEntrada_lineas.btBusca.CL_Filtro, AlbEntrada_lineas.btBusca.CL_ch1000)
        Frb.Width = 1024
        Frb.ShowDialog()

        If Not IsNothing(BuscarRow) Then
            Dim Partida As String = BuscarRow("Partida")
            TxBuscarPorPartida.Text = Partida
            TxBuscarPorPartida.Validar(True)
        End If

    End Sub

    Private Sub TxBuscarPorPartida_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxBuscarPorPartida.KeyDown
        If e.KeyCode = Keys.F2 Then
            EnlazaBusquedaPartidas()
        End If
    End Sub

    Private Sub TxDato1_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxDato1.EnabledChanged
        TxBuscarPorPartida.Enabled = TxDato1.Enabled
        btBuscaPartidas.Enabled = TxDato1.Enabled
    End Sub

    Private Sub TxBuscarPorPartida_Valida(edicion As System.Boolean) Handles TxBuscarPorPartida.Valida

        If edicion Then

            If VaInt(TxBuscarPorPartida.Text) > 0 Then

                Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
                Dim id As Integer = AlbEntrada_Lineas.LeerMuestreo(LbCampa.Text, TxBuscarPorPartida.Text)

                If id > 0 Then

                    Dim CONSULTA As New Cdatos.E_select
                    CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idalbaran, "IdAlbaran")
                    CONSULTA.SelCampo(AlbEntrada.AEN_Albaran, "Albaran", AlbEntrada_Lineas.AEL_idalbaran, AlbEntrada.AEN_IdAlbaran)
                    CONSULTA.WheCampo(AlbEntrada_Lineas.AEL_idlinea, "=", id.ToString)

                    Dim sql As String = CONSULTA.SQL
                    Dim bEncontrado As Boolean = False

                    Dim dt As DataTable = AlbEntrada_Lineas.MiConexion.ConsultaSQL(sql)
                    If Not IsNothing(dt) Then
                        If dt.Rows.Count > 0 Then

                            bEncontrado = True



                            TxDato1.Text = (dt.Rows(0)("Albaran").ToString & "").Trim

                            TxDato1.MiError = False
                            QuitaError(TxDato1.Orden)

                            TxDato1.Validar(True)


                            If Not TxDato1.MiError And TxDato1.Text.Trim <> "" Then
                                Siguiente(TxDato1.Orden)
                            End If


                        End If
                    End If

                    If Not bEncontrado Then
                        MsgBox("La partida no existe para esta campaña")
                    End If


                End If

            End If


        End If

    End Sub

    Private Sub TxDato6_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato6.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            TxDato20.Select()
            TxDato20.Focus()
        End If
    End Sub

    Private Sub TxDato20_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato20.KeyDown
        If e.KeyCode = Keys.Up Then
            TxDato6.Select()
            TxDato6.Focus()
        End If
    End Sub


    Private Sub btPrevisiones_Click(sender As System.Object, e As System.EventArgs) Handles btPrevisiones.Click

        If VaInt(TxDato3.Text) > 0 Then

            Dim frm As New FrmPreviones()
            frm.InitAgricultor(TxDato3.Text)
            frm.ShowDialog()

        End If

    End Sub


    Private Sub TxMarca_Valida(edicion As System.Boolean) Handles TxMarca.Valida
        If edicion Then
            TxMarca.Siguiente = TxDato9.Orden
        End If
    End Sub


    Private Sub TxDato19_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato19.TextChanged

    End Sub

    Private Sub TxDato19_Valida(edicion As Boolean) Handles TxDato19.Valida
        If edicion = True Then
            LbTipoPrecio.Text = "K"
        End If
    End Sub


    Private Sub TxDato_6_Valida(edicion As System.Boolean) Handles TxDato_6.Valida


        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        If Agricultores.LeerId(TxDato3.Text) = True Then

            If edicion = True Then

                DatosGasto()

            End If

        End If


    End Sub


    Private Sub DatosGasto()

        Dim Consulta As New Cdatos.E_select
        Dim i As Integer = 0

        Consulta.SelCampo(AgricultorGastos.AGG_IdGasto)
        Consulta.SelCampo(Tiposdegastoagri.TGA_Nombre, "gasto", AgricultorGastos.AGG_IdGasto)
        Consulta.SelCampo(AgricultorGastos.AGG_Valor, "valor")
        Consulta.SelCampo(AgricultorGastos.AGG_TipoFC)
        Consulta.SelCampo(Tiposdegastoagri.TGA_Tipo, "tipo")
        Consulta.SelCampo(Origengastos.ORG_tipo, "origen", Tiposdegastoagri.TGA_idgrupo)
        Consulta.SelCampo(AgricultorGastos.AGG_IdAcreedor, "IdAcreedor")
        Consulta.SelCampo(AgricultorGastos.AGG_AsignarAcreedorAlbaran, "AsignarAcreedor")
        Consulta.WheCampo(AgricultorGastos.AGG_IdAgricultor, "=", TxDato3.Text)
        Consulta.WheCampo(AgricultorGastos.AGG_PedirEntrada, "=", "S")

        Dim sql As String = Consulta.SQL
        sql = sql + " AND (AGG_idcentrorec=0 or AGG_Idcentrorec=" + LbCrecogida.Text + ") "
        sql = sql + " order by AGG_id"

        Dim dt As New DataTable
        dt = AgricultorGastos.MiConexion.ConsultaSQL(sql)


        Dim bPosibleGastoDuplicado As Boolean = False
        Dim DcGastoFacturable As New Dictionary(Of Integer, Integer)


        If Not dt Is Nothing Then

            For Each rw In dt.Rows

                i = i + 1

                Dim IdAcreedor As String = (rw("IdAcreedor").ToString & "").Trim
                Dim IdTransportista As String = TxDato_6.Text
                Dim bAsignarAcreedor As String = ((rw("AsignarAcreedor").ToString & "").Trim = "S")

                Select Case i
                    Case 1

                        TxIdGasto1.Text = rw("AGG_idgasto").ToString
                        LbNomGasto1.Text = rw("gasto")
                        LbTipGasto1.Text = rw("tipo")
                        TxVgasto1.Text = rw("valor")
                        BtBuscaAcreedor1.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"

                        LbDto1.Text = rw("AGG_tipofc").ToString

                        'TxAcreedor1.Text = rw("AGG_idacreedor").ToString
                        If bAsignarAcreedor Then
                            TxAcreedor1.Text = IdTransportista
                        Else
                            TxAcreedor1.Text = IdAcreedor
                        End If

                        If VaInt(TxAcreedor1.Text) > 0 Then
                            TxAcreedor1.Validar(False)
                        Else
                            TxAcreedor1.Text = ""
                        End If


                    Case 2

                        TxIdGasto2.Text = rw("AGG_idgasto").ToString
                        LbNomGasto2.Text = rw("gasto")
                        LbTipGasto2.Text = rw("tipo")
                        TxVgasto2.Text = rw("valor")
                        BtBuscaAcreedor2.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"

                        LbDto2.Text = rw("AGG_tipofc").ToString

                        'TxAcreedor2.Text = rw("AGG_idacreedor").ToString
                        If bAsignarAcreedor Then
                            TxAcreedor2.Text = IdTransportista
                        Else
                            TxAcreedor2.Text = IdAcreedor
                        End If


                        If VaInt(TxAcreedor2.Text) > 0 Then
                            TxAcreedor2.Validar(False)
                        Else
                            TxAcreedor2.Text = ""
                        End If


                    Case 3

                        TxIdGasto3.Text = rw("AGG_idgasto").ToString
                        LbNomGasto3.Text = rw("gasto")
                        LbTipGasto3.Text = rw("tipo")
                        LbDto3.Text = rw("AGG_tipofc").ToString

                        TxVgasto3.Text = rw("valor")
                        BtBuscaAcreedor3.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"

                        'TxAcreedor3.Text = rw("AGG_idacreedor").ToString
                        If bAsignarAcreedor Then
                            TxAcreedor3.Text = IdTransportista
                        Else
                            TxAcreedor3.Text = IdAcreedor
                        End If


                        If VaInt(TxAcreedor3.Text) > 0 Then
                            TxAcreedor3.Validar(False)
                        Else
                            TxAcreedor3.Text = ""
                        End If


                    Case 4

                        TxIdGasto4.Text = rw("AGG_idgasto").ToString
                        LbNomGasto4.Text = rw("gasto")
                        LbTipGasto4.Text = rw("tipo")
                        TxVgasto4.Text = rw("valor")
                        BtBuscaAcreedor4.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"
                        LbDto4.Text = rw("AGG_tipofc").ToString

                        'TxAcreedor4.Text = rw("AGG_idacreedor").ToString
                        If bAsignarAcreedor Then
                            TxAcreedor4.Text = IdTransportista
                        Else
                            TxAcreedor4.Text = IdAcreedor
                        End If


                        If VaInt(TxAcreedor4.Text) > 0 Then
                            TxAcreedor4.Validar(False)
                        Else
                            TxAcreedor4.Text = ""
                        End If


                End Select
            Next

            Dim o As Integer = 0
            If TxIdGasto1.Text = "" Then
                o = TxIdGasto1.Orden
            End If
            If o = 0 Then
                If TxAcreedor1.Text = "" Then
                    o = TxAcreedor1.Orden
                End If
            End If
            If o = 0 Then
                If TxIdGasto2.Text = "" Then
                    o = TxIdGasto2.Orden
                End If
            End If

            If o = 0 Then
                If TxAcreedor2.Text = "" Then
                    o = TxAcreedor2.Orden
                End If
            End If
            If o = 0 Then
                If TxIdGasto3.Text = "" Then
                    o = TxIdGasto3.Orden
                End If
            End If
            If o = 0 Then
                If TxAcreedor3.Text = "" Then
                    o = TxAcreedor3.Orden
                End If
            End If
            If o = 0 Then
                If TxIdGasto4.Text = "" Then
                    o = TxIdGasto4.Orden
                End If
            End If
            If o = 0 Then
                If TxAcreedor4.Text = "" Then
                    o = TxAcreedor4.Orden
                End If
            End If


            If o > 0 Then
                TxDato6.Siguiente = o
            End If

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


        Dim nif As String = ""
        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        If Agricultores.LeerId(TxDato3.Text) Then
            nif = (Agricultores.AGR_Nif.Valor & "").Trim.Replace("-", "").Replace(".", "").Replace(" ", "")
        End If



        Dim fechafiltro As String = TxDato6.Text
        If VaDate(TxDato6.Text) > VaDate("") Then
            fechafiltro = DateAdd(DateInterval.Day, -1, VaDate(TxDato6.Text)).ToString("dd/MM/yyyy")
        End If

        BtBuscaLocalizador.CL_Filtro = "Fecha >= '" & fechafiltro & "' AND NIF = '" & nif & "'"

    End Sub


    Private Sub MuestraFacturaAgr()

        Dim Serie As String = ""
        Dim Factura As String = ""


        If VaDec(LbId.Text) > 0 Then

            Dim sql As String = "SELECT TOP 1 FGR_Serie as Serie, FGR_NumeroFactur as Factura" & vbCrLf
            sql = sql & " FROM AlbEntrada_lineas" & vbCrLf
            sql = sql & " LEFT JOIN FacturaAgr_Lineas ON AEL_IdLinea = FAL_IdPartida" & vbCrLf
            sql = sql & " LEFT JOIN FacturaAgr ON FGR_IdFactura = FAL_IdFactura" & vbCrLf
            sql = sql & " WHERE AEL_IdAlbaran = " & LbId.Text & vbCrLf

            Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim row As DataRow = dt.Rows(0)
                    Serie = (row("Serie").ToString & "").Trim
                    Factura = (row("Factura").ToString & "").Trim

                End If
            End If

        End If


        LbSerie.Text = Serie
        LbFactura.Text = Factura


    End Sub



    Private Sub TxLocalizadorDAT_Valida(edicion As System.Boolean) Handles TxLocalizadorDAT.Valida

        If edicion Then

            If TxLocalizadorDAT.Text.Trim <> "" Then

                Dim DAT_ENTRADAS As New E_DAT_ENTRADAS(Idusuario, cn)
                If Not DAT_ENTRADAS.LeerId(TxLocalizadorDAT.Text) Then
                    TxLocalizadorDAT.MiError = True
                    MsgBox("El localizador introducido no existe")
                Else

                    Dim Agricultores As New E_Agricultores(Idusuario, cn)
                    If Agricultores.LeerId(TxDato3.Text) Then

                        Dim nif As String = (Agricultores.AGR_Nif.Valor & "").Trim.Replace("-", "").Replace(".", "").Replace(" ", "")
                        If nif <> (DAT_ENTRADAS.DAT_NIFAgricultor.Valor & "").Trim Then
                            If MessageBox.Show("El NIF del agricultor (" & nif & ") no coincide con el NIF del porte (" & (DAT_ENTRADAS.DAT_NIFAgricultor.Valor & "").Trim & "). ¿Desea continuar?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then


                                Dim fechaporte As String = FnF8(FnFechaInversa(DAT_ENTRADAS.DAT_FechaLog.Valor & ""))

                                If VaDate(TxDato6.Text) <> VaDate(fechaporte) Then
                                    If MessageBox.Show("La fecha del albarán (" & TxDato6.Text & ") no coincide con la fecha del porte (" & fechaporte & "). ¿Desea continuar?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

                                    Else
                                        TxLocalizadorDAT.MiError = True
                                    End If
                                End If


                            Else
                                TxLocalizadorDAT.MiError = True
                            End If
                        End If

                    End If


                End If

            End If





            ''Mostrar mensaje de advertencia si queremos quitar un localizador que ya estaba presentado
            'Dim localizador_anterior As String = (AlbEntrada.AEN_LocalizadorDAT.Valor & "").Trim
            'If TxLocalizadorDAT.Text.Trim = "" And localizador_anterior <> "" Then

            '    Dim DAT_ENTRADAS As New E_DAT_ENTRADAS(Idusuario, cn)
            '    If DAT_ENTRADAS.LeerId(localizador_anterior) Then
            '        If VaInt(DAT_ENTRADAS.DAT_Estado.Valor) = VaInt(E_DAT_ENTRADAS.DAT_Estados.Rechazado) Or VaInt(DAT_ENTRADAS.DAT_Estado.Valor) = VaInt(E_DAT_ENTRADAS.DAT_Estados.Recibido) Then

            '            DAT_ENTRADAS.DAT_IdAlbaran.Valor = ""
            '            DAT_ENTRADAS.DAT_IdAlbaranNET.Valor = ""
            '            DAT_ENTRADAS.Actualizar()

            '        End If
            '    End If
            'End If


            'If TxLocalizadorDAT.Text.Trim <> "" Then
            '    Dim DAT_ENTRADAS As New E_DAT_ENTRADAS(Idusuario, cn)
            '    If DAT_ENTRADAS.LeerId(TxLocalizadorDAT.Text) Then

            '        If MessageBox.Show("El localizador es de fecha distinta al albarán de salida (" & DAT_ENTRADAS.DAT_FechaLog 
            '        End If

            '    End If
            'End If

        End If

    End Sub

End Class