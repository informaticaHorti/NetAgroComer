
Public Class FrmConsultaPrevisiones
    Inherits FrConsulta


    Dim Previsiones As New E_Previsiones(Idusuario, cn)
    Dim Previsiones_Lineas As New E_Previsiones_lineas(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDesdeAgricultor, Agricultores.AGR_idagricultor, LbDesdeAgricultor)
        ParamTx(TxHastaAgricultor, Agricultores.AGR_idagricultor, LbHastaAgricultor)
        ParamTx(TxDesdeFecha, Nothing, LbDesdeFecha, False, Cdatos.TiposCampo.Fecha)
        ParamTx(TxHastaFecha, Nothing, LbHastaFecha, False, Cdatos.TiposCampo.Fecha)

        AsociarControles(TxDesdeAgricultor, BtBuscaAg1, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNomDesdeAgricultor)
        AsociarControles(TxHastaAgricultor, BtBuscaAg2, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNomHastaAgricultor)


    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub FrmConsultaPrevisiones_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        FechasPorDefecto()

    End Sub


    Private Sub FechasPorDefecto()

        If TxDesdeFecha.Text.Trim = "" Then TxDesdeFecha.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        If TxHastaFecha.Text.Trim = "" Then TxHastaFecha.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        GridView1.Columns.Clear()


        Dim Consulta As New Cdatos.E_select
        Consulta.SelCampo(Previsiones_Lineas.PRL_id, "IdLinea")
        Consulta.SelCampo(Previsiones.PVR_idagricultor, "IdAgricultor", Previsiones_Lineas.PRL_idprevision, Previsiones.PVR_idprevision)
        Consulta.SelCampo(Agricultores.AGR_Nombre, "Agricultor", Previsiones.PVR_idagricultor, Agricultores.AGR_IdAgricultor)
        Consulta.SelCampo(Previsiones.PVR_fecha, "Fecha")
        Consulta.SelCampo(Previsiones_Lineas.PRL_idgenero, "IdGenero")
        Consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Previsiones_Lineas.PRL_idgenero, Generos.GEN_IdGenero)
        Consulta.SelCampo(Previsiones_Lineas.PRL_KILOS, "Kilos")
        If TxDesdeAgricultor.Text.Trim <> "" Then Consulta.WheCampo(Previsiones.PVR_idagricultor, ">=", TxDesdeAgricultor.Text)
        If TxHastaAgricultor.Text.Trim <> "" Then Consulta.WheCampo(Previsiones.PVR_idagricultor, "<=", TxHastaAgricultor.Text)
        If TxDesdeFecha.Text.Trim <> "" Then Consulta.WheCampo(Previsiones.PVR_fecha, ">=", TxDesdeFecha.Text)
        If TxHastaFecha.Text.Trim <> "" Then Consulta.WheCampo(Previsiones.PVR_fecha, "<=", TxHastaFecha.Text)
        

        Dim sql As String = Consulta.SQL


        If RbDetallado.Checked Then

            sql = "SELECT IdAgricultor, Agricultor, Fecha, IdGenero, Genero, SUM(Kilos) as Kilos" & vbCrLf & _
                " FROM ( " & vbCrLf & sql & vbCrLf & ") as G" & vbCrLf & _
                " GROUP BY IdAgricultor, Agricultor, Fecha, IdGenero, Genero" & vbCrLf & _
                " ORDER BY IdAgricultor, Fecha, IdGenero"
        Else
            sql = "SELECT IdAgricultor, Agricultor, IdGenero, Genero, SUM(Kilos) as Kilos" & vbCrLf & _
                " FROM ( " & vbCrLf & sql & vbCrLf & ") as G" & vbCrLf & _
                " GROUP BY IdAgricultor, Agricultor, IdGenero, Genero" & vbCrLf & _
                " ORDER BY IdAgricultor, IdGenero"

        End If


        Dim dt As DataTable = Previsiones.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt


        AjustaColumnas()


        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Kilos", "{0:n2}")



    End Sub


    Private Sub AjustaColumnas()

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDAGRICULTOR"
                    c.Caption = "CodAgr"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.MaxWidth = 50
                Case "IDGENERO"
                    c.Caption = "CodGen"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.MaxWidth = 50
                Case "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 70
                Case "FECHA"
                    c.Width = 75
            End Select
        Next

    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim agricultores As String = FiltroDesdeHasta("Agricultor", TxDesdeAgricultor.Text, TxHastaAgricultor.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDesdeFecha.Text, TxHastaFecha.Text)

        Dim RbTipoListado As RadioButton() = {RbDetallado, RbResumido}
        Dim StrTipoListado As String() = {"Detallado", "Resumido"}
        Dim tipolistado As String = FiltroRadioButton("Tipo listado", RbTipoListado, StrTipoListado)


        If agricultores <> "" Then LineasDescripcion.Add(agricultores)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If tipolistado <> "" Then LineasDescripcion.Add(tipolistado)


        MyBase.Imprimir()

    End Sub


    
End Class