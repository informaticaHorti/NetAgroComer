Public Class E_trazaconf
    Inherits Cdatos.Entidad

    Public TRC_idtraza As Cdatos.bdcampo
    Public TRC_idlineaent As Cdatos.bdcampo
    Public TRC_idpaletlinea As Cdatos.bdcampo
    Public TRC_bultos As Cdatos.bdcampo
    Public TRC_kilos As Cdatos.bdcampo
    Public TRC_gasto As Cdatos.bdcampo

    Public TRC_IdUsuarioLog As Cdatos.bdcampo
    Public TRC_FechaLog As Cdatos.bdcampo
    Public TRC_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "trazaconf"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            TRC_idtraza = New Cdatos.bdcampo(CodigoEntidad & "idtraza", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            TRC_idlineaent = New Cdatos.bdcampo(CodigoEntidad & "idlineaent", Cdatos.TiposCampo.EnteroPositivo, 6)
            TRC_idpaletlinea = New Cdatos.bdcampo(CodigoEntidad & "idpaletlinea", Cdatos.TiposCampo.EnteroPositivo, 6)
            TRC_bultos = New Cdatos.bdcampo(CodigoEntidad & "bultos", Cdatos.TiposCampo.Importe, 6)
            TRC_kilos = New Cdatos.bdcampo(CodigoEntidad & "kilos", Cdatos.TiposCampo.Importe, 6, 2)
            TRC_gasto = New Cdatos.bdcampo(CodigoEntidad & "gasto", Cdatos.TiposCampo.Importe, 10, 6)

            TRC_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            TRC_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            TRC_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub

    Public Sub CopiarTrazabilidad(idlineaentrada As String)

        Dim consulta1 As New Cdatos.E_select
        Dim Palets_traza As New E_palets_traza(Idusuario, cn)
        consulta1.SelCampo(Me.TRC_idtraza, "idtraza")
        consulta1.WheCampo(Me.TRC_idlineaent, "=", idlineaentrada)
        Dim sql1 As String = consulta1.SQL
        Dim dt1 As DataTable = Me.MiConexion.ConsultaSQL(sql1)
        If Not dt1 Is Nothing Then
            If dt1.Rows.Count = 0 Then

                Dim consulta As New Cdatos.E_select
                consulta.SelCampo(Palets_traza.PLT_idlineapalet, "idlineapalet")
                consulta.SelCampo(Palets_traza.PLT_bultos, "bultos")
                consulta.SelCampo(Palets_traza.PLT_kilos, "kilos")
                consulta.WheCampo(Palets_traza.PLT_IdLineaEntrada, "=", idlineaentrada)
                Dim sql As String = consulta.SQL
                Dim dt As DataTable = Palets_traza.MiConexion.ConsultaSQL(sql)
                If Not dt Is Nothing Then
                    For Each rw In dt.Rows
                        Me.VaciaEntidad()
                        Dim id As String = Me.MaxId.ToString
                        Me.TRC_idtraza.Valor = id
                        Me.TRC_idlineaent.Valor = idlineaentrada
                        Me.TRC_idpaletlinea.Valor = rw("idlineapalet").ToString
                        Me.TRC_bultos.Valor = rw("bultos").ToString
                        Me.TRC_kilos.Valor = rw("kilos").ToString
                        Me.Insertar()
                    Next
                End If


            End If
        End If


    End Sub


    Public Sub BorrarTrazabilidad(idlineaentrada As String)

        If VaInt(idlineaentrada) > 0 Then

            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(Me.TRC_idtraza, "IdTraza")
            CONSULTA.WheCampo(Me.TRC_idlineaent, "=", idlineaentrada)

            Dim dt As DataTable = MiConexion.ConsultaSQL(CONSULTA.SQL)


            Dim TrazaConf As New E_trazaconf(Idusuario, cn)

            For Each row As DataRow In dt.Rows
                Dim IdTraza As String = row("IdTraza").ToString & ""
                If TrazaConf.LeerId(IdTraza) Then
                    TrazaConf.Eliminar()
                End If
            Next

        End If

    End Sub



End Class
