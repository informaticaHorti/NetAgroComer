
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic

Public Class FrmListadoConsumoMateriales
    Inherits FrConsulta


    Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    Dim ValeEnvases_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
    Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, CnCtb)


    Dim err As New Errores

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ParametrosFrm()
    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Nothing, Lb1, True, Cdatos.TiposCampo.Fecha, , 8)
        ParamTx(TxDato2, Nothing, Lb2, True, Cdatos.TiposCampo.Fecha, , 8)

    End Sub


    Private Sub FrmListadoConsumoMateriales_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.HeaderPanel.BackColor = Color.Aquamarine


        Dim sql As String = "Select idcentro,nombre from centros order by idcentro"
        Dim dt As DataTable = Centros.MiConexion.ConsultaSQL(sql)

        CbCentros.DataSource = dt
        CbCentros.DisplayMember = "Nombre"
        CbCentros.ValueMember = "idcentro"

        CbCentros.SelectedValue = MiMaletin.IdCentro


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

        Dim IdCentro As Integer = MiMaletin.IdCentro
        If VaInt(CbCentros.SelectedValue) <> 0 Then IdCentro = VaInt(CbCentros.SelectedValue)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(ValeEnvases.VEV_Idvale, "IdVale")
        consulta.SelCampo(ValeEnvases.VEV_Numero, "NumVale")
        consulta.SelCampo(AlmacenEnvases.AEV_Nombre, "Almacen", ValeEnvases.VEV_IdAlmacen, AlmacenEnvases.AEV_Idalmacen)
        consulta.SelCampo(ValeEnvases.VEV_Fecha, "Fecha")
        consulta.SelCampo(ValeEnvases.VEV_Referencia, "Ref")
        consulta.SelCampo(ValeEnvases_Lineas.VEL_idenvase, "IdEnvase", ValeEnvases.VEV_Idvale, ValeEnvases_Lineas.VEL_idvale)
        consulta.SelCampo(Envases.ENV_Nombre, "Envase", ValeEnvases_Lineas.VEL_idenvase, Envases.ENV_IdEnvase)
        consulta.SelCampo(Marcas.MAR_Nombre, "Marca", ValeEnvases_Lineas.VEL_idmarca, Marcas.MAR_Idmarca)
        consulta.SelCampo(ValeEnvases_Lineas.VEL_retira, "Unidades")
        consulta.SelCampo(ValeEnvases_Lineas.VEL_precioretira, "Precio")
        Dim strImporte As New Cdatos.bdcampo("@(VEL_Retira * VEL_PrecioRetira)", Cdatos.TiposCampo.Importe, 18, 2)
        consulta.SelCampo(strImporte, "Importe")
        consulta.WheCampo(ValeEnvases.VEV_Operacion, "=", "CN")
        'consulta.WheCampo(ValeEnvases.VEV_Idcentro, "=", MiMaletin.IdCentro.ToString)
        consulta.WheCampo(ValeEnvases.VEV_Idcentro, "=", IdCentro)
        If TxDato1.Text <> "" Then consulta.WheCampo(ValeEnvases.VEV_Fecha, ">=", TxDato1.Text)
        If TxDato2.Text <> "" Then consulta.WheCampo(ValeEnvases.VEV_Fecha, "<=", TxDato2.Text)

        Dim sql As String = consulta.SQL & vbCrLf
        sql = sql & " ORDER BY VEV_Fecha, VEV_Numero, VEL_IdEnvase" & vbCrLf


        Dim dt As DataTable = ValeEnvases.MiConexion.ConsultaSQL(sql)


        Dim colAlb As New DataColumn("Vale", GetType(String))
        dt.Columns.Add(colAlb)

        For Each row As DataRow In dt.Rows

            Dim NumVale As String = (row("NumVale").ToString & "").Trim
            Dim Almacen As String = (row("Almacen").ToString & "").Trim
            Dim Fecha As String = ""
            If VaDate(row("Fecha")) <> VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
            Dim Referencia As String = (row("Ref").ToString & "").Trim

            row("Vale") = VaInt(NumVale).ToString("000000") & " Fecha: " & Fecha & " Almacen: " & Almacen & " Ref: " & Referencia

        Next


        Grid.DataSource = dt
        AjustaColumnas()

    End Sub


    Private Sub AjustaColumnas()



        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "NUMVALE", "FECHA", "REF", "ALMACEN", "IDVALE"
                    c.Visible = False
                Case "IMPORTE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
            End Select
        Next

        With GridView1.Columns
            If Not IsNothing(.ColumnByFieldName("Vale")) Then
                .ColumnByFieldName("Vale").GroupIndex = 1
            End If
        End With
        GridView1.ExpandAllGroups()


        GridView1.BestFitColumns()


    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim Centro As String = CbCentros.Text & ""
                ImprimirListadoConsumoMateriales(dt, TxDato1.Text, TxDato2.Text, Centro)

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


        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato1.Text, TxDato2.Text)
        Dim centro As String = FiltroCombo("Centro", CbCentros)

        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If centro <> "" Then LineasDescripcion.Add(centro)


        MyBase.Imprimir()

    End Sub

End Class