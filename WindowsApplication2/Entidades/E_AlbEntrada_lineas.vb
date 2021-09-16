Public Class E_AlbEntrada_lineas
    Inherits Cdatos.Entidad


    Public AEL_idlinea As Cdatos.bdcampo
    Public AEL_idalbaran As Cdatos.bdcampo
    Public AEL_idgenero As Cdatos.bdcampo
    Public AEL_idenvase As Cdatos.bdcampo
    Public AEL_idpalet As Cdatos.bdcampo
    Public AEL_kilosbrutos As Cdatos.bdcampo
    Public AEL_tara As Cdatos.bdcampo
    Public AEL_kilosnetos As Cdatos.bdcampo
    Public AEL_palets As Cdatos.bdcampo
    Public AEL_bultos As Cdatos.bdcampo
    Public AEL_idcultivo As Cdatos.bdcampo
    Public AEL_idcategoria As Cdatos.bdcampo
    Public AEL_albaran As Cdatos.bdcampo
    Public AEL_linea As Cdatos.bdcampo
    Public AEL_tarapalet As Cdatos.bdcampo
    Public AEL_taraenvase As Cdatos.bdcampo
    Public AEL_taraporce As Cdatos.bdcampo
    Public AEL_piezas As Cdatos.bdcampo
    Public AEL_tipoprecio As Cdatos.bdcampo
    Public AEL_precio As Cdatos.bdcampo
    Public AEL_precioenvase As Cdatos.bdcampo
    Public AEL_preciopalet As Cdatos.bdcampo
    Public AEL_observaciones As Cdatos.bdcampo
    Public AEL_muestreo As Cdatos.bdcampo
    Public AEL_taramanual As Cdatos.bdcampo
    Public AEL_fechamuestreo As Cdatos.bdcampo
    Public AEL_idprograma As Cdatos.bdcampo
    Public AEL_idtipoconfeccion As Cdatos.bdcampo
    Public AEL_idtipopalet As Cdatos.bdcampo
    Public AEL_idmarca As Cdatos.bdcampo
    Public AEL_envasepropio As Cdatos.bdcampo
    Public AEL_idgensal As Cdatos.bdcampo
    Public AEL_materialpropio As Cdatos.bdcampo
    Public AEL_IdPedidoLinea As Cdatos.bdcampo
    Public AEL_IdMarcaEtiqueta As Cdatos.bdcampo
    Public AEL_IdMarcaMaterial As Cdatos.bdcampo
    Public AEL_Calidad As Cdatos.bdcampo
    Public AEL_BultosxPalet As Cdatos.bdcampo
    Public AEL_KilosxBulto As Cdatos.bdcampo
    Public AEL_PiezasxBulto As Cdatos.bdcampo
    Public AEL_KilosCliente As Cdatos.bdcampo
    Public AEL_IdUbicacionPV As Cdatos.bdcampo
    Public AEL_campacultivo As Cdatos.bdcampo
    Public AEL_Controlado As Cdatos.bdcampo
    Public AEL_ObservacionesProveedor As Cdatos.bdcampo

    Public AEL_IdValoracion As Cdatos.bdcampo
    Public AEL_FechaValoracion As Cdatos.bdcampo
    Public AEL_Idparte As Cdatos.bdcampo

    Public AEL_RevisadaWeb As Cdatos.bdcampo
    Public AEL_ControlPresuntivoMP As Cdatos.bdcampo

    Public AEL_Color As Cdatos.bdcampo


    Public AEL_IdUsuarioLog As Cdatos.bdcampo
    Public AEL_FechaLog As Cdatos.bdcampo
    Public AEL_HoraLog As Cdatos.bdcampo



    Public BtBuscaPar As BtBusca

    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Dim Albentrada As New E_AlbEntrada(idUsuario, cn)
        Dim Generos As New E_Generos(idUsuario, cn)
        Dim Envases As New E_Envases(idUsuario, cn)
        Dim Agricultor As New E_Agricultores(idUsuario, cn)


        Dim Categoria As New E_CategoriasEntrada(idUsuario, cn)

        Try
            NombreTabla = "AlbEntrada_lineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            AEL_idlinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            AEL_idalbaran = New Cdatos.bdcampo(CodigoEntidad & "idalbaran", Cdatos.TiposCampo.EnteroPositivo, 6)
            AEL_idgenero = New Cdatos.bdcampo(CodigoEntidad & "idgenero", Cdatos.TiposCampo.EnteroPositivo, 5)
            AEL_idenvase = New Cdatos.bdcampo(CodigoEntidad & "idenvase", Cdatos.TiposCampo.EnteroPositivo, 5)
            AEL_idpalet = New Cdatos.bdcampo(CodigoEntidad & "idpalet", Cdatos.TiposCampo.EnteroPositivo, 5)
            AEL_kilosbrutos = New Cdatos.bdcampo(CodigoEntidad & "kilosbrutos", Cdatos.TiposCampo.Importe, 18, 2)
            AEL_kilosnetos = New Cdatos.bdcampo(CodigoEntidad & "kilosnetos", Cdatos.TiposCampo.Importe, 18, 2)
            AEL_palets = New Cdatos.bdcampo(CodigoEntidad & "palets", Cdatos.TiposCampo.Entero, 6)
            AEL_bultos = New Cdatos.bdcampo(CodigoEntidad & "bultos", Cdatos.TiposCampo.Entero, 6)
            AEL_idcultivo = New Cdatos.bdcampo(CodigoEntidad & "idcultivo", Cdatos.TiposCampo.Entero, 5)
            AEL_idcategoria = New Cdatos.bdcampo(CodigoEntidad & "idcategoria", Cdatos.TiposCampo.EnteroPositivo, 4)
            AEL_albaran = New Cdatos.bdcampo(CodigoEntidad & "albaran", Cdatos.TiposCampo.Entero, 6)
            AEL_linea = New Cdatos.bdcampo(CodigoEntidad & "linea", Cdatos.TiposCampo.Entero, 2)
            AEL_tarapalet = New Cdatos.bdcampo(CodigoEntidad & "tarapalet", Cdatos.TiposCampo.Importe, 6, 2)
            AEL_taraenvase = New Cdatos.bdcampo(CodigoEntidad & "taraenvase", Cdatos.TiposCampo.Importe, 6, 2)
            AEL_taraporce = New Cdatos.bdcampo(CodigoEntidad & "taraporce", Cdatos.TiposCampo.Importe, 6, 2)
            AEL_piezas = New Cdatos.bdcampo(CodigoEntidad & "piezas", Cdatos.TiposCampo.Entero, 6)
            AEL_tipoprecio = New Cdatos.bdcampo(CodigoEntidad & "tipoprecio", Cdatos.TiposCampo.Cadena, 1)
            AEL_precio = New Cdatos.bdcampo(CodigoEntidad & "precio", Cdatos.TiposCampo.Importe, 6, 4)
            AEL_precioenvase = New Cdatos.bdcampo(CodigoEntidad & "precioenvase", Cdatos.TiposCampo.Importe, 6, 4)
            AEL_preciopalet = New Cdatos.bdcampo(CodigoEntidad & "preciopalet", Cdatos.TiposCampo.Importe, 6, 4)
            AEL_observaciones = New Cdatos.bdcampo(CodigoEntidad & "observaciones", Cdatos.TiposCampo.Cadena, 50)
            AEL_muestreo = New Cdatos.bdcampo(CodigoEntidad & "muestreo", Cdatos.TiposCampo.EnteroPositivo, 10)
            AEL_taramanual = New Cdatos.bdcampo(CodigoEntidad & "taramanual", Cdatos.TiposCampo.Importe, 6, 2)
            AEL_fechamuestreo = New Cdatos.bdcampo(CodigoEntidad & "fechamuestreo", Cdatos.TiposCampo.Fecha, 10)
            AEL_idprograma = New Cdatos.bdcampo(CodigoEntidad & "idprograma", Cdatos.TiposCampo.EnteroPositivo, 4)
            AEL_idtipoconfeccion = New Cdatos.bdcampo(CodigoEntidad & "idtipoconfeccion", Cdatos.TiposCampo.EnteroPositivo, 7)
            AEL_idtipopalet = New Cdatos.bdcampo(CodigoEntidad & "idtipopalet", Cdatos.TiposCampo.EnteroPositivo, 7)
            AEL_idmarca = New Cdatos.bdcampo(CodigoEntidad & "idmarca", Cdatos.TiposCampo.EnteroPositivo, 4)
            AEL_envasepropio = New Cdatos.bdcampo(CodigoEntidad & "envasepropio", Cdatos.TiposCampo.Cadena, 1)
            AEL_idgensal = New Cdatos.bdcampo(CodigoEntidad & "idgensal", Cdatos.TiposCampo.EnteroPositivo, 5)
            AEL_materialpropio = New Cdatos.bdcampo(CodigoEntidad & "materialpropio", Cdatos.TiposCampo.Cadena, 1)
            AEL_IdPedidoLinea = New Cdatos.bdcampo(CodigoEntidad & "IdPedidoLinea", Cdatos.TiposCampo.EnteroPositivo, 10)
            AEL_IdMarcaEtiqueta = New Cdatos.bdcampo(CodigoEntidad & "IdMarcaEtiqueta", Cdatos.TiposCampo.EnteroPositivo, 4)
            AEL_IdMarcaMaterial = New Cdatos.bdcampo(CodigoEntidad & "IdMarcaMaterial", Cdatos.TiposCampo.EnteroPositivo, 4)
            AEL_Calidad = New Cdatos.bdcampo(CodigoEntidad & "Calidad", Cdatos.TiposCampo.Cadena, 1)
            AEL_BultosxPalet = New Cdatos.bdcampo(CodigoEntidad & "BultosxPalet", Cdatos.TiposCampo.Entero, 4)
            AEL_KilosxBulto = New Cdatos.bdcampo(CodigoEntidad & "KilosxBulto", Cdatos.TiposCampo.Importe, 5, 2)
            AEL_PiezasxBulto = New Cdatos.bdcampo(CodigoEntidad & "PiezasxBulto", Cdatos.TiposCampo.Entero, 4)
            AEL_KilosCliente = New Cdatos.bdcampo(CodigoEntidad & "KilosCliente", Cdatos.TiposCampo.Importe, 18, 2)
            AEL_IdUbicacionPV = New Cdatos.bdcampo(CodigoEntidad & "IdUbicacionPV", Cdatos.TiposCampo.EnteroPositivo, 3)
            AEL_campacultivo = New Cdatos.bdcampo(CodigoEntidad & "campacultivo", Cdatos.TiposCampo.Entero, 2)
            AEL_Controlado = New Cdatos.bdcampo(CodigoEntidad & "Controlado", Cdatos.TiposCampo.Cadena, 1)
            AEL_ObservacionesProveedor = New Cdatos.bdcampo(CodigoEntidad & "ObservacionesProveedor", Cdatos.TiposCampo.Cadena, 50)
            AEL_IdValoracion = New Cdatos.bdcampo(CodigoEntidad & "IdValoracion", Cdatos.TiposCampo.EnteroPositivo, 10, 0)
            AEL_FechaValoracion = New Cdatos.bdcampo(CodigoEntidad & "FechaValoracion", Cdatos.TiposCampo.Fecha, 10)
            AEL_Idparte = New Cdatos.bdcampo(CodigoEntidad & "Idparte", Cdatos.TiposCampo.EnteroPositivo, 6)
            AEL_RevisadaWeb = New Cdatos.bdcampo(CodigoEntidad & "RevisadaWeb", Cdatos.TiposCampo.Cadena, 1)
            AEL_ControlPresuntivoMP = New Cdatos.bdcampo(CodigoEntidad & "ControlPresuntivoMP", Cdatos.TiposCampo.Entero, 1)

            AEL_Color = New Cdatos.bdcampo(CodigoEntidad & "Color", Cdatos.TiposCampo.Cadena, 1)


            AEL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            AEL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            AEL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.AEL_muestreo)

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try



        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.AEL_idlinea, "idlinea")
        consulta.SelCampo(Albentrada.AEN_Albaran, "Albaran", Me.AEL_idalbaran)
        consulta.SelCampo(Albentrada.AEN_Fecha, "Fecha")
        consulta.SelCampo(Me.AEL_idgenero, "Codigo")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Me.AEL_idgenero)
        consulta.SelCampo(Me.AEL_muestreo, "Partida")
        consulta.SelCampo(Me.AEL_kilosnetos, "Kilos")
        consulta.SelCampo(Albentrada.AEN_TipoFCS, "Tipo")
        consulta.SelCampo(Albentrada.AEN_IdPuntoVenta, "PV")
 


        _btBusca.Params("Idlinea", , -1)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Me.AEL_idgenero
        _btBusca.CL_camponombre = Generos.GEN_NombreGenero
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio

        _btBusca.CL_CampoOrden = "Fecha"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Partida"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaPartidas"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing
        _btBusca.CL_xCentro = False
        _btBusca.CL_EsId = False





        Dim consulta2 As New Cdatos.E_select
        consulta2.SelCampo(Me.AEL_idlinea, "idlinea")
        consulta2.SelCampo(Me.AEL_muestreo, "Partida")
        consulta2.SelCampo(Albentrada.AEN_Albaran, "Albaran", Me.AEL_idalbaran)
        consulta2.SelCampo(Albentrada.AEN_TipoFCS, "Tipo")
        consulta2.SelCampo(Albentrada.AEN_Fecha, "Fecha")
        consulta2.SelCampo(Albentrada.AEN_IdAgricultor, "Codigo")
        consulta2.SelCampo(Agricultor.AGR_Nombre, "Agricultor", Albentrada.AEN_IdAgricultor)
        consulta2.SelCampo(Generos.GEN_NombreGenero, "Genero", Me.AEL_idgenero)
        consulta2.SelCampo(Me.AEL_kilosnetos, "Kilos")
        consulta2.SelCampo(Me.AEL_fechamuestreo, "FechaMuestreo")

        'en la consulta tiene que haber un campo que se llame codigo,y otro fecha


        BtBuscaPar = New BtBusca
        BtBuscaPar.Image = Global.NetAgro.My.Resources.Lupa16_
        BtBuscaPar.Location = New System.Drawing.Point(134, 303)
        BtBuscaPar.Size = New System.Drawing.Size(33, 23)
        BtBuscaPar.UseVisualStyleBackColor = True


        BtBuscaPar.CL_BuscaAlb = True ' busqueda por codigo
        BtBuscaPar.CL_campocodigo = Agricultor.AGR_IdAgricultor
        BtBuscaPar.CL_camponombre = Agricultor.AGR_Nombre
        BtBuscaPar.CL_dfecha = MiMaletin.FechaInicioEjercicio
        BtBuscaPar.CL_hfecha = MiMaletin.FechaFinEjercicio

        '_btBusca.CL_CampoOrden = "Agricultor"
        BtBuscaPar.CL_CampoOrden = "Codigo"
        BtBuscaPar.CL_ConsultaSql = consulta2.SQL
        BtBuscaPar.CL_ControlAsociado = Nothing
        BtBuscaPar.CL_DevuelveCampo = "Idlinea"
        BtBuscaPar.CL_Entidad = Me
        BtBuscaPar.CL_Filtro = Nothing
        BtBuscaPar.Name = "BtBuscaPartidas"
        BtBuscaPar.CL_ch1000 = False
        BtBuscaPar.cl_formu = Nothing


        BtBuscaPar.ParamConsultaAlb(consulta2, "AEN_IdAgricultor", Albentrada.AEN_IdAgricultor, Albentrada.AEN_Fecha, Albentrada.AEN_IdCentro)



    End Sub

    Private Sub E_AlbEntrada_lineas_ActualizaHijos(nuevo As Boolean) Handles Me.ActualizaHijos

    End Sub

  


    Private Sub E_AlbEntrada_lineas_EliminaHijos() Handles Me.EliminaHijos

        Dim sql As String
        sql = "Delete from albentrada_lineascla where ALC_idlineaentrada=" + AEL_idlinea.Valor
        Me.MiConexion.OrdenSql(sql)

        sql = "Delete from albentrada_lineaskilos where ALK_idlineaentrada=" + AEL_idlinea.Valor
        Me.MiConexion.OrdenSql(sql)



    End Sub


    Public Function LeerMuestreo(ByVal Campa As String, ByVal Muestreo As String) As Integer

        Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
        Dim consulta As New Cdatos.E_select
        Dim dT As New DataTable
        Dim RET As Integer
        consulta.SelCampo(Me.AEL_idlinea)
        consulta.SelCampo(Albentrada.AEN_Campa, "campa", Me.AEL_idalbaran)
        consulta.WheCampo(Me.AEL_muestreo, "=", Muestreo)
        consulta.WheCampo(Albentrada.AEN_Campa, "=", Campa)
        dT = Me.MiConexion.ConsultaSQL(consulta.SQL)
        If Not dT Is Nothing Then
            If dT.Rows.Count > 0 Then
                RET = dT.Rows(0)(0)
            End If
        End If
        Return RET
    End Function

    Public Function DatosPartida(ByVal Campa As String, ByVal Muestreo As String, ByRef idAgricultor As String, ByRef idGenero As String, ByRef IdCategoria As String, ByRef kilos As String) As Integer

        Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
        Dim consulta As New Cdatos.E_select
        Dim dT As New DataTable
        Dim RET As Integer
        idAgricultor = ""
        idGenero = ""
        IdCategoria = ""
        kilos = ""

        consulta.SelCampo(Me.AEL_idlinea)
        consulta.SelCampo(Me.AEL_idgenero, "idgenero")
        consulta.SelCampo(Me.AEL_kilosnetos, "kilos")
        consulta.SelCampo(Me.AEL_idcategoria, "idcategoria")
        consulta.SelCampo(Albentrada.AEN_Campa, "campa", Me.AEL_idalbaran)
        consulta.SelCampo(Albentrada.AEN_IdAgricultor, "IdAgricultor")
        consulta.WheCampo(Me.AEL_muestreo, "=", Muestreo)
        consulta.WheCampo(Albentrada.AEN_Campa, "=", Campa)
        dT = Me.MiConexion.ConsultaSQL(consulta.SQL)
        If Not dT Is Nothing Then
            If dT.Rows.Count > 0 Then
                RET = dT.Rows(0)(0)
                idAgricultor = dT.Rows(0)("idagricultor").ToString
                idGenero = dT.Rows(0)("idgenero").ToString
                IdCategoria = dT.Rows(0)("idcategoria").ToString
                kilos = dT.Rows(0)("kilos").ToString

            End If
        End If
        Return RET
    End Function


    Public Function LineasMuestreadas(ByVal IdAlba As String) As Boolean
        Dim consulta As New Cdatos.E_select
        Dim dT As New DataTable
        Dim RET As Boolean
        consulta.SelCampo(Me.AEL_idlinea)
        consulta.WheCampo(Me.AEL_idalbaran, "=", IdAlba)
        consulta.WheCampo(Me.AEL_fechamuestreo, "<>", "01/01/1900")
        dT = Me.MiConexion.ConsultaSQL(consulta.SQL)
        If Not dT Is Nothing Then
            If dT.Rows.Count > 0 Then
                RET = True
            End If
        End If
        Return RET


    End Function

    Public Function TodasLineasMuestreadas(ByVal IdAlba As String) As Boolean

        Dim bRes As Boolean = True

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.AEL_idlinea)
        consulta.SelCampo(Me.AEL_fechamuestreo, "FechaMuestreo")
        consulta.WheCampo(Me.AEL_idalbaran, "=", IdAlba)

        Dim dt As DataTable = MiConexion.ConsultaSQL(consulta.SQL)

        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows
                If VaDate(row("FechaMuestreo")) <= VaDate("") Then
                    bRes = False
                End If
            Next
        Else
            bRes = False
        End If


        Return bRes

    End Function



    Public Function ActualizaPartida(Campa As String, Partida As String, idlineaentrada As String) As String

        Dim muestreo As String = Partida

        If VaInt(Partida) = 0 Then ' la linea no tiene numero de partida
            muestreo = Me.MaxIdPartida(VaInt(Campa))
            Dim sql As String = "update albentrada_lineas set AEL_muestreo=" + muestreo.ToString + " where AEL_idlinea=" + idlineaentrada
            Me.MiConexion.OrdenSql(sql)

        End If
        Return muestreo
    End Function


    



    Public Function MaxIdPartida(ByVal Campa As Integer, Optional ByVal vmax As Integer = 0) As Integer
        Dim N As String = ""
        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                max = ValorMaximo(Campa.ToString, vmax)
                N = max.ToString
                existe = LeerMuestreo(Campa.ToString, N)
            End While

            Return VaInt(N)
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de ", "Function MaxIdMartida", ex.Message)
            Return 0
        End Try


    End Function



End Class
