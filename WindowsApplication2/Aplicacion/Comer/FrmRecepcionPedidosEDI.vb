Imports DevExpress.XtraEditors


Public Class FrmRecepcionPedidosEDI
    Inherits FrConsulta


    Dim Pedidos As New E_Pedidos(Idusuario, cn)
    Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
    Dim _ruta_llegada_pedidos As String = ""


    Dim lstPedidos As New List(Of EDI.EDI_Pedido)                               'Lista con los pedidos por orden
    Dim DcPedidos As New Dictionary(Of String, Integer)                         'Diccionario que enlaza la clave de dtFinal con la posición del pedido en lstPedidos


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

    End Sub



    Private Sub FrmConsultaPrevisiones_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        'BInforme.Image = My.Resources.icons8_download_16
        'BInforme.Text = "Recibir pedidos pendientes"
        'BInforme.Width = 165
        BInforme.Visible = False

        _ruta_llegada_pedidos = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CARPETA_TEMPORAL_LLEGADA_PEDIDOS_EDI, 0, 0, 0)
        If Not _ruta_llegada_pedidos.EndsWith("\") Then _ruta_llegada_pedidos = _ruta_llegada_pedidos & "\"

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        DcPedidos.Clear()
        For Each Pedido As EDI.EDI_Pedido In lstPedidos
            Pedido = Nothing
        Next
        lstPedidos.Clear()



        Dim dtFinal As New DataTable
        dtFinal.Columns.Add("Fichero", GetType(String))
        dtFinal.Columns.Add("Tipo", GetType(String))
        dtFinal.Columns.Add("Pedido", GetType(String))
        dtFinal.Columns.Add("Fecha", GetType(DateTime))
        dtFinal.Columns.Add("CodCli", GetType(Integer))
        dtFinal.Columns.Add("Cliente", GetType(String))
        dtFinal.Columns.Add("Clave", GetType(String))



        Dim dt As New DataTable
        dt.Columns.Add("Fichero", GetType(String))



        If IO.Directory.Exists(_ruta_llegada_pedidos) Then

            Dim Dir As New IO.DirectoryInfo(_ruta_llegada_pedidos)
            Dim Archivos As IO.FileInfo() = Dir.GetFiles("CABPED*.TXT")

            For Each archivo As IO.FileInfo In Archivos

                Dim fila As DataRow = dt.NewRow()
                fila("Fichero") = archivo.Name
                dt.Rows.Add(fila)

            Next

            dtFinal = CompletarDatosPedidos(dt, dtFinal, lstPedidos, DcPedidos)

        Else
            MsgBox("La carpeta de llegada de los pedidos no existe")
        End If


        'If Not IsNothing(dtFinal) Then

        '    Dim colSel As New DataColumn("S", GetType(Boolean))
        '    colSel.DefaultValue = False
        '    dtFinal.Columns.Add(colSel)

        'End If

        Grid.DataSource = dtFinal
        GridView1.ActiveFilterString = "Tipo = 'PEDIDO NUEVO'"
        'GridView1.RowFilter = "Tipo = 'NUEVO PEDIDO'"

        AjustaColumnas()


    End Sub


    Private Function CompletarDatosPedidos(dt As DataTable, ByRef dtFinal As DataTable,
                                           ByRef lstPedidos As List(Of EDI.EDI_Pedido),
                                           ByRef DcPedidos As Dictionary(Of String, Integer)) As DataTable


        lstPedidos.Clear()      'lstPedidos: Lista con los pedidos en formato EDI
        DcPedidos.Clear()       'DcPedidos: Generamos un diccionario que guarde la clave del pedido y su posición en la lista para procesarlo después


        Dim Dir As New IO.DirectoryInfo(_ruta_llegada_pedidos)

        Dim edifile = Application.StartupPath & "\EDI.dll"
        Dim proveedor As String = LeerConfig(edifile, "proveedor")

        Dim generador As EDI.EDI_GeneradorPedidosElectronicos = EDI.EDI_GeneradorPedidosElectronicos.ObtenerGeneradorPedidos(proveedor, _ruta_llegada_pedidos)

        Dim indice As Integer = 1

        For Each row As DataRow In dt.Rows

            Dim fichero_cabecera As String = (row("Fichero").ToString & "").Trim
            Dim sufijo As String = fichero_cabecera.ToLower.Replace("cabped", "")
            Dim DcFicherosPedidos As New Dictionary(Of String, String)


            Dim Archivos As IO.FileInfo() = Dir.GetFiles("*" & sufijo)
            For Each archivo As IO.FileInfo In Archivos

                If archivo.Name.ToLower.Contains(sufijo) Then

                    Dim nombre_archivo As String = archivo.Name.ToLower.Replace(sufijo, "") & ".txt"
                    Select Case nombre_archivo.ToUpper
                        Case "CABPED.TXT", "LINPED.TXT", "OBSPED.TXT", "OBSLPED.TXT", "LOCLPED.TXT"
                            DcFicherosPedidos(nombre_archivo.ToUpper) = archivo.FullName
                    End Select

                End If

            Next



            Dim lst As List(Of EDI.EDI_Pedido) = generador.Resultado(DcFicherosPedidos)
            For Each Pedido As EDI.EDI_Pedido In lst

                Dim bMostrar As Boolean = True
                'If Pedido.Cabecera.FuncionMensaje = EDI.Comun.FuncionMensaje.Reemplazo And Not ChkMostrarReemplazos.Checked Then
                '    bMostrar = False
                'End If

                If bMostrar Then
                    Dim fila As DataRow = dtFinal.NewRow()
                    fila("Fichero") = row("Fichero")
                    Select Case Pedido.Cabecera.FuncionMensaje
                        Case EDI.Comun.FuncionMensaje.Reemplazo
                            fila("Tipo") = "REEMPLAZO"
                        Case EDI.Comun.FuncionMensaje.Original
                            fila("Tipo") = "PEDIDO NUEVO"
                        Case Else
                    End Select

                    Dim clave_pedido As String = indice.ToString & "|" & (row("Fichero").ToString & "").Trim & "|" & Pedido.ClavePedido & "|" & Pedido.NumeroPedido


                    Dim Cliente As String = ""
                    fila("Pedido") = Pedido.NumeroPedido
                    fila("Fecha") = Pedido.FechaPedido
                    fila("CodCli") = EDI.Comun.ObtenerClienteGLN(Pedido.Comprador, Cliente)
                    fila("Cliente") = Cliente
                    fila("Clave") = clave_pedido

                    DcPedidos(clave_pedido) = indice - 1

                    dtFinal.Rows.Add(fila)
                    indice = indice + 1

                End If

                Application.DoEvents()

            Next


            If Not IsNothing(lst) Then
                If lst.Count > 0 Then
                    lstPedidos.AddRange(lst)
                End If
            End If


        Next



        ''Ahora que tenemos todos los ficheros procesados, mostramos la información en el grid
        'For Each Pedido As EDI.EDI_Pedido In lstPedidos

        '    'If Pedido.ClavePedido = "1" Then

        '    '    Dim a As Integer = Pedido.Lineas.Count
        '    '    Dim b As Integer = CType(Pedido.Lineas(0), EDICOM.EDICOM_DetallePedido).ObservacionesLinea.Count
        '    '    Dim c As Integer = CType(Pedido, EDICOM.EDICOM_Pedido).ObservacionesGlobales.Count
        '    '    Dim d As Integer = CType(Pedido.Lineas(0), EDICOM.EDICOM_DetallePedido).DesgloseLinea.Count

        '    '    Dim z As Integer = 0

        '    'ElseIf Pedido.ClavePedido = "3" Then

        '    '    Dim a As Integer = Pedido.Lineas.Count
        '    '    Dim b As Integer = CType(Pedido, EDICOM.EDICOM_Pedido).ObservacionesGlobales.Count

        '    '    Dim c1 As Integer = CType(Pedido.Lineas(0), EDICOM.EDICOM_DetallePedido).DesgloseLinea.Count
        '    '    Dim d1 As Integer = CType(Pedido.Lineas(0), EDICOM.EDICOM_DetallePedido).ObservacionesLinea.Count

        '    '    Dim c2 As Integer = CType(Pedido.Lineas(1), EDICOM.EDICOM_DetallePedido).DesgloseLinea.Count
        '    '    Dim d2 As Integer = CType(Pedido.Lineas(1), EDICOM.EDICOM_DetallePedido).ObservacionesLinea.Count

        '    '    Dim z As Integer = 0

        '    'End If



        'Next


        Return dtFinal

    End Function


    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "CLAVE"
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "FICHERO"
                    c.Width = 200

                Case "TIPO"
                    c.MinWidth = 100
                    c.MaxWidth = 100

                Case "PEDIDO"
                    c.Width = 100

                Case "FECHA"
                    c.MinWidth = 75
                    c.MaxWidth = 75
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                Case "CODCLI"
                    c.MinWidth = 55
                    c.MaxWidth = 55

                Case "S"
                    c.MinWidth = 25
                    c.MaxWidth = 25
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            End Select
        Next


    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

        If column.FieldName.Trim.ToUpper = "S" Then

            If Not IsNothing(row) Then
                row("S") = Not row("S")
            End If

        Else

            Dim clave As String = (row("Clave").ToString & "").Trim
            Dim fichero As String = (row("Fichero").ToString & "").Trim
            If DcPedidos.ContainsKey(clave) Then

                Dim indice As Integer = DcPedidos(clave)

                If indice < lstPedidos.Count Then

                    Dim Pedido As EDI.EDI_Pedido = lstPedidos(indice)
                    Dim frm As New FrmVisorPedidoEDI(fichero, Pedido)
                    frm.ShowDialog()

                    If frm.Resultado = FrmVisorPedidoEDI.ResultadoFormulario.Importar Then
                        Application.DoEvents()
                        Consultar()
                    End If

                Else
                    MsgBox("ERROR, no se ha encontrado el pedido en la lista en memoria")
                End If



            Else
                MsgBox("ERROR, no se ha encontrado la clave del pedido en memoria")
            End If


        End If

    End Sub


    Private Sub BtSelNinguno_Click(sender As System.Object, e As System.EventArgs) Handles BtSelNinguno.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = False
            End If
        Next

    End Sub


    Private Sub BtSelTodos_Click(sender As System.Object, e As System.EventArgs) Handles BtSelTodos.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = True
            End If
        Next

    End Sub


    Protected Overrides Sub RowCellStyle(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn, sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        MyBase.RowCellStyle(row, column, sender, e)

        If Not IsNothing(row) Then
            If (row("Tipo").ToString & "").Trim.ToUpper = "REEMPLAZO" Then
                e.Appearance.BackColor = Color.LightSalmon
            End If
        End If

    End Sub


    'Public Overrides Sub Informe()
    '    MyBase.Informe()





    'End Sub


    Public Function ObtenerIdGeneroEAN(ByVal EAN_Articulo As String, ByRef Genero As String) As Integer

        Dim res As Integer = 0
        Genero = ""

        If EAN_Articulo.Trim <> "" Then

            Dim sql As String = "SELECT CED_IdGenero as IdGenero, GEN_NombreGenero as Genero, CED_IdPresentacion as IdPresentacion, GES_Nombre as Presentacion" & vbCrLf
            sql = sql & " FROM ClientesEDI" & vbCrLf
            sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = CED_IdGenero" & vbCrLf
            sql = sql & " LEFT JOIN GenerosSalida ON GES_IdGenSal = CED_IdPresentacion" & vbCrLf
            sql = sql & " WHERE CED_CodigoEDI = '" & EAN_Articulo & "'" & vbCrLf

            Dim dt As DataTable = cn.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 1 Then
                    MsgBox("ERROR: El código EAN del artículo se está usando en varios Códigos EDI")
                ElseIf dt.Rows.Count > 0 Then
                    Dim row As DataRow = dt.Rows(0)
                    res = VaInt(row("IdGenero"))
                    Genero = (row("Genero").ToString & "").Trim
                End If
            End If

        End If


        Return res

    End Function


End Class