Imports DevExpress.XtraEditors.Controls

Public Class FrmMaterialesEnPalets
    Inherits FrConsulta


    Dim Palets As New E_palets(Idusuario, cn)


    
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Nothing, Lb1, True, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato2, Nothing, Lb1, True, Cdatos.TiposCampo.Fecha)


    End Sub



    Private Sub FrmInventarioMaterialesPorFecha_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim fuente_nueva As New Font(fuente.FontFamily, fuente.Size + 1, FontStyle.Bold)
        GridView1.Appearance.GroupRow.Font = fuente_nueva
        GridView1.OptionsView.ShowGroupPanel = False

        BInforme.Visible = False

        cbAlmacenes = ComboAlmacenEnvases(cbAlmacenes, MiMaletin.IdPuntoVenta)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxDato1.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato2.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub


    Private Sub CargaGrid()


        Dim lstAlmacenes As List(Of String) = ListadeCombo(cbAlmacenes)

       
        Dim sql As String = "SELECT PAL_Palet as Palet, PAL_Fecha as Fecha, 'P' as Tipo, PAL_IdTipoPalet as IdTipoConfeccion, CPL_IdMaterial as IdMaterial, ENV_Nombre as Material," & vbCrLf
        sql = sql & " 0 as IdMarca, '' as Marca, CPL_Cantidad as Cantidad" & vbCrLf
        sql = sql & " FROM Palets" & vbCrLf
        sql = sql & " LEFT JOIN ConfecPalet ON CPA_idconfec = PAL_idtipopalet " & vbCrLf
        sql = sql & " LEFT JOIN ConfecPaletLineas ON CPL_IdConfec = CPA_IdConfec" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = CPL_IdMaterial" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida_Palets ON ASP_IdPalet = PAL_IdPalet" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida ON ASA_IdAlbaran = ASP_IdAlbaran" & vbCrLf
        sql = sql & " WHERE PAL_Fecha >= '" & TxDato1.Text & "' AND PAL_Fecha <= '" & TxDato2.Text & "'"
        If RbEnExistencias.Checked Then sql = sql & " AND (COALESCE(ASP_IdAlbaran, 0) = 0 OR ASA_FechaSalida > '" & TxDato2.Text & "')" & vbCrLf
        sql = sql & " AND PAL_envasepropio='S' " & vbCrLf
        sql = sql & CadenaWhereLista(Palets.PAL_idpvsituacion, lstAlmacenes, "AND") & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT PAL_Palet as Palet, PAL_Fecha as Fecha, 'E' as Tipo, PAL_IdTipoPalet as IdTipoConfeccion, CEL_IdMaterial as IdMaterial, ENV_Nombre as Material," & vbCrLf
        sql = sql & " CASE ENV_Tipo WHEN 'E' THEN PLL_IdMarca WHEN 'Q' THEN PLL_IdMarcaEti WHEN 'M' THEN PLL_IdMarcaMat ELSE '' END as IdMarca," & vbCrLf
        sql = sql & " CASE ENV_Tipo WHEN 'E' THEN MarcasEnv.MAR_Nombre WHEN 'Q' THEN MarcasEti.MAR_Nombre WHEN 'M' THEN MarcasMat.MAR_Nombre ELSE '' END as Marca, " & vbCrLf
        sql = sql & " (CEL_Cantidad * PLL_Bultos) as Cantidad" & vbCrLf
        sql = sql & " FROM Palets_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN Palets ON PAL_IdPalet = PLL_IdPalet" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida_Palets ON ASP_IdPalet = PAL_IdPalet" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida ON ASA_IdAlbaran = ASP_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN ConfecEnvase ON CEV_IdConfec = PLL_idtipoconfeccion " & vbCrLf
        sql = sql & " LEFT JOIN ConfecEnvaseLineas ON CEL_IdConfec = CEV_IdConfec" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = CEL_IdMaterial" & vbCrLf
        sql = sql & " LEFT JOIN Marcas MarcasEnv ON MarcasEnv.MAR_IdMarca = PLL_IdMarca " & vbCrLf
        sql = sql & " LEFT JOIN Marcas MarcasEti ON MarcasEti.MAR_IdMarca = PLL_idmarcaeti " & vbCrLf
        sql = sql & " LEFT JOIN Marcas MarcasMat ON MarcasMat.MAR_idmarca = PLL_idmarcamat " & vbCrLf
        sql = sql & " WHERE PAL_Fecha >= '" & TxDato1.Text & "' AND PAL_Fecha <= '" & TxDato2.Text & "'"
        If RbEnExistencias.Checked Then sql = sql & " AND (COALESCE(ASP_IdAlbaran, 0) = 0 OR ASA_FechaSalida > '" & TxDato2.Text & "')" & vbCrLf
        sql = sql & " AND PAL_envasepropio='S' " & vbCrLf
        sql = sql & CadenaWhereLista(Palets.PAL_idpvsituacion, lstAlmacenes, "AND") & vbCrLf
        sql = sql & " ORDER BY Palet, Tipo DESC, IdTipoConfeccion, IdMarca" & vbCrLf

        Dim dt As DataTable = Palets.MiConexion.ConsultaSQL(sql)


        GridView1.Columns.Clear()
        Grid.DataSource = dt

        AjustaColumnas()


    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "TIPO"
                    'c.Visible = False
            End Select
        Next


        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "PALET"
                    c.Width = 80

                Case "FECHA"
                    c.MinWidth = 75
                    c.MaxWidth = 75

                Case "TIPO"
                    c.MinWidth = 50
                    c.MaxWidth = 50

                Case "IDTIPOCONFECCION"
                    c.Caption = "CodConf"
                    c.MinWidth = 70
                    c.MaxWidth = 70

                Case "IDMATERIAL"
                    c.MinWidth = 70
                    c.MaxWidth = 70

                Case "IDMARCA"
                    c.MinWidth = 60
                    c.MaxWidth = 60

                Case "CANTIDAD"
                    c.Width = 85
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

            End Select
        Next


        AñadeResumenCampo("Cantidad", "{0:n2}")
      

    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        LineasDescripcion.Add("Desde fecha : " & TxDato1.Text & "  Hasta fecha : " & TxDato2.Text)
        Dim almacenes As String = FiltroCheckedComboBox("Almacen", cbAlmacenes)
        If almacenes <> "" Then LineasDescripcion.Add(almacenes)

        Dim RbExistencias As RadioButton() = {RbEnExistencias, RbTodos}
        Dim StrExistencias As String() = {"SÍ", "TODOS"}
        Dim FiltroExistencias As String = FiltroRadioButton("En existencias", RbExistencias, StrExistencias)

        MyBase.Imprimir()

    End Sub


   
End Class

