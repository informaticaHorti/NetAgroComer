Imports DevExpress.XtraEditors

Public Class FrmTarifasMaterial
    Inherits FrMantenimiento



    Dim tarifasmaterial As New E_TarifasMaterial(Idusuario, cn)
    Dim tarifasmateriallineas As New E_TarifasMaterialLineas(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim marcas As New E_Marcas(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)




    Private Sub ParametrosFrm()
        EntidadFrm = tarifasmaterial


        Dim lc As New List(Of Object)
        ListaControles = lc


        ParamTx(TxDato_3, tarifasmaterial.TMA_idacreedor, Lb_3, True)

        TxDato_3.Autonumerico = False
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato_2, tarifasmaterial.TMA_fechatarifa, Lb_2, True)


        ParamTx(TxDato_10, tarifasmateriallineas.TML_idmaterial, Lb_10, True)
        ParamTx(TxDato_15, tarifasmateriallineas.tml_idmarca, Lb_15, False)

        ParamTx(TxDato_11, tarifasmateriallineas.TML_precio, Lb_11, False)
        ParamTx(TxDato_12, tarifasmateriallineas.TML_descuento, Lb_12, False)
        ParamTx(TxDato_13, tarifasmateriallineas.TML_referencia, Lb_13, False)



        AsociarGrid(ClGrid1, TxDato_10, TxDato_13, tarifasmateriallineas)

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        PropiedadesCamposGr(ClGrid1, "TML_idlinea", "TML_idlinea", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 10)
        PropiedadesCamposGr(ClGrid1, "Material", "Material", True, 50)
        PropiedadesCamposGr(ClGrid1, "Marca", "Marca", True, 40)
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 10, False, "#0.000000")
        PropiedadesCamposGr(ClGrid1, "Dto", "Dto", True, 10, False, "#0.00")


        AsociarControles(TxDato_3, BtBusca_3, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, Lbnom_3)
        BtBusca_3.CL_Filtro = "TIPO='MA'"

        AsociarControles(TxDato_10, BtBusca_10, Envases.btBusca, Envases, Envases.ENV_Nombre, Lbnom_10)
        AsociarControles(TxDato_15, BtBusca_15, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, Lbnom_15)




    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
      
        LbId.Text = TxDato_3.Text



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
        tarifasmateriallineas.TML_idacreedor.Valor = LbId.Text
        SqlGrid()
        r = MyBase.GuardarLineas(Gr)
        Return r
    End Function

    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()

        'If NuevoRegistro Then
        '    '          ImprimirAlbaranMedianero(LbId.Text, False, Not NuevoRegistro)
        'Else
        '    If XtraMessageBox.Show("¿Desea imprimir el albarán?", "Albarán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '        '             ImprimirAlbaranMedianero(LbId.Text, False, Not NuevoRegistro)
        '    End If
        'End If

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

        If LbId.Text = "+" Then
            id = "-1"
        Else
            id = LbId.Text
        End If
        Dim sql As String
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim CONSULTA As New Cdatos.E_select


        CONSULTA.SelCampo(tarifasmateriallineas.TML_idlinea, "TML_idlinea")
        CONSULTA.SelCampo(tarifasmateriallineas.TML_idmaterial, "Codigo")
        CONSULTA.SelCampo(Envases.ENV_Nombre, "Material", tarifasmateriallineas.TML_idmaterial)
        CONSULTA.SelCampo(marcas.MAR_Nombre, "Marca", tarifasmateriallineas.TML_idmarca)
        CONSULTA.SelCampo(tarifasmateriallineas.TML_precio, "Precio")
        CONSULTA.SelCampo(tarifasmateriallineas.TML_descuento, "Dto")
        CONSULTA.SelCampo(tarifasmateriallineas.TML_referencia, "Referencia")

        CONSULTA.WheCampo(tarifasmateriallineas.TML_idacreedor, "=", id)
        sql = CONSULTA.SQL
        sql = sql + " order by TML_idlinea"

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


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        'Preliminar

        If VaInt(LbId.Text) > 0 Then
            Dim Listado As New Listado_Tarifas_Materiales(TxDato_3.Text, Lbnom_3.Text, TxDato_2.Text, TipoImpresion.Preliminar)
            Listado.ImprimirListado()
        End If


    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        'Imp. Directa
        If VaInt(LbId.Text) > 0 Then
            Dim Listado As New Listado_Tarifas_Materiales(TxDato_3.Text, Lbnom_3.Text, TxDato_2.Text, TipoImpresion.ImpresoraPorDefecto)
            Listado.ImprimirListado()
        End If

    End Sub
   
End Class