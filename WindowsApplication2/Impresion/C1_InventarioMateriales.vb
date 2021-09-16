Imports System.Drawing

Module C1_InventarioMateriales

    Private anchoPagina As Integer = 273
    Private margenIzquierdo As Integer = 20
    Private margenDerecho As Integer = 30
    Private margenSuperior As Integer = 50
    Private margenInferior As Integer = 50
    Private anchoLinea As Integer = 2

    Public Sub C1_ImprimirInventarioMateriales(ByVal dt As DataTable, ByVal fechaDesde As String, ByVal fechaHasta As String, _
                                               ByVal marcas As Boolean, lstAlmacenes As List(Of String), lstFamilias As List(Of String))

        Dim impreso As New Impreso()

        impreso.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
        impreso.Documento.PageLayout.PageSettings.Landscape = True
        impreso.Documento.PageLayout.PageSettings.TopMargin = margenSuperior.ToString & "mm"
        impreso.Documento.PageLayout.PageSettings.LeftMargin = margenIzquierdo.ToString & "mm"
        impreso.Documento.PageLayout.PageSettings.RightMargin = margenDerecho.ToString & "mm"
        impreso.Documento.PageLayout.PageSettings.BottomMargin = margenInferior.ToString & "mm"

        If Not dt.Columns.Contains("IdMarca") Then
            marcas = False
        End If

        Dim almacenes As String = ""

        For Each idAlmacen As String In lstAlmacenes
            If almacenes.Trim <> "" Then almacenes = almacenes & ","
            almacenes = almacenes & idAlmacen
        Next

        Dim familias As String = ""

        For Each idFamilia As String In lstFamilias
            If familias.Trim <> "" Then familias = familias & ","
            familias = familias & idFamilia
        Next

        'ImprimeCabecera()







        'Dim AlbSalida As New E_AlbSalida(Idusuario, cn)

        'If AlbSalida.LeerId(IdAlbaran) Then
        '    Dim Clientes As New E_Clientes(Idusuario, cn)
        '    If Not Clientes.LeerId(AlbSalida.ASA_idcliente.Valor) Then
        '        MsgBox("Error al leer los datos del cliente con Id: " & AlbSalida.ASA_idcliente.Valor)
        '        Exit Sub
        '    End If

        '    Dim ClienteDescarga As New E_ClientesDescargas(Idusuario, cn)
        '    ClienteDescarga.LeerId(AlbSalida.ASA_iddomicilio.Valor)

        '    Dim altura As Integer = 5
        '    Dim DatosEmpresa As New DatosEmpresa


        '    Dim Impreso As New Impreso()

        '    Impreso.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
        '    Impreso.Documento.PageLayout.PageSettings.Landscape = True
        '    Impreso.Documento.PageLayout.PageSettings.TopMargin = "10mm"
        '    Impreso.Documento.PageLayout.PageSettings.LeftMargin = "10mm"
        '    Impreso.Documento.PageLayout.PageSettings.RightMargin = "10mm"
        '    Impreso.Documento.PageLayout.PageSettings.BottomMargin = "5mm"


        '    Impreso.DatosMail = ObtenerDatosMail(AlbSalida, ClienteDescarga)



        '    Dim TotalPalets As Integer = 0
        '    Dim TotalBultos As Integer = 0
        '    Dim TotalPiezas As Integer = 0
        '    Dim TotalKgBrutos As Decimal = 0
        '    Dim TotalKgNetos As Decimal = 0
        '    Dim TotalImporte As Decimal = 0

        '    Dim LeyendaControlado As Boolean = False

        '    'Imprimir cabecera
        '    ImprimeCabeceraAlbaranSalida(Impreso, altura, AlbSalida, DatosEmpresa, Clientes)

        '    'Imprimir detalle
        '    ImprimeDetalleAlbaranSalida(Impreso, altura, AlbSalida, TotalPalets, TotalBultos, TotalPiezas, TotalKgBrutos, TotalKgNetos, TotalImporte, LeyendaControlado)

        '    'Imprimir totales
        '    ImprimirTotalAlbaranSalida(Impreso, altura, AlbSalida, Clientes, TotalPalets, TotalBultos, TotalPiezas, TotalKgBrutos, TotalKgNetos, TotalImporte)

        '    'Pie
        '    ImprimirPieAlbaranSalida(Impreso, LeyendaControlado)

        '    Dim CD As New E_ConfiguracionesDiversas(Idusuario, cn)
        '    Dim ruta As String = CD.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_ARCHIVOS_ADJUNTOS_TEMP) & "\"

        '    Select Case TipoImpresion

        '        Case TipoImpresion.Email

        '            Impreso.Imprimir(NetAgro.TipoImpresion.ExportacionPDF, , ruta, Impreso.DatosMail.NombreDocumento)
        '            Impreso.DatosMail.ListaAdjuntos.Add(ruta & Impreso.DatosMail.NombreDocumento)
        '            Impreso()


        '            .EnviarPorOutlook(False)

        '            Try
        '                If IO.File.Exists(ruta & Impreso.DatosMail.NombreDocumento) Then
        '                    IO.File.Delete(ruta & Impreso.DatosMail.NombreDocumento)
        '                End If
        '            Catch ex As Exception
        '            End Try


        '        Case TipoImpresion.Fax
        '            Impreso.DatosMail = ObtenerDatosMail(AlbSalida, ClienteDescarga)

        '            Impreso.Imprimir(NetAgro.TipoImpresion.ExportacionPDF, , ruta, Impreso.DatosMail.NombreDocumento)
        '            Impreso.DatosMail.ListaAdjuntos.Add(ruta & Impreso.DatosMail.NombreDocumento)
        '            Impreso.EnviarPorOutlook(True)

        '            Try
        '                If IO.File.Exists(ruta & Impreso.DatosMail.NombreDocumento) Then
        '                    IO.File.Delete(ruta & Impreso.DatosMail.NombreDocumento)
        '                End If
        '            Catch ex As Exception
        '            End Try

        '        Case Else
        '            'Impresión
        '            Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF, NumCopias)
        '    End Select


        '    Impreso.Dispose()

        'Else
        'MsgBox("No se puede leer el albarán de salida con Id: " & IdAlbaran)
        'End If

    End Sub

    Private Sub ImprimeCabecera(ByRef impreso As Impreso)

        impreso.Cabecera.Titulo(MiMaletin.NombreEmpresa, margenIzquierdo, margenSuperior, anchoPagina, 8, Estilos.Cabecera)
        'impreso.Cabecera("Inventario de materiales por fecha", )

        'impreso.Cabecera("Inventario de materiales por fecha", "990", milinea.stilos.GrandeBold)
        'impreso.Cabecera("Almacén: " & Almacenes & "|Fecha Impresión: " & Today.ToString("dd/MM/yyyy"), "730|>260", milinea.stilos.NormalBold)
        'impreso.Cabecera("Desde " & FechaDesde & "  hasta " & FechaHasta, "990", milinea.stilos.NormalBold)
        'If Familias.Trim <> "" Then impreso.Cabecera("Familias: " & Familias, "990", milinea.stilos.NormalBold)
        'If bMarcas Then impreso.Cabecera("Mostrar marcas", "990", milinea.stilos.NormalBold)
        'impreso.Cabecera("", "200", milinea.stilos.Normal)
        'impreso.Cabecera("", "200", milinea.stilos.Normal)
    End Sub



End Module