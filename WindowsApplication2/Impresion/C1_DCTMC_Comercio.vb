Imports System.Drawing
Imports DevExpress.XtraEditors



Module C1_DCTMC_Comercio

    Private Class stClave_Traspaso
        Public IdGenero As Integer = 0
        Public Genero As String = ""

        Public Sub New(IdGenero As Integer, Genero As String)
            Me.IdGenero = IdGenero
            Me.Genero = Genero
        End Sub

    End Class

    Private Class stDatos_Traspaso
        Public Kilos As Decimal

        Public Sub New(Kilos As Decimal)
            Me.Kilos = Kilos
        End Sub

    End Class


    Public Enum TipoDCTMC
        CMR
        Traspasos
        ValeEnvasesTraspasos
        ValeEnvases
    End Enum


    Public Sub C1_ImprimirDCTMC(Id As String, Tipo As TipoDCTMC, TipoImpresion As TipoImpresion,
                                          Optional Impresora As String = "",
                                          Optional rutaPDF As String = "",
                                          Optional archivoPDF As String = "")


        If VaInt(Id) > 0 Then


            Dim IdCliente As String = ""


            Dim CMR As E_Cmr = Nothing
            Dim TraspasosCentros As E_TraspasosCentros = Nothing
            Dim ValeEnvases_Traspaso As E_ValeEnvases_Traspaso = Nothing
            Dim ValeEnvases As E_ValeEnvases = Nothing
            Dim Cliente As E_Clientes = Nothing
            Dim AlbSalida As E_AlbSalida = Nothing




            Select Case Tipo

                Case TipoDCTMC.CMR

                    CMR = New E_Cmr(Idusuario, cn)
                    If Not CMR.LeerId(Id) Then
                        MsgBox("No se puede leer el CMR con Id: " & Id)
                        Exit Sub
                    End If

                    Cliente = New E_Clientes(Idusuario, cn)
                    If Not Cliente.LeerId(CMR.CMR_Idcliente.Valor) Then
                        MsgBox("No se puede leer el cliente con Id: " & CMR.CMR_Idcliente.Valor)
                        Exit Sub
                    End If

                    Dim Campa As Integer = VaInt(CMR.CMR_Campa.Valor)
                    Dim IdCentro As Integer = VaInt(CMR.CMR_Idcentro.Valor)
                    Dim Albaran As Integer = VaInt(CMR.CMR_Albaran.Valor)

                    AlbSalida = New E_AlbSalida(Idusuario, cn)
                    If Not AlbSalida.LeerAlb(Campa, IdCentro, Albaran) > 0 Then
                        MsgBox("No se puede leer el albarán del CMR")
                        Exit Sub
                    End If

                Case TipoDCTMC.Traspasos

                    TraspasosCentros = New E_TraspasosCentros(Idusuario, cn)
                    If Not TraspasosCentros.LeerId(Id) Then
                        MsgBox("No se puede leer el Traspaso con Id: " & Id)
                        Exit Sub
                    End If


                Case TipoDCTMC.ValeEnvasesTraspasos

                    ValeEnvases_Traspaso = New E_ValeEnvases_Traspaso(Idusuario, cn)
                    If Not ValeEnvases_Traspaso.LeerId(Id) Then
                        MsgBox("No se puede leer el Vale de Traspaso con Id: " & Id)
                        Exit Sub
                    End If

                Case TipoDCTMC.ValeEnvases

                    ValeEnvases = New E_ValeEnvases(Idusuario, cn)
                    If Not ValeEnvases.LeerId(Id) Then
                        MsgBox("No se puede leer el Vale de Envases con Id: " & Id)
                        Exit Sub
                    End If

                Case Else
                    MsgBox("No se ha pasado el tipo para el impresión del DCTMC")
                    Exit Sub

            End Select



            'DatosEmpresa
            Dim DatosEmpresa As New DatosEmpresa()
            DatosEmpresa.ObtenerDatosEmpresa()



            'Meollo
            Dim Impreso As New Impreso
            Impreso.f.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
            Impreso.f.Documento.PageLayout.PageSettings.Landscape = False
            Impreso.f.Documento.PageLayout.PageSettings.TopMargin = "0mm"
            Impreso.f.Documento.PageLayout.PageSettings.BottomMargin = "0mm"
            Impreso.f.Documento.PageLayout.PageSettings.LeftMargin = "0mm"
            Impreso.f.documento.PageLayout.PageSettings.RightMargin = "0mm"


            Try

                If IO.File.Exists(Application.StartupPath & "\Fondo_CMR_nacional.png") Then

                    Dim imagen As New C1.C1Preview.RenderImage
                    imagen.Image = Image.FromFile(Application.StartupPath & "\Fondo_CMR_nacional.png")
                    Impreso.f.documento.PageLayout.Watermark = imagen

                End If

            Catch ex As Exception
            End Try



            Impreso.EstableceImpreso(TipoImpresion)


            Try

                'Meollo
                Select Case Tipo
                    Case TipoDCTMC.CMR
                        ImprimeDCTMC_CMR(Impreso, DatosEmpresa, CMR, Cliente, AlbSalida)
                    Case TipoDCTMC.Traspasos
                        ImprimeDCTMC_Traspaso(Impreso, DatosEmpresa, TraspasosCentros)
                    Case TipoDCTMC.ValeEnvasesTraspasos
                        ImprimeDCTMC_ValeTraspaso(Impreso, DatosEmpresa, ValeEnvases_Traspaso)
                    Case TipoDCTMC.ValeEnvases
                        ImprimeDCTMC_Vale(Impreso, DatosEmpresa, ValeEnvases)
                End Select



                'Impresión / previsualización / exportación
                Select Case TipoImpresion

                    Case NetAgro.TipoImpresion.ImpresoraPorDefecto

                        Dim valoresusuario As New E_valoresusuario(Idusuario, cn)
                        If valoresusuario.LeerId(Idusuario) = True Then
                            Impresora = valoresusuario.VUS_ImpresoraCMRNacional.Valor
                            Impreso.Imprimir(NetAgro.TipoImpresion.ImpresoraSeleccionada, Impresora, rutaPDF, archivoPDF)
                        Else
                            Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)
                        End If


                    Case Else
                        Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)

                End Select

            Catch ex As Exception

            End Try


        Else
            XtraMessageBox.Show("No hay datos que imprimir", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub


#Region "Vale envases"


    Private Sub ImprimeDCTMC_Vale(ByRef Impreso As Impreso, DatosEmpresa As DatosEmpresa, ValeEnvases As E_ValeEnvases)

        'Datos Cargador
        ImprimeDatosCargador_Interno(Impreso, 44, DatosEmpresa)

        'Transportista
        ImprimeTransportista_Vale(Impreso, ValeEnvases)

        'Lugar de origen
        ImprimeLugarDeOrigen_Vale(Impreso, DatosEmpresa)

        'Lucar de destino
        ImprimeLugarDeDestino_Vale(Impreso, ValeEnvases)

        'Datos Destinatario
        ImprimeDatosDestinatario_Vale(Impreso, 235, ValeEnvases)

        'Detalle mercancía
        ImprimeDetalleMercancia_Vale(Impreso, ValeEnvases)

        'Fecha envío
        ImprimeFechaEnvio(Impreso)

        'Matriculas
        ImprimeMatriculas_Vale(Impreso, ValeEnvases)

        'Firma expedidor
        ImprimeFirmaExpedidor(Impreso)


    End Sub



    Private Sub ImprimeTransportista_Vale(ByRef Impreso As Impreso, ValeEnvases As E_ValeEnvases)

        Dim Acreedores As New E_Acreedores(Idusuario, cn)
        If Acreedores.LeerId(ValeEnvases.VEV_IdTransportista.Valor) Then

            Dim NIF As String = Acreedores.ACR_Nif.Valor
            Dim Nombre As String = Acreedores.ACR_Nombre.Valor

            Impreso.Detalle.Titulo(NIF, 25, 96.5, 100, 4, Estilos.Normal)
            Impreso.Detalle.Titulo(Nombre, 65, 92.5, 135, 4, Estilos.Normal)

        Else
            XtraMessageBox.Show("No se encontró el transportista Id: " & ValeEnvases.VEV_IdTransportista.Valor, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub


    Private Sub ImprimeLugarDeOrigen_Vale(ByRef Impreso As Impreso, DatosEmpresa As DatosEmpresa)

        Impreso.Detalle.Titulo(DatosEmpresa.Poblacion & ", " & DatosEmpresa.CPostal & " - " & DatosEmpresa.Provincia, 20, 124, 80, 4, Estilos.Reducida)

    End Sub


    Private Sub ImprimeLugarDeDestino_Vale(ByRef Impreso As Impreso, ValeEnvases As E_ValeEnvases)

        Dim Poblacion As String = ""
        Dim CPostal As String = ""
        Dim provincia As String = ""


        Dim Codigo As String = (ValeEnvases.VEV_Codigo.Valor & "").Trim
        Dim TipoSujeto As String = (ValeEnvases.VEV_TipoSujeto.Valor & "").Trim


        If VaInt(Codigo) > 0 Then

            Select Case TipoSujeto

                Case "A"
                    'Agricultor
                    Dim Agricultores As New E_Agricultores(Idusuario, cn)
                    If Agricultores.LeerId(Codigo) Then
                        Poblacion = Agricultores.AGR_Poblacion.Valor
                        CPostal = Agricultores.AGR_Cpostal.Valor
                        provincia = Agricultores.AGR_Provincia.Valor
                    End If

                Case "C"
                    'Cliente
                    Dim Clientes As New E_Clientes(Idusuario, cn)
                    If Clientes.LeerId(Codigo) Then
                        Poblacion = Clientes.CLI_Poblacion.Valor
                        CPostal = Clientes.CLI_CPostal.Valor
                        provincia = Clientes.CLI_Provincia.Valor
                    End If

                Case "R"
                    'Acreedor
                    Dim Acreedor As New E_Acreedores(Idusuario, cn)
                    If Acreedor.LeerId(Codigo) Then
                        Poblacion = Acreedor.ACR_Poblacion.Valor
                        CPostal = Acreedor.ACR_CPostal.Valor
                        provincia = Acreedor.ACR_Provincia.Valor
                    End If

            End Select

        End If


        Impreso.Detalle.Titulo(Poblacion & ", " & CPostal & " - " & provincia, 110, 124, 80, 4, Estilos.Reducida)

    End Sub


    Private Sub ImprimeDatosDestinatario_Vale(ByRef Impreso As Impreso, altura As Integer, ValeEnvases As E_ValeEnvases)

        Dim NombreEmpresa As String = ""
        Dim NIF As String = ""
        Dim Domicilio As String = ""
        Dim CPostal As String = ""
        Dim Poblacion As String = ""
        Dim Provincia As String = ""
        Dim IdPais As String = ""
        Dim Pais As String = ""


        Dim Codigo As String = (ValeEnvases.VEV_Codigo.Valor & "").Trim
        Dim TipoSujeto As String = (ValeEnvases.VEV_TipoSujeto.Valor & "").Trim


        If VaInt(Codigo) > 0 Then

            Select Case TipoSujeto

                Case "A"
                    'Agricultor
                    Dim Agricultores As New E_Agricultores(Idusuario, cn)
                    If Agricultores.LeerId(Codigo) Then
                        NombreEmpresa = Agricultores.AGR_Nombre.Valor
                        NIF = Agricultores.AGR_Nif.Valor
                        Domicilio = Agricultores.AGR_Domicilio.Valor
                        Poblacion = Agricultores.AGR_Poblacion.Valor
                        CPostal = Agricultores.AGR_Cpostal.Valor
                        Provincia = Agricultores.AGR_Provincia.Valor
                        IdPais = Agricultores.AGR_IdPais.Valor
                    End If

                Case "C"
                    'Cliente
                    Dim Clientes As New E_Clientes(Idusuario, cn)
                    If Clientes.LeerId(Codigo) Then
                        NombreEmpresa = Clientes.CLI_Nombre.Valor
                        NIF = Clientes.CLI_Nif.Valor
                        Domicilio = Clientes.CLI_Domicilio.Valor
                        Poblacion = Clientes.CLI_Poblacion.Valor
                        CPostal = Clientes.CLI_CPostal.Valor
                        Provincia = Clientes.CLI_Provincia.Valor
                        IdPais = Clientes.CLI_IdPais.Valor
                    End If

                Case "R"
                    'Acreedor
                    Dim Acreedor As New E_Acreedores(Idusuario, cn)
                    If Acreedor.LeerId(Codigo) Then
                        NombreEmpresa = Acreedor.ACR_Nombre.Valor
                        NIF = Acreedor.ACR_Nif.Valor
                        Poblacion = Acreedor.ACR_Poblacion.Valor
                        Domicilio = Acreedor.ACR_Domicilio.Valor
                        CPostal = Acreedor.ACR_CPostal.Valor
                        Provincia = Acreedor.ACR_Provincia.Valor
                        IdPais = 1
                    End If

            End Select

        End If


        Dim Paises As New E_Paises(Idusuario, CnComun)
        If Paises.LeerId(IdPais) Then
            Pais = Paises.Nombre.Valor
        End If


        Impreso.Detalle.Titulo(NombreEmpresa, 70, altura, 125, 4, Estilos.Normal)                           'Nombre
        Impreso.Detalle.Titulo(NIF, 35, altura + 4, 160, 4, Estilos.Normal)                          'NIF
        Impreso.Detalle.Titulo(Domicilio, 35, altura + 8, 160, 4, Estilos.Normal)                    'Domicilio
        Impreso.Detalle.Titulo(CPostal & " - " & Poblacion, 35, altura + 12, 160, 4, Estilos.Normal)  'CPostal - Poblacion
        Impreso.Detalle.Titulo(Provincia & " - " & Pais, 35, altura + 16, 160, 4, Estilos.Normal)     'Provincia - Pais

    End Sub


    Private Sub ImprimeDetalleMercancia_Vale(ByRef Impreso As Impreso, ValeEnvases As E_ValeEnvases)


        Dim IdVale As String = VaInt(ValeEnvases.VEV_Idvale.Valor)


        If IdVale > 0 Then

            Dim ValeEnvase_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
            Dim Envases As New E_Envases(Idusuario, cn)
            Dim Marcas As New E_Marcas(Idusuario, cn)


            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(ValeEnvase_Lineas.VEL_Id, "IdLinea")
            CONSULTA.SelCampo(ValeEnvase_Lineas.VEL_retira, "Retira")
            CONSULTA.SelCampo(Envases.ENV_Nombre, "Envase", ValeEnvase_Lineas.VEL_idenvase, Envases.ENV_IdEnvase)
            CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", ValeEnvase_Lineas.VEL_idmarca, Marcas.MAR_Idmarca)
            Dim oPeso As New Cdatos.bdcampo("@COALESCE(VEL_Retira,0) * COALESCE(ENV_TaraSalida,0)", Cdatos.TiposCampo.Importe, 18, 2)
            CONSULTA.SelCampo(oPeso, "Peso")
            CONSULTA.WheCampo(ValeEnvase_Lineas.VEL_idvale, "=", IdVale)
            CONSULTA.WheCampo(ValeEnvase_Lineas.VEL_retira, ">", "0")
            Dim sql As String = CONSULTA.SQL
            sql = sql + " ORDER BY IdLinea"


            Dim dt As DataTable = ValeEnvase_Lineas.MiConexion.ConsultaSQL(sql)



            Dim TotalUds As Decimal = 0
            Dim TotalPeso As Decimal = 0

            Dim altura As Integer = 143
            Impreso.Detalle.Titulo("RETIRA", 116, altura, 22, 3, Estilos.Minima, ">")
            altura = altura + 3
            Impreso.Detalle.Titulo("------", 116, altura, 22, 3, Estilos.Minima, ">")
            altura = altura + 3


            'Máx. 12 líneas (no cabe más)
            For indice As Integer = 0 To dt.Rows.Count - 1

                Dim row As DataRow = dt.Rows(indice)
                If Not IsNothing(row) And indice <= 13 Then

                    Dim Cantidad As Decimal = VaDec(row("Retira"))
                    Dim Peso As Decimal = VaDec(row("Peso"))

                    Impreso.Detalle.Titulo(row("Envase").ToString, 45, altura, 45, 3, Estilos.Minima)
                    Impreso.Detalle.Titulo(row("Marca").ToString, 95, altura, 21, 3, Estilos.Minima)
                    Impreso.Detalle.Titulo(Cantidad.ToString("#,##0.00"), 116, altura, 22, 3, Estilos.Minima, ">")

                    TotalUds = TotalUds + Cantidad
                    TotalPeso = TotalPeso + Peso

                    altura = altura + 3

                End If


                Application.DoEvents()

            Next

            Impreso.Cabecera.Titulo(TotalPeso.ToString("#,##0") & " Kg", 145, altura + 5, 40, 5, Estilos.Normal, "=")

            Impreso.Detalle.Titulo("------------", 116, altura, 22, 3, Estilos.Minima, ">")
            altura = altura + 3
            Impreso.Detalle.Titulo(TotalUds.ToString("#,##0.00"), 116, altura, 22, 3, Estilos.Minima, ">")


            Dim vale As String = "Vale nº: " & VaInt(ValeEnvases.VEV_Numero.Valor).ToString("000000")
            Impreso.Detalle.Titulo(vale, 15, 173, 40, 4, Estilos.Normal)


        End If

    End Sub


    Private Sub ImprimeMatriculas_Vale(ByRef Impreso As Impreso, ValeEnvases As E_ValeEnvases)

        Dim remolque As String = ValeEnvases.VEV_Matricula.Valor
        Impreso.Detalle.Titulo(remolque, 127, 199, 25, 4, Estilos.Normal)

        Dim tractora As String = ValeEnvases.VEV_Tractora.Valor
        Impreso.Detalle.Titulo(tractora, 47, 199, 25, 4, Estilos.Normal)

    End Sub


#End Region


#Region "Traspasos"


    Private Sub ImprimeDCTMC_Traspaso(ByRef Impreso As Impreso, DatosEmpresa As DatosEmpresa, TraspasoCentros As E_TraspasosCentros)

        'Datos Cargador
        ImprimeDatosCargador_Interno(Impreso, 44, DatosEmpresa)

        'Transportista
        ImprimeTransportista_Traspaso(Impreso, TraspasoCentros)

        'Lugar de origen
        ImprimeLugarDeOrigen_Traspaso(Impreso, TraspasoCentros)

        'Lucar de destino
        ImprimeLugarDeDestino_Traspaso(Impreso, TraspasoCentros)

        'Datos Destinatario
        ImprimeDatosCargador_Interno(Impreso, 235, DatosEmpresa)

        'Detalle mercancía
        ImprimeDetalleMercancia_Traspaso(Impreso, TraspasoCentros)

        'Fecha envío
        ImprimeFechaEnvio_Traspaso(Impreso, TraspasoCentros)

        'Matriculas
        ImprimeMatriculas_Traspaso(Impreso, TraspasoCentros)

        'Firma expedidor
        ImprimeFirmaExpedidor(Impreso)



    End Sub



    Private Sub ImprimeTransportista_Traspaso(ByRef Impreso As Impreso, TraspasoCentros As E_TraspasosCentros)

        Dim Acreedores As New E_Acreedores(Idusuario, cn)
        If Acreedores.LeerId(TraspasoCentros.TCE_IdTransportista.Valor) Then

            Dim NIF As String = Acreedores.ACR_Nif.Valor
            Dim Nombre As String = Acreedores.ACR_Nombre.Valor

            Impreso.Detalle.Titulo(NIF, 25, 96.5, 100, 4, Estilos.Normal)
            Impreso.Detalle.Titulo(Nombre, 65, 92.5, 135, 4, Estilos.Normal)

        Else
            XtraMessageBox.Show("No se encontró el transportista Id: " & TraspasoCentros.TCE_IdTransportista.Valor, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub


    Private Sub ImprimeLugarDeOrigen_Traspaso(ByRef Impreso As Impreso, TraspasoCentros As E_TraspasosCentros)

        Dim Poblacion As String = ""
        Dim CPostal As String = ""
        Dim provincia As String = ""

        Dim ValoresPVenta As New E_valorespventa(Idusuario, cn)
        If ValoresPVenta.LeerId(TraspasoCentros.TCE_IdCentroOrigen.Valor) Then
            Poblacion = ValoresPVenta.VPV_PoblacionFacturacion.Valor
            CPostal = ValoresPVenta.VPV_CPostalFacturacion.Valor
            provincia = ValoresPVenta.VPV_ProvinciaFacturacion.Valor
        End If

        Impreso.Detalle.Titulo(Poblacion & ", " & CPostal & " - " & provincia, 20, 124, 80, 4, Estilos.Reducida)

    End Sub


    Private Sub ImprimeLugarDeDestino_Traspaso(ByRef Impreso As Impreso, TraspasoCentros As E_TraspasosCentros)

        Dim Poblacion As String = ""
        Dim CPostal As String = ""
        Dim provincia As String = ""

        Dim ValoresPVenta As New E_valorespventa(Idusuario, cn)
        If ValoresPVenta.LeerId(TraspasoCentros.TCE_IdCentroDestino.Valor) Then
            Poblacion = ValoresPVenta.VPV_PoblacionFacturacion.Valor
            CPostal = ValoresPVenta.VPV_CPostalFacturacion.Valor
            provincia = ValoresPVenta.VPV_ProvinciaFacturacion.Valor
        End If

        Impreso.Detalle.Titulo(Poblacion & ", " & CPostal & " - " & provincia, 110, 124, 80, 4, Estilos.Reducida)

    End Sub


    Private Sub ImprimeDetalleMercancia_Traspaso(ByRef Impreso As Impreso, TraspasoCentros As E_TraspasosCentros)


        Dim IdTraspaso As String = VaInt(TraspasoCentros.TCE_IdTrapaso.Valor)


        If IdTraspaso > 0 Then

            Dim TraspasoCentros_Lineas As New E_TraspasosCentros_Lineas(Idusuario, cn)
            Dim Envases As New E_Envases(Idusuario, cn)
            Dim Marcas As New E_Marcas(Idusuario, cn)


            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(TraspasoCentros_Lineas.TLI_Tipo, "Tipo")
            CONSULTA.SelCampo(TraspasoCentros_Lineas.TLI_Codigo, "Codigo")
            CONSULTA.WheCampo(TraspasoCentros_Lineas.TLI_IdTraspaso, "=", IdTraspaso)
            Dim sql As String = CONSULTA.SQL
            sql = sql + " ORDER BY TLI_IdLinea"


            Dim acum As New Acumulador


            Dim dt As DataTable = TraspasoCentros.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                For Each row As DataRow In dt.Rows

                    Dim Tipo As String = (row("Tipo").ToString & "").Trim
                    Dim Codigo As String = (row("Codigo").ToString & "").Trim

                    If VaInt(Codigo) > 0 Then

                        Select Case Tipo.ToUpper.Trim

                            Case "P"
                                'Partida
                                Dim sql2 As String = "SELECT AEL_IdGenero as IdGenero, GEN_NombreGenero as Genero, AEL_KilosBrutos as Kilos FROM AlbEntrada_Lineas LEFT JOIN Generos ON GEN_IdGenero = AEL_IdGenero WHERE AEL_IdLinea = " & Codigo
                                Dim dtc As DataTable = TraspasoCentros.MiConexion.ConsultaSQL(sql2)
                                If Not IsNothing(dtc) Then

                                    Dim IdGenero As Integer = VaInt(dtc.Rows(0)("IdGenero"))
                                    Dim Genero As String = (dtc.Rows(0)("Genero").ToString & "").Trim
                                    Dim Kilos As Decimal = VaDec(dtc.Rows(0)("Kilos"))

                                    Dim stClave As New stClave_Traspaso(IdGenero, Genero)
                                    Dim stDatos As New stDatos_Traspaso(Kilos)
                                    acum.Suma(stClave, stDatos)

                                End If

                            Case "L"
                                'Lote
                                Dim sql2 As String = "SELECT LTE_IdGenero as IdGenero, GEN_NombreGenero as Genero, SUM(LTL_Kilos) as Kilos FROM Lotes_Lineas LEFT JOIN Lotes ON LTE_IdLote = LTL_IdLote LEFT JOIN Generos ON GEN_IdGenero = LTE_IdGenero WHERE LTL_IdLote = " & Codigo
                                sql2 = sql2 & " GROUP BY LTE_IdGenero, GEN_NombreGenero"

                                Dim dtc As DataTable = TraspasoCentros.MiConexion.ConsultaSQL(sql2)
                                If Not IsNothing(dtc) Then
                                    For Each row2 As DataRow In dtc.Rows

                                        Dim IdGenero As Integer = VaInt(row2("IdGenero"))
                                        Dim Genero As String = (row2("Genero").ToString & "").Trim
                                        Dim Kilos As Decimal = VaDec(row2("Kilos"))

                                        Dim stClave As New stClave_Traspaso(IdGenero, Genero)
                                        Dim stDatos As New stDatos_Traspaso(Kilos)
                                        acum.Suma(stClave, stDatos)

                                        Application.DoEvents()

                                    Next
                                End If

                            Case "C"
                                'Precalibrado
                                Dim sql2 As String = "SELECT LPD_IdGenero as IdGenero, GEN_NombreGenero as Genero, SUM(LPL_Kilos) as Kilos FROM LotesProduccion_Lineas LEFT JOIN LotesProduccion ON LPD_IdLote = LPL_IdLote LEFT JOIN Generos ON GEN_IdGenero = LPD_IdGenero WHERE LPL_IdLote = " & Codigo
                                sql2 = sql2 & " GROUP BY LPD_IdGenero, GEN_NombreGenero"

                                Dim dtc As DataTable = TraspasoCentros.MiConexion.ConsultaSQL(sql2)
                                If Not IsNothing(dtc) Then
                                    For Each row2 As DataRow In dtc.Rows

                                        Dim IdGenero As Integer = VaInt(row2("IdGenero"))
                                        Dim Genero As String = (row2("Genero").ToString & "").Trim
                                        Dim Kilos As Decimal = VaDec(row2("Kilos"))

                                        Dim stClave As New stClave_Traspaso(IdGenero, Genero)
                                        Dim stDatos As New stDatos_Traspaso(Kilos)
                                        acum.Suma(stClave, stDatos)

                                        Application.DoEvents()

                                    Next
                                End If

                            Case "T"
                                'Palet
                                Dim sql2 As String = "SELECT PLL_IdGenero as IdGenero, GEN_NombreGenero as Genero, SUM(PLL_KilosBrutos) as Kilos FROM Palets_Lineas LEFT JOIN Generos ON GEN_IdGenero = PLL_IdGenero WHERE PLL_IdPalet = " & Codigo
                                sql2 = sql2 & " GROUP BY PLL_IdGenero, GEN_NombreGenero"

                                Dim dtc As DataTable = TraspasoCentros.MiConexion.ConsultaSQL(sql2)
                                If Not IsNothing(dtc) Then
                                    For Each row2 As DataRow In dtc.Rows

                                        Dim IdGenero As Integer = VaInt(row2("IdGenero"))
                                        Dim Genero As String = (row2("Genero").ToString & "").Trim
                                        Dim Kilos As Decimal = VaDec(row2("Kilos"))

                                        Dim stClave As New stClave_Traspaso(IdGenero, Genero)
                                        Dim stDatos As New stDatos_Traspaso(Kilos)
                                        acum.Suma(stClave, stDatos)

                                        Application.DoEvents()

                                    Next
                                End If

                        End Select


                    End If


                    Application.DoEvents()

                Next
            End If


            Dim dtKilos As DataTable = acum.DataTable



            Dim altura As Integer = 143

            Dim TotalKilos As Decimal = 0

            'Máx. 14 líneas (no cabe más)
            For indice As Integer = 0 To dtKilos.Rows.Count - 1

                Dim row As DataRow = dtKilos.Rows(indice)
                If Not IsNothing(row) And indice <= 13 Then

                    Dim Genero As String = (row("Genero").ToString & "").Trim
                    Dim Kilos As Decimal = VaDec(row("Kilos"))

                    Impreso.Detalle.Titulo(row("Genero").ToString, 45, altura, 66, 3, Estilos.Minima)
                    Impreso.Detalle.Titulo(Kilos.ToString("#,##0"), 172, altura, 22, 3, Estilos.Minima, ">")

                    TotalKilos = TotalKilos + Kilos

                    altura = altura + 3

                End If


                Application.DoEvents()

            Next

            Impreso.Detalle.Titulo("------------", 172, altura, 22, 3, Estilos.Minima, ">")
            altura = altura + 3
            Impreso.Detalle.Titulo(TotalKilos.ToString("#,##0"), 172, altura, 22, 3, Estilos.Minima, ">")


            Dim vale As String = "Trasp. nº: " & VaInt(TraspasoCentros.TCE_Numero.Valor).ToString("000000")
            Impreso.Detalle.Titulo(vale, 15, 173, 40, 4, Estilos.Normal)

            Impreso.Detalle.Titulo("Origen: ESPAÑA", 118, 173, 30, 4, Estilos.Normal)


        End If

    End Sub


    Private Sub ImprimeFechaEnvio_Traspaso(ByRef Impreso As Impreso, TraspasoCentros As E_TraspasosCentros)

        Dim Fecha As String = ""
        If VaDate(TraspasoCentros.TCE_Fecha.Valor) <> VaDate("") Then Fecha = VaDate(TraspasoCentros.TCE_Fecha.Valor).ToString("dd/MM/yyyy")
        Dim Hora As String = Now.ToString("HH:mm")

        Impreso.Detalle.Titulo(Fecha, 70, 182, 20, 4, Estilos.Normal)
        Impreso.Detalle.Titulo(Hora, 91, 182, 20, 4, Estilos.Normal)

    End Sub


    Private Sub ImprimeMatriculas_Traspaso(ByRef Impreso As Impreso, TraspasoCentros As E_TraspasosCentros)

        Dim remolque As String = TraspasoCentros.TCE_Matricula.Valor
        Impreso.Detalle.Titulo(remolque, 127, 199, 25, 4, Estilos.Normal)

        Dim tractora As String = TraspasoCentros.TCE_Tractora.Valor
        Impreso.Detalle.Titulo(tractora, 47, 199, 25, 4, Estilos.Normal)


    End Sub


#End Region



#Region "Vales Envases Traspasos"

    Private Sub ImprimeDCTMC_ValeTraspaso(ByRef Impreso As Impreso, DatosEmpresa As DatosEmpresa, ValeEnvases_Traspaso As E_ValeEnvases_Traspaso)


        'Datos Cargador
        ImprimeDatosCargador_ValeTraspaso(Impreso, 44, ValeEnvases_Traspaso, DatosEmpresa)

        'Transportista
        ImprimeTransportista_ValeTraspaso(Impreso, ValeEnvases_Traspaso)

        'Lugar de origen
        ImprimeLugarDeOrigen_ValeTraspaso(Impreso, ValeEnvases_Traspaso)

        'Lucar de destino
        ImprimeLugarDeDestino_ValeTraspaso(Impreso, ValeEnvases_Traspaso)

        'Datos Destinatario
        ImprimeDatosDestinatario_ValeTraspaso(Impreso, 235, ValeEnvases_Traspaso, DatosEmpresa)

        'Detalle mercancía
        ImprimeDetalleMercancia_ValeTraspaso(Impreso, ValeEnvases_Traspaso)

        'Fecha envío
        ImprimeFechaEnvio_ValeTraspaso(Impreso, ValeEnvases_Traspaso)

        'Matriculas
        ImprimeMatriculas_ValeTraspaso(Impreso, ValeEnvases_Traspaso)

        'Firma expedidor
        ImprimeFirmaExpedidor(Impreso)

    End Sub


    Private Sub ImprimeDatosCargador_Interno(ByRef Impreso As Impreso, altura As Integer, DatosEmpresa As DatosEmpresa)

        Impreso.Detalle.Titulo(DatosEmpresa.NombreEmpresa, 70, altura, 125, 4, Estilos.Normal)                           'Nombre
        Impreso.Detalle.Titulo(DatosEmpresa.NIF, 35, altura + 4, 160, 4, Estilos.Normal)                          'NIF
        Impreso.Detalle.Titulo(DatosEmpresa.Domicilio, 35, altura + 8, 160, 4, Estilos.Normal)                    'Domicilio
        Impreso.Detalle.Titulo(DatosEmpresa.CPostal & " - " & DatosEmpresa.Poblacion, 35, altura + 12, 160, 4, Estilos.Normal)  'CPostal - Poblacion
        Impreso.Detalle.Titulo(DatosEmpresa.Provincia & " - " & DatosEmpresa.Pais, 35, altura + 16, 160, 4, Estilos.Normal)     'Provincia - Pais

    End Sub


    Private Sub ImprimeDatosCargador_ValeTraspaso(ByRef Impreso As Impreso, altura As Integer, ValeEnvases_Traspaso As E_ValeEnvases_Traspaso, DatosEmpresa As DatosEmpresa)

        Dim Domicilio As String = DatosEmpresa.Domicilio
        Dim CPostal As String = DatosEmpresa.CPostal
        Dim Poblacion As String = DatosEmpresa.Poblacion
        Dim Provincia As String = DatosEmpresa.Provincia


        Dim IdOrigen As String = ValeEnvases_Traspaso.VET_IdAlmacenOrigen.Valor & ""
        If VaInt(IdOrigen) > 0 Then

            Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
            If AlmacenEnvases.LeerId(IdOrigen) Then

                Domicilio = (AlmacenEnvases.AEV_Domicilio.Valor & "").Trim
                CPostal = (AlmacenEnvases.AEV_CPostal.Valor & "").Trim
                Poblacion = (AlmacenEnvases.AEV_Poblacion.Valor & "").Trim
                Provincia = (AlmacenEnvases.AEV_Provincia.Valor & "").Trim

            End If

        End If


        Impreso.Detalle.Titulo(DatosEmpresa.NombreEmpresa, 70, altura, 125, 4, Estilos.Normal)                           'Nombre
        Impreso.Detalle.Titulo(DatosEmpresa.NIF, 35, altura + 4, 160, 4, Estilos.Normal)                          'NIF
        Impreso.Detalle.Titulo(Domicilio, 35, altura + 8, 160, 4, Estilos.Normal)                    'Domicilio
        Impreso.Detalle.Titulo(CPostal & " - " & Poblacion, 35, altura + 12, 160, 4, Estilos.Normal)  'CPostal - Poblacion
        Impreso.Detalle.Titulo(Provincia & " - " & DatosEmpresa.Pais, 35, altura + 16, 160, 4, Estilos.Normal)     'Provincia - Pais

    End Sub


    Private Sub ImprimeDatosDestinatario_ValeTraspaso(ByRef Impreso As Impreso, altura As Integer, ValeEnvases_Traspaso As E_ValeEnvases_Traspaso, DatosEmpresa As DatosEmpresa)

        Dim Domicilio As String = DatosEmpresa.Domicilio
        Dim CPostal As String = DatosEmpresa.CPostal
        Dim Poblacion As String = DatosEmpresa.Poblacion
        Dim Provincia As String = DatosEmpresa.Provincia


        Dim IdDestino As String = ValeEnvases_Traspaso.VET_IdAlmacenDestino.Valor & ""
        If VaInt(IdDestino) > 0 Then

            Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
            If AlmacenEnvases.LeerId(IdDestino) Then

                Domicilio = (AlmacenEnvases.AEV_Domicilio.Valor & "").Trim
                CPostal = (AlmacenEnvases.AEV_CPostal.Valor & "").Trim
                Poblacion = (AlmacenEnvases.AEV_Poblacion.Valor & "").Trim
                Provincia = (AlmacenEnvases.AEV_Provincia.Valor & "").Trim

            End If

        End If


        Impreso.Detalle.Titulo(DatosEmpresa.NombreEmpresa, 70, altura, 125, 4, Estilos.Normal)                           'Nombre
        Impreso.Detalle.Titulo(DatosEmpresa.NIF, 35, altura + 4, 160, 4, Estilos.Normal)                          'NIF
        Impreso.Detalle.Titulo(Domicilio, 35, altura + 8, 160, 4, Estilos.Normal)                    'Domicilio
        Impreso.Detalle.Titulo(CPostal & " - " & Poblacion, 35, altura + 12, 160, 4, Estilos.Normal)  'CPostal - Poblacion
        Impreso.Detalle.Titulo(Provincia & " - " & DatosEmpresa.Pais, 35, altura + 16, 160, 4, Estilos.Normal)     'Provincia - Pais

    End Sub


    Private Sub ImprimeTransportista_ValeTraspaso(ByRef Impreso As Impreso, ValeEnvases_Traspaso As E_ValeEnvases_Traspaso)

        Dim Acreedores As New E_Acreedores(Idusuario, cn)
        If Acreedores.LeerId(ValeEnvases_Traspaso.VET_IdTransportista.Valor) Then

            Dim NIF As String = Acreedores.ACR_Nif.Valor
            Dim Nombre As String = Acreedores.ACR_Nombre.Valor

            Impreso.Detalle.Titulo(NIF, 25, 96.5, 100, 4, Estilos.Normal)
            Impreso.Detalle.Titulo(Nombre, 65, 92.5, 135, 4, Estilos.Normal)

        Else
            XtraMessageBox.Show("No se encontró el transportista Id: " & ValeEnvases_Traspaso.VET_IdTransportista.Valor, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub


    Private Sub ImprimeLugarDeOrigen_ValeTraspaso(ByRef Impreso As Impreso, ValeEnvases_Traspaso As E_ValeEnvases_Traspaso)

        Dim Poblacion As String = ""
        Dim CPostal As String = ""
        Dim provincia As String = ""

        Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
        If AlmacenEnvases.LeerId(ValeEnvases_Traspaso.VET_IdAlmacenOrigen.Valor) Then
            Poblacion = AlmacenEnvases.AEV_Poblacion.Valor
            CPostal = AlmacenEnvases.AEV_CPostal.Valor
            provincia = AlmacenEnvases.AEV_Provincia.Valor
        End If

        Impreso.Detalle.Titulo(Poblacion & ", " & CPostal & " - " & provincia, 20, 124, 80, 4, Estilos.Reducida)

    End Sub


    Private Sub ImprimeLugarDeDestino_ValeTraspaso(ByRef Impreso As Impreso, ValeEnvases_Traspaso As E_ValeEnvases_Traspaso)

        Dim Poblacion As String = ""
        Dim CPostal As String = ""
        Dim provincia As String = ""

        Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
        If AlmacenEnvases.LeerId(ValeEnvases_Traspaso.VET_IdAlmacenDestino.Valor) Then
            Poblacion = AlmacenEnvases.AEV_Poblacion.Valor
            CPostal = AlmacenEnvases.AEV_CPostal.Valor
            provincia = AlmacenEnvases.AEV_Provincia.Valor
        End If

        Impreso.Detalle.Titulo(Poblacion & ", " & CPostal & " - " & provincia, 110, 124, 80, 4, Estilos.Reducida)

    End Sub


    Private Sub ImprimeDetalleMercancia_ValeTraspaso(ByRef Impreso As Impreso, ValeEnvases_Traspaso As E_ValeEnvases_Traspaso)


        Dim IdVale As String = VaInt(ValeEnvases_Traspaso.VET_Idvale.Valor)


        If IdVale > 0 Then

            Dim ValeEnvaseTraspaso_Lineas As New E_ValeEnvases_traspaso_Lineas(Idusuario, cn)
            Dim Envases As New E_Envases(Idusuario, cn)
            Dim Marcas As New E_Marcas(Idusuario, cn)


            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(ValeEnvaseTraspaso_Lineas.VTL_Id, "IdLinea")
            CONSULTA.SelCampo(ValeEnvaseTraspaso_Lineas.VTL_uds, "Cantidad")
            CONSULTA.SelCampo(Envases.ENV_Nombre, "Envase", ValeEnvaseTraspaso_Lineas.VTL_idenvase, Envases.ENV_IdEnvase)
            CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", ValeEnvaseTraspaso_Lineas.VTL_idmarca, Marcas.MAR_Idmarca)
            Dim oPeso As New Cdatos.bdcampo("@COALESCE(VTL_Uds,0) * COALESCE(ENV_TaraSalida,0)", Cdatos.TiposCampo.Importe, 18, 2)
            CONSULTA.SelCampo(oPeso, "Peso")
            CONSULTA.WheCampo(ValeEnvaseTraspaso_Lineas.VTL_idvaletraspaso, "=", IdVale)
            Dim sql As String = CONSULTA.SQL
            sql = sql + " ORDER BY IdLinea"


            Dim altura As Integer = 143
            Dim dt As DataTable = ValeEnvaseTraspaso_Lineas.MiConexion.ConsultaSQL(sql)


            Dim TotalUds As Decimal = 0
            Dim TotalPeso As Decimal = 0

            'Máx. 14 líneas (no cabe más)
            For indice As Integer = 0 To dt.Rows.Count - 1

                Dim row As DataRow = dt.Rows(indice)
                If Not IsNothing(row) And indice <= 13 Then

                    Dim Cantidad As Integer = VaInt(row("cantidad"))
                    Dim Peso As Decimal = VaDec(row("Peso"))

                    'miCMR.Titulo(row("Genero").ToString, 45, altura, 20, 3, Estilos.Minima)
                    Impreso.Detalle.Titulo(row("Envase").ToString, 45, altura, 45, 3, Estilos.Minima)
                    Impreso.Detalle.Titulo(row("Marca").ToString, 95, altura, 21, 3, Estilos.Minima)
                    Impreso.Detalle.Titulo(Cantidad.ToString("#,##0"), 116, altura, 22, 3, Estilos.Minima, ">")

                    TotalUds = TotalUds + Cantidad
                    TotalPeso = TotalPeso + Peso

                    altura = altura + 3

                End If


                Application.DoEvents()

            Next


            Impreso.Cabecera.Titulo(TotalPeso.ToString("#,##0") & " Kg", 145, altura + 5, 40, 5, Estilos.Normal, "=")

            Impreso.Detalle.Titulo("------------", 116, altura, 22, 3, Estilos.Minima, ">")
            'Impreso.Detalle.Titulo("------------", 172, altura, 22, 3, Estilos.Minima, ">")
            altura = altura + 3
            Impreso.Detalle.Titulo(TotalUds.ToString("#,##0"), 116, altura, 22, 3, Estilos.Minima, ">")


            Dim vale As String = "Vale nº: " & VaInt(ValeEnvases_Traspaso.VET_Numero.Valor).ToString("000000")
            Impreso.Detalle.Titulo(vale, 15, 173, 40, 4, Estilos.Normal)


        End If

    End Sub


    Private Sub ImprimeFechaEnvio_ValeTraspaso(ByRef Impreso As Impreso, ValeEnvases_Traspaso As E_ValeEnvases_Traspaso)

        Dim Fecha As String = ""
        If VaDate(ValeEnvases_Traspaso.VET_Fecha.Valor) <> VaDate("") Then Fecha = VaDate(ValeEnvases_Traspaso.VET_Fecha.Valor).ToString("dd/MM/yyyy")
        Dim Hora As String = Now.ToString("HH:mm")

        Impreso.Detalle.Titulo(Fecha, 70, 182, 20, 4, Estilos.Normal)
        Impreso.Detalle.Titulo(Hora, 91, 182, 20, 4, Estilos.Normal)

    End Sub


    Private Sub ImprimeMatriculas_ValeTraspaso(ByRef Impreso As Impreso, ValeEnvases_Traspaso As E_ValeEnvases_Traspaso)

        Dim remolque As String = ValeEnvases_Traspaso.VET_Matricula.Valor
        Impreso.Detalle.Titulo(remolque, 127, 199, 25, 4, Estilos.Normal)

        Dim tractora As String = ValeEnvases_Traspaso.VET_Tractora.Valor
        Impreso.Detalle.Titulo(tractora, 47, 199, 25, 4, Estilos.Normal)

    End Sub


#End Region


#Region "CMR"


    Private Sub ImprimeDCTMC_CMR(ByRef Impreso As Impreso, DatosEmpresa As DatosEmpresa, CMR As E_Cmr, Cliente As E_Clientes, AlbSalida As E_AlbSalida)

        'Origen/Destino
        ImprimeOrigenDestino_CMR(Impreso, CMR)

        'Datos Cargador
        ImprimeDatosCargador_CMR(Impreso, Cliente, CMR, 44, True, DatosEmpresa)

        'Transportista
        ImprimeTransportista_CMR(Impreso, AlbSalida)

        'Lugar de origen
        ImprimeLugarDeOrigen_CMR(Impreso, DatosEmpresa)

        'Lucar de destino
        ImprimeLugarDeDestino_CMR(Impreso, Cliente, CMR)

        'Datos Destinatario
        ImprimeDatosCargador_CMR(Impreso, Cliente, CMR, 235, False, DatosEmpresa)

        'Detalle mercancía
        ImprimeDetalleMercancia_CMR(Impreso, CMR)

        'Fecha envío
        ImprimeFechaEnvio(Impreso)

        'Matriculas
        ImprimeMatriculas_CMR(Impreso, AlbSalida)

        'Firma expedidor
        ImprimeFirmaExpedidor(Impreso)

    End Sub


    Private Sub ImprimeOrigenDestino_CMR(ByRef Impreso As Impreso, CMR As E_Cmr)

        Dim OD As String = (CMR.CMR_OD.Valor & "").Trim.ToUpper
        Dim textoOD As String = ""

        If OD = "O" Then
            textoOD = "ORIGEN"
        ElseIf OD = "D" Then
            textoOD = "DESTINO"
        End If

        If textoOD <> "" Then
            Impreso.Detalle.Titulo(textoOD, 135, 4, 50, 6, Estilos.GrandeBold)
        End If


    End Sub



    Private Sub ImprimeDatosCargador_CMR(ByRef Impreso As Impreso, Cliente As E_Clientes, CMR As E_Cmr, altura As Integer,
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



        Impreso.Detalle.Titulo(Nombre, 70, altura, 125, 4, Estilos.Normal)                           'Nombre
        Impreso.Detalle.Titulo(NIF, 35, altura + 4, 160, 4, Estilos.Normal)                          'NIF
        Impreso.Detalle.Titulo(Domicilio, 35, altura + 8, 160, 4, Estilos.Normal)                    'Domicilio
        Impreso.Detalle.Titulo(CPostal & " - " & Poblacion, 35, altura + 12, 160, 4, Estilos.Normal)  'CPostal - Poblacion
        Impreso.Detalle.Titulo(Provincia & " - " & Pais, 35, altura + 16, 160, 4, Estilos.Normal)     'Provincia - Pais

    End Sub


    Private Sub ImprimeTransportista_CMR(ByRef Impreso As Impreso, AlbSalida As E_AlbSalida)

        Dim Acreedores As New E_Acreedores(Idusuario, cn)
        If Acreedores.LeerId(AlbSalida.ASA_idtransportista.Valor) Then

            Dim NIF As String = Acreedores.ACR_Nif.Valor
            Dim Nombre As String = Acreedores.ACR_Nombre.Valor

            Impreso.Detalle.Titulo(NIF, 25, 96.5, 100, 4, Estilos.Normal)
            Impreso.Detalle.Titulo(Nombre, 65, 92.5, 135, 4, Estilos.Normal)

        Else
            XtraMessageBox.Show("No se encontró el transportista Id: " & AlbSalida.ASA_idtransportista.Valor, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub


    Private Sub ImprimeLugarDeOrigen_CMR(ByRef Impreso As Impreso, DatosEmpresa As DatosEmpresa)

        Impreso.Detalle.Titulo(DatosEmpresa.Poblacion & ", " & DatosEmpresa.CPostal & " - " & DatosEmpresa.Provincia, 20, 124, 80, 4, Estilos.Reducida)

    End Sub


    Private Sub ImprimeLugarDeDestino_CMR(ByRef Impreso As Impreso, Cliente As E_Clientes, CMR As E_Cmr)

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

        Impreso.Detalle.Titulo(Poblacion & ", " & Provincia & " - " & Pais, 110, 124, 80, 4, Estilos.Reducida)

    End Sub


    Private Sub ImprimeDetalleMercancia_CMR(ByRef Impreso As Impreso, CMR As E_Cmr)


        Dim IdCMR As String = VaInt(CMR.CMR_IdCmr.Valor)


        If IdCMR > 0 Then

            Dim CMR_Lineas As New E_Cmr_lineas(Idusuario, cn)
            Dim Familias As New E_FamiliasGeneros(Idusuario, cn)
            Dim Envases As New E_Envases(Idusuario, cn)
            Dim Marcas As New E_Marcas(Idusuario, cn)


            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(CMR_Lineas.CML_IdCmrlin, "IdLinea")
            CONSULTA.SelCampo(CMR_Lineas.CML_bultos, "Bultos")
            'CONSULTA.SelCampo(CMR_Lineas.CML_knetos, "Kilos")
            CONSULTA.SelCampo(CMR_Lineas.CML_kbrutos, "Kilos")
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

                    'miCMR.Titulo(row("Genero").ToString, 45, altura, 20, 3, Estilos.Minima)
                    Impreso.Detalle.Titulo(row("Genero").ToString, 45, altura, 18, 3, Estilos.Minima)
                    Impreso.Detalle.Titulo(row("Marca").ToString, 64, altura, 21, 3, Estilos.Minima)
                    Impreso.Detalle.Titulo(row("Envase").ToString, 86, altura, 30, 3, Estilos.Minima)
                    Impreso.Detalle.Titulo(bultos.ToString("0"), 116, altura, 15, 3, Estilos.Minima, ">")
                    Impreso.Detalle.Titulo(kilos.ToString("#,##0"), 172, altura, 22, 3, Estilos.Minima, ">")

                    TotalBultos = TotalBultos + bultos
                    TotalKilos = TotalKilos + kilos

                    altura = altura + 3

                End If

                Application.DoEvents()

            Next

            Impreso.Detalle.Titulo("------------", 116, altura, 15, 3, Estilos.Minima, ">")
            Impreso.Detalle.Titulo("------------", 172, altura, 22, 3, Estilos.Minima, ">")
            altura = altura + 3
            Impreso.Detalle.Titulo(TotalBultos.ToString("#,##0"), 116, altura, 15, 3, Estilos.Minima, ">")
            Impreso.Detalle.Titulo(TotalKilos.ToString("#,##0"), 172, altura, 22, 3, Estilos.Minima, ">")


            Dim Albaran As String = "Alb nº: " & VaInt(CMR.CMR_Albaran.Valor).ToString("000000")
            Impreso.Detalle.Titulo(Albaran, 15, 173, 40, 4, Estilos.Normal)


        End If

    End Sub


    Private Sub ImprimeFechaEnvio(ByRef Impreso As Impreso)

        'TODO: Esto es now o viene de la factura? Se guarda la hora en algún sitio?
        Dim Fecha As String = Now.ToString("dd/MM/yyyy")
        Dim Hora As String = Now.ToString("HH:mm")

        Impreso.Detalle.Titulo(Fecha, 70, 182, 20, 4, Estilos.Normal)
        Impreso.Detalle.Titulo(Hora, 91, 182, 20, 4, Estilos.Normal)

    End Sub

    Private Sub ImprimeMatriculas_CMR(ByRef Impreso As Impreso, AlbSalida As E_AlbSalida)

        Dim camion As String = AlbSalida.ASA_matriculacamion.Valor
        Dim remolque As String = AlbSalida.ASA_matricularemolque.Valor

        Impreso.Detalle.Titulo(camion, 45, 199, 25, 4, Estilos.Normal)
        Impreso.Detalle.Titulo(remolque, 127, 199, 25, 4, Estilos.Normal)


    End Sub


    Private Sub ImprimeFirmaExpedidor(ByRef Impreso As Impreso)

        Impreso.Detalle.Titulo("Firma del expedidor,", 40, 259, 60, 4, Estilos.Normal)

    End Sub


#End Region




End Module
