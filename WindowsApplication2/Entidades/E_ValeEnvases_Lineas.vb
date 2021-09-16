Public Class E_ValeEnvases_Lineas
    Inherits Cdatos.Entidad

    Public VEL_Id As Cdatos.bdcampo
    Public VEL_idvale As Cdatos.bdcampo
    Public VEL_idenvase As Cdatos.bdcampo
    Public VEL_retira As Cdatos.bdcampo
    Public VEL_entrega As Cdatos.bdcampo
    Public VEL_precioretira As Cdatos.bdcampo
    Public VEL_precioentrega As Cdatos.bdcampo
    Public VEL_idmarca As Cdatos.bdcampo
    Public VEL_idalmacen As Cdatos.bdcampo
    Public VEL_preciocoste As Cdatos.bdcampo
    Public VEL_Automatica As Cdatos.bdcampo
    Public VEL_MaterialPropio As Cdatos.bdcampo
    Public VEL_IdFacturaRecibida As Cdatos.bdcampo

    Public VEL_IdFacturaEnvase As Cdatos.bdcampo
    Public VEL_TipoEnvase As Cdatos.bdcampo
    Public VEL_PrecioFianza As Cdatos.bdcampo 'Sólo para VEL_TipoEnvase = 'B' y VEV_Operacion = 'CC' o 'SC' (facturar aparte) - Sólo retira


    Public VEL_IdUsuarioLog As Cdatos.bdcampo
    Public VEL_FechaLog As Cdatos.bdcampo
    Public VEL_HoraLog As Cdatos.bdcampo




    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "ValeEnvases_Lineas"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            VEL_Id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.Entero, 8, 0, True)
            VEL_idvale = New Cdatos.bdcampo(CodigoEntidad & "idvale", Cdatos.TiposCampo.Entero, 8)
            VEL_idenvase = New Cdatos.bdcampo(CodigoEntidad & "idenvase", Cdatos.TiposCampo.Entero, 8)
            VEL_retira = New Cdatos.bdcampo(CodigoEntidad & "retira", Cdatos.TiposCampo.Importe, 10, 2)
            VEL_entrega = New Cdatos.bdcampo(CodigoEntidad & "entrega", Cdatos.TiposCampo.Importe, 10, 2)
            VEL_precioretira = New Cdatos.bdcampo(CodigoEntidad & "precioretira", Cdatos.TiposCampo.Importe, 20, 6)
            VEL_precioentrega = New Cdatos.bdcampo(CodigoEntidad & "precioentrega", Cdatos.TiposCampo.Importe, 20, 6)
            VEL_idmarca = New Cdatos.bdcampo(CodigoEntidad & "idmarca", Cdatos.TiposCampo.Entero, 4)
            VEL_idalmacen = New Cdatos.bdcampo(CodigoEntidad & "idalmacen", Cdatos.TiposCampo.Entero, 4)
            VEL_preciocoste = New Cdatos.bdcampo(CodigoEntidad & "preciocoste", Cdatos.TiposCampo.Importe, 20, 6)
            VEL_Automatica = New Cdatos.bdcampo(CodigoEntidad & "Automatica", Cdatos.TiposCampo.Cadena, 1)
            VEL_MaterialPropio = New Cdatos.bdcampo(CodigoEntidad & "MaterialPropio", Cdatos.TiposCampo.Cadena, 1)
            VEL_IdFacturaRecibida = New Cdatos.bdcampo(CodigoEntidad & "IdFacturaRecibida", Cdatos.TiposCampo.Entero, 10)

            VEL_IdFacturaEnvase = New Cdatos.bdcampo(CodigoEntidad & "IdFacturaEnvase", Cdatos.TiposCampo.Entero, 10)
            VEL_TipoEnvase = New Cdatos.bdcampo(CodigoEntidad & "TipoEnvase", Cdatos.TiposCampo.Cadena, 1)
            VEL_PrecioFianza = New Cdatos.bdcampo(CodigoEntidad & "PrecioFianza", Cdatos.TiposCampo.Importe, 20, 6)

            VEL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            VEL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            VEL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

 
    End Sub

 
End Class
