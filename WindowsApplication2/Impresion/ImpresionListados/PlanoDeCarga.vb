Public Class PlanoDeCarga
    Inherits Listado_ImpresionBase


    Property Datos As DataTable = Nothing
    Property IdAlbaran As String = ""
    Property AlbSalida As New E_AlbSalida(Idusuario, cn)



    Public Sub New(ByVal IdAlbaran As String)

        Me.IdAlbaran = IdAlbaran

        If AlbSalida.LeerId(IdAlbaran) Then


            Dim sql As String = "SELECT PAL_Palet as Palet, GES_Nombre as Presentacion, CAS_CategoriaCalibre as Categoria, PAL_Lote as Lote," & vbCrLf
            sql = sql & " PLL_Bultos as Bultos, PLL_kilosnetos as Kilos, COALESCE(PLL_bultos * PLL_piezasxbulto,0) as Piezas" & vbCrLf
            sql = sql & " FROM AlbSalida_Palets" & vbCrLf
            sql = sql & " LEFT JOIN Palets ON PAL_IdPalet = ASP_IdPalet" & vbCrLf
            sql = sql & " LEFT JOIN Palets_Lineas ON PLL_IdPalet = PAL_IdPalet" & vbCrLf
            sql = sql & " LEFT JOIN GenerosSalida ON GES_idgensal = PLL_IdGenSal" & vbCrLf
            sql = sql & " LEFT JOIN CategoriasSalida ON CAS_id = PLL_IdCategoria" & vbCrLf
            sql = sql & " WHERE ASP_IdAlbaran = " & IdAlbaran & vbCrLf
            sql = sql & " ORDER BY ASP_Id" & vbCrLf

            Datos = AlbSalida.MiConexion.ConsultaSQL(sql)

        Else
            MsgBox("Error al leer el albarán con Id: " & IdAlbaran)
        End If

    End Sub


    Public Overrides Sub ImprimirListado()

        MargenSup = 10
        MargenIzq = 10
        EstableceListado(Orientacion.Horizontal, TipoImpresion.Preliminar)

        Try

            ConfigurarListado()
            Previsualiza()

        Catch ex As Exception

        End Try
        

    End Sub


    Public Overloads Sub ImprimirListado(bPreliminar As Boolean)

        If bPreliminar Then
            ImprimirListado()
        Else

            MargenSup = 10
            MargenIzq = 10
            EstableceListado(Orientacion.Horizontal, TipoImpresion.ImpresoraPorDefecto)

            Try

                ConfigurarListado()
                ImprimeDirecto()

            Catch ex As Exception

            End Try
            

        End If



    End Sub


    Private Sub ConfigurarListado()
        Dim PuntoVenta As String = ""


        If (AlbSalida.ASA_idalbaran.Valor) > 0 Then


            Dim Albaran As String = (AlbSalida.ASA_idcentro.Valor & "").Trim & "-" & AlbSalida.ASA_albaran.Valor
            Dim RefCliente As String = (AlbSalida.ASA_referencia.Valor & "").Trim
            Dim Matricula As String = (AlbSalida.ASA_matricularemolque.Valor & "").Trim

            'Cabecera
            Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "270", Estilos.Cabecera)
            Listado.Cabecera.Linea(" ", "270", Estilos.NormalBold)
            Listado.Cabecera.Linea("Plano de Carga del Albarán " & Albaran & "|Fecha: " & Now.ToString("dd/MM/yyyy"), "210|>60", Estilos.GrandeBold)
            Listado.Cabecera.Linea(" ", "270", Estilos.NormalBold)
            Listado.Cabecera.Linea("Referencia cliente: " & RefCliente, "270", Estilos.GrandeBold)
            Listado.Cabecera.Linea("Matricula: " & Matricula, "270", Estilos.GrandeBold)
            Listado.Cabecera.Linea(" ", "270", Estilos.NormalBold)
            Listado.Cabecera.Linea(" ", "270", Estilos.NormalBold)

            'Detalle
            Dim DLin As String = ">13|2|27|2|70|2|41|2|14|2|>27|>34|>34"
            Dim DLinTotal As String = ">13|2|27|2|131|>27|>34|>34"
            Dim Cabecera As String = "Orden||Palet||Presentación||Cat/Cal||Lote||Bultos|Kilos|Piezas"
            Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
            Listado.Cabecera.Linea("", "270", Estilos.ReducidaBold)

            Dim TotalBultos As Integer = 0
            Dim TotalKgNetos As Decimal = 0
            Dim TotalPiezas As Decimal = 0



            Dim Orden As Integer = 1

            For Each row As DataRow In Datos.Rows

                Dim Palet As String = (row("Palet").ToString & "").Trim
                Dim Presentacion As String = (row("Presentacion").ToString & "").Trim
                Dim Categoria As String = (row("Categoria").ToString & "").Trim
                Dim Lote As String = (row("Lote").ToString & "").Trim
                Dim Bultos As Integer = VaInt(row("Bultos"))
                Dim KgNetos As Decimal = VaDec(row("Kilos"))
                Dim Piezas As Integer = VaInt(row("Piezas"))


                'Líneas de listado
                Dim det As String = Orden.ToString & "||"
                det = det & Palet & "||"
                det = det & Presentacion & "||"
                det = det & Categoria & "||"
                det = det & Lote & "||"
                det = det & Bultos.ToString("#,##0") & "|"
                det = det & KgNetos.ToString("#,##0") & "|"
                det = det & Piezas.ToString("#,##0")
                Listado.Detalle.Linea(det, DLin, Estilos.Reducida)


                TotalBultos = TotalBultos + Bultos
                TotalKgNetos = TotalKgNetos + KgNetos
                TotalPiezas = TotalPiezas + Piezas

                Orden = Orden + 1


                Application.DoEvents()

            Next


            'Total
            Listado.Detalle.Linea("", "270", Estilos.ReducidaBoldLineaDebajo)
            Listado.Detalle.Linea("||||TOTAL|" & _
                                  TotalBultos.ToString("#,##0") & "|" & _
                                  TotalKgNetos.ToString("#,##0") & "|" & _
                                  TotalPiezas.ToString("#,##0"), DLinTotal, Estilos.NormalBoldLineaDebajo)
            Listado.Detalle.Linea("", "270", Estilos.ReducidaBold)


        Else
            MsgBox("Error al leer el albarán con Id: " & IdAlbaran)
        End If




    End Sub




End Class
