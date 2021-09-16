Imports System.Drawing


Module C1_OrdenConfeccion

    Dim margen_izquierdo As Integer = 6
    Dim ancho_linea As Decimal = 2
    Dim alto_linea_detalle As Integer = 34
    Dim Pie_linea As Integer = 199 '282
    Dim altura_impreso As Integer = 46


    Public Sub C1_ImprimirEtiquetaPedido(Ejercicio As String, IdCentro As String, NumPedido As String, Impresora As String, TipoImpresion As TipoImpresion)

        'Meollo
        Dim Impreso As New Impreso
        Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.Custom
        Impreso.f.documento.PageLayout.PageSettings.Landscape = False
        Impreso.f.documento.PageLayout.PageSettings.SetPaperSizes("69mm", "29mm")
        Impreso.f.documento.PageLayout.PageSettings.TopMargin = "0mm"
        Impreso.f.documento.PageLayout.PageSettings.BottomMargin = "0mm"
        Impreso.f.documento.PageLayout.PageSettings.LeftMargin = "0mm"
        Impreso.f.documento.PageLayout.PageSettings.RightMargin = "0mm"


        Impreso.EstableceImpreso(TipoImpresion)


        Dim Code39 As New Font("C39HrP24DhTt", 37)
        Dim CodBar As String = "*PE" & Ejercicio & "." & IdCentro & "." & NumPedido & "*"
        Impreso.Detalle.Titulo(CodBar, 0, 2, 68, 25, Estilos.Custom, "=", , Code39)


        'Impresión / previsualización / exportación
        If TipoImpresion = NetAgro.TipoImpresion.Preliminar Then
            Impreso.Imprimir(TipoImpresion, Impresora)
        Else
            Impreso.Imprimir(TipoImpresion.ImpresoraSeleccionada, Impresora)
        End If



    End Sub


    Public Sub C1_ImprimirPedidoCliente(IdPedido As String, TipoImpresion As TipoImpresion,
                                          Optional Impresora As String = "",
                                          Optional rutaPDF As String = "",
                                          Optional archivoPDF As String = "",
                                          Optional Completo As Boolean = False)



        Dim Pedidos As New E_Pedidos(Idusuario, cn)

        If Pedidos.LeerId(IdPedido) Then


            Dim Clientes As New E_Clientes(Idusuario, cn)
            If Not Clientes.LeerId(Pedidos.PED_idcliente.Valor) Then
                MsgBox("Error al leer los datos del cliente con Id: " & Pedidos.PED_idcliente.Valor)
                Exit Sub
            End If




            Dim altura As Integer = 7
            Dim DatosEmpresa As New DatosEmpresa


            If Completo = False Then
                'Separar por almacén
                Dim sql As String = "SELECT DISTINCT PAC_IdAlmacen as IdAlmacen, PV.Nombre as Almacen" & vbCrLf
                sql = sql & " FROM Pedidos_Lineas" & vbCrLf
                sql = sql & " LEFT JOIN Pedidos_Almacen ON PEL_IdLinea = PAC_IdLineaPedido" & vbCrLf
                sql = sql & " LEFT JOIN " & ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".dbo.PuntoVenta as PV ON PV.IdPuntoVenta = PAC_IdAlmacen" & vbCrLf
                sql = sql & " WHERE PEL_IdPedido = " & IdPedido & vbCrLf
                sql = sql & " ORDER BY PAC_IdAlmacen" & vbCrLf



                Dim dtAlm As DataTable = Pedidos.MiConexion.ConsultaSQL(sql)
                If Not IsNothing(dtAlm) Then


                    For Each row As DataRow In dtAlm.Rows


                        Dim Impreso As New Impreso()

                        Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
                        Impreso.f.documento.PageLayout.PageSettings.Landscape = True
                        Impreso.f.documento.PageLayout.PageSettings.TopMargin = "10mm"
                        Impreso.f.documento.PageLayout.PageSettings.LeftMargin = "10mm"
                        Impreso.f.documento.PageLayout.PageSettings.RightMargin = "10mm"
                        Impreso.f.documento.PageLayout.PageSettings.BottomMargin = "12mm"

                        Impreso.EstableceImpreso(TipoImpresion)


                        altura = 7


                        Dim Almacen As String = (row("Almacen").ToString & "").Trim
                        Dim IdAlmacen As String = (row("IdAlmacen").ToString & "").Trim
                        Dim HaImpreso As Boolean = False
                        If VaInt(IdAlmacen) > 0 Then

                            Dim TotalPalets As Integer = 0
                            Dim TotalBultos As Integer = 0
                            Dim TotalPiezas As Integer = 0
                            Dim TotalKilos As Decimal = 0


                            Try

                                'Imprimir cabecera
                                ImprimeCabeceraOrdenConfeccion(Impreso, altura, Pedidos, DatosEmpresa, Clientes, Almacen, IdAlmacen)

                                'Imprimir detalle
                                ImprimeDetalleOrdenConfeccion(Impreso, altura, Pedidos, IdAlmacen, TotalPalets, TotalBultos, TotalPiezas, TotalKilos)

                                'Imprimir 
                                ImprimirTotalOrdenConfeccion(Impreso, altura, TotalPalets, TotalBultos, TotalPiezas, TotalKilos)



                                'Impresión
                                Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)

                            Catch ex As Exception

                            End Try


                            Application.DoEvents()
                            HaImpreso = True
                        End If
                        If HaImpreso = False Then
                            MsgBox("No hay almacenes para imprimir ")
                        End If
                    Next


                Else
                    MsgBox("Error al leer las líneas del pedido con id: " & IdPedido)
                End If


            Else ' pedido completo

                Dim Impreso As New Impreso()

                Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
                Impreso.f.documento.PageLayout.PageSettings.Landscape = True
                Impreso.f.documento.PageLayout.PageSettings.TopMargin = "10mm"
                Impreso.f.documento.PageLayout.PageSettings.LeftMargin = "10mm"
                Impreso.f.documento.PageLayout.PageSettings.RightMargin = "10mm"
                Impreso.f.documento.PageLayout.PageSettings.BottomMargin = "12mm"

                Impreso.EstableceImpreso(TipoImpresion)


                altura = 7



                Dim TotalPalets As Integer = 0
                Dim TotalBultos As Integer = 0
                Dim TotalPiezas As Integer = 0
                Dim TotalKilos As Decimal = 0


                Try

                    'Imprimir cabecera
                    ImprimeCabeceraOrdenConfeccion(Impreso, altura, Pedidos, DatosEmpresa, Clientes, "", 0)

                    'Imprimir detalle
                    ImprimeDetalleOrdenConfeccion(Impreso, altura, Pedidos, 0, TotalPalets, TotalBultos, TotalPiezas, TotalKilos)

                    'Imprimir 
                    ImprimirTotalOrdenConfeccion(Impreso, altura, TotalPalets, TotalBultos, TotalPiezas, TotalKilos)



                    'Impresión
                    Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)

                Catch ex As Exception

                End Try


                Application.DoEvents()
            End If

        Else
            MsgBox("No se puede leer Pedido con Id: " & IdPedido)
        End If

    End Sub


    Private Sub ImprimeCabeceraOrdenConfeccion(Impreso As Impreso, ByRef altura As Integer, Pedidos As E_Pedidos, DatosEmpresa As DatosEmpresa, Cliente As E_Clientes, Almacen As String, idalmacen As Integer)

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
        If idalmacen > 0 Then
            Impreso.Cabecera.Titulo("ORDEN DE CONFECCION", margen_izquierdo, altura + 5, 275, 7, Estilos.Cabecera, "=")
            Impreso.Cabecera.Titulo(Almacen, margen_izquierdo + 82, altura + 15, 96, 7, Estilos.GrandeBold, "=")
        Else
            Impreso.Cabecera.Titulo("PEDIDO DE CLIENTE", margen_izquierdo, altura + 5, 275, 7, Estilos.Cabecera, "=")

        End If



        Impreso.Cabecera.Cuadro(margen_izquierdo + 180, altura, 100, 28, ancho_linea, Color.Black)

        Dim NombreCliente As String = Cliente.CLI_Nombre.Valor & ""
        Dim Domicilio As String = ""
        Dim CP As String = ""
        Dim Poblacion As String = ""
        Dim provincia As String = ""
        Dim Pais As String = ""

        If VaInt(Pedidos.PED_iddestino.Valor) > 0 Then

            Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
            If ClientesDescargas.LeerId(Pedidos.PED_iddestino.Valor) Then

                Domicilio = (ClientesDescargas.CLD_numero.Valor & "").Trim & ": " & (ClientesDescargas.CLD_Domicilio.Valor & "").Trim
                CP = (ClientesDescargas.CLD_CPostal.Valor & "").Trim
                Poblacion = (ClientesDescargas.CLD_Poblacion.Valor & "").Trim
                provincia = (ClientesDescargas.CLD_Provincia.Valor & "").Trim

                Dim Paises As New E_Paises(Idusuario, CnComun)
                If Paises.LeerId(ClientesDescargas.CLD_IdPais.Valor) Then
                    Pais = (Paises.Nombre.Valor & "").Trim
                End If

            End If

        End If

        Impreso.Cabecera.Titulo(NombreCliente, margen_izquierdo + 180 + 2, altura + 2, 96, 5, Estilos.NormalBold)
        altura = altura + 5
        Impreso.Cabecera.Titulo("DESTINO " & Domicilio, margen_izquierdo + 180 + 2, altura + 2, 96, 5, Estilos.NormalBold)
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
        Col(2) = Col(1) + 15
        Col(3) = Col(2) + 24
        Col(4) = Col(3) + 15
        Col(5) = Col(4) + 22
        Col(6) = Col(5) + 23
        Col(7) = Col(6) + 23
        Col(8) = Col(7) + 23


        Impreso.Cabecera.Cuadro(margen_izquierdo, altura, 170, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(Col(2), altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(Col(3), altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(Col(4), altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(Col(5), altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(Col(6), altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(Col(7), altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(Col(8), altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaH(margen_izquierdo, altura + 5, 170, ancho_linea)
        altura = altura + 1


        Impreso.Cabecera.Titulo("Código", Col(1) + 1, altura, 13, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo("C.I.F.", Col(2) + 1, altura, 22, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo("Pedido", Col(3) + 1, altura, 13, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo("N.Referen", Col(4) + 1, altura, 20, 4, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo("F.Pedido", Col(5) + 1, altura, 21, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo("F.Salida", Col(6) + 1, altura, 21, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo("F.Llegada", Col(7) + 1, altura, 21, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo("Matrícula", Col(8) + 1, altura, 23, 4, Estilos.ReducidaBold, "=")
        altura = altura + 5


        Dim CodCli As String = VaInt(Cliente.CLI_Codigo.Valor).ToString("00000")
        Dim CIF As String = Cliente.CLI_Nif.Valor & ""
        Dim Pedido As String = VaInt(Pedidos.PED_pedido.Valor).ToString("000000")
        Dim Ref As String = Pedidos.PED_referencia.Valor & ""
        Dim FechaPed As String = "" : If VaDate(Pedidos.PED_fechapedido.Valor) > VaDate("") Then FechaPed = VaDate(Pedidos.PED_fechapedido.Valor).ToString("dd/MM/yyyy")
        Dim FechaSal As String = "" : If VaDate(Pedidos.PED_fechasalida.Valor) > VaDate("") Then FechaSal = VaDate(Pedidos.PED_fechasalida.Valor).ToString("dd/MM/yyyy")
        Dim FechaLlegada As String = "" : If VaDate(Pedidos.PED_FechaLlegada.Valor) > VaDate("") Then FechaLlegada = VaDate(Pedidos.PED_FechaLlegada.Valor).ToString("dd/MM/yyyy")
        Dim Matricula As String = Pedidos.PED_matriculacamion.Valor & ""


        Impreso.Cabecera.Titulo(CodCli, Col(1) + 1, altura, 13, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(CIF, Col(2) + 1, altura, 22, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(Pedido, Col(3) + 1, altura, 13, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(Ref, Col(4) + 1, altura, 20, 4, Estilos.Reducida)
        Impreso.Cabecera.Titulo(FechaPed, Col(5) + 1, altura, 21, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(FechaSal, Col(6) + 1, altura, 21, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(FechaLlegada, Col(7) + 1, altura, 21, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(Matricula, Col(8) + 1, altura, 23, 4, Estilos.Reducida, "=")
        altura = altura - 1

        If VaDate(FechaSal) > VaDate("") Then
            Dim DiaSemana As String = VaDate(FechaSal).ToString("dddd", New Globalization.CultureInfo("es-ES")).ToUpper
            Impreso.Cabecera.Titulo(DiaSemana, margen_izquierdo + 204, altura, 50, 5, Estilos.GrandeBold)
        End If
        altura = altura + 8


    End Sub



    Private Sub ImprimeDetalleOrdenConfeccion(Impreso As Impreso, ByRef altura As Integer, Pedidos As E_Pedidos, IdAlmacen As String,
                                              ByRef TotalPalets As Integer, ByRef TotalBultos As Integer, ByRef TotalPiezas As Decimal,
                                              ByRef TotalKilos As Decimal)

        Dim BaseAltura As Integer = altura

        Dim Sql As String = ""
        If VaInt(IdAlmacen) > 0 Then
            sql = "SELECT PEL_IdGenero as IdGenero, GEN_NombreGenero as Genero, PEL_NomCate as Categoria, " & vbCrLf
            sql = sql & " PEL_IdGenSal as IdPresentacion, GES_Nombre as Presentacion, CEV_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
            sql = sql & " PEL_IdMarca as IdMarcaEnvase, MarcaEnv.MAR_Nombre as MarcaEnv, PEL_IdMarcaMaterial as IdMarcaMaterial, MarcaMat.MAR_Nombre as MarcaMat," & vbCrLf
            sql = sql & " PEL_ObsLote as Lote, PEL_IdMarcaEtiqueta as IdMarcaEtiqueta, MarcaEt.MAR_Nombre as MarcaEt," & vbCrLf
            sql = sql & " PAC_IdAlmacen as IdAlmacen, PAC_Palets as Palets, PEL_BultosPalet as BxP, PEL_KilosBulto as KxB, PEL_PiezasBulto AS PxB," & vbCrLf
            sql = sql & " PEL_obsconfec1 as Instrucciones1, PEL_obsconfec2 as Instrucciones2" & vbCrLf
            sql = sql & " FROM Pedidos_Lineas" & vbCrLf
            sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = PEL_IdGenero" & vbCrLf
            sql = sql & " LEFT JOIN GenerosSalida ON GES_IdGenSal = PEL_IdGenSal" & vbCrLf
            sql = sql & " LEFT JOIN ConfecEnvase ON CEV_IdConfec = PEL_IdTipoConfeccion" & vbCrLf
            sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = CEV_IdEnvase" & vbCrLf
            sql = sql & " LEFT JOIN Marcas as MarcaEnv ON MarcaEnv.MAR_IdMarca = PEL_IdMarca" & vbCrLf
            sql = sql & " LEFT JOIN Marcas as MarcaMat ON MarcaMat.MAR_IdMarca = PEL_IdMarcaMaterial" & vbCrLf
            sql = sql & " LEFT JOIN Marcas as MarcaEt ON MarcaEt.MAR_IdMarca = PEL_IdMarcaEtiqueta" & vbCrLf
            sql = sql & " LEFT JOIN Pedidos_Almacen ON PEL_IdLinea = PAC_IdLineaPedido" & vbCrLf
            sql = sql & " WHERE PEL_IdPedido = " & Pedidos.PED_idpedido.Valor & vbCrLf
            sql = sql & " AND PAC_IdAlmacen = " & IdAlmacen & vbCrLf
            sql = sql & " ORDER BY PAC_IdAlmacen, PEL_IdLinea" & vbCrLf


        Else

            Sql = "SELECT PEL_IdGenero as IdGenero, GEN_NombreGenero as Genero, PEL_NomCate as Categoria, " & vbCrLf
            sql = sql & " PEL_IdGenSal as IdPresentacion, GES_Nombre as Presentacion, CEV_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
            sql = sql & " PEL_IdMarca as IdMarcaEnvase, MarcaEnv.MAR_Nombre as MarcaEnv, PEL_IdMarcaMaterial as IdMarcaMaterial, MarcaMat.MAR_Nombre as MarcaMat," & vbCrLf
            sql = sql & " PEL_ObsLote as Lote, PEL_IdMarcaEtiqueta as IdMarcaEtiqueta, MarcaEt.MAR_Nombre as MarcaEt," & vbCrLf
            Sql = Sql & " 0 as IdAlmacen, PEL_Palets as Palets, PEL_BultosPalet as BxP, PEL_KilosBulto as KxB, PEL_PiezasBulto AS PxB," & vbCrLf
            sql = sql & " PEL_obsconfec1 as Instrucciones1, PEL_obsconfec2 as Instrucciones2" & vbCrLf
            sql = sql & " FROM Pedidos_Lineas" & vbCrLf
            sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = PEL_IdGenero" & vbCrLf
            sql = sql & " LEFT JOIN GenerosSalida ON GES_IdGenSal = PEL_IdGenSal" & vbCrLf
            sql = sql & " LEFT JOIN ConfecEnvase ON CEV_IdConfec = PEL_IdTipoConfeccion" & vbCrLf
            sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = CEV_IdEnvase" & vbCrLf
            sql = sql & " LEFT JOIN Marcas as MarcaEnv ON MarcaEnv.MAR_IdMarca = PEL_IdMarca" & vbCrLf
            sql = sql & " LEFT JOIN Marcas as MarcaMat ON MarcaMat.MAR_IdMarca = PEL_IdMarcaMaterial" & vbCrLf
            sql = sql & " LEFT JOIN Marcas as MarcaEt ON MarcaEt.MAR_IdMarca = PEL_IdMarcaEtiqueta" & vbCrLf
            sql = sql & " WHERE PEL_IdPedido = " & Pedidos.PED_idpedido.Valor & vbCrLf
            Sql = Sql & " ORDER BY  PEL_IdLinea" & vbCrLf


        End If

        Dim dt As DataTable = Pedidos.MiConexion.ConsultaSQL(sql)


        If Not IsNothing(dt) Then


            Dim nLineas As Integer = 1

            For Each row As DataRow In dt.Rows


                If nLineas > 4 Then
                    Impreso.Detalle.SaltoPagina()
                    nLineas = 1
                    altura = BaseAltura
                End If


                Dim Genero As String = row("Genero").ToString & ""
                Dim Categoria As String = row("Categoria").ToString & ""
                Dim IdPresentacion As String = row("IdPresentacion").ToString & ""
                Dim Presentacion As String = VaInt(row("IdPresentacion")).ToString("00000") & " - " & row("Presentacion").ToString & ""
                Dim Envase As String = row("Envase").ToString & ""
                Dim MarcaEnv As String = row("MarcaEnv").ToString & ""
                Dim MarcaMat As String = row("MarcaMat").ToString & ""
                Dim Lote As String = row("Lote").ToString & ""
                Dim MarcaEt As String = row("MarcaEt").ToString & ""

                Dim Palets As Integer = VaInt(row("Palets"))
                Dim BxP As Integer = VaInt(row("BxP"))
                Dim Bultos As Integer = Palets * BxP
                Dim KxB As Decimal = VaDec(row("KxB"))
                Dim Kilos As Decimal = Bultos * KxB
                Dim PxB As Integer = VaInt(row("PxB"))
                Dim Piezas As Integer = Bultos * PxB

                Dim Instrucciones1 As String = (row("Instrucciones1").ToString & "").Trim
                Dim Instrucciones2 As String = (row("Instrucciones2").ToString & "").Trim


                TotalPalets = TotalPalets + Palets
                TotalBultos = TotalBultos + Bultos
                TotalPiezas = TotalPiezas + Piezas
                TotalKilos = TotalKilos + Kilos


                'Cuadro
                Impreso.Detalle.Cuadro(margen_izquierdo, altura, 280, alto_linea_detalle, ancho_linea, Color.Black)
                altura = altura + 2

                'Impreso.Detalle.Titulo("Producto: ", margen_izquierdo + 5, altura, 30, 6, Estilos.Grande)
                'Impreso.Detalle.Titulo(Genero, margen_izquierdo + 30 + 5, altura, 145, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Presentación: ", margen_izquierdo + 5, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Presentacion, margen_izquierdo + 30 + 5, altura, 145, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Categ./Calibre: ", margen_izquierdo + 190, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Categoria, margen_izquierdo + 190 + 30, altura, 50, 6, Estilos.GrandeBold)
                altura = altura + 6
                Impreso.Detalle.Titulo("Palets: ", margen_izquierdo + 5, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Palets.ToString("#,##0"), margen_izquierdo + 30 + 5, altura, 15, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("BxPal: ", margen_izquierdo + 50, altura, 13, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(BxP.ToString("#,##0"), margen_izquierdo + 50 + 15, altura, 15, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Bultos: ", margen_izquierdo + 85, altura, 15, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Bultos.ToString("#,##0"), margen_izquierdo + 85 + 15, altura, 15, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Piezas/B: ", margen_izquierdo + 120, altura, 19, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(PxB.ToString("#,##0"), margen_izquierdo + 120 + 19, altura, 15, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Piezas: ", margen_izquierdo + 160, altura, 15, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Piezas.ToString("#,##0"), margen_izquierdo + 160 + 15, altura, 20, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("KxBul: ", margen_izquierdo + 200, altura, 15, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(KxB.ToString("#,##0.00"), margen_izquierdo + 200 + 15, altura, 15, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Kilos: ", margen_izquierdo + 235, altura, 15, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Kilos.ToString("#,##0"), margen_izquierdo + 235 + 15, altura, 25, 6, Estilos.GrandeBold)
                altura = altura + 6
                Impreso.Detalle.Titulo("Envase: ", margen_izquierdo + 5, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Envase, margen_izquierdo + 30 + 5, altura, 135, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Marca envase: ", margen_izquierdo + 180, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(MarcaEnv, margen_izquierdo + 180 + 30, altura, 60, 6, Estilos.GrandeBold)
                altura = altura + 6
                Impreso.Detalle.Titulo("Marca material: ", margen_izquierdo + 5, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(MarcaMat, margen_izquierdo + 30 + 5, altura, 60, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Lote: ", margen_izquierdo + 105, altura, 10, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Lote, margen_izquierdo + 105 + 10 + 5, altura, 58, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Marca etiqueta: ", margen_izquierdo + 180, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(MarcaEt, margen_izquierdo + 180 + 30, altura, 60, 6, Estilos.GrandeBold)
                altura = altura + 6
                Impreso.Detalle.Titulo("Observaciones: ", margen_izquierdo + 5, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Instrucciones1 & " " & Instrucciones2, margen_izquierdo + 30 + 5, altura, 235, 6, Estilos.GrandeBold)
                altura = altura + 6
                altura = altura + 5


                nLineas = nLineas + 1

            Next


            Application.DoEvents()

            altura = altura + 5


        End If




    End Sub



    Private Sub ImprimirTotalOrdenConfeccion(Impreso As Impreso, ByRef altura As Integer,
                                             TotalPalets As Integer, TotalBultos As Integer, TotalPiezas As Integer, TotalKilos As Decimal)


        Dim altura_linea As Integer = 22
        If CompruebaSaltoPagina(altura, altura_linea) Then
            Impreso.Detalle.SaltoPagina()
            altura = altura_impreso
        End If


        Impreso.Detalle.Titulo("", margen_izquierdo, altura, 280, 4, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo("TOTAL PALETS: ", margen_izquierdo, altura, 35, 6, Estilos.Grande)
        Impreso.Detalle.Titulo(TotalPalets.ToString("#,##0"), margen_izquierdo + 35, altura, 100, 6, Estilos.GrandeBold)
        altura = altura + 6
        Impreso.Detalle.Titulo("TOTAL BULTOS: ", margen_izquierdo, altura, 35, 6, Estilos.Grande)
        Impreso.Detalle.Titulo(TotalBultos.ToString("#,##0"), margen_izquierdo + 35, altura, 100, 6, Estilos.GrandeBold)
        altura = altura + 6
        Impreso.Detalle.Titulo("TOTAL PIEZAS: ", margen_izquierdo, altura, 35, 6, Estilos.Grande)
        Impreso.Detalle.Titulo(TotalPiezas.ToString("#,##0"), margen_izquierdo + 35, altura, 100, 6, Estilos.GrandeBold)
        altura = altura + 6
        Impreso.Detalle.Titulo("TOTAL KILOS: ", margen_izquierdo, altura, 35, 6, Estilos.Grande)
        Impreso.Detalle.Titulo(TotalKilos.ToString("#,##0"), margen_izquierdo + 35, altura, 100, 6, Estilos.GrandeBold)

    End Sub


    Private Function CompruebaSaltoPagina(altura As Integer, altura_linea As Integer) As Boolean

        Dim bRes As Boolean = False

        If altura + altura_linea > Pie_linea Then
            bRes = True
        End If


        Return bRes

    End Function


End Module


