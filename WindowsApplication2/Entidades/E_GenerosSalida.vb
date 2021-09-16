Public Class E_GenerosSalida
    Inherits Cdatos.Entidad

    Public GES_Idgensal As Cdatos.bdcampo
    Public GES_IdGenero As Cdatos.bdcampo
    Public GES_Idconfec As Cdatos.bdcampo
    Public GES_Nombre As Cdatos.bdcampo
    Public GES_PesoFijo As Cdatos.bdcampo
    Public GES_KilosXBulto As Cdatos.bdcampo
    Public GES_PiezasXBulto As Cdatos.bdcampo
    Public GES_GtoXKilo As Cdatos.bdcampo
    Public GES_Activo As Cdatos.bdcampo
    Public GES_SobrecosteMat As Cdatos.bdcampo
    Public GES_idmarcaenvase As Cdatos.bdcampo
    Public GES_idmarcamaterial As Cdatos.bdcampo
    Public GES_idmarcaetiqueta As Cdatos.bdcampo
    Public GES_pedirmarcamat As Cdatos.bdcampo
    Public GES_pedirmarcaeti As Cdatos.bdcampo
    Public GES_DescripcionAlb As Cdatos.bdcampo
    Public GES_GeneroQS As Cdatos.bdcampo
    Public GES_DEMETER As Cdatos.bdcampo

    Public GES_IdUsuarioLog As Cdatos.bdcampo
    Public GES_FechaLog As Cdatos.bdcampo
    Public GES_HoraLog As Cdatos.bdcampo


    Public BtBuscaXconfec As BtBusca
    Public BtBuscaXConfecSalida As BtBusca
    Public BtBuscaXconfecCliente As BtBusca


    Dim err As Errores



    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "GenerosSalida"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            GES_Idgensal = New Cdatos.bdcampo(CodigoEntidad & "idgensal", Cdatos.TiposCampo.Entero, 5, 0, True)
            GES_IdGenero = New Cdatos.bdcampo(CodigoEntidad & "idgenero", Cdatos.TiposCampo.Entero, 5)
            GES_Idconfec = New Cdatos.bdcampo(CodigoEntidad & "idconfec", Cdatos.TiposCampo.EnteroPositivo, 5)
            GES_Nombre = New Cdatos.bdcampo(CodigoEntidad & "nombre", Cdatos.TiposCampo.Cadena, 55)
            GES_PesoFijo = New Cdatos.bdcampo(CodigoEntidad & "pesofijo", Cdatos.TiposCampo.Cadena, 1)
            GES_KilosXBulto = New Cdatos.bdcampo(CodigoEntidad & "kilosxbulto", Cdatos.TiposCampo.Importe, 5, 2)
            GES_PiezasXBulto = New Cdatos.bdcampo(CodigoEntidad & "piezasxbulto", Cdatos.TiposCampo.EnteroPositivo, 4)
            GES_GtoXKilo = New Cdatos.bdcampo(CodigoEntidad & "gtoxkilo", Cdatos.TiposCampo.Importe, 5, 4)
            GES_Activo = New Cdatos.bdcampo(CodigoEntidad & "activo", Cdatos.TiposCampo.Cadena, 1)
            GES_SobrecosteMat = New Cdatos.bdcampo(CodigoEntidad & "sobrecostemat", Cdatos.TiposCampo.Importe, 5, 4)
            GES_idmarcaenvase = New Cdatos.bdcampo(CodigoEntidad & "idmarcaenvase", Cdatos.TiposCampo.EnteroPositivo, 4)
            GES_idmarcamaterial = New Cdatos.bdcampo(CodigoEntidad & "idmarcamaterial", Cdatos.TiposCampo.EnteroPositivo, 4)
            GES_idmarcaetiqueta = New Cdatos.bdcampo(CodigoEntidad & "idmarcaetiqueta", Cdatos.TiposCampo.EnteroPositivo, 4)
            GES_pedirmarcamat = New Cdatos.bdcampo(CodigoEntidad & "pedirmarcamat", Cdatos.TiposCampo.Cadena, 1)
            GES_pedirmarcaeti = New Cdatos.bdcampo(CodigoEntidad & "pedirmarcaeti", Cdatos.TiposCampo.Cadena, 1)
            GES_DescripcionAlb = New Cdatos.bdcampo(CodigoEntidad & "DescripcionAlb", Cdatos.TiposCampo.Cadena, 55)
            GES_GeneroQS = New Cdatos.bdcampo(CodigoEntidad & "GeneroQS", Cdatos.TiposCampo.Cadena, 1)
            GES_DEMETER = New Cdatos.bdcampo(CodigoEntidad & "DEMETER", Cdatos.TiposCampo.Cadena, 1)

            GES_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            GES_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            GES_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim SQL As String
        SQL = " Select distinct GES_IDCONFEC AS IdConfec,CEV_Nombre as Confeccion,GES_IdGenero as IdGenero,GES_Idgensal as IdPresenta,GES_Nombre as Presentacion,envases.ENV_nombre as Envase,GCA_codigo as IdCategoria,CAC_Nombre as Categoria from GenerosSalida  "
        SQL = SQL + " LEFT JOIN confecenvase on CEV_IDCONFEC=GES_IDCONFEC "
        SQL = SQL + " LEFT JOIN envases on ENV_idenvase=CEV_idenvase"
        SQL = SQL + " LEFT JOIN GenerosCategorias on GCA_idpresentacion=GES_idgensal and GCA_tipo='C'"
        SQL = SQL + " LEFT JOIN CategoriasComercial on CAC_idcategoria=GCA_codigo"
        SQL = SQL + " WHERE GES_ACTIVO<>'N' "


        BtBuscaXconfec = New BtBusca()
        BtBuscaXconfec.Image = Global.NetAgro.My.Resources.Lupa16_
        BtBuscaXconfec.Location = New System.Drawing.Point(134, 303)
        BtBuscaXconfec.Size = New System.Drawing.Size(33, 23)
        BtBuscaXconfec.UseVisualStyleBackColor = True

        BtBuscaXconfec.CL_CampoOrden = "Presentacion"

        BtBuscaXconfec.CL_ConsultaSql = SQL
        BtBuscaXconfec.CL_ControlAsociado = Nothing

        BtBuscaXconfec.CL_DevuelveCampo = "idpresenta"
        BtBuscaXconfec.CL_Entidad = Me
        BtBuscaXconfec.CL_Filtro = Nothing
        BtBuscaXconfec.Name = "BtBuscagensal"
        BtBuscaXconfec.CL_ch1000 = False
        BtBuscaXconfec.CL_Ancho = 1500
        BtBuscaXconfec.Params("Confeccion", , 100)
        BtBuscaXconfec.Params("Presentacion", , 150)
        BtBuscaXconfec.Params("Envase", , 100)
        BtBuscaXconfec.Params("Categoria", , 100)




        Dim sql2 As String = " Select distinct GES_IDCONFEC AS IdConfec, CEV_Nombre as Confeccion, GES_IdGenero as IdGenero, " & vbCrLf
        sql2 = sql2 & " GES_Idgensal as IdPresenta,GES_Nombre as Presentacion,envases.ENV_nombre as Envase," & vbCrLf
        sql2 = sql2 & " CAS_Id as IdCatSalida from GenerosSalida  " & vbCrLf
        sql2 = sql2 + " LEFT JOIN confecenvase on CEV_IDCONFEC=GES_IDCONFEC "
        sql2 = sql2 + " LEFT JOIN envases on ENV_idenvase=CEV_idenvase"
        sql2 = sql2 + " LEFT JOIN GenerosCategorias on GCA_idpresentacion=GES_idgensal and GCA_tipo='C'"
        sql2 = sql2 + " LEFT JOIN CategoriasComercial on CAC_idcategoria=GCA_codigo"
        sql2 = sql2 + " LEFT JOIN CatSalidaComercial on CAC_IdCategoria = CSC_IdCatComercial"
        sql2 = sql2 + " LEFT JOIN CategoriasSalida on CAS_Id = CSC_IdCatSalida"
        sql2 = sql2 + " WHERE GES_ACTIVO<>'N' "

        BtBuscaXConfecSalida = New BtBusca()
        BtBuscaXConfecSalida.Image = Global.NetAgro.My.Resources.Lupa16_
        BtBuscaXConfecSalida.Location = New System.Drawing.Point(134, 303)
        BtBuscaXConfecSalida.Size = New System.Drawing.Size(33, 23)
        BtBuscaXConfecSalida.UseVisualStyleBackColor = True

        BtBuscaXConfecSalida.CL_CampoOrden = "Presentacion"

        BtBuscaXConfecSalida.CL_ConsultaSql = sql2
        BtBuscaXConfecSalida.CL_ControlAsociado = Nothing

        BtBuscaXConfecSalida.CL_DevuelveCampo = "idpresenta"
        BtBuscaXConfecSalida.CL_Entidad = Me
        BtBuscaXConfecSalida.CL_Filtro = Nothing
        BtBuscaXConfecSalida.Name = "BtBuscagensal"
        BtBuscaXConfecSalida.CL_ch1000 = False
        BtBuscaXConfecSalida.CL_Ancho = 1500
        BtBuscaXConfecSalida.Params("Confeccion", , 100)
        BtBuscaXConfecSalida.Params("Presentacion", , 150)
        BtBuscaXConfecSalida.Params("Envase", , 100)
        BtBuscaXConfecSalida.Params("Categoria", , 100)





        Dim sqlPedidos As String = "SELECT DISTINCT GES_IdConfec as IdConfec, CEV_Nombre as Confeccion, GES_IdGenero as IdGenero, PCC_IdGenSal as IdPresenta, GES_Nombre as Presentacion," & vbCrLf
        sqlPedidos = sqlPedidos & " ENV_Nombre as Envase, GCA_Codigo as IdCategoria, CAC_Nombre as Categoria" & vbCrLf
        sqlPedidos = sqlPedidos & " FROM Pedidos_Clientes" & vbCrLf
        sqlPedidos = sqlPedidos & " INNER JOIN GenerosSalida ON PCC_IdGenSal = GES_IdGenSal" & vbCrLf
        sqlPedidos = sqlPedidos & " LEFT JOIN ConfecEnvase on CEV_IdConfec = GES_IdConfec" & vbCrLf
        sqlPedidos = sqlPedidos & " LEFT JOIN Envases on ENV_IdEnvase = CEV_IdEnvase" & vbCrLf
        sqlPedidos = sqlPedidos & " LEFT JOIN GenerosCategorias on GCA_idpresentacion = GES_IdGenSal AND GCA_Tipo='C'" & vbCrLf
        sqlPedidos = sqlPedidos & " LEFT JOIN CategoriasComercial on CAC_IdCategoria = GCA_Codigo" & vbCrLf
        sqlPedidos = sqlPedidos & " WHERE PCC_Activo = 'S'" & vbCrLf
        sqlPedidos = sqlPedidos & " AND GES_Activo <> 'N'" & vbCrLf
        sqlPedidos = sqlPedidos & " AND PCC_IdGenSal > 0 " & vbCrLf


        BtBuscaXconfecCliente = New BtBusca()
        BtBuscaXconfecCliente.Image = Global.NetAgro.My.Resources.Lupa16_
        BtBuscaXconfecCliente.Location = New System.Drawing.Point(134, 303)
        BtBuscaXconfecCliente.Size = New System.Drawing.Size(33, 23)
        BtBuscaXconfecCliente.UseVisualStyleBackColor = True

        BtBuscaXconfecCliente.CL_CampoOrden = "Presentacion"

        BtBuscaXconfecCliente.CL_ConsultaSql = sqlPedidos
        BtBuscaXconfecCliente.CL_ControlAsociado = Nothing

        BtBuscaXconfecCliente.CL_DevuelveCampo = "idpresenta"
        BtBuscaXconfecCliente.CL_Entidad = Me
        BtBuscaXconfecCliente.CL_Filtro = Nothing
        BtBuscaXconfecCliente.Name = "BtBuscagensal"
        BtBuscaXconfecCliente.CL_ch1000 = False
        BtBuscaXconfecCliente.CL_Ancho = 1500
        BtBuscaXconfecCliente.Params("Confeccion", , 100)
        BtBuscaXconfecCliente.Params("Presentacion", , 150)
        BtBuscaXconfecCliente.Params("Envase", , 100)
        BtBuscaXconfecCliente.Params("Categoria", , 100)




    End Sub

    Public Function LeerGensalida(ByVal IdGenero As String, ByVal idConfec As String) As DataTable

        Dim ret As New DataTable
        Dim consulta As New Cdatos.E_select

        consulta.SelTodos(Me)
        consulta.WheCampo(Me.GES_IdGenero, "=", IdGenero)
        consulta.WheCampo(Me.GES_Idconfec, "=", idConfec)
        consulta.WheCampo(Me.GES_Activo, "=", "S")
        ret = Me.MiConexion.ConsultaSQL(consulta.SQL)
        Return ret

    End Function

    Public Function LeerIdGenerosalida(idgenero As String, idconfec As String) As Integer
        Dim ret As Integer = 0
        Dim sql As String = ""
        sql = "Select GES_idgensal from GENEROSSALIDA WHERE GES_IDGENERO=" + idgenero + " AND GES_IDCONFEC=" + idconfec
        Dim DT As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not DT Is Nothing Then
            If DT.Rows.Count > 0 Then
                ret = DT.Rows(0)(0)
            End If
        End If
        Return ret

    End Function
End Class
