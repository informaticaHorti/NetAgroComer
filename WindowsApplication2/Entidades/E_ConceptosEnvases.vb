﻿Public Class E_ConceptosEnvases
    Inherits Cdatos.Entidad


    Public COE_Idconcepto As Cdatos.bdcampo
    Public COE_Nombre As Cdatos.bdcampo

    Public COE_IdUsuarioLog As Cdatos.bdcampo
    Public COE_FechaLog As Cdatos.bdcampo
    Public COE_HoraLog As Cdatos.bdcampo

    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "ConceptosEnvases"
            NombreBd = "NetAgroComer"
            MiConexion = conexion


            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            COE_Idconcepto = New Cdatos.bdcampo(CodigoEntidad & "Idconcepto", Cdatos.TiposCampo.Entero, 3, 0, True)
            COE_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 30)

            COE_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            COE_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            COE_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select COE_Idconcepto as IdConcepto, COE_Nombre as Nombre from conceptosenvases"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idconcepto"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaConceptosenvases"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmConcepEnvases"

    End Sub

    Public Function Tabla() As DataTable
        Dim dt As New DataTable
        dt = MiConexion.ConsultaSQL("Select COE_Idconcepto, COE_Nombre from conceptosenvases order by COE_idconcepto")

        Return dt
    End Function

End Class
