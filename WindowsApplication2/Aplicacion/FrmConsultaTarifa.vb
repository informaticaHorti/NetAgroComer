Public Class FrmConsultaTarifa
    Dim IdTarifa As Integer
    Public Sub Init(ByVal tarifa As Integer, ByVal NombreTarifa As String)
        GridView.OptionsView.ShowGroupPanel = False
        GridView.OptionsBehavior.Editable = False
        GridView.OptionsView.ColumnAutoWidth = True
        Lb10.Text = NombreTarifa
        IdTarifa = tarifa
        CargaDatos()
    End Sub

    Private Sub CargaDatos()
        Dim dt As New DataTable
        Dim Sql As String
        Dim dtc As New DataTable
        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim TiposdeGastosAgri As New E_TiposdeGastoAgri(Idusuario, cn)

        Sql = "Select nombre from centros order by idcentro"
        dtc = Centros.MiConexion.ConsultaSQL(Sql)

        dt.Columns.Add("codigo")
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Tipo")
        dt.Columns.Add("F/C")
        For Each c As DataRow In dtc.Rows
            dt.Columns.Add(c(0))
        Next
       
        Grid.DataSource = dt
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView.Columns
            Select Case c.FieldName.ToLower
                Case "codigo"
                    c.Width = 100
                Case "nombre"
                    c.Width = 500
                Case "tipo"
                    c.Width = 100
                Case "f/c"
                    c.Width = 100
                Case Else
                    c.Width = 300
            End Select

        Next

        GridView.Columns("Nombre").Width = 300
        GridView.Columns("codigo").Width = 100
        GridView.Columns("Tipo").Width = 100
        GridView.Columns("F/C").Width = 100
        Sql = "Select * from tiposdegastosagri order by TGA_idtipogasto"
        dtc = TiposdeGastosAgri.MiConexion.ConsultaSQL(Sql)
        Dim x As Integer = 0
        Dim nombre As String = ""
        For Each c As DataRow In dtc.Rows
            dt.Rows.Add(c(0).ToString, c(1).ToString, c(2).ToString, c(3).ToString)
        Next

        Sql = "Select TCL_idgasto as IdGasto, TCL_valorgasto as ValorGasto, dbo.centros.nombre as centro from tarifasagricultoreslineas, dbo.centros where TCL_idtarifaagricultor=" + IdTarifa.ToString
        Sql = Sql + " and dbo.centros.idcentro = TCL_idcentro"
        dtc = TiposdeGastosAgri.MiConexion.ConsultaSQL(Sql)
        For Each c As DataRow In dtc.Rows
            x = 0
            nombre = c("centro")
            For Each d As DataRow In dt.Rows
                If d("codigo") = c("idgasto") Then
                    dt.Rows(x)(nombre) = c("valorgasto")
                End If
                x = x + 1
            Next
        Next


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class