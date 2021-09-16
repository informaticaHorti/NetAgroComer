Imports DevExpress.XtraEditors

Public Class FrmCobros
    Inherits FrMantenimiento



    Dim err As New Errores

    Dim Cobros As New E_Cobros(Idusuario, cn)
    Dim CobrosLineas As New E_CobrosLineas(Idusuario, cn)
    Dim CobrosVtos As New E_CobrosVencimientos(Idusuario, cn)
    Dim Cuentas As New E_Cuentas(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim TipoDocumento As New E_TipoDocumento(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim FormasPago As New E_FormasPago(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim ConceptoCobros As New E_ConceptosCobros(Idusuario, cn)
    Dim PVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Facturas As New E_Facturas(Idusuario, cn)
    Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
    Dim Bancos As New E_Bancos(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))



    Dim divisafactura As Integer
    Dim IdasientoNet As Integer


    Private _Id As String = ""


    Public Sub New()

        'Llamada necesaria para el diseñador.
        InitializeComponent()

        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Public Sub New(Id As String)

        Me.new()
        _Id = Id

    End Sub


    Private Sub ParametrosFrm()

        EntidadFrm = Cobros


        Dim lc As New List(Of Object)
        ListaControles = lc



        ParamTx(TxDato1, Cobros.COB_NumeroCobro, Lb1, True)
        TxDato1.Autonumerico = True
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato6, Cobros.COB_FechaCobro, Lb9, True)
        ParamTx(TxDato11, Cobros.COB_FechaCtb, Lb36, True)
        ParamTx(TxDato50, Cobros.COB_IdPuntoVenta, Lb28, True)

        ParamTx(TxCliente, Cobros.COB_IdCliente, Lb3, True)
        ParamTx(TxEjercicioFactura, Facturas.FRA_campa, Lb23, True)
        ParamTx(TxSerie, Facturas.FRA_serie, Lb23)
        ParamTx(TxFactura, Facturas.FRA_factura, Lb23)
        ParamTx(TxImpCobro, CobrosLineas.CBL_ImporteCobradoDivisa, Lb10, True)



        'AsociarGrid(ClGrid1, TxSerie, TxImpCobro, CobrosLineas)
        AsociarGrid(ClGrid1, TxEjercicioFactura, TxImpCobro, CobrosLineas)


        ParamTx(TxCtaTesoreria, Cobros.COB_CuentaEfectivo)
        ParamTx(TxDato31, Cobros.COB_Idconcepto1)
        ParamTx(TxConcepto1, Cobros.COB_Concepto)
        ParamTx(TxImporteCon1, Cobros.COB_ImporteEfectivo)

        ParamTx(TxCtaGastosFinan, Cobros.COB_CtaGastosFinan)
        ParamTx(TxDato35, Cobros.COB_Idconcepto2)
        ParamTx(TxConcepto2, Cobros.COB_ConceptoGtosFinan)
        ParamTx(TxImporteCon2, Cobros.COB_ImporteGtosFinan)

        ParamTx(TxCtaDifCambio, Cobros.COB_CtaDifCambio)
        ParamTx(TxDato36, Cobros.COB_Idconcepto3)
        ParamTx(TxConcepto3, Cobros.COB_ConceptoDifCambio)
        ParamTx(TxImporteCon3, Cobros.COB_ImporteDifCambio)


        ParamTx(TxCtaCartera, Cobros.COB_CuentaVencimiento)
        ParamTx(TxSituacion, Cobros.COB_IdSituacion)

        ParamTx(TxVto1, Nothing, Nothing, False, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato37, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo, 0, 3)
        ParamTx(TxDato21, Nothing, Nothing, False, Cdatos.TiposCampo.Cadena, 0, 50)
        ParamTx(TxDato20, Nothing, Nothing, False, Cdatos.TiposCampo.Importe, 2, 10)
        ParamTx(TxDato17, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo, 0, 3)

        ParamTx(TxVto2, Nothing, Nothing, False, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato38, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo, 0, 3)
        ParamTx(TxDato26, Nothing, Nothing, False, Cdatos.TiposCampo.Cadena, 0, 50)
        ParamTx(TxDato25, Nothing, Nothing, False, Cdatos.TiposCampo.Importe, 2, 10)
        ParamTx(TxDato18, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo, 0, 3)

        ParamTx(TxVto3, Nothing, Nothing, False, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato39, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo, 0, 3)
        ParamTx(TxDato30, Nothing, Nothing, False, Cdatos.TiposCampo.Cadena, 0, 50)
        ParamTx(TxDato29, Nothing, Nothing, False, Cdatos.TiposCampo.Importe, 2, 10)
        ParamTx(TxDato19, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo, 0, 3)

        ParamTx(TxVto4, Nothing, Nothing, False, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato40, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo, 0, 3)
        ParamTx(TxDato34, Nothing, Nothing, False, Cdatos.TiposCampo.Cadena, 0, 50)
        ParamTx(TxDato33, Nothing, Nothing, False, Cdatos.TiposCampo.Importe, 2, 10)
        ParamTx(TxDato27, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo, 0, 3)

        PropiedadesCamposGr(ClGrid1, CobrosLineas.CBL_IdLinea.NombreCampo, "CBL_IdLinea", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Serie", "Serie", True, 10)
        PropiedadesCamposGr(ClGrid1, "Factura", "Factura", True, 50)
        PropiedadesCamposGr(ClGrid1, "Fecha", "Fecha", True, 40, , "dd/MM/yyyy")
        PropiedadesCamposGr(ClGrid1, "Referencia", "Referencia", True, 50)
        PropiedadesCamposGr(ClGrid1, "Importe_Fac", "Importe_Fac", True, 50, True, "#0.00")
        PropiedadesCamposGr(ClGrid1, "Cobrado", "Cobrado", True, 50, True, "#0.00")
        PropiedadesCamposGr(ClGrid1, "IdCentro", "IdCentro", False)


        AsociarControles(TxDato1, BtBuscaCobro, Cobros.btBusca, Cobros)
        AsociarControles(TxCliente, BtBuscaCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb19)
        Lb51.CL_ControlAsociado = TxCliente

        AsociarControles(TxCtaTesoreria, BtBusca1, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lb8)
        AsociarControles(TxCtaGastosFinan, BtBusca3, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lb11)
        AsociarControles(TxCtaDifCambio, BtBusca4, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lb25)
        AsociarControles(TxCtaCartera, BtBusca6, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lb42)
        AsociarControles(TxSituacion, BtSituacion, Bancos.btBusca, Bancos, Bancos.Nombre, LbNomSitu)
        AsociarControles(TxDato50, BtBusPVta, PVenta.btBusca, PVenta, PVenta.Nombre, LbNomPvta)


        AsociarControles(TxDato17, BtBusca2, TipoDocumento.btBusca, TipoDocumento, TipoDocumento.Nombre, Lb21)
        AsociarControles(TxDato18, BtBusca5, TipoDocumento.btBusca, TipoDocumento, TipoDocumento.Nombre, Lb27)
        AsociarControles(TxDato19, BtBusca7, TipoDocumento.btBusca, TipoDocumento, TipoDocumento.Nombre, Lb46)
        AsociarControles(TxDato27, BtBusca8, TipoDocumento.btBusca, TipoDocumento, TipoDocumento.Nombre, Lb47)


        AsociarControles(TxDato31, BtBusca9, ConceptoCobros.btBusca, ConceptoCobros)
        AsociarControles(TxDato35, BtBusca10, ConceptoCobros.btBusca, ConceptoCobros)
        AsociarControles(TxDato36, BtBusca11, ConceptoCobros.btBusca, ConceptoCobros)

        AsociarControles(TxDato37, BtBusca12, ConceptoCobros.btBusca, ConceptoCobros)
        AsociarControles(TxDato38, BtBusca13, ConceptoCobros.btBusca, ConceptoCobros)
        AsociarControles(TxDato39, BtBusca14, ConceptoCobros.btBusca, ConceptoCobros)
        AsociarControles(TxDato40, BtBusca15, ConceptoCobros.btBusca, ConceptoCobros)





        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me
        BotonesAvance1.Filtro = "COB_EJERCICIO = " + MiMaletin.Ejercicio.ToString + " AND COB_IDCENTRO=" + MiMaletin.IdCentro.ToString



    End Sub


    Public Overrides Sub ControlClave()


        ' componemos la clave
        Dim i As Integer
        If TxDato1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = Cobros.LeerCobro(CInt(LbNuCtb.Text), CInt(LbEjerCtb.Text), CInt(LbCentro.Text), CInt(TxDato1.Text))
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

        End If


        If LbId.Text <> "" Then
            CargaLineasGrid()
        End If

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()



        CargarVencimientos()

        IdasientoNet = VaInt(Cobros.COB_idasiento.Valor)
        LbCentro.Text = Cobros.COB_IdCentro.Valor
        LbNuCtb.Text = Cobros.COB_IdEmpresa.Valor
        LbEjerCtb.Text = Cobros.COB_Ejercicio.Valor

        If Centros.LeerId(LbCentro.Text) = True Then
            LbNomCentro.Text = Centros.Nombre.Valor
        Else
            LbCentro.Text = ""
            LbNomCentro.Text = ""
        End If
        Dim asientos As New E_Asientos(Idusuario, ConexCtb(Val(LbNuCtb.Text)))

        If Asientos.LeerId(IdasientoNet.ToString) = True Then

            LbAsientoNet.Text = Asientos.Asiento.Valor


            'Juanjo

          

        Else
            MsgBox("No encuentro el asiento " + IdasientoNet.ToString)
        End If


        ' llenar el grid
        CargaLineasGrid()


        'CompruebaEjercicioCentro(Me, LbEjerCtb.Text, LbCentro.Text)

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)

        Dim Facturas As New E_Facturas(Idusuario, cn)

        Dim IdFactura As String = CobrosLineas.CBL_IdFactura.Valor


        If VaInt(IdFactura) > 0 Then
            If Facturas.LeerId(IdFactura) Then
                TxEjercicioFactura.Text = Facturas.FRA_campa.Valor
                TxSerie.Text = Facturas.FRA_serie.Valor
                TxFactura.Text = Facturas.FRA_factura.Valor
            End If
        End If


        DatosFacturas()
        totales()

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean


        'asociar cabecera con lineas
        Dim r As Boolean
        If TxDato1.Text = "+" Then
            LbId.Text = Cobros.MaxId
            TxDato1.Text = Cobros.MaxIdCampa(Val(LbNuCtb.Text), Val(LbEjerCtb.Text), Val(LbCentro.Text))
        End If

        Cobros.COB_IdCobro.Valor = LbId.Text
        Cobros.COB_Ejercicio.Valor = LbEjerCtb.Text
        Cobros.COB_IdEmpresa.Valor = LbNuCtb.Text
        Cobros.COB_IdCentro.Valor = LbCentro.Text

        CobrosLineas.CBL_IdCobro.Valor = LbId.Text
        CobrosLineas.CBL_Cambio.Valor = Lbcambiofac.Text
        CobrosLineas.CBL_IdDivisa.Valor = divisafactura.ToString


        Dim Facturas As New E_Facturas(Idusuario, cn)
        'If Facturas.LeerFac(VaInt(LbNuCtb.Text), VaInt(LbEjerCtb.Text), TxSerie.Text, VaInt(TxFactura.Text)) > 0 Then
        If Facturas.LeerFac(VaInt(LbNuCtb.Text), VaInt(TxEjercicioFactura.Text), TxSerie.Text, VaInt(TxFactura.Text)) > 0 Then
            CobrosLineas.CBL_IdFactura.Valor = Facturas.FRA_idfactura.Valor
        End If


        SqlGrid()


        r = MyBase.GuardarLineas(Gr)
        Return r

    End Function


    Public Overrides Sub DespuesdeCargarLineas(gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)

        CompletarGrid()

    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)

        Lbptefac.Text = ""
        Lbimfac.Text = ""
        Lbmoneda.Text = ""
        Lbcambiofac.Text = ""
        LbEurosfac.Text = ""

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


        LbCentro.Text = MiMaletin.IdCentro
        LbAsientoNet.Text = ""
        LbEjerCtb.Text = MiMaletin.Ejercicio
        LbNuCtb.Text = MiMaletin.IdEmpresaCTB
        IdasientoNet = 0

        If Centros.LeerId(LbCentro.Text) = True Then
            LbNomCentro.Text = Centros.Nombre.Valor
        End If


        Dim CtaTesoreria As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CUENTA_DEFECTO_COBROS_TESORERIA) & ""
        Dim CtaGastosFin As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CUENTA_DEFECTO_COBROS_GASTOSFIN) & ""
        Dim CtaDifCambio As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CUENTA_DEFECTO_COBROS_DIFCAMBIO) & ""
        Dim CtaCartera As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CUENTA_DEFECTO_COBROS_CARTERA) & ""

        TxCtaTesoreria.Text = CtaTesoreria
        TxCtaGastosFinan.Text = CtaGastosFin
        TxCtaDifCambio.Text = CtaDifCambio
        TxCtaCartera.Text = CtaCartera

        TxCtaTesoreria.MiError = False
        TxCtaGastosFinan.MiError = False
        TxCtaDifCambio.MiError = False
        TxCtaCartera.MiError = False

        TxCtaTesoreria.Validar(False)
        TxCtaGastosFinan.Validar(False)
        TxCtaDifCambio.Validar(False)
        TxCtaCartera.Validar(False)


    End Sub


    Private Sub CargaLineasGrid()

        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)

        ClGrid1.GridView.RefreshData()

    End Sub


    Private Sub CompletarGrid()


        Dim Toeuros As Decimal = 0


        For Each dr As DataRowView In ClGrid1.GridView.DataSource
            If Not dr("Idfactura") Is DBNull.Value Then

                If Facturas.LeerId(dr("Idfactura").ToString) = True Then
                    dr("Serie") = Facturas.FRA_serie.Valor & ""
                    dr("Factura") = Facturas.FRA_factura.Valor & ""
                    dr("Fecha") = VaDate(Facturas.FRA_fecha.Valor)
                    dr("Importe_Fac") = VaDec(Facturas.FRA_totalfactura.Valor)
                    dr("Cobrado_Euros") = VaDec(dr("Cobrado")) * VaDec(Facturas.FRA_valorcambio.Valor)
                    dr("IdCentro") = VaInt(Facturas.FRA_idcentro.Valor)
                    dr("Referencia") = Facturas.FRA_RefCliente.Valor

                    Toeuros = Toeuros + VaDec(dr("Cobrado_Euros"))
                End If

            End If

        Next

        LbToerosfac.Text = Format(Toeuros, "#,###0.00")
        totales()

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

        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(CobrosLineas.CBL_IdLinea, "CBL_IdLinea")
        CONSULTA.SelCampo(CobrosLineas.CBL_IdFactura, "Idfactura")
        CONSULTA.SelCampo(Nothing, "Serie")
        CONSULTA.SelCampo(Nothing, "Factura")
        CONSULTA.SelCampo(Nothing, "Fecha")
        CONSULTA.SelCampo(Nothing, "Referencia")
        CONSULTA.SelCampo(Nothing, "Importe_Fac", , , "0.00")
        CONSULTA.SelCampo(CobrosLineas.CBL_ImporteCobradoDivisa, "Cobrado")
        CONSULTA.SelCampo(Nothing, "Cobrado_Euros")
        CONSULTA.SelCampo(Nothing, "IdCentro")


        CONSULTA.WheCampo(CobrosLineas.CBL_IdCobro, "=", id)
        Dim sql As String = CONSULTA.SQL
        sql = sql + " order by CBL_idlinea"

        ClGrid1.Consulta = sql

    End Sub


    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNuevo.Click
        If TxDato1.Text = "" And TxDato1.Enabled = True Then
            TxDato1.Text = "+"
            Siguiente(0)
        End If
    End Sub


    Public Overrides Sub DespuesdeAnular()
        MyBase.DespuesdeAnular()


        Dim NumAsientoNet As Integer = 0
        Dim AsientoAnulacion As New E_Asientos(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        If AsientoAnulacion.LeerId(IdasientoNet) Then
            NumAsientoNet = VaInt(AsientoAnulacion.Asiento.Valor)
        End If


        If IdasientoNet > 0 And NumAsientoNet > 0 Then
            Dim c As New Contabilizacion.clAsientos
            If c.AnularAsiento(ConexCtb(VaInt(LbNuCtb.Text)), IdasientoNet, NumAsientoNet) = 0 Then
                MsgBox("Asiento anulado con exito")
            End If

        End If

    End Sub


    Public Overrides Sub Guardar()


        TxCtaCartera.Validar(True)

        If TxVto1.Text.Trim <> "" Or TxVto2.Text.Trim <> "" Or TxVto3.Text.Trim <> "" Or TxVto4.Text.Trim <> "" Then

            'Verificamos cuenta de cartera para los vencimientos
            If TxCtaCartera.Text.Trim = "" Then
                MsgBox("Debe introducir una cuenta de cartera para los vencimientos")
                TxCtaCartera.MiError = True
            End If

            'Verificamos situación (banco) para los vencimientos
            If TxSituacion.Text.Trim = "" Then
                MsgBox("Debe introducir un banco (situación) para los vencimientos")
                TxSituacion.MiError = True
            End If

            'Comprobamos tipo de documento de los vencimientos
            If TxVto1.Text.Trim <> "" And TxDato17.Text.Trim = "" Then
                MsgBox("Debe introducir un tipo de documento para el primer vencimiento")
                TxDato17.MiError = True
            End If
            If TxVto2.Text.Trim <> "" And TxDato18.Text.Trim = "" Then
                MsgBox("Debe introducir un tipo de documento para el segundo vencimiento")
                TxDato18.MiError = True
            End If
            If TxVto3.Text.Trim <> "" And TxDato19.Text.Trim = "" Then
                MsgBox("Debe introducir un tipo de documento para el tercer vencimiento")
                TxDato19.MiError = True
            End If
            If TxVto4.Text.Trim <> "" And TxDato27.Text.Trim = "" Then
                MsgBox("Debe introducir un tipo de documento para el cuarto vencimiento")
                TxDato27.MiError = True
            End If

        End If


        If PVenta.LeerId(TxDato50.Text) = True Then
            Cobros.COB_IdActividad.Valor = PVenta.IdActividad.Valor
            Cobros.COB_IdSeccion.Valor = PVenta.IdSeccion.Valor
        Else
            Cobros.COB_IdActividad.Valor = MiMaletin.IdActividad.ToString
            Cobros.COB_IdSeccion.Valor = MiMaletin.IdSeccion.ToString
        End If

        Cobros.COB_IdDivisa.Valor = "1"
        Cobros.COB_Cambio.Valor = "1"
        Cobros.COB_CobradoDivisa.Valor = ""
        Cobros.COB_CobradoEuros.Valor = LbToerosfac.Text
        Select Case VaDec(LbdifCobro.Text)
            Case Is >= 0
                Cobros.COB_CuentaDifCobro.Valor = "66910000000"
            Case Else
                Cobros.COB_CuentaDifCobro.Valor = "76910000000"
        End Select
        Cobros.COB_ImporteDifCobro.Valor = LbdifCobro.Text
        Cobros.COB_IdDepartamento.Valor = ""
        Cobros.COB_IdSubdepartamento.Valor = ""


        Dim dt As DataTable = Nothing
        If Not IsNothing(ClGrid1.Grid.DataSource) Then dt = CType(ClGrid1.Grid.DataSource, DataTable)
        Dim bPreguntar As Boolean = (Modificando And Not NuevoRegistro)
        Dim IdCobro As String = LbId.Text
        Dim ImporteCobro As Decimal = VaDec(LbtotCobrado.Text)


        MyBase.Guardar()

    End Sub


    Public Overrides Sub DespuesdeGuardar()

        MyBase.DespuesdeGuardar()

        GuardarVencimientos()

        Dim i As Integer = Cobros.Contabiliza(LbId.Text, "", "", True)

        If i > 0 Then
            Dim ListaAsientos As New List(Of Integer)
            ListaAsientos.Add(i)
            Dim f As New frmVisualizadorAsiento(ListaAsientos, False, "")
            f.ShowDialog()
        Else
            MsgBox("no se generó asiento")
        End If


    End Sub


    Private Sub DatosFacturas()

        Dim Cobrado As Double

        Lbptefac.Text = ""
        Lbimfac.Text = ""
        Lbmoneda.Text = ""
        Lbcambiofac.Text = ""
        LbEurosfac.Text = ""



        Dim serie As String = TxSerie.Text
        Dim fra As String = TxFactura.Text

        Dim Facturas As New E_Facturas(Idusuario, cn)
        'If Facturas.LeerFac(MiMaletin.IdEmpresaCTB, VaInt(LbEjerCtb.Text), TxSerie.Text, VaInt(TxFactura.Text)) > 0 Then
        If Facturas.LeerFac(MiMaletin.IdEmpresaCTB, VaInt(TxEjercicioFactura.Text), TxSerie.Text, VaInt(TxFactura.Text)) > 0 Then
            Lbimfac.Text = Format(VaDec(Facturas.FRA_totalfactura.Valor), "#,###0.00")
            Lbmoneda.Text = ""
            Lbcambiofac.Text = Format(VaDec(Facturas.FRA_valorcambio.Valor), "###0.0000")
            Cobrado = CobrosLineas.CobradoFactura(Facturas.FRA_idfactura.Valor)
            Lbptefac.Text = Format(VaDec(Facturas.FRA_totalfactura.Valor) - Cobrado, "#,###0.00")
            divisafactura = VaInt(Facturas.FRA_cddivisa.Valor)
        End If



        LbEurosfac.Text = Format(VaDec(TxImpCobro.Text) * VaDec(Lbcambiofac.Text), "#,###0.00")

    End Sub


    Private Sub TxDato2_Valida(ByVal edicion As Boolean)

    End Sub


    Private Sub BtBusfac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtBusfac.Click
        If TxFactura.Enabled = True Then
            EnlazarFacturas()
        End If
    End Sub


    Private Sub EnlazarFacturas()


        Dim frm As New FrmSelFacCobros()

        Try
            Me.Enabled = False
            frm.init(TxCliente.Text, Lb19.Text, Lb51.Text)
            frm.ShowDialog()
        Catch ex As Exception
        End Try

        Me.Enabled = True


        Dim ListaDePaso As List(Of String) = frm.ListaDePaso

        If ListaDePaso.Count > 0 Then
            InsertarCobros(ListaDePaso)
        End If

    End Sub


    Private Sub InsertarCobros(ListaDePaso As List(Of String))

        Dim D As String()

        If LbId.Text = "+" Then

            LbId.Text = Cobros.MaxId
            If TxDato1.Text = "+" Or TxDato1.Text = "" Then
                TxDato1.Text = Cobros.MaxIdCampa(Val(LbNuCtb.Text), Val(LbEjerCtb.Text), Val(LbCentro.Text))
            End If
            Cobros.COB_IdCobro.Valor = LbId.Text
            Cobros.COB_Ejercicio.Valor = LbEjerCtb.Text
            Cobros.COB_IdCentro.Valor = LbCentro.Text
            Cobros.COB_IdEmpresa.Valor = LbNuCtb.Text
            Cobros.Insertar()

        End If

        For x As Integer = 0 To ListaDePaso.Count - 1

            D = Split(ListaDePaso.Item(x), Chr(9))

            If Facturas.LeerId(D(0)) Then

                CobrosLineas.VaciaEntidad()
                CobrosLineas.CBL_IdLinea.Valor = CobrosLineas.MaxId()
                CobrosLineas.CBL_IdFactura.Valor = D(0)
                CobrosLineas.CBL_IdCobro.Valor = LbId.Text
                CobrosLineas.CBL_ImporteCobradoDivisa.Valor = D(1)
                CobrosLineas.CBL_IdDivisa.Valor = Facturas.FRA_cddivisa.Valor
                CobrosLineas.CBL_Cambio.Valor = Facturas.FRA_valorcambio.Valor
                CobrosLineas.Insertar()
                HamodificadoGrid = True

            End If

        Next


        CargaLineasGrid()
        ClGrid1.GridView.FocusedRowHandle = ClGrid1.GridView.RowCount - 1
        TxFactura.Select()

    End Sub


    Private Sub TxImpCobro_Valida(ByVal edicion As Boolean) Handles TxImpCobro.Valida
        DatosFacturas()
        totales()
    End Sub


    'Private Sub BtBuscaCliente_AntesdeEnlazar() Handles BtBuscaCliente.AntesdeEnlazar
    '    BtBuscaCliente.CL_Filtro = "NUMEROCUENTA LIKE '" & TxCliente.Text & "%'"
    'End Sub


    Private Sub totales()

        Dim tc As Decimal = VaDec(TxImporteCon1.Text) + +VaDec(TxImporteCon2.Text) + VaDec(TxImporteCon3.Text) + VaDec(TxDato20.Text) + VaDec(TxDato25.Text) + VaDec(TxDato29.Text) + VaDec(TxDato33.Text)
        LbtotCobrado.Text = Format(tc, "#,###0.00")
        LbdifCobro.Text = Format(VaDec(LbToerosfac.Text) - tc, "#,###0.00")

    End Sub

    Private Sub TxDato8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxImporteCon1.KeyDown

        If e.KeyCode = Keys.F6 Then
            TxImporteCon1.Text = StDec(VaDec(LbdifCobro.Text) + VaDec(TxImporteCon1.Text))
        End If

    End Sub

    Private Sub TxDato8_Valida(ByVal edicion As Boolean) Handles TxImporteCon1.Valida
        totales()
    End Sub

    Private Sub TxDato9_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxImporteCon2.KeyDown

        If e.KeyCode = Keys.F6 Then
            TxImporteCon2.Text = StDec(VaDec(LbdifCobro.Text) + VaDec(TxImporteCon2.Text))
        End If

    End Sub


    Private Sub TxDato9_Valida(ByVal edicion As Boolean) Handles TxImporteCon2.Valida
        totales()
    End Sub

    Private Sub TxDato14_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxImporteCon3.KeyDown

        If e.KeyCode = Keys.F6 Then
            TxImporteCon3.Text = StDec(VaDec(LbdifCobro.Text) + VaDec(TxImporteCon3.Text))
        End If

    End Sub


    Private Sub TxDato14_Valida(ByVal edicion As Boolean) Handles TxImporteCon3.Valida
        totales()
    End Sub

    Private Sub TxDato20_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxDato20.KeyDown

        If e.KeyCode = Keys.F6 Then
            TxDato20.Text = StDec(VaDec(LbdifCobro.Text) + VaDec(TxDato20.Text))
        End If

    End Sub


    Private Sub TxDato20_Valida(ByVal edicion As Boolean) Handles TxDato20.Valida
        totales()
    End Sub

    Private Sub TxDato25_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxDato25.KeyDown

        If e.KeyCode = Keys.F6 Then
            TxDato25.Text = StDec(VaDec(LbdifCobro.Text) + VaDec(TxDato25.Text))
        End If

    End Sub


    Private Sub TxDato25_Valida(ByVal edicion As Boolean) Handles TxDato25.Valida
        totales()
    End Sub

    Private Sub TxDato29_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxDato29.KeyDown

        If e.KeyCode = Keys.F6 Then
            TxDato29.Text = StDec(VaDec(LbdifCobro.Text) + VaDec(TxDato29.Text))
        End If

    End Sub


    Private Sub TxDato29_Valida(ByVal edicion As Boolean) Handles TxDato29.Valida
        totales()
    End Sub

    Private Sub TxDato33_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxDato33.KeyDown

        If e.KeyCode = Keys.F6 Then
            TxDato33.Text = StDec(VaDec(LbdifCobro.Text) + VaDec(TxDato33.Text))
        End If

    End Sub


    Private Sub TxDato33_Valida(ByVal edicion As Boolean) Handles TxDato33.Valida
        totales()
    End Sub


    Private Sub GuardarVencimientos()


        Dim sql As String = "DELETE FROM CobrosVencimientos WHERE CVT_IdCobro = " + LbId.Text
        CobrosVtos.MiConexion.OrdenSql(sql)


        If VaDec(TxDato20.Text) <> 0 Then
            CobrosVtos.VaciaEntidad()
            CobrosVtos.CVT_IdVencimiento.Valor = CobrosVtos.MaxId
            CobrosVtos.CVT_IdCobro.Valor = LbId.Text
            CobrosVtos.CVT_Fecha.Valor = TxVto1.Text
            CobrosVtos.CVT_Importe.Valor = TxDato20.Text
            CobrosVtos.CVT_Concepto.Valor = TxDato21.Text
            CobrosVtos.CVT_Tipodocumento.Valor = TxDato17.Text
            CobrosVtos.CVT_Idconcepto.Valor = TxDato37.Text
            CobrosVtos.Insertar()
        End If

        If VaDec(TxDato25.Text) <> 0 Then
            CobrosVtos.VaciaEntidad()
            CobrosVtos.CVT_IdVencimiento.Valor = CobrosVtos.MaxId
            CobrosVtos.CVT_IdCobro.Valor = LbId.Text
            CobrosVtos.CVT_Fecha.Valor = TxVto2.Text
            CobrosVtos.CVT_Importe.Valor = TxDato25.Text
            CobrosVtos.CVT_Concepto.Valor = TxDato26.Text
            CobrosVtos.CVT_Tipodocumento.Valor = TxDato18.Text
            CobrosVtos.CVT_Idconcepto.Valor = TxDato38.Text
            CobrosVtos.Insertar()
        End If

        If VaDec(TxDato29.Text) <> 0 Then
            CobrosVtos.VaciaEntidad()
            CobrosVtos.CVT_IdVencimiento.Valor = CobrosVtos.MaxId
            CobrosVtos.CVT_IdCobro.Valor = LbId.Text
            CobrosVtos.CVT_Fecha.Valor = TxVto3.Text
            CobrosVtos.CVT_Importe.Valor = TxDato29.Text
            CobrosVtos.CVT_Concepto.Valor = TxDato30.Text
            CobrosVtos.CVT_Tipodocumento.Valor = TxDato19.Text
            CobrosVtos.CVT_Idconcepto.Valor = TxDato39.Text
            CobrosVtos.Insertar()
        End If

        If VaDec(TxDato33.Text) <> 0 Then
            CobrosVtos.VaciaEntidad()
            CobrosVtos.CVT_IdVencimiento.Valor = CobrosVtos.MaxId
            CobrosVtos.CVT_IdCobro.Valor = LbId.Text
            CobrosVtos.CVT_Fecha.Valor = TxVto4.Text
            CobrosVtos.CVT_Importe.Valor = TxDato33.Text
            CobrosVtos.CVT_Concepto.Valor = TxDato34.Text
            CobrosVtos.CVT_Tipodocumento.Valor = TxDato27.Text
            CobrosVtos.CVT_Idconcepto.Valor = TxDato40.Text
            CobrosVtos.Insertar()
        End If

    End Sub


    Private Sub CargarVencimientos()


        Dim sql As String = "SELECT * FROM CobrosVencimientos WHERE CVT_IdCobro=" + LbId.Text
        Dim dt As DataTable = CobrosVtos.MiConexion.ConsultaSQL(sql)

        Dim r As Integer = 0

        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                For Each rw As DataRow In dt.Rows
                    CobrosVtos.CargaCampos(rw)
                    If VaDec(CobrosVtos.CVT_Importe.Valor) <> 0 Then
                        r = r + 1
                        If r <= 4 Then
                            Select Case r
                                Case 1
                                    TxVto1.Text = CobrosVtos.CVT_Fecha.Valor
                                    TxDato20.Text = CobrosVtos.CVT_Importe.Valor
                                    TxDato21.Text = CobrosVtos.CVT_Concepto.Valor
                                    TxDato17.Text = CobrosVtos.CVT_Tipodocumento.Valor
                                    TxDato17.Validar(False)
                                    TxDato37.Text = CobrosVtos.CVT_Idconcepto.Valor
                                Case 2
                                    TxVto2.Text = CobrosVtos.CVT_Fecha.Valor
                                    TxDato25.Text = CobrosVtos.CVT_Importe.Valor
                                    TxDato26.Text = CobrosVtos.CVT_Concepto.Valor
                                    TxDato18.Text = CobrosVtos.CVT_Tipodocumento.Valor
                                    TxDato18.Validar(False)
                                    TxDato38.Text = CobrosVtos.CVT_Idconcepto.Valor
                                Case 3
                                    TxVto3.Text = CobrosVtos.CVT_Fecha.Valor
                                    TxDato29.Text = CobrosVtos.CVT_Importe.Valor
                                    TxDato30.Text = CobrosVtos.CVT_Concepto.Valor
                                    TxDato19.Text = CobrosVtos.CVT_Tipodocumento.Valor
                                    TxDato19.Validar(False)
                                    TxDato39.Text = CobrosVtos.CVT_Idconcepto.Valor
                                Case 4
                                    TxVto4.Text = CobrosVtos.CVT_Fecha.Valor
                                    TxDato33.Text = CobrosVtos.CVT_Importe.Valor
                                    TxDato34.Text = CobrosVtos.CVT_Concepto.Valor
                                    TxDato27.Text = CobrosVtos.CVT_Tipodocumento.Valor
                                    TxDato27.Validar(False)
                                    TxDato40.Text = CobrosVtos.CVT_Idconcepto.Valor
                            End Select
                        End If

                    End If
                Next
            End If
        End If


        totales()

    End Sub


    Private Sub Conceptos(ByVal id As String, ByVal Rellena As TxDato)

        If VaInt(id) > 0 Then
            If Rellena.Text = "" Then
                If ConceptoCobros.LeerId(id) = True Then
                    Rellena.Text = ConceptoCobros.COC_Nombre.Valor
                End If
            End If
        End If

    End Sub


    Private Sub TxDato5_Valida(ByVal edicion As Boolean) Handles TxCtaTesoreria.Valida
        If TxCtaTesoreria.Text = "" Then
            TxConcepto1.Text = ""
            TxImporteCon1.Text = ""
            totales()
            TxCtaTesoreria.Siguiente = TxCtaGastosFinan.Orden
        End If
    End Sub


    Private Sub TxDato13_Valida(ByVal edicion As Boolean) Handles TxCtaGastosFinan.Valida
        If TxCtaGastosFinan.Text = "" Then
            TxConcepto2.Text = ""
            TxImporteCon2.Text = ""
            totales()
            TxCtaGastosFinan.Siguiente = TxCtaDifCambio.Orden
        End If
    End Sub


    Private Sub TxDato16_Valida(ByVal edicion As Boolean) Handles TxCtaDifCambio.Valida
        If TxCtaDifCambio.Text = "" Then
            TxConcepto3.Text = ""
            TxImporteCon3.Text = ""
            totales()
            TxCtaDifCambio.Siguiente = TxCtaCartera.Orden()
        End If
    End Sub


    Private Sub TxDato23_Valida(ByVal edicion As Boolean)
        If TxVto1.Text = "" Then
            TxDato21.Text = ""
            TxDato20.Text = ""
            TxDato17.Text = ""
            totales()
            TxVto1.Siguiente = TxVto2.Orden
        End If
    End Sub


    Private Sub TxDato24_Valida(ByVal edicion As Boolean)
        If TxVto2.Text = "" Then
            TxDato26.Text = ""
            TxDato25.Text = ""
            TxDato18.Text = ""
            totales()
            TxVto2.Siguiente = TxVto3.Orden
        End If

    End Sub


    Private Sub TxDato28_Valida(ByVal edicion As Boolean)
        If TxVto3.Text = "" Then
            TxDato30.Text = ""
            TxDato29.Text = ""
            TxDato19.Text = ""
            totales()
            TxVto3.Siguiente = TxVto4.Orden
        End If

    End Sub


    Private Sub TxDato32_Valida(ByVal edicion As Boolean)
        If TxVto4.Text = "" Then
            TxDato34.Text = ""
            TxDato33.Text = ""
            TxDato27.Text = ""
            totales()
            TxVto4.Siguiente = TxDato27.Orden + 1
        End If

    End Sub


    Private Sub TxDato3_Valida(ByVal edicion As Boolean) Handles TxCliente.Valida

        Lb51.Text = ""

        If Clientes.LeerId(TxCliente.Text) Then
            Lb51.Text = Clientes.CLI_Nif.Valor
        End If

    End Sub


    Private Sub LbAsientoNet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbAsientoNet.Click

        If LbAsientoNet.Text <> "" Then

            Dim ListaAsientos As New List(Of Integer)
            ListaAsientos.Add(IdasientoNet)
            Dim F As New FrmConsultaVisuAsiento(ListaAsientos, False)
            F.ShowDialog()

        End If

    End Sub


    Private Sub FrmCobros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            BTaux1.Visible = True
            BTaux1.Text = "Imprimir"
            BTaux1.Image = PictureBox1.Image
            BtAux2.Visible = True
            BtAux2.Text = "I.Directa"
            BtAux2.Image = PictureBox2.Image


            If _Id.Trim <> "" Then

                BorraPan()

                TxDato1.Text = _Id
                TxDato1.Validar(True)

                Siguiente(TxDato1.Orden)

            End If

        Catch ex As Exception
            Dim Err As New Errores
            Err.Muestraerror("Error al cargar el formulario de cobros", "FrmCobros_Load", ex.Message)
        End Try


    End Sub


    Public Overrides Sub botonAuxiliar1()
        MyBase.BotonAuxiliar1()
        Dim listado As New Listado_Cobros(LbId.Text, LbCentro.Text, TxDato1.Text.Trim, TxDato6.Text.Trim, Lb19.Text, TipoImpresion.Preliminar)
        listado.ImprimirListado()
    End Sub


    Public Overrides Sub botonAuxiliar2()
        MyBase.BotonAuxiliar2()
        Dim listado As New Listado_Cobros(LbId.Text, LbCentro.Text, TxDato1.Text.Trim, TxDato6.Text.Trim, Lb19.Text, TipoImpresion.ImpresoraPorDefecto)
        listado.ImprimirListado()
    End Sub


    Private Sub VerporCentro()

        Dim Sql As String
        Dim dt As New DataTable
        Dim lst As New List(Of Parametros)

        If VaInt(LbId.Text) = 0 Then Exit Sub


        lst.Add(New Parametros("Cobrado", True, "{0:n2}", 0))

        Sql = " SELECT Facturas.FRA_IdCentro as IdCentro," & ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".dbo.centros.nombre, SUM(CBL_ImporteCobradoDivisa * FRA_ValorCambio) AS Cobrado " & vbCrLf
        Sql = Sql + " FROM CobrosLineas" & vbCrLf
        Sql = Sql + " LEFT OUTER JOIN Facturas ON CBL_IdFactura = FRA_IdFactura "
        Sql = Sql + " LEFT OUTER JOIN " & ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".dbo.centros on FRA_IdCentro=" & ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".dbo.centros.idcentro "
        Sql = Sql + " WHERE CBL_idcobro = " + LbId.Text
        Sql = Sql + " GROUP BY FRA_IdCentro," & ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".dbo.centros.nombre"
        dt = CobrosLineas.MiConexion.ConsultaSQL(Sql)
        Dim f As New FrConsultaGenerica(dt, lst, "Cobrado por centro")
        f.ShowDialog()

    End Sub


    Private Sub Botton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Botton2.Click
        VerporCentro()
    End Sub


    Private Sub TxDato31_Valida(ByVal edicion As Boolean) Handles TxDato31.Valida
        If edicion = True Then
            Conceptos(TxDato31.Text, ListaControles(TxDato31.Orden + 1))
        End If
    End Sub


    Private Sub TxDato35_Valida(ByVal edicion As Boolean) Handles TxDato35.Valida
        If edicion = True Then
            Conceptos(TxDato35.Text, ListaControles(TxDato35.Orden + 1))
        End If

    End Sub


    Private Sub TxDato36_Valida(ByVal edicion As Boolean) Handles TxDato36.Valida
        If edicion = True Then
            Conceptos(TxDato36.Text, ListaControles(TxDato36.Orden + 1))
        End If

    End Sub


    Private Sub TxDato37_Valida(ByVal edicion As Boolean) Handles TxDato37.Valida
        If edicion = True Then
            Conceptos(TxDato37.Text, ListaControles(TxDato37.Orden + 1))
        End If

    End Sub

    Private Sub TxDato38_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato38.TextChanged

    End Sub

    Private Sub TxDato38_Valida(ByVal edicion As Boolean) Handles TxDato38.Valida
        If edicion = True Then
            Conceptos(TxDato38.Text, ListaControles(TxDato38.Orden + 1))
        End If

    End Sub


    Private Sub TxDato39_Valida(ByVal edicion As Boolean) Handles TxDato39.Valida
        If edicion = True Then
            Conceptos(TxDato39.Text, ListaControles(TxDato39.Orden + 1))
        End If

    End Sub


    Private Sub TxDato40_Valida(ByVal edicion As Boolean) Handles TxDato40.Valida
        If edicion = True Then
            Conceptos(TxDato40.Text, ListaControles(TxDato40.Orden + 1))
        End If

    End Sub


    Private Sub TxDato6_Valida(ByVal edicion As Boolean) Handles TxDato6.Valida

        If TxDato6.Text = "" Then
            TxDato6.Text = FnFechaHoy()
        End If

        If edicion Then
            If TxDato11.Text = "" Then
                TxDato11.Text = TxDato6.Text
            End If
        End If


    End Sub


    Private Sub TxDato11_Valida(ByVal edicion As Boolean) Handles TxDato11.Valida

        If TxDato11.Text = "" Then
            TxDato11.Text = TxDato6.Text
        End If

        If edicion = True Then

            If TxDato50.Text = "" Then
                TxDato50.Text = MiMaletin.IdPuntoVenta.ToString
            End If

            If Not FnFechaEnEjercicio(TxDato11.Text, MiMaletin.Ejercicio.ToString) Then
                MsgBox("La fecha no está dentro del ejercicio")
                TxDato11.MiError = True
            End If

        End If

    End Sub


    Private Sub TxDato50_Valida(ByVal edicion As Boolean) Handles TxDato50.Valida
        If TxDato50.Text = "" Then
            TxDato50.Text = MiMaletin.IdPuntoVenta.ToString
        End If
    End Sub


    Private Sub TxFactura_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxFactura.KeyDown

        If e.KeyCode = Keys.F2 Then
            EnlazarFacturas()
        End If
    End Sub


    Private Sub TxFactura_Valida(edicion As Boolean) Handles TxFactura.Valida
        DatosFacturas()
    End Sub


    Public Overrides Sub Modificar()

        If VaDec(LbId.Text) > 0 Then

            Dim Asientos As New E_Asientos(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
            Dim IdAsiento As String = (Cobros.COB_idasiento.Valor & "").Trim

            If Asientos.AsientoPunteado(IdAsiento) Then
                MsgBox("Asiento punteado")
            Else
                MyBase.Modificar()
            End If


        End If



    End Sub


    Public Overrides Sub Anular()

        If VaDec(LbId.Text) > 0 Then

            Dim Asientos As New E_Asientos(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
            Dim IdAsiento As String = (Cobros.COB_idasiento.Valor & "").Trim

            If Asientos.AsientoPunteado(IdAsiento) Then
                MsgBox("Asiento punteado")
            Else
                MyBase.Anular()
            End If


        End If

    End Sub


    Private Sub TxConcepto1_AntesDeValidar(edicion As System.Boolean) Handles TxConcepto1.AntesDeValidar
        If edicion Then
            If TxCtaTesoreria.Text.Trim <> "" And TxConcepto1.Text.Trim = "" Then
                TxConcepto1.Text = "COBRO " & Lb19.Text
            End If
        End If
    End Sub


    Private Sub TxConcepto2_AntesDeValidar(edicion As System.Boolean) Handles TxConcepto2.AntesDeValidar
        If edicion Then
            If TxCtaGastosFinan.Text.Trim <> "" And TxConcepto2.Text.Trim = "" Then
                TxConcepto2.Text = "COBRO " & Lb19.Text
            End If
        End If
    End Sub


    Private Sub TxConcepto3_AntesDeValidar(edicion As System.Boolean) Handles TxConcepto3.AntesDeValidar
        If edicion Then
            If TxCtaDifCambio.Text.Trim <> "" And TxConcepto3.Text.Trim = "" Then
                TxConcepto3.Text = "COBRO " & Lb19.Text
            End If
        End If
    End Sub


    Private Sub TxEjercicioFactura_Enter(sender As Object, e As System.EventArgs) Handles TxEjercicioFactura.Enter

        If TxEjercicioFactura.Text.Trim = "" Then
            TxEjercicioFactura.Text = LbEjerCtb.Text
        End If

    End Sub


    Private Sub TxEjercicioFactura_Valida(edicion As System.Boolean) Handles TxEjercicioFactura.Valida

        If edicion Then

            Dim Ejercicios As New E_Ejercicios(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
            If Not Ejercicios.LeerId(TxEjercicioFactura.Text) Then
                MsgBox("Ejercicio inexistente")
                TxEjercicioFactura.MiError = True
            End If

        End If

    End Sub



End Class