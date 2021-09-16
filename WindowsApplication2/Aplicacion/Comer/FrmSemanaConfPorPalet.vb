Public Class FrmSemanaConfPorPalet
    Inherits FrConsulta

    Dim Semanaspartes As New E_SemanasPartes(Idusuario, cn)
    Dim Semanas_gastoconf As New E_Semanas_gastoconf(Idusuario, cn)
    Dim _idsemana As Integer


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato_1, Semanaspartes.SEV_Semana, Lb1, True)

        AsociarControles(TxDato_1, BtBuscaAlbaran, Semanaspartes.btBusca, Semanaspartes)
        LbCampa.Text = MiMaletin.IdCentro.ToString

    End Sub


    Private Sub FrmSemanaConfPorPalet_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim Fuente_titulo As New Font("Verdana", 10, FontStyle.Bold)

        GridViewPresenta.Appearance.ViewCaption.ForeColor = Color.Blue
        GridViewPresenta.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(224, 224, 224)
        GridViewPresenta.Appearance.ViewCaption.Font = Fuente_titulo
        GridViewPresenta.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near


        GridViewPresenta.ViewCaption = "Presentaciones con sobrecoste de manipulación".ToUpper
        GridViewPresenta.OptionsView.ShowViewCaption = True

    End Sub


    Private Sub TxDato_1_Valida(edicion As Boolean) Handles TxDato_1.Valida

        Dim id As Integer = Semanaspartes.LeerSemana(MiMaletin.Ejercicio, VaInt(TxDato_1.Text))
        _idsemana = id
        If id > 0 Then
            If Semanaspartes.LeerId(id) = True Then
                LbDesdeFecha.Text = Semanaspartes.SEV_FechaInicialSalida.Valor
                LbHastaFecha.Text = Semanaspartes.SEV_FechaFinalSalida.Valor

            End If

        End If
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        GridEditable.DataSource = Nothing
        LbDesdeFecha.Text = ""
        LbHastaFecha.Text = ""
        LbCampa.Text = MiMaletin.Ejercicio.ToString
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaKilosSalidas()
        CargaGridSobreCoste()

    End Sub


    
    Private Sub CargaKilosSalidas()

        'Dim albsalida As New E_AlbSalida(Idusuario, cn)
        'Dim albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)

        'Dim consulta As New Cdatos.E_select
        'consulta.SelCampo(albsalida_lineas.ASL_idgenero, "idgenero")
        'consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", albsalida_lineas.ASL_idgenero)
        'Dim kilos As New Cdatos.bdcampo("@SUM(asl_Kilosnetos)", Cdatos.TiposCampo.Importe, 10)
        'consulta.SelCampo(kilos, "Kilos")
        'consulta.SelCampo(albsalida.ASA_ejercicio, "Campa", albsalida_lineas.ASL_idalbaran)
        'consulta.WheCampo(albsalida.ASA_fechasalida, ">=", LbDesdeFecha.Text)
        'consulta.WheCampo(albsalida.ASA_fechasalida, "<=", LbHastaFecha.Text)
        'Dim sql As String = consulta.SQL
        'sql = sql + "group by asl_idgenero,gen_nombregenero,asa_ejercicio"

        'Dim dt As DataTable = albsalida_lineas.MiConexion.ConsultaSQL(Sql)


        Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
        Dim Palets As New E_palets(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Palets_Lineas.PLL_idgenero, "IdGenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Palets_Lineas.PLL_idgenero, Generos.GEN_IdGenero)
        Dim kilos As New Cdatos.bdcampo("@SUM(PLL_kilosnetos)", Cdatos.TiposCampo.Importe, 10)
        consulta.SelCampo(kilos, "Kilos")
        consulta.SelCampo(Palets.PAL_campa, "Campa", Palets_Lineas.PLL_idpalet, Palets.PAL_idpalet)
        consulta.WheCampo(Palets.PAL_fecha, ">=", LbDesdeFecha.Text)
        consulta.WheCampo(Palets.PAL_fecha, "<=", LbHastaFecha.Text)

        Dim sql As String = consulta.SQL
        sql = sql + "group by pll_idgenero, gen_nombregenero, pal_campa"



        Dim dt As DataTable = Palets_Lineas.MiConexion.ConsultaSQL(sql)
        dt.Columns.Add("Gasto", GetType(System.Decimal))
        dt.Columns.Add("Importe", GetType(System.Decimal))

        If Not dt Is Nothing Then
            For Each rw In dt.Rows

                Dim Idgenero As Integer = VaInt(rw("idgenero"))
                Dim gasto As Decimal = Semanas_gastoconf.GastoGenero(_idsemana, Idgenero)
                If gasto = 0 Then
                    If Generos.LeerId(Idgenero.ToString) = True Then
                        gasto = VaDec(Generos.GEN_GastoConfeccion.Valor)
                    End If
                End If
                rw("Gasto") = gasto
                rw("Importe") = gasto * VaDec(rw("kilos"))


            Next
        End If


        GridEditable.DataSource = dt
        GridEditable.Campo("Gasto", Semanas_gastoconf.SGK_gasto, True, True, False, False)

        AjustaColumnas(GridEditable.GridView)

    End Sub


    Private Sub Guardar()

        For Each rw In GridEditable.GridView.DataSource
            Dim Idgenero As Integer = VaInt(rw("idgenero"))

            Dim id As Integer = Semanas_gastoconf.LeerGasto(_idsemana, Idgenero)
            If id > 0 Then
                If Semanas_gastoconf.LeerId(id.ToString) = True Then
                    Semanas_gastoconf.SGK_gasto.Valor = rw("Gasto").ToString
                    Semanas_gastoconf.Actualizar()
                End If
            Else
                id = Semanas_gastoconf.MaxId
                Semanas_gastoconf.VaciaEntidad()
                Semanas_gastoconf.SGK_id.Valor = id.ToString
                Semanas_gastoconf.SGK_idgenero.Valor = Idgenero.ToString
                Semanas_gastoconf.SGK_idsemana.Valor = _idsemana.ToString
                Semanas_gastoconf.SGK_gasto.Valor = rw("Gasto").ToString
                Semanas_gastoconf.Insertar()
            End If


        Next
        ActualizaSalidas()
        MsgBox("Registros guardados")
    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()
        If MsgBox("Desea actualizar", vbYesNo) = vbYes Then
            Guardar()
        End If
    End Sub

    Private Sub AjustaColumnas(g As DevExpress.XtraGrid.Views.Grid.GridView)


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In g.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CAMPA"
                    c.Visible = False

            End Select
        Next

        g.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In g.Columns
            Select Case c.FieldName.ToUpper.Trim


                Case "IDGENERO"
                    c.Width = 150

                Case "KILOS"
                    c.Width = 250
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n0}"

                Case "KILOS", "GASTO"
                    c.Width = 250
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n4}"

                Case "IMPORTE"
                    c.Width = 350
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n2}"


                Case "GENERO", "PRESENTACION"
                    c.Width = 500

            End Select
        Next


        Funciones.AñadeResumenCampo(g, "Kilos", "{0:n0}")
        Funciones.AñadeResumenCampo(g, "Importe", "{0:n2}")


    End Sub



    Private Sub ActualizaSalidas()

        'Dim albsalida As New E_AlbSalida(Idusuario, cn)
        'Dim albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
        'Dim generosSalida As New E_GenerosSalida(Idusuario, cn)


        'Dim consulta As New Cdatos.E_select
        'consulta.SelCampo(albsalida_lineas.ASL_idlinea, "idlinea")
        'consulta.SelCampo(albsalida_lineas.ASL_idgenero, "idgenero")
        'consulta.SelCampo(albsalida_lineas.ASL_kilosnetos, "kilos")
        'consulta.SelCampo(generosSalida.GES_GtoXKilo, "gtoxkilo", albsalida_lineas.ASL_idgensal)
        'consulta.SelCampo(albsalida.ASA_idalbaran, "Idalbaran", albsalida_lineas.ASL_idalbaran)
        'consulta.WheCampo(albsalida.ASA_fechasalida, ">=", LbDesdeFecha.Text)
        'consulta.WheCampo(albsalida.ASA_fechasalida, "<=", LbHastaFecha.Text)

        'Dim sql As String = consulta.SQL
        'Dim dt As DataTable = albsalida_lineas.MiConexion.ConsultaSQL(sql)
        'If Not dt Is Nothing Then
        '    For Each rw In dt.Rows

        '        Dim g As Decimal = GastoKilo(VaInt(rw("idgenero")))
        '        Dim k As Decimal = VaDec(rw("kilos"))
        '        g = g + VaDec(rw("gtoxkilo")) ' le sumo el sobrecoste de manipulacion de la presentacion

        '        If albsalida_lineas.LeerId(rw("idlinea").ToString) = True Then
        '            albsalida_lineas.ASL_manipulacion.Valor = (g * k).ToString
        '            albsalida_lineas.Actualizar()
        '        End If
        '    Next
        'End If




        Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
        Dim Palets As New E_palets(Idusuario, cn)
        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
        Dim AlbSalida_Lineas As New E_AlbSalida_lineas(Idusuario, cn)
        Dim AlbSalida_Palets As New E_albsalida_palets(Idusuario, cn)

        Dim DcAlbaranes As New Dictionary(Of String, String)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Palets.PAL_idpalet, "IdPalet")
        consulta.SelCampo(AlbSalida_Palets.ASP_IdAlbaran, "IdAlbaran", Palets.PAL_idpalet, AlbSalida_Palets.ASP_Idpalet)
        consulta.WheCampo(Palets.PAL_fecha, ">=", LbDesdeFecha.Text)
        consulta.WheCampo(Palets.PAL_fecha, "<=", LbHastaFecha.Text)

        Dim sql As String = "SELECT DISTINCT IdAlbaran" & vbCrLf
        sql = sql & " FROM " & vbCrLf
        sql = sql & " ( " & vbCrLf & consulta.SQL & " ) as A" & vbCrLf


        Dim dt As DataTable = Palets_Lineas.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows

                Dim IdAlbaran As String = (row("IdAlbaran").ToString & "").Trim
                If Not DcAlbaranes.ContainsKey(IdAlbaran) Then

                    AGRO_ActualizaGastosOrigenAlbaran(IdAlbaran, True, _idsemana)
                    DcAlbaranes(IdAlbaran) = IdAlbaran

                End If

            Next

        End If



    End Sub


    Private Function GastoKilo(idgenero As Integer) As Decimal
        Dim ret As Decimal
        Dim dt As DataTable = GridEditable.DataSource
        For Each rw In dt.Rows
            If VaInt(rw("idgenero")) = idgenero Then
                ret = VaDec(rw("gasto"))
                Exit For
            End If
        Next


        Return ret

    End Function


    Private Sub CargaGridSobreCoste()
        Dim albsalida As New E_AlbSalida(Idusuario, cn)
        Dim albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
        Dim generosSalida As New E_GenerosSalida(Idusuario, cn)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(albsalida_lineas.ASL_idgenero, "idgenero")
        consulta.SelCampo(generosSalida.GES_Nombre, "Presentacion", albsalida_lineas.ASL_idgensal)
        Dim kilos As New Cdatos.bdcampo("@SUM(asl_Kilosnetos)", Cdatos.TiposCampo.Importe, 10)
        consulta.SelCampo(kilos, "Kilos")
        consulta.SelCampo(generosSalida.GES_GtoXKilo, "Gasto")
        consulta.SelCampo(albsalida.ASA_ejercicio, "campa", albsalida_lineas.ASL_idalbaran)
        consulta.WheCampo(albsalida.ASA_fechasalida, ">=", LbDesdeFecha.Text)
        consulta.WheCampo(albsalida.ASA_fechasalida, "<=", LbHastaFecha.Text)
        consulta.WheCampo(generosSalida.GES_GtoXKilo, "<>", "0")
        Dim sql As String = consulta.SQL


        sql = sql + "group by asl_idgenero,ges_nombre,ges_gtoxkilo,asa_ejercicio"
        Dim dt As DataTable = albsalida_lineas.MiConexion.ConsultaSQL(sql)
        dt.Columns.Add("Importe", GetType(System.Decimal))

        If Not dt Is Nothing Then
            For Each rw In dt.Rows

                rw("Importe") = VaDec(rw("Gasto")) * VaDec(rw("kilos"))


            Next
        End If
        GridPresenta.DataSource = dt

        AjustaColumnas(GridViewPresenta)
    End Sub

    Private Sub GridEditable_Valida(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        Dim i As Decimal = 0
        i = VaDec(row("gasto")) * VaDec(row("kilos"))
        row("Importe") = i

    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()
        LineasDescripcion.Add("")
        LineasDescripcion.Add("GASTO CONFECCIÓN SEMANAL SEMANA " & TxDato_1.Text & " (" & LbDesdeFecha.Text & "-" & LbHastaFecha.Text & ")")


        Try

            Application.DoEvents()

            Dim dt1 As DataTable = CType(GridEditable.Grid.DataSource, DataTable)
            Dim dt2 As DataTable = CType(GridPresenta.DataSource, DataTable)

            If dt1.Rows.Count <= 0 And dt2.Rows.Count <= 0 Then
                MsgBox("No hay datos que imprimir")
                Exit Sub
            End If

            Application.DoEvents()

        Catch ex As Exception

        End Try


        Application.DoEvents()


        If GridEditable.Grid.IsPrintingAvailable And GridPresenta.IsPrintingAvailable Then

            Dim psu As New DevExpress.XtraPrinting.PrinterSettingsUsing
            psu.UsePaperKind = True
            psu.UseMargins = False

            prtSystem2.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            prtSystem2.PageSettings.AssignDefaultPrinterSettings(psu)


            Dim bErrorMargen As Boolean = True

            CType(prtSystem2.Links(0), DevExpress.XtraPrintingLinks.PrintableComponentLinkBase).Component = GridEditable.Grid
            Dim contenedor As DevExpress.XtraPrintingLinks.CompositeLink = CType(prtSystem2.Links(2), DevExpress.XtraPrintingLinks.CompositeLink)


            contenedor.Margins.Top = 50
            contenedor.Margins.Right = 50
            contenedor.Margins.Bottom = 50
            contenedor.Margins.Left = 50


            Application.DoEvents()

            contenedor.ShowPreview()

            Application.DoEvents()

        Else
            MsgBox("Error, una de las tablas no está disponible para imprimir")
        End If


    End Sub


    Private Sub CompositeLink_CreateInnerPageHeaderArea(sender As System.Object, e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles CompositeLink1.CreateDetailHeaderArea


        Dim margen_izq_parametros As Integer = 10
        Dim base_parametros As Integer = 10

        Dim rec As RectangleF
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Arial", 13, FontStyle.Bold)




        Dim s As New SizeF(0, 0)

        Try

            'Logo
            Try

                Dim fichero_logo As String = "logo.png"

                Select Case MiMaletin.IdEmpresaCTB
                    Case 1
                        fichero_logo = "logo.png"
                    Case Else
                        fichero_logo = "logo_" & MiMaletin.IdEmpresaCTB.ToString & ".png"
                End Select

                If IO.File.Exists(Application.StartupPath & "\" & fichero_logo) Then

                    Dim logo As Image = Image.FromFile(Application.StartupPath & "\" & fichero_logo)
                    rec = New RectangleF(0, 0, logo.Size.Width, logo.Size.Height)
                    e.Graph.DrawImage(logo, rec, DevExpress.XtraPrinting.BorderSide.None, Color.Transparent)
                    s = logo.Size

                    margen_izq_parametros = margen_izq_parametros + logo.Size.Width

                End If

            Catch ex As Exception

            End Try



            'Separación debajo del logo
            e.Graph.DrawEmptyBrick(New RectangleF(0, s.Height, e.Graph.ClientPageSize.Width, 10))

            'Línea debajo del logo
            Dim c As System.Drawing.Color = Color.FromArgb(1, 70, 127)

            Dim p1f As New PointF(0, s.Height + 5)
            Dim p2f As New PointF(e.Graph.ClientPageSize.Width, s.Height + 5)
            e.Graph.DrawLine(p1f, p2f, c, 1)

            Dim base As Single = p1f.Y + 10

            'Nombre del listado
            Dim nombrelistado As String = "LISTADO " & Grid.Text & " - " & Now.ToString("dd/MM/yyyy")
            If Me.Text.Trim <> "" Then nombrelistado = Me.Text & " - " & Now.ToString("dd/MM/yyyy")

            'Espacio en blanco debajo del nombre del listado
            rec = New RectangleF(0, base, e.Graph.ClientPageSize.Width, 25)
            e.Graph.DrawString(nombrelistado, c, rec, DevExpress.XtraPrinting.BorderSide.None)

            base = base + 25


            If LineasDescripcion.Count > 0 Then

                e.Graph.Font = New Font("Arial", 9, FontStyle.Regular)


                Dim bp As Integer = base_parametros
                Dim alineacion As DevExpress.Utils.HorzAlignment = DevExpress.Utils.HorzAlignment.Near
                Dim ancho As Integer = e.Graph.ClientPageSize.Width - margen_izq_parametros - 5

                For indice As Integer = 0 To LineasDescripcion.Count - 1

                    If indice <= 12 Then

                        If indice = 6 Then
                            '2ª columna
                            ancho = ancho / 2
                            margen_izq_parametros = margen_izq_parametros + ancho
                            bp = base_parametros
                            alineacion = DevExpress.Utils.HorzAlignment.Far

                        End If

                        Dim linea As String = LineasDescripcion(indice)

                        rec = New RectangleF(margen_izq_parametros, bp, ancho, 20)
                        Dim tb As DevExpress.XtraPrinting.TextBrick = e.Graph.DrawString(linea, c, rec, DevExpress.XtraPrinting.BorderSide.None)
                        tb.HorzAlignment = alineacion
                        bp = bp + 15

                    End If


                Next



            End If


            'Último separador en blanco
            e.Graph.DrawEmptyBrick(New RectangleF(0, base, e.Graph.ClientPageSize.Width, 15))



        Catch ex As Exception


        End Try


    End Sub


    
End Class