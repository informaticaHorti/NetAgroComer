
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic

Public Class FrmRecomGastos



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

        ParamTx(TxFechaDesde, Albentrada.AEN_Fecha, LbDesdeFecha, True)
        ParamTx(TxFechaHasta, Albentrada.AEN_Fecha, LbHastaFecha, True)


        TxFechaDesde.TxDatoInicioSemana = TxFechaDesde
        TxFechaHasta.TxDatoFinalSemana = TxFechaHasta


        ParamChk(ChkAlbSalida, Nothing, "S", "N")
        ParamChk(ChkExiPal, Nothing, "S", "N")


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


    Private Function ConsultaAlbaranes() As DataTable

        Dim consulta As New Cdatos.E_select
        Dim dt As New DataTable
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim Albsalida As New E_AlbSalida(Idusuario, cn)
        Dim Albsalinea_lineas As New E_AlbSalida_lineas(Idusuario, cn)

        consulta.SelCampo(Albsalida_lineas.ASL_idlinea, "idlinea")
        Dim Tipo As New Cdatos.bdcampo("@'ALB'", Cdatos.TiposCampo.Cadena, 3)
        consulta.SelCampo(Tipo, "Tipo")
        consulta.SelCampo(Albsalida_lineas.ASL_idgenero, "idgenero")
        consulta.SelCampo(Albsalida.ASA_albaran, "Numero", Albsalida_lineas.ASL_idalbaran)
        consulta.SelCampo(Albsalida.ASA_fechasalida, "Fecha")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albsalida_lineas.ASL_idgenero)
        consulta.SelCampo(Albsalida_lineas.ASL_kilosnetos, "Kilos")
        consulta.SelCampo(Albsalida_lineas.ASL_idalbaran, "idalbaran")
        consulta.WheCampo(Albsalida.ASA_fechasalida, ">=", TxFechaDesde.Text)
        consulta.WheCampo(Albsalida.ASA_fechasalida, "<=", TxFechaHasta.Text)

        Dim sql As String = consulta.SQL
        sql = sql + " order by ASA_fechasalida  "
        dt = Albsalida.MiConexion.ConsultaSQL(sql)



        Return dt


    End Function


    Private Function ConsultaPalets() As DataTable

        Dim consulta As New Cdatos.E_select
        Dim dt As New DataTable
        Dim Palets As New E_palets(Idusuario, cn)
        Dim Palets_lineas As New E_palets_lineas(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim AlbsalidaPalets As New E_albsalida_palets(Idusuario, cn)


        consulta.SelCampo(Palets_lineas.PLL_idlinea, "idlinea")
        Dim Tipo As New Cdatos.bdcampo("@'PAL'", Cdatos.TiposCampo.Cadena, 3)
        consulta.SelCampo(Tipo, "Tipo")
        consulta.SelCampo(Palets_lineas.PLL_idgenero, "idgenero")
        consulta.SelCampo(Palets.PAL_palet, "Numero", Palets_lineas.PLL_idpalet)
        consulta.SelCampo(Palets.PAL_fecha, "Fecha")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Palets_lineas.PLL_idgenero)
        consulta.SelCampo(Palets_lineas.PLL_kilosnetos, "Kilos")
        consulta.SelCampo(AlbsalidaPalets.ASP_IdAlbaran, "Idalbaran", Palets.PAL_idpalet, AlbsalidaPalets.ASP_Idpalet)
        consulta.WheCampo(Palets.PAL_fecha, ">=", TxFechaDesde.Text)
        consulta.WheCampo(Palets.PAL_fecha, "<=", TxFechaHasta.Text)

        Dim sql As String = consulta.SQL
        sql = sql + " order by pal_fecha"
        dt = Palets.MiConexion.ConsultaSQL(sql)

        Dim dv2 As New DataView(dt)
        dv2.RowFilter = "idalbaran IS NULL"
        dt = dv2.ToTable



        Return dt

    End Function


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        Dim Dt1 As New DataTable
        If ChkExiPal.Checked = True Then
            Dt1 = ConsultaPalets()
        End If

        Dim dt2 As New DataTable
        If ChkAlbSalida.Checked = True Then
            dt2 = ConsultaAlbaranes()
        End If

        Dt2.Merge(Dt1)


        Grid.DataSource = Dt2
        AjustaColumnas()

        Button1.Visible = True

    End Sub


    Private Sub AjustaColumnas()

        Grid.ForceInitialize()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "GENERO"
                    c.Visible = True
                    c.Width = 300

                Case "FECHA", "TIPO", "NUMERO"
                    c.Visible = True
                    c.Width = 100

                Case "KILOS"
                    c.Visible = True
                    c.Width = 100
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,###"

                Case "SERIE"
                    c.Width = 50

                Case Else
                    c.Visible = False
            End Select
        Next

        AñadeResumenCampo("Kilos", "{0:n0}")
    End Sub


    Private Sub Salidas()

        Dim Albsalida As New E_AlbSalida(Idusuario, cn)

        Dim consulta As New Cdatos.E_select


        consulta.SelCampo(Albsalida.ASA_idalbaran, "idalbaran")
        consulta.WheCampo(Albsalida.ASA_fechasalida, ">=", TxFechaDesde.Text)
        consulta.WheCampo(Albsalida.ASA_fechasalida, "<=", TxFechaHasta.Text)
        Dim sql As String = consulta.SQL
        Dim dt As DataTable = Albsalida.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            Barra.Value = 0
            Barra.Maximum = dt.Rows.Count

            For Each rw In dt.Rows
                If Barra.Value < Barra.Maximum Then
                    Barra.Value = Barra.Value + 1
                End If
                Dim idalbaran As Integer = VaInt(rw("idalbaran"))

                AGRO_ActualizaGastosOrigenAlbaran(idalbaran.ToString, False, 0)

            Next
        End If

    End Sub



    Private Sub PaletsExistencias()

        Dim Palets_lineas As New E_palets_lineas(Idusuario, cn)
        Dim Palets As New E_palets(Idusuario, cn)
        Dim Albsalida_palets As New E_albsalida_palets(Idusuario, cn)
        Dim Albsalida As New E_AlbSalida(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Palets_lineas.PLL_idlinea, "idlineapalet")
        consulta.SelCampo(Palets.PAL_idpalet, "idpalet", Palets_lineas.PLL_idpalet)
        consulta.SelCampo(Albsalida_palets.ASP_IdAlbaran, "idalbaran", Palets.PAL_idpalet, Albsalida_palets.ASP_Idpalet)

        consulta.WheCampo(Palets.PAL_fecha, ">=", TxFechaDesde.Text)
        consulta.WheCampo(Palets.PAL_fecha, "<=", TxFechaHasta.Text)

        Dim sql As String = consulta.SQL
        Dim dt As DataTable = Palets.MiConexion.ConsultaSQL(sql)
        Dim dv2 As New DataView(dt)
        dv2.RowFilter = "idalbaran IS NULL"
        dt = dv2.ToTable

        If Not dt Is Nothing Then
            Barra.Value = 0
            Barra.Maximum = dt.Rows.Count
            For Each rw In dt.Rows

                If Barra.Value < Barra.Maximum Then
                    Barra.Value = Barra.Value + 1
                End If

                Dim idlineapalet As Integer = VaInt(rw("idlineapalet"))
                AGRO_GastosLineaPalet(idlineapalet, 0, 0, 0, True, 0)

            Next
        End If





    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If MsgBox("Desea recomponer los gastos", vbYesNo) = vbYes Then
            If ChkAlbSalida.CheckState = CheckState.Checked Then
                Salidas()
            End If
            If ChkExiPal.CheckState = CheckState.Checked Then
                PaletsExistencias()
            End If
            MsgBox("Proceso terminado")
            Button1.Visible = False
        End If
    End Sub
End Class