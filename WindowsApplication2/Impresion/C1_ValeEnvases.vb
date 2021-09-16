Imports System.Drawing

Public Module C1_ValeEnvases


    Dim ancho_linea As Decimal = 2
    Dim fuente As New Font("Courier New", 10)
    Dim fuente_titulo As New Font("Courier New", 12)



    Public Sub C1_ImprimirValeEnvases(IdVale As String, TipoImpresion As TipoImpresion,
                                        Optional Impresora As String = "",
                                        Optional rutaPDF As String = "",
                                        Optional archivoPDF As String = "")


        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
        Dim err As New Errores


        If ValeEnvases.LeerId(IdVale) Then

            Try


                Dim ConfiguracionesDiversas As New E_ConfiguracionesDiversas(Idusuario, cn)
                Dim papel = ConfiguracionesDiversas.xDameValor(E_ConfiguracionesDiversas.eClaves.FORMATO_PAPEL_ENTRADAS, MiMaletin.IdPuntoVenta)

                Dim Impreso As New Impreso
                'Impreso.f.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
                If papel = "A5" Then
                    Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A5
                    Impreso.f.documento.PageLayout.PageSettings.Landscape = True
                Else
                    Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
                    Impreso.f.documento.PageLayout.PageSettings.Landscape = False
                End If
                Impreso.f.Documento.PageLayout.PageSettings.TopMargin = "0mm"
                Impreso.f.Documento.PageLayout.PageSettings.BottomMargin = "0mm"
                Impreso.f.Documento.PageLayout.PageSettings.LeftMargin = "0mm"
                Impreso.f.documento.PageLayout.PageSettings.RightMargin = "0mm"

                Impreso.EstableceImpreso(TipoImpresion)



                Dim margen_izquierdo As Integer = 4


                Dim Col As New List(Of Integer)
                Col.Add(0)                                      'Col 0
                Col.Add(margen_izquierdo + 2)                   'Col 1
                Col.Add(margen_izquierdo + 45)                  'Col 2
                Col.Add(margen_izquierdo + 45 + 35)             'Col 3
                Col.Add(margen_izquierdo + 80 + 20)             'Col 4
                Col.Add(margen_izquierdo + 80 + 20 + 20)        'Col 5
                Col.Add(margen_izquierdo + 80 + 20 + 20 + 20)   'Col 6



                Dim altura As Integer = 34


                Dim DatosEmpresa As New DatosEmpresa


                Try

                    'Cabecera
                    ImprimeCabeceraValeEnvases(Impreso, DatosEmpresa, ValeEnvases, altura, margen_izquierdo, Col)

                    'Detalle
                    ImprimeDetalleValeEnvases(Impreso, ValeEnvases, altura, margen_izquierdo, Col)

                    'Pie
                    Impreso.Detalle.Titulo("FIRMADO:", margen_izquierdo, 135, 35, 4, Estilos.Custom, , , fuente)


                    'Impresión / previsualización / exportación
                    Dim valoresusuario As New E_valoresusuario(Idusuario, cn)
                    If valoresusuario.LeerId(Idusuario) = True Then
                        Impresora = valoresusuario.VUS_ImpresoraValeEnvases.Valor
                    End If


                    Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)

                Catch ex As Exception

                End Try


                

            Catch ex As Exception
                err.Muestraerror("Error al leer el vale de envases id: " & IdVale, "ImprimirValeEnvases", ex.Message)
            End Try

        Else
            err.Muestraerror("Error al leer el vale de envases con id: " & IdVale, "ImprimirValeEnvases", "Error al leer el albarán de entrada con id: " & IdVale)
        End If


    End Sub


    Private Sub ImprimeCabeceraValeEnvases(ByRef Impreso As Impreso, DatosEmpresa As DatosEmpresa, ValeEnvases As E_ValeEnvases, ByRef altura As Integer,
                                           margen_izquierdo As Integer, Col As List(Of Integer))


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
                Impreso.Cabecera.Imagen(logo, margen_izquierdo, 3, w, h)
            Catch ex As Exception
            End Try
        End If


        Impreso.Cabecera.Titulo(DatosEmpresa.NombreEmpresa, 122, 23, 90, 5, Estilos.NormalBold)
        Impreso.Cabecera.Titulo(DatosEmpresa.Domicilio, 122, 28, 90, 5, Estilos.MinimaBold)
        Impreso.Cabecera.Titulo(DatosEmpresa.Poblacion & " (" & DatosEmpresa.Provincia & ")", 122, 31, 90, 5, Estilos.MinimaBold)
        Impreso.Cabecera.Titulo("C.I.F.: " & DatosEmpresa.NIF, 122, 34, 90, 5, Estilos.MinimaBold)



        'Código de barras
        Dim Operacion As String = ValeEnvases.VEV_Operacion.Valor.ToUpper.Trim
        Dim Campa As String = VaInt(ValeEnvases.VEV_Campa.Valor).ToString("00")
        Dim NumeroVale As String = VaInt(ValeEnvases.VEV_Numero.Valor).ToString

        Dim CodBar As String = "*" & Operacion & Campa & "." & NumeroVale & "*"

        Dim Code39 As New Font("C39HrP24DhTt", 42)
        Impreso.Cabecera.Titulo(CodBar, 10, 4, 195, 18, Estilos.Custom, ">", , Code39)

        'Dim Code39 As New Font("IDAutomationHC39M", 12)
        'Impreso.Cabecera.Titulo(CodBar, 10, 4, 195, 50, Estilos.Custom, ">", , Code39)



        Dim Titulo As String = "VALE DE ENVASES"


        'Obtenemos datos
        Dim NumVale As String = VaInt(ValeEnvases.VEV_Numero.Valor).ToString("000000")
        Dim Fecha As String = ""
        If VaDate(ValeEnvases.VEV_Fecha.Valor) <> VaDate("") Then Fecha = VaDate(ValeEnvases.VEV_Fecha.Valor).ToString("dd/MM/yyyy")

        Dim Codigo As String = VaInt(ValeEnvases.VEV_Codigo.Valor).ToString("00000")
        Dim Nombre As String = ""
        Dim Concepto As String = (ValeEnvases.VEV_Concepto.Valor & "").Trim
        Dim TipoSujeto As String = (ValeEnvases.VEV_TipoSujeto.Valor & "").Trim.ToUpper
        Dim Referencia As String = (ValeEnvases.VEV_Referencia.Valor & "").Trim
        Dim Remolque As String = (ValeEnvases.VEV_Matricula.Valor & "").Trim
        Dim Tractora As String = (ValeEnvases.VEV_Tractora.Valor & "").Trim

        Select Case TipoSujeto
            Case "A"
                Dim Agricultores As New E_Agricultores(Idusuario, cn)
                If Agricultores.LeerId(ValeEnvases.VEV_Codigo.Valor) Then
                    Nombre = Agricultores.AGR_Nombre.Valor & ""
                End If

            Case "C"
                Dim Clientes As New E_Clientes(Idusuario, cn)
                If Clientes.LeerId(ValeEnvases.VEV_Codigo.Valor) Then
                    Nombre = Clientes.CLI_Nombre.Valor & ""
                End If

            Case "R"
                Dim Acreedores As New E_Acreedores(Idusuario, cn)
                If Acreedores.LeerId(ValeEnvases.VEV_Codigo.Valor) Then
                    Nombre = Acreedores.ACR_Nombre.Valor & ""
                End If

        End Select


        'Cabecera
        Impreso.Detalle.Titulo(Titulo, margen_izquierdo, altura, 145, 6, Estilos.Custom, "=", , fuente_titulo)
        altura = altura + 10


        'Imprimimos
        Impreso.Detalle.Titulo("Num. Albaran: ", margen_izquierdo + 2, altura, 26, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo(NumVale, margen_izquierdo + 2 + 27, altura, 30, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("Fecha: " & Fecha, margen_izquierdo + 117, altura, 145, 4, Estilos.Custom, , , fuente)
        altura = altura + 4
        Impreso.Detalle.Titulo("Hora:  " & Now.ToString("HH:mm"), margen_izquierdo + 117, altura, 145, 4, Estilos.Custom, , , fuente)
        altura = altura + 4
        Impreso.Detalle.Titulo("Nombre: " & Codigo & " " & Nombre, margen_izquierdo + 2, altura, 145, 4, Estilos.Custom, , , fuente)
        altura = altura + 4
        If TipoSujeto = "C" Then
            Impreso.Detalle.Titulo("Concepto: ", margen_izquierdo + 2, altura, 20, 4, Estilos.Custom, , , fuente)
            Impreso.Detalle.Titulo(Concepto, margen_izquierdo + 2 + 20, altura, 51, 4, Estilos.Custom, , , fuente)
            Impreso.Detalle.Titulo("Ref:", margen_izquierdo + 75, altura, 10, 4, Estilos.Custom, , , fuente)
            Impreso.Detalle.Titulo(Referencia, margen_izquierdo + 75 + 10, altura, 30, 4, Estilos.Custom, , , fuente)
        End If

        Impreso.Detalle.Titulo("Mat Rem.:", margen_izquierdo + 117, altura, 25, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo(Remolque, margen_izquierdo + 117 + 25, altura, 25, 4, Estilos.Custom, , , fuente)
        altura = altura + 4

        Impreso.Detalle.Titulo("Mat Tract.:", margen_izquierdo + 117, altura, 25, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo(Tractora, margen_izquierdo + 117 + 25, altura, 25, 4, Estilos.Custom, , , fuente)
        altura = altura + 8

        'Cabecera detalle
        Impreso.Detalle.Titulo("Tipo de Envase", Col(1), altura, 30, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("Marca", Col(2), altura, 30, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("Entrega", Col(3), altura, 20, 4, Estilos.Custom, ">", , fuente)
        If TipoSujeto = "C" Then Impreso.Detalle.Titulo("Precio", Col(4), altura, 20, 4, Estilos.Custom, ">", , fuente)
        Impreso.Detalle.Titulo("Retira", Col(5), altura, 20, 4, Estilos.Custom, ">", , fuente)
        If TipoSujeto = "C" Then Impreso.Detalle.Titulo("Precio", Col(6), altura, 20, 4, Estilos.Custom, ">", , fuente)
        altura = altura + 4

        Impreso.Detalle.Titulo("--------------", Col(1), altura, 30, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("-----", Col(2), altura, 30, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("-------", Col(3), altura, 20, 4, Estilos.Custom, ">", , fuente)
        If TipoSujeto = "C" Then Impreso.Detalle.Titulo("-------", Col(4), altura, 20, 4, Estilos.Custom, ">", , fuente)
        Impreso.Detalle.Titulo("------", Col(5), altura, 20, 4, Estilos.Custom, ">", , fuente)
        If TipoSujeto = "C" Then Impreso.Detalle.Titulo("-------", Col(6), altura, 20, 4, Estilos.Custom, ">", , fuente)
        altura = altura + 4



    End Sub


    Private Sub ImprimeDetalleValeEnvases(ByRef Impreso As Impreso, ValeEnvases As E_ValeEnvases, ByRef altura As Integer, margen_izquierdo As Integer, Col As List(Of Integer))


        Dim TipoSujeto As String = (ValeEnvases.VEV_TipoSujeto.Valor & "").Trim.ToUpper


        altura = altura + 8

        Dim ValeEnvase_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)
        Dim Marcas As New E_Marcas(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(ValeEnvase_Lineas.VEL_idenvase, "IdEnvase")
        consulta.SelCampo(Envases.ENV_Nombre, "Envase", ValeEnvase_Lineas.VEL_idenvase, Envases.ENV_IdEnvase)
        consulta.SelCampo(Marcas.MAR_Nombre, "Marca", ValeEnvase_Lineas.VEL_idmarca)
        consulta.SelCampo(ValeEnvase_Lineas.VEL_entrega, "Entrega")
        consulta.SelCampo(ValeEnvase_Lineas.VEL_precioentrega, "PrecioEntrega")
        consulta.SelCampo(ValeEnvase_Lineas.VEL_retira, "Retira")
        'consulta.SelCampo(ValeEnvase_Lineas.VEL_precioretira, "PrecioRetira")
        Dim oPrecioRetira As New Cdatos.bdcampo("@CASE VEL_TipoEnvase WHEN '" & E_FianzasEnvases.TipoFacturacion.FacturarAparte & "' THEN VEL_PrecioFianza ELSE VEL_PrecioRetira END", Cdatos.TiposCampo.Importe, ValeEnvase_Lineas.VEL_precioretira.Longitud, ValeEnvase_Lineas.VEL_precioretira.Decimales)
        consulta.SelCampo(oPrecioRetira, "PrecioRetira")
        consulta.WheCampo(ValeEnvase_Lineas.VEL_idvale, "=", ValeEnvases.VEV_Idvale.Valor)


        Dim dtLineas As DataTable = ValeEnvase_Lineas.MiConexion.ConsultaSQL(consulta.SQL)


        For Each row As DataRow In dtLineas.Rows

            Dim Envase As String = row("Envase").ToString & ""
            Dim Marca As String = row("Marca").ToString & ""
            Dim Entrega As Integer = VaInt(row("Entrega"))
            Dim Retira As Integer = VaInt(row("Retira"))

            Dim PrecioEntrega As Decimal = VaDec(row("PrecioEntrega"))
            Dim PrecioRetira As Decimal = VaDec(row("PrecioRetira"))


            Impreso.Detalle.Titulo(Envase, Col(1), altura, 41, 4, Estilos.Custom, , , fuente)
            Impreso.Detalle.Titulo(Marca, Col(2), altura, 29, 4, Estilos.Custom, , , fuente)

            If Entrega <> 0 Then
                Impreso.Detalle.Titulo(Entrega.ToString, Col(3), altura, 20, 4, Estilos.Custom, ">", , fuente)
                If TipoSujeto = "C" Then Impreso.Detalle.Titulo(PrecioEntrega.ToString("#,##0.000000"), Col(4), altura, 20, 4, Estilos.Custom, ">", , fuente)
            End If
            If Retira <> 0 Then
                Impreso.Detalle.Titulo(Retira.ToString, Col(5), altura, 20, 4, Estilos.Custom, ">", , fuente)
                If TipoSujeto = "C" Then Impreso.Detalle.Titulo(PrecioRetira.ToString("#,##0.000000"), Col(6), altura, 20, 4, Estilos.Custom, ">", , fuente)
            End If

            altura = altura + 4


            Application.DoEvents()

        Next



    End Sub


End Module
