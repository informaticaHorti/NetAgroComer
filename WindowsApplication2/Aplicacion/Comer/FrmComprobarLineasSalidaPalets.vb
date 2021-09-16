Imports DevExpress.XtraEditors


Public Class FrmComprobarLineasSalidaPalets
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


    Private Sub FrmComprobarLineasSalidaPalets_Load(sender As Object, e As System.EventArgs) Handles Me.Load

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
        CONSULTA.SelCampo(AlbSalida_Lineas.ASL_bultos, "Bultos")
        Dim oBultosPalets As New Cdatos.bdcampo("@(SELECT SUM(PLL_Bultos) FROM Palets_Lineas WHERE PLL_IdLineaSalida = ASL_IdLinea)", Cdatos.TiposCampo.Entero, 18)
        CONSULTA.SelCampo(oBultosPalets, "BultosPal")
        CONSULTA.WheCampo(AlbSalida.ASA_fechasalida, ">=", TxDesdeFecha.Text)
        CONSULTA.WheCampo(AlbSalida.ASA_fechasalida, "<=", TxHastaFecha.Text)


        Dim sql As String = CONSULTA.SQL & vbCrLf & " ORDER BY ASL_IdAlbaran"

        Dim dt As DataTable = AlbSalida_Lineas.MiConexion.ConsultaSQL(sql)

        If chkSoloErrores.Checked Then
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Dim dv As New DataView(dt)
                    dv.RowFilter = "Bultos <> BultosPal"
                    dt = dv.ToTable
                End If
            End If
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


    Protected Overrides Sub RowCellStyle(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn, sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        MyBase.RowCellStyle(row, column, sender, e)

        If Not IsNothing(row) Then

            Dim Bultos As Integer = VaInt(row("Bultos"))
            Dim BultosPal As Integer = VaInt(row("BultosPal"))

            If Bultos <> BultosPal Then
                e.Appearance.BackColor = Color.Red
            End If

        End If

    End Sub

    
End Class