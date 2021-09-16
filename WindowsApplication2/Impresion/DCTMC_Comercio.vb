Imports System.Drawing
Imports DevExpress.XtraEditors



Module DCTMC_Comercio


    Public Sub ImprimirDCTMC(IdCMR As String, TipoImpresion As TipoImpresion, Impresora As String, Optional rutaPDF As String = "")


        If VaInt(IdCMR) > 0 Then

            Dim CMR As New E_Cmr(Idusuario, cn)
            If CMR.LeerId(IdCMR) Then


                'DatosEmpresa
                Dim DatosEmpresa As New DatosEmpresa()
                DatosEmpresa.ObtenerDatosEmpresa()


                'DatosCliente
                Dim Cliente As New E_Clientes(Idusuario, cn)
                If Cliente.LeerId(CMR.CMR_Idcliente.Valor) Then


                    Dim Campa As Integer = VaInt(CMR.CMR_Campa.Valor)
                    Dim idCentro As Integer = VaInt(CMR.CMR_Idcentro.Valor)
                    Dim Albaran As Integer = VaInt(CMR.CMR_Albaran.Valor)

                    'Datos Albaran
                    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
                    If AlbSalida.LeerAlb(Campa, idCentro, Albaran) > 0 Then


                        'Meollo
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


                        Dim miCMR As New miFactura()
                        Dim err As New Errores



                        If IO.File.Exists(Application.StartupPath & "\Fondo_CMR_nacional.jpg") Then
                            Dim imagen As System.Drawing.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\Fondo_CMR_nacional.jpg")
                            Informe.Contenedor.PrintingSystem.Watermark.Image = imagen
                            Informe.Contenedor.PrintingSystem.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Zoom
                        End If


                        'Origen/Destino
                        ImprimeOrigenDestino(miCMR, CMR)

                        'Datos Cargador
                        ImprimeDatosCargador(miCMR, Cliente, CMR, 44, True, DatosEmpresa)

                        'Transportista
                        ImprimeTransportista(miCMR, AlbSalida)

                        'Lugar de origen
                        ImprimeLugarDeOrigen(miCMR, DatosEmpresa)

                        'Lucar de destino
                        ImprimeLugarDeDestino(miCMR, Cliente, CMR)

                        'Datos Destinatario
                        ImprimeDatosCargador(miCMR, Cliente, CMR, 235, False, DatosEmpresa)

                        'Detalle mercancía
                        ImprimeDetalleMercancia(miCMR, CMR)

                        'Fecha envío
                        ImprimeFechaEnvio(miCMR)

                        'Matriculas
                        ImprimeMatriculas(miCMR, AlbSalida)


                        'Firma expedidor
                        ImprimeFirmaExpedidor(miCMR)



                        'Añadimos el documento al informe
                        Informe.AñadeDetalles(miCMR)


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
                                If rutaPDF.Trim <> "" Then
                                    Informe.Contenedor.CreateDocument()
                                    Try
                                        Dim options As New DevExpress.XtraPrinting.PdfExportOptions
                                        options.Compressed = True
                                        Informe.Contenedor.ExportToPdf(rutaPDF, options)

                                    Catch ex As Exception
                                        err.Muestraerror("Error al exportar el documento con id" & IdCMR & " a PDF", "ImprimirDCTMC", ex.Message)
                                    End Try

                                Else
                                    Informe.ImpresionDirecta()
                                End If

                            Case Else
                                Informe.ImpresionDirecta()
                        End Select



                        Informe.Dispose()

                    Else
                        XtraMessageBox.Show("Imposible leer el albarán del CMR", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Else
                    XtraMessageBox.Show("No se encontró el cliente Id " & VaInt(CMR.CMR_Idcliente.Valor).ToString, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

                Else
                    XtraMessageBox.Show("No se pudo leer el DCTMC con Id " & IdCMR, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Else
                XtraMessageBox.Show("No hay datos que imprimir para el CMR", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

    End Sub


    Private Sub ImprimeOrigenDestino(ByRef miCMR As miFactura, CMR As E_Cmr)

        Dim OD As String = (CMR.CMR_OD.Valor & "").Trim.ToUpper
        Dim textoOD As String = ""

        If OD = "O" Then
            textoOD = "ORIGEN"
        ElseIf OD = "D" Then
            textoOD = "DESTINO"
        End If

        If textoOD <> "" Then
            miCMR.Titulo(textoOD, 135, 4, 50, 6, milinea.stilos.GrandeBold)
        End If


    End Sub



    Private Sub ImprimeDatosCargador(ByRef miCMR As miFactura, Cliente As E_Clientes, CMR As E_Cmr, altura As Integer,
                                     bPrimero As Boolean, DatosEmpresa As DatosEmpresa)

        Dim Pais As String = ""
        Dim Nombre As String = ""
        Dim NIF As String = ""
        Dim Domicilio As String = ""
        Dim CPostal As String = ""
        Dim Poblacion As String = ""
        Dim Provincia As String = ""


        Dim OD As String = (CMR.CMR_OD.Valor & "").Trim.ToUpper

        If OD = "O" And bPrimero Then

            Nombre = DatosEmpresa.NombreEmpresa.Trim
            NIF = DatosEmpresa.NIF
            Domicilio = DatosEmpresa.Domicilio.Trim
            CPostal = DatosEmpresa.CPostal.Trim
            Poblacion = DatosEmpresa.Poblacion.Trim
            Provincia = DatosEmpresa.Provincia.Trim
            Pais = "ESPAÑA"

        Else

            Dim Paises As New E_Paises(Idusuario, CnComun)
            If Paises.LeerId(Cliente.CLI_IdPais.Valor) Then Pais = (Paises.Nombre.Valor & "").Trim

            Nombre = (Cliente.CLI_Nombre.Valor & "").Trim
            NIF = (Cliente.CLI_Nif.Valor & "").Trim
            Domicilio = (Cliente.CLI_Domicilio.Valor & "").Trim
            CPostal = (Cliente.CLI_CPostal.Valor & "").Trim
            Poblacion = (Cliente.CLI_Poblacion.Valor & "").Trim
            Provincia = (Cliente.CLI_Provincia.Valor & "").Trim

            Dim DomDescarga As Integer = VaInt(CMR.CMR_Iddestino.Valor)
            If DomDescarga > 0 Then
                Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
                If ClientesDescargas.LeerId(DomDescarga) Then

                    Domicilio = (ClientesDescargas.CLD_Domicilio.Valor & "").Trim
                    CPostal = (ClientesDescargas.CLD_CPostal.Valor & "").Trim
                    Poblacion = (ClientesDescargas.CLD_Poblacion.Valor & "").Trim
                    Provincia = (ClientesDescargas.CLD_Provincia.Valor & "").Trim

                    If Paises.LeerId(ClientesDescargas.CLD_IdPais.Valor) Then
                        Pais = (Paises.Nombre.Valor & "").Trim
                    End If

                End If
            End If

        End If



        miCMR.Titulo(Nombre, 70, altura, 125, 4, milinea.stilos.Normal)                           'Nombre
        miCMR.Titulo(NIF, 35, altura + 4, 160, 4, milinea.stilos.Normal)                          'NIF
        miCMR.Titulo(Domicilio, 35, altura + 8, 160, 4, milinea.stilos.Normal)                    'Domicilio
        miCMR.Titulo(CPostal & " - " & Poblacion, 35, altura + 12, 160, 4, milinea.stilos.Normal)  'CPostal - Poblacion
        miCMR.Titulo(Provincia & " - " & Pais, 35, altura + 16, 160, 4, milinea.stilos.Normal)     'Provincia - Pais

    End Sub


    Private Sub ImprimeTransportista(miCMR As miFactura, AlbSalida As E_AlbSalida)

        Dim Acreedores As New E_Acreedores(Idusuario, cn)
        If Acreedores.LeerId(AlbSalida.ASA_idtransportista.Valor) Then

            Dim NIF As String = Acreedores.ACR_Nif.Valor
            Dim Nombre As String = Acreedores.ACR_Nombre.Valor

            miCMR.Titulo(NIF, 25, 96.5, 100, 4, milinea.stilos.Normal)
            miCMR.Titulo(Nombre, 65, 92.5, 135, 4, milinea.stilos.Normal)

        Else
            XtraMessageBox.Show("No se encontró el transportista Id: " & AlbSalida.ASA_idtransportista.Valor, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub


    Private Sub ImprimeLugarDeOrigen(ByRef miCMR As miFactura, DatosEmpresa As DatosEmpresa)

        miCMR.Titulo(DatosEmpresa.Poblacion & ", " & DatosEmpresa.CPostal & " - " & DatosEmpresa.Provincia, 20, 124, 80, 4, milinea.stilos.Reducida)

    End Sub


    Private Sub ImprimeLugarDeDestino(ByRef miCMR As miFactura, Cliente As E_Clientes, CMR As E_Cmr)

        Dim Poblacion As String = (Cliente.CLI_Poblacion.Valor & "").Trim
        Dim Provincia As String = (Cliente.CLI_Provincia.Valor & "").Trim
        Dim Pais As String = ""
        Dim Paises As New E_Paises(Idusuario, CnComun)

        Dim IdPais As String = Cliente.CLI_IdPais.Valor
        If VaInt(CMR.CMR_Iddestino.Valor) > 0 Then
            Dim ClientesDescargas As New E_ClientesDescargas(IdPais, cn)
            If ClientesDescargas.LeerId(CMR.CMR_Iddestino.Valor) Then

                Poblacion = (ClientesDescargas.CLD_Poblacion.Valor & "").Trim
                Provincia = (ClientesDescargas.CLD_Provincia.Valor & "").Trim
                IdPais = ClientesDescargas.CLD_IdPais.Valor

            End If
        End If


        If Paises.LeerId(IdPais) Then
            Pais = (Paises.Nombre.Valor & "").Trim
        End If

        miCMR.Titulo(Poblacion & ", " & provincia & " - " & Pais, 110, 124, 80, 4, milinea.stilos.Reducida)

    End Sub


    Private Sub ImprimeDetalleMercancia(ByRef miCMR As miFactura, CMR As E_Cmr)


        Dim IdCMR As String = VaInt(CMR.CMR_IdCmr.Valor)


        If IdCMR > 0 Then

            Dim CMR_Lineas As New E_Cmr_lineas(Idusuario, cn)
            Dim Familias As New E_FamiliasGeneros(Idusuario, cn)
            Dim Envases As New E_Envases(Idusuario, cn)
            Dim Marcas As New E_Marcas(Idusuario, cn)


            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(CMR_Lineas.CML_IdCmrlin, "IdLinea")
            CONSULTA.SelCampo(CMR_Lineas.CML_bultos, "Bultos")
            CONSULTA.SelCampo(CMR_Lineas.CML_knetos, "Kilos")
            CONSULTA.SelCampo(Familias.FAG_nombre, "Genero", CMR_Lineas.CML_Idfamilia, Familias.FAG_idfamilia)
            CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", CMR_Lineas.CML_idmarca, Marcas.MAR_Idmarca)
            CONSULTA.SelCampo(CMR_Lineas.CML_envase, "Envase")
            CONSULTA.WheCampo(CMR_Lineas.CML_Idcmr, "=", IdCMR)
            Dim sql As String = CONSULTA.SQL
            sql = sql + " ORDER BY IdLinea"


            Dim altura As Integer = 143
            Dim dt As DataTable = CMR.MiConexion.ConsultaSQL(sql)


            Dim TotalBultos As Decimal = 0
            Dim TotalKilos As Decimal = 0

            'Máx. 14 líneas (no cabe más)
            For indice As Integer = 0 To dt.Rows.Count - 1

                Dim row As DataRow = dt.Rows(indice)
                If Not IsNothing(row) And indice <= 13 Then

                    Dim bultos As Decimal = VaDec(row("Bultos"))
                    Dim kilos As Decimal = VaDec(row("Kilos"))

                    'miCMR.Titulo(row("Genero").ToString, 45, altura, 20, 3, milinea.stilos.Minima)
                    miCMR.Titulo(row("Genero").ToString, 45, altura, 18, 3, milinea.stilos.Minima)
                    miCMR.Titulo(row("Marca").ToString, 64, altura, 21, 3, milinea.stilos.Minima)
                    miCMR.Titulo(row("Envase").ToString, 86, altura, 30, 3, milinea.stilos.Minima)
                    miCMR.Titulo(bultos.ToString("0"), 116, altura, 15, 3, milinea.stilos.Minima, ">")
                    miCMR.Titulo(kilos.ToString("#,##0"), 172, altura, 22, 3, milinea.stilos.Minima, ">")

                    TotalBultos = TotalBultos + bultos
                    TotalKilos = TotalKilos + kilos

                    altura = altura + 3

                End If

            Next

            miCMR.Titulo("------------", 116, altura, 15, 3, milinea.stilos.Minima, ">")
            miCMR.Titulo("------------", 172, altura, 22, 3, milinea.stilos.Minima, ">")
            altura = altura + 3
            miCMR.Titulo(TotalBultos.ToString("#,##0"), 116, altura, 15, 3, milinea.stilos.Minima, ">")
            miCMR.Titulo(TotalKilos.ToString("#,##0"), 172, altura, 22, 3, milinea.stilos.Minima, ">")


            Dim Albaran As String = "Alb nº: " & VaInt(CMR.CMR_Albaran.Valor).ToString("000000")
            miCMR.Titulo(Albaran, 15, 173, 40, 4, milinea.stilos.Normal)


        End If

    End Sub


    Private Sub ImprimeFechaEnvio(ByRef miCMR As miFactura)

        'TODO: Esto es now o viene de la factura? Se guarda la hora en algún sitio?
        Dim Fecha As String = Now.ToString("dd/MM/yyyy")
        Dim Hora As String = Now.ToString("HH:mm")

        miCMR.Titulo(Fecha, 70, 182, 20, 4, milinea.stilos.Normal)
        miCMR.Titulo(Hora, 91, 182, 20, 4, milinea.stilos.Normal)

    End Sub

    Private Sub ImprimeMatriculas(ByRef miCMR As miFactura, AlbSalida As E_AlbSalida)

        Dim camion As String = AlbSalida.ASA_matriculacamion.Valor
        Dim remolque As String = AlbSalida.ASA_matricularemolque.Valor

        miCMR.Titulo(camion, 45, 199, 25, 4, milinea.stilos.Normal)
        miCMR.Titulo(remolque, 127, 199, 25, 4, milinea.stilos.Normal)


    End Sub


    Private Sub ImprimeFirmaExpedidor(ByRef miCMR As miFactura)

        miCMR.Titulo("Firma del expedidor,", 40, 259, 60, 4, milinea.stilos.Normal)

    End Sub




End Module
