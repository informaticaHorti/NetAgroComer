Public Class E_Variedades

    Inherits Cdatos.Entidad

    Public VAR_IdVariedad As Cdatos.bdcampo
    Public VAR_IdGenero As Cdatos.bdcampo
    Public VAR_Nombre As Cdatos.bdcampo
    Public VAR_IdCasaComercial As Cdatos.bdcampo

    Public VAR_IdUsuarioLog As Cdatos.bdcampo
    Public VAR_FechaLog As Cdatos.bdcampo
    Public VAR_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "Variedades"
            NombreBd = "TecnicosNet"
            MiConexion = conexion

            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            VAR_IdVariedad = New Cdatos.bdcampo(CodigoEntidad & "IdVariedad", Cdatos.TiposCampo.Entero, 4, , True)
            VAR_IdGenero = New Cdatos.bdcampo(CodigoEntidad & "IdGenero", Cdatos.TiposCampo.Entero, 6)
            VAR_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 50)
            VAR_IdCasaComercial = New Cdatos.bdcampo(CodigoEntidad & "IdCasaComercial", Cdatos.TiposCampo.Entero, 4)

            VAR_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            VAR_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            VAR_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.Muestraerror("Error en la creacion de la entidad ", "New", ex.Message)
        End Try

        'Dim Genero As New E_Generos(idUsuario, cn)
        'Dim CasaComercial As New E_CasasComerciales(idUsuario, cn)

        'Dim Consulta As New Cdatos.E_select

        'Consulta.SelCampo(Me.VAR_Nombre, "NombreVariedad")
        'Consulta.SelCampo(Genero.GEN_Nombre, "Genero", Me.VAR_IdGenero, Genero.GEN_IdGenero)
        'Consulta.SelCampo(CasaComercial.CCM_Nombre, "CasaComercial", Me.VAR_IdCasaComercial, CasaComercial.CCM_Id)
        'Consulta.SelCampo(Me.VAR_IdVariedad, "IdVariedad")
        'Consulta.SelCampo(Me.VAR_IdGenero, "IdGenero")


        'Dim sql As String = Consulta.SQL & " ORDER BY Genero"

        '_btBusca.CL_CampoOrden = "Genero"
        '_btBusca.CL_ConsultaSql = sql
        '_btBusca.CL_ControlAsociado = Nothing
        '_btBusca.CL_DevuelveCampo = "IdVariedad"
        '_btBusca.CL_Entidad = Me
        '_btBusca.CL_Filtro = Nothing
        '_btBusca.Name = "BtBuscaVariedades"
        '_btBusca.CL_ch1000 = False

        '_btBusca.Params("IdVariedad", , -1)
        '_btBusca.Params("IdGenero", , -1)


    End Sub

End Class
