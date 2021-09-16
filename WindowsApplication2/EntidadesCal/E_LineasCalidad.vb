Public Class E_LineasCalidad
    Inherits Cdatos.Entidad

    Public LIN_ID As Cdatos.bdcampo
    Public LIN_NOMBRE As Cdatos.bdcampo
    Public LIN_RESCALIDAD As Cdatos.bdcampo
    Public LIN_RESLIMPIEZA As Cdatos.bdcampo



    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Lineas"
            NombreBd = "CalidadNet"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            'If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"
            Dim CodigoEntidad As String = "LIN_"


            LIN_ID = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.EnteroPositivo, 4, 0, True)
            LIN_NOMBRE = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 50)
            LIN_RESCALIDAD = New Cdatos.bdcampo(CodigoEntidad & "Rescalidad", Cdatos.TiposCampo.Cadena, 50)
            LIN_RESLIMPIEZA = New Cdatos.bdcampo(CodigoEntidad & "Reslimpieza", Cdatos.TiposCampo.Cadena, 50)



            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try




        Dim sql As String = "Select Lineas.LIN_ID as Id, Lineas.LIN_NOMBRE as Nombre," & vbCrLf
        sql = sql & " Lineas.LIN_RESCALIDAD as Rescalidad, Lineas.LIN_RESLIMPIEZA as Reslimpieza" & vbCrLf
        sql = sql & " from Lineas"




        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = sql
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Id"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaLineas"
        _btBusca.CL_ch1000 = False
        ' _btBusca.cl_formu = "FrmEmpresas"



    End Sub



    Public Function Tabla() As DataTable


        Dim dt As DataTable = MiConexion.ConsultaSQL("SELECT LIN_ID as IdLinea, LIN_Nombre as NombreLinea FROM Lineas ORDER BY IdLinea")
        If IsNothing(dt) Then dt = New DataTable


        Return dt

    End Function


End Class
