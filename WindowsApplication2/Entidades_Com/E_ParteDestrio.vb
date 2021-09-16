Public Class E_ParteDestrio

    Inherits Cdatos.Entidad

    Public PDS_idparte As Cdatos.bdcampo
    Public PDS_numero As Cdatos.bdcampo
    Public PDS_campa As Cdatos.bdcampo
    Public PDS_idcentro As Cdatos.bdcampo
    Public PDS_fecha As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "Partedestrio"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            PDS_idparte = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            PDS_numero = New Cdatos.bdcampo(CodigoEntidad & "numero", Cdatos.TiposCampo.Entero, 6)
            PDS_campa = New Cdatos.bdcampo(CodigoEntidad & "campa", Cdatos.TiposCampo.Entero, 2)
            PDS_idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.Entero, 2)
            PDS_fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 10)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        Dim Centros As New E_centros(idUsuario, CnCtb)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.PDS_idparte, "IdParte")
        consulta.SelCampo(Me.PDS_numero, "Numero")
        consulta.SelCampo(Me.PDS_campa, "Ejercicio")
        consulta.SelCampo(Me.PDS_idcentro, "Codigo")
        consulta.SelCampo(Centros.Nombre, "CE", Me.PDS_idcentro)
        consulta.SelCampo(Me.PDS_fecha, "Fecha")

        _btBusca.Params("Idparte", , -1)
        _btBusca.Params("Codigo", , -1)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Centros.IdCentro
        _btBusca.CL_camponombre = Centros.Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio



        _btBusca.CL_CampoOrden = "Fecha"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idparte"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaParte"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing


    End Sub

    Public Function LeerParte(ByVal Campa As Integer, ByVal Centro As Integer, ByVal numparte As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.PDS_campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.PDS_idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.PDS_idcentro, "=", Centro.ToString)
        CONSULTA.WheCampo(Me.PDS_numero, "=", numparte.ToString)

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

        CONSULTA.WheCampo(Me.PDS_campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.PDS_idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.PDS_numero, "=", numparte.ToString)

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
