
Public Class FrmSaldoEnvasesAlmacen
    Inherits FrConsulta


    Private Class stClaves_SaldosAlmacen

        Public IdEnvase As Integer = 0
        Public IdMarca As Integer = 0
        Public IdAlmacen As Integer = 0


        Public Sub New(IdEnvase As Integer, IdMarca As Integer, IdAlmacen As Integer)
            Me.IdEnvase = IdEnvase
            Me.IdMarca = IdMarca
            Me.IdAlmacen = IdAlmacen
        End Sub

    End Class

    Private Class stDatos_SaldosAlmacen

        Public Saldo As Decimal = 0

        Public Sub New(Saldo As Decimal)
            Me.Saldo = Saldo
        End Sub

    End Class




    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(ByVal Titulo As String)

        Me.New()

        Me.Text = Titulo

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato5, Nothing, Lb6, False, Cdatos.TiposCampo.Fecha)
        ParamChk(chkMarcas, Nothing, "S", "N")

    End Sub


    Private Sub FrmSaldoEnvasesAlmacen_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False

    End Sub


    Public Overrides Sub Consultar()

        MyBase.Consultar()

        Dim Valeenvase As New E_ValeEnvases(Idusuario, cn)
        Dim ValeenvaseLineas As New E_ValeEnvases_Lineas(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)
        Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)


        Dim sql As String = ""

        ' Añadir las compras y los saldos iniciales.
        If chkMarcas.Checked Then
            Dim sql1 As String = "SELECT VEL_idenvase as IdEnvase, " & vbCrLf
            sql1 = sql1 + " ENV_nombre AS Envase, " & vbCrLf
            sql1 = sql1 & " VEL_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
            sql1 = sql1 + " VEL_idalmacen as IdAlmacen, " & vbCrLf
            sql1 = sql1 + " AEV_Nombre AS Almacen, " & vbCrLf
            sql1 = sql1 + " VEL_entrega as Entrega, VEL_retira as Retira, 0 AS ExPalets" & vbCrLf
            sql1 = sql1 + " FROM ValeEnvases_Lineas " & vbCrLf
            sql1 = sql1 + " LEFT OUTER JOIN Envases ON VEL_idenvase = ENV_idenvase" & vbCrLf
            sql1 = sql1 + " LEFT OUTER JOIN ValeEnvases ON VEL_idvale = VEV_idvale" & vbCrLf
            sql1 = sql1 + " LEFT OUTER JOIN AlmacenEnvases ON VEL_idalmacen = AEV_Idalmacen" & vbCrLf
            sql1 = sql1 & " LEFT JOIN Marcas on MAR_IdMarca = VEL_IdMarca" & vbCrLf
            sql1 = sql1 + " WHERE VEV_fecha <= '" + TxDato5.Text & "'" & vbCrLf

            Dim sql2 As String = "SELECT ENI_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
            sql2 = sql2 & " ENI_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
            sql2 = sql2 & " ENI_Codigo as IdAlmacen, AEV_Nombre as Almacen," & vbCrLf
            sql2 = sql2 & " ENI_Inicial as Entrega, 0 as Retira, 0 as ExPalets " & vbCrLf
            sql2 = sql2 & " FROM EnvasesInicial" & vbCrLf
            sql2 = sql2 & " LEFT OUTER JOIN Envases ON ENI_idenvase = ENV_idenvase " & vbCrLf
            sql2 = sql2 & " LEFT OUTER JOIN AlmacenEnvases ON ENI_Codigo = AEV_Idalmacen " & vbCrLf
            sql2 = sql2 & " LEFT OUTER JOIN Marcas on MAR_IdMarca = ENI_IdMarca" & vbCrLf
            sql2 = sql2 & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString & " AND ENI_Tipo = 'AL' " & vbCrLf




            sql = "SELECT IdEnvase, Envase, IdMarca, Marca, IdAlmacen, Almacen, SUM(Entrega - Retira - ExPalets) as SALDO" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sql1 & vbCrLf
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & sql2 & vbCrLf
            sql = sql & " ) AS M" & vbCrLf
            sql = sql & " GROUP BY idenvase, IdMarca, Marca, idalmacen, Envase, Almacen" & vbCrLf
            sql = sql & " HAVING SUM(Entrega - Retira - ExPalets) <> 0" & vbCrLf

        Else
            Dim sql1 As String = "SELECT VEL_idenvase as IdEnvase, " & vbCrLf
            sql1 = sql1 + " ENV_nombre AS Envase, " & vbCrLf
            sql1 = sql1 + " VEL_idalmacen as IdAlmacen, " & vbCrLf
            sql1 = sql1 + " AEV_Nombre AS Almacen, " & vbCrLf
            sql1 = sql1 + " VEL_entrega as Entrega, VEL_retira as Retira, 0 as ExPalets" & vbCrLf
            sql1 = sql1 + " FROM ValeEnvases_Lineas " & vbCrLf
            sql1 = sql1 + " LEFT OUTER JOIN Envases ON VEL_idenvase = ENV_idenvase" & vbCrLf
            sql1 = sql1 + " LEFT OUTER JOIN ValeEnvases ON VEL_idvale = VEV_idvale" & vbCrLf
            sql1 = sql1 + " LEFT OUTER JOIN AlmacenEnvases ON VEL_idalmacen = AEV_Idalmacen" & vbCrLf
            sql1 = sql1 + " WHERE VEV_fecha <= '" + TxDato5.Text & "'" & vbCrLf

            Dim sql2 As String = "SELECT ENI_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
            sql2 = sql2 & " ENI_Codigo as IdAlmacen, AEV_Nombre as Almacen," & vbCrLf
            sql2 = sql2 & " ENI_Inicial as Entrega, 0 as Retira, 0 as ExPalets " & vbCrLf
            sql2 = sql2 & " FROM EnvasesInicial" & vbCrLf
            sql2 = sql2 & " LEFT OUTER JOIN Envases ON ENI_idenvase = ENV_idenvase " & vbCrLf
            sql2 = sql2 & " LEFT OUTER JOIN AlmacenEnvases ON ENI_Codigo = AEV_Idalmacen " & vbCrLf
            sql2 = sql2 & " LEFT OUTER JOIN Marcas on MAR_IdMarca = ENI_IdMarca" & vbCrLf
            sql2 = sql2 & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString & " AND ENI_Tipo = 'AL' " & vbCrLf




            sql = "SELECT IdEnvase, Envase, 0 as IdMarca, '' as Marca, IdAlmacen, Almacen, SUM(Entrega - Retira - ExPalets) as SALDO" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & sql1 & vbCrLf
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & sql2 & vbCrLf
            sql = sql & " ) AS M" & vbCrLf
            sql = sql & " GROUP BY idenvase, idalmacen, Envase, Almacen" & vbCrLf
            sql = sql & " HAVING SUM(Entrega - Retira - ExPalets) <> 0" & vbCrLf

        End If

        Dim DT As DataTable = Valeenvase.MiConexion.ConsultaSQL(sql)


       
        'Guarda los nombres de los almacenes 
        Dim DcAlmacenes As New Dictionary(Of Integer, String)
        For Each row As DataRow In DT.Rows
            Dim IdAlmacen As Integer = VaInt(row("IdAlmacen"))
            Dim Almacen As String = row("Almacen").ToString & ""
            DcAlmacenes(IdAlmacen) = Almacen
        Next



        'Crea la estructura del datatable final 
        Dim dtResultado As New DataTable
        dtResultado.Columns.Add(New DataColumn("IdEnvase", GetType(Integer)))
        dtResultado.Columns.Add(New DataColumn("Envase", GetType(String)))
        dtResultado.Columns.Add(New DataColumn("IdMarca", GetType(Integer)))
        dtResultado.Columns.Add(New DataColumn("Marca", GetType(String)))

        'Ordenamos las columnas de los almacenes y añade
        Dim lst As New List(Of Integer)
        For Each IdAlmacen As Integer In DcAlmacenes.Keys
            lst.Add(IdAlmacen)
            lst.Sort()
        Next
        For Each IdAlmacen As Integer In lst
            If DcAlmacenes.ContainsKey(IdAlmacen) Then
                dtResultado.Columns.Add(New DataColumn(IdAlmacen.ToString & " " & (DcAlmacenes(IdAlmacen) & "").Trim, GetType(Decimal)))
            End If
        Next

        'Añade columnas existencias en palets y total
        dtResultado.Columns.Add(New DataColumn("TOTAL", GetType(Decimal)))


        'Recorremos el datatable principal
        For Each row As DataRow In DT.Rows

            Dim IdEnvase As Integer = VaInt(row("IdEnvase"))
            Dim IdMarca As Integer = VaInt(row("IdMarca"))
            Dim IdAlmacen As Integer = VaInt(row("IdAlmacen"))

            'Buscamos la fila en el datatable nuevo
            Dim fila As DataRow = Nothing
            For Each rowRes As DataRow In dtResultado.Rows

                Dim IdEnvaseRes As Integer = VaInt(rowRes("IdEnvase"))
                Dim IdMarcaRes As Integer = VaInt(rowRes("IdMarca"))

                If IdEnvase = IdEnvaseRes And IdMarca = IdMarcaRes Then
                    fila = rowRes
                    Exit For
                End If

            Next


            'Buscamos la columna del almacén
            For Each col As DataColumn In dtResultado.Columns
                If col.ColumnName = IdAlmacen.ToString & " " & (DcAlmacenes(IdAlmacen) & "").Trim Then

                    If Not IsNothing(fila) Then
                        'Si hemos encontrado la fila en el datatable nuevo, acumulamos saldo almacén y total
                        fila(col.ColumnName) = VaDec(fila(col.ColumnName)) + VaDec(row("Saldo"))
                        fila("Total") = VaDec(fila("Total")) + VaDec(row("Saldo"))
                    Else
                        'Si no la hemos encontrado añadimos los valores, el saldo para el almacén y el total
                        fila = dtResultado.NewRow()
                        fila("IdEnvase") = IdEnvase
                        fila("Envase") = row("Envase").ToString
                        fila("IdMarca") = IdMarca
                        fila("Marca") = row("Marca").ToString
                        fila(col.ColumnName) = VaDec(row("Saldo"))
                        fila("Total") = VaDec(row("Saldo"))
                        dtResultado.Rows.Add(fila)
                    End If

                End If
            Next

        Next


        If Not chkMarcas.Checked Then
            dtResultado.Columns.Remove("Marca")
        End If


        GridView1.Columns.Clear()
        Grid.DataSource = dtResultado

        AjustaColumnas()


    End Sub

    Private Sub AjustaColumnas()

        GridView1.BestFitColumns()

        Try

            For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

                Select Case c.FieldName.ToUpper.Trim
                    Case "TIPO", "IDENVASE", "IDMARCA"
                        c.Visible = False

                    Case "IDENVASE", "ENVASE", "MARCA"

                    Case Else
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0"

                End Select

            Next

            AñadeResumenCampo("Importe", "{0:n2}")


        Catch ex As Exception
            '  err.Muestraerror("Error al ajustar la columna", "AjustaColumnas", ex.Message)
        End Try


    End Sub


    Private Sub FrmConsultaAlbaranes_AntesDeMostrarTablaDinamica(ByVal f As NetAgro.FrTablaDinamica) Handles MyBase.AntesDeMostrarTablaDinamica

        'Ejemplo para añadir descripciones al informe
        'Dim lst As New List(Of String)
        'lst.Add("Aquí se pueden añadir")
        'lst.Add("líneas de descripción")
        'f.LineasDescripcion = lst

    End Sub

    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
        Fechaspordefecto()

    End Sub
    Private Sub Fechaspordefecto()
        TxDato5.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")

    End Sub

    Private Sub FrmConsultaAlbaranes_DespuesDeIncluirCampoCalculado(ByVal c As DevExpress.XtraGrid.Columns.GridColumn) Handles MyBase.DespuesDeIncluirCampoCalculado
        AñadeResumenCampo(c.FieldName, "{0:n2}")
    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        If TxDato5.Text.Trim <> "" Then

            LineasDescripcion.Add("Hasta fecha: " & TxDato5.Text)
            If chkMarcas.Checked Then LineasDescripcion.Add("Mostrar marcas")

        End If


        MyBase.Imprimir()

    End Sub

    
End Class