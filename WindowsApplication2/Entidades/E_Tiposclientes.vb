Public Class E_Tiposclientes
    Inherits Cdatos.Entidad

    Public TPC_idtipo As Cdatos.bdcampo
    Public TPC_nombre As Cdatos.bdcampo
    Public TPC_poriva As Cdatos.bdcampo
    Public TPC_porre As Cdatos.bdcampo
    Public TPC_idtipoiva As Cdatos.bdcampo
    Public TPC_exentoiva As Cdatos.bdcampo
    Public TPC_recequivalencia As Cdatos.bdcampo

    Public TPC_ctacliente As Cdatos.bdcampo

    Public TPC_ctaventas As Cdatos.bdcampo
    Public TPC_ctavarios As Cdatos.bdcampo
    Public TPC_ctaenvases As Cdatos.bdcampo

    Public TPC_ctaivaventas As Cdatos.bdcampo
    Public TPC_ctaivavarios As Cdatos.bdcampo
    Public TPC_ctaivaenvases As Cdatos.bdcampo

    Public TPC_ctarecargo As Cdatos.bdcampo
    Public TPC_ctadevenvases As Cdatos.bdcampo
    Public TPC_clienteinterno As Cdatos.bdcampo

    Public TPC_GeneraAsiento As Cdatos.bdcampo

    Public TPC_ctanoretfac As Cdatos.bdcampo
    Public TPC_ctanoretabo As Cdatos.bdcampo

    Public TPC_IdUsuarioLog As Cdatos.bdcampo
    Public TPC_FechaLog As Cdatos.bdcampo
    Public TPC_HoraLog As Cdatos.bdcampo



    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "TiposClientes"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            TPC_idtipo = New Cdatos.bdcampo(CodigoEntidad & "idtipo", Cdatos.TiposCampo.Entero, 5, 0, True)
            TPC_nombre = New Cdatos.bdcampo(CodigoEntidad & "nombre", Cdatos.TiposCampo.Cadena, 50)
            TPC_poriva = New Cdatos.bdcampo(CodigoEntidad & "poriva", Cdatos.TiposCampo.Importe, 8, 2)
            TPC_porre = New Cdatos.bdcampo(CodigoEntidad & "porre", Cdatos.TiposCampo.Importe, 8, 2)
            TPC_idtipoiva = New Cdatos.bdcampo(CodigoEntidad & "idtipoiva", Cdatos.TiposCampo.EnteroPositivo, 4)
            TPC_exentoiva = New Cdatos.bdcampo(CodigoEntidad & "exentoiva", Cdatos.TiposCampo.Cadena, 1)
            TPC_recequivalencia = New Cdatos.bdcampo(CodigoEntidad & "recequivalencia", Cdatos.TiposCampo.Cadena, 1)
            TPC_ctacliente = New Cdatos.bdcampo(CodigoEntidad & "ctacliente", Cdatos.TiposCampo.CadenaNumero, 11)
            TPC_ctaventas = New Cdatos.bdcampo(CodigoEntidad & "ctaventas", Cdatos.TiposCampo.Cuenta, 11)
            TPC_ctaenvases = New Cdatos.bdcampo(CodigoEntidad & "ctaenvases", Cdatos.TiposCampo.Cuenta, 11)
            TPC_ctavarios = New Cdatos.bdcampo(CodigoEntidad & "ctavarios", Cdatos.TiposCampo.Cuenta, 11)
            TPC_ctaivaventas = New Cdatos.bdcampo(CodigoEntidad & "ctaivaventas", Cdatos.TiposCampo.Cuenta, 11)
            TPC_ctaivaenvases = New Cdatos.bdcampo(CodigoEntidad & "ctaivaenvases", Cdatos.TiposCampo.Cuenta, 11)
            TPC_ctaivavarios = New Cdatos.bdcampo(CodigoEntidad & "ctaivavarios", Cdatos.TiposCampo.Cuenta, 11)
            TPC_ctarecargo = New Cdatos.bdcampo(CodigoEntidad & "ctarecargo", Cdatos.TiposCampo.Cuenta, 11)
            TPC_ctadevenvases = New Cdatos.bdcampo(CodigoEntidad & "ctadevenvases", Cdatos.TiposCampo.Cuenta, 11)
            TPC_clienteinterno = New Cdatos.bdcampo(CodigoEntidad & "clienteinterno", Cdatos.TiposCampo.Cadena, 1)
            TPC_GeneraAsiento = New Cdatos.bdcampo(CodigoEntidad & "GeneraAsiento", Cdatos.TiposCampo.Cadena, 1)
            TPC_ctanoretfac = New Cdatos.bdcampo(CodigoEntidad & "ctanoretfac", Cdatos.TiposCampo.Cuenta, 11)
            TPC_ctanoretabo = New Cdatos.bdcampo(CodigoEntidad & "ctanoretabo", Cdatos.TiposCampo.Cuenta, 11)

            TPC_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            TPC_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            TPC_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select TPC_Idtipo as IdTipo, TPC_Nombre as Nombre from TiposClientes"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idtipo"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaTiposClientes"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmTiposdeClientes"

    End Sub



End Class
