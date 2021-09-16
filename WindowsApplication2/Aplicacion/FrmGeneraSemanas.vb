
Public Class FrmGeneraSemanas

    Inherits FrConsulta



    Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato3, Nothing, Lb3, True, Cdatos.TiposCampo.Fecha, True)
        ParamTx(TxDato4, Nothing, Lb4, True, Cdatos.TiposCampo.Fecha, True)
        ParamTx(TxDato1, Nothing, Lb1, True, Cdatos.TiposCampo.EnteroPositivo, 0, 2)
        ParamTx(TxDato5, Nothing, Lb5, True, Cdatos.TiposCampo.EnteroPositivo, 0, 2)
        ParamTx(TxDato2, Nothing, Lb2, True, Cdatos.TiposCampo.EnteroPositivo, 0, 1)




    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        FechasPorDefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxDato3.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato4.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Private Sub FrmExtractoEnvasesPorMaterial_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        BInforme.Visible = False
        BtAux.Visible = True
        BtAux.Text = "Generar"

     

        '  GridView1.Appearance.GroupRow.Font = nueva_fuente

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub



    Private Sub CargaGrid()


        If IsDate(TxDato3.Text) = False Or IsDate(TxDato4.Text) = False Then Exit Sub

        Dim Dt As New DataTable
        Dt.Columns.Add("Año", GetType(Int32))
        Dt.Columns.Add("Semana", GetType(Int32))
        Dt.Columns.Add("Defecha", GetType(Date))
        Dt.Columns.Add("AFecha", GetType(Date))
        Dt.Columns.Add("DefechaSalida", GetType(Date))
        Dt.Columns.Add("AFechaSalida", GetType(Date))
        Dim Año As Integer = VaInt(Mid(TxDato3.Text, 7, 4))
        Dim u As Integer = VaInt(TxDato5.Text)
        Dim s As Integer = VaInt(TxDato1.Text)
        Dim v As Integer = VaInt(TxDato2.Text)
        Dim f As Date = CDate(TxDato3.Text)
        While f < CDate(TxDato4.Text)
            Dt.Rows.Add(Año, s, f, f.AddDays(6), f.AddDays(v), f.AddDays(v + 6))
            f = f.AddDays(7)
            If s = u Then
                s = 0
                Año = Año + 1
            End If
            s = s + 1

        End While

        Grid.DataSource = Dt
        AjustaColumnas()



    End Sub


    Private Sub AjustaColumnas()


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

            

            End Select

        Next


    End Sub


    Private Sub BtAux_Click(sender As System.Object, e As System.EventArgs) Handles BtAux.Click

        'If Mid(TxDato3.Text, 7, 4) <> Mid(TxDato4.Text, 7, 4) Then
        '    MsgBox("Solo se pueden generar semanas dentro del mismo año. Revise las fechas")
        '    Exit Sub
        'End If
        If MsgBox("Desea generar las semanas ", vbYesNo) = vbNo Then Exit Sub
      
        Dim sql As String = "Delete from semanaspartes where sev_ejercicio=" + MiMaletin.Ejercicio.ToString
        SemanasPartes.MiConexion.OrdenSql(sql)
        Dim dt As New DataTable
        dt = Grid.DataSource
        For Each rw In dt.Rows
            Dim id As Integer = SemanasPartes.MaxId
            SemanasPartes.VaciaEntidad()
            SemanasPartes.SEV_IdSemana.Valor = id
            SemanasPartes.SEV_Ejercicio.Valor = MiMaletin.Ejercicio.ToString
            SemanasPartes.SEV_Ano.Valor = rw("Año").ToString
            SemanasPartes.SEV_Semana.Valor = VaInt(rw("semana")).ToString
            SemanasPartes.SEV_FechaInicialEntrada.Valor = rw("DeFecha").ToString
            SemanasPartes.SEV_FechaFinalEntrada.Valor = rw("AFecha").ToString
            SemanasPartes.SEV_FechaInicialSalida.Valor = rw("DeFechaSalida").ToString
            SemanasPartes.SEV_FechaFinalSalida.Valor = rw("AFechaSalida").ToString
            SemanasPartes.Insertar()

        Next
        MsgBox("Finalizado")
        Me.Close()
    End Sub
End Class