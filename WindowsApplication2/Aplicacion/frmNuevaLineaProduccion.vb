Imports DevExpress.XtraEditors


Public Class frmNuevaLineaProduccion

    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro


    Dim Produccion As New E_Produccion(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)
    Dim Lotes_Lineas As New E_Lotes_lineas(Idusuario, cn)
    Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)

    Dim Ejercicios As New E_Ejercicios(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))


    Private err As New Errores
    Public ErrorGrave As Boolean = False

    Dim _IdLinea As String = ""
    Dim _IdPventa As String = ""
    Dim _bSoloPrecalibrado As Boolean = False
    Dim _bPermitirPrecalibrado As Boolean = False


    Dim _CampaBloqueada As Boolean = False


    Dim _bCambio As Boolean = False


    'Dim _HoraInicio As Date = VaDate("")


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub


    Public Sub New(IdLinea As String, IdPventa As String, Fecha As String, bSoloPrecalibrado As Boolean, bPermitirPrecalibrado As Boolean,
                   Optional HoraInicio As Date = Nothing)

        Me.New()


        LbFecha.Text = Fecha


        _IdLinea = IdLinea
        _IdPventa = IdPventa
        _bSoloPrecalibrado = bSoloPrecalibrado
        _bPermitirPrecalibrado = bPermitirPrecalibrado

        If VaDate(HoraInicio) > VaDate("") Then
            TxHoraInicio.Text = HoraInicio.ToString("HH:mm")
            updownHora.Value = HoraInicio.Hour
            updownMinutos.Value = HoraInicio.Minute
        Else
            Dim ahora As DateTime = Now
            TxHoraInicio.Text = ahora.ToString("HH:mm")
            updownHora.Value = ahora.Hour
            updownMinutos.Value = ahora.Minute
        End If


    End Sub


    Private Sub ParametrosFrm()

        Dim param As New Cdatos.PropiedadesTx

        param.Obligatorio = True
        param.CampoBd = Ejercicios.IdEjercicio
        param.Tipo = Ejercicios.IdEjercicio.TipoBd
        param.Longitud = 2

        TxCampa.Orden = 0
        TxCampa.ClParam = param
        TxCampa.ClForm = Me


        param = New Cdatos.PropiedadesTx
        param.Obligatorio = True

        If rdbPartida.Checked Then
            param.CampoBd = Produccion.PRD_IdLineaEntrada
            param.Tipo = Produccion.PRD_IdLineaEntrada.TipoBd
            param.Longitud = 15
        ElseIf rdbLote.Checked Then
            param.CampoBd = Produccion.PRD_IdLote
            param.Tipo = Produccion.PRD_IdLote.TipoBd
            param.Longitud = 15
        ElseIf rdbPrecalibrado.Checked Then
            param.CampoBd = Produccion.PRD_IdLoteProduccion
            param.Tipo = Produccion.PRD_IdLoteProduccion.TipoBd
            param.Longitud = 15
        End If

        TxNumero.Orden = 1
        TxNumero.ClParam = param
        TxNumero.ClForm = Me

        TxNumero.ClParam.Exclusivos = "0123456789PALEPS."


    End Sub


    Private Sub frmNuevaLineaProduccion_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Borrapan()


        Dim ValoresEjercicio As New E_ValoresEjercicio(Idusuario, cn)
        If ValoresEjercicio.LeerId(MiMaletin.Ejercicio.ToString) Then
            If ValoresEjercicio.VEJ_Bloqueada.Valor = "S" Then
                _CampaBloqueada = True
            End If
        End If


        TxNumero.Select()
        TxNumero.Focus()


        rdbPartida.Checked = False
        rdbLote.Checked = False
        rdbPrecalibrado.Checked = False

        If _bSoloPrecalibrado Then
            'Precalibrado
            rdbPartida.Enabled = False
            rdbLote.Enabled = False
            rdbPrecalibrado.Enabled = True
            rdbPrecalibrado.Checked = True
        ElseIf _bPermitirPrecalibrado Then
            'Partida, lotes y precalibrado
            rdbPartida.Enabled = True
            rdbLote.Enabled = True
            rdbPrecalibrado.Enabled = True
            rdbPartida.Checked = True
        Else
            'Normal: partida y lote
            rdbPartida.Enabled = True
            rdbLote.Enabled = True
            rdbPrecalibrado.Enabled = False
            rdbPartida.Checked = True
        End If


    End Sub


    Private Sub BtAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BtAceptar.Click

        BtAceptar.Enabled = False


        Try

            If VaInt(LbKilosPendientes.Text) <= 0 Then
                MsgBox("No quedan kilos pendientes")
                Exit Sub
            End If



            If XtraMessageBox.Show("¿Está seguro de introducir un nuevo registro?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
                Dim Lotes As New E_Lotes(Idusuario, cn)
                Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)


                Dim Produccion As New E_Produccion(Idusuario, cn)
                Produccion.PRD_Id.Valor = Produccion.MaxId()
                Produccion.PRD_Fecha.Valor = LbFecha.Text
                Produccion.PRD_IdCentro.Valor = _IdPventa
                Produccion.PRD_IdLinea.Valor = _IdLinea


                Dim HoraInicio As DateTime = VaDate("")
                Dim texto_hora_inicio As String() = Split(TxHoraInicio.Text, ":")
                If texto_hora_inicio.Length = 2 And VaInt(texto_hora_inicio(0)) > -1 And VaInt(texto_hora_inicio(0)) < 24 And VaInt(texto_hora_inicio(1)) > -1 And VaInt(texto_hora_inicio(1)) < 60 Then
                    HoraInicio = New DateTime(Now.Year, Now.Month, Now.Day, VaInt(texto_hora_inicio(0)), VaInt(texto_hora_inicio(1)), 0)
                Else
                    HoraInicio = New DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, 0)
                End If

                If HoraInicio > VaDate("") Then
                    Produccion.PRD_HoraInicio.Valor = HoraInicio.ToString("HH:mm:ss")
                    Produccion.PRD_HoraInicialCompleta.Valor = HoraInicio.ToString("dd/MM/yyyy HH:mm:ss")
                Else
                    Produccion.PRD_HoraInicio.Valor = Now.ToString("HH:mm:ss")
                    Produccion.PRD_HoraInicialCompleta.Valor = Now.ToString("dd/MM/yyyy HH:mm:ss")
                End If


                If rdbPartida.Checked Then
                    'Dim IdLineaEntrada As Integer = AlbEntrada_Lineas.LeerMuestreo(MiMaletin.Ejercicio, TxNumero.Text)
                    Dim IdLineaEntrada As Integer = AlbEntrada_Lineas.LeerMuestreo(VaInt(TxCampa.Text), TxNumero.Text)
                    Produccion.PRD_IdLineaEntrada.Valor = IdLineaEntrada.ToString
                ElseIf rdbLote.Checked Then
                    'Dim IdLote As Integer = Lotes.LeerLote(MiMaletin.Ejercicio, TxNumero.Text)
                    Dim IdLote As Integer = Lotes.LeerLote(VaInt(TxCampa.Text), TxNumero.Text)
                    Produccion.PRD_IdLote.Valor = IdLote.ToString
                ElseIf rdbPrecalibrado.Checked Then
                    'Dim IdLotePrecalibrado As Integer = LotesProduccion.LeerLote(MiMaletin.Ejercicio, TxNumero.Text)
                    Dim IdLotePrecalibrado As Integer = LotesProduccion.LeerLote(VaInt(TxCampa.Text), TxNumero.Text)
                    Produccion.PRD_IdLoteProduccion.Valor = IdLotePrecalibrado.ToString
                End If

                Produccion.PRD_KilosLinea.Valor = VaInt(LbKilosPendientes.Text).ToString
                'Produccion.PRD_KilosConsumidos.Valor = VaInt(LbKilosConsumidos.Text).ToString
                Produccion.Insertar()

                Me.Close()

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


        BtAceptar.Enabled = True

    End Sub



    Private Sub btCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub


    Private Sub MuestraDatosPartida()

        Dim kilos As Integer = 0
        Dim KilosLote As Integer = 0
        Dim KilosConsumidos As Integer = 0

        'Partidas
        Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        'Dim IdLineaEntrada As Integer = AlbEntrada_Lineas.LeerMuestreo(MiMaletin.Ejercicio, TxNumero.Text)
        Dim IdLineaEntrada As Integer = AlbEntrada_Lineas.LeerMuestreo(VaInt(TxCampa.Text), TxNumero.Text)


        If IdLineaEntrada > 0 Then

            AlbEntrada_Lineas.LeerId(IdLineaEntrada)

            If VaInt(AlbEntrada_Lineas.AEL_IdUbicacionPV.Valor) <> _IdPventa Then
                MsgBox("La partida no está en este centro")
                Exit Sub
            End If



            TxNumero.MiError = False

            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idlinea, "IdLinea")
            CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Producto", AlbEntrada_Lineas.AEL_idgenero, Generos.GEN_IdGenero)
            CONSULTA.SelCampo(Generos.GEN_IdsubFamilia, "IdSubFamilia")
            CONSULTA.SelCampo(CategoriasEntrada.CAE_CategoriaCalibre, "Categoria", AlbEntrada_Lineas.AEL_idcategoria, CategoriasEntrada.CAE_Id)
            CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_kilosnetos, "Kilos")
            CONSULTA.WheCampo(AlbEntrada_Lineas.AEL_idlinea, "=", IdLineaEntrada.ToString)


            Dim sql As String = CONSULTA.SQL
            Dim dt As DataTable = AlbEntrada_Lineas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Dim row As DataRow = dt.Rows(0)

                    Dim IdSubFamilia As String = (row("IdSubFamilia").ToString & "").Trim
                    If ComprobarProducto(_IdLinea, IdSubFamilia) Then

                        kilos = VaDec(row("Kilos"))

                        LbProducto.Text = row("Producto").ToString
                        LbCategoria.Text = row("Categoria").ToString
                        LbKilos.Text = kilos.ToString("#,##0")

                        TxNumero.MiError = False

                    Else

                        MsgBox("El producto de la partida no corresponde con el de la linea")
                        TxNumero.MiError = True
                        Exit Sub

                    End If

                End If

            End If


            'Kilos Lote
            sql = "SELECT SUM(LTL_Kilos) as KilosLote FROM Lotes_Lineas WHERE LTL_IdLineaEntrada = " & IdLineaEntrada.ToString
            dt = Lotes_Lineas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    KilosLote = VaDec(dt.Rows(0)("KilosLote")).ToString("#,##0")
                    LbKilosPartidaLote.Text = KilosLote.ToString("#,##0")
                End If
            End If

            'Kilos consumidos
            sql = "SELECT SUM(PRD_KilosConsumidos) as KilosConsumidos FROM Produccion WHERE PRD_IdLineaEntrada = " & IdLineaEntrada.ToString
            dt = Lotes_Lineas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    KilosConsumidos = VaDec(dt.Rows(0)("KilosConsumidos")).ToString("#,##0")
                    LbKilosConsumidos.Text = KilosConsumidos.ToString("#,##0")
                End If
            End If

            LbKilosPendientes.Text = (kilos - KilosLote - KilosConsumidos).ToString("#,##0")


        Else
            MsgBox("Partida no encontrada")
            TxNumero.MiError = True
        End If

    End Sub


    Private Sub MuestraDatosLote()

        Dim kilos As Integer = 0
        Dim KilosLote As Integer = 0
        Dim KilosConsumidos As Integer = 0

        'Lotes
        Dim Lotes As New E_Lotes(Idusuario, cn)
        'Dim IdLote As Integer = Lotes.LeerLote(MiMaletin.Ejercicio, TxNumero.Text)
        Dim IdLote As Integer = Lotes.LeerLote(VaInt(TxCampa.Text), TxNumero.Text)

        If IdLote > 0 Then


            If VaInt(Lotes.LTE_IdUbicacionPV.Valor) <> _IdPventa Then
                MsgBox("El lote no pertenece a este centro")
                Exit Sub
            End If


            TxNumero.MiError = False


            Dim sql As String = "SELECT LTE_IdGenero AS Idgenero, GEN_NombreGenero AS Producto, GEN_IdSubFamilia as IdSubFamilia," & vbCrLf
            sql = sql & " 0 AS IdCategoria, '' AS Categoria, " & vbCrLf
            sql = sql & " (SELECT SUM(LTL_Kilos) FROM Lotes_Lineas WHERE LTL_IdLote = LTE_IdLote) AS Kilos " & vbCrLf
            sql = sql & " FROM Lotes" & vbCrLf
            sql = sql & " LEFT OUTER JOIN Generos ON LTE_idgenero = GEN_IdGenero" & vbCrLf
            sql = sql & " WHERE LTE_Idlote = " & IdLote & vbCrLf


            Dim dt As DataTable = Lotes_Lineas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Dim row As DataRow = dt.Rows(0)

                    Dim IdSubFamilia As String = (row("IdSubFamilia").ToString & "").Trim
                    If ComprobarProducto(_IdLinea, IdSubFamilia) Then

                        kilos = VaDec(row("Kilos"))

                        LbProducto.Text = row("Producto").ToString
                        LbCategoria.Text = row("Categoria").ToString
                        LbKilos.Text = kilos.ToString("#,##0")

                    Else

                        MsgBox("El producto del lote no corresponde con el de la linea")
                        TxNumero.MiError = True
                        Exit Sub

                    End If



                End If

            End If


            'Kilos Lote
            LbKilosPartidaLote.Text = "0"


            'Kilos consumidos
            sql = "SELECT SUM(PRD_KilosConsumidos) as KilosConsumidos FROM Produccion WHERE PRD_IdLote = " & IdLote.ToString
            dt = Lotes_Lineas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    KilosConsumidos = VaDec(dt.Rows(0)("KilosConsumidos")).ToString("#,##0")
                    LbKilosConsumidos.Text = VaDec(dt.Rows(0)("KilosConsumidos")).ToString("#,##0")
                End If
            End If


            LbKilosPendientes.Text = (kilos - KilosLote - KilosConsumidos).ToString("#,##0")


        Else
            MsgBox("Lote no encontrado")
            TxNumero.MiError = True
        End If

    End Sub


    Private Sub MuestraDatosPrecalibrado()

        Dim kilos As Integer = 0
        Dim KilosLote As Integer = 0
        Dim KilosConsumidos As Integer = 0

        'Lotes
        Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
        'Dim IdLoteProduccion As Integer = LotesProduccion.LeerLote(MiMaletin.Ejercicio, TxNumero.Text)
        Dim IdLoteProduccion As Integer = LotesProduccion.LeerLote(VaInt(TxCampa.Text), TxNumero.Text)

        If IdLoteProduccion > 0 Then


            If VaInt(LotesProduccion.LPD_IdUbicacionPV.Valor) <> _IdPventa Then
                MsgBox("El lote no pertenece a este centro")
                Exit Sub
            End If


            TxNumero.MiError = False


            Dim sql As String = "SELECT LPD_IdGenero AS Idgenero, GEN_NombreGenero AS Producto, GEN_IdSubFamilia as IdSubFamilia," & vbCrLf
            sql = sql & " LPD_idcategoria AS IdCategoria, CAS_categoriacalibre AS Categoria, " & vbCrLf
            sql = sql & " (SELECT SUM(LPL_Kilos) FROM LotesProduccion_Lineas WHERE LPL_IdLote = LPD_IdLote) AS Kilos " & vbCrLf
            sql = sql & " FROM LotesProduccion" & vbCrLf
            sql = sql & " LEFT OUTER JOIN Generos ON LPD_idgenero = GEN_IdGenero" & vbCrLf
            sql = sql & " LEFT OUTER JOIN CategoriasSalida ON LPD_idcategoria = CAS_id" & vbCrLf
            sql = sql & " WHERE LPD_Idlote = " & IdLoteProduccion & vbCrLf


            Dim dt As DataTable = Lotes_Lineas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Dim row As DataRow = dt.Rows(0)

                    Dim IdSubFamilia As String = (row("IdSubFamilia").ToString & "").Trim
                    If ComprobarProducto(_IdLinea, IdSubFamilia) Then

                        kilos = VaDec(row("Kilos"))

                        LbProducto.Text = row("Producto").ToString
                        LbCategoria.Text = row("Categoria").ToString
                        LbKilos.Text = kilos.ToString("#,##0")

                    Else

                        MsgBox("El producto del lote no corresponde con el de la linea")
                        TxNumero.MiError = True
                        Exit Sub

                    End If



                End If

            End If


            'Kilos Lote
            LbKilosPartidaLote.Text = "0"


            'Kilos consumidos
            sql = "SELECT SUM(PRD_KilosConsumidos) as KilosConsumidos FROM Produccion WHERE PRD_IdLoteProduccion = " & IdLoteProduccion.ToString
            dt = Lotes_Lineas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    KilosConsumidos = VaDec(dt.Rows(0)("KilosConsumidos")).ToString("#,##0")
                    LbKilosConsumidos.Text = VaDec(dt.Rows(0)("KilosConsumidos")).ToString("#,##0")
                End If
            End If


            LbKilosPendientes.Text = (kilos - KilosLote - KilosConsumidos).ToString("#,##0")


        Else
            MsgBox("Lote no encontrado")
            TxNumero.MiError = True
        End If

    End Sub


    Private Function ComprobarProducto(IdLinea As String, IdSubFamilia As String) As Boolean

        Dim bRes As Boolean = False

        Dim sql As String = "SELECT COUNT(LNP_Id) FROM Lineas_Producto WHERE LNP_IdLinea = " & IdLinea & " AND LNP_IdSubFamilia = " & IdSubFamilia
        Dim dt As DataTable = Produccion.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                Dim c As Integer = VaInt(dt.Rows(0)(0))
                If c > 0 Then bRes = True
            End If
        End If
        

        Return bRes

    End Function



    Private Sub rdbPartida_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbPartida.CheckedChanged

        If rdbPartida.Checked Then

            'Borrapan()

            ParametrosFrm()

            If Not _bCambio Then TxNumero.Text = ""
            LbProducto.Text = ""
            LbCategoria.Text = ""
            LbKilos.Text = ""
            LbKilosPartidaLote.Text = ""
            LbKilosConsumidos.Text = ""
            LbKilosPendientes.Text = ""

            TxCampa.Text = MiMaletin.Ejercicio.ToString

            TxNumero.Select()
            TxNumero.Focus()

            Lb5.Visible = True
            LbKilosPartidaLote.Visible = True

        End If

    End Sub

    Private Sub rdbLote_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbLote.CheckedChanged

        If rdbLote.Checked Then

            'Borrapan()

            ParametrosFrm()

            If Not _bCambio Then TxNumero.Text = ""
            LbProducto.Text = ""
            LbCategoria.Text = ""
            LbKilos.Text = ""
            LbKilosPartidaLote.Text = ""
            LbKilosConsumidos.Text = ""
            LbKilosPendientes.Text = ""

            TxCampa.Text = MiMaletin.Ejercicio.ToString

            TxNumero.Select()
            TxNumero.Focus()

            Lb5.Visible = False
            LbKilosPartidaLote.Visible = False

        End If


    End Sub

    Private Sub rdbPrecalibrado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbPrecalibrado.CheckedChanged

        If rdbPrecalibrado.Checked Then

            'Borrapan()

            ParametrosFrm()

            If Not _bCambio Then TxNumero.Text = ""
            LbProducto.Text = ""
            LbCategoria.Text = ""
            LbKilos.Text = ""
            LbKilosPartidaLote.Text = ""
            LbKilosConsumidos.Text = ""
            LbKilosPendientes.Text = ""

            TxCampa.Text = MiMaletin.Ejercicio.ToString

            TxNumero.Select()
            TxNumero.Focus()

            Lb5.Visible = False
            LbKilosPartidaLote.Visible = False

        End If


    End Sub


    Private Sub Borrapan()

        ParametrosFrm()

        TxNumero.Text = ""
        LbProducto.Text = ""
        LbCategoria.Text = ""
        LbKilos.Text = ""
        LbKilosPartidaLote.Text = ""
        LbKilosConsumidos.Text = ""
        LbKilosPendientes.Text = ""

        TxCampa.Text = MiMaletin.Ejercicio.ToString


        TxNumero.Validar(True)

    End Sub

    
    
    Private Sub TxNumero_AntesDeValidar(edicion As System.Boolean) Handles TxNumero.AntesDeValidar

        If edicion Then

            If TxNumero.Text.Trim <> "" Then

                If Not IsNumeric(TxNumero.Text) Then

                    Dim datos As String() = Split(TxNumero.Text, ".")
                    If datos.Length = 2 Then


                        Dim campa As String = datos(0)
                        Dim numero As String = datos(1)

                        _bCambio = True

                        If campa.StartsWith("PA") Then
                            rdbPartida.Checked = True
                            campa = campa.Replace("PA", "")
                        ElseIf campa.StartsWith("LE") Then
                            rdbLote.Checked = True
                            campa = campa.Replace("LE", "")
                        ElseIf campa.StartsWith("PS") Then
                            rdbPrecalibrado.Checked = True
                            campa = campa.Replace("PS", "")
                        End If

                        _bCambio = False

                        If VaInt(campa) <> MiMaletin.Ejercicio And _CampaBloqueada Then
                            MsgBox("Ejercicio no válido, sólo se permiten partidas de la campaña actual")
                            TxNumero.Text = ""
                            Exit Sub
                        End If

                        TxNumero.Text = numero
                        TxCampa.Text = campa
                        'TxNumero.Validar(True)

                    Else
                        MsgBox("El valor introducido no es válido")
                        TxNumero.Text = ""
                    End If

                End If

            End If

        End If



    End Sub


    Private Sub TxNumero_Valida(edicion As System.Boolean) Handles TxNumero.Valida

        If edicion Then

            If LbFecha.Text <> "" Then

                If VaInt(TxNumero.Text) > 0 Then

                    If rdbPartida.Checked Then
                        MuestraDatosPartida()
                    ElseIf rdbLote.Checked Then
                        MuestraDatosLote()
                    ElseIf rdbPrecalibrado.Checked Then
                        MuestraDatosPrecalibrado()
                    End If

                    If Not TxNumero.MiError Then
                        BtAceptar.Select()
                        BtAceptar.Focus()
                    End If

                Else
                    TxNumero.Select()
                    TxNumero.Focus()
                End If

            Else
                MsgBox("La fecha introducida no es valida. Inserte una fecha valida")
            End If

        End If

    End Sub


    Private Sub TxNumero_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxNumero.KeyDown

        If e.KeyCode = Keys.Up Then
            TxCampa.Select()
            TxCampa.Focus()
        End If

    End Sub


    Private Sub TxCampa_Valida(edicion As System.Boolean) Handles TxCampa.Valida

        If edicion Then

            TxCampa.MiError = False

            Dim Ejercicios As New E_Ejercicios(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
            If Not Ejercicios.LeerId(TxCampa.Text) Then
                MsgBox("La campaña especificada no existe")
                TxCampa.MiError = True
            End If

            'Si la campaña del precalibrado está bloqueada, sólo se puede introducir la campaña del precalibrado (en caso de nueva línea)
            If Not TxCampa.MiError And _CampaBloqueada Then
                If VaInt(TxCampa.Text) <> MiMaletin.Ejercicio Then
                    MsgBox("Ejercicio no válido, sólo se permiten partidas, lotes y precalibrados de la campaña actual")
                    TxCampa.MiError = True
                End If
            End If

            If Not TxCampa.MiError Then
                TxNumero.Select()
                TxNumero.Focus()
            End If

        End If

    End Sub

    Private Sub updownHora_ValueChanged(sender As Object, e As EventArgs) Handles updownHora.ValueChanged

        If updownHora.Value > 23 Then
            updownHora.Value = 0
        ElseIf updownHora.value < 0 Then
            updownHora.Value = 23
        End If

        MostrarHora()

    End Sub

    Private Sub updownMinutos_ValueChanged(sender As Object, e As EventArgs) Handles updownMinutos.ValueChanged

        If updownMinutos.Value > 59 Then
            updownMinutos.Value = 0
        ElseIf updownMinutos.Value < 0 Then
            updownMinutos.Value = 59
        End If

        MostrarHora()

    End Sub


    Private Sub MostrarHora()

        TxHoraInicio.Text = updownHora.Value.ToString("00") & ":" & updownMinutos.Value.ToString("00")

    End Sub


End Class