Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraPrintingLinks
Imports System.Runtime

Public Class miInforme

    Dim WithEvents _Informe As CompositeLink
    Dim rpt As New PrintingSystem

    Private lineaCabecera As Single = 0
    Private _lineasCab As New List(Of TextBrick)
    Private _lineasPie As New List(Of TextBrick)
    Private lineaPie As Single = 0

    Private _logo As miLogo


    Public Property Contenedor As CompositeLink
        Get
            Return _Informe
        End Get
        Set(ByVal value As CompositeLink)
            _Informe = value
        End Set
    End Property
   

    Public Sub Dispose()


        If Not IsNothing(_lineasCab) Then

            For Each tb As TextBrick In _lineasCab
                tb.Dispose()
                tb = Nothing
            Next

        End If

        If Not IsNothing(_lineasPie) Then

            For Each tb As TextBrick In _lineasPie
                tb.Dispose()
                tb = Nothing
            Next

        End If



        If Not IsNothing(_Informe) Then

            For Each Link In _Informe.Links
                If Not IsNothing(Link) Then
                    Link.ClearDocument()
                    'Link.Dispose()
                    Link = Nothing
                End If
            Next
        End If


        rpt.Dispose()
        rpt = Nothing

        _lineasCab.Clear()
        _lineasCab = Nothing

        _lineasPie.Clear()
        _lineasPie = Nothing

        
        If Not IsNothing(_Informe) Then

            Try
                _Informe.ClearDocument()
            Catch ex As Exception
            End Try

            _Informe.Dispose()
            _Informe = Nothing
        End If



        If Not IsNothing(_logo) Then
            _logo.Dispose()
            _logo = Nothing
        End If



        'GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce
        GC.Collect()

    End Sub
    Public Sub New(ByVal apaisado As Boolean)

        _Informe = New CompositeLink(rpt)
        _Informe.Landscape = apaisado

        _Informe.Margins.Left = 1
        _Informe.Margins.Right = 30
        _Informe.Margins.Top = 50
        _Informe.Margins.Bottom = 50

        Dim pie As DevExpress.XtraPrinting.PageFooterArea = New DevExpress.XtraPrinting.PageFooterArea
        pie.Content.Add("")
        pie.Content.Add("Página [Page # of Pages #]")
        pie.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Center
        pie.Font = New Font("Tahoma", 10, FontStyle.Regular)

        Dim AreaPie As DevExpress.XtraPrinting.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(Nothing, pie)
        _Informe.PageHeaderFooter = AreaPie

        If ImpresionDePrueba.Trim.ToUpper = "S" Then
            _Informe.PrintingSystemBase.Watermark.Text = "Prueba impresión"
        End If


    End Sub




    Public Sub AñadeDetalles(ByVal detalle As LinkBase)
        _Informe.Links.Add(detalle)
    End Sub

    Public Sub AñadeDetalles(ByVal detalle As subInforme)
        For Each lbase As LinkBase In detalle.detalles
            _Informe.Links.Add(lbase)
        Next

    End Sub

    Public Sub AñadeDetalles(ByVal detalle As miFactura)
        For Each lbase As LinkBase In detalle.detalles
            _Informe.Links.Add(lbase)
        Next

    End Sub


    Public Sub Cabecera(ByVal txlinea As String, ByVal txAncho As String, ByVal _stilo As milinea.stilos)

        _lineasCab.AddRange(New milinea().linea(txlinea, txAncho, _stilo, lineaCabecera))
        lineaCabecera += _lineasCab(_lineasCab.Count - 1).Font.Height
        Application.DoEvents()

    End Sub


    Public Sub Pie(ByVal txlinea As String, ByVal txAncho As String, ByVal _stilo As milinea.stilos)

        _lineasPie.AddRange(New milinea().linea(txlinea, txAncho, _stilo, lineaPie))
        lineaPie += _lineasPie(_lineasPie.Count - 1).Font.Height
        Application.DoEvents()

    End Sub

    Public Sub logo(ByVal pathlogo As String, ByVal x1 As Single, ByVal y1 As Single)

        _logo = New miLogo(pathlogo, x1, y1)

    End Sub
    Public Sub logo(ByVal pathlogo As String, ByVal x1 As Single, ByVal y1 As Single, ByVal x2 As Single, ByVal y2 As Single)

        _logo = New miLogo(pathlogo, x1, y1, x2, y2)

    End Sub


    Private Sub composLink_CreateDetailHeaderArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs) Handles _Informe.CreateDetailHeaderArea

        For Each txLin As TextBrick In _lineasCab
            e.Graph.DrawBrick(txLin)
            'Application.DoEvents()
        Next txLin

        If Not IsNothing(_logo) Then
            If Not IsNothing(_logo.logo) Then
                e.Graph.DrawImage(_logo.logo, New RectangleF(_logo.x1, _logo.y1, _logo.x2, _logo.y2), DevExpress.XtraPrinting.BorderSide.None, Color.Transparent)
                'Application.DoEvents()
            End If
        End If


    End Sub

    Private Sub composLink_CreateDetailFooterArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs) Handles _Informe.CreateDetailFooterArea
        For Each txLin As TextBrick In _lineasPie
            e.Graph.DrawBrick(txLin)
            'Application.DoEvents()
        Next txLin

    End Sub

    Public Sub Preliminar(ByVal miLook As DevExpress.LookAndFeel.UserLookAndFeel)

        Application.DoEvents()
        _Informe.ShowRibbonPreviewDialog(miLook)
        Application.DoEvents()

    End Sub


    Public Sub ImpresionDirecta()

        Application.DoEvents()
        AñadirLog("impresion directa")
        Dim impresora As New Printing.PrinterSettings
        AñadirLog("_informe_print")
        _Informe.PrintingSystem.ShowPrintStatusDialog = False
        _Informe.Print(impresora.PrinterName)
        AñadirLog("_informe_print terminado")
        Application.DoEvents()

        impresora = Nothing

    End Sub

    Private Sub AñadirLog(Proceso As String)
        If Idusuario = 41 Or Idusuario = 39 Then

            Dim NombreFic As String = Application.StartupPath + "\Factura_" + Format(Now, "HHmm") + ".log"
            Dim Fs As New System.IO.FileStream(NombreFic, IO.FileMode.Append)
            Dim wr As New IO.StreamWriter(Fs)
            wr.WriteLine(Format(Now, "HHmmss") + "_" + Proceso)
            wr.Close()
            Fs.Close()
        End If
    End Sub


    Public Sub ImpresionDirecta(Impresora As String)

        Application.DoEvents()

        Try
            AñadirLog("impresion directa 2")
            _Informe.PrintingSystem.ShowPrintStatusDialog = False
            _Informe.Print(Impresora)
            AñadirLog("impresion directa 2 terminado")

        Catch ex As Exception
            MsgBox("Error al imprimir documento por la impresora " & Impresora)
        End Try

        Application.DoEvents()

    End Sub



