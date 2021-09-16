Public Class FrmCuadreKilosHistorico
    Inherits FrConsulta


    Private Class stClave_Albaranes

        Public CE As Integer = 0
        Public IdAlbaran As Integer = 0
        Public Albaran As Integer = 0
        Public Fecha As String = ""

        Public Sub New(IdAlbaran As Integer, Albaran As Integer, Fecha As String, CE As Integer)

            Me.CE = CE
            Me.IdAlbaran = IdAlbaran
            Me.Albaran = Albaran
            Me.Fecha = Fecha

        End Sub

    End Class

    Private Class stDatos_Albaranes

        Public KgEntrada As Decimal = 0
        Public KgHistorico As Decimal = 0

        Public Sub New(KgEntrada As Decimal, KgHistorico As Decimal)

            Me.KgEntrada = KgEntrada
            Me.KgHistorico = KgHistorico

        End Sub

    End Class


    Private AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    

    Dim err As New Errores


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, AlbEntrada.AEN_Fecha, Lb1, True)
        ParamTx(TxDato2, AlbEntrada.AEN_Fecha, Lb2, True)
        ParamChk(chkSoloPendientes, Nothing, "S", "N")

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub FrmCuadreKilosHistorico_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False

    End Sub


    Private Sub Fechaspordefecto()
        TxDato1.Text = Now.ToString("dd/MM/yyyy")
        TxDato2.Text = Now.ToString("dd/MM/yyyy")

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim acum As New Acumulador


        'Albaranes de entrada
        Dim sql As String = "SELECT AEN_IdAlbaran as IdAlbaran, AEN_IdCentro as CE, AEN_Albaran as Albaran, AEN_Fecha as Fecha, SUM(AEL_KilosNetos) as KgEntrada" & vbCrLf
        sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " WHERE AEN_Fecha >= '" & TxDato1.Text & "'" & vbCrLf
        sql = sql & " AND AEN_Fecha <= '" & TxDato2.Text & "'" & vbCrLf
        sql = sql & " GROUP BY AEN_IdCentro, AEN_IdAlbaran, AEN_Albaran, AEN_Fecha" & vbCrLf
        sql = sql & " ORDER BY AEN_IdCentro, AEN_Fecha, AEN_Albaran" & vbCrLf

        Dim dtAEN As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dtAEN) Then

            For Each row As DataRow In dtAEN.Rows

                Dim IdCentro As Integer = VaInt(row("CE"))
                Dim IdAlbaran As Integer = VaInt(row("IdAlbaran"))
                Dim Albaran As Integer = VaInt(row("Albaran"))
                Dim Fecha As String = ""
                If VaDate(row("Fecha")) <> VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
                Dim KgEntrada As Decimal = VaDec(row("KgEntrada"))

                Dim stClaves As New stClave_Albaranes(IdAlbaran, Albaran, Fecha, IdCentro)
                Dim stDatos As New stDatos_Albaranes(KgEntrada, 0)

                acum.Suma(stClaves, stDatos)

            Next

        End If


        sql = "SELECT AEN_IdAlbaran as IdAlbaran, AEN_IdCentro as CE, AEN_Albaran as Albaran, AEN_Fecha as Fecha, SUM(AHL_Kilos) as KgHistorico" & vbCrLf
        sql = sql & " FROM AlbEntrada_HisLineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada_His ON AHL_IdAlbHis = AEH_Id" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEH_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " WHERE AEN_Fecha >= '" & TxDato1.Text & "'" & vbCrLf
        sql = sql & " AND AEN_Fecha <= '" & TxDato2.Text & "'" & vbCrLf
        sql = sql & " GROUP BY AEN_IdCentro, AEN_IdAlbaran, AEN_Albaran, AEN_Fecha" & vbCrLf
        sql = sql & " ORDER BY AEN_IdCentro, AEN_Fecha, AEN_Albaran" & vbCrLf

        Dim dtAEH As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dtAEH) Then

            For Each row As DataRow In dtAEH.Rows

                Dim IdCentro As Integer = VaInt(row("CE"))
                Dim IdAlbaran As Integer = VaInt(row("IdAlbaran"))
                Dim Albaran As Integer = VaInt(row("Albaran"))
                Dim Fecha As String = ""
                If VaDate(row("Fecha")) <> VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
                Dim KgHistorico As Decimal = VaDec(row("KgHistorico"))

                Dim stClaves As New stClave_Albaranes(IdAlbaran, Albaran, Fecha, IdCentro)
                Dim stDatos As New stDatos_Albaranes(0, KgHistorico)

                acum.Suma(stClaves, stDatos)

            Next

        End If


        Dim dt As DataTable = acum.DataTable


        Dim dv As New DataView(dt)
        dv.Sort = "CE, Fecha, Albaran"
        If chkSoloPendientes.Checked Then
            dv.RowFilter = "(Isnull(KgEntrada,0) - Isnull(KgHistorico,0)) <> 0"
        End If
        dt = dv.ToTable




        Grid.DataSource = dt
        AjustaColumnas()


        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("KgEntrada", "{0:n2}")
        AñadeResumenCampo("KgHistorico", "{0:n2}")


    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "IDALBARAN"
                    c.Visible = False
            End Select
        Next

        With GridView1.Columns
            If Not IsNothing(.ColumnByFieldName("Fecha")) Then
                .ColumnByFieldName("Fecha").MaxWidth = 80
            End If
        End With

        GridView1.BestFitColumns()

       

    End Sub


    Protected Overrides Sub RowCellStyle(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn, sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        MyBase.RowCellStyle(row, column, sender, e)

        If e.Column.FieldName.Trim.ToUpper = "KGENTRADA" Or e.Column.FieldName.Trim.ToUpper = "KGHISTORICO" Then

            If VaDec(row("KgEntrada")) <> VaDec(row("KgHistorico")) Then
                e.Appearance.BackColor = Color.OrangeRed
            End If

        End If

    End Sub



    
End Class