Imports System.Drawing
Imports DevExpress.XtraEditors


Module C1_ProformaPedido

    Private margen_izquierdo As Integer = 9
    Dim ancho_linea As Decimal = 2
    Dim Pie_linea As Integer = 282

    Dim fuente_envase As New Font("Tahoma", 8, FontStyle.Italic)
    Dim fuente As New Font("Tahoma", 7, FontStyle.Regular)
    Dim fuente_negrita As New Font("Tahoma", 7, FontStyle.Bold)

    Dim altura_impreso As Integer = 79


#Region "Clases"

    Private Class LineaDesglosePedido

        Public Presentacion As String = ""
        Public Genero As String = ""
        Public Confeccion As String = ""
        Public Categoria As String = ""
        Public Marca As String = ""
        Public Bultos As Integer = 0
        Public Piezas As Integer = 0
        Public Kilos As Decimal = 0
        Public KilosBrutos As Decimal = 0
        Public Precio As Decimal = 0
        Public TipoPrecio As String = ""
        Public Importe As Decimal = 0

        Public Sub New(Presentacion As String, Genero As String, Confeccion As String, Categoria As String, Marca As String, Bultos As Integer, Piezas As Integer,
                       Kilos As Decimal, KilosBrutos As Decimal, Precio As Decimal, TipoPrecio As String, Importe As Decimal)

            Me.Presentacion = Presentacion
            Me.Genero = Genero
            Me.Confeccion = Confeccion
            Me.Categoria = Categoria
            Me.Marca = Marca
            Me.Bultos = Bultos
            Me.Piezas = Piezas
            Me.Kilos = Kilos
            Me.KilosBrutos = KilosBrutos
            Me.Precio = Precio
            Me.TipoPrecio = TipoPrecio
            Me.Importe = Importe

        End Sub

    End Class

#End Region



