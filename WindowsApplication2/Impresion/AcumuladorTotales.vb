Public Class AcumuladorTotales

#Region "Propiedades"

    ''' <summary>
    ''' Lista de nombres correspondiente a cada campo a actualizar
    ''' </summary>
    ''' <remarks>Lista paralela a la lista de valores</remarks>
    Private mListaNombres As List(Of String)
    Public Property ListaNombres() As List(Of String)
        Get
            Return mListaNombres
        End Get
        Set(ByVal value As List(Of String))
            mListaNombres = value
        End Set
    End Property

    ''' <summary>
    ''' Lista de valores correspondientes a cada campo a actualizar
    ''' </summary>
    ''' <remarks>Lista paralela a la lista de nombres</remarks>
    Private mListaValores As List(Of Decimal)
    Public Property ListaValores() As List(Of Decimal)
        Get
            Return mListaValores
        End Get
        Set(ByVal value As List(Of Decimal))
            mListaValores = value
        End Set
    End Property

#End Region

#Region "Constructor"

    ''' <summary>
    ''' Constructor al que se le pasa el número de campos que se quieren ir actualizando
    ''' </summary>
    ''' <param name="NumElementos">Número de elementos que se irán actualizando</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal NumElementos As Integer)
        Me.ListaNombres = New List(Of String)
        Me.ListaValores = New List(Of Decimal)
        IniciarListas(NumElementos)
    End Sub

    ''' <summary>
    ''' Constructor al que se le pasa una lista con todos los nombres de los campos
    ''' </summary>
    ''' <param name="ListaCampos">Lista de todos los nombres de los elementos que se irán actualizando</param>
    ''' <remarks>Al tener nombre los elementos se podrá obtener el valor de dicho elemento directamente por el nombre que se le ha dado</remarks>
    Public Sub New(ByVal ListaCampos As List(Of String))
        Me.ListaNombres = ListaCampos
        Me.ListaValores = New List(Of Decimal)
        IniciarValores()
    End Sub

#End Region

#Region "Métodos Públicos"

    ''' <summary>
    ''' Método privado para crear una lista paralela a la lista de nombres que corresponderá a cada valor computado por cada nombre
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub IniciarValores()
        For Each Elemento In ListaNombres
            ListaValores.Add(0)
        Next
    End Sub

    ''' <summary>
    ''' Método privado que inicia dos listas, de nombres vacios y de valores a cero, con el número de elementos requerido por el usuario
    ''' </summary>
    ''' <param name="Elementos"></param>
    ''' <remarks>
    ''' El número de elementos es necesario para crear dos listas paralelas, y posteriormente, cuando se le pasa una lista de valores a actualizar se pueda comprobar que la lista 
    ''' pasada corresponde al tamaño correcto. De lo contrario se podrían producir errores de indices fuera de rango.
    ''' </remarks>
    Private Sub IniciarListas(ByVal Elementos As Integer)
        For i = 0 To Elementos - 1
            ListaNombres.Add("")
            ListaValores.Add(0)
        Next
    End Sub

    ''' <summary>
    ''' Método que añade un nuevo campo a las dos listas paralelas, pasándole el nombre del campo y el valor inicial del campo
    ''' </summary>
    ''' <param name="Nombre">Campo Nombre que definirá el valor</param>
    ''' <param name="Valor">Valor inicial que se le aplicará al campo</param>
    ''' <remarks></remarks>
    Public Sub AddCampo(ByVal Nombre As String, ByVal Valor As Decimal)
        ListaNombres.Add(Nombre)
        ListaValores.Add(Valor)
    End Sub

    ''' <summary>
    ''' Método que borra un campo de las dos listas paralelas a partir del nombre asignado
    ''' </summary>
    ''' <param name="Nombre">Nombre que se buscará en la lista de nombres para borrar el campo</param>
    ''' <remarks></remarks>
    Public Sub BorraCampo(ByVal Nombre As String)
        For i = 0 To ListaNombres.Count - 1
            If ListaNombres(i).Equals(Nombre) Then
                ListaNombres.RemoveAt(i)
                ListaValores.RemoveAt(i)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Método que reinicia todo los valores de la lista igualandolos a cero
    ''' </summary>
    ''' <remarks>Este proceso se realiza en las roturas, cuando se totaliza un campo y se quiere reiniciar para totalizar el siguiente</remarks>
    Public Sub ReiniciarValores()
        For i = 0 To ListaValores.Count - 1
            ListaValores(i) = 0
        Next
    End Sub

    ''' <summary>
    ''' Método que obtiene el valor del campo correspondiente a un nombre dado
    ''' </summary>
    ''' <param name="Nombre">Nombre asociado en la lista de nombres</param>
    ''' <returns>Valor correspondiente de la lista de valores</returns>
    ''' <remarks></remarks>
    Public Function GetValor(ByVal Nombre As String) As Decimal
        Dim Num As Decimal = 0

        For i = 0 To ListaNombres.Count - 1
            If ListaNombres(i).Equals(Nombre) Then Num = ListaValores(i)
        Next

        Return Num
    End Function

    ''' <summary>
    ''' Método que devuelve la lista de todos los valores
    ''' </summary>
    ''' <returns>Lista de decimales correspondiente a los valores</returns>
    ''' <remarks>No está asociada a nombres por lo tanto se deberá tener en cuenta el orden de introducción de los valores</remarks>
    Public Function GetLista() As List(Of Decimal)
        Return ListaValores
    End Function

    ''' <summary>
    ''' Método que actualiza los valores sumando la lista de valores dada
    ''' </summary>
    ''' <param name="Valores">Lista de valores ordenada</param>
    ''' <returns>Booleano que indica que la suma se ha realizado correctamente como consecuencia de introducir una lista del mismo tamaño que 
    ''' las listas que tiene el objeto</returns>
    ''' <remarks>
    ''' Se debe tener en cuenta el orden de los valores a actualizar así como el tamaño de la lista. Si el tamaño no corresponde con la lista de valores que
    ''' que contiene el objeto, no se actualizará la lista y se devolverá false como resultado
    ''' </remarks>
    Public Function Suma(ByVal Valores As List(Of Decimal)) As Boolean
        Dim Ok As Boolean = True

        If Valores.Count = ListaValores.Count Then
            For i = 0 To ListaValores.Count - 1
                ListaValores(i) = ListaValores(i) + Valores(i)
            Next
        Else
            Ok = False
        End If

        Return Ok
    End Function

    ''' <summary>
    ''' Método que actualiza un valor del campo según el nombre de campo dado
    ''' </summary>
    ''' <param name="Campo">Nombre del campo a actualizar</param>
    ''' <param name="valor">Valor del campo que se quiere sumar</param>
    ''' <returns>Booleano que indicar que la suma se ha realizado con éxito</returns>
    ''' <remarks>Si el nombre del campo no existe, no se actualizará ningún elemento y el método devolverá false para indicarlo</remarks>
    Public Function SumaACampo(ByVal Campo As String, ByVal valor As Decimal) As Boolean
        Dim Ok As Boolean = True

        If ListaNombres.Contains(Campo) Then
            Dim Indice As Integer = ListaNombres.IndexOf(Campo)
            ListaValores(Indice) = ListaValores(Indice) + valor
        End If

        Return Ok
    End Function

#End Region

End Class