End Class


Public Class miLogo

    Public logo As Image
    Public x1 As Single
    Public y1 As Single
    Public x2 As Single
    Public y2 As Single

    Public Sub New(ByVal pathlogo As String, ByVal _x1 As Single, ByVal _y1 As Single)
        If System.IO.File.Exists(pathlogo) Then
            logo = Image.FromFile(pathlogo)
        End If
        x1 = _x1
        y1 = _y1
        x2 = logo.Width
        y2 = logo.Height

    End Sub

    Public Sub New(ByVal pathlogo As String, ByVal _x1 As Single, ByVal _y1 As Single, ByVal _x2 As Single, ByVal _y2 As Single)
        If System.IO.File.Exists(pathlogo) Then
            logo = Image.FromFile(pathlogo)
        End If
        x1 = _x1
        y1 = _y1
        x2 = _x2
        y2 = _y2
    End Sub
    Public Sub Dispose()
        logo.Dispose()
    End Sub

End Class


Public Class subInforme


    Private linkCabecera As New Link
    Private linkPie As New Link
    Private linkDetalle As New PrintableComponentLink
    Private lineaCabecera As Single = 0
    Private _lineasCab As New List(Of TextBrick)

    Private _lineasPie As New List(Of TextBrick)
    Private lineaPie As Single = 0



    Public Sub New()

        AddHandler linkCabecera.CreateDetailArea, AddressOf linkCabecera_CreateDetailArea
        AddHandler linkPie.CreateDetailArea, AddressOf linkPie_CreateDetailArea



        linkCabecera.Margins.Left = 1
        linkCabecera.Margins.Right = 30
        linkCabecera.Margins.Top = 50
        linkCabecera.Margins.Bottom = 50

        linkDetalle.Margins.Left = 1
        linkDetalle.Margins.Right = 30
        linkDetalle.Margins.Top = 50
        linkDetalle.Margins.Bottom = 50

        linkPie.Margins.Left = 1
        linkPie.Margins.Right = 30
        linkPie.Margins.Top = 50
        linkPie.Margins.Bottom = 50

    End Sub


    Public Sub Dispose()

        linkCabecera.ClearDocument()
        linkCabecera.Dispose()
        linkCabecera = Nothing

        linkPie.ClearDocument()
        linkPie.Dispose()
        linkPie = Nothing

        linkDetalle.ClearDocument()
        linkDetalle.Dispose()
        linkDetalle = Nothing


        If Not IsNothing(_lineasCab) Then

            For Each tb As TextBrick In _lineasCab
                tb.Dispose()
                tb = Nothing
            Next

        End If

        If Not IsNothing(_lineasPie) Then

            For Each tb As TextBrick In _lineasPie
                tb.Dispose()
                tb = Nothing
            Next

        End If

        GC.Collect()

    End Sub



    Public Sub AñadeDetalles(ByVal detalle As IPrintable)
        linkDetalle.Component = detalle
        'linkDetalle.Component.
    End Sub

    Public Sub Detalle(ByVal txlinea As String, ByVal txAncho As String, ByVal _stilo As milinea.stilos)
        Cabecera(txlinea, txAncho, _stilo)

    End Sub

    Public Sub SaltoPagina()
        Cabecera(vbFormFeed, 50, milinea.stilos.Normal)

    End Sub

    Public Sub Cabecera(ByVal txlinea As String, ByVal txAncho As String, ByVal _stilo As milinea.stilos)

        _lineasCab.AddRange(New milinea().linea(txlinea, txAncho, _stilo, lineaCabecera))
        lineaCabecera += _lineasCab(_lineasCab.Count - 1).Font.Height
        Application.DoEvents()

    End Sub


    Public Sub Pie(ByVal txlinea As String, ByVal txAncho As String, ByVal _stilo As milinea.stilos)

        _lineasPie.AddRange(New milinea().linea(txlinea, txAncho, _stilo, lineaPie))
        lineaPie += _lineasPie(_lineasPie.Count - 1).Font.Height
        Application.DoEvents()

    End Sub


    Private Sub linkCabecera_CreateDetailArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)

        For Each txLin As TextBrick In _lineasCab
            If txLin.Text = vbFormFeed Then
                linkCabecera.PrintingSystem.InsertPageBreak(txLin.Rect.Y + txLin.Rect.Height + 1)
            Else
                e.Graph.DrawBrick(txLin)
                'Application.DoEvents()
            End If
        Next txLin

        'For Each txLin As TextBrick In _lineasCab2
        '    If txLin.Text = vbFormFeed Then
        '        linkCabecera.PrintingSystem.InsertPageBreak(txLin.Rect.Y + txLin.Rect.Height + 1)
        '    Else
        '        e.Graph.DrawBrick(txLin)
        '    End If
        'Next txLin


    End Sub


    Private Sub linkPie_CreateDetailArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
        For Each txLin As TextBrick In _lineasPie
            If txLin.Text = vbFormFeed Then
                linkPie.PrintingSystem.InsertPageBreak(txLin.Rect.Y + txLin.Rect.Height + 1)
            Else
                e.Graph.DrawBrick(txLin)
                'Application.DoEvents()
            End If

        Next txLin
    End Sub

    Public ReadOnly Property detalles As List(Of LinkBase)
        Get
            Dim _detalles As New List(Of LinkBase)
            If _lineasCab.Count > 0 Then
                _detalles.Add(linkCabecera)
            End If
            If Not linkDetalle Is Nothing Then
                _detalles.Add(linkDetalle)
            End If
            If _lineasPie.Count > 0 Then
                _detalles.Add(linkPie)
            End If
            Return _detalles

        End Get
    End Property


