Public Class E_Medianeria
    Inherits Cdatos.Entidad


    Public MED_Idmedianeria As Cdatos.bdcampo
    Public MED_IdAgricultor As Cdatos.bdcampo
    Public MED_Numero As Cdatos.bdcampo
    Public MED_Nombre As Cdatos.bdcampo

    Public MED_IdUsuarioLog As Cdatos.bdcampo
    Public MED_FechaLog As Cdatos.bdcampo
    Public MED_HoraLog As Cdatos.bdcampo


    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "Medianeria"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            MED_Idmedianeria = New Cdatos.bdcampo(CodigoEntidad & "idmedianeria", Cdatos.TiposCampo.EnteroPositivo, 5, 0, True)
            MED_IdAgricultor = New Cdatos.bdcampo(CodigoEntidad & "idagricultor", Cdatos.TiposCampo.EnteroPositivo, 5)
            MED_Numero = New Cdatos.bdcampo(CodigoEntidad & "numero", Cdatos.TiposCampo.EnteroPositivo, 2)
            MED_Nombre = New Cdatos.bdcampo(CodigoEntidad & "nombre", Cdatos.TiposCampo.Cadena, 50)

            MED_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            MED_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            MED_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.MED_Idmedianeria, "IdMedianeria")
        consulta.SelCampo(Me.MED_Numero, "Numero")
        consulta.SelCampo(Me.MED_Nombre, "Nombre")
        consulta.SelCampo(Me.MED_IdAgricultor, "IdAgricultor")

        ' en la consulta tiene que haber un campo que se llame codigo,y otro fecha

        _btBusca.Params("IdMedianeria", , -1)
        _btBusca.Params("IdAgricultor", , -1)

        _btBusca.CL_BuscaAlb = False ' busqueda por codigo
        '_btBusca.CL_CampoOrden = "Agricultor"
        _btBusca.CL_CampoOrden = "Numero"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdMedianeria"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaMedianeria"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "Frmmedianeria"



    End Sub


    Public Function LeerMedianeria(IdAgricultor As String, Numero As String) As Integer
        Dim ret As Integer
        Dim Sql As String
        Sql = "Select MED_idmedianeria from medianeria where med_idagricultor=" + IdAgricultor + " and med_numero=" + Numero
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(Sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = VaInt(dt.Rows(0)(0))
            End If
        End If

        Return ret

    End Function

    Public Function Medianerias(idagricultor As String) As DataTable
        Dim sql As String = "Select MED_idmedianeria as medianeria, MED_Numero as Numero, MED_Nombre as Nombre from medianeria where med_idagricultor=" + idagricultor
        Dim dt As New DataTable
        dt = Me.MiConexion.ConsultaSQL(sql)
        Return dt

    End Function

    Private Sub E_Medianeria_EliminaHijos() Handles Me.EliminaHijos
        Dim sql As String
        sql = "Delete from medianeria_lineas where mel_idmedianeria=" + Me.MED_Idmedianeria.Valor
        Me.MiConexion.OrdenSql(sql)
    End Sub

End Class
