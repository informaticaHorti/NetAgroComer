Imports DevExpress.XtraEditors
Imports System.Drawing

Public Class FrmCargaPalets
    Inherits FrMantenimiento


    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)

    Dim Categorias As New E_CategoriasSalida(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)

    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
    Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim Albsalida As New E_AlbSalida(Idusuario, cn)
    Dim palets As New E_palets(Idusuario, cn)
    Dim palets_lineas As New E_palets_lineas(Idusuario, cn)
    Dim Albsalida_palets As New E_albsalida_palets(Idusuario, cn)
    Dim Albsalida_gastos As New E_albsalida_gastos(Idusuario, cn)
    Dim Facturas As New E_Facturas(Idusuario, cn)
    Dim TiposPorte As New E_TiposPorte(Idusuario, cn)
    Dim Moneda As New E_Moneda(Idusuario, cn)

    Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)


    Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)
    Dim Pedidos As New E_Pedidos(Idusuario, cn)


    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim MiCentro As String
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim idpaletlinea As String
    Dim Dtv As New DataView
    Dim Dtt As New DataTable
    Dim _iddomicilio As Integer
    Dim _idpedido As Integer


    Dim _CampaBloqueada As Boolean = False
    Dim _CampaActualBloqueada As Boolean = False



    Private Sub ParametrosFrm()
        EntidadFrm = Albsalida


        Dim lc As New List(Of Object)
        ListaControles = lc



        LbPuntoVenta.CL_ControlAsociado = TxDato_1
        LbNomPv.CL_ControlAsociado = TxDato_1
        CampoClave = 0 ' ultimo campo de la clave

        ParamTx(TxDato_1, Albsalida.ASA_albaran, Lb_1, False)
        ParamTx(TxPedido, Nothing, Lb_3)

        ParamTx(TxDato_2, Albsalida.ASA_fechasalida, Lb_2, True)
        TxDato_1.Autonumerico = True
        ParamTx(TxDato_4, Albsalida.ASA_idcliente, Lb_4, True)
        ParamTx(TxDomicilio, Nothing, LbDescarga, False)

        ParamTx(TxDato_6, Albsalida.ASA_idtransportista, Lb_6, False)
        ParamTx(TxDato_7, Albsalida.ASA_matriculacamion, Lb_7, False)
        ParamTx(TxDato_8, Albsalida.ASA_matricularemolque, Lb_8, False)

        ParamTx(TxMovilChofer, Albsalida.ASA_movilchofer, LbMovilChofer, False)
        ParamTx(TxNumRegTemp, Albsalida.ASA_numregtemperatura, LbNumRegTemp, False)

        ParamTx(TxDato4, Albsalida.ASA_observaciones, Lb19)

        ParamTx(TxDato_5, Albsalida.ASA_referencia, Lb_5, False)
        ParamTx(TxTipoPorte, Albsalida.ASA_idtipoporte, LbTipoPorte, True)
        ParamTx(TxDivisa, Albsalida.ASA_iddivisa, LbDivisa, False)
        ParamTx(TxValorCambio, Albsalida.ASA_valorcambio, LbValorCambio, False)

        ParamTx(TxFc, Albsalida.ASA_tipofc, Lb4, True, , , , "FC")
        ParamTx(TxHoraSalida, Albsalida.ASA_HoraSalida, LbHoraSalida)
        'ParamChk(ChkImprimirCMR, Nothing, "S", "N")


        AsociarControles(TxDato_1, BtBuscaAlbaran, Albsalida.btBusca, EntidadFrm)
        BtBuscaAlbaran.CL_Filtro = "Emp=" + MiMaletin.IdEmpresaCTB.ToString

        ParamTx(TxCampa, Nothing, LbCampaPalet, True, Cdatos.TiposCampo.Entero, , 2)
        TxHoraSalida.Siguiente = TxDato_10.Orden
        ParamTx(TxDato_10, Nothing, Lb_10, False, Cdatos.TiposCampo.Cadena, 0, 8)

        AsociarGrid(ClGrid1, TxCampa, TxDato_10, Albsalida_palets)
        ClGrid1.GridEnterAutomatico = True

        PropiedadesCamposGr(ClGrid1, Albsalida_palets.ASP_Id.NombreCampo, "ASP_id", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Campa", "Campa", True, 10)
        PropiedadesCamposGr(ClGrid1, "Palet", "Palet", True, 20)
        PropiedadesCamposGr(ClGrid1, "Fecha", "Fecha", True, 30)
        PropiedadesCamposGr(ClGrid1, "TipoPalet", "TipoPalet", True, 50)
        PropiedadesCamposGr(ClGrid1, "Bultos", "Bultos", True, 10, True)
        PropiedadesCamposGr(ClGrid1, "Kilos", "Kilos", True, 15, True)


        AsociarControles(TxDato_4, BtBuscaCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lbnom_4)
        AsociarControles(TxDomicilio, BtBuscaDestino, ClientesDescargas.btBusca, ClientesDescargas)


        AsociarControles(TxDato_6, BtBusca_6, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, Lb_nom6)
        BtBusca_6.CL_Filtro = "TIPO='PV'"

        AsociarControles(TxTipoPorte, BtBuscaPorte, Tiposporte.btBusca, Tiposporte, Tiposporte.TPO_Nombre, LbNomPorte)
        AsociarControles(TxDivisa, BtBuscaDivisa, Moneda.btBusca, Moneda, Moneda.MON_Nombre, LbNomDivisa)


        ' BotonesAvance1.Mientidad = EntidadFrm
        ' BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        ' BotonesAvance1.Formulario = Me

        tt.SetToolTip(BtNuevo, "Nuevo")
        FiltroEntidad.Add(Albsalida.ASA_idcentro.NombreCampo, MiMaletin.IdCentro.ToString)
        FiltroEntidad.Add(Albsalida.ASA_ejercicio.NombreCampo, MiMaletin.Ejercicio.ToString)
        FiltroEntidad.Add(Albsalida.ASA_IdEmpresa.NombreCampo, MiMaletin.IdEmpresaCTB.ToString)



    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave


        Dim i As Integer
        If TxDato_1.Text = "+" Then
            LbId.Text = "+"
        Else
            If TxDato_1.Text <> "" Then
                i = Albsalida.LeerAlb(Lbejer.Text, MiCentro, VaInt(TxDato_1.Text))
                If i > 0 Then
                    LbId.Text = i.ToString

                Else
                    If MsgBox("Registro inexistente. Desea crear uno nuevo", vbYesNo) = vbYes Then
                        '                    LbId.Text = Cobros.MaxId
                        LbId.Text = "+"
                    Else
                        LbId.Text = ""
                    End If

                End If
            Else
                TxDato_1.Text = "+"
                LbId.Text = "+"
            End If
        End If


        If LbId.Text <> "" Then
            CargaLineasGrid()
        End If

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

        PintaPuntoVenta(Albsalida.ASA_idpuntoventa.Valor)

        Lbejer.Text = Albsalida.ASA_ejercicio.Valor

        Dim ValoresEjercicio As New E_ValoresEjercicio(Idusuario, cn)
        If ValoresEjercicio.LeerId(Lbejer.Text) Then
            If ValoresEjercicio.VEJ_Bloqueada.Valor = "S" Then
                _CampaBloqueada = True
            End If
        End If

        LbEmpresa.Text = Albsalida.ASA_IdEmpresa.Valor
        LbFactura.Text = ""
        If VaInt(Albsalida.ASA_idfactura.Valor) > 0 Then
            If Facturas.LeerId(Albsalida.ASA_idfactura.Valor) = True Then
                LbFactura.Text = Facturas.FRA_serie.Valor & "  " & Facturas.FRA_factura.Valor
            End If
        End If

        _iddomicilio = VaInt(Albsalida.ASA_iddomicilio.Valor)
        If _iddomicilio > 0 Then
            If ClientesDescargas.LeerId(_iddomicilio.ToString) = True Then
                TxDomicilio.Text = ClientesDescargas.CLD_numero.Valor
                LbNomDestino.Text = ClientesDescargas.CLD_Domicilio.Valor
            End If
        End If

        _idpedido = VaInt(Albsalida.ASA_idpedido.Valor)
        If _idpedido > 0 Then
            If Pedidos.LeerId(_idpedido.ToString) = True Then
                TxPedido.Text = Pedidos.PED_pedido.Valor
                TxPedido.Validar(False)
            End If
        End If
        ' llenar el grid
        CargaLineasGrid()
    End Sub
    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        Dim IDPALET As Integer

        IDPALET = VaInt(Albsalida_palets.ASP_Idpalet.Valor)
        If palets.LeerId(IDPALET) = True Then
            TxCampa.Text = palets.PAL_campa.Valor
            TxDato_10.Text = palets.PAL_palet.Valor
            DatosPalet()
        End If
        MyBase.Entidad_a_DatosLin(Grid)
    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)

        Lb3.Text = ""
        GridPalet.DataSource = Nothing

        MyBase.Borralin(gr)

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean


        If LbId.Text = "+" Then
            LbId.Text = Albsalida.MaxId
            If TxDato_1.Text = "+" Then
                TxDato_1.Text = Albsalida.MaxIdCampa(Val(Lbejer.Text), Val(MiCentro))
            End If
        End If

        Albsalida.ASA_ejercicio.Valor = Lbejer.Text
        Albsalida.ASA_IdEmpresa.Valor = LbEmpresa.Text
        Albsalida.ASA_idalbaran.Valor = LbId.Text
        Albsalida.ASA_idpuntoventa.Valor = LbPuntoVenta.Text
        Albsalida.ASA_idcentro.Valor = MiCentro
        Albsalida.ASA_idpedido.Valor = _idpedido.ToString
        Albsalida.ASA_iddomicilio.Valor = _iddomicilio.ToString


        Albsalida_palets.ASP_IdAlbaran.Valor = LbId.Text
        Albsalida_palets.ASP_Idpalet.Valor = idpaletlinea
        SqlGrid()
        r = MyBase.GuardarLineas(Gr)
        CalculoTotales()

        Return r

    End Function


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()

        Agro_GeneraLineasAlbaran(LbId.Text, True)
        Dim palets_traza As New E_palets_traza(Idusuario, cn)
        palets_traza.DuplicaTrazabilidad(LbId.Text)

        Dim IdCliente As String = (Albsalida.ASA_idcliente.Valor & "").Trim
        Dim IdDomicilio As String = VaInt(Albsalida.ASA_iddomicilio.Valor).ToString

        'Albsalida.CrearValeEnvasesSalida(LbId.Text, "S", Clientes.CLI_FacturaEnvaseComercio.Valor, IdCliente, IdDomicilio)
        'Albsalida.CrearValeEnvasesSalida(LbId.Text, "N", Clientes.CLI_FacturaEnvaseComercio.Valor, IdCliente, IdDomicilio)

        Albsalida.CrearValeEnvasesSalida(LbId.Text, "S", IdCliente, IdDomicilio)
        Albsalida.CrearValeEnvasesSalida(LbId.Text, "N", IdCliente, IdDomicilio)




        'Imprimir AlbSalida
        If VaDec(LbId.Text) > 0 Then

            'Mostrar Vale
            Dim IdVale As String = Albsalida.ASA_idvaleenvase.Valor
            If VaInt(IdVale) > 0 Then

                Dim frm As New FrmValeEnvase("SC")
                frm.init(IdVale)
                frm.ShowDialog()

                If NuevoRegistro Then
                    If ChkImprimirValeEnvases.Checked Then C1_ImprimirValeEnvases(IdVale, TipoImpresion.ImpresoraSeleccionada)
                End If

            End If


            'Borra posible CMR anterior
            Dim Campa As Integer = VaInt(Albsalida.ASA_ejercicio.Valor)
            Dim IdCentro As Integer = VaInt(Albsalida.ASA_idcentro.Valor)
            Dim Albaran As Integer = VaInt(Albsalida.ASA_albaran.Valor)

            Dim CMR As New E_Cmr(Idusuario, cn)
            If CMR.LeerCmr(Campa, IdCentro, Albaran) Then
                CMR.Eliminar()
            End If


            'Genera CMR automáticamente
            Dim IdCMR As String = CrearCMRDesdeAlbaran(LbId.Text)

            If ChkImprimirCMR.Checked Then
                If VaInt(IdCMR) > 0 Then
                    C1_ImprimirCMR_InterNacional(IdCMR, TipoImpresion.ImpresoraPorDefecto, ChkImprimirEtiquetaCMR.Checked)
                Else
                    MsgBox("No se generó CMR")
                End If
            End If


            If XtraMessageBox.Show("¿Desea imprimir el albarán?", "Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim impresora As New Printing.PrinterSettings
                C1_ImprimirAlbaranSalida(LbId.Text, TipoImpresion.ImpresoraPorDefecto, 2)
            End If


            If VaInt(Albsalida.ASA_iddomicilio.Valor) > 0 Then
                Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
                If ClientesDescargas.LeerId(Albsalida.ASA_iddomicilio.Valor) Then
                    Dim OpcionEnvio As String = (ClientesDescargas.CLD_OpcionEnvio.Valor & "").Trim

                    If OpcionEnvio = "E" Or OpcionEnvio = "T" Then

                        If XtraMessageBox.Show("¿Desea enviar al cliente por email?", "Email", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            C1_ImprimirAlbaranSalida(LbId.Text, TipoImpresion.Email, 0)
                            MsgBox("Enviado!")
                        End If

                    End If


                    If OpcionEnvio = "F" Or OpcionEnvio = "T" Then

                        If XtraMessageBox.Show("¿Desea enviar al cliente por fax?", "Fax", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            C1_ImprimirAlbaranSalida(LbId.Text, TipoImpresion.Fax, 0)
                            MsgBox("Enviado!")
                        End If

                    End If



                End If
            End If



        End If





        'Dim frm As New FrmComprobarPalets(LbId.Text)
        'frm.MdiParent = Me.MdiParent
        'frm.Show()

    End Sub





    Private Sub CargaLineasGrid()
        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)

        CalculoTotales()
    End Sub


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
        Dim Dt As New DataTable


        CONSULTA.SelCampo(Albsalida_palets.ASP_Id, "ASP_id")
        CONSULTA.SelCampo(palets.PAL_campa, "Campa", Albsalida_palets.ASP_Idpalet)
        CONSULTA.SelCampo(palets.PAL_palet, "Palet")
        CONSULTA.SelCampo(palets.PAL_fecha, "Fecha")
        CONSULTA.SelCampo(ConfecPalet.CPA_Nombre, "Tipopalet", palets.PAL_idtipopalet)
        CONSULTA.SelCampo(palets.PAL_PaletsTransporte, "PaletsTransporte")
        CONSULTA.SelCampo(Albsalida_palets.ASP_Idpalet, "Bultos")
        CONSULTA.SelCampo(Albsalida_palets.ASP_Idpalet, "Kilos")
        CONSULTA.SelCampo(palets.PAL_idpalet, "idpalet")
        CONSULTA.WheCampo(Albsalida_palets.ASP_IdAlbaran, "=", id)
        sql = CONSULTA.SQL
        sql = sql + " order by ASP_id"



        ClGrid1.Consulta = sql


    End Sub

    Public Overrides Sub DespuesdeCargarLineas(ByVal gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)
        Dim sql As String = ""

        ' Dim DTG As DataTable = gr.GridView.DataSource
        Dim Idpalet As String = ""



        For Each rw In gr.GridView.DataSource

            Idpalet = rw("bultos").ToString
            rw("bultos") = 0
            If VaInt(Idpalet) > 0 Then
                sql = "Select sum(PLL_bultos) as bultos ,sum(PLL_kiloscliente) as kilos from palets_lineas where PLL_idpalet=" + Idpalet
                Dim dt As DataTable = palets_lineas.MiConexion.ConsultaSQL(sql)
                If Not dt Is Nothing Then
                    If dt.Rows.Count > 0 Then
                        rw("bultos") = VaDec(dt.Rows(0)(0))
                        rw("kilos") = VaDec(dt.Rows(0)(1))
                    End If
                End If
            End If
        Next
        LlenaGridLineas()
        ClGrid1.GridView.RefreshData()
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub

    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If Albsalida.ASA_fechavaloracion.Valor <> "01/01/1900" And Albsalida.ASA_tipofc.Valor <> "F" Then
            MsgBox("Albaran valorado. Debe anular la valoracion para poder anular el albarán.")
            Exit Sub
        End If

        If LbFactura.Text <> "" Then
            MsgBox("Albaran facturado")
            Exit Sub
        End If

        Dim f As String = Albsalida_gastos.GastosFacturados(LbId.Text)
        If f <> "" Then
            MsgBox(f)
            Exit Sub
        End If


        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
        If ValeEnvases.LineasFacturadas(Albsalida.ASA_idvaleenvase.Valor) Then
            MsgBox("No se puede anular el albarán, el vale de envases tiene líneas facturadas")
            Exit Sub
        End If


        MyBase.BAnular_Click(sender, e)
    End Sub



    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)


        If Albsalida.ASA_fechavaloracion.Valor <> "01/01/1900" And Albsalida.ASA_tipofc.Valor <> "F" Then
            MsgBox("Albaran valorado. Debe anular la valoracion para poder modificarlo")
            Exit Sub
        End If

        If LbFactura.Text <> "" Then
            MsgBox("Albaran facturado")
            Exit Sub
        End If

        Dim f As String = Albsalida_gastos.GastosFacturados(LbId.Text)
        If f <> "" Then
            MsgBox(f)
            Exit Sub
        End If

        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
        If ValeEnvases.LineasFacturadas(Albsalida.ASA_idvaleenvase.Valor) Then
            MsgBox("No se puede modificar el albarán, el vale de envases tiene líneas facturadas")
            Exit Sub
        End If

        MyBase.BModificar_Click(sender, e)

    End Sub

    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNuevo.Click
        If TxDato_1.Text = "" And TxDato_1.Enabled = True Then
            TxDato_1.Text = "+"
            Siguiente(0)
        End If
    End Sub


    Private Sub PintaPuntoVenta(ByVal idpv As String)

        LbPuntoVenta.Text = idpv

        If PuntoVenta.LeerId(idpv) = True Then
            LbNomPv.Text = PuntoVenta.Nombre.Valor
            MiCentro = PuntoVenta.IdCentro.Valor
        Else
            LbNomPv.Text = ""
            MiCentro = ""
        End If

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        PintaPuntoVenta(MiMaletin.IdPuntoVenta)

        Lbejer.Text = MiMaletin.Ejercicio
        _CampaBloqueada = _CampaActualBloqueada

        LbEmpresa.Text = MiMaletin.IdEmpresaCTB
        GridLineas.DataSource = Nothing

        LbNom_BESTELLNR.Text = ""

        _idpedido = 0
        _iddomicilio = 0

    End Sub


    Private Sub CalculoTotales()

        Dim Filas As Integer = ClGrid1.GridView.RowCount - 1
        Dim PaletsTransporte As Integer = 0

        Dim dt As DataTable = ClGrid1.Grid.DataSource
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    PaletsTransporte = PaletsTransporte + VaInt(row("PaletsTransporte"))
                Next
            End If
        End If

        LbResultadoLineas.Text = "Total Palets: " & Filas.ToString & "       Total Palets Transporte: " & PaletsTransporte.ToString


    End Sub

    Public Overrides Sub Guardar()

        Albsalida.ASA_idpuntoventa.Valor = LbPuntoVenta.Text
        Albsalida.ASA_ejercicio.Valor = Lbejer.Text
        Albsalida.ASA_idcentro.Valor = MiCentro
        Albsalida.ASA_IdEmpresa.Valor = LbEmpresa.Text
        Albsalida.ASA_IdVendedor.Valor = Clientes.CLI_IdVendedor.Valor

        TxHoraSalida.Text = Now.ToString("HH:mm:ss")


        MyBase.Guardar()

    End Sub


    Private Sub TxDato_10_Valida(ByVal edicion As Boolean) Handles TxDato_10.Valida

        Lb3.Text = ""

        If VaDec(TxDato_10.Text) > 0 Then


            idpaletlinea = palets.Leerpalet(TxCampa.Text, MiCentro, TxDato_10.Text)

            Dim idalb As Integer = 0
            If VaInt(idpaletlinea) > 0 Then

                If palets.LeerId(idpaletlinea) = True Then

                    idalb = VaInt(Albsalida_palets.AlbaranPalet(idpaletlinea))

                    If idalb > 0 And idalb <> Val(LbId.Text) Then
                        MsgBox("Palet ya cargado en otro albaran")
                        TxDato_10.MiError = True

                    ElseIf palets.PAL_finalizado.Valor = "N" Then
                        MsgBox("Palet sin terminar")
                        TxDato_10.MiError = True

                    ElseIf DcEmpresaPventa(palets.PAL_idpuntoventa.Valor) <> VaInt(LbEmpresa.Text) Then
                        MsgBox("Palet de otra empresa")
                        TxDato_10.MiError = True

                    ElseIf idalb > 0 And edicion = True And idalb = Val(LbId.Text) Then
                        Dim row As DataRow = ClGrid1.GridView.GetFocusedDataRow()
                        If Not IsNothing(row) Then
                            If VaInt(row("ASP_id")) = 0 Then
                                ' la linea es nueva
                                For Each rw In ClGrid1.GridView.DataSource
                                    If VaInt(rw("idpalet")) = idpaletlinea Then
                                        MsgBox("palet ya cargado")
                                        TxDato_10.MiError = True
                                    End If
                                Next

                            End If
                        End If

                    End If

                    If TxDato_10.MiError = False Then
                        palets_lineas.CoeficientePalet(idpaletlinea)
                    End If

                Else
                    MsgBox("Palet inexistente")
                    TxDato_10.MiError = True
                End If
            Else
                MsgBox("Palet inexistente")
                TxDato_10.MiError = True
            End If

        ElseIf TxDato_10.Text.Trim = "." Then
            'Dejar esto así

        ElseIf edicion Then

            MsgBox("Palet inexistente")
            TxDato_10.MiError = True

        End If


    End Sub


    Private Sub TxDato_10_AntesDeValidar(edicion As System.Boolean) Handles TxDato_10.AntesDeValidar

        If edicion Then
            'Borralin(ClGrid1)
        End If

    End Sub



    Private Sub DatosPalet()

        Dim consulta As New Cdatos.E_select
        Dim sql As String = ""
        Lb3.Text = ""
        If ConfecPalet.LeerId(palets.PAL_idtipopalet.Valor) = True Then
            Lb3.Text = ConfecPalet.CPA_Nombre.Valor
        End If

        consulta.SelCampo(palets_lineas.PLL_idlinea, "IdLinea")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Producto", palets_lineas.PLL_idgenero)
        consulta.SelCampo(Categorias.CAS_CategoriaCalibre, "Categoria", palets_lineas.PLL_idcategoria)
        consulta.SelCampo(palets_lineas.PLL_bultos, "Bultos")
        consulta.WheCampo(palets_lineas.PLL_idpalet, "=", palets.PAL_idpalet.Valor)
        sql = consulta.SQL + " order by PLL_idlinea"

        Dim dt As DataTable = palets_lineas.MiConexion.ConsultaSQL(sql)
        GridPalet.DataSource = dt
        AjustaColumnasPalet()
    End Sub


    Private Sub FrmCargaPalets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ValoresEjercicio As New E_ValoresEjercicio(Idusuario, cn)
        If ValoresEjercicio.LeerId(MiMaletin.Ejercicio.ToString) Then
            If ValoresEjercicio.VEJ_Bloqueada.Valor = "S" Then
                _CampaActualBloqueada = True
            End If
        End If

        GridViewPalet.BestFitColumns()
        GridViewPalet.OptionsView.ShowGroupPanel = False
        GridViewPalet.OptionsBehavior.Editable = False

        GridViewLineas.BestFitColumns()
        GridViewLineas.OptionsView.ShowGroupPanel = False
        GridViewLineas.OptionsBehavior.Editable = False

        tt.SetToolTip(Button4, "Ver palet")

        ChkImprimirCMR.Checked = True



        BTaux1.Text = "Imprimir"
        BTaux1.Image = My.Resources.Action_file_print_16x16_32
        BTaux1.Visible = True

        BtAux2.Text = "Imp.Carga"
        BtAux2.Width = 75
        BtAux2.Image = My.Resources.Action_file_print_16x16_32
        BtAux2.Visible = True

        BtAux3.Text = "Enviar cliente"
        BtAux3.Width = 90
        BtAux3.Image = NetAgro.My.Resources.Resources.App_xf_mail_16x16_32
        BtAux3.Visible = True

    End Sub



    Private Sub AjustaColumnasPalet()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewPalet.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDLINEA"
                    c.Visible = False

                Case "GENERO"
                    c.Width = 100

                Case "CATEGORIA"
                    c.Width = 50

                Case "BULTOS"
                    c.Width = 30


                    '                    Case "PMEDIO"
                    '                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    '                        c.DisplayFormat.FormatString = "#,##0.00"
                    '                        c.Width = 65


                    '                    Case "IMPORTE"
                    '                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    '                        c.DisplayFormat.FormatString = "#,##0.00"
                    '                        c.Width = 80

            End Select

        Next

        '        AñadeResumenCampo(GridView1, "Importe", "{0:n2}")


    End Sub


    Private Sub CreaDtt()

        Dtt.Clear()

        If Not Dtt.Columns.Contains("Idgenero") Then Dtt.Columns.Add("Idgenero", GetType(Int32))
        If Not Dtt.Columns.Contains("Genero") Then Dtt.Columns.Add("Genero", GetType(String))
        If Not Dtt.Columns.Contains("Idconfec") Then Dtt.Columns.Add("Idconfec", GetType(Int32))
        If Not Dtt.Columns.Contains("Confeccion") Then Dtt.Columns.Add("Confeccion", GetType(String))
        If Not Dtt.Columns.Contains("Categoria") Then Dtt.Columns.Add("Categoria", GetType(String))
        If Not Dtt.Columns.Contains("Idmarca") Then Dtt.Columns.Add("Idmarca", GetType(Int32))
        If Not Dtt.Columns.Contains("Marca") Then Dtt.Columns.Add("Marca", GetType(String))
        If Not Dtt.Columns.Contains("Bultos") Then Dtt.Columns.Add("Bultos", GetType(Int32))
        If Not Dtt.Columns.Contains("KNetos") Then Dtt.Columns.Add("KNetos", GetType(Int32))
        If Not Dtt.Columns.Contains("KCliente") Then Dtt.Columns.Add("KCliente", GetType(Int32))
        If Not Dtt.Columns.Contains("Idgensal") Then Dtt.Columns.Add("Idgensal", GetType(Int32))
        If Not Dtt.Columns.Contains("EntConf") Then Dtt.Columns.Add("EntConf", GetType(Int32))


    End Sub
    Private Sub AjustaColumnasLineas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewLineas.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDGENERO", "IDCONFEC", "IDMARCA", "IDGENSAL", "IDLINEAENTRADA"
                    c.Visible = False

                Case "GENERO", "CONFECCION"
                    c.Width = 100

                Case "CATEGORIA", "MARCA"
                    c.Width = 50

                Case "BULTOS", "KNETOS", "KCLIENTE"
                    c.Width = 30

                Case "ENTCONF"
                    c.Caption = "EntDirecta"
                    c.Width = 60

            End Select

        Next

        AñadeResumenCampo(GridViewLineas, "Bultos", "{0:n0}")
        AñadeResumenCampo(GridViewLineas, "KNetos", "{0:n0}")
        AñadeResumenCampo(GridViewLineas, "KCliente", "{0:n0}")


    End Sub

    Private Sub AcumulaGenero(ByVal IdGenero As Integer, ByVal nomgenero As String, ByVal idconfec As Integer, ByVal nomconfec As String, ByVal categoria As String, ByVal idmarca As Integer, ByVal nommarca As String, ByVal bultos As Integer, ByVal kilosnetos As Double, ByVal kiloscliente As Double, idgensal As Integer, ByVal EntConf As Integer)

        Dim E As Boolean
        Dim Pmedio As Decimal = 0

        For Each rwa As DataRow In Dtt.Rows


            If IdGenero = VaInt(rwa("idgenero")) And categoria.Trim = rwa("categoria").trim And idconfec = VaInt(rwa("idconfec")) And idmarca = VaInt(rwa("idmarca")) And idgensal = VaInt(rwa("idgensal") And EntConf = VaInt("entconf")) Then
                rwa("knetos") = rwa("knetos") + kilosnetos
                rwa("kcliente") = rwa("kcliente") + kiloscliente
                rwa("bultos") = rwa("bultos") + bultos
                E = True
            End If
        Next

        If E = False Then
            Dtt.Rows.Add(IdGenero, nomgenero, idconfec, nomconfec, categoria, idmarca, nommarca, bultos, kilosnetos, kiloscliente, idgensal, EntConf)
        End If

    End Sub

    Private Sub LlenaGridLineas()
        Dim consulta As New Cdatos.E_select
        Dim sql As String

        CreaDtt()
        If VaInt(LbId.Text) = 0 Then Exit Sub

        consulta.SelCampo(palets_lineas.PLL_idlinea, "IdLinea")
        consulta.SelCampo(palets_lineas.PLL_idgenero, "IdGenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Producto", palets_lineas.PLL_idgenero)
        consulta.SelCampo(palets_lineas.PLL_idtipoconfeccion, "IdTipoConfeccion")
        consulta.SelCampo(ConfecEnvase.CEV_Nombre, "Confeccion", palets_lineas.PLL_idtipoconfeccion)
        consulta.SelCampo(palets_lineas.PLL_categoria, "Categoria")
        consulta.SelCampo(palets_lineas.PLL_idmarca, "IdMarca")
        consulta.SelCampo(Marcas.MAR_Nombre, "Marca", palets_lineas.PLL_idmarca)
        consulta.SelCampo(palets_lineas.PLL_bultos, "Bultos")
        consulta.SelCampo(palets_lineas.PLL_kilosnetos, "Knetos")
        consulta.SelCampo(palets_lineas.PLL_kiloscliente, "Kcliente")
        consulta.SelCampo(palets_lineas.Pll_idgensal, "idgensal")
        consulta.SelCampo(Albsalida_palets.ASP_IdAlbaran, "IdAlbaran", palets_lineas.PLL_idpalet, Albsalida_palets.ASP_Idpalet)
        consulta.SelCampo(AlbEntrada_Lineas.AEL_idlinea, "IdLineaEntrada", palets_lineas.PLL_idlineaentradaconfeccionada, AlbEntrada_Lineas.AEL_idlinea)
        consulta.SelCampo(AlbEntrada.AEN_Albaran, "EntConf", AlbEntrada_Lineas.AEL_idalbaran, AlbEntrada.AEN_IdAlbaran)
        consulta.WheCampo(Albsalida_palets.ASP_IdAlbaran, "=", LbId.Text)

        sql = consulta.SQL
        Dim dt As DataTable = palets_lineas.MiConexion.ConsultaSQL(sql)
        For Each rw In dt.Rows
            AcumulaGenero(VaInt(rw("idgenero")), rw("producto").ToString, VaInt(rw("idtipoconfeccion")), rw("Confeccion").ToString, rw("categoria").ToString, VaInt(rw("idmarca")), rw("Marca").ToString, VaInt(rw("Bultos")), VaDec(rw("Knetos")), VaDec(rw("Kcliente")), VaInt(rw("idgensal")), VaInt(rw("EntConf")))
        Next

        GridLineas.DataSource = Dtt
        AjustaColumnasLineas()

    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If VaInt(TxDato_10.Text) > 0 Then

            Dim IDP As Integer = palets.Leerpalet(VaInt(TxCampa.Text), MiCentro, TxDato_10.Text)
            If IDP > 0 Then
                Dim Frm As New FrmPaletsComer

                Frm.init(IDP)
                Frm.InitAlb(LbId.Text)
                Frm.ShowDialog()
                CargaLineasGrid()

                'Dim Frm As New FrmPaletsComer
                'Frm.init(IDP)
                'Frm.InitAlb(LbId.Text)
                'Frm.ShowDialog()
                'CargaLineasGrid()

            End If

        Else
            MsgBox("Debe introducir un palet")
        End If


    End Sub


    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click

        If VaInt(LbId.Text) > 0 Then
            AGRO_ActualizaGastosOrigenAlbaran(LbId.Text, True, 0)
            Dim frm As New FrmComprobarPalets(LbId.Text)
            frm.MdiParent = Me.MdiParent
            frm.Show()
        End If

    End Sub

    Private Sub TxPedido_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPedido.KeyDown
        If e.KeyCode = Keys.F2 Then
            BuscaPEd()
        End If
    End Sub



    Private Sub TxPedido_Valida(edicion As Boolean) Handles TxPedido.Valida

        LbNom_BESTELLNR.Text = ""

        If TxPedido.Text <> "" Then
            _idpedido = Pedidos.LeerPedido(Lbejer.Text, MiMaletin.IdCentro, TxPedido.Text)
            If _idpedido > 0 Then
                If Pedidos.LeerId(_idpedido) = True Then

                    LbNom_BESTELLNR.Text = Pedidos.PED_BESTELLNR.Valor

                    If Clientes.LeerId(Pedidos.PED_idcliente.Valor) Then
                        LbNomPedido.Text = Clientes.CLI_Nombre.Valor
                    End If
                    If edicion = True Then
                        If TxDato_1.Text = "" Then
                            Dim albaran As String = AlbaranesDelPedido(_idpedido)
                            If VaInt(albaran) = 0 Then
                                TxDato_1.Text = "+"
                                LbId.Text = "+"
                            Else
                                If Albsalida.LeerId(albaran) = True Then
                                    LbId.Text = albaran
                                    TxDato_1.Text = Albsalida.ASA_albaran.Valor
                                    Me.Siguiente(0)

                                    Exit Sub
                                End If
                            End If
                        Else
                            If LbId.Text = "+" Then

                                If TieneAlbaranes(_idpedido) = True Then
                                    MsgBox("Atencion, este pedido ya tiene albaranes asignados")
                                End If

                            End If

                        End If


                        TxDato_4.Text = Pedidos.PED_idcliente.Valor
                        TxTipoPorte.Text = Pedidos.PED_idporte.Valor
                        If ClientesDescargas.LeerId(Pedidos.PED_iddestino.Valor) = True Then
                            TxDomicilio.Text = ClientesDescargas.CLD_numero.Valor
                        End If
                        TxFc.Text = Clientes.CLI_FC.Valor
                        TxDivisa.Text = Pedidos.PED_iddivisa.Valor
                        TxValorCambio.Text = Pedidos.PED_valorcambio.Valor

                        If TxDato_6.Text.Trim = "" Then
                            If VaInt(Pedidos.PED_idtransportista.Valor) > 0 Then
                                TxDato_6.Text = Pedidos.PED_idtransportista.Valor
                            End If
                        End If

                        If Pedidos.PED_matriculacamion.Valor <> "" Then
                            TxDato_7.Text = Pedidos.PED_matriculacamion.Valor
                        End If
                        If Pedidos.PED_matricularemolque.Valor <> "" Then
                            TxDato_8.Text = Pedidos.PED_matricularemolque.Valor
                        End If
                        If Pedidos.PED_referencia.Valor <> "" Then
                            TxDato_5.Text = Pedidos.PED_referencia.Valor
                        End If
                        If Pedidos.PED_MovilChofer.Valor & "" <> "" Then
                            TxMovilChofer.Text = Pedidos.PED_MovilChofer.Valor
                        End If

                    End If

                End If

            Else
                TxPedido.MiError = True
                MsgBox("Pedido inexistente")
            End If

        End If
    End Sub



    Private Function AlbaranesDelPedido(idpedido As Integer) As Integer

        Dim ret As Integer

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Albsalida.ASA_idalbaran, "idalbaran")
        consulta.SelCampo(Albsalida.ASA_albaran, "Albaran")
        consulta.SelCampo(Albsalida.ASA_fechasalida, "Fecha")
        consulta.SelCampo(Albsalida.ASA_matricularemolque, "Matricula")
        Dim s As String = "Select count(*) from albsalida_palets where asp_idalbaran = asa_idalbaran"
        Dim palets As New Cdatos.bdcampo("@(" + s + ")", Cdatos.TiposCampo.Entero, 10)
        consulta.SelCampo(palets, "Palets")
        consulta.WheCampo(Albsalida.ASA_idpedido, "=", idpedido.ToString)
        Dim Sql As String = consulta.SQL
        Dim dt As DataTable = Albsalida.MiConexion.ConsultaSQL(Sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count = 1 Then
                ret = VaInt(dt.Rows(0)("idAlbaran"))
            ElseIf dt.Rows.Count = 0 Then
                ret = 0
            Else

                ret = VaInt(SeleccionarAlbaran(dt))


            End If
        End If
        Return ret
    End Function

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


    Private Function SeleccionarAlbaran(dt As DataTable) As String
        Dim lst As New List(Of Parametros)
        Dim ret As String = ""



        lst.Add(New Parametros("IdAlbaran", False, "", -1))
        lst.Add(New Parametros("Albaran", False, "", 100))
        lst.Add(New Parametros("Fecha", False, "", 150))
        lst.Add(New Parametros("Matricula", False, "", 200))
        lst.Add(New Parametros("Palets", True, "{0:n0}", 100))



        Dim f As New FrConsultaGenerica(dt, lst, "Albaranes del pedido")
        f.ShowDialog()
        If Not RowDePaso Is Nothing Then
            ret = RowDePaso("idAlbaran").ToString
        End If

        Return ret
    End Function

    Private Sub TxDomicilio_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDomicilio.TextChanged

    End Sub

    Private Sub TxDomicilio_Valida(edicion As Boolean) Handles TxDomicilio.Valida
        If TxDomicilio.Text = "" Then
            TxDomicilio.Text = "1"
        End If

        'ClientesDescargas.LeerDomi(TxDato_4.Text, TxDomicilio.Text)
        '_iddomicilio = VaInt(ClientesDescargas.CLD_Id.Valor)

        _iddomicilio = VaInt(ClientesDescargas.LeerDomi(TxDato_4.Text, TxDomicilio.Text))

        If _iddomicilio > 0 Then
            If ClientesDescargas.LeerId(_iddomicilio) = True Then
                LbNomDestino.Text = ClientesDescargas.CLD_Domicilio.Valor
                If edicion = True Then
                    TxTipoPorte.Text = ClientesDescargas.CLD_idtipoporte.Valor
                End If

            End If
        Else
            TxDomicilio.MiError = True
            MsgBox("Domicilio inexistente")
        End If

    End Sub

    Private Sub TxDato_4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato_4.TextChanged

    End Sub

    Private Sub TxDato_4_Valida(edicion As Boolean) Handles TxDato_4.Valida

        BtBuscaDestino.CL_Filtro = "IDCLIENTE=" + TxDato_4.Text

        If edicion = True Then

            If TxFc.Text = "" Then
                TxFc.Text = Clientes.CLI_FC.Valor
            End If

            Dim Bloqueado As String = (Clientes.CLI_Bloqueo.Valor & "").Trim.ToUpper

            If Bloqueado = "S" Then
                XtraMessageBox.Show("CLIENTE BLOQUEADO" & vbCrLf & Clientes.CLI_Bloqueocausa.Valor, "CLIENTE BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxDato_4.MiError = True
            End If


            If TxDivisa.Text.Trim = "" Then
                TxDivisa.Text = Clientes.CLI_Iddivisa.Valor
                TxDivisa.Validar(edicion)
            End If

        End If

    End Sub

    Private Sub TxValorCambio_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxValorCambio.TextChanged

    End Sub

    Private Sub TxValorCambio_Valida(edicion As Boolean) Handles TxValorCambio.Valida
        If VaInt(TxValorCambio.Text) = 0 Then
            TxValorCambio.Text = "1"
        End If
    End Sub

    Private Sub TxDivisa_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDivisa.TextChanged
      
    End Sub

    

    Private Sub BuscaPEd()
        Dim lst As New List(Of Parametros)
        Dim Fedia As String = TxDato_2.Text
        If Fedia = "" Then
            Fedia = Format(Now, "dd/MM/yyyy")
        End If
        Dim dt As DataTable = Pedidos.PedidosPteCarga(Fedia)


        lst.Add(New Parametros("idpedido", False, "", -1))
        lst.Add(New Parametros("Albaran", False, "", -1))
        lst.Add(New Parametros("Pedido", False, "", 100))
        lst.Add(New Parametros("FechaSalida", False, "", 150))
        lst.Add(New Parametros("Cliente", False, "", 300))
        lst.Add(New Parametros("Referencia", False, "", 200))
        lst.Add(New Parametros("Matricula", False, "", 200))
        lst.Add(New Parametros("Transportista", False, "", 200))
        lst.Add(New Parametros("Palets", True, "{0:n0}", 100))



        Dim f As New FrConsultaGenerica(dt, lst, "Pedidos pendientes del dia")
        f.ShowDialog()
        If TxPedido.Enabled = True Then
            If Not RowDePaso Is Nothing Then
                TxPedido.Text = RowDePaso("Pedido").ToString
                TxPedido.Validar(True)
                TxDato_4.Focus()
            End If
        End If
    End Sub

    
    Private Sub BtBuscaPedido_Click(sender As System.Object, e As System.EventArgs) Handles BtBuscaPedido.Click
        BuscaPEd()
    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirAlbaranSalida(LbId.Text, TipoImpresion.Preliminar, 0)
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaInt(LbId.Text) > 0 Then
            Dim Listado As New Listado_CargaPalets(LbId.Text)
            Listado.ImprimirListado(True)
        End If

    End Sub
    

    Private Sub TxDivisa_Valida(edicion As Boolean) Handles TxDivisa.Valida

        If VaInt(TxDivisa.Text) = 0 Then
            TxDivisa.Text = "1"
        End If

        If edicion Then
            If TxValorCambio.Text.Trim = "" Then TxValorCambio.Text = VaDec(Moneda.MON_Cambio.Valor).ToString("#,##0.000000")
        End If

    End Sub

    Private Sub btPlanoCarga_Click(sender As System.Object, e As System.EventArgs) Handles btPlanoCarga.Click
        If VaInt(LbId.Text) > 0 Then
            Dim Listado As New PlanoDeCarga(LbId.Text)
            Listado.ImprimirListado(False)
        End If
    End Sub

    Public Overrides Sub BotonAuxiliar3()

        If VaDec(LbId.Text) > 0 Then
            C1_EnviarAlbaranSalida(LbId.Text)
            MsgBox("Enviado!")
        End If

    End Sub

    Private Sub GridViewLineas_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridViewLineas.RowCellStyle
        If e.Column.FieldName.ToUpper.Trim = "ENTCONF" Then
            e.Appearance.ForeColor = Color.Red
        End If
    End Sub



    Private Sub GridViewLineas_CustomColumnDisplayText(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridViewLineas.CustomColumnDisplayText
        If e.Column.FieldName.Trim.ToUpper = "ENTCONF" Then
            If VaInt(e.Value) = 0 Then e.DisplayText = ""
        End If
    End Sub

    Private Sub ChkImprimirCMR_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkImprimirCMR.CheckedChanged
        ChkImprimirEtiquetaCMR.Checked = ChkImprimirCMR.Checked
    End Sub

    Private Sub TxDato_2_Valida(edicion As System.Boolean) Handles TxDato_2.Valida

        If edicion = True Then
            Dim E As String = ControlaFecha(TxDato_2.Text)
            If E <> "" Then
                MsgBox(E)
                TxDato_2.MiError = True
            End If
        End If

    End Sub


    Private Sub TxCampa_Enter(sender As System.Object, e As System.EventArgs) Handles TxCampa.Enter

        If NuevoRegistro Or Modificando Then
            If TxCampa.Text.Trim = "" Then
                TxCampa.Text = Lbejer.Text
            End If
        End If

    End Sub

    
    Private Sub ClGrid1_DespuesIntro() Handles ClGrid1.DespuesIntro

        TxDato_10.Select()
        TxDato_10.Focus()

    End Sub


    Protected Overrides Function HayQueGuardarLinea(Control As System.Windows.Forms.Control) As Boolean

        Dim ret As Boolean = True


        If Control Is TxDato_10 Then
            If TxDato_10.Text.Trim = "." Then
                ret = False
            End If
        End If



        Return ret

    End Function


    Private Sub TxCampa_Valida(edicion As System.Boolean) Handles TxCampa.Valida

        If edicion Then

            TxCampa.MiError = False

            Dim Ejercicios As New E_Ejercicios(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
            If Not Ejercicios.LeerId(TxCampa.Text) Then
                MsgBox("La campaña especificada no existe")
                TxCampa.MiError = True
            End If

            'Si la campaña del lote está bloqueada, sólo se puede introducir la campaña del lote (en caso de nueva línea)
            If Not TxCampa.MiError And _CampaBloqueada And Not TxCampa.Bloqueado Then
                If VaInt(TxCampa.Text) <> VaInt(Lbejer.Text) Then
                    MsgBox("Ejercicio no válido, sólo se permiten palets de la campaña actual")
                    TxCampa.MiError = True
                End If
            End If

        End If

    End Sub
    
End Class