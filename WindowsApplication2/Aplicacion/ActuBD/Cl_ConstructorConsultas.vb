Imports System.Data.Odbc
Imports System.Data.OleDb
Imports NetAgro.ProveedorDatos

Namespace Constructor

    ' tipo de conexion utilizada
    Public Enum Tipo_Proveedor

        Odbc = 0
        OleDb = 1
        SqlClient = 2

    End Enum

    ' proveedor de base de datos
    Public Enum Tipo_Conexion

        SqlServer = 0
        Firebird = 1
        Pervasive = 2
        Postgre8 = 3
        Postgre9 = 4

    End Enum

    ' tipo de campo
    Public Enum Tipo_Campo

        Tipo_char = 0
        Tipo_varchar = 1
        Tipo_nvarchar = 2

        Tipo_integer = 3
        Tipo_float = 4
        Tipo_double = 5
        Tipo_decimal = 6
        Tipo_numeric = 7

        Tipo_text = 8

        Tipo_date = 9
        Tipo_datetime = 10
        Tipo_blob = 11


    End Enum

    Public Class Cl_Tabla

        Protected _cNombre As String
        Protected _lstCampos As New List(Of Cl_Campo)
        Protected _dicCampos As New Dictionary(Of String, Cl_Campo)
        Protected _oClave As Cl_ClavePrimaria = Nothing
        Protected _dicIndices As New Dictionary(Of String, Cl_Indice)
        Protected _lstIndices As New List(Of Cl_Indice)

        Public ReadOnly Property Nombre
            Get
                Return _cNombre
            End Get
        End Property


        Public ReadOnly Property Campos As List(Of Cl_Campo)
            Get
                Return _lstCampos
            End Get
        End Property


        Public ReadOnly Property Campo As Dictionary(Of String, Cl_Campo)
            Get
                Return _dicCampos
            End Get
        End Property


        Public ReadOnly Property Clave As Cl_ClavePrimaria
            Get
                Return _oClave
            End Get
        End Property


        Public ReadOnly Property Indices As List(Of Cl_Indice)
            Get
                Return _lstIndices
            End Get
        End Property


        Public ReadOnly Property Indice As Dictionary(Of String, Cl_Indice)
            Get
                Return _dicIndices
            End Get
        End Property



        Public Sub New(ByVal nombre_tabla As String, ByVal lstCampos As List(Of Cl_Campo), Optional ByVal clave As Cl_ClavePrimaria = Nothing,
                       Optional ByVal lstIndices As List(Of Cl_Indice) = Nothing)


            _cNombre = nombre_tabla.Trim()
            _lstCampos = lstCampos
            _oClave = clave
            If Not IsNothing(lstIndices) Then _lstIndices = lstIndices


            For Each campo As Cl_Campo In _lstCampos
                _dicCampos(campo.Nombre) = campo
            Next

            For Each indice As Cl_Indice In _lstIndices
                _dicIndices(indice.Nombre) = indice
            Next


        End Sub

    End Class

    Public Class Cl_Indice

        Protected _cNombre As String
        Protected _cCampos As String
        Protected _bClavePrimaria As Boolean = False


        Public ReadOnly Property Nombre As String
            Get
                Return _cNombre
            End Get
        End Property

        Public ReadOnly Property ListaCampos As String
            Get
                Return _cCampos
            End Get
        End Property


        Public ReadOnly Property EsClavePrimaria As Boolean
            Get
                Return _bClavePrimaria
            End Get
        End Property

        Public Sub New(ByVal nombre As String, ByVal campos As String)

            _cNombre = nombre.Trim()
            _cCampos = campos.Trim()

        End Sub

    End Class

    Public Class Cl_ClavePrimaria
        Inherits Cl_Indice


        Public Sub New(ByVal nombre As String, ByVal campos As String)

            MyBase.New(nombre, campos)

            _bClavePrimaria = True

        End Sub

    End Class

    Public Class Cl_Campo

        Public Const NODECIMALES As Integer = -99999
        Public Const NOLONGITUD As Integer = -1

