Public Class E_Marcas
    Inherits Cdatos.Entidad

    Public MAR_Idmarca As Cdatos.bdcampo
    Public MAR_Nombre As Cdatos.bdcampo
    Public MAR_Envase As Cdatos.bdcampo
    Public MAR_Material As Cdatos.bdcampo
    Public MAR_Etiqueta As Cdatos.bdcampo

    Public MAR_IdUsuarioLog As Cdatos.bdcampo
    Public MAR_FechaLog As Cdatos.bdcampo
    Public MAR_HoraLog As Cdatos.bdcampo


    Public BtBuscaXconfec As BtBusca


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Marcas"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            MAR_Idmarca = New Cdatos.bdcampo(CodigoEntidad & "idmarca", Cdatos.TiposCampo.EnteroPositivo, 3, 0, True)
            MAR_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 25)
            MAR_Envase = New Cdatos.bdcampo(CodigoEntidad & "Envase", Cdatos.TiposCampo.Cadena, 1)
            MAR_Material = New Cdatos.bdcampo(CodigoEntidad & "Material", Cdatos.TiposCampo.Cadena, 1)
            MAR_Etiqueta = New Cdatos.bdcampo(CodigoEntidad & "Etiqueta", Cdatos.TiposCampo.Cadena, 1)

            MAR_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            MAR_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            MAR_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select MAR_Idmarca as IdMarca, MAR_Nombre as Nombre, MAR_Envase as Env, MAR_Material as Mat, MAR_Etiqueta as Eti from Marcas"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdMarca"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaMarcas"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmMarcas"

        Dim SQL As String
        Dim Consulta As New Cdatos.E_select
        Dim Generoscategoria As New E_GenerosCategorias(idUsuario, cn)
        Dim GenerosSalida As New E_GenerosSalida(idUsuario, cn)


        BtBuscaXconfec = New BtBusca()
        BtBuscaXconfec.Image = Global.NetAgro.My.Resources.Lupa16_
        BtBuscaXconfec.Location = New System.Drawing.Point(134, 303)
        BtBuscaXconfec.Size = New System.Drawing.Size(33, 23)
        BtBuscaXconfec.UseVisualStyleBackColor = True

        BtBuscaXconfec.CL_CampoOrden = "MARCA"
        Consulta.SelCampo(Generoscategoria.GCA_codigo, "idmarca")
        Consulta.SelCampo(Me.MAR_Nombre, "Marca", Generoscategoria.GCA_codigo)
        Consulta.SelCampo(GenerosSalida.GES_Idgensal, "idpresentacion", Generoscategoria.GCA_idpresentacion)
        Consulta.WheCampo(Generoscategoria.GCA_tipo, "=", "M")
        SQL = Consulta.SQL
        SQL = SQL.Replace("Select", "Select distinct")

        BtBuscaXconfec.CL_ConsultaSql = SQL
        BtBuscaXconfec.CL_ControlAsociado = Nothing

        BtBuscaXconfec.CL_DevuelveCampo = "idmarca"
        BtBuscaXconfec.CL_Entidad = Me
        BtBuscaXconfec.CL_Filtro = Nothing
        BtBuscaXconfec.Name = "BtBuscamarca"
        BtBuscaXconfec.CL_ch1000 = False
        BtBuscaXconfec.cl_formu = "FrmMarcas"


        
    End Sub

  
End Class
