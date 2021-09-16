Public Class AcumuladorCampos

    Private mListaCampos As Dictionary(Of String, Decimal)
    Public Property ListaCampos() As Dictionary(Of String, Decimal)
        Get
            Return mListaCampos
        End Get
        Set(ByVal value As Dictionary(Of String, Decimal))
            mListaCampos = value
        End Set
    End Property

#Region "Constructores"

    Public Sub New()
        Me.New(Nothing)
    End Sub

    Public Sub New(ByVal Claves As Array, ByVal Valores As Array)
        AddLista(Claves, Valores)
    End Sub

    Public Sub New(ByVal Lista As Dictionary(Of String, Decimal))
        Me.ListaCampos = Lista
    End Sub

#End Region

#Region "Metodos"

    Public Sub AddElemento(ByVal Clave As String, ByVal Valor As Decimal)
        ListaCampos.Add(Clave, Valor)
    End Sub

    Public Sub AddLista(ByVal Claves As Array, ByVal Valores As Array)
        For i = 0 To ListaCampos.Count - 1
            If i < Claves.Length And i < Valores.Length Then
                AddElemento(Claves(i), Valores(i))
            End If
        Next
    End Sub

    Public Sub SumarValores(ByVal Valores As Array)
        For i = 0 To ListaCampos.Count - 1
            If i < Valores.Length Then
                ListaCampos(i) += Valores(i)
            End If
        Next
    End Sub

    Public Function GetValor(ByVal Clave As String) As Decimal
        Return ListaCampos.Item(Clave)
    End Function

    Public Sub Reiniciar()
        For Each r As Decimal In ListaCampos.Values
            r = 0
        Next
    End Sub

#End Region

End Class
