Public Class E_AlbSalida_Lineas_Desglose
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public ASD_Id AS Cdatos.bdcampo
	Public ASD_IdLineaAlbSalida AS Cdatos.bdcampo
	Public ASD_IdAlbaran AS Cdatos.bdcampo
    Public ASD_BultosVendidos As Cdatos.bdcampo
	Public ASD_KilosVendidos AS Cdatos.bdcampo
	Public ASD_PiezasVendidas AS Cdatos.bdcampo
	Public ASD_PrecioVenta AS Cdatos.bdcampo
    Public ASD_TipoKBP As Cdatos.bdcampo
    Public ASD_ImporteVenta As Cdatos.bdcampo

    Public ASD_IdUsuarioLog As Cdatos.bdcampo
    Public ASD_FechaLog As Cdatos.bdcampo
    Public ASD_HoraLog As Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

			NombreTabla = "AlbSalida_Lineas_Desglose"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            ASD_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.Entero, 10, 0, True)
            ASD_IdLineaAlbSalida = New Cdatos.bdcampo(CodigoEntidad & "IdLineaAlbSalida", Cdatos.TiposCampo.Entero, 10)
            ASD_IdAlbaran = New Cdatos.bdcampo(CodigoEntidad & "IdAlbaran", Cdatos.TiposCampo.Entero, 10)
            ASD_BultosVendidos = New Cdatos.bdcampo(CodigoEntidad & "BultosVendidos", Cdatos.TiposCampo.Entero, 10)
            ASD_KilosVendidos = New Cdatos.bdcampo(CodigoEntidad & "KilosVendidos", Cdatos.TiposCampo.Importe, 10, 2)
            ASD_PiezasVendidas = New Cdatos.bdcampo(CodigoEntidad & "PiezasVendidas", Cdatos.TiposCampo.Entero, 10)
            ASD_PrecioVenta = New Cdatos.bdcampo(CodigoEntidad & "PrecioVenta", Cdatos.TiposCampo.Importe, 10, 4)
            ASD_TipoKBP = New Cdatos.bdcampo(CodigoEntidad & "TipoKBP", Cdatos.TiposCampo.Cadena, 1)
            ASD_ImporteVenta = New Cdatos.bdcampo(CodigoEntidad & "ImporteVenta", Cdatos.TiposCampo.Importe, 10, 2)

            ASD_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            ASD_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            ASD_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)

			MiListadeCampos = ListadeCampos()


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

	 End Sub


    Public Sub BorrarDesgloseLinea(IdLineaAlbSalida As String)

        If VaInt(IdLineaAlbSalida) > 0 Then

            Dim AlbSalida_Lineas_Desglose As New E_AlbSalida_Lineas_Desglose(Idusuario, cn)


            Dim dt As DataTable = AlbSalida_Lineas_Desglose.DesgloseLinea(IdLineaAlbSalida)

            If Not IsNothing(dt) Then
                For Each row As DataRow In dt.Rows

                    Dim Id As String = (row("ASD_Id").ToString & "").Trim
                    If AlbSalida_Lineas_Desglose.LeerId(Id) Then
                        AlbSalida_Lineas_Desglose.Eliminar()
                    End If

                Next
            End If


        End If

    End Sub


    Public Function DesgloseLinea(IdLineaAlbSalida As String) As DataTable

        Dim dt As DataTable = Nothing


        If VaInt(IdLineaAlbSalida) > 0 Then

            Dim sql As String = "SELECT * FROM AlbSalida_Lineas_Desglose"
            sql = sql & " WHERE ASD_IdLineaAlbSalida = '" & IdLineaAlbSalida & "'"
            dt = MiConexion.ConsultaSQL(sql)

        End If


        Return dt

    End Function


End Class
