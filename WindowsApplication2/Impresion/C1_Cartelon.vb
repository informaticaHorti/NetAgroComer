Imports DevExpress.XtraEditors
Imports System.Drawing


Module C1_Cartelon


    Private margen_izquierdo As Integer = 10






    Public Sub C1_ImprimirCartelon(ByVal Presentacion As String, ByVal Categoria As String, ByVal FechaSalida As String, ByVal FechaConfeccion As String, ByVal Bultos As String,
                                   ByVal fuente_presentacion As Font, ByVal fuente_categoria As Font, ByVal fuente_fechasalida As Font, ByVal fuente_fechaconfeccion As Font, ByVal fuente_bultos As Font,
                                   ByVal TipoImpresion As TipoImpresion, NumCopias As Integer,
                                   Optional Impresora As String = "",
                                   Optional rutaPDF As String = "",
                                   Optional archivoPDF As String = "")



        Dim ConfiguracionesDiversas As New E_ConfiguracionesDiversas(Idusuario, cn)
        Dim papel = ConfiguracionesDiversas.xDameValor(E_ConfiguracionesDiversas.eClaves.FORMATO_PAPEL_PALETS, MiMaletin.IdPuntoVenta)


        Dim Impreso As New Impreso
        'Impreso.f.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
        If papel = "A5" Then
            Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A5
            Impreso.f.documento.PageLayout.PageSettings.Landscape = True
        Else
            Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
            Impreso.f.documento.PageLayout.PageSettings.Landscape = False
        End If
        Impreso.f.documento.PageLayout.PageSettings.TopMargin = "0mm"
        Impreso.f.Documento.PageLayout.PageSettings.BottomMargin = "0mm"
        Impreso.f.Documento.PageLayout.PageSettings.LeftMargin = "0mm"
        Impreso.f.documento.PageLayout.PageSettings.RightMargin = "0mm"

        Impreso.EstableceImpreso(TipoImpresion)


        Dim altura As Integer = 15


        Try

            Impreso.Detalle.Titulo(Presentacion, margen_izquierdo, altura, 190, fuente_presentacion.Height * 0.2646, Estilos.Custom, "=", , fuente_presentacion)
            altura = altura + 26
            Impreso.Detalle.Titulo(Categoria, margen_izquierdo, altura, 190, fuente_categoria.Height * 0.2646, Estilos.Custom, "=", , fuente_categoria)
            altura = altura + 32
            Impreso.Detalle.Titulo(FechaSalida, margen_izquierdo, altura, 190, fuente_fechasalida.Height * 0.2646, Estilos.Custom, "=", , fuente_fechasalida)
            altura = altura + 20
            Impreso.Detalle.Titulo(FechaConfeccion, margen_izquierdo, altura, 190, fuente_fechaconfeccion.Height * 0.2646, Estilos.Custom, "=", , fuente_fechaconfeccion)
            altura = altura + 26
            Impreso.Detalle.Titulo(Bultos, margen_izquierdo, altura, 190, fuente_bultos.Height * 0.2646, Estilos.Custom, "=", , fuente_bultos)
            altura = altura + 26



            'Impresión / previsualización / exportación
            If TipoImpresion = NetAgro.TipoImpresion.ImpresoraPorDefecto Then
                Dim Valoresusuario As New E_valoresusuario(Idusuario, cn)
                If Valoresusuario.LeerId(Idusuario) Then
                    Dim Impresora_cartelones As String = (Valoresusuario.VUS_ImpresoraCartelones.Valor & "").Trim
                    If Impresora_cartelones <> "" Then
                        Impreso.Imprimir(NetAgro.TipoImpresion.ImpresoraSeleccionada, Impresora_cartelones, rutaPDF, archivoPDF, NumCopias)
                    Else
                        Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF, NumCopias)
                    End If
                End If
            Else
                Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF, NumCopias)
            End If


        Catch ex As Exception

        End Try


    End Sub




End Module
