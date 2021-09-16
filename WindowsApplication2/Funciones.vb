Imports System.Net

Module Funciones


    Dim err As Errores

    Dim Ta() As String
    Dim Tb() As String
    Dim Tc() As String
    Dim Td() As String


    Public Sub parte2Cadena(ByVal Cadena As String, ByRef cadres1 As String, ByRef cadres2 As String, longmax As Integer)
        ' Divide la cadena dada en cadena en 2 cadenas (cadres1 y cadres2) con una longitud máxima de la
        ' por cadena especificada en longmax. No parte fraccionando palabras sino teniendo
        ' en cuenta los delimitadores de espacios blancos.
        Dim i As String

        cadres1 = Left(Cadena, longmax)
        cadres2 = Mid(Cadena, longmax + 1)
        i = Len(cadres1)
        If cadres2 <> "" And Mid(Cadena, i + 1, 1) <> " " Then
            While Mid(cadres1, i, 1) <> " " And i > 1
                cadres2 = Mid(cadres1, i, 1) + cadres2
                i = i - 1
            End While
            If i = 1 Then
                cadres1 = Cadena
                cadres2 = ""
            Else
                cadres1 = Mid(cadres1, 1, i)
            End If
        End If
    End Sub
  


    Public Function LIMPIANOMBRE(ByVal Nombre As String) As String

        Dim x As Integer
        Dim n As String
        Dim C As String

        n = ""
        For x = 1 To Len(Nombre)
            C = Mid(Nombre, x, 1)

            Select Case C
                Case "Á", "Ä"
                    C = "A"
                Case "É", "Ë"
                    C = "E"
                Case "Í", "Ï"
                    C = "I"
                Case "Ó", "Ö"
                    C = "O"
                Case "Ú", "Ü"
                    C = "U"
                Case "á", "ä"
                    C = "a"
                Case "é", "ë"
                    C = "e"
                Case "í", "ï"
                    C = "i"
                Case "ó", "ö"
                    C = "o"
                Case "ú", "ü"
                    C = "u"
                Case "¦"
                    C = "."
                Case "¥"
                    C = "Ñ"

            End Select


            If InStr("ç,.-ºª()&_@+'´" + Chr(34), C) > 0 Then
                n = n + " "
            Else
                n = n + C
            End If
        Next
        LIMPIANOMBRE = n

    End Function


    Public Function ObtenerIpLocal() As String

        Dim res As String = ""


        Try

            Dim Host As String = Dns.GetHostName

            'Dim IPs As IPHostEntry = Dns.GetHostByName(Host)
            Dim IPs As IPHostEntry = Dns.GetHostEntry(Host)
            Dim Direcciones As IPAddress() = IPs.AddressList


            For Each ip As IPAddress In Direcciones
                If ip.AddressFamily = Sockets.AddressFamily.InterNetwork Then
                    'Coge la primera
                    res = ip.ToString()
                    Exit For
                End If
            Next

            'Se despliega la lista de IP's
            'For i_cont = 0 To i_cont = Direcciones.Length
            '    Console.WriteLine("IP {0}: {1} ", i_cont + 1, Direcciones(i_cont).ToString())
            'Next

        Catch ex As Exception

        End Try



        Return res

    End Function


#Region "Filtros de FrConsulta"

    Public Function FiltroDesdeHasta(Parametro As String, tx1 As String, tx2 As String) As String

        Dim res As String = ""

        If tx1 <> "" Then res = "Desde " & Parametro & " " & tx1
        If tx2.Trim <> "" Then
            If res = "" Then
                res = "Hasta " & Parametro & " " & tx2
            Else
                res = res & " hasta " & Parametro & " " & tx2
            End If
        End If


        Return res

    End Function


    Public Function FiltroCheckedComboBox(Parametro As String, cb As DevExpress.XtraEditors.CheckedComboBoxEdit) As String

        Dim res As String = ""


        Dim lst As List(Of String) = ValoresDeCombo(cb)
        For Each s As String In lst
            If res.Trim <> "" Then res = res & ","
            res = res & s
        Next
        If res <> "" Then
            res = Parametro & ": " & res
        Else
            res = Parametro & ": TODOS"
        End If

        Return res

    End Function


    Public Function FiltroCombo(Parametro As String, cb As ComboBox) As String

        Dim res As String = ""

        res = Parametro & ": " & cb.Text


        Return res

    End Function


    Public Function FiltroCheckBox(Parametro As String, chk As Chk, ValorTrue As String, ValorFalse As String) As String
        Return FiltroCheckBox(Parametro, chk.Checked, ValorTrue, ValorFalse)
    End Function

    Public Function FiltroCheckBox(Parametro As String, chk As CheckBox, ValorTrue As String, ValorFalse As String) As String
        Return FiltroCheckBox(Parametro, chk.Checked, ValorTrue, ValorFalse)
    End Function


    Private Function FiltroCheckBox(Parametro As String, ValorChecked As Boolean, ValorTrue As String, ValorFalse As String) As String

        Dim res As String = ""

        If Parametro <> "" Then Parametro = Parametro & ": "


        If ValorChecked Then
            If ValorTrue.Trim <> "" Then
                res = Parametro & ValorTrue
            End If
        Else
            If ValorFalse.Trim <> "" Then
                res = Parametro & ValorFalse
            End If
        End If


        Return res

    End Function


    Public Function FiltroRadioButton(Parametro As String, array_rb As RadioButton(), array_str As String()) As String

        Dim res As String = ""


        For indice As Integer = 0 To array_rb.Length - 1
            If array_rb(indice).Checked Then
                res = array_str(indice)
            End If
        Next


        If res <> "" Then res = Parametro & ": " & res

        Return res

    End Function


    Public Function ValoresDeCombo(ByVal Combo As DevExpress.XtraEditors.CheckedComboBoxEdit) As List(Of String)
        Dim resultado As New List(Of String)
        Dim i As Integer = 0
        Dim s As Integer = 0
        Dim n As Integer = 0
        If Combo IsNot Nothing Then

            For Each it As DevExpress.XtraEditors.Controls.CheckedListBoxItem In Combo.Properties.GetItems()
                If it.CheckState = CheckState.Checked Then
                    resultado.Add(it.Description)
                    s = s + 1
                Else
                    n = n + 1
                End If
                i = i + 1
            Next

        End If
        If s = i Or n = i Then
            resultado.Clear() ' todas checked
        End If
        Return resultado

    End Function


#End Region


#Region "Codigo de barras"

    'Public Function CodigoBarras(texto) As Image

    '    Dim bc As New DevExpress.XtraPrinting.BarCode.Code93Generator
    '    Dim a As New DevExpress.XtraExport.ui.barcode



    '    'Dim bc As New DevExpress.XtraReports.UI.XRBarCode()

    '        bc.Symbology = new DevExpress.XtraPrinting.BarCode.DataMatrixGenerator();
    '        bc.Text = "0123456789";
    '        bc.Width = 100;
    '        bc.Height = 100;

    '        bc.AutoModule = false;
    '        bc.Module = 3;

    '        // Adjust the barcode's specific properties. 
    '        ((DataMatrixGenerator)bc.Symbology).CompactionMode = DataMatrixCompactionMode.Text;
    '        ((DataMatrixGenerator)bc.Symbology).MatrixSize = DataMatrixSize.Matrix96x96;

    '    DBConcurrencyException.to()

    'End Function



#End Region



    Private Enum TiposCodigosEnum
        NIF
        NIE
        CIF
        CIFExtranjero
    End Enum

