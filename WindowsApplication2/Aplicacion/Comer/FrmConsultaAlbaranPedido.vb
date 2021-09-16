
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls


Public Class FrmConsultaAlbaranPedido
    Inherits FrConsulta


    Dim AlbaranMaterial As New E_AlbMaterial(Idusuario, cn)
    Dim AlbaranmaterialLineas As New E_AlbMaterialLineas(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Centro As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim err As New Errores


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc


        ParamTx(TxDato5, Envases.ENV_IdEnvase, Lb5)
        ParamTx(TxDato1, Acreedores.ACR_Codigo, Lb1)
        ParamTx(TxDato2, Acreedores.ACR_Codigo, Lb2)
        ParamTx(TxDato3, AlbaranMaterial.AMA_Fecha, Lb3)
        ParamTx(TxDato4, AlbaranMaterial.AMA_Fecha, Lb4)

        AsociarControles(TxDato1, BtBusca1, Acreedores.btBusca, Acreedores, Acreedores.ACR_Nombre, Lb_1)
        AsociarControles(TxDato2, BtBusca2, Acreedores.btBusca, Acreedores, Acreedores.ACR_Nombre, Lb_2)
        AsociarControles(TxDato5, BtBusca5, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb_5)



        Dim dt As New DataTable

        dt = Centro.TablaCentros

        cbCentro.Properties.DataSource = dt
        cbCentro.Properties.ValueMember = "IdCentro"
        cbCentro.Properties.DisplayMember = "Nombre"


        For Each it As CheckedListBoxItem In cbCentro.Properties.GetItems()
            If it.Value = MiMaletin.IdCentro Then
                it.CheckState = CheckState.Checked
            Else
                it.CheckState = CheckState.Unchecked
            End If
        Next

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

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbaranmaterialLineas.AML_idlinea, "idlinea")
        consulta.SelCampo(AlbaranMaterial.AMA_Numero, "Albaran", AlbaranmaterialLineas.AML_idalb, AlbaranMaterial.AMA_Idalb)
        consulta.SelCampo(AlbaranMaterial.AMA_Fecha, "Fecha")
        consulta.SelCampo(PuntoVenta.Nombre, "PuntoVenta", AlbaranMaterial.AMA_idpuntoventa, PuntoVenta.IdPuntoVenta)
        consulta.SelCampo(AlbaranMaterial.AMA_referencia, "Referencia")
        consulta.SelCampo(Acreedores.ACR_Codigo, "Codigo")
        consulta.SelCampo(Acreedores.ACR_Nombre, "Acreedor", AlbaranMaterial.AMA_Idacreedor, Acreedores.ACR_Codigo)
        consulta.SelCampo(Envases.ENV_Nombre, "Material", AlbaranmaterialLineas.AML_idmaterial, Envases.ENV_IdEnvase)
        consulta.SelCampo(AlbaranmaterialLineas.AML_cantidad, "Cantidad")
        consulta.SelCampo(AlbaranmaterialLineas.AML_precio, "Precio")
        Dim oImporte As New Cdatos.bdcampo("@AML_Cantidad * AML_Precio", Cdatos.TiposCampo.Importe, 18, 2)
        consulta.SelCampo(oImporte, "Importe")
        consulta.SelCampo(AlbaranmaterialLineas.AML_descuento, "Dto")
        If TxDato1.Text.Trim <> "" Then consulta.WheCampo(Acreedores.ACR_Codigo, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then consulta.WheCampo(Acreedores.ACR_Codigo, "<=", TxDato2.Text)
        If TxDato3.Text.Trim <> "" Then consulta.WheCampo(AlbaranMaterial.AMA_Fecha, ">=", TxDato3.Text)
        If TxDato4.Text.Trim <> "" Then consulta.WheCampo(AlbaranMaterial.AMA_Fecha, "<=", TxDato4.Text)
        If TxDato5.Text.Trim <> "" Then consulta.WheCampo(AlbaranmaterialLineas.AML_idmaterial, "=", TxDato5.Text)

        Dim WHE As String = consulta.Whe

        If RbSiFacturados.Checked Then
            If WHE.Trim <> "" Then
                WHE = WHE & " AND COALESCE(AMA_IdFactura,0) > 0"
            Else
                WHE = " WHERE COALESCE(AMA_IdFactura,0) > 0"
            End If
        ElseIf RbNoFacturados.Checked Then
            If WHE.Trim <> "" Then
                WHE = WHE & " AND COALESCE(AMA_IdFactura,0) = 0"
            Else
                WHE = " WHERE COALESCE(AMA_IdFactura,0) = 0"
            End If
        End If



        If WHE = "" Then
            WHE = CadenaWhereLista(AlbaranMaterial.AMA_idpuntoventa, ListadeCombo(cbCentro), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(AlbaranMaterial.AMA_idpuntoventa, ListadeCombo(cbCentro), " AND ")
        End If


        Dim sql As String = consulta.Sel(_IncluirTodosLosCampos) & WHE

        sql = sql & " order by Fecha, Albaran"


        Dim dt As DataTable = AlbaranMaterial.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt


        If Not IsNothing(GridView1.Columns.ColumnByFieldName("Albaran")) Then
            GridView1.Columns.ColumnByFieldName("Albaran").GroupIndex = 1
            GridView1.ExpandAllGroups()
        End If

        AjustaColumnas()

        AñadeResumenCampo("Cantidad", "{0:n4}")
        AñadeResumenCampo("Importe", "{0:n2}")

    End Sub



    Private Sub AjustaColumnas()

        Grid.ForceInitialize()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDLINEA"
                    c.Visible = False
            End Select
        Next

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "CANTIDAD"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.0000"
                    c.Width = 100
                Case "PRECIO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.000000"
                    c.Width = 100
                Case "DTO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 50
                    c.Caption = "% Dto"
                Case "CODIGO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                Case "IMPORTE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 100
            End Select
        Next
        GridView1.BestFitColumns()
    End Sub
    Public Overrides Sub Informe()
        MyBase.Informe()
        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)
        Dim lstCentros As New List(Of Integer)
        For Each it As CheckedListBoxItem In cbCentro.Properties.GetItems()
            If it.CheckState = CheckState.Checked Then
                lstCentros.Add(VaInt(it.Value))
            End If
        Next
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim Facturados As String = ""
                If RbSiFacturados.Checked Then
                    Facturados = "S"
                ElseIf RbNoFacturados.Checked Then
                    Facturados = "N"
                End If

                Dim material As String = TxDato5.Text.Trim
                If material <> "" Then material = material & " - " & Lb_5.Text

                Dim listado As New Listado_InformeAlbaranMaterial(dt, material, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, lstCentros, Facturados, TipoImpresion.Preliminar)
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


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()


        Dim material As String = ""
        If TxDato5.Text.Trim <> "" Then material = "Material: " & VaInt(TxDato5.Text).ToString("0000") & " - " & Lb_5.Text

        Dim acreedores As String = FiltroDesdeHasta("Acreedor", TxDato1.Text, TxDato2.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato3.Text, TxDato4.Text)
        Dim centros As String = FiltroCheckedComboBox("Centro", cbCentro)

        Dim RbFacturados As RadioButton() = {RbSiFacturados, RbNoFacturados, RbTodosFacturados}
        Dim StrFacturados As String() = {"SI", "NO", "Todos"}
        Dim Facturados As String = FiltroRadioButton("Facturados", RbFacturados, StrFacturados)

        If material <> "" Then LineasDescripcion.Add(material)
        If acreedores <> "" Then LineasDescripcion.Add(acreedores)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If centros <> "" Then LineasDescripcion.Add(centros)
        If Facturados <> "" Then LineasDescripcion.Add(Facturados)


        MyBase.Imprimir()

    End Sub

End Class