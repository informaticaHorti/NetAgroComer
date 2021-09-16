Public Class ConfiguracionEnlace

    Inherits FicheroXml

    Public configuracion As New NodoXml("configuracion")
    Public path As New NodoXml("path", configuracion)
    Public usuariofichero As New NodoXml("usuariofichero", configuracion)
    Public passwordfichero As New NodoXml("passwordfichero", configuracion)

    Public tipodoc As New NodoXml("tipodoc", configuracion)

    Public pathnuxeo As New NodoXml("pathnuxeo", configuracion)
    Public pathvisualiza As New NodoXml("pathvisualiza", configuracion)

    Public conexionbd As New NodoXml("conexionnet", configuracion)
    Public ServidorFtp As New NodoXml("servidorftp", configuracion)

    ' Variables de uso para contener otras configuraciones
    Public MiId As String, MiDescripcion As String, miCopia As String


    Public Sub New()
        MyBase.New(AppDomain.CurrentDomain.BaseDirectory + "configdoc.xml")
    End Sub

End Class
