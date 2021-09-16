
Public Class FrmInventarioMaterialesPorFecha
    Inherits FrConsulta


    Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)


    Private err As New Errores()



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Nothing, Lb1, True, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato2, Nothing, Lb1, True, Cdatos.TiposCampo.Fecha)
        ParamChk(chkMarcas, Nothing, "S", "N")
        ParamCb_Copia(CbAlmacenes, AlmacenEnvases.AEV_Idalmacen, Lb4, Combos.ComboAlmacenesEnvases)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()


        For Each item As Object In CbAlmacenes.Items
            If item("Id") = MiMaletin.IdPuntoVenta Then
                CbAlmacenes.SelectedItem = item
                Exit Sub
            End If
        Next

    End Sub


    Private Sub Fechaspordefecto()
        TxDato1.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato2.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub


    Private Sub CargaGrid()


        Dim sql As String = ""
        If chkMarcas.Checked Then
            sql = SQLInventarioConMarcas()
        Else
            sql = SQLInventarioSinMarcas()
        End If
        

        Dim dt As DataTable = AlmacenEnvases.MiConexion.ConsultaSQL(sql)


        GridView1.Columns.Clear()
        Grid.DataSource = dt

        AjustaColumnas()


    End Sub


    Private Function SQLInventarioConMarcas() As String

        Dim IdAlmacen As String = ""
        If VaInt(CbAlmacenes.SelectedValue) Then IdAlmacen = VaInt(CbAlmacenes.SelectedValue).ToString


        'Saldos ValesEnvases
        Dim sql1 As String = "SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase," & vbCrLf
        sql1 = sql1 & " VEL_idenvase as IdEnvase,  ENV_nombre AS Envase, " & vbCrLf
        sql1 = sql1 & " VEL_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql1 = sql1 & " 0 as Inicial, 0 as VInicial,0 as UCompra,0 as Icompra,VEL_entrega - VEL_retira as MovEnvases, 0 AS ExPalets," & vbCrLf
        sql1 = sql1 & " 0 as ExisRec," & vbCrLf
        sql1 = sql1 & " ENV_PMC as PMC" & vbCrLf
        sql1 = sql1 & " FROM ValeEnvases_Lineas" & vbCrLf
        sql1 = sql1 & " LEFT OUTER JOIN Envases ON VEL_idenvase = ENV_idenvase" & vbCrLf
        sql1 = sql1 & " LEFT OUTER JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql1 = sql1 & " LEFT OUTER JOIN ValeEnvases ON VEL_idvale = VEV_idvale" & vbCrLf
        sql1 = sql1 & " LEFT JOIN Marcas on MAR_IdMarca = VEL_IdMarca" & vbCrLf
        sql1 = sql1 & " WHERE VEV_Fecha >= '" & TxDato1.Text & "'" & vbCrLf
        sql1 = sql1 & " AND VEV_fecha <= '" & TxDato2.Text & "'" & vbCrLf
        sql1 = sql1 + " AND VEV_OPERACION<>'AC'"
        If IdAlmacen.Trim <> "" Then sql1 = sql1 & " AND VEL_IdAlmacen = " & IdAlmacen & vbCrLf



        'Saldos Iniciales
        Dim sql2 As String = "SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase," & vbCrLf
        sql2 = sql2 & " ENI_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
        sql2 = sql2 & "  ENI_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql2 = sql2 & " ENI_Inicial as Inicial,ENI_inicial*ENI_precio as Vinicial,0 as Ucompra,0 as Icompra, 0 as MovEnvases, 0 as ExPalets," & vbCrLf
        sql2 = sql2 & " 0 as ExisRec, " & vbCrLf
        sql2 = sql2 & " ENV_PMC as PMC" & vbCrLf
        sql2 = sql2 & " FROM EnvasesInicial" & vbCrLf
        sql2 = sql2 & " LEFT OUTER JOIN Envases ON ENI_idenvase = ENV_idenvase " & vbCrLf
        sql2 = sql2 & " LEFT OUTER JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql2 = sql2 & " LEFT OUTER JOIN Marcas on MAR_IdMarca = ENI_IdMarca" & vbCrLf
        sql2 = sql2 & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString & " AND ENI_Tipo = 'AL' " & vbCrLf
        If IdAlmacen.Trim <> "" Then sql2 = sql2 & " AND ENI_Codigo = " & IdAlmacen & vbCrLf

        'Compras
        Dim sql3 As String = "SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase," & vbCrLf
        sql3 = sql3 & " VEL_idenvase as IdEnvase,  ENV_nombre AS Envase, " & vbCrLf
        sql3 = sql3 & " VEL_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql3 = sql3 & " 0 as Inicial, 0 as VInicial,VEL_entrega as UCompra,VEL_entrega*VEL_precioentrega as Icompra,0 as MovEnvases, 0 AS ExPalets," & vbCrLf
        sql3 = sql3 & " 0 as ExisRec," & vbCrLf
        sql3 = sql3 & " ENV_PMC as PMC" & vbCrLf
        sql3 = sql3 & " FROM ValeEnvases_Lineas" & vbCrLf
        sql3 = sql3 & " LEFT OUTER JOIN Envases ON VEL_idenvase = ENV_idenvase" & vbCrLf
        sql3 = sql3 & " LEFT OUTER JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql3 = sql3 & " LEFT OUTER JOIN ValeEnvases ON VEL_idvale = VEV_idvale" & vbCrLf
        sql3 = sql3 & " LEFT JOIN Marcas on MAR_IdMarca = VEL_IdMarca" & vbCrLf
        sql3 = sql3 & " WHERE VEV_Fecha >= '" & TxDato1.Text & "'" & vbCrLf
        sql3 = sql3 & " AND VEV_fecha <= '" & TxDato2.Text & "'" & vbCrLf
        sql3 = sql3 + " AND VEV_OPERACION='AC'"

        If IdAlmacen.Trim <> "" Then sql3 = sql3 & " AND VEL_IdAlmacen = " & IdAlmacen & vbCrLf



        'Calcula existencias agrupando
        Dim sql4 As String = "SELECT IdFamiliaEnvase, FamiliaEnvase, IdEnvase, Envase, IdMarca, Marca, " & vbCrLf
        sql4 = sql4 & " SUM(Inicial) as Inicial, SUM(Vinicial) as Vinicial,SUM(Ucompra) as ucompra,Sum(icompra) as icompra,SUM(Movenvases) as movenvases, " & vbCrLf
        sql4 = sql4 & " SUM(ExPalets) as ExPalets, SUM(Inicial + movenvases - ExPalets) as Existencias," & vbCrLf
        sql4 = sql4 & " PMC, SUM(ExisRec) as ExisRec" & vbCrLf
        sql4 = sql4 & " FROM (" & vbCrLf
        sql4 = sql4 & vbCrLf & sql1 & vbCrLf
        sql4 = sql4 & " UNION ALL" & vbCrLf
        sql4 = sql4 & vbCrLf & sql2 & vbCrLf
        sql4 = sql4 & " UNION ALL" & vbCrLf
        sql4 = sql4 & vbCrLf & sql3 & vbCrLf
        sql4 = sql4 & " ) AS M" & vbCrLf
        sql4 = sql4 & " GROUP BY idfamiliaEnvase, FamiliaEnvase, idenvase, Envase, IdMarca, Marca, PMC" & vbCrLf


        'Calcula diferencias, agrupando
        Dim sql As String = "SELECT cast(IdFamiliaEnvase as varchar) + ' ' + FamiliaEnvase as FamiliaEnvase, IdEnvase, Envase, IdMarca, Marca," & vbCrLf
        sql = sql & " SUM(Inicial) as Inicial,sum(Vinicial) as Vinicial, sum(ucompra) as ucompra,sum(icompra) as icompra,SUM(Movenvases) as MovEnvases, " & vbCrLf
        sql = sql & " SUM(ExPalets) as ExPalets, SUM(Existencias) as Existencias, PMC," & vbCrLf
        sql = sql & " SUM(Existencias * PMC) as ValorExistencias," & vbCrLf
        sql = sql & " SUM(ExisRec) as ExiRec," & vbCrLf
        sql = sql & " SUM(ExisRec * PMC) as ImpRec," & vbCrLf
        sql = sql & " SUM(ExisRec - Existencias) as DifUnds," & vbCrLf
        sql = sql & " SUM(Existencias * PMC) - SUM(ExisRec * PMC) as DifImp" & vbCrLf
        sql = sql & " FROM" & vbCrLf
        sql = sql & " (" & vbCrLf
        sql = sql & sql4 & vbCrLf
        sql = sql & " )as X " & vbCrLf
        sql = sql & " GROUP BY idfamiliaEnvase, FamiliaEnvase, idenvase, Envase, IdMarca, Marca, PMC" & vbCrLf
        sql = sql & " ORDER BY IdFamiliaEnvase, IdEnvase, IdMarca" & vbCrLf



        Return sql

    End Function


    Private Function SQLInventarioSinMarcas() As String

        Dim IdAlmacen As String = ""
        If VaInt(CbAlmacenes.SelectedValue) Then IdAlmacen = VaInt(CbAlmacenes.SelectedValue).ToString


        'Saldos ValesEnvases
        Dim sql1 As String = "SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase," & vbCrLf
        sql1 = sql1 & " VEL_idenvase as IdEnvase,  ENV_nombre AS Envase, " & vbCrLf
        sql1 = sql1 & " 0 as Inicial, VEL_entrega as Entrega, VEL_retira as Retira, 0 AS ExPalets," & vbCrLf
        sql1 = sql1 & " 0 as ExisRec," & vbCrLf
        sql1 = sql1 & " ENV_PMC as PMC" & vbCrLf
        sql1 = sql1 & " FROM ValeEnvases_Lineas" & vbCrLf
        sql1 = sql1 & " LEFT OUTER JOIN Envases ON VEL_idenvase = ENV_idenvase" & vbCrLf
        sql1 = sql1 & " LEFT OUTER JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql1 = sql1 & " LEFT OUTER JOIN ValeEnvases ON VEL_idvale = VEV_idvale" & vbCrLf
        sql1 = sql1 & " WHERE VEV_Fecha >= '" & TxDato1.Text & "'" & vbCrLf
        sql1 = sql1 & " AND VEV_fecha <= '" & TxDato2.Text & "'" & vbCrLf
        If IdAlmacen.Trim <> "" Then sql1 = sql1 & " AND VEL_IdAlmacen = " & IdAlmacen & vbCrLf


        'Saldos Iniciales
        Dim sql2 As String = "SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase," & vbCrLf
        sql2 = sql2 & " ENI_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
        sql2 = sql2 & " ENI_Inicial as Inicial, 0 as Entrega, 0 as Retira, 0 as ExPalets," & vbCrLf
        sql2 = sql2 & " 0 as ExisRec, " & vbCrLf
        sql2 = sql2 & " ENV_PMC as PMC" & vbCrLf
        sql2 = sql2 & " FROM EnvasesInicial" & vbCrLf
        sql2 = sql2 & " LEFT OUTER JOIN Envases ON ENI_idenvase = ENV_idenvase " & vbCrLf
        sql2 = sql2 & " LEFT OUTER JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql2 = sql2 & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString & " AND ENI_Tipo = 'AL' " & vbCrLf
        If IdAlmacen.Trim <> "" Then sql2 = sql2 & " AND ENI_Codigo = " & IdAlmacen & vbCrLf




        'Calcula existencias agrupando
        Dim sql4 As String = "SELECT IdFamiliaEnvase, FamiliaEnvase, IdEnvase, Envase, " & vbCrLf
        sql4 = sql4 & " SUM(Inicial) as Inicial, SUM(Entrega) as Entrega, SUM(Retira) as Retira, " & vbCrLf
        sql4 = sql4 & " SUM(ExPalets) as ExPalets, SUM(Inicial + Entrega - Retira - ExPalets) as Existencias," & vbCrLf
        sql4 = sql4 & " PMC, SUM(ExisRec) as ExisRec" & vbCrLf
        sql4 = sql4 & " FROM (" & vbCrLf
        sql4 = sql4 & vbCrLf & sql1 & vbCrLf
        sql4 = sql4 & " UNION ALL" & vbCrLf
        sql4 = sql4 & vbCrLf & sql2 & vbCrLf
        sql4 = sql4 & " ) AS M" & vbCrLf
        sql4 = sql4 & " GROUP BY idfamiliaEnvase, FamiliaEnvase, idenvase, Envase, PMC" & vbCrLf


        'Calcula diferencias, agrupando
        Dim sql As String = "SELECT cast(IdFamiliaEnvase as varchar) + ' ' + FamiliaEnvase as FamiliaEnvase, IdEnvase, Envase, " & vbCrLf
        sql = sql & " SUM(Inicial) as Inicial, SUM(Entrega) as Entrega, SUM(Retira) as Retira, " & vbCrLf
        sql = sql & " SUM(ExPalets) as ExPalets, SUM(Existencias) as Existencias, PMC," & vbCrLf
        sql = sql & " SUM(Existencias * PMC) as ValorExistencias," & vbCrLf
        sql = sql & " SUM(ExisRec) as ExiRec," & vbCrLf
        sql = sql & " SUM(ExisRec * PMC) as ImpRec," & vbCrLf
        sql = sql & " SUM(ExisRec - Existencias) as DifUnds," & vbCrLf
        sql = sql & " SUM(Existencias * PMC) - SUM(ExisRec * PMC) as DifImp" & vbCrLf
        sql = sql & " FROM" & vbCrLf
        sql = sql & " (" & vbCrLf
        sql = sql & sql4 & vbCrLf
        sql = sql & " )as X " & vbCrLf
        sql = sql & " GROUP BY idfamiliaEnvase, FamiliaEnvase, idenvase, Envase, PMC" & vbCrLf
        sql = sql & " ORDER BY IdFamiliaEnvase, IdEnvase" & vbCrLf



        Return sql

    End Function



    Private Sub AjustaColumnas()

        With GridView1.Columns

            If Not IsNothing(.ColumnByFieldName("IdMarca")) Then .ColumnByFieldName("IdMarca").Visible = False
            If Not IsNothing(.ColumnByFieldName("FamiliaEnvase")) Then
                .ColumnByFieldName("FamiliaEnvase").GroupIndex = 1
                .ColumnByFieldName("FamiliaEnvase").Visible = False
            End If

        End With


        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDENVASE"
                    c.Caption = "Cod"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.MaxWidth = 50
                    c.MinWidth = 50

                Case "ENVASE"
                    c.Caption = "Material"

                Case "MARCA"


                Case "PMC"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00####"
                    c.Width = 80

                Case Else
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 80

            End Select

        Next


        AñadeResumenCampo("Inicial", "{0:n2}")
        AñadeResumenCampo("Entrega", "{0:n2}")
        AñadeResumenCampo("Retira", "{0:n2}")
        AñadeResumenCampo("ExPalets", "{0:n2}")
        AñadeResumenCampo("Existencias", "{0:n2}")
        AñadeResumenCampo("ValorExistencias", "{0:n2}")
        AñadeResumenCampo("ExiRec", "{0:n2}")
        AñadeResumenCampo("ImpRec", "{0:n2}")
        AñadeResumenCampo("DifUnds", "{0:n2}")
        AñadeResumenCampo("DifImp", "{0:n2}")


    End Sub



    Private Sub FrmInventarioMaterialesPorFecha_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim fuente_nueva As New Font(fuente.FontFamily, fuente.Size + 1, FontStyle.Bold)
        GridView1.Appearance.GroupRow.Font = fuente_nueva

        GridView1.OptionsView.ShowGroupPanel = False


        


    End Sub



    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()


        'Género
        LineasDescripcion.Add("Desde fecha : " & TxDato1.Text & "  Hasta fecha : " & TxDato2.Text)
        LineasDescripcion.Add("Almacén: " & CbAlmacenes.Text)
        If chkMarcas.Checked Then LineasDescripcion.Add("Listado con marcas")

        MyBase.Imprimir()

    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()

        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                ImprimirInventarioMaterialesPorFecha(dt, TxDato1.Text, TxDato2.Text, chkMarcas.Checked, CbAlmacenes.Text)

            Else
                bDatos = False
            End If
        Else
            bDatos = False
        End If


        If Not bDatos Then
            MessageBox.Show("No hay datos que imprimir")
        End If

    End Sub


End Class

