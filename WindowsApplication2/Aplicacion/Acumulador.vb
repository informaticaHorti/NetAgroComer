Imports System.Reflection



Public Class Acumulador

    Public Dc As New Dictionary(Of Object, Object)


    Public ReadOnly Property Dato(stClave As Object)
        Get
            Dim resultado As Object = Nothing
            Dim clave As Object = ObtenerClave(stClave)

            If Not IsNothing(clave) Then
                If Dc.ContainsKey(clave) Then
                    resultado = Dc(clave)
                End If
            End If

            Return resultado

        End Get
    End Property


    Public Overridable Function ObtenerClave(stClave As Object) As Object

        Dim resultado As Object = Nothing

        Dim bEncontrado As Boolean = False


        'Busca la clave según las variables de la clase stClave
        For Each clave As Object In Dc.Keys

            'Obtiene array con variables de las claves y los datos para compararlas
            Dim VarNuevaClave() As FieldInfo = stClave.GetType.GetFields(BindingFlags.Instance Or BindingFlags.Public)
            Dim VarClave() As FieldInfo = clave.GetType.GetFields(BindingFlags.Instance Or BindingFlags.Public)


            'Busca variable por variable
            For Each vnc As FieldInfo In VarNuevaClave

                'Se supone que si tienen distinto número de variables, son clases (y claves) distintas
                Dim bVarEncontrada As Boolean = True

                If VarNuevaClave.Length <> VarClave.Length Then
                    bVarEncontrada = False
                Else
                    For indice As Integer = 0 To VarNuevaClave.Length - 1

                        If Not VarNuevaClave(indice).FieldType.Name.StartsWith("Dictionary") Then

                            If VarNuevaClave(indice).Name.ToUpper.Trim <> VarClave(indice).Name.ToUpper.Trim Then
                                bVarEncontrada = False
                                Exit For
                            ElseIf VarNuevaClave(indice).GetValue(stClave) <> VarClave(indice).GetValue(clave) Then
                                bVarEncontrada = False
                                Exit For
                            End If

                        End If

                    Next
                End If


                'Si ha encontrado todas las variables, dejamos de buscar
                If bVarEncontrada Then
                    bEncontrado = True
                    Exit For
                End If

            Next

            If bEncontrado Then
                resultado = clave
                Exit For
            End If

        Next

        Return resultado

    End Function


    Public Function Suma(stClave As Object, stDatos As Object) As Object


        Dim ClaveEncontrada As Object = ObtenerClave(stClave)
        If IsNothing(ClaveEncontrada) Then ClaveEncontrada = New Object


        If Dc.ContainsKey(ClaveEncontrada) Then

            Dim datos As Object = Dc(ClaveEncontrada)

            Dim VarNuevosDatos() As FieldInfo = stDatos.GetType.GetFields(BindingFlags.Instance Or BindingFlags.Public)
            Dim VarDatos() As FieldInfo = datos.GetType.GetFields(BindingFlags.Instance Or BindingFlags.Public)

            For Each vnd As FieldInfo In VarNuevosDatos
                For Each vd As FieldInfo In VarDatos

                    'Acumula las variables numéricas con el mismo nombre
                    If vnd.Name.ToUpper.Trim = vd.Name.ToUpper.Trim Then
                        If IsNumeric(vnd.GetValue(stDatos)) And IsNumeric(vd.GetValue(datos)) Then
                            'Por algún motivo el SetValue no funciona con estructuras, sólo con clases
                            'vd.SetValue(datos, vnd.GetValue(stDatos) + vd.GetValue(datos))
                            vd.SetValue(datos, vd.GetValue(datos) + vnd.GetValue(stDatos))
                        End If
                    End If

                Next
            Next

            Return ClaveEncontrada

        Else
            Dc(stClave) = stDatos
            Return stClave
        End If

    End Function


    Public Overridable Function DataTable() As DataTable

        Dim dt As New DataTable


        '1) Crea las columnas de la estructura
        If Dc.Keys.Count > 0 Then


            Dim indice As Integer = 0

            For Each clave As Object In Dc.Keys
                If indice = 0 Then

                    'If Not VarClaves(indice).FieldType.Name.StartsWith("Dictionary") Then

                    'End If


                    Dim VarClaves() As FieldInfo = clave.GetType.GetFields(BindingFlags.Instance Or BindingFlags.Public)
                    For Each var As FieldInfo In VarClaves
                        If Not var.FieldType.Name.StartsWith("Dictionary") Then
                            CreaColumna(dt, var)
                        End If
                    Next

                    '2) Crea las columnas de los datos
                    Dim datos As Object = Dc(clave)
                    Dim VarDatos() As FieldInfo = datos.GetType.GetFields(BindingFlags.Instance Or BindingFlags.Public)
                    For Each var As FieldInfo In VarDatos
                        If Not var.FieldType.Name.StartsWith("Dictionary") Then
                            CreaColumna(dt, var, True)
                        End If
                    Next

                Else
                    Exit For
                End If

                indice = indice + 1
            Next


        End If



        '3) Ya existen las columnas si no estaban creadas. Ahora introducimos los datos
        For Each clave As Object In Dc.Keys

            'Creamos la fila una vez que tenemos todas las columnas
            Dim row As DataRow = dt.NewRow()


            'Añadimos los valores de la estructura
            Dim VarClaves() As FieldInfo = clave.GetType.GetFields(BindingFlags.Instance Or BindingFlags.Public)
            For Each var As FieldInfo In VarClaves
                If dt.Columns.Contains(var.Name) Then
                    row(var.Name) = var.GetValue(clave)
                End If
            Next


            'Añadimos los valores de los datos
            Dim datos As Object = Dc(clave)
            Dim VarDatos() As FieldInfo = datos.GetType.GetFields(BindingFlags.Instance Or BindingFlags.Public)
            For Each var As FieldInfo In VarDatos
                If dt.Columns.Contains(var.Name) Then
                    row(var.Name) = var.GetValue(datos)
                End If
            Next

            dt.Rows.Add(row)

        Next


        Return dt

    End Function


    Protected Sub CreaColumna(ByRef dt As DataTable, var As FieldInfo, Optional MostrarErrorSiRepetida As Boolean = False)

        'Crea la columna en caso de que no exista
        If Not dt.Columns.Contains(var.Name) Then

            Dim tipo As Type

            'Select Case var.GetType()
            Select Case var.FieldType

                Case GetType(Int32)
                    tipo = GetType(Int32)

                Case GetType(Decimal)
                    tipo = GetType(Decimal)

                Case GetType(Date), GetType(DateTime)
                    tipo = GetType(Date)

                Case GetType(Boolean)
                    tipo = GetType(Boolean)

                Case Else
                    tipo = GetType(String)

            End Select

            Dim columna As New DataColumn(var.Name, tipo)
            dt.Columns.Add(columna)

        Else

            If MostrarErrorSiRepetida Then
                'Avisamos que hemos incluído una columna repetida
                Throw New Exception("Error, nombre de columna repetido: " & var.Name)
            End If

        End If

    End Sub


    Public Sub Borrar()

        For Each clave As Object In Dc.Keys

            Dim datos As Object = Dc(clave)
            datos = Nothing
            clave = Nothing

        Next


        Dc.Clear()

    End Sub


End Class
