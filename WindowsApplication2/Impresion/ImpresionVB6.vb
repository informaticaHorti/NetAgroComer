Module ImpresionVB6


    Public Const TablillaAlhondiga As String = "T"
    Public Const TablillaNormalizado As String = "N"


    Public Sub VB6_ImprimirAlbaranFactoring(ByVal IdAlbaran As String)

        NetAgroPrint("O", IdAlbaran & ";" & Idusuario.ToString)

    End Sub


    'Public Sub VB6_ImprimirTicketPalet(ByVal IdPalet As String, TipoImpresion As TipoImpresion, bCopia As Boolean, Impresora As String, rutaPDF As String, archivoPDF As String)

    '    If ImpresionDirectaVB6.Trim.ToUpper = "S" Then
    '        NetAgroPrint("P", IdPalet & ";" & Idusuario.ToString)
    '    Else
    '        ImprimirTicketPalet(IdPalet, TipoImpresion, bCopia, Impresora, rutaPDF, archivoPDF)
    '    End If

    'End Sub


    'Public Sub VB6_ImprimirCMREnvases(IdVale As String)

    '    PrintVB6("L", IdVale)

    'End Sub


    'Public Sub VB6_ImprimirFacturaComercializacion(ByVal IdFactura As String, TipoImpresion As TipoImpresion, bCopia As Boolean, Impresora As String, rutaPDF As String, archivoPDF As String, bDirecta As Boolean)

    '    If ImpresionDirectaVB6.Trim.ToUpper = "S" Then
    '        If bDirecta Then
    '            PrintVB6("K", IdFactura & ";" & Idusuario.ToString)
    '        Else
    '            PrintVB6("J", IdFactura & ";" & Idusuario.ToString)
    '        End If

    '    Else
    '        ImprimirFacturaComercializacion(IdFactura, TipoImpresion, bCopia, Impresora, rutaPDF, archivoPDF)
    '    End If

    'End Sub


    'Public Sub VB6_ImprimirAlbaranSalida(ByVal IdAlbaran As String, TipoImpresion As TipoImpresion, bCopia As Boolean, Impresora As String, rutaPDF As String, archivoPDF As String)

    '    If ImpresionDirectaVB6.Trim.ToUpper = "S" Then
    '        'PrintVB6("I", IdAlbaran & ";" & Idusuario.ToString)
    '        NetAgroPrint("I", IdAlbaran & ";" & Idusuario.ToString)
    '    Else
    '        ImprimirAlbaranSalida(IdAlbaran, TipoImpresion, bCopia, Impresora, rutaPDF, archivoPDF)
    '    End If

    'End Sub


    'Public Sub VB6_ImprimirValeEnvasesTraspaso(IdVale As String)

    '    If ImpresionDirectaVB6.Trim.ToUpper = "S" Then
    '        PrintVB6("V", IdVale)
    '    End If

    'End Sub





    Public Sub VB6_ImprimirAlbaranFactura(FBD As String, Id As String, Optional bDialogoImpresion As Boolean = True,
                                          Optional TipoImpresion As TipoImpresion = TipoImpresion.ImpresoraPorDefecto,
                                          Optional bCopia As Boolean = False, Optional Impresora As String = "",
                                          Optional rutaPDF As String = "", Optional archivoPDF As String = "")

        If ImpresionDirectaVB6.Trim.ToUpper = "S" Then
            PrintVB6(FBD, Id & ";" & Idusuario.ToString)
        Else

            Dim AF As String = ""
            Select Case FBD
                Case "F"
                    AF = "F"
                Case "A"
                    AF = "A"
                Case "D"
                    AF = "F"
                    TipoImpresion = NetAgro.TipoImpresion.ImpresoraPorDefecto
            End Select

            ' ImprimirAlbaranFactura(AF, Id.ToString, TipoImpresion, bCopia, Impresora, rutaPDF, archivoPDF)
        End If

    End Sub


    'Public Sub VB6_ImprimirValeEnvases(IdVale As String, Optional NumDev As String = "")

    '    If ImpresionDirectaVB6.Trim.ToUpper = "S" Then
    '        PrintVB6("E", IdVale)
    '    Else
    '        ImprimirValeEnvases(IdVale, False, NumDev)
    '    End If

    'End Sub


    'Public Sub VB6_ImprimirValeGastosEntrada(IdAlbaran As String)

    '    If ImpresionDirectaVB6.Trim.ToUpper = "S" Then

    '        Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)


    '        Dim Total As Decimal = 0

    '        Dim sql As String = "SELECT  " & vbCrLf
    '        sql = sql & " (SELECT SUM(AEL_Bultos) FROM AlbEntrada_Lineas as Bultos WHERE AEL_IdAlbaran = AEG_IdAlbaran) as Bultos," & vbCrLf
    '        sql = sql & " (SELECT SUM(AEL_KilosNetos) FROM AlbEntrada_Lineas as Kilos WHERE AEL_IdAlbaran = AEG_IdAlbaran) as Kilos," & vbCrLf
    '        sql = sql & " (SELECT SUM(AEL_Palets) FROM AlbEntrada_Lineas as Palets WHERE AEL_IdAlbaran = AEG_IdAlbaran) as Palets," & vbCrLf
    '        sql = sql & " AEG_tipo AS tipo, AEG_gasto AS valor" & vbCrLf
    '        sql = sql & " FROM albentrada_gastos" & vbCrLf
    '        sql = sql & " LEFT JOIN AlbEntrada ON AEG_IdAlbaran = AEN_IdAlbaran" & vbCrLf
    '        sql = sql & " LEFT JOIN TiposDeGastosAgri ON TGA_IdTipoGasto = AEG_IdGasto" & vbCrLf
    '        sql = sql & " WHERE AlbEntrada_gastos.AEG_IdAlbaran = " & IdAlbaran & vbCrLf
    '        sql = sql & " AND COALESCE(AEG_IdAcreedor, 0) > 0" & vbCrLf
    '        sql = sql & " AND COALESCE(TGA_ImprimirEnEntrada,'N') = 'S'" & vbCrLf

    '        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)

    '        If Not IsNothing(dt) Then

    '            For Each row As DataRow In dt.Rows

    '                Dim Tipo As String = (row("Tipo").ToString & "").ToUpper.Trim

    '                Select Case Tipo

    '                    Case "K"
    '                        Dim nKilos As Decimal = VaDec(row("Kilos"))
    '                        Dim Precio As Decimal = VaDec(row("Valor"))
    '                        Total = Total + (nKilos * Precio)

    '                    Case "B"
    '                        Dim nBultos As Decimal = VaDec(row("Bultos"))
    '                        Dim Precio As Decimal = VaDec(row("Valor"))
    '                        Total = Total + (nBultos * Precio)

    '                    Case "P"
    '                        Dim nPalets As Decimal = VaDec(row("Palets"))
    '                        Dim Precio As Decimal = VaDec(row("Valor"))
    '                        Total = Total + (nPalets * Precio)

    '                    Case "I"
    '                        Total = VaDec(row("Valor"))

    '                End Select

    '            Next

    '        End If




    '        'Sólo imprime si tiene gastos!
    '        If Total <> 0 Then
    '            PrintVB6("G", IdAlbaran)
    '        End If


    '    Else
    '        ImprimirValeGastosEntrada(IdAlbaran, TipoImpresion.ImpresoraPorDefecto, "", "", "")
    '    End If

    'End Sub


    'Public Sub VB6_ImprimirAlbaranMedianero(IdAlbaran As String)

    '    If ImpresionDirectaVB6.Trim.ToUpper = "S" Then

    '        Dim AlbEntrada_His As New E_AlbEntrada_his(Idusuario, cn)


    '        Dim Consulta1 As New Cdatos.E_select
    '        Consulta1.SelCampo(AlbEntrada_His.AEH_id, "id")
    '        Consulta1.WheCampo(AlbEntrada_His.AEH_idalbaran, "=", IdAlbaran)
    '        Dim dt As DataTable = AlbEntrada_His.MiConexion.ConsultaSQL(Consulta1.SQL)

    '        If Not IsNothing(dt) Then

    '            For Each row As DataRow In dt.Rows
    '                Dim IdAlbHis As String = (row("Id").ToString & "").Trim
    '                PrintVB6("A", IdAlbHis)
    '            Next

    '        End If

    '    Else
    '        C1_ImprimirAlbaranMedianero(IdAlbaran, False, False)
    '    End If


    'End Sub


    'Public Sub VB6_ImprimirTicketsPartida(IdLinea As String, TipoTablilla As String)


    '    If TipoTablilla = TablillaAlhondiga Or TipoTablilla = TablillaNormalizado Then
    '    Else
    '        MsgBox("Tipo de tablilla erróneo")
    '    End If

    '    If ImpresionDirectaVB6.Trim.ToUpper = "S" Then
    '        PrintVB6(TipoTablilla, IdLinea)
    '    Else
    '        ImprimirTicketsPartida(IdLinea, False, False)
    '    End If


    'End Sub


    Public Sub PrintVB6(Tipo As String, Id As String)

        Dim print_exe As String = Application.StartupPath & "\printVB6.exe " & Tipo & ";" & Id
        Shell(print_exe, AppWinStyle.NormalFocus, True)

    End Sub


    Public Sub NetAgroPrint(Tipo As String, Id As String)

        Dim print_exe As String = Application.StartupPath & "\NetAgroPrint.exe " & Tipo & ";" & Id
        Shell(print_exe, AppWinStyle.NormalFocus, True)

    End Sub

End Module
