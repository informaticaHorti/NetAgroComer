Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmConsumoMaterialesComparativo
    Inherits FrConsulta


    Private Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Private Envases As New E_Envases(Idusuario, cn)
    Private FamiliaEnvases As New E_FamiliaEnvases(Idusuario, cn)
    Private ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    Private ValeEnvases_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub

    
    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, FamiliaEnvases.FEV_IdFamilia, Lb1)
        ParamTx(TxDato2, FamiliaEnvases.FEV_IdFamilia, Lb2)
        ParamTx(TxDato3, ValeEnvases.VEV_Fecha, Lb3)
        ParamTx(TxDato4, ValeEnvases.VEV_Fecha, Lb4)

        AsociarControles(TxDato1, BtBusca1, FamiliaEnvases.btBusca, FamiliaEnvases, FamiliaEnvases.FEV_Nombre, Lb_1)
        AsociarControles(TxDato2, BtBusca2, FamiliaEnvases.btBusca, FamiliaEnvases, FamiliaEnvases.FEV_Nombre, Lb_2)

    End Sub


    
    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim dtC As DataTable = Centros.TablaCentros()

        CbCentros.Properties.DataSource = dtC
        CbCentros.Properties.ValueMember = "IdCentro"
        CbCentros.Properties.DisplayMember = "Nombre"


        For Each it As DevExpress.XtraEditors.Controls.CheckedListBoxItem In CbCentros.Properties.GetItems()
            If it.Value = MiMaletin.IdCentro Then
                it.CheckState = CheckState.Checked
            Else
                it.CheckState = CheckState.Unchecked
            End If
        Next




        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxDato3.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato4.Text = Today.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        Dim sqlWhere As String = ""
        If TxDato1.Text.Trim <> "" Then sqlWhere = sqlWhere & " AND ENV_IdFamiliaEnvase >= " & TxDato1.Text & vbCrLf
        If TxDato2.Text.Trim <> "" Then sqlWhere = sqlWhere & " AND ENV_IdFamiliaEnvase <= " & TxDato2.Text & vbCrLf
        If TxDato3.Text.Trim <> "" Then sqlWhere = sqlWhere & " AND VEV_Fecha >= '" & TxDato3.Text & "'" & vbCrLf
        If TxDato4.Text.Trim <> "" Then sqlWhere = sqlWhere & " AND VEV_Fecha <= '" & TxDato4.Text & "'" & vbCrLf
        sqlWhere = sqlWhere & CadenaWhereLista(ValeEnvases.VEV_Idcentro, ListadeCombo(CbCentros), " AND ")



        Dim sql As String = "SELECT IdFamiliaEnvase, FamiliaEnvase, IdEnvase, '' as NombreFamilia, Envase," & vbCrLf
        If chkDetallarMarcas.Checked Then sql = sql & " IdMarca, Marca," & vbCrLf
        sql = sql & " SUM(CantComp) as CantComp, SUM(ImpComp) as ImpComp, 0.00 as PMC," & vbCrLf
        sql = sql & " SUM(UnidsSal) as UnidsSal, SUM(ImpSal) as ImpSal, 0.00 as PMS" & vbCrLf
        sql = sql & " FROM" & vbCrLf
        sql = sql & " (" & vbCrLf
        sql = sql & " SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase, " & vbCrLf
        sql = sql & " VEL_IdEnvase as IdEnvase, ENV_Nombre as Envase, VEL_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql = sql & " VEL_Entrega as CantComp, COALESCE(VEL_Entrega,0) * COALESCE(VEL_PrecioEntrega,0) as ImpComp," & vbCrLf
        sql = sql & " 0.00 as UnidsSal, 0.00 as ImpSal" & vbCrLf
        sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN ValeEnvases ON VEV_IdVale = VEL_IdVale" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = VEL_IdEnvase" & vbCrLf
        sql = sql & " LEFT JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql = sql & " LEFT JOIN Marcas ON MAR_IdMarca = VEL_IdMarca" & vbCrLf
        sql = sql & " WHERE VEV_Operacion = 'AC'" & vbCrLf
        sql = sql & sqlWhere
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase, " & vbCrLf
        sql = sql & " VEL_IdEnvase as IdEnvase, ENV_Nombre as Envase, VEL_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql = sql & " 0.00 as CantComp, 0.00 as ImpComp, VEL_Retira as UnidsSal, " & vbCrLf
        sql = sql & " COALESCE(VEL_Retira,0) * COALESCE(VEL_PrecioCoste,0) as ImpSal" & vbCrLf
        sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN ValeEnvases ON VEV_IdVale = VEL_IdVale" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = VEL_IdEnvase" & vbCrLf
        sql = sql & " LEFT JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql = sql & " LEFT JOIN Marcas ON MAR_IdMarca = VEL_IdMarca" & vbCrLf
        sql = sql & " WHERE (VEV_Operacion = 'SM' OR VEV_Operacion = 'SC')" & vbCrLf
        sql = sql & sqlWhere
        sql = sql & " ) as G" & vbCrLf
        If chkDetallarMarcas.Checked Then
            sql = sql & " GROUP BY IdFamiliaEnvase, FamiliaEnvase, IdEnvase, Envase, IdMarca, Marca" & vbCrLf
            sql = sql & " ORDER BY IdFamiliaEnvase, Idenvase, IdMarca"
        Else
            sql = sql & " GROUP BY IdFamiliaEnvase, FamiliaEnvase, IdEnvase, Envase" & vbCrLf
            sql = sql & " ORDER BY IdFamiliaEnvase, Idenvase"
        End If



        Dim dt As DataTable = ValeEnvases_Lineas.MiConexion.ConsultaSQL(sql)

        For Each row As DataRow In dt.Rows

            Dim CantComp As Decimal = VaDec(row("CantComp"))
            Dim ImpComp As Decimal = VaDec(row("ImpComp"))
            Dim UnidsSal As Decimal = VaDec(row("UnidsSal"))
            Dim ImpSal As Decimal = VaDec(row("ImpSal"))

            Dim PMC As Decimal = 0
            Dim PMS As Decimal = 0

            If CantComp <> 0 Then PMC = ImpComp / CantComp
            If UnidsSal <> 0 Then PMS = ImpSal / UnidsSal

            row("NombreFamilia") = VaInt(row("IdFamiliaEnvase")).ToString("00") & " " & row("FamiliaEnvase").ToString
            row("PMC") = PMC
            row("PMS") = PMS

        Next


        GridView1.Columns.Clear()
        Grid.DataSource = dt


        AñadeResumenCampo("CantComp", "{0:n2}")
        AñadeResumenCampo("ImpComp", "{0:n2}")
        AñadeResumenCampo("UnidsSal", "{0:n2}")
        AñadeResumenCampo("ImpSal", "{0:n2}")


        AjustaColumnas()



    End Sub
    Private Sub AjustaColumnas()



        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDFAMILIAENVASE", "FAMILIAENVASE", "IDMARCA"
                    c.Visible = False
                Case "NOMBREFAMILIA"
                    c.Visible = False
                    c.GroupIndex = 1
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "IDENVASE"
                    c.Caption = "CodEnv"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.MinWidth = 50

                Case "CANTCOMP", "IMPCOMP", "UNIDSSAL", "IMPSAL"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 90

                Case "PMC"
                    c.Caption = "P.M.C."
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00000"
                    c.Width = 90

                Case "PMS"
                    c.Caption = "P.M.S."
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00000"
                    c.Width = 90

            End Select
        Next
    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim familias As String = FiltroDesdeHasta("Familia Envase", TxDato1.Text, TxDato2.Text)
        Dim fechas As String = FiltroDesdeHasta("Fechas", TxDato3.Text, TxDato4.Text)
        Dim centros As String = FiltroCheckedComboBox("Centro", CbCentros)

        If familias <> "" Then LineasDescripcion.Add(familias)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If centros <> "" Then LineasDescripcion.Add(centros)


        MyBase.Imprimir()

    End Sub



    Public Overrides Sub Informe()
        MyBase.Informe()

        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim lstCentros As List(Of String) = ListadeCombo(CbCentros)
                Dim listado As New Listado_ConsumoMaterialesComparativo(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, lstCentros, chkDetallarMarcas.Checked, TipoImpresion.Preliminar)
                listado.ImprimirListado()
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


    Private Sub Grid_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class