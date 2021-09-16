
Public Class FrmConsultaAlbaranes
    Inherits FrConsulta

    Private Sub ParametrosFrm()
       
        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Agricultores.AGR_idagricultor, Lb1)
        ParamTx(TxDato2, Agricultores.AGR_idagricultor, Lb3)
        ParamTx(TxDato4, Nothing, Lb5, False, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato3, Nothing, Lb4, False, Cdatos.TiposCampo.Fecha)




        AsociarControles(TxDato1, BtBuscaAg1, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb19)
        AsociarControles(TxDato2, BtBuscaAg2, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb2)




    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(ByVal Titulo As String)

        Me.New()

        Me.Text = Titulo

    End Sub



    Public Overrides Sub Consultar()

        MyBase.Consultar()

        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
        Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)

        Dim Consulta As New Cdatos.E_select
        Dim DT As New DataTable
        Dim sql As String
        Consulta.SelCampo(Albentrada_lineas.AEL_muestreo, "muestreo")
        Consulta.SelCampo(Albentrada.AEN_Albaran, "Albaran", Albentrada_lineas.AEL_idalbaran, Albentrada.AEN_IdAlbaran)
        Consulta.SelCampo(Albentrada.AEN_Fecha, "Fecha")
        Consulta.SelCampo(Agricultores.AGR_Nombre, "Nombre", Albentrada.AEN_IdAgricultor, Agricultores.AGR_IdAgricultor)
        Consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albentrada_lineas.AEL_idgenero)
        Consulta.SelCampo(Albentrada_lineas.AEL_bultos, "bultos")
        Consulta.SelCampo(Albentrada_lineas.AEL_kilosnetos, "Kilos")
        Consulta.WheCampo(Agricultores.AGR_IdAgricultor, ">=", TxDato1.Text)
        Consulta.WheCampo(Agricultores.AGR_IdAgricultor, "<=", TxDato2.Text)
        Consulta.WheCampo(Albentrada.AEN_Fecha, ">=", TxDato4.Text)
        Consulta.WheCampo(Albentrada.AEN_Fecha, "<=", TxDato3.Text)





        sql = Consulta.SQL


        DT = Albentrada.MiConexion.ConsultaSQL(Consulta.SQL)
        Grid.DataSource = DT
        GridView1.BestFitColumns()


        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("bultos", "{0:n2}")
        AñadeResumenCampo("Kilos", "{0:n2}")



    End Sub



    Private Sub FrmConsultaAlbaranes_AntesDeMostrarTablaDinamica(ByVal f As NetAgro.FrTablaDinamica) Handles MyBase.AntesDeMostrarTablaDinamica

        'Ejemplo para añadir descripciones al informe
        'Dim lst As New List(Of String)
        'lst.Add("Aquí se pueden añadir")
        'lst.Add("líneas de descripción")
        'f.LineasDescripcion = lst

    End Sub


    Private Sub FrmConsultaAlbaranes_DespuesDeIncluirCampoCalculado(ByVal c As DevExpress.XtraGrid.Columns.GridColumn) Handles MyBase.DespuesDeIncluirCampoCalculado
        AñadeResumenCampo(c.FieldName, "{0:n2}")
    End Sub
End Class