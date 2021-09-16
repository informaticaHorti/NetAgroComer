Public Class Listado_IntroduccionExistencias
    Inherits Listado_ImpresionBase


    Property IdParteSemanal As String
    Property ParteDesde As String
    Property ParteHasta As String
    Property Ancho As Integer = 190
    Property Cabecera As String = "Genero|Confección|Categoría|Marca|Kilos|Precio|Importe"
    Property Formato As String = "45|30|25|23|>20|>22|>25"
    Property TipoImpresion As TipoImpresion


    Public Sub New(ByVal IdParteSemanal As String, ByVal ParteDesde As String, ByVal ParteHasta As String, ByVal TipoImpresion As TipoImpresion)
        Me.IdParteSemanal = IdParteSemanal
        Me.ParteDesde = ParteDesde
        Me.ParteHasta = ParteHasta
        Me.TipoImpresion = TipoImpresion
    End Sub


    Public Overrides Sub ImprimirListado()

        Try

            EstableceListado(Orientacion.Vertical, TipoImpresion)
            ImprimeListado()

            Previsualiza()


        Catch ex As Exception

        End Try


    End Sub


    Private Sub ImprimeListado()


        ' Titulos Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, Ancho.ToString, Estilos.Cabecera)
        Listado.Cabecera.Linea("Introducción de existencias" & "|" & "Fecha: " & Today.ToString("dd/MM/yyyy"), "100|>90", Estilos.GrandeBold)
        Listado.Cabecera.Linea("De Fecha Inicial: " & ParteDesde & " a Fecha Final: " & ParteHasta, Ancho.ToString, Estilos.NormalBold)
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Normal)
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Normal)

        Listado.Cabecera.Linea(Cabecera, Formato, Estilos.MinimaBoldLineaDebajo)
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.MinimaBold)


       
        Dim dt As DataTable = ObtenerDatosIntroduccionExistencias(IdParteSemanal)


        Dim TotalKilos As Decimal = 0
        Dim TotalImporte As Decimal = 0


        For Each row As DataRow In dt.Rows

            Dim Genero As String = (row("Genero").ToString & "").Trim
            Dim Confeccion As String = (row("Confeccion").ToString & "").Trim
            Dim Categoria As String = (row("Categoria").ToString & "").Trim
            Dim Marca As String = (row("Marca").ToString & "").Trim
            Dim Kilos As Decimal = VaDec(row("Kilos"))
            Dim Precio As Decimal = VaDec(row("Precio"))
            Dim Importe As Decimal = VaDec(row("Importe"))


            TotalKilos = TotalKilos + Kilos
            TotalImporte = TotalImporte + Importe


            Dim det As String = Genero & "|"
            det = det & Confeccion & "|"
            det = det & Categoria & "|"
            det = det & Marca & "|"
            det = det & Kilos.ToString("#,##0") & "|"
            det = det & Precio.ToString("#,##0.00000") & "|"
            det = det & Importe.ToString("#,##0.00")

            Listado.Detalle.Linea(det, Formato, Estilos.Reducida)


            Application.DoEvents()

        Next


        Listado.Detalle.Linea("", Ancho.ToString, Estilos.Reducida)

        Dim tot As String = "TOTAL||||"
        tot = tot & TotalKilos.ToString("#,##0") & "||"
        tot = tot & TotalImporte.ToString("#,##0.00")
        Listado.Detalle.Linea(tot, Formato, Estilos.ReducidaBoldLineaEncima)


    End Sub


    Private Function ObtenerDatosIntroduccionExistencias(IdParteSemanal As String) As DataTable

        Dim ParteExistencias_Lineas As New E_ParteExistencias_lineas(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
        Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
        Dim Marcas As New E_Marcas(Idusuario, cn)


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(ParteExistencias_lineas.PSL_idlinea, "PSL_idlinea")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero", ParteExistencias_lineas.PSL_idgenero)
        CONSULTA.SelCampo(ConfecEnvase.CEV_Nombre, "Confeccion", ParteExistencias_lineas.PSL_idtipoconfeccion)
        CONSULTA.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", ParteExistencias_lineas.PSL_idcategoria)
        CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", ParteExistencias_lineas.PSL_idmarca)
        CONSULTA.SelCampo(ParteExistencias_lineas.PSL_palets, "Palets")
        CONSULTA.SelCampo(ParteExistencias_lineas.PSL_bultos, "Bultos")
        CONSULTA.SelCampo(ParteExistencias_lineas.PSL_kilos, "Kilos")
        CONSULTA.SelCampo(ParteExistencias_lineas.PSL_precio, "Precio")
        Dim oImporte As New Cdatos.bdcampo("@PSL_Kilos * PSL_Precio", Cdatos.TiposCampo.Importe, 18, 2)
        CONSULTA.SelCampo(oImporte, "Importe")
        CONSULTA.WheCampo(ParteExistencias_Lineas.PSL_idparte, "=", IdParteSemanal)

        Dim sql As String = CONSULTA.SQL & vbCrLf
        sql = sql + " ORDER BY PSL_IdLinea"



        Dim dt As DataTable = ParteExistencias_Lineas.MiConexion.ConsultaSQL(sql)

        Return dt

    End Function
    

End Class
