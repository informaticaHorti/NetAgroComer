Imports DevExpress.XtraEditors
Imports System.Linq

Public Class FrmLotesProduccion
    Inherits FrMantenimiento


    Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
    Dim LotesProduccion_Lineas As New E_LotesProduccion_Lineas(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
    Dim Agriculores As New E_Agricultores(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim PventaUsuario As New E_PventaUsuario(Idusuario, cn)


    Dim _IdPartida As Integer
    Dim _IdLotePartidas As Integer
    Dim _CampaBloqueada As Boolean = False
    Dim _CampaActualBloqueada As Boolean = False

    Dim _IdProgramaCalidad As Integer = 0
    Dim _dtLineas As DataTable = Nothing



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()

        BTaux1.Visible = True
        BTaux1.Text = "Imprimir"
        BTaux1.Image = PictureBox1.Image

        BtAux2.Visible = True
        BtAux2.Text = "I.Directa"
        BtAux2.Image = PictureBox2.Image


    End Sub


    Public Sub New(dtLineas As DataTable)
        Me.New()

        _dtLineas = dtLineas


    End Sub


    Private Sub ParametrosFrm()
        EntidadFrm = LotesProduccion


        Dim lc As New List(Of Object)
        ListaControles = lc



        ParamTx(TxNumero, LotesProduccion.LPD_Lote, LbNumero, True)
        TxNumero.Autonumerico = True
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxFechaLote, LotesProduccion.LPD_Fecha, LbFechaLote, True)
        ParamTx(TxCalidad, LotesProduccion.LPD_Calidad, LbCalidad, , , , , "ABCDE")
        'ParamTx(TxControlado, LotesProduccion.LPD_Controlado, LbControlado, , , , , "SN")
        ParamTx(TxProductoLote, LotesProduccion.LPD_Idgenero, LbProductoLote, True)
        ParamTx(TxColor, LotesProduccion.LPD_Color, LbColor, True, , , , "NPS")
        ParamTx(TxEnvase, LotesProduccion.LPD_IdEnvase, LbEnvase)
        ParamTx(TxKxB, LotesProduccion.LPD_KilosxBulto, LbKxB)
        ParamTx(TxCategoria, LotesProduccion.LPD_IdCategoria, LbCategoria)
        ParamTx(TxGP, LotesProduccion.LPD_GP, LbGP, , , , , "GP")



        'Líneas
        ParamTx(TxCampaPartida, Nothing, LbPartida)
        ParamTx(TxPartida, Nothing, LbPartida)
        ParamTx(TxCampaLote, Nothing, LbPartida)
        ParamTx(TxLotePartidas, Nothing, LbLote)
        ParamTx(TxBultos, LotesProduccion_Lineas.LPL_Bultos, LbBultos, True)
        ParamTx(TxKilos, LotesProduccion_Lineas.LPL_Kilos, LbKilos, False)



        AsociarGrid(ClGrid1, TxCampaPartida, TxKilos, LotesProduccion_Lineas)

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        PropiedadesCamposGr(ClGrid1, "LPL_Idlinea", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "PartidaLote", "PartidaLote", True, 10)
        PropiedadesCamposGr(ClGrid1, "Genero", "Genero", True, 50)
        PropiedadesCamposGr(ClGrid1, "Lote", "Lote", True, 10)
        PropiedadesCamposGr(ClGrid1, "Bultos", "Bultos", True, 10, False)
        PropiedadesCamposGr(ClGrid1, "Kilos", "Kilos", True, 10, True)


        AsociarControles(TxNumero, BtBuscaLote, LotesProduccion.btBusca, EntidadFrm)
        AsociarControles(TxProductoLote, BtBuscaProducto, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomProductoLote)
        AsociarControles(TxEnvase, BtBuscaEnvase, Envases.btBusca, Envases, Envases.ENV_Nombre, LbNomEnvase)
        AsociarControles(TxCategoria, BtBuscaCat, CategoriasSalida.BtBuscaFamilias, CategoriasSalida, CategoriasSalida.CAS_CategoriaCalibre, LbNomCategoria)


        tt.SetToolTip(BtNuevo, "Nuevo")

        BtBuscaLote.CL_Filtro = pventausuario.FiltroPventaGrid("PV", "")
        BtBuscaLote.CL_xCentro = False


    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        Dim i As Integer


        If TxNumero.Text = "+" Then
            LbId.Text = "+"
        Else
            i = LotesProduccion.LeerLote(CInt(LbCampa.Text), CInt(TxNumero.Text))
            If i > 0 Then
                LbId.Text = i.ToString
            Else
                LbId.Text = "+" 'AlbEntrada.MaxId
            End If

        End If
        CargaLineasGrid()

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)


        TxPartida.Text = ""
        TxLotePartidas.Text = ""
        TxKilos.Text = ""
        TxBultos.Text = ""

        LbProducto.Text = ""
        LbAgricultor.Text = ""
        LbAlbaran.Text = ""
        LbFecha.Text = ""
        LbBultosEntrada.Text = ""
        LbKilosEntrada.Text = ""




        MyBase.Entidad_a_DatosLin(Grid)


        _IdPartida = VaInt(LotesProduccion_Lineas.LPL_IdlineaEntrada.Valor)
        If _IdPartida > 0 Then
            If Albentrada_lineas.LeerId(_IdPartida) = True Then

                Dim campa As String = ""
                Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
                If AlbEntrada.LeerId(Albentrada_lineas.AEL_idalbaran.Valor) Then
                    campa = AlbEntrada.AEN_Campa.Valor
                End If
                TxCampaPartida.Text = campa

                TxPartida.Text = Albentrada_lineas.AEL_muestreo.Valor
                DatosPartida(_IdPartida) 'ida(_idpartida)

            End If

            'Rellena el listview
            ListaNormas.Items.Clear()
            Dim LNormas As List(Of String) = ObtenerNormasCalidad(_IdPartida, "P")

            If Not IsNothing(LNormas) Then
                For cont = 0 To LNormas.Count - 1
                    ListaNormas.Items.Add(LNormas(cont))
                Next
            End If


            TxCampaPartida.Bloqueado = True
            TxPartida.Bloqueado = True

        End If

        _IdLotePartidas = VaInt(LotesProduccion_Lineas.LPL_IdLotePartida.Valor)
        If _IdLotePartidas > 0 Then

            Dim Lote As New E_Lotes(Idusuario, cn)
            If Lote.LeerId(_IdLotePartidas) Then
                TxCampaLote.Text = Lote.LTE_Campa.Valor
                TxLotePartidas.Text = Lote.LTE_Lote.Valor
                DatosLote(_IdLotePartidas)

                'Rellena el listview
                ListaNormas.Items.Clear()
                Dim LNormas As List(Of String) = ObtenerNormasCalidad(_IdLotePartidas, "L")

                If Not IsNothing(LNormas) Then
                    For cont = 0 To LNormas.Count - 1
                        ListaNormas.Items.Add(LNormas(cont))
                    Next
                End If

            End If

            TxCampaLote.Bloqueado = True
            TxLotePartidas.Bloqueado = True

        End If


    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

        LbCampa.Text = LotesProduccion.LPD_Campa.Valor
        TxCampaPartida.Text = LbCampa.Text
        TxCampaLote.Text = LbCampa.Text
        LbControladoSN.Text = (LotesProduccion.LPD_Controlado.Valor & "").Trim
        LbProgramaCalidad.Text = ""

        Dim ValoresEjercicio As New E_ValoresEjercicio(Idusuario, cn)
        If ValoresEjercicio.LeerId(LbCampa.Text) Then
            If ValoresEjercicio.VEJ_Bloqueada.Valor = "S" Then
                _CampaBloqueada = True
            End If
        End If


        ' llenar el grid
        CargaLineasGrid()


        Dim ProgramaCalidadTecnicos As New E_ProgramaCalidadTecnicos(Idusuario, cn)
        If ProgramaCalidadTecnicos.LeerId(LotesProduccion.LPD_IdProgramaCalidad.Valor) Then
            LbProgramaCalidad.Text = ProgramaCalidadTecnicos.PCT_Nombre.Valor
        End If




        '_IdProgramaCalidad = VaInt(LotesProduccion.LPD_IdProgramaCalidad.Valor)

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean


        If TxPartida.Text.Trim = "" And TxLotePartidas.Text.Trim = "" Then
            MsgBox("Debe introducir una partida o un lote")
            TxPartida.MiError = True
        Else
            TxPartida.MiError = False
        End If


        If LbId.Text = "+" Then
            LbId.Text = LotesProduccion.MaxId
            If TxNumero.Text = "+" Then
                TxNumero.Text = LotesProduccion.MaxIdCampa(Val(LbCampa.Text))
            End If
        End If

        LotesProduccion.LPD_Idlote.Valor = LbId.Text
        LotesProduccion.LPD_Campa.Valor = LbCampa.Text
        LotesProduccion_Lineas.LPL_Idlote.Valor = LbId.Text
        LotesProduccion_Lineas.LPL_IdlineaEntrada.Valor = _IdPartida.ToString
        LotesProduccion_Lineas.LPL_IdLotePartida.Valor = _IdLotePartidas.ToString
        LotesProduccion_Lineas.LPL_IdProgramaCliente.Valor = MiMaletin.idprogramacliente.ToString


        Dim IdPartida As Integer = _IdPartida
        Dim IdLote As Integer = _IdLotePartidas


        SqlGrid()

        r = MyBase.GuardarLineas(Gr)


        If VaDec(IdPartida) > 0 Then

            Dim Calidad As String = ""

            Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
            If AlbEntrada_Lineas.LeerId(IdPartida) Then

                Calidad = (AlbEntrada_Lineas.AEL_Calidad.Valor & "").Trim

                If (LotesProduccion.LPD_Controlado.Valor & "").Trim = "S" Then
                    If (AlbEntrada_Lineas.AEL_Controlado.Valor & "").Trim = "N" Then
                        LotesProduccion.LPD_Controlado.Valor = "N"
                        LbControladoSN.Text = "N"
                    End If
                End If

            End If


            Dim frm As New FrmColorEtiqueta(Calidad)
            frm.ShowDialog()

        ElseIf VaDec(IdLote) > 0 Then

            Dim Calidad As String = ""

            Dim Lotes As New E_Lotes(Idusuario, cn)
            If Lotes.LeerId(IdLote) Then

                Calidad = (Lotes.LTE_Calidad.Valor & "").Trim

                If (LotesProduccion.LPD_Controlado.Valor & "").Trim = "S" Then
                    If (Lotes.LTE_Controlado.Valor & "").Trim = "N" Then
                        LotesProduccion.LPD_Controlado.Valor = "N"
                        LbControladoSN.Text = "N"
                    End If
                End If

            End If

            Dim frm As New FrmColorEtiqueta(Calidad)
            frm.ShowDialog()

        End If




        Return r

    End Function


    Public Overrides Sub DespuesdeGuardarLinea(gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)

        
    End Sub


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()

        'If _IdProgramaCalidad <> 3 Then
        '    If VaInt(LbId.Text) > 0 Then
        '        If LotesProduccion.LeerId(LbId.Text) Then
        '            LotesProduccion.LPD_Controlado.Valor = "S"
        '            LotesProduccion.Actualizar()
        '        End If
        '    End If
        'End If


        If NuevoRegistro Then
            'C1_ImprimirPaletSemiterminado(LbId.Text, TipoImpresion.ImpresoraPorDefecto)
            C1_ImprimirPaletSemiterminado(LbId.Text, TipoImpresion.ImpresoraSeleccionada)
        Else
            If XtraMessageBox.Show("¿Desea imprimir el palet semiterminado?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'C1_ImprimirPaletSemiterminado(LbId.Text, TipoImpresion.ImpresoraPorDefecto)
                C1_ImprimirPaletSemiterminado(LbId.Text, TipoImpresion.ImpresoraSeleccionada)
            End If
        End If


    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)

        _IdPartida = 0
        _IdLotePartidas = 0

        TxCampaPartida.Text = LbCampa.Text
        TxCampaLote.Text = LbCampa.Text

        TxCampaPartida.Bloqueado = False
        TxPartida.Bloqueado = False
        TxCampaLote.Bloqueado = False
        TxLotePartidas.Bloqueado = False


        TxPartida.Text = ""
        TxLotePartidas.Text = ""
        TxBultos.Text = ""
        TxKilos.Text = ""


        LbProducto.Text = ""
        LbAgricultor.Text = ""
        LbAlbaran.Text = ""
        LbFecha.Text = ""
        LbBultosEntrada.Text = ""
        LbKilosEntrada.Text = ""

        ListaNormas.Items.Clear()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbCampa.Text = MiMaletin.Ejercicio.ToString
        _CampaBloqueada = _CampaActualBloqueada

        LbProgramaCalidad.Text = ""
        ListaNormas.Items.Clear()
        LbControladoSN.Text = ""

        BtBuscaCat.CL_Filtro = ""

    End Sub


    Private Sub CargaLineasGrid()
        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)
    End Sub


    Private Sub SqlGrid()
        Dim id As String

        If LbId.Text = "+" Then
            id = "-1"
        Else
            id = LbId.Text
        End If

        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim sql As String = "SELECT LPL_Idlinea, AEL_Muestreo as PartidaLote, GEN_NombreGenero as Genero, AEN_Albaran as Albaran," & vbCrLf
        sql = sql & " AGR_Nombre as Agricultor, LPL_Bultos as Bultos, LPL_Kilos as Kilos" & vbCrLf
        sql = sql & " FROM LotesProduccion_Lineas" & vbCrLf
        sql = sql & " INNER JOIN AlbEntrada_Lineas ON LPL_IdLineaEntrada = AEL_IdLinea" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = AEL_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN Agricultores ON AEN_IdAgricultor = AGR_IdAgricultor" & vbCrLf
        sql = sql & " WHERE LPL_IdLote = " & id & vbCrLf
        sql = sql & " AND LPL_IdProgramaCliente = " & MiMaletin.idprogramacliente.ToString & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT LPL_Idlinea, LTE_Lote as PartidaLote, GEN_NombreGenero as Genero, '' as Albaran, '' as Agricultor," & vbCrLf
        sql = sql & " LPL_Bultos as Bultos, LPL_Kilos as Kilos" & vbCrLf
        sql = sql & " FROM LotesProduccion_Lineas" & vbCrLf
        sql = sql & " INNER JOIN Lotes ON LTE_IdLote = LPL_IdLotePartida" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = LTE_IdGenero" & vbCrLf
        sql = sql & " WHERE LPL_IdLote = " & id & vbCrLf
        sql = sql & " AND LPL_IdProgramaCliente = " & MiMaletin.idprogramacliente.ToString & vbCrLf
        sql = sql & " ORDER BY LPL_IdLinea" & vbCrLf


        ClGrid1.Consulta = sql

    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MyBase.BAnular_Click(sender, e)
    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MyBase.BModificar_Click(sender, e)
    End Sub


    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNuevo.Click
        If TxNumero.Text = "" And TxNumero.Enabled = True Then
            TxNumero.Text = "+"
            Siguiente(0)
        End If
    End Sub


    Public Overrides Sub Guardar()


        'Actualiza la ubicacion actual
        If NuevoRegistro Then
            LotesProduccion.LPD_IdUbicacionPV.Valor = MiMaletin.IdPuntoVenta.ToString
        End If


        'Actualizamos FechaProducto
        Dim sql As String = "SELECT AEN_Fecha as Fecha " & vbCrLf
        sql = sql & " FROM LotesProduccion_Lineas" & vbCrLf
        sql = sql & " INNER JOIN AlbEntrada_Lineas ON LPL_IdLineaEntrada = AEL_IdLinea " & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " WHERE LPL_IdLote = " & LbId.Text & vbCrLf
        sql = sql & " UNION ALL " & vbCrLf
        sql = sql & " SELECT LTE_Fecha as Fecha" & vbCrLf
        sql = sql & " FROM LotesProduccion_Lineas" & vbCrLf
        sql = sql & " INNER JOIN Lotes ON LTE_IdLote = LPL_IdLotePartida" & vbCrLf
        sql = sql & " WHERE LPL_IdLote = " & LbId.Text & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT AEN_Fecha as Fecha " & vbCrLf
        sql = sql & " FROM Lotes_Lineas" & vbCrLf
        sql = sql & " INNER JOIN AlbEntrada_Lineas ON LTL_IdLineaEntrada = AEL_IdLinea " & vbCrLf
        sql = sql & " INNER JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " INNER JOIN LotesProduccion_Lineas ON LPL_IdLotePartida = LTL_IdLote" & vbCrLf
        sql = sql & " WHERE LPL_IdLote = " & LbId.Text & vbCrLf
        sql = sql & " ORDER BY Fecha" & vbCrLf


        Dim dt As DataTable = Albentrada_lineas.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)

                Dim FechaProducto As String = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
                LotesProduccion.LPD_FechaProducto.Valor = FechaProducto

            End If
        End If


        LotesProduccion.LPD_IdProgramaCalidad.Valor = _IdProgramaCalidad
        LotesProduccion.LPD_Controlado.Valor = LbControladoSN.Text


        MyBase.Guardar()

    End Sub


    Private Sub FrmPedidosMaterial_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BTaux1.Visible = True
        BTaux1.Text = "Imprimir"
        BTaux1.Image = PictureBox1.Image

        BtAux2.Visible = True
        BtAux2.Text = "I.Directa"
        BtAux2.Image = PictureBox2.Image

        Dim ValoresEjercicio As New E_ValoresEjercicio(Idusuario, cn)
        If ValoresEjercicio.LeerId(MiMaletin.Ejercicio.ToString) Then
            If ValoresEjercicio.VEJ_Bloqueada.Valor = "S" Then
                _CampaActualBloqueada = True
            End If
        End If


        Dim bDatos As Boolean = Not IsNothing(_dtLineas)
        If Not IsNothing(_dtLineas) Then
            If _dtLineas.Rows.Count > 0 Then
                bDatos = True
            Else
                bDatos = False
            End If
        End If



        If bDatos Then

            ClGrid1.Size = New Size(300, 229)
            ClGrid1.Location = New Point(537, 129)
            GridLineas.Visible = True
            LbPartidasEnProduccion.Visible = True


            GridLineas.DataSource = _dtLineas
            AjustaColumnasGridLineas()

        Else

            ClGrid1.Size = New Size(837, 229)
            ClGrid1.Location = New Point(0, 129)
            GridLineas.Visible = False
            LbPartidasEnProduccion.Visible = False
        End If


    End Sub


    Private Sub AjustaColumnasGridLineas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewLineas.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "ID", "KILOS", "KILOSCONSUMIDOS", "KGXHORA", "CATEGORIA", "PCALIB", "TIEMPO"
                    c.Visible = False
            End Select
        Next

        GridViewLineas.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewLineas.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "NUMERO"
                    c.Caption = "Par/Lote"
                Case "TIPO"
                    c.MinWidth = 30
                    c.MaxWidth = 30
                Case "KILOSLINEA"
                    c.MinWidth = 80
                    c.MaxWidth = 80
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                Case "INICIO", "FINAL"
                    c.MinWidth = 65
                    c.MaxWidth = 65

            End Select
        Next

    End Sub


    Private Sub TxPartida_Valida(edicion As Boolean) Handles TxPartida.Valida


        If edicion Then

            Dim bBorradatos As Boolean = False

            If VaInt(TxPartida.Text) > 0 Then
                'Hay partida, quita lote: Borra datos y carga abajo los de la partida
                bBorradatos = True
            ElseIf VaInt(TxLotePartidas.Text) = 0 Then
                'No hay lote ni partida: Borra datos
                bBorradatos = True
            End If


            If bBorradatos Then

                _IdPartida = 0
                _IdLotePartidas = 0

                TxLotePartidas.Text = ""
                TxBultos.Text = ""
                TxKilos.Text = ""
                LbProducto.Text = ""
                LbAgricultor.Text = ""
                LbAlbaran.Text = ""
                LbBultosEntrada.Text = ""
                LbFecha.Text = ""
                LbKilosEntrada.Text = ""

            End If

        End If




        If VaInt(TxPartida.Text) > 0 Then


            Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
            'Dim Id As Integer = AlbEntrada_Lineas.LeerMuestreo(LbCampa.Text, TxPartida.Text)
            Dim Id As Integer = AlbEntrada_Lineas.LeerMuestreo(TxCampaPartida.Text, TxPartida.Text)
            AlbEntrada_Lineas.LeerId(Id)


            If Id = 0 Then
                MsgBox("partida inexistente")
                TxPartida.MiError = True
            ElseIf Not CompruebaGeneroTrazabilidadPartida(TxProductoLote.Text, AlbEntrada_Lineas) Then
                MsgBox("El género de la partida no coincide con el género del lote.")
                TxPartida.MiError = True
                'ElseIf LbControladoSN.Text = "S" And AlbEntrada_Lineas.AEL_Controlado.Valor <> "S" Then
                '    MsgBox("Producto no controlado")
                '    TxPartida.MiError = True
            ElseIf TxCalidad.Text < (AlbEntrada_Lineas.AEL_Calidad.Valor & "").Trim Then
                If XtraMessageBox.Show("ATENCIÓN: La partida " & TxPartida.Text & " tiene calidad inferior al precalibrado. Si la introduce, la calidad del precalibrado será cambiada a la calidad de la partida. ¿Desea introducir la partida?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
                    'No continúa
                    TxPartida.MiError = True
                Else
                    LotesProduccion.LPD_Calidad.Valor = (AlbEntrada_Lineas.AEL_Calidad.Valor & "").Trim
                    TxCalidad.Text = (AlbEntrada_Lineas.AEL_Calidad.Valor & "").Trim
                    _IdPartida = Id
                    DatosPartida(Id)
                End If

                'ElseIf EntradaDirecta(LbCampa.Text, Id) Then
            ElseIf EntradaDirecta(TxCampaPartida.Text, Id) Then

                'Comprueba que la partida no provenga de una entrada directa
                MsgBox("La partida proviene de una entrada directa")
                TxPartida.MiError = True
                Exit Sub

            Else
                _IdPartida = Id
                DatosPartida(Id)
            End If
        End If


    End Sub


    Private Function EntradaDirecta(Ejercicio As String, IdLineaEntrada As String) As Boolean

        Dim bRes As Boolean = False

        If VaInt(IdLineaEntrada) > 0 Then

            Dim sql As String = "SELECT AEN_EntradaConfeccionada as Directa FROM AlbEntrada_Lineas LEFT JOIN AlbEntrada ON AEN_IdAlbaran = AEL_IdAlbaran WHERE AEL_IdLinea = " & IdLineaEntrada
            Dim dt As DataTable = AlbEntrada_lineas.MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim row As DataRow = dt.Rows(0)
                    Dim directa As String = (row("Directa").ToString & "").Trim

                    bRes = (directa = "S")

                End If
            End If


        End If


        Return bRes

    End Function



    Private Sub TxLotePartidas_Valida(edicion As System.Boolean) Handles TxLotePartidas.Valida

        If edicion Then


            Dim bBorradatos As Boolean = False

            If VaInt(TxLotePartidas.Text) > 0 Then
                'Hay lote, quita partida: Borra datos y carga abajo los del lote
                bBorradatos = True
            ElseIf VaInt(TxPartida.Text) = 0 Then
                'No hay lote ni partida: Borra datos
                bBorradatos = True
            End If


            If bBorradatos Then

                _IdPartida = 0
                _IdLotePartidas = 0

                TxPartida.Text = ""
                TxBultos.Text = ""
                TxKilos.Text = ""
                LbProducto.Text = ""
                LbAgricultor.Text = ""
                LbAlbaran.Text = ""
                LbBultosEntrada.Text = ""
                LbFecha.Text = ""
                LbKilosEntrada.Text = ""

            End If


        End If




        If VaInt(TxLotePartidas.Text) > 0 Then

            Dim Lotes As New E_Lotes(Idusuario, cn)
            'Dim Id As Integer = Lotes.LeerLote(LbCampa.Text, TxLotePartidas.Text)
            Dim Id As Integer = Lotes.LeerLote(TxCampaLote.Text, TxLotePartidas.Text)

            If Id = 0 Then
                MsgBox("Lote inexistente")
                TxLotePartidas.MiError = True
            ElseIf Not CompruebaGeneroTrazabilidadLote(TxProductoLote.Text, Lotes) Then
                MsgBox("El género del lote de entrada no coincide con el género del precalibrado. (Cultivos)")
                TxLotePartidas.MiError = True
                'ElseIf LbControladoSN.Text = "S" And Lotes.LTE_Controlado.Valor <> "S" Then
                '    MsgBox("Producto no controlado")
                '    TxLotePartidas.MiError = True
            ElseIf TxCalidad.Text < (Lotes.LTE_Calidad.Valor & "").Trim Then
                If XtraMessageBox.Show("ATENCIÓN: El lote " & TxLotePartidas.Text & " tiene calidad inferior al precalibrado. Si lo introduce, la calidad del precalibrado será cambiada a la calidad del lote. ¿Desea introducir el lote?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
                    'No continúa
                    TxLotePartidas.MiError = True
                Else
                    LotesProduccion.LPD_Calidad.Valor = (Lotes.LTE_Calidad.Valor & "").Trim
                    TxCalidad.Text = (Lotes.LTE_Calidad.Valor & "").Trim
                    _IdLotePartidas = Id
                    DatosLote(Id)
                End If
            Else
                _IdLotePartidas = Id
                DatosLote(Id)
            End If

        End If


    End Sub


    Private Sub DatosPartida(idlineaentrada As Integer)

        Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
        Dim Agricultores As New E_Agricultores(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Albentrada_lineas.AEL_bultos, "bultos")
        consulta.SelCampo(Albentrada_lineas.AEL_kilosnetos, "kilos")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albentrada_lineas.AEL_idgenero)
        consulta.SelCampo(Albentrada.AEN_Albaran, "Albaran", Albentrada_lineas.AEL_idalbaran)
        consulta.SelCampo(Albentrada.AEN_Fecha, "Fecha")
        consulta.SelCampo(Agricultores.AGR_Nombre, "Agricultor", Albentrada.AEN_IdAgricultor)
        consulta.WheCampo(Albentrada_lineas.AEL_idlinea, "=", idlineaentrada.ToString)
        Dim sql As String = consulta.SQL
        Dim dt As DataTable = Albentrada.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                LbProducto.Text = dt.Rows(0)("Genero").ToString
                LbAgricultor.Text = dt.Rows(0)("Agricultor").ToString
                LbAlbaran.Text = dt.Rows(0)("Albaran").ToString
                LbFecha.Text = Format(dt.Rows(0)("Fecha"), "dd/MM/yyyy")
                LbBultosEntrada.Text = dt.Rows(0)("Bultos").ToString
                LbKilosEntrada.Text = dt.Rows(0)("Kilos").ToString
            End If
        End If


    End Sub


    Private Sub DatosLote(IdLotePartida As Integer)

        Dim Lotes As New E_Lotes(Idusuario, cn)

        LbAgricultor.Text = ""

        Dim sql As String = "SELECT" & vbCrLf
        sql = sql & " (SELECT SUM(LTL_Bultos) FROM Lotes_Lineas WHERE LTL_IdLote = LTE_IdLote) as Bultos," & vbCrLf
        sql = sql & " (SELECT SUM(LTL_Kilos) FROM Lotes_Lineas WHERE LTL_IdLote = LTE_IdLote) as Kilos," & vbCrLf
        sql = sql & " GEN_NombreGenero as Genero, LTE_Fecha as Fecha" & vbCrLf
        sql = sql & " FROM Lotes" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = LTE_IdGenero" & vbCrLf
        sql = sql & " WHERE LTE_IdLote = " & IdLotePartida & vbCrLf

        Dim dt As DataTable = Lotes.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                LbProducto.Text = row("Genero").ToString
                LbFecha.Text = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
                LbBultosEntrada.Text = row("Bultos").ToString
                LbKilosEntrada.Text = row("Kilos").ToString
            End If
        End If


    End Sub


    Private Sub TxBultos_Valida(edicion As Boolean) Handles TxBultos.Valida
        If edicion = True Then
            If TxKilos.Text = "" Then
                TxKilos.Text = FnVaStr(Int(VaDec(TxBultos.Text) * VaDec(TxKxB.Text)))
            End If
        End If
    End Sub


    Private Sub TxCalidad_Valida(edicion As System.Boolean) Handles TxCalidad.Valida

        If edicion Then
            If TxCalidad.Text.Trim = "" Then
                TxCalidad.Text = "B"
            End If
        End If

    End Sub


    Private Sub TxProductoLote_Valida(edicion As System.Boolean) Handles TxProductoLote.Valida

        If edicion Then

            BtBuscaCat.CL_Filtro = ""

            If Not TxProductoLote.MiError Then

                Dim Generos As New E_Generos(Idusuario, cn)
                If Generos.LeerId(TxProductoLote.Text) Then

                    Dim IdFamilia As String = (Generos.idfamiliagenero() & "").trim
                    If VaInt(IdFamilia) > 0 Then
                        BtBuscaCat.CL_Filtro = "IdFamilia = " & IdFamilia
                    End If

                End If

            End If
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirPaletSemiterminado(LbId.Text, TipoImpresion.Preliminar)
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaInt(LbId.Text) > 0 Then
            'C1_ImprimirPaletSemiterminado(LbId.Text, TipoImpresion.ImpresoraPorDefecto)
            C1_ImprimirPaletSemiterminado(LbId.Text, TipoImpresion.ImpresoraSeleccionada)
        End If

    End Sub


    'Private Sub TxControlado_Valida(edicion As System.Boolean)
    '    If edicion Then
    '        If TxControlado.Text = "" Then TxControlado.Text = "N"
    '    End If
    'End Sub


    
    Private Sub GridViewLineas_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridViewLineas.RowCellClick

        Dim linea As DataRow = GridViewLineas.GetFocusedDataRow()
        If Not IsNothing(linea) Then

            Dim indice As Integer = ClGrid1.GridView.RowCount - 1

            If TxPartida.Enabled And Modificando And ClGrid1.GridView.FocusedRowHandle = indice Then

                If indice >= 0 Then

                    Dim row As DataRow = ClGrid1.GridView.GetDataRow(indice)
                    ClGrid1.Subirlinea(indice)


                    Dim tipo As String = (linea("Tipo").ToString & "").ToUpper.Trim
                    Dim numero As String = (linea("Numero").ToString & "").Trim

                    Select Case tipo

                        Case "P"
                            TxPartida.Text = numero
                            TxPartida.Validar(True)
                            TxBultos.Select()

                        Case "L"
                            TxLotePartidas.Text = numero
                            TxLotePartidas.Validar(True)
                            TxBultos.Select()

                    End Select


                End If


            End If

        End If


        

    End Sub


    Private Sub TxPartida_AntesDeValidar(edicion As System.Boolean) Handles TxPartida.AntesDeValidar

        If edicion Then

            Dim datos As String() = Split(TxPartida.Text, ".")
            If datos.Length = 2 Then


                Dim campa As String = datos(0)
                Dim numero As String = datos(1)

                If campa.StartsWith("PA") Then
                    campa = campa.Replace("PA", "")
                End If


                If VaInt(campa) <> VaInt(LbCampa.Text) And _CampaBloqueada Then
                    MsgBox("Ejercicio no válido, sólo se permiten partidas de la campaña actual")
                    TxCampaPartida.Text = ""
                    TxPartida.Text = ""
                    Exit Sub
                End If

                TxPartida.Text = numero
                TxCampaPartida.Text = campa

            End If

        End If

    End Sub


    Private Sub TxColor_AntesDeValidar(edicion As System.Boolean) Handles TxColor.AntesDeValidar

        If edicion Then
            If TxColor.Text.Trim = "" Then TxColor.Text = "N"
        End If

    End Sub


    Private Sub TxKilos_Valida(edicion As System.Boolean) Handles TxKilos.Valida

        If edicion Then
            If VaDec(TxKilos.Text) <= 0 Then
                TxKilos.MiError = True
                MsgBox("Los kilos deben ser superiores a cero")
            End If
        End If

    End Sub


    Private Function CalculaProgramaCalidadLoteProduccion(ByRef programa As String, ByRef bControlado As Boolean) As Integer

        'Por defecto usamos el 3, que es no controlado
        Dim res As Integer = 3
        programa = ""
        bControlado = False


        If VaDec(LbId.Text) > 0 Then


            Dim lst As New List(Of Integer)
            Dim DcLineas As New Dictionary(Of Integer, List(Of Integer))



            'Los programas de calidad y las normas, están duplicadas en NetAgro y TecnicosNet, pero las relaciones están sólo en TécnicosNet
            Dim sql As String = "SELECT AEL_IdLinea as IdLinea, CAN_IdNorma as IdNorma" & vbCrLf
            sql = sql & " FROM Albentrada_lineas" & vbCrLf
            sql = sql & " LEFT JOIN LotesProduccion_lineas ON LPL_IdlineaEntrada = AEL_IdLinea" & vbCrLf
            sql = sql & " LEFT JOIN TecnicosNet.dbo.ProgramasCalidad ON PCL_IdPrograma = AEL_IdPrograma" & vbCrLf
            sql = sql & " INNER JOIN TecnicosNet.dbo.CalidadNorma ON PCL_IdPrograma = CAN_IdPrograma" & vbCrLf
            sql = sql & " INNER JOIN TecnicosNet.dbo.NormasCalidad ON CAN_IdNorma = NCL_IdNorma" & vbCrLf
            sql = sql & " WHERE LPL_Idlote = " & LbId.Text & vbCrLf
            sql = sql & " AND LPL_IdlineaEntrada > 0" & vbCrLf



            Dim sql1 As String = "SELECT AEL_IdLinea as IdLinea, CAN_IdNorma as IdNorma" & vbCrLf
            sql1 = sql1 & " FROM Albentrada_lineas" & vbCrLf
            sql1 = sql1 & " LEFT JOIN Lotes_lineas ON LTL_Idlineaentrada = AEL_IdLinea" & vbCrLf
            sql1 = sql1 & " LEFT JOIN LotesProduccion_lineas ON LPL_IdLotePartida = LTL_Idlote" & vbCrLf
            sql1 = sql1 & " LEFT JOIN TecnicosNet.dbo.ProgramasCalidad ON PCL_IdPrograma = AEL_IdPrograma" & vbCrLf
            sql1 = sql1 & " INNER JOIN TecnicosNet.dbo.CalidadNorma ON PCL_IdPrograma = CAN_IdPrograma" & vbCrLf
            sql1 = sql1 & " INNER JOIN TecnicosNet.dbo.NormasCalidad ON CAN_IdNorma = NCL_IdNorma" & vbCrLf
            sql1 = sql1 & " WHERE LPL_Idlote = " & LbId.Text & vbCrLf
            sql1 = sql1 & " AND LPL_IdLotePartida > 0" & vbCrLf



            Dim sqlFinal As String = sql & " UNION ALL " & sql1
            sqlFinal = sqlFinal & " ORDER BY IdLinea, IdNorma"


            Dim dt As DataTable = Albentrada_lineas.MiConexion.ConsultaSQL(sqlFinal)
            If Not IsNothing(dt) Then

                'Obtengo todas las normas de las partidas
                For Each row As DataRow In dt.Rows

                    Dim IdLinea As Integer = VaInt(row("IdLinea"))
                    Dim IdNorma As Integer = VaInt(row("IdNorma"))

                    'DcLineas guarda las normas por línea
                    If Not DcLineas.ContainsKey(IdLinea) Then
                        DcLineas(IdLinea) = New List(Of Integer)
                    End If
                    DcLineas(IdLinea).Add(IdNorma)


                    'lst guarda todas las normas de todas las partidas para ir restando posteriormente
                    If Not lst.Contains(VaInt(IdNorma)) Then
                        lst.Add(VaInt(IdNorma))
                    End If

                Next


                'Ordenamos la lista
                lst.Sort()
                Dim Normas As Integer() = lst.ToArray()


                'Nos quedamos sólo con la intersección de todas las normas
                For Each IdLinea As Integer In DcLineas.Keys
                    Dim normas_linea As List(Of Integer) = DcLineas(IdLinea)
                    Normas = Normas.Intersect(normas_linea.ToArray()).ToArray()
                Next


                If Normas.Length > 0 Then

                    sql = ""

                    For Each norma As Integer In Normas
                        If sql.Trim <> "" Then sql = sql & " INTERSECT " & vbCrLf
                        sql = sql & " SELECT CAN.CAN_IdPrograma as IdPrograma, PCL_Nombre as Programa, PCL_ControladoSN as Controlado FROM TecnicosNet.dbo.CalidadNorma CAN LEFT JOIN TecnicosNet.dbo.ProgramasCalidad ON PCL_IdPrograma = CAN_IdPrograma WHERE CAN.CAN_IdNorma = " & norma.ToString
                        sql = sql & " AND (SELECT Count(CAN_IdPrograma) FROM TecnicosNet.dbo.CalidadNorma CAN2 WHERE CAN2.CAN_IdPrograma = CAN.CAN_IdPrograma) = " & Normas.Length.ToString
                    Next

                    Dim dt2 As DataTable = Albentrada.MiConexion.ConsultaSQL(sql)
                    If Not IsNothing(dt2) Then
                        If dt2.Rows.Count > 0 Then
                            res = VaInt(dt2.Rows(0)("IdPrograma"))
                            programa = (dt2.Rows(0)("Programa").ToString & "").Trim
                            bControlado = ((dt2.Rows(0)("Controlado").ToString & "").Trim = "S")
                        End If
                    End If



                End If


            End If


        End If


        If programa.Trim = "" Then
            Dim ProgramaCalidadTecnicos As New E_ProgramaCalidadTecnicos(Idusuario, cn)
            If ProgramaCalidadTecnicos.LeerId(res.ToString) Then
                programa = (ProgramaCalidadTecnicos.PCT_Nombre.Valor & "").Trim
            End If
        End If


        Return res

    End Function


    Public Overrides Sub DespuesdeCargarLineas(ByVal gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)


        Dim programa As String = ""
        Dim bControlado As Boolean = False

        _IdProgramaCalidad = CalculaProgramaCalidadLoteProduccion(programa, bControlado)

        'If _IdProgramaCalidad = E_ProgramaCalidadTecnicos.ProgramasCalidad.NoControlado Or
        '    _IdProgramaCalidad = E_ProgramaCalidadTecnicos.ProgramasCalidad.NoControladoLimpio Then
        If Not bControlado Then
            LbProgramaCalidad.ForeColor = Color.Red
            LbControladoSN.Text = "N"
        Else
            LbProgramaCalidad.ForeColor = Color.Blue
            LbControladoSN.Text = "S"
        End If

        LbProgramaCalidad.Text = programa


    End Sub


    Private Sub TxCampaPartida_Valida(edicion As System.Boolean) Handles TxCampaPartida.Valida

        If edicion Then

            TxCampaPartida.MiError = False

            Dim Ejercicios As New E_Ejercicios(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
            If Not Ejercicios.LeerId(TxCampaPartida.Text) Then
                MsgBox("La campaña especificada no existe")
                TxCampaPartida.MiError = True
            End If

            'Si la campaña del precalibrado está bloqueada, sólo se puede introducir la campaña del precalibrado (en caso de nueva línea)
            If Not TxCampaPartida.MiError And _CampaBloqueada And Not TxCampaPartida.Bloqueado Then
                If VaInt(TxCampaPartida.Text) <> VaInt(LbCampa.Text) Then
                    MsgBox("Ejercicio no válido, sólo se permiten partidas de la campaña actual")
                    TxCampaPartida.MiError = True
                End If
            End If

        End If

    End Sub


    Private Sub TxCampaLote_Valida(edicion As System.Boolean) Handles TxCampaLote.Valida

        If edicion Then

            TxCampaLote.MiError = False

            Dim Ejercicios As New E_Ejercicios(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
            If Not Ejercicios.LeerId(TxCampaLote.Text) Then
                MsgBox("La campaña especificada no existe")
                TxCampaLote.MiError = True
            End If

            'Si la campaña del precalibrado está bloqueada, sólo se puede introducir la campaña del precalibrado (en caso de nueva línea)
            If Not TxCampaLote.MiError And _CampaBloqueada And Not TxCampaLote.Bloqueado Then
                If VaInt(TxCampaLote.Text) <> VaInt(LbCampa.Text) Then
                    MsgBox("Ejercicio no válido, sólo se permiten lotes de la campaña actual")
                    TxCampaLote.MiError = True
                End If
            End If

        End If

    End Sub
End Class
