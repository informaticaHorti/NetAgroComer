
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls


Public Class FrmMuestreoPartidas
    Inherits FrConsulta


    Private Agricultores As New E_Agricultores(Idusuario, cn)
    Private Generos As New E_Generos(Idusuario, cn)
    Private AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Private AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Private Produccion As New E_Produccion(Idusuario, cn)
    Private Lineas_Producto As New E_Lineas_producto(Idusuario, cn)


    Private ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)


    Dim err As New Errores

    Private _IdLinea As String = ""


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(IdLinea As String)
        Me.New()


        _IdLinea = IdLinea


    End Sub


    Private Sub ParametrosFrm()


        Dim lc As New List(Of Object)
        ListaControles = lc


        ParamTx(TxDesdeFecha, AlbEntrada.AEN_Fecha, LbDesdeFecha)
        ParamTx(TxHastaFecha, AlbEntrada.AEN_Fecha, LbHastaFecha)
        ParamTx(TxDesdeAgricultor, Agricultores.AGR_IdAgricultor, LbDeAgr)
        ParamTx(TxHastaAgricultor, Agricultores.AGR_IdAgricultor, LbHastaAgr)


        AsociarControles(TxDesdeAgricultor, BtBuscaDesdeAgricultor, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNom_DesdeAgricultor)
        AsociarControles(TxHastaAgricultor, BtBuscaHastaAgricultor, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNom_HastaAgricultor)



        Dim sql As String = "SELECT GEN_IdGenero as Id, GEN_NombreGenero as Nombre FROM Generos"
        Dim dt As DataTable = cn.ConsultaSQL(sql)

        CbGeneros.Properties.DataSource = dt
        CbGeneros.Properties.ValueMember = "Id"
        CbGeneros.Properties.DisplayMember = "Nombre"

        CbPventa = ComboPuntoventa(CbPventa, MiMaletin.IdPuntoVenta)
    End Sub


    Private Sub FrmConsultaEntradas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False

        BtAux.Text = "Clasificar"
        BtAux.Image = NetAgro.My.Resources.Resources.App_klines_game_16x16_32
        BtAux.Visible = True




        If VaInt(_IdLinea) > 0 Then

            Dim sql As String = "SELECT DISTINCT COALESCE(GEN_IdGenero,0) as IdGenero FROM Lineas_Producto" & vbCrLf
            sql = sql & " LEFT JOIN Generos ON GEN_IdSubFamilia = LNP_IdSubFamilia" & vbCrLf
            sql = sql & " WHERE LNP_IdLinea = " & _IdLinea & vbCrLf


            Dim dt As DataTable = Lineas_Producto.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                dt.PrimaryKey = New DataColumn() {dt.Columns("IdGenero")}

                For Each it As CheckedListBoxItem In CbGeneros.Properties.GetItems()

                    Dim IdGenero As String = it.Value.ToString & ""
                    Dim row As DataRow = dt.Rows.Find(VaInt(IdGenero))

                    If Not IsNothing(row) Then
                        it.CheckState = CheckState.Checked
                    End If

                Next

            End If

        End If


        _IdLinea = ""



        '    BConsultar.PerformClick()


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()


    End Sub


    Private Sub Fechaspordefecto()
        TxDesdeFecha.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxHastaFecha.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()



        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idlinea, "IdLinea")
        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_muestreo, "Partida")
        CONSULTA.SelCampo(AlbEntrada.AEN_IdPuntoVenta, "Pv")
        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_fechamuestreo, "FechaMuestreo")
        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idalbaran, "IdAlbaran")
        CONSULTA.SelCampo(AlbEntrada.AEN_IdAgricultor, "IdAgricultor", AlbEntrada_Lineas.AEL_idalbaran, AlbEntrada.AEN_IdAlbaran)
        CONSULTA.SelCampo(Agricultores.AGR_Nombre, "Agricultor", AlbEntrada.AEN_IdAgricultor, Agricultores.AGR_IdAgricultor)
        CONSULTA.SelCampo(AlbEntrada.AEN_Fecha, "Fecha")
        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idgenero, "IdGenero")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbEntrada_Lineas.AEL_idgenero, Generos.GEN_IdGenero)
        CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_kilosnetos, "Kilos")
        Dim oEstado As New Cdatos.bdcampo("@''", Cdatos.TiposCampo.Cadena, 25)
        CONSULTA.SelCampo(oEstado, "Estado")
        CONSULTA.WheCampo(AlbEntrada.AEN_EntradaConfeccionada, "<>", "S")
        If TxDesdeFecha.Text.Trim <> "" Then CONSULTA.WheCampo(AlbEntrada.AEN_Fecha, ">=", TxDesdeFecha.Text)
        If TxHastaFecha.Text.Trim <> "" Then CONSULTA.WheCampo(AlbEntrada.AEN_Fecha, "<=", TxHastaFecha.Text)
        If TxDesdeAgricultor.Text.Trim <> "" Then CONSULTA.WheCampo(AlbEntrada.AEN_IdAgricultor, ">=", TxDesdeAgricultor.Text)
        If TxHastaAgricultor.Text.Trim <> "" Then CONSULTA.WheCampo(AlbEntrada.AEN_IdAgricultor, "<=", TxHastaAgricultor.Text)


        Dim sql As String = CONSULTA.SQL & vbCrLf
        If CONSULTA.Whe.Trim = "" Then
            sql = sql & " WHERE COALESCE(AEL_FechaMuestreo, '" & VaDate("").ToString("dd/MM/yyyy") & "') = '" & VaDate("").ToString("dd/MM/yyyy") & "'" & vbCrLf
        Else
            sql = sql & " AND COALESCE(AEL_FechaMuestreo, '" & VaDate("").ToString("dd/MM/yyyy") & "') = '" & VaDate("").ToString("dd/MM/yyyy") & "'" & vbCrLf
        End If
        sql = sql & CadenaWhereLista(AlbEntrada_Lineas.AEL_idgenero, ListadeCombo(CbGeneros), " AND ") & vbCrLf
        sql = sql & CadenaWhereLista(AlbEntrada.AEN_IdPuntoVenta, ListadeCombo(CbPventa), " AND ")

        sql = sql & " ORDER BY AEN_Fecha, AEL_IdLinea"


       
        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
        dt.Columns.Add("Clasificados", GetType(Decimal)).SetOrdinal(9)
        dt.Columns.Add("Porcentaje", GetType(Decimal)).SetOrdinal(10)
       

        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows

                Dim IdLinea As String = (row("IdLinea").ToString & "").Trim
                Dim Kilos As Decimal = VaDec(row("Kilos"))
                Dim Clasificados As Decimal = ObtenerClasificados(IdLinea)
                row("Clasificados") = Clasificados

                Dim Porcentaje As Decimal = 0
                If Kilos <> 0 Then Porcentaje = Clasificados / Kilos * 100
                row("Porcentaje") = Porcentaje

            Next
        End If


        Grid.DataSource = dt


        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Kilos", "{0:n2}")
        AñadeResumenCampo("Clasificados", "{0:n2}")


        AjustaColumnas()


    End Sub


    Private Function ObtenerClasificados(IdLinea As String) As Decimal

        Dim Clasificados As Decimal = 0


        Dim dt As DataTable = AgClasifiPartida(IdLinea)
        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows
                Dim Kilos As Decimal = VaDec(row("Kilos"))
                Clasificados = Clasificados + Kilos
            Next

        End If




        Return Clasificados

    End Function


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "PARTIDA", "FECHA", "IDAGRICULTOR", "AGRICULTOR", "IDGENERO", "GENERO", "KILOS", "ESTADO", "CLASIFICADOS", "PORCENTAJE", "PV"
                    c.Visible = True
                Case Else
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDAGRICULTOR"
                    c.Caption = "CodAgr"
                    c.MinWidth = 50
                    c.MaxWidth = 50
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"

                Case "IDGENERO"
                    c.Caption = "CodGen"
                    c.MinWidth = 50
                    c.MaxWidth = 50
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"

                Case "ESTADO"
                    c.Width = 100

                Case "KILOS",
                    c.Caption = "KilosEnt"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 80

                Case "CLASIFICADOS"
                    c.Caption = "KgClasif"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 80

                Case "FECHA"
                    c.MinWidth = 80

                Case "PORCENTAJE"
                    c.Caption = "%"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.MinWidth = 45
                    c.MaxWidth = 45

            End Select

        Next


    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()


        Dim Generos As String = ""

        Dim lstGeneros As List(Of String) = ListadeCombo(CbGeneros)
        For Each s As String In lstGeneros
            If Generos <> "" Then Generos = Generos & ","
            Generos = Generos & s
        Next


        'Agricultor, fecha
        If TxDesdeFecha.Text.Trim <> "" Or TxHastaFecha.Text.Trim <> "" Then LineasDescripcion.Add("Desde " & TxDesdeFecha.Text & " hasta " & TxHastaFecha.Text)
        If TxDesdeAgricultor.Text.Trim <> "" Or TxHastaAgricultor.Text.Trim <> "" Then LineasDescripcion.Add("Desde agricultor " & TxDesdeAgricultor.Text & " hasta agricultor " & TxHastaAgricultor.Text)
        If lstGeneros.Count > 0 Then LineasDescripcion.Add("Generos: " & Generos)


        MyBase.Imprimir()

    End Sub


    Public Overrides Sub CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs)
        MyBase.CustomColumnDisplayText(sender, e)

        Dim row As DataRow = GridView1.GetDataRow(e.RowHandle)
        If Not IsNothing(row) Then



            If e.Column.FieldName.ToUpper.Trim = "ESTADO" Then

                Dim Porcentaje As Decimal = VaDec(row("Porcentaje"))


                If Porcentaje = 0 Then

                    'Sin confeccionar
                    e.DisplayText = "SIN CONFECCIONAR"

                ElseIf Porcentaje > 90 Then

                    'consumida
                    e.DisplayText = "CONSUMIDA"

                Else

                    'en curso
                    e.DisplayText = "MANIPULADA"

                End If

            End If


        End If

    End Sub


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()

        Dim row As DataRow = GridView1.GetFocusedDataRow()
        If Not IsNothing(row) Then

            Dim IdLinea As String = (row("IdLinea").ToString & "").Trim
            Dim FechaMuestreo As String = "" : If VaDate(row("FechaMuestreo")) > VaDate("") Then FechaMuestreo = VaDate(row("FechaMuestreo")).ToString("dd/MM/yyyy")


            If Not CompruebaBloqueoClasificacion(IdLinea) Then
                MsgBox("Clasificación bloqueada")
                Exit Sub
            End If



            If VaInt(IdLinea) > 0 Then

                If FechaMuestreo <> "" Then
                    MsgBox("La partida ya ha sido clasificada")
                    Exit Sub
                End If

                Dim frm As New FrmClasificacionPartidas(IdLinea)
                frm.ShowDialog()

                If frm.Resultado = ResultadoFormulario.Guardar Then
                    BConsultar.PerformClick()
                End If

            End If

        End If

    End Sub

   

    Private Function CompruebaBloqueoClasificacion(IdLinea As String)

        Dim bRes As Boolean = True


        Dim sql As String = "SELECT AEL_FechaMuestreo as FechaMuestreo, AEN_Fecha as Fecha FROM AlbEntrada_Lineas LEFT JOIN AlbEntrada ON AEN_IdAlbaran = AEL_IdALbaran WHERE AEL_IdLinea = " & IdLinea
        Dim dt As DataTable = AlbEntrada_Lineas.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim row As DataRow = dt.Rows(0)
                If VaDate(row("FechaMuestreo")) > VaDate("") Then

                    Dim Fecha As String = (row("Fecha").ToString & "").Trim

                    Dim bloqueo As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.FECHA_BLOQUEO_CLASIFICACIONES)
                    If VaDate(Fecha) <= VaDate(bloqueo) Then
                        bRes = False
                    End If

                End If

            End If
        End If



        Return bRes

    End Function


    Protected Overrides Sub RowCellStyle(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn, sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        MyBase.RowCellStyle(row, column, sender, e)


        If Not IsNothing(row) Then

            If column.FieldName.ToUpper.Trim = "ESTADO" Then

                Dim Porcentaje As Decimal = VaDec(row("Porcentaje"))


                If Porcentaje = 0 Then

                    'Sin confeccionar
                    e.Appearance.BackColor = Color.Red

                ElseIf Porcentaje > 90 Then

                    'consumida
                    e.Appearance.BackColor = Color.LightGreen

                Else

                    'en curso
                    e.Appearance.BackColor = Color.Yellow

                End If

            End If


        End If

    End Sub


    

    
End Class