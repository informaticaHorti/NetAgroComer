Public Class E_AlbEntrada
    Inherits Cdatos.Entidad


    Public AEN_IdAlbaran As Cdatos.bdcampo
    Public AEN_Campa As Cdatos.bdcampo
    Public AEN_Albaran As Cdatos.bdcampo
    Public AEN_IdAgricultor As Cdatos.bdcampo
    Public AEN_Fecha As Cdatos.bdcampo
    Public AEN_IdPuntoVenta As Cdatos.bdcampo
    Public AEN_IdCentro As Cdatos.bdcampo
    Public AEN_IdRecogida As Cdatos.bdcampo
    Public AEN_IdGastoPorte As Cdatos.bdcampo
    Public AEN_DtoKg As Cdatos.bdcampo
    Public AEN_TipoEntrada As Cdatos.bdcampo
    Public AEN_TipoFCS As Cdatos.bdcampo
    Public AEN_FechaHora As Cdatos.bdcampo
    Public AEN_IdValeEnvase As Cdatos.bdcampo
    Public AEN_EntradaConfeccionada As Cdatos.bdcampo
    Public AEN_referencia As Cdatos.bdcampo
    Public AEN_idbascula As Cdatos.bdcampo
    Public AEN_fechavaloracion As Cdatos.bdcampo
    Public AEN_matricula As Cdatos.bdcampo
    Public AEN_IdMedianeria As Cdatos.bdcampo
    Public AEN_IdTransportista As Cdatos.bdcampo
    Public AEN_HoraEntrada As Cdatos.bdcampo

    Public AEN_LocalizadorDAT As Cdatos.bdcampo

    Public AEN_IdUsuarioLog As Cdatos.bdcampo
    Public AEN_FechaLog As Cdatos.bdcampo
    Public AEN_HoraLog As Cdatos.bdcampo



    Private ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    Private ValeEnvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)


   

    Private Class stClaves_ValeEnvase

        Public IdMaterial As Integer = 0
        Public IdMarca As Integer = 0
        Public EsPropio As String = "S"

        Public Sub New(ByVal IdMaterial As Integer, ByVal IdMarca As Integer, ByVal Espropio As String)
            Me.IdMaterial = IdMaterial
            Me.IdMarca = IdMarca
            Me.EsPropio = Espropio
        End Sub

    End Class

    Private Class stDatos_ValeEnvase

        Public Cantidad As Double = 0

        Public Sub New(ByVal Cantidad As Double)
            Me.Cantidad = Cantidad
        End Sub

    End Class

    Dim ACEnvases As New Acumulador

    Dim err As Errores




    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Dim Agricultor As New E_Agricultores(idUsuario, cn)
        Dim Centro As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim Gastos As New E_TiposdeGastoAgri(idUsuario, cn)
        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))

        Try
            NombreTabla = "AlbEntrada"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            AEN_IdAlbaran = New Cdatos.bdcampo(CodigoEntidad & "idalbaran", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            AEN_Campa = New Cdatos.bdcampo(CodigoEntidad & "campa", Cdatos.TiposCampo.EnteroPositivo, 2)
            AEN_Albaran = New Cdatos.bdcampo(CodigoEntidad & "albaran", Cdatos.TiposCampo.EnteroPositivo, 6)
            AEN_IdAgricultor = New Cdatos.bdcampo(CodigoEntidad & "idagricultor", Cdatos.TiposCampo.EnteroPositivo, 5, 0, False, Agricultor, Agricultor.AGR_IdAgricultor, Agricultor.AGR_Nombre)
            AEN_Fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 10)
            AEN_IdPuntoVenta = New Cdatos.bdcampo(CodigoEntidad & "idpuntoventa", Cdatos.TiposCampo.EnteroPositivo, 3, 0, False, PuntoVenta, PuntoVenta.IdPuntoVenta, PuntoVenta.Nombre)
            AEN_IdCentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.EnteroPositivo, 2, 0, False, Centro, Centro.IdCentro, Centro.Nombre)
            AEN_IdGastoPorte = New Cdatos.bdcampo(CodigoEntidad & "idgastoporte", Cdatos.TiposCampo.EnteroPositivo, 3, 0, False, Gastos, Gastos.TGA_Idtipogasto, Gastos.TGA_Nombre)
            AEN_DtoKg = New Cdatos.bdcampo(CodigoEntidad & "dtokg", Cdatos.TiposCampo.Importe, 6, 4)
            AEN_TipoEntrada = New Cdatos.bdcampo(CodigoEntidad & "tipoentrada", Cdatos.TiposCampo.Cadena, 2)
            AEN_TipoFCS = New Cdatos.bdcampo(CodigoEntidad & "tipofcs", Cdatos.TiposCampo.Cadena, 1)
            AEN_IdRecogida = New Cdatos.bdcampo(CodigoEntidad & "idrecogida", Cdatos.TiposCampo.EnteroPositivo, 4)
            AEN_FechaHora = New Cdatos.bdcampo(CodigoEntidad & "fechahora", Cdatos.TiposCampo.Fecha, 15)
            AEN_IdValeEnvase = New Cdatos.bdcampo(CodigoEntidad & "idvaleenvase", Cdatos.TiposCampo.EnteroPositivo, 4)
            AEN_EntradaConfeccionada = New Cdatos.bdcampo(CodigoEntidad & "entradaconfeccionada", Cdatos.TiposCampo.Cadena, 1)
            AEN_referencia = New Cdatos.bdcampo(CodigoEntidad & "referencia", Cdatos.TiposCampo.Cadena, 10)
            AEN_idbascula = New Cdatos.bdcampo(CodigoEntidad & "idbascula", Cdatos.TiposCampo.EnteroPositivo, 4)
            AEN_fechavaloracion = New Cdatos.bdcampo(CodigoEntidad & "fechavaloracion", Cdatos.TiposCampo.Fecha, 10)
            AEN_matricula = New Cdatos.bdcampo(CodigoEntidad & "matricula", Cdatos.TiposCampo.Cadena, 15)
            AEN_IdMedianeria = New Cdatos.bdcampo(CodigoEntidad & "idmedianeria", Cdatos.TiposCampo.EnteroPositivo, 5)
            AEN_IdTransportista = New Cdatos.bdcampo(CodigoEntidad & "IdTransportista", Cdatos.TiposCampo.EnteroPositivo, 5)
            AEN_HoraEntrada = New Cdatos.bdcampo(CodigoEntidad & "HoraEntrada", Cdatos.TiposCampo.Cadena, 8)

            AEN_LocalizadorDAT = New Cdatos.bdcampo(CodigoEntidad & "LocalizadorDAT", Cdatos.TiposCampo.Cadena, 15)

            AEN_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            AEN_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            AEN_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()


            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.AEN_Albaran)


            'Descripción de la tabla para la gestion documental
            _DescripcionDocumental = "Albaran Entrada"


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.AEN_IdAlbaran, "IdAlbaran")
        consulta.SelCampo(Me.AEN_Albaran, "Albaran")
        consulta.SelCampo(Me.AEN_TipoFCS, "FC")
        consulta.SelCampo(Me.AEN_IdCentro, "IdCentro")
        consulta.SelCampo(Me.AEN_Campa, "Campa")
        consulta.SelCampo(Centros.Nombre, "CE", Me.AEN_IdCentro, Centros.IdCentro)
        consulta.SelCampo(Me.AEN_Fecha, "Fecha")
        consulta.SelCampo(Me.AEN_IdPuntoVenta, "PV")
        consulta.SelCampo(Me.AEN_IdRecogida, "CR")
        consulta.SelCampo(Me.AEN_IdAgricultor, "codigo")
        consulta.SelCampo(Me.AEN_EntradaConfeccionada, "Directa")
        consulta.SelCampo(Agricultor.AGR_Nombre, "", Me.AEN_IdAgricultor, Agricultor.AGR_IdAgricultor)
        ' en la consulta tiene que haber un campo que se llame codigo,y otro fecha

        Dim sql As String = consulta.SQL & vbCrLf & " ORDER BY AEN_Fecha DESC"


        _btBusca.Params("IdAlbaran", , -1)
        _btBusca.Params("FC", , 25)
        _btBusca.Params("IdCentro", , -1)
        _btBusca.Params("PV", , -1)
        _btBusca.Params("Directa", , -1)
        _btBusca.Params("codigo", "Codigo", 60, , "00000")
        _btBusca.Params("AGR_Nombre", "Agricultor")

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Agricultor.AGR_IdAgricultor
        _btBusca.CL_camponombre = Agricultor.AGR_Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio

        '_btBusca.CL_CampoOrden = "Agricultor"
        '_btBusca.CL_CampoOrden = "Fecha DESC"
        _btBusca.CL_ConsultaSql = Sql
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdAlbaran"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaEnvases"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = Nothing
        _btBusca.CL_xCentro = True


        _btBusca.ParamConsultaAlb(consulta, "AEN_Fecha DESC", Me.AEN_IdAgricultor, Me.AEN_Fecha, Me.AEN_IdCentro)



       



    End Sub


    Private Sub BuscaPartidas()
    End Sub


    Public Function LeerAlb(ByVal Campa As Integer, ByVal Centro As Integer, ByVal numalba As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.AEN_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.AEN_IdCentro, "=", Centro.ToString)
        Else
            CONSULTA.WheCampo(Me.AEN_Albaran, "=", numalba.ToString)
        End If
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


    Public Function ExisteAlb(ByVal Campa As Integer, ByVal Centro As Integer, ByVal numalba As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.AEN_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.AEN_IdCentro, "=", Centro.ToString)
        Else
            CONSULTA.WheCampo(Me.AEN_Albaran, "=", numalba.ToString)
        End If
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


    Public Function MaxIdCampa(ByVal Campa As Integer, ByVal Centro As Integer, Optional ByVal vmax As Integer = 0) As Integer
        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                If ContadorxCentro = True Then
                    max = ValorMaximo(Campa.ToString + "_" + Centro.ToString, vmax)
                Else
                    max = ValorMaximo(Campa.ToString, vmax)
                End If
                existe = ExisteAlb(Campa, Centro, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de albaranes", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function

    Private Sub E_AlbEntrada_ActualizaHijos(nuevo As Boolean) Handles Me.ActualizaHijos

    End Sub



    Private Sub E_Albentrada_EliminaHijos() Handles Me.EliminaHijos

        Dim sql As String
        Dim dt As New DataTable
        Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim AlbEntrada_his As New E_AlbEntrada_his(Idusuario, cn)

        sql = "select * from albentrada_lineas where AEL_idalbaran=" + AEN_IdAlbaran.Valor

        dt = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw As DataRow In dt.Rows
                Albentrada_lineas.CargaCampos(rw)
                Albentrada_lineas.Eliminar()
            Next
        End If


        sql = "select * from albentrada_his where AEH_idalbaran=" + AEN_IdAlbaran.Valor

        dt = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw As DataRow In dt.Rows
                AlbEntrada_his.CargaCampos(rw)
                AlbEntrada_his.Eliminar()
            Next
        End If

        If VaInt(Me.AEN_IdValeEnvase.Valor) > 0 Then
            If ValeEnvases.LeerId(Me.AEN_IdValeEnvase.Valor) = True Then
                ValeEnvases.Eliminar()
            End If
        End If

    End Sub




    Public Sub CrearValeEnvasesComercio(ByVal Nalbaran As String)

        Dim sql As String
        Dim dt As New DataTable
        Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)
        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
        Dim ValeEnvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
        Dim Confecenvaselineas As New E_ConfecEnvaseLineas(Idusuario, cn)
        Dim Confecpaletlineas As New E_ConfecPaletLineas(Idusuario, cn)
        Dim GeneroSalida As New E_GenerosSalida(Idusuario, cn)


        Dim Consulta As New Cdatos.E_select
        Dim x As Integer = 0
        Dim Operacion As String = "EB"
        Dim IdVale As Integer = 0

        Dim AcEnvases As New Acumulador
        Dim idmarca As Integer


        If VaInt(Nalbaran) = 0 Then Exit Sub

        If Me.LeerId(Nalbaran) = True Then


            IdVale = VaInt(Me.AEN_IdValeEnvase.Valor)
            If IdVale > 0 Then

                'Borra sólo las líneas automáticas
                Dim VEL As New E_ValeEnvases_Lineas(Idusuario, cn)

                Dim sqlL As String = "SELECT VEL_Id FROM ValeEnvases_Lineas WHERE VEL_IdVale = " & IdVale & " AND VEL_Automatica = 'S'"
                Dim dtL As DataTable = ValeEnvases_lineas.MiConexion.ConsultaSQL(sqlL)
                If Not IsNothing(dtL) Then
                    For Each rowL As DataRow In dtL.Rows
                        If VEL.LeerId(rowL("VEL_Id")) Then
                            VEL.Eliminar()
                        End If
                    Next
                End If

            End If


            AcEnvases.Borrar()


            Consulta.SelCampo(Albentrada_lineas.AEL_idpalet, "idpalet")
            Consulta.SelCampo(Albentrada_lineas.AEL_idenvase, "idenvase")
            Consulta.SelCampo(Albentrada_lineas.AEL_palets, "palets")
            Consulta.SelCampo(Albentrada_lineas.AEL_idmarca, "idmarca")
            Consulta.SelCampo(Albentrada_lineas.AEL_bultos, "bultos")
            Consulta.SelCampo(Albentrada_lineas.AEL_idtipoconfeccion, "idtipoconfeccion")
            Consulta.SelCampo(Albentrada_lineas.AEL_idtipopalet, "idtipopalet")
            Consulta.SelCampo(Albentrada_lineas.AEL_idgensal, "idgensal")
            Consulta.SelCampo(Albentrada_lineas.AEL_envasepropio, "envasepropio")
            Consulta.SelCampo(Albentrada_lineas.AEL_materialpropio, "materialpropio")

            Consulta.WheCampo(Albentrada_lineas.AEL_idalbaran, "=", Nalbaran)

            Dim Retornable As String = ""
            Dim TipoEnvase As String = ""

            dt = Me.MiConexion.ConsultaSQL(Consulta.SQL)
            If Not dt Is Nothing Then
                For Each rw As DataRow In dt.Rows

                    Dim EnvasePropio As String = rw("envasepropio").ToString
                    Dim MaterialPropio As String = rw("materialpropio").ToString


                    'palets

                    If VaInt(rw("idtipopalet")) = 0 Then
                        If VaInt(rw("palets")) > 0 And VaInt(rw("IdPalet")) > 0 Then
                            'If VaInt(rw("idtipopalet")) = 0 And VaInt(rw("palets")) > 0 And VaInt(rw("IdPalet")) > 0 Then
                            idmarca = 0

                            If Envases.LeerId(rw("idpalet").ToString) = True Then
                                If Envases.ENV_StockMarca.Valor = "S" Then
                                    idmarca = VaInt(rw("idmarca"))
                                End If
                                Retornable = Envases.ENV_Retornable.Valor
                            End If

                            ' If Retornable = "S" Or EnvasePropio = "S" Then

                            IdVale = CrearCabeceraEnvases(Operacion, IdVale)

                            Dim clave As New stClaves_ValeEnvase(VaInt(rw("idpalet")), idmarca, EnvasePropio)
                            Dim datos As New stDatos_ValeEnvase(VaDec(rw("palets")))

                            AcEnvases.Suma(clave, datos)

                            'End If

                        End If
                    Else

                        'ElseIf VaInt(rw("idtipopalet")) > 0 Then

                        sql = "Select CPL_idmaterial as material,CPL_cantidad as cantidad from confecpaletlineas where CPL_idconfec= " + rw("idtipopalet").ToString
                        dt = Me.MiConexion.ConsultaSQL(sql)
                        If Not dt Is Nothing Then
                            For Each rwl As DataRow In dt.Rows
                                If rw("palets") > 0 Then
                                    idmarca = 0
                                    If Envases.LeerId(rwl("material").ToString) = True Then
                                        ' If Envases.ENV_StockMarca.Valor = "S" Then
                                        ' idmarca = VaInt(rw("idmarca"))
                                        'End If
                                        TipoEnvase = Envases.ENV_Tipo.Valor
                                        Retornable = Envases.ENV_Retornable.Valor
                                    End If
                                    Dim crealinea As Boolean = True ' creamos siempre la linea de envase
                                    Dim Espropio As String = "S"
                                    If Retornable = "S" Then
                                        crealinea = True
                                    End If
                                    Select Case TipoEnvase
                                        Case "P", "E"
                                            If EnvasePropio = "S" Then
                                                crealinea = True
                                            End If
                                            Espropio = EnvasePropio
                                        Case Else
                                            If MaterialPropio = "S" Then
                                                crealinea = True
                                            End If
                                            Espropio = MaterialPropio
                                    End Select
                                    If crealinea = True Then

                                        IdVale = CrearCabeceraEnvases(Operacion, IdVale)

                                        Dim clave As New stClaves_ValeEnvase(VaInt(rwl("material")), idmarca, Espropio)
                                        Dim datos As New stDatos_ValeEnvase(VaDec(rw("palets")) * VaDec(rwl("cantidad")))

                                        AcEnvases.Suma(clave, datos)

                                    End If

                                End If
                            Next
                        End If
                    End If


                    ' bultos
                    If VaInt(rw("idtipoconfeccion")) = 0 Then
                        If rw("bultos") > 0 Then
                            idmarca = 0
                            If Envases.LeerId(rw("idenvase").ToString) = True Then
                                If Envases.ENV_StockMarca.Valor = "S" Then
                                    idmarca = VaInt(rw("idmarca"))
                                End If
                                Retornable = Envases.ENV_Retornable.Valor

                            End If
                            '                    If Retornable = "S" Or EnvasePropio = "S" Then

                            IdVale = CrearCabeceraEnvases(Operacion, IdVale)

                            Dim clave As New stClaves_ValeEnvase(VaInt(rw("idenvase")), idmarca, EnvasePropio)
                            Dim datos As New stDatos_ValeEnvase(VaDec(rw("bultos")))

                            AcEnvases.Suma(clave, datos)
                            '                        End If

                        End If
                    Else
                        sql = "Select CEL_idmaterial as material,CEL_cantidad as cantidad from confecenvaselineas where CEL_idconfec= " + rw("idtipoconfeccion").ToString
                        dt = Me.MiConexion.ConsultaSQL(sql)
                        If Not dt Is Nothing Then
                            For Each rwl As DataRow In dt.Rows
                                If rw("bultos") > 0 Then
                                    idmarca = 0
                                    If Envases.LeerId(rwl("material").ToString) = True Then
                                        If Envases.ENV_StockMarca.Valor = "S" Then
                                            idmarca = VaInt(rw("idmarca"))
                                        End If
                                        Retornable = Envases.ENV_Retornable.Valor
                                        TipoEnvase = Envases.ENV_Tipo.Valor

                                    End If
                                    Dim crealinea As Boolean = True ' creamos la linea siempre
                                    Dim Espropio As String = "S"
                                    If Retornable = "S" Then
                                        crealinea = True
                                    End If
                                    Select Case TipoEnvase
                                        Case "E", "P"
                                            If EnvasePropio = "S" Then
                                                crealinea = True
                                            End If
                                            Espropio = EnvasePropio
                                        Case Else
                                            If Envases.ENV_StockMarca.Valor = "S" Then
                                                idmarca = 0
                                                If GeneroSalida.LeerId(rw("idgensal").ToString) = True Then
                                                    If TipoEnvase = "M" Then
                                                        idmarca = GeneroSalida.GES_idmarcamaterial.Valor
                                                    Else
                                                        idmarca = GeneroSalida.GES_idmarcaetiqueta.Valor
                                                    End If
                                                    If MaterialPropio = "S" Then
                                                        crealinea = True
                                                    End If
                                                    Espropio = MaterialPropio
                                                End If
                                            End If
                                    End Select
                                    If crealinea = True Then

                                        IdVale = CrearCabeceraEnvases(Operacion, IdVale)

                                        Dim clave As New stClaves_ValeEnvase(VaInt(rwl("material")), idmarca, Espropio)
                                        Dim datos As New stDatos_ValeEnvase(VaDec(rw("bultos")) * VaDec(rwl("cantidad")))

                                        AcEnvases.Suma(clave, datos)
                                    End If
                                End If
                            Next
                        End If
                    End If

                Next
            End If

            Dim dte As DataTable = AcEnvases.DataTable
            For Each rwe In dte.Rows
                CreaLineaEnvases(IdVale, VaInt(rwe("idmaterial")), VaDec(rwe("cantidad")).ToString, VaInt(rwe("idmarca")), rwe("espropio").ToString)
            Next


            Me.AEN_IdValeEnvase.Valor = IdVale
            Me.Actualizar()
        End If


    End Sub


    Public Function AlbaranValorado(IdAlbaran As String, TipoFC As String) As Boolean

        Dim bRes As Boolean = True

        If VaInt(IdAlbaran) > 0 Then

            Dim sql As String = "SELECT AEL_FechaValoracion as FechaValoracion, AEL_Precio as Precio FROM AlbEntrada_Lineas WHERE AEL_IdAlbaran = " & IdAlbaran
            Dim dt As DataTable = MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then

                For Each row As DataRow In dt.Rows

                    Dim FechaValoracion As Date = VaDate(row("FechaValoracion"))
                    Dim Precio As Decimal = VaDec(row("Precio"))

                    Select Case TipoFC
                        Case "F"
                            If Precio = 0 And FechaValoracion = VaDate("") Then
                                bRes = False
                            End If
                        Case Else
                            If FechaValoracion = VaDate("") Then
                                bRes = False
                            End If
                    End Select

                Next

            End If


        End If

        Return bRes

    End Function


    'Public Sub CrearValeEnvases(ByVal Nalbaran As String)

    '    Dim sql As String
    '    Dim dt As New DataTable
    '    Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    '    Dim Envases As New E_Envases(Idusuario, cn)
    '    Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    '    Dim ValeEnvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
    '    Dim ConsultaP As New Cdatos.E_select
    '    Dim ConsultaB As New Cdatos.E_select
    '    Dim x As Integer = 0
    '    Dim Operacion As String = "EB"
    '    Dim IdVale As Integer = 0
    '    If Me.LeerId(Nalbaran) = True Then


    '        IdVale = VaInt(Me.AEN_IdValeEnvase.Valor)
    '        If IdVale > 0 Then

    '            'Borra sólo las líneas automáticas
    '            Dim VEL As New E_ValeEnvases_Lineas(Idusuario, cn)

    '            Dim sqlL As String = "SELECT VEL_Id FROM ValeEnvases_Lineas WHERE VEL_IdVale = " & IdVale & " AND VEL_Automatica = 'S'"
    '            Dim dtL As DataTable = ValeEnvases_lineas.MiConexion.ConsultaSQL(sqlL)
    '            If Not IsNothing(dtL) Then
    '                For Each rowL As DataRow In dtL.Rows
    '                    If VEL.LeerId(rowL("VEL_Id")) Then
    '                        VEL.Eliminar()
    '                    End If
    '                Next
    '            End If

    '        End If
    '        IdVale = 0

    '        sql = "Select AEL_idpalet as idpalet, sum(AEL_palets) AS uds  from albentrada_lineas where AEL_idalbaran=" + Nalbaran + " group by AEL_idpalet"
    '        dt = Me.MiConexion.ConsultaSQL(sql)
    '        If Not dt Is Nothing Then
    '            For Each rw As DataRow In dt.Rows
    '                If Envases.LeerId(rw("idpalet")) = True Then
    '                    ' If Envases.ENV_Retornable.Valor = "S" And rw("uds") > 0 Then
    '                    If rw("uds") > 0 Then
    '                        If IdVale = 0 Then
    '                            IdVale = CrearCabeceraEnvases(Operacion)
    '                        End If
    '                        CreaLineaEnvases(IdVale, rw("idpalet"), rw("uds").ToString, 0)
    '                    End If
    '                End If

    '            Next
    '        End If


    '        sql = "Select AEL_idenvase as idenvase, sum(AEL_bultos) as uds  from albentrada_lineas where AEL_idalbaran=" + Nalbaran + " group by AEL_idenvase"
    '        dt = Me.MiConexion.ConsultaSQL(sql)
    '        If Not dt Is Nothing Then
    '            For Each rw As DataRow In dt.Rows
    '                If Envases.LeerId(rw("idenvase")) = True Then
    '                    'If Envases.ENV_Retornable.Valor = "S" And rw("uds") > 0 Then
    '                    If rw("uds") > 0 Then
    '                        If IdVale = 0 Then
    '                            IdVale = CrearCabeceraEnvases(Operacion)
    '                        End If
    '                        CreaLineaEnvases(IdVale, rw("idenvase"), rw("uds").ToString, 0)
    '                    End If
    '                End If

    '            Next
    '        End If


    '        Me.AEN_IdValeEnvase.Valor = IdVale
    '        Me.Actualizar()
    '    End If


    'End Sub

    Private Sub CreaLineaEnvases(ByVal idvale As Integer, ByVal idenvase As Integer, ByVal uds As String, ByVal idmarca As Integer, Espropio As String)
        Dim idLinea As Integer = 0

        ValeEnvases_lineas.VaciaEntidad()
        idLinea = ValeEnvases_lineas.MaxId
        ValeEnvases_lineas.VEL_Id.Valor = idLinea.ToString
        ValeEnvases_lineas.VEL_idvale.Valor = idvale.ToString
        ValeEnvases_lineas.VEL_idenvase.Valor = idenvase
        ValeEnvases_lineas.VEL_retira.Valor = "0"
        ValeEnvases_lineas.VEL_entrega.Valor = uds
        ValeEnvases_lineas.VEL_precioretira.Valor = "0"
        ValeEnvases_lineas.VEL_precioentrega.Valor = "0"
        ValeEnvases_lineas.VEL_idmarca.Valor = idmarca.ToString
        'ValeEnvases_lineas.VEL_idalmacen.Valor = Me.AEN_IdPuntoVenta.Valor
        'ValeEnvases_lineas.VEL_idalmacen.Valor = Me.AEN_IdRecogida.Valor
        Dim IdRecogida As String = Me.AEN_IdRecogida.Valor
        If VaInt(IdRecogida) > 0 Then
            Dim CentroRecogida As New E_centrosrecogida(Idusuario, cn)
            If CentroRecogida.LeerId(IdRecogida) Then
                ValeEnvases_lineas.VEL_idalmacen.Valor = CentroRecogida.CER_IdAlmacenEnvases.Valor
            End If
        End If
        ValeEnvases_lineas.VEL_Automatica.Valor = "S"
        ValeEnvases_lineas.VEL_MaterialPropio.Valor = espropio

        ValeEnvases_lineas.Insertar()

    End Sub


    Private Function CrearCabeceraEnvases(ByVal Operacion As String, IdVale As Integer) As Integer


        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)

        Dim bNuevo As Boolean = (IdVale = 0)


        If bNuevo Then
            IdVale = ValeEnvases.MaxId
        ElseIf Not ValeEnvases.LeerId(IdVale) Then
            bNuevo = True
        End If

        ValeEnvases.VEV_Idvale.Valor = IdVale.ToString
        ValeEnvases.VEV_Operacion.Valor = Operacion
        ValeEnvases.VEV_Campa.Valor = Me.AEN_Campa.Valor
        ValeEnvases.VEV_Idcentro.Valor = Me.AEN_IdCentro.Valor
        ValeEnvases.VEV_Numero.Valor = Me.AEN_Albaran.Valor
        ValeEnvases.VEV_Fecha.Valor = Me.AEN_Fecha.Valor
        'ValeEnvases.VEV_IdAlmacen.Valor = Me.AEN_IdPuntoVenta.Valor
        'ValeEnvases.VEV_IdAlmacen.Valor = Me.AEN_IdRecogida.Valor
        Dim IdRecogida As String = Me.AEN_IdRecogida.Valor
        If VaInt(IdRecogida) > 0 Then
            Dim CentroRecogida As New E_centrosrecogida(Idusuario, cn)
            If CentroRecogida.LeerId(IdRecogida) Then
                ValeEnvases.VEV_IdAlmacen.Valor = CentroRecogida.CER_IdAlmacenEnvases.Valor
            End If
        End If
        ValeEnvases.VEV_IdConcepto.Valor = "0"
        ValeEnvases.VEV_Concepto.Valor = "ALBARAN ENTRADA " + Me.AEN_Albaran.Valor
        ValeEnvases.VEV_TipoSujeto.Valor = "A"
        ValeEnvases.VEV_Codigo.Valor = Me.AEN_IdAgricultor.Valor


        If bNuevo Then
            ValeEnvases.Insertar()
        Else
            ValeEnvases.Actualizar()
        End If


        Return IdVale

    End Function


    Public Function AlbaranControlado(Optional IdAlbaran As String = "") As String

        Dim Res As String = ""

        If IdAlbaran = "" Then IdAlbaran = Me.AEN_IdAlbaran.Valor & ""


        If VaInt(IdAlbaran) > 0 Then

            Dim sql As String = "SELECT DISTINCT AEL_Controlado as Controlado FROM AlbEntrada_Lineas WHERE AEL_IdAlbaran = " & IdAlbaran
            Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then


                If dt.Rows.Count > 0 Then

                    Res = "S"

                    For Each row As DataRow In dt.Rows

                        Dim Controlado As String = (row("Controlado").ToString & "").ToUpper.Trim
                        If Controlado <> "S" Then
                            Res = "N"
                            Exit For
                        End If

                    Next

                End If


            End If


        End If


        Return Res

    End Function


    'Public Shared Function PesoBrutoTotal(ByVal IdAlbaran As String) As Integer

    '    Dim peso As Integer = 0

    '    If VaDec(IdAlbaran) > 0 Then

    '        Dim sql As String = "SELECT SUM(AEL_KilosBrutos) as Peso FROM AlbEntrada_Lineas WHERE AEL_IdAlbaran = " & IdAlbaran
    '        Dim dt As DataTable = cn.ConsultaSQL(sql)
    '        If Not IsNothing(dt) Then
    '            If dt.Rows.Count > 0 Then

    '                Dim row As DataRow = dt.Rows(0)
    '                peso = VaInt(row("Peso"))

    '            End If
    '        End If


    '    End If

    '    Return peso

    'End Function


    Public Shared Function PesoNetoTotal(ByVal IdAlbaran As String) As Integer

        Dim peso As Integer = 0

        If VaDec(IdAlbaran) > 0 Then

            Dim sql As String = "SELECT SUM(AEL_KilosNetos) as Peso FROM AlbEntrada_Lineas WHERE AEL_IdAlbaran = " & IdAlbaran
            Dim dt As DataTable = cn.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim row As DataRow = dt.Rows(0)
                    peso = VaInt(row("Peso"))

                End If
            End If


        End If

        Return peso

    End Function


End Class
