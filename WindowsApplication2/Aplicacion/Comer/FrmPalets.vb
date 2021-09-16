Imports DevExpress.XtraEditors


Public Class FrmPalets


    Inherits FrMantenimiento

    Dim palets As New E_palets(Idusuario, cn)
    Dim palets_lineas As New E_palets_lineas(Idusuario, cn)
    Dim palets_traza As New E_palets_traza(Idusuario, cn)
    Dim albsalida_palets As New E_albsalida_palets(Idusuario, cn)
    Dim albsalida As New E_AlbSalida(Idusuario, cn)


    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Confecpalet As New E_ConfecPalet(Idusuario, cn)
    Dim Confecenvase As New E_ConfecEnvase(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim partidascompra As New E_PartidasCompra(Idusuario, cn)
    Dim FamiliasCategorias As New E_FamiliasCategorias(Idusuario, cn)
    Dim Subfamilias As New E_Subfamilias(Idusuario, cn)



    Dim PuntoVenta As New E_PuntoVenta(Idusuario, CnCtb)
    Dim MiCentro As String
    Dim MiCampa As String
    Dim idpartida As String
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim IdLineaGrid As String = ""
    Dim IdCargaAlb As String



    Private Sub ParametrosFrm()

        EntidadFrm = palets


        Dim lc As New List(Of Object)
        ListaControles = lc

        LbPuntoVenta.CL_ControlAsociado = TxDato_1
        LbNomPv.CL_ControlAsociado = TxDato_1
        CampoClave = 0 ' ultimo campo de la clave

        ParamTx(TxDato_1, palets.PAL_palet, Lb_1, True)
        TxDato_1.Autonumerico = True
        ParamTx(TxDato_2, palets.PAL_fecha, Lb_2, True)
        ParamTx(TxDato_3, palets.PAL_idtipopalet, Lb_3, False, Cdatos.TiposCampo.Cadena, 0, 40)
        ParamTx(TxDato_4, palets.PAL_tarapalet, Lb_4, False)
        ParamTx(TxDato_5, palets.PAL_envasepropio, Lb_5, False)
        ParamTx(TxDato22, palets.PAL_idcliente, Lb63, False)
        ParamTx(TxDato1, palets.PAL_idclientesalida, Lb2, False)




        ParamTx(TxDato_10, palets_lineas.PLL_idgenero, Lb_10, True)
        ParamTx(TxDato_11, palets_lineas.PLL_idtipoconfeccion, Lb_11, False)
        ParamTx(TxDato_12, palets_lineas.PLL_idcategoria, Lb_12, False)
        ParamTx(TxDato_15, palets_lineas.PLL_categoria, Lb_12, False)
        ParamTx(TxDato_13, palets_lineas.PLL_idmarca, Lb_13, False)
        ParamTx(TxDato_14, palets_lineas.PLL_bultos, Lb_14, False)
        ParamTx(TxDato_16, palets_lineas.PLL_kilosxbulto, Lb_16, False)
        ParamTx(TxDato_17, palets_lineas.PLL_kilosbrutos, Lb_17, False)
        ParamTx(TxDato_18, palets_lineas.PLL_piezasxbulto, Lb_18, False)


        ParamTx(TxDato_30, Nothing, Lb_30, True)
        ParamTx(TxDato_31, palets_traza.PLT_bultos, Lb_31, True)

        ParamTx(TxDato_40, palets_lineas.PLL_calidad, Lb_40, , , , , "AB")


        AsociarControles(TxDato_1, BtBuscaAlbaran, palets.btBusca, palets)
        AsociarControles(TxDato22, BtBuscaCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb62)
        AsociarControles(TxDato1, BtBuscaCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb1)

        AsociarGrid(ClGrid1, TxDato_10, TxDato_40, palets_lineas)
        AsociarGrid(ClGrid2, TxDato_30, TxDato_31, palets_traza)

        PropiedadesCamposGr(ClGrid1, "PLL_idlinea", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 10)
        PropiedadesCamposGr(ClGrid1, "Producto", "Producto", True, 50)
        PropiedadesCamposGr(ClGrid1, "Confeccion", "Confeccion", True, 50)
        PropiedadesCamposGr(ClGrid1, "Bultos", "Bultos", True, 10, True)


        PropiedadesCamposGr(ClGrid2, "PLT_idtraza", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid2, "Partida", "Partida", True, 10)
        PropiedadesCamposGr(ClGrid2, "Producto", "Producto", True, 50)
        PropiedadesCamposGr(ClGrid2, "Agricultor", "Agricultor", True, 50)
        PropiedadesCamposGr(ClGrid2, "Bultos", "Bultos", True, 10, True)


        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False





        AsociarControles(TxDato_3, BtBuscaTipopalet, Confecpalet.btBusca, Confecpalet, Confecpalet.CPA_Nombre, LbNomPalet)

        AsociarControles(TxDato_10, BtBuscaGenero, Generos.btBusca, Generos, Generos.GEN_NombreGenero, Lb4)
        AsociarControles(TxDato_11, BtBuscaConfec, GenerosSalida.btBusca, Confecenvase, Confecenvase.CEV_Nombre, Lb24)
        AsociarControles(TxDato_12, BtBuscaCat, CategoriasSalida.BtBuscaSal, CategoriasSalida, CategoriasSalida.CAS_CategoriaCalibre, Lb10)
        AsociarControles(TxDato_13, BtBuscaMarca, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, Lb31)


        ' BotonesAvance1.Mientidad = EntidadFrm
        ' BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        ' BotonesAvance1.Formulario = Me

        MiCampa = MiMaletin.Ejercicio


        tt.SetToolTip(BtNuevo, "Nuevo")
        tt.SetToolTip(BtGastosGenerales, "Desglose de gastos generales de palet")
        tt.SetToolTip(BtGastosLineas, "Desglose de gastos de las líneas de palet")

        FiltroEntidad.Add(palets.PAL_campa.NombreCampo, MiMaletin.Ejercicio.ToString)


    End Sub

    Public Sub InitAlb(ByVal Idalb As String)
        IdCargaAlb = Idalb

    End Sub


    Private Sub FrmPalets_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BTaux1.Visible = True
        BTaux1.Text = "Imprimir ticket"
        BTaux1.Width = 100
        BTaux1.Image = NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32

    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave

        Dim i As Integer
        If TxDato_1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = palets.Leerpalet(Lbejer.Text, TxDato_1.Text)
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

        '        If VaInt(AlbSalidaAlh.idfactura.Valor) > 0 Then
        ' If facturas.LeerId(AlbSalidaAlh.idfactura.Valor) = True Then
        ' LbNumAlm.Text = facturas.serie.Valor + " " + facturas.factura.Valor
        ' End If
        ' End If

        NumeroAlbaran()


        ' llenar el grid
        CargaLineasGrid()
    End Sub
    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)



        Dim Idpartida As String = ""

        If Grid Is ClGrid2 Then

            Idpartida = VaInt(palets_traza.PLT_idpartida.Valor)
            If partidascompra.LeerId(Idpartida) = True Then
                TxDato_30.Text = partidascompra.PAR_muestreo.Valor
                DatosPartida(TxDato_30.Text)
            End If

        Else
            IdLineaGrid = palets_lineas.PLL_idlinea.Valor

            SqlGrid2(palets_lineas.PLL_idlinea.Valor)
            Lbkilosnetos.Text = palets_lineas.PLL_kilosnetos.Valor
            LbKilosSal.Text = palets_lineas.PLL_kiloscliente.Valor
            Cargalineas(ClGrid2)
        End If
        MyBase.Entidad_a_DatosLin(Grid)
    End Sub
    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean
        Dim i As String
        If Gr Is ClGrid1 Then


            If LbId.Text = "+" Then
                LbId.Text = palets.MaxId
                If TxDato_1.Text = "+" Then
                    TxDato_1.Text = palets.MaxIdCampa(Lbejer.Text)
                End If
            End If
            palets.PAL_idpalet.Valor = LbId.Text
            palets.PAL_campa.Valor = Lbejer.Text
            palets.PAL_idpuntoventa.Valor = LbPuntoVenta.Text
            palets.PAL_idcentro.Valor = MiCentro
            palets.PAL_idpalet.Valor = LbId.Text
            palets_lineas.PLL_idpalet.Valor = LbId.Text
            palets_lineas.PLL_kilosnetos.Valor = Lbkilosnetos.Text
            palets_lineas.PLL_kiloscliente.Valor = LbKilosSal.Text


            SqlGrid()
        Else
            ClGrid1.MismaLinea = True ' para que no cambie la linea
            i = ClGrid1.IdLinea
            If VaInt(i) = 0 Then
                GuardarLineas(ClGrid1) ' grabo la linea del primer grid al insertar
                i = ClGrid1.IdLinea
            End If
            palets_traza.PLT_idlineapalet.Valor = i
            palets_traza.PLT_idpartida.Valor = idpartida
            SqlGrid2(palets_lineas.PLL_idlinea.Valor)
        End If

        r = MyBase.GuardarLineas(Gr)

        Return r

    End Function

    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()
    End Sub

    Private Sub CargaLineasGrid()
        SqlGrid()

        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)

        SqlGrid2(palets_lineas.PLL_idlinea.Valor)
        ClGrid2.Nlinea = -1
        Cargalineas(ClGrid2)

        CalculoTotales()
    End Sub

    Private Sub CalculoTotales()

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

        CONSULTA.SelCampo(palets_lineas.PLL_idlinea)
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Producto", palets_lineas.PLL_idgenero)
        CONSULTA.SelCampo(Confecenvase.CEV_Nombre, "Confeccion", palets_lineas.PLL_idtipoconfeccion)
        CONSULTA.SelCampo(palets_lineas.PLL_bultos, "Bultos")
        CONSULTA.SelCampo(palets_lineas.PLL_kilosbrutos, "Kilos")
        CONSULTA.WheCampo(palets_lineas.PLL_idpalet, "=", id)
        sql = CONSULTA.SQL
        sql = sql + " order by PLL_idlinea"



        ClGrid1.Consulta = sql


    End Sub

    Private Sub SqlGrid2(ByVal Idlineapalet As String)
        Dim CONSULTA2 As New Cdatos.E_select
        Dim sql As String
        Dim ID As String

        If Val(Idlineapalet) = 0 Then
            ID = "-1"
        Else
            ID = Idlineapalet
        End If


        'sql = " Select PLT_idtraza, "
        'sql = sql + " AEL_muestreo AS Partida, "
        'sql = sql + " AEN_campa AS Campa, "
        'sql = sql + " PAR_idgenero AS idgenero, "
        'sql = sql + " PAR_idagricultor AS IdAgricultor, "
        'sql = sql + " AGR_Nombre AS Agricultor, "
        'sql = sql + " Generos.GEN_NombreGenero AS Producto, "
        'sql = sql + " PLT_bultos AS Bultos from palets_traza"
        'sql = sql + " LEFT OUTER JOIN AlbEntrada_lineas ON PLT_idLineaentrada = AEL_idlinea"
        'sql = sql + " LEFT OUTER JOIN AlbEntrada ON AEL_idalbaran = AEN_idalbaran"
        'sql = sql + " LEFT OUTER JOIN PartidasCompra ON AEL_muestreo = PAR_muestreo and AEN_campa=PAR_campa"
        'sql = sql + " LEFT OUTER JOIN Agricultores ON PAR_idagricultor = AGR_Idagricultor"
        'sql = sql + " LEFT OUTER JOIN Generos ON PAR_idgenero = GEN_IdGenero"
        'sql = sql + " where palets_traza.PLT_idlineapalet =" + ID + "  order by PLT_IdTraza"


        sql = " Select PLT_idtraza, "
        sql = sql + " PAR_muestreo AS Partida, "
        sql = sql + " PAR_idgenero AS idgenero, "
        sql = sql + " PAR_idagricultor AS IdAgricultor, "
        sql = sql + " AGR_Nombre AS Agricultor, "
        sql = sql + " Generos.GEN_NombreGenero AS Producto, "
        sql = sql + " PLT_bultos AS Bultos from palets_traza"
        sql = sql + " LEFT OUTER JOIN PartidasCompra ON PLT_idpartida = PAR_id"
        sql = sql + " LEFT OUTER JOIN Agricultores ON PAR_idagricultor = AGR_Idagricultor"
        sql = sql + " LEFT OUTER JOIN Generos ON PAR_idgenero = GEN_IdGenero"
        sql = sql + " where palets_traza.PLT_idlineapalet =" + ID + "  order by PLT_IdTraza"


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
            MsgBox("no se puede modificar el palet")
            Exit Sub
        End If

        If LbNumAlb.Text <> "" Then
            MsgBox("Palet cargado")
            Exit Sub
        End If



        MyBase.BAnular_Click(sender, e)
    End Sub
    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString Then
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
        If gr Is ClGrid1 Then

            'ClGrid2.Grid.DataSource = Nothing
            SqlGrid2(-1)
            Cargalineas(ClGrid2)

            LbKilosSal.Text = ""
            Lbkilosnetos.Text = ""
            lbpiezas.Text = ""

        End If

        IdLineaGrid = ""
        LbGeneroPar.Text = ""
        LbNomAgri.Text = ""
        LbNomGeneroPar.Text = ""
        LbKilosPar.Text = ""

        MyBase.Borralin(gr)
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        PintaPuntoVenta(MiMaletin.IdPuntoVenta)
        Lbejer.Text = MiMaletin.Ejercicio
        IdCargaAlb = ""

    End Sub


    Public Overrides Sub DespuesdeCargarLineas(ByVal gr As ClGrid)

        MyBase.DespuesdeCargarLineas(gr)

    End Sub


    Public Overrides Sub Guardar()

        palets.PAL_idpuntoventa.Valor = LbPuntoVenta.Text
        palets.PAL_campa.Valor = Lbejer.Text
        palets.PAL_idcentro.Valor = MiCentro


        Dim bImprimir As Boolean = NuevoRegistro
        If Modificando And Not NuevoRegistro Then
            If XtraMessageBox.Show("¿Desea imprimir el ticket del palet?", "Imprimir Ticket", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                bImprimir = True
            End If
        End If

        Dim IdPalet As String = LbId.Text

        MyBase.Guardar()


        If bImprimir Then
            If VaDec(IdPalet) > 0 Then

                Dim impresora As New Printing.PrinterSettings
                ImprimirTicketPalet(IdPalet, TipoImpresion.ImpresoraPorDefecto, False, impresora.PrinterName, "", "")

            End If
        End If


    End Sub



    Private Sub DatosPartida(ByVal Nupartida As String)
        Dim IdAgricultor As String = ""
        Dim IdGenero As String = ""
        Dim Kilos As String = ""
        Dim idcategoria As String = ""
        Dim id As String
        LbNomAgri.Text = ""
        LbNomGeneroPar.Text = ""
        LbKilosPar.Text = ""
        id = partidascompra.DatosPartida(Lbejer.Text, Nupartida, IdAgricultor, IdGenero, idcategoria, Kilos)
        If Val(id) > 0 Then
            If Agricultores.LeerId(IdAgricultor) Then
                LbNomAgri.Text = Agricultores.AGR_Nombre.Valor
            End If
            LbGeneroPar.Text = IdGenero
            If Generos.LeerId(LbGeneroPar.Text) = True Then
                LbNomGeneroPar.Text = Generos.GEN_NombreGenero.Valor
            End If
            LbKilosPar.Text = Kilos
        End If
    End Sub






    Private Sub TxDato_30_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_30.TextChanged

    End Sub

    Private Sub TxDato_30_Valida(ByVal edicion As Boolean) Handles TxDato_30.Valida
        If edicion = True Then
            Dim IdLineaEntrada As String = Albentrada_lineas.LeerMuestreo(MiCampa, TxDato_30.Text, MiCentro)
            If VaInt(IdLineaEntrada) = 0 Then
                MsgBox("La partida no está en el centro")
                ' TxDato_30.MiError = True
                'Exit Sub
            End If
        End If
        idpartida = partidascompra.LeerMuestreo(MiCampa, TxDato_30.Text)
        If idpartida > 0 Then
            'partidas.LeerId(idpartida)
            DatosPartida(TxDato_30.Text)
        Else
            MsgBox("La partida no existe")
            TxDato_30.MiError = True

        End If


    End Sub

    Private Sub Calculin()
        Dim Tarapalet As Double = VaDec(TxDato_4.Text)
        Dim taraenvase As Double = VaDec(TxDato_14.Text) * VaDec(LbTaraEnvase.Text)
        Dim l As Integer = ClGrid1.GridView.FocusedRowHandle
        If l > 1 Then
            Tarapalet = 0
        End If
        If ChTara.CheckState = CheckState.Checked Then
            Tarapalet = 0
            taraenvase = 0
        End If
        Dim ks As Double = VaDec(TxDato_14.Text) * VaDec(TxDato_16.Text)
        Dim kn As Double = VaDec(TxDato_17.Text) - Tarapalet - taraenvase
        Lbkilosnetos.Text = Format(kn, "#,###")
        If ks = 0 Then
            ks = kn
        End If
        LbKilosSal.Text = Format(ks, "#,###")
        lbpiezas.Text = Format(VaDec(TxDato_14.Text) * VaDec(TxDato_18.Text), "#,###")
    End Sub

    Private Sub TxDato_11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_11.TextChanged

    End Sub

    Private Sub TxDato_11_Valida(ByVal edicion As Boolean) Handles TxDato_11.Valida
        'If edicion = True Then
        Dim Confecenvase As New E_ConfecEnvase(Idusuario, cn)
        If Confecenvase.LeerId(TxDato_11.Text) = True Then
            LbTaraEnvase.Text = Confecenvase.CEV_TotalTara.Valor
        End If
        'End If

    End Sub

    Private Sub TxDato_12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_12.TextChanged

    End Sub

    Private Sub TxDato_12_Valida(ByVal edicion As Boolean) Handles TxDato_12.Valida
        If edicion = True Then
            If TxDato_15.Text = "" Then
                TxDato_15.Text = Lb10.Text
            End If
        End If
    End Sub

    Private Sub TxDato_16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_16.TextChanged

    End Sub

    Private Sub TxDato_16_Valida(ByVal edicion As Boolean) Handles TxDato_16.Valida
        If edicion = True Then
            Calculin()
        End If
    End Sub

    Private Sub TxDato_17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_17.TextChanged

    End Sub

    Private Sub TxDato_17_Valida(ByVal edicion As Boolean) Handles TxDato_17.Valida
        If edicion = True Then
            Calculin()

        End If
    End Sub

    Private Sub TxDato_18_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_18.TextChanged

    End Sub

    Private Sub TxDato_18_Valida(ByVal edicion As Boolean) Handles TxDato_18.Valida
        If edicion = True Then
            Calculin()
        End If
    End Sub

    Private Sub TxDato_10_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato_10.KeyDown
        If e.KeyCode = Keys.F2 Then
            If TxDato22.Text <> "" Then
                Dim frm As New FrmGeneroTerceros
                frm.init(TxDato22.Text, TxDato_2.Text, Lb62.Text)
                frm.ShowDialog()

            End If
        End If
    End Sub

  

  

    Private Sub TxDato_10_Valida(ByVal edicion As Boolean) Handles TxDato_10.Valida
        BtBuscaConfec.CL_Filtro = "idgenero=" + TxDato_10.Text
        If edicion = True Then

            If TxDato22.Text <> "" Then
                Dim dtg As DataTable = Agro_GeneroTerceros(TxDato22.Text, TxDato_2.Text)
                If Not dtg Is Nothing Then
                    Dim si As Boolean
                    For Each rw In dtg.Rows
                        If VaInt(TxDato_10.Text) = VaInt(rw("Codigo")) Then
                            si = True
                        End If
                    Next
                    If si = False Then
                        MsgBox("Genero no disponible para este cliente")
                        TxDato_10.MiError = True
                    End If
                End If

            End If

            If Generos.LeerId(TxDato_10.Text) = True Then
                If Subfamilias.LeerId(Generos.GEN_IdsubFamilia.Valor) = True Then
                    BtBuscaCat.CL_Filtro = "Idfamilia=" + Subfamilias.SFA_idfamilia.Valor
                End If
            End If

            Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
            Dim dt As DataTable = GenerosSalida.LeerGensal(VaInt(TxDato_10.Text), VaInt(TxDato_11.Text))
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim KxB As Decimal = VaDec(dt.Rows(0)("GES_KilosXBulto"))
                    TxDato_16.Text = KxB.ToString("#,##0.00")
                    TxDato_16.Validar(True)

                    Dim PxB As Decimal = VaDec(dt.Rows(0)("GES_PiezasXBulto"))
                    TxDato_18.Text = PxB.ToString("#,##0.00")
                    TxDato_18.Validar(True)

                    Dim KgBrutos As Decimal = VaDec(TxDato_14.Text) * KxB
                    TxDato_17.Text = KgBrutos.ToString("#,##0.00")
                    TxDato_17.Validar(True)

                End If
            End If


        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtGastosGenerales.Click
        Dim frm As New FrmGastosPalet
        Dim id As String

        If Val(LbId.Text) = 0 Then Exit Sub

        id = LbId.Text
        frm.initLinea("0")
        frm.init(id)
        'frm.Left = Me.Left + Me.Width - frm.Width
        'frm.Top = Me.Top
        '        frm.Initpos(Me.Top, Me.Left + Me.Width - frm.Width)
        frm.ShowDialog()

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtGastosLineas.Click
        Dim frm As New FrmGastosPalet
        Dim id As String

        If Val(LbId.Text) = 0 Then Exit Sub
        If Val(palets_lineas.PLL_idlinea.Valor) = 0 Then Exit Sub

        id = LbId.Text
        frm.initLinea(palets_lineas.PLL_idlinea.Valor)
        frm.init(id)
        'frm.Left = Me.Left + Me.Width - frm.Width
        'frm.Top = Me.Top
        '        frm.Initpos(Me.Top, Me.Left + Me.Width - frm.Width)
        frm.ShowDialog()

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

    Private Sub TxDato_40_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_40.TextChanged

    End Sub

    Private Sub TxDato_40_Valida(ByVal edicion As Boolean) Handles TxDato_40.Valida
        If edicion = True Then
            If TxDato_40.Text <> "B" Then
                TxDato_40.Text = "A"
            End If
        End If
    End Sub


    Private Sub TxDato_5_Valida(ByVal edicion As Boolean) Handles TxDato_5.Valida

        If edicion = True Then
            If TxDato_5.Text <> "S" Then
                TxDato_5.Text = "N"
            End If
        End If
    End Sub


    Private Sub BtBuscaCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtBuscaCat.Click

    End Sub

    Private Sub TxDato_3_Valida(edicion As System.Boolean) Handles TxDato_3.Valida

        If edicion Then

            EntradaLectorCodigos()

            ObtenerTara()

        End If

    End Sub


    Private Sub EntradaLectorCodigos()

        If TxDato_3.Text.Length > 6 And TxDato_3.Text.Contains(".") Then

            Dim IdGenero As String = ""
            Dim TipoConf As String = ""
            Dim Categoria As String = ""
            Dim Marca As String = ""
            Dim Bultos As String = ""
            Dim TipoPalet As String = ""
            Dim Linea As String = ""
            Dim Tarea As String = ""

            If Mid(TxDato_3.Text, 1, 3).ToUpper = "+C1" Then
                TxDato_3.Text = Mid(TxDato_3.Text, 4)
            End If
            Dim codigo As String() = TxDato_3.Text.Split(".")

            If codigo.Length >= 0 Then IdGenero = codigo(0)
            If codigo.Length >= 1 Then TipoConf = codigo(1)
            If codigo.Length >= 2 Then Categoria = codigo(2)
            If codigo.Length >= 3 Then Marca = codigo(3)
            If codigo.Length >= 4 Then Bultos = codigo(4)
            If codigo.Length >= 5 Then TipoPalet = codigo(5)
            If codigo.Length >= 6 Then Linea = codigo(6)
            If codigo.Length >= 7 Then Tarea = codigo(7)

            palets.PAL_IdLinea.Valor = VaInt(Linea)
            palets.PAL_IdTarea.Valor = VaInt(Tarea)

            TxDato_5.Text = "N"

            TxDato_10.Text = IdGenero
            TxDato_11.Text = TipoConf
            TxDato_12.Text = Categoria
            TxDato_13.Text = Marca
            TxDato_14.Text = Bultos


            QuitaError(TxDato_3.Orden)
            TxDato_3.MiError = False
            TxDato_3.Text = TipoPalet

            TxDato_5.Validar(True)
            TxDato_10.Validar(True)
            TxDato_11.Validar(True)
            TxDato_12.Validar(True)
            TxDato_13.Validar(True)
            TxDato_14.Validar(True)

            Siguiente(TxDato_16.Orden)

        End If

    End Sub


    Private Sub ObtenerTara()

        If VaInt(TxDato_3.Text) > 0 Then

            Dim TotalTara As Decimal = 0

            Dim sql As String = "SELECT SUM(Tara) AS TotalTara" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & " SELECT CPA_IncrementoTara as Tara " & vbCrLf
            sql = sql & " FROM Confecpalet" & vbCrLf
            sql = sql & " WHERE CPA_IdConfec = " & TxDato_3.Text & vbCrLf
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT COALESCE(CPL_Cantidad,0) * COALESCE(ENV_TaraSalida,0) as Tara" & vbCrLf
            sql = sql & " FROM ConfecPaletLineas" & vbCrLf
            sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = CPL_IdMaterial" & vbCrLf
            sql = sql & " WHERE CPL_IdConfec = " & TxDato_3.Text & vbCrLf
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


    Private Sub TxDato_3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato_3.KeyDown

        If e.KeyCode = Keys.Enter Then

            EntradaLectorCodigos()

            ObtenerTara()

        End If

    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaDec(LbId.Text) > 0 Then

            Dim impresora As New Printing.PrinterSettings
            ImprimirTicketPalet(LbId.Text, TipoImpresion.ImpresoraPorDefecto, False, impresora.PrinterName, "", "")

        End If



    End Sub


    Private Sub TxDato_4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_4.TextChanged

    End Sub

    Private Sub TxDato_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_3.TextChanged

    End Sub

    Private Sub GroupBox5_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Function DtGeneros3(idcliente As String) As DataTable
        Dim ret As New DataTable
        Dim Consulta As New Cdatos.E_select
       

        Return ret

    End Function

    Private Sub TxDato_10_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato_10.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim frm As New FrmGeneroTerceros
        frm.init(TxDato22.Text, TxDato_2.Text, Lb62.Text)
        frm.ShowDialog()
        If TxDato_10.Enabled = True Then
            TxDato_10.Select()
        End If

    End Sub

    Private Sub TxDato22_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato22.TextChanged

    End Sub

    Private Sub TxDato22_Valida(edicion As Boolean) Handles TxDato22.Valida
        If VaInt(TxDato22.Text) = 0 Then
            Button2.Visible = False
            BtBuscaGenero.Visible = True
        Else
            Button2.Visible = True
            BtBuscaGenero.Visible = False
            Button2.Top = BtBuscaGenero.Top
            Button2.Left = BtBuscaGenero.Left
        End If
    End Sub
End Class