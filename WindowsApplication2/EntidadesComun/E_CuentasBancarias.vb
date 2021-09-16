Public Class E_CuentasBancarias
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdCuenta AS Cdatos.bdcampo
	Public IdOficina AS Cdatos.bdcampo
	Public NIF AS Cdatos.bdcampo
	Public DC AS Cdatos.bdcampo
	Public NumeroCuenta AS Cdatos.bdcampo
    Public Defecto As Cdatos.bdcampo

    Public IBAN As Cdatos.bdcampo
    Public FechaMandato As Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 

        Dim EntidadesBancarias As New E_EntidadesBancarias(idUsuario, Cncomun)
        Dim OficinasBancarias As New E_OficinasBancarias(idUsuario, Cncomun)

		Try

			NombreTabla = "CuentasBancarias"
			MiConexion = conexion
            NombreBd = "comun"

            IdCuenta = New Cdatos.bdcampo(CodigoEntidad & "IdCuenta", Cdatos.TiposCampo.Entero, 10, 0, True)
			IdOficina = New Cdatos.bdcampo(CodigoEntidad & "IdOficina", Cdatos.TiposCampo.Entero, 10)
			NIF = New Cdatos.bdcampo(CodigoEntidad & "NIF", Cdatos.TiposCampo.Cadena, 15)
			DC = New Cdatos.bdcampo(CodigoEntidad & "DC", Cdatos.TiposCampo.Cadena, 2)
			NumeroCuenta = New Cdatos.bdcampo(CodigoEntidad & "NumeroCuenta", Cdatos.TiposCampo.Cadena, 10)
            Defecto = New Cdatos.bdcampo(CodigoEntidad & "Defecto", Cdatos.TiposCampo.Cadena, 1)

            IBAN = New Cdatos.bdcampo("IBAN", Cdatos.TiposCampo.Cadena, 50)
            FechaMandato = New Cdatos.bdcampo("FechaMandato", Cdatos.TiposCampo.Fecha, 8)

			MiListadeCampos = ListadeCampos()


            Dim Consulta As New Cdatos.E_select

            Consulta.SelCampo(IdCuenta)
            Consulta.SelCampo(OficinasBancarias.Nombre, "Oficina", IdOficina)
            Consulta.SelCampo(EntidadesBancarias.Nombre, "Banco", OficinasBancarias.IdEntidad)
            Consulta.SelCampo(NumeroCuenta)
            Consulta.SelCampo(NIF)

            _btBusca.CL_CampoOrden = "Idcuenta"
            _btBusca.CL_ConsultaSql = Consulta.SQL
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "idcuenta"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.cl_formu = Nothing
            _btBusca.Name = "BtBuscaCuentaBanco"
            _btBusca.CL_ch1000 = False


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

    End Sub


    Public Function ObtenCuentaCompleta(Optional ByVal IdCuenta As String = "") As String

        Dim resultado As String = ""



        If IdCuenta = "" Then IdCuenta = Me.IdCuenta.Valor

        If Me.LeerId(IdCuenta) Then

            Dim ofi As New E_OficinasBancarias(Idusuario, Cncomun)
            If ofi.LeerId(IdOficina.Valor) Then

                Dim enti As New E_EntidadesBancarias(Idusuario, Cncomun)
                If enti.LeerId(ofi.IdEntidad.Valor) Then
                    resultado = enti.NumeroBanco.Valor & ofi.NumeroOficina.Valor & Me.DC.Valor & Me.NumeroCuenta.Valor
                End If

            End If

        End If

        Return resultado

    End Function


    'Public Function TablaCuentasNif(ByVal nif As String) As DataTable
    '    Dim dt As New DataTable
    '    dt = MiConexion.ConsultaSQL("SELECT     dbo.CuentasBancarias.NIF,dbo.CuentasBancarias.NumeroCuenta,dbo.CuentasBancarias.DC, dbo.CuentasBancarias.IdCuenta, dbo.CuentasBancarias.IdOficina, dbo.EntidadesBancarias.Nombre AS Banco, " & _
    '                  " dbo.OficinasBancarias.Nombre AS Oficina, " & _
    '                  " dbo.EntidadesBancarias.NumeroBanco + ' ' + dbo.OficinasBancarias.NumeroOficina + ' ' + dbo.CuentasBancarias.DC + ' ' + dbo.CuentasBancarias.NumeroCuenta AS CuentaBancaria," & _
    '                  " dbo.CuentasBancarias.Defecto FROM         dbo.CuentasBancarias INNER JOIN " & _
    '                  " dbo.OficinasBancarias ON dbo.CuentasBancarias.IdOficina = dbo.OficinasBancarias.IdOficina INNER JOIN " & _
    '                  " dbo.EntidadesBancarias ON dbo.OficinasBancarias.IdEntidad = dbo.EntidadesBancarias.IdEntidad INNER JOIN " & _
    '                  " dbo.NIF ON dbo.CuentasBancarias.NIF = dbo.NIF.NIF Where CuentasBancarias.Nif='" & nif & "'  ")

    '    Return dt
    'End Function


End Class
