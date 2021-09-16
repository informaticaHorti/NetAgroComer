Public Class FrmActualizarDatosTransferenciaAgricultores


    Private Sub FrmActualizarDatosTransferenciaAgricultores_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Consultar()

    End Sub


    Private Sub Consultar()

        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)

        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(Agricultores.AGR_IdAgricultor, "IdAgricultor")
        CONSULTA.SelCampo(Agricultores.AGR_Nombre, "Agricultor")
        CONSULTA.SelCampo(Agricultores.AGR_idempresa, "IdEmpresa")
        CONSULTA.SelCampo(Agricultores.AGR_IdFormaPago, "IdFormaPago")
        CONSULTA.SelCampo(Agricultores.AGR_TipoDocumento, "TipoDoc_OLD")
        CONSULTA.SelCampo(Agricultores.AGR_SituacionCartera, "Situacion_OLD")
        CONSULTA.SelCampo(TipoAgricultor.TPA_ctaprov, "CuentaTipo", Agricultores.AGR_IdTipo, TipoAgricultor.TPA_idtipo)
        CONSULTA.SelCampo(TipoAgricultor.TPA_CtaCartera, "CuentaTipoCartera")
        CONSULTA.SelCampo(Agricultores.AGR_IBAN, "IBAN")
        CONSULTA.WheCampo(Agricultores.AGR_IdFormaPago, "=", VaInt(E_Agricultores.FormasPago.Transferencia).ToString)


        Dim sql As String = CONSULTA.SQL
        Dim dt As DataTable = Agricultores.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dt) Then


            dt.Columns.Add("Cuenta", GetType(String))
            dt.Columns.Add("CuentaCartera", GetType(String))
            dt.Columns.Add("TipoDoc", GetType(Integer))
            dt.Columns.Add("Situacion", GetType(Integer))


            For Each row As DataRow In dt.Rows

                Dim CuentaTipo As String = (row("CuentaTipo").ToString & "").Trim & "00000000000"
                Dim CuentaTipoCartera As String = (row("CuentaTipoCartera").ToString & "").Trim & "00000000000"
                Dim IdAgricultor As String = VaInt(row("IdAgricultor")).ToString("00000")
                Dim Cuenta As String = CuentaTipo.Substring(0, 6) & IdAgricultor
                Dim CuentaCartera As String = CuentaTipoCartera.Substring(0, 6) & IdAgricultor

                Dim IdEmpresa As Integer = VaInt(row("IdEmpresa"))

                row("Cuenta") = Cuenta
                row("CuentaCartera") = CuentaCartera
                If IdEmpresa = 1 Then
                    row("Situacion") = 2
                ElseIf IdEmpresa = 2 Then
                    row("Situacion") = 1
                End If

                row("TipoDoc") = 10

                Application.DoEvents()

            Next


            'dt.Columns.Remove("CuentaTipo")


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

        If MessageBox.Show("¿Desea actualizar los datos para las transferencias a los agricultores?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


            ProgressBar1.Value = 0
            ProgressBar1.Maximum = 0

            If GridView1.RowCount > 0 Then
                ProgressBar1.Maximum = GridView1.RowCount - 1
            End If


            For indice As Integer = 0 To GridView1.RowCount - 1

                Dim row As DataRow = GridView1.GetDataRow(indice)
                If Not IsNothing(row) Then

                    Dim IdAgricultor As String = (row("IdAgricultor").ToString & "").Trim
                    Dim IdTipoDocumento As String = (row("TipoDoc").ToString & "").Trim
                    Dim Situacion As String = (row("Situacion").ToString & "").Trim
                    Dim Cuenta As String = (row("Cuenta").ToString & "").Trim
                    Dim CuentaCartera As String = (row("CuentaCartera").ToString & "").Trim
                    Dim IBAN As String = (row("IBAN").ToString & "").Trim


                    Dim Agricultores As New E_Agricultores(Idusuario, cn)
                    If Agricultores.LeerId(IdAgricultor) Then
                        Agricultores.AGR_TipoDocumento.Valor = IdTipoDocumento
                        Agricultores.AGR_SituacionCartera.Valor = Situacion
                        Agricultores.Actualizar()
                    End If

                    If IBAN.Trim <> "" Then

                        Dim Cuentas1 As New E_Cuentas(Idusuario, ConexCtb(1))
                        If Cuentas1.LeerId(Cuenta) Then
                            Cuentas1.CuentaBancaria.Valor = IBAN
                            Cuentas1.Actualizar()
                        End If
                        Dim Cuentas2 As New E_Cuentas(Idusuario, ConexCtb(2))
                        If Cuentas2.LeerId(Cuenta) Then
                            Cuentas2.CuentaBancaria.Valor = IBAN
                            Cuentas2.Actualizar()
                        End If

                        Dim Cartera1 As New E_Cuentas(Idusuario, ConexCtb(1))
                        If Cartera1.LeerId(CuentaCartera) Then
                            Cartera1.CuentaBancaria.Valor = IBAN
                            Cartera1.Actualizar()
                        End If
                        Dim Cartera2 As New E_Cuentas(Idusuario, ConexCtb(2))
                        If Cartera2.LeerId(CuentaCartera) Then
                            Cartera2.CuentaBancaria.Valor = IBAN
                            Cartera2.Actualizar()
                        End If


                    End If

                End If


                ProgressBar1.Value = indice
                Application.DoEvents()

            Next



        End If

    End Sub

    
    Private Sub GridView1_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle

        Dim row As DataRow = GridView1.GetDataRow(e.RowHandle)
        If Not IsNothing(row) Then

            If e.Column.FieldName.ToUpper.Trim = "IDEMPRESA" Then

                Dim IdEmpresa As Integer = VaInt(row("IdEmpresa"))
                If IdEmpresa <> 1 And IdEmpresa <> 2 Then
                    e.Appearance.BackColor = Color.Red
                End If

            ElseIf e.Column.FieldName.ToUpper.Trim = "CUENTA" Then

                Dim Cuenta As String = (row("Cuenta").ToString & "").Trim
                If Cuenta.Length <> 11 Then
                    e.Appearance.BackColor = Color.Red
                End If

            End If




            



        End If

    End Sub
End Class