Imports DevExpress.XtraEditors
Imports System.Linq



Public Class FrmLotesPartida
    Inherits FrMantenimiento



    Dim lotes As New E_Lotes(Idusuario, cn)
    Dim Lotes_lineas As New E_Lotes_lineas(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
    Dim Agriculores As New E_Agricultores(Idusuario, cn)
    Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim pventausuario As New E_PventaUsuario(Idusuario, cn)




    Dim _idpartida As Integer
    Dim _IdProgramaCalidad As Integer = 0
    Dim _CampaBloqueada As Boolean = False
    Dim _CampaActualBloqueada As Boolean = False


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()



    End Sub



    Private Sub ParametrosFrm()
        EntidadFrm = lotes


        Dim lc As New List(Of Object)
        ListaControles = lc



        ParamTx(TxNumero, lotes.LTE_Lote, LbNumero, True)
        TxNumero.Autonumerico = True
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxFechaLote, lotes.LTE_Fecha, LbFechaLote, True)
        ParamTx(TxCalidad, lotes.LTE_Calidad, LbCalidad, , , , , "ABCDE")
        'ParamTx(TxControlado, lotes.LTE_Controlado, LbControlado, , , , , "SN")
        ParamTx(TxProducto, lotes.LTE_Idgenero, LbProductoLote, True)
        ParamTx(TxColor, lotes.LTE_Color, LbColor, True, , , , "NPS")
        ParamTx(TxEnvase, lotes.LTE_IdEnvase, LbEnvase)



        'Líneas
        ParamTx(TxCampaPartida, Nothing, LbPartida, True)
        ParamTx(TxPartida, Nothing, LbPartida, True)
        ParamTx(TxBultos, Lotes_lineas.LTL_Bultos, LbBultos, True, Cdatos.TiposCampo.Entero, 0, 6)
        ParamTx(TxKilos, Lotes_lineas.LTL_Kilos, LbKilos, False)



        AsociarGrid(ClGrid1, TxCampaPartida, TxKilos, Lotes_lineas)

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        PropiedadesCamposGr(ClGrid1, "LTL_Idlinea", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Partida", "Partida", True, 10)
        PropiedadesCamposGr(ClGrid1, "Genero", "Genero", True, 50)
        PropiedadesCamposGr(ClGrid1, "Albaran", "Albaran", True, 10)
        PropiedadesCamposGr(ClGrid1, "Agricultor", "Agricultor", True, 50)
        PropiedadesCamposGr(ClGrid1, "Bultos", "Bultos", True, 10, False)
        PropiedadesCamposGr(ClGrid1, "Kilos", "Kilos", True, 10, True)


        AsociarControles(TxNumero, BtBuscaLote, lotes.btBusca, EntidadFrm)
        AsociarControles(TxProducto, BtBuscaProducto, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomProductoLote)
        AsociarControles(TxEnvase, BtBuscaEnvase, Envases.btBusca, Envases, Envases.ENV_Nombre, LbNomEnvase)


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
            i = lotes.LeerLote(CInt(LbCampa.Text), CInt(TxNumero.Text))
            If i > 0 Then
                LbId.Text = i.ToString

                'If VaInt(AlbEntrada.idpuntoventa.Valor) <> VaInt(LbCentro.Text) Then
                ' MsgBox("No coincide el punto de venta")
                ' LbId.Text = ""
                ' TxDato_1.Text = ""
                ' Exit Sub
                'End If

            Else
                LbId.Text = "+" 'AlbEntrada.MaxId
            End If

        End If
        CargaLineasGrid()

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)


        _idpartida = Lotes_lineas.LTL_Idlineaentrada.Valor

        If _idpartida > 0 Then

            If Albentrada_lineas.LeerId(_idpartida) = True Then

                Dim campa As String = ""
                Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
                If AlbEntrada.LeerId(Albentrada_lineas.AEL_idalbaran.Valor) Then
                    campa = AlbEntrada.AEN_Campa.Valor
                End If
                TxCampaPartida.Text = campa

                TxPartida.Text = Albentrada_lineas.AEL_muestreo.Valor
                DatosPartida(_idpartida) 'ida(_idpartida)

            End If


            'Rellena el listview
            ListaNormas.Items.Clear()
            Dim LNormas As List(Of String) = ObtenerNormasCalidad(_idpartida, "P")

            If Not IsNothing(LNormas) Then
                For cont = 0 To LNormas.Count - 1
                    ListaNormas.Items.Add(LNormas(cont))
                Next
            End If

            TxCampaPartida.Bloqueado = True
            TxPartida.Bloqueado = True

        End If


    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

        LbCampa.Text = lotes.LTE_Campa.Valor
        TxCampaPartida.Text = LbCampa.Text

        LbControladoSN.Text = (lotes.LTE_Controlado.Valor & "").Trim
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
        If ProgramaCalidadTecnicos.LeerId(lotes.LTE_IdProgramaCalidad.Valor) Then
            LbProgramaCalidad.Text = ProgramaCalidadTecnicos.PCT_Nombre.Valor
        End If


        '_IdProgramaCalidad = VaInt(lotes.LET_IdProgramaCalidad.Valor)

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean

        'asociar cabecera con lineas
        Dim r As Boolean

        If LbId.Text = "+" Then
            LbId.Text = lotes.MaxId
            If TxNumero.Text = "+" Then
                TxNumero.Text = lotes.MaxIdCampa(Val(LbCampa.Text))
            End If
        End If


        If NuevoRegistro Then
            lotes.LTE_IdUbicacionPV.Valor = MiMaletin.IdPuntoVenta.ToString
        End If

        lotes.LTE_Idlote.Valor = LbId.Text
        lotes.LTE_Campa.Valor = LbCampa.Text
        Lotes_lineas.LTL_Idlote.Valor = LbId.Text
        Lotes_lineas.LTL_Idlineaentrada.Valor = _idpartida.ToString
        Lotes_lineas.LTL_Idprogramacliente.Valor = MiMaletin.idprogramacliente.ToString

        SqlGrid()


        Dim Calidad_partida As String = (Albentrada_lineas.AEL_Calidad.Valor & "").Trim
        If (lotes.LTE_Calidad.Valor & "").Trim < Calidad_partida Then
            lotes.LTE_Calidad.Valor = Calidad_partida
            TxCalidad.Text = Calidad_partida
        End If



        Dim Calidad As String = ""




        If VaDec(Lotes_lineas.LTL_Idlineaentrada.Valor) > 0 Then

            Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
            If AlbEntrada_Lineas.LeerId(Lotes_lineas.LTL_Idlineaentrada.Valor) Then

                Calidad = (AlbEntrada_Lineas.AEL_Calidad.Valor & "").Trim

                If (lotes.LTE_Controlado.Valor & "").Trim = "S" Then
                    If (AlbEntrada_Lineas.AEL_Controlado.Valor & "").Trim = "N" Then
                        lotes.LTE_Controlado.Valor = "N"
                        LbControladoSN.Text = "N"
                    End If
                End If

            End If

        End If



        r = MyBase.GuardarLineas(Gr)


        Dim frm As New FrmColorEtiqueta(Calidad)
        frm.ShowDialog()


        Return r

    End Function


    Public Overrides Sub DespuesdeGuardarLinea(gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)

    End Sub


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()


        If NuevoRegistro Then
            C1_ImprimirLoteEntrada(LbId.Text, TipoImpresion.ImpresoraSeleccionada)
        Else
            If XtraMessageBox.Show("¿Desea imprimir el lote de entrada?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                C1_ImprimirLoteEntrada(LbId.Text, TipoImpresion.ImpresoraSeleccionada)
            End If
        End If

    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)

        _idpartida = 0

        TxCampaPartida.Text = LbCampa.Text

        TxCampaPartida.Bloqueado = False
        TxPartida.Bloqueado = False


        TxPartida.Text = ""
        TxBultos.Text = ""
        TxKilos.Text = ""

        LbProducto.Text = ""
        LbAgricultor.Text = ""
        LbAlbaran.Text = ""
        LbFecha.Text = ""
        LbBultosEntrada.Text = ""
        LbKilosEntrada.Text = ""
        LbKilosxBulto.Text = ""

        ListaNormas.Items.Clear()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbCampa.Text = MiMaletin.Ejercicio.ToString
        _CampaBloqueada = _CampaActualBloqueada

        LbProgramaCalidad.Text = ""
        LbControladoSN.Text = ""

        ListaNormas.Items.Clear()

    End Sub


    Private Sub CargaLineasGrid()

        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)

    End Sub


    Public Overrides Sub DespuesdeCargarLineas(gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)


        Dim programa As String = ""
        Dim bControlado As Boolean = False
        _IdProgramaCalidad = CalculaProgramaCalidadLote(programa, bControlado)


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


    Private Function CalculaProgramaCalidadLote(ByRef programa As String, ByRef bControlado As Boolean) As Integer

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
            sql = sql & " LEFT JOIN Lotes_Lineas ON LTL_IdLineaEntrada = AEL_IdLinea" & vbCrLf
            sql = sql & " LEFT JOIN TecnicosNet.dbo.ProgramasCalidad ON PCL_IdPrograma = AEL_IdPrograma" & vbCrLf
            sql = sql & " INNER JOIN TecnicosNet.dbo.CalidadNorma ON PCL_IdPrograma = CAN_IdPrograma" & vbCrLf
            sql = sql & " INNER JOIN TecnicosNet.dbo.NormasCalidad ON CAN_IdNorma = NCL_IdNorma" & vbCrLf
            sql = sql & " WHERE LTL_IdLote = " & LbId.Text & vbCrLf
            sql = sql & " ORDER BY AEL_IdLinea, CAN_IdNorma" & vbCrLf

            Dim dt As DataTable = Albentrada_lineas.MiConexion.ConsultaSQL(sql)
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


    Private Sub SqlGrid()


        Dim id As String
        If LbId.Text = "+" Then
            id = "-1"
        Else
            id = LbId.Text
        End If
        Dim sql As String
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim CONSULTA As New Cdatos.E_select


        CONSULTA.SelCampo(Lotes_lineas.LTL_Idlinea, "LTL_Idlinea")
        CONSULTA.SelCampo(Albentrada_lineas.AEL_muestreo, "Partida", Lotes_lineas.LTL_Idlineaentrada)
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero", Albentrada_lineas.AEL_idgenero)
        CONSULTA.SelCampo(Albentrada.AEN_Albaran, "Albaran", Albentrada_lineas.AEL_idalbaran)
        CONSULTA.SelCampo(Agriculores.AGR_Nombre, "Agricultor", Albentrada.AEN_IdAgricultor)
        CONSULTA.SelCampo(Lotes_lineas.LTL_Bultos, "Bultos")
        CONSULTA.SelCampo(Lotes_lineas.LTL_Kilos, "Kilos")

        CONSULTA.WheCampo(Lotes_lineas.LTL_Idlote, "=", id)
        CONSULTA.WheCampo(Lotes_lineas.LTL_Idprogramacliente, "=", MiMaletin.idprogramacliente.ToString)
        sql = CONSULTA.SQL
        sql = sql + " order by LTL_idlinea"

        ClGrid1.Consulta = sql

    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MyBase.BAnular_Click(sender, e)
    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString Then
        ' MsgBox("no se puede modificar el albarán")
        ' Exit Sub
        ' End If

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
            lotes.LTE_IdUbicacionPV.Valor = MiMaletin.IdPuntoVenta.ToString
        End If


        'Actualizamos FechaProducto
        Dim sql As String = "SELECT AEN_Fecha as Fecha " & vbCrLf
        sql = sql & " FROM Lotes_lineas" & vbCrLf
        sql = sql & " INNER JOIN AlbEntrada_Lineas ON LTL_IdLineaEntrada = AEL_IdLinea " & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " WHERE LTL_IdLote = " & LbId.Text & vbCrLf
        sql = sql & " ORDER BY AEL_FechaMuestreo" & vbCrLf

        Dim dt As DataTable = Albentrada_lineas.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)

                Dim FechaProducto As String = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
                lotes.LTE_FechaProducto.Valor = FechaProducto

            End If
        End If


        lotes.LTE_IdProgramaCalidad.Valor = _IdProgramaCalidad.ToString
        lotes.LTE_Controlado.Valor = LbControladoSN.Text

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
        If ValoresEjercicio.LeerId(LbCampa.Text) Then
            If ValoresEjercicio.VEJ_Bloqueada.Valor = "S" Then
                _CampaActualBloqueada = True
            End If
        End If


    End Sub


    Private Sub TxPartida_Valida(edicion As Boolean) Handles TxPartida.Valida

        Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        'Dim Id As Integer = AlbEntrada_Lineas.LeerMuestreo(LbCampa.Text, TxPartida.Text)
        Dim Id As Integer = AlbEntrada_Lineas.LeerMuestreo(TxCampaPartida.Text, TxPartida.Text)
        If Id > 0 Then AlbEntrada_Lineas.LeerId(Id)


        If Id = 0 Then
            MsgBox("Partida inexistente")
            TxPartida.MiError = True
        ElseIf Not CompruebaGeneroTrazabilidadPartida(TxProducto.Text, AlbEntrada_Lineas) Then
            MsgBox("El género de la partida no coincide con el género del lote.")
            TxPartida.MiError = True
        Else

            If edicion Then

                'Comprobar que la partida no esté ya en el lote
                If PartidaYaIntroducida(TxPartida.Text) Then
                    MsgBox("La partida " & TxPartida.Text & " ya está introducida")
                    TxPartida.MiError = True
                    Exit Sub
                End If

                'Comprueba que la partida no provenga de una entrada directa
                'If EntradaDirecta(LbCampa.Text, Id) Then
                If EntradaDirecta(TxCampaPartida.Text, Id) Then
                    MsgBox("La partida proviene de una entrada directa")
                    TxPartida.MiError = True
                    Exit Sub
                End If

                'Comprobar que si la partida cambia el lote de controlado a no controlado
                If LbControladoSN.Text.Trim = "S" Then

                    Dim Controlada As String = (AlbEntrada_Lineas.AEL_Controlado.Valor & "").Trim
                    If Controlada <> "S" Then
                        If XtraMessageBox.Show("ATENCIÓN: La partida " & TxPartida.Text & " es una partida no controlada. Si la introduce, el lote cambiará a NO CONTROLADO. ¿Desea introducir la partida?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
                            'No continúa
                            TxPartida.MiError = True
                            Exit Sub
                        Else
                            'TxControlado.Text = "N"
                        End If
                    End If


                End If


                'Comprobar si la partida cambia la calidad del lote
                Dim Calidad_partida As String = (AlbEntrada_Lineas.AEL_Calidad.Valor & "").Trim
                If Calidad_partida > TxCalidad.Text Then
                    If XtraMessageBox.Show("ATENCIÓN: La partida " & TxPartida.Text & " tiene calidad inferior al lote. Si la introduce, la calidad del lote será cambiada a la calidad de la partida. ¿Desea introducir la partida?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
                        'No continúa
                        TxPartida.MiError = True
                        Exit Sub
                    Else
                        lotes.LTE_Calidad.Valor = Calidad_partida
                        TxCalidad.Text = Calidad_partida
                    End If
                End If

            End If



            _idpartida = Id
            DatosPartida(Id)

        End If


    End Sub


    Private Function EntradaDirecta(Ejercicio As String, IdLineaEntrada As String) As Boolean

        Dim bRes As Boolean = False

        If VaInt(IdLineaEntrada) > 0 Then

            Dim sql As String = "SELECT AEN_EntradaConfeccionada as Directa FROM AlbEntrada_Lineas LEFT JOIN AlbEntrada ON AEN_IdAlbaran = AEL_IdAlbaran WHERE AEL_IdLinea = " & IdLineaEntrada
            Dim dt As DataTable = Albentrada_lineas.MiConexion.ConsultaSQL(sql)

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


    Private Function PartidaYaIntroducida(Partida As String) As Boolean

        Dim bRes As Boolean = False


        If VaInt(LbId.Text) > 0 Then

            Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
            'Dim IdLinea As Integer = AlbEntrada_Lineas.LeerMuestreo(LbCampa.Text, Partida)
            Dim IdLinea As Integer = AlbEntrada_Lineas.LeerMuestreo(TxCampaPartida.Text, Partida)
            If IdLinea > 0 Then

                Dim sql As String = "SELECT LTL_IdLineaEntrada FROM Lotes_lineas WHERE LTL_IdLote = " & LbId.Text & " AND LTL_IdLineaEntrada = " & IdLinea
                Dim dt As DataTable = AlbEntrada_Lineas.MiConexion.ConsultaSQL(sql)
                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 0 Then bRes = True
                End If

            End If


        End If


        Return bRes

    End Function


    Private Sub DatosPartida(idlineaentrada As Integer)

        Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
        Dim Agricultores As New E_Agricultores(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Albentrada_lineas.AEL_bultos, "bultos")
        consulta.SelCampo(Albentrada_lineas.AEL_kilosnetos, "kilos")
        consulta.SelCampo(Albentrada_lineas.AEL_KilosxBulto, "KxB")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albentrada_lineas.AEL_idgenero)
        consulta.SelCampo(Albentrada.AEN_Albaran, "Albaran", Albentrada_lineas.AEL_idalbaran)
        consulta.SelCampo(Albentrada.AEN_Fecha, "Fecha")
        consulta.SelCampo(Agricultores.AGR_Nombre, "Agricultor", Albentrada.AEN_IdAgricultor)
        consulta.WheCampo(Albentrada_lineas.AEL_idlinea, "=", idlineaentrada.ToString)

        Dim sql As String = consulta.SQL


        Dim dt As DataTable = Albentrada.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then

                Dim Bultos As Integer = VaInt(dt.Rows(0)("Bultos"))
                Dim Kilos As Decimal = VaDec(dt.Rows(0)("Kilos"))

                LbProducto.Text = dt.Rows(0)("Genero").ToString
                LbAgricultor.Text = dt.Rows(0)("Agricultor").ToString
                LbAlbaran.Text = dt.Rows(0)("Albaran").ToString
                LbFecha.Text = Format(dt.Rows(0)("Fecha"), "dd/MM/yyyy")
                LbBultosEntrada.Text = dt.Rows(0)("Bultos").ToString
                LbKilosEntrada.Text = dt.Rows(0)("Kilos").ToString

                Dim kxb As Decimal = 0
                If Bultos <> 0 Then kxb = Kilos / Bultos
                LbKilosxBulto.Text = kxb.ToString("#,##0.00")

            End If
        End If


    End Sub


    Private Sub TxBultos_Valida(edicion As Boolean) Handles TxBultos.Valida
        If edicion = True Then
            If TxKilos.Text = "" Then
                If VaDec(TxBultos.Text) = VaDec(LbBultosEntrada.Text) Then ' cuando es el total de la partida
                    TxKilos.Text = LbKilosEntrada.Text
                Else
                    TxKilos.Text = FnVaStr(Int(VaDec(TxBultos.Text) * VaDec(LbKilosxBulto.Text)))
                End If
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


    'Private Sub TxControlado_Valida(edicion As System.Boolean)
    '    If edicion Then

    '        If TxControlado.Text = "" Then TxControlado.Text = "N"

    '        If TxControlado.Text = "S" Then
    '            If HayPartidasNoControladas() Then
    '                TxControlado.Text = "N"
    '                MsgBox("Hay partidas no controladas, el lote debe ser no controlado")
    '            End If
    '        End If


    '    End If
    'End Sub


    Private Function HayPartidasNoControladas() As Boolean

        Dim bRes As Boolean = False


        If VaInt(LbId.Text) > 0 Then

            Dim sql As String = "SELECT COALESCE(AEL_Controlado, 'N') as Controlado" & vbCrLf
            sql = sql & " FROM Lotes_lineas" & vbCrLf
            sql = sql & " LEFT JOIN AlbEntrada_Lineas ON AEL_IdLinea = LTL_IdLineaEntrada" & vbCrLf
            sql = sql & " WHERE LTL_IdLote = " & LbId.Text & vbCrLf
            sql = sql & " AND COALESCE(AEL_Controlado, 'N') = 'N'" & vbCrLf


            Dim dt As DataTable = Albentrada_lineas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    bRes = True
                End If
            End If


        End If


        Return bRes

    End Function


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirLoteEntrada(LbId.Text, TipoImpresion.Preliminar)
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirLoteEntrada(LbId.Text, TipoImpresion.ImpresoraSeleccionada)
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

    Private Sub TxCampaPartida_Valida(edicion As System.Boolean) Handles TxCampaPartida.Valida

        If edicion Then

            TxCampaPartida.MiError = False

            Dim Ejercicios As New E_Ejercicios(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
            If Not Ejercicios.LeerId(TxCampaPartida.Text) Then
                MsgBox("La campaña especificada no existe")
                TxCampaPartida.MiError = True
            End If

            'Si la campaña del lote está bloqueada, sólo se puede introducir la campaña del lote (en caso de nueva línea)
            If Not TxCampaPartida.MiError And _CampaBloqueada And Not TxCampaPartida.Bloqueado Then
                If VaInt(TxCampaPartida.Text) <> VaInt(LbCampa.Text) Then
                    MsgBox("Ejercicio no válido, sólo se permiten partidas de la campaña actual")
                    TxCampaPartida.MiError = True
                End If
            End If

        End If

    End Sub
End Class
