Public Class FrmCatEntrada
    Inherits FrMantenimiento
    Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)
    Dim Tiposdecalibre As New E_TiposdeCalibre(Idusuario, cn)

    Private Sub ParametrosFrm()
        EntidadFrm = CategoriasEntrada


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, CategoriasEntrada.CAE_Id, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, CategoriasEntrada.CAE_Categoria, Lb2)
        ParamCb_Copia(CbBox1, CategoriasEntrada.CAE_IdTipoCategoria, Lb5, Combos.ComboCategorias)
        ParamTx(TxDato4, CategoriasEntrada.CAE_idtipocalibre, Lb4, True)
        ParamTx(TxDato3, CategoriasEntrada.CAE_Calibre, Lb3)
        ParamTx(TxClasificacion, CategoriasEntrada.CAE_clasificacion, LbClasificacion)




        AsociarControles(TxDato1, BtBuscaCategoria, CategoriasEntrada.btBusca, EntidadFrm)
        AsociarControles(TxDato4, BtBusca1, Tiposdecalibre.btBusca, Tiposdecalibre, Tiposdecalibre.TCB_Nombre, lb6)



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
        CategoriasEntrada.CAE_CategoriaCalibre.Valor = TxDato2.Text & " " & TxDato3.Text
        MyBase.Guardar()
        CargaGridFRm()
    End Sub


    Private Sub CargaGridFRm()
        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsView.ColumnAutoWidth = True

        Dim dt As New DataTable
        Dim sql As String
        sql = "Select CAE_id AS id,CAE_categoria as categoria,CAE_calibre as calibre from " + EntidadFrm.NombreTabla + " order by " + EntidadFrm.ClavePrimaria.NombreCampo
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


  
    Private Sub TxDato4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato4.TextChanged

    End Sub

    Private Sub TxDato4_Valida(ByVal edicion As Boolean) Handles TxDato4.Valida
        If edicion = True Then
            If TxDato3.Text = "" Then
                TxDato3.Text = lb6.Text
            End If
        End If
    End Sub
End Class