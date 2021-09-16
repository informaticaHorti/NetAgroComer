Public Class FrmPasoUsuariosWeb


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub FrmPasoUsuariosWeb_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        TxNetAgro.Text = cn.CadenaConexion


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If MsgBox("¿Está seguro de pasar los datos de la tabla UsuariosWeb?", MsgBoxStyle.YesNo, "ATENCIÓN") = MsgBoxResult.Yes Then


            Dim cnHorti As New Cdatos.Conexion(txVB6.Text)

            Dim sql As String = "SELECT Codigo, Linea, CdAgricultor, Password FROM UsuariosWeb ORDER BY Codigo, Linea"
            Dim dt As DataTable = cnHorti.ConsultaSQL(sql)

            If Not IsNothing(dt) Then

                sql = "DELETE FROM UsuariosWeb"
                cn.OrdenSql(sql)


                ProgressBar1.Value = 0
                ProgressBar1.Maximum = dt.Rows.Count - 1

                For indice As Integer = 0 To dt.Rows.Count - 1

                    Dim row As DataRow = dt.Rows(indice)
                    Dim Codigo As String = VaInt(row("Codigo")).ToString
                    Dim Linea As String = VaInt(row("Linea")).ToString
                    Dim IdAgricultor As String = VaInt(row("CdAgricultor")).ToString
                    Dim Password As String = (row("Password").ToString & "").Trim


                    Dim UsuariosWeb As New E_UsuariosWeb(Idusuario, cn)
                    UsuariosWeb.UWB_Id.Valor = UsuariosWeb.MaxId()
                    UsuariosWeb.UWB_Codigo.Valor = Codigo
                    UsuariosWeb.UWB_Linea.Valor = Linea
                    UsuariosWeb.UWB_IdAgricultor.Valor = IdAgricultor
                    UsuariosWeb.UWB_Password.Valor = Password
                    UsuariosWeb.Insertar()


                    ProgressBar1.Value = indice

                    Application.DoEvents()

                Next

            End If


            MsgBox("Terminado!")

            ProgressBar1.Value = 0

        End If


    End Sub
End Class