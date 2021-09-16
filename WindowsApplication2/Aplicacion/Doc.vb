Public Module Doc

    Private Structure RelacionDocumental

        Public NombreBd As String
        Public Entidad As String
        Public CampoEnlace As String
        Public CampoClave As String

    End Structure


    Public Class RelacionEntidad

        Public PadreBD As String = ""
        Public PadreEntidad As String = ""
        Public PadreCampo As String = ""
        Public HijoBD As String = ""
        Public HijoEntidad As String = ""
        Public HijoCampo As String = ""
        Public ClavePrimaria As String = ""

        Public Sub New(PadreBD As String, PadreEntidad As String, PadreCampo As String, HijoBD As String, HijoEntidad As String, HijoCampo As String)

            Me.PadreBD = PadreBD
            Me.PadreEntidad = PadreEntidad
            Me.PadreCampo = PadreCampo
            Me.HijoBD = HijoBD
            Me.HijoEntidad = HijoEntidad
            Me.HijoCampo = HijoCampo

        End Sub

        Public Function Relacion() As String

            Return PadreBD & SeparadorCtb & PadreEntidad & SeparadorCtb & PadreCampo & "|;|" & HijoBD & SeparadorCtb & HijoEntidad & SeparadorCtb & HijoCampo

        End Function

    End Class


    Public Class GD_Campo

        Public NombreBd As String = ""
        Public Entidad As String = ""
        Public Campo As String = ""

        Public Sub New(NombreBd As String, Entidad As String, Campo As String)

            Me.NombreBd = NombreBd
            Me.Entidad = Entidad
            Me.Campo = Campo

        End Sub

    End Class


    Public Function Doc_ObtenerRelaciones(NombreBd As String, Entidad As String, Campo As String,
                                          NombreBd2 As String, Entidad2 As String, Campo2 As String,
                                          ByRef lst As List(Of RelacionEntidad)) As List(Of RelacionEntidad)

        Dim TablaRelacionesDoc As String = "RelacionesDoc" & "_" & MiMaletin.IdEmpresaCTB.ToString


        Dim sql As String = "SELECT NombreBdPadre, EntidadPadre, CampoPadre, EntidadHijo, CampoHijo, ClavePrimaria as ClaveHijo FROM Documentos.dbo." & TablaRelacionesDoc & vbCrLf
        sql = sql & " LEFT JOIN ClavesDoc ON (NombreBdHijo = BaseDatos AND EntidadHijo = Entidad)" & vbCrLf
        sql = sql + " WHERE NombreBdHijo = '" & NombreBd & "'" & vbCrLf
        sql = sql & " AND EntidadHijo = '" & Entidad & "'"


        If NombreBd2.Trim = "" Then
            NombreBd2 = NombreBd
        End If
        If Entidad2.Trim = "" Then
            Entidad2 = Entidad
        End If
        If Campo2.Trim = "" Then
            Campo2 = Campo
        End If


        Dim Relacion As RelacionEntidad = New RelacionEntidad(NombreBd2, Entidad2, Campo2, NombreBd, Entidad, Campo)

        Dim bEncontrado As Boolean = False
        For Each r As RelacionEntidad In lst
            If Relacion.Relacion = r.Relacion Then
                bEncontrado = True
                Exit For
            End If
        Next

        If Not bEncontrado Then
            lst.Add(Relacion)
        End If


        'If Not lst.Contains(NombreBd & SeparadorCtb & Entidad) Then
        '    lst.Add(NombreBd & SeparadorCtb & Entidad)
        'End If


        Dim dt As DataTable = CnDoc.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows

                Dim NombreBdPadre As String = (row("NombreBdPadre").ToString & "").Trim
                Dim EntidadPadre As String = (row("EntidadPadre").ToString & "").Trim
                Dim CampoPadre As String = (row("CampoPadre").ToString & "").Trim
                Dim CampoHijo As String = (row("CampoHijo").ToString & "").Trim
                Dim CampoClavePadre As String = ClavePrimaria(NombreBdPadre, EntidadPadre)


                Dim NombreBdHijo As String = NombreBd
                Dim EntidadHijo As String = (row("EntidadHijo").ToString & "").Trim

                Dim CampoClaveHijo As String = ClavePrimaria(NombreBdHijo, EntidadHijo)


                If CampoClaveHijo <> "" And CampoClavePadre <> "" Then

                    lst = Doc_ObtenerRelaciones(NombreBdPadre, EntidadPadre, CampoPadre, NombreBdHijo, EntidadHijo, CampoHijo, lst)

                End If
            Next

        End If


        Return lst

    End Function


    Public Function Doc_ObtenerDocumentos(NombreBd As String, Entidad As String, Id As String, lst As List(Of String)) As List(Of String)

        Dim TablaRelacionesDoc As String = "RelacionesDoc" & "_" & MiMaletin.IdEmpresaCTB.ToString


        Dim sql As String = "SELECT NombreBdPadre, EntidadPadre, CampoPadre, EntidadHijo, CampoHijo FROM Documentos.dbo." & TablaRelacionesDoc
        sql = sql + " WHERE NombreBdHijo = '" & NombreBd & "'" & vbCrLf
        sql = sql & " AND EntidadHijo = '" & Entidad & "'"



        If VaInt(Id) <> 0 Then
            Dim clave As String = NombreBd & SeparadorCtb & Entidad & SeparadorCtb & Id
            If lst.Contains(clave) = False Then
                lst.Add(clave)
            End If

        End If


        Dim dt As DataTable = CnDoc.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows

                Dim NombreBdPadre As String = (row("NombreBdPadre").ToString & "").Trim
                Dim EntidadPadre As String = (row("EntidadPadre").ToString & "").Trim
                Dim CampoPadre As String = (row("CampoPadre").ToString & "").Trim
                Dim CampoHijo As String = (row("CampoHijo").ToString & "").Trim
                Dim CampoClavePadre As String = ClavePrimaria(NombreBdPadre, EntidadPadre)


                Dim NombreBdHijo As String = NombreBd
                Dim EntidadHijo As String = (row("EntidadHijo").ToString & "").Trim

                Dim CampoClaveHijo As String = ClavePrimaria(NombreBdHijo, EntidadHijo)


                If CampoClaveHijo <> "" And CampoClavePadre <> "" Then

                    Dim idhijo As String = ""

                    'TODO: Función para poner comillas o no
                    'sql = "SELECT " & E_Entidad.NombreBd & ".dbo." & E_Entidad.NombreTabla & "." & campo_clave & " FROM " & NombreBdPadre & ".dbo." & EntidadPadre & " WHERE " & CampoPadre & " = " & Id
                    sql = "Select " + NombreBdHijo & ".dbo." & EntidadHijo & "." & CampoHijo + " from " + NombreBdHijo & ".dbo." & EntidadHijo & " WHERE " + CampoClaveHijo + "= " + Id
                    Dim dt3 As DataTable = CnDoc.ConsultaSQL(sql)
                    If Not dt3 Is Nothing Then
                        If dt3.Rows.Count > 0 Then
                            idhijo = dt3.Rows(0)(0).ToString ' obtengo el valor del campo del hijo para enlazar con el padre
                        End If
                    End If

                    If idhijo <> "" Then
                        sql = "SELECT " & CampoClavePadre & vbCrLf
                        sql = sql & " FROM " & NombreBdPadre & ".dbo." & EntidadPadre & vbCrLf
                        sql = sql + " WHERE " & CampoPadre & " = " & idhijo



                        ' select ENTIDADPADRE.CLAVEPRIMARIA FROM ENTIDADPADRE WHERE ENTIDADPADRE.CAMPOPADRE = ENTIDADHIJO.CAMPOHIJO

                        Dim dt2 As DataTable = CnDoc.ConsultaSQL(sql)
                        If Not IsNothing(dt2) Then

                            For Each row2 As DataRow In dt2.Rows

                                Dim IdClavePadre As String = (row2(CampoClavePadre).ToString & "").Trim
                                lst = Doc_ObtenerDocumentos(NombreBdPadre, EntidadPadre, IdClavePadre, lst)

                            Next

                        End If
                    End If
                End If
            Next

        End If


        Return lst

    End Function


    Public Function ClavePrimaria(Basedatos As String, Entidad As String) As String
        Dim ret As String = ""

        Dim Sql As String = "Select ClavePrimaria from ClavesDoc where Basedatos='" + Basedatos + "' and Entidad='" + Entidad + "'"
        Dim dt As DataTable = CnDoc.ConsultaSQL(Sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)(0).ToString
            End If
        End If
        Return ret

    End Function


    Private Function ObtenerClavePrimaria(EntidadPadre As String) As Cdatos.Entidad

        'Dim clave_primaria As String = ""
        Dim Entidad As Cdatos.Entidad = Nothing


        Try

            Dim asm As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly

            Entidad = DirectCast(Activator.CreateInstance(asm.GetType("NetAgro.E_" & EntidadPadre)), Cdatos.Entidad)
            'clave_primaria = Entidad.ClavePrimaria.NombreCampo
            'If clave_primaria.Trim = "" Then Throw New Exception("Entidad sin clave primaria")

        Catch ex As Exception
            MsgBox("Error al buscar la clave primaria de la entidad " & EntidadPadre)
        End Try



        Return Entidad

    End Function



End Module
