Class Errores


    Public Sub Muestraerror(ByVal Titulo As String, ByVal Origen As String, ByVal DescripcionError As String)
        'MsgBox(Texto)
        Dim E As New ClErrores(Origen)
        E.MuestraError(Titulo, Origen, DescripcionError)

    End Sub
End Class

