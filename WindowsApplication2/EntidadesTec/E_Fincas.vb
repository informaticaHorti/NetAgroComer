Public Class E_Fincas

    Inherits Cdatos.Entidad

    Public FIN_IdFinca As Cdatos.bdcampo
    Public FIN_Nombre As Cdatos.bdcampo
    Public FIN_IdAgricultor As Cdatos.bdcampo
    Public FIN_IdZona As Cdatos.bdcampo
    Public FIN_IdPozo As Cdatos.bdcampo
    Public FIN_IdRegimen As Cdatos.bdcampo
    Public FIN_IdTecnico As Cdatos.bdcampo
    Public FIN_IdAbonadora As Cdatos.bdcampo
    Public FIN_Responsable As Cdatos.bdcampo
    Public FIN_fechaFinArr As Cdatos.bdcampo
    Public FIN_IdAgriaSoc As Cdatos.bdcampo
    Public FIN_Superficie As Cdatos.bdcampo
    Public FIN_numRegistro As Cdatos.bdcampo
    Public FIN_Aplicador As Cdatos.bdcampo
    Public FIN_Carnet As Cdatos.bdcampo
    'Public FIN_posGps As Cdatos.bdcampo
    Public FIN_Latitud As Cdatos.bdcampo
    Public FIN_Longitud As Cdatos.bdcampo
    Public FIN_Municipio As Cdatos.bdcampo
    Public FIN_Provincia As Cdatos.bdcampo
    Public FIN_superficieCultivo As Cdatos.bdcampo
    Public FIN_Finca As Cdatos.bdcampo

    Public FIN_IdUsuarioLog As Cdatos.bdcampo
    Public FIN_FechaLog As Cdatos.bdcampo
    Public FIN_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Fincas"
            NombreBd = "TecnicosNet"
            MiConexion = conexion


            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            FIN_IdFinca = New Cdatos.bdcampo(CodigoEntidad & "IdFinca", Cdatos.TiposCampo.Entero, 5, , True)
            FIN_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 50)
            FIN_IdAgricultor = New Cdatos.bdcampo(CodigoEntidad & "IdAgricultor", Cdatos.TiposCampo.Entero, 5)
            FIN_IdZona = New Cdatos.bdcampo(CodigoEntidad & "IdZona", Cdatos.TiposCampo.Entero, 4)
            FIN_IdPozo = New Cdatos.bdcampo(CodigoEntidad & "IdPozo", Cdatos.TiposCampo.Entero, 4)
            FIN_IdRegimen = New Cdatos.bdcampo(CodigoEntidad & "IdRegimen", Cdatos.TiposCampo.Entero, 4)
            FIN_IdTecnico = New Cdatos.bdcampo(CodigoEntidad & "IdTecnico", Cdatos.TiposCampo.Entero, 4)
            FIN_IdAbonadora = New Cdatos.bdcampo(CodigoEntidad & "IdAbonadora", Cdatos.TiposCampo.Entero, 4)
            FIN_Responsable = New Cdatos.bdcampo(CodigoEntidad & "Responsable", Cdatos.TiposCampo.Cadena, 50)
            FIN_fechaFinArr = New Cdatos.bdcampo(CodigoEntidad & "FechaFinArr", Cdatos.TiposCampo.Fecha, 10)
            FIN_IdAgriaSoc = New Cdatos.bdcampo(CodigoEntidad & "IdAgriAsoc", Cdatos.TiposCampo.Entero, 5)
            FIN_Superficie = New Cdatos.bdcampo(CodigoEntidad & "Superficie", Cdatos.TiposCampo.Importe, 8)
            FIN_numRegistro = New Cdatos.bdcampo(CodigoEntidad & "NumRegistro", Cdatos.TiposCampo.Cadena, 30)
            FIN_Aplicador = New Cdatos.bdcampo(CodigoEntidad & "Aplicador", Cdatos.TiposCampo.Cadena, 35)
            FIN_Carnet = New Cdatos.bdcampo(CodigoEntidad & "Carnet", Cdatos.TiposCampo.Cadena, 10)
            ' FIN_posGps = New Cdatos.bdcampo(CodigoEntidad & "PosGps", Cdatos.TiposCampo.Cadena, 20)

            FIN_Latitud = New Cdatos.bdcampo(CodigoEntidad & "Latitud", Cdatos.TiposCampo.Cadena, 9)
            FIN_Longitud = New Cdatos.bdcampo(CodigoEntidad & "Longitud", Cdatos.TiposCampo.Cadena, 9)

            FIN_Municipio = New Cdatos.bdcampo(CodigoEntidad & "Municipio", Cdatos.TiposCampo.Cadena, 50)
            FIN_Provincia = New Cdatos.bdcampo(CodigoEntidad & "Provincia", Cdatos.TiposCampo.Cadena, 50)
            FIN_superficieCultivo = New Cdatos.bdcampo(CodigoEntidad & "SuperficieCultivo", Cdatos.TiposCampo.Importe, 8)
            FIN_Finca = New Cdatos.bdcampo(CodigoEntidad & "Finca", Cdatos.TiposCampo.Cadena, 10)

            FIN_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            FIN_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            FIN_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error en la entidad ", "New", ex.Message)
        End Try

        Dim sql As String = "Select FIN_IdFinca as IdFinca, FIN_IdAgricultor as CodAgr, agr_nombre as Agricultor, FIN_Nombre as Nombre, FIN_Superficie as Superficie" & vbCrLf
        sql = sql & " from Fincas " & vbCrLf
        sql = sql & " left join agricultores ON agr_idagricultor = FIN_IdAgricultor"

        _btBusca.CL_CampoOrden = "IdFinca"
        _btBusca.CL_ConsultaSql = sql
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdFinca"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaFincas"
        _btBusca.CL_ch1000 = False

    End Sub

End Class
