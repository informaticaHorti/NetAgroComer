Imports System.Reflection
Imports NetAgro.Constructor




Public Class Actualizador

    Private Enum TipoActualizacion
        CrearTabla
        CrearCampo
        LongitudCampo
        BorrarCampo
        InstruccionSQL
        CrearIndice
    End Enum


    Private Class Actualizacion

        Public _TipoActualizacion As TipoActualizacion
        Public _Entidad As Cdatos.Entidad
        Public _Campo As Cdatos.bdcampo
        Public _ValorDefectoCampo As String = Nothing
        Public _NombreTabla As String = ""
        Public _NombreCampo As String = ""
        Public _Sql As String = ""
        Public _lstIndices As List(Of Cdatos.bdcampo)
        Public _NombreIndice As String = ""


        Public Sub New(t As TipoActualizacion, obj As Object, Optional ValorDefectoCampo As String = Nothing, Optional sqlCrearCampo As String = "")

            _TipoActualizacion = t

            If TypeOf obj Is Cdatos.Entidad Then
                _Entidad = obj
                'If Not IsNothing(ValorDefectoCampo) Then
                '    Throw New ExcepcionActualizacion("El valor por defecto no es aplicable a la creación de entidades")
                'End If
                _Sql = ValorDefectoCampo
            ElseIf TypeOf obj Is Cdatos.bdcampo Then
                _Campo = obj
                _ValorDefectoCampo = ValorDefectoCampo
                _Sql = sqlCrearCampo
            ElseIf t = TipoActualizacion.InstruccionSQL Then
                _Sql = obj
            End If

        End Sub


        Public Sub New(t As TipoActualizacion, NombreTabla As String, NombreCampo As String)

            _TipoActualizacion = t

            If NombreTabla.Trim = "" Or NombreCampo.Trim = "" Then
                Throw New ExcepcionActualizacion("Deben especificarse el nombre de la tabla y el nombre del campo a borrar")
            End If

            _NombreTabla = NombreTabla
            _NombreCampo = NombreCampo

        End Sub


        Public Sub New(t As TipoActualizacion, lst As List(Of Cdatos.bdcampo), Optional ValorDefectoCampo As String = Nothing)

            _TipoActualizacion = t

            _lstIndices = lst
            _NombreIndice = ValorDefectoCampo

        End Sub


    End Class



    Private _Director As Cl_DirectorActualizaciones = New Cl_DirectorActualizaciones
    Private _Constructor As Cl_ConstructorConsultas = Nothing
    Private _ListaActualizaciones As New List(Of Actualizacion)



    Private _TipoConexion As Tipo_Conexion
    Public ReadOnly Property TipoConexion As Tipo_Conexion
        Get
            Return _TipoConexion
        End Get
    End Property
    Private _TipoProveedor As Tipo_Conexion

    Public ReadOnly Property TipoProveedor As Tipo_Conexion
        Get
            Return _TipoProveedor
        End Get
    End Property



    Public Sub New(conexion As Cdatos.Conexion, Optional TipoConexion As Tipo_Conexion = Tipo_Conexion.SqlServer,
                   Optional TipoProveedor As Tipo_Proveedor = Tipo_Proveedor.Odbc)

        _TipoConexion = TipoConexion
        _TipoProveedor = TipoProveedor

        Dim cadena As String = conexion.CadenaConexion
        _Constructor = _Director.AñadirConstructor(TipoConexion, TipoProveedor, cadena)

    End Sub



    Public Sub CreaTabla(Entidad As Cdatos.Entidad, Optional InstruccionSql As String = "")

        Dim Actualizacion As New Actualizacion(TipoActualizacion.CrearTabla, Entidad, InstruccionSql)
        _ListaActualizaciones.Add(Actualizacion)

    End Sub

    Public Sub CreaCampo(Campo As Cdatos.bdcampo, Optional ValorDefecto As String = Nothing, Optional sql As String = "")

        Dim Actualizacion As New Actualizacion(TipoActualizacion.CrearCampo, Campo, ValorDefecto, sql)
        _ListaActualizaciones.Add(Actualizacion)

    End Sub

    Public Sub LongitudCampo(Campo As Cdatos.bdcampo)

        Dim Actualizacion As New Actualizacion(TipoActualizacion.LongitudCampo, Campo)
        _ListaActualizaciones.Add(Actualizacion)

    End Sub

    Public Sub BorraCampo(NombreTabla As String, NombreCampo As String)

        Dim Actualizacion As New Actualizacion(TipoActualizacion.BorrarCampo, NombreTabla, NombreCampo)
        _ListaActualizaciones.Add(Actualizacion)

    End Sub


    Public Sub CreaIndice(Campo As Cdatos.bdcampo, NombreIndice As String)

        Dim lst As New List(Of Cdatos.bdcampo)
        lst.Add(Campo)

        CreaIndice(lst, NombreIndice)

    End Sub


    Public Sub CreaIndice(lstCampos As List(Of Cdatos.bdcampo), NombreIndice As String)

        Dim Actualizacion As New Actualizacion(TipoActualizacion.CrearIndice, lstCampos, NombreIndice)
        _ListaActualizaciones.Add(Actualizacion)

    End Sub


    Public Sub InstruccionSQL(sql As String)

        Dim Actualizacion As New Actualizacion(TipoActualizacion.InstruccionSQL, sql)
        _ListaActualizaciones.Add(Actualizacion)

    End Sub



    Public Function RealizaActualizaciones() As Boolean

        Dim resultado As Boolean = False


        Dim bCancelado As Boolean = False
        While Not resultado And Not bCancelado

            'Pone a 0 las actualizaciones
            BorrarActualizaciones()
            CargaActualizaciones()

            'Muestra el formulario con las sentencias SQL. Si el actualizador es nothing, significa que no hay actualizaciones pendientes
            If Not IsNothing(_Director) Then
                resultado = _Director.ActuVersion(bCancelado)
            Else
                resultado = True
            End If

        End While



        Return resultado

    End Function


    Private Sub BorrarActualizaciones()

        If Not IsNothing(_Director) Then

            For Each constructor As Cl_ConstructorConsultas In _Director.Constructor
                constructor.BorrarConsultas()
            Next

        End If

    End Sub


    'Public Function CadenaODBC_OLEDB(ByVal CadenaConexionActualizacion) As String


    '    Dim Dc As New Dictionary(Of String, String)

    '    Dim parametros As String() = CadenaConexionActualizacion.Split(Convert.ToChar(";"))
    '    For Each parametro As String In parametros
    '        Dim par As String() = parametro.Split(Convert.ToChar("="))
    '        If par.Length = 2 Then
    '            Dc(par(0).ToLower) = par(1)
    '        End If
    '    Next

    '    Dim Provider As String = "Provider=SQLOLEDB.1;"
    '    Dim ds As String = ""
    '    Dim uid As String = ""
    '    Dim pwd As String = ""
    '    Dim ic As String = ""


    '    If Dc.ContainsKey("server") Then ds = Dc("server")
    '    If Dc.ContainsKey("uid") Then uid = Dc("uid")
    '    If Dc.ContainsKey("pwd") Then pwd = Dc("pwd")
    '    If Dc.ContainsKey("database") Then ic = Dc("database")


    '    Dim conn_str As String = Provider & "Data Source=" & ds & ";User ID=" & uid & ";Initial Catalog=" & ic & ";password=" & pwd
    '    Return conn_str

    'End Function


    Private Sub CargaActualizaciones()

        If Not IsNothing(_Constructor) Then

            For Each Actualizacion As Actualizacion In _ListaActualizaciones

                Select Case Actualizacion._TipoActualizacion

                    Case TipoActualizacion.CrearTabla
                        CargaCrearTabla(Actualizacion._Entidad, Actualizacion._Sql)
                    Case TipoActualizacion.CrearCampo
                        If Actualizacion._Campo.NombreCampo.ToLower = "agr_iban" Then
                            Dim a As String = ""
                        End If
                        CargaCrearCampo(Actualizacion._Campo, Actualizacion._ValorDefectoCampo, Actualizacion._Sql)
                    Case TipoActualizacion.LongitudCampo
                        CargaLongitudCampo(Actualizacion._Campo)
                    Case TipoActualizacion.BorrarCampo
                        CargaBorrarCampo(Actualizacion._NombreTabla, Actualizacion._NombreCampo)
                    Case TipoActualizacion.InstruccionSQL
                        CargaInstruccionSQL(Actualizacion._Sql)
                    Case TipoActualizacion.CrearIndice
                        CargaCrearIndice(Actualizacion._lstIndices, Actualizacion._NombreIndice)

                End Select

            Next

        End If


    End Sub


    Private Function CargaCrearTabla(Entidad As Cdatos.Entidad, InstruccionSQL As String) As Boolean

        Try

            If Not _Constructor.ExisteTabla(Entidad.NombreTabla) Then

                Dim lista As List(Of Cdatos.bdcampo) = Entidad.MiListadeCampos
                Dim ListaCl As New List(Of Cl_Campo)
                Dim clPrimaria As Cl_ClavePrimaria = Nothing
                Dim camposPrimarios As String = ""

                For Each bdc As Cdatos.bdcampo In lista

                    Dim tipo As Tipo_Campo = Tipo_Campo.Tipo_nvarchar
                    Dim longitud As Integer = -1
                    Dim Decimales As Integer = -99999
                    If bdc.Primary Then
                        camposPrimarios = camposPrimarios & "," & bdc.NombreCampo
                    End If


                    Select Case bdc.TipoBd

                        Case Cdatos.TiposCampo.Cadena, Cdatos.TiposCampo.CadenaNumero, Cdatos.TiposCampo.Cuenta, Cdatos.TiposCampo.CuentaCliente
                            tipo = Tipo_Campo.Tipo_nvarchar
                            longitud = bdc.Longitud

                        Case Cdatos.TiposCampo.Entero, Cdatos.TiposCampo.EnteroPositivo
                            tipo = Tipo_Campo.Tipo_integer

                        Case Cdatos.TiposCampo.Importe
                            tipo = Tipo_Campo.Tipo_decimal
                            longitud = bdc.Longitud
                            Decimales = bdc.Decimales

                        Case Cdatos.TiposCampo.Fecha
                            tipo = Tipo_Campo.Tipo_date

                        Case Cdatos.TiposCampo.Hora, Cdatos.TiposCampo.FechaHora
                            tipo = Tipo_Campo.Tipo_datetime

                    End Select

                    ListaCl.Add(New Cl_Campo(bdc.NombreCampo, tipo, longitud, Decimales))

                Next
                camposPrimarios = camposPrimarios.Remove(0, 1)

                clPrimaria = New Cl_ClavePrimaria("pk_" & Entidad.NombreTabla, camposPrimarios)



                If clPrimaria IsNot Nothing Then

                    Try
                        Dim tabla As New Cl_Tabla(Entidad.NombreTabla, ListaCl, clPrimaria)
                        _Constructor.AñadirConsulta(_Constructor.SQLCrearTabla(tabla))

                        If InstruccionSQL.trim <> "" Then
                            _Constructor.AñadirConsulta(InstruccionSQL)
                        End If

                    Catch ex As ExcepcionActualizacion
                        Return False
                    End Try

                Else
                    Return False
                End If

                Return True

            Else
                'No ha podido crearla, ya existe
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function



    Public Function CargaCrearCampo(ByVal Campo As Cdatos.bdcampo, Optional ValorDefectoCampo As String = Nothing, Optional InstruccionSql As String = "") As Boolean


        Try

            If Campo.NombreCampo.ToLower = "agr_iban" Then
                Dim a As String = ""
            End If

            If IsNothing(Campo.MiEntidad) Then Throw New Exception("No se puede crear el campo si no está asociado a una entidad: propiedad MiEntidad vacía.")

            Dim Entidad As Cdatos.Entidad = Campo.MiEntidad


            Dim ListaBDCampos As List(Of Cdatos.bdcampo) = Entidad.MiListadeCampos
            Dim ListaOCampos As New List(Of Constructor.Cl_Campo)
            Dim ClPrimaria As Cl_ClavePrimaria = Nothing


            Dim CamposPrimarios As String = ""


            Dim tipo As Tipo_Campo = Tipo_Campo.Tipo_nvarchar
            Dim longitud As Integer = -1
            Dim Decimales As Integer = -99999


            If Campo.Primary Then CamposPrimarios = CamposPrimarios & "," & Campo.NombreCampo

            Select Case Campo.TipoBd

                Case Cdatos.TiposCampo.Cadena, Cdatos.TiposCampo.CadenaNumero, Cdatos.TiposCampo.Cuenta, Cdatos.TiposCampo.CuentaCliente
                    tipo = Constructor.Tipo_Campo.Tipo_nvarchar
                    longitud = Campo.Longitud

                Case Cdatos.TiposCampo.Entero, Cdatos.TiposCampo.EnteroPositivo
                    tipo = Constructor.Tipo_Campo.Tipo_integer

                Case Cdatos.TiposCampo.Importe
                    tipo = Constructor.Tipo_Campo.Tipo_decimal
                    longitud = Campo.Longitud
                    Decimales = Campo.Decimales

                Case Cdatos.TiposCampo.Fecha
                    tipo = Constructor.Tipo_Campo.Tipo_date

                Case Cdatos.TiposCampo.Hora, Cdatos.TiposCampo.FechaHora
                    tipo = Tipo_Campo.Tipo_datetime

            End Select


            If IsNothing(ValorDefectoCampo) Then ValorDefectoCampo = ""
            Dim ClCampo As New Cl_Campo(Campo.NombreCampo, tipo, longitud, Decimales, ValorDefectoCampo)


            If Not _Constructor.ExisteCampo(Entidad.NombreTabla, ClCampo.Nombre) Then

                Try
                    _Constructor.AñadirConsulta(_Constructor.SQLAñadirCampo(Entidad.NombreTabla, ClCampo))

                    If InstruccionSql.Trim <> "" Then
                        _Constructor.AñadirConsulta(InstruccionSql)
                    End If

                Catch ex As ExcepcionActualizacion
                    Return False
                End Try

            Else
                Return False
            End If

            Return True

        Catch ex As Exception
            Return False
        End Try


    End Function


    Public Function CargaBorrarCampo(NombreTabla As String, NombreCampo As String) As Boolean


        Try

            If NombreTabla.Trim = "" Or NombreCampo.Trim = "" Then
                Throw New Exception("Debe especificar el nombre de la tabla y el nombre del campo a borrar.")
            End If


            If _Constructor.ExisteCampo(NombreTabla, NombreCampo) Then

                Try
                    _Constructor.AñadirConsulta(_Constructor.SQLQuitarCampo(NombreTabla, NombreCampo))

                Catch ex As ExcepcionActualizacion
                    Return False
                End Try

            Else
                Return False
            End If

            Return True

        Catch ex As Exception
            Return False
        End Try


    End Function



    Public Function CargaLongitudCampo(ByVal Campo As Cdatos.bdcampo, Optional bVerificarLongitud As Boolean = True) As Boolean

        Try

            Dim longitud As Integer = Campo.Longitud


            If IsNothing(Campo.MiEntidad) Then Throw New Exception("No se puede crear el campo si no está asociado a una entidad: propiedad MiEntidad vacía.")

            Dim Entidad As Cdatos.Entidad = Campo.MiEntidad

            Dim ListaBDCampos As List(Of Cdatos.bdcampo) = Entidad.MiListadeCampos
            Dim ListaOCampos As New List(Of Cl_Campo)
            Dim ClPrimaria As Cl_ClavePrimaria = Nothing


            Dim CamposPrimarios As String = ""


            Dim tipo As Tipo_Campo = Tipo_Campo.Tipo_nvarchar
            Dim Decimales As Integer = -99999

            If Campo.Primary Then CamposPrimarios = CamposPrimarios & "," & Campo.NombreCampo

            Select Case Campo.TipoBd

                Case Cdatos.TiposCampo.Cadena, Cdatos.TiposCampo.CadenaNumero, Cdatos.TiposCampo.Cuenta, Cdatos.TiposCampo.CuentaCliente
                    tipo = Constructor.Tipo_Campo.Tipo_nvarchar

                Case Cdatos.TiposCampo.Entero, Cdatos.TiposCampo.EnteroPositivo
                    tipo = Constructor.Tipo_Campo.Tipo_integer

                Case Cdatos.TiposCampo.Importe
                    tipo = Constructor.Tipo_Campo.Tipo_decimal
                    Decimales = Campo.Decimales

                Case Cdatos.TiposCampo.Fecha
                    tipo = Constructor.Tipo_Campo.Tipo_date

                Case Cdatos.TiposCampo.Hora, Cdatos.TiposCampo.FechaHora
                    tipo = Tipo_Campo.Tipo_datetime

            End Select


            Dim ClCampo As New Constructor.Cl_Campo(Campo.NombreCampo, tipo, Campo.Longitud, Decimales)

            Dim longitud_actual As Integer = 0
            Try
                longitud_actual = _Constructor.ObtenerLongitudCampo(Entidad.NombreTabla, ClCampo.Nombre, ClCampo.oTipo)
            Catch ex As ExcepcionActualizacion
            End Try

            Dim bContinuar As Boolean = False

            If Not bVerificarLongitud Then
                bContinuar = True
            ElseIf longitud_actual < longitud Then
                bContinuar = True
            End If


            If bContinuar Then

                Try

                    _Constructor.AñadirConsulta(_Constructor.SQLModificarCampo(Entidad.NombreTabla, ClCampo))

                Catch ex As ExcepcionActualizacion
                    Return False
                End Try

            End If

            Return True


        Catch ex As Exception
            Return False
        End Try


    End Function


    Public Function CargaInstruccionSQL(sql As String) As Boolean

        Dim res As Boolean = True


        Try

            _Constructor.AñadirConsulta(sql)

        Catch ex As ExcepcionActualizacion
            Return False
        End Try


        Return res

    End Function


    Public Function CargaCrearIndice(lstIndices As List(Of Cdatos.bdcampo), NombreIndice As String) As Boolean

        Try


            If lstIndices.Count = 0 Then
                Throw New Exception("Debe especificar los campos del índice")
            End If


            Dim NombreTabla As String = lstIndices(0).MiEntidad.NombreTabla
            Dim BaseDatos As String = lstIndices(0).MiEntidad.NombreBd

            If Not _Constructor.ExisteConstraint(NombreTabla, NombreIndice) Then


                Try

                    Dim campos As String = ""
                    For Each campo As Cdatos.bdcampo In lstIndices

                        Dim nombre As String = campo.NombreCampo
                        If campos.Trim <> "" Then campos = campos & ", "
                        campos = campos & nombre

                    Next


                    Dim oIndice As New Cl_Indice(NombreIndice, campos)
                    _Constructor.AñadirConsulta(_Constructor.SQLAñadirIndice(NombreTabla, oIndice))


                Catch ex As ExcepcionActualizacion
                    Return False
                End Try

            Else
                Return False
            End If


            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function



End Class


