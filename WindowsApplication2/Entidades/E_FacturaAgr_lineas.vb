Public Class E_FacturaAgr_lineas
    Inherits Cdatos.Entidad

    Public FAL_id As Cdatos.bdcampo
    Public FAL_idfactura As Cdatos.bdcampo
    Public FAL_idgenero As Cdatos.bdcampo
    Public FAL_idcategoria As Cdatos.bdcampo
    Public FAL_bultos As Cdatos.bdcampo
    Public FAL_kilos As Cdatos.bdcampo
    Public FAL_precio As Cdatos.bdcampo
    Public FAL_importe As Cdatos.bdcampo
    Public FAL_idpartida As Cdatos.bdcampo
    Public FAL_Piezas As Cdatos.bdcampo
    Public FAL_TipoPrecio As Cdatos.bdcampo
    Public FAL_IdGensal As Cdatos.bdcampo



    Public FAL_IdUsuarioLog As Cdatos.bdcampo
    Public FAL_FechaLog As Cdatos.bdcampo
    Public FAL_HoraLog As Cdatos.bdcampo




    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "FacturaAgr_lineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            FAL_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            FAL_idfactura = New Cdatos.bdcampo(CodigoEntidad & "idfactura", Cdatos.TiposCampo.EnteroPositivo, 6)
            FAL_idgenero = New Cdatos.bdcampo(CodigoEntidad & "idgenero", Cdatos.TiposCampo.EnteroPositivo, 5)
            FAL_kilos = New Cdatos.bdcampo(CodigoEntidad & "kilos", Cdatos.TiposCampo.Importe, 10, 2)
            FAL_bultos = New Cdatos.bdcampo(CodigoEntidad & "bultos", Cdatos.TiposCampo.Entero, 4)
            FAL_idcategoria = New Cdatos.bdcampo(CodigoEntidad & "idcategoria", Cdatos.TiposCampo.EnteroPositivo, 4)
            FAL_precio = New Cdatos.bdcampo(CodigoEntidad & "precio", Cdatos.TiposCampo.Importe, 8, 4)
            FAL_importe = New Cdatos.bdcampo(CodigoEntidad & "importe", Cdatos.TiposCampo.Importe, 12, 2)
            FAL_idpartida = New Cdatos.bdcampo(CodigoEntidad & "idpartida", Cdatos.TiposCampo.Entero, 10)
            FAL_Piezas = New Cdatos.bdcampo(CodigoEntidad & "Piezas", Cdatos.TiposCampo.Entero, 6)
            FAL_TipoPrecio = New Cdatos.bdcampo(CodigoEntidad & "TipoPrecio", Cdatos.TiposCampo.Cadena, 1)
            FAL_IdGensal = New Cdatos.bdcampo(CodigoEntidad & "IdGensal", Cdatos.TiposCampo.Entero, 6)

            FAL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            FAL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            FAL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub




End Class
