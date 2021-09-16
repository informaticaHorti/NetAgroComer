Imports DevExpress.XtraEditors.Controls


Public Class FrmTrabajosEtiqueta
    Inherits FrConsulta


    Dim Pedidos As New E_Pedidos(Idusuario, cn)
    Dim pedidos_lineas As New E_Pedidos_lineas(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
    Dim CategoriasComercial As New E_CategoriasComercial(Idusuario, cn)

    Dim IdlineaPedidoAlm As Integer
    Dim IdLineaPedido As Integer
    Dim IdPedido As Integer



    Private _filtros As String = ""

    Dim err As New Errores




    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Pedidos.PED_fechapedido, Lb1)
        CbPventa = ComboPuntoventa(CbPventa, MiMaletin.IdPuntoVenta)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub FrmConsultaPaletsResumida_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente

    End Sub


    Private Sub Fechaspordefecto()
        TxDato1.Text = Now.ToShortDateString

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        IdlineaPedidoAlm = 0
        IdLineaPedido = 0
        IdPedido = 0

        Lbpedido.Text = ""
        LbCliente.Text = ""
        LbLote.Text = ""
        LbReferencia.Text = ""
        LbPresentacion.Text = ""
        LbConfeccion.Text = ""
        LbMarca.Text = ""
        LbEtiquetaCesta.Text = ""
        LbEtiquetaCaja.Text = ""
        LbMarcaEtiquetaCesta.Text = ""
        LbMarcaMaterial.Text = ""
        LbPalets.Text = ""
        LbBultos.Text = ""
        LbPiezas.Text = ""
        PanelEstado.Visible = False
        PanelBotones.Visible = False

        Grid.DataSource = Nothing
        GridView1.Columns.Clear()

        Dim consulta As New Cdatos.E_select
        Dim pedidos_lineas As New E_Pedidos_lineas(Idusuario, cn)
        Dim pedidos_almacen As New E_pedidos_almacen(Idusuario, cn)
        Dim pedidos As New E_Pedidos(Idusuario, cn)
        Dim Clientes As New E_Clientes(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim CategoriasComercial As New E_CategoriasComercial(Idusuario, cn)
        Dim Marca As New E_Marcas(Idusuario, cn)
        Dim MensajesEntidades As New E_mensajesentidades(Idusuario, cn)


        consulta.SelCampo(pedidos_almacen.PAC_id, "id")
        consulta.SelCampo(pedidos_lineas.PEL_idlinea, "idlinea", pedidos_almacen.PAC_idlineapedido)
        consulta.SelCampo(pedidos.PED_idpedido, "idpedido", pedidos_lineas.PEL_idpedido)
        consulta.SelCampo(pedidos.PED_pedido, "pedido")
        consulta.SelCampo(pedidos.PED_fechasalida, "Fecha")
        consulta.SelCampo(Centros.Nombre, "Centro", pedidos_almacen.PAC_idalmacen)
        consulta.SelCampo(pedidos.PED_idcliente, "Codigo")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", pedidos.PED_idcliente)
        consulta.SelCampo(pedidos.PED_referencia, "referencia")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", pedidos_lineas.PEL_idgenero)
        consulta.SelCampo(pedidos_lineas.PEL_idtipoconfeccion, "IdTipoConfeccion")
        consulta.SelCampo(ConfecEnvase.CEV_Nombre, "Confeccion", pedidos_lineas.PEL_idtipoconfeccion)
        consulta.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", pedidos_lineas.PEL_idgensal, GenerosSalida.GES_Idgensal)
        consulta.SelCampo(CategoriasComercial.CAC_Nombre, "Categoria", pedidos_lineas.PEL_idcategoria)
        consulta.SelCampo(Marca.MAR_Nombre, "Marca", pedidos_lineas.PEL_idmarca)
        consulta.SelCampo(pedidos_almacen.PAC_palets, "Palets")
        Dim Bultos As New Cdatos.bdcampo("@COALESCE(pac_palets,0) * COALESCE(pel_bultospalet,0) ", Cdatos.TiposCampo.Entero, 10)
        consulta.SelCampo(Bultos, "Bultos")
        Dim Piezas As New Cdatos.bdcampo("@COALESCE(pac_palets,0) * COALESCE(pel_bultospalet,0) * COALESCE(pel_piezasbulto,0) ", Cdatos.TiposCampo.Entero, 10)
        consulta.SelCampo(Piezas, "Piezas")
        consulta.SelCampo(pedidos_almacen.PAC_estadoetiqueta, "idestado")
        consulta.SelCampo(pedidos_lineas.PEL_obslote, "Estado")
        consulta.SelCampo(pedidos_lineas.PEL_requiereaprobacion, "aprobacion")
        consulta.SelCampo(pedidos_lineas.PEL_obseti1, "instrucciones1")
        consulta.SelCampo(pedidos_lineas.PEL_obseti2, "instrucciones2")
        consulta.SelCampo(pedidos_lineas.PEL_obslote, "Lote")
        'Dim oMarcaEtiqueta As New Cdatos.bdcampo("@(SELECT MAR_Nombre FROM Marcas WHERE MAR_IdMarca = PEL_IdMarcaEtiqueta)", Marcas.MAR_Nombre.TipoBd, Marcas.MAR_Nombre.Longitud)
        'consulta.SelCampo(oMarcaEtiqueta, "MarcaEtiqueta")
        'Dim oMarcaMaterial As New Cdatos.bdcampo("@(SELECT MAR_Nombre FROM Marcas WHERE MAR_IdMarca = PEL_IdMarcaMaterial)", Marcas.MAR_Nombre.TipoBd, Marcas.MAR_Nombre.Longitud)
        'consulta.SelCampo(oMarcaMaterial, "MarcaMaterial")
        consulta.WheCampo(pedidos.PED_fechasalida, ">=", TxDato1.Text)
        consulta.WheCampo(pedidos_lineas.PEL_generatrabajo, "=", "S")


        Dim sqlFiltro As String = ""
        If rbFiltroPteEnvioMuestra.Checked Then
            consulta.WheCampo(pedidos_almacen.PAC_estadoetiqueta, "=", "0")
            consulta.WheCampo(pedidos_lineas.PEL_requiereaprobacion, "=", "S")
        ElseIf rbFiltroPteConfCliente.Checked Then
            sqlFiltro = " AND (PAC_EstadoEtiqueta = 1 OR (COALESCE(PAC_EstadoEtiqueta,0) = 0 AND PEL_RequiereAprobacion = 'S'))"
            'consulta.WheCampo(pedidos_almacen.PAC_estadoetiqueta, "=", "1")
        ElseIf rbFiltroPteImprimir.Checked Then
            sqlFiltro = " AND (COALESCE(PAC_EstadoEtiqueta,0) = 0 OR PAC_EstadoEtiqueta = 2 OR PAC_EstadoEtiqueta = 1)"
            'sqlFiltro = " AND (PAC_EstadoEtiqueta = 2 OR (COALESCE(PAC_EstadoEtiqueta,0) = 0 AND PEL_RequiereAprobacion <> 'S'))"
        ElseIf rbFiltroFinalizada.Checked Then
            consulta.WheCampo(pedidos_almacen.PAC_estadoetiqueta, "=", "9")
        End If


        Dim WHE As String = consulta.Whe & vbCrLf
        WHE = WHE & sqlFiltro & vbCrLf
        WHE = WHE & CadenaWhereLista(pedidos_almacen.PAC_idalmacen, ListadeCombo(CbPventa), " AND ")


        Dim sql As String = consulta.Sel + WHE
        Dim dt As DataTable = pedidos.MiConexion.ConsultaSQL(sql)

        dt.Columns.Add(New DataColumn("Mensajes", GetType(Int32)))

        Grid.DataSource = dt

        For Each RW In dt.Rows

            Select Case VaInt(RW("idestado"))
                Case 9
                    RW("Estado") = "TERMINADA"
                Case 2
                    RW("Estado") = "PTE IMPRIMIR"
                Case 1
                    RW("Estado") = "PTE CONF.CLIENTE"
                Case 0
                    If RW("APROBACION").ToString = "S" Then
                        RW("Estado") = "PTE ENVIO CLIENTE"
                    Else
                        RW("Estado") = "PTE IMPRIMIR"
                    End If

            End Select

            Dim n As Integer = MensajesEntidades.Pendientes(Idusuario, "pedidos_lineas", VaInt(RW("idlinea")))
            RW("mensajes") = n
        Next

        AjustaColumnas()


        Dim r As DataRow = GridView1.GetFocusedDataRow()
        If Not IsNothing(r) Then
            MuestraLinea(r)
        End If


    End Sub





    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "PEDIDO", "PALETS", "BULTOS", "CODIGO", "PIEZAS", "FECHA", "MENSAJES"
                    c.Width = 60

                Case "CENTRO", "CATEGORIA", "ESTADO", "REFERENCIA", "MARCA"
                    c.Width = 100


                Case "CLIENTE", "GENERO", "CONFECCION"
                    c.Width = 150

                Case Else
                    c.Visible = False
            End Select
        Next


    End Sub



    Public Overrides Sub GridClik(ByVal row As System.Data.DataRow, ByVal column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

        MuestraLinea(row)

        If column.FieldName.ToUpper = "MENSAJES" Then
            Dim frm As New FrMMensajesEntidad
            frm.Init(pedidos_lineas.NombreTabla, IdLineaPedido.ToString, "Pedido: " + Lbpedido.Text + " " + LbCliente.Text)
            frm.ShowDialog()
        End If

    End Sub


    Private Sub MuestraLinea(row As DataRow)

        Dim IdLineaPedido As String = row("IdLinea").ToString & ""
        Dim EtiquetaCesta As String = ""
        Dim MarcaEtiqueta As String = ""
        Dim EtiquetaCaja As String = ""
        Dim MarcaMaterial As String = ""
        EtiquetasCestaCaja(IdLineaPedido, EtiquetaCesta, EtiquetaCaja, MarcaEtiqueta, MarcaMaterial)

        Lbpedido.Text = row("pedido").ToString
        LbCliente.Text = row("cliente").ToString
        LbLote.Text = row("Lote").ToString
        LbReferencia.Text = row("referencia").ToString
        LbPresentacion.Text = row("presentacion").ToString
        LbCategoria.Text = row("Categoria").ToString
        LbConfeccion.Text = row("confeccion").ToString
        LbMarca.Text = row("marca").ToString
        LbEtiquetaCesta.Text = EtiquetaCesta
        LbEtiquetaCaja.Text = EtiquetaCaja
        LbMarcaEtiquetaCesta.Text = MarcaEtiqueta
        LbMarcaMaterial.Text = MarcaMaterial
        LbPalets.Text = row("palets").ToString
        LbBultos.Text = Format(VaInt(row("bultos")), "#,###")
        LbPiezas.Text = Format(VaInt(row("piezas")), "#,###")


        MuestraEstado(VaInt(row("idestado")), row("APROBACION").ToString & "")


        IdlineaPedidoAlm = VaInt(row("id"))
        IdLineaPedido = VaInt(row("idlinea"))
        IdPedido = VaInt(row("idpedido"))
        PanelEstado.Visible = True
        PanelBotones.Visible = True

    End Sub


    Private Sub MuestraEstado(Estado As Integer, Aprobacion As String)

        Select Case VaInt(Estado)
            Case 9
                RbFinalizada.Checked = True
            Case 2
                RbPteImprimir.Checked = True
            Case 1
                RbPteConf.Checked = True
            Case 0
                If Aprobacion = "S" Then
                    RbPteEnvioMuestra.Checked = True
                Else
                    RbPteImprimir.Checked = True
                End If
        End Select

    End Sub


    Public Overrides Sub FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        MyBase.FocusedRowChanged(sender, e)

        Dim row As DataRow = GridView1.GetDataRow(e.FocusedRowHandle)
        If Not IsNothing(row) Then

            MuestraLinea(row)

        End If

    End Sub


    Private Sub RbPteEnvioMuestra_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbPteEnvioMuestra.CheckedChanged
        'If RbPteEnvioMuestra.Checked = True Then
        '    CambioEstado(0)
        'End If
    End Sub
    Private Sub RbPteConf_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbPteConf.CheckedChanged
        'If RbPteConf.Checked = True Then
        '    CambioEstado(1)
        'End If
    End Sub
    Private Sub RbPteImprimir_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbPteImprimir.CheckedChanged
        'If RbPteImprimir.Checked = True Then
        '    CambioEstado(2)
        'End If
    End Sub
    Private Sub RbFinalizada_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbFinalizada.CheckedChanged
        'If RbFinalizada.Checked = True Then
        '    CambioEstado(9)
        'End If
    End Sub
    Private Sub RbPteEnvioMuestra_Click(sender As System.Object, e As System.EventArgs) Handles RbPteEnvioMuestra.Click
        If RbPteEnvioMuestra.Checked = True Then
            CambioEstado(0)
        End If
    End Sub

    Private Sub RbPteConf_Click(sender As System.Object, e As System.EventArgs) Handles RbPteConf.Click
        If RbPteConf.Checked = True Then
            CambioEstado(1)
        End If
    End Sub

    Private Sub RbPteImprimir_Click(sender As System.Object, e As System.EventArgs) Handles RbPteImprimir.Click
        If RbPteImprimir.Checked = True Then
            CambioEstado(2)
        End If
    End Sub

    Private Sub RbFinalizada_Click(sender As System.Object, e As System.EventArgs) Handles RbFinalizada.Click
        If RbFinalizada.Checked = True Then
            CambioEstado(9)
        End If
    End Sub



    Private Sub CambioEstado(Aestado As Integer)

        Dim Pedidos_almacen As New E_pedidos_almacen(Idusuario, cn)
        If IdlineaPedidoAlm > 0 Then
            If MsgBox("Guardar nuevo estado", vbYesNo) = vbYes Then

                If Pedidos_almacen.LeerId(IdlineaPedidoAlm.ToString) = True Then

                    Pedidos_almacen.PAC_estadoetiqueta.Valor = Aestado.ToString
                    Pedidos_almacen.Actualizar()

                    Dim indice As Integer = GridView1.FocusedRowHandle
                    Consultar()
                    GridView1.FocusedRowHandle = indice

                End If
            End If
        End If


    End Sub

    
    Private Sub BtVerEtiqueta_Click(sender As System.Object, e As System.EventArgs) Handles BtVerEtiqueta.Click


        Dim pedidos_lineas As New E_Pedidos_lineas(Idusuario, cn)
        If IdLineaPedido > 0 Then

            Timer1.Stop()

            Dim frm As New FrDocs
            frm.Init(Pedidos.NombreBd, pedidos_lineas.NombreTabla, IdLineaPedido.ToString)
            frm.ShowDialog()

            Timer1.Start()

        End If

    End Sub


    Private Sub BtMuestra_Click(sender As System.Object, e As System.EventArgs) Handles BtMuestra.Click

        Dim pedidos_almacen As New E_pedidos_almacen(Idusuario, cn)
        If IdlineaPedidoAlm > 0 Then

            Timer1.Stop()

            Dim frm As New FrDocs
            frm.Init(Pedidos.NombreBd, pedidos_almacen.NombreTabla, IdlineaPedidoAlm.ToString)
            frm.ShowDialog()

            Timer1.Start()

        End If

    End Sub


    Protected Overrides Sub RowCellStyle(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn, sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        MyBase.RowCellStyle(row, column, sender, e)

        If e.Column.FieldName.Trim.ToUpper = "ESTADO" Then

            Select Case VaInt(row("idestado"))
                Case 9
                    e.Appearance.BackColor = Color.LightGreen
                Case 2
                    e.Appearance.BackColor = Color.Cyan
                Case 1
                    e.Appearance.BackColor = Color.Yellow
                Case 0
                    If row("APROBACION").ToString = "S" Then
                        e.Appearance.BackColor = Color.Red
                    Else
                        e.Appearance.BackColor = Color.Cyan
                    End If



            End Select

        ElseIf e.Column.FieldName.Trim.ToUpper = "MENSAJES" Then
            Select Case VaInt(row("mensajes"))
                Case 0
                    e.Appearance.BackColor = Color.Green
                Case Else
                    e.Appearance.BackColor = Color.Red
            End Select

        End If

    End Sub


    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles btMensajes.Click

        Timer1.Stop()

        Dim frm As New FrMMensajesEntidad
        frm.Init(pedidos_lineas.NombreTabla, IdLineaPedido.ToString, "Pedido: " + Lbpedido.Text + " " + LbCliente.Text)
        frm.ShowDialog()

        Timer1.Start()

    End Sub

    Private Sub BtVerPedido_Click(sender As System.Object, e As System.EventArgs) Handles BtVerPedido.Click

        If IdPedido > 0 Then

            Timer1.Stop()

            Dim frm As New FrDocs
            frm.Init(Pedidos.NombreBd, Pedidos.NombreTabla, IdPedido.ToString)
            frm.ShowDialog()

            Timer1.Start()

        End If

    End Sub

   
    Protected Overrides Sub OcultaCargando()
        MyBase.OcultaCargando()

        GridView1.ActiveFilterString = _filtros

    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        Dim indice As Integer = GridView1.FocusedRowHandle
        'Consultar()
        'GridView1.FocusedRowHandle = indice

        _filtros = GridView1.ActiveFilterString
        BConsultar.PerformClick()

        GridView1.FocusedRowHandle = indice

    End Sub

    Private Sub BConsultar_Click(sender As System.Object, e As System.EventArgs) Handles BConsultar.Click

        Timer1.Start()

    End Sub

    Private Sub btEnvioMuestra_Click(sender As System.Object, e As System.EventArgs) Handles btEnvioMuestra.Click

        'Timer1.Stop()


        'Timer1.Start()

    End Sub

   
End Class