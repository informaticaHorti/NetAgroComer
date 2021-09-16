Imports NetAgro.Cdatos
Imports System.Drawing

Public Class FrmSeleccionImpresora


    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro
    Dim _ListaControles As New List(Of Object)

    Dim _TipoImpresion As TipoImpresion = NetAgro.TipoImpresion.Cancelar
    Dim _Impresora As String = ""

    Dim _predeterminada As String = ""



    Public ReadOnly Property TipoImpresion As TipoImpresion
        Get
            Return _TipoImpresion
        End Get
    End Property

    Public ReadOnly Property Impresora As String
        Get
            Return _Impresora
        End Get
    End Property


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(Predeterminada As String)
        Me.new()

        _predeterminada = Predeterminada

    End Sub


    Private Sub ParametrosFrm()

        ParamCb_Copia(CbImpresoras, Nothing, Nothing, Combos.ComboImpresoras)
        CbImpresoras.Orden = 0

        'No damos la opción de no usar impresora
        Dim dt As DataTable = CbImpresoras.DataSource
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                dt.Rows.RemoveAt(0)
                CbImpresoras.DataSource = dt
            End If
        End If



    End Sub


    Private Sub FrmSeleccionImpresora_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Cargar impresora por defecto
        Dim p As New Printing.PrinterSettings
        Dim impresora_predefinida As String = p.PrinterName


        If _predeterminada.Trim <> "" Then impresora_predefinida = _predeterminada


        'La predefinida arriba 
        CbImpresoras.Text = impresora_predefinida


        btAceptar.Select()
        btAceptar.Focus()


    End Sub

    Private Sub btCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btCancelar.Click

        Me.Close()

    End Sub

    Private Sub btAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btAceptar.Click

        Dim Impresora As String = CbImpresoras.Text & ""

        If Impresora.Trim <> "" Then
            _TipoImpresion = NetAgro.TipoImpresion.ImpresoraSeleccionada
            _Impresora = Impresora
        Else
            MsgBox("Debe seleccionar una impresora")
        End If

        Me.Close()

    End Sub


    Private Sub ParamCb_Copia(ByVal Cb As CbBox, ByVal CampoBd As bdcampo, ByVal lbfija As Lb, ByVal CbCajon As CbBox)

        Cb.ClForm = Me
        Cb.Campobd = CampoBd
        If Not lbfija Is Nothing Then
            lbfija.CL_ControlAsociado = Cb
            lbfija.CL_ValorFijo = True
        End If
        Cb.DataSource = CbCajon.DataSource
        Cb.DisplayMember = CbCajon.DisplayMember
        Cb.ValueMember = CbCajon.ValueMember

    End Sub


End Class