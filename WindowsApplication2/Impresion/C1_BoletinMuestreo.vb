Imports DevExpress.XtraEditors
Imports System.Drawing


Module C1_BoletinMuestreo

    Public Sub C1_ImprimirBoletinMuestreo(ByVal Idlineaalbentrada As String, TipoImpresion As TipoImpresion, NumCopias As Integer,
                                          Optional Impresora As String = "",
                                          Optional rutaPDF As String = "",
                                          Optional archivoPDF As String = "")

        If VaInt(Idlineaalbentrada) > 0 Then



            Dim ConfiguracionesDiversas As New E_ConfiguracionesDiversas(Idusuario, cn)
            Dim papel = ConfiguracionesDiversas.xDameValor(E_ConfiguracionesDiversas.eClaves.FORMATO_PAPEL_ENTRADAS, MiMaletin.IdPuntoVenta)

            Dim Impreso As New Impreso

            If papel = "A5" Then
                Impreso.f.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A5
                Impreso.f.Documento.PageLayout.PageSettings.Landscape = True
            Else
                Impreso.f.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
                Impreso.f.Documento.PageLayout.PageSettings.Landscape = False
                NumCopias = 0
            End If


            Impreso.f.Documento.PageLayout.PageSettings.TopMargin = "0mm"
            Impreso.f.Documento.PageLayout.PageSettings.BottomMargin = "0mm"
            Impreso.f.Documento.PageLayout.PageSettings.LeftMargin = "0mm"
            Impreso.f.documento.PageLayout.PageSettings.RightMargin = "0mm"

            Impreso.EstableceImpreso(TipoImpresion)


            Try

                ImprimeBoletinMuestreo(Idlineaalbentrada, 32, Impreso)


                'Impresión / previsualización / exportación
                Dim valoresusuario As New E_valoresusuario(Idusuario, cn)
                If valoresusuario.LeerId(Idusuario) = True Then

                    If papel = "A5" Then
                        'Distribuir la impresión según la partida es controlada o no 
                        Dim AlbEntrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
                        If AlbEntrada_lineas.LeerId(Idlineaalbentrada) Then

                            Dim Controlada As String = (AlbEntrada_lineas.AEL_Controlado.Valor & "").Trim
                            If Controlada = "S" Then
                                Impresora = valoresusuario.VUS_ImpresoraPartidaControlada.Valor
                            Else
                                Impresora = valoresusuario.VUS_ImpresoraPartidaNoControlada.Valor
                            End If

                        End If
                    Else
                        'Imprime como hasta ahora
                        Impresora = valoresusuario.VUS_ImpresoraMuestreo.Valor
                    End If


                End If

                If Impresora.Trim = "" Then
                    Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF, NumCopias)
                Else
                    Impreso.Imprimir(TipoImpresion.ImpresoraSeleccionada, Impresora, rutaPDF, archivoPDF, NumCopias)
                End If


            Catch ex As Exception
            End Try


        End If

    End Sub


    Public Sub ImprimeBoletinMuestreo(ByVal IdLineaAlbEntrada As String, ByVal Altura As Integer, ByVal BoletinMuestreo As Impreso)

        Dim AlbEntrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)
        Dim AlbEntrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)
        Dim SubFamilias As New E_Subfamilias(Idusuario, cn)
        Dim Familias As New E_FamiliasGeneros(Idusuario, cn)
        Dim TextoError As String = ""


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_idlinea, "IdLinea")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_muestreo, "Muestreo")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "NombreGenero", AlbEntrada_lineas.AEL_idgenero)
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_idgenero, "IdGenero")
        CONSULTA.SelCampo(AlbEntrada.AEN_Albaran, "Albaran", AlbEntrada_lineas.AEL_idalbaran, AlbEntrada.AEN_IdAlbaran)
        CONSULTA.SelCampo(AlbEntrada.AEN_Campa, "Campa")
        CONSULTA.SelCampo(AlbEntrada.AEN_Fecha, "Fecha")
        CONSULTA.SelCampo(AlbEntrada.AEN_IdAgricultor, "IdAgricultor")
        CONSULTA.SelCampo(Agricultores.AGR_Nombre, "Agricultor", AlbEntrada.AEN_IdAgricultor, Agricultores.AGR_IdAgricultor)
        CONSULTA.SelCampo(Envases.ENV_Nombre, "Envase", AlbEntrada_lineas.AEL_idenvase, Envases.ENV_IdEnvase)
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_bultos, "Bultos")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_kilosnetos, "Kilos")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_palets, "Palets")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_observaciones, "Observaciones")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_idcultivo, "IdCultivo")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_campacultivo, "CampaCultivo")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_Controlado, "Controlado")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_campacultivo, "CampaCultivo")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_Calidad, "Calidad")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_idprograma, "IdProgramaCalidad")
        CONSULTA.WheCampo(AlbEntrada_lineas.AEL_idlinea, "=", IdLineaAlbEntrada)

        Dim sql As String = CONSULTA.SQL
        Dim dt As DataTable = AlbEntrada_lineas.MiConexion.ConsultaSQL(sql)


        If dt.Rows.Count > 0 Then


            Dim BaseAltura As Integer = Altura

            Dim fuente As New Font("Courier New", 12)
            Dim fuente_bold As New Font("Courier New", 12, FontStyle.Bold)


            Dim Partida = VaInt(dt.Rows(0)("muestreo")).ToString("00000000")
            Dim Albaran As String = VaInt(dt.Rows(0)("Albaran")).ToString("000000")
            Dim Fecha As String = VaDate(dt.Rows(0)("Fecha")).ToString("dd-MM-yyyy")
            Dim Campa As String = VaInt(dt.Rows(0)("Campa")).ToString("00")
            Dim CampaCultivo As String = VaInt(dt.Rows(0)("CampaCultivo")).ToString("00")
            Dim IdCultivo As String = VaInt(dt.Rows(0)("IdCultivo")).ToString("00000")
            Dim Tecnico As String = NombreTecnicoCultivo(Campa, IdCultivo)
            Dim Producto As String = dt.Rows(0)("NombreGenero").ToString
            Dim Bultos As String = VaInt(dt.Rows(0)("Bultos")).ToString("#,###")
            Dim Variedad As String = NombreVariedadCultivo(Campa, IdCultivo)
            Dim Kilos As String = VaDec(dt.Rows(0)("Kilos")).ToString("#,##0")
            Dim Palets As String = VaDec(dt.Rows(0)("Palets")).ToString("#,##0")
            Dim IdGenero As String = dt.Rows(0)("IdGenero").ToString & ""
            Dim Observaciones As String = dt.Rows(0)("Observaciones").ToString & ""
            Dim bControlado As Boolean = (dt.Rows(0)("Controlado").ToString & "").ToUpper.Trim = "S"
            Dim IdAgricultor As String = (dt.Rows(0)("IdAgricultor").ToString & "").Trim
            Dim Calidad As String = (dt.Rows(0)("Calidad").ToString & "").Trim
            Dim IdProgramaCalidad As String = (dt.Rows(0)("IdProgramaCalidad").ToString & "").Trim
            'Dim GGN As String = GGNCultivo(Campa, IdCultivo)




            Dim margen_izquierdo As Integer = 4

            'Cabecera
            BoletinMuestreo.Detalle.Titulo("* BOLETIN DE MUESTREO *", 0, BaseAltura, 210, 5, Estilos.GrandeBold, "=")
            BaseAltura = BaseAltura + 10

            BoletinMuestreo.Detalle.Titulo("PARTIDA: ", margen_izquierdo + 2, BaseAltura, 20, 6, Estilos.Grande)
            BoletinMuestreo.Detalle.Titulo(Partida, margen_izquierdo + 25, BaseAltura - 1, 30, 6, Estilos.Cabecera)
            BoletinMuestreo.Detalle.Titulo("ALBARAN: ", margen_izquierdo + 25 + 35, BaseAltura, 20, 6, Estilos.Grande)
            BoletinMuestreo.Detalle.Titulo(Albaran, margen_izquierdo + 25 + 35 + 25, BaseAltura - 1, 25, 6, Estilos.Cabecera)
            BoletinMuestreo.Detalle.Titulo("FECHA: ", margen_izquierdo + 140, BaseAltura, 15, 6, Estilos.Grande)
            BoletinMuestreo.Detalle.Titulo(Fecha, margen_izquierdo + 140 + 15, BaseAltura - 1, 45, 6, Estilos.Cabecera)
            BaseAltura = BaseAltura + 6
            BoletinMuestreo.Detalle.Titulo("CULTIVO: ", margen_izquierdo + 2, BaseAltura, 20, 6, Estilos.Grande)
            BoletinMuestreo.Detalle.Titulo(Campa & IdCultivo, margen_izquierdo + 25, BaseAltura - 1, 105, 6, Estilos.Cabecera)
            BaseAltura = BaseAltura + 6
            BoletinMuestreo.Detalle.Titulo("TECNICO: ", margen_izquierdo + 2, BaseAltura, 20, 6, Estilos.Grande)
            BoletinMuestreo.Detalle.Titulo(Tecnico, margen_izquierdo + 25, BaseAltura, 105, 6, Estilos.Cabecera)
            BoletinMuestreo.Detalle.Titulo("HORA: ", margen_izquierdo + 140, BaseAltura, 15, 6, Estilos.Grande)
            BoletinMuestreo.Detalle.Titulo(Now.ToString("HH:mm"), margen_izquierdo + 140 + 15, BaseAltura - 1, 35, 6, Estilos.Cabecera)
            BaseAltura = BaseAltura + 10
            BoletinMuestreo.Detalle.Titulo(Producto, margen_izquierdo + 2, BaseAltura - 1, 74, 6, Estilos.Cabecera)
            BoletinMuestreo.Detalle.Titulo(Bultos, margen_izquierdo + 81, BaseAltura - 1, 20, 6, Estilos.Cabecera, ">")
            BoletinMuestreo.Detalle.Titulo("Bultos", margen_izquierdo + 107, BaseAltura, 20, 6, Estilos.Grande)
            BaseAltura = BaseAltura + 6
            BoletinMuestreo.Detalle.Titulo(Variedad, margen_izquierdo + 2, BaseAltura - 1, 74, 6, Estilos.Cabecera)
            BoletinMuestreo.Detalle.Titulo(Kilos, margen_izquierdo + 81, BaseAltura - 1, 20, 6, Estilos.Cabecera, ">")
            BoletinMuestreo.Detalle.Titulo("Kilos", margen_izquierdo + 107, BaseAltura, 20, 6, Estilos.Grande)
            
            BoletinMuestreo.Detalle.Titulo(Palets, margen_izquierdo + 140, BaseAltura - 1, 20, 6, Estilos.Cabecera, ">")
            If VaInt(Palets) > 1 Then
                BoletinMuestreo.Detalle.Titulo("Palets", margen_izquierdo + 140 + 25, BaseAltura, 20, 6, Estilos.Grande)
            Else
                BoletinMuestreo.Detalle.Titulo("Palet", margen_izquierdo + 140 + 25, BaseAltura, 20, 6, Estilos.Grande)
            End If
            BaseAltura = BaseAltura + 10

            'Código de barras
            Dim Code39 As New Font("C39HrP24DhTt", 45)
            Dim CodBar As String = "*" & "PA" & Campa & "." & VaInt(dt.Rows(0)("muestreo")).ToString & "*" ' formatear a 11 caracteres. 1 pppppp bb 00
            BoletinMuestreo.Detalle.Titulo(CodBar, 0, 12, 180, 20, Estilos.Custom, ">", , Code39)



            Dim max_lineas_por_columna As Integer = 8


            'Categorias
            If Generos.LeerId(IdGenero) Then
                If SubFamilias.LeerId(Generos.GEN_IdsubFamilia.Valor) Then
                    If Familias.LeerId(SubFamilias.SFA_idfamilia.Valor) Then

                        Dim IdFamilia As String = SubFamilias.SFA_idfamilia.Valor & ""

                        sql = "SELECT CAE_CategoriaCalibre as Categoria FROM familiascategorias" & vbCrLf
                        sql = sql & " LEFT JOIN categoriasentrada ON CAE_Id = FAC_IdCategoriaEntrada" & vbCrLf
                        sql = sql & " WHERE COALESCE(cae_id, 0) > 0" & vbCrLf
                        sql = sql & " AND FAC_IdFamilia = " & IdFamilia & vbCrLf
                        sql = sql & " ORDER by CAE_CategoriaCalibre" & vbCrLf

                        Dim dtFamilias As DataTable = Familias.MiConexion.ConsultaSQL(sql)
                        If Not IsNothing(dtFamilias) Then

                            Dim cont As Integer = 0
                            Dim linea As Integer = 0

                            For Each row As DataRow In dtFamilias.Rows

                                cont = cont + 1


                                Dim xCol As Integer = 0
                                If cont > 8 And cont <= 16 Then
                                    xCol = 70
                                ElseIf cont > 16 Then
                                    xCol = 140
                                End If



                                Dim categoria As String = row("Categoria").ToString & ""
                                Dim puntos As String = "........................"
                                BoletinMuestreo.Detalle.Titulo(categoria, margen_izquierdo + xCol, BaseAltura + (linea * 5), 35, 4, Estilos.Normal)
                                BoletinMuestreo.Detalle.Titulo(puntos, margen_izquierdo + xCol + 40, BaseAltura + (linea * 5), 15, 4, Estilos.Normal)

                                linea = linea + 1
                                If linea = max_lineas_por_columna Then linea = 0


                                Application.DoEvents()

                            Next

                        End If


                    End If
                End If

            End If

            'BaseAltura = BaseAltura + 45
            Altura = BaseAltura + 45


            'Observaciones
            BoletinMuestreo.Detalle.Titulo("OBSERVACIONES:", margen_izquierdo, Altura, 39, 4, Estilos.Normal)
            BoletinMuestreo.Detalle.Titulo(Observaciones, margen_izquierdo + 40, Altura, 85, 4, Estilos.Normal)


            If bControlado Then
                BoletinMuestreo.Detalle.Titulo("CONTROLADO", margen_izquierdo, Altura, 200, 7, Estilos.Cabecera, ">")
            Else
                BoletinMuestreo.Detalle.Titulo("NO CONTROLADO", margen_izquierdo, Altura, 200, 7, Estilos.Cabecera, ">")
            End If
            BoletinMuestreo.Detalle.Titulo("CALIDAD " & Calidad, margen_izquierdo, Altura + 6, 200, 7, Estilos.Cabecera, ">")


            Altura = Altura + 4


            Dim l1 As String = ""
            Dim l2 As String = ""
            'GGnBoletin(CampaCultivo, VaInt(IdAgricultor), VaInt(IdCultivo), l1, l2)
            GGNBoletinPrograma(VaInt(IdAgricultor), IdProgramaCalidad, l1, l2)

            Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
            Dim texto As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.TEXTO_TEMPERATURA_BOLETIN_MUESTREO)
            l1 = l1 & " - " & texto


            BoletinMuestreo.Detalle.Titulo(l1, margen_izquierdo, Altura, 200, 4, Estilos.Normal)
            Altura = Altura + 4
            BoletinMuestreo.Detalle.Titulo(l2 & " COD. AGR.: " & IdAgricultor, margen_izquierdo, Altura, 200, 4, Estilos.Normal)


        Else
            TextoError = "Imposible leer la partida con Id " & IdLineaAlbEntrada
        End If



        If TextoError.Trim <> "" Then
            XtraMessageBox.Show(TextoError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

End Module
