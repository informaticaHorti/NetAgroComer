
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls


Public Class FrmEnvioMasivoEmail
    Inherits FrConsulta


    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Facturas As New E_Facturas(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)


    Dim err As New Errores



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub



    Private Sub ParametrosFrm()


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxCliente, Facturas.FRA_idcliente, LbCliente)
        ParamTx(TxDesdeFecha, Facturas.FRA_fecha, LbDesdeFecha, True)
        ParamTx(TxHastaFecha, Facturas.FRA_fecha, LbHastaFecha, True)


        AsociarControles(TxCliente, BtBuscaCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomCliente)


    End Sub


    Private Sub FrmConsultaEntradas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Text = "Enviar"
        BInforme.Image = My.Resources.mail_message_new

        'BInforme.Visible = False


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        FechasPorDefecto()

    End Sub


    Private Sub FechasPorDefecto()

        If TxDesdeFecha.Text.Trim = "" Then TxDesdeFecha.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        If TxHastaFecha.Text.Trim = "" Then TxHastaFecha.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")

    End Sub




    Public Overrides Sub Consultar()
        MyBase.Consultar()

        GridView1.Columns.Clear()

        If VaInt(TxCliente.Text) = 0 Then
            MsgBox("Debe introducir un cliente")
            Exit Sub
        End If


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Facturas.FRA_campa, "Campa")
        consulta.SelCampo(Facturas.FRA_idcentro, "IdCentro")
        consulta.SelCampo(Centros.Nombre, "Centro", Facturas.FRA_idcentro)
        consulta.SelCampo(Facturas.FRA_idfactura, "IdFactura")
        consulta.SelCampo(Facturas.FRA_serie, "Serie")
        consulta.SelCampo(Facturas.FRA_factura, "Numero")
        consulta.SelCampo(Facturas.FRA_RefCliente, "RefCliente")
        consulta.SelCampo(Facturas.FRA_totalfactura, "Total")
        consulta.WheCampo(Facturas.FRA_idcliente, "=", TxCliente.Text)
        If TxDesdeFecha.Text.Trim <> "" Then consulta.WheCampo(Facturas.FRA_fecha, ">=", TxDesdeFecha.Text)
        If TxHastaFecha.Text.Trim <> "" Then consulta.WheCampo(Facturas.FRA_fecha, "<=", TxHastaFecha.Text)


        Dim sql As String = consulta.SQL & " ORDER BY FRA_Fecha DESC"
        Dim dt As DataTable = Facturas.MiConexion.ConsultaSQL(sql)

        Dim colSel As New DataColumn("S", GetType(Boolean))
        colSel.DefaultValue = False
        dt.Columns.Add(colSel)


        Grid.DataSource = dt


        'OJO con las mayúsculas / minúsculas


        AjustaColumnas()



    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDFACTURA", "IDCENTRO"
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim


                Case "CAMPA"
                    c.MinWidth = 50
                    c.MaxWidth = 50

                Case "CENTRO"
                    c.Width = 120

                Case "SERIE"
                    c.MinWidth = 50
                    c.MaxWidth = 50

                Case "NUMERO"

                Case "REFCLIENTE"
                    c.MinWidth = 120

                Case "TOTAL"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 100

                Case "S"
                    c.MaxWidth = 20
                    c.MinWidth = 20
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            End Select

        Next


    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)


        If Not IsNothing(row) Then

            If column.FieldName.ToUpper.Trim = "S" Then
                If row("S") = True Then
                    row("S") = False
                Else
                    row("S") = True
                End If
            End If

        End If

    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()


        Dim Cliente As String = "Cliente: " & TxCliente.Text & " - " & LbNomCliente.Text
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDesdeFecha.Text, TxHastaFecha.Text)

        If Cliente <> "" Then LineasDescripcion.Add(Cliente)
        If fechas <> "" Then LineasDescripcion.Add(fechas)

        MyBase.Imprimir()

    End Sub


    Private Sub BtSelNinguno_Click(sender As System.Object, e As System.EventArgs) Handles BtSelNinguno.Click

        For indice As Integer = 0 To GridView1.RowCount - 1

            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = False
            End If

        Next

    End Sub


    Private Sub BtSelTodos_Click(sender As System.Object, e As System.EventArgs) Handles BtSelTodos.Click

        For indice As Integer = 0 To GridView1.RowCount - 1

            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = True
            End If

        Next

    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()

        EnviarFacturas()

    End Sub



    Private Sub EnviarFacturas()


        Dim lstFacturas As New List(Of String)


        For indice As Integer = 0 To GridView1.RowCount - 1

            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then

                If row("S") = True Then

                    Dim IdFactura As String = (row("IdFactura").ToString & "").Trim
                    lstFacturas.Add(IdFactura)

                End If

            End If

        Next


        If lstFacturas.Count = 0 Then
            MsgBox("No hay facturas seleccionadas")
        Else

            Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
            Dim ruta As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_ARCHIVOS_ADJUNTOS_TEMP)
            If Not ruta.EndsWith("\") Then ruta = ruta & "\"
            Dim prefijoarchivo As String = "FRA_CLI" & TxCliente.Text & "_"
            Dim lstAdjuntos As New List(Of String)
            Dim lstMails As New List(Of String)


            If Not IO.Directory.Exists(ruta) Then
                MsgBox("Error al exportar la factura a PDF, no existe la carpeta temporal " & ruta)
                Exit Sub
            End If


            '1) Obtener los PDFs y creamos la lista de adjuntos
            For Each IdFactura As String In lstFacturas

                Dim archivo As String = prefijoarchivo & IdFactura & ".pdf"
                C1_ImprimirFacturaComercializacion(IdFactura, TipoImpresion.ExportacionPDF, , ruta, archivo)
                lstAdjuntos.Add(ruta & archivo)

            Next


            '2) Obtener las direcciones de mail de la ficha de cliente --> Emails facturas
            Dim Clientes As New E_Clientes(Idusuario, cn)
            If Clientes.LeerId(TxCliente.Text) Then

                Dim email1 As String = (Clientes.CLI_emailped1.Valor & "").Trim
                Dim email2 As String = (Clientes.CLI_emailped2.Valor & "").Trim
                Dim email3 As String = (Clientes.CLI_emailped3.Valor & "").Trim

                If email1.Trim <> "" Then lstMails.Add(email1)
                If email2.Trim <> "" Then lstMails.Add(email2)
                If email3.Trim <> "" Then lstMails.Add(email3)

            Else
                MsgBox("No existe el cliente con Id " & TxCliente.Text)
                Exit Sub
            End If

            If lstMails.Count = 0 Then
                MsgBox("ATENCIÓN: No hay ningún email de facturas asociados a este cliente")
            End If


            '3) Mostrar preliminar de direcciones 
            Dim frm As New FrmPedirDatosEmail
            Dim asunto As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.TEXTO_ASUNTO_FACTURAS_EMAIL) & ""
            If asunto.Trim = "" Then asunto = "Facturas pendientes"
            frm.Init(lstMails, asunto)
            frm.ShowDialog()


            '4) Realizar el envío (uno conjunto por email)
            If frm.Resultado = FrmPedirDatosEmail.ResultadoFormulario.Enviar Then


                Dim txtError As String = EnviarMailOutlook(frm.Destinatarios, lstAdjuntos, frm.Asunto, frm.Texto)

                If txtError.Trim <> "" Then
                    MsgBox("No se ha podido enviar el documento: " & txtError)
                Else
                    MsgBox("Mensaje enviado")
                End If

                For Each a As String In lstAdjuntos
                    If IO.File.Exists(a) Then
                        Try
                            My.Computer.FileSystem.DeleteFile(a)
                        Catch ex As Exception
                        End Try
                    End If
                Next


            End If


        End If


    End Sub


End Class