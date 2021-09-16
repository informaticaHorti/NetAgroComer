Public Class FrmCatComercial
    Inherits FrMantenimiento
    Dim CategoriasComercial As New E_CategoriasComercial(Idusuario, cn)
    Dim CatSalidaComercial As New E_CatSalidaComercial(Idusuario, cn)

    Dim CargandoCategoria As Boolean

    Private Sub ParametrosFrm()
        EntidadFrm = CategoriasComercial


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, CategoriasComercial.CAC_IdCategoria, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, CategoriasComercial.CAC_Nombre, Lb2)

        AsociarControles(TxDato1, BtBuscaMarca, CategoriasComercial.btBusca, EntidadFrm)



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

    End Sub

    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()
        CargaChCategoria()
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
        CargaChCategoria()
    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Private Sub CargaChCategoria()

        Dim dt As New DataTable
        Dim sql As String
        Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)

        Dim Consulta2 As New Cdatos.E_select

       
        Consulta2.SelCampo(CategoriasSalida.CAS_Id, "Codigo")
        Consulta2.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria")

        Consulta2.WheCampo(CategoriasSalida.CAS_Id, ">", "0")


        sql = Consulta2.SQL
        dt = CategoriasSalida.MiConexion.ConsultaSQL(sql)

        ChCategoria.DataSource = dt
        ChCategoria.ValueMember = "Codigo"
        ChCategoria.DisplayMember = "Categoria"


        ChCategoria.CheckOnClick = True

        CargandoCategoria = True
        If Val(LbId.Text) > 0 Then
            For indice As Integer = 0 To ChCategoria.ItemCount - 1

                Dim row As DataRowView = ChCategoria.GetItem(indice)
                Dim a As String = row("Codigo").ToString
                If CatSalidaComercial.LeerCat(LbId.Text, a) > 0 Then
                    ChCategoria.SetItemChecked(indice, True)
                End If
            Next
        End If
        CargandoCategoria = False


    End Sub

    Private Sub GuardarChCategoria(Codigo As String, V As Boolean)
        If CargandoCategoria = True Then Exit Sub

        If V = False Then
            BorraChCategoria(Codigo)
        Else

            CatSalidaComercial.VaciaEntidad()
            Dim id As Integer = CatSalidaComercial.MaxId
            CatSalidaComercial.CSC_Id.Valor = id.ToString
            CatSalidaComercial.CSC_Idcatcomercial.Valor = LbId.Text
            CatSalidaComercial.CSC_idCatsalida.Valor = Codigo
            CatSalidaComercial.Insertar()

        End If

    End Sub

    Private Sub BorraChCategoria(codigo As String)
        If Val(LbId.Text) > 0 Then
            Dim sql As String = "delete from catsalidacomericial where csc_idcatcomercial=" + LbId.Text + " and csc_idcatsalida=" + codigo
            CatSalidaComercial.MiConexion.ConsultaSQL(sql)
        End If

    End Sub

    Private Sub ChCategoria_ItemCheck(sender As Object, e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles ChCategoria.ItemCheck
        Dim v As Boolean
        If e.State = CheckState.Checked Then
            v = True
        Else
            v = False
        End If
        Dim C As String = ChCategoria.GetItemValue(e.Index)
        GuardarChCategoria(C, v)

    End Sub


    Private Sub ChCategoria_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ChCategoria.SelectedIndexChanged

    End Sub
End Class