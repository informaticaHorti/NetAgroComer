Imports DevExpress.XtraEditors

Public Class FrmModificarTipoFianzaEnvase
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


        TipoSujeto = "C"
        LbNomVale.Text = "Clientes"
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

        Dim Dc As New Dictionary(Of Object, Color)
        Dc("S") = Color.Red
        Dc("N") = Color.LimeGreen


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

        ParamTx(TxPrecio, Valeenvases_lineas.VEL_precioretira, Lb_12, False)
        ParamTx(TxTipo, Valeenvases_lineas.VEL_TipoEnvase, LbTipo, True, , , , "ABC")

        AsociarGrid(ClGrid1, TxPrecio, TxTipo, Valeenvases_lineas)

        PropiedadesCamposGr(ClGrid1, "VEL_Id", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 10)
        PropiedadesCamposGr(ClGrid1, "Envase", "Envase", True, 50)
        PropiedadesCamposGr(ClGrid1, "Marca", "Marca", True, 40)
        PropiedadesCamposGr(ClGrid1, "Almacen", "Almacen", True, 40)
        PropiedadesCamposGr(ClGrid1, "Retira", "Retira", True, 10, False, "#0")
        PropiedadesCamposGr(ClGrid1, "PrecioR", "PrecioR", True, 10, False, "#0.00")
        PropiedadesCamposGr(ClGrid1, "Entrega", "Entrega", True, 10, False, "#0")
        PropiedadesCamposGr(ClGrid1, "PrecioE", "PrecioE", True, 10, False, "#0.00")

        InitTipoVale()


    End Sub


    Private Sub FrmValeEnvase_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BTaux1.Visible = False
        BtAux2.Visible = False
        BAnular.Visible = False

    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave

        Dim i As Integer = Valeenvases.LeerVale(CInt(LbCampa.Text), VaInt(LbCentro.Text), TipoVale, CInt(TxDato_1.Text))
        If i > 0 Then

            LbId.Text = i.ToString

            CargaLineasGrid()

        Else
            MsgBox("El vale no existe")
            TxDato_1.MiError = True
        End If

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)


        If VaDec(Valeenvases_lineas.VEL_Id.Valor) = 0 Then
            ClGrid1.LineaBloqueada = True
        Else
            ClGrid1.LineaBloqueada = False
        End If


        If Valeenvases_lineas.VEL_TipoEnvase.Valor = E_FianzasEnvases.TipoFacturacion.FacturarAparte Then
            TxPrecio.Text = Mascara(Valeenvases_lineas.VEL_PrecioFianza.Valor, Cdatos.TiposCampo.Importe, TxPrecio.ClParam.Decimales)
        End If

        If VaInt(Valeenvases_lineas.VEL_idenvase.Valor) > 0 Then LbEnvase.Text = Valeenvases_lineas.VEL_idenvase.Valor
        If VaInt(Valeenvases_lineas.VEL_idmarca.Valor) > 0 Then LbMarca.Text = Valeenvases_lineas.VEL_idmarca.Valor
        If VaInt(Valeenvases_lineas.VEL_idalmacen.Valor) > 0 Then LbAlmacenLinea.Text = Valeenvases_lineas.VEL_idalmacen.Valor
        LbRetira.Text = VaDec(Valeenvases_lineas.VEL_retira.Valor).ToString("#,##0.00")
        LbEntrega.Text = VaDec(Valeenvases_lineas.VEL_entrega.Valor).ToString("#,##0.00")
        LbPrecioEntrega.Text = VaDec(Valeenvases_lineas.VEL_precioentrega.Valor).ToString("#,##0.000000")


        Dim sql As String = "SELECT ENV_Nombre as Envase, AEV_Nombre as Almacen, MAR_Nombre as Marca" & vbCrLf
        sql = sql & " FROM Valeenvases_lineas" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = VEL_IdEnvase " & vbCrLf
        sql = sql & " LEFT JOIN AlmacenEnvases ON AEV_IdAlmacen = VEL_IdAlmacen" & vbCrLf
        sql = sql & " LEFT JOIN Marcas ON MAR_IdMarca = VEL_IdMarca" & vbCrLf
        sql = sql & " WHERE VEL_Id = " & Valeenvases_lineas.VEL_Id.Valor & vbCrLf

        Dim dt As DataTable = Valeenvases_lineas.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim row As DataRow = dt.Rows(0)

                LbNomEnvase.Text = (row("Envase").ToString & "").Trim
                LbNomMarca.Text = (row("Marca").ToString & "").Trim
                LbNomAlmacenLinea.Text = (row("Almacen").ToString & "").Trim

            End If
        End If


    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()


        Mi_IdCentro = Valeenvases.VEV_Idcentro.Valor
        LbCampa.Text = Valeenvases.VEV_Campa.Valor
        PintaCentro(Mi_IdCentro)
        TipoVale = Valeenvases.VEV_Operacion.Valor

        InitTipoVale()

        If VaDate(Valeenvases.VEV_Fecha.Valor) > VaDate("") Then LbFecha.Text = Valeenvases.VEV_Fecha.Valor
        LbCodigo.Text = Valeenvases.VEV_Codigo.Valor
        If VaInt(Valeenvases.VEV_IdAlmacen.Valor) > 0 Then LbAlmacen.Text = Valeenvases.VEV_IdAlmacen.Valor
        LbReferencia.Text = Valeenvases.VEV_Referencia.Valor
        LbMatriculaRemolque.Text = Valeenvases.VEV_Matricula.Valor
        If VaInt(Valeenvases.VEV_IdTransportista.Valor) > 0 Then LbTransportista.Text = Valeenvases.VEV_IdTransportista.Valor
        LbMatriculaTractora.Text = Valeenvases.VEV_Tractora.Valor
        If VaInt(Valeenvases.VEV_IdConcepto.Valor) > 0 Then LbConcepto.Text = Valeenvases.VEV_IdConcepto.Valor
        LbNomConcepto.Text = Valeenvases.VEV_Concepto.Valor


        Dim sql As String = "SELECT CLI_Nombre as Cliente, AEV_Nombre as Almacen, ACR_Nombre as Transportista" & vbCrLf
        sql = sql & " FROM Valeenvases" & vbCrLf
        sql = sql & " LEFT JOIN Clientes ON CLI_IdCliente = VEV_Codigo" & vbCrLf
        sql = sql & " LEFT JOIN AlmacenEnvases ON AEV_IdAlmacen = VEV_IdAlmacen" & vbCrLf
        sql = sql & " LEFT JOIN Acreedores ON ACR_Codigo = VEV_IdTransportista" & vbCrLf
        sql = sql & " WHERE VEV_IdVale = " & LbId.Text & vbCrLf

        Dim dt As DataTable = Valeenvases.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim row As DataRow = dt.Rows(0)
                LbNomSujeto.Text = (row("Cliente").ToString & "").Trim
                LbNomAlmacen.Text = (row("Almacen").ToString & "").Trim
                LbNomTransportista.Text = (row("Transportista").ToString & "").Trim

            End If
        End If

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


        ''Si es una línea nueva y es vale de envases de cliente o salidas de clientes, habrá que rellenar el campo VEL_TipoEnvase
        'If TipoVale = "CC" Or TipoVale = "SC" And VaDec(Valeenvases_lineas.VEL_Id.Valor) = 0 Then
        '    If (Valeenvases_lineas.VEL_TipoEnvase.Valor & "").Trim = "" Then

        '        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
        '        Dim consulta As New Cdatos.E_select
        '        consulta.SelCampo(AlbSalida.ASA_idcliente, "IdCliente")
        '        consulta.SelCampo(AlbSalida.ASA_iddomicilio, "IdDomicilio")
        '        consulta.WheCampo(AlbSalida.ASA_idvaleenvase, "=", Valeenvases.VEV_Idvale.Valor)


        '        Dim IdCliente As String = "0"
        '        Dim IdDomicilio As String = "0"
        '        Dim IdSubFamilia As String = "0"

        '        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(consulta.SQL)
        '        If Not IsNothing(dt) Then
        '            If dt.Rows.Count > 0 Then
        '                IdCliente = (dt.Rows(0)("IdCliente").ToString & "").Trim
        '                IdDomicilio = VaInt(dt.Rows(0)("IdDomicilio")).ToString
        '            End If
        '        End If

        '        Dim Envases As New E_Envases(Idusuario, cn)
        '        If Envases.LeerId(Valeenvases_lineas.VEL_idenvase.Valor) Then
        '            IdSubFamilia = VaInt(Envases.ENV_idsubfamilia.Valor).ToString
        '        End If

        '        Valeenvases_lineas.VEL_TipoEnvase.Valor = E_FianzasEnvases.TipoEnvase(IdCliente, IdDomicilio, IdSubFamilia)

        '    End If
        'End If

        'If Valeenvases_lineas.VEL_TipoEnvase.Valor = E_FianzasEnvases.TipoFacturacion.FacturarAparte Then
        '    Dim precioretira As Decimal = 0
        '    Valeenvases_lineas.VEL_precioretira.Valor = precioretira.ToString
        '    Valeenvases_lineas.VEL_PrecioFianza.Valor = VaDec(TxPrecio.Text).ToString
        'End If

        If TxTipo.Text = E_FianzasEnvases.TipoFacturacion.FacturarAparte Then
            Dim precioretira As Decimal = 0
            Valeenvases_lineas.VEL_precioretira.Valor = precioretira.ToString
            Valeenvases_lineas.VEL_PrecioFianza.Valor = VaDec(TxPrecio.Text).ToString
        Else
            Dim preciofianza As Decimal = 0
            Valeenvases_lineas.VEL_precioretira.Valor = VaDec(TxPrecio.Text).ToString
            Valeenvases_lineas.VEL_PrecioFianza.Valor = preciofianza.ToString
        End If


    End Sub



    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()


    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)

        LbEnvase.Text = ""
        LbNomEnvase.Text = ""
        LbMarca.Text = ""
        LbNomMarca.Text = ""
        LbAlmacenLinea.Text = ""
        LbNomAlmacenLinea.Text = ""
        LbRetira.Text = ""
        LbEntrega.Text = ""
        LbPrecioEntrega.Text = ""

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


        LbCampa.Text = MiMaletin.Ejercicio.ToString
        Mi_IdCentro = MiMaletin.IdCentro
        PintaCentro(Mi_IdCentro)
        LbNumFac.Text = ""

        LbFecha.Text = ""
        LbCodigo.Text = ""
        LbNomSujeto.Text = ""
        LbAlmacen.Text = ""
        LbNomAlmacen.Text = ""
        LbReferencia.Text = ""
        LbMatriculaRemolque.Text = ""
        LbTransportista.Text = ""
        LbNomTransportista.Text = ""
        LbMatriculaTractora.Text = ""
        LbConcepto.Text = ""
        LbNomConcepto.Text = ""

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

        'De momento no controlamos nada sobre si está facturado o no

        ''If VaInt(LbNumFac.Text) > 0 Then
        'If LbNumFac.Text.Trim <> "" Then
        '    MsgBox("No se puede modificar, el vale de envase o el albarán ya están facturados")
        '    Exit Sub
        'End If

        'If Valeenvases.LineasFacturadas(LbId.Text) Then
        '    MsgBox("No se puede modificar, el vale de envase tiene líneas facturadas")
        '    Exit Sub
        'End If

        MyBase.BModificar_Click(sender, e)

    End Sub


    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxDato_1.Text = "" And TxDato_1.Enabled = True Then
            TxDato_1.Text = "+"
            Siguiente(0)
        End If
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


    Private Sub ClGrid1_DespuesIntro() Handles ClGrid1.DespuesIntro

        Dim row As DataRow = ClGrid1.GridView.GetFocusedDataRow()
        If Not IsNothing(row) Then
            If VaInt(row(0)) = 0 Then
                BloquearCamposLineas(True, ClGrid1)
            Else
                BloquearCamposLineas(False, ClGrid1)
            End If
        End If

        If (Valeenvases_lineas.VEL_Automatica.Valor & "").ToUpper.Trim = "S" Then
            TxPrecio.Select()
            TxPrecio.Focus()
        End If

    End Sub


    Private Sub ClGrid1_FocusedRowHandle(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles ClGrid1.FocusedRowHandle

        

    End Sub

    Private Sub TxPrecio_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxPrecio.EnabledChanged
        If TxPrecio.Enabled = True Then
            Dim a As String = ""
        End If

    End Sub
End Class