Public Class Listado_ConsumoMaterialesComparativo
    Inherits Listado_ImpresionBase


    Property Dt As DataTable
    Property FamEnvaseDesde As String
    Property FamEnvaseHasta As String
    Property FechaDesde As String
    Property FechaHasta As String
    Property Centros As List(Of String)
    Property DetallarMarcas As Boolean
    Property TipoImpresion As TipoImpresion


    Public Sub New(ByVal dt As DataTable, ByVal famEnvaseDesde As String, ByVal famEnvaseHasta As String, _
                   ByVal fechaDesde As String, ByVal fechaHasta As String, centros As List(Of String), detallarMarcas As Boolean,
                   ByVal TipoImpresion As TipoImpresion)
        Me.Dt = dt
        Me.FamEnvaseDesde = famEnvaseDesde
        Me.FamEnvaseHasta = famEnvaseHasta
        Me.FechaDesde = fechaDesde
        Me.FechaHasta = fechaHasta
        Me.Centros = centros
        Me.DetallarMarcas = detallarMarcas
        Me.TipoImpresion = TipoImpresion
    End Sub


    Dim Texto As String = ""
    Dim Formato As String = ""
    Dim Formato2 As String = ""
    Dim AnchoPagina As Integer = 185
    Dim Ancho As Integer = AnchoPagina


    Public Overrides Sub ImprimirListado()

        MargenIzq = 13
        Ancho = AnchoPagina - MargenIzq - MargenDer
        EstableceListado(Orientacion.Vertical, TipoImpresion)

        Try

            ConfiguraListado()
            Previsualiza()

        Catch ex As Exception

        End Try

        
    End Sub

    Private Sub ConfiguraListado()

        
        Dim listaCentros As String = ObtenerListaFiltros(Centros)

        Texto = MiMaletin.NombreEmpresa
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.Cabecera)

        Texto = "Consumo de materiales por fecha - Comparativo"
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.GrandeBold)

        If Len(FamEnvaseDesde.Trim) > 0 Or Len(FamEnvaseHasta.Trim) > 0 Then
            Texto = "Desde Familia Env. " & FamEnvaseDesde & " hasta Familia Env. " & FamEnvaseHasta & "|Fecha Impresión: " & Today.ToString("dd/MM/yyyy")
            Formato = (Ancho - 80).ToString & "|>80"
            Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)
        End If

        If Len(FechaDesde.Trim) > 0 Or Len(FechaHasta.Trim) > 0 Then
            Texto = "Desde Fecha " & FechaDesde & " hasta Fecha " & FechaHasta
            Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)
        End If

        If Len(listaCentros.Trim) > 0 Then
            Texto = "Centros: " & listaCentros
            Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)
        End If

        If DetallarMarcas Then
            Texto = "Detallar marcas"
            Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)
        End If

        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Normal)


        'Detalle
        Formato = "11|42|22|>20|>20|>15|>20|>20|>15"
        Formato2 = "40|252|>77|>77|>55|>77|>77|>55"

        If DetallarMarcas Then
            Texto = "Cod|Material|Marca|CantComp|ImpComp|P.M.C.|UnidsSal|ImpSal|P.M.S."
            Listado.Cabecera.Linea(Texto, Formato, Estilos.ReducidaBoldLineaDebajo)
        Else
            Texto = "Cod|Material|CantComp|ImpComp|P.M.C.|UnidsSal|ImpSal|P.M.S."
            Listado.Cabecera.Linea(Texto, Formato2, Estilos.ReducidaBoldLineaDebajo)
        End If

        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.ReducidaBoldLineaEncima)

        Dim famEnvaseActual As String = ""

        Dim listaCampos As New List(Of String)
        listaCampos.Add("comp")
        listaCampos.Add("impcomp")
        listaCampos.Add("sal")
        listaCampos.Add("impsal")

        Dim totalFam As New AcumuladorTotales(listaCampos)
        Dim total As New AcumuladorTotales(listaCampos)

        For Each r As DataRow In Dt.Rows

            Dim FamiliaEnvase As String = (r("NombreFamilia").ToString & "").Trim
            Dim CodEnv As String = VaInt(r("IdEnvase")).ToString("00000")
            Dim Envase As String = r("Envase").ToString & ""
            Dim Comp As Decimal = VaDec(r("CantComp"))
            Dim ImpComp As Decimal = VaDec(r("ImpComp"))
            Dim PMC As Decimal = VaDec(r("PMC"))
            Dim Sal As Decimal = VaDec(r("UnidsSal"))
            Dim ImpSal As Decimal = VaDec(r("ImpSal"))
            Dim PMS As Decimal = VaDec(r("PMS"))

            If Not famEnvaseActual.Equals(FamiliaEnvase) Then
                If Len(famEnvaseActual) > 0 Then
                    'Total Familia
                    Texto = "|TOTALES FAMILIA...||"
                    Texto = Texto & totalFam.GetValor("comp").ToString("#,##0.00") & "|"
                    Texto = Texto & totalFam.GetValor("impcomp").ToString("#,##0.00") & "||"
                    Texto = Texto & totalFam.GetValor("sal").ToString("#,##0.00") & "|"
                    Texto = Texto & totalFam.GetValor("impsal").ToString("#,##0.00") & "||"
                    Listado.Detalle.Linea(Texto, Formato, Estilos.ReducidaBoldLineaEncima)
                    Listado.Detalle.Linea("", Ancho.ToString, Estilos.NormalBold)

                    totalFam.ReiniciarValores()
                End If

                'Titulo Familia
                Listado.Detalle.Linea(FamiliaEnvase, Ancho.ToString, Estilos.NormalBold)
            End If

            Texto = CodEnv & "|"
            Texto = Texto & Envase & "|"

            If DetallarMarcas Then
                Texto = Texto & r("Marca").ToString
            End If

            Texto = Texto & "|"
            Texto = Texto & Comp.ToString("#,##0.00") & "|"
            Texto = Texto & ImpComp.ToString("#,##0.00") & "|"
            Texto = Texto & PMC.ToString("#,##0.00000") & "|"
            Texto = Texto & Sal.ToString("#,##0.00") & "|"
            Texto = Texto & ImpSal.ToString("#,##0.00") & "|"
            Texto = Texto & PMS.ToString("#,##0.00000")
            Listado.Detalle.Linea(Texto, Formato, Estilos.Reducida)

            Dim listaValores As New List(Of Decimal)
            listaValores.Add(Comp)
            listaValores.Add(ImpComp)
            listaValores.Add(Sal)
            listaValores.Add(ImpSal)

            totalFam.Suma(listaValores)
            total.Suma(listaValores)

            famEnvaseActual = FamiliaEnvase

            Application.DoEvents()

        Next

        'Último Total Familia
        Texto = "|TOTALES FAMILIA...||"
        Texto = Texto & totalFam.GetValor("comp").ToString("#,##0.00") & "|"
        Texto = Texto & totalFam.GetValor("impcomp").ToString("#,##0.00") & "||"
        Texto = Texto & totalFam.GetValor("sal").ToString("#,##0.00") & "|"
        Texto = Texto & totalFam.GetValor("impsal").ToString("#,##0.00") & "||"
        Listado.Detalle.Linea(Texto, Formato, Estilos.ReducidaBoldLineaEncima)
        Listado.Detalle.Linea("", Ancho.ToString, Estilos.NormalBold)

        'Gran total
        Texto = "|TOTALES...||"
        Texto = Texto & total.GetValor("comp").ToString("#,##0.00") & "|"
        Texto = Texto & total.GetValor("impcomp").ToString("#,##0.00") & "||"
        Texto = Texto & total.GetValor("sal").ToString("#,##0.00") & "|"
        Texto = Texto & total.GetValor("impsal").ToString("#,##0.00") & "||"
        Listado.Detalle.Linea(Texto, Formato, Estilos.ReducidaBoldLineaEncima)
        Listado.Detalle.Linea("", Ancho.ToString, Estilos.NormalBold)
    End Sub

    
End Class
