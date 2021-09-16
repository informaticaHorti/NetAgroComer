Public Class E_FacturasRecibidasImportaciones
	Inherits Cdatos.Entidad


	Private err As New Errores

    Public FRI_idfactura As Cdatos.bdcampo
    Public FRI_idcuenta As Cdatos.bdcampo

    'SII
    Public FRI_TipoIdentificacion As Cdatos.bdcampo
    Public FRI_CodigoPais As Cdatos.bdcampo

    Public FRI_nif As Cdatos.bdcampo
    Public FRI_IdTipoIva As Cdatos.bdcampo
    Public FRI_Base As Cdatos.bdcampo
    Public FRI_PorcentajeIva As Cdatos.bdcampo
    Public FRI_CuotaIva As Cdatos.bdcampo
    Public FRI_Concepto As Cdatos.bdcampo
    Public FRI_Documento As Cdatos.bdcampo
    Public FRI_BaseSuplido As Cdatos.bdcampo
    Public FRI_CuentaSuplido As Cdatos.bdcampo



    Public FRI_IdUsuarioLog As Cdatos.bdcampo
    Public FRI_FechaLog As Cdatos.bdcampo
    Public FRI_HoraLog As Cdatos.bdcampo


	Public Sub New() 
		Me.New(0, nothing)
	End Sub


	Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
		MyBase.New(idUsuario) 


		Try

            NombreTabla = "FacturasRecibidasImportaciones"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            FRI_idfactura = New Cdatos.bdcampo(CodigoEntidad & "idfactura", Cdatos.TiposCampo.Cadena, 10, , True)
            FRI_idcuenta = New Cdatos.bdcampo(CodigoEntidad & "idcuenta", Cdatos.TiposCampo.Cadena, 11)
            FRI_TipoIdentificacion = New Cdatos.bdcampo(CodigoEntidad & "TipoIdentificacion", Cdatos.TiposCampo.Cadena, 2)
            FRI_CodigoPais = New Cdatos.bdcampo(CodigoEntidad & "CodigoPais", Cdatos.TiposCampo.Cadena, 2)
            FRI_nif = New Cdatos.bdcampo(CodigoEntidad & "nif", Cdatos.TiposCampo.Cadena, 15)
            FRI_IdTipoIva = New Cdatos.bdcampo(CodigoEntidad & "IdTipoIva", Cdatos.TiposCampo.Entero, 10)
            FRI_Base = New Cdatos.bdcampo(CodigoEntidad & "Base", Cdatos.TiposCampo.Importe, 19, 2)
            FRI_PorcentajeIva = New Cdatos.bdcampo(CodigoEntidad & "PorcentajeIva", Cdatos.TiposCampo.Importe, 19, 2)
            FRI_CuotaIva = New Cdatos.bdcampo(CodigoEntidad & "CuotaIva", Cdatos.TiposCampo.Importe, 19, 2)
            FRI_Concepto = New Cdatos.bdcampo(CodigoEntidad & "Concepto", Cdatos.TiposCampo.Cadena, 50)
            FRI_Documento = New Cdatos.bdcampo(CodigoEntidad & "Documento", Cdatos.TiposCampo.Cadena, 50)
            FRI_BaseSuplido = New Cdatos.bdcampo(CodigoEntidad & "BaseSuplido", Cdatos.TiposCampo.Importe, 19, 2)
            FRI_CuentaSuplido = New Cdatos.bdcampo(CodigoEntidad & "CuentaSuplido", Cdatos.TiposCampo.Cadena, 11)

            FRI_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            FRI_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            FRI_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


			MiListadeCampos = ListadeCampos()


		Catch ex as Exception
			err.MuestraError("Error cuando se inicializo la clase","New", ex.Message)
		 End Try

    End Sub


    Public Function BorrarPorFactura(IdFactura As String)

        Dim bRes As Boolean = True

        Try

            Dim sql As String = "DELETE FROM FacturasRecibidasImportaciones WHERE FRI_IdFactura = '" & IdFactura & "'"
            bRes = MiConexion.OrdenSql(sql)

        Catch ex As Exception
            err.Muestraerror("Error al borrar las Imporaciones de la factura " & IdFactura, "BorrarPorFactura", ex.Message)
            bRes = False
        End Try


        Return bRes

    End Function




End Class
