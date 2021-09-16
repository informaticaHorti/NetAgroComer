
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmListadoAlbaranesEntrada
    Inherits FrConsulta


    Private Enum TipoListado
        DetalladoConClasificacion = 1
        DetalladoSinClasificacion = 2
        Resumido = 3
        ResumidoAgricultorGenero = 4
        ResumidoGeneroYFinca = 5
        ResumidoGenero = 6
    End Enum



    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
    Dim Empresas As New E_Empresas(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))

    Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim AlbEntrada_LineasCla As New E_AlbEntrada_lineascla(Idusuario, cn)



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

        ParamTx(TxAgricultorDesde, Agricultores.AGR_idagricultor, LbDesdeAgricultor)
        ParamTx(TxAgricultorHasta, Agricultores.AGR_IdAgricultor, LbHastaAgricultor)
        ParamTx(TxFechaDesde, AlbEntrada.AEN_Fecha, LbDesdeFecha, True)
        ParamTx(TxFechaHasta, AlbEntrada.AEN_Fecha, LbHastaFecha, True)
        ParamTx(TxAlbaranDesde, AlbEntrada.AEN_Albaran, LbDesdeAlbaran)
        ParamTx(TxAlbaranHasta, AlbEntrada.AEN_Albaran, LbHastaAlbaran)
        ParamTx(TxGeneroDesde, Generos.GEN_IdGenero, LbDesdeGenero)
        ParamTx(TxGeneroHasta, Generos.GEN_IdGenero, LbHastaGenero)
        ParamTx(TxCategDesde, Categorias.CAE_Id, LbDesdeCateg)
        ParamTx(TxCategHasta, Categorias.CAE_Id, LbHastaCateg)
        ParamChk(chkDetallarAlbaranesResumidos, Nothing, "S", "N")
        ParamChk(ChkIncluirSinCategoria, Nothing, "S", "N")
        ParamChk(ChkOcultarObservaciones, Nothing, "S", "N")



        AsociarControles(TxAgricultorDesde, BtBuscaAgricultorDesde, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNomAgricultorDesde)
        AsociarControles(TxAgricultorHasta, BtBuscaAgricultorHasta, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNomAgricultorHasta)
        AsociarControles(TxAlbaranDesde, BtBuscaAlbaranDesde, AlbEntrada.btBusca, AlbEntrada)
        AsociarControles(TxAlbaranHasta, BtBuscaAlbaranHasta, AlbEntrada.btBusca, AlbEntrada)
        AsociarControles(TxGeneroDesde, BtBuscaGeneroDesde, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomGeneroDesde)
        AsociarControles(TxGeneroHasta, BtBuscaGeneroHasta, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomGeneroHasta)
        AsociarControles(TxCategDesde, BtBuscaCategDesde, Categorias.btBusca, Categorias, Categorias.CAE_CategoriaCalibre, LbNomCategDesde)
        AsociarControles(TxCategHasta, BtBuscaCategHasta, Categorias.btBusca, Categorias, Categorias.CAE_CategoriaCalibre, LbNomCategHasta)



    End Sub


    Private Sub FrmConsultaEntradas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        'BInforme.Visible = False
        'BImprimir.Visible = False


        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente



        CbCentroRecogida = ComboCentrosRecogida(CbCentroRecogida)
        CbEmpresas = ComboEmpresas(CbEmpresas, MiMaletin.IdEmpresaCTB)
        CbPventa = ComboPuntoventa(CbPventa, MiMaletin.IdPuntoVenta)

        CargaComboTipoListado()

        'CbTipoListado.SelectedIndex = 0


        CbCentroRecogida.CheckAll()
        CbEmpresas.CheckAll()


        CbTipoListado.SelectedValue = TipoListado.DetalladoSinClasificacion


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

        ChkIncluirSinCategoria.Checked = True

    End Sub


    Private Sub CargaComboTipoListado()

        Dim dt As New DataTable
        dt.Columns.Add("Id", GetType(Integer))
        dt.Columns.Add("Nombre", GetType(String))

        Dim row As DataRow = dt.NewRow()
        row("Id") = TipoListado.DetalladoConClasificacion
        row("Nombre") = "Detallado con clasificación"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Id") = TipoListado.DetalladoSinClasificacion
        row("Nombre") = "Detallado sin clasificación"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Id") = TipoListado.Resumido
        row("Nombre") = "Resumido"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Id") = TipoListado.ResumidoAgricultorGenero
        row("Nombre") = "Resumido por Agricultor y Género"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Id") = TipoListado.ResumidoGeneroYFinca
        row("Nombre") = "Resumido por Género y Finca"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Id") = TipoListado.ResumidoGenero
        row("Nombre") = "Resumido por Género"
        dt.Rows.Add(row)


        CbTipoListado.DataSource = dt
        CbTipoListado.ValueMember = "Id"
        CbTipoListado.DisplayMember = "Nombre"

    End Sub



    Private Sub Fechaspordefecto()
        TxFechaDesde.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxFechaHasta.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim IdTipoListado As Integer = VaInt(CbTipoListado.SelectedValue)
        If IdTipoListado > 0 Then


            Dim sql As String = ""

            Select Case IdTipoListado

                Case TipoListado.DetalladoConClasificacion
                    sql = SQL_Detallado()

                Case TipoListado.DetalladoSinClasificacion
                    sql = SQL_DetalladoSinClasificacion()

                Case TipoListado.Resumido
                    sql = SQL_Resumido()

                Case TipoListado.ResumidoAgricultorGenero
                    sql = SQL_ResumidoAgricultorGenero()

                Case TipoListado.ResumidoGeneroYFinca
                    sql = SQL_ResumidoGeneroYFinca()


                Case TipoListado.ResumidoGenero
                    sql = SQL_ResumidoGenero()

            End Select



            GridView1.Columns.Clear()



            Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
            Grid.DataSource = dt



            'OJO con las mayúsculas / minúsculas
            AñadeResumenCampo("Kilos", "{0:n2}")
            AñadeResumenCampo("Importe", "{0:n2}")
            AñadeResumenCampo("Bultos", "{0:n0}")
            AñadeResumenCampo("Precio", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
            AñadeResumenCampo("ImpComision", "{0:n2}")


            AjustaColumnas()


        End If


    End Sub


    Public Overrides Sub CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs)
        MyBase.CustomSummaryCalculate(sender, e)


        Try


            If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

                If e.IsGroupSummary Then

                    Dim precio As Decimal = 0

                    Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item
                    If item.FieldName.ToUpper.Trim = "PRECIO" Then

                        Dim Kilos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(0)))
                        Dim Importe As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(1)))
                        If Kilos <> 0 Then precio = Importe / Kilos

                    End If
                    e.TotalValue = precio

                End If


                If e.IsTotalSummary Then

                    Dim precio As Decimal = 0

                    Dim item As DevExpress.XtraGrid.GridColumnSummaryItem = e.Item
                    If item.FieldName.ToUpper.Trim = "PRECIO" Then

                        Dim kilos As Decimal = 0
                        Dim Importe As Decimal = 0

                        Dim colKilos As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Kilos")
                        If Not IsNothing(colKilos) Then kilos = VaDec(colKilos.SummaryItem.SummaryValue)

                        Dim colImporte As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Importe")
                        If Not IsNothing(colImporte) Then Importe = VaDec(colImporte.SummaryItem.SummaryValue)

                        If kilos <> 0 Then precio = Importe / kilos

                    End If
                    e.TotalValue = precio

                End If

            End If




        Catch ex As Exception

        End Try

    End Sub


    'Public Function SQL_DetalladoConClasificacion()


    '    Dim sql As String = ""
    '    Dim sqlWhere As String = ""


    '    sql = sql & "SELECT AEN_IdAgricultor as IdAgricultor, AGR_Nombre as Agricultor, AGR_idempresa as IdEmpresa, AEL_IdCultivo as IdCultivo," & vbCrLf
    '    sql = sql & " AHL_IdAlbaran as IdAlbaran, AEN_Fecha as Fecha," & vbCrLf
    '    sql = sql & " AEN_Campa as Campa, AEN_IdPuntoVenta as PV, AEN_Albaran as Albaran, AEN_idrecogida as IdRecogida, AEL_Muestreo as Partida, AHL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
    '    sql = sql & " ALC_IdCategoria as IdCategoria, CAE_CategoriaCalibre as Categoria, AEL_Observaciones as Observaciones," & vbCrLf
    '    sql = sql & " AHL_Bultos as Bultos, ALC_KilosNetos as Kilos, AHL_Precio as Precio, AHL_ImporteGenero as Importe" & vbCrLf
    '    sql = sql & " FROM AlbEntrada_HisLineas" & vbCrLf
    '    sql = sql & " LEFT JOIN AlbEntrada_LineasCla ON AHL_idlineaentrada = ALC_idlineaentrada" & vbCrLf
    '    sql = sql & " LEFT JOIN AlbEntrada_His ON AHL_IdAlbHis = AEH_Id" & vbCrLf
    '    sql = sql & " LEFT JOIN AlbEntrada ON AHL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
    '    sql = sql & " LEFT JOIN Agricultores ON AGR_IdAgricultor = AEN_IdAgricultor" & vbCrLf
    '    sql = sql & " LEFT JOIN Generos ON AHL_IdGenero = GEN_IdGenero" & vbCrLf
    '    sql = sql & " LEFT JOIN CategoriasEntrada ON CAE_Id = ALC_IdCategoria" & vbCrLf
    '    sql = sql & " LEFT JOIN AlbEntrada_Lineas ON AHL_IdLineaEntrada = AEL_IdLinea" & vbCrLf


    '    If TxAgricultorDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEN_IdAgricultor >= " & TxAgricultorDesde.Text)
    '    If TxAgricultorHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEN_IdAgricultor <= " & TxAgricultorHasta.Text)
    '    If TxFechaDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEN_Fecha >= '" & TxFechaDesde.Text & "'")
    '    If TxFechaHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEN_Fecha <= '" & TxFechaHasta.Text & "'")
    '    If TxAlbaranDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEN_Albaran >= " & TxAlbaranDesde.Text)
    '    If TxAlbaranHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEN_Albaran <= " & TxAlbaranHasta.Text)
    '    If TxGeneroDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AHL_IdGenero >= " & TxGeneroDesde.Text)
    '    If TxGeneroHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AHL_IdGenero <= " & TxGeneroHasta.Text)
    '    If TxCategDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AHL_IdCategoria >= " & TxCategDesde.Text)
    '    If TxCategHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AHL_IdCategoria <= " & TxCategHasta.Text)

    '    AñadeCondicion(sqlWhere, CadenaWhereLista(Agricultores.AGR_idempresa, ListadeCombo(CbEmpresas)))
    '    AñadeCondicion(sqlWhere, CadenaWhereLista(AlbEntrada.AEN_IdPuntoVenta, ListadeCombo(CbCentroRecogida)))

    '    'FCS
    '    If RbFirme.Checked Then
    '        AñadeCondicion(sqlWhere, "AEN_TipoFCS = 'F'")
    '    ElseIf RbComision.Checked Then
    '        AñadeCondicion(sqlWhere, "AEN_TipoFCS = 'C'")
    '    ElseIf RbFirmeSClasific.Checked Then
    '        AñadeCondicion(sqlWhere, "AEN_TipoFCS = 'S'")
    '    End If

    '    'Confeccionado
    '    If RbSiConfeccionado.Checked Then
    '        AñadeCondicion(sqlWhere, "AEN_EntradaConfeccionada = 'S'")
    '    ElseIf RbNoConfeccionado.Checked Then
    '        AñadeCondicion(sqlWhere, "AEN_EntradaConfeccionada <> 'S'")
    '    End If

    '    'Facturado
    '    If RbSIFacturado.Checked Then
    '        AñadeCondicion(sqlWhere, "COALESCE(AEH_IdFactura,0) > 0")
    '    ElseIf RbNOFacturado.Checked Then
    '        AñadeCondicion(sqlWhere, "COALESCE(AEH_IdFactura,0) = 0")
    '    End If

    '    'Incluir sin categoría
    '    If Not ChkIncluirSinCategoria.Checked Then
    '        AñadeCondicion(sqlWhere, "COALESCE(AHL_IdCategoria,0) > 0")
    '    End If


    '    sql = sql & sqlWhere




    '    sql = "SELECT IdAgricultor, Agricultor, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida as CR, Fecha, Partida, IdGenero, Genero, IdCategoria, Categoria, Observaciones," & vbCrLf & _
    '        " SUM(Bultos) as Bultos, SUM(Kilos) as Kilos, Precio, SUM(Importe) as Importe" & vbCrLf & _
    '        " FROM" & vbCrLf & _
    '        "(" & vbCrLf & sql & ") as G" & vbCrLf & _
    '        " GROUP BY IdAgricultor, Agricultor, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida, Fecha, Partida, IdGenero, Genero, IdCategoria, Categoria, Observaciones, Precio" & vbCrLf & _
    '        " ORDER BY IdAgricultor, Albaran, Fecha, Partida"



    '    Return sql


    'End Function

    'Public Function SQL_DetalladoVB6() As String

    '    Dim sql As String = SQL_ConsultaBase()


    '    If ChkDetallarCultivo.Checked Then

    '        sql = "SELECT IdAgricultor, Agricultor, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida as CR, Fecha, G.Partida, IdGenero, Genero, IdCategoria, G.Categoria, " & vbCrLf & _
    '       " CAST(RIGHT('00' + CAST(CampaCultivo as varchar), 2) as varchar) + CAST(RIGHT('00000' + CAST(G.IdCultivo as varchar), 5) as varchar) as Cultivo," & vbCrLf & _
    '       " CL.cdNave, I.Nombre as Nave, T.Nombre as Tecnico, G.Observaciones," & vbCrLf & _
    '       " SUM(Kilos) as Kilos, Precio, TipoPrecio as TP, SUM(Importe) as Importe, Controlado, Programa," & vbCrLf & _
    '       " SocioSN, FondoOpSN" & vbCrLf & _
    '       " FROM" & vbCrLf & _
    '       "(" & vbCrLf & sql & ") as G" & vbCrLf & _
    '       " LEFT JOIN TecnicosSQL.dbo.Cultivos_Lineas CL on (CL.IdCultivo = G.IdCultivo AND CL.CdCampa = G.Campa)" & vbCrLf & _
    '       " LEFT JOIN TecnicosSQL.dbo.invernaderos I ON (I.cdCampa = CL.cdCampa AND I.cdFinca = CL.cdFinca AND I.cdNave = CL.cdNave)" & vbCrLf & _
    '       " LEFT JOIN TecnicosSQL.dbo.datos_fincas DF ON (CL.cdCampa = DF.cdCampa AND CL.cdFinca = DF.cdFinca)" & vbCrLf & _
    '       " LEFT JOIN TecnicosSQL.dbo.tecnicos T ON (T.cdTecnico = DF.cdTecnico)" & vbCrLf & _
    '       " GROUP BY IdAgricultor, Agricultor, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida, Fecha, G.Partida, IdGenero, Genero, IdCategoria, G.Categoria, CampaCultivo, G.IdCultivo, CL.cdNave, I.Nombre, T.Nombre,  G.Observaciones, Controlado, IdPrograma, Programa, TipoPrecio, Precio, FondoOPSN, SocioSN" & vbCrLf & _
    '       " ORDER BY IdAgricultor, Albaran, Fecha, Partida"


    '    Else

    '        sql = "SELECT IdAgricultor, Agricultor, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida as CR, Fecha, Partida, IdGenero, Genero, IdCategoria, Categoria, Observaciones," & vbCrLf & _
    '        " SUM(Kilos) as Kilos, Precio, TipoPrecio as TP, SUM(Importe) as Importe, Controlado, Programa," & vbCrLf & _
    '        " SocioSN, FondoOpSN" & vbCrLf & _
    '        " FROM" & vbCrLf & _
    '        "(" & vbCrLf & sql & ") as G" & vbCrLf & _
    '        " GROUP BY IdAgricultor, Agricultor, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida, Fecha, Partida, IdGenero, Genero, IdCategoria, Categoria, Observaciones, Controlado, IdPrograma, Programa, TipoPrecio, Precio, FondoOPSN, SocioSN" & vbCrLf & _
    '        " ORDER BY IdAgricultor, Albaran, Fecha, Partida"

    '    End If


    '    Return sql

    'End Function


    'Public Function SQL_Detallado() As String

    '    Dim sql As String = SQL_ConsultaBase()


    '    If ChkDetallarCultivo.Checked Then

    '        sql = "SELECT IdAgricultor, Agricultor, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida as CR, Fecha, G.Partida, IdGenero, Genero, IdCategoria, G.Categoria, " & vbCrLf & _
    '       " G.IdCultivoxx  as Cultivo," & vbCrLf & _
    '       " CL.cul_idnave, I.nav_Nombre as Nave, T.Nombre as Tecnico, G.Observaciones," & vbCrLf & _
    '       " SUM(Kilos) as Kilos, Precio, TipoPrecio as TP, SUM(Importe) as Importe, Controlado, Programa," & vbCrLf & _
    '       " SocioSN, FondoOpSN" & vbCrLf & _
    '       " FROM" & vbCrLf & _
    '       "(" & vbCrLf & sql & ") as G" & vbCrLf & _
    '       " LEFT JOIN TecnicosNET.dbo.Cultivos CL on CL.IdCultivo = G.IdCultivo " & vbCrLf & _
    '       " LEFT JOIN TecnicosNET.dbo.naves I ON  I.nav_idNave = CL.cul_idnave" & vbCrLf & _
    '       " LEFT JOIN TecnicosNET.dbo.datos_fincas DF ON CL.cul_idFinca = DF.fin_idfinca " & vbCrLf & _
    '       " LEFT JOIN TecnicosNET.dbo.tecnicos T ON (T.tec_idtecnico = DF.fin_idTecnico)" & vbCrLf & _
    '       " GROUP BY IdAgricultor, Agricultor, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida, Fecha, G.Partida, IdGenero, Genero, IdCategoria, G.Categoria,  G.IdCultivo, CL.cdNave, I.Nombre, T.Nombre,  G.Observaciones, Controlado, IdPrograma, Programa, TipoPrecio, Precio, FondoOPSN, SocioSN" & vbCrLf & _
    '       " ORDER BY IdAgricultor, Albaran, Fecha, Partida"


    '    Else

    '        sql = "SELECT IdAgricultor, Agricultor, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida as CR, Fecha, Partida, IdGenero, Genero, IdCategoria, Categoria, Observaciones," & vbCrLf & _
    '        " SUM(Kilos) as Kilos, Precio, TipoPrecio as TP, SUM(Importe) as Importe, Controlado, Programa," & vbCrLf & _
    '        " SocioSN, FondoOpSN" & vbCrLf & _
    '        " FROM" & vbCrLf & _
    '        "(" & vbCrLf & sql & ") as G" & vbCrLf & _
    '        " GROUP BY IdAgricultor, Agricultor, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida, Fecha, Partida, IdGenero, Genero, IdCategoria, Categoria, Observaciones, Controlado, IdPrograma, Programa, TipoPrecio, Precio, FondoOPSN, SocioSN" & vbCrLf & _
    '        " ORDER BY IdAgricultor, Albaran, Fecha, Partida"

    '    End If


    '    Return sql

    'End Function



    Public Function SQL_Detallado() As String

        Dim sql As String = SQL_ConsultaBase()


        If ChkDetallarCultivo.Checked Then

            sql = "SELECT IdAgricultor, Agricultor, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida as CR, Fecha, G.Partida, IdGenero, Genero, IdCategoria, G.Categoria, " & vbCrLf & _
           " G.IdCultivo as Cultivo," & vbCrLf & _
           " CUL_IdNave as cdNave, NAV_Nombre as Nave, TEC_Nombre as Tecnico, G.Observaciones," & vbCrLf & _
           " SUM(Kilos) as Kilos, Precio, TipoPrecio as TP, SUM(Importe) as Importe, PorComision," & vbCrLf & _
           " SUM(Importe) * PorComision / 100 as ImpComision," & vbCrLf & _
           " Controlado, Programa," & vbCrLf & _
           " SocioSN, FondoOpSN" & vbCrLf & _
           " FROM" & vbCrLf & _
           "(" & vbCrLf & sql & ") as G" & vbCrLf & _
           " LEFT JOIN TecnicosNet.dbo.Cultivos on CUL_IdCultivo = G.IdCultivo" & vbCrLf & _
           " LEFT JOIN TecnicosNet.dbo.Naves on NAV_IdNave = CUL_IdNave" & vbCrLf & _
           " LEFT JOIN TecnicosNet.dbo.Tecnicos ON TEC_IdTecnico = CUL_IdTecnico" & vbCrLf & _
           " GROUP BY IdAgricultor, Agricultor, PorComision, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida, Fecha, G.Partida, IdGenero, Genero, IdCategoria, G.Categoria, G.IdCultivo, CUL_IdNave, NAV_Nombre, TEC_Nombre,  G.Observaciones, Controlado, IdPrograma, Programa, TipoPrecio, Precio, FondoOPSN, SocioSN" & vbCrLf & _
           " ORDER BY IdAgricultor, Albaran, Fecha, Partida"


        Else

            sql = "SELECT IdAgricultor, Agricultor, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida as CR, Fecha, Partida, IdGenero, Genero, IdCategoria, Categoria, Observaciones," & vbCrLf & _
            " SUM(Kilos) as Kilos, Precio, TipoPrecio as TP, SUM(Importe) as Importe, PorComision," & vbCrLf & _
            " SUM(Importe) * PorComision / 100 as ImpComision," & vbCrLf & _
            " Controlado, Programa," & vbCrLf & _
            " SocioSN, FondoOpSN" & vbCrLf & _
            " FROM" & vbCrLf & _
            "(" & vbCrLf & sql & ") as G" & vbCrLf & _
            " GROUP BY IdAgricultor, Agricultor, PorComision, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida, Fecha, Partida, IdGenero, Genero, IdCategoria, Categoria, Observaciones, Controlado, IdPrograma, Programa, TipoPrecio, Precio, FondoOPSN, SocioSN" & vbCrLf & _
            " ORDER BY IdAgricultor, Albaran, Fecha, Partida"

        End If


        Return sql

    End Function


    Public Function SQL_DetalladoSinClasificacion() As String

        Dim sql As String = SQL_ConsultaBase()


        If ChkDetallarCultivo.Checked Then

            sql = "SELECT IdAgricultor, Agricultor, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida as CR, Fecha, G.Partida, IdGenero, Genero," & vbCrLf & _
            " G.IdCultivo as Cultivo," & vbCrLf & _
            " CUL_IdNave as cdNave, NAV_Nombre as Nave, TEC_Nombre as Tecnico, G.Observaciones," & vbCrLf & _
            " Bultos, SUM(Kilos) as Kilos,CASE COALESCE(SUM(Kilos),0) WHEN 0 THEN 0 ELSE COALESCE(SUM(Importe),0) / COALESCE(SUM(Kilos),0) END as Precio, SUM(Importe) as Importe," & vbCrLf & _
            " PorComision, SUM(Importe) * PorComision / 100 as ImpComision, " & vbCrLf & _
            " Controlado, Programa, " & vbCrLf & _
            " SocioSN, FondoOpSN" & vbCrLf & _
            " FROM" & vbCrLf & _
            "(" & vbCrLf & sql & ") as G" & vbCrLf & _
            " LEFT JOIN TecnicosNet.dbo.Cultivos on CUL_IdCultivo = G.IdCultivo" & vbCrLf & _
            " LEFT JOIN TecnicosNet.dbo.Naves ON CUL_IdNave = NAV_IdNave" & vbCrLf & _
            " LEFT JOIN TecnicosNet.dbo.tecnicos ON TEC_IdTecnico = CUL_IdTecnico" & vbCrLf & _
            " GROUP BY IdAgricultor, Agricultor, PorComision, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida, Fecha, G.Partida, Bultos, IdGenero, Genero, G.IdCultivo, CUL_IdNave, NAV_Nombre, TEC_Nombre, G.Observaciones, Controlado, IdPrograma, Programa, FondoOPSN, SocioSN" & vbCrLf & _
            " ORDER BY IdAgricultor, Albaran, Fecha, G.Partida"

        Else

            sql = "SELECT IdAgricultor, Agricultor, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida as CR, Fecha, Partida, IdGenero, Genero,  Observaciones," & vbCrLf & _
            " Bultos, SUM(Kilos) as Kilos,CASE COALESCE(SUM(Kilos),0) WHEN 0 THEN 0 ELSE COALESCE(SUM(Importe),0) / COALESCE(SUM(Kilos),0) END as Precio, SUM(Importe) as Importe," & vbCrLf & _
            " PorComision, SUM(Importe) * PorComision / 100 as ImpComision, " & vbCrLf & _
            " Controlado, Programa," & vbCrLf & _
            " SocioSN, FondoOpSN" & vbCrLf & _
            " FROM" & vbCrLf & _
            "(" & vbCrLf & sql & ") as G" & vbCrLf & _
            " GROUP BY IdAgricultor, Agricultor, PorComision, IdEmpresa, IdAlbaran, Campa, PV, Albaran, IdRecogida, Fecha, Partida, Bultos, IdGenero, Genero, Observaciones, Controlado, IdPrograma, Programa, FondoOPSN, SocioSN" & vbCrLf & _
            " ORDER BY IdAgricultor, Albaran, Fecha, Partida"


        End If



        'err.Muestraerror("SQL", "SQL_DetalladoSinClasificacion", sql)

        Return sql




    End Function



    Public Function SQL_Resumido() As String

        Dim sql As String = SQL_ConsultaBase()


        sql = "SELECT IdAgricultor, Agricultor, Campa, PV, Albaran, Fecha," & vbCrLf & _
            " SUM(Kilos) as Kilos, SUM(Importe) as Importe," & vbCrLf & _
            " PorComision, SUM(Importe) * PorComision / 100 as ImpComision" & vbCrLf & _
            " FROM" & vbCrLf & _
            "(" & vbCrLf & sql & ") as G" & vbCrLf & _
            " GROUP BY IdAgricultor, Agricultor, PorComision, IdAlbaran, Campa, PV, Albaran, Fecha " & vbCrLf & _
            " ORDER BY IdAgricultor, Albaran, Fecha"


        Return sql

    End Function


    Public Function SQL_ResumidoAgricultorGenero() As String

        Dim sql As String = SQL_ConsultaBase()


        sql = "SELECT IdAgricultor, Agricultor, IdGenero, Genero, IdCategoria, Categoria," & vbCrLf & _
            " SUM(Kilos) as Kilos," & vbCrLf & _
            " CASE COALESCE(SUM(Kilos),0) WHEN 0 THEN 0 ELSE COALESCE(SUM(Importe),0) / COALESCE(SUM(Kilos),0) END as Precio," & vbCrLf & _
            " SUM(Importe) as Importe, " & vbCrLf & _
            " PorComision, SUM(Importe) * PorComision / 100 as ImpComision" & vbCrLf & _
            " FROM" & vbCrLf & _
            "(" & vbCrLf & sql & ") as G" & vbCrLf & _
            " GROUP BY IdAgricultor, Agricultor, PorComision, IdGenero, Genero, IdCategoria, Categoria" & vbCrLf & _
            " ORDER BY IdAgricultor, IdGenero, IdCategoria"


        Return sql

    End Function

    Public Function SQL_ResumidoGenero() As String

        Dim sql As String = SQL_ConsultaBase()


        sql = "SELECT IdGenero, Genero, IdCategoria, Categoria," & vbCrLf & _
            " SUM(Kilos) as Kilos," & vbCrLf & _
            " CASE COALESCE(SUM(Kilos),0) WHEN 0 THEN 0 ELSE COALESCE(SUM(Importe),0) / COALESCE(SUM(Kilos),0) END as Precio," & vbCrLf & _
            " SUM(Importe) as Importe" & vbCrLf & _
            " FROM" & vbCrLf & _
            "(" & vbCrLf & sql & ") as G" & vbCrLf & _
            " GROUP BY IdGenero, Genero, IdCategoria, Categoria" & vbCrLf & _
            " ORDER BY idgenero, IdCategoria"


        Return sql

    End Function


    Public Function SQL_ResumidoGeneroYFinca() As String

        Dim sql As String = SQL_ConsultaBase()


        sql = "SELECT IdAgricultor, Agricultor, CL.CdFinca as Finca, IdGenero, Genero, IdCategoria, Categoria," & vbCrLf & _
           " SUM(Kilos) as Kilos," & vbCrLf & _
           " CASE COALESCE(SUM(Kilos),0) WHEN 0 THEN 0 ELSE COALESCE(SUM(Importe),0) / COALESCE(SUM(Kilos),0) END as Precio," & vbCrLf & _
           " SUM(Importe) as Importe, " & vbCrLf & _
           " PorComision, SUM(Importe) * PorComision / 100 as ImpComision" & vbCrLf & _
           " FROM" & vbCrLf & _
           "(" & vbCrLf & sql & ") as G" & vbCrLf & _
           " LEFT JOIN TecnicosSQL.dbo.Cultivos_Lineas CL on (CL.IdCultivo = G.IdCultivo AND CL.CdCampa = G.Campa)" & vbCrLf & _
           " GROUP BY IdAgricultor, Agricultor, PorComision, IdGenero, Genero, IdCategoria, Categoria, CL.CdFinca" & vbCrLf & _
           " ORDER BY IdAgricultor, IdGenero, IdCategoria, CL.CdFinca"



        Return sql


    End Function




    Private Function SQL_ConsultaBase() As String

        Dim sql As String = ""
        Dim sqlWhere As String = ""


        sql = sql & "SELECT AEN_IdAgricultor as IdAgricultor, AGR_Nombre as Agricultor, AGR_idempresa as IdEmpresa,  AEL_IdCultivo as IdCultivo," & vbCrLf
        sql = sql & " AEL_IdAlbaran as IdAlbaran, AEN_Fecha as Fecha," & vbCrLf
        sql = sql & " AEN_Campa as Campa, AEN_IdPuntoVenta as PV, AEN_Albaran as Albaran, AEN_idrecogida as IdRecogida, AEL_Muestreo as Partida, AEL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN AEL_IdCategoria ELSE ALC_IdCategoria END as IdCategoria," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN CAE_AEL.CAE_categoriacalibre ELSE CAE_ALC.CAE_categoriacalibre END as Categoria," & vbCrLf
        sql = sql & " AEL_Observaciones as Observaciones, AEL_Bultos as Bultos, " & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN AEL_Precio ELSE ALC_Precio END as Precio, AEL_TipoPrecio as TipoPrecio," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN AEL_kilosnetos ELSE ALC_KilosNetos END as Kilos," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN " & vbCrLf
        sql = sql & " CASE AEL_TipoPrecio WHEN 'K' THEN AEL_Precio * AEL_KilosNetos WHEN 'B' THEN AEL_Bultos * AEL_Precio WHEN 'P' THEN AEL_piezas * AEL_Precio ELSE 0 END " & vbCrLf
        sql = sql & " ELSE " & vbCrLf
        sql = sql & " CASE AEL_TipoPrecio WHEN 'K' THEN ALC_Precio * ALC_KilosNetos WHEN 'B' THEN ALC_Bultos * ALC_Precio WHEN 'P' THEN ALC_piezas * ALC_Precio ELSE 0 END " & vbCrLf
        sql = sql & " END as Importe," & vbCrLf
        sql = sql & " TPA_PorComision as PorComision, " & vbCrLf
        sql = sql & " COALESCE(AEL_Controlado,'N') as Controlado," & vbCrLf
        sql = sql & " AEL_IdPrograma as IdPrograma, PCT_Nombre as Programa, TPA_SocioHortichuelasSN as SocioSN, TPA_FondoOperativoSN as FondoOpSN" & vbCrLf
        sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada_LineasCla ON ALC_idlineaentrada = AEL_idLinea" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Agricultores ON AGR_IdAgricultor = AEN_IdAgricultor" & vbCrLf
        sql = sql & " LEFT JOIN TipoAgricultor ON TPA_IdTipo = AGR_IdTipo" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON AEL_IdGenero = GEN_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN ProgramaCalidadTecnicos ON PCT_idprograma = AEL_IdPrograma" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasEntrada CAE_AEL ON CAE_AEL.CAE_Id = AEL_IdCategoria" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasEntrada CAE_ALC ON CAE_ALC.CAE_Id = ALC_IdCategoria" & vbCrLf



        If TxAgricultorDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEN_IdAgricultor >= " & TxAgricultorDesde.Text)
        If TxAgricultorHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEN_IdAgricultor <= " & TxAgricultorHasta.Text)
        If TxFechaDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEN_Fecha >= '" & TxFechaDesde.Text & "'")
        If TxFechaHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEN_Fecha <= '" & TxFechaHasta.Text & "'")
        If TxAlbaranDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEN_Albaran >= " & TxAlbaranDesde.Text)
        If TxAlbaranHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEN_Albaran <= " & TxAlbaranHasta.Text)
        If TxGeneroDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEL_IdGenero >= " & TxGeneroDesde.Text)
        If TxGeneroHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "AEL_IdGenero <= " & TxGeneroHasta.Text)
        If TxCategDesde.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "COALESCE(ALC_IdCategoria,0) >= " & TxCategDesde.Text)
        If TxCategHasta.Text.Trim <> "" Then AñadeCondicion(sqlWhere, "COALESCE(ALC_IdCategoria,0) <= " & TxCategHasta.Text)

        AñadeCondicion(sqlWhere, CadenaWhereLista(Agricultores.AGR_idempresa, ListadeCombo(CbEmpresas)))
        AñadeCondicion(sqlWhere, CadenaWhereLista(AlbEntrada.AEN_IdPuntoVenta, ListadeCombo(CbPventa)))

        AñadeCondicion(sqlWhere, CadenaWhereLista(Agricultores.AGR_idcrecogida, ListadeCombo(CbCentroRecogida)))

        'FCS
        If RbFirme.Checked Then
            AñadeCondicion(sqlWhere, "AEN_TipoFCS = 'F'")
        ElseIf RbComision.Checked Then
            AñadeCondicion(sqlWhere, "AEN_TipoFCS = 'C'")
        ElseIf RbFirmeSClasific.Checked Then
            AñadeCondicion(sqlWhere, "AEN_TipoFCS = 'S'")
        End If

        'Confeccionado
        If RbSiConfeccionado.Checked Then
            AñadeCondicion(sqlWhere, "AEN_EntradaConfeccionada = 'S'")
        ElseIf RbNoConfeccionado.Checked Then
            AñadeCondicion(sqlWhere, "AEN_EntradaConfeccionada <> 'S'")
        End If

        'Facturado
        'If RbSIFacturado.Checked Then
        '    AñadeCondicion(sqlWhere, "COALESCE(AEH_IdFactura,0) > 0")
        'ElseIf RbNOFacturado.Checked Then
        '    AñadeCondicion(sqlWhere, "COALESCE(AEH_IdFactura,0) = 0")
        'End If
        If RbSIFacturado.Checked Then
            AñadeCondicion(sqlWhere, "(SELECT SUM(COALESCE(AEH_IdFactura,0)+COALESCE(AEH_idfacturafirme,0)) FROM AlbEntrada_His WHERE AEH_IdAlbaran = AEL_IdAlbaran) > 0")
        ElseIf RbNOFacturado.Checked Then
            AñadeCondicion(sqlWhere, "(SELECT SUM(COALESCE(AEH_IdFactura,0)+COALESCE(AEH_idfacturafirme,0)) FROM AlbEntrada_His WHERE AEH_IdAlbaran = AEL_IdAlbaran) = 0")
        End If




        'Incluir sin categoría
        If Not ChkIncluirSinCategoria.Checked Then
            AñadeCondicion(sqlWhere, "COALESCE(ALC_IdCategoria,0) > 0")
        End If


        sql = sql & sqlWhere



        Return sql

    End Function


    Private Sub AñadeCondicion(ByRef sqlWhere As String, ByVal condicion As String)

        If condicion.Trim <> "" Then

            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE " & condicion & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND " & condicion & vbCrLf
            End If

        End If


    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDCATEGORIA", "CATEGORIA"

                    'Dim IdTipoListado As Integer = VaInt(CbTipoListado.SelectedValue)
                    'If IdTipoListado = TipoListado.DetalladoConClasificacion Then
                    '    c.Visible = True
                    'ElseIf IdTipoListado = TipoListado.DetalladoSinClasificacion Then
                    '    c.Visible = False
                    'End If
                Case "FONDOOPSN", "SOCIOSN"
                    If ChkDesgloseFondoOperativo.Checked Then
                        c.Visible = True
                    Else
                        c.Visible = False
                    End If


                Case "IDAGRICULTOR", "AGRICULTOR", "FECHA", "ALBARAN", "IDGENERO", "GENERO", "BULTOS", "KILOS", "PRECIO", "IMPORTE", "OBSERVACIONES", "PARTIDA", "CR", "IDEMPRESA", "PROGRAMA", "CONTROLADO", "TP", "CULTIVO", "NAVE", "TECNICO"
                    c.Visible = True


                Case Else
                    c.Visible = False

            End Select

        Next


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "IDAGRICULTOR"
                    c.Caption = "CodAgr"
                    c.MinWidth = 50
                    c.MaxWidth = 50
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    'c.GroupIndex = 0

                Case "ALBARAN"
                    'c.GroupIndex = 1

                Case "IDCATEGORIA"
                    c.Caption = "IdCat"
                    c.MinWidth = 45
                    c.MaxWidth = 45

                Case "IDGENERO"
                    c.Caption = "CodGen"
                    c.MinWidth = 50
                    c.MaxWidth = 50
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"

                Case "BULTOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 60

                Case "PRECIO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.000"

                Case "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 70

                Case "FECHA"
                    c.MinWidth = 80

                Case "CONTROLADO"
                    c.Caption = "Cont"
                    c.Width = 30
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                Case "TP"
                    c.MinWidth = 20
                    c.MaxWidth = 20

                Case "CULTIVO"
                    c.Width = 60
                Case "NAVE"
                    c.Width = 100
                Case "TECNICO"
                    c.Width = 100

                Case "FONDOOPSN"
                    c.Caption = "Fondo"
                    c.MinWidth = 45
                    c.MaxWidth = 45
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                Case "SOCIOSN"
                    c.Caption = "Socio"
                    c.MinWidth = 45
                    c.MaxWidth = 45
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                Case "PORCOMISION"
                    c.Caption = "% Com."
                    c.MinWidth = 50
                    c.MaxWidth = 50
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

                Case "IMPCOMISION"
                    c.Caption = "Imp.Com."
                    c.Width = 70
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

                Case "IMPORTE"
                    c.Width = 70
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"



            End Select
        Next


    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim bDatos As Boolean = True


        Dim dt As DataTable = Grid.DataSource
        If Not IsNothing(dt) Then

            If dt.Rows.Count > 0 Then

                Dim IdTipoListado As Integer = VaInt(CbTipoListado.SelectedValue)
                If IdTipoListado > 0 Then


                    Dim lstEmpresas As List(Of String) = ListadeCombo(CbEmpresas)
                    Dim lstCentros As List(Of String) = ListadeCombo(CbPventa)
                    Dim lstCentroRecogida As List(Of String) = ListadeCombo(CbCentroRecogida)

                    Dim TipoEntrada As String = ""
                    Dim TipoGenero As String = ""
                    Dim Facturados As String = ""


                    'FCS
                    If RbFirme.Checked Then
                        TipoEntrada = "Sólo Firme"
                    ElseIf RbComision.Checked Then
                        TipoEntrada = "Sólo Comisión"
                    ElseIf RbFirmeSClasific.Checked Then
                        TipoEntrada = "Sólo Firme S/Clasificación"
                    End If

                    'Confeccionado
                    If RbSiConfeccionado.Checked Then
                        TipoGenero = "Sólo Directas"
                    ElseIf RbNoConfeccionado.Checked Then
                        TipoGenero = "Sólo NO directas"
                    End If

                    'Facturado
                    If RbSIFacturado.Checked Then
                        Facturados = "Sólo facturados"
                    ElseIf RbNOFacturado.Checked Then
                        Facturados = "Sólo NO facturados"
                    End If

                    Dim tList As Integer = 0

                    Select Case IdTipoListado
                        Case TipoListado.DetalladoConClasificacion
                            tList = 0
                        Case TipoListado.DetalladoSinClasificacion
                            tList = 1
                        Case TipoListado.Resumido
                            tList = 2
                        Case TipoListado.ResumidoAgricultorGenero
                            tList = 3
                        Case TipoListado.ResumidoGeneroYFinca
                            tList = 4
                        Case TipoListado.ResumidoGenero
                            tList = 5
                    End Select

                    Dim listado As New Listado_ListadoAlbaranesEntrada(dt, TxAgricultorDesde.Text, TxAgricultorHasta.Text, TxFechaDesde.Text, _
                                                                       TxFechaHasta.Text, TxAlbaranDesde.Text, TxAlbaranHasta.Text, _
                                                                       TxGeneroDesde.Text, TxGeneroHasta.Text, TxCategDesde.Text, _
                                                                       TxCategHasta.Text, lstEmpresas, lstCentroRecogida, TipoEntrada, _
                                                                       TipoGenero, Facturados, ChkIncluirSinCategoria.Checked, _
                                                                       chkDetallarAlbaranesResumidos.Checked, tList,
                                                                       TipoImpresion.Preliminar)
                    listado.ImprimirListado()

                Else
                    MsgBox("Debe escoger un tipo de listado")
                End If

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

        Dim AgricultorDesde As String = ""
        Dim AgricultorHasta As String = ""
        If Len(TxAgricultorDesde.Text.Trim) > 0 Then AgricultorDesde = TxAgricultorDesde.Text Else AgricultorDesde = "00000"
        If Len(TxAgricultorHasta.Text.Trim) > 0 Then AgricultorHasta = TxAgricultorHasta.Text Else AgricultorHasta = "99999"

        Dim GeneroDesde As String = ""
        Dim GeneroHasta As String = ""
        If Len(TxGeneroDesde.Text.Trim) > 0 Then GeneroDesde = TxGeneroDesde.Text Else GeneroDesde = "00000"
        If Len(TxGeneroHasta.Text.Trim) > 0 Then GeneroHasta = TxGeneroHasta.Text Else GeneroHasta = "99999"

        Dim FechaDesde As String = TxFechaDesde.Text
        Dim FechaHasta As String = TxFechaHasta.Text

        Dim CategoriaDesde As String = ""
        Dim CategoriaHasta As String = ""
        If Len(TxCategDesde.Text.Trim) > 0 Then CategoriaDesde = TxCategDesde.Text Else CategoriaDesde = "000"
        If Len(TxCategHasta.Text.Trim) > 0 Then CategoriaHasta = TxCategHasta.Text Else CategoriaHasta = "999"

        Dim AlbaranDesde As String = TxAlbaranDesde.Text
        Dim AlbaranHasta As String = TxAlbaranHasta.Text

        Dim FiltroAgricultor As String = FiltroDesdeHasta("Agricultor", AgricultorDesde, AgricultorHasta)
        Dim FiltroGenero As String = FiltroDesdeHasta("Género", GeneroDesde, GeneroHasta)
        Dim FiltroFecha As String = FiltroDesdeHasta("Fecha", FechaDesde, FechaHasta)
        Dim FiltroCategoria As String = FiltroDesdeHasta("Categoría", CategoriaDesde, CategoriaHasta)
        Dim FiltroAlbaran As String = FiltroDesdeHasta("Albarán", AlbaranDesde, AlbaranHasta)

        Dim FiltroCR As String = FiltroCheckedComboBox("C.Recogida", CbCentroRecogida)
        Dim FiltroEmpresa As String = FiltroCheckedComboBox("Empresa", CbEmpresas)

        Dim RbTipoAlbaran As RadioButton() = {RbFirme, RbComision, RbFirmeSClasific, RbTodosFC}
        Dim StrTipoAlbaran As String() = {"FIRME", "COMISIÓN", "FIRME S/ CLASIF.", "TODOS"}
        Dim FiltroTipoAlbaran As String = FiltroRadioButton("Tipo Albarán", RbTipoAlbaran, StrTipoAlbaran)

        Dim RbConfeccionado As RadioButton() = {RbSiConfeccionado, RbNoConfeccionado, RbTodosConfeccionado}
        Dim StrConfeccionado As String() = {"SÍ", "NO", "TODO"}
        Dim FiltroConfeccionado As String = FiltroRadioButton("Entradas Directas", RbConfeccionado, StrConfeccionado)

        Dim RbFacturado As RadioButton() = {RbSIFacturado, RbNOFacturado, RbNOFacturado}
        Dim StrFacturado As String() = {"SÍ", "NO", "TODOS"}
        Dim FiltroFacturado As String = FiltroRadioButton("Facturado", RbFacturado, StrFacturado)

        Dim DetallarCultivo As String = FiltroCheckBox("Detallar cultivo", ChkDetallarCultivo, "SI", "NO")



        If Len(FiltroAgricultor.Trim) > 0 Then LineasDescripcion.Add(FiltroAgricultor)
        If Len(FiltroGenero.Trim) > 0 Then LineasDescripcion.Add(FiltroGenero)
        If Len(FiltroFecha.Trim) > 0 Then LineasDescripcion.Add(FiltroFecha)
        If Len(FiltroCategoria.Trim) > 0 Then LineasDescripcion.Add(FiltroCategoria)
        If Len(FiltroAlbaran.Trim) > 0 Then LineasDescripcion.Add(FiltroAlbaran)
        If Len(FiltroCR.Trim) > 0 Then LineasDescripcion.Add(FiltroCR)
        If Len(FiltroEmpresa.Trim) > 0 Then LineasDescripcion.Add(FiltroEmpresa)
        If Len(FiltroTipoAlbaran.Trim) > 0 Then LineasDescripcion.Add(FiltroTipoAlbaran)
        If Len(FiltroConfeccionado.Trim) > 0 Then LineasDescripcion.Add(FiltroConfeccionado)
        If Len(FiltroFacturado.Trim) > 0 Then LineasDescripcion.Add(FiltroFacturado)
        If DetallarCultivo <> "" Then LineasDescripcion.Add(DetallarCultivo)

        MyBase.Imprimir()

    End Sub


    
End Class