
Public Class FrmConsultaEntradasEnPlazoSeguridad
    Inherits FrConsulta



    Private Agricultores As New E_Agricultores(Idusuario, cn)
    Private AlbEntrada As New E_AlbEntrada(Idusuario, cn)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub




    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDesdeAgricultor, Agricultores.AGR_idagricultor, LbDesdeAgricultor)
        ParamTx(TxHastaAgricultor, Agricultores.AGR_idagricultor, LbHastaAgricultor)
        ParamTx(TxDesdeFecha, Nothing, LbDesdeFecha, False, Cdatos.TiposCampo.Fecha, True)
        ParamTx(TxHastaFecha, Nothing, LbHastaFecha, False, Cdatos.TiposCampo.Fecha, True)
        ParamCb_Copia(CbTipoEntrada, AlbEntrada.AEN_EntradaConfeccionada, LbTipoEntrada, Combos.ComboTipoEntrada)

        AsociarControles(TxDesdeAgricultor, BtBuscaAg1, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNomDesdeAgricultor)
        AsociarControles(TxHastaAgricultor, BtBuscaAg2, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNomHastaAgricultor)


    End Sub


    Private Sub FrmConsultaPrevisiones_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False

        CbTipoEntrada.SelectedIndex = 0

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        FechasPorDefecto()

    End Sub


    Private Sub FechasPorDefecto()

        If TxDesdeFecha.Text.Trim = "" Then TxDesdeFecha.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        If TxHastaFecha.Text.Trim = "" Then TxHastaFecha.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        GridView1.Columns.Clear()


        'Dim sql As String = "SELECT AEL_Muestreo as Partida, AEN_Campa as Campa, AEN_IdCentro as CE, AEN_Albaran as Albaran, AEN_Fecha as FechaAlb, " & vbCrLf
        'sql = sql & " AEN_HoraEntrada as HoraAlb, BCU_IdBloqueo as Parte, BCU_Fecha as FechaBl, BCU_Hora as HoraBl, FIN_Nombre as Finca, AGR_Nombre as Agricultor, " & vbCrLf
        'sql = sql & " BCU_DeFecha as DesdeFecha, BCU_AFecha as HastaFecha, BCU_Motivo as Motivo" & vbCrLf
        'sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        'sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        'sql = sql & " LEFT JOIN BloqueoCultivos ON (AEL_IdCultivo = BCU_IdCultivo AND AEN_Fecha BETWEEN BCU_DeFecha AND BCU_AFecha AND AEN_HoraEntrada BETWEEN BCU_DeHora AND BCU_AHora)" & vbCrLf
        'sql = sql & " LEFT JOIN TecnicosNet.dbo.Cultivos ON BCU_IdCultivo = CUL_IdCultivo" & vbCrLf
        'sql = sql & " LEFT JOIN TecnicosNet.dbo.Fincas ON FIN_IdFinca = CUL_IdFinca" & vbCrLf
        'sql = sql & " LEFT JOIN Agricultores ON AGR_IdAgricultor = FIN_IdAgricultor" & vbCrLf
        'sql = sql & " WHERE COALESCE(BCU_IdBloqueo, 0) > 0" & vbCrLf
        'If TxDesdeAgricultor.Text.Trim <> "" Then sql = sql & " AND AEN_IdAgricultor >= " & TxDesdeAgricultor.Text & vbCrLf
        'If TxHastaAgricultor.Text.Trim <> "" Then sql = sql & " AND AEN_IdAgricultor <= " & TxHastaAgricultor.Text & vbCrLf
        'If TxDesdeFecha.Text.Trim <> "" Then sql = sql & " AND AEN_Fecha >= '" & TxDesdeFecha.Text & "'" & vbCrLf
        'If TxHastaFecha.Text.Trim <> "" Then sql = sql & " AND AEN_Fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf
        'sql = sql & " ORDER BY AEN_Fecha" & vbCrLf

        Dim TipoEntrada As String = ""
        If CbTipoEntrada.SelectedIndex >= 0 Then
            TipoEntrada = CbTipoEntrada.SelectedValue
        End If


        Dim sql As String = "SELECT AEL_Muestreo as Partida, AEN_Campa as Campa, AEN_IdCentro as CE, AEN_Albaran as Albaran, AEN_Fecha as FechaAlb, " & vbCrLf
        sql = sql & " AEN_HoraEntrada as HoraAlb, BCU_IdBloqueo as Parte, BCU_Fecha as FechaBl, BCU_Hora as HoraBl, FIN_Nombre as Finca, AGR_Nombre as Agricultor, "
        sql = sql & " BCU_DeFecha as DesdeFecha, BCU_AFecha as HastaFecha, BCU_Motivo as Motivo"
        sql = sql & " FROM AlbEntrada_Lineas"
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran"
        sql = sql & " LEFT JOIN BloqueoCultivos ON "
        sql = sql & " ("
        sql = sql & " AEL_IdCultivo = BCU_IdCultivo"
        sql = sql & " AND CONVERT(nvarchar(MAX), AEN_FECHA, 112) + AEN_HoraEntrada BETWEEN CONVERT(nvarchar(MAX), BCU_DeFecha, 112) + BCU_DeHora AND CONVERT(nvarchar(MAX), BCU_AFecha, 112) + BCU_AHora"
        sql = sql & " )"
        sql = sql & " LEFT JOIN TecnicosNet.dbo.Cultivos ON BCU_IdCultivo = CUL_IdCultivo"
        sql = sql & " LEFT JOIN TecnicosNet.dbo.Fincas ON FIN_IdFinca = CUL_IdFinca"
        sql = sql & " LEFT JOIN Agricultores ON AGR_IdAgricultor = FIN_IdAgricultor"
        sql = sql & " WHERE COALESCE(BCU_IdBloqueo, 0) > 0"
        If TxDesdeAgricultor.Text.Trim <> "" Then sql = sql & " AND AEN_IdAgricultor >= " & TxDesdeAgricultor.Text & vbCrLf
        If TxHastaAgricultor.Text.Trim <> "" Then sql = sql & " AND AEN_IdAgricultor <= " & TxHastaAgricultor.Text & vbCrLf
        If TxDesdeFecha.Text.Trim <> "" Then sql = sql & " AND AEN_Fecha >= '" & TxDesdeFecha.Text & "'" & vbCrLf
        If TxHastaFecha.Text.Trim <> "" Then sql = sql & " AND AEN_Fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf
        If TipoEntrada = "S" Then
            sql = sql & " AND AEN_EntradaConfeccionada = 'S'" & vbCrLf
        ElseIf TipoEntrada = "N" Then
            sql = sql & " AND COALESCE(AEN_EntradaConfeccionada, 'N') <> 'S'" & vbCrLf
        End If
        sql = sql & " ORDER BY AEN_Fecha"


        Dim dt As DataTable = Agricultores.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt


        AjustaColumnas()



    End Sub


    Private Sub AjustaColumnas()

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "FECHAALB", "FECHABL"
                    c.Caption = "Fecha"

                Case "HORAALB", "HORABL"
                    c.Caption = "Hora"

            End Select
        Next

    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim agricultores As String = FiltroDesdeHasta("Agricultor", TxDesdeAgricultor.Text, TxHastaAgricultor.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDesdeFecha.Text, TxHastaFecha.Text)


        If agricultores <> "" Then LineasDescripcion.Add(agricultores)
        If fechas <> "" Then LineasDescripcion.Add(fechas)

        MyBase.Imprimir()

    End Sub


End Class