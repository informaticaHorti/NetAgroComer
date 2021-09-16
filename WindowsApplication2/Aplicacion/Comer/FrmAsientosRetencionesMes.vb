Imports DevExpress.XtraEditors

Public Class FrmAsientosRetencionesMes
    Inherits FrConsulta


    Dim AsientoLineas As New E_AsientoLineas(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim Cuentas As New E_Cuentas(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxFechaAsiento, AsientoLineas.Fecha, LbFechaAsiento)


    End Sub


    Private Sub FrmAsientosRetencionesMes_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False

        BtAux.Text = "Contabilizar"
        BtAux.Image = My.Resources.App_kservices_16x16_32
        BtAux.Visible = True

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        If VaDate(TxFechaAsiento.Text) > VaDate("") Then

            Dim sql As String = "SELECT Cuenta, Nombre, Saldo as ImpSaldo, '' as Saldo" & vbCrLf
            sql = sql & " FROM " & vbCrLf
            sql = sql & " ( " & vbCrLf
            sql = sql & "SELECT AL.NumeroCuenta as Cuenta, CU.Nombre, SUM(Debe - Haber) as Saldo" & vbCrLf
            sql = sql & " FROM AsientoLineas AL " & vbCrLf
            sql = sql & " LEFT JOIN Cuentas CU ON AL.NumeroCuenta = CU.NumeroCuenta" & vbCrLf
            sql = sql & " WHERE AL.NumeroCuenta BETWEEN '47530000000' AND '47530099999'" & vbCrLf
            sql = sql & " AND AL.Fecha <= '" & TxFechaAsiento.Text & "'" & vbCrLf
            sql = sql & " GROUP BY AL.NumeroCuenta, CU.Nombre" & vbCrLf
            sql = sql & " ) as G" & vbCrLf
            sql = sql & " WHERE Saldo <> 0 " & vbCrLf
            sql = sql & " ORDER BY Cuenta" & vbCrLf



            Dim dt As DataTable = AsientoLineas.MiConexion.ConsultaSQL(sql)
            Grid.DataSource = dt

            lbTotal.Text = "TOTAL: "

            If Not IsNothing(dt) Then
                For Each row As DataRow In dt.Rows

                    Dim ImpSaldo As Decimal = VaDec(row("ImpSaldo"))
                    row("Saldo") = StSaldoDec(ImpSaldo)
                    Application.DoEvents()

                Next

                If dt.Rows.Count > 0 Then
                    Dim Total As Decimal = VaDec(dt.Compute("SUM(ImpSaldo)", ""))
                    lbTotal.Text = lbTotal.Text & StSaldoDec(Total)
                End If

            End If

            AjustaColumnas()

            AñadeResumenCampo("ImpSaldo", "{0:n2}")


        Else
            MsgBox("Debe introducir una fecha válida")
        End If



    End Sub


    Private Sub AjustaColumnas()

        Grid.ForceInitialize()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IMPSALDO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "SALDO"
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            End Select
        Next

    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        If TxFechaAsiento.Text.Trim <> "" Then LineasDescripcion.Add("Fecha: " & TxFechaAsiento.Text)

        MyBase.Imprimir()

    End Sub


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()


        If XtraMessageBox.Show("¿Desea contabilizar?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            'Contabiliza
            Dim i As Integer = Contabilizar_IRPF_Agricultores()
            If i > 0 Then

                Dim ListaAsientos As New List(Of Integer)
                ListaAsientos.Add(i)
                Dim f As New frmVisualizadorAsiento(ListaAsientos, False, "")
                f.ShowDialog()

            Else
                MsgBox("no se generó asiento")
            End If
            

        End If

    End Sub


    Private Function Contabilizar_IRPF_Agricultores()

        Dim Resultado As Integer = 0


        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))


        Dim c As New Contabilizacion.clAsientos


        Dim Actividad As Integer = 0
        Dim Seccion As Integer = 0
        If PuntoVenta.LeerId(MiMaletin.IdPuntoVenta.ToString) Then
            Actividad = PuntoVenta.IdActividad.Valor
            Seccion = PuntoVenta.IdSeccion.Valor
        End If


        Dim Documento As String = MesLetra(TxFechaAsiento.Text)
        Dim TotalImporte As Decimal = 0

        'Retenciones
        For indice As Integer = 0 To GridView1.RowCount - 1

            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then

                Dim Cuenta As String = (row("Cuenta").ToString & "").Trim
                Dim Importe As Decimal = VaDec(row("ImpSaldo"))

                Dim asiLin As New Contabilizacion.clAsientoLineas
                asiLin.Concepto = "RETENCIONES IRPF MES"
                asiLin.Cuenta = Cuenta
                If Importe < 0 Then
                    asiLin.DH = "D"
                    TotalImporte = TotalImporte + Math.Abs(Importe)
                Else
                    asiLin.DH = "H"
                    TotalImporte = TotalImporte - Math.Abs(Importe)
                End If
                Importe = Math.Abs(Importe)
                asiLin.Documento = Documento
                asiLin.Importe = Importe
                asiLin.idConcepto = 0
                asiLin.IdActividad = Actividad
                asiLin.IdSeccion = Seccion
                asiLin.IdDepartamento = 0
                asiLin.IdSubDepartamento = 0

                c.ListaClAsientosLineas.Add(asiLin)

            End If

        Next


        'Contraparte con el importe total
        Dim asiLin_contraparte As New Contabilizacion.clAsientoLineas

        asiLin_contraparte.Concepto = "RETENCIONES IRPF MES"
        asiLin_contraparte.Cuenta = "47510000005"
        asiLin_contraparte.DH = "H"
        asiLin_contraparte.Documento = Documento
        asiLin_contraparte.Importe = TotalImporte
        asiLin_contraparte.idConcepto = 0
        asiLin_contraparte.IdActividad = Actividad
        asiLin_contraparte.IdSeccion = Seccion
        asiLin_contraparte.IdDepartamento = 0
        asiLin_contraparte.IdSubDepartamento = 0

        c.ListaClAsientosLineas.Add(asiLin_contraparte)


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'CONTABILIZAR


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Resultado = c.Contabilizar(ConexCtb(MiMaletin.IdEmpresaCTB), 0, MiMaletin.IdCentro, CDate(TxFechaAsiento.Text), MiMaletin.Ejercicio, MiMaletin.IdPuntoVenta, E_Asientos.AsientoIRPFAgricultores, VaDate(TxFechaAsiento.Text).ToString("yyyyMM"))

        'If Resultado > 0 Then
        '    Me.FRR_IdAsientoNet.Valor = Resultado.ToString
        '    Me.Actualizar()
        'End If


        Return Resultado

    End Function


    Private Function MesLetra(Fecha As String) As String

        Dim mes As Integer = 0
        Dim meses As String() = {"", "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"}
        If VaDate(Fecha) > VaDate("") Then
            mes = VaDate(Fecha).Month
        End If

        If mes > 0 Then
            Return meses(mes)
        Else
            Return ""
        End If

    End Function



End Class