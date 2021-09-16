Imports DevExpress.XtraEditors
Imports System.Drawing


Public Class FrmPaletsComer
    Inherits FrMantenimiento


    Dim err As New Errores

    Dim palets As New E_palets(Idusuario, cn)
    Dim palets_lineas As New E_palets_lineas(Idusuario, cn)
    Dim palets_traza As New E_palets_traza(Idusuario, cn)
    Dim albsalida_palets As New E_albsalida_palets(Idusuario, cn)
    Dim albsalida As New E_AlbSalida(Idusuario, cn)


    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim CatSalidaComercial As New E_CatSalidaComercial(Idusuario, cn)
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Confecpalet As New E_ConfecPalet(Idusuario, cn)
    Dim Confecenvase As New E_ConfecEnvase(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim FamiliasCategorias As New E_FamiliasCategorias(Idusuario, cn)
    Dim Subfamilias As New E_Subfamilias(Idusuario, cn)

    Dim Lotes As New E_Lotes(Idusuario, cn)
    Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)

    Dim EnvasesPalets As New E_EnvasesPalets(Idusuario, cn)

    Dim Pedidos As New E_Pedidos(Idusuario, cn)
    Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)
    Dim CategoriasComercial As New E_CategoriasComercial(Idusuario, cn)
    Dim PventaUsuario As New E_PventaUsuario(Idusuario, cn)


    Dim _idlineapedido As String = ""
    Dim _IdCategoriaPedido As String = ""
    Dim _categoriacomercial As String

    Dim _bPesoFijo As Boolean = False



    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim MiCentro As String
    'Dim MiCampa As String
    Dim idpartida As String
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim IdLineaGrid As String = ""
    Dim IdCargaAlb As String
    Dim _Cbarras As Boolean
    Dim _Idlinea As String
    Dim _IdTarea As String
    Dim _salirdespuesdeguardar As Boolean

    Dim _bVieneDeCargaPalets As Boolean = False




    Private Sub ParametrosFrm()

        EntidadFrm = palets


        Dim lc As New List(Of Object)
        ListaControles = lc

        LbPuntoVenta.CL_ControlAsociado = TxNuPalet
        LbNomPv.CL_ControlAsociado = TxNuPalet
        CampoClave = 0 ' ultimo campo de la clave

        ParamTx(TxNuPalet, palets.PAL_palet, Lb_1, True)
        TxNuPalet.Autonumerico = True
        ParamTx(TxFecha, palets.PAL_fecha, Lb_2, True)
        ParamTx(TxTipoPalet, palets.PAL_idtipopalet, Lb_3, True, Cdatos.TiposCampo.Cadena, 0, 40)
        ParamTx(TxLote, palets.PAL_Lote, LbLote)
        ParamTx(TxDato_4, palets.PAL_tarapalet, Lb_4, False)
        ParamTx(TxEnvPropio, palets.PAL_envasepropio, Lb_5, False)
        ParamTx(TxMatPropio, palets.PAL_materialpropio, Lb_5, False)




        'ParamTx(LbIdPedidoLinea, palets_lineas.PLL_idpedidolinea, Lb1, False)
        ParamTx(TxGenero, palets_lineas.PLL_idgenero, Lb_10, True)
        ParamTx(TxCategoria, palets_lineas.PLL_idcategoria, Lb_12, True)
        ParamTx(TxNomCategoria, palets_lineas.PLL_categoria, Lb_12, True)
        ParamTx(TxConfeccion, palets_lineas.PLL_idtipoconfeccion, Lb_11, True)
        ParamTx(TxPresentacion, palets_lineas.PLL_idgensal, Lb9, True)
        ParamTx(TxCliente, palets_lineas.PLL_IdCliente, LbCliente)
        ParamTx(TxMarca, palets_lineas.PLL_idmarca, Lb_13, True)
        ParamTx(TxMarcaEti, palets_lineas.PLL_idmarcaeti, LbMarcaEti, False)
        ParamTx(TxMarcaMaterial, palets_lineas.PLL_idmarcamat, LbMarcaMaterial, False)
        ParamTx(TxCalidad, palets_lineas.PLL_calidad, Lb15, False, , , , "ABCDE")
        ParamTx(TxControlado, palets_lineas.PLL_Controlado, LbControlado, , , , , "SN")

        ParamTx(TxBultos, palets_lineas.PLL_bultos, Lb_14, True)
        ParamTx(TxKxB, palets_lineas.PLL_kilosxbulto, Lb_16, False)
        ParamTx(TxKilosBr, palets_lineas.PLL_kilosbrutos, Lb_17, False)
        ParamTx(TxPxB, palets_lineas.PLL_piezasxbulto, Lb_18, False)



        'Panel
        ParamTx(TxCampa1, Nothing, Lb16, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789")
        ParamTx(TxPar1, Nothing, Lb_30, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789PA.")
        ParamTx(TxLote1, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca1, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul1, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxCampa2, Nothing, Lb16, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789")
        ParamTx(TxPar2, Nothing, Lb_30, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789PA.")
        ParamTx(TxLote2, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca2, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul2, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxCampa3, Nothing, Lb16, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789")
        ParamTx(TxPar3, Nothing, Lb_30, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789PA.")
        ParamTx(TxLote3, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca3, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul3, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxCampa4, Nothing, Lb16, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789")
        ParamTx(TxPar4, Nothing, Lb_30, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789PA.")
        ParamTx(TxLote4, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca4, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul4, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxCampa5, Nothing, Lb16, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789")
        ParamTx(TxPar5, Nothing, Lb_30, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789PA.")
        ParamTx(TxLote5, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca5, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul5, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxCampa6, Nothing, Lb16, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789")
        ParamTx(TxPar6, Nothing, Lb_30, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789PA.")
        ParamTx(TxLote6, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca6, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul6, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxCampa7, Nothing, Lb16, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789")
        ParamTx(TxPar7, Nothing, Lb_30, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789PA.")
        ParamTx(TxLote7, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca7, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul7, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxCampa8, Nothing, Lb16, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789")
        ParamTx(TxPar8, Nothing, Lb_30, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789PA.")
        ParamTx(TxLote8, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca8, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul8, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxCampa9, Nothing, Lb16, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789")
        ParamTx(TxPar9, Nothing, Lb_30, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789PA.")
        ParamTx(TxLote9, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca9, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul9, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxCampa10, Nothing, Lb16, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789")
        ParamTx(TxPar10, Nothing, Lb_30, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789PA.")
        ParamTx(TxLote10, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca10, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul10, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxCampa11, Nothing, Lb16, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789")
        ParamTx(TxPar11, Nothing, Lb_30, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789PA.")
        ParamTx(TxLote11, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca11, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul11, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxCampa12, Nothing, Lb16, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789")
        ParamTx(TxPar12, Nothing, Lb_30, , Cdatos.TiposCampo.EnteroPositivo, , , "0123456789PA.")
        ParamTx(TxLote12, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca12, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul12, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)


        'observaciones
        ParamTx(TxObserva, palets_lineas.PLL_observaciones, Lb_12, False)

        AsociarControles(TxCliente, BtBuscaCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNom_Cliente)
        AsociarControles(TxNuPalet, BtBuscaAlbaran, palets.btBusca, palets)

        AsociarGrid(ClGrid1, TxGenero, TxObserva, palets_lineas)

        PropiedadesCamposGr(ClGrid1, "PLL_idlinea", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 10)
        PropiedadesCamposGr(ClGrid1, "Producto", "Producto", True, 50)
        PropiedadesCamposGr(ClGrid1, "Confeccion", "Confeccion", True, 50)
        PropiedadesCamposGr(ClGrid1, "Categoria", "Categoria", True, 30)
        PropiedadesCamposGr(ClGrid1, "Marca", "Marca", True, 30)
        PropiedadesCamposGr(ClGrid1, "Bultos", "Bultos", True, 10, True)
        PropiedadesCamposGr(ClGrid1, "Kilos", "Kilos", True, 10, True)
        PropiedadesCamposGr(ClGrid1, "EntConf", "EntConf", True, 15)




        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False





        AsociarControles(TxTipoPalet, BtBuscaTipopalet, Confecpalet.btBusca, Confecpalet, Confecpalet.CPA_Nombre, LbNomPalet)

        AsociarControles(TxGenero, BtBuscaGenero, Generos.btBusca, Generos, Generos.GEN_NombreGenero, Lb4)
        '        AsociarControles(TxConfeccion, BtBuscaConfec, GenerosSalida.btBusca, Confecenvase, Confecenvase.CEV_Nombre, Lb24)
        '        AsociarControles(TxPresentacion, BtBusca2, GenerosSalida.BtBuscaXconfec, GenerosSalida, GenerosSalida.GES_Nombre, Lb5)

        AsociarControles(TxPresentacion, BtBuscaConfecSalidas, GenerosSalida.BtBuscaXConfecSalida, GenerosSalida, GenerosSalida.GES_Nombre, Lb5)
        AsociarControles(TxPresentacion, BtBuscaPresenta, GenerosSalida.BtBuscaXConfecSalida, GenerosSalida, GenerosSalida.GES_Nombre, Lb5)


        AsociarControles(TxCategoria, BtBuscaCatTodas, CategoriasSalida.BtBuscaFamilias, CategoriasSalida, CategoriasSalida.CAS_CategoriaCalibre, Lb10)
        AsociarControles(TxCategoria, BtBuscaCat, CategoriasSalida.BtBuscaFamilias, CategoriasSalida, CategoriasSalida.CAS_CategoriaCalibre, Lb10)


        AsociarControles(TxMarca, BtBuscaMarca, Marcas.BtBuscaXconfec, Marcas, Marcas.MAR_Nombre, Lb31)
        AsociarControles(TxMarcaEti, BtBuscaMarcaEti, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, LbNomMarcaEti)
        AsociarControles(TxMarcaMaterial, BtBuscaMarcaMaterial, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, LbNomMarcaMat)


        ' BotonesAvance1.Mientidad = EntidadFrm
        ' BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        ' BotonesAvance1.Formulario = Me

        'MiCampa = MiMaletin.Ejercicio


        tt.SetToolTip(BtNuevo, "Nuevo")

        FiltroEntidad.Add(palets.PAL_campa.NombreCampo, MiMaletin.Ejercicio.ToString)
        FiltroEntidad.Add(palets.PAL_idcentro.NombreCampo, MiMaletin.IdCentro.ToString)
        BtBuscaAlbaran.CL_Filtro = pventausuario.FiltroPventaGrid("PV", "")
        BtBuscaAlbaran.CL_xCentro = False


        'TxBul1.Siguiente = TxPar2.Orden
        'TxBul2.Siguiente = TxPar3.Orden
        'TxBul3.Siguiente = TxPar4.Orden
        'TxBul4.Siguiente = TxPar5.Orden
        'TxBul5.Siguiente = TxPar6.Orden
        'TxBul6.Siguiente = TxPar7.Orden
        'TxBul7.Siguiente = TxPar8.Orden
        'TxBul8.Siguiente = TxPar9.Orden
        'TxBul9.Siguiente = TxPar10.Orden
        'TxBul10.Siguiente = TxPar11.Orden
        'TxBul11.Siguiente = TxPar12.Orden



    End Sub


    Protected Overrides Function CumpleFiltro(Mostrar As Boolean, TipoOperacion As String) As Boolean

        If Not EntidadFrm Is Nothing Then

            For Each campo In EntidadFrm.MiListadeCampos

                If FiltroEntidad.ContainsKey(campo.NombreCampo) = True Then

                    If TipoOperacion = "MODIFICAR" And campo.NombreCampo.ToUpper = "PAL_IDCENTRO" Then

                        'TODO: Revisar la última condición con Miguel (Jose Jibaja: 07/05/2021)

                        If campo.Valor <> FiltroEntidad(campo.NombreCampo) And CType(EntidadFrm, E_palets).PAL_idpvsituacion.Valor <> FiltroEntidad(campo.NombreCampo) And
                            MiMaletin.IdPuntoVenta.ToString <> CType(EntidadFrm, E_palets).PAL_idpvsituacion.Valor Then
                            If Mostrar = True Then
                                MsgBox("Registro no modificable. " + campo.NombreCampo + " incorrecto ")
                            End If
                            Return False
                        End If

                    ElseIf campo.Valor <> FiltroEntidad(campo.NombreCampo) Then
                        If Mostrar = True Then
                            MsgBox("Registro no modificable. " + campo.NombreCampo + " incorrecto ")
                        End If
                        Return False
                    End If

                End If

            Next

            Return True
        Else
            Return True
        End If

    End Function


    'Public Overrides Sub InicioFrm()

    '    Dim TextoError As String = ""
    '    OperFrm = PermisoFormulario(Idusuario, Me.Name, TextoError)
    '    If TextoError.Trim <> "" Then
    '        MsgBox(TextoError)
    '    End If
    '    Dim FBOTON As New Font(BGuardar.Font.FontFamily, BGuardar.Font.Size, FontStyle.Strikeout)
    '    If InStr(OperFrm, PermisosFormularios.Alta) = 0 Then
    '        BGuardar.Font = FBOTON
    '    End If
    '    If InStr(OperFrm, PermisosFormularios.Modificaciones) = 0 Then
    '        BModificar.Font = FBOTON
    '    End If
    '    If InStr(OperFrm, PermisosFormularios.Bajas) = 0 Then
    '        BAnular.Font = FBOTON
    '    End If

    'End Sub


    Public Sub InitAlb(ByVal Idalb As String)

        IdCargaAlb = Idalb


        'Se llama sólo desde Carga Palets, debo dejar modificar el lote
        _bVieneDeCargaPalets = True


        'Si el formulario viene de carga de palets, ya está mostrando directamente el palet que hemos selccionado desde la carga
        'Sólo nos permite modificar este albarán y cuando salgamos del palet no permitirá dar de alta ni editar ningún otro, sino que volverá directamente a la carga de palets
        'En este caso en particular podemos quitarle el filtro de campaña para que nos permita editar el palet que se muestra de forma modal desde la carga de palets
        If FiltroEntidad.ContainsKey(palets.PAL_campa.NombreCampo) Then
            FiltroEntidad.Remove(palets.PAL_campa.NombreCampo)
        End If

    End Sub


    Private Sub FrmPalets_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BTaux1.Visible = True
        BTaux1.Text = "Imprimir ticket"
        BTaux1.Width = 100
        BTaux1.Image = NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32

        PanelTrazabilidad.Top = 4
        PanelTrazabilidad.Left = 3


        BtAux2.Text = "Introducir lote"
        BtAux2.Width = 110
        BtAux2.Image = NetAgro.My.Resources.Resources.arrow_up_blue
        BtAux2.Visible = True


        BtAux3.Text = "+ Info"
        BtAux3.Image = NetAgro.My.Resources.Action_button_info_16x16_32
        BtAux3.Visible = True



        'No envar la pulsación de F12 al formulario de mantenimiento
        Dim lstTx As New List(Of TxDato)

        lstTx.Add(TxCampa1)
        lstTx.Add(TxCampa2)
        lstTx.Add(TxCampa3)
        lstTx.Add(TxCampa4)
        lstTx.Add(TxCampa5)
        lstTx.Add(TxCampa6)
        lstTx.Add(TxCampa7)
        lstTx.Add(TxCampa8)
        lstTx.Add(TxCampa9)
        lstTx.Add(TxCampa10)
        lstTx.Add(TxCampa11)
        lstTx.Add(TxCampa12)

        lstTx.Add(TxPar1)
        lstTx.Add(TxPar2)
        lstTx.Add(TxPar3)
        lstTx.Add(TxPar4)
        lstTx.Add(TxPar5)
        lstTx.Add(TxPar6)
        lstTx.Add(TxPar7)
        lstTx.Add(TxPar8)
        lstTx.Add(TxPar9)
        lstTx.Add(TxPar10)
        lstTx.Add(TxPar11)
        lstTx.Add(TxPar12)

        lstTx.Add(TxLote1)
        lstTx.Add(TxLote2)
        lstTx.Add(TxLote3)
        lstTx.Add(TxLote4)
        lstTx.Add(TxLote5)
        lstTx.Add(TxLote6)
        lstTx.Add(TxLote7)
        lstTx.Add(TxLote8)
        lstTx.Add(TxLote9)
        lstTx.Add(TxLote10)
        lstTx.Add(TxLote11)
        lstTx.Add(TxLote12)

        lstTx.Add(TxPreca1)
        lstTx.Add(TxPreca2)
        lstTx.Add(TxPreca3)
        lstTx.Add(TxPreca4)
        lstTx.Add(TxPreca5)
        lstTx.Add(TxPreca6)
        lstTx.Add(TxPreca7)
        lstTx.Add(TxPreca8)
        lstTx.Add(TxPreca9)
        lstTx.Add(TxPreca10)
        lstTx.Add(TxPreca11)
        lstTx.Add(TxPreca12)


        lstTx.Add(TxBul1)
        lstTx.Add(TxBul2)
        lstTx.Add(TxBul3)
        lstTx.Add(TxBul4)
        lstTx.Add(TxBul5)
        lstTx.Add(TxBul6)
        lstTx.Add(TxBul7)
        lstTx.Add(TxBul8)
        lstTx.Add(TxBul9)
        lstTx.Add(TxBul10)
        lstTx.Add(TxBul11)
        lstTx.Add(TxBul12)

        CancelaPulsacion(lstTx)


        If _idlineapedido <> "" Then
            CargaDatosPedido()
            _idlineapedido = ""
        End If


    End Sub


    Private Sub CancelaPulsacion(lst As List(Of TxDato))

        For Each tx As TxDato In lst
            tx.EnviarTecla(Keys.F12, False)
        Next

    End Sub



    Public Overrides Sub ControlClave()
        ' componemos la clave

        Dim i As Integer
        If TxNuPalet.Text = "+" Then
            LbId.Text = "+"
        Else
            i = palets.Leerpalet(Lbejer.Text, MiCentro, TxNuPalet.Text)
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


        PintaPuntoVenta(palets.PAL_idpuntoventa.Valor)
        Lbejer.Text = palets.PAL_campa.Valor
        LbNumAlb.Text = ""

       

        NumeroAlbaran()

        If palets.PAL_finalizado.Valor = "N" Then
            BtTerminado.Text = "SIN TERMINAR"
            BtTerminado.ForeColor = Color.Red
        Else
            BtTerminado.Text = "PALET TERMINADO"
            BtTerminado.ForeColor = Color.Green
        End If


        ' llenar el grid
        CargaLineasGrid()

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)


        btCartelon.Enabled = True


        Dim Idpartida As String = ""

        IdLineaGrid = palets_lineas.PLL_idlinea.Valor

        Lbkilosnetos.Text = Format(VaDec(palets_lineas.PLL_kilosnetos.Valor), "#,###")
        LbKilosSal.Text = Format(VaDec(palets_lineas.PLL_kiloscliente.Valor), "#,###")

        If VaDec(palets_lineas.PLL_bultos.Valor) <> 0 Then
            LbKnXb.Text = Format(VaDec(Lbkilosnetos.Text) / VaDec(palets_lineas.PLL_bultos.Valor), "#0.0")
        Else
            LbKnXb.Text = ""
        End If

        MyBase.Entidad_a_DatosLin(Grid)


        CalculaTaras()

        CargaTrazabilidadLinea(IdLineaGrid)

        If VaInt(palets_lineas.PLL_idlineaentradaconfeccionada.Valor) > 0 Then
            If Albentrada_lineas.LeerId(palets_lineas.PLL_idlineaentradaconfeccionada.Valor) = True Then
                If Albentrada.LeerId(Albentrada_lineas.AEL_idalbaran.Valor) = True Then
                    LbEntrConf.Text = Albentrada.AEN_Albaran.Valor
                End If
            End If
        End If





        Dim IdPedidoLineaActual As Integer = VaInt(palets_lineas.PLL_idpedidolinea.Valor)


        If IdPedidoLineaActual > 0 Then

            LbIdPedidoLinea.text = IdPedidoLineaActual.ToString

            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(Pedidos_Lineas.PEL_idpedido, "idpedido")
            consulta.SelCampo(Pedidos_Lineas.PEL_idcategoria, "idcatcomercial")
            consulta.SelCampo(Pedidos.PED_pedido, "pedido", Pedidos_Lineas.PEL_idpedido)
            consulta.SelCampo(Clientes.CLI_Nombre, "cliente", Pedidos.PED_idcliente)
            consulta.WheCampo(Pedidos_Lineas.PEL_idlinea, "=", palets_lineas.PLL_idpedidolinea.Valor)

            Dim sql As String = consulta.SQL
            Dim dt As DataTable = Pedidos.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                If dt.Rows.Count = 1 Then

                    LbPedido.Text = dt.Rows(0)("pedido").ToString
                    LbNom_Cliente.Text = dt.Rows(0)("cliente").ToString

                    AsociarCategorias()

                End If
            End If
        Else
            lbidpedidolinea.text = ""
            LbPedido.Text = ""
            LbNom_Cliente.Text = ""
        End If


    End Sub


    Private Sub CargaTrazabilidadLinea(IdLineaGrid As String)

        BorrarPanel()

        Dim sql As String = ""
        Dim indice As Integer = 0

        sql = "SELECT PLT_idlineaentrada as idPartida, PLT_idlote as idlote, PLT_idprecalibrado as idpreca, " & vbCrLf
        sql = sql & " PLT_Bultos as Bultos" & vbCrLf
        sql = sql & " FROM PALETS_TRAZA" & vbCrLf
        sql = sql & " WHERE PLT_IdLineaPalet = " & IdLineaGrid & vbCrLf
        sql = sql & " AND COALESCE(PLT_IdProgramaCliente,0) = 0" & vbCrLf
        sql = sql & " ORDER BY PLT_IDTRAZA"

        Dim DtTraza As DataTable = palets_traza.MiConexion.ConsultaSQL(sql)
        If Not DtTraza Is Nothing Then
            For Each rwt In DtTraza.Rows

                Dim Campa As String = ""
                Dim Bultos As Integer = VaInt(rwt("Bultos"))
                Dim Partida As String = ""
                Dim Agricultor As String = ""
                Dim Idgenero As String = ""
                Dim Genero As String = ""
                Dim Lote As String = ""
                Dim Preca As String = ""

                If VaInt(rwt("idpartida")) > 0 Then

                    sql = "SELECT AEN_Campa as Campa, AEL_Muestreo as Partida, AGR_Nombre as Agricultor, AEL_IdGenero as IdGenero, GEN_NombreGenero as Genero " & vbCrLf
                    sql = sql & " FROM albentrada_lineas" & vbCrLf
                    sql = sql & " LEFT JOIN Albentrada ON AEN_Idalbaran = AEL_Idalbaran" & vbCrLf
                    sql = sql & " LEFT JOIN Agricultores ON AGR_IdAgricultor = AEN_IdAgricultor" & vbCrLf
                    sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = AEL_IdGenero" & vbCrLf
                    sql = sql & " WHERE AEL_IdLinea = " & rwt("idpartida").ToString & vbCrLf

                    Dim dtp As DataTable = Albentrada_lineas.MiConexion.ConsultaSQL(sql)
                    If Not dtp Is Nothing Then
                        If dtp.Rows.Count > 0 Then
                            Dim row As DataRow = dtp.Rows(0)

                            Campa = (row("Campa").ToString & "").Trim
                            Partida = (row("Partida").ToString & "").Trim
                            Agricultor = (row("Agricultor").ToString & "").Trim
                            Idgenero = (row("IdGenero").ToString & "").Trim
                            Genero = (row("Genero").ToString & "").Trim
                            Preca = ""
                            Lote = ""

                        End If
                    End If


                ElseIf VaInt(rwt("idlote")) > 0 Then

                    sql = "SELECT LTE_Campa as Campa, LTE_lote as lote,  LTE_IdGenero as IdGenero, GEN_NombreGenero as Genero " & vbCrLf
                    sql = sql & " FROM LOTES" & vbCrLf
                    sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = LTE_IdGenero" & vbCrLf
                    sql = sql & " WHERE LTE_Idlote = " & rwt("idlote").ToString & vbCrLf

                    Dim dtp As DataTable = Lotes.MiConexion.ConsultaSQL(sql)
                    If Not dtp Is Nothing Then
                        If dtp.Rows.Count > 0 Then
                            Dim row As DataRow = dtp.Rows(0)

                            Campa = (row("Campa").ToString & "").Trim
                            Partida = ""
                            Preca = ""

                            Agricultor = ""
                            Idgenero = (row("IdGenero").ToString & "").Trim
                            Genero = (row("Genero").ToString & "").Trim
                            Lote = (row("Lote").ToString & "").Trim

                        End If
                    End If

                ElseIf VaInt(rwt("idpreca")) > 0 Then
                    sql = "SELECT LPD_Campa as Campa, LPD_lote as lote,  LPD_IdGenero as IdGenero, GEN_NombreGenero as Genero " & vbCrLf
                    sql = sql & " FROM LOTESPRODUCCION" & vbCrLf
                    sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = LPD_IdGenero" & vbCrLf
                    sql = sql & " WHERE LPD_Idlote = " & rwt("idpreca").ToString & vbCrLf

                    Dim dtp As DataTable = Lotes.MiConexion.ConsultaSQL(sql)
                    If Not dtp Is Nothing Then
                        If dtp.Rows.Count > 0 Then
                            Dim row As DataRow = dtp.Rows(0)

                            Campa = (row("Campa").ToString & "").Trim
                            Partida = ""
                            Lote = ""
                            Agricultor = ""
                            Idgenero = (row("IdGenero").ToString & "").Trim
                            Genero = (row("Genero").ToString & "").Trim
                            Preca = (row("Lote").ToString & "").Trim

                        End If
                    End If



                End If


                If VaInt(Lote) > 0 Or VaInt(Partida) > 0 Or VaInt(Preca) > 0 Then
                    indice = indice + 1
                    Select Case indice

                        Case 1
                            TxCampa1.Text = Campa : TxPar1.Text = Partida : LbAgri1.Text = Agricultor : LbCodGen1.Text = Idgenero : LbGen1.Text = Genero : TxBul1.Text = Bultos.ToString("#,##0") : TxLote1.Text = Lote : TxPreca1.Text = Preca
                        Case 2
                            TxCampa2.Text = Campa : TxPar2.Text = Partida : LbAgri2.Text = Agricultor : LbCodGen2.Text = Idgenero : LbGen2.Text = Genero : TxBul2.Text = Bultos.ToString("#,##0") : TxLote2.Text = Lote : TxPreca2.Text = Preca
                        Case 3
                            TxCampa3.Text = Campa : TxPar3.Text = Partida : LbAgri3.Text = Agricultor : LbCodGen3.Text = Idgenero : LbGen3.Text = Genero : TxBul3.Text = Bultos.ToString("#,##0") : TxLote3.Text = Lote : TxPreca3.Text = Preca
                        Case 4
                            TxCampa4.Text = Campa : TxPar4.Text = Partida : LbAgri4.Text = Agricultor : LbCodGen4.Text = Idgenero : LbGen4.Text = Genero : TxBul4.Text = Bultos.ToString("#,##0") : TxLote4.Text = Lote : TxPreca4.Text = Preca
                        Case 5
                            TxCampa5.Text = Campa : TxPar5.Text = Partida : LbAgri5.Text = Agricultor : LbCodGen5.Text = Idgenero : LbGen5.Text = Genero : TxBul5.Text = Bultos.ToString("#,##0") : TxLote5.Text = Lote : TxPreca5.Text = Preca
                        Case 6
                            TxCampa6.Text = Campa : TxPar6.Text = Partida : LbAgri6.Text = Agricultor : LbCodGen6.Text = Idgenero : LbGen6.Text = Genero : TxBul6.Text = Bultos.ToString("#,##0") : TxLote6.Text = Lote : TxPreca6.Text = Preca
                        Case 7
                            TxCampa7.Text = Campa : TxPar7.Text = Partida : LbAgri7.Text = Agricultor : LbCodGen7.Text = Idgenero : LbGen7.Text = Genero : TxBul7.Text = Bultos.ToString("#,##0") : TxLote7.Text = Lote : TxPreca7.Text = Preca
                        Case 8
                            TxCampa8.Text = Campa : TxPar8.Text = Partida : LbAgri8.Text = Agricultor : LbCodGen8.Text = Idgenero : LbGen8.Text = Genero : TxBul8.Text = Bultos.ToString("#,##0") : TxLote8.Text = Lote : TxPreca8.Text = Preca
                        Case 9
                            TxCampa9.Text = Campa : TxPar9.Text = Partida : LbAgri9.Text = Agricultor : LbCodgen9.Text = Idgenero : LbGen9.Text = Genero : TxBul9.Text = Bultos.ToString("#,##0") : TxLote9.Text = Lote : TxPreca9.Text = Preca
                        Case 10
                            TxCampa10.Text = Campa : TxPar10.Text = Partida : LbAgri10.Text = Agricultor : LbCodGen10.Text = Idgenero : LbGen10.Text = Genero : TxBul10.Text = Bultos.ToString("#,##0") : TxLote10.Text = Lote : TxPreca10.Text = Preca
                        Case 11
                            TxCampa11.Text = Campa : TxPar11.Text = Partida : LbAgri11.Text = Agricultor : LbCodGen11.Text = Idgenero : LbGen11.Text = Genero : TxBul11.Text = Bultos.ToString("#,##0") : TxLote11.Text = Lote : TxPreca11.Text = Preca
                        Case 12
                            TxCampa12.Text = Campa : TxPar12.Text = Partida : LbAgri12.Text = Agricultor : LbCodgen12.Text = Idgenero : LbGen12.Text = Genero : TxBul12.Text = Bultos.ToString("#,##0") : TxLote12.Text = Lote : TxPreca12.Text = Preca

                    End Select

                End If
            Next

        End If



    End Sub

    Public Overrides Sub DespuesdeGuardarLinea(gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)
        Dim IdLineaGrid As String = palets_lineas.PLL_idlinea.Valor & ""

        Try

            'Revisamos los datos del panel antes de guardar
            'TxPar1.Validar(False)
            'TxPar2.Validar(False)
            'TxPar3.Validar(False)
            'TxPar4.Validar(False)
            'TxPar5.Validar(False)
            'TxPar6.Validar(False)
            'TxPar7.Validar(False)

            'TxBul1.Validar(False)
            'TxBul2.Validar(False)
            'TxBul3.Validar(False)
            'TxBul4.Validar(False)
            'TxBul5.Validar(False)
            'TxBul6.Validar(False)
            'TxBul7.Validar(False)


            'If TxPar1.MiError Or TxPar2.MiError Or TxPar3.MiError Or TxPar4.MiError Or TxPar5.MiError Or TxPar6.MiError Or TxPar7.MiError Or
            '    TxBul1.MiError Or TxBul2.MiError Or TxBul3.MiError Or TxBul4.MiError Or TxBul5.MiError Or TxBul6.MiError Or TxBul7.MiError Then
            '    MsgBox("Corregir errores en las líneas de trazabilidad")
            '    Return False
            'End If


            ''Guardamos la trazabilidad
            GuardaTrazabilidadLinea(IdLineaGrid)

        Catch ex As Exception
            err.Muestraerror("Error al guardar la trazabilidad de la línea " & IdLineaGrid, "GuardarLineas", ex.Message)
        End Try


    End Sub




    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean


        Dim bTransformarControlado As Boolean = False


        'asociar cabecera con lineas
        Dim r As Boolean

        If Gr Is ClGrid1 Then




            If LbId.Text = "+" Then
                LbId.Text = palets.MaxId
                If TxNuPalet.Text = "+" Then
                    TxNuPalet.Text = palets.MaxIdCampa(Lbejer.Text, MiCentro)
                End If
            End If

            palets.PAL_idpalet.Valor = LbId.Text
            palets.PAL_campa.Valor = Lbejer.Text
            palets.PAL_idpuntoventa.Valor = LbPuntoVenta.Text
            palets.PAL_idcentro.Valor = MiCentro
            palets.PAL_idpalet.Valor = LbId.Text



            If Not CopruebaControladoTraza() Then
                TxControlado.Text = "N"
                palets_lineas.PLL_Controlado.Valor = "N"
                bTransformarControlado = True
            End If


            palets_lineas.PLL_idpalet.Valor = LbId.Text
            palets_lineas.PLL_kilosnetos.Valor = Lbkilosnetos.Text
            palets_lineas.PLL_kiloscliente.Valor = LbKilosSal.Text
            palets_lineas.PLL_idpedidolinea.Valor = LbIdPedidoLinea.Text

            If VaInt(LbIdPedidoLinea.Text) > 0 Then
                palets_lineas.PLL_TipoReserva.Valor = "R"
            End If

            Dim idlinea As String = ""
            Dim idtarea As String = ""



            SqlGrid()

        End If



        r = MyBase.GuardarLineas(Gr)


        If bTransformarControlado Then
            MsgBox("Esta línea de palet se ha transformado en NO CONTROLADA porque tiene trazabilidades NO CONTROLADAS")
        End If


        Return r


    End Function


    Private Function CopruebaControladoTraza() As Boolean

        Dim bRes As Boolean = True


        If Not EsControlado(TxCampa1.Text, TxPar1.Text, TxLote1.Text, TxPreca1.Text) Then
            bRes = False
        ElseIf Not EsControlado(TxCampa2.Text, TxPar2.Text, TxLote2.Text, TxPreca2.Text) Then
            bRes = False
        ElseIf Not EsControlado(TxCampa3.Text, TxPar3.Text, TxLote3.Text, TxPreca3.Text) Then
            bRes = False
        ElseIf Not EsControlado(TxCampa4.Text, TxPar4.Text, TxLote4.Text, TxPreca4.Text) Then
            bRes = False
        ElseIf Not EsControlado(TxCampa5.Text, TxPar5.Text, TxLote5.Text, TxPreca5.Text) Then
            bRes = False
        ElseIf Not EsControlado(TxCampa6.Text, TxPar6.Text, TxLote6.Text, TxPreca6.Text) Then
            bRes = False
        ElseIf Not EsControlado(TxCampa7.Text, TxPar7.Text, TxLote7.Text, TxPreca7.Text) Then
            bRes = False
        ElseIf Not EsControlado(TxCampa8.Text, TxPar8.Text, TxLote8.Text, TxPreca8.Text) Then
            bRes = False
        ElseIf Not EsControlado(TxCampa9.Text, TxPar9.Text, TxLote9.Text, TxPreca9.Text) Then
            bRes = False
        ElseIf Not EsControlado(TxCampa10.Text, TxPar10.Text, TxLote10.Text, TxPreca10.Text) Then
            bRes = False
        ElseIf Not EsControlado(TxCampa11.Text, TxPar11.Text, TxLote11.Text, TxPreca11.Text) Then
            bRes = False
        ElseIf Not EsControlado(TxCampa12.Text, TxPar12.Text, TxLote12.Text, TxPreca12.Text) Then
            bRes = False
        End If



        Return bRes

    End Function


    Private Function EsControlado(Campa As String, Partida As String, NumLote As String, NumLoteProduccion As String) As Boolean


        If Partida.Trim = "" And NumLote.Trim = "" And NumLoteProduccion.Trim = "" Then
            'línea vacía
            Return True
        End If



        Dim bRes As Boolean = False


        Dim Controlado As String = ""


        If VaInt(Partida) > 0 Then

            Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
            Dim Id As Integer = AlbEntrada_Lineas.LeerMuestreo(Campa, Partida)
            If Id > 0 Then
                If AlbEntrada_Lineas.LeerId(Id) Then
                    Controlado = (AlbEntrada_Lineas.AEL_Controlado.Valor & "").Trim.ToUpper
                End If
            End If

        ElseIf VaInt(NumLote) > 0 Then

            Dim Lotes As New E_Lotes(Idusuario, cn)
            If Lotes.LeerLote(Campa, NumLote) Then
                Controlado = (Lotes.LTE_Controlado.Valor & "").Trim.ToUpper
            End If

        ElseIf VaInt(NumLoteProduccion) > 0 Then

            Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
            If LotesProduccion.LeerLote(Campa, NumLoteProduccion) Then
                Controlado = (LotesProduccion.LPD_Controlado.Valor & "").Trim.ToUpper
            End If

        End If



        If Controlado = "S" Then
            bRes = True
        End If



        Return bRes

    End Function


    Private Sub GuardaTrazabilidadLinea(IdLineaPalet As String)

        'Borrar trazabilidad para la linea de palet
        If VaInt(IdLineaPalet) > 0 Then
            Dim sql As String = "DELETE FROM palets_traza WHERE PLT_IdLineaPalet = " & IdLineaPalet & " AND COALESCE(PLT_IdProgramaCliente,0) = 0"
            palets_traza.MiConexion.OrdenSql(sql)
        End If



        'Crear trazabilidad a partir del panel
        Dim Partida As String = ""
        Dim Bultos As Integer = 0
        Dim Kilos As Decimal = 0


        CreaTrazabilidad(IdLineaPalet, TxCampa1.Text, TxPar1.Text, TxBul1.Text, TxLote1.Text, TxPreca1.Text)
        CreaTrazabilidad(IdLineaPalet, TxCampa2.Text, TxPar2.Text, TxBul2.Text, TxLote2.Text, TxPreca2.Text)
        CreaTrazabilidad(IdLineaPalet, TxCampa3.Text, TxPar3.Text, TxBul3.Text, TxLote3.Text, TxPreca3.Text)
        CreaTrazabilidad(IdLineaPalet, TxCampa4.Text, TxPar4.Text, TxBul4.Text, TxLote4.Text, TxPreca4.Text)
        CreaTrazabilidad(IdLineaPalet, TxCampa5.Text, TxPar5.Text, TxBul5.Text, TxLote5.Text, TxPreca5.Text)
        CreaTrazabilidad(IdLineaPalet, TxCampa6.Text, TxPar6.Text, TxBul6.Text, TxLote6.Text, TxPreca6.Text)
        CreaTrazabilidad(IdLineaPalet, TxCampa7.Text, TxPar7.Text, TxBul7.Text, TxLote7.Text, TxPreca7.Text)
        CreaTrazabilidad(IdLineaPalet, TxCampa8.Text, TxPar8.Text, TxBul8.Text, TxLote8.Text, TxPreca8.Text)
        CreaTrazabilidad(IdLineaPalet, TxCampa9.Text, TxPar9.Text, TxBul9.Text, TxLote9.Text, TxPreca9.Text)
        CreaTrazabilidad(IdLineaPalet, TxCampa10.Text, TxPar10.Text, TxBul10.Text, TxLote10.Text, TxPreca10.Text)
        CreaTrazabilidad(IdLineaPalet, TxCampa11.Text, TxPar11.Text, TxBul11.Text, TxLote11.Text, TxPreca11.Text)
        CreaTrazabilidad(IdLineaPalet, TxCampa12.Text, TxPar12.Text, TxBul12.Text, TxLote12.Text, TxPreca12.Text)

    End Sub


    Private Sub CreaTrazabilidad(IdLineaPalet As String, Campa As String, Partida As String, Bultos As String, lote As String, preca As String)

        Dim IdAgricultor As String = ""
        Dim IdGenero As String = ""
        Dim IdCategoria As String = ""
        Dim KgEntrada As Decimal = 0
        Dim idlineaentrada As String = ""
        Dim Idlote As String = ""
        Dim IdPreca As String = ""


        If VaInt(Partida) > 0 Then
            idlineaentrada = Albentrada_lineas.LeerMuestreo(Campa, Partida)
        ElseIf VaInt(lote) > 0 Then
            Idlote = Lotes.LeerLote(Campa, lote)
        ElseIf VaInt(preca) > 0 Then
            IdPreca = LotesProduccion.LeerLote(Campa, preca)
        End If


        If VaInt(idlineaentrada) > 0 Or VaInt(Idlote) > 0 Or VaInt(IdPreca) > 0 Then

            Dim KilosNetos As Decimal = VaDec(Lbkilosnetos.Text)
            Dim BultosLinea As Integer = VaInt(TxBultos.Text)

            Dim KNxB As Decimal = 0
            If BultosLinea <> 0 Then
                KNxB = KilosNetos / BultosLinea
            End If
            Dim Kilos As Decimal = Math.Round(VaInt(Bultos) * KNxB, 0)


            Dim Palet_Traza As New E_palets_traza(Idusuario, cn)
            Palet_Traza.PLT_idtraza.Valor = Palet_Traza.MaxId()
            Palet_Traza.PLT_idlineapalet.Valor = IdLineaPalet
            Palet_Traza.PLT_bultos.Valor = VaInt(Bultos)
            Palet_Traza.PLT_kilos.Valor = Kilos
            Palet_Traza.PLT_IdLineaEntrada.Valor = idlineaentrada
            Palet_Traza.PLT_idlote.Valor = Idlote
            Palet_Traza.PLT_idprecalibrado.Valor = IdPreca
            Palet_Traza.PLT_idprogramacliente.Valor = "0"
            Palet_Traza.Insertar()


        End If
    End Sub


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()

        If VaInt(LbId.Text) > 0 Then
            palets_lineas.CoeficientePalet(LbId.Text)
        End If

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


        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 
        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable

        CONSULTA.SelCampo(palets_lineas.PLL_idlinea)
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Producto", palets_lineas.PLL_idgenero)
        CONSULTA.SelCampo(Confecenvase.CEV_Nombre, "Confeccion", palets_lineas.PLL_idtipoconfeccion)
        CONSULTA.SelCampo(palets_lineas.PLL_categoria, "Categoria")
        CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", palets_lineas.PLL_idmarca)
        CONSULTA.SelCampo(palets_lineas.PLL_bultos, "Bultos")
        CONSULTA.SelCampo(palets_lineas.PLL_kilosbrutos, "Kilos")
        CONSULTA.SelCampo(Albentrada_lineas.AEL_idalbaran, "IdAlbaran", palets_lineas.PLL_idlineaentradaconfeccionada, Albentrada_lineas.AEL_idlinea)
        CONSULTA.SelCampo(Albentrada.AEN_Albaran, "EntConf ", Albentrada_lineas.AEL_idalbaran, Albentrada.AEN_IdAlbaran)
        CONSULTA.WheCampo(palets_lineas.PLL_idpalet, "=", id)
        Dim sql As String = CONSULTA.SQL
        sql = sql + " order by PLL_idlinea"


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
            MsgBox("no se puede anular el palet")
            Exit Sub
        End If

        If LbNumAlb.Text <> "" Then
            MsgBox("Palet cargado")
            Exit Sub
        End If


        MyBase.BAnular_Click(sender, e)

    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString And VaInt(palets.PAL_idpvsituacion.Valor) <> MiMaletin.IdPuntoVenta Then
            MsgBox("no se puede modificar el palet")
            Exit Sub
        End If


        If LbNumAlb.Text <> "" And IdCargaAlb = "" Then
            MsgBox("Palet cargado")
            Exit Sub
        End If

        MyBase.BModificar_Click(sender, e)

    End Sub


    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNuevo.Click
        If TxNuPalet.Text = "" And TxNuPalet.Enabled = True Then
            TxNuPalet.Text = "+"
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

        'ClGrid2.Grid.DataSource = Nothing

        '_IdCategoriaPedido = ""

        LbKilosSal.Text = ""
        Lbkilosnetos.Text = ""
        LbKnXb.Text = ""
        lbpiezas.Text = ""


        IdLineaGrid = ""
        LbCodGen1.Text = ""
        LbAgri1.Text = ""
        LbGen1.Text = ""
        _Cbarras = False
        _Idlinea = ""
        _IdTarea = ""
        LbEntrConf.Text = ""


        LbIdPedidoLinea.Text = ""
        LbNom_Cliente.Text = ""
        LbPedido.Text = ""


        btCartelon.Enabled = False


        MyBase.Borralin(gr)


        If ClGrid1.Nlinea = -2 Then
            BorrarPanel()
        End If


        PanelTrazabilidad.Visible = False


        _bPesoFijo = False
        LbKxBPresentacion.Text = ""

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        '_IdCategoriaPedido = ""

        PintaPuntoVenta(MiMaletin.IdPuntoVenta)
        Lbejer.Text = MiMaletin.Ejercicio
        IdCargaAlb = ""
        _Cbarras = False
        _Idlinea = ""
        _IdTarea = ""

        LbCoeficiente.Text = ""

        BorrarPanel()

        'Reseteamos el último valor validado del txdato al borrar el formulario
        'TxCategoria.UltimoValorValidado = Nothing
        TxCategoria._UltimoValorCambiado = Nothing

        BtTerminado.Text = "PALET TERMINADO"
        BtTerminado.ForeColor = Color.Green

        btCartelon.Enabled = False

    End Sub


    Public Overrides Sub Salir()
        MyBase.Salir()

        _IdCategoriaPedido = ""

    End Sub


    Private Sub BorrarPanel()

        TxCampa1.Text = ""
        TxCampa2.Text = ""
        TxCampa3.Text = ""
        TxCampa4.Text = ""
        TxCampa5.Text = ""
        TxCampa6.Text = ""
        TxCampa7.Text = ""
        TxCampa8.Text = ""
        TxCampa9.Text = ""
        TxCampa10.Text = ""
        TxCampa11.Text = ""
        TxCampa12.Text = ""

        TxPar1.Text = ""
        TxPar2.Text = ""
        TxPar3.Text = ""
        TxPar4.Text = ""
        TxPar5.Text = ""
        TxPar6.Text = ""
        TxPar7.Text = ""
        TxPar8.Text = ""
        TxPar9.Text = ""
        TxPar10.Text = ""
        TxPar11.Text = ""
        TxPar12.Text = ""

        LbAgri1.Text = ""
        LbAgri2.Text = ""
        LbAgri3.Text = ""
        LbAgri4.Text = ""
        LbAgri5.Text = ""
        LbAgri6.Text = ""
        LbAgri7.Text = ""
        LbAgri8.Text = ""
        LbAgri9.Text = ""
        LbAgri10.Text = ""
        LbAgri11.Text = ""
        LbAgri12.Text = ""

        LbCodGen1.Text = ""
        LbCodGen2.Text = ""
        LbCodGen3.Text = ""
        LbCodGen4.Text = ""
        LbCodGen5.Text = ""
        LbCodGen6.Text = ""
        LbCodGen7.Text = ""
        LbCodGen8.Text = ""
        LbCodgen9.Text = ""
        LbCodGen10.Text = ""
        LbCodGen11.Text = ""
        LbCodgen12.Text = ""

        LbGen1.Text = ""
        LbGen2.Text = ""
        LbGen3.Text = ""
        LbGen4.Text = ""
        LbGen5.Text = ""
        LbGen6.Text = ""
        LbGen7.Text = ""
        LbGen8.Text = ""
        LbGen9.Text = ""
        LbGen10.Text = ""
        LbGen11.Text = ""
        LbGen12.Text = ""


        TxBul1.Text = ""
        TxBul2.Text = ""
        TxBul3.Text = ""
        TxBul4.Text = ""
        TxBul5.Text = ""
        TxBul6.Text = ""
        TxBul7.Text = ""
        TxBul8.Text = ""
        TxBul9.Text = ""
        TxBul10.Text = ""
        TxBul11.Text = ""
        TxBul12.Text = ""

        TxPreca1.Text = ""
        TxPreca2.Text = ""
        TxPreca3.Text = ""
        TxPreca4.Text = ""
        TxPreca5.Text = ""
        TxPreca6.Text = ""
        TxPreca7.Text = ""
        TxPreca8.Text = ""
        TxPreca9.Text = ""
        TxPreca10.Text = ""
        TxPreca11.Text = ""
        TxPreca12.Text = ""

    End Sub


    Public Overrides Sub DespuesdeCargarLineas(ByVal gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)
    End Sub


    Public Overrides Sub Guardar()

        'If Not CompruebaGGN1() Then
        '    MsgBox("Debe introducir al menos el primer GGN. Para introducirlo, pulse en el botón '+ Info'")
        '    Exit Sub
        'End If


        palets.PAL_idpuntoventa.Valor = LbPuntoVenta.Text
        palets.PAL_campa.Valor = Lbejer.Text
        palets.PAL_idcentro.Valor = MiCentro

        If VaInt(palets.PAL_idpvsituacion.Valor) = 0 Then palets.PAL_idpvsituacion.Valor = palets.PAL_idpuntoventa.Valor


        If BtTerminado.Text = "SIN TERMINAR" Then
            palets.PAL_finalizado.Valor = "N"
        Else
            palets.PAL_finalizado.Valor = "S"
        End If

        Dim bImprimir As Boolean = NuevoRegistro
        If Modificando And Not NuevoRegistro Then
            If XtraMessageBox.Show("¿Desea imprimir el ticket del palet?", "Imprimir Ticket", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                bImprimir = True
            End If
        End If

        Dim IdPalet As String = LbId.Text


        palets.PAL_HoraConfeccion.Valor = Now.ToString("dd/MM/yyyy HH:mm:ss")
        palets.PAL_IdUsuario.Valor = Idusuario.ToString
        palets.PAL_IdOperario.Valor = MiMaletin.IdOperario.ToString

        palets.PAL_PaletsTransporte.Valor = VaInt(LbCoeficiente.Text).ToString


        MyBase.Guardar()


        If bImprimir Then
            If VaDec(IdPalet) > 0 Then
                'C1_ImprimirTicketPalet(IdPalet, TipoImpresion.ImpresoraPorDefecto)
                C1_ImprimirTicketPalet(IdPalet, TipoImpresion.ImpresoraSeleccionada)
            End If
        End If

        If _salirdespuesdeguardar = True Then Me.Close()



    End Sub



    'Private Sub DatosPartida(ByVal Nupartida As String)

    '    Dim IdAgricultor As String = ""
    '    Dim IdGenero As String = ""
    '    Dim Kilos As String = ""
    '    Dim idcategoria As String = ""
    '    Dim id As String
    '    LbAgri1.Text = ""
    '    LbGen1.Text = ""

    '    id = Albentrada_lineas.DatosPartida(Lbejer.Text, Nupartida, IdAgricultor, IdGenero, idcategoria, Kilos)

    '    If Val(id) > 0 Then
    '        If Agricultores.LeerId(IdAgricultor) Then
    '            LbAgri1.Text = Agricultores.AGR_Nombre.Valor
    '        End If
    '        LbCodGen1.Text = IdGenero
    '        If Generos.LeerId(LbCodGen1.Text) = True Then
    '            LbGen1.Text = Generos.GEN_NombreGenero.Valor
    '        End If
    '    End If

    'End Sub





    Private Sub Calculin()

        Dim Tarapalet As Double = VaDec(TxDato_4.Text)
        Dim taraenvase As Double = VaDec(TxBultos.Text) * VaDec(LbTaraEnvase.Text)
        Dim l As Integer = ClGrid1.GridView.FocusedRowHandle

        If l > 0 Then
            Tarapalet = 0
        End If

        If ChTara.CheckState = CheckState.Checked Then
            Tarapalet = 0
            taraenvase = 0
        End If


        Dim ks As Double = 0
        If _bPesoFijo Then
            ks = VaDec(TxBultos.Text) * VaDec(TxKxB.Text)
        End If
        Dim kn As Double = VaDec(TxKilosBr.Text) - Tarapalet - taraenvase
        Lbkilosnetos.Text = Format(kn, "#,###")

        If ks = 0 Then
            ks = kn
        End If

        If VaDec(TxBultos.Text) <> 0 Then
            LbKnXb.Text = Format(kn / VaDec(TxBultos.Text), "#0.0")
        Else
            LbKnXb.Text = ""
        End If

        LbKilosSal.Text = Format(ks, "#,###")
        lbpiezas.Text = Format(VaDec(TxBultos.Text) * VaDec(TxPxB.Text), "#,###")

    End Sub


    Private Sub TxConfeccion_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxConfeccion.KeyDown

        Select Case e.KeyCode
            Case Keys.F2
                Dim v As String


                'If Not TxPresentacion.ClParam.BtBusca Is Nothing Then
                '    v = TxPresentacion.ClParam.BtBusca.Enlazar


                If Not IsNothing(BtBuscaConfecSalidas) Then
                    v = BtBuscaConfecSalidas.Enlazar

                    If v <> "" Then
                        TxPresentacion.Text = v
                        TxPresentacion.Validar(True)
                        TxCliente.Focus()
                        'TxMarca.Focus()
                    End If
                End If

        End Select

    End Sub



    Private Sub TxConfeccion_Valida(ByVal edicion As Boolean) Handles TxConfeccion.Valida

        FiltroConfeccion()


        Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
        If ConfecEnvase.LeerId(TxConfeccion.Text) Then
            Lb24.Text = ConfecEnvase.CEV_Nombre.Valor
        End If


        CalculaTaras()

    End Sub


    Private Sub CalculaTaras()

        LbTaraEnvase.Text = ""
        LbTaraLinea.Text = ""

        Dim TaraLinea As Decimal = 0
        'If ClGrid1.Nlinea = 0 Then TaraLinea = VaDec(TxDato_4.Text)
        If ClGrid1.GridView.FocusedRowHandle <= 0 Then TaraLinea = VaDec(TxDato_4.Text)

        Dim Confecenvase As New E_ConfecEnvase(Idusuario, cn)
        If Confecenvase.LeerId(TxConfeccion.Text) = True Then

            LbTaraEnvase.Text = Confecenvase.CEV_TotalTara.Valor
            TaraLinea = TaraLinea + VaDec(Confecenvase.CEV_TotalTara.Valor) * VaDec(TxBultos.Text)

        End If


        If TaraLinea <> 0 Then LbTaraLinea.Text = TaraLinea.ToString("#,##0.00")

    End Sub


    Private Sub TxCategoria_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxCategoria.TextChanged

    End Sub

    Private Sub TxCategoria_Valida(ByVal edicion As Boolean) Handles TxCategoria.Valida

        '       _categoriacomercial = CatSalidaComercial.fCategoriaComercial(TxCategoria.Text).ToString
        _categoriacomercial = TxCategoria.Text.ToString

        FiltroConfeccion()

        If edicion = True Then
            'If TxNomCategoria.Text = "" Then
            If TxCategoria.HaCambiado Or TxNomCategoria.Text = "" Then
                TxNomCategoria.Text = Lb10.Text
            End If
        End If

    End Sub

    Private Sub TxDato_16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxKxB.TextChanged

    End Sub

    Private Sub TxDato_16_Valida(ByVal edicion As Boolean) Handles TxKxB.Valida
        If edicion = True Then
            Calculin()
        End If
    End Sub

    Private Sub TxDato_17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxKilosBr.TextChanged

    End Sub

    Private Sub TxDato_17_Valida(ByVal edicion As Boolean) Handles TxKilosBr.Valida
        If edicion = True Then
            Calculin()
        End If
    End Sub


    Private Sub TxDato_18_Valida(ByVal edicion As Boolean) Handles TxPxB.Valida

        If edicion = True Then

            If TxCampa1.Text.Trim = "" Then TxCampa1.Text = Lbejer.Text
            TxPxB.Siguiente = TxPar1.Orden

            Calculin()
            MuestraPanel()
        End If

    End Sub


    Private Sub TxGenero_Valida(ByVal edicion As Boolean) Handles TxGenero.Valida

        FiltroConfeccion()
        AsociarCategorias()

    End Sub


    Private Sub AsociarCategorias()

        If VaInt(_IdCategoriaPedido) > 0 Then

            Dim Sql As String = "Select CSC_idcatsalida from catsalidacomercial where CSC_idcatcomercial=" + _IdCategoriaPedido
            Dim dtc As DataTable = CatSalidaComercial.MiConexion.ConsultaSQL(Sql)
            If Not dtc Is Nothing Then
                If dtc.Rows.Count >= 1 Then
                    AsociarControles(TxCategoria, BtBuscaCat, CategoriasSalida.BtBuscaComercial, CategoriasSalida, CategoriasSalida.CAS_CategoriaCalibre, Lb10)
                    BtBuscaCat.CL_Filtro = "idcomercial=" + _IdCategoriaPedido
                End If
            End If

            If Generos.LeerId(TxGenero.Text) = True Then
                If Subfamilias.LeerId(Generos.GEN_IdsubFamilia.Valor) = True Then
                    AsociarControles(TxCategoria, BtBuscaCatTodas, CategoriasSalida.BtBuscaFamilias, CategoriasSalida, CategoriasSalida.CAS_CategoriaCalibre, Lb10)
                    BtBuscaCatTodas.CL_Filtro = "Idfamilia = " & Subfamilias.SFA_idfamilia.Valor
                End If
            End If

        Else

            If Generos.LeerId(TxGenero.Text) = True Then
                If Subfamilias.LeerId(Generos.GEN_IdsubFamilia.Valor) = True Then

                    AsociarControles(TxCategoria, BtBuscaCat, CategoriasSalida.BtBuscaFamilias, CategoriasSalida, CategoriasSalida.CAS_CategoriaCalibre, Lb10)
                    BtBuscaCat.CL_Filtro = "Idfamilia = " & Subfamilias.SFA_idfamilia.Valor

                    AsociarControles(TxCategoria, BtBuscaCatTodas, CategoriasSalida.BtBuscaFamilias, CategoriasSalida, CategoriasSalida.CAS_CategoriaCalibre, Lb10)
                    BtBuscaCatTodas.CL_Filtro = "Idfamilia = " & Subfamilias.SFA_idfamilia.Valor

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




    Private Sub NumeroAlbaran()
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(albsalida_palets.ASP_IdAlbaran)
        consulta.SelCampo(albsalida.ASA_albaran, "Albaran", albsalida_palets.ASP_IdAlbaran)
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", albsalida.ASA_idcliente)
        consulta.WheCampo(albsalida_palets.ASP_Idpalet, "=", LbId.Text)
        Dim sql As String = consulta.SQL
        Dim dt As DataTable = albsalida_palets.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                LbNumAlb.Text = dt.Rows(0)("Albaran").ToString
                LbCliAlb.Text = dt.Rows(0)("Cliente").ToString
            End If
        End If
    End Sub

    Private Sub TxDato_40_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub TxDato_5_Valida(ByVal edicion As Boolean) Handles TxEnvPropio.Valida

        If edicion = True Then
            If TxEnvPropio.Text <> "N" Then
                TxEnvPropio.Text = "S"
            End If
        End If
    End Sub


    Private Sub BtBuscaCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtBuscaCat.Click

    End Sub

    Private Sub TxTipoPalet_Valida(edicion As System.Boolean) Handles TxTipoPalet.Valida


        LbCoeficiente.Text = ""

        If edicion Then
            ObtenerTara()
        End If

        Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)
        If VaInt(TxTipoPalet.Text) > 0 Then
            If ConfecPalet.LeerId(TxTipoPalet.Text) Then
                LbCoeficiente.Text = VaDec(ConfecPalet.CPA_Coeficiente.Valor).ToString("#,##0.00")
            End If
        End If

    End Sub




    Private Sub ObtenerTara()

        If VaInt(TxTipoPalet.Text) > 0 Then

            Dim TotalTara As Decimal = 0

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

            Dim dt As DataTable = palets.MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    TotalTara = Math.Round(VaDec(dt.Rows(0)("TotalTara")), 2)
                End If
            End If


            TxDato_4.Text = TotalTara.ToString()
            TxDato_4.Validar(True)


        End If

    End Sub


    Private Sub TxDato_3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxTipoPalet.KeyDown

        If e.KeyCode = Keys.Enter Then

            ObtenerTara()

        End If

    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()


        If VaDec(LbId.Text) > 0 Then
            'C1_ImprimirTicketPalet(LbId.Text, TipoImpresion.ImpresoraPorDefecto)
            C1_ImprimirTicketPalet(LbId.Text, TipoImpresion.ImpresoraSeleccionada)
        End If

    End Sub


    Private Function DtGeneros3(idcliente As String) As DataTable
        Dim ret As New DataTable
        Dim Consulta As New Cdatos.E_select


        Return ret

    End Function


    Private Sub OcultaPalet()
        If PanelTrazabilidad.Visible = True Then
            PanelTrazabilidad.Visible = False
        End If
        TxPxB.Focus()

    End Sub

    Private Sub MuestraPanel()

        If PanelTrazabilidad.Visible = False Then
            PanelTrazabilidad.Visible = True
        End If

    End Sub


    Private Sub CerrarPanel()

        PanelTrazabilidad.Visible = False

    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If PanelTrazabilidad.Visible = True Then
            OcultaPalet()
        Else
            MuestraPanel()
        End If

    End Sub

    Private Sub BtSumakilos_Click(sender As System.Object, e As System.EventArgs) Handles BtSumakilos.Click

        CerrarPanel()

    End Sub

    Private Sub TxPar1_Valida(edicion As System.Boolean) Handles TxPar1.Valida
        ValidaPartida(edicion, TxCampa1.Text, TxPar1.Text, 1, TxPar1, TxLote1, TxBul1, TxPreca1)
    End Sub

    Private Sub TxPar2_Valida(edicion As System.Boolean) Handles TxPar2.Valida
        ValidaPartida(edicion, TxCampa2.Text, TxPar2.Text, 2, TxPar2, TxLote2, TxBul2, TxPreca2)
    End Sub

    Private Sub TxPar3_Valida(edicion As System.Boolean) Handles TxPar3.Valida
        ValidaPartida(edicion, TxCampa3.Text, TxPar3.Text, 3, TxPar3, TxLote3, TxBul3, TxPreca3)
    End Sub

    Private Sub TxPar4_Valida(edicion As System.Boolean) Handles TxPar4.Valida
        ValidaPartida(edicion, TxCampa4.Text, TxPar4.Text, 4, TxPar4, TxLote4, TxBul4, TxPreca4)
    End Sub

    Private Sub TxPar5_Valida(edicion As System.Boolean) Handles TxPar5.Valida
        ValidaPartida(edicion, TxCampa5.Text, TxPar5.Text, 5, TxPar5, TxLote5, TxBul5, TxPreca5)
    End Sub

    Private Sub TxPar6_Valida(edicion As System.Boolean) Handles TxPar6.Valida
        ValidaPartida(edicion, TxCampa6.Text, TxPar6.Text, 6, TxPar6, TxLote6, TxBul6, TxPreca6)
    End Sub

    Private Sub TxPar7_Valida(edicion As System.Boolean) Handles TxPar7.Valida
        ValidaPartida(edicion, TxCampa7.Text, TxPar7.Text, 7, TxPar7, TxLote7, TxBul7, TxPreca7)
    End Sub

    Private Sub TxPar8_Valida(edicion As System.Boolean) Handles TxPar8.Valida
        ValidaPartida(edicion, TxCampa8.Text, TxPar8.Text, 8, TxPar8, TxLote8, TxBul8, TxPreca8)
    End Sub
    Private Sub TxPar9_Valida(edicion As System.Boolean) Handles TxPar9.Valida
        ValidaPartida(edicion, TxCampa9.Text, TxPar9.Text, 9, TxPar9, TxLote9, TxBul9, TxPreca9)
    End Sub
    Private Sub TxPar10_Valida(edicion As System.Boolean) Handles TxPar10.Valida
        ValidaPartida(edicion, TxCampa10.Text, TxPar10.Text, 10, TxPar10, TxLote10, TxBul10, TxPreca10)
    End Sub
    Private Sub TxPar11_Valida(edicion As System.Boolean) Handles TxPar11.Valida
        ValidaPartida(edicion, TxCampa11.Text, TxPar11.Text, 11, TxPar11, TxLote11, TxBul11, TxPreca11)
    End Sub

    Private Sub TxPar12_Valida(edicion As System.Boolean) Handles TxPar12.Valida
        ValidaPartida(edicion, TxCampa12.Text, TxPar12.Text, 12, TxPar12, TxLote12, TxBul12, TxPreca12)
    End Sub

    Private Sub ValidaPartida(edicion As Boolean, Campa As String, NuPartida As String, num As Integer, txPartida As TxDato, Txlote As TxDato, txbulto As TxDato, txpreca As TxDato)

        Dim IdAgricultor As String = ""
        Dim IdGenero As String = ""
        Dim IdCategoria As String = ""
        Dim sKilos As String = ""
        Dim Kilos As Decimal = 0

        Dim Agricultor As String = ""
        Dim Genero As String = ""

        Dim OrdenFinalLinea As Integer = 0





        If NuPartida.Trim <> "" Then

            Dim id As String = Albentrada_lineas.DatosPartida(Campa, NuPartida, IdAgricultor, IdGenero, IdCategoria, sKilos)

            If VaDec(id) = 0 Then
                MsgBox("Partida inexistente.")
                txPartida.MiError = True

            ElseIf Not CompruebaGeneroTrazabilidadPartida(TxGenero.Text, IdGenero) Then
                MsgBox("El género de la partida no corresponde al género de la línea del palet")
                txPartida.MiError = True

            ElseIf Val(id) > 0 Then
                If Agricultores.LeerId(IdAgricultor) Then
                    Agricultor = Agricultores.AGR_Nombre.Valor
                End If
                If Generos.LeerId(IdGenero) Then
                    Genero = Generos.GEN_NombreGenero.Valor
                End If

                txPartida.MiError = False
                txPartida.Siguiente = txbulto.Orden

            Else
                MsgBox("Partida inexistente")
                txPartida.MiError = True
            End If

        ElseIf Txlote.Text <> "" Then

            Dim idlote As Integer = Lotes.LeerLote(Campa, Txlote.Text)

            If idlote = 0 Then
                MsgBox("Lote inexistente.")
                txPartida.MiError = True

            ElseIf Not CompruebaGeneroTrazabilidadLote(TxGenero.Text, Lotes) Then
                MsgBox("El género del lote de entrada no corresponde al género de la línea del palet")
                txPartida.MiError = True

            ElseIf idlote > 0 Then
                If Lotes.LeerId(idlote.ToString) = True Then
                    IdGenero = Lotes.LTE_Idgenero.Valor
                    If Generos.LeerId(IdGenero) = True Then
                        Genero = Generos.GEN_NombreGenero.Valor
                    End If
                    Txlote.MiError = False
                    Txlote.Siguiente = txbulto.Orden

                End If

            Else
                MsgBox("Lote inexistente")
                Txlote.MiError = True

            End If

        ElseIf txpreca.Text <> "" Then

            Dim idpreca As Integer = LotesProduccion.LeerLote(Campa, txpreca.Text)

            If idpreca = 0 Then
                MsgBox("Lote produccion inexistente.")
                txpreca.MiError = True

            ElseIf Not CompruebaGeneroTrazabilidadPrecalibrado(TxGenero.Text, LotesProduccion) Then
                MsgBox("El género del precalibrado no corresponde al género de la línea del palet")
                txPartida.MiError = True

            ElseIf idpreca > 0 Then
                If LotesProduccion.LeerId(idpreca.ToString) = True Then
                    IdGenero = LotesProduccion.LPD_Idgenero.Valor
                    If Generos.LeerId(IdGenero) = True Then
                        Genero = Generos.GEN_NombreGenero.Valor
                    End If
                    txpreca.MiError = False
                End If

            Else
                MsgBox("Lote produccion inexistente")
                txpreca.MiError = True
            End If

        End If




        Select Case num

            Case 1
                LbAgri1.Text = Agricultor : LbCodGen1.Text = IdGenero : LbGen1.Text = Genero : OrdenFinalLinea = TxBul1.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul1.Text = ""
            Case 2
                LbAgri2.Text = Agricultor : LbCodGen2.Text = IdGenero : LbGen2.Text = Genero : OrdenFinalLinea = TxBul2.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul2.Text = ""
            Case 3
                LbAgri3.Text = Agricultor : LbCodGen3.Text = IdGenero : LbGen3.Text = Genero : OrdenFinalLinea = TxBul3.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul3.Text = ""
            Case 4
                LbAgri4.Text = Agricultor : LbCodGen4.Text = IdGenero : LbGen4.Text = Genero : OrdenFinalLinea = TxBul4.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul4.Text = ""
            Case 5
                LbAgri5.Text = Agricultor : LbCodGen5.Text = IdGenero : LbGen5.Text = Genero : OrdenFinalLinea = TxBul5.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul5.Text = ""
            Case 6
                LbAgri6.Text = Agricultor : LbCodGen6.Text = IdGenero : LbGen6.Text = Genero : OrdenFinalLinea = TxBul6.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul6.Text = ""
            Case 7
                LbAgri7.Text = Agricultor : LbCodGen7.Text = IdGenero : LbGen7.Text = Genero : OrdenFinalLinea = TxBul7.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul7.Text = ""
            Case 8
                LbAgri8.Text = Agricultor : LbCodGen8.Text = IdGenero : LbGen8.Text = Genero : OrdenFinalLinea = TxBul8.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul8.Text = ""
            Case 9
                LbAgri9.Text = Agricultor : LbCodgen9.Text = IdGenero : LbGen9.Text = Genero : OrdenFinalLinea = TxBul9.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul9.Text = ""
            Case 10
                LbAgri10.Text = Agricultor : LbCodGen10.Text = IdGenero : LbGen10.Text = Genero : OrdenFinalLinea = TxBul10.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul10.Text = ""
            Case 11
                LbAgri11.Text = Agricultor : LbCodGen11.Text = IdGenero : LbGen11.Text = Genero : OrdenFinalLinea = TxBul11.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul11.Text = ""
            Case 12
                LbAgri12.Text = Agricultor : LbCodgen12.Text = IdGenero : LbGen12.Text = Genero : OrdenFinalLinea = TxBul12.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul12.Text = ""

        End Select


    End Sub


    Private Sub TxPar1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar1.Text.Trim = "" Then
                TxLote1.Select()
                TxLote1.Focus()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            PanelTrazabilidad.Visible = False
            Siguiente(TxBul12.Orden)
        End If
    End Sub

    Private Sub TxPar2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar2.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar2.Text.Trim = "" Then
                TxLote2.Select()
                TxLote2.Focus()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            PanelTrazabilidad.Visible = False
            Siguiente(TxBul12.Orden)
        End If
    End Sub

    Private Sub TxPar3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar3.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar3.Text.Trim = "" Then
                TxLote3.Select()
                TxLote3.Focus()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            PanelTrazabilidad.Visible = False
            Siguiente(TxBul12.Orden)
        End If
    End Sub

    Private Sub TxPar4_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar4.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar4.Text.Trim = "" Then
                TxLote4.Select()
                TxLote4.Focus()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            PanelTrazabilidad.Visible = False
            Siguiente(TxBul12.Orden)
        End If
    End Sub

    Private Sub TxPar5_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar5.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar5.Text.Trim = "" Then
                TxLote5.Select()
                TxLote5.Focus()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            PanelTrazabilidad.Visible = False
            Siguiente(TxBul12.Orden)
        End If
    End Sub

    Private Sub TxPar6_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar6.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar6.Text.Trim = "" Then
                TxLote6.Select()
                TxLote6.Focus()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            PanelTrazabilidad.Visible = False
            Siguiente(TxBul12.Orden)
        End If
    End Sub

    Private Sub TxPar7_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar7.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar7.Text.Trim = "" Then
                TxLote7.Select()
                TxLote7.Focus()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            PanelTrazabilidad.Visible = False
            Siguiente(TxBul12.Orden)
        End If
    End Sub
    Private Sub TxPar8_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar8.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar8.Text.Trim = "" Then
                TxLote8.Select()
                TxLote8.Focus()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            PanelTrazabilidad.Visible = False
            Siguiente(TxBul12.Orden)
        End If

    End Sub
    Private Sub TxPar9_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar9.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar9.Text.Trim = "" Then
                TxLote9.Select()
                TxLote9.Focus()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            PanelTrazabilidad.Visible = False
            Siguiente(TxBul12.Orden)
        End If
    End Sub
    Private Sub TxPar10_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar10.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar10.Text.Trim = "" Then
                TxLote10.Select()
                TxLote10.Focus()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            PanelTrazabilidad.Visible = False
            Siguiente(TxBul12.Orden)
        End If
    End Sub

    Private Sub TxPar11_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar11.KeyDown

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar11.Text.Trim = "" Then
                TxLote11.Select()
                TxLote11.Focus()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            PanelTrazabilidad.Visible = False
            Siguiente(TxBul12.Orden)
        End If
    End Sub

    Private Sub TxPar12_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar12.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar12.Text.Trim = "" Then
                TxLote12.Select()
                TxLote12.Focus()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            PanelTrazabilidad.Visible = False
            Siguiente(TxBul12.Orden)

        End If
    End Sub

    Private Sub TxDato_18_EnabledChanged(sender As System.Object, e As System.EventArgs)

        HabilitarPanel(TxPxB.Enabled)

    End Sub

    Private Sub HabilitarPanel(bHabilitar As Boolean)

        TxPar1.Enabled = bHabilitar
        TxPar2.Enabled = bHabilitar
        TxPar3.Enabled = bHabilitar
        TxPar4.Enabled = bHabilitar
        TxPar5.Enabled = bHabilitar
        TxPar6.Enabled = bHabilitar
        TxPar7.Enabled = bHabilitar
        TxPar8.Enabled = bHabilitar
        TxPar9.Enabled = bHabilitar
        TxPar10.Enabled = bHabilitar
        TxPar11.Enabled = bHabilitar
        TxPar12.Enabled = bHabilitar


        TxBul1.Enabled = bHabilitar
        TxBul2.Enabled = bHabilitar
        TxBul3.Enabled = bHabilitar
        TxBul4.Enabled = bHabilitar
        TxBul5.Enabled = bHabilitar
        TxBul6.Enabled = bHabilitar
        TxBul7.Enabled = bHabilitar
        TxBul8.Enabled = bHabilitar
        TxBul9.Enabled = bHabilitar
        TxBul10.Enabled = bHabilitar
        TxBul11.Enabled = bHabilitar
        TxBul12.Enabled = bHabilitar


        BtSumakilos.Enabled = True

    End Sub


    Private Sub TxKilosBr_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxKilosBr.KeyDown

        If e.KeyCode = Keys.F2 Then

            Dim KgCliente As Decimal = VaDec(LbKilosSal.Text)
            Dim TaraLinea As Decimal = VaDec(LbTaraLinea.Text)
            Dim KgBrutos As Decimal = KgCliente + TaraLinea

            TxKilosBr.Text = KgBrutos.ToString("#,##0")

            Calculin()

        End If

    End Sub


    Private Sub TxPresentacion_Valida(edicion As Boolean) Handles TxPresentacion.Valida

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


            _bPesoFijo = ((GenerosSalida.GES_PesoFijo.Valor & "").Trim = "S")


            LbKxBPresentacion.Text = VaDec(GenerosSalida.GES_KilosXBulto.Valor).ToString("#,##0.00")
            If _bPesoFijo Then
                LbKxBPresentacion.ForeColor = Color.Green
            Else
                LbKxBPresentacion.ForeColor = Color.Red
            End If



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

                    If _bPesoFijo Then
                        TxKxB.Text = VaDec(GenerosSalida.GES_KilosXBulto.Valor).ToString("#,##0.00")
                    Else
                        TxKxB.Text = ""
                    End If



                    TxKxB.Validar(True)
                    TxPxB.Text = VaInt(GenerosSalida.GES_PiezasXBulto.Valor).ToString

                    If VaInt(_idlineapedido) = 0 Then

                        If VaInt(GenerosSalida.GES_idmarcaenvase.Valor) > 0 Then
                            TxMarca.Text = GenerosSalida.GES_idmarcaenvase.Valor
                            TxMarca.Validar(edicion)
                        End If
                        If VaInt(GenerosSalida.GES_idmarcamaterial.Valor) > 0 Then
                            TxMarcaMaterial.Text = GenerosSalida.GES_idmarcamaterial.Valor
                            TxMarcaMaterial.Validar(True)
                        End If
                        If VaInt(GenerosSalida.GES_idmarcaetiqueta.Valor) > 0 Then
                            TxMarcaEti.Text = GenerosSalida.GES_idmarcaetiqueta.Valor
                            TxMarcaEti.Validar(True)
                        End If

                    End If


                End If




                Dim dt As DataTable = GenerosSalida.LeerGensalida(TxGenero.Text, TxConfeccion.Text)

                If Not dt Is Nothing Then
                    If dt.Rows.Count = 1 Then
                        TxPresentacion.Text = dt.Rows(0)("GES_idgensal").ToString
                    End If
                End If


                If VaInt(TxBultos.Text) = 0 Then
                    Dim MaxBul As Integer = EnvasesPalets.MaxBultosPalet(TxConfeccion.Text, TxTipoPalet.Text)
                    If MaxBul > 0 Then
                        TxBultos.Text = MaxBul.ToString
                        TxBultos.Validar(True)
                    End If
                End If


            End If

        End If



    End Sub


    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)
        PanelTrazabilidad.Visible = False
    End Sub


    Private Sub BTentrada_Click(sender As System.Object, e As System.EventArgs) Handles BTentrada.Click
        If TxGenero.Enabled = False Then Exit Sub
        If TxGenero.Text = "" Then Exit Sub

        Dim DesdeFecha As String = FnLeft(DateAdd("D", -10, TxFecha.Text), 10)
        Dim Sql As String = ""
        Dim Consulta As New Cdatos.E_select
        Consulta.SelCampo(Albentrada_lineas.AEL_idlinea, "idlinea")
        Consulta.SelCampo(Albentrada.AEN_Albaran, "Albaran", Albentrada_lineas.AEL_idalbaran)
        Consulta.SelCampo(Albentrada.AEN_Fecha, "Fecha")
        Consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albentrada_lineas.AEL_idgenero)
        Consulta.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", Albentrada_lineas.AEL_idcategoria)
        Consulta.SelCampo(Albentrada_lineas.AEL_palets, "Palets")
        Consulta.SelCampo(Albentrada_lineas.AEL_bultos, "Bultos")
        Consulta.SelCampo(Albentrada_lineas.AEL_kilosnetos, "Kilos")
        Consulta.SelCampo(Albentrada_lineas.AEL_muestreo, "Partida")

        Consulta.WheCampo(Albentrada.AEN_EntradaConfeccionada, "=", "S")
        Consulta.WheCampo(Albentrada.AEN_IdCentro, "=", MiMaletin.IdCentro.ToString)
        Consulta.WheCampo(Albentrada.AEN_Fecha, ">=", DesdeFecha)
        If TxGenero.Text <> "" Then
            Consulta.WheCampo(Albentrada_lineas.AEL_idgenero, "=", TxGenero.Text)
        End If
        Sql = Consulta.SQL

        Dim lst As New List(Of Parametros)
        Dim dt As DataTable = Albentrada_lineas.MiConexion.ConsultaSQL(Sql)


        lst.Add(New Parametros("idlinea", False, "", -1))
        lst.Add(New Parametros("Genero", False, "", 200))
        lst.Add(New Parametros("Categoria", False, "", 100))
        lst.Add(New Parametros("Albaran", False, "", 100))
        lst.Add(New Parametros("Fecha", False, "", 100))
        lst.Add(New Parametros("Palets", False, "", 50))
        lst.Add(New Parametros("Bultos", False, "", 50))
        lst.Add(New Parametros("Kilos", False, "", 70))
        lst.Add(New Parametros("Partida", False, "", 100))



        Dim f As New FrConsultaGenerica(dt, lst, "Entradas directas")
        f.ShowDialog()
        If Not RowDePaso Is Nothing Then
            LbEntrConf.Text = RowDePaso("Albaran").ToString
            palets_lineas.PLL_idlineaentradaconfeccionada.Valor = RowDePaso("idlinea").ToString
            TxPar1.Text = RowDePaso("Partida".ToString)
        End If

    End Sub


    Private Sub TxObserva_EnabledChanged(sender As Object, e As System.EventArgs) Handles TxObserva.EnabledChanged
        HabilitarPanel(TxTipoPalet.Enabled)
    End Sub


    Private Sub TxDato3_Valida(edicion As Boolean) Handles TxObserva.Valida
        If edicion = True Then
            ' MuestraPanel()
        End If
    End Sub


    Private Sub TxLote1_Valida(edicion As Boolean) Handles TxLote1.Valida
        ValidaPartida(edicion, TxCampa1.Text, TxPar1.Text, 1, TxPar1, TxLote1, TxBul1, TxPreca1)
    End Sub


    Private Sub TxLote2_Valida(edicion As Boolean) Handles TxLote2.Valida
        ValidaPartida(edicion, TxCampa2.Text, TxPar2.Text, 2, TxPar2, TxLote2, TxBul2, TxPreca2)
    End Sub


    Private Sub TxLote3_Valida(edicion As Boolean) Handles TxLote3.Valida
        ValidaPartida(edicion, TxCampa3.Text, TxPar3.Text, 3, TxPar3, TxLote3, TxBul3, TxPreca3)
    End Sub


    Private Sub TxLote4_Valida(edicion As Boolean) Handles TxLote4.Valida
        ValidaPartida(edicion, TxCampa4.Text, TxPar4.Text, 4, TxPar4, TxLote4, TxBul4, TxPreca4)
    End Sub


    Private Sub TxLote5_Valida(edicion As Boolean) Handles TxLote5.Valida
        ValidaPartida(edicion, TxCampa5.Text, TxPar5.Text, 5, TxPar5, TxLote5, TxBul5, TxPreca5)
    End Sub


    Private Sub TxLote6_Valida(edicion As Boolean) Handles TxLote6.Valida
        ValidaPartida(edicion, TxCampa6.Text, TxPar6.Text, 6, TxPar6, TxLote6, TxBul6, TxPreca6)
    End Sub


    Private Sub TxLote7_Valida(edicion As Boolean) Handles TxLote7.Valida
        ValidaPartida(edicion, TxCampa7.Text, TxPar7.Text, 7, TxPar7, TxLote7, TxBul7, TxPreca7)
    End Sub


    Private Sub TxLote8_Valida(edicion As Boolean) Handles TxLote8.Valida
        ValidaPartida(edicion, TxCampa8.Text, TxPar8.Text, 8, TxPar8, TxLote8, TxBul8, TxPreca8)
    End Sub


    Private Sub TxLote9_Valida(edicion As Boolean) Handles TxLote9.Valida
        ValidaPartida(edicion, TxCampa9.Text, TxPar9.Text, 9, TxPar9, TxLote9, TxBul9, TxPreca9)
    End Sub


    Private Sub TxLote10_Valida(edicion As Boolean) Handles TxLote10.Valida
        ValidaPartida(edicion, TxCampa10.Text, TxPar10.Text, 10, TxPar10, TxLote10, TxBul10, TxPreca10)
    End Sub


    Private Sub TxLote11_Valida(edicion As Boolean) Handles TxLote11.Valida
        ValidaPartida(edicion, TxCampa11.Text, TxPar11.Text, 11, TxPar11, TxLote11, TxBul11, TxPreca11)
    End Sub

    Private Sub TxLote12_Valida(edicion As Boolean) Handles TxLote12.Valida
        ValidaPartida(edicion, TxCampa12.Text, TxPar12.Text, 12, TxPar12, TxLote12, TxBul12, TxPreca12)
    End Sub


    Private Sub TxLote12_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxLote12.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then

            PanelTrazabilidad.Visible = False
            Siguiente(TxBul12.Orden)
        End If

    End Sub


    Private Sub TxDato4_Valida(edicion As Boolean) Handles TxMatPropio.Valida
        If edicion = True Then
            If TxMatPropio.Text <> "N" Then
                TxMatPropio.Text = "S"
            End If
        End If

    End Sub


    Private Sub CargaDatosPedido()

        Dim Pedidos_lineas As New E_Pedidos_lineas(Idusuario, cn)
        Dim Pedidos As New E_Pedidos(Idusuario, cn)

        If Pedidos_lineas.LeerId(_idlineapedido) = True Then


            _IdCategoriaPedido = Pedidos_lineas.PEL_idcategoria.Valor & ""

            TxNuPalet.Text = "+"
            ControlClave()
            TxFecha.Text = Format(Now, "dd/MM/yyyy")
            TxEnvPropio.Text = "S"
            TxMatPropio.Text = "S"
            TxTipoPalet.Text = Pedidos_lineas.PEL_idtipopalet.Valor
            TxGenero.Text = Pedidos_lineas.PEL_idgenero.Valor


            Dim NumPedido As String = ""
            Dim IdCliente As String = ""
            CargaLineaPedido(NumPedido, IdCliente, _idlineapedido)



            If Pedidos_lineas.PEL_reservapalets.Valor = "S" Then
                LbIdPedidoLinea.Text = _idlineapedido
                LbPedido.Text = NumPedido
                TxCliente.Text = IdCliente
                TxCliente.Validar(False)
            Else
                LbIdPedidoLinea.Text = ""
                TxCliente.Text = IdCliente
                TxCliente.Validar(False)
            End If




            TxTipoPalet.Validar(True)
            TxGenero.Validar(True)
            TxCategoria.Validar(True)
            TxConfeccion.Validar(True)
            TxPresentacion.Validar(True)
            TxMarca.Validar(True)
            TxBultos.Validar(True)
            TxKxB.Validar(True)
            TxMarcaEti.Validar(True)
            TxMarcaMaterial.Validar(True)

            Me.BloquearCamposLineas(False, ClGrid1)
            TxCalidad.Focus()
            NuevoRegistro = True
            Modificando = True

            HabilitarPanel(True)
            _salirdespuesdeguardar = True

            TxCategoria.Select()
            TxCategoria.Focus()

        End If


    End Sub


    Private Sub CargaLineaPedido(ByRef NumPedido As String, ByRef IdCliente As String, ByVal IdLinea As String)

        Dim Pedidos_lineas As New E_Pedidos_lineas(Idusuario, cn)
        'Dim Pedidos As New E_Pedidos(Idusuario, cn)

        If Pedidos_lineas.LeerId(IdLinea) = True Then


            NumPedido = ""
            IdCliente = ""


            _IdCategoriaPedido = Pedidos_lineas.PEL_idcategoria.Valor & ""


            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(Pedidos_lineas.PEL_idpedido, "idpedido")
            consulta.SelCampo(Pedidos_lineas.PEL_idcategoria, "idcatcomercial")
            consulta.SelCampo(Pedidos.PED_pedido, "pedido", Pedidos_lineas.PEL_idpedido)
            consulta.SelCampo(Pedidos.PED_idcliente, "IdCliente")
            'consulta.SelCampo(Clientes.CLI_Nombre, "cliente", Pedidos.PED_idcliente)
            consulta.WheCampo(Pedidos_lineas.PEL_idlinea, "=", IdLinea)

            Dim sql As String = consulta.SQL
            Dim dt As DataTable = Pedidos.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                If dt.Rows.Count = 1 Then

                    NumPedido = dt.Rows(0)("pedido").ToString
                    IdCliente = dt.Rows(0)("IdCliente").ToString

                    sql = "Select CSC_idcatsalida from catsalidacomercial where CSC_idcatcomercial=" + dt.Rows(0)("idcatcomercial").ToString
                    Dim dtc As DataTable = CatSalidaComercial.MiConexion.ConsultaSQL(sql)

                    If Not dtc Is Nothing Then
                        If dtc.Rows.Count = 1 Then
                            TxCategoria.Text = dtc.Rows(0)("CSC_idcatsalida").ToString
                        ElseIf dtc.Rows.Count > 1 Then
                            AsociarControles(TxCategoria, BtBuscaCat, CategoriasSalida.BtBuscaComercial, CategoriasSalida, CategoriasSalida.CAS_CategoriaCalibre, Lb10)
                            BtBuscaCat.CL_Filtro = "idcomercial=" + dt.Rows(0)("idcatcomercial").ToString
                        End If
                    End If

                End If
            End If


            TxConfeccion.Text = Pedidos_lineas.PEL_idtipoconfeccion.Valor
            TxPresentacion.Text = Pedidos_lineas.PEL_idgensal.Valor
            TxMarca.Text = Pedidos_lineas.PEL_idmarca.Valor
            TxBultos.Text = Pedidos_lineas.PEL_bultospalet.Valor
            TxKxB.Text = Pedidos_lineas.PEL_kilosbulto.Valor
            TxPxB.Text = Pedidos_lineas.PEL_piezasbulto.Valor
            TxMarcaEti.Text = Pedidos_lineas.PEL_idmarcaetiqueta.Valor
            TxMarcaMaterial.Text = Pedidos_lineas.PEL_idmarcamaterial.Valor

        End If


    End Sub


    Public Sub InitPedido(IdlineaPedido As String)

        _idlineapedido = IdlineaPedido


        PintaPuntoVenta(MiMaletin.IdPuntoVenta)
        Lbejer.Text = MiMaletin.Ejercicio

        Me.Idinit = "+"

    End Sub


    'Private Sub TxNuPalet_GotFocus(sender As Object, e As System.EventArgs) Handles TxNuPalet.GotFocus
    '    If _idlineapedido <> "" Then
    '        CargaDatosPedido()
    '        _idlineapedido = ""
    '    End If
    'End Sub


    'Private Sub TxLpedido_Valida(edicion As Boolean)

    '    Dim pedidos_lineas As New E_Pedidos_lineas(Idusuario, cn)
    '    Dim pedidos As New E_Pedidos(Idusuario, cn)
    '    Dim Catsalidacomercial As New E_CatSalidaComercial(Idusuario, cn)


    '    LbPedido.Text = ""
    '    LbNomCli.Text = ""


    '    If _idlineapedido <> "" Then

    '        Dim consulta As New Cdatos.E_select
    '        consulta.SelCampo(pedidos_lineas.PEL_idpedido, "idpedido")
    '        consulta.SelCampo(pedidos_lineas.PEL_idcategoria, "idcatcomercial")
    '        consulta.SelCampo(pedidos.PED_pedido, "pedido", pedidos_lineas.PEL_idpedido)
    '        consulta.SelCampo(Clientes.CLI_Nombre, "cliente", pedidos.PED_idcliente)
    '        consulta.WheCampo(pedidos_lineas.PEL_idlinea, "=", _idlineapedido)

    '        Dim sql As String = consulta.SQL
    '        Dim dt As DataTable = pedidos.MiConexion.ConsultaSQL(sql)
    '        If Not dt Is Nothing Then
    '            If dt.Rows.Count = 1 Then
    '                LbPedido.Text = dt.Rows(0)("pedido").ToString
    '                LbNomCli.Text = dt.Rows(0)("cliente").ToString


    '                If edicion = True Then
    '                    sql = "Select CSC_idcatsalida from catsalidacomercial where CSC_idcatcomercial=" + dt.Rows(0)("idcatcomercial").ToString
    '                    Dim dtc As DataTable = Catsalidacomercial.MiConexion.ConsultaSQL(sql)
    '                    If Not dtc Is Nothing Then
    '                        If dtc.Rows.Count = 1 Then
    '                            TxCategoria.Text = dtc.Rows(0)("CSC_idcatsalida").ToString
    '                        ElseIf dtc.Rows.Count > 1 Then
    '                            AsociarControles(TxCategoria, BtBuscaCat, CategoriasSalida.BtBuscaComercial, CategoriasSalida, CategoriasSalida.CAS_CategoriaCalibre, Lb10)
    '                            BtBuscaCat.CL_Filtro = "idcatcomercial=" + dt.Rows(0)("idcatcomercial").ToString

    '                        End If
    '                    End If
    '                End If

    '            End If
    '        End If

    '        'If LbPedido.Text = "" Then
    '        '    LbIdPedidoLinea.MiError = True
    '        'End If


    '    End If

    'End Sub



    Private Sub TxCalidad_Valida(edicion As Boolean) Handles TxCalidad.Valida
        If TxCalidad.Text = "" Then
            TxCalidad.Text = "B"
        End If
    End Sub


    Private Sub TxPreca1_Valida(edicion As Boolean) Handles TxPreca1.Valida
        ValidaPartida(edicion, TxCampa1.Text, TxPar1.Text, 1, TxPar1, TxLote1, TxBul1, TxPreca1)
    End Sub


    Private Sub TxPreca2_Valida(edicion As Boolean) Handles TxPreca2.Valida
        ValidaPartida(edicion, TxCampa2.Text, TxPar2.Text, 2, TxPar2, TxLote2, TxBul2, TxPreca2)
    End Sub


    Private Sub TxPreca3_Valida(edicion As Boolean) Handles TxPreca3.Valida
        ValidaPartida(edicion, TxCampa3.Text, TxPar3.Text, 3, TxPar3, TxLote3, TxBul3, TxPreca3)
    End Sub


    Private Sub TxPreca4_Valida(edicion As Boolean) Handles TxPreca4.Valida
        ValidaPartida(edicion, TxCampa4.Text, TxPar4.Text, 4, TxPar4, TxLote4, TxBul4, TxPreca4)
    End Sub


    Private Sub TxPreca5_Valida(edicion As Boolean) Handles TxPreca5.Valida
        ValidaPartida(edicion, TxCampa5.Text, TxPar5.Text, 5, TxPar5, TxLote5, TxBul5, TxPreca5)
    End Sub


    Private Sub TxPreca6_Valida(edicion As Boolean) Handles TxPreca6.Valida
        ValidaPartida(edicion, TxCampa6.Text, TxPar6.Text, 6, TxPar6, TxLote6, TxBul6, TxPreca6)
    End Sub


    Private Sub TxPreca7_Valida(edicion As Boolean) Handles TxPreca7.Valida
        ValidaPartida(edicion, TxCampa7.Text, TxPar7.Text, 7, TxPar7, TxLote7, TxBul7, TxPreca7)
    End Sub


    Private Sub TxPreca8_Valida(edicion As Boolean) Handles TxPreca8.Valida
        ValidaPartida(edicion, TxCampa8.Text, TxPar8.Text, 8, TxPar8, TxLote8, TxBul8, TxPreca8)
    End Sub


    Private Sub TxPreca9_Valida(edicion As Boolean) Handles TxPreca9.Valida
        ValidaPartida(edicion, TxCampa9.Text, TxPar9.Text, 9, TxPar9, TxLote9, TxBul9, TxPreca9)
    End Sub


    Private Sub TxPreca10_Valida(edicion As Boolean) Handles TxPreca10.Valida
        ValidaPartida(edicion, TxCampa10.Text, TxPar10.Text, 10, TxPar10, TxLote10, TxBul10, TxPreca10)
    End Sub


    Private Sub TxPreca11_Valida(edicion As Boolean) Handles TxPreca11.Valida
        ValidaPartida(edicion, TxCampa11.Text, TxPar11.Text, 11, TxPar11, TxLote11, TxBul11, TxPreca11)
    End Sub


    Private Sub TxPreca12_Valida(edicion As Boolean) Handles TxPreca12.Valida
        ValidaPartida(edicion, TxCampa12.Text, TxPar12.Text, 12, TxPar12, TxLote12, TxBul12, TxPreca12)
    End Sub


    Private Sub TxControlado_Valida(edicion As System.Boolean) Handles TxControlado.Valida
        If edicion Then

            If TxControlado.Text <> "S" Then TxControlado.Text = "N"

        End If
    End Sub

    Private Sub TxBultos_Valida(edicion As System.Boolean) Handles TxBultos.Valida

        If edicion Then

            Dim MaxBul As Integer = EnvasesPalets.MaxBultosPalet(TxConfeccion.Text, TxTipoPalet.Text)
            If MaxBul > 0 And VaInt(TxBultos.Text) > MaxBul Then
                MsgBox("Bultos incorrectos para este palet")
                TxBultos.MiError = True
            End If

            If VaInt(TxKilosBr.Text) = 0 Then

                Calculin()
                CalculaTaras()

                Dim KgCliente As Decimal = VaDec(LbKilosSal.Text)
                Dim TaraLinea As Decimal = VaDec(LbTaraLinea.Text)
                Dim KgBrutos As Decimal = KgCliente + VaDec(LbTaraLinea.Text)

                TxKilosBr.Text = KgBrutos.ToString("#,##0")

                Calculin()

            End If
        End If

    End Sub


    Private Sub btImprimirRFID_Click(sender As System.Object, e As System.EventArgs) Handles btImprimirRFID.Click
        If Val(LbId.Text) > 0 Then
            If palets.PAL_finalizado.Valor = "N" Then
                MsgBox("Palet sin terminar")
            Else
                ImprimirPaletRFID(LbId.Text)
            End If
        End If
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click


        If VaInt(LbIdPedidoLinea.Text) > 0 Then
            If XtraMessageBox.Show("¿Desea desasignar el pedido?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                LbIdPedidoLinea.Text = ""
                LbPedido.Text = ""
                'TxCliente.Text = ""

                Dim row As DataRow = ClGrid1.GridView.GetFocusedDataRow()
                If Not IsNothing(row) Then
                    Dim IdLinea As String = (row("PLL_IdLinea").ToString & "").Trim
                    If VaDec(IdLinea) > 0 Then
                        Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
                        If Palets_Lineas.LeerId(IdLinea) Then
                            Palets_Lineas.PLL_idpedidolinea.Valor = "0"
                            'Palets_Lineas.PLL_IdCliente.Valor = "0"
                            Palets_Lineas.Actualizar()
                        End If
                    End If
                End If


            End If
        Else
            Dim Consulta As New Cdatos.E_select
            Consulta.SelCampo(Pedidos_Lineas.PEL_idlinea, "IdLinea")
            Consulta.SelCampo(Pedidos.PED_pedido, "Pedido", Pedidos_Lineas.PEL_idpedido, Pedidos.PED_idpedido)
            Consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", Pedidos.PED_idcliente)
            Consulta.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", Pedidos_Lineas.PEL_idgensal)
            Consulta.SelCampo(CategoriasComercial.CAC_Nombre, "Categoria", Pedidos_Lineas.PEL_idcategoria)
            If TxGenero.Text <> "" Then
                Consulta.WheCampo(Pedidos_Lineas.PEL_idgenero, "=", TxGenero.Text)
            End If
            If TxFecha.Text <> "" Then
                Consulta.WheCampo(Pedidos.PED_fechasalida, "=", TxFecha.Text)
            End If


            Dim lst As New List(Of Parametros)
            Dim dt As DataTable = palets.MiConexion.ConsultaSQL(Consulta.SQL)
            lst.Add(New Parametros("idlinea", False, "", -1))
            lst.Add(New Parametros("Pedido", False, "", 60))
            lst.Add(New Parametros("Cliente", False, "", 300))
            lst.Add(New Parametros("Presentacion", False, "", 220))
            lst.Add(New Parametros("Categoria", False, "", 80))

            Dim f As New FrConsultaGenerica(dt, lst, "Pedidos")
            f.ShowDialog()
            If Not RowDePaso Is Nothing Then

                Dim IdLinea As String = (RowDePaso("Idlinea").ToString & "").Trim
                Dim NumPedido As String = ""
                Dim IdCliente As String = ""

                CargaLineaPedido(NumPedido, IdCliente, IdLinea)

                LbIdPedidoLinea.Text = IdLinea
                LbPedido.Text = NumPedido
                TxCliente.Text = IdCliente
                TxCliente.Validar(True)

            End If
        End If



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles BtTerminado.Click

        If BtTerminado.Text = "PALET TERMINADO" Then
            BtTerminado.Text = "SIN TERMINAR"
            BtTerminado.ForeColor = Color.Red
        Else
            BtTerminado.Text = "PALET TERMINADO"
            BtTerminado.ForeColor = Color.Green
        End If
    End Sub


    Private Sub TxBul1_Valida(edicion As System.Boolean) Handles TxBul1.Valida
        TxBul1.Siguiente = TxPar2.Orden
        CompruebaBultos(TxBul1)
        If edicion Then
            If Not TxBul1.MiError Then
                TxCampa2.Text = Lbejer.Text
            End If
        End If
    End Sub
    Private Sub TxBul2_Valida(edicion As System.Boolean) Handles TxBul2.Valida
        TxBul2.Siguiente = TxPar3.Orden
        CompruebaBultos(TxBul2)
        If edicion Then
            If Not TxBul2.MiError Then
                TxCampa3.Text = Lbejer.Text
            End If
        End If
    End Sub
    Private Sub TxBul3_Valida(edicion As System.Boolean) Handles TxBul3.Valida
        TxBul3.Siguiente = TxPar4.Orden
        CompruebaBultos(TxBul3)
        If edicion Then
            If Not TxBul3.MiError Then
                TxCampa4.Text = Lbejer.Text
            End If
        End If
    End Sub
    Private Sub TxBul4_Valida(edicion As System.Boolean) Handles TxBul4.Valida
        TxBul4.Siguiente = TxPar5.Orden
        CompruebaBultos(TxBul4)
        If edicion Then
            If Not TxBul4.MiError Then
                TxCampa5.Text = Lbejer.Text
            End If
        End If
    End Sub
    Private Sub TxBul5_Valida(edicion As System.Boolean) Handles TxBul5.Valida
        TxBul5.Siguiente = TxPar6.Orden
        CompruebaBultos(TxBul5)
        If edicion Then
            If Not TxBul5.MiError Then
                TxCampa6.Text = Lbejer.Text
            End If
        End If
    End Sub
    Private Sub TxBul6_Valida(edicion As System.Boolean) Handles TxBul6.Valida
        TxBul6.Siguiente = TxPar7.Orden
        CompruebaBultos(TxBul6)
        If edicion Then
            If Not TxBul6.MiError Then
                TxCampa7.Text = Lbejer.Text
            End If
        End If
    End Sub
    Private Sub TxBul7_Valida(edicion As System.Boolean) Handles TxBul7.Valida
        TxBul7.Siguiente = TxPar8.Orden
        CompruebaBultos(TxBul7)
        If edicion Then
            If Not TxBul7.MiError Then
                TxCampa8.Text = Lbejer.Text
            End If
        End If
    End Sub
    Private Sub TxBul8_Valida(edicion As System.Boolean) Handles TxBul8.Valida
        TxBul8.Siguiente = TxPar9.Orden
        CompruebaBultos(TxBul8)
        If edicion Then
            If Not TxBul8.MiError Then
                TxCampa9.Text = Lbejer.Text
            End If
        End If
    End Sub
    Private Sub TxBul9_Valida(edicion As System.Boolean) Handles TxBul9.Valida
        TxBul9.Siguiente = TxPar10.Orden
        CompruebaBultos(TxBul9)
        If edicion Then
            If Not TxBul9.MiError Then
                TxCampa10.Text = Lbejer.Text
            End If
        End If
    End Sub
    Private Sub TxBul10_Valida(edicion As System.Boolean) Handles TxBul10.Valida
        TxBul10.Siguiente = TxPar11.Orden
        CompruebaBultos(TxBul10)
        If edicion Then
            If Not TxBul10.MiError Then
                TxCampa11.Text = Lbejer.Text
            End If
        End If
    End Sub
    Private Sub TxBul11_Valida(edicion As System.Boolean) Handles TxBul11.Valida
        TxBul11.Siguiente = TxPar12.Orden
        CompruebaBultos(TxBul11)
        If edicion Then
            If Not TxBul11.MiError Then
                TxCampa12.Text = Lbejer.Text
            End If
        End If
    End Sub
    Private Sub TxBul12_Valida(edicion As System.Boolean) Handles TxBul12.Valida
        CompruebaBultos(TxBul12)

        If edicion Then
            If Not TxBul12.MiError Then
                PanelTrazabilidad.Visible = False
            End If
        End If

    End Sub



    Private Function CompruebaBultos(tx As TxDato) As Boolean

        Dim bRes As Boolean = True


        Dim TotalBultos As Decimal = VaDec(TxBultos.Text)

        Dim TotalTraza As Decimal = VaDec(TxBul1.Text)
        TotalTraza = TotalTraza + VaDec(TxBul2.Text)

        TotalTraza = TotalTraza + VaDec(TxBul3.Text)
        TotalTraza = TotalTraza + VaDec(TxBul4.Text)
        TotalTraza = TotalTraza + VaDec(TxBul5.Text)
        TotalTraza = TotalTraza + VaDec(TxBul6.Text)
        TotalTraza = TotalTraza + VaDec(TxBul7.Text)
        TotalTraza = TotalTraza + VaDec(TxBul8.Text)
        TotalTraza = TotalTraza + VaDec(TxBul9.Text)
        TotalTraza = TotalTraza + VaDec(TxBul10.Text)
        TotalTraza = TotalTraza + VaDec(TxBul11.Text)
        TotalTraza = TotalTraza + VaDec(TxBul12.Text)

        If TotalTraza > TotalBultos Then

            MsgBox("El total de los bultos introducidos en la trazabilidad no puede ser superior al total de bultos del palet")
            tx.MiError = True
            tx.Select()
            tx.Focus()

            bRes = False

        End If


        Return bRes

    End Function


    Private Sub btCartelon_Click(sender As System.Object, e As System.EventArgs) Handles btCartelon.Click

        'pll_idlinea
        Dim row As DataRow = ClGrid1.GridView.GetFocusedDataRow()
        If Not IsNothing(row) Then
            Dim IdLinea As String = (row("PLL_IdLinea").ToString & "").Trim
            If VaInt(IdLinea) > 0 Then

                Dim frm As New FrmCartelones
                frm.InitPalet(IdLinea)
                frm.ShowDialog()

            End If
        End If

    End Sub


    Private Sub TxPar1_AntesDeValidar(edicion As System.Boolean) Handles TxPar1.AntesDeValidar
        If edicion Then ValidaCodigo(TxPar1, TxCampa1.Text)
    End Sub




    Private Sub ValidaCodigo(Tx As TxDato, TxCampa As String)

        Dim datos As String() = Split(Tx.Text, ".")
        If datos.Length = 2 Then


            Dim campa As String = datos(0)
            Dim numero As String = datos(1)

            If campa.StartsWith("PA") Then
                campa = campa.Replace("PA", "")
            End If


            If VaInt(campa) <> VaInt(TxCampa) Then
                MsgBox("Campaña no válida")
                Tx.Text = ""
                Exit Sub
            End If

            Tx.Text = numero


        End If

    End Sub


    Private Sub BtTerminado_TextChanged(sender As System.Object, e As System.EventArgs) Handles BtTerminado.TextChanged
        LoteObligatorio()
    End Sub


    Private Sub LoteObligatorio()

        If Not IsNothing(TxLote.ClParam) Then
            If BtTerminado.Text = "PALET TERMINADO" Then

                Dim DesglosarLotes As String = (Clientes.CLI_DesglosarLotes.Valor & "").Trim
                If DesglosarLotes = "S" Then
                    TxLote.ClParam.Obligatorio = True
                Else
                    TxLote.ClParam.Obligatorio = False
                End If
            Else
                TxLote.ClParam.Obligatorio = False
            End If
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        'MyBase.BotonAuxiliar2()


        If VaInt(LbId.Text) > 0 Then


            'If LbNumAlb.Text <> "" And Not _bVieneDeCargaPalets Then       'Manolo 12/02/2020
            '    MsgBox("Palet cargado")
            '    Exit Sub
            'End If


            Dim frm As New FrmIntroducirLote(LbId.Text, TxLote.Text)
            frm.ShowDialog()

            If frm.ResultadoFormulario = FrmIntroducirLote.Resultado.Aceptar Then
                Dim Palet As String = TxNuPalet.Text
                BorraPan()
                TxNuPalet.Text = Palet
                Siguiente(TxNuPalet.Orden)
            End If

        End If

    End Sub


    Public Overrides Sub BotonAuxiliar3()
        'MyBase.BotonAuxiliar3()

        If VaInt(LbId.Text) Then
            Dim frm As New FrmIntroducirGGNPalet(LbId.Text, TxCliente.Text)
            frm.init(LbId.Text)
            frm.ShowDialog()
        End If

    End Sub

    Private Sub ClGrid1_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles ClGrid1.RowCellStyle

        If e.Column.FieldName.ToUpper.Trim = "ENTCONF" Then

            e.Appearance.ForeColor = Color.Red

        End If

    End Sub


    Private Sub TxCampa_Enter(sender As System.Object, e As System.EventArgs) Handles TxCampa1.Enter, TxCampa2.Enter, TxCampa3.Enter, TxCampa4.Enter, TxCampa5.Enter, TxCampa6.Enter, TxCampa7.Enter, TxCampa8.Enter, TxCampa9.Enter, TxCampa10.Enter, TxCampa11.Enter, TxCampa12.Enter
        If NuevoRegistro Or Modificando Then
            Dim Txcampa As TxDato = CType(sender, TxDato)
            If Txcampa.Text.Trim = "" Then
                Txcampa.Text = Lbejer.Text
            End If
        End If
    End Sub

    
    Private Sub TxCampa_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxCampa9.KeyDown, TxCampa8.KeyDown, TxCampa7.KeyDown, TxCampa6.KeyDown, TxCampa5.KeyDown, TxCampa4.KeyDown, TxCampa3.KeyDown, TxCampa2.KeyDown, TxCampa12.KeyDown, TxCampa11.KeyDown, TxCampa10.KeyDown, TxCampa1.KeyDown

        If e.KeyCode = Keys.F12 Then
            PanelTrazabilidad.Visible = False
            Siguiente(TxBul12.Orden)
        End If

    End Sub


    Private Sub TxCampa2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxCampa2.TextChanged

        If TxCampa2.Text <> "19" Then
            Dim a As String = ""
        End If

    End Sub

End Class