#Region "Variables miembro y propiedades de Cl_Campo"

        Protected _cNombre As String
        Protected _oTipoCampo As Tipo_Campo
        Protected _nLongitud As Integer = 0
        Protected _nNumDecimales As Integer = 0
        Protected _cValorDefecto As String = ""
        Protected _bPermiteNulos As Boolean = False


        Public Property Nombre As String
            Get
                Return _cNombre
            End Get
            Set(ByVal value As String)
                _cNombre = value
            End Set
        End Property

        Public ReadOnly Property oTipo As Tipo_Campo
            Get
                Return _oTipoCampo
            End Get
        End Property


        Public Property Longitud As Integer
            Get
                Return _nLongitud
            End Get
            Set(ByVal value As Integer)
                _nLongitud = value
            End Set
        End Property


        Public Property Decimales As Integer
            Get
                Return _nNumDecimales
            End Get
            Set(ByVal value As Integer)
                _nNumDecimales = value
            End Set
        End Property

        Public ReadOnly Property ValorDefecto As String
            Get
                Return _cValorDefecto
            End Get
        End Property

        Public Property PermiteNulos As Boolean
            Get
                Return _bPermiteNulos
            End Get
            Set(ByVal value As Boolean)
                _bPermiteNulos = value
            End Set
        End Property

        Public ReadOnly Property RequiereLongitud As Boolean
            Get

                Return LongitudRequerida()
            End Get

        End Property

        Public ReadOnly Property UsaTexto As Boolean
            Get

                Return (_oTipoCampo = Tipo_Campo.Tipo_char Or
                        _oTipoCampo = Tipo_Campo.Tipo_varchar Or
                        _oTipoCampo = Tipo_Campo.Tipo_nvarchar Or
                        _oTipoCampo = Tipo_Campo.Tipo_text)

            End Get
        End Property

        Public ReadOnly Property RequiereDecimales As Boolean
            Get
                Return DecimalesRequeridos()
            End Get
        End Property

