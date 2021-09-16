Public Class E_RemesasFactoring
    Inherits Cdatos.Entidad

    Public REF_IdRemesa As Cdatos.bdcampo
    Public REF_Campa As Cdatos.bdcampo
    Public REF_IdCentro As Cdatos.bdcampo
    Public REF_Remesa As Cdatos.bdcampo
    Public REF_Fecha As Cdatos.bdcampo

    Public REF_IdUsuarioLog As Cdatos.bdcampo
    Public REF_FechaLog As Cdatos.bdcampo
    Public REF_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "RemesasFactoring"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            REF_IdRemesa = New Cdatos.bdcampo(CodigoEntidad & "IdRemesa", Cdatos.TiposCampo.Entero, 10, 0, True)
            REF_Campa = New Cdatos.bdcampo(CodigoEntidad & "Campa", Cdatos.TiposCampo.Entero, 2)
            REF_IdCentro = New Cdatos.bdcampo(CodigoEntidad & "IdCentro", Cdatos.TiposCampo.Entero, 3)
            REF_Remesa = New Cdatos.bdcampo(CodigoEntidad & "Remesa", Cdatos.TiposCampo.Entero, 8)
            REF_Fecha = New Cdatos.bdcampo(CodigoEntidad & "Fecha", Cdatos.TiposCampo.Fecha, 10)

            REF_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            REF_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            REF_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.REF_Remesa)


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        'Dim Clientes As New E_Clientes(idUsuario, cn)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.REF_IdRemesa, "IdRemesa")
        consulta.SelCampo(Me.REF_Remesa, "Remesa")
        consulta.SelCampo(Me.REF_Campa, "Campa")
        consulta.SelCampo(Me.REF_IdCentro, "CE")
        consulta.SelCampo(Me.REF_Fecha, "Fecha")
        Dim oTotal As New Cdatos.bdcampo("@(SELECT SUM(RFL_Importe) FROM RemesasFactoring_Lineas WHERE RFL_IdRemesa = REF_IdRemesa)", Cdatos.TiposCampo.Importe, 18, 2)
        consulta.SelCampo(oTotal, "TotalRemesa")
        consulta.WheCampo(Me.REF_IdCentro, "=", MiMaletin.IdCentro.ToString)
        consulta.WheCampo(Me.REF_Campa, "=", MiMaletin.Ejercicio.ToString)

        _btBusca.Params("IdRemesa", , -1)
        _btBusca.Params("TotalRemesa", , , , "#,##0.00")

        '_btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_CampoOrden = "Fecha"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Remesa"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaRemesa"
        _btBusca.CL_ch1000 = False

       


    End Sub



    Public Function LeerRemesa(ByVal Campa As Integer, ByVal IdCentro As Integer, ByVal Remesa As Integer) As Integer

        Dim ret As Integer = 0

        Dim RemesasFactoring As New E_RemesasFactoring(Idusuario, cn)


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelTodos(RemesasFactoring)
        CONSULTA.WheCampo(RemesasFactoring.REF_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(RemesasFactoring.REF_IdCentro, "=", IdCentro.ToString)
        End If
        CONSULTA.WheCampo(RemesasFactoring.REF_Remesa, "=", Remesa.ToString)


        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(CONSULTA.SQL)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                If dt.Rows(0)(0) IsNot DBNull.Value Then
                    ret = dt.Rows(0)(0)
                    RemesasFactoring.CargaCampos(dt.Rows(0))
                End If
            End If
        End If


        Return ret

    End Function


    Public Function ExisteRemesa(ByVal Campa As Integer, ByVal IdCentro As Integer, ByVal Remesa As Integer) As Integer

        Dim ret As Integer = 0
        Dim RemesasFactoring As New E_RemesasFactoring(Idusuario, cn)


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelTodos(RemesasFactoring)
        CONSULTA.WheCampo(RemesasFactoring.REF_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(RemesasFactoring.REF_IdCentro, "=", IdCentro.ToString)
        End If
        CONSULTA.WheCampo(RemesasFactoring.REF_Remesa, "=", Remesa.ToString)

        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(CONSULTA.SQL)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                If dt.Rows(0)(0) IsNot DBNull.Value Then
                    ret = dt.Rows(0)(0)
                End If
            End If
        End If
        Return ret
    End Function


    Public Function MaxIdCampa(ByVal Campa As Integer, ByVal IdCentro As Integer, Optional ByVal vmax As Integer = 0) As Integer
        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                If ContadorxCentro = True Then
                    max = ValorMaximo(Campa.ToString + "_" + IdCentro.ToString, vmax)
                Else
                    max = ValorMaximo(Campa.ToString, vmax)
                End If

                existe = ExisteRemesa(Campa, IdCentro, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de albaranes", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function



    Private Sub E_Almmaterial_EliminaHijos() Handles Me.EliminaHijos

        Dim sql As String
        sql = "Delete from RemesasFactoring_Lineas where RFL_IdRemesa = " + Me.REF_IdRemesa.Valor
        MiConexion.OrdenSql(sql)

    End Sub



End Class
