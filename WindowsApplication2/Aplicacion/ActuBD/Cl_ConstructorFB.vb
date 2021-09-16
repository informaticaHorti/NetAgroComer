Imports NetAgro.Constructor
Imports NetAgro.ProveedorDatos

Public Class Cl_ConstructorFB
    Inherits Cl_ConstructorConsultas

    Public Sub New(ByVal proveedor As Cl_ProveedorDatos)

        MyBase.New(proveedor)

        Cadena_Tipo_Campo = {"CHAR", "VARCHAR", "VARCHAR", "INTEGER", "FLOAT", "DOUBLE PRECISION", "DECIMAL", "NUMERIC", "VARCHAR", "DATE", "DATE", "BLOB"}
        Cadena_Valor_Defecto = {"''", "''", "''", "0", "0", "0", "0", "0", "''", "''", "''", "''"}

    End Sub

    ''' <summary>
    ''' Comprueba si una tabla existe en la base de datos, según el tipo de conexión
    ''' </summary>
    ''' <param name="nombre_tabla"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function ExisteTabla(ByVal nombre_tabla) As Boolean

        Dim bExiste As Boolean = False
        Dim sql As String = ""

        Try

            sql = "Select RDB$FIELD_SOURCE from RDB$RELATION_FIELDS where RDB$RELATION_NAME='" & nombre_tabla & "'"
            bExiste = ExisteResultado(sql)

        Catch ex As Exception
            Throw New ExcepcionActualizacion("Error al comprobar si existe la tabla " & nombre_tabla)
        End Try


        Return bExiste

    End Function



    ''' <summary>
    ''' Comprueba si un campo existe en la base de datos, según el tipo de conexión
    ''' </summary>
    ''' <param name="nombre_tabla"></param>
    ''' <param name="nombre_campo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function ExisteCampo(ByVal nombre_tabla, ByVal nombre_campo) As Boolean

        Dim bExiste As Boolean = False
        Dim sql As String = ""

        Try

            sql = "Select RDB$FIELD_SOURCE from RDB$RELATION_FIELDS where RDB$RELATION_NAME='" & nombre_tabla & _
                "' AND RDB$FIELD_NAME='" & nombre_campo & "'"

            bExiste = ExisteResultado(sql)

        Catch ex As Exception
            Throw New ExcepcionActualizacion("Error al comprobar si existe el campo " & nombre_campo & " en la tabla " & nombre_tabla)
        End Try


        Return bExiste

    End Function



    Public Overrides Function ObtenerLongitudCampo(ByVal nombre_tabla As String, ByVal nombre_campo As String, ByVal TipoCampo As Tipo_Campo) As Integer

        Dim longitud As Integer = -1
        Dim bError As Boolean = False


        Try

            Dim sql As String = "Select RDB$FIELD_LENGTH from RDB$FIELDS, RDB$RELATION_FIELDS " & " where (RDB$RELATION_FIELDS.RDB$RELATION_NAME='" & _
                nombre_tabla & "') " & " AND (RDB$RELATION_FIELDS.RDB$FIELD_NAME='" & nombre_campo & "') " & _
                " AND (RDB$RELATION_FIELDS.RDB$FIELD_SOURCE=RDB$FIELDS.RDB$FIELD_NAME) "

            'En los campos de tipo NUMERIC, Firebird guarda la longitud en el campo RDB$FIELD_PRECISION
            If TipoCampo = Tipo_Campo.Tipo_numeric Or TipoCampo = Tipo_Campo.Tipo_decimal Then
                sql = sql.Replace("RDB$FIELD_LENGTH", "RDB$FIELD_PRECISION")
            End If

            Dim l As Object = _proveedor.EjecutarEscalar(sql)

            If Not Integer.TryParse(l, longitud) Or IsNothing(l) Then
                'If longitud = -1 Or IsNothing(l) Then Throw New ExcepcionActualizacion("Error al obtener la longitud del campo " & nombre_campo & _
                '" de la tabla " & nombre_tabla)

                If longitud = -1 Or IsNothing(l) Then berror = True

            End If


        Catch ex As Exception
            Throw New ExcepcionActualizacion("Error al obtener la longitud del campo " & nombre_campo & " de la tabla " & nombre_tabla)
        End Try


        If bError Then Throw New ExcepcionActualizacion("Error al obtener la longitud del campo " & nombre_campo & " de la tabla " & nombre_tabla)


        Return longitud

    End Function



    Public Overrides Function ObtenerDecimalesCampo(ByVal nombre_tabla As String, ByVal nombre_campo As String, ByVal tipocampo As Tipo_Campo) As Integer


        'Sólo válido para campos DECIMAL y NUMERIC
        If tipocampo <> Tipo_Campo.Tipo_decimal And tipocampo <> Tipo_Campo.Tipo_numeric Then
            'Throw New ExcepcionActualizacion("Error: Sólo se puede obtener decimales de un campo DECIMAL o NUMERIC")
            Return Cl_Campo.NODECIMALES
        End If


        Dim decimales As Integer = Cl_Campo.NODECIMALES


        Try

            Dim sql As String = "Select RDB$FIELD_SCALE from RDB$FIELDS, RDB$RELATION_FIELDS " & " where (RDB$RELATION_FIELDS.RDB$RELATION_NAME='" & _
                nombre_tabla & "') " & " AND (RDB$RELATION_FIELDS.RDB$FIELD_NAME='" & nombre_campo & "') " & _
                " AND (RDB$RELATION_FIELDS.RDB$FIELD_SOURCE=RDB$FIELDS.RDB$FIELD_NAME) "

            Dim d As Object = _proveedor.EjecutarEscalar(sql)

            If Not Integer.TryParse(d, decimales) Or IsNothing(d) Then
                If decimales = Cl_Campo.NODECIMALES Or IsNothing(d) Then Throw New ExcepcionActualizacion("Error al obtener decimales del campo " & nombre_campo & _
                " de la tabla " & nombre_tabla)
            End If

            decimales = Math.Abs(decimales)

        Catch ex As Exception
            Throw New ExcepcionActualizacion("Error al obtener los decimales del campo " & nombre_campo & " de la tabla " & nombre_tabla)
        End Try


        Return decimales

    End Function



    ''' <summary>
    ''' Devuelve True o False en función de si existe el constraint
    ''' </summary>
    ''' <param name="nombre_tabla">Nombre de la tabla</param>
    ''' <param name="nombre_indice">Nombre del índice</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function ExisteConstraint(ByVal nombre_tabla As String, ByVal nombre_indice As String) As Boolean

        Dim bRes As Boolean = False

        Try

            Dim sql As String = "select * from RDB$INDICES where UPPER(rdb$INDEX_name)='" & nombre_indice.ToUpper() & "'"
            bRes = ExisteResultado(sql)

            If Not bRes Then

                'Comprueba que no está en los constraints
                sql = "select * from RDB$RELATION_CONSTRAINTS where UPPER(rdb$constraint_name)='" & nombre_indice.ToUpper() & "'"
                bRes = ExisteResultado(sql)
            End If


        Catch ex As Exception
            Throw New ExcepcionActualizacion("Error al comprobar si existe el constraint " & nombre_indice & " en la tabla " & nombre_tabla)
        End Try


        Return bRes

    End Function



    ''' <summary>
    ''' Obtiene una cadena de texto con los campos del índice, separados por comas
    ''' </summary>
    ''' <param name="nombre_tabla">Nombre de la tabla</param>
    ''' <param name="nombre_indice">Nombre del índice</param>
    ''' <returns>Campos del índice separados por comas o cadena vacía si el índice no existe</returns>
    ''' <remarks></remarks>
    Public Overrides Function ObtenerIndice(ByVal nombre_tabla As String, ByVal nombre_indice As String) As String

        Dim ix_campos As String = ""

        'En FB no pueden existir dos índices con el mismo nombre, en teoría
        'TODO: Comprobar esto último
        'TODO: Comprobar en versiones antiguas
        Dim sql As String = "SELECT RDB$INDEX_SEGMENTS.RDB$FIELD_NAME COLUMNA FROM RDB$INDEX_SEGMENTS" & _
        " WHERE RDB$INDEX_SEGMENTS.RDB$INDEX_NAME = '" & nombre_indice & "'" & _
        " ORDER BY RDB$INDEX_SEGMENTS.RDB$FIELD_POSITION"


        Dim dt As DataTable = _proveedor.ObtenerTabla(sql)

        For Each row As DataRow In dt.Rows
            If ix_campos.Trim() <> "" Then ix_campos = ix_campos & ","
            ix_campos = ix_campos & row("COLUMNA").ToString().TrimEnd()
        Next


        Return ix_campos


    End Function



    ' ''' <summary>
    ' ''' Genera la cadena SQL necesaria para crear una tabla según el tipo de conexión
    ' ''' </summary>
    ' ''' <param name="nombre_tabla">Nombre de la tabla</param>
    ' ''' <param name="lstCampos">Lista de campos</param>
    ' ''' <param name="campos_clave">Cadena de texto con los campos que forman la clave primaria, separados por comas</param>
    ' ''' <param name="nombre_clave">Nombre de la clave primaria</param>
    ' ''' <param name="campos_indice">Cadena de texto con los campos que forman un índice (en caso de querer añadir uno adicional), separados por comas</param>
    ' ''' <param name="nombre_indice">Nombre (opcional) del índice</param>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public Overrides Function SQLCrearTabla(ByVal nombre_tabla As String, ByVal lstCampos As List(Of Cl_Campo), Optional ByVal campos_clave As String = "",
    '                                               Optional ByVal nombre_clave As String = "", Optional ByVal campos_indice As String = "", Optional ByVal nombre_indice As String = "") As List(Of String)


    '    Dim lstSQL As New List(Of String)
    '    lstSQL.Clear()


    '    If Not ExisteTabla(nombre_tabla) Then


    '        'Sentencia CREATE TABLE
    '        Dim sql As String = "CREATE TABLE " & nombre_tabla & " ("

    '        Dim cont As Integer = 1
    '        For Each oCampo As Cl_Campo In lstCampos

    '            'Campo TEXT se traduce a FB como un Varchar de 8192 caracteres
    '            If oCampo.oTipo = Tipo_Campo.Tipo_text Then oCampo.Longitud = 8192

    '            sql = sql & oCampo.Nombre & " " & Cadena_Tipo_Campo(oCampo.oTipo)

    '            If oCampo.RequiereDecimales Then
    '                sql = sql & "(" & oCampo.Longitud.ToString() & "," & oCampo.Decimales.ToString() & ")"
    '            ElseIf oCampo.RequiereLongitud Or oCampo.oTipo = Tipo_Campo.Tipo_text Then
    '                sql = sql & "(" & oCampo.Longitud.ToString() & ")"
    '            End If

    '            If oCampo.UsaTexto Then sql = sql & " CHARACTER SET ISO8859_1"
    '            If Not oCampo.PermiteNulos Then sql = sql & " NOT NULL"
    '            If oCampo.UsaTexto Then sql = sql & " COLLATE ISO8859_1"
    '            If cont < lstCampos.Count Then sql = sql & ","
    '            cont = cont + 1
    '        Next


    '        'Claves
    '        If (campos_clave.Trim() <> "" And nombre_clave.Trim() = "") Or (campos_clave.Trim() = "" And nombre_clave.Trim() <> "") Then
    '            Throw New ExcepcionActualizacion("Debe proporcionar el nombre y los campos para la clave primaria en la tabla " & nombre_tabla)
    '        End If

    '        If campos_clave.Trim() <> "" And nombre_clave.Trim() <> "" Then
    '            sql = sql & ", CONSTRAINT " & nombre_clave & " PRIMARY KEY (" & campos_clave & ")"
    '        End If
    '        sql = sql & ")"
    '        lstSQL.Add(sql.ToString())


    '        'Índices
    '        If (campos_indice.Trim() <> "" And nombre_indice.Trim() = "") Or (campos_indice.Trim() = "" And nombre_indice.Trim() <> "") Then
    '            Throw New ExcepcionActualizacion("Debe proporcionar el nombre y los campos para el índice en la tabla " & nombre_tabla)
    '        End If

    '        If campos_indice.Trim() <> "" And nombre_indice.Trim() <> "" Then
    '            lstSQL.Add("CREATE ASC INDEX " & nombre_indice & " ON " & nombre_tabla & " (" & campos_indice & ")")
    '        End If


    '    End If



    '    Return lstSQL

    'End Function



    Public Overrides Function SQLCrearTabla(ByVal oTabla As Cl_Tabla) As List(Of String)


        Dim lstSQL As New List(Of String)


        If Not ExisteTabla(oTabla.Nombre) Then


            'Sentencia CREATE TABLE
            Dim sql As String = "CREATE TABLE " & oTabla.Nombre & " ("

            Dim cont As Integer = 1
            For Each oCampo As Cl_Campo In oTabla.Campos

                'Campo TEXT se traduce a FB como un Varchar de 8192 caracteres
                If oCampo.oTipo = Tipo_Campo.Tipo_text Then oCampo.Longitud = 8192

                sql = sql & oCampo.Nombre & " " & Cadena_Tipo_Campo(oCampo.oTipo)

                If oCampo.RequiereDecimales Then
                    sql = sql & "(" & oCampo.Longitud.ToString() & "," & oCampo.Decimales.ToString() & ")"
                ElseIf oCampo.RequiereLongitud Or oCampo.oTipo = Tipo_Campo.Tipo_text Then
                    sql = sql & "(" & oCampo.Longitud.ToString() & ")"
                End If

                If oCampo.UsaTexto Then sql = sql & " CHARACTER SET ISO8859_1"
                If Not oCampo.PermiteNulos Then sql = sql & " NOT NULL"
                If oCampo.UsaTexto Then sql = sql & " COLLATE ISO8859_1"
                If cont < oTabla.Campos.Count Then sql = sql & ","
                cont = cont + 1
            Next


            'Claves
            If Not IsNothing(oTabla.Clave) Then

                If (oTabla.Clave.ListaCampos <> "" And oTabla.Clave.Nombre = "") Or (oTabla.Clave.ListaCampos = "" And oTabla.Clave.Nombre <> "") Then
                    Throw New ExcepcionActualizacion("Debe proporcionar el nombre y los campos para la clave primaria en la tabla " & oTabla.Nombre)
                End If

                If oTabla.Clave.ListaCampos <> "" And oTabla.Clave.Nombre <> "" Then
                    sql = sql & ", CONSTRAINT " & oTabla.Clave.Nombre & " PRIMARY KEY (" & oTabla.Clave.ListaCampos & ")"
                End If

            End If

            sql = sql & ")"
            lstSQL.Add(sql)


            'Índices
            For Each indice As Cl_Indice In oTabla.Indices

                'Índices
                If (indice.ListaCampos <> "" And indice.Nombre = "") Or (indice.ListaCampos = "" And indice.Nombre <> "") Then
                    Throw New ExcepcionActualizacion("Debe proporcionar el nombre y los campos para el índice en la tabla " & oTabla.Nombre)
                End If

                If indice.ListaCampos <> "" And indice.Nombre <> "" Then
                    lstSQL.Add("CREATE ASC INDEX " & indice.Nombre & " ON " & oTabla.Nombre & " (" & indice.ListaCampos & ")")
                End If

            Next
        End If



        Return lstSQL

    End Function




    'Public Overrides Function SQLAñadirCampo(ByVal nombre_tabla As String, ByVal nombre_campo As String, ByVal tipocampo As Tipo_Campo, Optional ByVal longitud As Integer = 0, Optional ByVal decimales As Integer = 0) As List(Of String)

    '    Dim lstSQL As New List(Of String)
    '    lstSQL.Clear()



    '    If Not ExisteCampo(nombre_tabla, nombre_campo) Then


    '        'Comprueba que esté definido el tipo de campo
    '        If Not [Enum].IsDefined(GetType(Tipo_Campo), tipocampo) Then Throw New ExcepcionActualizacion("Error al insertar campo " & nombre_campo & " en la tabla " & nombre_tabla & ": " & vbCrLf & " 'Tipo de campo no definido': " & tipocampo.ToString())


    '        'Obtiene tipo de campo y valor por defecto

    '        Dim valor_defecto As String = Cadena_Valor_Defecto(tipocampo)
    '        Dim tipo As String = Cadena_Tipo_Campo(tipocampo)
    '        If tipo.Trim() = "" Then Throw New ExcepcionActualizacion("Error al insertar campo " & nombre_campo & " en la tabla " & nombre_tabla & ": " & vbCrLf & " 'Tipo de campo no definido': " & tipocampo.ToString())

    '        Dim bLongitud As Boolean = (tipocampo = Tipo_Campo.Tipo_char Or
    '                                    tipocampo = Tipo_Campo.Tipo_varchar Or
    '                                    tipocampo = Tipo_Campo.Tipo_nvarchar)

    '        Dim bTexto As Boolean = bLongitud And tipocampo = Tipo_Campo.Tipo_text

    '        Dim bDecimales As Boolean = (tipocampo = Tipo_Campo.Tipo_decimal Or
    '                                    tipocampo = Tipo_Campo.Tipo_numeric)


    '        'Genera el SQL correspondiente

    '        'Campo TEXT se traduce a FB como un Varchar de 8192 caracteres
    '        If tipocampo = Tipo_Campo.Tipo_text Then
    '            bLongitud = True
    '            longitud = 8192
    '        End If

    '        Dim sql As String = "ALTER TABLE " & nombre_tabla & " ADD " & nombre_campo & " " & tipo
    '        If bDecimales Then
    '            sql = sql & "(" & longitud.ToString() & "," & decimales.ToString() & ")"
    '        ElseIf bLongitud Then
    '            sql = sql & "(" & longitud.ToString() & ")"
    '        End If
    '        If bTexto Then sql = sql & " CHARACTER SET ISO8859_1"
    '        sql = sql & " NOT NULL"
    '        If bTexto Then sql = sql & " COLLATE ISO8859_1"
    '        lstSQL.Add(sql)



    '        'Respetando el código existente en versiones previas de ActuBD, se inicializa el campo a su valor por defecto
    '        Dim sqlUpdate = ("UPDATE " & nombre_tabla & " SET " & nombre_campo & "=" & valor_defecto)
    '        If _TipoConexion = Tipo_Conexion.Pervasive Then sqlUpdate = sqlUpdate.ToLower()
    '        lstSQL.Add(sqlUpdate)


    '    End If


    '    Return lstSQL

    'End Function


    Public Overrides Function SQLAñadirCampo(ByVal nombre_tabla As String, ByVal oCampo As Constructor.Cl_Campo) As System.Collections.Generic.List(Of String)

        Dim lstSQL As New List(Of String)
        lstSQL.Clear()



        If Not ExisteCampo(nombre_tabla, oCampo.Nombre) Then


            'Comprueba que esté definido el tipo de campo
            If Not [Enum].IsDefined(GetType(Tipo_Campo), oCampo.oTipo) Then Throw New ExcepcionActualizacion("Error al insertar campo " & oCampo.Nombre & " en la tabla " & nombre_tabla & ": " & vbCrLf & " 'Tipo de campo no definido': " & oCampo.oTipo.ToString())


            'Obtiene tipo de campo y valor por defecto

            Dim valor_defecto As String = Cadena_Valor_Defecto(oCampo.oTipo)
            If oCampo.ValorDefecto.Trim <> "" Then
                Select Case oCampo.oTipo
                    Case Tipo_Campo.Tipo_decimal, Tipo_Campo.Tipo_double, Tipo_Campo.Tipo_float, Tipo_Campo.Tipo_integer, Tipo_Campo.Tipo_numeric
                        valor_defecto = "'" & oCampo.ValorDefecto & "'"
                    Case Else
                        valor_defecto = "'" & oCampo.ValorDefecto & "'"
                End Select
            End If


            Dim tipo As String = Cadena_Tipo_Campo(oCampo.oTipo)
            If tipo.Trim() = "" Then Throw New ExcepcionActualizacion("Error al insertar campo " & oCampo.Nombre & " en la tabla " & nombre_tabla & ": " & vbCrLf & " 'Tipo de campo no definido': " & oCampo.oTipo.ToString())

            Dim bLongitud As Boolean = (oCampo.oTipo = Tipo_Campo.Tipo_char Or
                                        oCampo.oTipo = Tipo_Campo.Tipo_varchar Or
                                        oCampo.oTipo = Tipo_Campo.Tipo_nvarchar)

            Dim bTexto As Boolean = bLongitud And oCampo.oTipo = Tipo_Campo.Tipo_text

            Dim bDecimales As Boolean = (oCampo.oTipo = Tipo_Campo.Tipo_decimal Or
                                        oCampo.oTipo = Tipo_Campo.Tipo_numeric)


            'Genera el SQL correspondiente

            'Campo TEXT se traduce a FB como un Varchar de 8192 caracteres
            If oCampo.oTipo = Tipo_Campo.Tipo_text Then
                bLongitud = True
                oCampo.Longitud = 8192
            End If

            Dim sql As String = "ALTER TABLE " & nombre_tabla & " ADD " & oCampo.Nombre & " " & tipo
            If bDecimales Then
                sql = sql & "(" & oCampo.Longitud.ToString() & "," & oCampo.Decimales.ToString() & ")"
            ElseIf bLongitud Then
                sql = sql & "(" & oCampo.Longitud.ToString() & ")"
            End If
            If bTexto Then sql = sql & " CHARACTER SET ISO8859_1"
            sql = sql & " NOT NULL"
            If bTexto Then sql = sql & " COLLATE ISO8859_1"
            lstSQL.Add(sql)


            'If oCampo.ValorDefecto.Trim <> "" Then
            '    Select Case oCampo.oTipo
            '        Case Tipo_Campo.Tipo_decimal, Tipo_Campo.Tipo_double, Tipo_Campo.Tipo_float, Tipo_Campo.Tipo_integer, Tipo_Campo.Tipo_numeric
            '            valor_defecto = "'" & oCampo.ValorDefecto & "'"
            '        Case Else
            '            valor_defecto = "'" & oCampo.ValorDefecto & "'"
            '    End Select
            'End If


            'Respetando el código existente en versiones previas de ActuBD, se inicializa el campo a su valor por defecto
            Dim sqlUpdate = ("UPDATE " & nombre_tabla & " SET " & oCampo.Nombre & "=" & valor_defecto)
            If _TipoConexion = Tipo_Conexion.Pervasive Then sqlUpdate = sqlUpdate.ToLower()
            lstSQL.Add(sqlUpdate)


        End If


        Return lstSQL



    End Function



    ' ''' <summary>
    ' ''' Genera la cadena SQL para modificar la longitud de un campo
    ' ''' </summary>
    ' ''' <param name="nombre_tabla">Nombre de la tabla</param>
    ' ''' <param name="oCampo">Clase Cl_Campo con los datos necesarios</param>
    ' ''' <returns>Lista de cadenas SQL generadas</returns>
    ' ''' <remarks>La nueva longitud no puede ser menor que la longitud anterior. No se puede modificar la longitud de un índice o de una clave primaria. En Pervasive no funciona si no hay espacio reservado.</remarks>
    'Public Overrides Function SQLModificarLongitudCampo(ByVal nombre_tabla As String, ByVal oCampo As Cl_Campo) As List(Of String)

    '    'Controla que se pueda modificar la longitud
    '    If Not oCampo.RequiereLongitud Then Throw New ExcepcionActualizacion("No se puede modificar la longitud de un campo" & Cadena_Tipo_Campo(oCampo.oTipo))


    '    Dim lstSQL As New List(Of String)

    '    Dim sql As String = ""

    '    'Sólo tiene sentido si aumenta la longitud del campo
    '    If ObtenerLongitudCampo(nombre_tabla, oCampo.Nombre, oCampo.oTipo) < oCampo.Longitud Then

    '        sql = "ALTER TABLE " & nombre_tabla & " ALTER " & oCampo.Nombre & " TYPE " & Cadena_Tipo_Campo(oCampo.oTipo)

    '        If oCampo.RequiereDecimales Then
    '            sql = sql & "(" & oCampo.Longitud.ToString() & "," & oCampo.Decimales.ToString() & ")"
    '        ElseIf oCampo.RequiereLongitud Then
    '            sql = sql & "(" & oCampo.Longitud.ToString() & ")"
    '        End If

    '        lstSQL.Add(sql)

    '    End If


    '    Return lstSQL


    'End Function


    Public Overrides Function SQLModificarCampo(ByVal nombre_tabla As String, ByVal oCampo As Constructor.Cl_Campo) As System.Collections.Generic.List(Of String)

        Dim bModificarDecimales As Boolean = False
        Dim lstSQL As New List(Of String)
        lstSQL.Clear()

        Dim longitud As Integer = ObtenerLongitudCampo(nombre_tabla, oCampo.Nombre, oCampo.oTipo)
        Dim decimales As Integer = ObtenerDecimalesCampo(nombre_tabla, oCampo.Nombre, oCampo.oTipo)
        If oCampo.RequiereDecimales And decimales < oCampo.Decimales Then bModificarDecimales = True

        Dim bCambiar As Boolean = bModificarDecimales
        If oCampo.RequiereLongitud And longitud < oCampo.Longitud Then bCambiar = True


        If bCambiar Then

            If Not bModificarDecimales Then

                Dim sql = "ALTER TABLE " & nombre_tabla & " ALTER " & oCampo.Nombre & " TYPE " & Cadena_Tipo_Campo(oCampo.oTipo)

                If oCampo.RequiereDecimales Then
                    sql = sql & "(" & oCampo.Longitud.ToString() & "," & oCampo.Decimales.ToString() & ")"
                ElseIf oCampo.RequiereLongitud Then
                    sql = sql & "(" & oCampo.Longitud.ToString() & ")"
                End If

                lstSQL.Add(sql)

            Else

                'Para hacer esto en Firebird (si hay que aumentar el número), es necesario:
                '1.) Crear un nuevo campo al final de la tabla
                '2.) Actualizar el nuevo campo con los valores del que queremos cambiar
                '3.) Aumentar en una la posición de los campos debajo del campo que vamos a cambiar
                '4.) Cambiar la posición del campo nuevo a la posición del campo antiguo
                '5.) Borrar el campo antiguo
                '6.) Renombrar el campo nuevo con el nombre del campo antiguo

                'Crea el campo
                Dim nombre_temporal As String = oCampo.Nombre & "2TEMPORAL"

                Dim oNuevoCampo As New Cl_Campo(oCampo.Nombre & "2TEMPORAL", oCampo.oTipo, oCampo.Longitud, oCampo.Decimales)
                lstSQL.AddRange(SQLAñadirCampo(nombre_tabla, oNuevoCampo))
                lstSQL.Add("UPDATE " & nombre_tabla & " SET " & nombre_temporal & "=" & oCampo.Nombre)


                'Movemos los que hay debajo
                Dim posicion_campo As Integer = -1
                Dim campos_debajo As String = ObtenerCamposPosteriores(nombre_tabla, oCampo.Nombre, posicion_campo)
                If campos_debajo.Trim() <> "" Then

                    'Si especificamos que hay campos debajo, debemos especificar la posición donde encajar el campo
                    If posicion_campo < 0 Then Throw New ExcepcionActualizacion("Es necesario especificar la posición del campo")

                    Dim campos As String() = campos_debajo.Split(",")
                    Dim posicion_debajo As Integer = posicion_campo + 1
                    For Each campo As String In campos
                        posicion_debajo = posicion_debajo + 1
                        Dim sqlPos As String = "ALTER TABLE " & nombre_tabla & " ALTER COLUMN " & campo & _
                            " POSITION " & posicion_debajo.ToString()
                        lstSQL.Add(sqlPos)
                    Next

                    'Mueve el campo nuevo a la posición debajo del antiguo
                    lstSQL.Add("ALTER TABLE " & nombre_tabla & " ALTER COLUMN " & nombre_temporal & _
                            " POSITION " & (posicion_campo + 1).ToString())

                End If

                'Borra el campo antiguo
                Dim sql As String = "ALTER TABLE " & nombre_tabla & " DROP " & oCampo.Nombre
                lstSQL.Add(sql)

                'Renombra el campo nuevo con el nombre del antiguo
                sql = "ALTER TABLE " & nombre_tabla & " ALTER COLUMN " & nombre_temporal & " TO " & oCampo.Nombre
                lstSQL.Add(sql)


            End If

        End If



        Return lstSQL


    End Function


    ' ''' <summary>
    ' ''' Genera la cadena SQL para modificar el número de decimales de un campo
    ' ''' </summary>
    ' ''' <param name="nombre_tabla">Nombre de la tabla</param>
    ' ''' <param name="oCampo">Clase Cl_Campo con los datos necesarios</param>
    ' ''' <returns>Lista de cadenas SQL generadas</returns>
    ' ''' <remarks>El nuevo número de decimales no puede ser menor que el anterior. En Pervasive seguramente no funciona si no hay espacio reservado.</remarks>
    'Public Overrides Function SQLModificarDecimalesCampo(ByVal nombre_tabla As String, ByVal oCampo As Cl_Campo) As List(Of String)

    '    'Controla que se puedan modificar los decimales
    '    If Not oCampo.RequiereDecimales Then Throw New ExcepcionActualizacion("No se pueden modificar los decimales de un campo " & Cadena_Tipo_Campo(oCampo.oTipo))


    '    Dim lstSQL As New List(Of String)
    '    lstSQL.Clear()


    '    'Sólo tiene sentido si aumentan los deciales
    '    If ObtenerDecimalesCampo(nombre_tabla, oCampo.Nombre, oCampo.oTipo) < oCampo.Decimales Then


    '        If oCampo.RequiereDecimales Then

    '            'Para hacer esto en Firebird (si hay que aumentar el número), es necesario:
    '            '1.) Crear un nuevo campo al final de la tabla
    '            '2.) Actualizar el nuevo campo con los valores del que queremos cambiar
    '            '3.) Aumentar en una la posición de los campos debajo del campo que vamos a cambiar
    '            '4.) Cambiar la posición del campo nuevo a la posición del campo antiguo
    '            '5.) Borrar el campo antiguo
    '            '6.) Renombrar el campo nuevo con el nombre del campo antiguo

    '            'Crea el campo
    '            Dim nombre_temporal As String = oCampo.Nombre & "2TEMPORAL"

    '            Dim oNuevoCampo As New Cl_Campo(oCampo.Nombre & "2TEMPORAL", oCampo.oTipo, oCampo.Longitud, oCampo.Decimales)
    '            lstSQL.AddRange(SQLAñadirCampo(nombre_tabla, oNuevoCampo))
    '            lstSQL.Add("UPDATE " & nombre_tabla & " SET " & nombre_temporal & "=" & oCampo.Nombre)


    '            'Movemos los que hay debajo
    '            Dim posicion_campo As Integer = -1
    '            Dim campos_debajo As String = ObtenerCamposPosteriores(nombre_tabla, oCampo.Nombre, posicion_campo)
    '            If campos_debajo.Trim() <> "" Then

    '                'Si especificamos que hay campos debajo, debemos especificar la posición donde encajar el campo
    '                If posicion_campo < 0 Then Throw New ExcepcionActualizacion("Es necesario especificar la posición del campo")

    '                Dim campos As String() = campos_debajo.Split(",")
    '                Dim posicion_debajo As Integer = posicion_campo + 1
    '                For Each campo As String In campos
    '                    posicion_debajo = posicion_debajo + 1
    '                    Dim sqlPos As String = "ALTER TABLE " & nombre_tabla & " ALTER COLUMN " & campo & _
    '                        " POSITION " & posicion_debajo.ToString()
    '                    lstSQL.Add(sqlPos)
    '                Next

    '                'Mueve el campo nuevo a la posición debajo del antiguo
    '                lstSQL.Add("ALTER TABLE " & nombre_tabla & " ALTER COLUMN " & nombre_temporal & _
    '                        " POSITION " & (posicion_campo + 1).ToString())

    '            End If

    '            'Borra el campo antiguo
    '            Dim sql As String = "ALTER TABLE " & nombre_tabla & " DROP " & oCampo.Nombre
    '            lstSQL.Add(sql)

    '            'Renombra el campo nuevo con el nombre del antiguo
    '            sql = "ALTER TABLE " & nombre_tabla & " ALTER COLUMN " & nombre_temporal & " TO " & oCampo.Nombre
    '            lstSQL.Add(sql)


    '        End If

    '    End If



    '    Return lstSQL

    'End Function



    ''' <summary>
    ''' Quita un campo de la tabla
    ''' </summary>
    ''' <param name="nombre_tabla">Nombre de la tabla</param>
    ''' <param name="nombre_campo">Nombre del campo</param>
    ''' <returns>Lista de cadenas SQL generadas</returns>
    ''' <remarks></remarks>
    Public Overrides Function SQLQuitarCampo(ByVal nombre_tabla As String, ByVal nombre_campo As String) As List(Of String)

        Dim lstSQL As New List(Of String)
        lstSQL.Clear()

        If ExisteTabla(nombre_tabla) Then

            If ExisteCampo(nombre_tabla, nombre_campo) Then
                lstSQL.Add("ALTER TABLE " & nombre_tabla & " DROP " & nombre_campo)
            End If

        End If


        Return lstSQL

    End Function



    
    Public Overrides Function SQLAñadirClavePrimaria(ByVal nombre_tabla As String, ByVal oClave As Cl_ClavePrimaria) As List(Of String)

        Dim lstSQL As New List(Of String)
        Dim sql As String = ""


        'If ExisteConstraint(nombre_tabla, nombre_indice) Then Throw New ExcepcionActualizacion("Ya existe una clave primaria en la tabla " & _
        'nombre_tabla)

        If Not ExisteConstraint(nombre_tabla, oClave.Nombre) Then

            sql = "ALTER TABLE " & nombre_tabla & " ADD CONSTRAINT " & oClave.Nombre & " PRIMARY KEY (" & oClave.ListaCampos & ") USING INDEX " & oClave.Nombre
            lstSQL.Add(sql)

        End If


        Return lstSQL

    End Function



    ' ''' <summary>
    ' ''' Genera las cadenas SQL necesarias para modificar el número de decimales de los campos de una clave primaria. Para ello, debe borrar la clave y volver a crearla, así como sus índices.
    ' ''' </summary>
    ' ''' <param name="nombre_tabla">Nombre de la tabla</param>
    ' ''' <param name="lstCampos">Lista con los campos de la Clave Primaria a los que se les quiere efectuar cambios</param>
    ' ''' <param name="nombre_clave">Nombre de la clave primaria</param>
    ' ''' <param name="indices">Lista con los nombres de los índices afectados por la lista de lstCampos, separados por comas y sin espacios</param>
    ' ''' <returns>Array de string con las cadenas SQL</returns>
    ' ''' <remarks></remarks>
    'Public Overrides Function SQLModificarDecimalesClavePrimaria(ByVal nombre_tabla As String, ByVal lstCampos As List(Of Cl_Campo),
    '                                                  ByVal nombre_clave As String, ByVal indices As String) As List(Of String)

    '    Dim lstSQL As New List(Of String)
    '    lstSQL.Clear()


    '    'Comprueba que exista la clave primaria
    '    If Not ExisteConstraint(nombre_tabla, nombre_clave) Then Throw New ExcepcionActualizacion("No existe Clave primaria " & _
    '        nombre_clave & " en la tabla " & nombre_tabla)


    '    Dim bCambiar As Boolean = False
    '    For Each oCampo As Cl_Campo In lstCampos
    '        Dim decimales As Integer = ObtenerDecimalesCampo(nombre_tabla, oCampo.Nombre, oCampo.oTipo)
    '        If decimales < oCampo.Decimales Then
    '            bCambiar = True
    '        End If
    '    Next


    '    If bCambiar Then

    '        'Quita la clave primaria
    '        Dim pk_campos As String = ObtenerIndice(nombre_tabla, nombre_clave)
    '        lstSQL.Add("ALTER TABLE " & nombre_tabla & " DROP CONSTRAINT " & nombre_clave)

    '        'Quita los índices
    '        Dim dicIndices As New Dictionary(Of String, String)
    '        dicIndices.Clear()

    '        If indices.Trim() <> "" Then
    '            Dim indices_array As String() = indices.Split(",")
    '            For Each indice As String In indices_array
    '                dicIndices(indice) = ObtenerIndice(nombre_tabla, indice)
    '                lstSQL.Add("DROP INDEX " & indice)
    '            Next
    '        End If


    '        'Realiza la modificación de los decimales de los campos (se puede realizar de uno o varios de los campos de la clave primaria a la vez)
    '        For Each oCampo As Cl_Campo In lstCampos
    '            If oCampo.RequiereDecimales Then
    '                Dim decimales_actuales As Integer = ObtenerDecimalesCampo(nombre_tabla, oCampo.Nombre, oCampo.oTipo)
    '                If decimales_actuales < oCampo.Decimales Then
    '                    lstSQL.AddRange(SQLModificarDecimalesCampo(nombre_tabla, oCampo))
    '                End If
    '            End If
    '        Next


    '        'Vuelve a crear la clave primaria
    '        lstSQL.Add("ALTER TABLE " & nombre_tabla & " ADD CONSTRAINT " & nombre_clave & " PRIMARY KEY (" & pk_campos & ") USING INDEX " & nombre_clave)


    '        'Vuelve a crear los índices
    '        If indices.Trim() <> "" Then
    '            For Each indice As String In dicIndices.Keys
    '                lstSQL.Add("CREATE INDEX " & indice & " ON " & nombre_tabla & " (" & dicIndices(indice) & ")")
    '            Next
    '        End If

    '    End If



    '    Return lstSQL


    'End Function



    ' ''' <summary>
    ' ''' Genera las cadenas SQL necesarias para modificar la longirud de los campos de una clave primaria. Para ello, debe borrar la clave y volver a crearla, así como sus índices.
    ' ''' </summary>
    ' ''' <param name="nombre_tabla">Nombre de la tabla</param>
    ' ''' <param name="lstCampos">Lista con los campos de la Clave Primaria a los que se les quiere efectuar cambios</param>
    ' ''' <param name="nombre_clave">Nombre de la clave primaria</param>
    ' ''' <param name="indices">Lista con los nombres de los índices afectados por la lista de lstCampos, separados por comas y sin espacios</param>
    ' ''' <returns>Array de string con las cadenas SQL</returns>
    ' ''' <remarks></remarks>
    'Public Overrides Function SQLModificarLongitudClavePrimaria(ByVal nombre_tabla As String, ByVal lstCampos As List(Of Cl_Campo),
    '                                                  ByVal nombre_clave As String, ByVal indices As String) As List(Of String)

    '    Dim lstSQL As New List(Of String)
    '    lstSQL.Clear()


    '    'Comprueba que exista la clave primaria
    '    If Not ExisteConstraint(nombre_tabla, nombre_clave) Then Throw New ExcepcionActualizacion("No existe Clave primaria " & _
    '        nombre_clave & " en la tabla " & nombre_tabla)


    '    Dim bCambiar As Boolean = False
    '    For Each oCampo As Cl_Campo In lstCampos
    '        Dim longitud As Integer = ObtenerLongitudCampo(nombre_tabla, oCampo.Nombre, oCampo.oTipo)
    '        If longitud < oCampo.Longitud Then
    '            bCambiar = True
    '        End If
    '    Next


    '    If bCambiar Then


    '        'Quita la clave primaria
    '        Dim pk_campos As String = ObtenerIndice(nombre_tabla, nombre_clave)
    '        lstSQL.Add("ALTER TABLE " & nombre_tabla & " DROP CONSTRAINT " & nombre_clave)

    '        'Quita los índices
    '        Dim dicIndices As New Dictionary(Of String, String)
    '        dicIndices.Clear()

    '        If indices.Trim() <> "" Then
    '            Dim indices_array As String() = indices.Split(",")
    '            For Each indice As String In indices_array
    '                dicIndices(indice) = ObtenerIndice(nombre_tabla, indice)
    '                lstSQL.Add("DROP INDEX " & indice)
    '            Next
    '        End If


    '        'Realiza la modificación de la longitud de los campos (se puede realizar de uno o varios de los campos de la clave primaria a la vez)
    '        For Each oCampo As Cl_Campo In lstCampos
    '            If oCampo.RequiereLongitud Then
    '                Dim longitud_actual As Integer = ObtenerLongitudCampo(nombre_tabla, oCampo.Nombre, oCampo.oTipo)
    '                If longitud_actual < oCampo.Longitud Then
    '                    lstSQL.AddRange(SQLModificarLongitudCampo(nombre_tabla, oCampo))
    '                End If
    '            End If
    '        Next


    '        'Vuelve a crear la clave primaria
    '        lstSQL.Add("ALTER TABLE " & nombre_tabla & " ADD CONSTRAINT " & nombre_clave & _
    '            " PRIMARY KEY (" & pk_campos & ") USING INDEX " & nombre_clave)


    '        'Vuelve a crear los índices
    '        If indices.Trim() <> "" Then
    '            For Each indice As String In dicIndices.Keys
    '                lstSQL.Add("CREATE INDEX " & indice & " ON " & nombre_tabla & " (" & dicIndices(indice) & ")")
    '            Next
    '        End If


    '    End If


    '    Return lstSQL


    'End Function


    Public Overrides Function SQLModificarCamposClavePrimaria(ByVal nombre_tabla As String, ByVal lstCampos As List(Of Cl_Campo),
                                                      ByVal nombre_clave As String, ByVal indices As String) As List(Of String)

        Dim lstSQL, lstSQLCampos As New List(Of String)
        Dim bCambiar As Boolean = False
        lstSQL.Clear()
        lstSQLCampos.Clear()


        'Comprueba que exista la clave primaria
        If Not ExisteConstraint(nombre_tabla, nombre_clave) Then Throw New ExcepcionActualizacion("No existe Clave primaria " & _
            nombre_clave & " en la tabla " & nombre_tabla)


        'Comprueba si existen modificaciones pendientes para los campos
        For Each oCampo As Cl_Campo In lstCampos
            lstSQLCampos.AddRange(SQLModificarCampo(nombre_tabla, oCampo))
        Next
        If lstSQLCampos.Count > 0 Then bCambiar = True


        'Sólo hay que modificar si existen campos para cambiar y si los campos tienen actualizaciones pendientes
        If bCambiar And lstCampos.Count > 0 Then


            'Quita la clave primaria
            Dim pk_campos As String = ObtenerIndice(nombre_tabla, nombre_clave)
            lstSQL.Add("ALTER TABLE " & nombre_tabla & " DROP CONSTRAINT " & nombre_clave)

            'Quita los índices
            Dim dicIndices As New Dictionary(Of String, String)
            dicIndices.Clear()

            If indices.Trim() <> "" Then
                Dim indices_array As String() = indices.Split(",")
                For Each indice As String In indices_array
                    dicIndices(indice) = ObtenerIndice(nombre_tabla, indice)
                    lstSQL.Add("DROP INDEX " & indice)
                Next
            End If


            'Añade las modificaciones de los campos
            lstSQL.AddRange(lstSQLCampos)
            

            'Vuelve a crear la clave primaria
            lstSQL.Add("ALTER TABLE " & nombre_tabla & " ADD CONSTRAINT " & nombre_clave & " PRIMARY KEY (" & pk_campos & ") USING INDEX " & nombre_clave)


            'Vuelve a crear los índices
            If indices.Trim() <> "" Then
                For Each indice As String In dicIndices.Keys
                    lstSQL.Add("CREATE INDEX " & indice & " ON " & nombre_tabla & " (" & dicIndices(indice) & ")")
                Next
            End If

        End If


        Return lstSQL

    End Function



    Public Overrides Function SQLModificarClavePrimaria(ByVal nombre_tabla As String, ByVal nombre_clave As String, ByVal oClave As Constructor.Cl_ClavePrimaria) As System.Collections.Generic.List(Of String)

        Dim lstSQL As New List(Of String)
        lstSQL.Clear()

        'Comprueba que exista el índice
        Dim ix_campos As String = ObtenerIndice(nombre_tabla, nombre_clave).Trim()
        If ix_campos = "" Then Throw New ExcepcionActualizacion("Índice " & nombre_clave & " de la tabla " & nombre_tabla & " no existe")


        If ix_campos <> "" And ix_campos.ToLower() <> oClave.ListaCampos.ToLower() Then

            'Sólo para la clave primaria, no para el índice
            lstSQL.Add("ALTER TABLE " & nombre_tabla & " DROP CONSTRAINT " & nombre_clave)
            lstSQL.Add("ALTER TABLE " & nombre_tabla & " ADD CONSTRAINT " & oClave.Nombre & " PRIMARY KEY (" & oClave.ListaCampos & ") USING INDEX " & _
                       oClave.Nombre)

        End If

        Return lstSQL

    End Function



    ''' <summary>
    ''' Genera la Cadena SQL para quitar el indice de una tabla
    ''' </summary>
    ''' <param name="nombre_tabla">Nombre de la tabla</param>
    ''' <param name="nombre_clave">Nombre del índice</param>
    ''' <returns>Cadena SQL para quitar el índice</returns>
    ''' <remarks></remarks>
    Public Overrides Function SQLQuitarClavePrimaria(ByVal nombre_tabla As String, ByVal nombre_clave As String) As List(Of String)

        Dim lstSQL As New List(Of String)
        lstSQL.Clear()


        If ObtenerIndice(nombre_tabla, nombre_clave).Trim() <> "" Then

            Dim sql As String = "ALTER TABLE " & nombre_tabla & " DROP CONSTRAINT " & nombre_clave & " "
            lstSQL.Add(sql)

        End If


        Return lstSQL

    End Function



    Public Overrides Function SQLAñadirIndice(ByVal nombre_tabla As String, ByVal oIndice As Cl_Indice) As List(Of String)

        Dim lstSQL As New List(Of String)
        lstSQL.Clear()

        If Not ExisteConstraint(nombre_tabla, oIndice.Nombre) Then

            Dim sql As String = "CREATE INDEX " & oIndice.Nombre & " ON " & nombre_tabla & " (" & oIndice.ListaCampos & ")"
            lstSQL.Add(sql)

        End If


        Return lstSQL

    End Function



    Public Overrides Function SQLModificarIndice(ByVal nombre_tabla As String, ByVal nombre_indice As String, ByVal oIndice As Cl_Indice) As List(Of String)

        Dim lstSQL As New List(Of String)
        lstSQL.Clear()


        'Comprueba que exista el índice
        Dim ix_campos As String = ObtenerIndice(nombre_tabla, nombre_indice).Trim()
        If ix_campos = "" Then Throw New ExcepcionActualizacion("Índice " & nombre_indice & " de la tabla " & nombre_tabla & " no existe")


        If ix_campos <> "" And ix_campos.ToLower() <> oIndice.ListaCampos.ToLower() Then

            lstSQL.Add("DROP INDEX " & nombre_indice)
            lstSQL.Add("CREATE INDEX " & nombre_indice & " ON " & nombre_tabla & " (" & ix_campos & ")")

        End If

        Return lstSQL


    End Function



    ''' <summary>
    ''' Genera la Cadena SQL para quitar el indice de una tabla
    ''' </summary>
    ''' <param name="nombre_tabla">Nombre de la tabla</param>
    ''' <param name="nombre_indice">Nombre del índice</param>
    ''' <returns>Cadena SQL para quitar el índice</returns>
    ''' <remarks></remarks>
    Public Overrides Function SQLQuitarIndice(ByVal nombre_tabla As String, ByVal nombre_indice As String) As List(Of String)

        Dim lstSQL As New List(Of String)
        lstSQL.Clear()


        If ObtenerIndice(nombre_tabla, nombre_indice).Trim() <> "" Then

            'En firebird no hay índices con el mismo nombre, pues no se guardan a nivel de tabla, sino a nivel de BBDD
            'TODO: Comprobar esto último
            Dim sql As String = "DROP INDEX " & nombre_indice
            lstSQL.Add(sql)

        End If


        Return lstSQL

    End Function




    Protected Function ObtenerCamposPosteriores(ByVal nombre_tabla As String, ByVal nombre_campo As String, ByRef posicion As Integer) As String

        Dim campos As String = ""
        Dim sql As String = "SELECT RDB$RELATION_FIELDS.RDB$FIELD_NAME AS COLUMNA FROM RDB$RELATION_FIELDS WHERE RDB$RELATION_NAME = '" & nombre_tabla & "'" & _
            " ORDER BY RDB$RELATION_FIELDS.RDB$FIELD_POSITION"
        Dim contador As Integer = 1
        posicion = -1


        Try

            Dim dt As DataTable = _proveedor.ObtenerTabla(sql)

            If Not IsNothing(dt) Then


                For Each row As DataRow In dt.Rows

                    Dim campo As String = row("COLUMNA").ToString().Trim()

                    If campo = nombre_campo.Trim() Then
                        posicion = contador
                    Else

                        If posicion > -1 Then
                            If campos.Trim() <> "" Then campos = campos & ","
                            campos = campos & campo
                        End If

                    End If

                    contador = contador + 1

                Next


            End If


        Catch ex As Exception
            Throw New ExcepcionActualizacion("Error al obtener los campos posteriores a " & nombre_campo & " en la tabla " & nombre_tabla)
        End Try



        Return campos

    End Function



End Class
