Public Class E_Moneda
    Inherits Cdatos.Entidad


    Private err As New Errores

    Public MON_IdMoneda As Cdatos.bdcampo
    Public MON_Nombre As Cdatos.bdcampo
    Public MON_Cambio As Cdatos.bdcampo
    Public MON_Simbolo As Cdatos.bdcampo
    Public MON_Abreviatura As Cdatos.bdcampo


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "Moneda"
            MiConexion = conexion
            NombreBd = "NetAgroComer"


            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            MON_IdMoneda = New Cdatos.bdcampo(CodigoEntidad & "IdMoneda", Cdatos.TiposCampo.Entero, 10, 0, True)
            MON_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 20)
            MON_Cambio = New Cdatos.bdcampo(CodigoEntidad & "Cambio", Cdatos.TiposCampo.Importe, 18, 2)
            MON_Simbolo = New Cdatos.bdcampo(CodigoEntidad & "Simbolo", Cdatos.TiposCampo.Cadena, 1)
            MON_Abreviatura = New Cdatos.bdcampo(CodigoEntidad & "Abreviatura", Cdatos.TiposCampo.Cadena, 5)


            MiListadeCampos = ListadeCampos()

            btBusca.CL_CampoOrden = "nombre"
            btBusca.CL_ConsultaSql = "SELECT MON_IdMoneda as IdMoneda, MON_Nombre as Nombre FROM Moneda"
            btBusca.CL_ControlAsociado = Nothing
            btBusca.CL_DevuelveCampo = "IdMoneda"
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
