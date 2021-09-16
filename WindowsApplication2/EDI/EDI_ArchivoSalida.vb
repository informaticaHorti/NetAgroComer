
Namespace EDI


    Public Class EDI_ArchivoSalida


        Public Lineas As New List(Of String)
        Public IdMensaje As String = ""
        Public Formato As String = ""
        Public Carpeta_formato_ftp As String = ""

        Public Nombre As String = ""


        Public Sub New(Nombre As String)
            Me.Nombre = Nombre
        End Sub


        Public Sub New(ByVal IdMensaje As String, ByVal formato As String, ByVal carpeta_formato_ftp As String)
            Me.IdMensaje = IdMensaje
            Me.Formato = formato
            Me.Carpeta_formato_ftp = carpeta_formato_ftp
        End Sub


        Public Function Guardar(ByVal carpeta As String, ByVal archivo As String, Optional ByVal codificacion As System.Text.Encoding = Nothing) As Boolean

            If IsNothing(codificacion) Then
                codificacion = System.Text.Encoding.ASCII
            End If


            Dim bRes As Boolean = True

            Try

                Dim fs As New IO.FileStream(carpeta & archivo, IO.FileMode.Create)
                Dim wr As New IO.StreamWriter(fs, codificacion)

                For Each linea As String In Lineas
                    wr.WriteLine(linea)
                Next

                wr.Close()
                fs.Close()



            Catch ex As Exception
                MsgBox("Error al guardar a disco el archivo de factura electrónica " & archivo)
                bRes = False
            End Try



            Return bRes

        End Function


    End Class


End Namespace


