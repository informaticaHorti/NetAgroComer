Public Class FrmDesgloseTrazabilidadPalet
    Inherits FrMantenimiento


    Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
    Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Lotes As New E_Lotes(Idusuario, cn)
    Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)



    Dim _bLineaControlada As Boolean = False


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(bLineaControlada As Boolean)
        Me.New()

        _bLineaControlada = bLineaControlada

    End Sub


    Private Sub ParametrosFrm()
        EntidadFrm = Palets_Lineas


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxLineaPalet, Palets_Lineas.PLL_idlinea, Lb31, True)
        CampoClave = 0 ' ultimo campo de la clave


        'Panel
        ParamTx(TxPar1, Nothing, Lb31, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxLote1, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca1, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul1, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxPar2, Nothing, Lb31, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxLote2, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca2, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul2, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxPar3, Nothing, Lb31, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxLote3, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca3, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul3, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxPar4, Nothing, Lb31, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxLote4, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca4, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul4, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxPar5, Nothing, Lb31, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxLote5, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca5, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul5, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxPar6, Nothing, Lb31, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxLote6, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca6, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul6, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxPar7, Nothing, Lb31, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxLote7, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca7, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul7, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxPar8, Nothing, Lb31, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxLote8, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca8, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul8, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxPar9, Nothing, Lb31, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxLote9, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca9, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul9, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxPar10, Nothing, Lb31, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxLote10, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca10, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul10, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxPar11, Nothing, Lb31, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxLote11, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca11, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul11, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)

        ParamTx(TxPar12, Nothing, Lb31, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxLote12, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxPreca11, Nothing, Lb6, , Cdatos.TiposCampo.EnteroPositivo)
        ParamTx(TxBul12, Nothing, Lb31, False, Cdatos.TiposCampo.Entero, 0, 4)


    End Sub


    Public Overrides Sub ControlClave()

        ' componemos la clave
        LbId.Text = TxLineaPalet.Text


    End Sub


    Private Sub FrmDesgloseTrazabilidadPalet_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BAnular.Visible = False
        BModificar.Visible = False

        InicioFrm()

        Modificar()


        CargaTrazabilidad()

    End Sub


    Private Sub CargaTrazabilidad()

        Dim sql As String = ""
        Dim indice As Integer = 0

        sql = "SELECT PLT_idlineaentrada as idPartida, PLT_idlote as idlote,PLT_idprecalibrado as idpreca, " & vbCrLf
        sql = sql & " PLT_Bultos as Bultos" & vbCrLf
        sql = sql & " FROM PALETS_TRAZA" & vbCrLf
        sql = sql & " WHERE PLT_IdLineaPalet = " & LbId.Text & vbCrLf
        sql = sql & " AND COALESCE(PLT_IdProgramaCliente,0) = " & MiMaletin.idprogramacliente.ToString & vbCrLf
        sql = sql + "ORDER BY PLT_IDTRAZA"

        Dim DtTraza As DataTable = Palets_Lineas.MiConexion.ConsultaSQL(sql)
        If Not DtTraza Is Nothing Then
            For Each rwt In DtTraza.Rows
                Dim Bultos As Integer = VaInt(rwt("Bultos"))
                Dim Partida As String = ""
                Dim Agricultor As String = ""
                Dim Idgenero As String = ""
                Dim Genero As String = ""
                Dim Lote As String = ""
                Dim Preca As String = ""

                If VaInt(rwt("idpartida")) > 0 Then
                    sql = "SELECT AEL_Muestreo as Partida, AGR_Nombre as Agricultor, AEL_IdGenero as IdGenero, GEN_NombreGenero as Genero " & vbCrLf
                    sql = sql & " FROM albentrada_lineas" & vbCrLf
                    sql = sql & " LEFT JOIN Albentrada ON AEN_Idalbaran = AEL_Idalbaran" & vbCrLf
                    sql = sql & " LEFT JOIN Agricultores ON AGR_IdAgricultor = AEN_IdAgricultor" & vbCrLf
                    sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = AEL_IdGenero" & vbCrLf

                    sql = sql & " WHERE AEL_IdLinea = " & rwt("idpartida").ToString & vbCrLf

                    Dim dtp As DataTable = Albentrada_lineas.MiConexion.ConsultaSQL(sql)
                    If Not dtp Is Nothing Then
                        If dtp.Rows.Count > 0 Then
                            Dim row As DataRow = dtp.Rows(0)

                            Partida = (row("Partida").ToString & "").Trim
                            Agricultor = (row("Agricultor").ToString & "").Trim
                            Idgenero = (row("IdGenero").ToString & "").Trim
                            Genero = (row("Genero").ToString & "").Trim
                            Preca = ""
                            Lote = ""


                        End If
                    End If
                ElseIf VaInt(rwt("idlote")) > 0 Then
                    sql = "SELECT LTE_lote as lote,  LTE_IdGenero as IdGenero, GEN_NombreGenero as Genero " & vbCrLf
                    sql = sql & " FROM LOTES" & vbCrLf
                    sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = LTE_IdGenero" & vbCrLf

                    sql = sql & " WHERE LTE_Idlote = " & rwt("idlote").ToString & vbCrLf

                    Dim dtp As DataTable = Lotes.MiConexion.ConsultaSQL(sql)
                    If Not dtp Is Nothing Then
                        If dtp.Rows.Count > 0 Then
                            Dim row As DataRow = dtp.Rows(0)

                            Partida = ""
                            Preca = ""

                            Agricultor = ""
                            Idgenero = (row("IdGenero").ToString & "").Trim
                            Genero = (row("Genero").ToString & "").Trim
                            Lote = (row("Lote").ToString & "").Trim

                        End If
                    End If

                ElseIf VaInt(rwt("idpreca")) > 0 Then
                    sql = "SELECT LPD_lote as lote,  LPD_IdGenero as IdGenero, GEN_NombreGenero as Genero " & vbCrLf
                    sql = sql & " FROM LOTESPRODUCCION" & vbCrLf
                    sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = LPD_IdGenero" & vbCrLf

                    sql = sql & " WHERE LPD_Idlote = " & rwt("idpreca").ToString & vbCrLf

                    Dim dtp As DataTable = Lotes.MiConexion.ConsultaSQL(sql)
                    If Not dtp Is Nothing Then
                        If dtp.Rows.Count > 0 Then
                            Dim row As DataRow = dtp.Rows(0)

                            Partida = ""
                            Lote = ""
                            Agricultor = ""
                            Idgenero = (row("IdGenero").ToString & "").Trim
                            Genero = (row("Genero").ToString & "").Trim
                            Preca = (row("Lote").ToString & "").Trim

                        End If
                    End If



                End If


                If VaInt(Lote) > 0 Or VaInt(Partida) > 0 Or VaInt(Preca) > 0 Then
                    indice = indice + 1
                    Select Case indice

                        Case 1
                            TxPar1.Text = Partida : LbAgri1.Text = Agricultor : LbCodGen1.Text = Idgenero : LbGen1.Text = Genero : TxBul1.Text = Bultos.ToString("#,##0") : TxLote1.Text = Lote : TxPreca1.Text = Preca
                        Case 2
                            TxPar2.Text = Partida : LbAgri2.Text = Agricultor : LbCodGen2.Text = Idgenero : LbGen2.Text = Genero : TxBul2.Text = Bultos.ToString("#,##0") : TxLote2.Text = Lote : TxPreca2.Text = Preca
                        Case 3
                            TxPar3.Text = Partida : LbAgri3.Text = Agricultor : LbCodGen3.Text = Idgenero : LbGen3.Text = Genero : TxBul3.Text = Bultos.ToString("#,##0") : TxLote3.Text = Lote : TxPreca3.Text = Preca
                        Case 4
                            TxPar4.Text = Partida : LbAgri4.Text = Agricultor : LbCodGen4.Text = Idgenero : LbGen4.Text = Genero : TxBul4.Text = Bultos.ToString("#,##0") : TxLote4.Text = Lote : TxPreca4.Text = Preca
                        Case 5
                            TxPar5.Text = Partida : LbAgri5.Text = Agricultor : LbCodGen5.Text = Idgenero : LbGen5.Text = Genero : TxBul5.Text = Bultos.ToString("#,##0") : TxLote5.Text = Lote : TxPreca5.Text = Preca
                        Case 6
                            TxPar6.Text = Partida : LbAgri6.Text = Agricultor : LbCodGen6.Text = Idgenero : LbGen6.Text = Genero : TxBul6.Text = Bultos.ToString("#,##0") : TxLote6.Text = Lote : TxPreca6.Text = Preca
                        Case 7
                            TxPar7.Text = Partida : LbAgri7.Text = Agricultor : LbCodGen7.Text = Idgenero : LbGen7.Text = Genero : TxBul7.Text = Bultos.ToString("#,##0") : TxLote7.Text = Lote : TxPreca7.Text = Preca
                        Case 8
                            TxPar8.Text = Partida : LbAgri8.Text = Agricultor : LbCodGen8.Text = Idgenero : LbGen8.Text = Genero : TxBul8.Text = Bultos.ToString("#,##0") : TxLote8.Text = Lote : TxPreca8.Text = Preca
                        Case 9
                            TxPar9.Text = Partida : LbAgri9.Text = Agricultor : LbCodgen9.Text = Idgenero : LbGen9.Text = Genero : TxBul9.Text = Bultos.ToString("#,##0") : TxLote9.Text = Lote : TxPreca9.Text = Preca
                        Case 10
                            TxPar10.Text = Partida : LbAgri10.Text = Agricultor : LbCodGen10.Text = Idgenero : LbGen10.Text = Genero : TxBul10.Text = Bultos.ToString("#,##0") : TxLote10.Text = Lote : TxPreca10.Text = Preca
                        Case 11
                            TxPar11.Text = Partida : LbAgri11.Text = Agricultor : LbCodGen11.Text = Idgenero : LbGen11.Text = Genero : TxBul11.Text = Bultos.ToString("#,##0") : TxLote11.Text = Lote : TxPreca11.Text = Preca
                        Case 12
                            TxPar12.Text = Partida : LbAgri12.Text = Agricultor : LbCodgen12.Text = Idgenero : LbGen12.Text = Genero : TxBul12.Text = Bultos.ToString("#,##0") : TxLote12.Text = Lote : TxPreca12.Text = Preca

                    End Select

                End If
            Next

        End If

    End Sub


    Public Overrides Sub Guardar()


        Dim bError As Boolean = False

        For Each c As Control In ListaControles
            If TypeOf c Is TxDato Then

                Dim tx As TxDato = CType(c, TxDato)
                If tx.MiError Then

                    bError = True
                    tx.MiError = True
                    PonError(tx.Orden)
                    Exit For

                End If

            End If
        Next


        If bError Then
            MsgBox("Corregir campos")
            Exit Sub
        End If


        If VaInt(LbId.Text) > 0 Then
            GuardaTrazabilidadLinea(LbId.Text)
        End If


        Me.Close()
        'MyBase.Guardar()

    End Sub


    Private Sub GuardaTrazabilidadLinea(IdLineaPalet As String)

        'Borrar trazabilidad para la linea de palet
        If VaInt(IdLineaPalet) > 0 Then
            Dim sql As String = "DELETE FROM palets_traza WHERE PLT_IdLineaPalet = " & IdLineaPalet & " AND COALESCE(PLT_IdProgramaCliente,0) = " & MiMaletin.idprogramacliente.ToString
            Palets_Lineas.MiConexion.OrdenSql(sql)
        End If



        'Crear trazabilidad a partir del panel
        Dim Partida As String = ""
        Dim Bultos As Integer = 0
        Dim Kilos As Decimal = 0


        CreaTrazabilidad(IdLineaPalet, TxPar1.Text, TxBul1.Text, TxLote1.Text, TxPreca1.Text)
        CreaTrazabilidad(IdLineaPalet, TxPar2.Text, TxBul2.Text, TxLote2.Text, TxPreca2.Text)
        CreaTrazabilidad(IdLineaPalet, TxPar3.Text, TxBul3.Text, TxLote3.Text, TxPreca3.Text)
        CreaTrazabilidad(IdLineaPalet, TxPar4.Text, TxBul4.Text, TxLote4.Text, TxPreca4.Text)
        CreaTrazabilidad(IdLineaPalet, TxPar5.Text, TxBul5.Text, TxLote5.Text, TxPreca5.Text)
        CreaTrazabilidad(IdLineaPalet, TxPar6.Text, TxBul6.Text, TxLote6.Text, TxPreca6.Text)
        CreaTrazabilidad(IdLineaPalet, TxPar7.Text, TxBul7.Text, TxLote7.Text, TxPreca7.Text)
        CreaTrazabilidad(IdLineaPalet, TxPar8.Text, TxBul8.Text, TxLote8.Text, TxPreca8.Text)
        CreaTrazabilidad(IdLineaPalet, TxPar9.Text, TxBul9.Text, TxLote9.Text, TxPreca9.Text)
        CreaTrazabilidad(IdLineaPalet, TxPar10.Text, TxBul10.Text, TxLote10.Text, TxPreca10.Text)
        CreaTrazabilidad(IdLineaPalet, TxPar11.Text, TxBul11.Text, TxLote11.Text, TxPreca11.Text)
        CreaTrazabilidad(IdLineaPalet, TxPar12.Text, TxBul12.Text, TxLote12.Text, TxPreca12.Text)

    End Sub


    Private Sub CreaTrazabilidad(IdLineaPalet As String, Partida As String, Bultos As String, lote As String, preca As String)

        Dim IdAgricultor As String = ""
        Dim IdGenero As String = ""
        Dim IdCategoria As String = ""
        Dim KgEntrada As Decimal = 0
        Dim idlineaentrada As String = ""
        Dim Idlote As String = ""
        Dim IdPreca As String = ""


        If VaInt(Partida) > 0 Then
            idlineaentrada = Albentrada_lineas.LeerMuestreo(MiMaletin.Ejercicio, Partida)
        ElseIf VaInt(lote) > 0 Then
            Idlote = Lotes.LeerLote(MiMaletin.Ejercicio, lote)
        ElseIf VaInt(preca) > 0 Then
            IdPreca = LotesProduccion.LeerLote(MiMaletin.Ejercicio, preca)
        End If


        If VaInt(idlineaentrada) > 0 Or VaInt(Idlote) > 0 Or VaInt(IdPreca) > 0 Then

            'Dim KilosNetos As Decimal = VaDec(Lbkilosnetos.Text)
            'Dim BultosLinea As Integer = VaInt(TxBultos.Text)

            Dim KilosNetos As Decimal = VaDec(Palets_Lineas.PLL_kilosnetos.Valor)
            Dim BultosLinea As Integer = VaInt(Palets_Lineas.PLL_bultos.Valor)

            Dim KNxB As Decimal = 0
            If BultosLinea <> 0 Then
                KNxB = KilosNetos / BultosLinea
            End If
            Dim Kilos As Decimal = Math.Round(VaInt(Bultos) * KNxB, 0)


            Dim Palet_Traza As New E_palets_traza(Idusuario, cn)
            Palet_Traza.PLT_idtraza.Valor = Palet_Traza.MaxId()
            Palet_Traza.PLT_idlineapalet.Valor = IdLineaPalet
            Palet_Traza.PLT_bultos.Valor = VaInt(Bultos).ToString
            Palet_Traza.PLT_kilos.Valor = VaDec(Kilos).ToString
            Palet_Traza.PLT_IdLineaEntrada.Valor = idlineaentrada
            Palet_Traza.PLT_idlote.Valor = Idlote
            Palet_Traza.PLT_idprecalibrado.Valor = IdPreca
            Palet_Traza.PLT_idprogramacliente.Valor = MiMaletin.idprogramacliente.ToString
            Palet_Traza.Insertar()

        End If

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
    End Sub



    Private Sub TxPar1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar1.Text.Trim = "" Then
                TxLote1.Select()
                TxLote1.Focus()
            End If
        End If
    End Sub

    Private Sub TxPar2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar2.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar2.Text.Trim = "" Then
                TxLote2.Select()
                TxLote2.Focus()
            End If
        End If
    End Sub

    Private Sub TxPar3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar3.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar3.Text.Trim = "" Then
                TxLote3.Select()
                TxLote3.Focus()
            End If
        End If
    End Sub

    Private Sub TxPar4_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar4.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar4.Text.Trim = "" Then
                TxLote4.Select()
                TxLote4.Focus()
            End If
        End If
    End Sub

    Private Sub TxPar5_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar5.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar5.Text.Trim = "" Then
                TxLote5.Select()
                TxLote5.Focus()
            End If
        End If
    End Sub

    Private Sub TxPar6_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar6.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar6.Text.Trim = "" Then
                TxLote6.Select()
                TxLote6.Focus()
            End If
        End If
    End Sub

    Private Sub TxPar7_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar7.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar7.Text.Trim = "" Then
                TxLote7.Select()
                TxLote7.Focus()
            End If
        End If
    End Sub
    Private Sub TxPar8_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar8.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar8.Text.Trim = "" Then
                TxLote8.Select()
                TxLote8.Focus()
            End If
        End If

    End Sub
    Private Sub TxPar9_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar9.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar9.Text.Trim = "" Then
                TxLote9.Select()
                TxLote9.Focus()
            End If
        End If
    End Sub
    Private Sub TxPar10_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar10.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar10.Text.Trim = "" Then
                TxLote10.Select()
                TxLote10.Focus()
            End If
        End If
    End Sub

    Private Sub TxPar11_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar11.KeyDown

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar11.Text.Trim = "" Then
                TxLote11.Select()
                TxLote11.Focus()
            End If
        End If
    End Sub

    Private Sub TxPar12_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPar12.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If TxPar12.Text.Trim = "" Then
                TxLote12.Select()
                TxLote12.Focus()
            End If
        End If
    End Sub



    Private Sub TxPar1_Valida(edicion As System.Boolean) Handles TxPar1.Valida
        ValidaPartida(edicion, TxPar1.Text, 1, TxPar1, TxLote1, TxBul1, TxPreca1)
    End Sub

    Private Sub TxPar2_Valida(edicion As System.Boolean) Handles TxPar2.Valida
        ValidaPartida(edicion, TxPar2.Text, 2, TxPar2, TxLote2, TxBul2, TxPreca2)
    End Sub

    Private Sub TxPar3_Valida(edicion As System.Boolean) Handles TxPar3.Valida
        ValidaPartida(edicion, TxPar3.Text, 3, TxPar3, TxLote3, TxBul3, TxPreca3)
    End Sub

    Private Sub TxPar4_Valida(edicion As System.Boolean) Handles TxPar4.Valida
        ValidaPartida(edicion, TxPar4.Text, 4, TxPar4, TxLote4, TxBul4, TxPreca4)
    End Sub

    Private Sub TxPar5_Valida(edicion As System.Boolean) Handles TxPar5.Valida
        ValidaPartida(edicion, TxPar5.Text, 5, TxPar5, TxLote5, TxBul5, TxPreca5)
    End Sub

    Private Sub TxPar6_Valida(edicion As System.Boolean) Handles TxPar6.Valida
        ValidaPartida(edicion, TxPar6.Text, 6, TxPar6, TxLote6, TxBul6, TxPreca6)
    End Sub

    Private Sub TxPar7_Valida(edicion As System.Boolean) Handles TxPar7.Valida
        ValidaPartida(edicion, TxPar7.Text, 7, TxPar7, TxLote7, TxBul7, TxPreca7)
    End Sub

    Private Sub TxPar8_Valida(edicion As System.Boolean) Handles TxPar8.Valida
        ValidaPartida(edicion, TxPar8.Text, 8, TxPar8, TxLote8, TxBul8, TxPreca8)
    End Sub
    Private Sub TxPar9_Valida(edicion As System.Boolean) Handles TxPar9.Valida
        ValidaPartida(edicion, TxPar9.Text, 9, TxPar9, TxLote9, TxBul9, TxPreca9)
    End Sub
    Private Sub TxPar10_Valida(edicion As System.Boolean) Handles TxPar10.Valida
        ValidaPartida(edicion, TxPar10.Text, 10, TxPar10, TxLote10, TxBul10, TxPreca10)
    End Sub
    Private Sub TxPar11_Valida(edicion As System.Boolean) Handles TxPar11.Valida
        ValidaPartida(edicion, TxPar11.Text, 11, TxPar11, TxLote11, TxBul11, TxPreca11)
    End Sub

    Private Sub TxPar12_Valida(edicion As System.Boolean) Handles TxPar12.Valida
        ValidaPartida(edicion, TxPar12.Text, 12, TxPar12, TxLote12, TxBul12, TxPreca12)
    End Sub


    Private Sub TxPreca1_Valida(edicion As Boolean) Handles TxPreca1.Valida
        ValidaPartida(edicion, TxPar1.Text, 1, TxPar1, TxLote1, TxBul1, TxPreca1)
    End Sub

    Private Sub TxPreca2_Valida(edicion As Boolean) Handles TxPreca2.Valida
        ValidaPartida(edicion, TxPar2.Text, 2, TxPar2, TxLote2, TxBul2, TxPreca2)
    End Sub

    Private Sub TxPreca3_Valida(edicion As Boolean) Handles TxPreca3.Valida
        ValidaPartida(edicion, TxPar3.Text, 3, TxPar3, TxLote3, TxBul3, TxPreca3)
    End Sub

    Private Sub TxPreca4_Valida(edicion As Boolean) Handles TxPreca4.Valida
        ValidaPartida(edicion, TxPar4.Text, 4, TxPar4, TxLote4, TxBul4, TxPreca4)
    End Sub

    Private Sub TxPreca5_Valida(edicion As Boolean) Handles TxPreca5.Valida
        ValidaPartida(edicion, TxPar5.Text, 5, TxPar5, TxLote5, TxBul5, TxPreca5)
    End Sub

    Private Sub TxPreca6_Valida(edicion As Boolean) Handles TxPreca6.Valida
        ValidaPartida(edicion, TxPar6.Text, 6, TxPar6, TxLote6, TxBul6, TxPreca6)
    End Sub

    Private Sub TxPreca7_Valida(edicion As Boolean) Handles TxPreca7.Valida
        ValidaPartida(edicion, TxPar7.Text, 7, TxPar7, TxLote7, TxBul7, TxPreca7)
    End Sub

    Private Sub TxPreca8_Valida(edicion As Boolean) Handles TxPreca8.Valida
        ValidaPartida(edicion, TxPar8.Text, 8, TxPar8, TxLote8, TxBul8, TxPreca8)
    End Sub

    Private Sub TxPreca9_Valida(edicion As Boolean) Handles TxPreca9.Valida
        ValidaPartida(edicion, TxPar9.Text, 9, TxPar9, TxLote9, TxBul9, TxPreca9)
    End Sub

    Private Sub TxPreca10_Valida(edicion As Boolean) Handles TxPreca10.Valida
        ValidaPartida(edicion, TxPar10.Text, 10, TxPar10, TxLote10, TxBul10, TxPreca10)
    End Sub

    Private Sub TxPreca11_Valida(edicion As Boolean) Handles TxPreca11.Valida
        ValidaPartida(edicion, TxPar11.Text, 11, TxPar11, TxLote11, TxBul11, TxPreca11)
    End Sub

    Private Sub TxPreca12_Valida(edicion As Boolean) Handles TxPreca12.Valida
        ValidaPartida(edicion, TxPar12.Text, 12, TxPar12, TxLote12, TxBul12, TxPreca12)
    End Sub


    Private Sub ValidaPartida(edicion As Boolean, NuPartida As String, num As Integer, txPartida As TxDato, Txlote As TxDato, txbulto As TxDato, txpreca As TxDato)

        Dim IdAgricultor As String = ""
        Dim IdGenero As String = ""
        Dim IdCategoria As String = ""
        Dim sKilos As String = ""
        Dim Kilos As Decimal = 0

        Dim Agricultor As String = ""
        Dim Genero As String = ""

        Dim OrdenFinalLinea As Integer = 0


        Dim Campa As String = ""

        Dim Palet As New E_palets(Idusuario, cn)
        If Palet.LeerId(Palets_Lineas.PLL_idpalet.Valor) Then
            Campa = VaInt(Palet.PAL_campa.Valor).ToString
        End If



        If NuPartida.Trim <> "" Then

            Dim id As String = Albentrada_lineas.DatosPartida(Campa, NuPartida, IdAgricultor, IdGenero, IdCategoria, sKilos)

            If Not CompruebaGeneroTrazabilidadPartida(Palets_Lineas.PLL_idgenero.Valor, IdGenero) Then
                MsgBox("El género de la partida no corresponde al género de la línea del palet")
                txPartida.MiError = True
            ElseIf Not CopruebaControladoTraza(Campa) Then
                MsgBox("No se puede introducir una partida, lote o precalibrado no controlado en un palet controlado")
                txPartida.MiError = True
            ElseIf Val(id) > 0 Then
                If Agricultores.LeerId(IdAgricultor) Then
                    Agricultor = Agricultores.AGR_Nombre.Valor
                End If
                If Generos.LeerId(IdGenero) Then
                    Genero = Generos.GEN_NombreGenero.Valor
                End If


                txPartida.MiError = False
                txPartida.Siguiente = txbulto.Orden

            Else
                MsgBox("Partida inexistente")
                txPartida.MiError = True
            End If

        ElseIf Txlote.Text <> "" Then

            Dim idlote As Integer = Lotes.LeerLote(Campa, Txlote.Text)

            If Not CompruebaGeneroTrazabilidadLote(Palets_Lineas.PLL_idgenero.Valor, Lotes) Then
                MsgBox("El género del lote de entrada no corresponde al género de la línea del palet")
                txPartida.MiError = True
            ElseIf Not CopruebaControladoTraza(Campa) Then
                MsgBox("No se puede introducir una partida, lote o precalibrado no controlado en un palet controlado")
                Txlote.MiError = True
            ElseIf idlote > 0 Then
                If Lotes.LeerId(idlote.ToString) = True Then
                    IdGenero = Lotes.LTE_Idgenero.Valor
                    If Generos.LeerId(IdGenero) = True Then
                        Genero = Generos.GEN_NombreGenero.Valor
                    End If
                    Txlote.MiError = False
                    Txlote.Siguiente = txbulto.Orden

                End If
            Else
                MsgBox("Lote inexistente")
                Txlote.MiError = True

            End If

        ElseIf txpreca.Text <> "" Then

            Dim idpreca As Integer = LotesProduccion.LeerLote(Campa, txpreca.Text)

            If Not CompruebaGeneroTrazabilidadPrecalibrado(Palets_Lineas.PLL_idgenero.Valor, LotesProduccion) Then
                MsgBox("El género del precalibrado no corresponde al género de la línea del palet")
                txPartida.MiError = True
            ElseIf Not CopruebaControladoTraza(Campa) Then
                MsgBox("No se puede introducir una partida, lote o precalibrado no controlado en un palet controlado")
                txpreca.MiError = True
            ElseIf idpreca > 0 Then
                If LotesProduccion.LeerId(idpreca.ToString) = True Then
                    IdGenero = LotesProduccion.LPD_Idgenero.Valor
                    If Generos.LeerId(IdGenero) = True Then
                        Genero = Generos.GEN_NombreGenero.Valor
                    End If
                    txpreca.MiError = False

                End If
            Else
                MsgBox("Lote produccion inexistente")
                txpreca.MiError = True

            End If

        End If




        Select Case num

            Case 1
                LbAgri1.Text = Agricultor : LbCodGen1.Text = IdGenero : LbGen1.Text = Genero : OrdenFinalLinea = TxBul1.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul1.Text = ""
            Case 2
                LbAgri2.Text = Agricultor : LbCodGen2.Text = IdGenero : LbGen2.Text = Genero : OrdenFinalLinea = TxBul2.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul2.Text = ""
            Case 3
                LbAgri3.Text = Agricultor : LbCodGen3.Text = IdGenero : LbGen3.Text = Genero : OrdenFinalLinea = TxBul3.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul3.Text = ""
            Case 4
                LbAgri4.Text = Agricultor : LbCodGen4.Text = IdGenero : LbGen4.Text = Genero : OrdenFinalLinea = TxBul4.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul4.Text = ""
            Case 5
                LbAgri5.Text = Agricultor : LbCodGen5.Text = IdGenero : LbGen5.Text = Genero : OrdenFinalLinea = TxBul5.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul5.Text = ""
            Case 6
                LbAgri6.Text = Agricultor : LbCodGen6.Text = IdGenero : LbGen6.Text = Genero : OrdenFinalLinea = TxBul6.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul6.Text = ""
            Case 7
                LbAgri7.Text = Agricultor : LbCodGen7.Text = IdGenero : LbGen7.Text = Genero : OrdenFinalLinea = TxBul7.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul7.Text = ""
            Case 8
                LbAgri8.Text = Agricultor : LbCodGen8.Text = IdGenero : LbGen8.Text = Genero : OrdenFinalLinea = TxBul8.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul8.Text = ""
            Case 9
                LbAgri9.Text = Agricultor : LbCodgen9.Text = IdGenero : LbGen9.Text = Genero : OrdenFinalLinea = TxBul9.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul9.Text = ""
            Case 10
                LbAgri10.Text = Agricultor : LbCodGen10.Text = IdGenero : LbGen10.Text = Genero : OrdenFinalLinea = TxBul10.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul10.Text = ""
            Case 11
                LbAgri11.Text = Agricultor : LbCodGen11.Text = IdGenero : LbGen11.Text = Genero : OrdenFinalLinea = TxBul11.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul11.Text = ""
            Case 12
                LbAgri12.Text = Agricultor : LbCodgen12.Text = IdGenero : LbGen12.Text = Genero : OrdenFinalLinea = TxBul12.Orden : If NuPartida.Trim = "" And Txlote.Text = "" And txpreca.Text = "" Then TxBul12.Text = ""

        End Select


    End Sub


    Private Function CopruebaControladoTraza(Campa As String) As Boolean

        Dim bRes As Boolean = True

        If _bLineaControlada Then

            If Not EsControlado(Campa, TxPar1.Text, TxLote1.Text, TxPreca1.Text) Then
                bRes = False
            ElseIf Not EsControlado(Campa, TxPar2.Text, TxLote2.Text, TxPreca2.Text) Then
                bRes = False
            ElseIf Not EsControlado(Campa, TxPar3.Text, TxLote3.Text, TxPreca3.Text) Then
                bRes = False
            ElseIf Not EsControlado(Campa, TxPar4.Text, TxLote4.Text, TxPreca4.Text) Then
                bRes = False
            ElseIf Not EsControlado(Campa, TxPar5.Text, TxLote5.Text, TxPreca5.Text) Then
                bRes = False
            ElseIf Not EsControlado(Campa, TxPar6.Text, TxLote6.Text, TxPreca6.Text) Then
                bRes = False
            ElseIf Not EsControlado(Campa, TxPar7.Text, TxLote7.Text, TxPreca7.Text) Then
                bRes = False
            ElseIf Not EsControlado(Campa, TxPar8.Text, TxLote8.Text, TxPreca8.Text) Then
                bRes = False
            ElseIf Not EsControlado(Campa, TxPar9.Text, TxLote9.Text, TxPreca9.Text) Then
                bRes = False
            ElseIf Not EsControlado(Campa, TxPar10.Text, TxLote10.Text, TxPreca10.Text) Then
                bRes = False
            ElseIf Not EsControlado(Campa, TxPar11.Text, TxLote11.Text, TxPreca11.Text) Then
                bRes = False
            ElseIf Not EsControlado(Campa, TxPar12.Text, TxLote12.Text, TxPreca12.Text) Then
                bRes = False
            End If

        End If


        Return bRes

    End Function


    Private Function EsControlado(Campa As String, Partida As String, NumLote As String, NumLoteProduccion As String) As Boolean


        If Partida.Trim = "" And NumLote.Trim = "" And NumLoteProduccion.Trim = "" Then
            'línea vacía
            Return True
        End If



        Dim bRes As Boolean = False


        Dim Controlado As String = ""


        If VaInt(Partida) > 0 Then

            Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
            Dim Id As Integer = AlbEntrada_Lineas.LeerMuestreo(Campa, Partida)
            If Id > 0 Then
                If AlbEntrada_Lineas.LeerId(Id) Then
                    Controlado = (AlbEntrada_Lineas.AEL_Controlado.Valor & "").Trim.ToUpper
                End If
            End If

        ElseIf VaInt(NumLote) > 0 Then

            Dim Lotes As New E_Lotes(Idusuario, cn)
            If Lotes.LeerLote(Campa, NumLote) Then
                Controlado = (Lotes.LTE_Controlado.Valor & "").Trim.ToUpper
            End If

        ElseIf VaInt(NumLoteProduccion) > 0 Then

            Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
            If LotesProduccion.LeerLote(Campa, NumLoteProduccion) Then
                Controlado = (LotesProduccion.LPD_Controlado.Valor & "").Trim.ToUpper
            End If

        End If



        If Controlado = "S" Then
            bRes = True
        End If



        Return bRes

    End Function


    Private Sub TxLote1_Valida(edicion As Boolean) Handles TxLote1.Valida
        ValidaPartida(edicion, TxPar1.Text, 1, TxPar1, TxLote1, TxBul1, TxPreca1)
    End Sub


    Private Sub TxLote2_Valida(edicion As Boolean) Handles TxLote2.Valida
        ValidaPartida(edicion, TxPar2.Text, 2, TxPar2, TxLote2, TxBul2, TxPreca2)
    End Sub


    Private Sub TxLote12_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxLote12.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            BGuardar.Select()
            BGuardar.Focus()
        End If
    End Sub


    Private Sub TxLote3_Valida(edicion As Boolean) Handles TxLote3.Valida
        ValidaPartida(edicion, TxPar3.Text, 3, TxPar3, TxLote3, TxBul3, TxPreca3)
    End Sub


    Private Sub TxLote4_Valida(edicion As Boolean) Handles TxLote4.Valida
        ValidaPartida(edicion, TxPar4.Text, 4, TxPar4, TxLote4, TxBul4, TxPreca4)
    End Sub


    Private Sub TxLote5_Valida(edicion As Boolean) Handles TxLote5.Valida
        ValidaPartida(edicion, TxPar5.Text, 5, TxPar5, TxLote5, TxBul5, TxPreca5)
    End Sub


    Private Sub TxLote6_Valida(edicion As Boolean) Handles TxLote6.Valida
        ValidaPartida(edicion, TxPar6.Text, 6, TxPar6, TxLote6, TxBul6, TxPreca6)
    End Sub


    Private Sub TxLote7_Valida(edicion As Boolean) Handles TxLote7.Valida
        ValidaPartida(edicion, TxPar7.Text, 7, TxPar7, TxLote7, TxBul7, TxPreca7)
    End Sub


    Private Sub TxLote8_Valida(edicion As Boolean) Handles TxLote8.Valida
        ValidaPartida(edicion, TxPar8.Text, 8, TxPar8, TxLote8, TxBul8, TxPreca8)
    End Sub


    Private Sub TxLote9_Valida(edicion As Boolean) Handles TxLote9.Valida
        ValidaPartida(edicion, TxPar9.Text, 9, TxPar9, TxLote9, TxBul9, TxPreca9)
    End Sub


    Private Sub TxLote10_Valida(edicion As Boolean) Handles TxLote10.Valida
        ValidaPartida(edicion, TxPar10.Text, 10, TxPar10, TxLote10, TxBul10, TxPreca10)
    End Sub


    Private Sub TxLote11_Valida(edicion As Boolean) Handles TxLote11.Valida
        ValidaPartida(edicion, TxPar11.Text, 11, TxPar11, TxLote11, TxBul11, TxPreca11)
    End Sub

    Private Sub TxLote12_Valida(edicion As Boolean) Handles TxLote12.Valida
        ValidaPartida(edicion, TxPar12.Text, 12, TxPar12, TxLote12, TxBul12, TxPreca12)
    End Sub

End Class