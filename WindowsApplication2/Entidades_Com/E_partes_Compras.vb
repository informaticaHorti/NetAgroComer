Public Class E_partes_Compras
    Inherits Cdatos.Entidad

    Public PDL_idlinea As Cdatos.bdcampo
    Public PDL_idparte As Cdatos.bdcampo
    Public PDL_idgenero As Cdatos.bdcampo
    Public PDL_idcategoria As Cdatos.bdcampo
    Public PDL_kilosC As Cdatos.bdcampo
    Public PDL_kilosS As Cdatos.bdcampo
    Public PDL_kilosF As Cdatos.bdcampo
    Public PDL_ImporteC As Cdatos.bdcampo
    Public PDL_ImporteS As Cdatos.bdcampo
    Public PDL_ImporteF As Cdatos.bdcampo
    Public PDL_GastosCom As Cdatos.bdcampo
    Public PDL_PrecioAprox As Cdatos.bdcampo
    Public PDL_Disponible As Cdatos.bdcampo
    Public PDL_PrecioLiquid As Cdatos.bdcampo
    Public PDL_KilosExIni As Cdatos.bdcampo
    Public PDL_ImpExIni As Cdatos.bdcampo
    Public PDL_KilosExFin As Cdatos.bdcampo
    Public PDL_ImpExFin As Cdatos.bdcampo
    Public PDL_idfamilia As Cdatos.bdcampo
    Public PDL_ImporteFAC As Cdatos.bdcampo

    Public PDL_IdUsuarioLog As Cdatos.bdcampo
    Public PDL_FechaLog As Cdatos.bdcampo
    Public PDL_HoraLog As Cdatos.bdcampo





    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "partes_compras"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            PDL_idlinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            PDL_idparte = New Cdatos.bdcampo(CodigoEntidad & "idparte", Cdatos.TiposCampo.EnteroPositivo, 6)
            PDL_idgenero = New Cdatos.bdcampo(CodigoEntidad & "idgenero", Cdatos.TiposCampo.EnteroPositivo, 5)
            PDL_idcategoria = New Cdatos.bdcampo(CodigoEntidad & "idcategoria", Cdatos.TiposCampo.EnteroPositivo, 5)
            PDL_kilosC = New Cdatos.bdcampo(CodigoEntidad & "kilosC", Cdatos.TiposCampo.Importe, 18, 2)
            PDL_kilosS = New Cdatos.bdcampo(CodigoEntidad & "kilosS", Cdatos.TiposCampo.Importe, 18, 2)
            PDL_kilosF = New Cdatos.bdcampo(CodigoEntidad & "kilosF", Cdatos.TiposCampo.Importe, 18, 2)
            PDL_ImporteC = New Cdatos.bdcampo(CodigoEntidad & "importeC", Cdatos.TiposCampo.Importe, 18, 2)
            PDL_ImporteS = New Cdatos.bdcampo(CodigoEntidad & "importeS", Cdatos.TiposCampo.Importe, 18, 2)
            PDL_ImporteF = New Cdatos.bdcampo(CodigoEntidad & "importeF", Cdatos.TiposCampo.Importe, 18, 2)
            PDL_GastosCom = New Cdatos.bdcampo(CodigoEntidad & "GastosCom", Cdatos.TiposCampo.Importe, 18, 2)
            PDL_PrecioAprox = New Cdatos.bdcampo(CodigoEntidad & "PrecioAprox", Cdatos.TiposCampo.Importe, 18, 4)
            PDL_Disponible = New Cdatos.bdcampo(CodigoEntidad & "Disponible", Cdatos.TiposCampo.Importe, 18, 2)
            PDL_PrecioLiquid = New Cdatos.bdcampo(CodigoEntidad & "PrecioLiquid", Cdatos.TiposCampo.Importe, 18, 4)
            PDL_KilosExIni = New Cdatos.bdcampo(CodigoEntidad & "kilosExIni", Cdatos.TiposCampo.Importe, 18, 2)
            PDL_ImpExIni = New Cdatos.bdcampo(CodigoEntidad & "ImpExIni", Cdatos.TiposCampo.Importe, 18, 2)
            PDL_KilosExFin = New Cdatos.bdcampo(CodigoEntidad & "kilosExFin", Cdatos.TiposCampo.Importe, 18, 2)
            PDL_ImpExFin = New Cdatos.bdcampo(CodigoEntidad & "ImpExFin", Cdatos.TiposCampo.Importe, 18, 2)
            PDL_idfamilia = New Cdatos.bdcampo(CodigoEntidad & "idfamilia", Cdatos.TiposCampo.EnteroPositivo, 5)
            PDL_ImporteFAC = New Cdatos.bdcampo(CodigoEntidad & "importeFAC", Cdatos.TiposCampo.Importe, 18, 2)

            PDL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PDL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PDL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


End Class
