Imports DevExpress.XtraEditors


Public Class FrmActualizarMermas


    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro



    Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)


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

        If XtraMessageBox.Show("¿Desea actualizar las mermas de las líneas de palets?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim sql As String = "SELECT PLL_IdLinea as IdLinea, GES_PesoFijo as PesoFijo, PLL_KilosNetos as KilosNetos, PLL_KilosCliente as KilosCliente," & vbCrLf
            sql = sql & " PLL_Bultos as Bultos, PLL_KilosxBulto as KxBCli" & vbCrLf
            sql = sql & " FROM Palets_Lineas" & vbCrLf
            sql = sql & " LEFT JOIN GenerosSalida ON GES_IdGenSal = PLL_IdGenSal" & vbCrLf

            Dim dt As DataTable = Palets_Lineas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                ProgressBar1.Value = 0
                ProgressBar1.Maximum = dt.Rows.Count - 1

                For indice As Integer = 0 To dt.Rows.Count - 1

                    Dim row As DataRow = dt.Rows(indice)

                    Dim IdLinea As String = (row("IdLinea").ToString & "").Trim
                    If Palets_Lineas.LeerId(IdLinea) Then

                        Dim PesoFijo As String = (row("PesoFijo").ToString & "").Trim
                        Dim KilosNetos As Decimal = VaDec(row("KilosNetos"))
                        Dim KilosCliente As Decimal = VaDec(row("KilosCliente"))
                        'Dim KilosTeoricos As Decimal = VaDec(row("Bultos")) * VaDec(row("KxBCli"))

                        Dim Merma As Decimal = 0
                        If PesoFijo = "S" Then
                            Merma = KilosNetos - KilosCliente
                        End If
                        Palets_Lineas.PLL_Merma.Valor = Merma.ToString
                        Palets_Lineas.Actualizar()

                    End If


                    ProgressBar1.Value = indice

                Next

            End If

            MsgBox("Terminado!")

        End If


    End Sub




End Class