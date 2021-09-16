Public Class FrmIntroducirOperario

    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro


    Public Enum RespuestaFormulario
        Validar
        Salir
    End Enum

    Private _Respuesta As RespuestaFormulario = RespuestaFormulario.Salir

    Public ReadOnly Property Respuesta As RespuestaFormulario
        Get
            Return _Respuesta
        End Get
    End Property

    Public ReadOnly Property IdOperario As Integer
        Get
            Return _IdOperario
        End Get
    End Property

    Public ReadOnly Property Operario
        Get
            Return _Operario
        End Get
    End Property


    Dim Operarios As New E_Operarios(Idusuario, cn)
    Dim _bCerrar As Boolean = False
    Dim _padre As _FrMPrincipal = Nothing
    Dim _IdOperario As Integer = 0
    Dim _Operario As String = ""


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent()
        ParametrosFrm()

    End Sub

    Public Sub New(padre As _FrMPrincipal)
        Me.New()

        _padre = padre

    End Sub


    Private Sub ParametrosFrm()

        Dim cl As New Cdatos.PropiedadesTx
        cl.Tipo = Cdatos.TiposCampo.Cadena
        cl.Longitud = Operarios.OPE_Rfid.Longitud


        cl.Obligatorio = True

        TxCodigo.Orden = 0
        TxCodigo.ClParam = cl
        TxCodigo.ClForm = Me

        Lb1.CL_ControlAsociado = TxCodigo
        Lb1.CL_ValorFijo = True

    End Sub


    Private Sub FrmIntroducirOperario_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        TxCodigo.Select()
        TxCodigo.Focus()

    End Sub


    Private Sub TxCodigo_Valida(edicion As System.Boolean) Handles TxCodigo.Valida

        If edicion And Not TxCodigo.MiError Then

            Dim Codigo As String = TxCodigo.Text
            Codigo = Codigo.PadLeft(DigitosRfid, "0").Substring(0, DigitosRfid)


            _IdOperario = Operarios.ObtenerIdOperario(Codigo, _Operario)
            If _IdOperario <= 0 Then
                MsgBox("Código no válido")
                TxCodigo.Select()
                TxCodigo.Focus()
            Else
                LbNombreOperario.Text = _Operario
                btValidar.Select()
                btValidar.Focus()
            End If

        End If

    End Sub


    Private Sub FrmIntroducirOperario_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not _bCerrar Then e.Cancel = True
    End Sub


    Private Sub btCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btCancelar.Click

        _IdOperario = 0

        LbNombreOperario.Text = ""

        TxCodigo.Text = ""
        TxCodigo.Select()
        TxCodigo.Focus()

    End Sub

    Private Sub btValidar_Click(sender As System.Object, e As System.EventArgs) Handles btValidar.Click

        If LbNombreOperario.Text.Trim = "" Then
            TxCodigo.Validar(True)
        Else
            _Respuesta = RespuestaFormulario.Validar
            _bCerrar = True
            Me.Close()
        End If

    End Sub


   
    Private Sub btSalir_Click(sender As System.Object, e As System.EventArgs) Handles btSalir.Click

        _Respuesta = RespuestaFormulario.Salir
        _bCerrar = True
        Me.Close()

    End Sub

    
End Class