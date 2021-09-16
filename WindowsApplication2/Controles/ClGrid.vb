Imports System.Collections.Generic

Public Class ClGrid




    Protected _bOcultarCeros As Boolean = False

    Public Property OcultarCeros As Boolean
        Get
            Return _bOcultarCeros
        End Get
        Set(value As Boolean)
            _bOcultarCeros = value
        End Set
    End Property

    Protected _DcMostrarCeroEnColumna As New Dictionary(Of String, Boolean)

    Public ReadOnly Property MostrarCeroEnColumna As Dictionary(Of String, Boolean)
        Get
            Return _DcMostrarCeroEnColumna
        End Get
    End Property




    Dim _PrimerControl As Integer

    Public Property PrimerControl As Integer
        Set(ByVal value As Integer)
            _PrimerControl = value

        End Set
        Get
            Return _PrimerControl

        End Get
    End Property
    Dim _Cargando As Boolean

    Public Property Cargando As Boolean
        Set(ByVal value As Boolean)
            _Cargando = value

        End Set
        Get
            Return _Cargando

        End Get
    End Property

    Dim _Saliendo As Boolean

    Public Property Saliendo As Boolean
        Set(ByVal value As Boolean)
            _Saliendo = value

        End Set
        Get
            Return _Saliendo

        End Get
    End Property


    Dim _UltimoControl As Integer

    Public Property UltimoControl As Integer
        Set(ByVal value As Integer)
            _UltimoControl = value

        End Set
        Get
            Return _UltimoControl

        End Get
    End Property
    Dim _nlinea As Integer

    Public Property Nlinea As Integer
        Set(ByVal value As Integer)
            _nlinea = value

        End Set
        Get
            Return _nlinea

        End Get
    End Property

    Dim _IdLinea As String
    Public Property IdLinea As String
        Set(ByVal value As String)
            _IdLinea = value
        End Set
        Get
            Return _IdLinea

        End Get

    End Property


    Dim _Consulta As String

    Public Property Consulta As String
        Set(ByVal value As String)
            _Consulta = value

        End Set
        Get
            Return _Consulta

        End Get
    End Property

    Dim _Dtlineas As DataTable

    Public Property DtLineas As DataTable
        Set(ByVal value As DataTable)
            _Dtlineas = value

        End Set
        Get
            Return _Dtlineas

        End Get
    End Property

    Dim _EntidadLinea As Cdatos.Entidad

    Public Property EntidadLinea As Cdatos.Entidad
        Set(ByVal value As Cdatos.Entidad)
            _EntidadLinea = value

        End Set
        Get
            Return _EntidadLinea

        End Get
    End Property

    Dim _Formu As FrMantenimiento

    Public Property Formu As FrMantenimiento
        Set(ByVal value As FrMantenimiento)
            _Formu = value

        End Set
        Get
            Return _Formu

        End Get
    End Property
    Dim _ListaCamposGr As New List(Of Cdatos.PropiedadesCamposGrid)
    Public Property ListaCamposGr As List(Of Cdatos.PropiedadesCamposGrid)
        Set(ByVal value As List(Of Cdatos.PropiedadesCamposGrid))
            _ListaCamposGr = value

        End Set
        Get
            Return _ListaCamposGr


        End Get
    End Property
    Dim _LineaBloqueada As Boolean
    Public Property LineaBloqueada As Boolean
        Set(ByVal value As Boolean)
            _LineaBloqueada = value

        End Set
        Get
            Return _LineaBloqueada

        End Get
    End Property


    Public Sub Subirlinea(ByVal row As Integer)
        Dim c As String
        Dim campo As String
        campo = Me.EntidadLinea.ClavePrimaria.NombreCampo

        _LineaBloqueada = False
        Nlinea = row
        If Nlinea = Me.GridView.RowCount - 1 Then
            Nlinea = -2
            c = ""
            Me.Formu.Borralin(Me)
        Else
            c = Me.GridView.GetRowCellValue(row, campo)
            If EntidadLinea.LeerId(c) = True Then
                Formu.Entidad_a_DatosLin(Me)
                IdLinea = c
            End If
        End If

    End Sub

    Public Sub Borrar()
        Me.Grid.DataSource = Nothing
    End Sub

    Private Sub BotonAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAnular.Click
        If Formu.Modificando = True And _LineaBloqueada = False Then
            'If Formu.ListaControles(PrimerControl).enabled = True Then

            If IdLinea <> "" Then
                If MsgBox("Desea anular la línea ", vbYesNo) = vbYes Then
                    Me.EntidadLinea.Eliminar()
                    Formu.Cargalineas(Me)
                    Formu.HamodificadoGrid = True
                End If
            End If
        End If
    End Sub

    Private Sub BotonNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonNuevo.Click
        If Formu.Modificando = True Then
            'If Formu.ListaControles(PrimerControl).enabled = True Then
            Me.GridView.FocusedRowHandle = Me.GridView.RowCount - 1
            Formu.ListaControles(PrimerControl).focus()

        End If
    End Sub

    Private Sub BotonModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonModificar.Click
        If Formu.Modificando = True And _LineaBloqueada = False Then
            'If Formu.ListaControles(PrimerControl).enabled = True Then
            Formu.BloquearCamposLineas(False, Me)
            Formu.ListaControles(PrimerControl).select()
        End If

    End Sub

    Private Sub BotonSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonSalir.Click
        If Formu.ListaControles(PrimerControl).enabled = True Then
            Saliendo = True
            Formu.Siguiente(UltimoControl)

        End If


    End Sub




    Private Sub GridView_FocusedRowChanged1(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView.FocusedRowChanged
        If Cargando = False Then

            If e.FocusedRowHandle >= 0 Then
                Subirlinea(e.FocusedRowHandle)
                ' Me.GridView.TopRowIndex = e.FocusedRowHandle
            End If
        End If

    End Sub

    Private Sub GridView_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView.KeyDown
        If e.KeyCode = 13 Then
            If _LineaBloqueada = False Then
                If Formu.Modificando = True Then
                    Formu.BloquearCamposLineas(False, Me)
                    Formu.ListaControles(Me.PrimerControl).select()
                End If
            End If

        End If

    End Sub

    Private Sub GridView_RowCellClick1(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
        Subirlinea(e.RowHandle)
    End Sub

    Private Sub Grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.Click

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.GridView.OptionsCustomization.AllowSort = False 'no se puede ordenar
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub ClGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ttImprimir.SetToolTip(BotonSalir, "Salir")
        ttImprimir.SetToolTip(BotonAnular, "Anular linea")
        ttImprimir.SetToolTip(BotonModificar, "Modificar linea")
        ttImprimir.SetToolTip(BotonNuevo, "Nueva linea")

    End Sub


    Protected Overridable Sub GridView_CustomColumnDisplayText(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView.CustomColumnDisplayText

        Try

            If IsNumeric(e.Value) And VaDec(e.Value) = 0 Then

                If _bOcultarCeros Then
                    If _DcMostrarCeroEnColumna.Count = 0 Then
                        'Oculta los ceros en todos los casos
                        e.DisplayText = ""
                    Else
                        If _DcMostrarCeroEnColumna.ContainsKey(e.Column.FieldName) Then
                            If _DcMostrarCeroEnColumna.ContainsKey(e.Column.FieldName) = False Then
                                e.DisplayText = ""
                            End If
                        ElseIf e.Column.DisplayFormat.FormatString <> "" Then
                            e.DisplayText = ""
                        End If
                    End If
                Else
                    If _DcMostrarCeroEnColumna.Count > 0 Then
                        If _DcMostrarCeroEnColumna.ContainsKey(e.Column.FieldName) Then
                            If _DcMostrarCeroEnColumna(e.Column.FieldName) = False Then
                                e.DisplayText = ""
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception

        End Try



    End Sub


End Class

