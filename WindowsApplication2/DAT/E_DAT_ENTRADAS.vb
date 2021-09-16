Public Class E_DAT_ENTRADAS
    Inherits Cdatos.Entidad


    Public Enum DAT_Estados

        Borrador = 339
        Creado = 333
        EnTransito = 334
        Recibido = 335
        Caducado = 337
        Rechazado = 338

    End Enum



    Public DAT_Localizador As Cdatos.bdcampo

    Public DAT_IdEmpresa As Cdatos.BdCampo
    Public DAT_IdCentro As Cdatos.BdCampo
    Public DAT_IdCampa As Cdatos.BdCampo
    Public DAT_Serie As Cdatos.BdCampo
    Public DAT_IdAlbaran As Cdatos.BdCampo

    Public DAT_IdAlbaranNET As Cdatos.BdCampo

    Public DAT_FechaEnt As Cdatos.bdcampo
    Public DAT_HoraEnt As Cdatos.BdCampo
    Public DAT_Peso As Cdatos.BdCampo
    Public DAT_Observaciones As Cdatos.BdCampo
    Public DAT_Recibido As Cdatos.BdCampo
    Public DAT_NIFAgricultor As Cdatos.BdCampo
    Public DAT_NombreAgricultor As Cdatos.BdCampo
    Public DAT_NIFTransportista As Cdatos.BdCampo
    Public DAT_NombreTransportista As Cdatos.BdCampo

    Public DAT_UsuarioLog As Cdatos.BdCampo
    Public DAT_FechaLog As Cdatos.BdCampo
    Public DAT_HoraLog As Cdatos.BdCampo

    Public DAT_Estado As Cdatos.BdCampo
    Public DAT_FechaAcepta As Cdatos.BdCampo
    Public DAT_HoraAcepta As Cdatos.BdCampo
    Public DAT_NIFAgricultorDAT As Cdatos.BdCampo
    Public DAT_NIFTransportistaDAT As Cdatos.BdCampo
    Public DAT_ObservaEnvio As Cdatos.BdCampo




    Dim err As New Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub



    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "DAT_ENTRADAS"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            DAT_Localizador = New Cdatos.bdcampo(CodigoEntidad & "LOCALIZADOR", Cdatos.TiposCampo.Cadena, 20, , True)

            DAT_IdEmpresa = New Cdatos.bdcampo(CodigoEntidad & "IDEMPRESA", Cdatos.TiposCampo.EnteroPositivo, 5)
            DAT_IdCentro = New Cdatos.bdcampo(CodigoEntidad & "IDCENTRO", Cdatos.TiposCampo.EnteroPositivo, 5)
            DAT_IdCampa = New Cdatos.bdcampo(CodigoEntidad & "IDCAMPA", Cdatos.TiposCampo.EnteroPositivo, 5)
            DAT_Serie = New Cdatos.bdcampo(CodigoEntidad & "SERIE", Cdatos.TiposCampo.Cadena, 12)
            DAT_IdAlbaran = New Cdatos.bdcampo(CodigoEntidad & "IDALBARAN", Cdatos.TiposCampo.EnteroPositivo, 10)

            DAT_IdAlbaranNET = New Cdatos.bdcampo(CodigoEntidad & "IDALBARANNET", Cdatos.TiposCampo.EnteroPositivo, 10)

            DAT_FechaEnt = New Cdatos.bdcampo(CodigoEntidad & "FECHAENT", Cdatos.TiposCampo.Cadena, 8)
            DAT_HoraEnt = New Cdatos.bdcampo(CodigoEntidad & "HORAENT", Cdatos.TiposCampo.Cadena, 8)
            DAT_Peso = New Cdatos.bdcampo(CodigoEntidad & "PESO", Cdatos.TiposCampo.Entero, 10)
            DAT_Observaciones = New Cdatos.bdcampo(CodigoEntidad & "OBSERVACIONES", Cdatos.TiposCampo.Cadena, 50)
            DAT_Recibido = New Cdatos.bdcampo(CodigoEntidad & "RECIBIDO", Cdatos.TiposCampo.Entero, 1)
            DAT_NIFAgricultor = New Cdatos.bdcampo(CodigoEntidad & "NIFAGRICULTOR", Cdatos.TiposCampo.Cadena, 30)
            DAT_NombreAgricultor = New Cdatos.bdcampo(CodigoEntidad & "NOMBREAGRICULTOR", Cdatos.TiposCampo.Cadena, 100)
            DAT_NIFTransportista = New Cdatos.bdcampo(CodigoEntidad & "NIFTRANSPORTISTA", Cdatos.TiposCampo.Cadena, 30)
            DAT_NombreTransportista = New Cdatos.bdcampo(CodigoEntidad & "NOMBRETRANSPORTISTA", Cdatos.TiposCampo.Cadena, 100)

            DAT_UsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "USUARIOLOG", Cdatos.TiposCampo.Cadena, 50)
            DAT_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FECHALOG", Cdatos.TiposCampo.Cadena, 8)
            DAT_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HORALOG", Cdatos.TiposCampo.Cadena, 8)

            DAT_Estado = New Cdatos.bdcampo(CodigoEntidad & "ESTADO", Cdatos.TiposCampo.Entero, 5)
            DAT_FechaAcepta = New Cdatos.bdcampo(CodigoEntidad & "FECHAACEPTA", Cdatos.TiposCampo.Cadena, 8)
            DAT_HoraAcepta = New Cdatos.bdcampo(CodigoEntidad & "HORAACEPTA", Cdatos.TiposCampo.Cadena, 8)
            DAT_NIFAgricultorDAT = New Cdatos.bdcampo(CodigoEntidad & "NIFAGRICULTORDAT", Cdatos.TiposCampo.Cadena, 30)
            DAT_NIFTransportistaDAT = New Cdatos.bdcampo(CodigoEntidad & "NIFTRANSPORTISTADAT", Cdatos.TiposCampo.Cadena, 30)
            DAT_ObservaEnvio = New Cdatos.bdcampo(CodigoEntidad & "OBSERVAENVIO", Cdatos.TiposCampo.Cadena, 1024)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim sql As String = "SELECT DAT_LOCALIZADOR as Localizador, DAT_IDCENTRO as CE, DAT_NIFAGRICULTOR as NIF, DAT_NOMBREAGRICULTOR as Agricultor, DAT_PESO as Peso,"
        sql = sql & " CASE LEN(DAT_FECHALOG) WHEN 8 THEN CONCAT(CONCAT(SUBSTRING(DAT_FECHALOG, 7, 2), '/', SUBSTRING(DAT_FECHALOG, 5, 2)), '/', SUBSTRING(DAT_FECHALOG, 1, 4)) ELSE DAT_FECHALOG END as Fecha" & vbCrLf
        sql = sql & " FROM DAT_ENTRADAS" & vbCrLf
        sql = sql & " WHERE DAT_ESTADO <> 335 AND DAT_ESTADO <> 338"



        _btBusca.CL_CampoOrden = "Agricultor"
        _btBusca.CL_ConsultaSql = Sql
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Localizador"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaLocalizador"
        _btBusca.CL_ch1000 = False
        _btBusca.Width = 1000



    End Sub


    Public Shared Function DesasociarAlbaran(ByVal Localizador As String, ByVal IdAlbaran As String) As Boolean

        Dim bRes As Boolean = False

        If VaDec(IdAlbaran) > 0 And (Localizador & "").Trim <> "" Then

            Dim sql As String = "SELECT DAT_LOCALIZADOR as localizador FROM DAT_ENTRADAS WHERE DAT_IDALBARANNET = " & IdAlbaran & " AND DAT_LOCALIZADOR <> '" & Localizador & "'"
            Dim dt As DataTable = cn.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                For Each row As DataRow In dt.Rows

                    Dim IdEntrada As String = (row("localizador").ToString & "").Trim

                    If IdEntrada.Trim <> "" Then
                        Dim DAT_ENTRADAS As New E_DAT_ENTRADAS(Idusuario, cn)

                        If DAT_ENTRADAS.LeerId(IdEntrada) Then

                            DAT_ENTRADAS.DAT_IdAlbaran.Valor = ""
                            DAT_ENTRADAS.DAT_IdAlbaranNET.Valor = ""
                            If LocalizadorPendiente(IdEntrada) Then
                                DAT_ENTRADAS.DAT_FechaEnt.Valor = ""
                                DAT_ENTRADAS.DAT_HoraEnt.Valor = ""
                                DAT_ENTRADAS.DAT_Peso.Valor = "0"
                            End If

                            DAT_ENTRADAS.Actualizar()

                        End If
                    End If

                Next

            End If

        End If


        Return bRes

    End Function


    Public Shared Function EliminarLocalizadorAlbaran(ByVal IdAlbaran As String) As Boolean

        Dim bRes As Boolean = False


        If VaDec(IdAlbaran) > 0 Then

            Dim sql As String = "SELECT DAT_LOCALIZADOR as localizador FROM DAT_ENTRADAS WHERE DAT_IDALBARANNET = " & IdAlbaran
            Dim dt As DataTable = cn.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                For Each row As DataRow In dt.Rows

                    Dim localizador As String = (row("localizador").ToString & "").Trim

                    If localizador.Trim <> "" Then
                        Dim DAT_ENTRADAS As New E_DAT_ENTRADAS(Idusuario, cn)

                        If DAT_ENTRADAS.LeerId(localizador) Then

                            DAT_ENTRADAS.DAT_IdAlbaran.Valor = ""
                            DAT_ENTRADAS.DAT_IdAlbaranNET.Valor = ""
                            If LocalizadorPendiente(localizador) Then
                                DAT_ENTRADAS.DAT_FechaEnt.Valor = ""
                                DAT_ENTRADAS.DAT_HoraEnt.Valor = ""
                                DAT_ENTRADAS.DAT_Peso.Valor = "0"
                            End If

                            DAT_ENTRADAS.Actualizar()

                        End If
                    End If

                Next

            End If

        End If


        Return bRes

    End Function


    Public Shared Sub Actualizar_DAT_ENTRADA(ByVal IdAlbaran As String, ByVal localizador As String, ByVal Peso As Integer)


        'Ha cambiado el DAT en la JJAA, actualizamos:


        'NO INSERTAMOS, de eso se encarga la app de Jose Jibaja
        Dim DAT_ENTRADAS As New E_DAT_ENTRADAS(Idusuario, cn)
        If DAT_ENTRADAS.LeerId(localizador) Then

            If Not LocalizadorPendiente(localizador) Then
                MessageBox.Show("El porte ya ha sido aceptado o rechazado en la JJAA, no se puede volver a presentar", "ATENCIÓN - DAT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            'Datos desde el albarán
            If VaDec(IdAlbaran) > 0 Then

                Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
                If AlbEntrada.LeerId(IdAlbaran) Then


                    'Busco si hay otro localizador para este albarán, si lo hay, le borro los datos del albarán
                    E_DAT_ENTRADAS.DesasociarAlbaran(localizador, IdAlbaran)


                    'Actualizamos los datos de la parte del albarán
                    DAT_ENTRADAS.DAT_IdAlbaran.Valor = AlbEntrada.AEN_Albaran.Valor
                    DAT_ENTRADAS.DAT_IdAlbaranNET.Valor = IdAlbaran

                    If LocalizadorPendiente(localizador) Then
                        DAT_ENTRADAS.DAT_FechaEnt.Valor = VaDate(AlbEntrada.AEN_Fecha.Valor).ToString("yyyyMMdd")
                        DAT_ENTRADAS.DAT_HoraEnt.Valor = Now.ToString("HH:mm:ss")
                        DAT_ENTRADAS.DAT_Peso.Valor = Peso.ToString
                        'DAT_ENTRADAS.DAT_Observaciones.Valor = Observaciones
                    End If

                End If

            End If

            DAT_ENTRADAS.Actualizar()


        Else
            MsgBox("El localizador introducido no existe")
        End If



    End Sub


    Public Shared Function LocalizadorPendiente(ByVal localizador As String) As Boolean

        Dim bRes As Boolean = False


        If localizador.Trim <> "" Then

            Dim DAT_ENTRADAS As New E_DAT_ENTRADAS(Idusuario, cn)
            If DAT_ENTRADAS.LeerId(localizador) Then

                If VaInt(DAT_ENTRADAS.DAT_Estado.Valor) <> VaInt(DAT_Estados.Rechazado) And VaInt(DAT_ENTRADAS.DAT_Estado.Valor) <> VaInt(DAT_Estados.Recibido) Then
                    bRes = True
                End If

            Else
                'No existe el localizador en la tabla, está pendiente
                bRes = True
            End If

        End If


        Return bRes

    End Function


    Public Overrides Function FechaLogToString(Fecha As Date) As String

        Return Fecha.ToString("yyyyMMdd")

    End Function



End Class
