Public Class E_Partes
    Inherits Cdatos.Entidad


    Public PDS_idparte As Cdatos.bdcampo
    Public PDS_numero As Cdatos.bdcampo
    Public PDS_campa As Cdatos.bdcampo
    Public PDS_idsemana As Cdatos.bdcampo
    Public PDS_defecha As Cdatos.bdcampo
    Public PDS_afecha As Cdatos.bdcampo
    Public PDS_defechasal As Cdatos.bdcampo
    Public PDS_afechasal As Cdatos.bdcampo
    Public PDS_IdValoracion As Cdatos.bdcampo
    Public PDS_valorada As Cdatos.bdcampo
    Public PDS_idcentro As Cdatos.bdcampo

    Public PDS_IdUsuarioLog As Cdatos.bdcampo
    Public PDS_FechaLog As Cdatos.bdcampo
    Public PDS_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "Partes"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            PDS_idparte = New Cdatos.bdcampo(CodigoEntidad & "idparte", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            PDS_numero = New Cdatos.bdcampo(CodigoEntidad & "numero", Cdatos.TiposCampo.Entero, 8)
            PDS_idsemana = New Cdatos.bdcampo(CodigoEntidad & "idsemana", Cdatos.TiposCampo.Entero, 6)
            PDS_campa = New Cdatos.bdcampo(CodigoEntidad & "campa", Cdatos.TiposCampo.Entero, 2)
            PDS_defecha = New Cdatos.bdcampo(CodigoEntidad & "defecha", Cdatos.TiposCampo.Fecha, 10)
            PDS_afecha = New Cdatos.bdcampo(CodigoEntidad & "afecha", Cdatos.TiposCampo.Fecha, 10)
            PDS_defechasal = New Cdatos.bdcampo(CodigoEntidad & "defechasal", Cdatos.TiposCampo.Fecha, 10)
            PDS_afechasal = New Cdatos.bdcampo(CodigoEntidad & "afechasal", Cdatos.TiposCampo.Fecha, 10)
            PDS_IdValoracion = New Cdatos.bdcampo(CodigoEntidad & "IdValoracion", Cdatos.TiposCampo.EnteroPositivo, 10)
            PDS_valorada = New Cdatos.bdcampo(CodigoEntidad & "valorada", Cdatos.TiposCampo.Cadena, 1)
            PDS_idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.EnteroPositivo, 4)

            PDS_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PDS_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PDS_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.PDS_numero)


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.PDS_idparte, "IdParte")
        consulta.SelCampo(Me.PDS_numero, "Numero")
        consulta.SelCampo(Me.PDS_campa, "Ejercicio")
        consulta.SelCampo(Me.PDS_defecha, "DeFecha")
        consulta.SelCampo(Me.PDS_afecha, "AFecha")
        consulta.WheCampo(Me.PDS_campa, ">", "0")

        _btBusca.Params("IdParte", , -1)

        _btBusca.CL_BuscaAlb = False ' busqueda por codigo



        _btBusca.CL_CampoOrden = "DeFecha"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Numero"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaParte"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing


    End Sub

    Public Function LeerParte(ByVal Campa As Integer, ByVal numparte As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.PDS_campa, "=", Campa.ToString)
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


    Public Function ExisteParte(ByVal Campa As Integer, ByVal numparte As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.PDS_campa, "=", Campa.ToString)
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


    Public Function MaxIdCampa(ByVal Campa As Integer, Optional ByVal vmax As Integer = 0) As Integer
        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                max = ValorMaximo(Campa.ToString, vmax)

                existe = ExisteParte(Campa, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de partes", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function

End Class
