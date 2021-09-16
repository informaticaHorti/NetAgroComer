Public Class E_DocumentosBancos
    Inherits Cdatos.Entidad

    Public DDB_Id As Cdatos.bdcampo
    Public DDB_IdBanco As Cdatos.bdcampo
    Public DDB_Alias As Cdatos.bdcampo
    Public DDB_TipoDocumento As Cdatos.bdcampo
    Public DDB_Archivo As Cdatos.bdcampo

    Public DDB_IdUsuarioLog As Cdatos.bdcampo
    Public DDB_FechaLog As Cdatos.bdcampo
    Public DDB_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "DocumentosBancos"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            DDB_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            DDB_IdBanco = New Cdatos.bdcampo(CodigoEntidad & "IdBanco", Cdatos.TiposCampo.EnteroPositivo, 10, 0)
            DDB_Alias = New Cdatos.bdcampo(CodigoEntidad & "Alias", Cdatos.TiposCampo.Cadena, 150)
            DDB_TipoDocumento = New Cdatos.bdcampo(CodigoEntidad & "TipoDocumento", Cdatos.TiposCampo.Cadena, 25)
            DDB_Archivo = New Cdatos.bdcampo(CodigoEntidad & "Archivo", Cdatos.TiposCampo.Cadena, 250)

            DDB_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            DDB_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            DDB_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        


    End Sub


    Public Function Tabla(IdTipoDocumento As Integer) As DataTable

        Dim sql As String = "SELECT DDB_Id as Id, DDB_Alias as Nombre FROM DocumentosBancos" & vbCrLf
        If VaInt(IdTipoDocumento) > 0 Then


            Select Case VaInt(IdTipoDocumento)

                Case VaInt(E_Agricultores.FormasPago.Talon)
                    sql = sql & " WHERE (DDB_TipoDocumento like '%TALON%' OR DDB_TipoDocumento like '%TALÓN%')" & vbCrLf

                Case VaInt(E_Agricultores.FormasPago.Pagare)
                    sql = sql & " WHERE (DDB_TipoDocumento like '%PAGARE%' OR DDB_TipoDocumento like '%PAGARÉ%')" & vbCrLf

            End Select


        End If

        Dim dt As DataTable = MiConexion.ConsultaSQL(sql)

        Return dt

    End Function

End Class
