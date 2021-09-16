Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Reflection


Public Class NodoXml

    Public miNodo As String
    Public nodoPadre As NodoXml
    Public Valores As New List(Of String)


    Public ReadOnly Property Valor As String
        Get
            Try
                Return Valores(0)
            Catch ex As Exception
                Return ""
            End Try
        End Get
    End Property

    Public Function structuraNodo() As String

        If Not nodoPadre Is Nothing Then
            Return nodoPadre.structuraNodo + "/" + miNodo
        Else
            Return miNodo
        End If

    End Function


    Public Sub New(ByVal _miNodo As String)
        miNodo = _miNodo
    End Sub


    Public Sub New(ByVal _miNodo As String, ByVal _nodoPadre As NodoXml)
        nodoPadre = _nodoPadre
        miNodo = _miNodo
    End Sub

End Class

Public Class FicheroXml

    Dim XmlDocumento As New XmlDocument

    Private miPath As String
    Private infoCampos() As FieldInfo = Me.GetType.GetFields(BindingFlags.Instance Or BindingFlags.Public)


    Public Sub New(ByVal _path As String)
        miPath = _path
    End Sub


    Public Sub CargaXML()

        Dim infosr As StreamReader = New StreamReader(miPath)

        XmlDocumento.LoadXml(infosr.ReadToEnd)

        For i As Integer = 0 To infoCampos.Length - 1

            If TypeOf infoCampos(i).GetValue(Me) Is NodoXml Then

                Dim tmpNodo As NodoXml
                tmpNodo = CType(infoCampos(i).GetValue(Me), NodoXml)
                tmpNodo.Valores.Clear()

                For Each oxmlnode As XmlNode In XmlDocumento.SelectNodes(tmpNodo.structuraNodo)
                    tmpNodo.Valores.Add(oxmlnode.InnerText)
                Next

                infoCampos(i).SetValue(Me, tmpNodo)

            End If

        Next

    End Sub

    Public Function CreaArbolNodo() As ArbolNodo

        Dim miArbol As New ArbolNodo(New NodoXml(""))

        For i As Integer = 0 To infoCampos.Length - 1
            If TypeOf infoCampos(i).GetValue(Me) Is NodoXml Then
                AñadeNodo(miArbol, CType(infoCampos(i).GetValue(Me), NodoXml))
            End If
        Next

        Return miArbol

    End Function


    Public Function AñadeNodo(ByRef miArbol As ArbolNodo, ByVal Nodo As NodoXml) As Integer

        If Nodo.nodoPadre Is Nothing Then

            miArbol.nodoHijos.Add(New ArbolNodo(Nodo))
            Return 1

        Else
            If miArbol.miNodo.miNodo = Nodo.nodoPadre.miNodo Then

                miArbol.nodoHijos.Add(New ArbolNodo(Nodo))
                Return 1

            Else
                For Each hijos As ArbolNodo In miArbol.nodoHijos

                    If AñadeNodo(hijos, Nodo) = 1 Then
                        Return 1
                    End If

                Next

                Return 0

            End If

        End If


    End Function

End Class



Public Class ArbolNodo

    Public miNodo As NodoXml
    Public nodoHijos As New List(Of ArbolNodo)

    Public Sub New(ByVal _miNodo As NodoXml)
        miNodo = _miNodo
    End Sub

    Public Sub New()

    End Sub

End Class


