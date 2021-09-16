Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Security.Principal
Imports System.Security.Permissions
Imports System.Environment

Public Class EnlaceDocumentos

    Protected oServicioBd As ServicioBd
    Protected oConfig As ConfiguracionEnlace


    Public Sub New(tabla As String)

        oConfig = New ConfiguracionEnlace()
        oServicioBd = New ServicioBd(oConfig.conexionbd.Valor, tabla)

    End Sub


    Public Sub New(ByVal oConfig As ConfiguracionEnlace, tabla As String)

        Me.oConfig = oConfig
        oServicioBd = New ServicioBd(oConfig.conexionbd.Valor, tabla)

    End Sub


    Public Function AñadirArchivo(ByVal pathFichero As String, ByVal Descripcion As String, ByVal TipoDocumento As String) As Integer
        Return oServicioBd.InsertaDocumento(oConfig.MiId, SubirArchivo(pathFichero), Descripcion, TipoDocumento)
    End Function

    Public Function AñadirArchivo(ByVal pathFichero As String, ByVal Descripcion As String, ByVal TipoDocumento As String, ByRef IdNuxeo As String) As Integer
        IdNuxeo = SubirArchivo(pathFichero)
        Return oServicioBd.InsertaDocumento(oConfig.MiId, IdNuxeo, Descripcion, TipoDocumento)
    End Function



    Protected Overridable Function SubirArchivo(ByVal pathFichero As String) As String
        Return ""
    End Function


    Public Function BorrarArchivo(ByVal idFichero As String) As Integer
        EliminarArchivo(idFichero & ".pdf")
        Return oServicioBd.EliminaDocumento(oConfig.MiId, idFichero)
    End Function

    Public Function EliminarRegistro(ByVal idFichero As String) As Integer
        Return oServicioBd.EliminaDocumento(oConfig.MiId, idFichero)
    End Function


    Protected Sub EliminarArchivo(ByVal Archivo As String)


        Try

            If My.Computer.FileSystem.FileExists(oConfig.path.Valor + Archivo) Then

                For Each p As Process In Process.GetProcesses()
                    If Not p Is Nothing Then
                        If p.ProcessName.ToLower = "acrord32" Then
                            p.Kill()
                            Exit For
                        End If
                    End If
                Next

                Dim fichero As New System.IO.FileInfo(oConfig.path.Valor + Archivo)
                My.Computer.FileSystem.DeleteFile(oConfig.path.Valor + Archivo, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)

            End If

        Catch ex As Exception

            Dim strComandoShell As String
            strComandoShell = "net use n: " + oConfig.path.Valor.Substring(oConfig.path.Valor.Length - 1) + " " + oConfig.passwordfichero.Valor + " /USER:" + oConfig.usuariofichero.Valor + "  /yes"
            Shell(strComandoShell, AppWinStyle.Hide, True)
            strComandoShell = "net use n: /DELETE /yes"
            Shell(strComandoShell, AppWinStyle.Hide, True)
            System.IO.File.Delete(oConfig.path.Valor + Archivo)

        Finally

        End Try

    End Sub


    Protected Overridable Function DameFichero(ByVal pathFichero As String) As String

        Dim mifile As String
        Dim dir() As String = pathFichero.Split(CChar("\"))
        'mifile = New RegularExpressions.Regex("[^a-zA-Z0-9 .]").Replace(dir(dir.Count - 1).Normalize(NormalizationForm.FormD), "")
        mifile = New RegularExpressions.Regex("[^a-zA-Z0-9 .]").Replace(dir(dir.Length - 1).Normalize(NormalizationForm.FormD), "")
        Return mifile

    End Function

    Public Function RecogeFicheros() As DataTable
        Return oServicioBd.RecogeDocumentos(oConfig.MiId)
    End Function

    Public Function RecogeFicherosPorNif(nif As String) As DataTable
        Return oServicioBd.RecogeDocumentosPorNIF(nif)
    End Function

    Public Overridable Function VisualizaFichero(ByVal idFichero As String) As String
        Return oConfig.pathvisualiza.Valor + idFichero.Trim
    End Function

    Public Sub ReplicaDocumentos(ByVal idOriginal As String, ByVal idCopia As String)
        oServicioBd.ReplicaDocumento(idOriginal, idCopia)
    End Sub

End Class








