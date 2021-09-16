Public Class FrmProduccion

    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro


    Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Produccion As New E_Produccion(Idusuario, cn)
    Dim Lineas As New E_Lineas(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)

    Dim BloqueoLineaFecha As New E_BloqueoLineaFecha(Idusuario, cn)




    Dim LstTab As New List(Of TabPage)
    Dim LstCb As New List(Of CbBox)
    Dim LstGrid As New List(Of DevExpress.XtraGrid.GridControl)
    Dim lstGridView As New List(Of DevExpress.XtraGrid.Views.Grid.GridView)
    Dim LstNuevo As New List(Of ClButton)
    Dim lstFinalizar As New List(Of ClButton)
    Dim lstPrecalibrado As New List(Of ClButton)
    Dim lstDestrio As New List(Of ClButton)
    Dim lstMuestreo As New List(Of ClButton)


    Dim lstLineas As New List(Of String)



    Dim _bPrimero As Boolean = True




    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub



    Private Sub ParametrosFrm()

        Dim cl As New Cdatos.PropiedadesTx
        cl.CampoBd = Produccion.PRD_Fecha
        cl.Tipo = Cdatos.TiposCampo.Fecha
        cl.Longitud = Produccion.PRD_Fecha.Longitud
        cl.Obligatorio = True


        TxFecha.Orden = 0
        TxFecha.ClParam = cl

        TxFecha.ClForm = Me
        LbFecha.CL_ControlAsociado = TxFecha
        LbFecha.CL_ValorFijo = True



        'Tabs


    End Sub


    Private Sub FrmProduccion_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        TabControl1.Enabled = False

        LbPventa.Text = MiMaletin.IdPuntoVenta.ToString
        PuntoVenta.LeerId(LbPventa.Text)
        LbNomPventa.Text = PuntoVenta.Nombre.Valor


        TxFecha.Text = Today.ToString("dd/MM/yyyy")
        TxFecha.Validar(True)


        LstTab.Add(TabControl1.TabPages(0))
        LstTab.Add(TabControl1.TabPages(1))
        LstTab.Add(TabControl1.TabPages(2))
        LstTab.Add(TabControl1.TabPages(3))
        LstTab.Add(TabControl1.TabPages(4))
        LstTab.Add(TabControl1.TabPages(5))
        LstTab.Add(TabControl1.TabPages(6))
        LstTab.Add(TabControl1.TabPages(7))
        LstTab.Add(TabControl1.TabPages(8))
        LstTab.Add(TabControl1.TabPages(9))
        For Each t As TabPage In LstTab
            t.Text = ""
        Next


        lstLineas.Add(0)
        lstLineas.Add(0)
        lstLineas.Add(0)
        lstLineas.Add(0)
        lstLineas.Add(0)
        lstLineas.Add(0)
        lstLineas.Add(0)
        lstLineas.Add(0)
        lstLineas.Add(0)
        lstLineas.Add(0)


        LstCb.Add(CbLinea1)
        LstCb.Add(CbLinea2)
        LstCb.Add(CbLinea3)
        LstCb.Add(CbLinea4)
        LstCb.Add(CbLinea5)
        LstCb.Add(CbLinea6)
        LstCb.Add(CbLinea7)
        LstCb.Add(CbLinea8)
        LstCb.Add(CbLinea9)
        LstCb.Add(CbLinea10)

        For Each Cb As CbBox In LstCb
            Cb.DeshabilitarRuedaRaton = True
        Next


        LstGrid.Add(Grid1)
        LstGrid.Add(Grid2)
        LstGrid.Add(Grid3)
        LstGrid.Add(Grid4)
        LstGrid.Add(Grid5)
        LstGrid.Add(Grid6)
        LstGrid.Add(Grid7)
        LstGrid.Add(Grid8)
        LstGrid.Add(Grid9)
        LstGrid.Add(Grid10)

        lstGridView.Add(GridView1)
        lstGridView.Add(GridView2)
        lstGridView.Add(GridView3)
        lstGridView.Add(GridView4)
        lstGridView.Add(GridView5)
        lstGridView.Add(GridView6)
        lstGridView.Add(GridView7)
        lstGridView.Add(GridView8)
        lstGridView.Add(GridView9)
        lstGridView.Add(GridView10)

        LstNuevo.Add(btNuevo1)
        LstNuevo.Add(btNuevo2)
        LstNuevo.Add(btNuevo3)
        LstNuevo.Add(btNuevo4)
        LstNuevo.Add(btNuevo5)
        LstNuevo.Add(btNuevo6)
        LstNuevo.Add(btNuevo7)
        LstNuevo.Add(btNuevo8)
        LstNuevo.Add(btNuevo9)
        LstNuevo.Add(btNuevo10)

        lstFinalizar.Add(btFinalizar1)
        lstFinalizar.Add(btFinalizar2)
        lstFinalizar.Add(btFinalizar3)
        lstFinalizar.Add(btFinalizar4)
        lstFinalizar.Add(btFinalizar5)
        lstFinalizar.Add(btFinalizar6)
        lstFinalizar.Add(btFinalizar7)
        lstFinalizar.Add(btFinalizar8)
        lstFinalizar.Add(btFinalizar9)
        lstFinalizar.Add(btFinalizar10)

        lstPrecalibrado.Add(btNuevoPrecalibrado1)
        lstPrecalibrado.Add(btNuevoPrecalibrado2)
        lstPrecalibrado.Add(btNuevoPrecalibrado3)
        lstPrecalibrado.Add(btNuevoPrecalibrado4)
        lstPrecalibrado.Add(btNuevoPrecalibrado5)
        lstPrecalibrado.Add(btNuevoPrecalibrado6)
        lstPrecalibrado.Add(btNuevoPrecalibrado7)
        lstPrecalibrado.Add(btNuevoPrecalibrado8)
        lstPrecalibrado.Add(btNuevoPrecalibrado9)
        lstPrecalibrado.Add(btNuevoPrecalibrado10)

        lstDestrio.Add(btDestrio1)
        lstDestrio.Add(btDestrio2)
        lstDestrio.Add(btDestrio3)
        lstDestrio.Add(btDestrio4)
        lstDestrio.Add(btDestrio5)
        lstDestrio.Add(btDestrio6)
        lstDestrio.Add(btDestrio7)
        lstDestrio.Add(btDestrio8)
        lstDestrio.Add(btDestrio9)
        lstDestrio.Add(btDestrio10)

        lstMuestreo.Add(btMuestreo1)
        lstMuestreo.Add(btMuestreo2)
        lstMuestreo.Add(btMuestreo3)
        lstMuestreo.Add(btMuestreo4)
        lstMuestreo.Add(btMuestreo5)
        lstMuestreo.Add(btMuestreo6)
        lstMuestreo.Add(btMuestreo7)
        lstMuestreo.Add(btMuestreo8)
        lstMuestreo.Add(btMuestreo9)
        lstMuestreo.Add(btMuestreo10)


        'Carga líneas
        Dim sql = "Select LIN_IdLinea as Id, LIN_nombre as Nombre from Lineas order by LIN_Nombre"
        Dim dtLineas = Lineas.MiConexion.ConsultaSQL(sql)

        For Each cb As CbBox In LstCb
            cb.DataSource = dtLineas.Copy
            cb.DisplayMember = "Nombre"
            cb.ValueMember = "Id"

            cb.SelectedIndex = -1

        Next

        _bPrimero = False



        'Deshabilita botones de nuevo y finalizar hasta que cargue una linea
        For Each nuevo As ClButton In LstNuevo
            nuevo.Enabled = False
        Next
        For Each fin As ClButton In lstFinalizar
            fin.Enabled = False
        Next
        For Each pre As ClButton In lstPrecalibrado
            pre.Enabled = False
        Next
        For Each destrio As ClButton In lstDestrio
            destrio.Enabled = False
        Next
        For Each muestreo As ClButton In lstMuestreo
            muestreo.Enabled = False
        Next


    End Sub


    Private Sub FrmProduccion_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'Comprueba si tiene alguna línea abierta antes de salir
        Dim lstLineasAbiertas As List(Of Integer) = CompruebaLineasAbiertas()
        If lstLineasAbiertas.Count > 0 Then

            Dim texto As String = "Tiene una o más líneas abiertas. Tiene que parar la producción antes de salir."
            texto = texto & vbCrLf & vbCrLf

            For Each pagina As Integer In lstLineasAbiertas
                texto = texto & vbTab & " - " & LstTab(pagina).Text & vbCrLf
            Next

            MsgBox(texto)

            e.Cancel = True
            Exit Sub
        Else
            'Desbloquea las líneas en uso
            For Each IdLinea As String In lstLineas
                DesBloquearLineas(IdLinea)
            Next

        End If

    End Sub


    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click

        'Comprueba si tiene alguna línea abierta antes de salir
        Dim lstLineasAbiertas As List(Of Integer) = CompruebaLineasAbiertas()
        If lstLineasAbiertas.Count > 0 Then

            Dim texto As String = "Tiene una o más líneas abiertas. Tiene que parar la producción antes de salir."
            texto = texto & vbCrLf & vbCrLf

            For Each pagina As Integer In lstLineasAbiertas
                texto = texto & vbTab & " - " & LstTab(pagina).Text & vbCrLf
            Next

            MsgBox(texto)
            Exit Sub
        End If



        For Each IdLinea As String In lstLineas
            DesBloquearLineas(IdLinea)
        Next



        Dim bHayDatos As Boolean = False

        For Each tab As TabPage In LstTab
            If tab.Text.Trim <> "" Then
                bHayDatos = True
            End If
        Next

        If bHayDatos Then

            BorraPan()

            TxFecha.Text = Today.ToString("dd/MM/yyyy")
            TxFecha.Select()
            TxFecha.Focus()

        Else
            Me.Close()
        End If



    End Sub


    Private Function CompruebaLineasAbiertas() As List(Of Integer)

        Dim lst As New List(Of Integer)

        'Para todos los grids
        For indice As Integer = 0 To lstGridView.Count - 1

            Dim gridview As DevExpress.XtraGrid.Views.Grid.GridView = lstGridView(indice)

            'Comprueba si hay alguna linea sin final y añade el indice a la lista
            For indice_grid As Integer = 0 To gridview.RowCount - 1

                Dim row As DataRow = gridview.GetDataRow(indice_grid)
                If Not IsNothing(row) Then
                    Dim Final As String = (row("Final").ToString & "").Trim
                    If Final = "" Then
                        lst.Add(indice)
                        Exit For
                    End If
                End If
            Next

        Next


        Return lst

    End Function


    Private Sub btNuevo1_Click(sender As System.Object, e As System.EventArgs) Handles btNuevo1.Click
        Nuevo(1)
    End Sub

    Private Sub btNuevo2_Click(sender As System.Object, e As System.EventArgs) Handles btNuevo2.Click
        Nuevo(2)
    End Sub

    Private Sub btNuevo3_Click(sender As System.Object, e As System.EventArgs) Handles btNuevo3.Click
        Nuevo(3)
    End Sub

    Private Sub btNuevo4_Click(sender As System.Object, e As System.EventArgs) Handles btNuevo4.Click
        Nuevo(4)
    End Sub

    Private Sub btNuevo5_Click(sender As System.Object, e As System.EventArgs) Handles btNuevo5.Click
        Nuevo(5)
    End Sub

    Private Sub btNuevo6_Click(sender As System.Object, e As System.EventArgs) Handles btNuevo6.Click
        Nuevo(6)
    End Sub

    Private Sub btNuevo7_Click(sender As System.Object, e As System.EventArgs) Handles btNuevo7.Click
        Nuevo(7)
    End Sub

    Private Sub btNuevo8_Click(sender As System.Object, e As System.EventArgs) Handles btNuevo8.Click
        Nuevo(8)
    End Sub

    Private Sub btNuevo9_Click(sender As System.Object, e As System.EventArgs) Handles btNuevo9.Click
        Nuevo(9)
    End Sub

    Private Sub btNuevo10_Click(sender As System.Object, e As System.EventArgs) Handles btNuevo10.Click
        Nuevo(10)
    End Sub


    Private Sub Nuevo(pagina As Integer)

        Dim paginaOrig As Integer = pagina
        pagina = pagina - 1


        Try

            Dim gridview As DevExpress.XtraGrid.Views.Grid.GridView = lstGridView(pagina)
            Dim cb As CbBox = LstCb(pagina)


            Dim HoraInicio As Date = VaDate("")


            For indice As Integer = 0 To gridview.RowCount - 1
                Dim row As DataRow = gridview.GetDataRow(indice)
                If Not IsNothing(row) Then

                    Dim Inicio As String = (row("Inicio").ToString & "").Trim
                    Dim Final As String = (row("Final").ToString & "").Trim

                    If Inicio <> "" And Final = "" Then

                        Dim Id As String = (row("Id").ToString & "").Trim
                        'Dim KilosLinea As Integer = VaInt(row("KilosLinea"))


                        Dim grid As DevExpress.XtraGrid.GridControl = LstGrid(pagina)
                        Dim dt As DataTable = CType(grid.DataSource, DataTable)
                        Dim dv As New DataView(dt)
                        dv.RowFilter = "Final = ''"
                        dt = dv.ToTable


                        If dt.Rows.Count > 0 Then

                            Dim frm As New FrmFinalizarLineaProduccion(Id, TxFecha.Text, dt)
                            frm.ShowDialog()

                            If frm.Resultado = FrmFinalizarLineaProduccion.ResultadoFormulario.Cancelar Then
                                Exit Sub
                            End If

                            If frm.HoraFinalizacion > VaDate("") Then
                                HoraInicio = DateAdd(DateInterval.Second, 1, frm.HoraFinalizacion)
                            End If
                            Exit For

                        Else
                            MsgBox("No hay lineas sin finalizar")
                            Exit Sub
                        End If



                    End If

                End If
            Next


            'Nuevo
            Dim IdLinea As String = VaInt(cb.SelectedValue).ToString

            If VaInt(IdLinea) > 0 And VaInt(LbPventa.Text) > 0 Then

                Dim bSoloPrecalibrado As Boolean = False
                Dim bPermitirPrecalibrado As Boolean = False

                Dim Lineas As New E_Lineas(Idusuario, cn)
                If Lineas.LeerId(IdLinea) Then
                    bSoloPrecalibrado = ((Lineas.LIN_SoloPrecalibradoSN.Valor & "").ToUpper.Trim = "S")
                    bPermitirPrecalibrado = ((Lineas.LIN_PermitirPrecalibradoSN.Valor & "").ToUpper.Trim = "S")
                End If


                Dim frm As New frmNuevaLineaProduccion(IdLinea, LbPventa.Text, TxFecha.Text, bSoloPrecalibrado, bPermitirPrecalibrado, HoraInicio)
                frm.ShowDialog()

                Refresca(paginaOrig)
                'SeleccionaLinea(paginaOrig)

            End If



        Catch ex As Exception

        End Try



    End Sub



    Private Sub btFinalizar1_Click(sender As System.Object, e As System.EventArgs) Handles btFinalizar1.Click
        Finalizar(1)
    End Sub

    Private Sub btFinalizar2_Click(sender As System.Object, e As System.EventArgs) Handles btFinalizar2.Click
        Finalizar(2)
    End Sub

    Private Sub btFinalizar3_Click(sender As System.Object, e As System.EventArgs) Handles btFinalizar3.Click
        Finalizar(3)
    End Sub

    Private Sub btFinalizar4_Click(sender As System.Object, e As System.EventArgs) Handles btFinalizar4.Click
        Finalizar(4)
    End Sub

    Private Sub btFinalizar5_Click(sender As System.Object, e As System.EventArgs) Handles btFinalizar5.Click
        Finalizar(5)
    End Sub

    Private Sub btFinalizar6_Click(sender As System.Object, e As System.EventArgs) Handles btFinalizar6.Click
        Finalizar(6)
    End Sub

    Private Sub btFinalizar7_Click(sender As System.Object, e As System.EventArgs) Handles btFinalizar7.Click
        Finalizar(7)
    End Sub

    Private Sub btFinalizar8_Click(sender As System.Object, e As System.EventArgs) Handles btFinalizar8.Click
        Finalizar(8)
    End Sub

    Private Sub btFinalizar9_Click(sender As System.Object, e As System.EventArgs) Handles btFinalizar9.Click
        Finalizar(9)
    End Sub

    Private Sub btFinalizar10_Click(sender As System.Object, e As System.EventArgs) Handles btFinalizar10.Click
        Finalizar(10)
    End Sub

    Private Sub Finalizar(pagina As Integer)

        Dim paginaOrig As Integer = pagina
        pagina = pagina - 1

        Try

            Dim gridview As DevExpress.XtraGrid.Views.Grid.GridView = lstGridView(pagina)
            Dim row As DataRow = gridview.GetFocusedDataRow()
            If Not IsNothing(row) Then

                Dim Final As String = (row("Final").ToString & "").Trim

                Dim Id As String = (row("Id").ToString & "").Trim
                If VaInt(Id) > 0 Then

                    'Dim KilosLinea As Integer = VaInt(row("KilosLinea"))


                    Dim grid As DevExpress.XtraGrid.GridControl = LstGrid(pagina)
                    Dim dt As DataTable = CType(grid.DataSource, DataTable)
                    Dim dv As New DataView(dt)
                    dv.RowFilter = "Final = ''"
                    dt = dv.ToTable

                    If dt.Rows.Count > 0 Then
                        Dim frm As New FrmFinalizarLineaProduccion(Id, TxFecha.Text, dt)
                        frm.ShowDialog()
                    Else
                        MsgBox("No hay lineas abiertas")
                        Exit Sub
                    End If


                    Refresca(paginaOrig)
                    'SeleccionaLinea(paginaOrig)

                End If

            End If


        Catch ex As Exception

        End Try


    End Sub


    Private Sub CbLinea1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbLinea1.SelectedIndexChanged
        CambiaLinea(1)
    End Sub

    Private Sub CbLinea2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbLinea2.SelectedIndexChanged
        CambiaLinea(2)
    End Sub

    Private Sub CbLinea3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbLinea3.SelectedIndexChanged
        CambiaLinea(3)
    End Sub

    Private Sub CbLinea4_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbLinea4.SelectedIndexChanged
        CambiaLinea(4)
    End Sub

    Private Sub CbLinea5_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbLinea5.SelectedIndexChanged
        CambiaLinea(5)
    End Sub

    Private Sub CbLinea6_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbLinea6.SelectedIndexChanged
        CambiaLinea(6)
    End Sub

    Private Sub CbLinea7_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbLinea7.SelectedIndexChanged
        CambiaLinea(7)
    End Sub

    Private Sub CbLinea8_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbLinea8.SelectedIndexChanged
        CambiaLinea(8)
    End Sub

    Private Sub CbLinea9_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbLinea9.SelectedIndexChanged
        CambiaLinea(9)
    End Sub

    Private Sub CbLinea10_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbLinea10.SelectedIndexChanged
        CambiaLinea(10)
    End Sub

    Private Sub CambiaLinea(pagina As Integer)

        Try

            If Not _bPrimero Then

                SeleccionaLinea(pagina)

            End If

        Catch ex As Exception

        End Try


    End Sub


    Private Sub SeleccionaLinea(pagina As Integer)

        Try

            Dim paginaOrig As Integer = pagina


            'Cambia etiqueta del tab
            pagina = pagina - 1



            Dim pag As TabPage = LstTab(pagina)
            Dim cb As CbBox = LstCb(pagina)
            Dim btPrecalibrado As ClButton = lstPrecalibrado(pagina)



            'Carga los datos de esa linea en el grid
            Dim IdLinea As String = VaInt(cb.SelectedValue).ToString


            'Oculta el botón de nuevo precalibrado si la línea es Solo Precalibrado
            Dim bPrecalibradoVisible As Boolean = True
            Dim Lineas As New E_Lineas(Idusuario, cn)
            If Lineas.LeerId(IdLinea) Then
                bPrecalibradoVisible = ((Lineas.LIN_SoloPrecalibradoSN.Valor & "").ToUpper.Trim <> "S")
            End If
            btPrecalibrado.Visible = bPrecalibradoVisible


            pag.Text = ""

            'Comprueba que no esté en otra pestaña
            For indice As Integer = 0 To LstCb.Count - 1
                If indice <> pagina Then
                    If VaInt(cb.SelectedValue) > 0 Then
                        If VaInt(cb.SelectedValue) = VaInt(LstCb(indice).SelectedValue) Then

                            MsgBox("La línea ya está seleccionada en otra pestaña")

                            cb.SelectedIndex = -1

                            Exit Sub

                        End If
                    End If
                End If
            Next



            If lstLineas(pagina) <> IdLinea Then

                'Comprueba que no esté seleccionada por otro usuario, y si no lo está, la bloquea (si ha cambiado la línea realmente)
                Dim NombreUsuario As String = UsuarioLineaBloqueada(IdLinea)
                If NombreUsuario.Trim <> "" Then
                    MsgBox("Error. El usuario " & NombreUsuario & " tiene abierta esta línea para Controlar la Producción")
                    cb.SelectedIndex = -1
                    Exit Sub
                End If

            End If


            'Bloquea línea
            BloquearLineas(paginaOrig)



            pag.Text = cb.Text


            Refresca(paginaOrig)





        Catch ex As Exception

        End Try




    End Sub


    Private Sub Refresca(pagina As Integer)

        pagina = pagina - 1


        Dim pag As TabPage = LstTab(pagina)
        Dim cb As CbBox = LstCb(pagina)
        Dim grid As DevExpress.XtraGrid.GridControl = LstGrid(pagina)
        Dim gridview As DevExpress.XtraGrid.Views.Grid.GridView = lstGridView(pagina)
        Dim btNuevo As ClButton = LstNuevo(pagina)
        Dim btFinalizar As ClButton = lstFinalizar(pagina)
        Dim btPrecalibrado As ClButton = lstPrecalibrado(pagina)
        Dim btDestrio As ClButton = lstDestrio(pagina)
        Dim btMuestreo As ClButton = lstMuestreo(pagina)


        'Carga los datos de esa linea en el grid
        Dim IdLinea As String = VaInt(cb.SelectedValue).ToString


        'Partidas
        Dim sql1 As String = "SELECT PRD_Id AS Id, 'P' AS Tipo, AEL_muestreo AS Numero, GEN_NombreGenero AS Genero, " & vbCrLf
        sql1 = sql1 & " CAE_categoriacalibre AS Categoria, " & vbCrLf
        sql1 = sql1 & " AEL_kilosnetos AS Kilos, PRD_KilosLinea AS KilosLinea, PRD_HoraInicio AS Inicio, PRD_HoraFinal AS Final," & vbCrLf
        sql1 = sql1 & " PRD_KilosConsumidos as KilosConsumidos, PRD_KilosDestrio as KgDestrio," & vbCrLf
        sql1 = sql1 & " CASE COALESCE(AEL_FechaMuestreo, '" & VaDate("") & "') WHEN '" & VaDate("") & "' THEN 'N' ELSE 'S' END as Muestreada," & vbCrLf
        sql1 = sql1 & " PRD_IdLineaEntrada as IdLineaEntrada, AEL_Observaciones as Observaciones," & vbCrLf
        sql1 = sql1 & " PRD_IdLineaEntrada as IdLineaEntrada, 0 as IdLote, 0 as IdLoteProduccion" & vbCrLf
        sql1 = sql1 & " FROM Produccion" & vbCrLf
        sql1 = sql1 & " INNER JOIN AlbEntrada_lineas ON PRD_IdLineaEntrada = AEL_idlinea" & vbCrLf
        sql1 = sql1 & " LEFT OUTER JOIN Generos ON AEL_idgenero = GEN_IdGenero" & vbCrLf
        sql1 = sql1 & " LEFT OUTER JOIN CategoriasEntrada ON AEL_idcategoria = CAE_id" & vbCrLf
        sql1 = sql1 & " WHERE PRD_IdLinea = " & IdLinea & vbCrLf
        sql1 = sql1 & " AND PRD_IdCentro = " & LbPventa.Text & vbCrLf
        sql1 = sql1 & " AND PRD_Fecha = '" & TxFecha.Text & "'" & vbCrLf



        'Lotes
        Dim sql2 As String = "SELECT PRD_Id as Id, 'L' as Tipo, LTE_Lote as Numero, GEN_NombreGenero as Producto, " & vbCrLf
        sql2 = sql2 & " '' as Categoria, (SELECT SUM(LTL_Kilos) FROM Lotes_Lineas WHERE LTE_IdLote = LTL_IdLote) as Kilos," & vbCrLf
        sql2 = sql2 & " PRD_KilosLinea as KilosLinea, PRD_HoraInicio as Inicio, PRD_HoraFinal as Final, PRD_KilosConsumidos as KilosConsumidos," & vbCrLf
        sql2 = sql2 & " PRD_KilosDestrio as KgDestrio, '-' as Muestreada, 0 as IdLineaEntrada, '' as Observaciones," & vbCrLf
        sql2 = sql2 & " 0 as IdLineaEntrada, PRD_IdLote as IdLote, 0 as IdLoteProduccion" & vbCrLf
        sql2 = sql2 & " FROM Produccion" & vbCrLf
        sql2 = sql2 & " INNER JOIN Lotes ON LTE_IdLote = PRD_IdLote" & vbCrLf
        sql2 = sql2 & " LEFT JOIN Generos ON GEN_IdGenero = LTE_IdGenero" & vbCrLf
        sql2 = sql2 & " WHERE PRD_IdLinea = " & IdLinea & vbCrLf
        sql2 = sql2 & " AND PRD_IdCentro = " & LbPventa.Text & vbCrLf
        sql2 = sql2 & " AND PRD_Fecha = '" & TxFecha.Text & "'"



        'Precalibrado
        Dim sql3 As String = "SELECT PRD_Id as Id, 'C' as Tipo, LPD_Lote as Numero, GEN_NombreGenero as Producto, " & vbCrLf
        sql3 = sql3 & " CAS_CategoriaCalibre as Categoria, (SELECT SUM(LPL_Kilos) FROM LotesProduccion_Lineas WHERE LPD_IdLote = LPL_IdLote) as Kilos," & vbCrLf
        sql3 = sql3 & " PRD_KilosLinea as KilosLinea, PRD_HoraInicio as Inicio, PRD_HoraFinal as Final, PRD_KilosConsumidos as KilosConsumidos," & vbCrLf
        sql3 = sql3 & " PRD_KilosDestrio as KgDestrio, '-' as Muestreada, 0 as IdLineaEntrada, '' as Observaciones," & vbCrLf
        sql3 = sql3 & " 0 as IdLineaEntrada, 0 as IdLote, PRD_IdLoteProduccion as IdLoteProduccion" & vbCrLf
        sql3 = sql3 & " FROM Produccion" & vbCrLf
        sql3 = sql3 & " INNER JOIN LotesProduccion ON LPD_IdLote = PRD_IdLoteProduccion" & vbCrLf
        sql3 = sql3 & " LEFT JOIN Generos ON GEN_IdGenero = LPD_IdGenero" & vbCrLf
        sql3 = sql3 & " LEFT JOIN CategoriasSalida ON CAS_Id = LPD_IdCategoria" & vbCrLf
        sql3 = sql3 & " WHERE PRD_IdLinea = " & IdLinea & vbCrLf
        sql3 = sql3 & " AND PRD_IdCentro = " & LbPventa.Text & vbCrLf
        sql3 = sql3 & " AND PRD_Fecha = '" & TxFecha.Text & "'"


        Dim sql As String = sql1 & vbCrLf & "UNION ALL" & vbCrLf & sql2 & vbCrLf & "UNION ALL" & vbCrLf & sql3 & vbCrLf
        sql = sql & " ORDER BY PRD_HoraInicio" & vbCrLf


        Dim dt As DataTable = Produccion.MiConexion.ConsultaSQL(sql)
        dt.Columns.Add(New DataColumn("Tiempo", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("KgxHora", GetType(Decimal)))
        dt = CompletarGrid(dt)


        grid.DataSource = dt
        AjustaColumnas(gridview)


        btNuevo.Enabled = True
        btFinalizar.Enabled = True
        btPrecalibrado.Enabled = True
        btDestrio.Enabled = True
        btMuestreo.Enabled = True



    End Sub



    Private Function CompletarGrid(ByRef dt As DataTable) As DataTable

        For Each row As DataRow In dt.Rows

            Dim TotalKilosConsumidos As Integer = VaInt(row("KilosConsumidos"))
            Dim HoraInicio As String = (row("Inicio").ToString & "").Trim
            Dim HoraFinal As String = (row("Final").ToString & "").Trim


            'TODO: Buscar las líneas abiertas y recalcular los kiloslinea de las líneas del lote, partida o precalibrado, no usar
            'los kiloslineas de producción para las líneas abiertas
            If HoraFinal = "" Then
                Dim Tipo As String = (row("Tipo").ToString & "").Trim
                Select Case Tipo

                    Case "P"

                        Dim IdLineaEntrada As String = (row("IdLineaEntrada").ToString & "").Trim
                        If VaInt(IdLineaEntrada) > 0 Then
                            Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
                            If AlbEntrada_Lineas.LeerId(IdLineaEntrada) Then

                                Dim Kilos As Decimal = VaDec(AlbEntrada_Lineas.AEL_kilosnetos.Valor)
                                Dim KilosLote As Decimal = 0
                                Dim KilosConsumidos As Decimal = 0

                                'Kilos Lote
                                Dim sql As String = "SELECT SUM(LTL_Kilos) as KilosLote FROM Lotes_Lineas WHERE LTL_IdLineaEntrada = " & IdLineaEntrada
                                Dim dtPartida = AlbEntrada_Lineas.MiConexion.ConsultaSQL(sql)
                                If Not IsNothing(dtPartida) Then
                                    If dtPartida.Rows.Count > 0 Then
                                        KilosLote = VaDec(dtPartida.Rows(0)("KilosLote"))
                                    End If
                                End If

                                'Kilos consumidos
                                sql = "SELECT SUM(PRD_KilosConsumidos) as KilosConsumidos FROM Produccion WHERE PRD_IdLineaEntrada = " & IdLineaEntrada
                                dtPartida = AlbEntrada_Lineas.MiConexion.ConsultaSQL(sql)
                                If Not IsNothing(dtPartida) Then
                                    If dtPartida.Rows.Count > 0 Then
                                        KilosConsumidos = VaDec(dtPartida.Rows(0)("KilosConsumidos"))
                                    End If
                                End If

                                row("KilosLinea") = (Kilos - KilosLote - KilosConsumidos)


                                Dim Id As String = (row("Id").ToString & "").Trim
                                If VaInt(Id) > 0 Then
                                    Dim Produccion As New E_Produccion(Idusuario, cn)
                                    If Produccion.LeerId(Id) Then
                                        Produccion.PRD_KilosLinea.Valor = VaDec(row("KilosLinea")).ToString
                                        Produccion.Actualizar()
                                    End If
                                End If



                            End If
                        End If

                    Case "L"

                        Dim IdLote As String = (row("IdLote").ToString & "").Trim
                        If VaInt(IdLote) > 0 Then

                            Dim Kilos As Decimal = 0
                            Dim KilosConsumidos As Decimal = 0

                            'Kilos del lote
                            Dim sql As String = "SELECT SUM(LTL_Kilos) as Kilos FROM Lotes_Lineas WHERE LTL_IdLote = " & IdLote
                            Dim dtLote As DataTable = Produccion.MiConexion.ConsultaSQL(sql)
                            If Not IsNothing(dtLote) Then
                                If dtLote.Rows.Count > 0 Then
                                    Kilos = VaDec(dtLote.Rows(0)("Kilos"))
                                End If
                            End If

                            'Kilos consumidos
                            sql = "SELECT SUM(PRD_KilosConsumidos) as KilosConsumidos FROM Produccion WHERE PRD_IdLote = " & IdLote
                            dtLote = AlbEntrada_Lineas.MiConexion.ConsultaSQL(sql)
                            If Not IsNothing(dtLote) Then
                                If dtLote.Rows.Count > 0 Then
                                    KilosConsumidos = VaDec(dtLote.Rows(0)("KilosConsumidos"))
                                End If
                            End If

                            row("KilosLinea") = (Kilos - KilosConsumidos)

                            Dim Id As String = (row("Id").ToString & "").Trim
                            If VaInt(Id) > 0 Then
                                Dim Produccion As New E_Produccion(Idusuario, cn)
                                If Produccion.LeerId(Id) Then
                                    Produccion.PRD_KilosLinea.Valor = VaDec(row("KilosLinea")).ToString
                                    Produccion.Actualizar()
                                End If
                            End If


                        End If



                    Case "C"

                        Dim IdLoteProduccion As String = (row("IdLoteProduccion").ToString & "").Trim
                        If VaInt(IdLoteProduccion) > 0 Then

                            Dim Kilos As Decimal = 0
                            Dim KilosConsumidos As Decimal = 0


                            'Kilos precalibrado
                            Dim sql As String = "SELECT SUM(LPL_Kilos) as Kilos FROM LotesProduccion_Lineas WHERE LPL_IdLote = " & IdLoteProduccion
                            Dim dtPrecalibrado As DataTable = Produccion.MiConexion.ConsultaSQL(sql)
                            If Not IsNothing(dtPrecalibrado) Then
                                If dtPrecalibrado.Rows.Count > 0 Then
                                    Kilos = VaDec(dtPrecalibrado.Rows(0)("Kilos"))
                                End If
                            End If


                            'Kilos consumidos
                            sql = "SELECT SUM(PRD_KilosConsumidos) as KilosConsumidos FROM Produccion WHERE PRD_IdLoteProduccion = " & IdLoteProduccion
                            dtPrecalibrado = AlbEntrada_Lineas.MiConexion.ConsultaSQL(sql)
                            If Not IsNothing(dtPrecalibrado) Then
                                If dtPrecalibrado.Rows.Count > 0 Then
                                    KilosConsumidos = VaDec(dtPrecalibrado.Rows(0)("KilosConsumidos"))
                                End If
                            End If

                            row("KilosLinea") = (Kilos - KilosConsumidos)

                            Dim Id As String = (row("Id").ToString & "").Trim
                            If VaInt(Id) > 0 Then
                                Dim Produccion As New E_Produccion(Idusuario, cn)
                                If Produccion.LeerId(Id) Then
                                    Produccion.PRD_KilosLinea.Valor = VaDec(row("KilosLinea")).ToString
                                    Produccion.Actualizar()
                                End If
                            End If


                        End If

                End Select
            End If


            Dim Inicio As DateTime
            Dim Final As DateTime


            If DateTime.TryParse(HoraInicio, Inicio) And DateTime.TryParse(HoraFinal, Final) Then

                If Final < Inicio Then
                    Final = DateAdd(DateInterval.Day, 1, Final)
                End If


                Dim segundos As Decimal = DateDiff(DateInterval.Second, Inicio, Final)
                Dim horas As Decimal = segundos / 3600
                If horas <> 0 Then
                    row("KgxHora") = TotalKilosConsumidos / horas
                    row("Tiempo") = horas
                End If
            End If

        Next


        Return dt

    End Function


    Private Sub AjustaColumnas(gridview As DevExpress.XtraGrid.Views.Grid.GridView)

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In gridview.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "ID", "IDLINEAENTRADA", "OBSERVACIONES", "IDLINEAENTRADA", "IDLOTE", "IDLOTEPRODUCCION"
                    c.Visible = False
            End Select
        Next

        gridview.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In gridview.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "NUMERO"
                    c.Caption = "Partida/Lote/PreCalib."
                Case "TIPO"
                    c.MinWidth = 30
                    c.MaxWidth = 30
                Case "KILOS", "KILOSLINEA", "KILOSCONSUMIDOS", "KGDESTRIO"
                    c.MinWidth = 85
                    c.MaxWidth = 85
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                Case "INICIO", "FINAL"
                    c.MinWidth = 65
                    c.MaxWidth = 65
                Case "KGXHORA"
                    c.MinWidth = 80
                    c.MaxWidth = 80
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                Case "CATEGORIA"
                    c.Width = 100
                Case "PCALIB"
                    c.MinWidth = 50
                    c.MaxWidth = 50
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case "TIEMPO"
                    c.MinWidth = 65
                    c.MaxWidth = 65
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.0000"
                    c.Caption = "Tiempo(H)"
                Case "MUESTREADA"
                    c.Caption = "Muest."
                    c.MinWidth = 50
                    c.MaxWidth = 50
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            End Select
        Next

        Funciones.AñadeResumenCampo(gridview, "Tiempo", "{0:n4}")
        Funciones.AñadeResumenCampo(gridview, "KilosConsumidos", "{0:n0}")
        Funciones.AñadeResumenCampo(gridview, "KgxHora", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)

    End Sub


    Private Sub TxFecha_Valida(edicion As Boolean) Handles TxFecha.Valida

        If edicion Then

            BorraPan()

            If Not TxFecha.MiError Then
                TabControl1.Enabled = True

                Dim pagina As Integer = TabControl1.SelectedIndex
                Try
                    Dim cb As CbBox = LstCb(pagina)
                    cb.Select()
                    cb.Focus()

                    cb.DroppedDown = True

                Catch ex As Exception

                End Try

            Else
                TabControl1.Enabled = False
            End If
        End If

    End Sub


    Private Sub BorraPan()

        For Each grid As DevExpress.XtraGrid.GridControl In LstGrid
            grid.DataSource = Nothing
        Next

        For pagina As Integer = 0 To LstCb.Count - 1
            Dim Cb As CbBox = LstCb(pagina)
            Desbloquear(pagina + 1)
            Cb.SelectedIndex = -1
        Next

        For Each TAB As TabPage In LstTab
            TAB.Text = ""
        Next
        TabControl1.SelectedIndex = 0

        For Each btNuevo As ClButton In LstNuevo
            btNuevo.Enabled = False
        Next

        For Each btFinalizar As ClButton In lstFinalizar
            btFinalizar.Enabled = False
        Next

        For Each btPrecalibrado As ClButton In lstPrecalibrado
            btPrecalibrado.Enabled = False
        Next

        For Each btDestrio As ClButton In lstDestrio
            btDestrio.Enabled = False
        Next

        For Each btMuestreo As ClButton In lstMuestreo
            btMuestreo.Enabled = False
        Next



    End Sub


    Private Sub CbLinea1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbLinea1.KeyDown
        CbKeyDown(sender, e.KeyCode, 1)
    End Sub
    Private Sub CbLinea2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbLinea2.KeyDown
        CbKeyDown(sender, e.KeyCode, 2)
    End Sub
    Private Sub CbLinea3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbLinea3.KeyDown
        CbKeyDown(sender, e.KeyCode, 3)
    End Sub
    Private Sub CbLinea4_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbLinea4.KeyDown
        CbKeyDown(sender, e.KeyCode, 4)
    End Sub
    Private Sub CbLinea5_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbLinea5.KeyDown
        CbKeyDown(sender, e.KeyCode, 5)
    End Sub
    Private Sub CbLinea6_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbLinea6.KeyDown
        CbKeyDown(sender, e.KeyCode, 6)
    End Sub
    Private Sub CbLinea7_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbLinea7.KeyDown
        CbKeyDown(sender, e.KeyCode, 7)
    End Sub
    Private Sub CbLinea8_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbLinea8.KeyDown
        CbKeyDown(sender, e.KeyCode, 8)
    End Sub
    Private Sub CbLinea9_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbLinea9.KeyDown
        CbKeyDown(sender, e.KeyCode, 9)
    End Sub
    Private Sub CbLinea10_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbLinea10.KeyDown
        CbKeyDown(sender, e.KeyCode, 10)
    End Sub

    Private Sub CbKeyDown(cb As CbBox, k As Keys, pagina As Integer)

        pagina = pagina - 1

        If k = Keys.Enter Then
            If cb.DroppedDown Then
                cb.DroppedDown = False
            Else

                Try

                    Dim btNuevo As ClButton = LstNuevo(pagina)
                    btNuevo.Select()
                    btNuevo.Focus()

                Catch ex As Exception

                End Try

            End If
        End If

    End Sub


    
    Private Sub GridView1_CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles GridView1.CustomSummaryCalculate
        TotalesTiempos(1, e)
    End Sub

    Private Sub GridView2_CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles GridView2.CustomSummaryCalculate
        TotalesTiempos(2, e)
    End Sub

    Private Sub GridView3_CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles GridView3.CustomSummaryCalculate
        TotalesTiempos(3, e)
    End Sub

    Private Sub GridView4_CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles GridView4.CustomSummaryCalculate
        TotalesTiempos(4, e)
    End Sub

    Private Sub GridView5_CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles GridView5.CustomSummaryCalculate
        TotalesTiempos(5, e)
    End Sub

    Private Sub GridView6_CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles GridView6.CustomSummaryCalculate
        TotalesTiempos(6, e)
    End Sub

    Private Sub GridView7_CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles GridView7.CustomSummaryCalculate
        TotalesTiempos(7, e)
    End Sub

    Private Sub GridView8_CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles GridView8.CustomSummaryCalculate
        TotalesTiempos(8, e)
    End Sub

    Private Sub GridView9_CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles GridView9.CustomSummaryCalculate
        TotalesTiempos(9, e)
    End Sub

    Private Sub GridView10_CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles GridView10.CustomSummaryCalculate
        TotalesTiempos(10, e)
    End Sub


    Private Sub TotalesTiempos(indice As Integer, e As DevExpress.Data.CustomSummaryEventArgs)

        Try

            Dim gridview As DevExpress.XtraGrid.Views.Grid.GridView = lstGridView(indice)


            If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

                If e.IsGroupSummary Then

                    Dim kh As Decimal = 0

                    Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item
                    If item.FieldName.ToUpper.Trim = "KGXHORA" Then

                        Dim Horas As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(0)))
                        Dim Kilos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(1)))
                        If Horas <> 0 Then kh = Kilos / Horas

                    End If
                    e.TotalValue = kh

                End If


                If e.IsTotalSummary Then

                    Dim kh As Decimal = 0

                    Dim item As DevExpress.XtraGrid.GridColumnSummaryItem = e.Item
                    If item.FieldName.ToUpper.Trim = "KGXHORA" Then

                        Dim kilos As Decimal = 0
                        Dim horas As Decimal = 0

                        Dim colKilos As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("KilosConsumidos")
                        If Not IsNothing(colKilos) Then kilos = VaDec(colKilos.SummaryItem.SummaryValue)

                        Dim colHoras As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("Tiempo")
                        If Not IsNothing(colHoras) Then horas = VaDec(colHoras.SummaryItem.SummaryValue)

                        If horas <> 0 Then kh = kilos / horas

                    End If
                    e.TotalValue = kh

                End If

            End If




        Catch ex As Exception

        End Try


    End Sub


    Private Sub btDesbloquear1_Click(sender As System.Object, e As System.EventArgs) Handles btDesbloquear1.Click
        Desbloquear(1)
    End Sub

    Private Sub btDesbloquear2_Click(sender As System.Object, e As System.EventArgs) Handles btDesbloquear2.Click
        Desbloquear(2)
    End Sub

    Private Sub btDesbloquear3_Click(sender As System.Object, e As System.EventArgs) Handles btDesbloquear3.Click
        Desbloquear(3)
    End Sub

    Private Sub btDesbloquear4_Click(sender As System.Object, e As System.EventArgs) Handles btDesbloquear4.Click
        Desbloquear(4)
    End Sub

    Private Sub btDesbloquear5_Click(sender As System.Object, e As System.EventArgs) Handles btDesbloquear5.Click
        Desbloquear(5)
    End Sub

    Private Sub btDesbloquear6_Click(sender As System.Object, e As System.EventArgs) Handles btDesbloquear6.Click
        Desbloquear(6)
    End Sub

    Private Sub btDesbloquear7_Click(sender As System.Object, e As System.EventArgs) Handles btDesbloquear7.Click
        Desbloquear(7)
    End Sub

    Private Sub btDesbloquear8_Click(sender As System.Object, e As System.EventArgs) Handles btDesbloquear8.Click
        Desbloquear(8)
    End Sub

    Private Sub btDesbloquear9_Click(sender As System.Object, e As System.EventArgs) Handles btDesbloquear9.Click
        Desbloquear(9)
    End Sub

    Private Sub btDesbloquear10_Click(sender As System.Object, e As System.EventArgs) Handles btDesbloquear10.Click
        Desbloquear(10)
    End Sub

    'Private Sub Desbloquear(pagina As Integer)

    '    Dim paginaOrig As Integer = pagina
    '    pagina = pagina - 1

    '    Dim Cb As CbBox = LstCb(pagina)
    '    Cb.SelectedIndex = -1

    '    BloqueoLineas(paginaOrig)
    '    DesBloqueoLineas(paginaOrig)


    '    For Each btNuevo As ClButton In LstNuevo
    '        btNuevo.Enabled = False
    '    Next
    '    For Each btFinalizar As ClButton In lstFinalizar
    '        btFinalizar.Enabled = False
    '    Next
    '    For Each btPrecalibrado As ClButton In lstPrecalibrado
    '        btPrecalibrado.Enabled = False
    '    Next
    '    For Each btDestrio As ClButton In lstDestrio
    '        btDestrio.Enabled = False
    '    Next
    '    For Each btMuestreo As ClButton In lstMuestreo
    '        btMuestreo.Enabled = False
    '    Next


    'End Sub


    Private Sub btGuardarConf_Click(sender As System.Object, e As System.EventArgs) Handles btGuardarConf.Click

        If VaDate(TxFecha.Text) > VaDate("") Then

            Dim lstLineasBloqueadas As New List(Of String)

            For indice As Integer = 0 To LstCb.Count - 1
                Dim Cb As CbBox = LstCb(indice)
                If VaInt(Cb.SelectedValue) > 0 Then
                    lstLineasBloqueadas.Add(VaInt(Cb.SelectedValue).ToString)
                End If
            Next


            BloqueoLineaFecha.GuardaConfiguracion(lstLineasBloqueadas)

            MsgBox("Configuración guardada")

        End If

    End Sub

    Private Sub btCargarConf_Click(sender As System.Object, e As System.EventArgs) Handles btCargarConf.Click

        Dim lstLineasBloqueadas As List(Of String) = BloqueoLineaFecha.CargaConfiguracion()

        'Ponemos todo a 0
        BorraPan()


        Dim ultima_pagina As Integer = 0

        For Each IdLinea As String In lstLineasBloqueadas
            If ultima_pagina < 10 Then

                Dim Cb As CbBox = LstCb(ultima_pagina)
                Cb.SelectedValue = IdLinea

                ultima_pagina = ultima_pagina + 1

            End If
        Next


    End Sub


    Private Function UsuarioLineaBloqueada(IdLinea As String) As String

        Dim res As String = ""


        If VaDate(TxFecha.Text) > VaDate("") Then

            Dim BloqueoLineaFecha As New E_BloqueoLineaFecha(Idusuario, cn)
            If BloqueoLineaFecha.LeerPorLineaFecha(IdLinea, TxFecha.Text) > 0 Then

                res = VaInt(BloqueoLineaFecha.BLF_IdUsuario.Valor).ToString

                Dim Usuarios As New E_Usuarios(Idusuario, CnComun)
                If Usuarios.LeerId(BloqueoLineaFecha.BLF_IdUsuario.Valor) Then
                    res = Usuarios.Nombre.Valor
                End If

            End If

        End If



        Return res

    End Function


    Private Sub btNuevoPrecalibrado1_Click(sender As System.Object, e As System.EventArgs) Handles btNuevoPrecalibrado1.Click
        NuevoPrecalibrado(1)
    End Sub

    Private Sub btNuevoPrecalibrado2_Click(sender As System.Object, e As System.EventArgs) Handles btNuevoPrecalibrado2.Click
        NuevoPrecalibrado(2)
    End Sub

    Private Sub btNuevoPrecalibrado3_Click(sender As System.Object, e As System.EventArgs) Handles btNuevoPrecalibrado3.Click
        NuevoPrecalibrado(3)
    End Sub

    Private Sub btNuevoPrecalibrado4_Click(sender As System.Object, e As System.EventArgs) Handles btNuevoPrecalibrado4.Click
        NuevoPrecalibrado(4)
    End Sub

    Private Sub btNuevoPrecalibrado5_Click(sender As System.Object, e As System.EventArgs) Handles btNuevoPrecalibrado5.Click
        NuevoPrecalibrado(5)
    End Sub

    Private Sub btNuevoPrecalibrado6_Click(sender As System.Object, e As System.EventArgs) Handles btNuevoPrecalibrado6.Click
        NuevoPrecalibrado(6)
    End Sub

    Private Sub btNuevoPrecalibrado7_Click(sender As System.Object, e As System.EventArgs) Handles btNuevoPrecalibrado7.Click
        NuevoPrecalibrado(7)
    End Sub

    Private Sub btNuevoPrecalibrado8_Click(sender As System.Object, e As System.EventArgs) Handles btNuevoPrecalibrado8.Click
        NuevoPrecalibrado(8)
    End Sub

    Private Sub btNuevoPrecalibrado9_Click(sender As System.Object, e As System.EventArgs) Handles btNuevoPrecalibrado9.Click
        NuevoPrecalibrado(9)
    End Sub

    Private Sub btNuevoPrecalibrado10_Click(sender As System.Object, e As System.EventArgs) Handles btNuevoPrecalibrado10.Click
        NuevoPrecalibrado(10)
    End Sub

    Private Sub NuevoPrecalibrado(pagina As Integer)

        pagina = pagina - 1


        Dim Grid As DevExpress.XtraGrid.GridControl = LstGrid(pagina)
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)
        Dim dtLineas As DataTable = Nothing
        'Dim DcNumero As New Dictionary(Of String, String)


        If Not IsNothing(dt) Then

            dtLineas = dt.Clone

            'Suponemos ordenadas por hora inicio ascendente, así que cogemos sólo las 10 últimas
            For indice As Integer = dt.Rows.Count - 1 To 0 Step -1

                'Máximo 10
                If dtLineas.Rows.Count = 10 Then
                    Exit For
                End If


                Dim row As DataRow = dt.Rows(indice)
                Dim tipo As String = (row("Tipo").ToString & "").ToUpper.Trim
                Dim num As String = tipo & (row("Numero").ToString & "").Trim

                'Sólo Partidas o Lotes, no precalibrado
                If tipo <> "C" Then
                    'If Not DcNumero.ContainsKey(num) Then
                    dtLineas.ImportRow(row)
                    'DcNumero(num) = num

                    'End If
                End If

            Next

        End If


        Dim frm As New FrmLotesProduccion(dtLineas)
        frm.ShowDialog()


    End Sub



    Private Sub btMuestreo1_Click(sender As System.Object, e As System.EventArgs) Handles btMuestreo1.Click
        Muestreo(1)
    End Sub

    Private Sub btMuestreo2_Click(sender As System.Object, e As System.EventArgs) Handles btMuestreo2.Click
        Muestreo(2)
    End Sub

    Private Sub btMuestreo3_Click(sender As System.Object, e As System.EventArgs) Handles btMuestreo3.Click
        Muestreo(3)
    End Sub

    Private Sub btMuestreo4_Click(sender As System.Object, e As System.EventArgs) Handles btMuestreo4.Click
        Muestreo(4)
    End Sub

    Private Sub btMuestreo5_Click(sender As System.Object, e As System.EventArgs) Handles btMuestreo5.Click
        Muestreo(5)
    End Sub

    Private Sub btMuestreo6_Click(sender As System.Object, e As System.EventArgs) Handles btMuestreo6.Click
        Muestreo(6)
    End Sub

    Private Sub btMuestreo7_Click(sender As System.Object, e As System.EventArgs) Handles btMuestreo7.Click
        Muestreo(7)
    End Sub

    Private Sub btMuestreo8_Click(sender As System.Object, e As System.EventArgs) Handles btMuestreo8.Click
        Muestreo(8)
    End Sub

    Private Sub btMuestreo9_Click(sender As System.Object, e As System.EventArgs) Handles btMuestreo9.Click
        Muestreo(9)
    End Sub

    Private Sub btMuestreo10_Click(sender As System.Object, e As System.EventArgs) Handles btMuestreo10.Click
        Muestreo(10)
    End Sub

    Private Sub Muestreo(pagina As Integer)

        Dim paginaOrig As Integer = pagina
        pagina = pagina - 1


        Dim gridview As DevExpress.XtraGrid.Views.Grid.GridView = lstGridView(pagina)
        Dim row As DataRow = gridview.GetFocusedDataRow()

        If Not IsNothing(row) Then

            Dim IdLineaEntrada As String = (row("IdLineaEntrada").ToString & "").Trim


            Dim frm As New FrmClasificacionPartidas(IdLineaEntrada)
            frm.ShowDialog()

            If frm.Resultado = ResultadoFormulario.Guardar Then
                Refresca(paginaOrig)
            End If

        End If


        

    End Sub

    
    

    Private Sub btDestrio1_Click(sender As System.Object, e As System.EventArgs) Handles btDestrio1.Click
        Destrio(1)
    End Sub

    Private Sub btDestrio2_Click(sender As System.Object, e As System.EventArgs) Handles btDestrio2.Click
        Destrio(2)
    End Sub

    Private Sub btDestrio3_Click(sender As System.Object, e As System.EventArgs) Handles btDestrio3.Click
        Destrio(3)
    End Sub

    Private Sub btDestrio4_Click(sender As System.Object, e As System.EventArgs) Handles btDestrio4.Click
        Destrio(4)
    End Sub

    Private Sub btDestrio5_Click(sender As System.Object, e As System.EventArgs) Handles btDestrio5.Click
        Destrio(5)
    End Sub

    Private Sub btDestrio6_Click(sender As System.Object, e As System.EventArgs) Handles btDestrio6.Click
        Destrio(6)
    End Sub

    Private Sub btDestrio7_Click(sender As System.Object, e As System.EventArgs) Handles btDestrio7.Click
        Destrio(7)
    End Sub

    Private Sub btDestrio8_Click(sender As System.Object, e As System.EventArgs) Handles btDestrio8.Click
        Destrio(8)
    End Sub

    Private Sub btDestrio9_Click(sender As System.Object, e As System.EventArgs) Handles btDestrio9.Click
        Destrio(9)
    End Sub

    Private Sub btDestrio10_Click(sender As System.Object, e As System.EventArgs) Handles btDestrio10.Click
        Destrio(10)
    End Sub

    Private Sub Destrio(pagina As Integer)

        pagina = pagina - 1


        Dim gridview As DevExpress.XtraGrid.Views.Grid.GridView = lstGridView(pagina)
        Dim row As DataRow = gridview.GetFocusedDataRow()
        If Not IsNothing(row) Then

            Dim IdProduccion As String = (row("Id").ToString & "").Trim
            If VaInt(IdProduccion) > 0 Then

                Dim Fecha As String = ""
                If VaDate(TxFecha.Text) > VaDate("") Then Fecha = VaDate(TxFecha.Text).ToString("dd/MM/yyyy")
                Dim Tipo As String = (row("Tipo").ToString & "").Trim
                Dim Numero As String = (row("Numero").ToString & "").Trim
                Dim Genero As String = (row("Genero").ToString & "").Trim
                Dim Consumido As Integer = VaInt(row("KilosConsumidos"))
                Dim Inicio As String = (row("Inicio").ToString & "").Trim
                Dim Final As String = (row("Final").ToString & "").Trim
                Dim destrio As Integer = VaInt(row("KgDestrio"))

                Dim frm As New frmKilosDestrio(IdProduccion, Fecha, Tipo, Numero, Genero, Consumido, Inicio, Final, destrio)
                frm.ShowDialog()

                If frm.Resultado = frmKilosDestrio.ResultadoFormulario.Aceptar Then
                    row("KgDestrio") = frm.KilosDestrio
                End If


            Else
                MsgBox("Error al obtener el Id de producción")
            End If

        End If


    End Sub


    Private Sub GridView1_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        EstiloLinea(1, e)
    End Sub

    Private Sub GridView2_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView2.RowCellStyle
        EstiloLinea(2, e)
    End Sub

    Private Sub GridView3_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView3.RowCellStyle
        EstiloLinea(3, e)
    End Sub

    Private Sub GridView4_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView4.RowCellStyle
        EstiloLinea(4, e)
    End Sub

    Private Sub GridView5_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView5.RowCellStyle
        EstiloLinea(5, e)
    End Sub

    Private Sub GridView6_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView6.RowCellStyle
        EstiloLinea(6, e)
    End Sub

    Private Sub GridView7_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView7.RowCellStyle
        EstiloLinea(7, e)
    End Sub

    Private Sub GridView8_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView8.RowCellStyle
        EstiloLinea(8, e)
    End Sub

    Private Sub GridView9_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView9.RowCellStyle
        EstiloLinea(9, e)
    End Sub

    Private Sub GridView10_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView10.RowCellStyle
        EstiloLinea(10, e)
    End Sub


    Private Sub EstiloLinea(pagina As Integer, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)

        pagina = pagina - 1


        Dim gridview As DevExpress.XtraGrid.Views.Grid.GridView = lstGridView(pagina)

        Dim row As DataRow = gridview.GetDataRow(e.RowHandle)
        If Not IsNothing(row) Then
            If e.Column.FieldName.ToUpper.Trim = "MUESTREADA" Then

                If (e.CellValue.ToString & "").Trim = "S" Then
                    e.Appearance.BackColor = Color.LightGreen
                ElseIf (e.CellValue.ToString & "").Trim = "N" Then
                    e.Appearance.BackColor = Color.Red
                End If

            End If
        End If


    End Sub


    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        CambiaFoco(1)
    End Sub



    Private Sub CambiaFoco(pagina As Integer)

        pagina = pagina - 1


        Dim gridview As DevExpress.XtraGrid.Views.Grid.GridView = lstGridView(pagina)
        Dim btMuestreo As ClButton = lstMuestreo(pagina)

        Dim row As DataRow = gridview.GetFocusedDataRow()
        If Not IsNothing(row) Then

            Dim Tipo As String = (row("Tipo").ToString & "").ToUpper.Trim
            Dim Muestreada As String = (row("Muestreada").ToString & "").ToUpper.Trim

            If Tipo = "P" And Muestreada = "N" Then
                btMuestreo.Visible = True
            Else
                btMuestreo.Visible = False
            End If

        End If

    End Sub



    Private Sub btRefrescar1_Click(sender As System.Object, e As System.EventArgs) Handles btRefrescar1.Click
        SeleccionaLinea(1)
    End Sub

    Private Sub btRefrescar2_Click(sender As System.Object, e As System.EventArgs) Handles btRefrescar2.Click
        Refresca(2)
    End Sub

    Private Sub btRefrescar3_Click(sender As System.Object, e As System.EventArgs) Handles btRefrescar3.Click
        Refresca(3)
    End Sub

    Private Sub btRefrescar4_Click(sender As System.Object, e As System.EventArgs) Handles btRefrescar4.Click
        Refresca(4)
    End Sub

    Private Sub btRefrescar5_Click(sender As System.Object, e As System.EventArgs) Handles btRefrescar5.Click
        Refresca(5)
    End Sub

    Private Sub btRefrescar6_Click(sender As System.Object, e As System.EventArgs) Handles btRefrescar6.Click
        Refresca(6)
    End Sub

    Private Sub btRefrescar7_Click(sender As System.Object, e As System.EventArgs) Handles btRefrescar7.Click
        Refresca(7)
    End Sub

    Private Sub btRefrescar8_Click(sender As System.Object, e As System.EventArgs) Handles btRefrescar8.Click
        Refresca(8)
    End Sub

    Private Sub btRefrescar9_Click(sender As System.Object, e As System.EventArgs) Handles btRefrescar9.Click
        Refresca(9)
    End Sub

    Private Sub btRefrescar10_Click(sender As System.Object, e As System.EventArgs) Handles btRefrescar10.Click
        Refresca(10)
    End Sub



    Private Sub BloquearLineas(pagina As Integer)

        If VaDate(TxFecha.Text) > VaDate("") Then

            Dim paginaOrig As Integer = pagina
            pagina = pagina - 1

            Dim Cb As CbBox = LstCb(pagina)
            Dim IdLinea As String = VaInt(Cb.SelectedValue).ToString


            If VaInt(IdLinea) > 0 Then


                'Si había línea anterior, desbloquear
                Dim IdLineaAnterior As String = lstLineas(pagina)

                If IdLineaAnterior <> IdLinea Then

                    If VaInt(IdLineaAnterior) > 0 Then
                        DesBloquearLineas(IdLineaAnterior)
                    End If


                    Dim BloqueoLineaFecha As New E_BloqueoLineaFecha(Idusuario, cn)
                    If Not BloqueoLineaFecha.LeerPorLineaFecha(IdLinea, TxFecha.Text, Idusuario.ToString) Then

                        BloqueoLineaFecha = New E_BloqueoLineaFecha(Idusuario, cn)
                        BloqueoLineaFecha.BLF_Id.Valor = BloqueoLineaFecha.MaxId()
                        BloqueoLineaFecha.BLF_Fecha.Valor = TxFecha.Text
                        BloqueoLineaFecha.BLF_IdLinea.Valor = IdLinea
                        BloqueoLineaFecha.BLF_IdUsuario.Valor = Idusuario.ToString
                        BloqueoLineaFecha.Insertar()


                        'Actualiza línea de la página
                        lstLineas(pagina) = IdLinea


                    End If


                Else
                    Refresca(paginaOrig)
                End If

            End If

        End If

    End Sub


    Private Sub DesBloquearLineas(IdLinea As String)

        If VaInt(IdLinea) > 0 Then

            Dim sql As String = "DELETE FROM BloqueoLineaFecha WHERE BLF_IdLinea = " & IdLinea & vbCrLf
            sql = sql & " AND BLF_IdUsuario = " & Idusuario.ToString & vbCrLf
            sql = sql & " AND BLF_Fecha > '" & VaDate("") & "'" & vbCrLf

            BloqueoLineaFecha.MiConexion.OrdenSql(sql)

        End If

    End Sub


    Private Sub Desbloquear(pagina As Integer)

        'Sólo para botón desbloquear

        If VaDate(TxFecha.Text) > VaDate("") Then

            pagina = pagina - 1

            Dim Cb As CbBox = LstCb(pagina)
            Dim IdLinea As String = VaInt(Cb.SelectedValue).ToString


            If VaInt(IdLinea) > 0 Then

                Cb.SelectedIndex = -1
                DesBloquearLineas(IdLinea)
                lstLineas(pagina) = 0

            End If

        End If



    End Sub


    'Private Sub DesBloqueoLineas(pagina As Integer, Optional IdLinea As String = "")

    '    If VaDate(TxFecha.Text) > VaDate("") Then

    '        pagina = pagina - 1

    '        If IdLinea.Trim = "" Then
    '            Dim Cb As CbBox = LstCb(pagina)
    '            IdLinea = VaInt(Cb.SelectedValue).ToString
    '        End If


    '        If VaInt(IdLinea) > 0 Then

    '            Dim sql As String = "DELETE FROM BloqueoLineaFecha WHERE BLF_IdLinea = " & IdLinea & vbCrLf
    '            sql = sql & " AND BLF_IdUsuario = " & Idusuario.ToString & vbCrLf
    '            sql = sql & " AND BLF_Fecha > '" & VaDate("") & "'" & vbCrLf

    '            BloqueoLineaFecha.MiConexion.OrdenSql(sql)

    '        End If

    '    End If

    'End Sub

    Private Sub btPartidasPendientesMuestrear_Click(sender As System.Object, e As System.EventArgs) Handles btPartidasPendientesMuestrear.Click

        Dim pagina As Integer = TabControl1.TabIndex

        Dim cb As CbBox = LstCb(pagina)
        Dim IdLinea As String = cb.SelectedValue.ToString & ""

        If VaInt(IdLinea) > 0 Then

            Dim frm As New FrmMuestreoPartidas(IdLinea)
            frm.Show()

        End If


    End Sub
End Class