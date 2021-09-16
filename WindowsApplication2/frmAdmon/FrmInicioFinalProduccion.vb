Imports DevExpress.XtraEditors


Public Class FrmInicioFinalProduccion
    Inherits FrConsulta


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()



    End Sub



    Private Sub FrmConsultaCuentasAgricultoresClientes_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Consultar()

    End Sub



    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim sql As String = "SELECT * FROM PRODUCCION"
        Dim dt As DataTable = cn.ConsultaSQL(sql)

        Dim dtFinal As DataTable = dt.Clone

        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows

                Dim finicio As DateTime
                Dim ffinal As DateTime

                Dim inicio As String = Today.ToString("dd/MM/yyyy") & " " & (row("PRD_HoraInicio").ToString & "").Trim
                Dim final As String = Today.ToString("dd/MM/yyyy") & " " & (row("PRD_HoraFinal").ToString & "").Trim

                If Not DateTime.TryParse(inicio, finicio) Then
                    dtFinal.ImportRow(row)
                ElseIf Not DateTime.TryParse(final, ffinal) Then
                    dtFinal.ImportRow(row)
                End If

            Next

        End If



        Grid.DataSource = dtFinal
        GridView1.BestFitColumns()

    End Sub


    
End Class