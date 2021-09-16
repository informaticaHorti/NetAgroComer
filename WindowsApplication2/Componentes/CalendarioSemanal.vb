Public Class CalendarioSemanal

    Public Enum Acciones
        Cancelar
        SeleccionaFecha
        SeleccionaSemana
    End Enum


    Private _año As Integer


    Private _Accion As Acciones = Acciones.Cancelar
    Public ReadOnly Property Accion As Acciones
        Get
            Return _Accion
        End Get
    End Property

    Private _Fecha As Date
    Public ReadOnly Property Fecha As Date
        Get
            Return _Fecha
        End Get
    End Property

    Private _FechaInicioSemana As Date
    Public ReadOnly Property FechaInicioSemana As Date
        Get
            Return _FechaInicioSemana
        End Get
    End Property

    Private _FechaFinSemana As Date
    Public ReadOnly Property FechaFinSemana As Date
        Get
            Return _FechaFinSemana
        End Get
    End Property


    Private _TxDatoFecha As TxDato = Nothing
    Public Property TxDatoFecha As TxDato
        Get
            Return _TxDatoFecha
        End Get
        Set(value As TxDato)
            _TxDatoFecha = value
        End Set
    End Property

    Private _TxDatoInicioSemana As TxDato = Nothing
    Public Property TxDatoInicioSemana As TxDato
        Get
            Return _TxDatoInicioSemana
        End Get
        Set(value As TxDato)
            _TxDatoInicioSemana = value
        End Set
    End Property


    Private _TxDatoFinalSemana As TxDato = Nothing
    Public Property TxDatoFinalSemana As TxDato
        Get
            Return _TxDatoFinalSemana
        End Get
        Set(value As TxDato)
            _TxDatoFinalSemana = value
        End Set
    End Property


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Public Sub New(TxDatoFecha As TxDato)
        Me.New()

        _TxDatoFecha = TxDatoFecha

        MonthCalendar1.Select()
        MonthCalendar1.Focus()

    End Sub


    Public Sub New(TxDatoInicioSemana As TxDato, TxDatoFinalSemana As TxDato)
        Me.New()

        _TxDatoInicioSemana = TxDatoInicioSemana
        _TxDatoFinalSemana = TxDatoFinalSemana

        Grid.Select()
        Grid.Focus()


    End Sub

    Private Sub Calendario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'If _FechaInicial = VaDate("") Then _FechaInicial = Today

        Dim _FechaInicial As Date = Today

        'Por defecto, la fecha es la de hoy
        MonthCalendar1.SelectionRange.Start = _FechaInicial
        MonthCalendar1.SelectionRange.End = _FechaInicial

        CargaSemanas(MonthCalendar1.SelectionRange.Start)


    End Sub


    Public Sub Borrar()

        _Fecha = VaDate("")
        _FechaInicioSemana = VaDate("")
        _FechaFinSemana = VaDate("")

        '_FechaInicial = VaDate("")
        '_FechaInicial_InicioSemana = VaDate("")
        '_FechaInicial_FinSemana = VaDate("")

    End Sub


    'Public Sub EstableceFecha(Fecha As Date)

    '    _FechaInicial = Fecha

    '    MonthCalendar1.SelectionRange.Start = Fecha
    '    MonthCalendar1.SelectionRange.End = Fecha

    'End Sub

    'Public Sub EstableceSemana(Inicio As Date)

    '    _FechaInicial_InicioSemana = Inicio
    '    _FechaInicial_FinSemana = Inicio.AddDays(6)

    'End Sub


    Private Sub CargaSemanas(fecha As Date)

        If Not DesignMode Then

            'TODO: Leer de tabla?

            Try

                Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)

                Dim sql As String = "SELECT SEV_IdSemana as IdSemana, SEV_Semana as SEM, SEV_FechaInicialEntrada as DesdeFecha, SEV_FechaFinalEntrada as HastaFecha FROM SemanasPartes WHERE SEV_Ano = " & fecha.ToString("yyyy")
                Dim dt As DataTable = SemanasPartes.MiConexion.ConsultaSQL(sql)

                'Dim dt As New DataTable
                'dt.Columns.Add(New DataColumn("Sem", GetType(Integer)))
                'dt.Columns.Add(New DataColumn("DesdeFecha", GetType(Date)))
                'dt.Columns.Add(New DataColumn("HastaFecha", GetType(Date)))


                ''De momento, suponemos que la semana comienza en lunes
                'Dim fechaInicial As Date = VaDate("01/01/" & fecha.ToString("yyyy"))

                'Dim Fecha1 As Date
                'Dim Fecha2 As Date
                'ObtenerSemana(fechaInicial, Fecha1, Fecha2)


                'fechaInicial = Fecha1

                'Dim rowInicial As DataRow = dt.NewRow()
                'rowInicial("Sem") = DatePart(DateInterval.WeekOfYear, fechaInicial, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek)
                'rowInicial("DesdeFecha") = Fecha1
                'rowInicial("HastaFecha") = Fecha2
                'dt.Rows.Add(rowInicial)

                'fechaInicial = fechaInicial.AddDays(7)


                'Do While fechaInicial.Year = fecha.Year

                '    Dim row As DataRow = dt.NewRow()
                '    row("Sem") = DatePart(DateInterval.WeekOfYear, fechaInicial, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek)
                '    ObtenerSemana(fechaInicial, Fecha1, Fecha2)
                '    row("DesdeFecha") = Fecha1
                '    row("HastaFecha") = Fecha2
                '    dt.Rows.Add(row)

                '    fechaInicial = fechaInicial.AddDays(7)

                'Loop


                Grid.DataSource = dt

                AjustaColumnas()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try



            _año = fecha.Year


            For indice As Integer = 0 To GridView1.RowCount - 1
                Dim row As DataRow = GridView1.GetDataRow(indice)
                If Not IsNothing(row) Then

                    Dim Inicio As Date = VaDate(row("DesdeFecha"))
                    Dim Final As Date = VaDate(row("HastaFecha"))

                    If fecha >= Inicio And fecha <= Final Then
                        GridView1.FocusedRowHandle = indice
                        Exit For
                    End If

                End If
            Next


        End If


    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "DESDEFECHA"
                    c.Caption = "D.Fecha"
                    c.Width = 100
                Case "HASTAFECHA"
                    c.Caption = "H.Fecha"
                    c.Width = 100
                Case "SEM"
                    c.Width = 55

                Case Else
                    c.Visible = False

            End Select
        Next

    End Sub


    Private Sub SeleccionaSemana(row As DataRow)

        _Fecha = VaDate("")
        _FechaInicioSemana = VaDate("")
        _FechaFinSemana = VaDate("")

        _FechaInicioSemana = VaDate(row("DesdeFecha"))
        _FechaFinSemana = VaDate(row("HastaFecha"))

        'Actualizar txdato1 y txdato2
        If Not IsNothing(_TxDatoInicioSemana) Then
            If _FechaInicioSemana > VaDate("") Then
                _TxDatoInicioSemana.Text = _FechaInicioSemana.ToString("dd/MM/yyyy")
                TxDatoInicioSemana.Validar(True)
                _Accion = Acciones.SeleccionaSemana
            End If
        End If

        If Not IsNothing(_TxDatoFinalSemana) Then
            If _FechaFinSemana > VaDate("") Then
                _TxDatoFinalSemana.Text = _FechaFinSemana.ToString("dd/MM/yyyy")
                TxDatoFinalSemana.Validar(True)
                _Accion = Acciones.SeleccionaSemana
            End If
        End If

    End Sub


    Private Sub SeleccionaFecha(Fecha As Date)

        _Fecha = VaDate("")
        _FechaInicioSemana = VaDate("")
        _FechaFinSemana = VaDate("")

        _Fecha = Fecha

        'Actualizar txdato fecha
        If Not IsNothing(_TxDatoFecha) Then
            If _Fecha > VaDate("") Then
                _TxDatoFecha.Text = _Fecha.ToString("dd/MM/yyyy")
                _TxDatoFecha.Validar(True)
                _Accion = Acciones.SeleccionaFecha
            End If
        End If


    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Salir()

    End Sub


    Private Sub GridView1_RowClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick

        If IsNothing(_TxDatoFecha) Then

            Dim row As DataRow = GridView1.GetDataRow(e.RowHandle)
            If Not IsNothing(row) Then

                SeleccionaSemana(row)
                Me.Visible = False

            End If

        End If


    End Sub


    Private Sub MonthCalendar1_DateSelected(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected

        If Not IsNothing(_TxDatoFecha) Then

            SeleccionaFecha(e.Start)
            Me.Visible = False

        End If


    End Sub


    Private Sub GridView1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown

        If e.KeyCode = Keys.Enter Then

            If IsNothing(_TxDatoFecha) Then

                Dim row As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If Not IsNothing(row) Then

                    SeleccionaSemana(row)
                    Me.Visible = False

                End If

            End If

        ElseIf e.KeyCode = Keys.Escape Then

            Salir()

        End If



    End Sub


    Private Sub MonthCalendar1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MonthCalendar1.KeyDown

        If e.KeyCode = Keys.Escape Then
            Salir()
        End If

    End Sub


    Public Sub Salir()

        _Fecha = VaDate("")
        _FechaInicioSemana = VaDate("")
        _FechaFinSemana = VaDate("")

        Me.Close()

    End Sub


    Private Sub MonthCalendar1_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged


        Dim fecha As Date = VaDate("01/" & e.Start.ToString("MM") & "/" & e.Start.ToString("yyyy"))

        'Se trata de un cambio de año?
        If e.Start.Year <> _año Then

            CargaSemanas(fecha)

        Else

            For indice As Integer = 0 To GridView1.RowCount - 1

                Dim row As DataRow = GridView1.GetDataRow(indice)
                If Not IsNothing(row) Then

                    Dim Inicio As Date = VaDate(row("DesdeFecha"))
                    Dim Final As Date = VaDate(row("HastaFecha"))

                    If fecha >= Inicio And fecha <= Final Then
                        GridView1.FocusedRowHandle = indice
                        Exit For
                    End If

                End If

            Next

        End If

    End Sub

End Class