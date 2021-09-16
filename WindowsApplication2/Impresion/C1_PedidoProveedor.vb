Imports System.Drawing


Module C1_PedidoProveedor

    Dim margen_izquierdo As Integer = 6
    Dim ancho_linea As Decimal = 2
    Dim alto_linea_detalle As Integer = 34
    Dim Pie_linea As Integer = 199 '282
    Dim altura_impreso As Integer = 46


    Public Sub C1_ImprimirPedidoProveedor(IdPedido As String, TipoImpresion As TipoImpresion,
                                          Optional Impresora As String = "",
                                          Optional rutaPDF As String = "",
                                          Optional archivoPDF As String = "")


        Dim Pedidos As New E_Pedidos(Idusuario, cn)

        If Pedidos.LeerId(IdPedido) Then


            Dim altura As Integer = 7
            Dim DatosEmpresa As New DatosEmpresa




            'Separar por almacén
            Dim sql As String = "SELECT DISTINCT PEL_IdProveedor as IdAgricultor, AGR_Nombre as Agricultor" & vbCrLf
            sql = sql & " FROM Pedidos_Lineas" & vbCrLf
            sql = sql & " LEFT JOIN Agricultores ON PEL_IdProveedor = AGR_IdAgricultor" & vbCrLf
            sql = sql & " WHERE PEL_IdPedido = " & IdPedido & vbCrLf
            sql = sql & " AND COALESCE(PEL_IdProveedor,0) > 0 " & vbCrLf
            sql = sql & " ORDER BY PEL_IdProveedor" & vbCrLf



            Dim dt As DataTable = Pedidos.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then


                For Each row As DataRow In dt.Rows

                    Dim IdAgricultor As String = (row("IdAgricultor").ToString & "").Trim

                    Dim Agricultores As New E_Agricultores(Idusuario, cn)
                    If Not Agricultores.LeerId(IdAgricultor) Then
                        MsgBox("No se puede leer el agricultor con Id: " & IdAgricultor)
                        Exit Sub
                    End If


                    Dim Impreso As New Impreso()

                    Impreso.f.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
                    Impreso.f.Documento.PageLayout.PageSettings.Landscape = True
                    Impreso.f.Documento.PageLayout.PageSettings.TopMargin = "10mm"
                    Impreso.f.Documento.PageLayout.PageSettings.LeftMargin = "10mm"
                    Impreso.f.Documento.PageLayout.PageSettings.RightMargin = "10mm"
                    Impreso.f.documento.PageLayout.PageSettings.BottomMargin = "12mm"

                    Impreso.EstableceImpreso(TipoImpresion)


                    Impreso.DatosMail = ObtenerDatosMail(Pedidos, Agricultores)


                    altura = 7


                    Dim TotalPalets As Integer = 0
                    Dim TotalBultos As Integer = 0
                    Dim TotalKilos As Decimal = 0


                    
                    Try

                        'Imprimir cabecera
                        ImprimeCabeceraPedidoProveedor(Impreso, altura, Pedidos, DatosEmpresa, Agricultores)

                        'Imprimir detalle
                        ImprimeDetallePedidoProveedor(Impreso, altura, Pedidos, IdAgricultor, TotalPalets, TotalBultos, TotalKilos)

                        'Imprimir 
                        ImprimirTotalPedidoProveedor(Impreso, altura, TotalPalets, TotalBultos, TotalKilos)



                        'Impresión
                        Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)

                    Catch ex As Exception

                    End Try


                    Application.DoEvents()

                Next


            Else
                MsgBox("Error al leer las líneas del pedido con id: " & IdPedido)
            End If

        Else
            MsgBox("No se puede leer Pedido con Id: " & IdPedido)
        End If

    End Sub


    Private Function ObtenerDatosMail(ByVal Pedido As E_Pedidos, ByVal Agricultor As E_Agricultores) As DatosMail

        Dim DestinatarioFax As String = ""

        Dim DestinatariosMail As New List(Of String)
        Dim Email As String = Agricultor.AGR_Mail.Valor
        DestinatariosMail.Add(Email)

        Dim NumPedido As String = Pedido.PED_pedido.Valor
        Dim PV As String = Pedido.PED_idpuntoventa.Valor
        Dim Referencia As String = Pedido.PED_referencia.Valor
        Dim NombreDocumento As String = "Pedido_" & PV & "_" & NumPedido & ".pdf"

        ' Añado los datos al email
        Dim Asunto As String = "Pedido nº: " & PV & "-" & NumPedido
        If Referencia.Trim <> "" Then Asunto = Asunto & " / Ref.: " & Referencia
        Dim Body As String = ""

        
        Return New DatosMail(DestinatariosMail, DestinatarioFax, Asunto, Body, Nothing, NombreDocumento)

    End Function



    Private Sub ImprimeCabeceraPedidoProveedor(Impreso As Impreso, ByRef altura As Integer, Pedidos As E_Pedidos, DatosEmpresa As DatosEmpresa, Agricultores As E_Agricultores)

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
        Impreso.Cabecera.Titulo("PEDIDO A PROVEEDOR", margen_izquierdo, altura + 5, 275, 7, Estilos.Cabecera, "=")


        Impreso.Cabecera.Cuadro(margen_izquierdo + 180, altura, 100, 28, ancho_linea, Color.Black)

        Dim NombreProveedor As String = Agricultores.AGR_Nombre.Valor & ""
        Dim Domicilio As String = Agricultores.AGR_Domicilio.Valor
        Dim CP As String = Agricultores.AGR_Cpostal.Valor
        Dim Poblacion As String = Agricultores.AGR_Poblacion.Valor
        Dim provincia As String = Agricultores.AGR_Provincia.Valor
        Dim Pais As String = ""
        Dim Paises As New E_Paises(Idusuario, CnComun)
        If Paises.LeerId(Agricultores.AGR_IdPais.Valor) Then
            Pais = (Paises.Nombre.Valor & "").Trim
        End If


        Impreso.Cabecera.Titulo(NombreProveedor, margen_izquierdo + 180 + 2, altura + 2, 96, 5, Estilos.NormalBold)
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


        Dim CodAgr As String = VaInt(Agricultores.AGR_IdAgricultor.Valor).ToString("00000")
        Dim CIF As String = Agricultores.AGR_Nif.Valor & ""
        Dim Pedido As String = VaInt(Pedidos.PED_pedido.Valor).ToString("000000")
        Dim Ref As String = Pedidos.PED_referencia.Valor & ""
        Dim FechaPed As String = "" : If VaDate(Pedidos.PED_fechapedido.Valor) > VaDate("") Then FechaPed = VaDate(Pedidos.PED_fechapedido.Valor).ToString("dd/MM/yyyy")
        Dim FechaSal As String = "" : If VaDate(Pedidos.PED_fechasalida.Valor) > VaDate("") Then FechaSal = VaDate(Pedidos.PED_fechasalida.Valor).ToString("dd/MM/yyyy")
        Dim Matricula As String = Pedidos.PED_matriculacamion.Valor & ""


        Impreso.Cabecera.Titulo(CodAgr, Col(1) + 1, altura, 13, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(CIF, Col(2) + 1, altura, 22, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(Pedido, Col(3) + 1, altura, 13, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(Ref, Col(4) + 1, altura, 20, 4, Estilos.Reducida)
        Impreso.Cabecera.Titulo(FechaPed, Col(5) + 1, altura, 21, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(FechaSal, Col(6) + 1, altura, 21, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(Matricula, Col(8) + 1, altura, 23, 4, Estilos.Reducida, "=")
        altura = altura - 1

        If VaDate(FechaSal) > VaDate("") Then
            Dim DiaSemana As String = VaDate(FechaSal).ToString("dddd", New Globalization.CultureInfo("es-ES")).ToUpper
            Impreso.Cabecera.Titulo(DiaSemana, margen_izquierdo + 204, altura, 50, 5, Estilos.GrandeBold)
        End If
        altura = altura + 8


    End Sub



    Private Sub ImprimeDetallePedidoProveedor(Impreso As Impreso, ByRef altura As Integer, Pedidos As E_Pedidos, IdAgricultor As String,
                                              ByRef TotalPalets As Integer, ByRef TotalBultos As Integer, ByRef TotalKilos As Decimal)

        Dim BaseAltura As Integer = altura


        Dim sql As String = "SELECT PEL_IdGenero as IdGenero, GEN_NombreGenero as Genero, PEL_NomCate as Categoria, " & vbCrLf
        sql = sql & " PEL_IdGenSal as IdPresentacion, GES_Nombre as Presentacion, CEV_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
        sql = sql & " PEL_IdMarca as IdMarcaEnvase, MarcaEnv.MAR_Nombre as MarcaEnv, PEL_IdMarcaMaterial as IdMarcaMaterial, MarcaMat.MAR_Nombre as MarcaMat," & vbCrLf
        sql = sql & " PEL_ObsLote as Lote, PEL_IdMarcaEtiqueta as IdMarcaEtiqueta, MarcaEt.MAR_Nombre as MarcaEt," & vbCrLf
        sql = sql & " PEL_paletsproveedor as Palets, PEL_BultosPalet as BxP, PEL_KilosBulto as KxB, PEL_precioproveedor as Precio, " & vbCrLf
        sql = sql & " PEL_TipoPrecio as TipoPrecio, CPA_Nombre as TipoPalet" & vbCrLf
        sql = sql & " FROM Pedidos_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = PEL_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN GenerosSalida ON GES_IdGenSal = PEL_IdGenSal" & vbCrLf
        sql = sql & " LEFT JOIN ConfecEnvase ON CEV_IdConfec = PEL_IdTipoConfeccion" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = CEV_IdEnvase" & vbCrLf
        sql = sql & " LEFT JOIN Marcas as MarcaEnv ON MarcaEnv.MAR_IdMarca = PEL_IdMarca" & vbCrLf
        sql = sql & " LEFT JOIN Marcas as MarcaMat ON MarcaMat.MAR_IdMarca = PEL_IdMarcaMaterial" & vbCrLf
        sql = sql & " LEFT JOIN Marcas as MarcaEt ON MarcaEt.MAR_IdMarca = PEL_IdMarcaEtiqueta" & vbCrLf
        sql = sql & " LEFT JOIN ConfecPalet ON CPA_IdConfec = PEL_IdTipoPalet" & vbCrLf
        sql = sql & " WHERE PEL_IdPedido = " & Pedidos.PED_idpedido.Valor & vbCrLf
        sql = sql & " AND PEL_IdProveedor = " & IdAgricultor & vbCrLf
        sql = sql & " ORDER BY PEL_IdProveedor, PEL_IdLinea" & vbCrLf


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
                Dim TipoPrecio As String = (row("TipoPrecio").ToString & "").Trim
                Dim TipoPalet As String = (row("TipoPalet").ToString & "").Trim

                Dim Palets As Integer = VaInt(row("Palets"))
                Dim BxP As Integer = VaInt(row("BxP"))
                Dim Bultos As Integer = Palets * BxP
                Dim KxB As Decimal = VaDec(row("KxB"))
                Dim Kilos As Decimal = Bultos * KxB
                Dim Precio As Decimal = VaDec(row("Precio"))

                TotalPalets = TotalPalets + Palets
                TotalBultos = TotalBultos + Bultos
                TotalKilos = TotalKilos + Kilos


                'Cuadro
                Impreso.Detalle.Cuadro(margen_izquierdo, altura, 280, alto_linea_detalle, ancho_linea, Color.Black)
                altura = altura + 2

                Impreso.Detalle.Titulo("Producto: ", margen_izquierdo + 5, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Genero, margen_izquierdo + 30 + 5, altura, 145, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Categ./Calibre: ", margen_izquierdo + 190, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Categoria, margen_izquierdo + 190 + 30, altura, 50, 6, Estilos.GrandeBold)
                altura = altura + 6
                Impreso.Detalle.Titulo("Presentación: ", margen_izquierdo + 5, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Presentacion, margen_izquierdo + 30 + 5, altura, 235, 6, Estilos.GrandeBold)
                altura = altura + 6
                Impreso.Detalle.Titulo("Palets: ", margen_izquierdo + 5, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Palets.ToString("#,##0"), margen_izquierdo + 30 + 5, altura, 30, 6, Estilos.GrandeBold)

                Impreso.Detalle.Titulo("BxPal: ", margen_izquierdo + 50, altura, 13, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(BxP.ToString("#,##0"), margen_izquierdo + 50 + 15, altura, 15, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Bultos: ", margen_izquierdo + 85, altura, 15, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Bultos.ToString("#,##0"), margen_izquierdo + 85 + 15, altura, 30, 6, Estilos.GrandeBold)

                Impreso.Detalle.Titulo("Kilos: ", margen_izquierdo + 130, altura, 15, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Kilos.ToString("#,##0"), margen_izquierdo + 130 + 15, altura, 30, 6, Estilos.GrandeBold)

                Impreso.Detalle.Titulo("Tipo Palet: ", margen_izquierdo + 160, altura, 25, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(TipoPalet, margen_izquierdo + 160 + 25, altura, 80, 6, Estilos.GrandeBold)


                altura = altura + 6
                Impreso.Detalle.Titulo("Envase: ", margen_izquierdo + 5, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Envase, margen_izquierdo + 30 + 5, altura, 135, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("M. Envase: ", margen_izquierdo + 160, altura, 25, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(MarcaEnv, margen_izquierdo + 160 + 25, altura, 50, 6, Estilos.GrandeBold)
                altura = altura + 6
                Impreso.Detalle.Titulo("Marca material: ", margen_izquierdo + 5, altura, 30, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(MarcaMat, margen_izquierdo + 30 + 5, altura, 50, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Lote: ", margen_izquierdo + 95, altura, 10, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(Lote, margen_izquierdo + 95 + 10 + 5, altura, 48, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("M. Etiqueta: ", margen_izquierdo + 160, altura, 25, 6, Estilos.Grande)
                Impreso.Detalle.Titulo(MarcaEt, margen_izquierdo + 160 + 25, altura, 50, 6, Estilos.GrandeBold)
                Impreso.Detalle.Titulo("Precio: ", margen_izquierdo + 237, altura, 15, 6, Estilos.Grande)


                Impreso.Detalle.Titulo(Precio.ToString("#,##0.0000") & " " & TipoPrecio, margen_izquierdo + 237 + 15, altura, 25, 6, Estilos.GrandeBold)


                altura = altura + 6
                altura = altura + 5


                nLineas = nLineas + 1


                Application.DoEvents()

            Next

            altura = altura + 5


        End If




    End Sub



    Private Sub ImprimirTotalPedidoProveedor(Impreso As Impreso, ByRef altura As Integer,
                                             TotalPalets As Integer, TotalBultos As Integer, TotalKilos As Decimal)


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


