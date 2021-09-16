Module GestionDocumental


    Public Sub ActualizaBotonGestionDocumental(bt As Button, Entidad As Cdatos.Entidad, Id As String)


        'Sólo si tiene la imagen de "SIN GESTIÓN DOCUMENTAL"
        If ExisteGestionDocumentalEntidad(Entidad, Id) Then
            bt.Image = My.Resources.GD_ACTIVO
        Else
            bt.Image = My.Resources.GD_INACTIVO
        End If


    End Sub


    Public Function ExisteGestionDocumentalEntidad(Entidad As Cdatos.Entidad, Id As String) As Boolean

        Dim bRes As Boolean = False



        Dim clave As String = Entidad.NombreBd & SeparadorCtb & Entidad.NombreTabla & SeparadorCtb & Id


        Try

            CnDoc.AbrirConexion()


            Dim sql As String = "SELECT Count(*) as Cont FROM Documentos_" & MiMaletin.IdEmpresaCTB.ToString & vbCrLf
            sql = sql & " WHERE IdClave = '" & clave & "'"


            Dim dt As DataTable = CnDoc.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count = 1 Then

                    Dim cont As Integer = VaInt(dt.Rows(0)("Cont"))
                    bRes = (cont > 0)

                End If
            End If


        Catch ex As Exception
        End Try


        If CnDoc.Conn.State = ConnectionState.Open Then
            CnDoc.CerrarConexion()
        End If



        Return bRes

    End Function


    Public Sub GeneraGestionDocumental(ByRef Impreso As Impreso, Entidad As Cdatos.Entidad)


        'Dim bDocumental As Boolean = False
        Dim bDocumental As Boolean = True


        Dim Id As String = Entidad.ClavePrimaria.Valor & ""
        If VaDec(Id) > 0 Then


            Try

                CnDoc.AbrirConexion()

                'Clave
                Dim clave As String = Entidad.NombreBd & SeparadorCtb & Entidad.NombreTabla & SeparadorCtb & Id


                'Descripción
                Dim NombreDocumento As String = ""
                If Entidad.CamposDocumentoExtendido.Count > 0 Then
                    NombreDocumento = ""
                    For Each campo As Cdatos.bdcampo In Entidad.CamposDocumentoExtendido
                        If NombreDocumento.Trim <> "" Then NombreDocumento = NombreDocumento & "_"
                        NombreDocumento = NombreDocumento & campo.Valor
                    Next
                Else
                    NombreDocumento = Entidad.ClavePrimaria.Valor
                End If
                NombreDocumento = Entidad.NombreTabla & " " & NombreDocumento


                'TipoDocumento
                Dim TipoDocumento As String = "DOCUMENTO_ERP"


                'Borra registros por clave, descripción y tipo de documento
                Dim sql As String = "DELETE FROM Documentos_" & MiMaletin.IdEmpresaCTB.ToString & vbCrLf
                sql = sql & " WHERE IdClave = '" & clave & "' AND Descripcion = '" & NombreDocumento & "' AND TipoDocumento = '" & TipoDocumento & "'" & vbCrLf

                CnDoc.OrdenSql(sql)


                'Dim sql As String = "SELECT Id FROM Documentos_" & MiMaletin.IdEmpresaCTB.ToString & vbCrLf
                'sql = sql & " WHERE IdClave = '" & clave & "'" & vbCrLf
                'sql = sql & " AND TipoDocumento = 'DOCUMENTO_ERP'"

                'Dim dt As DataTable = CnDoc.ConsultaSQL(sql)
                'If Not IsNothing(dt) Then
                '    If dt.Rows.Count = 0 Then
                '        bDocumental = True
                '    End If
                'End If



                If bDocumental Then
                    GenerarDocumento(Impreso, Entidad, NombreDocumento, TipoDocumento)
                End If


            Catch ex As Exception

            End Try

            If CnDoc.conn.State = ConnectionState.Open Then
                CnDoc.CerrarConexion()
            End If


        End If



    End Sub


    Private Sub GenerarDocumento(ByRef Impreso As Impreso, ByVal Entidad As Cdatos.Entidad, ByVal NombreDocumento As String, ByVal TipoDocumento As String)

        Try


            Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)

            Dim ruta As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_ARCHIVOS_ADJUNTOS_TEMP) & ""
            If Not ruta.EndsWith("\") Then ruta = ruta & "\"

            Dim Id As String = Entidad.ClavePrimaria.Valor & ""
            Dim archivo As String = Entidad.NombreTabla & "_" & Id & ".pdf"


            If Not IsNothing(Impreso.f.documento) Then

                Impreso.f.documento.EndDoc()

                Impreso.f.documento.Export(ruta & archivo)
                SubirGestionDocumental(Entidad, NombreDocumento, TipoDocumento, ruta & archivo)

                Impreso.Dispose()

            End If


            

        Catch ex As Exception
            MsgBox("Error al subir el documento a gestión documental")
        End Try


    End Sub


    Private Function SubirGestionDocumental(ByVal Entidad As Cdatos.Entidad, ByVal NombreDocumento As String, ByVal Tipodocumento As String, ByVal Archivo As String) As Boolean

        Dim bRes As Boolean = True

        Try


            'Clave
            Dim Id As String = Entidad.ClavePrimaria.Valor & ""
            Dim ClaveDocumento As String = Entidad.NombreBd & SeparadorCtb & Entidad.NombreTabla & SeparadorCtb & Id



            'IdPdf
            Dim IdPdf As String = SubirFichero(ClaveDocumento, Archivo)


            Dim TablaDocumentos As String = "Documentos_" & MiMaletin.IdEmpresaCTB.ToString

            Dim sql As String = "INSERT INTO " & TablaDocumentos & " (IdClave, IdNuxeo, Descripcion, TipoDocumento) "
            sql = sql + " VALUES ('" + ClaveDocumento + "','" + IdPdf + "','" + NombreDocumento + " ', '" & Tipodocumento & "')"

            CnDoc.OrdenSql(sql)

        Catch ex As Exception
            bRes = False
        End Try



        Return bRes

    End Function


    Private Function SubirFichero(ByVal clavedoc As String, ByVal Fichero As String) As String
        ' desde aqui mandamos a nuxeo/clave


        Dim ret As String = ""
        Dim NomFichero As String
        Dim PathFichero As String
        Dim nfic As String



        PathFichero = PathDocumentos
        nfic = Format(Now, "yyyyMMddhhmmssfff")
        NomFichero = PathFichero + "\" + nfic + ".pdf"

        If My.Computer.FileSystem.DirectoryExists(PathFichero) = False Then ' creo el directorio de documentos por si no existe
            My.Computer.FileSystem.CreateDirectory(PathFichero)
        End If
        My.Computer.FileSystem.CopyFile(Fichero, NomFichero, True)
        ret = nfic



        Return ret

    End Function


End Module
