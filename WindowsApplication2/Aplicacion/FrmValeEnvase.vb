Imports DevExpress.XtraEditors

Public Class FrmValeEnvase
    Inherits FrMantenimiento


    Dim Valeenvases As New E_ValeEnvases(Idusuario, cn)
    Dim Valeenvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
    Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
    Dim AlbEntrada_gastos As New E_albentrada_gastos(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim ConceptosEnvases As New E_ConceptosEnvases(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)



    Dim Mi_IdCentro As Integer
    Dim TipoVale As String
    Dim TipoSujeto As String


    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Envases As New E_Envases(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Public Sub New(TipoVale As String)

        Me.New()


        Me.TipoVale = TipoVale


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()

        BTaux1.Visible = True
        BTaux1.Text = "Imprimir"
        BTaux1.Image = PictureBox1.Image

        BtAux2.Visible = True
        BtAux2.Text = "I.Directa"
        BtAux2.Image = PictureBox2.Image



    End Sub
   

    Private Sub InitTipoVale()
        Dim consulta As New Cdatos.E_select

        '_btBusca.CL_ConsultaSql = "Select Idvale,operacion,codigo,campa,idcentro,numero,fecha from Valeenvases"


        BtBusca_10.CL_Filtro = ""


        Select Case TipoVale
            Case "EB" ' entrada en bascula
                TipoSujeto = "A"
                LbNomVale.Text = "Albaranes de entrada"
                AsociarControles(TxDato_3, BtBusca_3, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lbnom_3)
                BtBuscaAlbaran.CL_campocodigo = Agricultores.AGR_IdAgricultor
                BtBuscaAlbaran.CL_camponombre = Agricultores.AGR_Nombre
                ' BtBuscaAlbaran.CL_Filtro = "operacion='" + Tvale + "'"
                consulta.SelCampo(Valeenvases.VEV_Idvale, "IdVale")
                consulta.SelCampo(Valeenvases.VEV_Operacion, "Operacion")
                consulta.SelCampo(Valeenvases.VEV_Campa, "Campa")
                consulta.SelCampo(Valeenvases.VEV_Idcentro, "IdCentro")
                consulta.SelCampo(Centros.Nombre, "Centro", Valeenvases.VEV_Idcentro, Centros.IdCentro)
                consulta.SelCampo(Valeenvases.VEV_Numero, "Numero")
                consulta.SelCampo(Valeenvases.VEV_Codigo, "Codigo")
                consulta.SelCampo(Valeenvases.VEV_Fecha, "Fecha")
                consulta.SelCampo(Agricultores.AGR_Nombre, "Nombre", Valeenvases.VEV_Codigo)
                BtBuscaAlbaran.Params("IdCentro", , -1)
                BtBuscaAlbaran.CL_ConsultaSql = consulta.SQL



            Case "AA" ' AGRICULTORES
                TipoSujeto = "A"
                LbNomVale.Text = "Agricultores"
                AsociarControles(TxDato_3, BtBusca_3, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lbnom_3)
                BtBuscaAlbaran.CL_campocodigo = Agricultores.AGR_IdAgricultor
                BtBuscaAlbaran.CL_camponombre = Agricultores.AGR_Nombre
                consulta.SelCampo(Valeenvases.VEV_Idvale, "IdVale")
                consulta.SelCampo(Valeenvases.VEV_Operacion, "Operacion")
                consulta.SelCampo(Valeenvases.VEV_Campa, "Campa")
                consulta.SelCampo(Valeenvases.VEV_Idcentro, "IdCentro")
                consulta.SelCampo(Centros.Nombre, "Centro", Valeenvases.VEV_Idcentro, Centros.IdCentro)
                consulta.SelCampo(Valeenvases.VEV_Numero, "Numero")
                consulta.SelCampo(Valeenvases.VEV_Codigo, "Codigo")
                consulta.SelCampo(Valeenvases.VEV_Fecha, "Fecha")
                consulta.SelCampo(Agricultores.AGR_Nombre, "Nombre", Valeenvases.VEV_Codigo)
                BtBuscaAlbaran.Params("IdCentro", , -1)
                BtBuscaAlbaran.CL_ConsultaSql = consulta.SQL


                Lb_12.Visible = False
                TxDato_12.Visible = False
                Lb_14.Visible = False
                TxDato_14.Visible = False


            Case "RI" ' AGR. INVENTARIABLES
                TipoSujeto = "A"
                LbNomVale.Text = "Agr. Inventariables"
                AsociarControles(TxDato_3, BtBusca_3, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lbnom_3)
                BtBuscaAlbaran.CL_campocodigo = Agricultores.AGR_IdAgricultor
                BtBuscaAlbaran.CL_camponombre = Agricultores.AGR_Nombre
                consulta.SelCampo(Valeenvases.VEV_Idvale, "IdVale")
                consulta.SelCampo(Valeenvases.VEV_Operacion, "Operacion")
                consulta.SelCampo(Valeenvases.VEV_Campa, "Campa")
                consulta.SelCampo(Valeenvases.VEV_Idcentro, "IdCentro")
                consulta.SelCampo(Centros.Nombre, "Centro", Valeenvases.VEV_Idcentro, Centros.IdCentro)
                consulta.SelCampo(Valeenvases.VEV_Numero, "Numero")
                consulta.SelCampo(Valeenvases.VEV_Codigo, "Codigo")
                consulta.SelCampo(Valeenvases.VEV_Fecha, "Fecha")
                consulta.SelCampo(Agricultores.AGR_Nombre, "Nombre", Valeenvases.VEV_Codigo)
                BtBuscaAlbaran.Params("IdCentro", , -1)
                BtBuscaAlbaran.CL_ConsultaSql = consulta.SQL

                BtBusca_10.CL_Filtro = "Inv = 'S'"


                Lb_12.Visible = False
                TxDato_12.Visible = False
                Lb_14.Visible = False
                TxDato_14.Visible = False


            Case "CC", "SA", "SC", "SM", "DV" ' CLIENTES
                TipoSujeto = "C"
                LbNomVale.Text = "Clientes"
                AsociarControles(TxDato_3, BtBusca_3, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lbnom_3)
                BtBuscaAlbaran.CL_campocodigo = Clientes.CLI_Codigo
                BtBuscaAlbaran.CL_camponombre = Clientes.CLI_Nombre
                '  BtBuscaAlbaran.CL_Filtro = "operacion='" + Tvale + "'"
                consulta.SelCampo(Valeenvases.VEV_Idvale, "IdVale")
                consulta.SelCampo(Valeenvases.VEV_Operacion, "Operacion")
                consulta.SelCampo(Valeenvases.VEV_Campa, "Campa")
                consulta.SelCampo(Valeenvases.VEV_Idcentro, "IdCentro")
                consulta.SelCampo(Centros.Nombre, "Centro", Valeenvases.VEV_Idcentro, Centros.IdCentro)
                consulta.SelCampo(Valeenvases.VEV_Numero, "Numero")
                consulta.SelCampo(Valeenvases.VEV_Codigo, "Codigo")
                consulta.SelCampo(Valeenvases.VEV_Fecha, "Fecha")
                Dim oBloqueo As New Cdatos.bdcampo("@CASE COALESCE(CLI_Bloqueo, 'N') WHEN 'S' THEN 'S' ELSE 'N' END", Cdatos.TiposCampo.Cadena, 1)
                consulta.SelCampo(oBloqueo, "Bloqueo")
                consulta.SelCampo(Clientes.CLI_Nombre, "Nombre", Valeenvases.VEV_Codigo)

                BtBuscaAlbaran.Params("IdCentro", , -1)

                Dim Dc As New Dictionary(Of Object, Color)
                Dc("S") = Color.Red
                Dc("N") = Color.LimeGreen
                BtBuscaAlbaran.Params("Bloqueo", "B", 15, , , Dc)

                BtBuscaAlbaran.CL_ConsultaSql = consulta.SQL


            Case "AC" ' COMPRAS
                TipoSujeto = "R"
                LbNomVale.Text = "Compras de materiales"
                AsociarControles(TxDato_3, BtBusca_3, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, Lbnom_3)
                BtBuscaAlbaran.CL_campocodigo = Acreedores.ACR_Codigo
                BtBuscaAlbaran.CL_camponombre = Acreedores.ACR_Nombre
                BtBusca_3.CL_Filtro = "TIPO='MA'"
                '  BtBuscaAlbaran.CL_Filtro = "operacion='" + Tvale + "'"
                consulta.SelCampo(Valeenvases.VEV_Idvale, "IdVale")
                consulta.SelCampo(Valeenvases.VEV_Operacion, "Operacion")
                consulta.SelCampo(Valeenvases.VEV_Campa, "Campa")
                consulta.SelCampo(Valeenvases.VEV_Idcentro, "IdCentro")
                consulta.SelCampo(Centros.Nombre, "Centro", Valeenvases.VEV_Idcentro, Centros.IdCentro)
                consulta.SelCampo(Valeenvases.VEV_Numero, "Numero")
                consulta.SelCampo(Valeenvases.VEV_Codigo, "Codigo")
                consulta.SelCampo(Valeenvases.VEV_Fecha, "Fecha")
                consulta.SelCampo(Acreedores.ACR_Nombre, "Nombre", Valeenvases.VEV_Codigo)
                BtBuscaAlbaran.Params("IdCentro", , -1)
                BtBuscaAlbaran.CL_ConsultaSql = consulta.SQL


        End Select

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
        ParamTx(TxDato_3, Valeenvases.VEV_Codigo, Lb_3, True)
        ParamTx(TxDato_4, Valeenvases.VEV_IdAlmacen, Lb_4, True)
        ParamTx(TxDato_7, Valeenvases.VEV_Referencia, Lb_7, False)

        ParamTx(TxTransportista, Valeenvases.VEV_IdTransportista, LbTransportista)

        ParamTx(TxMatricula, Valeenvases.VEV_Matricula, LbMatricula)
        ParamTx(TxTractora, Valeenvases.VEV_Tractora, LbTractora)
        ParamTx(TxDato_5, Valeenvases.VEV_IdConcepto, Lb_5, False)
        ParamTx(TxDato_6, Valeenvases.VEV_Concepto, Lb_5, False)


        ParamTx(TxDato_10, Valeenvases_lineas.VEL_idenvase, Lb_10, True)
        ParamTx(TxDato_15, Valeenvases_lineas.VEL_idmarca, Lb_15, False)
        ParamTx(TxDato_16, Valeenvases_lineas.VEL_idalmacen, Lb_16, True)

        ParamTx(TxDato_11, Valeenvases_lineas.VEL_retira, Lb_11, False)
        If TipoVale <> "AA" And TipoVale <> "RI" Then ParamTx(TxDato_12, Valeenvases_lineas.VEL_precioretira, Lb_12, False)
        ParamTx(TxDato_13, Valeenvases_lineas.VEL_entrega, Lb_13, False)
        If TipoVale <> "AA" And TipoVale <> "RI" Then ParamTx(TxDato_14, Valeenvases_lineas.VEL_precioentrega, Lb_14, False)



        If TipoVale <> "AA" And TipoVale <> "RI" Then
            AsociarGrid(ClGrid1, TxDato_10, TxDato_14, Valeenvases_lineas)
        Else
            AsociarGrid(ClGrid1, TxDato_10, TxDato_13, Valeenvases_lineas)
        End If

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        PropiedadesCamposGr(ClGrid1, "VEL_Id", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 10)
        PropiedadesCamposGr(ClGrid1, "Envase", "Envase", True, 50)
        PropiedadesCamposGr(ClGrid1, "Marca", "Marca", True, 40)
        PropiedadesCamposGr(ClGrid1, "Almacen", "Almacen", True, 40)
        PropiedadesCamposGr(ClGrid1, "Retira", "Retira", True, 10, False, "#0")
        If TipoVale <> "AA" And TipoVale <> "RI" Then PropiedadesCamposGr(ClGrid1, "PrecioR", "PrecioR", True, 10, False, "#0.00")
        PropiedadesCamposGr(ClGrid1, "Entrega", "Entrega", True, 10, False, "#0")
        If TipoVale <> "AA" And TipoVale <> "RI" Then PropiedadesCamposGr(ClGrid1, "PrecioE", "PrecioE", True, 10, False, "#0.00")


        AsociarControles(TxDato_1, BtBuscaAlbaran, Valeenvases.btBusca, EntidadFrm)


        AsociarControles(TxDato_4, BtBusca_4, AlmacenEnvases.btBusca, AlmacenEnvases, AlmacenEnvases.AEV_Nombre, LbNom_4)
        AsociarControles(TxDato_10, BtBusca_10, Envases.btBusca, Envases, Envases.ENV_Nombre, Lbnom_10)
        AsociarControles(TxDato_15, BtBusca_15, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, Lbnom_15)
        AsociarControles(TxDato_16, BtBusca_16, AlmacenEnvases.btBusca, AlmacenEnvases, AlmacenEnvases.AEV_Nombre, Lbnom_16)
        AsociarControles(TxDato_5, BtBusca_5, ConceptosEnvases.btBusca, ConceptosEnvases)


        AsociarControles(TxTransportista, BtBuscaTransportista, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomTransportista)


        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me

        tt.SetToolTip(BtNuevo, "Nuevo")

        InitTipoVale()


        Select Case TipoSujeto
            Case "A"
                BtBuscaTransportista.CL_Filtro = "TIPO='PO'"
            Case "C"
                BtBuscaTransportista.CL_Filtro = "TIPO='PV'"
            Case "R"
                BtBuscaTransportista.CL_Filtro = "TIPO='PO'"
        End Select



    End Sub


    Private Sub FrmValeEnvase_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BTaux1.Visible = True
        BTaux1.Text = "Imprimir"
        BTaux1.Image = PictureBox1.Image
        
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


        If Valeenvases_lineas.VEL_TipoEnvase.Valor = E_FianzasEnvases.TipoFacturacion.FacturarAparte Then
            TxDato_12.Text = Mascara(Valeenvases_lineas.VEL_PrecioFianza.Valor, Cdatos.TiposCampo.Importe, TxDato_12.ClParam.Decimales)
        End If


        If (Valeenvases_lineas.VEL_Automatica.Valor & "").ToUpper.Trim = "S" Then

            'Grid.LineaBloqueada = True
            'BloquearCamposLineas(True, Grid)

        End If
        

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()


        Mi_IdCentro = Valeenvases.VEV_Idcentro.Valor
        LbCampa.Text = Valeenvases.VEV_Campa.Valor
        PintaCentro(Mi_IdCentro)
        TipoVale = Valeenvases.VEV_Operacion.Valor

        InitTipoVale()

        LbNumFac.Text = ObtenerNumFactura()

        ' llenar el grid
        CargaLineasGrid()

    End Sub


    Private Function ObtenerNumFactura() As String

        Dim res As String = ""
        Dim IdFactura As String = ""

        'Primero comprobamos si el vale de envases está enlazado directamente con una factura
        If VaInt(Valeenvases.VEV_idfactura.Valor) > 0 Then
            IdFactura = Valeenvases.VEV_idfactura.Valor
        Else


            'Busco por factura en AlbSalidaALH
            Dim consulta As New Cdatos.E_select

            Dim dt As New DataTable

            Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
            consulta = New Cdatos.E_select
            consulta.SelCampo(AlbSalida.ASA_idfactura, "IdFactura")
            consulta.WheCampo(AlbSalida.ASA_idvaleenvase, "=", Valeenvases.VEV_Idvale.Valor)

            dt = AlbSalida.MiConexion.ConsultaSQL(consulta.SQL)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    IdFactura = dt.Rows(0)("IdFactura")
                End If
            End If

        End If


        Dim Factura As New E_Facturas(Idusuario, cn)
        If VaInt(IdFactura) > 0 Then
            If Factura.LeerId(IdFactura) Then
                Dim serie As String = (Factura.FRA_serie.Valor & "").Trim
                res = Factura.FRA_factura.Valor
                If serie <> "" Then res = serie & "-" & res
            End If
        End If


        Return res

    End Function


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
        Valeenvases.VEV_TipoSujeto.Valor = TipoSujeto
        Valeenvases_lineas.VEL_idvale.Valor = LbId.Text



        SqlGrid()


        r = MyBase.GuardarLineas(Gr)
        Return r

    End Function


    Protected Overrides Sub DatosLin_a_Entidad(gr As ClGrid, EntidadLin As Cdatos.Entidad, Optional AsignarClavePrimariaLinea As Boolean = True)
        MyBase.DatosLin_a_Entidad(gr, EntidadLin, AsignarClavePrimariaLinea)


        'Si es una línea nueva y es vale de envases de cliente o salidas de clientes, habrá que rellenar el campo VEL_TipoEnvase
        If TipoVale = "CC" Or TipoVale = "SC" And VaDec(Valeenvases_lineas.VEL_Id.Valor) = 0 Then
            If (Valeenvases_lineas.VEL_TipoEnvase.Valor & "").Trim = "" Then

                Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
                Dim consulta As New Cdatos.E_select
                consulta.SelCampo(AlbSalida.ASA_idcliente, "IdCliente")
                consulta.SelCampo(AlbSalida.ASA_iddomicilio, "IdDomicilio")
                consulta.WheCampo(AlbSalida.ASA_idvaleenvase, "=", Valeenvases.VEV_Idvale.Valor)


                Dim IdCliente As String = "0"
                Dim IdDomicilio As String = "0"
                Dim IdSubFamilia As String = "0"

                Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(consulta.SQL)
                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 0 Then
                        IdCliente = (dt.Rows(0)("IdCliente").ToString & "").Trim
                        IdDomicilio = VaInt(dt.Rows(0)("IdDomicilio")).ToString
                    End If
                End If

                Dim Envases As New E_Envases(Idusuario, cn)
                If Envases.LeerId(Valeenvases_lineas.VEL_idenvase.Valor) Then
                    IdSubFamilia = VaInt(Envases.ENV_idsubfamilia.Valor).ToString
                End If

                Valeenvases_lineas.VEL_TipoEnvase.Valor = E_FianzasEnvases.TipoEnvase(IdCliente, IdDomicilio, IdSubFamilia)

            End If
        End If

        If Valeenvases_lineas.VEL_TipoEnvase.Valor = E_FianzasEnvases.TipoFacturacion.FacturarAparte Then
            Dim precioretira As Decimal = 0
            Valeenvases_lineas.VEL_precioretira.Valor = precioretira.ToString
            Valeenvases_lineas.VEL_PrecioFianza.Valor = VaDec(TxDato_12.Text).ToString
        End If


    End Sub



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
        MyBase.Borralin(gr)
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


        LbCampa.Text = MiMaletin.Ejercicio.ToString
        Mi_IdCentro = MiMaletin.IdCentro
        PintaCentro(Mi_IdCentro)
        LbNumFac.Text = ""

        BtBuscaAlbaran.CL_Filtro = "IDCENTRO=" + LbCentro.Text + " AND OPERACION='" + TipoVale + "' AND CAMPA=" + LbCampa.Text
        BotonesAvance1.Filtro = "VEV_IDCENTRO=" + LbCentro.Text + " AND VEV_OPERACION='" + TipoVale + "' AND VEV_CAMPA=" + LbCampa.Text


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
        CONSULTA.SelCampo(AlmacenEnvases.AEV_Nombre, "Almacen", Valeenvases_lineas.VEL_idalmacen)
        CONSULTA.SelCampo(Valeenvases_lineas.VEL_retira, "Retira")
        'CONSULTA.SelCampo(ValeEnvases_lineas.VEL_precioretira, "PrecioR")
        Dim oPrecioRetira As New Cdatos.bdcampo("@CASE VEL_TipoEnvase WHEN '" & E_FianzasEnvases.TipoFacturacion.FacturarAparte & "' THEN VEL_PrecioFianza ELSE VEL_PrecioRetira END", Cdatos.TiposCampo.Importe, Valeenvases_lineas.VEL_precioretira.Longitud, Valeenvases_lineas.VEL_precioretira.Decimales)
        CONSULTA.SelCampo(oPrecioRetira, "PrecioR")
        CONSULTA.SelCampo(ValeEnvases_lineas.VEL_entrega, "Entrega")
        CONSULTA.SelCampo(ValeEnvases_lineas.VEL_precioentrega, "PrecioE")

        CONSULTA.WheCampo(ValeEnvases_lineas.VEL_idvale, "=", id)
        sql = CONSULTA.SQL
        sql = sql + " order by VEL_id"

        ClGrid1.Consulta = sql

    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        'If VaInt(LbNumFac.Text) > 0 Then
        If LbNumFac.Text.Trim <> "" Then
            MsgBox("No se puede anular, el vale de envase o el albarán ya están facturados")
            Exit Sub
        End If

        If Valeenvases.LineasFacturadas(LbId.Text) Then
            MsgBox("No se puede anular, el vale de envase tiene líneas facturadas")
            Exit Sub
        End If


        MyBase.BAnular_Click(sender, e)

    End Sub

    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString Then
        ' MsgBox("no se puede modificar el albarán")
        ' Exit Sub
        ' End If

        'If VaInt(LbNumFac.Text) > 0 Then
        If LbNumFac.Text.Trim <> "" Then
            MsgBox("No se puede modificar, el vale de envase o el albarán ya están facturados")
            Exit Sub
        End If

        If Valeenvases.LineasFacturadas(LbId.Text) Then
            MsgBox("No se puede modificar, el vale de envase tiene líneas facturadas")
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


    Private Sub TxDato2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_14.TextChanged

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


    Private Sub TxDato_10_Valida(edicion As System.Boolean) Handles TxDato_10.Valida

        If edicion Then

            If TxDato_16.Text.Trim = "" Then
                TxDato_16.Text = TxDato_4.Text
                TxDato_16.Validar(True)
            End If


            If TipoVale = "AC" Then 'Compras material

                If VaInt(TxDato_10.Text) > 0 Then

                    Dim Envases As New E_Envases(Idusuario, cn)
                    If Envases.LeerId(TxDato_10.Text) Then

                        If (Envases.ENV_EnvaseObsoleto.Valor & "").Trim = "S" Then

                            'Obsoleto
                            If XtraMessageBox.Show("Material obsoleto. ¿Está seguro?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                                'Marcar como no obsoleto
                                TxDato_10.MiError = False
                                Envases.ENV_EnvaseObsoleto.Valor = "N"
                                Envases.Actualizar()

                            Else

                                TxDato_10.MiError = True

                            End If


                        End If

                    End If

                End If

            End If



        End If

    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirValeEnvases(LbId.Text, TipoImpresion.Preliminar)
            If chkImprimirCMR.Checked Then
                C1_ImprimirDCTMC(LbId.Text, TipoDCTMC.ValeEnvases, TipoImpresion.Preliminar)
            End If
        End If


    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirValeEnvases(LbId.Text, TipoImpresion.ImpresoraSeleccionada)
            If chkImprimirCMR.Checked Then
                C1_ImprimirDCTMC(LbId.Text, TipoDCTMC.ValeEnvases, TipoImpresion.ImpresoraPorDefecto)
            End If
        End If

    End Sub


    Private Sub TxDato_6_Valida(edicion As System.Boolean) Handles TxDato_6.Valida

        If edicion Then

            If TxDato_6.Text.Trim = "" Then

                Select Case TipoVale

                    Case "AA"
                        TxDato_6.Text = FnLeft("V.AGRICULTOR " & TxDato_3.Text & " - " & Lbnom_3.Text, 50)

                    Case "CC"
                        TxDato_6.Text = FnLeft("V.CLIENTE " & TxDato_3.Text & " - " & Lbnom_3.Text, 50)

                End Select

            End If

        End If

    End Sub

   
    Private Sub ClGrid1_DespuesIntro() Handles ClGrid1.DespuesIntro

        If (Valeenvases_lineas.VEL_Automatica.Valor & "").ToUpper.Trim = "S" Then

            TxDato_10.Enabled = False
            TxDato_15.Enabled = False
            TxDato_16.Enabled = False
            TxDato_11.Enabled = False
            TxDato_13.Enabled = False

            If TxDato_12.Visible Then
                TxDato_12.Select()
                TxDato_12.Focus()
                TxDato_12.Siguiente = TxDato_14.Orden
            ElseIf TxDato_14.Visible Then
                TxDato_14.Select()
                TxDato_14.Focus()
            End If
            
        End If

    End Sub

    
    Private Sub TxDato_3_Valida(edicion As System.Boolean) Handles TxDato_3.Valida

        If edicion Then

            If TipoSujeto = "C" Then


                Dim Clientes As New E_Clientes(Idusuario, cn)
                If Clientes.LeerId(TxDato_3.Text) Then

                    Dim Bloqueado As String = (Clientes.CLI_Bloqueo.Valor & "").Trim.ToUpper

                    If Bloqueado = "S" Then
                        XtraMessageBox.Show("CLIENTE BLOQUEADO" & vbCrLf & Clientes.CLI_Bloqueocausa.Valor, "CLIENTE BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        TxDato_3.MiError = True
                    End If

                End If


            ElseIf TipoSujeto = "A" Then

                Dim Agricultores As New E_Agricultores(Idusuario, cn)
                If Agricultores.LeerId(TxDato_3.Text) Then


                    If Agricultores.AGR_TextoMensaje1.Valor.Trim <> "" Or Agricultores.AGR_TextoMensaje2.Valor.Trim <> "" Then
                        MsgBox(Agricultores.AGR_TextoMensaje1.Valor & Chr(13) & Chr(10) + Agricultores.AGR_TextoMensaje2.Valor)
                    End If


                    Dim Bloqueado As String = (Agricultores.AGR_Bloqueado.Valor & "").Trim.ToUpper
                    If Bloqueado = "S" Then

                        If VaDec(TxDato_11.Text) > 0 Then
                            MsgBox("AGRICULTOR BLOQUEADO")
                            TxDato_3.MiError = True
                        End If

                    End If

                End If

            End If

        End If

    End Sub


    Private Sub TxDato_11_Valida(edicion As System.Boolean) Handles TxDato_11.Valida

        If edicion Then

            If TipoSujeto = "A" Then

                If VaDec(TxDato_11.Text) > 0 Then

                    Dim Bloqueado As String = (Agricultores.AGR_Bloqueado.Valor & "").Trim.ToUpper
                    If Bloqueado = "S" Then

                        If VaDec(TxDato_11.Text) > 0 Then
                            MsgBox("AGRICULTOR BLOQUEADO")
                            TxDato_11.MiError = True
                        End If

                    End If

                End If


            End If

        End If

    End Sub
End Class