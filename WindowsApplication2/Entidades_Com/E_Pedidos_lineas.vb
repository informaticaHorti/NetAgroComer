Public Class E_Pedidos_lineas
    Inherits Cdatos.Entidad

    Public PEL_idlinea As Cdatos.bdcampo
    Public PEL_idpedido As Cdatos.bdcampo
    Public PEL_idgenero As Cdatos.bdcampo
    Public PEL_idtipoconfeccion As Cdatos.bdcampo
    Public PEL_idgensal As Cdatos.bdcampo
    Public PEL_idcategoria As Cdatos.bdcampo
    Public PEL_nomcate As Cdatos.bdcampo
    Public PEL_idmarca As Cdatos.bdcampo
    Public PEL_idtipopalet As Cdatos.bdcampo
    Public PEL_palets As Cdatos.bdcampo
    Public PEL_bultospalet As Cdatos.bdcampo
    Public PEL_kilosbulto As Cdatos.bdcampo
    Public PEL_piezasbulto As Cdatos.bdcampo
    Public PEL_precio As Cdatos.bdcampo
    Public PEL_tipoprecio As Cdatos.bdcampo
    Public PEL_Bultos As Cdatos.bdcampo
    Public PEL_kilos As Cdatos.bdcampo
    Public PEL_piezas As Cdatos.bdcampo
    Public PEL_idproveedor As Cdatos.bdcampo
    Public PEL_precioproveedor As Cdatos.bdcampo
    Public PEL_paletsproveedor As Cdatos.bdcampo
    Public PEL_obslote As Cdatos.bdcampo
    Public PEL_obsconfec1 As Cdatos.bdcampo
    Public PEL_obsconfec2 As Cdatos.bdcampo
    Public PEL_obseti1 As Cdatos.bdcampo
    Public PEL_obseti2 As Cdatos.bdcampo
    Public PEL_generatrabajo As Cdatos.bdcampo
    Public PEL_requiereaprobacion As Cdatos.bdcampo
    Public PEL_idmarcaetiqueta As Cdatos.bdcampo
    Public PEL_idmarcamaterial As Cdatos.bdcampo
    Public PEL_calidad As Cdatos.bdcampo
    Public PEL_maxdias As Cdatos.bdcampo
    Public PEL_reservapalets As Cdatos.bdcampo
    Public PEL_KilosBrutos As Cdatos.bdcampo

    Public PEL_PaletsTransporte As Cdatos.bdcampo

    Public PEL_IdUsuarioLog As Cdatos.bdcampo
    Public PEL_FechaLog As Cdatos.bdcampo
    Public PEL_HoraLog As Cdatos.bdcampo

    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "Pedidos_lineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            PEL_idlinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            PEL_idpedido = New Cdatos.bdcampo(CodigoEntidad & "idpedido", Cdatos.TiposCampo.EnteroPositivo, 6)
            PEL_idgenero = New Cdatos.bdcampo(CodigoEntidad & "idgenero", Cdatos.TiposCampo.EnteroPositivo, 5)
            PEL_idtipoconfeccion = New Cdatos.bdcampo(CodigoEntidad & "idtipoconfeccion", Cdatos.TiposCampo.EnteroPositivo, 5)
            PEL_idgensal = New Cdatos.bdcampo(CodigoEntidad & "idgensal", Cdatos.TiposCampo.EnteroPositivo, 6)
            PEL_idcategoria = New Cdatos.bdcampo(CodigoEntidad & "idcategoria", Cdatos.TiposCampo.EnteroPositivo, 5)
            PEL_nomcate = New Cdatos.bdcampo(CodigoEntidad & "nomcate", Cdatos.TiposCampo.Cadena, 50)
            PEL_idmarca = New Cdatos.bdcampo(CodigoEntidad & "idmarca", Cdatos.TiposCampo.EnteroPositivo, 5)
            PEL_idtipopalet = New Cdatos.bdcampo(CodigoEntidad & "idtipopalet", Cdatos.TiposCampo.EnteroPositivo, 5)
            PEL_palets = New Cdatos.bdcampo(CodigoEntidad & "palets", Cdatos.TiposCampo.Entero, 4)
            PEL_bultospalet = New Cdatos.bdcampo(CodigoEntidad & "bultospalet", Cdatos.TiposCampo.Entero, 4)
            PEL_kilosbulto = New Cdatos.bdcampo(CodigoEntidad & "kilosbulto", Cdatos.TiposCampo.Importe, 5, 2)
            PEL_piezasbulto = New Cdatos.bdcampo(CodigoEntidad & "piezasbulto", Cdatos.TiposCampo.Entero, 4)
            PEL_Bultos = New Cdatos.bdcampo(CodigoEntidad & "bultos", Cdatos.TiposCampo.Entero, 5)
            PEL_kilos = New Cdatos.bdcampo(CodigoEntidad & "kilos", Cdatos.TiposCampo.Entero, 6)
            PEL_piezas = New Cdatos.bdcampo(CodigoEntidad & "piezas", Cdatos.TiposCampo.Entero, 6)
            PEL_precio = New Cdatos.bdcampo(CodigoEntidad & "precio", Cdatos.TiposCampo.Importe, 6, 4)
            PEL_tipoprecio = New Cdatos.bdcampo(CodigoEntidad & "tipoprecio", Cdatos.TiposCampo.Cadena, 1)
            PEL_idproveedor = New Cdatos.bdcampo(CodigoEntidad & "idproveedor", Cdatos.TiposCampo.Entero, 5)
            PEL_precioproveedor = New Cdatos.bdcampo(CodigoEntidad & "precioproveedor", Cdatos.TiposCampo.Importe, 6, 4)
            PEL_paletsproveedor = New Cdatos.bdcampo(CodigoEntidad & "paletsproveedor", Cdatos.TiposCampo.Entero, 5)
            PEL_obslote = New Cdatos.bdcampo(CodigoEntidad & "obslote", Cdatos.TiposCampo.Cadena, 50)
            PEL_obsconfec1 = New Cdatos.bdcampo(CodigoEntidad & "obsconfec1", Cdatos.TiposCampo.Cadena, 50)
            PEL_obsconfec2 = New Cdatos.bdcampo(CodigoEntidad & "obsconfec2", Cdatos.TiposCampo.Cadena, 50)
            PEL_obseti1 = New Cdatos.bdcampo(CodigoEntidad & "obseti1", Cdatos.TiposCampo.Cadena, 50)
            PEL_obseti2 = New Cdatos.bdcampo(CodigoEntidad & "obseti2", Cdatos.TiposCampo.Cadena, 50)
            PEL_generatrabajo = New Cdatos.bdcampo(CodigoEntidad & "generatrabajo", Cdatos.TiposCampo.Cadena, 1)
            PEL_requiereaprobacion = New Cdatos.bdcampo(CodigoEntidad & "requiereaprobacion", Cdatos.TiposCampo.Cadena, 1)
            PEL_idmarcaetiqueta = New Cdatos.bdcampo(CodigoEntidad & "idmarcaetiqueta", Cdatos.TiposCampo.EnteroPositivo, 5)
            PEL_idmarcamaterial = New Cdatos.bdcampo(CodigoEntidad & "idmarcamaterial", Cdatos.TiposCampo.EnteroPositivo, 5)
            PEL_calidad = New Cdatos.bdcampo(CodigoEntidad & "calidad", Cdatos.TiposCampo.Cadena, 1)
            PEL_maxdias = New Cdatos.bdcampo(CodigoEntidad & "maxdias", Cdatos.TiposCampo.CadenaNumero, 1)
            PEL_reservapalets = New Cdatos.bdcampo(CodigoEntidad & "reservapalets", Cdatos.TiposCampo.Cadena, 1)
            PEL_KilosBrutos = New Cdatos.bdcampo(CodigoEntidad & "KilosBrutos", Cdatos.TiposCampo.Entero, 6)

            PEL_PaletsTransporte = New Cdatos.bdcampo(CodigoEntidad & "PaletsTransporte", Cdatos.TiposCampo.Importe, 18, 2)

            PEL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PEL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PEL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub

   

End Class
