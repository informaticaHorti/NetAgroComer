Public Class Listado_ConsultaListadoGenerosSalidas
    Inherits Listado_ImpresionBase


    Property Dt As DataTable
    Property Genero As String
    Property SoloActivos As Boolean



    Dim Texto As String = ""
    Dim Formato As String = ""
    Dim FormatoTotales As String = ""
    Dim AnchoPagina As Integer = 297
    Dim Ancho As Integer = AnchoPagina
    Dim TipoImpresion As TipoImpresion


    Public Sub New(ByVal dt As DataTable, ByVal genero As String, soloActivos As Boolean, TipoImpresion As TipoImpresion)
        Me.Dt = dt
        Me.Genero = genero
        Me.SoloActivos = soloActivos
        Me.TipoImpresion = TipoImpresion
    End Sub



    Public Overrides Sub ImprimirListado()

        MargenIzq = 5
        EstableceListado(Orientacion.Horizontal, TipoImpresion)
        Ancho = AnchoPagina - MargenDer - MargenIzq

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

        Texto = MiMaletin.NombreEmpresa
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.Cabecera)

        Texto = "Listado Generos Salidas"
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.GrandeBold)

        Texto = "Genero: " & Genero & "|Fecha Impresión: " & Today.ToString("dd/MM/yyyy")
        Formato = (Ancho - 80).ToString & "|>80"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)

        If SoloActivos Then
            Texto = "SOLO ACTIVOS"
            Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)
        End If

        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Normal)

        Texto = "CodGen | Genero | CodConf | Confeccion | Presentacion | SobreC | KxB | MatxBul | ConxBul | "
        Texto = Texto & "EstxBul | TotxBul | MatxKil | ConxKil | EstxKil | TotxKil"
        Formato = "10|28|10|50|50|>14|>14|>14|>15|>15|>15|>15|>15|>15"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.MinimaBoldLineaDebajo)
        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Minima)

    End Sub

    Private Sub ConfiguraDetalle()


        For Each r As DataRow In Dt.Rows

            Dim IdGenero As String = VaInt(r("Genero")).ToString("00000")
            Dim NombreGenero As String = (r("Nombregenero").ToString & "").Trim
            Dim IdConfec As String = VaInt(r("IdConfec")).ToString("00000")
            Dim Confeccion As String = (r("Confeccion").ToString & "").Trim
            Dim Presentacion As String = (r("Presentacion").ToString & "").Trim
            Dim sobrec As Decimal = VaDec(r("SobreC"))
            Dim kxb As Decimal = VaDec(r("KxB"))
            Dim matxbul As Decimal = VaDec(r("MatxBul"))
            Dim conxbul As Decimal = VaDec(r("ConxBul"))
            Dim estxbul As Decimal = VaDec(r("EstxBul"))
            Dim totxbul As Decimal = VaDec(r("TotxBul"))
            Dim matxkil As Decimal = VaDec(r("MatxKil"))
            Dim conxkil As Decimal = VaDec(r("ConxKil"))
            Dim estxkil As Decimal = VaDec(r("EstxKil"))
            Dim totxkil As Decimal = VaDec(r("TotxKil"))

            Texto = IdGenero & "|"
            Texto = Texto & NombreGenero & "|"
            Texto = Texto & IdConfec & "|"
            Texto = Texto & Confeccion & "|"
            Texto = Texto & Presentacion & "|"
            Texto = Texto & sobrec.ToString("#,##0.00") & "|"
            Texto = Texto & kxb.ToString("#,##0.00") & "|"
            Texto = Texto & matxbul.ToString("#,##0.00") & "|"
            Texto = Texto & conxbul.ToString("#,##0.00") & "|"
            Texto = Texto & estxbul.ToString("#,##0.00") & "|"
            Texto = Texto & totxbul.ToString("#,##0.00") & "|"
            Texto = Texto & matxkil.ToString("#,##0.00") & "|"
            Texto = Texto & conxkil.ToString("#,##0.00") & "|"
            Texto = Texto & estxkil.ToString("#,##0.00") & "|"
            Texto = Texto & totxkil.ToString("#,##0.00")

            Listado.Detalle.Linea(Texto, Formato, Estilos.Minima)


            Application.DoEvents()

        Next
    End Sub


End Class