#End Region

        Public Sub New(ByVal nombre As String, ByVal tipo_campo As Tipo_Campo, Optional ByVal nLongitud As Integer = NOLONGITUD,
                       Optional ByVal nDecimales As Integer = NODECIMALES, Optional ByVal cValorDefecto As String = "",
                       Optional ByVal bPermiteNulos As Boolean = False)

            _cNombre = nombre
            _oTipoCampo = tipo_campo
            _nLongitud = nLongitud
            _nNumDecimales = nDecimales
            If cValorDefecto.Trim() <> "" Then _cValorDefecto = cValorDefecto
            _bPermiteNulos = bPermiteNulos

            If LongitudRequerida() And nLongitud < 0 Then
                Throw New ExcepcionActualizacion("Longitud no definida para el campo: " & nombre)
            End If

            If DecimalesRequeridos() And nDecimales < 0 Then
                Throw New ExcepcionActualizacion("Número de decimales no definidos para el campo: " & nombre)
            End If

        End Sub

        Protected Function LongitudRequerida() As Boolean

            Return (_oTipoCampo = Tipo_Campo.Tipo_char Or
                    _oTipoCampo = Tipo_Campo.Tipo_varchar Or
                    _oTipoCampo = Tipo_Campo.Tipo_nvarchar Or
                    _oTipoCampo = Tipo_Campo.Tipo_decimal Or
                    _oTipoCampo = Tipo_Campo.Tipo_numeric)

        End Function

        Protected Function DecimalesRequeridos() As Boolean

            Return (_oTipoCampo = Tipo_Campo.Tipo_decimal Or
                    _oTipoCampo = Tipo_Campo.Tipo_numeric)

        End Function

    End Class

    Public MustInherit Class Cl_ConstructorConsultas


        'Tipos de campo y valores por defecto
        Public Cadena_Tipo_Campo As String() = {}
        Public Cadena_Valor_Defecto As String() = {}

        'Variables miembro y propiedades
        Protected _lstActualizaciones As New List(Of String)
        Protected _proveedor As Cl_ProveedorDatos = Nothing
        Protected _TipoConexion As Tipo_Conexion = Nothing

        Public ReadOnly Property ErrorConexion As Boolean
            Get

                If Not IsNothing(_proveedor) Then
                    Return _proveedor.ErrorConexion
                Else
                    Return True
                End If

            End Get
        End Property

        Public ReadOnly Property Actualizaciones As List(Of String)
            Get
                Return _lstActualizaciones
            End Get
        End Property


        Public Property TipoConexion As Tipo_Conexion
            Get
                Return _TipoConexion
            End Get
            Set(ByVal value As Tipo_Conexion)
                _TipoConexion = value
            End Set
        End Property

        'Función new
        Public Sub New(ByVal proveedor As Cl_ProveedorDatos)

            _proveedor = proveedor
            _TipoConexion = proveedor.TipoConexion

        End Sub

        'Funciones de comprobación
        Public MustOverride Function ExisteTabla(ByVal nombre_tabla) As Boolean
        Public MustOverride Function ExisteCampo(ByVal nombre_tabla, ByVal nombre_campo) As Boolean
        Public MustOverride Function ObtenerLongitudCampo(ByVal nombre_tabla As String, ByVal nombre_campo As String, ByVal TipoCampo As Tipo_Campo) As Integer
        Public MustOverride Function ObtenerDecimalesCampo(ByVal nombre_tabla As String, ByVal nombre_campo As String, ByVal tipocampo As Tipo_Campo) As Integer
        Public MustOverride Function ExisteConstraint(ByVal nombre_tabla As String, ByVal nombre_indice As String) As Boolean
        Public MustOverride Function ObtenerIndice(ByVal nombre_tabla As String, ByVal nombre_indice As String) As String


        'Funciones de obtención de consultas
        'Public MustOverride Function SQLCrearTabla(ByVal nombre_tabla As String, ByVal lstCampos As List(Of Cl_Campo), Optional ByVal campos_clave As String = "",
        '                                           Optional ByVal nombre_clave As String = "", Optional ByVal campos_indice As String = "", Optional ByVal nombre_indice As String = "") As List(Of String)

        'Public MustOverride Function SQLAñadirCampo(ByVal nombre_tabla As String, ByVal nombre_campo As String, ByVal tipocampo As Tipo_Campo,
        '                                            Optional ByVal longitud As Integer = 0, Optional ByVal decimales As Integer = 0) As List(Of String)
        'Public MustOverride Function SQLModificarLongitudCampo(ByVal nombre_tabla As String, ByVal oCampo As Cl_Campo) As List(Of String)
        'Public MustOverride Function SQLAñadirClavePrimaria(ByVal nombre_tabla As String, ByVal nombre_indice As String, ByVal campos As String) As List(Of String)
        'Public MustOverride Function SQLAñadirIndice(ByVal nombre_tabla As String, ByVal nombre_indice As String, ByVal campos As String) As List(Of String)
        'Public MustOverride Function SQLModificarIndice(ByVal nombre_tabla As String, ByVal nombre_indice As String, ByVal nuevo_nombre_indice As String,
        '                                                ByVal campos As String, ByVal primaria As Boolean) As List(Of String)


        Public MustOverride Function SQLCrearTabla(ByVal oTabla As Cl_Tabla) As List(Of String)
        Public MustOverride Function SQLAñadirCampo(ByVal nombre_tabla As String, ByVal oCampo As Cl_Campo) As List(Of String)
        Public MustOverride Function SQLModificarCampo(ByVal nombre_tablas As String, ByVal oCampo As Cl_Campo) As List(Of String)
        Public MustOverride Function SQLQuitarCampo(ByVal nombre_tabla As String, ByVal nombre_campo As String) As List(Of String)
        Public MustOverride Function SQLAñadirClavePrimaria(ByVal nombre_tabla As String, ByVal oClave As Cl_ClavePrimaria) As List(Of String)
        Public MustOverride Function SQLModificarClavePrimaria(ByVal nombre_tabla As String, ByVal nombre_indice As String, ByVal oIndice As Cl_ClavePrimaria) As List(Of String)
        Public MustOverride Function SQLModificarCamposClavePrimaria(ByVal nombre_tabla As String, ByVal lstCampos As List(Of Cl_Campo),
                                                               ByVal nombre_clave As String, ByVal indices As String) As List(Of String)
        Public MustOverride Function SQLQuitarClavePrimaria(ByVal nombre_tabla As String, ByVal nombre_clave As String) As List(Of String)
        Public MustOverride Function SQLAñadirIndice(ByVal nombre_tabla As String, ByVal oIndice As Cl_Indice) As List(Of String)


        Public MustOverride Function SQLModificarIndice(ByVal nombre_tabla As String, ByVal nombre_indice As String, ByVal oIndice As Cl_Indice) As List(Of String)
        Public MustOverride Function SQLQuitarIndice(ByVal nombre_tabla As String, ByVal nombre_indice As String) As List(Of String)

