
Public Class FrmListadoVentasGastosAlbaran
    Inherits FrConsulta

    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxClienteDesde, Clientes.CLI_Codigo, LbDesdeCliente)
        ParamTx(TxClienteHasta, Clientes.CLI_Codigo, LbHastaCliente)
        ParamTx(TxFechaDesde, AlbSalida.ASA_fechasalida, LbDesdeFecha, True)
        ParamTx(TxFechaHasta, AlbSalida.ASA_fechasalida, LbHastaFecha, True)

      

        AsociarControles(TxClienteDesde, BtBuscaClienteDesde, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomClienteDesde)
        AsociarControles(TxClienteHasta, BtBuscaClienteHasta, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomClienteHasta)

    End Sub


    Private Sub FrmListadoAlbaranesSalida_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente

        CbPuntoVenta = ComboPuntoventa(CbPuntoVenta, MiMaletin.IdPuntoVenta)
        CbEmpresas = ComboEmpresas(CbEmpresas, MiMaletin.IdEmpresaCTB)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxFechaDesde.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxFechaHasta.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        ' Dim TipoBd As Cdatos.TipoBD = AlbSalida.MiConexion.TipoBD

        Dim sql As String = SQL_Grid()

        GridView1.Columns.Clear()

        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)

        Grid.DataSource = dt


        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Kilos", "{0:n2}")
        AñadeResumenCampo("ImporteVen", "{0:n2}")
        AñadeResumenCampo("ImporteEnv", "{0:n2}")
        AñadeResumenCampo("TotalVenta", "{0:n2}")
        AñadeResumenCampo("GastosFac", "{0:n2}")
        AñadeResumenCampo("VentaNeta", "{0:n2}")
        AñadeResumenCampo("GastosComer", "{0:n2}")
        AñadeResumenCampo("GastosAlm", "{0:n2}")
        AñadeResumenCampo("VentaFinal", "{0:n2}")
        AñadeResumenCampo("Margen", "{0:n2}")

        AjustaColumnas()

    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "IDCLIENTE", "IDALBARAN"
                    c.Visible = False

            End Select
        Next


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"

                Case "IMPORTEVEN", "IMPORTEENV", "TOTALVENTA", "GASTOSFAC", "VENTANETA", "GASTOSCOMER", "GASTOSALM", "VENTAFINAL", "MARGEN"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

            End Select
        Next


    End Sub


    Public Function SQL_Grid() As String

        Dim sql As String = ""
        Dim sqlWhere As String = ""


        sql = sql & " SELECT IdCliente, Cliente, IdAlbaran, Albaran, FechaSalida,FC,FechaVal, Matricula, SUM(Kilos) as Kilos, SUM(ImporteVen) as ImporteVen," & vbCrLf
        sql = sql & " SUM(ImporteEnv) as ImporteEnv," & vbCrLf
        sql = sql & " SUM(ImporteVen + ImporteEnv) as TotalVenta," & vbCrLf
        sql = sql & " SUM(GastosFra) as GastosFac, SUM(ImporteVen - GastosFra) as VentaNeta," & vbCrLf
        sql = sql & " SUM(GastosComer) as GastosComer," & vbCrLf
        sql = sql & " SUM(GastosAlm) as GastosAlm," & vbCrLf
        sql = sql & " SUM(ImporteVen - GastosFra - GastosComer - GastosAlm) as VentaFinal" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT ASA_IdCliente as IdCliente, CLI_Nombre as Cliente, ASA_IdAlbaran as IdAlbaran, ASA_Albaran as Albaran, ASA_FechaSalida as FechaSalida," & vbCrLf
        sql = sql & " ASA_TIPOFC AS FC,ASA_FECHAVALORACION AS FechaVal,ASA_MatriculaRemolque as Matricula, ASL_KilosNetos as Kilos, COALESCE(ASL_ImporteGeneroVta,0) * COALESCE(ASA_ValorCambio,1) as ImporteVen," & vbCrLf
        sql = sql & " COALESCE((SELECT SUM(COALESCE(VEL_Retira,0) * COALESCE(VEL_PrecioRetira,0)) FROM ValeEnvases_Lineas WHERE VEL_IdVale = ASA_IdValeEnvase),0) as ImporteEnv," & vbCrLf
        sql = sql & " COALESCE(ASL_GastoF,0) as GastosFra, COALESCE(ASL_GastoC,0) + COALESCE(ASL_GastoPorte,0) as GastosComer, " & vbCrLf
        sql = sql & " COALESCE(ASL_Estructura,0) + COALESCE(ASL_Manipulacion,0) + COALESCE(ASL_Materiales,0) as GastosAlm " & vbCrLf
        sql = sql & " FROM AlbSalida_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida ON ASA_IdAlbaran = ASL_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Clientes ON CLI_IdCliente = ASA_IdCliente" & vbCrLf
        sql = sql & " LEFT JOIN Facturas ON FRA_IdFactura = ASA_IdFactura" & vbCrLf
        sql = sql & " " & vbCrLf

        If TxClienteDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_IdCliente >= " & TxClienteDesde.Text)
        If TxClienteHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_IdCliente <= " & TxClienteHasta.Text)
        If TxFechaDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_FechaSalida >= '" & TxFechaDesde.Text & "'")
        If TxFechaHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "ASA_FechaSalida <= '" & TxFechaHasta.Text & "'")

        'Punto de Venta
        AñadeCondicion(sqlWhere, CadenaWhereLista(AlbSalida.ASA_idpuntoventa, ListadeCombo(CbPuntoVenta)))

        AñadeCondicion(sqlWhere, CadenaWhereLista(AlbSalida.ASA_IdEmpresa, ListadeCombo(CbEmpresas)))
        'CadenaWhereLista(AlbSalida.ASA_IdEmpresa, ListadeCombo(CbEmpresas), "AND")

        'FC
        If RbFirme.Checked Then
            AñadeCondicion(sqlWhere, "ASA_TipoFC = 'F'")
        ElseIf RbComision.Checked Then
            AñadeCondicion(sqlWhere, "ASA_TipoFC = 'C'")
        End If

        'Valorado
        If RbSiValorado.Checked Then
            AñadeCondicion(sqlWhere, "ASA_FECHAVALORACION>'01/01/1900'")
        ElseIf RbNoValorado.Checked Then
            AñadeCondicion(sqlWhere, "ASA_FECHAVALORACION<='01/01/1900'")
        End If

        'Facturado
        If RbSiFacturados.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(ASA_IdFactura,0) > 0")
        ElseIf RbNoFacturados.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(ASA_IdFactura,0) = 0")
        End If


        sql = sql & sqlWhere

        sql = sql & " ) as G" & vbCrLf
        sql = sql & " GROUP BY IdCliente, Cliente, IdAlbaran, Albaran, Fc,FechaSalida,FechaVal, Matricula" & vbCrLf
        sql = sql & " ORDER BY IdCliente, FechaSalida, IdAlbaran" & vbCrLf


        Return sql

    End Function


    Private Sub AñadeCondicion(ByRef sqlWhere As String, condicion As String)

        If condicion.Trim <> "" Then

            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE " & condicion & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND " & condicion & vbCrLf
            End If

        End If

    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()

        Dim bDatos As Boolean = True

        Dim dt As DataTable = Grid.DataSource
        If Not IsNothing(dt) Then

            If dt.Rows.Count > 0 Then

                'Tipo Venta
                Dim TipoVenta As String = ""
                Select Case True
                    Case RbFirme.Checked
                        TipoVenta = "F"
                    Case RbComision.Checked
                        TipoVenta = "C"
                    Case RbTodos.Checked
                        TipoVenta = "T"
                End Select

                'Albaran Valorado
                Dim AlbValorado As String = ""
                Select Case True
                    Case RbSiValorado.Checked
                        AlbValorado = "S"
                    Case RbNoValorado.Checked
                        AlbValorado = "N"
                    Case RbTodosValorado.Checked
                        AlbValorado = "T"
                End Select

                'Albaran Facturados
                Dim AlbFacturados As String = ""
                Select Case True
                    Case RbSiFacturados.Checked
                        AlbFacturados = "S"
                    Case RbNoFacturados.Checked
                        AlbFacturados = "N"
                    Case RbTodosFacturados.Checked
                        AlbFacturados = "T"
                End Select


                Dim PuntoVenta As String = FiltroCheckedComboBox("Punto de Venta", CbPuntoVenta)
                Dim Empresa As String = FiltroCheckedComboBox("Empresa", CbEmpresas)

                Dim Listado As New Listado_Ventas_Gastos_Albaran(dt, TxClienteDesde.Text, TxClienteHasta.Text, TxFechaDesde.Text, TxFechaHasta.Text,
                                                         PuntoVenta, AlbValorado, AlbFacturados, TipoVenta, Empresa,
                                                          TipoImpresion.Preliminar)
                Listado.ImprimirListado()

            Else
                bDatos = False
            End If
        Else
            bDatos = False
        End If


        If Not bDatos Then
            MsgBox("No hay datos que imprimir")
        End If


    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim ClientesDesde As String = ""
        Dim ClientesHasta As String = ""

        Dim empresa As String = FiltroCheckedComboBox("Empresa", CbEmpresas)
        If Len(TxClienteDesde.Text.Trim) > 0 Then ClientesDesde = TxClienteDesde.Text Else ClientesDesde = "00000"
        If Len(TxClienteHasta.Text.Trim) > 0 Then ClientesHasta = TxClienteHasta.Text Else ClientesHasta = "99999"

        Dim FiltroCliente As String = FiltroDesdeHasta("Cliente", ClientesDesde, ClientesHasta)
        Dim FiltroFecha As String = FiltroDesdeHasta("Fecha", TxFechaDesde.Text, TxFechaHasta.Text)

        Dim FiltroPuntoVenta As String = FiltroCheckedComboBox("Punto de venta", CbPuntoVenta)


        Dim strTipoEntrada As String() = {"Firme", "Comision", "TODOS"}
        Dim RbTipoEntrada As RadioButton() = {RbFirme, RbComision, RbTodos}
        Dim FiltroEntrada As String = FiltroRadioButton("Tipos de Venta", RbTipoEntrada, strTipoEntrada)

        Dim strAlbVal As String() = {"SI", "NO", "TODOS"}
        Dim rbAlbVal As RadioButton() = {RbSiValorado, RbNoValorado, RbTodosValorado}
        Dim FiltroAlbVal As String = FiltroRadioButton("Albaranes Valorados", rbAlbVal, strAlbVal)

        Dim strAlbFac As String() = {"SI", "NO", "TODOS"}
        Dim rbAlbFac As RadioButton() = {RbSiFacturados, RbNoFacturados, RbTodosFacturados}
        Dim FiltroAlbFac As String = FiltroRadioButton("Albaranes Facturados", rbAlbFac, strAlbFac)

        If Len(FiltroCliente.Trim) > 0 Then LineasDescripcion.Add(FiltroCliente)
        If Len(FiltroFecha.Trim) > 0 Then LineasDescripcion.Add(FiltroFecha)

        If Len(FiltroPuntoVenta) > 0 Then LineasDescripcion.Add(FiltroPuntoVenta)

        If Len(FiltroEntrada) > 0 Then LineasDescripcion.Add(FiltroEntrada)
        If Len(FiltroAlbVal) > 0 Then LineasDescripcion.Add(FiltroAlbVal)
        If Len(FiltroAlbFac) > 0 Then LineasDescripcion.Add(FiltroAlbFac)
        If empresa <> "" Then LineasDescripcion.Add(empresa)

        MyBase.Imprimir()

    End Sub

  
End Class