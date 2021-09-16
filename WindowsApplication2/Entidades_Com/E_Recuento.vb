Public Class E_Recuento
    Inherits Cdatos.Entidad


    Public REC_IdRecuento As Cdatos.bdcampo
    Public REC_Numero As Cdatos.bdcampo
    Public REC_Campa As Cdatos.bdcampo
    Public REC_IdCentro As Cdatos.bdcampo
    Public REC_Fecha As Cdatos.bdcampo

    Public REC_IdUsuarioLog As Cdatos.bdcampo
    Public REC_FechaLog As Cdatos.bdcampo
    Public REC_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "Recuento"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            REC_IdRecuento = New Cdatos.bdcampo(CodigoEntidad & "IdRecuento", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            REC_Numero = New Cdatos.bdcampo(CodigoEntidad & "Numero", Cdatos.TiposCampo.Entero, 6)
            REC_Campa = New Cdatos.bdcampo(CodigoEntidad & "Campa", Cdatos.TiposCampo.Entero, 2)
            REC_IdCentro = New Cdatos.bdcampo(CodigoEntidad & "IdCentro", Cdatos.TiposCampo.Entero, 2) ' es el almacen
            REC_Fecha = New Cdatos.bdcampo(CodigoEntidad & "Fecha", Cdatos.TiposCampo.Fecha, 10)

            REC_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            REC_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            REC_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.REC_Numero)


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.REC_IdRecuento, "IdRecuento")
        consulta.SelCampo(Me.REC_numero, "Numero")
        consulta.SelCampo(Me.REC_campa, "Ejercicio")
        consulta.SelCampo(Me.REC_idcentro, "Codigo")
        consulta.SelCampo(Centros.Nombre, "CE", Me.REC_idcentro)
        consulta.SelCampo(Me.REC_fecha, "Fecha")

        _btBusca.Params("IdRecuento", , -1)
        _btBusca.Params("Codigo", , -1)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Centros.IdCentro
        _btBusca.CL_camponombre = Centros.Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio



        _btBusca.CL_CampoOrden = "Fecha"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdRecuento"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaRecuento"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing


    End Sub

    Public Function LeerParte(ByVal Campa As Integer, ByVal Centro As Integer, ByVal numparte As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.REC_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.REC_IdCentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.REC_Numero, "=", numparte.ToString)

        Dt = Me.MiConexion.ConsultaSQL(CONSULTA.SQL)
        If Not Dt Is Nothing Then
            If Dt.Rows.Count > 0 Then
                If Dt.Rows(0)(0) IsNot DBNull.Value Then
                    ret = Dt.Rows(0)(0)
                    CargaCampos(Dt.Rows(0))
                End If
            End If
        End If
        Return ret
    End Function


    Public Function ExisteParte(ByVal Campa As Integer, ByVal Centro As Integer, ByVal numparte As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.REC_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.REC_IdCentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.REC_Numero, "=", numparte.ToString)

        Dt = Me.MiConexion.ConsultaSQL(CONSULTA.SQL)
        If Not Dt Is Nothing Then
            If Dt.Rows.Count > 0 Then
                If Dt.Rows(0)(0) IsNot DBNull.Value Then
                    ret = Dt.Rows(0)(0)
                End If
            End If
        End If
        Return ret
    End Function


    Public Function MaxIdCampa(ByVal Campa As Integer, ByVal Centro As Integer, Optional ByVal vmax As Integer = 0) As Integer
        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                If ContadorxCentro = True Then
                    max = ValorMaximo(Campa.ToString + "_" + Centro.ToString, vmax)
                Else
                    max = ValorMaximo(Campa.ToString, vmax)
                End If
                existe = ExisteParte(Campa, Centro, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de partes", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function

End Class