End Class


Public Class milinea

    Public Enum stilos
        Cabecera
        Grande
        Normal
        Reducida
        Minima
        Titulo
        GrandeBold
        GrandeBoldLineaDebajo
        GrandeBoldLineaEncima
        GrandeBoldLineaFinaDebajo
        GrandeBoldLineaFinaEncima
        NormalBold
        NormalBoldLineaDebajo
        NormalBoldLineaEncima
        NormalBoldCursiva
        ReducidaBold
        ReducidaBoldLineaDebajo
        ReducidaBoldLineaEncima
        ReducidaBoldLineaFinaDebajo
        ReducidaBoldLineaFinaEncima
        ReducidaBoldCuadro
        MinimaBold
        MinimaBoldLineaEncima
        MinimaBoldLineaDebajo
        Custom

    End Enum

    Public Enum Alineacion
        Izquierda = 1
        Derecha = 3
        Centro = 2
    End Enum

    Dim tLineas As New List(Of TextBrick)

    Public Sub New()

    End Sub


    Public Sub Dispose()

        For Each tb As TextBrick In tLineas
            tb.Dispose()
            tb = Nothing
        Next

    End Sub


    Public Function linea(ByVal txlinea As String, ByVal txAncho As String, ByVal _stilo As stilos, ByVal x_linea As Single, Optional ByVal fuente As Font = Nothing)

        Dim misLineas() As String = txlinea.Split("|")
        Dim misAnchos() As String = txAncho.Split("|")
        Dim _x As Single = 0
        Dim ancho As Single = 0

        Dim alin As Alineacion
        Dim pos As Integer = 1
        For lin As Integer = 0 To misAnchos.Length - 1
            pos = 1
            alin = Alineacion.Izquierda
            If Len(misAnchos(lin)) > 0 Then
                Select Case misAnchos(lin).Substring(0, 1)
                    Case ">"
                        alin = Alineacion.Derecha
                    Case "="
                        alin = Alineacion.Centro
                    Case "<"
                        alin = Alineacion.Izquierda
                    Case Else
                        alin = Alineacion.Izquierda
                        pos = 0
                End Select
                ancho = misAnchos(lin).Substring(pos)
                Try
                    tLineas.Add(mistilo(misLineas(lin), _x, x_linea, ancho, _stilo, alin, fuente))

                Catch ex As Exception

                End Try
                _x += ancho

            End If


        Next
        Return tLineas

    End Function

    Public ReadOnly Property _lineas() As List(Of TextBrick)
        Get
            Return tLineas
        End Get
    End Property


    Public Function mistilo(ByVal miTexto As String, ByVal x As Single, ByVal y As Single, ByVal x_ancho As Single, ByVal _Stilo As stilos, ByVal _alin As Alineacion, ByVal _Fuente As Font, Optional alto_en_mm As Single = 0) As TextBrick


        Dim _miText As New TextBrick
        Dim lineaDebajo As Boolean = False
        Dim lineaEncima As Boolean = False
        Dim grosorlinea As Decimal = 1


        _miText.Text = miTexto
        _miText.BackColor = Color.Transparent
        _miText.BorderWidth = 0

        _miText.HorzAlignment = _alin


        Dim MargenAlto As Integer = 0

        Select Case _Stilo
            Case stilos.Cabecera
                _miText.Font = New Font("Tahoma", 16, FontStyle.Bold)

            Case stilos.Grande
                _miText.Font = New Font("Tahoma", 12)

            Case stilos.Minima
                _miText.Font = New Font("Tahoma", 6)

            Case stilos.Normal
                _miText.Font = New Font("Tahoma", 10)

            Case stilos.Reducida
                _miText.Font = New Font("Tahoma", 8)


            Case stilos.GrandeBold
                _miText.Font = New Font("Tahoma", 12, FontStyle.Bold)

            Case stilos.MinimaBold
                _miText.Font = New Font("Tahoma", 6, FontStyle.Bold)

            Case stilos.MinimaBoldLineaEncima
                _miText.Font = New Font("Tahoma", 6, FontStyle.Bold)
                lineaEncima = True
                grosorlinea = 0.25

            Case stilos.MinimaBoldLineaDebajo
                _miText.Font = New Font("Tahoma", 6, FontStyle.Bold)
                lineaDebajo = True
                grosorlinea = 0.25

            Case stilos.NormalBold
                _miText.Font = New Font("Tahoma", 10, FontStyle.Bold)

            Case stilos.NormalBoldLineaEncima
                _miText.Font = New Font("Tahoma", 10, FontStyle.Bold)
                lineaEncima = True
                grosorlinea = 1

            Case stilos.NormalBoldLineaDebajo
                _miText.Font = New Font("Tahoma", 10, FontStyle.Bold)
                lineaDebajo = True
                grosorlinea = 1

            Case stilos.NormalBoldCursiva
                _miText.Font = New Font("Tahoma", 10, FontStyle.Bold Or FontStyle.Italic)

            Case stilos.ReducidaBold
                _miText.Font = New Font("Tahoma", 8, FontStyle.Bold)

            Case stilos.ReducidaBoldLineaDebajo
                _miText.Font = New Font("Tahoma", 8, FontStyle.Bold)
                lineaDebajo = True
                grosorlinea = 1

            Case stilos.ReducidaBoldLineaEncima
                _miText.Font = New Font("Tahoma", 8, FontStyle.Bold)
                lineaEncima = True
                grosorlinea = 1

            Case stilos.ReducidaBoldLineaFinaDebajo
                _miText.Font = New Font("Tahoma", 8, FontStyle.Bold)
                lineaDebajo = True
                grosorlinea = 0.25

            Case stilos.ReducidaBoldLineaFinaEncima
                _miText.Font = New Font("Tahoma", 8, FontStyle.Bold)
                lineaEncima = True
                grosorlinea = 0.25

            Case stilos.GrandeBoldLineaDebajo
                _miText.Font = New Font("Tahoma", 12, FontStyle.Bold)
                lineaDebajo = True
                grosorlinea = 1

            Case stilos.GrandeBoldLineaEncima
                _miText.Font = New Font("Tahoma", 12, FontStyle.Bold)
                lineaEncima = True
                grosorlinea = 1

            Case stilos.GrandeBoldLineaFinaDebajo
                _miText.Font = New Font("Tahoma", 12, FontStyle.Bold)
                lineaDebajo = True
                grosorlinea = 0.25

            Case stilos.GrandeBoldLineaFinaEncima
                _miText.Font = New Font("Tahoma", 12, FontStyle.Bold)
                lineaEncima = True
                grosorlinea = 0.25

            Case stilos.ReducidaBoldCuadro
                _miText.Font = New Font("Tahoma", 8, FontStyle.Bold)
                _miText.Sides = BorderSide.All
                _miText.BorderWidth = grosorlinea
                _miText.BackColor = Color.WhiteSmoke
                MargenAlto = 4

            Case stilos.Titulo
                _miText.Font = New Font("Tahoma", 14, FontStyle.Bold)

            Case stilos.Custom
                _miText.Font = _Fuente

        End Select

        If alto_en_mm = 0 Then
            _miText.Rect = New RectangleF(x, y, x_ancho, _miText.Font.Height + MargenAlto)
        Else
            _miText.Rect = New RectangleF(x, y, x_ancho, alto_en_mm)
        End If





        If lineaDebajo Then
            _miText.Sides = BorderSide.Bottom
            _miText.BorderWidth = grosorlinea
        End If
        If lineaEncima Then
            _miText.Sides = BorderSide.Top
            _miText.BorderWidth = grosorlinea
        End If


        'Application.DoEvents()


        Return _miText

    End Function




