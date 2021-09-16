Public Class E_Operarios
    Inherits Cdatos.Entidad

    Public OPE_Id As Cdatos.bdcampo
    Public OPE_Nombre As Cdatos.bdcampo
    Public OPE_Rfid As Cdatos.bdcampo

    Public OPE_IdUsuarioLog As Cdatos.bdcampo
    Public OPE_FechaLog As Cdatos.bdcampo
    Public OPE_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Operarios"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            OPE_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 8, 0, True)
            OPE_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 50)
            OPE_Rfid = New Cdatos.bdcampo(CodigoEntidad & "Rfid", Cdatos.TiposCampo.Cadena, 30)

            OPE_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            OPE_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            OPE_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "SELECT OPE_Id as Id, OPE_Nombre as Nombre FROM Operarios"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaOperarios"
        _btBusca.CL_ch1000 = False


    End Sub


    Public Function ObtenerIdOperario(ByVal Codigo As String, ByRef Operario As String) As Integer

        Dim res As Integer = 0
        Operario = ""


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.OPE_Id, "IdOperario")
        consulta.SelCampo(Me.OPE_Nombre, "Operario")
        consulta.WheCampo(Me.OPE_Rfid, "=", Codigo)

        Dim dt As DataTable = MiConexion.ConsultaSQL(consulta.SQL)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                res = VaInt(dt.Rows(0)("IdOperario"))
                Operario = (dt.Rows(0)("Operario").ToString & "").Trim
            End If
        End If


        Return res

    End Function

End Class
