Imports System.IO
Imports System.Xml

Public Class Ficheros

#Region "FicherosINI"

    Dim _fichero As String = ""
    Dim _parametros As New Dictionary(Of String, String)

    Public Property fichero As String
        Get
            Return _fichero
        End Get
        Set(ByVal value As String)
            _fichero = value
        End Set
    End Property

    Public Property parametros As Dictionary(Of String, String)
        Get
            Return _parametros
        End Get
        Set(ByVal value As Dictionary(Of String, String))
            _parametros = value
        End Set
    End Property

    Public Sub New()

        _parametros.Clear()
        _fichero = Application.StartupPath & "\configuracion.ini"

    End Sub

    Public Sub New(ByVal _fic As String)

        _parametros.Clear()
        _fichero = _fic

    End Sub

    Public Function LeerParametro(ByVal param As String) As String

        Try
            Dim fs As New FileStream(_fichero, FileMode.Open)
            Dim sr As New StreamReader(fs)
            Dim linea As String = ""
            Dim texto As String = ""

            linea = sr.ReadLine
            While linea <> Nothing
                If Left(linea, param.Length).ToLower = param.ToLower Then
                    texto = linea.Substring(param.Length + 1, linea.Length - param.Length - 1)
                End If
                linea = sr.ReadLine
            End While

            sr.Close()
            fs.Close()

            Return texto.Trim

        Catch ex As Exception

            MsgBox("No ha sido posible leer el fichero ini " & fichero & " parámetro " & param, "Clave 'FicheroINI', Función 'Parámetro'", ex.Message)
            Return ""

        End Try

    End Function

    Public Sub GrabarParametros()

        Dim fs As New FileStream(_fichero, FileMode.Create)
        Dim wr As New StreamWriter(fs)

        For Each item In _parametros
            wr.WriteLine(item.Key.ToString & item.Value.ToString)
        Next

        wr.Close()
        fs.Close()

    End Sub

#End Region