End Class

Friend Class CBase


    Public x As Single = 0
    Public y As Single = 0

    Public Sub New()

    End Sub


End Class


Friend Class CTitulo
    Inherits CBase

    Public Texto As String = ""
    Public lg_x As Integer = 0
    Public lg_y As Integer = 0
    Public estilo As milinea.stilos
    Public alineacion As String = ""
    Public fuente As Font


    Public Sub New(ByVal texto As String, ByVal x As Single, ByVal y As Single, ByVal lg_x As Integer, ByVal lg_y As Integer, ByVal estilo As milinea.stilos, ByVal alineacion As String, Optional ByVal fuente As Font = Nothing)
        MyBase.New()

        Me.Texto = texto
        Me.x = x
        Me.y = y
        Me.lg_x = lg_x
        Me.lg_y = lg_y
        Me.estilo = estilo
        Me.alineacion = alineacion
        Me.fuente = fuente

    End Sub


End Class

Friend Class CTipoLinea
    Inherits CBase

    Public Grosor As Decimal = 0
    Public color As Color = color.Black

    Public Sub New(ByVal Grosor As Decimal, ByVal color As Color)
        MyBase.New()
        Me.Grosor = Grosor
        Me.color = color

    End Sub

End Class

Friend Class CLineaH
    Inherits CBase
   
    Public lg As Integer = 0
    Public linea As CTipoLinea

    Public Sub New(ByVal x As Single, ByVal y As Single, ByVal lg As Integer, ByVal linea As CTipoLinea)
        MyBase.New()

        Me.x = x
        Me.y = y
        Me.lg = lg
        Me.linea = linea

    End Sub

