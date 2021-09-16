Imports DevExpress.XtraEditors

Public Class FrmParteExistencias
    Inherits FrMantenimiento



    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim Mi_IdCentro As Integer
    Dim ParteExistencias As New E_ParteExistencias(Idusuario, cn)
    Dim ParteExistencias_lineas As New E_ParteExistencias_lineas(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
    Dim Subfamilias As New E_Subfamilias(Idusuario, cn)





    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Envases As New E_Envases(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = ParteExistencias


        Dim lc As New List(Of Object)
        ListaControles = lc



        LbCentro.CL_ControlAsociado = TxDato_2
        LbNomCentro.CL_ControlAsociado = TxDato_2
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato_2, ParteExistencias.PSM_fechafinal, Lb_2, True)
        ParamTx(TxDato_3, ParteExistencias.PSM_fechainicial, Lb_3, True)

        ParamTx(TxDato_50, ParteExistencias_lineas.PSL_idgenero, Lb_50, True)
        ParamTx(TxDato_52, ParteExistencias_lineas.PSL_idtipoconfeccion, Lb_52, False)
        ParamTx(TxDato_51, ParteExistencias_lineas.PSL_idmarca, Lb_51, False)
        ParamTx(TxDato_53, ParteExistencias_lineas.PSL_idcategoria, Lb_53, False)

        ParamTx(TxDato_54, ParteExistencias_lineas.PSL_palets, Lb_54, False)
        ParamTx(TxDato_55, ParteExistencias_lineas.PSL_bultos, Lb_55, False)
        ParamTx(TxDato_56, ParteExistencias_lineas.PSL_kilos, Lb_56, False)
        ParamTx(TxDato_57, ParteExistencias_lineas.PSL_precio, Lb_57, False)
        ParamTx(TxDato_58, ParteExistencias_lineas.PSL_observaciones, Lb_58, False)


        AsociarGrid(ClGrid1, TxDato_50, TxDato_58, ParteExistencias_lineas)

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        PropiedadesCamposGr(ClGrid1, "PSL_idlinea", "PSL_idlinea", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Genero", "Genero", True, 50)
        PropiedadesCamposGr(ClGrid1, "Confeccion", "Confeccion", True, 30)
        PropiedadesCamposGr(ClGrid1, "Categoria", "Categoria", True, 30)
        PropiedadesCamposGr(ClGrid1, "Marca", "Marca", True, 10, False)
        PropiedadesCamposGr(ClGrid1, "Kilos", "Kilos", True, 10, True, "#,##0", "{0:n0}")
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 10, False)
        PropiedadesCamposGr(ClGrid1, "Importe", "Importe", True, 12, True, "#,##0.00", "{0:n2}")


        AsociarControles(TxDato_2, BtBuscaAlbaran, ParteExistencias.btBusca, EntidadFrm)



        AsociarControles(TxDato_52, BtBusca_52, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb_nom52)
        BtBusca_52.CL_Filtro = "TIPO='P'"
        AsociarControles(TxDato_51, BtBusca_51, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, Lbnom_51)
        AsociarControles(TxDato_50, BtBusca_50, Generos.btBusca, Generos, Generos.GEN_NombreGenero, Lbnom_50)
        AsociarControles(TxDato_52, BtBusca_52, GenerosSalida.btBusca, ConfecEnvase, ConfecEnvase.CEV_Nombre, Lb_nom52)
        AsociarControles(TxDato_53, BtBusca_53, CategoriasSalida.BtBuscaFamilias, CategoriasSalida, CategoriasSalida.CAS_CategoriaCalibre, Lbnom_53)



        FiltroEntidad.Add(ParteExistencias.PSM_idcentro.NombreCampo, MiMaletin.IdCentro.ToString)
        FiltroEntidad.Add(ParteExistencias.PSM_campa.NombreCampo, MiMaletin.Ejercicio.ToString)

        AñadeResumenCampo(ClGrid1.GridView, "Importe", "{0:n2}")


    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        Dim i As Integer

        i = ParteExistencias.LeerParte(CInt(LbCampa.Text), VaInt(LbCentro.Text), TxDato_2.Text)
        If i > 0 Then
            LbId.Text = i.ToString
        Else
            LbId.Text = "+" 'AlbEntrada.MaxId

        End If

        CargaLineasGrid()

    End Sub
    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)

    End Sub
    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()
        Mi_IdCentro = ParteExistencias.PSM_idcentro.Valor
        LbCampa.Text = ParteExistencias.PSM_campa.Valor
        PintaCentro(Mi_IdCentro)

        ' llenar el grid
        CargaLineasGrid()
        '  LbtotAlb.Text = Format(TotalAlbaran, "#,###0.00")

    End Sub
    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean

        If LbId.Text = "+" Then
            LbId.Text = ParteExistencias.MaxId
        End If
        ParteExistencias.PSM_idparte.Valor = LbId.Text
        ParteExistencias.PSM_campa.Valor = LbCampa.Text
        ParteExistencias.PSM_idcentro.Valor = LbCentro.Text


        ParteExistencias_lineas.PSL_idparte.Valor = LbId.Text
        SqlGrid()
        r = MyBase.GuardarLineas(Gr)
        Return r
    End Function

    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()



        'If NuevoRegistro Then
        '    ImprimirDocumento(False)
        'Else
        '    If XtraMessageBox.Show("¿Desea imprimir el Documento?", "CMR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '        ImprimirDocumento(False)
        '    End If
        'End If

    End Sub
    Public Overrides Sub DespuesdeGuardarLinea(ByVal gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)

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

    Public Overrides Sub DespuesdeCargarLineas(ByVal gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)
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


        CONSULTA.SelCampo(ParteExistencias_lineas.PSL_idlinea, "PSL_idlinea")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero", ParteExistencias_lineas.PSL_idgenero)
        CONSULTA.SelCampo(ConfecEnvase.CEV_Nombre, "Confeccion", ParteExistencias_lineas.PSL_idtipoconfeccion)
        CONSULTA.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", ParteExistencias_lineas.PSL_idcategoria)
        CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", ParteExistencias_lineas.PSL_idmarca)
        CONSULTA.SelCampo(ParteExistencias_lineas.PSL_palets, "Palets")
        CONSULTA.SelCampo(ParteExistencias_lineas.PSL_bultos, "Bultos")
        CONSULTA.SelCampo(ParteExistencias_lineas.PSL_kilos, "Kilos")
        CONSULTA.SelCampo(ParteExistencias_lineas.PSL_precio, "Precio")
        Dim oImporte As New Cdatos.bdcampo("@PSL_Kilos * PSL_Precio", Cdatos.TiposCampo.Importe, 18, 2)
        CONSULTA.SelCampo(oImporte, "Importe")


        CONSULTA.WheCampo(ParteExistencias_lineas.PSL_idparte, "=", id)
        sql = CONSULTA.SQL
        sql = sql + " order by parteexistencias_lineas.psl_idlinea"

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



    Private Sub TxDato2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_56.TextChanged

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


    Private Sub TxDato_50_Valida(edicion As Boolean) Handles TxDato_50.Valida
        BtBusca_52.CL_Filtro = "idgenero=" + TxDato_50.Text
        If Generos.LeerId(TxDato_50.Text) = True Then
            If Subfamilias.LeerId(Generos.GEN_IdsubFamilia.Valor) = True Then
                BtBusca_53.CL_Filtro = "Idfamilia=" + Subfamilias.SFA_idfamilia.Valor
            End If
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaInt(LbId.Text) > 0 Then

            Dim Listado As New Listado_IntroduccionExistencias(LbId.Text, TxDato_2.Text, TxDato_3.Text, TipoImpresion.Preliminar)
            Listado.ImprimirListado()

        End If

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaInt(LbId.Text) > 0 Then

            Dim Listado As New Listado_IntroduccionExistencias(LbId.Text, TxDato_2.Text, TxDato_3.Text, TipoImpresion.ImpresoraPorDefecto)
            Listado.ImprimirListado()

        End If


    End Sub

End Class