#Region "Funciones comunes"


        Public Sub AñadirConsulta(ByVal lstSQL As List(Of String))

            _lstActualizaciones.AddRange(lstSQL)

        End Sub

        Public Sub AñadirConsulta(ByVal sql As String)

            _lstActualizaciones.Add(sql)

        End Sub


        Public Sub BorrarConsultas()

            _lstActualizaciones.Clear()

        End Sub


        ' ''' <summary>
        ' ''' Obtiene el tipo de campo en SQL según el tipo de conexión y el valor por defecto correspondiente
        ' ''' </summary>
        ' ''' <param name="tipo_campo">Tipo de campo</param>
        ' ''' <param name="valor_defecto">Variable pasada por referencia cuyo valor se establece en la función</param>
        ' ''' <returns>Tipo de campo en SQL según el tipo de conexión: CHAR, VARCHAR, INT, INTERGER, etc...</returns>
        ' ''' <remarks></remarks>
        'Public Function ObtenerTipo(ByVal tipo_campo As Tipo_Campo, Optional ByRef valor_defecto As String = "")

        '    valor_defecto = Cadena_Valor_Defecto(tipo_campo)
        '    Return Cadena_Tipo_Campo(tipo_campo)

        'End Function

        ''' <summary>
        ''' Devuelve las cadenas SQL para modificar un indice de una tabla
        ''' </summary>
        ''' <param name="nombre_tabla">Nombre de la tabla</param>
        ''' <returns>Lista con las cadenas SQL necesarias</returns>
        ''' <remarks></remarks>
        Public Function SQLModificarIndice(ByVal nombre_tabla As String, ByVal oIndice As Cl_Indice) As List(Of String)

            Return SQLModificarIndice(nombre_tabla, oIndice.Nombre, oIndice)

        End Function

        Public Function SQLModificarClavePrimaria(ByVal nombre_tabla As String, ByVal oClave As Cl_ClavePrimaria) As List(Of String)

            Return SQLModificarClavePrimaria(nombre_tabla, oClave.Nombre, oClave)

        End Function

        ''' <summary>
        ''' Comprueba si existe un resultado para la cadena sql 
        ''' </summary>
        ''' <param name="sql">Cadena SQL</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Protected Function ExisteResultado(ByVal sql As String) As Boolean

            Dim resultado As Object = _proveedor.EjecutarEscalar(sql)
            Return Not IsNothing(resultado)

        End Function


        ''' <summary>
        ''' Ejecuta una instrucción SQL en el proveedor asignado
        ''' </summary>
        ''' <param name="Sql">Cadena SQL</param>
        ''' <returns>Número de filas afectadas</returns>
        ''' <remarks></remarks>
        Public Function EjecutarComando(ByVal Sql As String) As Integer

            Return _proveedor.EjecutarComando(Sql)

        End Function


        Public Sub Dispose()

            _proveedor.Dispose()
            _proveedor = Nothing

        End Sub


#End Region



    End Class


End Namespace




