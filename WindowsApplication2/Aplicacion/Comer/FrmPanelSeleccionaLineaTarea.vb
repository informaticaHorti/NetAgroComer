Public Class FrmPanelSeleccionaLineaTarea


    Private _dt As DataTable = Nothing
    Private _IdLinea As String = ""
    Private _IdTarea As String = ""


    Public Property IdLinea As String
        Get
            Return _IdLinea
        End Get
        Set(value As String)
            _IdLinea = value
        End Set
    End Property


    Public Property IdTarea As String
        Get
            Return _IdTarea
        End Get
        Set(value As String)
            _IdTarea = value
        End Set
    End Property


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Public Sub New(dt As DataTable)
        Me.New()

        _dt = dt

    End Sub


    Private Sub FrmPanelValoraAlbCoste_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        If Not IsNothing(_dt) Then

            _dt.Columns.Add(New DataColumn("LineaTarea", GetType(String)))

            For indice As Integer = 0 To _dt.Rows.Count - 1
                Dim row As DataRow = _dt.Rows(indice)
                row("LineaTarea") = "Opcion " & (indice + 1).ToString & ": LINEA " & row("IdLinea").ToString & " - TAREA " & row("IdTarea").ToString
            Next

            CbLineaTarea.DataSource = _dt
            CbLineaTarea.ValueMember = "Id"
            CbLineaTarea.DisplayMember = "LineaTarea"

        End If


    End Sub


    Private Sub btAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btAceptar.Click

        If Not IsNothing(_dt) Then

            Dim Id As String = CbLineaTarea.SelectedValue.ToString & ""

            For Each row As DataRow In _dt.Rows
                If Id = (row("Id").ToString & "").Trim Then

                    _IdLinea = (row("IdLinea").ToString & "").Trim
                    _IdTarea = (row("IdTarea").ToString & "").Trim

                    Exit For
                End If
            Next

        End If



        Me.Close()

    End Sub



    Private Sub ClButton1_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub
End Class