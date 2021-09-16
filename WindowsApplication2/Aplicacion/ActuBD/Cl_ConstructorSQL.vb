Imports System.Collections.Generic
Imports NetAgro.ProveedorDatos
Imports NetAgro.Constructor

Public Class Cl_ConstructorSQL
    Inherits Cl_ConstructorConsultas

    Public Sub New(ByVal proveedor As Cl_ProveedorDatos)

        MyBase.New(proveedor)

        Cadena_Tipo_Campo = {"CHAR", "VARCHAR", "NVARCHAR", "INT", "FLOAT", "FLOAT", "DECIMAL", "NUMERIC", "TEXT", "DATE", "DATETIME", ""}
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

            sql = "Select ID from SYSOBJECTS where name='" & nombre_tabla & "' and xtype='U'"
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

            sql = "Select syscolumns.length from syscolumns,sysobjects where sysobjects.name='" & _
                nombre_tabla & "' AND sysobjects.xtype='U' and syscolumns.id=sysobjects.id and syscolumns.name='" & _
                nombre_campo & "'"

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

            'Dim sql As String = "Select syscolumns.length from syscolumns,sysobjects where sysobjects.name='" & _
            '    nombre_tabla & "' AND sysobjects.xtype='U' and syscolumns.id=sysobjects.id and syscolumns.name='" & _
            '    nombre_campo & "'"
            'If TipoCampo = Tipo_Campo.Tipo_decimal Or TipoCampo = Tipo_Campo.Tipo_numeric Then
            '    sql = sql.Replace("syscolumns.length", "syscolumns.prec")
            'End If

            Dim sql As String = "SELECT character_maximum_length " & vbCrLf & _
                " FROM information_schema.columns " & vbCrLf & _
                " where table_name = '" & nombre_tabla & "'" & vbCrLf & _
                " and column_name = '" & nombre_campo & "'"

            If TipoCampo = Tipo_Campo.Tipo_decimal Or TipoCampo = Tipo_Campo.Tipo_numeric Then
                sql = "SELECT numeric_precision " & vbCrLf & _
                " FROM information_schema.columns " & vbCrLf & _
                " where table_name = '" & nombre_tabla & "'" & vbCrLf & _
                " and column_name = '" & nombre_campo & "'"
            End If


            Dim l As Object = _proveedor.EjecutarEscalar(sql)

            If Not Integer.TryParse(l, longitud) Or IsNothing(l) Then
                'If longitud = -1 Or IsNothing(l) Then Throw New ExcepcionActualizacion("Error al obtener la longitud del campo " & nombre_campo & _
                '" de la tabla " & nombre_tabla)

                'If longitud = -1 Or IsNothing(l) Then berror = True
                If IsNothing(l) Then longitud = -1

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

            Dim sql As String = "Select syscolumns.scale from syscolumns,sysobjects where sysobjects.name='" & _
                nombre_tabla & "' AND sysobjects.xtype='U' and syscolumns.id=sysobjects.id and syscolumns.name='" & _
                nombre_campo & "'"

            Dim d As Object = _proveedor.EjecutarEscalar(sql)

            If Not Integer.TryParse(d, decimales) Or IsNothing(d) Then
                If decimales = Cl_Campo.NODECIMALES Or IsNothing(d) Then Throw New ExcepcionActualizacion("Error al obtener decimales del campo " & nombre_campo & _
                " de la tabla " & nombre_tabla)
            End If

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

            Dim sql As String = "SELECT id FROM SYSINDEXES WHERE { fn UCASE(name) }='" & nombre_indice.ToUpper() & "'"
            bRes = ExisteResultado(sql)

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
        Dim sql As String = ""


        'TODO: Comprobar en versiones antiguas
        sql = "SELECT cols.name COLUMNA FROM sys.columns cols, sys.indexes ind, sys.index_columns ind_cols" & _
            " WHERE cols.object_id = ind.object_id AND cols.object_id = ind_cols.object_id AND cols.column_id = ind_cols.column_id" & _
            " AND ind.index_id = ind_cols.index_id AND object_name(cols.object_id) = '" & nombre_tabla & "'" & _
            " AND ind.name = '" & nombre_indice & "'" & _
            " ORDER BY key_ordinal"


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
    '                                               Optional ByVal nombre_clave As String = "", Optional ByVal campos_indice As String = "",
    '                                               Optional ByVal nombre_indice As String = "") As List(Of String)

    '    Dim lstSQL As New List(Of String)
    '    lstSQL.Clear()


    '    If Not ExisteTabla(nombre_tabla) Then


    '        'Sentencia CREATE TABLE
    '        Dim sql As String = "CREATE TABLE [dbo].[" & nombre_tabla & "] ("

    '        Dim cont As Integer = 1
    '        For Each oCampo As Cl_Campo In lstCampos

    '            sql = sql & "[" & oCampo.Nombre & "] " & Cadena_Tipo_Campo(oCampo.oTipo)

    '            If oCampo.RequiereDecimales Then
    '                sql = sql & "(" & oCampo.Longitud.ToString() & "," & oCampo.Decimales.ToString() & ")"
    '            ElseIf oCampo.RequiereLongitud Then
    '                sql = sql & "(" & oCampo.Longitud.ToString() & ")"
    '            End If

    '            If oCampo.UsaTexto Then sql = sql & " COLLATE Modern_Spanish_CI_AS"
    '            If Not oCampo.PermiteNulos Then sql = sql & " NOT NULL"
    '            sql = sql & " DEFAULT " & Cadena_Valor_Defecto(oCampo.oTipo)
    '            If cont < lstCampos.Count Then sql = sql & ","
    '            cont = cont + 1
    '        Next

    '        sql = sql & ") ON [PRIMARY]"
    '        lstSQL.Add(sql.ToString())


    '        'Clave primaria
    '        If (campos_clave.Trim() <> "" And nombre_clave.Trim() = "") Or (campos_clave.Trim() = "" And nombre_clave.Trim() <> "") Then
    '            Throw New ExcepcionActualizacion("Debe proporcionar el nombre y los campos para la clave primaria en la tabla " & nombre_tabla)
    '        End If

    '        If campos_clave.Trim() <> "" And nombre_clave.Trim() <> "" Then
    '            lstSQL.Add("ALTER TABLE dbo.[" & nombre_tabla & "] ADD CONSTRAINT " & nombre_clave & _
    '                       " PRIMARY KEY (" & campos_clave & ") ON [PRIMARY]")
    '        End If


    '        'Índice
    '        If (campos_indice.Trim() <> "" And nombre_indice.Trim() = "") Or (campos_indice.Trim() = "" And nombre_indice.Trim() <> "") Then
    '            Throw New ExcepcionActualizacion("Debe proporcionar el nombre y los campos para el índice en la tabla " & nombre_tabla)
    '        End If

    '        If campos_indice.Trim() <> "" And nombre_indice.Trim() <> "" Then
    '            lstSQL.Add("CREATE  INDEX [" & nombre_indice & "] ON [dbo].[" & nombre_tabla & "](" & _
    '                       campos_indice & ") ON [PRIMARY]")
    '        End If


    '    End If



    '    Return lstSQL

    'End Function


    Public Overrides Function SQLCrearTabla(ByVal oTabla As Cl_Tabla) As List(Of String)

        Dim lstSQL As New List(Of String)


        If Not ExisteTabla(oTabla.Nombre) Then

            'Sentencia CREATE TABLE
            Dim sql As String = "CREATE TABLE [dbo].[" & oTabla.Nombre & "] ("

            Dim cont As Integer = 1
            For Each oCampo As Cl_Campo In oTabla.Campos

                sql = sql & "[" & oCampo.Nombre & "] " & Cadena_Tipo_Campo(oCampo.oTipo)

                If oCampo.RequiereDecimales Then
                    sql = sql & "(" & oCampo.Longitud.ToString() & "," & oCampo.Decimales.ToString() & ")"
                ElseIf oCampo.RequiereLongitud Then
                    sql = sql & "(" & oCampo.Longitud.ToString() & ")"
                End If

                If oCampo.UsaTexto Then sql = sql & " COLLATE Modern_Spanish_CI_AS"
                If Not oCampo.PermiteNulos Then sql = sql & " NOT NULL"
                sql = sql & " DEFAULT " & Cadena_Valor_Defecto(oCampo.oTipo)
                If cont < oTabla.Campos.Count Then sql = sql & ","
                cont = cont + 1
            Next

            sql = sql & ") ON [PRIMARY]"
            lstSQL.Add(sql.ToString())


            'Clave primaria
            If Not IsNothing(oTabla.Clave) Then

                If (oTabla.Clave.ListaCampos <> "" And oTabla.Clave.Nombre = "") Or (oTabla.Clave.ListaCampos = "" And oTabla.Clave.Nombre <> "") Then
                    Throw New ExcepcionActualizacion("Debe proporcionar el nombre y los campos para la clave primaria en la tabla " & oTabla.Nombre)
                End If

                If oTabla.Clave.ListaCampos <> "" And oTabla.Clave.Nombre <> "" Then
                    lstSQL.Add("ALTER TABLE dbo.[" & oTabla.Nombre & "] ADD CONSTRAINT " & oTabla.Clave.Nombre & _
                               " PRIMARY KEY (" & oTabla.Clave.ListaCampos & ") ON [PRIMARY]")
                End If

            End If

            'Índices
            For Each indice As Cl_Indice In oTabla.Indices

                If (indice.ListaCampos <> "" And indice.Nombre = "") Or (indice.ListaCampos = "" And indice.Nombre <> "") Then
                    Throw New ExcepcionActualizacion("Debe proporcionar el nombre y los campos para el índice en la tabla " & oTabla.Nombre)
                End If

                If indice.ListaCampos <> "" And indice.Nombre <> "" Then
                    lstSQL.Add("CREATE  INDEX [" & indice.Nombre & "] ON [dbo].[" & oTabla.Nombre & "](" & indice.ListaCampos & ") ON [PRIMARY]")
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
    '        Dim sql As String = "ALTER TABLE " & nombre_tabla & " ADD " & nombre_campo & " " & tipo
    '        If bDecimales Then
    '            sql = sql & "(" & longitud.ToString() & "," & decimales.ToString() & ")"
    '        ElseIf bLongitud Then
    '            sql = sql & "(" & longitud.ToString() & ")"
    '        End If

    '        If bTexto Then sql = sql & " COLLATE Modern_Spanish_CI_AS"
    '        sql = sql & " NOT NULL DEFAULT " & valor_defecto
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
            Dim sql As String = "ALTER TABLE " & nombre_tabla & " ADD " & oCampo.Nombre & " " & tipo
            If bDecimales Then
                sql = sql & "(" & oCampo.Longitud.ToString() & "," & oCampo.Decimales.ToString() & ")"
            ElseIf bLongitud Then
                sql = sql & "(" & oCampo.Longitud.ToString() & ")"
            End If

            If bTexto Then sql = sql & " COLLATE Modern_Spanish_CI_AS"
            sql = sql & " NOT NULL DEFAULT " & valor_defecto
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
            'Dim sqlUpdate = ("UPDATE " & nombre_tabla & " SET " & oCampo.Nombre & "=" & valor_defecto)
            'If _TipoConexion = Tipo_Conexion.Pervasive Then sqlUpdate = sqlUpdate.ToLower()
            'lstSQL.Add(sqlUpdate)


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

    '        sql = "ALTER TABLE " & nombre_tabla & " ALTER COLUMN " & oCampo.Nombre & " " & Cadena_Tipo_Campo(oCampo.oTipo)

    '        If oCampo.RequiereDecimales Then
    '            sql = sql & "(" & oCampo.Longitud.ToString() & "," & oCampo.Decimales.ToString() & ")"
    '        ElseIf oCampo.RequiereLongitud Then
    '            sql = sql & "(" & oCampo.Longitud.ToString() & ")"
    '        End If

    '        If Not oCampo.PermiteNulos Then sql = sql & " NOT NULL"

    '        lstSQL.Add(sql)

    '    End If


    '    Return lstSQL


    'End Function


    Public Overrides Function SQLModificarCampo(ByVal nombre_tabla As String, ByVal oCampo As Cl_Campo) As List(Of String)

        Dim lstSQL As New List(Of String)
        lstSQL.Clear()


        Dim longitud As Integer = ObtenerLongitudCampo(nombre_tabla, oCampo.Nombre, oCampo.oTipo)
        Dim decimales = ObtenerDecimalesCampo(nombre_tabla, oCampo.Nombre, oCampo.oTipo)

        Dim bCambiar As Boolean = False
        If oCampo.RequiereLongitud And longitud < oCampo.Longitud Then bCambiar = True
        If oCampo.RequiereDecimales And decimales < oCampo.Decimales Then bCambiar = True


        If bCambiar Then

            Dim sql As String = "ALTER TABLE " & nombre_tabla & " ALTER COLUMN " & oCampo.Nombre & " " & Cadena_Tipo_Campo(oCampo.oTipo)

            If oCampo.RequiereDecimales Then
                sql = sql & "(" & oCampo.Longitud.ToString() & "," & oCampo.Decimales.ToString() & ")"
            ElseIf oCampo.RequiereLongitud Then
                sql = sql & "(" & oCampo.Longitud.ToString() & ")"
            End If

            If Not oCampo.PermiteNulos Then sql = sql & " NOT NULL"

            lstSQL.Add(sql)

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

    '            Dim sql As String = "ALTER TABLE " & nombre_tabla & " ALTER COLUMN " & oCampo.Nombre & " " & Cadena_Tipo_Campo(oCampo.oTipo)
    '            sql = sql & "(" & oCampo.Longitud.ToString() & "," & oCampo.Decimales.ToString() & ")"
    '            If Not oCampo.PermiteNulos Then sql = sql & " NOT NULL"
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

                'Primero hay que quitar las restricciones sobre el campo, si existen
                Dim sql As String = "Select SysObjects.Name As RESTRICCION From SysObjects Inner Join (Select NAME,ID From SysObjects Where XType = 'U')" & _
                    " As TABLAS On TABLAS.ID = Sysobjects.Parent_Obj Inner Join sysconstraints On sysconstraints.Constid = Sysobjects.ID " & _
                    " Inner Join SysColumns On syscolumns.ColID = sysconstraints.ColID And syscolumns.ID = TABLAS.ID" & _
                    " where TABLAS.name = '" & nombre_tabla & "' AND syscolumns.name  = '" & nombre_campo & "'"

                Dim dt As DataTable = _proveedor.ObtenerTabla(sql)
                For Each row As DataRow In dt.Rows
                    Dim restriccion As String = row("RESTRICCION").ToString() & ""
                    If restriccion.Trim() <> "" Then
                        lstSQL.Add("ALTER TABLE [dbo].[" & nombre_tabla & "] DROP CONSTRAINT [" & restriccion & "]")
                    End If
                Next


                lstSQL.Add("ALTER TABLE " & nombre_tabla & " DROP COLUMN " & nombre_campo)

            End If

        End If


        Return lstSQL

    End Function




    ' ''' <summary>
    ' ''' Genera la cadena SQL para añadir un índice a una tabla 
    ' ''' </summary>
    ' ''' <param name="nombre_tabla">Nombre de la tabla</param>
    ' ''' <param name="nombre_indice">Nombre del nuevo índice</param>
    ' ''' <param name="campos">Cadena con los nombres de los campos, separados por comas, tal como iría en la consulta SQL</param>
    ' ''' <returns>Lista con las cadenas SQL generadas</returns>
    ' ''' <remarks></remarks>
    'Public Overrides Function SQLAñadirClavePrimaria(ByVal nombre_tabla As String, ByVal nombre_indice As String, ByVal campos As String) As List(Of String)

    '    Dim lstSQL As New List(Of String)
    '    Dim sql As String = ""


    '    'If ExisteConstraint(nombre_tabla, nombre_indice) Then Throw New ExcepcionActualizacion("Ya existe una clave primaria en la tabla " & _
    '    'nombre_tabla)

    '    If Not ExisteConstraint(nombre_tabla, nombre_indice) Then

    '        'Le inserta los corchetes
    '        Dim indices As String = ""
    '        Dim nuevo_indice_array As String() = campos.Split(",")
    '        For i As Integer = 0 To nuevo_indice_array.Length - 1
    '            indices = indices & "[" & nuevo_indice_array(i) & "]"
    '            If i < nuevo_indice_array.Length - 1 Then indices = indices & ","
    '        Next

    '        'Crea el nuevo índice
    '        sql = "ALTER TABLE [dbo].[" & nombre_tabla & "] ADD CONSTRAINT [" & nombre_indice & "] PRIMARY KEY (" & indices & ") ON [PRIMARY]  "
    '        lstSQL.Add(sql)


    '    End If


    '    Return lstSQL

    'End Function



    Public Overrides Function SQLAñadirClavePrimaria(ByVal nombre_tabla As String, ByVal oClave As Cl_ClavePrimaria) As List(Of String)

        Dim lstSQL As New List(Of String)
        Dim sql As String = ""


        'If ExisteConstraint(nombre_tabla, nombre_indice) Then Throw New ExcepcionActualizacion("Ya existe una clave primaria en la tabla " & _
        'nombre_tabla)

        If Not ExisteConstraint(nombre_tabla, oClave.Nombre) Then

            'Le inserta los corchetes
            Dim indices As String = ""
            Dim nuevo_indice_array As String() = oClave.ListaCampos.Split(",")
            For i As Integer = 0 To nuevo_indice_array.Length - 1
                indices = indices & "[" & nuevo_indice_array(i) & "]"
                If i < nuevo_indice_array.Length - 1 Then indices = indices & ","
            Next

            'Crea el nuevo índice
            sql = "ALTER TABLE [dbo].[" & nombre_tabla & "] ADD CONSTRAINT [" & oClave.Nombre & "] PRIMARY KEY (" & indices & ") ON [PRIMARY]  "
            lstSQL.Add(sql)


        End If


        Return lstSQL

    End Function




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
    '        lstSQL.Add("ALTER TABLE [dbo].[" & nombre_tabla & "]  DROP CONSTRAINT [" & nombre_clave & "]")

    '        'Quita los índices
    '        Dim dicIndices As New Dictionary(Of String, String)
    '        dicIndices.Clear()

    '        If indices.Trim() <> "" Then
    '            Dim indices_array As String() = indices.Split(",")
    '            For Each indice As String In indices_array
    '                dicIndices(indice) = ObtenerIndice(nombre_tabla, indice)
    '                lstSQL.Add("DROP INDEX [dbo].[" & nombre_tabla & "].[" & indice & "]")
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
    '        lstSQL.Add("ALTER TABLE [dbo].[" & nombre_tabla & "] ADD CONSTRAINT [" & nombre_clave & _
    '                   "] PRIMARY KEY (" & pk_campos & ") ON [PRIMARY]")


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
    '        lstSQL.Add("ALTER TABLE [dbo].[" & nombre_tabla & "]  DROP CONSTRAINT [" & nombre_clave & "]")

    '        'Quita los índices
    '        Dim dicIndices As New Dictionary(Of String, String)
    '        dicIndices.Clear()

    '        If indices.Trim() <> "" Then
    '            Dim indices_array As String() = indices.Split(",")
    '            For Each indice As String In indices_array
    '                dicIndices(indice) = ObtenerIndice(nombre_tabla, indice)
    '                lstSQL.Add("DROP INDEX [dbo].[" & nombre_tabla & "].[" & indice & "]")
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
    '        lstSQL.Add("ALTER TABLE [dbo].[" & nombre_tabla & "] ADD CONSTRAINT [" & nombre_clave & _
    '                   "] PRIMARY KEY (" & pk_campos & ") ON [PRIMARY]")


    '        'Vuelve a crear los índices
    '        If indices.Trim() <> "" Then
    '            For Each indice As String In dicIndices.Keys
    '                lstSQL.Add("CREATE INDEX " & indice & " ON " & nombre_tabla & " (" & dicIndices(indice) & ")")
    '            Next
    '        End If

    '    End If



    '    Return lstSQL


    'End Function


    Public Overrides Function SQLModificarCamposClavePrimaria(ByVal nombre_tabla As String, ByVal lstCampos As System.Collections.Generic.List(Of Constructor.Cl_Campo),
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
            lstSQL.Add("ALTER TABLE [dbo].[" & nombre_tabla & "]  DROP CONSTRAINT [" & nombre_clave & "]")

            'Quita los índices
            Dim dicIndices As New Dictionary(Of String, String)
            dicIndices.Clear()

            If indices.Trim() <> "" Then
                Dim indices_array As String() = indices.Split(",")
                For Each indice As String In indices_array
                    dicIndices(indice) = ObtenerIndice(nombre_tabla, indice)
                    lstSQL.Add("DROP INDEX [dbo].[" & nombre_tabla & "].[" & indice & "]")
                Next
            End If


            'Añade las modificaciones de los campos
            lstSQL.AddRange(lstSQLCampos)


            'Vuelve a crear la clave primaria
            lstSQL.Add("ALTER TABLE [dbo].[" & nombre_tabla & "] ADD CONSTRAINT [" & nombre_clave & _
                       "] PRIMARY KEY (" & pk_campos & ") ON [PRIMARY]")


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
            lstSQL.Add("ALTER TABLE [dbo].[" & nombre_tabla & "]  DROP CONSTRAINT [" & nombre_clave & "]")
            lstSQL.Add("ALTER TABLE [dbo].[" & nombre_tabla & "] ADD CONSTRAINT [" & oClave.Nombre & _
                "] PRIMARY KEY (" & oClave.ListaCampos & ") ON [PRIMARY]")

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

            Dim sql As String = "ALTER TABLE [dbo].[" & nombre_tabla & "]  DROP CONSTRAINT [" & nombre_clave & "] "
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



    ' ''' <summary>
    ' ''' Devuelve las cadenas SQL para modificar un indice de una tabla
    ' ''' </summary>
    ' ''' <param name="nombre_tabla">Nombre de la tabla</param>
    ' ''' <param name="nombre_indice">Nombre del índice</param>
    ' ''' <param name="nuevo_nombre_indice">Nombre del nuevo índice en caso de que cambie</param>
    ' ''' <param name="campos">Cadena con los nombres de los campos, separados por comas, tal como iría en la consulta SQL: "CAMPO1, CAMPO2, CAMPO3,..."</param>
    ' ''' <returns>Lista con las cadenas SQL necesarias</returns>
    ' ''' <remarks></remarks>
    'Public Overrides Function SQLModificarIndice(ByVal nombre_tabla As String, ByVal nombre_indice As String, ByVal nuevo_nombre_indice As String, ByVal campos As String, ByVal primaria As Boolean) As List(Of String)

    '    If nuevo_nombre_indice.Trim() = "" Then nuevo_nombre_indice = nombre_indice


    '    Dim lstSQL As New List(Of String)
    '    lstSQL.Clear()


    '    Dim ix_campos As String = ObtenerIndice(nombre_tabla, nuevo_nombre_indice)
    '    If ix_campos.Trim() = "" Then Throw New ExcepcionActualizacion("Índice " & nombre_indice & " de la tabla " & nombre_tabla & " no existe")

    '    If ix_campos.Trim() <> "" And ix_campos.Trim().ToLower() <> campos.Trim().ToLower() Then

    '        'Diferencia entre clave primaria e índice
    '        If primaria Then
    '            lstSQL.Add("ALTER TABLE [dbo].[" & nombre_tabla & "]  DROP CONSTRAINT [" & nombre_indice & "]")
    '            lstSQL.Add("ALTER TABLE [dbo].[" & nombre_tabla & "] ADD CONSTRAINT [" & nombre_indice & _
    '                "] PRIMARY KEY (" & campos & ") ON [PRIMARY]")
    '        Else
    '            lstSQL.Add("DROP INDEX [dbo].[" & nombre_tabla & "].[" & nombre_indice & "]")
    '            lstSQL.Add("CREATE INDEX " & nombre_indice & " ON " & nombre_tabla & " (" & ix_campos & ")")
    '        End If

    '    End If

    '    Return lstSQL


    'End Function


    
    Public Overrides Function SQLModificarIndice(ByVal nombre_tabla As String, ByVal nombre_indice As String, ByVal oIndice As Cl_Indice) As List(Of String)

        Dim lstSQL As New List(Of String)
        lstSQL.Clear()

        'Comprueba que exista el índice
        Dim ix_campos As String = ObtenerIndice(nombre_tabla, nombre_indice).Trim()
        If ix_campos = "" Then Throw New ExcepcionActualizacion("Índice " & nombre_indice & " de la tabla " & nombre_tabla & " no existe")


        If ix_campos <> "" And ix_campos.ToLower() <> oIndice.ListaCampos.ToLower() Then

            'Sólo para el índice, no la clave primaria
            lstSQL.Add("DROP INDEX [dbo].[" & nombre_tabla & "].[" & nombre_indice & "]")
            lstSQL.Add("CREATE INDEX " & oIndice.Nombre & " ON " & nombre_tabla & " (" & oIndice.ListaCampos & ")")


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

            Dim sql As String = "DROP INDEX [dbo].[" & nombre_tabla & "].[" & nombre_indice & "]"
            lstSQL.Add(sql)

        End If


        Return lstSQL


    End Function


End Class
