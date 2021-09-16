Public Class FrmValertas


    Dim alertas As New E_Alertas(Idusuario, cn)
    Private Sub FrmVactividad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cargagrid()

        '  Timer1.Enabled = True
    End Sub

    Private Sub Cargagrid()

        Dim consulta As New Cdatos.E_select
        Dim sql As String
        consulta.SelCampo(alertas.ALE_fecha, "Fecha")
        consulta.SelCampo(alertas.ALE_hora, "Hora")
        consulta.SelCampo(alertas.ALE_idusuario, "id")
        consulta.SelCampo(alertas.ALE_NombreUsuario, "Usuario")
        consulta.SelCampo(alertas.ALE_Alerta, "Alerta")
        consulta.SelCampo(alertas.ALE_Email, "Email")

        Sql = consulta.SQL
        sql = sql + " order by ALE_Fecha DESC,ALE_hora DESC,ALE_ID desc "

        Dim dt As DataTable = cn.ConsultaSQL(sql)


    

        Grid.DataSource = dt




        AjustaColumnas2()
    End Sub



    Private Sub Bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub


    Private Sub AjustaColumnas2()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "HORA"
                    c.MaxWidth = 100
                    c.Width = 100


                Case "FECHA"
                    c.MaxWidth = 100
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    c.DisplayFormat.FormatString = "dd/MM/yyyy"



            End Select

            GridView1.BestFitColumns()
        Next

    End Sub

   




End Class