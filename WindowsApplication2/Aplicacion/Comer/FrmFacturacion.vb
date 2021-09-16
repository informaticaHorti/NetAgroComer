Imports DevExpress.XtraEditors
Imports System.Drawing


Public Class FrmFacturacion
    Inherits FrMantenimiento


    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Categorias As New E_CategoriasSalida(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim GastosComercio As New E_GastosComercio(Idusuario, cn)
    Dim Facturas As New E_Facturas(Idusuario, cn)
    Dim Facturaslineasvar As New E_FacturasLineasVar(Idusuario, cn)
    Dim Paises As New E_Paises(Idusuario, CnComun)
    Dim Moneda As New E_Moneda(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim ConceptosFactura As New E_ConceptosFactura(Idusuario, cn)
    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim AlbSalida_Gastos As New E_albsalida_gastos(Idusuario, cn)
    Dim IdAsientonet As Integer
    Dim TipoIva As New E_tiposiva(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)


    Dim TiposClientes As New E_Tiposclientes(Idusuario, cn)
    Dim TipoIvaRepercutido As New E_TipoIvaRepercutido(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))

    Dim FormasPago As New E_FormasPago(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim Cuentas As New E_Cuentas(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))

    Dim Cobros As New E_Cobros(Idusuario, cn)
    Dim CobrosLineas As New E_CobrosLineas(Idusuario, cn)

    Dim Altas_AEAT As New E_Altas_AEAT(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))



    Dim MiCentro As String
    Dim Envases As New E_Envases(Idusuario, cn)

    Dim _DtGastos As DataTable = Nothing


    Private Class stClaves_GastosAlbaran

        Public Tipo As Integer = 0
        Public Gasto As String = ""
        Public FC As String = ""

        Public Sub New(Tipo As Integer, gasto As String, FC As String)
            Me.Tipo = Tipo
            Me.Gasto = gasto
            Me.FC = FC
        End Sub

    End Class

    Private Class stDatos_GastosAlbaran

        Public ImpGasto As Decimal = 0

        Public Sub New(ImpGasto As Decimal)
            Me.ImpGasto = ImpGasto
        End Sub

    End Class


    Dim acum As New Acumulador


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Private Sub ParametrosFrm()


        EntidadFrm = Facturas


        Dim lc As New List(Of Object)
        ListaControles = lc



        LbPuntoVenta.CL_ControlAsociado = TxDato_1
        LbNomPv.CL_ControlAsociado = TxDato_1
        CampoClave = 1 ' ultimo campo de la clave

        ParamTx(TxDato_0, Facturas.FRA_serie, Lb_1)
        ParamTx(TxDato_1, Facturas.FRA_factura, Lb_1, True)
        TxDato_1.Autonumerico = True

        ParamTx(TxDato_2, Facturas.FRA_fecha, Lb_2, True)
        ParamTx(TxDato_4, Facturas.FRA_idcliente, Lb_4, True)
        ParamTx(TxDato_5, Facturas.FRA_clientealbaranes, Lb_5, True)

        ParamTx(TxDato_3, Facturas.FRA_cdpais, Lb_3, True)
        ParamTx(TxReferencia, Facturas.FRA_RefCliente, LbReferencia)
        ParamTx(TxDato_8, Facturas.FRA_idformadepago, Lb_8, False)
        ParamTx(TxDato_6, Facturas.FRA_cddivisa, Lb_6, True)
        ParamTx(TxDato_7, Facturas.FRA_valorcambio, Lb_7, True)
        ParamTx(TxDato_9, Facturas.FRA_fechavto, Lb_9, False)
        ParamTx(TxRegimenIva, Facturas.FRA_IdTipoIva, LbRegimenIva, True)
        'ParamTx(TxDato_10, Facturas.FRA_FacturaEnvases, Lb1, True, , , 1, "SN")
        'TODO: Comprobar: O bien 1--> No Facturar, o bien 2--> Detallar. No se piensa en incluir en precio
        'ParamChk(chkFacturarEnvases, Facturas.FRA_FacturaEnvases, "1", "2")



        ParamTx(TxDato_28, Facturaslineasvar.FLV_tipoGEC, Lb_28, True, , , , "GEC")
        ParamTx(TxDato_27, Facturaslineasvar.FLV_codigo, Lb_27, True)
        ParamTx(TxDato_29, Facturaslineasvar.FLV_cantidad, Lb_29, False)
        ParamTx(TxDato_30, Facturaslineasvar.FLV_precio, Lb_30, False)


        AsociarControles(TxDato_1, BtBuscaAlbaran, Facturas.btBusca, Facturas)
        AsociarControles(TxRegimenIva, BtBuscaRegimenIva, TipoIvaRepercutido.btBusca, TipoIvaRepercutido, TipoIvaRepercutido.Nombre, LbNom_RegimenIva)

        BtBuscaAlbaran.CL_Filtro = "AC='C'"
        BtBuscaAlbaran.CL_DevuelveCampo = "IdFactura"


        AsociarGrid(ClGrid1, TxDato_28, TxDato_30, Facturaslineasvar)

        PropiedadesCamposGr(ClGrid1, "FLV_idlinea", "FLV_idlinea", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Tipo", "Tipo", True, 10)
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 10)
        PropiedadesCamposGr(ClGrid1, "Producto", "Producto", True, 50)
        PropiedadesCamposGr(ClGrid1, "Cantidad", "Cantidad", True, 15, False, "#0.00")
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 15, False, "#0.000000")
        PropiedadesCamposGr(ClGrid1, "Importe", "Importe", True, 20, True, "#,##0.00", "{0:n2}")


        ParamTx(TxDato1, Facturas.FRA_obs1, Nothing, False)
        ParamTx(TxDato2, Facturas.FRA_obs2, Nothing, False)


        ParamTx(TxDato_40, Facturas.FRA_Iva1, Lb10, False)
        ParamTx(TxDato_41, Facturas.FRA_Iva2, Lb10, False)
        ParamTx(TxDato_42, Facturas.FRA_Iva3, Lb10, False)

        ParamTx(TxDato_43, Facturas.FRA_Re1, Lb26, False)
        ParamTx(TxDato_44, Facturas.FRA_Re2, Lb26, False)
        ParamTx(TxDato_45, Facturas.FRA_Re3, Lb26, False)

        ' ParamTx(TxDato_50, Facturas.FRA_cuentaventas1, Lb30, False, Cdatos.TiposCampo.Cuenta)
        'ParamTx(TxDato_51, Facturas.FRA_cuentaventas2, Lb30, False, Cdatos.TiposCampo.Cuenta)
        ParamTx(TxDato_52, Facturas.FRA_cuentaventas3, Lb30, False, Cdatos.TiposCampo.Cuenta)

        ParamTx(TxSuplido, Facturas.FRA_Suplido, LbSuplido, False)
        ParamTx(TxAcreedor, Facturas.FRA_idacreedor, LbAcreedor, False)


        AsociarControles(TxDato_4, BtBuscaCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lbnom_4)
        AsociarControles(TxDato_5, BtBuscaClienteAlb, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lbnom_5)
        AsociarControles(TxDato_3, BtBusca_3, Paises.btBusca, Paises, Paises.Nombre, Lbnom_3)
        AsociarControles(TxDato_6, BtBusca_6, Moneda.btBusca, Moneda, Moneda.MON_Nombre, Lbnom_6)

        AsociarControles(TxDato_8, BtBusca_8, FormasPago.btBusca, FormasPago, FormasPago.Nombre, Lbnom_8)
        ' AsociarControles(TxDato_50, BtBusca_50, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lb_50)
        'AsociarControles(TxDato_51, BtBusca_51, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lb_51)
        AsociarControles(TxDato_52, BtBusca_52, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lb_52)
        AsociarControles(TxAcreedor, BtAcreedor, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomAcreedor)

        BtAcreedor.CL_Filtro = "Tipo='PV'"

        'FiltroEntidad.Add(Facturas.FRA_idpuntoventa.NombreCampo, MiMaletin.IdPuntoVenta.ToString)
        FiltroEntidad.Add(Facturas.FRA_campa.NombreCampo, MiMaletin.Ejercicio.ToString)

    End Sub


    Private Sub FrmFacturacion_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        InicioDespuesDeGuardar = False
        'InicioDespuesDeAuxiliar3 = False

        GridViewAlbaranes.OptionsView.ShowGroupPanel = False
        GridViewGastos.OptionsView.ShowGroupPanel = False
        GridViewAlbaranes.OptionsBehavior.Editable = False
        GridViewGastos.OptionsBehavior.Editable = False


        BTaux1.Text = "Imprimir"
        BTaux1.Image = NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        BTaux1.Visible = True

        BtAux2.Text = "I.Directa"
        BtAux2.Image = NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        BtAux2.Visible = True

        BtAux3.Text = "Enviar cliente"
        BtAux3.Width = 90
        BtAux3.Image = NetAgro.My.Resources.Resources.App_xf_mail_16x16_32
        BtAux3.Visible = True


    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave

        Dim i As Integer
        If TxDato_1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = Facturas.LeerFac(LbNuCTB.Text, Lbejer.Text, TxDato_0.Text, VaInt(TxDato_1.Text))
            If i > 0 Then
                LbId.Text = i.ToString
                If Facturas.FRA_alhcom.Valor <> "C" Then
                    MsgBox("Esta factura no es de comercio")
                    LbId.Text = ""
                End If
            Else
                LbId.Text = "+"
            End If
        End If

        If LbId.Text <> "" Then
            CargaLineasGrid()
        End If

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()


        LbNumeroRegistro.Text = Clientes.CLI_NumeroRegistro.Valor

        PintaPuntoVenta(Facturas.FRA_idempresa.Valor, Facturas.FRA_idpuntoventa.Valor, Facturas.FRA_campa.Valor, Facturas.FRA_idasientoNet.Valor)
        Lbejer.Text = Facturas.FRA_campa.Valor
        LbNuCTB.Text = Facturas.FRA_idempresa.Valor


        ' llenar el grid
        CargaLineasGrid()

        CargaAlbaranes()

        BtSelNinguno.Enabled = False
        BtSelTodos.Enabled = False

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)

        MyBase.Entidad_a_DatosLin(Grid)
        If Grid Is ClGrid1 Then

            Dim Tipo As String = (Facturaslineasvar.FLV_tipoGEC.Valor & "").Trim.ToUpper

            Select Case Tipo
                Case "G"
                    AsociarControles(TxDato_27, BtBusca_GEC, Generos.btBusca, Generos, Generos.GEN_NombreGenero, Lbnom_27)
                Case "E"
                    AsociarControles(TxDato_27, BtBusca_GEC, Envases.btBusca, Envases, Envases.ENV_Nombre, Lbnom_27)
                Case "C"
                    AsociarControles(TxDato_27, BtBusca_GEC, ConceptosFactura.btBusca, ConceptosFactura, ConceptosFactura.COF_nombre, Lbnom_27)
            End Select

        End If

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean
        Dim importe As Double



        If LbId.Text = "+" Then
            LbId.Text = Facturas.MaxId
            If TxDato_1.Text = "+" Then
                TxDato_1.Text = Facturas.MaxIdCampa(Val(LbNuCTB.Text), Val(Lbejer.Text), TxDato_0.Text)
            End If
        End If

        If Gr Is ClGrid1 Then
            Facturas.FRA_idfactura.Valor = LbId.Text
            Facturas.FRA_campa.Valor = Lbejer.Text
            Facturas.FRA_idempresa.Valor = LbNuCTB.Text
            Facturas.FRA_idpuntoventa.Valor = LbPuntoVenta.Text
            Facturas.FRA_idcentro.Valor = MiCentro
            Facturaslineasvar.FLV_idfactura.Valor = LbId.Text
            importe = VaDec(TxDato_29.Text) * VaDec(TxDato_30.Text)
        End If



        SqlGrid()
        r = MyBase.GuardarLineas(Gr)

        'Si estamos guardando líneas en el grid de otros gastos, debe recalcular todos los importes
        CalculoTotales(True)

        Return r

    End Function


    Private Sub CargaLineasGrid()

        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)

        MarcaAlbaranes()
        CalculoTotales(False)

    End Sub


    Private Sub MarcaAlbaranes()

        For indice As Integer = 0 To GridViewAlbaranes.RowCount - 1

            Dim row As DataRow = GridViewAlbaranes.GetDataRow(indice)
            If Not IsNothing(row) Then
                Dim IdFactura As String = row("IdFactura").ToString
                If VaInt(IdFactura) = VaInt(LbId.Text) Then
                    row("S") = True
                End If
            End If

        Next

    End Sub


    Private Sub SqlGrid()
        Dim id As String

        If LbId.Text = "+" Then
            id = "-1"
        Else
            id = LbId.Text
        End If


        Dim sql As String = "Select FLV_idlinea AS FLV_idlinea, " & vbCrLf
        sql = sql & " FLV_tipoGEC AS Tipo, " & vbCrLf
        sql = sql & " FLV_Codigo AS Codigo, " & vbCrLf
        sql = sql & " COALESCE(GEN_NombreGenero,'') + COALESCE(ENV_Nombre,'') + COALESCE(COF_Nombre,'') AS Producto, " & vbCrLf
        sql = sql & " FLV_cantidad AS Cantidad, " & vbCrLf
        sql = sql & " FLV_precio AS Precio, " & vbCrLf
        sql = sql & " COALESCE(FLV_cantidad,0) * COALESCE(FLV_precio,0) as Importe" & vbCrLf
        sql = sql & " FROM Facturaslineasvar" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON (FLV_Codigo = GEN_IdGenero AND FLV_TipoGEC = 'G') " & vbCrLf
        sql = sql & " LEFT JOIN Envases ON (FLV_Codigo = ENV_IdEnvase AND FLV_TipoGEC = 'E') " & vbCrLf
        sql = sql & " LEFT JOIN ConceptosFactura ON (FLV_Codigo = COF_IdConcepto AND FLV_TipoGEC = 'C') " & vbCrLf
        sql = sql & " WHERE FLV_idfactura = " & id & vbCrLf
        sql = sql & " ORDER BY flv_IdLinea" & vbCrLf


        ClGrid1.Consulta = sql


    End Sub


    Public Overrides Sub Anular()
        'MyBase.Anular()

        If LbId.Text = "" Then Exit Sub
        If InStr(OperFrm, PermisosFormularios.Bajas) = 0 Then
            MsgBox("No tiene permisos para anular")
        Else
            If EstaBloqueado() = False Then
                If CumpleFiltro(True, "ANULAR") = True Then

                    If MsgBox("Desea anular el registro", vbYesNo) = vbYes Then

                        If MsgBox("Desea borrar el asiento?", vbYesNo) = MsgBoxResult.Yes Then

                            EntidadFrm.Eliminar()
                            DespuesdeAnular()
                            QuitarBloqueo()

                            If Not IsNothing(usuarios_procesos) Then
                                usuarios_procesos.AñadirProceso(Me.Text, "BAJA", Me.EntidadFrm.NombreTabla, LbId.Text)
                            End If


                            BorraPan()
                            If ListaControles.Count > 0 Then ListaControles(0).select()

                        Else
                            MsgBox("Se cancela la anulación de la factura")
                        End If

                    End If
                End If
            End If

        End If

    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If CDate(Facturas.FRA_fecha.Valor) < MiMaletin.FechaCtbIva Then
            MsgBox("Fecha contabilidad bloqueada")
            Exit Sub
        End If


        If VaDec(LbId.Text) > 0 Then

            Dim IdAsiento As String = (Facturas.FRA_idasientoNet.Valor & "").Trim

            If FacturaEnviada_AEAT(IdAsiento) Then
                MsgBox("No se puede anular la factura debido a que ya ha sido presentada en Hacienda. Para cualquier cambio debe presentar una factura rectificativa.")
            Else
                MyBase.BAnular_Click(sender, e)
            End If


        End If




    End Sub

    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If VaInt(LbId.Text) > 0 Then

            If CDate(Facturas.FRA_fecha.Valor) < MiMaletin.FechaCtbIva Then
                MsgBox("Fecha contabilidad bloqueada")
                Exit Sub
            End If


            If VaDec(LbId.Text) > 0 Then

                Dim IdAsiento As String = (Facturas.FRA_idasientoNet.Valor & "").Trim


                If FacturaEnviada_AEAT(IdAsiento) Then
                    MsgBox("No se puede modificar la factura debido a que ya ha sido presentada en Hacienda. Para cualquier cambio debe presentar una factura rectificativa.")
                Else
                    MyBase.BModificar_Click(sender, e)

                    BtSelNinguno.Enabled = True
                    BtSelTodos.Enabled = True

                End If


            End If

        End If


    End Sub


    Private Sub PintaPuntoVenta(ByVal idempresa As Integer, ByVal idpv As String, ByVal ejer As String, ByVal idasiento As String)

        Dim asientos As New E_Asientos(Idusuario, ConexCtb(idempresa))
        LbPuntoVenta.Text = idpv

        If PuntoVenta.LeerId(idpv) = True Then
            LbNomPv.Text = PuntoVenta.Nombre.Valor
            MiCentro = PuntoVenta.IdCentro.Valor
        Else
            LbNomPv.Text = ""
            MiCentro = ""
        End If
        IdAsientonet = VaInt(idasiento)
        If VaInt(idasiento) > 0 Then
            LbAsiento.Text = Asientos.NumeroAsiento(idasiento)
        End If
        Lbejer.Text = ejer
        LbNuCTB.Text = idempresa


    End Sub



    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbNumeroRegistro.Text = ""

        PintaPuntoVenta(MiMaletin.IdEmpresaCTB, MiMaletin.IdPuntoVenta, MiMaletin.Ejercicio.ToString, "")
        Lbejer.Text = MiMaletin.Ejercicio
        LbNuCTB.Text = MiMaletin.IdEmpresaCTB
        IdAsientonet = 0
        GridAlbaranes.DataSource = Nothing
        GridGastos.DataSource = Nothing

        'Número de serie: por defecto el Centro con dos dígitos
        'If MiMaletin.IdCentro > 0 Then TxDato_0.Text = MiMaletin.IdCentro.ToString("00")


        _DtGastos = Nothing


        LbCobrado.Text = ""
        'TxRegimenIva.Text = ""


    End Sub


    Private Sub CalculoTotales(ByVal bCalcula As Boolean)

        Dim TotalGeneros As Decimal = 0
        Dim TotalEnvases As Decimal = 0
        Dim TotalOtros As Decimal = 0
        Dim TotalGastos As Decimal = 0

        Dim baseGeneros As Decimal = VaDec(Facturas.FRA_Base1.Valor)
        Dim baseEnvases As Decimal = VaDec(Facturas.FRA_Base2.Valor)
        Dim baseOtros As Decimal = VaDec(Facturas.FRA_Base3.Valor)


        If bCalcula Then

            CalculaTotalAlbaranes(TotalGeneros, TotalEnvases, TotalGastos)
            'If Not chkFacturarEnvases.Checked Then TotalEnvases = 0
            CalculaTotalOtros(TotalGeneros, TotalEnvases, TotalOtros)

            baseGeneros = TotalGeneros - TotalGastos
            baseEnvases = TotalEnvases
            baseOtros = TotalOtros

        End If

        LbTGeneros.Text = baseGeneros.ToString("#,##0.00")
        LbTEnvases.Text = baseEnvases.ToString("#,##0.00")
        LbTVarios.Text = baseOtros.ToString("#,##0.00")



    End Sub


    Private Sub CalculaTotalAlbaranes(ByRef TotalGeneros As Decimal, ByRef TotalEnvases As Decimal, ByRef TotalGastos As Decimal)

        For indice As Integer = 0 To GridViewAlbaranes.RowCount - 1
            Dim row As DataRow = GridViewAlbaranes.GetDataRow(indice)
            If Not IsNothing(row) Then

                If row("S") = True Then

                    Dim ImpGenero As Decimal = VaDec(row("ImpGenero"))
                    Dim ImpEnvases As Decimal = VaDec(row("ImpEnvases"))
                    Dim GastosFra As Decimal = VaDec(row("GastosFra"))

                    TotalGeneros = TotalGeneros + ImpGenero
                    TotalEnvases = TotalEnvases + ImpEnvases
                    TotalGastos = TotalGastos + GastosFra

                End If

            End If
        Next

    End Sub


    Private Sub CalculaTotalOtros(ByRef TotalGeneros As Decimal, ByRef TotalEnvases As Decimal, ByRef TotalOtros As Decimal)

        Dim res As Decimal = 0

        For indice As Integer = 0 To ClGrid1.GridView.RowCount - 1

            Dim row As DataRow = ClGrid1.GridView.GetDataRow(indice)
            If Not IsNothing(row) Then

                Dim Tipo As String = (row("Tipo").ToString & "").Trim.ToUpper
                Select Case Tipo
                    Case "G"
                        TotalGeneros = TotalGeneros + (VaDec(row("Cantidad")) * VaDec(row("Precio")))
                    Case "E"
                        TotalEnvases = TotalEnvases + (VaDec(row("Cantidad")) * VaDec(row("Precio")))
                    Case "C"
                        TotalOtros = TotalOtros + (VaDec(row("Cantidad")) * VaDec(row("Precio")))
                End Select

            End If

        Next


    End Sub


    Public Overrides Sub Guardar()


        If LbId.Text = "+" Then
            Facturas.FRA_idfactura.Valor = Facturas.MaxId()
            LbId.Text = Facturas.FRA_idfactura.Valor
            If TxDato_1.Text = "+" Then
                TxDato_1.Text = Facturas.MaxIdCampa(VaInt(LbNuCTB.Text), VaInt(Lbejer.Text), TxDato_0.Text)
            End If
        End If


        Facturas.FRA_idfactura.Valor = LbId.Text
        Facturas.FRA_idpuntoventa.Valor = LbPuntoVenta.Text
        Facturas.FRA_campa.Valor = Lbejer.Text
        Facturas.FRA_idempresa.Valor = LbNuCTB.Text


        Facturas.FRA_Base1.Valor = VaDec(LbTGeneros.Text)
        Facturas.FRA_Base2.Valor = VaDec(LbTEnvases.Text)
        Facturas.FRA_Base3.Valor = VaDec(LbTVarios.Text)

        Facturas.FRA_Cuota1.Valor = VaDec(LbCuotaGen.Text)
        Facturas.FRA_Cuota2.Valor = VaDec(LbCuotaEnv.Text)
        Facturas.FRA_Cuota3.Valor = VaDec(LbCuotaVar.Text)

        Facturas.FRA_CuotaRe1.Valor = VaDec(LbCuotaReGen.Text)
        Facturas.FRA_CuotaRe2.Valor = VaDec(LbCuotaReEnv.Text)
        Facturas.FRA_CuotaRe3.Valor = VaDec(LbCuotaReVar.Text)

        'Facturas.FRA_totalfactura.Valor = VaDec(LbTotEuros.Text)
        Facturas.FRA_totalfactura.Valor = VaDec(LbTotDivisa.Text)
        Facturas.FRA_tipofactura.Valor = "1"
        Facturas.FRA_alhcom.Valor = "C"
        Facturas.FRA_idcentro.Valor = MiCentro


        MyBase.Guardar()


    End Sub


    Public Overrides Sub DespuesdeGuardar()
        Dim TxError As String = ""
        MyBase.DespuesdeGuardar()

        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)

        For indice As Integer = 0 To GridViewAlbaranes.RowCount - 1

            Dim row As DataRow = GridViewAlbaranes.GetDataRow(indice)
            If Not IsNothing(row) Then

                If VaInt(row("S")) <> VaInt(row("S_Original")) Then

                    Dim IdAlbaran As String = row("IdAlbaran").ToString & ""
                    If AlbSalida.LeerId(IdAlbaran) Then
                        If row("S") = True Then
                            AlbSalida.ASA_idfactura.Valor = LbId.Text
                        Else
                            AlbSalida.ASA_idfactura.Valor = 0
                        End If
                        AlbSalida.Actualizar()
                    End If
                End If

            End If

        Next


        If ConectarFinancieroContabilidad = "S" Then

            'No contabilizar si el tipo de cliente no genera asiento
            Dim Clientes As New E_Clientes(Idusuario, cn)
            If Clientes.LeerId(Facturas.FRA_idcliente.Valor) Then
                Dim TiposClientes As New E_Tiposclientes(Idusuario, cn)
                If TiposClientes.LeerId(Clientes.CLI_IdTipo.Valor) Then

                    Dim bGeneraAsiento As Boolean = ((TiposClientes.TPC_GeneraAsiento.Valor & "").Trim.ToUpper = "S")
                    If bGeneraAsiento Then

                        'Contabiliza
                        Dim i As Integer = Facturas.Contabiliza(LbId.Text)
                        If i > 0 Then

                            Dim ListaAsientos As New List(Of Integer)
                            ListaAsientos.Add(i)
                            Dim f As New frmVisualizadorAsiento(ListaAsientos, False, "")
                            f.ShowDialog()

                        Else
                            MsgBox("no se generó asiento")
                        End If


                    End If

                End If
            End If


        End If



        If VaDec(LbId.Text) > 0 Then

            If XtraMessageBox.Show("¿Desea enviar al cliente por email?", "Email", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                C1_EnviarFacturaComercializacion(LbId.Text)
            End If

            If XtraMessageBox.Show("¿Desea imprimir la factura?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                C1_ImprimirFacturaComercializacion(LbId.Text, TipoImpresion.Preliminar)
            End If

            C1_GestionDocumentalFacturasComercializacion(LbId.Text)

        End If


    End Sub



    Public Overrides Sub DespuesdeAnular()
        Dim c As New Contabilizacion.clAsientos

        MyBase.DespuesdeAnular()
        If idasientonet > 0 And VaInt(LbAsiento.Text) > 0 Then
            If c.AnularAsiento(ConexCtb(VaInt(LbNuCTB.Text)), IdAsientonet, LbAsiento.Text) <> 0 Then
                MsgBox("No se pudo anular el asiento ")
            Else
                MsgBox("Asiento anulado con exito")
            End If
        End If

    End Sub
    Private Sub TxDato_28_Valida(edicion As System.Boolean) Handles TxDato_28.Valida

        Dim tipo As String = TxDato_28.Text.Trim.ToUpper
        Select Case tipo
            Case "G"
                AsociarControles(TxDato_27, BtBusca_GEC, Generos.btBusca, Generos, Generos.GEN_NombreGenero, Lbnom_27)
            Case "E"
                AsociarControles(TxDato_27, BtBusca_GEC, Envases.btBusca, Envases, Envases.ENV_Nombre, Lbnom_27)
            Case "C"
                AsociarControles(TxDato_27, BtBusca_GEC, ConceptosFactura.btBusca, ConceptosFactura, ConceptosFactura.COF_nombre, Lbnom_27)
        End Select

    End Sub


    Private Sub TxDato_5_Valida(edicion As System.Boolean) Handles TxDato_5.Valida

        'TODO: MUCHO OJO!!!!! Al cambiar de cliente albaranes, habrá que quitar los que estaban asociados del otro cliente


        'Si estamos dando de alta, sólo mostramos los pendientes para este cliente
        If edicion Then

            If NuevoRegistro Then

                CargaAlbaranes()
                CalculoTotales(True)

            ElseIf Not NuevoRegistro And Modificando And VaInt(TxDato_5.Text) <> VaInt(Facturas.FRA_clientealbaranes.Valor) Then


                If XtraMessageBox.Show("Al cambiar Cliente Albaranes, se desvincularán los albaranes asociados a esta factura, ¿desea continuar?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)

                    For indice As Integer = 0 To GridViewAlbaranes.RowCount - 1
                        Dim row As DataRow = GridViewAlbaranes.GetDataRow(indice)
                        If Not IsNothing(row) Then
                            If VaInt(row("IdFactura").ToString) = VaInt(LbId.Text) Then
                                Dim IdAlbaran As String = row("IdAlbaran").ToString & ""
                                If AlbSalida.LeerId(IdAlbaran) Then
                                    AlbSalida.ASA_idfactura.Valor = 0
                                    AlbSalida.Actualizar()
                                End If
                            End If
                        End If
                    Next

                    Dim FRA As New E_Facturas(Idusuario, cn)
                    If FRA.LeerId(LbId.Text) Then
                        Facturas.FRA_clientealbaranes.Valor = TxDato_5.Text
                        FRA.FRA_clientealbaranes.Valor = TxDato_5.Text
                        FRA.Actualizar()
                    End If

                    CargaAlbaranes()
                    CalculoTotales(True)
                Else
                    TxDato_5.Text = Facturas.FRA_clientealbaranes.Valor
                    TxDato_5.Validar(edicion)
                End If
            End If


        End If


    End Sub


    Private Sub CargaAlbaranes()


        'TODO: Guardar cambios al guardar
        'TODO: MUCHO OJO!!!!! Al cambiar de cliente albaranes, habrá que quitar los que estaban asociados del otro cliente
        'TODO: Primero borramos todos y después actualizamos??


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbSalida.ASA_idalbaran, "IdAlbaran")
        consulta.SelCampo(AlbSalida.ASA_albaran, "Albaran")
        consulta.SelCampo(AlbSalida.ASA_idcentro, "CE")
        consulta.SelCampo(AlbSalida.ASA_fechasalida, "FechaSalida")
        'consulta.SelCampo(AlbSalida.ASA_referencia, "Referencia")
        consulta.SelCampo(AlbSalida.ASA_refvaloracion, "Referencia")
        consulta.SelCampo(AlbSalida.ASA_matriculacamion, "Matricula")
        consulta.SelCampo(Moneda.MON_Nombre, "Divisa", AlbSalida.ASA_iddivisa, Moneda.MON_IdMoneda)
        consulta.SelCampo(AlbSalida.ASA_valorcambio, "Cambio")
        consulta.SelCampo(AlbSalida.ASA_idfactura, "IdFactura")
        consulta.SelCampo(AlbSalida.ASA_idvaleenvase, "IdValeEnvase")
        consulta.WheCampo(AlbSalida.ASA_idcliente, "=", VaInt(TxDato_5.Text).ToString)
        consulta.WheCampo(AlbSalida.ASA_IdEmpresa, "=", LbNuCTB.Text)

        '        consulta.WheCampo(AlbSalida.ASA_idcentro, "=", MiMaletin.IdCentro.ToString)
        Dim sqlfac As String = ""
        If VaInt(LbId.Text) = 0 Then
            'sqlfac = "COALESCE(ASA_IdFactura,0) = 0 AND ASA_IDCENTRO=" + MiMaletin.IdCentro.ToString ' nueva
            sqlfac = "COALESCE(ASA_IdFactura,0) = 0 "
        Else
            sqlfac = "COALESCE(ASA_IdFactura,0) = " + LbId.Text
        End If
        Dim sql As String = consulta.SQL & vbCrLf & " AND " & sqlfac & vbCrLf
        sql = sql & " AND (ASA_TipoFC = 'F' OR (ASA_TipoFC = 'C' AND ASA_FechaValoracion > '" & VaDate("").ToString("dd/MM/yyyy") & "'))" & vbCrLf
        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)


        dt.Columns.Add("ImpGenero", GetType(Decimal)).SetOrdinal(6)
        dt.Columns.Add("ImpEnvases", GetType(Decimal)).SetOrdinal(7)
        dt.Columns.Add("GastosFra", GetType(Decimal)).SetOrdinal(8)


        Dim colSel As New DataColumn("S", GetType(Boolean))
        colSel.DefaultValue = False
        dt.Columns.Add(colSel)

        Dim colSelOriginal As New DataColumn("S_Original", GetType(Boolean))
        colSelOriginal.DefaultValue = False
        dt.Columns.Add(colSelOriginal)


        For Each row As DataRow In dt.Rows

            'Marcamos los que ya estén asociados a esta factura
            If VaInt(LbId.Text) > 0 Then
                If VaInt(row("IdFactura")) = VaInt(LbId.Text) Then
                    row("S") = True
                    row("S_Original") = True
                Else
                    row("S") = False
                    row("S_Original") = False
                End If
            End If

            'Calculamos importes de género, envases y gastos de factura
            row("ImpGenero") = AlbSalida.TotalGenero(row("IdAlbaran").ToString & "", True)
            row("ImpEnvases") = AlbSalida.TotalEnvases(row("IdValeEnvase").ToString & "")
            row("GastosFra") = AlbSalida.GastosFactura(row("IdAlbaran").ToString & "")

        Next


        GridAlbaranes.DataSource = dt
        AjustaColumnasAlbaranes()


        AñadeResumenCampo(GridViewAlbaranes, "ImpGenero", "{0:n2}")
        AñadeResumenCampo(GridViewAlbaranes, "ImpEnvases", "{0:n2}")
        AñadeResumenCampo(GridViewAlbaranes, "GastosFra", "{0:n2}")


        'Obtenemos los gastos de los albaranes de arriba
        consulta = New Cdatos.E_select
        consulta.SelCampo(AlbSalida_Gastos.ASG_id, "Id")
        consulta.SelCampo(AlbSalida_Gastos.ASG_idgasto, "Tipo")
        consulta.SelCampo(GastosComercio.GCO_Nombre, "Gasto", AlbSalida_Gastos.ASG_idgasto, GastosComercio.GCO_Idgasto)
        consulta.SelCampo(AlbSalida_Gastos.ASG_tipofc, "FC")
        consulta.SelCampo(AlbSalida_Gastos.ASG_importegastodivisa, "ImpGastoDivisa")
        consulta.SelCampo(AlbSalida_Gastos.ASG_importegastoeuros, "ImpGastoEuros")
        consulta.SelCampo(AlbSalida.ASA_idalbaran, "IdAlbaran", AlbSalida_Gastos.ASG_idalbaran, AlbSalida.ASA_idalbaran)
        consulta.WheCampo(AlbSalida.ASA_idcliente, "=", VaInt(TxDato_5.Text).ToString)
        consulta.WheCampo(AlbSalida.ASA_idcentro, "=", MiMaletin.IdCentro.ToString)

        sql = consulta.SQL & vbCrLf & " AND (COALESCE(ASA_IdFactura,0) = 0 OR COALESCE(ASA_IdFactura,0) = " & VaInt(LbId.Text) & ")" & vbCrLf
        sql = sql & " AND (ASA_TipoFC = 'F' OR (ASA_TipoFC = 'C' AND ASA_FechaValoracion > '" & VaDate("").ToString("dd/MM/yyyy") & "'))" & vbCrLf

        _DtGastos = AlbSalida_Gastos.MiConexion.ConsultaSQL(sql)



        CargaGastos()


    End Sub





    Private Sub CargaGastos()

        'Obtenemos los albaranes marcados
        Dim DcAlbaranesMarcados As New Dictionary(Of Integer, Integer)
        For indice As Integer = 0 To GridViewAlbaranes.RowCount - 1
            Dim row As DataRow = GridViewAlbaranes.GetDataRow(indice)
            If Not IsNothing(row) Then
                If row("S") = True Then
                    Dim IdAlbaran As Integer = VaInt(row("IdAlbaran"))
                    DcAlbaranesMarcados(IdAlbaran) = IdAlbaran
                End If
            End If
        Next


        acum = New Acumulador

        'Acumula
        For Each row As DataRow In _DtGastos.Rows

            Dim IdAlbaran As Integer = VaInt(row("IdAlbaran"))

            If DcAlbaranesMarcados.ContainsKey(IdAlbaran) Then

                Dim FC As String = (row("FC").ToString & "").Trim
                If (FC = "F" And rdbEnFactura.Checked) Or (FC = "C" And rdbComerciales.Checked) Then

                    Dim IdTipo As String = (row("Tipo").ToString & "").Trim
                    Dim Gasto As String = (row("Gasto").ToString & "").Trim
                    Dim ImpGasto As Decimal = 0
                    If rdbEnFactura.Checked Then
                        ImpGasto = VaDec(row("ImpGastoDivisa"))
                    ElseIf rdbComerciales.Checked Then
                        ImpGasto = VaDec(row("ImpGastoEuros"))
                    End If

                    Dim stClave As New stClaves_GastosAlbaran(IdTipo, Gasto, FC)
                    Dim stDatos As New stDatos_GastosAlbaran(ImpGasto)

                    acum.Suma(stClave, stDatos)

                End If

            End If

        Next


        Dim dtResultado As DataTable = acum.DataTable

        GridGastos.DataSource = dtResultado
        AjustaColumnasGastos()

        AñadeResumenCampo(GridViewGastos, "ImpGasto", "{0:n2}")


    End Sub


    Private Sub AjustaColumnasAlbaranes()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewAlbaranes.Columns
            Select Case c.FieldName.Trim.ToUpper
                Case "IDALBARAN", "IDFACTURA", "IDVALEENVASE", "S_ORIGINAL"
                    c.Visible = False
            End Select
        Next

        GridViewAlbaranes.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewAlbaranes.Columns
            Select Case c.FieldName.Trim.ToUpper
                Case "CAMBIO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.000000"
                Case "IMPGENERO", "IMPENVASES", "GASTOSFRA"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                Case "S"
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.Width = 20
                Case "REFERENCIA"
                    c.Caption = "Nº Cta Venta"
            End Select
        Next

    End Sub


    Private Sub AjustaColumnasGastos()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewGastos.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDALBARAN", "ID"
                    c.Visible = False
            End Select
        Next

        GridViewGastos.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewGastos.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IMPGASTO"
                    If rdbComerciales.Checked Then
                        c.Caption = "ImpGastoEuros"
                    ElseIf rdbEnFactura.Checked Then
                        c.Caption = "ImpGastoDivisa"
                    End If
            End Select
        Next


    End Sub


    Private Sub GridViewAlbaranes_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridViewAlbaranes.RowCellClick

        If NuevoRegistro Or Modificando Then

            If e.Column.FieldName.Trim.ToUpper = "S" Then

                Dim row As DataRow = GridViewAlbaranes.GetDataRow(e.RowHandle)
                If Not IsNothing(row) Then
                    If row("S") = True Then
                        row("S") = False
                    Else
                        row("S") = True
                    End If
                End If

                CargaGastos()
                CalculoTotales(True)

                ClGrid1.GridView.Focus()
                ClGrid1.GridView.FocusedRowHandle = ClGrid1.GridView.RowCount - 1

            End If

        End If


    End Sub



    Private Sub BtSelNinguno_Click(sender As System.Object, e As System.EventArgs) Handles BtSelNinguno.Click

        For indice As Integer = 0 To GridViewAlbaranes.RowCount - 1
            Dim row As DataRow = GridViewAlbaranes.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = False
            End If
        Next
        CargaGastos()
        CalculoTotales(True)

    End Sub

    Private Sub BtSelTodos_Click(sender As System.Object, e As System.EventArgs) Handles BtSelTodos.Click
        For indice As Integer = 0 To GridViewAlbaranes.RowCount - 1
            Dim row As DataRow = GridViewAlbaranes.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = True
            End If
        Next
        CargaGastos()
        CalculoTotales(True)
    End Sub


    Private Sub TxDato_4_Valida(edicion As System.Boolean) Handles TxDato_4.Valida

        If edicion Then

            If TxDato_5.Text = "" Then
                TxDato_5.Text = TxDato_4.Text
            End If

            Clientes.LeerId(TxDato_4.Text)

            LbNumeroRegistro.Text = Clientes.CLI_NumeroRegistro.Valor


            If TiposClientes.LeerId(Clientes.CLI_IdTipo.Valor) = True Then

                If VaInt(TxDato_1.Text) = 0 Then
                    If TiposClientes.TPC_clienteinterno.Valor = "S" Then
                        TxDato_0.Text = "I" + Format(MiMaletin.IdPuntoVenta, "00")
                    End If
                End If

                If TxRegimenIva.Text = "" Then
                    TxRegimenIva.Text = TiposClientes.TPC_idtipoiva.Valor
                    TxRegimenIva.Validar(True)
                End If

            End If


            CargaIva(TxDato_4.Text)


            If TxDato_6.Text.Trim = "" Then
                TxDato_6.Text = Clientes.CLI_Iddivisa.Valor
                TxDato_6.Validar(edicion)
            End If

        End If

    End Sub


    Private Sub CargaIva(IdCliente As String)

        Dim Iva1 As Decimal = 0
        Dim Iva2 As Decimal = 0
        Dim Iva3 As Decimal = 0

        Dim Re1 As Decimal = 0
        Dim Re2 As Decimal = 0
        Dim Re3 As Decimal = 0

        Dim CtaVentas As String = ""
        Dim CtaEnvases As String = ""
        Dim CtaVarios As String = ""


        Dim Idpais As String = ""
        Dim IdDivisa As String = ""

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Clientes.CLI_IdTipo, "IdTipo")
        consulta.SelCampo(Clientes.CLI_Iddivisa, "IdDivisa")
        consulta.SelCampo(Clientes.CLI_IdPais, "Idpais")
        consulta.SelCampo(TiposClientes.TPC_idtipoiva, "IdTipoIva", Clientes.CLI_IdTipo, TiposClientes.TPC_idtipo)
        consulta.SelCampo(TiposClientes.TPC_exentoiva, "ExentoIVA")
        consulta.SelCampo(TiposClientes.TPC_recequivalencia, "RecargoEq")
        consulta.SelCampo(TiposClientes.TPC_ctaventas, "CtaVentas")
        consulta.SelCampo(TiposClientes.TPC_ctaenvases, "CtaEnvases")
        consulta.SelCampo(TiposClientes.TPC_ctavarios, "CtaVarios")
        consulta.WheCampo(Clientes.CLI_Codigo, "=", VaInt(IdCliente))

        Dim dt As DataTable = Clientes.MiConexion.ConsultaSQL(consulta.SQL)
        If dt.Rows.Count > 0 Then

            Dim row As DataRow = dt.Rows(0)
            Dim ExentoIVA As String = (row("ExentoIVA").ToString & "").Trim.ToUpper
            Dim RecargoEq As String = (row("RecargoEq").ToString & "").Trim.ToUpper



            Dim dtIva As DataTable = TipoIva.Tabla
            For Each rw In dtIva.Rows
                Select Case rw("id").ToString


                    Case "1"
                        If ExentoIVA <> "S" Then Iva1 = VaDec(rw("iva"))
                        If RecargoEq = "S" Then Re1 = VaDec(rw("re"))

                    Case "2"
                        If ExentoIVA <> "S" Then Iva2 = VaDec(rw("iva"))
                        If RecargoEq = "S" Then Re2 = VaDec(rw("re"))

                    Case "3"
                        If ExentoIVA <> "S" Then Iva3 = VaDec(rw("iva"))
                        If RecargoEq = "S" Then Re3 = VaDec(rw("re"))

                End Select

            Next


            CtaVentas = row("ctaventas").ToString
            CtaEnvases = row("ctaenvases").ToString
            CtaVarios = row("ctavarios").ToString

            Idpais = row("idpais").ToString
            IdDivisa = row("iddivisa").ToString

        End If


        TxDato_52.Text = CtaVarios
        TxDato_40.Text = Iva1.ToString("#,##0.00")
        TxDato_41.Text = Iva1.ToString("#,##0.00") ' el mismo iva para envases
        TxDato_42.Text = Iva3.ToString("#,##0.00")
        TxDato_43.Text = Re1.ToString("#,##0.00")
        TxDato_44.Text = Re2.ToString("#,##0.00")
        TxDato_45.Text = Re3.ToString("#,##0.00")
        TxDato_3.Text = Idpais
        TxDato_6.Text = IdDivisa

        TxDato_40.Validar(True)
        TxDato_41.Validar(True)
        TxDato_42.Validar(True)
        TxDato_43.Validar(True)
        TxDato_44.Validar(True)
        TxDato_45.Validar(True)
        TxDato_3.Validar(True)
        TxDato_6.Validar(True)


        CalculaCuotas()


    End Sub


    Private Sub CalculaCuotas()

        LbCuotaGen.Text = (VaDec(LbTGeneros.Text) * VaDec(TxDato_40.Text) / 100).ToString("#,##0.00")
        LbCuotaReGen.Text = (VaDec(LbTGeneros.Text) * VaDec(TxDato_43.Text) / 100).ToString("#,##0.00")

        LbCuotaEnv.Text = (VaDec(LbTEnvases.Text) * VaDec(TxDato_41.Text) / 100).ToString("#,##0.00")
        LbCuotaReEnv.Text = (VaDec(LbTEnvases.Text) * VaDec(TxDato_44.Text) / 100).ToString("#,##0.00")

        LbCuotaVar.Text = (VaDec(LbTVarios.Text) * VaDec(TxDato_42.Text) / 100).ToString("#,##0.00")
        LbCuotaReVar.Text = (VaDec(LbTVarios.Text) * VaDec(TxDato_45.Text) / 100).ToString("#,##0.00")

    End Sub


    Private Sub CalculaTotalesFactura()

        Dim TotalDivisa As Decimal = VaDec(LbTGeneros.Text) + VaDec(LbTEnvases.Text) + VaDec(LbTVarios.Text)
        TotalDivisa = TotalDivisa + VaDec(LbCuotaGen.Text) + VaDec(LbCuotaEnv.Text) + VaDec(LbCuotaVar.Text)
        TotalDivisa = TotalDivisa + VaDec(LbCuotaReGen.Text) + VaDec(LbCuotaReEnv.Text) + VaDec(LbCuotaReVar.Text)
        TotalDivisa = TotalDivisa - VaDec(TxSuplido.Text)

        Dim cambio As Decimal = VaDec(TxDato_7.Text)

        LbTotDivisa.Text = TotalDivisa.ToString("#,##0.00")
        LbTotEuros.Text = (TotalDivisa * cambio).ToString("#,##0.00")
        LbCobrado.Text = CalculaCobrado.ToString("#,##0.00")

    End Sub


    Private Function CalculaCobrado() As Decimal

        Dim res As Decimal = 0


        If VaDec(LbId.Text) > 0 Then

            Dim sql As String = "SELECT SUM(CBL_ImporteCobradoDivisa) as Cobrado FROM CobrosLineas WHERE CBL_IdFactura = " & LbId.Text
            Dim dt As DataTable = Facturas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim row As DataRow = dt.Rows(0)
                    res = VaDec(row("Cobrado"))

                End If
            End If

        End If


        Return res

    End Function


    Private Sub TxDato_40_Valida(edicion As System.Boolean) Handles TxDato_40.Valida
        'If edicion Then
        'TODO: Comprobar decimales
        LbCuotaGen.Text = (VaDec(LbTGeneros.Text) * VaDec(TxDato_40.Text) / 100).ToString("#,##0.00")
        'End If
    End Sub

    Private Sub TxDato_41_Valida(edicion As System.Boolean) Handles TxDato_41.Valida
        'If edicion Then
        'TODO: Comprobar decimales
        LbCuotaEnv.Text = (VaDec(LbTEnvases.Text) * VaDec(TxDato_41.Text) / 100).ToString("#,##0.00")
        'End If
    End Sub

    Private Sub TxDato_42_Valida(edicion As System.Boolean) Handles TxDato_42.Valida
        'If edicion Then
        'TODO: Comprobar decimales
        LbCuotaVar.Text = (VaDec(LbTVarios.Text) * VaDec(TxDato_42.Text) / 100).ToString("#,##0.00")
        'End If
    End Sub

    Private Sub TxDato_43_Valida(edicion As System.Boolean) Handles TxDato_43.Valida
        'If edicion Then
        'TODO: Comprobar decimales
        LbCuotaReGen.Text = (VaDec(LbTGeneros.Text) * VaDec(TxDato_43.Text) / 100).ToString("#,##0.00")
        'End If
    End Sub

    Private Sub TxDato_44_Valida(edicion As System.Boolean) Handles TxDato_44.Valida
        'If edicion Then
        'TODO: Comprobar decimales
        LbCuotaReEnv.Text = (VaDec(LbTEnvases.Text) * VaDec(TxDato_44.Text) / 100).ToString("#,##0.00")
        'End If
    End Sub

    Private Sub TxDato_45_Valida(edicion As System.Boolean) Handles TxDato_45.Valida
        'If edicion Then
        'TODO: Comprobar decimales
        LbCuotaReVar.Text = (VaDec(LbTVarios.Text) * VaDec(TxDato_45.Text) / 100).ToString("#,##0.00")
        'End If
    End Sub


    Private Sub LbTGeneros_TextChanged(sender As System.Object, e As System.EventArgs) Handles LbTGeneros.TextChanged
        LbCuotaGen.Text = (VaDec(LbTGeneros.Text) * VaDec(TxDato_40.Text) / 100).ToString("#,##0.00")
        LbCuotaReGen.Text = (VaDec(LbTGeneros.Text) * VaDec(TxDato_43.Text) / 100).ToString("#,##0.00")
        CalculaTotalesFactura()
    End Sub

    Private Sub LbTEnvases_TextChanged(sender As System.Object, e As System.EventArgs) Handles LbTEnvases.TextChanged
        LbCuotaEnv.Text = (VaDec(LbTEnvases.Text) * VaDec(TxDato_41.Text) / 100).ToString("#,##0.00")
        LbCuotaReEnv.Text = (VaDec(LbTEnvases.Text) * VaDec(TxDato_44.Text) / 100).ToString("#,##0.00")
        CalculaTotalesFactura()
    End Sub

    Private Sub LbTVarios_TextChanged(sender As System.Object, e As System.EventArgs) Handles LbTVarios.TextChanged
        LbCuotaVar.Text = (VaDec(LbTVarios.Text) * VaDec(TxDato_42.Text) / 100).ToString("#,##0.00")
        LbCuotaReVar.Text = (VaDec(LbTVarios.Text) * VaDec(TxDato_45.Text) / 100).ToString("#,##0.00")
        CalculaTotalesFactura()
    End Sub

    Private Sub LbCuotaGen_TextChanged(sender As System.Object, e As System.EventArgs) Handles LbCuotaGen.TextChanged
        CalculaTotalesFactura()
    End Sub

    Private Sub LbCuotaEnv_TextChanged(sender As System.Object, e As System.EventArgs) Handles LbCuotaEnv.TextChanged
        CalculaTotalesFactura()
    End Sub

    Private Sub LbCuotaVar_TextChanged(sender As System.Object, e As System.EventArgs) Handles LbCuotaVar.TextChanged
        CalculaTotalesFactura()
    End Sub

    Private Sub LbCuotaReGen_TextChanged(sender As System.Object, e As System.EventArgs) Handles LbCuotaReGen.TextChanged
        CalculaTotalesFactura()
    End Sub

    Private Sub LbCuotaReEnv_TextChanged(sender As System.Object, e As System.EventArgs) Handles LbCuotaReEnv.TextChanged
        CalculaTotalesFactura()
    End Sub

    Private Sub LbCuotaReVar_TextChanged(sender As System.Object, e As System.EventArgs) Handles LbCuotaReVar.TextChanged
        CalculaTotalesFactura()
    End Sub

    Private Sub TxDato_7_Valida(edicion As System.Boolean) Handles TxDato_7.Valida
        LbTotEuros.Text = (VaDec(TxDato_7.Text) * VaDec(LbTotDivisa.Text)).ToString("#,##0.00")
    End Sub



    Private Sub rdbEnFactura_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbEnFactura.CheckedChanged
        If Not IsNothing(_DtGastos) Then CargaGastos()
    End Sub

    Private Sub rdbComerciales_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbComerciales.CheckedChanged
        If Not IsNothing(_DtGastos) Then CargaGastos()
    End Sub

    Private Sub chkFacturarEnvases_Click(sender As System.Object, e As System.EventArgs)

        If NuevoRegistro Or Modificando Then
            CalculoTotales(True)
        End If


    End Sub

    Private Sub LbAsiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbAsiento.Click
        If LbAsiento.Text <> "" Then

            Dim IdAsientoNET As Integer = VaInt(Facturas.FRA_idasientoNet.Valor)
            Dim ListaAsientos As New List(Of Integer)
            ListaAsientos.Add(IdAsientoNET)
            Dim F As New FrmConsultaVisuAsiento(ListaAsientos, False)
            F.ShowDialog()

        End If
    End Sub

    Private Sub TxDato_4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_4.TextChanged

    End Sub

    Private Sub BAnular_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub TxDato_6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_6.TextChanged

    End Sub

    Private Sub TxDato_6_Valida(ByVal edicion As Boolean) Handles TxDato_6.Valida

        If edicion = True Then

            If VaInt(TxDato_6.Text) = 0 Then
                TxDato_6.Text = "1"
                TxDato_7.Text = "1"
            End If

            Dim Moneda As New E_Moneda(Idusuario, cn)
            If Moneda.LeerId(TxDato_6.Text) Then
                TxDato_7.Text = VaDec(Moneda.MON_Cambio.Valor).ToString("#,##0.000000")
                TxDato_7.Validar(True)
            End If


        End If
    End Sub

    Private Sub TxDato_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_3.TextChanged

    End Sub

    Private Sub TxDato_3_Valida(ByVal edicion As Boolean) Handles TxDato_3.Valida
        If edicion = True Then
            If VaInt(TxDato_3.Text) = 0 Then
                TxDato_3.Text = "1"

            End If
        End If
    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaDec(LbId.Text) > 0 Then
            C1_ImprimirFacturaComercializacion(LbId.Text, TipoImpresion.Preliminar)
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaDec(LbId.Text) > 0 Then
            C1_ImprimirFacturaComercializacion(LbId.Text, TipoImpresion.ImpresoraPorDefecto)
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar3()

        If VaDec(LbId.Text) > 0 Then
            C1_EnviarFacturaComercializacion(LbId.Text)
        End If

    End Sub


    Private Sub TxDato_0_Valida(edicion As System.Boolean) Handles TxDato_0.Valida
        If edicion Then

            If TxDato_0.Text.Trim <> "" Then

                'Dim regexNumeros As New System.Text.RegularExpressions.Regex("[0-9]")
                'If regexNumeros.IsMatch(TxDato_0.Text) Then
                '    If VaInt(TxDato_0.Text) < 10 Then
                '        TxDato_0.Text = VaInt(TxDato_0.Text).ToString("00")
                '    End If
                'End If

                If IsNumeric(TxDato_0.Text) Then
                    If VaInt(TxDato_0.Text) > 0 And VaInt(TxDato_0.Text) < 10 Then
                        TxDato_0.Text = VaInt(TxDato_0.Text).ToString("00")
                    ElseIf TxDato_0.Text.Trim = "0" Then
                        TxDato_0.Text = "00"
                    End If
                End If

            End If

        End If
    End Sub

    Private Sub TxSuplido_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxSuplido.TextChanged

    End Sub

    Private Sub TxSuplido_Valida(edicion As Boolean) Handles TxSuplido.Valida
        CalculaTotalesFactura()
    End Sub


    Private Sub TxDato_2_Valida(edicion As System.Boolean) Handles TxDato_2.Valida

        If edicion = True Then
            Dim E As String = ControlaFecha(TxDato_2.Text)
            If E <> "" Then
                MsgBox(E)
                TxDato_2.MiError = True
            End If
        End If

    End Sub


    Private Sub btVerCobros_Click(sender As System.Object, e As System.EventArgs) Handles btVerCobros.Click

        If VaDec(LbId.Text) > 0 And VaDec(LbCobrado.Text) <> 0 Then

            Dim sql As String = "SELECT CBL_IdCobro as IdCobro, COB_IdCentro as CE, COB_Ejercicio as Campa, COB_NumeroCobro as Cobro, COB_IdCliente as CodCli, CLI_Nombre as Cliente," & vbCrLf
            sql = sql & " SUM(CBL_ImporteCobradoDivisa) as ImpDivisa, SUM(CBL_ImporteCobradoDivisa * COALESCE(CBL_Cambio,1)) as ImpEuros" & vbCrLf
            sql = sql & " FROM CobrosLineas" & vbCrLf
            sql = sql & " LEFT JOIN Cobros ON CBL_IdCobro = COB_IdCobro" & vbCrLf
            sql = sql & " LEFT JOIN Clientes ON COB_IdCliente = CLI_IdCliente" & vbCrLf
            sql = sql & " WHERE CBL_IdFactura = " & LbId.Text & vbCrLf
            sql = sql & " GROUP BY CBL_IdCobro, COB_IdCentro, COB_Ejercicio, COB_NumeroCobro, COB_IdCliente, CLI_Nombre" & vbCrLf


            Dim dt As DataTable = Cobros.MiConexion.ConsultaSQL(sql)

            Dim lst As New List(Of Parametros)
            lst.Add(New Parametros("IdCobro", False, "", -1))
            lst.Add(New Parametros("CE", False, "", 30))
            lst.Add(New Parametros("Campa", False, "", 50))
            lst.Add(New Parametros("Cobro", False, "", 100))
            lst.Add(New Parametros("CodCli", False, "", 50))
            lst.Add(New Parametros("Cliente", False, "", 340))
            lst.Add(New Parametros("ImpDivisa", False, "{0:n2}", 100))
            lst.Add(New Parametros("ImpEuros", False, "{0:n2}", 100))


            Dim f As New FrConsultaGenerica(dt, lst, "Cobros factura")
            f.ShowDialog()


        End If

    End Sub

End Class