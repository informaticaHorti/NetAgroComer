
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic

Public Class FrmChequeoSemana



    Inherits FrConsulta

    Dim Agricultor As New E_Agricultores(Idusuario, cn)
    Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Albsalida As New E_AlbSalida(Idusuario, cn)
    Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)

    Dim Dtg As New DataTable

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

        ParamTx(TxSemana, Nothing, LbSemana, True, Cdatos.TiposCampo.EnteroPositivo, 0, 2)
        ParamTx(TxFechaDesde, Albentrada.AEN_Fecha, LbDesdeFecha, True)
        ParamTx(TxFechaHasta, Albentrada.AEN_Fecha, LbHastaFecha, True)

        ParamChk(ChkSmuestreo, Nothing, "S", "N")
        ParamChk(ChkSvalor, Nothing, "S", "N")
        ParamChk(ChkSprecio, Nothing, "S", "N")
        ParamChk(ChkComision, Nothing, "S", "N")
        ParamChk(ChkFirme, Nothing, "S", "N")
        ParamChk(ChkClasif, Nothing, "S", "N")
        ParamChk(ChkSCuenta, Nothing, "S", "N")
        ParamChk(ChkFirmeSprecio, Nothing, "S", "N")

        cbCentro = ComboCentro(cbCentro, MiMaletin.IdCentro)
    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        BInforme.Visible = False
        GridView1.Appearance.HeaderPanel.BackColor = Color.Aquamarine

    End Sub

    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub

    Private Sub CargaVentas()

        Dim Consulta As New Cdatos.E_select
        Consulta.SelCampo(Albsalida_lineas.ASL_idalbaran, "idalbaran")
        Consulta.SelCampo(Albsalida.ASA_albaran, "Albaran", Albsalida_lineas.ASL_idalbaran)
        Consulta.SelCampo(Albsalida.ASA_fechasalida, "Fecha")
        Consulta.SelCampo(Albsalida.ASA_tipofc, "tipo")
        Consulta.SelCampo(Albsalida.ASA_fechavaloracion, "FechaValoracion")
        Consulta.SelCampo(Albsalida.ASA_idcliente, "Codigo")
        Consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", Albsalida.ASA_idcliente)
        Consulta.SelCampo(Albsalida_lineas.ASL_precioventa, "Precio")
        Consulta.WheCampo(Albsalida.ASA_fechasalida, ">=", TxFechaDesde.Text)
        Consulta.WheCampo(Albsalida.ASA_fechasalida, "<=", TxFechaHasta.Text)

        Dim sql As String = Consulta.SQL
        sql = sql + CadenaWhereLista(Albsalida.ASA_idcentro, ListadeCombo(cbCentro), " AND ")
        sql = sql + " order by Asa_fechasalida"
        Dim dt As DataTable = Albsalida.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                Dim tipo As String = rw("Tipo").ToString
                Dim incidencia As String = ""
                If ChkSCuenta.CheckState = CheckState.Checked And tipo = "C" Then
                    Dim Fvalora As Date = VaDate(rw("fechavaloracion"))
                    If Fvalora = VaDate("") Then
                        incidencia = "Sin cuenta de venta"
                    End If
                End If

                If ChkFirmeSprecio.CheckState = CheckState.Checked And tipo = "F" Then
                    If VaDec(rw("precio")) = 0 Then
                        incidencia = "Precio venta 0 "
                    End If
                End If

                If incidencia <> "" Then
                    GeneraIncidencia(rw("albaran").ToString, "0", rw("fecha"), rw("codigo"), rw("Cliente"), incidencia)

                End If

            Next
        End If
    End Sub


    Private Sub CargaCompras()
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Albentrada_lineas.AEL_muestreo, "Partida")
        consulta.SelCampo(Albentrada.AEN_Albaran, "Albaran", Albentrada_lineas.AEL_idalbaran)
        consulta.SelCampo(Albentrada.AEN_Fecha, "Fecha")
        consulta.SelCampo(Albentrada_lineas.AEL_fechamuestreo, "FechaMuestreo")
        consulta.SelCampo(Albentrada_lineas.AEL_FechaValoracion, "FechaValoracion")
        consulta.SelCampo(Albentrada_lineas.AEL_IdValoracion, "idvaloracion")


        Dim oImporte As New Cdatos.bdcampo("@(SELECT SUM(AlC_KilosNetos*ALC_PRECIO) FROM ALBENTRADA_LINEASCLA WHERE ALC_Idlineaentrada = AEL_IdLINEA)", Cdatos.TiposCampo.Entero, 10)
        consulta.SelCampo(oImporte, "Importe")
        ' consulta.SelCampo(Albentrada_lineas.AEL_precio, "precio")
        consulta.SelCampo(Albentrada.AEN_IdAgricultor, "Codigo")
        consulta.SelCampo(Agricultor.AGR_Nombre, "Agricultor", Albentrada.AEN_IdAgricultor)
        consulta.SelCampo(Albentrada.AEN_TipoFCS, "Tipo")
        consulta.WheCampo(Albentrada.AEN_Fecha, ">=", TxFechaDesde.Text)
        consulta.WheCampo(Albentrada.AEN_Fecha, "<=", TxFechaHasta.Text)
        consulta.WheCampo(Albentrada.AEN_EntradaConfeccionada, "<>", "S")
        Dim sql As String = consulta.SQL
        sql = sql + CadenaWhereLista(Albentrada.AEN_IdCentro, ListadeCombo(cbCentro), " AND ")

        sql = sql + " order by aen_fecha"
        Dim dt As DataTable = Albentrada.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows

                Dim ok As Boolean = False
                Dim tipo As String = rw("Tipo").ToString
                If ChkComision.CheckState = CheckState.Checked And tipo = "C" Then
                    ok = True
                End If
                If ChkFirme.CheckState = CheckState.Checked And tipo = "F" Then
                    ok = True
                End If
                If ChkClasif.CheckState = CheckState.Checked And tipo = "S" Then
                    ok = True
                End If
                If ok = True Then
                    Dim incidencia As String = ""
                    If ChkSmuestreo.CheckState = CheckState.Checked Then
                        Dim Fmuestreo As Date = VaDate(rw("fechamuestreo"))
                        If Fmuestreo = VaDate("") Then
                            incidencia = "Sin muestrear"
                        End If
                    End If


                    If ChkSvalor.CheckState = CheckState.Checked Then

                        Dim Fvalora As Date = VaDate(rw("fechavaloracion"))
                        If Fvalora = VaDate("") Then
                            incidencia = "Sin valorar"
                        End If
                    End If


                    If ChkSprecio.CheckState = CheckState.Checked Then
                        Dim Fvalora As Date = VaDate(rw("fechavaloracion"))
                        If Fvalora > VaDate("") Then
                            If VaDec(rw("importe")) = 0 Then
                                incidencia = "Precio compra 0 "

                            End If
                        End If
                    End If

                    If incidencia <> "" Then
                        GeneraIncidencia(rw("albaran").ToString, rw("partida").ToString, rw("fecha"), rw("codigo"), rw("Agricultor"), incidencia)

                    End If

                End If

            Next
        End If

    End Sub

    Private Sub GeneraIncidencia(albaran As String, Partida As String, Fecha As Date, Codigo As String, Nombre As String, incidencia As String)
        Dtg.Rows.Add(albaran, Partida, Fecha, Codigo, Nombre, incidencia)
    End Sub

    Public Overrides Sub Consultar()
        MyBase.Consultar()

        If Dtg.Rows.Count > 0 Then
            Dtg.Rows.Clear()
        End If

        If Dtg.Columns.Count = 0 Then

            Dtg.Columns.Add("Albaran", GetType(System.Int32))
            Dtg.Columns.Add("Partida", GetType(System.Int32))
            Dtg.Columns.Add("Fecha", GetType(System.DateTime))
            Dtg.Columns.Add("Codigo", GetType(System.Int32))
            Dtg.Columns.Add("Nombre", GetType(System.String))
            Dtg.Columns.Add("Incidencia", GetType(System.String))

        End If
        CargaCompras()
        CargaVentas()

        Grid.DataSource = Dtg

        AjustaColumnas()
    End Sub
    Private Sub AjustaColumnas()

        Grid.ForceInitialize()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "ALBARAN", "PARTIDA", "CODIGO"
                    c.Visible = True
                    c.Width = 100

                Case "FECHA"
                    c.Visible = True
                    c.Width = 150
 
                Case "NOMBRE", "INCIDENCIA"
                    c.Visible = True
                    c.Width = 400
                Case Else
                    c.Visible = False
            End Select
        Next

    End Sub

    Private Sub TxSemana_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxSemana.TextChanged

    End Sub

    Private Sub TxSemana_Valida(edicion As Boolean) Handles TxSemana.Valida
        Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
        If SemanasPartes.LeerSemana(MiMaletin.Ejercicio, VaInt(TxSemana.Text)) > 0 Then
            If edicion Then
                If VaDate(SemanasPartes.SEV_FechaInicialEntrada.Valor) > VaDate("") Then TxFechaDesde.Text = VaDate(SemanasPartes.SEV_FechaInicialEntrada.Valor).ToString("dd/MM/yyyy")
                If VaDate(SemanasPartes.SEV_FechaFinalEntrada.Valor) > VaDate("") Then TxFechaHasta.Text = VaDate(SemanasPartes.SEV_FechaFinalEntrada.Valor).ToString("dd/MM/yyyy")
            Else
                If TxFechaDesde.Text.Trim <> "" Then
                    If VaDate(SemanasPartes.SEV_FechaInicialEntrada.Valor) > VaDate("") Then TxFechaDesde.Text = VaDate(SemanasPartes.SEV_FechaInicialEntrada.Valor).ToString("dd/MM/yyyy")
                End If
                If TxFechaHasta.Text.Trim <> "" Then
                    If VaDate(SemanasPartes.SEV_FechaFinalEntrada.Valor) > VaDate("") Then TxFechaHasta.Text = VaDate(SemanasPartes.SEV_FechaFinalEntrada.Valor).ToString("dd/MM/yyyy")
                End If
            End If
        End If

    End Sub
End Class