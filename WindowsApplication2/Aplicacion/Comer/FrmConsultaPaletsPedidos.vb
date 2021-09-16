
Public Class FrmConsultaPaletsPedidos
    Inherits FrConsulta


    Private Class stClaves_PaletsPedidos

        Public IdGenero As Integer = 0
        Public IdCliente As Integer = 0

        Public Sub New(IdGenero As Integer, IdCliente As Integer)
            Me.IdGenero = IdGenero
            Me.IdCliente = IdCliente
        End Sub

    End Class

    Private Class stDatos_PaletsPedidos

        Public PaletsBultos As Integer = 0

        Public Sub New(PaletsBultos As Integer)
            Me.PaletsBultos = PaletsBultos
        End Sub

    End Class


    Private Pedidos As New E_Pedidos(Idusuario, cn)
    Private PedidosLineas As New E_Pedidos_lineas(Idusuario, cn)
    Private Generos As New E_Generos(Idusuario, cn)
    Private Clientes As New E_Clientes(Idusuario, cn)
    Private CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)

    Private err As New Errores


    Private Sub ParametrosFrm()

        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Nothing, Lb1, True, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato2, Nothing, Lb2, True, Cdatos.TiposCampo.Fecha)


    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

        BInforme.Visible = False


    End Sub


    Private Sub FrmConsultaPaletsPedidos_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        GridView2.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap

        GridView1.ColumnPanelRowHeight = 50
        GridView2.ColumnPanelRowHeight = 50

    End Sub


    Public Overrides Sub Consultar()

        MyBase.Consultar()

        Grid.DataSource = Nothing
        Grid2.DataSource = Nothing

        'If VaDate(TxDato1.Text) > VaDate("")  Then
        CargaGridGeneros()
        CargaGridCalibres("")
        'End If


    End Sub


    Private Sub CargaGridGeneros()

        Dim sql As String = "SELECT PEL_idgenero AS IdGenero, GEN_NombreGenero AS Genero, PED_IdCliente as IdCliente, CLI_Nombre AS Cliente, " & vbCrLf
        If RbPalets.Checked Then
            sql = sql & " SUM(PEL_palets) AS Palets" & vbCrLf
        Else
            sql = sql & " SUM(PEL_Bultos) AS Bultos" & vbCrLf
        End If
        sql = sql & " FROM NetAgroComer.dbo.Pedidos" & vbCrLf
        sql = sql & " LEFT OUTER JOIN NetAgroComer.dbo.Pedidos_lineas ON NetAgroComer.dbo.Pedidos.PED_idpedido = NetAgroComer.dbo.Pedidos_lineas.PEL_idpedido" & vbCrLf
        sql = sql & " LEFT OUTER JOIN NetAgroComer.dbo.Generos ON NetAgroComer.dbo.Pedidos_lineas.PEL_idgenero = NetAgroComer.dbo.Generos.GEN_IdGenero" & vbCrLf
        sql = sql & " LEFT OUTER JOIN NetAgroComer.dbo.Clientes ON NetAgroComer.dbo.Pedidos.PED_idcliente = NetAgroComer.dbo.Clientes.CLI_Idcliente" & vbCrLf
        sql = sql & " WHERE PED_IdCentro = " & MiMaletin.IdCentro.ToString & vbCrLf
        'sql = sql & " WHERE Pedidos.PED_fechapedido = '" & TxDato1.Text & "'"
        If TxDato1.Text <> "" Then sql = sql & " AND PED_FechaPedido >= '" & TxDato1.Text & "'" & vbCrLf
        If TxDato2.Text <> "" Then sql = sql & " AND PED_FechaPedido <= '" & TxDato2.Text & "'" & vbCrLf
        sql = sql & " GROUP BY PEL_idgenero, GEN_NombreGenero, PED_idcliente, CLI_Nombre" & vbCrLf
        sql = sql & " ORDER BY IdCliente, Genero" & vbCrLf


        Dim dt As DataTable = Pedidos.MiConexion.ConsultaSQL(sql)


        'Transforma tabla con los clientes en las columnas
        Dim dtFinal As New DataTable
        dtFinal.Columns.Add(New DataColumn("IdGenero", GetType(String)))
        dtFinal.Columns.Add(New DataColumn("Genero", GetType(String)))
        dtFinal.Columns.Add(New DataColumn("TOTAL", GetType(Int32)))


        Dim acum As New Acumulador
        Dim DcGeneros As New Dictionary(Of Integer, String)
        Dim DcClientes As New Dictionary(Of Integer, String)

        'Crea DataTable
        For Each row As DataRow In dt.Rows

            'Columnas clientes
            Dim IdGenero As Integer = VaInt(row("IdGenero"))
            Dim IdCliente As Integer = VaInt(row("IdCliente"))
            Dim Genero As String = (row("Genero").ToString & "").Trim
            Dim Cliente As String = (row("Cliente").ToString & "").Trim
            Dim PaletsBultos As Integer = 0
            'Dim Palets As Integer = VaInt(row("Palets"))
            If RbPalets.Checked Then
                PaletsBultos = VaInt(row("Palets"))
            Else
                PaletsBultos = VaInt(row("Bultos"))
            End If

            DcGeneros(IdGenero) = Genero
            DcClientes(IdCliente) = Cliente

            If Not dtFinal.Columns.Contains(Cliente) Then dtFinal.Columns.Add(New DataColumn(Cliente, GetType(Int32)))


            'Acumulador
            Dim clave As New stClaves_PaletsPedidos(IdGenero, IdCliente)
            Dim clave_total As New stClaves_PaletsPedidos(IdGenero, 0)
            Dim datos As New stDatos_PaletsPedidos(PaletsBultos)
            Dim datos_total As New stDatos_PaletsPedidos(PaletsBultos)

            acum.Suma(clave, datos)
            acum.Suma(clave_total, datos_total)

        Next

        dtFinal.Columns.Add(New DataColumn("Separador", GetType(String)))


        'Incorporamos los datos
        For Each IdGenero As Integer In DcGeneros.Keys

            Dim row As DataRow = dtFinal.NewRow()

            Dim clave_total As New stClaves_PaletsPedidos(IdGenero, 0)
            Dim dato_total As stDatos_PaletsPedidos = acum.Dato(clave_total)

            row("IdGenero") = IdGenero
            row("Genero") = DcGeneros(IdGenero)
            If Not IsNothing(dato_total) Then row("TOTAL") = dato_total.PaletsBultos

            'Clientes
            For Each IdCliente As Integer In DcClientes.Keys

                Dim clave As New stClaves_PaletsPedidos(IdGenero, IdCliente)
                Dim dato As stDatos_PaletsPedidos = acum.Dato(clave)

                If Not IsNothing(dato) Then
                    Dim Cliente As String = DcClientes(IdCliente)
                    row(Cliente) = dato.PaletsBultos
                End If

            Next

            dtFinal.Rows.Add(row)

        Next


        'Borramos la estructura de las columnas
        GridView1.Columns.Clear()


        Grid.DataSource = dtFinal
        AjustaColumnas1()

        'Libera de la memoria las clases almacenadas en el acumulador
        acum.Borrar()


    End Sub


    Private Sub CargaGridCalibres(IdGenero As String)

        Dim sql As String = "SELECT CAS_IdTipoCalibre AS IdTipoCalibre, TCB_Nombre as Calibre, PED_IdCliente as IdCliente, CLI_Nombre AS Cliente, " & vbCrLf
        If RbPalets.Checked Then
            sql = sql & " SUM(PEL_palets) AS Palets " & vbCrLf
        Else
            sql = sql & " SUM(PEL_Bultos) AS Bultos " & vbCrLf
        End If
        sql = sql & " FROM Pedidos" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Pedidos_lineas ON PED_idpedido = PEL_idpedido " & vbCrLf
        sql = sql & " LEFT OUTER JOIN CategoriasSalida ON PEL_idcategoria = CAS_Id " & vbCrLf
        sql = sql & " LEFT OUTER JOIN Clientes ON PED_idcliente = CLI_Idcliente " & vbCrLf
        sql = sql & " LEFT OUTER JOIN TiposDeCalibre ON TCB_Id = CAS_IdTipoCalibre" & vbCrLf
        sql = sql & " WHERE PED_IdCentro = " & MiMaletin.IdCentro.ToString & vbCrLf
        'sql = sql & " WHERE PED_fechapedido = '" & TxDato1.Text & "'" & vbCrLf
        If TxDato1.Text <> "" Then sql = sql & " AND PED_FechaPedido >= '" & TxDato1.Text & "'" & vbCrLf
        If TxDato2.Text <> "" Then sql = sql & " AND PED_FechaPedido <= '" & TxDato2.Text & "'" & vbCrLf
        If IdGenero.Trim <> "" Then sql = sql & " AND PEL_IdGenero = " & IdGenero & vbCrLf
        sql = sql & " GROUP BY CAS_IdTipoCalibre, TCB_Nombre, PED_idcliente, CLI_Nombre " & vbCrLf
        sql = sql & " ORDER BY IdCliente, Calibre" & vbCrLf


        Dim dt As DataTable = Pedidos.MiConexion.ConsultaSQL(sql)



        'Transforma tabla con los clientes en las columnas
        Dim dtFinal As New DataTable
        dtFinal.Columns.Add(New DataColumn("IdTipoCalibre", GetType(String)))
        dtFinal.Columns.Add(New DataColumn("Calibre", GetType(String)))
        dtFinal.Columns.Add(New DataColumn("TOTAL", GetType(Int32)))


        Dim acum As New Acumulador
        Dim DcCalibres As New Dictionary(Of Integer, String)
        Dim DcClientes As New Dictionary(Of Integer, String)

        'Crea DataTable
        For Each row As DataRow In dt.Rows

            'Columnas clientes
            Dim IdTipoCalibre As Integer = VaInt(row("IdTipoCalibre"))
            Dim IdCliente As Integer = VaInt(row("IdCliente"))
            Dim Calibre As String = (row("Calibre").ToString & "").Trim
            Dim Cliente As String = (row("Cliente").ToString & "").Trim

            Dim PaletsBultos As Integer = 0
            'Dim Palets As Integer = VaInt(row("Palets"))

            If RbPalets.Checked Then
                PaletsBultos = VaInt(row("Palets"))
            Else
                PaletsBultos = VaInt(row("Bultos"))
            End If

            DcCalibres(IdTipoCalibre) = Calibre
            DcClientes(IdCliente) = Cliente

            If Not dtFinal.Columns.Contains(Cliente) Then dtFinal.Columns.Add(New DataColumn(Cliente, GetType(Int32)))


            'Acumulador
            Dim clave As New stClaves_PaletsPedidos(IdTipoCalibre, IdCliente)
            Dim clave_total As New stClaves_PaletsPedidos(IdTipoCalibre, 0)
            Dim datos As New stDatos_PaletsPedidos(PaletsBultos)
            Dim datos_total As New stDatos_PaletsPedidos(PaletsBultos)

            acum.Suma(clave, datos)
            acum.Suma(clave_total, datos_total)

        Next

        dtFinal.Columns.Add(New DataColumn("Separador", GetType(String)))



        'Incorporamos los datos
        For Each IdTipoCalibre As Integer In DcCalibres.Keys

            Dim row As DataRow = dtFinal.NewRow()

            Dim clave_total As New stClaves_PaletsPedidos(IdTipoCalibre, 0)
            Dim dato_total As stDatos_PaletsPedidos = acum.Dato(clave_total)

            row("IdTipoCalibre") = IdTipoCalibre
            row("Calibre") = DcCalibres(IdTipoCalibre)
            If Not IsNothing(dato_total) Then row("TOTAL") = dato_total.PaletsBultos

            'Clientes
            For Each IdCliente As Integer In DcClientes.Keys

                Dim clave As New stClaves_PaletsPedidos(IdTipoCalibre, IdCliente)
                Dim dato As stDatos_PaletsPedidos = acum.Dato(clave)

                If Not IsNothing(dato) Then
                    Dim Cliente As String = DcClientes(IdCliente)
                    row(Cliente) = dato.PaletsBultos
                End If

            Next

            dtFinal.Rows.Add(row)

        Next



        'Borramos la estructura de las columnas
        GridView2.Columns.Clear()


        Grid2.DataSource = dtFinal
        AjustaColumnas2()


        'Libera de la memoria las clases almacenadas en el acumulador
        acum.Borrar()


    End Sub


    Private Sub AjustaColumnas1()

        GridView1.BestFitColumns()
        GridView1.OptionsBehavior.Editable = False

        Try

            For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

                Select Case c.FieldName.ToUpper.Trim

                    Case "IDPEDIDO", "IDCATEGORIA", "IDGENERO", "IDTIPOCALIBRE"
                        c.Visible = False

                    Case "GENERO"
                        c.MaxWidth = 250
                        c.MinWidth = 250
                        c.Caption = "GENEROS"

                    Case "TOTAL"
                        c.MaxWidth = 50
                        c.MinWidth = 50
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0"
                        Funciones.AñadeResumenCampo(GridView1, c.FieldName, "{0:n0}")

                    Case "SEPARADOR"
                        c.Caption = " "


                    Case Else
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0"
                        c.Width = 90
                        Funciones.AñadeResumenCampo(GridView1, c.FieldName, "{0:n0}")

                End Select

            Next


        Catch ex As Exception
            err.Muestraerror("Error al ajustar la columna", "AjustaColumnas", ex.Message)
        End Try

    End Sub


    Private Sub AjustaColumnas2()

        GridView2.BestFitColumns()
        GridView2.OptionsBehavior.Editable = False

        Try

            For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView2.Columns

                Select Case c.FieldName.ToUpper.Trim

                    Case "IDPEDIDO", "IDCATEGORIA", "IDGENERO", "IDTIPOCALIBRE"
                        c.Visible = False

                    Case "CALIBRE"
                        c.Caption = "CALIBRES"
                        c.MaxWidth = 250
                        c.MinWidth = 250

                    Case "TOTAL"
                        c.MaxWidth = 50
                        c.MinWidth = 50
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0"
                        Funciones.AñadeResumenCampo(GridView2, c.FieldName, "{0:n0}")

                    Case "SEPARADOR"
                        c.Caption = " "


                    Case Else
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0"
                        c.Width = 90
                        Funciones.AñadeResumenCampo(GridView2, c.FieldName, "{0:n0}")

                End Select

            Next


        Catch ex As Exception
            err.Muestraerror("Error al ajustar la columna", "AjustaColumnas", ex.Message)
        End Try

    End Sub


    Public Overrides Sub Imprimir()

        If Not IsNothing(Grid.DataSource) Then

            If CType(Grid.DataSource, DataTable).Rows.Count > 0 Then
            
                prtSystem.Links.Clear()

                Dim linkGeneros As New DevExpress.XtraPrinting.PrintableComponentLink(prtSystem)
                linkGeneros.Component = Grid

                Dim linkCalibres As New DevExpress.XtraPrinting.PrintableComponentLink(prtSystem)
                linkCalibres.Component = Grid2

                Dim linkContainer As New DevExpress.XtraPrintingLinks.CompositeLink(prtSystem)
                linkContainer.Links.Add(linkGeneros)
                linkContainer.Links.Add(linkCalibres)

                AddHandler linkContainer.CreateDetailHeaderArea, AddressOf CompositeLink_CreateInnerPageHeaderArea



                prtSystem.Links.Add(linkGeneros)
                prtSystem.Links.Add(linkCalibres)
                prtSystem.Links.Add(linkContainer)


                prtSystem.PreviewRibbonFormEx.MdiParent = Me.MdiParent
                prtSystem.PreviewRibbonFormEx.WindowState = FormWindowState.Maximized


                Dim documentoGeneros As DevExpress.XtraPrinting.PrintableComponentLink = CType(prtSystem.Links(0), DevExpress.XtraPrinting.PrintableComponentLink)
                documentoGeneros.ClearDocument()
                documentoGeneros.Margins.Left = 50
                documentoGeneros.Margins.Right = 50
                documentoGeneros.Margins.Top = 50
                documentoGeneros.Margins.Bottom = 50
                documentoGeneros.PaperKind = System.Drawing.Printing.PaperKind.A4
                documentoGeneros.Landscape = True


                Dim documentoCalibres As DevExpress.XtraPrinting.PrintableComponentLink = CType(prtSystem.Links(1), DevExpress.XtraPrinting.PrintableComponentLink)
                documentoCalibres.ClearDocument()
                documentoCalibres.Margins.Left = 50
                documentoCalibres.Margins.Right = 50
                documentoCalibres.Margins.Top = 50
                documentoCalibres.Margins.Bottom = 50
                documentoCalibres.PaperKind = System.Drawing.Printing.PaperKind.A4
                documentoCalibres.Landscape = True


                Dim contenedor As DevExpress.XtraPrintingLinks.CompositeLink = CType(prtSystem.Links(2), DevExpress.XtraPrintingLinks.CompositeLink)
                contenedor.ClearDocument()
                contenedor.Margins.Left = 50
                contenedor.Margins.Right = 50
                contenedor.Margins.Top = 50
                contenedor.Margins.Bottom = 50
                contenedor.PaperKind = System.Drawing.Printing.PaperKind.A4
                contenedor.Landscape = True

                contenedor.Links.Clear()
                contenedor.Links.Add(documentoGeneros)
                contenedor.Links.Add(documentoCalibres)

                prtSystem.PreviewRibbonFormEx.MdiParent = Me.MdiParent
                prtSystem.PreviewRibbonFormEx.WindowState = FormWindowState.Maximized


                contenedor.CreateDocument()
                contenedor.ShowPreview()

            Else
                MsgBox("No hay nada que imprimir")
            End If

        Else
            MsgBox("No hay datos que imprimir")
        End If


    End Sub


    Private Sub CompositeLink_CreateInnerPageHeaderArea(sender As System.Object, e As DevExpress.XtraPrinting.CreateAreaEventArgs)

        Dim fuente_defecto As Font = e.Graph.Font
        Dim c As System.Drawing.Color = Color.FromArgb(1, 70, 127)
        Dim titulo As String = "PALETS DE PEDIDOS " & " - " & Today.ToString("dd/MM/yyyy")
        Dim titulo2 As String = "Pedidos desde fecha " & TxDato1.Text & " hasta fecha " & TxDato2.Text
        Dim palets_bultos As String = ""
        If RbPalets.Checked Then
            palets_bultos = "palets"
        Else
            palets_bultos = "bultos"
        End If
        Dim titulo3 As String = "Listado de " & palets_bultos
        Dim xpos As Integer = 10
        Dim al As DevExpress.Utils.HorzAlignment = DevExpress.Utils.HorzAlignment.Near

        Try

            'Logo
            Dim fichero_logo As String = "logo.png"

            Select Case MiMaletin.IdEmpresaCTB
                Case 1
                    fichero_logo = "logo.png"
                Case Else
                    fichero_logo = "logo_" & MiMaletin.IdEmpresaCTB.ToString & ".png"
            End Select

            Dim ficheroLogo As String = Application.StartupPath & "\" & fichero_logo
            If System.IO.File.Exists(ficheroLogo) Then
                Dim logo As Image = Image.FromFile(ficheroLogo)
                If Not IsNothing(logo) Then
                    e.Graph.DrawImage(logo, New RectangleF(0, 0, logo.Width, logo.Height), DevExpress.XtraPrinting.BorderSide.None, Color.Transparent)
                End If

                xpos = 350
                al = DevExpress.Utils.HorzAlignment.Far
            Else

                e.Graph.Font = New Font("Arial", 15, FontStyle.Bold)
                Dim recf As New RectangleF(xpos, 10, 343, 25)
                Dim empresa As DevExpress.XtraPrinting.TextBrick = e.Graph.DrawString(MiMaletin.NombreEmpresa, c, recf, DevExpress.XtraPrinting.BorderSide.None)

            End If


            e.Graph.Font = New Font("Arial", 12, FontStyle.Bold)
            Dim rec As New RectangleF(xpos, 45, 600, 25)
            Dim brick As DevExpress.XtraPrinting.TextBrick = e.Graph.DrawString(titulo, c, rec, DevExpress.XtraPrinting.BorderSide.None)
            brick.HorzAlignment = DevExpress.Utils.HorzAlignment.Near

            rec = New RectangleF(xpos, 65, 600, 25)
            brick = e.Graph.DrawString(titulo2, c, rec, DevExpress.XtraPrinting.BorderSide.None)
            brick.HorzAlignment = DevExpress.Utils.HorzAlignment.Near

            rec = New RectangleF(xpos, 85, 600, 25)
            brick = e.Graph.DrawString(titulo3, c, rec, DevExpress.XtraPrinting.BorderSide.None)
            brick.HorzAlignment = DevExpress.Utils.HorzAlignment.Near


        Catch ex As Exception
            err.Muestraerror("Error al imprimir zona cabecera", "CompositeLink1_CreateInnerPageHeaderArea", ex.Message)
        End Try


        e.Graph.Font = fuente_defecto

    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

        Dim IdGenero As String = row("IdGenero").ToString & ""
        CargaGridCalibres(IdGenero)

    End Sub



End Class