Public Class E_DAT_ENTRADAS_PERIODOS
    Inherits Cdatos.Entidad


    Public DEP_Localizador As Cdatos.bdcampo

    Public DEP_IdEmpresa As Cdatos.bdcampo
    Public DEP_IdCentro As Cdatos.bdcampo
    Public DEP_IdCampa As Cdatos.bdcampo
    Public DEP_Serie As Cdatos.bdcampo
    Public DEP_IdAlbaran As Cdatos.bdcampo
    Public DEP_IdAlbaranNET As Cdatos.bdcampo
    Public DEP_IdLinea As Cdatos.bdcampo

    Public DEP_FechaEnt As Cdatos.bdcampo
    Public DEP_HoraEnt As Cdatos.bdcampo
    Public DEP_IdGenero As Cdatos.bdcampo
    Public DEP_Peso As Cdatos.bdcampo
    Public DEP_Observaciones As Cdatos.bdcampo
    Public DEP_Recibido As Cdatos.bdcampo
    Public DEP_NIFAgricultor As Cdatos.bdcampo
    Public DEP_NombreAgricultor As Cdatos.bdcampo
    Public DEP_NIFTransportista As Cdatos.bdcampo
    Public DEP_NombreTransportista As Cdatos.bdcampo

    Public DEP_UsuarioLog As Cdatos.bdcampo
    Public DEP_FechaLog As Cdatos.bdcampo
    Public DEP_HoraLog As Cdatos.bdcampo

    Public DEP_Estado As Cdatos.bdcampo
    Public DEP_FechaAcepta As Cdatos.bdcampo
    Public DEP_HoraAcepta As Cdatos.bdcampo
    Public DEP_NIFAgricultorDAT As Cdatos.bdcampo
    Public DEP_NIFTransportistaDAT As Cdatos.bdcampo
    Public DEP_ObservaEnvio As Cdatos.bdcampo


    Dim err As New Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub



    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "DAT_ENTRADAS_PERIODOS"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            DEP_Localizador = New Cdatos.bdcampo(CodigoEntidad & "LOCALIZADOR", Cdatos.TiposCampo.Cadena, 20, , True)

            DEP_IdEmpresa = New Cdatos.bdcampo(CodigoEntidad & "IDEMPRESA", Cdatos.TiposCampo.EnteroPositivo, 5)
            DEP_IdCentro = New Cdatos.bdcampo(CodigoEntidad & "IDCENTRO", Cdatos.TiposCampo.EnteroPositivo, 5)
            DEP_IdCampa = New Cdatos.bdcampo(CodigoEntidad & "IDCAMPA", Cdatos.TiposCampo.EnteroPositivo, 5)
            DEP_Serie = New Cdatos.bdcampo(CodigoEntidad & "SERIE", Cdatos.TiposCampo.Cadena, 12)
            DEP_IdAlbaran = New Cdatos.bdcampo(CodigoEntidad & "IDALBARAN", Cdatos.TiposCampo.EnteroPositivo, 10)
            DEP_IdAlbaranNET = New Cdatos.bdcampo(CodigoEntidad & "IDALBARANNET", Cdatos.TiposCampo.EnteroPositivo, 10)
            DEP_IdLinea = New Cdatos.bdcampo(CodigoEntidad & "IDLINEA", Cdatos.TiposCampo.EnteroPositivo, 10)

            DEP_FechaEnt = New Cdatos.bdcampo(CodigoEntidad & "FECHAENT", Cdatos.TiposCampo.Cadena, 8)
            DEP_HoraEnt = New Cdatos.bdcampo(CodigoEntidad & "HORAENT", Cdatos.TiposCampo.Cadena, 8)
            DEP_IdGenero = New Cdatos.bdcampo(CodigoEntidad & "IDGENERO", Cdatos.TiposCampo.Entero, 5)
            DEP_Peso = New Cdatos.bdcampo(CodigoEntidad & "PESO", Cdatos.TiposCampo.Entero, 10)
            DEP_Observaciones = New Cdatos.bdcampo(CodigoEntidad & "OBSERVACIONES", Cdatos.TiposCampo.Cadena, 50)
            DEP_Recibido = New Cdatos.bdcampo(CodigoEntidad & "RECIBIDO", Cdatos.TiposCampo.Entero, 1)
            DEP_NIFAgricultor = New Cdatos.bdcampo(CodigoEntidad & "NIFAGRICULTOR", Cdatos.TiposCampo.Cadena, 30)
            DEP_NombreAgricultor = New Cdatos.bdcampo(CodigoEntidad & "NOMBREAGRICULTOR", Cdatos.TiposCampo.Cadena, 100)
            DEP_NIFTransportista = New Cdatos.bdcampo(CodigoEntidad & "NIFTRANSPORTISTA", Cdatos.TiposCampo.Cadena, 30)
            DEP_NombreTransportista = New Cdatos.bdcampo(CodigoEntidad & "NOMBRETRANSPORTISTA", Cdatos.TiposCampo.Cadena, 100)

            DEP_UsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "USUARIOLOG", Cdatos.TiposCampo.Cadena, 50)
            DEP_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FECHALOG", Cdatos.TiposCampo.Cadena, 8)
            DEP_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HORALOG", Cdatos.TiposCampo.Cadena, 8)

            DEP_Estado = New Cdatos.bdcampo(CodigoEntidad & "ESTADO", Cdatos.TiposCampo.Entero, 5)
            DEP_FechaAcepta = New Cdatos.bdcampo(CodigoEntidad & "FECHAACEPTA", Cdatos.TiposCampo.Cadena, 8)
            DEP_HoraAcepta = New Cdatos.bdcampo(CodigoEntidad & "HORAACEPTA", Cdatos.TiposCampo.Cadena, 8)
            DEP_NIFAgricultorDAT = New Cdatos.bdcampo(CodigoEntidad & "NIFAGRICULTORDAT", Cdatos.TiposCampo.Cadena, 30)
            DEP_NIFTransportistaDAT = New Cdatos.bdcampo(CodigoEntidad & "NIFTRANSPORTISTADAT", Cdatos.TiposCampo.Cadena, 30)
            DEP_ObservaEnvio = New Cdatos.bdcampo(CodigoEntidad & "OBSERVAENVIO", Cdatos.TiposCampo.Cadena, 1024)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim sql As String = "SELECT DEP_LOCALIZADOR as Localizador, DEP_IDCENTRO as CE, DEP_NIFAGRICULTOR as NIF, DEP_NOMBREAGRICULTOR as Agricultor," & vbCrLf
        sql = sql & " DEP_IdGenero as CodGen, GEN_NombreGenero as Genero, DEP_PESO as Peso," & vbCrLf
        sql = sql & " CASE LEN(DEP_FECHALOG) WHEN 8 THEN CONCAT(CONCAT(SUBSTRING(DEP_FECHALOG, 7, 2), '/', SUBSTRING(DEP_FECHALOG, 5, 2)), '/', SUBSTRING(DEP_FECHALOG, 1, 4)) ELSE DEP_FECHALOG END as Fecha" & vbCrLf
        sql = sql & " FROM DAT_ENTRADAS_PERIODOS" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = DEP_IdGenero" & vbCrLf
        sql = sql & " WHERE DEP_ESTADO <> 335 AND DEP_ESTADO <> 338"



        _btBusca.CL_CampoOrden = "Agricultor"
        _btBusca.CL_ConsultaSql = sql
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Localizador"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaLocalizador"
        _btBusca.CL_ch1000 = False
        _btBusca.Width = 1000



    End Sub


    Public Shared Function DesasociarLineaAlbaran(ByVal Localizador As String, ByVal IdLinea As String) As Boolean

        Dim bRes As Boolean = False

        If VaDec(IdLinea) > 0 And (Localizador & "").Trim <> "" Then

            Dim sql As String = "SELECT DEP_LOCALIZADOR as localizador FROM DAT_ENTRADAS_PERIODOS WHERE DEP_IDLINEA = " & IdLinea & " AND DEP_LOCALIZADOR <> '" & Localizador & "'"
            Dim dt As DataTable = cn.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                For Each row As DataRow In dt.Rows

                    Dim IdEntrada As String = (row("localizador").ToString & "").Trim

                    If IdEntrada.Trim <> "" Then

                        Dim DAT_ENTRADAS_PERIODOS As New E_DAT_ENTRADAS_PERIODOS(Idusuario, cn)
                        If DAT_ENTRADAS_PERIODOS.LeerId(IdEntrada) Then

                            DAT_ENTRADAS_PERIODOS.DEP_IdAlbaran.Valor = ""
                            DAT_ENTRADAS_PERIODOS.DEP_IdAlbaranNET.Valor = ""
                            DAT_ENTRADAS_PERIODOS.DEP_IdLinea.Valor = ""

                            If LocalizadorPendiente(IdEntrada) Then
                                DAT_ENTRADAS_PERIODOS.DEP_FechaEnt.Valor = ""
                                DAT_ENTRADAS_PERIODOS.DEP_HoraEnt.Valor = ""
                                DAT_ENTRADAS_PERIODOS.DEP_IdGenero.Valor = ""
                                DAT_ENTRADAS_PERIODOS.DEP_Peso.Valor = "0"
                            End If

                            DAT_ENTRADAS_PERIODOS.Actualizar()

                        End If
                    End If

                Next

            End If

        End If


        Return bRes

    End Function


    Public Shared Function EliminarLocalizadorLineaAlbaran(ByVal IdLinea As String) As Boolean

        Dim bRes As Boolean = False


        If VaDec(IdLinea) > 0 Then

            Dim sql As String = "SELECT DEP_LOCALIZADOR as localizador FROM DAT_ENTRADAS_PERIODOS WHERE DEP_IDLINEA = " & IdLinea
            Dim dt As DataTable = cn.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                For Each row As DataRow In dt.Rows

                    Dim localizador As String = (row("localizador").ToString & "").Trim

                    If localizador.Trim <> "" Then

                        Dim DAT_ENTRADAS_PERIODOS As New E_DAT_ENTRADAS_PERIODOS(Idusuario, cn)
                        If DAT_ENTRADAS_PERIODOS.LeerId(localizador) Then

                            DAT_ENTRADAS_PERIODOS.DEP_IdAlbaran.Valor = ""
                            DAT_ENTRADAS_PERIODOS.DEP_IdAlbaranNET.Valor = ""
                            DAT_ENTRADAS_PERIODOS.DEP_IdLinea.Valor = ""

                            If LocalizadorPendiente(localizador) Then
                                DAT_ENTRADAS_PERIODOS.DEP_FechaEnt.Valor = ""
                                DAT_ENTRADAS_PERIODOS.DEP_HoraEnt.Valor = ""
                                DAT_ENTRADAS_PERIODOS.DEP_IdGenero.Valor = ""
                                DAT_ENTRADAS_PERIODOS.DEP_Peso.Valor = "0"
                            End If

                            DAT_ENTRADAS_PERIODOS.Actualizar()

                        End If
                    End If

                Next

            End If

        End If


        Return bRes

    End Function


    Public Shared Sub Actualizar_DAT_ENTRADA_PERIODO(ByVal IdLinea As String, ByVal localizador As String, ByVal Peso As Integer)


        'Ha cambiado el DAT en la JJAA, actualizamos:


        'NO INSERTAMOS, de eso se encarga la app de Jose Jibaja
        Dim DAT_ENTRADAS_PERIODOS As New E_DAT_ENTRADAS_PERIODOS(Idusuario, cn)
        If DAT_ENTRADAS_PERIODOS.LeerId(localizador) Then

            If Not LocalizadorPendiente(localizador) Then
                MessageBox.Show("El porte ya ha sido aceptado o rechazado en la JJAA, no se puede volver a presentar", "ATENCIÓN - DAT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            'Datos desde el albarán
            If VaDec(IdLinea) > 0 Then

                Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
                If AlbEntrada_Lineas.LeerId(IdLinea) Then


                    'Busco si hay otro localizador para este albarán, si lo hay, le borro los datos del albarán
                    E_DAT_ENTRADAS_PERIODOS.DesasociarLineaAlbaran(localizador, IdLinea)


                    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
                    AlbEntrada.LeerId(AlbEntrada_Lineas.AEL_idalbaran.Valor)


                    'Actualizamos los datos de la parte del albarán
                    DAT_ENTRADAS_PERIODOS.DEP_IdAlbaran.Valor = AlbEntrada.AEN_Albaran.Valor
                    DAT_ENTRADAS_PERIODOS.DEP_IdAlbaranNET.Valor = AlbEntrada_Lineas.AEL_idalbaran.Valor
                    DAT_ENTRADAS_PERIODOS.DEP_IdLinea.Valor = IdLinea

                    If LocalizadorPendiente(localizador) Then
                        DAT_ENTRADAS_PERIODOS.DEP_FechaEnt.Valor = VaDate(AlbEntrada.AEN_Fecha.Valor).ToString("yyyyMMdd")
                        DAT_ENTRADAS_PERIODOS.DEP_HoraEnt.Valor = Now.ToString("HH:mm:ss")
                        DAT_ENTRADAS_PERIODOS.DEP_IdGenero.Valor = AlbEntrada_Lineas.AEL_idgenero.Valor
                        DAT_ENTRADAS_PERIODOS.DEP_Peso.Valor = Peso.ToString
                        'DEP_ENTRADAS.DEP_Observaciones.Valor = Observaciones
                    End If

                End If

            End If

            DAT_ENTRADAS_PERIODOS.Actualizar()


        Else
            MsgBox("El localizador introducido no existe")
        End If



    End Sub



    Public Shared Function LocalizadorPendiente(ByVal localizador As String) As Boolean

        Dim bRes As Boolean = False


        If localizador.Trim <> "" Then

            Dim DAT_ENTRADAS_PERIODOS As New E_DAT_ENTRADAS_PERIODOS(Idusuario, cn)
            If DAT_ENTRADAS_PERIODOS.LeerId(localizador) Then

                If VaInt(DAT_ENTRADAS_PERIODOS.DEP_Estado.Valor) <> VaInt(DAT_Estados.Rechazado) And VaInt(DAT_ENTRADAS_PERIODOS.DEP_Estado.Valor) <> VaInt(DAT_Estados.Recibido) Then
                    bRes = True
                End If

            Else
                'No existe el localizador en la tabla, está pendiente
                bRes = True
            End If

        End If


        Return bRes

    End Function


    Public Overrides Function FechaLogToString(ByVal Fecha As Date) As String

        Return Fecha.ToString("yyyyMMdd")

    End Function



End Class
