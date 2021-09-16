
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls


Public Class FrmListadoDifGastos

    Inherits FrConsulta


    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim albsalida_gastos As New E_albsalida_gastos(Idusuario, cn)
    Dim GastosClientes As New E_GastosClientes(Idusuario, cn)
    Dim Gastoscomercio As New E_GastosComercio(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))


    Dim err As New Errores


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Clientes.CLI_Codigo, Lb1)
        ParamTx(TxDato2, Clientes.CLI_Codigo, Lb2)
        ParamTx(TxDato3, AlbSalida.ASA_fechasalida, Lb3)
        ParamTx(TxDato4, AlbSalida.ASA_fechasalida, Lb4)

        AsociarControles(TxDato1, BtBusca1, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb_1)
        AsociarControles(TxDato2, BtBusca2, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb_2)

        CargaComboCentros()
    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        BInforme.Visible = False

    End Sub

    Public Sub CargaComboCentros()

        Dim dt As DataTable = Centros.TablaCentros()

        CbCentros.Properties.DataSource = dt
        CbCentros.Properties.ValueMember = "IdCentro"
        CbCentros.Properties.DisplayMember = "Nombre"

        For Each it As CheckedListBoxItem In CbCentros.Properties.GetItems()
            If VaInt(it.Value) = MiMaletin.IdCentro Then
                it.CheckState = CheckState.Checked
            Else
                it.CheckState = CheckState.Unchecked
            End If
        Next

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

        CargaGrid()

    End Sub


    Private Sub CargaGrid()

        Dim sql As String = ""
        Dim Dt As New DataTable

        Dt.Columns.Add(New DataColumn("Albaran", GetType(Int32)))
        Dt.Columns.Add(New DataColumn("Fecha", GetType(Date)))
        Dt.Columns.Add(New DataColumn("Centro", GetType(String)))
        Dt.Columns.Add(New DataColumn("Idcliente", GetType(Int32)))
        Dt.Columns.Add(New DataColumn("Cliente", GetType(String)))
        Dt.Columns.Add(New DataColumn("Idgasto", GetType(Int32)))
        Dt.Columns.Add(New DataColumn("Gasto", GetType(String)))
        Dt.Columns.Add(New DataColumn("ValorGasto", GetType(Decimal)))
        Dt.Columns.Add(New DataColumn("Tipo", GetType(String)))
        Dt.Columns.Add(New DataColumn("F/C", GetType(String)))
        Dt.Columns.Add(New DataColumn("Diferencia", GetType(String)))


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbSalida.ASA_idalbaran, "idalbaran")
        consulta.SelCampo(AlbSalida.ASA_albaran, "Albaran")
        consulta.SelCampo(AlbSalida.ASA_idcliente, "idcliente")
        consulta.SelCampo(AlbSalida.ASA_fechasalida, "Fecha")
        consulta.SelCampo(AlbSalida.ASA_idcentro, "idcentro")
        consulta.SelCampo(Centros.Nombre, "Centro", AlbSalida.ASA_idcentro)
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", AlbSalida.ASA_idcliente)

        If TxDato1.Text <> "" Then
            consulta.WheCampo(AlbSalida.ASA_idcliente, ">=", TxDato1.Text)
        End If
        If TxDato2.Text <> "" Then
            consulta.WheCampo(AlbSalida.ASA_idcliente, "<=", TxDato2.Text)
        End If
        consulta.WheCampo(AlbSalida.ASA_fechasalida, ">=", TxDato3.Text)
        consulta.WheCampo(AlbSalida.ASA_fechasalida, "<=", TxDato4.Text)
        If RbSiFacturados.Checked Then
            consulta.WheCampo(AlbSalida.ASA_idfactura, ">", "0")
        ElseIf RbNoFacturados.Checked Then
            consulta.WheCampo(AlbSalida.ASA_idfactura, "=", "0")
        End If
        Dim lst As List(Of String) = ListadeCombo(cbCentros)

        sql = consulta.SQL
        sql = sql & CadenaWhereLista(AlbSalida.ASA_idcentro, lst, " AND ") & vbCrLf
        Dim dtalb As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)




        If Not dtalb Is Nothing Then
            For Each rwalb In dtalb.Rows
                Dim idcliente As String = rwalb("idcliente").ToString
                Dim idcentro As String = rwalb("idcentro").ToString
                Dim idalbaran As String = rwalb("idalbaran").ToString
                Dim Albaran As String = rwalb("albaran").ToString
                Dim Fecha As String = rwalb("Fecha").ToString
                Dim Centro As String = rwalb("Centro").ToString
                Dim Cliente As String = rwalb("Cliente").ToString

                Dim consulta1 As New Cdatos.E_select
                consulta1.SelCampo(GastosClientes.GCL_IdGasto, "idgasto")
                consulta1.SelCampo(GastosClientes.GCL_TipoAFC, "fc")
                consulta1.SelCampo(GastosClientes.GCL_ValorGasto, "valorgasto")
                consulta1.SelCampo(Gastoscomercio.GCO_Tipobkp, "kbp", GastosClientes.GCL_IdGasto)
                consulta1.SelCampo(Gastoscomercio.GCO_Nombre, "Gasto")
                consulta1.WheCampo(GastosClientes.GCL_IdCliente, "=", idcliente)
                consulta1.WheCampo(GastosClientes.GCL_TipoAFC, "<>", "A")
                sql = consulta1.SQL
                Dim DtgastoCli As DataTable = GastosClientes.MiConexion.ConsultaSQL(sql)

                For Each rwcli In DtgastoCli.Rows
                    Dim idgasto As String = rwcli("idgasto").ToString
                    Dim fc As String = rwcli("fc").ToString
                    Dim kbp As String = rwcli("kbp").ToString
                    Dim valorgasto As Decimal = VaDec(rwcli("valorgasto"))
                    Dim Gasto As String = rwcli("Gasto").ToString
                    Dim consulta2 As New Cdatos.E_select

                    consulta2.SelCampo(albsalida_gastos.ASG_tipofc, "fc")
                    consulta2.SelCampo(albsalida_gastos.ASG_tipokbp, "kbp")
                    consulta2.SelCampo(albsalida_gastos.ASG_valorgasto, "valorgasto")
                    consulta2.WheCampo(albsalida_gastos.ASG_idalbaran, "=", idalbaran)
                    consulta2.WheCampo(albsalida_gastos.ASG_idgasto, "=", idgasto)
                    sql = consulta2.SQL
                    Dim dtgastoalb As DataTable = albsalida_gastos.MiConexion.ConsultaSQL(sql)
                    Dim Terror As String = ""
                    terror = "No existe gasto"
                    If Not dtgastoalb Is Nothing Then
                        If dtgastoalb.Rows.Count > 0 Then
                            If dtgastoalb.Rows(0)("fc").ToString <> fc Then
                                Terror = "Distinto F/C"
                            ElseIf dtgastoalb.Rows(0)("kbp").ToString <> kbp Then
                                terror = "Distinto K/B/P"
                            ElseIf VaDec(dtgastoalb.Rows(0)("Valorgasto")) <> valorgasto Then
                                Terror = "Distinto ValorGasto"
                            Else
                                Terror = ""
                            End If
                        End If
                    End If
                    If Terror <> "" Then

                        Dt.Rows.Add(Albaran, Fecha, Centro, idcliente, Cliente, idgasto, Gasto, valorgasto, kbp, fc, Terror)

                    End If
                Next

            Next
        End If








        Grid.DataSource = dt
        AjustaColumnas()





    End Sub



    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                'Case "RETIRA", "ENTREGA"
                '    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                '    c.DisplayFormat.FormatString = "#,##0.00"
                '    c.Width = 75
                'Case "PRECIORETIRA", "PRECIOENTREGA"
                '    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                '    c.DisplayFormat.FormatString = "#,##0.00"
                '    c.Width = 80
            End Select
        Next


    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()


        Dim clientes As String = FiltroDesdeHasta("Cliente", TxDato1.Text, TxDato2.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato3.Text, TxDato4.Text)
        Dim centro As String = FiltroCheckedComboBox("Centro", cbCentros)

        Dim RbFacturado As RadioButton() = {RbSiFacturados, RbNoFacturados, RbTodosFacturados}
        Dim StrFacturado As String() = {"SI", "NO", "TODOS"}
        Dim Facturado As String = FiltroRadioButton("Facturados", RbFacturado, StrFacturado)

        If clientes <> "" Then LineasDescripcion.Add(clientes)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If centro <> "" Then LineasDescripcion.Add(centro)
        If Facturado <> "" Then LineasDescripcion.Add(Facturado)


        MyBase.Imprimir()

    End Sub


End Class