Imports DevExpress.XtraEditors
Imports SharpSsh





Public Class FrMMensajesUsuario

    Dim MensajesEntidades As New E_mensajesentidades(Idusuario, cn)
    Dim usuarios As New E_Usuarios(Idusuario, CnComun)

    Dim err As New Errores()

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub



    Private Sub CargaMensajes()
        Dim sql As String = ""

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(MensajesEntidades.PMJ_id, "id")
        consulta.SelCampo(MensajesEntidades.PMJ_fecha, "Fecha")
        consulta.SelCampo(MensajesEntidades.PMJ_hora, "Hora")
        consulta.SelCampo(MensajesEntidades.PMJ_Referencia, "Referencia")
        consulta.SelCampo(MensajesEntidades.PMJ_mensaje, "Mensaje")
        consulta.SelCampo(MensajesEntidades.PMJ_idusuarioLeido, "idusuarioleido")
        consulta.SelCampo(usuarios.Nombre, "De", MensajesEntidades.PMJ_idusuarioDe)

        consulta.WheCampo(MensajesEntidades.PMJ_idusuarioPara, "=", Idusuario.ToString)
        consulta.WheCampo(MensajesEntidades.PMJ_idusuarioLeido, "=", "0")
        sql = consulta.SQL
        Dim dt As DataTable = MensajesEntidades.MiConexion.ConsultaSQL(sql)
        dt.Columns.Add(New DataColumn("LEIDO", GetType(Boolean)))


        For Each RW In dt.Rows
            If VaInt(RW("idusuarioleido")) > 0 Then
                RW("LEIDO") = True
            Else
                RW("LEIDO") = False
            End If
        Next
        Grid.DataSource = dt

        AjustaColumnas()

    End Sub
    Private Sub Bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsalir.Click

        Me.Close()
    End Sub

    Private Sub AjustaColumnas()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "FECHA", "HORA", "LEIDO"
                    c.Width = 60

                Case "DE"
                    c.Width = 100


                Case "MENSAJE", "REFERENCIA"
                    c.Width = 200

                Case Else
                    c.Visible = False
            End Select
        Next
        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsBehavior.Editable = False

    End Sub

    Protected Sub RowCellStyle(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn, sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)



        Select Case row("LEIDO")
            Case True
                e.Appearance.BackColor = Color.LightGreen

        End Select




    End Sub



    Private Sub GridView1_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        If FnLeft(e.DisplayText, 10) = "01/01/1900" Then
            e.DisplayText = ""
        End If
    End Sub

    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        If e.Column.FieldName.ToUpper = "LEIDO" Then
            If e.CellValue = True Then
                GridView1.SetRowCellValue(e.RowHandle, e.Column, False)
            Else
                GridView1.SetRowCellValue(e.RowHandle, e.Column, True)

            End If
            Dim idlinea As String
            Dim rw As DataRow
            rw = GridView1.GetDataRow(e.RowHandle)
            idlinea = rw("id")
            MarcaLinea(idlinea, e.CellValue)
        End If
    End Sub

    Private Sub MarcaLinea(idmensaje As String, V As Boolean)

        If MensajesEntidades.LeerId(idmensaje) = True Then
            If V = True Then
                MensajesEntidades.PMJ_idusuarioLeido.Valor = Idusuario.ToString
                MensajesEntidades.PMJ_fechaleido.Valor = Format(Now, "dd/MM/yyyy")
                MensajesEntidades.PMJ_horaleido.Valor = Format(Now, "hh:mm")
            Else
                MensajesEntidades.PMJ_idusuarioLeido.Valor = "0"
                MensajesEntidades.PMJ_fechaleido.Valor = ""
                MensajesEntidades.PMJ_horaleido.Valor = ""
            End If

            MensajesEntidades.Actualizar()
        End If

    End Sub


  

    Private Sub FrMMensajesUsuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargaMensajes()
    End Sub

    Private Sub ClButton2_Click_1(sender As System.Object, e As System.EventArgs) Handles ClButton2.Click
        CargaMensajes()
    End Sub
End Class