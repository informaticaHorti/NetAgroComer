Imports DevExpress.XtraEditors


Public Class FrmActualizarVEV_PrecioCoste


    Private ValeEnvases_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
    Private Envases As New E_Envases(Idusuario, cn)
    Private ValeEnvases As New E_ValeEnvases(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If XtraMessageBox.Show("¿Desea actualizar el precio de coste de las lineas de los vales de envases?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Actualizar()

        End If

    End Sub


    Private Sub Actualizar()

        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(ValeEnvases_Lineas.VEL_Id, "IdLinea")
        CONSULTA.SelCampo(Envases.ENV_CosteSalida, "CosteSalida", ValeEnvases_Lineas.VEL_idenvase, Envases.ENV_IdEnvase)
        CONSULTA.SelCampo(ValeEnvases.VEV_Operacion, "Operacion", ValeEnvases_Lineas.VEL_idvale)

        Dim sql As String = CONSULTA.SQL & vbCrLf
        sql = sql & " WHERE (VEV_Operacion = 'SM' or VEV_Operacion = 'SC')" & vbCrLf
        sql = sql & " AND COALESCE(VEL_PrecioCoste,0) = 0"


        Dim dt As DataTable = ValeEnvases_Lineas.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dt) Then

            ProgressBar1.Value = 0
            ProgressBar1.Maximum = dt.Rows.Count

            For Each row As DataRow In dt.Rows

                Dim IdLinea As String = row("IdLinea").ToString & ""
                Dim CosteSalida As Decimal = VaDec(row("CosteSalida"))

                If ValeEnvases_Lineas.LeerId(IdLinea) Then

                    ValeEnvases_Lineas.VEL_preciocoste.Valor = CosteSalida.ToString
                    ValeEnvases_Lineas.Actualizar()

                    Application.DoEvents()

                End If

                If ProgressBar1.Value < ProgressBar1.Maximum Then ProgressBar1.Value = ProgressBar1.Value + 1

            Next

        End If

        MsgBox("Terminado!")

    End Sub

End Class