Imports System.Text.RegularExpressions

Public Class FrmConfirmarEmail

    Public Enum ResultadoFormulario
        Enviar
        Cancelar
    End Enum



    Private _lstDestinatarios As List(Of String)
    Private _resultado As ResultadoFormulario = ResultadoFormulario.Cancelar



    Public ReadOnly Property Destinatarios As List(Of String)
        Get
            Return _lstDestinatarios
        End Get
    End Property


    Public ReadOnly Property Resultado As ResultadoFormulario
        Get
            Return _resultado
        End Get
    End Property




    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim param As New Cdatos.PropiedadesTx
        param.Obligatorio = True
        param.Tipo = Cdatos.TiposCampo.Cadena
        param.Longitud = 500
        TxEmail.ClParam = param
        TxEmail.ClForm = Me
        TxEmail.Orden = 0


    End Sub


    Public Sub Init(lstEmails As List(Of String))

        _lstDestinatarios = lstEmails

    End Sub


    Private Sub FrmPedirDatosEmail_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        If Not IsNothing(_lstDestinatarios) Then

            'Hemos realizado el Init
            For Each mail As String In _lstDestinatarios
                If TxEmail.Text.Trim <> "" Then TxEmail.Text = TxEmail.Text & ";"
                TxEmail.Text = TxEmail.Text & mail
            Next

        Else
            _lstDestinatarios = New List(Of String)
        End If

    End Sub


    Private Sub TxEmail_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxEmail.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            BEnviar.Select()
            BEnviar.Focus()
        End If
    End Sub


    Private Sub BEnviar_Click(sender As System.Object, e As System.EventArgs) Handles BEnviar.Click

        If Validar() Then


            _lstDestinatarios.Clear()

            Dim destinatarios As String() = Split(TxEmail.Text.Trim, ";")
            For Each mail As String In destinatarios
                _lstDestinatarios.Add(mail)
            Next

            _resultado = ResultadoFormulario.Enviar


            Me.Close()

        Else
            MsgBox("Debe introducir un email y asunto válidos")
        End If

    End Sub


    Private Function Validar() As Boolean

        Dim bRes As Boolean = False


        If TxEmail.Text.Trim <> "" Then

            Dim destinatarios As String() = Split(TxEmail.Text.Trim, ";")
            If destinatarios.Length > 0 Then

                Dim bMailsValidos As Boolean = True

                For Each mail As String In destinatarios
                    'Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
                    Static emailExpression As New Regex("^[_a-z0-9-]+([.a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
                    If Not emailExpression.IsMatch(mail.ToLower) Then
                        bMailsValidos = False
                        Exit For
                    End If
                Next


                bRes = bMailsValidos

            End If

        End If


        Return bRes

    End Function


    Private Sub BCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BCancelar.Click

        Me.Close()

    End Sub

    
End Class