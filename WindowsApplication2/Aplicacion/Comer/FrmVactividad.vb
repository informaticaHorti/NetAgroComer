Public Class FrmVactividad

    Dim Usuarios As New E_Usuarios(Idusuario, CnComun)
    Private Sub FrmVactividad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Cargagrid()
        Timer1.Enabled = True
    End Sub

    Private Sub Cargagrid()

        Dim sql As String = ""
        sql = "Select BLQ_Entidad as Entidad,BLQ_proceso as proceso,BLQ_id as id,BLQ_Fecha as Fecha,BLQ_idusuario as Idusuario,BLQ_NombreUsuario as Usuario from bloqueos order by BLQ_fecha"
        Dim dt As DataTable = cn.ConsultaSQL(sql)
        Dim colP1 As New DataColumn("S", GetType(Boolean))
        colP1.DefaultValue = False
        dt.Columns.Add(colP1)
        Grid.DataSource = dt

        For Each RW In dt.Rows
            If Usuarios.LeerId(RW("idusuario").ToString) = True Then
                RW("Usuario") = Usuarios.Nombre.Valor

            End If
        Next
        AjustaColumnas2()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Cargagrid()
    End Sub

    Private Sub ChActu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChActu.CheckedChanged
        If ChActu.CheckState = True Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub

    Private Sub BtSelTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSelTodos.Click
        For indice As Integer = 0 To GridView.RowCount - 1

            Dim row As DataRow = GridView.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = True
            End If

        Next

    End Sub

    Private Sub BtSelNinguno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSelNinguno.Click
        For indice As Integer = 0 To GridView.RowCount - 1

            Dim row As DataRow = GridView.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = False
            End If

        Next


    End Sub

    Private Sub BtGenerarPalets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtGenerarPalets.Click
        If MsgBox("Desea quitar los bloqueos seleccionados", vbYesNo) = vbYes Then


            For indice As Integer = 0 To GridView.RowCount - 1

                Dim row As DataRow = GridView.GetDataRow(indice)
                If Not IsNothing(row) Then

                    If row("S") = True Then
                        Dim sql As String = ""
                        sql = "Delete from Bloqueos where BLQ_Entidad='" + row("Entidad") + "'"
                        sql = sql + " and BLQ_id='" + row("Id") + "'"
                        cn.OrdenSql(sql)

                    End If
                End If
            Next

        End If
        Cargagrid()
    End Sub

    Private Sub AjustaColumnas2()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "ENTIDAD"
                    c.MaxWidth = 100

                Case "FECHA"
                    c.MaxWidth = 100
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    c.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss"
                Case "ID"
                    c.Width = 50

                Case "USUARIO"
                    c.Width = 100


                Case "PROCESO", "NOMBREUSUARIO"
                    c.Width = 100


                Case "S"
                    c.Width = 50




            End Select


        Next

        GridView.BestFitColumns()

    End Sub

End Class