
Public Class FrmRecomponerTarasPalets
    Inherits FrConsulta


    Private Class stClave_Taras

        Public IdPalet As Integer = 0
        Public Palet As Integer = 0
        Public Fecha As String = ""
        Public IdPresentacion As Integer = 0
        Public Presentacion As String = ""

        Public Sub New(IdPalet As Integer, Palet As Integer, Fecha As String, IdPresentacion As Integer, Presentacion As String)
            Me.IdPalet = IdPalet
            Me.Palet = Palet
            Me.Fecha = Fecha
            Me.IdPresentacion = IdPresentacion
            Me.Presentacion = Presentacion
        End Sub

    End Class

    Private Class stDatos_Taras

        Public TaraPalet As Decimal = 0
        Public TaraEnvase As Decimal = 0
        Public KilosBrutos As Decimal = 0
        Public KgSinTara As Decimal = 0
        Public KilosNetos As Decimal = 0
        Public Diferencia As Decimal = 0

        Public Sub New(TaraPalet As Decimal, TaraEnvase As Decimal, KilosBrutos As Decimal, KgSinTara As Decimal, KilosNetos As Decimal, Diferencia As Decimal)
            Me.TaraPalet = TaraPalet
            Me.TaraEnvase = TaraEnvase
            Me.KilosBrutos = KilosBrutos
            Me.KgSinTara = KgSinTara
            Me.KilosNetos = KilosNetos
            Me.Diferencia = Diferencia
        End Sub

    End Class



    Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        BInforme.Visible = False
        GridView1.Appearance.HeaderPanel.BackColor = Color.Aquamarine


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub

    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim sql As String = "SELECT PLL_IdPalet as IdPalet, PAL_Palet as Palet, PAL_Fecha as Fecha, COALESCE(PAL_tarapalet,0) as TaraPalet, " & vbCrLf
        sql = sql & " PLL_IdGenSal as IdPresentacion, GES_Nombre as Presentacion," & vbCrLf
        sql = sql & " COALESCE(CEV_TotalTara,0) * COALESCE(PLL_Bultos,0)  as TaraEnvase," & vbCrLf
        sql = sql & " PLL_KilosBrutos as KilosBrutos, PLL_KilosNetos as KilosNetos" & vbCrLf
        sql = sql & " FROM Palets_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN Palets ON PAL_IdPalet = PLL_IdPalet" & vbCrLf
        sql = sql & " LEFT JOIN confecenvase ON CEV_idconfec = PLL_IdTipoConfeccion" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida_Palets ON ASP_IdPalet = PLL_IdPalet" & vbCrLf
        sql = sql & " LEFT JOIN GenerosSalida ON GES_IdGenSal = PLL_IdGenSal" & vbCrLf
        sql = sql & " WHERE COALESCE(ASP_IdAlbaran,0) = 0" & vbCrLf
        sql = sql & " AND PAL_Finalizado = 'S'" & vbCrLf
        sql = sql & " ORDER BY PLL_IdPalet, PLL_IdLinea " & vbCrLf

        Dim dt As DataTable = Palets_Lineas.MiConexion.ConsultaSQL(sql)


        Dim acum As New Acumulador


        Dim Dc As New Dictionary(Of Integer, Integer)


        If Not IsNothing(dt) Then

            ProgressBar1.Value = 0
            ProgressBar1.Maximum = dt.Rows.Count - 1

            For indice As Integer = 0 To dt.Rows.Count - 1

                Dim row As DataRow = dt.Rows(indice)

                Dim IdPalet As Integer = VaInt(row("IdPalet"))
                Dim Palet As Integer = VaInt(row("Palet"))
                Dim Fecha As String = ""
                If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
                Dim IdPresentacion As Integer = VaInt(row("IdPresentacion"))
                Dim Presentacion As String = (row("Presentacion").ToString & "").Trim


                Dim TaraPalet As Decimal = VaDec(row("TaraPalet"))
                Dim TaraEnvase As Decimal = VaDec(row("TaraEnvase"))
                Dim KilosBrutos As Decimal = VaDec(row("KilosBrutos"))
                Dim KilosNetos As Decimal = VaDec(row("KilosNetos"))


                'Controlamos que la tara de palet sólo se introduzca en la primera línea
                If Not Dc.ContainsKey(IdPalet) Then
                    Dc(IdPalet) = IdPalet
                Else
                    TaraPalet = 0
                End If

                Dim KgSinTara As Decimal = KilosBrutos - TaraPalet - TaraEnvase
                Dim Diferencia As Decimal = KgSinTara - KilosNetos

                Dim stClave As New stClave_Taras(IdPalet, Palet, Fecha, IdPresentacion, Presentacion)
                Dim stDatos As New stDatos_Taras(TaraPalet, TaraEnvase, KilosBrutos, KgSinTara, KilosNetos, Diferencia)
                acum.Suma(stClave, stDatos)

                ProgressBar1.Value = indice

            Next

        End If


        dt = acum.DataTable



        Grid.DataSource = dt
        AjustaColumnas()

    End Sub

    Private Sub AjustaColumnas()

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDPRESENTACION"
                    c.Visible = False
            End Select
        Next


    End Sub
End Class