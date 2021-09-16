Public Class E_CHEQUES_CUENTAS
	Inherits Cdatos.Entidad

	Private err As New Errores

    Public IdCuenta As Cdatos.bdcampo
    Public Descripcion As Cdatos.bdcampo
    Public Cuenta As Cdatos.bdcampo
    Public IBAN As Cdatos.bdcampo
    Public DeTalon As Cdatos.bdcampo
    Public ATalon As Cdatos.bdcampo
    Public SerieTalon As Cdatos.bdcampo
    Public TalonActual As Cdatos.bdcampo
    Public CuentaCtb As Cdatos.bdcampo
    Public Fichero As Cdatos.bdcampo

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 

		Try

            NombreTabla = "CHEQUES_CUENTAS"
            NombreBd = "CobrosPagos"
			MiConexion = conexion

            IdCuenta = New Cdatos.bdcampo(CodigoEntidad & "IdCuenta", Cdatos.TiposCampo.Cadena, 3, 0, True)
            Descripcion = New Cdatos.bdcampo(CodigoEntidad & "Descripcion", Cdatos.TiposCampo.Cadena, 50)
            Cuenta = New Cdatos.bdcampo(CodigoEntidad & "Cuenta", Cdatos.TiposCampo.Cadena, 50)
			IBAN = New Cdatos.bdcampo(CodigoEntidad & "IBAN", Cdatos.TiposCampo.Cadena, 50)
            DeTalon = New Cdatos.bdcampo(CodigoEntidad & "DeTalon", Cdatos.TiposCampo.Cadena, 50)
            ATalon = New Cdatos.bdcampo(CodigoEntidad & "ATalon", Cdatos.TiposCampo.Cadena, 50)
            SerieTalon = New Cdatos.bdcampo(CodigoEntidad & "SerieTalon", Cdatos.TiposCampo.Cadena, 50)
            TalonActual = New Cdatos.bdcampo(CodigoEntidad & "TalonActual", Cdatos.TiposCampo.Cadena, 50)
            CuentaCtb = New Cdatos.bdcampo(CodigoEntidad & "CuentaCtb", Cdatos.TiposCampo.Cadena, 9)
            Fichero = New Cdatos.bdcampo(CodigoEntidad & "Fichero", Cdatos.TiposCampo.Cadena, 50)

            MiListadeCampos = ListadeCampos()

            Dim csql As String = ""
            csql = " select IdCuenta, Descripcion, CuentaCtb as CuentaContable from CHEQUES_CUENTAS order by IdCuenta "

            _btBusca.CL_CampoOrden = "IdCuenta"
            _btBusca.CL_ConsultaSql = csql
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "IdCuenta"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.cl_formu = Nothing
            _btBusca.Name = "BtBuscaCHEQUES_CUENTA"
            _btBusca.CL_ch1000 = False

		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

    End Sub

    Public Function xBancosCuentasUsuario(ByVal idusu As Integer) As List(Of String)
        Dim ret As New List(Of String)
        Dim csql As String = ""
        Dim dt As New DataTable

        ret.Clear()

        csql = " SELECT ChequesPermisos.IdUsuario, ChequesPermisos.Defecto, "
        csql = csql & " Cheques_Cuentas.idcuenta, Cheques_Cuentas.Descripcion, Cheques_Cuentas.cuenta "
        csql = csql & " FROM ChequesPermisos "
        csql = csql & " inner join Cheques_Cuentas on ChequesPermisos.IdCuenta = Cheques_Cuentas.IdCuenta "
        csql = csql & " where(IdUsuario=" & idusu.ToString & ") "
        csql = csql & " order by  IdUsuario, Defecto Desc "
        dt = MiConexion.ConsultaSQL(csql)
        For Each row As DataRow In dt.Rows
            Dim nomCta As String = Fnc0(row("idcuenta").ToString, 3) & "|" & row("descripcion").ToString
            ret.Add(nomCta)
        Next

        Return ret

    End Function

End Class
