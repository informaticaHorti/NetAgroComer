Public Class Listado_InventarioMateriales
    Inherits Listado_ImpresionBase


    Property Dt As DataTable
    Property FechaDesde As String
    Property FechaHasta As String
    Property Marcas As Boolean
    Property Almacenes As List(Of String)
    Property Familias As List(Of String)
    Property TipoImpresion As TipoImpresion


    Dim Texto As String = ""
    Dim Formato As String = ""
    Dim FormatoTotales As String = ""
    Dim AnchoPagina As Integer = 297
    Dim Ancho As Integer = AnchoPagina


    Public Sub New(ByVal dt As DataTable, ByVal fechaDesde As String, ByVal fechaHasta As String, ByVal marcas As Boolean, _
                   ByVal almacenes As List(Of String), ByVal familias As List(Of String), ByVal TipoImpresion As TipoImpresion)
        Me.Dt = dt
        Me.FechaDesde = fechaDesde
        Me.FechaHasta = fechaHasta
        Me.Marcas = marcas
        Me.Almacenes = almacenes
        Me.Familias = familias
        Me.TipoImpresion = TipoImpresion
    End Sub


    Public Overrides Sub ImprimirListado()

        MargenIzq = 5
        MargenDer = 8
        MargenSup = 13
        MargenInf = 13
        Ancho = AnchoPagina - MargenIzq - MargenDer

        EstableceListado(Orientacion.Horizontal, TipoImpresion)

        Try

            ConfigurarListado()
            Previsualiza()

        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub ConfigurarListado()
        

        ImprimeCabecera()

        Dim listaTotales As New List(Of String)
        listaTotales.Add("ExistIni")
        listaTotales.Add("ValIni")
        listaTotales.Add("UdsCom")
        listaTotales.Add("ValCom")
        listaTotales.Add("MovEnv")
        listaTotales.Add("Consum")
        listaTotales.Add("ExPalets")
        listaTotales.Add("Exist")
        listaTotales.Add("Recuento")
        listaTotales.Add("Difer")
        listaTotales.Add("ValExist")
        listaTotales.Add("ValRec")

        Dim totalFamilia As New AcumuladorTotales(listaTotales)

        ImprimeDetalle(totalFamilia)
    End Sub

    Private Sub ImprimeCabecera()
        Dim empresa As String = MiMaletin.NombreEmpresa
        Dim titulo As String = "Inventario de materiales por fecha"
        Dim listaAlmacenes As String = MetodosComunesListados.ObtenerListaFiltros(Almacenes)
        Dim listaFamilias As String = MetodosComunesListados.ObtenerListaFiltros(Familias)

        If Not Dt.Columns.Contains("IdMarca") Then
            Marcas = False
        End If

        Texto = empresa
        Formato = Ancho.ToString
        Listado.Cabecera.Linea(Texto, Formato, Estilos.Cabecera)

        Texto = "Inventario de materiales por fecha "
        Formato = Ancho.ToString
        Listado.Cabecera.Linea(Texto, Formato, Estilos.GrandeBold)

        Texto = "Almacén: " & listaAlmacenes & "| Fecha impresión: " & Today.ToString("dd/MM/yyyy")
        Dim anchoIzq As Integer = Ancho - 80
        Formato = anchoIzq.ToString & "|>80"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)

        Texto = "Desde " & FechaDesde & " hasta " & FechaHasta
        Formato = Ancho.ToString
        Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)

        If Len(listaFamilias.Trim) > 0 Then
            Texto = "Familias: " & listaFamilias
            Formato = Ancho.ToString
            Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)
        End If

        If Marcas Then
            Texto = "Mostrar marcas"
            Formato = Ancho.ToString
            Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)
        End If

        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Normal)

        If Marcas Then
            Texto = " Cod | Material | Marca | ExistIni | ValIni | UdsCom | ValCom | MovEnv | Consum | ExPalets | "
            Texto = Texto & "Exist | Recuento | Difer | P.M.C. | ValExist | ValRec"
            Formato = "13|35|15|>15|>17|>17|>17|>15|>17|>18|>15|>18|>18|>18|>18|>18"
        Else
            Texto = "Cod | Material | ExistIni | ValIni | UdsCom | ValCom | MovEnv | Consum | ExPalets | "
            Texto = Texto & "Exist | Recuento | Difer | P.M.C. | ValExist | ValRec"
            Formato = "13|50|>15|>17|>17|>17|>15|>17|>18|>15|>18|>18|>18|>18|>18"
        End If

        FormatoTotales = "62|>15|>17|>17|>17|>15|>18|>18|>15|>18|>18|>18|>18|>18"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.MinimaBoldLineaDebajo)
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Minima)
    End Sub

    Private Sub ImprimeDetalle(ByRef totalFamilia As AcumuladorTotales)
        Dim famActual As String = ""
        Dim primera As Boolean = True

        For Each r As DataRow In Dt.Rows

            Dim familia As String = r("FamiliaEnvase").ToString
            Dim idEnvase As String = VaInt(r("IdEnvase")).ToString("00000")
            Dim envase As String = r("Envase").ToString
            Dim marca As String = ""
            If Marcas Then marca = r("Marca").ToString
            Dim existIni As Decimal = VaDec(r("ExistIni"))
            Dim valIni As Decimal = VaDec(r("ValIni"))
            Dim udsCom As Decimal = VaDec(r("UdsCom"))
            Dim valCom As Decimal = VaDec(r("ValCom"))
            Dim movEnv As Decimal = VaDec(r("MovEnv"))
            Dim consum As Decimal = VaDec(r("Consum"))
            Dim exPalets As Decimal = VaDec(r("ExPalets"))
            Dim exist As Decimal = VaDec(r("Exist"))
            Dim recuento As Decimal = VaDec(r("Recuento"))
            Dim difer As Decimal = VaDec(r("Difer"))
            Dim valExist As Decimal = VaDec(r("ValExist"))
            Dim valRec As Decimal = VaDec(r("ValRec"))
            Dim pmc As Decimal = VaDec(r("PMC"))


            If Not familia.Equals(famActual) Then
                If Not primera Then
                    Texto = "|" & totalFamilia.GetValor("ExistIni").ToString("#,##0.00") & "|"
                    Texto = Texto & totalFamilia.GetValor("ValIni").ToString("#,##0.00") & "|"
                    Texto = Texto & totalFamilia.GetValor("UdsCom").ToString("#,##0.00") & "|"
                    Texto = Texto & totalFamilia.GetValor("ValCom").ToString("#,##0.00") & "|"
                    Texto = Texto & totalFamilia.GetValor("MovEnv").ToString("#,##0.00") & "|"
                    Texto = Texto & totalFamilia.GetValor("Consum").ToString("#,##0.00") & "|"
                    Texto = Texto & totalFamilia.GetValor("ExPalets").ToString("#,##0.00") & "|"
                    Texto = Texto & totalFamilia.GetValor("Exist").ToString("#,##0.00") & "|"
                    Texto = Texto & totalFamilia.GetValor("Recuento").ToString("#,##0.00") & "|"
                    Texto = Texto & totalFamilia.GetValor("Difer").ToString("#,##0.00") & "||"
                    Texto = Texto & totalFamilia.GetValor("ValExist").ToString("#,##0.00") & "|"
                    Texto = Texto & totalFamilia.GetValor("ValRec").ToString("#,##0.00")

                    Listado.Detalle.Linea(Texto, FormatoTotales, Estilos.MinimaBoldLineaEncima)
                    Listado.Detalle.Linea("", Ancho.ToString, Estilos.NormalBold)

                    totalFamilia.ReiniciarValores()
                End If

                Texto = familia
                Listado.Detalle.Linea(Texto, Ancho.ToString, Estilos.GrandeBold)
            End If

            Texto = idEnvase & "|"
            Texto = Texto & envase & "|"
            If Marcas Then Texto = Texto & marca & "|"
            Texto = Texto & existIni.ToString("#,##0.00") & "|"
            Texto = Texto & valIni.ToString("#,##0.00") & "|"
            Texto = Texto & udsCom.ToString("#,##0.00") & "|"
            Texto = Texto & valCom.ToString("#,##0.00") & "|"
            Texto = Texto & movEnv.ToString("#,##0.00") & "|"
            Texto = Texto & consum.ToString("#,##0.00") & "|"
            Texto = Texto & exPalets.ToString("#,##0.00") & "|"
            Texto = Texto & exist.ToString("#,##0.00") & "|"
            Texto = Texto & recuento.ToString("#,##0.00") & "|"
            Texto = Texto & difer.ToString("#,##0.00") & "|"
            Texto = Texto & pmc.ToString("#,##0.000000") & "|"
            Texto = Texto & valExist.ToString("#,##0.00") & "|"
            Texto = Texto & valRec.ToString("#,##0.00")
            Listado.Detalle.Linea(Texto, Formato, Estilos.Minima)

            Dim listaValores As New List(Of Decimal)
            listaValores.Add(existIni)
            listaValores.Add(valIni)
            listaValores.Add(udsCom)
            listaValores.Add(valCom)
            listaValores.Add(movEnv)
            listaValores.Add(consum)
            listaValores.Add(exPalets)
            listaValores.Add(exist)
            listaValores.Add(recuento)
            listaValores.Add(difer)
            listaValores.Add(valExist)
            listaValores.Add(valRec)

            totalFamilia.Suma(listaValores)

            famActual = familia
            primera = False


            Application.DoEvents()

        Next

        Texto = "|" & totalFamilia.GetValor("ExistIni").ToString("#,##0.00") & "|"
        Texto = Texto & totalFamilia.GetValor("ValIni").ToString("#,##0.00") & "|"
        Texto = Texto & totalFamilia.GetValor("UdsCom").ToString("#,##0.00") & "|"
        Texto = Texto & totalFamilia.GetValor("ValCom").ToString("#,##0.00") & "|"
        Texto = Texto & totalFamilia.GetValor("MovEnv").ToString("#,##0.00") & "|"
        Texto = Texto & totalFamilia.GetValor("Consum").ToString("#,##0.00") & "|"
        Texto = Texto & totalFamilia.GetValor("ExPalets").ToString("#,##0.00") & "|"
        Texto = Texto & totalFamilia.GetValor("Exist").ToString("#,##0.00") & "|"
        Texto = Texto & totalFamilia.GetValor("Recuento").ToString("#,##0.00") & "|"
        Texto = Texto & totalFamilia.GetValor("Difer").ToString("#,##0.00") & "||"
        Texto = Texto & totalFamilia.GetValor("ValExist").ToString("#,##0.00") & "|"
        Texto = Texto & totalFamilia.GetValor("ValRec").ToString("#,##0.00")

        Listado.Detalle.Linea(Texto, FormatoTotales, Estilos.MinimaBoldLineaEncima)
        Listado.Detalle.Linea("", Ancho.ToString, Estilos.NormalBold)

        Dim TotalExistIni As Decimal = VaDec(Dt.Compute("SUM(ExistIni)", ""))
        Dim TotalValIni As Decimal = VaDec(Dt.Compute("SUM(ValIni)", ""))
        Dim TotalUdsCom As Decimal = VaDec(Dt.Compute("SUM(UdsCom)", ""))
        Dim TotalValCom As Decimal = VaDec(Dt.Compute("SUM(ValCom)", ""))
        Dim TotalMovEnv As Decimal = VaDec(Dt.Compute("SUM(MovEnv)", ""))
        Dim TotalConsum As Decimal = VaDec(Dt.Compute("SUM(Consum)", ""))
        Dim TotalExPalets As Decimal = VaDec(Dt.Compute("SUM(ExPalets)", ""))
        Dim TotalExist As Decimal = VaDec(Dt.Compute("SUM(Exist)", ""))
        Dim TotalRecuento As Decimal = VaDec(Dt.Compute("SUM(Recuento)", ""))
        Dim TotalDifer As Decimal = VaDec(Dt.Compute("SUM(Difer)", ""))

        Dim TotalValExist As Decimal = VaDec(Dt.Compute("SUM(ValExist)", ""))
        Dim TotalValRec As Decimal = VaDec(Dt.Compute("SUM(ValRec)", ""))


        Dim PMC_Medio As Decimal = 0
        If TotalExistIni + TotalUdsCom <> 0 Then PMC_Medio = (TotalValIni + TotalValCom) / (TotalExistIni + TotalUdsCom)

        Texto = "|" & TotalExistIni.ToString("#,##0.00") & "|"
        Texto = Texto & TotalValIni.ToString("#,##0.00") & "|"
        Texto = Texto & TotalUdsCom.ToString("#,##0.00") & "|"
        Texto = Texto & TotalValCom.ToString("#,##0.00") & "|"
        Texto = Texto & TotalMovEnv.ToString("#,##0.00") & "|"
        Texto = Texto & TotalConsum.ToString("#,##0.00") & "|"
        Texto = Texto & TotalExPalets.ToString("#,##0.00") & "|"
        Texto = Texto & TotalExist.ToString("#,##0.00") & "|"
        Texto = Texto & TotalRecuento.ToString("#,##0.00") & "|"
        Texto = Texto & TotalDifer.ToString("#,##0.00") & "|"
        Texto = Texto & PMC_Medio.ToString("#,##0.000000") & "|"
        Texto = Texto & TotalValExist.ToString("#,##0.00") & "|"
        Texto = Texto & TotalValRec.ToString("#,##0.00")

        Listado.Detalle.Linea(Texto, FormatoTotales, Estilos.MinimaBoldLineaEncima)
    End Sub


End Class
