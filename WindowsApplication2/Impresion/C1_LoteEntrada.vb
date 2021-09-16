Imports DevExpress.XtraEditors
Imports System.Drawing

Module C1_LoteEntrada

    Private margen_izquierdo As Integer = 10

    Public Sub C1_ImprimirLoteEntrada(ByVal IdLoteEntrada As String, TipoImpresion As TipoImpresion,
                                          Optional Impresora As String = "",
                                          Optional rutaPDF As String = "",
                                          Optional archivoPDF As String = "")
        If VaInt(IdLoteEntrada) > 0 Then


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
            Impreso.f.documento.PageLayout.PageSettings.BottomMargin = "0mm"
            Impreso.f.documento.PageLayout.PageSettings.LeftMargin = "0mm"
            Impreso.f.documento.PageLayout.PageSettings.RightMargin = "0mm"

            Impreso.EstableceImpreso(TipoImpresion)

            Try

                Dim bControlado As Boolean = False

                ImprimeLoteEntrada(IdLoteEntrada, 42, False, Impreso, bControlado)

                'Impresión / previsualización / exportación
                Dim valoresusuario As New E_valoresusuario(Idusuario, cn)
                If valoresusuario.LeerId(Idusuario) = True Then
                    'Impresora = valoresusuario.VUS_ImpresoraPaletSemiterminado.Valor
                    If bControlado Then
                        Impresora = valoresusuario.VUS_ImpresoraLotesControlados.Valor
                    Else
                        Impresora = valoresusuario.VUS_ImpresoraLotesNoControlados.Valor
                    End If
                End If

                Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)

            Catch ex As Exception

            End Try

        End If
    End Sub

    Public Sub ImprimeLoteEntrada(ByVal IdLoteEntrada As String, ByVal Altura As Integer, ByVal bCopia As Boolean, ByVal Impreso As Impreso, ByRef bControlado As Boolean)

        bControlado = False
        Dim Lote As New E_Lotes(Idusuario, cn)

        If Lote.LeerId(IdLoteEntrada) Then

            Dim Generos As New E_Generos(Idusuario, cn)
            Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
            Dim Envases As New E_Envases(Idusuario, cn)

            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(Lote.LTE_Idlote, "IdLote")
            CONSULTA.SelCampo(Lote.LTE_IdProgramaCalidad, "IdProgramaCalidad")
            CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero", Lote.LTE_Idgenero, Generos.GEN_IdGenero)
            'Los lotes de entrada no tienen categoria
            'CONSULTA.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", Lote.Lte_IdCategoria, CategoriasSalida.CAS_Id)
            CONSULTA.SelCampo(Envases.ENV_Nombre, "Envase", Lote.LTE_IdEnvase, Envases.ENV_IdEnvase)
            Dim oBultos As New Cdatos.bdcampo("@(SELECT SUM(LTL_Bultos) FROM Lotes_Lineas WHERE LTL_IdLote = LTE_IdLote)", Cdatos.TiposCampo.Importe, 10)
            CONSULTA.SelCampo(oBultos, "Bultos")
            Dim oKilosNetos As New Cdatos.bdcampo("@(SELECT SUM(LTL_Kilos) FROM Lotes_Lineas WHERE LTL_IdLote = LTE_IdLote)", Cdatos.TiposCampo.Importe, 10)
            CONSULTA.SelCampo(oKilosNetos, "Kilos")
            CONSULTA.WheCampo(Lote.LTE_Idlote, "=", IdLoteEntrada)

            Dim sql As String = CONSULTA.SQL
            Dim dt As DataTable = Lote.MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Dim Numero As String = VaInt(Lote.LTE_Lote.Valor).ToString("00000000")
                    Dim IdProgramaCalidad As Integer = VaInt(dt.Rows(0)("IdProgramaCalidad"))
                    Dim Campa As String = VaInt(Lote.LTE_Campa.Valor).ToString("00")
                    Dim Genero As String = dt.Rows(0)("Genero").ToString
                    Dim Bultos As String = VaInt(dt.Rows(0)("Bultos")).ToString
                    Dim Kilos As String = VaInt(dt.Rows(0)("Kilos")).ToString("#,##0")
                    Dim Envase As String = dt.Rows(0)("Envase").ToString
                    Dim Trazabilidad As DataTable = TrazabilidadLote(IdLoteEntrada)
                    Dim Controlado As String = ""

                    If IdProgramaCalidad <> 3 And (Lote.LTE_Controlado.Valor & "").ToUpper.Trim = "S" Then
                        Controlado = "CONTROLADO"
                    Else
                        Controlado = "NO CONTROLADO"
                    End If

                    Dim Calidad As String = (Lote.LTE_Calidad.Valor & "").Trim


                    'Código de barras
                    Dim Code39 As New Font("C39HrP24DhTt", 45)
                    Dim CodBar As String = "*" & "LE" & Campa & "." & Lote.LTE_Lote.Valor & "*" ' formatear a 11 caracteres. 1 pppppp bb 00
                    Impreso.Detalle.Titulo(CodBar, 0, 20, 180, 20, Estilos.Custom, ">", , Code39)

                    Impreso.Detalle.Titulo("LOTE DE ENTRADA", margen_izquierdo, Altura, 145, 6, Estilos.Cabecera)

                    Dim alturaTrazabilidad As Integer = Altura + 2

                    Altura = Altura + 20
                    Impreso.Detalle.Titulo("Num. Palet: ", margen_izquierdo, Altura, 25, 5, Estilos.Grande)
                    Impreso.Detalle.Titulo(Numero, margen_izquierdo + 25, Altura - 3, 65, 10, Estilos.MuyGrandeBold)
                    Altura = Altura + 10
                    Impreso.Detalle.Titulo("Genero: ", margen_izquierdo, Altura, 25, 5, Estilos.Grande)
                    Impreso.Detalle.Titulo(Genero, margen_izquierdo + 25, Altura - 3, 65, 10, Estilos.MuyGrandeBold)
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
                    Impreso.Detalle.Titulo(Controlado, margen_izquierdo, Altura, 60, 6, Estilos.Cabecera)
                    Impreso.Detalle.Titulo("CALIDAD " & Calidad, margen_izquierdo, Altura + 6, 60, 6, Estilos.Cabecera)

                    'Dim NormasCalidad As String = NormasProgramaCalidad(IdProgramaCalidad)

                    Dim ProgramasCalidad As New E_ProgramaCalidadTecnicos(Idusuario, cn)
                    If ProgramasCalidad.LeerId(IdProgramaCalidad) Then
                        Impreso.Detalle.Titulo(ProgramasCalidad.PCT_Nombre.Valor, margen_izquierdo, Altura + 15, 200, 6, Estilos.Grande)
                    End If






                    Dim finEspacio As Integer = 125

                    Impreso.Detalle.Titulo("Trazabilidad", margen_izquierdo + 95, alturaTrazabilidad, 95, 6, Estilos.Cabecera, "=")
                    alturaTrazabilidad = alturaTrazabilidad + 8
                    Impreso.Detalle.Titulo("PARTIDA", margen_izquierdo + 90, alturaTrazabilidad, 23, 6, Estilos.Grande)
                    Impreso.Detalle.Titulo("PROT.", margen_izquierdo + 112, alturaTrazabilidad, 14, 6, Estilos.Grande)
                    Impreso.Detalle.Titulo("AGR", margen_izquierdo + 133, alturaTrazabilidad, 17, 6, Estilos.Grande, "=")
                    Impreso.Detalle.Titulo("GGN", margen_izquierdo + 150, alturaTrazabilidad, 30, 6, Estilos.Grande)
                    Impreso.Detalle.Titulo("BULTOS", margen_izquierdo + 172, alturaTrazabilidad, 25, 6, Estilos.Grande, ">")


                    'Impreso.Detalle.Titulo("Trazabilidad", margen_izquierdo + 95, alturaTrazabilidad, 95, 6, Estilos.Cabecera, "=")
                    'alturaTrazabilidad = alturaTrazabilidad + 8
                    'Impreso.Detalle.Titulo("PARTIDA", margen_izquierdo + 95, alturaTrazabilidad, 23, 6, Estilos.Grande)
                    'Impreso.Detalle.Titulo("AGR", margen_izquierdo + 118, alturaTrazabilidad, 17, 6, Estilos.Grande, "=")
                    'Impreso.Detalle.Titulo("GGN", margen_izquierdo + 135, alturaTrazabilidad, 30, 6, Estilos.Grande)
                    'Impreso.Detalle.Titulo("BULTOS", margen_izquierdo + 165, alturaTrazabilidad, 25, 6, Estilos.Grande, ">")
                    alturaTrazabilidad = alturaTrazabilidad + 6

                    For Each r As DataRow In Trazabilidad.Rows
                        If alturaTrazabilidad < finEspacio Then
                            'Impreso.Detalle.Titulo(r("Partida").ToString, margen_izquierdo + 95, alturaTrazabilidad, 23, 6, Estilos.GrandeBold)
                            'Impreso.Detalle.Titulo(VaInt(r("CodAgr")).ToString(), margen_izquierdo + 118, alturaTrazabilidad, 17, 6, Estilos.GrandeBold, "=")
                            'Impreso.Detalle.Titulo(r("GGN").ToString, margen_izquierdo + 135, alturaTrazabilidad + 1, 29, 6, Estilos.NormalBold)
                            'Impreso.Detalle.Titulo(VaInt(r("Bultos")).ToString("#,###"), margen_izquierdo + 165, alturaTrazabilidad, 25, 6, Estilos.GrandeBold, ">")

                            'PaletSemi.Detalle.Titulo(r("kilos").ToString & " kg", 160, alturaTrazabilidad, 37, 6, Estilos.GrandeBold, ">")

                            Impreso.Detalle.Titulo(r("Partida").ToString(), margen_izquierdo + 90, alturaTrazabilidad, 23, 6, Estilos.GrandeBold)
                            Impreso.Detalle.Titulo(r("Protocolo").ToString(), margen_izquierdo + 112, alturaTrazabilidad + 1, 21, 6, Estilos.NormalBold)
                            Impreso.Detalle.Titulo(VaInt(r("CodAgr")).ToString(), margen_izquierdo + 133, alturaTrazabilidad, 17, 6, Estilos.GrandeBold, "=")
                            Impreso.Detalle.Titulo(r("GGN").ToString, margen_izquierdo + 150, alturaTrazabilidad + 1, 29, 6, Estilos.NormalBold)
                            Impreso.Detalle.Titulo(VaInt(r("Bultos")).ToString("#,###"), margen_izquierdo + 172, alturaTrazabilidad, 25, 6, Estilos.GrandeBold, ">")


                        End If

                        alturaTrazabilidad = alturaTrazabilidad + 6


                        Application.DoEvents()

                    Next
                End If
            End If

            bControlado = ((Lote.LTE_Controlado.Valor & "").Trim = "S")

        Else
            MsgBox("Imposible leer el palet semiterminado con Id " & IdLoteEntrada)
        End If
    End Sub


    Private Function TrazabilidadLote(IdLoteEntrada As String) As DataTable
        Dim res As String = ""

        Dim Lotes_Lineas As New E_Lotes_lineas(Idusuario, cn)
        Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
        Dim ProgramaCalidadTec As New E_ProgramaCalidadTecnicos(Idusuario, cn)
        Dim Lotes As New E_Lotes(Idusuario, cn)


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(Lotes_Lineas.LTL_Idlinea, "IdLinea")
        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_muestreo, "Partida", Lotes_Lineas.LTL_Idlineaentrada, AlbEntrada_Lineas.AEL_idlinea)
        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_campacultivo, "CampaCultivo")
        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idcultivo, "IdCultivo")
        CONSULTA.SelCampo(ProgramaCalidadTec.PCT_Nombre, "Protocolo", AlbEntrada_Lineas.AEL_idprograma)
        CONSULTA.SelCampo(AlbEntrada.AEN_IdAgricultor, "CodAgr", AlbEntrada_Lineas.AEL_idalbaran)
        CONSULTA.SelCampo(Lotes_Lineas.LTL_Bultos, "Bultos")
        CONSULTA.SelCampo(Lotes_Lineas.LTL_Kilos, "kilos")
        CONSULTA.SelCampo(Lotes.LTE_IdProgramaCalidad, "IdProgramaCalidad", Lotes_Lineas.LTL_Idlote, Lotes.LTE_Idlote)
        CONSULTA.WheCampo(Lotes_Lineas.LTL_Idlote, "=", IdLoteEntrada)

        Dim sql As String = CONSULTA.SQL & vbCrLf
        sql = sql & " AND COALESCE(AEL_IdLinea,0) > 0" & vbCrLf
        sql = sql & " ORDER BY LTL_IdLinea"

        Dim dt As DataTable = Lotes_Lineas.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dt) Then

            dt.Columns.Add(New DataColumn("GGN", GetType(String)))
            'dt.Columns.Add(New DataColumn("Protocolo", GetType(String)))


            For Each row As DataRow In dt.Rows

                Dim IdAgricultor As String = (row("CodAgr").ToString & "").Trim
                Dim CampaCultivo As String = VaInt(row("CampaCultivo")).ToString("00")
                Dim IdCultivo As Integer = VaInt(row("IdCultivo"))
                Dim IdProgramaCalidad As String = (row("IdProgramaCalidad").ToString & "").Trim

                Dim l1 As String = ""
                Dim l2 As String = ""
                'GGnBoletin(CampaCultivo, IdAgricultor, IdCultivo, l1, l2)
                GGNBoletinPrograma(IdAgricultor, IdProgramaCalidad, l1, l2)

                Dim ggn As String = l2
                If ggn.Contains(".  ") Then

                    Dim s As String() = Split(ggn, ".  ")
                    If s.Length > 0 Then

                        If s(0).StartsWith("GGN:") Then

                            Dim s2 As String() = Split(s(0), ": ")
                            If s2.Length > 0 Then

                                ggn = s2(1).Trim
                                row("GGN") = ggn

                            End If

                        End If

                    End If

                End If


                'Dim protocolo As String = ProgProtocolo(CampaCultivo, IdAgricultor, IdCultivo)
                'row("Protocolo") = protocolo

                Application.DoEvents()

            Next
        End If


        Return dt
    End Function

End Module
