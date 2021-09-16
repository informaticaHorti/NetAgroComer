Imports System.Data
Imports System.Reflection

Public Module Memoria

    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean

    'Funcion de liberacion de memoria
    Public Sub ClearMemory()

        Try
            Dim Mem As Process
            Mem = Process.GetCurrentProcess()
            SetProcessWorkingSetSize(Mem.Handle, -1, -1)
        Catch ex As Exception
            'Control de errores
            MsgBox("Error liberando memoria")
        End Try

    End Sub

End Module


Public Class Cdatos

    Public Class CamposSelect
        Public Campo As bdcampo
        Public CampoEnlace As bdcampo
        Public CampoNombre As String
        Public CampoClave As bdcampo
        Public Basedatos As String
        Public ValorDefecto As String
        Public CondicionInner As String
    End Class
    Public Class CamposCondicion
        Public Campo As bdcampo
        Public tipo As String
        Public Valor As String

    End Class
    Public Class CamposRelacion
        Public Destino As bdcampo
        Public Origen As bdcampo
    End Class

    Public Class PropiedadesTx
        Public Longitud As Integer
        Public Tipo As Cdatos.TiposCampo
        Public CampoBd As Cdatos.bdcampo
        Public Decimales As Integer
        Public Exclusivos As String
        Public Obligatorio As Boolean
        Public BtBusca As BtBusca
        Public Entidadenlace As Entidad
        Public CampoEnlace As bdcampo
        Public LabelEnlace As Lb
        Public FiltroFecha As String



    End Class

    <Serializable()>
    Public Class PropiedadesCamposGrid
        Public CampoBd As String
        Public NombreCabecera As String
        Public Visible As Boolean
        Public Tamaño As Integer
        Public Suma As Boolean
        Public Formato As String
        Public FormatoSuma As String

    End Class


    Public Enum ETipoFrm
        Mantenimiento
        Consulta
        Otro
    End Enum
    Public Function tipofrm(ByVal Frm As Object) As ETipoFrm

        Try

            Return Frm.tipofrm
        Catch ex As Exception
            Return 0
        End Try

    End Function
    Public Enum Compara
        Igual
        Menor
        Mayor
        MenorIgual
        MayorIgual
        Distinto

    End Enum


    Public Enum TiposCampo
        Cadena
        CadenaNumero
        Cuenta
        Entero
        EnteroPositivo
        Importe
        Fecha
        CuentaCliente
        Hora
        FechaHora
    End Enum


    Public Class bdcampo
        Dim err As New Errores
        Private _NombreCampo As String
        Private _Valor As String
        Private _Longitud As Integer
        Private _TipoBd As TiposCampo
        Private _Decimales As Integer
        Private _Primari As Boolean
        Private _EnlaceEntidad As Entidad
        Private _EnlaceId As bdcampo
        Private _EnlaceNombre As bdcampo
        Private _EnlaceAlias As String
        Private _EnlaceAliasNombreCampo As String



        Private _MiEntidad As Entidad


        Public Property EnlaceAliasNombreCampo As String
            Set(ByVal value As String)
                Try
                    _EnlaceAliasNombreCampo = value

                Catch ex As Exception
                    err.Muestraerror("No se pudo guardar EnlaceAliasNombreCampo", "Set Property Valor", ex.Message)
                    _EnlaceAliasNombreCampo = ""
                End Try

            End Set
            Get
                Try
                    Return _EnlaceAliasNombreCampo
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver EnlaceAliasNombreCampo", "Get Property Valor", ex.Message)
                    Return ("")
                End Try

            End Get
        End Property


        Public Property EnlaceAlias As String
            Set(ByVal value As String)
                Try
                    _EnlaceAlias = value

                Catch ex As Exception
                    err.Muestraerror("No se pudo guardar EnlaceAlias", "Set Property Valor", ex.Message)
                    _EnlaceAlias = ""
                End Try

            End Set
            Get
                Try
                    Return _EnlaceAlias
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver EnlaceAlias", "Get Property Valor", ex.Message)
                    Return ("")
                End Try

            End Get
        End Property



        Public Sub New(ByVal strBDCampo As String, ByVal Tipo As TiposCampo, ByVal lg As Integer, Optional ByVal NumDecimales As Integer = 0, Optional ByVal bolPrimari As Boolean = False, Optional ByVal EnlEntidad As Entidad = Nothing, Optional ByVal Enlid As bdcampo = Nothing, Optional ByVal EnlNombre As bdcampo = Nothing, Optional ByVal EnlAlias As String = "", Optional ByVal EnlAliasNombreCampo As String = "")
            Try
                NombreCampo = strBDCampo
                TipoBd = Tipo
                Primary = bolPrimari
                Decimales = NumDecimales
                Longitud = lg

                _EnlaceAlias = ""
                _EnlaceAliasNombreCampo = ""

                If EnlEntidad IsNot Nothing Then
                    If Enlid IsNot Nothing Then
                        Longitud = Enlid.Longitud ' iguala la longitud a la de la entidad con la que enlaza
                        If EnlNombre IsNot Nothing Then
                            EnlaceEntidad = EnlEntidad
                            EnlaceId = Enlid
                            EnlaceNombre = EnlNombre
                            EnlaceAlias = EnlAlias
                            EnlaceAliasNombreCampo = EnlAliasNombreCampo

                            If EnlaceAlias.Trim <> "" And EnlaceAliasNombreCampo.Trim = "" Then
                                EnlaceAliasNombreCampo = strBDCampo
                            End If

                        End If
                    End If
                End If

            Catch ex As Exception
                err.Muestraerror("No se pudo inicializar BDCampo", "New", ex.Message)
            End Try

        End Sub


        Public Property MiEntidad As Entidad
            Get
                Try
                    Return _MiEntidad
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver MiEntidad", "Get Property MiEntidad", ex.Message)
                    Return Nothing
                End Try

            End Get
            Set(ByVal value As Entidad)
                Try
                    _MiEntidad = value
                Catch ex As Exception
                    err.Muestraerror("No se pudo guardar MiEntidad", "Set Property MiEntidad", ex.Message)
                    _MiEntidad = Nothing
                End Try

            End Set
        End Property

        Public Property Valor As String
            Set(ByVal value As String)
                Try
                    _Valor = value

                Catch ex As Exception
                    err.Muestraerror("No se pudo guardar Valor", "Set Property Valor", ex.Message)
                    _Valor = ""
                End Try

            End Set
            Get
                Try
                    Return _Valor
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver Valor", "Get Property Valor", ex.Message)
                    Return ("")
                End Try

            End Get
        End Property

        Public Property NombreCampo As String
            Set(ByVal value As String)
                Try
                    _NombreCampo = value

                Catch ex As Exception
                    err.Muestraerror("No se pudo guardar NombreCampo", "Set Property NombreCampo", ex.Message)
                    _NombreCampo = ""
                End Try

            End Set
            Get
                Try
                    Return _NombreCampo
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver nombrecampo", "Get Property Valor", ex.Message)
                    Return ("")
                End Try

            End Get
        End Property


        Public Property TipoBd As TiposCampo
            Set(ByVal value As TiposCampo)
                Try
                    _TipoBd = value

                Catch ex As Exception
                    err.Muestraerror("No se pudo guardar TipoBd", "Set Property Valor", ex.Message)
                    _TipoBd = 0
                End Try

            End Set
            Get
                Try
                    Return _TipoBd
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver TipoBd", "Get Property Valor", ex.Message)
                    Return (0)
                End Try

            End Get
        End Property

        Public Property Longitud As Integer
            Set(ByVal value As Integer)
                Try
                    _Longitud = value

                Catch ex As Exception
                    err.Muestraerror("No se pudo guardar Longitud", "Set Property Valor", ex.Message)
                    _Longitud = 0
                End Try

            End Set
            Get
                Try
                    Return _Longitud
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver Longitud", "Get Property Valor", ex.Message)
                    Return (0)
                End Try

            End Get
        End Property

        Public Property Decimales As Integer
            Set(ByVal value As Integer)
                Try
                    _Decimales = value

                Catch ex As Exception
                    err.Muestraerror("No se pudo guardar Decimales", "Set Property Valor", ex.Message)
                    _Decimales = 0
                End Try

            End Set
            Get
                Try
                    Return _Decimales
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver decimales", "Get Property Valor", ex.Message)
                    Return (0)
                End Try

            End Get
        End Property

        Public Property Primary As Boolean
            Set(ByVal value As Boolean)
                Try
                    _Primari = value

                Catch ex As Exception
                    err.Muestraerror("No se pudo guardar primari", "Set Property primari", ex.Message)
                    _Primari = False
                End Try

            End Set
            Get
                Try
                    Return _Primari
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver primari", "Get Property primari", ex.Message)
                    Return False
                End Try

            End Get
        End Property


        Public Property EnlaceEntidad As Entidad
            Set(ByVal value As Entidad)
                Try
                    _EnlaceEntidad = value

                Catch ex As Exception
                    err.Muestraerror("No se pudo guardar EnlaceTabla", "Set Property EnlaceTabla", ex.Message)
                    _EnlaceEntidad = Nothing
                End Try

            End Set
            Get
                Try
                    Return _EnlaceEntidad
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver enlacetabla", "Get Property enlacetabla", ex.Message)
                    Return Nothing
                End Try

            End Get
        End Property

        Public Property EnlaceId As bdcampo
            Set(ByVal value As bdcampo)
                Try
                    _EnlaceId = value

                Catch ex As Exception
                    err.Muestraerror("No se pudo guardar Enlaceid", "Set Property EnlaceId", ex.Message)
                    _EnlaceId = Nothing
                End Try

            End Set
            Get
                Try
                    Return _EnlaceId
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver enlaceid", "Get Property enlaceId", ex.Message)
                    Return Nothing
                End Try

            End Get
        End Property
        Public Property EnlaceNombre As bdcampo
            Set(ByVal value As bdcampo)
                Try
                    _EnlaceNombre = value

                Catch ex As Exception
                    err.Muestraerror("No se pudo guardar EnlaceNombre", "Set Property EnlaceNombre", ex.Message)
                    _EnlaceNombre = Nothing
                End Try

            End Set
            Get
                Try
                    Return _EnlaceNombre
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver enlaceNombre", "Get Property enlaceNombre", ex.Message)
                    Return Nothing
                End Try

            End Get
        End Property

    End Class

    Public Class E_select
        Public Listacampos As New List(Of CamposSelect)
        Public ListaCondicion As New List(Of CamposCondicion)

        Public Sub SelCampo(ByVal campo As bdcampo, Optional ByVal Nombre As String = "", Optional ByVal campoenlace As bdcampo = Nothing, Optional ByVal campoclave As bdcampo = Nothing, Optional ByVal vdefecto As String = "''", Optional Condicion As String = "")

            Dim Cs As New CamposSelect
            Cs.Campo = campo
            Cs.CampoEnlace = campoenlace
            Cs.CampoNombre = Nombre
            Cs.CampoClave = campoclave
            Cs.ValorDefecto = vdefecto
            Cs.CondicionInner = Condicion
            Listacampos.Add(Cs)

        End Sub


        Public Sub SelTodos(ByVal enti As Entidad)


            For Each campo As bdcampo In enti.ListadeCampos
                Dim Cs As New CamposSelect
                Cs.Campo = campo
                Cs.Campo.NombreCampo = campo.NombreCampo
                Cs.CampoEnlace = Nothing
                Cs.CampoNombre = Nothing
                Cs.CampoClave = Nothing

                Listacampos.Add(Cs)

            Next
        End Sub


        Public Sub WheCampo(ByVal campo As bdcampo, ByVal Tipo As String, ByVal valor As String)

            Dim cw As New CamposCondicion
            cw.Campo = campo
            cw.tipo = Tipo
            cw.Valor = valor

            'No añadir la misma condición 2 veces
            Dim bEncontrado As Boolean = False
            For Each condicion As CamposCondicion In ListaCondicion
                If cw.Campo.NombreCampo.ToUpper = condicion.Campo.NombreCampo.ToUpper And cw.tipo.ToUpper = condicion.tipo.ToUpper And cw.Valor.ToUpper = condicion.Valor.ToUpper Then
                    bEncontrado = True
                End If
            Next


            If Not bEncontrado Then
                ListaCondicion.Add(cw)
            End If


        End Sub


        Public Sub BorraCondicion(ByVal campo As bdcampo)

            Dim lst As List(Of CamposCondicion) = ListaCondicion

            For Each condicion As CamposCondicion In ListaCondicion
                If campo.NombreCampo.ToUpper <> condicion.Campo.NombreCampo.ToUpper Then
                    lst.Add(condicion)
                End If
            Next

            ListaCondicion = lst

        End Sub


        Public Function SQL() As String
            Return Sel() + Whe()
        End Function

        Public Function Whe() As String

            Dim t As String = ""
            Dim ret As String = ""

            For Each c As Cdatos.CamposCondicion In Me.ListaCondicion
                Select Case c.tipo
                    Case Compara.Igual, "="
                        t = "="
                    Case Compara.Mayor, ">"
                        t = ">"
                    Case Compara.Menor, "<"
                        t = "<"
                    Case Compara.MayorIgual, ">="
                        t = ">="
                    Case Compara.MenorIgual, "<="
                        t = "<="
                    Case Compara.Distinto, "<>"
                        t = "<>"
                End Select
                If ret = "" Then
                    ret = " where "
                End If
                ' c.Campo.Valor = c.Valor


                '                ret = ret + c.Campo.MiEntidad.NombreTabla + "." + c.Campo.NombreCampo + " " + t + " " + c.Campo.MiEntidad.ValorCampo(c.Campo) + " AND "
                ret = ret + c.Campo.MiEntidad.NombreTabla + "." + c.Campo.NombreCampo + " " + t + " " + c.Campo.MiEntidad.SqlCampo(c.Valor, c.Campo.TipoBd) + " AND "
                ret = ret + Chr(13) + Chr(10)
            Next
            If Len(ret) > 0 Then
                ret = Mid(ret, 1, Len(ret) - 6)
            End If

            Return ret
        End Function
        Public Function Sel(Optional ByVal todos As Boolean = False) As String

            Dim nom As String = ""
            Dim r As Integer
            'Dim Enti As New Dictionary(Of String, String)
            Dim Primeraentidad As String = ""
            Dim PrimeraBd As String = ""

            Dim Enlaces As String = ""
            Dim ret As String = "Select "
            Dim clave As String = ""
            Dim Campo As String = ""
            Dim nombretabla As String = ""
            Dim DcEntidad As New Dictionary(Of String, String)

            For Each c As Cdatos.CamposSelect In Me.Listacampos

                r = r + 1
                If Primeraentidad = "" Then
                    Primeraentidad = c.Campo.MiEntidad.NombreBd + ".dbo." + c.Campo.MiEntidad.NombreTabla
                End If
                If todos = True Then
                    If DcEntidad.ContainsKey(c.Campo.MiEntidad.NombreTabla) = False Then
                        DcEntidad.Add(c.Campo.MiEntidad.NombreTabla, c.Campo.MiEntidad.NombreBd + ".dbo." + c.Campo.MiEntidad.NombreTabla)
                    End If
                End If
                If c.Campo Is Nothing Then
                    Dim v As String = ""
                    If c.ValorDefecto = "" Then
                        v = "''"
                    Else
                        v = c.ValorDefecto
                    End If
                    Campo = v & " AS " & c.CampoNombre

                Else
                    If Left(c.Campo.NombreCampo, 1) <> "@" Then
                        nombretabla = c.Campo.MiEntidad.NombreBd + ".dbo." + c.Campo.MiEntidad.NombreTabla
                        If c.Campo.MiEntidad.NombreTabla <> Primeraentidad Then
                            'nombretabla = c.Campo.MiEntidad.NombreTabla + "_" + r.ToString
                        End If






                        Dim bNormal As Boolean = True

                        If c.Campo.EnlaceAlias.Trim <> "" Then
                            Campo = c.Campo.EnlaceAlias + "." + c.Campo.EnlaceAliasNombreCampo
                            c.CampoNombre = c.Campo.EnlaceAlias & "_" & c.Campo.NombreCampo
                            bNormal = False
                        End If

                        If Not IsNothing(c.CampoEnlace) Then

                            If c.CampoEnlace.EnlaceAlias.Trim <> "" Then
                                Campo = c.CampoEnlace.EnlaceAlias + "." + c.Campo.NombreCampo
                                c.CampoNombre = c.CampoEnlace.EnlaceAlias & "_" & c.Campo.NombreCampo
                                bNormal = False
                            End If

                        End If

                        If bNormal Then Campo = nombretabla + "." + c.Campo.NombreCampo

                        '                    If c.Campo.MiEntidad.NombreBd <> "" And c.Campo.MiEntidad.NombreBd <> PrimeraBd Then
                        ' Campo = c.Campo.MiEntidad.NombreBd + "." + Campo
                        'End If
                    Else
                        Campo = Mid(c.Campo.NombreCampo, 2)
                    End If
                    If Not c.CampoNombre Is Nothing Then

                        If c.CampoNombre.Trim <> "" Then
                            Campo = Campo & " AS " & c.CampoNombre
                        End If
                    End If

                End If




                    ret = ret + Campo
                    ret = ret + ", " + Chr(13) + Chr(10)

                    If Not c.CampoEnlace Is Nothing Then

                        If Not c.CampoClave Is Nothing Then
                            clave = c.CampoClave.NombreCampo
                            If c.CampoClave.MiEntidad.NombreTabla <> c.Campo.MiEntidad.NombreTabla Then
                                MsgBox("no coincide la entidad del campo clave")
                            End If
                        Else
                            clave = c.Campo.MiEntidad.ClavePrimaria.NombreCampo
                        End If

                        clave = nombretabla + "." + clave




                        If c.CampoEnlace.EnlaceAlias.Trim <> "" Then
                            clave = c.CampoEnlace.EnlaceAlias + "." + c.CampoEnlace.EnlaceAliasNombreCampo
                            Enlaces = Enlaces + " LEFT OUTER JOIN " + c.Campo.MiEntidad.NombreBd + ".dbo." + c.Campo.MiEntidad.NombreTabla + " AS " + c.CampoEnlace.EnlaceAlias + " ON " + c.CampoEnlace.MiEntidad.NombreBd + ".dbo." + c.CampoEnlace.MiEntidad.NombreTabla + "." + c.CampoEnlace.NombreCampo + " = " + clave + Chr(13) + Chr(10)
                            If c.CondicionInner <> "" Then Enlaces = Enlaces + " " + c.CondicionInner + Chr(13) + Chr(10)
                        Else
                            Enlaces = Enlaces + " LEFT OUTER JOIN " + c.Campo.MiEntidad.NombreBd + ".dbo." + c.Campo.MiEntidad.NombreTabla + " ON " + c.CampoEnlace.MiEntidad.NombreBd + ".dbo." + c.CampoEnlace.MiEntidad.NombreTabla + "." + c.CampoEnlace.NombreCampo + " = " + clave + Chr(13) + Chr(10)
                            If c.CondicionInner <> "" Then
                                Enlaces = Enlaces + " " + c.CondicionInner + Chr(13) + Chr(10)
                            End If

                        End If

                    End If

            Next

            If Len(ret) > 0 Then
                ret = Mid(ret, 1, Len(ret) - 4)
            End If

            If todos = True Then

                For Each nenti In DcEntidad.Keys
                    ret = ret + ", " + DcEntidad(nenti) + ".*"
                Next
            End If
            ret = ret + " from " + Primeraentidad + Chr(13) + Chr(10)
            ret = ret + Enlaces


            Return ret

        End Function



    End Class





    Public Class Conexion
        Dim err As New Errores
        Public conn As New Odbc.OdbcConnection

        ''' <summary>
        ''' </summary>
        ''' <param name="conex">Cadena de conexión de SQL SERVER</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal conex As String)
            Try
                conn.ConnectionString = conex
            Catch ex As Exception
                err.Muestraerror("No se pudo crear la clase conexion", "New(ByVal conex As String)", ex.Message)
            End Try
        End Sub
        Private _CadenaConexion As String

        Public ReadOnly Property CadenaConexion As String
            Get
                Try
                    Return conn.ConnectionString
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver la cadena de conexion", "CadenaConexion", ex.Message)
                    Return ""

                End Try

            End Get

        End Property


        Public Function AbrirConexion() As Boolean
            Try
                conn.Open()
                Return True
            Catch ex As Exception
                err.Muestraerror("No se pudo abrir la conexion " & vbCrLf & conn.ConnectionString, "AbrirConexion", ex.Message)
                Return False
            End Try
        End Function
        Public Function CerrarConexion() As Boolean
            Try
                conn.Close()
                Return True
            Catch ex As Exception
                err.Muestraerror("No se pudo cerrar la conexion", "CerrarConexion", ex.Message)
                Return False
            End Try
        End Function




        ''' <summary>
        ''' Ejecuta una consulta sql
        ''' </summary>
        ''' <param name="orden">Cadena con la consulta sql</param>
        ''' <returns>Devuelve true si se ha ejecutado correctamente, y false en caso de error</returns>
        ''' <remarks></remarks>
        Public Function OrdenSql(ByVal orden As String) As Boolean
            Try
                Dim command As Odbc.OdbcCommand
                command = conn.CreateCommand()
                command.CommandText = orden
                command.CommandTimeout = 500
                command.ExecuteNonQuery()
                ' aqui llamar a clase control trazabilidad uso de la bd
                Return True
            Catch ex As Exception

                err.Muestraerror(ex.Message, "OrdenSql", orden)
                Return (False)
            End Try

        End Function




        ''' <summary>
        ''' Devuelve el resultado de una consulta sql
        ''' </summary>
        ''' <param name="consulta">Cadena con la consulta sql</param>
        ''' <returns>Devuelve un DataTable con el resultado, en caso de error devuelve Nothing</returns>
        ''' <remarks></remarks>
        Public Function ConsultaSQL(ByVal consulta As String, Optional ByVal Ro As Boolean = False, Optional TimeOut As Integer = 0) As DataTable

            Application.DoEvents()

            Select Case Ro
                Case False
                    Try

                        Dim oDatatable As New DataTable
                        Dim ta = New Odbc.OdbcDataAdapter(consulta, conn)

                        If TimeOut > 0 Then
                            ta.SelectCommand.CommandTimeout = TimeOut
                        ElseIf TimeOutConsulta > 0 Then
                            ta.SelectCommand.CommandTimeout = TimeOutConsulta
                        End If

                        ta.Fill(oDatatable)
                        Return oDatatable

                    Catch ex As Exception
                        err.Muestraerror(ex.Message, "consultasql", consulta)
                        Return Nothing
                    End Try

                Case Else ' solo lectura

                    Dim ta As Odbc.OdbcDataReader
                    Dim cmd As New Odbc.OdbcCommand(consulta, conn)
                    cmd.CommandTimeout = 500

                    Try
                        Dim oDatatable As New DataTable
                        ta = cmd.ExecuteReader
                        oDatatable.Load(ta)
                        Return (oDatatable)

                    Catch ex As Exception
                        err.Muestraerror(ex.Message, "consultasql", consulta)
                        Return Nothing
                    End Try

            End Select

            Application.DoEvents()

        End Function

    End Class



    Public Class Entidad

        Public Sub New()

        End Sub


        Dim err As New Errores
        Dim _NombreTabla As String
        Private infoCampos() As FieldInfo = Me.GetType.GetFields(BindingFlags.Instance Or BindingFlags.Public)


        Protected _lstCamposDocumento As New List(Of bdcampo)
        Public ReadOnly Property CamposDocumento As List(Of bdcampo)
            Get
                Return _lstCamposDocumento
            End Get
        End Property

        Protected _lstCamposDocumentoExtendido As New List(Of bdcampo)
        Public ReadOnly Property CamposDocumentoExtendido As List(Of bdcampo)
            Get
                Return _lstCamposDocumentoExtendido
            End Get
        End Property


        Private _PrefijoContador As String = "CON_"
        Public Property PrefijoContador As String
            Get
                Return _PrefijoContador
            End Get
            Set(value As String)
                _PrefijoContador = value
            End Set
        End Property


        'Evento para ejecutar despues de guardar o actualizar datos de cada entidad, para actualizar los hijos
        Public Event ActualizaHijos(ByVal nuevo As Boolean)
        Public Event EliminaHijos()


        Protected _DescripcionDocumental As String = ""
        Public ReadOnly Property DescripcionDocumental
            Get
                If _DescripcionDocumental = "" Then
                    Return NombreTabla
                Else
                    Return _DescripcionDocumental
                End If
            End Get
        End Property


        Protected _Codigo As String = ""
        Protected Property CodigoEntidad As String
            Get
                Return _Codigo
            End Get
            Set(value As String)
                _Codigo = value
            End Set
        End Property



        Protected _EsVista As Boolean = False
        Public ReadOnly Property EsVista As Boolean
            Get
                Return _EsVista
            End Get
        End Property


        Public Property NombreTabla As String
            Set(ByVal value As String)
                Try
                    _NombreTabla = value

                Catch ex As Exception
                    err.Muestraerror("No se pudo guardar NombreTabla", "Set Property NombreTabla", ex.Message)
                    _NombreTabla = ""
                End Try

            End Set
            Get
                Try
                    Return _NombreTabla
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver nombrecampo", "Get Property Nombretabla", ex.Message)
                    Return ("")
                End Try

            End Get
        End Property
        Dim _NombreBd As String = ""
        Public Property NombreBd As String
            Set(ByVal value As String)
                _NombreBd = value

            End Set
            Get
                Return _NombreBd

            End Get
        End Property

        Protected _btBusca As BtBusca

        Public Property btBusca As BtBusca

            Get
                Return _btBusca
            End Get
            Set(ByVal value As BtBusca)
                _btBusca = value
            End Set
        End Property
        Private _Vacia As Boolean = True
        Public Property Vacia As Boolean
            Set(ByVal value As Boolean)
                _Vacia = value

            End Set

            Get
                Return _Vacia

            End Get
        End Property


        Private _Usuario As Integer
        Public Property Usuario As Integer
            Get
                Try
                    Return _Usuario
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver el usuario", "Get Property Usuario", ex.Message)
                    Return Nothing
                End Try

            End Get
            Set(ByVal value As Integer)
                Try
                    _Usuario = value
                Catch ex As Exception
                    err.Muestraerror("No se pudo guardar el usuario", "Set Property Usuario", ex.Message)
                    _Usuario = Nothing
                End Try

            End Set
        End Property
        Private _CampoContador As String
        Public Property CampoContador As String
            Get
                Try
                    Return _CampoContador
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver el campocontador", "Get Property Usuario", ex.Message)
                    Return Nothing
                End Try

            End Get
            Set(ByVal value As String)
                Try
                    _CampoContador = value
                Catch ex As Exception
                    err.Muestraerror("No se pudo guardar el campocontador", "Set Property Usuario", ex.Message)
                    _CampoContador = Nothing
                End Try

            End Set
        End Property

        Private _MiConexion As Conexion
        Public Property MiConexion As Conexion
            Get
                Try
                    Return _MiConexion
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver MiConexion", "Get Property MiConexion", ex.Message)
                    Return Nothing
                End Try

            End Get
            Set(ByVal value As Conexion)
                Try
                    _MiConexion = value
                Catch ex As Exception
                    err.Muestraerror("No se pudo guardar MiConexion", "Set Property MiConexion", ex.Message)
                    value = Nothing
                End Try

            End Set
        End Property
        Private _MiListadeCampos As List(Of bdcampo)
        Public Property MiListadeCampos As List(Of bdcampo)
            Get
                Try
                    Return _MiListadeCampos
                Catch ex As Exception
                    err.Muestraerror("No se pudo devolver Milistadecampos", "Get Property MiConexion", ex.Message)
                    Return Nothing
                End Try

            End Get
            Set(ByVal value As List(Of bdcampo))
                Try
                    _MiListadeCampos = value
                Catch ex As Exception
                    err.Muestraerror("No se pudo guardar Milistadecampos", "Set Property MiConexion", ex.Message)
                    value = Nothing
                End Try

            End Set
        End Property

        Private _ContadorxCentro As Boolean = False
        Public Property ContadorxCentro As Boolean
            Set(ByVal value As Boolean)
                _ContadorxCentro = value

            End Set

            Get
                Return _ContadorxCentro

            End Get
        End Property

        Public Sub New(ByVal IdUsuario As Integer)

            Try
                _Usuario = IdUsuario
            Catch ex As Exception
                err.Muestraerror("No se ha podido inicializar Entidad", "New(IdUsuario as Integer)", ex.Message)
            End Try

            _btBusca = New BtBusca()
            _btBusca.Image = Global.NetAgro.My.Resources.Lupa16_
            _btBusca.Location = New System.Drawing.Point(134, 303)
            _btBusca.Size = New System.Drawing.Size(33, 23)
            _btBusca.UseVisualStyleBackColor = True


        End Sub

        Public Function ListadeCampos() As List(Of bdcampo)
            'devuelve una lista de los campos que componen la entidad
            Try
                Dim fnmisCampos As New List(Of bdcampo)

                For i As Integer = 0 To infoCampos.Length - 1
                    If TypeOf infoCampos(i).GetValue(Me) Is bdcampo Then
                        CType(infoCampos(i).GetValue(Me), bdcampo).MiEntidad = Me
                        Dim campo As bdcampo = CType(infoCampos(i).GetValue(Me), bdcampo)
                        fnmisCampos.Add(campo)
                    End If
                Next

                Return fnmisCampos


            Catch ex As Exception
                err.Muestraerror("Error en CargaCampos de la entidad " & NombreTabla, "Function CargaCampos() as list of (BdCampo)", ex.Message)
                Return Nothing
            End Try

        End Function

        Public Overridable Function LeerId(ByVal Id As String) As Boolean
            Dim Err As New Errores
            ' leer el registro y lo carga en la entidad por una id
            Try
                Dim CadenaInicial As String = "SELECT * FROM " & NombreTabla
                Dim CadenaWhere As String = " WHERE ("

                For Each ibdCampo As bdcampo In MiListadeCampos()

                    If ibdCampo.Primary Then
                        ibdCampo.Valor = Id
                        CadenaWhere = CadenaWhere & ibdCampo.NombreCampo & "=" & ValorCampo(ibdCampo) & " AND "
                    End If
                Next

                CadenaWhere = CadenaWhere.Substring(0, CadenaWhere.Length - 4) & ")"

                ' MsgBox(CadenaInicial + CadenaValores + CadenaWhere)
                Dim resultado As Boolean
                Dim Dt As New DataTable
                Dt = MiConexion.ConsultaSQL(CadenaInicial + CadenaWhere)
                If Dt.Rows.Count > 0 Then
                    resultado = True
                    CargaCampos(Dt.Rows(0))
                Else
                    VaciaEntidad()
                    resultado = False
                End If

                Return resultado
            Catch ex As Exception
                Err.Muestraerror("Error al LEER ID en la Entidad " & NombreTabla, "Function LeerId() As Boolean", ex.Message)
                Return False
            End Try

        End Function
        Public Overridable Sub VaciaEntidad()
            For Each b As bdcampo In MiListadeCampos
                b.Valor = ""
            Next
            Vacia = True
        End Sub
        Public Overridable Sub CargaCampos(ByVal row As System.Data.DataRow)
            Try
                For Each b As bdcampo In MiListadeCampos
                    b.Valor = ""
                    Select Case b.TipoBd

                        Case TiposCampo.Importe
                            If row(b.NombreCampo) Is DBNull.Value Then
                                b.Valor = "0"
                            Else
                                b.Valor = row(b.NombreCampo).ToString
                            End If

                        Case TiposCampo.Entero, TiposCampo.EnteroPositivo

                            If row(b.NombreCampo) Is DBNull.Value Then
                                b.Valor = "0"
                            Else
                                b.Valor = row(b.NombreCampo).ToString.Replace(".", "")
                            End If
                        Case TiposCampo.Fecha
                            If row(b.NombreCampo) Is DBNull.Value Then
                                b.Valor = ""
                            Else
                                b.Valor = Left(row(b.NombreCampo).ToString, 10)
                            End If

                        Case TiposCampo.Hora
                            If row(b.NombreCampo) Is DBNull.Value Then
                                b.Valor = ""
                            Else
                                b.Valor = VaTime(row(b.NombreCampo)).ToString("HH:mm:ss")
                            End If

                        Case TiposCampo.FechaHora
                            If row(b.NombreCampo) Is DBNull.Value Then
                                b.Valor = ""
                            Else
                                b.Valor = VaTime(row(b.NombreCampo)).ToString("dd/MM/yyyy HH:mm:ss")
                            End If


                        Case Else
                            If row(b.NombreCampo) Is DBNull.Value Then
                                b.Valor = ""
                            Else
                                b.Valor = row(b.NombreCampo).ToString
                            End If

                    End Select

                Next
                Vacia = False


            Catch ex As Exception
                err.Muestraerror("Error al cargar los campos en la Entidad " & NombreTabla, "CargaCampos", ex.Message)


            End Try

        End Sub

        Public Overridable Function ValorCampoTxt(ByVal NombreCampo As String) As String
            ' devuelve el valor del campo nombrecampo
            Dim v As String = ""
            For Each b As bdcampo In MiListadeCampos
                If b.NombreCampo = NombreCampo Then
                    v = b.Valor

                End If
            Next
            Return v
        End Function

        Public Overridable Function ClavePrimaria() As bdcampo
            Dim v As bdcampo = Nothing
            For Each b As bdcampo In MiListadeCampos
                If b.Primary = True Then
                    v = b

                End If
            Next
            Return v
        End Function
        Public Overridable Sub AsignarClavePrimaria(ByVal id As String)

            For Each b As bdcampo In MiListadeCampos
                If b.Primary = True Then
                    b.Valor = id

                End If
            Next
        End Sub

        Public Overridable Function Insertar() As Boolean


            Dim ERR As New Errores




            Dim CadenaInicial As String = "INSERT INTO " & NombreTabla & " ("
            Dim CadenaValores As String = ""


            If Vacia = False Then
                MsgBox(NombreTabla & " no se ha inicializado antes de la insercion ")
            End If

            Try


                ' Recorremos todos los campos para is asignadole valores
                For Each ibdCampo As bdcampo In MiListadeCampos()

                    If Len(ibdCampo.NombreCampo) > 3 Then
                        If Mid(ibdCampo.NombreCampo, 4).ToUpper = "_IDUSUARIOLOG" Then
                            ibdCampo.Valor = Idusuario.ToString
                        End If
                        If Mid(ibdCampo.NombreCampo, 4).ToUpper = "_FECHALOG" Then
                            'ibdCampo.Valor = Now.ToString
                            ibdCampo.Valor = FechaLogToString(Now)
                        End If
                        If Mid(ibdCampo.NombreCampo, 4).ToUpper = "_HORALOG" Then
                            ibdCampo.Valor = Now.ToString("HH:mm:ss")
                        End If

                    End If

                    Try
                        CadenaValores = CadenaValores & ValorCampo(ibdCampo) + ","
                    Catch ex As Exception
                        Throw New Exception
                    End Try
                    CadenaInicial = CadenaInicial & ibdCampo.NombreCampo & ","

                Next

                CadenaInicial = CadenaInicial.Substring(0, CadenaInicial.Length - 1) & ") VALUES ("
                CadenaValores = CadenaValores.Substring(0, CadenaValores.Length - 1) & ")"

                'MsgBox(CadenaInicial + CadenaValores)
                'Return True

                Dim resultado As Boolean = MiConexion.OrdenSql(CadenaInicial + CadenaValores)

                If resultado = True Then
                    RaiseEvent ActualizaHijos(True)

                    'LoguearXEntidad("A")

                    AlertaInsertar(Me.NombreTabla)
                End If
                Vacia = False
                Return resultado

            Catch ex As Exception
                err.Muestraerror("Error al insertar en la Entidad " & NombreTabla, "Function Insertar() As Boolean", CadenaInicial + CadenaValores)
                Return False
            End Try

        End Function


        Public Overridable Function FechaLogToString(Fecha As DateTime) As String

            Return Fecha.ToString

        End Function



        ''' <summary>
        ''' Funcion de Update, toma los valores dados a la clase
        ''' </summary>
        ''' <returns>True se ha insertado con exito, False ha ocurrido algun error</returns>
        ''' <remarks>Permite sobreescribir y sobrecargar</remarks>
        Public Overridable Function Actualizar() As Boolean
            Try
                Dim CadenaInicial As String = "UPDATE " & NombreTabla
                Dim CadenaValores As String = " SET "
                Dim CadenaWhere As String = " WHERE ("

                For Each ibdCampo As bdcampo In MiListadeCampos()
                    CadenaValores = CadenaValores & ibdCampo.NombreCampo & "=" & ValorCampo(ibdCampo) + ","

                    If ibdCampo.Primary Then
                        CadenaWhere = CadenaWhere & ibdCampo.NombreCampo & "=" & ValorCampo(ibdCampo) & " AND "
                    End If
                Next

                CadenaValores = CadenaValores.Substring(0, CadenaValores.Length - 1)
                CadenaWhere = CadenaWhere.Substring(0, CadenaWhere.Length - 4) & ")"

                ' MsgBox(CadenaInicial + CadenaValores + CadenaWhere)
                Dim resultado As Boolean
                If MiConexion.OrdenSql(CadenaInicial + CadenaValores + CadenaWhere) Then
                    RaiseEvent ActualizaHijos(False)


                    resultado = True

                    ' LoguearXEntidad("M")


                Else
                    resultado = False

                End If

                Return resultado
            Catch ex As Exception
                err.Muestraerror("Error al actualizar en la Entidad " & NombreTabla, "Function Actualizar() As Boolean", ex.Message)
                Return False
            End Try

        End Function

        ''' <summary>
        ''' Funcion de Delete, toma los valores dados a la clase
        ''' </summary>
        ''' <returns>True se ha insertado con exito, False ha ocurrido algun error</returns>
        ''' <remarks>Permite sobreescribir y sobrecargar</remarks>
        Public Overridable Function Eliminar() As Boolean

            Try
                Dim CadenaInicial As String = "DELETE FROM " & NombreTabla
                Dim CadenaWhere As String = " WHERE ("
                For Each ibdCampo As bdcampo In MiListadeCampos()
                    ' En caso de que sea un valor primary se le asigna al where
                    If ibdCampo.Primary Then
                        CadenaWhere = CadenaWhere + ibdCampo.NombreCampo & "=" & ValorCampo(ibdCampo) & " AND "
                    End If
                Next

                CadenaWhere = CadenaWhere.Substring(0, CadenaWhere.Length - 4) & ")"

                Dim resultado As Boolean



                resultado = MiConexion.OrdenSql(CadenaInicial + CadenaWhere)

                If resultado = True Then
                    RaiseEvent EliminaHijos()
                    'LoguearXEntidad("B")
                    alertaeliminar(Me.NombreTabla)
                    VaciaEntidad()
                End If
                Return resultado

            Catch ex As Exception
                err.Muestraerror("Error al eliminar en la Entidad " & NombreTabla, "Function Eliminar() As Boolean", ex.Message)
                Return False
            End Try

        End Function

        Public Function ValorCampo(ByVal campo As bdcampo) As String
            Return SqlCampo(campo.Valor, campo.TipoBd)
        End Function
        Public Function SqlCampo(ByVal Dato As String, ByVal Tipo As Cdatos.TiposCampo) As String

            ' devuelve el campo formateado  para asignar el valor a la bd 
            Dim Micaracter As String = ""

            Dim Cadenacampo As String = ""
            Select Case Tipo
                Case TiposCampo.Fecha
                    If IsDate(Dato) Then
                        Cadenacampo = Dato
                    Else
                        Cadenacampo = "01/01/1900"
                    End If
                    Micaracter = "'"
                Case TiposCampo.Hora
                    If IsDate(Dato) Then
                        Cadenacampo = VaTime(Dato).ToString("HH:mm:ss")
                    Else
                        Cadenacampo = "00:00:00"
                    End If
                    Micaracter = "'"

                Case TiposCampo.FechaHora
                    If IsDate(Dato) Then
                        Cadenacampo = VaTime(Dato).ToString("dd/MM/yyyy HH:mm:ss")
                    Else
                        Cadenacampo = "01/01/1900 00:00:00"
                    End If
                    Micaracter = "'"

                Case TiposCampo.Importe, TiposCampo.Entero, TiposCampo.EnteroPositivo
                    If Dato Is Nothing Or Dato = "" Then
                        Dato = "0"
                    ElseIf Funciones.VaDec(Dato) = 0 Then
                        Dato = "0"
                    End If
                    Cadenacampo = Dato
                    Cadenacampo = Dato.Replace(".", "")
                    Cadenacampo = Cadenacampo.Replace(",", ".")

                    Micaracter = ""
                Case Else
                    If Dato Is Nothing Then
                        Dato = ""
                    End If
                    Cadenacampo = Dato
                    Cadenacampo = Dato.Replace("'", "")

                    Micaracter = "'"


            End Select
            Return Micaracter & Cadenacampo & Micaracter
        End Function

        Public Overridable Function MaxId(Optional ByVal v As Integer = 0) As Integer
            Try

                Dim max As Integer = 0
                Dim existe As Boolean = True


                While existe = True
                    max = ValorMaximo("", v)
                    existe = ExisteId(max.ToString)

                End While
                'VaciaEntidad
                Return max

            Catch ex As Exception
                err.Muestraerror("No se pudo obtener el maximo", "Function ObtieneMax() As Integer", ex.Message)
                Return 0
            End Try
        End Function
        Public Function ValorMaximo(ByVal tipocontador As String, Optional ByVal numeromaximo As Integer = 0) As Integer
            Dim resultado As Integer = 0

            Select Case tipocontador
                Case ""
                    If CampoContador <> "" Then
                        resultado = ObtieneContadorTabla(numeromaximo)
                    Else
                        resultado = ObtieneContador(Me.NombreTabla, tipocontador, Me.Usuario, numeromaximo)
                    End If
                Case Else
                    resultado = ObtieneContador(Me.NombreTabla, tipocontador, Me.Usuario, numeromaximo)

            End Select
            If numeromaximo > 0 Then
                Return numeromaximo + 1
            Else
                Return resultado
            End If
        End Function


        Public Overridable Function ObtieneContador(ByVal nombreTabla As String, ByVal TipoContador As String, ByVal idUsuario As Integer, Optional ByVal ultimo As Integer = 0) As Integer

            Try
                Dim resultado As Integer = 0
                Dim dt As New DataTable
                Dim consulta As String = ""
                Dim v As Integer = 0

                If ultimo <> 0 Then
                    If ultimo = -1 Then ' BORRA EL CONTADOR
                        ultimo = 0
                    End If
                    v = Vcontador(TipoContador)
                    If v >= 0 Then
                        MiConexion.OrdenSql("Update Contadores set " & PrefijoContador & "UltimoNumero=" & ultimo.ToString & ", " & PrefijoContador & "IdUsuario=" & idUsuario.ToString & " WHERE " & PrefijoContador & "NombreTabla='" & nombreTabla & "' AND " & PrefijoContador & "TipoContador='" & TipoContador & "'")
                    Else
                        MiConexion.OrdenSql("Insert Into Contadores (" & PrefijoContador & "NombreTabla, " & PrefijoContador & "TipoContador, " & PrefijoContador & "UltimoNumero, " & PrefijoContador & "IdUsuario) VALUES ('" & nombreTabla & "','" & TipoContador & "'," & ultimo.ToString & "," & idUsuario.ToString & ")")
                    End If
                    Return ultimo
                End If

                v = Vcontador(TipoContador)

                If v >= 0 Then
                    resultado = v + 1
                    MiConexion.OrdenSql("Update Contadores set " & PrefijoContador & "UltimoNumero=" & resultado.ToString & ", " & PrefijoContador & "IdUsuario=" & idUsuario.ToString & " WHERE " & PrefijoContador & "NombreTabla='" & nombreTabla & "' AND " & PrefijoContador & "TipoContador='" & TipoContador & "'")
                Else
                    MiConexion.OrdenSql("Insert Into Contadores (" & PrefijoContador & "NombreTabla, " & PrefijoContador & "TipoContador, " & PrefijoContador & "UltimoNumero, " & PrefijoContador & "IdUsuario) VALUES ('" & nombreTabla & "','" & TipoContador & "',1," & idUsuario.ToString & ")")
                    resultado = 1
                End If

                dt = New DataTable
                consulta = "Select " & PrefijoContador & "IdUsuario From Contadores WHERE " & PrefijoContador & "NombreTabla='" & nombreTabla & "' AND " & PrefijoContador & "TipoContador='" & TipoContador & "'"
                dt = MiConexion.ConsultaSQL(consulta)
                Dim e As Boolean = False

                If dt.Rows.Count > 0 Then
                    If dt.Rows(0)(0) IsNot DBNull.Value Then
                        If CInt(dt.Rows(0)(0)) = idUsuario Then
                            e = True
                        End If
                    End If
                End If

                If e = False Then
                    Return ObtieneContador(nombreTabla, TipoContador, idUsuario)
                Else
                    Return resultado
                End If

            Catch ex As Exception
                err.Muestraerror(ex.Message, "ObtieneContador", ex.Message)
                Return 0
            End Try

        End Function

        Public Overridable Function Vcontador(ByVal TipoContador) As Integer
            Dim resultado As Integer = 0
            Dim dt As New DataTable
            Dim consulta As String = ""

            dt = New DataTable
            consulta = "Select " & PrefijoContador & "UltimoNumero From Contadores WHERE " & PrefijoContador & "NombreTabla='" & NombreTabla & "' AND " & PrefijoContador & "TipoContador='" & TipoContador & "'"
            dt = MiConexion.ConsultaSQL(consulta)

            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    Return CInt(dt.Rows(0)(0))
                Else

                    Return -1
                End If
            Else
                Return -1
            End If




        End Function
        Public Function ObtieneContadorTabla(Optional ByVal ultimo As Integer = 0) As Integer

            ' el contador se guarda en el campo campocontador de la entidad con la clave = 0
            Try
                Dim resultado As Integer = 0
                Dim dt As New DataTable
                Dim consulta As String = ""

                Dim e As Boolean

                If ultimo <> 0 Then
                    If ultimo = -1 Then
                        ultimo = 0
                    End If


                    e = LeerId("0")
                    For Each c As bdcampo In Me.ListadeCampos
                        If c.NombreCampo = CampoContador Then
                            c.Valor = ultimo.ToString
                        Else
                            c.Valor = ""
                        End If
                    Next
                    If e = True Then
                        Actualizar()
                    Else
                        Insertar()
                    End If

                    Return ultimo
                End If

                e = LeerId(0)
                For Each c As bdcampo In Me.ListadeCampos
                    If c.NombreCampo = CampoContador Then
                        c.Valor = (VaInt(c.Valor) + 1).ToString
                        resultado = VaInt(c.Valor)
                    Else
                        c.Valor = ""
                    End If
                Next

                If resultado = 0 Then
                    MsgBox("no se encontro el campo " & CampoContador)
                End If
                If e = True Then
                    Actualizar()
                Else
                    Insertar()
                End If


                Me.VaciaEntidad()

                Return resultado

            Catch ex As Exception
                err.Muestraerror(ex.Message, "ObtieneContadortabla", ex.Message)
                Return 0
            End Try

        End Function

        Public Function ExisteId(ByVal id As String) As Boolean

            Dim Err As New Errores
            ' leer el registro y lo carga en la entidad por una id
            Try
                Dim CadenaInicial As String = "SELECT * FROM " & NombreTabla
                Dim CadenaWhere As String = " WHERE ("

                For Each ibdCampo As bdcampo In MiListadeCampos()

                    If ibdCampo.Primary Then
                        ibdCampo.Valor = id
                        CadenaWhere = CadenaWhere & ibdCampo.NombreCampo & "=" & ValorCampo(ibdCampo) & " AND "
                    End If
                Next

                CadenaWhere = CadenaWhere.Substring(0, CadenaWhere.Length - 4) & ")"

                ' MsgBox(CadenaInicial + CadenaValores + CadenaWhere)
                Dim resultado As Boolean
                Dim Dt As New DataTable
                Dt = MiConexion.ConsultaSQL(CadenaInicial + CadenaWhere)
                If Dt.Rows.Count > 0 Then
                    resultado = True
                Else
                    resultado = False
                End If

                Return resultado
            Catch ex As Exception
                Err.Muestraerror("Error al LEER ID en la Entidad " & NombreTabla, "Function LeerId() As Boolean", ex.Message)
                Return False
            End Try




        End Function



        'Public Sub LoguearXFormulario(ByVal operacion As String)

        '    Dim vclave As String
        '    Dim Dreg As String

        '    If NombreTabla.ToLower = "logusuarios" Then Exit Sub
        '    If NombreTabla.ToLower = "contadores" Then Exit Sub
        '    If ValorClavePrimaria() = "0" Then Exit Sub
        '    If DcLogTablas.ContainsKey(NombreTabla.ToLower.Trim) = False Then Exit Sub

        '    Static Utabla As String ' GUARDO LOS ULTIMOS DATOS PARA NO GENERAR REGISTROS DUPLICADOS EN LAS MODIFICACIONES
        '    Static UClave As String
        '    Static Udatos As String


        '    vclave = ValorClavePrimaria()
        '    Dreg = Datosreg()

        '    If operacion = "M" Then
        '        If Utabla = NombreTabla And UClave = vclave And Udatos = Dreg Then
        '            Exit Sub
        '        End If
        '    End If



        '    Dim Log As New E_Logusuarios(Idusuario, CnComun)

        '    Log.Id.Valor = Log.MaxId
        '    Log.Iduser.Valor = Usuario
        '    Log.Fecha.Valor = Now.ToString("dd/MM/yyyy")
        '    Log.hora.Valor = Format(TimeOfDay, "HH:mm:ss")
        '    Log.operacion.Valor = operacion
        '    Log.idaplicacion.Valor = Idaplicacion.ToString
        '    Log.tabla.Valor = NombreTabla
        '    Log.clave.Valor = vclave
        '    Log.datosregistro.Valor = Dreg
        '    Log.Insertar()

        '    Utabla = NombreTabla
        '    UClave = vclave
        '    Udatos = Dreg

        'End Sub


        Public Sub LoguearXFormulario(ByVal operacion As String)

            Dim vclave As String
            Dim Dreg As String

            If NombreTabla.ToLower = "logusuariosapl" Then Exit Sub
            If NombreTabla.ToLower = "contadores" Then Exit Sub
            If ValorClavePrimaria() = "0" Then Exit Sub
            If DcLogTablas.ContainsKey(NombreTabla.ToLower.Trim) = False Then Exit Sub

            Static Utabla As String ' GUARDO LOS ULTIMOS DATOS PARA NO GENERAR REGISTROS DUPLICADOS EN LAS MODIFICACIONES
            Static UClave As String
            Static Udatos As String


            vclave = ValorClavePrimaria()
            Dreg = Datosreg()

            If operacion = "M" Then
                If Utabla = NombreTabla And UClave = vclave And Udatos = Dreg Then
                    Exit Sub
                End If
            End If



            Dim Log As New E_LogusuariosApl(Idusuario, cn)

            Log.Id.Valor = Log.MaxId
            Log.Iduser.Valor = Usuario
            Log.Fecha.Valor = Now.ToString("dd/MM/yyyy")
            Log.hora.Valor = Format(TimeOfDay, "HH:mm:ss")
            Log.operacion.Valor = operacion
            Log.idaplicacion.Valor = Idaplicacion.ToString
            Log.tabla.Valor = NombreTabla
            Log.clave.Valor = vclave
            Log.datosregistro.Valor = Dreg
            Log.Insertar()

            Utabla = NombreTabla
            UClave = vclave
            Udatos = Dreg

        End Sub


        'Public Sub LoguearXEntidad(ByVal operacion As String)

        '    Dim vclave As String
        '    Dim Dreg As String

        '    If NombreTabla.ToLower = "logusuarios" Then Exit Sub
        '    If NombreTabla.ToLower = "contadores" Then Exit Sub
        '    If ValorClavePrimaria() = "0" Then Exit Sub
        '    If DcLogTablas.ContainsKey(NombreTabla.ToLower.Trim) = False Then Exit Sub

        '    Static Utabla As String ' GUARDO LOS ULTIMOS DATOS PARA NO GENERAR REGISTROS DUPLICADOS EN LAS MODIFICACIONES
        '    Static UClave As String
        '    Static Udatos As String


        '    vclave = ValorClavePrimaria()
        '    Dreg = Datosreg()

        '    If operacion = "M" Then
        '        If Utabla = NombreTabla And UClave = vclave And Udatos = Dreg Then
        '            Exit Sub
        '        End If
        '    End If



        '    Dim Log As New E_Logusuarios(Idusuario, CnComun)

        '    Log.Id.Valor = Log.MaxId
        '    Log.Iduser.Valor = Usuario
        '    Log.Fecha.Valor = Now.ToString("dd/MM/yyyy")
        '    Log.hora.Valor = Format(TimeOfDay, "HH:mm:ss")
        '    Log.operacion.Valor = operacion
        '    Log.idaplicacion.Valor = Idaplicacion.ToString
        '    Log.tabla.Valor = NombreTabla
        '    Log.clave.Valor = vclave
        '    Log.datosregistro.Valor = Dreg
        '    Log.Insertar()

        '    Utabla = NombreTabla
        '    UClave = vclave
        '    Udatos = Dreg

        'End Sub


        Private Sub AlertaInsertar(ByVal Tabla As String)
            If DcAltTablas.ContainsKey(NombreTabla.ToLower.Trim) = False Then Exit Sub
            Dim Alertas As New E_Alertas(Idusuario, cn)
            Alertas.NuevaAlerta("Nuevo registro en " & Tabla & ". Id: " & Me.ClavePrimaria.Valor)

            'MsgBox("Alerta insertar " & Tabla)
        End Sub
        Private Sub AlertaEliminar(ByVal Tabla As String)
            If DcAltTablas.ContainsKey(NombreTabla.ToLower.Trim) = False Then Exit Sub
            Dim Alertas As New E_Alertas(Idusuario, cn)
            Alertas.NuevaAlerta("Baja registro en " & Tabla & ". Id: " & Me.ClavePrimaria.Valor)

            'MsgBox("Alerta insertar " & Tabla)
        End Sub

        'Public Function Datosreg() As String
        '    Dim ret As String = ""

        '    For Each c As bdcampo In Me.MiListadeCampos
        '        ret = ret & c.Valor & "|"
        '    Next


        '    Return ret


        'End Function

        Public Function Datosreg() As String
            Dim ret As String = ""

            For Each c As bdcampo In Me.MiListadeCampos
                If c.Longitud < 512 Then
                    ret = ret & c.Valor & "|"
                Else
                    ret = ret + "|"
                End If
            Next


            Return ret


        End Function

        Public Function ValorClavePrimaria() As String
            Dim ret As String = ""

            For Each c As bdcampo In Me.MiListadeCampos
                If c Is ClavePrimaria() Then
                    ret = ClavePrimaria.Valor
                End If
            Next


            Return ret


        End Function


        'Public Overridable Sub Actualizame(constructor As ActuBdFinanciero.Constructor.Cl_ConstructorConsultas)

        '    If CreaTablaEntidad(Me, constructor) = False Then
        '        err.Muestraerror("No se ha podido realizar la actualización de la entidad", "Actualizame", "Error al realizar la actualización de los campos de la entidad " & Me.NombreTabla)
        '    End If

        '    If CreaCamposEntidad(Me, constructor) = False Then
        '        err.Muestraerror("No se ha podido realizar la actualización de la entidad", "Actualizame", "Error al realizar la actualización de la tabla de la entidad " & Me.NombreTabla)
        '    End If

        'End Sub

    End Class






    Public Shared Function ListaEntidades() As List(Of Entidad)

        Dim asm As Assembly = Reflection.Assembly.GetExecutingAssembly
        Dim _listaEntidades As New List(Of Entidad)

        Dim p As New List(Of Object)
        p.Add(Idusuario)
        p.Add(cn)


        For Each ty As Type In asm.GetTypes

            Dim NombreFormulario As Type = asm.GetType(ty.FullName)

            If Not NombreFormulario.FullName.StartsWith("Microsoft.") Then

                If ty.BaseType.Name.ToLower = "entidad" Then
                    Try
                        Dim tipoEntidad As Type = asm.GetType(ty.FullName)
                        Dim e As Entidad = DirectCast(Activator.CreateInstance(tipoEntidad, p.ToArray), Cdatos.Entidad)
                        _listaEntidades.Add(e)
                    Catch ex As Exception
                        Throw New Exception("No se han podido cargar las entidades")
                    End Try
                End If
            End If

        Next


        Return _listaEntidades

    End Function

    Public Shared Function ListaRelaciones() As List(Of CamposRelacion)
        Dim _listarelaciones As New List(Of CamposRelacion)
        For Each ENTI As Cdatos.Entidad In Cdatos.ListaEntidades
            For Each CAMPO As Cdatos.bdcampo In ENTI.ListadeCampos
                If Not CAMPO.EnlaceId Is Nothing Then
                    Dim Relacion As New Cdatos.CamposRelacion

                    Relacion.Origen = CAMPO.EnlaceId
                    Relacion.Destino = CAMPO
                    _listarelaciones.Add(Relacion)


                End If

            Next
        Next
        Return _listarelaciones
    End Function





End Class




