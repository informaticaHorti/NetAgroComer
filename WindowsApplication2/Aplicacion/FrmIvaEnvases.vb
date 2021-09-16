Public Class FrmIvaEnvases
    Inherits FrMantenimiento
    Dim TiposIva As New E_tiposiva(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = TiposIva


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, TiposIva.TIV_Id, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, TiposIva.TIV_iva, Lb2)
        ParamTx(TxDato3, TiposIva.TIV_re, Lb3)



    End Sub
    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text


    End Sub
    Public Overrides Sub Guardar()
        Dim a = ""
        MyBase.Guardar()
        CargaGridFRm()
    End Sub


    Private Sub CargaGridFRm()
        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsView.ColumnAutoWidth = True

        Dim dt As New DataTable
        Dim sql As String
        sql = "Select TIV_id as id,TIV_iva as iva,TIV_re as re from " + EntidadFrm.NombreTabla + " order by " + EntidadFrm.ClavePrimaria.NombreCampo
        dt = EntidadFrm.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
        CargaGridFRm()
    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Private Sub GridView1_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        With TxDato1
            ' If .Enabled = True Then
            .Text = GridView1.GetRowCellValue(e.RowHandle, "id")
            .Validar(True)
            If .MiError = False Then
                .ClForm.Siguiente(.Orden)
            End If


            'End If
        End With
    End Sub





   
    Private Sub Grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.Click

    End Sub
End Class