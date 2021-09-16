Public Module FuncionesEDI


    'Public Function PadNumero(numero As String, longitud As Integer) As String

    '    Dim res As String = numero.PadRight(longitud, Convert.ToChar("0"))
    '    res = res.Substring(0, longitud)

    '    Return res

    'End Function


    Public Function PadNumero(numero As Decimal, longitud As Integer) As String

        Return PadImporte(numero, longitud, 0)

    End Function


    Public Function PadVacio(longitud As Integer) As String

        'EDICOM recomieda enviar el campo vacío si el número es 0
        Return "".PadRight(longitud, " ")

    End Function


    Public Function PadTexto(texto As String, longitud As Integer) As String

        Dim res As String = texto.PadRight(longitud, Convert.ToChar(" "))
        res = res.Substring(0, longitud)

        Return res

    End Function


    Public Function PadImporte(importe As Decimal, longitud As Integer, decimales As Integer) As String

        Dim res As String = ""


        Dim formato As String = "0.".PadRight(decimales + 2, Convert.ToChar("0"))
        res = importe.ToString(formato)
        res = res.PadLeft(longitud, Convert.ToChar("0"))
        res = res.Replace(",", ".")
        res = res.Substring(0, longitud)


        Return res

    End Function


    Public Function PadImporteSigno(importe As Decimal, longitud As Integer, decimales As Integer, obligatorio As Boolean) As String

        Dim res As String = ""

        If importe = 0 And Not obligatorio Then

            res = PadVacio(longitud)

        Else

            Dim signo As String = "0"
            If importe < 0 Then signo = "-"

            importe = Math.Abs(importe)
            Dim formato As String = "0.".PadRight(decimales + 2, Convert.ToChar("0"))
            Dim numero_formateado As String = importe.ToString(formato)
            numero_formateado = numero_formateado.Replace(",", ".")

            Dim numero As String() = Split(numero_formateado, ".")
            If numero.Length = 2 Then
                res = signo & numero(0).PadLeft(longitud - decimales - 1 - 1, "0")           'menos el punto decimal y menos el signo
                res = res & "." & numero(1)
            End If


        End If


        Return res

    End Function


    Public Function PadNumeroSigno(numero As Integer, longitud As Integer, obligatorio As Boolean) As String

        Dim res As String = ""

        If numero = 0 And Not obligatorio Then
            res = PadVacio(longitud)
        Else

            Dim signo As String = "0"
            If numero < 0 Then signo = "-"

            res = signo & numero.ToString.PadLeft(longitud - 1, "0")


        End If


        Return res

    End Function

End Module
