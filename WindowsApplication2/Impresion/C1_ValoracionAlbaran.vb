Imports System.Drawing


Module C1_ValoracionAlbaranSalida

    Dim margen_izquierdo As Integer = 6
    Dim ancho_linea As Decimal = 2
    Dim alto_linea_detalle As Integer = 28
    Dim Pie_linea As Integer = 199 '282
    Dim altura_impreso As Integer = 46


    Private Class Costos

        Public Estructura As Decimal = 0
        Public Mantenimiento As Decimal = 0
        Public Materiales As Decimal = 0


        Public Function Total() As Decimal

            Return Estructura + Mantenimiento + Materiales

        End Function

    End Class


    Private Class Gasto

        Public Nombre As String = ""
        Public Importe As Decimal = 0

        Public Sub New(Nombre As String, Importe As Decimal)
            Me.Nombre = Nombre
            Me.Importe = Importe
        End Sub

    End Class


    Private Class GastosVentas

        Public VentaBruta As Decimal = 0
        Public DcGastos As New Dictionary(Of Integer, Gasto)


        Public Sub SumaGasto(IdGasto As Integer, Nombre As String, Importe As Decimal)
            If DcGastos.ContainsKey(IdGasto) Then
                DcGastos(IdGasto).Importe = DcGastos(IdGasto).Importe + Importe
            Else
                Dim gasto As New Gasto(Nombre, Importe)
                DcGastos(IdGasto) = gasto
            End If
        End Sub


        Public Function Total() As Decimal

            Dim res As Decimal = 0


            For Each IdGasto As Integer In DcGastos.Keys
                res = res + DcGastos(IdGasto).Importe
            Next


            Return res

        End Function

    End Class


    Public Sub C1_ImprimirValoracionAlbaran(IdAlbaran As String, TipoImpresion As TipoImpresion,
                                          Optional Impresora As String = "",
                                          Optional rutaPDF As String = "",
                                          Optional archivoPDF As String = "")


        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)

        If AlbSalida.LeerId(IdAlbaran) Then


            Dim Clientes As New E_Clientes(Idusuario, cn)
            If Not Clientes.LeerId(AlbSalida.ASA_idcliente.Valor) Then
                MsgBox("Error al leer los datos del cliente con Id: " & AlbSalida.ASA_idcliente.Valor)
                Exit Sub
            End If


            Dim altura As Integer = 7
            Dim DatosEmpresa As New DatosEmpresa



            Dim Impreso As New Impreso()

            Impreso.f.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
            Impreso.f.Documento.PageLayout.PageSettings.Landscape = True
            Impreso.f.Documento.PageLayout.PageSettings.TopMargin = "10mm"
            Impreso.f.Documento.PageLayout.PageSettings.LeftMargin = "10mm"
            Impreso.f.Documento.PageLayout.PageSettings.RightMargin = "10mm"
            Impreso.f.Documento.PageLayout.PageSettings.BottomMargin = "12mm"

            Impreso.EstableceImpreso(TipoImpresion)


            altura = 7


            Dim Costos As New Costos
            Dim GastosVentas As New GastosVentas

            Dim TotalBultosSal As Decimal = 0
            Dim TotalBultosVen As Decimal = 0
            Dim TotalKilosSal As Decimal = 0
            Dim TotalKilosVen As Decimal = 0
            Dim TotalImporte As Decimal = 0
            Dim TotalKilos As Decimal = 0


            Try

                'Imprimir cabecera
                ImprimeCabeceraValoracionAlbaran(Impreso, altura, AlbSalida, DatosEmpresa, Clientes)

                'Imprimir detalle
                ImprimeDetalleValoracionAlbaran(Impreso, altura, AlbSalida, Costos, GastosVentas,
                                                TotalBultosSal, TotalBultosVen, TotalKilosSal, TotalKilosVen, TotalImporte,
                                                TotalKilos)

                'Imprimir 
                ImprimirTotalValoracionAlbaran(Impreso, altura, AlbSalida,
                                               TotalBultosSal, TotalBultosVen,
                                               TotalKilosSal, TotalKilosVen, TotalImporte,
                                               Costos, GastosVentas, TotalKilos)



                'Impresión
                Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)

            Catch ex As Exception

            End Try


        Else
            MsgBox("No se puede leer Pedido con Id: " & IdAlbaran)
        End If

    End Sub


    Private Sub ImprimeCabeceraValoracionAlbaran(Impreso As Impreso, ByRef altura As Integer, AlbSalida As E_AlbSalida, DatosEmpresa As DatosEmpresa, Cliente As E_Clientes)

        Dim BaseAltura As Integer = altura

        Impreso.Cabecera.Titulo(DatosEmpresa.NombreEmpresa, margen_izquierdo, altura, 175, 7, Estilos.Cabecera)
        altura = altura + 7
        Impreso.Cabecera.Titulo(DatosEmpresa.Domicilio, margen_izquierdo, altura, 75, 4, Estilos.NormalBold)
        altura = altura + 4
        Impreso.Cabecera.Titulo(DatosEmpresa.Poblacion & " (" & DatosEmpresa.Provincia & ")", margen_izquierdo, altura, 75, 4, Estilos.NormalBold)
        altura = altura + 4
        Impreso.Cabecera.Titulo("C.I.F.: " & DatosEmpresa.NIF, margen_izquierdo, altura, 75, 4, Estilos.NormalBold)
        altura = altura + 8

        altura = BaseAltura
        Impreso.Cabecera.Titulo("RESULTADOS DE LA VENTA", margen_izquierdo, altura + 5, 275, 7, Estilos.Cabecera, "=")


        Impreso.Cabecera.Cuadro(margen_izquierdo + 180, altura, 100, 28, ancho_linea, Color.Black)

        Dim NombreCliente As String = Cliente.CLI_Nombre.Valor & ""
        Dim Domicilio As String = (Cliente.CLI_Domicilio.Valor & "").Trim
        Dim CP As String = (Cliente.CLI_CPostal.Valor & "").Trim
        Dim Poblacion As String = (Cliente.CLI_Poblacion.Valor & "").Trim
        Dim provincia As String = (Cliente.CLI_Provincia.Valor & "").Trim
        Dim Pais As String = ""

        Dim Paises As New E_Paises(Idusuario, CnComun)
        If Paises.LeerId(Cliente.CLI_IdPais.Valor) Then
            Pais = (Paises.Nombre.Valor & "").Trim
        End If


        Impreso.Cabecera.Titulo(NombreCliente, margen_izquierdo + 180 + 2, altura + 2, 96, 5, Estilos.NormalBold)
        altura = altura + 5
        Impreso.Cabecera.Titulo(Domicilio, margen_izquierdo + 180 + 2, altura + 2, 96, 5, Estilos.NormalBold)
        altura = altura + 5
        Impreso.Cabecera.Titulo(CP & " - " & Poblacion, margen_izquierdo + 180 + 2, altura + 2, 96, 5, Estilos.NormalBold)
        altura = altura + 5
        Impreso.Cabecera.Titulo(provincia, margen_izquierdo + 180 + 2, altura + 2, 96, 5, Estilos.NormalBold)
        altura = altura + 5
        Impreso.Cabecera.Titulo(Pais, margen_izquierdo + 180 + 2, altura + 2, 96, 5, Estilos.NormalBold)




        altura = BaseAltura + 28 - 2


        Dim Col As New List(Of Integer)
        Col.Add(0)
        Col.Add(0)
        Col.Add(0)
        Col.Add(0)
        Col.Add(0)
        Col.Add(0)
        Col.Add(0)
        Col.Add(0)
        Col.Add(0)


        Col(0) = 0
        Col(1) = margen_izquierdo
        Col(2) = Col(1) + 23
        Col(3) = Col(2) + 22
        Col(4) = Col(3) + 18
        Col(5) = Col(4) + 15
        Col(6) = Col(5) + 22


        Impreso.Cabecera.Cuadro(margen_izquierdo, altura, 100, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(Col(2), altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(Col(3), altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(Col(4), altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(Col(5), altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaH(margen_izquierdo, altura + 5, 100, ancho_linea)
        altura = altura + 1


        Impreso.Cabecera.Titulo("F.Salida", Col(1) + 1, altura, 22, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo("F.Valor.", Col(2) + 1, altura, 21, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo("Albaran", Col(3) + 1, altura, 13, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo("Codigo", Col(4) + 1, altura, 13, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo("Valor cambio", Col(5) + 1, altura, 21, 4, Estilos.ReducidaBold, "=")
        altura = altura + 5


        Dim CodCli As String = VaInt(Cliente.CLI_Codigo.Valor).ToString("00000")
        Dim FechaSal As String = "" : If VaDate(AlbSalida.ASA_fechasalida.Valor) > VaDate("") Then FechaSal = VaDate(AlbSalida.ASA_fechasalida.Valor).ToString("dd/MM/yyyy")
        Dim FechaValor As String = "" : If VaDate(AlbSalida.ASA_fechavaloracion.Valor) > VaDate("") Then FechaValor = VaDate(AlbSalida.ASA_fechavaloracion.Valor).ToString("dd/MM/yyyy")
        Dim Albaran As String = AlbSalida.ASA_albaran.Valor
        Dim ValorCambio As Decimal = 1 : If VaDec(AlbSalida.ASA_valorcambio.Valor) <> 0 Then ValorCambio = VaDec(AlbSalida.ASA_valorcambio.Valor)


        Impreso.Cabecera.Titulo(FechaSal, Col(1) + 1, altura, 21, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(FechaValor, Col(2) + 1, altura, 21, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(Albaran, Col(3) + 1, altura, 16, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(CodCli, Col(4) + 1, altura, 13, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(ValorCambio.ToString("#,##0.0000"), Col(5) + 1, altura, 20, 4, Estilos.Reducida, ">")
        altura = altura + 7

    End Sub



    Private Sub ImprimeDetalleValoracionAlbaran(Impreso As Impreso, ByRef altura As Integer, AlbSalida As E_AlbSalida,
                            ByRef Costos As Costos, ByRef GastosVentas As GastosVentas,
                            ByRef TotalBultosSal As Integer, ByRef TotalBultosVen As Integer,
                            ByRef TotalKilosSal As Decimal, ByRef TotalKilosVen As Decimal, ByRef TotalImporte As Decimal,
                            ByRef TotalKilos As Decimal)

        Dim BaseAltura As Integer = altura



        Dim VentaBruta As Decimal = 0
        TotalKilos = 0


        Dim sql As String = "SELECT SUM(COALESCE(ASL_ImporteGeneroVta,0) * COALESCE(ASA_ValorCambio,1)) as TotalImporte, " & vbCrLf
        sql = sql & " SUM(ASL_KilosNetos) as TotalKilos " & vbCrLf
        sql = sql & " FROM AlbSalida_Lineas" & vbCrLf
        sql = sql & "LEFT JOIN AlbSalida ON ASA_IdAlbaran = ASL_IdAlbaran" & vbCrLf
        sql = sql & " WHERE ASL_IdAlbaran = " & AlbSalida.ASA_idalbaran.Valor

        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                VentaBruta = VaDec(dt.Rows(0)("TotalImporte"))
                TotalKilos = VaDec(dt.Rows(0)("TotalKilos"))
            End If
        End If


        GastosVentas.VentaBruta = VentaBruta

        sql = "SELECT ASG_IdGasto as IdGasto, GCO_Nombre as Gasto, ASG_ImporteGastoEuros as Importe" & vbCrLf
        sql = sql & " FROM AlbSalida_Gastos" & vbCrLf
        sql = sql & " LEFT JOIN GastosComercio ON GCO_IdGasto = ASG_IdGasto" & vbCrLf
        sql = sql & " WHERE ASG_IdAlbaran = " & AlbSalida.ASA_idalbaran.Valor & vbCrLf
        dt = AlbSalida.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows

                Dim IdGasto As Integer = VaInt(row("IdGasto"))
                Dim Gasto As String = (row("Gasto").ToString & "").Trim
                Dim Importe As Decimal = VaDec(row("Importe"))
                GastosVentas.SumaGasto(IdGasto, Gasto, Importe)

                Application.DoEvents()

            Next

        End If




        Dim VentaNeta As Decimal = VentaBruta - GastosVentas.Total
        Dim PrecioNeto As Decimal = 0
        If TotalKilos <> 0 Then PrecioNeto = VentaNeta / TotalKilos


        sql = "SELECT ASL_IdGenero as IdGenero, GEN_NombreGenero as Genero, ASL_Categoria as Categoria," & vbCrLf
        sql = sql & " ASL_IdGenSal as IdPresentacion, GES_Nombre as Presentacion," & vbCrLf
        sql = sql & " ASL_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql = sql & " ASL_Bultos as BultosSal, ASL_BultosVendidos as BultosVen," & vbCrLf
        sql = sql & " COALESCE(ASL_BultosVendidos,0) - COALESCE(ASL_Bultos,0) as DifBultos," & vbCrLf
        sql = sql & " ASL_KilosNetos as KilosSal, ASL_KilosVendidos as KilosVen," & vbCrLf
        sql = sql & " COALESCE(ASL_KilosVendidos,0) - COALESCE(ASL_KilosNetos,0) as DifKilos," & vbCrLf
        sql = sql & " 0.00 as Precio, COALESCE(ASL_ImporteGeneroVta,0) * COALESCE(ASA_ValorCambio,1) as Importe, " & vbCrLf
        sql = sql & " 0.00 as PrecioNeto, " & vbCrLf
        sql = sql & " COALESCE(ASL_Estructura, 0) as Estructura, COALESCE(ASL_Manipulacion, 0) as Manipulacion,  COALESCE(ASL_Materiales, 0) as Materiales," & vbCrLf
        sql = sql & " 0.00 as Beneficio" & vbCrLf
        sql = sql & " FROM AlbSalida_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida ON ASA_IdAlbaran = ASL_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = ASL_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN GenerosSalida ON GES_IdGenSal = ASL_IdGenSal" & vbCrLf
        sql = sql & " LEFT JOIN Marcas ON MAR_IdMarca = ASL_IdMarca" & vbCrLf
        sql = sql & " WHERE ASL_IdAlbaran = " & AlbSalida.ASA_idalbaran.Valor & vbCrLf


        dt = AlbSalida.MiConexion.ConsultaSQL(sql)


        If Not IsNothing(dt) Then


            Dim nLineas As Integer = 1

            For Each row As DataRow In dt.Rows


                If nLineas > 5 Then
                    Impreso.Detalle.SaltoPagina()
                    nLineas = 1
                    altura = BaseAltura
                End If


                Dim Genero As String = row("Genero").ToString & ""
                Dim Categoria As String = row("Categoria").ToString & ""
                Dim Presentacion As String = row("Presentacion").ToString & ""
                Dim Marca As String = row("Marca").ToString & ""

                Dim BultosSal As Integer = VaInt(row("BultosSal"))
                Dim BultosVen As Integer = VaInt(row("BultosVen"))
                Dim DifBultos As Integer = VaInt(row("DifBultos"))
                Dim KilosSal As Decimal = VaDec(row("KilosSal"))
                Dim KilosVen As Decimal = VaDec(row("KilosVen"))
                Dim DifKilos As Decimal = VaDec(row("DifKilos"))
                Dim Importe As Decimal = VaDec(row("Importe"))
                Dim Estructura As Decimal = VaDec(row("Estructura"))
                Dim Mantenimiento As Decimal = VaDec(row("Manipulacion"))
                Dim Materiales As Decimal = VaDec(row("Materiales"))
                Dim TotalCoste As Decimal = Estructura + Mantenimiento + Materiales

                Dim VentaNetaLinea As Decimal = PrecioNeto * KilosSal
                Dim Beneficio As Decimal = VentaNetaLinea - TotalCoste


                TotalBultosSal = TotalBultosSal + BultosSal
                TotalBultosVen = TotalBultosVen + BultosVen
                TotalKilosSal = TotalKilosSal + KilosSal
                TotalKilosVen = TotalKilosVen + KilosVen
                TotalImporte = TotalImporte + Importe



                Dim Precio As Decimal = 0
                Dim PrecioCoste As Decimal = 0

                If KilosSal <> 0 Then
                    Precio = Importe / KilosSal
                    PrecioCoste = TotalCoste / KilosSal
                End If



                Costos.Estructura = Costos.Estructura + Estructura
                Costos.Mantenimiento = Costos.Mantenimiento + Mantenimiento
                Costos.Materiales = Costos.Materiales + Materiales


                'Cuadro
                Impreso.Detalle.Cuadro(margen_izquierdo, altura, 280, alto_linea_detalle, ancho_linea, Color.Black)
                altura = altura + 2

                Impreso.Detalle.Titulo("Producto: ", margen_izquierdo + 5, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Genero, margen_izquierdo + 30 + 5, altura, 140, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Categ./Calibre: ", margen_izquierdo + 180, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Categoria, margen_izquierdo + 180 + 30, altura, 60, 6, Estilos.GrandeBold)
                altura = altura + 6
                Impreso.Detalle.Titulo("Presentación: ", margen_izquierdo + 5, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Presentacion, margen_izquierdo + 30 + 5, altura, 160, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Marca: ", margen_izquierdo + 195, altura, 15, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Marca, margen_izquierdo + 195 + 15, altura, 60, 6, Estilos.GrandeBold)
                altura = altura + 6
                Impreso.Detalle.Titulo("Bultos Sal.: ", margen_izquierdo + 5, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(BultosSal.ToString("#,##0"), margen_izquierdo + 5 + 30, altura, 17, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Bultos Ven.: ", margen_izquierdo + 52 + 5, altura, 23, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(BultosVen.ToString("#,##0"), margen_izquierdo + 80, altura, 17, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Dif. Bultos: ", margen_izquierdo + 102, altura, 22, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(DifBultos.ToString("#,##0"), margen_izquierdo + 102 + 22, altura, 17, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Kg. Sal.: ", margen_izquierdo + 146, altura, 18, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(KilosSal.ToString("#,##0"), margen_izquierdo + 146 + 18, altura, 20, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Kg. Ven.: ", margen_izquierdo + 189, altura, 18, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(KilosVen.ToString("#,##0"), margen_izquierdo + 189 + 20, altura, 20, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Dif. Kg.: ", margen_izquierdo + 234, altura, 17, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(DifKilos.ToString("#,##0"), margen_izquierdo + 234 + 17, altura, 20, 6, Estilos.GrandeBold)
                altura = altura + 6
                Impreso.Detalle.Titulo("Precio: ", margen_izquierdo + 5, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Precio.ToString("#,##0.0000"), margen_izquierdo + 5 + 30, altura, 22, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Importe: ", margen_izquierdo + 63, altura, 20, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Importe.ToString("#,##0.00"), margen_izquierdo + 80, altura, 25, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("P.Neto: ", margen_izquierdo + 112, altura, 15, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(PrecioNeto.ToString("#,##0.0000"), margen_izquierdo + 112 + 15, altura, 22, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("P.Costo: ", margen_izquierdo + 154, altura, 17, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(PrecioCoste.ToString("#,##0.0000"), margen_izquierdo + 154 + 17, altura, 22, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Benef: ", margen_izquierdo + 198, altura, 15, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Beneficio.ToString("#,##0.00"), margen_izquierdo + 198 + 15, altura, 25, 6, Estilos.GrandeBold)


                altura = altura + 6
                altura = altura + 5


                nLineas = nLineas + 1


                Application.DoEvents()

            Next


        End If




    End Sub



    Private Sub ImprimirTotalValoracionAlbaran(Impreso As Impreso, ByRef altura As Integer, AlbSalida As E_AlbSalida,
                                               TotalBultosSal As Integer, TotalBultosVen As Integer,
                                               TotalKilosSal As Decimal, TotalKilosVen As Decimal, TotalImporte As Decimal,
                                               ByVal Costos As Costos, ByVal GastosVentas As GastosVentas, KilosSal As Decimal)



        'Línea total
        Dim altura_linea As Integer = 17
        If CompruebaSaltoPagina(altura, altura_linea) Then
            Impreso.Detalle.SaltoPagina()
            altura = altura_impreso
        End If


        Impreso.Detalle.Cuadro(120, altura, 160, 12, ancho_linea, Color.Black)
        Impreso.Detalle.LineaH(120, altura + 6, 160, ancho_linea)
        Impreso.Detalle.LineaV(120 + 30, altura, 12, ancho_linea)
        Impreso.Detalle.LineaV(120 + 60, altura, 12, ancho_linea)
        Impreso.Detalle.LineaV(120 + 90, altura, 12, ancho_linea)
        Impreso.Detalle.LineaV(120 + 120, altura, 12, ancho_linea)

        Impreso.Detalle.Titulo("BUL.SAL.", 120, altura + 1, 30, 6, Estilos.GrandeBold, "=")
        Impreso.Detalle.Titulo("BUL.VEN.", 120 + 30, altura + 1, 30, 6, Estilos.GrandeBold, "=")
        Impreso.Detalle.Titulo("KG.SAL.", 120 + 60, altura + 1, 30, 6, Estilos.GrandeBold, "=")
        Impreso.Detalle.Titulo("KG.VEN.", 120 + 90, altura + 1, 30, 6, Estilos.GrandeBold, "=")
        Impreso.Detalle.Titulo("IMPORTE", 120 + 120, altura + 1, 40, 6, Estilos.GrandeBold, "=")
        altura = altura + 6

        Impreso.Detalle.Titulo(TotalBultosSal.ToString("#,##0"), 120 + 1, altura, 28, 6, Estilos.GrandeBold, ">")
        Impreso.Detalle.Titulo(TotalBultosVen.ToString("#,##0"), 120 + 30 + 1, altura, 28, 6, Estilos.GrandeBold, ">")
        Impreso.Detalle.Titulo(TotalKilosSal.ToString("#,##0"), 120 + 60 + 1, altura, 28, 6, Estilos.GrandeBold, ">")
        Impreso.Detalle.Titulo(TotalKilosVen.ToString("#,##0"), 120 + 90 + 1, altura, 28, 6, Estilos.GrandeBold, ">")
        Impreso.Detalle.Titulo(TotalImporte.ToString("#,##0.00"), 120 + 120 + 1, altura, 38, 6, Estilos.GrandeBold, ">")
        altura = altura + 5
        altura = altura + 7


        Dim BaseAltura As Integer = altura


        'Costos
        Dim altura_costos As Integer = 25  'altura costes
        Dim altura_gastos As Integer = 5 + 5 + 5 + GastosVentas.DcGastos.Keys.Count * 5
        Dim altura_min_resumen As Integer = altura_costos
        If altura_gastos > altura_costos Then altura_min_resumen = altura_gastos



        altura_linea = altura_min_resumen
        If CompruebaSaltoPagina(altura, altura_linea) Then
            Impreso.Detalle.SaltoPagina()
            altura = altura_impreso
        End If


        Dim PMC_Estructura As Decimal = 0
        Dim PMC_Mantenimiento As Decimal = 0
        Dim PMC_Materiales As Decimal = 0
        Dim PMC As Decimal = 0

        If KilosSal <> 0 Then
            PMC_Estructura = Costos.Estructura / KilosSal
            PMC_Mantenimiento = Costos.Mantenimiento / KilosSal
            PMC_Materiales = Costos.Materiales / KilosSal
            PMC = Costos.Total / KilosSal
        End If


        Dim altura_costes_gastos As Integer = altura

        Impreso.Detalle.Cuadro(margen_izquierdo, altura, 80, 25, ancho_linea, Color.Black)
        Impreso.Detalle.LineaH(margen_izquierdo, altura + 5, 80, ancho_linea)
        Impreso.Detalle.LineaH(margen_izquierdo, altura + 25 - 6, 80, ancho_linea)
        Impreso.Detalle.LineaV(margen_izquierdo + 40, altura, 25, ancho_linea)
        Impreso.Detalle.LineaV(margen_izquierdo + 65, altura, 25, ancho_linea)


        Impreso.Detalle.Titulo("COSTO SALIDAS", margen_izquierdo + 2, altura + 1, 40, 4, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo("P.M.C.", margen_izquierdo + 65, altura + 1, 14, 6, Estilos.ReducidaBold, ">")
        altura = altura + 5
        Impreso.Detalle.Titulo("GASTO DE MATERIALES", margen_izquierdo + 2, altura, 40, 4, Estilos.Reducida)
        Impreso.Detalle.Titulo(Costos.Materiales.ToString("#,##0.00"), margen_izquierdo + 40 + 1, altura, 23, 4, Estilos.Reducida, ">")
        Impreso.Detalle.Titulo(PMC_Materiales.ToString("#,##0.0000"), margen_izquierdo + 65 + 1, altura, 13, 4, Estilos.Reducida, ">")
        altura = altura + 5
        Impreso.Detalle.Titulo("GASTO DE ESTRUCTURA", margen_izquierdo + 2, altura, 40, 4, Estilos.Reducida)
        Impreso.Detalle.Titulo(Costos.Estructura.ToString("#,##0.00"), margen_izquierdo + 40 + 1, altura, 23, 4, Estilos.Reducida, ">")
        Impreso.Detalle.Titulo(PMC_Estructura.ToString("#,##0.0000"), margen_izquierdo + 65 + 1, altura, 13, 4, Estilos.Reducida, ">")
        altura = altura + 5
        Impreso.Detalle.Titulo("GASTO DE CONFECCION", margen_izquierdo + 2, altura, 40, 4, Estilos.Reducida)
        Impreso.Detalle.Titulo(Costos.Mantenimiento.ToString("#,##0.00"), margen_izquierdo + 40 + 1, altura, 23, 4, Estilos.Reducida, ">")
        Impreso.Detalle.Titulo(PMC_Mantenimiento.ToString("#,##0.0000"), margen_izquierdo + 65 + 1, altura, 13, 4, Estilos.Reducida, ">")
        altura = altura + 5
        Impreso.Detalle.Titulo("TOTAL COSTOS", margen_izquierdo + 2, altura, 40, 4, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo(Costos.Total.ToString("#,##0.00"), margen_izquierdo + 40 + 1, altura, 23, 4, Estilos.ReducidaBold, ">")
        Impreso.Detalle.Titulo(PMC.ToString("#,##0.0000"), margen_izquierdo + 65 + 1, altura, 13, 4, Estilos.Reducida, ">")
        altura = altura + 5


        'Gastos
        'altura = BaseAltura
        altura = altura_costes_gastos


        Dim PMV_VentaBruta As Decimal = 0
        Dim PMV_Gastos As Decimal = 0
        Dim PMV_Global As Decimal = 0

        If KilosSal <> 0 Then
            PMV_VentaBruta = GastosVentas.VentaBruta / KilosSal
            PMV_Gastos = GastosVentas.Total / KilosSal
            PMV_Global = (GastosVentas.VentaBruta - GastosVentas.Total) / KilosSal
        End If

        Impreso.Detalle.Cuadro(200, altura, 80, altura_gastos + 6, ancho_linea, Color.Black)
        Impreso.Detalle.LineaH(200, altura + 5, 80, ancho_linea)
        Impreso.Detalle.LineaH(200, altura + altura_gastos, 80, ancho_linea)
        Impreso.Detalle.LineaV(200 + 43, altura, altura_gastos + 6, ancho_linea)
        Impreso.Detalle.LineaV(200 + 65, altura, altura_gastos + 6, ancho_linea)

        Impreso.Detalle.Titulo("GASTOS VENTAS", 200 + 2, altura + 1, 40, 4, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo("P.M.V.", 200 + 65, altura + 1, 14, 6, Estilos.ReducidaBold, ">")
        altura = altura + 5

        'Venta Bruta
        Impreso.Detalle.Titulo("VENTA BRUTA", 200 + 2, altura, 40, 4, Estilos.Reducida)
        Impreso.Detalle.Titulo(GastosVentas.VentaBruta.ToString("#,##0.00"), 200 + 40 + 1, altura, 23, 4, Estilos.Reducida, ">")
        Impreso.Detalle.Titulo(PMV_VentaBruta.ToString("#,##0.0000"), 200 + 65 + 1, altura, 13, 4, Estilos.Reducida, ">")
        altura = altura + 5

        For Each IdGasto As Integer In GastosVentas.DcGastos.Keys

            Dim gasto As Gasto = GastosVentas.DcGastos(IdGasto)
            Dim PMV As Decimal = 0
            If KilosSal <> 0 Then
                PMV = gasto.Importe / KilosSal
            End If

            Impreso.Detalle.Titulo(gasto.Nombre, 200 + 2, altura, 40, 4, Estilos.Reducida)
            Impreso.Detalle.Titulo(gasto.Importe.ToString("#,##0.00"), 200 + 40 + 1, altura, 23, 4, Estilos.Reducida, ">")
            Impreso.Detalle.Titulo(PMV.ToString("#,##0.0000"), 200 + 65 + 1, altura, 13, 4, Estilos.Reducida, ">")
            altura = altura + 5

            Application.DoEvents()

        Next

        Impreso.Detalle.Titulo("TOTAL GASTOS", 200 + 2, altura, 40, 4, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo(GastosVentas.Total.ToString("#,##0.00"), 200 + 40 + 1, altura, 23, 4, Estilos.Reducida, ">")
        Impreso.Detalle.Titulo(PMV_Gastos.ToString("#,##0.0000"), 200 + 65 + 1, altura, 13, 4, Estilos.Reducida, ">")
        altura = altura + 6


        Dim VentaNeta As Decimal = GastosVentas.VentaBruta - GastosVentas.Total

        Impreso.Detalle.Titulo("VENTA NETA", 200 + 2, altura, 40, 4, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo(VentaNeta.ToString("#,##0.00"), 200 + 40 + 1, altura, 23, 4, Estilos.ReducidaBold, ">")
        Impreso.Detalle.Titulo(PMV_Global.ToString("#,##0.0000"), 200 + 65 + 1, altura, 13, 4, Estilos.Reducida, ">")
        altura = altura + 5



        'Resultados
        'altura = BaseAltura + altura_min_resumen + 5
        altura = altura + altura_min_resumen + 5

        altura_linea = 6
        If CompruebaSaltoPagina(altura, altura_linea) Then
            Impreso.Detalle.SaltoPagina()
            altura = altura_impreso
        End If


        Dim Resultado As Decimal = GastosVentas.VentaBruta - GastosVentas.Total - Costos.Total
        Dim PrecioMedio As Decimal = 0
        If KilosSal <> 0 Then PrecioMedio = Resultado / KilosSal

        Impreso.Detalle.Titulo("RESULTADOS:             " & Resultado.ToString("#,##0.00") & " €              " & PrecioMedio.ToString("#,##0.0000") & " €/Kg",
                               margen_izquierdo, altura, 280, 6, Estilos.GrandeBold, "=")



    End Sub


    Private Function CompruebaSaltoPagina(altura As Integer, altura_linea As Integer) As Boolean

        Dim bRes As Boolean = False

        If altura + altura_linea > Pie_linea Then
            bRes = True
        End If


        Return bRes

    End Function


End Module


