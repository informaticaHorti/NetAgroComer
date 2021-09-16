Imports DevExpress.XtraPrinting
Imports System.Drawing

Public Class FrmConsultaVisuAsiento
    Private err As New Errores()
    Private _ListaIdAsientos As New List(Of Integer)
    Private _DtFinal As New DataTable
    Private _NumAsientos As Integer = 0
    Private _ImporteDebe As Decimal = 0
    Private _ImporteHaber As Decimal = 0

    Private _FechaAsiento As String = ""
    Private _Asiento As String = ""

    Private _Ejercicio As String = ""
    Private _IdCentro As String = ""
    Private _IdEmpresa As Integer = 0

    Private _bSoloImprimir As Boolean = False


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Public Sub New(ByVal listaIdAsiento As List(Of Integer), ByVal VB6 As Boolean, Optional ByVal ejercicioVB6 As String = "", Optional IdEmpresa As Integer = 0)

        Try

            InitializeComponent()

            _ListaIdAsientos = listaIdAsiento
            _IdEmpresa = IdEmpresa

            GridView.Appearance.Row.Font = New Font("Verdana", 8)
            GridView.Appearance.Row.ForeColor = Color.Black
            GridView.Appearance.HeaderPanel.BackColor = Color.WhiteSmoke

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase ", "New", ex.Message)
        End Try

    End Sub


    Public Sub Init(bSoloImprimir As Boolean)

        _bSoloImprimir = bSoloImprimir
        Me.Visible = Not bSoloImprimir

    End Sub


    Private Sub AjustaTamañoColumna()
        Try

            For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView.Columns
                Select Case c.FieldName.ToUpper

                    Case "NUMEROCUENTA"
                        c.Width = 40
                        c.Caption = "Cuenta"
                        c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    Case "TITULO"
                        c.Width = 70
                    Case "CONCEPTO"
                    Case "DOCUMENTO"
                        c.Width = 30
                        c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    Case "ACTSECC"
                        c.Width = 300
                        c.Caption = "Act/Secc"
                    Case "DEBE"
                        c.Width = 35
                        c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    Case "HABER"
                        c.Width = 35
                        c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

                    Case "AC"
                        c.Width = 10
                        c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                        c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                    Case "SC"
                        c.Width = 10
                        c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                        c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                    Case "ASIENTO"
                        If _ListaIdAsientos.Count > 1 Then
                            c.GroupIndex = 1
                        Else
                            c.Visible = False
                        End If


                    Case Else
                        c.Visible = False

                End Select

            Next

        Catch ex As Exception
            err.Muestraerror("Problema cuando se intentaba ajustar el tamaño de las columnas del grid", "Sub AjustaTamañoColumna", ex.Message)
        End Try

    End Sub

    Private Sub AgregaRows()

        _DtFinal = New DataTable

        _NumAsientos = 0
        _ImporteDebe = 0
        _ImporteHaber = 0


        Dim TextoAsiento As String = ""

        For i As Integer = 0 To _ListaIdAsientos.Count - 1
            Dim enti As Cdatos.Entidad = Nothing
            Dim asiento As String = ""
            Dim fecha As String = ""


            Dim IdEmpresa As Integer = MiMaletin.IdEmpresaCTB
            If _IdEmpresa <> 0 Then
                IdEmpresa = _IdEmpresa
            End If

            'enti = New E_Asientos(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
            enti = New E_Asientos(Idusuario, ConexCtb(IdEmpresa))

            enti.LeerId(_ListaIdAsientos(i))
            If i = 0 Then
                _DtFinal = ConsultaVisualizaAsiento(_ListaIdAsientos(i))
                _DtFinal.Clear()
            End If


            TextoAsiento = "nº " & CType(enti, E_Asientos).Asiento.Valor & " con fecha " & VaDate(CType(enti, E_Asientos).Fecha.Valor).ToShortDateString
            TextoAsiento = TextoAsiento & "  -  " & "Ejercicio: " & CType(enti, E_Asientos).Ejercicio.Valor & "    " & "Centro: " & CType(enti, E_Asientos).IdCentro.Valor & ""

            LbAsiento.Text = "Asiento nº " & CType(enti, E_Asientos).Asiento.Valor & " con fecha " & VaDate(CType(enti, E_Asientos).Fecha.Valor).ToShortDateString
            LbEjercicioCentro.Text = "Ejercicio: " & CType(enti, E_Asientos).Ejercicio.Valor & "    " & "Centro: " & CType(enti, E_Asientos).IdCentro.Valor & ""
            '_DtFinal.Rows.Add(DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value)
            '_DtFinal.Rows.Add(TextoAsiento, TextoFecha, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, TextoEjercicio, TextoCentro)
            _DtFinal.Rows.Add(TextoAsiento, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value)


            _FechaAsiento = VaDate(CType(enti, E_Asientos).Fecha.Valor).ToShortDateString
            _Asiento = CType(enti, E_Asientos).Asiento.Valor & ""
            _Ejercicio = CType(enti, E_Asientos).Ejercicio.Valor & ""
            _IdCentro = CType(enti, E_Asientos).IdCentro.Valor & ""


            If _ListaIdAsientos.Count > 1 Then
                LbAsiento.Text = "Varios asientos"
                LbEjercicioCentro.Text = ""
            End If



            ' Cabecera del asiento

            ' Lineas del asiento
            Dim sumaDebe As Decimal = 0
            Dim sumaHaber As Decimal = 0
            Dim dtImporte As New DataTable
            dtImporte = ConsultaVisualizaAsiento(_ListaIdAsientos(i))

            For Each dr As DataRow In dtImporte.Rows
                sumaDebe = sumaDebe + VaDec(dr("Debe"))
                sumaHaber = sumaHaber + VaDec(dr("Haber"))
                _DtFinal.Rows.Add(TextoAsiento, dr("NumeroCuenta"), dr("Titulo"), dr("Concepto").ToString.Trim, dr("Documento").ToString.Trim, dr("Ac"), dr("Sc"), dr("Debe"), dr("Haber"))
            Next

            ' Sumatoria y Pie asiento
            _DtFinal.Rows.Add(TextoAsiento, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, sumaDebe, sumaHaber)
            _ImporteDebe = _ImporteDebe + sumaDebe
            _ImporteHaber = sumaHaber + _ImporteHaber
            _NumAsientos = _NumAsientos + 1

        Next

    End Sub


    Private Function ConsultaVisualizaAsiento(id As Integer) As DataTable

        'Dim s As String = " SELECT dbo.AsientoLineas.NumeroCuenta, "
        Dim s As String = "SELECT '' as Asiento, dbo.AsientoLineas.NumeroCuenta, "
        s = s & " isnull(dbo.Cuentas.Nombre, 'CUENTA INEXISTENTE') as Titulo, "
        s = s & " dbo.AsientoLineas.Concepto, dbo.AsientoLineas.Documento, "
        s = s & " dbo.AsientoLineas.IdActividad as Ac, dbo.AsientoLineas.IdSeccion as Sc,"
        s = s & " dbo.AsientoLineas.Debe as DebeAsiento, dbo.AsientoLineas.Haber as HaberAsiento, '' as Debe, '' as Haber"

        s = s & " FROM dbo.AsientoLineas INNER JOIN dbo.Asientos ON "
        s = s & " dbo.AsientoLineas.IdAsiento = dbo.Asientos.IdAsiento LEFT OUTER JOIN "
        s = s & " dbo.Cuentas ON dbo.AsientoLineas.NumeroCuenta = dbo.Cuentas.NumeroCuenta"
        s = s & " WHERE dbo.AsientoLineas.IdAsiento= " & id.ToString

        s = s & " ORDER BY dbo.AsientoLineas.IdApunte "


        Dim IdEmpresa As Integer = MiMaletin.IdEmpresaCTB
        If _IdEmpresa <> 0 Then
            IdEmpresa = _IdEmpresa
        End If


        'Dim Asiento As New E_Asientos(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim Asiento As New E_Asientos(Idusuario, ConexCtb(IdEmpresa))
        Dim dt As DataTable = Asiento.MiConexion.ConsultaSQL(s)


        For Each row As DataRow In dt.Rows
            row("Debe") = VaDec(row("DebeAsiento")).ToString("#,##0.00")
            row("Haber") = VaDec(row("HaberAsiento")).ToString("#,##0.00")
        Next

        dt.Columns.Remove("DebeAsiento")
        dt.Columns.Remove("HaberAsiento")

        Return dt

    End Function



    Private Sub CargaGrid()

        AgregaRows()

        Grid.DataSource = _DtFinal

        AjustaTamañoColumna()

        Me.LblNumasientos.Text = "Nº de asientos= " & _NumAsientos.ToString
        Lbltotaldebe.Text = "Total debe= " & String.Format(_ImporteDebe.ToString, "C")
        LbltotalHaber.Text = "Total haber= " & String.Format(_ImporteHaber.ToString, "C")
        LblDescuadre.Text = "Descuadre= " & String.Format((_ImporteDebe - _ImporteHaber).ToString, "C")

        GridView.ExpandAllGroups()

    End Sub

    

    Private Sub FrmConsultaVisuAsiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim fuente As Font = GridView.Appearance.GroupRow.Font
        GridView.Appearance.GroupRow.Font = New Font(fuente.FontFamily, 11, FontStyle.Bold)
        GridView.Appearance.GroupRow.ForeColor = Color.Teal
        GridView.Appearance.GroupRow.BackColor = Color.White


        CargaGrid()

        If _bSoloImprimir Then

            ImpresionDirecta()
            Me.Close()

        End If


    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea


        Dim altura As Integer = 0

        Dim fuente As Font = e.Graph.Font
        Dim negrita As Font = New Font(fuente.FontFamily, 11, FontStyle.Bold)
        Dim npequeña As Font = New Font(fuente.FontFamily, 8, FontStyle.Regular)
        Dim ngrande As Font = New Font(fuente.FontFamily, 14, FontStyle.Bold)

     
        altura = altura + 10
        e.Graph.Font = npequeña
        Dim recFI As New RectangleF(0, altura, e.Graph.ClientPageSize.Width, 25)
        Dim brick As TextBrick = e.Graph.DrawString(Today.ToShortDateString, Color.Black, recFI, BorderSide.None)
        brick.HorzAlignment = DevExpress.Utils.HorzAlignment.Center


        altura = altura + 20
        e.Graph.Font = ngrande
        recFI = New RectangleF(0, altura, e.Graph.ClientPageSize.Width, 20)
        brick = e.Graph.DrawString(MiMaletin.NombreEmpresa, Color.Black, recFI, BorderSide.None)
        brick.HorzAlignment = DevExpress.Utils.HorzAlignment.Near

        If _ListaIdAsientos.Count > 1 Then

            altura = altura + 20
            e.Graph.Font = negrita
            recFI = New RectangleF(0, altura, e.Graph.ClientPageSize.Width, 20)
            brick = e.Graph.DrawString("Varios asientos", Color.Black, recFI, BorderSide.None)
            brick.HorzAlignment = DevExpress.Utils.HorzAlignment.Near

        Else

            altura = altura + 20
            e.Graph.Font = negrita
            recFI = New RectangleF(0, altura, e.Graph.ClientPageSize.Width, 20)
            brick = e.Graph.DrawString("Nº de Asiento: " & _Asiento, Color.Black, recFI, BorderSide.None)
            brick.HorzAlignment = DevExpress.Utils.HorzAlignment.Near


            altura = altura + 20

            'Ejercicio y Centro
            recFI = New RectangleF(0, altura, e.Graph.ClientPageSize.Width / 2 - 1, 25)
            brick = e.Graph.DrawString("Ejercicio: " & _Ejercicio & "    " & "Centro: " & _IdCentro, Color.Black, recFI, BorderSide.None)
            brick.HorzAlignment = DevExpress.Utils.HorzAlignment.Near

            'Fecha asiento
            recFI = New RectangleF(e.Graph.ClientPageSize.Width / 2, altura, e.Graph.ClientPageSize.Width / 2, 25)
            brick = e.Graph.DrawString("Fecha: " & _FechaAsiento, Color.Black, recFI, BorderSide.None)
            brick.HorzAlignment = DevExpress.Utils.HorzAlignment.Far

        End If


        e.Graph.Font = fuente




    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub btImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimir.Click

        Dim documento As DevExpress.XtraPrinting.PrintableComponentLink = CType(prtSystem.Links(0), DevExpress.XtraPrinting.PrintableComponentLink)
        documento.ShowPreview()

    End Sub

    Private Sub btImpresionDirecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImpresionDirecta.Click

        ImpresionDirecta()

    End Sub


    Private Sub ImpresionDirecta()

        Dim documento As DevExpress.XtraPrinting.PrintableComponentLink = CType(prtSystem.Links(0), DevExpress.XtraPrinting.PrintableComponentLink)
        Dim pd As New Printing.PrinterSettings
        documento.Print(pd.PrinterName)

    End Sub

   
End Class