Imports DevExpress.XtraEditors

Public Class FrmAnnoFondo
    Inherits FrConsulta


    Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDesdeFecha, FacturaAgr.FGR_fecha, LbDesdeFecha)
        ParamTx(TxHastaFecha, FacturaAgr.FGR_fecha, LbHastaFecha)


    End Sub


    Private Sub FrmAsientosRetencionesMes_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False

        BtAux.Text = "Actualizar facturas"
        BtAux.Width = 135
        BtAux.Image = My.Resources.App_kservices_16x16_32
        BtAux.Visible = True

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim sql As String = "SELECT IdFactura, Serie, Factura, Fecha, IdAgricultor, NumeroCuenta, IdAsiento, CuotaFondo, AnnoFondo" & vbCrLf
        sql = sql & " FROM" & vbCrLf
        sql = sql & " (" & vbCrLf
        sql = sql & " SELECT FGR_IdFactura as IdFactura, FGR_Serie as Serie, FGR_NumeroFactur as Factura, FGR_Fecha as Fecha, " & vbCrLf
        sql = sql & " FGR_IdAgricultor as IdAgricultor, NumeroCuenta, FGR_IdAsiento as IdAsiento, FGR_CuotaFondo as CuotaFondo, '2018' as AnnoFondo" & vbCrLf
        sql = sql & " FROM FacturaAgr" & vbCrLf
        sql = sql & " LEFT JOIN Contabilidad.dbo.AsientoLineas ON AsientoLineas.IdAsiento = FGR_IdAsiento" & vbCrLf
        sql = sql & " WHERE COALESCE(FGR_CuotaFondo, 0) <> 0" & vbCrLf
        sql = sql & " AND COALESCE(FGR_AnnoFondo, '') = ''" & vbCrLf
        sql = sql & " AND NumeroCuenta = CAST('554800' AS VARCHAR) + RIGHT(CAST('00000' AS VARCHAR) + CAST(FGR_IdAgricultor AS VARCHAR), 5)" & vbCrLf
        If TxDesdeFecha.Text.Trim <> "" Then sql = sql & " AND FGR_Fecha >= '" & TxDesdeFecha.Text & "'" & vbCrLf
        If TxHastaFecha.Text.Trim <> "" Then sql = sql & " AND FGR_Fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf
        sql = sql & " AND FGR_IdEmpresa = 1" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT FGR_IdFactura as IdFactura, FGR_Serie as Serie, FGR_NumeroFactur as Factura, FGR_Fecha as Fecha, " & vbCrLf
        sql = sql & " FGR_IdAgricultor as IdAgricultor, NumeroCuenta, FGR_IdAsiento as IdAsiento, FGR_CuotaFondo as CuotaFondo, '2019' as AnnoFondo" & vbCrLf
        sql = sql & " FROM FacturaAgr" & vbCrLf
        sql = sql & " LEFT JOIN Contabilidad.dbo.AsientoLineas ON AsientoLineas.IdAsiento = FGR_IdAsiento" & vbCrLf
        sql = sql & " WHERE COALESCE(FGR_CuotaFondo, 0) <> 0" & vbCrLf
        sql = sql & " AND COALESCE(FGR_AnnoFondo, '') = ''" & vbCrLf
        sql = sql & " AND NumeroCuenta = CAST('554019' AS VARCHAR) + RIGHT(CAST('00000' AS VARCHAR) + CAST(FGR_IdAgricultor AS VARCHAR), 5)" & vbCrLf
        If TxDesdeFecha.Text.Trim <> "" Then sql = sql & " AND FGR_Fecha >= '" & TxDesdeFecha.Text & "'" & vbCrLf
        If TxHastaFecha.Text.Trim <> "" Then sql = sql & " AND FGR_Fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf
        sql = sql & " AND FGR_IdEmpresa = 1" & vbCrLf
        sql = sql & " ) as G" & vbCrLf
        sql = sql & " GROUP BY IdFactura, Serie, Factura, Fecha, IdAgricultor, NumeroCuenta, IdAsiento, CuotaFondo, AnnoFondo" & vbCrLf
        sql = sql & " UNION ALL " & vbCrLf

        sql = sql & " SELECT IdFactura, Serie, Factura, Fecha, IdAgricultor, NumeroCuenta, IdAsiento, CuotaFondo, AnnoFondo" & vbCrLf
        sql = sql & " FROM" & vbCrLf
        sql = sql & " (" & vbCrLf
        sql = sql & " SELECT FGR_IdFactura as IdFactura, FGR_Serie as Serie, FGR_NumeroFactur as Factura, FGR_Fecha as Fecha, " & vbCrLf
        sql = sql & " FGR_IdAgricultor as IdAgricultor, NumeroCuenta, FGR_IdAsiento as IdAsiento, FGR_CuotaFondo as CuotaFondo, '2018' as AnnoFondo" & vbCrLf
        sql = sql & " FROM FacturaAgr" & vbCrLf
        sql = sql & " LEFT JOIN Contabilidad_2.dbo.AsientoLineas ON AsientoLineas.IdAsiento = FGR_IdAsiento" & vbCrLf
        sql = sql & " WHERE COALESCE(FGR_CuotaFondo, 0) <> 0" & vbCrLf
        sql = sql & " AND COALESCE(FGR_AnnoFondo, '') = ''" & vbCrLf
        sql = sql & " AND NumeroCuenta = CAST('554800' AS VARCHAR) + RIGHT(CAST('00000' AS VARCHAR) + CAST(FGR_IdAgricultor AS VARCHAR), 5)" & vbCrLf
        If TxDesdeFecha.Text.Trim <> "" Then sql = sql & " AND FGR_Fecha >= '" & TxDesdeFecha.Text & "'" & vbCrLf
        If TxHastaFecha.Text.Trim <> "" Then sql = sql & " AND FGR_Fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf
        sql = sql & " AND FGR_IdEmpresa = 2" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT FGR_IdFactura as IdFactura, FGR_Serie as Serie, FGR_NumeroFactur as Factura, FGR_Fecha as Fecha, " & vbCrLf
        sql = sql & " FGR_IdAgricultor as IdAgricultor, NumeroCuenta, FGR_IdAsiento as IdAsiento, FGR_CuotaFondo as CuotaFondo, '2019' as AnnoFondo" & vbCrLf
        sql = sql & " FROM FacturaAgr" & vbCrLf
        sql = sql & " LEFT JOIN Contabilidad_2.dbo.AsientoLineas ON AsientoLineas.IdAsiento = FGR_IdAsiento" & vbCrLf
        sql = sql & " WHERE COALESCE(FGR_CuotaFondo, 0) <> 0" & vbCrLf
        sql = sql & " AND COALESCE(FGR_AnnoFondo, '') = ''" & vbCrLf
        sql = sql & " AND NumeroCuenta = CAST('554019' AS VARCHAR) + RIGHT(CAST('00000' AS VARCHAR) + CAST(FGR_IdAgricultor AS VARCHAR), 5)" & vbCrLf
        If TxDesdeFecha.Text.Trim <> "" Then sql = sql & " AND FGR_Fecha >= '" & TxDesdeFecha.Text & "'" & vbCrLf
        If TxHastaFecha.Text.Trim <> "" Then sql = sql & " AND FGR_Fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf
        sql = sql & " AND FGR_IdEmpresa = 2" & vbCrLf
        sql = sql & " ) as G" & vbCrLf
        sql = sql & " GROUP BY IdFactura, Serie, Factura, Fecha, IdAgricultor, NumeroCuenta, IdAsiento, CuotaFondo, AnnoFondo" & vbCrLf
        sql = sql & " ORDER BY IDFACTURA DESC" & vbCrLf



        Dim dt As DataTable = FacturaAgr.MiConexion.ConsultaSQL(sql)

        Dim colSel As New DataColumn("S", GetType(Boolean))
        colSel.DefaultValue = False
        dt.Columns.Add(colSel)


        Grid.DataSource = dt



        AjustaColumnas()



    End Sub


    Private Sub AjustaColumnas()

        'For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
        '    Select Case c.FieldName.ToUpper.Trim
        '        Case "IMPSALDO"
        '            c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '            c.DisplayFormat.FormatString = "#,##0.00"
        '            c.Visible = False
        '    End Select
        'Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "ANNOFONDO"
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.MaxWidth = 50
                    c.MinWidth = 50
                    c.Caption = "AÑO FONDO"

                Case "S"
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.MinWidth = 20
                    c.MaxWidth = 20

            End Select
        Next

    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDesdeFecha.Text, TxHastaFecha.Text)
        If fechas <> "" Then LineasDescripcion.Add("Fecha: " & TxDesdeFecha.Text)

        MyBase.Imprimir()

    End Sub


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()


        If XtraMessageBox.Show("¿Desea actualizar las facturas de agricultores?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


            If IsNothing(Grid.DataSource) Then
                MsgBox("No hay facturas que actualizar.")
                Exit Sub
            End If

            If GridView1.RowCount = 0 Then
                MsgBox("No hay facturas que actualizar")
                Exit Sub
            End If


            Dim cont As Integer = 0

            For indice As Integer = 0 To GridView1.RowCount - 1

                Dim row As DataRow = GridView1.GetDataRow(indice)
                If Not IsNothing(row) Then
                    If row("S") = True Then

                        Dim IdFactura As String = (row("IdFactura").ToString & "").Trim
                        Dim AnnoFondo As String = (row("AnnoFondo").ToString & "").Trim

                        Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)
                        If FacturaAgr.LeerId(IdFactura) Then

                            FacturaAgr.FGR_AnnoFondo.Valor = AnnoFondo
                            FacturaAgr.Actualizar()

                        End If

                        cont = cont + 1

                    End If
                End If

                Application.DoEvents()

            Next

            MsgBox("Terminado! Se actualizaron " & cont.ToString & " facturas")
            Consultar()
            

        End If

    End Sub


    Private Sub btSelNinguno_Click(sender As System.Object, e As System.EventArgs) Handles btSelNinguno.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = False
            End If
        Next

    End Sub


    Private Sub btSelTodos_Click(sender As System.Object, e As System.EventArgs) Handles btSelTodos.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = True
            End If
        Next

    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

        If Not IsNothing(row) Then
            row("S") = Not row("S")
        End If

    End Sub

End Class