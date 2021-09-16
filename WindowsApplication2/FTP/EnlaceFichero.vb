
Imports System.Text

Public Class EnlaceFichero

    Inherits EnlaceDocumentos

    Public Sub New(ByVal oConfig As ConfiguracionEnlace, tabla As String)
        MyBase.new(oConfig, tabla)
    End Sub


    Protected Overrides Function DameFichero(ByVal pathFichero As String) As String
        Return CStr(CDbl(oServicioBd.UltimoDocumento))
    End Function


    Public Overrides Function VisualizaFichero(ByVal idFichero As String) As String
        Return oConfig.pathvisualiza.Valor + idFichero.ToString.Trim + ".pdf"
    End Function



    Protected Overrides Function SubirArchivo(ByVal pathFichero As String) As String

        Dim mifile As String = DameFichero(pathFichero)

        Try
            If mifile.ToLower.Contains(".pdf") Then
                System.IO.File.Copy(pathFichero, oConfig.path.Valor + mifile)
            Else
                System.IO.File.Copy(pathFichero, oConfig.path.Valor + mifile & ".pdf")
            End If

        Catch ex As Exception

            Dim strComandoShell As String
            strComandoShell = "net use n: " + oConfig.path.Valor.Substring(0, oConfig.path.Valor.Length - 1) + " " + oConfig.passwordfichero.Valor + " /USER:" + oConfig.usuariofichero.Valor + "  /yes"
            Shell(strComandoShell, AppWinStyle.Hide, True)
            strComandoShell = "net use n: /DELETE /yes"
            Shell(strComandoShell, AppWinStyle.Hide, True)
            System.IO.File.Copy(pathFichero, oConfig.path.Valor + mifile)

        Finally

        End Try


        Return mifile

    End Function

End Class
