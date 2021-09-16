Imports DevExpress.XtraEditors

Public Class FrmFacRecibidas2

    Inherits FrMantenimiento

    Dim FacturasRecibidas As New E_Facturasrecibidas(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Cuentas As New E_Cuentas(Idusuario, CnCtb)
    Dim CtaProveedor As New E_Cuentas(Idusuario, CnCtb)
    Dim Centros As New E_centros(Idusuario, CnCtb)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, CnCtb)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim TipoIvaSoportado As New E_TipoIvaSoportado(Idusuario, CnCtb)
    Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)

    Dim AlbEntrada_His As New E_AlbEntrada_his(Idusuario, cn)
    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim AlbEntrada_HisGastos As New E_albentrada_hisgastos(Idusuario, cn)
    Dim AlbMaterial As New E_AlbMaterial(Idusuario, cn)
    Dim TiposDeGastoAgri As New E_TiposdeGastoAgri(Idusuario, cn)

    Dim Asientos As New E_Asientos(Idusuario, CnCtb)
    Dim IdAsientoNet As Integer
    Dim Cartera As New E_Cuentas(Idusuario, CnCtb)
    Private Bancos As New E_Bancos(Idusuario, CnCtb)
    Private FormasPagoProveedor As New E_FormasPagoProveedor(Idusuario, CnCtb)



    Dim err As New Errores
    Private _dtPagos As DataTable = Nothing

    Dim MiCentro As String

    Dim _FacturasRecibidasImportaciones As E_FacturasRecibidasImportaciones = Nothing


    Public Structure stAlbaran
        Public IdAlbaran As String
        Public SN As Boolean
        Public tipo As String
        Public IdGasto As Integer
    End Structure



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Private Sub ParametrosFrm()


        EntidadFrm = FacturasRecibidas


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato_1, FacturasRecibidas.FRR_numero, Lb_1, True)
        TxDato_1.Autonumerico = True
        CampoClave = 0 ' ultimo campo de la clave

        ParamTx(TxDato_2, FacturasRecibidas.FRR_fechafactura, Lb_2, True)
        ParamTx(TxDato_3, FacturasRecibidas.FRR_fechactb, Lb_3, True)
        ParamTx(TxDato_4, FacturasRecibidas.FRR_idproveedor, Lb_4, False)
        ParamTx(TxDato_10, FacturasRecibidas.FRR_IdCuenta, Lb10, True)
        ParamTx(TxDato_5, FacturasRecibidas.FRR_numerofactura, Lb_5, True)
        ParamTx(TxDato_6, FacturasRecibidas.FRR_idregimen, Lb_6, True)

        ParamTx(TxBase1, FacturasRecibidas.FRR_base1)
        ParamTx(TxIva1, FacturasRecibidas.FRR_iva1)
        ParamTx(TxCuota1, FacturasRecibidas.FRR_cuota1)

        ParamTx(TxBase2, FacturasRecibidas.FRR_base2)
        ParamTx(TxIva2, FacturasRecibidas.FRR_iva2)
        ParamTx(TxCuota2, FacturasRecibidas.FRR_cuota2)

        ParamTx(TxBase3, FacturasRecibidas.FRR_base3)
        ParamTx(TxIva3, FacturasRecibidas.FRR_iva3)
        ParamTx(TxCuota3, FacturasRecibidas.FRR_cuota3)

        ParamTx(TxBase4, FacturasRecibidas.FRR_base4)
        ParamTx(TxIva4, FacturasRecibidas.FRR_iva4)
        ParamTx(TxCuota4, FacturasRecibidas.FRR_cuota4)

        ParamTx(TxBaseRet, FacturasRecibidas.FRR_baseret)
        ParamTx(TxRet, FacturasRecibidas.FRR_ret)
        ParamTx(TxCuotaRe, FacturasRecibidas.FRR_cuotaret)
        ParamTx(TxClaveIRPF, FacturasRecibidas.FRR_ClaveIRPF)

        ParamTx(TxImpGasto1, FacturasRecibidas.FRR_igasto1)
        ParamTx(TxCtaGasto1, FacturasRecibidas.FRR_ctagasto1)
        ParamTx(TxImpGasto2, FacturasRecibidas.FRR_igasto2)
        ParamTx(TxCtaGasto2, FacturasRecibidas.FRR_ctagasto2)
        ParamTx(TxImpGasto3, FacturasRecibidas.FRR_igasto3)
        ParamTx(TxCtaGasto3, FacturasRecibidas.FRR_ctagasto3)
        ParamTx(TxImpGasto4, FacturasRecibidas.FRR_igasto4)
        ParamTx(TxCtaGasto4, FacturasRecibidas.FRR_ctagasto4)

        ParamTx(TxDato_7, FacturasRecibidas.FRR_CtaCartera)
        ParamTx(TxDato_8, FacturasRecibidas.FRR_IdBanco)
        ParamTx(TxDato_9, FacturasRecibidas.FRR_IdFormaPago)

        ParamTx(TxDato_11, FacturasRecibidas.FRR_FechaVto, Lb11)
        ParamTx(TxDato_12, FacturasRecibidas.FRR_ImporteVto, Lb12)




        AsociarControles(TxDato_1, BtBusca_1, FacturasRecibidas.btBusca, EntidadFrm)
        AsociarControles(TxDato_4, BtBusca_4, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lbnom_4)
        AsociarControles(TxDato_10, BtBusca_10, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lbnom_10)
        AsociarControles(TxDato_6, BtBusca_6, TipoIvaSoportado.btBusca, TipoIvaSoportado, TipoIvaSoportado.Nombre, Lbnom_6)

        AsociarControles(TxCtaGasto1, BtBuscaG1, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lbnom_CtaGasto1)
        AsociarControles(TxCtaGasto2, BtBuscaG2, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lbnom_CtaGasto2)
        AsociarControles(TxCtaGasto3, BtBuscaG3, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lbnom_CtaGasto3)
        AsociarControles(TxCtaGasto4, BtBuscaG4, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lbnom_CtaGasto4)

        AsociarControles(TxDato_7, BtBusca_7, Cartera.btBusca, Cartera, Cartera.Nombre, Lb_7)
        AsociarControles(TxDato_8, BtBusca_8, Bancos.btBusca, Bancos, Bancos.Nombre, Lb_8)
        AsociarControles(TxDato_9, BtBusca_9, FormasPagoProveedor.btBusca, FormasPagoProveedor, FormasPagoProveedor.Nombre, Lb_9)



        FiltroEntidad.Add(FacturasRecibidas.FRR_idcentro.NombreCampo, MiMaletin.IdCentro.ToString)
        FiltroEntidad.Add(FacturasRecibidas.FRR_ejercicio.NombreCampo, MiMaletin.Ejercicio.ToString)


        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub


    Private Sub FrmFacRecibidas_AccionTerminada(ByRef TipoAccion As FrMantenimiento.TipoMantenimiento) Handles Me.AccionTerminada

        If TxImpGasto1.MiError Then
            TxImpGasto1.Select()
            TxImpGasto1.Focus()
        End If

    End Sub


    Private Sub FrmFacRecibidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        'Botón
        BTaux1.Text = "Gestión documental"
        BTaux1.Width = 125
        BTaux1.Image = NetAgro.My.Resources.Resources.App_ark_16x16_32
        BTaux1.Visible = True

        GridViewAlbaranes.OptionsView.ShowGroupPanel = False
        GridViewAlbaranes.OptionsBehavior.Editable = False
        GridViewAlbaranes.OptionsView.ColumnAutoWidth = True

    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave

        Dim i As Integer
        If TxDato_1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = FacturasRecibidas.Leerfac(VaInt(Lbejer.Text), MiMaletin.IdCentro, TxDato_1.Text)

            If i > 0 Then
                LbId.Text = i.ToString
            Else
                If MsgBox("Registro inexistente. Desea crear uno nuevo", vbYesNo) = vbYes Then
                    LbId.Text = "+"
                Else
                    LbId.Text = ""
                End If
            End If

        End If


    End Sub


    Private Function ValidarDesglose() As Boolean

        Return (VaDec(LbTBase.Text) = VaDec(LbTGasto.Text))

    End Function


    Public Overrides Sub Modificar()
        MyBase.Modificar()

        'No permite que cambie el tipo de factura
        If Not RbCompras.Checked Then RbCompras.Enabled = False
        If Not RbGastosCom.Checked Then RbGastosCom.Enabled = False
        If Not RbGastosVen.Checked Then RbGastosVen.Enabled = False
        If Not RbMateriales.Checked Then RbMateriales.Enabled = False
        If Not RbOtros.Checked Then RbOtros.Enabled = False


        GroupBox1.Enabled = True

        If RbGastosCom.Checked Then
            LbAlbaran.Visible = True
            txAlbaran.Visible = True
        End If

    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If CDate(FacturasRecibidas.FRR_fechactb.Valor) < MiMaletin.FechaCtbIva Then
            MsgBox("Fecha contabilidad bloqueada")
            Exit Sub
        End If

        MyBase.BAnular_Click(sender, e)

    End Sub

    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If CDate(FacturasRecibidas.FRR_fechactb.Valor) < MiMaletin.FechaCtbIva Then
            MsgBox("Fecha contabilidad bloqueada")
            Exit Sub
        End If

        MyBase.BModificar_Click(sender, e)

    End Sub

    Public Overrides Sub Entidad_a_Datos()


        'La fra no es modificable si tiene pagos generados
        Dim Modificable As Boolean = True
        'Dim Modificable As Boolean = CompruebaPagosGenerados(FacturasRecibidas.FRR_IdFacturaNet.Valor)
        'If Modificable Then
        '    Dim modif As String = (FacturasRecibidas.FRR_Modificable.Valor & "").Trim.ToUpper
        '    If modif = "N" Then
        '        MsgBox("Factura generada desde financiero, debe modificarla desde financiero")
        '        Modificable = False
        '    End If
        'End If

        If Not Modificable Then
            BGuardar.Enabled = False
            BModificar.Enabled = False
            BAnular.Enabled = False
        End If

        Select Case (FacturasRecibidas.FRR_tipofactura.Valor & "").Trim
            Case TipoFacturaRecibida.ComprasGenero
                RbCompras.Checked = True
            Case TipoFacturaRecibida.GastosCompras
                RbGastosCom.Checked = True
            Case TipoFacturaRecibida.GastosVentas
                RbGastosVen.Checked = True
            Case TipoFacturaRecibida.Materiales
                RbMateriales.Checked = True
            Case TipoFacturaRecibida.Otros
                RbOtros.Checked = True
        End Select


        MyBase.Entidad_a_Datos()


        VerificaProveedorAcreedor(False)
        GroupBox1.Enabled = False


        Dim IdCentro As String = FacturasRecibidas.FRR_idcentro.Valor & ""
        Dim IdPuntoVenta As String = FacturasRecibidas.FRR_IdPuntoVenta.Valor & ""

        PintaCentro(IdCentro, IdPuntoVenta)
        Lbejer.Text = FacturasRecibidas.FRR_ejercicio.Valor

        If VaInt(FacturasRecibidas.FRR_IdAsientoNet.Valor) > 0 Then
            LbAsiento.Text = Asientos.NumeroAsiento(FacturasRecibidas.FRR_IdAsientoNet.Valor)
        End If
        'LbFacturaNet.Text = FacturasRecibidas.FRR_IdFacturaNet.Valor

        IdAsientoNet = VaInt(FacturasRecibidas.FRR_IdAsientoNet.Valor)
        CargaAlbaranes()

        If VaInt(TxDato_8.Text) = 0 Then
            TxDato_8.Text = ""

        End If

        If VaInt(TxDato_9.Text) = 0 Then
            TxDato_9.Text = ""

        End If

        LbAlbaran.Visible = False
        txAlbaran.Visible = False

        CalculaTotalImportaciones()
        CalculaTotalesAlbaranes(False)




    End Sub

    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        BGuardar.Enabled = True
        BModificar.Enabled = True
        BAnular.Enabled = True

        RbCompras.Enabled = True
        RbGastosCom.Enabled = True
        RbGastosVen.Enabled = True
        RbMateriales.Enabled = True
        RbOtros.Enabled = True

        LbAsiento.Text = ""
        LbFacturaNet.Text = ""
        IdAsientoNet = 0

        LbTImportaciones.Text = ""


        If RbGastosCom.Checked Then
            LbAlbaran.Visible = True
            txAlbaran.Visible = True
        Else
            LbAlbaran.Visible = False
            txAlbaran.Visible = False
        End If



        GridAlbaranes.DataSource = Nothing

        PintaCentro(MiMaletin.IdCentro.ToString, MiMaletin.IdPuntoVenta.ToString)
        Lbejer.Text = MiMaletin.Ejercicio.ToString


        LbTBase.Text = ""
        LbTIVa.Text = ""
        LbTGasto.Text = ""
        LbToFactura.Text = ""
        Lbnom_10.Text = ""


        _FacturasRecibidasImportaciones = Nothing
        EntidadDePaso = Nothing


        GroupBox1.Enabled = True

        PanelPagosGenerados.Visible = False
        _dtPagos = Nothing


        VerificaBusca()
        VerificaProveedorAcreedor(False)


        BotonesAvance1.Filtro = "FRR_IdCentro = " & MiMaletin.IdCentro.ToString & " AND FRR_Ejercicio = " & MiMaletin.Ejercicio.ToString


    End Sub


    Private Sub PintaCentro(ByVal IdCentro As String, ByVal IdPuntoVenta As String)
        LbCentro.Text = IdCentro
        LbIdPuntoVenta.Text = IdPuntoVenta

        If Centros.LeerId(IdCentro) = True Then
            LbNomCentro.Text = Centros.Nombre.Valor
            MiCentro = Centros.IdCentro.Valor
        Else
            LbNomCentro.Text = ""
            MiCentro = ""
        End If

        If PuntoVenta.LeerId(IdPuntoVenta) Then
            LbNomPuntoVenta.Text = PuntoVenta.Nombre.Valor
        Else
            LbNomPuntoVenta.Text = ""
        End If

    End Sub





    Private Sub VerificaProveedorAcreedor(edicion As Boolean)

        GridAlbaranes.DataSource = Nothing

        'If LbId.Text.Trim <> "" Then

        If edicion Then
            TxDato_4.Text = ""
            Lbnom_4.Text = ""
            TxDato_4.Validar(edicion)
        End If


        If RbCompras.Checked Then
            Lb_4.Text = "Proveedor"
            AsociarControles(TxDato_4, BtBusca_4, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lbnom_4)
        Else
            Lb_4.Text = "Acreedor"
            AsociarControles(TxDato_4, BtBusca_4, Acreedores.btBusca, Acreedores, Acreedores.ACR_Nombre, Lbnom_4)
        End If

        'End If


        'Volvemos a cargar el grid de albaranes
        CargaAlbaranes()


    End Sub

    Private Sub TxDato_4_Valida(edicion As System.Boolean) Handles TxDato_4.Valida

        If edicion And Not RbOtros.Checked Then
            TxDato_10.Text = ""
        End If


        Lbnom_10.Text = ""


        If RbCompras.Checked Then
            AsociarControles(TxDato_4, BtBusca_4, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lbnom_4)

            'Cta y Nombre
            Dim Agricultor As New E_Agricultores(Idusuario, cn)
            If Agricultor.LeerId(TxDato_4.Text) Then

                If TipoAgricultor.LeerId(Agricultor.AGR_IdTipo.Valor) Then

                    If edicion Then

                        If TxDato_6.Text = "" Then
                            Dim TiposIva As New E_tiposiva(Idusuario, cn)
                            TxDato_6.Text = TipoAgricultor.TPA_idtipoiva.Valor
                            TxDato_6.Validar(True)
                        End If

                        TxDato_10.Text = (TipoAgricultor.TPA_ctaprov.Valor & "").ToString & VaInt(TxDato_4.Text).ToString("00000")

                        TxDato_10.Validar(edicion)
                    End If


                    If CtaProveedor.LeerId(TxDato_10.Text) Then

                        'Lbnom_10.Text = CtaProveedor.Nombre.Valor


                        'Datos de pago por defecto
                        If edicion Then
                            If TxCtaGasto1.Text.Trim = "" Or NuevoRegistro Then TxCtaGasto1.Text = TipoAgricultor.TPA_ctacompracomer.Valor
                            If TxDato_7.Text.Trim = "" Or NuevoRegistro Then TxDato_7.Text = CtaProveedor.CtaEfecto.Valor
                            If TxDato_8.Text.Trim = "" Or NuevoRegistro Then TxDato_8.Text = CtaProveedor.IdBanco.Valor
                            If TxDato_9.Text.Trim = "" Or NuevoRegistro Then TxDato_9.Text = CtaProveedor.IdFPago.Valor

                            TxDato_7.Validar(True)
                            TxDato_8.Validar(True)
                            TxDato_9.Validar(True)

                        End If

                    End If

                End If

            End If

        Else

            AsociarControles(TxDato_4, BtBusca_4, Acreedores.btBusca, Acreedores, Acreedores.ACR_Nombre, Lbnom_4)

            'Cta y Nombre
            Dim Acreedor As New E_Acreedores(Idusuario, cn)
            If Acreedor.LeerId(TxDato_4.Text) Then

                If edicion Then


                    'If TxDato_6.Text = "" Then
                    '    Dim TiposIva As New E_tiposiva(Idusuario, cn)
                    '    If TiposIva.LeerId(TipoAgricultor.TPA_idtipoiva.Valor) Then
                    '        TxDato_6.Text = VaDec(TiposIva.TIV_iva.Valor).ToString("#,##0.00")
                    '    End If
                    'End If


                    TxDato_10.Text = Acreedor.ACR_IdCuenta.Valor
                    If CtaProveedor.LeerId(Acreedor.ACR_IdCuenta.Valor) Then
                        Lbnom_10.Text = CtaProveedor.Nombre.Valor

                        'Datos de pago por defecto

                        If TxDato_7.Text.Trim = "" Or NuevoRegistro Then TxDato_7.Text = CtaProveedor.CtaEfecto.Valor
                        If TxDato_8.Text.Trim = "" Or NuevoRegistro Then TxDato_8.Text = CtaProveedor.IdBanco.Valor
                        If TxDato_9.Text.Trim = "" Or NuevoRegistro Then TxDato_9.Text = CtaProveedor.IdFPago.Valor

                        TxDato_7.Validar(True)
                        TxDato_8.Validar(True)
                        TxDato_9.Validar(True)


                    End If

                End If

            End If

        End If


        If edicion Then

            CargaAlbaranes()
            CompruebaBloqueo()

        End If


    End Sub


    Private Sub TxDato_6_Valida(edicion As System.Boolean) Handles TxDato_6.Valida

        If edicion Then
            If Not TxDato_6.MiError Then

                If TipoIvaSoportado.LeerId(TxDato_6.Text) Then
                    TxIva1.Text = VaDec(TipoIvaSoportado.Iva1.Valor).ToString("#,##0.00")
                    TxIva2.Text = VaDec(TipoIvaSoportado.Iva2.Valor).ToString("#,##0.00")
                    TxIva3.Text = VaDec(TipoIvaSoportado.Iva3.Valor).ToString("#,##0.00")
                    TxIva4.Text = VaDec(TipoIvaSoportado.Iva4.Valor).ToString("#,##0.00")
                End If

            End If
        End If

    End Sub


    Private Sub TxBase1_Valida(edicion As System.Boolean) Handles TxBase1.Valida
        CalculaCuotas(edicion)
    End Sub

    Private Sub TxBase2_Valida(edicion As System.Boolean) Handles TxBase2.Valida
        CalculaCuotas(edicion)
    End Sub

    Private Sub TxBase3_Valida(edicion As System.Boolean) Handles TxBase3.Valida
        CalculaCuotas(edicion)
    End Sub

    Private Sub TxBase4_Valida(edicion As System.Boolean) Handles TxBase4.Valida
        CalculaCuotas(edicion)
        If edicion = True Then
            If NuevoRegistro Then
                TxImpGasto1.Text = VaDec(LbTBase.Text).ToString
            End If
        End If
    End Sub

    Private Sub TxIva1_Valida(edicion As System.Boolean) Handles TxIva1.Valida
        CalculaCuotas(edicion)
    End Sub

    Private Sub TxIva2_Valida(edicion As System.Boolean) Handles TxIva2.Valida
        CalculaCuotas(edicion)
    End Sub

    Private Sub TxIva3_Valida(edicion As System.Boolean) Handles TxIva3.Valida
        CalculaCuotas(edicion)
    End Sub

    Private Sub TxIva4_Valida(edicion As System.Boolean) Handles TxIva4.Valida
        CalculaCuotas(edicion)
    End Sub

    Private Sub TxBaseRet_Valida(edicion As System.Boolean) Handles TxBaseRet.Valida
        CalculaCuotas(edicion)
    End Sub

    Private Sub TxRet_Valida(edicion As System.Boolean) Handles TxRet.Valida
        CalculaCuotas(edicion)
    End Sub


    Private Sub TxImpGasto1_Valida(edicion As System.Boolean) Handles TxImpGasto1.Valida
        CalculaGastos()
    End Sub

    Private Sub TxImpGasto2_Valida(edicion As System.Boolean) Handles TxImpGasto2.Valida
        CalculaGastos()
    End Sub

    Private Sub TxImpGasto3_Valida(edicion As System.Boolean) Handles TxImpGasto3.Valida
        CalculaGastos()
    End Sub

    Private Sub TxImpGasto4_Valida(edicion As System.Boolean) Handles TxImpGasto4.Valida
        CalculaGastos()
    End Sub


    Private Sub CalculaCuotas(edicion As Boolean)

        If edicion Then
            TxCuota1.Text = (VaDec(TxBase1.Text) * VaDec(TxIva1.Text) / 100).ToString("#,##0.00")
            TxCuota2.Text = (VaDec(TxBase2.Text) * VaDec(TxIva2.Text) / 100).ToString("#,##0.00")
            TxCuota3.Text = (VaDec(TxBase3.Text) * VaDec(TxIva3.Text) / 100).ToString("#,##0.00")
            TxCuota4.Text = (VaDec(TxBase4.Text) * VaDec(TxIva4.Text) / 100).ToString("#,##0.00")
            TxCuotaRe.Text = (VaDec(TxBaseRet.Text) * VaDec(TxRet.Text) / 100).ToString("#,##0.00")
        End If


        Dim totalbases As Decimal = VaDec(TxBase1.Text) + VaDec(TxBase2.Text) + VaDec(TxBase3.Text) + VaDec(TxBase4.Text)
        LbTBase.Text = totalbases.ToString("#,##0.00")
        Dim totalCuotaIva As Decimal = VaDec(TxCuota1.Text) + VaDec(TxCuota2.Text) + VaDec(TxCuota3.Text) + VaDec(TxCuota4.Text)
        LbTIVa.Text = totalCuotaIva.ToString("#,##0.00")


        CalculaTotal(edicion)

    End Sub


    Private Sub CalculaGastos()

        Dim totalgastos As Decimal = VaDec(TxImpGasto1.Text) + VaDec(TxImpGasto2.Text) + VaDec(TxImpGasto3.Text) + VaDec(TxImpGasto4.Text)
        LbTGasto.Text = totalgastos.ToString("#,##0.00")

        'CalculaTotal()

    End Sub


    Private Sub CalculaTotal(edicion As Boolean)

        Dim total As Decimal = VaDec(LbTBase.Text) + VaDec(LbTIVa.Text) + VaDec(LbTImportaciones.Text) - VaDec(TxCuotaRe.Text)
        LbToFactura.Text = total.ToString("#,##0.00")

        If edicion Then
            TxDato_12.Text = LbToFactura.Text
        End If

    End Sub


    Private Sub TxBase1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxBase1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If VaDec(TxBase1.Text) = 0 Then
                TxCuota1.Text = TxBase1.Text
                TxCuota1.Validar(True)
                Siguiente(TxCuota1.Orden)
            End If
        End If
    End Sub

    Private Sub TxBase2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxBase2.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If VaDec(TxBase2.Text) = 0 Then
                TxCuota2.Text = TxBase2.Text
                TxCuota2.Validar(True)
                Siguiente(TxCuota2.Orden)
            End If
        End If
    End Sub

    Private Sub TxBase3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxBase3.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If VaDec(TxBase3.Text) = 0 Then
                TxCuota3.Text = TxBase3.Text
                TxCuota3.Validar(True)
                Siguiente(TxCuota3.Orden)
            End If
        End If
    End Sub

    Private Sub TxBase4_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxBase4.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If VaDec(TxBase4.Text) = 0 Then
                TxCuota4.Text = TxBase4.Text
                TxCuota4.Validar(True)
                Siguiente(TxCuota4.Orden)
            End If
        End If
    End Sub

    Private Sub TxBaseRet_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxBaseRet.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If VaDec(TxBaseRet.Text) = 0 Then
                TxRet.Text = TxBaseRet.Text
                TxCuotaRe.Text = TxBaseRet.Text
                TxRet.Validar(True)
                TxCuotaRe.Validar(True)
                Siguiente(TxCuotaRe.Orden)
            End If
        End If
    End Sub

    Private Sub TxImpGasto1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImpGasto1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If VaDec(TxImpGasto1.Text) = 0 Then
                TxDato_7.Select()
                TxDato_7.Focus()
            End If
        ElseIf e.KeyCode = Keys.Left Then
            If TxImpGasto1.SelectionLength = 0 Then
                BtImportaciones.Select()
                BtImportaciones.Focus()
            End If
        End If
    End Sub

    Private Sub TxImpGasto2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImpGasto2.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If VaDec(TxImpGasto2.Text) = 0 Then
                TxDato_7.Select()
                TxDato_7.Focus()
            End If
        End If
    End Sub

    Private Sub TxImpGasto3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImpGasto3.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If VaDec(TxImpGasto3.Text) = 0 Then
                TxDato_7.Select()
                TxDato_7.Focus()
            End If
        End If
    End Sub

    Private Sub TxImpGasto4_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImpGasto4.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            If VaDec(TxImpGasto4.Text) = 0 Then
                TxDato_7.Select()
                TxDato_7.Focus()
            End If
        End If
    End Sub

    Private Sub RbCompras_Click(sender As System.Object, e As System.EventArgs) Handles RbCompras.Click
        VerificaProveedorAcreedor(True)
        VerificaBusca()
    End Sub

    Private Sub RbGastosCom_Click(sender As System.Object, e As System.EventArgs) Handles RbGastosCom.Click
        VerificaProveedorAcreedor(True)
        VerificaBusca()
    End Sub

    Private Sub RbGastosVen_Click(sender As System.Object, e As System.EventArgs) Handles RbGastosVen.Click
        VerificaProveedorAcreedor(True)
        VerificaBusca()
    End Sub

    Private Sub RbMateriales_Click(sender As System.Object, e As System.EventArgs) Handles RbMateriales.Click
        VerificaProveedorAcreedor(True)
        VerificaBusca()
    End Sub

    Private Sub RbOtros_Click(sender As System.Object, e As System.EventArgs) Handles RbOtros.Click
        VerificaProveedorAcreedor(True)
        VerificaBusca()
    End Sub


    Private Sub VerificaBusca()

        If RbGastosCom.Checked Then
            LbAlbaran.Visible = True
            TxAlbaran.Visible = True
        Else
            LbAlbaran.Visible = False
            TxAlbaran.Visible = False
        End If


        If RbCompras.Checked Then
            BtBusca_1.CL_campocodigo = Agricultores.AGR_IdAgricultor
            BtBusca_1.CL_camponombre = Agricultores.AGR_Nombre
        Else
            BtBusca_1.CL_campocodigo = Acreedores.ACR_Codigo
            BtBusca_1.CL_camponombre = Acreedores.ACR_Nombre
        End If

    End Sub

    Private Sub CargaAlbaranes()

        If VaInt(TxDato_4.Text) > 0 Then

            GridViewAlbaranes.Columns.Clear()

            If RbCompras.Checked Then
                CargaAlbaranesCompraGenero()
            ElseIf RbGastosCom.Checked Then
                CargaAlbaranesGastosCompras()
            ElseIf RbGastosVen.Checked Then
                CargaAlbaranesGastosVentas()
            ElseIf RbMateriales.Checked Then
                CargaMateriales()
            End If

        Else
            GridAlbaranes.DataSource = Nothing
        End If

    End Sub


    Private Sub CargaAlbaranesCompraGenero()

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbEntrada_His.AEH_idalbaran, "IdAlbaran")
        consulta.SelCampo(AlbEntrada.AEN_Albaran, "Albaran", AlbEntrada_His.AEH_idalbaran, AlbEntrada.AEN_IdAlbaran)
        consulta.SelCampo(AlbEntrada.AEN_referencia, "Ref")
        consulta.SelCampo(AlbEntrada_His.AEH_baseimponible, "BaseImp")

        consulta.SelCampo(AlbEntrada.AEN_Fecha, "Fecha")
        consulta.SelCampo(AlbEntrada.AEN_IdCentro, "CE")
        'consulta.SelCampo(Centros.Nombre, "Centro", AlbEntrada.AEN_IdCentro, Centros.IdCentro)
        consulta.SelCampo(AlbEntrada_His.AEH_idfactura, "IdFactura")
        consulta.WheCampo(AlbEntrada_His.AEH_idproveedor, "=", TxDato_4.Text)
        consulta.WheCampo(AlbEntrada.AEN_IdCentro, "=", MiMaletin.IdCentro.ToString)

        Dim sqlConsulta As String = consulta.SQL
        sqlConsulta = sqlConsulta & " AND (COALESCE(AEH_IdFactura,0) = 0 OR COALESCE(AEH_IdFactura,0) = " & VaInt(LbId.Text).ToString & ")" & vbCrLf


        Dim sql As String = "select IdAlbaran, Albaran, Ref," & vbCrLf
        sql = sql & " SUM(BaseImp) as BaseImp," & vbCrLf
        sql = sql & " Fecha, CE, IdFactura" & vbCrLf
        sql = sql & " FROM " & vbCrLf
        sql = sql & " (" & vbCrLf & sqlConsulta & vbCrLf & ") as G" & vbCrLf
        sql = sql & " GROUP BY IdAlbaran, Albaran, Ref, Fecha, CE, IdFactura" & vbCrLf
        sql = sql & " ORDER BY Fecha"

        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)

        Dim colB As New DataColumn("S_Original", GetType(Boolean))
        colB.DefaultValue = False
        dt.Columns.Add(colB)

        Dim col As New DataColumn("S", GetType(Boolean))
        col.DefaultValue = False
        dt.Columns.Add(col)


        For Each row As DataRow In dt.Rows
            Dim IdFactura As String = (row("IdFactura").ToString & "").Trim
            If IdFactura = LbId.Text.Trim Then
                row("S_Original") = True
                row("S") = True
            End If
        Next


        GridAlbaranes.DataSource = dt

        AjustaColumnas()

    End Sub


    Private Sub CargaAlbaranesGastosCompras()

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbEntrada_HisGastos.AHG_id, "Id")
        consulta.SelCampo(AlbEntrada.AEN_IdAlbaran, "IdAlbaran", AlbEntrada_HisGastos.AHG_idalbaran, AlbEntrada.AEN_IdAlbaran)
        consulta.SelCampo(AlbEntrada.AEN_Albaran, "Albaran")
        consulta.SelCampo(AlbEntrada.AEN_referencia, "Ref")
        consulta.SelCampo(AlbEntrada_HisGastos.AHG_idgasto, "IdGasto")
        consulta.SelCampo(TiposDeGastoAgri.TGA_Nombre, "Gasto", AlbEntrada_HisGastos.AHG_idgasto, TiposDeGastoAgri.TGA_Idtipogasto)
        consulta.SelCampo(AlbEntrada_HisGastos.AHG_importe, "Importe")
        consulta.SelCampo(AlbEntrada.AEN_Fecha, "Fecha")
        consulta.SelCampo(AlbEntrada.AEN_IdCentro, "CE")
        'consulta.SelCampo(Centros.Nombre, "Centro", AlbEntrada.AEN_IdCentro, Centros.IdCentro)
        consulta.SelCampo(AlbEntrada_HisGastos.AHG_idfacturaproveedor, "IdFactura")
        consulta.WheCampo(AlbEntrada_HisGastos.AHG_idacreedor, "=", TxDato_4.Text)


        Dim sqlConsulta As String = consulta.SQL
        sqlConsulta = sqlConsulta & " AND (COALESCE(AHG_idfacturaproveedor,0) = 0 OR COALESCE(AHG_idfacturaproveedor,0) = " & VaInt(LbId.Text).ToString & ")" & vbCrLf


        Dim sql As String = "SELECT IdAlbaran, Albaran, Ref, Fecha, CE, IdGasto, Gasto, SUM(Importe) as Importe, IdFactura " & vbCrLf
        sql = sql & " FROM " & vbCrLf
        sql = sql & " (" & vbCrLf & sqlConsulta & vbCrLf & ") as G" & vbCrLf
        sql = sql & " GROUP BY IdAlbaran, Albaran, Ref, Fecha, CE, IdFactura, IdGasto, Gasto" & vbCrLf
        sql = sql & " ORDER BY Fecha"

        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)


        Dim colB As New DataColumn("S_Original", GetType(Boolean))
        colB.DefaultValue = False
        dt.Columns.Add(colB)

        Dim col As New DataColumn("S", GetType(Boolean))
        col.DefaultValue = False
        dt.Columns.Add(col)


        For Each row As DataRow In dt.Rows
            Dim IdFactura As String = (row("IdFactura").ToString & "").Trim
            If IdFactura = LbId.Text.Trim Then
                row("S_Original") = True
                row("S") = True
            End If
        Next


        GridAlbaranes.DataSource = dt

        AjustaColumnas()

    End Sub


    Private Sub CargaAlbaranesGastosVentas()

        Dim sqlConsulta As String = "SELECT 'S' as Tipo, ASG_IdAlbaran AS IdAlbaran, 'SAL ' +  CAST(ASA_Albaran AS Varchar) as Albaran, ASA_Referencia as Ref," & vbCrLf
        sqlConsulta = sqlConsulta & " ASA_FechaSalida as Fecha, ASA_IdCentro as CE, ASG_Importegastoeuros as Importe, ASG_IdFactura as IdFactura" & vbCrLf
        sqlConsulta = sqlConsulta & " FROM AlbSalida_Gastos" & vbCrLf
        sqlConsulta = sqlConsulta & " LEFT JOIN AlbSalida on ASA_IdAlbaran = ASG_IdAlbaran" & vbCrLf
        sqlConsulta = sqlConsulta & " LEFT JOIN " & NombreBdCtb & ".dbo.Centros as Centros ON Centros.IdCentro = ASA_IdCentro" & vbCrLf
        sqlConsulta = sqlConsulta & " WHERE ASG_IdAcreedor = " & TxDato_4.Text & vbCrLf
        sqlConsulta = sqlConsulta & " AND (COALESCE(ASG_IdFactura,0) = 0 OR COALESCE(ASG_IdFactura,0) = " & VaInt(LbId.Text).ToString & ")" & vbCrLf
        sqlConsulta = sqlConsulta & " UNION ALL" & vbCrLf
        sqlConsulta = sqlConsulta & " SELECT 'A' as Tipo, AAG_IdAlbaran AS IdAlbaran, 'ALH ' + CAST(AAH_Albaran AS Varchar) as Albaran, '' as Ref," & vbCrLf
        sqlConsulta = sqlConsulta & " AAH_FechaSalida as Fecha, AAH_IdCentro as CE, AAG_ImporteGasto as Importe, AAG_IdFactura as IdFactura" & vbCrLf
        sqlConsulta = sqlConsulta & " FROM AlbSalidaALH_Gastos" & vbCrLf
        sqlConsulta = sqlConsulta & " LEFT JOIN AlbSalidaALH ON AAH_IdAlbaran = AAG_IdAlbaran " & vbCrLf
        sqlConsulta = sqlConsulta & " LEFT JOIN " & NombreBdCtb & ".dbo.Centros as Centros ON Centros.IdCentro = AAH_IdCentro" & vbCrLf
        sqlConsulta = sqlConsulta & " WHERE AAG_IdAcreedor = " & TxDato_4.Text & vbCrLf
        sqlConsulta = sqlConsulta & " AND (COALESCE(AAG_IdFactura,0) = 0 OR COALESCE(AAG_IdFactura,0) = " & VaInt(LbId.Text).ToString & ")" & vbCrLf


        Dim sql As String = "SELECT Tipo, IdAlbaran, Albaran, Ref, Fecha, CE, SUM(Importe) as Importe, IdFactura " & vbCrLf
        sql = sql & " FROM " & vbCrLf
        sql = sql & " (" & vbCrLf & sqlConsulta & vbCrLf & ") as G" & vbCrLf
        sql = sql & " GROUP BY Tipo, IdAlbaran, Albaran, Ref, Fecha, CE, IdFactura" & vbCrLf
        sql = sql & " ORDER BY Fecha"


        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)


        Dim colB As New DataColumn("S_Original", GetType(Boolean))
        colB.DefaultValue = False
        dt.Columns.Add(colB)

        Dim col As New DataColumn("S", GetType(Boolean))
        col.DefaultValue = False
        dt.Columns.Add(col)


        For Each row As DataRow In dt.Rows
            Dim IdFactura As String = (row("IdFactura").ToString & "").Trim
            If IdFactura = LbId.Text.Trim Then
                row("S_Original") = True
                row("S") = True
            End If
        Next


        GridAlbaranes.DataSource = dt

        AjustaColumnas()


    End Sub


    Private Sub CargaMateriales()

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbMaterial.AMA_Idalb, "IdAlbaran")
        consulta.SelCampo(AlbMaterial.AMA_Numero, "Albaran")
        consulta.SelCampo(AlbMaterial.AMA_referencia, "Ref")
        consulta.SelCampo(AlbMaterial.AMA_Fecha, "Fecha")
        consulta.SelCampo(AlbMaterial.AMA_Idcentro, "CE")
        'consulta.SelCampo(Centros.Nombre, "Centro", AlbMaterial.AMA_Idcentro, Centros.IdCentro)
        consulta.SelCampo(AlbMaterial.AMA_importe, "Importe")
        consulta.SelCampo(AlbMaterial.AMA_idfactura, "IdFactura")
        consulta.WheCampo(AlbMaterial.AMA_Idacreedor, "=", TxDato_4.Text)

        Dim sqlConsulta As String = consulta.SQL
        sqlConsulta = sqlConsulta & " AND (COALESCE(AMA_idfactura,0) = 0 OR COALESCE(AMA_idfactura,0) = " & VaInt(LbId.Text).ToString & ")" & vbCrLf


        Dim sql As String = "select IdAlbaran, Albaran, Ref, " & vbCrLf
        sql = sql & " Fecha, CE," & vbCrLf
        sql = sql & " SUM(Importe) as Importe, IdFactura" & vbCrLf
        sql = sql & " FROM " & vbCrLf
        sql = sql & " (" & vbCrLf & sqlConsulta & vbCrLf & ") as G" & vbCrLf
        sql = sql & " GROUP BY IdAlbaran, Albaran, Ref, Fecha, CE, IdFactura" & vbCrLf
        sql = sql & " ORDER BY Fecha"

        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)


        Dim colB As New DataColumn("S_Original", GetType(Boolean))
        colB.DefaultValue = False
        dt.Columns.Add(colB)

        Dim col As New DataColumn("S", GetType(Boolean))
        col.DefaultValue = False
        dt.Columns.Add(col)


        For Each row As DataRow In dt.Rows
            Dim IdFactura As String = (row("IdFactura").ToString & "").Trim
            If IdFactura = LbId.Text.Trim Then
                row("S_Original") = True
                row("S") = True
            End If
        Next


        GridAlbaranes.DataSource = dt

        AjustaColumnas()


    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewAlbaranes.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDALBARAN", "IDFACTURA", "TIPO", "ID", "S_ORIGINAL", "IDGASTO"
                    c.Visible = False
            End Select
        Next

        GridViewAlbaranes.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewAlbaranes.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "IMPORTE", "BASEIMP", "S_ORIGINAL"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

                Case "S"
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.MaxWidth = 20
            End Select
        Next


    End Sub


    Private Sub GridViewAlbaranes_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridViewAlbaranes.RowCellClick

        Dim row As DataRow = GridViewAlbaranes.GetDataRow(e.RowHandle)
        If Not IsNothing(row) Then

            If e.Column.FieldName.ToUpper.Trim = "S" Then

                If NuevoRegistro Or Modificando Then

                    If RbGastosCom.Checked Then

                        Dim IdAlbaran As String = VaInt(row("IdAlbaran"))
                        Dim IdGasto As Integer = VaInt(row("IdGasto"))
                        Dim bValor As Boolean = Not row("S")

                        MarcaAlbaran(IdAlbaran, IdGasto, bValor)

                    Else
                        If row("S") = True Then
                            row("S") = False
                        Else
                            row("S") = True
                        End If

                        CalculaTotalesAlbaranes()

                    End If

                    TxBase1.Select()
                    TxBase1.Focus()


                End If


            End If

        End If


    End Sub

    Private Sub BtSelNinguno_Click(sender As System.Object, e As System.EventArgs) Handles BtSelNinguno.Click

        If NuevoRegistro Or Modificando Then

            For indice As Integer = 0 To GridViewAlbaranes.RowCount - 1
                Dim row As DataRow = GridViewAlbaranes.GetDataRow(indice)
                If Not IsNothing(row) Then
                    row("S") = False
                End If
            Next

            CalculaTotalesAlbaranes()

        End If

    End Sub

    Private Sub BtSelTodos_Click(sender As System.Object, e As System.EventArgs) Handles BtSelTodos.Click

        If NuevoRegistro Or Modificando Then

            For indice As Integer = 0 To GridViewAlbaranes.RowCount - 1
                Dim row As DataRow = GridViewAlbaranes.GetDataRow(indice)
                If Not IsNothing(row) Then
                    row("S") = True
                End If
            Next

            CalculaTotalesAlbaranes()

        End If

    End Sub


    Private Sub CalculaTotalesAlbaranes(Optional edicion As Boolean = True)

        Dim total As Decimal = 0

        For indice As Integer = 0 To GridViewAlbaranes.RowCount - 1
            Dim row As DataRow = GridViewAlbaranes.GetDataRow(indice)
            If Not IsNothing(row) Then

                If row("S") = True Then

                    If RbCompras.Checked Then
                        total = total + VaDec(row("BaseImp"))
                    ElseIf RbGastosCom.Checked Then
                        total = total + VaDec(row("Importe"))
                    ElseIf RbGastosVen.Checked Then
                        total = total + VaDec(row("Importe"))
                    ElseIf RbMateriales.Checked Then
                        total = total + VaDec(row("Importe"))
                    ElseIf RbOtros.Checked Then
                        total = total + VaDec(row("Importe"))
                    End If

                End If


            End If
        Next


        If RbCompras.Checked Then
            LbTAlbaranes.Text = "Total Base Imp: " & total.ToString("#,##0.00")
        Else
            LbTAlbaranes.Text = "Total: " & total.ToString("#,##0.00")
        End If


        'De momento, todos los importes del grid de albaranes van a la base1
        If edicion Then

            If RbCompras.Checked Then
                TxBase1.Text = total.ToString("#,##0.00")
            ElseIf RbGastosCom.Checked Then
                TxBase1.Text = total.ToString("#,##0.00")
            ElseIf RbGastosVen.Checked Then
                TxBase1.Text = total.ToString("#,##0.00")
            ElseIf RbMateriales.Checked Then
                TxBase1.Text = total.ToString("#,##0.00")
            End If

        End If



        'Calcula total de las bases, las cuotas de iva y el total de iva
        CalculaCuotas(edicion)


    End Sub


    Private Sub ActualizaAlbaranesGastos()

        Try

            Dim lst As New List(Of stAlbaran)

            'Actualizamos sólo los que hayan cambiado
            For indice As Integer = 0 To GridViewAlbaranes.RowCount - 1
                Dim row As DataRow = GridViewAlbaranes.GetDataRow(indice)
                If Not IsNothing(row) Then
                    If row("S") <> row("S_Original") Then
                        Dim st As New stAlbaran
                        st.IdAlbaran = (row("IdAlbaran").ToString & "").Trim
                        st.SN = row("S")
                        If RbGastosCom.Checked Then
                            st.IdGasto = VaInt(row("IdGasto"))
                        End If
                        If RbGastosVen.Checked Then
                            st.tipo = row("Tipo").ToString & ""
                        End If
                        lst.Add(st)
                    End If
                End If
            Next


            If RbCompras.Checked Then
                ActualizaAlbEntrada_His(lst)
            ElseIf RbGastosCom.Checked Then
                ActualizaAlbEntrada_HisGastos(lst)
            ElseIf RbMateriales.Checked Then
                ActualizaAlbMateriales(lst)
            End If

        Catch ex As Exception
            err.Muestraerror("Error al actualizar los albaranes del grid", "ActualizaAlbaranesGastos", ex.Message)
        End Try

    End Sub


    Private Sub ActualizaAlbEntrada_His(lst As List(Of stAlbaran))

        Dim AEH As New E_AlbEntrada_his(Idusuario, cn)

        For Each stAlbaran As stAlbaran In lst

            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(AEH.AEH_id, "Id")
            consulta.WheCampo(AEH.AEH_idalbaran, "=", stAlbaran.IdAlbaran)
            consulta.WheCampo(AEH.AEH_idproveedor, "=", TxDato_4.Text)

            Dim dt As DataTable = AEH.MiConexion.ConsultaSQL(consulta.SQL)
            For Each row As DataRow In dt.Rows

                Dim Id As String = row("Id").ToString & ""
                If AEH.LeerId(Id) Then
                    If stAlbaran.SN Then
                        AEH.AEH_idfactura.Valor = LbId.Text
                    Else
                        AEH.AEH_idfactura.Valor = 0
                    End If
                    AEH.Actualizar()
                End If

            Next


            Application.DoEvents()

        Next

    End Sub

    Private Sub ActualizaAlbEntrada_HisGastos(lst As List(Of stAlbaran))

        Dim AHG As New E_albentrada_hisgastos(Idusuario, cn)

        For Each stAlbaran As stAlbaran In lst

            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(AHG.AHG_id, "Id")
            consulta.WheCampo(AHG.AHG_idalbaran, "=", stAlbaran.IdAlbaran)
            consulta.WheCampo(AHG.AHG_idacreedor, "=", TxDato_4.Text)
            consulta.WheCampo(AHG.AHG_idgasto, "=", stAlbaran.IdGasto)

            Dim dt As DataTable = AHG.MiConexion.ConsultaSQL(consulta.SQL)
            For Each row As DataRow In dt.Rows

                Dim Id As String = row("Id").ToString & ""
                If AHG.LeerId(Id) Then
                    If stAlbaran.SN Then
                        AHG.AHG_idfacturaproveedor.Valor = LbId.Text
                    Else
                        AHG.AHG_idfacturaproveedor.Valor = 0
                    End If
                    AHG.Actualizar()
                End If

            Next


            Application.DoEvents()

        Next

    End Sub



    Private Sub ActualizaAlbMateriales(lst As List(Of stAlbaran))

        Dim AMA As New E_AlbMaterial(Idusuario, cn)

        For Each stAlbaran As stAlbaran In lst

            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(AMA.AMA_Idalb, "Id")
            consulta.WheCampo(AMA.AMA_Idalb, "=", stAlbaran.IdAlbaran)
            consulta.WheCampo(AMA.AMA_Idacreedor, "=", TxDato_4.Text)

            Dim dt As DataTable = AMA.MiConexion.ConsultaSQL(consulta.SQL)
            For Each row As DataRow In dt.Rows

                Dim Id As String = row("Id").ToString & ""
                If AMA.LeerId(Id) Then
                    If stAlbaran.SN Then
                        AMA.AMA_idfactura.Valor = LbId.Text
                    Else
                        AMA.AMA_idfactura.Valor = 0
                    End If
                    AMA.Actualizar()
                End If

            Next


            Application.DoEvents()

        Next

    End Sub


    Private Sub BtImportaciones_Click(sender As System.Object, e As System.EventArgs) Handles BtImportaciones.Click

        'Si IdFactura es 0, la guardamos al guardar la FacturaRecibida (la almacenamos en _FacturasRecibidasImportaciones)
        If VaInt(LbId.Text) = 0 Then
            If IsNothing(_FacturasRecibidasImportaciones) Then
                Dim f As New frmFacturasRecibidasImportaciones(LbId.Text)
                f.init(LbId.Text)
                f.ShowDialog()
            Else
                Dim f As New frmFacturasRecibidasImportaciones(_FacturasRecibidasImportaciones)
                f.init(_FacturasRecibidasImportaciones.FRI_idfactura.Valor)
                f.ShowDialog()
            End If

            _FacturasRecibidasImportaciones = EntidadDePaso
            If Not IsNothing(_FacturasRecibidasImportaciones) Then
                If (_FacturasRecibidasImportaciones.FRI_idfactura.Valor & "").Trim = "" Then _FacturasRecibidasImportaciones.FRI_idfactura.Valor = "+"
            End If

            Dim totalImportaciones As Decimal = VaDec(_FacturasRecibidasImportaciones.FRI_BaseSuplido.Valor) + VaDec(_FacturasRecibidasImportaciones.FRI_CuotaIva.Valor)
            LbTImportaciones.Text = totalImportaciones.ToString("#,##0.00")

        Else

            Dim f As New frmFacturasRecibidasImportaciones(LbId.Text)
            f.init(LbId.Text)
            f.ShowDialog()

        End If



    End Sub


    Private Sub TxDato_5_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxDato_5.EnabledChanged
        BtImportaciones.Enabled = TxDato_5.Enabled
    End Sub


    Private Sub BtImportaciones_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles BtImportaciones.KeyDown
        If e.KeyCode = Keys.Left Then
            TxCuotaRe.Select()
            TxCuotaRe.Focus()
        ElseIf e.KeyCode = Keys.Right Then
            TxImpGasto1.Select()
            TxImpGasto1.Focus()
        End If
    End Sub

    Private Sub TxCuotaRe_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxCuotaRe.KeyDown
        If e.KeyCode = Keys.Right Then
            If TxCuotaRe.SelectionStart = TxCuotaRe.Text.Length Then
                BtImportaciones.Select()
                BtImportaciones.Focus()
            End If
        End If
    End Sub


    Private Sub CalculaTotalImportaciones()

        Dim FRI As New E_FacturasRecibidasImportaciones(Idusuario, cn)
        If FRI.LeerId(LbId.Text) Then
            Dim totalImportaciones As Decimal = VaDec(FRI.FRI_BaseSuplido.Valor) + VaDec(FRI.FRI_CuotaIva.Valor)
            LbTImportaciones.Text = totalImportaciones.ToString("#,##0.00")
        End If

        CalculaTotal(False)

    End Sub


    Private Sub LbAsiento_Click(sender As System.Object, e As System.EventArgs) Handles LbAsiento.Click

        If LbAsiento.Text <> "" Then

            Dim IdAsientoNET As Integer = VaInt(FacturasRecibidas.FRR_IdAsientoNet.Valor)
            Dim ListaAsientos As New List(Of Integer)
            ListaAsientos.Add(IdAsientoNET)
            Dim F As New FrmConsultaVisuAsiento(ListaAsientos, False)
            F.ShowDialog()

        End If

    End Sub


    Public Overrides Sub Guardar()


        If Not RbOtros.Checked Then
            If TxDato_4.Text.Trim = "" Then
                MsgBox("Debe introducir un proveedor o acreedor")
                Exit Sub
            End If
        End If


        'Cuando hay que insertar vencimiento? Cuando Fecha y/o importe de vto <> ''?
        Dim FechaVto As String = ""
        If VaDate(TxDato_11.Text) <> VaDate("") Then FechaVto = VaDate(TxDato_11.Text).ToString("dd/MM/yyyy")
        Dim ImporteVto As Decimal = VaDec(TxDato_12.Text)
        If VaDec(ImporteVto) <> 0 And FechaVto = "" Then
            MsgBox("Debe introducir una fecha de vencimiento")
            Exit Sub
        End If



        If Not ValidarDesglose() Then
            MsgBox("La suma del desglose de gastos es distinta del total de las bases")
            TxImpGasto1.MiError = True
            Exit Sub
        Else

            Dim campa As Integer = VaInt(Lbejer.Text)
            Dim IdCentro As Integer = VaInt(LbCentro.Text)
            Dim IdPuntoVenta As Integer = VaInt(LbIdPuntoVenta.Text)

            If LbId.Text = "+" Then
                FacturasRecibidas.FRR_Id.Valor = FacturasRecibidas.MaxId()
                LbId.Text = FacturasRecibidas.FRR_Id.Valor
            End If
            If TxDato_1.Text = "+" Then
                TxDato_1.Text = FacturasRecibidas.MaxIdCampa(campa, IdCentro)
            End If


            FacturasRecibidas.FRR_ejercicio.Valor = campa
            FacturasRecibidas.FRR_idcentro.Valor = IdCentro
            'FacturasRecibidas.FRR_IdCuenta.Valor = TxDato_10.Text
            FacturasRecibidas.FRR_IdPuntoVenta.Valor = IdPuntoVenta
            Dim totalFactura As Decimal = VaDec(LbTBase.Text) + VaDec(LbTIVa.Text) - VaDec(TxCuotaRe.Text) + VaDec(LbTImportaciones.Text)
            FacturasRecibidas.FRR_totalfac.Valor = totalFactura


            Dim tipofactura As String = ""
            If RbCompras.Checked Then
                tipofactura = TipoFacturaRecibida.ComprasGenero
            ElseIf RbGastosCom.Checked Then
                tipofactura = TipoFacturaRecibida.GastosCompras
            ElseIf RbGastosVen.Checked Then
                tipofactura = TipoFacturaRecibida.GastosVentas
            ElseIf RbMateriales.Checked Then
                tipofactura = TipoFacturaRecibida.Materiales
            ElseIf RbOtros.Checked Then
                tipofactura = TipoFacturaRecibida.Otros
            End If

            FacturasRecibidas.FRR_tipofactura.Valor = tipofactura


            '
            ActualizaAlbaranesGastos()


            'Si existía, guarda el formulario de facturasrecibidasimportaciones,
            'si no existía, guardamos aquí después de asignar el idfactura
            If Not IsNothing(_FacturasRecibidasImportaciones) Then
                If VaInt(_FacturasRecibidasImportaciones.FRI_idfactura.Valor) = 0 Then
                    _FacturasRecibidasImportaciones.FRI_idfactura.Valor = LbId.Text
                    Try
                        _FacturasRecibidasImportaciones.Insertar()
                    Catch ex As Exception
                        Try
                            _FacturasRecibidasImportaciones.Actualizar()
                        Catch ex2 As Exception
                            err.Muestraerror("Error al guardar las importaciones de la factura", "Guardar()", ex2.Message)
                        End Try
                    End Try

                End If
            End If

        End If


        MyBase.Guardar()

    End Sub


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()


        'ConectarFinancieroContabilidad es un valor en el INI
        If ConectarFinancieroContabilidad = "S" Then

            'Contabiliza
            Dim i As Integer = FacturasRecibidas.Contabiliza(LbId.Text)
            If i > 0 Then

                Dim ListaAsientos As New List(Of Integer)
                ListaAsientos.Add(i)
                Dim f As New frmVisualizadorAsiento(ListaAsientos, False, "")
                f.ShowDialog()

            Else
                MsgBox("no se generó asiento")
            End If


            'Genera IdFacturaNET

        End If



        'Gestión documental: Duplica documento para el asiento, muestra formulario nuevo con los documentos asociados al NIF para marcarlos y asociarlos a la factura

        'Se trata de la gestión documental de Financiero



    End Sub


    Public Overrides Sub Anular()

    End Sub


    Public Overrides Sub DespuesdeAnular()
        MyBase.DespuesdeAnular()

        Dim c As New Contabilizacion.clAsientos
        If IdasientoNet > 0 And VaInt(LbAsiento.Text) > 0 Then
            If c.AnularAsiento(IdasientoNet, LbAsiento.Text) <> 0 Then
                MsgBox("No se pudo anular el asiento ")
            Else
                MsgBox("Asiento anulado con exito")
            End If
        End If



    End Sub




    Private Sub CompruebaBloqueo()

        Dim bGeneraPago As Boolean = False

        Dim FormasPagoProveedor As New E_FormasPagoProveedor(Idusuario, CnCtb)
        If VaInt(TxDato_9.Text) > 0 Then
            If FormasPagoProveedor.LeerId(TxDato_9.Text) Then

                If FormasPagoProveedor.TipoFormaPago = E_FormasPagoProveedor.TipoFormaPagoProveedor.ReciboDomiciliado Or
                    FormasPagoProveedor.TipoFormaPago = E_FormasPagoProveedor.TipoFormaPagoProveedor.Confirming Or
                    FormasPagoProveedor.TipoFormaPago = E_FormasPagoProveedor.TipoFormaPagoProveedor.ReciboALaVista Or
                    FormasPagoProveedor.TipoFormaPago = E_FormasPagoProveedor.TipoFormaPagoProveedor.Contado Then
                    bGeneraPago = True
                End If

                If bGeneraPago And Not CompruebaBloqueoCuenta(TxDato_10.Text) Then
                    TxDato_4.MiError = True
                End If
            End If
        End If

    End Sub


    Private Sub TxDato_9_Valida(edicion As System.Boolean) Handles TxDato_9.Valida

        If edicion Then

            CompruebaBloqueo()

            'Fecha Vto (si está en blanco)
            If TxDato_11.Text.Trim = "" And VaDate(TxDato_2.Text) > VaDate("") Then

                Dim FormaPagoProveedor As New E_FormasPagoProveedor(Idusuario, CnCtb)
                If FormaPagoProveedor.LeerId(TxDato_9.Text) Then

                    Dim GeneraCartera As String = (FormaPagoProveedor.GeneraCartera.Valor & "").Trim.ToUpper.Trim
                    Dim NumRecibo As Integer = VaInt(FormaPagoProveedor.NumRecibos.Valor)
                    Dim Periodicidad As Integer = VaInt(FormaPagoProveedor.Periodicidad.Valor)

                    If GeneraCartera = "S" Then
                        If NumRecibo = 1 And Periodicidad > 0 Then
                            Dim Vencimiento As Date = VaDate(TxDato_2.Text) + TimeSpan.FromDays(Periodicidad)
                            TxDato_11.Text = Vencimiento.ToString("dd/MM/yyyy")
                        End If
                    End If

                End If

            End If

        End If

    End Sub




    Private Sub BtPagos_Click(sender As System.Object, e As System.EventArgs) Handles BtPagos.Click

        If Not IsNothing(_dtPagos) Then

            Dim fr As New FrBuscar
            Dim dt As DataTable = _dtPagos.Copy
            Dim ltCols As New List(Of Integer)

            dt.Columns.Remove("Id")
            dt.Columns.Remove("IdFactura")
            dt.Columns.Remove("IdPago")

            fr.InitDta(dt, "Pago")
            fr.ShowDialog()

        End If

    End Sub






    Private Sub txAlbaran_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txAlbaran.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim codigo As String = txAlbaran.Text
            If codigo.StartsWith("AEG") Then

                'Formato código de barras: AEG + AEG_Id formateado a 6
                codigo = codigo.Replace("AEG", "")
                codigo = VaInt(codigo).ToString

                Dim AlbEntrada_Gastos As New E_albentrada_gastos(Idusuario, cn)
                If AlbEntrada_Gastos.LeerId(codigo) Then

                    If VaInt(TxDato_4.Text) <> VaInt(AlbEntrada_Gastos.AEG_IdAcreedor.Valor) Then
                        MsgBox("El albarán introducido no es de este acreedor")
                        txAlbaran.Text = ""
                        Exit Sub
                    End If

                    Dim IdAlbaran As Integer = VaInt(AlbEntrada_Gastos.AEG_IdAlbaran.Valor)
                    Dim IdGasto As Integer = VaInt(AlbEntrada_Gastos.AEG_IdGasto.Valor)

                    MarcaAlbaran(IdAlbaran, IdGasto, True)

                End If

            End If

            txAlbaran.Text = ""

        End If
    End Sub


    Private Sub MarcaAlbaran(IdAlbaran As Integer, IdGasto As Integer, bValor As Boolean)

        For indice As Integer = 0 To GridViewAlbaranes.RowCount - 1
            Dim row As DataRow = GridViewAlbaranes.GetDataRow(indice)
            If Not IsNothing(row) Then

                If VaInt(row("IdAlbaran")) = IdAlbaran And VaInt(row("IdGasto")) = IdGasto Then
                    row("S") = bValor
                End If

            End If
        Next

        CalculaTotalesAlbaranes()

    End Sub


    Private Sub LbToFactura_TextChanged(sender As System.Object, e As System.EventArgs) Handles LbToFactura.TextChanged

        'If NuevoRegistro Or Modificando Then
        '    If TxDato_12.Text.Trim = "" Then
        '        TxDato_12.Text = LbToFactura.Text
        '    End If
        'End If

    End Sub

    Private Sub TxDato_2_Valida(edicion As System.Boolean) Handles TxDato_2.Valida
        If edicion Then
            TxDato_3.Text = TxDato_2.Text
        End If
    End Sub


End Class