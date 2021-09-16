Public Class E_Altas_AEAT
    Inherits Cdatos.Entidad


    Private err As New Errores


    Public Id As Cdatos.bdcampo
    Public Tipo As Cdatos.bdcampo
    Public SerieDocumento As Cdatos.bdcampo
    Public Documento As Cdatos.bdcampo
    Public FechaFac As Cdatos.bdcampo
    Public NIF As Cdatos.bdcampo
    Public Emisor As Cdatos.bdcampo
    Public TipoIdentificacion As Cdatos.bdcampo
    Public CodigoPais As Cdatos.bdcampo
    Public FechaHora_AEAT As Cdatos.bdcampo
    Public NumSerieFin As Cdatos.bdcampo





    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try


            NombreTabla = "Altas_AEAT"
            NombreBd = NombreBd = ObtenerBDConexion(conexion)
            MiConexion = conexion


            Id = New Cdatos.bdcampo("Id", Cdatos.TiposCampo.Entero, 18, 0, True)
            Tipo = New Cdatos.bdcampo("Tipo", Cdatos.TiposCampo.Cadena, 1)
            SerieDocumento = New Cdatos.bdcampo("SerieDocumento", Cdatos.TiposCampo.Cadena, 10)
            Documento = New Cdatos.bdcampo("Documento", Cdatos.TiposCampo.Cadena, 20)
            FechaFac = New Cdatos.bdcampo("FechaFac", Cdatos.TiposCampo.Fecha, 8)
            NIF = New Cdatos.bdcampo("NIF", Cdatos.TiposCampo.Cadena, 20)
            TipoIdentificacion = New Cdatos.bdcampo("TipoIdentificacion", Cdatos.TiposCampo.Cadena, 2)
            CodigoPais = New Cdatos.bdcampo("CodigoPais", Cdatos.TiposCampo.Cadena, 2)
            FechaHora_AEAT = New Cdatos.bdcampo("FechaHora_AEAT", Cdatos.TiposCampo.Cadena, 14)
            NumSerieFin = New Cdatos.bdcampo("NumSerieFin", Cdatos.TiposCampo.Cadena, 30)

            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


    Public Function ExisteFactura(ByVal Tipo As String, ByVal SerieDocumento As String, ByVal Documento As String, NumSerieFin As String,
                                  ByVal FechaFac As String, ByVal NIF As String, ByVal TipoIdentificacion As String, ByVal CodigoPais As String) As Boolean

        Dim bRes As Boolean = False


        Dim sql As String = "SELECT Id FROM Altas_AEAT"
        sql = sql & " WHERE Tipo = '" & Tipo & "'" & vbCrLf
        sql = sql & " AND SerieDocumento = '" & SerieDocumento & "'" & vbCrLf
        sql = sql & " AND Documento = '" & Documento & "'" & vbCrLf
        sql = sql & " AND NumSerieFin = '" & NumSerieFin & "'" & vbCrLf
        sql = sql & " AND FechaFac = '" & FechaFac & "'" & vbCrLf
        sql = sql & " AND NIF = '" & NIF & "'" & vbCrLf
        sql = sql & " AND COALESCE(TipoIdentificacion, '') = '" & TipoIdentificacion & "'" & vbCrLf
        sql = sql & " AND COALESCE(CodigoPais,'') = '" & CodigoPais & "'" & vbCrLf


        Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            If dt.Rows.Count > 0 Then bRes = True

        End If


        Return bRes

    End Function



End Class
