Public Class E_AlbEntrada_hislineas
    Inherits Cdatos.Entidad

    Public AHL_id As Cdatos.bdcampo
    Public AHL_idalbhis As Cdatos.bdcampo
    Public AHL_idalbaran As Cdatos.bdcampo
    Public AHL_idgenero As Cdatos.bdcampo
    Public AHL_idenvase As Cdatos.bdcampo
    Public AHL_idpalet As Cdatos.bdcampo
    Public AHL_kilos As Cdatos.bdcampo
    Public AHL_palets As Cdatos.bdcampo
    Public AHL_bultos As Cdatos.bdcampo
    Public AHL_idcategoria As Cdatos.bdcampo
    Public AHL_precio As Cdatos.bdcampo
    Public AHL_muestreo As Cdatos.bdcampo
    Public AHL_idlineaentrada As Cdatos.bdcampo
    Public AHL_idtipoconfeccion As Cdatos.bdcampo
    Public AHL_idmarca As Cdatos.bdcampo
    Public AHL_precioenvase As Cdatos.bdcampo
    Public AHL_piezas As Cdatos.bdcampo
    Public AHL_tipoprecio As Cdatos.bdcampo
    Public AHL_importegenero As Cdatos.bdcampo
    Public AHL_idlineacla As Cdatos.bdcampo

    Public AHL_IdUsuarioLog As Cdatos.bdcampo
    Public AHL_FechaLog As Cdatos.bdcampo
    Public AHL_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Dim Generos As New E_Generos(idUsuario, cn)
        Dim Envases As New E_Envases(idUsuario, cn)
        Dim Categoria As New E_CategoriasEntrada(idUsuario, cn)

        Try
            NombreTabla = "AlbEntrada_hislineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            AHL_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            AHL_idalbhis = New Cdatos.bdcampo(CodigoEntidad & "idalbhis", Cdatos.TiposCampo.EnteroPositivo, 6)
            AHL_idalbaran = New Cdatos.bdcampo(CodigoEntidad & "idalbaran", Cdatos.TiposCampo.EnteroPositivo, 6)
            AHL_idgenero = New Cdatos.bdcampo(CodigoEntidad & "idgenero", Cdatos.TiposCampo.EnteroPositivo, 5)
            AHL_idenvase = New Cdatos.bdcampo(CodigoEntidad & "idenvase", Cdatos.TiposCampo.EnteroPositivo, 5)
            AHL_idpalet = New Cdatos.bdcampo(CodigoEntidad & "idpalet", Cdatos.TiposCampo.EnteroPositivo, 5)
            AHL_kilos = New Cdatos.bdcampo(CodigoEntidad & "kilos", Cdatos.TiposCampo.Importe, 10, 2)
            AHL_palets = New Cdatos.bdcampo(CodigoEntidad & "palets", Cdatos.TiposCampo.Entero, 4)
            AHL_bultos = New Cdatos.bdcampo(CodigoEntidad & "bultos", Cdatos.TiposCampo.Entero, 4)
            AHL_idcategoria = New Cdatos.bdcampo(CodigoEntidad & "idcategoria", Cdatos.TiposCampo.EnteroPositivo, 4)
            AHL_precio = New Cdatos.bdcampo(CodigoEntidad & "precio", Cdatos.TiposCampo.Importe, 6, 2)
            AHL_muestreo = New Cdatos.bdcampo(CodigoEntidad & "muestreo", Cdatos.TiposCampo.Entero, 10)
            AHL_idlineaentrada = New Cdatos.bdcampo(CodigoEntidad & "idlineaentrada", Cdatos.TiposCampo.Entero, 8)
            AHL_idtipoconfeccion = New Cdatos.bdcampo(CodigoEntidad & "idtipoconfeccion", Cdatos.TiposCampo.EnteroPositivo, 6)
            AHL_idmarca = New Cdatos.bdcampo(CodigoEntidad & "idmarca", Cdatos.TiposCampo.EnteroPositivo, 4)
            AHL_precioenvase = New Cdatos.bdcampo(CodigoEntidad & "precioenvase", Cdatos.TiposCampo.Importe, 6, 2)
            AHL_piezas = New Cdatos.bdcampo(CodigoEntidad & "piezas", Cdatos.TiposCampo.Entero, 4)
            AHL_tipoprecio = New Cdatos.bdcampo(CodigoEntidad & "tipoprecio", Cdatos.TiposCampo.Cadena, 1)
            AHL_importegenero = New Cdatos.bdcampo(CodigoEntidad & "importegenero", Cdatos.TiposCampo.Importe, 10, 2)
            AHL_idlineacla = New Cdatos.bdcampo(CodigoEntidad & "idlineacla", Cdatos.TiposCampo.Entero, 8)

            AHL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            AHL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            AHL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub




End Class
