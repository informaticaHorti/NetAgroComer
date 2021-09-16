Public Class FrmTrazaSalida
    Inherits FrConsulta


    Private AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Private AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Private Albsalida As New E_AlbSalida(Idusuario, cn)
    Private Clientes As New E_Clientes(Idusuario, cn)
    Private Agricultores As New E_Agricultores(Idusuario, cn)
    Private Generos As New E_Generos(Idusuario, cn)

    Private Cultivos As New E_Cultivos(Idusuario, cnFincasNET)
    Private Fincas As New E_Fincas(Idusuario, cnFincasNET)
    Private Naves As New E_Naves(Idusuario, cnFincasNET)
    Private Variedades As New E_Variedades(Idusuario, cnFincasNET)


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

        Public Idpalet As Integer
        Public Palet As Integer
        Public Producto As String
        Public categoria As String
        Public Fecha As String


        Public Sub New(idpalet As String, palet As String, Producto As String, Fecha As String, categoria As String)
            Me.Idpalet = idpalet
            Me.Producto = Producto
            Me.Palet = palet
            Me.Fecha = FnLeft(Fecha, 10)
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


    Private Class stClaves_partida
        Public Idpartida As Integer
        Public Partida As Integer
        Public Albaran As Integer
        Public Agricultor As String
        Public Producto As String
        Public Fecha As String
        Public IdCultivo As Integer
        Public Cultivo As String
        Public IdFinca As Integer
        Public Finca As String
        Public IdNave As Integer
        Public Nave As String


        Public Sub New(Idpartida As Integer, Partida As Integer, Albaran As Integer, Agricultor As String, Producto As String, Fecha As String, IdCultivo As Integer, Cultivo As String, IdFinca As Integer, Finca As String, IdNave As Integer, Nave As String)
            Me.Idpartida = Idpartida
            Me.Partida = Partida
            Me.Albaran = Albaran
            Me.Agricultor = Agricultor
            Me.Producto = Producto
            Me.Fecha = Fecha
            Me.IdCultivo = IdCultivo
            Me.Cultivo = Cultivo
            Me.IdFinca = IdFinca
            Me.Finca = Finca
            Me.IdNave = IdNave
            Me.Nave = Nave
            Me.Fecha = FnLeft(Fecha, 10)
        End Sub

    End Class

    Private Class stDatos_partida


        Public Kilos As Decimal = 0

        Public Sub New(Kilos As Decimal)

            Me.Kilos = Kilos
        End Sub

    End Class


    Dim Acum_Lote As New Acumulador
    Dim Acum_Preca As New Acumulador
    Dim Acum_Palet As New Acumulador
    Dim Acum_Partida As New Acumulador

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Albsalida.ASA_albaran, Lb1, True)


    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False
        ' BConsultar.Visible = False

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


        GridLotes.DataSource = Nothing
        GridPreca.DataSource = Nothing


        LbCodCliente.Text = ""
        LbNombreCliente.Text = ""
        LbKilos.Text = ""
        LbFechaSalida.Text = ""


    End Sub


    Private Sub CargaGrid(IdAlbaran As String)

        Dim lotes As New E_Lotes(Idusuario, cn)
        Dim lotes_lineas As New E_Lotes_lineas(Idusuario, cn)
        Dim Lotesproduccion As New E_LotesProduccion(Idusuario, cn)
        Dim LotesProduccion_lineas As New E_LotesProduccion_Lineas(Idusuario, cn)
        Dim Categoria As New E_CategoriasSalida(Idusuario, cn)

        Dim palets As New E_palets(Idusuario, cn)
        Dim palets_lineas As New E_palets_lineas(Idusuario, cn)
        Dim palets_traza As New E_palets_traza(Idusuario, cn)
        Dim albsalida_palets As New E_albsalida_palets(Idusuario, cn)
        Dim albsalida As New E_AlbSalida(Idusuario, cn)
        Dim clientes As New E_Clientes(Idusuario, cn)
        Dim puntoventa As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)

        Dim fecha As String
        Dim producto As String
        Dim cat As String
        Dim idpalet As Integer
        Dim palet As Integer
      








        Dim Sql As String

        ' busco los lotes donde esta la partida
        Dim Consulta As New Cdatos.E_select
        Consulta.SelCampo(palets_lineas.PLL_idlinea, "idlinea")
        Consulta.SelCampo(palets_lineas.PLL_idpalet, "idpalet")
        Consulta.SelCampo(palets.PAL_palet, "Palet", palets_lineas.PLL_idpalet)
        Consulta.SelCampo(palets.PAL_fecha, "Fecha")
        Consulta.SelCampo(GenerosSalida.GES_Nombre, "Producto", palets_lineas.PLL_idgensal)
        Consulta.SelCampo(Categoria.CAS_CategoriaCalibre, "Categoria", palets_lineas.PLL_idcategoria)
        Consulta.SelCampo(palets_lineas.PLL_kilosnetos, "Kilos")
        Consulta.SelCampo(albsalida_palets.ASP_IdAlbaran, "idalbaran", palets.PAL_idpalet, albsalida_palets.ASP_Idpalet)

        Consulta.WheCampo(albsalida_palets.ASP_IdAlbaran, "=", Idalbaran)
        Sql = Consulta.SQL
        Dim dtpalets As DataTable = palets_lineas.MiConexion.ConsultaSQL(Sql)

        If Not dtpalets Is Nothing Then

            ' busco los palets que contienen el albaran

            For Each rw In dtpalets.Rows
                idpalet = VaInt(rw("idpalet"))
                palet = VaInt(rw("palet"))
                fecha = rw("Fecha").ToString
                producto = rw("Producto").ToString
                Cat = rw("Categoria").ToString
                Dim kilos As Decimal = VaDec(rw("Kilos"))
                AcumularPalet(idpalet, palet, fecha, producto, cat, kilos)
            Next


            For Each rw In dtpalets.Rows
                Dim idlinea As Integer = VaInt(rw("idlinea"))
                Dim consulta2 As New Cdatos.E_select
                consulta2.SelCampo(palets_traza.PLT_IdLineaEntrada, "idpartida")
                consulta2.SelCampo(palets_traza.PLT_idlote, "idlote")
                consulta2.SelCampo(palets_traza.PLT_idprecalibrado, "idpreca")
                consulta2.SelCampo(palets_traza.PLT_kilos, "Kilos")
                consulta2.WheCampo(palets_traza.PLT_idlineapalet, "=", idlinea.ToString)
                consulta2.WheCampo(palets_traza.PLT_idprogramacliente, "=", MiMaletin.idprogramacliente.ToString)
                Sql = consulta2.SQL
                Dim dttraza As DataTable = palets_traza.MiConexion.ConsultaSQL(Sql)
                If Not dttraza Is Nothing Then
                    For Each rwt In dttraza.Rows
                        Dim idpartida As Integer = VaInt(rwt("idpartida"))
                        Dim idlote As Integer = VaInt(rwt("idlote"))
                        Dim idpreca As Integer = VaInt(rwt("idpreca"))
                        Dim kilos As Decimal = VaDec(rwt("kilos"))

                        If idpartida > 0 Then
                            Dt_partidas(idpartida, kilos)
                        End If
                        If idlote > 0 Then
                            Dt_lotes(idlote, kilos)
                        End If
                        If idpreca > 0 Then
                            Dt_preca(idpreca, kilos)
                        End If
                    Next
                End If
            Next
          
            LineasPrecalibrado()
            LineasLote()
        End If


        GridLotes.DataSource = Acum_Lote.DataTable
        GridPreca.DataSource = Acum_Preca.DataTable
        Grid.DataSource = Acum_Partida.DataTable
        GridPalets.DataSource = Acum_Palet.DataTable
        AjustaColumnas()
        AjustaColumnasLotes()
        AjustaColumnasPreca()
        AjustaColumnaspalets()


    End Sub

    Private Sub LineasPrecalibrado()
        Dim lotesproduccion As New E_LotesProduccion(Idusuario, cn)
        Dim lotesproduccion_lineas As New E_LotesProduccion_Lineas(Idusuario, cn)
        Dim dtprecas As DataTable = Acum_Preca.DataTable
        If Not dtprecas Is Nothing Then
            For Each rw In dtprecas.Rows
                Dim id As Integer = VaInt(rw("idpreca"))
                Dim kilos As Decimal = VaDec(rw("Kilos"))
                Dim kilospreca As Decimal = lotesproduccion.kilosLote(id.ToString)
                Dim porcelote As Decimal = 0
                If kilospreca > 0 Then
                    porcelote = kilos / kilospreca * 100
                End If
                If porcelote = 0 Then
                    porcelote = 100
                End If
                Dim consulta As New Cdatos.E_select
                consulta.SelCampo(lotesproduccion_lineas.LPL_IdLotePartida, "idlote")
                consulta.SelCampo(lotesproduccion_lineas.LPL_IdlineaEntrada, "idpartida")
                consulta.SelCampo(lotesproduccion_lineas.LPL_Kilos, "kiloslinea")
                consulta.WheCampo(lotesproduccion_lineas.LPL_Idlote, "=", id.ToString)
                Dim sql As String = consulta.SQL
                Dim dt As DataTable = lotesproduccion.MiConexion.ConsultaSQL(sql)
                If Not dt Is Nothing Then
                    For Each rwl In dt.Rows
                        If VaInt(rwl("idpartida")) > 0 Then
                            Dt_partidas(VaInt(rwl("idpartida")), VaDec(rwl("kiloslinea")) * porcelote / 100)
                        ElseIf VaInt(rwl("idlote")) > 0 Then
                            Dt_lotes(VaInt(rwl("idlote")), VaDec(rwl("kiloslinea")) * porcelote / 100)
                        End If
                    Next
                End If
            Next
        End If


    End Sub


    Private Sub LineasLote()
        Dim lotes As New E_Lotes(Idusuario, cn)
        Dim lotes_lineas As New E_Lotes_lineas(Idusuario, cn)
        Dim dtlote As DataTable = Acum_Lote.DataTable
        If Not dtlote Is Nothing Then
            For Each rw In dtlote.Rows
                Dim id As Integer = VaInt(rw("idlote"))
                Dim kilos As Decimal = VaDec(rw("Kilos"))
                Dim kiloslote As Decimal = lotes.kilosLote(id.ToString)
                Dim porcelote As Decimal = 0
                If kiloslote > 0 Then
                    porcelote = kilos / kiloslote * 100
                End If
                If porcelote = 0 Then
                    porcelote = 100
                End If
                Dim consulta As New Cdatos.E_select
                consulta.SelCampo(lotes_lineas.LTL_Idlineaentrada, "idpartida")
                consulta.SelCampo(lotes_lineas.LTL_Kilos, "kiloslinea")
                consulta.WheCampo(lotes_lineas.LTL_Idlote, "=", id.ToString)
                Dim sql As String = consulta.SQL
                Dim dt As DataTable = lotes.MiConexion.ConsultaSQL(sql)
                If Not dt Is Nothing Then
                    For Each rwl In dt.Rows
                        If VaInt(rwl("idpartida")) > 0 Then
                            Dt_partidas(VaInt(rwl("idpartida")), VaDec(rwl("kiloslinea")) * porcelote / 100)
                        End If
                    Next
                End If
            Next
        End If


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

    Private Sub AcumularPalet(idpalet As Integer, Palet As Integer, Fecha As String, Producto As String, Categoria As String, Kilos As Decimal)
        Dim clave As New stClaves_palets(idpalet, Palet, Producto, Fecha, Categoria)
        Dim datos As New stDatos_palets(1, Kilos)

        Acum_Palet.Suma(clave, datos)

    End Sub

    Private Sub AcumularPartida(idpartida As Integer, partida As Integer, albaran As Integer, agricultor As String, producto As String, fecha As String, idcultivo As Integer, cultivo As String, idfinca As String, finca As String, idnave As String, nave As String, kilos As Decimal)
        Dim clave As New stClaves_partida(idpartida, partida, albaran, agricultor, producto, fecha, idcultivo, cultivo, idfinca, finca, idnave, nave)
        Dim datos As New stDatos_partida(kilos)
        Acum_Partida.Suma(clave, datos)
    End Sub

    Private Sub Dt_lotes(idlote As Integer, kilos As Decimal)
        Dim lotes As New E_Lotes(Idusuario, cn)
        Dim lotes_lineas As New E_Lotes_lineas(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(lotes.LTE_Fecha, "fecha")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", lotes.LTE_Idgenero)
        consulta.SelCampo(lotes.LTE_Lote, "lote")
        consulta.WheCampo(lotes.LTE_Idlote, "=", idlote.ToString)
        Dim dt As DataTable = lotes.MiConexion.ConsultaSQL(consulta.SQL)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                Dim rw As DataRow = dt.Rows(0)
                AcumularLote(idlote, VaInt(rw("lote")), rw("Fecha").ToString, rw("Genero").ToString, kilos)
            End If
        End If

    End Sub

    Private Sub Dt_preca(idpreca As Integer, kilos As Decimal)
        Dim lotesproduccion As New E_LotesProduccion(Idusuario, cn)
        Dim lotesproduccion_lineas As New E_LotesProduccion_Lineas(Idusuario, cn)
        Dim Categoria As New E_CategoriasSalida(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(lotesproduccion.LPD_Fecha, "fecha")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", lotesproduccion.LPD_Idgenero)
        consulta.SelCampo(lotesproduccion.LPD_Lote, "lote")
        consulta.SelCampo(Categoria.CAS_CategoriaCalibre, "Categoria", lotesproduccion.LPD_IdCategoria)
        consulta.WheCampo(lotesproduccion.LPD_Idlote, "=", idpreca.ToString)
        Dim dt As DataTable = lotesproduccion.MiConexion.ConsultaSQL(consulta.SQL)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                Dim rw As DataRow = dt.Rows(0)
                AcumularPreca(idpreca, VaInt(rw("lote")), rw("Fecha").ToString, rw("Genero").ToString, rw("categoria").ToString, kilos)
            End If
        End If

    End Sub


    Private Sub Dt_partidas(idlineaentrada As Integer, kilos As Decimal)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbEntrada_Lineas.AEL_muestreo, "Partida")
        consulta.SelCampo(AlbEntrada.AEN_Albaran, "Albaran", AlbEntrada_Lineas.AEL_idalbaran)
        consulta.SelCampo(AlbEntrada.AEN_Fecha, "Fecha")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbEntrada_Lineas.AEL_idgenero)
        consulta.SelCampo(Agricultores.AGR_Nombre, "Agricultor", AlbEntrada.AEN_IdAgricultor)
        consulta.SelCampo(AlbEntrada_Lineas.AEL_idcultivo, "IdCultivo")
        consulta.SelCampo(Cultivos.CUL_IdFinca, "IdFinca", AlbEntrada_Lineas.AEL_idcultivo, Cultivos.CUL_IdCultivo)
        consulta.SelCampo(Fincas.FIN_Nombre, "Finca", Cultivos.CUL_IdFinca, Fincas.FIN_IdFinca)
        consulta.SelCampo(Cultivos.CUL_IdNave, "IdNave")
        consulta.SelCampo(Naves.NAV_Nombre, "Nave", Cultivos.CUL_IdNave, Naves.NAV_IdNave)
        consulta.SelCampo(Variedades.VAR_Nombre, "Variedad", Cultivos.CUL_IdVariedad, Variedades.VAR_IdVariedad)
        consulta.WheCampo(AlbEntrada_Lineas.AEL_idlinea, "=", idlineaentrada)


        Dim dt As DataTable = AlbEntrada_Lineas.MiConexion.ConsultaSQL(consulta.SQL)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                Dim rw As DataRow = dt.Rows(0)

                Dim partida As Integer = VaInt(rw("Partida"))
                Dim albaran As Integer = VaInt(rw("Albaran"))
                Dim agricultor As String = rw("Agricultor").ToString
                Dim genero As String = rw("Genero").ToString
                Dim fecha As String = rw("Fecha").ToString
                Dim idcultivo As Integer = VaInt(rw("IdCultivo"))
                Dim idfinca As Integer = VaInt(rw("IdFinca"))
                Dim finca As String = rw("Finca").ToString
                Dim idnave As Integer = VaInt(rw("IdNave"))
                Dim nave As String = rw("Nave").ToString
                Dim variedad As String = (rw("Variedad").ToString & "").Trim
                Dim cultivo As String = genero : If variedad.Trim <> "" Then cultivo = genero & " - " & variedad

                AcumularPartida(idlineaentrada, partida, albaran, agricultor, genero, fecha, idcultivo, cultivo, idfinca, finca, idnave, nave, kilos)

            End If
        End If

    End Sub
   


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CANTIDAD", "IDPARTIDA", "IDFINCA", "IDNAVE"
                    c.Visible = False

            End Select
        Next


        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsView.ColumnAutoWidth = True


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 85
                    'Case "PRODUCTO", "CLIENTE"
                    '    c.Width = 0
                    'Case Else
                    '    c.Width = 50
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
                Case "FECHA"
                    c.Width = 100
                Case "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 85

                Case Else
                    c.Width = 50
            End Select
        Next

        Funciones.AñadeResumenCampo(GridlotesView, "Kilos", "{0:n0}")

    End Sub

    Private Sub AjustaColumnasPreca()

        

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
                Case "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 85


                Case Else
                    c.Width = 100
            End Select
        Next
        Funciones.AñadeResumenCampo(GridPrecaView, "Kilos", "{0:n0}")

    End Sub

    Private Sub AjustaColumnaspalets()



        GridPaletsView.BestFitColumns()
        GridPaletsView.OptionsView.ShowGroupPanel = False
        GridPaletsView.OptionsBehavior.Editable = False
        GridPaletsView.OptionsView.ColumnAutoWidth = True




        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridPaletsView.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDPALET", "CANTIDAD"
                    c.Visible = False
                Case "PRODUCTO"
                    c.Width = 200
                Case "CATEGORIA", "FECHA"
                    c.Width = 100
                Case "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 85

                Case Else
                    c.Width = 100
            End Select
        Next
        Funciones.AñadeResumenCampo(GridPaletsView, "Kilos", "{0:n0}")

    End Sub


    Private Sub TxDato1_Valida(edicion As System.Boolean) Handles TxDato1.Valida

        If edicion Then

            Dim Idcliente As String = ""

            Dim Idalbaran As String = Albsalida.LeerAlb(MiMaletin.Ejercicio, MiMaletin.IdCentro, TxDato1.Text)
            If Idalbaran > 0 Then
                LbCodCliente.Text = Albsalida.ASA_idcliente.Valor
                If Clientes.LeerId(LbCodCliente.Text) Then
                    LbNombreCliente.Text = Clientes.CLI_Nombre.Valor
                End If
                LbFechaSalida.Text = Albsalida.ASA_fechasalida.Valor
                LbKilos.Text = Format(Albsalida.TotalKilos(Idalbaran), "#,###")
            Else
                MsgBox("Albaran inexistente")
                TxDato1.MiError = True
            End If






            Grid.DataSource = Nothing

        End If


    End Sub


    Public Overrides Sub Imprimir()


        LineasDescripcion.Clear()

        If TxDato1.Text.Trim <> "" Then

            LineasDescripcion.Add("Albaran: " & TxDato1.Text)
            LineasDescripcion.Add("Cliente: " & LbCodCliente.Text & " " & LbNombreCliente.Text)
            LineasDescripcion.Add("Kilos: " & LbKilos.Text)
            LineasDescripcion.Add("Fecha salida: " & LbFechaSalida.Text)

        End If


        MyBase.Imprimir()

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        Dim IdAlbaran As String = Albsalida.LeerAlb(MiMaletin.Ejercicio, MiMaletin.IdCentro, TxDato1.Text)
        Acum_Lote.Borrar()
        Acum_Palet.Borrar()
        Acum_Preca.Borrar()
        Acum_Partida.Borrar()

        CargaGrid(IdAlbaran)
    End Sub


    Private Sub TxDato1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato1.TextChanged

    End Sub
End Class