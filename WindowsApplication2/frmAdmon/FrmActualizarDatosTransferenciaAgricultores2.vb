Public Class FrmActualizarDatosTransferenciaAgricultores2


    Private Sub FrmActualizarDatosTransferenciaAgricultores_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Consultar()

    End Sub


    Private Sub Consultar()

        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)

        'SELECT AGR_IdAgricultor as IdAgricultor, AGR_Nombre as Agricultor, AGR_NIF as NIF, IBAN as IBAN, 
        'LEFT(CAST(TPA_CtaProv AS NVARCHAR) + '000000', 6) + RIGHT('00000' + CAST(AGR_IDAGRICULTOR AS NVARCHAR), 5) as CtaProveedor,
        'LEFT(CAST(TPA_CtaCartera AS NVARCHAR) + '000000', 6) + RIGHT('00000' + CAST(AGR_IDAGRICULTOR AS NVARCHAR), 5) as CtaCartera
        'FROM Agricultores
        'LEFT JOIN TipoAgricultor ON TPA_idtipo = AGR_idtipo 
        'WHERE AGR_IdFormaPago = 3


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(Agricultores.AGR_IdAgricultor, "IdAgricultor")
        CONSULTA.SelCampo(Agricultores.AGR_Nombre, "Agricultor")
        CONSULTA.SelCampo(Agricultores.AGR_Nif, "NIF")
        CONSULTA.SelCampo(TipoAgricultor.TPA_ctaprov, "CuentaTipo", Agricultores.AGR_IdTipo, TipoAgricultor.TPA_idtipo)
        CONSULTA.SelCampo(TipoAgricultor.TPA_CtaCartera, "CuentaTipoCartera")
        Dim oCtaProv As New Cdatos.bdcampo("@LEFT(CAST(TPA_CtaProv AS NVARCHAR) + '000000', 6) + RIGHT('00000' + CAST(AGR_IdAgricultor AS NVARCHAR), 5)", Cdatos.TiposCampo.Cadena, 255)
        CONSULTA.SelCampo(oCtaProv, "CtaProveedor")
        Dim oCtaCartera As New Cdatos.bdcampo("@LEFT(CAST(TPA_CtaCartera AS NVARCHAR) + '000000', 6) + RIGHT('00000' + CAST(AGR_IDAGRICULTOR AS NVARCHAR), 5)", Cdatos.TiposCampo.Cadena, 255)
        CONSULTA.SelCampo(oCtaCartera, "CtaCartera")
        CONSULTA.SelCampo(Agricultores.AGR_IBAN, "IBAN")
        CONSULTA.WheCampo(Agricultores.AGR_IdFormaPago, "=", VaInt(E_Agricultores.FormasPago.Transferencia).ToString)


        Dim sql As String = CONSULTA.SQL
        Dim dt As DataTable = Agricultores.MiConexion.ConsultaSQL(sql)


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
                    Dim Cuenta As String = (row("CtaProveedor").ToString & "").Trim
                    Dim CuentaCartera As String = (row("CtaCartera").ToString & "").Trim
                    Dim IBAN As String = (row("IBAN").ToString & "").Trim
                    Dim NIF As String = (row("NIF").ToString & "").Trim


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

                    End If


                    Dim Cartera1 As New E_Cuentas(Idusuario, ConexCtb(1))
                    If Cartera1.LeerId(CuentaCartera) Then
                        If IBAN.Trim <> "" Then Cartera1.CuentaBancaria.Valor = IBAN
                        Cartera1.Nif.Valor = NIF
                        Cartera1.Actualizar()
                    End If
                    Dim Cartera2 As New E_Cuentas(Idusuario, ConexCtb(2))
                    If Cartera2.LeerId(CuentaCartera) Then
                        If IBAN.Trim <> "" Then Cartera2.CuentaBancaria.Valor = IBAN
                        Cartera2.Nif.Valor = NIF
                        Cartera2.Actualizar()
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