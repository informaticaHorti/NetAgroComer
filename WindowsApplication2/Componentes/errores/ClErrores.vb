Imports System.Windows.Forms

Public Class ClErrores
    Private _Proyecto As String
    Public Property Proyecto As String
        Get
            Return _Proyecto
        End Get
        Set(ByVal value As String)
            _Proyecto = value
        End Set
    End Property
    Private _Clase As String
    Public Property Clase As String
        Get
            Return _Clase
        End Get
        Set(ByVal value As String)
            _Clase = value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="err">Error definido por el programador</param>
    ''' <param name="Procedimiento">Procedimiento,funcion,propiedad donde se encuentra el error</param>
    ''' <param name="tex">ex.Message</param>
    ''' <remarks></remarks>
    Public Sub MuestraError(ByVal err As String, ByVal Procedimiento As String, ByVal tex As String)
        _Proyecto = My.Application.Info.ProductName

        Dim f As New frmMuestraErrores(err, Proyecto, Clase, Procedimiento, tex)
        f.ShowDialog()
    End Sub


    Public Sub New(ByVal cla As String)
        _Clase = cla
    End Sub


End Class
