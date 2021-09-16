Public Class FrmValorespventa
    Inherits FrMantenimiento


    Dim Valorespventa As New E_valorespventa(Idusuario, cn)
    Dim Puntoventa As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim DestinoTransito As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim Paises As New E_Paises(Idusuario, CnComun)
    Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)
    Dim Empresas As New E_Empresas(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))



    Private Sub ParametrosFrm()
        EntidadFrm = Valorespventa


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Valorespventa.VPV_idpventa, Lb1, True)
        ParamCb_Copia(CbtipoActividad, Valorespventa.VPV_tipoactividad, Lb2, Combos.ComboTipoactividad)
        ParamTx(TxEmpresa, Valorespventa.VPV_IdEmpresa, Lbempresa, True)
        ParamTx(TxCentroCtb, Valorespventa.VPV_CentroCtb, LbCentroCtb)
        ParamTx(TxDestinoTransito, Valorespventa.VPV_IdDestinoTransito, LbDestinoTransito)

        CampoClave = 0 ' ultimo campo de la clave


        ParamTx(TxDato3, Valorespventa.VPV_EmpresaFacturacion, Lb3)
        ParamTx(TxDato4, Valorespventa.VPV_DomicilioFacturacion, Lb4)
        ParamTx(TxDato5, Valorespventa.VPV_CPostalFacturacion, Lb5)
        ParamTx(TxDato6, Valorespventa.VPV_PoblacionFacturacion, Lb6)
        ParamTx(TxDato7, Valorespventa.VPV_ProvinciaFacturacion, Lb7)
        ParamTx(TxDato8, Valorespventa.VPV_IdPaisFacturacion, Lb8)
        ParamTx(TxDato9, Valorespventa.VPV_AptdoCorreosFacturacion, Lb9)
        ParamTx(TxDato10, Valorespventa.VPV_TelefonosFacturacion, Lb10)
        ParamTx(TxDato11, Valorespventa.VPV_FaxFacturacion, Lb11)
        ParamTx(TxDato12, Valorespventa.VPV_EmailFacturacion, Lb12)
        ParamTx(TxDato13, Valorespventa.VPV_WebFacturacion, Lb13)
        ParamTx(TxNif, Valorespventa.VPV_Nif, LbNif)
        ParamTx(TxGGN, Valorespventa.VPV_GGN, Lb15)
        ParamChk(ChkProductoEcologico, Valorespventa.VPV_EcologicoSN, "S", "N")
        ParamTx(TxNumRegistro, Valorespventa.VPV_NumRegistroEco, LbNumRegistro)


        ParamTx(TxDato20, Valorespventa.VPV_LineaDatosFiscales, Lb20)

        ParamTx(TxDato30, Valorespventa.VPV_NombreBanco, Lb30)
        ParamTx(TxDato31, Valorespventa.VPV_EntidadSucursal, Lb31)
        ParamTx(TxDato32, Valorespventa.VPV_IBAN, Lb32)
        ParamTx(TxDato33, Valorespventa.VPV_SWIFT, Lb33)
        ParamTx(TxDato41, Valorespventa.VPV_TextoContrato, Lb41)



        AsociarControles(TxDato1, BtBuscaFRM, Puntoventa.btBusca, Puntoventa, Puntoventa.Nombre, LbNomUsu)
        AsociarControles(TxDato8, BtBusca_8, Paises.btBusca, Paises, Paises.Nombre, Lb_8)
        AsociarControles(TxEmpresa, BtEmpresa, Empresas.btBusca, Empresas, Empresas.EMP_Nombre, LbnomEmpresa)
        AsociarControles(TxCentroCtb, BtBuscaCentroCtb, Centros.btBusca, Centros, Centros.Nombre, LbNom_CentroCtb)
        AsociarControles(TxDestinoTransito, BtBuscaDestinoTransito, DestinoTransito.btBusca, DestinoTransito, DestinoTransito.Nombre, LbNom_DestinoTransito)



        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me

        tt.SetToolTip(BtColor, "Cambiar color de fondo")

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


    Private Sub FrmValorespventa_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(0)

    End Sub


    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()

        Dim texto_color As String = (Valorespventa.VPV_Color.Valor & "").Trim
        Dim rgb As String() = texto_color.Split(Convert.ToChar(";"))

        Dim R As Integer = 0
        Dim G As Integer = 0
        Dim B As Integer = 0

        If rgb.Length > 0 Then R = VaInt(rgb(0))
        If rgb.Length > 1 Then G = VaInt(rgb(1))
        If rgb.Length > 2 Then B = VaInt(rgb(2))

        Dim color_pv As Color = Color.FromArgb(R, G, B)
        PictureBox1.BackColor = color_pv


    End Sub


    Protected Overrides Sub Datos_a_Entidad()
        MyBase.Datos_a_Entidad()

        Dim color_pv As String = PictureBox1.BackColor.R & ";" & PictureBox1.BackColor.G & ";" & PictureBox1.BackColor.B
        Valorespventa.VPV_Color.Valor = color_pv

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        PictureBox1.BackColor = SystemColors.Control

    End Sub


    Private Sub TxDato13_Valida(edicion As System.Boolean) Handles TxDato13.Valida

        'If edicion Then
        '    XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(1)
        '    TxDato20.Select()
        '    TxDato20.Focus()
        'End If

    End Sub

    Private Sub TxDato20_Valida(edicion As System.Boolean) Handles TxDato20.Valida

        If edicion Then
            XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(2)
            TxDato30.Select()
            TxDato30.Focus()
        End If

    End Sub

    Private Sub CbtipoActividad_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbtipoActividad.KeyDown

        If CbtipoActividad.DroppedDown = False Then
            If e.KeyCode = Keys.Enter Then
                TxEmpresa.Select()
                TxEmpresa.Focus()
            End If
        End If

    End Sub




    Private Sub BtColor_Click(sender As System.Object, e As System.EventArgs) Handles BtColor.Click

        ColorDialog1.Color = PictureBox1.BackColor
        ColorDialog1.FullOpen = True
        ColorDialog1.ShowDialog()
        PictureBox1.BackColor = ColorDialog1.Color

        Siguiente(CbtipoActividad.Orden)

        'Estructura dato color: R;G;B (A siempre es 255)
        'Dim texto_color As String = color_seleccionado.R & ";" & color_seleccionado.G & ";" & color_seleccionado.B

    End Sub

    Private Sub CbtipoActividad_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles CbtipoActividad.EnabledChanged

        PictureBox1.Enabled = CbtipoActividad.Enabled
        BtColor.Enabled = CbtipoActividad.Enabled

    End Sub

    Private Sub TxDato33_Valida(edicion As System.Boolean) Handles TxDato33.Valida

        If edicion Then
            XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(3)
            TxDato41.Select()
            TxDato41.Focus()
        End If

    End Sub

    Private Sub TxDato41_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato41.KeyDown

        If e.KeyCode = Keys.Up And TxDato41.Enabled Then

            XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(2)
            TxDato33.Select()
            TxDato33.Focus()

        End If

    End Sub

   
    Private Sub TxNumRegistro_Valida(edicion As System.Boolean) Handles TxNumRegistro.Valida

        If edicion Then
            XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(1)
            TxDato20.Select()
            TxDato20.Focus()
        End If

    End Sub
End Class