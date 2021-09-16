Public Class FrmTiposdeClientes
    Inherits FrMantenimiento


    Dim TiposdeClientes As New E_Tiposclientes(Idusuario, cn)
    Dim TipoIvaRepercutido As New E_TipoIvaRepercutido(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Cuentas As New E_Cuentas(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()


    End Sub


    Private Sub ParametrosFrm()


        EntidadFrm = TiposdeClientes


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, TiposdeClientes.TPC_idtipo, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, TiposdeClientes.TPC_nombre, Lb2)
        ParamChk(ChInterno, TiposdeClientes.TPC_clienteinterno, "S", "N")
        ParamChk(ChkGeneraAsiento, TiposdeClientes.TPC_GeneraAsiento, "S", "N")

        ParamTx(TxDato5, TiposdeClientes.TPC_idtipoiva, Lb5)
        ParamChk(ChExento, TiposdeClientes.TPC_exentoiva, "S", "N")
        ParamChk(ChRec, TiposdeClientes.TPC_recequivalencia, "S", "N")

        'ParamTx(TxCtaCliente, TiposdeClientes.TPC_ctacliente, Lb6)
        ParamTx(TxCtaCliente, TiposdeClientes.TPC_ctacliente, Lb6, , Cdatos.TiposCampo.Entero, , 5, "0123456789")
        ParamTx(TxDato7, TiposdeClientes.TPC_ctaventas, Lb7)
        ParamTx(TxDato8, TiposdeClientes.TPC_ctaenvases, Lb8)
        ParamTx(TxDato9, TiposdeClientes.TPC_ctavarios, Lb9)


        ParamTx(TxDato12, TiposdeClientes.TPC_ctaivaventas, Lb21)
        ParamTx(TxDato11, TiposdeClientes.TPC_ctaivaenvases, Lb20)
        ParamTx(TxDato10, TiposdeClientes.TPC_ctaivavarios, Lb19)
        ParamTx(TxDato13, TiposdeClientes.TPC_ctarecargo, Lb22)



        AsociarControles(TxDato1, BtBuscaTipoCli, TiposdeClientes.btBusca, EntidadFrm)
        AsociarControles(TxDato5, BtBuscaTipoIva, TipoIvaRepercutido.btBusca, TipoIvaRepercutido, TipoIvaRepercutido.Nombre, Lb10)

        'AsociarControles(TxCtaCliente, BtBusca6, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lbnom6)
        AsociarControles(TxDato7, BtBusca7, Cuentas.btBusca, Cuentas, Cuentas.Nombre, LbNom7)
        AsociarControles(TxDato8, BtBusca8, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lbnom8)
        AsociarControles(TxDato9, BtBusca9, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lbnom9)

        AsociarControles(TxDato12, BtBusca12, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lbnom12)
        AsociarControles(TxDato11, BtBusca11, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lbnom11)
        AsociarControles(TxDato10, BtBusca10, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lbnom10)
        AsociarControles(TxDato13, BtBusca13, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lbnom13)




        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text
    End Sub


    Public Overrides Sub Guardar()
        MyBase.Guardar()
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
    End Sub


    Private Sub TxCtaCliente_Valida(ByVal edicion As System.Boolean) Handles TxCtaCliente.Valida
        If edicion Then TxCtaCliente.Text = ComprobarDigitos(TxCtaCliente.Text)
    End Sub

    Private Function ComprobarDigitos(ByVal Campo As String) As String
        If Len(Campo) > 0 Then
            Dim Digitos As Integer = Campo.Length
            Dim Faltan As Integer = 6 - Digitos
            For i = 0 To Faltan - 1
                Campo = Campo & "0"
            Next
        End If
        Return Campo
    End Function
End Class