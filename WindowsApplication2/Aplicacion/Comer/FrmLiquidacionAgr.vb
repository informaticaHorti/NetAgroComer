Imports DevExpress.XtraEditors

Public Class FrmLiquidacionAgr
    Inherits FrMantenimiento


    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim liquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)
    Dim Bancos As New E_Bancos(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim TipoDoc As New E_TipoDocumento(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))


    Dim IdAsientonet As Integer

    Dim _FechaVto As String = ""
    Dim _SituacionCartera As String = ""
    Dim _TipoDoc As String = ""


    Dim acum As New Acumulador


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


        ParametrosFrm()


    End Sub


    Private Sub ParametrosFrm()
        EntidadFrm = liquidacionAgr


        Dim lc As New List(Of Object)
        ListaControles = lc



        CampoClave = 1 ' ultimo campo de la clave

        ParamTx(TxSerie, liquidacionAgr.LIQ_serie, LbFactura, True)
        ParamTx(TxNuliqui, liquidacionAgr.LIQ_numero, LbFactura, True)
        TxNuliqui.Autonumerico = False

        ParamTx(TxFecha, liquidacionAgr.LIQ_fecha, LbFecha, True)
        ParamTx(TxDFecha, liquidacionAgr.LIQ_DeFecha, LbDfecha, True)
        ParamTx(TxAfecha, liquidacionAgr.LIQ_Afecha, LbAfecha, True)
        ParamTx(TxBanco, liquidacionAgr.LIQ_Idbanco, LbBanco, True)
        ParamTx(TxTalon, liquidacionAgr.LIQ_Nutalon, LbTalon, False)

        ParamTx(TxFechaVto, liquidacionAgr.LIQ_FechaVto, LbFechaVto)
        ParamTx(TxSitCartera, liquidacionAgr.LIQ_SituacionCartera, LbSitCartera)
        ParamTx(TxTipoDoc, liquidacionAgr.LIQ_TipoDocumento, LbTipoDoc)

        ParamTx(TxSaldo, liquidacionAgr.LIQ_ImpAnterior, Lb10, False)
        ParamTx(TxAnticipos, liquidacionAgr.LIQ_DtoAnticipos, LbAnticipos, False)
        ParamTx(TxSuministros, liquidacionAgr.LIQ_DtoSumi, LbSuministros, False)
        ParamTx(TxPortes, liquidacionAgr.LIQ_DtoPortes, LbPortes, False)


        AsociarControles(TxSerie, BtBuscaAlbaran, liquidacionAgr.btBusca, liquidacionAgr)
        AsociarControles(TxBanco, BtBanco, Bancos.btBusca, Bancos, Bancos.Nombre, LbNomBanco)

        AsociarControles(TxSitCartera, BtBuscaSitCartera, Bancos.btBusca, Bancos, Bancos.Nombre, LbNom_SitCartera)
        AsociarControles(TxTipoDoc, BtBuscaTipoDoc, TipoDoc.btBusca, TipoDoc, TipoDoc.Nombre, LbNom_TipoDoc)



        FiltroEntidad.Add(liquidacionAgr.LIQ_idempresa.NombreCampo, MiMaletin.IdEmpresaCTB.ToString)
        FiltroEntidad.Add(liquidacionAgr.LIQ_ejercicio.NombreCampo, MiMaletin.Ejercicio.ToString)

    End Sub


    Private Sub FrmFacturacion_Load(sender As Object, e As System.EventArgs) Handles Me.Load



        BTaux1.Text = "Imprimir"
        BTaux1.Image = NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        BTaux1.Visible = True

        BtAux2.Text = "I.Directa"
        BtAux2.Image = NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        BtAux2.Visible = True


    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave

        Dim i As Integer
        i = liquidacionAgr.LeerLiquidacion(LbNuCTB.Text, Lbejer.Text, TxSerie.Text, VaInt(TxNuliqui.Text))
        If i > 0 Then
            LbId.Text = i.ToString
        End If


    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()


        PintaPuntoVenta(liquidacionAgr.LIQ_idempresa.Valor, liquidacionAgr.LIQ_ejercicio.Valor, liquidacionAgr.LIQ_IdAsiento.Valor)
        Lbejer.Text = liquidacionAgr.LIQ_ejercicio.Valor
        LbNuCTB.Text = liquidacionAgr.LIQ_idempresa.Valor

        LbCodigo.Text = liquidacionAgr.LIQ_Idagricultor.Valor

        If Agricultores.LeerId(LbCodigo.Text) = True Then

            LbnomAgr1.Text = Agricultores.AGR_Nombre.Valor

            If VaDate(TxFecha.Text) > VaDate("") Then
                Dim DiasVto As Integer = VaInt(Agricultores.AGR_DiasVto.Valor)
                If DiasVto > 0 Then
                    _FechaVto = DateAdd(DateInterval.Day, DiasVto, VaDate(TxFecha.Text))
                End If
            End If

            _SituacionCartera = (Agricultores.AGR_SituacionCartera.Valor & "").Trim
            _TipoDoc = (Agricultores.AGR_TipoDocumento.Valor & "").Trim

        End If


        LbImpFacturas.Text = VaDec(liquidacionAgr.LIQ_ImpFacturas.Valor).ToString("#,###0.00")


        Select Case VaInt(liquidacionAgr.LIQ_IdFormaPago.Valor)
            Case E_Agricultores.FormasPago.Talon
                rbTalon.Checked = True
            Case E_Agricultores.FormasPago.Pagare
                RbPagare.Checked = True
            Case E_Agricultores.FormasPago.Transferencia
                RbTransferencia.Checked = True
        End Select



        CargaFacturas()
        CalculaTotal()

        ' llenar el grid


        'CargaAlbaranes()


    End Sub


    Private Sub CargaFacturas()
        Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)
        Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(FacturaAgr.FGR_serie, "Serie")
        consulta.SelCampo(FacturaAgr.FGR_numerofactura, "Numero")
        consulta.SelCampo(FacturaAgr.FGR_fecha, "Fecha")
        consulta.SelCampo(SemanasPartes.SEV_Semana, "Semana", FacturaAgr.FGR_Idsemana)
        consulta.SelCampo(FacturaAgr.FGR_TotalFactura, "Importe")
        consulta.WheCampo(FacturaAgr.FGR_IdLiquidacion, "=", LbId.Text)
        Dim sql As String = consulta.SQL
        Dim dt As DataTable = FacturaAgr.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt


    End Sub

    Private Sub CalculaTotal()
        Dim t As Decimal = 0
        t = VaDec(LbImpFacturas.Text) + VaDec(TxSaldo.Text) - VaDec(TxAnticipos.Text) - VaDec(TxSuministros.Text) - VaDec(TxPortes.Text)
        LbResultado.Text = t.ToString("#,###0.00")


    End Sub
    Private Sub AjustaColumnas()

    End Sub
    Public Overrides Sub Anular()
        MyBase.Anular()

    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If CDate(liquidacionAgr.LIQ_fecha.Valor) < MiMaletin.FechaCtbIva Then
            MsgBox("Fecha contabilidad bloqueada")
            Exit Sub
        End If

      
        MyBase.BAnular_Click(sender, e)

    End Sub

    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If VaDate(liquidacionAgr.LIQ_fecha.Valor) < MiMaletin.FechaCtbIva Then
            MsgBox("Fecha contabilidad bloqueada")
            Exit Sub
        End If

       


        MyBase.BModificar_Click(sender, e)


    End Sub


    Private Sub PintaPuntoVenta(ByVal idempresa As Integer, ByVal ejer As String, ByVal idasiento As String)

        Dim asientos As New E_Asientos(Idusuario, ConexCtb(idempresa))

        IdAsientonet = VaInt(idasiento)
        If VaInt(idasiento) > 0 Then
            LbAsiento.Text = asientos.NumeroAsiento(idasiento)
        End If
        Lbejer.Text = ejer
        LbNuCTB.Text = idempresa


    End Sub





    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        PintaPuntoVenta(MiMaletin.IdEmpresaCTB, MiMaletin.Ejercicio.ToString, "")
        Lbejer.Text = MiMaletin.Ejercicio
        LbNuCTB.Text = MiMaletin.IdEmpresaCTB
        IdAsientonet = 0

        Grid.DataSource = Nothing

        LbImpFacturas.Text = ""

        LbResultado.Text = ""
        LbCodigo.Text = ""
        LbnomAgr1.Text = ""


        rbTalon.Checked = True


        _FechaVto = ""
        _SituacionCartera = ""
        _TipoDoc = ""


    End Sub


    Public Overrides Sub Modificar()
        MyBase.Modificar()

        If RbPagare.Checked Then
            ValoresPorDefectoCartera(RbPagare.Checked)
        End If

    End Sub


    Private Sub ValoresPorDefectoCartera(bPagare As Boolean)

        If bPagare Then

            If TxFechaVto.Text.Trim = "" And VaDate(_FechaVto) > VaDate("") Then
                TxFechaVto.Text = _FechaVto
                TxFechaVto.Validar(True)
            End If

            If TxSitCartera.Text.Trim = "" And VaInt(_SituacionCartera) > 0 Then
                TxSitCartera.Text = _SituacionCartera
                TxSitCartera.Validar(True)
            End If

            If TxTipoDoc.Text.Trim = "" And VaInt(_TipoDoc) > 0 Then
                TxTipoDoc.Text = _TipoDoc
                TxTipoDoc.Validar(True)
            End If

        Else

            TxFechaVto.Text = ""
            TxSitCartera.Text = ""
            TxTipoDoc.Text = ""

        End If
        

    End Sub


    Public Overrides Sub Guardar()

        Dim t As Decimal = VaDec(LbResultado.Text)
        If t < 0 Then t = 0
        liquidacionAgr.LIQ_Apagar.Valor = t.ToString


        Select Case True
            Case rbTalon.Checked
                liquidacionAgr.LIQ_IdFormaPago.Valor = VaInt(E_Agricultores.FormasPago.Talon).ToString
            Case RbPagare.Checked
                liquidacionAgr.LIQ_IdFormaPago.Valor = VaInt(E_Agricultores.FormasPago.Pagare).ToString
            Case RbTransferencia.Checked
                liquidacionAgr.LIQ_IdFormaPago.Valor = VaInt(E_Agricultores.FormasPago.Transferencia).ToString
        End Select


        MyBase.Guardar()


    End Sub


    Public Overrides Sub DespuesdeGuardar()
        Dim TxError As String = ""
        MyBase.DespuesdeGuardar()


        If VaDec(LbId.Text) > 0 Then
            If XtraMessageBox.Show("¿Desea imprimir la factura?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                ' C1_ImprimirFacturaComercializacion(LbId.Text, TipoImpresion.Preliminar)
            End If
        End If


        If ConectarFinancieroContabilidad = "S" Then

            Dim i As Integer = liquidacionAgr.Contabiliza(LbId.Text)
            If i > 0 Then

                Dim ListaAsientos As New List(Of Integer)
                ListaAsientos.Add(i)
                Dim f As New frmVisualizadorAsiento(ListaAsientos, False, "")
                f.ShowDialog()

            Else
                MsgBox("no se generó asiento")
            End If


        End If


    End Sub



    Public Overrides Sub DespuesdeAnular()
        Dim c As New Contabilizacion.clAsientos

        MyBase.DespuesdeAnular()
        If IdAsientonet > 0 And VaInt(LbAsiento.Text) > 0 Then
            If c.AnularAsiento(ConexCtb(VaInt(LbNuCTB.Text)), IdAsientonet, LbAsiento.Text) <> 0 Then
                MsgBox("No se pudo anular el asiento ")
            Else
                MsgBox("Asiento anulado con exito")
            End If
        End If

    End Sub

    Private Sub LbAsiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbAsiento.Click
        If LbAsiento.Text <> "" Then

            Dim IdAsientoNET As Integer = VaInt(liquidacionAgr.LIQ_IdAsiento.Valor)
            Dim ListaAsientos As New List(Of Integer)
            ListaAsientos.Add(IdAsientoNET)
            Dim F As New FrmConsultaVisuAsiento(ListaAsientos, False)
            F.ShowDialog()

        End If
    End Sub


    Private Sub TxAnticipos_Valida(edicion As Boolean) Handles TxAnticipos.Valida
        If edicion = True Then
            CalculaTotal()
        End If
    End Sub


    Private Sub TxSuministros_Valida(edicion As Boolean) Handles TxSuministros.Valida
        If edicion = True Then
            CalculaTotal()
        End If

    End Sub


    Private Sub TxPortes_Valida(edicion As Boolean) Handles TxPortes.Valida
        If edicion = True Then
            CalculaTotal()
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaDec(LbId.Text) > 0 Then
            C1_ImprimirLiquidacionAgr(Nothing, LbId.Text, TipoImpresion.Preliminar, "")
        End If
    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaDec(LbId.Text) > 0 Then
            C1_ImprimirLiquidacionAgr(Nothing, LbId.Text, TipoImpresion.ImpresoraPorDefecto, "")
        End If
    End Sub


    Private Sub rbTalon_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbTalon.CheckedChanged

        If Not IsNothing(TxFechaVto.ClParam) Then
            If rbTalon.Checked Then
                TxFechaVto.ClParam.Obligatorio = False
                TxSitCartera.ClParam.Obligatorio = False
                TxTipoDoc.ClParam.Obligatorio = False
            End If
        End If

    End Sub

    Private Sub RbPagare_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbPagare.CheckedChanged

        If Not IsNothing(TxFechaVto.ClParam) Then

            If RbPagare.Checked Then

                TxFechaVto.ClParam.Obligatorio = True
                TxSitCartera.ClParam.Obligatorio = True
                TxTipoDoc.ClParam.Obligatorio = True

            End If

            'Actualizar datos de cartera desde los datos del agricultor, si están en blanco
            ValoresPorDefectoCartera(RbPagare.Checked)

        End If

    End Sub

    Private Sub RbTransferencia_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbTransferencia.CheckedChanged

        If Not IsNothing(TxFechaVto.ClParam) Then
            If RbTransferencia.Checked Then
                TxFechaVto.ClParam.Obligatorio = False
                TxSitCartera.ClParam.Obligatorio = False
                TxTipoDoc.ClParam.Obligatorio = False
            End If
        End If

    End Sub

    Private Sub TxFecha_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxFecha.EnabledChanged
        rbTalon.Enabled = TxFecha.Enabled
        RbPagare.Enabled = TxFecha.Enabled
        RbTransferencia.Enabled = TxFecha.Enabled
    End Sub

End Class