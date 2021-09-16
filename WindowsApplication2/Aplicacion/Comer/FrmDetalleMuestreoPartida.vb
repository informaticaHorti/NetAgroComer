Public Class FrmDetalleMuestreoPartida

    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro


    Private _IdLinea As String = ""


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent()

    End Sub


    Public Sub New(IdLinea As String)
        Me.New()

        _IdLinea = IdLinea

    End Sub


    Private Sub FrmDetalleMuestreoPartida_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)


        Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        If AlbEntrada_Lineas.LeerId(_IdLinea) Then

            Me.Text = "DETALLE MUESTREO PARTIDA " & AlbEntrada_Lineas.AEL_muestreo.Valor


            Dim FechaEntrada As String = ""
            Dim FechaConfeccion As String = ""
            Dim FechaMuestreo As String = ""
            If VaDate(AlbEntrada_Lineas.AEL_fechamuestreo.Valor) > VaDate("") Then FechaMuestreo = VaDate(AlbEntrada_Lineas.AEL_fechamuestreo.Valor).ToString("dd/MM/yyyy")


            Dim sql As String = "SELECT AEN_Fecha as FechaEntrada, PRD_Fecha as FechaConfeccion" & vbCrLf
            sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
            sql = sql & " LEFT JOIN Produccion ON PRD_IdLineaEntrada = AEL_IdLinea " & vbCrLf
            sql = sql & " LEFT JOIN AlbEntrada ON AEN_IdAlbaran = AEL_IdAlbaran" & vbCrLf
            sql = sql & " WHERE AEL_IdLinea = " & _IdLinea & vbCrLf
            sql = sql & " ORDER BY PRD_Fecha" & vbCrLf


            Dim dt As DataTable = AlbEntrada_Lineas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    If VaDate(dt.Rows(0)("FechaEntrada")) > VaDate("") Then FechaEntrada = VaDate(dt.Rows(0)("FechaEntrada")).ToString("dd/MM/yyyy")
                    If VaDate(dt.Rows(0)("FechaConfeccion")) > VaDate("") Then FechaConfeccion = VaDate(dt.Rows(0)("FechaConfeccion")).ToString("dd/MM/yyyy")
                End If
            End If


            lbFechaEntrada.Text = FechaEntrada
            LbFechaConfeccion.Text = FechaConfeccion
            LbFechaMuestreo.Text = FechaMuestreo


            Dim TotalKilos As Decimal = VaDec(AlbEntrada_Lineas.AEL_kilosnetos.Valor)


            sql = "SELECT IdCategoria, Categoria, TipoCat, Cantidad, 0.00 as Porcentaje" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & " SELECT ALC_IdCategoria as IdCategoria, CAE_CategoriaCalibre as Categoria, " & vbCrLf
            sql = sql & " CASE COALESCE(CAE_idtipocategoria,0) WHEN 1 THEN 'A' WHEN 2 THEN 'B' WHEN 3 THEN 'C' WHEN 4 THEN 'D' WHEN 9 THEN 'DESTRIO' ELSE '' END as TipoCat, " & vbCrLf
            sql = sql & " ALC_KilosNetos as Cantidad" & vbCrLf
            sql = sql & " FROM AlbEntrada_LineasCla" & vbCrLf
            sql = sql & " LEFT JOIN CategoriasEntrada ON CAE_id = ALC_IdCategoria" & vbCrLf
            sql = sql & " WHERE ALC_idlineaentrada = " & _IdLinea & vbCrLf
            sql = sql & " ) as G" & vbCrLf
            sql = sql & " ORDER BY TipoCat, IdCategoria" & vbCrLf

            dt = AlbEntrada_Lineas.MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then
                For Each row As DataRow In dt.Rows

                    Dim Kilos As Decimal = VaDec(row("Cantidad"))
                    Dim Porcentaje As Decimal = 0

                    If TotalKilos <> 0 Then Porcentaje = Kilos / TotalKilos * 100
                    row("Porcentaje") = Porcentaje

                Next
            End If

            Grid.DataSource = dt

            AjustaColumnas()

        End If


    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDCATEGORIA"
                    c.Visible = False
                Case "TIPOCAT"
                    c.Visible = False
                    c.GroupIndex = 1
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "CANTIDAD"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.MaxWidth = 80
                    c.Width = 80

                Case "PORCENTAJE"
                    c.Caption = "%"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    c.MinWidth = 50
                    c.MaxWidth = 50
            End Select
        Next


        AñadeResumenCampo(GridView1, "Cantidad", "{0:n0}")
        AñadeResumenCampo(GridView1, "Porcentaje", "{0:n2}")


        GridView1.ExpandAllGroups()


    End Sub


    Private Sub btSalir_Click(sender As System.Object, e As System.EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub

    
    
End Class