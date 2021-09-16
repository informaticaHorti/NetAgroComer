Public Class FrmEmpresas
    Inherits FrMantenimiento
    Dim Empresas As New E_Empresas(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = Empresas


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Empresas.Emp_Idempresa, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, Empresas.EMP_Nombre, Lb2)
        ParamTx(TxDomicilio, Empresas.EMP_Domicilio, LbDomicilio)
        ParamTx(TxCIF, Empresas.EMP_CIF, LbCIF)
        ParamTx(TxTelefono, Empresas.EMP_Telefono, LbTelefono)


        AsociarControles(TxDato1, BtBuscaMarca, Empresas.btBusca, EntidadFrm)



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
        GridView.OptionsView.ShowGroupPanel = False
        GridView.OptionsBehavior.Editable = False
        GridView.OptionsView.ColumnAutoWidth = True

        Dim dt As New DataTable
        Dim sql As String
        sql = "Select emp_idempresa as id,emp_nombre as nombre from " + EntidadFrm.NombreTabla + " order by " + EntidadFrm.ClavePrimaria.NombreCampo
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


    Private Sub GridView1_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
        With TxDato1
            ' If .Enabled = True Then
            .Text = GridView.GetRowCellValue(e.RowHandle, "id")
            .Validar(True)
            If .MiError = False Then
                .ClForm.Siguiente(.Orden)
            End If


            'End If
        End With
    End Sub

    Private Sub FrmMarcas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MinimumSize = Me.Size
    End Sub
End Class