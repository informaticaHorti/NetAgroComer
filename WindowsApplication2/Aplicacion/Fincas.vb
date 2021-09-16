Module Fincas


    Public Sub ActualizaFechaInicioRecoleccionRealCultivo(IdCultivo As String, FechaInicioRecoleccionRealCultivo As String)

        If VaInt(IdCultivo) > 0 And VaDate(FechaInicioRecoleccionRealCultivo) > VaDate("") Then


            Dim bCerrado As Boolean = False
            If cnFincasNET.conn.State = ConnectionState.Closed Then
                bCerrado = True
                cnFincasNET.AbrirConexion()
            End If


            Dim Cultivos As New E_Cultivos(Idusuario, cnFincasNET)
            If Cultivos.LeerId(IdCultivo) Then

                If VaDate(Cultivos.CUL_FechaRecoleReal.Valor) = VaDate("") Then

                    Cultivos.CUL_FechaRecoleReal.Valor = FechaInicioRecoleccionRealCultivo
                    Cultivos.Actualizar()

                End If

            End If


            'Lo dejo como estaba
            If bCerrado Then
                If cnFincasNET.conn.State = ConnectionState.Open Then
                    cnFincasNET.CerrarConexion()
                End If
            End If

        End If

    End Sub


    Public Function EsTecnicosNet() As Boolean

        Dim bRes As Boolean = False


        Dim ValoresEjercicio As New E_ValoresEjercicio(Idusuario, cn)
        If ValoresEjercicio.LeerId(MiMaletin.Ejercicio.ToString) Then

            If VaInt(ValoresEjercicio.VEJ_TipoConexion.Valor) = VaInt(E_ValoresEjercicio.TipoConexionTecnicos.TecnicosNet) Then
                bRes = True
            End If

        End If


        Return bRes

    End Function


    Public Function DatosCultivo(IdCultivo As String, ByRef Genero As String, ByRef Variedad As String, ByRef IdPrograma As String, ByRef Controlado As String, ByRef IdTipoCultivo As String, ByRef Nave As String, ByRef CampaCultivo As String, ByRef CalidadEntradas As String) As Boolean


        Dim bEncontrado As Boolean = False


        If VaInt(IdCultivo) > 0 Then

            Dim Cultivos As New E_Cultivos(Idusuario, cnFincasNET)
            Dim GenerosTecnicos As New E_GenerosTecnicos(Idusuario, cnFincasNET)
            Dim Variedades As New E_Variedades(Idusuario, cnFincasNET)
            Dim ProgramaCalidad As New E_ProgramasCalidad(Idusuario, cnFincasNET)
            Controlado = "N"

            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(Cultivos.CUL_IdProgramaCalidad, "IdPrograma")
            consulta.SelCampo(Cultivos.CUL_TipoCultivo, "TipoCultivo")
            consulta.SelCampo(Cultivos.CUL_IdNave, "IdNave")
            consulta.SelCampo(Cultivos.CUL_Campa, "CampaCultivo")
            consulta.SelCampo(GenerosTecnicos.GEN_Nombre, "Genero", Cultivos.CUL_IdGenero, GenerosTecnicos.GEN_IdGenero)
            consulta.SelCampo(Variedades.VAR_Nombre, "Variedad", Cultivos.CUL_IdVariedad, Variedades.VAR_IdVariedad)
            consulta.SelCampo(ProgramaCalidad.PCL_ControladoSN, "Controlado", Cultivos.CUL_IdProgramaCalidad)
            consulta.SelCampo(Cultivos.CUL_CalidadEntradas, "Calidad")

            consulta.WheCampo(Cultivos.CUL_IdCultivo, "=", IdCultivo)

            Dim dt As DataTable = Cultivos.MiConexion.ConsultaSQL(consulta.SQL)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim row As DataRow = dt.Rows(0)
                    Genero = (row("Genero").ToString & "").Trim
                    Variedad = (row("Variedad").ToString & "").Trim
                    IdPrograma = (row("IdPrograma").ToString & "").Trim
                    Controlado = (row("Controlado").ToString & "").Trim
                    Nave = (row("IdNave").ToString & "").Trim
                    IdTipoCultivo = (row("TipoCultivo").ToString & "").Trim
                    CampaCultivo = (row("CampaCultivo").ToString & "").Trim
                    CalidadEntradas = (row("Calidad").ToString & "").Trim
                    bEncontrado = True

                End If
            End If


        End If



        Return bEncontrado

    End Function


    Public Function ObtenerTablaNormasCalidad() As DataTable

        Dim dt As DataTable = Nothing


        If EsTecnicosNet() Then

            Dim sql As String = "SELECT NCL_IdNorma as Id, NCL_Nombre as Nombre FROM NormasCalidad ORDER BY NCL_Nombre"
            dt = cnFincasNET.ConsultaSQL(sql)

        Else

            Dim sql As String = "Select cdnorma as Id, Nombre from normas_calidad order by nombre"
            dt = cnFincasVB6.ConsultaSQL(sql)

        End If


        If IsNothing(dt) Then dt = New DataTable
        Return dt

    End Function



    Public Function CompruebaGGN(IdCliente As String, ggn As String) As Boolean

        If ggn.Trim = "" Then Return True


        Dim bRes As Boolean = False
        Dim dt As DataTable
        Dim bClienteConNorma6 As Boolean = False

        'Dim sqlN As String = "SELECT Count(NOR_IdNorma) as cont FROM NormasCalidad WHERE NOR_IdNorma = 6"
        Dim sqlN As String = "SELECT Count(CPR_Id) as cont FROM ClientesPrograma WHERE CPR_IdCliente = " & IdCliente & " AND CPR_IdPrograma = 6"
        Dim dtN As DataTable = cn.ConsultaSQL(sqlN)
        If Not IsNothing(dtN) Then
            If dtN.Rows.Count > 0 Then

                If VaInt(dtN.Rows(0)("cont")) > 0 Then
                    bClienteConNorma6 = True
                End If

            End If
        End If



        If bClienteConNorma6 Then

            'Si el cliente tiene norma 6, comprueba que las partidas tengan la norma 6
            If EsTecnicosNet() Then
                Dim sql As String = "SELECT Count(ACA_Numero) as cont FROM AgricultorCalidad WHERE ACA_IdNorma = 6 and ACA_Numero = '" & ggn & "'"
                dt = cnFincasNET.ConsultaSQL(sql)
            Else
                Dim sql As String = "SELECT Count(numero) as cont FROM agricultor_calidad WHERE cdnorma = '06' and numero = '" & ggn & "'"
                dt = cnFincasVB6.ConsultaSQL(sql)
            End If

        Else

            'Si el cliente no tiene norma 6, comprueba que las partidas tengan la norma 1
            If EsTecnicosNet() Then
                Dim sql As String = "SELECT Count(ACA_Numero) as cont FROM AgricultorCalidad WHERE ACA_IdNorma = 1 and ACA_Numero = '" & ggn & "'"
                dt = cnFincasNET.ConsultaSQL(sql)
            Else
                Dim sql As String = "SELECT Count(numero) as cont FROM agricultor_calidad WHERE cdnorma = '01' and numero = '" & ggn & "'"
                dt = cnFincasVB6.ConsultaSQL(sql)
            End If

        End If




        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                Dim cont As Integer = VaInt(dt.Rows(0)("cont"))
                If cont > 0 Then
                    bRes = True
                End If
            End If
        End If



        Return bRes


    End Function


    Public Function VariedadFincas(cdcultivo As String, cdvariedad As String) As String


        ' devuelvo el nombre de la variedad

        Dim ret As String = ""
        Dim sql As String

        cdcultivo = Fnc0(cdcultivo, 5)
        cdvariedad = Fnc0(cdvariedad, 4)

        sql = "Select variedades.nombre as variedad from variedades where cdcultivo='" + cdcultivo + "' and cdvariedad='" + cdvariedad + "'"

        Dim dt As DataTable = cnFincasVB6.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)("variedad").ToString
            End If
        End If



        Return ret



    End Function

    Public Function InvernaderosFincas(cdfinca As String, cdnave As String, cdcampa As String) As String


        ' devuelvo el nombre del invernadero

        Dim ret As String = ""
        Dim sql As String

        cdfinca = Fnc0(cdfinca, 5)
        cdnave = Fnc0(cdnave, 2)
        cdcampa = Fnc0(cdcampa, 2)

        sql = "Select invernaderos.nombre as invernadero from invernaderos where cdfinca='" + cdfinca + "' and cdnave='" + cdnave + "' and cdcampa='" + cdcampa + "'"
        Dim dt As DataTable = cnFincasVB6.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)("invernadero").ToString
            End If
        End If



        Return ret



    End Function

    Public Function NombreFinca(cdfinca As String, cdcampa As String) As String


        ' devuelvo el nombre de la finca

        Dim ret As String = ""
        Dim sql As String

        cdfinca = Fnc0(cdfinca, 5)

        cdcampa = Fnc0(cdcampa, 2)

        sql = "Select datos_fincas.nombre as finca from datos_fincas where cdfinca='" + cdfinca + "' and cdcampa='" + cdcampa + "'"
        Dim dt As DataTable = cnFincasVB6.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)("finca").ToString
            End If
        End If



        Return ret



    End Function

    Public Function GeneroFincas(cdcultivo As String) As String


        ' devuelvo el nombre del cultivo

        Dim ret As String = ""
        Dim sql As String

        cdcultivo = Fnc0(cdcultivo, 5)
        sql = "Select cultivos.nombre as genero from cultivos where cdcultivo='" + cdcultivo + "' "
        Dim dt As DataTable = cnFincasVB6.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)("genero").ToString
            End If
        End If



        Return ret



    End Function


    Public Function NombreGeneroCultivoNET(IdCultivo As String,
                                           Optional ByRef IdGenero As String = "",
                                           Optional ByRef IdFinca As String = "",
                                           Optional ByRef IdNave As String = "") As String

        Dim ret As String = ""


        If VaInt(IdCultivo) > 0 Then

            Dim sql As String = "SELECT GEN_Nombre as Nombre, CUL_IdGenero as IdGenero, CUL_IdFinca as IdFinca, CUL_IdNave as IdNave " & vbCrLf
            sql = sql & " FROM Cultivos " & vbCrLf
            sql = sql & " LEFT JOIN Generos ON CUL_IdGenero = GEN_IdGenero" & vbCrLf
            sql = sql & " WHERE CUL_IdCultivo = " & IdCultivo & vbCrLf

            Dim dt As DataTable = cnFincasNET.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim row As DataRow = dt.Rows(0)
                    ret = (row("Nombre").ToString & "").Trim

                    IdGenero = (row("IdGenero").ToString & "").Trim
                    IdFinca = (row("IdFinca").ToString & "").Trim
                    IdNave = (row("IdNave").ToString & "").Trim

                End If
            End If

        End If



        Return ret

    End Function


    Public Function NombreGeneroCultivo(campatec As String, idcultivo As String,
                                              Optional ByRef cdGenero As String = "",
                                              Optional ByRef cdFinca As String = "",
                                              Optional ByRef cdNave As String = "") As String
        ' devuelvo el nombre del cultivo 

        Dim ret As String = ""
        Dim sql As String

        sql = "Select cultivos_lineas.cdgenero as cdgenero,cultivos.nombre as nombre, cultivos_lineas.cdfinca, cultivos_lineas.cdnave " & vbCrLf
        sql = sql & " from cultivos_lineas" & vbCrLf
        sql = sql & " LEFT JOIN cultivos ON cdgenero = cdcultivo " & vbCrLf
        sql = sql + " where cdcampa='" + Fnc0(campatec, 2) + "' and idcultivo='" + Fnc0(idcultivo, 5) + "'" & vbCrLf
        Dim dt As DataTable = cnFincasVB6.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)("nombre").ToString
                cdGenero = dt.Rows(0)("cdgenero").ToString
                cdFinca = dt.Rows(0)("cdfinca").ToString
                cdNave = dt.Rows(0)("cdnave").ToString
            End If
        End If


        Return ret

    End Function


    Public Function ProgramaCalidadCultivo(campatec As String, idcultivo As String,
                                              Optional ByRef controlado As String = "") As String

        ' devuelvo el id del programa de calidad y si es controlado o no

        Dim ret As String = ""
        Dim sql As String

        sql = "Select cultivos_lineas.cdprogcalidad as cdprogramacalidad, programas_calidad.controlado as controlado" & vbCrLf
        sql = sql & " from cultivos_lineas " & vbCrLf
        sql = sql & " LEFT JOIN cultivos ON cdgenero = cdcultivo " & vbCrLf
        sql = sql & " LEFT JOIN programas_calidad ON cultivos_lineas.cdprogcalidad = programas_calidad.cdprograma" & vbCrLf
        sql = sql + " where cdcampa='" + Fnc0(campatec, 2) + "' and idcultivo='" + Fnc0(idcultivo, 5) + "'" & vbCrLf
        Dim dt As DataTable = cnFincasVB6.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)("cdprogramacalidad").ToString
                controlado = dt.Rows(0)("controlado").ToString
            End If
        End If


        Return ret

    End Function




    'Public Sub GGNBoletin(ByVal Campa As String, ByVal IdAgricultor As Integer, ByVal IdCultivo As Integer, ByRef linea1 As String, ByRef linea2 As String,
    '                            Optional ByRef Normas As String = "")

    '    'EXISTE UN SUB NUEVO PARA LAS IMPRESIONES DE LOS PRECALIBRADOS - EN EL QUE PASO DIRECTAMENTE EL PROGRAMA Y NO EL CULTIVO - GGNBoletinPrograma


    '    Normas = ""
    '    linea1 = ""
    '    linea2 = ""


    '    If EsTecnicosNet() Then

    '        Dim IdPrograma As String = ""

    '        Dim sql As String = "SELECT CUL_IdProgramaCalidad as IdPrograma FROM Cultivos WHERE CUL_IdCultivo = " & IdCultivo
    '        Dim dt As DataTable = cnFincasNET.ConsultaSQL(sql)
    '        If Not dt Is Nothing Then
    '            If dt.Rows.Count > 0 Then
    '                IdPrograma = (dt.Rows(0)("IdPrograma").ToString & "").Trim
    '            End If
    '        End If


    '        If IdPrograma <> "" Then
    '            sql = "SELECT CAN_IdNorma as IdNorma FROM CalidadNorma WHERE CAN_IdPrograma = " & IdPrograma & " ORDER BY CAN_IdNorma" & vbCrLf


    '            dt = cnFincasNET.ConsultaSQL(sql)
    '            If Not dt Is Nothing Then

    '                For Each rw In dt.Rows

    '                    Dim IdNorma As String = (rw("IdNorma").ToString & "").Trim

    '                    Dim NombreNorma As String = ""
    '                    Dim prefijo As String = ""
    '                    Dim Numero As String = ""

    '                    sql = "SELECT NCL_Nombre as Nombre, NCL_Prefijo as Prefijo FROM NormasCalidad WHERE NCL_IdNorma = " & IdNorma
    '                    Dim dt2 As DataTable = cnFincasNET.ConsultaSQL(sql)
    '                    If Not dt2 Is Nothing Then
    '                        If dt2.Rows.Count > 0 Then
    '                            NombreNorma = (dt2.Rows(0)("nombre").ToString & "").Trim
    '                            prefijo = (dt2.Rows(0)("prefijo").ToString & "").Trim
    '                        End If
    '                    End If



    '                    sql = "SELECT ACA_Numero as Numero FROM AgricultorCalidad WHERE ACA_IdAgricultor = " & IdAgricultor & " AND ACA_IdNorma = " & IdNorma
    '                    Dim dt3 As DataTable = cnFincasNET.ConsultaSQL(sql)
    '                    If Not dt3 Is Nothing Then

    '                        If dt3.Rows.Count > 0 Then
    '                            Numero = (dt3.Rows(0)("numero").ToString & "").Trim
    '                        End If
    '                    End If
    '                    linea1 = linea1 + NombreNorma + "  "
    '                    linea2 = linea2 + prefijo + ": " + Numero + ".  "
    '                    Normas = Normas & IdNorma & "|"
    '                Next
    '            End If
    '        End If

    '    Else

    '        Dim SQL As String = ""
    '        Dim CdProgCalidad As String = ""

    '        SQL = "Select cdprogcalidad from cultivos_lineas where idcultivo='" + Fnc0(IdCultivo, 5) + "' and cdcampa='" + Campa + "'"
    '        Dim dt As DataTable = cnFincasVB6.ConsultaSQL(SQL)
    '        If Not dt Is Nothing Then
    '            If dt.Rows.Count > 0 Then
    '                CdProgCalidad = Fnc0(dt.Rows(0)("cdprogcalidad").ToString, 4)
    '            End If
    '        End If

    '        SQL = "select cdnorma from calidad_norma where cdprogcalidad='" + CdProgCalidad + "'"
    '        dt = cnFincasVB6.ConsultaSQL(SQL)
    '        If Not dt Is Nothing Then

    '            For Each rw In dt.Rows
    '                Dim cdnorma As String = Fnc0(rw("cdnorma").ToString, 2)
    '                Dim NombreNorma As String = ""
    '                Dim prefijo As String = ""
    '                Dim Numero As String = ""

    '                SQL = "Select nombre,prefijo from normas_calidad where cdnorma='" + cdnorma + "'"
    '                Dim dt2 As DataTable = cnFincasVB6.ConsultaSQL(SQL)
    '                If Not dt2 Is Nothing Then
    '                    If dt2.Rows.Count > 0 Then
    '                        NombreNorma = dt2.Rows(0)("nombre").ToString.Trim
    '                        prefijo = dt2.Rows(0)("prefijo").ToString.Trim
    '                    End If
    '                End If
    '                SQL = "Select numero from agricultor_calidad where cdagricultor='" + Fnc0(IdAgricultor, 5) + "' and cdnorma='" + cdnorma + "'"
    '                Dim dt3 As DataTable = cnFincasVB6.ConsultaSQL(SQL)
    '                If Not dt3 Is Nothing Then

    '                    If dt3.Rows.Count > 0 Then
    '                        Numero = dt3.Rows(0)("numero").ToString.Trim
    '                    End If
    '                End If
    '                linea1 = linea1 + NombreNorma + "  "
    '                linea2 = linea2 + prefijo + ": " + Numero + ".  "
    '                Normas = Normas & cdnorma & "|"
    '            Next
    '        End If

    '    End If



    'End Sub



    Public Sub GGNBoletinPrograma(ByVal IdAgricultor As Integer, ByVal IdProgramaCalidad As String, ByRef linea1 As String, ByRef linea2 As String,
                                Optional ByRef Normas As String = "")

        Normas = ""
        linea1 = ""
        linea2 = ""

        If EsTecnicosNet() Then


            If IdProgramaCalidad <> "" Then
                Dim Sql As String = "SELECT CAN_IdNorma as IdNorma FROM CalidadNorma WHERE CAN_IdPrograma = " & IdProgramaCalidad & " ORDER BY CAN_IdNorma" & vbCrLf


                Dim dt As DataTable = cnFincasNET.ConsultaSQL(Sql)
                If Not dt Is Nothing Then

                    For Each rw In dt.Rows

                        Dim IdNorma As String = (rw("IdNorma").ToString & "").Trim

                        Dim NombreNorma As String = ""
                        Dim prefijo As String = ""
                        Dim Numero As String = ""

                        Sql = "SELECT NCL_Nombre as Nombre, NCL_Prefijo as Prefijo FROM NormasCalidad WHERE NCL_IdNorma = " & IdNorma
                        Dim dt2 As DataTable = cnFincasNET.ConsultaSQL(Sql)
                        If Not dt2 Is Nothing Then
                            If dt2.Rows.Count > 0 Then

                                NombreNorma = (dt2.Rows(0)("nombre").ToString & "").Trim
                                prefijo = (dt2.Rows(0)("prefijo").ToString & "").Trim

                            End If
                        End If



                        Sql = "SELECT ACA_Numero as Numero FROM AgricultorCalidad WHERE ACA_IdAgricultor = " & IdAgricultor & " AND ACA_IdNorma = " & IdNorma
                        Dim dt3 As DataTable = cnFincasNET.ConsultaSQL(Sql)
                        If Not dt3 Is Nothing Then

                            If dt3.Rows.Count > 0 Then

                                Numero = (dt3.Rows(0)("numero").ToString & "").Trim

                            End If
                        End If

                        linea1 = linea1 + NombreNorma + "  "
                        linea2 = linea2 + prefijo + ": " + Numero + ".  "
                        Normas = Normas & IdNorma & "|"

                    Next
                End If
            End If

        Else

            Dim SQL As String = ""
            Dim CdProgCalidad As String = ""

            SQL = "select cdnorma from calidad_norma where cdprogcalidad='" + IdProgramaCalidad + "'"
            Dim dt As DataTable = cnFincasVB6.ConsultaSQL(SQL)
            If Not dt Is Nothing Then

                For Each rw In dt.Rows
                    Dim cdnorma As String = Fnc0(rw("cdnorma").ToString, 2)
                    Dim NombreNorma As String = ""
                    Dim prefijo As String = ""
                    Dim Numero As String = ""

                    SQL = "Select nombre,prefijo from normas_calidad where cdnorma='" + cdnorma + "'"
                    Dim dt2 As DataTable = cnFincasVB6.ConsultaSQL(SQL)
                    If Not dt2 Is Nothing Then
                        If dt2.Rows.Count > 0 Then
                            NombreNorma = dt2.Rows(0)("nombre").ToString.Trim
                            prefijo = dt2.Rows(0)("prefijo").ToString.Trim
                        End If
                    End If
                    SQL = "Select numero from agricultor_calidad where cdagricultor='" + Fnc0(IdAgricultor, 5) + "' and cdnorma='" + cdnorma + "'"
                    Dim dt3 As DataTable = cnFincasVB6.ConsultaSQL(SQL)
                    If Not dt3 Is Nothing Then

                        If dt3.Rows.Count > 0 Then
                            Numero = dt3.Rows(0)("numero").ToString.Trim
                        End If
                    End If
                    linea1 = linea1 + NombreNorma + "  "
                    linea2 = linea2 + prefijo + ": " + Numero + ".  "
                    Normas = Normas & cdnorma & "|"
                Next
            End If

        End If



    End Sub


    Public Function ProgProtocolo(Campa As String, IdAgricultor As Integer, IdCultivo As Integer) As String

        Dim res As String = ""



        If EsTecnicosNet() Then

            Dim sql As String = "SELECT NCL_Nombre as Nombre FROM NormasCalidad WHERE NCL_IdNorma IN" & vbCrLf
            sql = sql & " (" & vbCrLf
            sql = sql & " SELECT TOP 1 CAN_IdNorma as IdNorma" & vbCrLf
            sql = sql & " FROM Cultivos" & vbCrLf
            sql = sql & " LEFT JOIN CalidadNorma ON CAN_IdPrograma = CUL_IdProgramaCalidad " & vbCrLf
            sql = sql & " WHERE CUL_IdCultivo = " & IdCultivo & vbCrLf
            sql = sql & " )" & vbCrLf

            Dim dt As DataTable = cnFincasNET.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    res = (dt.Rows(0)("Nombre").ToString & "").Trim
                End If
            End If


        Else


            Dim CdProgCalidad As String = ""


            Dim sql As String = "Select top 1 cdprogcalidad from cultivos_lineas where idcultivo='" + Fnc0(IdCultivo, 5) + "' and cdcampa='" + Campa + "'"
            Dim dt As DataTable = cnFincasVB6.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    CdProgCalidad = Fnc0(dt.Rows(0)("cdprogcalidad").ToString, 4)
                End If
            End If

            sql = "select top 1 cdnorma from calidad_norma where cdprogcalidad='" + CdProgCalidad + "'"
            dt = cnFincasVB6.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                For Each rw In dt.Rows
                    Dim cdnorma As String = Fnc0(rw("cdnorma").ToString, 2)
                    Dim NombreNorma As String = ""
                    Dim prefijo As String = ""
                    Dim Numero As String = ""
                    sql = "Select nombre from normas_calidad where cdnorma='" + cdnorma + "'"
                    Dim dt2 As DataTable = cnFincasVB6.ConsultaSQL(sql)
                    If Not dt2 Is Nothing Then
                        If dt2.Rows.Count > 0 Then
                            NombreNorma = dt2.Rows(0)("nombre").ToString.Trim
                        End If
                    End If

                    res = NombreNorma

                Next
            End If

        End If
        



        Return res

    End Function




    Public Function NombreTecnicoCultivo(campatec As String, idcultivo As String,
                                         Optional ByRef cdTecnico As String = "") As String
        ' devuelvo el nombre del cultivo 

        Dim ret As String = ""
        Dim dt As DataTable

        If EsTecnicosNet() Then

            Dim sql As String = "SELECT CUL_IdTecnico as CdTecnico, TEC_Nombre as Tecnico" & vbCrLf
            sql = sql & " FROM Cultivos" & vbCrLf
            sql = sql & " LEFT JOIN Tecnicos ON TEC_IdTecnico = CUL_IdTecnico" & vbCrLf
            sql = sql & " WHERE CUL_IdCultivo = " & idcultivo & vbCrLf
            dt = cnFincasNET.ConsultaSQL(sql)

        Else
            Dim sql As String = "SELECT Datos_Fincas.CdTecnico, Tecnicos.Nombre as Tecnico" & vbCrLf
            sql = sql & " FROM Cultivos_Lineas " & vbCrLf
            sql = sql & " LEFT JOIN Cultivos ON CdGenero = CdCultivo " & vbCrLf
            sql = sql & " LEFT JOIN Datos_Fincas ON (Datos_Fincas.CdCampa = Cultivos_Lineas.CdCampa AND Datos_Fincas.CdFinca = Cultivos_Lineas.CdFinca)" & vbCrLf
            sql = sql & " LEFT JOIN Tecnicos ON Tecnicos.CdTecnico = Datos_Fincas.CdTecnico " & vbCrLf
            sql = sql & " WHERE Cultivos_Lineas.CdCampa='" + Fnc0(campatec, 2) & "' AND IdCultivo = '" & Fnc0(idcultivo, 5) & "'" & vbCrLf
            dt = cnFincasVB6.ConsultaSQL(sql)
        End If


        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)("Tecnico").ToString
                cdTecnico = dt.Rows(0)("cdTecnico").ToString
            End If
        End If


        Return ret

    End Function



    Public Function NombreVariedadCultivo(campatec As String, idcultivo As String,
                                          Optional ByRef cdVariedad As String = "") As String
        ' devuelvo el nombre del cultivo 

        Dim ret As String = ""
        Dim dt As DataTable


        If EsTecnicosNet() Then

            Dim sql As String = "SELECT CUL_IdVariedad as cdvariedad, VAR_Nombre as Variedad" & vbCrLf
            sql = sql & " FROM Cultivos" & vbCrLf
            sql = sql & " LEFT JOIN Variedades ON VAR_IdVariedad = CUL_IdVariedad" & vbCrLf
            sql = sql & " WHERE CUL_IdCultivo = " & idcultivo & vbCrLf
            dt = cnFincasNET.ConsultaSQL(sql)

        Else

            Dim sql As String = "SELECT Cultivos_Lineas.cdvariedad, Variedades.Nombre as Variedad" & vbCrLf
            sql = sql & " FROM Cultivos_Lineas " & vbCrLf
            sql = sql & " LEFT JOIN Cultivos ON CdGenero = CdCultivo " & vbCrLf
            sql = sql & " LEFT JOIN Variedades ON (Variedades.CdCultivo = Cultivos.CdCultivo AND Variedades.CdVariedad = Cultivos_Lineas.CdVariedad) " & vbCrLf
            sql = sql & " WHERE Cultivos_Lineas.CdCampa='" + Fnc0(campatec, 2) & "' AND IdCultivo = '" & Fnc0(idcultivo, 5) & "'" & vbCrLf
            dt = cnFincasVB6.ConsultaSQL(sql)

        End If

        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = dt.Rows(0)("Variedad").ToString
                cdVariedad = dt.Rows(0)("cdVariedad").ToString
            End If
        End If


        Return ret

    End Function



    Public Function CompruebaGeneroTrazabilidadPartida(IdGeneroPalet As String, IdGeneroPartida As String) As Boolean

        If EsTecnicosNet() Then
            Return CompruebaGeneroTrazabilidadPartida_NET(IdGeneroPalet, IdGeneroPartida)
        Else
            Return CompruebaGeneroTrazabilidadPartida_VB6(IdGeneroPalet, IdGeneroPartida)
        End If

    End Function


    Private Function CompruebaGeneroTrazabilidadPartida_VB6(IdGeneroPalet As String, IdGeneroPartida As String) As Boolean

        Dim bRes As Boolean = False


        If VaInt(IdGeneroPalet) > 0 And VaInt(IdGeneroPartida) > 0 Then

            'Obtiene el género de tecnicos del cultivo de la partida
            Dim CdGenAlm As String = VaInt(IdGeneroPalet).ToString("00000")
            Dim CdGenero As String = VaInt(IdGeneroPartida).ToString("00000")

            'Cultivos permitidos para ese género
            Dim sqlLote As String = "SELECT CdCultivo FROM Generos_por_cultivo WHERE CdGenAlm = '" & CdGenAlm & "'"
            Dim dtLote As DataTable = cnFincasVB6.ConsultaSQL(sqlLote)
            If Not IsNothing(dtLote) Then
                For Each row As DataRow In dtLote.Rows

                    Dim CdCultivo As String = (row("CdCultivo").ToString & "").Trim
                    If VaInt(CdCultivo) = VaInt(CdGenero) Then
                        bRes = True
                        Exit For
                    End If

                Next
            End If


        End If


        Return bRes

    End Function


    Private Function CompruebaGeneroTrazabilidadPartida_NET(IdGeneroPalet As String, IdGeneroPartida As String) As Boolean

        Dim bRes As Boolean = False

        If VaInt(IdGeneroPalet) > 0 And VaInt(IdGeneroPartida) > 0 Then

            'Cultivos permitidos para ese género
            Dim sqlLote As String = "SELECT CGE_IdCultivo as IdGeneroTecnicos FROM CultivosGenero WHERE CGE_IdGenero = " & IdGeneroPalet
            Dim dtLote As DataTable = cnFincasNET.ConsultaSQL(sqlLote)
            If Not IsNothing(dtLote) Then
                For Each row As DataRow In dtLote.Rows

                    Dim IdGeneroTecnicos As String = (row("IdGeneroTecnicos").ToString & "").Trim
                    If VaInt(IdGeneroTecnicos) = VaInt(IdGeneroPartida) Then
                        bRes = True
                        Exit For
                    End If

                Next
            End If

        End If


        Return bRes

    End Function



    Public Function CompruebaGeneroTrazabilidadPartida(IdGeneroLote As String, AlbEntrada_lineas As E_AlbEntrada_lineas) As Boolean

        If EsTecnicosNet() Then
            Return CompruebaGeneroTrazabilidadPartida_NET(IdGeneroLote, AlbEntrada_lineas)
        Else
            Return CompruebaGeneroTrazabilidadPartida_VB6(IdGeneroLote, AlbEntrada_lineas)
        End If

    End Function


    Private Function CompruebaGeneroTrazabilidadPartida_NET(IdGeneroLote As String, AlbEntrada_lineas As E_AlbEntrada_lineas) As Boolean

        Dim bRes As Boolean = False

        If VaInt(IdGeneroLote) > 0 And VaInt(AlbEntrada_lineas.AEL_idgenero.Valor) > 0 Then

            'Cultivos permitidos para ese género
            Dim sqlLote As String = "SELECT CGE_IdCultivo as IdGeneroTecnicos FROM CultivosGenero WHERE CGE_IdGenero = " & IdGeneroLote
            Dim dtLote As DataTable = cnFincasNET.ConsultaSQL(sqlLote)
            If Not IsNothing(dtLote) Then
                For Each row As DataRow In dtLote.Rows

                    Dim IdGeneroTecnicos As String = (row("IdGeneroTecnicos").ToString & "").Trim
                    If VaInt(IdGeneroTecnicos) = VaInt(AlbEntrada_lineas.AEL_idgenero.Valor) Then
                        bRes = True
                        Exit For
                    End If

                Next
            End If


        End If


        Return bRes

    End Function


    Private Function CompruebaGeneroTrazabilidadPartida_VB6(IdGeneroLote As String, AlbEntrada_lineas As E_AlbEntrada_lineas) As Boolean

        Dim bRes As Boolean = False

        If VaInt(IdGeneroLote) > 0 And VaInt(AlbEntrada_lineas.AEL_idgenero.Valor) > 0 Then


            Dim CdGenAlm As String = VaInt(IdGeneroLote).ToString("00000")
            Dim CdGenero As String = VaInt(AlbEntrada_lineas.AEL_idgenero.Valor).ToString("00000")

            'Cultivos permitidos para ese género
            Dim sqlLote As String = "SELECT CdCultivo FROM Generos_por_cultivo WHERE CdGenAlm = '" & CdGenAlm & "'"
            Dim dtLote As DataTable = cnFincasVB6.ConsultaSQL(sqlLote)
            If Not IsNothing(dtLote) Then
                For Each row As DataRow In dtLote.Rows

                    Dim CdCultivo As String = (row("CdCultivo").ToString & "").Trim
                    If VaInt(CdCultivo) = VaInt(CdGenero) Then
                        bRes = True
                        Exit For
                    End If

                Next
            End If



        End If


        Return bRes

    End Function



    Public Function CompruebaGeneroTrazabilidadLote(IdGeneroPalet As String, Lotes As E_Lotes) As Boolean

        If EsTecnicosNet() Then
            Return CompruebaGeneroTrazabilidadLote_NET(IdGeneroPalet, Lotes)
        Else
            Return CompruebaGeneroTrazabilidadLote_VB6(IdGeneroPalet, Lotes)
        End If

    End Function


    Private Function CompruebaGeneroTrazabilidadLote_VB6(IdGeneroPalet As String, Lotes As E_Lotes) As Boolean

        Dim bRes As Boolean = False

        If VaInt(IdGeneroPalet) > 0 And VaInt(Lotes.LTE_Idlote.Valor) > 0 Then

            'Obtiene el género de tecnicos del género del lote

            Dim CdGenAlm As String = VaInt(IdGeneroPalet).ToString("00000")
            Dim cdGenero As String = VaInt(Lotes.LTE_Idgenero.Valor).ToString("00000")

            'Cultivos permitidos para ese género
            Dim sqlLote As String = "SELECT CdCultivo FROM Generos_por_cultivo WHERE CdGenAlm = '" & CdGenAlm & "'"
            Dim dtLote As DataTable = cnFincasVB6.ConsultaSQL(sqlLote)
            If Not IsNothing(dtLote) Then
                For Each row As DataRow In dtLote.Rows

                    Dim CdCultivo As String = (row("CdCultivo").ToString & "").Trim
                    If VaInt(CdCultivo) = VaInt(cdGenero) Then
                        bRes = True
                        Exit For
                    End If

                Next
            End If

        End If


        Return bRes

    End Function



    Private Function CompruebaGeneroTrazabilidadLote_NET(IdGeneroLote As String, Lotes As E_Lotes) As Boolean

        Dim bRes As Boolean = False
      
        If VaInt(IdGeneroLote) > 0 And VaInt(Lotes.LTE_Idlote.Valor) > 0 Then

            'Cultivos permitidos para ese género
            Dim sqlLote As String = "SELECT CGE_IdCultivo as IdGeneroTecnicos FROM CultivosGenero WHERE CGE_IdGenero = " & IdGeneroLote
            Dim dtLote As DataTable = cnFincasNET.ConsultaSQL(sqlLote)
            If Not IsNothing(dtLote) Then
                For Each row As DataRow In dtLote.Rows

                    Dim IdGeneroTecnicos As String = (row("IdGeneroTecnicos").ToString & "").Trim
                    If VaInt(IdGeneroTecnicos) = VaInt(Lotes.LTE_Idgenero.Valor) Then
                        bRes = True
                        Exit For
                    End If

                Next
            End If



        End If


        Return bRes

    End Function


    Public Function CompruebaGeneroTrazabilidadPrecalibrado(IdGeneroPalet As String, LotesProduccion As E_LotesProduccion) As Boolean

        If EsTecnicosNet() Then
            Return CompruebaGeneroTrazabilidadPrecalibrado_NET(IdGeneroPalet, LotesProduccion)
        Else
            Return CompruebaGeneroTrazabilidadPrecalibrado_VB6(IdGeneroPalet, LotesProduccion)
        End If

    End Function


    Private Function CompruebaGeneroTrazabilidadPrecalibrado_VB6(IdGeneroPalet As String, LotesProduccion As E_LotesProduccion) As Boolean

        Dim bRes As Boolean = False

        If VaInt(IdGeneroPalet) > 0 And VaInt(LotesProduccion.LPD_Idlote.Valor) > 0 Then

            'Obtiene el género de tecnicos del género del lote

            Dim CdGenAlm As String = VaInt(IdGeneroPalet).ToString("00000")
            Dim cdGenero As String = VaInt(LotesProduccion.LPD_Idgenero.Valor).ToString("00000")

            'Cultivos permitidos para ese género
            Dim sqlLote As String = "SELECT CdCultivo FROM Generos_por_cultivo WHERE CdGenAlm = '" & CdGenAlm & "'"
            Dim dtLote As DataTable = cnFincasVB6.ConsultaSQL(sqlLote)
            If Not IsNothing(dtLote) Then
                For Each row As DataRow In dtLote.Rows

                    Dim CdCultivo As String = (row("CdCultivo").ToString & "").Trim
                    If VaInt(CdCultivo) = VaInt(cdGenero) Then
                        bRes = True
                        Exit For
                    End If

                Next
            End If

        End If


        Return bRes

    End Function


    Private Function CompruebaGeneroTrazabilidadPrecalibrado_NET(IdGeneroPalet As String, LotesProduccion As E_LotesProduccion) As Boolean

        Dim bRes As Boolean = False

        If VaInt(IdGeneroPalet) > 0 And VaInt(LotesProduccion.LPD_Idlote.Valor) > 0 Then

            'Cultivos permitidos para ese género
            Dim sqlLote As String = "SELECT CGE_IdCultivo as IdGeneroTecnicos FROM CultivosGenero WHERE CGE_IdGenero = " & IdGeneroPalet
            Dim dtLote As DataTable = cnFincasNET.ConsultaSQL(sqlLote)
            If Not IsNothing(dtLote) Then
                For Each row As DataRow In dtLote.Rows

                    Dim IdGeneroTecnicos As String = (row("IdGeneroTecnicos").ToString & "").Trim
                    If VaInt(IdGeneroTecnicos) = VaInt(LotesProduccion.LPD_Idgenero.Valor) Then
                        bRes = True
                        Exit For
                    End If

                Next
            End If

        End If


        Return bRes

    End Function

End Module
