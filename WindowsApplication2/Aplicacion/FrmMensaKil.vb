Public Class FrmMensaKil
    Public Sub Init(ByVal K1 As Double, ByVal b1 As Double, ByVal K2 As Double, ByVal b2 As Double)
        Lbk1.Text = Format(K1, "#,###")
        LbKb1.Text = Format(b1, "###0.00")

        Lbk2.Text = Format(K2, "#,###")
        LbKb2.Text = Format(b2, "###0.00")

        Lbdif1.Text = Format(K1 - K2, "#,###")
        LbDif2.Text = Format(b1 - b2, "###0.00")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        EnlaceCodigo = "S"
        Me.Close()

    End Sub


    Private Sub FrmMensaKil_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Button1.Focus()
    End Sub

    Private Sub FrmMensaKil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class