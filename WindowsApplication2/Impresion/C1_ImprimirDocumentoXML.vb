Imports System.Drawing
Imports System.Xml

Module C1_ImprimirDocumentoTalonXML


    Public Class Formato

        Public NombreCampo As String = ""
        Public Texto As String = ""
        Public x As Integer = 0
        Public y As Integer = 0
        Public h As Integer = 0
        Public w As Integer = 0
        Public fuente As Font
        Public mascara As String = ""

        Public Sub New(NombreCampo As String, texto As String, x As Integer, y As Integer, h As Integer, w As Integer, fuente As Font, mascara As String)

            Me.NombreCampo = NombreCampo
            Me.Texto = texto
            Me.x = x
            Me.y = y
            Me.h = h
            Me.w = w
            Me.fuente = fuente
            Me.mascara = mascara

        End Sub

    End Class


    Public Class DocumentoTalonXML


        Private ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
        Private _dtOrigen As New DataTable
        Private _dtFormato As New DataTable


        Dim Impreso As New Impreso()

        Dim Informe As New miInforme(False)



        Public ReadOnly Property TablaFormato As DataTable
            Get
                Return _dtFormato
            End Get
        End Property


        Public ReadOnly Property TablaOrigen As DataTable
            Get
                Return _dtOrigen
            End Get
        End Property


        Public Sub New(fichero As String, dtOrigen As DataTable)


            'Impreso.f.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
            'Impreso.f.Documento.PageLayout.PageSettings.SetPaperSizes("6in", "6in")

            Impreso.f.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.Custom
            Impreso.f.Documento.PageLayout.PageSettings.Landscape = False
            Impreso.f.Documento.PageLayout.PageSettings.SetPaperSizes("175mm", "76mm")
            '




            Impreso.f.Documento.PageLayout.PageSettings.TopMargin = "0mm"
            Impreso.f.Documento.PageLayout.PageSettings.LeftMargin = "0mm"
            Impreso.f.Documento.PageLayout.PageSettings.RightMargin = "0mm"
            Impreso.f.Documento.PageLayout.PageSettings.BottomMargin = "0mm"


            _dtOrigen = dtOrigen


            Dim directorio_por_defecto As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CARPETA_DOCUMENTOS_BANCARIOS)
            If directorio_por_defecto.Trim = "" Then
                MsgBox("Error al leer la plantilla de datos")
                Exit Sub
            Else

                Dim ruta As String = Application.StartupPath & "\" & directorio_por_defecto & "\"

                If Not IO.Directory.Exists(ruta) Then
                    MsgBox("Error al leer la plantilla de datos")
                    Exit Sub
                Else

                    _dtFormato.Clear()


                    Dim fichero_estructura As String = ruta & "datastructure.xsd"
                    If Not IO.File.Exists(fichero_estructura) Then
                        MsgBox("Error al leer la plantilla de datos")
                        Exit Sub
                    End If



                    Try

                        'Leer XML y almacenar en el diccionario
                        _dtFormato.ReadXmlSchema(fichero_estructura)
                        _dtFormato.ReadXml(fichero)

                        Application.DoEvents()

                    Catch ex As Exception
                        MsgBox("Error al leer el fichero " & fichero & vbCrLf & vbCrLf & ex.Message)
                    End Try



                End If

            End If


        End Sub


        Public Sub Imprimir(TipoImpresion As TipoImpresion,
                             Optional Impresora As String = "",
                             Optional rutaPDF As String = "",
                             Optional archivoPDF As String = "")


            Impreso.EstableceImpreso(TipoImpresion)


            Try

                Dim Dc As New Dictionary(Of String, Formato)

                If Not IsNothing(_dtFormato) Then

                    For Each row As DataRow In _dtFormato.Rows

                        Dim NombreCampo As String = (row("campo").ToString & "").Trim
                        Dim texto As String = (row("texto").ToString & "").Trim

                        Dim posicion As String = (row("posicion").ToString & "").Trim
                        Dim posX As Integer = 0
                        Dim posY As Integer = 0

                        Dim datos_posicion As String() = Split(posicion, ",")
                        If datos_posicion.Length > 0 Then posX = VaInt(datos_posicion(0))
                        If datos_posicion.Length > 1 Then posY = VaInt(datos_posicion(1))


                        Dim formato As String = (row("formato").ToString & "").Trim
                        Dim datos_formato As String() = Split(formato, ",")

                        Dim nombre_fuente As String = "Courier New"
                        Dim tamaño_fuente As Decimal = 9
                        Dim bNegrita As Boolean = False
                        Dim bCursiva As Boolean = False
                        Dim bSubrayado As Boolean = False

                        If datos_formato.Length > 0 Then nombre_fuente = datos_formato(0)
                        If datos_formato.Length > 1 Then tamaño_fuente = VaInt(datos_formato(1))
                        If datos_formato.Length > 2 Then bNegrita = ((datos_formato(2) & "").Trim = "S")
                        If datos_formato.Length > 3 Then bCursiva = ((datos_formato(3) & "").Trim = "S")
                        If datos_formato.Length > 4 Then bSubrayado = ((datos_formato(4) & "").Trim = "S")

                        Dim estilo_fuente As FontStyle
                        If bNegrita Then estilo_fuente = FontStyle.Bold
                        If bCursiva Then estilo_fuente = estilo_fuente Or FontStyle.Italic
                        If bSubrayado Then estilo_fuente = estilo_fuente Or FontStyle.Underline


                        Dim fuente As New Font(nombre_fuente, tamaño_fuente, estilo_fuente)

                        Dim textSize As Size = TextRenderer.MeasureText(texto, fuente)

                        Dim h As Integer = textSize.Height * 0.2646
                        Dim w As Integer = textSize.Width * 0.2646

                        Dim mascara As String = (row("mascara").ToString & "").Trim


                        If NombreCampo.Trim <> "" Then
                            Dim f As New Formato(NombreCampo, texto, posX, posY, h, w, fuente, mascara)
                            Dc(NombreCampo) = f
                        Else
                            Impreso.Detalle.Titulo(texto, posX, posY, w, h, Estilos.Custom, , , fuente)
                        End If


                        Application.DoEvents()

                    Next
                End If


                Dim LiquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)



                'Imprime Detalle
                Dim cont As Integer = 0
                For Each row As DataRow In _dtOrigen.Rows

                    For Each col As DataColumn In _dtOrigen.Columns
                        If Dc.ContainsKey(col.ColumnName) Then

                            Dim texto As String = (row(col.ColumnName).ToString & "").Trim

                            Dim f As Formato = Dc(col.ColumnName)
                            If f.mascara.Trim <> "" Then texto = VaDec(texto).ToString(f.mascara)



                            Dim textSize As Size = TextRenderer.MeasureText(texto, f.fuente)
                            f.h = textSize.Height * 0.2646
                            f.w = textSize.Width * 0.2646


                            Impreso.Detalle.Titulo(texto, f.x, f.y, f.w, f.h, Estilos.Custom, , , f.fuente)

                        End If

                        Application.DoEvents()

                    Next



                    If cont < _dtOrigen.Rows.Count - 1 Then
                        Impreso.Detalle.SaltoPagina()
                    End If


                    cont = cont + 1

                    'Actualizo número de talón
                    If _dtOrigen.Columns.Contains("IdLiquidacion") Then
                        Dim IdLiquidacion As String = (row("IdLiquidacion").ToString & "").Trim
                        If VaInt(IdLiquidacion) > 0 Then
                            If LiquidacionAgr.LeerId(IdLiquidacion) Then
                                Dim NumTalon As String = (row("NumeroTalon").ToString & "").Trim
                                LiquidacionAgr.LIQ_Nutalon.Valor = NumTalon
                                LiquidacionAgr.Actualizar()
                            End If
                        End If
                    End If

                    Application.DoEvents()

                Next



                'Imprimir
                'Impreso.Imprimir(NetAgro.TipoImpresion.Preliminar)
                Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)


            Catch ex As Exception

            End Try


            

        End Sub




    End Class


End Module
