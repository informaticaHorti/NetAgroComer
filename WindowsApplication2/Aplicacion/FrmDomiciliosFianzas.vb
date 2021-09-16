
Imports NetAgro.Cdatos
Imports System.Drawing

Imports DevExpress.XtraEditors



Public Class FrmDomiciliosFianzas


    Dim DomiciliosFianzas As New E_DomiciliosFianzas(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)


    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro
    Dim _ListaControles As New List(Of Object)


    Dim _IdDomicilio As String = ""



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(IdDomicilio As String, NombreDomicilio As String, Cliente As String)
        Me.new()

        _IdDomicilio = IdDomicilio

        LbCliente.Text = Cliente.ToUpper
        LbDomicilio.Text = NombreDomicilio.ToUpper

    End Sub


    Private Sub ParametrosFrm()


    End Sub



    Private Sub FrmDomiciliosFianzas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        GridEditable1.pnlDerecha.Visible = False

        CargaGrid()


    End Sub


    Private Sub CargaGrid()


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(Envases.ENV_IdEnvase, "IdEnvase")
        CONSULTA.SelCampo(Envases.ENV_Nombre, "Envase")
        CONSULTA.WheCampo(Envases.ENV_IdAcreedorFianza, ">", "0")


        Dim dt As DataTable = Envases.MiConexion.ConsultaSQL(CONSULTA.SQL)
        If Not IsNothing(dt) Then

            dt.Columns.Add("CodFianza", GetType(String))
            dt.PrimaryKey = New DataColumn() {dt.Columns("IdEnvase")}


            'Completamos con los datos de la tabla DomicilioFianzas
            Dim CONSULTA2 As New Cdatos.E_select
            CONSULTA2.SelCampo(DomiciliosFianzas.DFZ_IdEnvase, "IdEnvase")
            CONSULTA2.SelCampo(DomiciliosFianzas.DFZ_CodigoFianza, "CodFianza")
            CONSULTA2.WheCampo(DomiciliosFianzas.DFZ_IdDomicilio, "=", _IdDomicilio)

            Dim dt2 As DataTable = DomiciliosFianzas.MiConexion.ConsultaSQL(CONSULTA2.SQL)
            If Not IsNothing(dt2) Then

                For Each row2 As DataRow In dt2.Rows

                    Dim IdEnvase As Integer = VaInt(row2("IdEnvase"))
                    Dim CodFianza As String = (row2("CodFianza").ToString & "").Trim

                    Dim row As DataRow = dt.Rows.Find(VaInt(IdEnvase))
                    If Not IsNothing(row) Then
                        row("CodFianza") = CodFianza
                    End If

                Next

            End If


        End If


        


        GridEditable1.DataSource = dt

        AjustaColumnas()



        GridEditable1.Campo("CodFianza", DomiciliosFianzas.DFZ_CodigoFianza, True, True)


    End Sub



    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridEditable1.GridView.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "ID", "IDDOMICILIO"
                    c.Visible = False

            End Select
        Next


        GridEditable1.GridView.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridEditable1.GridView.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "IDENVASE"
                    c.Caption = "Cod.Envase"
                    c.MinWidth = 60
                    c.MaxWidth = 60

                Case "CODFIANZA"
                    c.Caption = "Cod.Fianza"
                    c.Width = 110

            End Select
        Next


    End Sub


    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click

        Me.Close()

    End Sub


    Private Sub BConsultar_Click(sender As System.Object, e As System.EventArgs) Handles BConsultar.Click

        CargaGrid()

    End Sub


    Private Sub BGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BGuardar.Click

        If XtraMessageBox.Show("¿Desea guardar los códigos de fianza?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            'Borra los datos para este domicilio
            Dim sql As String = "DELETE FROM DomiciliosFianzas WHERE DFZ_IdDomicilio = " & _IdDomicilio
            DomiciliosFianzas.MiConexion.OrdenSql(sql)

            'Creamos los registros
            Dim dt As DataTable = GridEditable1.DataSource
            If Not IsNothing(dt) Then

                For Each row As DataRow In dt.Rows

                    Dim IdEnvase As String = (row("IdEnvase").ToString & "").Trim
                    Dim CodFianza As String = (row("CodFianza").ToString & "").Trim

                    If CodFianza <> "" Then

                        Dim DomiciliosFianzas_New As New E_DomiciliosFianzas(Idusuario, cn)
                        DomiciliosFianzas_New.DFZ_Id.Valor = DomiciliosFianzas_New.MaxId.ToString
                        DomiciliosFianzas_New.DFZ_IdDomicilio.Valor = _IdDomicilio
                        DomiciliosFianzas_New.DFZ_IdEnvase.Valor = IdEnvase
                        DomiciliosFianzas_New.DFZ_CodigoFianza.Valor = CodFianza
                        DomiciliosFianzas_New.Insertar()

                    End If


                Next

            End If


        End If

    End Sub



    Private Sub Bsalir_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Bsalir.KeyDown, BGuardar.KeyDown, GridEditable1.KeyDown

        If e.KeyCode = Keys.F12 Then

            Bsalir.PerformClick()
            e.Handled = True

        ElseIf e.KeyCode = Keys.F5 Then
            BConsultar.PerformClick()
            e.Handled = True

        ElseIf e.KeyCode = Keys.F10 Then

            BGuardar.PerformClick()
            e.Handled = True

        End If

    End Sub


    Private Sub GridEditable1_ColumnaSiguiente(IndiceFila As System.Int32, IndiceColumna As System.Int32, ByRef NuevaFila As System.Int32, ByRef NuevaColumna As System.Int32) Handles GridEditable1.ColumnaSiguiente

        Try

            Dim rowActual As DataRow = GridEditable1.GridView.GetDataRow(IndiceFila)
            Dim colActual As DevExpress.XtraGrid.Columns.GridColumn = GridEditable1.GridView.GetVisibleColumn(IndiceColumna)

            If colActual.FieldName.ToUpper.Trim = "CODFIANZA" Then
                GridEditable1_Valida(rowActual, colActual)
            End If


            NuevaColumna = IndiceColumna
            NuevaFila = IndiceFila + 1

        Catch ex As Exception

        End Try



    End Sub


    Private Sub GridEditable1_Valida(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn) Handles GridEditable1.Valida



    End Sub


End Class