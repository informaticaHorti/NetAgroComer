Public Class FrmPINFacturas

    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro


    Public Enum ResultadoClave
        PIN_Ok
        PIN_Incorrecto
        Cancelado
    End Enum


    Private _Resultado As ResultadoClave = ResultadoClave.Cancelado
    Public ReadOnly Property Resultado As ResultadoClave
        Get
            Return _Resultado
        End Get
    End Property


    Dim _PIN As String = ""



    Private DatosEmpresa As New E_DatosEmpresa(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(PIN As String)
        Me.New()

        _PIN = PIN

    End Sub


    Private Sub ParametrosFrm()

        Dim cl As New Cdatos.PropiedadesTx
        cl.CampoBd = DatosEmpresa.PINFacturas
        cl.Tipo = Cdatos.TiposCampo.Cadena
        cl.Longitud = DatosEmpresa.PINFacturas.Longitud
        cl.Obligatorio = True

        TxDato1.Orden = 0
        TxDato1.ClParam = cl

        TxDato1.ClForm = Me
        Lb1.CL_ControlAsociado = TxDato1
        Lb1.CL_ValorFijo = True

    End Sub


    Private Sub FrmClaveBotones_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        TxDato1.Select()
        TxDato1.Focus()

    End Sub


    Private Sub TxDato1_Valida(edicion As System.Boolean) Handles TxDato1.Valida
        ValidarClave()
    End Sub


    Private Sub TxDato1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato1.KeyDown

        If e.KeyCode = Keys.Escape Then
            _Resultado = ResultadoClave.Cancelado
            Me.Close()
        End If

    End Sub


    Private Sub BtAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BtAceptar.Click
        ValidarClave()
    End Sub


    Private Sub ValidarClave()


        If TxDato1.Text = _PIN Then
            _Resultado = ResultadoClave.PIN_Ok
        Else
            MsgBox("Clave incorrecta")
            _Resultado = ResultadoClave.PIN_Incorrecto
        End If


        Me.Close()

    End Sub


    Private Sub BtCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BtCancelar.Click
        _Resultado = ResultadoClave.Cancelado
        Me.Close()
    End Sub


End Class