
Public Class FrmPeriodoMedioExpedicion
    Inherits FrConsulta


    Private AlbSalida As New E_AlbSalida(Idusuario, cn)
    Private Generos As New E_Generos(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        ListaControles = New List(Of Object)


        ParamTx(TxDesdeFecha, AlbSalida.ASA_fechasalida, LbDesdeFecha, True)
        ParamTx(TxHastaFecha, AlbSalida.ASA_fechasalida, LbHastaFecha, True)
        ParamTx(TxDesdeGenero, Generos.GEN_IdGenero, LbDesdeGenero, True)


        AsociarControles(TxDesdeGenero, BtBuscaDesdeGenero, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNombreDesdeGenero)


    End Sub


    Private Sub FrmPeriodoMedioExpedicion_Load(sender As Object, e As System.EventArgs) Handles Me.Load



    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        FechasPorDefecto()

    End Sub


    Private Sub FechasPorDefecto()

        TxDesdeFecha.Text = Today.ToString("dd/MM/yyyy")
        TxHastaFecha.Text = Today.ToString("dd/MM/yyyy")

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        GridView1.Columns.Clear()


        Dim consulta As New Cdatos.E_select

        Dim sql As String = consulta.SQL


        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(consulta.SQL)
        Grid.DataSource = dt

        GridView1.BestFitColumns()


        AjustaColumnas()


        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("bultos", "{0:n2}")
        AñadeResumenCampo("Kilos", "{0:n2}")



    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

            End Select
        Next


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

            End Select
        Next

    End Sub

  
    
End Class