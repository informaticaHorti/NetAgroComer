Public Class E_palets
    Inherits Cdatos.Entidad

    Public PAL_idpalet As Cdatos.bdcampo
    Public PAL_campa As Cdatos.bdcampo
    Public PAL_idcentro As Cdatos.bdcampo
    Public PAL_palet As Cdatos.bdcampo
    Public PAL_fecha As Cdatos.bdcampo
    Public PAL_idpuntoventa As Cdatos.bdcampo
    Public PAL_idtipopalet As Cdatos.bdcampo
    Public PAL_tarapalet As Cdatos.bdcampo
    Public PAL_idpvsituacion As Cdatos.bdcampo
    Public PAL_envasepropio As Cdatos.bdcampo
    Public PAL_materialpropio As Cdatos.bdcampo
    Public PAL_idclientepedido As Cdatos.bdcampo
    Public PAL_idpedido As Cdatos.bdcampo
    Public PAL_finalizado As Cdatos.bdcampo
    Public PAL_Lote As Cdatos.bdcampo
    Public PAL_GGN1 As Cdatos.bdcampo
    Public PAL_GGN2 As Cdatos.bdcampo
    Public PAL_GGN3 As Cdatos.bdcampo
    Public PAL_GGN4 As Cdatos.bdcampo
    Public PAL_HoraConfeccion As Cdatos.bdcampo
    Public PAL_IdUsuario As Cdatos.bdcampo
    Public PAL_IdOperario As Cdatos.bdcampo

    Public PAL_PaletsTransporte As Cdatos.bdcampo           'Campo que se usa sólo para el PowerBi de Manolo

    Public PAL_SufijoGGN1 As Cdatos.bdcampo
    Public PAL_SufijoGGN2 As Cdatos.bdcampo
    Public PAL_SufijoGGN3 As Cdatos.bdcampo
    Public PAL_SufijoGGN4 As Cdatos.bdcampo

    Public PAL_IdUsuarioLog As Cdatos.bdcampo
    Public PAL_FechaLog As Cdatos.bdcampo
    Public PAL_HoraLog As Cdatos.bdcampo





    Structure KlCoste
        Dim idmaterial As Integer
        Dim idmarca As Integer

    End Structure

    Dim DcCoste As New Dictionary(Of KlCoste, Double)


    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "palets"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            PAL_idpalet = New Cdatos.bdcampo(CodigoEntidad & "idpalet", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            PAL_campa = New Cdatos.bdcampo(CodigoEntidad & "campa", Cdatos.TiposCampo.EnteroPositivo, 2)
            PAL_idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.EnteroPositivo, 2)
            PAL_palet = New Cdatos.bdcampo(CodigoEntidad & "palet", Cdatos.TiposCampo.EnteroPositivo, 6)
            PAL_fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 10)
            PAL_idpuntoventa = New Cdatos.bdcampo(CodigoEntidad & "idpuntoventa", Cdatos.TiposCampo.EnteroPositivo, 3)
            PAL_idtipopalet = New Cdatos.bdcampo(CodigoEntidad & "idtipopalet", Cdatos.TiposCampo.EnteroPositivo, 4)
            PAL_tarapalet = New Cdatos.bdcampo(CodigoEntidad & "tarapalet", Cdatos.TiposCampo.Importe, 6, 2)
            PAL_idpvsituacion = New Cdatos.bdcampo(CodigoEntidad & "idpvsituacion", Cdatos.TiposCampo.EnteroPositivo, 3)
            PAL_envasepropio = New Cdatos.bdcampo(CodigoEntidad & "envasepropio", Cdatos.TiposCampo.Cadena, 1)
            PAL_idclientepedido = New Cdatos.bdcampo(CodigoEntidad & "Idclientepedido", Cdatos.TiposCampo.EnteroPositivo, 5)
            PAL_idpedido = New Cdatos.bdcampo(CodigoEntidad & "Idpedido", Cdatos.TiposCampo.EnteroPositivo, 5)
            PAL_materialpropio = New Cdatos.bdcampo(CodigoEntidad & "materialpropio", Cdatos.TiposCampo.Cadena, 1)
            PAL_finalizado = New Cdatos.bdcampo(CodigoEntidad & "finalizado", Cdatos.TiposCampo.Cadena, 1)
            PAL_Lote = New Cdatos.bdcampo(CodigoEntidad & "Lote", Cdatos.TiposCampo.Cadena, 4)
            PAL_GGN1 = New Cdatos.bdcampo(CodigoEntidad & "GGN1", Cdatos.TiposCampo.Cadena, 20)
            PAL_GGN2 = New Cdatos.bdcampo(CodigoEntidad & "GGN2", Cdatos.TiposCampo.Cadena, 20)
            PAL_GGN3 = New Cdatos.bdcampo(CodigoEntidad & "GGN3", Cdatos.TiposCampo.Cadena, 20)
            PAL_GGN4 = New Cdatos.bdcampo(CodigoEntidad & "GGN4", Cdatos.TiposCampo.Cadena, 20)
            PAL_HoraConfeccion = New Cdatos.bdcampo(CodigoEntidad & "HoraConfeccion", Cdatos.TiposCampo.FechaHora, 19)
            PAL_IdUsuario = New Cdatos.bdcampo(CodigoEntidad & "IdUsuario", Cdatos.TiposCampo.Entero, 10)
            PAL_IdOperario = New Cdatos.bdcampo(CodigoEntidad & "IdOperario", Cdatos.TiposCampo.EnteroPositivo, 8)

            'Campo que se usa sólo para el PowerBi de Manolo
            PAL_PaletsTransporte = New Cdatos.bdcampo(CodigoEntidad & "PaletsTransporte", Cdatos.TiposCampo.Importe, 5, 2)

            PAL_SufijoGGN1 = New Cdatos.bdcampo(CodigoEntidad & "SufijoGGN1", Cdatos.TiposCampo.Cadena, 2)
            PAL_SufijoGGN2 = New Cdatos.bdcampo(CodigoEntidad & "SufijoGGN2", Cdatos.TiposCampo.Cadena, 2)
            PAL_SufijoGGN3 = New Cdatos.bdcampo(CodigoEntidad & "SufijoGGN3", Cdatos.TiposCampo.Cadena, 2)
            PAL_SufijoGGN4 = New Cdatos.bdcampo(CodigoEntidad & "SufijoGGN4", Cdatos.TiposCampo.Cadena, 2)

            PAL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PAL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PAL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.PAL_palet)


            Dim palets_lineas As New E_palets_lineas(idUsuario, cn)
            Dim Generos As New E_Generos(idUsuario, cn)
            Dim Confecpalet As New E_ConfecPalet(idUsuario, cn)
            Dim Confecenvase As New E_ConfecEnvase(idUsuario, cn)
            Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
            Dim Albsalida As New E_AlbSalida(idUsuario, cn)
            Dim Albsalida_palets As New E_albsalida_palets(idUsuario, cn)
            Dim GenerosSalida As New E_GenerosSalida(idUsuario, cn)

            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(palets_lineas.PLL_idlinea, "IdLinea")
            consulta.SelCampo(Me.PAL_palet, "Numero", palets_lineas.PLL_idpalet)
            consulta.SelCampo(Me.PAL_idpuntoventa, "PV")
            consulta.SelCampo(PuntoVenta.Nombre, "Pventa", Me.PAL_idpuntoventa)
            consulta.SelCampo(PAL_idcentro, "IdCentro")
            consulta.SelCampo(palets_lineas.PLL_idgenero, "Codigo")
            consulta.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", palets_lineas.PLL_idgensal, GenerosSalida.GES_Idgensal)
            'consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", palets_lineas.PLL_idgenero)
            'consulta.SelCampo(Confecenvase.CEV_Abreviatura, "TipoEnvase", palets_lineas.PLL_idtipoconfeccion)
            consulta.SelCampo(Me.PAL_idpalet, "IdPalet")
            consulta.SelCampo(Me.PAL_fecha, "Fecha")
            consulta.SelCampo(Confecpalet.CPA_Abreviatura, "TipoPalet", Me.PAL_idtipopalet)
            consulta.SelCampo(palets_lineas.PLL_bultos, "Bultos")
            consulta.SelCampo(palets_lineas.PLL_kilosnetos, "Kilos")
            consulta.SelCampo(palets_lineas.PLL_costematerial, "CosteMat")
            consulta.SelCampo(palets_lineas.PLL_costeconfeccion, "CosteConf")
            consulta.SelCampo(palets_lineas.PLL_costeestructura, "CosteEstr")
            consulta.SelCampo(Albsalida_palets.ASP_IdAlbaran, "idalbaran", Me.PAL_idpalet, Albsalida_palets.ASP_Idpalet)
            consulta.SelCampo(Albsalida.ASA_albaran, "Albaran", Albsalida_palets.ASP_IdAlbaran)
            Dim sql As String = consulta.SQL & vbCrLf

            _btBusca.Params("IdLinea", , -1)
            _btBusca.Params("IdPalet", , -1)
            _btBusca.Params("IdCentro", , -1)
            _btBusca.Params("PV", , -1)
            _btBusca.Params("idalbaran", , -1)
            _btBusca.Params("Albaran", , 80)
            _btBusca.Params("Bultos", , 60, True, "#,##0")
            _btBusca.Params("Kilos", , 70, True, "#,##0.00")
            _btBusca.Params("CosteMat", , 70, True, "#,##0.00")
            _btBusca.Params("CosteConf", , 70, True, "#,##0.00")
            _btBusca.Params("CosteEstr", , 70, True, "#,##0.00")



            _btBusca.CL_BuscaAlb = True ' busqueda por codigo
            _btBusca.CL_campocodigo = Generos.GEN_IdGenero
            _btBusca.CL_camponombre = Generos.GEN_NombreGenero
            _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
            _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio

            '_btBusca.CL_CampoOrden = "Palet DESC"
            _btBusca.CL_ConsultaSql = sql
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "IdPalet"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.Name = "BtBuscaPalets"
            _btBusca.CL_ch1000 = False
            _btBusca.cl_formu = Nothing
            _btBusca.CL_xCentro = True


            _btBusca.ParamConsultaAlb(consulta, "PAL_Palet DESC", palets_lineas.PLL_idgenero, Me.PAL_fecha, Me.PAL_idcentro)


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub

    Public Function Leerpalet(ByVal Campa As Integer, Centro As Integer, ByVal numpalet As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.PAL_campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.PAL_idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.PAL_palet, "=", numpalet.ToString)

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


    Public Function ExistePalet(ByVal Campa As Integer, Centro As Integer, ByVal numpalet As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.PAL_campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.PAL_idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.PAL_palet, "=", numpalet.ToString)

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


    Public Function MaxIdCampa(ByVal Campa As Integer, Centro As Integer, Optional ByVal vmax As Integer = 0) As Integer
        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                If ContadorxCentro = True Then
                    max = ValorMaximo(Campa.ToString + "_" + Centro.ToString, vmax)
                Else
                    max = ValorMaximo(Campa.ToString, vmax)
                End If
                existe = ExistePalet(Campa, Centro, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de palet", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function

    Private Sub E_palets_ActualizaHijos(ByVal nuevo As Boolean) Handles Me.ActualizaHijos
        CreaCostes(Me.PAL_idpalet.Valor)
    End Sub



    Private Sub E_palets_EliminaHijos() Handles Me.EliminaHijos
        Dim sql As String
        Dim dt As New DataTable
        Dim palets_lineas As New E_palets_lineas(Idusuario, cn)

        sql = "select * from palets_lineas where PLL_idpalet=" + Me.PAL_idpalet.Valor

        dt = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw As DataRow In dt.Rows
                palets_lineas.CargaCampos(rw)
                palets_lineas.Eliminar()
            Next
        End If






    End Sub

    Private Sub CreaCostes(ByVal idpalet As String)
        Dim palets_lineas As New E_palets_lineas(Idusuario, cn)



        If Me.LeerId(idpalet) = True Then


            Dim Gtoconf As Double = 0
            Dim GtoMat As Double = 0
            Dim GtoEstr As Double = 0


            Dim consulta3 As New Cdatos.E_select
            consulta3.SelCampo(palets_lineas.PLL_idlinea)
            consulta3.WheCampo(palets_lineas.PLL_idpalet, "=", idpalet)


            Dim dt3 As DataTable = Me.MiConexion.ConsultaSQL(consulta3.SQL)
            If Not dt3 Is Nothing Then
                For Each rw In dt3.Rows
                    AGRO_GastosLineaPalet(rw("pll_idlinea").ToString, Gtoconf, GtoMat, GtoEstr, True, 0)
                Next
            End If


        End If
    End Sub

    Private Sub AcumulaMaterial(ByVal idmaterial As Integer, ByVal idmarca As Integer, ByVal Cantidad As Double)

    End Sub


End Class
