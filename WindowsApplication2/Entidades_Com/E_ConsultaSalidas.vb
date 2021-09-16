Public Class E_ConsultaSalidas
    Inherits Cdatos.Entidad

    Public CNS_Id As Cdatos.bdcampo
    Public CNS_IdAlbaran As Cdatos.bdcampo
    Public CNS_Albaran As Cdatos.bdcampo
    Public CNS_IdCentro As Cdatos.bdcampo
    Public CNS_IdPuntoVenta As Cdatos.bdcampo
    Public CNS_IdCliente As Cdatos.bdcampo
    Public CNS_Cliente As Cdatos.bdcampo
    Public CNS_IdVendedor As Cdatos.bdcampo
    Public CNS_Vendedor As Cdatos.bdcampo
    Public CNS_IdGenero As Cdatos.bdcampo
    Public CNS_Genero As Cdatos.bdcampo
    Public CNS_IdPresentacion As Cdatos.bdcampo
    Public CNS_Presentacion As Cdatos.bdcampo
    Public CNS_IdCategoria As Cdatos.bdcampo
    Public CNS_Categoria As Cdatos.bdcampo
    Public CNS_Kilos As Cdatos.bdcampo
    Public CNS_ImporteVenta As Cdatos.bdcampo
    Public CNS_GastosVenta As Cdatos.bdcampo
    Public CNS_GastosOperaciones As Cdatos.bdcampo
    Public CNS_Coste As Cdatos.bdcampo
    Public CNS_Margen As Cdatos.bdcampo
    Public CNS_MargenKilo As Cdatos.bdcampo
    Public CNS_FechaDesde As Cdatos.bdcampo
    Public CNS_FechaHasta As Cdatos.bdcampo


   

    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "ConsultaSalidas"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            CNS_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            CNS_IdAlbaran = New Cdatos.bdcampo(CodigoEntidad & "IdAlbaran", Cdatos.TiposCampo.EnteroPositivo, 6)
            CNS_Albaran = New Cdatos.bdcampo(CodigoEntidad & "Albaran", Cdatos.TiposCampo.EnteroPositivo, 6)
            CNS_IdCentro = New Cdatos.bdcampo(CodigoEntidad & "IdCentro", Cdatos.TiposCampo.EnteroPositivo, 3)
            CNS_IdPuntoVenta = New Cdatos.bdcampo(CodigoEntidad & "IdPuntoVenta", Cdatos.TiposCampo.EnteroPositivo, 3)
            CNS_IdCliente = New Cdatos.bdcampo(CodigoEntidad & "IdCliente", Cdatos.TiposCampo.EnteroPositivo, 5)
            CNS_Cliente = New Cdatos.bdcampo(CodigoEntidad & "Cliente", Cdatos.TiposCampo.Cadena, 100)
            CNS_IdVendedor = New Cdatos.bdcampo(CodigoEntidad & "IdVendedor", Cdatos.TiposCampo.EnteroPositivo, 4)
            CNS_Vendedor = New Cdatos.bdcampo(CodigoEntidad & "Vendedor", Cdatos.TiposCampo.Cadena, 40)
            CNS_IdGenero = New Cdatos.bdcampo(CodigoEntidad & "IdGenero", Cdatos.TiposCampo.EnteroPositivo, 5)
            CNS_Genero = New Cdatos.bdcampo(CodigoEntidad & "Genero", Cdatos.TiposCampo.Cadena, 40)
            CNS_IdPresentacion = New Cdatos.bdcampo(CodigoEntidad & "IdPresentacion", Cdatos.TiposCampo.Entero, 5)
            CNS_Presentacion = New Cdatos.bdcampo(CodigoEntidad & "Presentacion", Cdatos.TiposCampo.Cadena, 50)
            CNS_IdCategoria = New Cdatos.bdcampo(CodigoEntidad & "IdCategoria", Cdatos.TiposCampo.EnteroPositivo, 3)
            CNS_Categoria = New Cdatos.bdcampo(CodigoEntidad & "Categoria", Cdatos.TiposCampo.Cadena, 25)
            CNS_Kilos = New Cdatos.bdcampo(CodigoEntidad & "Kilos", Cdatos.TiposCampo.Importe, 18, 2)
            CNS_ImporteVenta = New Cdatos.bdcampo(CodigoEntidad & "ImporteVenta", Cdatos.TiposCampo.Importe, 18, 2)
            CNS_GastosVenta = New Cdatos.bdcampo(CodigoEntidad & "GastosVenta", Cdatos.TiposCampo.Importe, 18, 2)
            CNS_GastosOperaciones = New Cdatos.bdcampo(CodigoEntidad & "GastosOperaciones", Cdatos.TiposCampo.Importe, 18, 2)
            CNS_Coste = New Cdatos.bdcampo(CodigoEntidad & "Coste", Cdatos.TiposCampo.Importe, 18, 2)
            CNS_Margen = New Cdatos.bdcampo(CodigoEntidad & "Margen", Cdatos.TiposCampo.Importe, 18, 2)
            CNS_MargenKilo = New Cdatos.bdcampo(CodigoEntidad & "MargenKilo", Cdatos.TiposCampo.Importe, 18, 4)
            CNS_FechaDesde = New Cdatos.bdcampo(CodigoEntidad & "FechaDesde", Cdatos.TiposCampo.Fecha, 10)
            CNS_FechaHasta = New Cdatos.bdcampo(CodigoEntidad & "FechaHasta", Cdatos.TiposCampo.Fecha, 10)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub

    
End Class
