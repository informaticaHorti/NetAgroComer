Public Class FrmValoresUsuario
    Inherits FrMantenimiento



    Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)
    Dim Usuarios As New E_Usuarios(Idusuario, CnComun)
    Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)
    Dim GruposMensajes As New E_GruposMensajes(Idusuario, cn)
    Dim PventaUsuario As New E_PventaUsuario(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim CargandoCombo As Boolean
    Dim LstPrinter As New List(Of String)


    Private Sub ParametrosFrm()

        EntidadFrm = ValoresUsuario


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, ValoresUsuario.VUS_Iduser, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, ValoresUsuario.VUS_IdCentroRecogida, Lb2)
        ParamTx(TxDato3, ValoresUsuario.VUS_idgrupomensajes, Lb9)
        ParamTx(TxValidarOperario, ValoresUsuario.VUS_ValidarOperario, LbValidarOperario, True, , , , "SN")
        CargandoCombo = True
        LstPrinter = ListaImpresorasDelSistema()
        LstPrinter.Sort()
        'Sin impresora
        LstPrinter.Insert(0, "")


        ComboImpresoras(CbPartidaControlada)
        ComboImpresoras(CbPartidaNoControlada)
        ComboImpresoras(CbAlbEntrada)
        ComboImpresoras(CbClasificacionesProveedor)
        ComboImpresoras(CbValeEnvases)
        ComboImpresoras(CbLiquidaciones)
        ComboImpresoras(CbTalones)
        ComboImpresoras(CbFacturas)
        ComboImpresoras(CbCMRNacional)
        ComboImpresoras(CbCMRInternacional)
        ComboImpresoras(CbEtiquetasCMR)
        ComboImpresoras(CbPalets)
        ComboImpresoras(CbLotesEntradaControlados)
        ComboImpresoras(CbLotesEntradaNoControlados)
        ComboImpresoras(CbPaletsSemiterminadosControlados)
        ComboImpresoras(CbPaletsSemiterminadosNoControlados)
        ComboImpresoras(CbCartelones)
        ComboImpresoras(CbEmail_PDF)



        'ParamCb_Copia(CbBoletin, ValoresUsuario.VUS_ImpresoraMuestreo, Lb14, Combos.ComboImpresoras)
        ParamTx(TxPartidaControlada, ValoresUsuario.VUS_ImpresoraPartidaControlada, LbPartidaControlada)
        ParamTx(TxPartidaNoControlada, ValoresUsuario.VUS_ImpresoraPartidaNoControlada, LbPartidaNoControlada)
        ParamTx(TxAlbaranEntrada, ValoresUsuario.VUS_ImpresoraAlbEntrada, Lb13)
        ParamTx(TxClasificacionesProveedor, ValoresUsuario.VUS_ImpresoraClasificacionesProveedor, Lb18)
        ParamTx(TxValeEnvases, ValoresUsuario.VUS_ImpresoraValeEnvases, Lb10)
        ParamTx(TxLiquidaciones, ValoresUsuario.VUS_ImpresoraLiquidaciones, Lb14)
        'ParamTx(TxTalones, ValoresUsuario.VUS_ImpresoraPartidaControlada, Lb15)
        ParamTx(TxTalones, ValoresUsuario.VUS_ImpresoraTalones, Lb15)

        ParamTx(TxFacturas, ValoresUsuario.VUS_ImpresoraFacturasClientes, Lb3)
        ParamTx(TxCMRNacional, ValoresUsuario.VUS_ImpresoraCMRNacional, Lb4)
        ParamTx(TxCmrInternacional, ValoresUsuario.VUS_ImpresoraCMRInternacional, Lb5)
        ParamTx(TxEtiquetasCMR, ValoresUsuario.VUS_ImpresoraEtiquetaCMR, Lb16)
        ParamTx(TxPalets, ValoresUsuario.VUS_ImpresoraPalets, Lb7)

        'ParamTx(TxLotesEntradaControlados, ValoresUsuario.VUS_ImpresoraLoteEntrada, LbLotesControlados)
        'ParamTx(TxPaletsSemiterminadosControlados, ValoresUsuario.VUS_ImpresoraPaletSemiterminado, LbPaletsSemiterminadosControlados)

        ParamTx(TxLotesEntradaControlados, ValoresUsuario.VUS_ImpresoraLotesControlados, LbLotesControlados)
        ParamTx(TxLotesEntradaNoControlados, ValoresUsuario.VUS_ImpresoraLotesNoControlados, LbLotesNoControlados)
        ParamTx(TxPaletsSemiterminadosControlados, ValoresUsuario.VUS_ImpresoraPaletSemitControlados, LbPaletsSemiterminadosControlados)
        ParamTx(TxPaletsSemiterminadosNoControlados, ValoresUsuario.VUS_ImpresoraPaletSemitNoControlados, LbPaletsSemiterminadosNoControlados)


        ParamTx(TxCartelones, ValoresUsuario.VUS_ImpresoraCartelones, LbCartelones)
        ParamTx(TxEmailPDF, ValoresUsuario.VUS_ImpresoraEmail_PDF, Lb8)


        CargandoCombo = False
        ParamTx(TxDato20, ValoresUsuario.VUS_RutaMensajeCorreoNET, Lb20)
        ParamTx(TxDato21, ValoresUsuario.VUS_RutaGeneracionPDF, Lb21)
        ParamTx(TxDato22, ValoresUsuario.VUS_RutaMensajeFax, Lb22)
        ParamTx(TxDato23, ValoresUsuario.VUS_PrefijoFax, Lb23)
        ParamTx(TxDato24, ValoresUsuario.VUS_SufijoFax, Lb24)


        ParamTx(TxDescripcion1, ValoresUsuario.VUS_DescNavegador1, LbDescripcionNavegador)
        ParamTx(TxUrl1, ValoresUsuario.VUS_UrlNavegador1, LbUrlNavegador)
        ParamTx(TxDescripcion2, ValoresUsuario.VUS_DescNavegador2, LbDescripcionNavegador)
        ParamTx(TxUrl2, ValoresUsuario.VUS_UrlNavegador2, LbUrlNavegador)
        ParamTx(TxDescripcion3, ValoresUsuario.VUS_DescNavegador3, LbDescripcionNavegador)
        ParamTx(TxUrl3, ValoresUsuario.VUS_UrlNavegador3, LbUrlNavegador)
        ParamTx(TxDescripcion4, ValoresUsuario.VUS_DescNavegador4, LbDescripcionNavegador)
        ParamTx(TxUrl4, ValoresUsuario.VUS_UrlNavegador4, LbUrlNavegador)
        ParamTx(TxDescripcion5, ValoresUsuario.VUS_DescNavegador5, LbDescripcionNavegador)
        ParamTx(TxUrl5, ValoresUsuario.VUS_UrlNavegador5, LbUrlNavegador)
        ParamTx(TxDescripcion6, ValoresUsuario.VUS_DescNavegador6, LbDescripcionNavegador)
        ParamTx(TxUrl6, ValoresUsuario.VUS_UrlNavegador6, LbUrlNavegador)
        ParamTx(TxDescripcion7, ValoresUsuario.VUS_DescNavegador7, LbDescripcionNavegador)
        ParamTx(TxUrl7, ValoresUsuario.VUS_UrlNavegador7, LbUrlNavegador)
        ParamTx(TxDescripcion8, ValoresUsuario.VUS_DescNavegador8, LbDescripcionNavegador)
        ParamTx(TxUrl8, ValoresUsuario.VUS_UrlNavegador8, LbUrlNavegador)
        ParamTx(TxDescripcion9, ValoresUsuario.VUS_DescNavegador9, LbDescripcionNavegador)
        ParamTx(TxUrl9, ValoresUsuario.VUS_UrlNavegador9, LbUrlNavegador)
        ParamTx(TxDescripcion10, ValoresUsuario.VUS_DescNavegador10, LbDescripcionNavegador)
        ParamTx(TxUrl10, ValoresUsuario.VUS_UrlNavegador10, LbUrlNavegador)


        AsociarControles(TxDato1, BtBuscaFRM, Usuarios.btBusca, Usuarios, Usuarios.Nombre, LbNomUsu)
        AsociarControles(TxDato2, BtBusca1, CentrosRecogida.btBusca, CentrosRecogida, CentrosRecogida.CER_Nombre, Lb19)
        AsociarControles(TxDato3, BtBusca2, GruposMensajes.btBusca, GruposMensajes, GruposMensajes.GRM_Nombre, Lb6)

        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub


    Private Sub FrmValoresUsuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        TxUrl1.CharacterCasing = CharacterCasing.Normal
        TxUrl2.CharacterCasing = CharacterCasing.Normal
        TxUrl3.CharacterCasing = CharacterCasing.Normal
        TxUrl4.CharacterCasing = CharacterCasing.Normal
        TxUrl5.CharacterCasing = CharacterCasing.Normal
        TxUrl6.CharacterCasing = CharacterCasing.Normal
        TxUrl7.CharacterCasing = CharacterCasing.Normal
        TxUrl8.CharacterCasing = CharacterCasing.Normal
        TxUrl9.CharacterCasing = CharacterCasing.Normal
        TxUrl10.CharacterCasing = CharacterCasing.Normal

    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Private Sub TxDato2_Valida(edicion As System.Boolean) Handles TxDato2.Valida

        If edicion Then
            XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(0)
            CbFacturas.Select()
            CbFacturas.Focus()
        End If

    End Sub


    'Private Sub CbCMRInternacional_Valida(edicion As System.Boolean) Handles CbCMRInternacional.Valida

    '    If edicion Then

    '        XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(1)
    '        TxDato20.Select()
    '        TxDato20.Focus()

    '        'Por defecto
    '        Dim ruta_mensaje As String = "C:\CorreoNET\Mensajes\"
    '        Dim ruta_PDF As String = "C:\temp\"
    '        Dim ruta_fax As String = "C:\CorreoNET\Mensajes\"
    '        Dim prefijo_fax As String = "fax."
    '        Dim sufijo_fax As String = "@fax.vodafone.es"

    '        If TxDato20.Text.Trim = "" Then TxDato20.Text = ruta_mensaje
    '        If TxDato21.Text.Trim = "" Then TxDato21.Text = ruta_PDF
    '        If TxDato22.Text.Trim = "" Then TxDato22.Text = ruta_fax
    '        If TxDato23.Text.Trim = "" Then TxDato23.Text = prefijo_fax
    '        If TxDato24.Text.Trim = "" Then TxDato24.Text = sufijo_fax

    '    End If

    'End Sub


    Private Sub CbFacturas_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbFacturas.KeyDown

        If e.KeyCode = Keys.Enter Then

            If (CbFacturas.Text & "").Trim = "" Then
                CbFacturas.SelectedIndex = 0
                CbCMRNacional.Select()
                CbCMRNacional.Focus()
            End If

        End If

    End Sub

    Private Sub CbCMRNacional_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbCMRNacional.KeyDown

        If e.KeyCode = Keys.Enter Then

            If (CbCMRNacional.Text & "").Trim = "" Then
                CbCMRNacional.SelectedIndex = 0
                CbCMRInternacional.Select()
                CbCMRInternacional.Focus()
            End If

        End If

    End Sub

    Private Sub CbCMRInternacional_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbCMRInternacional.KeyDown

        If e.KeyCode = Keys.Enter Then

            If (CbCMRInternacional.Text & "").Trim = "" Then
                CbCMRInternacional.SelectedIndex = 0
                CbEtiquetasCMR.Select()
                CbEtiquetasCMR.Focus()
            End If

        End If

    End Sub

    Private Sub CbPalets_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CbPalets.KeyDown

        If e.KeyCode = Keys.Enter Then

            If (CbPalets.Text & "").Trim = "" Then
                CbPalets.SelectedIndex = 0
                CbLotesEntradaControlados.Select()
                CbLotesEntradaControlados.Focus()
                CbLotesEntradaControlados.SelectedIndex = 0
            End If

        End If

    End Sub

    Private Sub CbPaletsSemiterminadosControlados_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbPaletsSemiterminadosControlados.KeyDown

        If e.KeyCode = Keys.Enter Then

            If (CbPaletsSemiterminadosControlados.Text & "").Trim = "" Then
                CbPaletsSemiterminadosControlados.SelectedIndex = 0
                CbCartelones.Select()
                CbCartelones.Focus()
                CbCartelones.SelectedIndex = 0
            End If

        End If

    End Sub


    Private Sub CbCartelones_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbCartelones.KeyDown

        If e.KeyCode = Keys.Enter Then

            If (CbCartelones.Text & "").Trim = "" Then
                CbCartelones.SelectedIndex = 0
                CbEmail_PDF.Select()
                CbEmail_PDF.Focus()
                CbEmail_PDF.SelectedIndex = 0
            End If

        End If

    End Sub


    Private Sub CbEmail_PDF_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbEmail_PDF.KeyDown

        If e.KeyCode = Keys.Enter Then
            If (CbEmail_PDF.Text & "").Trim = "" Then

                XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(2)

                TxDato20.Select()
                TxDato20.Focus()

            End If
        End If

    End Sub


    Private Sub CbEmail_PDF_Valida(edicion As System.Boolean) Handles CbEmail_PDF.Valida

        If edicion Then

            XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(2)
            TxDato20.Select()
            TxDato20.Focus()

            'Por defecto
            Dim ruta_mensaje As String = "C:\CorreoNET\Mensajes\"
            Dim ruta_PDF As String = "C:\temp\"
            Dim ruta_fax As String = "C:\CorreoNET\Mensajes\"
            Dim prefijo_fax As String = "fax."
            Dim sufijo_fax As String = "@fax.vodafone.es"

            If TxDato20.Text.Trim = "" Then TxDato20.Text = ruta_mensaje
            If TxDato21.Text.Trim = "" Then TxDato21.Text = ruta_PDF
            If TxDato22.Text.Trim = "" Then TxDato22.Text = ruta_fax
            If TxDato23.Text.Trim = "" Then TxDato23.Text = prefijo_fax
            If TxDato24.Text.Trim = "" Then TxDato24.Text = sufijo_fax

        End If

    End Sub

    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        CbPartidaControlada.SelectedIndex = 0
        CbPartidaNoControlada.SelectedIndex = 0
        CbAlbEntrada.SelectedIndex = 0
        CbClasificacionesProveedor.SelectedIndex = 0

        CbLiquidaciones.SelectedIndex = 0
        CbTalones.SelectedIndex = 0

        CbFacturas.SelectedIndex = 0
        CbCMRNacional.SelectedIndex = 0
        CbCMRInternacional.SelectedIndex = 0
        CbEtiquetasCMR.SelectedIndex = 0
        CbPalets.SelectedIndex = 0
        CbLotesEntradaControlados.SelectedIndex = 0
        CbLotesEntradaNoControlados.SelectedIndex = 0
        CbPaletsSemiterminadosControlados.SelectedIndex = 0
        CbPaletsSemiterminadosNoControlados.SelectedIndex = 0
        CbCartelones.SelectedIndex = 0
        CbEmail_PDF.SelectedIndex = 0


        '        CbPartidaControlada.SelectedIndex = 0
        '        CbPartidaNoControlada.SelectedIndex = 0
        '        CbAlbEntrada.SelectedIndex = 0
        '        CbValeEnvases.SelectedIndex = 0
        CargaGridFRm()

    End Sub



    Private Sub CbTalones_Valida(edicion As System.Boolean) Handles CbTalones.Valida

        XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(1)
        CbFacturas.Select()
        CbFacturas.Focus()

    End Sub



    Private Sub CbEtiquetasCMR_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbEtiquetasCMR.KeyDown

        If e.KeyCode = Keys.Enter Then

            If (CbEtiquetasCMR.Text & "").Trim = "" Then
                CbEtiquetasCMR.SelectedIndex = 0
                CbPalets.Select()
                CbPalets.Focus()
            End If

        End If

    End Sub



    Private Sub CargaGridFRm()

        Dim dt As New DataTable
        dt = PuntoVenta.Tabla

        ChPventa.DataSource = dt
        ChPventa.ValueMember = "IdPuntoventa"
        ChPventa.DisplayMember = "Nombre"


        ChPventa.CheckOnClick = True


        If Val(LbId.Text) > 0 Then
            For indice As Integer = 0 To ChPventa.ItemCount - 1

                '   If ChOrigen.GetItemChecked(indice) = True Then
                ' MsgBox("Checked: " & row("Nombre").ToString)
                ' End If

                Dim row As DataRowView = ChPventa.GetItem(indice)
                Dim a As String = row("IdPuntoventa").ToString
                If PventaUsuario.LeerUsuario_Pventa(LbId.Text, a) > 0 Then
                    ChPventa.SetItemChecked(indice, True)

                End If

            Next
        End If


    End Sub

    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()

        CargaGridFRm()

    End Sub


    Public Overrides Sub Guardar()

        '        For Each cb In Me.ListaControles
        ' If TypeOf (cb) Is CbBox Then
        ' If cb.SelectedIndex < 0 Then
        'cb.SelectedIndex = 0
        'End If
        'End If
        'Next



        GuardarCh()

        MyBase.Guardar()
        CargaGridFRm()

    End Sub



    Private Sub GuardarCh()
        BorrarGastos()
        For Each row As DataRowView In ChPventa.CheckedItems

            PventaUsuario.VaciaEntidad()
            Dim id As Integer = PventaUsuario.MaxId
            PventaUsuario.PVU_Id.Valor = id.ToString
            PventaUsuario.PVU_IdUsuario.Valor = LbId.Text
            PventaUsuario.PVU_Idpventa.Valor = row("IdPuntoventa").ToString
            PventaUsuario.Insertar()

        Next

    End Sub

    Private Sub BorrarGastos()
        If Val(LbId.Text) > 0 Then
            Dim sql As String = "delete from pventausuario where PVU_idusuario=" + LbId.Text
            PventaUsuario.MiConexion.ConsultaSQL(sql)
        End If

    End Sub


    Private Sub ComboImpresoras(ByRef cb As CbBox)


        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("Id", GetType(String)))
        dt.Columns.Add(New DataColumn("Nombre", GetType(String)))


        For Each item As String In LstPrinter
            Dim row As DataRow = dt.NewRow()
            row("Id") = item
            row("Nombre") = item
            dt.Rows.Add(row)
        Next


        cb.DataSource = dt
        cb.DisplayMember = "Nombre"
        cb.ValueMember = "Id"




    End Sub


    Private Sub CbPartidaControlada_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbPartidaControlada.SelectedIndexChanged
        CambiaImpresora(CbPartidaControlada, TxPartidaControlada)
    End Sub

    Private Sub CambiaImpresora(cb As CbBox, tx As TxDato)
        If tx.Enabled = True Then
            tx.Text = cb.SelectedValue.ToString
        End If
    End Sub

    Private Sub CbPartidaNoControlada_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbPartidaNoControlada.SelectedIndexChanged
        CambiaImpresora(CbPartidaNoControlada, TxPartidaNoControlada)
    End Sub

    Private Sub CbAlbEntrada_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbAlbEntrada.SelectedIndexChanged
        CambiaImpresora(CbAlbEntrada, TxAlbaranEntrada)
    End Sub

    Private Sub CbClasificacionesProveedor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbClasificacionesProveedor.SelectedIndexChanged
        CambiaImpresora(CbClasificacionesProveedor, TxClasificacionesProveedor)
    End Sub

    Private Sub CbValeEnvases_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbValeEnvases.SelectedIndexChanged
        CambiaImpresora(CbValeEnvases, TxValeEnvases)
    End Sub

    Private Sub CbLiquidaciones_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbLiquidaciones.SelectedIndexChanged
        CambiaImpresora(CbLiquidaciones, TxLiquidaciones)
    End Sub

    Private Sub CbTalones_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbTalones.SelectedIndexChanged
        CambiaImpresora(CbTalones, TxTalones)
    End Sub

    Private Sub CbFacturas_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbFacturas.SelectedIndexChanged
        CambiaImpresora(CbFacturas, TxFacturas)
    End Sub

    Private Sub CbCMRNacional_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbCMRNacional.SelectedIndexChanged
        CambiaImpresora(CbCMRNacional, TxCMRNacional)
    End Sub

    Private Sub CbCMRInternacional_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbCMRInternacional.SelectedIndexChanged
        CambiaImpresora(CbCMRInternacional, TxCmrInternacional)
    End Sub

    Private Sub CbEtiquetasCMR_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbEtiquetasCMR.SelectedIndexChanged
        CambiaImpresora(CbEtiquetasCMR, TxEtiquetasCMR)
    End Sub

    Private Sub CbPalets_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbPalets.SelectedIndexChanged
        CambiaImpresora(CbPalets, TxPalets)
    End Sub

    Private Sub CbLotesEntradaControlados_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbLotesEntradaControlados.SelectedIndexChanged
        CambiaImpresora(CbLotesEntradaControlados, TxLotesEntradaControlados)
    End Sub

    Private Sub CbLotesEntradaNoControlados_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbLotesEntradaNoControlados.SelectedIndexChanged
        CambiaImpresora(CbLotesEntradaNoControlados, TxLotesEntradaNoControlados)
    End Sub

    Private Sub CbPaletsSemiterminadosControlados_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbPaletsSemiterminadosControlados.SelectedIndexChanged
        CambiaImpresora(CbPaletsSemiterminadosControlados, TxPaletsSemiterminadosControlados)
    End Sub

    Private Sub CbPaletsSemiterminadosNoControlados_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbPaletsSemiterminadosNoControlados.SelectedIndexChanged
        CambiaImpresora(CbPaletsSemiterminadosNoControlados, TxPaletsSemiterminadosNoControlados)
    End Sub

    Private Sub CbCartelones_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbCartelones.SelectedIndexChanged
        CambiaImpresora(CbCartelones, TxCartelones)
    End Sub

    Private Sub CbEmail_PDF_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbEmail_PDF.SelectedIndexChanged
        CambiaImpresora(CbEmail_PDF, TxEmailPDF)
    End Sub

    
    
    Private Sub TxTalones_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxTalones.KeyDown
        If e.KeyCode = Keys.Enter And Not TxTalones.MiError Then
            XtraTabControl1.SelectedTabPage = XtraTabPage2
            TxFacturas.Select()
            TxFacturas.Focus()
        End If
    End Sub

    Private Sub TxEmailPDF_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxEmailPDF.KeyDown
        If e.KeyCode = Keys.Enter And Not TxEmailPDF.MiError Then
            XtraTabControl1.SelectedTabPage = XtraTabPage3
            TxDato20.Select()
            TxDato20.Focus()
        End If
    End Sub

    Private Sub TxDato24_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato24.KeyDown
        If e.KeyCode = Keys.Enter And Not TxDato24.MiError Then
            XtraTabControl1.SelectedTabPage = XtraTabPage4
            TxDescripcion1.Select()
            TxDescripcion1.Focus()
        End If

    End Sub

    Private Sub TxDescripcion1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDescripcion1.KeyDown
        If e.KeyCode = Keys.Up And Not TxDescripcion1.MiError Then
            XtraTabControl1.SelectedTabPage = XtraTabPage3
            TxDato24.Select()
            TxDato24.Focus()
        End If
    End Sub

    Private Sub TxDato20_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato20.KeyDown
        If e.KeyCode = Keys.Up And Not TxDato20.MiError Then
            XtraTabControl1.SelectedTabPage = XtraTabPage2
            TxEmailPDF.Select()
            TxEmailPDF.Focus()
        End If
    End Sub

    Private Sub TxFacturas_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxFacturas.KeyDown
        If e.KeyCode = Keys.Up And Not TxFacturas.MiError Then
            XtraTabControl1.SelectedTabPage = XtraTabPage1
            TxTalones.Select()
            TxTalones.Focus()
        End If
    End Sub
End Class