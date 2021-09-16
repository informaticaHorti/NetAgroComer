Public Class Listado_CargaPalets
    Inherits Listado_ImpresionBase


    Property Datos As DataTable = Nothing
    Property IdAlbaran As String = ""
    Property AlbSalida As New E_AlbSalida(Idusuario, cn)



    Public Sub New(ByVal IdAlbaran As String)

        Me.IdAlbaran = IdAlbaran
        If AlbSalida.LeerId(IdAlbaran) Then


            Dim sql As String = "SELECT ASP_Id, ASP_IdPalet as IdPalet, PAL_IdCentro as CE, PAL_Palet as Palet, PAL_Fecha as Fecha," & vbCrLf
            sql = sql & " CPA_Nombre as TipoPalet, GEN_NombreGenero as Genero, CEV_Nombre as Confeccion, PLL_Categoria as Categoria," & vbCrLf
            sql = sql & " MAR_Nombre as Marca, AEN_Albaran as EntConf, PLL_Bultos as Bultos, PLL_KilosNetos as Knetos, PLL_KilosCliente as Kcliente" & vbCrLf
            sql = sql & " FROM AlbSalida_Palets" & vbCrLf
            sql = sql & " LEFT JOIN Palets ON PAL_IdPalet= ASP_IdPalet" & vbCrLf
            sql = sql & " LEFT JOIN ConfecPalet ON PAL_IdTipoPalet = CPA_IdConfec" & vbCrLf
            sql = sql & " LEFT JOIN Palets_Lineas ON PAL_IdPalet = PLL_IdPalet" & vbCrLf
            sql = sql & " LEFT JOIN AlbEntrada_Lineas ON AEL_IdLinea = PLL_IdLineaEntradaConfeccionada" & vbCrLf
            sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
            sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = PLL_IdGenero" & vbCrLf
            sql = sql & " LEFT JOIN ConfecEnvase ON CEV_IdConfec = PLL_IdTipoConfeccion" & vbCrLf
            sql = sql & " LEFT JOIN Marcas ON MAR_IdMarca = PLL_IdMarca" & vbCrLf
            sql = sql & " WHERE ASP_IdAlbaran = " & IdAlbaran & vbCrLf

            Datos = AlbSalida.MiConexion.ConsultaSQL(sql)

        Else
            MsgBox("Error al leer el albarán con Id: " & IdAlbaran)
        End If

    End Sub



    Public Overrides Sub ImprimirListado()

        MargenSup = 10
        MargenIzq = 10

        EstableceListado(Orientacion.Vertical, TipoImpresion.Preliminar)

        Try
            ConfigurarListado()
        Catch ex As Exception

        End Try


        Previsualiza()

    End Sub


    Public Overloads Sub ImprimirListado(bPreliminar As Boolean)

        If bPreliminar Then

            ImprimirListado()

        Else

            MargenSup = 10
            MargenIzq = 10


            Dim TipoImpresion As TipoImpresion = TipoImpresion.Preliminar
            If Not bPreliminar Then TipoImpresion = NetAgro.TipoImpresion.ImpresoraPorDefecto

            EstableceListado(Orientacion.Vertical, TipoImpresion)

            Try
                ConfigurarListado()
            Catch ex As Exception

            End Try

            ImprimeDirecto()

        End If
    End Sub


    Private Sub ConfigurarListado()


        Dim PuntoVenta As String = ""


        If (AlbSalida.ASA_idalbaran.Valor) > 0 Then


            Dim Albaran As String = (AlbSalida.ASA_idcentro.Valor & "").Trim & "-" & AlbSalida.ASA_albaran.Valor

            'Cabecera
            Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "190", Estilos.Cabecera)
            Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
            Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
            Listado.Cabecera.Linea("Carga de palets del Albarán " & Albaran & "|Fecha: " & Now.ToString("dd/MM/yyyy"), "130|>60", Estilos.GrandeBold)
            Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
            Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)

            'Detalle
            Dim DLin As String = "28|2|33|2|18|2|23|2|20|>20|>20|>20"
            Dim DLinTotal As String = "130|>20|>20|>20"
            Dim Cabecera As String = "Genero||Confeccion||Categ||Marca||EntConf|Bultos|KgNetos|KgCliente"
            Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
            Listado.Cabecera.Linea("", "180", Estilos.ReducidaBold)

            Dim TotalBultos As Integer = 0
            Dim TotalKgNetos As Decimal = 0
            Dim TotalKgCliente As Decimal = 0
            Dim TotalBultosPal As Integer = 0
            Dim TotalKgNetosPal As Decimal = 0
            Dim TotalKgClientePal As Decimal = 0



            Dim AuxIdPalet As String = ""
            Dim AuxPalet As String = ""


            For Each row As DataRow In Datos.Rows

                Dim IdPalet As String = (row("IdPalet").ToString & "").Trim
                Dim IdCentro As String = (row("CE").ToString & "").Trim
                Dim Palet As String = (row("Palet").ToString & "").Trim
                Dim TipoPalet As String = (row("TipoPalet").ToString & "").Trim
                Dim Fecha As String = ""
                If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
                Dim Genero As String = (row("Genero").ToString & "").Trim
                Dim Confeccion As String = (row("Confeccion").ToString & "").Trim
                Dim Categoria As String = (row("Categoria").ToString & "").Trim
                Dim Marca As String = (row("Marca").ToString & "").Trim
                Dim EntConf As String = (row("EntConf").ToString & "").Trim
                Dim Bultos As Integer = VaInt(row("Bultos"))
                Dim KgNetos As Decimal = VaDec(row("KNetos"))
                Dim KgCliente As Decimal = VaDec(row("KCliente"))


                Dim bCambioPalet As Boolean = IdPalet <> AuxIdPalet

                'Cambio de Palet
                If bCambioPalet Then

                    If AuxIdPalet <> "" Then

                        'Resumen palet anterior
                        Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
                        Listado.Detalle.Linea("TOTAL PALET|" & _
                                              TotalBultosPal.ToString("#,##0") & "|" & _
                                              TotalKgNetosPal.ToString("#,##0") & "|" & _
                                              TotalKgClientePal.ToString("#,##0"), DLinTotal, Estilos.NormalBold)
                        Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)
                        Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

                        TotalBultosPal = 0
                        TotalKgNetosPal = 0
                        TotalKgClientePal = 0

                    End If


                    'Nuevo palet
                    Dim CadenaPalet As String = "PALET " & IdCentro & "-" & Palet & " | " & Fecha & " | " & TipoPalet
                    Listado.Detalle.Linea(CadenaPalet, "55|35|100", Estilos.GrandeBold)

                End If



                'Líneas de listado
                Dim det As String = Genero & "||"
                det = det & Confeccion & "||"
                det = det & Categoria & "||"
                det = det & Marca & "||"
                det = det & EntConf & "|"
                det = det & Bultos.ToString("#,##0") & "|"
                det = det & KgNetos.ToString("#,##0") & "|"
                det = det & KgCliente.ToString("#,##0")
                Listado.Detalle.Linea(det, DLin, Estilos.Reducida)


                TotalBultos = TotalBultos + Bultos
                TotalKgNetos = TotalKgNetos + KgNetos
                TotalKgCliente = TotalKgCliente + KgCliente
                TotalBultosPal = TotalBultosPal + Bultos
                TotalKgNetosPal = TotalKgNetosPal + KgNetos
                TotalKgClientePal = TotalKgClientePal + KgCliente


                AuxIdPalet = IdPalet
                AuxPalet = Palet


                Application.DoEvents()

            Next

            'Último resumen palet
            Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
            Listado.Detalle.Linea("TOTAL PALET|" & _
                                  TotalBultosPal.ToString("#,##0") & "|" & _
                                  TotalKgNetosPal.ToString("#,##0") & "|" & _
                                  TotalKgClientePal.ToString("#,##0"), DLinTotal, Estilos.NormalBold)
            Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)
            Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)

            'Total
            Listado.Detalle.Linea("", "190", Estilos.ReducidaBoldLineaDebajo)
            Listado.Detalle.Linea("TOTAL LISTADO|" & _
                                  TotalBultos.ToString("#,##0") & "|" & _
                                  TotalKgNetos.ToString("#,##0") & "|" & _
                                  TotalKgCliente.ToString("#,##0"), DLinTotal, Estilos.NormalBoldLineaDebajo)
            Listado.Detalle.Linea("", "190", Estilos.ReducidaBold)


        Else
            MsgBox("Error al leer el albarán con Id: " & IdAlbaran)
        End If




    End Sub




End Class
