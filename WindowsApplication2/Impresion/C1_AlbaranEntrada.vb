Imports DevExpress.XtraEditors
Imports System.Drawing


Module C1_AlbaranEntrada


    Dim margen_izquierdo As Integer = 1
    Dim fuente As New Font("Courier New", 12)


    Public Sub C1_ImprimirAlbaraEntrada(ByVal IdAlbaran As String, TipoImpresion As TipoImpresion, NumCopias As Integer,
                                          Optional Impresora As String = "",
                                          Optional rutaPDF As String = "",
                                          Optional archivoPDF As String = "")


        Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)

        If VaInt(IdAlbaran) > 0 Then

            Dim ConfiguracionesDiversas As New E_ConfiguracionesDiversas(Idusuario, cn)
            Dim papel = ConfiguracionesDiversas.xDameValor(E_ConfiguracionesDiversas.eClaves.FORMATO_PAPEL_ENTRADAS, MiMaletin.IdPuntoVenta)

            Dim Impreso As New Impreso

            If papel = "A5" Then
                Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A5
                Impreso.f.documento.PageLayout.PageSettings.Landscape = True
            Else
                Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
                Impreso.f.documento.PageLayout.PageSettings.Landscape = False
                NumCopias = 0
            End If

            Impreso.f.documento.PageLayout.PageSettings.TopMargin = "0mm"
            Impreso.f.documento.PageLayout.PageSettings.BottomMargin = "0mm"
            Impreso.f.documento.PageLayout.PageSettings.LeftMargin = "0mm"
            Impreso.f.documento.PageLayout.PageSettings.RightMargin = "0mm"


            Impreso.EstableceImpreso(TipoImpresion )


            Dim Col As New List(Of Integer)
            Col.Add(0)
            Col.Add(margen_izquierdo)
            Col.Add(margen_izquierdo + 25)
            Col.Add(margen_izquierdo + 25 + 68)
            Col.Add(margen_izquierdo + 25 + 68 + 36)
            Col.Add(margen_izquierdo + 25 + 68 + 36 + 10)
            Col.Add(margen_izquierdo + 25 + 68 + 36 + 10 + 21)
            Col.Add(margen_izquierdo + 25 + 68 + 36 + 10 + 21 + 21)



            Try

                ImprimeAlbaranEntrada(IdAlbaran, 34, Impreso, Col)

                'Impresión / previsualización / exportación
                Dim valoresusuario As New E_valoresusuario(Idusuario, cn)
                If valoresusuario.LeerId(Idusuario) = True Then
                    Impresora = valoresusuario.VUS_ImpresoraAlbEntrada.Valor
                End If

                Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF, NumCopias)

            Catch ex As Exception

            End Try


        Else
            XtraMessageBox.Show("No hay datos que imprimir", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub


    Private Sub ImprimeAlbaranEntrada(ByVal IdAlbaran As String, ByVal Altura As Integer, ByRef AlbaranEntrada As Impreso,
                                      Col As List(Of Integer))


        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
        Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)
        Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
        Dim Acreedores As New E_Acreedores(Idusuario, cn)
        Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)
        Dim ProgramasCalidadTecnicos As New E_ProgramaCalidadTecnicos(Idusuario, cn)


        If AlbEntrada.LeerId(IdAlbaran) Then


            Dim DatosEmpresa As New DatosEmpresa

            Dim Campaña As String = AlbEntrada.AEN_Campa.Valor
            Dim Albaran As String = (AlbEntrada.AEN_Albaran.Valor & "").PadLeft(6, Convert.ToChar("0"))

            Dim Fecha As String = AlbEntrada.AEN_Fecha.Valor
            Dim Codigo As String = (AlbEntrada.AEN_IdAgricultor.Valor & "").PadLeft(5, Convert.ToChar("0"))


            Dim IdEmpresa As Integer = 1
            Dim Empresa As String = ""

            Dim Agricultor As String = ""
            If Agricultores.LeerId(Codigo) Then
                Agricultor = Agricultores.AGR_Nombre.Valor
                If VaInt(Agricultores.AGR_idempresa.Valor) > 0 Then

                    IdEmpresa = VaInt(Agricultores.AGR_idempresa.Valor)

                    If IdEmpresa = 2 Then ' solo hortihorto
                        Dim Empresas As New E_Empresas(Idusuario, cn)
                        If Empresas.LeerId(IdEmpresa) Then
                            Empresa = (Empresas.EMP_Nombre.Valor & "").Trim
                        End If
                    End If

                End If
            End If


            Dim Transportista As String = ""
            Dim IdTransportista As String = (AlbEntrada.AEN_IdTransportista.Valor)
            If Acreedores.LeerId(IdTransportista) Then
                If VaInt(IdTransportista) > 0 Then
                    Transportista = VaInt(IdTransportista).ToString("00000") & " " & Acreedores.ACR_Nombre.Valor
                End If
            End If

            'Dim Controlado As String = AlbEntrada.AlbaranControlado()
            'If Controlado = "S" Then
            '    Controlado = "CONTROLADO"
            'Else
            '    Controlado = "NO CONTROLADO"
            'End If


            ''Código de barras
            'Dim Code39 As New Font("C39HrP24DhTt", 42)
            Dim CodBar As String = "*AE" & Fnc0(Campaña, 2) & "." & VaInt(AlbEntrada.AEN_Albaran.Valor).ToString & "*"
            'AlbaranEntrada.Detalle.Titulo(CodBar, 35, 25, 165, 18, Estilos.Custom, ">", , Code39)


            'Cabecera
            ImprimeCabeceraAlbaranEntrada(AlbaranEntrada, DatosEmpresa, Altura, Col, Albaran, Fecha, Codigo, Agricultor, Empresa, CodBar)


            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idlinea, "idlinea")
            CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_muestreo, "Partida")
            CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idgenero, "Genero")
            CONSULTA.SelCampo(Generos.GEN_NombreGenero, "NombreGenero", AlbEntrada_Lineas.AEL_idgenero)
            CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_bultos, "Bultos")
            CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_kilosnetos, "Kilos")
            CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idcultivo, "IdCultivo")
            CONSULTA.SelCampo(AlbEntrada.AEN_Campa, "Campa", AlbEntrada_Lineas.AEL_idalbaran, AlbEntrada.AEN_IdAlbaran)
            CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_campacultivo, "CampaCultivo")
            CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_Controlado, "Controlado")
            CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idprograma, "IdProgramaCalidad")
            'CONSULTA.SelCampo(ProgramasCalidadTecnicos.PCT_Nombre, "Protocolo", AlbEntrada_Lineas.AEL_idprograma)
            CONSULTA.WheCampo(AlbEntrada_Lineas.AEL_idalbaran, "=", IdAlbaran)
            Dim Sql As String = CONSULTA.SQL
            Sql = Sql + " order by idlinea"


            Dim TotalBultos As Decimal = 0
            Dim TotalKg As Decimal = 0
            Dim cont As Integer = 1


            Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(Sql)


            'Debug
            'For indice As Integer = 0 To 9
            '    Dim r As DataRow = dt.Rows(0)
            '    dt.ImportRow(r)
            'Next



            For Each row As DataRow In dt.Rows

                If cont > 1 And cont Mod 6 = 1 Then

                    AlbaranEntrada.Detalle.Titulo("(SUMA Y SIGUE)", margen_izquierdo, Altura, 145, 5, Estilos.Custom, ">", , fuente)

                    Altura = 34

                    AlbaranEntrada.Detalle.SaltoPagina()
                    ImprimeCabeceraAlbaranEntrada(AlbaranEntrada, DatosEmpresa, Altura, Col, Albaran, Fecha, Codigo, Agricultor, Empresa, CodBar)

                End If

                Dim Partida As String = row("Partida").ToString
                Dim Genero As String = row("NombreGenero").ToString
                Dim Finca As String = VaInt(row("Campa")).ToString("00") & VaInt(row("IdCultivo")).ToString("00000")
                Dim IdCultivo As String = (row("IdCultivo").ToString & "").Trim
                Dim bultos As Integer = VaInt(row("Bultos"))
                Dim kg As Decimal = VaDec(row("Kilos"))
                Dim controlado As String = (row("Controlado").ToString & "").Trim
                Dim IdProgramaCalidad As String = (row("IdProgramaCalidad").ToString & "").Trim
                TotalBultos = TotalBultos + bultos
                TotalKg = TotalKg + kg

                Dim CampaCultivo As Integer = VaInt(row("CampaCultivo"))

                Dim Protocolo As String = ""
                Dim l2 As String = ""
                'GGnBoletin(CampaCultivo, VaInt(AlbEntrada.AEN_IdAgricultor.Valor), VaInt(IdCultivo), Protocolo, l2)
                GGNBoletinPrograma(VaInt(AlbEntrada.AEN_IdAgricultor.Valor), IdProgramaCalidad, Protocolo, l2)



                AlbaranEntrada.Detalle.Titulo(VaInt(Partida).ToString("00000000"), Col(1), Altura, 20, 5, Estilos.Custom, , , fuente)
                AlbaranEntrada.Detalle.Titulo(FnLeft(Genero, 25), Col(2), Altura, 65, 5, Estilos.Custom, , , fuente)
                AlbaranEntrada.Detalle.Titulo(Protocolo, Col(3), Altura, 39, 5, Estilos.Custom, , , fuente)
                AlbaranEntrada.Detalle.Titulo(Controlado, Col(4), Altura, 7, 5, Estilos.Custom, "=", , fuente)
                AlbaranEntrada.Detalle.Titulo(Finca, Col(5), Altura, 19, 5, Estilos.Custom, , , fuente)
                AlbaranEntrada.Detalle.Titulo(bultos.ToString("#,###"), Col(6), Altura, 15, 5, Estilos.Custom, ">", , fuente)
                AlbaranEntrada.Detalle.Titulo(kg.ToString("#,##0"), Col(7), Altura, 20, 5, Estilos.Custom, ">", , fuente)

                Altura = Altura + 5


                cont = cont + 1


                Application.DoEvents()

            Next


            For indice As Integer = 0 To 6 - dt.Rows.Count - 1
                Altura = Altura + 5
            Next


            AlbaranEntrada.Detalle.Titulo("------", Col(6), Altura, 20, 5, Estilos.Custom, , , fuente)
            AlbaranEntrada.Detalle.Titulo("--------", Col(7), Altura, 20, 5, Estilos.Custom, , , fuente)
            Altura = Altura + 5
            AlbaranEntrada.Detalle.Titulo("SUMAS TOTALES.....", margen_izquierdo, Altura, 68, 5, Estilos.Custom, , , fuente)
            AlbaranEntrada.Detalle.Titulo(TotalBultos.ToString("#,##0"), Col(6) - 5, Altura, 20, 5, Estilos.Custom, ">", , fuente)
            AlbaranEntrada.Detalle.Titulo(TotalKg.ToString("#,##0"), Col(7), Altura, 20, 5, Estilos.Custom, ">", , fuente)
            Altura = Altura + 8
            AlbaranEntrada.Detalle.Titulo("TRANSPORTISTA:", margen_izquierdo, Altura, 68, 5, Estilos.Custom, , , fuente)
            AlbaranEntrada.Detalle.Titulo(Transportista, margen_izquierdo + 40, Altura, 100, 5, Estilos.Custom, , , fuente)
            Altura = Altura + 5
            AlbaranEntrada.Detalle.Titulo("PORTES.......:", margen_izquierdo, Altura, 68, 5, Estilos.Custom, , , fuente)
            Altura = Altura + 5
            'AlbaranEntrada.Detalle.Titulo(Controlado, margen_izquierdo, Altura, 68, 5, Estilos.Custom, , , fuente)
            'Altura = Altura + 5


        Else
            XtraMessageBox.Show("Imposible leer albaran con Id " & IdAlbaran, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub


    Private Sub ImprimeCabeceraAlbaranEntrada(ByRef AlbaranEntrada As Impreso, DatosEmpresa As DatosEmpresa, ByRef altura As Integer, Col As List(Of Integer),
                                              Albaran As String, Fecha As String, Codigo As String, Agricultor As String,
                                              Empresa As String, CodBar As String)

        'Logo
        Dim fichero_logo As String = "logo.png"

        Select Case MiMaletin.IdEmpresaCTB
            Case 1
                fichero_logo = "logo.png"
            Case Else
                fichero_logo = "logo_" & MiMaletin.IdEmpresaCTB.ToString & ".png"
        End Select


        If IO.File.Exists(Application.StartupPath & "\" & fichero_logo) Then
            Try
                Dim logo As Image = Image.FromFile(Application.StartupPath & "\" & fichero_logo)
                Dim w As Integer = Math.Round(logo.Width * 0.2646)
                Dim h As Integer = Math.Round(logo.Height * 0.2646)
                AlbaranEntrada.Cabecera.Imagen(logo, margen_izquierdo, 3, w, h)
            Catch ex As Exception
            End Try
        End If


        AlbaranEntrada.Cabecera.Titulo(DatosEmpresa.NombreEmpresa, 100, 3, 90, 5, Estilos.NormalBold)
        AlbaranEntrada.Cabecera.Titulo(DatosEmpresa.FilaDatos(), 100, 8, 90, 98, Estilos.MinimaBold)



        'Código de barras
        Dim Code39 As New Font("C39HrP24DhTt", 42)
        AlbaranEntrada.Detalle.Titulo(CodBar, 35, 25, 165, 18, Estilos.Custom, ">", , Code39)




        AlbaranEntrada.Detalle.Titulo("** ALBARAN DE ENTRADA **", margen_izquierdo, altura, 200, 5, Estilos.Custom, "=", , fuente)
        altura = altura + 8
        AlbaranEntrada.Detalle.Titulo("NUM. ALBARAN.: ", margen_izquierdo, altura, 35, 5, Estilos.Custom, , , fuente)
        AlbaranEntrada.Detalle.Titulo(Albaran, margen_izquierdo + 35 + 2, altura, 50, 5, Estilos.Custom, , , fuente)
        AlbaranEntrada.Detalle.Titulo("FECHA:", margen_izquierdo + 155, altura, 15, 5, Estilos.Custom, , , fuente)
        AlbaranEntrada.Detalle.Titulo(Fecha, margen_izquierdo + 155 + 15 + 2, altura, 30, 5, Estilos.Custom, , , fuente)
        altura = altura + 5

        If Empresa.Trim <> "" Then AlbaranEntrada.Detalle.Titulo(Empresa & " entrega por", margen_izquierdo, altura, 95, 5, Estilos.Custom, , , fuente)
        AlbaranEntrada.Detalle.Titulo("HORA.:", margen_izquierdo + 155, altura, 15, 5, Estilos.Custom, , , fuente)
        AlbaranEntrada.Detalle.Titulo(Now.ToString("HH:mm"), margen_izquierdo + 155 + 15 + 2, altura, 30, 5, Estilos.Custom, , , fuente)
        altura = altura + 4
        If Empresa.Trim <> "" Then AlbaranEntrada.Detalle.Titulo("cuenta de...", margen_izquierdo, altura, 95, 5, Estilos.Custom, , , fuente)
        altura = altura + 4
        AlbaranEntrada.Detalle.Titulo("NOMBRE...: " & Codigo & " " & Agricultor, margen_izquierdo, altura, 145, 5, Estilos.Custom, , , fuente)
        altura = altura + 8

        AlbaranEntrada.Detalle.Titulo("PARTIDA", Col(1), altura, 65, 5, Estilos.Custom, , , fuente)
        AlbaranEntrada.Detalle.Titulo("GENERO", Col(2), altura, 65, 5, Estilos.Custom, , , fuente)
        AlbaranEntrada.Detalle.Titulo("PROTOCOLO", Col(3), altura, 25, 5, Estilos.Custom, , , fuente)
        AlbaranEntrada.Detalle.Titulo("CON", Col(4), altura, 10, 5, Estilos.Custom, , , fuente)
        AlbaranEntrada.Detalle.Titulo("CULTIVO", Col(5), altura, 20, 5, Estilos.Custom, , , fuente)
        AlbaranEntrada.Detalle.Titulo("BULTOS", Col(6), altura, 20, 5, Estilos.Custom, , , fuente)
        AlbaranEntrada.Detalle.Titulo("KG.NETOS", Col(7), altura, 20, 5, Estilos.Custom, , , fuente)
        altura = altura + 5

        AlbaranEntrada.Detalle.Titulo("--------", Col(1), altura, 20, 5, Estilos.Custom, , , fuente)
        AlbaranEntrada.Detalle.Titulo("-------------------------", Col(2), altura, 65, 5, Estilos.Custom, , , fuente)

        'AlbaranEntrada.Detalle.Titulo("-----------------", Col(3), altura, 45, 5, Estilos.Custom, , , fuente)
        AlbaranEntrada.Detalle.Titulo("-------------", Col(3), altura, 38, 5, Estilos.Custom, , , fuente)
        AlbaranEntrada.Detalle.Titulo("---", Col(4), altura, 7, 5, Estilos.Custom, , , fuente)

        AlbaranEntrada.Detalle.Titulo("-------", Col(5), altura, 20, 5, Estilos.Custom, , , fuente)
        AlbaranEntrada.Detalle.Titulo("------", Col(6), altura, 20, 5, Estilos.Custom, , , fuente)
        AlbaranEntrada.Detalle.Titulo("--------", Col(7), altura, 20, 5, Estilos.Custom, , , fuente)
        altura = altura + 5



    End Sub

End Module
