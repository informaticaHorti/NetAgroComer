
Public Class FrBuscaAlb
    Inherits FrConsulta


    Dim msql As String
    Dim BtBusca As BtBusca
    Dim mentidad As Cdatos.Entidad
    Dim mdfecha As String
    Dim mhfecha As String
    Dim mfiltro As String
    Dim mporcentro As Boolean


    Dim _DcParametros As New Dictionary(Of String, Parametros)



    Public Sub InitCodigo(ByVal Sql As String, ByVal EntidadAlb As Cdatos.Entidad, ByVal CampoCodigo As Cdatos.bdcampo, ByVal CampoNombre As Cdatos.bdcampo, ByVal dfecha As String, ByVal hfecha As String, ParamBusqueda As Dictionary(Of String, Parametros),
                          BtBusca As BtBusca)

        msql = Sql
        Me.BtBusca = BtBusca
        mentidad = EntidadAlb
        AsociarControles(TxCodigo, BtBusca2, CampoCodigo.MiEntidad.btBusca, CampoCodigo.MiEntidad, CampoNombre, Lb10)
        mdfecha = dfecha
        mhfecha = hfecha


        _DcParametros = ParamBusqueda

    End Sub

    Public Sub InitFiltro(ByVal Sqlfiltro As String)
        mfiltro = Sqlfiltro
    End Sub

    Public Sub InitCentro(ByVal PorCentro As Boolean)
        mporcentro = PorCentro
        If mporcentro = True Then
            ChCentros.Visible = True
        Else
            ChCentros.Visible = False
        End If

    End Sub
    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxCodigo, Nothing, Lb11, False, Cdatos.TiposCampo.EnteroPositivo, 0, 10)
        ParamTx(TxDfecha, Nothing, Lb7, False, Cdatos.TiposCampo.Fecha)
        ParamTx(TxHfecha, Nothing, Lb6, False, Cdatos.TiposCampo.Fecha)

        BInforme.Visible = False
        BuscarRow = Nothing
        PlantillaConsulta1.Visible = False

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.Appearance.Row.Font = New Font("Lucida Sans", 10, FontStyle.Bold)
        GridView1.Appearance.HeaderPanel.Font = New Font("Tahoma", 8, FontStyle.Bold)
        GridView1.Appearance.HeaderPanel.GradientMode = Drawing2D.LinearGradientMode.Vertical
        GridView1.Appearance.HeaderPanel.BackColor = Color.FromArgb(192, 192, 255)
        GridView1.Appearance.HeaderPanel.BackColor2 = Color.FromArgb(192, 255, 255)


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(ByVal Titulo As String)

        Me.New()

        Me.Text = Titulo


    End Sub



    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim dt As DataTable
        Dim filtro As String = mfiltro


        'Preguntamos si tiene propiedad CONSULTA
        Dim bCONSULTA As Boolean = False
        If Not IsNothing(BtBusca) Then
            If BtBusca.TieneConsulta Then
                bCONSULTA = True
            End If
        End If


        If bCONSULTA Then

            With BtBusca.CL_CONSULTA

                .E_Select.ListaCondicion.Clear()

                'Código
                If TxCodigo.Text.Trim <> "" Then
                    If Not IsNothing(.Campo_Codigo) Then
                        .E_Select.WheCampo(.Campo_Codigo, "=", TxCodigo.Text)
                    End If
                End If


                'Fecha desde
                If TxDfecha.Text.Trim <> "" Then
                    If Not IsNothing(.Campo_Fecha) Then
                        .E_Select.WheCampo(.Campo_Fecha, ">=", TxDfecha.Text)
                    End If
                End If


                'Fecha hasta
                If TxHfecha.Text.Trim <> "" Then
                    If Not IsNothing(.Campo_Fecha) Then
                        .E_Select.WheCampo(.Campo_Fecha, "<=", TxHfecha.Text)
                    End If
                End If


                'Centro
                If mporcentro = True Then
                    If ChCentros.CheckState = CheckState.Unchecked Then
                        If Not IsNothing(.Campo_Centro) Then
                            .E_Select.WheCampo(.Campo_Centro, "=", MiMaletin.IdCentro.ToString)
                        End If
                    End If
                End If


                'EMPRESA
                If Not IsNothing(.Campo_IdEmpresa) Then
                    .E_Select.WheCampo(.Campo_IdEmpresa, "=", MiMaletin.IdEmpresaCTB.ToString)
                End If


                'Si tiene propiedad CONSULTA
                Dim sql As String = BtBusca.CL_CONSULTA.E_Select.SQL & vbCrLf
                sql = sql & BtBusca.CL_CONSULTA.OrderBy

                dt = mentidad.MiConexion.ConsultaSQL(sql)

            End With


        Else

            'Si no tiene propiedad CONSULTA, lo hacemos como siempre
            dt = mentidad.MiConexion.ConsultaSQL(msql)


            If TxCodigo.Text <> "" Then
                If filtro <> "" Then
                    filtro = filtro + " and "
                End If

                filtro = filtro + "codigo=" + TxCodigo.Text
            End If
            If TxDfecha.Text <> "" Then

                If filtro <> "" Then
                    filtro = filtro + " and "
                End If
                filtro = filtro + " fecha>='" + TxDfecha.Text + "'"

            End If
            If TxHfecha.Text <> "" Then
                If filtro <> "" Then
                    filtro = filtro + " and "
                End If
                If filtro <> "" Then
                    filtro = filtro + " fecha<='" + TxHfecha.Text + "'"
                End If
            End If

            If mporcentro = True Then
                If ChCentros.CheckState = CheckState.Unchecked Then
                    If dt.Columns.Contains("IdCentro") Then
                        If filtro <> "" Then
                            filtro = filtro + " and "
                        End If
                        If filtro <> "" Then
                            filtro = filtro + " idcentro=" + MiMaletin.IdCentro.ToString
                        End If

                    End If
                End If
            End If

        End If


        If Not filtro Is Nothing Then
            If filtro.Trim <> "" Then
                If dt.Rows.Count > 0 Then
                    Dim dv As New DataView(dt)
                    dv.RowFilter = filtro
                    dt = dv.ToTable
                End If
            End If
        End If


        Grid.DataSource = dt


        'GridView1.BestFitColumns()
        AjustaColumnas()

        'OJO con las mayúsculas / minúsculas
        '  AñadeResumenCampo("bultos", "{0:n2}")
        '  AñadeResumenCampo("Kilos", "{0:n2}")



    End Sub

    Private Sub AjustaColumnas()


        For Each NombreCampo As String In _DcParametros.Keys

            Dim columna As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName(NombreCampo)
            If Not IsNothing(columna) Then

                Dim param As Parametros = _DcParametros(NombreCampo)
                If param.NombreCampo.Trim <> "" Then columna.Caption = param.NombreCampo
                If param.Formato.Trim <> "" Then
                    columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    columna.DisplayFormat.FormatString = param.Formato
                End If
                If param.Longitud < 0 Then columna.Visible = False
                If param.EsResumen Then AñadeResumenCampo(NombreCampo, "{0:n2}")

            End If

        Next


        'Una vez hemos quitado las no visibles, ajustamos los tamaños y aplicamos los anchos
        GridView1.BestFitColumns()


        For Each NombreCampo As String In _DcParametros.Keys
            Dim columna As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName(NombreCampo)
            If Not IsNothing(columna) Then
                Dim param As Parametros = _DcParametros(NombreCampo)
                If param.Longitud > 0 Then columna.Width = param.Longitud
            End If
        Next


    End Sub



    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
        TxDfecha.Text = mdfecha
        TxHfecha.Text = mhfecha

    End Sub

    Private Sub FrmConsultaAlbaranes_DespuesDeIncluirCampoCalculado(ByVal c As DevExpress.XtraGrid.Columns.GridColumn) Handles MyBase.DespuesDeIncluirCampoCalculado
        AñadeResumenCampo(c.FieldName, "{0:n2}")
    End Sub

    Public Overrides Sub GridClik(ByVal row As System.Data.DataRow, ByVal column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)
        Dim I As Integer = 0
        BuscarRow = row
        '        I = VaInt(row("idenvase"))
        Me.Close()

    End Sub

    Protected Overrides Sub OcultaCargando()
        MyBase.OcultaCargando()

        Grid.Select()
        Grid.Focus()

    End Sub

    Public Overrides Sub Intro()

        MyBase.intro()


        Dim row As System.Data.DataRow

        row = GridView1.GetFocusedDataRow()
        If Not row Is Nothing Then
            BuscarRow = row
            Me.Close()
        End If

    End Sub

    Private Sub Grid_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Protected Overrides Sub RowCellStyle(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn, sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        MyBase.RowCellStyle(row, column, sender, e)


        If Not IsNothing(row) Then

            If _DcParametros.ContainsKey(e.Column.FieldName) Then

                Dim DcCondiciones As Dictionary(Of Object, Color) = _DcParametros(e.Column.FieldName).DcCondiciones
                If Not IsNothing(DcCondiciones) Then

                    If DcCondiciones.ContainsKey(row(e.Column.FieldName)) Then
                        e.Appearance.BackColor = DcCondiciones(row(e.Column.FieldName))
                        'ElseIf DcCondiciones.ContainsKey(Nothing) Then
                        '    e.Appearance.BackColor = DcCondiciones(Nothing)
                    End If

                End If


            End If

        End If

    End Sub

End Class