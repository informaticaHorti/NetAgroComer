Public Class Listado_Tarifas_Materiales
    Inherits Listado_ImpresionBase


    'Propiedades
    Property IdAcreedor As String = ""
    Property NombreAcreedor As String = ""
    Property FechaTarifa As String = ""
    Property ancho As Integer = 178
    Property formato As String = "14|74|40|>20|>15|5|30"
    Property TipoImpresion As TipoImpresion


    Public Sub New(ByVal IdAcreedor As String, ByVal NombreAcreedor As String, ByVal FechaTarifa As String, _
                   ByVal tipoImpresion As TipoImpresion)

        Me.IdAcreedor = IdAcreedor
        Me.NombreAcreedor = NombreAcreedor
        Me.FechaTarifa = FechaTarifa
        Me.TipoImpresion = tipoImpresion

    End Sub


    Public Overrides Sub ImprimirListado()


        ConfigurarListado()

        Try

            'Cabecera
            ImprimirCabecera()

            'Detalle
            ImprimirDetalle()


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

        MargenSup = 12
        MargenIzq = 10
        MargenDer = 12
        MargenInf = 12

        EstableceListado(Orientacion.Vertical, TipoImpresion)

    End Sub


    Private Sub ImprimirCabecera()

        Dim texto As String = ""

        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, ancho.ToString, Estilos.GrandeBold)

        texto = "TARIFAS DE MATERIALES" & "|Fecha impresión: " & Today.ToString("dd/MM/yyyy")
        Listado.Cabecera.Linea(texto, "108|>90", Estilos.NormalBold)

        texto = "ACREEDOR: " & IdAcreedor & " - " & NombreAcreedor & "|Fecha tarifa: " & FechaTarifa
        Listado.Cabecera.Linea(texto, "118|>80", Estilos.NormalBold)
        Listado.Cabecera.Linea("", ancho.ToString, Estilos.Normal)
        Listado.Cabecera.Linea("", ancho.ToString, Estilos.Normal)
        Listado.Cabecera.Linea("", ancho.ToString, Estilos.Normal)


        texto = "Cod.|Material|Marca|Precio|Dto||Ref."
        Listado.Cabecera.Linea(texto, formato, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", ancho.ToString, Estilos.Minima)

    End Sub


    Private Sub ImprimirDetalle()

        Dim dt As DataTable = ObtenerDatosDetalle()
        Dim texto As String = ""


        For Each row As DataRow In dt.Rows

            Dim Codigo As String = (row("Cod").ToString & "").Trim
            Dim Material As String = (row("Material").ToString & "").Trim
            Dim Marca As String = (row("Marca").ToString & "").Trim
            Dim Precio As Decimal = VaDec(row("Precio"))
            Dim Dto As Decimal = VaDec(row("Dto"))
            Dim Referencia As String = (row("Referencia").ToString & "").Trim


            texto = codigo & "|"
            texto = texto & Material & " | "
            texto = texto & Marca & " | "
            texto = texto & Precio.ToString("#,##0.000000") & " | "
            texto = texto & Dto.ToString("#,##0.00") & "||"
            texto = texto & Referencia
            Listado.Detalle.Linea(texto, formato, Estilos.Reducida)

            Application.DoEvents()

        Next

    End Sub


    Private Function ObtenerDatosDetalle() As DataTable

        Dim TarifasMaterial As New E_TarifasMaterial(Idusuario, cn)
        Dim TarifasMaterialLineas As New E_TarifasMaterialLineas(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)
        Dim Marcas As New E_Marcas(Idusuario, cn)


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(TarifasMaterialLineas.TML_idmaterial, "Cod")
        CONSULTA.SelCampo(Envases.ENV_Nombre, "Material", TarifasMaterialLineas.TML_idmaterial, Envases.ENV_IdEnvase)
        CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", TarifasMaterialLineas.TML_idmarca, Marcas.MAR_Idmarca)
        CONSULTA.SelCampo(TarifasMaterialLineas.TML_precio, "Precio")
        CONSULTA.SelCampo(TarifasMaterialLineas.TML_descuento, "Dto")
        CONSULTA.SelCampo(TarifasMaterialLineas.TML_referencia, "Referencia")
        CONSULTA.WheCampo(TarifasMaterialLineas.TML_idacreedor, "=", IdAcreedor)

       

        Dim sql As String = CONSULTA.SQL & vbCrLf & " ORDER BY TML_IdLinea"
        Return TarifasMaterial.MiConexion.ConsultaSQL(Sql)

    End Function


End Class
