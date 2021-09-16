Public Class FrmFamilias
    Inherits FrMantenimiento



    'Dim Centros As New E_centros(Idusuario,ConexCTB(Mimaletin.IdempresaCTB))
    Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)
    Dim Familias As New E_FamiliasGeneros(Idusuario, cn)
    Dim subFamilias As New E_Subfamilias(Idusuario, cn)
    Dim familiascategorias As New E_FamiliasCategorias(Idusuario, cn)
    Dim Descuentos As New E_FamiliasDescuentos(Idusuario, cn)
    Dim Primero As Boolean




    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)
    End Sub

    Public Overrides Sub borrapan()
        XtraTabControl1.SelectedTabPageIndex = 0

        MyBase.BorraPan()
        Pintagrids()
    End Sub


    Private Sub Pintagrids()
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim Sql As String
        Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)
        Dim CategoriasComercial As New E_CategoriasComercial(Idusuario, cn)


        Dim dd As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit



        Sql = "Select CAE_id as id, CAE_categoriacalibre as categoriacalibre from categoriasentrada order by CAE_id"


        dt = CategoriasEntrada.MiConexion.ConsultaSQL(Sql)
        dt2 = CategoriasEntrada.MiConexion.ConsultaSQL(Sql)

        dd.DataSource = dt2
        dd.ValueMember = "id"
        dd.DisplayMember = "categoriacalibre"
        dd.NullText = ""
        dt.Columns.Add("X", GetType(System.Boolean))
        For Each col In dt.Rows

            col("X") = False
            If familiascategorias.LeerCat(VaInt(TxDato1.Text), VaInt(col("id")), "E") > 0 Then
                col("X") = True
            End If
        Next


        GridCateEnt.DataSource = dt
        GridCatEntView.BestFitColumns()


        ' comercial

        Dim consulta2 As New Cdatos.E_select
        consulta2.SelCampo(CategoriasComercial.CAC_IdCategoria, "id")
        consulta2.SelCampo(CategoriasComercial.CAC_Nombre, "CategoriaCalibre")
        Sql = consulta2.SQL
        Sql = Sql + " order by CAC_idcategoria"

        dt = CategoriasComercial.MiConexion.ConsultaSQL(Sql)
        dt.Columns.Add("X", GetType(System.Boolean))


        For Each col In dt.Rows
            col("X") = False
            Dim r As Integer
            r = familiascategorias.LeerCat(VaInt(TxDato1.Text), VaInt(col("id")), "C")
            If r > 0 Then
                If familiascategorias.LeerId(r) = True Then
                    col("X") = True

                    ' col("catentrada") = VaInt(FamiliasCategorias.FAC_idCategoriaentrada.Valor)
                End If
            End If

        Next


        GridCateSal.DataSource = dt




        ' GridCateSalView.Columns("catentrada").ColumnEdit = dd
        GridCateSalView.BestFitColumns()


    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()
    End Sub
    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()
        ' llenar el grid
        CargaLineasGrid()
        CargaLineasGridGastos()
        Pintagrids()
    End Sub
    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        SubFamilias.SFA_idfamilia.Valor = TxDato1.Text

        Descuentos.FAD_idfamilia.Valor = TxDato1.Text


        If UCase(Gr.Name) = UCase("ClGrid1") Then
            GuardaCategorias(TxDato1.Text)
        End If
        Return MyBase.GuardarLineas(Gr)
    End Function

    Private Sub GuardaCategorias(ByVal IdFamilia As String)
        If VaInt(TxDato1.Text) > 0 Then
            Dim Sql As String
            Sql = "Delete from familiascategorias where FAC_idfamilia=" + TxDato1.Text
            familiascategorias.MiConexion.OrdenSql(Sql)
            With GridCatEntView
                For x = 0 To .RowCount - 1
                    If .GetDataRow(x)("X") = True Then
                        familiascategorias.VaciaEntidad()
                        familiascategorias.FAC_Id.Valor = Familias.MaxId().ToString
                        FamiliasCategorias.FAC_Idfamilia.Valor = TxDato1.Text
                        FamiliasCategorias.FAC_idCategoriaentrada.Valor = .GetDataRow(x)(0).ToString
                        familiascategorias.FAC_idCategoriaComercial.Valor = ""
                        familiascategorias.Insertar()
                    End If
                Next


            End With





            For x = 0 To GridCateSalView.RowCount - 1


                If GridCateSalView.GetDataRow(x)("X") = True Then
                    Dim r As DataRowView
                    r = GridCateSalView.GetRow(x)

                    'Dim i As Integer
                    'i = GridCateSalView.GetDataRow(x)("catentrada")

                    familiascategorias.VaciaEntidad()
                    familiascategorias.FAC_Id.Valor = Familias.MaxId().ToString
                    FamiliasCategorias.FAC_Idfamilia.Valor = TxDato1.Text
                    familiascategorias.FAC_idCategoriaentrada.Valor = ""
                    familiascategorias.FAC_idCategoriaComercial.Valor = r("id").ToString
                    familiascategorias.Insertar()


                End If
            Next


        End If



    End Sub

    Public Overrides Sub Guardar()
        Dim a = ""
        GuardaCategorias(TxDato1.Text)
        MyBase.Guardar()

    End Sub
    Private Sub CargaLineasGrid()
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 
        Dim sql As String
        sql = "Select SFA_id , SFA_codigo as Codigo, SFA_nombre as Nombre from subfamilias where SFA_idfamilia=" + TxDato1.Text
        ClGrid1.Consulta = sql
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)

        If Not IsNothing(ClGrid1.GridView.Columns.ColumnByFieldName("Codigo")) Then
            ClGrid1.GridView.Columns.ColumnByFieldName("Codigo").MaxWidth = 80
        End If

    End Sub



    Private Sub CargaLineasGridGastos()
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 
        Dim sql As String
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Descuentos.FAD_id, "")
        consulta.SelCampo(CentrosRecogida.CER_Nombre, "Centro", Descuentos.FAD_idcentro)
        consulta.SelCampo(Descuentos.FAD_dtobascula, "DtoBascula")
        '        consulta.SelCampo(Descuentos.FAD_dtobasculafirme, "DtoBasculaFirme")
        '        consulta.SelCampo(Descuentos.FAD_mermasfirme, "MermasFirme")
        consulta.SelCampo(Descuentos.FAD_estructura, "Estructura")
        consulta.SelCampo(Descuentos.FAD_DtoBasculaFirme, "DtoFirme")
        consulta.SelCampo(Descuentos.FAD_DtoBasculaFirmeSinClasif, "DtoFirmeSinClasif")


        consulta.WheCampo(Descuentos.FAD_idfamilia, "=", TxDato1.Text)
        sql = consulta.SQL
        sql = sql + " order by fad_id"

        ClGrid2.Consulta = sql
        ClGrid2.Nlinea = -1
        Cargalineas(ClGrid2)
    End Sub

    Private Sub parametrosfrm()
        EntidadFrm = Familias


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Familias.FAG_idfamilia, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, Familias.FAG_nombre, Lb2)


        ParamTx(TxDato3, Familias.FAG_intrastat1, Lb3)
        ParamTx(TxDato4, Familias.FAG_desde, Lb4)
        ParamTx(TxDato5, Familias.FAG_hasta, Lb5)
        ParamTx(TxDato6, Familias.FAG_intrastat2, Lb6)
        ParamTx(TxDato7, Familias.FAG_valorestadistico, Lb7)

        ParamTx(TxDato8, SubFamilias.SFA_codigo, Lb8)
        ParamTx(TxDato9, SubFamilias.SFA_nombre, Lb9)

        ParamTx(TxDato11, Descuentos.FAD_idcentro, Lb11, True)
        ParamTx(TxDato10, Descuentos.FAD_dtobascula, Lb10)
        '        ParamTx(TxDato12, Descuentos.FAD_dtobasculafirme, Lb12)
        '        ParamTx(TxDato13, Descuentos.FAD_mermasfirme, Lb13)
        ParamTx(TxDato14, Descuentos.FAD_estructura, Lb14, False, Cdatos.TiposCampo.Importe, 5, 10)
        ParamTx(TxDtoFirme, Descuentos.FAD_DtoBasculaFirme, LbDtoFirme)
        ParamTx(TxDtoFirmeSinClasificar, Descuentos.FAD_DtoBasculaFirmeSinClasif, LbDtoFirmeSinClasificar)


        AsociarControles(TxDato1, BtBuscaFamilia, Familias.btBusca, EntidadFrm)
        AsociarControles(TxDato11, BtBuscaCentro, CentrosRecogida.btBusca, CentrosRecogida, CentrosRecogida.CER_Nombre, Lb15)


        AsociarGrid(ClGrid1, TxDato8, TxDato9, subFamilias)

        AsociarGrid(ClGrid2, TxDato11, TxDtoFirmeSinClasificar, Descuentos)


        PropiedadesCamposGr(ClGrid1, "SFA_id", "", False, 0)
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 50)
        PropiedadesCamposGr(ClGrid1, "Nombre", "Nombre", True, 100)
        PropiedadesCamposGr(ClGrid2, Descuentos.FAD_id.NombreCampo, "", False, 0)
        PropiedadesCamposGr(ClGrid2, "Centro", "Centro", True, 150)
        PropiedadesCamposGr(ClGrid2, "DtoBascula", "DtoBascula", True, 50, False, "#0.0000")
        '        PropiedadesCamposGr(ClGrid2, "DtoBasculaFirme", "DtoBasculaFirme", True, 50, False, "#0.0000")
        '        PropiedadesCamposGr(ClGrid2, "MermasFirme", "MermasFirme", True, 50, False, "#0.0000")
        PropiedadesCamposGr(ClGrid2, "Estructura", "Estructura", True, 50, False, "#0.0000")
        PropiedadesCamposGr(ClGrid2, "DtoFirme", "DtoFirme", True, 50, False, "#0.0000")
        PropiedadesCamposGr(ClGrid2, "DtoFirmeSinClasif", "DtoFirmeSinClasif", True, 50, False, "#0.0000")


        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub


    Private Sub TxDato1_Valida(ByVal edicion As Boolean) Handles TxDato1.Valida
        If edicion = True Then
            CargaLineasGrid()
            CargaLineasGridGastos()
        End If

    End Sub


    Private Sub GridCatEntView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridCatEntView.RowCellClick
        If e.Column.FieldName = "X" Then
            If e.CellValue = False Then
                GridCatEntView.SetRowCellValue(e.RowHandle, "X", True)
            Else
                GridCatEntView.SetRowCellValue(e.RowHandle, "X", False)

            End If
            Modificando = True
        End If
    End Sub


    Private Sub FrmFamilias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridCatEntView.OptionsView.ShowGroupPanel = False
        GridCatEntView.OptionsBehavior.Editable = False
        GridCatEntView.OptionsView.ColumnAutoWidth = False
        GridCateSalView.OptionsView.ShowGroupPanel = False
        GridCateSalView.OptionsBehavior.Editable = False
        GridCateSalView.OptionsView.ColumnAutoWidth = False

    End Sub

   
    Private Sub GridCateSalView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridCateSalView.RowCellClick

        Dim idcatentrada As String

        Select Case UCase(e.Column.FieldName)

            Case "catentrada"

            Case "X"
                If e.CellValue = False Then
                    idcatentrada = GridCatEntView.GetRowCellValue(GridCatEntView.FocusedRowHandle, "id")
                    GridCateSalView.SetRowCellValue(e.RowHandle, "X", True)
                Else
                    GridCateSalView.SetRowCellValue(e.RowHandle, "X", False)
                End If

                Modificando = True

            Case Else

        End Select

    End Sub

   
   

    Private Sub GridCateSal_Click(sender As System.Object, e As System.EventArgs) Handles GridCateSal.Click

    End Sub

    Private Sub GridCateCom_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btGenerar_Click(sender As System.Object, e As System.EventArgs) Handles btGenerar.Click

        Dim sql As String = "SELECT * FROM FamiliasDescuentos WHERE FAD_IdCentro = 1"
        Dim dt As DataTable = Familias.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows
                For idcentro As Integer = 3 To 6
                    Dim FamiliasDescuentos As New E_FamiliasDescuentos(Idusuario, cn)
                    FamiliasDescuentos.FAD_id.Valor = FamiliasDescuentos.MaxId
                    FamiliasDescuentos.FAD_idfamilia.Valor = row("FAD_IdFamilia").ToString & ""
                    FamiliasDescuentos.FAD_dtobascula.Valor = row("FAD_dtobascula").ToString & ""
                    FamiliasDescuentos.FAD_DtoBasculaFirme.Valor = row("FAD_DtoBasculaFirme").ToString & ""
                    FamiliasDescuentos.FAD_mermasfirme.Valor = row("FAD_mermasfirme").ToString & ""
                    FamiliasDescuentos.FAD_estructura.Valor = row("FAD_estructura").ToString & ""
                    FamiliasDescuentos.FAD_DtoBasculaFirmeSinClasif.Valor = row("FAD_DtoBasculaFirmeSinClasif").ToString & ""
                    FamiliasDescuentos.FAD_idcentro.Valor = idcentro.ToString
                    FamiliasDescuentos.Insertar()
                Next
            Next
        End If

        MsgBox("Terminado!")

    End Sub
End Class