Imports NetAgro.ProveedorDatos
Imports NetAgro.Constructor

''' <summary>
''' Tipo de excepción distinta a la general para controlar las excepciones propias de la lógica de ActuBD
''' </summary>
''' <remarks>ATENCIÓN: La propiedad MESSAGE es el mensaje original de la excepción, la propiedad MENSAJE es el mensaje que envía ActuBD al usuario</remarks>
Public Class ExcepcionActualizacion
    Inherits Exception

    Private _Mensaje As String = ""

    Public ReadOnly Property Mensaje
        Get
            Return _Mensaje
        End Get
    End Property

    Public Sub New(ByVal mensaje As String)
        _Mensaje = mensaje
    End Sub

End Class

''' <summary>
''' En este módulo se dirige las operaciones de actualización
''' </summary>
''' <remarks></remarks>
Public Class Cl_DirectorActualizaciones

    'Protected _factoria As New Cl_FactoriaConstructores
    Protected _lstActualizaciones As New List(Of String)
    Protected _lstConstructores As New List(Of Cl_ConstructorConsultas)

    'Propiedades
    Public ReadOnly Property Constructor As List(Of Cl_ConstructorConsultas)
        Get
            Return _lstConstructores
        End Get
    End Property

    Public Function AñadirConstructor(ByVal TipoConexion As Tipo_Conexion, _
                                      ByVal TipoProveedor As Tipo_Proveedor, _
                                      ByVal CadenaConexion As String) As Cl_ConstructorConsultas

        Dim constructor As Cl_ConstructorConsultas = ObtenerConstructor(TipoConexion, TipoProveedor, CadenaConexion)
        _lstConstructores.Add(constructor)

        Return constructor

    End Function

    Public Function AñadirConstructor(ByVal TipoConexion As Integer, _
                                      ByVal TipoProveedor As Tipo_Proveedor,
                                      ByVal CadenaConexion As String) As Cl_ConstructorConsultas

        If Not [Enum].IsDefined(GetType(Tipo_Conexion), TipoConexion) Then Throw New ExcepcionActualizacion("Tipo de conexión no definida: " & TipoConexion.ToString())

        Dim constructor As Cl_ConstructorConsultas = ObtenerConstructor(TipoConexion, TipoProveedor, CadenaConexion)
        _lstConstructores.Add(constructor)

        Return constructor

    End Function

    Public Function ObtenerConstructor(ByVal TipoConexion As Tipo_Conexion, _
                                       ByVal TipoProveedor As Tipo_Proveedor,
                                       ByVal Conexion As String) As Cl_ConstructorConsultas

        Dim constructor As Cl_ConstructorConsultas = Nothing
        Dim proveedor As New Cl_ProveedorDatos(TipoConexion, TipoProveedor, _
                                               Conexion, constructor)

        Select Case TipoConexion

            Case Tipo_Conexion.SqlServer
                constructor = New Cl_ConstructorSQL(proveedor)

            Case Tipo_Conexion.Firebird
                constructor = New Cl_ConstructorFB(proveedor)

            Case Tipo_Conexion.Pervasive
                constructor = New Cl_ConstructorPVS(proveedor)

            Case Tipo_Conexion.Postgre8
                constructor = New Cl_ConstructorPG8(proveedor)

            Case Tipo_Conexion.Postgre9
                constructor = New Cl_ConstructorPG9(proveedor)

        End Select



        Return CType(constructor, Cl_ConstructorConsultas)

    End Function

    Public Function ActuVersion(ByRef bCancelado As Boolean) As Boolean

        Dim bResultado As Boolean = False
        Dim bErrorConexion As Boolean = False
        Dim dlg_resultado As Windows.Forms.DialogResult = Windows.Forms.DialogResult.Cancel

        Dim f As New frmActuBD


        'Ejecuta las consultas de cada constructor
        For Each Constructor As Cl_ConstructorConsultas In _lstConstructores


            'Llena el grid con la lista de actualizaciones
         
            f.EstablecerActualizaciones(Constructor)
            If Constructor.ErrorConexion Then bErrorConexion = True

        Next


        'TODO: Comprobar si es correcto que sólo dependa del número de filas del grid
        If bErrorConexion Then

            bCancelado = True

        Else

            If f.grid.Rows.Count = 0 Then

                'Si no hay actualizaciones y no ha habido error, terminamos con resultado positivo
                bResultado = True
                dlg_resultado = Windows.Forms.DialogResult.OK

            Else

                'Espera al resultado de la actualización para devolver cierto o falso
                dlg_resultado = f.ShowDialog()
                bCancelado = dlg_resultado = Windows.Forms.DialogResult.Cancel
                bResultado = (dlg_resultado = Windows.Forms.DialogResult.OK)

            End If

        End If

        'TODO: Destruir los objetos creados

        Return bResultado

    End Function



End Class
