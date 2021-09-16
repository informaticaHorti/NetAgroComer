Public Class FrmCargarIBANAgricultores


    Private Sub FrmCargarIBANAgricultores_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Consultar()

    End Sub


    Private Sub Consultar()

        

        Dim sql As String = "SELECT AGR_IdAgricultor as IdAgricultor, '' as Entidad, IBAN as IBAN" & vbCrLf
        sql = sql & " FROM Agricultores" & vbCrLf
        sql = sql & " WHERE COALESCE(LTRIM(RTRIM(IBAN)),'') > ''" & vbCrLf
        sql = sql & " AND IBAN NOT IN" & vbCrLf
        sql = sql & " (" & vbCrLf
        sql = sql & " SELECT AIB_IBAN" & vbCrLf
        sql = sql & " FROM Agricultores_IBAN" & vbCrLf
        sql = sql & " WHERE AIB_IdAgricultor = AGR_IdAgricultor" & vbCrLf
        sql = sql & " AND AIB_IBAN = Agricultores.IBAN" & vbCrLf
        sql = sql & " )" & vbCrLf

        Dim dt As DataTable = cn.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows

                Dim IBAN As String = (row("IBAN").ToString & "").Trim.Replace(" ", "")
                If IBAN.Length >= 8 Then

                    Dim codigo As String = IBAN.Substring(4, 4)
                    Select Case codigo.ToUpper

                        Case "0030", "0038", "0049", "0075"
                            row("Entidad") = "BANCO SANTANDER"
                        Case "0081"
                            row("Entidad") = "BANCO SABADELL"
                        Case "0128"
                            row("Entidad") = "BANKINTER"
                        Case "0149"
                            row("Entidad") = "BNP PARIBAS"
                        Case "0182"
                            row("Entidad") = "BVVA"
                        Case "0237"
                            row("Entidad") = "CAJASUR"
                        Case "1465"
                            row("Entidad") = "ING BANK"
                        Case "2038"
                            row("Entidad") = "BANKIA"
                        Case "2080"
                            row("Entidad") = "ABANCA"
                        Case "2085"
                            row("Entidad") = "IBERCAJA"
                        Case "2100"
                            row("Entidad") = "CAIXABANK"
                        Case "2103"
                            row("Entidad") = "UNICAJA"
                        Case "3023"
                            row("Entidad") = "CAJA RURAL DE GRANADA"
                        Case "3058", "3082"
                            row("Entidad") = "CAJAMAR"

                    End Select

                End If


            Next

        End If


        Grid.DataSource = dt
        AjustaColumnas()



    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            If c.FieldName.Trim.ToUpper.EndsWith("_OLD") Then
                c.Visible = False
            ElseIf c.FieldName.Trim.ToUpper = "CUENTATIPO" Then
                c.Visible = False
            End If
        Next

        GridView1.BestFitColumns()

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If MessageBox.Show("¿Desea insertar los IBAN de los agricultores?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


            ProgressBar1.Value = 0
            ProgressBar1.Maximum = 0

            If GridView1.RowCount > 0 Then
                ProgressBar1.Maximum = GridView1.RowCount - 1
            End If


            For indice As Integer = 0 To GridView1.RowCount - 1

                Dim row As DataRow = GridView1.GetDataRow(indice)
                If Not IsNothing(row) Then

                    Dim IdAgricultor As String = (row("IdAgricultor").ToString & "").Trim
                    Dim Entidad As String = (row("Entidad").ToString & "").Trim
                    Dim IBAN As String = (row("IBAN").ToString & "").Trim


                    Dim Agricultores_IBAN As New E_Agricultores_IBAN(Idusuario, cn)
                    Agricultores_IBAN.AIB_Id.Valor = Agricultores_IBAN.MaxId.ToString
                    Agricultores_IBAN.AIB_IdAgricultor.Valor = IdAgricultor
                    Agricultores_IBAN.AIB_Entidad.Valor = Entidad
                    Agricultores_IBAN.AIB_IBAN.Valor = IBAN
                    Agricultores_IBAN.Insertar()

                    Dim Agricultores As New E_Agricultores(Idusuario, cn)
                    If Agricultores.LeerId(IdAgricultor) Then
                        Agricultores.AGR_IBAN.Valor = IBAN
                        Agricultores.Actualizar()
                    End If

                End If


                ProgressBar1.Value = indice
                Application.DoEvents()

            Next



        End If

    End Sub


End Class