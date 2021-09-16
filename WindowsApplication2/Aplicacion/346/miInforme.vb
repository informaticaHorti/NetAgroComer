Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraPrintingLinks
Public Class miInforme

    Dim WithEvents _Informe As CompositeLink
    Dim rpt As New PrintingSystem

    Private lineaCabecera As Single = 0
    Private _lineasCab As New List(Of TextBrick)
    Private _lineasPie As New List(Of TextBrick)
    Private lineaPie As Single = 0
    Public _NombreFichero As String
    Private _logo As miLogo


    Public ReadOnly Property Contenedor As CompositeLink
        Get
            Return _Informe
        End Get
    End Property


    Public Sub New(ByVal apaisado As Boolean, NombreFichero As String)

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
        If NombreFichero = "" Then
            _NombreFichero = "InformeCTB"
        Else
            _NombreFichero = NombreFichero
        End If
        If _NombreFichero <> "" Then
            Dim Carpeta As String = "C:\informesCTB\"
            If Not IO.Directory.Exists(Carpeta) Then
                IO.Directory.CreateDirectory(Carpeta)
            End If
            Dim fichero As String = Carpeta + NombreFichero + "_" + Idusuario.ToString + ".CSV"
            FileOpen(200, fichero, OpenMode.Output)
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

    Public Sub Cabecera(ByVal txlinea As String, ByVal txAncho As String, ByVal _stilo As milinea.stilos)


        _lineasCab.AddRange(New milinea().Crealinea(txlinea, txAncho, _stilo, lineaCabecera))
        lineaCabecera += _lineasCab(_lineasCab.Count - 1).Font.Height
        Application.DoEvents()

    End Sub


    Public Sub Pie(ByVal txlinea As String, ByVal txAncho As String, ByVal _stilo As milinea.stilos)

        _lineasPie.AddRange(New milinea().Crealinea(txlinea, txAncho, _stilo, lineaPie))
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
            Application.DoEvents()
        Next txLin

        If Not IsNothing(_logo) Then
            If Not IsNothing(_logo.logo) Then
                e.Graph.DrawImage(_logo.logo, New RectangleF(_logo.x1, _logo.y1, _logo.x2, _logo.y2), DevExpress.XtraPrinting.BorderSide.None, Color.Transparent)
                Application.DoEvents()
            End If
        End If


    End Sub

    Private Sub composLink_CreateDetailFooterArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs) Handles _Informe.CreateDetailFooterArea
        For Each txLin As TextBrick In _lineasPie
            e.Graph.DrawBrick(txLin)
            Application.DoEvents()
        Next txLin

    End Sub

    Public Sub preliminar(ByVal miLook As DevExpress.LookAndFeel.UserLookAndFeel)

        Application.DoEvents()
        _Informe.ShowRibbonPreviewDialog(miLook)
        Application.DoEvents()

    End Sub


    Public Sub Finalizar()
        If _NombreFichero <> "" Then
            FileClose(200)
        End If
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

        _lineasCab.AddRange(New milinea().Crealinea(txlinea, txAncho, _stilo, lineaCabecera))
        lineaCabecera += _lineasCab(_lineasCab.Count - 1).Font.Height
        Application.DoEvents()

    End Sub


    Public Sub Pie(ByVal txlinea As String, ByVal txAncho As String, ByVal _stilo As milinea.stilos)

        _lineasPie.AddRange(New milinea().Crealinea(txlinea, txAncho, _stilo, lineaPie))
        lineaPie += _lineasPie(_lineasPie.Count - 1).Font.Height
        Application.DoEvents()

    End Sub


    Private Sub linkCabecera_CreateDetailArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)

        For Each txLin As TextBrick In _lineasCab
            If txLin.Text = vbFormFeed Then
                linkCabecera.PrintingSystem.InsertPageBreak(txLin.Rect.Y + txLin.Rect.Height + 1)
            Else
                e.Graph.DrawBrick(txLin)
                Application.DoEvents()
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
                Application.DoEvents()
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
        NormalBold
        ReducidaBold
        ReducidaBoldLineaDebajo
        ReducidaBoldLineaEncima
        ReducidaBoldLineaFinaDebajo
        ReducidaBoldLineaFinaEncima
        ReducidaBoldCuadro
        MinimaBold
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

    Public Function Crealinea(ByVal txlinea As String, ByVal txAncho As String, ByVal _stilo As stilos, ByVal x_linea As Single, Optional ByVal fuente As Font = Nothing)

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

        txlinea = txlinea.Replace("|", ";")
        PrintLine(200, txlinea)
        Return tLineas


    End Function

    Public ReadOnly Property _lineas() As List(Of TextBrick)
        Get
            Return tLineas
        End Get
    End Property


    Private Function mistilo(ByVal miTexto As String, ByVal x As Single, ByVal y As Single, ByVal x_ancho As Single, ByVal _Stilo As stilos, ByVal _alin As Alineacion, ByVal _Fuente As Font) As TextBrick


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

            Case stilos.NormalBold
                _miText.Font = New Font("Tahoma", 10, FontStyle.Bold)

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

        _miText.Rect = New RectangleF(x, y, x_ancho, _miText.Font.Height + MargenAlto)

        If lineaDebajo Then
            _miText.Sides = BorderSide.Bottom
            _miText.BorderWidth = grosorlinea
        End If
        If lineaEncima Then
            _miText.Sides = BorderSide.Top
            _miText.BorderWidth = grosorlinea
        End If


        Application.DoEvents()


        Return _miText

    End Function




End Class

