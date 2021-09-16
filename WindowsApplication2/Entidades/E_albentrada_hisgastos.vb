Public Class E_albentrada_hisgastos
    Inherits Cdatos.Entidad


    Private err As New Errores

    Public AHG_id As Cdatos.bdcampo
    Public AHG_idalbhis As Cdatos.bdcampo
    Public AHG_idgasto As Cdatos.bdcampo
    Public AHG_valor As Cdatos.bdcampo
    Public AHG_tipo As Cdatos.bdcampo
    Public AHG_importe As Cdatos.bdcampo
    Public AHG_factura_comercial As Cdatos.bdcampo
    Public AHG_idfacturaproveedor As Cdatos.bdcampo
    Public AHG_idalbaran As Cdatos.bdcampo
    Public AHG_idacreedor As Cdatos.bdcampo

    Public AHG_IdUsuarioLog As Cdatos.bdcampo
    Public AHG_FechaLog As Cdatos.bdcampo
    Public AHG_HoraLog As Cdatos.bdcampo


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "albentrada_hisgastos"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            AHG_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.Entero, 10, 0, True)
            AHG_idalbhis = New Cdatos.bdcampo(CodigoEntidad & "idalbhis", Cdatos.TiposCampo.Entero, 10)
            AHG_idgasto = New Cdatos.bdcampo(CodigoEntidad & "idgasto", Cdatos.TiposCampo.Entero, 10)
            AHG_valor = New Cdatos.bdcampo(CodigoEntidad & "valor", Cdatos.TiposCampo.Importe, 18, 5)
            AHG_tipo = New Cdatos.bdcampo(CodigoEntidad & "tipo", Cdatos.TiposCampo.Cadena, 1)
            AHG_importe = New Cdatos.bdcampo(CodigoEntidad & "importe", Cdatos.TiposCampo.Importe, 18, 5)
            AHG_factura_comercial = New Cdatos.bdcampo(CodigoEntidad & "factura_comercial", Cdatos.TiposCampo.Cadena, 1)
            AHG_idfacturaproveedor = New Cdatos.bdcampo(CodigoEntidad & "idfacturaproveedor", Cdatos.TiposCampo.Entero, 10)
            AHG_idalbaran = New Cdatos.bdcampo(CodigoEntidad & "idalbaran", Cdatos.TiposCampo.Entero, 10)
            AHG_idacreedor = New Cdatos.bdcampo(CodigoEntidad & "idacreedor", Cdatos.TiposCampo.Entero, 5)

            AHG_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            AHG_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            AHG_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.MuestraError("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


End Class
