Public Class frmEdicionEntidades

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub


    Private Sub frmEdicionEntidades_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        CargaEntidades()

    End Sub


    Private Sub CargaEntidades()

        Dim dt As DataTable = ObtenerTablasAplicacion()

        For Each row As DataRow In dt.Rows
            Dim tabla As String = (row("Tabla").ToString & "").ToUpper
            row("Tabla") = tabla
        Next

        dt.Columns.Remove("Prefijo")
        dt.Columns.Remove("LogSN")

        GridEntidades.DataSource = dt

    End Sub


    Public Sub SeleccionaEntidad()

        Dim row As DataRow = GridViewEntidades.GetFocusedDataRow()
        If Not IsNothing(row) Then

            Dim tabla As String = (row("Tabla").ToString & "").Trim

            Dim asm As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly

            For Each ty As Type In asm.GetTypes()
                If ty.BaseType.Name.ToLower = "entidad" Then

                    Dim NombreEntidad As Type = asm.GetType(ty.FullName)
                    Dim f As Cdatos.Entidad = DirectCast(Activator.CreateInstance(NombreEntidad), Cdatos.Entidad)


                End If
            Next

        End If

    End Sub

    
    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub

    Private Sub GridViewEntidades_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridViewEntidades.RowCellClick

        SeleccionaEntidad()

    End Sub
End Class