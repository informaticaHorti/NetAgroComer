Public Class E_centros
    Inherits Cdatos.Entidad
    Public IdCentro As Cdatos.bdcampo
    Public Nombre As Cdatos.bdcampo
    Public CuentaCliente As Cdatos.bdcampo
    Public GenerarAsientoVb6 As Cdatos.bdcampo
    Public EjercicioVB6 As Cdatos.bdcampo
    Public Suministros As Cdatos.bdcampo
    Public Exportacion As Cdatos.bdcampo
    Public Localidad As Cdatos.bdcampo

    Public Const CodigoTERCEROS As Integer = 6
    Public Const CodigoFITO As Integer = 7
    Public Const CodigoSANAGUSTIN As Integer = 8
    Public Const CodigoEXPORTACION As Integer = 9




    Dim err As Errores



    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Centros"
            MiConexion = conexion
            NombreBd = ObtenerBDConexion(conexion)


            PrefijoContador = ""

            IdCentro = New Cdatos.bdcampo(CodigoEntidad & "Idcentro", Cdatos.TiposCampo.Entero, 2, 0, True)
            Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 30)
            CuentaCliente = New Cdatos.bdcampo(CodigoEntidad & "CuentaCliente", Cdatos.TiposCampo.Cadena, 6)
            GenerarAsientoVb6 = New Cdatos.bdcampo(CodigoEntidad & "GenerarAsientoVB6", Cdatos.TiposCampo.Cadena, 1)
            EjercicioVB6 = New Cdatos.bdcampo(CodigoEntidad & "EjercicioVB6", Cdatos.TiposCampo.Cadena, 2)
            Suministros = New Cdatos.bdcampo(CodigoEntidad & "Suministros", Cdatos.TiposCampo.Cadena, 1)
            Exportacion = New Cdatos.bdcampo(CodigoEntidad & "Exportacion", Cdatos.TiposCampo.Cadena, 1)
            Localidad = New Cdatos.bdcampo(CodigoEntidad & "Localidad", Cdatos.TiposCampo.Cadena, 50)

            MiListadeCampos = ListadeCampos()

            Creaboton()



        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub

    Private Sub Creaboton()

        btBusca.CL_CampoOrden = "idcentro"
        btBusca.CL_ConsultaSql = "Select idcentro,nombre from centros"
        btBusca.CL_ControlAsociado = Nothing
        btBusca.CL_DevuelveCampo = "idcentro"
        btBusca.CL_Entidad = Nothing
        btBusca.CL_Filtro = Nothing
        btBusca.cl_formu = Nothing
        btBusca.Location = New System.Drawing.Point(134, 303)
        btBusca.Name = "BtBuscaCentros"
        btBusca.Size = New System.Drawing.Size(33, 23)
        btBusca.UseVisualStyleBackColor = True

    End Sub

    Public Function TablaCentros() As DataTable
        Dim dt As New DataTable
        dt = MiConexion.ConsultaSQL("Select IdCentro, Nombre from centros order by idcentro")
        Return dt
    End Function


    Public Function TablaCentrosCtaCliente() As DataTable
        Dim dt As New DataTable
        dt = MiConexion.ConsultaSQL("Select IdCentro, Nombre, CuentaCliente from centros order by idcentro")
        Return dt
    End Function

    Public Function SeccionCentro(ByVal Idcentro As Integer) As Integer
        ' cogo la seccion del primer punto de venta del centro
        Dim id As Integer = 0
        Dim sql As String = ""
        Dim dt As New DataTable
        Dim s As Integer = 0


        sql = "Select * from puntoventa where idcentro=" + Idcentro.ToString + " order by idcentro"
        dt = MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                s = dt.Rows(0)("idseccion")
            End If
        End If
        Return s

    End Function

    Public Function ActividadCentro(ByVal Idcentro As Integer) As Integer
        ' cogo la actividad del primer punto de venta del centro
        Dim id As Integer = 0
        Dim sql As String = ""
        Dim dt As New DataTable
        Dim s As Integer = 0


        sql = "Select * from puntoventa where idcentro=" + Idcentro.ToString + " order by idcentro"
        dt = MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                s = dt.Rows(0)("idactividad")
            End If
        End If
        Return s

    End Function

End Class
