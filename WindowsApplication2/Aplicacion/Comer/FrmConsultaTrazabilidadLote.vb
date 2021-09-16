Public Class FrmConsultaTrazabilidadLote

    Inherits FrConsulta


    Dim Lotes As New E_Lotes(Idusuario, cn)
    Dim Lotes_lineas As New E_Lotes_lineas(Idusuario, cn)
    Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
    Dim LotesProduccion_lineas As New E_LotesProduccion_Lineas(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)


  
    Dim err As New Errores

    Private Class stClaves_palets


        Public Palet As Integer
        Public Preca As Integer
        Public Producto As String
        Public Categoria As String
        Public Fecha As String
        Public albaran As Integer
        Public fechasalida As String
        Public codigo As Integer
        Public cliente As String


        Public Sub New(palet As String, Preca As Integer, Producto As String, Fecha As String, albaran As Integer, fechasalida As String, codigo As Integer, cliente As String, Categoria As String)
            Me.Producto = Producto
            Me.Palet = palet
            Me.Preca = Preca
            Me.Fecha = FnLeft(Fecha, 10)
            Me.albaran = albaran
            Me.fechasalida = FnLeft(fechasalida, 10)
            Me.codigo = codigo
            Me.cliente = cliente
            Me.Categoria = Categoria
        End Sub

    End Class

    Private Class stDatos_palets

        Public Cantidad As Decimal = 0
        Public Kilos As Decimal = 0

        Public Sub New(Cantidad As Decimal, Kilos As Decimal)
            Me.Cantidad = Cantidad
            Me.Kilos = Kilos
        End Sub

    End Class

    Dim Acum_Palet As New Acumulador



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub

    Private Property AlbEntrada_Lineas As Object


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Lotes.LTE_Lote, Lb1, True)


    End Sub


    Private Sub CargaPartidas(Idlote As String)

        Dim consulta As New Cdatos.E_select
        Dim albentrada As New E_AlbEntrada(Idusuario, cn)
        Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim Agricultores As New E_Agricultores(Idusuario, cn)

        consulta.SelCampo(Lotes_lineas.LTL_Idlineaentrada, "idlinea")
        consulta.SelCampo(Albentrada_lineas.AEL_muestreo, "Partida", Lotes_lineas.LTL_Idlineaentrada)
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albentrada_lineas.AEL_idgenero)
        consulta.SelCampo(albentrada.AEN_IdAgricultor, "Codigo", Albentrada_lineas.AEL_idalbaran)
        consulta.SelCampo(Agricultores.AGR_Nombre, "Agricultor", albentrada.AEN_IdAgricultor)
        consulta.SelCampo(Lotes_lineas.LTL_Kilos, "Kilos")
        consulta.WheCampo(Lotes_lineas.LTL_Idlote, "=", Idlote)
        'consulta.WheCampo(Lotes_lineas.LTL_Idprogramacliente, "=", MiMaletin.idprogramacliente.ToString)
        Dim sql As String = consulta.SQL

        Dim dt As DataTable = Lotes.MiConexion.ConsultaSQL(sql)
        GridPartidas.DataSource = dt
        AjustaColumnasPartida()


    End Sub

    Private Sub CargaPreca(Idlote As String)

        Dim consulta As New Cdatos.E_select

        consulta.SelCampo(LotesProduccion_lineas.LPL_Idlote, "idpreca")
        consulta.SelCampo(LotesProduccion.LPD_Lote, "Preca", LotesProduccion_lineas.LPL_Idlote)
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", LotesProduccion.LPD_Idgenero)
        consulta.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", LotesProduccion.LPD_IdCategoria)
        consulta.SelCampo(LotesProduccion_lineas.LPL_Kilos, "Kilos")
        consulta.WheCampo(LotesProduccion_lineas.LPL_IdLotePartida, "=", Idlote)
        'consulta.WheCampo(Lotes_lineas.LTL_Idprogramacliente, "=", MiMaletin.idprogramacliente.ToString)
        Dim sql As String = consulta.SQL

        Dim dt As DataTable = Lotes.MiConexion.ConsultaSQL(sql)
        Gridpreca.DataSource = dt
        AjustaColumnasPreca()


    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False
        ' BConsultar.Visible = False
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbCodGenero.Text = ""
        LbNombreGenero.Text = ""
        LbFechaLote.Text = ""

    End Sub


    Private Sub CargaGrid(Idlote As String)

        Dim lotes As New E_Lotes(Idusuario, cn)
        Dim lotes_lineas As New E_Lotes_lineas(Idusuario, cn)
        Dim palets As New E_palets(Idusuario, cn)
        Dim palets_lineas As New E_palets_lineas(Idusuario, cn)
        Dim palets_traza As New E_palets_traza(Idusuario, cn)
        Dim albsalida_palets As New E_albsalida_palets(Idusuario, cn)
        Dim albsalida As New E_AlbSalida(Idusuario, cn)
        Dim clientes As New E_Clientes(Idusuario, cn)
        Dim puntoventa As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))


        Dim dtprecas As DataTable = Gridpreca.DataSource
        If Not dtprecas Is Nothing Then
            For Each rw In dtprecas.Rows
                Dim id As Integer = VaInt(rw("idpreca"))
                Dim kilos As Decimal = VaDec(rw("Kilos"))
                Dim kilospreca As Decimal = LotesProduccion.kilosLote(id.ToString)
                Dim porcelote As Decimal = 0
                If kilospreca > 0 Then
                    porcelote = kilos / kilospreca * 100
                End If
                Dt_palets(0, 0, id, porcelote) ' los palets que tienen precalibrado


            Next
        End If
        Dt_palets(0, VaInt(Idlote), 0, 0) ' los palets del lote

        Dim dtpalets As DataTable = Acum_Palet.DataTable



        If Not dtpalets Is Nothing Then

            Dim dv As New DataView(dtpalets)
            If dtpalets.Rows.Count > 0 Then
                dv.Sort = "Fecha"
                dtpalets = dv.ToTable
                Grid.DataSource = dtpalets
                AjustaColumnas()
            End If
        End If
    End Sub


    Private Sub Dt_palets(idlineaentrada As Integer, idlote As Integer, idpreca As Integer, porce As Decimal)

        Dim ret As New DataTable
        Dim sql As String

        Dim Consulta4 As New Cdatos.E_select
        Dim palets As New E_palets(Idusuario, cn)
        Dim palets_lineas As New E_palets_lineas(Idusuario, cn)
        Dim palets_traza As New E_palets_traza(Idusuario, cn)
        Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
        Dim albsalida_palets As New E_albsalida_palets(Idusuario, cn)
        Dim albsalida As New E_AlbSalida(Idusuario, cn)
        Dim clientes As New E_Clientes(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
        Dim Fecha As String
        Dim Producto As String
        Dim Palet As Integer
        Dim Preca As Integer
        Dim Albaran As Integer
        Dim Codigo As Integer
        Dim Cliente As String
        Dim FechaSalida As String
        Dim Categoria As String



        ' busco los palets donde esta la partida,el lote o el precalibrado

        Consulta4.SelCampo(palets_traza.PLT_idlineapalet, "idlineapalet")
        Consulta4.SelCampo(palets_traza.PLT_bultos, "Bultos")
        Consulta4.SelCampo(palets_traza.PLT_kilos, "Kilos")
        Consulta4.SelCampo(palets_lineas.PLL_idpalet, "idpalet", palets_traza.PLT_idlineapalet)
        Consulta4.SelCampo(Generos.GEN_NombreGenero, "Genero", palets_lineas.PLL_idgenero)
        Consulta4.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", palets_lineas.PLL_idcategoria)
        Consulta4.SelCampo(palets.PAL_palet, "Palet", palets_lineas.PLL_idpalet)
        Consulta4.SelCampo(palets.PAL_fecha, "FechaPalet")
        Consulta4.SelCampo(LotesProduccion.LPD_Lote, "Preca", palets_traza.PLT_idprecalibrado, LotesProduccion.LPD_Idlote)
        Consulta4.SelCampo(albsalida_palets.ASP_IdAlbaran, "idalbaran", palets.PAL_idpalet, albsalida_palets.ASP_Idpalet)
        Consulta4.SelCampo(albsalida.ASA_albaran, "Albaran", albsalida_palets.ASP_IdAlbaran)
        Consulta4.SelCampo(albsalida.ASA_fechasalida, "FechaSalida")
        Consulta4.SelCampo(albsalida.ASA_idcliente, "Codigo")
        Consulta4.SelCampo(clientes.CLI_Nombre, "Cliente", albsalida.ASA_idcliente)
        Consulta4.WheCampo(palets_traza.PLT_idprogramacliente, "=", MiMaletin.idprogramacliente.ToString)
        If idlineaentrada > 0 Then
            Consulta4.WheCampo(palets_traza.PLT_IdLineaEntrada, "=", idlineaentrada)
        ElseIf idlote > 0 Then
            Consulta4.WheCampo(palets_traza.PLT_idlote, "=", idlote)
        ElseIf idpreca > 0 Then
            Consulta4.WheCampo(palets_traza.PLT_idprecalibrado, "=", idpreca)
        End If
        sql = Consulta4.SQL
        ret = palets.MiConexion.ConsultaSQL(sql)

        If Not ret Is Nothing Then

            For Each rw4 In ret.Rows

                Palet = VaInt(rw4("palet"))
                Preca = VaInt(rw4("Preca"))
                Fecha = rw4("fechapalet").ToString
                Producto = rw4("genero").ToString
                Albaran = VaInt(rw4("albaran"))
                Codigo = VaInt(rw4("codigo"))
                Cliente = rw4("cliente").ToString
                FechaSalida = rw4("fechasalida").ToString
                Categoria = rw4("categoria").ToString
                Dim kilos As Decimal = 0
                Kilos = VaDec(rw4("Kilos"))
                If porce <> 0 Then
                    Kilos = Kilos * porce / 100
                End If

                AcumularPalet(Palet, Preca, Fecha, Producto, Albaran, FechaSalida, Codigo, Cliente, Categoria, kilos)

            Next

        End If

        ' Consulta.WheCampo(lotes_lineas.LTL_Idprogramacliente, "=", MiMaletin.idprogramacliente.ToString)

    End Sub

    Private Sub AcumularPalet(Palet As Integer, Preca As Integer, Fecha As String, Producto As String, Albaran As Integer, FechaSalida As String, Codigo As Integer, Cliente As String, Categoria As String, kilos As Decimal)
        Dim clave As New stClaves_palets(Palet, Preca, Producto, Fecha, Albaran, FechaSalida, Codigo, Cliente, Categoria)
        Dim datos As New stDatos_palets(1, kilos)

        Acum_Palet.Suma(clave, datos)

    End Sub


    Private Sub AjustaColumnas()

        'For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
        '    Select Case c.FieldName.ToUpper.Trim

        '        Case "ALBARAN", "FECHA", "PVENTA", "NOMBRE", "CLIENTE", "CODIGO", "GASTO", "VGASTO", "TIPO", "IMPORTE", "NOMBREACREEDOR", "FACTURA"
        '            c.Visible = True
        '        Case Else
        '            c.Visible = False
        '    End Select
        'Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "CANTIDAD"
                    c.Visible = False
                Case "CLIENTE", "GENERO"
                    c.Width = 200
                Case Else
                    c.Width = 80
                    '                    c.Width = 50
            End Select
        Next

        AñadeResumenCampo("Kilos", "{0:n0}")
    End Sub

    Private Sub AjustaColumnasPartida()

        'For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
        '    Select Case c.FieldName.ToUpper.Trim

        '        Case "ALBARAN", "FECHA", "PVENTA", "NOMBRE", "CLIENTE", "CODIGO", "GASTO", "VGASTO", "TIPO", "IMPORTE", "NOMBREACREEDOR", "FACTURA"
        '            c.Visible = True
        '        Case Else
        '            c.Visible = False
        '    End Select
        'Next

        GridPartidasView.BestFitColumns()
        GridPartidasView.OptionsView.ShowGroupPanel = False
        GridPartidasView.OptionsBehavior.Editable = False
        GridPartidasView.OptionsView.ColumnAutoWidth = True



        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridPartidasView.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDLINEA"
                    c.Visible = False

            End Select
        Next
        ' Funciones.AñadeResumenCampo(GridView2, "Kilos", "{0:n0}")
        Funciones.AñadeResumenCampo(GridPartidasView, "Kilos", "{0:n0}")



    End Sub


    Private Sub AjustaColumnasPreca()

        'For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
        '    Select Case c.FieldName.ToUpper.Trim

        '        Case "ALBARAN", "FECHA", "PVENTA", "NOMBRE", "CLIENTE", "CODIGO", "GASTO", "VGASTO", "TIPO", "IMPORTE", "NOMBREACREEDOR", "FACTURA"
        '            c.Visible = True
        '        Case Else
        '            c.Visible = False
        '    End Select
        'Next

        GridViewpreca.BestFitColumns()
        GridViewpreca.OptionsView.ShowGroupPanel = False
        GridViewpreca.OptionsBehavior.Editable = False
        GridViewpreca.OptionsView.ColumnAutoWidth = True



        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewpreca.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDPRECA"
                    c.Visible = False

            End Select
        Next
        ' Funciones.AñadeResumenCampo(GridView2, "Kilos", "{0:n0}")
        Funciones.AñadeResumenCampo(GridViewpreca, "Kilos", "{0:n0}")



    End Sub

    Private Sub TxDato1_Valida(edicion As System.Boolean) Handles TxDato1.Valida

        If edicion Then

            Dim IdGenero As String = ""

            Dim Idlote As String = Lotes.LeerLote(MiMaletin.Ejercicio.ToString, TxDato1.Text)

            If VaInt(Idlote) > 0 Then
                If Lotes.LeerId(Idlote) = True Then
                    IdGenero = Lotes.LTE_Idgenero.Valor
                    LbFechaLote.Text = Lotes.LTE_Fecha.Valor
                    If Generos.LeerId(IdGenero) Then
                        LbCodGenero.Text = IdGenero
                        LbNombreGenero.Text = Generos.GEN_NombreGenero.Valor
                    End If
                    CargaPartidas(Idlote)
                    CargaPreca(Idlote)
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


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        Dim Idlote As String = Lotes.LeerLote(MiMaletin.Ejercicio, VaInt(TxDato1.Text))

        If VaInt(Idlote) > 0 Then
            CargaGrid(Idlote)
        Else
            MsgBox("Debe introducir un lote válido")
        End If


    End Sub

    Private Sub VerClasificacion()

        Dim Idlote As Integer = Lotes.LeerLote(MiMaletin.Ejercicio.ToString, TxDato1.Text)

        If Idlote > 0 Then
            Dim lst As New List(Of Parametros)
            Dim dt As DataTable = AgClasifiLote(Idlote.ToString, TxDato1.Text)
            dt.Columns.Add("KLote", GetType(Decimal))

            lst.Add(New Parametros("idCat", False, "", 50))
            lst.Add(New Parametros("Categoria", False, "", 200))
            lst.Add(New Parametros("Numero", False, "", 150))
            lst.Add(New Parametros("Kilos", True, "{0:n2}", 150))
            lst.Add(New Parametros("Porcentaje", True, "{0:n2}", 150))
            lst.Add(New Parametros("KLote", True, "{0:n2}", 150))

            Dim sql As String = "Select sum(ltl_kilos) as kilos from lotes_lineas where ltl_idlote=" + Idlote.ToString
            Dim dtk As DataTable = Lotes_lineas.MiConexion.ConsultaSQL(sql)
            Dim Klote As Decimal = 0
            If Not dtk Is Nothing Then
                If dtk.Rows.Count > 0 Then
                    Klote = VaDec(dtk.Rows(0)("kilos"))
                End If
            End If
            For Each rw In dt.Rows
                rw("Klote") = VaDec(Klote * VaDec(rw("porcentaje")) / 100)
            Next

            Dim f As New FrConsultaGenerica(dt, lst, "Clasificacion lote")
            f.ShowDialog()
        End If

    End Sub
  
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If VaInt(TxDato1.Text) > 0 Then
            VerClasificacion()
        End If
    End Sub
End Class