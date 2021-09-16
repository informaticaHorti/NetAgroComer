Public Class E_palets_costes
    Inherits Cdatos.Entidad

    Public PLC_idcoste As Cdatos.bdcampo
    Public PLC_idpalet As Cdatos.bdcampo
    Public PLC_idmaterial As Cdatos.bdcampo
    Public PLC_idmarca As Cdatos.bdcampo
    Public PLC_cantidad As Cdatos.bdcampo
    Public PLC_precio As Cdatos.bdcampo
    Public PLC_automatico As Cdatos.bdcampo
    Public PLC_idlineapalet As Cdatos.bdcampo

    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "palets_costes"
            NombreBd = "NetAgro"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            PLC_idcoste = New Cdatos.bdcampo(CodigoEntidad & "idcoste", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            PLC_idpalet = New Cdatos.bdcampo(CodigoEntidad & "idpalet", Cdatos.TiposCampo.EnteroPositivo, 6)
            PLC_idmaterial = New Cdatos.bdcampo(CodigoEntidad & "idmaterial", Cdatos.TiposCampo.EnteroPositivo, 10)
            PLC_idmarca = New Cdatos.bdcampo(CodigoEntidad & "idmarca", Cdatos.TiposCampo.EnteroPositivo, 5)
            PLC_cantidad = New Cdatos.bdcampo(CodigoEntidad & "cantidad", Cdatos.TiposCampo.Importe, 12, 6)
            PLC_precio = New Cdatos.bdcampo(CodigoEntidad & "precio", Cdatos.TiposCampo.Importe, 12, 6)
            PLC_automatico = New Cdatos.bdcampo(CodigoEntidad & "automatico", Cdatos.TiposCampo.Cadena, 1)
            PLC_idlineapalet = New Cdatos.bdcampo(CodigoEntidad & "idlineapalet", Cdatos.TiposCampo.EnteroPositivo, 10)

            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub



End Class
