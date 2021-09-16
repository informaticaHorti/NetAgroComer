Public Class FrmCarga_Inspeccion

    Inherits FrMantenimiento
    Dim ConceptosInspeccion As New E_ConceptosInspeccion(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = ConceptosInspeccion


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, ConceptosInspeccion.CIS_Id, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, ConceptosInspeccion.CIS_Nombre, Lb2)
        ParamTx(TxDato3, ConceptosInspeccion.CIS_sn, Lb3, True, Cdatos.TiposCampo.Cadena, , , "NS")

        AsociarControles(TxDato1, BtBuscaMarca, ConceptosInspeccion.btBusca, EntidadFrm)



        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub
    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text


    End Sub
    Public Overrides Sub Guardar()
        MyBase.Guardar()
        CargaGridFRm()
    End Sub


    Private Sub CargaGridFRm()
        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsView.ColumnAutoWidth = True

        Dim dt As New DataTable
        Dim sql As String
        sql = "Select CIS_id as id,CIS_nombre as nombre from " + EntidadFrm.NombreTabla + " order by " + EntidadFrm.ClavePrimaria.NombreCampo
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

End Class