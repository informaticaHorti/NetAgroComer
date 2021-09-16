
Public Class FrmPortesSalida
    Inherits FrConsulta

    Dim Albsalida As New E_AlbSalida(Idusuario, cn)
    Dim Albsalida_gastos As New E_albsalida_gastos(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim GastosComercio As New E_GastosComercio(Idusuario, cn)
    Dim FActurasrecibidas As New E_Facturasrecibidas(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDesdeTransp, Acreedores.ACR_Codigo, LbDesdeTransp)
        ParamTx(TxHastaTransp, Acreedores.ACR_Codigo, LbHastaTransp)

        ParamTx(TxClienteDesde, Clientes.CLI_Codigo, LbDesdeCliente)
        ParamTx(TxClienteHasta, Clientes.CLI_Codigo, LbHastaCliente)

        ParamTx(TxFechaDesde, Albsalida.ASA_fechasalida, LbDesdeFecha)
        ParamTx(TxFechaHasta, Albsalida.ASA_fechasalida, LbHastaFecha)

        AsociarControles(TxDesdeTransp, BtBuscaDesdeTrasnp, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomDesdeTransp)
        BtBuscaDesdeTrasnp.CL_Filtro = "TIPO='PV'"

        AsociarControles(TxHastaTransp, BtBuscaHastaTransp, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomHastaTransp)
        BtBuscaHastaTransp.CL_Filtro = "TIPO='PV'"


        AsociarControles(TxClienteDesde, BtBuscaClienteDesde, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomClienteDesde)
        AsociarControles(TxClienteHasta, BtBuscaClienteHasta, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomClienteHasta)

    End Sub


    Private Sub FrmPortesSalida_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente

        CbTipoPorte = ComboTiposDePorte(CbTipoPorte)
        CbEmpresas = ComboEmpresas(CbEmpresas, MiMaletin.IdEmpresaCTB)

        BInforme.Visible = False

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxFechaDesde.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxFechaHasta.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        Grid.DataSource = Nothing
        GridView1.Columns.Clear()

        Dim sql As String = SQL_Grid()
        Dim DT As DataTable = Albsalida.MiConexion.ConsultaSQL(sql)

        Grid.DataSource = DT

        AñadeResumenCampo("Palets", "{0:n0}")

        AjustaColumnas()

    End Sub


    Private Sub AjustaColumnas()
        GridView1.BestFitColumns()
    End Sub


    Public Function SQL_Grid() As String

        Dim Acreedores As New E_Acreedores(Idusuario, cn)
        Dim Tarifaportes As New E_TarifaPortes(Idusuario, cn)
        Dim TiposPorte As New E_TiposPorte(Idusuario, cn)
        Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)

        Dim sql As String = ""
        Dim Consulta As New Cdatos.E_select
        Consulta.SelCampo(Albsalida.ASA_albaran, "Albaran")
        Consulta.SelCampo(Albsalida.ASA_fechasalida, "Fecha")
        Consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", Albsalida.ASA_idcliente)
        Consulta.SelCampo(Albsalida.ASA_matriculacamion, "Matricula")
        Consulta.SelCampo(Albsalida.ASA_matricularemolque, "MatRemolque")
        Consulta.SelCampo(Acreedores.ACR_Nombre, "Transportista", Albsalida.ASA_idtransportista)
        Consulta.SelCampo(TiposPorte.TPO_OrigenDestino, "OD", Albsalida.ASA_idtipoporte)
        Dim opalets As New Cdatos.bdcampo("@(Select sum(asl_palets) from albsalida_lineas where asl_idalbaran=asa_idalbaran)", Cdatos.TiposCampo.EnteroPositivo, 10)
        Consulta.SelCampo(opalets, "Palets")

        If TxClienteDesde.Text.Trim <> "" Then Consulta.WheCampo(Albsalida.ASA_idcliente, ">=", TxClienteDesde.Text)
        If TxClienteHasta.Text.Trim <> "" Then Consulta.WheCampo(Albsalida.ASA_idcliente, "<=", TxClienteHasta.Text)

        If TxDesdeTransp.Text.Trim <> "" Then Consulta.WheCampo(Albsalida.ASA_idtransportista, ">=", TxDesdeTransp.Text)
        If TxHastaTransp.Text.Trim <> "" Then Consulta.WheCampo(Albsalida.ASA_idtransportista, "<=", TxHastaTransp.Text)
        
        Consulta.WheCampo(Albsalida.ASA_fechasalida, ">=", TxFechaDesde.Text)
        Consulta.WheCampo(Albsalida.ASA_fechasalida, "<=", TxFechaHasta.Text)

        sql = Consulta.SQL


        sql = sql & CadenaWhereLista(Albsalida.ASA_IdEmpresa, ListadeCombo(CbEmpresas), " AND ")
        sql = sql & CadenaWhereLista(Albsalida.ASA_idtipoporte, ListadeCombo(CbTipoPorte), " AND ")

        Return sql

    End Function


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim ClientesDesde As String = ""
        Dim ClientesHasta As String = ""

        Dim TranspDesde As String = ""
        Dim TranspHasta As String = ""


        If Len(TxDesdeTransp.Text.Trim) > 0 Then TranspDesde = TxDesdeTransp.Text Else TranspDesde = "00000"
        If Len(TxHastaTransp.Text.Trim) > 0 Then TranspHasta = TxHastaTransp.Text Else TranspHasta = "99999"


        If Len(TxClienteDesde.Text.Trim) > 0 Then ClientesDesde = TxClienteDesde.Text Else ClientesDesde = "00000"
        If Len(TxClienteHasta.Text.Trim) > 0 Then ClientesHasta = TxClienteHasta.Text Else ClientesHasta = "99999"

        Dim FiltroCliente As String = FiltroDesdeHasta("Cliente", ClientesDesde, ClientesHasta)
        Dim FiltroTransp As String = FiltroDesdeHasta("Transportista", TranspDesde, TranspHasta)
        Dim FiltroFecha As String = FiltroDesdeHasta("Fecha", TxFechaDesde.Text, TxFechaHasta.Text)

        Dim empresa As String = FiltroCheckedComboBox("Empresa", CbEmpresas)
        Dim FiltroPuntoVenta As String = FiltroCheckedComboBox("Tipo Porte", CbTipoPorte)

        If Len(FiltroCliente.Trim) > 0 Then LineasDescripcion.Add(FiltroCliente)
        If Len(FiltroTransp.Trim) > 0 Then LineasDescripcion.Add(FiltroTransp)
        If Len(FiltroFecha.Trim) > 0 Then LineasDescripcion.Add(FiltroFecha)
        If Len(FiltroPuntoVenta) > 0 Then LineasDescripcion.Add(FiltroPuntoVenta)
        If empresa <> "" Then LineasDescripcion.Add(empresa)

        MyBase.Imprimir()

    End Sub


End Class