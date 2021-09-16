Imports C1.C1Preview


Public Class Listado


    Private Class bww
        Inherits System.ComponentModel.BackgroundWorker

        Public Listado As Listado

        Public Sub New(ByRef Listado As Listado)
            MyBase.New()

            Me.Listado = Listado

        End Sub

    End Class


    Public ForzarSaltoPagina As Boolean = False
    Private fuente_pagina As New Font("Arial", 10, FontStyle.Regular)
    Public f As New frmPreliminar(Me)
    Dim bw As New bww(Me)



    Public Class SeccionDetalle

        Protected _Listado As Listado
        Protected _lineas As New List(Of Object)
        Public ReadOnly Property Lineas As List(Of Object)
            Get
                Return _lineas
            End Get
        End Property


        Public Sub New(Listado As Listado)
            _Listado = Listado
        End Sub


        Public Overridable Sub Linea(ByVal texto As String, ByVal ancho As String, ByVal estilo As Estilos,
                         Optional fuente As Font = Nothing)

            Dim st As CLinea = _Listado.ObtenerLinea(texto, ancho, estilo, fuente)
            _Listado.ImprimeObjeto(st)

        End Sub


        Public Sub SaltoPagina()
            'Dim SaltoPagina As New CSaltoPagina
            '_lineas.Add(SaltoPagina)
            _Listado.ImprimeSaltoPagina()
        End Sub


    End Class


    Public Class SeccionRepetitiva
        Inherits SeccionDetalle


        Public Sub New(Listado As Listado)
            MyBase.New(Listado)

        End Sub


        Public Overrides Sub Linea(ByVal texto As String, ByVal ancho As String, ByVal estilo As Estilos,
                         Optional fuente As Font = Nothing)

            Dim st As CLinea = _Listado.ObtenerLinea(texto, ancho, estilo, fuente)
            _Listado.ImprimeObjeto(st)
            _lineas.Add(st)

        End Sub


    End Class


    Private Structure CLinea
        Public Texto As String
        Public Ancho As String
        Public Fuente As Font
        Public Linea_encima As Boolean
        Public Linea_debajo As Boolean
    End Structure

    Private Structure CSaltoPagina
    End Structure



    'Public Documento As C1PrintDocument

    Private _altura As Integer = 0
    Private _margen_izquierdo = 0
    Private _PiePagina_Vertical As Integer = 282
    Private _PiePagina_Horizontal As Integer = 190
    Private _AnchoLinea As String = "3pix"


    Private _lineas As New List(Of Object)
    Public ReadOnly Property Lineas As List(Of Object)
        Get
            Return _lineas
        End Get
    End Property



    Friend Cabecera As New SeccionRepetitiva(Me)
    Friend Detalle As New SeccionDetalle(Me)
    Friend Pie As New SeccionRepetitiva(Me)


    Public DatosMail As DatosMail = Nothing



    Public Sub New()

        'Me.Documento = New C1PrintDocument


        f.documento.PageLayout.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        f.documento.PageLayout.PageSettings.Landscape = False
        f.documento.PageLayout.PageFooter = New RenderText("Página [PageNo] de [PageCount]", fuente_pagina, AlignHorzEnum.Center)


    End Sub


    Public Sub EstableceListado(TipoImpresion As TipoImpresion)


        Try
            _altura = Val(f.documento.PageLayout.PageSettings.TopMargin)
            _margen_izquierdo = Val(f.documento.PageLayout.PageSettings.LeftMargin)

        Catch ex As Exception
        End Try



        If TipoImpresion = NetAgro.TipoImpresion.Preliminar Then
            AddHandler bw.RunWorkerCompleted, AddressOf Me.TerminaTarea
            bw.RunWorkerAsync()
        End If


        f.documento.StartDoc()



    End Sub


    Private Sub TerminaTarea(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)

        Dim bw As bww = CType(sender, bww)
        Dim f As frmPreliminar = bw.Listado.f
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

                'Dim enddoc As frmPreliminar.FinalizaDocumento_Delegate = AddressOf f.FinalizaDocumento
                'enddoc.Invoke()

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


    Protected Friend Function ObtenerLinea(ByVal texto As String, ByVal ancho As String, ByVal estilo As Estilos,
                                           Optional ByVal fuente As Font = Nothing) As Object

        Dim st As New CLinea
        st.Texto = texto
        st.Ancho = ancho


        'Fuente y tamaño
        Select Case estilo

            Case Estilos.MuyGrandeBold
                st.Fuente = _Fuente_MuyGrandeBold
            Case Estilos.Cabecera
                st.Fuente = _Fuente_Cabecera
            Case Estilos.Grande
                st.Fuente = _Fuente_Grande
            Case Estilos.GrandeBold
                st.Fuente = _Fuente_GrandeBold
            Case Estilos.Normal
                st.Fuente = _Fuente_Normal
            Case Estilos.NormalBold, Estilos.NormalBoldLineaEncima, Estilos.NormalBoldLineaDebajo
                st.Fuente = _Fuente_NormalBold
            Case Estilos.Reducida, Estilos.ReducidaLineaEncima, Estilos.ReducidaLineaDebajo
                st.Fuente = _Fuente_Reducida
            Case Estilos.ReducidaBold, Estilos.ReducidaBoldLineaEncima, Estilos.ReducidaBoldLineaDebajo
                st.Fuente = _Fuente_ReducidaBold
            Case Estilos.Minima
                st.Fuente = _Fuente_Minima
            Case Estilos.MinimaCursiva
                st.Fuente = _Fuente_Minima_Cursiva
            Case Estilos.MinimaBold, Estilos.MinimaBoldLineaEncima, Estilos.MinimaBoldLineaDebajo
                st.Fuente = _Fuente_MinimaBold
            Case Estilos.Custom
                If Not IsNothing(fuente) Then
                    st.Fuente = fuente
                Else
                    st.Fuente = _Fuente_Normal
                End If

        End Select


        'Líneas
        Select Case estilo
            Case Estilos.NormalBoldLineaEncima, Estilos.ReducidaBoldLineaEncima, Estilos.MinimaBoldLineaEncima, Estilos.ReducidaLineaEncima
                st.Linea_encima = True

            Case Estilos.NormalBoldLineaDebajo, Estilos.ReducidaBoldLineaDebajo, Estilos.MinimaBoldLineaDebajo, Estilos.ReducidaLineaDebajo
                st.Linea_debajo = True

        End Select


        Return st


    End Function


    Public Sub Imprimir(ByVal TipoImpresion As TipoImpresion, Optional ByVal Impresora As String = "", Optional ByVal RutaPDF As String = "", Optional ByVal ArchivoPDF As String = "")


        If Not IsNothing(f.documento) Then

            f.documento.EndDoc()


            Select Case TipoImpresion

                Case TipoImpresion.Preliminar

                    'f.C1PrintPreviewControl1.Document = Documento
                    'bw.RunWorkerAsync()
                    'MuestraDatos()


                    'f.C1PrintPreviewControl1.Document = Documento
                    'f.ShowDialog()
                    'f.MuestraMensaje("Hola")
                    'f.C1PrintPreviewControl1.Refresh()

                Case TipoImpresion.ImpresoraPorDefecto
                    f.documento.Print()

                Case TipoImpresion.ImpresoraSeleccionada
                    If Impresora = "" Then
                        f.documento.Print()
                    Else
                        Try
                            Dim ps As New System.Drawing.Printing.PrinterSettings
                            ps.PrinterName = Impresora
                            f.documento.Print(ps)
                        Catch ex As Exception
                            MsgBox("Error al imprimir por la impresora " & Impresora)
                        End Try

                    End If

                Case TipoImpresion.ExportacionPDF
                    If RutaPDF.Trim = "" Or ArchivoPDF.Trim = "" Then
                        MsgBox("Error, debe especificar una ruta y nombre de archivo PDF de destino")
                    Else
                        'TODO: Se puede comprimir? - la verdad es que ya está bastante comprimido...
                        f.documento.Export(RutaPDF & ArchivoPDF)
                    End If


                Case Else
                    f.documento.Print()

            End Select


        End If



    End Sub


    Public Sub Generar(Optional numCop As Integer = 0)


        f.documento.PageLayout.PageFooter = New RenderText("Página [PageNo] de [PageCount]", AlignHorzEnum.Center)


        Try
            _altura = Val(f.documento.PageLayout.PageSettings.TopMargin)
            _margen_izquierdo = Val(f.documento.PageLayout.PageSettings.LeftMargin)

        Catch ex As Exception
        End Try


        'f.documento.StartDoc()

        'For Each linea As Object In Cabecera.Lineas
        '    ImprimeObjeto(linea)
        'Next

        'For Each linea As Object In Detalle.Lineas
        '    ImprimeObjeto(linea)
        'Next

        'For Each linea As Object In Pie.Lineas
        '    ImprimeObjeto(linea)
        'Next

        f.documento.EndDoc()


    End Sub


    Private Sub ImprimeObjeto(ByVal obj As Object)


        With f.documento

            If TypeOf obj Is CLinea Then
                ImprimeLinea(obj)

            ElseIf TypeOf obj Is CSaltoPagina Then
                ImprimeSaltoPagina()

            End If

        End With


    End Sub


    Private Sub ImprimeLinea(ByVal st As CLinea)


        Dim PiePagina As Integer = _PiePagina_Vertical
        If f.documento.PageLayout.PageSettings.Landscape = True Then
            PiePagina = _PiePagina_Horizontal
        End If

        'Dim BottomMargin As Integer = Val(Documento.PageLayout.PageSettings.BottomMargin)
        'If BottomMargin > 0 Then
        '    PiePagina = PiePagina - BottomMargin
        'End If


        Dim altura_linea As Integer = (st.Fuente.Height * 0.2646)
        If st.Linea_debajo Then altura_linea = altura_linea + 0.5


        If _altura + altura_linea > PiePagina Then
            ImprimeSaltoPagina()
        End If



        Dim misLineas() As String = st.Texto.Split("|")
        Dim misAnchos() As String = st.Ancho.Split("|")


        Dim x As Integer = 0


        For lin As Integer = 0 To misAnchos.Length - 1

            Dim pos As Integer = 1

            Dim alineacion As AlignHorzEnum

            If Len(misAnchos(lin)) > 0 Then

                Select Case misAnchos(lin).Substring(0, 1)
                    Case ">"
                        alineacion = AlignHorzEnum.Right
                    Case "="
                        alineacion = AlignHorzEnum.Center
                    Case "<"
                        alineacion = AlignHorzEnum.Left
                    Case Else
                        alineacion = AlignHorzEnum.Left
                        pos = 0

                End Select

                Dim texto As String = ""
                If lin < misLineas.Length Then texto = misLineas(lin)
                Dim ancho As String = misAnchos(lin).Substring(pos)
                Dim alto As String = (st.Fuente.Height * 0.2646) + 1


                Try

                    Dim sX As String = (_margen_izquierdo + x).ToString & "mm"
                    Dim sAncho As String = VaInt(ancho).ToString & "mm"
                    Dim sAlto As String = VaInt(alto).ToString & "mm"
                    Dim sY As String = _altura.ToString & "mm"


                    'Línea encima
                    If st.Linea_encima Then
                        f.documento.RenderDirectLine(sX, sY, (_margen_izquierdo + x + ancho).ToString & "mm", sY, Color.Black, _AnchoLinea)
                    End If

                    'Texto
                    'Documento.RenderDirectText(sX, sY, texto, sAncho, st.Fuente, Color.Black, alineacion)
                    Dim s As Style = f.documento.Style
                    s.Font = st.Fuente
                    s.TextColor = Color.Black
                    s.TextAlignHorz = alineacion
                    s.WordWrap = False
                    f.documento.RenderDirectText(sX, sY, texto, sAncho, sAlto, s)

                    'Línea abajo
                    If st.Linea_debajo Then
                        f.documento.RenderDirectLine(sX, (_altura + altura_linea).ToString & "mm", (_margen_izquierdo + x + ancho).ToString & "mm", (_altura + altura_linea).ToString & "mm", Color.Black, _AnchoLinea)
                    End If

                Catch ex As Exception
                End Try

                x += ancho


            End If


        Next

        _altura += altura_linea


    End Sub


    Private Sub ImprimeSaltoPagina()

        f.documento.AllowNonReflowableDocs = True
        f.documento.NewPage()

        If ForzarSaltoPagina Then
            f.documento.Body.Children.Add(New C1.C1Preview.RenderEmpty(C1.C1Preview.BreakEnum.Page))
        End If

        _altura = Val(f.documento.PageLayout.PageSettings.TopMargin)


        For Each linea As Object In Cabecera.Lineas
            ImprimeObjeto(linea)
        Next

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

            For Each a As String In DatosMail.ListaAdjuntos
                My.Computer.FileSystem.DeleteFile(a)
            Next

        Else
            'Dim PedirDatos As New FrmIntroducirDatosEnvio(Me, Fax)
            'PedirDatos.Show()
            MsgBox("No hay datos para el envío")
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


End Class
