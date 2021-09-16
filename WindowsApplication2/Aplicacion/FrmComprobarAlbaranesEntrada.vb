Public Class FrmComprobarAlbaranesEntrada
    Inherits FrConsulta


    Dim Albentrada As New E_AlbEntrada(Idusuario, cn)


    Private err As New Errores()



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Nothing, Lb1, True, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato2, Nothing, Lb1, True, Cdatos.TiposCampo.Fecha)
        ParamChk(chkSoloDiferencias, Nothing, "S", "N")

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

        CargaGrid()

    End Sub


    Private Sub CargaGrid()


        Dim sql As String = "SELECT IdAlbaran, Albaran, Fecha,idcentro, KgNetos, KilosCla, KgHistorico, GastosCabHist, GastosHist" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT AEN_IdAlbaran as IdAlbaran, AEN_Albaran as Albaran, AEN_Fecha AS Fecha,AEN_idcentro as idcentro, " & vbCrLf
        sql = sql & " (SELECT SUM(COALESCE(AEL_KilosNetos,0)) FROM AlbEntrada_Lineas WHERE AEL_IdAlbaran = AEN_IdAlbaran) AS KgNetos," & vbCrLf
        sql = sql & " (SELECT SUM(COALESCE(ALC_KilosNetos,0)) as KilosCla FROM AlbEntrada_LineasCla WHERE ALC_IdAlbaran = AEN_IdAlbaran) AS KilosCla," & vbCrLf
        sql = sql & " (SELECT SUM(COALESCE(AHL_Kilos,0)) FROM Albentrada_hislineas LEFT JOIN Albentrada_his on AHL_idalbhis = AEH_Id WHERE AEH_IdAlbaran = AEN_IdAlbaran) AS KgHistorico," & vbCrLf
        sql = sql & " (SELECT SUM(COALESCE(AEH_TGastosFac,0) + COALESCE(AEH_TGastosCom,0)) FROM AlbEntrada_His WHERE AEH_IdAlbaran = AEN_IdAlbaran) as GastosCabHist," & vbCrLf
        sql = sql & " (SELECT SUM(ROUND(COALESCE(AHG_importe,0),2)) FROM Albentrada_HisGastos LEFT JOIN AlbEntrada_His ON AHG_idalbhis = AEH_Id WHERE AEH_IdAlbaran = AEN_IdAlbaran) AS GastosHist" & vbCrLf
        sql = sql & " FROM AlbEntrada" & vbCrLf
        sql = sql & " WHERE AEN_FECHA >= '" & TxDato1.Text & "'" & vbCrLf
        sql = sql & " AND AEN_FECHA <= '" & TxDato2.Text & "'" & vbCrLf
        sql = sql & " GROUP BY AEN_IdAlbaran, AEN_Albaran, AEN_Fecha,AEN_idcentro" & vbCrLf
        sql = sql & " ) AS X" & vbCrLf
        If chkSoloDiferencias.Checked Then
            sql = sql & " WHERE COALESCE(KgNetos,0) <> COALESCE(KilosCla,0) OR COALESCE(KgNetos,0) <> COALESCE(KgHistorico,0) OR COALESCE(KilosCla,0) <> COALESCE(KgHistorico,0) OR (COALESCE(GastosCabHist,0) - COALESCE(GastosHist,0))>=1 or (COALESCE(GastosCabHist,0) - COALESCE(GastosHist,0))<=-1" & vbCrLf
        End If
        sql = sql & " ORDER BY ALBARAN" & vbCrLf


        Dim dt As DataTable = Albentrada.MiConexion.ConsultaSQL(sql)

        GridView1.Columns.Clear()
        Grid.DataSource = dt

        AjustaColumnas()


    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDALBARAN"
                    c.Visible = False
                Case "FECHA"
                Case "ALBARAN"
                Case Else
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
            End Select
        Next

        GridView1.BestFitColumns()
        AñadeResumenCampo("KgNetos", "{0:n0}")
        AñadeResumenCampo("KilosCla", "{0:n0}")
        AñadeResumenCampo("KgHistorico", "{0:n0}")

        AñadeResumenCampo("GastosCabHist", "{0:n2}")
        AñadeResumenCampo("GastosHist", "{0:n2}")

    End Sub


End Class

