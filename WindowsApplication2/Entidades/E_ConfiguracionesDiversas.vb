Public Class E_ConfiguracionesDiversas
    Inherits Cdatos.Entidad

    Enum eClaves As Integer

        PATH_FOTOS_AGRICULTORES
        NO_IMPRIMIR_BASCULA
        EJERCICIO_TECNICOS
        TEMPERATURA_TRANSPORTE_CMR
        SUFIJO_CONFIGURACION_FAX
        RUTA_ARCHIVOS_ADJUNTOS_TEMP
        PIN_FAX
        TELEFONO_COMERCIAL
        TELEFONO_CALIDAD
        TELEFONO_SALIDAS
        TELEFONO_ADMINISTRACION
        FAX_ADMINISTRACION
        RUTA_EXPORTACION_PDF_CLASIFICACION_PROVEEDORES
        PALET_ENTRADA_PREDETERMINADO
        TEXTO_TEMPERATURA_BOLETIN_MUESTREO
        FORMATO_PAPEL_ENTRADAS
        DIAS_DESDE_FECHA_PEDIDOS_ALMACEN
        CARPETA_DOCUMENTOS_BANCARIOS
        COPIAS_POR_DEFECTO_CARTELONES

        CUENTA_DEFECTO_COBROS_TESORERIA
        CUENTA_DEFECTO_COBROS_GASTOSFIN
        CUENTA_DEFECTO_COBROS_DIFCAMBIO
        CUENTA_DEFECTO_COBROS_CARTERA

        FECHA_BLOQUEO_CLASIFICACIONES

        TEXTO_ASUNTO_ALBARANES_EMAIL
        TEXTO_ASUNTO_FACTURAS_EMAIL

        RUTA_ADJUNTOS_NOTICIAS

        RUTA_BUZON_ENTRADA
        RUTA_BUZON_ENTRADA_PAGOS
        RUTA_BUZON_ENTRADA_PAGOS_LIQUIDACIONES

        FORMATO_PAPEL_PALETS



        CUENTA_TESORERIA_COBROS
        CUENTA_GASTOSFINANCIEROS_COBROS
        CUENTA_DIFERENCIASCAMBIO_COBROS
        CUENTA_CARTERA_COBROS


        RUTA_CARPETA_IARCHIVA

        AÑO_POR_DEFECTO_FONDO_OPERATIVO


        'Carpeta de llegada de pedidos EDICOM
        CARPETA_TEMPORAL_LLEGADA_PEDIDOS_EDI

        'Fondo operativo
        CUENTA_FONDOOPERATIVO_SUBVENCIONABLE                '5540
        CUENTA_FONDOOPERATIVO_NOSUBVENCIONABLE              '554700


        CUENTA_FONDOOPERATIVO_ACREEDOR                      '554400
        CUENTA_FONDOOPERATIVO_CARTERA
        SITUACION_FONDOOPERATIVO_CARTERA                    '3


    End Enum



    Public xLstClaves As New Dictionary(Of eClaves, String)

    Dim err As New Errores

    Dim csql As String = ""
    Dim dt As New DataTable

    Public _IdUsuario As Integer

    Public Id As Cdatos.bdcampo
    Public Clave As Cdatos.bdcampo
    Public Valor As Cdatos.bdcampo
    Public IdCentro As Cdatos.bdcampo
    Public IdPuntoVenta As Cdatos.bdcampo
    Public EUsuario As Cdatos.bdcampo

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal IdUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(IdUsuario)

        Try

            _IdUsuario = IdUsuario

            NombreTabla = "ConfiguracionesDiversas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.Entero, 10, 0, True)
            Clave = New Cdatos.bdcampo(CodigoEntidad & "Clave", Cdatos.TiposCampo.Cadena, 50)
            IdCentro = New Cdatos.bdcampo(CodigoEntidad & "IdCentro", Cdatos.TiposCampo.Entero, 10, 0)
            IdPuntoVenta = New Cdatos.bdcampo(CodigoEntidad & "IdPuntoVenta", Cdatos.TiposCampo.Entero, 10, 0)
            EUsuario = New Cdatos.bdcampo(CodigoEntidad & "IdUsuario", Cdatos.TiposCampo.Entero, 10, 0)
            Valor = New Cdatos.bdcampo(CodigoEntidad & "Valor", Cdatos.TiposCampo.Cadena, 50)

            MiListadeCampos = ListadeCampos()

            Dim sql As String = ""
            sql = " select CDV_idcentro AS IdCentro, CDV_idpuntoventa as IdPuntoVenta, CDV_clave as Clave, CDV_valor as Valor from configuracionesdiversas "

            _btBusca.CL_CampoOrden = "clave"
            _btBusca.CL_ConsultaSql = sql
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "Id"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.cl_formu = Nothing
            _btBusca.Name = "BtBuscaConfiguracionesDiversas"
            _btBusca.CL_ch1000 = False

            xLstClaves.Clear()

            Dim Claves As Reflection.FieldInfo() = GetType(E_ConfiguracionesDiversas.eClaves).GetFields()
            For Each item As Reflection.FieldInfo In Claves
                If Not item.IsSpecialName Then
                    Dim val As Integer = item.GetValue(0)
                    Dim nom As String = item.Name
                    '                    MsgBox(val.ToString & " " & nom)
                    xLstClaves.Add(val, nom)

                End If
            Next


            '  xLstClaves.Add(eClaves.PATH_FOTOS_AGRICULTORES, "PATH_FOTOS_AGRICULTORES")
            '  xLstClaves.Add(eClaves.NO_IMPRIMIR_BASCULA, "NO_IMPRIMIR_BASCULA")




            ' <---------------- nuevas palabras en el diccionario 

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' comprueba si existe la clave pasada, generalmente para crearla si no existe
    ''' </summary>
    ''' <param name="clave"></param>
    ''' <param name="puntoventa"></param>
    ''' <param name="centro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function xExisteClave(ByVal clave As eClaves, _
                                    Optional ByVal centro As Integer = 0, _
                                    Optional ByVal puntoventa As Integer = 0, _
                                    Optional ByVal usuario As Integer = 0) As Boolean

        Dim ret As Boolean = False

        csql = " select CDV_Id as Id, CDV_Clave as Clave, CDV_IdCentro as IdCentro, CDV_IdPuntoVenta as IdPuntoVenta, CDV_IdUsuario as IdUsuario from configuracionesdiversas "
        csql = csql & " where (CDV_clave='" & clave.ToString & "') "
        If centro <> 0 Then
            csql = csql & " and (CDV_idcentro=" & centro.ToString & ") "
        End If
        If puntoventa <> 0 Then
            csql = csql & " and (CDV_idpuntoventa=" & puntoventa.ToString & ") "
        End If
        If puntoventa <> 0 Then
            csql = csql & " and (CDV_idusuario=" & puntoventa.ToString & ") "
        End If

        dt = cn.ConsultaSQL(csql)
        If dt.Rows.Count > 0 Then ret = True
        Return ret

    End Function

    ''' <summary>
    ''' cargamos todas las configuraciones diversas del centro y punto de venta
    ''' </summary>
    ''' <param name="centro"></param>
    ''' <param name="puntoventa"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function xCargaConfiguraciones(Optional ByVal centro As Integer = 0, _
                                            Optional ByVal puntoventa As Integer = 0, _
                                            Optional ByVal usuario As Integer = 0) As DataTable

        Dim wh As Integer = 0
        Dim sqlwhere As String = ""
        Dim ret As New DataTable

        csql = " select CDV_Clave as Clave, CDV_Valor as Valor, CDV_IdCentro as IdCentro, CDV_IdPuntoVenta as IdPuntoVenta, CDV_IdUsuario as IdUsuario "
        csql = csql & "  from configuracionesdiversas "
        If centro <> 0 Then
            csql = csql & " where (CDV_idcentro=" & centro.ToString & ") "
            wh = 1
        End If
        If puntoventa <> 0 Then
            If wh = 0 Then sqlwhere = " where " Else sqlwhere = " and "
            csql = csql & sqlwhere & " (CDV_idpuntoventa=" & puntoventa.ToString & ") "
        End If
        If usuario <> 0 Then
            If wh = 0 Then sqlwhere = " where " Else sqlwhere = " and "
            csql = csql & sqlwhere & " (CDV_Idusuario=" & usuario.ToString & ") "
        End If
        csql = csql & " order by CDV_id "
        ret = cn.ConsultaSQL(csql)

        Return ret

    End Function


   

    ''' <summary>
    ''' leemos un id por su clave
    ''' </summary>
    ''' <param name="clave"></param>
    ''' <param name="centro"></param>
    ''' <param name="puntoventa"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function xLeerIdClave(ByVal clave As String, _
                                    Optional ByVal centro As Integer = 0, _
                                    Optional ByVal puntoventa As Integer = 0, _
                                    Optional ByVal usuario As Integer = 0) As Integer

        Dim ret As Integer = -1

        csql = " select CDV_id as Id from configuracionesdiversas "
        csql = csql & " where (CDV_clave='" & clave & "') "
        If centro <> 0 Then
            csql = csql & " and (CDV_idcentro=" & centro.ToString & ") "
        End If
        If puntoventa <> 0 Then
            csql = csql & " and (CDV_idpuntoventa=" & puntoventa.ToString & ") "
        End If
        If usuario <> 0 Then
            csql = csql & " and (CDV_idusuario=" & usuario.ToString & ") "
        End If

        dt = cn.ConsultaSQL(csql)
        If dt.Rows.Count > 0 Then ret = dt.Rows(0)("id")

        Return ret
    End Function

    Private Function Busca(ByVal clv As eClaves, ByVal cen As Integer, ByVal pun As Integer, ByVal usr As Integer) As String
        Dim ret As String = ""

        csql = " select CDV_Clave as Clave, CDV_Valor as Valor, CDV_IdCentro as IdCentro, CDV_IdPuntoVenta as IdPuntoVenta, CDV_IdUsuario as IdUsuario from configuracionesdiversas "
        csql = csql & " where (CDV_clave='" & clv.ToString & "') "
        csql = csql & " and (CDV_idcentro=" & cen.ToString & ") "
        csql = csql & " and (CDV_idpuntoventa=" & pun.ToString & ") "
        csql = csql & " and (CDV_idusuario=" & usr.ToString & ") "
        dt = cn.ConsultaSQL(csql)
        If dt.Rows.Count > 0 Then ret = dt.Rows(0)("valor").ToString

        Busca = ret

    End Function

    ''' <summary>
    ''' devuelve el valor de la clave pasada segun el orden de busqueda: [usuario]pv->centro
    ''' </summary>
    ''' <param name="clave"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function xDameValor(ByVal clave As eClaves, _
                                Optional ByVal puntoventa As Integer = 0, _
                                Optional ByVal centro As Integer = 0, _
                                Optional ByVal usuario As Integer = 0) As String

        ' orden de busqueda --------------------------------
        '   1º - con usuario (usuario <>  0)
        '       1a) por puntoventa 
        '       1b) por centro
        '       1c) sin puntoventa y sin centro
        '   2º - sin usuario (usuario = 0)
        '       2a) por puntoventa
        '       2b) por centro
        '       2c) sin puntoventa y sin centro

        Dim ret As String = ""

        ' parámetros CON usuario; usuario <> 0
        If usuario > 0 Then
            ret = Busca(clave, 0, puntoventa, usuario)
            If ret.Trim = "" Then ret = Busca(clave, centro, 0, usuario)
            If ret.Trim = "" Then ret = Busca(clave, 0, 0, usuario)
        End If

        ' parámetros SIN usuario; usuario = 0
        If ret.Trim = "" Then ret = Busca(clave, 0, puntoventa, 0)
        If ret.Trim = "" Then ret = Busca(clave, centro, 0, 0)
        If ret.Trim = "" Then ret = Busca(clave, 0, 0, 0)

        Return ret

    End Function

End Class
