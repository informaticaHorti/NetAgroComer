Imports DevExpress.XtraEditors


Public Class FrmPaletsRFID
    Inherits FrMantenimiento


    Dim Palets As New E_palets(Idusuario, cn)
    Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
    Dim AlbSalida_Palets As New E_albsalida_palets(Idusuario, cn)
    Dim Marca As New E_Marcas(Idusuario, cn)


    Private _bloquearKg As Boolean = True


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()


        BTaux1.Visible = True
        BTaux1.Text = "Imprimir"
        BTaux1.Image = PictureBox2.Image

    End Sub



    Private Sub ParametrosFrm()
        EntidadFrm = Palets


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxPalet, Palets.PAL_palet, LbPalet, True)
        TxPalet.Autonumerico = False
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxKgBrutos, Nothing, Lb4, True, Palets_Lineas.PLL_kilosbrutos.TipoBd, 0, Palets_Lineas.PLL_kilosbrutos.Longitud)

        AsociarControles(TxPalet, BtBuscaPalets, Palets.btBusca, Palets)



    End Sub


    Private Sub FrmPaletsRFID_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BModificar.Visible = False
        BAnular.Visible = False


        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsView.ShowGroupPanel = False

        Dim fuente As Font = GridView1.Appearance.Row.Font
        fuente = New Font(fuente.FontFamily, 13, FontStyle.Bold)
        GridView1.Appearance.Row.Font = fuente


    End Sub



    Public Overrides Sub ControlClave()

        ' componemos la clave
        Dim i As Integer
        If TxPalet.Text = "+" Then
            LbId.Text = "+"
        Else

            i = Palets.Leerpalet(MiMaletin.Ejercicio, MiMaletin.IdCentro, TxPalet.Text)

            If i > 0 Then

                'Controlar que el palet no esté cargado
                Dim sql As String = "SELECT COUNT(ASP_Id) FROM AlbSalida_Palets WHERE ASP_IdPalet = " & i.ToString
                Dim dt As DataTable = Palets.MiConexion.ConsultaSQL(sql)

                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 0 Then
                        Dim cont As Integer = VaInt(dt.Rows(0)(0))
                        If cont > 0 Then
                            MsgBox("El palet ya está cargado")
                            TxPalet.Select()
                            TxPalet.Focus()
                            Exit Sub
                        End If
                    End If
                End If

                If Palets.PAL_finalizado.Valor = "N" Then
                    MsgBox("Palet sin terminar")
                    TxPalet.Select()
                    TxPalet.Focus()
                    Exit Sub

                End If


                If VaInt(Palets.PAL_idcentro.Valor) <> MiMaletin.IdCentro Then
                    MsgBox("Palet de otro centro")
                    TxPalet.Select()
                    TxPalet.Focus()
                    Exit Sub

                End If



                LbId.Text = i.ToString



            Else
                MsgBox("El palet introducido no existe")
                TxPalet.Select()
                TxPalet.Focus()
            End If

        End If


    End Sub


    Public Overrides Sub Guardar()
        'MyBase.Guardar()

        'Guarda la línea actual

        '1) Calcula KgNetos y rectifica los KgBrutos y los KgNetos
        Dim KgNetos As Decimal = VaDec(TxKgBrutos.Text) - VaDec(LbTaraPalet.Text) - VaDec(LbTaraBultos.Text)


        Dim indice As Integer = GridView1.FocusedRowHandle
        Dim row As DataRow = GridView1.GetDataRow(indice)

        If Not IsNothing(row) Then

            Dim IdLinea As String = (row("IdLinea").ToString & "").Trim
            Dim Bultos As Integer = VaInt(row("Bultos"))

            Dim IdPalet As String = ""


            Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
            If Palets_Lineas.LeerId(IdLinea) Then

                Palets_Lineas.PLL_kilosbrutos.Valor = VaDec(TxKgBrutos.Text).ToString
                Palets_Lineas.PLL_kilosnetos.Valor = KgNetos.ToString

                Dim PesoFijo As String = ""
                Dim merma As Decimal = ObtenerMerma(Palets_Lineas, PesoFijo)
                Palets_Lineas.PLL_Merma.Valor = merma.ToString


                If PesoFijo <> "S" Then
                    Palets_Lineas.PLL_kiloscliente.Valor = KgNetos.ToString
                End If


                IdPalet = (Palets_Lineas.PLL_idpalet.Valor & "").Trim

                Palets_Lineas.Actualizar()


                If VaDec(IdPalet) > 0 Then
                    Dim Palets As New E_palets(Idusuario, cn)
                    If Palets.LeerId(IdPalet) Then
                        Palets.PAL_Flejado.Valor = "S"
                        Palets.Actualizar()
                    End If
                End If


                '2) Actualizar Palets_traza
                ActualizaPalets_Traza(IdLinea, KgNetos, Bultos)


                '3) Impresión RFID
                If XtraMessageBox.Show("¿Desea imprimir la etiqueta?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    EnviaImprimir()
                End If


            End If



        End If



        'Si hay más líneas, pasamos a la siguiente línea
        If GridView1.RowCount = 1 Or indice = GridView1.RowCount - 1 Then
            BorraPan()
        ElseIf indice < GridView1.RowCount - 1 Then

            indice = indice + 1

            'Recarga datos
            CargaLineasPalet(LbId.Text)

            GridView1.FocusedRowHandle = indice

            Dim rowSig As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(rowSig) Then
                MuestraDatos(rowSig, indice)
            End If

        End If





    End Sub


    Private Function ObtenerMerma(Palets_Lineas As E_palets_lineas, ByRef PesoFijo As String) As Decimal


        Dim IdGensal As String = (Palets_Lineas.PLL_idgensal.Valor & "").Trim
        Dim KilosNetos As Decimal = VaDec(Palets_Lineas.PLL_kilosnetos.Valor)
        Dim KilosCliente As Decimal = VaDec(Palets_Lineas.PLL_kiloscliente.Valor)
        'Dim KilosTeoricos As Decimal = VaDec(Palets_Lineas.PLL_bultos.Valor) * VaDec(Palets_Lineas.PLL_kilosxbulto)


        Dim merma As Decimal = 0
        'Dim PesoFijo As String = ""


        If VaInt(IdGensal) > 0 Then

            Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
            If GenerosSalida.LeerId(IdGensal) Then
                PesoFijo = (GenerosSalida.GES_PesoFijo.Valor & "").Trim
            End If

            If PesoFijo = "S" Then
                merma = KilosNetos - KilosCliente
            Else
                merma = 0
            End If

        End If




        Return merma

    End Function


    Private Sub ActualizaPalets_Traza(IdLinea As String, KgNetos As Decimal, Bultos As Integer)


        Dim Palets_Traza As New E_palets_traza(Idusuario, cn)


        '1) Calcula los kilos para actualizar Palets_traza
        Dim KxB As Decimal = 0
        If Bultos <> 0 Then KxB = KgNetos / Bultos


        '2) Busca los registros de Palets_traza de la línea de palet y actualiza
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Palets_Traza.PLT_idtraza, "Id")
        consulta.WheCampo(Palets_Traza.PLT_idlineapalet, "=", IdLinea)

        Dim sql As String = consulta.SQL
        Dim dt As DataTable = Palets_Traza.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows

                Dim Id As String = (row("Id").ToString & "").Trim
                If Palets_Traza.LeerId(Id) Then

                    Dim Bultos_Traza As Integer = VaInt(Palets_Traza.PLT_bultos.Valor)
                    Dim Kilos As Decimal = Bultos_Traza * KxB

                    Palets_Traza.PLT_kilos.Valor = Kilos.ToString
                    Palets_Traza.Actualizar()

                End If

            Next

        End If

    End Sub



    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbTaraPalet.Text = ""
        LbTaraBultos.Text = ""

        Grid.DataSource = Nothing
        GridView1.Columns.Clear()

        _bloquearKg = True
        Modificando = False

    End Sub


    Private Function Dtpalet(idpalet As String) As DataTable
        Dim ret As New DataTable
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Palets_Lineas.PLL_idlinea, "IdLinea")
        consulta.SelCampo(GenerosSalida.GES_DescripcionAlb, "Presentacion", Palets_Lineas.PLL_idgensal, GenerosSalida.GES_Idgensal)
        consulta.SelCampo(Palets_Lineas.PLL_categoria, "Categoria")
        consulta.SelCampo(Marca.MAR_Nombre, "Marca", Palets_Lineas.PLL_idmarca, Marca.MAR_Idmarca)
        consulta.SelCampo(Palets_Lineas.PLL_bultos, "Bultos")
        consulta.SelCampo(Palets_Lineas.PLL_kilosbrutos, "KgBrutos")
        consulta.SelCampo(Palets_Lineas.PLL_kilosnetos, "KgNetos")
        consulta.SelCampo(Palets_Lineas.PLL_idtipoconfeccion, "IdConfeccion")
        consulta.WheCampo(Palets_Lineas.PLL_idpalet, "=", idpalet)

        Dim sql As String = consulta.SQL & vbCrLf

        ret = Palets.MiConexion.ConsultaSQL(sql)

        Return ret

    End Function
    Private Sub CargaLineasPalet(IdPalet As String)

        Grid.DataSource = Nothing
        GridView1.Columns.Clear()


        Grid.DataSource = Dtpalet(IdPalet)

        AjustaColumnas()


    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim
                Case "IDLINEA", "IDCONFECCION"
                    c.Visible = False
            End Select


            GridView1.BestFitColumns()


            Select Case c.FieldName.ToUpper.Trim
                Case "CATEGORIA"
                    c.Width = 150
                Case "BULTOS", "KGBRUTOS"
                    c.Width = 90
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                Case "MARCA"
                    c.Width = 100
            End Select

        Next

    End Sub


    Public Overrides Sub Entidad_a_Datos()

        _bloquearKg = False
        MyBase.Entidad_a_Datos()


        CargaLineasPalet(LbId.Text)


        If GridView1.RowCount = 1 Then
            Dim row As DataRow = GridView1.GetDataRow(0)
            If Not IsNothing(row) Then
                MuestraDatos(row, 0)
            End If
        End If


    End Sub


    Protected Overrides Sub BloquearCampos(ByVal Bloqueo As Boolean)

        Dim x As Integer
        For x = 0 To ListaControles.Count - 1
            If x > CampoClave Then

                If ListaControles(x) Is TxKgBrutos Then
                    If _bloquearKg Then
                        ListaControles(x).enabled = False
                    Else
                        ListaControles(x).enabled = True
                    End If
                Else
                    ListaControles(x).enabled = Not Bloqueo
                End If

            End If
        Next

    End Sub


    Private Sub MuestraDatos(row, indice)


        If Not IsNothing(row) Then

            LbTaraPalet.Text = ""
            LbTaraBultos.Text = ""
            TxKgBrutos.Text = ""


            If indice >= 0 Then

                Dim TaraPalet As Decimal = 0
                Dim TaraBultos As Decimal = 0
                Dim Bultos As Integer = VaInt(row("Bultos"))
                Dim KgBrutos As Decimal = VaDec(row("KgBrutos"))
                Dim IdConfeccion As String = (row("IdConfeccion").ToString & "").Trim


                'Tara palet
                If indice = 0 Then
                    'Muestra tara palet sólo en la primera fila
                    Dim IdTipoPalet As String = Palets.PAL_idtipopalet.Valor
                    TaraPalet = ObtenerTaraPalet(IdTipoPalet)
                End If

                'Tara línea
                Dim Confecenvase As New E_ConfecEnvase(Idusuario, cn)
                If Confecenvase.LeerId(IdConfeccion) = True Then
                    TaraBultos = TaraBultos + VaDec(Confecenvase.CEV_TotalTara.Valor) * VaDec(Bultos)
                End If


                LbTaraPalet.Text = TaraPalet.ToString("#,##0.00")
                LbTaraBultos.Text = TaraBultos.ToString("#,##0.00")

                TxKgBrutos.Text = KgBrutos.ToString("#,##0")
                TxKgBrutos.Validar(False)


                TxKgBrutos.Enabled = True
                Modificando = True
                TxKgBrutos.Select()
                TxKgBrutos.Focus()


            End If


        End If

        _bloquearKg = False





    End Sub


    Private Function ObtenerTaraPalet(IdTipoPalet As String) As Decimal

        Dim TotalTara As Decimal = 0


        If VaInt(IdTipoPalet) > 0 Then

            Dim sql As String = "SELECT SUM(Tara) AS TotalTara" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & " SELECT CPA_IncrementoTara as Tara " & vbCrLf
            sql = sql & " FROM Confecpalet" & vbCrLf
            sql = sql & " WHERE CPA_IdConfec = " & IdTipoPalet & vbCrLf
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " SELECT COALESCE(CPL_Cantidad,0) * COALESCE(ENV_TaraSalida,0) as Tara" & vbCrLf
            sql = sql & " FROM ConfecPaletLineas" & vbCrLf
            sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = CPL_IdMaterial" & vbCrLf
            sql = sql & " WHERE CPL_IdConfec = " & IdTipoPalet & vbCrLf
            sql = sql & " ) AS T" & vbCrLf

            Dim dt As DataTable = Palets.MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    TotalTara = Math.Round(VaDec(dt.Rows(0)("TotalTara")), 2)
                End If
            End If


        End If


        Return TotalTara

    End Function


    Private Sub GridView1_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick

        Dim indice As Integer = GridView1.FocusedRowHandle
        Dim row As DataRow = GridView1.GetDataRow(indice)

        MuestraDatos(row, indice)


    End Sub


    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        Dim indice As Integer = GridView1.FocusedRowHandle
        Dim row As DataRow = GridView1.GetDataRow(indice)

        MuestraDatos(row, indice)

    End Sub


    Private Sub FrmPaletsRFID_DespuesDeSiguiente(Orden As System.Int32) Handles MyBase.DespuesDeSiguiente

        If Orden = TxPalet.Orden Then

            If VaInt(LbId.Text) > 0 Then

                If GridView1.RowCount = 1 Then
                    TxKgBrutos.Select()
                    TxKgBrutos.Focus()
                End If

            End If

        End If

    End Sub



    Private Sub FrmPaletsRFID_AccionTerminada(ByRef TipoAccion As NetAgro.FrMantenimiento.TipoMantenimiento) Handles MyBase.AccionTerminada

        If TipoAccion = TipoMantenimiento.Guardar Then


            If GridView1.RowCount = 0 Then
                TxPalet.Select()
                TxPalet.Focus()
            Else
                TxKgBrutos.Select()
                TxKgBrutos.Focus()
            End If
            

        End If

    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()


        EnviaImprimir()


    End Sub


    Private Sub EnviaImprimir()

        If VaInt(LbId.Text) > 0 Then


            ImprimirPaletRFID(LbId.Text)

        End If

    End Sub



End Class