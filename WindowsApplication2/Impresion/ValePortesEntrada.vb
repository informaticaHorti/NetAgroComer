Public Class ValePortesEntrada


    Public Sub ImprimirValePortesEntrada(IdAlbaran As String)

        Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
        Dim err As New Errores


        If AlbEntrada.LeerId(IdAlbaran) Then

            Try



            Catch ex As Exception
                err.Muestraerror("Error al leer el albarán de entrada con id: " & IdAlbaran, "ImprimirValePortesEntrada", ex.Message)
            End Try

        Else
            err.Muestraerror("Error al leer el albarán de entrada con id: " & IdAlbaran, "ImprimirValePortesEntrada", "Error al leer el albarán de entrada con id: " & IdAlbaran)
        End If


    End Sub


End Class
