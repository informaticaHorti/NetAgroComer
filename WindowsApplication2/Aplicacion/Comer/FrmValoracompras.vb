Imports DevExpress.XtraEditors


Public Class FrmValoraCompras
    Inherits FrConsulta


    Private Class stClaves_ValoracionCompras

        Public IdGenero As Integer = 0
        Public IdTipoConfeccion As Integer = 0
        Public IdEnvase As Integer = 0
        Public IdCategoria As Integer = 0

        Public Sub New(IdGenero As Integer, IdTipoConfeccion As Integer, IdEnvase As Integer, IdCategoria As Integer)
            Me.IdGenero = IdGenero
            Me.IdTipoConfeccion = IdTipoConfeccion
            Me.IdEnvase = IdEnvase
            Me.IdCategoria = IdCategoria
        End Sub

    End Class

    Private Class stDatos_ValoracionCompras

        Public Bultos As Decimal = 0
        Public Kilos As Decimal = 0

        Public Sub New(Bultos As Decimal, Kilos As Decimal)
            Me.Bultos = Bultos
            Me.Kilos = Kilos
        End Sub

    End Class



    Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Albentrada_LineasCla As New E_AlbEntrada_lineascla(Idusuario, cn)
    Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)

    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)



    Private Sub ParametrosFrm()

        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Agricultores.AGR_idagricultor, Lb1)
        ParamTx(TxDato2, Nothing, Lb5, False, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato3, Nothing, Lb4, False, Cdatos.TiposCampo.Fecha)
        ParamChk(chkAgrupar, Nothing, "S", "N")

        ParamTx(TxPrecioEnv, Nothing, Nothing, , Cdatos.TiposCampo.Importe, 4)
        ParamTx(TxImporte1, Nothing, Nothing, , Cdatos.TiposCampo.Importe, 2)
        ParamTx(TxImporte2, Nothing, Nothing, , Cdatos.TiposCampo.Importe, 2)
        ParamTx(TxImporte3, Nothing, Nothing, , Cdatos.TiposCampo.Importe, 2)
        ParamTx(TxImporte4, Nothing, Nothing, , Cdatos.TiposCampo.Importe, 2)
        ParamTx(TxImporte5, Nothing, Nothing, , Cdatos.TiposCampo.Importe, 2)
        ParamTx(TxImporte6, Nothing, Nothing, , Cdatos.TiposCampo.Importe, 2)
        ParamTx(TxImporte7, Nothing, Nothing, , Cdatos.TiposCampo.Importe, 2)
        ParamTx(TxImporte8, Nothing, Nothing, , Cdatos.TiposCampo.Importe, 2)

        AsociarControles(TxDato1, BtBuscaAg1, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb19)

        tt.SetToolTip(BtActualizar, "Actualizar precio medio y precio de envase de la línea")

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

        GridView1.OptionsView.ShowGroupPanel = False
        GridView2.OptionsView.ShowGroupPanel = False
        GridView2.OptionsBehavior.Editable = False

        BtAux.Text = "Valorar"
        BtAux.Visible = True

    End Sub


    Public Sub New(ByVal Titulo As String)

        Me.New()

        Me.Text = Titulo

    End Sub


    Private Sub FrmValoraCompras_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        chkAgrupar.Checked = True
        BImprimir.Visible = False
        BInforme.Visible = False

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Grid.DataSource = Nothing
        Grid2.DataSource = Nothing

        BorraDetalles()
        Fechaspordefecto()

        chkAgrupar.Checked = True

    End Sub


    Private Sub Fechaspordefecto()
        TxDato2.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato3.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()

        MyBase.Consultar()


        Grid2.DataSource = Nothing

        Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
        Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim Consulta As New Cdatos.E_select
        Dim DT As New DataTable
        Dim sql As String
        Consulta.SelCampo(Albentrada_his.AEH_idfactura, "idfactura")
        Consulta.SelCampo(Albentrada.AEN_IdAlbaran, "id", Albentrada_his.AEH_idalbaran)
        Consulta.SelCampo(Albentrada.AEN_Albaran, "Albaran")
        Consulta.SelCampo(Albentrada.AEN_Fecha, "Fecha")
        Consulta.SelCampo(Centros.Nombre, "Centro", Albentrada.AEN_IdCentro)
        Consulta.SelCampo(Albentrada.AEN_EntradaConfeccionada, "EntradaConfeccionada")
        If TxDato1.Text.Trim <> "" Then Consulta.WheCampo(Albentrada_his.AEH_idproveedor, "=", TxDato1.Text)
        Consulta.WheCampo(Albentrada.AEN_Fecha, ">=", TxDato2.Text)
        Consulta.WheCampo(Albentrada.AEN_Fecha, "<=", TxDato3.Text)
        Consulta.WheCampo(Albentrada.AEN_TipoFCS, "=", "F")
        Consulta.WheCampo(Albentrada.AEN_fechavaloracion, "=", "01/01/1900")
        Consulta.WheCampo(Albentrada_his.AEH_idfactura, "=", 0)

        sql = Consulta.SQL & vbCrLf & " ORDER BY Fecha DESC"

        DT = Albentrada.MiConexion.ConsultaSQL(sql)

        Dim colP1 As New DataColumn("S", GetType(Boolean))
        colP1.DefaultValue = False
        DT.Columns.Add(colP1)

        Grid.DataSource = DT


        With GridView1.Columns
            Dim columna As DevExpress.XtraGrid.Columns.GridColumn = .ColumnByFieldName("id")
            If Not IsNothing(columna) Then
                columna.Visible = False
            End If
            columna = .ColumnByFieldName("EntradaConfeccionada")
            If Not IsNothing(columna) Then
                columna.Visible = False
            End If
            columna = .ColumnByFieldName("idfactura")
            If Not IsNothing(columna) Then
                columna.Visible = False
            End If

        End With

        GridView1.BestFitColumns()

        Grid.Select()
        Grid.Focus()

    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

        If column.FieldName.ToUpper.Trim = "S" Then

            If row("S") = True Then
                row("S") = False
            Else

                Dim EntradaConfeccionada As String = (row("EntradaConfeccionada").ToString & "").Trim.ToUpper

                'Comprueba que todas las líneas estén muestreadas o sean confeccionadas aunque no estén muestreadas
                '  If AlbEntrada_Lineas.TodasLineasMuestreadas(row("Id")) Or EntradaConfeccionada = "S" Then
                ' If EntradaConfeccionada = "S" Then
                row("S") = True
                ' Else
                ' MsgBox("Albarán con lineas sin muestrear o no confeccionado")
                'End If
            End If

        CalculaAcumulado()

        End If

    End Sub


    Private Sub BtSelNinguno_Click(sender As System.Object, e As System.EventArgs) Handles BtSelNinguno.Click

        For indice As Integer = 0 To GridView1.RowCount - 1

            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = False
            End If

        Next

        CalculaAcumulado()

    End Sub


    Private Sub BtSelTodos_Click(sender As System.Object, e As System.EventArgs) Handles BtSelTodos.Click

        For indice As Integer = 0 To GridView1.RowCount - 1

            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then

                Dim EntradaConfeccionada As String = (row("EntradaConfeccionada").ToString & "").Trim.ToUpper

                'If AlbEntrada_Lineas.TodasLineasMuestreadas(row("Id")) Or EntradaConfeccionada = "S" Then

                row("S") = True
                'End If
            End If

        Next

        CalculaAcumulado()

    End Sub


    Private Sub CalculaAcumulado()


        If chkAgrupar.Checked Then
            CalculaAcumuladoCatEnv()
        Else
            CalculaAcumuladoGen()
        End If


    End Sub


    Private Sub CalculaAcumuladoCatEnv()


        GridView2.Columns.Clear()
        Grid2.DataSource = Nothing



        Dim Acumulador As New Acumulador
        Dim DcGeneros As New Dictionary(Of Integer, String)
        Dim DcEnvases As New Dictionary(Of Integer, String)
        Dim DcConfecciones As New Dictionary(Of Integer, String)
        Dim DcCategorias As New Dictionary(Of Integer, String)


        For indice As Integer = 0 To GridView1.RowCount - 1

            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then

                If row("S") = True Then

                    Dim IdAlbaran As String = row("Id").ToString

                    Dim CONSULTA As New Cdatos.E_select
                    CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idgenero, "IdGenero")
                    CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbEntrada_Lineas.AEL_idgenero, Generos.GEN_IdGenero)
                    CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idtipoconfeccion, "IdTipoConfeccion")
                    CONSULTA.SelCampo(ConfecEnvase.CEV_Nombre, "Confeccion", AlbEntrada_Lineas.AEL_idtipoconfeccion, ConfecEnvase.CEV_Idconfec)
                    CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idenvase, "IdEnvase")
                    CONSULTA.SelCampo(Envases.ENV_Nombre, "Envase", AlbEntrada_Lineas.AEL_idenvase, Envases.ENV_IdEnvase)
                    CONSULTA.SelCampo(Albentrada_LineasCla.ALC_idcategoria, "IdCategoria", AlbEntrada_Lineas.AEL_idlinea, Albentrada_LineasCla.ALC_idlineaentrada)
                    CONSULTA.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", Albentrada_LineasCla.ALC_idcategoria, Categorias.CAE_Id)
                    CONSULTA.SelCampo(Albentrada_LineasCla.ALC_bultos, "Bultos")
                    CONSULTA.SelCampo(Albentrada_LineasCla.ALC_kilosnetos, "Kilos")
                    CONSULTA.WheCampo(AlbEntrada_Lineas.AEL_idalbaran, "=", IdAlbaran)

                    Dim dt As DataTable = AlbEntrada_Lineas.MiConexion.ConsultaSQL(CONSULTA.SQL)


                    If Not IsNothing(dt) Then

                        For Each fila As DataRow In dt.Rows

                            Dim IdGenero As Integer = VaInt(fila("IdGenero"))
                            Dim Genero As String = fila("Genero").ToString & ""
                            Dim IdEnvase As Integer = VaInt(fila("IdEnvase"))
                            Dim Envase As String = fila("Envase").ToString & ""
                            Dim IdTipoConfeccion As Integer = VaInt(fila("IdTipoConfeccion"))
                            If IdTipoConfeccion > 0 Then IdEnvase = VaInt(fila("IdTipoConfeccion"))
                            Dim Confeccion As String = fila("Confeccion").ToString & ""
                            Dim IdCategoria As Integer = VaInt(fila("IdCategoria"))
                            Dim Categoria As String = fila("Categoria").ToString & ""
                            Dim Bultos As Integer = VaInt(fila("Bultos"))
                            Dim Kilos As Decimal = VaDec(fila("Kilos"))

                            Dim stClaves As New stClaves_ValoracionCompras(IdGenero, IdTipoConfeccion, IdEnvase, IdCategoria)
                            Dim stDatos As New stDatos_ValoracionCompras(Bultos, Kilos)
                            Acumulador.Suma(stClaves, stDatos)

                            DcGeneros(IdGenero) = Genero
                            DcEnvases(IdEnvase) = Envase
                            DcConfecciones(IdTipoConfeccion) = Confeccion
                            DcCategorias(IdCategoria) = Categoria

                        Next

                    End If


                End If

            End If

        Next

        Dim dtResultado As DataTable = Acumulador.DataTable

        If Not IsNothing(dtResultado) Then
            If dtResultado.Rows.Count > 0 Then

                dtResultado.Columns.Add("Genero").SetOrdinal(1)
                dtResultado.Columns.Add("Envase").SetOrdinal(4)
                dtResultado.Columns.Add("Categoria").SetOrdinal(6)


                For Each row As DataRow In dtResultado.Rows

                    Dim IdGenero As Integer = VaInt(row("IdGenero"))
                    Dim IdTipoConfeccion As Integer = VaInt(row("IdTipoConfeccion"))
                    Dim IdEnvase As Integer = VaInt(row("IdEnvase"))
                    Dim IdCategoria As Integer = VaInt(row("IdCategoria"))

                    If DcGeneros.ContainsKey(IdGenero) Then row("Genero") = DcGeneros(IdGenero)
                    If IdTipoConfeccion > 0 Then
                        If DcConfecciones.ContainsKey(IdTipoConfeccion) Then row("Envase") = DcConfecciones(IdTipoConfeccion)
                    Else
                        If DcEnvases.ContainsKey(IdEnvase) Then row("Envase") = DcEnvases(IdEnvase)
                    End If
                    If DcCategorias.ContainsKey(IdCategoria) Then row("Categoria") = DcCategorias(IdCategoria)

                Next


                Dim PrecioMedio As New DataColumn("PrecioMedio", GetType(Decimal))
                PrecioMedio.DefaultValue = 0.0
                dtResultado.Columns.Add(PrecioMedio)

                Dim PrecioEnvase As New DataColumn("PrecioEnvase", GetType(Decimal))
                PrecioEnvase.DefaultValue = 0.0
                dtResultado.Columns.Add(PrecioEnvase)

                Dim Importe As New DataColumn("Importe", GetType(Decimal))
                Importe.DefaultValue = 0.0
                dtResultado.Columns.Add(Importe)

                Grid2.DataSource = dtResultado

                Funciones.AñadeResumenCampo(GridView2, "Bultos", "{0:n0}")
                Funciones.AñadeResumenCampo(GridView2, "Kilos", "{0:n0}")
                Funciones.AñadeResumenCampo(GridView2, "Importe", "{0:n2}")

                AjustaColumnas2()

            End If

        End If


        If IsNothing(GridView2.DataSource) Then
            BorraDetalles()
        Else
            If GridView2.RowCount = 0 Then
                BorraDetalles()
            End If
        End If


    End Sub


    Private Sub CalculaAcumuladoGen()


        GridView2.Columns.Clear()
        Grid2.DataSource = Nothing



        Dim Acumulador As New Acumulador
        Dim DcGeneros As New Dictionary(Of Integer, String)


        For indice As Integer = 0 To GridView1.RowCount - 1

            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then

                If row("S") = True Then

                    Dim IdAlbaran As String = row("Id").ToString

                    Dim CONSULTA As New Cdatos.E_select
                    CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idgenero, "IdGenero")
                    CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbEntrada_Lineas.AEL_idgenero, Generos.GEN_IdGenero)
                    CONSULTA.SelCampo(Albentrada_LineasCla.ALC_bultos, "Bultos", AlbEntrada_Lineas.AEL_idlinea, Albentrada_LineasCla.ALC_idlineaentrada)
                    CONSULTA.SelCampo(Albentrada_LineasCla.ALC_kilosnetos, "Kilos")
                    CONSULTA.WheCampo(AlbEntrada_Lineas.AEL_idalbaran, "=", IdAlbaran)

                    Dim dt As DataTable = AlbEntrada_Lineas.MiConexion.ConsultaSQL(CONSULTA.SQL)


                    If Not IsNothing(dt) Then

                        For Each fila As DataRow In dt.Rows

                            Dim IdGenero As Integer = VaInt(fila("IdGenero"))
                            Dim Genero As String = fila("Genero").ToString & ""
                            Dim Bultos As Integer = VaInt(fila("Bultos"))
                            Dim Kilos As Decimal = VaDec(fila("Kilos"))

                            Dim stClaves As New stClaves_ValoracionCompras(IdGenero, 0, 0, 0)
                            Dim stDatos As New stDatos_ValoracionCompras(Bultos, Kilos)
                            Acumulador.Suma(stClaves, stDatos)

                            DcGeneros(IdGenero) = Genero

                        Next

                    End If


                End If

            End If

        Next

        Dim dtResultado As DataTable = Acumulador.DataTable

        If Not IsNothing(dtResultado) Then
            If dtResultado.Rows.Count > 0 Then

                dtResultado.Columns.Add("Genero").SetOrdinal(1)


                For Each row As DataRow In dtResultado.Rows
                    Dim IdGenero As Integer = VaInt(row("IdGenero"))
                    If DcGeneros.ContainsKey(IdGenero) Then row("Genero") = DcGeneros(IdGenero)
                Next


                Dim PrecioMedio As New DataColumn("PrecioMedio", GetType(Decimal))
                PrecioMedio.DefaultValue = 0.0
                dtResultado.Columns.Add(PrecioMedio)

                Dim PrecioEnvase As New DataColumn("PrecioEnvase", GetType(Decimal))
                PrecioEnvase.DefaultValue = 0.0
                dtResultado.Columns.Add(PrecioEnvase)

                Dim Importe As New DataColumn("Importe", GetType(Decimal))
                Importe.DefaultValue = 0.0
                dtResultado.Columns.Add(Importe)

                Grid2.DataSource = dtResultado

                Funciones.AñadeResumenCampo(GridView2, "Bultos", "{0:n0}")
                Funciones.AñadeResumenCampo(GridView2, "Kilos", "{0:n0}")
                Funciones.AñadeResumenCampo(GridView2, "Importe", "{0:n0}")

                AjustaColumnas2()

            End If

        End If


        If IsNothing(GridView2.DataSource) Then
            BorraDetalles()
        Else
            If GridView2.RowCount = 0 Then
                BorraDetalles()
            End If
        End If


    End Sub


    Private Sub AjustaColumnas2()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView2.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDGENERO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.MaxWidth = 60


                Case "BULTOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 100

                Case "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 100


                Case "PRECIOMEDIO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.0000"
                    c.Caption = "P.Medio"
                    c.Width = 100


                Case "PRECIOENVASE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.0000"
                    c.Caption = "P.Envase"
                    c.Width = 100

                Case "IMPORTE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Caption = "Importe"
                    c.Width = 100

                Case "IDTIPOCONFECCION", "IDCATEGORIA", "IDENVASE"
                    c.Visible = False

                Case "ENVASE"
                    c.Caption = "Envase/Confección"



            End Select


        Next

        GridView2.BestFitColumns()

    End Sub


    Private Sub GridView2_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged

        MostrarLineaActual()

    End Sub


    Private Sub GridView2_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView2.RowCellClick

        MostrarLineaActual()

    End Sub


    Private Sub MostrarLineaActual()

        If GridView2.FocusedRowHandle >= 0 Then

            Dim row As DataRow = GridView2.GetFocusedDataRow()
            MuestraDetalles(row)

            TxPrecioEnv.Select()
            TxPrecioEnv.Focus()

        Else
            BorraDetalles()
        End If

    End Sub


    Private Sub BorraDetalles()

        LbGenero.Text = ""
        LbEnvase.Text = ""
        LbCategoria.Text = ""
        LbKilos.Text = ""
        LbBultos.Text = ""

        TxPrecioEnv.Text = ""
        TxImporte1.Text = ""
        TxImporte2.Text = ""
        TxImporte3.Text = ""
        TxImporte4.Text = ""
        TxImporte5.Text = ""
        TxImporte6.Text = ""
        TxImporte7.Text = ""
        TxImporte8.Text = ""

        LbTotalImporte.Text = ""
        LbPmedio.Text = ""

        TxPrecioEnv.Enabled = False
        TxImporte1.Enabled = False
        TxImporte2.Enabled = False
        TxImporte3.Enabled = False
        TxImporte4.Enabled = False
        TxImporte5.Enabled = False
        TxImporte6.Enabled = False
        TxImporte7.Enabled = False
        TxImporte8.Enabled = False

    End Sub


    Private Sub MuestraDetalles(row As DataRow)

        BorraDetalles()

        If Not IsNothing(row) Then

            LbGenero.Text = row("Genero").ToString
            LbKilos.Text = VaDec(row("Kilos")).ToString("#,##0.00")
            LbBultos.Text = VaInt(row("Bultos")).ToString("#,##0")
            If chkAgrupar.Checked Then
                LbEnvase.Text = row("Envase").ToString
                LbCategoria.Text = row("Categoria").ToString
            End If
            LbTotalImporte.Text = 0.ToString("#,##0.00")
            LbPmedio.Text = 0.ToString("#,##0.00")


            TxPrecioEnv.Enabled = True
            TxImporte1.Enabled = True
            TxImporte2.Enabled = True
            TxImporte3.Enabled = True
            TxImporte4.Enabled = True
            TxImporte5.Enabled = True
            TxImporte6.Enabled = True
            TxImporte7.Enabled = True
            TxImporte8.Enabled = True

        End If


    End Sub


    Private Sub TxDato3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato3.KeyDown

        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            BConsultar.Select()
            BConsultar.Focus()
        End If

    End Sub


    Protected Overrides Sub OcultaCargando()
        MyBase.OcultaCargando()

        BorraDetalles()

        Grid.Select()
        Grid.Focus()

    End Sub


    Private Sub TxImporte1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImporte1.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            ValidaImporte(TxImporte1)
        End If
    End Sub
    Private Sub TxImporte2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImporte2.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            ValidaImporte(TxImporte2)
        End If
    End Sub
    Private Sub TxImporte3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImporte3.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            ValidaImporte(TxImporte3)
        End If
    End Sub
    Private Sub TxImporte4_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImporte4.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            ValidaImporte(TxImporte4)
        End If
    End Sub
    Private Sub TxImporte5_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImporte5.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            ValidaImporte(TxImporte5)
        End If
    End Sub
    Private Sub TxImporte6_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImporte6.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            ValidaImporte(TxImporte6)
        End If
    End Sub
    Private Sub TxImporte7_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImporte7.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            ValidaImporte(TxImporte7)
        End If
    End Sub
    Private Sub TxImporte8_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImporte8.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            ValidaImporte(TxImporte8)

            BtActualizar.Select()
            BtActualizar.Focus()

        End If
    End Sub

    Private Sub ValidaImporte(tx As TxDato)

        If VaInt(tx.Text) = 0 Then
            TxImporte8.Validar(True)
        End If

    End Sub





    Private Sub BtActualizar_Click(sender As System.Object, e As System.EventArgs) Handles BtActualizar.Click

        Dim row As DataRow = GridView2.GetFocusedDataRow()
        Dim indice As Integer = GridView2.FocusedRowHandle

        If IsNothing(row) Then
            Exit Sub
        End If


        If XtraMessageBox.Show("¿Desea actualizar el precio medio y el precio del envase de la línea?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim PrecioEnvase As Decimal = VaDec(TxPrecioEnv.Text)
            Dim PrecioMedio As Decimal = VaDec(LbPmedio.Text)
            Dim Importe As Decimal = VaDec(LbKilos.Text) * VaDec(LbPmedio.Text) + VaDec(LbBultos.Text) * VaDec(TxPrecioEnv.Text)


            row("PrecioMedio") = PrecioMedio
            row("PrecioEnvase") = PrecioEnvase
            row("Importe") = importe

            If indice < GridView2.RowCount - 1 Then
                GridView2.FocusedRowHandle = indice + 1
            Else
                BtAux.Select()
                BtAux.Focus()
            End If


        End If

    End Sub


    Private Sub TxImporte1_Valida(edicion As System.Boolean) Handles TxImporte1.Valida
        If edicion Then CalculaTotalImportes()
    End Sub

    Private Sub TxImporte2_Valida(edicion As System.Boolean) Handles TxImporte2.Valida
        If edicion Then CalculaTotalImportes()
    End Sub

    Private Sub TxImporte3_Valida(edicion As System.Boolean) Handles TxImporte3.Valida
        If edicion Then CalculaTotalImportes()
    End Sub

    Private Sub TxImporte4_Valida(edicion As System.Boolean) Handles TxImporte4.Valida
        If edicion Then CalculaTotalImportes()
    End Sub

    Private Sub TxImporte5_Valida(edicion As System.Boolean) Handles TxImporte5.Valida
        If edicion Then CalculaTotalImportes()
    End Sub

    Private Sub TxImporte6_Valida(edicion As System.Boolean) Handles TxImporte6.Valida
        If edicion Then CalculaTotalImportes()
    End Sub

    Private Sub TxImporte7_Valida(edicion As System.Boolean) Handles TxImporte7.Valida
        If edicion Then CalculaTotalImportes()
    End Sub

    Private Sub TxImporte8_Valida(edicion As System.Boolean) Handles TxImporte8.Valida
        If edicion Then
            If Not TxImporte8.MiError Then

                CalculaTotalImportes()
                BtActualizar.Select()
                BtActualizar.Focus()

            End If
        End If
    End Sub

    Private Sub CalculaTotalImportes()

        Dim total As Decimal = VaDec(TxImporte1.Text)
        total = total + VaDec(TxImporte2.Text)
        total = total + VaDec(TxImporte3.Text)
        total = total + VaDec(TxImporte4.Text)
        total = total + VaDec(TxImporte5.Text)
        total = total + VaDec(TxImporte6.Text)
        total = total + VaDec(TxImporte7.Text)
        total = total + VaDec(TxImporte8.Text)

        Dim Kilos As Decimal = VaDec(LbKilos.Text)
        Dim PrecioMedio As Decimal = 0
        If Kilos <> 0 Then PrecioMedio = Math.Round(total / Kilos, 4)

        LbTotalImporte.Text = total.ToString("#,##0.00")
        LbPmedio.Text = PrecioMedio.ToString("#,##0.0000")

    End Sub


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()

        Valorar()

    End Sub


    Private Sub Valorar()

        If XtraMessageBox.Show("¿Desea valorar los albaranes con el precio medio y el precio de envase de cada línea?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


            Dim AlbEntrada_LineasCla As New E_AlbEntrada_lineascla(Idusuario, cn)
            Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
            Dim DcLineasEntrada As New Dictionary(Of String, String)

            Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)

            '1) Recorre las líneas del grid2 con los precios según Género, Categoría y TipoConfeccion/Envase
            For indice_precios As Integer = 0 To GridView2.RowCount - 1

                Dim rowPrecios As DataRow = GridView2.GetDataRow(indice_precios)
                If Not IsNothing(rowPrecios) Then

                    'Criterios
                    Dim IdGenero As String = rowPrecios("IdGenero").ToString
                    Dim IdTipoConfeccion As String = rowPrecios("IdTipoConfeccion").ToString
                    Dim IdEnvase As String = rowPrecios("IdEnvase").ToString
                    Dim IdCategoria As String = rowPrecios("IdCategoria").ToString

                    'Precios a actualizar
                    Dim PrecioMedio As Decimal = VaDec(rowPrecios("PrecioMedio"))
                    Dim PrecioEnvase As Decimal = VaDec(rowPrecios("PrecioEnvase"))


                    '2) Recorre los albaranes para obtener las líneas afectadas
                    For indice_albaran As Integer = 0 To GridView1.RowCount - 1

                        Dim rowAlbaran As DataRow = GridView1.GetDataRow(indice_albaran)
                        If Not IsNothing(rowAlbaran) Then

                            'Si está marcado para actualizar
                            If rowAlbaran("S") = True Then

                                'Obtenemos el IdAlbaran
                                Dim IdAlbaran As String = rowAlbaran("Id").ToString

                                'TODO: VER ESTO CON MIGUEL
                                'Para todas las líneas del albaran con los mismos IdGenero, IdTipoConfeccion/IdEnvase, IdCategoria e IdAlbarán
                                'buscamos las líneas de AlbEntrada_LineasCla y AlbEntrada_Lineas
                                Dim consulta As New Cdatos.E_select
                                consulta.SelCampo(AlbEntrada_LineasCla.ALC_id, "Id")
                                consulta.SelCampo(AlbEntrada_Lineas.AEL_idlinea, "IdLineaEntrada", AlbEntrada_LineasCla.ALC_idlineaentrada)
                                consulta.WheCampo(AlbEntrada_LineasCla.ALC_idalbaran, "=", IdAlbaran)
                                consulta.WheCampo(AlbEntrada_LineasCla.ALC_idgenero, "=", IdGenero)
                                consulta.WheCampo(AlbEntrada_LineasCla.ALC_idcategoria, "=", IdCategoria)
                                If VaInt(IdTipoConfeccion) > 0 Then
                                    consulta.WheCampo(AlbEntrada_Lineas.AEL_idtipoconfeccion, "=", IdTipoConfeccion)
                                Else
                                    consulta.WheCampo(AlbEntrada_Lineas.AEL_idenvase, "=", IdEnvase)
                                End If
                                Dim dtLineas As DataTable = AlbEntrada_Lineas.MiConexion.ConsultaSQL(consulta.SQL)

                                Application.DoEvents()

                                '3) Recorremos las lineas de AlbEntrada_Lineas y AlbEntrada_LineasCla para actualizar
                                For Each rowLinea As DataRow In dtLineas.Rows

                                    'Actualiza el precio medio de las lineas de clasificación
                                    'Dim IdLineasCla As String = rowLinea("Id").ToString
                                    'If AlbEntrada_LineasCla.LeerId(IdLineasCla) Then
                                    '    AlbEntrada_LineasCla.ALC_precio.Valor = PrecioMedio
                                    '    AlbEntrada_LineasCla.Actualizar()
                                    'End If

                                    'Actualiza el precio de envase de las líneas de entrada (sólo si no hemos actualizado ya)
                                    Dim IdLineaEntrada As String = (rowLinea("IdLineaEntrada").ToString & "").Trim
                                    If Not DcLineasEntrada.ContainsKey(IdLineaEntrada) Then

                                        If AlbEntrada_Lineas.LeerId(IdLineaEntrada) Then
                                            AlbEntrada_Lineas.AEL_precio.Valor = PrecioMedio
                                            AlbEntrada_Lineas.AEL_precioenvase.Valor = PrecioEnvase

                                            AlbEntrada_Lineas.Actualizar()

                                            DcLineasEntrada(IdLineaEntrada) = IdLineaEntrada

                                            'If AlbEntrada.LeerId(AlbEntrada_Lineas.AEL_idalbaran.Valor) = True Then
                                            '    AlbEntrada.AEN_fechavaloracion.Valor = TxDato3.Text
                                            '    AlbEntrada.Actualizar()
                                            'End If

                                        End If

                                    End If

                                Next


                                'Actualizamos albarán
                                Agro_GeneraAlbaranEntrada(IdAlbaran)
                                Application.DoEvents()


                            End If

                        End If

                    Next

                End If

                Application.DoEvents()

            Next


            BorraPan()

        End If



    End Sub



End Class