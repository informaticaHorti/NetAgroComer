Public Class E_MedidasPalet
    Inherits Cdatos.Entidad

    Public PLM_Id As Cdatos.bdcampo
    Public PLM_Medidas As Cdatos.bdcampo

    Public PLM_IdUsuarioLog As Cdatos.bdcampo
    Public PLM_FechaLog As Cdatos.bdcampo
    Public PLM_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "MedidasPalet"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            PLM_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 3, 0, True)
            PLM_Medidas = New Cdatos.bdcampo(CodigoEntidad & "Medidas", Cdatos.TiposCampo.Cadena, 25)

            PLM_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PLM_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PLM_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Medidas"
        _btBusca.CL_ConsultaSql = "Select PLM_Id as Id, PLM_Medidas as Medidas from MedidasPalet"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaMedidas"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmMedidas"

    End Sub

  
End Class
