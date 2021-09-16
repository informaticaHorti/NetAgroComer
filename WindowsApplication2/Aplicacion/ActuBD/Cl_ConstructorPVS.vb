Imports NetAgro.Constructor
Imports NetAgro.ProveedorDatos


Public Class Cl_ConstructorPVS
    Inherits Cl_ConstructorConsultas



    Public Sub New(ByVal proveedor As Cl_ProveedorDatos)
        MyBase.New(proveedor)
    End Sub


    Public Overrides Function ExisteCampo(ByVal nombre_tabla As Object, ByVal nombre_campo As Object) As Boolean
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    End Function

    Public Overrides Function ExisteConstraint(ByVal nombre_tabla As String, ByVal nombre_indice As String) As Boolean
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    End Function

    Public Overrides Function ExisteTabla(ByVal nombre_tabla As Object) As Boolean
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    End Function

    Public Overrides Function ObtenerDecimalesCampo(ByVal nombre_tabla As String, ByVal nombre_campo As String, ByVal tipocampo As Tipo_Campo) As Integer
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    End Function

    Public Overrides Function ObtenerIndice(ByVal nombre_tabla As String, ByVal nombre_indice As String) As String
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    End Function

    Public Overrides Function ObtenerLongitudCampo(ByVal nombre_tabla As String, ByVal nombre_campo As String, ByVal TipoCampo As Tipo_Campo) As Integer
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    End Function

    'Public Overrides Function SQLAñadirCampo(ByVal nombre_tabla As String, ByVal nombre_campo As String, ByVal tipocampo As Tipo_Campo, Optional ByVal longitud As Integer = 0, Optional ByVal decimales As Integer = 0) As System.Collections.Generic.List(Of String)
    '    Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    'End Function
    Public Overrides Function SQLAñadirCampo(ByVal nombre_tablas As String, ByVal oCampo As Constructor.Cl_Campo) As System.Collections.Generic.List(Of String)
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    End Function

    Public Overrides Function SQLQuitarCampo(ByVal nombre_tabla As String, ByVal nombre_campo As String) As System.Collections.Generic.List(Of String)
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PG8")
    End Function

    'Public Overrides Function SQLAñadirClavePrimaria(ByVal nombre_tabla As String, ByVal nombre_indice As String, ByVal campos As String) As System.Collections.Generic.List(Of String)
    '    Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    'End Function
    Public Overrides Function SQLAñadirClavePrimaria(ByVal nombre_tabla As String, ByVal oClave As Constructor.Cl_ClavePrimaria) As System.Collections.Generic.List(Of String)
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    End Function

    'Public Overrides Function SQLAñadirIndice(ByVal nombre_tabla As String, ByVal nombre_indice As String, ByVal campos As String) As System.Collections.Generic.List(Of String)
    '    Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    'End Function
    Public Overrides Function SQLAñadirIndice(ByVal nombre_tabla As String, ByVal oIndice As Constructor.Cl_Indice) As System.Collections.Generic.List(Of String)
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    End Function

    'Public Overrides Function SQLCrearTabla(ByVal nombre_tabla As String, ByVal lstCampos As List(Of Cl_Campo), Optional ByVal campos_clave As String = "",
    '                                        Optional ByVal nombre_clave As String = "", Optional ByVal campos_indice As String = "",
    '                                        Optional ByVal nombre_indice As String = "") As List(Of String)
    '    Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    'End Function
    Public Overrides Function SQLCrearTabla(ByVal oTabla As Constructor.Cl_Tabla) As System.Collections.Generic.List(Of String)
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    End Function

    'Public Overrides Function SQLModificarDecimalesCampo(ByVal nombre_tabla As String, ByVal oCampo As Cl_Campo) As System.Collections.Generic.List(Of String)
    '    Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    'End Function
    Public Overrides Function SQLModificarCampo(ByVal nombre_tablas As String, ByVal oCampo As Constructor.Cl_Campo) As System.Collections.Generic.List(Of String)
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    End Function
    'Public Overrides Function SQLModificarDecimalesClavePrimaria(ByVal nombre_tabla As String, ByVal lstCampos As System.Collections.Generic.List(Of Cl_Campo), ByVal nombre_clave As String, ByVal indices As String) As List(Of String)
    '    Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    'End Function

    'Public Overloads Overrides Function SQLModificarIndice(ByVal nombre_tabla As String, ByVal nombre_indice As String, ByVal nuevo_nombre_indice As String, ByVal campos As String, ByVal primaria As Boolean) As System.Collections.Generic.List(Of String)
    '    Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    'End Function
    Public Overrides Function SQLModificarIndice(ByVal nombre_tabla As String, ByVal nombre_indice As String, ByVal oIndice As Constructor.Cl_Indice) As System.Collections.Generic.List(Of String)
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    End Function
    Public Overrides Function SQLModificarClavePrimaria(ByVal nombre_tabla As String, ByVal nombre_indice As String, ByVal oIndice As Constructor.Cl_ClavePrimaria) As System.Collections.Generic.List(Of String)
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    End Function

    'Public Overrides Function SQLModificarLongitudCampo(ByVal nombre_tabla As String, ByVal oCampo As Cl_Campo) As System.Collections.Generic.List(Of String)
    '    Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    'End Function

    'Public Overrides Function SQLModificarLongitudClavePrimaria(ByVal nombre_tabla As String, ByVal lstCampos As System.Collections.Generic.List(Of Cl_Campo), ByVal nombre_clave As String, ByVal indices As String) As List(Of String)
    '    Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    'End Function

    Public Overrides Function SQLQuitarClavePrimaria(ByVal nombre_tabla As String, ByVal nombre_clave As String) As System.Collections.Generic.List(Of String)
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    End Function

    Public Overrides Function SQLQuitarIndice(ByVal nombre_tabla As String, ByVal nombre_indice As String) As System.Collections.Generic.List(Of String)
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    End Function

    Public Overrides Function SQLModificarCamposClavePrimaria(ByVal nombre_tabla As String, ByVal lstCampos As System.Collections.Generic.List(Of Constructor.Cl_Campo), ByVal nombre_clave As String, ByVal indices As String) As System.Collections.Generic.List(Of String)
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PVS")
    End Function



End Class
