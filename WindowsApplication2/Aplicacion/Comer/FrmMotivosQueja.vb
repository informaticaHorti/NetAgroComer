Public Class FrmMotivosQueja
    Inherits FrMantenimiento


    Dim MotivosQueja As New E_MotivosQueja(Idusuario, cn)
    Dim Reclama_Origen As New E_Reclama_origen(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        EntidadFrm = MotivosQueja

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, MotivosQueja.MTQ_Id, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamCb_Copia(CbOrigen, MotivosQueja.MTQ_Idorigen, Lb2, Combos.ComboOrigenReclamaciones)
        ParamTx(TxDato3, MotivosQueja.MTQ_Nombre, Lb3)

        AsociarControles(TxDato1, BtBusca1, MotivosQueja.btBusca, EntidadFrm)


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

        CargaGridFrm()

    End Sub


    Private Sub CargaGridFrm()

        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsView.ColumnAutoWidth = True


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(MotivosQueja.MTQ_Id, "Id")
        CONSULTA.SelCampo(MotivosQueja.MTQ_Nombre, "Motivo")
        CONSULTA.SelCampo(Reclama_Origen.RCO_Nombre, "Origen", MotivosQueja.MTQ_Idorigen, Reclama_Origen.RCO_Idorigen)

        Dim sql As String = CONSULTA.SQL
        sql = sql & " ORDER BY MTQ_Id"

        Dim dt As DataTable = EntidadFrm.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt

        GridView1.BestFitColumns()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
        CargaGridFRm()
    End Sub


    Private Sub GridView1_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick

        With TxDato1
            .Text = GridView1.GetRowCellValue(e.RowHandle, "id")
            .Validar(True)
            If .MiError = False Then
                .ClForm.Siguiente(.Orden)
            End If

        End With

    End Sub

End Class