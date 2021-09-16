Public Class E_Moneda
    Inherits Cdatos.Entidad


    Private err As New Errores

    Public IdMoneda As Cdatos.bdcampo
    Public Nombre As Cdatos.bdcampo
    Public Cambio As Cdatos.bdcampo
    Public Simbolo As Cdatos.bdcampo


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "Moneda"
            MiConexion = conexion
            NombreBd = "Comun"


            IdMoneda = New Cdatos.bdcampo(CodigoEntidad & "IdMoneda", Cdatos.TiposCampo.Entero, 10, 0, True)
            Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 20)
            Cambio = New Cdatos.bdcampo(CodigoEntidad & "Cambio", Cdatos.TiposCampo.Importe, 18, 2)
            Simbolo = New Cdatos.bdcampo(CodigoEntidad & "Simbolo", Cdatos.TiposCampo.Cadena, 1)

            MiListadeCampos = ListadeCampos()

            btBusca.CL_CampoOrden = "nombre"
            btBusca.CL_ConsultaSql = "Select IdMoneda, Nombre from Moneda"
            btBusca.CL_ControlAsociado = Nothing
            btBusca.CL_DevuelveCampo = "idmoneda"
            btBusca.CL_Entidad = Nothing
            btBusca.CL_Filtro = Nothing
            btBusca.cl_formu = Nothing
            btBusca.Location = New System.Drawing.Point(134, 303)
            btBusca.Name = "BtBuscaMoneda"
            btBusca.Size = New System.Drawing.Size(33, 23)
            btBusca.UseVisualStyleBackColor = True


        Catch ex As Exception
            err.MuestraError("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


    Public Function CbDivisa() As DataTable

        Dim dt As New DataTable

        dt.Columns.Add(New DataColumn("Id"))
        dt.Columns.Add(New DataColumn("Nombre"))

        dt.Rows.Add(1, "Euros")
        dt.Rows.Add(0, "Divisa")

        Return dt

    End Function


End Class
