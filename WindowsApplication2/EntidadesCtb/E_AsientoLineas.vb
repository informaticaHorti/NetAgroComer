Public Class E_AsientoLineas
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdApunte AS Cdatos.bdcampo
	Public IdAsiento AS Cdatos.bdcampo
	Public NumeroCuenta AS Cdatos.bdcampo
	Public IdActividad AS Cdatos.bdcampo
	Public IdSeccion AS Cdatos.bdcampo
	Public IdDepartamento AS Cdatos.bdcampo
	Public IdSubDepartamento AS Cdatos.bdcampo
	Public IdConcepto AS Cdatos.bdcampo
	Public Concepto AS Cdatos.bdcampo
	Public SRPC AS Cdatos.bdcampo
	Public Punteo AS Cdatos.bdcampo
	Public IdPunteoManual AS Cdatos.bdcampo
	Public IdPunteo43 AS Cdatos.bdcampo
	Public Debe AS Cdatos.bdcampo
	Public Haber AS Cdatos.bdcampo
	Public IdRegistro AS Cdatos.bdcampo
	Public Fecha AS Cdatos.bdcampo
	Public Tipo AS Cdatos.bdcampo
	Public TipoSRPC AS Cdatos.bdcampo
	Public FechaPunteo AS Cdatos.bdcampo
	Public Documento AS Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

			NombreTabla = "AsientoLineas"
            MiConexion = conexion
            NombreBd = ObtenerBDConexion(conexion)
            PrefijoContador = ""

            IdApunte = New Cdatos.bdcampo("IdApunte", Cdatos.TiposCampo.Entero, 10, 0, True)
			IdAsiento = New Cdatos.bdcampo("IdAsiento", Cdatos.TiposCampo.Entero, 10)
			NumeroCuenta = New Cdatos.bdcampo("NumeroCuenta", Cdatos.TiposCampo.Cadena, 15)
			IdActividad = New Cdatos.bdcampo("IdActividad", Cdatos.TiposCampo.Entero, 10)
			IdSeccion = New Cdatos.bdcampo("IdSeccion", Cdatos.TiposCampo.Entero, 10)
			IdDepartamento = New Cdatos.bdcampo("IdDepartamento", Cdatos.TiposCampo.Entero, 10)
			IdSubDepartamento = New Cdatos.bdcampo("IdSubDepartamento", Cdatos.TiposCampo.Entero, 10)
			IdConcepto = New Cdatos.bdcampo("IdConcepto", Cdatos.TiposCampo.Entero, 10)
			Concepto = New Cdatos.bdcampo("Concepto", Cdatos.TiposCampo.Cadena, 100)
			SRPC = New Cdatos.bdcampo("SRPC", Cdatos.TiposCampo.Cadena, 1)
			Punteo = New Cdatos.bdcampo("Punteo", Cdatos.TiposCampo.Cadena, 1)
			IdPunteoManual = New Cdatos.bdcampo("IdPunteoManual", Cdatos.TiposCampo.Entero, 10)
			IdPunteo43 = New Cdatos.bdcampo("IdPunteo43", Cdatos.TiposCampo.Entero, 10)
			Debe = New Cdatos.bdcampo("Debe", Cdatos.TiposCampo.Importe, 19, 2)
			Haber = New Cdatos.bdcampo("Haber", Cdatos.TiposCampo.Importe, 19, 2)
			IdRegistro = New Cdatos.bdcampo("IdRegistro", Cdatos.TiposCampo.Entero, 10)
			Fecha = New Cdatos.bdcampo("Fecha", Cdatos.TiposCampo.Fecha, 8)
			Tipo = New Cdatos.bdcampo("Tipo", Cdatos.TiposCampo.Cadena, 1)
			TipoSRPC = New Cdatos.bdcampo("TipoSRPC", Cdatos.TiposCampo.Cadena, 1)
			FechaPunteo = New Cdatos.bdcampo("FechaPunteo", Cdatos.TiposCampo.Fecha, 8)
			Documento = New Cdatos.bdcampo("Documento", Cdatos.TiposCampo.Cadena, 50)

			MiListadeCampos = ListadeCampos()


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

    End Sub


    ' saldo cuenta = debe - haber
    Public Function SaldoCuenta(ByVal cuenta As String, Optional ByVal tipoctb As String = "") As Decimal
        Dim csql As String = ""
        Dim dt As DataTable
        Dim saldo As Decimal = 0

        csql = " select sum(debe) - sum(haber) as saldo "
        csql = csql & " from AsientoLineas "
        csql = csql & " where (NumeroCuenta='" & cuenta & "') "
        If tipoctb.trim <> "" Then
            csql = csql & " and (tipo='" & tipoctb & "') "
        End If
        dt = ConexCtb(MiMaletin.IdEmpresaCTB).ConsultaSQL(csql)
        If dt.Rows.Count > 0 Then saldo = VaDec(dt.Rows(0)("saldo"))

        SaldoCuenta = saldo

    End Function


    Public Function InsertaLineaIva(ByVal idASi As Integer, ByVal NumCuenta As String, ByVal IdActi As Integer, ByVal IdSec As Integer, ByVal idDepar As Integer, ByVal idConcep As Integer, ByVal Concep As String, ByVal SRP As String, ByVal Punte As String, ByVal IdPuntMan As Integer, ByVal IdPunt43 As Integer, ByVal documen As String, ByVal deb As Decimal, ByVal hab As Decimal, ByVal idReg As Integer, ByVal idSubDep As Integer, ByVal fecha As Date, ByVal tipo As String, ByVal tipoSRPC As String) As Boolean


        Try
            Dim resultado As Boolean = False
            Me.VaciaEntidad()
            Dim id As Integer = Me.MaxId()
            If NumCuenta = "" Then
                NumCuenta = "55500000000"
            End If
            Me.IdApunte.Valor = StInt(id)
            Me.IdAsiento.Valor = StInt(idASi)
            Me.IdActividad.Valor = StInt(IdActi)
            Me.Haber.Valor = StDec(hab)
            Me.Concepto.Valor = Concep
            Me.IdConcepto.Valor = StInt(idConcep)
            Me.Debe.Valor = StDec(deb)
            Me.Documento.Valor = documen
            Me.IdDepartamento.Valor = StInt(idDepar)
            Me.IdPunteo43.Valor = StInt(IdPunt43)
            Me.IdPunteoManual.Valor = StInt(IdPuntMan)
            Me.IdRegistro.Valor = StInt(idReg)
            Me.IdSeccion.Valor = StInt(IdSec)
            Me.IdSubDepartamento.Valor = StInt(idSubDep)
            Me.NumeroCuenta.Valor = NumCuenta
            Me.Tipo.Valor = tipo
            Me.Fecha.Valor = StDate(fecha)
            Me.TipoSRPC.Valor = tipoSRPC
            Me.SRPC.Valor = SRP

            If Me.Insertar = False Then
                Throw New Exception("No se ha podido insertar la linea")
            End If
            Return True
        Catch ex As Exception
            err.MuestraError("Error cuando se intentaba obtener la tabla general de asientos", "Function Tabla", ex.Message)
            Return False
        End Try

    End Function

    Private Sub E_AsientoLineas_EliminaHijos() Handles Me.EliminaHijos
        Dim IvaSoportado As New E_IvaSoportado(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim IvaRepercutido As New E_IvaRepercutido(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        Dim Cartera As New E_Cartera(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        Dim Cartera_lineas As New E_Cartera_lineas(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))

        If Me.SRPC.Valor = "S" Then
            If IvaSoportado.LeerId(Me.IdApunte.Valor) = True Then
                IvaSoportado.Eliminar()
            End If
        End If
        If Me.SRPC.Valor = "R" Then
            If IvaRepercutido.LeerId(Me.IdApunte.Valor) = True Then
                IvaRepercutido.Eliminar()
            End If
        End If

        If Me.SRPC.Valor = "C" Or Me.SRPC.Valor = "P" Then
            If Cartera.LeerId(Me.IdApunte.Valor) = True Then
                Cartera.Eliminar()
            End If
        End If


    End Sub
    Public Function ConsultaPunteo(ByVal Cuenta As String, ByVal Dfecha As String, ByVal Hfecha As String, ByVal FechaPunteo As String, ByVal Punteados As Boolean, ByVal SoloFecha As Boolean, ByVal Nopunteados As Boolean) As DataTable
        Dim Dt As New DataTable
        Dim Sql As String
        Dim ors As String = ""
        Dim Cpun As String = ""


        Sql = "SELECT asientolineas.idapunte, Asientos.Ejercicio AS EJ,Asientos.IdCentro as CE,Asientolineas.IdAsiento, Asientos.Asiento, Asientolineas.Fecha,  asientolineas.concepto AS Concepto, AsientoLineas.Documento, AsientoLineas.Debe AS Debe, AsientoLineas.Haber AS Haber,Asientolineas.punteo " & _
                             " FROM AsientoLineas LEFT OUTER JOIN  Asientos ON AsientoLineas.IdAsiento = Asientos.IdAsiento" & _
                             " WHERE dbo.AsientoLineas.NumeroCuenta='" & Cuenta & "' AND dbo.ASientolineas.Fecha>'" & Dfecha & "' AND dbo.ASientolineas.Fecha<='" & Hfecha & "' "
        Cpun = ""
        If Punteados = True Then
            Cpun = Cpun + "(punteo<>'' and punteo<>'0') "
            ors = " or "
        End If
        If SoloFecha = True Then
            Cpun = Cpun + ors + "FechaPunteo='" + FechaPunteo + "' "
            ors = " or "
        End If
        If Nopunteados = True Then
            Cpun = Cpun + ors + " (punteo='' or punteo='0') "
        End If
        If Cpun <> "" Then
            Sql = Sql + " and ( " + Cpun + ") "

        End If
        Sql = Sql + " order by dbo.asientolineas.fecha"

        Dt = MiConexion.ConsultaSQL(Sql)
        Return Dt


    End Function
    Public Function ConsultaBusqueda(ByVal Cuenta As String, ByVal Dfecha As String, ByVal Hfecha As String, ByVal filtro As String) As DataTable
        Dim Dt As New DataTable
        Dim Sql As String
        Dim ors As String = ""
        Dim Cpun As String = ""


        Sql = "SELECT asientolineas.idapunte, Asientos.Ejercicio AS EJ,Asientos.IdCentro as CE,Asientolineas.IdAsiento, Asientos.Asiento, Asientolineas.Fecha,  asientolineas.concepto AS Concepto, AsientoLineas.Documento, AsientoLineas.Debe AS Debe, AsientoLineas.Haber AS Haber,Asientolineas.punteo " & _
                             " FROM AsientoLineas LEFT OUTER JOIN  Asientos ON AsientoLineas.IdAsiento = Asientos.IdAsiento" & _
                             " WHERE  dbo.ASientolineas.Fecha>'" & Dfecha & "' AND dbo.ASientolineas.Fecha<='" & Hfecha & "' "
        Cpun = ""
        If Cuenta <> "" Then
            Sql = Sql + " and dbo.AsientoLineas.NumeroCuenta='" & Cuenta & "' "
        End If

        If filtro <> "" Then
            Sql = Sql + " and " + filtro
        End If

        Sql = Sql + " order by dbo.asientolineas.fecha"

        Dt = MiConexion.ConsultaSQL(Sql)
        Return Dt


    End Function


    Public Function SaldoPunteado(ByVal Cuenta As String, ByVal Dfecha As String, ByVal Hfecha As String, ByVal Punteado As Boolean) As Decimal
        Dim Dt As New DataTable

        Dim s As Decimal
        If Punteado = True Then
            Dt = MiConexion.ConsultaSQL("SELECT sum(Debe) as debe, sum(Haber) as haber from asientolineas where numerocuenta='" + Cuenta + "' and fecha>'" + Dfecha + "' and fecha<='" + Hfecha + "' and (Punteo<>'' and punteo<>'0')")
            'Dt = MiConexion.ConsultaSQL("SELECT sum(Debe) as debe, sum(Haber) as haber from asientolineas where numerocuenta='" + Cuenta + "' and fecha>'" + Dfecha + "' and fecha<='" + Hfecha + "' and Punteo='1'")
        Else
            Dt = MiConexion.ConsultaSQL("SELECT sum(Debe) as debe, sum(Haber) as haber from asientolineas where numerocuenta='" + Cuenta + "' and fecha>'" + Dfecha + "' and fecha<='" + Hfecha + "' and (Punteo='' or punteo='0')")
        End If
        If Dt.Rows.Count > 0 Then

            s = VaDec(Dt.Rows(0)("debe")) - VaDec(Dt.Rows(0)("haber"))
        End If
        Return s
    End Function

End Class
