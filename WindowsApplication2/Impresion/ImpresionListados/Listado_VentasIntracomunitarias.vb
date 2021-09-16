Public Class Listado_VentasIntracomunitarias
    Inherits Listado_ImpresionBase


    Property Dt As DataTable
    Property Empresas As String
    Property CliDesde As String
    Property CliHasta As String
    Property FechaDesde As String
    Property FechaHasta As String
    Property Pais As String
    Property TipoImpresion As TipoImpresion


    Dim Texto As String = ""
    Dim Formato As String = ""
    Dim AnchoPagina As Integer = 190
    Dim Ancho As Integer = AnchoPagina

    Dim CabeceraDetallada As String = "N.I.F|SUJETO|PAIS|BASE IMPONIBLE"
    Dim FormatoDetallado As String = "45|60|55|>25"
    Dim FormatoPais As String = "110|50|>25"



    Public Sub New(ByVal dt As DataTable, ByVal lstEmpresas As String, ByVal CliDesde As String, ByVal CliHasta As String,
                   ByVal fechaDesde As String, ByVal fechaHasta As String, ByVal Pais As String, TipoImpresion As TipoImpresion)

        Me.Dt = dt
        Me.Empresas = lstEmpresas
        Me.CliDesde = CliDesde
        Me.CliHasta = CliHasta
        Me.FechaDesde = fechaDesde
        Me.FechaHasta = fechaHasta
        Me.Pais = Pais
        Me.TipoImpresion = TipoImpresion

    End Sub


    Public Overrides Sub ImprimirListado()

        MargenIzq = 10
        Ancho = AnchoPagina - MargenIzq - MargenDer
        EstableceListado(Orientacion.Vertical, TipoImpresion)

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

        Texto = "Listado Ventas Intracomunitarias | Desde: " & FechaDesde & " Hasta: " & FechaHasta
        Formato = (Ancho - 100).ToString & "|>100"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.GrandeBold)

        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Normal)


    End Sub

    Private Sub ConfiguraDetalle()

        Listado.Cabecera.Linea(CabeceraDetallada, FormatoDetallado, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", FormatoDetallado, Estilos.Minima)

        Dim DcBase As New Dictionary(Of String, Decimal)

        Dim det As String = ""
        Dim TotBaseImp As Decimal = 0

        For Each row As DataRow In Dt.Rows

            Dim Nif As String = (row("Nif").ToString & "").Trim
            Dim Cliente As String = (row("Sujeto").ToString & "").Trim
            Dim Pais As String = (row("pais").ToString & "").Trim
            Dim BaseImp As Decimal = VaDec(row("BaseImp"))


            ' Escribe detalle

            det = ""
            det = det & Nif & "|"
            det = det & Cliente & "|"
            det = det & Pais & "|"
            det = det & BaseImp.ToString("#,##0.00")

            Listado.Detalle.Linea(det, FormatoDetallado, Estilos.Normal)


            TotBaseImp = TotBaseImp + BaseImp

            'Llenamos el diccionario

            If DcBase.ContainsKey(Pais) = False Then
                DcBase.Add(Pais, BaseImp)
            Else
                DcBase(Pais) = DcBase(Pais) + BaseImp
            End If


            Application.DoEvents()

        Next


        'Total Listado
        det = ""
        det = det & "" & "|"
        det = det & "TOTAL LISTADO" & "|"
        det = det & "" & "|"
        det = det & TotBaseImp.ToString("#,##0.00")
        Listado.Detalle.Linea("", FormatoDetallado, Estilos.Reducida)
        Listado.Detalle.Linea(det, FormatoDetallado, Estilos.NormalBoldLineaEncima)
        Listado.Detalle.Linea("", FormatoDetallado, Estilos.Reducida)




        For Each bas In DcBase.Keys

            Dim pa As String = ""

            pa = pa & "" & "|"
            pa = pa & bas & "|"
            pa = pa & DcBase(bas).ToString("#,##0.00")

            Listado.Detalle.Linea(pa, FormatoPais, Estilos.ReducidaBold)


        Next



    End Sub


End Class
