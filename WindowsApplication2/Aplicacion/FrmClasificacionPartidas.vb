
Imports NetAgro.Cdatos
Imports System.Drawing

Imports DevExpress.XtraEditors


Public Enum ResultadoFormulario
    Guardar
    Cancelar
End Enum


Public Class FrmClasificacionPartidas


    Private Class stClaves_Clasificacion

        Public IdCat As Integer = 0
        Public Categoria As String = ""
        Public Porcentaje As Decimal = 0

        Public Sub New(IdCat As Integer, Categoria As String)
            Me.IdCat = IdCat
            Me.Categoria = Categoria
        End Sub

    End Class


    Private Class stDatos_Clasificacion

        Public Kilos As Decimal = 0
        Public KPartida As Decimal = 0

        Public Sub New(Kilos As Decimal, KPartida As Decimal)
            Me.Kilos = Kilos
            Me.KPartida = KPartida
        End Sub

    End Class


    Private _Resultado As ResultadoFormulario = ResultadoFormulario.Cancelar
    Public ReadOnly Property Resultado As ResultadoFormulario
        Get
            Return _Resultado
        End Get
    End Property



    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro
    Dim _ListaControles As New List(Of Object)


    Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim AlbEntrada_LineasCla As New E_AlbEntrada_lineascla(Idusuario, cn)


    Dim _IdLinea As String = ""
    Dim _IdGenero As String = ""
    Dim _IdAlbaran As String = ""
    'Dim _CampaCultivo As String = ""
    Dim _IdCultivo As String = ""
    Dim _IdAgricultor As String = ""
    Dim _Precio As Decimal = 0


    Dim _LineasDescripcion As New List(Of String)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(IdLinea As String)
        Me.New()


        _IdLinea = IdLinea


        Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        If AlbEntrada_Lineas.LeerId(_IdLinea) Then

            _IdGenero = AlbEntrada_Lineas.AEL_idgenero.Valor & ""
            _IdAlbaran = AlbEntrada_Lineas.AEL_idalbaran.Valor & ""

            TxObservaciones.Text = AlbEntrada_Lineas.AEL_observaciones.Valor
            TxObsProveedor.Text = AlbEntrada_Lineas.AEL_ObservacionesProveedor.Valor

            '_CampaCultivo = VaInt(AlbEntrada_Lineas.AEL_campacultivo.Valor).ToString
            _IdCultivo = VaInt(AlbEntrada_Lineas.AEL_idcultivo.Valor).ToString

        End If


    End Sub


    Private Sub ParametrosFrm()

        Dim param = New Cdatos.PropiedadesTx
        param.Obligatorio = False

        param.CampoBd = AlbEntrada_Lineas.AEL_observaciones
        param.Tipo = AlbEntrada_Lineas.AEL_observaciones.TipoBd
        param.Longitud = AlbEntrada_Lineas.AEL_observaciones.Longitud

        TxObservaciones.Orden = 0
        TxObservaciones.ClParam = param
        TxObservaciones.ClForm = Me


        param = New Cdatos.PropiedadesTx
        param.Obligatorio = False

        param.CampoBd = AlbEntrada_Lineas.AEL_ObservacionesProveedor
        param.Tipo = AlbEntrada_Lineas.AEL_ObservacionesProveedor.TipoBd
        param.Longitud = AlbEntrada_Lineas.AEL_ObservacionesProveedor.Longitud

        TxObsProveedor.Orden = 1
        TxObsProveedor.ClParam = param
        TxObsProveedor.ClForm = Me




    End Sub



    Private Sub FrmClasificacionPartidas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        GridEditable1.pnlDerecha.Visible = False


        CargaDatosPartida()

        CargaDatosClasificacionConfeccion()

        CargaCategoriasGenero()

        CargaHistorial()

        'CompruebaPartidaMuestreada()


    End Sub


    Private Sub CargaDatosPartida()

        If VaInt(_IdLinea) > 0 Then

            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_muestreo, "Partida")
            CONSULTA.SelCampo(AlbEntrada.AEN_IdAgricultor, "IdAgricultor", AlbEntrada_Lineas.AEL_idalbaran, AlbEntrada.AEN_IdAlbaran)
            CONSULTA.SelCampo(Agricultores.AGR_Nombre, "Agricultor", AlbEntrada.AEN_IdAgricultor, Agricultores.AGR_IdAgricultor)
            CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbEntrada_Lineas.AEL_idgenero, Generos.GEN_IdGenero)
            CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_kilosnetos, "Kilos")
            CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_precio, "Precio")
            CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_campacultivo, "CampaCultivo")
            CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idcultivo, "IdCultivo")
            CONSULTA.WheCampo(AlbEntrada_Lineas.AEL_idlinea, "=", _IdLinea)

            Dim sql As String = CONSULTA.SQL

            Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim row As DataRow = dt.Rows(0)
                    LbPartida.Text = row("Partida").ToString & ""
                    LbAgricultor.Text = row("Agricultor").ToString & ""
                    _IdAgricultor = (row("IdAgricultor").ToString & "").Trim
                    LbKilosEntrada.Text = VaInt(row("Kilos")).ToString("#,##0")
                    LbGenero.Text = row("Genero").ToString & ""
                    LbCultivo.Text = VaInt(row("CampaCultivo")).ToString("00") & VaInt(row("IdCultivo")).ToString("00000")

                    _Precio = VaDec(row("Precio"))

                End If
            End If

        End If



    End Sub


    Private Sub CargaDatosClasificacionConfeccion()

        If VaInt(_IdLinea) > 0 Then


            Dim totalkilos As Integer = 0
            Dim maxkilos As Integer = 0
            Dim maxindice As Integer = -1


            Dim dt As DataTable = AgClasifiPartida(_IdLinea)
            dt.Columns.Add("KPartida", GetType(Decimal))


            For indice As Integer = 0 To dt.Rows.Count - 1

                Dim rw As DataRow = dt.Rows(indice)

                Dim kilos As Integer = VaDec(LbKilosEntrada.Text) * VaDec(rw("porcentaje")) / 100
                If kilos > maxkilos Then
                    maxkilos = kilos
                    maxindice = indice
                End If

                totalkilos = totalkilos + kilos


                rw("KPartida") = kilos

            Next

            If maxindice >= 0 Then
                dt.Rows(maxindice)("KPartida") = dt.Rows(maxindice)("Kpartida") + VaDec(LbKilosEntrada.Text) - totalkilos
            End If



            GridConfeccion.DataSource = dt
            AjustaColumnas(GridViewConfeccion)


        End If


    End Sub


    Private Sub AjustaColumnas(g As DevExpress.XtraGrid.Views.Grid.GridView)


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In g.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "IDCAT"
                    c.Visible = False

            End Select
        Next

        g.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In g.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CATEGORIA"
                    c.Width = 300
                    If g IsNot GridEditable1.GridView Then
                        c.GroupIndex = 0
                    End If

                Case "NUMERO"
                    c.Width = 150

                Case "KILOS"
                    c.Width = 150
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n2}"

                Case "PORCENTAJE"
                    c.Width = 150
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    If g Is GridViewConfeccion Then
                        c.DisplayFormat.FormatString = "{0:n2}"
                    ElseIf g Is GridEditable1.GridView Then
                        c.DisplayFormat.FormatString = "P"
                    End If


                Case "KPARTIDA"
                    c.Width = 150
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n2}"

            End Select
        Next


        AñadeResumenCampo(g, "Kilos", "{0:n2}")
        AñadeResumenCampo(g, "KPartida", "{0:n2}")
        If g Is GridEditable1.GridView Then
            AñadeResumenCampo(g, "Porcentaje", "{0:P}", DevExpress.Data.SummaryItemType.Custom)
        End If


    End Sub


    Private Sub CargaCategoriasGenero()


        Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim SubFamilias As New E_Subfamilias(Idusuario, cn)

        If AlbEntrada_Lineas.LeerId(_IdLinea) Then
            If Generos.LeerId(AlbEntrada_Lineas.AEL_idgenero.Valor) Then

                If SubFamilias.LeerId(Generos.GEN_IdsubFamilia.Valor) Then

                    Dim IdFamilia As String = SubFamilias.SFA_idfamilia.Valor

                    If VaInt(IdFamilia) > 0 Then

                        Dim sql As String = "SELECT CAE_Id as IdCat, CAE_CategoriaCalibre as Categoria FROM familiascategorias" & vbCrLf
                        sql = sql & " LEFT JOIN categoriasentrada ON CAE_Id = FAC_IdCategoriaEntrada" & vbCrLf
                        sql = sql & " WHERE COALESCE(cae_id, 0) > 0" & vbCrLf
                        sql = sql & " AND FAC_IdFamilia = " & IdFamilia & vbCrLf
                        'sql = sql & " ORDER by CAE_CategoriaCalibre" & vbCrLf
                        sql = sql & " ORDER by FAC_IdCategoriaEntrada" & vbCrLf

                        Dim dt As DataTable = AlbEntrada_Lineas.MiConexion.ConsultaSQL(sql)
                        If Not IsNothing(dt) Then

                            dt.Columns.Add("Kilos", GetType(Decimal))
                            dt.Columns.Add("Porcentaje", GetType(Decimal))


                            dt.PrimaryKey = New DataColumn() {dt.Columns("IdCat")}


                            GridEditable1.DataSource = dt
                            AjustaColumnas(GridEditable1.GridView)

                            GridEditable1.Campo("Kilos", AlbEntrada_LineasCla.ALC_kilosnetos, True, True, True, True)


                        End If


                    End If

                End If

            End If


        End If


        

    End Sub


    'Private Sub CompruebaPartidaMuestreada()


    '    If VaInt(_IdLinea) > 0 Then


    '        Dim dtDestino As DataTable = CType(GridEditable1.Grid.DataSource, DataTable)

    '        If Not IsNothing(dtDestino) Then


    '            Dim sql As String = "SELECT ALC_IdCategoria as IdCategoria, ALC_KilosNetos as Kilos " & vbCrLf
    '            sql = sql & " FROM AlbEntrada_LineasCla WHERE ALC_IdLineaEntrada = " & _IdLinea

    '            Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
    '            If Not IsNothing(dt) Then

    '                For Each row As DataRow In dt.Rows

    '                    Dim IdCat As Integer = VaInt(row("IdCategoria"))
    '                    Dim Kilos As Decimal = VaDec(row("Kilos"))

    '                    Dim rowDestino As DataRow = dtDestino.Rows.Find(IdCat)
    '                    If Not IsNothing(rowDestino) Then
    '                        rowDestino("Kilos") = Kilos
    '                    End If

    '                Next

    '            End If

    '        End If



    '    End If



    'End Sub


    Private Sub BtPasarClasificacion_Click(sender As System.Object, e As System.EventArgs) Handles BtPasarClasificacion.Click

        If XtraMessageBox.Show("¿Desea pasar los kilos a la clasificación?", "PASAR KILOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            CalculaClasificacion()

        End If


    End Sub


    Private Function ObtenerClasificacion(ByRef Ajuste As Decimal, ByRef TotalKilosNetos As Decimal, ByRef TotalKilos As Decimal, ByRef Estandar As Decimal, bEdicion As Boolean) As DataTable

        TotalKilosNetos = 0
        TotalKilos = 0


        Ajuste = 1


        Dim acum As New Acumulador


        Dim dtClasif As DataTable = CType(GridEditable1.Grid.DataSource, DataTable)


        Dim dtConfeccion As DataTable = CType(GridConfeccion.DataSource, DataTable)
        If Not IsNothing(dtConfeccion) Then

            For Each row As DataRow In dtConfeccion.Rows

                Dim IdCat As Integer = VaInt(row("IdCat"))
                Dim Categoria As String = (row("Categoria").ToString & "").Trim
                Dim Kilos As Decimal = VaDec(row("Kilos"))
                Dim KPartida As Decimal = VaDec(row("KPartida"))


                Dim stClave As New stClaves_Clasificacion(IdCat, Categoria)
                Dim stDatos As New stDatos_Clasificacion(Kilos, KPartida)

                acum.Suma(stClave, stDatos)


                'If IdCat <> 500 Then
                TotalKilos = TotalKilos + KPartida
                TotalKilosNetos = TotalKilosNetos + KPartida
                'End If

            Next

        End If


        'Calcula el ajuste en caso de que haya estandar
        Estandar = ObtenerKilosEstandar()
        TotalKilosNetos = TotalKilosNetos - Estandar


        If bEdicion Then
            Dim KgDestrio As Decimal = ObtenerDestrioDestino(dtClasif)
            TotalKilosNetos = TotalKilosNetos - KgDestrio
            TotalKilos = TotalKilos - KgDestrio
        End If



        If TotalKilos <> 0 Then Ajuste = TotalKilosNetos / TotalKilos
        Ajuste = Math.Round(Ajuste, 4)



        Dim dt As DataTable = acum.DataTable
        If Not IsNothing(dt) Then

            dt.PrimaryKey = New DataColumn() {dt.Columns("IdCat")}

        End If



        Return dt


    End Function



    Private Function ObtenerKilosEstandar() As Decimal

        Dim Estandar As Decimal = 0


        For indice As Integer = 0 To GridEditable1.GridView.RowCount - 1

            Dim rowEstandar As DataRow = GridEditable1.GridView.GetDataRow(indice)
            If Not IsNothing(rowEstandar) Then

                Dim IdCat As Integer = VaInt(rowEstandar("IdCat"))

                If IdCat = 135 Then
                    Estandar = Estandar + VaDec(rowEstandar("Kilos"))
                End If

            End If

        Next


        Return Estandar

    End Function



    Private Function ObtenerCategoriaMayor(dt As DataTable) As Integer

        Dim cat_mayor As Integer = -1
        Dim kilos_mayor As Decimal = 0


        For Each row As DataRow In dt.Rows


            Dim IdCat As Integer = VaInt(row("IdCat"))
            Dim Kilos As Decimal = VaDec(row("Kilos"))

            If IdCat <> 500 And IdCat <> 135 Then

                If cat_mayor = -1 And Kilos > 0 Then

                    cat_mayor = IdCat
                    kilos_mayor = Kilos

                ElseIf cat_mayor > -1 Then

                    If Kilos > kilos_mayor Then
                        cat_mayor = IdCat
                        kilos_mayor = Kilos
                    End If

                End If

            End If

        Next


        Return cat_mayor

    End Function


    Private Function PasaKilos(dt As DataTable) As DataTable


        Dim dtDestino As DataTable = CType(GridEditable1.DataSource, DataTable).Copy


        If Not IsNothing(dtDestino) Then


            For Each row As DataRow In dtDestino.Rows

                Dim IdCat As Integer = VaInt(row("IdCat"))
                Dim rowAcum As DataRow = dt.Rows.Find(IdCat)
                If Not IsNothing(rowAcum) Then

                    Dim porcentaje As Decimal = 0
                    Dim kilos As Decimal = VaDec(rowAcum("Kilos"))
                    Dim Kpartida As Decimal = VaDec(rowAcum("Kpartida"))
                    row("Kilos") = Kpartida

                    If VaInt(LbKilosEntrada.Text) <> 0 Then porcentaje = Kpartida / VaInt(LbKilosEntrada.Text)
                    row("Porcentaje") = porcentaje

                End If
            Next


        End If


        Return dtDestino


    End Function


    Private Function RecalcularKilosEstandar(dt As DataTable, ajuste As Decimal, TotalKilosNetos As Decimal, cat_mayor As Integer) As DataTable


        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows

                Dim IdCat As Integer = VaInt(row("IdCat"))
                Dim rowAcum As DataRow = dt.Rows.Find(IdCat)
                If Not IsNothing(rowAcum) Then

                    Dim porcentaje As Decimal = 0
                    Dim kilos As Decimal = VaDec(rowAcum("Kilos"))

                    If IdCat <> 500 And IdCat <> 135 Then
                        kilos = VaInt(kilos * ajuste)
                    End If


                    If kilos <> 0 Then

                        row("Kilos") = kilos

                        If VaInt(LbKilosEntrada.Text) <> 0 Then porcentaje = kilos / VaInt(LbKilosEntrada.Text)
                        row("Porcentaje") = porcentaje

                    End If


                End If
            Next


            Dim resto As Decimal = 0

            For Each row As DataRow In dt.Rows

                Dim IdCat As Integer = VaInt(row("IdCat"))
                Dim Kilos As Decimal = VaDec(row("Kilos"))

                If IdCat <> 500 And IdCat <> 135 And IdCat <> cat_mayor Then
                    resto = resto + Kilos
                End If

            Next

            Dim rowMayor As DataRow = dt.Rows.Find(cat_mayor)
            If Not IsNothing(rowMayor) Then
                rowMayor("Kilos") = TotalKilosNetos - resto
            End If

        End If


        Return dt

    End Function



    Private Sub CalculaClasificacion()

        Dim TotalKilosNetos As Decimal = 0
        Dim TotalKilos As Decimal = 0
        Dim Estandar As Decimal = 0
        Dim Ajuste As Decimal = 1

        'Obtiene datos origen
        Dim dt As DataTable = ObtenerClasificacion(Ajuste, TotalKilosNetos, TotalKilos, Estandar, False)

        'Pasa los kilos del origen al destino
        Dim dtDestino As DataTable = PasaKilos(dt)

        Dim KgDestrio As Decimal = ObtenerDestrioDestino(dtDestino)
        TotalKilosNetos = TotalKilosNetos - KgDestrio
        TotalKilos = TotalKilos - KgDestrio

        If TotalKilos <> 0 Then Ajuste = TotalKilosNetos / TotalKilos
        Ajuste = Math.Round(Ajuste, 4)


        'Obtiene la categoría con más kilos para ajustar con prorrata
        Dim cat_mayor As Integer = ObtenerCategoriaMayor(dt)


        'Recalcula kilos en función del Estandar y calcula porcentajes
        If Estandar <> 0 Then
            dtDestino = RecalcularKilosEstandar(dtDestino, Ajuste, TotalKilosNetos, cat_mayor)
        End If


        GridEditable1.Grid.DataSource = dtDestino



    End Sub


    Private Function ObtenerDestrioDestino(dt As DataTable) As Decimal

        Dim res As Decimal = 0


        If Not IsNothing(dt) Then
            Dim row As DataRow = dt.Rows.Find(500)
            If Not IsNothing(row) Then
                res = VaDec(row("Kilos"))
            End If
        End If


        Return res

    End Function


    Private Sub BGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BGuardar.Click

        BGuardar.Enabled = False

        Try


            If Not CompruebaKilosClasificados() Then
                MsgBox("No se puede guardar la clasificación, se deben clasificar los mismos kilos de la entrada")
                Exit Sub
            End If


            If XtraMessageBox.Show("¿Desea guardar la clasificación de la partida?", "GUARDAR CLASIFICACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


                'Borramos primero la clasificación
                Dim sql As String = "DELETE FROM AlbEntrada_LineasCla WHERE ALC_IdLineaEntrada = " & _IdLinea
                AlbEntrada_LineasCla.MiConexion.OrdenSql(sql)


                Dim cont As Integer = 0

                'Crea ALbEntradaLineas_Cla
                For indice As Integer = 0 To GridEditable1.GridView.RowCount - 1
                    Dim row As DataRow = GridEditable1.GridView.GetDataRow(indice)
                    If Not IsNothing(row) Then

                        Dim IdCat As String = (row("IdCat").ToString & "").Trim
                        Dim Kilos As Decimal = VaDec(row("Kilos"))

                        If Kilos > 0 Then

                            Dim AlbEntrada_LineasCla As New E_AlbEntrada_lineascla(Idusuario, cn)
                            AlbEntrada_LineasCla.ALC_id.Valor = AlbEntrada_LineasCla.MaxId()
                            AlbEntrada_LineasCla.ALC_idlineaentrada.Valor = _IdLinea
                            AlbEntrada_LineasCla.ALC_idalbaran.Valor = _IdAlbaran
                            AlbEntrada_LineasCla.ALC_idgenero.Valor = _IdGenero
                            AlbEntrada_LineasCla.ALC_kilosnetos.Valor = Kilos.ToString
                            AlbEntrada_LineasCla.ALC_idcategoria.Valor = IdCat
                            AlbEntrada_LineasCla.ALC_precio.Valor = _Precio.ToString
                            AlbEntrada_LineasCla.Insertar()

                            cont = cont + 1

                        End If

                    End If

                Next


                If cont > 0 Then

                    'Guarda la partida con la fecha de muestreo (hoy)
                    'Al volver, recarga el grid de muestreo
                    Dim hoy As String = Today.ToString("dd/MM/yyyy")

                    Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
                    If AlbEntrada_Lineas.LeerId(_IdLinea) Then

                        AlbEntrada_Lineas.AEL_fechamuestreo.Valor = hoy
                        AlbEntrada_Lineas.AEL_observaciones.Valor = TxObservaciones.Text
                        AlbEntrada_Lineas.AEL_ObservacionesProveedor.Valor = TxObsProveedor.Text
                        AlbEntrada_Lineas.Actualizar()

                        If VaInt(AlbEntrada_Lineas.AEL_idalbaran.Valor) > 0 Then
                            Agro_GeneraAlbaranEntrada(VaInt(AlbEntrada_Lineas.AEL_idalbaran.Valor))
                        End If

                    End If




                    _Resultado = ResultadoFormulario.Guardar



                    MsgBox("Terminado!")


                    If XtraMessageBox.Show("¿Desea imprimir la clasificación?", "IMPRIMIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Imprimir(False)
                    End If


                    Me.Close()


                Else
                    MsgBox("No existe ninguna categoría con kilos")
                End If




            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        BGuardar.Enabled = True


    End Sub



    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click

        Me.Close()

    End Sub

    Private Sub Bsalir_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles GridEditable1.KeyDown, GridConfeccion.KeyDown, BtPasarClasificacion.KeyDown, Bsalir.KeyDown, BGuardar.KeyDown

        If e.KeyCode = Keys.F12 Then

            Bsalir.PerformClick()
            e.Handled = True

        ElseIf e.KeyCode = Keys.F10 Then

            BGuardar.PerformClick()
            e.Handled = True

        End If

    End Sub

    Private Sub TxObservaciones_Valida(edicion As System.Boolean) Handles TxObservaciones.Valida
        If edicion Then
            TxObsProveedor.Select()
            TxObsProveedor.Focus()
        End If
    End Sub


    Private Sub GridEditable1_CustomSummaryCalculate(sender As System.Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles GridEditable1.CustomSummaryCalculate

        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

            If e.IsGroupSummary Then

                Dim porcentaje As Decimal = 0

                Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item
                If item.FieldName.ToUpper.Trim = "PORCENTAJE" Then

                    Dim Kilos As Decimal = VaDec(GridEditable1.GridView.GetGroupSummaryValue(e.GroupRowHandle, GridEditable1.GridView.GroupSummary(2)))
                    If VaDec(LbKilosEntrada.Text) <> 0 Then porcentaje = Kilos / VaDec(LbKilosEntrada.Text)

                End If
                e.TotalValue = porcentaje

            End If


            If e.IsTotalSummary Then

                Dim porcentaje As Decimal = 0

                Dim item As DevExpress.XtraGrid.GridColumnSummaryItem = e.Item
                If item.FieldName.ToUpper.Trim = "PORCENTAJE" Then

                    Dim kilos As Decimal = 0

                    Dim colKilos As DevExpress.XtraGrid.Columns.GridColumn = GridEditable1.GridView.Columns.ColumnByFieldName("Kilos")
                    If Not IsNothing(colKilos) Then kilos = VaDec(colKilos.SummaryItem.SummaryValue)
                    If VaDec(LbKilosEntrada.Text) <> 0 Then porcentaje = kilos / VaDec(LbKilosEntrada.Text)

                End If
                e.TotalValue = porcentaje

            End If

        End If

    End Sub


    Private Function CompruebaKilosClasificados() As Boolean

        Dim bRes As Boolean = False


        Dim dt As DataTable = CType(GridEditable1.Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then

            Dim Clasificados As Decimal = VaDec(dt.Compute("SUM(Kilos)", ""))
            If Clasificados <> VaDec(LbKilosEntrada.Text) Then
                bRes = False
            Else
                bRes = True
            End If

        End If


        Return bRes

    End Function


    Private Sub GridEditable1_Valida(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn) Handles GridEditable1.Valida

        If Not IsNothing(row) Then

            Dim IdCat As Integer = VaInt(row("IdCat"))
            If IdCat = 135 Then

                Dim TotalKilosNetos As Decimal = 0
                Dim TotalKilos As Decimal = 0
                Dim Estandar As Decimal = 0
                Dim Ajuste As Decimal = 1


                Dim dtDestino As DataTable = CType(GridEditable1.DataSource, DataTable)


                'Obtiene datos origen
                Dim dt As DataTable = ObtenerClasificacion(Ajuste, TotalKilosNetos, TotalKilos, Estandar, True)

                'Obtiene la categoría con más kilos para ajustar con prorrata
                Dim cat_mayor As Integer = ObtenerCategoriaMayor(dtDestino)

                'Recalcula kilos en función del Estandar y calcula porcentajes
                If Estandar <> 0 Then
                    dtDestino = RecalcularKilosEstandar(dtDestino, Ajuste, TotalKilosNetos, cat_mayor)
                End If


                GridEditable1.Grid.DataSource = dtDestino

            End If

        End If

    End Sub



    Public Overridable Sub Imprimir(bPreliminar As Boolean)


        If IsNothing(GridEditable1.DataSource) Then
            MsgBox("No hay datos que imprimir")
            Exit Sub
        Else

            Try

                Application.DoEvents()

                Dim dt As DataTable = CType(GridEditable1.DataSource, DataTable)
                If dt.Rows.Count <= 0 Then
                    MsgBox("No hay datos que imprimir")
                    Exit Sub
                End If

                Application.DoEvents()

            Catch ex As Exception

            End Try

        End If


        Application.DoEvents()


        _LineasDescripcion.Clear()

        _LineasDescripcion.Add("Partida: " & LbPartida.Text)
        _LineasDescripcion.Add("Agricultor: " & LbAgricultor.Text)
        _LineasDescripcion.Add("Género: " & LbGenero.Text)
        _LineasDescripcion.Add("Kilos Entrada: " & LbKilosEntrada.Text)
        _LineasDescripcion.Add("Observaciones: " & TxObsProveedor.Text)
        _LineasDescripcion.Add(" ")



        If GridEditable1.Grid.IsPrintingAvailable Then

            Dim psu As New DevExpress.XtraPrinting.PrinterSettingsUsing
            psu.UsePaperKind = True
            psu.UseMargins = False

            prtSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            prtSystem.PageSettings.AssignDefaultPrinterSettings(psu)


            Dim bErrorMargen As Boolean = True
            Dim documento As DevExpress.XtraPrinting.PrintableComponentLink = CType(prtSystem.Links(0), DevExpress.XtraPrinting.PrintableComponentLink)
            documento.Component = GridEditable1.Grid


            documento.Margins.Top = 50
            documento.Margins.Right = 50
            documento.Margins.Bottom = 50
            documento.Margins.Left = 50


            Application.DoEvents()

            If bPreliminar Then
                documento.ShowPreview()
            Else
                Dim prn As New Printing.PrinterSettings
                Dim impresora As String = prn.PrinterName
                documento.Print(impresora)
            End If

            Application.DoEvents()

        End If

    End Sub


    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea

        Dim margen_izq_parametros As Integer = 10
        'Dim base_parametros As Integer = 10

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

                    'margen_izq_parametros = margen_izq_parametros + logo.Size.Width

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
            Dim nombrelistado As String = "LISTADO " & GridEditable1.Grid.Text & " - " & Now.ToString("dd/MM/yyyy")
            If Me.Text.Trim <> "" Then nombrelistado = Me.Text & " - " & Now.ToString("dd/MM/yyyy")

            'Espacio en blanco debajo del nombre del listado
            rec = New RectangleF(0, base, e.Graph.ClientPageSize.Width, 25)
            e.Graph.DrawString(nombrelistado, c, rec, DevExpress.XtraPrinting.BorderSide.None)

            base = base + 25


            If _LineasDescripcion.Count > 0 Then


                e.Graph.Font = New Font("Arial", 9, FontStyle.Regular)


                'Dim bp As Integer = base_parametros
                Dim bp As Integer = base
                Dim alineacion As DevExpress.Utils.HorzAlignment = DevExpress.Utils.HorzAlignment.Near
                Dim ancho As Integer = e.Graph.ClientPageSize.Width - margen_izq_parametros - 5

                For indice As Integer = 0 To _LineasDescripcion.Count - 1

                    If indice <= 12 Then

                        If indice = 6 Then
                            '2ª columna
                            ancho = ancho / 2
                            'margen_izq_parametros = margen_izq_parametros + ancho
                            'bp = base_parametros
                            bp = base
                            alineacion = DevExpress.Utils.HorzAlignment.Far

                        End If

                        Dim linea As String = _LineasDescripcion(indice)

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


    Private Sub BImprimir_Click(sender As System.Object, e As System.EventArgs) Handles BImpDirecta.Click

        Dim dt As DataTable = CType(GridEditable1.Grid.DataSource, DataTable)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Imprimir(False)

            Else
                MsgBox("No hay datos que imprimir")
            End If
        Else
            MsgBox("No hay datos que imprimir")
        End If



    End Sub

    
    Private Sub GridEditable1_ColumnaSiguiente(IndiceFila As System.Int32, IndiceColumna As System.Int32, ByRef NuevaFila As System.Int32, ByRef NuevaColumna As System.Int32) Handles GridEditable1.ColumnaSiguiente

        Try

            Dim rowActual As DataRow = GridEditable1.GridView.GetDataRow(IndiceFila)
            Dim colActual As DevExpress.XtraGrid.Columns.GridColumn = GridEditable1.GridView.GetVisibleColumn(IndiceColumna)

            If colActual.FieldName.ToUpper.Trim = "KILOS" Then
                GridEditable1_Valida(rowActual, colActual)
            End If


            NuevaColumna = IndiceColumna
            NuevaFila = IndiceFila + 1

        Catch ex As Exception

        End Try



    End Sub


    Private Sub BPreliminar_Click(sender As System.Object, e As System.EventArgs) Handles BPreliminar.Click

        Dim dt As DataTable = CType(GridEditable1.Grid.DataSource, DataTable)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Imprimir(True)

            Else
                MsgBox("No hay datos que imprimir")
            End If
        Else
            MsgBox("No hay datos que imprimir")
        End If

    End Sub


    Private Sub CargaHistorial()

        Dim dt As DataTable = Agro_HistorialCultivoAgricultor(_IdAgricultor, _IdCultivo, _IdGenero)
        GridHistorial.DataSource = dt

        AjustaColumnasHistorial()

    End Sub


    Private Sub AjustaColumnasHistorial()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewHistorial.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDGENERO", "GENERO", "IDLINEA"
            End Select
        Next

        GridViewHistorial.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewHistorial.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "PARTIDA"
                    c.Width = 80
                    c.MaxWidth = 80
                Case "FECHA"
                    c.MinWidth = 75
                    c.MaxWidth = 75
                    c.Width = 75
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case "PORCENKILOSA", "PORCENKILOSB", "PORCENKILOSC", "PORCENKILOSD", "PORCENDESTRIO"
                    c.MinWidth = 45
                    c.MaxWidth = 45
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.Caption = "%"
                Case "KILOSA", "KILOSB", "KILOSC", "KILOSD", "DESTRIO"
                    c.Caption = c.Caption.Replace("Kilos", "")
                    c.MinWidth = 85
                    c.MaxWidth = 85
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                Case "TOTAL"
                    c.MinWidth = 90
                    c.MaxWidth = 90
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                Case "OBSERVACIONES"

                
            End Select
        Next

    End Sub

    Private Sub GridViewHistorial_CustomColumnDisplayText(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridViewHistorial.CustomColumnDisplayText

        Dim col As String = e.Column.FieldName.ToUpper.Trim
        Select Case col
            Case "KILOSA", "KILOSB", "KILOSC", "DESTRIO", "PORCENKILOSA", "PORCENKILOSB", "PORCENKILOSC", "PORCENDESTRIO", "TOTAL"
                If VaDec(e.Value) = 0 Then
                    e.DisplayText = ""
                End If
        End Select

    End Sub

    Private Sub TxObsProveedor_Valida(edicion As Boolean) Handles TxObsProveedor.Valida
        If edicion Then
            BGuardar.Select()
            BGuardar.Focus()
        End If
    End Sub


    Private Sub GridViewHistorial_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridViewHistorial.RowCellStyle

        Dim row As DataRow = GridViewHistorial.GetDataRow(e.RowHandle)
        If Not IsNothing(row) Then
            If e.Column.FieldName.ToUpper.Trim = "PARTIDA" Then
                e.Appearance.BackColor = Color.Azure
            End If
        End If
        
    End Sub


    Private Sub GridViewHistorial_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridViewHistorial.DoubleClick

        If GridViewHistorial.FocusedColumn.FieldName.ToUpper.Trim = "PARTIDA" Then
            If Not IsNothing(GridViewHistorial.GetFocusedDataRow()) Then

                Dim row As DataRow = GridViewHistorial.GetFocusedDataRow()
                Dim IdLinea As String = (row("IdLinea").ToString & "").Trim

                Dim frm As New FrmDetalleMuestreoPartida(IdLinea)
                frm.ShowDialog()

            End If
        End If

    End Sub


    Private Sub btDocumental_Click(sender As System.Object, e As System.EventArgs) Handles btDocumental.Click

        If VaDec(_IdAlbaran) > 0 Then

            Dim fr As New FrDocs
            fr.Init(AlbEntrada.NombreBd, AlbEntrada.NombreTabla, _IdAlbaran)
            fr.ShowDialog()

        End If

    End Sub

End Class