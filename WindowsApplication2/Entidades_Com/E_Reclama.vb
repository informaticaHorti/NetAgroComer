Public Class E_Reclama
    Inherits Cdatos.Entidad

    Public RCL_Idreclama As Cdatos.bdcampo
    Public RCL_Campa As Cdatos.bdcampo
    Public RCL_Idcentro As Cdatos.bdcampo
    Public RCL_Numero As Cdatos.bdcampo
    Public RCL_Fecha As Cdatos.bdcampo
    Public RCL_Idlinalb As Cdatos.bdcampo
    Public RCL_fechaestimada As Cdatos.bdcampo
    Public RCL_kilosestimados As Cdatos.bdcampo
    Public RCL_bultosestimados As Cdatos.bdcampo
    Public RCL_importeestimado As Cdatos.bdcampo
    Public RCL_fechareal As Cdatos.bdcampo
    Public RCL_kilos As Cdatos.bdcampo
    Public RCL_bultos As Cdatos.bdcampo
    Public RCL_importe As Cdatos.bdcampo
    Public RCL_idorigen As Cdatos.bdcampo
    Public RCL_observaciones1 As Cdatos.bdcampo
    Public RCL_observaciones2 As Cdatos.bdcampo
    Public RCL_observaciones3 As Cdatos.bdcampo
    Public RCL_observaciones4 As Cdatos.bdcampo
    Public RCL_fecharesolucion As Cdatos.bdcampo
    Public RCL_idresolucion As Cdatos.bdcampo
    Public RCL_IdMotivoQueja As Cdatos.bdcampo

    Public RCL_Conclusiones1 As Cdatos.bdcampo
    Public RCL_Conclusiones2 As Cdatos.bdcampo
    Public RCL_Conclusiones3 As Cdatos.bdcampo
    Public RCL_Conclusiones4 As Cdatos.bdcampo

    Public RCL_Acciones1 As Cdatos.bdcampo
    Public RCL_Acciones2 As Cdatos.bdcampo
    Public RCL_Acciones3 As Cdatos.bdcampo
    Public RCL_Acciones4 As Cdatos.bdcampo


    Public RCL_IdUsuarioLog As Cdatos.bdcampo
    Public RCL_FechaLog As Cdatos.bdcampo
    Public RCL_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "reclama"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            RCL_Idreclama = New Cdatos.bdcampo(CodigoEntidad & "idreclama", Cdatos.TiposCampo.Entero, 8, 0, True)
            RCL_Campa = New Cdatos.bdcampo(CodigoEntidad & "campa", Cdatos.TiposCampo.Entero, 2)
            RCL_Idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.Entero, 3)
            RCL_Numero = New Cdatos.bdcampo(CodigoEntidad & "numero", Cdatos.TiposCampo.Entero, 8)
            RCL_Fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 10)
            RCL_Idlinalb = New Cdatos.bdcampo(CodigoEntidad & "idlinalb", Cdatos.TiposCampo.Entero, 10)
            RCL_fechaestimada = New Cdatos.bdcampo(CodigoEntidad & "fechaestimada", Cdatos.TiposCampo.Fecha, 10)
            RCL_kilosestimados = New Cdatos.bdcampo(CodigoEntidad & "kilosestimados", Cdatos.TiposCampo.Entero, 10)
            RCL_bultosestimados = New Cdatos.bdcampo(CodigoEntidad & "bultosestimados", Cdatos.TiposCampo.Entero, 10)
            RCL_importeestimado = New Cdatos.bdcampo(CodigoEntidad & "importeestimado", Cdatos.TiposCampo.Importe, 12, 2)
            RCL_fechareal = New Cdatos.bdcampo(CodigoEntidad & "fechareal", Cdatos.TiposCampo.Fecha, 10)
            RCL_kilos = New Cdatos.bdcampo(CodigoEntidad & "kilos", Cdatos.TiposCampo.Entero, 10)
            RCL_bultos = New Cdatos.bdcampo(CodigoEntidad & "bultos", Cdatos.TiposCampo.Entero, 10)
            RCL_importe = New Cdatos.bdcampo(CodigoEntidad & "importe", Cdatos.TiposCampo.Importe, 12, 2)
            RCL_idorigen = New Cdatos.bdcampo(CodigoEntidad & "idorigen", Cdatos.TiposCampo.Entero, 10)
            RCL_observaciones1 = New Cdatos.bdcampo(CodigoEntidad & "observaciones1", Cdatos.TiposCampo.Cadena, 50)
            RCL_observaciones2 = New Cdatos.bdcampo(CodigoEntidad & "observaciones2", Cdatos.TiposCampo.Cadena, 50)
            RCL_observaciones3 = New Cdatos.bdcampo(CodigoEntidad & "observaciones3", Cdatos.TiposCampo.Cadena, 50)
            RCL_observaciones4 = New Cdatos.bdcampo(CodigoEntidad & "observaciones4", Cdatos.TiposCampo.Cadena, 50)
            RCL_fecharesolucion = New Cdatos.bdcampo(CodigoEntidad & "fecharesolucion", Cdatos.TiposCampo.Fecha, 10)
            RCL_idresolucion = New Cdatos.bdcampo(CodigoEntidad & "idresolucion", Cdatos.TiposCampo.Entero, 10)
            RCL_IdMotivoQueja = New Cdatos.bdcampo(CodigoEntidad & "IdMotivoQueja", Cdatos.TiposCampo.Entero, 10)

            RCL_Conclusiones1 = New Cdatos.bdcampo(CodigoEntidad & "Conclusiones1", Cdatos.TiposCampo.Cadena, 100)
            RCL_Conclusiones2 = New Cdatos.bdcampo(CodigoEntidad & "Conclusiones2", Cdatos.TiposCampo.Cadena, 100)
            RCL_Conclusiones3 = New Cdatos.bdcampo(CodigoEntidad & "Conclusiones3", Cdatos.TiposCampo.Cadena, 100)
            RCL_Conclusiones4 = New Cdatos.bdcampo(CodigoEntidad & "Conclusiones4", Cdatos.TiposCampo.Cadena, 100)

            RCL_Acciones1 = New Cdatos.bdcampo(CodigoEntidad & "Acciones1", Cdatos.TiposCampo.Cadena, 100)
            RCL_Acciones2 = New Cdatos.bdcampo(CodigoEntidad & "Acciones2", Cdatos.TiposCampo.Cadena, 100)
            RCL_Acciones3 = New Cdatos.bdcampo(CodigoEntidad & "Acciones3", Cdatos.TiposCampo.Cadena, 100)
            RCL_Acciones4 = New Cdatos.bdcampo(CodigoEntidad & "Acciones4", Cdatos.TiposCampo.Cadena, 100)


            RCL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            RCL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            RCL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.RCL_Numero)


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim AlbSalida As New E_AlbSalida(idUsuario, cn)
        Dim Albsalida_lineas As New E_AlbSalida_lineas(idUsuario, cn)
        Dim Clientes As New E_Clientes(idUsuario, cn)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.RCL_Idreclama, "Idreclama")
        consulta.SelCampo(Me.RCL_Campa, "Campa")
        consulta.SelCampo(Me.RCL_Idcentro, "IdCentro")
        consulta.SelCampo(Centros.Nombre, "Centro", Me.RCL_Idcentro)
        consulta.SelCampo(Me.RCL_Numero, "Numero")
        consulta.SelCampo(Me.RCL_Fecha, "Fecha")
        consulta.SelCampo(Albsalida_lineas.ASL_idalbaran, "idalbaran", Me.RCL_Idlinalb)
        consulta.SelCampo(AlbSalida.ASA_albaran, "Albaran", Albsalida_lineas.ASL_idalbaran)
        consulta.SelCampo(AlbSalida.ASA_idcliente, "Codigo")
        Dim oBloqueo As New Cdatos.bdcampo("@CASE COALESCE(CLI_Bloqueo, 'N') WHEN 'S' THEN 'S' ELSE 'N' END", Cdatos.TiposCampo.Cadena, 1)
        consulta.SelCampo(oBloqueo, "Bloqueo")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", AlbSalida.ASA_idcliente)
        _btBusca.Params("IdCentro", , -1)
        _btBusca.Params("Idreclama", , -1)
        _btBusca.Params("Idalbaran", , -1)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_CampoOrden = "Fecha"
        '_btBusca.CL_ConsultaSql = "Select VEV_Idvale as IdVale, VEV_operacion as Operacion, VEV_codigo as Codigo, VEV_campa as Campa, VEV_idcentro as IdCentro, VEV_numero as Numero, VEV_fecha as Fecha from Valeenvases"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "idreclama"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscareclama"
        _btBusca.CL_ch1000 = False


        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Clientes.CLI_Codigo
        _btBusca.CL_camponombre = Clientes.CLI_Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio
        _btBusca.CL_xCentro = True

        Dim Dc As New Dictionary(Of Object, Color)
        Dc("S") = Color.Red
        Dc("N") = Color.LimeGreen
        _btBusca.Params("Bloqueo", "B", 15, , , Dc)


    End Sub

    Public Function LeerReclama(ByVal Campa As Integer, ByVal Centro As Integer, ByVal Reclama As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.RCL_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.RCL_Idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.RCL_Numero, "=", Reclama.ToString)

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


    Public Function ExisteReclama(ByVal Campa As Integer, ByVal Centro As Integer, ByVal reclama As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.RCL_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.RCL_Idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.RCL_Numero, "=", reclama.ToString)

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
                existe = ExisteReclama(Campa, Centro, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de albaranes", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function





End Class
