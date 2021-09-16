Public Class Listado_InformeAlbaranMaterial
    Inherits Listado_ImpresionBase


    Property Dt As DataTable
    Property Material As String
    Property AcreedorDesde As String
    Property AcreedorHasta As String
    Property FechaDesde As String
    Property FechaHasta As String
    Property Almacenes As List(Of Integer)
    Property Facturados As String
    Property TipoImpresion As TipoImpresion


    Dim Texto As String = ""
    Dim Formato As String = ""
    Dim FormatoTotales As String = ""
    Dim AnchoPagina As Integer = 297
    Dim Ancho As Integer = AnchoPagina


    Public Sub New(ByVal dt As DataTable, material As String, _
                   ByVal acreedorDesde As String, ByVal acreedorHasta As String, _
                   ByVal fechaDesde As String, ByVal fechaHasta As String, _
                   ByVal almacenes As List(Of Integer), ByVal facturados As String,
                   ByVal TipoImpresion As TipoImpresion)
        Me.Dt = dt
        Me.Material = material
        Me.AcreedorDesde = acreedorDesde
        Me.AcreedorHasta = acreedorHasta
        Me.FechaDesde = fechaDesde
        Me.FechaHasta = fechaHasta
        Me.Almacenes = almacenes
        Me.Facturados = facturados
        Me.TipoImpresion = TipoImpresion
    End Sub


    Public Overrides Sub ImprimirListado()

        MargenIzq = 5
        EstableceListado(Orientacion.Horizontal, TipoImpresion)
        Ancho = Ancho - MargenDer - MargenIzq

        Try

            ConfiguraListado()
            Previsualiza()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ConfiguraListado()

        ConfiguraCabecera()
        ConfiguraDetalle()

    End Sub

    Private Sub ConfiguraCabecera()

        ConfiguraFiltrosCabecera()

        Dim lista As List(Of String) = MetodosComunesListados.ListaIntegerToString(Almacenes)
        Dim listaAlmacenes As String = MetodosComunesListados.ObtenerListaFiltros(lista)

        Texto = MiMaletin.NombreEmpresa
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.Cabecera)

        Texto = "Listado Albaran"
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.GrandeBold)

        Texto = "Material: " & Material
        If Len(Material.Trim) > 0 Then Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)

        Texto = "Desde acreedor " & AcreedorDesde & " hasta  " & AcreedorHasta & " | "
        Texto = Texto & "Fecha Impresión: " & Today.ToString("dd/MM/yyyy")
        Formato = (Ancho - 80).ToString & "|>80"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)

        Texto = "Desde fecha " & FechaDesde & " hasta  " & FechaHasta
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)

        Select Case Facturados
            Case "S"
                Texto = "SOLO FACTURADOS"
            Case "N"
                Texto = "SOLO NO FACTURADOS"
            Case Else
                Texto = ""
        End Select
        If Len(Texto) > 0 Then Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)

        Texto = "Almacen: " & listaAlmacenes
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.NormalBold)

        Texto = " Albaran | Fecha | Punto de Venta | Referencia | Acreedor | Material | Cantidad | Precio | % Dto |"
        Formato = "18|20|48|32|70|32|>24|>18|>18|"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.ReducidaBold)
    End Sub

    Private Sub ConfiguraDetalle()
        Dim total As Decimal = 0
        Dim totalAlbaran As Decimal = 0

        Dim codigoActual As Integer = 0

        For Each r As DataRow In Dt.Rows

            Dim idPedido As Integer = VaInt(r("Albaran"))
            Dim fecha As String = VaDate(r("Fecha")).ToString("dd/MM/yyyy")
            Dim puntoVenta As String = r("PuntoVenta").ToString
            Dim referencia As String = r("Referencia").ToString
            Dim acreedor As String = r("Acreedor").ToString
            Dim material As String = r("Material").ToString
            Dim cantidad As Decimal = VaDec(r("Cantidad"))
            Dim precio As Decimal = VaDec(r("Precio"))
            Dim descuento As Decimal = VaDec(r("Dto"))

            If idPedido = 0 Or Not idPedido = codigoActual Then
                If Not codigoActual = 0 Then
                    Texto = "||||||" & totalAlbaran.ToString("#,##0.0000") & "|||"
                    Listado.Detalle.Linea(Texto, Formato, Estilos.ReducidaBoldLineaEncima)

                    totalAlbaran = 0
                End If

                Listado.Detalle.Linea("", Ancho.ToString, Estilos.Reducida)
                Texto = "Número Albaran: " & idPedido.ToString
                Listado.Detalle.Linea(Texto, Ancho.ToString, Estilos.ReducidaBold)
                Listado.Detalle.Linea("", Ancho.ToString, Estilos.Reducida)
            End If

            Texto = idPedido.ToString & " | "
            Texto = Texto & fecha & "|"
            Texto = Texto & puntoVenta & "|"
            Texto = Texto & referencia & "|"
            Texto = Texto & acreedor & "|"
            Texto = Texto & material & "|"
            Texto = Texto & Format(cantidad, "#,##0.0000") & "|"
            Texto = Texto & Format(precio, "#,##0.000000") & "|"
            Texto = Texto & Format(descuento, "#,##0.00") & "|"
            Listado.Detalle.Linea(Texto, Formato, Estilos.Reducida)

            totalAlbaran = totalAlbaran + cantidad
            total = total + cantidad
            codigoActual = idPedido

            Application.DoEvents()

        Next

        Texto = "||||||" & totalAlbaran.ToString("#,##0.0000") & "|||"
        Listado.Detalle.Linea(Texto, Formato, Estilos.ReducidaBoldLineaEncima)
        Listado.Detalle.Linea("", Ancho.ToString, Estilos.Reducida)

        Texto = "|TOTALES|||||" & total.ToString("#,##0.0000") & "|||"
        Listado.Detalle.Linea(Texto, Formato, Estilos.ReducidaBoldLineaEncima)
    End Sub


    Private Sub ConfiguraFiltrosCabecera()
        If Not Len(AcreedorDesde.Trim) > 0 Then
            AcreedorDesde = "00001"
        Else
            AcreedorDesde = VaInt(AcreedorDesde).ToString("00000")
        End If

        If Not Len(AcreedorHasta.Trim) > 0 Then
            AcreedorHasta = "99999"
        Else
            AcreedorHasta = VaInt(AcreedorHasta).ToString("00000")
        End If
    End Sub


End Class
