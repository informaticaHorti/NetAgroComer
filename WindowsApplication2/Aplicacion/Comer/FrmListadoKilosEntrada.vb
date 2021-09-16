
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class FrmListadoKilosEntrada
    Inherits FrConsulta



    Private Class stClaves_KilosEntrada

        Public IdSubFamilia As Integer = 0
        Public SubFamilia As String = ""
        Public NombreSubFamilia As String = ""
        Public IdGenero As Integer = 0
        Public Genero As String = ""
        Public Categoria As String = ""

        Public Sub New(IdSubFamilia As Integer, SubFamilia As String, IdGenero As Integer, Genero As String, Categoria As String)
            Me.IdSubFamilia = IdSubFamilia
            Me.SubFamilia = SubFamilia
            Me.NombreSubFamilia = SubFamilia
            Me.IdGenero = IdGenero
            Me.Genero = Genero
            Me.Categoria = Categoria
        End Sub

    End Class


    Private Class stDatos_KilosEntrada

        Public KgConfec As Decimal = 0.0
        Public KgFirme As Decimal = 0.0
        Public KgComision As Decimal = 0.0
        Public TotalKilos As Decimal = 0.0
        Public Importe As Decimal = 0.0
        Public PMC As Decimal = 0.0

        Public Sub New(KgConfec As Decimal, KgFirme As Decimal, KgComision As Decimal, TotalKilos As Decimal, Importe As Decimal)
            Me.KgConfec = KgConfec
            Me.KgFirme = KgFirme
            Me.KgComision = KgComision
            Me.TotalKilos = TotalKilos
            Me.Importe = Importe
        End Sub

    End Class



    Dim AlbEntrada_His As New E_AlbEntrada_his(Idusuario, cn)
    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim AlbEntrada_hisLineas As New E_AlbEntrada_hislineas(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, CnCtb)
    'Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    'Dim Albentrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)

    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)
    Dim SubFamilias As New E_Subfamilias(Idusuario, cn)


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

        ParamTx(TxDato1, Agricultores.AGR_IdAgricultor, Lb1)
        ParamTx(TxDato2, Agricultores.AGR_IdAgricultor, Lb2)
        ParamTx(TxDato3, AlbEntrada.AEN_Fecha, Lb3)
        ParamTx(TxDato4, AlbEntrada.AEN_Fecha, Lb4)


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
        Fechaspordefecto()
    End Sub


    Private Sub Fechaspordefecto()

        TxDato3.Text = MiMaletin.FechaInicioEjercicio
        TxDato4.Text = Now.ToString("dd/MM/yyyy")

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub


    Private Sub CargaGrid()


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbEntrada_hisLineas.AHL_id, "Id")
        consulta.SelCampo(AlbEntrada.AEN_TipoFCS, "FC", AlbEntrada_hisLineas.AHL_idalbaran)
        consulta.SelCampo(AlbEntrada.AEN_EntradaConfeccionada, "EntradaConfeccionada")
        consulta.SelCampo(AlbEntrada_hisLineas.AHL_idgenero, "IdGenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbEntrada_hisLineas.AHL_idgenero)
        consulta.SelCampo(Generos.GEN_IdsubFamilia, "IdSubFamilia")
        consulta.SelCampo(SubFamilias.SFA_nombre, "SubFamilia", Generos.GEN_IdsubFamilia, SubFamilias.SFA_id)
        consulta.SelCampo(CategoriasEntrada.CAE_CategoriaCalibre, "Categoria", AlbEntrada_hisLineas.AHL_idcategoria)
        consulta.SelCampo(AlbEntrada_hisLineas.AHL_kilos, "Kilos")
        consulta.SelCampo(AlbEntrada_hisLineas.AHL_precio, "Precio")
        If TxDato1.Text.Trim <> "" Then consulta.WheCampo(AlbEntrada.AEN_IdAgricultor, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then consulta.WheCampo(AlbEntrada.AEN_IdAgricultor, "<=", TxDato2.Text)
        If TxDato3.Text.Trim <> "" Then consulta.WheCampo(AlbEntrada.AEN_Fecha, ">=", TxDato3.Text)
        If TxDato4.Text.Trim <> "" Then consulta.WheCampo(AlbEntrada.AEN_Fecha, "<=", TxDato4.Text)

        Dim sql As String = consulta.SQL
        Dim WHE As String = consulta.Whe
        If WHE.Trim = "" Then
            sql = sql & CadenaWhereLista(AlbEntrada.AEN_IdCentro, ListadeCombo(cbCentro), " WHERE ")
        Else
            sql = sql & CadenaWhereLista(AlbEntrada.AEN_IdCentro, ListadeCombo(cbCentro), " AND ")
        End If
        sql = sql & " ORDER BY GEN_IdSubFamilia, AHL_idgenero, AHL_idcategoria" & vbCrLf


        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)

        Dim acum As New Acumulador


        For Each row As DataRow In dt.Rows

            Dim IdGenero As Integer = VaInt(row("IdGenero"))
            Dim Genero As String = (row("Genero").ToString & "").Trim
            Dim IdSubFamilia As Integer = VaInt(row("IdSubFamilia"))
            Dim SubFamilia As String = IdSubFamilia.ToString("00000") & " " & (row("SubFamilia").ToString & "").Trim
            Dim Categoria As String = (row("Categoria").ToString & "").Trim

            Dim Kilos As Decimal = VaDec(row("Kilos"))
            Dim Precio As Decimal = VaDec(row("Precio"))
            Dim Importe As Decimal = Kilos * Precio


            Dim KgConfec As Decimal = 0
            Dim KgFirme As Decimal = 0
            Dim KgComision As Decimal = 0

            Dim FC As String = (row("FC").ToString & "").Trim.ToUpper
            Dim EntradaConfeccionada As String = (row("EntradaConfeccionada").ToString & "").Trim.ToUpper


            If EntradaConfeccionada = "S" Then
                KgConfec = Kilos
            ElseIf FC = "F" Then
                KgFirme = Kilos
            ElseIf FC = "C" Then
                KgComision = Kilos
            End If

            Dim stClave As New stClaves_KilosEntrada(IdSubFamilia, SubFamilia, IdGenero, Genero, Categoria)
            Dim stDatos As New stDatos_KilosEntrada(KgConfec, KgFirme, KgComision, Kilos, Importe)
            acum.Suma(stClave, stDatos)

        Next



        dt = acum.DataTable

        'Calcula PMC
        For Each row As DataRow In dt.Rows

            Dim Kilos As Decimal = VaDec(row("TotalKilos"))
            Dim Importe As Decimal = VaDec(row("Importe"))
            Dim PMC As Decimal = 0

            If Kilos <> 0 Then PMC = Importe / Kilos
            row("PMC") = PMC

        Next



        Grid.DataSource = Nothing
        GridView1.Columns.Clear()

        Grid.DataSource = dt
        AjustaColumnas()


        AñadeResumenCampo("KgConfec", "{0:n0}")
        AñadeResumenCampo("KgFirme", "{0:n0}")
        AñadeResumenCampo("KgComision", "{0:n0}")
        AñadeResumenCampo("TotalKilos", "{0:n0}")
        AñadeResumenCampo("Importe", "{0:n2}")


    End Sub



    Private Sub AjustaColumnas()

        GridView1.BestFitColumns()
        GridView1.OptionsBehavior.Editable = False

        Try

            For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
                Select Case c.FieldName.ToUpper.Trim
                    Case "IDALBARAN", "ID", "FC", "ENTRADACONFECCIONADA", "IDSUBFAMILIA", "SUBFAMILIA", "NOMBRESUBFAMILIA"
                        c.Visible = False
                End Select
            Next

            GridView1.BestFitColumns()


            For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

                Select Case c.FieldName.ToUpper.Trim

                    Case "CATEGORIA"
                        c.Width = 80

                    Case "GENERO"
                        c.Width = 120

                    Case "IMPORTE"
                        c.Width = 90
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0.00"

                    Case "PMC"
                        c.Width = 90
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,##0.00000"

                    Case "TOTALKILOS"
                        c.Width = 90
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,###"

                    Case "KGCONFEC", "KGFIRME", "KGCOMISION"
                        c.Width = 85
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,###"

                    Case "SUBFAMILIA"
                        c.GroupIndex = 1

                End Select

            Next


        Catch ex As Exception
            err.Muestraerror("Error al ajustar la columna", "AjustaColumnas", ex.Message)
        End Try


    End Sub



    Private Sub FrmCuadreAgricultorComprador_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BImprimir.Visible = False

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente


        Dim dt As New DataTable


        dt = Centros.TablaCentros

        cbCentro.Properties.DataSource = dt
        cbCentro.Properties.ValueMember = "IdCentro"
        cbCentro.Properties.DisplayMember = "Nombre"


        For Each it As CheckedListBoxItem In cbCentro.Properties.GetItems()
            If it.Value = MiMaletin.IdCentro Then
                it.CheckState = CheckState.Checked
            Else
                it.CheckState = CheckState.Unchecked
            End If
        Next


    End Sub



    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim lstCentros As List(Of String) = ListadeCombo(cbCentro)

                ImprimirListadoKilosEntrada(dt, TxDato1.Text, TxDato2.Text, TxDato3.Text, TxDato4.Text, lstCentros)
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
