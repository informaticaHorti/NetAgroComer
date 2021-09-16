
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls


Public Class FrmConsultaPedidoMaterial
    Inherits FrConsulta

    Dim PedidosMaterial As New E_PedidosMaterial(Idusuario, cn)
    Dim PedidosMaterialLineas As New E_PedidosMaterialLineas(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Centro As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))

    Dim err As New Errores


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Acreedores.ACR_Codigo, Lb1)
        ParamTx(TxDato2, Acreedores.ACR_Codigo, Lb2)
        ParamTx(TxDato3, PedidosMaterial.PMA_Fecha, Lb3)
        ParamTx(TxDato4, PedidosMaterial.PMA_Fecha, Lb4)

        AsociarControles(TxDato1, BtBusca1, Acreedores.btBusca, Acreedores, Acreedores.ACR_Nombre, Lb_1)
        AsociarControles(TxDato2, BtBusca2, Acreedores.btBusca, Acreedores, Acreedores.ACR_Nombre, Lb_2)



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
        consulta.SelCampo(PedidosMaterialLineas.PML_idlinea, "idlinea")
        consulta.SelCampo(PedidosMaterial.PMA_Numero, "Pedido", PedidosMaterialLineas.PML_idpedido, PedidosMaterial.PMA_Idpedido)
        consulta.SelCampo(PedidosMaterial.PMA_Fecha, "Fecha")
        consulta.SelCampo(Centro.Nombre, "Centro", PedidosMaterial.PMA_Idcentro, Centro.IdCentro)
        consulta.SelCampo(PedidosMaterial.PMA_referencia, "Referencia")
        consulta.SelCampo(Acreedores.ACR_Codigo, "Codigo")
        consulta.SelCampo(Acreedores.ACR_Nombre, "Acreedor", PedidosMaterial.PMA_Idacreedor, Acreedores.ACR_Codigo)
        consulta.SelCampo(Envases.ENV_Nombre, "Material", PedidosMaterialLineas.PML_idmaterial, Envases.ENV_IdEnvase)
        consulta.SelCampo(PedidosMaterialLineas.PML_cantidad, "Cantidad")
        consulta.SelCampo(PedidosMaterialLineas.PML_precio, "Precio")
        consulta.SelCampo(PedidosMaterialLineas.PML_descuento, "Dto")


        If TxDato1.Text.Trim <> "" Then consulta.WheCampo(Acreedores.ACR_Codigo, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then consulta.WheCampo(Acreedores.ACR_Codigo, "<=", TxDato2.Text)
        If TxDato3.Text.Trim <> "" Then consulta.WheCampo(PedidosMaterial.PMA_Fecha, ">=", TxDato3.Text)
        If TxDato4.Text.Trim <> "" Then consulta.WheCampo(PedidosMaterial.PMA_Fecha, "<=", TxDato4.Text)
        If RbFinalizados.Checked Then consulta.WheCampo(PedidosMaterialLineas.PML_finalizado, "=", "S")
        If RbNoFinalizados.Checked Then consulta.WheCampo(PedidosMaterialLineas.PML_finalizado, "<>", "S")


        Dim WHE As String = consulta.Whe

        If WHE = "" Then
            WHE = CadenaWhereLista(PedidosMaterial.PMA_Idcentro, ListadeCombo(cbCentro), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(PedidosMaterial.PMA_Idcentro, ListadeCombo(cbCentro), " AND ")
        End If
        

        Dim sql As String = consulta.Sel(_IncluirTodosLosCampos) & WHE & "order by Fecha, Pedido"
        


        Dim dt As DataTable = PedidosMaterial.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt


        If Not IsNothing(GridView1.Columns.ColumnByFieldName("Pedido")) Then
            GridView1.Columns.ColumnByFieldName("Pedido").GroupIndex = 1
            GridView1.ExpandAllGroups()
        End If

        AjustaColumnas()



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


            End Select
        Next
        GridView1.BestFitColumns()

    End Sub
    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        Dim Finalizado As String = ""
        If RbFinalizados.Checked = True Then
            Finalizado = "Solo finalizados"
        ElseIf RbNoFinalizados.Checked = True Then
            Finalizado = "Solo no finalizados"
        ElseIf RbTodosFinalizados.Checked = True Then
            Finalizado = "Todos"
        End If
        Dim lstCentros As New List(Of Integer)
        For Each it As CheckedListBoxItem In cbCentro.Properties.GetItems()
            lstCentros.Add(VaInt(it.Value))
        Next
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim listado As New Listado_ConsultaPedidoMaterial(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, Finalizado, lstCentros, TipoImpresion.Preliminar)
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


        Dim acreedores As String = FiltroDesdeHasta("Acreedor", TxDato1.Text, TxDato2.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato3.Text, TxDato4.Text)
        Dim centros As String = FiltroCheckedComboBox("Centro", cbCentro)

        Dim RbFinalizado As RadioButton() = {RbFinalizados, RbNoFinalizados, RbTodosFinalizados}
        Dim StrFinalizado As String() = {"SI", "NO", "Todos"}
        Dim Finalizado As String = FiltroRadioButton("Finalizados", RbFinalizado, StrFinalizado)

        If acreedores <> "" Then LineasDescripcion.Add(acreedores)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If centros <> "" Then LineasDescripcion.Add(centros)
        If Finalizado <> "" Then LineasDescripcion.Add(Finalizado)


        MyBase.Imprimir()

    End Sub

End Class