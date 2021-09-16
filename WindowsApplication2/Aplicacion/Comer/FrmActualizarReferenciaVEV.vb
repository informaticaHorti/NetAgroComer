Imports DevExpress.XtraEditors


Public Class FrmActualizarReferenciaVEV
    Inherits FrConsulta



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

    End Sub


    Private Sub FrmActualizarLineasSalidaPalets_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        LbEjercicio.Text = MiMaletin.Ejercicio.ToString

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        BInforme.Visible = False
        GridView1.Appearance.HeaderPanel.BackColor = Color.Aquamarine


        BtAux.Text = "Actualizar"
        BtAux.Image = My.Resources.App_kservices_16x16_32
        BtAux.Visible = True

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


    End Sub



    Public Overrides Sub Consultar()
        MyBase.Consultar()

        If VaInt(LbEjercicio.Text) <= 0 Then
            MsgBox("Ejercicio no válido")
            Exit Sub
        End If

        Dim sql As String = "SELECT ASA_IdCentro, ASA_Albaran, ASA_Referencia, VEV_IdCentro, VEV_Campa, VEV_Numero, VEV_Referencia, VEV_IdVale" & vbCrLf
        sql = sql & " FROM ValeEnvases"
        sql = sql & " INNER JOIN AlbSalida ON ASA_idvaleenvase = VEV_IdVale"
        sql = sql & " WHERE VEV_Operacion = 'SC'"
        sql = sql & " AND COALESCE(VEV_Referencia,'') = ''"
        sql = sql & " AND COALESCE(ASA_Referencia,'') <> '' "
        sql = sql & " AND VEV_Campa = " & LbEjercicio.Text
        sql = sql & " ORDER BY VEV_IdVale"

        '        SELECT ASA_Referencia, VEV_Referencia, VEV_IdVale
        'FROM ValeEnvases
        'INNER JOIN AlbSalida ON ASA_idvaleenvasematerial = VEV_IdVale
        'WHERE (VEV_Operacion = 'CC' OR VEV_Operacion = 'SC')
        'AND COALESCE(VEV_Referencia,'') = ''
        'AND COALESCE(ASA_Referencia,'') <> '' 
        'AND VEV_Campa = " & LbEjercicio.Text
        'ORDER BY VEV_IdVale


        Dim dt As DataTable = cn.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            Dim colSel As New DataColumn("S", GetType(Boolean))
            colSel.DefaultValue = False
            dt.Columns.Add(colSel)
        End If

        Grid.DataSource = dt

    End Sub


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()

        If XtraMessageBox.Show("¿Desea actualizar los vales de envases?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim dt As DataTable = Grid.DataSource
            If Not IsNothing(dt) Then

                Dim cont As Integer = 0


                If dt.Rows.Count > 0 Then

                    ProgressBar1.Value = 0
                    ProgressBar1.Maximum = dt.Rows.Count - 1


                    For indice As Integer = 0 To dt.Rows.Count - 1

                        Dim row As DataRow = dt.Rows(indice)
                        If Not IsNothing(row) Then

                            If row("S") = True Then

                                Dim IdVale As String = (row("VEV_IdVale").ToString & "").Trim
                                Dim Referencia As String = (row("ASA_Referencia").ToString & "").Trim

                                Dim ValeEnvase As New E_ValeEnvases(Idusuario, cn)
                                If ValeEnvase.LeerId(IdVale) Then
                                    ValeEnvase.VEV_Referencia.Valor = Referencia
                                    ValeEnvase.Actualizar()
                                End If

                                cont = cont + 1

                            End If

                        End If


                        ProgressBar1.Value = indice

                    Next

                End If


                If cont = 0 Then
                    MsgBox("No hay registros marcados para actualizar")
                Else
                    MsgBox("Terminado! Se actualizaron " & cont.ToString & " registros")
                End If

            End If

        End If

    End Sub


    Private Sub btSelNinguno_Click(sender As System.Object, e As System.EventArgs) Handles btSelNinguno.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = False
            End If
        Next

    End Sub


    Private Sub btSelTodos_Click(sender As System.Object, e As System.EventArgs) Handles btSelTodos.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = True
            End If
        Next

    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

        If Not IsNothing(row) Then
            If column.FieldName.Trim.ToUpper = "S" Then
                row("S") = Not row("S")
            End If
        End If

    End Sub

End Class