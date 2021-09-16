Imports DevExpress.XtraEditors

Public Class FrmDevEnvase
    Inherits FrMantenimiento


    Dim DevEnvases As New E_DevEnvases(Idusuario, cn)
    Dim DevEnvases_lineas As New E_DevEnvases_Lineas(Idusuario, cn)
    Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Valeenvases As New E_ValeEnvases(Idusuario, cn)
    Dim ConceptosEnvases As New E_ConceptosEnvases(Idusuario, cn)



    Dim Mi_IdCentro As Integer


    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Envases As New E_Envases(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = DevEnvases


        Dim lc As New List(Of Object)
        ListaControles = lc



        ParamTx(TxDato_1, DevEnvases.DEV_Numero, Lb1, True)
        TxDato_1.Autonumerico = True
        LbCentro.CL_ControlAsociado = TxDato_1
        LbNomCentro.CL_ControlAsociado = TxDato_1
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato_2, DevEnvases.DEV_Fecha, Lb_2, True)
        ParamTx(TxDato_3, DevEnvases.DEV_Idcliente, Lb_3, True)
        ParamTx(TxDato_4, DevEnvases.DEV_IdAlmacen, Lb_4, True)
        ParamTx(TxDato_6, DevEnvases.DEV_Referencia, Lb_5, False)
        ParamTx(TxDato_7, DevEnvases.DEV_IdConcepto, Lb7, False)
        ParamTx(TxDato_8, DevEnvases.DEV_Concepto, Nothing, False)
        ParamTx(TxDato_10, DevEnvases_lineas.DEL_idenvase, Lb_10, True)
        ParamTx(TxDato_11, DevEnvases_lineas.DEL_cantidad, Lb_11, False)




        AsociarGrid(ClGrid1, TxDato_10, TxDato_11, DevEnvases_lineas)

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        PropiedadesCamposGr(ClGrid1, "DEL_id", "DEL_Id", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 10)
        PropiedadesCamposGr(ClGrid1, "Envase", "Envase", True, 50)
        PropiedadesCamposGr(ClGrid1, "Cantidad", "Cantidad", True, 10, True, "#0")


        AsociarControles(TxDato_1, BtBuscaAlbaran, DevEnvases.btBusca, EntidadFrm)


        AsociarControles(TxDato_3, BtBusca_3, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lbnom_3)
        AsociarControles(TxDato_4, BtBusca_4, AlmacenEnvases.btBusca, AlmacenEnvases, AlmacenEnvases.AEV_Nombre, LbNom_4)
        AsociarControles(TxDato_7, BtBusca_7, ConceptosEnvases.btBusca, ConceptosEnvases)
        AsociarControles(TxDato_10, BtBusca_10, Envases.btBusca, Envases, Envases.ENV_Nombre, Lbnom_10)




       

        tt.SetToolTip(BtNuevo, "Nuevo")


    End Sub


    Private Sub FrmDevEnvase_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BTaux1.Visible = True
        BTaux1.Text = "Imprimir"
        BTaux1.Image = PictureBox1.Image

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
            i = DevEnvases.LeerVale(CInt(LbCampa.Text), VaInt(LbCentro.Text), CInt(TxDato_1.Text))
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
        LlenagridPrecios()

    End Sub
    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()
        Mi_IdCentro = DevEnvases.DEV_Idcentro.Valor
        PintaCentro(Mi_IdCentro)
        ' llenar el grid
        CargaLineasGrid()
    End Sub
    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean

        If LbId.Text = "+" Then
            LbId.Text = DevEnvases.MaxId
            If TxDato_1.Text = "+" Then
                TxDato_1.Text = DevEnvases.MaxIdCampa(Val(LbCampa.Text), LbCentro.Text)
            End If
        End If
        DevEnvases.DEV_Idvale.Valor = LbId.Text
        DevEnvases.DEV_Campa.Valor = LbCampa.Text
        DevEnvases.DEV_Idcentro.Valor = LbCentro.Text
        DevEnvases_lineas.DEL_idvale.Valor = LbId.Text
        SqlGrid()
        r = MyBase.GuardarLineas(Gr)
        Return r
    End Function

    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()

        DevEnvases.CrearValeEnvasesDevolucion(LbId.Text)


        Dim IdVale As String = DevEnvases.DEV_idvaleenvase.Valor
        If NuevoRegistro Then
            If VaInt(IdVale) > 0 Then
                C1_ImprimirValeEnvases(IdVale, TipoImpresion.ImpresoraPorDefecto)
            End If
        Else
            If XtraMessageBox.Show("¿Desea imprimir el vale?", "Imprimir vale", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If VaInt(IdVale) > 0 Then
                    C1_ImprimirValeEnvases(IdVale, TipoImpresion.ImpresoraPorDefecto)
                End If
            End If
        End If

    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)
        Grid2.DataSource = Nothing
    End Sub
    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
        LbCampa.Text = MiMaletin.Ejercicio.ToString
        Mi_IdCentro = MiMaletin.IdCentro
        PintaCentro(Mi_IdCentro)


        BtBuscaAlbaran.CL_Filtro = "IDCENTRO=" + LbCentro.Text + " AND CAMPA=" + LbCampa.Text

    End Sub
    Private Sub CargaLineasGrid()
        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)
    End Sub

    Private Sub LlenagridPrecios()
        If TxDato_3.Text <> "" And TxDato_10.Text <> "" And TxDato_2.Text <> "" Then
            Dim dt As DataTable = AGRO_DevolucionClientes(TxDato_3.Text, TxDato_10.Text, TxDato_2.Text, 0)
            Grid2.DataSource = dt
            GridView2.Columns("Devolucion").Visible = False
            GridView2.BestFitColumns()
            GridView2.OptionsView.ShowGroupPanel = False
            GridView2.OptionsBehavior.Editable = False

        End If
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


        CONSULTA.SelCampo(DevEnvases_lineas.DEL_id, "DEL_id")
        CONSULTA.SelCampo(DevEnvases_lineas.DEL_idenvase, "Codigo")
        CONSULTA.SelCampo(Envases.ENV_Nombre, "Envase", DevEnvases_lineas.DEL_idenvase)
        CONSULTA.SelCampo(DevEnvases_lineas.DEL_cantidad, "Cantidad")
 
        CONSULTA.WheCampo(DevEnvases_lineas.DEL_idvale, "=", id)
        sql = CONSULTA.SQL
        sql = sql + " order by DEL_ID"

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
        '
        If Valeenvases.LeerId(DevEnvases.DEV_idvaleenvase.Valor) = True Then
            If VaInt(Valeenvases.VEV_idfactura.Valor) > 0 Then
                MsgBox("Vale de envases facturado. No se puede modificar")
                Exit Sub
                'Else
                '    Valeenvases.Eliminar()
                '    If DevEnvases.LeerId(LbId.Text) = True Then
                '        DevEnvases.DEV_idvaleenvase.Valor = ""
                '        DevEnvases.Actualizar()
                '    End If

            End If
        End If

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


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaInt(LbId.Text) > 0 Then
            Dim IdVale As String = DevEnvases.DEV_idvaleenvase.Valor
            If VaInt(IdVale) > 0 Then
                C1_ImprimirValeEnvases(IdVale, TipoImpresion.Preliminar)
            End If
        End If


    End Sub

    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaInt(LbId.Text) > 0 Then
            Dim IdVale As String = DevEnvases.DEV_idvaleenvase.Valor
            If VaInt(IdVale) > 0 Then
                C1_ImprimirValeEnvases(IdVale, TipoImpresion.ImpresoraPorDefecto)
            End If
        End If

    End Sub




    Private Sub TxDato_10_Valida(ByVal edicion As Boolean) Handles TxDato_10.Valida
        If edicion = True Then
            LlenagridPrecios()
        End If

    End Sub

    
    Private Sub TxDato_7_Valida(edicion As System.Boolean) Handles TxDato_7.Valida

        If edicion Then

            If TxDato_8.Text.Trim = "" Then

                If ConceptosEnvases.LeerId(TxDato_7.Text) Then
                    TxDato_8.Text = ConceptosEnvases.COE_Nombre.Valor
                End If

            End If

        End If

    End Sub
End Class