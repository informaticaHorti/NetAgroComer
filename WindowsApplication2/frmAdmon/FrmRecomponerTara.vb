Imports DevExpress.XtraEditors


Public Class FrmRecomponerTara


    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro



    Dim Envases As New E_Envases(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()


    End Sub



    Private Sub FrmDesbloquearLinea_Load(sender As Object, e As System.EventArgs) Handles Me.Load



    End Sub


    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click

        Me.Close()

    End Sub


    Private Sub BGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BGuardar.Click

        If XtraMessageBox.Show("¿Desea recomponer la tara de costes y de tipos de confección?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim sql As String = "SELECT ENV_IdEnvase as IdEnvase FROM Envases ORDER BY ENV_IdEnvase"
            Dim dt As DataTable = Envases.MiConexion.ConsultaSQL(sql)


            If Not IsNothing(dt) Then

                ProgressBar1.Value = 0
                ProgressBar1.Maximum = dt.Rows.Count - 1


                For indice As Integer = 0 To dt.Rows.Count - 1

                    Dim row As DataRow = dt.Rows(indice)

                    Dim IdEnvase As String = (row("IdEnvase").ToString & "").Trim
                    If VaInt(IdEnvase) > 0 Then

                        Agro_ActualizaTarasEnvase(IdEnvase)
                        Application.DoEvents()

                        Agro_ActualizaTarasPalet(IdEnvase)
                        Application.DoEvents()

                    End If

                    ProgressBar1.Value = indice

                Next

            End If


            MsgBox("Terminado!")

        End If


    End Sub




End Class