Imports System.Drawing
Imports DevExpress.XtraEditors

Module C1_FacturacionAgr


    Private margen_izquierdo As Integer = 9
    Dim ancho_linea As Decimal = 2
    Dim Pie_linea As Integer = 282

    Dim altura_impreso As Integer = 91



    Public Sub C1_ImprimirFacturaAgr(ByVal Impreso As Impreso, ByVal IdFactura As String, ByVal tipoImpresion As TipoImpresion, Ejemplar As String,
                                            Optional ByVal impresora As String = "",
                                            Optional ByVal rutaPDF As String = "",
                                            Optional ByVal archivoPDF As String = "")


        If IsNothing(Impreso) Then
            Impreso = C1_AñadeFacturaAgr(IdFactura, Ejemplar, tipoImpresion)
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


    Public Function C1_AñadeFacturaAgr(ByVal IdFactura As String, Ejemplar As String, TipoImpresion As TipoImpresion) As Impreso


        Dim Impreso As New Impreso
        Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
        Impreso.f.documento.PageLayout.PageSettings.Landscape = False
        Impreso.f.documento.PageLayout.PageSettings.TopMargin = "10mm"
        Impreso.f.documento.PageLayout.PageSettings.LeftMargin = "10mm"
        Impreso.f.documento.PageLayout.PageSettings.BottomMargin = "10mm"

        Impreso.EstableceImpreso(TipoImpresion)



        Try

            Impreso.ForzarSaltoPagina = True


            Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)
            Dim Compensacion As String = ""

            If FacturaAgr.LeerId(IdFactura) Then


                Dim Agricultores As New E_Agricultores(Idusuario, cn)
                If Not Agricultores.LeerId(FacturaAgr.FGR_Idagricultor.Valor) Then
                    MsgBox("Error al leer los datos del agricultor con Id: " & FacturaAgr.FGR_Idagricultor.Valor)
                    Return Nothing
                End If

                Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)
                If TipoAgricultor.LeerId(Agricultores.AGR_IdTipo.Valor) = True Then
                    Compensacion = TipoAgricultor.TPA_compensa.Valor
                End If


                Dim TotalKilos As Decimal = 0
                Dim TotalImporte As Decimal = 0


                'Datos Cabecera
                Dim DatosEmpresa As New DatosEmpresa


                'Cabecera
                Dim BaseLineas As Integer = 0
                Dim altura As Integer = 27


                'Cabecera factura
                Dim Col As New List(Of Integer)
                Col.Add(0)
                Col.Add(margen_izquierdo)   'Col1
                Col.Add(Col(1) + 70)        'Col2
                Col.Add(Col(2) + 40)        'Col3
                Col.Add(Col(3) + 20)        'Col4
                Col.Add(Col(4) + 20)        'Col5
                Col.Add(Col(5) + 30)        'Col6


                'Imprime cabecera
                ImprimeCabeceraFacturaAgr(Impreso, altura, FacturaAgr, Agricultores, DatosEmpresa, Col, BaseLineas)

                'Imprimir detalle
                ImprimeDetalleFacturaAgr(Impreso, IdFactura, altura, BaseLineas, Col, TotalKilos, TotalImporte)

                'Totales
                ImprimeTotalesFacturaAgr(Impreso, altura, FacturaAgr, Col, TotalKilos, TotalImporte, Compensacion)

                'Ejemplar
                ImprimePieFacturaAgr(Impreso, Ejemplar, FacturaAgr)


            Else
                XtraMessageBox.Show("Error al leer la factura con id: " & IdFactura, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return Nothing
            End If


        Catch ex As Exception

        End Try

        

        Return Impreso

    End Function



    Private Sub ImprimeCabeceraFacturaAgr(ByRef Impreso As Impreso, ByRef altura As Integer,
                                              FacturaAgr As E_FacturaAgr, Agricultores As E_Agricultores, DatosEmpresa As DatosEmpresa,
                                              Col As List(Of Integer), ByRef BaseLineasDetalle As Integer)



        'CONSULTA.WheCampo(Me.FGR_idempresa, "=", idempresa.ToString)
        'CONSULTA.WheCampo(Me.FGR_ejercicio, "=", Campa.ToString)
        'CONSULTA.WheCampo(Me.FGR_serie, "=", Serie)
        'CONSULTA.WheCampo(Me.FGR_numerofactura, "=", Factura.ToString)


        Dim CB_IdEmpresa As String = VaInt(FacturaAgr.FGR_idempresa.Valor)
        Dim CB_Ejercicio As String = VaInt(FacturaAgr.FGR_ejercicio.Valor)
        Dim CB_Serie As String = (FacturaAgr.FGR_serie.Valor & "").Trim
        Dim CB_NumeroFactura As String = (FacturaAgr.FGR_numerofactura.Valor & "").Trim


        'Código de barras
        Dim Code39 As New Font("C39HrP24DhTt", 42)
        Dim CodBar As String = "*FG" & CB_IdEmpresa & "." & Fnc0(CB_Ejercicio, 2) & "." & CB_Serie & "." & CB_NumeroFactura & "*"
        Impreso.Cabecera.Titulo(CodBar, 10, 7, 190, 18, Estilos.Custom, ">", , Code39)





        Dim bMayorista As Boolean = False

        Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)
        If TipoAgricultor.LeerId(Agricultores.AGR_IdTipo.Valor) Then
            bMayorista = ((TipoAgricultor.TPA_agrimayo.Valor & "").Trim.ToUpper = "M")
        End If



        Dim posAgr As Integer = margen_izquierdo
        If bMayorista Then
            posAgr = 100
        End If


        Dim altura_logo As Integer = altura
        Dim altura_agr As Integer = altura



      

        'Logo
        Dim fichero_logo As String = "logo.png"

        Select Case VaInt(FacturaAgr.FGR_idempresa.Valor)
            Case 0, 1
                fichero_logo = "logo.png"
            Case Else
                fichero_logo = "logo_" & FacturaAgr.FGR_idempresa.Valor & "" & ".png"
        End Select



        If IO.File.Exists(Application.StartupPath & "\" & fichero_logo) Then

            Try

                Dim logo As Image = Image.FromFile(Application.StartupPath & "\" & fichero_logo)
                Dim w As Integer = Math.Round(logo.Width * 0.2646)
                Dim h As Integer = Math.Round(logo.Height * 0.2646)

                If bMayorista Then
                    Impreso.Cabecera.Imagen(logo, margen_izquierdo, altura, w, h)
                Else
                    Impreso.Cabecera.Imagen(logo, 180 - w - 4, altura, w, h)
                End If

                altura_logo = altura + h + 5


            Catch ex As Exception
            End Try

        End If



        

        Dim Pais As String = ""
        If VaInt(Agricultores.AGR_IdPais.Valor) > 0 Then
            Dim Paises As New E_Paises(Idusuario, CnComun)
            If Paises.LeerId(Agricultores.AGR_IdPais.Valor) Then
                Pais = Paises.Nombre.Valor
            End If
        End If


        Impreso.Cabecera.Cuadro(posAgr, altura, 100, 32, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo(Agricultores.AGR_Nombre.Valor & "", posAgr + 5, altura + 1, 91, 5, Estilos.GrandeBold)
        Impreso.Cabecera.Titulo(Agricultores.AGR_Domicilio.Valor & "", posAgr + 5, altura + 7, 91, 5, Estilos.GrandeBold)
        Impreso.Cabecera.Titulo(Agricultores.AGR_Cpostal.Valor & " " & Agricultores.AGR_Poblacion.Valor & "", posAgr + 5, altura + 13, 91, 5, Estilos.GrandeBold)
        Impreso.Cabecera.Titulo(Agricultores.AGR_Provincia.Valor, posAgr + 5, altura + 19, 91, 5, Estilos.GrandeBold)
        Impreso.Cabecera.Titulo(Pais, posAgr + 5, altura + 25, 91, 5, Estilos.GrandeBold)

        altura_agr = altura + 32 + 5


        If altura_logo >= altura_agr Then
            altura = altura_logo
        Else
            altura = altura_agr
        End If




        'Fila datos factura

        Dim FechaFactura As String = ""
        If VaDate(FacturaAgr.FGR_fecha.Valor) > VaDate("") Then FechaFactura = VaDate(FacturaAgr.FGR_fecha.Valor).ToString("dd/MM/yyyy")


        Dim Semana As String = ""
        Dim Dfecha As String = ""
        Dim Afecha As String = ""
        Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
        If SemanasPartes.LeerId(FacturaAgr.FGR_Idsemana.Valor.ToString) Then
            Semana = SemanasPartes.SEV_Ano.Valor.ToString & "-" & SemanasPartes.SEV_Semana.Valor.ToString
            Dfecha = SemanasPartes.SEV_FechaInicialEntrada.Valor
            Afecha = SemanasPartes.SEV_FechaFinalEntrada.Valor
        End If


        Dim Serie As String = (FacturaAgr.FGR_serie.Valor & "").Trim
        Dim NumFactura As String = (FacturaAgr.FGR_numerofactura.Valor & "").Trim
        If Serie <> "" Then NumFactura = Serie & "-" & NumFactura

        Dim NumeroCuenta As String = "400000" & VaInt(Agricultores.AGR_IdAgricultor.Valor).ToString("00000")
        Dim NIF = Agricultores.AGR_Nif.Valor.ToString


        Impreso.Cabecera.Cuadro(margen_izquierdo, altura, 190, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaH(margen_izquierdo, altura + 5, 190, ancho_linea, Color.Black)
        ' Impreso.Cabecera.LineaV(margen_izquierdo + 70, altura, 10, ancho_linea, Color.Black)

        Impreso.Cabecera.Titulo("FACTURA", margen_izquierdo + 3, altura + 1, 26, 5, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo(NumFactura, margen_izquierdo + 3, altura + 6, 26, 5, Estilos.Reducida)
        Impreso.Cabecera.LineaV(margen_izquierdo + 30, altura, 10, ancho_linea, Color.Black)

        Impreso.Cabecera.Titulo("FECHA FRA.", margen_izquierdo + 32, altura + 1, 22, 5, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo(FechaFactura, margen_izquierdo + 30, altura + 6, 23, 5, Estilos.Reducida, "=")
        Impreso.Cabecera.LineaV(margen_izquierdo + 55, altura, 10, ancho_linea, Color.Black)

        Impreso.Cabecera.Titulo("SEMANA", margen_izquierdo + 55, altura + 1, 22, 5, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo(Semana, margen_izquierdo + 55, altura + 6, 22, 5, Estilos.Reducida, "=")
        Impreso.Cabecera.LineaV(margen_izquierdo + 80, altura, 10, ancho_linea, Color.Black)

        Impreso.Cabecera.Titulo("DE FECHA", margen_izquierdo + 80, altura + 1, 22, 5, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo(Dfecha, margen_izquierdo + 80, altura + 6, 22, 5, Estilos.Reducida, "=")
        Impreso.Cabecera.LineaV(margen_izquierdo + 103, altura, 10, ancho_linea, Color.Black)

        Impreso.Cabecera.Titulo("A FECHA", margen_izquierdo + 105, altura + 1, 22, 5, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo(Afecha, margen_izquierdo + 105, altura + 6, 22, 5, Estilos.Reducida, "=")
        Impreso.Cabecera.LineaV(margen_izquierdo + 128, altura, 10, ancho_linea, Color.Black)



        '  Impreso.Cabecera.Cuadro(margen_izquierdo + 100, altura, 80, 10, ancho_linea, Color.Black)
        '  Impreso.Cabecera.LineaH(margen_izquierdo + 100, altura + 5, 80, ancho_linea, Color.Black)
        '  Impreso.Cabecera.LineaV(margen_izquierdo + 100 + 30, altura, 10, ancho_linea, Color.Black)
        '  Impreso.Cabecera.LineaV(margen_izquierdo + 100 + 30 + 25, altura, 10, ancho_linea, Color.Black)

        Impreso.Cabecera.Titulo("Nº CUENTA", margen_izquierdo + 100 + 30 + 1, altura + 1, 23, 5, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo(NumeroCuenta, margen_izquierdo + 100 + 30 + 1, altura + 6, 22, 5, Estilos.Reducida)
        Impreso.Cabecera.LineaV(margen_izquierdo + 153, altura, 10, ancho_linea, Color.Black)

        Impreso.Cabecera.Titulo("N.I.F.", margen_izquierdo + 100 + 30 + 25 + 1, altura + 1, 23, 5, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo(NIF, margen_izquierdo + 100 + 30 + 25 + 1, altura + 6, 23, 5, Estilos.Reducida)

        altura = altura + 20


        'Solo le pasamos Col si queremos imprimir la cabecera del detalle
        If Not IsNothing(Col) Then

            'Guardo el principio del detalle para dibujar luego las lineas verticales laterales de la factura
            BaseLineasDetalle = altura

            Impreso.Cabecera.LineaH(margen_izquierdo, altura, 190, ancho_linea, Color.Black)
            Impreso.Cabecera.LineaH(margen_izquierdo, altura + 5, 190, ancho_linea, Color.Black)
            Impreso.Cabecera.Titulo("GENERO", Col(1) + 3, altura + 1, 25, 5, Estilos.ReducidaBold)
            Impreso.Cabecera.Titulo("CAT/CAL", Col(2) + 1, altura + 1, 25, 5, Estilos.ReducidaBold)
            Impreso.Cabecera.Titulo("KILOS", Col(3) + 1, altura + 1, 18, 5, Estilos.ReducidaBold, ">")
            Impreso.Cabecera.Titulo("PRECIO", Col(4) + 1, altura + 1, 18, 5, Estilos.ReducidaBold, ">")
            Impreso.Cabecera.Titulo("IMPORTE", Col(5) + 1, altura + 1, 28, 5, Estilos.ReducidaBold, ">")


            altura = altura + 5
            altura = altura + 2

        End If



    End Sub


    Private Sub ImprimeDetalleFacturaAgr(ByRef Impreso As Impreso, ByVal IdFactura As String, ByRef altura As Integer, ByRef BaseLineas As Integer,
                                         ByVal Col As List(Of Integer), ByRef TotalKilos As Decimal, ByRef TotalImporte As Decimal)


        TotalKilos = 0
        TotalImporte = 0


        Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)


        Dim sql As String = "SELECT FAL_IdGenero as IdGenero, GEN_NombreGenero as Genero, FAL_IdCategoria as IdCategoria, CAE_CategoriaCalibre as Categoria, " & vbCrLf
        sql = sql & " SUM(FAL_Kilos) as Kilos, SUM(FAL_Importe) as Importe, FAL_Precio as Precio" & vbCrLf
        sql = sql & " FROM FacturaAgr_lineas" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = FAL_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasEntrada ON CAE_Id = FAL_IdCategoria" & vbCrLf
        sql = sql & " WHERE FAL_IdFactura = " & IdFactura & vbCrLf
        sql = sql & " GROUP BY FAL_IdGenero, GEN_NombreGenero, FAL_IdCategoria, CAE_CategoriaCalibre, FAL_Precio" & vbCrLf
        sql = sql & " ORDER BY FAL_IdGenero" & vbCrLf


        Dim dt As DataTable = FacturaAgr.MiConexion.ConsultaSQL(sql)


        'Debug
        'Dim dt2 As DataTable = dt.Copy
        'For indice As Integer = 0 To 10
        '    dt2.Merge(dt)
        'Next
        'dt = dt2



        If Not IsNothing(dt) Then


            Dim TotalKilosGen As Decimal = 0
            Dim TotalImporteGen As Decimal = 0

            Dim AuxIdGenero As String = ""



            For Each row As DataRow In dt.Rows

                Dim IdGenero As String = (row("IdGenero").ToString & "").Trim
                Dim Genero As String = (row("Genero").ToString & "").Trim
                Dim Categoria As String = (row("Categoria").ToString & "").Trim
                Dim Precio As String = VaDec(row("Precio")).ToString("#,##0.0000")
                Dim Kilos As Decimal = VaDec(row("Kilos"))
                Dim Importe As Decimal = VaDec(row("Importe"))


                'Si cambia el género
                If IdGenero <> AuxIdGenero And AuxIdGenero <> "" Then

                    'Total producto
                    Impreso.Detalle.Titulo("Total Producto...", Col(1), altura, 90, 4, Estilos.Reducida, "=")
                    Impreso.Detalle.Titulo(TotalKilosGen.ToString("#,##0.00"), Col(3), altura, 19, 4, Estilos.Reducida, ">")
                    Impreso.Detalle.Titulo(TotalImporteGen.ToString("#,##0.00"), Col(5), altura, 29, 4, Estilos.Reducida, ">")
                    altura = altura + 8

                    TotalKilosGen = 0
                    TotalImporteGen = 0

                End If



                TotalKilos = TotalKilos + Kilos
                TotalImporte = TotalImporte + Importe

                TotalKilosGen = TotalKilosGen + Kilos
                TotalImporteGen = TotalImporteGen + Importe


                If CompruebaSaltoPagina(altura, 4) Then
                    Impreso.Detalle.LineaH(margen_izquierdo, altura, 190, ancho_linea, Color.Black)
                    Impreso.Detalle.LineaV(margen_izquierdo, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)
                    Impreso.Detalle.LineaV(margen_izquierdo + 190, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)
                    Impreso.Detalle.SaltoPagina()
                    altura = altura_impreso
                End If

                Impreso.Detalle.Titulo(Genero, Col(1) + 3, altura, 66, 4, Estilos.Reducida)
                Impreso.Detalle.Titulo(Categoria, Col(2), altura, 39, 4, Estilos.Reducida)
                Impreso.Detalle.Titulo(Kilos.ToString("#,##0.00"), Col(3), altura, 19, 4, Estilos.Reducida, ">")
                Impreso.Detalle.Titulo(Precio, Col(4), altura, 19, 4, Estilos.Reducida, ">")
                Impreso.Detalle.Titulo(Importe.ToString("#,##0.00"), Col(5), altura, 29, 4, Estilos.Reducida, ">")

                altura = altura + 4



                AuxIdGenero = IdGenero

                Application.DoEvents()

            Next


            If CompruebaSaltoPagina(altura, 14) Then
                Impreso.Detalle.SaltoPagina()
                altura = altura_impreso
            End If

            'Total producto
            Impreso.Detalle.Titulo("Total Producto...", Col(1), altura, 60, 4, Estilos.Reducida, ">")
            Impreso.Detalle.Titulo(TotalKilosGen.ToString("#,##0.00"), Col(3), altura, 19, 4, Estilos.Reducida, ">")
            Impreso.Detalle.Titulo(TotalImporteGen.ToString("#,##0.00"), Col(5), altura, 29, 4, Estilos.Reducida, ">")
            altura = altura + 8


        End If






        Dim alto_detalle As Integer = altura - BaseLineas
        If alto_detalle < 130 Then
            altura = BaseLineas + 130
        End If



        'Líneas laterales
        Impreso.Detalle.LineaH(margen_izquierdo, altura, 190, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(margen_izquierdo, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(margen_izquierdo + 190, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)

        altura = altura + 2



    End Sub


    Private Sub ImprimeTotalesFacturaAgr(ByRef Impreso As Impreso, ByRef altura As Integer, FacturaAgr As E_FacturaAgr,
                                           ByRef Col As List(Of Integer), ByVal TotalKilos As Decimal, ByVal TotalImporte As Decimal,
                                           ByVal Compensacion As String)



        Impreso.Detalle.Titulo("TOTAL LINEAS: ", Col(2), altura, 39, 4, Estilos.Reducida, "=")
        Impreso.Detalle.Titulo(TotalKilos.ToString("#,##0.00"), Col(3), altura, 19, 4, Estilos.Reducida, ">")
        Impreso.Detalle.Titulo(TotalImporte.ToString("#,##0.00"), Col(5), altura, 29, 4, Estilos.Reducida, ">")

        altura = altura + 7

        Impreso.Detalle.LineaH(Col(1), altura, 190, ancho_linea, Color.Black)

        altura = altura + 5


        'Comprueba salto de linea
        Dim altura_linea As Integer = 50
        If CompruebaSaltoPagina(altura, altura_linea) Then
            Impreso.Detalle.SaltoPagina()
            altura = altura_impreso
        End If



        Dim c1 As Integer = margen_izquierdo
        Dim c2 As Integer = margen_izquierdo + 30 + 2
        Dim c3 As Integer = margen_izquierdo + 30 + 2 + 25 + 2
        Dim c4 As Integer = margen_izquierdo + 30 + 2 + 25 + 2 + 25 + 2
        Dim c5 As Integer = margen_izquierdo + 30 + 2 + 25 + 2 + 25 + 2 + 30 + 2
        Dim c6 As Integer = margen_izquierdo + 30 + 2 + 25 + 2 + 25 + 2 + 30 + 2 + 15 + 2
        Dim c7 As Integer = margen_izquierdo + 30 + 2 + 25 + 2 + 25 + 2 + 30 + 2 + 15 + 2 + 23 + 2




        Dim canon As Decimal = VaDec(FacturaAgr.FGR_comision.Valor)
        Dim portes As Decimal = VaDec(FacturaAgr.FGR_otrosgastos.Valor)
        Dim base As Decimal = TotalImporte - canon - portes
        Dim iva As Decimal = VaDec(FacturaAgr.FGR_iva.Valor)
        Dim cuotaiva As Decimal = VaDec(FacturaAgr.FGR_CuotaIva.Valor)
        Dim total As Decimal = base + cuotaiva
        Dim fondo As Decimal = VaDec(FacturaAgr.FGR_cuotafondo.Valor)
        Dim contingencia As Decimal = VaDec(FacturaAgr.FGR_CuotaContingencia.Valor)
        Dim re As Decimal = VaDec(FacturaAgr.FGR_retencion.Valor)
        Dim cuotare As Decimal = VaDec(FacturaAgr.FGR_cuotaretencion.Valor)
        Dim apagar As Decimal = VaDec(FacturaAgr.FGR_TotalFactura.Valor)


        Impreso.Detalle.Titulo("TOTAL", c1 + 1, altura, 28, 5, Estilos.ReducidaBoldLineaDebajo, "=")
        Impreso.Detalle.Titulo("CANON", c2 + 1, altura, 23, 5, Estilos.ReducidaBoldLineaDebajo, "=")
        Impreso.Detalle.Titulo("PORTES", c3 + 1, altura, 23, 5, Estilos.ReducidaBoldLineaDebajo, "=")
        Impreso.Detalle.Titulo("BASE IMP", c4 + 1, altura, 28, 5, Estilos.ReducidaBoldLineaDebajo, "=")
        Impreso.Detalle.Titulo("%IVA", c5 + 1, altura, 13, 5, Estilos.ReducidaBoldLineaDebajo, "=")
        Impreso.Detalle.Titulo("CUOTA", c6 + 1, altura, 21, 5, Estilos.ReducidaBoldLineaDebajo, "=")
        Impreso.Detalle.Titulo("TOTAL FACTURA", c7 + 1, altura, 28, 5, Estilos.ReducidaBoldLineaDebajo, "=")
        altura = altura + 4


        Impreso.Detalle.Titulo(TotalImporte.ToString("#,##0.00"), c1 + 1, altura, 28, 4, Estilos.Reducida, "=")
        If canon <> 0 Then Impreso.Detalle.Titulo("-" & canon.ToString("#,##0.00"), c2 + 1, altura, 23, 4, Estilos.Reducida, "=")
        If portes <> 0 Then Impreso.Detalle.Titulo("-" & portes.ToString("#,##0.00"), c3 + 1, altura, 23, 4, Estilos.Reducida, "=")
        Impreso.Detalle.Titulo(base.ToString("#,##0.00"), c4 + 1, altura, 28, 4, Estilos.Reducida, "=")
        Impreso.Detalle.Titulo(iva.ToString("#,##0.00"), c5 + 1, altura, 13, 4, Estilos.Reducida, "=")
        Impreso.Detalle.Titulo(cuotaiva.ToString("#,##0.00"), c6 + 1, altura, 21, 4, Estilos.Reducida, "=")
        Impreso.Detalle.Titulo(total.ToString("#,##0.00"), c7 + 1, altura, 28, 4, Estilos.Reducida, "=")

        altura = altura + 14


        Impreso.Detalle.Titulo("RECIBI", c1 + 10, altura, 78, 5, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo("F.OPERATIVO", c3 + 1, altura, 28, 5, Estilos.ReducidaBoldLineaDebajo, "=")
        If contingencia <> 0 Then Impreso.Detalle.Titulo("F.CONTINGENCIA", c4 + 1, altura, 28, 5, Estilos.ReducidaBoldLineaDebajo, "=")
        Impreso.Detalle.Titulo("%RET", c5 + 1, altura, 13, 5, Estilos.ReducidaBoldLineaDebajo, "=")
        Impreso.Detalle.Titulo("RETENCION", c6 + 1, altura, 21, 5, Estilos.ReducidaBoldLineaDebajo, "=")
        Impreso.Detalle.Titulo("T.A PAGAR", c7 + 1, altura, 28, 5, Estilos.ReducidaBoldLineaDebajo, "=")
        altura = altura + 4

        If fondo <> 0 Then Impreso.Detalle.Titulo("-" & fondo.ToString("#,##0.00"), c3 + 1, altura, 28, 4, Estilos.Reducida, "=")
        If contingencia <> 0 Then Impreso.Detalle.Titulo("-" & contingencia.ToString("#,##0.00"), c4 + 1, altura, 28, 4, Estilos.Reducida, "=")
        Impreso.Detalle.Titulo(re.ToString("#,##0.00"), c5 + 1, altura, 13, 4, Estilos.Reducida, "=")
        Impreso.Detalle.Titulo(cuotare.ToString("#,##0.00"), c6 + 1, altura, 21, 4, Estilos.Reducida, "=")
        Impreso.Detalle.Titulo(apagar.ToString("#,##0.00"), c7 + 1, altura, 28, 4, Estilos.Reducida, "=")
        altura = altura + 24

        If compensacion = "S" Then
            Impreso.Detalle.Titulo("Acogido al Regimen Especial de Agricultura, Ganaderia y Pesca", margen_izquierdo, altura, 190, 4, Estilos.Reducida)
        End If



    End Sub


    Private Sub ImprimePieFacturaAgr(ByRef Impreso As Impreso, Ejemplar As String, FacturaAgr As E_FacturaAgr)

        Impreso.Pie.Titulo(Ejemplar, margen_izquierdo, 275, 190, 7, Estilos.ReducidaBold, ">")
        'Datos empresa
        Dim IdEmpresa As String = (FacturaAgr.FGR_idempresa.Valor & "").Trim

        Dim Empresa As New E_Empresas(Idusuario, cn)
        If Empresa.LeerId(IdEmpresa) Then

            Dim domicilio As String = Empresa.EMP_Domicilio.Valor
            Dim cif As String = Empresa.EMP_CIF.Valor

            Impreso.Pie.LineaH(margen_izquierdo, 280, 190, ancho_linea)
            Impreso.Pie.Titulo(domicilio & " - C.I.F.: " & cif, margen_izquierdo, 281, 190, 3, Estilos.MinimaBold)

        End If


    End Sub



    Private Function CompruebaSaltoPagina(altura As Integer, altura_linea As Integer) As Boolean

        Dim bRes As Boolean = False

        If altura + altura_linea > Pie_linea Then
            bRes = True
        End If


        Return bRes

    End Function


End Module
