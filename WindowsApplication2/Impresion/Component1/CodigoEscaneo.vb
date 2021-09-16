

Public Class CodigoEscaneo

    Public Codigo As String = ""
    Public x As Single = 190
    Public y As Single = 7
    Public w As Single = 80
    Public h As Single = 18
    Public tamaño_fuente As Decimal = 42
    Public Code39 As Font
    'Public Code39 As New Font("C39HrP24DhTt", tamaño_fuente)
    Public alineacion As String = ">"


    Public Sub New(ByVal Codigo As String, ByVal x As Integer, ByVal y As Integer, ByVal w As Integer, ByVal h As Integer,
                          ByVal alineacion As String, ByVal tamaño_fuente As Integer)

        Me.Codigo = Codigo
        Me.x = x
        Me.y = y
        Me.w = w
        Me.h = h
        Me.alineacion = alineacion
        Me.Code39 = New Font("C39HrP24DhTt", tamaño_fuente)

    End Sub


End Class
