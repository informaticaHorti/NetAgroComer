Public Class E_CobrosLineas
	Inherits Cdatos.Entidad


	Private err As New Errores

    Public CBL_IdLinea As Cdatos.bdcampo
    Public CBL_IdCobro As Cdatos.bdcampo
    Public CBL_IdFactura As Cdatos.bdcampo
    Public CBL_ImporteCobradoDivisa As Cdatos.bdcampo
    Public CBL_IdDivisa As Cdatos.bdcampo
    Public CBL_Cambio As Cdatos.bdcampo

    Public CBL_IdUsuarioLog As Cdatos.bdcampo
    Public CBL_FechaLog As Cdatos.bdcampo
    Public CBL_HoraLog As Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

			NombreTabla = "CobrosLineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"


            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"



            CBL_IdLinea = New Cdatos.bdcampo(CodigoEntidad & "IdLinea", Cdatos.TiposCampo.Entero, 6, 0, True)
            CBL_IdCobro = New Cdatos.bdcampo(CodigoEntidad & "IdCobro", Cdatos.TiposCampo.Entero, 6)
            CBL_IdFactura = New Cdatos.bdcampo(CodigoEntidad & "IdFactura", Cdatos.TiposCampo.Entero, 8)
            CBL_ImporteCobradoDivisa = New Cdatos.bdcampo(CodigoEntidad & "ImporteCobradoDivisa", Cdatos.TiposCampo.Importe, 18, 2)
            CBL_IdDivisa = New Cdatos.bdcampo(CodigoEntidad & "IdDivisa", Cdatos.TiposCampo.Entero, 3)
            CBL_Cambio = New Cdatos.bdcampo(CodigoEntidad & "Cambio", Cdatos.TiposCampo.Importe, 18, 6)

            CBL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CBL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CBL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


			MiListadeCampos = ListadeCampos()


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

    End Sub


    Public Function CobradoFactura(ByVal idfactura As Integer, Optional ByRef NumCobros As Integer = 0) As Decimal
        Dim sql As String = ""
        Dim dt As New DataTable
        Dim ret As Decimal = 0


        sql = "Select sum(CBL_importecobradodivisa) as cobrado from cobroslineas where CBL_idfactura=" + idfactura.ToString

        dt = Me.MiConexion.ConsultaSQL(sql)

        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                If IsDBNull(dt.Rows(0)(0)) = False Then
                    ret = dt.Rows(0)(0)
                End If
                NumCobros = dt.Rows.Count
            End If
        End If


        Return ret

    End Function


End Class
