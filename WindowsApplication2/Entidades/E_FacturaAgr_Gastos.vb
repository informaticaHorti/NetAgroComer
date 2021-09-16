Public Class E_FacturaAgr_Gastos

    Inherits Cdatos.Entidad

    Public FGA_id As Cdatos.bdcampo
    Public FGA_idfactura As Cdatos.bdcampo
    Public FGA_idgasto As Cdatos.bdcampo
    Public FGA_importe As Cdatos.bdcampo
    Public FGA_tipofc As Cdatos.bdcampo



    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "FacturaAgr_gastos"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            FGA_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            FGA_idfactura = New Cdatos.bdcampo(CodigoEntidad & "idfactura", Cdatos.TiposCampo.EnteroPositivo, 6)
            FGA_idgasto = New Cdatos.bdcampo(CodigoEntidad & "idgenero", Cdatos.TiposCampo.EnteroPositivo, 5)
            FGA_importe = New Cdatos.bdcampo(CodigoEntidad & "importe", Cdatos.TiposCampo.Importe, 12, 2)
            FGA_tipofc = New Cdatos.bdcampo(CodigoEntidad & "tipofc", Cdatos.TiposCampo.Cadena, 1)



            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub




End Class
