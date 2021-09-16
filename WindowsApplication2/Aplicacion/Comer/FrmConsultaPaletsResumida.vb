
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls


Public Class FrmConsultaPaletsResumida
    Inherits FrConsulta


    Private Class AcumulaPalets
        Inherits Acumulador

        Public Sub SumaPalets(stClave As Object, stDatos As Object, IdPalet As Integer)
            MyBase.Suma(stClave, stDatos)

            Dim clave As stClaves_PaletsResumidos = ObtenerClave(stClave)

            If Not clave.DcPalets.ContainsKey(IdPalet) Then
                Dc(clave).Palets = Dc(clave).Palets + 1
            End If

        End Sub

    End Class


    Private Class stClaves_PaletsResumidos

        Public DcPalets As New Dictionary(Of Integer, Integer)

        Public IdGenero As Integer = 0
        Public IdConfecEnvase As Integer = 0
        Public GeneroConfeccion As String = ""
        Public Categoria As String = ""
        Public NumPalets As Integer = 0
        Public TipoPalet As String = ""
        Public Envase As String = ""
        Public Marca As String = ""

        Public Sub New(IdGenero As Integer, IdConfecEnvase As Integer, GeneroConfeccion As String, Categoria As String,
                       TipoPalet As String, Envase As String, Marca As String)

            Me.IdGenero = IdGenero
            Me.IdConfecEnvase = IdConfecEnvase
            Me.GeneroConfeccion = GeneroConfeccion
            Me.Categoria = Categoria
            Me.TipoPalet = TipoPalet
            Me.Envase = Envase
            Me.Marca = Marca

        End Sub

    End Class


    Private Class stDatos_PaletsResumidos

        Public Bultos As Integer = 0
        Public Kilos As Decimal = 0
        Public Palets As Integer = 0

        Public Sub New(Bultos As Integer, Kilos As Decimal)

            Me.Bultos = Bultos
            Me.Kilos = Kilos

        End Sub

    End Class




    Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
    Dim Palets As New E_palets(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, CnCtb)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim ConfecPalets As New E_ConfecPalet(Idusuario, cn)
    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
    Dim AlbSalida_Palets As New E_albsalida_palets(Idusuario, cn)
    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim SubFamilias As New E_Subfamilias(Idusuario, cn)
    Dim FamiliasGeneros As New E_FamiliasGeneros(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)




    Dim err As New Errores


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Palets.PAL_fecha, Lb1)
        ParamTx(TxDato2, Palets.PAL_fecha, Lb2)

        cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)
        CbFamilias = ComboFamilias(CbFamilias)

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub FrmConsultaPaletsResumida_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente

    End Sub


    Private Sub Fechaspordefecto()
        TxDato1.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato2.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Palets_Lineas.PLL_idlinea, "IdLinea")
        consulta.SelCampo(Nothing, "GeneroConfeccion")
        consulta.SelCampo(Palets.PAL_idpalet, "IdPalet", Palets_Lineas.PLL_idpalet, Palets.PAL_idpalet)
        consulta.SelCampo(Palets_Lineas.PLL_idgenero, "IdGenero")
        consulta.SelCampo(Palets_Lineas.PLL_idtipoconfeccion, "IdTipoConfeccion")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Palets_Lineas.PLL_idgenero, Generos.GEN_IdGenero)
        consulta.SelCampo(SubFamilias.SFA_idfamilia, "IdFamilia", Generos.GEN_IdsubFamilia, SubFamilias.SFA_id)
        consulta.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", Palets_Lineas.PLL_idcategoria, CategoriasSalida.CAS_Id)
        consulta.SelCampo(Marcas.MAR_Nombre, "Marca", Palets_Lineas.PLL_idmarca)
        consulta.SelCampo(ConfecPalets.CPA_Nombre, "ConfecPalet", Palets.PAL_idtipopalet, ConfecPalets.CPA_Idconfec)
        consulta.SelCampo(ConfecEnvase.CEV_Nombre, "ConfecEnvase", Palets_Lineas.PLL_idtipoconfeccion, ConfecEnvase.CEV_Idconfec)
        consulta.SelCampo(Envases.ENV_Nombre, "Envase", ConfecEnvase.CEV_IdEnvase, Envases.ENV_IdEnvase)
        consulta.SelCampo(AlbSalida_Palets.ASP_IdAlbaran, "IdAlbaran", Palets.PAL_idpalet, AlbSalida_Palets.ASP_Idpalet)
        consulta.SelCampo(Palets_Lineas.PLL_bultos, "Bultos")
        consulta.SelCampo(Palets_Lineas.PLL_kilosnetos, "KilosNetos")

        If TxDato1.Text.Trim <> "" Then consulta.WheCampo(Palets.PAL_fecha, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then consulta.WheCampo(Palets.PAL_fecha, "<=", TxDato2.Text)


        Dim WHE As String = consulta.Whe

        'Existencias
        If RbEnExistencias.Checked Then
            If WHE = "" Then
                WHE = " WHERE COALESCE(AlbSalida_Palets.ASP_IdAlbaran,0) = 0" & vbCrLf
            Else
                WHE = WHE & " AND COALESCE(AlbSalida_Palets.ASP_IdAlbaran,0) = 0" & vbCrLf
            End If
        ElseIf RbNoEnExistencias.Checked Then
            If WHE = "" Then
                WHE = " WHERE COALESCE(AlbSalida_Palets.ASP_IdAlbaran,0) <> 0" & vbCrLf
            Else
                WHE = WHE & " AND COALESCE(AlbSalida_Palets.ASP_IdAlbaran,0) <> 0" & vbCrLf
            End If
        End If


        'Entradas confeccionadas
        If rbEntradasConfeccionadas.Checked Then
            If WHE = "" Then
                WHE = " WHERE COALESCE(PLL_IdLineaEntradaConfeccionada,0) <> 0 "
            Else
                WHE = WHE & " AND COALESCE(PLL_IdLineaEntradaConfeccionada,0) <> 0 "
            End If
        ElseIf rbNOEntradasConfeccionadas.Checked Then
            If WHE = "" Then
                WHE = " WHERE COALESCE(PLL_IdLineaEntradaConfeccionada,0) = 0 "
            Else
                WHE = WHE & " AND COALESCE(PLL_IdLineaEntradaConfeccionada,0) = 0 "
            End If
        End If


        'PV
        If WHE = "" Then
            WHE = CadenaWhereLista(Palets.PAL_idpuntoventa, ListadeCombo(cbPuntoVenta), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(Palets.PAL_idpuntoventa, ListadeCombo(cbPuntoVenta), " AND ")
        End If
        'Familias
        If WHE = "" Then
            WHE = CadenaWhereLista(SubFamilias.SFA_idfamilia, ListadeCombo(CbFamilias), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(SubFamilias.SFA_idfamilia, ListadeCombo(CbFamilias), " AND ")
        End If

        'Dim sql As String = consulta.Sel(ChkTodos.Checked) + WHE + " order by fecha"
        Dim sql As String = consulta.Sel(_IncluirTodosLosCampos) + WHE + " order by PAL_fecha"

        GridView1.Columns.Clear()
        Dim dt As DataTable = Palets.MiConexion.ConsultaSQL(sql)


        Dim Acum As New AcumulaPalets

        For Each row As DataRow In dt.Rows

            Dim IdGenero As Integer = VaInt(row("IdGenero"))
            Dim IdConfec As Integer = VaInt(row("IdTipoConfeccion"))
            Dim Genero As String = IdGenero.ToString("00000")
            Dim Confec As String = IdConfec.ToString("00000")
            Dim NombreConfec As String = (row("Genero").ToString & "").Trim & " " & (row("ConfecEnvase").ToString & "").Trim
            NombreConfec = Genero & Confec & " " & NombreConfec
            Dim Categoria As String = (row("Categoria").ToString & "").Trim
            Dim TipoPalet As String = (row("ConfecPalet").ToString & "").Trim
            Dim Envase As String = (row("Envase").ToString & "").Trim
            Dim Marca As String = (row("Marca").ToString & "").Trim

            Dim Bultos As Integer = VaInt(row("Bultos"))
            Dim Kilos As Decimal = VaDec(row("KilosNetos"))

            Dim IdPalet As Integer = VaInt(row("IdPalet"))


            Dim stClaves As New stClaves_PaletsResumidos(IdGenero, IdConfec, NombreConfec, Categoria, TipoPalet, Envase, Marca)
            Dim stDatos As New stDatos_PaletsResumidos(Bultos, Kilos)

            Acum.SumaPalets(stClaves, stDatos, IdPalet)

        Next




        Dim dtFinal As DataTable = Acum.DataTable
        For Each row As DataRow In dtFinal.Rows
            row("NumPalets") = row("Palets")
        Next

        If dtFinal.Columns.Contains("Palets") Then
            dtFinal.Columns.Remove("Palets")
        End If



        Grid.DataSource = dtFinal





        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Bultos", "{0:n0}")
        AñadeResumenCampo("Kilos", "{0:n2}")


        AjustaColumnas()






        CalculaNumPalets()


    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CATEGORIA", "NUMPALETS", "MARCA", "TIPOPALET", "BULTOS", "KILOS", "ENVASE"
                    c.Visible = True
                Case Else
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "BULTOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 85
                Case "KILOSNETOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 85
                Case "CATEGORIA"
                    c.Width = 75
                Case "FECHA"
                    c.MinWidth = 80
                    c.MaxWidth = 80

                Case "FSALIDA"
                    c.MinWidth = 80
                    c.MaxWidth = 80
                    c.Caption = "F.Salida"

            End Select
        Next


        With GridView1.Columns

            If Not IsNothing(.ColumnByFieldName("GeneroConfeccion")) Then
                .ColumnByFieldName("GeneroConfeccion").GroupIndex = 1
            End If

        End With


    End Sub


    Public Overrides Sub ColumnFilterChanged(sender As Object, e As System.EventArgs)
        MyBase.ColumnFilterChanged(sender, e)

        CalculaNumPalets()

    End Sub


    Private Sub CalculaNumPalets()

        'Número de palets diferentes
        'Dim cont As Integer = 0

        'Dim DcPalet As New Dictionary(Of Integer, Integer)
        'For indice As Integer = 0 To GridView1.RowCount - 1

        '    Dim row As DataRow = GridView1.GetDataRow(indice)
        '    If Not IsNothing(row) Then
        '        Dim IdPalet As Integer = VaInt(row("IdPalet"))
        '        If Not DcPalet.ContainsKey(IdPalet) Then
        '            DcPalet(IdPalet) = IdPalet
        '            cont = cont + 1
        '        End If
        '    End If

        'Next

        Dim NumPalets As Integer = 0

        If Not IsNothing(Grid.DataSource) Then

            Dim dt As DataTable = CType(Grid.DataSource, DataTable)
            If dt.Columns.Contains("NumPalets") Then
                NumPalets = VaInt(dt.Compute("SUM(NumPalets)", ""))
            End If


        End If

        LbNumPalets.Text = "Nº Palets: " & NumPalets.ToString


    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()

        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim lstPuntoVenta As New List(Of Integer)
                Dim lstFamilias As New List(Of Integer)

                For Each it As CheckedListBoxItem In cbPuntoVenta.Properties.GetItems()
                    If it.CheckState = CheckState.Checked Then
                        lstPuntoVenta.Add(VaInt(it.Value))
                    End If
                Next
                For Each it As CheckedListBoxItem In CbFamilias.Properties.GetItems()
                    If it.CheckState = CheckState.Checked Then
                        lstFamilias.Add(VaInt(it.Value))
                    End If
                Next

                Dim Existencias As String = ""
                Dim Confeccionadas As String = ""

                If RbEnExistencias.Checked Then
                    Existencias = "S"
                ElseIf RbNoEnExistencias.Checked Then
                    Existencias = "N"
                End If

                If rbEntradasConfeccionadas.Checked Then
                    Confeccionadas = "S"
                ElseIf rbNOEntradasConfeccionadas.Checked Then
                    Confeccionadas = "N"
                End If


                ImprimirConsultaPaletsResumida(dt, TxDato1.Text, TxDato2.Text, Existencias, Confeccionadas, lstPuntoVenta, lstFamilias)

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


    Public Overrides Sub Imprimir()

        Dim PuntoVenta As String = ""
        Dim Familias As String = ""

        Dim lstPuntoVenta As List(Of String) = ListadeCombo(cbPuntoVenta)
        Dim lstFamilias As List(Of String) = ListadeCombo(CbFamilias)

        For Each s As String In lstPuntoVenta
            If PuntoVenta <> "" Then PuntoVenta = PuntoVenta & ","
            PuntoVenta = PuntoVenta & s
        Next
        For Each s As String In lstFamilias
            If Familias <> "" Then Familias = Familias & ","
            Familias = Familias & s
        Next



        LineasDescripcion.Clear()
        If TxDato1.Text.Trim <> "" Or TxDato2.Text.Trim <> "" Then LineasDescripcion.Add("Desde " & TxDato1.Text & " hasta " & TxDato2.Text)
        If PuntoVenta <> "" Then LineasDescripcion.Add("Punto de Venta: " & PuntoVenta)
        If Familias <> "" Then LineasDescripcion.Add("Familias: " & Familias)
        If RbEnExistencias.Checked Then
            LineasDescripcion.Add("Imprimir en existencias: SI")
        ElseIf RbNoEnExistencias.Checked Then
            LineasDescripcion.Add("Imprimir en existencias: NO")
        ElseIf RbTodos.Checked Then
            LineasDescripcion.Add("Imprimir en existencias: TODOS")
        End If
        If rbEntradasConfeccionadas.Checked Then
            LineasDescripcion.Add("Imprimir entradas confeccionadas: SI")
        ElseIf rbNOEntradasConfeccionadas.Checked Then
            LineasDescripcion.Add("Imprimir entradas confeccionadas: NO")
        ElseIf rbTodasEntradasConfeccionadas.Checked Then
            LineasDescripcion.Add("Imprimir entradas confeccionadas: TODOS")
        End If


        MyBase.Imprimir()
    End Sub


End Class