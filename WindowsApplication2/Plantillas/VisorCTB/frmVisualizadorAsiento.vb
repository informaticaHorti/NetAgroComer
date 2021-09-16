Public Class frmVisualizadorAsiento


    Private err As New Errores
    Private _ListaIdAsientos As New List(Of Integer)
    Private _VB6 As Boolean = False
    Private _ejerciciovb6 As String
    Private _IdEmpresa As Integer = 0


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Public Sub New(ByVal listaIdAsientos As List(Of Integer), ByVal vb6 As Boolean, Optional ByVal ejerciciovb6 As String = "", Optional ByVal IdEmpresa As Integer = 0)


        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Try
            _ListaIdAsientos = listaIdAsientos
            _VB6 = vb6
            _ejerciciovb6 = ejerciciovb6
            _IdEmpresa = IdEmpresa

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase ", "New", ex.Message)
        End Try


    End Sub

    Private Sub frmVisualizadorAsiento_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated

        btAceptar.Focus()

    End Sub

    Private Sub frmVisualizadorAsiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For Each i As Integer In _ListaIdAsientos

            Dim IdEmpresa As Integer = MiMaletin.IdEmpresaCTB
            If _IdEmpresa <> 0 Then
                IdEmpresa = _IdEmpresa
            End If

            Dim asi As New E_Asientos(Idusuario, ConexCtb(IdEmpresa))
            If asi.LeerId(i.ToString) Then
                ListBox1.Items.Add("- Asiento nº " & asi.Ejercicio.Valor & "-" & asi.Asiento.Valor & " generado correctamente. Id: " + i.ToString & ". Centro: " & asi.IdCentro.Valor & "")
            End If
        Next

    End Sub

    Private Sub btAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAceptar.Click
        Me.Close()
    End Sub

    Private Sub btVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVisualizar.Click

        Dim f As New FrmConsultaVisuAsiento(_ListaIdAsientos, _VB6, _ejerciciovb6, _IdEmpresa)
        f.ShowDialog(Me)

    End Sub

    Private Sub btImpresionDirecta_Click(sender As System.Object, e As System.EventArgs) Handles btImpresionDirecta.Click

        Dim f As New FrmConsultaVisuAsiento(_ListaIdAsientos, _VB6, _ejerciciovb6, _IdEmpresa)
        f.Init(True)
        f.ShowDialog(Me)

    End Sub
End Class