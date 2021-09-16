
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls


Public Class FrmConsultaTarifasPrecios
    Inherits FrConsulta

    Dim TarifasMaterial As New E_TarifasMaterial(Idusuario, cn)
    Dim TarifasMaterialLineas As New E_TarifasMaterialLineas(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Material As New E_Envases(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim SubFamiliaEnvases As New E_SubFamiliaEnvases(Idusuario, cn)
    Dim FamiliaEnvases As New E_FamiliaEnvases(Idusuario, cn)


    
    Dim err As New Errores


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Acreedores.ACR_Codigo, Lb1)
        ParamTx(TxDato2, Acreedores.ACR_Codigo, Lb2)
        ParamTx(TxDMaterial, Nothing, LbDeMaterial, False, Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxAMaterial, Nothing, LbAMaterial, False, Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxDato3, Nothing, Lb3, True, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato4, Nothing, Lb4, True, Cdatos.TiposCampo.Fecha)


        AsociarControles(TxDato1, BtBusca1, Acreedores.btBusca, Acreedores, Acreedores.ACR_Nombre, Lb_1)
        AsociarControles(TxDato2, BtBusca2, Acreedores.btBusca, Acreedores, Acreedores.ACR_Nombre, Lb_2)
        AsociarControles(TxDMaterial, BtBuscaDMaterial, Material.btBusca, Material, Material.ENV_Nombre, LbNombreDMaterial)
        AsociarControles(TxAMaterial, BtBuscaAMaterial, Material.btBusca, Material, Material.ENV_Nombre, LbNombreAMaterial)
        BInforme.Visible = False

        CbFamilias = ComboFamiliasEnvases(CbFamilias)
        CbFamilias.CheckAll()

    End Sub




    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)



    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxDato3.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato4.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim sql As String = ""


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(TarifasMaterial.TMA_idacreedor, "IdAcreedor")
        CONSULTA.SelCampo(Acreedores.ACR_Nombre, "Acreedor", TarifasMaterial.TMA_idacreedor)
        CONSULTA.SelCampo(TarifasMaterial.TMA_fechatarifa, "Fecha")
        CONSULTA.SelCampo(TarifasMaterialLineas.TML_idmaterial, "IdMaterial", TarifasMaterial.TMA_idacreedor, TarifasMaterialLineas.TML_idacreedor)
        CONSULTA.SelCampo(Material.ENV_Nombre, "Material", TarifasMaterialLineas.TML_idmaterial)
        CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", TarifasMaterialLineas.TML_idmarca)
        CONSULTA.SelCampo(SubFamiliaEnvases.SFE_Nombre, "SubFamilia", Material.ENV_idsubfamilia)
        CONSULTA.SelCampo(FamiliaEnvases.FEV_Nombre, "Familia", Material.ENV_IdfamiliaEnvase)
        CONSULTA.SelCampo(TarifasMaterialLineas.TML_precio, "Precio")
        CONSULTA.SelCampo(TarifasMaterialLineas.TML_descuento, "Dto")
        CONSULTA.SelCampo(TarifasMaterialLineas.TML_referencia, "Referencia")

        If TxDato1.Text.Trim <> "" Then CONSULTA.WheCampo(TarifasMaterial.TMA_idacreedor, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then CONSULTA.WheCampo(TarifasMaterial.TMA_idacreedor, "<=", TxDato2.Text)

        If TxDato1.Text.Trim <> "" Then CONSULTA.WheCampo(TarifasMaterialLineas.TML_idmaterial, ">=", TxDMaterial.Text)
        If TxDato2.Text.Trim <> "" Then CONSULTA.WheCampo(TarifasMaterialLineas.TML_idmaterial, "<=", TxAMaterial.Text)

        If TxDato3.Text.Trim <> "" Then CONSULTA.WheCampo(TarifasMaterial.TMA_fechatarifa, ">=", TxDato3.Text)
        If TxDato4.Text.Trim <> "" Then CONSULTA.WheCampo(TarifasMaterial.TMA_fechatarifa, "<=", TxDato4.Text)

        sql = CONSULTA.SQL
        sql = sql + CadenaWhereLista(Material.ENV_IdfamiliaEnvase, ListadeCombo(CbFamilias), " AND ")

        sql = sql + " ORDER BY TMA_fechatarifa"

        Dim dt As DataTable = TarifasMaterial.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt


        AjustaColumnas()

    End Sub


    Private Sub AjustaColumnas()

        Grid.ForceInitialize()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "IDACREEDOR", "IDMATERIAL"

                    c.MaxWidth = 50


                Case "PRECIO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.0000"
                    c.Width = 100
                Case "DTO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 50
                    c.Caption = "% Dto"
               


            End Select
        Next
        GridView1.BestFitColumns()

    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        Dim Informe As String = ""
        If RbPorAcreedor.Checked = True Then
            Informe = "A"
        ElseIf RbPorMaterial.Checked = True Then
            Informe = "M"
        End If

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                ' Dim listado As New Listado_ConsultaTarifasMaterial(dt, TxDato1.Text, TxDato2.Text, TxDMaterial.Text, TxAMaterial.Text, TxDato3.Text, TxDato4.Text, Informe, TipoImpresion.Preliminar)
                ' listado.ImprimirListado()
            Else
                bDatos = False
            End If
        Else
            bDatos = False
        End If


        If Not bDatos Then
            MessageBox.Show("No hay datos que imprimir")
        End If

    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()


        Dim acreedores As String = FiltroDesdeHasta("Acreedor", TxDato1.Text, TxDato2.Text)
        Dim Material As String = FiltroDesdeHasta("Material", TxDMaterial.Text, TxAMaterial.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato3.Text, TxDato4.Text)

        
        If acreedores <> "" Then LineasDescripcion.Add(acreedores)
        If Material <> "" Then LineasDescripcion.Add(Material)
        If fechas <> "" Then LineasDescripcion.Add(fechas)


        MyBase.Imprimir()

    End Sub

End Class