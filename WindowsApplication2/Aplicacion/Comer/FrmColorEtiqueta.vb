Public Class FrmColorEtiqueta

    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro


    Dim _Calidad As String = ""



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(Calidad As String)
        Me.New()

        _Calidad = Calidad

        LbCalidad.Text = Chr(34) & _Calidad & Chr(34)


        Select Case _Calidad

            Case "A"
                pnlColor.BackColor = Color.FromArgb(92, 166, 68)
            Case "B"
                pnlColor.BackColor = Color.Gold
            Case "C"
                pnlColor.BackColor = Color.DarkOrange
            Case "D"
                pnlColor.BackColor = Color.Salmon
            Case "E"
                pnlColor.BackColor = Color.Red
            Case Is > "E"
                pnlColor.BackColor = Color.Red
            Case Else
                pnlColor.BackColor = Color.White
        End Select

    End Sub


    Private Sub ParametrosFrm()

    End Sub



    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click

        Me.Close()

    End Sub


    
End Class