Imports NetAgro.Constructor
Imports NetAgro.ProveedorDatos


Public Class Cl_ConstructorPG9
    Inherits Cl_ConstructorPG8

    Public Sub New(ByVal proveedor As Cl_ProveedorDatos)
        MyBase.New(proveedor)
    End Sub


    Public Overrides Function ExisteCampo(ByVal nombre_tabla As Object, ByVal nombre_campo As Object) As Boolean
        Throw New ExcepcionActualizacion("Constructor consultas aún no implementado para PG9")
    End Function

End Class
