Imports DevExpress.XtraEditors

Public Class FrmPedidosPredefinidos
    Inherits FrConsulta


    Public Enum ResultadoFormulario
        InsertarLineas
        NoInsertar
    End Enum


    Private _resultado As ResultadoFormulario = ResultadoFormulario.NoInsertar
    Public ReadOnly Property Resultado As ResultadoFormulario
        Get
            Return _resultado
        End Get
    End Property


    Dim PedidosClientes As New E_Pedidos_Clientes(Idusuario, cn)


    Dim _IdCliente As String = ""
    Dim _IdDomicilio As String = ""
    Dim _IdPedido As String = ""
    Dim _IdAlmacen As String = ""

    Dim _bPrimero As Boolean = True


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(IdPedido As String, IdCliente As String, IdDomicilio As String, IdAlmacen As String)
        Me.New()

        _IdPedido = IdPedido
        _IdCliente = IdCliente
        _IdDomicilio = IdDomicilio
        _IdAlmacen = IdAlmacen

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc


        ParamTx(TxLote, PedidosClientes.PCC_obslote, LbLote)


    End Sub


    Private Sub FrmPedidosPredefinidos_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        GridEditable.pnlDerecha.Visible = False
        GridEditable.GridView.OptionsView.ShowGroupPanel = True

        Dim fuente As Font = GridEditable.GridView.Appearance.GroupRow.Font
        GridEditable.GridView.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)


        _bPrimero = False


        Consultar()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        GridEditable.DataSource = Nothing

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()



        Dim sql As String = "SELECT PCC_IdLinea as IdLinea, PCC_IdGenero as IdGenero, GEN_NombreGenero as Genero, " & vbCrLf
        sql = sql & " PCC_IdGenSal as IdPresentacion, GES_Nombre as Presentacion, PCC_IdCategoria as IdCategoria, CAS_CategoriaCalibre as Categoria," & vbCrLf
        sql = sql & " PCC_IdTipoPalet as IdTipoPalet, CPA_Nombre as TipoPalet, PCC_IdMarca as IdMarca, MarcaEnv.MAR_Nombre as Marca," & vbCrLf
        sql = sql & " PCC_IdMarcaEtiqueta as IdMarcaEti, MarcaEti.MAR_Nombre as MarcaEti, PCC_IdMarcaMaterial as IdMarcaMat, MarcaMat.MAR_Nombre as MarcaMat," & vbCrLf
        sql = sql & " PCC_bultospalet as BxP, PCC_KilosBulto as KxB, PCC_PiezasBulto as PxB, 0 as Palets, PCC_FechaPedido as FechaPedido," & vbCrLf
        sql = sql & " PCC_Activo" & vbCrLf
        sql = sql & " FROM Pedidos_Clientes" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON PCC_IdGenero = GEN_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN GenerosSalida ON GES_IdGenSal = PCC_IdGenSal" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasSalida ON CAS_Id = PCC_IdCategoria" & vbCrLf
        sql = sql & " LEFT JOIN ConfecPalet ON CPA_IdConfec = PCC_IdTipoPalet" & vbCrLf
        sql = sql & " LEFT JOIN Marcas MarcaEnv ON MarcaEnv.MAR_IdMarca = PCC_IdMarca" & vbCrLf
        sql = sql & " LEFT JOIN Marcas MarcaEti ON MarcaEti.MAR_IdMarca = PCC_IdMarcaEtiqueta" & vbCrLf
        sql = sql & " LEFT JOIN Marcas MarcaMat ON MarcaMat.MAR_IdMarca = PCC_IdMarcaMaterial" & vbCrLf
        sql = sql & " WHERE PCC_IdCliente = " & _IdCliente & vbCrLf
        sql = sql & " AND PCC_IdDomicilio = " & _IdDomicilio & vbCrLf
        If RbSi.Checked Then
            sql = sql & " AND PCC_Activo = 'S'" & vbCrLf
        ElseIf RbNo.Checked Then
            sql = sql & " AND PCC_Activo <> 'S'" & vbCrLf
        End If
        sql = sql & " ORDER BY PCC_IdGenero, PCC_IdGenSal, PCC_FechaPedido DESC" & vbCrLf



        Dim dt As DataTable = PedidosClientes.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            Dim colActivos As New DataColumn("Activo", GetType(Boolean))
            colActivos.DefaultValue = False
            dt.Columns.Add(colActivos)

            For Each row As DataRow In dt.Rows
                Dim Activo As String = (row("PCC_Activo").ToString & "").Trim
                If Activo = "S" Then
                    row("Activo") = True
                Else
                    row("Activo") = False
                End If
            Next

        End If




        GridEditable.DataSource = dt
        GridEditable.Campo("Palets", PedidosClientes.PCC_palets, True, True, True, False, 200)


        'Agrega Boton Borrar
        AñadirColumnaAlGridView(GridEditable.Grid, GridEditable.GridView, "Borrar", GetType(System.Drawing.Image))
        For indice As Integer = 0 To GridEditable.GridView.RowCount - 1
            GridEditable.GridView.SetRowCellValue(indice, GridEditable.GridView.Columns("Borrar"), My.Resources.messagebox_critical)
        Next


        AjustaColumnas(GridEditable.GridView)


    End Sub



    Public Sub AñadirColumnaAlGridView(ByRef Grid As DevExpress.XtraGrid.GridControl, ByRef GridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal NombreColumna As String, ByVal tipo As System.Type)

        'Para Llamar: AñadirColumnaAlGrid(ClGrid1, "P1", GetType(System.Drawing.Image))


        If Not IsNothing(Grid.DataSource) Then

            If TypeOf Grid.DataSource Is DataTable Then

                If Not CType(Grid.DataSource, DataTable).Columns.Contains(NombreColumna) Then
                    Dim col As New DataColumn(NombreColumna, GetType(Image))
                    CType(Grid.DataSource, DataTable).Columns.Add(col)
                    'Grid.GridView.FocusedRowHandle = Grid.GridView.RowCount - 2
                End If


                If IsNothing(GridView.Columns.ColumnByFieldName(NombreColumna)) Then

                    Dim unb As DevExpress.XtraGrid.Columns.GridColumn = GridView.Columns.AddField(NombreColumna)
                    unb.Visible = True

                End If

                If IsNothing(GridView.Columns(NombreColumna).ColumnEdit) Then

                    If tipo = GetType(Image) Then
                        Dim rep As New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
                        rep.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
                        rep.NullText = " "
                        rep.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image
                        GridView.Columns(NombreColumna).ColumnEdit = rep

                        AddHandler rep.Click, AddressOf Imagen_Click

                    End If

                End If

            End If

        End If

    End Sub


    Private Sub Imagen_Click()

        If XtraMessageBox.Show("¿Desea borrar la línea?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim row As DataRow = GridEditable.GridView.GetFocusedDataRow()
            If Not IsNothing(row) Then

                GridEditable.Enabled = False

                Try

                    Dim IdLinea As String = (row("IdLinea").ToString & "").Trim
                    BorrarLinea(IdLinea)
                    Consultar()

                Catch ex As Exception

                End Try

                GridEditable.Enabled = True


            End If

        End If


    End Sub


    Private Sub AjustaColumnas(g As DevExpress.XtraGrid.Views.Grid.GridView)


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In g.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDLINEA", "IDPRESENTACION", "IDCATEGORIA", "IDTIPOPALET", "IDMARCA", "IDMARCAETI", "IDMARCAMAT", "PCC_ACTIVO", "IDGENERO"
                    c.Visible = False
            End Select
        Next


        g.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In g.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "GENERO"
                    c.GroupIndex = 1

                Case "BORRAR"
                    c.Caption = ""
                    c.MinWidth = 20
                    c.MaxWidth = 20

                Case "CATEGORIA"
                    c.Width = 90

                Case "ACTIVO"
                    c.MinWidth = 50
                    c.MaxWidth = 50

                Case "FECHAPEDIDO"
                    c.MinWidth = 80
                    c.MaxWidth = 80

                Case "MARCA", "MARCAETI", "MARCAMAT"
                    c.Width = 90

                Case "TIPOPALET"
                    c.Width = 110

                Case "PALETS", "BXP", "PXB"
                    c.Width = 60
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"

                Case "KXB"
                    c.Width = 60
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

            End Select

        Next


        Funciones.AñadeResumenCampo(g, "Palets", "{0:n0}")

        GridEditable.GridView.ExpandAllGroups()


    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()

        InsertarLineas()

    End Sub


    Public Sub InsertarLineas()

        Dim lstLineas As New List(Of String)
        Dim lstPalets As New List(Of Integer)

        For indice As Integer = 0 To GridEditable.GridView.RowCount - 1
            Dim row As DataRow = GridEditable.GridView.GetDataRow(indice)
            If Not IsNothing(row) Then

                If row("Activo") = True And VaInt(row("Palets")) > 0 Then

                    Dim IdLinea As String = (row("IdLinea").ToString & "").Trim
                    Dim palets As Integer = VaInt(row("Palets"))

                    lstLineas.Add(IdLinea)
                    lstPalets.Add(palets)

                End If

            End If
        Next


        If lstLineas.Count > 0 Then

            For indice As Integer = 0 To lstLineas.Count - 1

                Dim IdLinea As String = lstLineas(indice)
                Dim palets As Integer = lstPalets(indice)


                Dim Pedidos_Clientes As New E_Pedidos_Clientes(Idusuario, cn)
                If Pedidos_Clientes.LeerId(IdLinea) Then

                    Dim IdGenSal As String = (Pedidos_Clientes.PCC_idgensal.Valor & "").Trim
                    Dim IdGenero As String = (Pedidos_Clientes.PCC_IdGenero.Valor & "").Trim

                    Dim IdTipoConfeccion As String = ""
                    If VaInt(IdGenSal) > 0 Then
                        Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
                        If GenerosSalida.LeerId(IdGenSal) Then

                            'Obtiene el tipo de confección de la presentación
                            IdTipoConfeccion = (GenerosSalida.GES_Idconfec.Valor & "").Trim

                        End If
                    End If
                    Dim BxP As Integer = VaInt(Pedidos_Clientes.PCC_bultospalet.Valor)
                    Dim KxB As Decimal = VaDec(Pedidos_Clientes.PCC_kilosbulto.Valor)
                    Dim PxB As Integer = VaDec(Pedidos_Clientes.PCC_piezasbulto.Valor)
                    Dim Bultos As Integer = palets * BxP
                    Dim Kilos As Decimal = Bultos * KxB
                    Dim Piezas As Integer = Bultos * PxB


                    'Inserta la línea del pedido con los datos de la línea de cliente
                    Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)
                    Dim IdLineaPedido As String = Pedidos_Lineas.MaxId.ToString
                    Pedidos_Lineas.PEL_idlinea.Valor = IdLineaPedido
                    Pedidos_Lineas.PEL_idpedido.Valor = _IdPedido
                    Pedidos_Lineas.PEL_palets.Valor = palets.ToString
                    Pedidos_Lineas.PEL_idgenero.Valor = IdGenero
                    Pedidos_Lineas.PEL_idtipoconfeccion.Valor = IdTipoConfeccion
                    Pedidos_Lineas.PEL_idgenero.Valor = IdGenero
                    Pedidos_Lineas.PEL_idgensal.Valor = Pedidos_Clientes.PCC_idgensal.Valor
                    Pedidos_Lineas.PEL_idcategoria.Valor = Pedidos_Clientes.PCC_idcategoria.Valor
                    Pedidos_Lineas.PEL_nomcate.Valor = Pedidos_Clientes.PCC_nomcate.Valor
                    Pedidos_Lineas.PEL_idmarca.Valor = Pedidos_Clientes.PCC_idmarca.Valor
                    Pedidos_Lineas.PEL_idtipopalet.Valor = Pedidos_Clientes.PCC_idtipopalet.Valor
                    Pedidos_Lineas.PEL_bultospalet.Valor = Pedidos_Clientes.PCC_bultospalet.Valor
                    Pedidos_Lineas.PEL_kilosbulto.Valor = Pedidos_Clientes.PCC_kilosbulto.Valor
                    Pedidos_Lineas.PEL_piezasbulto.Valor = Pedidos_Clientes.PCC_piezasbulto.Valor
                    Pedidos_Lineas.PEL_precio.Valor = Pedidos_Clientes.PCC_precio.Valor
                    Pedidos_Lineas.PEL_tipoprecio.Valor = Pedidos_Clientes.PCC_tipoprecio.Valor
                    Pedidos_Lineas.PEL_Bultos.Valor = Bultos.ToString
                    Pedidos_Lineas.PEL_kilos.Valor = Kilos.ToString
                    Pedidos_Lineas.PEL_piezas.Valor = Piezas.ToString
                    Pedidos_Lineas.PEL_obsconfec1.Valor = Pedidos_Clientes.PCC_obsconfec1.Valor
                    Pedidos_Lineas.PEL_obsconfec2.Valor = Pedidos_Clientes.PCC_obsconfec2.Valor
                    Pedidos_Lineas.PEL_obseti1.Valor = Pedidos_Clientes.PCC_obseti1.Valor
                    Pedidos_Lineas.PEL_obseti2.Valor = Pedidos_Clientes.PCC_obseti2.Valor
                    Pedidos_Lineas.PEL_generatrabajo.Valor = Pedidos_Clientes.PCC_generatrabajo.Valor
                    Pedidos_Lineas.PEL_requiereaprobacion.Valor = Pedidos_Clientes.PCC_requiereaprobacion.Valor
                    Pedidos_Lineas.PEL_idmarcaetiqueta.Valor = Pedidos_Clientes.PCC_idmarcaetiqueta.Valor
                    Pedidos_Lineas.PEL_idmarcamaterial.Valor = Pedidos_Clientes.PCC_idmarcamaterial.Valor
                    Pedidos_Lineas.PEL_calidad.Valor = Pedidos_Clientes.PCC_calidad.Valor
                    Pedidos_Lineas.PEL_maxdias.Valor = Pedidos_Clientes.PCC_maxdias.Valor
                    If TxLote.Text.Trim = "" Then
                        Pedidos_Lineas.PEL_obslote.Valor = Pedidos_Clientes.PCC_obslote.Valor
                    Else
                        Pedidos_Lineas.PEL_obslote.Valor = TxLote.Text
                    End If
                    Pedidos_Lineas.Insertar()


                    'Inserta las líneas de Pedidos Almacén
                    Dim Pedidos_Almacen As New E_pedidos_almacen(Idusuario, cn)
                    Pedidos_Almacen.PAC_id.Valor = Pedidos_Almacen.MaxId.ToString
                    Pedidos_Almacen.PAC_idlineapedido.Valor = IdLineaPedido
                    Pedidos_Almacen.PAC_idalmacen.Valor = _IdAlmacen
                    Pedidos_Almacen.PAC_palets.Valor = palets.ToString
                    Pedidos_Almacen.PAC_estadoetiqueta.Valor = "0"
                    Pedidos_Almacen.Insertar()


                End If

            Next

            _resultado = ResultadoFormulario.InsertarLineas

            Me.Close()

        Else
            MsgBox("No hay lineas marcadas y con palets para añadir al pedido")
        End If

        'Actualizar el grid del formulario de pedidos

    End Sub



    Private Sub RbSi_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbSi.CheckedChanged
        If Not _bPrimero Then
            Consultar()
        End If
    End Sub

    Private Sub RbNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbNo.CheckedChanged
        If Not _bPrimero Then
            Consultar()
        End If
    End Sub

    Private Sub RbTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbTodos.CheckedChanged
        If Not _bPrimero Then
            Consultar()
        End If
    End Sub


    Private Sub GridEditable_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridEditable.RowCellClick

        Dim row As DataRow = GridEditable.GridView.GetDataRow(e.RowHandle)
        If Not IsNothing(row) Then

            If e.Column.FieldName.Trim.ToUpper = "ACTIVO" Then

                Dim Activo As String = ""
                If row("Activo") = True Then
                    row("Activo") = False
                    Activo = "N"
                Else
                    row("Activo") = True
                    Activo = "S"
                End If

                Dim IdLinea As String = (row("IdLinea").ToString & "").Trim
                Dim Pedidos_Clientes As New E_Pedidos_Clientes(Idusuario, cn)
                If Pedidos_Clientes.LeerId(IdLinea) Then
                    Pedidos_Clientes.PCC_activo.Valor = Activo
                    Pedidos_Clientes.Actualizar()
                End If

            ElseIf e.Column.FieldName.Trim.ToUpper = "BORRAR" Then
                Imagen_Click()
            End If

        End If

    End Sub


    Private Sub BorrarLinea(IdLinea As String)

        If VaInt(IdLinea) > 0 Then

            Dim Pedidos_Cliente As New E_Pedidos_Clientes(Idusuario, cn)
            If Pedidos_Cliente.LeerId(IdLinea) Then
                Pedidos_Cliente.Eliminar()
            End If

        End If

    End Sub


    Private Sub GridEditable_ShowingEditor(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles GridEditable.ShowingEditor

        Dim View As DevExpress.XtraGrid.Views.Grid.GridView = sender
        Dim row As DataRow = View.GetFocusedDataRow()

        If Not IsNothing(row) Then

            If row("Activo") = False Then
                e.Cancel = True
            End If

        End If

    End Sub


    Private Sub GridEditable_ColumnaSiguiente(IndiceFila As System.Int32, IndiceColumna As System.Int32, ByRef NuevaFila As System.Int32, ByRef NuevaColumna As System.Int32) Handles GridEditable.ColumnaSiguiente

        Try

            Dim rowActual As DataRow = GridEditable.GridView.GetDataRow(IndiceFila)
            Dim colActual As DevExpress.XtraGrid.Columns.GridColumn = GridEditable.GridView.GetVisibleColumn(IndiceColumna)

            If colActual.FieldName.ToUpper.Trim = "PALETS" Then
                GridEditable_Valida(rowActual, colActual)
            End If


            NuevaColumna = IndiceColumna
            NuevaFila = IndiceFila + 1

        Catch ex As Exception

        End Try



    End Sub

    Private Sub GridEditable_Valida(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn) Handles GridEditable.Valida

    End Sub
End Class