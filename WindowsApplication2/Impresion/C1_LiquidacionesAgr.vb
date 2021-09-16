Imports System.Drawing
Imports DevExpress.XtraEditors

Module C1_LiquidacionesAgr


    Private margen_izquierdo As Integer = 20
    Dim ancho_linea As Decimal = 2
    Dim Pie_linea As Integer = 282

    Dim altura_impreso As Integer = 88



    Public Sub C1_ImprimirLiquidacionAgr(ByVal Impreso As Impreso, ByVal IdLiquidacion As String, ByVal tipoImpresion As TipoImpresion, Ejemplar As String,
                                            Optional ByVal impresora As String = "",
                                            Optional ByVal rutaPDF As String = "",
                                            Optional ByVal archivoPDF As String = "")


        If IsNothing(Impreso) Then
            Impreso = C1_AñadeLiquidacionAgr(IdLiquidacion, Ejemplar, tipoImpresion, "", 0)
        End If


        Try

            'Impresión / previsualización / exportación
            Select Case tipoImpresion

                Case NetAgro.TipoImpresion.Preliminar
                    Impreso.Imprimir(tipoImpresion, impresora, rutaPDF, archivoPDF)

                Case NetAgro.TipoImpresion.ExportacionPDF
                    Impreso.Imprimir(tipoImpresion, impresora, rutaPDF, archivoPDF)

                Case NetAgro.TipoImpresion.ImpresoraSeleccionada
                    Impreso.Imprimir(tipoImpresion, impresora)

                Case Else

                    Dim valoresusuario As New E_valoresusuario(Idusuario, cn)

                    If valoresusuario.LeerId(Idusuario) Then
                        impresora = valoresusuario.VUS_ImpresoraLiquidaciones.Valor
                        Impreso.Imprimir(NetAgro.TipoImpresion.ImpresoraSeleccionada, impresora, rutaPDF, archivoPDF)
                    Else
                        Impreso.Imprimir(tipoImpresion, impresora, rutaPDF, archivoPDF)
                    End If

            End Select


        Catch ex As Exception

        End Try

        

    End Sub


    Public Function C1_AñadeLiquidacionAgr(ByVal IdLiquidacion As String, Ejemplar As String, TipoImpresion As TipoImpresion,
                                           ByVal xml_talon_pagare As String, ByVal NumTalon As Decimal) As Impreso



        Dim Impreso As New Impreso
        Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
        Impreso.f.documento.PageLayout.PageSettings.Landscape = False
        Impreso.f.documento.PageLayout.PageSettings.TopMargin = "10mm"
        Impreso.f.documento.PageLayout.PageSettings.LeftMargin = "10mm"
        Impreso.f.documento.PageLayout.PageSettings.BottomMargin = "10mm"

        Impreso.EstableceImpreso(TipoImpresion)



        Try

            Impreso.ForzarSaltoPagina = True


            Dim LiquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)
            Dim Compensacion As String = ""
            If LiquidacionAgr.LeerId(IdLiquidacion) Then


                Dim Agricultores As New E_Agricultores(Idusuario, cn)
                If Not Agricultores.LeerId(LiquidacionAgr.LIQ_Idagricultor.Valor) Then
                    MsgBox("Error al leer los datos del agricultor con Id: " & LiquidacionAgr.LIQ_Idagricultor.Valor)
                    Return Nothing
                End If

                Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)
                If TipoAgricultor.LeerId(Agricultores.AGR_IdTipo.Valor) = True Then
                    Compensacion = TipoAgricultor.TPA_compensa.Valor
                End If

                Dim TotalKilos As Decimal = 0
                Dim TotalImporte As Decimal = 0



                'Cabecera
                Dim BaseLineas As Integer = 0
                Dim altura As Integer = 7


                'Cabecera factura
                Dim Col As New List(Of Integer)
                Col.Add(0)
                Col.Add(margen_izquierdo)           'Col1
                Col.Add(Col(1) + 25 + 5)            'Col2
                Col.Add(Col(2) + 105 + 5)           'Col3



                Dim bLogo As Boolean = (xml_talon_pagare.Trim = "")



                'Imprime cabecera
                ImprimeCabeceraLiquidacionAgr(Impreso, altura, LiquidacionAgr, Agricultores, Col, BaseLineas, bLogo)


                'Imprimir detalle
                ImprimeDetalleLiquidacionAgr(Impreso, LiquidacionAgr, altura, BaseLineas, Col, Compensacion)


                'Talon
                ImprimeTalonPagareLiquidacionAgr(Impreso, xml_talon_pagare, IdLiquidacion, NumTalon)


                'Pie
                ImprimePieLiquidacionAgr(Impreso, Ejemplar, LiquidacionAgr)



            Else
                XtraMessageBox.Show("Error al leer la liquidacion con id: " & IdLiquidacion, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        Catch ex As Exception

        End Try



        Return Impreso


    End Function


    Private Sub ImprimeCabeceraLiquidacionAgr(ByRef Impreso As Impreso, ByRef altura As Integer,
                                              LiquidacionAgr As E_LiquidacionAgr, Agricultores As E_Agricultores,
                                              Col As List(Of Integer), ByRef BaseLineasDetalle As Integer,
                                              bLogo As Boolean)


        'Logo

        If bLogo Then

            Dim fichero_logo As String = "logo.png"

            Select Case VaInt(LiquidacionAgr.LIQ_idempresa.Valor)
                Case 0, 1
                    fichero_logo = "logo.png"
                Case Else
                    fichero_logo = "logo_" & LiquidacionAgr.LIQ_idempresa.Valor & "" & ".png"
            End Select


            If IO.File.Exists(Application.StartupPath & "\" & fichero_logo) Then

                Try

                    Dim logo As Image = Image.FromFile(Application.StartupPath & "\" & fichero_logo)
                    Dim w As Integer = Math.Round(logo.Width * 0.2646)
                    Dim h As Integer = Math.Round(logo.Height * 0.2646)
                    Impreso.Cabecera.Imagen(logo, margen_izquierdo, altura, w, h)

                Catch ex As Exception
                End Try

            End If

        End If





        'CONSULTA.WheCampo(Me.LIQ_idempresa, "=", idempresa.ToString)
        'CONSULTA.WheCampo(Me.LIQ_ejercicio, "=", Campa.ToString)
        'CONSULTA.WheCampo(Me.LIQ_serie, "=", Serie)
        'CONSULTA.WheCampo(Me.LIQ_numero, "=", Numero.ToString)


        Dim CB_IdEmpresa As String = VaInt(LiquidacionAgr.LIQ_idempresa.Valor)
        Dim CB_Ejercicio As String = VaInt(LiquidacionAgr.LIQ_ejercicio.Valor)
        Dim CB_Serie As String = (LiquidacionAgr.LIQ_serie.Valor & "").Trim
        Dim CB_Numero As String = (LiquidacionAgr.LIQ_numero.Valor & "").Trim


        'Código de barras
        Dim Code39 As New Font("C39HrP24DhTt", 42)
        Dim CodBar As String = "*LQ" & CB_IdEmpresa & "." & Fnc0(CB_Ejercicio, 2) & "." & CB_Serie & "." & CB_Numero & "*"
        Impreso.Cabecera.Titulo(CodBar, 10, 7, 190, 18, Estilos.Custom, ">", , Code39)





        altura = altura + 5


        'Periodo
        Dim FechaDesde As String = ""
        Dim FechaHasta As String = ""
        If VaDate(LiquidacionAgr.LIQ_DeFecha.Valor) > VaDate("") Then FechaDesde = VaDate(LiquidacionAgr.LIQ_DeFecha.Valor).ToString("dd/MM/yyyy")
        If VaDate(LiquidacionAgr.LIQ_Afecha.Valor) > VaDate("") Then FechaHasta = VaDate(LiquidacionAgr.LIQ_Afecha.Valor).ToString("dd/MM/yyyy")


        'Fecha Liquidación
        Dim FechaLiquidacion As String = " "
        If VaDate(LiquidacionAgr.LIQ_fecha.Valor) > VaDate("") Then FechaLiquidacion = VaDate(LiquidacionAgr.LIQ_fecha.Valor).ToString("dd/MM/yyyy")
        Dim Serie As String = (LiquidacionAgr.LIQ_serie.Valor & "").Trim
        Dim Numero As String = LiquidacionAgr.LIQ_numero.Valor & ""
        If Serie <> "" Then Numero = Serie & "-" & Numero


        'Datos Agricultor
        Dim Nombre As String = VaInt(Agricultores.AGR_IdAgricultor.Valor).ToString("0000") & " - " & Agricultores.AGR_Nombre.Valor
        Dim Domicilio As String = Agricultores.AGR_Domicilio.Valor & ""
        Dim Poblacion As String = Agricultores.AGR_Poblacion.Valor & ""
        Dim Provincia As String = Agricultores.AGR_Provincia.Valor & ""
        Dim NIF As String = Agricultores.AGR_Nif.Valor & ""


        altura = altura + 20
        Impreso.Cabecera.Titulo("RESUMEN DE LIQUIDACION", 100, altura, 90, 5, Estilos.GrandeBold)
        altura = altura + 5
        Impreso.Cabecera.Titulo("Periodo liquidación:", 100, altura, 45, 4, Estilos.NormalBold)
        Impreso.Cabecera.Titulo(FechaDesde, 100 + 40, altura, 30, 4, Estilos.NormalBold)
        altura = altura + 4
        ' Impreso.Cabecera.Titulo("al:", 20, altura, 25, 4, Estilos.NormalBold)
        Impreso.Cabecera.Titulo(FechaHasta, 100 + 40, altura, 25, 4, Estilos.NormalBold)
        altura = altura + 8
        Impreso.Cabecera.Titulo("Fecha Liquidación:", 100, altura, 45, 4, Estilos.NormalBold)
        Impreso.Cabecera.Titulo(FechaLiquidacion, 100 + 40, altura, 25, 4, Estilos.NormalBold)
        altura = altura + 4
        Impreso.Cabecera.Titulo("Número Liquidación:", 100, altura, 45, 4, Estilos.NormalBold)
        Impreso.Cabecera.Titulo(Numero, 100 + 40, altura, 30, 4, Estilos.NormalBold)

        altura = altura + 10

        Impreso.Cabecera.Titulo(Nombre, 100, altura, 110, 4, Estilos.NormalBold)
        altura = altura + 4
        Impreso.Cabecera.Titulo(Domicilio, 100, altura, 110, 4, Estilos.Normal)
        altura = altura + 4
        Impreso.Cabecera.Titulo(Poblacion, 100, altura, 110, 4, Estilos.Normal)
        altura = altura + 4
        Impreso.Cabecera.Titulo(Provincia, 100, altura, 110, 4, Estilos.Normal)
        altura = altura + 4
        Impreso.Cabecera.Titulo("N.I.F.: " & NIF, 100, altura, 110, 4, Estilos.Normal)
        altura = altura + 10


        Impreso.Cabecera.LineaH(margen_izquierdo, altura, 170, ancho_linea)
        altura = altura + 5
        Impreso.Cabecera.Titulo("FACTURA", Col(1), altura - 4, 25, 4, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo("CONCEPTO", Col(2), altura - 4, 105, 4, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo("IMPORTE", Col(3), altura - 4, 30, 4, Estilos.ReducidaBold, ">")
        Impreso.Cabecera.LineaH(margen_izquierdo, altura, 170, ancho_linea)
        altura = altura + 2



    End Sub


    Private Sub ImprimeDetalleLiquidacionAgr(ByRef Impreso As Impreso, LiquidacionAgr As E_LiquidacionAgr, ByRef altura As Integer, ByRef BaseLineas As Integer,
                                         ByVal Col As List(Of Integer), ByVal Compensacion As String)



        Dim sql As String = "SELECT FGR_IdFactura as IdFactura, FGR_IdSemana as IdSemana, SEV_Semana as Semana," & vbCrLf
        sql = sql & " FGR_Serie as Serie, FGR_numerofactur as Factura, FGR_totalfactura as Importe " & vbCrLf
        sql = sql & " FROM FacturaAgr " & vbCrLf
        sql = sql & " LEFT JOIN SemanasPartes ON FGR_IdSemana = SEV_IdSemana " & vbCrLf
        sql = sql & " LEFT JOIN LiquidacionAgr ON FGR_IdLiquidacion = LIQ_IdLiquidacion" & vbCrLf
        sql = sql & " WHERE FGR_idliquidacion = " & LiquidacionAgr.LIQ_Idliquidacion.Valor & vbCrLf
        sql = sql & " ORDER BY FGR_IdSemana" & vbCrLf




        Dim dt As DataTable = LiquidacionAgr.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then


            For Each row As DataRow In dt.Rows

                Dim Serie As String = (row("Serie").ToString & "").Trim
                Dim Factura As String = (row("Factura").ToString & "").Trim
                If Serie.Trim <> "" Then Factura = Serie & "-" & Factura


                Dim Semana As String = (row("Semana").ToString & "").Trim
                Dim Importe As Decimal = VaDec(row("Importe"))

                Impreso.Detalle.Titulo(Factura, Col(1) + 1, altura, 23, 4, Estilos.Reducida)
                Impreso.Detalle.Titulo("LIQUIDACION DE LA SEMANA " & Semana, Col(2) + 1, altura, 103, 4, Estilos.Reducida)
                Impreso.Detalle.Titulo(Importe.ToString("#,##0.00"), Col(3) + 1, altura, 28, 4, Estilos.Reducida, ">")
                altura = altura + 4


                Application.DoEvents()

            Next

        End If


        Dim TotalImporte As Decimal = VaDec(LiquidacionAgr.LIQ_ImpFacturas.Valor)
        Dim Anterior As Decimal = VaDec(LiquidacionAgr.LIQ_ImpAnterior.Valor)
        Dim saldo As Decimal = TotalImporte + Anterior

        Dim Anticipos As Decimal = -VaDec(LiquidacionAgr.LIQ_DtoAnticipos.Valor)
        Dim Suministros As Decimal = -VaDec(LiquidacionAgr.LIQ_DtoSumi.Valor)
        Dim PortesOtros As Decimal = -VaDec(LiquidacionAgr.LIQ_DtoPortes.Valor)
        Dim Dtos As Decimal = Anticipos + Suministros + PortesOtros
        Dim APagar As Decimal = VaDec(LiquidacionAgr.LIQ_Apagar.Valor)
        Dim Resultado As Decimal = saldo + Dtos


        altura = altura + 4
        Impreso.Detalle.Titulo("SALDO PENDIENTE ANTERIOR", Col(2) + 1, altura, 103, 4, Estilos.Reducida)
        Impreso.Detalle.Titulo(Anterior.ToString("#,##0.00"), Col(3) + 1, altura, 28, 4, Estilos.Reducida, ">")
        altura = altura + 3
        Impreso.Detalle.Titulo("---------------", Col(3) + 1, altura, 28, 4, Estilos.ReducidaBold, ">")
        altura = altura + 2
        Impreso.Detalle.Titulo("SALDO PENDIENTE A SU FAVOR", Col(2) + 1, altura, 103, 4, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo(saldo.ToString("#,##0.00"), Col(3) + 1, altura, 28, 4, Estilos.ReducidaBold, ">")
        altura = altura + 8
        Impreso.Detalle.Titulo("DESCUENTO DE ANTICIPOS", Col(2) + 1, altura, 103, 4, Estilos.Reducida)
        Impreso.Detalle.Titulo(Anticipos.ToString("#,##0.00"), Col(3) + 1, altura, 28, 4, Estilos.Reducida, ">")
        altura = altura + 4
        Impreso.Detalle.Titulo("DESCUENTO DE SUMINISTROS", Col(2) + 1, altura, 103, 4, Estilos.Reducida)
        Impreso.Detalle.Titulo(Suministros.ToString("#,##0.00"), Col(3) + 1, altura, 28, 4, Estilos.Reducida, ">")
        altura = altura + 4
        Impreso.Detalle.Titulo("DESCUENTO DE PORTES Y OTROS", Col(2) + 1, altura, 103, 4, Estilos.Reducida)
        Impreso.Detalle.Titulo(PortesOtros.ToString("#,##0.00"), Col(3) + 1, altura, 28, 4, Estilos.Reducida, ">")
        altura = altura + 3
        Impreso.Detalle.Titulo("---------------", Col(3) + 1, altura, 28, 4, Estilos.ReducidaBold, ">")
        altura = altura + 2
        Impreso.Detalle.Titulo("TOTAL DESCUENTOS", Col(2) + 1, altura, 103, 4, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo(Dtos.ToString("#,##0.00"), Col(3) + 1, altura, 28, 4, Estilos.ReducidaBold, ">")
        altura = altura + 12
        Impreso.Detalle.Titulo("IMPORTE NETO A LIQUIDAR", Col(2) + 1, altura, 103, 4, Estilos.NormalBold)
        Impreso.Detalle.Titulo(Resultado.ToString("#,##0.00"), Col(3) + 1, altura, 28, 4, Estilos.NormalBold, ">")

        altura = altura + 6

        If Compensacion = "S" Then
            Impreso.Detalle.Titulo("Acogido al Regimen Especial de Agricultura, Ganaderia y Pesca", margen_izquierdo, altura + 8, 170, 4, Estilos.Reducida)
        End If

        Impreso.Detalle.Titulo("RECIBI: ", margen_izquierdo + 15, altura, 170, 4, Estilos.Reducida, "=")
        altura = altura + 5
        Impreso.Cabecera.LineaH(margen_izquierdo, altura + 8, 170, ancho_linea)

        'altura = altura + 15
        'Impreso.Detalle.Titulo("RECIBI: ", margen_izquierdo, altura, 170, 4, Estilos.Reducida, "=")
        'altura = altura + 15
        'Impreso.Cabecera.LineaH(margen_izquierdo, altura, 170, ancho_linea)

        'If Compensacion = "S" Then
        '    altura = altura + 5
        '    Impreso.Detalle.Titulo("Acogido al Regimen Especial de Agricultura, Ganaderia y Pesca", margen_izquierdo, altura, 170, 4, Estilos.Reducida)
        'End If

        altura = 170 + 5

    End Sub


    Private Sub ImprimeTalonPagareLiquidacionAgr(ByRef Impreso As Impreso, ByVal xml_talon_pagare As String, ByVal IdLiquidacion As String, ByVal NumTalon As Decimal)


        If (xml_talon_pagare & "").Trim = "" Then
            Exit Sub
        End If


        'Impresión talón / pagaré 
        Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
        Dim ruta As String = Application.StartupPath & "\" & ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CARPETA_DOCUMENTOS_BANCARIOS) & "\"
        If IO.File.Exists(ruta & xml_talon_pagare) Then


            Dim dt As DataTable = ObtenerTablaTalones(IdLiquidacion, NumTalon)
            Dim doc As New DocumentoTalonXML(ruta & xml_talon_pagare, dt)

            Dim dtFormato As DataTable = doc.TablaFormato
            Dim dtOrigen As DataTable = doc.TablaOrigen


            Try

                Dim Dc As New Dictionary(Of String, Formato)

                If Not IsNothing(dtFormato) Then

                    For Each row As DataRow In dtFormato.Rows

                        Dim NombreCampo As String = (row("campo").ToString & "").Trim
                        Dim texto As String = (row("texto").ToString & "").Trim

                        Dim posicion As String = (row("posicion").ToString & "").Trim
                        Dim posX As Integer = 0
                        Dim posY As Integer = 0

                        Dim datos_posicion As String() = Split(posicion, ",")
                        If datos_posicion.Length > 0 Then posX = VaInt(datos_posicion(0))
                        If datos_posicion.Length > 1 Then posY = VaInt(datos_posicion(1))


                        Dim formato As String = (row("formato").ToString & "").Trim
                        Dim datos_formato As String() = Split(formato, ",")

                        Dim nombre_fuente As String = "Courier New"
                        Dim tamaño_fuente As Decimal = 9
                        Dim bNegrita As Boolean = False
                        Dim bCursiva As Boolean = False
                        Dim bSubrayado As Boolean = False

                        If datos_formato.Length > 0 Then nombre_fuente = datos_formato(0)
                        If datos_formato.Length > 1 Then tamaño_fuente = VaInt(datos_formato(1))
                        If datos_formato.Length > 2 Then bNegrita = ((datos_formato(2) & "").Trim = "S")
                        If datos_formato.Length > 3 Then bCursiva = ((datos_formato(3) & "").Trim = "S")
                        If datos_formato.Length > 4 Then bSubrayado = ((datos_formato(4) & "").Trim = "S")

                        Dim estilo_fuente As FontStyle
                        If bNegrita Then estilo_fuente = FontStyle.Bold
                        If bCursiva Then estilo_fuente = estilo_fuente Or FontStyle.Italic
                        If bSubrayado Then estilo_fuente = estilo_fuente Or FontStyle.Underline


                        Dim fuente As New Font(nombre_fuente, tamaño_fuente, estilo_fuente)

                        Dim textSize As Size = TextRenderer.MeasureText(texto, fuente)

                        Dim h As Integer = textSize.Height * 0.2646
                        Dim w As Integer = textSize.Width * 0.2646
                        w = w + 3

                        Dim mascara As String = (row("mascara").ToString & "").Trim


                        If NombreCampo.Trim <> "" Then
                            Dim f As New Formato(NombreCampo, texto, posX, posY, h, w, fuente, mascara)
                            Dc(NombreCampo) = f
                        Else

                            Impreso.Detalle.Titulo(texto, posX, posY, w, h, Estilos.Custom, , , fuente)
                        End If


                        Application.DoEvents()

                    Next
                End If


                Dim LiquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)



                'Imprime Detalle
                Dim cont As Integer = 0
                For Each row As DataRow In dtOrigen.Rows

                    For Each col As DataColumn In dtOrigen.Columns
                        If Dc.ContainsKey(col.ColumnName) Then

                            Dim texto As String = (row(col.ColumnName).ToString & "").Trim

                            Dim f As Formato = Dc(col.ColumnName)
                            If f.mascara.Trim <> "" Then texto = VaDec(texto).ToString(f.mascara)



                            Dim textSize As Size = TextRenderer.MeasureText(texto, f.fuente)
                            f.h = textSize.Height * 0.2646
                            f.w = textSize.Width * 0.2646
                            f.w = f.w + 6


                            Impreso.Detalle.Titulo(texto, f.x, f.y, f.w, f.h, Estilos.Custom, , , f.fuente)

                        End If

                        Application.DoEvents()

                    Next



                    If cont < dtOrigen.Rows.Count - 1 Then
                        Impreso.Detalle.SaltoPagina()
                    End If


                    cont = cont + 1

                    'Actualizo número de talón
                    If dtOrigen.Columns.Contains("IdLiquidacion") Then
                        Dim IdLiquidacion_Origen As String = (row("IdLiquidacion").ToString & "").Trim
                        If VaInt(IdLiquidacion_Origen) > 0 Then
                            If LiquidacionAgr.LeerId(IdLiquidacion_Origen) Then
                                Dim NumTalon_Origen As String = (row("NumeroTalon").ToString & "").Trim
                                LiquidacionAgr.LIQ_Nutalon.Valor = NumTalon_Origen
                                LiquidacionAgr.Actualizar()
                            End If
                        End If
                    End If

                    Application.DoEvents()

                Next



                'Imprimir
                'Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)


            Catch ex As Exception

            End Try

        End If


    End Sub



    Private Sub ImprimePieLiquidacionAgr(ByRef Impreso As Impreso, ByVal Ejemplar As String, ByVal Liquidacion As E_LiquidacionAgr)


        'Pie
        Impreso.Pie.Titulo(Ejemplar, margen_izquierdo, 275, 170, 7, Estilos.ReducidaBold, ">")


        'Datos empresa
        Dim IdEmpresa As String = (Liquidacion.LIQ_idempresa.Valor & "").Trim

        Dim Empresa As New E_Empresas(Idusuario, cn)
        If Empresa.LeerId(IdEmpresa) Then

            Dim domicilio As String = Empresa.EMP_Domicilio.Valor
            Dim cif As String = Empresa.EMP_CIF.Valor

            Impreso.Pie.LineaH(margen_izquierdo, 280, 170, ancho_linea)
            Impreso.Pie.Titulo(domicilio & " - C.I.F.: " & cif, margen_izquierdo, 281, 170, 3, Estilos.MinimaBold)

        End If


    End Sub




    Private Function CompruebaSaltoPagina(altura As Integer, altura_linea As Integer) As Boolean

        Dim bRes As Boolean = False

        If altura + altura_linea > Pie_linea Then
            bRes = True
        End If


        Return bRes

    End Function


    Public Function ObtenerTablaTalones(IdLiquidacion As String, ByRef NumTalon As Decimal) As DataTable

        Dim dt As New DataTable


        If VaInt(IdLiquidacion) > 0 Then


            Dim LiquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)
            If LiquidacionAgr.LeerId(IdLiquidacion) Then

                Dim Nombre As String = ""
                Dim Agricultores As New E_Agricultores(Idusuario, cn)
                If Agricultores.LeerId(LiquidacionAgr.LIQ_Idagricultor.Valor) Then
                    Nombre = Agricultores.AGR_Nombre.Valor
                End If


                dt.Columns.Add("IdLiquidacion", GetType(String))
                dt.Columns.Add("Nombre", GetType(String))
                dt.Columns.Add("Importe", GetType(String))
                dt.Columns.Add("NumletA", GetType(String))
                dt.Columns.Add("NumletB", GetType(String))
                dt.Columns.Add("Poblacion", GetType(String))
                dt.Columns.Add("DiaFin", GetType(String))
                dt.Columns.Add("MesFin", GetType(String))
                dt.Columns.Add("AnoFin", GetType(String))
                dt.Columns.Add("NumeroTalon", GetType(String))
                dt.Columns.Add("DiaPag", GetType(String))
                dt.Columns.Add("MesPag", GetType(String))
                dt.Columns.Add("AnoPag", GetType(String))


                Dim row As DataRow = dt.NewRow()
                row("IdLiquidacion") = IdLiquidacion
                row("Nombre") = Nombre
                row("Importe") = "# " & VaDec(LiquidacionAgr.LIQ_Apagar.Valor).ToString("#,##0.00") & " #"

                If VaDate(LiquidacionAgr.LIQ_fecha.Valor) > VaDate("") Then
                    Dim fecha As Date = VaDate(LiquidacionAgr.LIQ_fecha.Valor)
                    row("DiaFin") = NumLetra(fecha.Day, True, True)
                    row("MesFin") = NombreMes(fecha.Month)
                    row("AnoFin") = fecha.ToString("yyyy")
                End If

                If VaDate(LiquidacionAgr.LIQ_FechaVto.Valor) > VaDate("") Then
                    Dim fecha As Date = VaDate(LiquidacionAgr.LIQ_FechaVto.Valor)
                    row("DiaPag") = fecha.Day.ToString
                    row("MesPag") = NombreMes(fecha.Month)
                    row("AnoPag") = fecha.ToString("yyyy")
                End If

                Dim Importe As Decimal = VaDec(LiquidacionAgr.LIQ_Apagar.Valor)
                Dim Numlet As String = NumLetra(Importe, True, False, "Euros", "Céntimos")
                Dim Numlet1 As String = ""
                Dim Numlet2 As String = ""
                parte2Cadena(Numlet, Numlet1, Numlet2, 50)

                row("NumLetA") = Numlet1
                row("NumLetB") = Numlet2

                row("NumeroTalon") = NumTalon.ToString("#")
                NumTalon = NumTalon + 1


                dt.Rows.Add(row)

            Else
                MsgBox("Error al leer la liquidacion con id " & IdLiquidacion)
            End If


        End If


        Return dt

    End Function


End Module
