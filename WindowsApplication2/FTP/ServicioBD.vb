Public Class ServicioBd

    Dim cnDocumentos As SqlClient.SqlConnection
    Dim _tabla As String


    Public Sub New(ByVal strConexion As String, tabla As String)

        cnDocumentos = New SqlClient.SqlConnection(strConexion)
        _tabla = tabla

    End Sub


    Public Function RecogeDocumentosPorNIF(ByVal nif As String)

        Dim sql As String = "SELECT R.IdRegistro, D1.Descripcion as Archivo, D1.IdNuxeo" & vbCrLf
        sql = sql & " FROM CobrosPagos.dbo.RegistroDocumentos as R" & vbCrLf
        sql = sql & " LEFT JOIN Documentos.dbo.Doc1 as D1 ON D1.idclave = 'RegistroDocumentos_' +  CAST(R.IdRegistro as varchar)" & vbCrLf
        sql = sql & " WHERE NIF = '" & nif & "'" & vbCrLf
        sql = sql & " AND Asociado <> 'S' AND COALESCE(D1.Descripcion,'') <> ''" & vbCrLf
        sql = sql & " ORDER BY Archivo" & vbCrLf

        Dim odatatable As New DataTable
        odatatable = ConsultaSQL(sql)


        Return odatatable

    End Function


    Public Function RecogeDocumentos(ByVal id As String) As DataTable

        Dim odatatable As New DataTable

        odatatable = ConsultaSQL(" Select descripcion as Archivo, idnuxeo from documentos.dbo." & _tabla & " where idclave='" + id.Trim + "' ")


        Return odatatable

    End Function

    Public Function InsertaDocumento(ByVal id As String, ByVal uid As String, ByVal descripcion As String, ByVal TipoDocumento As String) As Integer

        Return OrdenSql("insert into " & _tabla & " (idclave, idnuxeo, descripcion, tipodocumento) values('" + id + "','" + uid + "','" + descripcion + "', '" & TipoDocumento & "')")

    End Function


    Public Function EliminaDocumento(ByVal id As String, ByVal uid As String) As Integer

        Return OrdenSql("delete from " & _tabla & " where (idclave ='" + id + "' and  idnuxeo = '" + uid + "')")

    End Function


    Public Function UltimoDocumento() As String

        Dim resultado As Integer = 0

        Dim dt As DataTable = ConsultaSQL("SELECT MAX(idnuxeo) as Expr1 FROM " & _tabla)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0)(0) IsNot DBNull.Value Then
                resultado = VaInt(dt.Rows(0)(0)) + 1
            Else
                resultado = 1
            End If
        Else
            resultado = 1
        End If


        Return resultado.ToString

    End Function

    Public Function ReplicaDocumento(ByVal idOriginal As String, ByVal idCopia As String) As Integer

        Return OrdenSql(" insert into " & _tabla & " (idclave, idnuxeo, descripcion) select '" + idCopia + "', idnuxeo, descripcion from " & _tabla & " where idclave = '" + idOriginal + "'")

    End Function


    ''' <summary>
    ''' Ejecuta una consulta sql
    ''' </summary>
    ''' <param name="orden">Cadena con la consulta sql</param>
    ''' <returns>Devuelve true si se ha ejecutado correctamente, y false en caso de error</returns>
    ''' <remarks></remarks>
    Public Function OrdenSql(ByVal orden As String) As Boolean
        Try
            cnDocumentos.Open()
            Dim command As SqlClient.SqlCommand
            command = cnDocumentos.CreateCommand()
            command.CommandText = orden
            command.ExecuteNonQuery()
            cnDocumentos.Close()
            ' aqui llamar a clase control trazabilidad uso de la bd
            Return True
        Catch ex As Exception
            If cnDocumentos.State = ConnectionState.Open Then cnDocumentos.Close()
            Return (False)
        End Try

    End Function



    Protected Overridable Function AdaptaConsulta(consulta As String) As String

        Return consulta.Replace("Contabilidad.dbo.", ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".dbo.")

    End Function


    ''' <summary>
    ''' Devuelve el resultado de una consulta sql
    ''' </summary>
    ''' <param name="consulta">Cadena con la consulta sql</param>
    ''' <returns>Devuelve un DataTable con el resultado, en caso de error devuelve Nothing</returns>
    ''' <remarks></remarks>
    Public Function ConsultaSQL(ByVal consulta As String) As DataTable

        Try

            consulta = AdaptaConsulta(consulta)

            Dim oDatatable As New DataTable
            Dim ta = New SqlClient.SqlDataAdapter(consulta, cnDocumentos)
            ta.Fill(oDatatable)
            Return oDatatable

        Catch ex As Exception
            Return Nothing
        End Try

    End Function


End Class