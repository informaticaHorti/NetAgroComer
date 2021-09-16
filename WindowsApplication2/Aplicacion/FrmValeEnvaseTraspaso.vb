Imports DevExpress.XtraEditors

Public Class FrmValeEnvaseTraspaso
    Inherits FrMantenimiento



    Dim Valeenvases_traspaso As New E_ValeEnvases_Traspaso(Idusuario, cn)
    Dim Valeenvases_traspaso_lineas As New E_ValeEnvases_traspaso_Lineas(Idusuario, cn)
    Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)

    Dim Mi_IdCentro As Integer
    Dim TipoVale As String
    Dim TipoSujeto As String


    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Envases As New E_Envases(Idusuario, cn)


    Private Sub ParametrosFrm()

        EntidadFrm = Valeenvases_traspaso


        Dim lc As New List(Of Object)
        ListaControles = lc



        ParamTx(TxDato_1, Valeenvases_traspaso.VET_Numero, Lb1, True)
        TxDato_1.Autonumerico = True
        LbCentro.CL_ControlAsociado = TxDato_1
        LbNomCentro.CL_ControlAsociado = TxDato_1
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato_2, Valeenvases_traspaso.VET_Fecha, Lb_2, True)
        ParamTx(TxDato_3, Valeenvases_traspaso.VET_IdAlmacenOrigen, Lb_3, False)
        ParamTx(TxDato_4, Valeenvases_traspaso.VET_IdAlmacenDestino, Lb_4, False)
        ParamTx(TxTransportista, Valeenvases_traspaso.VET_IdTransportista, LbTransportista)
        ParamTx(TxMatricula, Valeenvases_traspaso.VET_Matricula, LbMatricula)
        ParamTx(TxTractora, Valeenvases_traspaso.VET_Tractora, LbTractora)

        ParamTx(TxDato_6, Valeenvases_traspaso.VET_Concepto, Lb_5, False)

        ParamTx(TxDato_10, Valeenvases_traspaso_lineas.VTL_idenvase, Lb_10, True)
        ParamTx(TxDato_15, Valeenvases_traspaso_lineas.VTL_idmarca, Lb_15, False)

        ParamTx(TxDato_11, Valeenvases_traspaso_lineas.VTL_uds, Lb_11, False)
        ParamTx(TxDato_12, Valeenvases_traspaso_lineas.VTL_precio, Lb_12, False)





        AsociarGrid(ClGrid1, TxDato_10, TxDato_12, Valeenvases_traspaso_lineas)

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        'PropiedadesCamposGr(ClGrid1, Valeenvases_traspaso_lineas.VTL_Id.NombreCampo, "Id", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "VTL_Id", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 10)
        PropiedadesCamposGr(ClGrid1, "Envase", "Envase", True, 50)
        PropiedadesCamposGr(ClGrid1, "Uds", "Uds", True, 10, True, "#0")
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 10, False, "#,##0.000000")
        PropiedadesCamposGr(ClGrid1, "Importe", "Importe", True, 12, True, "#,##0.00", "{0:n2}")


        AsociarControles(TxDato_1, BtBuscaAlbaran, Valeenvases_traspaso.btBusca, EntidadFrm)


        AsociarControles(TxDato_3, BtBusca_3, AlmacenEnvases.btBusca, AlmacenEnvases, AlmacenEnvases.AEV_Nombre, Lbnom_3)
        AsociarControles(TxDato_4, BtBusca_4, AlmacenEnvases.btBusca, AlmacenEnvases, AlmacenEnvases.AEV_Nombre, LbNom_4)
        AsociarControles(TxDato_10, BtBusca_10, Envases.btBusca, Envases, Envases.ENV_Nombre, Lbnom_10)
        AsociarControles(TxDato_15, BtBusca_15, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, Lbnom_15)

        AsociarControles(TxTransportista, BtBuscaTransportista, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomTransportista)
        BtBuscaTransportista.CL_Filtro = "TIPO='PO'"




        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me

        tt.SetToolTip(BtNuevo, "Nuevo")


    End Sub


    Private Sub FrmValeEnvaseTraspaso_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BTaux1.Visible = False

        BtAux2.Visible = True
        BtAux2.Text = "I.Directa"
        BtAux2.Image = PictureBox2.Image

    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        Dim i As Integer


        If TxDato_1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = Valeenvases_traspaso.LeerVale(CInt(LbCampa.Text), VaInt(LbCentro.Text), CInt(TxDato_1.Text))
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

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)

        Dim Importe As Decimal = VaDec(Valeenvases_traspaso_lineas.VTL_uds.Valor) * VaDec(Valeenvases_traspaso_lineas.VTL_precio.Valor)
        LbImporte.Text = "Importe: " & Importe.ToString("#,##0.00")

    End Sub
    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()
        Mi_IdCentro = Valeenvases_traspaso.VET_Idcentro.Valor
        PintaCentro(Mi_IdCentro)
        ' llenar el grid
        CargaLineasGrid()
    End Sub
    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean

        If LbId.Text = "+" Then
            LbId.Text = Valeenvases_traspaso.MaxId
            If TxDato_1.Text = "+" Then
                TxDato_1.Text = Valeenvases_traspaso.MaxIdCampa(Val(LbCampa.Text), LbCentro.Text)
            End If
        End If
        Valeenvases_traspaso.VET_Idvale.Valor = LbId.Text
        Valeenvases_traspaso.VET_Campa.Valor = LbCampa.Text
        Valeenvases_traspaso.VET_Idcentro.Valor = LbCentro.Text
        Valeenvases_traspaso_lineas.VTL_idvaletraspaso.Valor = LbId.Text
        SqlGrid()
        r = MyBase.GuardarLineas(Gr)
        Return r
    End Function
    
    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()

        Valeenvases_traspaso.CrearValeEnvasesTraspaso(LbId.Text)


        If XtraMessageBox.Show("¿Desea imprimir el vale?", "Albarán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            C1_ImprimirValeEnvasesTraspaso(LbId.Text, TipoImpresion.ImpresoraSeleccionada)
            If chkImprimirCMR.Checked Then
                C1_ImprimirDCTMC(LbId.Text, TipoDCTMC.ValeEnvasesTraspasos, TipoImpresion.ImpresoraPorDefecto)
            End If
        End If



        If ConectarFinancieroContabilidad = "S" Then

            'Contabiliza
            'Dim i As Integer = Valeenvases_traspaso.Contabiliza(LbId.Text)

            'If i > 0 Then

            '    Dim ListaAsientos As New List(Of Integer)
            '    ListaAsientos.Add(i)
            '    Dim f As New frmVisualizadorAsiento(ListaAsientos, False, "")
            '    f.ShowDialog()

            'ElseIf i = 0 Then
            '    'Si devuelve otro valor, no muestra mensaje de error
            '    MsgBox("no se generó asiento")
            'End If

        End If


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


        BtBuscaAlbaran.CL_Filtro = "IDCENTRO=" + LbCentro.Text + " AND CAMPA=" + LbCampa.Text
        BotonesAvance1.Filtro = "VET_IDCENTRO=" + LbCentro.Text + " AND VET_CAMPA=" + LbCampa.Text

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


        CONSULTA.SelCampo(Valeenvases_traspaso_lineas.VTL_Id)
        CONSULTA.SelCampo(Valeenvases_traspaso_lineas.VTL_idenvase, "Codigo")
        CONSULTA.SelCampo(Envases.ENV_Nombre, "Envase", Valeenvases_traspaso_lineas.VTL_idenvase)
        CONSULTA.SelCampo(Valeenvases_traspaso_lineas.VTL_uds, "Uds")
        CONSULTA.SelCampo(Valeenvases_traspaso_lineas.VTL_precio, "Precio")
        Dim oImporte As New Cdatos.bdcampo("@COALESCE(VTL_Uds,0) * COALESCE(VTL_Precio,0)", Cdatos.TiposCampo.Importe, 18, 2)
        CONSULTA.SelCampo(oImporte, "Importe")

        CONSULTA.WheCampo(Valeenvases_traspaso_lineas.VTL_idvaletraspaso, "=", id)
        sql = CONSULTA.SQL
        sql = sql + " order by VTL_Id"

        ClGrid1.Consulta = sql

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

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


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirValeEnvasesTraspaso(LbId.Text, TipoImpresion.ImpresoraSeleccionada)
            If chkImprimirCMR.Checked Then
                C1_ImprimirDCTMC(LbId.Text, TipoDCTMC.ValeEnvasesTraspasos, TipoImpresion.ImpresoraPorDefecto)
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

    Private Sub TxDato_6_Valida(edicion As System.Boolean) Handles TxDato_6.Valida

        If edicion Then
            If TxDato_6.Text.Trim = "" Then
                TxDato_6.Text = "TRASPASO DE " & Lbnom_3.Text & " A " & LbNom_4.Text
            End If
        End If

    End Sub
End Class