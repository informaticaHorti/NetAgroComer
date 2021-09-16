Public Class E_ConfecPalet
    Inherits Cdatos.Entidad

    Public CPA_Idconfec As Cdatos.bdcampo
    Public CPA_Nombre As Cdatos.bdcampo
    Public CPA_Abreviatura As Cdatos.bdcampo
    Public CPA_TotalTara As Cdatos.bdcampo
    Public CPA_TotalCoste As Cdatos.bdcampo
    Public CPA_IdPalet As Cdatos.bdcampo
    Public CPA_IncrementoTara As Cdatos.bdcampo
    Public CPA_Coeficiente As Cdatos.bdcampo

    Public CPA_IdUsuarioLog As Cdatos.bdcampo
    Public CPA_FechaLog As Cdatos.bdcampo
    Public CPA_HoraLog As Cdatos.bdcampo



    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "confecpalet"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            CPA_Idconfec = New Cdatos.bdcampo(CodigoEntidad & "idconfec", Cdatos.TiposCampo.EnteroPositivo, 5, 0, True)
            CPA_Nombre = New Cdatos.bdcampo(CodigoEntidad & "nombre", Cdatos.TiposCampo.Cadena, 50)
            CPA_Abreviatura = New Cdatos.bdcampo(CodigoEntidad & "abreviatura", Cdatos.TiposCampo.Cadena, 25)
            CPA_TotalTara = New Cdatos.bdcampo(CodigoEntidad & "totaltara", Cdatos.TiposCampo.Importe, 20, 4)
            CPA_TotalCoste = New Cdatos.bdcampo(CodigoEntidad & "totalcoste", Cdatos.TiposCampo.Importe, 8, 4)
            CPA_IdPalet = New Cdatos.bdcampo(CodigoEntidad & "idpalet", Cdatos.TiposCampo.EnteroPositivo, 5)
            CPA_IncrementoTara = New Cdatos.bdcampo(CodigoEntidad & "incrementotara", Cdatos.TiposCampo.Importe, 8, 4)

            CPA_Coeficiente = New Cdatos.bdcampo(CodigoEntidad & "Coeficiente", Cdatos.TiposCampo.Importe, 5, 2)

            CPA_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CPA_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CPA_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)

            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select CPA_Idconfec as IdConfec, CPA_Nombre as Nombre from confecpalet"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdConfec"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaConfecPalet"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmConfecPalet"

    End Sub



    Private Sub E_ConfecPalet_EliminaHijos() Handles Me.EliminaHijos
        Dim sql As String
        sql = "Delete from confecpaletlineas where CPL_idconfec=" + CPA_Idconfec.Valor
        Me.MiConexion.OrdenSql(sql)


    End Sub
End Class
