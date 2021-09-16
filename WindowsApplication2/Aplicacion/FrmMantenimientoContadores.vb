Public Class FrmMantenimientoContadores


    Public Sub New()
        InitializeComponent()
        Me.MinimumSize = Me.Size
        ParametrosFrm()
    End Sub


    Private Sub ParametrosFrm()

        RbFacAgri.Checked = True
        TxUltimo.Text = ""
        TxSerie.Focus()

    End Sub


    Private Sub CalculaUN()

        TxUltimo.Text = ObtieneUltimoNumero.ToString

    End Sub


    Private Function ObtieneUltimoNumero() As Integer

        Dim Numero As Integer

        Select Case True

            Case RbFacAgri.Checked
                Dim Entidad As New E_FacturaAgr(Idusuario, cn)
                Numero = Entidad.UltimoNumero(MiMaletin.IdEmpresaCTB, MiMaletin.Ejercicio, TxSerie.Text)

            Case RbLiqAgri.Checked
                Dim Entidad As New E_LiquidacionAgr(Idusuario, cn)
                Numero = Entidad.UltimoNumero(MiMaletin.IdEmpresaCTB, MiMaletin.Ejercicio, TxSerie.Text)

            Case rbFacturasClientes.Checked
                Dim Entidad As New E_Facturas(Idusuario, cn)
                Numero = Entidad.UltimoNumero(MiMaletin.IdEmpresaCTB, MiMaletin.Ejercicio, TxSerie.Text)

        End Select


        Return Numero

    End Function


    Private Function GuardaUN(ByVal Numero As Integer) As Boolean

        Dim OK As Boolean = True

        Try
            Select Case True

                Case RbFacAgri.Checked
                    Dim Entidad As New E_FacturaAgr(Idusuario, cn)
                    Entidad.ActuContador(MiMaletin.IdEmpresaCTB, MiMaletin.Ejercicio, TxSerie.Text, Numero)

                Case RbLiqAgri.Checked
                    Dim Entidad As New E_LiquidacionAgr(Idusuario, cn)
                    Entidad.ActuContador(MiMaletin.IdEmpresaCTB, MiMaletin.Ejercicio, TxSerie.Text, Numero)

                Case rbFacturasClientes.Checked
                    Dim Entidad As New E_Facturas(Idusuario, cn)
                    Entidad.ActuContador(MiMaletin.IdEmpresaCTB, MiMaletin.Ejercicio, TxSerie.Text, Numero)

            End Select


        Catch ex As Exception
            OK = False
        End Try


        Return OK
    End Function



#Region "Eventos"

    Private Sub BGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGuardar.Click
        Dim OK As Boolean = GuardaUN(VaInt(TxUltimo.Text))
        If OK Then
            MsgBox("Se ha guardado correctamente.")
        Else
            MsgBox("Error en el guardado.")
        End If
    End Sub

    Private Sub Bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub


#End Region


    Private Sub Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub FrmMantenimientoContadores_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        TxUltimo.Text = ObtieneUltimoNumero().ToString
    End Sub


    Private Sub RadioAgricultores_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbFacAgri.CheckedChanged
        CalculaUN()
        If TxUltimo.Text = -1 Then TxUltimo.Text = ""
    End Sub

    Private Sub TxSerie_GotFocus(sender As Object, e As System.EventArgs) Handles TxSerie.GotFocus
        TxSerie.BackColor = Color.Yellow
    End Sub

    Private Sub TxSerie_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxSerie.KeyPress
        If e.KeyChar = Chr(13) Then
           
            TxUltimo.Focus()
        End If
    End Sub



    Private Sub TxUltimo_GotFocus(sender As Object, e As System.EventArgs) Handles TxUltimo.GotFocus
        CalculaUN()
        If TxUltimo.Text = -1 Then TxUltimo.Text = ""
    End Sub

    Private Sub RbLiqAgri_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbLiqAgri.CheckedChanged
        CalculaUN()
        If TxUltimo.Text = -1 Then TxUltimo.Text = ""
    End Sub

    Private Sub rbFacturasClientes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbFacturasClientes.CheckedChanged
        CalculaUN()
        If TxUltimo.Text = -1 Then TxUltimo.Text = ""
    End Sub
End Class