#Region "NIF, NIE"

    Public Function ObtenerLetraDNI_NIE(dni As String)

        Dim res As String = ""


        Dim regex As New System.Text.RegularExpressions.Regex("[^\w]")
        Dim Numero As String = regex.Replace(dni, "").ToUpper

        If Numero.Length <> 9 AndAlso Numero.Length <> 11 Then
            If Numero.Length > 15 AndAlso Numero.Length < 8 Then
                Return ""
            End If
        End If


        If Numero.Length < 11 And Numero.Length > 0 Then

            Try

                Dim tipo As TiposCodigosEnum = TipoIdentificacion(Numero(0))
                Dim n As Int32

                If tipo = TiposCodigosEnum.NIF Then
                    Int32.TryParse(Numero.Substring(0, 8), n)
                ElseIf tipo = TiposCodigosEnum.NIE Then
                    Dim LetraInicial As String = Numero.Substring(0, 1).Replace("X", "0").Replace("Y", "1").Replace("Z", "2")
                    Int32.TryParse(LetraInicial & Numero.Substring(1, 7), n)
                End If

                Select Case tipo
                    Case TiposCodigosEnum.NIF, TiposCodigosEnum.NIE

                        res = ObtenLetraDNI(n)

                        'If n.ToString.PadLeft(8, Convert.ToChar("0")) & res = dni.Trim Then
                        If Numero.PadLeft(8, Convert.ToChar("0")).Substring(0, 8) & res = dni.Trim Then
                            'Ya tiene la letra
                            res = ""
                        End If

                End Select

            Catch ex As Exception
            End Try

        End If



        Return res

    End Function


    ''' <summary>
    ''' En base al primer carácter del código, se obtiene el tipo de documento que se intenta
    ''' comprobar
    ''' </summary>
    ''' <param name="letra">Primer carácter del número pasado</param>
    ''' <returns>Tipo de documento</returns>
    Private Function TipoIdentificacion(ByVal letra As Char) As TiposCodigosEnum
        Dim regexNumeros As New System.Text.RegularExpressions.Regex("[0-9]")
        If regexNumeros.IsMatch(letra.ToString()) Then
            Return TiposCodigosEnum.NIF
        End If

        Dim regexLetrasNIE As New System.Text.RegularExpressions.Regex("[XYZ]")
        If regexLetrasNIE.IsMatch(letra.ToString()) Then
            Return TiposCodigosEnum.NIE
        End If

        Dim regexLetrasCIF As New System.Text.RegularExpressions.Regex("[ABCDEFGHJPQRSUVNW]")
        If regexLetrasCIF.IsMatch(letra.ToString()) Then
            Return TiposCodigosEnum.CIF
        End If
        Dim regexLetrasCIFExtranjero As New System.Text.RegularExpressions.Regex("[ABCDEFGHIJKLMNOPQRSTUVWXYZ]")
        If regexLetrasCIFExtranjero.IsMatch(letra.ToString()) Then
            Return TiposCodigosEnum.CIFExtranjero
        End If


        Throw New ApplicationException("El código no es reconocible")
    End Function


    ''' <summary>
    ''' Obtiene la letra correspondiente al Dni
    ''' </summary>
    Private Function ObtenLetraDNI(Numero As String) As String
        Dim indice As Integer = Numero Mod 23
        Return "TRWAGMYFPDXBNJZSQVHLCKET"(indice).ToString()
    End Function


#End Region




#Region "Conversion"


    Public Function Upcampo(ByVal dato As Double) As String
        Dim d As String
        d = dato.ToString
        d = d.Replace(".", "")
        d = d.Replace(",", ".")
        Return d

    End Function


    ''' <summary>
    ''' devuelve un Color de .NET a partir de su correspondiente codigo de color VB6
    ''' </summary>
    ''' <param name="colorVB6"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ColorNET(ByVal colorVB6 As Integer) As System.Drawing.Color

        Dim ret As System.Drawing.Color = Color.White
        ret = ColorTranslator.FromOle(colorVB6)
        Return ret

    End Function
    Public Function FnColorNET(ByVal colorVB6 As Integer) As System.Drawing.Color
        Return ColorNET(colorVB6)
    End Function

    ''' <summary>
    ''' convierte la fecha pasada en un string del stipo ShortDateString
    ''' </summary>
    ''' <param name="valor"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function StDate(ByVal valor As Date) As String

        Dim resultado As String
        resultado = valor.ToShortDateString
        Return resultado

    End Function


    Public Function VaInt64(ByVal valor As Object) As Int64
        Dim resultado As Int64
        If IsNumeric(valor) Then
            resultado = Convert.ToInt64(valor)
        Else
            Return 0
        End If
        Return resultado
    End Function


    Public Function FnStDate(ByVal valor As Date) As String
        Return StDate(valor)
    End Function

    ''' <summary>
    ''' convierte el decimal pasado en un string; devuelve 0 si se lo indicamos
    ''' </summary>
    ''' <param name="valor"></param>
    ''' <param name="devuelve0"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function StDec(ByVal valor As Decimal, Optional ByVal devuelve0 As Boolean = False) As String

        Dim resultado As String
        If valor = 0 Then
            If devuelve0 Then
                resultado = "0"
            Else
                resultado = ""
            End If
        Else
            resultado = valor.ToString
        End If
        Return resultado

    End Function
    Public Function FnStDec(ByVal valor As Decimal, Optional ByVal devuelve0 As Boolean = False) As String
        Return StDec(valor, devuelve0)
    End Function

    ''' <summary>
    ''' convierte el integer pasado en un string; devuelve 0 si se lo indicamos
    ''' </summary>
    ''' <param name="valor"></param>
    ''' <param name="devuelve0"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function StInt(ByVal valor As Integer, Optional ByVal devuelve0 As Boolean = False) As String

        Dim resultado As String
        If valor = 0 Then
            If devuelve0 Then
                resultado = "0"
            Else
                resultado = ""
            End If
        Else
            resultado = valor.ToString
        End If
        Return resultado

    End Function
    Public Function FnStInt(ByVal valor As Integer, Optional ByVal devuelve0 As Boolean = False) As String
        Return StInt(valor, devuelve0)
    End Function

    ''' <summary>
    ''' devuelve un date a partir del valor pasado en "valor", tipic. un string con una fecha valida
    ''' </summary>
    ''' <param name="valor"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function VaDate(ByVal valor As Object) As Date

        Dim resultado As Date
        If IsDate(valor) Then
            resultado = CDate(CDate(valor).ToShortDateString)
        Else
            Return CDate("01/01/1900")
        End If

        Return resultado

    End Function
    Public Function FnVaDate(ByVal valor As Object) As Date
        Return VaDate(valor)
    End Function


    Public Function VaTime(ByVal valor As Object) As DateTime

        Dim resultado As DateTime

        'If Not DateTime.TryParse("01/01/1900 " & valor, resultado) Then
        If Not DateTime.TryParse(valor, resultado) Then
            resultado = VaDate("")
        End If


        Return resultado

    End Function


    ''' <summary>
    ''' devuelve el valor decimal del dato pasado en "valor", tipic. un string
    ''' </summary>
    ''' <param name="valor"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function VaDec(ByVal valor As Object) As Decimal

        ' convertir a decimal
        Dim resultado As Decimal
        If valor Is DBNull.Value Then Return 0
        If valor Is Nothing Then Return 0

        If IsNumeric(valor) Then
            resultado = CDec(valor)
        Else
            Return 0
        End If

        Return resultado

    End Function
    Public Function FnVaDec(ByVal valor As Object) As Decimal
        Return VaDec(valor)
    End Function
    ''' <summary>
    '''  devolvemos como string un valor decimal, si es cero podemos devolverlo o traernos "" en su lugar
    ''' </summary>
    ''' <param name="valor"></param>
    ''' <param name="siZero"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FnVaDecStr(ByVal valor As Object, siZero As Boolean) As String
        Dim r As Decimal = VaDec(valor)
        If siZero = True Then
            Return r.ToString
        Else
            If r = 0 Then
                Return ""
            Else
                Return r.ToString
            End If
        End If
    End Function


    ''' <summary>
    ''' devuelve el valor entero del dato pasado en "valor", tipic. un string
    ''' </summary>
    ''' <param name="valor"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function VaInt(ByVal valor As Object) As Integer

        Dim resultado As Integer
        If valor Is DBNull.Value Then Return 0
        If valor Is Nothing Then Return 0

        If IsNumeric(valor) Then
            resultado = CInt(valor)
        Else
            Return 0
        End If

        Return resultado

    End Function
    Public Function FnVaInt(ByVal valor As Object) As Integer
        Return VaInt(valor)
    End Function

    ''' <summary>
    ''' devuelve el valor entero del dato pasado en "valor", tipic. un string
    ''' </summary>
    ''' <param name="valor"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function VaLng(ByVal valor As Object) As Long

        Dim resultado As Long
        If valor Is DBNull.Value Then Return 0
        If valor Is Nothing Then Return 0

        If IsNumeric(valor) Then
            resultado = CLng(valor)
        Else
            Return 0
        End If

        Return resultado

    End Function
    Public Function FnVaLng(ByVal valor As Object) As Long
        Return VaLng(valor)
    End Function

#End Region

