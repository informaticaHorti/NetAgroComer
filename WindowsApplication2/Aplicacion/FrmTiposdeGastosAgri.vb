Public Class FrmTiposdeGastosAgri

    Inherits FrMantenimiento


    Dim TiposdeGastosAgri As New E_TiposdeGastoAgri(Idusuario, cn)
    Dim origengastos As New E_OrigenGastos(Idusuario, cn)
    Dim acreedores As New E_Acreedores(Idusuario, cn)



    Private Sub ParametrosFrm()
        EntidadFrm = TiposdeGastosAgri


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, TiposdeGastosAgri.TGA_Idtipogasto, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, TiposdeGastosAgri.TGA_Nombre, Lb2)
        ParamCb_Copia(CbBox1, TiposdeGastosAgri.TGA_Tipo, Lb5, Combos.ComboGastos)
        ParamTx(TxDato3, TiposdeGastosAgri.TGA_idgrupo, Lb3)
        ParamTx(TxDato4, TiposdeGastosAgri.TGA_idacreedor, Lb7)
        ParamCb_Copia(CbFaccom, TiposdeGastosAgri.TGA_tipogastofc, Lb8, Combos.ComboFacCom)
        ParamChk(chkImprimirEnEntrada, TiposdeGastosAgri.TGA_ImprimirEnEntrada, "S", "N")




        AsociarControles(TxDato1, BtBuscaTgasto, TiposdeGastosAgri.btBusca, EntidadFrm)
        AsociarControles(TxDato3, BtBuscaGrupo, origengastos.btBusca, origengastos, origengastos.ORG_Nombre, Lb10)
        AsociarControles(TxDato4, BtBuscaAcreedor, acreedores.BtBuscaXtipo, acreedores, acreedores.ACR_Nombre, Lb6)



        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub
    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text


    End Sub
    Public Overrides Sub Guardar()
        Dim a = ""

        MyBase.Guardar()

    End Sub







    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub











    Private Sub Lb4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub CbBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxDato1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato1.TextChanged

    End Sub

    Private Sub TxDato3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato3.TextChanged

    End Sub

    Private Sub TxDato3_Valida(ByVal edicion As Boolean) Handles TxDato3.Valida
        If origengastos.LeerId(TxDato3.Text) = True Then
            BtBuscaAcreedor.CL_Filtro = "TIPO='" + origengastos.ORG_tipo.Valor + "'"
        End If

    End Sub
End Class