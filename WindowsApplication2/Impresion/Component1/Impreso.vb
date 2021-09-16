Imports C1.Win.C1Preview
Imports C1.C1Preview

Public Class Impreso


    Private Class bww
        Inherits System.ComponentModel.BackgroundWorker

        Public Impreso As Impreso

        Public Sub New(ByRef Impreso As Impreso)
            MyBase.New()

            Me.Impreso = Impreso

        End Sub

    End Class


    Public ForzarSaltoPagina As Boolean = False

    Public f As New frmPreliminar(Me)
    Dim bw As New bww(Me)



    Private Structure CLogo

        Public x As Integer
        Public y As Integer
        Public w As Integer
        Public h As Integer
        Public imagen As String

    End Structure


    Private Structure CImagen

        Public x As Integer
        Public y As Integer
        Public w As Integer
        Public h As Integer
        Public imagen As Image

    End Structure


    Private Structure CTitulo

        Public x As Integer
        Public y As Integer
        Public w As Integer
        Public h As Integer
        Public texto As String
        Public fuente As Font
        Public color As Color
        Public linea_debajo As Boolean
        Public linea_encima As Boolean
        Public alineacion As AlignHorzEnum
        Public autosize As Rectangle

    End Structure


    Private Structure CCuadro

        Public x As Integer
        Public y As Integer
        Public w As Integer
        Public h As Integer
        Public color As Color
        Public ancho_linea As Decimal

    End Structure


    Private Structure CLineaH

        Public x As Integer
        Public y As Integer
        Public l As Integer
        Public ancho_linea As Decimal
        Public color As Color

    End Structure


    Private Structure CLineaV

        Public x As Integer
        Public y As Integer
        Public l As Integer
        Public ancho_linea As Decimal
        Public color As Color

    End Structure


    Private Structure CSaltoPagina
    End Structure



    Public Class SeccionDetalle

        Protected _Impreso As Impreso
        Protected _lineas As New List(Of Object)
        Public ReadOnly Property Lineas As List(Of Object)
            Get
                Return _lineas
            End Get
        End Property


        Public Sub New(Impreso As Impreso)
            _Impreso = Impreso
        End Sub


        Public Overridable Sub Logo(ByVal imagen As String, ByVal x As Integer, ByVal y As Integer, Optional w As Integer = 0,
                        Optional h As Integer = 0)

            Dim st As CLogo = _Impreso.ObtenerLogo(imagen, x, y, w, h)
            _Impreso.ImprimeObjeto(st)

        End Sub

        Public Overridable Sub Imagen(ByVal imagen As Image, ByVal x As Integer, ByVal y As Integer, Optional w As Integer = 0,
                        Optional h As Integer = 0)

            Dim st As CImagen = _Impreso.ObtenerImagen(imagen, x, y, w, h)
            _Impreso.ImprimeObjeto(st)

        End Sub

        Public Overridable Sub Titulo(ByVal texto As String, ByVal x As Integer, ByVal y As Integer, ByVal w As Integer, ByVal h As Integer,
                          ByVal estilo As Estilos, Optional alineacion As String = "<",
                          Optional color As Color = Nothing, Optional fuente As Font = Nothing,
                          Optional LineaEncima As Boolean = False, Optional LineaDebajo As Boolean = False,
                          Optional AutoSize As Rectangle = Nothing)

            If color = Nothing Then
                color = System.Drawing.Color.Black
            End If

            Dim st As CTitulo = _Impreso.ObtenerTitulo(x, y, w, h, texto, estilo, alineacion, color, fuente, LineaEncima, LineaDebajo, AutoSize)
            _Impreso.ImprimeObjeto(st)

        End Sub

        Public Overridable Sub Cuadro(ByVal x As Integer, ByVal y As Integer, ByVal w As Integer, ByVal h As Integer,
                      ByVal ancho_linea As Decimal, ByVal color As Color)

            Dim st As CCuadro = _Impreso.ObtenerCuadro(x, y, w, h, ancho_linea, color)
            _Impreso.ImprimeObjeto(st)

        End Sub

        Public Overridable Sub LineaH(ByVal x As Integer, ByVal y As Integer, ByVal l As Integer, ByVal ancho_linea As Decimal,
                          Optional color As Color = Nothing)

            Dim st As CLineaH = _Impreso.ObtenerLineaH(x, y, l, ancho_linea, color)
            _Impreso.ImprimeObjeto(st)

        End Sub

        Public Overridable Sub LineaV(ByVal x As Integer, ByVal y As Integer, ByVal l As Integer, ByVal ancho_linea As Decimal,
                          Optional color As Color = Nothing)

            Dim st As CLineaV = _Impreso.ObtenerLineaV(x, y, l, ancho_linea, color)
            _Impreso.ImprimeObjeto(st)

        End Sub

        Public Overridable Sub SaltoPagina()

            Dim SaltoPagina As New CSaltoPagina
            _Impreso.ImprimeSaltoPagina(SaltoPagina)

        End Sub


    End Class


    Public Class SeccionRepetitiva
        Inherits SeccionDetalle


        Public Sub New(Impreso As Impreso)
            MyBase.New(Impreso)

        End Sub



        Public Overrides Sub Logo(ByVal imagen As String, ByVal x As Integer, ByVal y As Integer, Optional w As Integer = 0,
                        Optional h As Integer = 0)

            Dim st As CLogo = _Impreso.ObtenerLogo(imagen, x, y, w, h)
            _lineas.Add(st)

        End Sub

        Public Overrides Sub Imagen(ByVal imagen As Image, ByVal x As Integer, ByVal y As Integer, Optional w As Integer = 0,
                        Optional h As Integer = 0)

            Dim st As CImagen = _Impreso.ObtenerImagen(imagen, x, y, w, h)
            _lineas.Add(st)

        End Sub

        Public Overrides Sub Titulo(ByVal texto As String, ByVal x As Integer, ByVal y As Integer, ByVal w As Integer, ByVal h As Integer,
                          ByVal estilo As Estilos, Optional alineacion As String = "<",
                          Optional color As Color = Nothing, Optional fuente As Font = Nothing,
                          Optional LineaEncima As Boolean = False, Optional LineaDebajo As Boolean = False,
                          Optional AutoSize As Rectangle = Nothing)

            If color = Nothing Then
                color = System.Drawing.Color.Black
            End If

            Dim st As CTitulo = _Impreso.ObtenerTitulo(x, y, w, h, texto, estilo, alineacion, color, fuente, LineaEncima, LineaDebajo, AutoSize)
            _lineas.Add(st)

        End Sub

        Public Overrides Sub Cuadro(ByVal x As Integer, ByVal y As Integer, ByVal w As Integer, ByVal h As Integer,
                      ByVal ancho_linea As Decimal, ByVal color As Color)

            Dim st As CCuadro = _Impreso.ObtenerCuadro(x, y, w, h, ancho_linea, color)
            _lineas.Add(st)

        End Sub

        Public Overrides Sub LineaH(ByVal x As Integer, ByVal y As Integer, ByVal l As Integer, ByVal ancho_linea As Decimal,
                          Optional color As Color = Nothing)

            Dim st As CLineaH = _Impreso.ObtenerLineaH(x, y, l, ancho_linea, color)
            _lineas.Add(st)

        End Sub

        Public Overrides Sub LineaV(ByVal x As Integer, ByVal y As Integer, ByVal l As Integer, ByVal ancho_linea As Decimal,
                          Optional color As Color = Nothing)

            Dim st As CLineaV = _Impreso.ObtenerLineaV(x, y, l, ancho_linea, color)
            _lineas.Add(st)

        End Sub

        Public Overrides Sub SaltoPagina()

            Dim SaltoPagina As New CSaltoPagina
            _lineas.Add(SaltoPagina)

        End Sub


    End Class



    'Public Documento As C1PrintDocument


    Friend Cabecera As New SeccionRepetitiva(Me)
    Friend Detalle As New SeccionDetalle(Me)
    Friend Pie As New SeccionRepetitiva(Me)


    Public DatosMail As DatosMail = Nothing




    'Public CodigoEscaneo As CodigoEscaneo = Nothing
    Private _NumeroPagina As Integer = 0


    Private _AnchoLinea As String = "2pix"

    Public Sub New()


        'Me.Documento = New C1PrintDocument

        'AddHandler Me.Documento.PageAdded, AddressOf documento_PageAdded

    End Sub


    Public Sub EstableceImpreso(TipoImpresion As TipoImpresion)

        If TipoImpresion = NetAgro.TipoImpresion.Preliminar Then
            AddHandler bw.RunWorkerCompleted, AddressOf Me.TerminaTarea
            bw.RunWorkerAsync()
        End If


        f.documento.StartDoc()

    End Sub


    Private Sub TerminaTarea(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)

        Dim bw As bww = CType(sender, bww)
        Dim f As frmPreliminar = bw.Impreso.f
        f.Show()

    End Sub


    Public Sub Dispose()

        Try
            If Not IsNothing(Cabecera.Lineas) Then
                For Each obj As Object In Cabecera.Lineas
                    obj = Nothing
                Next
                Cabecera.Lineas.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            If Not IsNothing(Detalle.Lineas) Then
                For Each obj As Object In Detalle.Lineas
                    obj = Nothing
                Next
                Detalle.Lineas.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            If Not IsNothing(Pie.Lineas) Then
                For Each obj As Object In Pie.Lineas
                    obj = Nothing
                Next
                Pie.Lineas.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Try
            If Not IsNothing(f.documento) Then

                If f.documento.IsGenerating Then
                    f.documento.EndDoc()
                End If

                f.documento.Clear()
                f.documento.Dispose()
                f.documento = Nothing

            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
            f.documento.Dispose()
            f.documento = Nothing
        End Try


        Cabecera = Nothing
        Detalle = Nothing
        Pie = Nothing


        'GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce
        GC.Collect()

    End Sub


    'Informe
    Protected Friend Function ObtenerLogo(ByVal imagen As String, ByVal x As Integer, ByVal y As Integer, Optional ByVal w As Integer = 0,
                        Optional ByVal h As Integer = 0) As Object

        Dim st As New CLogo
        st.x = x
        st.y = y
        st.w = w
        st.h = h
        st.imagen = imagen


        Return st

    End Function


    Protected Friend Function ObtenerImagen(ByVal imagen As Image, ByVal x As Integer, ByVal y As Integer, Optional ByVal w As Integer = 0,
                        Optional ByVal h As Integer = 0) As Object

        Dim st As New CImagen
        st.x = x
        st.y = y
        st.w = w
        st.h = h
        st.imagen = imagen


        Return st

    End Function


    Protected Friend Function ObtenerTitulo(ByVal x As Integer, ByVal y As Integer, ByVal w As Integer, ByVal h As Integer,
                      ByVal texto As String, ByVal estilo As Estilos,
                      Optional ByVal alineacion As String = "<", Optional ByVal color As Color = Nothing,
                      Optional ByVal fuente As Font = Nothing, Optional ByVal LineaEncima As Boolean = False,
                      Optional ByVal LineaDebajo As Boolean = False,
                      Optional ByVal AutoSize As Rectangle = Nothing) As Object


        Dim st As New CTitulo
        st.x = x
        st.y = y
        st.w = w
        st.h = h

        st.texto = texto
        If color = Nothing Then
            color = Drawing.Color.Black
        End If
        st.color = color


        If IsNothing(fuente) Then
            fuente = _Fuente_Normal
        End If


        'Fuente y tamaño
        Select Case estilo

            Case Estilos.MuyGrandeBold
                st.fuente = _Fuente_MuyGrandeBold
            Case Estilos.Cabecera
                st.fuente = _Fuente_Cabecera
            Case Estilos.Grande
                st.fuente = _Fuente_Grande
            Case Estilos.GrandeBold
                st.fuente = _Fuente_GrandeBold
            Case Estilos.Normal
                st.fuente = _Fuente_Normal
            Case Estilos.NormalBold, Estilos.NormalBoldLineaEncima, Estilos.NormalBoldLineaDebajo
                st.fuente = _Fuente_NormalBold
            Case Estilos.Reducida, Estilos.ReducidaLineaEncima, Estilos.ReducidaLineaDebajo
                st.fuente = _Fuente_Reducida
            Case Estilos.ReducidaBold, Estilos.ReducidaBoldLineaEncima, Estilos.ReducidaBoldLineaDebajo
                st.fuente = _Fuente_ReducidaBold
            Case Estilos.Minima
                st.fuente = _Fuente_Minima
            Case Estilos.MinimaCursiva
                st.fuente = _Fuente_Minima_Cursiva
            Case Estilos.MinimaBold, Estilos.MinimaBoldLineaEncima, Estilos.MinimaBoldLineaDebajo
                st.fuente = _Fuente_MinimaBold
            Case Estilos.Custom
                st.fuente = fuente

        End Select


        'Líneas
        Select Case estilo
            Case Estilos.NormalBoldLineaEncima, Estilos.ReducidaBoldLineaEncima, Estilos.MinimaBoldLineaEncima, Estilos.ReducidaLineaEncima
                st.linea_encima = True

            Case Estilos.NormalBoldLineaDebajo, Estilos.ReducidaBoldLineaDebajo, Estilos.MinimaBoldLineaDebajo, Estilos.ReducidaLineaDebajo
                st.linea_debajo = True

        End Select


        'Alineacion
        Select Case alineacion
            Case "<"
                st.alineacion = AlignHorzEnum.Left

            Case "="
                st.alineacion = AlignHorzEnum.Center

            Case ">"
                st.alineacion = AlignHorzEnum.Right

        End Select


        st.autosize = AutoSize


        Return st


    End Function


    Protected Friend Function ObtenerCuadro(ByVal x As Integer, ByVal y As Integer, ByVal w As Integer, ByVal h As Integer,
                      ByVal ancho_linea As Decimal, Optional ByVal color As Color = Nothing) As Object


        Dim st As New CCuadro
        st.x = x
        st.y = y
        st.w = w
        st.h = h
        st.ancho_linea = ancho_linea
        If color = Nothing Then
            color = Drawing.Color.Black
        End If
        st.color = color


        Return st

    End Function


    Protected Friend Function ObtenerLineaH(ByVal x As Integer, ByVal y As Integer, ByVal l As Integer,
                                            ByVal ancho_linea As Decimal, Optional ByVal color As Color = Nothing) As Object

        Dim st As New CLineaH
        st.x = x
        st.y = y
        st.l = l
        st.ancho_linea = ancho_linea
        If color = Nothing Then
            color = Drawing.Color.Black
        End If
        st.color = color


        Return st

    End Function


    Protected Friend Function ObtenerLineaV(ByVal x As Integer, ByVal y As Integer, ByVal l As Integer,
                                            ByVal ancho_linea As Decimal, Optional ByVal color As Color = Nothing) As Object

        Dim st As New CLineaV
        st.x = x
        st.y = y
        st.l = l
        st.ancho_linea = ancho_linea
        If color = Nothing Then
            color = Drawing.Color.Black
        End If
        st.color = color


        Return st

    End Function


    Private Sub ImprimeObjeto(ByVal obj As Object)


        With f.documento

            If TypeOf obj Is CLogo Then
                ImprimeLogo(obj)

            ElseIf TypeOf obj Is CImagen Then
                ImprimeImagen(obj)

            ElseIf TypeOf obj Is CTitulo Then
                ImprimeTitulo(obj)

            ElseIf TypeOf obj Is CCuadro Then
                ImprimeCuadro(obj)

            ElseIf TypeOf obj Is CLineaH Then
                ImprimeLineaH(obj)

            ElseIf TypeOf obj Is CLineaV Then
                ImprimeLineaV(obj)

            ElseIf TypeOf obj Is CSaltoPagina Then
                ImprimeSaltoPagina(obj)

            End If

        End With


    End Sub


    Private Sub ImprimeLogo(ByVal st As CLogo)

        Dim x As String = st.x.ToString & "mm"
        Dim y As String = st.y.ToString & "mm"
        Dim w As String = st.w.ToString & "mm"
        Dim h As String = st.h.ToString & "mm"

        Try

            Dim imagen As Image = Image.FromFile(st.imagen)
            f.documento.RenderDirectImage(x, y, imagen, w, h, ImageAlign.Default)

        Catch ex As Exception

        End Try


    End Sub


    Private Sub ImprimeImagen(ByVal st As CImagen)

        Dim x As String = st.x.ToString & "mm"
        Dim y As String = st.y.ToString & "mm"
        Dim w As String = st.w.ToString & "mm"
        Dim h As String = st.h.ToString & "mm"

        Try
            If Not IsNothing(st.imagen) Then

                Dim s As Style = f.documento.Style
                f.documento.RenderDirectImage(x, y, st.imagen, w, h, s)

            End If

        Catch ex As Exception

        End Try


    End Sub


    Private Sub ImprimeTitulo(ByVal st As CTitulo)

        Dim x As String = st.x.ToString & "mm"
        Dim y As String = st.y.ToString & "mm"
        Dim w As String = st.w.ToString & "mm"
        Dim h As String = st.h.ToString & "mm"


        'If Not IsNothing(st.autosize) Then
        If Not st.autosize = Nothing Then

            'Calcular fuente
            'C1PrintDocument.MeasurementGraphics.PageUnit = GraphicsUnit.Millimeter
            'Dim rs As SizeF = C1PrintDocument.MeasurementGraphics.MeasureString(st.texto, st.fuente)

            Dim g As Graphics = f.CreateGraphics()
            g.PageUnit = GraphicsUnit.Millimeter
            Dim rs As SizeF = g.MeasureString(st.texto, st.fuente)

            Dim pW As Decimal = 0 : If rs.Width <> 0 Then pW = st.autosize.Width / rs.Width
            Dim pH As Decimal = 0 : If rs.Height <> 0 Then pH = st.autosize.Height / rs.Height

            Dim proporcion As Single = pW : If pH < pW Then proporcion = pH

            If proporcion > 0 Then
                Dim fuente As Font = New Font(st.fuente.Name, CSng(st.fuente.Size * proporcion), st.fuente.Style)
                st.fuente = fuente
            End If

        End If


        Dim altura_linea As Integer = st.fuente.Height * 0.2646

        Try

            'Línea encima
            If st.linea_encima Then
                f.documento.RenderDirectLine(x, y, (st.x + st.w).ToString & "mm", y, Color.Black, _AnchoLinea)
            End If

            Dim s As Style = f.documento.Style
            s.Font = st.fuente
            s.TextColor = st.color
            s.TextAlignHorz = st.alineacion
            s.WordWrap = False
            f.documento.RenderDirectText(x, y, st.texto, w, h, s)

            'Documento.RenderDirectText(x, y, st.texto, w, st.fuente, st.color, st.alineacion)

            'Línea abajo
            If st.linea_debajo Then
                f.documento.RenderDirectLine(x, (Val(y) + altura_linea).ToString & "mm", (st.x + st.w).ToString & "mm", (Val(y) + altura_linea).ToString & "mm", Color.Black, _AnchoLinea)
            End If

        Catch ex As Exception

        End Try


    End Sub


    Private Sub ImprimeCuadro(ByVal st As CCuadro)

        Dim x As String = st.x.ToString & "mm"
        Dim y As String = st.y.ToString & "mm"
        Dim w As String = st.w.ToString & "mm"
        Dim h As String = st.h.ToString & "mm"
        Dim ancho_linea As String = st.ancho_linea.ToString & "pix"

        'Dim lineDef As New LineDef(ancho_linea, st.color)
        f.documento.RenderDirectRectangle(x, y, w, h, st.color, ancho_linea)

    End Sub


    Private Sub ImprimeLineaH(ByVal st As CLineaH)

        Dim x As String = st.x.ToString & "mm"
        Dim y As String = st.y.ToString & "mm"
        Dim l As String = (st.x + st.l).ToString & "mm"
        Dim ancho_linea As String = st.ancho_linea.ToString & "pix"

        'Dim linedef As New LineDef(ancho_linea, st.color)
        f.documento.RenderDirectLine(x, y, l, y, st.color, ancho_linea)

    End Sub


    Private Sub ImprimeLineaV(ByVal st As CLineaV)

        Dim x As String = st.x.ToString & "mm"
        Dim y As String = st.y.ToString & "mm"
        Dim l As String = (st.y + st.l).ToString & "mm"
        Dim ancho_linea As String = st.ancho_linea.ToString & "pix"

        'Dim linedef As New LineDef(ancho_linea, st.color)
        f.documento.RenderDirectLine(x, y, x, l, st.color, ancho_linea)

    End Sub


    Private Sub ImprimeSaltoPagina(ByVal st As CSaltoPagina)

        'Dim y As String = st.salto.ToString & "mm"
        f.documento.AllowNonReflowableDocs = True
        f.documento.NewPage()

        If ForzarSaltoPagina Then
            f.documento.Body.Children.Add(New C1.C1Preview.RenderEmpty(C1.C1Preview.BreakEnum.Page))
        End If


    End Sub



    Private Sub documento_PageAdded(ByVal sender As C1.C1Preview.C1PrintDocument, ByVal e As C1.C1Preview.PageEventArgs)

        NuevaPagina()
        
    End Sub


    Public Sub NuevaPagina()

        _NumeroPagina = _NumeroPagina + 1
        'ImprimeCodigoEscaneo()

        For Each linea As Object In Cabecera.Lineas
            ImprimeObjeto(linea)
        Next

    End Sub


    Public Sub Imprimir(ByVal TipoImpresion As TipoImpresion, Optional ByVal Impresora As String = "", Optional ByVal RutaPDF As String = "", Optional ByVal ArchivoPDF As String = "", Optional ByVal numCop As Integer = 0)


        If numCop = 0 Then numCop = 1



        If Not IsNothing(f.documento) Then


            f.documento.EndDoc()


            Select Case TipoImpresion

                Case TipoImpresion.Preliminar
                    Copiar(numCop)

                Case TipoImpresion.ImpresoraPorDefecto
                    For indice As Integer = 1 To numCop
                        f.documento.Print()
                    Next
                    Me.Dispose()

                Case TipoImpresion.ImpresoraSeleccionada
                    If Impresora = "" Then
                        For indice As Integer = 1 To numCop
                            f.documento.Print()
                        Next
                    Else
                        Try
                            Dim ps As New System.Drawing.Printing.PrinterSettings
                            ps.PrinterName = Impresora
                            For indice As Integer = 1 To numCop
                                f.documento.Print(ps)
                            Next
                        Catch ex As Exception
                            MsgBox("Error al imprimir por la impresora " & Impresora)
                        End Try

                    End If
                    Me.Dispose()

                Case TipoImpresion.ExportacionPDF
                    If RutaPDF.Trim = "" Or ArchivoPDF.Trim = "" Then
                        MsgBox("Error, debe especificar una ruta y nombre de archivo PDF de destino")
                    Else
                        'TODO: Se puede comprimir? - la verdad es que ya está bastante comprimido...
                        Copiar(numCop)
                        f.documento.Export(RutaPDF & ArchivoPDF)
                    End If
                    Me.Dispose()

                Case Else
                    For indice As Integer = 1 To numCop
                        f.documento.Print()
                    Next
                    Me.Dispose()

            End Select

        End If


    End Sub


    Public Sub Generar(Optional numCop As Integer = 0)

        If numCop = 0 Then

            'f.documento.StartDoc()

            'No es necesario, ya lo pone en page_added
            'For Each linea As Object In Cabecera.Lineas
            '    ImprimeObjeto(linea)
            'Next

            For Each linea As Object In Detalle.Lineas
                Try
                    ImprimeObjeto(linea)
                Catch ex As Exception
                    Dim a As String = ""
                End Try
            Next

            For Each linea As Object In Pie.Lineas
                ImprimeObjeto(linea)
            Next

            f.documento.EndDoc()


        Else
            For i As Integer = 1 To numCop
                f.documento.StartDoc()

                'No es necesario, ya lo pone en page_added
                'For Each linea As Object In Cabecera.Lineas
                '    ImprimeObjeto(linea)
                'Next

                For Each linea As Object In Detalle.Lineas
                    ImprimeObjeto(linea)
                Next

                For Each linea As Object In Pie.Lineas
                    ImprimeObjeto(linea)
                Next

                f.documento.EndDoc()


            Next
        End If


    End Sub


    Public Sub EnviarPorOutlook(ByVal Fax As Boolean)

        If Not IsNothing(DatosMail) And CompruebaDestinatarios(Fax) Then
            'TODO: qué hacemos si faltan datos?

            Dim txtError As String = EnviarMailOutlook(DatosMail, Fax)
            If txtError.Trim <> "" Then
                MsgBox("No se ha podido enviar el documento: " & txtError)
            Else
                MsgBox("Mensaje enviado")
            End If

        Else
            MsgBox("No hay datos para el envío")
            'Dim PedirDatos As New FrmIntroducirDatosEnvio(Me, Fax)
            'PedirDatos.Show()
        End If
    End Sub

    Private Function CompruebaDestinatarios(ByVal Fax As Boolean) As Boolean
        Dim Comprobacion As Boolean = False

        If Fax And Len(DatosMail.DestinatarioFax) > 0 Then
            Comprobacion = True
        End If

        If Not Fax Then
            For Each d As String In DatosMail.DestinatarioMail
                If Len(d) > 0 Then
                    Comprobacion = True
                End If
            Next
        End If

        Return Comprobacion
    End Function


    'Private Sub ImprimeCodigoEscaneo()

    '    If Not IsNothing(CodigoEscaneo) Then

    '        Dim CodBar As String = "*" & CodigoEscaneo.Codigo & "." & _NumeroPagina.ToString & "*"
    '        Dim linea As CTitulo = ObtenerTitulo(CodigoEscaneo.x, CodigoEscaneo.y, CodigoEscaneo.w, CodigoEscaneo.h, CodBar, Estilos.Custom, CodigoEscaneo.alineacion, , CodigoEscaneo.Code39)
    '        ImprimeObjeto(linea)

    '    End If

    'End Sub


    Public Shared Function Merge(lst As List(Of Object),
                                 Optional Papel As Drawing.Printing.PaperKind = Drawing.Printing.PaperKind.A4,
                                 Optional Apaisado As Boolean = False,
                                 Optional MargenSup As String = "",
                                 Optional MargenIzq As String = "",
                                 Optional MargenInf As String = "",
                                 Optional MargenDer As String = ""
                                 ) As Impreso


        Dim Impreso As New Impreso


        'Documento combinado
        Dim doc As New C1.C1Preview.C1PrintDocument

        doc.PageLayout.PageSettings.PaperKind = Papel
        doc.PageLayout.PageSettings.Landscape = Apaisado
        If MargenSup.Trim <> "" Then doc.PageLayout.PageSettings.TopMargin = MargenSup
        If MargenIzq.Trim <> "" Then doc.PageLayout.PageSettings.LeftMargin = MargenIzq
        If MargenInf.Trim <> "" Then doc.PageLayout.PageSettings.BottomMargin = MargenInf
        If MargenDer.Trim <> "" Then doc.PageLayout.PageSettings.RightMargin = MargenDer


        If lst.Count > 0 Then

            For indice As Integer = 0 To lst.Count - 1

                'Inserta salto de página
                If indice > 0 Then
                    doc.Body.Children.Add(New C1.C1Preview.RenderEmpty(C1.C1Preview.BreakEnum.Page))
                End If




                If TypeOf lst(indice) Is Impreso Then

                    Dim Impreso2 As Impreso = lst(indice)
                    Impreso2.Generar()

                    'Añadir el segundo documento
                    While Impreso2.f.documento.Body.Children.Count > 0
                        Dim ro As C1.C1Preview.RenderObject = Impreso2.f.documento.Body.Children(0)
                        Impreso2.f.documento.Body.Children.RemoveAt(0)
                        doc.Body.Children.Add(ro)
                    End While

                    Application.DoEvents()

                    Impreso2.Dispose()
                    Impreso2 = Nothing

                ElseIf TypeOf lst(indice) Is Listado Then

                    Dim Impreso2 As Listado = lst(indice)
                    Impreso2.Generar()

                    'Dim f As New frmPreliminar(Impreso2)
                    'f.C1PrintPreviewControl1.Document = Impreso2.Documento
                    'f.ShowDialog()


                    'Añadir el segundo documento
                    While Impreso2.f.documento.Body.Children.Count > 0
                        Dim ro As C1.C1Preview.RenderObject = Impreso2.f.documento.Body.Children(0)
                        Impreso2.f.documento.Body.Children.RemoveAt(0)
                        doc.Body.Children.Add(ro)
                    End While

                    Application.DoEvents()

                    Impreso2.Dispose()
                    Impreso2 = Nothing

                End If


                Application.DoEvents()


            Next

        End If




        Impreso.f.documento = doc


        Return Impreso


    End Function


    'Public Shared Function MergeStart(lst As List(Of Object), TipoImpresion As TipoImpresion,
    '                             Optional Papel As Drawing.Printing.PaperKind = Drawing.Printing.PaperKind.A4,
    '                             Optional Apaisado As Boolean = False,
    '                             Optional MargenSup As String = "",
    '                             Optional MargenIzq As String = "",
    '                             Optional MargenInf As String = "",
    '                             Optional MargenDer As String = ""
    '                             ) As Impreso


    '    Dim Impreso As New Impreso


    '    'Documento combinado
    '    Dim doc As New C1.C1Preview.C1PrintDocument

    '    doc.PageLayout.PageSettings.PaperKind = Papel
    '    doc.PageLayout.PageSettings.Landscape = Apaisado
    '    If MargenSup.Trim <> "" Then doc.PageLayout.PageSettings.TopMargin = MargenSup
    '    If MargenIzq.Trim <> "" Then doc.PageLayout.PageSettings.LeftMargin = MargenIzq
    '    If MargenInf.Trim <> "" Then doc.PageLayout.PageSettings.BottomMargin = MargenInf
    '    If MargenDer.Trim <> "" Then doc.PageLayout.PageSettings.RightMargin = MargenDer



    '    If lst.Count > 0 Then

    '        For indice As Integer = 0 To lst.Count - 1

    '            'Inserta salto de página
    '            If indice > 0 Then
    '                doc.Body.Children.Add(New C1.C1Preview.RenderEmpty(C1.C1Preview.BreakEnum.Page))
    '            End If




    '            If TypeOf lst(indice) Is Impreso Then

    '                Dim Impreso2 As Impreso = lst(indice)
    '                Impreso2.Generar()

    '                'Añadir el segundo documento
    '                While Impreso2.f.documento.Body.Children.Count > 0
    '                    Dim ro As C1.C1Preview.RenderObject = Impreso2.f.documento.Body.Children(0)
    '                    Impreso2.f.documento.Body.Children.RemoveAt(0)
    '                    doc.Body.Children.Add(ro)
    '                End While

    '                Application.DoEvents()

    '                Impreso2.Dispose()
    '                Impreso2 = Nothing

    '            ElseIf TypeOf lst(indice) Is Listado Then

    '                Dim Impreso2 As Listado = lst(indice)
    '                Impreso2.Generar()

    '                'Dim f As New frmPreliminar(Impreso2)
    '                'f.C1PrintPreviewControl1.Document = Impreso2.Documento
    '                'f.ShowDialog()


    '                'Añadir el segundo documento
    '                While Impreso2.f.documento.Body.Children.Count > 0
    '                    Dim ro As C1.C1Preview.RenderObject = Impreso2.f.documento.Body.Children(0)
    '                    Impreso2.f.documento.Body.Children.RemoveAt(0)
    '                    doc.Body.Children.Add(ro)
    '                End While

    '                Application.DoEvents()

    '                Impreso2.Dispose()
    '                Impreso2 = Nothing

    '            End If


    '            Application.DoEvents()


    '        Next

    '    End If


    '    Impreso.f.documento = doc
    '    Impreso.f.documento.StartDoc()


    '    Return Impreso


    'End Function


    Public Shared Function Merge(lst As List(Of Listado),
                                 Optional Papel As Drawing.Printing.PaperKind = Drawing.Printing.PaperKind.A4,
                                 Optional Apaisado As Boolean = False,
                                 Optional MargenSup As String = "",
                                 Optional MargenIzq As String = "",
                                 Optional MargenInf As String = "",
                                 Optional MargenDer As String = ""
                                 ) As Impreso


        Dim Impreso As New Impreso



        'Documento combinado
        Dim doc As New C1.C1Preview.C1PrintDocument

        doc.PageLayout.PageSettings.PaperKind = Papel
        doc.PageLayout.PageSettings.Landscape = Apaisado
        If MargenSup.Trim <> "" Then doc.PageLayout.PageSettings.TopMargin = MargenSup
        If MargenIzq.Trim <> "" Then doc.PageLayout.PageSettings.LeftMargin = MargenIzq
        If MargenInf.Trim <> "" Then doc.PageLayout.PageSettings.BottomMargin = MargenInf
        If MargenDer.Trim <> "" Then doc.PageLayout.PageSettings.RightMargin = MargenDer


        If lst.Count > 0 Then

            For indice As Integer = 0 To lst.Count - 1

                'Inserta salto de página
                If indice > 0 Then
                    doc.Body.Children.Add(New C1.C1Preview.RenderEmpty(C1.C1Preview.BreakEnum.Page))
                End If


                Dim Impreso2 As Listado = lst(indice)
                Impreso2.Generar()

                Application.DoEvents()


                'Añadir el segundo documento
                While Impreso2.f.documento.Body.Children.Count > 0
                    Dim ro As C1.C1Preview.RenderObject = Impreso2.f.documento.Body.Children(0)
                    Impreso2.f.documento.Body.Children.RemoveAt(0)
                    doc.Body.Children.Add(ro)
                End While

                Application.DoEvents()

                Impreso2.Dispose()
                Impreso2 = Nothing

            Next

        End If




        Impreso.f.documento = doc

        Return Impreso


    End Function




    Public Sub Copiar(NumCopiasTotales As Integer)

        Dim numCopias As Integer = NumCopiasTotales - 1


        If numCopias > 0 Then

            Dim lst As New List(Of C1.C1Preview.RenderObject)

            'Obtiene datos de origen para copiar
            For indice As Integer = 0 To f.documento.Body.Children.Count - 1

                Dim linea As C1.C1Preview.RenderObject = f.documento.Body.Children(indice)
                lst.Add(linea)

                Application.DoEvents()

            Next


            For indice As Integer = 0 To numCopias - 1

                f.documento.Body.Children.Add(New C1.C1Preview.RenderEmpty(C1.C1Preview.BreakEnum.Page))

                For Each l As C1.C1Preview.RenderObject In lst
                    Dim linea As C1.C1Preview.RenderObject = l.Clone()
                    f.documento.Body.Children.Add(linea)
                Next

                Application.DoEvents()

            Next



            f.documento.Generate()


        End If



    End Sub


    'Public Sub EstableceCodigoEscaneo(ByVal Codigo As String, ByVal x As Integer, ByVal y As Integer, ByVal w As Integer, ByVal h As Integer,
    '                      ByVal alineacion As String, ByVal tamaño_fuente As Integer)

    '    CodigoEscaneo = New CodigoEscaneo(Codigo, x, y, w, h, alineacion, tamaño_fuente)

    'End Sub

End Class


