Imports DevExpress.XtraEditors


Public Class FrmActualizarLineasSalidaPalets
    Inherits FrConsulta


    Dim AlbSalida_Lineas As New E_AlbSalida_lineas(Idusuario, cn)
    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)

   
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDesdeFecha, Nothing, LbDesdeFecha, False, Cdatos.TiposCampo.Fecha)
        ParamTx(TxHastaFecha, Nothing, LbHastaFecha, False, Cdatos.TiposCampo.Fecha)

    End Sub


    Private Sub FrmActualizarLineasSalidaPalets_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        BInforme.Visible = False
        GridView1.Appearance.HeaderPanel.BackColor = Color.Aquamarine


        BtAux.Text = "Actualizar"
        BtAux.Image = My.Resources.App_kservices_16x16_32
        BtAux.Visible = True

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        FechasPorDefecto()

    End Sub


    Private Sub FechasPorDefecto()

        TxDesdeFecha.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxHastaFecha.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        If VaDate(TxDesdeFecha.Text.Trim) = VaDate("") Or VaDate(TxHastaFecha.Text.Trim) = VaDate("") Then
            MsgBox("Debe introducir fechas válidas")
            Exit Sub
        End If


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(AlbSalida_Lineas.ASL_idlinea, "IdLinea")
        CONSULTA.SelCampo(AlbSalida_Lineas.ASL_idalbaran, "IdAlbaran")
        CONSULTA.SelCampo(AlbSalida.ASA_albaran, "Albaran", AlbSalida_Lineas.ASL_idalbaran, AlbSalida.ASA_idalbaran)
        CONSULTA.SelCampo(AlbSalida.ASA_fechasalida, "FechaSalida")
        CONSULTA.SelCampo(AlbSalida.ASA_ejercicio, "EJ")
        CONSULTA.SelCampo(AlbSalida.ASA_idcentro, "CE")
        CONSULTA.SelCampo(AlbSalida.ASA_idcliente, "CodCli")
        CONSULTA.SelCampo(Clientes.CLI_Nombre, "Cliente", AlbSalida.ASA_idcliente, Clientes.CLI_Codigo)
        CONSULTA.WheCampo(AlbSalida.ASA_fechasalida, ">=", TxDesdeFecha.Text)
        CONSULTA.WheCampo(AlbSalida.ASA_fechasalida, "<=", TxHastaFecha.Text)


        Dim sql As String = CONSULTA.SQL & vbCrLf & " ORDER BY IdLinea"


        Dim dt As DataTable = AlbSalida_Lineas.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            Dim colSel As New DataColumn("S", GetType(Boolean))
            colSel.DefaultValue = False
            dt.Columns.Add(colSel)

        End If


        Grid.DataSource = dt
        AjustaColumnas()

    End Sub


    Private Sub AjustaColumnas()

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "S"
                    c.MinWidth = 20
                    c.MaxWidth = 20
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            End Select
        Next


    End Sub


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()

        If XtraMessageBox.Show("¿Desea actualizar las líneas de palets?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim dt As DataTable = Grid.DataSource
            If Not IsNothing(dt) Then

                Dim cont As Integer = 0


                If dt.Rows.Count > 0 Then

                    ProgressBar1.Value = 0
                    ProgressBar1.Maximum = dt.Rows.Count - 1

                    For indice As Integer = 0 To dt.Rows.Count - 1

                        Dim row As DataRow = dt.Rows(indice)
                        If Not IsNothing(row) Then

                            If row("S") = True Then

                                Dim IdAlbaran As String = (row("IdAlbaran").ToString & "").Trim
                                Agro_asociarpaletsalineas(IdAlbaran)

                                cont = cont + 1

                            End If

                        End If


                        ProgressBar1.Value = indice

                    Next

                End If


                If cont = 0 Then
                    MsgBox("No hay registros marcados para actualizar")
                Else
                    MsgBox("Terminado! Se actualizaron " & cont.ToString & " registros")
                End If

            End If

        End If

    End Sub


    Private Sub btSelNinguno_Click(sender As System.Object, e As System.EventArgs) Handles btSelNinguno.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = False
            End If
        Next

    End Sub


    Private Sub btSelTodos_Click(sender As System.Object, e As System.EventArgs) Handles btSelTodos.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = True
            End If
        Next

    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

        If Not IsNothing(row) Then
            If column.FieldName.Trim.ToUpper = "S" Then
                row("S") = Not row("S")
            End If
        End If

    End Sub

End Class