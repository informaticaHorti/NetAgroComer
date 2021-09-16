Public Class Frmgastoscomercio
    Inherits FrMantenimiento


    Dim gastoscomercio As New E_GastosComercio(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim origengastos As New E_OrigenGastos(Idusuario, cn)



    Private Sub ParametrosFrm()
        EntidadFrm = gastoscomercio


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, gastoscomercio.GCO_Idgasto, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, gastoscomercio.GCO_Nombre, Lb2)
        ParamTx(TxDato3, gastoscomercio.GCO_idgrupo, Lb3)

        ParamCb_Copia(CbBox1, gastoscomercio.GCO_Tipobkp, Lb5, Combos.ComboGastos)
        ParamCb_Copia(CbFaccom, gastoscomercio.GCO_Tipogastofc, Lb8, Combos.ComboFacCom)

        ParamTx(TxDato4, gastoscomercio.GCO_idacreedor, Lb7)

        '   ParamTx(TxDato4, gastoscomercio.GCO_Cuenta, Lb7)




        AsociarControles(TxDato1, BtBuscaTgasto, gastoscomercio.btBusca, EntidadFrm)
        AsociarControles(TxDato3, BtBuscaGrupo, origengastos.btBusca, origengastos, origengastos.ORG_Nombre, Lb10)
        AsociarControles(TxDato4, BtBusca1, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, Lb6)



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


    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()
    End Sub

    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Private Sub TxDato3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato3.TextChanged

    End Sub

    Private Sub TxDato3_Valida(ByVal edicion As Boolean) Handles TxDato3.Valida
        If origengastos.LeerId(TxDato3.Text) = True Then
            BtBusca1.CL_Filtro = "TIPO='" + origengastos.ORG_tipo.Valor + "'"
        End If
    End Sub
End Class