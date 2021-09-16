Public Class FrmAcreedores
    Inherits FrMantenimiento


    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Acreedores_gastos As New E_Acreedores_gastos(Idusuario, cn)

    Dim Cuentas As New E_Cuentas(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Bancos As New E_Bancos(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim Tipodocumento As New E_TipoDocumento(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()
        EntidadFrm = Acreedores


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Acreedores.ACR_Codigo, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        TxDato1.Autonumerico = True
        ParamTx(TxDato7, Acreedores.ACR_Nif, Lb7)
        ParamTx(TxDato2, Acreedores.ACR_Nombre, Lb2, True)
        ParamTx(TxDato3, Acreedores.ACR_Domicilio, Lb3)
        ParamTx(TxDato4, Acreedores.ACR_Poblacion, Lb4)
        ParamTx(TxDato5, Acreedores.ACR_CPostal, Lb5)
        ParamTx(TxProvincia, Acreedores.ACR_Provincia, LbProvincia)
        ParamTx(TxDato8, Acreedores.ACR_Telefono1, Lb8)
        ParamTx(TxDato9, Acreedores.ACR_Telefono2, Lb9)
        ParamTx(TxDato10, Acreedores.ACR_Fax, Lb10)
        ParamTx(TxDato11, Acreedores.ACR_Mail, Lb1)
        ParamTx(TxDato12, Acreedores.ACR_IdCuenta, Lb12, True)
        ParamTx(TxDato6, Acreedores.ACR_CuentaGasto, Lb15)

        ParamTx(TxDato13, Acreedores.ACR_PorceIva, Lb13)
        ParamTx(TxDato14, Acreedores.ACR_PorceRet, Lb14)

        ParamTx(TxBanco, Acreedores.ACR_IdBanco, LbBanco)
        ParamTx(TxTipo, Acreedores.ACR_IdTipo, LbTipo)
        ParamTx(TxDias, Acreedores.ACR_Dias, LbDias)
        ParamTx(TxCodigoFianza, Acreedores.ACR_CodigoFianza, LbCodigoFianza)


        AsociarControles(TxDato1, BtBusca1, Acreedores.btBusca, EntidadFrm)

        AsociarControles(TxDato12, BtBusca12, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lb_12)
        AsociarControles(TxDato6, BtBusca2, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lb6)

        AsociarControles(TxBanco, BtBanco, Bancos.btBusca, Bancos, Bancos.Nombre, LbNomBanco)
        AsociarControles(TxTipo, BtTipo, Tipodocumento.btBusca, Tipodocumento, Tipodocumento.Nombre, LbNomTipo)


        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text

    End Sub

    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()
        CargaGridFRm()
    End Sub
    Public Overrides Sub Guardar()
        GuardarCh()

        MyBase.Guardar()
        CargaGridFRm()
    End Sub
    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
        CargaGridFRm()

    End Sub

    Private Sub CargaGridFRm()
       
        Dim dt As New DataTable
        Dim sql As String
        sql = "Select ORG_idorigen as IdOrigen, ORG_nombre as Nombre from origengastos order by ORG_idorigen"
        dt = EntidadFrm.MiConexion.ConsultaSQL(sql)

        ChOrigen.DataSource = dt
        ChOrigen.ValueMember = "IdOrigen"
        ChOrigen.DisplayMember = "Nombre"


        ChOrigen.CheckOnClick = True


        If Val(LbId.Text) > 0 Then
            For indice As Integer = 0 To ChOrigen.ItemCount - 1

                '   If ChOrigen.GetItemChecked(indice) = True Then
                ' MsgBox("Checked: " & row("Nombre").ToString)
                ' End If

                Dim row As DataRowView = ChOrigen.GetItem(indice)
                Dim a As String = row("IdOrigen").ToString
                If Acreedores_gastos.leeracreedor_origen(LbId.Text, a) > 0 Then
                    ChOrigen.SetItemChecked(indice, True)

                End If

            Next
        End If


    End Sub

    Private Sub GuardarCh()
        BorrarGastos()
        For Each row As DataRowView In ChOrigen.CheckedItems

            Acreedores_gastos.VaciaEntidad()
            Dim id As Integer = Acreedores_gastos.MaxId
            Acreedores_gastos.ACG_Id.Valor = id.ToString
            Acreedores_gastos.ACG_Idacreedor.Valor = LbId.Text
            Acreedores_gastos.ACG_Idorigengasto.Valor = row("IdOrigen").ToString
            Acreedores_gastos.Insertar()

        Next

    End Sub

    Private Sub BorrarGastos()
        If Val(LbId.Text) > 0 Then
            Dim sql As String = "delete from acreedores_gastos where ACG_idacreedor=" + LbId.Text
            Acreedores_gastos.MiConexion.ConsultaSQL(sql)
        End If

    End Sub


    Private Sub TxDato7_Valida(edicion As System.Boolean) Handles TxDato7.Valida

        If edicion Then

            If TxDato7.Text.Trim <> "" And NuevoRegistro Then

                Dim lst As New List(Of String)


                Dim CONSULTA As New Cdatos.E_select
                CONSULTA.SelCampo(Acreedores.ACR_Codigo, "IdAcreedor")
                CONSULTA.WheCampo(Acreedores.ACR_Nif, "=", TxDato7.Text)

                Dim dt As DataTable = Acreedores.MiConexion.ConsultaSQL(CONSULTA.SQL)
                If Not IsNothing(dt) Then

                    If dt.Rows.Count > 0 Then

                        For Each row As DataRow In dt.Rows

                            Dim IdAcreedor As String = (row("IdAcreedor").ToString & "").Trim
                            lst.Add(IdAcreedor)

                        Next

                    End If

                End If


                If lst.Count > 0 Then

                    Dim texto As String = CadenaWhereLista_CAMPO("", Cdatos.TiposCampo.Entero, lst)
                    MsgBox("El NIF introducido ya existe en el siguiente acreedor: " & texto.Replace("=", ""))

                End If

            End If


        End If

    End Sub

End Class