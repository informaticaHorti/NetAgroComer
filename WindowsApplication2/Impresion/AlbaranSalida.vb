Imports DevExpress.XtraEditors
Imports System.Drawing


Module ImpresionAlbaranSalida


#Region "Clases para impresión albarán"

    Private Class DatosCabecera

        Public IdAlbaran As String = ""
        Public NumAlbaran As String = "" 'Sólo en caso de que sea factura, para guardar el Albaran
        Public Fecha As String = ""
        Public IdValeEnvase As String = ""
        Public ValorCambio As Decimal = 1

        Public IdCliente As Integer = 0
        Public NIF As String = ""
        Public Nombre As String = ""
        Public Domicilio As String = ""
        Public Poblacion As String = ""
        Public Provincia As String = ""
        Public CPostal As String = ""

        Public MatriculaCamion As String = ""
        Public MatriculaRemolque As String = ""
        Public Referencia As String = ""

        Public EsCopia As Boolean = False
        Public DatosEmpresa As New DatosEmpresa   'De momento, como una variable con retornos de carro


        Public Base1 As Decimal = 0
        Public Base2 As Decimal = 0
        Public Iva1 As Decimal = 0
        Public Iva2 As Decimal = 0
        Public CuotaIVA1 As Decimal = 0
        Public CuotaIVA2 As Decimal = 0
        Public Re1 As Decimal = 0
        Public Re2 As Decimal = 0
        Public CuotaRe1 As Decimal = 0
        Public CuotaRe2 As Decimal = 0

        Public TotalGastos As Decimal = 0
        Public Observaciones As String = ""
        'Public Divisa As Decimal = 1




    End Class


    Private Class LineaAlbaran

        Public Genero As String = ""
        Public Confeccion As String = ""
        Public Categoria As String = ""
        Public Marca As String = ""
        Public Bultos As Decimal = 0
        Public Piezas As Decimal = 0
        Public KgBrutos As Decimal = 0
        Public KgNetos As Decimal = 0
        Public Precio As Decimal = 0
        Public Importe As Decimal = 0
        Public Presentacion As String = ""

        Public Sub New(Genero As String, Confeccion As String, Categoria As String, Marca As String, Bultos As Decimal, Piezas As Decimal,
                       KgBrutos As Decimal, KgNetos As Decimal, Precio As Decimal, Importe As Decimal, Presentacion As String)

            Me.Genero = Genero
            Me.Confeccion = Confeccion
            Me.Categoria = Categoria
            Me.Marca = Marca
            Me.Bultos = Bultos
            Me.Piezas = Piezas
            Me.KgBrutos = KgBrutos
            Me.KgNetos = KgNetos
            Me.Precio = Precio
            Me.Importe = Importe
            Me.Presentacion = Presentacion
        End Sub

    End Class


#End Region


