Imports System.Drawing
Imports DevExpress.XtraEditors


Module TicketsPartida

    Public Sub ImprimirTicketsPartida(ByVal IdLineaAlbEntrada As String, ByVal bPreliminar As Boolean, ByVal bMensaje As Boolean)


        If VaInt(IdLineaAlbEntrada) > 0 Then


            Dim Informe As New miInforme(False)
            Informe.Contenedor.PaperKind = Printing.PaperKind.A4
            Informe.Contenedor.PrintingSystem.ShowMarginsWarning = False

            Informe.Contenedor.MinMargins.Top = 0
            Informe.Contenedor.MinMargins.Left = 0
            Informe.Contenedor.MinMargins.Right = 0
            Informe.Contenedor.MinMargins.Bottom = 0

            Informe.Contenedor.Margins.Top = 0
            Informe.Contenedor.Margins.Left = 0
            Informe.Contenedor.Margins.Right = 0
            Informe.Contenedor.Margins.Bottom = 0

            Dim Ticket As New miFactura()
            ImprimeTicketPartida(IdLineaAlbEntrada, 30, False, Ticket)
            ImprimeTicketPartida(IdLineaAlbEntrada, 176, True, Ticket)
            Informe.AñadeDetalles(Ticket)


            If bPreliminar Then
                Informe.Preliminar(DevExpress.LookAndFeel.UserLookAndFeel.Default)
            Else
                Informe.ImpresionDirecta()
            End If


            Informe.Dispose()


        Else
            If bMensaje Then XtraMessageBox.Show("No hay datos que imprimir", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub


    Public Sub ImprimeTicketPartida(ByVal IdLineaAlbEntrada As String, ByVal Altura As Integer, ByVal bCopia As Boolean, ByVal TicketPartida As miFactura)

        Dim AlbEntrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)
        Dim AlbEntrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
        Dim TextoError As String = ""



        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_idlinea, "IdLinea")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_muestreo, "Muestreo")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_idprograma, "IdPrograma")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_idgenero, "idgenero")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "NombreGenero", AlbEntrada_lineas.AEL_idgenero)
        CONSULTA.SelCampo(Categorias.CAE_CategoriaCalibre, "CategoriaCalibre", AlbEntrada_lineas.AEL_idcategoria, Categorias.CAE_Id)
        CONSULTA.SelCampo(AlbEntrada.AEN_Albaran, "Albaran", AlbEntrada_lineas.AEL_idalbaran, AlbEntrada.AEN_IdAlbaran)
        CONSULTA.SelCampo(AlbEntrada.AEN_Campa, "Campa")
        CONSULTA.SelCampo(AlbEntrada.AEN_Fecha, "Fecha")
        CONSULTA.SelCampo(AlbEntrada.AEN_IdCentro, "Centro")
        CONSULTA.SelCampo(AlbEntrada.AEN_idbascula, "Bascula")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_bultos, "Bultos")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_kilosnetos, "Kilos")
        CONSULTA.WheCampo(AlbEntrada_lineas.AEL_idlinea, "=", IdLineaAlbEntrada)

        Dim sql As String = CONSULTA.SQL
        Dim dt As DataTable = AlbEntrada_lineas.MiConexion.ConsultaSQL(sql)


        If dt.Rows.Count > 0 Then


            Dim BaseAltura As Integer = Altura

            Dim fuente As New Font("Courier New", 16)
            Dim fuente2 As New Font("Courier New", 24)

            Dim certif As String = dt.Rows(0)("Programa").ToString
            Dim fecha As String = Left(dt.Rows(0)("Fecha").ToString, 10)
            Dim albaran As String = dt.Rows(0)("Centro").ToString + "-" + dt.Rows(0)("Albaran").ToString
            Dim producto As String = dt.Rows(0)("idgenero").ToString & "  " & dt.Rows(0)("NombreGenero").ToString & " / " & dt.Rows(0)("CategoriaCalibre").ToString
            Dim bultos As String = VaInt(dt.Rows(0)("Bultos")).ToString("#,###")
            Dim kilos As String = VaDec(dt.Rows(0)("Kilos")).ToString("#,##0.00")
            Dim origen As String = ""
            Dim Bascula As String = dt.Rows(0)("Bascula").ToString
            Dim Idpartida As String = dt.Rows(0)("muestreo").ToString
            Dim IdBarras = dt.Rows(0)("muestreo").ToString


            If Not bCopia Then
                TicketPartida.Titulo("@@", 6, BaseAltura, 37, 5, milinea.stilos.Reducida)
                BaseAltura = BaseAltura + 5
            Else
                TicketPartida.Titulo("@@", 6, BaseAltura, 37, 7, milinea.stilos.Reducida)
                BaseAltura = BaseAltura + 5
            End If
            TicketPartida.Titulo("Partida", 6, BaseAltura, 37, 7, milinea.stilos.Custom, , fuente)
            TicketPartida.Titulo(":" & Idpartida, 44, BaseAltura, 70, 7, milinea.stilos.Custom, , fuente)
            TicketPartida.Titulo(certif, 117, BaseAltura, 74, 7, milinea.stilos.Custom, , fuente)
            BaseAltura = BaseAltura + 7
            TicketPartida.Titulo("Fecha", 6, BaseAltura, 37, 7, milinea.stilos.Custom, , fuente)
            TicketPartida.Titulo(":" & fecha, 44, BaseAltura, 70, 7, milinea.stilos.Custom, , fuente)
            TicketPartida.Titulo("Albaran", 117, BaseAltura, 34, 7, milinea.stilos.Custom, , fuente)
            TicketPartida.Titulo(":" & albaran, 150, BaseAltura, 39, 7, milinea.stilos.Custom, , fuente)
            BaseAltura = BaseAltura + 7
            TicketPartida.Titulo("Producto", 6, BaseAltura, 37, 7, milinea.stilos.Custom, , fuente)
            TicketPartida.Titulo(":" & producto, 44, BaseAltura, 145, 7, milinea.stilos.Custom, , fuente)

            BaseAltura = BaseAltura + 7
            TicketPartida.Titulo("Bultos", 6, BaseAltura, 37, 7, milinea.stilos.Custom, , fuente)
            TicketPartida.Titulo(":", 44, BaseAltura, 4, 7, milinea.stilos.Custom, , fuente)
            TicketPartida.Titulo(bultos, 49, BaseAltura, 30, 7, milinea.stilos.Custom, ">", fuente)
            BaseAltura = BaseAltura + 7
            TicketPartida.Titulo("Kilos", 6, BaseAltura, 37, 7, milinea.stilos.Custom, , fuente)
            TicketPartida.Titulo(":", 44, BaseAltura, 4, 7, milinea.stilos.Custom, , fuente)
            TicketPartida.Titulo(kilos, 49, BaseAltura, 30, 7, milinea.stilos.Custom, ">", fuente)
            BaseAltura = BaseAltura + 7
            TicketPartida.Titulo("Origen", 6, BaseAltura, 37, 7, milinea.stilos.Custom, , fuente)
            TicketPartida.Titulo(":" & origen, 44, BaseAltura, 145, 7, milinea.stilos.Custom, , fuente)

            BaseAltura = BaseAltura + 7
            TicketPartida.Titulo("Bascula", 6, BaseAltura, 37, 7, milinea.stilos.Custom, , fuente)
            TicketPartida.Titulo(":" & bascula, 44, BaseAltura, 145, 7, milinea.stilos.Custom, , fuente)

            'Código de barras
            Dim Code39 As New Font("C39HrP24DhTt", 34)
            Dim cod_barras As String = ""
            IdBarras = "1" + Fnc0(IdBarras, 11) ' formatear a 11 caracteres. 10 pppppp bb 00
            cod_barras = "*" & IdBarras & "*"
            TicketPartida.Titulo(cod_barras, 125, Altura + 55, 60, 18, milinea.stilos.Custom, , Code39)


        Else
            TextoError = "Imposible leer la partida con Id " & IdLineaAlbEntrada
        End If



        If TextoError.Trim <> "" Then
            XtraMessageBox.Show(TextoError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

End Module