End Class

Friend Class CLineaV
    Inherits CBase

    Public lg As Integer = 0
    Public linea As CTipoLinea

    Public Sub New(ByVal x As Single, ByVal y As Single, ByVal lg As Integer, ByVal linea As CTipoLinea)
        MyBase.New()

        Me.x = x
        Me.y = y
        Me.lg = lg
        Me.linea = linea

    End Sub

End Class


Friend Class CCuadro
    Inherits CBase

    Public lg_x As Integer = 0
    Public lg_y As Integer = 0
    Public linea As CTipoLinea

    Public Sub New(ByVal x As Single, ByVal y As Single, ByVal lg_x As Integer, ByVal lg_y As Integer, ByVal linea As CTipoLinea)
        MyBase.New()

        Me.x = x
        Me.y = y
        Me.lg_x = lg_x
        Me.lg_y = lg_y
        Me.linea = linea

    End Sub

End Class

Friend Class CLogo
    Inherits CBase

    Public lg_x As Integer = 0
    Public lg_y As Integer = 0
    Public archivo As String = ""

    Public Sub New(ByVal x As Single, ByVal y As Single, ByVal lg_x As Integer, ByVal lg_y As Integer, ByVal archivo As String)

        Me.x = x
        Me.y = y
        Me.lg_x = lg_x
        Me.lg_y = lg_y
        Me.archivo = archivo

    End Sub