#Region "FicherosCorreo"

    ' --------------------------------------------------------------------------
    ' formato del fichero para el envío automático de emails, 
    '   el separador de valores es "|"
    '   el separador de líneas es crlf
    ' --------------------------------------------------------------------------

    ' --------------------------------------------------------------------------
    ' parámetros que se pueden o SE DEBEN presentar N veces, 1 vez por línea
    ' --------------------------------------------------------------------------
    ' PARA              |email válido                   ' obligatorio
    ' COPIAPARA         |email válido
    ' COPIAOCULTAPARA   |email válido
    ' TEXTO             |texto libre                    ' obligatorio
    ' ADJUNTO           |ruta válida a un fichero   

    ' --------------------------------------------------------------------------
    ' parámetros que SE DEBEN presentar en 1 sola línea
    ' --------------------------------------------------------------------------
    ' ASUNTO|texto                                      ' obligatorio

    ' --------------------------------------------------------------------------
    ' datos opcionales, siempre en 1 sola línea
    ' --------------------------------------------------------------------------
    ' FECHA             |texto libre teoric. con una fecha válida
    ' ID                |texto libre con un identificador del mensaje

    ''' <summary>
    ''' procesa un fichero *.txt (mensaje de correo para enviar)
    ''' </summary>
    ''' <param name="archivo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function LeerFicheroCorreo(ByVal archivo As String) As ClvMail

        Dim mensaje As ClvMail = Nothing

        Dim destinatarios As New List(Of String)
        Dim copiaspara As New List(Of String)
        Dim copiasocultaspara As New List(Of String)

        Dim asunto As String = ""
        Dim texto As New List(Of String)
        Dim adjuntos As New List(Of String)

        Try

            Dim contenido As String = File.ReadAllText(archivo)
            Dim lineas_contenido As String() = contenido.Split(vbCrLf)

            For Each linea As String In lineas_contenido

                Dim datos_linea As String() = linea.Split("|")

                If datos_linea.Length = 2 Then

                    Dim tipo As String = datos_linea(0).Trim.ToUpper
                    Dim valor As String = datos_linea(1).Trim

                    Select Case tipo

                        Case "FECHA"
                        Case "ID"

                        Case "PARA"
                            destinatarios.Add(valor)
                        Case "COPIAPARA"
                            copiaspara.Add(valor)
                        Case "COPIAOCULTAPARA"
                            copiasocultaspara.Add(valor)

                        Case "ASUNTO"
                            asunto = valor
                        Case "TEXTO"
                            texto.Add(valor)
                        Case "ADJUNTO"
                            adjuntos.Add(valor)

                    End Select

                End If

            Next

            mensaje = New ClvMail

            mensaje.Para = destinatarios
            mensaje.CopiaPara = copiaspara
            mensaje.CopiaOcultaPara = copiasocultaspara

            mensaje.Asunto = asunto
            mensaje.Texto = texto
            mensaje.Adjuntos = adjuntos

            mensaje.Log = Me

        Catch ex As Exception

        End Try

        Return mensaje

    End Function

    ''' <summary>
    ''' recupera un mensaje error de envío como mensaje para enviar
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub RecuperaFicheroError(ByVal origen As String, ByVal dirdestino As String)

        Try
            If File.Exists(origen) = True Then
                Dim destino As String = dirdestino & Path.GetFileName(origen)
                If File.Exists(destino) = True Then File.Delete(destino)
                File.Copy(origen, destino)
                File.Delete(origen)
            End If
        Catch ex As Exception
        End Try

    End Sub

    ''' <summary>
    ''' borra un fichero, típicamente un mensaje enviado
    ''' </summary>
    ''' <param name="archivo"></param>
    ''' <remarks></remarks>
    Public Sub BorraFicheroCorreo(ByVal archivo As String)

        Try
            If File.Exists(archivo) = True Then
                File.Delete(archivo)
            End If
        Catch ex As Exception
        End Try

    End Sub

    ''' <summary>
    ''' carga listado ficheros con ext indicada en directorio indicado
    ''' </summary>
    ''' <param name="ruta"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CargaListaFicheros(ByVal ruta As String, Optional ByVal ext As String = "*.txt") As List(Of String)
        Dim lst As New List(Of String)
        Try
            If Directory.Exists(ruta) = True Then
                For Each f As String In Directory.GetFiles(ruta, ext)
                    lst.Add(f)
                Next
            End If
        Catch ex As Exception
        End Try
        Return lst
    End Function

    ''' <summary>
    ''' directorio para mensajes enviados (...\enviados\)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DirEnviados() As String
        Return Application.StartupPath & "\enviados\"
    End Function
    ''' <summary>
    ''' crea el directorio para los mensajes enviados
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CrearDirEnviados()

        Try
            If Directory.Exists(DirEnviados) = False Then
                Directory.CreateDirectory(DirEnviados)
            End If
        Catch ex As Exception
        End Try

    End Sub

    ''' <summary>
    ''' copia el fichero a la carpeta enviados, típicamente para correos enviados
    ''' </summary>
    ''' <param name="origen"></param>
    ''' <remarks></remarks>
    Public Sub CopiaFicheroCorreo(ByVal origen As String)

        Try
            Dim destino As String = DirEnviados() & Path.GetFileName(origen)
            If File.Exists(origen) = True Then
                If File.Exists(destino) = False Then
                    File.Copy(origen, destino)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' directorio para mensajes "errores" (...\errores\)
    ''' típicamente errores de envío que se copia a este directorio antes de renombrarlos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DirErrores() As String
        Return Application.StartupPath & "\errores\"
    End Function
    Public Sub CrearDirErrores()

        Try
            If Directory.Exists(DirErrores) = False Then
                Directory.CreateDirectory(DirErrores)
            End If
        Catch ex As Exception
        End Try

    End Sub

    ''' <summary>
    ''' copia el fichero a la carpeta errores, típicamente para correos fallidos
    ''' </summary>
    ''' <param name="origen"></param>
    ''' <remarks></remarks>
    Public Sub CopiaFicheroError(ByVal origen As String)

        Try
            If File.Exists(origen) = True Then
                Dim destino As String = DirErrores() & Path.GetFileName(origen)
                If File.Exists(destino) = True Then File.Delete(destino)
                File.Copy(origen, destino)
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Log"

    ''' <summary>
    ''' nombre del directorio para logs (...\logfiles\)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DirLog() As String
        Return Application.StartupPath & "\logfiles\"
    End Function

    ''' <summary>
    ''' creación de directorio para logs (...\logfiles\)
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CrearDirLog()
        Try
            If Directory.Exists(DirLog) = False Then
                Directory.CreateDirectory(DirLog)
            End If
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' nombre del fichero log diario, yyyymmdd.txt
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IdLog() As String
        Return DirLog() & Today.ToString("yyyyMMdd") & ".txt"
    End Function

    ''' <summary>
    ''' creación del fichero log, si no existe
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CrearLog()

        Try
            If File.Exists(IdLog) = False Then
                ActualizarLog(Now.ToString & " -------------------------")
            End If
        Catch ex As Exception
        End Try

    End Sub

    ''' <summary>
    ''' actualiza (escribe la línea pasada en) el fichero log
    ''' </summary>
    ''' <param name="linea"></param>
    ''' <remarks></remarks>
    Public Sub ActualizarLog(ByVal linea As String)

        Try
            Dim fs As New FileStream(IdLog, FileMode.Append)
            Dim wr As New StreamWriter(fs)

            wr.WriteLine(linea)

            wr.Close()
            fs.Close()
        Catch ex As Exception
        End Try

    End Sub

#End Region

#Region "Xml"

    ''' <summary>
    ''' nombre del log en xml para los mensajes enviados (yyyymm.xml)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IdLogXML() As String
        Return DirLog() & Today.ToString("yyyyMM") & ".xml"
    End Function

    ''' <summary>
    ''' crea fichero log xml mensajes enviados (en ...\logfiles\)
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CrearLogXML()

        Try
            If File.Exists(IdLogXML) = False Then

                Dim settings As New XmlWriterSettings()
                settings.Indent = True
                settings.IndentChars = "    "

                Using writer As XmlWriter = XmlWriter.Create(IdLogXML, settings)
                    writer.WriteStartElement("Log")
                    writer.WriteStartElement("Mensaje")
                    writer.WriteElementString("Fecha", Today.ToString("yyyyMMdd"))
                    writer.WriteElementString("Para", "Administrador")
                    writer.WriteElementString("Asunto", "Se ha iniciado un nuevo log de envios.")
                    writer.WriteEndElement()
                    writer.WriteEndElement()
                    writer.Flush()
                End Using

            End If
        Catch ex As Exception
        End Try

    End Sub

    ''' <summary>
    ''' lectura del fichero xml log de mensajes enviados
    ''' </summary>
    ''' <param name="_fic"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function LeerXmlEnviados(ByVal _fic As String) As DataTable

        Try
            Dim Xml As XmlDocument
            Dim NodeList As XmlNodeList
            Dim Node As XmlNode

            Xml = New XmlDocument()
            Xml.Load(_fic)
            NodeList = Xml.SelectNodes("//Mensaje")     ' todos los elementos mensaje en el doc

            Dim dt As New DataTable
            dt.Columns.Add(New DataColumn("Fecha", GetType(System.String)))
            dt.Columns.Add(New DataColumn("Para", GetType(System.String)))
            dt.Columns.Add(New DataColumn("Asunto", GetType(System.String)))

            For Each Node In NodeList
                Dim a As Integer = 0
                For i = 0 To Node.ChildNodes.Count - 1
                    Try
                        dt.Rows.Add(Node.ChildNodes(i).InnerText.Trim, Node.ChildNodes(i + 1).InnerText.Trim, Node.ChildNodes(i + 2).InnerText.Trim)
                        i = i + 3
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Next i
            Next

            Return dt
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    ''' <summary>
    ''' añade un nodo xml al fichero log xml de mensajes enviados
    ''' un nodo es una estructura xml completa en formato <padre><hijos></hijos></padre>
    ''' </summary>
    ''' <param name="_doc"></param>
    ''' <param name="_padre"></param>
    ''' <param name="_elementos"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function NuevoNodoXML(ByRef _doc As XmlDocument, ByVal _padre As String, _
                                ByVal _elementos As Dictionary(Of String, String)) As XmlElement
        Dim miEle As XmlElement = _doc.CreateElement(_padre)
        Try
            For Each item In _elementos
                Dim miNodo As XmlElement = _doc.CreateElement(item.Key)
                miNodo.InnerText = item.Value
                miEle.AppendChild(miNodo)
            Next
        Catch ex As Exception
        End Try
        Return miEle
    End Function

    ''' <summary>
    ''' actualiza el fichero log xml de mensajes enviados (añade los 
    ''' nuevos nodos para los nuevos mensajes enviados)
    ''' </summary>
    ''' <param name="_fecha"></param>
    ''' <param name="_para"></param>
    ''' <param name="_asunto"></param>
    ''' <remarks></remarks>
    Public Sub ActualizaXmlEnviados(ByVal _fecha As String, ByVal _para As String, ByVal _asunto As String)

        Try
            If File.Exists(IdLogXML) = True Then

                ' documento xml
                Dim miDoc As New XmlDocument
                miDoc.Load(IdLogXML)

                ' raiz del documento xml
                Dim miRaiz As XmlElement = miDoc.DocumentElement

                ' nodo xml
                Dim dicItems As New Dictionary(Of String, String)
                dicItems.Add("Fecha", _fecha)
                dicItems.Add("Para", _para)
                dicItems.Add("Asunto", _asunto)

                ' elemento xml 
                Dim miEle As XmlElement = NuevoNodoXML(miDoc, "Mensaje", dicItems)

                ' inserta al final de la raiz xml
                miRaiz.InsertAfter(miEle, miRaiz.LastChild)

                ' guarda documento xml
                miDoc.Save(IdLogXML)

            End If
        Catch ex As Exception
        End Try

    End Sub

#End Region

End Class
