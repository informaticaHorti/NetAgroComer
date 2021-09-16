Public Class FrmModProduccion


    Inherits FrMantenimiento
    Dim Produccion As New E_Produccion(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim Lineas As New E_Lineas(Idusuario, cn)
    Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Lotes As New E_Lotes(Idusuario, cn)
    Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)






    Private Sub ParametrosFrm()
        EntidadFrm = Produccion


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxNumero, Produccion.PRD_Id, LbNumero, True)
        CampoClave = 0 ' ultimo campo de la clave
        TxNumero.Autonumerico = True

        ParamTx(TxFecha, Produccion.PRD_Fecha, LbFecha, True)
        ParamTx(TxAlmacen, Produccion.PRD_IdCentro, LbAlmcen, True)
        ParamTx(TxLinea, Produccion.PRD_IdLinea, LbLinea, True)
        ParamTx(TxPLC, Nothing, LbPartidaLote, True, , , , "PLC")
        ParamTx(TxNuparlote, Nothing, LbNuParlote, True)
        ParamTx(TxKilosLinea, Produccion.PRD_KilosLinea, LbKilosLinea)
        ParamTx(TxKilosconsu, Produccion.PRD_KilosConsumidos, LbKilosConsu)
        ParamTx(TxInicio, Produccion.PRD_HoraInicio, LbInicio)
        ParamTx(TxFinal, Produccion.PRD_HoraFinal, LbFin)


        AsociarControles(TxNumero, BtBuscaProduc, Produccion.btBusca, EntidadFrm)
        AsociarControles(TxAlmacen, BtBuscaAlm, PuntoVenta.btBusca, PuntoVenta, PuntoVenta.Nombre, LbNomAlmacen)
        AsociarControles(TxLinea, BtBuscaLinea, Lineas.btBusca, Lineas, Lineas.LIN_Nombre, LbNomLinea)





        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub
    Public Overrides Sub ControlClave()
        ' componemos la clave

        LbId.Text = TxNumero.Text


    End Sub
    Public Overrides Sub Guardar()

        If LbId.Text = "+" Then
            LbId.Text = Produccion.MaxId
            TxNumero.Text = LbId.Text
        End If


        Produccion.PRD_IdLineaEntrada.Valor = "0"
        Produccion.PRD_IdLote.Valor = "0"

        Select Case TxPLC.Text

            Case "P"
                Dim ID As Integer = Albentrada_lineas.LeerMuestreo(MiMaletin.Ejercicio, TxNuparlote.Text)
                Produccion.PRD_IdLineaEntrada.Valor = ID

            Case "L"
                Dim ID As Integer = Lotes.LeerLote(MiMaletin.Ejercicio, TxNuparlote.Text)
                Produccion.PRD_IdLote.Valor = ID

            Case "C"
                Dim ID As Integer = LotesProduccion.LeerLote(MiMaletin.Ejercicio, TxNuparlote.Text)
                Produccion.PRD_IdLoteProduccion.Valor = ID

        End Select


        MyBase.Guardar()

    End Sub



    Public Overrides Sub Entidad_a_Datos()


        Dim id As Integer = VaInt(Produccion.PRD_IdLineaEntrada.Valor)

        If id > 0 Then
            TxPLC.Text = "P"
            If Albentrada_lineas.LeerId(id) = True Then
                TxNuparlote.Text = Albentrada_lineas.AEL_muestreo.Valor
                TxNuparlote_Valida(False)
            End If
        End If

        id = VaInt(Produccion.PRD_IdLote.Valor)
        If id > 0 Then
            TxPLC.Text = "L"
            If Lotes.LeerId(id) = True Then
                TxNuparlote.Text = Lotes.LTE_Lote.Valor
                TxNuparlote_Valida(False)
            End If
        End If

        id = VaInt(Produccion.PRD_IdLoteProduccion.Valor)
        If id > 0 Then
            TxPLC.Text = "C"
            If LotesProduccion.LeerId(id) = True Then
                TxNuparlote.Text = LotesProduccion.LPD_Lote.Valor
                TxNuparlote_Valida(False)
            End If
        End If


        MyBase.Entidad_a_Datos()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Private Sub TxPartidaLote_Valida(edicion As Boolean) Handles TxPLC.Valida

        If TxPLC.Text <> "L" And TxPLC.Text <> "C" Then
            TxPLC.Text = "P"
        End If

        'Select Case TxPartidaLote.Text
        '    Case "P"
        '        TxIdPartidaLote.ClParam.CampoBd = Produccion.PRD_IdLineaEntrada
        '        AsociarControles(TxIdPartidaLote, BtBuscaPartida, Albentrada_lineas.btBusca, Albentrada_lineas, Albentrada_lineas.AEL_muestreo, LbNomIdPartidaLote)

        '    Case "L"
        '        TxIdPartidaLote.ClParam.CampoBd = Produccion.PRD_IdLote
        '        AsociarControles(TxIdPartidaLote, BtBuscaPartida, Lotes.btBusca, Lotes, Lotes.LTE_Lote, LbNomIdPartidaLote)
        '        BtBuscaPartida.CL_EsId = False

        'End Select

    End Sub



    Private Sub TxNuparlote_Valida(edicion As Boolean) Handles TxNuparlote.Valida

        Select Case TxPLC.Text

            Case "P"
                Dim ID As Integer = Albentrada_lineas.LeerMuestreo(MiMaletin.Ejercicio, TxNuparlote.Text)
                If ID = 0 Then
                    MsgBox("Partida inexistente")
                Else
                    If Albentrada_lineas.LeerId(ID.ToString) = True Then
                        If Generos.LeerId(Albentrada_lineas.AEL_idgenero.Valor) = True Then
                            LbNomPartida.Text = Generos.GEN_NombreGenero.Valor
                        End If
                    End If
                End If

            Case "L"
                Dim ID As Integer = Lotes.LeerLote(MiMaletin.Ejercicio, TxNuparlote.Text)
                If ID = 0 Then
                    MsgBox("Lote inexistente")
                Else
                    If Lotes.LeerId(ID.ToString) = True Then
                        If Generos.LeerId(Lotes.LTE_Idgenero.Valor) = True Then
                            LbNomPartida.Text = Generos.GEN_NombreGenero.Valor
                        End If
                    End If
                End If

            Case "C"
                Dim ID As Integer = LotesProduccion.LeerLote(MiMaletin.Ejercicio, TxNuparlote.Text)
                If ID = 0 Then
                    MsgBox("Precalibrado inexistente")
                Else
                    If LotesProduccion.LeerId(ID.ToString) = True Then
                        If Generos.LeerId(LotesProduccion.LPD_Idgenero.Valor) = True Then
                            LbNomPartida.Text = Generos.GEN_NombreGenero.Valor
                        End If
                    End If
                End If

        End Select
    End Sub




    Private Sub BtBuscaPartidaLote_Click(sender As System.Object, e As System.EventArgs) Handles BtBuscaPartidaLote.Click

        If TxNuparlote.Enabled Then

            BuscaPartidaLote()

        End If

    End Sub

    Private Sub TxNuparlote_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxNuparlote.KeyDown

        If e.KeyCode = Keys.F2 Then
            BuscaPartidaLote()
        End If

    End Sub

    Private Sub BuscaPartidaLote()

        Dim FrBuscaAlb As FrBuscaAlb
        Dim BtBusca As BtBusca


        Select Case TxPLC.Text

            Case "P"
                FrBuscaAlb = New FrBuscaAlb("Partidas")
                BtBusca = Albentrada_lineas.btBusca
                FrBuscaAlb.InitCodigo(BtBusca.CL_ConsultaSql, Albentrada_lineas, BtBusca.CL_campocodigo, BtBusca.CL_camponombre, BtBusca.CL_dfecha, BtBusca.CL_hfecha, BtBusca.CL_ParamBusqueda, Nothing)
                FrBuscaAlb.ShowDialog()

            Case "L"
                FrBuscaAlb = New FrBuscaAlb("Lotes")
                BtBusca = Lotes.btBusca
                FrBuscaAlb.InitCodigo(BtBusca.CL_ConsultaSql, Lotes, BtBusca.CL_campocodigo, BtBusca.CL_camponombre, BtBusca.CL_dfecha, BtBusca.CL_hfecha, BtBusca.CL_ParamBusqueda, Nothing)
                FrBuscaAlb.ShowDialog()

            Case "C"
                FrBuscaAlb = New FrBuscaAlb("Precalibrado")
                BtBusca = LotesProduccion.btBusca
                FrBuscaAlb.InitCodigo(BtBusca.CL_ConsultaSql, LotesProduccion, BtBusca.CL_campocodigo, BtBusca.CL_camponombre, BtBusca.CL_dfecha, BtBusca.CL_hfecha, BtBusca.CL_ParamBusqueda, Nothing)
                FrBuscaAlb.ShowDialog()

        End Select



        If Not BuscarRow Is Nothing Then

            Try
                Select Case TxPLC.Text
                    Case "P"
                        TxNuparlote.Text = BuscarRow("Partida").ToString
                    Case "L"
                        TxNuparlote.Text = BuscarRow("Lote").ToString
                    Case "C"
                        TxNuparlote.Text = BuscarRow("Lote").ToString
                End Select


            Catch ex As Exception
                TxNuparlote.Text = ""
            End Try


            TxNuparlote.Validar(True)
            If Not TxNuparlote.MiError Then
                TxKilosLinea.Select()
                TxKilosLinea.Focus()
            End If

        End If

    End Sub

    Private Sub TxNuparlote_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxNuparlote.EnabledChanged
        BtBuscaPartidaLote.Enabled = TxNuparlote.Enabled
    End Sub

    Private Sub TxInicio_Valida(edicion As System.Boolean) Handles TxInicio.Valida
        If edicion Then

            Dim inicio As String = Now.ToString("dd/MM/yyyy") & " " & TxInicio.Text
            Dim finicio As DateTime

            If Not DateTime.TryParse(inicio, finicio) Then
                MsgBox("Formato de hora incorrecto. El formato debe ser 'HH:mm:ss' (hora con dos dígitos, minutos con dos dígitos, segundos con dos dígitos)")
                TxInicio.MiError = True
            Else
                TxInicio.Text = finicio.ToString("HH:mm:ss")
            End If


        End If
    End Sub

    Private Sub TxFinal_Valida(edicion As System.Boolean) Handles TxFinal.Valida

        If edicion Then

            Dim final As String = Now.ToString("dd/MM/yyyy") & " " & TxFinal.Text
            Dim ffinal As DateTime

            If Not DateTime.TryParse(final, ffinal) Then
                MsgBox("Formato de hora incorrecto. El formato debe ser 'HH:mm:ss' (hora con dos dígitos, minutos con dos dígitos, segundos con dos dígitos)")
                TxInicio.MiError = True
            Else
                TxFinal.Text = ffinal.ToString("HH:mm:ss")
            End If



        End If

    End Sub
End Class