#Region "Formato"

    Private Function NumeroARomano(ByVal Numero As Integer, ByVal nt As Integer) As String

        Dim cd As String = ""
        Select Case Numero
            Case 0
                Exit Select
            Case 1
                Select Case nt
                    Case 1
                        cd = "I"
                        Exit Select
                    Case 2
                        cd = "X"
                        Exit Select
                    Case 3
                        cd = "C"
                        Exit Select
                    Case 4
                        cd = "M"
                        Exit Select
                    Case 5
                        cd = cd.PadRight(10, Convert.ToChar("M"))
                        Exit Select
                End Select
                Exit Select
            Case 2
                Select Case nt
                    Case 1
                        cd = "II"
                        Exit Select
                    Case 2
                        cd = "XX"
                        Exit Select
                    Case 3
                        cd = "CC"
                        Exit Select
                    Case 4
                        cd = "MM"
                        Exit Select
                    Case 5
                        cd = cd.PadRight(20, Convert.ToChar("M"))
                        Exit Select
                End Select
                Exit Select
            Case 3
                Select Case nt
                    Case 1
                        cd = "III"
                        Exit Select
                    Case 2
                        cd = "XXX"
                        Exit Select
                    Case 3
                        cd = "CCC"
                        Exit Select
                    Case 4
                        cd = "MMM"
                        Exit Select
                    Case 5
                        cd = cd.PadRight(30, Convert.ToChar("M"))
                        Exit Select
                End Select
                Exit Select
            Case 4
                Select Case nt
                    Case 1
                        cd = "IV"
                        Exit Select
                    Case 2
                        cd = "LX"
                        Exit Select
                    Case 3
                        cd = "CD"
                        Exit Select
                    Case 4
                        cd = "MMMM"
                        Exit Select
                    Case 5
                        cd = cd.PadRight(40, Convert.ToChar("M"))
                        Exit Select
                End Select
                Exit Select
            Case 5
                Select Case nt
                    Case 1
                        cd = "V"
                        Exit Select
                    Case 2
                        cd = "X"
                        Exit Select
                    Case 3
                        cd = "D"
                        Exit Select
                    Case 4
                        cd = "MMMMM"
                        Exit Select
                    Case 5
                        cd = cd.PadRight(50, Convert.ToChar("M"))
                        Exit Select
                End Select
                Exit Select
            Case 6
                Select Case nt
                    Case 1
                        cd = "VI"
                        Exit Select
                    Case 2
                        cd = "LX"
                        Exit Select
                    Case 3
                        cd = "DC"
                        Exit Select
                    Case 4
                        cd = "MMMMMM"
                        Exit Select
                    Case 5
                        cd = cd.PadRight(60, Convert.ToChar("M"))
                        Exit Select
                End Select
                Exit Select
            Case 7
                Select Case nt
                    Case 1
                        cd = "VII"
                        Exit Select
                    Case 2
                        cd = "LXX"
                        Exit Select
                    Case 3
                        cd = "DCC"
                        Exit Select
                    Case 4
                        cd = "MMMMMMM"
                        Exit Select
                    Case 5
                        cd = cd.PadRight(70, Convert.ToChar("M"))
                        Exit Select
                End Select
                Exit Select
            Case 8
                Select Case nt
                    Case 1
                        cd = "VIII"
                        Exit Select
                    Case 2
                        cd = "LXXX"
                        Exit Select
                    Case 3
                        cd = "DCCC"
                        Exit Select
                    Case 4
                        cd = "MMMMMMMM"
                        Exit Select
                    Case 5
                        cd = cd.PadRight(80, Convert.ToChar("M"))
                        Exit Select
                End Select
                Exit Select
            Case 9
                Select Case nt
                    Case 1
                        cd = "IX"
                        Exit Select
                    Case 2
                        cd = "XC"
                        Exit Select
                    Case 3
                        cd = "CM"
                        Exit Select
                    Case 4
                        cd = "MMMMMMMMM"
                        Exit Select
                    Case 5
                        cd = cd.PadRight(90, Convert.ToChar("M"))
                        Exit Select
                End Select
                Exit Select

        End Select


        Return cd


    End Function


    Public Function ObtenerNumeroRomano(ByVal Number As Integer) As String

        Dim n1 As Integer, x As Integer, ln As Integer
        Dim stri As String, cd As String, dgt As String

        cd = Convert.ToString(Number)
        ln = cd.Length
        stri = ""
        x = 0

        While x < ln

            dgt = cd.Substring(x, 1)
            n1 = Convert.ToInt32(dgt)
            stri = stri & NumeroARomano(n1, ln - x)
            x += 1

        End While

        Return stri

    End Function


    Public Function FnSpace(ByVal Dato As String, ByVal n As Integer) As String
        Return Microsoft.VisualBasic.Left(Dato + Space(n), n)

    End Function


    Public Sub FnParte2Cadena(ByVal cadena As String, ByRef cadres1 As String, ByRef cadres2 As String, ByVal longmax As Integer)
        ' Divide la cadena dada en cadena en 2 cadenas (cadres1 y cadres2) con una longitud máxima de la
        ' por cadena especificada en longmax. No parte fraccionando palabras sino teniendo
        ' en cuenta los delimitadores de espacios blancos.
        Dim i As Integer

        cadres1 = Left(cadena, longmax)
        cadres2 = Mid(cadena, longmax + 1)
        i = Len(cadres1)

        If cadres2 <> "" And Mid(cadena, i + 1, 1) <> " " Then
            While Mid(cadres1, i, 1) <> " " And i > 1
                cadres2 = Mid(cadres1, i, 1) + cadres2
                i = i - 1
            End While
            If i = 1 Then
                cadres1 = cadena
                cadres2 = ""
            Else
                cadres1 = Mid(cadres1, 1, i)
            End If
        End If
    End Sub

    Private Function Unidad(ByVal numcad As String) As String
        Unidad = Ta(VaInt(numcad))
    End Function
    Private Function Decena(ByVal numcad As String) As String
        Dim resul As String

        resul = Tb(VaInt(Mid(numcad, 1, 1))) + " Y " + Ta(VaInt(Mid(numcad, 2, 1)))
        If VaInt(numcad) = 0 Then
            resul = ""
        ElseIf VaInt(numcad) < 10 Then
            resul = Ta(VaInt(numcad))
        ElseIf VaInt(Mid(numcad, 2, 1)) = 0 Then
            resul = Tb(VaInt(Mid(numcad, 1, 1)))
        ElseIf VaInt(numcad) > 10 And VaInt(numcad) < 20 Then
            resul = Tc(VaInt(Right(numcad, 1)))
        End If

        If Left(resul, 9) = "VEINTE Y " Then
            Decena = "VEINTI" + Mid(resul, 10, Len(resul))
        Else
            Decena = resul
        End If

    End Function
    Private Function Centena(ByVal numcad As String) As String
        Dim resul As String

        If VaInt(numcad) = 0 Then
            Centena = ""
        ElseIf VaInt(numcad) = 100 Then
            Centena = "CIEN"
        Else
            resul = Decena(Right(numcad, 2))
            If VaInt(numcad) < 100 Then
                Centena = resul
            Else
                Centena = Td(VaInt(Left(numcad, 1))) + " " + resul
            End If
        End If

    End Function
    Private Function Millar(ByVal numcad As String) As String
        Dim resul As String

        resul = Centena(Right(numcad, 3))
        If VaLng(Left(numcad, 1)) = 1 Then
            Millar = "MIL " + resul
        Else
            Millar = Ta(VaInt(Left(numcad, 1))) + " MIL " + resul
        End If

    End Function
    Private Function Demillar(ByVal numcad As String) As String
        Dim izq, der As String

        izq = Decena(Left(numcad, 2))
        der = Centena(Right(numcad, 3))
        Demillar = izq + " MIL " + der

    End Function
    Private Function Cemillar(ByVal numcad As String) As String
        Dim izq, der As String

        izq = Centena(Left(numcad, 3))
        der = Centena(Right(numcad, 3))
        If izq = "" Then
            Cemillar = der
        Else
            Cemillar = izq + " MIL " + der
        End If

    End Function
    Private Function MenosDelMillon(ByVal numcad As String) As String

        Select Case Len(numcad)
            Case 1
                MenosDelMillon = Unidad(numcad)
            Case 2
                MenosDelMillon = Decena(numcad)
            Case 3
                MenosDelMillon = Centena(numcad)
            Case 4
                MenosDelMillon = Millar(numcad)
            Case 5
                MenosDelMillon = Demillar(numcad)
            Case 6
                MenosDelMillon = Cemillar(numcad)
            Case Else
                Return "0"
        End Select

    End Function

    ''' <summary>
    ''' devuelve un numero (la cantidad pasada) como texto
    ''' </summary>
    ''' <param name="Numero"></param>
    ''' <param name="masculino"></param>
    ''' <param name="Concepto"></param>
    ''' <param name="Concepto2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function NumLetra(ByVal Numero As Decimal, ByVal masculino As Boolean, ByVal fecha As Boolean, Optional ByVal Concepto As String = "", Optional Concepto2 As String = "") As String

        Dim posComa As Integer

        Dim parteEntera = ""
        Dim numcad As String = ""
        Dim parteDecimal As String = ""

        Dim dec As String = ""
        Dim izq As String = ""
        Dim der As String = ""

        Tb = {"", "DIEZ", "VEINTE", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA"}
        Tc = {"", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISEIS", "DIECISIETE", "DIECIOCHO", "DIECINUEVE"}

        If masculino Then

            If fecha Then
                Ta = {"", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE"}
            Else
                Ta = {"", "UN", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE"}
            End If

            Td = {"", "CIENTO", "DOSCIENTOS", "TRESCIENTOS", "CUATROCIENTOS", "QUINIENTOS", "SEISCIENTOS", "SETECIENTOS", "OCHOCIENTOS", "NOVECIENTOS"}
        Else
            Ta = {"", "UNA", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE"}
            Td = {"", "CIENTO", "DOSCIENTAS", "TRESCIENTAS", "CUATROCIENTAS", "QUINIENTAS", "SEISCIENTAS", "SETECIENTAS", "OCHOCIENTAS", "NOVECIENTAS"}
        End If

        Numero = Math.Round(Numero, 2)
        numcad = Mid(Str(Numero), 2)
        posComa = InStr(numcad, ".")

        If posComa > 0 Then
            parteEntera = Left(numcad, posComa - 1)
        Else
            parteEntera = numcad
        End If

        If Len(parteEntera) > 6 Then
            izq = MenosDelMillon(Left(parteEntera, Len(parteEntera) - 6))
            If izq = "UNO" Or izq = "UNA" Or izq = "UN" Then
                izq = "UN MILLON "
            Else
                izq = izq + " MILLONES "
            End If
            parteEntera = Right(parteEntera, 6)
        End If

        der = MenosDelMillon(parteEntera)

        If posComa > 0 Then

            parteDecimal = Mid(numcad, posComa + 1)
            parteDecimal = Left$(parteDecimal + "00", 2)
            dec = MenosDelMillon(parteDecimal)


            If VaDec(parteDecimal) = 0 Then

                If izq = "" And der = "" Then
                    NumLetra = "CERO " + Concepto + " "
                Else
                    NumLetra = izq + der + " " + Concepto + " "
                End If

            Else

                If izq = "" And der = "" Then
                    NumLetra = "CERO CON " + dec + " " + Concepto2
                Else
                    NumLetra = izq + der + " " + Concepto + " CON " + dec + " " + Concepto2
                End If

            End If


        Else
            'Concepto = ""
            NumLetra = izq + der + " " + Concepto
        End If

    End Function



    Public Function FnNumLetra(ByVal Numero As Decimal, ByVal masculino As Boolean, ByVal fecha As Boolean, Optional ByVal Concepto As String = "", Optional Concepto2 As String = "") As String
        Return NumLetra(Numero, masculino, fecha, Concepto, Concepto2)
    End Function
    ''' <summary>
    ''' devuelve un string con el numero de caracteres pasados del tipo de caracter pasado
    ''' replica la funcionalidad de String(num, CHAR) de vb6
    ''' </summary>
    ''' <param name="numero"></param>
    ''' <param name="caracter"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FnString(ByVal numero As Integer, ByVal caracter As String) As String

        Try
            Dim cadena As String = ""
            For i As Integer = 1 To numero
                cadena = cadena & caracter
            Next
            Return cadena
        Catch ex As Exception
            err.Muestraerror("No se pudo formatear " & numero.ToString & " caracter " & caracter, "Function fnString(ByVal numero As Integer, ByVal caracter As String) As String", ex.Message)
            Return numero.ToString
        End Try

    End Function

    Public Function SinMascara(ByVal Tipo As Cdatos.TiposCampo, ByVal Cadena As String) As String
        Try
            Dim miCadena As String = ""
            Select Case Tipo
                Case Cdatos.TiposCampo.Entero, Cdatos.TiposCampo.EnteroPositivo, Cdatos.TiposCampo.Fecha, Cdatos.TiposCampo.Hora, Cdatos.TiposCampo.Importe
                    If Cadena.Length > 0 Then
                        For i As Integer = 0 To Cadena.Length - 1
                            If InStr("1234567890,-", Cadena.Substring(i, 1)) > 0 Then
                                miCadena = miCadena + Cadena.Substring(i, 1)
                            End If
                        Next
                        If Tipo = Cdatos.TiposCampo.Fecha And miCadena = "01011900" Then
                            miCadena = ""
                        End If
                        If Tipo = Cdatos.TiposCampo.Hora And miCadena = "000000" Then
                            miCadena = ""
                        End If
                        If Tipo = Cdatos.TiposCampo.Importe Then
                            Dim v1 As Double = VaDec(miCadena)
                            Dim v2 As Double = Int(VaDec(miCadena))
                            If v1 = v2 Then
                                miCadena = v2.ToString
                            End If
                        End If

                    Else
                        miCadena = Cadena
                    End If

                Case Else
                    miCadena = Cadena
            End Select

            Return miCadena

        Catch ex As Exception
            err.Muestraerror("No se pudo devolver sin mascara   de la cadena" & Cadena, "Function SinMascara(ByVal tipoMascara As TipoCampo, ByVal Cadena As String) As String", ex.Message)
            Return Cadena
        End Try

    End Function
    Public Function FnSinMascara(ByVal Tipo As Cdatos.TiposCampo, ByVal Cadena As String) As String
        Return SinMascara(Tipo, Cadena)
    End Function

    ''' <summary>
    ''' formatea dato con el tipo de mascara indicado
    ''' </summary>
    ''' <param name="dato"></param>
    ''' <param name="tipo"></param>
    ''' <param name="numdecimales"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Mascara(ByVal dato As String, ByVal tipo As Cdatos.TiposCampo, Optional ByVal numdecimales As Integer = 0) As String

        Try
            Dim formato As String = ""
            Select Case tipo
                Case Cdatos.TiposCampo.EnteroPositivo, Cdatos.TiposCampo.Entero
                    'formato = "#,###"
                    'Return Format(VaInt(dato), formato)
                    If CInt(dato) = 0 Then
                        Return ""
                    Else
                        Return dato
                    End If

                Case Cdatos.TiposCampo.Importe
                    If numdecimales > 0 Then
                        formato = "#,###0." & FnString(numdecimales, "0")
                    Else
                        formato = "#,###"
                    End If
                    Return Format(VaDec(dato), formato)

                Case Cdatos.TiposCampo.Fecha
                    formato = "dd/MM/yyyy"
                    dato = FnFecha(dato)
                    If dato <> "" Then
                        Return dato.Substring(0, 2) + "/" + dato.Substring(2, 2) + "/" + dato.Substring(4, 4)
                    Else
                        Return ""
                    End If

                Case Cdatos.TiposCampo.Hora
                    formato = "HH:mm:ss"
                    dato = FnHora(dato)
                    If dato <> "" Then
                        Return dato.Substring(0, 2) & ":" & dato.Substring(2, 2) & ":" & dato.Substring(4, 2)
                    Else
                        Return ""
                    End If

                Case Cdatos.TiposCampo.FechaHora
                    formato = "dd/MM/yyyy HH:mm:ss"
                    If dato <> "" Then
                        Dim fecha As DateTime
                        If DateTime.TryParse(dato, fecha) Then
                            Return fecha.ToString(formato)
                        Else
                            Return ""
                        End If
                    Else
                        Return ""
                    End If

                Case Else
                    formato = ""
                    Return dato

            End Select

        Catch ex As Exception
            'err.Muestraerror("No se pudo devolver la mascara " & tipo.ToString & " num decimales " & numdecimales, "DevuelveMascara(ByVal tipo As TipoCampo, Optional ByVal numdecimales As Integer = 0) As String", ex.Message)
            Return ""
        End Try

    End Function
    Public Function FnMascara(ByVal dato As String, ByVal tipo As Cdatos.TiposCampo, Optional ByVal numdecimales As Integer = 0, Optional noZero As Boolean = False) As String
        Dim ret As String = Mascara(dato, tipo, numdecimales)
        If noZero = True Then
            If IsNumeric(ret) = True Then
                If FnVaDec(ret) = 0 Then ret = ""
            End If
        End If
        Return ret
    End Function

    ''' <summary>
    ''' Formatea un valor numérico con formato de importe y los decimales indicados
    ''' </summary>
    ''' <param name="Cadena"></param>
    ''' <param name="NumDecimales"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FormatearMascaraDecimales(ByVal Cadena As String, Optional ByVal NumDecimales As Integer = 0) As String
        Try
            Dim resultado As String = ""
            Dim mascara As String = ""
            mascara = DevuelveMascara(Cdatos.TiposCampo.Importe, NumDecimales)

            If Cadena = "" Then
                Cadena = "0"
            End If

            resultado = Format(VaDec(Cadena), mascara)

            Return resultado
        Catch ex As Exception
            'err.MuestraError("No se pudo formatear la mascara " & tipoMascara.ToString & " de la cadena " & Cadena & " num decimales " & NumDecimales & " manual=" & Manual, "FormatearMascara(ByVal tipoMascara As TipoCampo, ByVal Cadena As String, Optional ByVal NumDecimales As Integer = 0, Optional ByVal Manual As String = "") As String", ex.Message)
            Return ""
        End Try


    End Function

    Public Function FnFormatearMascaraDecimales(ByVal Cadena As String, Optional ByVal NumDecimales As Integer = 0) As String
        Return FormatearMascaraDecimales(Cadena, NumDecimales)
    End Function

    ''' <summary>
    ''' Devuelve el formato según el tipo de bdcampo
    ''' </summary>
    ''' <param name="tipo"></param>
    ''' <param name="numdecimales"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DevuelveMascara(ByVal tipo As Cdatos.TiposCampo, Optional ByVal numdecimales As Integer = 0) As String

        Try
            Dim formato As String = ""
            Select Case tipo
                Case Cdatos.TiposCampo.Importe
                    If numdecimales > 0 Then
                        formato = "#,###0." & FnString(numdecimales, "0")
                    Else
                        formato = "#,###"
                    End If

                Case Cdatos.TiposCampo.Fecha
                    formato = "dd/MM/yyyy"

                Case Cdatos.TiposCampo.Hora
                    formato = "HH:mm:ss"

                Case Cdatos.TiposCampo.FechaHora
                    formato = "dd/MM/yyyy HH:mm:ss"

                Case Cdatos.TiposCampo.Entero, Cdatos.TiposCampo.EnteroPositivo

                Case Else
                    formato = ""
            End Select

            Return formato
        Catch ex As Exception
            err.Muestraerror("No se pudo devolver la mascara " & tipo.ToString & " num decimales " & numdecimales, "DevuelveMascara(ByVal tipo As TipoCampo, Optional ByVal numdecimales As Integer = 0) As String", ex.Message)
            Return ""
        End Try

    End Function

    Public Function FnDevuelveMascara(ByVal tipo As Cdatos.TiposCampo, Optional ByVal numdecimales As Integer = 0) As String
        Return DevuelveMascara(tipo, numdecimales)
    End Function

    ''' <summary>
    ''' comprueba si el string "fecha" contiene una fecha valida, devuelve "" si no la contiene
    ''' </summary>
    ''' <param name="fecha"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FnFecha(ByVal fecha As String, Optional dfecha As String = "", Optional hfecha As String = "") As String
        Try
            Dim F As String
            Dim Milenio As String
            Dim Dias(12) As Integer

            Dim D As Integer
            Dim M As Integer

            If fecha = "" Then
                FnFecha = ""
                Exit Function
            End If

            Dias(1) = 31 : Dias(2) = 28 : Dias(3) = 31 : Dias(4) = 30
            Dias(5) = 31 : Dias(6) = 30 : Dias(7) = 31 : Dias(8) = 31
            Dias(9) = 30 : Dias(10) = 31 : Dias(11) = 30 : Dias(12) = 31

            If Len(fecha) >= 18 Then ' Fecha formateada por el sistema, fecha mas hora dd/MM/yyyy 
                fecha = fecha.Substring(0, 10)
            End If
            If Len(fecha) = 10 Then
                F = Left(fecha, 2) + Mid(fecha, 4, 2) + Right(fecha, 4)
            ElseIf Len(fecha) = 8 Then
                F = fecha
            ElseIf Len(fecha) = 6 Then
                If Val(Right(fecha, 2)) < 50 Then
                    Milenio = "20"
                Else
                    Milenio = "19"
                End If
                F = Left(fecha, 2) + Mid(fecha, 3, 2) + Milenio + Right(fecha, 2)
            ElseIf Len(fecha) = 4 Then
                F = Left(fecha, 2) + Mid(fecha, 3, 2) + Left(Year(Now).ToString, 4)
            ElseIf Len(fecha) = 2 Then
                F = Left(fecha, 2) + Format(Month(Now), "00") + Left(Year(Now).ToString, 4)
            Else
                F = ""
            End If

            If F = "" Then
                FnFecha = ""
                Exit Function
            End If

            D = CInt(Val(Left(F, 2)))
            M = CInt(Val(Mid(F, 3, 2)))
            If M < 1 Or M > 12 Then
                FnFecha = ""
                Exit Function
            End If

            If M = 2 Then
                If Val(Right(F, 2)) Mod 4 = 0 Then
                    Dias(2) = 29
                End If
            End If

            If D < 1 Or D > Dias(M) Then
                FnFecha = ""
                Exit Function
            End If

            If dfecha <> "" Then
                If IsDate(dfecha) = True Then
                    If VaDate(FnF8(F)) < VaDate(dfecha) Then
                        MsgBox("Fecha inferior a " + dfecha)
                        FnFecha = ""
                        Exit Function

                    End If
                End If
            End If

            If hfecha <> "" Then
                If IsDate(hfecha) = True Then
                    If VaDate(FnF8(F)) > VaDate(hfecha) Then
                        MsgBox("Fecha superior a " + hfecha)
                        FnFecha = ""
                        Exit Function
                    End If
                End If
            End If

            FnFecha = F
        Catch ex As Exception
            err.Muestraerror("No se pudo devolver la fecha " & fecha, "Function FnFecha(ByVal fecha As String) As String", ex.Message)
            Return ""
        End Try

    End Function



    Public Function FnHora(ByVal hora As String) As String

        Dim res As String = ""

        Try

            Dim HH As String = "00"
            Dim mm As String = "00"
            Dim ss As String = "00"

            hora = Replace(hora, ":", "")


            Select Case hora.Trim.Length
                Case 2
                    HH = VaInt(hora).ToString("00")
                Case 4
                    HH = VaInt(hora.Substring(0, 2)).ToString("00")
                    mm = VaInt(hora.Substring(2, 2)).ToString("00")
                Case 6
                    HH = VaInt(hora.Substring(0, 2)).ToString("00")
                    mm = VaInt(hora.Substring(2, 2)).ToString("00")
                    ss = VaInt(hora.Substring(4, 2)).ToString("00")
                Case Else
                    res = ""
            End Select


            If HH = "24" Then HH = "00"

            If HH >= 24 Or mm > 59 Or ss > 59 Then
                res = ""
            Else
                res = HH & mm & ss
            End If


        Catch ex As Exception
            err.Muestraerror("No se pudo devolver la hora " & hora, "Function FnHora", ex.Message)
            Return ""
        End Try


        Return res

    End Function



    ''' <summary>
    ''' completa con ceros por la derecha hasta la longitud indicada
    ''' </summary>
    ''' <param name="dato"></param>
    ''' <param name="lg"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Fnc0Der(ByVal dato As String, ByVal lg As Integer) As String
        Dim ret As String = dato.Trim
        While ret.Length < lg
            ret = ret & "0"
        End While
        Return ret
    End Function

    ''' <summary>
    ''' completa con ceros por la izquierda hasta la longitud indicada
    ''' </summary>
    ''' <param name="DATO"></param>
    ''' <param name="L"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Fnc0Izq(ByVal dato As String, ByVal l As Integer) As String
        Return Fnc0(dato, l)
    End Function

    ''' <summary>
    ''' formatea dato a la longitud dada por l mediante ceros, ej: format("310", 5) = "00310"
    ''' </summary>
    ''' <param name="DATO"></param>
    ''' <param name="L"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Fnc0(ByVal dato As String, ByVal l As Integer) As String
        Return Microsoft.VisualBasic.Right(FnString(l, "0") + StInt(VaInt(dato)), l)
    End Function

    ''' <summary>
    ''' convierte dato en una cuenta de once digitos valida, si no lo es
    ''' </summary>
    ''' <param name="dato"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FnCuenta11(ByVal dato As String) As String
        Dim ret As String = dato.Trim
        Select Case Len(dato)
            Case Is > 11
                ret = FnLeft(dato, 11)
            Case 11
                ret = dato
            Case 9
                ret = FnLeft(dato, 4) & "00" & FnRight(dato, 5)
            Case Is > 6
                ret = FnLeft(dato, 6) + Fnc0(Mid(dato, 7), 5)
            Case Is <= 6
                ret = FnLeft(dato + FnString(11, "0"), 11)
        End Select
        Return ret
    End Function

    Public Function FnCuentaCliente(ByVal dato As String) As String
        Dim ret As String = dato
        Dim ce As String = "00"
        If MiMaletin.IdCentro = 7 Then
            ce = "07"
        End If
        Select Case Len(dato)
            Case Is <= 5
                ret = "4300" + ce + Fnc0(dato, 5)
            Case Else
                ret = FnCuenta11(dato)
        End Select
        Return ret
    End Function
    '

    Public Function FnCuentaCliente(ByVal dato As String, centro As Integer) As String
        Dim ret As String = dato
        Dim ce As String = "00"
        If centro = 7 Then
            ce = "07"
        End If
        Select Case Len(dato)
            Case Is <= 5
                ret = "4300" + ce + Fnc0(dato, 5)
            Case Else
                ret = FnCuenta11(dato)
        End Select
        Return ret
    End Function


    ''' <summary>
    ''' conversion de cuentas de 9 a 11 digitos, SOLO para ctas a 9 digts en VB6
    ''' </summary>
    ''' <param name="cta9"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FnCtasCostaNET(ByVal cta9 As String) As String

        Dim ret As String = cta9.Trim
        If ret.Length = 9 Then
            Dim parte1 As String = FnLeft(ret, 4)
            Dim parte2 As String = ret.Trim.Substring(4, 1)
            Dim parte3 As String = FnRight(ret, 4)
            ret = parte1 & "0" & parte2 & "0" & parte3
        Else
            ret = ""
        End If
        Return ret

    End Function

    ''' <summary>
    ''' devuelve la parte derecha de la cadena -trimpeada- pasada
    ''' </summary>
    ''' <param name="dato"></param>
    ''' <param name="chrs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FnRight(ByVal dato As String, ByVal chrs As Integer) As String
        Dim ret As String = dato.Trim
        If chrs <= ret.Length Then ret = ret.Substring(ret.Length - chrs)
        Return ret
    End Function

    ''' <summary>
    '''  devuelve la parte izquiera de la cadena -trimpeada- pasada
    ''' </summary>
    ''' <param name="dato"></param>
    ''' <param name="chrs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FnLeft(ByVal dato As String, ByVal chrs As Integer) As String
        Dim ret As String = dato.Trim
        If chrs <= ret.Length Then ret = ret.Substring(0, chrs)
        Return ret
    End Function

    ''' <summary>
    '''  devuelve la fecha actual en formato string del tipo DD/MM/YYYY
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FnFechaHoy() As String
        Return Fnc0(Now.Day, 2) & "/" & Fnc0(Now.Month, 2) & "/" & Fnc0(Now.Year, 4)
    End Function

    ''' <summary>
    ''' devuelve un Date (fecha) a partir de un String(8) con una fecha válida
    ''' </summary>
    ''' <param name="fecha"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FnFechaDevuelveFecha(ByVal fecha As String) As Date

        Try
            Dim f As String = ""
            Dim Dias(12) As Integer

            If fecha = "" Then
                FnFechaDevuelveFecha = VaDate("01/01/1900")
                Exit Function
            End If

            Dias(1) = 31 : Dias(2) = 28 : Dias(3) = 31 : Dias(4) = 30
            Dias(5) = 31 : Dias(6) = 30 : Dias(7) = 31 : Dias(8) = 31
            Dias(9) = 30 : Dias(10) = 31 : Dias(11) = 30 : Dias(12) = 31

            If Len(fecha) = 8 Then
                f = fecha.Substring(0, 2) & "/" & fecha.Substring(2, 2) & "/" & fecha.Substring(4, 4)
            End If

            Return VaDate(f)
        Catch ex As Exception
            err.Muestraerror("No se pudo devolver la fecha " & fecha, "Function FnFecha(ByVal fecha As String) As String", ex.Message)
            Return VaDate("01/01/1900")
        End Try

    End Function

    ''' <summary>
    ''' recibe un string fecha y lo formatéa (añade las barras) para devolver otro string fecha;
    '''  la fecha que recibimos puede venir invertida; fechas tipo DDMMYYYY o YYYYMMDD
    ''' </summary>
    ''' <param name="fecha"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FnF8(ByVal fecha As String, Optional ByVal inv As Boolean = False) As String
        Dim ret As String = fecha.Trim
        If ret.Length <> 8 Then Return ret
        If inv = True Then ret = FnFechaInversa(ret)
        ret = FnLeft(ret, 2) & "/" & ret.Substring(2, 2) & "/" & FnRight(ret, 4)
        Return ret
    End Function

    Public Function Fnv1(fecha As String) As String

        'ddmmyyyy ---> yyyymmdd

        Dim ret As String = ""

        If Len(fecha) = 8 Then
            ret = Mid(fecha, 5, 4) + Mid(fecha, 3, 2) + Mid(fecha, 1, 2)
        End If

        Return ret


    End Function


    Public Function Fnv2(fecha As String) As String

        ' yyyymmdd -----> ddmmyyyy

        Dim ret As String = ""

        If Len(fecha) = 8 Then
            ret = Mid(fecha, 7, 2) + Mid(fecha, 5, 2) + Mid(fecha, 1, 4)
        End If

        Return ret


    End Function


    ''' <summary>
    ''' invierte un string fecha del tipo YYYYMMDD o YYYY/MM/DD para devolver DDMMYYYY
    ''' </summary>
    ''' <param name="fecha"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FnFechaInversa(ByVal fecha As String) As String

        Try
            Dim F As String
            Dim Milenio As String
            Dim Dias(12) As Integer

            Dim D As Integer
            Dim M As Integer

            If fecha.Contains("/") Then
                fecha = fecha.Replace("/", "")
            End If

            If fecha = "" Then
                Return ""
                Exit Function
            Else
                Dim ano As String = fecha.Substring(0, 4)
                Dim mes As String = fecha.Substring(4, 2)
                Dim dia As String = fecha.Substring(6, 2)
                fecha = dia & mes & ano
            End If

            Dias(1) = 31 : Dias(2) = 28 : Dias(3) = 31 : Dias(4) = 30
            Dias(5) = 31 : Dias(6) = 30 : Dias(7) = 31 : Dias(8) = 31
            Dias(9) = 30 : Dias(10) = 31 : Dias(11) = 30 : Dias(12) = 31

            If Len(fecha) >= 18 Then ' Fecha formateada por el sistema, fecha mas hora dd/MM/yyyy 
                fecha = fecha.Substring(0, 10)
            End If

            If Len(fecha) = 10 Then
                F = Left(fecha, 2) + Mid(fecha, 4, 2) + Right(fecha, 4)
            ElseIf Len(fecha) = 8 Then
                F = fecha
            ElseIf Len(fecha) = 6 Then
                If Val(Right(fecha, 2)) < 50 Then
                    Milenio = "20"
                Else
                    Milenio = "19"
                End If
                F = Left(fecha, 2) + Mid(fecha, 3, 2) + Milenio + Right(fecha, 2)
            ElseIf Len(fecha) = 4 Then
                F = Left(fecha, 2) + Mid(fecha, 3, 2) + Left(Year(Now).ToString, 4)
            ElseIf Len(fecha) = 2 Then
                F = Left(fecha, 2) + Format(Month(Now), "00") + Left(Year(Now).ToString, 4)
            Else
                F = ""
            End If

            If F = "" Then
                Return ""
                Exit Function
            End If

            D = CInt(Val(Left(F, 2)))
            M = CInt(Val(Mid(F, 3, 2)))
            If M < 1 Or M > 12 Then
                Return ""
                Exit Function
            End If

            If M = 2 Then
                If Val(Right(F, 2)) Mod 4 = 0 Then
                    Dias(2) = 29
                End If
            End If

            If D < 1 Or D > Dias(M) Then
                Return ""
                Exit Function
            End If

            Return F
        Catch ex As Exception
            err.Muestraerror("No se pudo devolver la fecha " & fecha, "Function FnFecha(ByVal fecha As String) As String", ex.Message)
            Return ""
        End Try

    End Function

    ''' <summary>
    ''' recibe un String(8) con una fecha válida y lo devuelve invertido
    ''' </summary>
    ''' <param name="fecha"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PonFechaAlReves(ByVal fecha As String) As String

        Try
            If fecha = "" Then
                Return ""
                Exit Function
            Else
                If fecha.Contains("/") Then
                    fecha = fecha.Replace("/", "")
                End If
                Dim ano As String = fecha.Substring(4, 4)
                Dim mes As String = fecha.Substring(2, 2)
                Dim dia As String = fecha.Substring(0, 2)
                fecha = ano & mes & dia
            End If

            Return fecha
        Catch ex As Exception
            err.Muestraerror("No se pudo devolver la fecha " & fecha, "Function FnFecha(ByVal fecha As String) As String", ex.Message)
            Return ""
        End Try

    End Function

    ''' <summary>
    ''' recibe un Date y devuelve un String(8) con una fecha invertida
    ''' </summary>
    ''' <param name="fech"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PonFechaAlReves(ByVal fech As Date) As String

        Dim fecha As String = ""
        Try
            fecha = StDate(fech)
            fecha = fecha.Replace("/", "")
            If fecha = "" Then
                Return ""
                Exit Function
            Else
                Dim ano As String = fecha.Substring(4, 4)
                Dim mes As String = fecha.Substring(2, 2)
                Dim dia As String = fecha.Substring(0, 2)
                fecha = ano & mes & dia
            End If

            Return fecha
        Catch ex As Exception
            err.Muestraerror("No se pudo devolver la fecha " & fecha, "Function FnFecha(ByVal fecha As String) As String", ex.Message)
            Return ""
        End Try

    End Function

    ''' <summary>
    ''' formatea un decimal y lo devuelve como string para utilizar en inserts o updates
    ''' </summary>
    ''' <param name="numero"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FnDecToSql(ByVal numero As Decimal) As String
        Dim ret As String = ""
        ret = FnVaDec(numero).ToString
        ret = ret.Replace(".", "")
        ret = ret.Replace(",", ".")
        Return ret
    End Function

#End Region

#Region "Varias"

    Public Function FnIban(CCC As String, Cta As String, Optional sg As String = "ES") As String

        'CCC = CCC.Trim
        'Cta = Cta.Trim
        'sg = sg.Trim

        Dim cod1 As String = ""
        Dim cod2 As String = ""
        Dim Resto As Long = 0
        Dim Nume As Object = Nothing
        Dim Div As Integer = 0

        cod1 = sg & "0000" & CCC & Cta
        cod2 = Mid(cod1, 5) & DigitosPais(Left(cod1, 2)) & "00"
        Nume = CDec(cod2)
        Div = 97

        Resto = Nume - (Int(Nume / Div) * Div)
        FnIban = sg & Fnc0(FnVaStr(98 - Resto), 2) & CCC & Cta

    End Function


    Public Function FnVaStr(Cantidad As String) As String

        Dim B As String
        Dim d As Double

        If Cantidad = "" Then
            FnVaStr = ""
            Exit Function
        End If

        d = Math.Round(VaDec(Cantidad), 8)
        B = CStr(d)
        If Left(B, 1) = " " Then
            B = Mid(B, 2)
        End If

        FnVaStr = B

    End Function


    Private Function DigitosPais(Pais As String) As String

        Dim D1 As String
        Dim D2 As String

        D1 = Left(Pais, 1)
        D2 = Mid(Pais, 2)

        DigitosPais = LetraNumero(D1) & LetraNumero(D2)

    End Function


    Private Function LetraNumero(Letra As String) As String

        Dim dg As String = ""

        Select Case UCase(Letra)

            Case "A" : dg = "10"
            Case "B" : dg = "11"
            Case "C" : dg = "12"
            Case "D" : dg = "13"
            Case "E" : dg = "14"
            Case "F" : dg = "15"
            Case "G" : dg = "16"
            Case "H" : dg = "17"
            Case "I" : dg = "18"
            Case "J" : dg = "19"
            Case "K" : dg = "20"
            Case "L" : dg = "21"
            Case "M" : dg = "22"
            Case "N" : dg = "23"
            Case "O" : dg = "24"
            Case "P" : dg = "25"
            Case "Q" : dg = "26"
            Case "R" : dg = "27"
            Case "S" : dg = "28"
            Case "T" : dg = "29"
            Case "U" : dg = "30"
            Case "V" : dg = "31"
            Case "W" : dg = "32"
            Case "X" : dg = "33"
            Case "Y" : dg = "34"
            Case "Z" : dg = "35"

        End Select

        LetraNumero = dg

    End Function


    Public Function FnFinMes(mes As Integer, año As Integer) As Integer

        Dim resultado As Integer = 31

        Select Case mes

            Case 2
                If VaDate("29/02" & año.ToString("0000")) <> VaDate("") Then
                    resultado = 29
                Else
                    resultado = 28
                End If

            Case 4, 6, 9, 11
                resultado = 30


        End Select


        Return resultado

    End Function

    Public Function FnFechaEnEjercicio(FechaTexto As String, IdEjercicio As String) As Boolean

        Dim bRes As Boolean = False
        Dim Fecha As Date = VaDate(FechaTexto)

        Dim Ejercicio As New E_Ejercicios(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        If Ejercicio.LeerId(IdEjercicio) Then

            Dim FechaDesde As Date = VaDate(Ejercicio.FechaTrabDesde.Valor)
            Dim FechaHasta As Date = VaDate(Ejercicio.FechaTrabHasta.Valor)

            If Fecha >= FechaDesde And Fecha <= FechaHasta Then
                bRes = True
            End If

        End If


        Return bRes

    End Function



    ''' <summary>
    ''' Cálculo del número de trimestre de una fecha dada
    ''' </summary>
    ''' <param name="Fecha"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FnTrimestre(ByVal Fecha As Date) As Integer

        Dim tri As Integer = 0

        If Fecha > VaDate("") Then

            Dim Mes As Integer = Fecha.Month

            If Mes >= 10 Then
                tri = 4
            ElseIf Mes >= 7 Then
                tri = 3
            ElseIf Mes >= 4 Then
                tri = 2
            Else
                tri = 1
            End If

        End If


        Return tri

    End Function




    Public Sub ObtenerSemana(ByRef FechaInicio As Date, ByRef FechaFinal As Date, Optional SemanasAtras As Integer = 0)

        Dim hoy As Date = DateAdd(DateInterval.Day, SemanasAtras * -7, Today)
        Dim dia_semana As DayOfWeek = hoy.DayOfWeek

        Select Case dia_semana

            Case DayOfWeek.Monday
                FechaInicio = hoy
                FechaFinal = DateAdd(DateInterval.Day, 6, hoy)
            Case DayOfWeek.Tuesday
                FechaInicio = DateAdd(DateInterval.Day, -1, hoy)
                FechaFinal = DateAdd(DateInterval.Day, 5, hoy)
            Case DayOfWeek.Wednesday
                FechaInicio = DateAdd(DateInterval.Day, -2, hoy)
                FechaFinal = DateAdd(DateInterval.Day, 4, hoy)
            Case DayOfWeek.Thursday
                FechaInicio = DateAdd(DateInterval.Day, -3, hoy)
                FechaFinal = DateAdd(DateInterval.Day, 3, hoy)
            Case DayOfWeek.Friday
                FechaInicio = DateAdd(DateInterval.Day, -4, hoy)
                FechaFinal = DateAdd(DateInterval.Day, 2, hoy)
            Case DayOfWeek.Saturday
                FechaInicio = DateAdd(DateInterval.Day, -5, hoy)
                FechaFinal = DateAdd(DateInterval.Day, 1, hoy)
            Case DayOfWeek.Sunday
                FechaInicio = DateAdd(DateInterval.Day, -6, hoy)
                FechaFinal = hoy

        End Select

    End Sub


    Public Sub ObtenerSemana(ByVal Fecha As Date, ByRef FechaInicio As Date, ByRef FechaFinal As Date)

        'Dim hoy As Date = DateAdd(DateInterval.Day, SemanasAtras * -7, Fecha)
        Dim dia_semana As DayOfWeek = Fecha.DayOfWeek

        Select Case dia_semana

            Case DayOfWeek.Monday
                FechaInicio = Fecha
                FechaFinal = DateAdd(DateInterval.Day, 6, Fecha)
            Case DayOfWeek.Tuesday
                FechaInicio = DateAdd(DateInterval.Day, -1, Fecha)
                FechaFinal = DateAdd(DateInterval.Day, 5, Fecha)
            Case DayOfWeek.Wednesday
                FechaInicio = DateAdd(DateInterval.Day, -2, Fecha)
                FechaFinal = DateAdd(DateInterval.Day, 4, Fecha)
            Case DayOfWeek.Thursday
                FechaInicio = DateAdd(DateInterval.Day, -3, Fecha)
                FechaFinal = DateAdd(DateInterval.Day, 3, Fecha)
            Case DayOfWeek.Friday
                FechaInicio = DateAdd(DateInterval.Day, -4, Fecha)
                FechaFinal = DateAdd(DateInterval.Day, 2, Fecha)
            Case DayOfWeek.Saturday
                FechaInicio = DateAdd(DateInterval.Day, -5, Fecha)
                FechaFinal = DateAdd(DateInterval.Day, 1, Fecha)
            Case DayOfWeek.Sunday
                FechaInicio = DateAdd(DateInterval.Day, -6, Fecha)
                FechaFinal = Fecha

        End Select

    End Sub



    ''' <summary>
    ''' Devuelve el nombre del mes según el número del mes
    ''' </summary>
    ''' <param name="numero_mes"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function NombreMes(numero_mes As Integer)

        Dim mes As String = ""

        Dim Meses As String() = {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}

        If numero_mes <= 12 And numero_mes >= 1 Then
            mes = Meses(numero_mes)
        End If


        Return mes

    End Function


    ' division fina y segura (sin alas)
    Public Function FnDiv(dividendo As Decimal, divisor As Decimal) As Decimal
        Dim ret As Decimal

        ret = 0
        If divisor <> 0 Then ret = dividendo / divisor
        FnDiv = ret

    End Function

    Public Sub AñadeResumenCampo(ByRef GridView1 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal NombreColumna As String, ByVal Formato As String, Optional ByVal Tipo As DevExpress.Data.SummaryItemType = DevExpress.Data.SummaryItemType.Sum)

        Try

            If Not IsNothing(GridView1.Columns.ColumnByFieldName(NombreColumna)) Then

                Dim columna As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName(NombreColumna)

                columna.SummaryItem.DisplayFormat = Formato
                columna.SummaryItem.SummaryType = Tipo
                columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

                Dim item As New DevExpress.XtraGrid.GridGroupSummaryItem
                item.FieldName = columna.FieldName
                item.SummaryType = Tipo
                item.DisplayFormat = Formato
                item.ShowInGroupColumnFooter = columna
                GridView1.GroupSummary.Add(item)
                GridView1.UpdateSummary()

                GridView1.OptionsView.ShowFooter = True
                GridView1.OptionsView.ShowGroupedColumns = True

            End If

        Catch ex As Exception
            err.Muestraerror("Error al aplicar el resumen del campo " & NombreColumna, "AñadeResumenCampo", ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' en general con una lista de las impresoras es suficiente; la primera será siempre 
    ''' la impresora por defecto del sistema
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListaImpresorasDelSistema() As List(Of String)

        Dim lst As New List(Of String)

        lst.Clear()
        Dim impresoras As Dictionary(Of String, String) = DiccionarioImpresorasDelSistema()
        For Each key As String In impresoras.Keys
            If key = "default" Then
                lst.Insert(0, impresoras.Item(key))
            Else
                lst.Add(impresoras.Item(key))
            End If
        Next

        Return lst

    End Function
    ''' <summary>
    '''  devolvemos un diccionario con las impresoras en el sistema, indicando si es la impresora por defecto
    ''' ver ListaImpresorasDelSistema para otro método de carga de dichas impresoras
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DiccionarioImpresorasDelSistema() As Dictionary(Of String, String)

        Dim idx As Integer = 0
        Dim impresoras As New Dictionary(Of String, String)

        Try
            impresoras.Clear()

            Dim impDefecto As New System.Drawing.Printing.PrinterSettings
            Dim impdef As New System.Drawing.Printing.PrintDocument
            impDefecto = impdef.PrinterSettings

            For Each impresora As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
                If impresora.ToLower = impDefecto.PrinterName.ToLower Then
                    impresoras.Add("default", impresora)
                Else
                    impresoras.Add("imp" & idx.ToString, impresora)
                    idx = idx + 1
                End If
            Next
        Catch ex As Exception
            impresoras.Add("default", "Error al cargar las impresoras del sistema")
        End Try

        Return impresoras

    End Function

    ' ''' <summary>
    ' ''' devuelve una conexión del tipo Cdatos construida a partir de la 
    ' ''' conexión AlhondiBdXX activa donde sustituimos XX por la campaña pasada
    ' ''' </summary>
    ' ''' <param name="newCp"></param>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public Function ConexAlhCampa(ByVal newCp As String) As Cdatos.Conexion

    '    Const cALHONDIBD_NAME As String = "AlhondiBd"

    '    ' conexion AlhondiBd actual
    '    Dim cadcon As String = CnAlhondi.CadenaConexion

    '    ' campaña de la conexion AlhondiBd actual
    '    Dim actCp As String = cadcon.Substring(cadcon.IndexOf(cALHONDIBD_NAME, StringComparison.InvariantCultureIgnoreCase) + cALHONDIBD_NAME.Length, 2)

    '    Dim newCon As String = ""

    '    If newCp <= "05" Then
    '        ' nueva conexion AlhondiBd con la campaña pasada
    '        newCon = Replace(cadcon, cALHONDIBD_NAME & actCp, cALHONDIBD_NAME, , , CompareMethod.Text)
    '    Else
    '        ' nueva conexion AlhondiBd con la campaña pasada
    '        newCon = Replace(cadcon, cALHONDIBD_NAME & actCp, cALHONDIBD_NAME & newCp, , , CompareMethod.Text)
    '    End If



    '    ' nuevo objeto de la clase conexion con la campaña pasada
    '    Dim miCn As New Cdatos.Conexion(newCon)

    '    Return miCn

    'End Function


    Public Function ObtenerBDConexion(conexion As Cdatos.Conexion) As String

        Dim res As String = ""


        Dim cadenaconexion As String = conexion.CadenaConexion
        Dim params As String() = Split(cadenaconexion, ";")

        For Each param As String In params
            If param.StartsWith("database=") Then

                Dim valor As String() = Split(param, "=")
                If valor.Length = 2 Then
                    res = valor(1)
                End If

            End If
        Next



        Return res

    End Function

