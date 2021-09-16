Imports DevExpress.XtraEditors


Public Class FrmValoracionSegunClasificacion
    Inherits FrMantenimiento

    Dim _tipo As String

    Class stClave_Valoracion

        Public IdGenero As Integer = 0
        Public Genero As String = ""
        Public IdCategoria As Integer = 0
        Public Categoria As String = ""

        Public Sub New(IdGenero As Integer, Genero As String, IdCategoria As Integer, Categoria As String)

            Me.IdGenero = IdGenero
            Me.Genero = Genero
            Me.IdCategoria = IdCategoria
            Me.Categoria = Categoria
        End Sub

    End Class


    Class stDatos_Valoracion

        Public Kilos As Decimal = 0

        Public Sub New(Kilos As Decimal)

            Me.Kilos = Kilos

        End Sub

    End Class


    Class stLcla
        Public idgenero As Integer
        Public idcategoria As Integer
        Public Sub New(IdGenero As Integer, IdCategoria As Integer)

            Me.idgenero = IdGenero
            Me.idcategoria = IdCategoria
        End Sub
    End Class

    Dim DclCLA As New Dictionary(Of Integer, stLcla) ' dicionario para las lineas clasificadas


    Dim ValoracionSemanal As New E_ValoracionSemanal(Idusuario, cn)
    Dim ValoracionSemanal_Lineas As New E_ValoracionSemanal_Lineas(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
    Dim AlbEntrada_LineasCla As New E_AlbEntrada_lineascla(Idusuario, cn)
    Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim AlbEntrada_HisLineas As New E_AlbEntrada_hislineas(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))


    Dim _ejer As String

    Public Sub InitTipo(TipoEntrada As String)
        _tipo = TipoEntrada
        Select Case TipoEntrada
            Case "C"
                LbNomTipo.Text = "ALBARANES A COMISION"
            Case "S"
                LbNomTipo.Text = "ALBARANES S/ CLASIFICACIÓN"
        End Select
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()
        EntidadFrm = ValoracionSemanal


        Dim lc As New List(Of Object)
        ListaControles = lc


        ParamTx(TxValoracion, ValoracionSemanal.VSC_Valoracion, LbValoracion, True)
        CampoClave = 0 ' ultimo campo de la clave
        TxValoracion.Autonumerico = True

    
        ParamTx(TxFechaValoracion, ValoracionSemanal.VSC_FechaValoracion, LbFechaValoracion, True)
        ParamTx(TxCentro, ValoracionSemanal.VSC_idcentro, LbCentro, True)
        ParamTx(TxSemana, Nothing, LbSemana, True, Cdatos.TiposCampo.EnteroPositivo, 0, 2)
        ParamTx(TxFechaDesde, ValoracionSemanal.VSC_DFecha, LbDesdeFecha, True)
        ParamTx(TxFechaHasta, ValoracionSemanal.VSC_AFecha, LbHastaFecha, True)
        ParamTx(TxAgricultorDesde, ValoracionSemanal.VSC_IdAgricultorDesde, LbDesdeAgricultor)
        ParamTx(TxAgricultorHasta, ValoracionSemanal.VSC_IdAgricultorHasta, LbHastaAgricultor)


        ParamTx(TxPrecio, ValoracionSemanal_Lineas.VSL_Precio, Lb5, False)

        AsociarGrid(ClGrid1, TxPrecio, TxPrecio, ValoracionSemanal_Lineas)


        AsociarControles(TxValoracion, BtBuscaValoracion, ValoracionSemanal.btBusca, EntidadFrm)
        AsociarControles(TxAgricultorDesde, BtBuscaAg1, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNomAgricultorDesde)
        AsociarControles(TxAgricultorHasta, BtBuscaAg2, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNomAgricultorHasta)
        AsociarControles(TxCentro, BtCentro, Centros.btBusca, Centros, Centros.Nombre, LbNomCentro)


        PropiedadesCamposGr(ClGrid1, "VSL_IdLinea", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Genero", "Genero", True, 50)
        PropiedadesCamposGr(ClGrid1, "Categoria", "Categoria", True, 30)
        PropiedadesCamposGr(ClGrid1, "Kilos", "Kilos", True, 20, True, "#,##0.00")
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 20, False, "#,##0.0000")
        PropiedadesCamposGr(ClGrid1, "Importe", "Importe", True, 30, True, "#,##0.00")

       
    End Sub


    Private Sub FrmValoracionSegunClasificacion_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        CbCentrosRecogida = ComboCentrosRecogida(CbCentrosRecogida)
        CbCentrosRecogida.CheckAll()

        'BTaux1.Visible = True
        'BTaux1.Text = "Imprimir"
        'BTaux1.Image = PictureBox1.Image

        'BtAux2.Visible = True
        'BtAux2.Text = "I.Directa"
        'BtAux2.Image = PictureBox2.Image

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
        Barra.Maximum = 0
        _ejer = MiMaletin.Ejercicio.ToString
        GridKilos.DataSource = Nothing
        PanelKilos.Enabled = False

        BtBuscaValoracion.CL_Filtro = "Tipo='" & _tipo & "'"

    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave

        If TxValoracion.Text = "+" Then
            LbId.Text = "+"
        Else

            Dim i As Integer = ValoracionSemanal.LeerValoracion(VaInt(_ejer), VaInt(TxValoracion.Text))
            LbId.Text = i.ToString

            If i > 0 Then

                ValoracionSemanal.LeerId(i.ToString)
                If ValoracionSemanal.VSC_TipoCS.Valor <> _tipo Then
                    MsgBox("No es tipo " & _tipo)
                    LbId.Text = ""
                    Exit Sub
                End If
                CargaLineasGrid()
            Else
                If MsgBox("No existe la valoración. ¿Desea crear una nueva valoración?", vbYesNo) = vbYes Then

                    LbId.Text = "+"
                    'TxValoracion.Text = LbId.Text
                Else
                    LbId.Text = ""
                End If
            End If

        End If


        'CargaLineasGrid()


    End Sub


    Private Sub TxAgricultorHasta_Valida(edicion As System.Boolean) Handles TxAgricultorHasta.Valida

        If edicion Then

            If Not TxSemana.MiError And Not TxFechaDesde.MiError And Not TxFechaHasta.MiError Then

                Vkilos()
                PanelKilos.Enabled = True
              
            End If

        End If

    End Sub


    Private Sub VkilosModificar(idv As Integer)


        ' PROCEDIMIENTO PARA CALCULAR EL DICCIONARIO DE LAS PARTIDAS A MODIFICAR PERO NO MUESTRO EL GRID DE KILOS

        Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)

        Dim ACUM As New Acumulador
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbEntrada_LineasCla.ALC_id, "id")
        consulta.SelCampo(AlbEntrada_LineasCla.ALC_idgenero, "Idgenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbEntrada_LineasCla.ALC_idgenero)
        consulta.SelCampo(AlbEntrada_LineasCla.ALC_idcategoria, "IdCat")
        consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", AlbEntrada_LineasCla.ALC_idcategoria)
        consulta.SelCampo(AlbEntrada_Lineas.AEL_FechaValoracion, "Valoracion", AlbEntrada_LineasCla.ALC_idlineaentrada)
        consulta.SelCampo(AlbEntrada_LineasCla.ALC_kilosnetos, "Kilos")
        consulta.SelCampo(AlbEntrada.AEN_IdAlbaran, "idalbaran", AlbEntrada_Lineas.AEL_idalbaran)

        consulta.WheCampo(AlbEntrada.AEN_TipoFCS, "=", _tipo)
        consulta.WheCampo(AlbEntrada.AEN_Fecha, ">=", TxFechaDesde.Text)
        consulta.WheCampo(AlbEntrada.AEN_Fecha, "<=", TxFechaHasta.Text)
        consulta.WheCampo(AlbEntrada.AEN_IdCentro, "=", TxCentro.Text)

        If TxAgricultorDesde.Text <> "" Then
            consulta.WheCampo(AlbEntrada.AEN_IdAgricultor, ">=", TxAgricultorDesde.Text)
        End If
        If TxAgricultorHasta.Text <> "" Then
            consulta.WheCampo(AlbEntrada.AEN_IdAgricultor, "<=", TxAgricultorHasta.Text)
        End If

        Dim Sql As String = consulta.SQL


        Sql = Sql & CadenaWhereLista(AlbEntrada.AEN_IdRecogida, ListadeCombo(CbCentrosRecogida), " AND ") & vbCrLf




        Sql = Sql + "AND "
        Sql = Sql + " ( "
        Sql = Sql + " AEL_IDVALORACION = " + idv.ToString
        Sql = Sql + " OR "
        Sql = Sql & " (COALESCE(AEL_FechaValoracion,'" & VaDate("") & "') = '" & VaDate("") & "')" & vbCrLf ' no valorados
        Sql = Sql + "AND AEL_IDVALORACION=0"
        Sql = Sql + ") "


        Sql = Sql & " AND COALESCE(AEL_FechaMuestreo,'" & VaDate("") & "') > '" & VaDate("") & "'" & vbCrLf ' muestreados

        Sql = Sql + "order by ALC_IDGENERO,CAE_CATEGORIACALIBRE"

        Dim DT As DataTable = AlbEntrada_LineasCla.MiConexion.ConsultaSQL(Sql)

        DclCLA.Clear()

        If Not DT Is Nothing Then

            For Each RW In DT.Rows

                Dim idgenero As Integer = VaInt(RW("idgenero"))
                Dim IdCat As Integer = VaInt(RW("idcat"))
                Dim Genero As String = RW("Genero").ToString
                Dim Categoria As String = RW("Categoria").ToString
                Dim kilos As Decimal = VaDec(RW("kilos"))
                Dim clave As New stClave_Valoracion(idgenero, Genero, IdCat, Categoria)
                Dim datos As New stDatos_Valoracion(kilos)
                Dim idalbaran As Integer = VaInt(RW("idalbaran"))
                Dim id As Integer = VaInt(RW("id"))

                If Albentrada_his.AlbaranFacturado(idalbaran) = "" Then
                    ACUM.Suma(clave, datos)

                    Dim dlin As New stLcla(idgenero, IdCat)
                    If DclCLA.ContainsKey(id) = False Then
                        DclCLA.Add(id, dlin) ' las lineascla que voy a actualizar 
                    End If
                End If


            Next

        End If

        PanelKilos.Visible = False
        TxSemana.Enabled = False


    End Sub


    Private Sub Vkilos()


        PanelKilos.Visible = True
        Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)

        Dim ACUM As New Acumulador
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbEntrada_LineasCla.ALC_id, "id")
        consulta.SelCampo(AlbEntrada_LineasCla.ALC_idgenero, "Idgenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbEntrada_LineasCla.ALC_idgenero)
        consulta.SelCampo(AlbEntrada_LineasCla.ALC_idcategoria, "IdCat")
        consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", AlbEntrada_LineasCla.ALC_idcategoria)
        consulta.SelCampo(AlbEntrada_Lineas.AEL_FechaValoracion, "Valoracion", AlbEntrada_LineasCla.ALC_idlineaentrada)
        consulta.SelCampo(AlbEntrada_LineasCla.ALC_kilosnetos, "Kilos")
        consulta.SelCampo(AlbEntrada.AEN_IdAlbaran, "idalbaran", AlbEntrada_Lineas.AEL_idalbaran)

        consulta.WheCampo(AlbEntrada.AEN_TipoFCS, "=", _tipo)
        consulta.WheCampo(AlbEntrada.AEN_Fecha, ">=", TxFechaDesde.Text)
        consulta.WheCampo(AlbEntrada.AEN_Fecha, "<=", TxFechaHasta.Text)
        consulta.WheCampo(AlbEntrada.AEN_IdCentro, "=", TxCentro.Text)
        If TxAgricultorDesde.Text <> "" Then
            consulta.WheCampo(AlbEntrada.AEN_IdAgricultor, ">=", TxAgricultorDesde.Text)
        End If
        If TxAgricultorHasta.Text <> "" Then
            consulta.WheCampo(AlbEntrada.AEN_IdAgricultor, "<=", TxAgricultorHasta.Text)
        End If

        Dim Sql As String = consulta.SQL


        Sql = Sql & CadenaWhereLista(AlbEntrada.AEN_IdRecogida, ListadeCombo(CbCentrosRecogida), " AND ") & vbCrLf


        Sql = Sql & " AND (COALESCE(AEL_FechaValoracion,'" & VaDate("") & "') = '" & VaDate("") & "')" & vbCrLf ' no valorados
        Sql = Sql + "AND AEL_IDVALORACION=0"
 

        Sql = Sql & " AND COALESCE(AEL_FechaMuestreo,'" & VaDate("") & "') > '" & VaDate("") & "'" & vbCrLf ' muestreados

        Sql = Sql + "order by ALC_IDGENERO,CAE_CATEGORIACALIBRE"

        Dim DT As DataTable = AlbEntrada_LineasCla.MiConexion.ConsultaSQL(Sql)

        DclCLA.Clear()

        If Not DT Is Nothing Then

            For Each RW In DT.Rows

                Dim idgenero As Integer = VaInt(RW("idgenero"))
                Dim IdCat As Integer = VaInt(RW("idcat"))
                Dim Genero As String = RW("Genero").ToString
                Dim Categoria As String = RW("Categoria").ToString
                Dim kilos As Decimal = VaDec(RW("kilos"))
                Dim clave As New stClave_Valoracion(idgenero, Genero, IdCat, Categoria)
                Dim datos As New stDatos_Valoracion(kilos)
                Dim idalbaran As Integer = VaInt(RW("idalbaran"))
                Dim id As Integer = VaInt(RW("id"))

                If Albentrada_his.AlbaranFacturado(idalbaran) = "" Then
                    ACUM.Suma(clave, datos)

                    Dim dlin As New stLcla(idgenero, IdCat)
                    If DclCLA.ContainsKey(id) = False Then
                        DclCLA.Add(id, dlin) ' las lineascla que voy a actualizar 
                    End If
                End If


            Next

            Dim dt2 As DataTable = ACUM.DataTable
            If Not dt2 Is Nothing Then
                Dim colSel As New DataColumn("S", GetType(System.Boolean))

                colSel.DefaultValue = False
                PanelKilos.Enabled = True
                dt2.Columns.Add(colSel)
                GridKilos.DataSource = dt2
                AjustaColumnas(GridViewKilos)
                GridViewKilos.OptionsBehavior.Editable = False
                GridViewKilos.OptionsView.ShowGroupPanel = False
            End If
        End If



    End Sub


    Private Sub GridViewKilos_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridViewKilos.RowCellClick

        Dim column As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        Dim row As DataRow = GridViewKilos.GetDataRow(e.RowHandle)
        Dim PonloA As Boolean = False
        If column.FieldName = "S" Then

            Dim idgenero As Integer = VaInt(row("idgenero"))

            If row("S") = False Then
                PonloA = True
            Else
                PonloA = False
            End If

            Dim DT As DataTable = GridKilos.DataSource
            For Each rw In DT.Rows
                If VaInt(rw("idgenero")) = idgenero Then
                    rw("S") = PonloA
                End If
            Next
        End If


    End Sub
    Private Sub AjustaColumnas(g As DevExpress.XtraGrid.Views.Grid.GridView)


    

        g.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In g.Columns
            Select Case c.FieldName.ToUpper.Trim



                Case "IDGENERO", "IDCAT", "TIPO", "VALORACION"
                    c.Visible = False

                Case "KILOS"
                    c.Width = 100
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n0}"


                Case "GENERO"
                    c.Width = 300

                Case "CATEGORIA"
                    c.Width = 150

            End Select
        Next


        Funciones.AñadeResumenCampo(g, "Kilos", "{0:n0}")


    End Sub



    Private Sub CargaLineasGrid()


        SqlGrid()

        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)


    End Sub


    Private Sub SqlGrid()
        Dim id As String

        id = LbId.Text
        Dim sql As String
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(ValoracionSemanal_Lineas.VSL_IdLinea, "")
        CONSULTA.SelCampo(ValoracionSemanal_Lineas.VSL_IdGenero, "IdGenero")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero", ValoracionSemanal_Lineas.VSL_IdGenero, Generos.GEN_IdGenero)
        CONSULTA.SelCampo(ValoracionSemanal_Lineas.VSL_IdCategoria, "IdCategoria")
        CONSULTA.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", ValoracionSemanal_Lineas.VSL_IdCategoria)
        CONSULTA.SelCampo(ValoracionSemanal_Lineas.VSL_Kilos, "Kilos")
        CONSULTA.SelCampo(ValoracionSemanal_Lineas.VSL_Precio, "Precio")

        Dim Importe As New Cdatos.bdcampo("@(vsl_kilos*vsl_precio)", Cdatos.TiposCampo.Importe, 10)
        CONSULTA.SelCampo(Importe, "Importe")

        CONSULTA.WheCampo(ValoracionSemanal_Lineas.VSL_IdValora, "=", id)
        sql = CONSULTA.SQL


        ClGrid1.Consulta = sql

    End Sub


    Private Sub TxSemana_Valida(edicion As System.Boolean) Handles TxSemana.Valida

        Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
        If SemanasPartes.LeerSemana(VaInt(_ejer), VaInt(TxSemana.Text)) > 0 Then
            If edicion Then
                If VaDate(SemanasPartes.SEV_FechaInicialEntrada.Valor) > VaDate("") Then TxFechaDesde.Text = VaDate(SemanasPartes.SEV_FechaInicialEntrada.Valor).ToString("dd/MM/yyyy")
                If VaDate(SemanasPartes.SEV_FechaFinalEntrada.Valor) > VaDate("") Then TxFechaHasta.Text = VaDate(SemanasPartes.SEV_FechaFinalEntrada.Valor).ToString("dd/MM/yyyy")
            Else
                If TxFechaDesde.Text.Trim <> "" Then
                    If VaDate(SemanasPartes.SEV_FechaInicialEntrada.Valor) > VaDate("") Then TxFechaDesde.Text = VaDate(SemanasPartes.SEV_FechaInicialEntrada.Valor).ToString("dd/MM/yyyy")
                End If
                If TxFechaHasta.Text.Trim <> "" Then
                    If VaDate(SemanasPartes.SEV_FechaFinalEntrada.Valor) > VaDate("") Then TxFechaHasta.Text = VaDate(SemanasPartes.SEV_FechaFinalEntrada.Valor).ToString("dd/MM/yyyy")
                End If
            End If
        End If

    End Sub


   


    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)

        LbGenero.Text = ""
        LbNomGenero.Text = ""
        LbCategoria.Text = ""
        LbNomCategoria.Text = ""
        LbKilos.Text = ""
        LbImporte.Text = ""


      

    End Sub


    


    Public Overrides Sub Guardar()

        If MsgBox("Desea valorar los albaranes", vbYesNo) = vbYes Then
            If VaInt(LbId.Text) > 0 Then
                GenerarValoraciones()
            End If
        End If
        MyBase.Guardar()

    End Sub


    Public Overrides Sub Anular()

        MyBase.Anular()

    End Sub


    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()

        Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
        If SemanasPartes.LeerId(ValoracionSemanal.VSC_IdSemana.Valor) Then
            TxSemana.Text = SemanasPartes.SEV_Semana.Valor
        End If

        If VaInt(LbId.Text) = 0 Then
            Vkilos()
        Else
            VkilosModificar(VaInt(LbId.Text))
        End If
    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)


        'Genero
        LbGenero.Text = ValoracionSemanal_Lineas.VSL_IdGenero.Valor
        Dim Generos As New E_Generos(Idusuario, cn)
        If VaInt(LbGenero.Text) > 0 Then
            If Generos.LeerId(LbGenero.Text) Then
                LbNomGenero.Text = Generos.GEN_NombreGenero.Valor
            End If
        End If


        'Categoría
        LbCategoria.Text = ValoracionSemanal_Lineas.VSL_IdCategoria.Valor

        Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)
        If VaInt(LbCategoria.Text) > 0 Then
            If CategoriasEntrada.LeerId(LbCategoria.Text) Then
                LbNomCategoria.Text = CategoriasEntrada.CAE_CategoriaCalibre.Valor
            End If
        End If


        'Kilos
        Dim Kilos As Decimal = 0
        Dim row As DataRow = ClGrid1.GridView.GetFocusedDataRow()
        If Not IsNothing(row) Then
            Kilos = VaDec(row("Kilos"))
        End If

        LbKilos.Text = Kilos.ToString("#,##0")


        'Importe
        Dim Importe As Decimal = Kilos * VaDec(TxPrecio.Text)
        LbImporte.Text = Importe.ToString("#,##0.00")



     


    End Sub


    Private Sub TxPrecio_Valida(edicion As System.Boolean) Handles TxPrecio.Valida

        Dim Importe As Decimal = VaDec(LbKilos.Text) * VaDec(TxPrecio.Text)
        LbImporte.Text = Importe.ToString("#,##0.00")

    End Sub
    Public Overrides Sub DespuesdeAnular()
        MyBase.DespuesdeAnular()
        If VaInt(LbId.Text) > 0 Then
            AnulaValoracion()
        End If
    End Sub

    Private Sub AnulaValoracion()



        Dim dcalbaranes As New Dictionary(Of Integer, Integer)

        Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbEntrada_Lineas.AEL_idlinea, "idpartida")
        consulta.SelCampo(AlbEntrada_Lineas.AEL_idalbaran, "idalbaran")
        consulta.WheCampo(AlbEntrada_Lineas.AEL_IdValoracion, "=", LbId.Text)
        Dim sql As String = consulta.SQL
        Dim dt As DataTable = AlbEntrada_Lineas.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            Barra.Maximum = dt.Rows.Count
            Barra.Value = 0
            For Each rw In dt.Rows
                If Barra.Value < Barra.Maximum Then
                    Barra.Value = Barra.Value + 1
                End If
                Dim idpartida As Integer = VaInt(rw("idpartida"))
                Dim idalbaran As Integer = VaInt(rw("idalbaran"))

                If Albentrada_his.AlbaranFacturado(idalbaran) = "" Then

                    If AlbEntrada_Lineas.LeerId(idpartida) = True Then
                        AlbEntrada_Lineas.AEL_IdValoracion.Valor = "0"
                        AlbEntrada_Lineas.AEL_FechaValoracion.Valor = "01/01/1900"
                        AlbEntrada_Lineas.Actualizar()
                    End If

                    sql = "update albentrada_lineascla set alc_precio=0 where alc_idlineaentrada=" + idpartida.ToString
                    AlbEntrada.MiConexion.OrdenSql(sql)

                    sql = "update albentrada_hislineas set ahl_precio=0,ahl_importegenero=0 where ahl_idlineaentrada=" + idpartida.ToString
                    AlbEntrada.MiConexion.OrdenSql(sql)


                    If dcalbaranes.ContainsKey(idalbaran) = False Then
                        dcalbaranes.Add(idalbaran, idalbaran)
                    End If
                End If



            Next
        End If
        Dim n As Integer
        For Each idalbaran In dcalbaranes.Keys
            n = n + 1
            Agro_ValoraAlbaranHis(idalbaran)
        Next

        MsgBox("Se valoraron " + N.ToString + " albaranes")
        Barra.Value = 0

    End Sub



    Private Sub GenerarValoraciones()

        Dim N As Integer = 0



        Dim DcPartidas As New Dictionary(Of Integer, Integer)
        Dim DcAlbaranes As New Dictionary(Of Integer, Integer)
        Dim Fval As String = ""
        Dim nval As Integer = 0

        Fval = TxFechaValoracion.Text
        nval = VaInt(LbId.Text)
        



        'Leo de la entidad valoracionsemanal
        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(ValoracionSemanal_Lineas.VSL_IdGenero, "IdGenero")
        CONSULTA.SelCampo(ValoracionSemanal_Lineas.VSL_IdCategoria, "IdCategoria")
        CONSULTA.SelCampo(ValoracionSemanal_Lineas.VSL_Precio, "Precio")
        CONSULTA.WheCampo(ValoracionSemanal_Lineas.VSL_IdValora, "=", LbId.Text)

        Dim sql As String = CONSULTA.SQL
        Dim dt As DataTable = ValoracionSemanal_Lineas.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dt) Then

            Barra.Maximum = dt.Rows.Count
            Barra.Value = 0

            For Each row In dt.Rows

                If Barra.Value < Barra.Maximum Then
                    Barra.Value = Barra.Value + 1
                End If

                Dim IdGenero As String = (row("IdGenero").ToString & "").Trim
                Dim IdCategoria As String = (row("IdCategoria").ToString & "").Trim

                Dim Precio As Decimal = 0
                Precio = VaDec(row("Precio"))


                For Each id In DclCLA.Keys ' busco en el diccionarrio de lineascla las que coinciden con el genero y la categoria
                    If DclCLA(id).idcategoria = IdCategoria And DclCLA(id).idgenero = IdGenero Then
                        If AlbEntrada_LineasCla.LeerId(id) = True Then
                            AlbEntrada_LineasCla.ALC_precio.Valor = Precio.ToString
                            Dim idpartida As Integer = VaInt(AlbEntrada_LineasCla.ALC_idlineaentrada.Valor)
                            Dim idalbaran As Integer = VaInt(AlbEntrada_LineasCla.ALC_idalbaran.Valor)
                            AlbEntrada_LineasCla.Actualizar()
                            If DcPartidas.ContainsKey(idpartida) = False Then
                                DcPartidas.Add(idpartida, idpartida)
                            End If
                            If DcAlbaranes.ContainsKey(idalbaran) = False Then
                                DcAlbaranes.Add(idalbaran, idalbaran)
                            End If

                            'Obtengo los históricos del CLA
                            ActualizaHis(id, Precio)

                        End If
                    End If
                Next


            Next
            For Each idppartida In DcPartidas.Keys
                If AlbEntrada_Lineas.LeerId(idppartida) = True Then
                    AlbEntrada_Lineas.AEL_FechaValoracion.Valor = Fval
                    AlbEntrada_Lineas.AEL_IdValoracion.Valor = nval
                    AlbEntrada_Lineas.AEL_tipoprecio.Valor = "K"
                    AlbEntrada_Lineas.Actualizar()
                End If
            Next

            For Each idalbaran In DcAlbaranes.Keys
                Agro_ValoraAlbaranHis(idalbaran)
                N = N + 1

            Next

        End If

        MsgBox("Se valoraron " + N.ToString + " albaranes")
        Barra.Value = 0


    End Sub


 


    Private Function ObtenerHis(IdCla As String) As DataTable

        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(AlbEntrada_HisLineas.AHL_id, "IdLineaHis")
        CONSULTA.WheCampo(AlbEntrada_HisLineas.AHL_idlineacla, "=", IdCla)

        Dim sql As String = CONSULTA.SQL
        Return AlbEntrada_LineasCla.MiConexion.ConsultaSQL(sql)


    End Function


    Private Sub ActualizaHis(id As Integer, Precio As Decimal)
        Dim dtHis As DataTable = ObtenerHis(id)
        If Not IsNothing(dtHis) Then
            For Each rowHis As DataRow In dtHis.Rows

                Dim IdLineaHis As String = (rowHis("IdLineaHis").ToString & "").Trim
                If AlbEntrada_HisLineas.LeerId(IdLineaHis) Then

                    Dim Kilos As Double = VaDec(AlbEntrada_HisLineas.AHL_kilos.Valor)
                    Dim Importe As Decimal = Kilos * Precio

                    AlbEntrada_HisLineas.AHL_precio.Valor = Precio.ToString
                    AlbEntrada_HisLineas.AHL_tipoprecio.Valor = "K"
                    AlbEntrada_HisLineas.AHL_importegenero.Valor = Importe.ToString
                    AlbEntrada_HisLineas.Actualizar()

                End If

            Next
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If MsgBox("Desea introducir los precios a los productos seleccionados", vbYesNo) = vbYes Then
            Dim dt As DataTable = GridKilos.DataSource
            For Each rw In dt.Rows
                If Not rw Is Nothing Then
                    If rw("S") = True Then
                        NuevaLineaValoracion(VaInt(rw("idgenero")), VaInt(rw("idcategoria")), VaInt(rw("kilos")))
                    End If
                End If
            Next
            CargaLineasGrid()
        End If
    End Sub

    Private Sub NuevaLineaValoracion(Idgenero As Integer, idcat As Integer, kilos As Decimal)
        If LbId.Text = "+" Then
            If LbId.Text = "+" Then
                LbId.Text = ValoracionSemanal.MaxId
                If TxValoracion.Text = "+" Then
                    TxValoracion.Text = ValoracionSemanal.MaxIdCampa(Val(_ejer))
                End If
            End If

            'ValoracionSemanal.VSC_IdValora.Valor = LbId.Text
            ValoracionSemanal.VSC_IdEjercicio.Valor = _ejer
            ValoracionSemanal.VSC_TipoCS.Valor = _tipo

            Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
            Dim IdSemana As Integer = SemanasPartes.LeerSemana(VaInt(_ejer), VaInt(TxSemana.Text))
            If IdSemana > 0 Then
                ValoracionSemanal.VSC_IdSemana.Valor = IdSemana.ToString
            End If
            ValoracionSemanal.VSC_DFecha.Valor = TxFechaDesde.Text
            ValoracionSemanal.VSC_AFecha.Valor = TxFechaHasta.Text
            ValoracionSemanal.VSC_IdAgricultorDesde.Valor = TxAgricultorDesde.Text
            ValoracionSemanal.VSC_IdAgricultorHasta.Valor = TxAgricultorHasta.Text
            ValoracionSemanal.VSC_idcentro.Valor = TxCentro.Text
            ValoracionSemanal.Insertar()
            PanelKilos.Enabled = False

        End If

        Dim id As Integer = ValoracionSemanal_Lineas.MaxId
        ValoracionSemanal_Lineas.VaciaEntidad()
        ValoracionSemanal_Lineas.VSL_IdLinea.Valor = id.ToString
        ValoracionSemanal_Lineas.VSL_IdValora.Valor = LbId.Text
        ValoracionSemanal_Lineas.VSL_IdGenero.Valor = Idgenero.ToString
        ValoracionSemanal_Lineas.VSL_IdCategoria.Valor = idcat.ToString
        ValoracionSemanal_Lineas.VSL_Precio.Valor = "0"
        ValoracionSemanal_Lineas.VSL_Kilos.Valor = kilos.ToString
        ValoracionSemanal_Lineas.Insertar()



    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Val(LbId.Text) > 0 Then
            If MsgBox("Desea valorar los albaranes", vbYesNo) = vbYes Then
                GenerarValoraciones()
            End If
        End If
    End Sub


    Protected Overrides Sub BModificar_Click(sender As Object, e As System.EventArgs)
        MyBase.BModificar_Click(sender, e)
        TxSemana.Enabled = False
        TxFechaDesde.Enabled = False
        TxFechaHasta.Enabled = False
        TxAgricultorDesde.Enabled = False
        TxAgricultorHasta.Enabled = False
        CbCentrosRecogida.Enabled = False
        TxCentro.Enabled = False
    End Sub

    Private Sub TxValoracion_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxValoracion.TextChanged

    End Sub

    Private Sub TxSemana_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxSemana.TextChanged

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If VaInt(LbId.Text) > 0 Then
            VerAlbaranes()
        End If
    End Sub

    Private Sub VerAlbaranes()
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbEntrada_LineasCla.ALC_idlineaentrada, "idlineaentrada")
        consulta.SelCampo(AlbEntrada_Lineas.AEL_muestreo, "Partida", AlbEntrada_LineasCla.ALC_idlineaentrada)
        consulta.SelCampo(AlbEntrada.AEN_Albaran, "Albaran", AlbEntrada_Lineas.AEL_idalbaran)
        consulta.SelCampo(AlbEntrada.AEN_Fecha, "Fecha")
        consulta.SelCampo(Agricultores.AGR_Nombre, "Agricultor", AlbEntrada.AEN_IdAgricultor)
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbEntrada_LineasCla.ALC_idgenero)
        consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", AlbEntrada_LineasCla.ALC_idcategoria)
        consulta.SelCampo(AlbEntrada_LineasCla.ALC_kilosnetos, "Kilos")
        consulta.SelCampo(AlbEntrada_LineasCla.ALC_precio, "Precio")

        Dim Importe As New Cdatos.bdcampo("@(alc_Kilosnetos*Alc_precio)", Cdatos.TiposCampo.Importe, 10, 2)
        consulta.SelCampo(Importe, "Importe")

        consulta.WheCampo(AlbEntrada_Lineas.AEL_IdValoracion, "=", LbId.Text)
        Dim sql As String = consulta.SQL
        sql = sql + " order by aen_fecha"
        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then

            Dim lst As New List(Of Parametros)

            lst.Add(New Parametros("idlineaentrada", False, "", -1))
            lst.Add(New Parametros("Partida", False, "", 100))
            lst.Add(New Parametros("Albaran", False, "", 100))
            lst.Add(New Parametros("Fecha", False, "", 150))
            lst.Add(New Parametros("Agricultor", False, "", 300))
            lst.Add(New Parametros("Genero", False, "", 250))
            lst.Add(New Parametros("Categoria", False, "", 150))
            lst.Add(New Parametros("Kilos", True, "", 150))
            lst.Add(New Parametros("Precio", False, "{0:n4}", 150))
            lst.Add(New Parametros("Importe", True, "{0:n2}", 150))
 

            Dim f As New FrConsultaGenerica(dt, lst, "Albaranes de la valoracion")
            f.ShowDialog()

        End If



    End Sub

    Private Sub GridKilos_Click(sender As System.Object, e As System.EventArgs) Handles GridKilos.Click

    End Sub
End Class