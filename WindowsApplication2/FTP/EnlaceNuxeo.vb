Imports System.Net
Imports System.IO
Imports System.Xml
Imports System.Text
Imports System.Reflection
Imports SharpSsh


Public Class EnlaceNuxeo
    Inherits EnlaceDocumentos


    Public Sub New(ByVal _oConfig As ConfiguracionEnlace, tabla As String)
        MyBase.new(_oConfig, tabla)
    End Sub


    Private Function RecogeUID(ByVal strRespuesta As String) As String

        Dim DocumentoRespueta As New XmlDocument
        Dim m_nodelist As XmlNodeList
        Dim Retorno As String = ""

        Try
            DocumentoRespueta.LoadXml(strRespuesta)
            m_nodelist = DocumentoRespueta.SelectNodes("uid")
            Retorno = m_nodelist(0).FirstChild.InnerText

        Catch ex As Exception

        End Try


        Return Retorno

    End Function


    Private Function CargaDatosPagina(ByVal Direccion As String, ByVal fichero As String) As String
        Try

            Dim oRequest As HttpWebRequest = CType(WebRequest.Create(Direccion), HttpWebRequest)

            ' Aplicamos el metodo de trabajo y su contenido
            oRequest.Method = "POST"
            oRequest.ContentType = "application/x-www-form-urlencoded"


            'Creamos un stringbuilder para pasar los parametros
            Dim data As New StringBuilder
            data.Append("name=" + fichero)

            'El data lo pasamos a un array de byte para enviarlo
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(data.ToString)

            'Asingnamos el tamaño que tendra
            oRequest.ContentLength = byteArray.Length

            'Creamos el stream y despues realizamos el escrito en el
            Dim oDataStream As Stream = oRequest.GetRequestStream()
            oDataStream.Write(byteArray, 0, byteArray.Length)
            oDataStream.Close()

            'Creamos el objeto de respuesta de la web
            Dim oResponse As WebResponse = oRequest.GetResponse()

            'lo pasamos al objeto stream creado antes
            oDataStream = oResponse.GetResponseStream()
            Dim oLectura As New StreamReader(oDataStream)

            'obtenemos la respuesta en string
            Dim sRespuesta As String = oLectura.ReadToEnd()


            ' Cerramos los objetos
            oLectura.Close()
            oDataStream.Close()
            oResponse.Close()

            oLectura.Dispose()
            oDataStream.Dispose()
            Dim indice As Integer = sRespuesta.IndexOf("</uid>")
            sRespuesta = sRespuesta.Substring(0, indice + 6)

            Return sRespuesta

        Catch ex As Exception
            Return ""
        End Try

    End Function

    Protected Overrides Function SubirArchivo(ByVal pathFichero As String) As String
        Dim mifile As String = DameFichero(pathFichero)
        Dim miuid As String = ""
        Try
            Dim s As String = ".pdf"
            If mifile.ToLower.Contains(".pdf") = False Then
                mifile = mifile & s
            End If

            '''''''''''''''''FTP'''''''''''
            Dim servidor As String = oConfig.ServidorFtp.Valor
            Dim sshCp As SharpSsh.SshTransferProtocolBase
            sshCp = New Scp(servidor, oConfig.usuariofichero.Valor)
            sshCp.Password = oConfig.passwordfichero.Valor

            Try
                sshCp.Connect()
            Catch ex As Exception

            End Try


            Dim archivoLocal As String = ""
            Dim ArchivoRemoto As String = ""
            archivoLocal = pathFichero
            ArchivoRemoto = mifile
            sshCp.Put(archivoLocal, ArchivoRemoto)
            miuid = RecogeUID(CargaDatosPagina(oConfig.pathnuxeo.Valor, mifile))

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally


        End Try

        Return miuid

    End Function


End Class



