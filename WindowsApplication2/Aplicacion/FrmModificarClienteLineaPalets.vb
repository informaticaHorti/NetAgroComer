Public Class FrmModificarClienteLineaPalets

    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro



    Public Enum ResultadoFormulario
        Aceptar
        Salir
    End Enum


    Private _Resultado As ResultadoFormulario = ResultadoFormulario.Salir
    Public ReadOnly Property Resultado As ResultadoFormulario
        Get
            Return _Resultado
        End Get
    End Property


    Private _IdLinea As String = ""
    Private _IdCliente As String = ""


    Private Palets_Lineas As New E_palets_lineas(Idusuario, cn)
    Private Clientes As New E_Clientes(Idusuario, cn)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

    End Sub


    Public Sub New(ByVal IdLinea As String, ByVal IdCliente As String)
        Me.New()


        _IdLinea = IdLinea
        _IdCliente = IdCliente


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub



    Private Sub ParametrosFrm()

        Dim cl As New Cdatos.PropiedadesTx
        cl.CampoBd = Palets_Lineas.PLL_IdCliente
        cl.Tipo = Palets_Lineas.PLL_IdCliente.TipoBd
        cl.Longitud = Palets_Lineas.PLL_IdCliente.Longitud
        cl.Obligatorio = True

        TxCliente.Orden = 0
        TxCliente.ClParam = cl
        TxCliente.ClForm = Me
        LbCliente.CL_ControlAsociado = TxCliente


        AsociarControles(TxCliente, BtBuscaCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNom_Cliente)


    End Sub


    Public Sub AsociarControles(ByRef tx As TxDato, ByRef boconsu As BtBusca, ByVal Origen As BtBusca, ByVal Tabla As Cdatos.Entidad,
                                Optional ByVal Campo As Cdatos.bdcampo = Nothing, Optional ByVal Etiq As Lb = Nothing,
                                Optional TextoToolTip As String = "Búsqueda alfabética")

        If Not boconsu Is Nothing Then

            If Not Origen Is Nothing Then
                boconsu.Image = Origen.Image
                boconsu.CL_CampoOrden = Origen.CL_CampoOrden
                boconsu.CL_DevuelveCampo = Origen.CL_DevuelveCampo
                boconsu.CL_ConsultaSql = Origen.CL_ConsultaSql
                boconsu.cl_formu = Origen.cl_formu
                boconsu.CL_ch1000 = Origen.CL_ch1000
                boconsu.cl_ListaW = Origen.cl_ListaW
                boconsu.CL_BuscaAlb = Origen.CL_BuscaAlb
                boconsu.CL_campocodigo = Origen.CL_campocodigo
                boconsu.CL_camponombre = Origen.CL_camponombre
                boconsu.CL_dfecha = Origen.CL_dfecha
                boconsu.CL_hfecha = Origen.CL_hfecha
                boconsu.CL_ParamBusqueda = Origen.CL_ParamBusqueda
                boconsu.CL_xCentro = Origen.CL_xCentro
                boconsu.CL_EsId = Origen.CL_EsId
                boconsu.CL_Ancho = Origen.CL_Ancho
                boconsu.CL_CONSULTA = Origen.CL_CONSULTA

            End If

            tx.ClParam.BtBusca = boconsu
            boconsu.CL_ControlAsociado = tx
            boconsu.CL_Entidad = Tabla

        End If


        If Not Campo Is Nothing Then

            tx.ClParam.CampoEnlace = Campo
            tx.ClParam.Entidadenlace = Tabla
            tx.ClParam.LabelEnlace = Etiq

            If Not IsNothing(Etiq) Then
                Etiq.CL_ValorFijo = False
                Etiq.CL_ControlAsociado = tx
            End If

        End If

    End Sub


    Private Sub FrmModificarClienteLineaPalets_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        TxCliente.Text = _IdCliente
        TxCliente.Validar(False)

    End Sub


    Private Sub FrmModificarClienteLineaPalets_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        TxCliente.Select()
        TxCliente.Focus()

    End Sub


    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click

        Me.Close()

    End Sub


    Private Sub BGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BGuardar.Click

        TxCliente.Validar(True)

        If Not TxCliente.MiError Then

            Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
            If Palets_Lineas.LeerId(_IdLinea) Then
                Palets_Lineas.PLL_IdCliente.Valor = TxCliente.Text
                Palets_Lineas.Actualizar()
            End If


            _Resultado = ResultadoFormulario.Aceptar

            Me.Close()


        Else
            MsgBox("Debe especificar un cliente válido")
        End If


    End Sub

    Private Sub TxCliente_Valida(edicion As Boolean) Handles TxCliente.Valida

        If edicion Then

            TxCliente.MiError = False

            If Clientes.CLI_Bloqueo.Valor = "S" Then

                TxCliente.MiError = True
                MsgBox("Cliente bloqueado:" & vbCrLf & vbCrLf & Clientes.CLI_Bloqueocausa.Valor)

            End If


            If Not TxCliente.MiError Then
                BGuardar.Select()
                BGuardar.Focus()
            End If

        End If

    End Sub


End Class