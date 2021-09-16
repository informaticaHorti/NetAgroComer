Public Class Listado_Cobros
    Inherits Listado_ImpresionBase


    Property IdCobro As String
    Property IdCentro As String
    Property NumCobro As String
    Property Fecha As String
    Property NombreCliente As String
    Property TipoImpresion As TipoImpresion



    Public Sub New(ByVal idCobro As String, ByVal idCentro As String, ByVal numCobro As String, ByVal fecha As String, _
                   ByVal nombreCliente As String, ByVal tipoImpresion As TipoImpresion)
        Me.IdCobro = idCobro
        Me.IdCentro = idCentro
        Me.NumCobro = numCobro
        Me.Fecha = fecha
        Me.NombreCliente = nombreCliente
        Me.TipoImpresion = tipoImpresion
    End Sub



    Public Overrides Sub ImprimirListado()


        MargenSup = 60
        MargenIzq = 20
        MargenDer = 12
        MargenInf = 12

        EstableceListado(Orientacion.Vertical, TipoImpresion)


        Try

            ConfigurarListado()

            Select Case TipoImpresion
                Case NetAgro.TipoImpresion.Preliminar
                    Previsualiza()
                Case NetAgro.TipoImpresion.ImpresoraPorDefecto
                    ImprimeDirecto()
            End Select

        Catch ex As Exception

        End Try

        
    End Sub


    Private Sub ConfigurarListado()
        

        Dim ancho As Integer = 178

        Dim texto As String = ""
        Dim formato As String = ""

        texto = MiMaletin.NombreEmpresa.ToString
        formato = ancho.ToString
        Listado.Cabecera.Linea(texto, formato, Estilos.Cabecera)
        Listado.Cabecera.Linea("", ancho.ToString, Estilos.Minima)

        texto = "RECIBO DE COBRO Nº " & IdCentro & "-" & NumCobro.PadLeft(6, "0")
        Listado.Cabecera.Linea(texto, formato, Estilos.Cabecera)
        Listado.Cabecera.Linea("", ancho.ToString, Estilos.Minima)

        texto = "FECHA " & Fecha
        Listado.Cabecera.Linea(texto, formato, Estilos.Cabecera)
        Listado.Cabecera.Linea("", ancho.ToString, Estilos.Minima)

        texto = "CLIENTE " & NombreCliente
        Listado.Cabecera.Linea(texto, formato, Estilos.Cabecera)
        Listado.Cabecera.Linea("", ancho.ToString, Estilos.Minima)

        texto = "| FACTURA | FECHA | IMPORTE DV | COBRADO DV | COBRADO EUR"
        formato = "20|32|=30|>32|>32|>32"
        Listado.Cabecera.Linea(texto, formato, Estilos.ReducidaBold)
        Listado.Cabecera.Linea("", ancho.ToString, Estilos.Minima)

        Dim dt As DataTable = ObtenerDatosDetalle()

        Dim totalImporte As Decimal = 0
        Dim totalCobrado As Decimal = 0
        Dim totalCobradoEur As Decimal = 0

        For Each r As DataRow In dt.Rows
            Dim factura As String = ""
            If Not IsDBNull(r("serie")) And Not IsDBNull(r("numero")) Then factura = r("serie") & "-" & r("numero").ToString.PadLeft(6, "0")
            Dim fecha As String = ""
            If Not IsDBNull(r("fecha")) Then fecha = VaDate(r("fecha")).ToString("dd-MM-yyyy")
            Dim importeDv As Decimal = VaDec(r("importeDv"))
            Dim cobradoDv As Decimal = VaDec(r("cobradoDv"))
            Dim cambio As Decimal = VaDec(r("valorCambio"))
            If Not cambio > 0 Then cambio = 1
            Dim cobradoEur As Decimal = cobradoDv * cambio

            texto = "| " & factura & " | "
            texto = texto & fecha & " | "
            texto = texto & importeDv.ToString("#,##0.00") & " | "
            texto = texto & cobradoDv.ToString("#,##0.00") & " | "
            texto = texto & cobradoEur.ToString("#,##0.00")

            Listado.Detalle.Linea(texto, formato, Estilos.Reducida)

            totalImporte = totalImporte + importeDv
            totalCobrado = totalCobrado + cobradoDv
            totalCobradoEur = totalCobradoEur + cobradoEur


            Application.DoEvents()

        Next

        Listado.Detalle.Linea("", ancho.ToString, Estilos.Minima)
        texto = "||| " & totalImporte.ToString("#,##0.00") & " | "
        texto = texto & totalCobrado.ToString("#,##0.00") & " | "
        texto = texto & totalCobradoEur.ToString("#,##0.00")
        Listado.Detalle.Linea(texto, formato, Estilos.ReducidaBold)

    End Sub


    Private Function ObtenerDatosDetalle() As DataTable


        Dim dt As New DataTable

        Dim facturas As New E_Facturas(Idusuario, cn)
        Dim cobrosLineas As New E_CobrosLineas(Idusuario, cn)
        Dim consulta As New Cdatos.E_select

        consulta.SelCampo(cobrosLineas.CBL_IdLinea, "idLinea")
        consulta.SelCampo(facturas.FRA_serie, "serie", cobrosLineas.CBL_IdFactura)
        consulta.SelCampo(facturas.FRA_factura, "numero")
        consulta.SelCampo(facturas.FRA_fecha, "fecha")
        consulta.SelCampo(facturas.FRA_totalfactura, "importeDv")
        consulta.SelCampo(cobrosLineas.CBL_ImporteCobradoDivisa, "cobradoDv")
        consulta.SelCampo(facturas.FRA_valorcambio, "valorCambio")
        consulta.WheCampo(cobrosLineas.CBL_IdCobro, "=", IdCobro)

        Dim sql As String = consulta.SQL
        sql = sql + " ORDER BY idLinea"

        dt = facturas.MiConexion.ConsultaSQL(sql)

        Return dt
    End Function

    
End Class