#Region "Proforma"


    Public Sub C1_ImprimirProformaPedido(IdPedido As String, TipoImpresion As TipoImpresion,
                                          Optional Impresora As String = "",
                                          Optional rutaPDF As String = "",
                                          Optional archivoPDF As String = "")


        Dim err As New Errores
        Dim Pedidos As New E_Pedidos(Idusuario, cn)

        If Pedidos.LeerId(IdPedido) Then


            Dim Clientes As New E_Clientes(Idusuario, cn)
            If Not Clientes.LeerId(Pedidos.PED_idcliente.Valor) Then
                MsgBox("Error al leer los datos del cliente con Id: " & Pedidos.PED_idcliente.Valor)
                Exit Sub
            End If

            'Datos Cabecera
            Dim DatosEmpresa As New DatosEmpresa


            Dim Impreso As New Impreso()

            Impreso.f.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
            Impreso.f.Documento.PageLayout.PageSettings.Landscape = False
            Impreso.f.Documento.PageLayout.PageSettings.TopMargin = "10mm"
            Impreso.f.Documento.PageLayout.PageSettings.LeftMargin = "10mm"
            Impreso.f.documento.PageLayout.PageSettings.BottomMargin = "10mm"

            Impreso.EstableceImpreso(TipoImpresion)


            'Cabecera factura
            Dim Col As New List(Of Integer)
            Col.Add(0)
            Col.Add(margen_izquierdo)   'Col1
            Col.Add(Col(1) + 50)        'Col2
            Col.Add(Col(2) + 17)        'Col3
            Col.Add(Col(3) + 21)        'Col4
            Col.Add(Col(4) + 15)        'Col5
            Col.Add(Col(5) + 18)        'Col6
            Col.Add(Col(6) + 17)        'Col7
            Col.Add(Col(7) + 17)        'Col8
            Col.Add(Col(8) + 16)        'Col9


            'Cabecera
            Dim BaseLineas As Integer = 0
            Dim altura As Integer = 7

            
            'Detalle y totales detalle
            Dim TotalBultos As Decimal = 0
            Dim TotalPiezas As Decimal = 0
            Dim TotalKgNetos As Decimal = 0
            Dim TotalKgBrutos As Decimal = 0
            Dim TotalImporte As Decimal = 0


            Try

                'Imprime cabecera
                ImprimeCabeceraProformaPedido(Impreso, altura, Pedidos, Clientes, DatosEmpresa, Col, BaseLineas)


                'Imprime detalle
                ImprimeDetalleProformaPedido(Impreso, IdPedido, altura, BaseLineas, Col, TotalBultos, TotalPiezas, TotalKgNetos, TotalKgBrutos, TotalImporte)

                'Totales
                ImprimeTotalesProformaPedido(Impreso, altura, Pedidos, Clientes, Col, TotalBultos, TotalPiezas, TotalKgNetos, TotalKgBrutos, TotalImporte)

                'Pie
                ImprimePieProformaPedido(Impreso, DatosEmpresa, altura, Pedidos, Clientes)




                'Impresión / previsualización / exportación
                Select Case TipoImpresion

                    Case NetAgro.TipoImpresion.Preliminar
                        Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)

                    Case NetAgro.TipoImpresion.ExportacionPDF
                        Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)

                    Case Else

                        Dim valoresusuario As New E_valoresusuario(Idusuario, cn)

                        If valoresusuario.LeerId(Idusuario) Then
                            Impresora = valoresusuario.VUS_ImpresoraFacturasClientes.Valor
                            Impreso.Imprimir(NetAgro.TipoImpresion.ImpresoraSeleccionada, Impresora, rutaPDF, archivoPDF)
                        Else
                            Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)
                        End If

                End Select



            Catch ex As Exception

            End Try


        Else
            XtraMessageBox.Show("Error al leer el pedido con id: " & IdPedido, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub



    Private Sub ImprimeCabeceraProformaPedido(ByRef Impreso As Impreso, ByRef altura As Integer,
                                              Pedidos As E_Pedidos, Clientes As E_Clientes, DatosEmpresa As DatosEmpresa,
                                              Col As List(Of Integer), ByRef BaseLineasDetalle As Integer)



        Dim FechaFactura As String = ""
        If VaDate(Pedidos.PED_fechapedido.Valor) > VaDate("") Then FechaFactura = VaDate(Pedidos.PED_fechapedido.Valor).ToString("dd/MM/yyyy")

        Dim CE As String = (Pedidos.PED_idcentro.Valor & "").Trim
        Dim NumPedido As String = (Pedidos.PED_pedido.Valor & "").Trim
        If CE <> "" Then NumPedido = CE & "-" & NumPedido

        Dim Referencia As String = (Pedidos.PED_referencia.Valor & "").Trim


        'Logo
        Dim fichero_logo As String = "logo.png"

        Select Case MiMaletin.IdEmpresaCTB
            Case 1
                fichero_logo = "logo.png"
            Case Else
                fichero_logo = "logo_" & MiMaletin.IdEmpresaCTB.ToString & ".png"
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




        altura = altura + 7
        Impreso.Cabecera.Titulo(DatosEmpresa.NombreEmpresa, 117, altura - 9, 90, 5, Estilos.NormalBold)
        altura = altura + 5
        Impreso.Cabecera.Titulo(DatosEmpresa.FilaDatos(), 117, altura - 9, 90, 98, Estilos.MinimaBold)


        altura = altura + 12

        Impreso.Cabecera.Titulo("FACTURA PROFORMA", 117, altura, 90, 7, Estilos.GrandeBold)

        altura = altura + 5
        'If DatosCabecera.EsCopia Then
        '    Impreso.Cabecera.Titulo("##### COPIA #####", 135, altura, 52, 5, Estilos.GrandeBold)
        'End If
        altura = altura + 1

        Dim Pais As String = ""
        If VaInt(Clientes.CLI_IdPais.Valor) > 0 Then
            Dim Paises As New E_Paises(Idusuario, CnComun)
            If Paises.LeerId(Clientes.CLI_IdPais.Valor) Then
                Pais = Paises.Nombre.Valor
            End If
        End If


        'Impreso.Cabecera.Cuadro(margen_izquierdo, altura, 100, 32, ancho_linea, Color.Black)
        'Impreso.Cabecera.Titulo(Clientes.CLI_Nombre.Valor & "", margen_izquierdo + 5, altura + 1, 91, 5, Estilos.GrandeBold)
        'Impreso.Cabecera.Titulo(Clientes.CLI_Domicilio.Valor & "", margen_izquierdo + 5, altura + 7, 91, 5, Estilos.GrandeBold)
        'Impreso.Cabecera.Titulo(Clientes.CLI_CPostal.Valor & " " & Clientes.CLI_Poblacion.Valor & "", margen_izquierdo + 5, altura + 13, 91, 5, Estilos.GrandeBold)
        'Impreso.Cabecera.Titulo(Clientes.CLI_Provincia.Valor, margen_izquierdo + 5, altura + 19, 91, 5, Estilos.GrandeBold)
        'Impreso.Cabecera.Titulo(Pais, margen_izquierdo + 5, altura + 25, 91, 5, Estilos.GrandeBold)
        Impreso.Cabecera.Cuadro(margen_izquierdo, altura, 100, 32, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo(Clientes.CLI_Nombre.Valor & "", margen_izquierdo + 5, altura + 1, 91, 5, Estilos.GrandeBold)
        Impreso.Cabecera.Titulo(Clientes.CLI_Domicilio.Valor & "", margen_izquierdo + 5, altura + 6, 91, 5, Estilos.GrandeBold)
        Impreso.Cabecera.Titulo(Clientes.CLI_CPostal.Valor & " " & Clientes.CLI_Poblacion.Valor & "", margen_izquierdo + 5, altura + 11, 91, 5, Estilos.GrandeBold)
        Impreso.Cabecera.Titulo(Clientes.CLI_Provincia.Valor, margen_izquierdo + 5, altura + 16, 91, 5, Estilos.GrandeBold)
        Impreso.Cabecera.Titulo(Pais, margen_izquierdo + 5, altura + 21, 91, 5, Estilos.GrandeBold)
        Impreso.Cabecera.Titulo("Nº Reg.: " & Clientes.CLI_NumeroRegistro.Valor, margen_izquierdo + 5, altura + 26, 91, 5, Estilos.NormalBold)
        altura = altura + 4


        Impreso.Cabecera.Cuadro(120 + 25, altura, 50, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaH(120 + 25, altura + 5, 50, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(170, altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo("FECHA FRA.", 148, altura + 1, 22, 5, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo(FechaFactura, 146, altura + 6, 23, 5, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo("PEDIDO", 175, altura + 1, 22, 5, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo(NumPedido, 175, altura + 6, 26, 5, Estilos.Reducida, "=")
        altura = altura + 13

        Impreso.Cabecera.Cuadro(120, altura, 75, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaH(120, altura + 5, 75, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(145, altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(170, altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo("REF. FACTURA", 123, altura + 1, 22, 5, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo(Referencia, 121, altura + 6, 23, 5, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo("N.I.F.", 148, altura + 1, 22, 5, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo(Clientes.CLI_Nif.Valor & "", 146, altura + 6, 23, 5, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo("CODIGO", 175, altura + 1, 22, 5, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo(VaInt(Pedidos.PED_idcliente.Valor).ToString("00000"), 171, altura + 6, 24, 5, Estilos.Reducida, "=")
        altura = altura + 10 + 3 + 5


        'Solo le pasamos Col si queremos imprimir la cabecera del detalle
        If Not IsNothing(Col) Then

            'Guardo el principio del detalle para dibujar luego las lineas verticales laterales de la factura
            BaseLineasDetalle = altura

            Impreso.Cabecera.LineaH(margen_izquierdo, altura, 190, ancho_linea, Color.Black)
            Impreso.Cabecera.LineaH(margen_izquierdo, altura + 5, 190, ancho_linea, Color.Black)
            Impreso.Cabecera.Titulo("Producto", Col(1) + 1, altura + 1, 18, 5, Estilos.ReducidaBold)
            Impreso.Cabecera.Titulo("Cat/Cal", Col(2), altura + 1, 55, 5, Estilos.ReducidaBold)
            Impreso.Cabecera.Titulo("Marca", Col(3), altura + 1, 20, 5, Estilos.ReducidaBold)
            Impreso.Cabecera.Titulo("Bultos", Col(4), altura + 1, 14, 5, Estilos.ReducidaBold, ">")
            Impreso.Cabecera.Titulo("Piezas", Col(5), altura + 1, 17, 5, Estilos.ReducidaBold, ">")
            Impreso.Cabecera.Titulo("K.Netos", Col(6), altura + 1, 16, 5, Estilos.ReducidaBold, ">")
            Impreso.Cabecera.Titulo("K.Brutos", Col(7), altura + 1, 16, 5, Estilos.ReducidaBold, ">")
            Impreso.Cabecera.Titulo("Precio", Col(8), altura + 1, 15, 5, Estilos.ReducidaBold, ">")
            Impreso.Cabecera.Titulo("Importe", Col(9), altura + 1, 17, 5, Estilos.ReducidaBold, ">")

            altura = altura + 5
            altura = altura + 2

        End If



    End Sub


    Private Sub ImprimeDetalleProformaPedido(ByRef Impreso As Impreso, IdPedido As String, ByRef altura As Integer,
                                           BaseLineas As Integer, Col As List(Of Integer), ByRef TotalBultos As Decimal,
                                           ByRef TotalPiezas As Decimal, ByRef TotalKgNetos As Decimal, ByRef TotalKgBrutos As Decimal,
                                           ByRef TotalImporte As Decimal)


        'Líneas Detalle
        Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)
        Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
        Dim CategoriasComercial As New E_CategoriasComercial(Idusuario, cn)
        Dim Marcas As New E_Marcas(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)



        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Pedidos_Lineas.PEL_idlinea, "IdLinea")
        consulta.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", Pedidos_Lineas.PEL_idgensal)
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Pedidos_Lineas.PEL_idgenero)
        consulta.SelCampo(ConfecEnvase.CEV_Nombre, "Confeccion", Pedidos_Lineas.PEL_idtipoconfeccion)
        consulta.SelCampo(CategoriasComercial.CAC_Nombre, "Categoria", Pedidos_Lineas.PEL_idcategoria)
        consulta.SelCampo(Marcas.MAR_Nombre, "Marca", Pedidos_Lineas.PEL_idmarca)
        consulta.SelCampo(Pedidos_Lineas.PEL_Bultos, "Bultos")
        consulta.SelCampo(Pedidos_Lineas.PEL_piezas, "Piezas")
        consulta.SelCampo(Pedidos_Lineas.PEL_kilos, "Kilos")
        consulta.SelCampo(Pedidos_Lineas.PEL_KilosBrutos, "KilosBrutos")
        consulta.SelCampo(Pedidos_Lineas.PEL_precio, "Precio")
        consulta.SelCampo(Pedidos_Lineas.PEL_tipoprecio, "TipoPrecio")
        consulta.WheCampo(Pedidos_Lineas.PEL_idpedido, "=", IdPedido)



        Dim dt As DataTable = Pedidos_Lineas.MiConexion.ConsultaSQL(consulta.SQL)


        'Líneas del albarán
        For Each row As DataRow In dt.Rows

            Dim Genero As String = (row("Genero").ToString & "").Trim
            Dim Confeccion As String = (row("Confeccion").ToString & "").Trim
            Dim Categoria As String = (row("Categoria").ToString & "").Trim
            Dim Marca As String = (row("Marca").ToString & "").Trim
            Dim Presentacion As String = (row("Presentacion").ToString & "").Trim
            Dim Bultos As Decimal = VaInt(row("Bultos"))
            Dim Piezas As Decimal = VaInt(row("Piezas"))
            Dim Kilos As Decimal = VaDec(row("Kilos"))
            Dim KilosBrutos As Decimal = VaDec(row("KilosBrutos"))
            Dim Precio As Decimal = VaDec(row("Precio"))
            Dim TipoPrecio As String = (row("TipoPrecio").ToString & "").Trim

            Dim Importe As Decimal = 0

            Select Case TipoPrecio

                Case "K"
                    Importe = Precio * Kilos
                Case "B"
                    Importe = Precio * Bultos
                Case "P"
                    Importe = Precio * Piezas

            End Select



            Dim linea As New LineaDesglosePedido(Presentacion, Genero, Confeccion, Categoria, Marca, Bultos, Piezas, Kilos, KilosBrutos, Precio, TipoPrecio, Importe)
            ImprimeLineaProformaPedido(Impreso, linea, altura, Col)


            TotalBultos = TotalBultos + Bultos
            TotalPiezas = TotalPiezas + Piezas
            TotalKgNetos = TotalKgNetos + Kilos
            TotalKgBrutos = TotalKgBrutos + KilosBrutos
            TotalImporte = TotalImporte + Importe

            Application.DoEvents()

        Next


        altura = altura + 4




        altura = altura + 1



        Dim alto_detalle As Integer = altura - BaseLineas
        If alto_detalle < 123 Then
            altura = BaseLineas + 123
        End If



        'Líneas laterales
        Impreso.Detalle.LineaH(margen_izquierdo, altura, 190, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(margen_izquierdo, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(margen_izquierdo + 190, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)

        altura = altura + 2



    End Sub


    Private Sub ImprimeLineaProformaPedido(ByRef Impreso As Impreso, linea As LineaDesglosePedido, ByRef altura As Integer,
                                         Col As List(Of Integer))

        Dim altura_linea As Integer = 4

        If linea.Presentacion.Trim = "" Then
            Impreso.Detalle.Titulo(linea.Genero & "_" & linea.Confeccion, Col(1) + 1, altura, 49, altura_linea, Estilos.Reducida)

        Else
            Impreso.Detalle.Titulo(linea.Presentacion, Col(1) + 1, altura, 49, altura_linea, Estilos.Reducida)

        End If
        Impreso.Detalle.Titulo(linea.Categoria, Col(2), altura, 16, altura_linea, Estilos.Reducida)
        Impreso.Detalle.Titulo(linea.Marca, Col(3), altura, 20, altura_linea, Estilos.Reducida)
        If linea.Bultos <> 0 Then Impreso.Detalle.Titulo(linea.Bultos.ToString("#,##0"), Col(4), altura, 14, altura_linea, Estilos.Reducida, ">")
        If linea.Piezas <> 0 Then Impreso.Detalle.Titulo(linea.Piezas.ToString("#,##0"), Col(5), altura, 17, altura_linea, Estilos.Reducida, ">")
        If linea.Kilos <> 0 Then Impreso.Detalle.Titulo(linea.Kilos.ToString("#,##0"), Col(6), altura, 16, altura_linea, Estilos.Reducida, ">")
        If linea.KilosBrutos <> 0 Then Impreso.Detalle.Titulo(linea.KilosBrutos.ToString("#,##0"), Col(7), altura, 16, altura_linea, Estilos.Reducida, ">")
        If linea.Precio <> 0 Then Impreso.Detalle.Titulo(linea.Precio.ToString("#,##0.00000") & " " & linea.TipoPrecio, Col(8), altura, 15, altura_linea, Estilos.Reducida, ">")
        If linea.Importe <> 0 Then Impreso.Detalle.Titulo(linea.Importe.ToString("#,##0.00"), Col(9), altura, 17, altura_linea, Estilos.Reducida, ">")

        altura = altura + altura_linea


    End Sub


    Private Sub ImprimeTotalesProformaPedido(ByRef Impreso As Impreso, ByRef altura As Integer, Pedidos As E_Pedidos, Clientes As E_Clientes,
                                           Col As List(Of Integer), TotalBultos As Decimal, TotalPiezas As Decimal,
                                           TotalKgNetos As Decimal, TotalKgBrutos As Decimal, TotalImporte As Decimal)


        Impreso.Detalle.Titulo("MAT. REMOLQUE: ", margen_izquierdo, altura, 28, 5, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo(Pedidos.PED_matricularemolque.Valor & "", margen_izquierdo + 28, altura, 40, 5, Estilos.Reducida)

        Impreso.Detalle.Titulo("MÓV. CONDUCTOR: ", margen_izquierdo, altura + 4, 28, 5, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo(Pedidos.PED_MovilChofer.Valor & "", margen_izquierdo + 31, altura + 4, 40, 5, Estilos.Reducida)


        Dim base1 As Decimal = 0
        Dim base2 As Decimal = 0
        Dim base3 As Decimal = 0

        base1 = TotalImporte


        Dim iva1 As Decimal = 0
        Dim iva2 As Decimal = 0
        Dim iva3 As Decimal = 0

        Dim re1 As Decimal = 0
        Dim re2 As Decimal = 0
        Dim re3 As Decimal = 0

        CalculaIvaRet(Clientes, iva1, iva2, iva3, re1, re2, re3)

        Dim cuotaIva1 As Decimal = base1 * iva1 / 100
        Dim cuotaIva2 As Decimal = base2 * iva2 / 100
        Dim cuotaIva3 As Decimal = base3 * iva3 / 100

        Dim cuotaRe1 As Decimal = base1 * re1 / 100
        Dim cuotaRe2 As Decimal = base2 * re2 / 100
        Dim cuotaRe3 As Decimal = base3 * re3 / 100

        Dim Cambio As Decimal = VaDec(Pedidos.PED_valorcambio.Valor)



        'Totales Bultos, Piezas, Kg, Importe
        Impreso.Detalle.Cuadro(Col(4) - 5, altura, 107, 5, ancho_linea, Color.Black)
        altura = altura + 1

        'Impreso.Detalle.Titulo(Factura.FRA_obs1.Valor & "", margen_izquierdo + 5, altura - 10, 100, 6, Estilos.MinimaBold)
        'Impreso.Detalle.Titulo(Factura.FRA_obs2.Valor & "", margen_izquierdo + 5, altura - 7, 100, 6, Estilos.MinimaBold)

        If TotalBultos <> 0 Then Impreso.Detalle.Titulo(TotalBultos.ToString("#,##0"), Col(4), altura, 12, 4, Estilos.Reducida, ">")
        If TotalPiezas <> 0 Then Impreso.Detalle.Titulo(TotalPiezas.ToString("#,##0"), Col(5), altura, 11, 4, Estilos.Reducida, ">")
        If TotalKgNetos <> 0 Then Impreso.Detalle.Titulo(TotalKgNetos.ToString("#,##0"), Col(6), altura, 14, 4, Estilos.Reducida, ">")
        If TotalKgbrutos <> 0 Then Impreso.Detalle.Titulo(TotalKgbrutos.ToString("#,##0"), Col(7), altura, 14, 4, Estilos.Reducida, ">")
        If TotalImporte <> 0 Then Impreso.Detalle.Titulo(TotalImporte.ToString("#,##0.00"), Col(9), altura, 17, 4, Estilos.Reducida, ">")


        altura = altura + 6


        'Comprueba salto de linea
        Dim altura_linea As Integer = 31
        If CompruebaSaltoPagina(altura, altura_linea) Then
            Impreso.Detalle.SaltoPagina()
            altura = altura_impreso
        End If


        Impreso.Detalle.Titulo("Base Imponible", 60, altura, 26, 3, Estilos.MinimaBold, "=")
        Impreso.Detalle.Titulo("%", 87, altura, 9, 3, Estilos.MinimaBold, "=")
        Impreso.Detalle.Titulo("Importe I.V.A.", 97, altura, 26, 3, Estilos.MinimaBold, "=")
        Impreso.Detalle.Titulo("%", 124, altura, 9, 3, Estilos.MinimaBold, "=")
        Impreso.Detalle.Titulo("Importe R.E.", 134, altura, 26, 3, Estilos.MinimaBold, "=")


        altura = altura + 3

        Impreso.Detalle.LineaH(59, altura, 101, ancho_linea, Color.Black)
        Impreso.Detalle.LineaH(59, altura + 15, 101, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(59, altura, 15, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(86, altura, 15, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(96, altura, 15, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(123, altura, 15, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(133, altura, 15, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(160, altura, 15, ancho_linea, Color.Black)

        Impreso.Detalle.LineaH(165, altura, 34, ancho_linea, Color.Black)
        Impreso.Detalle.LineaH(165, altura + 15, 34, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(165, altura, 15, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(199, altura, 15, ancho_linea, Color.Black)




        'Bases
        If VaDec(base1) <> 0 Then Impreso.Detalle.Titulo(VaDec(base1).ToString("#,##0.00"), 59, altura + 1, 24, 5, Estilos.Reducida, ">")
        If VaDec(base2) <> 0 Then Impreso.Detalle.Titulo(VaDec(base2).ToString("#,##0.00"), 59, altura + 5, 24, 5, Estilos.Reducida, ">")
        If VaDec(base3) <> 0 Then Impreso.Detalle.Titulo(VaDec(base3).ToString("#,##0.00"), 59, altura + 9, 24, 5, Estilos.Reducida, ">")

        '%IVA
        If VaDec(iva1) <> 0 And VaDec(cuotaIva1) <> 0 Then Impreso.Detalle.Titulo(VaDec(iva1).ToString("#,##0.00"), 85, altura + 1, 10, 5, Estilos.Reducida, ">")
        If VaDec(iva2) <> 0 And VaDec(cuotaIva2) <> 0 Then Impreso.Detalle.Titulo(VaDec(iva2).ToString("#,##0.00"), 85, altura + 5, 10, 5, Estilos.Reducida, ">")
        If VaDec(iva3) <> 0 And VaDec(cuotaIva3) <> 0 Then Impreso.Detalle.Titulo(VaDec(iva3).ToString("#,##0.00"), 85, altura + 9, 10, 5, Estilos.Reducida, ">")

        'CuotaIVA
        If VaDec(cuotaIva1) <> 0 Then Impreso.Detalle.Titulo(VaDec(cuotaIva1).ToString("#,##0.00"), 96, altura + 1, 22, 5, Estilos.Reducida, ">")
        If VaDec(cuotaIva2) <> 0 Then Impreso.Detalle.Titulo(VaDec(cuotaIva2).ToString("#,##0.00"), 96, altura + 5, 22, 5, Estilos.Reducida, ">")
        If VaDec(cuotaIva3) <> 0 Then Impreso.Detalle.Titulo(VaDec(cuotaIva3).ToString("#,##0.00"), 96, altura + 9, 22, 5, Estilos.Reducida, ">")

        '%RE
        If VaDec(re1) <> 0 And VaDec(cuotaRe1) <> 0 Then Impreso.Detalle.Titulo(VaDec(re1).ToString("#,##0.00"), 122, altura + 1, 10, 5, Estilos.Reducida, ">")
        If VaDec(re2) <> 0 And VaDec(cuotaRe1) <> 0 Then Impreso.Detalle.Titulo(VaDec(re2).ToString("#,##0.00"), 122, altura + 5, 10, 5, Estilos.Reducida, ">")
        If VaDec(re3) <> 0 And VaDec(cuotaRe3) <> 0 Then Impreso.Detalle.Titulo(VaDec(re3).ToString("#,##0.00"), 122, altura + 9, 10, 5, Estilos.Reducida, ">")

        'CuotaRE
        If VaDec(cuotaRe1) <> 0 Then Impreso.Detalle.Titulo(VaDec(cuotaRe1).ToString("#,##0.00"), 133, altura + 1, 23, 5, Estilos.Reducida, ">")
        If VaDec(cuotaRe2) <> 0 Then Impreso.Detalle.Titulo(VaDec(cuotaRe2).ToString("#,##0.00"), 133, altura + 5, 23, 5, Estilos.Reducida, ">")
        If VaDec(cuotaRe3) <> 0 Then Impreso.Detalle.Titulo(VaDec(cuotaRe3).ToString("#,##0.00"), 133, altura + 9, 23, 5, Estilos.Reducida, ">")

        'Totales bases 

        Dim TotalBase1 As Decimal = VaDec(base1) + VaDec(cuotaIva1) + VaDec(cuotaRe1)
        Dim TotalBase2 As Decimal = VaDec(base2) + VaDec(cuotaIva2) + VaDec(cuotaRe2)
        Dim TotalBase3 As Decimal = VaDec(base3) + VaDec(cuotaIva3) + VaDec(cuotaRe3)
        Dim TotalFactura As Decimal = TotalBase1 + TotalBase2 + TotalBase3
        Dim TotalFacturaDivisa As Decimal = TotalFactura * Cambio

        If TotalBase1 <> 0 Then Impreso.Detalle.Titulo(TotalBase1.ToString("#,##0.00"), Col(8), altura + 1, 17, 5, Estilos.Reducida, ">")
        If TotalBase2 <> 0 Then Impreso.Detalle.Titulo(TotalBase2.ToString("#,##0.00"), Col(8), altura + 5, 17, 5, Estilos.Reducida, ">")
        If TotalBase3 <> 0 Then Impreso.Detalle.Titulo(TotalBase3.ToString("#,##0.00"), Col(8), altura + 9, 17, 5, Estilos.Reducida, ">")


        altura = altura + 18


        'Total factura
        If Cambio <= 0 Or Cambio = 1 Then
            Impreso.Detalle.Titulo("TOTAL", 121, altura, 40, 6, Estilos.GrandeBold, ">")
            Impreso.Detalle.Titulo(TotalFactura.ToString("#,##0.00"), Col(8) - 15, altura, 32, 6, Estilos.Grande, ">")
        Else

            'Nombre divisa
            Dim AbDivisa As String = ""
            Dim SimboloDivisa As String = ""

            Dim Moneda As New E_Moneda(Idusuario, cn)
            If VaInt(Pedidos.PED_iddivisa.Valor) > 0 Then
                If Moneda.LeerId(Pedidos.PED_iddivisa.Valor) Then
                    'AbDivisa = (Moneda.MON_Simbolo.Valor & "")
                    AbDivisa = (Moneda.MON_Abreviatura.Valor & "").Trim
                End If
                If AbDivisa.Trim = "" Then AbDivisa = "DIVISA"
            End If


            Impreso.Detalle.Titulo("TOTAL " & AbDivisa, 121, altura, 40, 6, Estilos.GrandeBold, ">")
            Impreso.Detalle.Titulo(TotalFactura.ToString("#,##0.00"), Col(8) - 15, altura, 32, 6, Estilos.Grande, ">")

            Impreso.Detalle.Titulo("TOTAL EUROS", 121, altura + 7, 40, 6, Estilos.GrandeBold, ">")
            Impreso.Detalle.LineaH(165, altura + 7, 34, ancho_linea, Color.Black)
            Impreso.Detalle.LineaH(165, altura + 13, 34, ancho_linea, Color.Black)
            Impreso.Detalle.LineaV(165, altura + 7, 6, ancho_linea, Color.Black)
            Impreso.Detalle.LineaV(199, altura + 7, 6, ancho_linea, Color.Black)
            Impreso.Detalle.Titulo(TotalFacturaDivisa.ToString("#,##0.00"), Col(8) - 15, altura + 7, 32, 6, Estilos.Grande, ">")

        End If

        Impreso.Detalle.LineaH(165, altura, 34, ancho_linea, Color.Black)
        Impreso.Detalle.LineaH(165, altura + 6, 34, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(165, altura, 6, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(199, altura, 6, ancho_linea, Color.Black)


        altura = altura + 12


        altura = altura + 5


    End Sub


    Private Sub ImprimePieProformaPedido(ByRef Impreso As Impreso, DatosEmpresa As DatosEmpresa, ByRef altura As Integer, Pedidos As E_Pedidos, Cliente As E_Clientes)


        'Comprueba salto de linea
        Dim altura_linea As Integer = 34
        If CompruebaSaltoPagina(altura, altura_linea) Then
            Impreso.Detalle.SaltoPagina()
            altura = altura_impreso
        End If


        Dim Fecha As String = ""
        If VaDate(Pedidos.PED_fechapedido.Valor) > VaDate("") Then Fecha = VaDate(Pedidos.PED_fechapedido.Valor).ToString("dd/MM/yyyy")


        'Detalle envases
        Dim BaseAltura As Integer = altura




        'Instrucciones para el pedido y carga
        Dim instrucciones1 As String = (Pedidos.PED_obs1.Valor & "").Trim
        Dim instrucciones2 As String = (Pedidos.PED_obs2.Valor & "").Trim
        Dim instrucciones3 As String = (Pedidos.PED_obs3.Valor & "").Trim

        If instrucciones1.Trim <> "" Or instrucciones2.Trim <> "" Or instrucciones3.Trim <> "" Then

            Dim altura_instrucciones As Integer = altura + 1
            Impreso.Detalle.Titulo("Instrucciones para el pedido y carga:", margen_izquierdo, altura_instrucciones, 73, 4, Estilos.ReducidaBold)

            If instrucciones1.Trim <> "" Then
                altura_instrucciones = altura_instrucciones + 4
                Impreso.Detalle.Titulo(instrucciones1, margen_izquierdo + 3, altura_instrucciones, 110, 4, Estilos.Reducida)
            End If
            If instrucciones2.Trim <> "" Then
                altura_instrucciones = altura_instrucciones + 4
                Impreso.Detalle.Titulo(instrucciones2, margen_izquierdo + 3, altura_instrucciones, 110, 4, Estilos.Reducida)
            End If
            If instrucciones3.Trim <> "" Then
                altura_instrucciones = altura_instrucciones + 4
                Impreso.Detalle.Titulo(instrucciones3, margen_izquierdo + 3, altura_instrucciones, 110, 4, Estilos.Reducida)
            End If

        End If






        'Instrucciones de pago


        Impreso.Detalle.LineaH(margen_izquierdo + 110 + 2, altura, 80, ancho_linea, Color.Black)
        Impreso.Detalle.LineaH(margen_izquierdo + 110 + 2, altura + 34, 80, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(margen_izquierdo + 110 + 2, altura, 34, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(margen_izquierdo + 110 + 2 + 80, altura, 34, ancho_linea, Color.Black)

        Impreso.Detalle.Titulo("INSTRUCCIONES DE PAGO:", margen_izquierdo + 110 + 2 + 1, altura + 1, 73, 4, Estilos.Custom, , , fuente_negrita)
        altura = altura + 5
        Impreso.Detalle.Titulo("A Vencimiento, sírvase ingresar en nuestra cuenta, como sigue:", margen_izquierdo + 110 + 3, altura, 73, 4, Estilos.Custom, , , fuente)
        altura = altura + 4
        Impreso.Detalle.Titulo("-Banco: " & DatosEmpresa.NombreBanco, margen_izquierdo + 110 + 3, altura, 73, 4, Estilos.Custom, , , fuente)
        altura = altura + 4
        Impreso.Detalle.Titulo("-Entidad/Sucursal: ", margen_izquierdo + 110 + 3, altura, 22, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo(DatosEmpresa.EntidadSucursal, margen_izquierdo + 110 + 3 + 20, altura, 22, 4, Estilos.Custom, , , fuente_negrita)
        altura = altura + 4
        Impreso.Detalle.Titulo("-IBAN: ", margen_izquierdo + 110 + 3, altura, 10, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo(DatosEmpresa.IBAN, margen_izquierdo + 110 + 2 + 9, altura, 63, 4, Estilos.Custom, , , fuente_negrita)
        altura = altura + 4
        Impreso.Detalle.Titulo("-Swift Code: ", margen_izquierdo + 110 + 3, altura, 17, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo(DatosEmpresa.Swift, margen_izquierdo + 110 + 3 + 14, altura, 56, 4, Estilos.Custom, , , fuente_negrita)
        altura = altura + 4
        Impreso.Detalle.Titulo("-Beneficiario: " & DatosEmpresa.NombreEmpresa, margen_izquierdo + 110 + 3, altura, 73, 4, Estilos.Custom, , , fuente)
        altura = altura + 4
        Impreso.Detalle.Titulo("CIF: " & DatosEmpresa.NIF, margen_izquierdo + 110 + 3, altura, 73, 4, Estilos.Custom, , , fuente)



        'Saldo de envases
        altura = BaseAltura

        altura = altura + 4

        If altura - BaseAltura < 34 Then
            altura = BaseAltura + 34
        Else
            altura = altura + 3
        End If


        'altura = altura + 2


        Dim IdTipoCliente As String = (Cliente.CLI_IdTipo.Valor & "").Trim
        Dim TiposClientes As New E_Tiposclientes(Idusuario, cn)
        If TiposClientes.LeerId(IdTipoCliente) Then
            Dim Exento As String = (TiposClientes.TPC_exentoiva.Valor & "").Trim.ToUpper
            If Exento = "S" Then
                Impreso.Detalle.Titulo("Art. 25  Ley 37/92 - Exención por Entrega Comunitaria", margen_izquierdo + 2, altura, 200, 4, Estilos.Reducida)
            End If
        End If



        Dim NumeroAOR As String = ""


        Dim IdPuntoVenta As String = (Pedidos.PED_idpuntoventa.Valor & "").Trim
        If VaInt(IdPuntoVenta) > 0 Then

            Dim ValoresPVenta As New E_valorespventa(Idusuario, cn)
            If ValoresPVenta.LeerId(IdPuntoVenta) Then

                NumeroAOR = (ValoresPVenta.VPV_AutorizacionAduanera.Valor & "").Trim

            End If

        End If



        altura = altura + 3
        'Impreso.Detalle.Cuadro(Col(4) - 5, altura, 107, 5, ancho_linea, Color.Black)
        'Impreso.Detalle.Cuadro(margen_izquierdo, altura, 190, 10, ancho_linea, Color.Black)
        Impreso.Detalle.Titulo("El exportador de los productos incluidos en el presente documento (autorización aduanera nº " & NumeroAOR & ") declara que, salvo indicación en", margen_izquierdo + 2, altura + 1, 200 - 4, 4, Estilos.Reducida)
        Impreso.Detalle.Titulo("sentido contrario, éstos productos gozan de un origen Preferencial: UNION EUROPEA.", margen_izquierdo + 2, altura + 4, 200 - 4, 4, Estilos.Reducida)


    End Sub



    Private Function CompruebaSaltoPagina(altura As Integer, altura_linea As Integer) As Boolean

        Dim bRes As Boolean = False

        If altura + altura_linea > Pie_linea Then
            bRes = True
        End If


        Return bRes

    End Function


    Private Sub CalculaIvaRet(ByVal Clientes As E_Clientes, ByRef iva1 As Decimal, ByRef iva2 As Decimal, ByRef iva3 As Decimal,
                              ByRef re1 As Decimal, ByRef re2 As Decimal, ByRef re3 As Decimal)

        iva1 = 0
        iva2 = 0
        iva3 = 0

        re1 = 0
        re2 = 0
        re3 = 0


        Dim TiposClientes As New E_Tiposclientes(Idusuario, cn)
        Dim TipoIva As New E_tiposiva(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Clientes.CLI_IdTipo, "IdTipo")
        consulta.SelCampo(Clientes.CLI_Iddivisa, "IdDivisa")
        consulta.SelCampo(Clientes.CLI_IdPais, "Idpais")
        consulta.SelCampo(TiposClientes.TPC_idtipoiva, "IdTipoIva", Clientes.CLI_IdTipo, TiposClientes.TPC_idtipo)
        consulta.SelCampo(TiposClientes.TPC_exentoiva, "ExentoIVA")
        consulta.SelCampo(TiposClientes.TPC_recequivalencia, "RecargoEq")
        consulta.WheCampo(Clientes.CLI_Codigo, "=", VaInt(Clientes.CLI_Codigo.Valor))

        Dim dt As DataTable = Clientes.MiConexion.ConsultaSQL(consulta.SQL)
        If dt.Rows.Count > 0 Then

            Dim row As DataRow = dt.Rows(0)
            Dim ExentoIVA As String = (row("ExentoIVA").ToString & "").Trim.ToUpper
            Dim RecargoEq As String = (row("RecargoEq").ToString & "").Trim.ToUpper



            Dim dtIva As DataTable = TipoIva.Tabla
            For Each rw In dtIva.Rows

                Select Case rw("id").ToString

                    Case "1"
                        If ExentoIVA <> "S" Then iva1 = VaDec(rw("iva"))
                        If RecargoEq = "S" Then re1 = VaDec(rw("re"))
                    Case "2"
                        If ExentoIVA <> "S" Then iva2 = VaDec(rw("iva"))
                        If RecargoEq = "S" Then re2 = VaDec(rw("re"))
                    Case "3"
                        If ExentoIVA <> "S" Then iva3 = VaDec(rw("iva"))
                        If RecargoEq = "S" Then re3 = VaDec(rw("re"))

                End Select

                Application.DoEvents()

            Next

        End If


    End Sub



#End Region



End Module