#End Region


#Region "Programas Calidad"

    Public Function ObtenerNormasCalidad(ByVal IdPartidaLote As String, ByVal Tipo As String) As List(Of String)

        'PartidaLote -> Indicamos el Numero de partida o lote
        'Tipo -> Indicamos una 'P' para la partida o una 'L' para el lote

        Dim ListaNormas As New List(Of String)

        Dim Albentrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)

        If Tipo = "P" Then 'Partida

            If VaInt(IdPartidaLote) > 0 Then


                Dim sql As String = "SELECT NCL_Nombre as Norma" & vbCrLf
                sql = sql & " FROM TecnicosNet.dbo.NormasCalidad" & vbCrLf
                sql = sql & " LEFT JOIN TecnicosNet.dbo.CalidadNorma ON NCL_IdNorma = CAN_IdNorma" & vbCrLf
                sql = sql & " LEFT JOIN TecnicosNet.dbo.ProgramasCalidad ON CAN_IdPrograma = PCL_IdPrograma" & vbCrLf
                sql = sql & " LEFT JOIN NetAgroComer.dbo.Albentrada_lineas ON PCL_IdPrograma = AEL_IdPrograma" & vbCrLf
                sql = sql & " WHERE AEL_IdLinea = " & IdPartidaLote
                sql = sql & " ORDER BY NCL_Nombre"


                Dim dt As DataTable = Albentrada_Lineas.MiConexion.ConsultaSQL(sql)

                If Not IsNothing(dt) Then

                    If dt.Rows.Count > 0 Then

                        For Each row In dt.Rows

                            Dim Norma As String = (row("Norma").ToString() & "").Trim

                            ListaNormas.Add(Norma)

                        Next

                    End If

                End If


            End If

        ElseIf Tipo = "L" Then 'Lote


            Dim sql As String = "SELECT DISTINCT NCL_Nombre as Norma" & vbCrLf
            sql = sql & " FROM TecnicosNet.dbo.NormasCalidad" & vbCrLf
            sql = sql & " LEFT JOIN TecnicosNet.dbo.CalidadNorma ON NCL_IdNorma = CAN_IdNorma" & vbCrLf
            sql = sql & " LEFT JOIN TecnicosNet.dbo.ProgramasCalidad ON CAN_IdPrograma = PCL_IdPrograma" & vbCrLf
            sql = sql & " LEFT JOIN NetAgroComer.dbo.Albentrada_lineas ON PCL_IdPrograma = AEL_IdPrograma" & vbCrLf
            sql = sql & " LEFT JOIN NetAgroComer.dbo.Lotes_lineas ON LTL_Idlineaentrada = AEL_IdLinea" & vbCrLf
            sql = sql & " WHERE LTL_Idlote = " & IdPartidaLote
            sql = sql & " ORDER BY NCL_Nombre"

            Dim dt As DataTable = Albentrada_Lineas.MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then

                If dt.Rows.Count > 0 Then

                    For Each row In dt.Rows

                        Dim Norma As String = (row("Norma").ToString() & "").Trim

                        ListaNormas.Add(Norma)

                    Next

                End If

            End If


        End If


        Return ListaNormas

    End Function


    Public Function NormasProgramaCalidad(ByVal IdPrograma As Integer) As String

        Dim ProgramasCalidad As New E_ProgramasCalidad(Idusuario, cnFincasNET)

        Dim NormasSTR As String = ""

        Dim sql As String = "SELECT DISTINCT NCL_Nombre as Norma" & vbCrLf
        sql = sql & " FROM TecnicosNet.dbo.NormasCalidad" & vbCrLf
        sql = sql & " LEFT JOIN TecnicosNet.dbo.CalidadNorma ON NCL_IdNorma = CAN_IdNorma" & vbCrLf
        sql = sql & " WHERE CAN_IdPrograma = " & IdPrograma.ToString()
        sql = sql & " ORDER BY NCL_Nombre"


        Dim dt As DataTable = ProgramasCalidad.MiConexion.ConsultaSQL(sql)


        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                For Each row In dt.Rows

                    If NormasSTR <> "" Then
                        NormasSTR = NormasSTR & ", "
                    End If

                    NormasSTR = NormasSTR & (row("Norma").ToString() & "").Trim.ToUpper

                Next

            End If
        End If
    

        Return NormasSTR

    End Function




#End Region



End Module
