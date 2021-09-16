Public Class Listado_ConsultaPedidoMaterial
    Inherits Listado_ImpresionBase


    Property Dt As DataTable
    Property AcreedorDesde As String
    Property AcreedorHasta As String
    Property FechaDesde As String
    Property FechaHasta As String
    Property Finalizado As String
    Property Centros As List(Of Integer)


    Dim Texto As String = ""
    Dim Formato As String = ""
    Dim FormatoTotales As String = ""
    Dim AnchoPagina As Integer = 297
    Dim Ancho As Integer = AnchoPagina
    Dim TipoImpresion As TipoImpresion


    Public Sub New(ByVal dt As DataTable, ByVal acreedorDesde As String, ByVal acreedorHasta As String, ByVal fechaDesde As String, _
                   ByVal fechaHasta As String, ByVal finalizado As String, ByVal centros As List(Of Integer), ByVal TipoImpresion As TipoImpresion)
        Me.Dt = dt
        Me.AcreedorDesde = acreedorDesde
        Me.AcreedorHasta = acreedorHasta
        Me.FechaDesde = fechaDesde
        Me.FechaHasta = fechaHasta
        Me.Finalizado = finalizado
        Me.Centros = centros
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

        Dim lista As List(Of String) = MetodosComunesListados.ListaIntegerToString(Centros)
        Dim listaCentros As String = MetodosComunesListados.ObtenerListaFiltros(lista)

        Texto = MiMaletin.NombreEmpresa
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.Cabecera)

        Texto = "Listado de Pedidos por Material"
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.GrandeBold)

        Texto = "Desde acreedor " & AcreedorDesde & " hasta  " & AcreedorHasta & " | "
        Texto = Texto & "Fecha Impresión: " & Today.ToString("dd/MM/yyyy")
        Formato = (Ancho - 80).ToString & "|>80"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)

        Texto = "Desde fecha " & FechaDesde & " hasta  " & FechaHasta
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)

        Texto = "Incluir Finalizados: " & Finalizado
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)

        Texto = "Centros: " & listaCentros
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.NormalBold)

        Texto = "Pedido|Fecha|Centro|Referencia|Acreedor|Material|Cantidad|Precio|% Dto|"
        Formato = "20|20|50|32|70|>32|>20|>18|>18|"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.ReducidaBold)
    End Sub

    Private Sub ConfiguraDetalle()
        Dim codActual As Integer = 0

        For Each r As DataRow In Dt.Rows

            Dim idPedido As Integer = VaInt(r("Pedido"))
            Dim fecha As String = VaDate(r("Fecha")).ToString("dd/MM/yyyy")
            Dim centro As String = r("Centro").ToString
            Dim referencia As String = r("Referencia").ToString
            Dim acreedor As String = r("Acreedor").ToString
            Dim material As String = r("Material").ToString
            Dim cantidad As Decimal = VaDec(r("Cantidad"))
            Dim precio As Decimal = VaDec(r("Precio"))
            Dim descuento As Decimal = VaDec(r("Dto"))

            If Not idPedido = 0 And Not idPedido = codActual Then
                If Not codActual = 0 Then
                    Listado.Detalle.Linea("", Ancho.ToString, Estilos.ReducidaBoldLineaEncima)
                End If

                Texto = "Número pedido: |" & idPedido.ToString
                Listado.Detalle.Linea(Texto, Ancho.ToString, Estilos.ReducidaBold)
                Listado.Detalle.Linea("", Ancho.ToString, Estilos.Reducida)
            End If

            Texto = idPedido.ToString + "|"
            Texto = Texto & fecha + "|"
            Texto = Texto + centro + "|"
            Texto = Texto + referencia + "|"
            Texto = Texto + acreedor + "|"
            Texto = Texto + material + "|"
            Texto = Texto + Format(cantidad, "#,##0.0000") + "|"
            Texto = Texto + Format(precio, "#,##0.000000") + "|"
            Texto = Texto + Format(descuento, "#,##0.00") + "|"
            Listado.Detalle.Linea(Texto, Formato, Estilos.Reducida)

            codActual = idPedido


            Application.DoEvents()
        Next

        Listado.Detalle.Linea("", Ancho.ToString, Estilos.ReducidaBoldLineaEncima)
    End Sub


    Private Sub ConfiguraFiltrosCabecera()
        If AcreedorDesde.Trim = "" Then
            AcreedorDesde = "00001"
        Else
            AcreedorDesde = VaInt(AcreedorDesde).ToString("00000")
        End If
        If AcreedorHasta.Trim = "" Then
            AcreedorHasta = "99999"
        Else
            AcreedorHasta = VaInt(AcreedorHasta).ToString("00000")
        End If
    End Sub


End Class
