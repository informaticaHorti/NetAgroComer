Imports System.Drawing
Imports DevExpress.XtraEditors



Module C1_FacturacionEnvases


    Private margen_izquierdo As Integer = 9
    Dim ancho_linea As Decimal = 2
    Dim Pie_linea As Integer = 282

    Dim fuente_envase As New Font("Tahoma", 8, FontStyle.Italic)
    Dim fuente As New Font("Tahoma", 7, FontStyle.Regular)
    Dim fuente_negrita As New Font("Tahoma", 7, FontStyle.Bold)

    Dim altura_impreso As Integer = 81



    Private Function C1_AñadirFacturaEnvases(IdFactura As String, TipoImpresion As TipoImpresion, Facturas As E_Facturas) As Impreso

        Dim Clientes As New E_Clientes(Idusuario, cn)
        If Not Clientes.LeerId(Facturas.FRA_idcliente.Valor) Then
            MsgBox("Error al leer los datos del cliente con Id: " & Facturas.FRA_idcliente.Valor)
            Return Nothing
        End If

        'Datos Cabecera
        Dim DatosEmpresa As New DatosEmpresa


        Dim Impreso As New Impreso()

        Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
        Impreso.f.documento.PageLayout.PageSettings.Landscape = False
        Impreso.f.documento.PageLayout.PageSettings.TopMargin = "10mm"
        Impreso.f.documento.PageLayout.PageSettings.LeftMargin = "10mm"
        Impreso.f.documento.PageLayout.PageSettings.BottomMargin = "10mm"

        Impreso.EstableceImpreso(TipoImpresion)



        Impreso.DatosMail = ObtenerDatosMail(Facturas, Clientes, TipoImpresion)


        'Cabecera factura
        Dim Col As New List(Of Integer)
        Col.Add(0)
        Col.Add(margen_izquierdo)   'Col1
        Col.Add(Col(1) + 19)        'Col2
        Col.Add(Col(2) + 74)        'Col3
        Col.Add(Col(3) + 34)        'Col4
        Col.Add(Col(4) + 19)        'Col5
        Col.Add(Col(5) + 19)        'Col6


        'Cabecera
        Dim BaseLineas As Integer = 0
        Dim altura As Integer = 7


        'Detalle y totales detalle
        Dim TotalCantidad As Decimal = 0
        Dim TotalImporte As Decimal = 0


        'Dim bLeyendaControlado As Boolean = False
        'Dim bLeyendaNOAcreditado As Boolean = False
        'Dim bForzarControlado As Boolean = ((Clientes.CLI_ForzarGGNEnFacturas.Valor & "").Trim = "S")



        Try

            'Imprime cabecera
            ImprimeCabeceraFacturaEnv(Impreso, altura, Facturas, Clientes, DatosEmpresa, Col, BaseLineas)

            'Imprime detalle
            ImprimeDetalleFacturaEnv(Impreso, IdFactura, altura, BaseLineas, Col, TotalCantidad, TotalImporte)

            'Totales
            ImprimeTotalesFacturaEnv(Impreso, altura, Facturas, Col, TotalCantidad, TotalImporte)

            'Pie
            ImprimePieFacturaEnv(Impreso, DatosEmpresa, altura, Facturas, Clientes)

        Catch ex As Exception

        End Try



        Return Impreso

    End Function


    Private Sub ImprimeCabeceraFacturaEnv(ByRef Impreso As Impreso, ByRef altura As Integer,
                                              Facturas As E_Facturas, Clientes As E_Clientes, DatosEmpresa As DatosEmpresa,
                                              Col As List(Of Integer), ByRef BaseLineasDetalle As Integer)



        'Dim CB_IdEmpresa As String = VaInt(Facturas.FRA_idempresa.Valor)
        'Dim CB_Ejercicio As String = VaInt(Facturas.FRA_campa.Valor)
        'Dim CB_Serie As String = (Facturas.FRA_serie.Valor & "").Trim
        'Dim CB_Numero As String = (Facturas.FRA_factura.Valor & "").Trim


        ''Código de barras
        'Dim Code39 As New Font("C39HrP24DhTt", 42)
        'Dim CodBar As String = "*FC" & CB_IdEmpresa & "." & Fnc0(CB_Ejercicio, 2) & "." & CB_Serie & "." & CB_Numero & "*"
        'Impreso.Cabecera.Titulo(CodBar, 10, 7, 190, 18, Estilos.Custom, ">", , Code39)



        Dim titulo As String = "FACTURA"

        Dim FechaFactura As String = ""
        If VaDate(Facturas.FRA_fecha.Valor) > VaDate("") Then FechaFactura = VaDate(Facturas.FRA_fecha.Valor).ToString("dd/MM/yyyy")

        Dim Serie As String = (Facturas.FRA_serie.Valor & "").Trim
        Dim NumFactura As String = (Facturas.FRA_factura.Valor & "").Trim
        If Serie <> "" Then NumFactura = Serie & "-" & NumFactura

        Dim Referencia As String = (Facturas.FRA_RefCliente.Valor & "").Trim


        'Logo
        Dim fichero_logo As String = "logo.png"

        Select Case VaInt(Facturas.FRA_idempresa.Valor)
            Case 0, 1
                fichero_logo = "logo.png"
            Case Else
                fichero_logo = "logo_" & Facturas.FRA_idempresa.Valor & "" & ".png"
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




        altura = altura + 16
        Impreso.Cabecera.Titulo(DatosEmpresa.NombreEmpresa, 117, altura, 90, 5, Estilos.NormalBold)
        altura = altura + 5
        Impreso.Cabecera.Titulo(DatosEmpresa.FilaDatos(), 117, altura, 90, 98, Estilos.MinimaBold)

        altura = altura + 3
        altura = altura + 5
        altura = altura + 4


        Dim Pais As String = ""
        If VaInt(Clientes.CLI_IdPais.Valor) > 0 Then
            Dim Paises As New E_Paises(Idusuario, CnComun)
            If Paises.LeerId(Clientes.CLI_IdPais.Valor) Then
                Pais = Paises.Nombre.Valor
            End If
        End If


        Impreso.Cabecera.Cuadro(margen_izquierdo + 90, altura, 100, 32, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo(Clientes.CLI_Nombre.Valor & "", margen_izquierdo + 90 + 5, altura + 1, 91, 5, Estilos.GrandeBold)
        Impreso.Cabecera.Titulo(Clientes.CLI_Domicilio.Valor & "", margen_izquierdo + 90 + 5, altura + 6, 91, 5, Estilos.GrandeBold)
        Impreso.Cabecera.Titulo(Clientes.CLI_CPostal.Valor & " " & Clientes.CLI_Poblacion.Valor & "", margen_izquierdo + 90 + 5, altura + 11, 91, 5, Estilos.GrandeBold)
        Impreso.Cabecera.Titulo(Clientes.CLI_Provincia.Valor, margen_izquierdo + 90 + 5, altura + 16, 91, 5, Estilos.GrandeBold)
        Impreso.Cabecera.Titulo(Pais, margen_izquierdo + 90 + 5, altura + 21, 91, 5, Estilos.GrandeBold)
        Impreso.Cabecera.Titulo("Nº Reg.: " & Clientes.CLI_NumeroRegistro.Valor, margen_izquierdo + 90 + 5, altura + 26, 91, 5, Estilos.NormalBold)
        altura = altura + 4


        Impreso.Cabecera.Cuadro(margen_izquierdo, altura, 50, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaH(margen_izquierdo, altura + 5, 50, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(margen_izquierdo + 25, altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo("FECHA FRA.", margen_izquierdo + 3, altura + 1, 22, 5, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo(FechaFactura, margen_izquierdo + 1, altura + 6, 23, 5, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(titulo, margen_izquierdo + 25 + 3, altura + 1, 22, 5, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo(NumFactura, margen_izquierdo + 25 + 1, altura + 6, 26, 5, Estilos.Reducida, "=")
        altura = altura + 13

        Impreso.Cabecera.Cuadro(margen_izquierdo, altura, 75, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaH(margen_izquierdo, altura + 5, 75, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(margen_izquierdo + 25, altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(margen_izquierdo + 25 + 25, altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo("REF. FACTURA", margen_izquierdo + 3, altura + 1, 22, 5, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo(Referencia, margen_izquierdo + 1, altura + 6, 23, 5, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo("N.I.F.", margen_izquierdo + 25 + 3, altura + 1, 22, 5, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo(Clientes.CLI_Nif.Valor & "", margen_izquierdo + 25 + 1, altura + 6, 23, 5, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo("CODIGO", margen_izquierdo + 25 + 25 + 3, altura + 1, 22, 5, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo(VaInt(Facturas.FRA_idcliente.Valor).ToString("00000"), margen_izquierdo + 25 + 25 + 1, altura + 6, 24, 5, Estilos.Reducida, "=")
        altura = altura + 10 + 3 + 5


        'Solo le pasamos Col si queremos imprimir la cabecera del detalle
        If Not IsNothing(Col) Then

            'Guardo el principio del detalle para dibujar luego las lineas verticales laterales de la factura
            BaseLineasDetalle = altura

            Impreso.Cabecera.LineaH(margen_izquierdo, altura, 190, ancho_linea, Color.Black)
            Impreso.Cabecera.LineaH(margen_izquierdo, altura + 5, 190, ancho_linea, Color.Black)
            Impreso.Cabecera.Titulo("Vale", Col(1) + 1, altura + 1, 18, 5, Estilos.ReducidaBold)
            Impreso.Cabecera.Titulo("Producto", Col(2) + 1, altura + 1, 73, 5, Estilos.ReducidaBold)
            Impreso.Cabecera.Titulo("Marca", Col(3), altura + 1, 33, 5, Estilos.ReducidaBold)
            Impreso.Cabecera.Titulo("Cantidad", Col(4), altura + 1, 18, 5, Estilos.ReducidaBold, ">")
            Impreso.Cabecera.Titulo("Precio", Col(5), altura + 1, 18, 5, Estilos.ReducidaBold, ">")
            Impreso.Cabecera.Titulo("Importe", Col(6), altura + 1, 18, 5, Estilos.ReducidaBold, ">")

            altura = altura + 5
            altura = altura + 2

        End If



    End Sub


    Private Sub ImprimeDetalleFacturaEnv(ByRef Impreso As Impreso, IdFactura As String, ByRef altura As Integer,
                                           BaseLineas As Integer, Col As List(Of Integer), ByRef TotalCantidad As Decimal,
                                           ByRef TotalImporte As Decimal)


        'Líneas Detalle
        Dim ValeEnvases_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
        Dim ValeEnvase As New E_ValeEnvases(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)
        Dim Marcas As New E_Marcas(Idusuario, cn)
        

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(ValeEnvases_Lineas.VEL_Id, "IdLinea")
        consulta.SelCampo(ValeEnvase.VEV_Numero, "Vale", ValeEnvases_Lineas.VEL_idvale)
        consulta.SelCampo(ValeEnvases_Lineas.VEL_idenvase, "IdEnvase")
        consulta.SelCampo(Envases.ENV_Nombre, "Envase", ValeEnvases_Lineas.VEL_idenvase)
        consulta.SelCampo(Marcas.MAR_Nombre, "Marca", ValeEnvases_Lineas.VEL_idmarca)
        consulta.SelCampo(ValeEnvases_Lineas.VEL_retira, "Cantidad")
        consulta.SelCampo(ValeEnvases_Lineas.VEL_PrecioFianza, "Precio")
        Dim oImporte As New Cdatos.bdcampo("@VEL_Retira * VEL_PrecioFianza", Cdatos.TiposCampo.Importe, 18, 2)
        consulta.SelCampo(oImporte, "Importe")
        consulta.WheCampo(ValeEnvases_Lineas.VEL_IdFacturaEnvase, "=", IdFactura)

        Dim sql As String = consulta.SQL & vbCrLf
        sql = sql & " ORDER BY VEV_Fecha, VEV_Numero, VEL_Id" & vbCrLf

        Dim dtDetalle As DataTable = ValeEnvases_Lineas.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dtDetalle) Then

            For Each row As DataRow In dtDetalle.Rows

                Dim Vale As String = (row("Vale").ToString & "").Trim
                Dim Envase As String = (row("Envase").ToString & "").Trim
                Dim Marca As String = (row("Marca").ToString & "").Trim
                Dim Cantidad As Decimal = VaDec(row("Cantidad"))
                Dim Precio As Decimal = VaDec(row("Precio"))
                Dim Importe As Decimal = VaDec(row("Importe"))


                Impreso.Detalle.Titulo(Vale, Col(1) + 1, altura, 18, altura, Estilos.Custom)
                Impreso.Detalle.Titulo(Envase, Col(2) + 1, altura, 73, altura, Estilos.Custom)
                Impreso.Detalle.Titulo(Marca, Col(3) + 1, altura, 33, altura, Estilos.Custom)

                If Cantidad <> 0 Then Impreso.Detalle.Titulo(Cantidad.ToString("#,##0"), Col(4), altura, 18, altura, Estilos.Custom, ">")
                If Precio <> 0 Then Impreso.Detalle.Titulo(Precio.ToString("#,##0.00000"), Col(5), altura, 18, altura, Estilos.Custom, ">")
                If Importe <> 0 Then Impreso.Detalle.Titulo(Importe.ToString("#,##0.00"), Col(6), altura, 18, altura, Estilos.Custom, ">")


                TotalCantidad = TotalCantidad + Cantidad
                TotalImporte = TotalImporte + Importe


                altura = altura + 4

                Application.DoEvents()

            Next

        End If


        altura = altura + 1


        Dim alto_detalle As Integer = altura - BaseLineas
        If alto_detalle < 123 Then
            altura = BaseLineas + 118
        End If


        'Líneas laterales
        Impreso.Detalle.LineaH(margen_izquierdo, altura, 190, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(margen_izquierdo, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(margen_izquierdo + 190, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)

        altura = altura + 2


    End Sub


    Private Sub ImprimeTotalesFacturaEnv(ByRef Impreso As Impreso, ByRef altura As Integer, Factura As E_Facturas,
                                           Col As List(Of Integer), TotalCantidad As Decimal, TotalImporte As Decimal)


        Dim base1 As Decimal = VaDec(Factura.FRA_Base1.Valor)
        Dim base2 As Decimal = VaDec(Factura.FRA_Base2.Valor)
        Dim base3 As Decimal = VaDec(Factura.FRA_Base3.Valor)

        Dim iva1 As Decimal = VaDec(Factura.FRA_Iva1.Valor)
        Dim iva2 As Decimal = VaDec(Factura.FRA_Iva2.Valor)
        Dim iva3 As Decimal = VaDec(Factura.FRA_Iva3.Valor)

        Dim cuotaIva1 As Decimal = VaDec(Factura.FRA_Cuota1.Valor)
        Dim cuotaIva2 As Decimal = VaDec(Factura.FRA_Cuota2.Valor)
        Dim cuotaIva3 As Decimal = VaDec(Factura.FRA_Cuota3.Valor)

        Dim re1 As Decimal = VaDec(Factura.FRA_Re1.Valor)
        Dim re2 As Decimal = VaDec(Factura.FRA_Re2.Valor)
        Dim re3 As Decimal = VaDec(Factura.FRA_Re3.Valor)

        Dim cuotaRe1 As Decimal = VaDec(Factura.FRA_CuotaRe1.Valor)
        Dim cuotaRe2 As Decimal = VaDec(Factura.FRA_CuotaRe2.Valor)
        Dim cuotaRe3 As Decimal = VaDec(Factura.FRA_CuotaRe3.Valor)



        'Totales Bultos, Piezas, Kg, Importe
        Impreso.Detalle.Cuadro(Col(4) - 5, altura, 20, 5, ancho_linea, Color.Black)
        Impreso.Detalle.Cuadro(Col(6), altura, 25, 5, ancho_linea, Color.Black)

        altura = altura + 1

        Impreso.Detalle.Titulo(Factura.FRA_obs1.Valor & "", margen_izquierdo + 5, altura - 10, 100, 6, Estilos.MinimaBold)
        Impreso.Detalle.Titulo(Factura.FRA_obs2.Valor & "", margen_izquierdo + 5, altura - 7, 100, 6, Estilos.MinimaBold)

        If TotalCantidad <> 0 Then Impreso.Detalle.Titulo(TotalCantidad.ToString("#,##0"), Col(4), altura, 14, 4, Estilos.Reducida, ">")
        If TotalImporte <> 0 Then Impreso.Detalle.Titulo(TotalImporte.ToString("#,##0.00"), Col(6), altura, 17, 4, Estilos.Reducida, ">")


        altura = altura + 6


        'Comprueba salto de linea
        Dim altura_linea As Integer = 31
        If CompruebaSaltoPagina(altura, altura_linea) Then
            Impreso.Detalle.SaltoPagina()
            altura = altura_impreso
        End If


        Impreso.Detalle.Titulo("Base Imponible", 33, altura, 26, 3, Estilos.MinimaBold, "=")
        Impreso.Detalle.Titulo("%", 60, altura, 9, 3, Estilos.MinimaBold, "=")
        Impreso.Detalle.Titulo("Importe I.V.A.", 71, altura, 26, 3, Estilos.MinimaBold, "=")
        Impreso.Detalle.Titulo("%", 97, altura, 9, 3, Estilos.MinimaBold, "=")
        Impreso.Detalle.Titulo("Importe R.E.", 107, altura, 26, 3, Estilos.MinimaBold, "=")

        altura = altura + 3


        Impreso.Detalle.LineaH(32, altura, 101, ancho_linea, Color.Black)
        Impreso.Detalle.LineaH(32, altura + 15, 101, ancho_linea, Color.Black)

        Impreso.Detalle.LineaV(32, altura, 15, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(59, altura, 15, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(69, altura, 15, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(96, altura, 15, ancho_linea, Color.Black)


        Impreso.Detalle.LineaV(106, altura, 15, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(133, altura, 15, ancho_linea, Color.Black)
        'Impreso.Detalle.LineaV(160, altura, 15, ancho_linea, Color.Black)

        Impreso.Detalle.LineaH(165, altura, 34, ancho_linea, Color.Black)
        Impreso.Detalle.LineaH(165, altura + 15, 34, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(165, altura, 15, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(199, altura, 15, ancho_linea, Color.Black)


        'Bases
        If VaDec(base1) <> 0 Then Impreso.Detalle.Titulo(VaDec(base1).ToString("#,##0.00"), 32, altura + 1, 24, 5, Estilos.Reducida, ">")
        If VaDec(base2) <> 0 Then Impreso.Detalle.Titulo(VaDec(base2).ToString("#,##0.00"), 32, altura + 5, 24, 5, Estilos.Reducida, ">")
        If VaDec(base3) <> 0 Then Impreso.Detalle.Titulo(VaDec(base3).ToString("#,##0.00"), 32, altura + 9, 24, 5, Estilos.Reducida, ">")

        '%IVA
        If VaDec(iva1) <> 0 And VaDec(cuotaIva1) <> 0 Then Impreso.Detalle.Titulo(VaDec(iva1).ToString("#,##0.00"), 58, altura + 1, 10, 5, Estilos.Reducida, ">")
        If VaDec(iva2) <> 0 And VaDec(cuotaIva2) <> 0 Then Impreso.Detalle.Titulo(VaDec(iva2).ToString("#,##0.00"), 58, altura + 5, 10, 5, Estilos.Reducida, ">")
        If VaDec(iva3) <> 0 And VaDec(cuotaIva3) <> 0 Then Impreso.Detalle.Titulo(VaDec(iva3).ToString("#,##0.00"), 58, altura + 9, 10, 5, Estilos.Reducida, ">")

        'CuotaIVA
        If VaDec(cuotaIva1) <> 0 Then Impreso.Detalle.Titulo(VaDec(cuotaIva1).ToString("#,##0.00"), 69, altura + 1, 22, 5, Estilos.Reducida, ">")
        If VaDec(cuotaIva2) <> 0 Then Impreso.Detalle.Titulo(VaDec(cuotaIva2).ToString("#,##0.00"), 69, altura + 5, 22, 5, Estilos.Reducida, ">")
        If VaDec(cuotaIva3) <> 0 Then Impreso.Detalle.Titulo(VaDec(cuotaIva3).ToString("#,##0.00"), 69, altura + 9, 22, 5, Estilos.Reducida, ">")

        '%RE
        If VaDec(re1) <> 0 And VaDec(cuotaRe1) <> 0 Then Impreso.Detalle.Titulo(VaDec(re1).ToString("#,##0.00"), 95, altura + 1, 10, 5, Estilos.Reducida, ">")
        If VaDec(re2) <> 0 And VaDec(cuotaRe1) <> 0 Then Impreso.Detalle.Titulo(VaDec(re2).ToString("#,##0.00"), 95, altura + 5, 10, 5, Estilos.Reducida, ">")
        If VaDec(re3) <> 0 And VaDec(cuotaRe3) <> 0 Then Impreso.Detalle.Titulo(VaDec(re3).ToString("#,##0.00"), 95, altura + 9, 10, 5, Estilos.Reducida, ">")

        'CuotaRE
        If VaDec(cuotaRe1) <> 0 Then Impreso.Detalle.Titulo(VaDec(cuotaRe1).ToString("#,##0.00"), 105, altura + 1, 23, 5, Estilos.Reducida, ">")
        If VaDec(cuotaRe2) <> 0 Then Impreso.Detalle.Titulo(VaDec(cuotaRe2).ToString("#,##0.00"), 105, altura + 5, 23, 5, Estilos.Reducida, ">")
        If VaDec(cuotaRe3) <> 0 Then Impreso.Detalle.Titulo(VaDec(cuotaRe3).ToString("#,##0.00"), 105, altura + 9, 23, 5, Estilos.Reducida, ">")


        'Totales bases 

        Dim TotalBase1 As Decimal = VaDec(base1) + VaDec(cuotaIva1) + VaDec(cuotaRe1)
        Dim TotalBase2 As Decimal = VaDec(base2) + VaDec(cuotaIva2) + VaDec(cuotaRe2)
        Dim TotalBase3 As Decimal = VaDec(base3) + VaDec(cuotaIva3) + VaDec(cuotaRe3)
        Dim TotalFactura As Decimal = VaDec(Factura.FRA_totalfactura.Valor)

        If TotalBase1 <> 0 Then Impreso.Detalle.Titulo(TotalBase1.ToString("#,##0.00"), Col(6), altura + 1, 17, 5, Estilos.Reducida, ">")
        If TotalBase2 <> 0 Then Impreso.Detalle.Titulo(TotalBase2.ToString("#,##0.00"), Col(6), altura + 5, 17, 5, Estilos.Reducida, ">")
        If TotalBase3 <> 0 Then Impreso.Detalle.Titulo(TotalBase3.ToString("#,##0.00"), Col(6), altura + 9, 17, 5, Estilos.Reducida, ">")


        altura = altura + 18


        'Total factura
        Impreso.Detalle.Titulo("TOTAL FACTURA", 121, altura, 40, 6, Estilos.GrandeBold, ">")
        Impreso.Detalle.Titulo(TotalFactura.ToString("#,##0.00"), Col(6) - 15, altura, 32, 6, Estilos.Grande, ">")
            

        Impreso.Detalle.LineaH(165, altura, 34, ancho_linea, Color.Black)
        Impreso.Detalle.LineaH(165, altura + 6, 34, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(165, altura, 6, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(199, altura, 6, ancho_linea, Color.Black)


        altura = altura + 5



        'Forma de pago
        Dim FormaPago As String = ""


        Dim IdFormaPago As String = (Factura.FRA_idformadepago.Valor & "").Trim
        Dim FormasPago As New E_FormasPago(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        If FormasPago.LeerId(IdFormaPago) Then
            FormaPago = FormasPago.Nombre.Valor
        End If

        Impreso.Detalle.Titulo("Forma de pago: " & FormaPago, margen_izquierdo, altura + 5, 170, 5, Estilos.Normal)


        altura = altura + 10


    End Sub


    Private Sub ImprimePieFacturaEnv(ByRef Impreso As Impreso, DatosEmpresa As DatosEmpresa, ByRef altura As Integer, Factura As E_Facturas,
                                     Cliente As E_Clientes)


        'Comprueba salto de linea
        Dim altura_linea As Integer = 34
        If CompruebaSaltoPagina(altura, altura_linea) Then
            Impreso.Detalle.SaltoPagina()
            altura = altura_impreso
        End If


        Dim Fecha As String = ""
        If VaDate(Factura.FRA_fecha.Valor) > VaDate("") Then Fecha = VaDate(Factura.FRA_fecha.Valor).ToString("dd/MM/yyyy")


        'Detalle envases
        Dim BaseAltura As Integer = altura


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
        'altura = BaseAltura


        'Impreso.Detalle.LineaH(margen_izquierdo, altura, 110, ancho_linea, Color.Black)
        'Impreso.Detalle.LineaV(margen_izquierdo + 75, altura, 4, ancho_linea, Color.Black)
        'Impreso.Detalle.LineaV(margen_izquierdo + 75 + 10, altura, 4, ancho_linea, Color.Black)

        'Impreso.Detalle.LineaH(margen_izquierdo, altura, 110, ancho_linea, Color.Black)
        'Impreso.Detalle.Titulo("DESGLOSE GASTOS", margen_izquierdo + 2, altura + 1, 73, 4, Estilos.MinimaBold)
        'Impreso.Detalle.Titulo("%", margen_izquierdo + 76, altura + 1, 8, 4, Estilos.MinimaBold, "=")
        'Impreso.Detalle.Titulo("IMPORTE", margen_izquierdo + 86, altura + 1, 23, 4, Estilos.MinimaBold, "=")
        'altura = altura + 4

        'Impreso.Detalle.LineaH(margen_izquierdo, altura, 110, ancho_linea, Color.Black)


        ''Detalle gastos
        'Dim dtEnvases As DataTable = DetalleGastos(Factura.FRA_idfactura.Valor)

        'Dim cont As Integer = 1
        'For Each row As DataRow In dtEnvases.Rows

        '    If cont > 7 Then Exit For

        '    Dim Gasto As String = (row("Gasto").ToString & "").Trim
        '    Dim Tipo As String = (row("Tipo").ToString & "").Trim.ToUpper
        '    Dim Valor As Decimal = VaDec(row("Valor"))
        '    Dim Importe As Decimal = VaDec(row("Importe"))


        '    If Importe <> 0 Then

        '        Dim Porcentaje As String = ""
        '        If Tipo = "%" Then
        '            Porcentaje = VaDec(Valor).ToString("#,##0.00")
        '        End If

        '        Impreso.Detalle.Titulo(Gasto, margen_izquierdo + 2, altura + 1, 73, 3, Estilos.Minima)
        '        Impreso.Detalle.Titulo(Porcentaje, margen_izquierdo + 76, altura + 1, 8, 3, Estilos.Minima, ">")
        '        Impreso.Detalle.Titulo(Importe.ToString("#,##0.00"), margen_izquierdo + 86, altura + 1, 23, 3, Estilos.Minima, ">")
        '        altura = altura + 4

        '        cont = cont + 1
        '    End If


        '    Application.DoEvents()

        'Next




        'If altura - BaseAltura < 34 Then
        '    altura = BaseAltura + 34
        'Else
        '    altura = altura + 3
        'End If


        ''Linea final horizontal
        'Impreso.Detalle.LineaH(margen_izquierdo, altura, 110, ancho_linea, Color.Black)

        ''Lineas laterales
        'Impreso.Detalle.LineaV(margen_izquierdo, BaseAltura, altura - BaseAltura, ancho_linea, Color.Black)
        'Impreso.Detalle.LineaV(margen_izquierdo + 110, BaseAltura, altura - BaseAltura, ancho_linea, Color.Black)

        'altura = altura + 1


        'Dim IdTipoCliente As String = (Cliente.CLI_IdTipo.Valor & "").Trim
        'Dim TiposClientes As New E_Tiposclientes(Idusuario, cn)
        'If TiposClientes.LeerId(IdTipoCliente) Then
        '    Dim Exento As String = (TiposClientes.TPC_exentoiva.Valor & "").Trim.ToUpper
        '    If Exento = "S" Then
        '        Impreso.Detalle.Titulo("Art. 25  Ley 37/92 - Exención por Entrega Comunitaria", margen_izquierdo + 2, altura, 200, 4, Estilos.Reducida)
        '    End If
        'End If


        'altura = altura + 3

        'Dim bProductoEcologico As Boolean = False
        'Dim NumRegistro As String = ""



        'Dim IdPuntoVenta As String = (Factura.FRA_idpuntoventa.Valor & "").Trim
        'If VaInt(IdPuntoVenta) > 0 Then

        '    Dim ValoresPVenta As New E_valorespventa(Idusuario, cn)
        '    If ValoresPVenta.LeerId(IdPuntoVenta) Then

        '        Dim Ecologico As String = (ValoresPVenta.VPV_EcologicoSN.Valor & "").Trim
        '        bProductoEcologico = (Ecologico = "S")
        '        NumRegistro = (ValoresPVenta.VPV_NumRegistroEco.Valor & "").Trim

        '    End If

        'End If


        'If bProductoEcologico Then
        '    Impreso.Detalle.Titulo("PROCEDENTE DEL CULTIVO ECOLOGICO, SISTEMA DE CONTROL UE: " & NumRegistro & "REGLAMENTO UE-834/2007", margen_izquierdo, altura, 185, 4, Estilos.Reducida)
        'End If

        'If bLeyendaControlado Then
        '    Impreso.Detalle.Titulo("** Producto controlado GLOBALGAP - GGN: " & DatosEmpresa.GGN & ". Producto Origen ESPAÑA.", margen_izquierdo, altura + 3, 280, 4, Estilos.Reducida)
        'Else
        '    Impreso.Detalle.Titulo("Producto Origen ESPAÑA.", margen_izquierdo, altura + 3, 280, 4, Estilos.Reducida)
        'End If

        'If bLeyendaNOAcreditado Then
        '    Impreso.Detalle.Titulo("*** Producto controlado GLOBALGAP - CoC: " & DatosEmpresa.GGN & ". Producto Origen ESPAÑA.", margen_izquierdo, altura + 6, 280, 4, Estilos.Reducida)
        'End If


    End Sub


    Private Function CompruebaSaltoPagina(altura As Integer, altura_linea As Integer) As Boolean

        Dim bRes As Boolean = False

        If altura + altura_linea > Pie_linea Then
            bRes = True
        End If


        Return bRes

    End Function



    Private Function ObtenerDatosMail(ByVal Facturas As E_Facturas, ByVal Clientes As E_Clientes, ByVal TipoImpresion As TipoImpresion) As DatosMail

        Dim NombreDocumento As String = ""
        Dim Asunto As String = ObtenerAsuntoMail(Facturas, NombreDocumento)


        Dim sql As String = "SELECT CLI_EmailPed1 as Email1, CLI_EmailPed2 as Email2, CLI_EmailPed3 as Email3" & vbCrLf
        sql = sql & " FROM Facturas" & vbCrLf
        sql = sql & " INNER JOIN Clientes ON FRA_IdCliente = CLI_IdCliente " & vbCrLf
        sql = sql & " WHERE FRA_IdFactura = " & Facturas.FRA_idfactura.Valor & vbCrLf


        Dim DestinatariosMail As New List(Of String)


        Dim dt As DataTable = Facturas.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            If dt.Rows.Count > 0 Then

                Dim row As DataRow = dt.Rows(0)

                Dim Email1 As String = (row("Email1").ToString & "").Trim
                Dim Email2 As String = (row("Email2").ToString & "").Trim
                Dim Email3 As String = (row("Email3").ToString & "").Trim

                If Email1.Trim <> "" Then
                    DestinatariosMail.Add(Email1)
                End If

                If Email2.Trim <> "" Then
                    If Not DestinatariosMail.Contains(Email2) Then DestinatariosMail.Add(Email2)
                End If

                If Email3.Trim <> "" Then
                    If Not DestinatariosMail.Contains(Email3) Then DestinatariosMail.Add(Email3)
                End If


            End If

        End If




        If TipoImpresion = NetAgro.TipoImpresion.Email Then

            Dim frm As New FrmConfirmarEmail
            frm.Init(DestinatariosMail)
            frm.ShowDialog()

            DestinatariosMail = frm.Destinatarios

            If frm.Resultado <> FrmConfirmarEmail.ResultadoFormulario.Enviar Then
                Return Nothing
            End If

        End If


        Return New DatosMail(DestinatariosMail, "", Asunto, "", Nothing, NombreDocumento)

    End Function


    Private Function ObtenerAsuntoMail(Facturas As E_Facturas, Optional ByRef NombreDocumento As String = "")


        Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
        'Dim Asunto As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.TEXTO_ASUNTO_FACTURASENVASES_EMAIL) & ""
        Dim asunto As String = ""


        Dim SerieFactura As String = (Facturas.FRA_serie.Valor & "").Trim
        Dim NumFactura As String = (Facturas.FRA_factura.Valor & "").Trim : If SerieFactura.Trim <> "" Then NumFactura = SerieFactura & "-" & NumFactura
        Dim RefCliente As String = (Facturas.FRA_RefCliente.Valor & "").Trim
        Dim PV As String = Facturas.FRA_idpuntoventa.Valor
        NombreDocumento = "FacturaEnvases_" & PV & "_" & NumFactura & ".pdf"

        Dim Fecha As String = ""
        If VaDate(Facturas.FRA_fecha.Valor) > VaDate("") Then Fecha = VaDate(Facturas.FRA_fecha.Valor).ToString("dd/MM/yyyy")

        ' Añado los datos al email
        'If Asunto.Trim = "" Then Asunto = "FACTURA ENVASES: " & PV & "-" & NumFactura & " / " & Fecha & " / Referencia cliente: " & RefCliente
        If Asunto.Trim = "" Then Asunto = "FACTURA ENVASES: " & PV & "-" & NumFactura & " / " & Fecha


        Return Asunto

    End Function



    Public Sub C1_ImprimirFacturaEnvases(IdFactura As String, TipoImpresion As TipoImpresion,
                                          Optional Impresora As String = "",
                                          Optional rutaPDF As String = "",
                                          Optional archivoPDF As String = "")


        Dim Facturas As New E_Facturas(Idusuario, cn)

        If Facturas.LeerId(IdFactura) Then



            Dim Impreso As Impreso = C1_AñadirFacturaEnvases(IdFactura, TipoImpresion, Facturas)






            If Not IsNothing(Impreso) Then

                Try

                    Dim CD As New E_ConfiguracionesDiversas(Idusuario, cn)
                    Dim ruta As String = CD.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_ARCHIVOS_ADJUNTOS_TEMP) & "\"


                    'Impresión / previsualización / exportación
                    Select Case TipoImpresion

                        Case TipoImpresion.Email

                            If Not IsNothing(Impreso.DatosMail) Then

                                Impreso.Imprimir(NetAgro.TipoImpresion.ExportacionPDF, , ruta, Impreso.DatosMail.NombreDocumento)
                                Impreso.DatosMail.ListaAdjuntos.Add(ruta & Impreso.DatosMail.NombreDocumento)
                                Impreso.EnviarPorOutlook(False)

                                Try
                                    If IO.File.Exists(ruta & Impreso.DatosMail.NombreDocumento) Then
                                        IO.File.Delete(ruta & Impreso.DatosMail.NombreDocumento)
                                    End If
                                Catch ex As Exception
                                End Try

                                MsgBox("Enviado!")

                            Else
                                MsgBox("Envío cancelado")
                            End If


                        Case TipoImpresion.Fax

                            Impreso.Imprimir(NetAgro.TipoImpresion.ExportacionPDF, , ruta, Impreso.DatosMail.NombreDocumento)
                            Impreso.DatosMail.ListaAdjuntos.Add(ruta & Impreso.DatosMail.NombreDocumento)
                            Impreso.EnviarPorOutlook(True)

                            Try
                                If IO.File.Exists(ruta & Impreso.DatosMail.NombreDocumento) Then
                                    IO.File.Delete(ruta & Impreso.DatosMail.NombreDocumento)
                                End If
                            Catch ex As Exception
                            End Try


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


                    'Genera gestión documental de la entidad, en caso necesario
                    'Select Case TipoImpresion

                    '    Case NetAgro.TipoImpresion.Preliminar, NetAgro.TipoImpresion.ImpresoraPorDefecto, NetAgro.TipoImpresion.ImpresoraSeleccionada
                    '        GeneraGestionDocumental(Impreso, Facturas)

                    'End Select



                Catch ex As Exception

                End Try

            End If




        Else
            XtraMessageBox.Show("Error al leer la factura de envases con id: " & IdFactura, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub


End Module
