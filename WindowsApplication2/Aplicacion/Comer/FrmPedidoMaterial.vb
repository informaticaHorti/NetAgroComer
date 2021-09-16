Imports DevExpress.XtraEditors

Public Class FrmPedidoMaterial
    Inherits FrMantenimiento


    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim Mi_IdCentro As Integer
    Dim TipoVale As String
    Dim TipoSujeto As String
    Dim PedidosMaterial As New E_PedidosMaterial(Idusuario, cn)
    Dim PedidosMaterialLineas As New E_PedidosMaterialLineas(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim TarifaMaterialLineas As New E_TarifasMaterialLineas(Idusuario, cn)

    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Envases As New E_Envases(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = PedidosMaterial


        Dim lc As New List(Of Object)
        ListaControles = lc



        ParamTx(TxDato_1, PedidosMaterial.PMA_Numero, Lb1, True)
        TxDato_1.Autonumerico = True
        LbCentro.CL_ControlAsociado = TxDato_1
        LbNomCentro.CL_ControlAsociado = TxDato_1
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato_2, PedidosMaterial.PMA_Fecha, Lb_2, True)
        ParamTx(TxDato_3, PedidosMaterial.PMA_Idacreedor, Lb_3, True)
        ParamTx(TxDato_7, PedidosMaterial.PMA_referencia, Lb_7, False)
        ParamTx(TxDato_6, PedidosMaterial.PMA_observaciones, Lb_5, False)


        ParamTx(TxDato_10, PedidosMaterialLineas.PML_idmaterial, Lb_10, True)
        ParamTx(TxDato_15, PedidosMaterialLineas.PML_idmarca, Lb_15, False)

        ParamTx(TxDato_11, PedidosMaterialLineas.PML_cantidad, Lb_11, True)
        ParamTx(TxDato_12, PedidosMaterialLineas.PML_precio, Lb_12, False)
        ParamTx(TxDato_13, PedidosMaterialLineas.PML_descuento, Lb_13, False)
        ParamTx(TxDato_14, PedidosMaterialLineas.PML_referencia, Lb_14, False)
        ParamTx(TxDato_16, PedidosMaterialLineas.PML_finalizado, Lb_16, False, , , , "SN")



        AsociarGrid(ClGrid1, TxDato_10, TxDato_16, PedidosMaterialLineas)

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        PropiedadesCamposGr(ClGrid1, "PML_Idlinea", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 10)
        PropiedadesCamposGr(ClGrid1, "Material", "Material", True, 50)
        PropiedadesCamposGr(ClGrid1, "Marca", "Marca", True, 40)
        PropiedadesCamposGr(ClGrid1, "Cantidad", "Cantidad", True, 10, False, "#0.0000")
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 10, False, "#0.000000")
        PropiedadesCamposGr(ClGrid1, "Dto", "Dto", True, 10, False, "#0.00")


        AsociarControles(TxDato_1, BtBuscaPedido, PedidosMaterial.btBusca, EntidadFrm)


        AsociarControles(TxDato_3, BtBusca_3, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, Lbnom_3)
        BtBusca_3.CL_Filtro = "TIPO='MA'"
        AsociarControles(TxDato_10, BtBusca_10, Envases.btBusca, Envases, Envases.ENV_Nombre, Lbnom_10)
        AsociarControles(TxDato_15, BtBusca_15, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, Lbnom_15)


        tt.SetToolTip(BtNuevo, "Nuevo")
        FiltroEntidad.Add(PedidosMaterial.PMA_Idcentro.NombreCampo, MiMaletin.IdCentro.ToString)
        FiltroEntidad.Add(PedidosMaterial.PMA_Campa.NombreCampo, MiMaletin.Ejercicio.ToString)



    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        Dim i As Integer


        If TxDato_1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = PedidosMaterial.LeerPedido(CInt(LbCampa.Text), VaInt(LbCentro.Text), CInt(TxDato_1.Text))
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

    End Sub
    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()
        Mi_IdCentro = PedidosMaterial.PMA_Idcentro.Valor
        LbCampa.Text = PedidosMaterial.PMA_Campa.Valor
        PintaCentro(Mi_IdCentro)

        ' llenar el grid
        CargaLineasGrid()
    End Sub
    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean

        If LbId.Text = "+" Then
            LbId.Text = PedidosMaterial.MaxId
            If TxDato_1.Text = "+" Then
                TxDato_1.Text = PedidosMaterial.MaxIdCampa(Val(LbCampa.Text), LbCentro.Text)
            End If
        End If
        PedidosMaterial.PMA_Idpedido.Valor = LbId.Text
        PedidosMaterial.PMA_Campa.Valor = LbCampa.Text
        PedidosMaterial.PMA_Idcentro.Valor = LbCentro.Text
        PedidosMaterialLineas.PML_idpedido.Valor = LbId.Text
        SqlGrid()
        r = MyBase.GuardarLineas(Gr)
        Return r
    End Function

    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()


        If VaInt(LbId.Text) > 0 Then
            If XtraMessageBox.Show("¿Desea imprimir el pedido?", "Albarán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                C1_ImprimirPedidosMaterial(LbId.Text, TipoImpresion.ImpresoraPorDefecto)
            End If
        End If

    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbCampa.Text = MiMaletin.Ejercicio.ToString
        Mi_IdCentro = MiMaletin.IdCentro
        PintaCentro(Mi_IdCentro)

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


        CONSULTA.SelCampo(PedidosMaterialLineas.PML_idlinea, "PML_idlinea")
        CONSULTA.SelCampo(PedidosMaterialLineas.PML_idmaterial, "Codigo")
        CONSULTA.SelCampo(Envases.ENV_Nombre, "Material", PedidosMaterialLineas.PML_idmaterial)
        CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", PedidosMaterialLineas.PML_idmarca)
        CONSULTA.SelCampo(PedidosMaterialLineas.PML_cantidad, "Cantidad")
        CONSULTA.SelCampo(PedidosMaterialLineas.PML_precio, "Precio")
        CONSULTA.SelCampo(PedidosMaterialLineas.PML_descuento, "Dto")
        CONSULTA.SelCampo(PedidosMaterialLineas.PML_referencia, "Referencia")
        CONSULTA.SelCampo(PedidosMaterialLineas.PML_finalizado, "Fin")

        CONSULTA.WheCampo(PedidosMaterialLineas.PML_idpedido, "=", id)
        sql = CONSULTA.SQL
        sql = sql + " order by pml_idlinea"

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




    Private Sub PrecioTarifa()
        Dim sql As String = ""
        Dim sql1 As String = ""
        Dim Precio As String = "*"
        Dim Dto As String = ""
        Dim Ref As String = ""

        sql1 = "Select TML_precio as precio,TML_descuento as descuento,TML_referencia as referencia "
        sql1 = sql1 + " from tarifasmateriallineas where TML_idmaterial=" + TxDato_10.Text
        sql1 = sql1 + " AND TML_idacreedor=" + TxDato_3.Text
        If VaInt(TxDato_15.Text) > 0 Then
            sql = sql1 + " and TML_idmarca=" + TxDato_15.Text
        Else
            sql = sql1
        End If
        Dim dt As DataTable = TarifaMaterialLineas.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                Precio = dt.Rows(0)("precio").ToString
                Dto = dt.Rows(0)("descuento").ToString
                Ref = dt.Rows(0)("referencia").ToString
            End If
        End If
        If Precio = "*" Then
            sql = sql1 + " and TML_idmarca=0"
            dt = TarifaMaterialLineas.MiConexion.ConsultaSQL(sql) ' sin marca
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    Precio = dt.Rows(0)("precio").ToString
                    Dto = dt.Rows(0)("descuento").ToString
                    Ref = dt.Rows(0)("referencia").ToString
                End If
            End If

        End If
        If Precio <> "*" Then
            TxDato_12.Text = Precio
            TxDato_13.Text = Dto
            TxDato_14.Text = Ref
        End If
    End Sub
   
   
    Private Sub TxDato_16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_16.TextChanged

    End Sub

    Private Sub TxDato_16_Valida(ByVal edicion As Boolean) Handles TxDato_16.Valida
        If TxDato_16.Text <> "S" Then
            TxDato_16.Text = "N"
        End If
    End Sub

    Private Sub TxDato_15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_15.TextChanged

    End Sub

    Private Sub TxDato_15_Valida(ByVal edicion As Boolean) Handles TxDato_15.Valida
        If edicion = True Then
            PrecioTarifa()
        End If
    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirPedidosMaterial(LbId.Text, TipoImpresion.Preliminar)
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirPedidosMaterial(LbId.Text, TipoImpresion.ImpresoraPorDefecto)
        End If

    End Sub

    Private Sub FrmPedidosMaterial_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BTaux1.Visible = True
        BTaux1.Text = "Imprimir"
        BTaux1.Image = PictureBox1.Image

        BtAux2.Visible = True
        BtAux2.Text = "I.Directa"
        BtAux2.Image = PictureBox2.Image

    End Sub

End Class