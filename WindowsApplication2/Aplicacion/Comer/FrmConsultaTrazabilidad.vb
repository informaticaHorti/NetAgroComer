Public Class FrmConsultaTrazabilidad
    Inherits FrConsulta


    Private AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Private AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Private Agricultores As New E_Agricultores(Idusuario, cn)
    Private Generos As New E_Generos(Idusuario, cn)
    

    
    Dim err As New Errores

    Private Class stClaves_lotes
        Public Idlote As Integer
        Public Lote As Integer
        Public Producto As String
        Public Fecha As String

        Public Sub New(IdLote As Integer, Lote As Integer, Producto As String, Fecha As String)
            Me.Idlote = IdLote
            Me.Producto = Producto
            Me.Lote = Lote
            Me.Fecha = FnLeft(Fecha, 10)
        End Sub

    End Class

    Private Class stDatos_lotes

        Public Cantidad As Decimal = 0
        Public Kilos As Decimal = 0

        Public Sub New(Cantidad As Decimal, Kilos As Decimal)
            Me.Cantidad = Cantidad
            Me.Kilos = Kilos
        End Sub

    End Class

    Private Class stClaves_preca
        Public IdPreca As Integer
        Public Preca As String
        Public Producto As String
        Public Fecha As String
        Public Categoria As String

        Public Sub New(idpreca As Integer, Preca As Integer, Producto As String, Fecha As String, Categoria As String)
            Me.IdPreca = idpreca
            Me.Producto = Producto
            Me.Preca = Preca
            Me.Fecha = FnLeft(Fecha, 10)
            Me.Categoria = Categoria
        End Sub

    End Class

    Private Class stDatos_preca

        Public Cantidad As Decimal = 0
        Public Kilos As Decimal = 0

        Public Sub New(Cantidad As Decimal, Kilos As Decimal)
            Me.Cantidad = Cantidad
            Me.Kilos = Kilos
        End Sub

    End Class

    Private Class stClaves_palets


        Public Palet As Integer
        Public Producto As String
        Public categoria As String
        Public Fecha As String
        Public albaran As Integer
        Public fechasalida As String
        Public codigo As Integer
        Public cliente As String


        Public Sub New(palet As String, Producto As String, Fecha As String, albaran As Integer, fechasalida As String, codigo As Integer, cliente As String, categoria As String)
            Me.Producto = Producto
            Me.Palet = palet
            Me.Fecha = FnLeft(Fecha, 10)
            Me.albaran = albaran
            Me.fechasalida = FnLeft(fechasalida, 10)
            Me.codigo = codigo
            Me.cliente = cliente
            Me.categoria = categoria

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

    Dim Acum_Lote As New Acumulador
    Dim Acum_Preca As New Acumulador
    Dim Acum_Palet As New Acumulador

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, AlbEntrada_Lineas.AEL_muestreo, Lb1, True)
        

    End Sub

    
    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False
       ' BConsultar.Visible = False

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


        GridLotes.DataSource = Nothing
        GridPreca.DataSource = Nothing

        LbCodAgricultor.Text = ""
        LbNombreAgricultor.Text = ""
        LbKilos.Text = ""
        LbFechaEntrada.Text = ""
        LbAlbCompra.Text = ""
        LbBultos.Text = ""
        LbProducto.Text = ""


    End Sub


    Private Sub CargaGrid(IdLineaEntrada As String)

        Dim lotes As New E_Lotes(Idusuario, cn)
        Dim lotes_lineas As New E_Lotes_lineas(Idusuario, cn)
        Dim Lotesproduccion As New E_LotesProduccion(Idusuario, cn)
        Dim LotesProduccion_lineas As New E_LotesProduccion_Lineas(Idusuario, cn)


        Dim palets As New E_palets(Idusuario, cn)
        Dim palets_lineas As New E_palets_lineas(Idusuario, cn)
        Dim palets_traza As New E_palets_traza(Idusuario, cn)
        Dim albsalida_palets As New E_albsalida_palets(Idusuario, cn)
        Dim albsalida As New E_AlbSalida(Idusuario, cn)
        Dim clientes As New E_Clientes(Idusuario, cn)
        Dim puntoventa As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim idlote As Integer
        Dim lote As Integer
        Dim fecha As String
        Dim producto As String




        Dim Sql As String

        ' busco los lotes donde esta la partida
        Dim Consulta As New Cdatos.E_select
        Consulta.SelCampo(lotes_lineas.LTL_Idlote, "Idlote")
        Consulta.SelCampo(lotes.LTE_Lote, "Lote", lotes_lineas.LTL_Idlote)
        Consulta.SelCampo(lotes.LTE_Fecha, "FechaLote")
        Consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", lotes.LTE_Idgenero)
        Consulta.SelCampo(lotes_lineas.LTL_Kilos, "Kilos")
        Consulta.WheCampo(lotes_lineas.LTL_Idlineaentrada, "=", IdLineaEntrada)
        Sql = Consulta.SQL
        Dim dtlote As DataTable = lotes_lineas.MiConexion.ConsultaSQL(Sql)

        If Not dtlote Is Nothing Then

            ' busco los precalibrados que contienen cada lote

            For Each rw In dtlote.Rows
                idlote = VaInt(rw("idlote"))
                Lote = VaInt(rw("lote"))
                Fecha = rw("Fechalote").ToString
                producto = rw("genero").ToString
                Dim kilos As Decimal = VaDec(rw("Kilos"))
                AcumularLote(idlote, lote, fecha, producto, kilos)
                Dim kiloslote As Decimal = lotes.kilosLote(idlote.ToString)
                Dim porcelote As Decimal = 0
                If kiloslote > 0 Then
                    porcelote = kilos / kiloslote * 100
                End If
                dt_PreCalibrados(0, VaInt(rw("idlote")), porcelote)


            Next
        End If



        ' busco los precalibrados donde esta la partida

        dt_PreCalibrados(IdLineaEntrada, 0, 0)

        Dt_palets(IdLineaEntrada, 0, 0, 0) ' los palets que tienen la linea de entrada

        Dim dtlotes As DataTable = Acum_Lote.DataTable
        If Not dtlotes Is Nothing Then
            For Each rw In dtlote.Rows
                Dim id As Integer = VaInt(rw("idlote"))
                Dim kilos As Decimal = VaDec(rw("Kilos"))
                Dim kiloslote As Decimal = lotes.kilosLote(id.ToString)
                Dim porcelote As Decimal = 0
                If kiloslote > 0 Then
                    porcelote = kilos / kiloslote * 100
                End If
                Dt_palets(0, id, 0, porcelote) ' los palets que tienen lote
            Next
        End If

        Dim dtprecas As DataTable = Acum_Preca.DataTable
        If Not dtprecas Is Nothing Then
            For Each rw In dtprecas.Rows
                Dim id As Integer = VaInt(rw("idpreca"))
                Dim kilos As Decimal = VaDec(rw("Kilos"))
                Dim kilospreca As Decimal = Lotesproduccion.kilosLote(id.ToString)
                Dim porcelote As Decimal = 0
                If kilospreca > 0 Then
                    porcelote = kilos / kilospreca * 100
                End If
                Dt_palets(0, 0, id, porcelote) ' los palets que tienen precalibrado
            Next
        End If

        Dim dtpalets As DataTable = Acum_Palet.DataTable

        GridLotes.DataSource = dtlotes
        GridPreca.DataSource = dtprecas
        Grid.DataSource = dtpalets
        AjustaColumnas()
        AjustaColumnasLotes()
        AjustaColumnasPreca()


    End Sub

    Private Sub AcumularLote(idlote As Integer, Lote As Integer, Fecha As String, Producto As String, Kilos As Decimal)
        Dim clave As New stClaves_lotes(idlote, Lote, Producto, Fecha)
        Dim datos As New stDatos_lotes(1, Kilos)

        Acum_Lote.Suma(clave, datos)

    End Sub

    Private Sub AcumularPreca(idpreca As Integer, Preca As Integer, Fecha As String, Producto As String, Categoria As String, Kilos As Decimal)
        Dim clave As New stClaves_preca(idpreca, Preca, Producto, Fecha, Categoria)
        Dim datos As New stDatos_preca(1, Kilos)

        Acum_Preca.Suma(clave, datos)

    End Sub

    Private Sub AcumularPalet(Palet As Integer, Fecha As String, Producto As String, Albaran As Integer, FechaSalida As String, Codigo As Integer, Cliente As String, Categoria As String, Kilos As Decimal)
        Dim clave As New stClaves_palets(Palet, Producto, Fecha, Albaran, FechaSalida, Codigo, Cliente, Categoria)
        Dim datos As New stDatos_palets(1, Kilos)

        Acum_Palet.Suma(clave, datos)

    End Sub

    Private Sub dt_PreCalibrados(idlineaentrada As Integer, idlote As Integer, porcelote As Decimal)

        Dim LotesProduccion_lineas As New E_LotesProduccion_Lineas(Idusuario, cn)
        Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
        Dim sql As String = ""
        ' devuelvo un datatable con los precalibrados por partida o por lote
        Dim ret As New DataTable

        Dim consulta3 As New Cdatos.E_select
        consulta3.SelCampo(LotesProduccion_lineas.LPL_Idlote, "idpreca")
        consulta3.SelCampo(LotesProduccion.LPD_Lote, "Preca", LotesProduccion_lineas.LPL_Idlote)
        consulta3.SelCampo(LotesProduccion.LPD_Fecha, "FechaLote")
        consulta3.SelCampo(Generos.GEN_NombreGenero, "Genero", LotesProduccion.LPD_Idgenero)
        consulta3.SelCampo(LotesProduccion_lineas.LPL_Kilos, "Kilos")
        consulta3.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", LotesProduccion.LPD_IdCategoria)
        If idlote > 0 Then
            consulta3.WheCampo(LotesProduccion_lineas.LPL_IdLotePartida, "=", idlote.ToString)
        ElseIf idlineaentrada > 0 Then
            consulta3.WheCampo(LotesProduccion_lineas.LPL_IdlineaEntrada, "=", idlineaentrada.ToString)
        End If

        sql = consulta3.SQL
        ret = LotesProduccion.MiConexion.ConsultaSQL(sql)

        Dim idpreca As Integer
        Dim Preca As Integer
        Dim Fecha As String
        Dim Producto As String
        Dim Categoria As String

        If Not ret Is Nothing Then
            For Each rwp In ret.Rows

                idpreca = VaInt(rwp("idpreca"))
                Preca = VaInt(rwp("preca"))
                Fecha = rwp("Fechalote").ToString
                Producto = rwp("genero").ToString
                Categoria = rwp("categoria").ToString
                Dim Kilos As Decimal = VaDec(rwp("Kilos"))
                If porcelote <> 0 Then
                    Kilos = Kilos * porcelote / 100
                End If

                AcumularPreca(idpreca, Preca, Fecha, Producto, Categoria, Kilos)

            Next
        End If


    End Sub

    Private Sub Dt_palets(idlineaentrada As Integer, idlote As Integer, idpreca As Integer, porce As Decimal)
        Dim ret As New DataTable
        Dim sql As String

        Dim Consulta4 As New Cdatos.E_select
        Dim palets As New E_palets(Idusuario, cn)
        Dim palets_lineas As New E_palets_lineas(Idusuario, cn)
        Dim palets_traza As New E_palets_traza(Idusuario, cn)
        Dim albsalida_palets As New E_albsalida_palets(Idusuario, cn)
        Dim albsalida As New E_AlbSalida(Idusuario, cn)
        Dim clientes As New E_Clientes(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim Fecha As String
        Dim Producto As String
        Dim Palet As Integer
        Dim Albaran As Integer
        Dim Codigo As Integer
        Dim Cliente As String
        Dim FechaSalida As String
        Dim Categoria As String
        Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
        Dim Kilos As Decimal = 0



        ' busco los palets donde esta la partida,el lote o el precalibrado

        Consulta4.SelCampo(palets_traza.PLT_idlineapalet, "idlineapalet")
        Consulta4.SelCampo(palets_traza.PLT_bultos, "Bultos")
        Consulta4.SelCampo(palets_traza.PLT_kilos, "Kilos")
        Consulta4.SelCampo(palets_lineas.PLL_idpalet, "idpalet", palets_traza.PLT_idlineapalet)
        Consulta4.SelCampo(Generos.GEN_NombreGenero, "Genero", palets_lineas.PLL_idgenero)
        Consulta4.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", palets_lineas.PLL_idcategoria)
        Consulta4.SelCampo(palets.PAL_palet, "Palet", palets_lineas.PLL_idpalet)
        Consulta4.SelCampo(palets.PAL_fecha, "FechaPalet")
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
                Fecha = rw4("fechapalet").ToString
                Producto = rw4("genero").ToString
                Albaran = VaInt(rw4("albaran"))
                Codigo = VaInt(rw4("codigo"))
                Cliente = rw4("cliente").ToString
                FechaSalida = rw4("fechasalida").ToString
                Categoria = rw4("categoria").ToString
                Kilos = VaDec(rw4("Kilos"))
                If porce <> 0 Then
                    Kilos = Kilos * porce / 100
                End If
                AcumularPalet(Palet, Fecha, Producto, Albaran, FechaSalida, Codigo, Cliente, Categoria, Kilos)

            Next

        End If

        ' Consulta.WheCampo(lotes_lineas.LTL_Idprogramacliente, "=", MiMaletin.idprogramacliente.ToString)

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
        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsView.ColumnAutoWidth = True




        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "CANTIDAD"
                    c.Visible = False
                Case "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 85
                Case "PRODUCTO", "CLIENTE"
                    c.Width = 200
                Case Else
                    c.Width = 50
            End Select
        Next


        AñadeResumenCampo("Kilos", "{0:n0}")

    End Sub


    Private Sub AjustaColumnasLotes()

        'For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
        '    Select Case c.FieldName.ToUpper.Trim

        '        Case "ALBARAN", "FECHA", "PVENTA", "NOMBRE", "CLIENTE", "CODIGO", "GASTO", "VGASTO", "TIPO", "IMPORTE", "NOMBREACREEDOR", "FACTURA"
        '            c.Visible = True
        '        Case Else
        '            c.Visible = False
        '    End Select
        'Next

        GridlotesView.BestFitColumns()
        GridlotesView.OptionsView.ShowGroupPanel = False
        GridlotesView.OptionsBehavior.Editable = False
        GridlotesView.OptionsView.ColumnAutoWidth = True




        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridlotesView.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "CANTIDAD", "IDLOTE"
                    c.Visible = False
                Case "PRODUCTO"
                    c.Width = 200
                Case "CATEGORIA"
                    c.Width = 100
                Case Else
                    c.Width = 50
            End Select
        Next
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

        GridPrecaView.BestFitColumns()
        GridPrecaView.OptionsView.ShowGroupPanel = False
        GridPrecaView.OptionsBehavior.Editable = False
        GridPrecaView.OptionsView.ColumnAutoWidth = True




        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridPrecaView.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "CANTIDAD", "IDPRECA"
                    c.Visible = False
                Case "PRODUCTO"
                    c.Width = 200
                Case "CATEGORIA"
                    c.Width = 100

                Case Else
                    c.Width = 100
            End Select
        Next
        Funciones.AñadeResumenCampo(GridPrecaView, "Kilos", "{0:n0}")

    End Sub



    Private Sub TxDato1_Valida(edicion As System.Boolean) Handles TxDato1.Valida

        If edicion Then

            Dim IdAgricultor As String = ""

            Dim IdLineaEntrada As String = AlbEntrada_Lineas.LeerMuestreo(MiMaletin.Ejercicio.ToString, TxDato1.Text)





            LbKilos.Text = ""
            LbFechaEntrada.Text = ""
            LbAlbCompra.Text = ""
            LbBultos.Text = ""
            LbProducto.Text = ""


            'Obtiene datos de kilos, Fecha y AlbCamapa desde IdLineaEntrada 
            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(AlbEntrada_Lineas.AEL_kilosnetos, "Kilos")
            consulta.SelCampo(AlbEntrada_Lineas.AEL_bultos, "bultos")
            consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbEntrada_Lineas.AEL_idgenero)
            consulta.SelCampo(AlbEntrada.AEN_Fecha, "FechaEntrada", AlbEntrada_Lineas.AEL_idalbaran, AlbEntrada.AEN_IdAlbaran)
            consulta.SelCampo(AlbEntrada.AEN_Albaran, "Albaran")
            consulta.SelCampo(AlbEntrada.AEN_IdAgricultor, "IdAgricultor")
            consulta.WheCampo(AlbEntrada_Lineas.AEL_idlinea, "=", IdLineaEntrada)

            Dim dtAEN As DataTable = AlbEntrada.MiConexion.ConsultaSQL(consulta.SQL)
            If Not IsNothing(dtAEN) Then
                If dtAEN.Rows.Count > 0 Then
                    LbKilos.Text = VaDec(dtAEN.Rows(0)("Kilos")).ToString("#,##0.00")
                    LbBultos.Text = VaDec(dtAEN.Rows(0)("Bultos")).ToString("#,###")
                    LbProducto.Text = dtAEN.Rows(0)("Genero").ToString
                    If VaDate(dtAEN.Rows(0)("FechaEntrada")) <> VaDate("") Then LbFechaEntrada.Text = VaDate(dtAEN.Rows(0)("FechaEntrada")).ToString("dd/MM/yyyy")
                    LbAlbCompra.Text = dtAEN.Rows(0)("Albaran")
                    'Muestra datos agricultor
                    IdAgricultor = dtAEN.Rows(0)("IdAgricultor").ToString
                    If Agricultores.LeerId(IdAgricultor) Then
                        LbCodAgricultor.Text = IdAgricultor
                        LbNombreAgricultor.Text = Agricultores.AGR_Nombre.Valor
                    End If

                End If
            End If


            Grid.DataSource = Nothing

            If VaInt(IdLineaEntrada) > 0 Then
                '                CargaGrid(IdLineaEntrada)
            Else
                MsgBox("La partida no existe ")
            End If


        End If


    End Sub


    Public Overrides Sub Imprimir()


        LineasDescripcion.Clear()

        If TxDato1.Text.Trim <> "" Then

            LineasDescripcion.Add("Partida: " & TxDato1.Text)
            LineasDescripcion.Add("Agricultor: " & LbCodAgricultor.Text & " " & LbNombreAgricultor.Text)
            LineasDescripcion.Add("Kilos: " & LbKilos.Text)
            LineasDescripcion.Add("Fecha entrada: " & LbFechaEntrada.Text)
            LineasDescripcion.Add("Alb. compra: " & LbAlbCompra.Text)

        End If


        MyBase.Imprimir()

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        Dim IdLineaEntrada As String = AlbEntrada_Lineas.LeerMuestreo(MiMaletin.Ejercicio.ToString, TxDato1.Text)
        Acum_Lote.Borrar()
        Acum_Palet.Borrar()
        Acum_Preca.Borrar()

        CargaGrid(IdLineaEntrada)
    End Sub
    Private Sub VerClasificacion()

        Dim IdLineaEntrada As Integer = AlbEntrada_Lineas.LeerMuestreo(MiMaletin.Ejercicio.ToString, TxDato1.Text)


        If IdLineaEntrada > 0 Then
            Dim lst As New List(Of Parametros)
            Dim dt As DataTable = AgClasifiPartida(IdLineaEntrada.ToString)
            dt.Columns.Add("KPartida", GetType(Decimal))

            lst.Add(New Parametros("idCat", False, "", 100))
            lst.Add(New Parametros("Categoria", False, "", 300))
            lst.Add(New Parametros("Numero", False, "", 150))
            lst.Add(New Parametros("Kilos", True, "{0:n2}", 150))
            lst.Add(New Parametros("Porcentaje", True, "{0:n2}", 150))
            lst.Add(New Parametros("KPartida", True, "{0:n2}", 150))

            For Each rw In dt.Rows
                rw("KPartida") = VaDec(VaDec(LbKilos.Text) * VaDec(rw("porcentaje")) / 100)
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

    Private Sub TxDato1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato1.TextChanged

    End Sub
End Class