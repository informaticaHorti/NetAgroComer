Public Class FrmVendedor

    Inherits FrMantenimiento
    Dim Vendedores As New E_Vendedores(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = Vendedores


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Vendedores.VED_idcomercial, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave

        ParamTx(TxDato2, Vendedores.VED_nombre, Lb2)
        ParamTx(TxDato3, Vendedores.VED_telefono, Lb3)

        AsociarControles(TxDato1, BtBuscaVdor, Vendedores.btBusca, EntidadFrm)



        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


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
        sql = "Select * from " + EntidadFrm.NombreTabla + " order by " + EntidadFrm.ClavePrimaria.NombreCampo
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
            .Text = GridView1.GetRowCellValue(e.RowHandle, EntidadFrm.ClavePrimaria.NombreCampo)
            .Validar(True)
            If .MiError = False Then
                .ClForm.Siguiente(.Orden)
            End If


            'End If
        End With
    End Sub



    Private Sub Grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.Click

    End Sub

    Private Sub TxDato3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato3.TextChanged

    End Sub

    Private Sub TxDato3_Valida(ByVal edicion As Boolean) Handles TxDato3.Valida
        If TxDato3.Text = "1" Then
            TxDato3.MiError = True

        End If
    End Sub
End Class