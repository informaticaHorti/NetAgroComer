Imports DevExpress.XtraEditors
Imports System.Drawing


Module C1_PaletSemiterminado


    Private margen_izquierdo As Integer = 6




    Public Sub C1_ImprimirPaletSemiterminado(ByVal IdLoteProduccion As String, TipoImpresion As TipoImpresion,
                                          Optional Impresora As String = "",
                                          Optional rutaPDF As String = "",
                                          Optional archivoPDF As String = "")

        If VaInt(IdLoteProduccion) > 0 Then


            Dim ConfiguracionesDiversas As New E_ConfiguracionesDiversas(Idusuario, cn)
            Dim papel = ConfiguracionesDiversas.xDameValor(E_ConfiguracionesDiversas.eClaves.FORMATO_PAPEL_PALETS, MiMaletin.IdPuntoVenta)


            Dim Impreso As New Impreso
            'Impreso.f.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
            If papel = "A5" Then
                Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A5
                Impreso.f.documento.PageLayout.PageSettings.Landscape = True
            Else
                Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
                Impreso.f.documento.PageLayout.PageSettings.Landscape = False
            End If
            Impreso.f.documento.PageLayout.PageSettings.TopMargin = "0mm"
            Impreso.f.Documento.PageLayout.PageSettings.BottomMargin = "0mm"
            Impreso.f.Documento.PageLayout.PageSettings.LeftMargin = "0mm"
            Impreso.f.documento.PageLayout.PageSettings.RightMargin = "0mm"

            Impreso.EstableceImpreso(TipoImpresion)


            Try

                Dim bControlado As Boolean = False

                ImprimePaletSemiterminado(IdLoteProduccion, 32, False, Impreso, bControlado)


                'Impresión / previsualización / exportación
                Dim valoresusuario As New E_valoresusuario(Idusuario, cn)
                If valoresusuario.LeerId(Idusuario) = True Then
                    'Impresora = valoresusuario.VUS_ImpresoraPaletSemiterminado.Valor
                    If bControlado Then
                        Impresora = valoresusuario.VUS_ImpresoraPaletSemitControlados.Valor
                    Else
                        Impresora = valoresusuario.VUS_ImpresoraPaletSemitNoControlados.Valor
                    End If
                End If


                Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)

            Catch ex As Exception

            End Try


        End If



    End Sub


    Private Sub ImprimePaletSemiterminado(ByVal IdLoteProduccion As String, ByVal Altura As Integer, ByVal bCopia As Boolean, ByVal Impreso As Impreso, ByRef bControlado As Boolean)


        bControlado = False
        Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)

        If LotesProduccion.LeerId(IdLoteProduccion) Then

            Dim Generos As New E_Generos(Idusuario, cn)
            Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
            Dim Envases As New E_Envases(Idusuario, cn)


            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(LotesProduccion.LPD_Idlote, "IdLote")
            CONSULTA.SelCampo(LotesProduccion.LPD_IdProgramaCalidad, "IdProgramaCalidad")
            CONSULTA.SelCampo(LotesProduccion.LPD_FechaProducto, "FechaProducto")
            CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero", LotesProduccion.LPD_Idgenero, Generos.GEN_IdGenero)
            CONSULTA.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", LotesProduccion.LPD_IdCategoria, CategoriasSalida.CAS_Id)
            CONSULTA.SelCampo(Envases.ENV_Nombre, "Envase", LotesProduccion.LPD_IdEnvase, Envases.ENV_IdEnvase)
            Dim oBultos As New Cdatos.bdcampo("@(SELECT SUM(LPL_Bultos) FROM LotesProduccion_Lineas WHERE LPL_IdLote = LPD_IdLote)", Cdatos.TiposCampo.Importe, 10)
            CONSULTA.SelCampo(oBultos, "Bultos")
            Dim oKilosNetos As New Cdatos.bdcampo("@(SELECT SUM(LPL_Kilos) FROM LotesProduccion_Lineas WHERE LPL_IdLote = LPD_IdLote)", Cdatos.TiposCampo.Importe, 10)
            CONSULTA.SelCampo(oKilosNetos, "Kilos")
            CONSULTA.SelCampo(LotesProduccion.LPD_GP, "GP")
            CONSULTA.WheCampo(LotesProduccion.LPD_Idlote, "=", IdLoteProduccion)

            Dim sql As String = CONSULTA.SQL
            Dim dt As DataTable = LotesProduccion.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim gp As String = (dt.Rows(0)("GP").ToString & "").Trim.ToUpper
                    If gp = "G" Then
                        gp = "Gordo"
                    ElseIf gp = "P" Then
                        gp = "Pequeño"
                    End If

                    Dim Numero As String = VaInt(LotesProduccion.LPD_Lote.Valor).ToString("00000000")
                    Dim Fecha As String = ""
                    If VaDate(LotesProduccion.LPD_Fecha.Valor) > VaDate("") Then Fecha = VaDate(LotesProduccion.LPD_Fecha.Valor).ToString("dd/MM/yyyy")
                    Dim Campa As String = VaInt(LotesProduccion.LPD_Campa.Valor).ToString("00")
                    Dim IdProgramaCalidad As Integer = VaInt(dt.Rows(0)("IdProgramaCalidad"))
                    Dim Genero As String = dt.Rows(0)("Genero").ToString
                    Dim Categoria As String = dt.Rows(0)("Categoria").ToString
                    Dim Bultos As String = VaInt(dt.Rows(0)("Bultos")).ToString
                    Dim Kilos As String = VaInt(dt.Rows(0)("Kilos")).ToString("#,##0")
                    Dim Envase As String = dt.Rows(0)("Envase").ToString
                    Dim FechaProducto As String = VaDate(dt.Rows(0)("FechaProducto")).ToString("dd/MM/yyyy")


                    Dim Controlado As String = ""
                    If IdProgramaCalidad <> 3 And (LotesProduccion.LPD_Controlado.Valor & "").ToUpper.Trim = "S" Then
                        Controlado = "CONTROLADO"
                    Else
                        Controlado = "NO CONTROLADO"
                    End If

                    Dim Trazabilidad As DataTable = TrazabilidadLote(IdLoteProduccion, IdProgramaCalidad)
                    Dim Calidad As String = (LotesProduccion.LPD_Calidad.Valor & "").Trim


                    'Código de barras
                    Dim Code39 As New Font("C39HrP24DhTt", 45)
                    Dim CodBar As String = "*" & "PS" & Campa & "." & LotesProduccion.LPD_Lote.Valor & "*" ' formatear a 11 caracteres. 1 pppppp bb 00
                    Impreso.Detalle.Titulo(CodBar, 0, 20, 180, 20, Estilos.Custom, ">", , Code39)


                    Impreso.Detalle.Titulo("PALET SEMITERMINADO ", margen_izquierdo, Altura, 145, 6, Estilos.Cabecera)
                    Altura = Altura + 20
                    Impreso.Detalle.Titulo("Num. Palet: ", margen_izquierdo, Altura, 25, 5, Estilos.Grande)
                    Impreso.Detalle.Titulo(Numero, margen_izquierdo + 25, Altura - 3, 65, 10, Estilos.MuyGrandeBold)
                    Impreso.Detalle.Titulo("Fecha: ", margen_izquierdo + 115, Altura, 12, 5, Estilos.Grande)
                    Impreso.Detalle.Titulo(Fecha, margen_izquierdo + 115 + 14, Altura - 3, 66, 10, Estilos.MuyGrandeBold)
                    Altura = Altura + 10

                    Dim alturaTrazabilidad As Integer = Altura + 2

                    Impreso.Detalle.Titulo("Genero: ", margen_izquierdo, Altura, 25, 5, Estilos.Grande)
                    Impreso.Detalle.Titulo(Genero, margen_izquierdo + 25, Altura - 3, 65, 10, Estilos.Cabecera)
                    Altura = Altura + 10
                    Impreso.Detalle.Titulo("Categoria: ", margen_izquierdo, Altura, 25, 5, Estilos.Grande)
                    Impreso.Detalle.Titulo(Categoria & " - " & gp, margen_izquierdo + 25, Altura - 3, 65, 10, Estilos.Cabecera)
                    Altura = Altura + 10
                    Impreso.Detalle.Titulo("Bultos: ", margen_izquierdo, Altura, 25, 5, Estilos.Grande)
                    Impreso.Detalle.Titulo(Bultos, margen_izquierdo + 25, Altura - 3, 65, 10, Estilos.MuyGrandeBold)
                    Altura = Altura + 10
                    Impreso.Detalle.Titulo("Kilos netos: ", margen_izquierdo, Altura, 25, 5, Estilos.Grande)
                    Impreso.Detalle.Titulo(Kilos, margen_izquierdo + 25, Altura - 3, 65, 10, Estilos.MuyGrandeBold)
                    Altura = Altura + 10
                    Impreso.Detalle.Titulo("Envase: ", margen_izquierdo, Altura, 25, 5, Estilos.Grande)
                    Impreso.Detalle.Titulo(Envase, margen_izquierdo + 25, Altura - 3, 65, 10, Estilos.MuyGrandeBold)
                    Altura = Altura + 10
                    'Impreso.Detalle.Titulo("Trazabilidad: ", margen_izquierdo, Altura, 25, 5, Estilos.Grande)
                    'Impreso.Detalle.Titulo(Trazabilidad, margen_izquierdo + 25, Altura - 3, 155, 10, Estilos.MuyGrandeBold)
                    'Altura = Altura + 10
                    Impreso.Detalle.Titulo(Controlado, margen_izquierdo, Altura, 60, 6, Estilos.Cabecera)
                    Impreso.Detalle.Titulo("CALIDAD " & Calidad, margen_izquierdo, Altura + 6, 60, 6, Estilos.Cabecera)

                    'Dim NormasCalidad As String = NormasProgramaCalidad(IdProgramaCalidad)

                    Dim ProgramasCalidad As New E_ProgramaCalidadTecnicos(Idusuario, cn)
                    If ProgramasCalidad.LeerId(IdProgramaCalidad) Then
                        Impreso.Detalle.Titulo(ProgramasCalidad.PCT_Nombre.Valor, margen_izquierdo, Altura + 15, 200, 6, Estilos.Grande)
                    End If

                    Impreso.Detalle.Titulo("Antigüedad:", margen_izquierdo + 90, Altura + 9, 60, 6, Estilos.Grande)
                    Impreso.Detalle.Titulo(FechaProducto, margen_izquierdo + 116, Altura + 6, 60, 10, Estilos.MuyGrandeBold)


                    Dim finEspacio As Integer = 125

                    Impreso.Detalle.Titulo("Trazabilidad", margen_izquierdo + 95, alturaTrazabilidad, 95, 6, Estilos.Cabecera, "=")
                    alturaTrazabilidad = alturaTrazabilidad + 8
                    Impreso.Detalle.Titulo("PARTIDA", margen_izquierdo + 90, alturaTrazabilidad, 23, 6, Estilos.Grande)
                    Impreso.Detalle.Titulo("PROT.", margen_izquierdo + 112, alturaTrazabilidad, 14, 6, Estilos.Grande)
                    Impreso.Detalle.Titulo("AGR", margen_izquierdo + 133, alturaTrazabilidad, 17, 6, Estilos.Grande, "=")
                    Impreso.Detalle.Titulo("GGN", margen_izquierdo + 150, alturaTrazabilidad, 30, 6, Estilos.Grande)
                    Impreso.Detalle.Titulo("BULTOS", margen_izquierdo + 172, alturaTrazabilidad, 25, 6, Estilos.Grande, ">")
                    alturaTrazabilidad = alturaTrazabilidad + 6

                    For Each r As DataRow In Trazabilidad.Rows
                        If alturaTrazabilidad < finEspacio Then

                            Dim Num As String = (r("Numero").ToString & "").Trim
                            Dim Tipo As String = (r("Tipo").ToString & "").Trim
                            Num = Tipo & Num

                            Dim CodAgr As String = ""
                            If VaInt(r("CodAgr")) > 0 Then
                                CodAgr = VaInt(r("CodAgr")).ToString()
                            End If

                            If CodAgr = "" And (r("Tipo").ToString & "").Trim = "L" Then
                                CodAgr = (r("IdAgricultorMayoritario").ToString & "").Trim
                            End If

                            Impreso.Detalle.Titulo(Num, margen_izquierdo + 90, alturaTrazabilidad, 23, 6, Estilos.GrandeBold)
                            Impreso.Detalle.Titulo(r("Protocolo").ToString, margen_izquierdo + 112, alturaTrazabilidad + 1, 21, 6, Estilos.NormalBold)
                            Impreso.Detalle.Titulo(CodAgr, margen_izquierdo + 133, alturaTrazabilidad, 17, 6, Estilos.GrandeBold, "=")
                            Impreso.Detalle.Titulo(r("GGN").ToString, margen_izquierdo + 150, alturaTrazabilidad + 1, 29, 6, Estilos.NormalBold)
                            Impreso.Detalle.Titulo(VaInt(r("Bultos")).ToString("#,###"), margen_izquierdo + 172, alturaTrazabilidad, 25, 6, Estilos.GrandeBold, ">")
                            'PaletSemi.Detalle.Titulo(r("kilos").ToString & " kg", 160, alturaTrazabilidad, 37, 6, Estilos.GrandeBold, ">")

                        End If

                        alturaTrazabilidad = alturaTrazabilidad + 6


                        Application.DoEvents()

                    Next


                End If
            End If


            bControlado = ((LotesProduccion.LPD_Controlado.Valor & "").Trim = "S")

        Else
            MsgBox("Imposible leer el palet semiterminado con Id " & IdLoteProduccion)
        End If


    End Sub


    'Private Function TrazabilidadLote(IdLoteProduccion As String) As String

    '    Dim res As String = ""

    '    Dim LotesProduccion_Lineas As New E_LotesProduccion_Lineas(Idusuario, cn)


    '    Dim sql As String = "SELECT LPL_IdLinea, 'P' as Tipo, AEL_Muestreo as Numero" & vbCrLf
    '    sql = sql & " FROM LotesProduccion_Lineas" & vbCrLf
    '    sql = sql & " INNER JOIN AlbEntrada_Lineas ON LPL_IdLineaEntrada = AEL_IdLinea" & vbCrLf
    '    sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
    '    sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = AEL_IdGenero" & vbCrLf
    '    sql = sql & " LEFT JOIN Agricultores ON AEN_IdAgricultor = AGR_IdAgricultor" & vbCrLf
    '    sql = sql & " WHERE LPL_IdLote = " & IdLoteProduccion & vbCrLf
    '    sql = sql & " AND LPL_IdProgramaCliente = " & MiMaletin.idprogramacliente.ToString & vbCrLf
    '    sql = sql & " UNION ALL" & vbCrLf
    '    sql = sql & " SELECT LPL_IdLinea, 'L' as Tipo, LTE_Lote as Numero" & vbCrLf
    '    sql = sql & " FROM LotesProduccion_Lineas" & vbCrLf
    '    sql = sql & " INNER JOIN Lotes ON LTE_IdLote = LPL_IdLotePartida" & vbCrLf
    '    sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = LTE_IdGenero" & vbCrLf
    '    sql = sql & " WHERE LPL_IdLote = " & IdLoteProduccion & vbCrLf
    '    sql = sql & " AND LPL_IdProgramaCliente = " & MiMaletin.idprogramacliente.ToString & vbCrLf
    '    sql = sql & " ORDER BY LPL_IdLinea" & vbCrLf

    '    Dim dt As DataTable = LotesProduccion_Lineas.MiConexion.ConsultaSQL(sql)
    '    If Not IsNothing(dt) Then

    '        For Each row As DataRow In dt.Rows

    '            Dim tipo As String = (row("Tipo").ToString & "").ToUpper.Trim
    '            Dim numero As String = (row("Numero").ToString & " ").Trim

    '            If res.Trim <> "" Then res = res & ","
    '            res = res & tipo & "." & numero

    '        Next

    '    End If


    '    Return res

    'End Function


    Private Function TrazabilidadLote(ByVal IdLoteProduccion As String, ByVal IdProgramaCalidad As String) As DataTable
        Dim res As String = ""


        Dim LotesProduccion_Lineas As New E_LotesProduccion_Lineas(Idusuario, cn)


        Dim sql As String = "SELECT LPL_IdLinea, 'P' as Tipo, AEL_Muestreo as Numero, AEN_IdAgricultor as CodAgr," & vbCrLf
        sql = sql & " CAST(AEL_CampaCultivo as varchar) as CampaCultivo, CAST(AEL_IdCultivo as varchar) as IdCultivo, LPL_Bultos as Bultos, PCT_Nombre as Protocolo," & vbCrLf
        sql = sql & " AEL_IdPrograma as IdProgramaCalidad, AEN_IdAgricultor as IdAgricultorMayoritario" & vbCrLf
        sql = sql & " FROM LotesProduccion_Lineas" & vbCrLf
        sql = sql & " INNER JOIN AlbEntrada_Lineas ON LPL_IdLineaEntrada = AEL_IdLinea" & vbCrLf
        sql = sql & " LEFT JOIN ProgramaCalidadTecnicos ON PCT_Idprograma = AEL_IdPrograma"
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = AEL_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN Agricultores ON AEN_IdAgricultor = AGR_IdAgricultor" & vbCrLf
        sql = sql & " WHERE LPL_IdLote = " & IdLoteProduccion & vbCrLf
        sql = sql & " AND LPL_IdProgramaCliente = " & MiMaletin.idprogramacliente.ToString & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT LPL_IdLinea, 'L' as Tipo, LTE_Lote as Numero, " & vbCrLf
        sql = sql & " '' as CodAgr, " & vbCrLf
        sql = sql & " '' as CampaCultivo, '' as IdCultivo, LPL_Bultos as Bultos, PCT_Nombre as Protocolo," & vbCrLf
        sql = sql & " LTE_IdProgramaCalidad as IdProgramaCalidad," & vbCrLf
        sql = sql & " (SELECT TOP 1 AEN_IdAgricultor FROM Lotes_Lineas LEFT JOIN AlbEntrada_Lineas ON AEL_IdLinea = LTL_IdLineaEntrada LEFT JOIN AlbEntrada ON AEN_IdAlbaran = AEL_IdAlbaran WHERE LTL_IdLote = LTE_IdLote ORDER BY LTL_Kilos DESC) as IdAgricultorMayoritario" & vbCrLf
        sql = sql & " FROM LotesProduccion_Lineas" & vbCrLf
        sql = sql & " INNER JOIN Lotes ON LTE_IdLote = LPL_IdLotePartida" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = LTE_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN ProgramaCalidadTecnicos ON PCT_Idprograma = LTE_IdProgramaCalidad"
        sql = sql & " WHERE LPL_IdLote = " & IdLoteProduccion & vbCrLf
        sql = sql & " AND LPL_IdProgramaCliente = " & MiMaletin.idprogramacliente.ToString & vbCrLf
        sql = sql & " ORDER BY LPL_IdLinea" & vbCrLf


        Dim dt As DataTable = LotesProduccion_Lineas.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dt) Then

            dt.Columns.Add(New DataColumn("GGN", GetType(String)))
            'dt.Columns.Add(New DataColumn("Protocolo", GetType(String)))


            For Each row As DataRow In dt.Rows

                Dim Tipo As String = (row("Tipo").ToString & "").Trim

                If Tipo = "P" Then ' PARTIDA

                    Dim IdAgricultor As String = (row("CodAgr").ToString & "").Trim
                    Dim CampaCultivo As String = VaInt(row("CampaCultivo")).ToString("00")
                    Dim IdCultivo As Integer = VaInt(row("IdCultivo"))
                    Dim IdProgramaCalidadPartida As String = (row("IdProgramaCalidad").ToString & "").Trim

                    Dim l1 As String = ""
                    Dim l2 As String = ""
                    GGNBoletinPrograma(CampaCultivo, IdAgricultor, IdProgramaCalidadPartida, l1, l2)

                    Dim ggn As String = l2
                    If ggn.Contains(".  ") Then

                        Dim s As String() = Split(ggn, ".  ")
                        If s.Length > 0 Then

                            For Each item As String In s

                                If item.StartsWith("GGN:") Then

                                    Dim s2 As String() = Split(s(0), ": ")
                                    If s2.Length > 0 Then

                                        ggn = s2(1).Trim
                                        row("GGN") = ggn

                                    End If

                                    Exit For

                                End If

                            Next

                        End If

                    End If

                    'Dim protocolo As String = ProgProtocolo(CampaCultivo, IdAgricultor, IdCultivo)
                    'row("Protocolo") = protocolo


                Else 'LOTE


                    If LotesProduccion_Lineas.LeerId(row("LPL_IdLinea")) Then

                        Dim Lotes_lineas As New E_Lotes_lineas(Idusuario, cn)
                        Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
                        Dim Albentrada As New E_AlbEntrada(Idusuario, cn)

                        Dim CONSULTA As New Cdatos.E_select
                        CONSULTA.SelCampo(Lotes_lineas.LTL_Idlineaentrada, "IdLineaEntrada")
                        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idalbaran, "IdAlbaran", Lotes_lineas.LTL_Idlineaentrada)
                        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_campacultivo, "CampaCultivo")
                        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idcultivo, "IdCultivo")
                        CONSULTA.SelCampo(Albentrada.AEN_IdAgricultor, "IdAgricultor", AlbEntrada_Lineas.AEL_idalbaran)
                        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idprograma, "IdProgramaCalidad")
                        CONSULTA.WheCampo(Lotes_lineas.LTL_Idlote, "=", LotesProduccion_Lineas.LPL_IdLotePartida.Valor)


                        Dim sqlAGR As String = "SELECT IdAgricultor, CampaCultivo, IdCultivo, IdProgramaCalidad  FROM (" & CONSULTA.SQL & ") as G GROUP BY IdAgricultor, CampaCultivo, IdCultivo, IdProgramaCalidad "

                        Dim dtAGR As DataTable = Lotes_lineas.MiConexion.ConsultaSQL(sqlAGR)

                        If Not IsNothing(dtAGR) Then

                            If dtAGR.Rows.Count = 1 Then

                                Dim IdAgricultor As String = (dtAGR.Rows(0)("IdAgricultor").ToString & "").Trim
                                Dim CampaCultivo As String = VaInt(dtAGR.Rows(0)("CampaCultivo")).ToString("00")
                                Dim IdCultivo As Integer = VaInt(dtAGR.Rows(0)("IdCultivo"))
                                Dim IdProgramaCalidadPartida As String = (dtAGR.Rows(0)("IdProgramaCalidad").ToString & "").Trim

                                Dim l1 As String = ""
                                Dim l2 As String = ""
                                'GGNBoletin(CampaCultivo, IdAgricultor, IdCultivo, l1, l2)
                                GGNBoletinPrograma(IdAgricultor, IdProgramaCalidadPartida, l1, l2)

                                Dim ggn As String = l2
                                If ggn.Contains(".  ") Then

                                    Dim s As String() = Split(ggn, ".  ")
                                    If s.Length > 0 Then

                                        'If s(0).StartsWith("GGN:") Then

                                        '    Dim s2 As String() = Split(s(0), ": ")
                                        '    If s2.Length > 0 Then

                                        '        ggn = s2(1).Trim
                                        '        row("GGN") = ggn
                                        '        row("CodAgr") = IdAgricultor

                                        '    End If

                                        'End If

                                        For Each item As String In s

                                            If item.StartsWith("GGN:") Then

                                                Dim s2 As String() = Split(s(0), ": ")
                                                If s2.Length > 0 Then

                                                    ggn = s2(1).Trim
                                                    row("GGN") = ggn

                                                End If

                                                Exit For

                                            End If

                                        Next


                                    End If

                                End If

                            End If

                        End If

                    End If

                End If


                Application.DoEvents()

            Next
        End If


        Return dt
    End Function




End Module
