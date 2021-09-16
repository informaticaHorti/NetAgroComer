Imports System.Drawing


Module C1_HojaTransferencia


    Dim Pie_linea As Integer = 240


    Public Function C1_AñadeHojaTransferencia(lstLiquidaciones As List(Of String), IdBanco As String, FechaEmision As String, bCopiaAgricultor As Boolean, TipoImpresion As TipoImpresion) As Impreso

        Dim Impreso As Impreso = Nothing


        Dim margen_izquierdo As Integer = 15
        Dim fuente_fecha As New Font("Times New Roman", 10, FontStyle.Italic)
        Dim fuente As New Font("Times New Roman", 12)
        Dim fuente_negrita As New Font("Times New Roman", 12, FontStyle.Bold)
        Dim fuente_negrita_subrayada As New Font("Times New Roman", 12, FontStyle.Bold Or FontStyle.Underline)
        Dim fuente_detalle As New Font("Arial", 9)
        Dim fuente_detalle_negrita As New Font("Arial", 9, FontStyle.Bold)



        Dim Bancos As New E_Bancos(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))

        If VaInt(IdBanco) > 0 Then

            If Bancos.LeerId(IdBanco) Then

                Dim NumeroCuenta As String = FormateaNumeroCuenta((Bancos.Numerocuenta.Valor & "").Trim)


                Impreso = New Impreso

                Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
                Impreso.f.documento.PageLayout.PageSettings.Landscape = False
                Impreso.f.documento.PageLayout.PageSettings.TopMargin = "10mm"
                Impreso.f.documento.PageLayout.PageSettings.LeftMargin = "10mm"
                Impreso.f.documento.PageLayout.PageSettings.BottomMargin = "10mm"

                Impreso.EstableceImpreso(TipoImpresion)




                'Logo
                Dim fichero_logo As String = "logo.png"
                Dim IdEmpresa As String = MiMaletin.IdEmpresaCTB.ToString

                Select Case VaInt(IdEmpresa)
                    Case 0, 1
                        fichero_logo = "logo.png"
                    Case Else
                        fichero_logo = "logo_" & IdEmpresa & ".png"
                End Select


                If IO.File.Exists(Application.StartupPath & "\" & fichero_logo) Then

                    Try

                        Dim logo As Image = Image.FromFile(Application.StartupPath & "\" & fichero_logo)
                        Dim w As Integer = Math.Round(logo.Width * 0.2646)
                        Dim h As Integer = Math.Round(logo.Height * 0.2646)
                        Impreso.Cabecera.Imagen(logo, margen_izquierdo, 7, w, h)

                    Catch ex As Exception
                    End Try

                End If





                'Cabecera
                Dim fecha As Date = VaDate(FechaEmision)
                Impreso.Detalle.Titulo("El Parador, " & fecha.ToString("dd") & " de " & fecha.ToString("MMMM") & " del " & fecha.ToString("yyyy"), 129, 65, 60, 4, Estilos.Custom, ">", , fuente_fecha)
                Impreso.Detalle.Titulo("ASUNTO:", margen_izquierdo, 77, 20, 6, Estilos.Custom, , , fuente_negrita)
                Impreso.Detalle.Titulo("Domiciliación de pago de hortalizas.", margen_izquierdo + 20, 77, 100, 6, Estilos.Custom, , , fuente)
                Impreso.Detalle.Titulo("Muy Sres. nuestros:", margen_izquierdo, 92, 50, 6, Estilos.Custom, , , fuente)

                Dim texto1 As String = "Les rogamos que con cargo a nuestra cuenta Nº " & NumeroCuenta
                Dim texto2 As String = "abonen, a los agricultores que seguidamente les relacionamos y que tienen domiciliado el pago"
                Dim texto3 As String = "de la liquidación de hortalizas."

                Impreso.Detalle.Titulo(texto1, margen_izquierdo + 28, 104, 142, 6, Estilos.Custom, , , fuente)
                Impreso.Detalle.Titulo(texto2, margen_izquierdo, 110, 170, 6, Estilos.Custom, , , fuente)
                Impreso.Detalle.Titulo(texto3, margen_izquierdo, 116, 170, 6, Estilos.Custom, , , fuente)


                'Cabecera del detalle
                Dim Col As New List(Of Integer)
                For indice As Integer = 0 To 5
                    Col.Add(0)
                Next

                Col(0) = 0
                Col(1) = margen_izquierdo
                Col(2) = Col(1) + 25
                Col(3) = Col(2) + 50
                Col(4) = Col(3) + 25
                Col(5) = Col(4) + 50


                Impreso.Detalle.Titulo("DNI", Col(1), 128, 25, 6, Estilos.Custom, "=", , fuente_negrita_subrayada)
                Impreso.Detalle.Titulo("NOMBRE", Col(2), 128, 50, 6, Estilos.Custom, "=", , fuente_negrita_subrayada)
                Impreso.Detalle.Titulo("Nº LIQ.", Col(3), 128, 25, 6, Estilos.Custom, "=", , fuente_negrita_subrayada)
                Impreso.Detalle.Titulo("CUENTA", Col(4), 128, 50, 6, Estilos.Custom, "=", , fuente_negrita_subrayada)
                Impreso.Detalle.Titulo("IMPORTE", Col(5), 128, 30, 6, Estilos.Custom, ">", , fuente_negrita_subrayada)




                'Detalle
                Dim Agricultores As New E_Agricultores(Idusuario, cn)
                Dim LiquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)
                Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
                Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)

                Dim total As Decimal = 0


                Dim altura As Integer = 140
                Dim altura_linea As Integer = 6

                Dim lstSemanas As New List(Of Integer)


                For Each IdLiquidacion As String In lstLiquidaciones

                    Dim CONSULTA As New Cdatos.E_select
                    CONSULTA.SelCampo(LiquidacionAgr.LIQ_Idliquidacion, "IdLiquidacion")
                    CONSULTA.SelCampo(Agricultores.AGR_Nif, "NIF", LiquidacionAgr.LIQ_Idagricultor, Agricultores.AGR_IdAgricultor)
                    CONSULTA.SelCampo(Agricultores.AGR_Nombre, "Agricultor")
                    CONSULTA.SelCampo(LiquidacionAgr.LIQ_serie, "Serie")
                    CONSULTA.SelCampo(LiquidacionAgr.LIQ_numero, "Liquidacion")
                    CONSULTA.SelCampo(Agricultores.AGR_IBAN, "IBAN")
                    CONSULTA.SelCampo(LiquidacionAgr.LIQ_Apagar, "Importe")
                    CONSULTA.WheCampo(LiquidacionAgr.LIQ_Idliquidacion, "=", IdLiquidacion)

                    Dim dt As DataTable = LiquidacionAgr.MiConexion.ConsultaSQL(CONSULTA.SQL)
                    If Not IsNothing(dt) Then
                        If dt.Rows.Count > 0 Then

                            Dim row As DataRow = dt.Rows(0)

                            Dim NIF As String = (row("NIF").ToString & "").Trim
                            Dim Agricultor As String = (row("Agricultor").ToString & "").Trim
                            Dim Serie As String = (row("Serie").ToString & "").Trim
                            Dim Liquidacion As String = (row("Liquidacion").ToString & "").Trim : If Serie <> "" Then Liquidacion = Serie & "-" & Liquidacion
                            Dim IBAN As String = (row("IBAN").ToString & "").Trim
                            Dim Importe As Decimal = VaDec(row("Importe"))



                            'Semanas de la liquidación
                            Dim CONSULTA2 As New Cdatos.E_select
                            CONSULTA2.SelCampo(SemanasPartes.SEV_Semana, "Semana")
                            CONSULTA2.SelCampo(FacturaAgr.FGR_Idfactura, "IdFactura", SemanasPartes.SEV_IdSemana, FacturaAgr.FGR_Idsemana)
                            CONSULTA2.SelCampo(LiquidacionAgr.LIQ_Idliquidacion, "IdLiquidacion", FacturaAgr.FGR_IdLiquidacion, LiquidacionAgr.LIQ_Idliquidacion)
                            CONSULTA2.WheCampo(LiquidacionAgr.LIQ_Idliquidacion, "=", IdLiquidacion)


                            Dim sqlSemanas As String = CONSULTA2.SQL
                            Dim dtSemanas As DataTable = LiquidacionAgr.MiConexion.ConsultaSQL(sqlSemanas)
                            If Not IsNothing(dtSemanas) Then
                                For Each rowSemana As DataRow In dtSemanas.Rows

                                    Dim Semana As String = (rowSemana("Semana").ToString & "").Trim
                                    If Not lstSemanas.Contains(Semana) Then lstSemanas.Add(Semana)

                                Next
                            End If





                            total = total + Importe





                            If CompruebaSaltoPagina(altura, altura_linea) Then
                                Impreso.Detalle.SaltoPagina()
                                altura = 140
                            End If


                            'Imprime línea
                            Impreso.Detalle.Titulo(NIF, Col(1) + 1, altura, 23, altura_linea, Estilos.Custom, , , fuente_detalle)
                            Impreso.Detalle.Titulo(Agricultor, Col(2) + 1, altura, 48, altura_linea, Estilos.Custom, , , fuente_detalle)
                            Impreso.Detalle.Titulo(Liquidacion, Col(3) + 1, altura, 23, altura_linea, Estilos.Custom, , , fuente_detalle)
                            Impreso.Detalle.Titulo(FormateaNumeroCuenta(IBAN), Col(4) + 1, altura, 48, altura_linea, Estilos.Custom, , , fuente_detalle)
                            Impreso.Detalle.Titulo(Importe.ToString("#,##0.00"), Col(5) + 1, altura, 28, altura_linea, Estilos.Custom, ">", , fuente_detalle)


                        End If
                    End If


                    altura = altura + altura_linea

                    Application.DoEvents()

                Next


                'Total
                Impreso.Detalle.Titulo("TOTAL", Col(4) + 1, altura, 48, altura_linea, Estilos.Custom, , , fuente_detalle_negrita)
                Impreso.Detalle.Titulo(total.ToString("#,##0.00"), Col(5) + 1, altura, 28, altura_linea, Estilos.Custom, ">", , fuente_detalle_negrita)
                Impreso.Detalle.LineaH(Col(4), altura + 4, 80, 1)


                'Pie
                If lstSemanas.Count > 0 Then

                    lstSemanas.Sort()

                    Dim semanas As String = ""
                    For indice As Integer = 0 To lstSemanas.Count - 1

                        Dim semana As Integer = lstSemanas(indice)

                        If semanas.Trim <> "" Then
                            If indice = lstSemanas.Count - 1 Then
                                semanas = semanas & " y "
                            Else
                                semanas = semanas & ", "
                            End If
                        End If
                        semanas = semanas & semana

                    Next


                    Dim textosemanas As String = "Estas liquidaciones corresponden a las semanas " & semanas & " de la presente campaña."
                    If lstSemanas.Count = 1 Then textosemanas = textosemanas.Replace("las semanas", "la semana")

                    Impreso.Detalle.Titulo("NOTA:", margen_izquierdo, 250, 15, 12, Estilos.Custom, , , fuente_negrita)
                    Impreso.Detalle.Titulo(textosemanas, margen_izquierdo + 16, 250, 180, 12, Estilos.Custom, , , fuente)

                    If bCopiaAgricultor Then
                        Impreso.Detalle.Titulo("COPIA PARA EL AGRICULTOR", margen_izquierdo, 270, 180, 12, Estilos.Reducida, ">")
                    End If


                End If


            End If

        End If



        Return Impreso

    End Function


    Private Function FormateaNumeroCuenta(NumeroCuenta As String) As String

        If NumeroCuenta.Length = 20 Then
            'Nº cuenta normal
            NumeroCuenta = NumeroCuenta.Substring(0, 4) & " " & NumeroCuenta.Substring(4, 4) & " " & NumeroCuenta.Substring(8, 2) & " " & NumeroCuenta.Substring(10, 4) & " " & NumeroCuenta.Substring(14, 6)
        ElseIf NumeroCuenta.Length = 24 Then
            NumeroCuenta = NumeroCuenta.Substring(0, 4) & " " & NumeroCuenta.Substring(4, 4) & " " & NumeroCuenta.Substring(8, 4) & " " & NumeroCuenta.Substring(12, 2) & " " & NumeroCuenta.Substring(14, 4) & " " & NumeroCuenta.Substring(18, 6)
        End If

        Return NumeroCuenta

    End Function


    Private Function CompruebaSaltoPagina(altura As Integer, altura_linea As Integer) As Boolean

        Dim bRes As Boolean = False

        If altura + altura_linea > Pie_linea Then
            bRes = True
        End If


        Return bRes

    End Function


End Module
