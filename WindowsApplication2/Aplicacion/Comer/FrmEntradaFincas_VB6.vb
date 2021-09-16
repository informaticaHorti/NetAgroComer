Public Class FrmEntradaFincas_VB6

    Dim DtFincas As New DataTable



    Public Sub Init(Cdagricultor As Integer, CampaFincas As Integer, cdgenero As Integer, FechaEntrada As String)


        If Len(FechaEntrada) = 10 Then
            FechaEntrada = Mid(FechaEntrada, 7, 4) + Mid(FechaEntrada, 4, 2) + Mid(FechaEntrada, 1, 2)
        Else
            FechaEntrada = ""
        End If

        SqlFincas(Cdagricultor, CampaFincas, cdgenero, FechaEntrada)


    End Sub



    Private Sub SqlFincas(Codprin As String, CampaFincas As String, Genero As String, FechaEntrada As String)

        Dim csql As String = ""
        Codprin = Fnc0(Codprin, 5)
        Genero = Fnc0(Genero, 5)
        CampaFincas = Fnc0(CampaFincas, 2)


        DtFincas.Columns.Add(New DataColumn("idcultivo", GetType(System.String)))
        DtFincas.Columns.Add(New DataColumn("finca", GetType(System.String)))
        DtFincas.Columns.Add(New DataColumn("Nave", GetType(System.String)))
        DtFincas.Columns.Add(New DataColumn("FechaSiembra", GetType(System.String)))
        DtFincas.Columns.Add(New DataColumn("idgenero", GetType(System.String)))
        DtFincas.Columns.Add(New DataColumn("Genero", GetType(System.String)))
        DtFincas.Columns.Add(New DataColumn("idvariedad", GetType(System.String)))
        DtFincas.Columns.Add(New DataColumn("Variedad", GetType(System.String)))
        DtFincas.Columns.Add(New DataColumn("Programa", GetType(System.String)))
        DtFincas.Columns.Add(New DataColumn("Blq", GetType(System.String)))
        DtFincas.Columns.Add(New DataColumn("N1", GetType(System.String)))
        DtFincas.Columns.Add(New DataColumn("FechaSeg", GetType(System.String)))
        DtFincas.Columns.Add(New DataColumn("Observaciones", GetType(System.String)))
        DtFincas.Columns.Add(New DataColumn("cdfinca", GetType(System.String)))
        DtFincas.Columns.Add(New DataColumn("cdnave", GetType(System.String)))


        csql = " select distinct g.cdcampa, g.cdfinca, isnull(datos_fincas.nombre, '') as nombre "
        csql = csql + " from ( "
        csql = csql + " select cdcampa, cdfinca from datos_fincas "
        csql = csql + " where (datos_fincas.cdagricultor='" + Codprin + "') "
        csql = csql + " and (datos_fincas.cdcampa='" + CampaFincas + "') "
        csql = csql + " union all "
        '   csql = csql + " select cdcampa, cdfinca from invernaderos_agricultores "
        '   csql = csql + " where (invernaderos_agricultores.cdagricultor='" + CodPrin + "') "
        '   csql = csql + " and (invernaderos_agricultores.cdcampa='" + CampaFincas + "') "
        csql = csql + " select cdcampa, cdfinca from invernaderos_sigpac "
        csql = csql + " where (invernaderos_sigpac.cdagricultor='" + Codprin + "') "
        csql = csql + " and (invernaderos_sigpac.cdcampa='" + CampaFincas + "') "
        csql = csql + " ) as g left outer join datos_fincas on "
        csql = csql + " datos_fincas.cdcampa = g.cdcampa and "
        csql = csql + " datos_fincas.cdfinca = g.cdfinca "
        csql = csql + " order by g.cdfinca "

        Dim dt As DataTable = cnFincasVB6.ConsultaSQL(csql)


        If Not dt Is Nothing Then

            For Each rw In dt.Rows

                If VaInt(Genero) = 0 Then
                    csql = "SELECT cultivos_lineas.* "
                    csql = csql + " FROM cultivos_lineas "
                    csql = csql + " WHERE (cultivos_lineas.cdcampa='" + CampaFincas + "') "
                    csql = csql + " AND (cultivos_lineas.cdfinca='" + Trim(rw("cdfinca").ToString) + "') "
                Else
                    csql = "SELECT DISTINCT cultivos_lineas.* "
                    csql = csql + " FROM cultivos_lineas LEFT OUTER JOIN "
                    csql = csql + " generos_por_cultivo on cultivos_lineas.cdgenero = generos_por_cultivo.cdcultivo "
                    csql = csql + " WHERE (cultivos_lineas.cdcampa='" + CampaFincas + "') "
                    csql = csql + " AND (cultivos_lineas.cdfinca='" + Trim(rw("cdfinca").ToString) + "') "
                    csql = csql + " AND (generos_por_cultivo.cdgenalm='" + Genero + "') "
                End If


                Dim dtc As DataTable = cnFincasVB6.ConsultaSQL(csql)
                If Not dtc Is Nothing Then
                    For Each rwc In dtc.Rows
                        CargadatosFin(Codprin, rwc, FechaEntrada)
                    Next
                End If

            Next
        End If


        Grid.DataSource = DtFincas
        AjustaColumnas()

    End Sub


    Private Sub CargadatosFin(codprin As String, rwc As DataRow, FechaEntrada As String)


        ' fecha entrada en formato YYYYMMDD

        Dim N1 As String

        Dim SiBloqu As String
        Dim FeSegur As String
        Dim HoSegur As String

        Dim Nvarie As String
        Dim Ninver As String
        Dim Ngen As String
        Dim Nfinca As String

        Dim csql As String
        Dim FechaEnt As String

        FechaEnt = FechaEntrada
        If FechaEnt = "" Then FechaEnt = Format(Now, "YYYYMMDD")

        ' --- 12- fecha final
        If VaDec(rwc("fechafinalizareal").ToString) > 0 Then Exit Sub

        Ninver = ""
        Ninver = InvernaderosFincas(rwc("cdfinca").ToString, rwc("cdnave").ToString, rwc("cdcampa").ToString).Trim

        Ngen = ""
        Ngen = GeneroFincas(rwc("cdgenero").ToString).Trim

        Nfinca = ""
        Nfinca = NombreFinca(rwc("cdfinca").ToString, rwc("cdcampa").ToString).Trim

        Nvarie = ""
        ' --- 15- cd.variedad
        If VaInt(rwc("cdVariedad")) > 0 Then
            ' --- 6- cdgenero / 15- cd.variedad
            Nvarie = VariedadFincas(rwc("cdgenero").ToString, rwc("cdvariedad").ToString).Trim
        End If

        ' --- 0- campaña / 2- cd.finca /  3- linea
        ' N1 = TbLincul.Fields(0) + TbLincul.Fields(1) + TbLincul.Fields(3)
        N1 = Trim(rwc("CdCampa").ToString) + Trim(rwc("cdFinca").ToString) + Trim(rwc("cdNave").ToString) + Trim(rwc("nuLinea").ToString)

        ' --- 28- bloquear
        SiBloqu = UCase(rwc("bloquear").ToString)

        HoSegur = ""
        FeSegur = ""

        csql = " select recetas_lineas.* "

        csql = csql + " from recetas_lineas inner join datos_fincas on "
        csql = csql + " recetas_lineas.cdcampa = datos_fincas.cdcampa and "
        csql = csql + " recetas_lineas.cdfinca = datos_fincas.cdfinca "

        csql = csql + " where (datos_fincas.cdagricultor='" + codprin + "') "
        csql = csql + " and (recetas_lineas.klavecultivo='" + N1 + "') "
        csql = csql + " and (recetas_lineas.fechaseguridad>='" + FechaEnt + "') "
        csql = csql + " and (recetas_lineas.nulinea<>'00') "

        Dim dtr As DataTable = cnFincasVB6.ConsultaSQL(csql)
        If Not dtr Is Nothing Then
            For Each rwr In dtr.Rows

                FeSegur = FnF8(Fnv2(rwr("fechaseguridad").ToString))

                ' --- 13- HoraSeguri
                If Trim(rwr("fechaseguridad").ToString) = FechaEnt Then
                    If VaInt(rwr("horaseguridad").ToString) > VaInt(Format(Now, "hh")) Then
                        SiBloqu = "S"
                    End If
                ElseIf Trim(rwr("fechaseguridad").ToString) > FechaEnt Then  ' --- comprueba fecha final receta
                    If Trim(rwr("fechaejecucion").ToString) = FechaEnt Then ' --- comprueba fecha inicial receta
                        SiBloqu = ""
                    Else
                        SiBloqu = "S"
                    End If
                End If

                HoSegur = Trim(rwr("horaseguridad").ToString)


            Next
        End If

        Dim f(14) As String



        f(0) = Trim(rwc("idcultivo").ToString)
        f(1) = Trim(rwc("cdFinca").ToString) + "-" + Nfinca
        f(2) = Trim(rwc("cdnave").ToString) + "-" + Ninver
        f(3) = FnF8(Fnv2(rwc("fechaSiembraReal").ToString.Trim))
        f(4) = Trim(rwc("cdgenero").ToString)           ' ---> género TECNICOS
        f(5) = Trim(Ngen)
        f(6) = Trim(rwc("cdVariedad").ToString)
        f(7) = Nvarie
        f(8) = Trim(rwc("cdprogcalidad").ToString)
        f(9) = SiBloqu
        f(10) = N1
        f(11) = FeSegur
        f(12) = Trim(rwc("observaciones").ToString)
        f(13) = Trim(rwc("cdFinca").ToString)          ' --- cdfinca
        f(14) = Trim(rwc("cdNave").ToString)                 ' --- cdnave

        DtFincas.Rows.Add(f)


    End Sub



    Private Sub GridView1_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick

        Dim row As System.Data.DataRow
        row = GridView1.GetDataRow(e.RowHandle)

        If Not IsNothing(row) Then
            RowDePaso = row
            ' _Resultado = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub


    Private Sub GridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridView1.KeyPress
        If e.KeyChar = Chr(13) Then
            Intro()
        End If

    End Sub

    Private Sub Intro()
        Dim row As System.Data.DataRow

        row = GridView1.GetFocusedDataRow()
        If Not row Is Nothing Then
            RowDePaso = row
            ' _Resultado = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub


    Private Sub AjustaColumnas()




        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDCULTIVO", "BLQ", "PROGRAMA"
                    c.Width = 70

                Case "FINCA", "GENERO", "OBSERVACIONES"
                    c.Width = 200
                Case "NAVE"
                    c.MinWidth = 200
                Case "FECHASIEMBRA", "FECHASEG", "VARIEDAD"
                    c.Width = 100

                Case Else
                    c.Visible = False

            End Select

        Next


    End Sub

    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click
        RowDePaso = Nothing
        ' _Resultado = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub FrmEntradaFincas_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Grid.Focus()
        GridView1.Focus()
    End Sub

    Private Sub FrmEntradaFincas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class