Imports System.Drawing
Imports DevExpress.XtraEditors


Module C1_FacturacionComercializacion

    Private margen_izquierdo As Integer = 9
    Dim ancho_linea As Decimal = 2
    Dim Pie_linea As Integer = 282

    Dim fuente_envase As New Font("Tahoma", 8, FontStyle.Italic)
    Dim fuente As New Font("Tahoma", 7, FontStyle.Regular)
    Dim fuente_negrita As New Font("Tahoma", 7, FontStyle.Bold)

    Dim altura_impreso As Integer = 81


#Region "Clases para impresión factura"


    Private Class LineaDesgloseAlbaran

        Public IdAlbaran As String = ""
        Public NumAlbaran As String = ""
        Public FechaAlbaran As String = ""
        Public Genero As String = ""
        Public Confeccion As String = ""
        Public Categoria As String = ""
        Public Marca As String = ""
        Public Bultos As Decimal = 0
        Public Piezas As Decimal = 0
        Public KgCliente As Decimal = 0
        Public Precio As Decimal = 0
        Public TipoPrecio As String = ""
        Public Importe As Decimal = 0
        Public Presentacion As String = ""
        Public Controlado As String = ""
        Public Acreditado As String = ""



        Public Sub New(IdAlbaran As String, NumAlbaran As String, FechaAlbaran As String,
                      Genero As String, Confeccion As String, Categoria As String, Marca As String, Bultos As Decimal, Piezas As Decimal,
                       KgCliente As Decimal, Precio As Decimal, TipoPrecio As String, Importe As Decimal, Presentacion As String,
                       Controlado As String, Acreditado As String)

            Me.IdAlbaran = IdAlbaran
            Me.NumAlbaran = NumAlbaran
            Me.FechaAlbaran = FechaAlbaran
            Me.Genero = Genero
            Me.Categoria = Categoria
            Me.Confeccion = Confeccion
            Me.Categoria = Categoria
            Me.Marca = Marca
            Me.Bultos = Bultos
            Me.Piezas = Piezas
            Me.KgCliente = KgCliente
            Me.Precio = Precio
            Me.TipoPrecio = TipoPrecio
            Me.Importe = Importe
            Me.Presentacion = Presentacion
            Me.Controlado = Controlado
            Me.Acreditado = Acreditado

        End Sub

    End Class


    Private Class LineaDesgloseEnvase

        Public Envase As String = ""
        Public Bultos As Decimal = 0
        Public Precio As Decimal = 0
        Public Importe As Decimal = 0

        Public Sub New(Envase As String, Bultos As Decimal, Precio As Decimal, Importe As Decimal)
            Me.Envase = Envase
            Me.Bultos = Bultos
            Me.Precio = Precio
            Me.Importe = Importe
        End Sub

    End Class


    Private Class LineaDesgloseConceptos

        Public Producto As String = ""
        Public Cantidad As Decimal = 0
        Public Precio As Decimal = 0
        Public Importe As Decimal = 0
        Public Tipo As String = ""

        Public Sub New(Producto As String, Cantidad As Decimal, Precio As Decimal, Importe As Decimal, Tipo As String)
            Me.Producto = Producto
            Me.Cantidad = Cantidad
            Me.Precio = Precio
            Me.Importe = Importe
            Me.Tipo = Tipo
        End Sub

    End Class


#End Region


