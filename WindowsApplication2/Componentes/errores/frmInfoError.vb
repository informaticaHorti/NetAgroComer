Public Class frmInfoError
    Private err As New ClErrores(Me.ToString)
    Private Sub frmInfoError_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'Me.Icon = My.Resources.Action_button_info_16x16_32
        Catch ex As Exception
            err.MuestraError("No se pudo cargar el formulario", "frmInfoError_Load", ex.Message)
        End Try

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(ByVal texto As String)
        Try
            InitializeComponent()
            Me.MemoEdit1.Text = texto
        Catch ex As Exception
            err.MuestraError("No se pudo iniciar la clase", "New", ex.Message)
        End Try
    End Sub
End Class