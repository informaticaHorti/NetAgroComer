Public Class E_Grupos

    Inherits Cdatos.Entidad


    Private err As New Errores

    Public Idgrupo As Cdatos.bdcampo
    Public Nombre As Cdatos.bdcampo
    Public Idresponsable1 As Cdatos.bdcampo
    Public IdResponsable2 As Cdatos.bdcampo
    Public IdResponsable3 As Cdatos.bdcampo



    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "Grupos"
            MiConexion = conexion
            NombreBd = "Comun"


            Idgrupo = New Cdatos.bdcampo("Idgrupo", Cdatos.TiposCampo.Entero, 10, 0, True)
            Nombre = New Cdatos.bdcampo("Nombre", Cdatos.TiposCampo.Cadena, 50)
            Idresponsable1 = New Cdatos.bdcampo("Idresponsable1", Cdatos.TiposCampo.Entero, 10)
            IdResponsable2 = New Cdatos.bdcampo("Idresponsable2", Cdatos.TiposCampo.Entero, 10)
            IdResponsable3 = New Cdatos.bdcampo("Idresponsable3", Cdatos.TiposCampo.Entero, 10)

            MiListadeCampos = ListadeCampos()

            btBusca.CL_CampoOrden = "nombre"
            btBusca.CL_ConsultaSql = "Select idgrupo, nombre from grupos"
            btBusca.CL_ControlAsociado = Nothing
            btBusca.CL_DevuelveCampo = "idgrupo"
            btBusca.CL_Entidad = Nothing
            btBusca.CL_Filtro = Nothing
            btBusca.cl_formu = Nothing
            btBusca.Location = New System.Drawing.Point(134, 303)
            btBusca.Name = "BtBuscaGrupos"
            btBusca.Size = New System.Drawing.Size(33, 23)
            btBusca.UseVisualStyleBackColor = True


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


End Class
