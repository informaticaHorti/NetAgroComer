Imports System.Drawing
Imports DevExpress.XtraEditors

Public MustInherit Class Listado_ImpresionBase

    Private mListado As Listado
    Public Property Listado() As Listado
        Get
            Return mListado
        End Get
        Set(ByVal value As Listado)
            mListado = value
        End Set
    End Property

    Private mMargenIzq As Integer
    Public Property MargenIzq() As Integer
        Get
            Return mMargenIzq
        End Get
        Set(ByVal value As Integer)
            mMargenIzq = value
        End Set
    End Property

    Private mMargenDer As Integer
    Public Property MargenDer() As Integer
        Get
            Return mMargenDer
        End Get
        Set(ByVal value As Integer)
            mMargenDer = value
        End Set
    End Property

    Private mMargenSup As Integer
    Public Property MargenSup() As Integer
        Get
            Return mMargenSup
        End Get
        Set(ByVal value As Integer)
            mMargenSup = value
        End Set
    End Property

    Private mMargenInf As Integer
    Public Property MargenInf() As Integer
        Get
            Return mMargenInf
        End Get
        Set(ByVal value As Integer)
            mMargenInf = value
        End Set
    End Property

    Public MustOverride Sub ImprimirListado()

    Public Sub EstableceListado(ByVal ori As Orientacion, Optional TipoImpresion As TipoImpresion = TipoImpresion.Preliminar)
        Me.Listado = New Listado

        If IsNothing(MargenDer) Or MargenDer = 0 Then MargenDer = 12
        If IsNothing(MargenIzq) Or MargenIzq = 0 Then MargenIzq = 12
        If IsNothing(MargenSup) Or MargenSup = 0 Then MargenSup = 12
        If IsNothing(MargenInf) Or MargenInf = 0 Then MargenInf = 12

        Dim landscape As Boolean = False
        If ori = Orientacion.Horizontal Then landscape = True

        Listado.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
        Listado.f.documento.PageLayout.PageSettings.Landscape = landscape
        Listado.f.documento.PageLayout.PageSettings.TopMargin = MargenSup.ToString & "mm"
        Listado.f.documento.PageLayout.PageSettings.RightMargin = MargenDer.ToString & "mm"
        Listado.f.documento.PageLayout.PageSettings.BottomMargin = MargenInf.ToString & "mm"
        Listado.f.documento.PageLayout.PageSettings.LeftMargin = MargenIzq.ToString & "mm"


        Listado.EstableceListado(TipoImpresion)

    End Sub


    Public Sub Dispose()
        Listado.Dispose()
    End Sub

    Protected Sub Previsualiza()
        Listado.Imprimir(TipoImpresion.Preliminar)
        'Listado.Dispose()
    End Sub

    Protected Sub ImprimeDirecto()
        Listado.Imprimir(TipoImpresion.ImpresoraPorDefecto)
        Listado.Dispose()
    End Sub


End Class
