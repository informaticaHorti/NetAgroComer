Public Class FrmConsultaTrazabilidadPreca
    Inherits FrConsulta


    Dim Generos As New E_Generos(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim lotesproduccion As New E_LotesProduccion(Idusuario, cn)
    Dim lotesproduccion_lineas As New E_LotesProduccion_Lineas(Idusuario, cn)




    Dim err As New Errores


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub

    'Private Property AlbEntrada_Lineas As Object


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, lotesproduccion.LPD_Lote, Lb1, True)


    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False
        ' BConsultar.Visible = False
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


        LbCodGenero.Text = ""
        LbNombreGenero.Text = ""
        LbCodCategoria.Text = ""
        LbCategoria.Text = ""
        LbFechaLote.Text = ""

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        GridPartidas.DataSource = Nothing
        Grid.DataSource = Nothing



        If VaInt(TxDato1.Text) > 0 Then

            Dim Idlote As String = lotesproduccion.LeerLote(MiMaletin.Ejercicio.ToString, TxDato1.Text)

            If VaInt(Idlote) > 0 Then

                CargaPartidas(Idlote)
                CargaPrecalibrado(Idlote)

            End If

        End If



    End Sub


    Private Sub CargaPartidas(Idlote As String)

        Dim consulta As New Cdatos.E_select
        Dim consulta2 As New Cdatos.E_select
        Dim albentrada As New E_AlbEntrada(Idusuario, cn)
        Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Dim Lotes As New E_Lotes(Idusuario, cn)

        consulta.SelCampo(lotesproduccion_lineas.LPL_Idlinea, "idlinea")
        consulta.SelCampo(Albentrada_lineas.AEL_muestreo, "Partida", lotesproduccion_lineas.LPL_IdlineaEntrada)
        consulta.SelCampo(Lotes.LTE_Lote, "Lote", lotesproduccion_lineas.LPL_IdLotePartida)
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albentrada_lineas.AEL_idgenero)
        consulta.SelCampo(albentrada.AEN_IdAgricultor, "Codigo", Albentrada_lineas.AEL_idalbaran)
        consulta.SelCampo(Agricultores.AGR_Nombre, "Agricultor", albentrada.AEN_IdAgricultor)
        consulta.SelCampo(lotesproduccion_lineas.LPL_Kilos, "Kilos")
        consulta.WheCampo(lotesproduccion_lineas.LPL_Idlote, "=", Idlote)
        consulta.WheCampo(lotesproduccion_lineas.LPL_IdlineaEntrada, ">", "0")
        'consulta.WheCampo(Lotes_lineas.LTL_Idprogramacliente, "=", MiMaletin.idprogramacliente.ToString)
        Dim sql As String = consulta.SQL

        Dim dt1 As DataTable = Lotes.MiConexion.ConsultaSQL(sql)

        consulta2.SelCampo(lotesproduccion_lineas.LPL_IdlineaEntrada, "idpartida")
        consulta2.SelCampo(Albentrada_lineas.AEL_muestreo, "Partida", lotesproduccion_lineas.LPL_IdlineaEntrada)
        consulta2.SelCampo(Lotes.LTE_Lote, "Lote", lotesproduccion_lineas.LPL_IdLotePartida)
        consulta2.SelCampo(Generos.GEN_NombreGenero, "Genero", Lotes.LTE_Idgenero)
        consulta2.SelCampo(albentrada.AEN_IdAgricultor, "Codigo", Albentrada_lineas.AEL_idalbaran)
        consulta2.SelCampo(Agricultores.AGR_Nombre, "Agricultor", albentrada.AEN_IdAgricultor)
        consulta2.SelCampo(lotesproduccion_lineas.LPL_Kilos, "Kilos")
        consulta2.WheCampo(lotesproduccion_lineas.LPL_Idlote, "=", Idlote)
        consulta2.WheCampo(lotesproduccion_lineas.LPL_IdLotePartida, ">", "0")
        sql = consulta2.SQL
        Dim dt2 As DataTable = Lotes.MiConexion.ConsultaSQL(sql)
        dt1.Merge(dt2)

        GridPartidas.DataSource = dt1
        AjustaColumnasPartida()


    End Sub


    Private Sub CargaPrecalibrado(Idpreca As String)

        Dim palets As New E_palets(Idusuario, cn)
        Dim palets_lineas As New E_palets_lineas(Idusuario, cn)
        Dim palets_traza As New E_palets_traza(Idusuario, cn)
        Dim albsalida_palets As New E_albsalida_palets(Idusuario, cn)
        Dim albsalida As New E_AlbSalida(Idusuario, cn)
        Dim clientes As New E_Clientes(Idusuario, cn)
        Dim puntoventa As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))


        Dim Sql As String
        Dim Consulta As New Cdatos.E_select
        Consulta.SelCampo(palets_traza.PLT_bultos, "Bultos")
        Consulta.SelCampo(palets_lineas.PLL_idpalet, "idpalet", palets_traza.PLT_idlineapalet)
        Consulta.SelCampo(palets.PAL_palet, "Palet", palets_lineas.PLL_idpalet)
        Consulta.SelCampo(palets.PAL_fecha, "FechaPalet")
        Consulta.SelCampo(palets_traza.PLT_kilos, "Kilos")
        Consulta.SelCampo(albsalida_palets.ASP_IdAlbaran, "idalbaran", palets.PAL_idpalet, albsalida_palets.ASP_Idpalet)
        Consulta.SelCampo(albsalida.ASA_albaran, "Albaran", albsalida_palets.ASP_IdAlbaran)
        Consulta.SelCampo(albsalida.ASA_fechasalida, "FechaSalida")
        Consulta.SelCampo(albsalida.ASA_idcliente, "Codigo")
        Consulta.SelCampo(clientes.CLI_Nombre, "Cliente", albsalida.ASA_idcliente)
        Consulta.WheCampo(palets_traza.PLT_idprogramacliente, "=", MiMaletin.idprogramacliente.ToString)
        Consulta.WheCampo(palets_traza.PLT_idprecalibrado, "=", Idpreca)

        Sql = Consulta.SQL





        Dim dt As DataTable = lotesproduccion_lineas.MiConexion.ConsultaSQL(Sql)

        Dim dt3 As New DataTable

        dt3.Columns.Add(New DataColumn("Palet", GetType(System.Int32)))
        dt3.Columns.Add(New DataColumn("FechaPalet", GetType(System.DateTime)))
        dt3.Columns.Add(New DataColumn("Bultos", GetType(System.Int32)))
        dt3.Columns.Add(New DataColumn("Kilos", GetType(System.Int32)))
        dt3.Columns.Add(New DataColumn("Albaran", GetType(System.Int32)))
        dt3.Columns.Add(New DataColumn("FechaSalida", GetType(System.DateTime)))
        dt3.Columns.Add(New DataColumn("Codigo", GetType(System.Int32)))
        dt3.Columns.Add(New DataColumn("Cliente", GetType(System.String)))



        If Not dt Is Nothing Then
            For Each rw In dt.Rows

                Dim fila As DataRow = dt3.NewRow() ' añado las filas de la consulta por lote (usar el mismo nombre en todas las consultas)
                For c = 0 To dt.Columns.Count - 1
                    Dim ncol As String
                    ncol = dt.Columns(c).ColumnName
                    If dt3.Columns.Contains(ncol) = True Then
                        fila(ncol) = rw(ncol)
                    End If
                Next
                dt3.Rows.Add(fila)

            Next

        End If

        Dim dv As New DataView(dt3)
        dv.Sort = "FechaPalet"
        dt3 = dv.ToTable
        Grid.DataSource = dt3
        AjustaColumnasPrecalibrado()


    End Sub


    Private Sub AjustaColumnasPrecalibrado()

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "CODIGO"
                    c.MinWidth = 55
                    c.MaxWidth = 55
            End Select
        Next

        AñadeResumenCampo("Kilos", "{0:n0}")

    End Sub


    Private Sub AjustaColumnasPartida()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridPartidasView.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDLINEA", "IDPARTIDA"
                    c.Visible = False
            End Select
        Next

        GridPartidasView.OptionsView.ShowGroupPanel = False
        GridPartidasView.OptionsBehavior.Editable = False
        GridPartidasView.OptionsView.ColumnAutoWidth = True

        GridPartidasView.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridPartidasView.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "CODIGO"
                    c.MinWidth = 55
                    c.MaxWidth = 55
            End Select
        Next


        Funciones.AñadeResumenCampo(GridPartidasView, "Kilos", "{0:n0}")

    End Sub


    Private Sub TxDato1_Valida(edicion As System.Boolean) Handles TxDato1.Valida

        If edicion Then

            Dim Idlote As String = lotesproduccion.LeerLote(MiMaletin.Ejercicio.ToString, TxDato1.Text)

            If VaInt(Idlote) > 0 Then

                If lotesproduccion.LeerId(Idlote) = True Then

                    Dim IdGenero As String = lotesproduccion.LPD_Idgenero.Valor
                    LbFechaLote.Text = lotesproduccion.LPD_Fecha.Valor

                    If Generos.LeerId(IdGenero) Then
                        LbCodGenero.Text = IdGenero
                        LbNombreGenero.Text = Generos.GEN_NombreGenero.Valor
                    End If

                    Dim IdCategoria As String = lotesproduccion.LPD_IdCategoria.Valor
                    If CategoriasSalida.LeerId(IdCategoria) Then
                        LbCodCategoria.Text = IdCategoria
                        LbCategoria.Text = CategoriasSalida.CAS_CategoriaCalibre.Valor
                    End If


                    Consultar()
                    'CargaPartidas(Idlote)


                End If
            Else
                MsgBox("Lote inexistente")
            End If



        End If


    End Sub


    Public Overrides Sub Imprimir()


        LineasDescripcion.Clear()

        If TxDato1.Text.Trim <> "" Then

            LineasDescripcion.Add("Lote: " & TxDato1.Text)
            LineasDescripcion.Add("Genero: " & LbCodGenero.Text & " " & LbNombreGenero.Text)
            LineasDescripcion.Add("Fecha Lote: " & LbFechaLote.Text)

        End If


        MyBase.Imprimir()

    End Sub


End Class