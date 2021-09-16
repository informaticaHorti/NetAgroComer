Imports DevExpress.XtraEditors


Public Class FrmGenerarInspecciones


    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro


    Dim AlbSalida_Lineas As New E_AlbSalida_lineas(Idusuario, cn)
    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()


    End Sub


    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click

        Me.Close()

    End Sub


    Private Sub BGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BGuardar.Click

        If XtraMessageBox.Show("¿Desea volver a generar las inspecciones de carga? LAS INSPECCIONES GUARDADAS SE BORRARÁN", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim sql As String = "DELETE FROM Cargas_inspeccion"
            cn.OrdenSql(sql)


            sql = "SELECT CAR_IdCarga as IdCarga, CAR_IdAlbaran1 as IdAlbaran1, CAR_IdAlbaran2 as IdAlbaran2, CAR_IdAlbaran3 as IdAlbaran3, CAR_IdAlbaran4 as IdAlbaran4, CAR_IdAlbaran5 as IdAlbaran5, CAR_IdAlbaran6 as IdAlbaran6 FROM CARGAS WHERE CAR_IdCarga > 0"
            Dim dt As DataTable = cn.ConsultaSQL(sql)

            If Not IsNothing(dt) Then

                ProgressBar1.Value = 0
                ProgressBar1.Maximum = dt.Rows.Count - 1


                For indice As Integer = 0 To dt.Rows.Count - 1

                    Dim row As DataRow = dt.Rows(indice)


                    Dim IdCarga As String = (row("IdCarga").ToString & "").Trim
                    Dim IdAlbaran1 As String = (row("IdAlbaran1").ToString & "").Trim
                    Dim IdAlbaran2 As String = (row("IdAlbaran2").ToString & "").Trim
                    Dim IdAlbaran3 As String = (row("IdAlbaran3").ToString & "").Trim
                    Dim IdAlbaran4 As String = (row("IdAlbaran4").ToString & "").Trim
                    Dim IdAlbaran5 As String = (row("IdAlbaran5").ToString & "").Trim
                    Dim IdAlbaran6 As String = (row("IdAlbaran6").ToString & "").Trim

                    Dim lst As New List(Of String)
                    If VaInt(IdAlbaran1) > 0 Then lst.Add(IdAlbaran1)
                    If VaInt(IdAlbaran2) > 0 Then lst.Add(IdAlbaran2)
                    If VaInt(IdAlbaran3) > 0 Then lst.Add(IdAlbaran3)
                    If VaInt(IdAlbaran4) > 0 Then lst.Add(IdAlbaran4)
                    If VaInt(IdAlbaran5) > 0 Then lst.Add(IdAlbaran5)
                    If VaInt(IdAlbaran6) > 0 Then lst.Add(IdAlbaran6)

                    Dim b3808 As Boolean = False
                    Dim bQS As Boolean = EsQS(IdCarga, lst, b3808)


                    'If VaInt(IdCarga) = 5333 Then
                    '    Dim a As String = ""
                    'End If



                    'Actualizo el verificador de la carga
                    Dim Cargas As New E_Cargas(Idusuario, cn)
                    If Cargas.LeerId(IdCarga) Then

                        If b3808 Then
                            Cargas.CAR_IdCargador.Valor = "2"
                        Else
                            Cargas.CAR_IdCargador.Valor = "3"
                        End If

                        Dim matricula As String = (Cargas.CAR_Matricula.Valor & "").Trim
                        If matricula = "" Then Cargas.CAR_Matricula.Valor = ObtenerMatriculaCarga(lst)

                        Cargas.Actualizar()

                    End If


                    'Creo las inspecciones para cada carga (1-6)
                    GrabarInspeccion(IdCarga, bQS)


                    ProgressBar1.Value = indice

                    Application.DoEvents()

                Next

            End If




            MsgBox("Terminado!")

        End If


    End Sub



    Private Sub GrabarInspeccion(IdCarga As String, bQS As Boolean)


        For IdConcepto As Integer = 1 To 6

            Dim Cargas_Inspeccion As New E_Cargas_inspeccion(Idusuario, cn)

            Dim Id As Integer = Cargas_Inspeccion.MaxId
            Cargas_Inspeccion.CGI_id.Valor = Id
            Cargas_Inspeccion.CGI_idcarga.Valor = IdCarga
            Cargas_Inspeccion.CGI_idinspeccion.Valor = IdConcepto.ToString
            If IdConcepto < 6 Then
                Cargas_Inspeccion.CGI_sn.Valor = "S"
            Else
                If bQS Then
                    Cargas_Inspeccion.CGI_sn.Valor = "S"
                Else
                    Cargas_Inspeccion.CGI_sn.Valor = "N"
                End If
            End If
          
            Cargas_Inspeccion.Insertar()


            Application.DoEvents()

        Next

    End Sub



    Private Function EsQS(IdCarga As String, lstAlbaranes As List(Of String), ByRef b3808 As Boolean) As Boolean

        Dim bRes As Boolean = False
        b3808 = False

        If lstAlbaranes.Count > 0 Then

            'Para que sea QS, es necesario que el cliente sea 3808 y el Id de Marca de envases sea 3
            Dim sql As String = "SELECT ASA_IdCliente as IdCliente, ASL_IdMarca as IdMarca" & vbCrLf
            sql = sql & " FROM AlbSalida_Lineas" & vbCrLf
            sql = sql & " LEFT JOIN AlbSalida ON ASA_IdAlbaran = ASL_IdAlbaran" & vbCrLf
            sql = sql & " WHERE ASA_IdCliente = 3808" & vbCrLf
            sql = sql & " AND ASL_IdMarca = 3" & vbCrLf
            sql = sql & CadenaWhereLista(AlbSalida_Lineas.ASL_idalbaran, lstAlbaranes, " AND ")
            'sql = sql & " AND ASL_IdAlbaran = 6867 OR ASL_IdAlbaran = 6868"


            Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                If dt.Rows.Count > 0 Then
                    bRes = True
                End If

            End If


            sql = "SELECT TOP 1 ASA_IdCliente as IdCliente" & vbCrLf
            sql = sql & " FROM AlbSalida" & vbCrLf
            sql = sql & CadenaWhereLista(AlbSalida.ASA_idalbaran, lstAlbaranes, " WHERE ")

            Dim dt3808 As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt3808) Then
                If dt3808.Rows.Count > 0 Then

                    Dim IdCliente As Integer = VaInt(dt3808.Rows(0)("IdCliente"))
                    If IdCliente = 3808 Then
                        b3808 = True
                    End If

                End If
            End If

        End If



        Return bRes

    End Function



    Private Function ObtenerMatriculaCarga(lst As List(Of String)) As String

        Dim matricula As String = ""
        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)


        If lst.Count > 0 Then


            For Each IdAlbaran As String In lst

                If AlbSalida.LeerId(IdAlbaran) Then

                    If (AlbSalida.ASA_matricularemolque.Valor & "").Trim <> "" Then
                        matricula = (AlbSalida.ASA_matricularemolque.Valor & "").Trim
                        Exit For
                    End If

                End If


                Application.DoEvents()

            Next


        End If



        Return matricula

    End Function




End Class