Public Class FrmAdministracionMenusPorPerfiles

    Private err As New Errores()
    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro

    Private Perfiles As New E_Perfiles(Idusuario, CnComun)
    Private LogMenu As New E_LogMenu(Idusuario, cn)

    Private bCargado As Boolean = False



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub FrmAdministracionMenusPorPerfiles_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsBehavior.Editable = False

        Dim TextoError As String = ""
        Dim dtBotones As DataTable = ObtenerBotonesMenu(Me.MdiParent, TextoError)
        If TextoError.Trim <> "" Then
            err.Muestraerror("Error al obtener los permisos del menú", "frmAdministracionMenusPorPerfiles_Load", TextoError)
            Exit Sub
        End If


        For Each row As DataRow In dtBotones.Rows

            Dim Pestaña As String = (row("Pestaña").ToString & "").Trim
            Dim Grupo As String = (row("Grupo").ToString & "").Trim
            Dim Nombre As String = (row("NombreBoton").ToString & "").Trim

            row("NombreBoton") = Pestaña & " / " & Grupo & " / " & Nombre

        Next

        CbFormularios.DataSource = dtBotones
        CbFormularios.DisplayMember = "NombreBoton"
        CbFormularios.ValueMember = "NombreControl"


        CargaGrid()

        bCargado = True


    End Sub


    Private Sub CargaGrid()

        Dim formulario As String = CbFormularios.SelectedValue
        If Not IsNothing(formulario) Then

            Dim dt As DataTable = Perfiles.TablaPerfiles

            Dim ColSel As New DataColumn("S", GetType(Boolean))
            ColSel.DefaultValue = False
            dt.Columns.Add(ColSel)


            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(LogMenu.LOM_IdPerfil, "IdPerfil")
            CONSULTA.WheCampo(LogMenu.LOM_NombreBoton, "=", formulario.ToLower.Trim)
            Dim sql As String = CONSULTA.SQL

            Dim dtPermisos As DataTable = LogMenu.MiConexion.ConsultaSQL(sql)
            Dim DcPermisos As New Dictionary(Of Integer, Integer)

            For Each row As DataRow In dtPermisos.Rows
                Dim IdPerfil As Integer = VaInt(row("IdPerfil"))
                DcPermisos(IdPerfil) = IdPerfil
            Next


            For Each row As DataRow In dt.Rows
                Dim IdPerfil As Integer = VaInt(row("Id"))
                If DcPermisos.ContainsKey(IdPerfil) Then
                    row("S") = True
                End If
            Next


            Grid.DataSource = dt
            AjustaColumnas()

        End If

    End Sub



    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "ID"
                    c.Visible = False
            End Select
        Next


        GridView1.BestFitColumns()
        

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "S"
                    c.MinWidth = 30
                    c.MaxWidth = 30
            End Select
        Next



    End Sub


    Private Sub BGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BGuardar.Click
        ActualizaPermisos()
    End Sub


    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub


    Private Sub CbFormularios_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbFormularios.SelectedIndexChanged

        If bCargado Then
            CargaGrid()
        End If

    End Sub


    Private Sub GridView1_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick

        If e.Column.FieldName.Trim.ToUpper = "S" Then
            Dim row As DataRow = GridView1.GetDataRow(e.RowHandle)
            If Not IsNothing(row) Then

                If row("S") = True Then
                    row("S") = False
                Else
                    row("S") = True
                End If

            End If
        End If

    End Sub


    Private Sub ActualizaPermisos()

        Dim NombreBoton As String = CbFormularios.SelectedValue & ""

        If NombreBoton.Trim <> "" Then

            Dim sql As String = "DELETE FROM LogMenu WHERE LOM_NombreBoton = '" & NombreBoton & "'"
            LogMenu.MiConexion.ConsultaSQL(sql)

            For indice As Integer = 0 To GridView1.RowCount - 1
                Dim row As DataRow = GridView1.GetDataRow(indice)
                If Not IsNothing(row) Then
                    If row("S") Then

                        Dim IdPerfil As String = VaInt(row("Id")).ToString
                        Dim LogMenu As New E_LogMenu(Idusuario, cn)
                        LogMenu.LOM_Id.Valor = LogMenu.MaxId()
                        LogMenu.LOM_NombreBoton.Valor = NombreBoton
                        LogMenu.LOM_IdPerfil.Valor = IdPerfil
                        LogMenu.Insertar()

                    End If
                End If
            Next

            
        End If

        MsgBox("Cambios guardados!")

        

    End Sub

    
    Private Sub BtSelTodos_Click(sender As System.Object, e As System.EventArgs) Handles BtSelTodos.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = True
            End If
        Next

    End Sub

    Private Sub BtSelNinguno_Click(sender As System.Object, e As System.EventArgs) Handles BtSelNinguno.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = False
            End If
        Next

    End Sub
End Class