Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmEnvioFianzasEnvases
    Inherits FrConsulta


    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Envase As New E_Envases(Idusuario, cn)

    Dim err As New Errores

    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDesdeProveedor, Acreedores.ACR_Codigo, LbDesdeProveedor)
        ParamTx(TxDesdeFecha, ValeEnvases.VEV_Fecha, LbDesdeFecha, True)
        ParamTx(TxHastaFecha, ValeEnvases.VEV_Fecha, LbHastaFecha, True)

        ParamTx(TxDEnvase, Envase.ENV_IdEnvase, LbDEnvase)
        ParamTx(TxAEnvase, Envase.ENV_IdEnvase, LbAEnvase)

        ParamTx(TxIdCliente, Clientes.CLI_Codigo, LbCliente, False)

        'AsignarCalendarioSemanalTxDato(TxDesdeFecha, TxHastaFecha)

        AsociarControles(TxDesdeProveedor, BtBuscaDesdeProveedor, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomDesdeProveedor)
        BtBuscaDesdeProveedor.CL_Filtro = "TIPO='MA'"


        AsociarControles(TxDEnvase, BtBuscaDEnvase, Envase.btBusca, Envase, Envase.ENV_Nombre, LbNomDEnvase)
        AsociarControles(TxAEnvase, BtBuscaAEnvase, Envase.btBusca, Envase, Envase.ENV_Nombre, LbNomAEnvase)

        AsociarControles(TxIdCliente, BtBuscaCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNombreCliente)

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxDesdeFecha.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxHastaFecha.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        If VaDate(TxDesdeFecha.Text) = VaDate("") Or VaDate(TxHastaFecha.Text) = VaDate("") Then
            MsgBox("Debe introducir fechas válidas")
            Exit Sub
        End If


        Dim sql As String = "SELECT VEV_Fecha as Fecha, VEV_Concepto as Concepto, ASA_Albaran as Albaran, ASA_Referencia as Referencia,ASA_IdCliente as IdCliente, CLI_Nombre as Cliente," & vbCrLf
        sql = sql & " VEL_IdEnvase as IdEnvase, ENV_Nombre as Envase, ENV_CodigoFianza as CodFianza, VEL_Entrega as Entrega, VEL_Retira as Retira," & vbCrLf
        sql = sql & " CLD_Domicilio as DomicilioDescarga," & vbCrLf
        sql = sql & " DFZ_CodigoFianza as CodFianzaDom, " & vbCrLf
        sql = sql & " ACR_CodigoFianza as CodFianzaAcr " & vbCrLf
        sql = sql & " FROM AlbSalida" & vbCrLf
        sql = sql & " LEFT JOIN ValeEnvases_Lineas ON ASA_IdValeEnvase = VEL_IdVale" & vbCrLf
        sql = sql & " LEFT JOIN ValeEnvases ON VEV_IdVale = VEL_IdVale" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = VEL_IdEnvase" & vbCrLf
        sql = sql & " LEFT JOIN Clientes ON ASA_IdCliente = CLI_IdCliente" & vbCrLf
        sql = sql & " LEFT JOIN Acreedores ON ENV_IdAcreedorFianza = ACR_Codigo" & vbCrLf
        sql = sql & " LEFT JOIN ClientesDescargas ON CLD_Id = ASA_iddomicilio" & vbCrLf
        sql = sql & " LEFT JOIN DomiciliosFianzas ON (DFZ_IdDomicilio = ASA_iddomicilio AND DFZ_IdEnvase = VEL_IdEnvase)" & vbCrLf
        sql = sql & " WHERE VEV_Fecha >= '" & TxDesdeFecha.Text & "'" & vbCrLf
        sql = sql & " AND VEV_Fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf

        If TxDesdeProveedor.Text.Trim <> "" Then sql = sql & " AND ENV_IdAcreedorFianza = " & TxDesdeProveedor.Text & vbCrLf

        If TxDEnvase.Text.Trim <> "" Then sql = sql & " AND VEL_IdEnvase >= " & TxDEnvase.Text & vbCrLf
        If TxAEnvase.Text.Trim <> "" Then sql = sql & " AND VEL_IdEnvase <= " & TxAEnvase.Text & vbCrLf


        If VaInt(TxIdCliente.Text) > 0 Then
            sql = sql & " AND ASA_IdCliente = " & TxIdCliente.Text & vbCrLf
        End If
        sql = sql + " order by vev_fecha "


        GridView1.Columns.Clear()
        Dim DtFinal As New DataTable
        If RbChep.Checked = True Then

            DtFinal.Columns.Add(New DataColumn("Ubicacion", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("Contrapartida", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("Tipo_de_Transferencia", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("Fecha_de_Entrega", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("Ref", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("Otra_referencia", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("Equipo", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("Cantidad", GetType(Int32)))
        ElseIf RbIfco.Checked = True Then
            DtFinal.Columns.Add(New DataColumn("Direccion", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("FechaRegistro", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("FechaEntrega", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("Albaran", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("Pool", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("Material", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("Cantidad", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("Ifco-NR", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("Mi_Ifco-NR", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("Observaciones", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("NumeroPedido", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("Contenido", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("Matricula", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("Origen", GetType(String)))
            DtFinal.Columns.Add(New DataColumn("ObservacionesEntrega", GetType(String)))

        End If


        Dim dt As DataTable = ValeEnvases.MiConexion.ConsultaSQL(sql)

        For Each rw In dt.Rows
            If VaInt(rw("Retira")) > 0 Then
                If RbChep.Checked = True Then
                    Dim RowF As DataRow = DtFinal.NewRow
                    RowF("Ubicacion") = rw("CodFianzaAcr").ToString
                    RowF("Contrapartida") = rw("CodfianzaDom").ToString
                    RowF("Tipo_de_transferencia") = "SALIDA"
                    RowF("Fecha_de_Entrega") = Format(rw("Fecha"), "yyyyMMdd")
                    RowF("Ref") = rw("Albaran").ToString
                    RowF("Otra_Referencia") = rw("Referencia").ToString
                    RowF("Equipo") = rw("CodFianza").ToString
                    RowF("Cantidad") = VaInt(rw("retira"))
                    DtFinal.Rows.Add(RowF)
                ElseIf RbIfco.Checked = True Then
                    Dim RowF As DataRow = DtFinal.NewRow
                    RowF("Direccion") = "S"
                    RowF("FechaRegistro") = Format(rw("Fecha"), "dd.MM.yyyy")
                    RowF("FechaEntrega") = Format(rw("Fecha"), "dd.MM.yyyy")
                    RowF("Albaran") = rw("Albaran").ToString
                    RowF("Material") = rw("CodFianza").ToString
                    RowF("Cantidad") = VaInt(rw("retira"))
                    RowF("Ifco-NR") = rw("CodFianzaDom").ToString
                    RowF("Mi_Ifco-NR") = rw("CodFianzaAcr").ToString
                    DtFinal.Rows.Add(RowF)




                End If
            End If
        Next

        Grid.DataSource = DtFinal
        AjustaColumnas()


    End Sub


    Private Sub AjustaColumnas()


        GridView1.BestFitColumns()

        'For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
        '    Select Case c.FieldName.ToUpper.Trim

        '    End Select
        'Next
    End Sub



    Public Overrides Sub Imprimir()


        LineasDescripcion.Clear()

        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDesdeFecha.Text, TxHastaFecha.Text)


        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If LbNomDesdeProveedor.Text <> "" Then LineasDescripcion.Add("Acreedor Fianza" & LbNomDesdeProveedor.Text)
        If TxIdCliente.Text <> "" Then LineasDescripcion.Add("Cliente: " & LbNombreCliente.Text)


        MyBase.Imprimir()

    End Sub




   
End Class