#Region "Facturas"


    Public Sub C1_EnviarFacturaComercializacion(IdFactura As String)


        Dim Facturas As New E_Facturas(Idusuario, cn)

        If Facturas.LeerId(IdFactura) Then

            C1_ImprimirFacturaComercializacion(IdFactura, TipoImpresion.Email)

        Else
            MsgBox("No se puede leer la factura con Id: " & IdFactura)
        End If


    End Sub


    Public Sub C1_GestionDocumentalFacturasComercializacion(IdFactura As String)


        Dim Facturas As New E_Facturas(Idusuario, cn)

        If Facturas.LeerId(IdFactura) Then


            Dim Impreso As Impreso = C1_AñadirFacturaComercializacion(IdFactura, TipoImpresion.ImpresoraPorDefecto, Facturas)



            If Not IsNothing(Impreso) Then

                GeneraGestionDocumental(Impreso, Facturas)

            End If



        Else
            XtraMessageBox.Show("Error al leer la factura con id: " & IdFactura, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub


    Private Function C1_AñadirFacturaComercializacion(IdFactura As String, TipoImpresion As TipoImpresion, Facturas As E_Facturas) As Impreso

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
        Col.Add(Col(1) + 59)        'Col2
        Col.Add(Col(2) + 17)        'Col3
        Col.Add(Col(3) + 30)        'Col4
        Col.Add(Col(4) + 15)        'Col5
        Col.Add(Col(5) + 18)        'Col6
        Col.Add(Col(6) + 17)        'Col7
        Col.Add(Col(7) + 16)        'Col8


        'Cabecera
        Dim BaseLineas As Integer = 0
        Dim altura As Integer = 7


        'Gastos envases y gastos en factura
        Dim ImpEnvases As Decimal = 0
        Dim GastosEnFactura As Decimal = 0

        'Detalle y totales detalle
        Dim TotalBultos As Decimal = 0
        Dim TotalPiezas As Decimal = 0
        Dim TotalKgNetos As Decimal = 0
        Dim TotalImporte As Decimal = 0


        Dim bLeyendaControlado As Boolean = False
        Dim bLeyendaNOAcreditado As Boolean = False
        Dim bForzarControlado As Boolean = ((Clientes.CLI_ForzarGGNEnFacturas.Valor & "").Trim = "S")



        Try

            'Imprime cabecera
            ImprimeCabeceraFacturaComer(Impreso, altura, Facturas, Clientes, DatosEmpresa, Col, BaseLineas)


            'Imprime detalle
            ImprimeDetalleFacturaComer(Impreso, IdFactura, altura, BaseLineas, Col, TotalBultos, TotalPiezas, TotalKgNetos, TotalImporte,
                                        ImpEnvases, GastosEnFactura, bLeyendaControlado, bForzarControlado, bLeyendaNOAcreditado)

            'Totales
            ImprimeTotalesFacturaComer(Impreso, altura, Facturas, Col, TotalBultos, TotalPiezas, TotalKgNetos, TotalImporte, ImpEnvases, GastosEnFactura)

            'Pie
            ImprimePieFacturaComer(Impreso, DatosEmpresa, altura, Facturas, Clientes, bLeyendaControlado, bLeyendaNOAcreditado)

        Catch ex As Exception

        End Try



        Return Impreso

    End Function



    Public Sub C1_ImprimirFacturaComercializacion(IdFactura As String, TipoImpresion As TipoImpresion,
                                          Optional Impresora As String = "",
                                          Optional rutaPDF As String = "",
                                          Optional archivoPDF As String = "")


        Dim Facturas As New E_Facturas(Idusuario, cn)

        If Facturas.LeerId(IdFactura) Then



            Dim Impreso As Impreso = C1_AñadirFacturaComercializacion(IdFactura, TipoImpresion, Facturas)






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
            XtraMessageBox.Show("Error al leer la factura con id: " & IdFactura, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub


    Private Sub ImprimeCabeceraFacturaComer(ByRef Impreso As Impreso, ByRef altura As Integer,
                                              Facturas As E_Facturas, Clientes As E_Clientes, DatosEmpresa As DatosEmpresa,
                                              Col As List(Of Integer), ByRef BaseLineasDetalle As Integer)



        'CONSULTA.WheCampo(Me.FRA_idempresa, "=", IdEmpresa.ToString)
        'CONSULTA.WheCampo(Me.FRA_campa, "=", Campa.ToString)
        'CONSULTA.WheCampo(Me.FRA_serie, "=", Serie)
        'CONSULTA.WheCampo(Me.FRA_factura, "=", numfac.ToString)


        Dim CB_IdEmpresa As String = VaInt(Facturas.FRA_idempresa.Valor)
        Dim CB_Ejercicio As String = VaInt(Facturas.FRA_campa.Valor)
        Dim CB_Serie As String = (Facturas.FRA_serie.Valor & "").Trim
        Dim CB_Numero As String = (Facturas.FRA_factura.Valor & "").Trim


        'Código de barras
        Dim Code39 As New Font("C39HrP24DhTt", 42)
        Dim CodBar As String = "*FC" & CB_IdEmpresa & "." & Fnc0(CB_Ejercicio, 2) & "." & CB_Serie & "." & CB_Numero & "*"
        Impreso.Cabecera.Titulo(CodBar, 10, 7, 190, 18, Estilos.Custom, ">", , Code39)






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
            Impreso.Cabecera.Titulo("Producto", Col(1) + 1, altura + 1, 18, 5, Estilos.ReducidaBold)
            Impreso.Cabecera.Titulo("Cat/Cal", Col(2), altura + 1, 55, 5, Estilos.ReducidaBold)
            Impreso.Cabecera.Titulo("Marca", Col(3), altura + 1, 20, 5, Estilos.ReducidaBold)
            Impreso.Cabecera.Titulo("Bultos", Col(4), altura + 1, 25, 5, Estilos.ReducidaBold)
            Impreso.Cabecera.Titulo("Piezas", Col(5), altura + 1, 25, 5, Estilos.ReducidaBold)
            Impreso.Cabecera.Titulo("K.Netos", Col(6), altura + 1, 25, 5, Estilos.ReducidaBold)
            Impreso.Cabecera.Titulo("Precio", Col(7), altura + 1, 25, 5, Estilos.ReducidaBold)
            Impreso.Cabecera.Titulo("Importe", Col(8), altura + 1, 25, 5, Estilos.ReducidaBold)

            altura = altura + 5
            altura = altura + 2

        End If



    End Sub


    Private Sub ImprimeDetalleFacturaComer(ByRef Impreso As Impreso, IdFactura As String, ByRef altura As Integer,
                                           BaseLineas As Integer, Col As List(Of Integer), ByRef TotalBultos As Decimal,
                                           ByRef TotalPiezas As Decimal, ByRef TotalKgNetos As Decimal, ByRef TotalImporte As Decimal,
                                           ByRef ImpEnvases As Decimal, ByRef GastosEnFactura As Decimal,
                                           ByRef bLeyendaControlado As Boolean, ByVal bForzarControlado As Boolean,
                                           ByRef bLeyendaNOAcreditado As Boolean)


        'Líneas Detalle
        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
        Dim Albsalida_Lineas As New E_AlbSalida_lineas(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
        Dim Marcas As New E_Marcas(Idusuario, cn)
        Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
        Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
        Dim Pedidos As New E_Pedidos(Idusuario, cn)
        Dim SubFamilias As New E_Subfamilias(Idusuario, cn)
        Dim FamiliasGeneros As New E_FamiliasGeneros(Idusuario, cn)




        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbSalida.ASA_idalbaran, "IdAlbaran")
        consulta.SelCampo(AlbSalida.ASA_albaran, "Albaran")
        consulta.SelCampo(AlbSalida.ASA_fechasalida, "FechaSalida")
        consulta.SelCampo(AlbSalida.ASA_idvaleenvase, "IdValeEnvase")
        consulta.SelCampo(AlbSalida.ASA_refvaloracion, "RefValoracion")
        consulta.SelCampo(AlbSalida.ASA_matriculacamion, "MatriculaCamion")
        consulta.SelCampo(AlbSalida.ASA_matricularemolque, "MatriculaRemolque")
        consulta.SelCampo(Pedidos.PED_referencia, "RefClientePedido", AlbSalida.ASA_idpedido, Pedidos.PED_idpedido)
        consulta.WheCampo(AlbSalida.ASA_idfactura, "=", IdFactura)
        Dim dtAlbaranes As DataTable = AlbSalida.MiConexion.ConsultaSQL(consulta.SQL)


        Dim NumLineas As Integer = 0
        Dim MaxLineas As Integer = 38


        If Not IsNothing(dtAlbaranes) Then


            For Each rowAlb As DataRow In dtAlbaranes.Rows

                Dim IdAlbaran As String = rowAlb("IdAlbaran").ToString & ""
                Dim NumAlbaran As String = rowAlb("Albaran").ToString & ""

                Dim RefValoracion As String = (rowAlb("RefValoracion").ToString & "").Trim
                Dim Camion As String = (rowAlb("MatriculaCamion").ToString & "").Trim
                If Camion.Trim <> "" Then Camion = " - Mat. camión: " & Camion
                Dim Remolque As String = (rowAlb("MatriculaRemolque").ToString & "").Trim

                Dim RefClientePedido As String = (rowAlb("RefClientePedido").ToString & "").Trim

                Dim FechaSalida As String = ""
                If VaDate(rowAlb("FechaSalida")) <> VaDate("") Then FechaSalida = VaDate(rowAlb("FechaSalida")).ToString("dd/MM/yyyy")
                Dim IdValeEnvase As String = rowAlb("IdValeEnvase").ToString & ""

                Dim GastoFactura As Decimal = AlbSalida.GastosFactura(IdAlbaran)
                Dim ImporteEnvases As Decimal = AlbSalida.TotalEnvases(IdValeEnvase)

                GastosEnFactura = GastosEnFactura + GastoFactura
                ImpEnvases = ImpEnvases + ImporteEnvases


                'Cabecera del albarán

                'Temporalmente, no se van a mostrar los números de albarán (18/09/2015)
                'Impreso.Detalle.Titulo("Alb: " & NumAlbaran & " - Fec: " & FechaSalida & _
                '                       " - Ref. Val.: " & RefValoracion & " - Mat.: " & RefMatricula & _
                '                       " - Ref. Ped.: " & RefClientePedido, Col(1) + 1, altura, 185, 4, Estilos.ReducidaBold)
                'Impreso.Detalle.Titulo("Alb - Fec: " & FechaSalida & _
                '                       " - Ref. Val.: " & RefValoracion & " - Mat.: " & Remolque & Camion & _
                '                       " - Ref. Ped.: " & RefClientePedido, Col(1) + 1, altura, 185, 4, Estilos.ReducidaBold)


                If CompruebaSaltoPagina(altura, 8) Then

                    Impreso.Detalle.LineaH(margen_izquierdo, altura, 190, ancho_linea, Color.Black)
                    Impreso.Detalle.LineaV(margen_izquierdo, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)
                    Impreso.Detalle.LineaV(margen_izquierdo + 190, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)

                    Impreso.Detalle.SaltoPagina()
                    altura = altura_impreso
                End If


                Impreso.Detalle.Titulo("Alb: " & NumAlbaran & " - Fec: " & FechaSalida & _
                                       " - Ref. Val.: " & RefValoracion & " - Mat.: " & Remolque & Camion & _
                                       " - Ref. Ped.: " & RefClientePedido, Col(1) + 1, altura, 185, 4, Estilos.ReducidaBold)
                NumLineas += 2


                altura = altura + 4


                consulta = New Cdatos.E_select
                consulta.SelCampo(Albsalida_Lineas.ASL_idlinea, "IdLinea")
                consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albsalida_Lineas.ASL_idgenero, Generos.GEN_IdGenero)
                consulta.SelCampo(SubFamilias.SFA_idfamilia, "IdFamilia", Generos.GEN_IdsubFamilia, SubFamilias.SFA_id)
                consulta.SelCampo(FamiliasGeneros.FAG_Acreditado, "Acreditado", SubFamilias.SFA_idfamilia, FamiliasGeneros.FAG_idfamilia)
                consulta.SelCampo(ConfecEnvase.CEV_Nombre, "Confeccion", Albsalida_Lineas.ASL_idtipoconfeccion, ConfecEnvase.CEV_Idconfec)
                consulta.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", Albsalida_Lineas.ASL_idgensal)
                consulta.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", Albsalida_Lineas.ASL_idcategoria, CategoriasSalida.CAS_Id)
                consulta.SelCampo(Marcas.MAR_Nombre, "Marca", Albsalida_Lineas.ASL_idmarca)
                consulta.SelCampo(Albsalida_Lineas.ASL_bultosvendidos, "Bultos")
                consulta.SelCampo(Albsalida_Lineas.ASL_piezasvendidas, "Piezas")
                consulta.SelCampo(Albsalida_Lineas.ASL_kilosvendidos, "KgCliente")
                consulta.SelCampo(Albsalida_Lineas.ASL_precioventa, "Precio")
                consulta.SelCampo(Albsalida_Lineas.ASL_tipopreciovta, "Tipo")
                consulta.SelCampo(Albsalida_Lineas.ASL_importegenerovta, "Importe")
                consulta.WheCampo(Albsalida_Lineas.ASL_idalbaran, "=", IdAlbaran)

                Dim dt As DataTable = Albsalida_Lineas.MiConexion.ConsultaSQL(consulta.SQL)


                ''Debug
                'Dim dt2 As DataTable = dt.Copy
                'For indice As Integer = 0 To 80
                '    For Each row As DataRow In dt2.Rows
                '        dt.ImportRow(row)
                '    Next
                'Next



                'Líneas del albarán
                For Each row As DataRow In dt.Rows


                    Dim IdLinea As String = (row("IdLinea").ToString & "").Trim
                    Dim dtDesglose As DataTable = ObtenerDesgloseLinea(IdLinea)


                    Dim Genero As String = (row("Genero").ToString & "").Trim
                    Dim Confeccion As String = (row("Confeccion").ToString & "").Trim
                    Dim Categoria As String = (row("Categoria").ToString & "").Trim
                    Dim Marca As String = (row("Marca").ToString & "").Trim
                    Dim Presentacion As String = (row("Presentacion").ToString & "").Trim

                    Dim Bultos As Decimal = 0
                    Dim Piezas As Decimal = 0
                    Dim KgCliente As Decimal = 0
                    Dim Precio As Decimal = 0
                    Dim TipoPrecio As String = ""
                    Dim Importe As Decimal = 0



                    Dim Controlado As String = "" 'If bForzarControlado Then Controlado = "**"
                    Dim Acreditado As String = (row("Acreditado").ToString & "").Trim


                    '3 casos
                    'Controlada y acreditada: usamos la línea de los **
                    'Controlada y no acreditada: usamos la línea de los ***
                    'No controlada: no ponemos nada
                    If bForzarControlado Then

                        If Acreditado <> "S" Then
                            Controlado = "***"
                            bLeyendaNOAcreditado = True
                        Else
                            Controlado = "**"
                            bLeyendaControlado = True
                        End If

                    End If



                    If IsNothing(dtDesglose) Then

                        Bultos = VaDec(row("Bultos"))
                        Piezas = VaDec(row("Piezas"))
                        KgCliente = VaDec(row("KgCliente"))
                        Precio = VaDec(row("Precio"))
                        Importe = VaDec(row("Importe"))
                        TipoPrecio = (row("Tipo").ToString & "").Trim


                        If CompruebaSaltoPagina(altura, 4) Then

                            Impreso.Detalle.LineaH(margen_izquierdo, altura, 190, ancho_linea, Color.Black)
                            Impreso.Detalle.LineaV(margen_izquierdo, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)
                            Impreso.Detalle.LineaV(margen_izquierdo + 190, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)

                            Impreso.Detalle.SaltoPagina()
                            altura = altura_impreso
                        End If


                        Dim linea As New LineaDesgloseAlbaran(IdAlbaran, NumAlbaran, FechaSalida, Genero, Confeccion, Categoria, Marca, Bultos, Piezas, KgCliente, Precio, TipoPrecio, Importe, Presentacion, Controlado, Acreditado)
                        ImprimeLineaFacturaComer(Impreso, linea, altura, Col)
                        NumLineas += 1


                        TotalBultos = TotalBultos + Bultos
                        TotalPiezas = TotalPiezas + Piezas
                        TotalKgNetos = TotalKgNetos + KgCliente
                        TotalImporte = TotalImporte + Importe


                    Else

                        For Each rowDesglose As DataRow In dtDesglose.Rows

                            Bultos = VaDec(rowDesglose("Bultos"))
                            Piezas = VaDec(rowDesglose("Piezas"))
                            KgCliente = VaDec(rowDesglose("KgCliente"))
                            Precio = VaDec(rowDesglose("Precio"))
                            Importe = VaDec(rowDesglose("Importe"))
                            TipoPrecio = (rowDesglose("Tipo").ToString & "").Trim


                            If CompruebaSaltoPagina(altura, 4) Then

                                Impreso.Detalle.LineaH(margen_izquierdo, altura, 190, ancho_linea, Color.Black)
                                Impreso.Detalle.LineaV(margen_izquierdo, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)
                                Impreso.Detalle.LineaV(margen_izquierdo + 190, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)

                                Impreso.Detalle.SaltoPagina()
                                altura = altura_impreso
                            End If


                            Dim linea As New LineaDesgloseAlbaran(IdAlbaran, NumAlbaran, FechaSalida, Genero, Confeccion, Categoria, Marca, Bultos, Piezas, KgCliente, Precio, TipoPrecio, Importe, Presentacion, Controlado, Acreditado)
                            ImprimeLineaFacturaComer(Impreso, linea, altura, Col)
                            NumLineas += 1


                            TotalBultos = TotalBultos + Bultos
                            TotalPiezas = TotalPiezas + Piezas
                            TotalKgNetos = TotalKgNetos + KgCliente
                            TotalImporte = TotalImporte + Importe


                            Application.DoEvents()

                        Next

                    End If


                    Application.DoEvents()

                Next


                'Líneas de desglose de envases
                Dim sql As String = "SELECT ENV_Nombre as Envase," & vbCrLf
                sql = sql & " SUM(COALESCE(VEL_Retira,0)) as Retira, SUM(COALESCE(VEL_Entrega,0)) as Entrega," & vbCrLf
                sql = sql & " VEL_PrecioRetira as PrecioRetira, VEL_PrecioEntrega as PrecioEntrega," & vbCrLf
                sql = sql & " SUM(COALESCE(VEL_Retira,0) * COALESCE(VEL_PrecioRetira,0)) as ImporteRetira," & vbCrLf
                sql = sql & " SUM(COALESCE(VEL_Entrega,0) * COALESCE(VEL_PrecioEntrega,0)) as ImporteEntrega" & vbCrLf
                sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
                sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = VEL_IdEnvase" & vbCrLf
                sql = sql & " WHERE VEL_IdVale = " & IdValeEnvase & vbCrLf
                sql = sql & " AND (COALESCE(VEL_PrecioEntrega,0) <> 0 OR COALESCE(VEL_PrecioRetira,0) <> 0)" & vbCrLf
                sql = sql & " AND ENV_Retornable = 'S'" & vbCrLf
                sql = sql & " GROUP BY ENV_Nombre, VEL_PrecioRetira, VEL_PrecioEntrega" & vbCrLf
                sql = sql & " ORDER BY ENV_Nombre" & vbCrLf

                Dim dtEnvases As DataTable = Albsalida_Lineas.MiConexion.ConsultaSQL(sql)

                If Not IsNothing(dtEnvases) Then


                    For Each row As DataRow In dtEnvases.Rows

                        Dim Envase As String = row("Envase").ToString & ""
                        Dim Cantidad As Decimal = VaDec(row("Retira")) - VaDec(row("Entrega"))
                        Dim Importe As Decimal = VaDec(row("ImporteRetira")) - VaDec(row("ImporteEntrega"))
                        Dim Precio As Decimal = 0
                        If Cantidad >= 0 Then
                            Precio = VaDec(row("PrecioRetira"))
                        Else
                            Precio = VaDec(row("PrecioEntrega"))
                        End If


                        If CompruebaSaltoPagina(altura, 4) Then

                            Impreso.Detalle.LineaH(margen_izquierdo, altura, 190, ancho_linea, Color.Black)
                            Impreso.Detalle.LineaV(margen_izquierdo, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)
                            Impreso.Detalle.LineaV(margen_izquierdo + 190, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)

                            Impreso.Detalle.SaltoPagina()
                            altura = altura_impreso
                        End If


                        Dim lineaEnvase As New LineaDesgloseEnvase(Envase, Cantidad, Precio, Importe)
                        ImprimeLineaEnvase(Impreso, lineaEnvase, altura, Col)
                        NumLineas += 1

                        Application.DoEvents()

                    Next

                End If


                altura = altura + 4


                Application.DoEvents()
            Next

        End If


        'Líneas de otros conceptos
        Dim sqlConceptos As String = "Select FLV_tipoGEC AS Tipo,  FLV_Codigo AS Codigo, " & vbCrLf
        sqlConceptos = sqlConceptos & " COALESCE(GEN_NombreGenero,'') + COALESCE(ENV_Nombre,'') + COALESCE(COF_Nombre,'') AS Producto, "
        sqlConceptos = sqlConceptos & " FLV_cantidad AS Cantidad,  FLV_precio AS Precio, COALESCE(FLV_cantidad,0) * COALESCE(FLV_precio,0) as Importe"
        sqlConceptos = sqlConceptos & " FROM Facturaslineasvar " & vbCrLf
        sqlConceptos = sqlConceptos & " LEFT JOIN Generos ON (FLV_Codigo = GEN_IdGenero AND FLV_TipoGEC = 'G') "
        sqlConceptos = sqlConceptos & " LEFT JOIN Envases ON (FLV_Codigo = ENV_IdEnvase AND FLV_TipoGEC = 'E') "
        sqlConceptos = sqlConceptos & " LEFT JOIN ConceptosFactura ON (FLV_Codigo = COF_IdConcepto AND FLV_TipoGEC = 'C') "
        sqlConceptos = sqlConceptos & " WHERE FLV_idfactura = " & IdFactura & vbCrLf
        sqlConceptos = sqlConceptos & " ORDER BY FLV_IdLinea"

        Dim dtConceptos As DataTable = AlbSalida.MiConexion.ConsultaSQL(sqlConceptos)
        If Not IsNothing(dtConceptos) Then

            If dtConceptos.Rows.Count > 0 Then


                If CompruebaSaltoPagina(altura, 4) Then

                    Impreso.Detalle.LineaH(margen_izquierdo, altura, 190, ancho_linea, Color.Black)
                    Impreso.Detalle.LineaV(margen_izquierdo, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)
                    Impreso.Detalle.LineaV(margen_izquierdo + 190, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)

                    Impreso.Detalle.SaltoPagina()
                    altura = altura_impreso
                End If


                Impreso.Detalle.Titulo("Otros conceptos", Col(1) + 1, altura, 80, 4, Estilos.ReducidaBold)
                NumLineas += 1
                altura = altura + 4

                For Each row As DataRow In dtConceptos.Rows

                    Dim Producto As String = row("Producto").ToString
                    Dim Cantidad As Decimal = VaDec(row("Cantidad"))
                    Dim Precio As Decimal = VaDec(row("Precio"))
                    Dim Importe As Decimal = VaDec(row("Importe"))
                    Dim tipo As String = (row("Tipo").ToString & "").ToUpper.Trim


                    If CompruebaSaltoPagina(altura, 4) Then

                        Impreso.Detalle.LineaH(margen_izquierdo, altura, 190, ancho_linea, Color.Black)
                        Impreso.Detalle.LineaV(margen_izquierdo, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)
                        Impreso.Detalle.LineaV(margen_izquierdo + 190, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)

                        Impreso.Detalle.SaltoPagina()
                        altura = altura_impreso
                    End If


                    Dim lineaConceptos As New LineaDesgloseConceptos(Producto, Cantidad, Precio, Importe, tipo)
                    ImprimeLineaConcepto(Impreso, lineaConceptos, altura, Col)
                    NumLineas += 1


                    TotalImporte = TotalImporte + Importe


                    Application.DoEvents()

                Next

                altura = altura + 4

            End If

        End If



        altura = altura + 1



        Dim alto_detalle As Integer = altura - BaseLineas
        If alto_detalle < 123 Then
            'altura = BaseLineas + 123
            altura = BaseLineas + 118
        End If



        'Líneas laterales
        Impreso.Detalle.LineaH(margen_izquierdo, altura, 190, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(margen_izquierdo, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(margen_izquierdo + 190, BaseLineas, altura - BaseLineas, ancho_linea, Color.Black)

        altura = altura + 2



        bLeyendaControlado = bLeyendaControlado Or bForzarControlado


    End Sub


    Public Function ObtenerDesgloseLinea(IdLinea As String) As DataTable

        Dim dtRes As DataTable = Nothing


        Dim sql As String = "SELECT ASD_BultosVendidos as Bultos, ASD_KilosVendidos as KgCliente, ASD_PiezasVendidas as Piezas, ASD_PrecioVenta as Precio, ASD_TipoKBP as Tipo, ASD_ImporteVenta as Importe" & vbCrLf
        sql = sql & " FROM AlbSalida_Lineas_Desglose" & vbCrLf
        sql = sql & " WHERE ASD_IdLineaAlbSalida = " & IdLinea & vbCrLf
        sql = sql & " AND COALESCE(ASD_BultosVendidos,0) <> 0 AND COALESCE(ASD_KilosVendidos,0) <> 0 AND COALESCE(ASD_PiezasVendidas,0) <> 0 "


        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 1 Then
                dtRes = dt
            End If
        End If



        Return dtRes

    End Function


    Private Sub ImprimeLineaFacturaComer(ByRef Impreso As Impreso, linea As LineaDesgloseAlbaran, ByRef altura As Integer,
                                         Col As List(Of Integer))

        Dim altura_linea As Integer = 4


        If linea.Presentacion.Trim = "" Then
            Impreso.Detalle.Titulo(linea.Genero & "_" & linea.Confeccion, Col(1) + 1, altura, 52, altura_linea, Estilos.Reducida)
        Else
            Impreso.Detalle.Titulo(linea.Presentacion, Col(1) + 1, altura, 52, altura_linea, Estilos.Reducida)
        End If

        Impreso.Detalle.Titulo(linea.Controlado, Col(1) + 1 + 50, altura, 7, altura_linea, Estilos.Reducida, ">")
        Impreso.Detalle.Titulo(linea.Categoria, Col(2), altura, 16, altura_linea, Estilos.Reducida)
        Impreso.Detalle.Titulo(linea.Marca, Col(3), altura, 29, altura_linea, Estilos.Reducida)
        If linea.Bultos <> 0 Then Impreso.Detalle.Titulo(linea.Bultos.ToString("#,##0"), Col(4), altura, 14, altura_linea, Estilos.Reducida, ">")
        If linea.Piezas <> 0 Then Impreso.Detalle.Titulo(linea.Piezas.ToString("#,##0"), Col(5), altura, 17, altura_linea, Estilos.Reducida, ">")
        If linea.KgCliente <> 0 Then Impreso.Detalle.Titulo(linea.KgCliente.ToString("#,##0"), Col(6), altura, 16, altura_linea, Estilos.Reducida, ">")
        If linea.Precio <> 0 Then Impreso.Detalle.Titulo(linea.Precio.ToString("#,##0.00000") & " " & linea.TipoPrecio, Col(7), altura, 15, altura_linea, Estilos.Reducida, ">")
        If linea.Importe <> 0 Then Impreso.Detalle.Titulo(linea.Importe.ToString("#,##0.00"), Col(8), altura, 17, altura_linea, Estilos.Reducida, ">")

        altura = altura + altura_linea


    End Sub



    Private Sub ImprimeLineaEnvase(ByRef Impreso As Impreso, linea As LineaDesgloseEnvase, ByRef altura As Integer,
                                   Col As List(Of Integer))

        Dim altura_linea As Integer = 4

        Impreso.Detalle.Titulo(linea.Envase, Col(1) + 1, altura, 100, altura_linea, Estilos.Custom, , , fuente_envase)
        If linea.Bultos <> 0 Then Impreso.Detalle.Titulo(linea.Bultos.ToString("#,##0"), Col(4), altura, 14, altura_linea, Estilos.Custom, ">")
        If linea.Precio <> 0 Then Impreso.Detalle.Titulo(linea.Precio.ToString("#,##0.00000"), Col(7), altura, 15, altura_linea, Estilos.Custom, ">")
        If linea.Importe <> 0 Then Impreso.Detalle.Titulo(linea.Importe.ToString("#,##0.00"), Col(8), altura, 17, altura_linea, Estilos.Custom, ">")

        altura = altura + altura_linea


    End Sub


    Private Sub ImprimeLineaConcepto(ByRef Impreso As Impreso, linea As LineaDesgloseConceptos, ByRef altura As Integer,
                                     Col As List(Of Integer))

        Dim altura_linea As Integer = 4


        Select Case linea.Tipo
            Case "G"
                linea.Producto = linea.Producto.Trim & " (GENEROS)"
            Case "E"
                linea.Producto = linea.Producto.Trim & " (ENVASES)"
        End Select

        Impreso.Detalle.Titulo(linea.Producto, Col(1) + 1, altura, 100, altura_linea, Estilos.Reducida)
        If linea.Cantidad <> 0 Then Impreso.Detalle.Titulo(linea.Cantidad.ToString("#,##0"), Col(6), altura, 14, altura_linea, Estilos.Reducida, ">")
        If linea.Precio <> 0 Then Impreso.Detalle.Titulo(linea.Precio.ToString("#,##0.00000"), Col(7), altura, 15, altura_linea, Estilos.Reducida, ">")
        If linea.Importe <> 0 Then Impreso.Detalle.Titulo(linea.Importe.ToString("#,##0.00"), Col(8), altura, 17, altura_linea, Estilos.Reducida, ">")

        altura = altura + altura_linea


    End Sub


    Private Sub ImprimeTotalesFacturaComer(ByRef Impreso As Impreso, ByRef altura As Integer, Factura As E_Facturas,
                                           Col As List(Of Integer), TotalBultos As Decimal, TotalPiezas As Decimal,
                                           TotalKgNetos As Decimal, TotalImporte As Decimal, ImpEnvases As Decimal, TotalGastos As Decimal)


        TotalImporte = TotalImporte + ImpEnvases



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

        Dim suplido As Decimal = VaDec(Factura.FRA_Suplido.Valor)

        Dim cuotaRe1 As Decimal = VaDec(Factura.FRA_CuotaRe1.Valor)
        Dim cuotaRe2 As Decimal = VaDec(Factura.FRA_CuotaRe2.Valor)
        Dim cuotaRe3 As Decimal = VaDec(Factura.FRA_CuotaRe3.Valor)

        Dim Cambio As Decimal = VaDec(Factura.FRA_valorcambio.Valor)



        'Totales Bultos, Piezas, Kg, Importe
        Impreso.Detalle.Cuadro(Col(4) - 5, altura, 89, 5, ancho_linea, Color.Black)
        altura = altura + 1

        Impreso.Detalle.Titulo(Factura.FRA_obs1.Valor & "", margen_izquierdo + 5, altura - 10, 100, 6, Estilos.MinimaBold)
        Impreso.Detalle.Titulo(Factura.FRA_obs2.Valor & "", margen_izquierdo + 5, altura - 7, 100, 6, Estilos.MinimaBold)

        If TotalBultos <> 0 Then Impreso.Detalle.Titulo(TotalBultos.ToString("#,##0"), Col(4), altura, 12, 4, Estilos.Reducida, ">")
        If TotalPiezas <> 0 Then Impreso.Detalle.Titulo(TotalPiezas.ToString("#,##0"), Col(5), altura, 11, 4, Estilos.Reducida, ">")
        If TotalKgNetos <> 0 Then Impreso.Detalle.Titulo(TotalKgNetos.ToString("#,##0"), Col(6), altura, 14, 4, Estilos.Reducida, ">")
        If TotalImporte <> 0 Then Impreso.Detalle.Titulo(TotalImporte.ToString("#,##0.00"), Col(8), altura, 17, 4, Estilos.Reducida, ">")


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
        Impreso.Detalle.Titulo("Suplido", 134, altura, 26, 3, Estilos.MinimaBold, "=")

        'Gastos
        If TotalGastos <> 0 Then Impreso.Detalle.Titulo("Gastos: " & TotalGastos.ToString("#,##0.00"), Col(8) - 10, altura, 27, 3, Estilos.MinimaBold, ">")

        altura = altura + 3

        Impreso.Detalle.LineaH(32, altura, 128, ancho_linea, Color.Black)
        Impreso.Detalle.LineaH(32, altura + 15, 128, ancho_linea, Color.Black)

        Impreso.Detalle.LineaV(32, altura, 15, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(59, altura, 15, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(69, altura, 15, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(96, altura, 15, ancho_linea, Color.Black)


        Impreso.Detalle.LineaV(106, altura, 15, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(133, altura, 15, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(160, altura, 15, ancho_linea, Color.Black)

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

        'Suplido
        If VaDec(suplido) <> 0 Then Impreso.Detalle.Titulo(VaDec(suplido).ToString("#,##0.00"), 132, altura + 1, 26, 5, Estilos.Reducida, ">")


        'Totales bases 

        Dim TotalBase1 As Decimal = VaDec(base1) + VaDec(cuotaIva1) + VaDec(cuotaRe1)
        Dim TotalBase2 As Decimal = VaDec(base2) + VaDec(cuotaIva2) + VaDec(cuotaRe2)
        Dim TotalBase3 As Decimal = VaDec(base3) + VaDec(cuotaIva3) + VaDec(cuotaRe3)
        'Dim TotalFactura As Decimal = TotalBase1 + TotalBase2 + TotalBase3
        Dim TotalFactura As Decimal = VaDec(Factura.FRA_totalfactura.Valor)
        Dim TotalFacturaDivisa As Decimal = TotalFactura * Cambio

        If TotalBase1 <> 0 Then Impreso.Detalle.Titulo(TotalBase1.ToString("#,##0.00"), Col(8), altura + 1, 17, 5, Estilos.Reducida, ">")
        If TotalBase2 <> 0 Then Impreso.Detalle.Titulo(TotalBase2.ToString("#,##0.00"), Col(8), altura + 5, 17, 5, Estilos.Reducida, ">")
        If TotalBase3 <> 0 Then Impreso.Detalle.Titulo(TotalBase3.ToString("#,##0.00"), Col(8), altura + 9, 17, 5, Estilos.Reducida, ">")


        altura = altura + 18


        'Total factura
        If Cambio <= 0 Or Cambio = 1 Then
            Impreso.Detalle.Titulo("TOTAL FACTURA", 121, altura, 40, 6, Estilos.GrandeBold, ">")
            Impreso.Detalle.Titulo(TotalFactura.ToString("#,##0.00"), Col(8) - 15, altura, 32, 6, Estilos.Grande, ">")
        Else

            'Nombre divisa
            Dim AbDivisa As String = ""
            Dim SimboloDivisa As String = ""

            Dim Moneda As New E_Moneda(Idusuario, cn)
            If VaInt(Factura.FRA_cddivisa.Valor) > 0 Then
                If Moneda.LeerId(Factura.FRA_cddivisa.Valor) Then
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



    Private Sub ImprimePieFacturaComer(ByRef Impreso As Impreso, DatosEmpresa As DatosEmpresa, ByRef altura As Integer, Factura As E_Facturas, Cliente As E_Clientes, bLeyendaControlado As Boolean,
                                       ByVal bLeyendaNOAcreditado As Boolean)


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
        altura = BaseAltura


        Impreso.Detalle.LineaH(margen_izquierdo, altura, 110, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(margen_izquierdo + 75, altura, 4, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(margen_izquierdo + 75 + 10, altura, 4, ancho_linea, Color.Black)

        Impreso.Detalle.LineaH(margen_izquierdo, altura, 110, ancho_linea, Color.Black)
        Impreso.Detalle.Titulo("DESGLOSE GASTOS", margen_izquierdo + 2, altura + 1, 73, 4, Estilos.MinimaBold)
        Impreso.Detalle.Titulo("%", margen_izquierdo + 76, altura + 1, 8, 4, Estilos.MinimaBold, "=")
        Impreso.Detalle.Titulo("IMPORTE", margen_izquierdo + 86, altura + 1, 23, 4, Estilos.MinimaBold, "=")
        altura = altura + 4

        Impreso.Detalle.LineaH(margen_izquierdo, altura, 110, ancho_linea, Color.Black)


        'Detalle gastos
        Dim dtEnvases As DataTable = DetalleGastos(Factura.FRA_idfactura.Valor)

        Dim cont As Integer = 1
        For Each row As DataRow In dtEnvases.Rows

            If cont > 7 Then Exit For

            Dim Gasto As String = (row("Gasto").ToString & "").Trim
            Dim Tipo As String = (row("Tipo").ToString & "").Trim.ToUpper
            Dim Valor As Decimal = VaDec(row("Valor"))
            Dim Importe As Decimal = VaDec(row("Importe"))


            If Importe <> 0 Then

                Dim Porcentaje As String = ""
                If Tipo = "%" Then
                    Porcentaje = VaDec(Valor).ToString("#,##0.00")
                End If

                Impreso.Detalle.Titulo(Gasto, margen_izquierdo + 2, altura + 1, 73, 3, Estilos.Minima)
                Impreso.Detalle.Titulo(Porcentaje, margen_izquierdo + 76, altura + 1, 8, 3, Estilos.Minima, ">")
                Impreso.Detalle.Titulo(Importe.ToString("#,##0.00"), margen_izquierdo + 86, altura + 1, 23, 3, Estilos.Minima, ">")
                altura = altura + 4

                cont = cont + 1
            End If


            Application.DoEvents()

        Next




        If altura - BaseAltura < 34 Then
            altura = BaseAltura + 34
        Else
            altura = altura + 3
        End If


        'Linea final horizontal
        Impreso.Detalle.LineaH(margen_izquierdo, altura, 110, ancho_linea, Color.Black)

        'Lineas laterales
        Impreso.Detalle.LineaV(margen_izquierdo, BaseAltura, altura - BaseAltura, ancho_linea, Color.Black)
        Impreso.Detalle.LineaV(margen_izquierdo + 110, BaseAltura, altura - BaseAltura, ancho_linea, Color.Black)

        altura = altura + 1


        Dim IdTipoCliente As String = (Cliente.CLI_IdTipo.Valor & "").Trim
        Dim TiposClientes As New E_Tiposclientes(Idusuario, cn)
        If TiposClientes.LeerId(IdTipoCliente) Then
            Dim Exento As String = (TiposClientes.TPC_exentoiva.Valor & "").Trim.ToUpper
            If Exento = "S" Then
                Impreso.Detalle.Titulo("Art. 25  Ley 37/92 - Exención por Entrega Comunitaria", margen_izquierdo + 2, altura, 200, 4, Estilos.Reducida)
            End If
        End If


        altura = altura + 3

        Dim bProductoEcologico As Boolean = False
        Dim NumRegistro As String = ""



        Dim IdPuntoVenta As String = (Factura.FRA_idpuntoventa.Valor & "").Trim
        If VaInt(IdPuntoVenta) > 0 Then

            Dim ValoresPVenta As New E_valorespventa(Idusuario, cn)
            If ValoresPVenta.LeerId(IdPuntoVenta) Then

                Dim Ecologico As String = (ValoresPVenta.VPV_EcologicoSN.Valor & "").Trim
                bProductoEcologico = (Ecologico = "S")
                NumRegistro = (ValoresPVenta.VPV_NumRegistroEco.Valor & "").Trim

            End If

        End If


        If bProductoEcologico Then
            Impreso.Detalle.Titulo("PROCEDENTE DEL CULTIVO ECOLOGICO, SISTEMA DE CONTROL UE: " & NumRegistro & "REGLAMENTO UE-834/2007", margen_izquierdo, altura, 185, 4, Estilos.Reducida)
        End If

        If bLeyendaControlado Then
            Impreso.Detalle.Titulo("** Producto controlado GLOBALGAP - GGN: " & DatosEmpresa.GGN & ". Producto Origen ESPAÑA.", margen_izquierdo, altura + 3, 280, 4, Estilos.Reducida)
        Else
            Impreso.Detalle.Titulo("Producto Origen ESPAÑA.", margen_izquierdo, altura + 3, 280, 4, Estilos.Reducida)
        End If

        If bLeyendaNOAcreditado Then
            Impreso.Detalle.Titulo("*** Producto controlado GLOBALGAP - CoC: " & DatosEmpresa.GGN & ". Producto Origen ESPAÑA.", margen_izquierdo, altura + 6, 280, 4, Estilos.Reducida)
        End If


    End Sub



    Private Function CompruebaSaltoPagina(altura As Integer, altura_linea As Integer) As Boolean

        Dim bRes As Boolean = False

        If altura + altura_linea > Pie_linea Then
            bRes = True
        End If


        Return bRes

    End Function


    Private Function DetalleGastos(IdFactura As String) As DataTable


        'Sólo gastos en factura

        Dim dt As New DataTable


        If VaInt(IdFactura) > 0 Then

            Dim AlbSalida As New E_AlbSalida(Idusuario, cn)

            Dim sql As String = "SELECT GCO_Nombre AS Gasto, ASG_TipoKBP as Tipo, ASG_ValorGasto as Valor, SUM(ASG_importegastodivisa) AS Importe " & vbCrLf
            sql = sql & " FROM Albsalida_Gastos" & vbCrLf
            sql = sql & " LEFT OUTER JOIN GastosComercio ON ASG_idgasto = GCO_Idgasto" & vbCrLf
            sql = sql & " LEFT OUTER JOIN AlbSalida ON ASG_idalbaran = ASA_idalbaran" & vbCrLf
            sql = sql & " WHERE COALESCE(ASA_IdFactura,0) = " & IdFactura & vbCrLf
            sql = sql & " AND ASG_TipoFC = 'F'" & vbCrLf
            sql = sql & " GROUP BY GCO_Nombre, ASG_TipoKBP, ASG_ValorGasto" & vbCrLf

            dt = AlbSalida.MiConexion.ConsultaSQL(sql)

        End If


        Return dt

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
        Dim Asunto As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.TEXTO_ASUNTO_ALBARANES_EMAIL) & ""


        Dim SerieFactura As String = (Facturas.FRA_serie.Valor & "").Trim
        Dim NumFactura As String = (Facturas.FRA_factura.Valor & "").Trim : If SerieFactura.Trim <> "" Then NumFactura = SerieFactura & "-" & NumFactura
        Dim RefCliente As String = (Facturas.FRA_RefCliente.Valor & "").Trim
        Dim PV As String = Facturas.FRA_idpuntoventa.Valor
        NombreDocumento = "Factura_" & PV & "_" & NumFactura & ".pdf"

        Dim Fecha As String = ""
        If VaDate(Facturas.FRA_fecha.Valor) > VaDate("") Then Fecha = VaDate(Facturas.FRA_fecha.Valor).ToString("dd/MM/yyyy")

        ' Añado los datos al email
        If Asunto.Trim = "" Then Asunto = "FACTURA: " & PV & "-" & NumFactura & " / " & Fecha & " / Referencia cliente: " & RefCliente


        Return Asunto

    End Function



    'Private Function ObtenerLineasControladas(IdFactura As String) As Boolean

    '    Dim bRes As Boolean = False


    '    Dim sql As String = "SELECT DISTINCT PLL_Controlado as Controlado" & vbCrLf
    '    sql = sql & " FROM Facturas" & vbCrLf
    '    sql = sql & " LEFT JOIN AlbSalida ON ASA_idfactura = FRA_IdFactura" & vbCrLf
    '    sql = sql & " LEFT JOIN AlbSalida_Palets ON ASA_IdAlbaran = ASP_IdAlbaran" & vbCrLf
    '    sql = sql & " LEFT JOIN Palets_Lineas ON PLL_IdPalet = ASP_IdPalet" & vbCrLf
    '    sql = sql & " WHERE FRA_IdFactura = " & IdFactura & vbCrLf

    '    Dim dt As DataTable = cn.ConsultaSQL(sql)
    '    If Not IsNothing(dt) Then

    '        If dt.Rows.Count > 0 Then

    '            bRes = True

    '            For Each row As DataRow In dt.Rows

    '                If (row("Controlado").ToString & "").Trim.ToUpper <> "S" Then
    '                    bRes = False
    '                    Exit For
    '                End If

    '            Next


    '        End If

    '    End If


    '    Return bRes

    'End Function


    Private Function AlbaranControlado(IdAlbaran As String) As String

        Dim res As String = "N"


        'Dim sql As String = "SELECT DISTINCT PLL_Controlado as Controlado " & vbCrLf
        'sql = sql & " FROM AlbSalida_Lineas" & vbCrLf
        'sql = sql & " LEFT JOIN AlbSalida_Palets ON ASP_IdAlbaran = ASL_IdAlbaran" & vbCrLf
        'sql = sql & " LEFT JOIN Palets_Lineas ON PLL_IdPalet = ASP_IdPalet" & vbCrLf
        'sql = sql & " WHERE ASL_IdAlbaran = " & IdAlbaran & vbCrLf


        'Dim dt As DataTable = cn.ConsultaSQL(sql)
        'If Not IsNothing(dt) Then

        '    If 

        '    End If


        Return res

    End Function



#End Region



End Module
