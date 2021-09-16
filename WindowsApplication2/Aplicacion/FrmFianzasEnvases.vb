Imports DevExpress.XtraEditors

Public Class FrmFianzasEnvases
    Inherits FrMantenimiento



    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
    Dim FianzasEnvases As New E_FianzasEnvases(Idusuario, cn)
    Dim SubFamiliaEnvases As New E_SubFamiliaEnvases(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Private Sub ParametrosFrm()

        EntidadFrm = Clientes



        ListaControles = New List(Of Object)

        ParamTx(TxCliente, Clientes.CLI_Codigo, LbCliente, True)
        TxCliente.Autonumerico = False
        CampoClave = 0 ' ultimo campo de la clave

        ParamTx(TxDomicilio, Nothing, LbDescarga, False)

        ParamTx(TxSubfamilia, FianzasEnvases.FZE_IdSubFamiliaEnvase, LbSubfamilia, True)
        ParamTx(TxTipo, FianzasEnvases.FZE_TipoFacturacion, LbTipo, True, , , , "ABC")

        AsociarGrid(ClGrid1, TxDomicilio, TxTipo, FianzasEnvases)

        PropiedadesCamposGr(ClGrid1, "FZE_Id", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Domicilio", "Domicilio", True, 250)
        PropiedadesCamposGr(ClGrid1, "SubFamilia", "SubFamilia", True, 150)
        PropiedadesCamposGr(ClGrid1, "Tipo", "Tipo", True, 30)

        AsociarControles(TxCliente, BtCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomCliente)
        AsociarControles(TxDomicilio, BtBuscaDestino, ClientesDescargas.btBusca, ClientesDescargas)
        AsociarControles(TxSubfamilia, BtSubfamilia, SubFamiliaEnvases.btBusca, SubFamiliaEnvases, SubFamiliaEnvases.SFE_Nombre, LbNomSubfamilia)

        BAnular.Visible = False

    End Sub


    Private Sub FrmFianzasEnvases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BAnular.Visible = False
    End Sub


    Public Overrides Sub init(Id As String)
        MyBase.init(Id)

        If VaDec(Id) > 0 Then

            BtBuscaDestino.CL_Filtro = "IdCliente = " & TxCliente.Text
            CargaLineasGrid()

        End If

    End Sub


    Public Overrides Sub ControlClave()

        ' componemos la clave
        LbId.Text = TxCliente.Text


        CargaLineasGrid()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        BtBuscaDestino.CL_Filtro = ""

    End Sub


    Public Overrides Sub Borralin(gr As ClGrid)
        MyBase.Borralin(gr)

        TxDomicilio.Text = ""
        LbnomDestino.Text = ""

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)

        TxDomicilio.Text = ""
        LbnomDestino.Text = ""

        Dim IdDomicilio As String = VaInt(FianzasEnvases.FZE_IdDomicilio.Valor).ToString
        MuestraDomicilio(IdDomicilio)

    End Sub


    Private Sub MuestraDomicilio(ByVal IdDomicilio As String)

        If VaInt(IdDomicilio) > 0 Then
            Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
            If ClientesDescargas.LeerId(IdDomicilio) Then
                TxDomicilio.Text = (ClientesDescargas.CLD_numero.Valor & "").Trim
                LbnomDestino.Text = (ClientesDescargas.CLD_Domicilio.Valor & "").Trim
            End If
        End If

    End Sub


    Private Sub CargaLineasGrid()

        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)

    End Sub


    Private Sub SqlGrid()


        Dim Id As String = LbId.Text

        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(FianzasEnvases.FZE_Id, "FZE_Id")
        CONSULTA.SelCampo(ClientesDescargas.CLD_Domicilio, "Domicilio", FianzasEnvases.FZE_IdDomicilio)
        CONSULTA.SelCampo(SubFamiliaEnvases.SFE_Nombre, "SubFamilia", FianzasEnvases.FZE_IdSubFamiliaEnvase)
        CONSULTA.SelCampo(FianzasEnvases.FZE_TipoFacturacion, "Tipo")
        CONSULTA.WheCampo(FianzasEnvases.FZE_IdCliente, "=", LbId.Text)

        Dim sql As String = CONSULTA.SQL & vbCrLf & " ORDER BY CLD_Domicilio, SFE_Nombre"
        ClGrid1.Consulta = sql

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean

        'asociar cabecera con lineas
        FianzasEnvases.FZE_IdCliente.Valor = LbId.Text

        Dim IdDomicilio As String = "0"

        If VaInt(TxDomicilio.Text) > 0 Then
            Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
            IdDomicilio = ClientesDescargas.LeerDomi(TxCliente.Text, TxDomicilio.Text).ToString
        End If

        If IdDomicilio = "" Then IdDomicilio = "0"
        FianzasEnvases.FZE_IdDomicilio.Valor = IdDomicilio


        Dim IdLinea As String = ""
        Dim row As DataRow = Gr.GridView.GetFocusedDataRow()
        If Not IsNothing(row) Then
            IdLinea = (row("FZE_Id").ToString & "").Trim
        End If



        If Not ValidaLineaFianzaEnvases(TxCliente.Text, IdDomicilio, TxSubfamilia.Text, IdLinea) Then
            MsgBox("Ya existe una línea para este cliente, domicilio de descarga y subfamilia")
            Return False
        End If




        SqlGrid()

        Dim r As Boolean = MyBase.GuardarLineas(Gr)
        Return r

    End Function



    Private Function ValidaLineaFianzaEnvases(IdCliente As String, IdDomicilio As String, IdSubFamilia As String, IdLinea As String) As Boolean

        Dim bRes As Boolean = True


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(FianzasEnvases.FZE_Id, "Id")
        CONSULTA.WheCampo(FianzasEnvases.FZE_IdCliente, "=", IdCliente)
        CONSULTA.WheCampo(FianzasEnvases.FZE_IdDomicilio, "=", IdDomicilio)
        CONSULTA.WheCampo(FianzasEnvases.FZE_IdSubFamiliaEnvase, "=", IdSubFamilia)
        If VaInt(IdLinea) > 0 Then CONSULTA.WheCampo(FianzasEnvases.FZE_Id, "<>", IdLinea)


        Dim sql As String = CONSULTA.SQL
        Dim dt As DataTable = FianzasEnvases.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                bRes = False
            End If
        End If


        Return bRes

    End Function



    Private Sub TxDomicilio_Valida(edicion As System.Boolean) Handles TxDomicilio.Valida

        If edicion Then

            LbnomDestino.Text = ""

            If VaInt(TxDomicilio.Text) > 0 Then
                Dim IdDomicilio As String = ClientesDescargas.LeerDomi(TxCliente.Text, TxDomicilio.Text)
                MuestraDomicilio(IdDomicilio)
            End If

        End If

    End Sub


    Private Sub TxCliente_Valida(edicion As System.Boolean) Handles TxCliente.Valida

        If edicion Then
            BtBuscaDestino.CL_Filtro = "IdCliente = " & TxCliente.Text
        End If

    End Sub


End Class