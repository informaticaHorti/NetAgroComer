Public Class Lb
    Inherits Label
    Dim _ControlAsociado As Object
    Public Property CL_ControlAsociado As Object
        Set(ByVal value As Object)
            _ControlAsociado = value

        End Set
        Get
            Return _ControlAsociado

        End Get
    End Property
    Dim _ValorFijo As Boolean
    Public Property CL_ValorFijo As Boolean
        Set(ByVal value As Boolean)
            _ValorFijo = value

        End Set
        Get
            Return _ValorFijo

        End Get
    End Property

    Dim _ClForm As Object
    Public Property ClForm As Object
        Set(ByVal value As Object)
            Try
                _ClForm = value

            Catch ex As Exception
                _ClForm = Nothing
            End Try

        End Set
        Get
            Try
                Return _ClForm
            Catch ex As Exception
                Return Nothing
            End Try

        End Get
    End Property


   
  
End Class
