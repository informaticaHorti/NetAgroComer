
' comparar elementos del ListView de ficheros enviados
Class ListViewEnviadosItemComparer
    Implements IComparer

    Private col As Integer

    Public Sub New()
        col = 0
    End Sub

    Public Sub New(ByVal column As Integer)
        col = column
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
       Implements IComparer.Compare
        If col = 0 Then
            Dim fec1 As String = CType(x, ListViewItem).SubItems(col).Text
            Dim fec2 As String = CType(y, ListViewItem).SubItems(col).Text
            If fec1.Length = 10 Then fec1 = fec1.Substring(6, 4) & fec1.Substring(3, 2) & fec1.Substring(0, 2)
            If fec2.Length = 10 Then fec2 = fec2.Substring(6, 4) & fec2.Substring(3, 2) & fec2.Substring(0, 2)
            Return String.Compare(fec1, fec2)
        Else
            Return [String].Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
        End If
    End Function

End Class

' comparar fechas de ultima actualizacion de ficheros
Public Class OrdenarFicherosFecha
    Implements IComparer

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare

        Dim mensaje1 As System.IO.FileInfo
        Dim mensaje2 As System.IO.FileInfo

        mensaje1 = DirectCast(x, System.IO.FileInfo)
        mensaje2 = DirectCast(y, System.IO.FileInfo)

        Compare = DateTime.Compare(mensaje1.LastWriteTime, mensaje2.LastWriteTime)

    End Function

End Class


