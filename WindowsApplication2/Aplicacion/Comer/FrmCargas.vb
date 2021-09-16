Imports DevExpress.XtraEditors.Controls

Public Class FrmCargas

    Inherits FrMantenimiento
    Dim Cargas As New E_Cargas(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Cargadores As New E_Cargadores(Idusuario, cn)
    Dim Conceptosinspeccion As New E_ConceptosInspeccion(Idusuario, cn)
    Dim ConceptosTransporte As New E_ConceptosTransporte(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Pedidos As New E_Pedidos(Idusuario, cn)
    Dim Albsalida As New E_AlbSalida(Idusuario, cn)
    Dim Albsalida_palets As New E_albsalida_palets(Idusuario, cn)
    Dim cargas_inspeccion As New E_Cargas_inspeccion(Idusuario, cn)
    Dim cargas_palets As New E_Cargas_Palets(Idusuario, cn)
    Dim Palets_lineas As New E_palets_lineas(Idusuario, cn)
    Dim Palets As New E_palets(Idusuario, cn)
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)

    Dim Idpedido(6) As Integer
    Dim IdAlbsalida(6) As Integer

    Dim dtg As New DataTable

    Dim _Derecha As Boolean
    Dim _bGuardado As Boolean = False


    Private Sub ParametrosFrm()
        EntidadFrm = Cargas


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxCarga, Cargas.CAR_Numero, LbCarga, True)
        CampoClave = 0 ' ultimo campo de la clave
        TxCarga.Autonumerico = True
        ParamTx(TxFecha, Cargas.CAR_Fecha, LbFecha, True)
        ParamTx(TxTransportista, Cargas.CAR_IdTransportista, LbTransportista, False)
        ParamTx(TxMatricula, Cargas.CAR_Matricula, LbMatricula, False)
        ParamTx(TxIdConcepto, Cargas.CAR_IdConcepto, LbConcepto, False)
        ParamTx(TxConcepto, Cargas.CAR_Concepto, LbConcepto, False)
        ParamTx(TxReparto, Cargas.CAR_Reparto, LbReparto, False)
        ParamTx(TxTemperatura, Cargas.CAR_Temperatura, LbTemperatura, False)
        ParamTx(TxCargador, Cargas.CAR_IdCargador, LbCargador, True)
        ParamTx(TxPedido1, Nothing, LbPedido, False, Cdatos.TiposCampo.EnteroPositivo, 0, 7)
        ParamTx(TxPedido2, Nothing, LbPedido, False, Cdatos.TiposCampo.EnteroPositivo, 0, 7)
        ParamTx(TxPedido3, Nothing, LbPedido, False, Cdatos.TiposCampo.EnteroPositivo, 0, 7)
        ParamTx(TxPedido4, Nothing, LbPedido, False, Cdatos.TiposCampo.EnteroPositivo, 0, 7)
        ParamTx(TxPedido5, Nothing, LbPedido, False, Cdatos.TiposCampo.EnteroPositivo, 0, 7)
        ParamTx(TxPedido6, Nothing, LbPedido, False, Cdatos.TiposCampo.EnteroPositivo, 0, 7)


        AsociarControles(TxCarga, BtBuscaCarga, Cargas.btBusca, EntidadFrm)
        AsociarControles(TxTransportista, BtBuscaTransportista, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomTransportista)
        BtBuscaTransportista.CL_Filtro = "TIPO='PV'"

        AsociarControles(TxIdConcepto, BtBuscaConcepto, ConceptosTransporte.btBusca, ConceptosTransporte)
        AsociarControles(TxCargador, BtBuscaCargador, Cargadores.btBusca, Cargadores, Cargadores.CGR_Nombre, LbNomCargador)

        BGuardar.Visible = False
        BAnular.Visible = False


        BTaux1.Visible = True
        BTaux1.Text = "PEDIDOS"

        BtAux2.Visible = True
        BtAux2.Text = "Guardar"



        dtg.Columns.Add("idgensal", GetType(System.Int32))
        dtg.Columns.Add("idcat", GetType(System.Int32))
        dtg.Columns.Add("idmarca", GetType(System.Int32))
        dtg.Columns.Add("Genero", GetType(System.String))
        dtg.Columns.Add("Categoria", GetType(System.String))
        dtg.Columns.Add("Marca", GetType(System.String))
        dtg.Columns.Add("PED", GetType(System.Int32))
        dtg.Columns.Add("CAR", GetType(System.Int32))
        dtg.Columns.Add("DIF", GetType(System.Int32))


    End Sub


    Public Sub InitMuelle(Nmuelle As Integer, Derecha As Boolean)

        LbMuelle.Text = Nmuelle.ToString
        _Derecha = Derecha

    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        Dim i As Integer


        If TxCarga.Text = "+" Then
            LbId.Text = "+"
        Else
            i = Cargas.LeerCarga(MiMaletin.Ejercicio, CInt(TxCarga.Text))
            If i > 0 Then
                LbId.Text = i.ToString


            Else
                LbId.Text = "+"
            End If

        End If

    End Sub


    Public Overrides Sub Guardar()

        GuardaDatos()
        GrabarInspeccion()
        ActualizarTransportista()

        MyBase.Guardar()

    End Sub


    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()
        If VaInt(LbId.Text) > 0 Then
            cargarPedidos()
            CargaInspeccionCarga()
            NumeroPalets()
        End If
    End Sub


    Private Sub cargarPedidos()

        Dim i As Integer
        Dim consulta As New Cdatos.E_select

        For i = 1 To 6
            Idpedido(i) = 0
            IdAlbsalida(i) = 0
        Next
        IdAlbsalida(1) = VaInt(Cargas.CAR_idalbaran1.Valor)
        IdAlbsalida(2) = VaInt(Cargas.CAR_idalbaran2.Valor)
        IdAlbsalida(3) = VaInt(Cargas.CAR_idalbaran3.Valor)
        IdAlbsalida(4) = VaInt(Cargas.CAR_idalbaran4.Valor)
        IdAlbsalida(5) = VaInt(Cargas.CAR_idalbaran5.Valor)
        IdAlbsalida(6) = VaInt(Cargas.CAR_idalbaran6.Valor)

        If VaInt(Cargas.CAR_idpedido1.Valor) > 0 Then
            If Pedidos.LeerId(Cargas.CAR_idpedido1.Valor) = True Then
                TxPedido1.Text = Pedidos.PED_pedido.Valor
                ValidaPedido(1, TxPedido1)
            Else
                Idpedido(1) = 0
            End If
        End If
        If VaInt(Cargas.CAR_idalbaran1.Valor) > 0 Then
            If Albsalida.LeerId(Cargas.CAR_idalbaran1.Valor) = True Then
                LbAlbaran1.Text = Albsalida.ASA_albaran.Valor
            Else
                IdAlbsalida(1) = 0
            End If
        End If

        If VaInt(Cargas.CAR_idpedido2.Valor) > 0 Then
            If Pedidos.LeerId(Cargas.CAR_idpedido2.Valor) = True Then
                TxPedido2.Text = Pedidos.PED_pedido.Valor
                ValidaPedido(2, TxPedido2)
            Else
                Idpedido(2) = 0
            End If
        End If
        If VaInt(Cargas.CAR_idalbaran2.Valor) > 0 Then
            If Albsalida.LeerId(Cargas.CAR_idalbaran2.Valor) = True Then
                LbAlbaran2.Text = Albsalida.ASA_albaran.Valor
            Else
                IdAlbsalida(2) = 0
            End If
        End If


        If VaInt(Cargas.CAR_idpedido3.Valor) > 0 Then
            If Pedidos.LeerId(Cargas.CAR_idpedido3.Valor) = True Then
                TxPedido3.Text = Pedidos.PED_pedido.Valor
                ValidaPedido(3, TxPedido3)
            Else
                Idpedido(3) = 0
            End If
        End If
        If VaInt(Cargas.CAR_idalbaran3.Valor) > 0 Then
            If Albsalida.LeerId(Cargas.CAR_idalbaran3.Valor) = True Then
                LbAlbaran3.Text = Albsalida.ASA_albaran.Valor
            Else
                IdAlbsalida(3) = 0
            End If
        End If


        If VaInt(Cargas.CAR_idpedido4.Valor) > 0 Then
            If Pedidos.LeerId(Cargas.CAR_idpedido4.Valor) = True Then
                TxPedido4.Text = Pedidos.PED_pedido.Valor
                ValidaPedido(4, TxPedido4)
            Else
                Idpedido(4) = 0
            End If
        End If
        If VaInt(Cargas.CAR_idalbaran4.Valor) > 0 Then
            If Albsalida.LeerId(Cargas.CAR_idalbaran4.Valor) = True Then
                LbAlbaran4.Text = Albsalida.ASA_albaran.Valor
            Else
                IdAlbsalida(4) = 0
            End If
        End If

        If VaInt(Cargas.CAR_idpedido5.Valor) > 0 Then
            If Pedidos.LeerId(Cargas.CAR_idpedido5.Valor) = True Then
                TxPedido5.Text = Pedidos.PED_pedido.Valor
                ValidaPedido(5, TxPedido5)
            Else
                Idpedido(5) = 0
            End If
        End If
        If VaInt(Cargas.CAR_idalbaran5.Valor) > 0 Then
            If Albsalida.LeerId(Cargas.CAR_idalbaran5.Valor) = True Then
                LbAlbaran5.Text = Albsalida.ASA_albaran.Valor
            Else
                IdAlbsalida(5) = 0
            End If
        End If

        If VaInt(Cargas.CAR_idpedido6.Valor) > 0 Then
            If Pedidos.LeerId(Cargas.CAR_idpedido6.Valor) = True Then
                TxPedido6.Text = Pedidos.PED_pedido.Valor
                ValidaPedido(6, TxPedido6)
            Else
                Idpedido(6) = 0
            End If
        End If
        If VaInt(Cargas.CAR_idalbaran6.Valor) > 0 Then
            If Albsalida.LeerId(Cargas.CAR_idalbaran6.Valor) = True Then
                LbAlbaran6.Text = Albsalida.ASA_albaran.Valor
            Else
                IdAlbsalida(6) = 0
            End If
        End If





    End Sub


    Private Sub NumeroPalets()
        Dim totalpalets As Integer = 0
        For i = 1 To 6
            If IdAlbsalida(i) > 0 Then
                Dim np As Integer = PaletsCargados(IdAlbsalida(i))
                Select Case i
                    Case 1
                        LbPalet1.Text = np.ToString
                    Case 2
                        LbPalet2.Text = np.ToString
                    Case 3
                        LbPalet3.Text = np.ToString
                    Case 4
                        LbPalet4.Text = np.ToString
                    Case 5
                        LbPalet5.Text = np.ToString
                    Case 6
                        LbPalet6.Text = np.ToString
                End Select
                totalpalets = totalpalets + np
            End If
        Next
        LbNumPaletTotal.Text = totalpalets.ToString
    End Sub
    Private Function PaletsCargados(idalbaran) As Integer
        Dim ret As Integer
        Dim sql As String
        Dim dt As New DataTable

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Palets_lineas.PLL_idpalet, "idpalet")
        consulta.SelCampo(Palets.PAL_palet, "Palet", Palets_lineas.PLL_idpalet)
        consulta.SelCampo(Albsalida_palets.ASP_IdAlbaran, "idalbaran", Palets.PAL_idpalet, Albsalida_palets.ASP_Idpalet)
        consulta.WheCampo(Albsalida_palets.ASP_IdAlbaran, "=", idalbaran.ToString)
        sql = consulta.SQL + " order by PAL_PALET "
        dt = Palets_lineas.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            Dim A As Integer = 0
            For Each RW In dt.Rows
                If VaInt(RW("idpalet")) <> A Then
                    ret = ret + 1
                End If
                A = VaInt(RW("idpalet"))
            Next
        End If

        Return ret


    End Function

    Private Sub GrabarInspeccion()

        If Val(LbId.Text) > 0 Then
            BorrarInspeccion()

            For Each rw In GridViewInspec.DataSource
                cargas_inspeccion.VaciaEntidad()
                Dim id As Integer = cargas_inspeccion.MaxId
                cargas_inspeccion.CGI_id.Valor = id
                cargas_inspeccion.CGI_idcarga.Valor = LbId.Text
                cargas_inspeccion.CGI_idinspeccion.Valor = rw("id").ToString
                If rw("X") = True Then
                    cargas_inspeccion.CGI_sn.Valor = "S"
                Else
                    cargas_inspeccion.CGI_sn.Valor = "N"
                End If
                cargas_inspeccion.Insertar()

            Next
        End If



    End Sub


    Private Sub ActualizarTransportista()

        Dim IdPedido1 As String = (Cargas.CAR_idpedido1.Valor & "").Trim
        Dim IdPedido2 As String = (Cargas.CAR_idpedido2.Valor & "").Trim
        Dim IdPedido3 As String = (Cargas.CAR_idpedido3.Valor & "").Trim
        Dim IdPedido4 As String = (Cargas.CAR_idpedido4.Valor & "").Trim
        Dim IdPedido5 As String = (Cargas.CAR_idpedido5.Valor & "").Trim
        Dim IdPedido6 As String = (Cargas.CAR_idpedido6.Valor & "").Trim

        Dim IdAlbaran1 As String = (Cargas.CAR_idalbaran1.Valor & "").Trim
        Dim IdAlbaran2 As String = (Cargas.CAR_idalbaran2.Valor & "").Trim
        Dim IdAlbaran3 As String = (Cargas.CAR_idalbaran3.Valor & "").Trim
        Dim IdAlbaran4 As String = (Cargas.CAR_idalbaran4.Valor & "").Trim
        Dim IdAlbaran5 As String = (Cargas.CAR_idalbaran5.Valor & "").Trim
        Dim IdAlbaran6 As String = (Cargas.CAR_idalbaran6.Valor & "").Trim

        ActualizaTransportistaPedido(IdPedido1, TxTransportista.Text)
        ActualizaTransportistaPedido(IdPedido2, TxTransportista.Text)
        ActualizaTransportistaPedido(IdPedido3, TxTransportista.Text)
        ActualizaTransportistaPedido(IdPedido4, TxTransportista.Text)
        ActualizaTransportistaPedido(IdPedido5, TxTransportista.Text)
        ActualizaTransportistaPedido(IdPedido6, TxTransportista.Text)

        ActualizaTransportistaAlbaran(IdAlbaran1, TxTransportista.Text)
        ActualizaTransportistaAlbaran(IdAlbaran2, TxTransportista.Text)
        ActualizaTransportistaAlbaran(IdAlbaran3, TxTransportista.Text)
        ActualizaTransportistaAlbaran(IdAlbaran4, TxTransportista.Text)
        ActualizaTransportistaAlbaran(IdAlbaran5, TxTransportista.Text)
        ActualizaTransportistaAlbaran(IdAlbaran6, TxTransportista.Text)

    End Sub

    Private Sub ActualizaTransportistaPedido(ByVal IdPedido As String, ByVal IdTransportista As String)

        If VaDec(IdPedido) > 0 Then

            Dim Pedidos As New E_Pedidos(Idusuario, cn)
            If Pedidos.LeerId(IdPedido) Then
                Pedidos.PED_idtransportista.Valor = IdTransportista
                Pedidos.Actualizar()
            End If

        End If

    End Sub

    Private Sub ActualizaTransportistaAlbaran(ByVal IdAlbaran As String, ByVal IdTransportista As String)

        If VaDec(IdAlbaran) > 0 Then

            Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
            If AlbSalida.LeerId(IdAlbaran) Then
                AlbSalida.ASA_idtransportista.Valor = IdTransportista
                AlbSalida.Actualizar()
            End If

        End If

    End Sub


    Private Sub BorrarInspeccion()

        If VaInt(LbId.Text) > 0 Then
            Dim sql As String
            sql = "Delete from cargas_inspeccion where CGI_idcarga=" + LbId.Text
            cargas_inspeccion.MiConexion.OrdenSql(sql)
        End If
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        _bGuardado = True


        If _Derecha = True Then
            Me.Left = Me.Width + 1
            Me.Top = 1
        Else
            Me.Left = 0
            Me.Top = 1
        End If



        Dim i As Integer
        For i = 1 To 6
            Idpedido(i) = 0
            IdAlbsalida(i) = 0
        Next

        LbAlbaran1.Text = ""
        LbCliente1.Text = ""
        LbPalet1.Text = ""


        LbAlbaran2.Text = ""
        LbCliente2.Text = ""
        LbPalet2.Text = ""

        LbAlbaran3.Text = ""
        LbCliente3.Text = ""
        LbPalet3.Text = ""

        LbAlbaran4.Text = ""
        LbCliente4.Text = ""
        LbPalet4.Text = ""

        LbAlbaran5.Text = ""
        LbCliente5.Text = ""
        LbPalet5.Text = ""

        LbAlbaran6.Text = ""
        LbCliente6.Text = ""
        LbPalet6.Text = ""

        CargaInspeccionDefecto()
        Grid.DataSource = Nothing
        LbNumPaletAlbaran.Text = ""
        LbNumPaletTotal.Text = ""


    End Sub



    Private Sub CargaInspeccionCarga()
        If VaInt(LbId.Text) > 0 Then
            Dim dt As New DataTable
            Dim sql As String
            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(cargas_inspeccion.CGI_idinspeccion, "id")
            consulta.SelCampo(Conceptosinspeccion.CIS_Nombre, "Nombre", cargas_inspeccion.CGI_idinspeccion)
            consulta.SelCampo(cargas_inspeccion.CGI_sn, "SN")
            consulta.WheCampo(cargas_inspeccion.CGI_idcarga, "=", LbId.Text)
            sql = consulta.SQL + " order by cgi_idinspeccion "
            dt = Conceptosinspeccion.MiConexion.ConsultaSQL(sql)
            dt.Columns.Add("X", GetType(Boolean))
            Dim S As Boolean
            For Each rw In dt.Rows
                rw("X") = False
                If rw("SN").ToString = "S" Then
                    rw("X") = True
                End If
                S = True
            Next


            GridInspec.DataSource = dt
            AjustaColumnas()

            If S = False Then
                CargaInspeccionDefecto()
            End If
        End If
    End Sub

    Private Sub CargaInspeccionDefecto()
        Dim dt As New DataTable
        Dim sql As String

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Conceptosinspeccion.CIS_Id, "id")
        consulta.SelCampo(Conceptosinspeccion.CIS_Nombre, "Nombre")
        consulta.SelCampo(Conceptosinspeccion.CIS_sn, "sn")

        sql = consulta.SQL + " order by cis_id"
        dt = Conceptosinspeccion.MiConexion.ConsultaSQL(sql)
        dt.Columns.Add("X", GetType(Boolean))

        For Each rw In dt.Rows
            rw("X") = False
            If rw("SN").ToString = "S" Then
                rw("X") = True
            End If
        Next

        GridInspec.DataSource = dt
        AjustaColumnas()
    End Sub


    Private Sub AjustaColumnas()
        GridViewInspec.BestFitColumns()
        GridViewInspec.OptionsView.ShowGroupPanel = False


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewInspec.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "ID"
                    c.Width = 90
                Case "NOMBRE"
                    c.Width = 500
                Case "X"
                    c.Width = 50
                Case Else
                    c.Visible = False
            End Select
        Next


    End Sub

    Private Sub AjustaColumnasPalets()
        GridView1.BestFitColumns()
        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsBehavior.Editable = False



        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "X"
                    c.Width = 90
                Case "GENERO"
                    c.Width = 400
                Case "MARCA"
                    c.Width = 200
                Case "PALET"
                    c.Width = 150
                Case Else
                    c.Visible = False
            End Select
        Next


    End Sub



    Private Sub CargaGridPalets()

        Dim linea As Integer = Rblinea()
       
        If IdAlbsalida(linea) = 0 Then
            Grid.DataSource = Nothing
            LbNumPaletAlbaran.Text = ""
            Exit Sub
        End If

        Dim sql As String
        Dim dt As New DataTable

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Palets_lineas.PLL_idpalet, "idpalet")
        consulta.SelCampo(Palets.PAL_palet, "Palet", Palets_lineas.PLL_idpalet)
        consulta.SelCampo(GenerosSalida.GES_Nombre, "Genero", Palets_lineas.PLL_idgensal)
        consulta.SelCampo(Marcas.MAR_Nombre, "Marca", Palets_lineas.PLL_idmarca)
        consulta.SelCampo(Albsalida_palets.ASP_IdAlbaran, "idalbaran", Palets.PAL_idpalet, Albsalida_palets.ASP_Idpalet)
        consulta.WheCampo(Albsalida_palets.ASP_IdAlbaran, "=", IdAlbsalida(linea).ToString)
        sql = consulta.SQL + " order by PAL_PALET "
        dt = Conceptosinspeccion.MiConexion.ConsultaSQL(sql)
        dt.Columns.Add("X", GetType(Boolean))
        Dim nupa As Integer = 0
        Dim np As Integer = 0
        For Each rw In dt.Rows
            If VaInt(rw("idpalet")) <> nupa Then
                np = np + 1
            End If
            rw("X") = True
            nupa = VaInt(rw("idpalet"))
        Next

        Grid.DataSource = dt
        AjustaColumnasPalets()
        LbNumPaletAlbaran.Text = np.ToString
        Select Case linea
            Case 1
                LbPalet1.Text = np.ToString
            Case 2
                LbPalet2.Text = np.ToString
            Case 3
                LbPalet3.Text = np.ToString
            Case 4
                LbPalet4.Text = np.ToString
            Case 5
                LbPalet5.Text = np.ToString
            Case 6
                LbPalet6.Text = np.ToString

        End Select


    End Sub
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        Timer1.Stop()

        ParametrosFrm()


    End Sub


  

    Private Sub GridInspec_Click(sender As System.Object, e As System.EventArgs) Handles GridInspec.Click

    End Sub

    Private Sub TxIdConcepto_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxIdConcepto.TextChanged

    End Sub

    Private Sub TxIdConcepto_Valida(edicion As Boolean) Handles TxIdConcepto.Valida
        If edicion = True Then
            If TxIdConcepto.HaCambiado = True Then
                If ConceptosTransporte.LeerId(TxIdConcepto.Text) = True Then
                    TxConcepto.Text = ConceptosTransporte.CTR_Nombre.Valor
                    TxReparto.Text = ConceptosTransporte.CTR_Reparto.Valor
                End If
            End If
        End If
    End Sub

    Private Sub TxReparto_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxReparto.TextChanged
    End Sub

    Private Sub TxReparto_Valida(edicion As Boolean) Handles TxReparto.Valida
        If edicion = True Then
            If TxReparto.Text = "" Then
                TxReparto.Text = "B"
            End If
        End If
    End Sub

    Private Sub Rb1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Rb1.CheckedChanged
        CargaGridPalets()

    End Sub

    Private Sub TxPedido1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxPedido1.TextChanged

    End Sub

    Private Sub TxPedido1_Valida(edicion As Boolean) Handles TxPedido1.Valida

        ValidaPedido(1, TxPedido1)
    End Sub

    Private Sub ValidaPedido(ByVal linea As Integer, ByRef txp As TxDato)
        Dim NumAlb As String = ""
        Dim nomcli As String = ""
        Idpedido(linea) = 0
        If txp.Text <> "" Then
            Dim idp As Integer = Pedidos.LeerPedido(MiMaletin.Ejercicio, MiMaletin.IdCentro, txp.Text)
            Idpedido(linea) = idp
            If idp = 0 Then
                txp.MiError = True
                MsgBox("pedido inexistente")
                Exit Sub
            Else
                If Pedidos.LeerId(idp) = True Then
                    If Clientes.LeerId(Pedidos.PED_idcliente.Valor) = True Then
                        nomcli = Clientes.CLI_Nombre.Valor
                    End If

                    If TieneAlbaranes(idp) = True Then
                        MsgBox("Atencion, este pedido ya tiene albaranes asignados")
                        Exit Sub
                    End If


                    'Dim sql As String = "Select ASA_idalbaran,ASA_albaran from ALBSALIDA where ASA_IDPEDIDO=" + idp.ToString
                    'Dim DT As DataTable = Albsalida.MiConexion.ConsultaSQL(sql)
                    'If Not DT Is Nothing Then
                    '    If DT.Rows.Count > 0 Then
                    '        NumAlb = DT.Rows(0)("asa_albaran").ToString
                    '        IdAlbsalida(linea) = VaInt(DT.Rows(0)("ASA_IDALBARAN"))
                    '    End If
                    'End If
                End If
            End If
        End If
        Select Case linea
            Case 1
                LbCliente1.Text = nomcli
            Case 2
                LbCliente2.Text = nomcli
            Case 3
                LbCliente3.Text = nomcli
            Case 4
                LbCliente4.Text = nomcli
            Case 5
                LbCliente5.Text = nomcli
            Case 6
                LbCliente6.Text = nomcli

        End Select

        If LbId.Text = "+" Then
            GuardaDatos()

        End If
    End Sub


    Private Function TieneAlbaranes(idpedido As Integer) As Boolean

        Dim ret As Boolean = False

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Albsalida.ASA_idalbaran, "idalbaran")
        consulta.WheCampo(Albsalida.ASA_idpedido, "=", idpedido.ToString)
        Dim Sql As String = consulta.SQL
        Dim dt As DataTable = Albsalida.MiConexion.ConsultaSQL(Sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = True
            End If
        End If

        Return ret
    End Function



    Private Sub GuardaDatos()

        If LbId.Text = "+" Then
            LbId.Text = Cargas.MaxId
            If TxCarga.Text = "+" Then
                TxCarga.Text = Cargas.MaxIdCampa(MiMaletin.Ejercicio).ToString
            End If

        End If

        Dim alta As Boolean
        If Cargas.LeerId(LbId.Text) = False Then
            alta = True
        Else
            alta = False
        End If
        Cargas.CAR_Idcarga.Valor = LbId.Text
        Cargas.CAR_Fecha.Valor = TxFecha.Text
        Cargas.CAR_Concepto.Valor = TxConcepto.Text
        Cargas.CAR_IdConcepto.Valor = TxIdConcepto.Text
        Cargas.CAR_IdMuelle.Valor = LbMuelle.Text
        Cargas.CAR_IdTransportista.Valor = TxTransportista.Text
        Cargas.CAR_Matricula.Valor = TxMatricula.Text
        Cargas.CAR_Numero.Valor = TxCarga.Text
        Cargas.CAR_Reparto.Valor = TxReparto.Text
        Cargas.CAR_Temperatura.Valor = TxTemperatura.Text
        Cargas.CAR_IdCentro.Valor = MiMaletin.IdCentro.ToString
        Cargas.CAR_Ejercicio.Valor = MiMaletin.Ejercicio.ToString
        Cargas.CAR_idpedido1.Valor = Idpedido(1)
        Cargas.CAR_idpedido2.Valor = Idpedido(2)
        Cargas.CAR_idpedido3.Valor = Idpedido(3)
        Cargas.CAR_idpedido4.Valor = Idpedido(4)
        Cargas.CAR_idpedido5.Valor = Idpedido(5)
        Cargas.CAR_idpedido6.Valor = Idpedido(6)
        Cargas.CAR_idalbaran1.Valor = IdAlbsalida(1)
        Cargas.CAR_idalbaran2.Valor = IdAlbsalida(2)
        Cargas.CAR_idalbaran3.Valor = IdAlbsalida(3)
        Cargas.CAR_idalbaran4.Valor = IdAlbsalida(4)
        Cargas.CAR_idalbaran5.Valor = IdAlbsalida(5)
        Cargas.CAR_idalbaran6.Valor = IdAlbsalida(6)
        Cargas.CAR_IdCargador.Valor = TxCargador.Text

        If alta = True Then
            Cargas.Insertar()
        Else
            Cargas.Actualizar()
        End If

    End Sub



    Private Sub TxPedido2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxPedido2.TextChanged

    End Sub

    Private Sub TxPedido2_Valida(edicion As Boolean) Handles TxPedido2.Valida
        ValidaPedido(2, TxPedido2)
    End Sub

    Private Sub TxPedido3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxPedido3.TextChanged

    End Sub

    Private Sub TxPedido3_Valida(edicion As Boolean) Handles TxPedido3.Valida
        ValidaPedido(3, TxPedido3)
    End Sub

    Private Sub TxPedido4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxPedido4.TextChanged

    End Sub

    Private Sub TxPedido4_Valida(edicion As Boolean) Handles TxPedido4.Valida
        ValidaPedido(4, TxPedido4)
    End Sub

    Private Sub TxPedido5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxPedido5.TextChanged

    End Sub

    Private Sub TxPedido5_Valida(edicion As Boolean) Handles TxPedido5.Valida
        ValidaPedido(5, TxPedido5)
    End Sub

    Private Sub TxPedido6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxPedido6.TextChanged

    End Sub

    Private Sub TxPedido6_Valida(edicion As Boolean) Handles TxPedido6.Valida
        ValidaPedido(6, TxPedido6)
    End Sub

    Private Sub BtPalet_Click(sender As System.Object, e As System.EventArgs) Handles BtPalet.Click
        If Rblinea() > 0 Then

            GuardaDatos()

            If VaInt(LbId.Text) > 0 Then

                'Timer1.Stop()

                Dim frm As New FrmCargaPalet
                frm.initcarga(LbMuelle.Text)
                frm.ShowDialog()

                'Timer1.Start()

            End If
        Else
            MsgBox("Asignar una carga")
        End If
    End Sub

    Private Sub ActualizaDatos()
        If VaInt(LbId.Text) > 0 Then
            ActualizarCarga()
            CargaGridPalets()
            NumeroPalets()
        End If
    End Sub

    Private Sub ActualizarCarga()



        If VaInt(LbId.Text) > 0 Then
            Dim sql As String
            Dim i As Integer = Rblinea()
            If i > 0 Then
                sql = "Select CGL_idpalet  as idpalet from cargas_palets where CGL_idmuelle=" + LbMuelle.Text
                Dim dt As DataTable = cargas_palets.MiConexion.ConsultaSQL(sql)
                If Not dt Is Nothing Then
                    For Each rw In dt.Rows
                        CargaPalet(VaInt(rw("idpalet")), i)
                    Next
                End If
            End If
            GuardaDatos()
        End If


    End Sub

    Private Function Rblinea() As Integer
        Dim i As Integer
        If Rb1.Checked = True And Val(TxPedido1.Text) > 0 Then
            i = 1
        ElseIf Rb2.Checked = True And Val(TxPedido1.Text) > 0 Then
            i = 2
        ElseIf Rb3.Checked = True And Val(TxPedido1.Text) > 0 Then
            i = 3
        ElseIf Rb4.Checked = True And Val(TxPedido1.Text) > 0 Then
            i = 4
        ElseIf Rb5.Checked = True And Val(TxPedido1.Text) > 0 Then
            i = 5
        ElseIf Rb6.Checked = True And Val(TxPedido1.Text) > 0 Then
            i = 6
        End If
        Return i
    End Function

    Private Sub CargaPalet(idpalet As Integer, linea As Integer)

        Dim IdAlb As Integer = IdAlbsalida(linea)
        Dim NumAlb As String = ""
        If IdAlb = 0 Then
            IdAlb = CrearNuevoAlbaran(Idpedido(linea))
        End If
        If IdAlb > 0 Then
            Albsalida_palets.VaciaEntidad()
            Dim id As Integer = Albsalida_palets.MaxId
            Albsalida_palets.ASP_Id.Valor = id.ToString
            Albsalida_palets.ASP_IdAlbaran.Valor = IdAlb.ToString
            Albsalida_palets.ASP_Idpalet.Valor = idpalet.ToString
            Albsalida_palets.Insertar()
            If Albsalida.LeerId(IdAlb) = True Then
                numalb = Albsalida.ASA_albaran.Valor
            End If
            IdAlbsalida(linea) = IdAlb
            Select Case linea
                Case 1
                    LbAlbaran1.Text = NumAlb
                Case 2
                    LbAlbaran2.Text = NumAlb
                Case 3
                    LbAlbaran3.Text = NumAlb
                Case 4
                    LbAlbaran4.Text = NumAlb
                Case 5
                    LbAlbaran5.Text = NumAlb
                Case 6
                    LbAlbaran6.Text = NumAlb
            End Select
            If cargas_palets.LeerId(idpalet) = True Then
                cargas_palets.Eliminar()
            End If
        End If

    End Sub

    Private Function CrearNuevoAlbaran(idped As Integer) As Integer
        Dim ret As Integer
        Dim nALB As Integer = 0
        If idped > 0 Then
            If Pedidos.LeerId(idped) = True Then
                Albsalida.VaciaEntidad()
                Dim id As Integer = Albsalida.MaxId
                nALB = Albsalida.MaxIdCampa(Pedidos.PED_ejercicio.Valor, Pedidos.PED_idcentro.Valor)
                Albsalida.ASA_idalbaran.Valor = id
                Albsalida.ASA_albaran.Valor = nALB.ToString
                Albsalida.ASA_ejercicio.Valor = Pedidos.PED_ejercicio.Valor
                Albsalida.ASA_IdEmpresa.Valor = MiMaletin.IdEmpresaCTB
                Albsalida.ASA_fechasalida.Valor = Format(Now, "dd/MM/yyyy") 'Pedidos.PED_fechasalida.Valor
                Albsalida.ASA_idcentro.Valor = Pedidos.PED_idcentro.Valor
                Albsalida.ASA_idcliente.Valor = Pedidos.PED_idcliente.Valor
                Albsalida.ASA_iddivisa.Valor = Pedidos.PED_iddivisa.Valor
                Albsalida.ASA_iddomicilio.Valor = Pedidos.PED_iddestino.Valor
                Albsalida.ASA_idpedido.Valor = Pedidos.PED_idpedido.Valor
                'Albsalida.ASA_idpuntoventa.Valor = Pedidos.PED_idpuntoventa.Valor
                Albsalida.ASA_idpuntoventa.Valor = MiMaletin.IdPuntoVenta.ToString
                Albsalida.ASA_idtransportista.Valor = TxTransportista.Text
                Albsalida.ASA_matricularemolque.Valor = TxMatricula.Text
                Albsalida.ASA_referencia.Valor = Pedidos.PED_referencia.Valor
                Albsalida.ASA_valorcambio.Valor = Pedidos.PED_valorcambio.Valor
                Albsalida.ASA_idcarga.Valor = LbId.Text
                Albsalida.Insertar()
                ret = id
            End If
        End If

        Return ret

    End Function

    Private Sub Rb2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Rb2.CheckedChanged
        CargaGridPalets()

    End Sub

    Private Sub Rb3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Rb3.CheckedChanged
        CargaGridPalets()
        
    End Sub

    Private Sub Rb4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Rb4.CheckedChanged
        CargaGridPalets()
 
    End Sub

    Private Sub Rb5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Rb5.CheckedChanged
        CargaGridPalets()
        
    End Sub

    Private Sub Rb6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Rb6.CheckedChanged
        CargaGridPalets()
        
    End Sub

    Private Sub Grid_Click(sender As System.Object, e As System.EventArgs) Handles Grid.Click

    End Sub

    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        Dim a As String = ""
        Dim x As Boolean = GridView1.GetRowCellValue(e.RowHandle, "X")
        If x = True Then

            Dim row As DataRow = GridView1.GetDataRow(e.RowHandle)
            If Not IsNothing(row) Then

                If MsgBox("Anular la carga de este palet ", vbYesNo) = vbYes Then

                    Dim IdPalet As String = (row("IdPalet").ToString & "").Trim

                    If AlbaranDelPaletTieneLineas(IdPalet) Then
                        MessageBox.Show("ALBARÁN YA GENERADO, DEBE ANULAR LA CARGA DESDE CARGA DE PALETS", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        AnularCargaPalet(VaInt(GridView1.GetRowCellValue(e.RowHandle, "idpalet")))
                        NumeroPalets()
                    End If

                End If

            End If


            'If MsgBox("Anular la carga de este palet ", vbYesNo) = vbYes Then
            '    AnularCargaPalet(VaInt(GridView1.GetRowCellValue(e.RowHandle, "idpalet")))
            '    NumeroPalets()
            'End If

        End If
    End Sub


    Private Function AlbaranDelPaletTieneLineas(ByVal IdPalet As String) As Boolean

        Dim bRes As Boolean = False

        If VaDec(IdPalet) > 0 Then

            Dim sql As String = "SELECT Count(ASL_IdLinea) as cont FROM AlbSalida_Palets LEFT JOIN AlbSalida_Lineas ON ASL_IdAlbaran = ASP_IdAlbaran WHERE ASP_IdPalet = " & IdPalet & vbCrLf
            Dim dt As DataTable = Albsalida.MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim cont As Integer = VaInt(dt.Rows(0)("cont"))
                    If cont > 0 Then bRes = True

                End If
            End If

        End If


        Return bRes

    End Function



    Private Sub AnularCargaPalet(idpalet As Integer)
        Dim sql As String
        sql = "Delete from albsalida_palets where asp_idpalet=" + idpalet.ToString
        Albsalida_palets.MiConexion.OrdenSql(sql)
        CargaGridPalets()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        ActualizaDatos()
        If PanelPedido.Visible = True Then
            ActualizaDatos_Pedidos()
        End If
        Timer1.Enabled = True
    End Sub


    Protected Overrides Sub BTaux1_Click(sender As Object, e As System.EventArgs)
        MyBase.BTaux1_Click(sender, e)
        If PanelPedido.Visible = False Then
            PanelPedido.Width = Me.Width
            PanelPedido.Height = Me.Height - 10
            PanelPedido.Top = 1
            PanelPedido.Left = 1
            PanelPedido.Visible = True
            Pinta_Pedidos()
        Else
            PanelPedido.Visible = False
        End If

        'Dim FRM As New FrmPedCarga

        'If Idpedido(Rblinea) > 0 Then
        '    FRM.InitPedido(Idpedido(Rblinea), IdAlbsalida(Rblinea))

        '    FRM.Show()
        'End If
    End Sub

    Private Sub Pinta_Pedidos()


        Dim rb As Integer = Rblinea()
        If rb = 0 Then Exit Sub

        Dim idp As String = Idpedido(rb).ToString
        Dim idalb As String = IdAlbsalida(rb).ToString

        If VaInt(idp) = 0 Then Exit Sub

        If Pedidos.LeerId(idp) = True Then
            LbNped.Text = Pedidos.PED_pedido.Valor
            If Clientes.LeerId(Pedidos.PED_idcliente.Valor) = True Then
                LbCliente.Text = Clientes.CLI_Nombre.Valor
            End If
        End If
        If IdAlbsalida(Rblinea) > 0 Then
            If Albsalida.LeerId(IdAlbsalida(Rblinea)) = True Then
                LbAlbaran.Text = Albsalida.ASA_albaran.Valor
            End If
        End If

        ActualizaDatos_Pedidos()

    End Sub


    Private Sub ActualizaDatos_Pedidos()



        Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)
        Dim palets As New E_palets(Idusuario, cn)
        Dim palets_lineas As New E_palets_lineas(Idusuario, cn)
        Dim albsalida_palets As New E_albsalida_palets(Idusuario, cn)
        Dim GeneroSalida As New E_GenerosSalida(Idusuario, cn)
        Dim CategoriasComercial As New E_CategoriasComercial(Idusuario, cn)
        Dim Categoriassalida As New E_CategoriasSalida(Idusuario, cn)
        Dim Marcas As New E_Marcas(Idusuario, cn)
        Dim consulta1 As New Cdatos.E_select

        Dim rb As Integer = Rblinea()
        If rb = 0 Then Exit Sub

        Dim idp As String = Idpedido(rb).ToString
        Dim idalb As String = IdAlbsalida(rb).ToString

        If VaInt(idp) = 0 Then Exit Sub


        For Each RW In dtg.Rows
            RW("PED") = 0
            RW("CAR") = 0
            RW("DIF") = 0
        Next
        Dim pped As Integer = 0
        Dim ppte As Integer = 0
        Dim pcar As Integer = 0


        consulta1.SelCampo(Pedidos_Lineas.PEL_idgensal, "idgensal")
        consulta1.SelCampo(Pedidos_Lineas.PEL_idcategoria, "idcat")
        consulta1.SelCampo(Pedidos_Lineas.PEL_idmarca, "idmarca")
        consulta1.SelCampo(GeneroSalida.GES_Nombre, "Genero", Pedidos_Lineas.PEL_idgensal)
        consulta1.SelCampo(CategoriasComercial.CAC_Nombre, "Categoria", Pedidos_Lineas.PEL_idcategoria)
        consulta1.SelCampo(Marcas.MAR_Nombre, "Marca", Pedidos_Lineas.PEL_idmarca)
        consulta1.SelCampo(Pedidos_Lineas.PEL_palets, "palets")
        consulta1.WheCampo(Pedidos_Lineas.PEL_idpedido, "=", idp)
        Dim sql As String = consulta1.SQL
        Dim dt As DataTable = Pedidos_Lineas.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                Lgrid(VaInt(rw("idgensal")), VaInt(rw("idcat")), VaInt(rw("idmarca")), rw("genero").ToString, rw("Categoria").ToString, rw("Marca").ToString, VaInt(rw("palets")), 0)
                pped = pped + VaInt(rw("PALETS"))
                ppte = pped - pcar
            Next
        End If

        Dim consulta2 As New Cdatos.E_select
        consulta2.SelCampo(palets_lineas.PLL_idpalet, "idpalet")
        consulta2.SelCampo(palets_lineas.PLL_idgensal, "idgensal")
        consulta2.SelCampo(palets_lineas.PLL_idcategoria, "idcat")
        consulta2.SelCampo(palets_lineas.PLL_idmarca, "idmarca")
        consulta2.SelCampo(palets_lineas.PLL_idmarca, "idmarca")
        consulta2.SelCampo(GeneroSalida.GES_Nombre, "Genero", palets_lineas.PLL_idgensal)
        consulta2.SelCampo(Categoriassalida.CAS_CategoriaCalibre, "Categoria", palets_lineas.PLL_idcategoria)
        consulta2.SelCampo(Marcas.MAR_Nombre, "Marca", palets_lineas.PLL_idmarca)
        consulta2.SelCampo(albsalida_palets.ASP_IdAlbaran, "idalbaran", palets_lineas.PLL_idpalet, albsalida_palets.ASP_Idpalet)
        consulta2.SelCampo(Albsalida.ASA_idpedido, "idpedido", albsalida_palets.ASP_IdAlbaran)
        consulta2.WheCampo(Albsalida.ASA_idpedido, "=", idp)
        '        consulta2.WheCampo(albsalida_palets.ASP_IdAlbaran, "=", idalb) ' los palets cargados del pedido
        sql = consulta2.SQL
        sql = sql + " order by pll_idpalet "
        dt = palets_lineas.MiConexion.ConsultaSQL(sql)
        Dim idpa As Integer = 0
        Dim p As Integer = 0
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                If VaInt(rw("idpalet")) <> idpa Then
                    p = 1
                Else
                    p = 0
                End If
                idpa = VaInt(rw("idpalet"))

                Lgrid(VaInt(rw("idgensal")), VaInt(rw("idcat")), VaInt(rw("idmarca")), rw("genero").ToString, rw("Categoria").ToString, rw("Marca").ToString, 0, p)
                pcar = pcar + p
                ppte = pped - pcar

            Next
        End If
        GridPedido.DataSource = dtg
        AjustaColumnas_Pedidos()
        LbPalped.Text = pped.ToString
        LbParCar.Text = pcar.ToString
        LbPalPte.Text = ppte.ToString

    End Sub
    Private Sub Lgrid(idgensal As Integer, idcategoria As Integer, idmarca As Integer, Genero As String, Categoria As String, Marca As String, pedidos As Integer, cargados As Integer)

        Dim s As Boolean = False
        Dim CatSalidaComercial As New E_CatSalidaComercial(Idusuario, cn)

        If pedidos > 0 Then
            For Each RW In dtg.Rows
                If VaInt(RW("idgensal")) = idgensal And VaInt(RW("idcat")) = idcategoria And VaInt(RW("idmarca")) = idmarca Then
                    RW("PED") = VaInt(RW("PED")) + pedidos
                    RW("CAR") = VaInt(RW("CAR")) + cargados
                    RW("DIF") = VaInt(RW("PED")) - VaInt(RW("CAR"))
                    s = True
                End If
            Next
            If s = False Then
                dtg.Rows.Add(idgensal, idcategoria, idmarca, Genero, Categoria, Marca, pedidos, cargados, pedidos - cargados)
            End If
        ElseIf cargados > 0 Then
            For Each RW In dtg.Rows
                If VaInt(RW("idgensal")) = idgensal And VaInt(RW("idmarca")) = idmarca Then
                    If CatSalidaComercial.LeerCat(RW("idcat"), idcategoria) > 0 Then ' si pertenece a la misma categoria comercial
                        RW("PED") = VaInt(RW("PED")) + pedidos
                        RW("CAR") = VaInt(RW("CAR")) + cargados
                        RW("DIF") = VaInt(RW("PED")) - VaInt(RW("CAR"))
                        s = True
                    End If
                End If
            Next
            If s = False Then
                dtg.Rows.Add(idgensal, idcategoria, idmarca, Genero, Categoria, Marca, pedidos, cargados, pedidos - cargados)
            End If

        End If



    End Sub

    Private Sub AjustaColumnas_Pedidos()
        GridPedidoView.BestFitColumns()
        GridPedidoView.OptionsView.ShowGroupPanel = False


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridPedidoView.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "GENERO"
                    c.Width = 200
                Case "CATEGORIA", "MARCA"
                    c.Width = 100
                Case "PED", "CAR", "DIF"
                    c.Width = 50
                Case Else
                    c.Visible = False
            End Select
        Next


    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        PanelPedido.Visible = False
    End Sub


    Private Sub FrmCargas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        GuardaDatos()
        GrabarInspeccion()
        ActualizarTransportista()
        BorraPan()

        _bGuardado = True

    End Sub


    Private Sub TxTemperatura_Valida(edicion As Boolean) Handles TxTemperatura.Valida
        If edicion = True Then
            If TxTemperatura.Text = "" Then
                TxTemperatura.Text = "11"
            End If
        End If
    End Sub


    Public Overrides Sub Salir()

        If _bGuardado Then
            MyBase.Salir()
        Else
            MsgBox("Debe guardar los datos antes de salir")
        End If

    End Sub

    Private Sub TxCarga_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxCarga.TextChanged
        If TxCarga.Text.Trim = "" Then
            _bGuardado = True
        Else
            _bGuardado = False
        End If
    End Sub
End Class
