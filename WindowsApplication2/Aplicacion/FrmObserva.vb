Public Class FrmObserva
    Dim _id As String
    Dim _tipo As String
    Dim _codigo As String
    Dim Observaciones As New E_Observaciones(Idusuario, cn)

    Public Sub init(Tipo As String, Codigo As String)

        _id = Observaciones.LeerCodigo(Tipo, Codigo)
        _tipo = Tipo
        _codigo = Codigo

        TxDato.Text = ""
        If VaInt(_id) > 0 Then
            If Observaciones.LeerId(_id) = True Then
                TxDato.Text = Observaciones.OBS_Texto.Valor
            End If
        End If



    End Sub

    Private Sub TxDato_GotFocus(sender As Object, e As System.EventArgs) Handles TxDato.GotFocus
        TxDato.BackColor = Color.Yellow
    End Sub

    Private Sub TxDato_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxDato.KeyPress
        'If e.KeyChar = Chr(13) Then
        '    BotonGuardar.Focus()
        'End If
    End Sub

    Private Sub TxDato_LostFocus(sender As Object, e As System.EventArgs) Handles TxDato.LostFocus
        TxDato.BackColor = Color.White
    End Sub

    Private Sub TxDato_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato.TextChanged

    End Sub

    Private Sub BotonSalir_Click(sender As System.Object, e As System.EventArgs) Handles BotonSalir.Click
        Me.Close()
    End Sub

    Private Sub BotonGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BotonGuardar.Click
        Dim Nuevo As Boolean = False
        If VaInt(_id) = 0 Then
            _id = Observaciones.MaxId
            Observaciones.VaciaEntidad()
            Nuevo = True
        End If
        Observaciones.OBS_Id.Valor = _id
        Observaciones.OBS_Tipo.Valor = _tipo
        Observaciones.OBS_Codigo.Valor = _codigo
        Observaciones.OBS_Texto.Valor = TxDato.Text
        If Nuevo = True Then
            Observaciones.Insertar()
        Else
            Observaciones.Actualizar()


        End If
        Me.Close()
    End Sub

    Private Sub FrmObserva_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        TxDato.Focus()
    End Sub

    Private Sub FrmObserva_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class