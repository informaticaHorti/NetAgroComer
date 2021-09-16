Imports System.Drawing


Module C1_AlbaranSalida


    Public Class stClave_lineasAlbaranControladas

        Public IdGenero As Integer = 0
        Public Genero As String = ""
        Public Categoria As String = ""
        Public IdPresentacion As Integer = 0
        Public Presentacion As String = ""
        Public IdEnvase As Integer = 0
        Public Envase As String = ""
        Public IdMarcaEnvase As Integer = 0
        Public MarcaEnvase As String = ""
        Public IdMarcaEti As Integer = 0
        Public MarcaEtiqueta As String = ""
        Public IdTipoPalet As Integer = 0
        Public IdTipoConfeccion As Integer = 0
        Public IdCategoria As Integer = 0
        Public BultosxPalet As Integer = 0
        Public PxB As Integer = 0
        Public KxB As Decimal = 0
        Public TipoPrecio As String = ""
        Public Precio As Decimal = 0
        Public Controlado As String = ""
        Public Lote As String = ""
        Public Acreditado As String = ""


        Public Sub New(ByVal IdGenero As Integer, ByVal Genero As String, ByVal Categoria As String, ByVal IdPresentacion As Integer, ByVal Presentacion As String,
                       ByVal IdEnvase As Integer, ByVal Envase As String, ByVal IdMarcaEnvase As Integer, ByVal MarcaEnvase As String,
                       ByVal IdMarcaEti As Integer, ByVal MarcaEtiqueta As String, ByVal IdTipoPalet As Integer, ByVal IdTipoConfeccion As Integer, ByVal IdCategoria As Integer,
                       ByVal BultosXPalet As Integer, ByVal PxB As Integer, ByVal KxB As Decimal, ByVal Controlado As String, Lote As String, Acreditado As String)

            Me.IdGenero = IdGenero
            Me.Genero = Genero
            Me.Categoria = Categoria
            Me.IdPresentacion = IdPresentacion
            Me.Presentacion = Presentacion
            Me.IdEnvase = IdEnvase
            Me.Envase = Envase
            Me.IdMarcaEnvase = IdMarcaEnvase
            Me.MarcaEnvase = MarcaEnvase
            Me.IdMarcaEti = IdMarcaEti
            Me.MarcaEtiqueta = MarcaEtiqueta
            Me.IdTipoPalet = IdTipoPalet
            Me.IdTipoConfeccion = IdTipoConfeccion
            Me.IdCategoria = IdCategoria
            Me.BultosxPalet = BultosXPalet
            Me.PxB = PxB
            Me.KxB = KxB
            Me.Controlado = Controlado
            Me.Lote = Lote
            Me.Acreditado = Acreditado

        End Sub

    End Class


    Dim margen_izquierdo As Integer = 6
    Dim ancho_linea As Decimal = 2
    Dim alto_linea_detalle As Integer = 20
    Dim Pie_linea As Integer = 199 '282
    Dim altura_impreso As Integer = 46

    Dim fuente_superpequeña As New Font("Courier New", 7, FontStyle.Bold)



    Public Sub C1_EnviarAlbaranSalida(IdAlbaran As String)

        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)

        If AlbSalida.LeerId(IdAlbaran) Then


            If VaInt(AlbSalida.ASA_iddomicilio.Valor) > 0 Then

                Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
                If ClientesDescargas.LeerId(AlbSalida.ASA_iddomicilio.Valor) Then

                    Dim OpEnvio As String = (ClientesDescargas.CLD_OpcionEnvio.Valor).Trim.ToUpper
                    Select Case OpEnvio

                        Case "E"
                            C1_ImprimirAlbaranSalida(IdAlbaran, TipoImpresion.Email, 0)

                        Case "F"
                            C1_ImprimirAlbaranSalida(IdAlbaran, TipoImpresion.Fax, 0)

                        Case "T"
                            C1_ImprimirAlbaranSalida(IdAlbaran, TipoImpresion.Email, 0)
                            C1_ImprimirAlbaranSalida(IdAlbaran, TipoImpresion.Fax, 0)

                    End Select


                Else
                    MsgBox("No puedo leer el domicilio de descarga del cliente con Id: " & AlbSalida.ASA_iddomicilio.Valor)
                End If

            Else
                'TODO: En caso de no tener domicilio de descarga el albarán??
            End If


        Else
            MsgBox("No se puede leer el albarán de salida con Id: " & IdAlbaran)
        End If


    End Sub



    Public Sub C1_ImprimirAlbaranSalida(IdAlbaran As String, TipoImpresion As TipoImpresion, NumCopias As Integer,
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

            Dim Pedidos As New E_Pedidos(Idusuario, cn)
            If VaInt(AlbSalida.ASA_idpedido.Valor) Then
                Pedidos.LeerId(AlbSalida.ASA_idpedido.Valor)
            End If

            Dim ClienteDescarga As New E_ClientesDescargas(Idusuario, cn)
            ClienteDescarga.LeerId(AlbSalida.ASA_iddomicilio.Valor)

            Dim altura As Integer = 5
            Dim DatosEmpresa As New DatosEmpresa


            Dim Impreso As New Impreso()

            Impreso.f.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
            Impreso.f.Documento.PageLayout.PageSettings.Landscape = True
            Impreso.f.Documento.PageLayout.PageSettings.TopMargin = "10mm"
            Impreso.f.Documento.PageLayout.PageSettings.LeftMargin = "10mm"
            Impreso.f.Documento.PageLayout.PageSettings.RightMargin = "10mm"
            Impreso.f.documento.PageLayout.PageSettings.BottomMargin = "5mm"


            Impreso.EstableceImpreso(TipoImpresion)


            Impreso.DatosMail = ObtenerDatosMail(AlbSalida, ClienteDescarga)



            Dim TotalPalets As Integer = 0
            Dim TotalPaletsTransporte As Integer = 0
            Dim TotalBultos As Integer = 0
            Dim TotalPiezas As Integer = 0
            Dim TotalKgBrutos As Decimal = 0
            Dim TotalKgNetos As Decimal = 0
            Dim TotalImporte As Decimal = 0
            Dim TotalImporteDivisa As Decimal = 0
            Dim abreviatura_divisa As String = ""
            Dim ValorCambio As Decimal = 0

            Dim LeyendaControlado As Boolean = False
            Dim LeyendaNOAcreditada As Boolean = False


            Try

                'Imprimir cabecera
                ImprimeCabeceraAlbaranSalida(Impreso, altura, AlbSalida, DatosEmpresa, Clientes, Pedidos)

                'Imprimir detalle
                ImprimeDetalleAlbaranSalida(Impreso, altura, AlbSalida, Clientes, TotalPalets, TotalBultos, TotalPiezas, TotalKgBrutos, TotalKgNetos, TotalImporte, LeyendaControlado,
                                            ValorCambio, TotalImporteDivisa, abreviatura_divisa)

                'Imprimir totales
                ImprimirTotalAlbaranSalida(Impreso, altura, AlbSalida, Clientes, TotalPalets, TotalBultos, TotalPiezas, TotalKgBrutos, TotalKgNetos, TotalImporte, ValorCambio, TotalImporteDivisa, abreviatura_divisa)

                'Pie
                'ImprimirPieAlbaranSalida(Impreso, AlbSalida, LeyendaControlado, DatosEmpresa)
                ImprimirPieAlbaranSalida(Impreso, AlbSalida, DatosEmpresa)

                Dim CD As New E_ConfiguracionesDiversas(Idusuario, cn)
                Dim ruta As String = CD.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_ARCHIVOS_ADJUNTOS_TEMP) & "\"

                Select Case TipoImpresion

                    Case TipoImpresion.Email

                        Impreso.Imprimir(NetAgro.TipoImpresion.ExportacionPDF, , ruta, Impreso.DatosMail.NombreDocumento)
                        Impreso.DatosMail.ListaAdjuntos.Add(ruta & Impreso.DatosMail.NombreDocumento)
                        Impreso.EnviarPorOutlook(False)

                        Try
                            If IO.File.Exists(ruta & Impreso.DatosMail.NombreDocumento) Then
                                IO.File.Delete(ruta & Impreso.DatosMail.NombreDocumento)
                            End If
                        Catch ex As Exception
                        End Try


                    Case TipoImpresion.Fax
                        Impreso.DatosMail = ObtenerDatosMail(AlbSalida, ClienteDescarga)

                        Impreso.Imprimir(NetAgro.TipoImpresion.ExportacionPDF, , ruta, Impreso.DatosMail.NombreDocumento)
                        Impreso.DatosMail.ListaAdjuntos.Add(ruta & Impreso.DatosMail.NombreDocumento)
                        Impreso.EnviarPorOutlook(True)

                        Try
                            If IO.File.Exists(ruta & Impreso.DatosMail.NombreDocumento) Then
                                IO.File.Delete(ruta & Impreso.DatosMail.NombreDocumento)
                            End If
                        Catch ex As Exception
                        End Try

                    Case Else
                        'Impresión
                        Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF, NumCopias)
                End Select


            Catch ex As Exception
            End Try


        Else
            MsgBox("No se puede leer el albarán de salida con Id: " & IdAlbaran)
        End If

    End Sub


    Private Function ObtenerDatosMail(ByVal AlbSalida As E_AlbSalida, ByVal ClienteDescarga As E_ClientesDescargas) As DatosMail

        Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
        Dim Asunto As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.TEXTO_ASUNTO_ALBARANES_EMAIL) & ""

        Dim DestinatarioFax As String = ObtenerDireccionFax(ClienteDescarga.CLD_Telefono2.Valor)
        Dim Email1 As String = ClienteDescarga.CLD_emailalba1.Valor
        Dim Email2 As String = ClienteDescarga.CLD_emailalba2.Valor
        Dim Email3 As String = ClienteDescarga.CLD_emailalba3.Valor
        Dim NumAlb As String = AlbSalida.ASA_albaran.Valor
        Dim PV As String = AlbSalida.ASA_idpuntoventa.Valor
        Dim NombreDocumento As String = "Albaran_" & PV & "_" & NumAlb & ".pdf"

        'Dim Matricula As String = AlbSalida.ASA_matriculacamion.Valor
        Dim Remolque As String = AlbSalida.ASA_matricularemolque.Valor
        Dim Referencia As String = AlbSalida.ASA_referencia.Valor
        Dim Fecha As String = ""
        If VaDate(AlbSalida.ASA_fechasalida.Valor) > VaDate("") Then Fecha = VaDate(AlbSalida.ASA_fechasalida.Valor).ToString("dd/MM/yyyy")

        ' Añado los datos al email
        'Dim Asunto As String = "Albaran Salida: " & PV & "-" & NumAlb & " / " & Matricula & " / " & Referencia
        If Asunto.Trim = "" Then Asunto = "ALBARAN DE SALIDA: " & PV & "-" & NumAlb & " / " & Fecha & " / Posicion: " & Referencia & " / " & Remolque


        Dim Body As String = ""

        Dim DestinatariosMail As New List(Of String)
        If Len(Email1) > 0 Then DestinatariosMail.Add(Email1)
        If Len(Email2) > 0 Then DestinatariosMail.Add(Email2)
        If Len(Email3) > 0 Then DestinatariosMail.Add(Email3)

        Return New DatosMail(DestinatariosMail, DestinatarioFax, Asunto, Body, Nothing, NombreDocumento)
    End Function



    Private Sub ImprimeCabeceraAlbaranSalida(ByVal Impreso As Impreso, ByRef altura As Integer, ByVal AlbSalida As E_AlbSalida, ByVal DatosEmpresa As DatosEmpresa, ByVal Cliente As E_Clientes, ByVal Pedidos As E_Pedidos)

        Dim BaseAltura As Integer = altura


        'Dim NIF As String = "F04026043"


        Impreso.Cabecera.Titulo(DatosEmpresa.NombreEmpresa, margen_izquierdo, altura, 65, 7, Estilos.NormalBold)
        Impreso.Cabecera.Titulo("C.I.F.: " & DatosEmpresa.NIF, margen_izquierdo + 65, altura, 35, 4, Estilos.Normal)
        altura = altura + 4
        Impreso.Cabecera.Titulo(DatosEmpresa.Domicilio, margen_izquierdo, altura, 65, 4, Estilos.NormalBold)
        Impreso.Cabecera.Titulo("Comercial: " & DatosEmpresa.TelfComercial, margen_izquierdo + 65, altura, 35, 4, Estilos.Normal)
        altura = altura + 4
        Impreso.Cabecera.Titulo(DatosEmpresa.Poblacion & " (" & DatosEmpresa.Provincia & ")", margen_izquierdo, altura, 75, 4, Estilos.NormalBold)
        altura = altura + 4
        Impreso.Cabecera.Titulo("Admon: " & DatosEmpresa.TelfAdmon & " - Fax: " & DatosEmpresa.Fax, margen_izquierdo, altura, 170, 4, Estilos.Normal)
        altura = altura + 4
        Impreso.Cabecera.Titulo("Calidad: " & DatosEmpresa.TelfCalidad, margen_izquierdo + 65, altura, 35, 4, Estilos.Normal)
        altura = altura + 4
        Impreso.Cabecera.Titulo("Salidas: " & DatosEmpresa.TelfSalidas, margen_izquierdo + 65, altura, 35, 4, Estilos.Normal)

        Dim BESTELLNR As String = (Pedidos.PED_BESTELLNR.Valor & "").Trim
        If BESTELLNR.Trim <> "" Then
            Impreso.Cabecera.Titulo("BESTELLNR: " & BESTELLNR, margen_izquierdo, altura, 60, 4, Estilos.NormalBold)
        End If
        


        altura = altura + 8

        altura = BaseAltura


        Impreso.Cabecera.Cuadro(margen_izquierdo + 190, altura, 90, 28, ancho_linea, Color.Black)

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
        Dim TelfCliente As String = (Cliente.CLI_Telefono1.Valor & "").Trim
        Dim FaxCliente As String = (Cliente.CLI_Fax.Valor & "").Trim
        Dim Pedido As String = ""
        Dim FechaLlegada As String = ""
        Dim CIF As String = (Cliente.CLI_Nif.Valor & "").Trim
        Dim NumeroRegistro As String = (Cliente.CLI_NumeroRegistro.Valor & "").Trim



        'If VaInt(AlbSalida.ASA_idpedido.Valor) > 0 Then
        '    Dim Pedidos As New E_Pedidos(Idusuario, cn)
        '    If Pedidos.LeerId(AlbSalida.ASA_idpedido.Valor) Then
        Pedido = (Pedidos.PED_pedido.Valor & "").Trim
        If VaDate(Pedidos.PED_FechaLlegada.Valor) > VaDate("") Then FechaLlegada = VaDate(Pedidos.PED_FechaLlegada.Valor).ToString("dd/MM/yyyy")
        '    End If
        'End If

        altura = altura - 1

        Impreso.Cabecera.Titulo(NombreCliente, margen_izquierdo + 190 + 2, altura + 2, 86, 5, Estilos.NormalBold)
        altura = altura + 4
        Impreso.Cabecera.Titulo(Domicilio, margen_izquierdo + 190 + 2, altura + 2, 86, 5, Estilos.NormalBold)
        altura = altura + 4
        Impreso.Cabecera.Titulo(CP & " - " & Poblacion, margen_izquierdo + 190 + 2, altura + 2, 86, 5, Estilos.NormalBold)
        altura = altura + 4
        Impreso.Cabecera.Titulo(provincia, margen_izquierdo + 190 + 2, altura + 2, 86, 5, Estilos.NormalBold)
        altura = altura + 4
        Impreso.Cabecera.Titulo(Pais, margen_izquierdo + 190 + 2, altura + 2, 86, 5, Estilos.NormalBold)
        altura = altura + 4
        Impreso.Cabecera.Titulo("C.I.F.: " & CIF, margen_izquierdo + 190 + 2, altura + 2, 45, 4, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo("Tlf: " & TelfCliente, margen_izquierdo + 230 + 2, altura + 2, 45, 4, Estilos.ReducidaBold, ">")
        altura = altura + 3
        Impreso.Cabecera.Titulo("Nº Registro: " & NumeroRegistro, margen_izquierdo + 190 + 2, altura + 2, 45, 4, Estilos.ReducidaBold)
        Impreso.Cabecera.Titulo("Fax: " & FaxCliente, margen_izquierdo + 230 + 2, altura + 2, 45, 4, Estilos.ReducidaBold, ">")



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


        Col(0) = 0
        Col(1) = margen_izquierdo
        Col(2) = Col(1) + 20
        Col(3) = Col(2) + 28
        Col(4) = Col(3) + 20
        Col(5) = Col(4) + 45
        Col(6) = Col(5) + 25
        Col(7) = Col(6) + 27


        Impreso.Cabecera.Cuadro(margen_izquierdo, altura, 185, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(Col(2), altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(Col(3), altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(Col(4), altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(Col(5), altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(Col(6), altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaV(Col(7), altura, 10, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaH(margen_izquierdo, altura + 5, 185, ancho_linea)
        altura = altura + 1


        Impreso.Cabecera.Titulo("Código", Col(1) + 1, altura, 18, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo("Pedido", Col(2) + 1, altura, 26, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo("N.Albarán", Col(3) + 1, altura, 18, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo("Ref/Posic", Col(4) + 1, altura, 43, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo("F.Salida", Col(5) + 1, altura, 23, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo("F.Llegada", Col(6) + 1, altura, 25, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo("H.Salida", Col(7) + 1, altura, 18, 4, Estilos.ReducidaBold, "=")
        altura = altura + 5


        Dim CodCli As String = VaInt(Cliente.CLI_Codigo.Valor).ToString("00000")
        Dim Albaran As String = VaInt(AlbSalida.ASA_idpuntoventa.Valor).ToString("00") & "/" & VaInt(AlbSalida.ASA_albaran.Valor).ToString("000000")
        Dim Ref As String = (AlbSalida.ASA_referencia.Valor & "").Trim
        Dim FechaSal As String = "" : If VaDate(AlbSalida.ASA_fechasalida.Valor) > VaDate("") Then FechaSal = VaDate(AlbSalida.ASA_fechasalida.Valor).ToString("dd/MM/yyyy")
        Dim Horasalida As String = (AlbSalida.ASA_HoraSalida.Valor & "").Trim


        Impreso.Cabecera.Titulo(CodCli, Col(1) + 1, altura, 18, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(Pedido, Col(2) + 1, altura, 26, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(Albaran, Col(3) + 1, altura, 18, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo(Ref, Col(4) + 1, altura, 43, 4, Estilos.ReducidaBold, "=")
        Impreso.Cabecera.Titulo(FechaSal, Col(5) + 1, altura, 23, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(FechaLlegada, Col(6) + 1, altura, 23, 4, Estilos.Reducida, "=")
        Impreso.Cabecera.Titulo(Horasalida, Col(7) + 1, altura, 20, 4, Estilos.Reducida, "=")
        altura = altura - 1
        Impreso.Cabecera.Titulo("ALBARAN DE SALIDA", margen_izquierdo + 180, altura, 100, 5, Estilos.NormalBold, "=")

        altura = altura + 8


        'Código de barras
        Dim Ejercicio As String = VaInt(AlbSalida.ASA_ejercicio.Valor).ToString("00")
        Dim NumAlbaran As String = VaInt(AlbSalida.ASA_albaran.Valor).ToString

        Dim CodBar As String = "*AS" & Ejercicio & "." & NumAlbaran & "*"
        Dim Code39 As New Font("C39HrP24DhTt", 42)
        Impreso.Cabecera.Titulo(CodBar, 110, 5, 80, 18, Estilos.Custom, ">", , Code39)


    End Sub



    Private Sub ImprimeDetalleAlbaranSalida(ByRef Impreso As Impreso, ByRef altura As Integer, ByVal AlbSalida As E_AlbSalida, ByVal Cliente As E_Clientes,
                                              ByRef TotalPalets As Integer, ByRef TotalBultos As Integer, ByRef TotalPiezas As Integer,
                                              ByRef TotalKgBrutos As Decimal, ByRef TotalKgNetos As Decimal, ByRef TotalImporte As Decimal,
                                              ByRef LeyendaControlado As Boolean, ByRef ValorCambio As Decimal,
                                              ByRef TotalImporteDivisa As Decimal, ByRef abreviatura_divisa As String)


        Dim BaseAltura As Integer = altura
        ValorCambio = 0
        TotalImporteDivisa = 0
        abreviatura_divisa = ""

        Dim dt As DataTable = GeneraLineasAlbaranControladas(AlbSalida.ASA_idalbaran.Valor, Cliente, ValorCambio)


        'Debug
        'Dim dt2 As DataTable = dt.Copy
        'For indice As Integer = 0 To 15
        '    dt.Merge(dt2)
        'Next


        Dim bDivisa As Boolean = False : If VaInt(AlbSalida.ASA_iddivisa.Valor) > 1 Then bDivisa = True
        Dim Controlado As String = ""

        If Not IsNothing(dt) Then


            Dim nLineas As Integer = 1

            For Each row As DataRow In dt.Rows



                If nLineas > 7 Then
                    Impreso.Detalle.SaltoPagina()
                    nLineas = 1
                    altura = BaseAltura
                End If


                Dim Genero As String = row("Genero").ToString & ""
                Dim Categoria As String = row("Categoria").ToString & ""
                Dim IdPresentacion As String = row("IdPresentacion").ToString & ""
                Dim Presentacion As String = row("Presentacion").ToString & ""
                Dim Envase As String = row("Envase").ToString & ""
                Dim MarcaEnv As String = row("MarcaEnvase").ToString & ""
                Dim MarcaEti As String = row("MarcaEtiqueta").ToString & ""

                Dim Palets As Integer = VaInt(row("Palets"))
                Dim Bultos As Integer = VaInt(row("Bultos"))
                Dim Piezas As Integer = VaInt(row("Piezas"))
                Dim KgBrutos As Decimal = VaDec(row("KilosBrutos"))
                Dim KgNetos As Decimal = VaDec(row("KilosSalidos"))

                Dim Precio As Decimal = VaDec(row("Precio"))
                Dim Importe As Decimal = VaDec(row("Importe"))
                Dim TipoPrecio As String = (row("TipoPrecio").ToString & "").Trim.ToUpper
                If TipoPrecio = "" Then TipoPrecio = "K"



                Dim BxP As Decimal = 0


                If Palets <> 0 Then BxP = Bultos / Palets


                Dim PxB As Integer = VaInt(row("PxB"))

                'Dim KxB_Netos As Decimal = VaDec(row("KxB"))
                Dim KxB_Netos As Decimal = 0
                If Bultos <> 0 Then KxB_Netos = KgNetos / Bultos


                '3 casos
                'Controlada y acreditada: usamos la línea de los **
                'Controlada y no acreditada: usamos la línea de los ***
                'No controlada: no ponemos nada
                Dim LineaControlada As Boolean = ((row("Controlado").ToString & "").Trim.ToUpper = "S")
                Dim LineaAcreditada As Boolean = ((row("Acreditado").ToString & "").Trim = "S")

                If LineaControlada Then

                    If LineaAcreditada Then
                        Controlado = "**"
                    Else
                        Controlado = "***"
                    End If

                    LeyendaControlado = True

                End If



                Dim Lote As String = (row("Lote").ToString & "").Trim


                TotalPalets = TotalPalets + Palets
                TotalBultos = TotalBultos + Bultos
                TotalPiezas = TotalPiezas + Piezas
                TotalKgBrutos = TotalKgBrutos + KgBrutos
                TotalKgNetos = TotalKgNetos + KgNetos
                TotalImporte = TotalImporte + Importe
                TotalImporteDivisa = TotalImporteDivisa + (Importe * ValorCambio)


                'Cuadro
                Impreso.Detalle.Cuadro(margen_izquierdo, altura, 280, alto_linea_detalle, ancho_linea, Color.Black)
                altura = altura + 2


                Dim DetallarLotes As String = (Cliente.CLI_DesglosarLotes.Valor & "").Trim


                Impreso.Detalle.Titulo("Producto: ", margen_izquierdo + 5, altura, 16, 5, Estilos.Normal)
                Impreso.Detalle.Titulo(Presentacion & "  " & Controlado, margen_izquierdo + 5 + 16, altura, 160, 5, Estilos.NormalBold)
                Impreso.Detalle.Titulo("Categ./Calibre: ", margen_izquierdo + 185, altura, 25, 5, Estilos.Normal)
                Impreso.Detalle.Titulo(Categoria, margen_izquierdo + 185 + 25, altura, 45, 5, Estilos.NormalBold)
                If DetallarLotes = "S" Then
                    Impreso.Detalle.Titulo("Lote: ", margen_izquierdo + 257, altura, 10, 5, Estilos.Normal)
                    Impreso.Detalle.Titulo(Lote, margen_izquierdo + 257 + 10, altura, 15, 5, Estilos.NormalBold)
                End If
                altura = altura + 4
                Impreso.Detalle.Titulo("Envase: ", margen_izquierdo + 5, altura, 16, 5, Estilos.Normal)
                Impreso.Detalle.Titulo(Envase, margen_izquierdo + 16 + 5, altura, 115, 5, Estilos.NormalBold)
                Impreso.Detalle.Titulo("Marca envase: ", margen_izquierdo + 141, altura, 23, 5, Estilos.Normal)
                Impreso.Detalle.Titulo(MarcaEnv, margen_izquierdo + 141 + 23, altura, 42, 5, Estilos.NormalBold)
                Impreso.Detalle.Titulo("Marca etiq.: ", margen_izquierdo + 208, altura, 20, 5, Estilos.Normal)
                Impreso.Detalle.Titulo(MarcaEti, margen_izquierdo + 208 + 20, altura, 45, 5, Estilos.NormalBold)
                altura = altura + 4
                Impreso.Detalle.Titulo("Palets: ", margen_izquierdo + 5, altura, 16, 5, Estilos.Normal)
                Impreso.Detalle.Titulo(Palets.ToString("#,##0"), margen_izquierdo + 5 + 16, altura, 21, 5, Estilos.NormalBold)
                Impreso.Detalle.Titulo("BxPal: ", margen_izquierdo + 47, altura, 10, 5, Estilos.Normal)
                Impreso.Detalle.Titulo(BxP.ToString("#,##0"), margen_izquierdo + 47 + 10, altura, 32, 5, Estilos.NormalBold)
                Impreso.Detalle.Titulo("Bultos: ", margen_izquierdo + 94, altura, 12, 5, Estilos.Normal)
                Impreso.Detalle.Titulo(Bultos.ToString("#,##0"), margen_izquierdo + 94 + 12, altura, 30, 5, Estilos.NormalBold)
                Impreso.Detalle.Titulo("Piezas/B: ", margen_izquierdo + 141, altura, 15, 5, Estilos.Normal)
                Impreso.Detalle.Titulo(PxB.ToString("#,##0"), margen_izquierdo + 141 + 15, altura, 27, 5, Estilos.NormalBold)
                Impreso.Detalle.Titulo("Tot.Piezas: ", margen_izquierdo + 185, altura, 18, 5, Estilos.Normal)
                Impreso.Detalle.Titulo(Piezas.ToString("#,##0"), margen_izquierdo + 185 + 18, altura, 30, 5, Estilos.NormalBold)
                Impreso.Detalle.Titulo("KgNetos/B: ", margen_izquierdo + 238, altura, 18, 5, Estilos.Normal)
                Impreso.Detalle.Titulo(KxB_Netos.ToString("#,##0.00"), margen_izquierdo + 238 + 18, altura, 30, 5, Estilos.NormalBold)
                altura = altura + 4
                Impreso.Detalle.Titulo("KgBrutos: ", margen_izquierdo + 5, altura, 16, 5, Estilos.Normal)
                Impreso.Detalle.Titulo(KgBrutos.ToString("#,##0"), margen_izquierdo + 16 + 5, altura, 21, 5, Estilos.NormalBold)
                Impreso.Detalle.Titulo("KgNetos: ", margen_izquierdo + 47, altura, 15, 5, Estilos.Normal)
                Impreso.Detalle.Titulo(KgNetos.ToString("#,##0"), margen_izquierdo + 47 + 15, altura, 27, 5, Estilos.NormalBold)
                Impreso.Detalle.Titulo("Precio: ", margen_izquierdo + 94, altura, 12, 5, Estilos.Normal)
                Impreso.Detalle.Titulo(Precio.ToString("#,##0.0000") & " " & TipoPrecio, margen_izquierdo + 106, altura, 100, 5, Estilos.NormalBold)

                If bDivisa Then

                    Dim importe_divisa As Decimal = Importe * ValorCambio

                    Dim Moneda As New E_Moneda(Idusuario, cn)
                    If Moneda.LeerId(AlbSalida.ASA_iddivisa.Valor) Then
                        abreviatura_divisa = Moneda.MON_Abreviatura.Valor
                    End If

                    Impreso.Detalle.Titulo("Importe: ", margen_izquierdo + 141, altura, 15, 5, Estilos.Normal)
                    Impreso.Detalle.Titulo(importe_divisa.ToString("#,##0.00") & " " & abreviatura_divisa, margen_izquierdo + 141 + 15, altura, 100, 5, Estilos.NormalBold)
                Else
                    Impreso.Detalle.Titulo("Importe: ", margen_izquierdo + 141, altura, 15, 5, Estilos.Normal)
                    Impreso.Detalle.Titulo(Importe.ToString("#,##0.00"), margen_izquierdo + 141 + 15, altura, 100, 5, Estilos.NormalBold)
                End If


                altura = altura + 4
                altura = altura + 4


                nLineas = nLineas + 1

                Controlado = ""
            Next

        End If

    End Sub



    Private Sub ImprimirTotalAlbaranSalida(Impreso As Impreso, ByRef altura As Integer, AlbSalida As E_AlbSalida, Cliente As E_Clientes,
                                             TotalPalets As Integer, TotalBultos As Integer, TotalPiezas As Integer,
                                             TotalKgBrutos As Decimal, TotalKgNetos As Decimal, TotalImporte As Decimal, ValorCambio As Decimal,
                                             TotalImporteDivisa As Decimal, abreviatura_divisa As String)


        Dim altura_linea As Integer = 62
        If CompruebaSaltoPagina(altura, altura_linea) Then
            Impreso.Detalle.SaltoPagina()
            altura = altura_impreso
        End If


        Dim BaseAltura As Integer = altura

        Impreso.Detalle.Cuadro(margen_izquierdo + 125, altura, 155, 12, ancho_linea, Color.Black)
        Impreso.Detalle.LineaH(margen_izquierdo + 125, altura + 6, 155, ancho_linea)

        Impreso.Detalle.LineaV(margen_izquierdo + 145, altura, 12, ancho_linea)
        Impreso.Detalle.LineaV(margen_izquierdo + 165, altura, 12, ancho_linea)
        Impreso.Detalle.LineaV(margen_izquierdo + 190, altura, 12, ancho_linea)
        Impreso.Detalle.LineaV(margen_izquierdo + 219, altura, 12, ancho_linea)
        Impreso.Detalle.LineaV(margen_izquierdo + 244, altura, 12, ancho_linea)

        altura = altura + 1

        Impreso.Detalle.Titulo("PALETS", margen_izquierdo + 125, altura, 20, 6, Estilos.GrandeBold, "=")
        Impreso.Detalle.Titulo("BULTOS", margen_izquierdo + 145, altura, 20, 6, Estilos.GrandeBold, "=")
        Impreso.Detalle.Titulo("PIEZAS", margen_izquierdo + 165, altura, 25, 6, Estilos.GrandeBold, "=")
        Impreso.Detalle.Titulo("KG.BRUTOS", margen_izquierdo + 190, altura, 28, 6, Estilos.GrandeBold, "=")
        Impreso.Detalle.Titulo("KG.NETOS", margen_izquierdo + 219, altura, 25, 6, Estilos.GrandeBold, "=")
        Impreso.Detalle.Titulo("IMPORTE", margen_izquierdo + 244, altura, 36, 6, Estilos.GrandeBold, "=")
        altura = altura + 5
        Impreso.Detalle.Titulo(TotalPalets.ToString("#,##0"), margen_izquierdo + 125 + 1, altura, 18, 6, Estilos.GrandeBold, "=")
        Impreso.Detalle.Titulo(TotalBultos.ToString("#,##0"), margen_izquierdo + 145 + 1, altura, 18, 6, Estilos.GrandeBold, "=")
        Impreso.Detalle.Titulo(TotalPiezas.ToString("#,##0"), margen_izquierdo + 165 + 1, altura, 23, 6, Estilos.GrandeBold, "=")
        Impreso.Detalle.Titulo(TotalKgBrutos.ToString("#,##0"), margen_izquierdo + 190 + 1, altura, 27, 6, Estilos.GrandeBold, "=")
        Impreso.Detalle.Titulo(TotalKgNetos.ToString("#,##0"), margen_izquierdo + 219 + 1, altura, 23, 6, Estilos.GrandeBold, "=")
        Impreso.Detalle.Titulo(TotalImporte.ToString("#,##0.00"), margen_izquierdo + 244 + 1, altura, 34, 6, Estilos.GrandeBold, "=")

        
        altura = altura + 6

        altura = altura + 3



        'Palets Transporte
        Dim sqlPalets As String = "SELECT PLM_Medidas as Medida, SUM(ASL_Palets * CPA_Coeficiente) as Numero" & vbCrLf
        sqlPalets = sqlPalets & " FROM AlbSalida_Lineas" & vbCrLf
        sqlPalets = sqlPalets & " LEFT JOIN ConfecPalet ON CPA_IdConfec = ASL_IdTipoPalet" & vbCrLf
        sqlPalets = sqlPalets & " LEFT JOIN Envases ON CPA_IdPalet = ENV_IdEnvase" & vbCrLf
        sqlPalets = sqlPalets & " LEFT JOIN MedidasPalet ON PLM_Id = ENV_IdMedida" & vbCrLf
        sqlPalets = sqlPalets & " WHERE ASL_IdAlbaran = " & AlbSalida.ASA_idalbaran.Valor & vbCrLf
        sqlPalets = sqlPalets & " GROUP BY PLM_Medidas" & vbCrLf
        sqlPalets = sqlPalets & " ORDER BY Medida" & vbCrLf

        Dim TotalPaletsTransporte As Integer = 0

        Dim dtPalets As DataTable = AlbSalida.MiConexion.ConsultaSQL(sqlPalets)
        If Not IsNothing(dtPalets) Then

            Dim altura_palet As Integer = altura + 4

            For Each rowPalet As DataRow In dtPalets.Rows

                Dim Medida As String = (rowPalet("Medida").ToString & "").Trim
                Medida = StrConv(Medida, vbProperCase)

                Dim Numero As Integer = VaInt(rowPalet("Numero"))

                TotalPaletsTransporte = TotalPaletsTransporte + Numero

                Impreso.Detalle.Titulo(Medida & ": " & Numero.ToString, margen_izquierdo + 120, altura_palet, 35, 6, Estilos.NormalBold)

                altura_palet = altura_palet + 4
            Next
        End If

        Impreso.Detalle.Titulo("Palets Transporte: " & TotalPaletsTransporte.ToString, margen_izquierdo + 120, altura, 35, 6, Estilos.NormalBold)



        'Comisión
        Impreso.Detalle.Cuadro(margen_izquierdo + 165, altura, 95, 20, ancho_linea, Color.Black)
        Impreso.Detalle.LineaH(margen_izquierdo + 165, altura + 5, 95, ancho_linea)
        Impreso.Detalle.LineaV(margen_izquierdo + 165 + 45, altura, 20, ancho_linea)
        Impreso.Detalle.LineaV(margen_izquierdo + 165 + 55, altura, 20, ancho_linea)
        Impreso.Detalle.LineaV(margen_izquierdo + 165 + 55 + 17, altura, 20, ancho_linea)
        altura = altura + 1

        Impreso.Detalle.Titulo("CONCEPTO", margen_izquierdo + 165 + 1, altura, 54, 3, Estilos.Minima)
        Impreso.Detalle.Titulo("TIPO", margen_izquierdo + 165 + 45 + 1, altura, 9, 3, Estilos.Minima, "=")
        Impreso.Detalle.Titulo("VALOR", margen_izquierdo + 165 + 55, altura, 17, 3, Estilos.Minima, "=")
        Impreso.Detalle.Titulo("IMPORTE", margen_izquierdo + 165 + 55 + 17, altura, 23, 3, Estilos.Minima, "=")
        altura = altura + 5

        Dim sqlGastos As String = "SELECT GCO_Nombre as Gasto, ASG_ValorGasto as Valor, ASG_TipoKBP as Tipo, ASG_ImporteGastoDivisa AS Importe" & vbCrLf
        sqlGastos = sqlGastos & " FROM AlbSalida_Gastos" & vbCrLf
        sqlGastos = sqlGastos & " LEFT JOIN GastosComercio ON GCO_IdGasto = ASG_IdGasto" & vbCrLf
        sqlGastos = sqlGastos & " WHERE ASG_IdAlbaran = " & AlbSalida.ASA_idalbaran.Valor & vbCrLf
        sqlGastos = sqlGastos & " AND ASG_TipoFC = 'F'" & vbCrLf

        Dim dtGastos As DataTable = AlbSalida.MiConexion.ConsultaSQL(sqlGastos)
        If Not IsNothing(dtGastos) Then

            Dim cont As Integer = 1

            For Each row As DataRow In dtGastos.Rows

                If cont > 6 Then
                    Exit For
                End If

                Dim Gasto As String = (row("Gasto").ToString & "").Trim
                Dim Tipo As String = (row("Tipo").ToString & "").Trim
                Dim Valor As String = VaDec(row("Valor")).ToString("#,##0.0000")
                Dim Importe As String = VaDec(row("Importe")).ToString("#,##0.00")

                Impreso.Detalle.Titulo(Gasto, margen_izquierdo + 165 + 1, altura, 61, 3, Estilos.Minima)
                Impreso.Detalle.Titulo(Tipo, margen_izquierdo + 165 + 45 + 1, altura, 8, 3, Estilos.Minima, "=")
                Impreso.Detalle.Titulo(Valor, margen_izquierdo + 165 + 45 + 10 + 1, altura, 15, 3, Estilos.Minima, ">")
                Impreso.Detalle.Titulo(Importe, margen_izquierdo + 165 + 45 + 10 + 17 + 1, altura, 21, 3, Estilos.Minima, ">")

                altura = altura + 2

                cont = cont + 1

            Next


        End If



        'Envases
        altura = BaseAltura + 2

        Impreso.Detalle.Cuadro(margen_izquierdo, altura, 53, 40, ancho_linea, Color.Black)
        Impreso.Detalle.LineaH(margen_izquierdo, altura + 5, 53, ancho_linea)
        Impreso.Detalle.LineaV(margen_izquierdo + 33, altura, 40, ancho_linea)
        Impreso.Detalle.LineaV(margen_izquierdo + 33 + 10, altura, 40, ancho_linea)

        altura = altura + 1

        Impreso.Detalle.Titulo("PALETS / ENVASES", margen_izquierdo + 1, altura, 30, 3, Estilos.Minima)
        Impreso.Detalle.Titulo("RET", margen_izquierdo + 33, altura, 9, 3, Estilos.Minima, ">")
        Impreso.Detalle.Titulo("ENT", margen_izquierdo + 33 + 10, altura, 9, 3, Estilos.Minima, ">")
        altura = altura + 5

        Dim IdValeEnvase As String = AlbSalida.ASA_idvaleenvase.Valor

        If VaInt(IdValeEnvase) > 0 Then

            Dim sql As String = "SELECT ENV_Nombre as Envase, VEL_Retira as Retira, VEL_Entrega as Entrega " & vbCrLf
            sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
            sql = sql & " LEFT JOIN Envases ON VEL_IdEnvase = ENV_IdEnvase" & vbCrLf
            sql = sql & " WHERE VEL_IdVale = " & IdValeEnvase & vbCrLf

            Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                Dim cont As Integer = 1

                For Each row As DataRow In dt.Rows

                    If cont > 12 Then
                        Exit For
                    End If

                    Dim Envase As String = (row("Envase").ToString & "").Trim
                    Dim Retira As Integer = VaInt(row("Retira"))
                    Dim Entrega As Integer = VaInt(row("Entrega"))

                    Impreso.Detalle.Titulo(Envase, margen_izquierdo + 1, altura, 29, 3, Estilos.Minima)
                    If Retira <> 0 Then Impreso.Detalle.Titulo(Retira.ToString("#,##0"), margen_izquierdo + 33 + 1, altura, 8, 3, Estilos.Minima, ">")
                    If Entrega <> 0 Then Impreso.Detalle.Titulo(Entrega.ToString("#,##0"), margen_izquierdo + 33 + 10 + 1, altura, 8, 3, Estilos.Minima, ">")

                    altura = altura + 2

                    cont = cont + 1

                Next

            End If


        End If



        'Transportista
        altura = BaseAltura + 2

        Dim Transportista As String = ""
        Dim Matricula As String = (AlbSalida.ASA_matriculacamion.Valor & "").Trim
        Dim MatRemolque As String = (AlbSalida.ASA_matricularemolque.Valor & "").Trim
        Dim MovilChofer As String = (AlbSalida.ASA_movilchofer.Valor & "").Trim

        If VaInt(AlbSalida.ASA_idtransportista.Valor) > 0 Then

            Dim Acreedores As New E_Acreedores(Idusuario, cn)
            If Acreedores.LeerId(AlbSalida.ASA_idtransportista.Valor) Then
                Transportista = Acreedores.ACR_Nombre.Valor
            End If

        End If

        Impreso.Detalle.Titulo("TRANSPORTISTA:", margen_izquierdo + 53 + 3, altura, 32, 4, Estilos.NormalBold)
        altura = altura + 4
        Impreso.Detalle.Titulo(Transportista, margen_izquierdo + 53 + 3, altura, 64, 4, Estilos.Normal)
        altura = altura + 4
        Impreso.Detalle.Titulo("MAT. CAMION: ", margen_izquierdo + 53 + 3, altura, 28, 4, Estilos.NormalBold)
        Impreso.Detalle.Titulo(Matricula, margen_izquierdo + 53 + 3 + 28, altura, 30, 4, Estilos.Normal)
        altura = altura + 4
        Impreso.Detalle.Titulo("MAT. REMOLQUE: ", margen_izquierdo + 53 + 3, altura, 32, 4, Estilos.NormalBold)
        Impreso.Detalle.Titulo(MatRemolque, margen_izquierdo + 53 + 3 + 32, altura, 30, 4, Estilos.Normal)
        altura = altura + 4
        Impreso.Detalle.Titulo("MOVIL CHOFER: ", margen_izquierdo + 53 + 3, altura, 28, 4, Estilos.NormalBold)
        Impreso.Detalle.Titulo(MovilChofer, margen_izquierdo + 53 + 3 + 28, altura, 30, 4, Estilos.Normal)

        'Condiciones de venta
        altura = BaseAltura + 2 + 20 + 5 - 4 + 20

        Dim TipoPorte As String = ""
        Dim TiposPorte As New E_TiposPorte(Idusuario, cn)
        If VaInt(AlbSalida.ASA_idtipoporte.Valor) > 0 Then
            If TiposPorte.LeerId(AlbSalida.ASA_idtipoporte.Valor) Then
                TipoPorte = TiposPorte.TPO_Nombre.Valor
            End If
            Impreso.Detalle.Titulo("CONDICIONES E VENTA S/INCOTERMS (2020): " & TipoPorte, margen_izquierdo, altura, 150, 4, Estilos.Reducida)
        End If

        altura = altura + 5

        'Domicilio de descarga
        Dim Nombre_Domicilio_descarga As String = ""
        Dim Domicilio_Descarga As String = ""
        Dim Provincia_Descarga As String = ""

        If VaInt(AlbSalida.ASA_iddomicilio.Valor) > 0 Then
            Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
            If ClientesDescargas.LeerId(AlbSalida.ASA_iddomicilio.Valor) Then
                Nombre_Domicilio_descarga = VaInt(ClientesDescargas.CLD_numero.Valor).ToString("00") & " - " & ClientesDescargas.CLD_Domicilio.Valor
                Domicilio_Descarga = (ClientesDescargas.CLD_CPostal.Valor & "").Trim & " - " & (ClientesDescargas.CLD_Poblacion.Valor & "").Trim
                Provincia_Descarga = (ClientesDescargas.CLD_Provincia.Valor & "").Trim & " - Fax: " & (Cliente.CLI_Fax.Valor & "").Trim
            End If
        End If

        Impreso.Detalle.Titulo("Domicilio de descarga:", margen_izquierdo, altura, 80, 4, Estilos.ReducidaBold)
        altura = altura + 4
        Impreso.Detalle.Titulo(Nombre_Domicilio_descarga, margen_izquierdo, altura, 80, 4, Estilos.Reducida)
        altura = altura + 4
        Impreso.Detalle.Titulo(Domicilio_Descarga, margen_izquierdo, altura, 80, 4, Estilos.Reducida)
        altura = altura + 4
        Impreso.Detalle.Titulo(Provincia_Descarga, margen_izquierdo, altura, 80, 4, Estilos.Reducida)

        'Bases
        altura = BaseAltura + 2 + 37

        Impreso.Detalle.Cuadro(margen_izquierdo + 165, altura, 110, 20, ancho_linea, Color.Black)
        Impreso.Detalle.LineaH(margen_izquierdo + 165, altura + 5, 110, ancho_linea)
        Impreso.Detalle.LineaV(margen_izquierdo + 165 + 32, altura, 20, ancho_linea)
        Impreso.Detalle.LineaV(margen_izquierdo + 165 + 45, altura, 20, ancho_linea)
        Impreso.Detalle.LineaV(margen_izquierdo + 165 + 72, altura, 20, ancho_linea)
        altura = altura + 1

        Impreso.Detalle.Titulo("Base Imponible", margen_izquierdo + 165, altura, 32, 4, Estilos.NormalBold, "=")
        Impreso.Detalle.Titulo("%", margen_izquierdo + 165 + 32, altura, 13, 4, Estilos.NormalBold, "=")
        Impreso.Detalle.Titulo("I.V.A.", margen_izquierdo + 165 + 45, altura, 27, 4, Estilos.NormalBold, "=")
        Impreso.Detalle.Titulo("TOTAL ALBARAN", margen_izquierdo + 165 + 72, altura, 38, 4, Estilos.NormalBold, "=")

        Dim Base1 As Decimal = 0
        Dim Base2 As Decimal = 0
        Dim Iva1 As Decimal = 0
        Dim Iva2 As Decimal = 0


        Dim ImpGenero As Decimal = AlbSalida.TotalGenero(AlbSalida.ASA_idalbaran.Valor & "", True)
        Dim GastosFra = AlbSalida.GastosFactura(AlbSalida.ASA_idalbaran.Valor & "")

        Base1 = ImpGenero - GastosFra
        If VaInt(AlbSalida.ASA_idvaleenvase.Valor) > 0 Then Base2 = AlbSalida.TotalEnvases(AlbSalida.ASA_idvaleenvase.Valor & "")


        If VaInt(Cliente.CLI_IdTipo.Valor) > 0 Then

            Dim TiposClientes As New E_Tiposclientes(Idusuario, cn)
            If TiposClientes.LeerId(Cliente.CLI_IdTipo.Valor) Then

                Dim ExentoIVA As String = (TiposClientes.TPC_exentoiva.Valor & "").Trim.ToUpper

                Dim TipoIva As New E_tiposiva(Idusuario, cn)
                Dim dtIva As DataTable = TipoIva.Tabla

                For Each rw In dtIva.Rows
                    Select Case rw("id").ToString
                        Case "1"
                            'If ExentoIVA <> "S" Then Iva1 = VaDec(rw("iva"))
                            If ExentoIVA <> "S" Then
                                Iva1 = VaDec(rw("iva"))
                                Iva2 = VaDec(rw("iva")) 'El mismo iva para envases que para género. Igual que en las facturas
                            End If

                            'Case "2"
                            '    If ExentoIVA <> "S" Then Iva2 = VaDec(rw("iva"))
                    End Select
                Next

            End If

        End If

        Base1 = Base1 * ValorCambio
        Base2 = Base2 * ValorCambio


        Dim CuotaIva1 As Decimal = Base1 * Iva1 / 100
        Dim CuotaIva2 As Decimal = Base2 * Iva2 / 100
        Dim Total As Decimal = Base1 + CuotaIva1 + Base2 + CuotaIva2


        altura = altura + 5

        Impreso.Detalle.Titulo(Base1.ToString("#,##0.00"), margen_izquierdo + 165 + 1, altura, 25, 4, Estilos.Normal, ">")
        Impreso.Detalle.Titulo(Iva1.ToString("#,##0.00"), margen_izquierdo + 165 + 32 + 1, altura, 11, 4, Estilos.Normal, "=")
        Impreso.Detalle.Titulo(CuotaIva1.ToString("#,##0.00"), margen_izquierdo + 165 + 45, altura, 20, 4, Estilos.Normal, ">")
        altura = altura + 5
        Impreso.Detalle.Titulo(Base2.ToString("#,##0.00"), margen_izquierdo + 165 + 1, altura, 25, 4, Estilos.Normal, ">")
        Impreso.Detalle.Titulo(Iva2.ToString("#,##0.00"), margen_izquierdo + 165 + 32 + 1, altura, 11, 4, Estilos.Normal, "=")
        Impreso.Detalle.Titulo(CuotaIva2.ToString("#,##0.00"), margen_izquierdo + 165 + 45, altura, 20, 4, Estilos.Normal, ">")

        If abreviatura_divisa.Trim <> "" Then
            Dim TotalDivisa As Decimal = Total * ValorCambio
            Impreso.Detalle.Titulo(TotalDivisa.ToString("#,##0.00") & " " & abreviatura_divisa, margen_izquierdo + 170 + 72, altura, 31, 6, Estilos.GrandeBold, ">")
        Else
            Impreso.Detalle.Titulo(Total.ToString("#,##0.00") & " €", margen_izquierdo + 165 + 72, altura, 31, 6, Estilos.GrandeBold, ">")
        End If


        altura = altura + 2



        'Conforme
        Impreso.Detalle.Titulo("Conforme el Transportista", margen_izquierdo + 65, altura, 100, 4, Estilos.Reducida, "=")



    End Sub


    Private Sub ImprimirPieAlbaranSalida(ByVal Impreso As Impreso, AlbSalida As E_AlbSalida, ByVal DatosEmpresa As DatosEmpresa)

        Dim y As Integer = 186

        Dim observaciones As String = (AlbSalida.ASA_observaciones.Valor & "").Trim

        If VaInt(AlbSalida.ASA_idpedido.Valor) > 0 Then
            Dim Pedidos As New E_Pedidos(Idusuario, cn)
            If Pedidos.LeerId(AlbSalida.ASA_idpedido.Valor) Then

                Dim BESTELLNR As String = (Pedidos.PED_BESTELLNR.Valor & "").Trim
                If BESTELLNR <> "" Then
                    observaciones = "BESTELLNUMMER: " & BESTELLNR & ". " & observaciones
                End If

            End If
        End If


        Impreso.Detalle.Titulo("OBSERVACIONES:", margen_izquierdo, y - 4, 280, 4, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo(observaciones, margen_izquierdo + 28, y - 4, 252, 4, Estilos.Reducida)



        y = y + 6


        Dim NumRegTemperatura As String = AlbSalida.ASA_numregtemperatura.Valor
        Dim texto_temperatura As String = "Registrador de temperatura / RYAN: " & NumRegTemperatura

        'If LeyendaControlado Then
        Impreso.Detalle.Titulo(texto_temperatura, margen_izquierdo, y - 4, 280, 4, Estilos.ReducidaBold)
        Impreso.Detalle.Titulo("** Producto controlado GLOBALGAP - GGN: " & DatosEmpresa.GGN & ". Producto Origen ESPAÑA.", margen_izquierdo, y, 280, 4, Estilos.Reducida)
        'End If
        Impreso.Detalle.Titulo("*** Producto controlado GLOBALGAP - CoC: " & DatosEmpresa.GGN & " Producto Origen ESPAÑA.", margen_izquierdo, y + 4, 280, 4, Estilos.Reducida)

        y = y + 4


        Dim bProductoEcologico As Boolean = False
        Dim NumRegistro As String = ""



        Dim IdPuntoVenta As String = (AlbSalida.ASA_idpuntoventa.Valor & "").Trim
        If VaInt(IdPuntoVenta) > 0 Then

            Dim ValoresPVenta As New E_valorespventa(Idusuario, cn)
            If ValoresPVenta.LeerId(IdPuntoVenta) Then

                Dim Ecologico As String = (ValoresPVenta.VPV_EcologicoSN.Valor & "").Trim
                bProductoEcologico = (Ecologico = "S")
                NumRegistro = (ValoresPVenta.VPV_NumRegistroEco.Valor & "").Trim

            End If

        End If


        If bProductoEcologico Then
            Impreso.Detalle.Titulo("PROCEDENTE DEL CULTIVO ECOLOGICO, SISTEMA DE CONTROL UE: " & NumRegistro, margen_izquierdo + 150, y, 140, 4, Estilos.Reducida)
            Impreso.Detalle.Titulo("REGLAMENTO UE-834/2007", margen_izquierdo + 150, y + 4, 140, 4, Estilos.Reducida)
        End If

        Impreso.Detalle.Titulo(DatosEmpresa.NombreEmpresa & " no acepta ninguna reclamación pasadas 24 horas de la descarga de la mercancía.", margen_izquierdo, y + 4, 150, 4, Estilos.Reducida)




    End Sub


    Private Function CompruebaSaltoPagina(altura As Integer, altura_linea As Integer) As Boolean

        Dim bRes As Boolean = False

        If altura + altura_linea > Pie_linea Then
            bRes = True
        End If


        Return bRes

    End Function

    Private Function LineaControlada(ByVal AlbSalida As E_AlbSalida, ByVal row As DataRow, ByVal BxP As Integer) As Boolean

        Dim res As Boolean = False


        If VaInt(AlbSalida.ASA_idalbaran.Valor) > 0 Then

            Dim IdGenero As Integer = VaInt(row("IdGenero"))
            Dim IdTipoConfeccion As Integer = VaInt(row("IdTipoConfeccion"))
            Dim IdMarca As Integer = VaInt(row("IdMarcaEnvase"))
            Dim IdCategoria As Integer = VaInt(row("IdCategoria"))
            Dim Categoria As String = (row("Categoria").ToString & "").Trim
            'Dim IdGenSal As Integer = VaInt(row("IdGenSal"))
            Dim IdGenSal As Integer = VaInt(row("IdPresentacion"))
            'Dim IdTipoPalet As Integer = VaInt(row("IdTipoPalet"))


            Dim sql As String = "SELECT PLL_IdGenero as IdGenero, PLL_IdTipoConfeccion as IdTipoConfeccion, PLL_IdMarca as IdMarca, PLL_IdCategoria as IdCategoria," & vbCrLf
            sql = sql & " PLL_Categoria as Categoria, PLL_IdGenSal as IdGenSal, PLL_Controlado as Controlado, PLL_Bultos as Bultos"
            sql = sql & " FROM Palets_Lineas"
            sql = sql & " LEFT JOIN Palets ON PAL_IdPalet = PLL_IdPalet "
            sql = sql & " LEFT JOIN AlbSalida_Palets ON ASP_IdPalet = PLL_IdPalet"
            sql = sql & " WHERE ASP_IdAlbaran = " & AlbSalida.ASA_idalbaran.Valor


            Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then

                For Each rowP As DataRow In dt.Rows

                    If IdGenero = VaInt(rowP("IdGenero")) And IdTipoConfeccion = VaInt(rowP("IdTipoConfeccion")) And IdMarca = VaInt(rowP("IdMarca")) And IdCategoria = VaInt(rowP("IdCategoria")) And
                        Categoria = (rowP("Categoria").ToString & "").Trim And IdGenSal = VaInt(rowP("IdGensal")) And BxP = VaInt(rowP("Bultos")) Then

                        Dim Controlado As String = (rowP("Controlado").ToString & "").Trim.ToUpper
                        If Controlado = "S" Then
                            res = True
                        Else
                            res = False
                        End If

                        Exit For

                    End If

                Next

            End If


        End If



        Return res

    End Function



    Private Function GeneraLineasAlbaranControladas(ByVal IdAlbaran As String, Cliente As E_Clientes, ByRef ValorCambio As Decimal) As DataTable

        ' genera datatable con las lineas de impresión
        Dim acum As New Acumulador


        Dim AlbSalida_Palets As New E_albsalida_palets(Idusuario, cn)
        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
        Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)
        Dim Clientes As New E_Clientes(Idusuario, cn)
        Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
        'Dim AlbSalida_Lineas As New E_AlbSalida_lineas(Idusuario, cn)
        Dim Palets As New E_palets(Idusuario, cn)
        Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
        Dim Generoscompuestos As New E_GenerosCompuestos(Idusuario, cn)
        Dim CatSalidaComercial As New E_CatSalidaComercial(Idusuario, cn)
        Dim TiposPortes As New E_TiposPorte(Idusuario, cn)
        Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)


        ValorCambio = 0


        If AlbSalida.LeerId(IdAlbaran) = False Then Return Nothing
        ValorCambio = VaDec(AlbSalida.ASA_valorcambio.Valor)
        If ValorCambio = 0 Then
            ValorCambio = 1
        End If



        Dim sql As String = "SELECT ASP_IdPalet, PLL_IdGenero as IdGenero, GEN_NombreGenero as Genero, " & vbCrLf
        sql = sql & " PLL_IdTipoConfeccion as IdTipoConfeccion, PLL_IdCategoria as IdCategoria, PLL_Categoria as Categoria," & vbCrLf
        sql = sql & " PLL_IdGenSal as IdPresentacion, GES_DescripcionAlb as Presentacion, PLL_IdMarca as IdMarcaEnvase, MarcaEnvase.MAR_Nombre as MarcaEnvase, " & vbCrLf
        sql = sql & " PLL_IdTipoConfeccion as IdTipoConfeccion, CEV_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
        sql = sql & " GES_IdMarcaEtiqueta as IdMarcaEti, MarcasEti.MAR_Nombre as MarcaEtiqueta, PAL_IdTipoPalet as IdTipoPalet," & vbCrLf
        sql = sql & " PLL_KilosBrutos as KgBrutos, PLL_KilosNetos as KilosNetos, PLL_KilosCliente as KgCliente," & vbCrLf
        'sql = sql & " GES_PiezasxBulto as PxB, GES_KilosxBulto as KxB," & vbCrLf
        sql = sql & " GES_PiezasxBulto as PxB," & vbCrLf
        sql = sql & " PLL_Bultos as Bultos, COALESCE(PLL_PiezasxBulto,0) * COALESCE(PLL_Bultos,0) as Piezas, PLL_CosteEstructura as CosteEstructura, PLL_CosteConfeccion as CosteConfeccion," & vbCrLf
        sql = sql & " PLL_CosteMaterial as CosteMaterial, PLL_CoeficientePalet as CoeficientePalet, PLL_Controlado as Controlado, FAG_Acreditado as Acreditado," & vbCrLf
        sql = sql & " PAL_Lote as Lote, PAL_PaletsTransporte as PaletsTransporte" & vbCrLf
        sql = sql & " FROM AlbSalida_Palets" & vbCrLf
        sql = sql & " LEFT JOIN Palets_Lineas ON ASP_IdPalet = PLL_IdPalet" & vbCrLf
        sql = sql & " LEFT JOIN Palets ON ASP_IdPalet = PAL_IdPalet" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = PLL_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN SubFamilias ON GEN_IdSubfamilia = SFA_Id" & vbCrLf
        sql = sql & " LEFT JOIN FamiliasGeneros ON FAG_IdFamilia = SFA_IdFamilia" & vbCrLf
        sql = sql & " LEFT JOIN GenerosSalida ON GES_IdGenSal = PLL_IdGenSal" & vbCrLf
        sql = sql & " LEFT JOIN Marcas as MarcaEnvase ON MarcaEnvase.MAR_IdMarca = PLL_IdMarca" & vbCrLf
        'sql = sql & " LEFT JOIN Marcas as MarcasEti ON MarcasEti.MAR_IdMarca = GES_IdMarcaEtiqueta" & vbCrLf
        sql = sql & " LEFT JOIN Marcas as MarcasEti ON MarcasEti.MAR_IdMarca = PLL_IdMarcaEti" & vbCrLf
        sql = sql & " LEFT JOIN ConfecEnvase ON PLL_IdTipoConfeccion = CEV_IdConfec" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = CEV_IdEnvase" & vbCrLf
        sql = sql & " WHERE ASP_IdAlbaran = " & IdAlbaran & vbCrLf
        sql = sql & " ORDER BY ASP_IdPalet"


        Dim dtp As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)


        Dim np As String = ""


        Dim DetallarLotes As String = (Cliente.CLI_DesglosarLotes.Valor & "").Trim


        For Each rwp In dtp.Rows

            Dim palet As Integer = 0

            If np <> rwp("asp_idpalet").ToString Then
                palet = 1
            Else
                palet = 0
            End If


            Dim IdGenero As Integer = VaInt(rwp("IdGenero"))
            Dim Genero As String = (rwp("Genero").ToString & "").Trim
            Dim IdTipoConfeccion As Integer = VaInt(rwp("IdTipoConfeccion"))
            Dim IdCategoria As Integer = VaInt(rwp("IdCategoria"))
            Dim Categoria As String = (rwp("Categoria").ToString & "").Trim
            Dim IdMarcaEnvase As Integer = VaInt(rwp("IdMarcaEnvase"))
            Dim MarcaEnvase As String = (rwp("MarcaEnvase").ToString & "").Trim
            Dim IdMarcaEti As Integer = VaInt(rwp("IdMarcaEti"))
            Dim MarcaEtiqueta As String = (rwp("MarcaEtiqueta").ToString & "").Trim
            Dim IdPresentacion As Integer = VaInt(rwp("IdPresentacion"))
            Dim Presentacion As String = (rwp("Presentacion").ToString & "").Trim
            Dim IdEnvase As Integer = VaInt(rwp("IdEnvase"))
            Dim Envase As String = (rwp("Envase"))
            Dim Bultos As Integer = VaInt(rwp("Bultos"))
            Dim Piezas As Integer = VaInt(rwp("Piezas"))
            Dim BultosxPalet As Integer = Bultos
            Dim PxB As Integer = VaInt(rwp("PxB"))
            Dim IdTipoPalet As Integer = VaInt(rwp("IdTipoPalet"))

            'Dim KxB As Decimal = VaDec(rwp("KxB"))
            Dim KxB As Decimal = 0


            Dim Controlado As String = (rwp("Controlado").ToString & "").Trim
            If Controlado <> "S" Then Controlado = "N"
            Dim Acreditado As String = (rwp("Acreditado").ToString & "").Trim
            If Acreditado <> "S" Then Acreditado = "N"

            Dim KilosBrutos As Decimal = VaDec(rwp("KgBrutos"))
            Dim KilosNetos As Decimal = VaDec(rwp("KilosNetos"))
            Dim KilosCliente As Decimal = VaDec(rwp("KgCliente"))
            Dim CosteEstructura As Decimal = VaDec(rwp("CosteEstructura"))
            Dim CosteConfeccion As Decimal = VaDec(rwp("CosteConfeccion"))
            Dim CosteMaterial As Decimal = VaDec(rwp("CosteMaterial"))
            Dim CoeficientePalet As Decimal = VaDec(rwp("CoeficientePalet"))


            Dim Lote As String = (rwp("Lote").ToString & "").Trim
            If DetallarLotes <> "S" Then
                Lote = ""
            End If



            Dim clave As New stClave_lineasAlbaranControladas(IdGenero, Genero, Categoria, IdPresentacion, Presentacion, IdEnvase, Envase, IdMarcaEnvase, MarcaEnvase,
                                            IdMarcaEti, MarcaEtiqueta, IdTipoPalet, IdTipoConfeccion, IdCategoria, BultosxPalet, PxB, KxB, Controlado, Lote, Acreditado)
            Dim datos As New stDatos_lineasAlbaran(palet, Bultos, KilosNetos, KilosBrutos, KilosCliente, Piezas, CosteEstructura, CosteConfeccion, CosteMaterial, CoeficientePalet)


            acum.Suma(clave, datos)

            np = rwp("asp_idpalet").ToString


        Next



        sql = "Select * from albsalida_lineas where ASL_idalbaran=" + IdAlbaran
        Dim dTL0 As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)



        Dim dt As DataTable = acum.DataTable
        If Not IsNothing(dt) Then

            dt.Columns.Add(New DataColumn("Importe", GetType(Decimal)))

            For Each row As DataRow In dt.Rows

                Dim Bultos As Integer = VaInt(row("Bultos"))
                Dim Piezas As Integer = VaInt(row("Piezas"))

                Dim IdPresentacion As Integer = VaInt(row("IdPresentacion"))
                Dim IdCategoria As Integer = VaInt(row("IdCategoria"))
                Dim IdMarca As Integer = VaInt(row("IdMarcaEnvase"))
                Dim IdGenero As Integer = VaInt(row("IdGenero"))
                Dim IdTipoConfeccion As Integer = VaInt(row("IdTipoConfeccion"))
                Dim Categoria As String = (row("Categoria").ToString & "").Trim
                Dim IdTipoPalet As Integer = VaInt(row("IdTipoPalet"))
                Dim KilosSalidos As Decimal = VaDec(row("KilosSalidos"))

                Dim Precio As Decimal = 0
                Dim PrecioEnvase As Decimal = 0
                Dim PrecioPalet As Decimal = 0
                Dim Tipoprecio As String = ""
                Dim Tipoprecioestimado As String = ""
                Dim PrecioEstimado As Decimal = 0


                'If dTL0 Is Nothing Then
                '    PrecioLineaPedido(AlbSalida.ASA_idpedido.Valor, IdPresentacion, IdCategoria, IdMarca, 0, Tipoprecio, Precio, PrecioEnvase, PrecioPalet, PrecioEstimado, AlbSalida.ASA_idcliente.Valor, Tipoprecioestimado)
                'Else
                '    PrecioLinea(dTL0, IdPresentacion, IdGenero, IdTipoConfeccion, IdMarca, IdCategoria, Categoria, 0, Tipoprecio, Precio, PrecioEnvase, PrecioPalet, PrecioEstimado, Tipoprecioestimado)
                'End If


                If dTL0 Is Nothing Then
                    PrecioLineaPedido(AlbSalida.ASA_idpedido.Valor, IdPresentacion, IdCategoria, IdMarca, IdTipoPalet, Tipoprecio, Precio, PrecioEnvase, PrecioPalet, PrecioEstimado, AlbSalida.ASA_idcliente.Valor, Tipoprecioestimado)
                Else
                    PrecioLinea(dTL0, IdPresentacion, IdGenero, IdTipoConfeccion, IdMarca, IdCategoria, Categoria, IdTipoPalet, Tipoprecio, Precio, PrecioEnvase, PrecioPalet, PrecioEstimado, Tipoprecioestimado)
                End If


                Dim ImporteLinea As Decimal = 0
                Dim ImporteLineaEstimado As Decimal = 0


                If PrecioEstimado = 0 Then PrecioEstimado = Precio
                Select Case Tipoprecio
                    Case "K"
                        ImporteLinea = KilosSalidos * Precio
                    Case "B"
                        ImporteLinea = Bultos * Precio
                    Case "P"
                        ImporteLinea = Piezas * Precio

                End Select

                Select Case Tipoprecioestimado
                    Case "K"
                        ImporteLineaEstimado = KilosSalidos * PrecioEstimado
                    Case "B"
                        ImporteLineaEstimado = Bultos * PrecioEstimado
                    Case "P"
                        ImporteLineaEstimado = Piezas * PrecioEstimado
                End Select



                row("TipoPrecio") = Tipoprecio
                row("Precio") = Precio * ValorCambio
                row("Importe") = ImporteLineaEstimado * ValorCambio

            Next

        End If



        Return dt


    End Function


End Module


