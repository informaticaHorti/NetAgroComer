Public Class FrmVprocesosdia
    Dim Seg As Integer

    Dim Usuarios_procesos As New E_usuarios_procesos(Idusuario, cn)
    Dim Usuarios As New E_Usuarios(Idaplicacion, CnComun)
    Private Sub FrmVactividad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Barra.Properties.Maximum = 3
        Seg = 0
        Cargagrid()

        '  Timer1.Enabled = True
    End Sub

    Private Sub Cargagrid()

        Dim sql As String
        Dim NombreUsu As String = ""


        If ChUsu.CheckState = CheckState.Checked Then

            sql = " SELECT  MAX(UPR_ID) as id FROM usuarios_procesos GROUP BY UPR_idusuario "
            Dim dt1 As DataTable = cn.ConsultaSQL(sql)

            If Not dt1 Is Nothing Then
                Dim colP1 As New DataColumn("Idusuario", GetType(Int32))
                colP1.DefaultValue = 0
                dt1.Columns.Add(colP1)

                Dim colP2 As New DataColumn("Usuario", GetType(String))
                colP2.DefaultValue = ""
                dt1.Columns.Add(colP2)

                Dim colP3 As New DataColumn("Formulario", GetType(String))
                colP3.DefaultValue = ""
                dt1.Columns.Add(colP3)

                Dim colP4 As New DataColumn("Proceso", GetType(String))
                colP4.DefaultValue = ""
                dt1.Columns.Add(colP4)

                Dim colP8 As New DataColumn("Fichero", GetType(String))
                colP8.DefaultValue = ""
                dt1.Columns.Add(colP8)


                Dim colP5 As New DataColumn("Registro", GetType(String))
                colP5.DefaultValue = ""
                dt1.Columns.Add(colP5)

                Dim colP6 As New DataColumn("Fecha", GetType(Date))
                colP6.DefaultValue = "01/01/1900"
                dt1.Columns.Add(colP6)

                Dim colP7 As New DataColumn("Hora", GetType(String))
                colP7.DefaultValue = ""
                dt1.Columns.Add(colP7)

                For Each rw In dt1.Rows

                    Dim id As String = rw("ID").ToString
                    If Usuarios_procesos.LeerId(id) = True Then
                        NombreUsu = ""
                        If Usuarios.LeerId(Usuarios_procesos.UPR_idusuario.Valor) Then
                            NombreUsu = Usuarios.Nombre.Valor
                        End If

                        rw("Idusuario") = Usuarios_procesos.UPR_idusuario.Valor
                        rw("Usuario") = NombreUsu
                        rw("Formulario") = Usuarios_procesos.UPR_formulario.Valor
                        rw("Proceso") = Usuarios_procesos.UPR_proceso.Valor
                        rw("Fichero") = Usuarios_procesos.UPR_entidad.Valor
                        rw("Registro") = Usuarios_procesos.UPR_identidad.Valor
                        rw("Fecha") = Usuarios_procesos.UPR_fecha.Valor
                        rw("Hora") = Usuarios_procesos.UPR_hora.Valor
 

                    End If
                Next

            End If


            Grid.DataSource = dt1


        Else

            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(Usuarios_procesos.UPR_id, "ID")
            consulta.SelCampo(Usuarios_procesos.UPR_idusuario, "Idusuario")
            consulta.SelCampo(Usuarios.Nombre, "Usuario", Usuarios_procesos.UPR_idusuario)
            consulta.SelCampo(Usuarios_procesos.UPR_formulario, "Formulario")
            consulta.SelCampo(Usuarios_procesos.UPR_proceso, "Proceso")
            consulta.SelCampo(Usuarios_procesos.UPR_entidad, "Fichero")
            consulta.SelCampo(Usuarios_procesos.UPR_identidad, "Registro")
            consulta.SelCampo(Usuarios_procesos.UPR_fecha, "Fecha")
            consulta.SelCampo(Usuarios_procesos.UPR_hora, "Hora")
            consulta.WheCampo(Usuarios_procesos.UPR_idaplicacion, "=", Idaplicacion)

            sql = consulta.SQL
            sql = sql + " order by UPR_Fecha DESC,UPR_hora DESC,UPR_ID desc "

            Dim dt As DataTable = cn.ConsultaSQL(sql)
            Grid.DataSource = dt

        End If

        AjustaColumnas2()
    End Sub

    Private Sub CuentaCiclos()
        Seg = Seg + 1
        If Seg >= Barra.Properties.Maximum Then
            Timer1.Enabled = False
            Cargagrid()
            Seg = 0
            Timer1.Enabled = True
        End If
        Barra.EditValue = Seg
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        CuentaCiclos()
    End Sub

    Private Sub ChActu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChActu.CheckedChanged
        If ChActu.CheckState = CheckState.Checked Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
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

                Case "ENTIDAD"
                    c.MaxWidth = 200
                    c.Width = 200

                Case "FORMULARIO", "PROCESO"
                    c.MaxWidth = 300
                    c.Width = 300

                Case "FECHA"
                    c.MaxWidth = 100
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    c.DisplayFormat.FormatString = "dd/MM/yyyy"
                Case "ID"
                    c.Width = 100
                    'c.Visible = False

                Case "IDUSUARIO"
                    c.Width = 50

                Case "USUARIO"
                    c.Width = 100



            End Select

            GridView1.BestFitColumns()
        Next
       
    End Sub

    Private Sub ChUsu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChUsu.CheckedChanged
        GridView1.Columns.Clear()

        Cargagrid()
    End Sub



    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle


        Dim row As System.Data.DataRow
        row = GridView1.GetDataRow(e.RowHandle)
        Select Case row("Proceso").ToString.ToUpper
            Case "BAJA"
                e.Appearance.BackColor = Color.Red
            Case "ALTA"
                e.Appearance.BackColor = Color.LightBlue
            Case "CONSULTA"
                e.Appearance.BackColor = Color.LightCyan
            Case "MODIFICACION"
                e.Appearance.BackColor = Color.LightGray
            Case "ABRIENDO FORMULARIO"
                e.Appearance.BackColor = Color.LightSalmon
            Case "ABRIENDO CONSULTA"
                e.Appearance.BackColor = Color.LightSeaGreen
            Case "CERRANDO FORMULARIO"
                e.Appearance.BackColor = Color.LightSkyBlue
            Case "CERRANDO CONSULTA"
                e.Appearance.BackColor = Color.LightYellow

        End Select


    End Sub

    Private Sub Grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.Click

    End Sub
End Class