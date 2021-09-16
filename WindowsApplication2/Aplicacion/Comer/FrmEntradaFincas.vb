Public Class FrmEntradaFincas



    Public Sub Init(ByVal IdAgricultor As String, ByVal IdGeneroCultivo As String, Optional IdFinca As String = "")

        Dim dt As DataTable = ObtenerCultivos(IdAgricultor, IdGeneroCultivo, False, IdFinca)


        Grid.DataSource = dt
        AjustaColumnas()

    End Sub


    


    Private Sub GridView1_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick

        Dim row As System.Data.DataRow
        row = GridView1.GetDataRow(e.RowHandle)

        If Not IsNothing(row) Then
            RowDePaso = row
            ' _Resultado = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub


    Private Sub GridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridView1.KeyPress
        If e.KeyChar = Chr(13) Then
            Intro()
        End If

    End Sub

    Private Sub Intro()
        Dim row As System.Data.DataRow

        row = GridView1.GetFocusedDataRow()
        If Not row Is Nothing Then
            RowDePaso = row
            ' _Resultado = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub


    Private Sub AjustaColumnas()


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDCULTIVO"
                    c.Width = 60
                Case "BLQ"
                    c.Width = 40
                Case "PROGRAMA", "TCULTIVO", "FECHARECOLECCION"
                    c.Width = 100
                Case "FINCANOMBRE", "GENERO", "OBSERVACIONES"
                    c.Width = 180
                Case "NAVE", "FINCA"
                    c.Width = 120
                Case "FECHASIEMBRA", "FECHASEG", "VARIEDAD"
                    c.Width = 100

                Case Else
                    c.Visible = False

            End Select

        Next


    End Sub

    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click
        RowDePaso = Nothing
        ' _Resultado = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub FrmEntradaFincas_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Grid.Focus()
        GridView1.Focus()
    End Sub

    Private Sub FrmEntradaFincas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        GridView1.OptionsView.ShowGroupPanel = False

    End Sub
End Class