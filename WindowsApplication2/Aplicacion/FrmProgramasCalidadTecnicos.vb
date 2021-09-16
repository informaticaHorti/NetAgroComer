Public Class FrmProgramasCalidadTecnicos
    Inherits FrMantenimiento


    Dim ProgramaCalidadTecnicos As New E_ProgramaCalidadTecnicos(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = ProgramaCalidadTecnicos


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, ProgramaCalidadTecnicos.PCT_Idprograma, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, ProgramaCalidadTecnicos.PCT_Nombre, Lb2)
        ParamChk(ChControlado, ProgramaCalidadTecnicos.PCT_Controlado, "S", "N")

        AsociarControles(TxDato1, BtBuscaMarca, ProgramaCalidadTecnicos.btBusca, EntidadFrm)



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
        sql = "Select PCT_IdPrograma as id, PCT_nombre as nombre from " + EntidadFrm.NombreTabla + " order by " + EntidadFrm.ClavePrimaria.NombreCampo
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