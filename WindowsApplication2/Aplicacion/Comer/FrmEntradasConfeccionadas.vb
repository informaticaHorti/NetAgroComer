Imports DevExpress.XtraEditors

Public Class FrmEntradasConfeccionadas
    Inherits FrMantenimiento


    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim AlbEntrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim AlbEntrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)
    Dim AlbEntrada_lineaskilos As New E_AlbEntrada_lineaskilos(Idusuario, cn)
    Dim AlbEntrada_gastos As New E_albentrada_gastos(Idusuario, cn)

    Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim AgricultorGastos As New E_AgricultorGastos(Idusuario, cn)
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



    Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim PventaUsuario As New E_PventaUsuario(Idusuario, cn)
    Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)
    Dim Mi_idcentro As String

    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Idtarifa As Integer
    Dim DtoMerma As Double



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

        ParamTx(TxDato20, AlbEntrada.AEN_referencia, Lb60, False)
        ParamTx(TxDato3, AlbEntrada.AEN_IdAgricultor, Lb3, True)
        ParamTx(TxDato23, AlbEntrada.AEN_matricula, Lb64, False)
        ParamTx(TxDato18, AlbEntrada.AEN_IdMedianeria, Lb21, False)
        ParamTx(TxLocalizadorDAT, AlbEntrada.AEN_LocalizadorDAT, LbLocalizadorDAT)
        ParamTx(TxDato_6, AlbEntrada.AEN_IdTransportista, Lb_6, False)

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

        ParamTx(TxLpedido, AlbEntrada_lineas.AEL_IdPedidoLinea, Lb20)
        ParamTx(TxControlado, AlbEntrada_lineas.AEL_Controlado, LbControlado, , , , , "SN")
        ParamTx(TxGenero, AlbEntrada_lineas.AEL_idgenero, Lb5, False)
        ParamTx(TxCultivo, AlbEntrada_lineas.AEL_idcultivo, LbCultivo, False)
        ParamTx(TxCategoria, AlbEntrada_lineas.AEL_idcategoria, Lb25, True)
        ParamTx(TxConfeccion, AlbEntrada_lineas.AEL_idtipoconfeccion, Lb11, True)
        ParamTx(TxPresentacion, AlbEntrada_lineas.AEL_idgensal, Lb48, True)
        ParamTx(TxTipoPalet, AlbEntrada_lineas.AEL_idtipopalet, Lb50, True)
        ParamTx(TxMarca, AlbEntrada_lineas.AEL_idmarca, Lb52, True)
        ParamTx(TxMarcaEti, AlbEntrada_lineas.AEL_IdMarcaEtiqueta, Lb6, False)
        ParamTx(TxMarcaMaterial, AlbEntrada_lineas.AEL_IdMarcaMaterial, Lb32, False)


        ParamTx(TxPalets, AlbEntrada_lineas.AEL_palets, Lb15, True)
        ParamTx(TxBxP, AlbEntrada_lineas.AEL_BultosxPalet, Lb2, True)
        ParamTx(TxKxB, AlbEntrada_lineas.AEL_KilosxBulto, Lb_16, False)
        ParamTx(TxKilosBrutos, AlbEntrada_lineas.AEL_kilosbrutos, Lb12, False)
        ParamTx(TxTaraManual, AlbEntrada_lineas.AEL_taramanual, Lb13, False)
        ParamTx(TxPxB, AlbEntrada_lineas.AEL_PiezasxBulto, Lb58, False)
        ParamTx(TxDato19, AlbEntrada_lineas.AEL_precio, Lb59, False)
        ParamTx(TxDato22, AlbEntrada_lineas.AEL_tipoprecio, Lb59, False, , , , "KBP")
        ParamTx(TxDato17, AlbEntrada_lineas.AEL_observaciones, Lb45, False)
        ParamTx(TxDato15, AlbEntrada_lineas.AEL_envasepropio, Lb55, False)
        ParamTx(TxDato25, AlbEntrada_lineas.AEL_materialpropio, Lb55, False)
        ParamTx(TxCalidad, AlbEntrada_lineas.AEL_Calidad, Lb30, False, , , , "ABCDE")


        LbKnetos.CL_ControlAsociado = TxTaraManual ' para que lo borre en en borralin

        LbTaraPalet.CL_ControlAsociado = TxTaraManual
        LbTaraEnvase.CL_ControlAsociado = TxTaraManual


        AsociarGrid(ClGrid1, TxLpedido, TxCalidad, AlbEntrada_lineas)

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        PropiedadesCamposGr(ClGrid1, "AEL_idlinea", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Genero", "Genero", True, 10)
        PropiedadesCamposGr(ClGrid1, "NombreGenero", "Nombre_Genero", True, 50)
        PropiedadesCamposGr(ClGrid1, "Envase", "Envase", True, 50)
        PropiedadesCamposGr(ClGrid1, "Bultos", "Bultos", True, 10, True, "#,##0", "{0:n0}")
        PropiedadesCamposGr(ClGrid1, "Kilos", "KilosNetos", True, 10, True, "#,##0.00", "{0:n2}")
        PropiedadesCamposGr(ClGrid1, "Partida", "Partida", True, 10)
        PropiedadesCamposGr(ClGrid1, "NombreEnvase", "NombreEnvase", False)
        PropiedadesCamposGr(ClGrid1, "NombreCategoria", "NombreCategoria", False)
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 10, False, "#,##0.000")
        PropiedadesCamposGr(ClGrid1, "KBP", "KBP", True, 10, False)



        AsociarControles(TxDato1, BtBuscaAlbaran, AlbEntrada.btBusca, EntidadFrm)
        AsociarControles(TxDato3, BtBuscaAgricultor, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb19)
        AsociarControles(TxDato18, BtBuscaMedianero, Medianeria.btBusca, Medianeria, Medianeria.MED_Nombre, LbNomMedianero)
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
        'AsociarControles(TxCategoria, BtBuscaCat, CategoriasEntrada.bTBuscaEnt, CategoriasEntrada, CategoriasEntrada.CAE_CategoriaCalibre, Lb24)

        AsociarControles(TxCategoria, BtBuscaCatTodas, CategoriasSalida.BtBuscaFamilias, CategoriasSalida, CategoriasSalida.CAS_CategoriaCalibre, Lb24)
        AsociarControles(TxCategoria, BtBuscaCat, CategoriasSalida.BtBuscaFamilias, CategoriasSalida, CategoriasSalida.CAS_CategoriaCalibre, Lb24)


        AsociarControles(TxMarca, BtBuscaMarca, Marcas.BtBuscaXconfec, Marcas, Marcas.MAR_Nombre, Lb51)
        AsociarControles(TxMarcaEti, BtBuscaMarcaEti, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, LbNomMarcaEti)
        AsociarControles(TxMarcaMaterial, BtBuscaMarcaMaterial, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, LbNomMarcaMat)


        'AsociarControles(TxConfeccion, BtBuscaConfec, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb10)
        AsociarControles(TxPresentacion, BtBuscaConfecSalidas, GenerosSalida.BtBuscaXConfecSalida, GenerosSalida, GenerosSalida.GES_Nombre, Lb47)
        AsociarControles(TxPresentacion, BtBuscaPresenta, GenerosSalida.BtBuscaXConfecSalida, GenerosSalida, GenerosSalida.GES_Nombre, Lb47)
        AsociarControles(TxPresentacion, BtBuscaPresenta, GenerosSalida.BtBuscaXconfec, GenerosSalida, GenerosSalida.GES_Nombre, Lb47)
        AsociarControles(TxTipoPalet, BtBusca2, Confecpalet.btBusca, Confecpalet, Confecpalet.CPA_Nombre, Lb49)

        AsociarControles(TxLocalizadorDAT, BtBuscaLocalizador, DAT_ENTRADAS.btBusca, DAT_ENTRADAS, DAT_ENTRADAS.DAT_Localizador, , "Buscador de localizadores")


        BtBuscaConfecSalidas.CL_Filtro = "TIPO='E'"



        tt.SetToolTip(BtNuevo, "Nuevo")

        tt.SetToolTip(LbBascu1, "Cambiar a báscula 1")
        tt.SetToolTip(LbBascu2, "Cambiar a báscula 2")
        tt.SetToolTip(LbBascu3, "Cambiar a báscula 3")
        tt.SetToolTip(LbBascu4, "Cambiar a báscula 4")

        tt.SetToolTip(BtDetallesAlbaran, "Ver detalles albarán")
        tt.SetToolTip(BtGenerarPalets, "Generar palets a partir de entradas directas")

        FiltroEntidad.Add(AlbEntrada.AEN_Campa.NombreCampo, MiMaletin.Ejercicio.ToString)
        FiltroEntidad.Add(AlbEntrada.AEN_IdCentro.NombreCampo, MiMaletin.IdCentro.ToString)

        BtBuscaAlbaran.CL_Filtro = "Directa = 'S' " + PventaUsuario.FiltroPventaGrid("PV", "AND")
        BtBuscaAlbaran.CL_xCentro = False
    End Sub


    Private Sub FrmEntradasConfeccionadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub



    Public Overrides Sub ControlClave()
        ' componemos la clave
        Dim i As Integer
        If TxDato1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = AlbEntrada.LeerAlb(CInt(LbCampa.Text), Mi_IdCentro, VaInt(TxDato1.Text))
            If i > 0 Then
                LbId.Text = i.ToString

                'If VaInt(AlbEntrada.AEN_idpuntoventa.Valor) <> VaInt(LbPuntoVenta.Text) Then
                '    MsgBox("No coincide el punto de venta")
                '    LbId.Text = ""
                '    TxDato1.Text = ""
                '    Exit Sub
                'End If

                If (AlbEntrada.AEN_EntradaConfeccionada.Valor & "").ToUpper.Trim <> "S" Then
                    MsgBox("La entrada no es directa")
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


        CalculaTaras(False)



        Idmuestreo = AlbEntrada_lineas.AEL_muestreo.Valor

        LbTaraPalet.Text = AlbEntrada_lineas.AEL_tarapalet.Valor
        LbTaraEnvase.Text = AlbEntrada_lineas.AEL_taraenvase.Valor
        'No actualizamos kilosnetos, porque no es edicion


        CargaKilosPalets(AlbEntrada_lineas.AEL_idlinea.Valor)

        pintacultivos()
        Button5.Enabled = True


        LbTBultos.Text = VaInt(AlbEntrada_lineas.AEL_bultos.Valor).ToString("#,###")
        LbTPiezas.Text = VaInt(AlbEntrada_lineas.AEL_piezas.Valor).ToString("#,###")
        LbKNetos.Text = VaDec(AlbEntrada_lineas.AEL_kilosnetos.Valor).ToString("#,##0")
        LbKilosSal.Text = VaDec(AlbEntrada_lineas.AEL_KilosCliente.Valor).ToString("#,##0")


        'If AlbEntrada_lineas.AEL_fechamuestreo.Valor <> "01/01/1900" Then
        '    LbMuestreado.Text = "MUESTREADO"
        '    LbMuestreado.Visible = True
        '    Grid.LineaBloqueada = True
        '    BloquearCamposLineas(True, Grid)
        'Else
        '    LbMuestreado.Visible = False
        '    Grid.LineaBloqueada = False
        '    ' If Modificando = True Then
        '    ' BloquearCamposLineas(False, Grid)
        '    'End If
        'End If


        LbIdCalidad.Text = AlbEntrada_lineas.AEL_idprograma.Valor

        MuestraProgramaCalidad()


    End Sub


    Private Sub GenerarMuestreoLineas(idalbaran As Integer)

        BorrarMuestreoLineas(idalbaran)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbEntrada_lineas.AEL_idlinea, "idlineaentrada")
        consulta.SelCampo(AlbEntrada_lineas.AEL_idgenero, "idgenero")
        consulta.SelCampo(AlbEntrada_lineas.AEL_idcategoria, "idcategoria")
        consulta.SelCampo(AlbEntrada_lineas.AEL_kilosnetos, "kilos")
        consulta.SelCampo(AlbEntrada_lineas.AEL_bultos, "Bultos")
        consulta.SelCampo(AlbEntrada_lineas.AEL_piezas, "piezas")
        consulta.SelCampo(AlbEntrada_lineas.AEL_precio, "precio")
        consulta.WheCampo(AlbEntrada_lineas.AEL_idalbaran, "=", idalbaran.ToString)

        Dim sql As String = consulta.SQL


        Dim dt As DataTable = AlbEntrada_lineas.MiConexion.ConsultaSQL(sql)

        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                For Each rw In dt.Rows

                    Dim AlbEntrada_LineasCla As New E_AlbEntrada_lineascla(Idusuario, cn)
                    Dim id As Integer = AlbEntrada_lineascla.MaxId

                    AlbEntrada_lineascla.ALC_id.Valor = id.ToString
                    AlbEntrada_lineascla.ALC_idalbaran.Valor = LbId.Text
                    AlbEntrada_lineascla.ALC_idgenero.Valor = rw("idgenero").ToString
                    AlbEntrada_lineascla.ALC_idcategoria.Valor = rw("idcategoria").ToString
                    AlbEntrada_lineascla.ALC_idlineaentrada.Valor = rw("idlineaentrada").ToString
                    AlbEntrada_lineascla.ALC_bultos.Valor = rw("bultos").ToString
                    AlbEntrada_lineascla.ALC_kilosnetos.Valor = rw("kilos").ToString
                    AlbEntrada_lineascla.ALC_piezas.Valor = rw("piezas").ToString
                    AlbEntrada_lineascla.ALC_precio.Valor = rw("precio").ToString
                    AlbEntrada_lineascla.Insertar()

                    If AlbEntrada_lineas.LeerId(rw("idlineaentrada").ToString) = True Then
                        AlbEntrada_lineas.AEL_fechamuestreo.Valor = TxDato6.Text
                        AlbEntrada_lineas.Actualizar()
                    End If

                Next
            End If
        End If
    End Sub

    Private Sub BorrarMuestreoLineas(idalbaran As Integer)
        Dim sql As String = "Delete from albentrada_lineascla where alc_idalbaran=" + idalbaran.ToString
        AlbEntrada_lineascla.MiConexion.OrdenSql(sql)

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()


        ChkNoAplicarTara.Checked = False


        PintaPuntoVenta(AlbEntrada.AEN_IdPuntoVenta.Valor)
        PintaCrecogida(AlbEntrada.AEN_IdRecogida.Valor)
        LbBascula.Text = AlbEntrada.AEN_idbascula.Valor
        LbCampa.Text = AlbEntrada.AEN_Campa.Valor
        CargaGastosAlbaran()
        ' llenar el grid
        CargaLineasGrid()

    End Sub


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


        AlbEntrada_lineas.AEL_idalbaran.Valor = LbId.Text
        AlbEntrada_lineas.AEL_kilosnetos.Valor = LbKNetos.Text
        AlbEntrada_lineas.AEL_albaran.Valor = TxDato1.Text
        AlbEntrada_lineas.AEL_taraenvase.Valor = LbTaraEnvase.Text
        AlbEntrada_lineas.AEL_tarapalet.Valor = LbTaraPalet.Text
        AlbEntrada_lineas.AEL_idcultivo.Valor = ""
        AlbEntrada_lineas.AEL_idprograma.Valor = ""


        AlbEntrada_lineas.AEL_bultos.Valor = VaInt(LbTBultos.Text).ToString
        AlbEntrada_lineas.AEL_piezas.Valor = VaInt(LbTPiezas.Text).ToString
        AlbEntrada_lineas.AEL_kilosnetos.Valor = VaDec(LbKNetos.Text).ToString
        AlbEntrada_lineas.AEL_KilosCliente.Valor = VaDec(LbKilosSal.Text).ToString


        Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)
        If ConfecPalet.LeerId(TxTipoPalet.Text) Then
            AlbEntrada_lineas.AEL_idpalet.Valor = ConfecPalet.CPA_IdPalet.Valor
        End If


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


        'Actualiza la fecha de inicio de recoleccion real del cultivo (si procede)
        ActualizaFechaInicioRecoleccionRealCultivo(TxCultivo.Text, TxDato6.Text)


        AlbEntrada_lineas.ActualizaPartida(LbCampa.Text, AlbEntrada_lineas.AEL_muestreo.Valor, AlbEntrada_lineas.AEL_idlinea.Valor)
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


        Dim frm As New FrmColorEtiqueta(AlbEntrada_lineas.AEL_Calidad.Valor)
        frm.ShowDialog()

    End Sub


    Private Sub ActualizaFechaPalets(Fecha As String)

        If VaDate(Fecha) > VaDate("") Then




            Dim sql As String = "SELECT AEL_IdLinea as IdLinea FROM AlbEntrada_Lineas WHERE AEL_IdAlbaran = " & LbId.Text
            Dim dtLineas As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dtLineas) Then

                For Each rowLinea As DataRow In dtLineas.Rows

                    Dim IdLineaEntradaConfeccionada As String = (rowLinea("IdLinea").ToString & "").Trim


                    sql = "SELECT DISTINCT PAL_IdPalet as IdPalet, PAL_Fecha as Fecha FROM Palets_Lineas LEFT JOIN Palets ON PAL_IdPalet = PLL_IdPalet WHERE PLL_IdLineaEntradaConfeccionada = " & IdLineaEntradaConfeccionada & " AND PAL_Fecha <> '" & Fecha & "'"
                    Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)

                    If Not IsNothing(dt) Then

                        Dim Palet As New E_palets(Idusuario, cn)

                        For Each row As DataRow In dt.Rows
                            Dim IdPalet As String = (row("IdPalet").ToString & "").Trim
                            If Palet.LeerId(IdPalet) Then
                                Palet.PAL_fecha.Valor = Fecha
                                Palet.Actualizar()
                            End If
                        Next

                    End If

                Next

            End If


        End If

    End Sub


    Public Overrides Sub DespuesdeAnular()

        BorrarMuestreoLineas(LbId.Text)
        MyBase.DespuesdeAnular()

    End Sub


    Public Overrides Sub DespuesdeGuardar()


        Dim IdVale As String = ""
        GrabaGastosAlbaran()

        AlbEntrada.CrearValeEnvasesComercio(LbId.Text)
        GenerarMuestreoLineas(VaInt(LbId.Text))

        Agro_GeneraAlbaranEntrada(VaInt(LbId.Text))


        If AlbEntrada.LeerId(LbId.Text) = True Then
            IdVale = AlbEntrada.AEN_IdValeEnvase.Valor
            AlbEntrada.Actualizar()
        End If



        Dim IdAlbaran As String = LbId.Text
        Dim localizador As String = TxLocalizadorDAT.Text

        MyBase.DespuesdeGuardar()



        If XtraMessageBox.Show("¿Desea imprimir el albarán?", "Albarán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            C1_ImprimirAlbaraEntrada(LbId.Text, TipoImpresion.ImpresoraSeleccionada, 2)
        End If




        If NuevoRegistro Then
            If ChkImprimirValeGastos.Checked Then C1_ImprimirValeGastosEntrada(LbId.Text, TipoImpresion.ImpresoraSeleccionada)
        Else
            If XtraMessageBox.Show("¿Desea imprimir el vale de gastos?", "Vale de gastos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'ImprimirValeGastosEntrada(LbId.Text, TipoImpresion.ImpresoraPorDefecto, "", "", "")
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

        ActualizaFechaPalets(TxDato6.Text)


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

        If Not dt Is Nothing Then
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


        Idmuestreo = 0
       


        LbPedido.Text = ""
        LbNomCli.Text = ""

        LbTBultos.Text = ""
        LbKilosSal.Text = ""
        LbKNetos.Text = ""
        LbTPiezas.Text = ""

        Lb10.Text = ""
        LbIdCalidad.Text = ""
        LbPcalidad.Text = ""


        TxCultivo.Siguiente = TxCategoria.Orden

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbCampa.Text = MiMaletin.Ejercicio.ToString
        PintaPuntoVenta(MiMaletin.IdPuntoVenta)
        PintaCrecogida(MiMaletin.IdCentroRecogida)
        PintaNbascula(Val(FnRight(Me.Text, 1)))

        Button5.Enabled = False

        BModificar.Enabled = True
        BAnular.Enabled = True
        BGuardar.Enabled = True

        LbBascula.Text = IdBasculaEntrada.ToString


        BtBuscaLocalizador.CL_Filtro = ""


    End Sub


    Private Sub CargaLineasGrid()
        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)
    End Sub


    Private Sub SqlGrid()


        Dim Centros As New E_centros(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
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
        CONSULTA.SelCampo(Confecenvase.CEV_Nombre, "Envase", AlbEntrada_lineas.AEL_idtipoconfeccion)
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_bultos, "Bultos")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_kilosnetos, "Kilos")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_precio, "Precio")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_tipoprecio, "KBP")
        CONSULTA.WheCampo(AlbEntrada_lineas.AEL_idalbaran, "=", id)
        sql = CONSULTA.SQL
        sql = sql + " order by AEL_Idlinea"

        ClGrid1.Consulta = sql

    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If LbId.Text = "" Then Exit Sub




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


    Private Sub TxConfeccion_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxConfeccion.KeyDown

        Select Case e.KeyCode
            Case Keys.F2
                Dim v As String

                If Not IsNothing(BtBuscaConfecSalidas) Then
                    v = BtBuscaConfecSalidas.Enlazar

                    If v <> "" Then
                        TxPresentacion.Text = v
                        TxPresentacion.Validar(False)
                        TxMarca.Focus()
                    End If
                End If

        End Select

    End Sub


    Private Sub TxConfeccion_Valida(ByVal edicion As Boolean) Handles TxConfeccion.Valida

        FiltroConfeccion()

        CalculaTaras(edicion)



        Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
        If ConfecEnvase.LeerId(TxConfeccion.Text) Then
            Lb10.Text = ConfecEnvase.CEV_Nombre.Valor
        End If


        If edicion = True Then

            Dim dt As DataTable = GenerosSalida.LeerGensalida(TxGenero.Text, TxConfeccion.Text)

            If Not dt Is Nothing Then
                If dt.Rows.Count = 1 Then
                    TxPresentacion.Text = dt.Rows(0)("GES_idgensal").ToString
                End If
            End If

        End If




    End Sub


    Private Sub CalculaTaras(edicion)


        Dim TaraEnvase As Decimal = 0
        Dim TaraPalet As Decimal = 0

        If Not ChkNoAplicarTara.Checked Then
            TaraEnvase = ObtenerTaraEnvase()
            TaraPalet = ObtenerTaraPalet()
        End If

        LbTaraEnvase.Text = TaraEnvase.ToString("#,##0.00")
        LbTaraPalet.Text = TaraPalet.ToString("#,##0.00")

        If edicion Then
            CalculaKilosNetos()
        End If


    End Sub


    Private Function ObtenerTaraEnvase() As Decimal

        Dim TaraEnvase As Decimal = 0

        Dim Confecenvase As New E_ConfecEnvase(Idusuario, cn)
        If Confecenvase.LeerId(TxConfeccion.Text) = True Then
            TaraEnvase = VaDec(Confecenvase.CEV_TotalTara.Valor)
        End If


        Return TaraEnvase

    End Function


    Private Function ObtenerTaraPalet() As Decimal

        Dim TotalTara As Decimal = 0


        If VaInt(TxTipoPalet.Text) > 0 Then

            Dim sql As String = "SELECT SUM(Tara) AS TotalTara" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & " SELECT CPA_IncrementoTara as Tara " & vbCrLf
            sql = sql & " FROM Confecpalet" & vbCrLf
            sql = sql & " WHERE CPA_IdConfec = " & TxTipoPalet.Text & vbCrLf
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT COALESCE(CPL_Cantidad,0) * COALESCE(ENV_TaraSalida,0) as Tara" & vbCrLf
            sql = sql & " FROM ConfecPaletLineas" & vbCrLf
            sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = CPL_IdMaterial" & vbCrLf
            sql = sql & " WHERE CPL_IdConfec = " & TxTipoPalet.Text & vbCrLf
            sql = sql & " ) AS T" & vbCrLf

            Dim dt As DataTable = Confecpalet.MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    TotalTara = Math.Round(VaDec(dt.Rows(0)("TotalTara")), 2)
                End If
            End If


        End If


        Return TotalTara

    End Function


    Private Sub TxDato3_Valida(ByVal edicion As Boolean) Handles TxDato3.Valida


        Dim nif As String = ""

        BtBuscaMedianero.CL_Filtro = "IdAgricultor=" + TxDato3.Text

        If Agricultores.LeerId(TxDato3.Text) = True Then

            nif = (Agricultores.AGR_Nif.Valor & "").Trim.Replace("-", "").Replace(".", "").Replace(" ", "")



            If edicion = True Then


                DatosGasto()

                If Agricultores.AGR_TextoMensaje1.Valor.Trim <> "" Or Agricultores.AGR_TextoMensaje2.Valor.Trim <> "" Then
                    MsgBox(Agricultores.AGR_TextoMensaje1.Valor & Chr(13) & Chr(10) + Agricultores.AGR_TextoMensaje2.Valor)
                End If

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
                    'If MsgBox("Desea cambiar actualizar el Centro de Recogida a """ & CentroRecogida.CER_Nombre.Valor.ToString & """", vbYesNo) = vbYes Then
                    If XtraMessageBox.Show("Desea cambiar el Centro de Recogida a """ & CentroRecogida.CER_Nombre.Valor.ToString & """", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        LbCrecogida.Text = Agricultores.AGR_idcrecogida.Valor.ToString
                        LbNomCr.Text = CentroRecogida.CER_Nombre.Valor.ToString
                    End If
                End If

            End If

        End If


        BtBuscaLocalizador.CL_Filtro = "Fecha = '" & TxDato6.Text & "' AND NIF = '" & nif & "'"


    End Sub


    Private Sub PintaPuntoVenta(ByVal PV As Integer)

        LbPuntoVenta.Text = PV.ToString
        If PuntoVenta.LeerId(LbPuntoVenta.Text) = True Then
            LbNomPv.Text = PuntoVenta.Nombre.Valor
            Mi_idcentro = PuntoVenta.IdCentro.Valor
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


    Private Sub TxGenero_Valida(ByVal edicion As Boolean) Handles TxGenero.Valida

        FiltroConfeccion()

        If TxLpedido.Text.Trim <> "" Then

            Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)
            If Pedidos_Lineas.LeerId(TxLpedido.Text) Then
                AsociarCategoriaComercial(Pedidos_Lineas.PEL_idcategoria.Valor)
            End If

        Else

            If Generos.LeerId(TxGenero.Text) = True Then
                If Subfamilias.LeerId(Generos.GEN_IdsubFamilia.Valor) = True Then
                    AsociarCategoriaFamilias(Subfamilias.SFA_idfamilia.Valor)
                End If
            End If

        End If


        If edicion Then

            If EsTecnicosNet() Then
                CompruebaCultivo_NET(edicion)
            Else
                CompruebaCultivo_VB6()
            End If

        End If


    End Sub


    Public Overrides Sub Guardar()

        AlbEntrada.AEN_TipoFCS.Valor = Agricultores.AGR_tipofcs.Valor
        AlbEntrada.AEN_EntradaConfeccionada.Valor = "S"

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


    Private Function BuscaCultivo(ByVal Idagricultor As String, ByVal idsubfamilia As String) As Integer

        ' -1 no tiene fincas
        ' 0 tiene + de 1 cultivo
        ' devuelve el id de cultivo cuando tiene un solo cultivo

        Dim ret As Integer = -1


        Return ret


    End Function


    Private Sub pintacultivos()

      

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
        Consulta.SelCampo(AgricultorGastos.AGG_IdAcreedor)
        Consulta.WheCampo(AgricultorGastos.AGG_IdAgricultor, "=", TxDato3.Text)
        Consulta.WheCampo(AgricultorGastos.AGG_PedirEntrada, "=", "S")

        Dim sql As String = Consulta.SQL
        sql = sql + " AND (AGG_idcentrorec=0 or AGG_Idcentrorec=" + LbCrecogida.Text + ") "
        sql = sql + " order by AGG_id"
        Dim dt As New DataTable
        dt = AgricultorGastos.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                i = i + 1
                Select Case i
                    Case 1
                        TxIdGasto1.Text = rw("AGG_idgasto").ToString
                        LbNomGasto1.Text = rw("gasto")
                        LbTipGasto1.Text = rw("tipo")
                        TxVgasto1.Text = rw("valor")
                        BtBuscaAcreedor1.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"

                        LbDto1.Text = rw("AGG_tipofc").ToString


                        TxAcreedor1.Text = rw("AGG_idacreedor").ToString
                        If VaInt(TxAcreedor1.Text) > 0 Then
                            TxAcreedor1.Validar(False)
                        Else
                            TxAcreedor1.Text = ""
                        End If
                        'BtBuscaGasto1.CL_Filtro = "ORIGEN='" + LbOrigenGasto1.Text + "'"
                    Case 2
                        TxIdGasto2.Text = rw("AGG_idgasto").ToString
                        LbNomGasto2.Text = rw("gasto")
                        LbTipGasto2.Text = rw("tipo")
                        TxVgasto2.Text = rw("valor")
                        BtBuscaAcreedor2.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"

                        LbDto2.Text = rw("AGG_tipofc").ToString

                        TxAcreedor2.Text = rw("AGG_idacreedor").ToString
                        If VaInt(TxAcreedor2.Text) > 0 Then
                            TxAcreedor2.Validar(False)
                        Else
                            TxAcreedor2.Text = ""

                        End If
                        'BtBuscaGasto2.CL_Filtro = "ORIGEN='" + LbOrigenGasto2.Text + "'"
                    Case 3
                        TxIdGasto3.Text = rw("AGG_idgasto").ToString
                        LbNomGasto3.Text = rw("gasto")
                        LbTipGasto3.Text = rw("tipo")
                        LbDto3.Text = rw("AGG_tipofc").ToString

                        TxVgasto3.Text = rw("valor")
                        BtBuscaAcreedor3.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"

                        TxAcreedor3.Text = rw("AGG_idacreedor").ToString
                        If VaInt(TxAcreedor3.Text) > 0 Then
                            TxAcreedor3.Validar(False)
                        Else
                            TxAcreedor3.Text = ""

                        End If

                        'BtBuscaGasto3.CL_Filtro = "ORIGEN='" + LbOrigenGasto3.Text + "'"
                    Case 4
                        TxIdGasto4.Text = rw("AGG_idgasto").ToString
                        LbNomGasto4.Text = rw("gasto")
                        LbTipGasto4.Text = rw("tipo")
                        TxVgasto4.Text = rw("valor")
                        BtBuscaAcreedor4.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"
                        LbDto4.Text = rw("AGG_tipofc").ToString

                        TxAcreedor4.Text = rw("AGG_idacreedor").ToString
                        If VaInt(TxAcreedor4.Text) > 0 Then
                            TxAcreedor4.Validar(False)
                        Else
                            TxAcreedor4.Text = ""
                        End If

                        'BtBuscaGasto4.CL_Filtro = "origen='" + LbOrigenGasto4.Text + "'"

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

                TxIdGasto4.Siguiente = TxLpedido.Orden
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
                    TxIdGasto3.Siguiente = TxLpedido.Orden
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

                If TxIdGasto3.Text = "" Then
                    TxIdGasto2.Siguiente = TxLpedido.Orden
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

                If TxIdGasto2.Text = "" Then
                    TxIdGasto1.Siguiente = TxLpedido.Orden
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
                                LbNomAcreedor1.Text = Acreedores.ACR_Nombre.Valor
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
            'ImprimirAlbaranMedianero(LbId.Text, False, True)
            C1_ImprimirAlbaraEntrada(LbId.Text, TipoImpresion.ImpresoraSeleccionada, 2)
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


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

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


    Private Sub CambiaBascula(ByVal nb As Integer)
        Dim s As Integer

        For Each formulario As Form In Me.MdiParent.MdiChildren
            If formulario.Text = "Entrada " + nb.ToString Then
                formulario.Focus()
                s = nb
            End If
        Next

        If s = 0 Then
            Dim frm As New FrmEntradasConfeccionadas
            frm.MdiParent = Me.MdiParent
            frm.Text = "Entrada " + nb.ToString
            frm.Show()
        End If

    End Sub


    'Private Sub TxDato12_Valida(ByVal edicion As Boolean) Handles TxDato12.Valida

    '    If edicion = True Then
    '        PintaTaraPalet()
    '    End If

    'End Sub


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
            If edicion = True Then


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

                    If Not Modificando Then

                        TxKxB.Text = VaDec(GenerosSalida.GES_KilosXBulto.Valor).ToString("#,##0.00")
                        TxKxB.Validar(True)
                        TxPxB.Text = VaInt(GenerosSalida.GES_PiezasXBulto.Valor).ToString

                        If VaInt(GenerosSalida.GES_idmarcaenvase.Valor) > 0 Then
                            TxMarca.Text = GenerosSalida.GES_idmarcaenvase.Valor
                            TxMarca.Validar(edicion)
                        End If
                        If VaInt(GenerosSalida.GES_idmarcamaterial.Valor) = 0 Then
                            TxMarcaMaterial.Text = GenerosSalida.GES_idmarcamaterial.Valor
                            TxMarcaMaterial.Validar(True)
                        End If
                        If VaInt(GenerosSalida.GES_idmarcaetiqueta.Valor) = 0 Then
                            TxMarcaEti.Text = GenerosSalida.GES_idmarcaetiqueta.Valor
                            TxMarcaEti.Validar(True)
                        End If

                    End If

                End If

            End If

        End If



        'If edicion = True Then
        '    PintaTaraEnvase()

        '    If edicion = True Then

        '        If VaInt(TxPresentacion.Text) > 0 Then

        '            If GenerosSalida.LeerId(TxPresentacion.Text) = True Then
        '                If VaInt(TxDato4.Text) <> VaInt(GenerosSalida.GES_IdGenero.Valor) Then
        '                    MsgBox("No coincide el genero")
        '                    TxPresentacion.MiError = True
        '                End If

        '                If GenerosSalida.GES_Activo.Valor = "N" Then
        '                    MsgBox("No activo")
        '                    TxPresentacion.MiError = True
        '                End If
        '                If Confecenvase.LeerId(GenerosSalida.GES_Idconfec.Valor) = True Then
        '                    If VaInt(Confecenvase.CEV_IdEnvase.Valor) <> TxConfeccion.Text Then
        '                        MsgBox("No coincide envase. " + Confecenvase.CEV_IdEnvase.Valor)
        '                        TxPresentacion.MiError = True
        '                    End If
        '                End If
        '            End If
        '        End If


        '    End If


        'End If

    End Sub


    Private Sub BtGenerarPalets_Click(sender As System.Object, e As System.EventArgs) Handles BtGenerarPalets.Click

        If VaInt(LbId.Text) > 0 Then
            Dim frm As New FrmCrearPalets(LbId.Text)
            frm.ShowDialog()
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


    Private Sub TxDato9_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxKilosBrutos.KeyDown
        If e.KeyCode = Keys.Up Then
            TxTipoPalet.Select()
            TxTipoPalet.Focus()
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
            'ImprimirValeGastosEntrada(LbId.Text, TipoImpresion.ImpresoraPorDefecto, "", "", "")
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

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        If VaInt(LbId.Text) = 0 Then Exit Sub

        If MsgBox("Desea generar el vale de envases", vbYesNo) = vbNo Then
            Exit Sub
        End If

        AlbEntrada.CrearValeEnvasesComercio(LbId.Text)
        MsgBox("Vale de envase generado")

    End Sub


    Private Sub TxDato18_Valida(edicion As Boolean) Handles TxDato18.Valida
        If edicion = True Then
            If TxDato18.Text <> "" Then
                If Medianeria.LeerId(TxDato18.Text) = False Then
                    MsgBox("Medianeria inexistente ")
                    TxDato18.MiError = True
                Else
                    If Medianeria.MED_IdAgricultor.Valor <> TxDato3.Text Then
                        MsgBox("Medianeria no coincide con proveedor")
                        TxDato18.MiError = True
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub TxDato22_Valida(edicion As Boolean) Handles TxDato22.Valida
        If TxDato22.Text <> "B" And TxDato22.Text <> "P" Then
            TxDato22.Text = "K"
        End If
    End Sub


    Private Sub TxDato25_Valida(edicion As Boolean) Handles TxDato25.Valida
        If edicion = True Then
            If TxDato25.Text <> "N" Then
                TxDato25.Text = "S"
            End If
        End If
    End Sub


    Private Sub btBuscaPedido_Click(sender As System.Object, e As System.EventArgs) Handles btBuscaPedido.Click
        EnlazarPedido()
    End Sub

    Private Sub TxLpedido_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxLpedido.EnabledChanged
        btBuscaPedido.Enabled = TxLpedido.Enabled
    End Sub

    Private Sub TxLpedido_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxLpedido.KeyDown
        If e.KeyCode = Keys.F2 Then
            EnlazarPedido()
        End If
    End Sub

    Private Sub EnlazarPedido()


        Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)
        Dim Pedidos As New E_Pedidos(Idusuario, cn)
        Dim CategoriasComercial As New E_CategoriasComercial(Idusuario, cn)



        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Pedidos_Lineas.PEL_idlinea, "IdLinea")
        consulta.SelCampo(Pedidos.PED_pedido, "Pedido", Pedidos_Lineas.PEL_idpedido)
        consulta.SelCampo(Pedidos.PED_fechasalida, "Fecha")
        consulta.SelCampo(Pedidos.PED_idcentro, "CE")
        consulta.SelCampo(Pedidos_Lineas.PEL_idgenero, "IdGenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Pedidos_Lineas.PEL_idgenero, Generos.GEN_IdGenero)
        consulta.SelCampo(Pedidos.PED_idcliente, "Codigo")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", Pedidos.PED_idcliente)
        consulta.SelCampo(Pedidos.PED_referencia, "Referencia")
        consulta.SelCampo(Generos.GEN_IdsubFamilia, "IdSubFamilia")
        consulta.SelCampo(Pedidos_Lineas.PEL_idgensal, "IdPresentacion")
        consulta.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", Pedidos_Lineas.PEL_idgensal)
        consulta.SelCampo(Confecenvase.CEV_IdEnvase, "IdEnvase", Pedidos_Lineas.PEL_idtipoconfeccion, Confecenvase.CEV_Idconfec)
        consulta.SelCampo(Envases.ENV_Nombre, "Envase", Confecenvase.CEV_IdEnvase, Envases.ENV_IdEnvase)
        consulta.SelCampo(Pedidos_Lineas.PEL_idcategoria, "IdCategoria")
        consulta.SelCampo(CategoriasComercial.CAC_Nombre, "Categoria", Pedidos_Lineas.PEL_idcategoria)
        consulta.SelCampo(Pedidos_Lineas.PEL_idmarca, "IdMarca")
        consulta.SelCampo(Marcas.MAR_Nombre, "Marca", Pedidos_Lineas.PEL_idmarca)
        consulta.SelCampo(Pedidos_Lineas.PEL_idtipopalet, "IdTipoPalet")
        consulta.SelCampo(Confecpalet.CPA_Nombre, "TipoPalet", Pedidos_Lineas.PEL_idtipopalet, Confecpalet.CPA_Idconfec)
        consulta.SelCampo(Pedidos_Lineas.PEL_calidad, "AB")


        Dim sql As String = consulta.SQL & vbCrLf
        sql = sql & " WHERE (SELECT COUNT(AEL_IdPedidoLinea) FROM AlbEntrada_Lineas WHERE AEL_IdPedidoLinea = PEL_IdLinea) = 0" & vbCrLf
        sql = sql & " ORDER BY PED_FechaPedido " & vbCrLf

        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)



        Dim FrBuscaAlb As New FrBuscaAlb("Lineas de pedidos")
        Dim BtBusca As BtBusca = Pedidos.btBusca

        Dim DeFecha As String = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        Dim HastaFecha As String = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")

        Dim DcParams As New Dictionary(Of String, Parametros)
        DcParams("IdLinea") = New Parametros("IdLinea", False, "", -1)
        DcParams("IdGenero") = New Parametros("IdGenero", False, "", -1)
        DcParams("Codigo") = New Parametros("Codigo", False, "", -1)
        DcParams("IdSubFamilia") = New Parametros("IdSubFamilia", False, "", -1)
        DcParams("IdPresentacion") = New Parametros("IdPresentacion", False, "", -1)
        DcParams("IdEnvase") = New Parametros("IdEnvase", False, "", -1)
        DcParams("IdCategoria") = New Parametros("IdCategoria", False, "", -1)
        DcParams("IdMarca") = New Parametros("IdMarca", False, "", -1)
        DcParams("IdTipoPalet") = New Parametros("IdTipoPalet", False, "", -1)




        FrBuscaAlb.InitCodigo(sql, Pedidos_Lineas, Clientes.CLI_Codigo, Clientes.CLI_Nombre, DeFecha, HastaFecha, DcParams, Nothing)
        FrBuscaAlb.ShowDialog()

        If Not BuscarRow Is Nothing Then

            Try
                TxLpedido.Text = BuscarRow("IdLinea").ToString

            Catch ex As Exception
                TxLpedido.Text = ""
            End Try

            TxLpedido.Validar(True)


        End If



    End Sub


    Private Sub TxLpedido_Valida(edicion As System.Boolean) Handles TxLpedido.Valida


        LbPedido.Text = ""
        LbNomCli.Text = ""



        If VaInt(TxLpedido.Text) > 0 Then


            Dim sql As String = "SELECT PED_Pedido as Pedido, CLI_Nombre as Nombre " & vbCrLf
            sql = sql & " FROM Pedidos_Lineas" & vbCrLf
            sql = sql & " LEFT JOIN Pedidos ON PEL_IdPedido = PED_IdPedido" & vbCrLf
            sql = sql & " LEFT JOIN Clientes ON CLI_IdCliente = PED_IdCliente" & vbCrLf
            sql = sql & " WHERE PEL_IdLinea = " & TxLpedido.Text & vbCrLf

            Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    'Datos del cliente
                    LbPedido.Text = dt.Rows(0)("Pedido").ToString
                    LbNomCli.Text = dt.Rows(0)("Nombre").ToString


                    If TxLpedido.HaCambiado Then

                        'Datos de la entrada
                        Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)
                        If Pedidos_Lineas.LeerId(TxLpedido.Text) Then

                            TxTipoPalet.Text = Pedidos_Lineas.PEL_idtipopalet.Valor
                            TxGenero.Text = Pedidos_Lineas.PEL_idgenero.Valor
                            TxConfeccion.Text = Pedidos_Lineas.PEL_idtipoconfeccion.Valor
                            TxPresentacion.Text = Pedidos_Lineas.PEL_idgensal.Valor
                            TxMarca.Text = Pedidos_Lineas.PEL_idmarca.Valor
                            TxMarcaEti.Text = Pedidos_Lineas.PEL_idmarcaetiqueta.Valor
                            TxMarcaMaterial.Text = Pedidos_Lineas.PEL_idmarcamaterial.Valor
                            TxBxP.Text = VaInt(Pedidos_Lineas.PEL_bultospalet.Valor).ToString("#,##0")
                            TxKxB.Text = VaDec(Pedidos_Lineas.PEL_kilosbulto.Valor).ToString("#,##0.00")
                            TxPxB.Text = VaInt(Pedidos_Lineas.PEL_piezasbulto.Valor).ToString("#,##0")


                            'Categoria
                            Dim IdCatComercial As String = Pedidos_Lineas.PEL_idcategoria.Valor & ""
                            If VaInt(IdCatComercial) > 0 Then

                                sql = "SELECT CSC_IdCatSalida FROM CatSalidaComercial WHERE CSC_IdCatComercial = " & IdCatComercial
                                Dim dtc As DataTable = Pedidos_Lineas.MiConexion.ConsultaSQL(sql)
                                If Not dtc Is Nothing Then
                                    If dtc.Rows.Count = 1 Then
                                        TxCategoria.Text = dtc.Rows(0)("CSC_IdCatSalida").ToString
                                    ElseIf dtc.Rows.Count > 1 Then
                                        AsociarControles(TxCategoria, BtBuscaCat, CategoriasSalida.BtBuscaComercial, CategoriasSalida, CategoriasSalida.CAS_CategoriaCalibre, Lb25)
                                        BtBuscaCat.CL_Filtro = "IdCatComercial = " & IdCatComercial
                                    End If
                                End If

                            End If


                            TxTipoPalet.Validar(edicion)
                            TxGenero.Validar(edicion)
                            TxCategoria.Validar(edicion)
                            TxConfeccion.Validar(edicion)
                            TxPresentacion.Validar(edicion)
                            TxMarca.Validar(edicion)
                            TxMarcaEti.Validar(edicion)
                            TxMarcaMaterial.Validar(edicion)
                            TxBxP.Validar(edicion)
                            TxKxB.Validar(edicion)
                            TxPxB.Validar(edicion)



                        End If

                    End If


                End If

            End If


        End If


    End Sub


    Private Sub FiltroConfeccion()

        If TxGenero.Text <> "" Then

            BtBuscaConfecSalidas.CL_Filtro = "idgenero=" + TxGenero.Text
            BtBuscaPresenta.CL_Filtro = "idgenero=" + TxGenero.Text

            If TxCategoria.Text.Trim <> "" Then

                BtBuscaConfecSalidas.CL_Filtro = "idgenero=" + TxGenero.Text + " AND IdCatSalida =" + TxCategoria.Text
                BtBuscaPresenta.CL_Filtro = "idgenero=" + TxGenero.Text + " AND IdCatSalida =" + TxCategoria.Text

                If TxConfeccion.Text <> "" Then
                    BtBuscaPresenta.CL_Filtro = "idgenero=" + TxGenero.Text + " AND IdCatSalida=" + TxCategoria.Text + " and idconfec=" + TxConfeccion.Text
                End If

            End If

        End If

    End Sub


    Private Sub AsociarCategoriaFamilias(IdFamilia As String)

        AsociarControles(TxCategoria, BtBuscaCat, CategoriasSalida.BtBuscaFamilias, CategoriasSalida, CategoriasSalida.CAS_CategoriaCalibre, Lb24)
        BtBuscaCat.CL_Filtro = "Idfamilia = " & IdFamilia

        AsociarControles(TxCategoria, BtBuscaCatTodas, CategoriasSalida.BtBuscaFamilias, CategoriasSalida, CategoriasSalida.CAS_CategoriaCalibre, Lb24)
        BtBuscaCatTodas.CL_Filtro = "Idfamilia = " & IdFamilia

    End Sub


    Private Sub AsociarCategoriaComercial(IdCatComercial As String)

        AsociarControles(TxCategoria, BtBuscaCat, CategoriasSalida.BtBuscaComercial, CategoriasSalida, CategoriasSalida.CAS_CategoriaCalibre, Lb24)
        BtBuscaCat.CL_Filtro = "IdComercial = " & IdCatComercial

        BtBuscaCat.Image = NetAgro.My.Resources.Lupa16_

    End Sub



    Private Sub TxCategoria_Valida(edicion As System.Boolean) Handles TxCategoria.Valida

        FiltroConfeccion()

    End Sub


    Private Sub TxTipoPalet_Valida(edicion As Boolean) Handles TxTipoPalet.Valida

        CalculaTaras(edicion)

    End Sub


    Private Sub TxCalidad_Valida(edicion As System.Boolean) Handles TxCalidad.Valida

        If edicion Then
            If TxCalidad.Text = "" Then
                TxCalidad.Text = "B"
            End If
        End If

    End Sub



#Region "Calculo bultos y Kilos"

    Private Sub TxPalets_Valida(edicion As System.Boolean) Handles TxPalets.Valida
        If edicion Then
            CalculaBultos()
        End If
    End Sub

    Private Sub TxBxP_Valida(edicion As System.Boolean) Handles TxBxP.Valida
        If edicion Then
            CalculaBultos()
        End If
    End Sub

    Private Sub CalculaBultos()

        'Suponemos edicion = true 

        Dim Bultos As Integer = VaInt(TxPalets.Text) * VaInt(TxBxP.Text)
        LbTBultos.Text = Bultos.ToString

        CalculaKilosBrutos()
        CalculaKilosCliente()
        CalculaPiezas()

    End Sub

    Private Sub TxKxB_TextChanged(sender As Object, e As System.EventArgs) Handles TxKxB.TextChanged
        Dim a As String = ""
    End Sub

    Private Sub TxKxB_Valida(edicion As System.Boolean) Handles TxKxB.Valida
        If edicion Then
            CalculaKilosBrutos()
            CalculaKilosCliente()
        End If
    End Sub

    Private Sub CalculaKilosBrutos()

        'Suponemos edicion = true 
        If VaDec(TxKilosBrutos.Text) = 0 Then ' SOLO CUANDO SON=0
            Dim TaraManual As Decimal = VaDec(TxTaraManual.Text)
            Dim Bultos As Integer = VaInt(LbTBultos.Text)
            Dim Palets As Integer = VaInt(TxPalets.Text)
            Dim TotalTaraEnvase As Decimal = VaDec(LbTaraEnvase.Text) * Bultos
            Dim TotalTaraPalet As Decimal = VaDec(LbTaraPalet.Text) * Palets


            Dim KilosBrutos As Decimal = VaInt(LbTBultos.Text) * VaDec(TxKxB.Text)
            'TODO: + la tara
            KilosBrutos = KilosBrutos + TotalTaraEnvase + TotalTaraPalet + TaraManual
            TxKilosBrutos.Text = KilosBrutos.ToString("#,##0")
            TxKilosBrutos.Validar(True)

        End If

    End Sub

    Private Sub LbKNetos_TextChanged(sender As System.Object, e As System.EventArgs) Handles LbKNetos.TextChanged
        CalculaKilosCliente()
    End Sub

    Private Sub CalculaKilosNetos()

        Dim KilosBrutos As Decimal = VaDec(TxKilosBrutos.Text)
        Dim Bultos As Integer = VaInt(LbTBultos.Text)
        Dim Palets As Integer = VaInt(TxPalets.Text)
        Dim TaraManual As Decimal = VaDec(TxTaraManual.Text)

        Dim TotalTaraEnvase As Decimal = VaDec(LbTaraEnvase.Text) * Bultos
        Dim TotalTaraPalet As Decimal = VaDec(LbTaraPalet.Text) * Palets

        Dim KilosNetos As Decimal = KilosBrutos - TotalTaraEnvase - TotalTaraPalet - TaraManual
        LbKNetos.Text = KilosNetos.ToString("#,##0")


        CalculaKilosCliente()

    End Sub

    Private Sub CalculaKilosCliente()

        'Primero hay que calcular KilosNetos
        If VaDec(TxKxB.Text) = 0 Then
            LbKilosSal.Text = LbKNetos.Text
        Else
            Dim KilosCliente As Decimal = VaInt(LbTBultos.Text) * VaDec(TxKxB.Text)
            LbKilosSal.Text = KilosCliente.ToString("#,##0")
        End If

    End Sub

    Private Sub TxKilosBrutos_Valida(edicion As System.Boolean) Handles TxKilosBrutos.Valida
        If edicion Then
            CalculaKilosNetos()
        End If
    End Sub

    Private Sub TxTaraManual_Valida(edicion As System.Boolean) Handles TxTaraManual.Valida
        If edicion Then
            CalculaKilosBrutos()
            CalculaKilosNetos()
        End If
    End Sub

    Private Sub TxPxB_Valida(edicion As System.Boolean) Handles TxPxB.Valida
        If edicion Then
            CalculaPiezas()
        End If
    End Sub

    Private Sub CalculaPiezas()
        Dim Piezas As Decimal = VaInt(LbTBultos.Text) * VaInt(TxPxB.Text)
        LbTPiezas.Text = Piezas.ToString("#,##0")
    End Sub


#End Region


    Private Sub ChkNoAplicarTara_Click(sender As System.Object, e As System.EventArgs) Handles ChkNoAplicarTara.Click
        CalculaTaras(True)
    End Sub



    Private Sub TxGenero_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxGenero.EnabledChanged
        ChkNoAplicarTara.Enabled = TxGenero.Enabled
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


    Private Sub btGenerarMuestreo_Click(sender As System.Object, e As System.EventArgs) Handles btGenerarMuestreo.Click
        If VaInt(LbId.Text) > 0 Then
            GenerarMuestreoLineas(VaInt(LbId.Text))
            MsgBox("Terminado!")
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

        BtBuscaLocalizador.CL_Filtro = "Fecha = '" & TxDato6.Text & "' AND NIF = '" & nif & "'"

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


    Private Sub BtBuscaCultivo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtBuscaCultivo.Click
        BuscaCultivos()
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

            'Dim sql As String = "SELECT BCU_IdBloqueo as IdBloqueo" & vbCrLf
            Dim sql As String = "SELECT BCU_IdBloqueo as IdBloqueo, BCU_DeFecha as DesdeFecha, BCU_AFecha as HastaFecha, BCU_DeHora as DesdeHora, BCU_AHora as HastaHora" & vbCrLf
            sql = sql & " FROM BloqueoCultivos" & vbCrLf
            sql = sql & " WHERE BCU_IdCultivo = " & IdCultivo & vbCrLf
            sql = sql & " AND '" & FechaHoy & "' BETWEEN BCU_DeFecha AND BCU_AFecha" & vbCrLf
            'sql = sql & " AND '" & HoraHoy & "' BETWEEN BCU_DeHora AND BCU_AHora" & vbCrLf

            Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
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
                If VaInt(LbIdCalidad.Text) = 0 Then
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


    Private Sub MuestraProgramaCalidad()

        If VaInt(LbIdCalidad.Text) > 0 Then
            Dim ProgramaCalidadTecnicos As New E_ProgramaCalidadTecnicos(Idusuario, cn)
            If ProgramaCalidadTecnicos.LeerId(LbIdCalidad.Text) Then
                LbPcalidad.Text = ProgramaCalidadTecnicos.PCT_Nombre.Valor
            End If
        End If


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

        End If



    End Sub



End Class