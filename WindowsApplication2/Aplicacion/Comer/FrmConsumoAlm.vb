Imports DevExpress.XtraEditors

Public Class FrmConsumoAlm

    Inherits FrMantenimiento


    Dim Valeenvases As New E_ValeEnvases(Idusuario, cn)
    Dim Valeenvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
    Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
    Dim ConceptosEnvases As New E_ConceptosEnvases(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)



    Dim Mi_IdCentro As Integer
    Dim TipoVale As String = "CN"
    Dim TipoSujeto As String


    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Envases As New E_Envases(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()

    End Sub





    Private Sub ParametrosFrm()
        EntidadFrm = Valeenvases


        Dim lc As New List(Of Object)
        ListaControles = lc



        ParamTx(TxDato_1, Valeenvases.VEV_Numero, Lb1, True)
        TxDato_1.Autonumerico = True
        LbCentro.CL_ControlAsociado = TxDato_1
        LbNomCentro.CL_ControlAsociado = TxDato_1
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato_2, Valeenvases.VEV_Fecha, Lb_2, True)
        ParamTx(TxDato_4, Valeenvases.VEV_IdAlmacen, Lb_4, True)
        ParamTx(TxDato_5, Valeenvases.VEV_IdConcepto, Lb_5, False)
        ParamTx(TxDato_6, Valeenvases.VEV_Concepto, Lb_5, False)
        ParamTx(TxDato_7, Valeenvases.VEV_Referencia, Lb_7, False)


        ParamTx(TxDato_10, Valeenvases_lineas.VEL_idenvase, Lb_10, True)
        ParamTx(TxDato_15, Valeenvases_lineas.VEL_idmarca, Lb_15, False)

        ParamTx(TxDato_11, Valeenvases_lineas.VEL_retira, Lb_11, False)
        ParamTx(TxDato_12, Valeenvases_lineas.VEL_precioretira, Lb_12, False)


        AsociarGrid(ClGrid1, TxDato_10, TxDato_12, Valeenvases_lineas)

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        PropiedadesCamposGr(ClGrid1, "VEL_Id", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 10)
        PropiedadesCamposGr(ClGrid1, "Envase", "Envase", True, 50)
        PropiedadesCamposGr(ClGrid1, "Marca", "Marca", True, 40)
        PropiedadesCamposGr(ClGrid1, "Uds", "Uds", True, 10, False, "#0.00")
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 12, False, "#,##0.000000")
        PropiedadesCamposGr(ClGrid1, "Importe", "Importe", True, 14, True, "#,##0.00", "{0:n2}")


        AsociarControles(TxDato_1, BtBuscaAlbaran, Valeenvases.btBusca, EntidadFrm)
        AsociarBtbuscaAlbaran()


        AsociarControles(TxDato_4, BtBusca_4, AlmacenEnvases.btBusca, AlmacenEnvases, AlmacenEnvases.AEV_Nombre, LbNom_4)
        AsociarControles(TxDato_10, BtBusca_10, Envases.btBusca, Envases, Envases.ENV_Nombre, Lbnom_10)
        AsociarControles(TxDato_15, BtBusca_15, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, Lbnom_15)
        AsociarControles(TxDato_5, BtBusca_5, ConceptosEnvases.btBusca, ConceptosEnvases)



        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me

        tt.SetToolTip(BtNuevo, "Nuevo")



    End Sub

    Private Sub AsociarBtbuscaAlbaran()
        Dim consulta As New Cdatos.E_select

        BtBuscaAlbaran.CL_campocodigo = AlmacenEnvases.AEV_Idalmacen
        BtBuscaAlbaran.CL_camponombre = AlmacenEnvases.AEV_Nombre
        BtBuscaAlbaran.CL_Filtro = "operacion='CN'"
        consulta.SelCampo(Valeenvases.VEV_Idvale, "IdVale")
        consulta.SelCampo(Valeenvases.VEV_Operacion, "Operacion")
        consulta.SelCampo(Valeenvases.VEV_Campa, "Campa")
        consulta.SelCampo(Valeenvases.VEV_Idcentro, "Idcentro")
        consulta.SelCampo(Valeenvases.VEV_IdAlmacen, "Codigo")
        consulta.SelCampo(AlmacenEnvases.AEV_Nombre, "Almacen", Valeenvases.VEV_IdAlmacen)
        consulta.SelCampo(Valeenvases.VEV_Numero, "Numero")
        consulta.SelCampo(Valeenvases.VEV_Codigo, "Codigo")
        consulta.SelCampo(Valeenvases.VEV_Fecha, "Fecha")

        BtBuscaAlbaran.Params("Operacion", , -1)
        BtBuscaAlbaran.Params("Idcentro", , -1)
        BtBuscaAlbaran.CL_ConsultaSql = consulta.SQL



    End Sub

    Private Sub FrmValeEnvase_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BTaux1.Visible = True
        BTaux1.Text = "Imprimir vale"
        BTaux1.Image = PictureBox1.Image
        BTaux1.Width = 100

    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        Dim i As Integer


        If TxDato_1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = Valeenvases.LeerVale(CInt(LbCampa.Text), VaInt(LbCentro.Text), TipoVale, CInt(TxDato_1.Text))
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


        'Usamos el centro de recogida como el almacén de envases por defecto
        If VaInt(MiMaletin.IdCentroRecogida) > 0 Then
            TxDato_4.Text = MiMaletin.IdCentroRecogida.ToString
            TxDato_4.Validar(False)
        End If



    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)

        Dim Importe As Decimal = VaDec(Valeenvases_lineas.VEL_retira.Valor) * VaDec(Valeenvases_lineas.VEL_precioretira.Valor)
        LbImporte.Text = "Importe: " & Importe.ToString("#,##0.00")

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()


        Mi_IdCentro = Valeenvases.VEV_Idcentro.Valor
        LbCampa.Text = Valeenvases.VEV_Campa.Valor
        PintaCentro(Mi_IdCentro)
        TipoVale = Valeenvases.VEV_Operacion.Valor


        ' llenar el grid
        CargaLineasGrid()

    End Sub




    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean

        If LbId.Text = "+" Then
            LbId.Text = Valeenvases.MaxId
            If TxDato_1.Text = "+" Then
                TxDato_1.Text = Valeenvases.MaxIdCampa(Val(LbCampa.Text), LbCentro.Text, TipoVale)
            End If
        End If
        Valeenvases.VEV_Idvale.Valor = LbId.Text
        Valeenvases.VEV_Campa.Valor = LbCampa.Text
        Valeenvases.VEV_Idcentro.Valor = LbCentro.Text
        Valeenvases.VEV_Operacion.Valor = TipoVale
        Valeenvases.VEV_TipoSujeto.Valor = ""
        Valeenvases_lineas.VEL_idvale.Valor = LbId.Text
        Valeenvases_lineas.VEL_idalmacen.Valor = TxDato_4.Text
        SqlGrid()
        r = MyBase.GuardarLineas(Gr)
        Return r
    End Function


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()

        ''TODO: Preguntar si desea generar factura (e imprimirla)
        'If XtraMessageBox.Show("¿Desea generar la factura?", "Facturar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

        '    Dim IdFactura As String = GenerarFacturaEnvases(LbId.Text)
        '    If VaInt(IdFactura) > 0 Then
        '        ImprimirFacturaEnvases(IdFactura, TipoImpresion.ImpresoraPorDefecto, False, "", "", "")
        '    End If

        'End If


    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)

        LbImporte.Text = "Importe: "

        MyBase.Borralin(gr)
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


        LbCampa.Text = MiMaletin.Ejercicio.ToString
        Mi_IdCentro = MiMaletin.IdCentro
        PintaCentro(Mi_IdCentro)

        BtBuscaAlbaran.CL_Filtro = "IDCENTRO=" + LbCentro.Text + " AND OPERACION='" + TipoVale + "' AND CAMPA=" + LbCampa.Text
        BotonesAvance1.Filtro = "VEV_IDCENTRO=" + LbCentro.Text + " AND VEV_OPERACION='" + TipoVale + "' AND VEV_CAMPA=" + LbCampa.Text

        LbImporte.Text = "Importe: "

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
        Dim sql As String
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(Valeenvases_lineas.VEL_Id)
        CONSULTA.SelCampo(ValeEnvases_lineas.VEL_idenvase, "Codigo")
        CONSULTA.SelCampo(Envases.ENV_Nombre, "Envase", ValeEnvases_lineas.VEL_idenvase)
        CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", Valeenvases_lineas.VEL_idmarca)
        CONSULTA.SelCampo(Valeenvases_lineas.VEL_retira, "Uds")
        CONSULTA.SelCampo(Valeenvases_lineas.VEL_precioretira, "Precio")
        Dim strImporte As New Cdatos.bdcampo("@COALESCE(VEL_Retira,0) * COALESCE(VEL_PrecioRetira,0) ", Cdatos.TiposCampo.Importe, 18, 2)
        CONSULTA.SelCampo(strImporte, "Importe")
        CONSULTA.WheCampo(Valeenvases_lineas.VEL_idvale, "=", id)
        sql = CONSULTA.SQL
        sql = sql + " order by VEL_id"

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
        If TxDato_1.Text = "" And TxDato_1.Enabled = True Then
            TxDato_1.Text = "+"
            Siguiente(0)
        End If
    End Sub


    Private Sub TxDato2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PintaCentro(ByVal Centro As Integer)

        LbCentro.Text = Centro.ToString
        If Centros.LeerId(LbCentro.Text) = True Then
            LbNomCentro.Text = Centros.Nombre.Valor
        Else
            LbNomCentro.Text = ""
        End If


    End Sub

    Public Overrides Sub Guardar()


        MyBase.Guardar()

    End Sub


    Public Overrides Sub ImpresionDirecta()

        BotonAuxiliar2()

    End Sub



    Private Sub TxDato_5_Valida(ByVal edicion As Boolean) Handles TxDato_5.Valida
        If edicion = True Then
            If TxDato_6.Text = "" Then
                If ConceptosEnvases.LeerId(TxDato_5.Text) = True Then
                    TxDato_6.Text = ConceptosEnvases.COE_Nombre.Valor
                End If
            End If
        End If
    End Sub




    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        'Preliminar, no usa PrintVB6
        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirValeEnvases(LbId.Text, TipoImpresion.Preliminar, "", "", "")
        End If


    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirValeEnvases(LbId.Text, TipoImpresion.ImpresoraSeleccionada)
        End If

    End Sub


    'Private Function GenerarFacturaEnvases(IdVale As String) As String

    '    Dim res As String = ""


    '    Dim Facturas As New E_Facturas(Idusuario, cn)

    '    Facturas.FRA_idfactura.Valor = Facturas.MaxId()
    '    Facturas.FRA_factura.Valor = Facturas.MaxIdCampa(MiMaletin.Ejercicio.ToString, serie)

    '    Facturas.Insertar()

    '    'If LbId.Text = "+" Then
    '    '    Facturas.FRA_idfactura.Valor = Facturas.MaxId()
    '    '    LbId.Text = Facturas.FRA_idfactura.Valor
    '    '    If TxDato_1.Text = "+" Then
    '    '        TxDato_1.Text = Facturas.MaxIdCampa(VaInt(Lbejer.Text), TxDato_0.Text)
    '    '    End If
    '    'End If



    '    'Facturas.FRA_idpuntoventa.Valor = LbPuntoVenta.Text
    '    'Facturas.FRA_campa.Valor = Lbejer.Text


    '    'Facturas.FRA_Base2.Valor = VaDec(LbTEnvases.Text)

    '    'Facturas.FRA_Cuota2.Valor = VaDec(LbCuotaEnv.Text)

    '    'Facturas.FRA_CuotaRe2.Valor = VaDec(LbCuotaReEnv.Text)
    '    'Facturas.FRA_clientealbaranes.Valor = TxDato_5.Text
    '    'Facturas.FRA_cdpais.Valor = "1"
    '    'Facturas.FRA_cddivisa.Valor = "1"


    '    'Facturas.FRA_totalfactura.Valor = VaDec(LbTotEuros.Text)
    '    'Facturas.FRA_tipofactura.Valor = "1"
    '    'Facturas.FRA_alhcom.Valor = "E"
    '    'Facturas.FRA_idcentro.Valor = MiCentro




    '    Return res

    'End Function


    Private Sub TxDato_10_Valida(edicion As System.Boolean) Handles TxDato_10.Valida
        If edicion Then

            If TxDato_12.Text.Trim = "" Then
                Dim precio As Decimal = VaDec(Envases.ENV_CosteSalida.Valor)
                TxDato_12.Text = precio.ToString("#,##0.000000")
            End If

        End If
    End Sub

    Private Sub TxDato_11_Valida(edicion As System.Boolean) Handles TxDato_11.Valida
        If edicion Then
            Dim Importe As Decimal = VaDec(TxDato_11.Text) * VaDec(TxDato_12.Text)
            LbImporte.Text = "Importe: " & Importe.ToString("#,##0.00")
        End If
    End Sub

    Private Sub TxDato_12_Valida(edicion As System.Boolean) Handles TxDato_12.Valida
        If edicion Then
            Dim Importe As Decimal = VaDec(TxDato_11.Text) * VaDec(TxDato_12.Text)
            LbImporte.Text = "Importe: " & Importe.ToString("#,##0.00")
        End If
    End Sub
End Class