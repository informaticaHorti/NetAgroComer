Imports DevExpress.XtraEditors


Public Class FrmFacturaEnvases
    Inherits FrMantenimiento


    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Facturas As New E_Facturas(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim TipoIvaRepercutido As New E_TipoIvaRepercutido(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim Cuentas As New E_Cuentas(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim Asientos As New E_Asientos(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim ValeEnvases_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim ValeEnvase As New E_ValeEnvases(Idusuario, cn)
    Dim TiposClientes As New E_Tiposclientes(Idusuario, cn)
    Dim TipoIva As New E_tiposiva(Idusuario, cn)


    Dim IdAsientonet As Integer
    Dim _DtGastos As DataTable = Nothing


   

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()
        EntidadFrm = Facturas


        Dim lc As New List(Of Object)
        ListaControles = lc



        CampoClave = 1 ' ultimo campo de la clave

        ParamTx(TxDato_0, Facturas.FRA_serie, Lb_1)
        ParamTx(TxDato_1, Facturas.FRA_factura, Lb_1, True)
        TxDato_1.Autonumerico = True

        ParamTx(TxDato_2, Facturas.FRA_fecha, Lb_2, True)
        ParamTx(TxDato_5, Facturas.FRA_idcliente, Lb_4, True)
        ParamTx(TxIdRegimenIva, Facturas.FRA_IdTipoIva, LbRegimenIva, True)


        AsociarControles(TxDato_1, BtBuscaAlbaran, Facturas.btBusca, Facturas)
        AsociarControles(TxIdRegimenIva, BtBuscaRegimenIva, TipoIvaRepercutido.btBusca, TipoIvaRepercutido, TipoIvaRepercutido.Nombre, LbNomRegimenIva)

        BtBuscaAlbaran.CL_Filtro = "AC='E'"
        BtBuscaAlbaran.CL_DevuelveCampo = "IdFactura"


        ParamTx(TxDato_41, Facturas.FRA_Iva2, Lb10, False)
        ParamTx(TxDato_44, Facturas.FRA_Re2, Lb26, False)
        'ParamTx(TxDato_51, Facturas.FRA_cuentaventas2, Lb30, False, Cdatos.TiposCampo.Cuenta)
        'ParamTx(TxObsAeat, Facturas.FRA_ObsAeat, Nothing, False)
        'ParamTx(TxFechaDevengo, Facturas.FRA_FechaDevengo, LbFechaDevengo, False)


        AsociarControles(TxDato_5, BtBuscaCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lbnom_4)
        'AsociarControles(TxDato_51, BtBusca_51, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lb_51)
        'AsociarControles(TxDato_0, BtBuscaSerie, SeriesFacturas.btBusca, SeriesFacturas)

        'FiltroEntidad.Add(Facturas.FRA_idpuntoventa.NombreCampo, MiMaletin.IdPuntoVenta.ToString)
        'FiltroEntidad.Add(Facturas.FRA_campa.NombreCampo, MiMaletin.EjercicioCtb.ToString)
        FiltroEntidad.Add(Facturas.FRA_campa.NombreCampo, MiMaletin.Ejercicio.ToString)


        BotonesAvance1.Mientidad = Facturas
        BotonesAvance1.CampoOrden = Facturas.FRA_idfactura
        BotonesAvance1.Formulario = Me
        BotonesAvance1.Filtro = "FRA_campa=" + MiMaletin.Ejercicio.ToString + " AND FRA_Serie='" + TxDato_0.Text + "' AND FRA_idempresa = '" + MiMaletin.IdEmpresaCTB.ToString + "' AND FRA_AlhCom = 'E'"

    End Sub


    Private Sub FrmFacturaEnvases_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        GridViewAlbaranes.OptionsView.ShowGroupPanel = False
        GridViewAlbaranes.OptionsBehavior.Editable = False

        GridView.OptionsView.ShowGroupPanel = False
        GridView.OptionsBehavior.Editable = False


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
            i = Facturas.LeerFac(MiMaletin.IdEmpresaCTB, VaInt(Lbejer.Text), TxDato_0.Text, VaInt(TxDato_1.Text))
            If i > 0 Then

                LbId.Text = i.ToString
                If Facturas.FRA_alhcom.Valor <> "E" Then
                    MsgBox("Esta factura no es de envases")
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


    Private Sub CargaLineasGrid()

        MarcaAlbaranes()
        CalculoTotales()

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


    Private Sub CalculoTotales()

        Dim TotalEnvases As Decimal = 0
        Dim TotalIVA As Decimal = 0
        Dim TotalCuotaRe As Decimal = 0

        If Not NuevoRegistro And Not Modificando Then

            'Si no está modificando y no es un registro nuevo, usamos las bases de la factura
            TotalEnvases = VaDec(Facturas.FRA_Base2.Valor)
            TotalIVA = VaDec(Facturas.FRA_Cuota2.Valor)
            TotalCuotaRe = VaDec(Facturas.FRA_CuotaRe2.Valor)

        Else

            For indice As Integer = 0 To GridViewAlbaranes.RowCount - 1
                Dim row As DataRow = GridViewAlbaranes.GetDataRow(indice)
                If Not IsNothing(row) Then

                    If row("S") = True Then
                        TotalEnvases = TotalEnvases + VaDec(row("ImpEnvases"))
                    End If

                End If
            Next

            TotalIVA = TotalEnvases * VaDec(TxDato_41.Text) / 100
            TotalCuotaRe = TotalEnvases * VaDec(TxDato_44.Text) / 100

        End If


        Dim TotalEuros As Decimal = TotalEnvases + TotalIVA + TotalCuotaRe


        LbTEnvases.Text = TotalEnvases.ToString("#,##0.00")
        LbCuotaEnv.Text = TotalIVA.ToString("#,##0.00")
        LbCuotaReEnv.Text = TotalCuotaRe.ToString("#,##0.00")
        LbTotEuros.Text = TotalEuros.ToString("#,##0.00")


    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()


        PintaPuntoVenta(Facturas.FRA_idpuntoventa.Valor, Facturas.FRA_campa.Valor, Facturas.FRA_idasientoNet.Valor)
        Lbejer.Text = Facturas.FRA_campa.Valor

        ' llenar el grid
        CargaLineasGrid()
        CargarGridCobros()
        CargaAlbaranes()

        BtSelNinguno.Enabled = False
        BtSelTodos.Enabled = False

    End Sub


    Private Sub PintaPuntoVenta(ByVal idpv As String, ByVal ejer As String, ByVal idasiento As String)

        IdAsientonet = VaInt(idasiento)

        If VaInt(idasiento) > 0 Then
            LbAsiento.Text = Asientos.NumeroAsiento(idasiento)

            ''20161213
            'Dim Motivo As String = ""
            'If Asientos.Bloqueado(IdAsientonet.ToString, Motivo) = True Then

            '    LbAsiento.ForeColor = Color.Red
            '    tt.SetToolTip(LbAsiento, Motivo)

            '    'If ProgramaAuditoria = "N" Then
            '    BAnular.Visible = False
            '    BModificar.Visible = False
            '    'Else
            '    '   BAnular.Visible = True
            '    '   BModificar.Visible = True
            '    'End If

            'Else
            '    LbAsiento.ForeColor = Color.Green
            '    BAnular.Visible = True
            '    BModificar.Visible = True
            'End If

        End If

        Lbejer.Text = ejer

    End Sub


    Private Sub CargarGridCobros()

        BModificar.Visible = True
        BAnular.Visible = True

        If VaInt(LbId.Text) > 0 Then

            GridCobros.DataSource = Nothing
            Dim Cobros_Lineas As New E_CobrosLineas(Idusuario, cn)
            Dim cobros As New E_Cobros(Idusuario, cn)

            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(Cobros_Lineas.CBL_IdCobro, "IdCobro")
            consulta.SelCampo(cobros.COB_NumeroCobro, "Cobro", Cobros_Lineas.CBL_IdCobro)
            consulta.SelCampo(cobros.COB_FechaCobro, "FechaCobro")
            consulta.SelCampo(cobros.COB_CobradoEuros, "ImporteEuros")
            consulta.WheCampo(Cobros_Lineas.CBL_IdFactura, "=", LbId.Text)

            Dim dt As DataTable = Cobros_Lineas.MiConexion.ConsultaSQL(consulta.SQL)

            If Not IsNothing(dt) And dt.Rows.Count > 0 Then

                GridCobros.DataSource = dt

                'If ProgramaAuditoria = "N" Then
                BModificar.Visible = False
                BAnular.Visible = False
                'End If


            End If

            AjustaGridCobros()

        End If

    End Sub


    Private Sub AjustaGridCobros()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView.Columns
            Select Case c.FieldName.Trim.ToUpper
                Case "IDCOBRO"
                    c.Visible = False
            End Select
        Next

        GridView.BestFitColumns()

    End Sub


    Private Sub CargaAlbaranes()


        'TODO: Guardar cambios al guardar
        'TODO: MUCHO OJO!!!!! Al cambiar de cliente albaranes, habrá que quitar los que estaban asociados del otro cliente
        'TODO: Primero borramos todos y después actualizamos??

        Dim Clientes As New E_Clientes(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(ValeEnvases_Lineas.VEL_Id, "IdLinea")
        consulta.SelCampo(ValeEnvase.VEV_Numero, "Vale", ValeEnvases_Lineas.VEL_idvale)
        'consulta.SelCampo(ValeEnvase.VEV_Idvale, "Idvale")
        consulta.SelCampo(ValeEnvase.VEV_Idcentro, "CE")
        consulta.SelCampo(ValeEnvase.VEV_Fecha, "Fecha")
        consulta.SelCampo(ValeEnvase.VEV_Referencia, "Referencia")
        consulta.SelCampo(ValeEnvase.VEV_Concepto, "Concepto")
        consulta.SelCampo(ValeEnvases_Lineas.VEL_idenvase, "IdEnvase")
        consulta.SelCampo(ValeEnvases_Lineas.VEL_retira, "Retira")
        consulta.SelCampo(Envases.ENV_Nombre, "Envase", ValeEnvases_Lineas.VEL_idenvase)
        Dim oImpEnvases As New Cdatos.bdcampo("@VEL_Retira * VEL_PrecioFianza", Cdatos.TiposCampo.Importe, 18, 2)
        consulta.SelCampo(oImpEnvases, "ImpEnvases")
        consulta.SelCampo(ValeEnvases_Lineas.VEL_IdFacturaEnvase, "IdFactura")
        consulta.WheCampo(ValeEnvase.VEV_Codigo, "=", VaInt(TxDato_5.Text).ToString)
        consulta.WheCampo(ValeEnvase.VEV_TipoSujeto, "=", "C")

        Dim sql As String = consulta.SQL & vbCrLf & " AND (COALESCE(VEL_IdFacturaEnvase,0) = 0 OR COALESCE(VEL_IdFacturaEnvase,0) = " & VaInt(LbId.Text) & ")" & vbCrLf
        sql = sql + "AND  (VEV_Operacion = 'CC' OR VEV_Operacion = 'SC') " & vbCrLf
        sql = sql & " AND VEL_TipoEnvase = '" & E_FianzasEnvases.TipoFacturacion.FacturarAparte & "'" & vbCrLf
        sql = sql & " ORDER BY VEV_Fecha, VEL_Id" & vbCrLf


        Dim dt As DataTable = ValeEnvase.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

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
                'row("ImpEnvases") = TotalEnvases(row("IdVale").ToString & "")

            Next

            ' DEBEMOS FILTRAR SOLO LOS QUE TENGAN IMPORTE ENVASES PARA FACTURAR

        End If
        

        GridAlbaranes.DataSource = dt
        AjustaColumnasAlbaranes()


        AñadeResumenCampo(GridViewAlbaranes, "ImpEnvases", "{0:n2}")

    End Sub


    'Private Function TotalEnvases(ByVal IdValeEnvase As String) As Decimal

    '    Dim total As Decimal = 0

    '    If VaInt(IdValeEnvase) > 0 Then

    '        Dim sql As String = "SELECT SUM(VEL_RETIRA * VEL_PRECIORETIRA) - SUM(VEL_ENTREGA * VEL_PRECIOENTREGA) AS ienvases FROM valeenvases_lineas where VEL_IDVALE=" + IdValeEnvase
    '        Dim dte As DataTable = ValeEnvase.MiConexion.ConsultaSQL(sql)

    '        If Not dte Is Nothing Then
    '            If dte.Rows.Count > 0 Then
    '                total = VaDec(dte.Rows(0)("ienvases"))
    '            End If
    '        End If

    '    End If


    '    Return total

    'End Function


    Private Sub AjustaColumnasAlbaranes()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewAlbaranes.Columns
            Select Case c.FieldName.Trim.ToUpper
                Case "IDALBARAN", "IDFACTURA", "IDVALEENVASE", "S_ORIGINAL", "IDENVASE", "IDLINEA"
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
            End Select
        Next

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        BModificar.Visible = True
        BAnular.Visible = True

        'PintaPuntoVenta(MiMaletin.IdPuntoVenta, MiMaletin.EjercicioCtb.ToString, "")
        'Lbejer.Text = MiMaletin.EjercicioCtb

        PintaPuntoVenta(MiMaletin.IdPuntoVenta, MiMaletin.Ejercicio.ToString, "")
        Lbejer.Text = MiMaletin.Ejercicio.ToString

        IdAsientonet = 0
        LbAsiento.Text = ""
        tt.SetToolTip(LbAsiento, "")
        GridAlbaranes.DataSource = Nothing
        GridCobros.DataSource = Nothing

        'Por defecto, serie 10
        ' TxDato_0.Text = "10"


        _DtGastos = Nothing

    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If CDate(Facturas.FRA_fecha.Valor) < MiMaletin.FechaCtbIva Then
            MsgBox("Fecha contabilidad bloqueada")
            Exit Sub
        End If


        MyBase.BModificar_Click(sender, e)

        BtSelNinguno.Enabled = True
        BtSelTodos.Enabled = True

    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If CDate(Facturas.FRA_fecha.Valor) < MiMaletin.FechaCtbIva Then
            MsgBox("Fecha contabilidad bloqueada")
            Exit Sub
        End If

        MyBase.BAnular_Click(sender, e)

    End Sub


    Private Sub GridViewAlbaranes_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridViewAlbaranes.RowCellClick

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

                CalculoTotales()

            End If

        End If

    End Sub


    Private Sub BtSelNinguno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSelNinguno.Click

        For indice As Integer = 0 To GridViewAlbaranes.RowCount - 1
            Dim row As DataRow = GridViewAlbaranes.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = False
            End If
        Next

        CalculoTotales()

    End Sub


    Private Sub BtSelTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSelTodos.Click

        For indice As Integer = 0 To GridViewAlbaranes.RowCount - 1
            Dim row As DataRow = GridViewAlbaranes.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = True
            End If
        Next

        CalculoTotales()

    End Sub


    Public Overrides Sub Guardar()

        If LbId.Text = "+" Then
            Facturas.FRA_idfactura.Valor = Facturas.MaxId()
            LbId.Text = Facturas.FRA_idfactura.Valor
            If TxDato_1.Text = "+" Then
                TxDato_1.Text = Facturas.MaxIdCampa(MiMaletin.IdEmpresaCTB, VaInt(Lbejer.Text), TxDato_0.Text)
            End If
        End If


        Facturas.FRA_idpuntoventa.Valor = MiMaletin.IdPuntoVenta.ToString
        Facturas.FRA_campa.Valor = Lbejer.Text


        Facturas.FRA_Base2.Valor = VaDec(LbTEnvases.Text)

        Facturas.FRA_Cuota2.Valor = VaDec(LbCuotaEnv.Text)

        Facturas.FRA_CuotaRe2.Valor = VaDec(LbCuotaReEnv.Text)
        Facturas.FRA_clientealbaranes.Valor = TxDato_5.Text

        Dim Clientes As New E_Clientes(Idusuario, cn)
        If Clientes.LeerId(TxDato_5.Text) Then
            Facturas.FRA_cdpais.Valor = Clientes.CLI_IdPais.Valor
        Else
            Facturas.FRA_cdpais.Valor = "1"
        End If

        Facturas.FRA_cddivisa.Valor = "1"
        Facturas.FRA_valorcambio.Valor = "1"


        Facturas.FRA_totalfactura.Valor = VaDec(LbTotEuros.Text)
        Facturas.FRA_valorcambio.Valor = "1"

        Facturas.FRA_tipofactura.Valor = "1"
        Facturas.FRA_alhcom.Valor = "E"
        Facturas.FRA_idcentro.Valor = MiMaletin.IdCentro.ToString
        Facturas.FRA_idempresa.Valor = MiMaletin.IdEmpresaCTB.ToString


        MyBase.Guardar()

    End Sub


    Public Overrides Sub DespuesdeGuardar()

        Dim TxError As String = ""
        MyBase.DespuesdeGuardar()


        Dim ValeEnvases_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)

        For indice As Integer = 0 To GridViewAlbaranes.RowCount - 1

            Dim row As DataRow = GridViewAlbaranes.GetDataRow(indice)
            If Not IsNothing(row) Then

                If VaInt(row("S")) <> VaInt(row("S_Original")) Then

                    Dim IdLinea As String = row("IdLinea").ToString & ""
                    If ValeEnvases_Lineas.LeerId(IdLinea) Then
                        If row("S") = True Then
                            ValeEnvases_Lineas.VEL_IdFacturaEnvase.Valor = LbId.Text
                        Else
                            ValeEnvases_Lineas.VEL_IdFacturaEnvase.Valor = 0
                        End If
                        ValeEnvases_Lineas.Actualizar()
                    End If
                End If

            End If

        Next

        If NuevoRegistro Then
            '  ImprimirFacturaEnvases(LbId.Text, TipoImpresion.ImpresoraPorDefecto, False, "", "", "")
        Else
            If XtraMessageBox.Show("¿Desea imprimir la factura", "Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                BotonAuxiliar1()
            End If
        End If


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
                            Dim f As New frmVisualizadorAsiento(ListaAsientos, False, , MiMaletin.IdEmpresaCTB)
                            f.ShowDialog()

                        Else
                            MsgBox("no se generó asiento")
                        End If


                    End If

                End If

            End If

        End If


    End Sub


    Public Overrides Sub DespuesdeAnular()
        Dim c As New Contabilizacion.clAsientos

        MyBase.DespuesdeAnular()

        If IdAsientonet > 0 And VaInt(LbAsiento.Text) > 0 Then
            If c.AnularAsiento(ConexCtb(MiMaletin.IdEmpresaCTB), IdAsientonet, LbAsiento.Text) <> 0 Then
                MsgBox("No se pudo anular el asiento ")
            Else
                'MsgBox("Asiento anulado con exito")
            End If
        End If

    End Sub


    Private Sub TxDato_41_Valida(ByVal edicion As System.Boolean) Handles TxDato_41.Valida
        'If edicion Then
        'TODO: Comprobar decimales
        LbCuotaEnv.Text = (VaDec(LbTEnvases.Text) * VaDec(TxDato_41.Text) / 100).ToString("#,##0.00")
        'End If
    End Sub


    Private Sub TxDato_44_Valida(ByVal edicion As System.Boolean) Handles TxDato_44.Valida
        'If edicion Then
        'TODO: Comprobar decimales
        LbCuotaReEnv.Text = (VaDec(LbTEnvases.Text) * VaDec(TxDato_44.Text) / 100).ToString("#,##0.00")
        'End If
    End Sub


    Private Sub LbTEnvases_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbTEnvases.TextChanged
        LbCuotaEnv.Text = (VaDec(LbTEnvases.Text) * VaDec(TxDato_41.Text) / 100).ToString("#,##0.00")
        LbCuotaReEnv.Text = (VaDec(LbTEnvases.Text) * VaDec(TxDato_44.Text) / 100).ToString("#,##0.00")
        CalculaTotalesFactura()
    End Sub


    Private Sub LbCuotaEnv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbCuotaEnv.TextChanged
        CalculaTotalesFactura()
    End Sub


    Private Sub LbCuotaReEnv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbCuotaReEnv.TextChanged
        CalculaTotalesFactura()
    End Sub


    Private Sub CalculaTotalesFactura()

        Dim TotalDivisa As Decimal = VaDec(LbTEnvases.Text)
        TotalDivisa = TotalDivisa + VaDec(LbCuotaEnv.Text)
        TotalDivisa = TotalDivisa + VaDec(LbCuotaReEnv.Text)

        LbTotEuros.Text = TotalDivisa.ToString("#,##0.00")

    End Sub


    Private Sub LbAsiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbAsiento.Click

        If LbAsiento.Text <> "" Then

            Dim IdAsientoNET As Integer = VaInt(Facturas.FRA_idasientoNet.Valor)
            Dim ListaAsientos As New List(Of Integer)
            ListaAsientos.Add(IdAsientoNET)
            Dim F As New FrmConsultaVisuAsiento(ListaAsientos, False, , MiMaletin.IdEmpresaCTB)
            F.ShowDialog()

        End If

    End Sub
    

    Private Sub TxDato_5_Valida1(ByVal edicion As Boolean) Handles TxDato_5.Valida


        'TODO: MUCHO OJO!!!!! Al cambiar de cliente albaranes, habrá que quitar los que estaban asociados del otro cliente


        'Dim MensajeBloqueo As String = ""

        'If Clientes.BloqueoClientes(TxDato_5.Text, MensajeBloqueo) Then

        '    XtraMessageBox.Show("CLIENTE BLOQUEADO" & vbCrLf & MensajeBloqueo, "CLIENTE BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    TxDato_5.MiError = True

        'Else


        'Si estamos dando de alta, sólo mostramos los pendientes para este cliente
        If edicion Then
            CargaIva(TxDato_5.Text)

            If TxIdRegimenIva.Text = "" Then
                If Clientes.LeerId(TxDato_5.Text) = True Then
                    If TiposClientes.LeerId(Clientes.CLI_IdTipo.Valor) = True Then
                        TxIdRegimenIva.Text = TiposClientes.TPC_idtipoiva.Valor
                    End If
                End If
            End If

            If NuevoRegistro Then

                CargaAlbaranes()
                CalculoTotales()

            ElseIf Not NuevoRegistro And Modificando And VaInt(TxDato_5.Text) <> VaInt(Facturas.FRA_clientealbaranes.Valor) Then


                If XtraMessageBox.Show("Al cambiar Cliente Albaranes, se desvincularán los albaranes asociados a esta factura, ¿desea continuar?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                    Dim ValeEnvases_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)

                    For indice As Integer = 0 To GridViewAlbaranes.RowCount - 1
                        Dim row As DataRow = GridViewAlbaranes.GetDataRow(indice)
                        If Not IsNothing(row) Then
                            If VaInt(row("IdFactura").ToString) = VaInt(LbId.Text) Then

                                Dim IdLinea As String = row("IdLinea").ToString & ""
                                If ValeEnvases_Lineas.LeerId(IdLinea) Then
                                    ValeEnvases_Lineas.VEL_IdFacturaEnvase.Valor = 0
                                    ValeEnvases_Lineas.Actualizar()
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
                    CalculoTotales()
                Else
                    TxDato_5.Text = Facturas.FRA_clientealbaranes.Valor
                    TxDato_5.Validar(edicion)
                End If
            End If


        End If

        'End If

    End Sub


    Private Sub CargaIva(ByVal IdCliente As String)

        Dim Iva2 As Decimal = 0

        Dim Re2 As Decimal = 0


        'Dim consulta As New Cdatos.E_select
        'consulta.SelCampo(Clientes.CLI_IdTipo, "IdTipo")
        'consulta.SelCampo(TiposClientes.TPC_idtipoiva, "IdTipoIva", Clientes.CLI_IdTipo, TiposClientes.TPC_idtipo)
        'consulta.SelCampo(TiposClientes.TPC_exentoiva, "ExentoIVA")
        'consulta.SelCampo(TiposClientes.TPC_recequivalencia, "RecargoEq")
        'consulta.SelCampo(TiposClientes.TPC_ctaenvases, "CtaEnvases")
        'consulta.SelCampo(TiposClientes.TPC_IvaEnvases, "IvaEnvases")
        'consulta.SelCampo(TiposClientes.TPC_ReEnvases, "ReEnvases")
        'consulta.WheCampo(Clientes.CLI_Codigo, "=", VaInt(IdCliente))


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Clientes.CLI_IdTipo, "IdTipo")
        consulta.SelCampo(TiposClientes.TPC_idtipoiva, "IdTipoIva", Clientes.CLI_IdTipo, TiposClientes.TPC_idtipo)
        consulta.SelCampo(TiposClientes.TPC_exentoiva, "ExentoIVA")
        consulta.SelCampo(TiposClientes.TPC_recequivalencia, "RecargoEq")
        consulta.SelCampo(TiposClientes.TPC_ctaenvases, "CtaEnvases")
        consulta.WheCampo(Clientes.CLI_Codigo, "=", VaInt(IdCliente))


        'Dim CtaDevEnvases As String = ""

        Dim dt As DataTable = Clientes.MiConexion.ConsultaSQL(consulta.SQL)
        If dt.Rows.Count > 0 Then

            Dim row As DataRow = dt.Rows(0)
            Dim ExentoIVA As String = (row("ExentoIVA").ToString & "").Trim.ToUpper
            Dim RecargoEq As String = (row("RecargoEq").ToString & "").Trim.ToUpper

            'If ExentoIVA <> "S" Then
            '    Iva2 = VaDec(row("IvaEnvases"))
            'End If

            'If RecargoEq = "S" Then
            '    Re2 = VaDec(row("ReEnvases"))
            'End If

            'CtaDevEnvases = row("CtaEnvases").ToString & ""


            Dim dtIva As DataTable = TipoIva.Tabla
            For Each rw In dtIva.Rows
                Select Case rw("id").ToString


                    'Case "1"
                    '    If ExentoIVA <> "S" Then Iva1 = VaDec(rw("iva"))
                    '    If RecargoEq = "S" Then Re1 = VaDec(rw("re"))

                    Case "2"
                        If ExentoIVA <> "S" Then Iva2 = VaDec(rw("iva"))
                        If RecargoEq = "S" Then Re2 = VaDec(rw("re"))

                        'Case "3"
                        '    If ExentoIVA <> "S" Then Iva3 = VaDec(rw("iva"))
                        '    If RecargoEq = "S" Then Re3 = VaDec(rw("re"))

                End Select

            Next

            'CtaDevEnvases = row("CtaEnvases").ToString & ""


        End If

        If VaInt(TxDato_41.Text) = 0 Then TxDato_41.Text = Iva2.ToString("#,##0.00")
        If VaInt(TxDato_44.Text) = 0 Then TxDato_44.Text = Re2.ToString("#,##0.00")


        'If TxDato_51.Text = "" Then TxDato_51.Text = CtaDevEnvases

        CalculaCuotas()

    End Sub


    Private Sub CalculaCuotas()

        LbCuotaEnv.Text = (VaDec(LbTEnvases.Text) * VaDec(TxDato_41.Text) / 100).ToString("#,##0.00")
        LbCuotaReEnv.Text = (VaDec(LbTEnvases.Text) * VaDec(TxDato_44.Text) / 100).ToString("#,##0.00")

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


    'Private Sub TxDato_51_TextChanged(sender As System.Object, e As System.EventArgs)
    '    BtBusca_51.CL_Filtro = "NUMEROCUENTA LIKE '" & TxDato_51.Text & "%'"
    'End Sub


    Private Sub TxDato_0_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato_0.TextChanged
        If TxDato_0.Text <> "" Then
            BotonesAvance1.Filtro = "FRA_campa=" + MiMaletin.Ejercicio.ToString + " AND FRA_Serie='" + TxDato_0.Text + "' AND FRA_idempresa = '" + MiMaletin.IdEmpresaCTB.ToString + "' AND FRA_AlhCom = 'E'"
        End If
    End Sub


    Private Sub TxDato_0_Valida(edicion As System.Boolean) Handles TxDato_0.Valida

        'If edicion Then

        '    If SeriesFacturas.LeerId(TxDato_0.Text) = False Then
        '        XtraMessageBox.Show("NO EXISTE LA SERIE", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Else
        '        Dim conf As New E_ConfiguracionesDiversas(Idusuario, cn)
        '        If conf.xDameValor(E_ConfiguracionesDiversas.eClaves.REG_IVA_SERIE_CLIENTE) = "0" Then
        '            TxIdRegimenIva.Text = SeriesFacturas.SFR_IdTipoIvaR.Valor
        '            TxIdRegimenIva.Validar(False)
        '        End If
        '    End If

        'End If


        If edicion Then

            If TxDato_0.Text.Trim <> "" Then

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


    'Public Overrides Sub BotonAuxiliar1()
    '    MyBase.BotonAuxiliar1()

    '    If VaDec(LbId.Text) > 0 Then
    '        Dim frm As New FrmImpresionFacturasEnvases(LbId.Text)
    '        frm.ShowDialog()
    '    End If

    'End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaDec(LbId.Text) > 0 Then
            C1_ImprimirFacturaEnvases(LbId.Text, TipoImpresion.Preliminar)
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaDec(LbId.Text) > 0 Then
            C1_ImprimirFacturaEnvases(LbId.Text, TipoImpresion.ImpresoraPorDefecto)
        End If

    End Sub


    'Public Overrides Sub BotonAuxiliar3()

    '    If VaDec(LbId.Text) > 0 Then
    '        C1_EnviarFacturaEnvases(LbId.Text)
    '    End If

    'End Sub



End Class