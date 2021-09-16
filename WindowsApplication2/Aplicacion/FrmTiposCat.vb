Public Class FrmTiposCat
    Inherits FrMantenimiento
    Dim TiposdeCategoria As New E_TiposdeCategoria(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = TiposdeCategoria


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, TiposdeCategoria.TCA_Id, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, TiposdeCategoria.TCA_Nombre, Lb2)
        ParamCb_Copia(CbBox1, TiposdeCategoria.TCA_Tipo, Lb5, Combos.ComboTiposCat)
        ParamTx(TxAbreviatura, TiposdeCategoria.TCA_Abreviatura, LbAbreviatura)




        AsociarControles(TxDato1, BtBuscaTgasto, TiposdeCategoria.btBusca, EntidadFrm)



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

    Private Sub CbBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxAbreviatura.Select()
            TxAbreviatura.Focus()
        End If
    End Sub
End Class