#Region "Albaranes"


    Public Sub ImprimirAlbaranSalida(ByVal IdAlbaran As String, TipoImpresion As TipoImpresion, bCopia As Boolean, Impresora As String, rutaPDF As String, archivoPDF As String)


        Dim err As New Errores

        If VaDec(IdAlbaran) > 0 Then

            'Datos Cabecera
            Dim DatosCabecera As New DatosCabecera
            DatosCabecera.IdAlbaran = IdAlbaran
            DatosCabecera.EsCopia = bCopia


            Dim Informe As New miInforme(False)
            Informe.Contenedor.PaperKind = Printing.PaperKind.A4
            Informe.Contenedor.PrintingSystem.ShowMarginsWarning = False

            Informe.Contenedor.MinMargins.Top = 0
            Informe.Contenedor.MinMargins.Left = 0
            Informe.Contenedor.MinMargins.Right = 0
            Informe.Contenedor.MinMargins.Bottom = 0

            Informe.Contenedor.Margins.Top = 0
            Informe.Contenedor.Margins.Left = 0
            Informe.Contenedor.Margins.Right = 0
            Informe.Contenedor.Margins.Bottom = 0


            'Cabecera factura
            Dim margen_izquierdo As Integer = 9
            Dim Col As New List(Of Integer)
            Col.Add(0)
            Col.Add(margen_izquierdo)   'Col1
            Col.Add(Col(1) + 47)        'Col2
            Col.Add(Col(2) + 20)        'Col5
            Col.Add(Col(3) + 15)        'Col3
            Col.Add(Col(4) + 20)        'Col4
            Col.Add(Col(5) + 13)        'Col6
            Col.Add(Col(6) + 12)        'Col7
            Col.Add(Col(7) + 15)        'Col8
            Col.Add(Col(8) + 15)        'Col9
            Col.Add(Col(9) + 14)        'Col10
            Col.Add(Col(10) + 15)        'Col11


            'Cabecera
            Dim miFactura As New miFactura()
            Dim BaseLineas As Integer = 0
            Dim NumFactura As String = ""
            Dim Fecha As String = ""
            Dim Cliente As String = ""
            Dim pag_actual As Integer = 1
            Dim inicio_pag_actual As Integer = 7
            Dim altura As Integer = inicio_pag_actual


            'Obtenemos los datos de la cabecera
            Try
                ObtenerDatosCabecera(DatosCabecera, IdAlbaran)
            Catch ex As Exception
                err.Muestraerror("Error al imprimir en tipo de documento", "ImprimirAlbaranFactura", ex.Message)
                Exit Sub
            End Try


            'Imprime cabecera
            ImprimeCabeceraAlbaranSalida(DatosCabecera, miFactura, altura, inicio_pag_actual, margen_izquierdo, Col, BaseLineas)


            'Gastos envases y gastos en factura
            ' Dim ImpEnvases As Decimal = ImporteEnvases(DatosCabecera.IdValeEnvase)
            'Dim GastosEnFactura As Decimal = GastosFactura(DatosCabecera.IdAlbaran)

            Dim IMPENVASES As Decimal = 0

            'Detalle y totales detalle
            Dim TotalBultos As Decimal = 0
            Dim TotalPiezas As Decimal = 0
            Dim TotalKgBrutos As Decimal = 0
            Dim TotalKgNetos As Decimal = 0
            Dim TotalImporte As Decimal = 0


            ImprimeDetalleAlbaranSalida(DatosCabecera, miFactura, altura, margen_izquierdo, BaseLineas, Col,
                                        pag_actual, inicio_pag_actual, TotalBultos, TotalPiezas, TotalKgBrutos, TotalKgNetos, TotalImporte,
                                        ImpEnvases)




            'Totales
            ImprimeTotalesAlbaranSalida(DatosCabecera, miFactura, altura, Col, margen_izquierdo, pag_actual, inicio_pag_actual,
                                        TotalBultos, TotalPiezas, TotalKgBrutos, TotalKgNetos, TotalImporte,
                                        ImpEnvases)

            'Pie
            ImprimePieAlbaranSalida(DatosCabecera, miFactura, altura, margen_izquierdo, pag_actual, inicio_pag_actual)



            'Añadimos el documento al informe
            Informe.AñadeDetalles(miFactura)



            'Impresión / previsualización / exportación
            Select Case TipoImpresion

                Case TipoImpresion.Preliminar
                    Informe.Preliminar(DevExpress.LookAndFeel.UserLookAndFeel.Default)

                Case TipoImpresion.ImpresoraSeleccionada
                    If Impresora.Trim <> "" Then
                        Informe.ImpresionDirecta(Impresora)
                    Else
                        Informe.ImpresionDirecta()
                    End If

                Case TipoImpresion.ExportacionPDF
                    If rutaPDF.Trim <> "" And archivoPDF.Trim <> "" Then
                        Informe.Contenedor.CreateDocument()
                        Try
                            Dim options As New DevExpress.XtraPrinting.PdfExportOptions
                            options.Compressed = True
                            Informe.Contenedor.ExportToPdf(rutaPDF & archivoPDF, options)

                        Catch ex As Exception
                            err.Muestraerror("Error al exportar el documento con id" & IdAlbaran & " a PDF", "ImprimirAlbaranFactura", ex.Message)
                        End Try

                    Else
                        Informe.ImpresionDirecta()
                    End If

                Case Else
                    Informe.ImpresionDirecta()
            End Select


            Informe.Dispose()

        Else
            XtraMessageBox.Show("No hay datos que imprimir", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub


    Private Sub ObtenerDatosCabecera(ByRef DatosCabecera As DatosCabecera, IdAlbaran As String)

        Dim TipoIva As New E_tiposiva(Idusuario, cn)

        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
        Dim TiposClientes As New E_Tiposclientes(Idusuario, cn)
        Dim TipoIvaRepercutido As New E_TipoIvaRepercutido(Idusuario, CnCtb)

        'Comprueba que pueda leer el albarán/la factura y obtiene los datos de la cabecera
        If Not AlbSalida.LeerId(IdAlbaran) Then
            XtraMessageBox.Show("No existe el albarán con Id " & IdAlbaran, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


        DatosCabecera.IdAlbaran = AlbSalida.ASA_idalbaran.Valor
        DatosCabecera.NumAlbaran = AlbSalida.ASA_albaran.Valor
        DatosCabecera.MatriculaCamion = AlbSalida.ASA_matriculacamion.Valor & ""
        DatosCabecera.MatriculaRemolque = AlbSalida.ASA_matricularemolque.Valor & ""
        DatosCabecera.Observaciones = AlbSalida.ASA_observaciones.Valor & ""
        DatosCabecera.Referencia = AlbSalida.ASA_referencia.Valor & ""
        DatosCabecera.IdValeEnvase = AlbSalida.ASA_idvaleenvase.Valor & ""
        DatosCabecera.ValorCambio = VaDec(AlbSalida.ASA_valorcambio.Valor)

        DatosCabecera.IdCliente = VaInt(AlbSalida.ASA_idcliente.Valor)
        If VaDate(AlbSalida.ASA_fechasalida.Valor) <> VaDate("") Then DatosCabecera.Fecha = VaDate(AlbSalida.ASA_fechasalida.Valor).ToString("dd/MM/yyyy")


        'Datos cliente
        Dim Clientes As New E_Clientes(Idusuario, cn)
        If Clientes.LeerId(DatosCabecera.IdCliente) Then

            DatosCabecera.NIF = (Clientes.CLI_Nif.Valor & "").Trim
            DatosCabecera.Nombre = (Clientes.CLI_Nombre.Valor & "").Trim
            DatosCabecera.Domicilio = (Clientes.CLI_Domicilio.Valor & "").Trim
            DatosCabecera.Poblacion = (Clientes.CLI_Poblacion.Valor & "").Trim
            DatosCabecera.Provincia = (Clientes.CLI_Provincia.Valor & "").Trim
            DatosCabecera.CPostal = (Clientes.CLI_CPostal.Valor & "").Trim

            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(Clientes.CLI_IdTipo, "IdTipo")
            consulta.SelCampo(Clientes.CLI_Iddivisa, "IdDivisa")
            consulta.SelCampo(Clientes.CLI_IdPais, "Idpais")
            consulta.SelCampo(TiposClientes.TPC_idtipoiva, "IdTipoIva", Clientes.CLI_IdTipo, TiposClientes.TPC_idtipo)
            consulta.SelCampo(TiposClientes.TPC_exentoiva, "ExentoIVA")
            consulta.SelCampo(TiposClientes.TPC_recequivalencia, "RecargoEq")
            consulta.SelCampo(TiposClientes.TPC_ctaventas, "CtaVentas")
            consulta.SelCampo(TiposClientes.TPC_ctaenvases, "CtaEnvases")
            consulta.SelCampo(TiposClientes.TPC_ctavarios, "CtaVarios")
            consulta.WheCampo(Clientes.CLI_Codigo, "=", VaInt(DatosCabecera.IdCliente))

            Dim dt As DataTable = Clientes.MiConexion.ConsultaSQL(consulta.SQL)
            If dt.Rows.Count > 0 Then

                Dim row As DataRow = dt.Rows(0)
                Dim ExentoIVA As String = (row("ExentoIVA").ToString & "").Trim.ToUpper
                Dim RecargoEq As String = (row("RecargoEq").ToString & "").Trim.ToUpper



                Dim dtIva As DataTable = TipoIva.Tabla
                For Each rw In dtIva.Rows
                    Select Case rw("id").ToString


                        Case "1"
                            If ExentoIVA <> "S" Then DatosCabecera.Iva1 = VaDec(rw("iva"))
                            If RecargoEq = "S" Then DatosCabecera.Re1 = VaDec(rw("re"))
                        Case "2"
                            If ExentoIVA <> "S" Then DatosCabecera.Iva2 = VaDec(rw("iva"))
                            If RecargoEq = "S" Then DatosCabecera.Re2 = VaDec(rw("re"))


                    End Select

                Next

            End If

            '            Dim consulta As New Cdatos.E_select
            '            consulta.SelCampo(Clientes.CLI_IdTipo, "IdTipo")
            '            consulta.SelCampo(TiposClientes.TPC_idtipoiva, "IdTipoIva", Clientes.CLI_IdTipo, TiposClientes.TPC_idtipo)
            '            consulta.SelCampo(TiposClientes.TPC_exentoiva, "ExentoIVA")
            '            consulta.SelCampo(TiposClientes.TPC_recequivalencia, "RecargoEq")
            '            consulta.SelCampo(TipoIvaRepercutido.Iva1, , TiposClientes.TPC_idtipoiva, TipoIvaRepercutido.IdIva)
            '            consulta.SelCampo(TipoIvaRepercutido.Iva2)
            '            consulta.SelCampo(TipoIvaRepercutido.Iva3)
            '            consulta.SelCampo(TipoIvaRepercutido.Iva4)
            '            consulta.SelCampo(TipoIvaRepercutido.TipoRe1)
            '            consulta.SelCampo(TipoIvaRepercutido.TipoRe2)
            '            consulta.SelCampo(TipoIvaRepercutido.TipoRe3)
            '            consulta.SelCampo(TipoIvaRepercutido.TipoRe4)
            '            consulta.WheCampo(Clientes.CLI_Codigo, "=", VaInt(DatosCabecera.IdCliente))
            '
            '            Dim dt As DataTable = Clientes.MiConexion.ConsultaSQL(consulta.SQL)
            '            If dt.Rows.Count > 0 Then
            '
            '            Dim row As DataRow = dt.Rows(0)
            '            Dim ExentoIVA As String = (row("ExentoIVA").ToString & "").Trim.ToUpper
            '            Dim RecargoEq As String = (row("RecargoEq").ToString & "").Trim.ToUpper
            '
            '            If ExentoIVA <> "S" Then
            ' DatosCabecera.Iva1 = VaDec(row("Iva1"))
            ' DatosCabecera.Iva2 = VaDec(row("Iva2"))
            '        End If
            '
            '            If RecargoEq = "S" Then
            ' DatosCabecera.Re1 = VaDec(row("TipoRe1"))
            ' DatosCabecera.Re2 = VaDec(row("TipoRe2"))
            'End If

            '        End If


        End If



        'Importes de las bases, iva y re

        Dim TotalGenero As Decimal = AlbSalida.TotalGenero(IdAlbaran, False)
        Dim Tk As Decimal = 0
        Dim Tb As Decimal = 0
        Dim Tp As Decimal = 0
        Dim sql As String = "Select sum(ASL_KILOSCLIENTE) AS KILOS,SUM(ASL_BULTOS) AS BULTOS,SUM(ASL_PALETS) AS PALETS FROM ALBSALIDA_LINEAS WHERE ASL_IDALBARAN=" + IdAlbaran
        Dim DTt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)
        If Not DTt Is Nothing Then
            If DTt.Rows.Count > 0 Then
                Tk = VaDec(DTt.Rows(0)("KILOS"))
                Tb = VaDec(DTt.Rows(0)("BULTOS"))
                Tp = VaDec(DTt.Rows(0)("PALETS"))

            End If
        End If

        Dim TotalGastos As Decimal = GastosFacturaSalida(IdAlbaran, Tk, Tb, Tp, TotalGenero)

        Dim TotalEnvases As Decimal = AlbSalida.TotalEnvases(AlbSalida.ASA_idvaleenvase.Valor)

        DatosCabecera.Base1 = TotalGenero - TotalGastos
        DatosCabecera.Base2 = TotalEnvases
        DatosCabecera.TotalGastos = TotalGastos


        DatosCabecera.CuotaIVA1 = (DatosCabecera.Base1 * DatosCabecera.Iva1 / 100).ToString("#,##0.00")
        DatosCabecera.CuotaRe1 = (DatosCabecera.Base1 * DatosCabecera.Re1 / 100).ToString("#,##0.00")

        DatosCabecera.CuotaIVA2 = (DatosCabecera.Base2 * DatosCabecera.Iva2 / 100).ToString("#,##0.00")
        DatosCabecera.CuotaRe2 = (DatosCabecera.Base2 * DatosCabecera.Re2 / 100).ToString("#,##0.00")


    End Sub


    Private Sub ImprimeCabeceraAlbaranSalida(DatosCabecera As DatosCabecera, ByRef miFactura As miFactura, ByRef altura As Integer,
                                              ByRef inicio_pag_actual As Integer, margen_izquierdo As Integer, Col As List(Of Integer),
                                              ByRef BaseLineasDetalle As Integer)


        Dim titulo As String = "ALBARAN"


        'Imprime cabecera
        inicio_pag_actual = altura


        miFactura.Titulo(DatosCabecera.DatosEmpresa.FilaDatos(), 117, altura, 90, 14, milinea.stilos.MinimaBold)
        altura = altura + 12


        If DatosCabecera.EsCopia Then
            miFactura.Titulo("##### COPIA #####", 135, altura, 52, 5, milinea.stilos.GrandeBold)
        End If
        altura = altura + 6


        miFactura.Cuadro(margen_izquierdo, altura, 100, 30, 0.25, Color.Black)
        miFactura.Titulo(DatosCabecera.Nombre, margen_izquierdo + 5, altura + 3, 91, 5, milinea.stilos.GrandeBold)
        miFactura.Titulo(DatosCabecera.Domicilio, margen_izquierdo + 5, altura + 9, 91, 5, milinea.stilos.GrandeBold)
        miFactura.Titulo(DatosCabecera.Poblacion, margen_izquierdo + 5, altura + 15, 91, 5, milinea.stilos.GrandeBold)
        miFactura.Titulo(DatosCabecera.Provincia & " " & DatosCabecera.CPostal, margen_izquierdo + 5, altura + 21, 91, 5, milinea.stilos.GrandeBold)
        altura = altura + 4

        miFactura.Titulo(DatosCabecera.DatosEmpresa.NombreEmpresa, margen_izquierdo + 1, altura - 9, 98, 5, milinea.stilos.NormalBold, "=")

        miFactura.Cuadro(140, altura, 55, 10, 0.25, Color.Black)
        miFactura.LineaH(140, altura + 5, 55, 0.25, Color.Black)
        miFactura.LineaV(170, altura, 10, 0.25, Color.Black)
        miFactura.Titulo("FECHA", 143, altura + 1, 22, 5, milinea.stilos.ReducidaBold)
        miFactura.Titulo(DatosCabecera.Fecha, 139, altura + 6, 24, 5, milinea.stilos.Reducida, "=")
        miFactura.Titulo(titulo, 175, altura + 1, 22, 5, milinea.stilos.ReducidaBold)
        miFactura.Titulo(DatosCabecera.NumAlbaran, 175, altura + 6, 26, 5, milinea.stilos.Reducida, "=")
        altura = altura + 13
        miFactura.Cuadro(140, altura, 55, 10, 0.25, Color.Black)
        miFactura.LineaH(140, altura + 5, 55, 0.25, Color.Black)
        miFactura.LineaV(170, altura, 10, 0.25, Color.Black)
        miFactura.Titulo("N.I.F.", 143, altura + 1, 22, 5, milinea.stilos.ReducidaBold)
        miFactura.Titulo(DatosCabecera.NIF, 139, altura + 6, 24, 5, milinea.stilos.Reducida, "=")
        miFactura.Titulo("CODIGO", 175, altura + 1, 22, 5, milinea.stilos.ReducidaBold)
        miFactura.Titulo(VaInt(DatosCabecera.IdCliente).ToString("00000"), 171, altura + 6, 24, 5, milinea.stilos.Reducida, "=")
        altura = altura + 10 + 3 + 5


        'Solo le pasamos Col si queremos imprimir la cabecera del detalle
        If Not IsNothing(Col) Then

            'Guardo el principio del detalle para dibujar luego las lineas verticales laterales de la factura
            BaseLineasDetalle = altura

            miFactura.LineaH(margen_izquierdo, altura, 190, 0.25, Color.Black)
            miFactura.LineaH(margen_izquierdo, altura + 5, 190, 0.25, Color.Black)
            miFactura.Titulo("Producto", Col(1) + 1, altura + 1, 18, 5, milinea.stilos.ReducidaBold)
            ' miFactura.Titulo("Confeccion", Col(2), altura + 1, 25, 5, milinea.stilos.ReducidaBold)
            miFactura.Titulo("Cat/Cal", Col(3), altura + 1, 55, 5, milinea.stilos.ReducidaBold)
            miFactura.Titulo("Marca", Col(4), altura + 1, 20, 5, milinea.stilos.ReducidaBold)
            miFactura.Titulo("Bultos", Col(5), altura + 1, 25, 5, milinea.stilos.ReducidaBold)
            miFactura.Titulo("Piezas", Col(6), altura + 1, 25, 5, milinea.stilos.ReducidaBold)
            miFactura.Titulo("K.Brutos", Col(7), altura + 1, 25, 5, milinea.stilos.ReducidaBold)
            miFactura.Titulo("K.Netos", Col(8), altura + 1, 25, 5, milinea.stilos.ReducidaBold)
            miFactura.Titulo("Precio", Col(9), altura + 1, 25, 5, milinea.stilos.ReducidaBold)
            miFactura.Titulo("Importe", Col(10), altura + 1, 25, 5, milinea.stilos.ReducidaBold)

            altura = altura + 5
            altura = altura + 2

        End If



    End Sub


    Private Sub ImprimeDetalleAlbaranSalida(DatosCabecera As DatosCabecera, ByRef miFactura As miFactura, ByRef altura As Integer, margen_izquierdo As Integer,
                                      BaseLineas As Integer, Col As List(Of Integer), ByRef pag_actual As Integer, ByRef inicio_pag_actual As Integer,
                                      ByRef TotalBultos As Decimal, ByRef TotalPiezas As Decimal, ByRef TotalKgBrutos As Decimal,
                                      ByRef TotalKgNetos As Decimal, ByRef TotalImporte As Decimal,
                                      ImpEnvases As Decimal)


        'Líneas Detalle
        Dim dtLineas As DataTable = GeneraLineasImpresion(DatosCabecera.IdAlbaran)


        'Debug
        'Dim dt As DataTable = dtLineas.Copy
        'For indice As Integer = 0 To 20
        '    For Each row As DataRow In dtLineas.Rows
        '        dt.ImportRow(row)
        '    Next
        'Next
        'dtLineas = dt



        'TODO: GlobalGAP



        If Not IsNothing(dtLineas) Then

            For Each row As DataRow In dtLineas.Rows

                Dim Genero As String = (row("Genero").ToString & "").Trim
                Dim Confeccion As String = (row("Confeccion").ToString & "").Trim
                Dim Categoria As String = (row("Categoria").ToString & "").Trim
                Dim Marca As String = (row("Marca").ToString & "").Trim
                Dim Bultos As Decimal = VaDec(row("Bultos"))
                Dim Piezas As Decimal = VaDec(row("Piezas"))
                Dim KgBrutos As Decimal = VaDec(row("KgBrutos"))
                Dim KgNetos As Decimal = VaDec(row("KgCliente"))
                Dim Precio As Decimal = VaDec(row("Precio"))
                Dim Importe As Decimal = VaDec(row("Importe"))
                Dim Presentacion As String = (row("presentacion").ToString & "").Trim

                Dim linea As New LineaAlbaran(Genero, Confeccion, Categoria, Marca, Bultos, Piezas, KgBrutos, KgNetos, Precio, Importe, presentacion)
                ImprimeLineaAlbaranSalida(DatosCabecera, miFactura, linea, altura, Col, pag_actual, inicio_pag_actual, margen_izquierdo, BaseLineas)

                'Acumulamos totales
                TotalBultos = TotalBultos + Bultos
                TotalPiezas = TotalPiezas + Piezas
                TotalKgBrutos = TotalKgBrutos + KgBrutos
                TotalKgNetos = TotalKgNetos + KgNetos
                TotalImporte = TotalImporte + Importe

            Next

        End If

        altura = altura + 1



        'Línea con importe envases
        If ImpEnvases <> 0 Then
            ImprimeLineaExtraAlbaranSalida(DatosCabecera, miFactura, "Importe envases: ", ImpEnvases, altura, Col, pag_actual, inicio_pag_actual, margen_izquierdo, BaseLineas)
        End If

        'Línea con importe gastos en factura
        'If GastosEnFactura <> 0 Then
        '    ImprimeLineaExtraAlbaranSalida(DatosCabecera, miFactura, "Total gastos factura: ", -GastosEnFactura, altura, Col, pag_actual, inicio_pag_actual, margen_izquierdo, BaseLineas)
        'End If



        Dim alto_detalle As Integer = altura - BaseLineas
        If alto_detalle < 135 Then
            altura = BaseLineas + 135
        End If



        'Líneas laterales
        miFactura.LineaH(margen_izquierdo, altura, 190, 0.25, Color.Black)
        miFactura.LineaV(margen_izquierdo, BaseLineas, altura - BaseLineas, 0.25, Color.Black)
        miFactura.LineaV(margen_izquierdo + 190, BaseLineas, altura - BaseLineas, 0.25, Color.Black)

        altura = altura + 2



    End Sub


    Private Sub ImprimeLineaAlbaranSalida(DatosCabecera As DatosCabecera, ByRef miFactura As miFactura, linea As LineaAlbaran,
                                    ByRef altura As Integer, Col As List(Of Integer), ByRef pag_actual As Integer, ByRef inicio_pag_actual As Integer,
                                    margen_izquierdo As Integer, ByRef BaseLineas As Integer)


        'Comprueba salto de linea
        Dim altura_linea As Integer = 4
        If CompruebaSaltoPagina(altura, altura_linea, pag_actual) Then
            pag_actual = pag_actual + 1
            ImprimeSaltoPagina(DatosCabecera, miFactura, altura, pag_actual, inicio_pag_actual, margen_izquierdo, BaseLineas, Col)
        End If


        If linea.Presentacion.Trim <> "" Then
            miFactura.Titulo(linea.Presentacion, Col(1) + 1, altura, 45 + 19, altura_linea, milinea.stilos.Reducida)

        Else
            miFactura.Titulo(linea.Genero, Col(1) + 1, altura, 45, altura_linea, milinea.stilos.Reducida)
            miFactura.Titulo(linea.Confeccion, Col(2), altura, 19, altura_linea, milinea.stilos.Reducida)

        End If

        miFactura.Titulo(linea.Categoria, Col(3), altura, 14, altura_linea, milinea.stilos.Reducida)
        miFactura.Titulo(linea.Marca, Col(4), altura, 19, altura_linea, milinea.stilos.Reducida)
        If linea.Bultos > 0 Then miFactura.Titulo(linea.Bultos.ToString("#,##0"), Col(5), altura, 12, altura_linea, milinea.stilos.Reducida, ">")
        If linea.Piezas > 0 Then miFactura.Titulo(linea.Piezas.ToString("#,##0"), Col(6), altura, 11, altura_linea, milinea.stilos.Reducida, ">")
        If linea.KgBrutos > 0 Then miFactura.Titulo(linea.KgBrutos.ToString("#,##0"), Col(7), altura, 14, altura_linea, milinea.stilos.Reducida, ">")
        If linea.KgNetos > 0 Then miFactura.Titulo(linea.KgNetos.ToString("#,##0"), Col(8), altura, 14, altura_linea, milinea.stilos.Reducida, ">")
        If linea.Precio > 0 Then miFactura.Titulo(linea.Precio.ToString("#,##0.00000"), Col(9), altura, 13, altura_linea, milinea.stilos.Reducida, ">")
        If linea.Importe > 0 Then miFactura.Titulo(linea.Importe.ToString("#,##0.00"), Col(10), altura, 17, altura_linea, milinea.stilos.Reducida, ">")

        altura = altura + altura_linea


    End Sub


    Private Sub ImprimeLineaExtraAlbaranSalida(DatosCabecera As DatosCabecera, ByRef miFactura As miFactura, concepto As String, importe As Decimal,
                                    ByRef altura As Integer, Col As List(Of Integer), ByRef pag_actual As Integer, ByRef inicio_pag_actual As Integer,
                                    margen_izquierdo As Integer, ByRef BaseLineas As Integer)

        'Comprueba salto de linea
        Dim altura_linea As Integer = 4
        If CompruebaSaltoPagina(altura, altura_linea, pag_actual) Then
            pag_actual = pag_actual + 1
            ImprimeSaltoPagina(DatosCabecera, miFactura, altura, pag_actual, inicio_pag_actual, margen_izquierdo, BaseLineas, Col)
        End If



        miFactura.Titulo(concepto, Col(1) + 1, altura, 120, altura_linea, milinea.stilos.ReducidaBold)
        miFactura.Titulo(importe.ToString("#,##0.00"), Col(10), altura, 17, altura_linea, milinea.stilos.Reducida, ">")

        altura = altura + altura_linea

    End Sub



    Private Sub ImprimeTotalesAlbaranSalida(DatosCabecera As DatosCabecera, ByRef miFactura As miFactura, ByRef altura As Integer,
                                             Col As List(Of Integer), margen_izquierdo As Integer, ByRef pag_actual As Integer,
                                             ByRef inicio_pag_actual As Integer, TotalBultos As Decimal, TotalPiezas As Decimal,
                                             TotalKgBrutos As Decimal, TotalKgNetos As Decimal, TotalImporte As Decimal,
                                             ImpEnvases As Decimal)


        'TotalImporte = TotalImporte + ImpEnvases - GastosEnFactura
        TotalImporte = TotalImporte + ImpEnvases


        miFactura.Titulo("Origen del producto: ESPAÑA", margen_izquierdo, altura - 1, 60, 4, milinea.stilos.ReducidaBold)


        'Totales Bultos, Piezas, Kg, Importe
        miFactura.Cuadro(Col(5) - 5, altura, 93, 5, 0.25, Color.Black)
        altura = altura + 1

        If TotalBultos <> 0 Then miFactura.Titulo(TotalBultos.ToString("#,##0"), Col(5), altura, 12, 4, milinea.stilos.Reducida, ">")
        If TotalPiezas <> 0 Then miFactura.Titulo(TotalPiezas.ToString("#,##0"), Col(6), altura, 11, 4, milinea.stilos.Reducida, ">")
        If TotalKgBrutos <> 0 Then miFactura.Titulo(TotalKgBrutos.ToString("#,##0"), Col(7), altura, 14, 4, milinea.stilos.Reducida, ">")
        If TotalKgNetos <> 0 Then miFactura.Titulo(TotalKgNetos.ToString("#,##0"), Col(8), altura, 14, 4, milinea.stilos.Reducida, ">")
        If TotalImporte <> 0 Then miFactura.Titulo(TotalImporte.ToString("#,##0.00"), Col(10), altura, 17, 4, milinea.stilos.Reducida, ">")


        altura = altura + 6





        miFactura.Titulo(DatosCabecera.Observaciones, 10, altura - 15, 100, 4, milinea.stilos.ReducidaBold, "<")

        'Comprueba salto de linea
        Dim alto As Integer = 31
        If CompruebaSaltoPagina(altura, alto, pag_actual) Then
            pag_actual = pag_actual + 1
            ImprimeSaltoPagina(DatosCabecera, miFactura, altura, pag_actual, inicio_pag_actual, margen_izquierdo, 0, Col)
            altura = altura + 10
        End If


        'Condiciones de compra-venta
        Dim s As String = "CONDICIONES DE COMPRA-VENTA" & vbCrLf
        s = s & "1º Recibí, con completa conformidad mercancías, precios, envases" & vbCrLf
        s = s & "e importe total de compra aquí realizada." & vbCrLf
        s = s & "2º El pago de esta compra se entiende al contado, reservándose" & vbCrLf
        s = s & "el derecho como vendedor, de la facultad de conceder un plaza" & vbCrLf
        s = s & "de liquidación no superior a 35 días." & vbCrLf
        s = s & "3º El envasado y carga de la mercancía son a cargo del comprador." & vbCrLf
        s = s & "4º En caso de litigio el comprador renuncia a su propio fuero y" & vbCrLf
        s = s & "se somete a la competencia de los Juzgados de Almería." & vbCrLf
        s = s & "5º El comprador está obligado a guardar la trazabilidad del" & vbCrLf
        s = s & "producto." & vbCrLf
        s = s & "6º Vencimiento pago: 35 días fecha salida." & vbCrLf
        s = s & "7º Operación asegurada en Crédito y Caución." & vbCrLf
        s = s & "8º Hortofrutícola Costa de Almería no se responsabiliza de" & vbCrLf
        s = s & "ninguna reclamación que no haya sido comunicada por escrito" & vbCrLf
        s = s & "en un plazo máximo de 48 horas desde la recepción de la" & vbCrLf
        s = s & "mercancía." & vbCrLf

        Dim fuente As New Font("Tahoma", 4.5)
        miFactura.Titulo(s, margen_izquierdo, altura - 4, 50, 34, milinea.stilos.Custom, , fuente)


        miFactura.Titulo("Base Imponible", 60, altura, 26, 3, milinea.stilos.MinimaBold, "=")
        miFactura.Titulo("%", 87, altura, 9, 3, milinea.stilos.MinimaBold, "=")
        miFactura.Titulo("Importe I.V.A.", 97, altura, 26, 3, milinea.stilos.MinimaBold, "=")
        miFactura.Titulo("%", 124, altura, 9, 3, milinea.stilos.MinimaBold, "=")
        miFactura.Titulo("Importe R.E.", 134, altura, 26, 3, milinea.stilos.MinimaBold, "=")

        'Gastos
        If DatosCabecera.TotalGastos <> 0 Then miFactura.Titulo("Gastos: " & DatosCabecera.TotalGastos.ToString("#,##0.00"), Col(10) - 10, altura, 27, 3, milinea.stilos.MinimaBold, ">")

        altura = altura + 3

        miFactura.LineaH(59, altura, 101, 0.25, Color.Black)
        miFactura.LineaH(59, altura + 15, 101, 0.25, Color.Black)
        miFactura.LineaV(59, altura, 15, 0.25, Color.Black)
        miFactura.LineaV(86, altura, 15, 0.25, Color.Black)
        miFactura.LineaV(96, altura, 15, 0.25, Color.Black)
        miFactura.LineaV(123, altura, 15, 0.25, Color.Black)
        miFactura.LineaV(133, altura, 15, 0.25, Color.Black)
        miFactura.LineaV(160, altura, 15, 0.25, Color.Black)

        miFactura.LineaH(165, altura, 34, 0.25, Color.Black)
        miFactura.LineaH(165, altura + 15, 34, 0.25, Color.Black)
        miFactura.LineaV(165, altura, 15, 0.25, Color.Black)
        miFactura.LineaV(199, altura, 15, 0.25, Color.Black)




        'Bases
        If VaDec(DatosCabecera.Base1) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.Base1).ToString("#,##0.00"), 59, altura + 1, 24, 5, milinea.stilos.Reducida, ">")
        If VaDec(DatosCabecera.Base2) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.Base2).ToString("#,##0.00"), 59, altura + 5, 24, 5, milinea.stilos.Reducida, ">")

        '%IVA
        If VaDec(DatosCabecera.Iva1) <> 0 And VaDec(DatosCabecera.CuotaIVA1) > 0 Then miFactura.Titulo(VaDec(DatosCabecera.Iva1).ToString("#,##0.00"), 85, altura + 1, 10, 5, milinea.stilos.Reducida, ">")
        If VaDec(DatosCabecera.Iva2) <> 0 And VaDec(DatosCabecera.CuotaIVA2) > 0 Then miFactura.Titulo(VaDec(DatosCabecera.Iva2).ToString("#,##0.00"), 85, altura + 5, 10, 5, milinea.stilos.Reducida, ">")

        'CuotaIVA
        If VaDec(DatosCabecera.CuotaIVA1) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.CuotaIVA1).ToString("#,##0.00"), 96, altura + 1, 22, 5, milinea.stilos.Reducida, ">")
        If VaDec(DatosCabecera.CuotaIVA2) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.CuotaIVA2).ToString("#,##0.00"), 96, altura + 5, 22, 5, milinea.stilos.Reducida, ">")

        '%RE
        If VaDec(DatosCabecera.Re1) <> 0 And VaDec(DatosCabecera.CuotaRe1) > 0 Then miFactura.Titulo(VaDec(DatosCabecera.Re1).ToString("#,##0.00"), 122, altura + 1, 10, 5, milinea.stilos.Reducida, ">")
        If VaDec(DatosCabecera.Re2) <> 0 And VaDec(DatosCabecera.CuotaRe1) > 0 Then miFactura.Titulo(VaDec(DatosCabecera.Re2).ToString("#,##0.00"), 122, altura + 5, 10, 5, milinea.stilos.Reducida, ">")

        'CuotaRE
        If VaDec(DatosCabecera.CuotaRe1) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.CuotaRe1).ToString("#,##0.00"), 133, altura + 1, 23, 5, milinea.stilos.Reducida, ">")
        If VaDec(DatosCabecera.CuotaRe2) <> 0 Then miFactura.Titulo(VaDec(DatosCabecera.CuotaRe2).ToString("#,##0.00"), 133, altura + 5, 23, 5, milinea.stilos.Reducida, ">")

        'Totales bases 

        Dim TotalBase1 As Decimal = VaDec(DatosCabecera.Base1) + VaDec(DatosCabecera.CuotaIVA1) + VaDec(DatosCabecera.CuotaRe1)
        Dim TotalBase2 As Decimal = VaDec(DatosCabecera.Base2) + VaDec(DatosCabecera.CuotaIVA2) + VaDec(DatosCabecera.CuotaRe2)
        Dim TotalFactura As Decimal = TotalBase1 + TotalBase2
        Dim TotalFacturaDivisa As Decimal = TotalFactura * DatosCabecera.ValorCambio

        If TotalBase1 <> 0 Then miFactura.Titulo(TotalBase1.ToString("#,##0.00"), Col(10), altura + 1, 17, 5, milinea.stilos.Reducida, ">")
        If TotalBase2 <> 0 Then miFactura.Titulo(TotalBase2.ToString("#,##0.00"), Col(10), altura + 5, 17, 5, milinea.stilos.Reducida, ">")


        altura = altura + 18

        miFactura.Titulo("Matriculas vehiculo:", 58, altura, 20, 4, milinea.stilos.Minima)
        miFactura.Titulo(DatosCabecera.MatriculaCamion & "  " & DatosCabecera.MatriculaRemolque, 78, altura, 25, 4, milinea.stilos.Minima)
        miFactura.Titulo("Referencia:", 58, altura + 4, 15, 4, milinea.stilos.Minima)
        miFactura.Titulo(DatosCabecera.Referencia, 73, altura + 4, 25, 4, milinea.stilos.Minima)

        miFactura.Titulo("El Comprador o persona autorizada", margen_izquierdo, altura + 8, 40, 3, milinea.stilos.MinimaBold)
        altura = altura + 4

        miFactura.Titulo("D.N.I. Nº", margen_izquierdo, altura + 14, 40, 3, milinea.stilos.MinimaBold)



        'Total factura
        If DatosCabecera.ValorCambio <= 0 Or DatosCabecera.ValorCambio = 1 Then
            miFactura.Titulo("TOTAL ALBARAN", 129, altura + 1, 30, 5, milinea.stilos.ReducidaBold, ">")
            miFactura.Titulo(TotalFactura.ToString("#,##0.00"), Col(10), altura + 1, 17, 5, milinea.stilos.Reducida, ">")
        Else
            miFactura.Titulo("TOTAL DIVISA", 129, altura + 1, 30, 5, milinea.stilos.ReducidaBold, ">")
            miFactura.Titulo(TotalFactura.ToString("#,##0.00"), Col(10), altura + 1, 17, 5, milinea.stilos.Reducida, ">")

            miFactura.Titulo("TOTAL EUROS", 129, altura + 7, 30, 5, milinea.stilos.ReducidaBold, ">")
            miFactura.LineaH(165, altura + 7, 34, 0.25, Color.Black)
            miFactura.LineaH(165, altura + 12, 34, 0.25, Color.Black)
            miFactura.LineaV(165, altura + 7, 5, 0.25, Color.Black)
            miFactura.LineaV(199, altura + 7, 5, 0.25, Color.Black)
            miFactura.Titulo(TotalFacturaDivisa.ToString("#,##0.00"), Col(10), altura + 8, 17, 5, milinea.stilos.Reducida, ">")

        End If

        miFactura.LineaH(165, altura, 34, 0.25, Color.Black)
        miFactura.LineaH(165, altura + 5, 34, 0.25, Color.Black)
        miFactura.LineaV(165, altura, 5, 0.25, Color.Black)
        miFactura.LineaV(199, altura, 5, 0.25, Color.Black)


        ''Total factura
        'miFactura.Cuadro(Col(6) - 6, altura, 34, 5, 0.25, Color.Black)
        'miFactura.Titulo(TotalFactura.ToString("#,##0.00"), Col(6) - 5, altura + 1, 30, 5, milinea.stilos.ReducidaBold, ">")


        altura = altura + 17


    End Sub



    Private Sub ImprimePieAlbaranSalida(DatosCabecera As DatosCabecera, ByRef miFactura As miFactura, ByRef altura As Integer,
                                         margen_izquierdo As Integer, ByRef pag_actual As Integer, ByRef inicio_pag_actual As Integer)


        'Comprueba salto de linea
        Dim alto As Integer = 34
        If CompruebaSaltoPagina(altura, alto, pag_actual) Then
            pag_actual = pag_actual + 1
            ImprimeSaltoPagina(DatosCabecera, miFactura, altura, pag_actual, inicio_pag_actual, margen_izquierdo, 0, Nothing)
            altura = altura + 10
        End If



        'Detalle envases
        Dim BaseAltura As Integer = altura


        'Instrucciones de pago
        Dim fuente As New Font("Tahoma", 7, FontStyle.Regular)
        Dim fuente_negrita As New Font("Tahoma", 7, FontStyle.Bold)


        miFactura.LineaH(margen_izquierdo + 110 + 2, altura, 80, 0.25, Color.Black)
        miFactura.LineaH(margen_izquierdo + 110 + 2, altura + 34, 80, 0.25, Color.Black)
        miFactura.LineaV(margen_izquierdo + 110 + 2, altura, 34, 0.25, Color.Black)
        miFactura.LineaV(margen_izquierdo + 110 + 2 + 80, altura, 34, 0.25, Color.Black)

        miFactura.Titulo("INSTRUCCIONES DE PAGO:", margen_izquierdo + 110 + 2 + 1, altura + 1, 73, 4, milinea.stilos.Custom, , fuente_negrita)
        altura = altura + 5
        miFactura.Titulo("A Vencimiento, sírvase ingresar en nuestra cuenta, como sigue:", margen_izquierdo + 110 + 3, altura, 73, 4, milinea.stilos.Custom, , fuente)
        altura = altura + 4
        miFactura.Titulo("-Banco: " & DatosCabecera.DatosEmpresa.NombreBanco, margen_izquierdo + 110 + 3, altura, 73, 4, milinea.stilos.Custom, , fuente)
        altura = altura + 4
        miFactura.Titulo("-Entidad/Sucursal: ", margen_izquierdo + 110 + 3, altura, 22, 4, milinea.stilos.Custom, , fuente)
        miFactura.Titulo(DatosCabecera.DatosEmpresa.EntidadSucursal, margen_izquierdo + 110 + 3 + 20, altura, 22, 4, milinea.stilos.Custom, , fuente_negrita)
        altura = altura + 4
        miFactura.Titulo("-IBAN: ", margen_izquierdo + 110 + 3, altura, 10, 4, milinea.stilos.Custom, , fuente)
        miFactura.Titulo(DatosCabecera.DatosEmpresa.IBAN, margen_izquierdo + 110 + 2 + 9, altura, 63, 4, milinea.stilos.Custom, , fuente_negrita)
        altura = altura + 4
        miFactura.Titulo("-Swift Code: ", margen_izquierdo + 110 + 3, altura, 17, 4, milinea.stilos.Custom, , fuente)
        miFactura.Titulo(DatosCabecera.DatosEmpresa.Swift, margen_izquierdo + 110 + 3 + 14, altura, 56, 4, milinea.stilos.Custom, , fuente_negrita)
        altura = altura + 4
        miFactura.Titulo("-Beneficiario: HORTOFRUTICOLA COSTA DE ALMERIA, S.L.", margen_izquierdo + 110 + 3, altura, 73, 4, milinea.stilos.Custom, , fuente)
        altura = altura + 4
        miFactura.Titulo("CIF: B04257028", margen_izquierdo + 110 + 3, altura, 73, 4, milinea.stilos.Custom, , fuente)



        'Saldo de envases
        altura = BaseAltura


        miFactura.LineaH(margen_izquierdo, altura, 110, 0.25, Color.Black)
        miFactura.LineaV(margen_izquierdo + 20, altura, 8, 0.25, Color.Black)
        miFactura.LineaV(margen_izquierdo + 40, altura, 8, 0.25, Color.Black)
        miFactura.Titulo("ALBARAN", margen_izquierdo + 2, altura + 1, 19, 4, milinea.stilos.MinimaBold)
        miFactura.Titulo("FECHA", margen_izquierdo + 22, altura + 1, 17, 4, milinea.stilos.MinimaBold)
        miFactura.Titulo("CLIENTE", margen_izquierdo + 42, altura + 1, 19, 4, milinea.stilos.MinimaBold)
        altura = altura + 4
        miFactura.LineaH(margen_izquierdo, altura, 110, 0.25, Color.Black)
        miFactura.Titulo(DatosCabecera.NumAlbaran, margen_izquierdo + 2, altura + 1, 18, 4, milinea.stilos.MinimaBold)
        miFactura.Titulo(DatosCabecera.Fecha, margen_izquierdo + 22, altura + 1, 18, 4, milinea.stilos.MinimaBold)
        miFactura.Titulo(DatosCabecera.IdCliente.ToString("00000") & " " & DatosCabecera.Nombre, margen_izquierdo + 42, altura + 1, 68, 3, milinea.stilos.MinimaBold)
        altura = altura + 4
        miFactura.LineaH(margen_izquierdo, altura, 110, 0.25, Color.Black)
        miFactura.Titulo("ENVASE", margen_izquierdo + 2, altura + 1, 19, 4, milinea.stilos.MinimaBold)
        miFactura.Titulo("RETIRA EL " & DatosCabecera.Fecha, margen_izquierdo + 54, altura + 1, 40, 4, milinea.stilos.MinimaBold)
        miFactura.Titulo("ENTREGA", margen_izquierdo + 94, altura + 1, 13, 4, milinea.stilos.MinimaBold)
        altura = altura + 4

        miFactura.LineaH(margen_izquierdo, altura, 110, 0.25, Color.Black)


        'Detalle vale envases
        Dim dtEnvases As DataTable = DetalleValeEnvases(DatosCabecera.IdValeEnvase)

        Dim cont As Integer = 1
        For Each row As DataRow In dtEnvases.Rows

            If cont > 5 Then Exit For

            Dim Envase As String = row("Envase").ToString & ""
            Dim Retira As String = VaDec(row("Retira")).ToString("#,##0")
            Dim Entrega As String = VaDec(row("Entrega")).ToString("#,##0")

            miFactura.Titulo(Envase, margen_izquierdo + 2, altura + 1, 40, 3, milinea.stilos.Minima)
            miFactura.Titulo(Retira, margen_izquierdo + 49, altura + 1, 13, 3, milinea.stilos.Minima, ">")
            miFactura.Titulo(Entrega, margen_izquierdo + 91, altura + 1, 13, 3, milinea.stilos.Minima, ">")
            altura = altura + 4

            cont = cont + 1

        Next




        If altura - BaseAltura < 34 Then
            altura = BaseAltura + 34
        Else
            altura = altura + 3
        End If


        'Linea final horizontal
        miFactura.LineaH(margen_izquierdo, altura, 110, 0.25, Color.Black)

        'Lineas laterales
        miFactura.LineaV(margen_izquierdo, BaseAltura, altura - BaseAltura, 0.25, Color.Black)
        miFactura.LineaV(margen_izquierdo + 110, BaseAltura, altura - BaseAltura, 0.25, Color.Black)



        Dim salto As Integer = ((297 - 15) * (pag_actual))
        miFactura.LineaH(0, salto - 1, 210, 0.25, Color.Transparent)
        miFactura.SaltoPagina(salto)


    End Sub



    Private Function CompruebaSaltoPagina(altura As Integer, altura_linea As Integer, pag_actual As Integer) As Boolean

        Dim bRes As Boolean = False

        'Detectamos si debe efectuarse un salto de página
        Dim pagina As Integer = ((altura + altura_linea) \ 282) + 1
        If pagina > pag_actual Then
            bRes = True
        End If


        Return bRes

    End Function


    Private Sub ImprimeSaltoPagina(DatosCabecera As DatosCabecera, ByRef miFactura As miFactura, ByRef altura As Integer,
                                          ByRef pag_actual As Integer, ByRef inicio_pag_actual As Integer, margen_izquierdo As Integer,
                                          ByRef BaseLineas As Integer, Col As List(Of Integer))


        'Líneas laterales
        If BaseLineas > 0 Then
            miFactura.LineaH(margen_izquierdo, altura, 190, 0.25, Color.Black)
            miFactura.LineaV(margen_izquierdo, BaseLineas, altura - BaseLineas, 0.25, Color.Black)
            miFactura.LineaV(margen_izquierdo + 190, BaseLineas, altura - BaseLineas, 0.25, Color.Black)
        End If


        Dim salto As Integer = ((297 - 15) * (pag_actual - 1))

        'Para asegurarnos de que el pie de página no suba
        miFactura.LineaH(0, salto - 1, 210, 0.25, Color.Transparent)
        miFactura.SaltoPagina(salto)

        altura = salto
        altura = altura + 7


        ImprimeCabeceraAlbaranSalida(DatosCabecera, miFactura, altura, inicio_pag_actual, margen_izquierdo, Col, BaseLineas)


    End Sub


    Private Function GeneraLineasImpresion(IdAlbaran As String) As DataTable

        Dim sql As String = "SELECT ASL_IdGenero as IdGenero, GEN_NombreGenero as Genero, CEV_Nombre as Confeccion, ASL_Categoria as Categoria," & vbCrLf
        sql = sql & " ASL_IdMarca as IdMarca, MAR_Nombre as Marca, ASL_IdTipoConfeccion as IdTipoConfeccion,GES_Nombre as presentacion," & vbCrLf
        sql = sql & " COALESCE(ASL_Bultos,0) as Bultos, COALESCE(ASL_Piezas,0) as Piezas, " & vbCrLf
        sql = sql & " COALESCE(ASL_KilosBrutos,0) as KgBrutos, COALESCE(ASL_KilosCliente,0) as KgCliente," & vbCrLf
        sql = sql & " ASL_TipoPrecio as TipoPrecio, " & vbCrLf
        sql = sql & " COALESCE(ASL_Precio,0) as Precio," & vbCrLf

        'sql = sql & " CASE ASL_TipoPrecio" & vbCrLf
        'sql = sql & " WHEN 'K' THEN COALESCE(ASL_Precio,0) * COALESCE(ASL_KilosCliente,0)" & vbCrLf
        'sql = sql & " WHEN 'B' THEN COALESCE(ASL_Precio,0) * COALESCE(ASL_Bultos,0)" & vbCrLf
        'sql = sql & " WHEN 'P' THEN COALESCE(ASL_Precio,0) * COALESCE(ASL_Piezas,0)" & vbCrLf
        'sql = sql & " ELSE 0.00 END as Importe" & vbCrLf
        sql = sql & " COALESCE(ASL_ImporteGenero, 0) AS Importe" & vbCrLf
        sql = sql & " FROM AlbSalida_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = ASL_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN GenerosSalida ON GES_IdGensal = ASL_Idgensal" & vbCrLf
        sql = sql & " LEFT JOIN Marcas ON MAR_IdMarca = ASL_IdMarca" & vbCrLf
        sql = sql & " LEFT JOIN ConfecEnvase ON CEV_IdConfec = ASL_IdTipoConfeccion" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida ON ASA_IdAlbaran = ASL_IdAlbaran" & vbCrLf
        sql = sql & " WHERE ASL_IdAlbaran = " & IdAlbaran & vbCrLf


        'Dim sql2 As String = "SELECT IdGenero, Genero, Confeccion, Categoria, IdMarca, Marca, IdTipoConfeccion," & vbCrLf
        'sql2 = sql2 & " SUM(Bultos) as Bultos, SUM(Piezas) as Piezas, SUM(KgBrutos) as KgBrutos, SUM(KgCliente) as KgCliente," & vbCrLf
        'sql2 = sql2 & " " & vbCrLf
        'sql2 = sql2 & " Precio, SUM(Importe) as Importe" & vbCrLf
        'sql2 = sql2 & " FROM (" & vbCrLf & sql & vbCrLf & ") as G" & vbCrLf
        'sql2 = sql2 & " GROUP BY IdGenero, Genero, IdTipoConfeccion, Confeccion, Categoria, IdMarca, Marca, Precio" & vbCrLf
        'sql2 = sql2 & " ORDER BY IdGenero" & vbCrLf


        Dim dt As DataTable = cn.ConsultaSQL(sql)

        Return dt

    End Function


    Private Function ImporteEnvases(IdValeEnvase As String) As Decimal

        Dim res As Decimal = 0

        If VaInt(IdValeEnvase) > 0 Then

            Dim AlbSalida As New E_AlbSalida(Idusuario, cn)

            Dim sql As String = "SELECT SUM(VEL_RETIRA*VEL_PRECIORETIRA)-SUM(VEL_ENTREGA*VEL_PRECIOENTREGA) AS ImporteEnvases FROM valeenvases_lineas where VEL_IDVALE = " & IdValeEnvase

            Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    res = VaDec(dt.Rows(0)("ImporteEnvases"))
                End If
            End If

        End If

        Return res

    End Function

    Private Function GastosFacturaSalida(idalbaran As String, kilos As Double, bultos As Double, palets As Double, igenero As Double) As Decimal

        Dim ret As Decimal

        If VaInt(idalbaran) > 0 Then

            Dim sql As String = "Select ASG_tipokbp as tipo, ASG_valorgasto as vgasto from albsalida_gastos where asg_idalbaran=" & idalbaran + " and asg_tipofc='F'"
            Dim dt As DataTable = cn.ConsultaSQL(sql)

            If Not IsNothing(dt) Then
                For Each rw In dt.Rows
                    Dim igasto As Decimal = 0
                    Dim vgasto As Decimal = VaDec(rw("vgasto"))
                    Select Case rw("tipo").ToString
                        Case "K"
                            igasto = kilos * vgasto
                        Case "B"
                            igasto = bultos * vgasto
                        Case "P"
                            igasto = palets * vgasto
                        Case "I"
                            igasto = vgasto
                        Case "%"
                            igasto = igenero * vgasto / 100
                    End Select
                    ret = ret + igasto
                Next
            End If

        End If



        Return ret

    End Function


    'Private Function GastosFactura(IdAlbaran) As Decimal

    '    Dim res As Decimal = 0

    '    If VaInt(IdAlbaran) > 0 Then

    '        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)

    '        Dim sql As String = "Select SUM(ASG_importegastodivisa) as Importe from albsalida_gastos where ASG_idalbaran = " & IdAlbaran & " and ASG_tipofc = 'F'"
    '        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)

    '        If Not IsNothing(dt) Then
    '            If dt.Rows.Count > 0 Then
    '                res = VaDec(dt.Rows(0)("Importe"))
    '            End If
    '        End If

    '    End If


    '    Return res

    'End Function


    Private Function DetalleValeEnvases(IdValeEnvases As String) As DataTable

        Dim dt As New DataTable


        If VaInt(IdValeEnvases) > 0 Then

            Dim AlbSalida As New E_AlbSalida(Idusuario, cn)

            Dim sql As String = "SELECT ENV_Nombre as Envase, VEL_Retira as Retira, VEL_Entrega as Entrega" & vbCrLf
            sql = sql & " FROM valeenvases_lineas" & vbCrLf
            sql = sql & " LEFT JOIN Envases ON VEL_IdEnvase = ENV_IdEnvase" & vbCrLf
            sql = sql & " WHERE VEL_IdVale = " & IdValeEnvases & vbCrLf
            sql = sql & " ORDER BY ENV_Nombre"

            dt = AlbSalida.MiConexion.ConsultaSQL(sql)

        End If


        Return dt

    End Function


    

#End Region



End Module
