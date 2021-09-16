Public Class FrVerLog

    Private err As New Errores

    Private LogUsuarioApl As New E_LogusuariosApl(Idusuario, cn)
    Private _IdLog As Integer



    Public Sub init(ByVal IdLog As Integer)

        _IdLog = IdLog


        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsView.ColumnAutoWidth = True

        GridView2.OptionsView.ShowGroupPanel = False
        GridView2.OptionsBehavior.Editable = False
        GridView2.OptionsView.ColumnAutoWidth = False

        If LogUsuarioApl.LeerId(IdLog) = True Then
            CargaDatosRegistro(LogUsuarioApl.datosregistro.Valor, True)
        End If

    End Sub


    Private Sub CargaDatosRegistro(ByVal datos As String, bRecargar As Boolean)

        Dim r As Integer = 0
        Dim v As String

        Dim Dtcol As New DataTable
        Dtcol.Columns.Add(New DataColumn("Campo"))
        Dtcol.Columns.Add(New DataColumn("Valor"))

        Dim Dtcol2 As New DataTable
        Dtcol2.Columns.Add(New DataColumn("Id"))
        Dtcol2.Columns.Add(New DataColumn("Fecha"))
        Dtcol2.Columns.Add(New DataColumn("Hora"))
        Dtcol2.Columns.Add(New DataColumn("Usuario"))
        Dtcol2.Columns.Add(New DataColumn("Operacion"))
        Dtcol2.Columns.Add(New DataColumn("DatosRegistro"))


        Dim Vcampos() As String = datos.Split("|")

        For Each enti As Cdatos.Entidad In Cdatos.ListaEntidades

            If enti.NombreTabla.ToLower.Trim = (LogUsuarioApl.tabla.Valor & "").Trim.ToLower Then

                For Each CAMPO As Cdatos.bdcampo In enti.ListadeCampos

                    If r <= UBound(Vcampos) Then
                        v = Vcampos(r)
                    Else
                        v = ""
                    End If

                    Dtcol.Rows.Add(CAMPO.NombreCampo, v)
                    r = r + 1

                Next

            End If
        Next


        Dim row As DataRow = Dtcol.NewRow()
        row("Campo") = "Operación"
        row("Valor") = LogUsuarioApl.operacion.Valor
        Dtcol.Rows.InsertAt(row, 0)


        Grid.DataSource = Dtcol




        If bRecargar Then


            Dtcol2.Columns.Add(New DataColumn(" "))

            Dim Reg As String = ""
            Dim sql As String = "Select * from LogUsuariosApl where tabla='" + LogUsuarioApl.tabla.Valor + "' and clave='" + LogUsuarioApl.clave.Valor + "' order by fecha desc"

            Dim dt As DataTable = LogUsuarioApl.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                For Each rw As DataRow In dt.Rows
                    Dtcol2.Rows.Add(rw("Id"), rw("Fecha").ToString.Substring(0, 10), rw("Hora"), rw("IdUser"), rw("Operacion"), rw("DatosRegistro"))
                Next
            End If

            Grid2.DataSource = Dtcol2

            If Not IsNothing(GridView2.Columns.ColumnByFieldName("Id")) Then GridView2.Columns.ColumnByFieldName("Id").Visible = False


        End If


    End Sub


    Private Sub FrVerLog_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        GridView2.BestFitColumns()

    End Sub


    Private Sub GridView2_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView2.RowCellStyle

        Try

            If VaInt(GridView2.GetDataRow(e.RowHandle)("Id")) = _IdLog Then
                e.Appearance.BackColor = Color.LightBlue
            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub


    Private Sub GridView2_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged

        Dim Id As String = GridView2.GetFocusedRow()("Id").ToString & ""

        If VaInt(Id) > 0 Then

            If LogUsuarioApl.LeerId(Id) Then
                CargaDatosRegistro(LogUsuarioApl.datosregistro.Valor, False)
            End If

        End If

    End Sub


    'Private Sub BImprimir_Click(sender As System.Object, e As System.EventArgs)

    '    Imprimir()

    'End Sub


    'Public Sub Imprimir()

    '    If IsNothing(Grid2.DataSource) Then
    '        MsgBox("No hay datos que imprimir")
    '        Exit Sub
    '    Else

    '        Try

    '            Dim dt As DataTable = CType(Grid2.DataSource, DataTable)
    '            If dt.Rows.Count <= 0 Then
    '                MsgBox("No hay datos que imprimir")
    '                Exit Sub
    '            End If


    '        Catch ex As Exception

    '        End Try

    '    End If

    '    If Grid2.IsPrintingAvailable Then

    '        Dim psu As New DevExpress.XtraPrinting.PrinterSettingsUsing
    '        psu.UsePaperKind = True
    '        psu.UseMargins = False

    '        prtSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
    '        prtSystem.PageSettings.AssignDefaultPrinterSettings(psu)


    '        Dim bErrorMargen As Boolean = True
    '        Dim imprime As DevExpress.XtraPrinting.PrintableComponentLink = CType(prtSystem.Links(0), DevExpress.XtraPrinting.PrintableComponentLink)


    '        imprime.Margins.Top = 50
    '        imprime.Margins.Right = 50
    '        imprime.Margins.Bottom = 50
    '        imprime.Margins.Left = 50


    '        imprime.ShowPreview()

    '    End If

    'End Sub


    'Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea

    '    Dim rec As RectangleF
    '    e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)
    '    e.Graph.Font = New Font("Arial", 13, FontStyle.Bold)

    '    Dim s As New SizeF(0, 0)

    '    Try

    '        'Logo
    '        Try

    '            If IO.File.Exists(Application.StartupPath & "\logo.png") Then

    '                Dim logo As Image = Image.FromFile(Application.StartupPath & "\logo.png")
    '                rec = New RectangleF(0, 0, logo.Size.Width, logo.Size.Height)
    '                e.Graph.DrawImage(logo, rec, DevExpress.XtraPrinting.BorderSide.None, Color.Transparent)
    '                s = logo.Size

    '            End If

    '        Catch ex As Exception

    '        End Try



    '        'Separación debajo del logo
    '        e.Graph.DrawEmptyBrick(New RectangleF(0, s.Height, e.Graph.ClientPageSize.Width, 10))

    '        'Línea debajo del logo
    '        Dim c As System.Drawing.Color = Color.FromArgb(1, 70, 127)

    '        Dim p1f As New PointF(0, s.Height + 5)
    '        Dim p2f As New PointF(e.Graph.ClientPageSize.Width, s.Height + 5)
    '        e.Graph.DrawLine(p1f, p2f, c, 1)

    '        Dim base As Single = p1f.Y + 10

    '        'Nombre del listado
    '        Dim nombrelistado As String = "LISTADO " & Grid.Text & " - " & Now.ToString("dd/MM/yyyy")
    '        If Me.Text.Trim <> "" Then nombrelistado = Me.Text & " - " & Now.ToString("dd/MM/yyyy")

    '        'Espacio en blanco debajo del nombre del listado
    '        rec = New RectangleF(0, base, e.Graph.ClientPageSize.Width, 25)
    '        e.Graph.DrawString(nombrelistado, c, rec, DevExpress.XtraPrinting.BorderSide.None)

    '        base = base + 25


    '        'Último separador en blanco
    '        e.Graph.DrawEmptyBrick(New RectangleF(0, base, e.Graph.ClientPageSize.Width, 15))



    '    Catch ex As Exception


    '    End Try

    'End Sub

End Class