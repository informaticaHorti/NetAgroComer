Public Class E_AmorRegistros
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdRegistro AS Cdatos.bdcampo
	Public IdElemento AS Cdatos.bdcampo
	Public Factura AS Cdatos.bdcampo
	Public FechaInicioAmor AS Cdatos.bdcampo
	Public Concepto AS Cdatos.bdcampo
	Public FechaCompra AS Cdatos.bdcampo
	Public UnidCompra AS Cdatos.bdcampo
	Public PrecioCompra AS Cdatos.bdcampo
    Public ImporteNeto As Cdatos.bdcampo
	Public ImporteAmorAnterior AS Cdatos.bdcampo
	Public FechaTope AS Cdatos.bdcampo
	Public PorcenAmor AS Cdatos.bdcampo
	Public CtaAcreedor AS Cdatos.bdcampo
	Public FechaBaja AS Cdatos.bdcampo
	Public Observaciones AS Cdatos.bdcampo
    Public TipoAmor As Cdatos.bdcampo
    Public FechaNeto As Cdatos.bdcampo
    Public numero As Cdatos.bdcampo
    Public idcentro As Cdatos.bdcampo
    Public ValorInicial As Cdatos.bdcampo
    Public idpuntoventa As Cdatos.bdcampo



	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

			NombreTabla = "AmorRegistros"
            MiConexion = conexion
            NombreBd = ObtenerBDConexion(conexion)

            IdRegistro = New Cdatos.bdcampo("IdRegistro", Cdatos.TiposCampo.Entero, 10, 0, True)
			IdElemento = New Cdatos.bdcampo("IdElemento", Cdatos.TiposCampo.Entero, 10)
			Factura = New Cdatos.bdcampo("Factura", Cdatos.TiposCampo.Cadena, 15)
            FechaInicioAmor = New Cdatos.bdcampo("FechaInicioAmor", Cdatos.TiposCampo.Fecha, 10)
			Concepto = New Cdatos.bdcampo("Concepto", Cdatos.TiposCampo.Cadena, 50)
            FechaCompra = New Cdatos.bdcampo("FechaCompra", Cdatos.TiposCampo.Fecha, 10)
			UnidCompra = New Cdatos.bdcampo("UnidCompra", Cdatos.TiposCampo.Importe, 18, 2)
			PrecioCompra = New Cdatos.bdcampo("PrecioCompra", Cdatos.TiposCampo.Importe, 18, 2)
            Importeneto = New Cdatos.bdcampo("ImporteNeto", Cdatos.TiposCampo.Importe, 18, 2)
			ImporteAmorAnterior = New Cdatos.bdcampo("ImporteAmorAnterior", Cdatos.TiposCampo.Importe, 18, 2)
            FechaTope = New Cdatos.bdcampo("FechaTope", Cdatos.TiposCampo.Fecha, 10)
			PorcenAmor = New Cdatos.bdcampo("PorcenAmor", Cdatos.TiposCampo.Importe, 18, 2)
            CtaAcreedor = New Cdatos.bdcampo("CtaAcreedor", Cdatos.TiposCampo.Cuenta, 15)
            FechaBaja = New Cdatos.bdcampo("FechaBaja", Cdatos.TiposCampo.Fecha, 10)
			Observaciones = New Cdatos.bdcampo("Observaciones", Cdatos.TiposCampo.Cadena, 50)
            TipoAmor = New Cdatos.bdcampo("TipoAmor", Cdatos.TiposCampo.Cadena, 1)
			FechaNeto = New Cdatos.bdcampo("FechaNeto", Cdatos.TiposCampo.Fecha, 8)
            numero = New Cdatos.bdcampo("numero", Cdatos.TiposCampo.Entero, 10)
            idcentro = New Cdatos.bdcampo("idcentro", Cdatos.TiposCampo.Entero, 10)
            Valorinicial = New Cdatos.bdcampo("valorinicial", Cdatos.TiposCampo.Importe, 18, 2)
            idpuntoventa = New Cdatos.bdcampo("idpuntoventa", Cdatos.TiposCampo.Entero, 10)

			MiListadeCampos = ListadeCampos()


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

	 End Sub


    Public Function MaxNumero(ByVal centro As String, ByVal vmax As Integer) As Integer

        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                max = ValorMaximo(centro, vmax)
                existe = ValorIdNumero(max.ToString, centro)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de asiento", "Function ObtieneMaxNumeroAsiento", ex.Message)
            Return 0
        End Try


    End Function


    Public Function ValorIdNumero(ByVal Numero As String, ByVal idcentro As String) As Integer
        Try
            Dim dt As New DataTable
            dt = MiConexion.ConsultaSQL("Select idregistro from AMORREGISTROS WHERE numero=" & Numero & " and idcentro=" & idcentro)
            Dim existe As Boolean = False
            If dt.Rows.Count > 0 Then
                If dt.Rows(0)(0) IsNot DBNull.Value Then
                    existe = True
                    Return CInt(dt.Rows(0)("Idregistro"))
                End If
            End If
            If existe = False Then
                Return 0
            Else
                Return 0
            End If

        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el numero de REGISTRO  del id ", "Function VALORIDNUMERO", ex.Message)
            Return 0
        End Try

    End Function

    Public Function CbTipoAmor() As DataTable
        Dim dT As New DataTable



        dT.Columns.Add(New DataColumn("Id"))
        dT.Columns.Add(New DataColumn("Nombre"))
        dT.Rows.Add("1", "Lineal")
        dT.Rows.Add("2", "Degresiva")


        Return dT

    End Function




End Class
