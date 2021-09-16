Public Class E_albsalida_gastos
    Inherits Cdatos.Entidad


    Private err As New Errores

    Public ASG_id As Cdatos.bdcampo
    Public ASG_idalbaran As Cdatos.bdcampo
    Public ASG_idgasto As Cdatos.bdcampo
    Public ASG_tipokbp As Cdatos.bdcampo
    Public ASG_tipofc As Cdatos.bdcampo
    Public ASG_valorgasto As Cdatos.bdcampo
    Public ASG_importegastodivisa As Cdatos.bdcampo
    Public ASG_importegastoeuros As Cdatos.bdcampo
    Public ASG_idacreedor As Cdatos.bdcampo
    Public ASG_suplido As Cdatos.bdcampo
    Public ASG_idfactura As Cdatos.bdcampo
    Public ASG_importefactura As Cdatos.bdcampo

    Public ASG_IdUsuarioLog As Cdatos.bdcampo
    Public ASG_FechaLog As Cdatos.bdcampo
    Public ASG_HoraLog As Cdatos.bdcampo



    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "albsalida_gastos"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            ASG_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.Entero, 10, 0, True)
            ASG_idalbaran = New Cdatos.bdcampo(CodigoEntidad & "idalbaran", Cdatos.TiposCampo.Entero, 10)
            ASG_idgasto = New Cdatos.bdcampo(CodigoEntidad & "idgasto", Cdatos.TiposCampo.Entero, 10)
            ASG_tipokbp = New Cdatos.bdcampo(CodigoEntidad & "tipokbp", Cdatos.TiposCampo.Cadena, 1)
            ASG_tipofc = New Cdatos.bdcampo(CodigoEntidad & "tipofc", Cdatos.TiposCampo.Cadena, 1)
            ASG_valorgasto = New Cdatos.bdcampo(CodigoEntidad & "valorgasto", Cdatos.TiposCampo.Importe, 18, 4)
            ASG_importegastodivisa = New Cdatos.bdcampo(CodigoEntidad & "importegastodivisa", Cdatos.TiposCampo.Importe, 18, 4)
            ASG_importegastoeuros = New Cdatos.bdcampo(CodigoEntidad & "importegastoeuros", Cdatos.TiposCampo.Importe, 18, 4)
            ASG_idacreedor = New Cdatos.bdcampo(CodigoEntidad & "idacreedor", Cdatos.TiposCampo.Entero, 5)
            ASG_suplido = New Cdatos.bdcampo(CodigoEntidad & "suplido", Cdatos.TiposCampo.Importe, 18, 4)
            ASG_idfactura = New Cdatos.bdcampo(CodigoEntidad & "idfactura", Cdatos.TiposCampo.EnteroPositivo, 10)
            ASG_importefactura = New Cdatos.bdcampo(CodigoEntidad & "importefactura", Cdatos.TiposCampo.Importe, 18, 2)

            ASG_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            ASG_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            ASG_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


    Public Function GastosFacturados(ByVal idalbaran As String) As String

        Dim ret As String = ""
        Dim sql As String

        sql = "Select ASG_importegastoeuros as importe from albsalida_gastos where ASG_idalbaran=" + idalbaran + " and ASG_idfactura > 0 "
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                ret = ret + rw("importe").ToString & " / "
            Next
        End If

        If ret <> "" Then
            ret = "El albarán tiene gastos facturados: " & ret
        End If

        Return ret


    End Function


End Class