End Class


Friend Class CSaltoPagina
    Inherits CBase


End Class




Public Class miFactura

    Public MaxY As Single = 0

    Private linkCabecera As New Link
    Private linkPie As New Link
    Private linkDetalle As New PrintableComponentLink

    Private _lineasCab As New List(Of CBase)
    Private _lineasPie As New List(Of CBase)

    Private _miLinea As New milinea


    Public Sub New()

        AddHandler linkCabecera.CreateDetailArea, AddressOf linkCabecera_CreateDetailArea
        AddHandler linkCabecera.CreateDetailFooterArea, AddressOf linkCabecera_CreateInnerPageFooter
        'AddHandler linkPie.CreateDetailArea, AddressOf linkPie_CreateDetailArea


        linkCabecera.Margins.Left = 1
        linkCabecera.Margins.Right = 30
        linkCabecera.Margins.Top = 50
        linkCabecera.Margins.Bottom = 50

        linkDetalle.Margins.Left = 1
        linkDetalle.Margins.Right = 30
        linkDetalle.Margins.Top = 50
        linkDetalle.Margins.Bottom = 50

        linkPie.Margins.Left = 1
        linkPie.Margins.Right = 30
        linkPie.Margins.Top = 50
        linkPie.Margins.Bottom = 50

    End Sub

    Public Sub Dispose()


        'If Not IsNothing(_lineasCab) Then

        '    For Each tb As TextBrick In _lineasCab
        '        tb.Dispose()
        '        tb = Nothing
        '    Next

        'End If

        'If Not IsNothing(_lineasPie) Then

        '    For Each tb As TextBrick In _lineasPie
        '        tb.Dispose()
        '        tb = Nothing
        '    Next

        'End If



        linkCabecera.ClearDocument()
        linkCabecera.Dispose()
        linkCabecera = Nothing
        Try
            linkPie.ClearDocument()

        Catch ex As Exception

        End Try
        linkPie.Dispose()
        linkPie = Nothing

        linkDetalle.ClearDocument()
        linkDetalle.Dispose()
        linkDetalle = Nothing

        _lineasCab.Clear()
        _lineasCab = Nothing

        _lineasPie.Clear()
        _lineasPie = Nothing


        _miLinea = Nothing


        GC.Collect()

    End Sub


    Public Sub AñadeDetalles(ByVal detalle As IPrintable)
        linkDetalle.Component = detalle
    End Sub


    Public Sub Titulo(ByVal texto As String, ByVal x As Single, ByVal y As Single, ByVal lg_x As Integer, ByVal lg_y As Integer, ByVal estilo As milinea.stilos, Optional ByVal alineacion As String = "<", Optional ByVal fuente As Font = Nothing)

        Dim tx As New CTitulo(texto, x, y, lg_x, lg_y, estilo, alineacion, fuente)
        _lineasCab.Add(tx)

    End Sub

    Public Sub Titulo_Pie(ByVal texto As String, ByVal x As Single, ByVal y As Single, ByVal lg_x As Integer, ByVal lg_y As Integer, ByVal estilo As milinea.stilos, ByVal alineacion As String, Optional ByVal fuente As Font = Nothing)

        Dim tx As New CTitulo(texto, x, y, lg_x, lg_y, estilo, alineacion, fuente)
        _lineasPie.Add(tx)

    End Sub

    Public Sub LineaH(ByVal x As Single, ByVal y As Single, ByVal lg As Integer, ByVal grosor As Decimal, ByVal color As Color)

        Dim l As New CLineaH(x, y, lg, New CTipoLinea(grosor, color))
        _lineasCab.Add(l)

    End Sub

    Public Sub LineaH_Pie(ByVal x As Single, ByVal y As Single, ByVal lg As Integer, ByVal grosor As Decimal, ByVal color As Color)

        Dim l As New CLineaH(x, y, lg, New CTipoLinea(grosor, color))
        _lineasPie.Add(l)

    End Sub

    Public Sub LineaV(ByVal x As Single, ByVal y As Single, ByVal lg As Integer, ByVal grosor As Decimal, ByVal color As Color)

        Dim l As New CLineaV(x, y, lg, New CTipoLinea(grosor, color))
        _lineasCab.Add(l)

    End Sub

    Public Sub LineaV_Pie(ByVal x As Integer, ByVal y As Integer, ByVal lg As Integer, ByVal grosor As Decimal, ByVal color As Color)

        Dim l As New CLineaV(x, y, lg, New CTipoLinea(grosor, color))
        _lineasPie.Add(l)

    End Sub

    Public Sub Cuadro(ByVal x As Single, ByVal y As Single, ByVal lg_x As Integer, ByVal lg_y As Integer, ByVal grosor As Decimal, ByVal color As Color)

        Dim cuadro As New CCuadro(x, y, lg_x, lg_y, New CTipoLinea(grosor, color))
        _lineasCab.Add(cuadro)

    End Sub

    Public Sub Cuadro_Pie(ByVal x As Single, ByVal y As Single, ByVal lg_x As Integer, ByVal lg_y As Integer, ByVal grosor As Decimal, ByVal color As Color)

        Dim cuadro As New CCuadro(x, y, lg_x, lg_y, New CTipoLinea(grosor, color))
        _lineasPie.Add(cuadro)

    End Sub

    Public Sub Logo(ByVal x As Single, ByVal y As Single, ByVal lg_x As Integer, ByVal lg_y As Integer, ByVal archivo As String)

        Dim lo As New CLogo(x, y, lg_x, lg_y, archivo)
        _lineasCab.Add(lo)

    End Sub

    Public Sub Logo_Pie(ByVal x As Single, ByVal y As Single, ByVal lg_x As Integer, ByVal lg_y As Integer, ByVal archivo As String)

        Dim lo As New CLogo(x, y, lg_x, lg_y, archivo)
        _lineasPie.Add(lo)

    End Sub

    Public Sub SaltoPagina()

        Dim sp As New CSaltoPagina()
        _lineasCab.Add(sp)

    End Sub


    Public Sub SaltoPagina(ByVal y As Single)

        Dim sp As New CSaltoPagina()
        sp.y = y
        _lineasCab.Add(sp)

    End Sub


    Public Sub SaltoPagina_Pie()

        Dim sp As New CSaltoPagina()
        _lineasPie.Add(sp)

    End Sub


    Private Sub linkCabecera_CreateDetailArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)

        e.Graph.PageUnit = GraphicsUnit.Millimeter

        For Each obj As CBase In _lineasCab


            If TypeOf obj Is CTitulo Then
                DibujaTitulo(obj, e)
            ElseIf TypeOf obj Is CLineaH Then
                DibujaLineaH(obj, e)
            ElseIf TypeOf obj Is CLineaV Then
                DibujaLineaV(obj, e)
            ElseIf TypeOf obj Is CCuadro Then
                DibujaCuadro(obj, e)
            ElseIf TypeOf obj Is CLogo Then
                DibujaLogo(obj, e)
            ElseIf TypeOf obj Is CSaltoPagina Then
                DibujaSaltoPagina(obj, e)
            End If

        Next

    End Sub


    Private Sub linkCabecera_CreateInnerPageFooter(ByVal sender As Object, ByVal e As CreateAreaEventArgs)

        e.Graph.PageUnit = GraphicsUnit.Millimeter

        For Each obj As CBase In _lineasPie


            If TypeOf obj Is CTitulo Then
                DibujaTitulo(obj, e)
            ElseIf TypeOf obj Is CLineaH Then
                DibujaLineaH(obj, e)
            ElseIf TypeOf obj Is CLineaV Then
                DibujaLineaV(obj, e)
            ElseIf TypeOf obj Is CCuadro Then
                DibujaCuadro(obj, e)
            ElseIf TypeOf obj Is CLogo Then
                DibujaLogo(obj, e)
                'ElseIf TypeOf obj Is CSaltoPagina Then
                '    DibujaSaltoPagina(obj, e)
            End If

        Next

    End Sub


    Private Sub linkPie_CreateDetailArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)

        e.Graph.PageUnit = GraphicsUnit.Millimeter

        For Each obj As CBase In _lineasPie


            If TypeOf obj Is CTitulo Then
                DibujaTitulo(obj, e)
            ElseIf TypeOf obj Is CLineaH Then
                DibujaLineaH(obj, e)
            ElseIf TypeOf obj Is CLineaV Then
                DibujaLineaV(obj, e)
            ElseIf TypeOf obj Is CCuadro Then
                DibujaCuadro(obj, e)
            ElseIf TypeOf obj Is CLogo Then
                DibujaLogo(obj, e)
            End If

        Next


    End Sub



    Private Sub DibujaTitulo(ByVal titulo As CTitulo, ByVal e As CreateAreaEventArgs)


        Dim alineacion As milinea.Alineacion
        Select Case titulo.alineacion

            Case ">"
                alineacion = milinea.Alineacion.Derecha
            Case "="
                alineacion = milinea.Alineacion.Centro
            Case Else
                alineacion = milinea.Alineacion.Izquierda
        End Select


        Dim Br As TextBrick = _miLinea.mistilo(titulo.Texto, titulo.x, titulo.y, titulo.lg_x, titulo.estilo, alineacion, titulo.fuente, titulo.lg_y)
        e.Graph.DrawBrick(Br)


        Br.Dispose()
        Br = Nothing
        GC.Collect()
        If titulo.y + titulo.lg_y > MaxY Then
            MaxY = titulo.y + titulo.lg_y
        End If

    End Sub


    Private Sub DibujaLineaH(ByVal linea As CLineaH, ByVal e As CreateAreaEventArgs)

        Dim Br As New LineBrick()

        Br.LineDirection = DevExpress.XtraReports.UI.LineDirection.Horizontal
        Br.Rect = New RectangleF(linea.x, linea.y, linea.lg, linea.linea.Grosor)
        Br.LineStyle = Drawing2D.DashStyle.Solid
        Br.BackColor = Color.Transparent
        Br.BorderWidth = 0

        Br.LineWidth = linea.linea.Grosor
        Br.ForeColor = linea.linea.color

        e.Graph.DrawBrick(Br)


        Br.Dispose()
        Br = Nothing
        GC.Collect()

        If linea.y + linea.linea.Grosor > MaxY Then
            MaxY = linea.y + linea.linea.Grosor
        End If


    End Sub


    Private Sub DibujaLineaV(ByVal linea As CLineaV, ByVal e As CreateAreaEventArgs)

        Dim Br As New LineBrick()

        Br.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Br.Rect = New RectangleF(linea.x, linea.y, linea.linea.Grosor, linea.lg)
        Br.LineStyle = Drawing2D.DashStyle.Solid
        Br.BackColor = Color.Transparent
        Br.BorderWidth = 0

        Br.LineWidth = linea.linea.Grosor
        Br.ForeColor = linea.linea.color

        e.Graph.DrawBrick(Br)


        Br.Dispose()
        Br = Nothing
        GC.Collect()

        If linea.y + linea.lg > MaxY Then
            MaxY = linea.y + linea.lg
        End If

    End Sub


    Private Sub DibujaCuadro(ByVal cuadro As CCuadro, ByVal e As CreateAreaEventArgs)

        Dim Br As New VisualBrick

        Br.Rect = New RectangleF(cuadro.x, cuadro.y, cuadro.lg_x, cuadro.lg_y)
        Br.BackColor = Color.Transparent
        Br.BorderColor = cuadro.linea.color
        Br.BorderWidth = cuadro.linea.Grosor

        e.Graph.DrawBrick(Br)


        Br.Dispose()
        Br = Nothing
        GC.Collect()

        If cuadro.y + cuadro.lg_y > MaxY Then
            MaxY = cuadro.y + cuadro.lg_y
        End If

    End Sub


    Private Sub DibujaLogo(ByVal logo As CLogo, ByVal e As CreateAreaEventArgs)

        Dim bError As Boolean = False
        Dim Imagen As Image = Nothing

        Try

            Imagen = Image.FromFile(logo.archivo)

        Catch ex As Exception
            bError = True
        End Try


        If bError Then
            Exit Sub
        End If


        Dim Br As New ImageBrick

        Br.Rect = New RectangleF(logo.x, logo.y, logo.lg_x, logo.lg_y)
        Br.BackColor = Color.Transparent
        Br.BorderWidth = 0
        Br.Image = Imagen
        Br.SizeMode = ImageSizeMode.StretchImage


        e.Graph.DrawBrick(Br)

        Br.Dispose()
        Br = Nothing
        GC.Collect()

        If logo.y + logo.lg_y > MaxY Then
            MaxY = logo.y + logo.lg_y
        End If


    End Sub


    Private Sub DibujaSaltoPagina(ByVal salto As CSaltoPagina, ByVal e As CreateAreaEventArgs)

        'linkCabecera.PrintingSystem.InsertPageBreak(salto.y)

        If salto.y > 0 Then
            linkCabecera.PrintingSystem.InsertPageBreak(salto.y)
        Else
            linkCabecera.PrintingSystem.InsertPageBreak(MaxY)
        End If


    End Sub



    Public ReadOnly Property detalles As List(Of LinkBase)
        Get
            Dim _detalles As New List(Of LinkBase)
            If _lineasCab.Count > 0 Then
                _detalles.Add(linkCabecera)
            End If
            If Not linkDetalle Is Nothing Then
                _detalles.Add(linkDetalle)
            End If
            If _lineasPie.Count > 0 Then
                _detalles.Add(linkPie)
            End If
            Return _detalles

        End Get
    End Property


End Class

