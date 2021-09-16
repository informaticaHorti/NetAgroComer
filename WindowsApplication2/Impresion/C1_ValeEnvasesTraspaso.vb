Imports System.Drawing

Public Module C1_ValeEnvasesTraspaso


    Dim ancho_linea As Decimal = 2
    Dim fuente As New Font("Courier New", 10)
    Dim fuente_titulo As New Font("Courier New", 12)



    Public Sub C1_ImprimirValeEnvasesTraspaso(IdVale As String, TipoImpresion As TipoImpresion,
                                        Optional Impresora As String = "",
                                        Optional rutaPDF As String = "",
                                        Optional archivoPDF As String = "")


        Dim ValeEnvases_Traspaso As New E_ValeEnvases_Traspaso(Idusuario, cn)
        Dim err As New Errores


        If ValeEnvases_Traspaso.LeerId(IdVale) Then

            Try


                Dim Impreso As New Impreso
                'Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
                Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A5
                Impreso.f.documento.PageLayout.PageSettings.Landscape = True
                Impreso.f.Documento.PageLayout.PageSettings.TopMargin = "0mm"
                Impreso.f.Documento.PageLayout.PageSettings.BottomMargin = "0mm"
                Impreso.f.Documento.PageLayout.PageSettings.LeftMargin = "0mm"
                Impreso.f.documento.PageLayout.PageSettings.RightMargin = "0mm"


                Impreso.EstableceImpreso(TipoImpresion)



                Dim margen_izquierdo As Integer = 4


                Dim Col As New List(Of Integer)
                Col.Add(0)
                Col.Add(margen_izquierdo + 2)
                Col.Add(margen_izquierdo + 80)
                Col.Add(margen_izquierdo + 80 + 35)


                Dim altura As Integer = 34


                Try

                    'Cabecera
                    ImprimeCabeceraValeEnvasesTraspaso(Impreso, ValeEnvases_Traspaso, altura, margen_izquierdo, Col)

                    'Detalle
                    Dim TotalPeso As Decimal = 0
                    ImprimeDetalleValeEnvasesTraspaso(Impreso, ValeEnvases_Traspaso, altura, margen_izquierdo, Col, TotalPeso)

                    'Pie
                    Impreso.Detalle.Titulo("FIRMADO:", margen_izquierdo, 135, 35, 4, Estilos.Custom, , , fuente)
                    'Impreso.Detalle.Titulo("TOTAL PESO: " & TotalPeso.ToString("#,##0.00") & " Kg.", margen_izquierdo, 135, 142, 4, Estilos.Custom, ">", , fuente)


                    'Impresión / previsualización / exportación
                    Dim valoresusuario As New E_valoresusuario(Idusuario, cn)
                    If valoresusuario.LeerId(Idusuario) = True Then
                        Impresora = valoresusuario.VUS_ImpresoraValeEnvases.Valor
                    End If


                    Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)

                Catch ex As Exception

                End Try


            Catch ex As Exception
                err.Muestraerror("Error al leer el vale de envases id: " & IdVale, "ImprimirValeEnvasesTraspaso", ex.Message)
            End Try

        Else
            err.Muestraerror("Error al leer el vale de envases con id: " & IdVale, "ImprimirValeEnvasesTraspaso", "Error al leer el albarán de entrada con id: " & IdVale)
        End If


    End Sub


    Private Sub ImprimeCabeceraValeEnvasesTraspaso(ByRef Impreso As Impreso, ValeEnvases_Traspaso As E_ValeEnvases_Traspaso, ByRef altura As Integer,
                                           margen_izquierdo As Integer, Col As List(Of Integer))


        'Código de barras
        Dim Campa As String = VaInt(ValeEnvases_Traspaso.VET_Campa.Valor).ToString("00")
        Dim NumeroVale As String = VaInt(ValeEnvases_Traspaso.VET_Numero.Valor).ToString

        Dim CodBar As String = "*VT" & Campa & "." & NumeroVale & "*"
        Dim Code39 As New Font("C39HrP24DhTt", 42)
        Impreso.Cabecera.Titulo(CodBar, 10, 4, 195, 18, Estilos.Custom, ">", , Code39)


        'Cabecera
        Impreso.Detalle.Titulo("VALE DE ENVASES DE TRASPASOS ENTRE CENTROS", margen_izquierdo, altura, 145, 6, Estilos.Custom, "=", , fuente_titulo)
        altura = altura + 10


        'Obtenemos datos
        Dim NumVale As String = VaInt(ValeEnvases_Traspaso.VET_Numero.Valor).ToString("000000")
        Dim Fecha As String = ""
        If VaDate(ValeEnvases_Traspaso.VET_Fecha.Valor) <> VaDate("") Then Fecha = VaDate(ValeEnvases_Traspaso.VET_Fecha.Valor).ToString("dd/MM/yyyy")


        Dim Origen As String = ""
        Dim Destino As String = ""


        Dim IdOrigen As String = ValeEnvases_Traspaso.VET_IdAlmacenOrigen.Valor
        Dim IdDestino As String = ValeEnvases_Traspaso.VET_IdAlmacenDestino.Valor

        Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
        If AlmacenEnvases.LeerId(IdOrigen) Then
            Origen = IdOrigen & " " & AlmacenEnvases.AEV_Nombre.Valor
        End If
        If AlmacenEnvases.LeerId(IdDestino) Then
            Destino = IdDestino & " " & AlmacenEnvases.AEV_Nombre.Valor
        End If



        'Imprimimos
        Impreso.Detalle.Titulo("Num. Vale: ", margen_izquierdo + 2, altura, 25, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo(NumVale, margen_izquierdo + 2 + 27, altura, 30, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("Fecha: " & Fecha, margen_izquierdo, altura, 145, 4, Estilos.Custom, ">", , fuente)
        altura = altura + 4
        Impreso.Detalle.Titulo("Hora: " & Now.ToString("HH:mm"), margen_izquierdo, altura, 145, 4, Estilos.Custom, ">", , fuente)
        altura = altura + 4
        Impreso.Detalle.Titulo("ORIGEN: " & Origen, margen_izquierdo + 2, altura, 72, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("DESTINO: " & Destino, margen_izquierdo + 2 + 72 + 1, altura, 72, 4, Estilos.Custom, , , fuente)
        altura = altura + 8

        'Cabecera detalle
        Impreso.Detalle.Titulo("Tipo de Envase", Col(1), altura, 60, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("Uds.", Col(3), altura, 30, 4, Estilos.Custom, ">", , fuente)
        altura = altura + 4

        Impreso.Detalle.Titulo("--------------", Col(1), altura, 60, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("------", Col(3), altura, 30, 4, Estilos.Custom, ">", , fuente)
        altura = altura + 4



    End Sub


    Private Sub ImprimeDetalleValeEnvasesTraspaso(ByRef Impreso As Impreso, ValeEnvases_Traspaso As E_ValeEnvases_Traspaso, ByRef altura As Integer, margen_izquierdo As Integer, Col As List(Of Integer),
                                                  ByRef TotalPeso As Decimal)

        altura = altura + 8


        TotalPeso = 0


        Dim ValeEnvases_traspaso_Lineas As New E_ValeEnvases_traspaso_Lineas(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(ValeEnvases_traspaso_Lineas.VTL_idenvase, "IdEnvase")
        consulta.SelCampo(Envases.ENV_Nombre, "Envase", ValeEnvases_traspaso_Lineas.VTL_idenvase, Envases.ENV_IdEnvase)
        consulta.SelCampo(ValeEnvases_traspaso_Lineas.VTL_uds, "Cantidad")
        Dim oPeso As New Cdatos.bdcampo("@COALESCE(VTL_Uds,0) * COALESCE(ENV_TaraSalida,0)", Cdatos.TiposCampo.Importe, 18, 2)
        consulta.SelCampo(oPeso, "Peso")
        consulta.WheCampo(ValeEnvases_traspaso_Lineas.VTL_idvaletraspaso, "=", ValeEnvases_Traspaso.VET_Idvale.Valor)


        Dim dtLineas As DataTable = ValeEnvases_traspaso_Lineas.MiConexion.ConsultaSQL(consulta.SQL)


        For Each row As DataRow In dtLineas.Rows

            Dim Envase As String = (row("Envase").ToString & "").Trim
            Dim Cantidad As Integer = VaDec(row("Cantidad"))

            Impreso.Detalle.Titulo(Envase, Col(1), altura, 60, 4, Estilos.Custom, , , fuente)
            Impreso.Detalle.Titulo(Cantidad.ToString("#,##0"), Col(3), altura, 30, 4, Estilos.Custom, ">", , fuente)

            TotalPeso = TotalPeso + VaDec(row("Peso"))

            altura = altura + 4


            Application.DoEvents()

        Next



    End Sub


End Module
