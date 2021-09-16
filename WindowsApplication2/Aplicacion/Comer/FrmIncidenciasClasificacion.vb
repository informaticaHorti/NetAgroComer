
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls


Public Class FrmIncidenciasClasificacion
    Inherits FrConsulta


    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc


        ParamTx(TxAgricultor, Agricultores.AGR_IdAgricultor, LbAgricultor)
        'ParamTx(TxCampaCultivo, AlbEntrada_Lineas.AEL_campacultivo, LbCultivo, False)
        ParamTx(TxCultivo, AlbEntrada_Lineas.AEL_idcultivo, LbCultivo, False)

        AsociarControles(TxAgricultor, BtBuscaAgricultor, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNomAgricultor)


    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


        btHistorico.Enabled = True

        CbCultivo.DataSource = Nothing
        CbGenero.DataSource = Nothing

        LbCampaCultivo.Text = ""

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        If VaInt(TxAgricultor.Text) = 0 Then
            MsgBox("Debe introducir un agricultor válido")
            Exit Sub
        End If


        GridView1.Columns.Clear()


        Dim CampaCultivo As String = ""
        Dim IdCultivo As String = ""

        If Not TypeOf CbCultivo.SelectedValue Is System.Data.DataRowView Then


            Dim cultivo As String = CbCultivo.SelectedValue & ""
            If cultivo.Length >= 2 Then

                CampaCultivo = VaInt(cultivo.Substring(0, 2)).ToString
                IdCultivo = VaInt(cultivo.Substring(2, cultivo.Length - 2)).ToString

                If VaInt(CampaCultivo) = 0 Then CampaCultivo = ""
                If VaInt(IdCultivo) = 0 Then IdCultivo = ""

            Else
                MsgBox("Debe introducir un cultivo")
                Exit Sub
            End If

        End If



        If IdCultivo = "" Then
            MsgBox("Debe introducir un cultivo")
            Exit Sub
        End If


        Dim IdGenero As String = VaInt(CbGenero.SelectedValue)

        



        Dim dt As DataTable = Agro_HistorialCultivoAgricultor(TxAgricultor.Text, IdCultivo, IdGenero)
        Grid.DataSource = dt



        AjustaColumnas()

        AñadeResumenCampo("Cantidad", "{0:n4}")
        AñadeResumenCampo("Importe", "{0:n2}")

    End Sub


    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select c.FieldName.ToUpper.Trim
                Case "IDLINEA"
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDGENERO"
                    c.Width = 50
                    c.Caption = "CodGen"

                Case "PARTIDA"
                    c.Width = 80
                    c.MaxWidth = 80
                Case "FECHA"
                    c.MinWidth = 75
                    c.MaxWidth = 75
                    c.Width = 75
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case "PORCENKILOSA", "PORCENKILOSB", "PORCENKILOSC", "PORCENKILOSD", "PORCENDESTRIO"
                    c.MinWidth = 45
                    c.MaxWidth = 45
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.Caption = "%"
                Case "KILOSA", "KILOSB", "KILOSC", "KILOSD", "DESTRIO"
                    c.Caption = c.Caption.Replace("Kilos", "")
                    c.MinWidth = 85
                    c.MaxWidth = 85
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                Case "TOTAL"
                    c.MinWidth = 90
                    c.MaxWidth = 90
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                Case "OBSERVACIONES"

                Case "IDAGRICULTOR"
                    c.Caption = "CodAgr"
                    c.MinWidth = 50
                    c.MaxWidth = 50


            End Select
        Next

    End Sub


    Public Overrides Sub Salir()

        If btHistorico.Enabled Then
            'Salgo normalmente
            MyBase.Salir()
        Else
            'Borro los datos
            GridView1.Columns.Clear()
            Grid.DataSource = Nothing
            btHistorico.Enabled = True
        End If

    End Sub



    Public Overrides Sub Informe()
        MyBase.Informe()

    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()


        Dim agricultor As String = ""
        If TxAgricultor.Text.Trim <> "" Then agricultor = "Agricultor: " & VaInt(TxAgricultor.Text).ToString("0000") & " - " & LbNomAgricultor.Text

        Dim cultivo As String = FiltroCombo("Cultivo", CbCultivo)
        Dim genero As String = FiltroCombo("Genero", CbGenero)

        If agricultor <> "" Then LineasDescripcion.Add(agricultor)
        If cultivo <> "" Then LineasDescripcion.Add(cultivo)
        If genero <> "" Then LineasDescripcion.Add(genero)


        MyBase.Imprimir()

    End Sub


    Private Sub TxAgricultor_Valida(edicion As System.Boolean) Handles TxAgricultor.Valida

        CbCultivo.DataSource = Nothing
        CbCultivo.SelectedIndex = -1

        CbGenero.DataSource = Nothing
        CbGenero.SelectedIndex = -1

        If VaInt(TxAgricultor.Text) > 0 Then

            'Actualiza datos cultivo
            CargaCultivo(TxAgricultor.Text)

        End If


    End Sub


    Private Sub TxAgricultor_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxAgricultor.KeyDown

        If e.KeyCode = Keys.Enter Then

            If Not TxAgricultor.MiError Then

                If TxAgricultor.Text.Trim <> "" Then

                    CbCultivo.Select()
                    CbCultivo.Focus()

                Else

                    TxCultivo.Select()
                    TxCultivo.Focus()

                End If

            End If

        End If

    End Sub


    Private Sub CbCultivo_Valida(edicion As System.Boolean) Handles CbCultivo.Valida

        'Actualiza datos genero
        If CbCultivo.SelectedIndex >= 0 Then

            Dim cultivo As String = CbCultivo.SelectedValue & ""
            If cultivo.Length >= 2 Then

                'Dim Campa As Integer = VaInt(cultivo.Substring(0, 2))
                Dim IdCultivo As Integer = VaInt(cultivo.Substring(2, cultivo.Length - 2))

                CargaGenero(TxAgricultor.Text, IdCultivo.ToString)

            End If

        End If


    End Sub


    Private Sub CargaCultivo(IdAgricultor As String)



        Dim sql As String = ""

        If Not EsTecnicosNet() Then

            sql = "SELECT DISTINCT Cultivo, RTRIM(CAST(Cultivo as varchar) + ' - ' +  COALESCE(Nombre, '')) as Nombre" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & " SELECT RIGHT('00' + CAST(AEL_CampaCultivo AS varchar), 2) + RIGHT('00000' + CAST(AEL_IdCultivo AS varchar), 5) as Cultivo, " & vbCrLf
            sql = sql & " I.Nombre as Nombre" & vbCrLf
            sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
            sql = sql & " LEFT JOIN AlbEntrada ON AEN_Idalbaran = AEL_IdAlbaran " & vbCrLf
            sql = sql & " LEFT JOIN TecnicosSQL.dbo.Cultivos_Lineas CL ON (CL.cdCampa = AEL_CampaCultivo AND CL.IdCultivo = AEL_IdCultivo)" & vbCrLf
            sql = sql & " LEFT JOIN TecnicosSQL.dbo.invernaderos I ON (I.cdCampa = CL.cdCampa AND I.cdFinca = CL.cdFinca AND I.cdNave = CL.cdNave)" & vbCrLf
            sql = sql & " WHERE AEL_CampaCultivo = " & MiMaletin.Ejercicio.ToString & vbCrLf
            sql = sql & " AND AEN_IdAgricultor = " & IdAgricultor & vbCrLf
            sql = sql & " ) as C" & vbCrLf
            sql = sql & " ORDER BY Cultivo" & vbCrLf

        Else

            sql = "SELECT DISTINCT Cultivo, CAST(Cultivo as varchar) + ' - ' + CAST(Nave as varchar) as Nombre" & vbCrLf
            sql = sql & " FROM (" & vbCrLf
            sql = sql & " SELECT RIGHT('00' + CAST(AEL_CampaCultivo AS varchar), 2) + CAST(AEL_IdCultivo AS varchar) as Cultivo, RTRIM(CAST(NAV_Nombre as varchar)) as Nave" & vbCrLf
            sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
            sql = sql & " LEFT JOIN AlbEntrada ON AEN_Idalbaran = AEL_IdAlbaran " & vbCrLf
            sql = sql & " LEFT JOIN TecnicosNET.dbo.Cultivos ON AEL_IdCultivo = CUL_IdCultivo" & vbCrLf
            sql = sql & " LEFT JOIN TecnicosNET.dbo.Naves ON CUL_IdNave = NAV_IdNave" & vbCrLf
            sql = sql & " WHERE AEN_IdAgricultor = " & IdAgricultor & vbCrLf
            sql = sql & " AND CUL_Activo = 'S'" & vbCrLf
            sql = sql & " ) as C" & vbCrLf
            sql = sql & " ORDER BY Cultivo" & vbCrLf

        End If

        
        Dim dt As DataTable = Agricultores.MiConexion.ConsultaSQL(sql)

        CbCultivo.DataSource = dt
        CbCultivo.DisplayMember = "Nombre"
        CbCultivo.ValueMember = "Cultivo"


        If CbCultivo.Items.Count = 1 Then
            CbCultivo.SelectedIndex = 0
        Else
            CbCultivo.SelectedIndex = -1
        End If



    End Sub


    Private Sub CargaGenero(IdAgricultor As String, IdCultivo As String)


        CbGenero.DataSource = Nothing

        If VaInt(IdCultivo) > 0 Then


            Dim sql As String = "SELECT DISTINCT AEL_IdGenero as IdGenero, RIGHT('00000' + CAST(AEL_IdGenero as varchar), 5) + ' - ' + RTRIM(GEN_NombreGenero) as Genero, CAST(VAR_Nombre as varchar) as Variedad" & vbCrLf
            sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
            sql = sql & " LEFT JOIN AlbEntrada ON AEN_Idalbaran = AEL_IdAlbaran " & vbCrLf
            sql = sql & " LEFT JOIN Generos ON AEL_IdGenero = GEN_IdGenero" & vbCrLf
            sql = sql & " LEFT JOIN TecnicosNet.dbo.Cultivos ON AEL_IdCultivo = CUL_IdCultivo" & vbCrLf
            sql = sql & " LEFT JOIN TecnicosNet.dbo.Variedades ON VAR_IdVariedad = CUL_IdVariedad" & vbCrLf
            sql = sql & " WHERE AEN_IdAgricultor = " & IdAgricultor & vbCrLf
            sql = sql & " AND AEL_IdCultivo = " & IdCultivo & vbCrLf

            Dim dt As DataTable = Agricultores.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                For Each row As DataRow In dt.Rows

                    row("Genero") = (row("Genero").ToString & "").Trim & " - " & (row("Variedad").ToString & "").Trim

                Next
            End If

            CbGenero.DataSource = dt
            CbGenero.DisplayMember = "Genero"
            CbGenero.ValueMember = "IdGenero"


            If CbGenero.Items.Count = 1 Then
                CbGenero.SelectedIndex = 0
            Else
                CbGenero.SelectedIndex = -1
            End If



        End If


    End Sub


    Private Sub CbCultivo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbCultivo.KeyDown

        If e.KeyCode = Keys.Enter Then

            If Not CbCultivo.MiError Then
                CbGenero.Select()
                CbGenero.Focus()
            End If

        End If


    End Sub

    Private Sub CbGenero_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbGenero.KeyDown

        If e.KeyCode = Keys.Enter Then

            BConsultar.Select()
            BConsultar.Focus()

        End If

    End Sub



    Private Sub CbCultivo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbCultivo.SelectedIndexChanged

        'Actualiza datos genero
        If CbCultivo.SelectedIndex >= 0 Then

            If Not TypeOf CbCultivo.SelectedValue Is System.Data.DataRowView Then

                Dim cultivo As String = CbCultivo.SelectedValue & ""
                If cultivo.Length >= 2 Then

                    'Dim Campa As Integer = VaInt(cultivo.Substring(0, 2))
                    Dim IdCultivo As Integer = VaInt(cultivo.Substring(2, cultivo.Length - 2))

                    CargaGenero(TxAgricultor.Text, IdCultivo.ToString)

                End If

            End If

        End If

    End Sub


    Protected Overrides Sub RowCellStyle(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn, sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        MyBase.RowCellStyle(row, column, sender, e)

        If e.Column.FieldName.ToUpper.Trim = "PARTIDA" Then
            e.Appearance.BackColor = Color.Azure
        End If

    End Sub


    Public Overrides Sub GridDoubleClick(sender As Object, e As System.EventArgs)
        MyBase.GridDoubleClick(sender, e)

        If GridView1.FocusedColumn.FieldName.ToUpper.Trim = "PARTIDA" Then
            If Not IsNothing(GridView1.GetFocusedDataRow()) Then

                Dim row As DataRow = GridView1.GetFocusedDataRow()
                Dim IdLinea As String = (row("IdLinea").ToString & "").Trim

                Dim frm As New FrmDetalleMuestreoPartida(IdLinea)
                frm.ShowDialog()

            End If
        End If

    End Sub


    Private Sub btHistorico_Click(sender As System.Object, e As System.EventArgs) Handles btHistorico.Click

        btHistorico.Enabled = False


        ConsultarHistorico()

    End Sub


    Private Sub ConsultarHistorico()
        MyBase.Consultar()


        If VaInt(TxAgricultor.Text) = 0 Then
            MsgBox("Debe introducir un agricultor válido")
            Exit Sub
        End If


        GridView1.Columns.Clear()


        Dim CampaCultivo As String = ""
        Dim IdCultivo As String = ""

        If Not TypeOf CbCultivo.SelectedValue Is System.Data.DataRowView Then

            Dim cultivo As String = CbCultivo.SelectedValue & ""
            If cultivo.Length >= 2 Then

                CampaCultivo = VaInt(cultivo.Substring(0, 2)).ToString
                IdCultivo = VaInt(cultivo.Substring(2, cultivo.Length - 2)).ToString

                If VaInt(CampaCultivo) = 0 Then CampaCultivo = ""
                If VaInt(IdCultivo) = 0 Then IdCultivo = ""

            Else
                MsgBox("Debe introducir un cultivo")
                Exit Sub
            End If
        End If

        If CampaCultivo = "" Or IdCultivo = "" Then
            MsgBox("Debe introducir un cultivo")
            Exit Sub
        End If


        Dim IdGenero As String = VaInt(CbGenero.SelectedValue)





        Dim dt As DataTable = Agro_HistorialCultivo(IdCultivo, IdGenero)
        Grid.DataSource = dt



        AjustaColumnas()

        AñadeResumenCampo("Cantidad", "{0:n4}")
        AñadeResumenCampo("Importe", "{0:n2}")

    End Sub


    Private Sub TxCultivo_Valida(edicion As System.Boolean) Handles TxCultivo.Valida

        If edicion Then

            LbCampaCultivo.Text = ""
            LbNomCultivo.Text = ""


            If Not TxCultivo.MiError And VaInt(TxCultivo.Text) > 0 Then

                Dim Cultivo As New E_Cultivos(Idusuario, cnFincasNET)
                If Cultivo.LeerId(TxCultivo.Text) Then

                    Dim Genero As String = ""
                    Dim Variedad As String = ""
                    Dim IdPrograma As String = ""
                    Dim Controlado As String = ""
                    Dim TipoCultivo As String = ""
                    Dim Nave As String = ""
                    Dim Campa As String = ""
                    Dim CalidadEntradas As String = ""

                    Dim bCultivoEncontrado As Boolean = DatosCultivo(TxCultivo.Text, Genero, Variedad, IdPrograma, Controlado, TipoCultivo, Nave, Campa, CalidadEntradas)


                    'Campaña cultivo
                    LbCampaCultivo.Text = Campa

                    'Nombre cultivo
                    LbNomCultivo.Text = Genero & " - " & Variedad



                    'Carga los datos del histórico
                    ConsultarHistoricoPorCultivo(TxCultivo.Text)


                Else
                    MsgBox("No se encuentra el cultivo")
                End If

            End If
        End If

    End Sub


    Private Sub ConsultarHistoricoPorCultivo(IdCultivo As String)
        MyBase.Consultar()


        GridView1.Columns.Clear()


        Dim dt As DataTable = Agro_HistorialCultivo(IdCultivo, "")
        Grid.DataSource = dt



        AjustaColumnas()

        AñadeResumenCampo("Cantidad", "{0:n4}")
        AñadeResumenCampo("Importe", "{0:n2}")

    End Sub

   

End Class