Imports DevExpress.XtraEditors


Public Class FrmActualizarAEL_IdPrograma
    Inherits FrConsulta


    Dim err As New Errores

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        BInforme.Visible = False
        GridView1.Appearance.HeaderPanel.BackColor = Color.Aquamarine

        BtAux.Image = My.Resources.App_kservices_16x16_32
        BtAux.Text = "Actualizar"
        BtAux.Visible = True

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub

    Public Overrides Sub Consultar()
        MyBase.Consultar()

        

        Dim sql As String = "SELECT Albaran, IdLinea, IdPrograma, IdProgCultivo " & vbCrLf
        sql = sql & " FROM ("
        sql = sql & " SELECT AEL_IdLinea as IdLinea, AEN_Albaran as Albaran, AEL_IdPrograma as IdPrograma,"
        sql = sql & " (SELECT cdprogcalidad FROM TecnicosSQL.dbo.Cultivos_Lineas WHERE idcultivo = AEL_IdCultivo AND cdCampa = AEN_Campa) as IdProgCultivo"
        sql = sql & " FROM AlbEntrada_Lineas"
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran"
        sql = sql & " WHERE COALESCE(AEL_IdPrograma, 0) = 0"
        sql = sql & " ) as T "
        sql = sql & " WHERE COALESCE(IdProgCultivo,'') <> ''"
        sql = sql & " ORDER BY Albaran, IdLinea"

        Dim dt As DataTable = cn.ConsultaSQL(sql)


        GridView1.Columns.Clear()
        Grid.DataSource = dt

        GridView1.BestFitColumns()

    End Sub


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()


        If XtraMessageBox.Show("¿Desea actualizar el programa de calidad de las líneas de albarán de entrada?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

            Dim cont As Integer = 0


            Dim dt As DataTable = CType(Grid.DataSource, DataTable)
            If Not IsNothing(dt) Then


                Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)


                For Each row As DataRow In dt.Rows

                    Dim IdLinea As String = (row("IdLinea").ToString & "").Trim
                    Dim IdProgramaCultivo As String = (row("IdProgCultivo").ToString & "").Trim

                    If VaInt(IdLinea) > 0 Then

                        If AlbEntrada_Lineas.LeerId(IdLinea) Then
                            AlbEntrada_Lineas.AEL_idprograma.Valor = IdProgramaCultivo
                            AlbEntrada_Lineas.Actualizar()
                        End If

                    End If

                    cont = cont + 1

                Next

            End If





            If cont = 0 Then
                MsgBox("No hay registros que actualizar")
            Else
                MsgBox("Terminado!")
                Consultar()
            End If


        End If

    End Sub

End Class