Imports System.Drawing

Public Module C1_AlbaranMaterial


    Dim ancho_linea As Decimal = 2
    Dim fuente As New Font("Courier New", 10)
    Dim fuente_bold As New Font("Courier New", 10, FontStyle.Bold)
    Dim fuente_titulo As New Font("Courier New", 12)



    Public Sub C1_ImprimirAlbaranMaterial(IdAlbaran As String, TipoImpresion As TipoImpresion,
                                        Optional Impresora As String = "",
                                        Optional rutaPDF As String = "",
                                        Optional archivoPDF As String = "")


        Dim AlbMaterial As New E_AlbMaterial(Idusuario, cn)
        Dim err As New Errores


        If AlbMaterial.LeerId(IdAlbaran) Then

            Try


                Dim Impreso As New Impreso
                Impreso.f.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
                Impreso.f.Documento.PageLayout.PageSettings.TopMargin = "0mm"
                Impreso.f.Documento.PageLayout.PageSettings.BottomMargin = "0mm"
                Impreso.f.Documento.PageLayout.PageSettings.LeftMargin = "0mm"
                Impreso.f.documento.PageLayout.PageSettings.RightMargin = "0mm"

                Impreso.EstableceImpreso(TipoImpresion)



                Dim margen_izquierdo As Integer = 4


                Dim Col As New List(Of Integer)
                Col.Add(0)                                      'Col 0
                Col.Add(margen_izquierdo + 2)                   'Col 1
                Col.Add(margen_izquierdo + 22)                  'Col 2
                Col.Add(margen_izquierdo + 65)                  'Col 3
                Col.Add(margen_izquierdo + 65 + 25)             'Col 4
                Col.Add(margen_izquierdo + 90 + 20)             'Col 5
                Col.Add(margen_izquierdo + 90 + 20 + 20)        'Col 6
                Col.Add(margen_izquierdo + 90 + 20 + 20 + 25)   'Col 7



                Dim altura As Integer = 34


                Try

                    Dim DatosEmpresa As New DatosEmpresa

                    'Cabecera
                    ImprimeCabeceraAlbaranMaterial(Impreso, DatosEmpresa, AlbMaterial, altura, margen_izquierdo, Col)

                    'Detalle
                    ImprimeDetalleAlbaranMaterial(Impreso, AlbMaterial, altura, margen_izquierdo, Col)

                    'Pie
                    'Impreso.Detalle.Titulo("FIRMADO:", margen_izquierdo, 135, 35, 4, Estilos.Custom, , , fuente)


                    'Impresión / previsualización / exportación
                    Dim valoresusuario As New E_valoresusuario(Idusuario, cn)
                    If valoresusuario.LeerId(Idusuario) = True Then
                        Impresora = valoresusuario.VUS_ImpresoraValeEnvases.Valor
                    End If


                    Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)

                Catch ex As Exception

                End Try



            Catch ex As Exception
                err.Muestraerror("Error al leer el albaran de materiales con id: " & IdAlbaran, "C1_ImprimirAlbaranMaterial", ex.Message)
            End Try

        Else
            err.Muestraerror("Error al leer el albaran de materiales con id: " & IdAlbaran, "C1_ImprimirAlbaranMaterial", "Error al leer el albarán de material con id: " & IdAlbaran)
        End If


    End Sub


    Private Sub ImprimeCabeceraAlbaranMaterial(ByRef Impreso As Impreso, DatosEmpresa As DatosEmpresa, AlbMaterial As E_AlbMaterial, ByRef altura As Integer,
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


        Impreso.Cabecera.Titulo(DatosEmpresa.NombreEmpresa, 140, 3, 90, 5, Estilos.NormalBold)
        Impreso.Cabecera.Titulo(DatosEmpresa.Domicilio, 140, 8, 90, 5, Estilos.MinimaBold)
        Impreso.Cabecera.Titulo(DatosEmpresa.Poblacion & " (" & DatosEmpresa.Provincia & ")", 140, 11, 90, 5, Estilos.MinimaBold)
        Impreso.Cabecera.Titulo("C.I.F.: " & DatosEmpresa.NIF, 140, 14, 90, 5, Estilos.MinimaBold)



        Dim Titulo As String = "ALBARAN MATERIAL"


        'Código de barras
        Dim CodBar As String = "*AM" & AlbMaterial.AMA_Campa.Valor & "." & VaInt(AlbMaterial.AMA_Numero.Valor).ToString & "*"

        Dim Code39 As New Font("C39HrP24DhTt", 42)
        Impreso.Cabecera.Titulo(CodBar, 35, 25, 165, 18, Estilos.Custom, ">", , Code39)



        'Obtenemos datos
        Dim NumAlbaran As String = VaInt(AlbMaterial.AMA_Numero.Valor).ToString("000000")
        Dim Fecha As String = ""
        If VaDate(AlbMaterial.AMA_Fecha.Valor) <> VaDate("") Then Fecha = VaDate(AlbMaterial.AMA_Fecha.Valor).ToString("dd/MM/yyyy")

        Dim Codigo As String = VaInt(AlbMaterial.AMA_Idacreedor.Valor).ToString("00000")
        Dim Nombre As String = ""

        Dim Acreedores As New E_Acreedores(Idusuario, cn)
        If VaInt(AlbMaterial.AMA_Idacreedor.Valor) > 0 Then
            If Acreedores.LeerId(AlbMaterial.AMA_Idacreedor.Valor) Then
                Nombre = Acreedores.ACR_Nombre.Valor
            End If
        End If



        'Cabecera
        Impreso.Detalle.Titulo(Titulo, margen_izquierdo, altura, 145, 6, Estilos.Custom, "=", , fuente_titulo)
        altura = altura + 10


        'Imprimimos
        Impreso.Detalle.Titulo("Num. Albaran: ", margen_izquierdo + 2, altura, 26, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo(NumAlbaran, margen_izquierdo + 2 + 27, altura, 30, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("Fecha: " & Fecha, margen_izquierdo, altura, 145, 4, Estilos.Custom, ">", , fuente)
        altura = altura + 4
        Impreso.Detalle.Titulo("Hora: " & Now.ToString("HH:mm"), margen_izquierdo, altura, 145, 4, Estilos.Custom, ">", , fuente)
        altura = altura + 4
        Impreso.Detalle.Titulo("Nombre: " & Codigo & " " & Nombre, margen_izquierdo + 2, altura, 145, 4, Estilos.Custom, , , fuente)
        altura = altura + 4
        altura = altura + 4

        'Cabecera detalle
        Impreso.Detalle.Titulo("Cod", Col(1), altura, 10, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("Material", Col(2), altura, 30, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("Marca", Col(3), altura, 30, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("Cant", Col(4), altura, 15, 4, Estilos.Custom, ">", , fuente)
        Impreso.Detalle.Titulo("Precio", Col(5), altura, 20, 4, Estilos.Custom, ">", , fuente)
        Impreso.Detalle.Titulo("Importe", Col(6), altura, 25, 4, Estilos.Custom, ">", , fuente)
        Impreso.Detalle.Titulo("Dto", Col(7), altura, 20, 4, Estilos.Custom, ">", , fuente)
        altura = altura + 4

        Impreso.Detalle.Titulo("---", Col(1), altura, 10, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("--------", Col(2), altura, 30, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("-----", Col(3), altura, 30, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("----", Col(4), altura, 15, 4, Estilos.Custom, ">", , fuente)
        Impreso.Detalle.Titulo("-------", Col(5), altura, 20, 4, Estilos.Custom, ">", , fuente)
        Impreso.Detalle.Titulo("-------", Col(6), altura, 25, 4, Estilos.Custom, ">", , fuente)
        Impreso.Detalle.Titulo("---", Col(7), altura, 20, 4, Estilos.Custom, ">", , fuente)
        altura = altura + 4



    End Sub


    Private Sub ImprimeDetalleAlbaranMaterial(ByRef Impreso As Impreso, AlbMaterial As E_AlbMaterial, ByRef altura As Integer, margen_izquierdo As Integer, Col As List(Of Integer))


        altura = altura + 8

        Dim AlbMaterialLineas As New E_AlbMaterialLineas(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)
        Dim Marcas As New E_Marcas(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbMaterialLineas.AML_idmaterial, "IdMaterial")
        consulta.SelCampo(Envases.ENV_Nombre, "Envase", AlbMaterialLineas.AML_idmaterial, Envases.ENV_IdEnvase)
        consulta.SelCampo(Marcas.MAR_Nombre, "Marca", AlbMaterialLineas.AML_idmarca)
        consulta.SelCampo(AlbMaterialLineas.AML_cantidad, "Cantidad")
        consulta.SelCampo(AlbMaterialLineas.AML_precio, "Precio")
        consulta.SelCampo(New Cdatos.bdcampo("@0", Cdatos.TiposCampo.Importe, 18, 2), "Importe")
        consulta.SelCampo(AlbMaterialLineas.AML_descuento, "Descuento")
        consulta.WheCampo(AlbMaterialLineas.AML_idalb, "=", AlbMaterial.AMA_Idalb.Valor)


        Dim TotalAlbaran As Decimal = VaDec(AlbMaterial.AMA_importe.Valor)


        Dim dtLineas As DataTable = AlbMaterialLineas.MiConexion.ConsultaSQL(consulta.SQL)

        For Each row As DataRow In dtLineas.Rows

            Dim IdMaterial As String = (row("IdMaterial").ToString & "").Trim
            Dim Material As String = row("Envase").ToString & ""
            Dim Marca As String = row("Marca").ToString & ""
            Dim Cantidad As Decimal = VaDec(row("Cantidad"))
            Dim Precio As Decimal = VaDec(row("Precio"))
            Dim Importe As Decimal = Cantidad * Precio
            Dim Descuento As Decimal = VaDec(row("Descuento"))

            Impreso.Detalle.Titulo(IdMaterial, Col(1), altura, 10, 4, Estilos.Custom, , , fuente)
            Impreso.Detalle.Titulo(Material, Col(2), altura, 41, 4, Estilos.Custom, , , fuente)
            Impreso.Detalle.Titulo(Marca, Col(3), altura, 19, 4, Estilos.Custom, , , fuente)
            If Cantidad <> 0 Then
                Impreso.Detalle.Titulo(Cantidad.ToString("#,##0"), Col(4), altura, 15, 4, Estilos.Custom, ">", , fuente)
                Impreso.Detalle.Titulo(Precio.ToString("#,##0.000000"), Col(5), altura, 20, 4, Estilos.Custom, ">", , fuente)
                Impreso.Detalle.Titulo(Importe.ToString("#,##0.00"), Col(6), altura, 25, 4, Estilos.Custom, ">", , fuente)
            End If
            Impreso.Detalle.Titulo(Descuento.ToString("#,##0.00"), Col(7), altura, 20, 4, Estilos.Custom, ">", , fuente)
            altura = altura + 4


            Application.DoEvents()

        Next


        altura = altura + 8
        Impreso.Detalle.Titulo("TOTAL:", Col(5), altura, 20, 4, Estilos.Custom, ">", , fuente_bold)
        Impreso.Detalle.Titulo(TotalAlbaran.ToString("#,##0.00"), Col(6), altura, 25, 4, Estilos.Custom, ">", , fuente_bold)


    End Sub


End Module
