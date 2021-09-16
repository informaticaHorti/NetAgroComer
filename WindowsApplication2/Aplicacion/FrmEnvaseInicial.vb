Imports DevExpress.XtraEditors

Public Class FrmEnvaseInicial





    Inherits FrMantenimiento

    Dim Envasesinicial As New E_envasesInicial(Idusuario, cn)
    Dim TipoIni As String

    Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)

    Dim Marcas As New E_Marcas(Idusuario, cn)

    Dim Envases As New E_Envases(Idusuario, cn)


    Private Sub ParametrosFrm()



        Dim lc As New List(Of Object)
        ListaControles = lc



        CampoClave = 0 ' ultimo campo de la clave


        ParamTx(TxDato_13, Envasesinicial.ENI_codigo, Lb_13, True)

        ParamTx(TxDato_10, Envasesinicial.ENI_idenvase, Lb_10, True)
        ParamTx(TxDato_15, Envasesinicial.ENI_idmarca, Lb_15, False)

        ParamTx(TxDato_11, Envasesinicial.ENI_inicial, Lb_11, False)
        ParamTx(TxDato_12, Envasesinicial.ENI_precio, Lb_12, False)



        AsociarGrid(ClGrid1, TxDato_10, TxDato_12, Envasesinicial)

        'ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        PropiedadesCamposGr(ClGrid1, "ENI_id", "ENI_id", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 10)
        PropiedadesCamposGr(ClGrid1, "Envase", "Envase", True, 40)
        PropiedadesCamposGr(ClGrid1, "Marca", "Marca", True, 30)
        PropiedadesCamposGr(ClGrid1, "Uds", "Uds", True, 10, True, "#0")
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 25, False, "#0.000000000")
        PropiedadesCamposGr(ClGrid1, "Importe", "Importe", True, 25, True, "#,###0.00")

        AsociarControles(TxDato_10, BtBusca_10, Envases.btBusca, Envases, Envases.ENV_Nombre, Lbnom_10)
        AsociarControles(TxDato_15, BtBusca_15, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, Lbnom_15)

        EntidadFrm = Clientes
        TipoIni = "CL"
        AsociarControles(TxDato_13, BtBusca_13, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lbnom_13)

        BAnular.Visible = False





    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave

        LbId.Text = TxDato_13.Text
        CargaLineasGrid()

    End Sub
    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)

    End Sub
    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()
        ' llenar el grid
        CargaLineasGrid()
    End Sub
    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean



        Envasesinicial.ENI_campa.Valor = MiMaletin.Ejercicio.ToString
        Envasesinicial.ENI_tipo.Valor = TipoIni
        Envasesinicial.ENI_codigo.Valor = LbId.Text
        SqlGrid()
        r = MyBase.GuardarLineas(Gr)
        Return r
    End Function

    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()
        If NuevoRegistro Then
            '          ImprimirAlbaranMedianero(LbId.Text, False, Not NuevoRegistro)
        Else
            'If XtraMessageBox.Show("¿Desea imprimir el albarán?", "Albarán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            '    '             ImprimirAlbaranMedianero(LbId.Text, False, Not NuevoRegistro)
            'End If
        End If

    End Sub
    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)
    End Sub
    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
    End Sub
    Private Sub CargaLineasGrid()
        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)
    End Sub


    Private Sub SqlGrid()
        Dim id As String

        id = LbId.Text
        Dim sql As String
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim CONSULTA As New Cdatos.E_select



        CONSULTA.SelCampo(Envasesinicial.ENI_id, "ENI_id")
        CONSULTA.SelCampo(Envasesinicial.ENI_idenvase, "Codigo")
        CONSULTA.SelCampo(Envases.ENV_Nombre, "Envase", Envasesinicial.ENI_idenvase)
        CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", Envasesinicial.ENI_idmarca)
        CONSULTA.SelCampo(Envasesinicial.ENI_inicial, "Uds")
        CONSULTA.SelCampo(Envasesinicial.ENI_precio, "Precio")
        Dim importe As New Cdatos.bdcampo("@ENI_INICIAL*ENI_PRECIO", Cdatos.TiposCampo.Importe, 15, 2)
        CONSULTA.SelCampo(importe, "Importe")
        CONSULTA.WheCampo(Envasesinicial.ENI_tipo, "=", TipoIni)
        CONSULTA.WheCampo(Envasesinicial.ENI_campa, "=", MiMaletin.Ejercicio.ToString)
        CONSULTA.WheCampo(Envasesinicial.ENI_codigo, "=", LbId.Text)
        sql = CONSULTA.SQL
        sql = sql + " order by eni_idenvase"

        ClGrid1.Consulta = sql

    End Sub


    Public Overrides Sub DespuesdeCargarLineas(gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)
        Funciones.AñadeResumenCampo(gr.GridView, "Importe", "{0:n2}")

    End Sub
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()



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





    Public Overrides Sub Guardar()


        MyBase.Guardar()

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        '        ImprimirAlbaranMedianero(LbId.Text, False, True)
    End Sub


    Private Sub RbAgricultores_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbAgricultores.CheckedChanged
        CambiaIni()
    End Sub

    Private Sub RbClientes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbClientes.CheckedChanged
        CambiaIni()
    End Sub

    Private Sub RbAlmacenes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbAlmacenes.CheckedChanged
        CambiaIni()
    End Sub
    Private Sub CambiaIni()
        If TipoIni Is Nothing Then Exit Sub
        If RbClientes.Checked = True Then
            EntidadFrm = Clientes
            TipoIni = "CL"
            AsociarControles(TxDato_13, BtBusca_13, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lbnom_13)
        ElseIf RbAgricultores.Checked = True Then
            EntidadFrm = Agricultores
            TipoIni = "AG"
            AsociarControles(TxDato_13, BtBusca_13, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lbnom_13)
        ElseIf RbAlmacenes.Checked = True Then
            EntidadFrm = AlmacenEnvases
            TipoIni = "AL"
            AsociarControles(TxDato_13, BtBusca_13, AlmacenEnvases.btBusca, AlmacenEnvases, AlmacenEnvases.AEV_Nombre, Lbnom_13)

        End If
        BorraPan()
    End Sub
End Class