Public Class E_palets_traza
    Inherits Cdatos.Entidad

    Public PLT_idtraza As Cdatos.bdcampo
    Public PLT_idlineapalet As Cdatos.bdcampo
    Public PLT_bultos As Cdatos.bdcampo
    Public PLT_kilos As Cdatos.bdcampo
    Public PLT_IdLineaEntrada As Cdatos.bdcampo
    Public PLT_idlote As Cdatos.bdcampo
    Public PLT_idprecalibrado As Cdatos.bdcampo
    Public PLT_idprogramacliente As Cdatos.bdcampo

    Public PLT_IdUsuarioLog As Cdatos.bdcampo
    Public PLT_FechaLog As Cdatos.bdcampo
    Public PLT_HoraLog As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "palets_traza"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            PLT_idtraza = New Cdatos.bdcampo(CodigoEntidad & "idtraza", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            PLT_idlineapalet = New Cdatos.bdcampo(CodigoEntidad & "idlineapalet", Cdatos.TiposCampo.EnteroPositivo, 6)
            PLT_bultos = New Cdatos.bdcampo(CodigoEntidad & "bultos", Cdatos.TiposCampo.Importe, 6)
            PLT_kilos = New Cdatos.bdcampo(CodigoEntidad & "kilos", Cdatos.TiposCampo.Importe, 6, 2)
            PLT_IdLineaEntrada = New Cdatos.bdcampo(CodigoEntidad & "IdLineaEntrada", Cdatos.TiposCampo.EnteroPositivo, 10)
            PLT_idlote = New Cdatos.bdcampo(CodigoEntidad & "IdLote", Cdatos.TiposCampo.EnteroPositivo, 10)
            PLT_idprecalibrado = New Cdatos.bdcampo(CodigoEntidad & "Idprecalibrado", Cdatos.TiposCampo.EnteroPositivo, 10)
            PLT_idprogramacliente = New Cdatos.bdcampo(CodigoEntidad & "Idprogramacliente", Cdatos.TiposCampo.EnteroPositivo, 10)

            PLT_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PLT_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PLT_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


    Public Sub DuplicaTrazabilidad(idalbaran As Integer)
        Dim consulta As New Cdatos.E_select
        Dim palets_linea As New E_palets_lineas(Idusuario, cn)
        Dim albsalida_palets As New E_albsalida_palets(Idusuario, cn)
        Dim albsalida As New E_AlbSalida(Idusuario, cn)
        Dim palets_traza As New E_palets_traza(Idusuario, cn)
        Dim palets As New E_palets(Idusuario, cn)
        Dim Clientes_programa As New E_ClientesPrograma(Idusuario, cn)

        Dim Cliente As String = ""
        If albsalida.LeerId(idalbaran.ToString) = True Then
            Cliente = albsalida.ASA_idcliente.Valor
        Else
            Exit Sub
        End If

        Dim listaprogramas As New List(Of Integer)

        consulta.SelCampo(Clientes_programa.CPR_idprograma, "idprograma")
        consulta.WheCampo(Clientes_programa.CPR_idcliente, "=", Cliente)
        Dim sql As String = consulta.SQL
        Dim dt As New DataTable
        dt = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count = 0 Then
                Exit Sub
            Else
                For Each rw In dt.Rows
                    listaprogramas.Add(VaInt(rw("idprograma")))
                Next
            End If
        End If

        consulta = New Cdatos.E_select

        consulta.SelCampo(palets_traza.PLT_idlineapalet, "idlineapalet")
        consulta.SelCampo(palets_traza.PLT_bultos, "bultos")
        consulta.SelCampo(palets_traza.PLT_IdLineaEntrada, "idlineaentrada")
        consulta.SelCampo(palets_traza.PLT_idlote, "idlote")
        consulta.SelCampo(palets_traza.PLT_idprecalibrado, "idprecalibrado")
        consulta.SelCampo(palets_traza.PLT_kilos, "kilos")
        consulta.SelCampo(palets_linea.PLL_idpalet, "idpalet", palets_traza.PLT_idlineapalet)
        consulta.SelCampo(albsalida_palets.ASP_IdAlbaran, "idalbaran", palets_linea.PLL_idpalet, albsalida_palets.ASP_Idpalet)
        consulta.WheCampo(albsalida_palets.ASP_IdAlbaran, "=", idalbaran.ToString)
        consulta.WheCampo(palets_traza.PLT_idprogramacliente, "=", "0")
        sql = consulta.SQL
        sql = sql + " order by idlineapalet"



        dt = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            Dim idlineapalet_aux As Integer = 0
            For Each rw In dt.Rows
                Dim idlineapalet As Integer = VaInt(rw("idlineapalet"))
                If idlineapalet <> idlineapalet_aux Then
                    sql = "Delete from palets_Traza where plt_idlineapalet=" + idlineapalet.ToString + " and PLT_idprogramacliente<>0"
                    Me.MiConexion.OrdenSql(sql)
                End If
                idlineapalet_aux = idlineapalet
                Dim idlineaentrada As Integer = VaInt(rw("idlineaentrada"))
                Dim idlote As Integer = VaInt(rw("idlote"))
                Dim idprecalibrado As Integer = VaInt(rw("idprecalibrado"))
                Dim kilos As Decimal = VaDec(rw("kilos"))
                Dim bultos As Decimal = VaDec(rw("bultos"))



                For Each programa In listaprogramas

                    Dim id As Integer = palets_traza.MaxId
                    palets_traza.VaciaEntidad()
                    palets_traza.PLT_idtraza.Valor = id.ToString
                    palets_traza.PLT_bultos.Valor = bultos.ToString
                    palets_traza.PLT_IdLineaEntrada.Valor = idlineaentrada.ToString
                    palets_traza.PLT_idlineapalet.Valor = idlineapalet.ToString
                    palets_traza.PLT_idlote.Valor = idlote.ToString
                    palets_traza.PLT_idprecalibrado.Valor = idprecalibrado.ToString
                    palets_traza.PLT_kilos.Valor = kilos.ToString
                    palets_traza.PLT_idprogramacliente.Valor = programa.ToString
                    palets_traza.Insertar()

                Next
            Next

        End If
    End Sub

End Class
