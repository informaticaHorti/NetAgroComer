Imports DevExpress.XtraEditors
Imports System.Drawing


Module C1_CartelonPartida

    Public Sub C1_ImprimirCartelonPartida(ByVal Idlineaalbentrada As String, TipoImpresion As TipoImpresion,
                                          Optional Impresora As String = "",
                                          Optional rutaPDF As String = "",
                                          Optional archivoPDF As String = "")

        If VaInt(Idlineaalbentrada) > 0 Then



            Dim ConfiguracionesDiversas As New E_ConfiguracionesDiversas(Idusuario, cn)
            Dim papel = ConfiguracionesDiversas.xDameValor(E_ConfiguracionesDiversas.eClaves.FORMATO_PAPEL_ENTRADAS, MiMaletin.IdPuntoVenta)

            Dim Impreso As New Impreso

            If papel = "A5" Then
                Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A5
                Impreso.f.documento.PageLayout.PageSettings.Landscape = False
            Else
                Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
                Impreso.f.documento.PageLayout.PageSettings.Landscape = True
            End If


            Impreso.f.documento.PageLayout.PageSettings.TopMargin = "0mm"
            Impreso.f.documento.PageLayout.PageSettings.BottomMargin = "0mm"
            Impreso.f.documento.PageLayout.PageSettings.LeftMargin = "0mm"
            Impreso.f.documento.PageLayout.PageSettings.RightMargin = "0mm"

            Impreso.EstableceImpreso(TipoImpresion)


            Try

                ImprimeCartelonPartida(Idlineaalbentrada, Impreso)


                'Impresión / previsualización / exportación
                Dim valoresusuario As New E_valoresusuario(Idusuario, cn)
                If valoresusuario.LeerId(Idusuario) = True Then

                    If papel = "A5" Then

                        'Distribuir la impresión según la partida es controlada o no 
                        Dim AlbEntrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
                        If AlbEntrada_lineas.LeerId(Idlineaalbentrada) Then
                            Impresora = valoresusuario.VUS_ImpresoraPartidaNoControlada.Valor
                        End If

                    Else
                        'Imprime como hasta ahora
                        Impresora = valoresusuario.VUS_ImpresoraMuestreo.Valor
                    End If


                End If

                If Impresora.Trim = "" Then
                    Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)
                Else
                    Impreso.Imprimir(TipoImpresion.ImpresoraSeleccionada, Impresora, rutaPDF, archivoPDF)
                End If


            Catch ex As Exception
            End Try


        End If

    End Sub


    Public Sub ImprimeCartelonPartida(ByVal IdLineaAlbEntrada As String, ByVal Cartelon As Impreso)


        Dim TextoError As String = ""
        Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)



        Dim sql As String = "SELECT GEN_Abreviacion as Genero, VAR_Nombre as Variedad, AEN_Fecha as Fecha, AEL_Palets as Palets, AEL_KilosNetos as Kilos, PCT_Nombre as ProgramaCalidad" & vbCrLf
        sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEN_IdAlbaran = AEL_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = AEL_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN TecnicosNet.dbo.Cultivos ON CUL_IdCultivo = AEL_IdCultivo" & vbCrLf
        sql = sql & " LEFT JOIN TecnicosNet.dbo.Variedades ON VAR_IdVariedad = CUL_IdVariedad" & vbCrLf
        sql = sql & " LEFT JOIN ProgramaCalidadTecnicos ON PCT_IdPrograma = AEL_IdPrograma" & vbCrLf
        sql = sql & " WHERE AEL_IdLinea = " & IdLineaAlbEntrada & vbCrLf


        Dim dt As DataTable = AlbEntrada_Lineas.MiConexion.ConsultaSQL(sql)


        If dt.Rows.Count > 0 Then


            Dim margen_izquierdo As Integer = 4


            Dim row As DataRow = dt.Rows(0)
            Dim Genero As String = (row("Genero").ToString & "").Trim
            Dim Variedad As String = (row("Variedad").ToString & "").Trim
            Dim Fecha As String = "" : If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd-MM")
            Dim Palets As String = "Nº Palets: " & VaInt(row("Palets")).ToString
            Dim Kilos As String = "KILOS: " & VaDec(row("Kilos")).ToString("#,##0") & " Kg"
            Dim ProgramaCalidad As String = (row("ProgramaCalidad").ToString & "").Trim


            'Definimos las zonas de impresión de cada rectánculo
            'Dim r1 As New Rectangle(5, 30, 138, 19) : Dim fuente1 As Font = CalculaFuente(r1, Genero)
            'Dim r2 As New Rectangle(5, 53, 138, 21) : Dim fuente2 As Font = CalculaFuente(r2, Variedad)
            'Dim r3 As New Rectangle(5, 78, 138, 27) : Dim fuente3 As Font = CalculaFuente(r3, Fecha)
            'Dim r4 As New Rectangle(5, 109, 138, 19) : Dim fuente4 As Font = CalculaFuente(r4, Palets)
            'Dim r5 As New Rectangle(5, 132, 138, 14) : Dim fuente5 As Font = CalculaFuente(r5, Kilos)
            'Dim r6 As New Rectangle(5, 148, 138, 58) : Dim fuente6 As Font = CalculaFuente(r6, ProgramaCalidad)

            Dim r1 As New Rectangle(5, 30, 138, 19) : Dim fuente1 As New Font("Verdana", 10, FontStyle.Bold)
            Dim r2 As New Rectangle(5, 53, 138, 21) : Dim fuente2 As New Font("Verdana", 10, FontStyle.Bold)
            Dim r3 As New Rectangle(5, 78, 138, 27) : Dim fuente3 As New Font("Verdana", 10, FontStyle.Bold)
            Dim r4 As New Rectangle(5, 109, 138, 19) : Dim fuente4 As New Font("Verdana", 10, FontStyle.Bold)
            Dim r5 As New Rectangle(5, 132, 138, 14) : Dim fuente5 As New Font("Verdana", 10, FontStyle.Bold)
            Dim r6 As New Rectangle(5, 148, 138, 58) : Dim fuente6 As New Font("Verdana", 10, FontStyle.Bold)




            Cartelon.Detalle.Titulo(Genero, r1.X, r1.Y, r1.Width, r1.Height, Estilos.Custom, "<", , fuente1, , , r1)
            Cartelon.Detalle.Titulo(Variedad, r2.X, r2.Y, r2.Width, r2.Height, Estilos.Custom, "<", , fuente2, , , r2)
            Cartelon.Detalle.Titulo(Fecha, r3.X, r3.Y, r3.Width, r3.Height, Estilos.Custom, "<", , fuente3, , , r3)
            Cartelon.Detalle.Titulo(Palets, r4.X, r4.Y, r4.Width, r4.Height, Estilos.Custom, "<", , fuente4, , , r4)
            Cartelon.Detalle.Titulo(Kilos, r5.X, r5.Y, r5.Width, r5.Height, Estilos.Custom, "<", , fuente5, , , r5)
            Cartelon.Detalle.Titulo(ProgramaCalidad, r6.X, r6.Y, r6.Width, r6.Height, Estilos.Custom, "=", , fuente6, , , r6)


          

        Else
            TextoError = "Imposible leer la partida con Id " & IdLineaAlbEntrada
        End If


        If TextoError.Trim <> "" Then
            XtraMessageBox.Show(TextoError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub




End Module
