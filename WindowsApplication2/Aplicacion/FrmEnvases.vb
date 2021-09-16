Public Class FrmEnvases
    Inherits FrMantenimiento


    Dim Envases As New E_Envases(Idusuario, cn)
    Dim famEnvases As New E_FamiliaEnvases(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Envasespalets As New E_EnvasesPalets(Idusuario, cn)
    Dim SubfamiliaEnvases As New E_SubFamiliaEnvases(Idusuario, cn)
    Dim Medidaspalet As New E_MedidasPalet(Idusuario, cn)
    Dim TipoMaterial As New E_TipoMaterial(Idusuario, cn)
    Dim Umedida As New E_Umedida(Idusuario, cn)
    Dim Cuentas As New E_Cuentas(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim Acreedores As New E_Acreedores(Idusuario, cn)



    Private Sub ParametrosFrm()
        EntidadFrm = Envases


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Envases.ENV_IdEnvase, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave

        ParamCb_Copia(CbTipoEnv, Envases.ENV_Tipo, Lb16, Combos.ComboTipoenvase)
        ParamTx(TxDato2, Envases.ENV_Nombre, Lb2)

        ParamTx(TxDato3, Envases.ENV_Abreviatura, Lb3)
        ParamTx(TxDato4, Envases.ENV_IdfamiliaEnvase, Lb4)
        ParamTx(TxDato18, Envases.ENV_idsubfamilia, Lb26)
        ParamTx(TxDato19, Envases.ENV_idtipomaterial, Lb28, True)
        ParamTx(TxDato20, Envases.ENV_Udmedida, Lb30, True)

        ParamChk(ChRetornable, Envases.ENV_Retornable, "S", "N")
        ParamChk(ChkStockMarca, Envases.ENV_StockMarca, "S", "N")
        ParamChk(ChkInventariable, Envases.ENV_Inventariable, "S", "N")


        ParamTx(TxDato8, Envases.ENV_StockMinimo, Lb8)

        ParamCb_Copia(CbTipoIva, Envases.ENV_IdTipoiva, Lb9, Combos.ComboIvaEnv)


        ParamTx(TxDato9, Envases.ENV_TaraEntrada, Lb11)
        ParamTx(TxDato10, Envases.ENV_TaraSalida, Lb12)

        ParamTx(TxDato14, Envases.ENV_idmedida, Lb20)


        ParamTx(TxDato15, Envasespalets.ENP_idmedidapalet, Lb22)
        ParamTx(TxDato16, Envasespalets.ENP_cajasfila, Lb23)
        ParamTx(TxDato17, Envasespalets.ENP_maxfilas, Lb24)

        ParamTx(TxDato11, Envases.ENV_largo, Lb15, , Cdatos.TiposCampo.Importe)
        ParamTx(TxDato12, Envases.ENV_ancho, Lb17, , Cdatos.TiposCampo.Importe)
        ParamTx(TxDato13, Envases.ENV_alto, Lb18, , Cdatos.TiposCampo.Importe)

        ParamTx(TxIdAcreedor, Envases.ENV_IdAcreedorFianza, LbAcreedor)
        ParamTx(TxCdFianza, Envases.ENV_CodigoFianza, LbcdFianza)
        ParamTx(TxPrecioFianza, Envases.ENV_PrecioFianza, LbPrecioFianza)


        ParamTx(TxCtaDevolucionFianzas, Envases.ENV_CtaDevFianzas, Lb33)
        ParamTx(TxDato5, Envases.ENV_CosteSalida, Lb5)
        ParamTx(TxDato6, Envases.ENV_PrecioVenta, Lb6)
        ParamTx(TxDato7, Envases.ENV_PrecioAbono, Lb7)


        AsociarGrid(ClGrid1, TxDato15, TxDato17, Envasespalets)


        PropiedadesCamposGr(ClGrid1, Envasespalets.ENP_id.NombreCampo, "ENP_id", False, 0)
        PropiedadesCamposGr(ClGrid1, "Medidas", "Medidas", True, 50)
        PropiedadesCamposGr(ClGrid1, "CajasFila", "CajasFila", True, 20)
        PropiedadesCamposGr(ClGrid1, "MaxFilas", "MaxFilas", True, 20)
        PropiedadesCamposGr(ClGrid1, "CajasPalet", "CajasPalet", True, 20)


        AsociarControles(TxDato1, BtBuscaEnvase, Envases.btBusca, EntidadFrm)
        AsociarControles(TxDato4, BtBuscaFamEnvase, famEnvases.btBusca, famEnvases, famEnvases.FEV_Nombre, Lb10)
        AsociarControles(TxDato18, BtBusca3, SubfamiliaEnvases.btBusca, SubfamiliaEnvases, SubfamiliaEnvases.SFE_Nombre, Lb25)
        AsociarControles(TxDato19, BtBusca4, TipoMaterial.btBusca, TipoMaterial, TipoMaterial.TMT_Nombre, Lb27)
        AsociarControles(TxDato14, BtBusca1, Medidaspalet.btBusca, Medidaspalet, Medidaspalet.PLM_Medidas, Lb19)
        AsociarControles(TxDato15, BtBusca2, Medidaspalet.btBusca, Medidaspalet, Medidaspalet.PLM_Medidas, Lb21)
        AsociarControles(TxDato20, BtBusca5, Umedida.btBusca, Umedida, Umedida.UME_Nombre, Lb29)

        AsociarControles(TxCtaDevolucionFianzas, BtBusca12, Cuentas.btBusca, Cuentas, Cuentas.Nombre, LbNomCtaDevolucionFianzas)

        AsociarControles(TxIdAcreedor, BtAcreedor, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomAcreedor)
        BtAcreedor.CL_Filtro = "TIPO='MA'"


    End Sub


    Private Sub FrmEnvases_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        ChkEnvaseRevisado.Enabled = True
        chkObsoleto.Enabled = True

    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text
    End Sub


    Public Overrides Sub Guardar()

        If ChkEnvaseRevisado.Checked Then
            Envases.ENV_EnvaseRevisado.Valor = "1"
        Else
            Envases.ENV_EnvaseRevisado.Valor = "0"
        End If

        If chkObsoleto.Checked Then
            Envases.ENV_EnvaseObsoleto.Valor = "S"
        Else
            Envases.ENV_EnvaseObsoleto.Valor = "N"
        End If

        MyBase.Guardar()
    End Sub


    Public Overrides Sub DespuesdeGuardar()
        If LbId.Text <> "" Then
            Agro_ActualizaTarasEnvase(LbId.Text)
            Agro_ActualizaTarasPalet(LbId.Text)
        End If

        MyBase.DespuesdeGuardar()
    End Sub

    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()

        ChkEnvaseRevisado.Checked = (Envases.ENV_EnvaseRevisado.Valor = "1")
        chkObsoleto.Checked = (Envases.ENV_EnvaseObsoleto.Valor = "S")

        CargaConfecciones()
        CargaLineasGrid()

    End Sub

    Private Sub CargaLineasGrid()

        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)

    End Sub

    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        ' Dim total As Double
        ' total = VaDec(ClGrid1.GridView.Columns("porcentaje").SummaryItem.SummaryValue)
        Envasespalets.ENP_idenvase.Valor = TxDato1.Text
        SqlGrid()
        Return MyBase.GuardarLineas(Gr)
    End Function


    Private Sub SqlGrid()

        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim sql As String
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Envasespalets.ENP_id, "ENP_id")
        consulta.SelCampo(Medidaspalet.PLM_Medidas, "Medidas", Envasespalets.ENP_idmedidapalet)
        consulta.SelCampo(Envasespalets.ENP_cajasfila, "CajasFila")
        consulta.SelCampo(Envasespalets.ENP_maxfilas, "MaxFilas")
        'Dim StrKilosCom As New Cdatos.bdcampo("@SUM(AHL_Kilos)", Cdatos.TiposCampo.Importe, 10)

        Dim Tcajas As New Cdatos.bdcampo("@ENP_cajasfila * ENP_maxfilas", Cdatos.TiposCampo.EnteroPositivo, 5)

        consulta.SelCampo(Tcajas, "CajasPalet")
        consulta.WheCampo(Envasespalets.ENP_idenvase, "=", TxDato1.Text)
        consulta.WheCampo(Envasespalets.ENP_idmedidapalet, ">", 0)
        sql = consulta.SQL
        ClGrid1.Consulta = sql

    End Sub

   


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Grid.DataSource = Nothing
        GRid2.DataSource = Nothing

        ChkEnvaseRevisado.Checked = False
        chkObsoleto.Checked = False

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)


        ParametrosFrm()


    End Sub



    Private Sub CargaConfecciones()


        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsView.ColumnAutoWidth = True

        GridView2.OptionsView.ShowGroupPanel = False
        GridView2.OptionsBehavior.Editable = False
        GridView2.OptionsView.ColumnAutoWidth = True

        Dim Confecenvaselineas As New E_ConfecEnvaseLineas(Idusuario, cn)
        Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)

        Dim ConfecPaletslineas As New E_ConfecPaletLineas(Idusuario, cn)
        Dim ConfecPalets As New E_ConfecPalet(Idusuario, cn)


        Dim Consulta As New Cdatos.E_select
        Consulta.SelCampo(Confecenvaselineas.CEL_Idconfec, "IdConfec")
        Consulta.SelCampo(ConfecEnvase.CEV_Nombre, "Confeccion", Confecenvaselineas.CEL_Idconfec)
        Consulta.SelCampo(Confecenvaselineas.CEL_Cantidad, "Cantidad")
        Consulta.WheCampo(Confecenvaselineas.CEL_Idmaterial, "=", LbId.Text)
        Dim dt As DataTable = ConfecEnvase.MiConexion.ConsultaSQL(Consulta.SQL)
        Grid.DataSource = dt


        Dim Consulta2 As New Cdatos.E_select
        Consulta2.SelCampo(ConfecPaletslineas.CPL_Idconfec, "IdConfec")
        Consulta2.SelCampo(ConfecPalets.CPA_Nombre, "Confeccion", ConfecPaletslineas.CPL_Idconfec)
        Consulta2.SelCampo(ConfecPaletslineas.CPL_Cantidad, "Cantidad")
        Consulta2.WheCampo(ConfecPaletslineas.CPL_Idmaterial, "=", LbId.Text)
        Dim dt2 As DataTable = ConfecPalets.MiConexion.ConsultaSQL(Consulta2.SQL)
        GRid2.DataSource = dt2



    End Sub

    Private Sub Grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.Click

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub TxDato14_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato14.TextChanged

    End Sub

    Private Sub TxDato14_Valida(edicion As Boolean) Handles TxDato14.Valida
        If edicion = True Then
            If CbTipoEnv.SelectedValue = "P" Then
                If TxDato14.Text = "" Then
                    MsgBox("Debe asignar un tamaño de palet")
                    TxDato14.MiError = True
                End If
            Else
                TxDato14.Text = ""
            End If

            If CbTipoEnv.Text.ToUpper = "PALET" Then
                TxDato14.Siguiente = TxDato5.Orden
            End If

        End If
    End Sub

    Private Sub TxDato10_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato10.TextChanged

    End Sub

    Private Sub TxDato10_Valida(edicion As Boolean) Handles TxDato10.Valida

        If edicion = True Then
            If CbTipoEnv.Text.ToUpper = "MATERIAL" Or CbTipoEnv.Text.ToUpper = "ETIQUETA" Then
                TxDato10.Siguiente = TxDato5.Orden
                TxDato14.ClParam.Obligatorio = False
            ElseIf CbTipoEnv.Text.ToUpper = "ENVASE" Then
                TxDato10.Siguiente = TxDato11.Orden
                TxDato14.ClParam.Obligatorio = False
            Else
                TxDato10.Siguiente = TxDato14.Orden
                TxDato14.ClParam.Obligatorio = True
            End If
        End If

    End Sub

    Private Sub TxDato2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato2.TextChanged

    End Sub

    Private Sub TxDato2_Valida(edicion As Boolean) Handles TxDato2.Valida

    End Sub

    Private Sub CbTipoEnv_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbTipoEnv.SelectedIndexChanged
        Dim a As String
        If LbId.Text <> "" Then
            a = CbTipoEnv.SelectedValue
            If a = "P" Then
                PanelPalet.Visible = True
                PanelEnvase.Visible = False
            ElseIf a = "E" Then
                PanelEnvase.Visible = True
                PanelPalet.Visible = False
            Else
                PanelEnvase.Visible = False
                PanelPalet.Visible = False

            End If
        End If
    End Sub

    
    Private Sub btRecomponerTara_Click(sender As System.Object, e As System.EventArgs) Handles btRecomponerTara.Click

        Dim frm As New FrmRecomponerTara
        frm.ShowDialog()

    End Sub


    Private Sub ChkEnvaseRevisado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkEnvaseRevisado.CheckedChanged

        If Not Modificando Then

            If VaDec(LbId.Text) > 0 Then

                Dim revisado As String = "0"
                If ChkEnvaseRevisado.Checked Then revisado = "1"

                'Actualizo el valor de la entidad en memoria para que no se borre al guardar
                Envases.ENV_EnvaseRevisado.Valor = revisado


                Dim Envase As New E_Envases(Idusuario, cn)
                If Envase.LeerId(LbId.Text) Then
                    Envase.ENV_EnvaseRevisado.Valor = revisado
                    Envase.Actualizar()
                End If

            End If

        End If

    End Sub



    Private Sub chkObsoleto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkObsoleto.CheckedChanged

        If Not Modificando Then

            If VaDec(LbId.Text) > 0 Then

                Dim obsoleto As String = "N"
                If chkObsoleto.Checked Then obsoleto = "S"

                'Actualizo el valor de la entidad en memoria para que no se borre al guardar
                Envases.ENV_EnvaseObsoleto.Valor = obsoleto


                Dim Envase As New E_Envases(Idusuario, cn)
                If Envase.LeerId(LbId.Text) Then
                    Envase.ENV_EnvaseObsoleto.Valor = obsoleto
                    Envase.Actualizar()
                End If

            End If

        End If

    End Sub
End Class