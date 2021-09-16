Imports System.Drawing


Module C1_ImpresionClasificacion


    Public Sub C1_ImprimirClasificacionPartida(TipoImpresion As TipoImpresion,
                                               dt As DataTable, Partida As String, Agricultor As String, Genero As String,
                                               KgEntrada As String, Observaciones As String)



        Dim Listado As New Listado()

        Listado.f.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
        Listado.f.Documento.PageLayout.PageSettings.Landscape = False
        Listado.f.Documento.PageLayout.PageSettings.TopMargin = "10mm"
        Listado.f.Documento.PageLayout.PageSettings.LeftMargin = "10mm"
        Listado.f.Documento.PageLayout.PageSettings.BottomMargin = "12mm"

        Listado.EstableceListado(TipoImpresion)


        Try

            'Cabecera
            Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "170", Estilos.Cabecera)
            Listado.Cabecera.Linea(" ", "170", Estilos.NormalBold)
            Listado.Cabecera.Linea(" ", "170", Estilos.NormalBold)
            Listado.Cabecera.Linea("Clasificación partida|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "110|>60", Estilos.GrandeBold)
            Listado.Cabecera.Linea(" ", "170", Estilos.MinimaBold)
            Listado.Cabecera.Linea("  Partida: " & Partida, "170", Estilos.NormalBold)
            Listado.Cabecera.Linea("  Agricultor: " & Agricultor, "170", Estilos.NormalBold)
            Listado.Cabecera.Linea("  Género: " & Genero, "170", Estilos.NormalBold)
            Listado.Cabecera.Linea("  Kilos Entrada: " & KgEntrada, "170", Estilos.NormalBold)
            Listado.Cabecera.Linea("  Observaciones: " & Observaciones, "170", Estilos.NormalBold)

            Listado.Cabecera.Linea(" ", "170", Estilos.NormalBold)
            Listado.Cabecera.Linea(" ", "170", Estilos.NormalBold)



            'Detalle
            Dim DLin As String = "70|>50|>50"
            Dim Cabecera As String = "Categoria|Kilos|Porcentaje"
            Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
            Listado.Cabecera.Linea("", "", Estilos.ReducidaBold)


            Dim TotalKilos As Decimal = 0
            Dim TotalPorcentaje As Decimal = 0



            For Each row As DataRow In dt.Rows

                Dim Categoria As String = (row("Categoria").ToString & "").Trim
                Dim Kilos As Decimal = VaDec(row("Kilos"))
                Dim Porcentaje As Decimal = VaDec(row("Porcentaje"))


                'Líneas de listado
                Dim det As String = Categoria & "|"
                det = det & Kilos.ToString("#,##0.00") & "|"
                det = det & Porcentaje.ToString("#,##0.00") & " %"
                Listado.Detalle.Linea(det, DLin, Estilos.Reducida)

                TotalKilos = TotalKilos + Kilos
                TotalPorcentaje = TotalPorcentaje + Porcentaje


                Application.DoEvents()

            Next

            Listado.Detalle.Linea(" ", "170", Estilos.NormalBold)

            'Último total del género
            Listado.Detalle.Linea("|" & _
                                  TotalKilos.ToString("#,##0.00") & "|" & _
                                  TotalPorcentaje.ToString("#,##0.00") & " %", DLin, Estilos.ReducidaBoldLineaEncima)

            'Previsualizar
            Listado.Imprimir(TipoImpresion)
            'Listado.Dispose()


        Catch ex As Exception

        End Try

        

    End Sub

End Module
