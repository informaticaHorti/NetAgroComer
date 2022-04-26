Imports DevExpress.XtraEditors


Public Class FrmAgricultores
    Inherits FrMantenimiento


    Private Structure SaldosMedianeros
        Public IdAgricultor As String
        Public SaldosProv As Decimal
        Public Anticipos As Decimal
        Public Suministros As Decimal
        Public PortesOtros As Decimal
        Public Entradas As Decimal
        Public AlbSumis As Decimal
        Public Disponible As Decimal
    End Structure



    Dim Pais As New E_Paises(Idusuario, CnComun)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim AgricultorGastos As New E_AgricultorGastos(Idusuario, cn)
    Dim Agricultor As New E_Agricultores(Idusuario, cn)

    Dim TiposdeGastosAgri As New E_TiposdeGastoAgri(Idusuario, cn)
    Dim OrigenGastos As New E_OrigenGastos(Idusuario, cn)
    Dim TiposAgricultores As New E_TipoAgricultor(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Zonas As New E_Zonas(Idusuario, cn)
    Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)
    Dim Empresas As New E_Empresas(Idusuario, cn)
    Dim Bancos As New E_Bancos(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim Centros As New E_centros(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim TipoDoc As New E_TipoDocumento(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))

    Dim Agricultores_IBAN As New E_Agricultores_IBAN(Idusuario, cn)

    Dim BloqueoCuentas As New E_BloqueoCuentas(Idusuario, cn)


    Dim Primero As Boolean


    Dim oEnlaceAgr As EnlaceNuxeo
    Dim oConfigAgr As New ConfiguracionEnlace
    Dim oEnlaceLiq As EnlaceNuxeo
    Dim oConfigLiq As New ConfiguracionEnlace
    Dim NuevoFichero As String = ""




    Private _bCrearNIF As Boolean = False


    Private Property Botontarifa As Button






    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        parametrosfrm()
    End Sub


    Private Sub FrmAgricultores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Primero = True
        Primero = False

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


        GridAsociados.DataSource = Nothing
        GridMed.DataSource = Nothing
        GridSaldos.DataSource = Nothing
        GridSaldosEnvases.DataSource = Nothing
        GridAlbaranesPendientesFacturar.DataSource = Nothing
        GridFacturasPendientesPago.DataSource = Nothing

        _bCrearNIF = False

        rbTalon.Checked = True


        btEditarIBAN.Enabled = False

    End Sub


    Public Overrides Sub ControlClave()
        MyBase.ControlClave()

        CargaLineasGrid()

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()


        Select Case VaInt(Agricultores.AGR_IdFormaPago.Valor)
            Case E_Agricultores.FormasPago.Talon
                rbTalon.Checked = True
            Case E_Agricultores.FormasPago.Pagare
                RbPagare.Checked = True
            Case E_Agricultores.FormasPago.Transferencia
                RbTransferencia.Checked = True
        End Select


        
        CargaBloqueos()
   
        CargaLineasGrid()

        CargaAsociados(LbId.Text)
      
        If TxDato_2.Text.Trim = "" Then
            TxDato_2.BackColor = Color.PaleVioletRed()
        Else
            TxDato_2.BackColor = Color.White
        End If

        CargaMedianeros()



        CargaSaldosMedianeros()
        CargaSaldosEnvases()

        CargaAlbaranesPendientesFacturar()
        CargaFacturasPendientesPago()


        btEditarIBAN.Enabled = True

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean


        If Gr Is ClGrid1 Then


            Dim IdLinea As String = ""
            Dim IdGasto As String = TxDato_42.Text
            Dim IdAcreedor As String = TxDato_44.Text
            Dim IdCentroRecogida As String = TxDato_45.Text


            Dim row As DataRow = ClGrid1.GridView.GetFocusedDataRow()
            If Not IsNothing(row) Then
                IdLinea = (row("AGG_Id").ToString & "").Trim
            End If

            If GastoYaIntroducido(IdLinea, LbId.Text, IdGasto, IdAcreedor, IdCentroRecogida) Then
                MsgBox("No se puede introducir un gasto con el mismo código de gasto, código de acreedor y centro de descarga")
                Return False
            End If

        End If


        'asociar cabecera con lineas
        AgricultorGastos.AGG_IdAgricultor.Valor = TxDato_1.Text


        CargaLineasGrid(False)

        Return MyBase.GuardarLineas(Gr)

    End Function


    Private Function GastoYaIntroducido(ByVal IdLinea As String, ByVal IdAgricultor As String, ByVal IdGasto As String, ByVal IdAcreedor As String, ByVal IdCentroRecogida As String) As Boolean

        Dim bRes As Boolean = False


        If VaInt(IdGasto) > 0 And VaInt(IdAgricultor) > 0 Then

            Dim sql As String = "SELECT AGG_Id as Id" & vbCrLf
            sql = sql & " FROM AgricultorGastos" & vbCrLf
            sql = sql & " WHERE AGG_IdAgricultor = " & IdAgricultor & vbCrLf
            sql = sql & " And AGG_IdGasto = " & IdGasto & vbCrLf
            sql = sql & " AND COALESCE(AGG_IdAcreedor,0) = " & VaInt(IdAcreedor).ToString & vbCrLf
            sql = sql & " AND COALESCE(AGG_IdCentroRec,0) = " & VaInt(IdCentroRecogida).ToString & vbCrLf
            If VaDec(IdLinea) > 0 Then
                sql = sql & " AND AGG_Id <> " & IdLinea & vbCrLf
            End If

            Dim dt As DataTable = Agricultor.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    bRes = True
                End If
            End If

        End If



        Return bRes

    End Function


    Public Overrides Sub Guardar()


        If RbPagare.Checked Then

            If VaInt(TxDiasVto.Text) = 0 Or TxSitCartera.Text.Trim = "" Or TxTipoDoc.Text.Trim = "" Then
                MsgBox("En caso de que la forma de pago sea mediante pagaré, debe introducir obligatoriamente los días de vencimiento, la situación de la cartera y el tipo de documento.")
                Exit Sub
            End If

        ElseIf rbTalon.Checked Then

            If TxSitCartera.Text.Trim = "" Or TxTipoDoc.Text.Trim = "" Then
                MsgBox("En caso de que la forma de pago sea mediante talón, debe introducir obligatoriamente la situación de la cartera y el tipo de documento.")
                Exit Sub
            End If

        ElseIf RbTransferencia.Checked Then

            If TxIBAN.Text.Trim = "" Then
                MsgBox("En caso de que la forma de pago sea mediante transferencia, debe introducir el IBAN")
                Exit Sub
            End If

        End If


        If _bCrearNIF Then
            TxDato_2.MiError = False
            TxDato_2.BackColor = Color.White
        End If

        GuardarBloqueos()


        Select Case True
            Case rbTalon.Checked
                Agricultores.AGR_IdFormaPago.Valor = VaInt(E_Agricultores.FormasPago.Talon).ToString
            Case RbPagare.Checked
                Agricultores.AGR_IdFormaPago.Valor = VaInt(E_Agricultores.FormasPago.Pagare).ToString
            Case RbTransferencia.Checked
                Agricultores.AGR_IdFormaPago.Valor = VaInt(E_Agricultores.FormasPago.Transferencia).ToString
        End Select


        MyBase.Guardar()

    End Sub


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()

        SincronizarProveedores(LbId.Text)

    End Sub


    Private Sub CargaLineasGrid(Optional bCargar As Boolean = True)
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 
        Dim sql As String
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AgricultorGastos.AGG_Id, "")
        consulta.SelCampo(AgricultorGastos.AGG_IdGasto, "Codigo")
        consulta.SelCampo(TiposdeGastosAgri.TGA_Nombre, "Gasto", AgricultorGastos.AGG_IdGasto)
        consulta.SelCampo(AgricultorGastos.AGG_Valor, "Valor")
        consulta.SelCampo(TiposdeGastosAgri.TGA_Tipo, "Tipo")
        consulta.SelCampo(CentrosRecogida.CER_Nombre, "Centro", AgricultorGastos.AGG_idcentrorec)

        consulta.WheCampo(AgricultorGastos.AGG_IdAgricultor, "=", TxDato_1.Text)
        sql = consulta.SQL
        sql = sql + " order by AGG_id"
        ClGrid1.Consulta = sql

        If bCargar Then
            ClGrid1.Nlinea = -1
            Cargalineas(ClGrid1)
        End If

    End Sub


    Private Sub ParametrosFrm()

        EntidadFrm = Agricultores


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato_1, Agricultores.AGR_IdAgricultor, Lb_1, True)

        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato_2, Agricultores.AGR_Nif, Lb_2)
        ParamTx(TxDato_3, Agricultores.AGR_Nombre, Lb_3, True)


        ParamChk(ChkNoFacturar, Agricultores.AGR_NoFacturar, "S", "N")


        ParamTx(TxDato_4, Agricultores.AGR_Domicilio, Lb_4)
        ParamTx(TxDato_5, Agricultores.AGR_IdZona, Lb_5)
        ParamTx(TxDato_6, Agricultores.AGR_Poblacion, Lb_6)
        ParamTx(TxDato_7, Agricultores.AGR_Provincia, Lb_7)
        ParamTx(TxDato_8, Agricultores.AGR_Cpostal, Lb_8)
        ParamTx(TxDato_25, Agricultores.AGR_fechaalta, Lb_25)
        ParamTx(TxDato_9, Agricultores.AGR_IdPais, Lb_9, True)
        ParamTx(TxDato_23, Agricultores.AGR_Telefono, Lb_23)
        ParamTx(TxDato_24, Agricultores.AGR_Movil, Lb_24)
        ParamTx(TxDato_10, Agricultores.AGR_IdTipo, Lb_10, True)
        ParamTx(TxSerie, Agricultores.AGR_serie, LbSerie)
        ParamTx(TxDato1, Agricultores.AGR_tipofcs, Lb2, True, , , , "FCS")

        ParamTx(TxEmailCalidad, Agricultores.AGR_EmailCalidad, LbEmailCalidad)

        ParamChk(ChBloqueo, Agricultores.AGR_Bloqueado, "S", "N")

        ParamTx(TxDato_11, Agricultores.AGR_TextoMensaje1, Lb_11)
        ParamTx(TxDato_12, Agricultores.AGR_TextoMensaje2, Lb_11)



        ParamChk(ChkBloqueoPagos, BloqueoCuentas.BloqueoSN, "S", "N")
        ParamChk(ChkMostrarMensaje, BloqueoCuentas.AvisoSN, "S", "N")
        ParamTx(TxMensaje, BloqueoCuentas.Aviso)

        ParamTx(TxDato_14, Agricultores.AGR_IdPrincipal, Lb_14)
        ParamTx(TxCenvases, Agricultores.AGR_idenvases, LbCenvases)
        ParamTx(TxEmpresa, Agricultores.AGR_idempresa, LbEmpresa, True)
        ParamTx(TxCrecogida, Agricultores.AGR_idcrecogida, LbCrecogida)
        ParamTx(TxCentro, Agricultores.AGR_idcentro, LbCentro, True)

        ParamTx(TxDato_13, Agricultores.AGR_PersonaContacto, Lb_13)
        ParamTx(TxDato_26, Agricultores.AGR_Mail, Lb_26)

        ParamTx(TxAltaOpFH, Agricultores.AGR_fechaaltaopfh, LbAltaopfh)
        ParamTx(TxBanco, Agricultores.AGR_idBanco, LbBanco)

        ParamTx(TxIBAN, Agricultores.AGR_IBAN, LbIBAN)
        ParamTx(TxDiasVto, Agricultores.AGR_DiasVto, LbDiasVto)
        ParamTx(TxSitCartera, Agricultores.AGR_SituacionCartera, LbSitCartera)
        ParamTx(TxTipoDoc, Agricultores.AGR_TipoDocumento, LbTipoDoc)



        ParamTx(TxDato_42, AgricultorGastos.AGG_IdGasto, Lb_42)
        ParamTx(TxDato_43, AgricultorGastos.AGG_Valor, Lb_43, False, Cdatos.TiposCampo.Importe, 4, 8)
        ParamChk(ChFija, AgricultorGastos.AGG_GastoFijo, "S", "N")
        ParamChk(Chprin, AgricultorGastos.AGG_PedirEntrada, "S", "N")
        ParamCb_Copia(CbFaccom, AgricultorGastos.AGG_TipoFC, Lb8, Combos.ComboFacCom)
        ParamTx(TxDato_44, AgricultorGastos.AGG_IdAcreedor, Lb_44)
        ParamChk(ChkAsignarAcreedor, AgricultorGastos.AGG_AsignarAcreedorAlbaran, "S", "N")
        ParamTx(TxDato_45, AgricultorGastos.AGG_idcentrorec, Lb_45)




        AsociarControles(TxDato_1, BtBuscaAgri, Agricultores.btBusca, EntidadFrm)
        'AsociarControles(TxDato_2, BtBuscaNif, Nif.btBusca, Nif, Nif.Nombre)
        AsociarControles(TxDato_5, btBuscaZona, Zonas.btBusca, Zonas, Zonas.ZON_Nombre, Lbnom_5)
        AsociarControles(TxDato_9, BtBuscaPais, Pais.btBusca, Pais, Pais.Nombre, Lbnom_9)
        AsociarControles(TxDato_10, BtBuscaTipoProv, TiposAgricultores.btBusca, TiposAgricultores, TiposAgricultores.TPA_nombre, Lbnom_10)
        AsociarControles(TxDato_14, BtBuscaPrinci, Agricultor.btBusca, Agricultor)
        AsociarControles(TxCenvases, BtBuscaCenvases, Agricultor.btBusca, Agricultor)
        AsociarControles(TxCrecogida, BtBuscaCRecogida, CentrosRecogida.btBusca, CentrosRecogida, CentrosRecogida.CER_Nombre, LbNomCrecogida)
        AsociarControles(TxCentro, BtCentro, Centros.btBusca, Centros, Centros.Nombre, LbNomCentro)

        'AsociarControles(TxIBAN, BtBuscaIBAN, Agricultores_IBAN.btBusca, Agricultores_IBAN, Agricultores_IBAN.AIB_IBAN)

        AsociarControles(TxSitCartera, BtBuscaSitCartera, Bancos.btBusca, Bancos, Bancos.Nombre, LbNom_SitCartera)
        AsociarControles(TxTipoDoc, BtBuscaTipoDoc, TipoDoc.btBusca, TipoDoc, TipoDoc.Nombre, LbNom_TipoDoc)


        AsociarControles(TxDato_42, BtBuscaGasto, TiposdeGastosAgri.btBusca, TiposdeGastosAgri, TiposdeGastosAgri.TGA_Nombre, Lb_Nom42)
        AsociarControles(TxDato_44, BtBuscaAcreedor, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, Lbnom_44)
        AsociarControles(TxDato_45, BtBuscaCentroRec, CentrosRecogida.btBusca, CentrosRecogida, CentrosRecogida.CER_Nombre, Lbnom_45)
        AsociarControles(TxEmpresa, BtBuscaEmpresa, Empresas.btBusca, Empresas, Empresas.EMP_Nombre, LbNomEmpresa)
        AsociarControles(TxBanco, BtBanco, Bancos.btBusca, Bancos, Bancos.Nombre, LbNomBanco)

        AsociarGrid(ClGrid1, TxDato_42, TxDato_45, AgricultorGastos)


        PropiedadesCamposGr(ClGrid1, "AGG_id", "", False, 0)
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 50)
        PropiedadesCamposGr(ClGrid1, "Gasto", "Gasto", True, 150)
        PropiedadesCamposGr(ClGrid1, "Valor", "Valor", True, 100, False, "#0.000000")
        PropiedadesCamposGr(ClGrid1, "Tipo", "Tipo", True, 25)
        PropiedadesCamposGr(ClGrid1, "Centro", "Centro", True, 150)
        PropiedadesCamposGr(ClGrid1, "FC", "FC", True, 20)


        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me



    End Sub


  


    Protected Overrides Sub BModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MyBase.BModificar_Click(sender, e)
        ' no se puede modificar el nif de un agricultor
        If TxDato_2.Text.Trim <> "" Then TxDato_2.Enabled = False
        TxDato_3.Focus()

        If TxDato_2.Text.Trim = "" Then
            TxDato_2.BackColor = Color.PaleVioletRed()
        Else
            TxDato_2.BackColor = Color.White
        End If

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Consulta As New Cdatos.E_select
        Consulta.SelCampo(Agricultores.AGR_IdAgricultor, "IdAgricultor")
        Consulta.SelCampo(Agricultores.AGR_Nombre, "Nombre")
        Consulta.SelCampo(TiposAgricultores.TPA_nombre, "Tipo", Agricultores.AGR_IdTipo)
        Consulta.WheCampo(Agricultores.AGR_IdAgricultor, "=", "1")
        MsgBox(Consulta.SQL)

    End Sub

    Sub TxDato_14_Valida(ByVal edicion As Boolean) Handles TxDato_14.Valida

        Dim Agricultor As New E_Agricultores(Idusuario, cn)

        If VaInt(TxDato_14.Text) = 0 Then
            TxDato_14.Text = TxDato_1.Text
        End If
        If VaInt(TxDato_14.Text) = VaInt(TxDato_1.Text) Then
            LbNom_14.Text = TxDato_3.Text
        Else
            If Agricultor.LeerId(TxDato_14.Text) = True Then
                LbNom_14.Text = Agricultor.AGR_Nombre.Valor
            Else
                TxDato_14.MiError = True
            End If
        End If

    End Sub


    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles BtContactos.Click

        If VaInt(LbId.Text) > 0 Then
            Dim frm As New FrmContactos("Proveedor", LbId.Text)
            frm.init(LbId.Text)
            frm.ShowDialog()
        End If

    End Sub


    Private Sub TxDato_42_Valida(ByVal edicion As Boolean) Handles TxDato_42.Valida

        If edicion Then
            If TxDato_42.Text.Trim = "" Then
                TxDato_42.MiError = True
                Exit Sub
            End If
        End If

        If TiposdeGastosAgri.LeerId(TxDato_42.Text) = True Then
            If OrigenGastos.LeerId(TiposdeGastosAgri.TGA_idgrupo.Valor) Then
                BtBuscaAcreedor.CL_Filtro = "TIPO='" + OrigenGastos.ORG_tipo.Valor + "'"
            End If
        If edicion = True Then
                If CbFaccom.SelectedValue Is Nothing Then
                    CbFaccom.SelectedValue = TiposdeGastosAgri.TGA_tipogastofc.Valor
                End If
                If TxDato_44.Text = "" Then
                    If VaInt(TiposdeGastosAgri.TGA_idacreedor.Valor) > 0 Then
                        TxDato_44.Text = TiposdeGastosAgri.TGA_idacreedor.Valor
                    End If

                End If
            End If
        End If

    End Sub


    


    Private Sub CargaAsociados(IdPrincipal As String)


        Dim Agricultor As New E_Agricultores(Idusuario, cn)

        If VaInt(IdPrincipal) > 0 Then

            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(Agricultor.AGR_IdAgricultor, "Codigo")
            consulta.SelCampo(Agricultor.AGR_Nombre, "Nombre")
            consulta.WheCampo(Agricultor.AGR_IdPrincipal, "=", IdPrincipal)

            Dim sql As String = consulta.SQL & vbCrLf & " ORDER BY Nombre"

            Dim dt As DataTable = Agricultor.MiConexion.ConsultaSQL(sql)
            GridAsociados.DataSource = dt

            AjustaColumnasAsociados()


        End If

    End Sub


    Private Sub AjustaColumnasAsociados()

        With GridViewAsociados.Columns

            Dim col As DevExpress.XtraGrid.Columns.GridColumn = .ColumnByFieldName("Codigo")
            col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            col.DisplayFormat.FormatString = "00000"
            col.MaxWidth = 60

        End With

    End Sub

    Private Sub ajustacolumnasmedianeros()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView7.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CMED", "NUMERO"
                    c.Visible = True
                    c.Width = 50
                    c.MinWidth = 50
                    c.MaxWidth = 50

                Case "MEDIANERO"
                    c.Visible = True
                    c.Width = 300
                    c.MinWidth = 300
                    c.MaxWidth = 300
                Case "PORC"
                    c.Visible = True
                    c.Width = 50
                    c.MinWidth = 50
                    c.MaxWidth = 50




                Case Else
                    c.Visible = False
            End Select
        Next

    End Sub
    Private Sub ChkMostrarMensaje_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ChkMostrarMensaje.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            TxMensaje.SelectAll()
            TxMensaje.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            ChkBloqueoPagos.Select()
            ChkBloqueoPagos.Focus()
        End If
    End Sub

    Private Sub ChkBloqueoPagos_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ChkBloqueoPagos.KeyDown
        If e.KeyCode = Keys.Up Then
            TxDato_26.Select()
            TxDato_26.Focus()
        End If
    End Sub

    Private Sub TxMensaje_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxMensaje.KeyDown
        If e.KeyCode = Keys.Up Then
            ChkMostrarMensaje.Select()
            ChkMostrarMensaje.Focus()
        ElseIf e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            TxDato_14.Select()
            TxDato_14.Focus()
        End If
    End Sub

    Private Sub BtObserva_Click(sender As System.Object, e As System.EventArgs) Handles BtObserva.Click
        If Val(LbId.Text) > 0 Then
            Dim frm As New FrmObserva
            frm.init("AGR", LbId.Text)
            frm.ShowDialog()
        End If

    End Sub

    Private Sub TxDato_10_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato_10.TextChanged

    End Sub

    Private Sub TxDato_10_Valida(edicion As Boolean) Handles TxDato_10.Valida
        If TxDato_10.Text <> "" Then
            If TiposAgricultores.LeerId(TxDato_10.Text) = True Then
                Lbiva.Text = Format(VaDec(TiposAgricultores.TPA_poriva.Valor), "###0.00")
                Lbret.Text = Format(VaDec(TiposAgricultores.TPA_porret.Valor), "###0.00")
            End If

        End If
    End Sub

    Private Sub Lb2_Click(sender As System.Object, e As System.EventArgs) Handles Lb2.Click

    End Sub

    Private Sub TxDato_14_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato_14.TextChanged

    End Sub

    Private Sub TxCrecogida_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxCrecogida.TextChanged

    End Sub

    Private Sub TxCenvases_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxCenvases.TextChanged

    End Sub

    Private Sub TxCenvases_Valida(edicion As Boolean) Handles TxCenvases.Valida
        Dim Agricultor As New E_Agricultores(Idusuario, cn)

        If VaInt(TxCenvases.Text) = 0 Then
            TxCenvases.Text = TxDato_1.Text
        End If
        If VaInt(TxCenvases.Text) = VaInt(TxDato_1.Text) Then
            LbNomCenvases.Text = TxDato_3.Text
        Else
            If Agricultor.LeerId(TxCenvases.Text) = True Then
                LbNomCenvases.Text = Agricultor.AGR_Nombre.Valor
            Else
                TxCenvases.MiError = True
            End If
        End If
    End Sub

    Private Sub TxEmpresa_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxEmpresa.TextChanged

    End Sub

    Private Sub TxEmpresa_Valida(edicion As Boolean) Handles TxEmpresa.Valida
        If VaInt(TxEmpresa.Text) = 0 Then
            TxEmpresa.Text = "1"
        End If
    End Sub

    Private Sub TxCrecogida_Valida(edicion As Boolean) Handles TxCrecogida.Valida
        If VaInt(TxCrecogida.Text) = 0 Then
            TxCrecogida.Text = MiMaletin.IdCentroRecogida.ToString
        End If
    End Sub


    Private Sub GuardarBloqueos()

        Dim Cta As String = "400" & VaInt(TxDato_1.Text).ToString("00000000")
        Dim BloqueoCuenta As New E_BloqueoCuentas(Idusuario, cn)
        If BloqueoCuenta.LeerId(Cta) Then
            'Si existe el bloqueo a la cuenta
            If ChkBloqueoPagos.Checked = False And ChkMostrarMensaje.Checked = False And TxMensaje.Text.Trim = "" Then
                'Si no hay datos que guardar, la borra
                BloqueoCuenta.Eliminar()
            Else
                'Si hay que guardar algo, actualiza los campos
                If ChkBloqueoPagos.Checked Then
                    BloqueoCuenta.BloqueoSN.Valor = "S"
                Else
                    BloqueoCuenta.BloqueoSN.Valor = "N"
                End If
                If ChkMostrarMensaje.Checked Then
                    BloqueoCuenta.AvisoSN.Valor = "S"
                Else
                    BloqueoCuenta.AvisoSN.Valor = "N"
                End If
                BloqueoCuenta.Aviso.Valor = TxMensaje.Text.Trim
                BloqueoCuenta.Actualizar()
            End If
        Else
            'Si no existe el bloqueo
            If ChkBloqueoPagos.Checked Or ChkMostrarMensaje.Checked Or TxMensaje.Text.Trim <> "" Then
                'Creamos el bloqueo e insertamos
                BloqueoCuenta = New E_BloqueoCuentas(Idusuario, cn)
                BloqueoCuenta.NumeroCuenta.Valor = Cta
                If ChkBloqueoPagos.Checked Then
                    BloqueoCuenta.BloqueoSN.Valor = "S"
                Else
                    BloqueoCuenta.BloqueoSN.Valor = "N"
                End If
                If ChkMostrarMensaje.Checked Then
                    BloqueoCuenta.AvisoSN.Valor = "S"
                Else
                    BloqueoCuenta.AvisoSN.Valor = "N"
                End If
                BloqueoCuenta.Aviso.Valor = TxMensaje.Text.Trim
                BloqueoCuenta.Insertar()
            End If
        End If


    End Sub


    Private Sub CargaBloqueos()

        Dim Cta As String = "400" & VaInt(TxDato_1.Text).ToString("00000000")
        Dim BloqueoCuenta As New E_BloqueoCuentas(Idusuario, cn)

        If BloqueoCuenta.LeerId(Cta) Then
            ChkBloqueoPagos.Checked = (BloqueoCuenta.BloqueoSN.Valor & "").Trim.ToUpper = "S"
            ChkMostrarMensaje.Checked = (BloqueoCuenta.AvisoSN.Valor & "").Trim.ToUpper = "S"
            TxMensaje.Text = BloqueoCuenta.Aviso.Valor & ""
        End If

    End Sub

    Private Sub CargaMedianeros()

        If TxDato_1.Text <> "" Then

            Dim medianeria_lineas As New E_Medianeria_lineas(Idusuario, cn)
            Dim medianeria As New E_Medianeria(Idusuario, cn)
            Dim Agr As New E_Agricultores(Idusuario, cn)
            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(medianeria_lineas.MEL_Id, "id")
            consulta.SelCampo(medianeria.MED_Numero, "Numero", medianeria_lineas.MEL_Idmedianeria)
            consulta.SelCampo(medianeria_lineas.MEL_Idagricultor, "Cmed")
            consulta.SelCampo(Agr.AGR_Nombre, "Medianero", medianeria_lineas.MEL_Idagricultor)
            consulta.SelCampo(medianeria_lineas.MEL_porcentaje, "Porc")
            consulta.WheCampo(medianeria.MED_IdAgricultor, "=", TxDato_1.Text)
            Dim Sql As String = consulta.SQL

            Dim dt As DataTable = medianeria.MiConexion.ConsultaSQL(Sql)

            GridMed.DataSource = dt
            ajustacolumnasmedianeros()

        End If

    End Sub


    Private Sub CargaSaldosMedianeros()

        If TxDato_1.Text <> "" Then


            Dim dtRes As New DataTable
            dtRes.Columns.Add(New DataColumn("Codigo", GetType(Int32)))
            dtRes.Columns.Add(New DataColumn("Nombre", GetType(String)))
            dtRes.Columns.Add(New DataColumn("SaldoProv", GetType(Decimal)))
            dtRes.Columns.Add(New DataColumn("Anticipos", GetType(Decimal)))
            dtRes.Columns.Add(New DataColumn("Suministros", GetType(Decimal)))
            dtRes.Columns.Add(New DataColumn("PortesOtros", GetType(Decimal)))
            dtRes.Columns.Add(New DataColumn("Entradas", GetType(Decimal)))
            dtRes.Columns.Add(New DataColumn("AlbSumis", GetType(Decimal)))
            dtRes.Columns.Add(New DataColumn("Disponible", GetType(Decimal)))


            'Primera línea: Agricultor principal
            Dim row As DataRow = dtRes.NewRow()
            row("Codigo") = TxDato_1.Text
            row("Nombre") = TxDato_3.Text

            Dim Saldos As SaldosMedianeros = ObtenerSaldosAgricultor(TxDato_1.Text, TxDato_10.Text)
            row("SaldoProv") = Saldos.SaldosProv
            row("Anticipos") = Saldos.Anticipos
            row("Suministros") = Saldos.Suministros
            row("PortesOtros") = Saldos.PortesOtros
            row("Entradas") = Saldos.Entradas
            row("AlbSumis") = Saldos.AlbSumis
            row("Disponible") = Saldos.Disponible

            dtRes.Rows.Add(row)



            'Medianeros
            Dim medianeria_lineas As New E_Medianeria_lineas(Idusuario, cn)
            Dim medianeria As New E_Medianeria(Idusuario, cn)
            Dim Agricultores As New E_Agricultores(Idusuario, cn)
            Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)

            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(medianeria_lineas.MEL_Id, "id")
            consulta.SelCampo(medianeria.MED_Numero, "Numero", medianeria_lineas.MEL_Idmedianeria)
            consulta.SelCampo(medianeria_lineas.MEL_Idagricultor, "Cmed")
            consulta.SelCampo(Agricultores.AGR_Nombre, "Medianero", medianeria_lineas.MEL_Idagricultor)
            consulta.SelCampo(Agricultores.AGR_IdTipo, "IdTipoAgricultor")
            consulta.SelCampo(TipoAgricultor.TPA_ctaprov, "CtaProv", Agricultores.AGR_IdTipo)
            consulta.SelCampo(TipoAgricultor.TPA_ctaanti, "CtaAnti")
            consulta.SelCampo(TipoAgricultor.TPA_ctasumi, "CtaSumi")
            consulta.SelCampo(TipoAgricultor.TPA_ctaotros, "CtaOtros")
            consulta.WheCampo(medianeria.MED_IdAgricultor, "=", TxDato_1.Text)
            Dim Sql As String = consulta.SQL

            Dim dt As DataTable = medianeria.MiConexion.ConsultaSQL(Sql)
            If Not IsNothing(dt) Then
                For Each rowMed As DataRow In dt.Rows

                    Dim Codigo As String = VaInt(rowMed("Cmed"))
                    Dim Nombre As String = (rowMed("Medianero").ToString & "").Trim
                    Dim IdTipoAgricultor As String = (rowMed("IdTipoAgricultor").ToString & "").Trim

                    Dim SaldosMed As SaldosMedianeros = ObtenerSaldosAgricultor(Codigo, IdTipoAgricultor)
                    
                    Dim fila As DataRow = dtRes.NewRow()
                    fila("Codigo") = Codigo
                    fila("Nombre") = Nombre

                    fila("SaldoProv") = SaldosMed.SaldosProv
                    fila("Anticipos") = SaldosMed.Anticipos
                    fila("Suministros") = SaldosMed.Suministros
                    fila("PortesOtros") = SaldosMed.PortesOtros
                    fila("Entradas") = SaldosMed.Entradas
                    fila("AlbSumis") = SaldosMed.AlbSumis
                    fila("Disponible") = SaldosMed.Disponible

                    dtRes.Rows.Add(fila)

                Next
            End If


            'Línea de total ( en amarillo ) 
            Dim rowFinal As DataRow = dtRes.NewRow()
            rowFinal("Codigo") = 0
            rowFinal("Nombre") = "TOTALES..."

            If dtRes.Columns.Contains("SaldoProv") Then rowFinal("SaldoProv") = VaDec(dtRes.Compute("SUM(SaldoProv)", ""))
            If dtRes.Columns.Contains("Anticipos") Then rowFinal("Anticipos") = VaDec(dtRes.Compute("SUM(Anticipos)", ""))
            If dtRes.Columns.Contains("Suministros") Then rowFinal("Suministros") = VaDec(dtRes.Compute("SUM(Suministros)", ""))
            If dtRes.Columns.Contains("PortesOtros") Then rowFinal("PortesOtros") = VaDec(dtRes.Compute("SUM(PortesOtros)", ""))
            If dtRes.Columns.Contains("Entradas") Then rowFinal("Entradas") = VaDec(dtRes.Compute("SUM(Entradas)", ""))
            If dtRes.Columns.Contains("AlbSumis") Then rowFinal("AlbSumis") = VaDec(dtRes.Compute("SUM(AlbSumis)", ""))
            If dtRes.Columns.Contains("Disponible") Then rowFinal("Disponible") = VaDec(dtRes.Compute("SUM(Disponible)", ""))

            dtRes.Rows.Add(rowFinal)


            GridSaldos.DataSource = dtRes
            AjustaColumnasSaldosMedianeros()



        End If


    End Sub


    Private Function ObtenerSaldosAgricultor(IdAgricultor As String, IdTipoAgricultor As String, Optional CtaProv As String = "", Optional CtaAnti As String = "", Optional CtaSumi As String = "",
                                             Optional CtaOtros As String = "") As SaldosMedianeros

        Dim saldos As New SaldosMedianeros
        saldos.SaldosProv = 0
        saldos.Anticipos = 0
        saldos.Suministros = 0
        saldos.PortesOtros = 0
        saldos.Entradas = 0
        saldos.AlbSumis = 0


        If CtaProv.Trim = "" Or CtaAnti.Trim = "" Or CtaSumi.Trim = "" Or CtaOtros.Trim = "" Then

            Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)
            If TipoAgricultor.LeerId(IdTipoAgricultor) Then
                If CtaProv.Trim = "" Then CtaProv = TipoAgricultor.TPA_ctaprov.Valor : CtaProv = CtaProv.PadRight(6, "0") & IdAgricultor.PadLeft(5, "0")
                If CtaAnti.Trim = "" Then CtaAnti = TipoAgricultor.TPA_ctaanti.Valor : CtaAnti = CtaAnti.PadRight(6, "0") & IdAgricultor.PadLeft(5, "0")
                If CtaSumi.Trim = "" Then CtaSumi = TipoAgricultor.TPA_ctasumi.Valor : CtaSumi = CtaSumi.PadRight(6, "0") & IdAgricultor.PadLeft(5, "0")
                If CtaOtros.Trim = "" Then CtaOtros = TipoAgricultor.TPA_ctaotros.Valor : CtaOtros = CtaOtros.PadRight(6, "0") & IdAgricultor.PadLeft(5, "0")
            End If

        End If


        'Cuentas del tipo de proveedor
        Dim lst As New List(Of String)
        lst.Add(CtaProv)
        lst.Add(CtaAnti)
        lst.Add(CtaSumi)
        lst.Add(CtaOtros)

        Dim dt As DataTable = SaldoCuentas(lst, 0)
        For Each row As DataRow In dt.Rows

            Dim cta As String = (row("NumeroCuenta").ToString & "").Trim
            Dim total As Decimal = VaDec(row("SaldoTotal"))

            Select Case cta.Trim
                Case CtaProv
                    saldos.SaldosProv = -total
                Case CtaAnti
                    saldos.Anticipos = total
                Case CtaSumi
                    saldos.Suministros = total
                Case CtaOtros
                    saldos.PortesOtros = total
            End Select

        Next


        'Entradas (Suma de los importes de albaranes pendientes de facturar)
        saldos.Entradas = AlbaranesPendientesFacturar(IdAgricultor)



        saldos.IdAgricultor = IdAgricultor

        saldos.Disponible = saldos.SaldosProv - saldos.Anticipos - saldos.Suministros - saldos.PortesOtros + saldos.Entradas - saldos.AlbSumis



        Return saldos

    End Function



    Private Function AlbaranesPendientesFacturar(IdAgricultor As String) As Decimal

        Dim res As Decimal = 0

        Dim sql As String = ConsultaAlbaranesPendientesFacturar(IdAgricultor)

        sql = "SELECT SUM(Importe) as Importe " & vbCrLf & " FROM ( " & vbCrLf & sql & " ) as T" & vbCrLf
        'sql = sql + " group by FECHA,CAMPA,CE,ALBARAN "
        Dim dt As DataTable = Agricultor.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                res = VaDec(dt.Rows(0)("Importe"))
            End If
        End If



        Return res

    End Function


    Private Function ConsultaAlbaranesPendientesFacturar(IdAgricultor As String) As String

        Dim sql As String = "SELECT AEN_Fecha as Fecha," & vbCrLf
        sql = sql & " AEL_Muestreo as Partida, GEN_NombreGenero as Genero, " & vbCrLf
        sql = sql & " (SELECT SUM(COALESCE(ALC_Precio,0) * COALESCE(ALC_kilosnetos,0)) FROM AlbEntrada_LineasCla WHERE ALC_idlineaentrada = AEL_IdLinea) as Importe," & vbCrLf
        sql = sql & " AEN_Campa as Campa, AEN_IdCentro as CE, AEN_Albaran as Albaran" & vbCrLf
        sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEN_IdAlbaran = AEL_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = AEL_IdGenero" & vbCrLf
        sql = sql & " WHERE AEN_IdAgricultor = " & IdAgricultor & vbCrLf
        sql = sql & " AND (SELECT count(AEH_Id) FROM AlbEntrada_His WHERE AEH_IdAlbaran = AEL_IdAlbaran AND (AEH_IdFactura > 0 or AEH_idfacturafirme > 0)) = 0" & vbCrLf


        Return sql

    End Function



    Private Sub AjustaColumnasSaldosMedianeros()


        GridViewSaldos.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewSaldos.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CODIGO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.Width = 50

                Case "PORTESOTROS"
                    c.Caption = "- Portes/Otros"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 110

                Case "SALDOPROV"
                    c.Caption = "+ SaldoProv"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 110

                Case "ANTICIPOS"
                    c.Caption = "- Anticipos"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 110

                Case "SUMINISTROS"
                    c.Caption = "- Suministros"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 110

                Case "ENTRADAS"
                    c.Caption = "+ Entradas"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 110

                Case "ALBSUMIS"
                    c.Caption = "- AlbSumis"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 110


                Case "DISPONIBLE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 110

            End Select
        Next

    End Sub


    Private Sub CargaSaldosEnvases()


        Dim Valeenvase As New E_ValeEnvases(Idusuario, cn)

        Dim Consulta As New Cdatos.E_select
        Dim DT As New DataTable
        Dim sql As String


        'TODO: Preguntar sobre las fechas
        Dim FechaDesde As String = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        Dim FechaHasta As String = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")


        sql = Valeenvase.SaldoEnvases("A", False, FechaDesde, FechaHasta, TxDato_1.Text, TxDato_1.Text, "", "")
        DT = Valeenvase.MiConexion.ConsultaSQL(sql)


        Dim DT2 As New DataTable

        Dim idEnvase As New DataColumn("IdEnvase", GetType(Int32))
        DT2.Columns.Add(idEnvase)

        Dim Envase As New DataColumn("Envase", GetType(String))
        DT2.Columns.Add(Envase)

        Dim Inicial As New DataColumn("Inicial", GetType(String))
        DT2.Columns.Add(Inicial)

        Dim retira As New DataColumn("Retira", GetType(Int32))
        DT2.Columns.Add(retira)

        Dim entrega As New DataColumn("Entrega", GetType(Int32))
        DT2.Columns.Add(entrega)

        Dim Saldo As New DataColumn("Saldo", GetType(String))
        DT2.Columns.Add(Saldo)

        Dim Inicialv As New DataColumn("InicialV", GetType(String))
        DT2.Columns.Add(Inicialv)

        Dim retirav As New DataColumn("RetiraV", GetType(Int32))
        DT2.Columns.Add(retirav)

        Dim entregav As New DataColumn("EntregaV", GetType(Int32))
        DT2.Columns.Add(entregav)

        Dim Saldov As New DataColumn("SaldoV", GetType(String))
        DT2.Columns.Add(Saldov)

        
        If Not DT Is Nothing Then
            For Each rw In DT.Rows
                DT2.Rows.Add(VaInt(rw("idenvase")), rw("nombreenvase").ToString, StSaldo(VaInt(rw("inicial"))), VaInt(rw("retira")), VaInt(rw("entrega")), StSaldo(VaInt(rw("saldo"))), StSaldo(VaInt(rw("inicialvalorado"))), VaInt(rw("retiravalorado")), VaInt(rw("entregavalorado")), StSaldo(VaInt(rw("saldovalorado"))))
            Next
        End If



        Dim rowFinal As DataRow = DT2.NewRow()
        rowFinal("IdEnvase") = 0
        rowFinal("Envase") = "TOTALES..."

        If DT.Columns.Contains("Inicial") Then rowFinal("Inicial") = VaDec(DT.Compute("SUM(Inicial)", ""))
        If DT.Columns.Contains("Retira") Then rowFinal("Retira") = VaDec(DT.Compute("SUM(Retira)", ""))
        If DT.Columns.Contains("Entrega") Then rowFinal("Entrega") = VaDec(DT.Compute("SUM(Entrega)", ""))
        If DT.Columns.Contains("Saldo") Then rowFinal("Saldo") = VaDec(DT.Compute("SUM(Saldo)", ""))
        If DT.Columns.Contains("InicialValorado") Then rowFinal("InicialV") = VaDec(DT.Compute("SUM(InicialValorado)", ""))
        If DT.Columns.Contains("RetiraValorado") Then rowFinal("RetiraV") = VaDec(DT.Compute("SUM(RetiraValorado)", ""))
        If DT.Columns.Contains("EntregaValorado") Then rowFinal("EntregaV") = VaDec(DT.Compute("SUM(EntregaValorado)", ""))
        If DT.Columns.Contains("SaldoValorado") Then rowFinal("SaldoV") = VaDec(DT.Compute("SUM(SaldoValorado)", ""))

        DT2.Rows.Add(rowFinal)


        GridSaldosEnvases.DataSource = DT2

        GridViewSaldosEnvases.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewSaldosEnvases.Columns
            Select Case c.FieldName.Trim.ToUpper
                Case "IDENVASE", "ENVASE"
                Case Else
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            End Select
        Next


    End Sub



    Private Sub GridViewSaldos_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridViewSaldos.RowCellStyle
        If e.RowHandle = GridViewSaldos.RowCount - 1 Then
            e.Appearance.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub GridViewSaldos_CustomColumnDisplayText(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridViewSaldos.CustomColumnDisplayText
        If e.RowHandle = GridViewSaldos.RowCount - 1 Then
            If e.DisplayText = "00000" Then e.DisplayText = ""
        End If
    End Sub


    Private Sub GridViewSaldosEnvases_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridViewSaldosEnvases.RowCellStyle
        If e.RowHandle = GridViewSaldosEnvases.RowCount - 1 Then
            e.Appearance.BackColor = Color.Yellow
        End If
    End Sub

    
    Private Sub GridViewSaldosEnvases_CustomColumnDisplayText(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridViewSaldosEnvases.CustomColumnDisplayText
        If e.RowHandle = GridViewSaldosEnvases.RowCount - 1 Then
            Select Case e.Column.FieldName.ToUpper.Trim
                Case "IDENVASE"
                    e.DisplayText = ""
                Case "ENVASE"
                Case "INICIAL", "SALDO", "INICIALV", "SALDOV"
                    e.DisplayText = StSaldo(VaInt(e.Value))
            End Select
        End If
    End Sub



    Private Sub CargaAlbaranesPendientesFacturar()

        Dim sql As String = ConsultaAlbaranesPendientesFacturar(TxDato_1.Text)

        Dim dt As DataTable = Agricultor.MiConexion.ConsultaSQL(sql)
        GridAlbaranesPendientesFacturar.DataSource = dt


        AjustaColumnasAlbaranesPendientesFacturar()


    End Sub


    Private Sub AjustaColumnasAlbaranesPendientesFacturar()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewAlbaranesPendientesFacturar.Columns
            Select Case c.FieldName.Trim.ToUpper
                Case "FECHA"
                    c.Width = 75
                Case "CAMPA"
                    c.Width = 50
                Case "CE"
                    c.Width = 25
                Case "ALBARAN"
                    c.Width = 90
                Case "IMPORTE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

            End Select
        Next

        AñadeResumenCampo(GridViewAlbaranesPendientesFacturar, "Importe", "{0:n2}")

    End Sub


    Private Sub CargaFacturasPendientesPago()

        Dim sql As String = "SELECT FGR_fecha as Fecha, FGR_totalfactura as Importe, FGR_IdEmpresa as Empresa, FGR_Ejercicio as Campa, FGR_Serie + '-' + CAST(FGR_NumeroFactur as nvarchar) as NumFra" & vbCrLf
        sql = sql & " FROM FacturaAgr" & vbCrLf
        sql = sql & " WHERE FGR_IdAgricultor = " & TxDato_1.Text & vbCrLf
        sql = sql & " AND COALESCE(FGR_IdLiquidacion,0) = 0" & vbCrLf

        Dim dt As DataTable = Agricultor.MiConexion.ConsultaSQL(sql)
        GridFacturasPendientesPago.DataSource = dt

        AjustaColumnasFacturasPendientesPago()

    End Sub


    Private Sub AjustaColumnasFacturasPendientesPago()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewAlbaranesPendientesFacturar.Columns
            Select Case c.FieldName.Trim.ToUpper
                Case "FECHA"
                    c.Width = 75
                Case "CAMPA"
                    c.Width = 50
                Case "EMPRESA"
                    c.Width = 60
                Case "NUMFRA"
                    c.Caption = "N.Fra"
                    c.Width = 120
                Case "IMPORTE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 120
            End Select
        Next


        AñadeResumenCampo(GridViewFacturasPendientesPago, "Importe", "{0:n2}")

    End Sub



    Private Sub rbTalon_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbTalon.CheckedChanged

        If Not IsNothing(TxIBAN.ClParam) Then
            If rbTalon.Checked Then
                TxIBAN.ClParam.Obligatorio = False
                TxDiasVto.ClParam.Obligatorio = False
                TxSitCartera.ClParam.Obligatorio = True
                TxTipoDoc.ClParam.Obligatorio = True
            End If
        End If

    End Sub

    Private Sub RbPagare_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbPagare.CheckedChanged

        If Not IsNothing(TxIBAN.ClParam) Then
            If RbPagare.Checked Then
                TxIBAN.ClParam.Obligatorio = False
                TxDiasVto.ClParam.Obligatorio = True
                TxSitCartera.ClParam.Obligatorio = True
                TxTipoDoc.ClParam.Obligatorio = True
            End If
        End If

    End Sub

    Private Sub RbTransferencia_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbTransferencia.CheckedChanged

        If Not IsNothing(TxIBAN.ClParam) Then
            If RbTransferencia.Checked Then
                TxIBAN.ClParam.Obligatorio = True
                TxDiasVto.ClParam.Obligatorio = False
                TxSitCartera.ClParam.Obligatorio = False
                TxTipoDoc.ClParam.Obligatorio = False
            End If
        End If

    End Sub

    Private Sub TxDato_4_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxDato_4.EnabledChanged
        rbTalon.Enabled = TxDato_4.Enabled
        RbPagare.Enabled = TxDato_4.Enabled
        RbTransferencia.Enabled = TxDato_4.Enabled
    End Sub


    Private Sub TxDato_2_Valida(edicion As System.Boolean) Handles TxDato_2.Valida

        If edicion Then

            If TxDato_2.Text.Trim <> "" And NuevoRegistro Then

                Dim lst As New List(Of String)


                Dim CONSULTA As New Cdatos.E_select
                CONSULTA.SelCampo(Agricultores.AGR_IdAgricultor, "IdAgricultor")
                CONSULTA.WheCampo(Agricultores.AGR_Nif, "=", TxDato_2.Text)

                Dim dt As DataTable = Agricultor.MiConexion.ConsultaSQL(CONSULTA.SQL)
                If Not IsNothing(dt) Then

                    If dt.Rows.Count > 0 Then

                        For Each row As DataRow In dt.Rows

                            Dim IdAgricultor As String = (row("IdAgricultor").ToString & "").Trim
                            lst.Add(IdAgricultor)

                        Next

                    End If

                End If


                If lst.Count > 0 Then

                    Dim texto As String = CadenaWhereLista_CAMPO("", Cdatos.TiposCampo.Entero, lst)
                    MsgBox("El NIF introducido ya existe en el siguiente agricultor: " & texto.Replace("=", ""))

                End If

            End If


        End If

    End Sub


    Private Sub TxIBAN_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxIBAN.KeyDown

        If e.KeyCode = Keys.F2 Then
            EnlazarIBAN()
            'ElseIf TxIBAN.Enabled And (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete) Then
            '    TxIBAN.Text = ""
        ElseIf e.KeyCode = Keys.Enter Then
            If ListaControles(TxIBAN.Orden + 1).Enabled = False Then
                BGuardar.Select()
                BGuardar.Focus()
            End If
        End If

    End Sub


    Private Sub EnlazarIBAN()

        Dim Agricultores_IBAN As New E_Agricultores_IBAN(Idusuario, cn)


        With Agricultores_IBAN.btBusca

            If VaInt(TxDato_1.Text) > 0 Then
                .CL_ConsultaSql = "SELECT AIB_Id as Id, AIB_Entidad as Entidad, AIB_IBAN as IBAN FROM Agricultores_IBAN WHERE AIB_IdAgricultor = " & TxDato_1.Text
            Else
                .CL_ConsultaSql = "SELECT AIB_Id as Id, AIB_Entidad as Entidad, AIB_IBAN as IBAN FROM Agricultores_IBAN WHERE AIB_IdAgricultor = -1"
            End If


            Dim sql As String = .CL_ConsultaSql
            Dim dt As DataTable = .CL_Entidad.MiConexion.ConsultaSQL(sql)

            Dim FRb As New FrBuscar
            FRb.InitCol(.CL_ParamBusqueda, .CL_Ancho)
            FRb.InitDta(dt, .CL_CampoOrden, .CL_Filtro, .CL_ch1000)
            FRb.ShowDialog()

            If Not BuscarRow Is Nothing Then
                TxIBAN.Text = BuscarRow(.CL_DevuelveCampo)
            End If

        End With


        TxIBAN.Validar(True)

        If Not TxIBAN.MiError Then
            Siguiente(TxIBAN.Orden)
        End If


    End Sub


    Private Sub btIBAN_Click(sender As System.Object, e As System.EventArgs) Handles btIBAN.Click

        If TxIBAN.Enabled Then
            EnlazarIBAN()
        End If

    End Sub

    'Private Sub TxDato_1_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxDato_1.EnabledChanged
    '    TxIBAN.ReadOnly = Not TxDato_1.Enabled
    'End Sub


    Private Sub btEditarIBAN_Click(sender As System.Object, e As System.EventArgs) Handles btEditarIBAN.Click

        btIBAN.Enabled = True
        TxIBAN.Enabled = True

        Modificando = True

        'EnlazarIBAN()

        'If MessageBox.Show("¿Desea guardar el IBAN?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

        '    Dim Agricultores As New E_Agricultores(Idusuario, cn)
        '    If Agricultores.LeerId(LbId.Text) Then
        '        Agricultores.AGR_IBAN.Valor = TxIBAN.Text
        '        Agricultores.Actualizar()
        '    End If

        'End If

    End Sub

    Private Sub TxIBAN_Valida(edicion As System.Boolean) Handles TxIBAN.Valida
        If edicion Then

            If Not CompruebaIBAN(TxIBAN.Text) Then
                TxIBAN.MiError = True
                MsgBox("El IBAN no tiene un formato correcto")
            Else
                TxIBAN.MiError = False
            End If

        End If
    End Sub

    Private Sub ClGrid1_Load(sender As Object, e As EventArgs) Handles ClGrid1.Load

    End Sub
End Class