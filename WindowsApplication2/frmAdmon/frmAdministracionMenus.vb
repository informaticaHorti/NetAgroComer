Imports DevExpress.XtraBars

Public Class frmAdministracionMenus

    Private err As New Errores


    Private Perfiles As New E_Perfiles(Idusuario, Cncomun)
    Private PerfilCb As New E_Perfiles(Idusuario, Cncomun)
    Private LogMenu As New E_LogMenu(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()


    End Sub


    Private Sub ParametrosFrm()

        EntidadFrm = Perfiles


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato_1, Perfiles.IdPerfil, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamCbFIJO(CbPerfiles, PerfilCb.IdPerfil, Perfiles.TablaPerfiles(), Lb2)


        AsociarControles(TxDato_1, BtBusca_1, Perfiles.btBusca, Perfiles, Perfiles.Nombre, Lb_1)


        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me
        BotonesAvance1.Filtro = "IdPerfil > 0"

    End Sub


    Private Sub TxDato_1_Valida(edicion As System.Boolean) Handles TxDato_1.Valida

        If Perfiles.LeerId(TxDato_1.Text) Then
            LbId.Text = Perfiles.IdPerfil.Valor
        Else
            LbId.Text = ""
        End If

    End Sub


    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()

        SqlGrid(LbId.Text)

    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MyBase.BModificar_Click(sender, e)

        Modificando = True
    End Sub


    Private Sub frmAdministracionMenus_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsView.AllowCellMerge = True
        'Grid.Enabled = False


        Dim TextoError As String = ""
        Dim dtBotones As DataTable = ObtenerBotonesMenu(Me.MdiParent, TextoError)
        If TextoError.Trim <> "" Then
            err.Muestraerror("Error al obtener los permisos del menú", "frmAdministracionMenus_Load", TextoError)
            Exit Sub
        End If

        Grid.DataSource = dtBotones



        If Not IsNothing(GridView1.Columns.ColumnByFieldName("NombreControl")) Then GridView1.Columns.ColumnByFieldName("NombreControl").Visible = False
        If Not IsNothing(GridView1.Columns.ColumnByFieldName("NombreBoton")) Then GridView1.Columns.ColumnByFieldName("NombreBoton").Caption = "Elemento del menú"

        If Not IsNothing(GridView1.Columns.ColumnByFieldName("S")) Then
            GridView1.Columns.ColumnByFieldName("S").OptionsColumn.AllowEdit = False
            GridView1.Columns.ColumnByFieldName("S").Width = 20
            GridView1.Columns.ColumnByFieldName("S").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            GridView1.Columns.ColumnByFieldName("S").OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False
        End If


    End Sub


    Private Sub GridView1_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick

        Dim row As System.Data.DataRow
        row = GridView1.GetDataRow(e.RowHandle)

        If e.Column.FieldName.ToUpper = "S" And e.Column.OptionsColumn.AllowEdit Then

            If row("S") = False Then
                row("S") = True
            Else
                row("S") = False
            End If

        End If


    End Sub



    Public Sub SqlGrid(IdPerfil As Integer)

        Dim DcBotonesActivos As New Dictionary(Of String, String)


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(LogMenu.LOM_Id, "Id")
        CONSULTA.SelCampo(LogMenu.LOM_NombreBoton, "NombreBoton")
        CONSULTA.WheCampo(LogMenu.LOM_IdPerfil, "=", IdPerfil.ToString)

        Dim sql As String = CONSULTA.SQL
        Dim dt As DataTable = LogMenu.MiConexion.ConsultaSQL(sql)

        For Each row As DataRow In dt.Rows
            Dim boton As String = row("NombreBoton").ToString
            DcBotonesActivos(boton.ToLower.Trim) = boton.ToLower.Trim
        Next


        For indice As Integer = 0 To GridView1.RowCount - 1

            Dim rowGrid As DataRow = GridView1.GetDataRow(indice)
            Dim boton As String = rowGrid("NombreControl").ToString & ""

            If DcBotonesActivos.ContainsKey(boton.ToLower.Trim) Then
                rowGrid("S") = True
            Else
                rowGrid("S") = False
            End If

        Next


    End Sub




    Public Overrides Sub ControlClave()
        LbId.Text = TxDato_1.Text
    End Sub


    Public Overrides Sub Guardar()
        'MyBase.Guardar()


        'Borra permisos para perfil
        LogMenu.BorrarPermisosPerfil(VaInt(TxDato_1.Text))


        'Añade los permisos individualmente
        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim boton As String = GridView1.GetDataRow(indice)("NombreControl").ToString & ""
            If GridView1.GetDataRow(indice)("S") = True Then
                LogMenu.AñadirPermisosPerfil(VaInt(TxDato_1.Text), boton.ToLower.Trim)
            End If
        Next

        BorraPan()

    End Sub


    Public Overrides Sub Modificar()
        'MyBase.Modificar()

        If VaInt(LbId.Text) > 0 Then
            If Not IsNothing(GridView1.Columns.ColumnByFieldName("S")) Then GridView1.Columns.ColumnByFieldName("S").OptionsColumn.AllowEdit = True
            CbPerfiles.Enabled = True
            'Grid.Enabled = True
        End If

    End Sub


    Public Overrides Sub Anular()
        'MyBase.Anular()

        If MsgBox("Desea anular el registro", vbYesNo) = vbYes Then
            LogMenu.BorrarPermisosPerfil(VaInt(TxDato_1.Text))
            BorraPan()
        End If

    End Sub


    Public Overrides Sub Salir()
        'MyBase.Salir()

        If LbId.Text.Trim = "" Then
            Me.Close()
        Else
            TxDato_1.Text = ""
            LbId.Text = ""
            Perfiles.VaciaEntidad()
            BorraPan()
        End If


    End Sub


    Private Sub BtSelTodos_Click(sender As System.Object, e As System.EventArgs) Handles BtSelTodos.Click

        If Not IsNothing(GridView1.Columns.ColumnByFieldName("S")) Then
            If GridView1.Columns.ColumnByFieldName("S").OptionsColumn.AllowEdit Then
                For indice As Integer = 0 To GridView1.RowCount - 1
                    Dim row As DataRow = GridView1.GetDataRow(indice)
                    row("S") = True
                Next
            End If
        End If

    End Sub

    Private Sub BtSelNinguno_Click(sender As System.Object, e As System.EventArgs) Handles BtSelNinguno.Click

        If Not IsNothing(GridView1.Columns.ColumnByFieldName("S")) Then
            If GridView1.Columns.ColumnByFieldName("S").OptionsColumn.AllowEdit Then
                For indice As Integer = 0 To GridView1.RowCount - 1
                    Dim row As DataRow = GridView1.GetDataRow(indice)
                    row("S") = False
                Next
            End If
        End If

    End Sub


    Public Overrides Sub BorraPan()

        MyBase.BorraPan()

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            row("S") = False
        Next

        'Grid.Enabled = False
        If Not IsNothing(GridView1.Columns.ColumnByFieldName("S")) Then GridView1.Columns.ColumnByFieldName("S").OptionsColumn.AllowEdit = False
        Lb_1.Text = ""
        LbId.Text = ""
        TxDato_1.Text = ""
        CbPerfiles.Enabled = False

    End Sub

    
    Private Sub CbPerfiles_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbPerfiles.SelectedIndexChanged

        Dim IdPerfilOrigen As Integer = VaInt(CbPerfiles.SelectedValue)
        If IdPerfilOrigen > 0 Then

            SqlGrid(IdPerfilOrigen.ToString)

        End If


    End Sub

   

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        If IsNothing(Grid.DataSource) Then
            MsgBox("No hay datos que imprimir")
            Exit Sub
        Else

            Try

                Application.DoEvents()

                Dim dt As DataTable = CType(Grid.DataSource, DataTable)
                If dt.Rows.Count <= 0 Then
                    MsgBox("No hay datos que imprimir")
                    Exit Sub
                End If

                Application.DoEvents()

            Catch ex As Exception

            End Try

        End If


        Application.DoEvents()


        If Grid.IsPrintingAvailable Then

            Dim psu As New DevExpress.XtraPrinting.PrinterSettingsUsing
            psu.UsePaperKind = True
            psu.UseMargins = False

            prtSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            prtSystem.PageSettings.AssignDefaultPrinterSettings(psu)


            Dim bErrorMargen As Boolean = True
            Dim imprime As DevExpress.XtraPrinting.PrintableComponentLink = CType(prtSystem.Links(0), DevExpress.XtraPrinting.PrintableComponentLink)


            imprime.Margins.Top = 50
            imprime.Margins.Right = 50
            imprime.Margins.Bottom = 50
            imprime.Margins.Left = 50


            Application.DoEvents()

            imprime.ShowPreview()

            Application.DoEvents()

        End If

    End Sub
End Class
