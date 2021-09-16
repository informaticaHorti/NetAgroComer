Public Class FrmBalanceMasas
    Inherits FrConsulta


    Private Class stClaves_BalanceMasas

        Public IdFamilia As Integer = 0
        Public Familia As String = ""
        Public IdGenero As String = 0
        Public Genero As String = ""

        Public Sub New(IdFamilia As Integer, Familia As String, IdGenero As Integer, Genero As String)
            Me.IdFamilia = IdFamilia
            Me.Familia = Familia
            Me.IdGenero = IdGenero
            Me.Genero = Genero
        End Sub

    End Class


    Public Class stDatos_BalanceMasas

        Public EntContBruto As Decimal = 0
        Public EntContDestrio As Decimal = 0
        Public EntContNeto As Decimal = 0
        Public EntNoContBruto As Decimal = 0
        Public EntNoContDestrio As Decimal = 0
        Public EntNoContNeto As Decimal = 0
        Public EntTotalBruto As Decimal = 0
        Public EntTotalDestrio As Decimal = 0
        Public EntTotalNeto As Decimal = 0
        Public SalCont As Decimal = 0
        Public SalNoCont As Decimal = 0
        Public SalTotal As Decimal = 0

        Public Sub New(EntContBruto As Decimal, EntContDestrio As Decimal, EntContNeto As Decimal,
                       EntNoContBruto As Decimal, EntNoContDestrio As Decimal, EntNoContNeto As Decimal,
                       EntTotalBruto As Decimal, EntTotalDestrio As Decimal, EntTotalNeto As Decimal,
                       SalCont As Decimal, SalNoCont As Decimal, SalTotal As Decimal)

            Me.EntContBruto = EntContBruto
            Me.EntContDestrio = EntContDestrio
            Me.EntContNeto = EntContNeto
            Me.EntNoContBruto = EntNoContBruto
            Me.EntNoContDestrio = EntNoContDestrio
            Me.EntNoContNeto = EntNoContNeto
            Me.EntTotalBruto = EntTotalBruto
            Me.EntTotalDestrio = EntTotalDestrio
            Me.EntTotalNeto = EntTotalNeto
            Me.SalCont = SalCont
            Me.SalNoCont = SalNoCont
            Me.SalTotal = SalTotal

        End Sub

    End Class


    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim GenerosCompuestos As New E_GenerosCompuestos(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDesdeFecha, Nothing, LbDesdeFecha, False, Cdatos.TiposCampo.Fecha)
        ParamTx(TxHastaFecha, Nothing, LbHastaFecha, False, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDesdeGenero, Generos.GEN_IdGenero, LbDesdeGenero)
        ParamTx(TxHastaGenero, Generos.GEN_IdGenero, LbHastaGenero)

        AsociarControles(TxDesdeGenero, BtBuscaGeneroDesde, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomGeneroDesde)
        AsociarControles(TxHastaGenero, BtBuscaGeneroHasta, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomGeneroHasta)

        cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)

    End Sub


    Private Sub FrmBalanceMasas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        EntContBruto.OwnerBand = bandEntradasControladoBruto
        EntContDestrio.OwnerBand = bandEntradasControladoDestrio
        EntContNeto.OwnerBand = bandEntradasControladoNeto
        EntNoContBruto.OwnerBand = bandEntradasNoControladoBruto
        EntNoContDestrio.OwnerBand = bandEntradasNoControladoDestrio
        EntNoContNeto.OwnerBand = bandEntradasNoControladoNeto
        EntTotalBruto.OwnerBand = bandEntradasTotalBruto
        EntTotalDestrio.OwnerBand = bandEntradasTotalDestrio
        EntTotalNeto.OwnerBand = bandEntadasTotalNeto
        SalCont.OwnerBand = bandSalidasControlado
        SalNoCont.OwnerBand = bandSalidasNoControlado
        SalTotal.OwnerBand = bandSalidasTotal

        IdGenero.OwnerBand = bandIdGenero
        Genero.OwnerBand = bandGenero
        IdFamilia.OwnerBand = bandIdFamilia
        Familia.OwnerBand = bandFamilia


        bandEntradasControladoBruto.Columns.Add(EntContBruto)
        bandEntradasControladoDestrio.Columns.Add(EntContDestrio)
        bandEntradasControladoNeto.Columns.Add(EntContNeto)
        bandEntradasNoControladoBruto.Columns.Add(EntNoContBruto)
        bandEntradasNoControladoDestrio.Columns.Add(EntNoContDestrio)
        bandEntradasNoControladoNeto.Columns.Add(EntNoContNeto)
        bandEntradasTotalBruto.Columns.Add(EntTotalBruto)
        bandEntradasTotalDestrio.Columns.Add(EntTotalDestrio)
        bandEntadasTotalNeto.Columns.Add(EntTotalNeto)
        bandSalidasControlado.Columns.Add(SalCont)
        bandSalidasNoControlado.Columns.Add(SalNoCont)
        bandSalidasTotal.Columns.Add(SalTotal)

        bandIdFamilia.Columns.Add(IdFamilia)
        bandFamilia.Columns.Add(Familia)
        bandIdGenero.Columns.Add(IdGenero)
        bandGenero.Columns.Add(Genero)
        
        GridViewBalanceMasas.OptionsView.ShowColumnHeaders = False

        Dim f As Font = GridViewBalanceMasas.Appearance.GroupRow.Font
        GridViewBalanceMasas.Appearance.GroupRow.Font = New Font(f.FontFamily, f.Size, FontStyle.Bold)
        GridViewBalanceMasas.OptionsView.ShowGroupPanel = False

        BInforme.Visible = False

        PlantillaConsulta1.Visible = False


        Dim documento As DevExpress.XtraPrinting.PrintableComponentLink = CType(prtSystem.Links(0), DevExpress.XtraPrinting.PrintableComponentLink)
        documento.Component = GridBalanceMasas


    End Sub


    Public Overrides Sub Consultar()

        MyBase.Consultar()


        If VaDate(TxDesdeFecha.Text) = VaDate("") Or VaDate(TxHastaFecha.Text) = VaDate("") Then
            MsgBox("Debe introducir fechas correctas")
            Exit Sub
        End If


        Dim acum As New Acumulador


        CargaEntradas(acum)
        CargaSalidas(acum)

        


        Dim dt As DataTable = acum.DataTable

        Grid.DataSource = dt
        GridBalanceMasas.DataSource = dt



        AjustaColumnas()
        GridViewBalanceMasas.ExpandAllGroups()


        'OJO con las mayúsculas / minúsculas
        Funciones.AñadeResumenCampo(GridViewBalanceMasas, "EntContBruto", "{0:n0}")
        Funciones.AñadeResumenCampo(GridViewBalanceMasas, "EntContDestrio", "{0:n0}")
        Funciones.AñadeResumenCampo(GridViewBalanceMasas, "EntContNeto", "{0:n0}")

        Funciones.AñadeResumenCampo(GridViewBalanceMasas, "EntNoContBruto", "{0:n0}")
        Funciones.AñadeResumenCampo(GridViewBalanceMasas, "EntNoContDestrio", "{0:n0}")
        Funciones.AñadeResumenCampo(GridViewBalanceMasas, "EntNoContNeto", "{0:n0}")

        Funciones.AñadeResumenCampo(GridViewBalanceMasas, "EntTotalBruto", "{0:n0}")
        Funciones.AñadeResumenCampo(GridViewBalanceMasas, "EntTotalDestrio", "{0:n0}")
        Funciones.AñadeResumenCampo(GridViewBalanceMasas, "EntTotalNeto", "{0:n0}")

        Funciones.AñadeResumenCampo(GridViewBalanceMasas, "SalCont", "{0:n0}")
        Funciones.AñadeResumenCampo(GridViewBalanceMasas, "SalNoCont", "{0:n0}")
        Funciones.AñadeResumenCampo(GridViewBalanceMasas, "SalTotal", "{0:n0}")




    End Sub


    Private Sub CargaEntradas(ByRef acum As Acumulador)


        'Entradas
        Dim sql As String = "SELECT IdFamilia, Familia, " & vbCrLf
        sql = sql & " IdGenero, Genero, Controlado, SUM(Bruto) as Bruto, SUM(Destrio) as Destrio" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT SFA_IdFamilia as IdFamilia, FAG_Nombre as Familia, AEL_IdGenero as IdGenero, GEN_NombreGenero as Genero, AEL_Controlado as Controlado, " & vbCrLf
        'sql = sql & " COALESCE(AEL_Kilosnetos,0) as Bruto," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN AEL_kilosnetos ELSE" & vbCrLf
        sql = sql & " (SELECT SUM(ALC_KilosNetos) FROM AlbEntrada_LineasCla WHERE ALC_IdLineaEntrada = AEL_IdLinea ) END as Bruto," & vbCrLf
        sql = sql & " COALESCE((SELECT SUM(ALC_KilosNetos) FROM AlbEntrada_LineasCla LEFT JOIN CategoriasEntrada ON ALC_IdCategoria = CAE_Id LEFT JOIN tiposdecategorias ON CAE_IdTipoCategoria = TCA_Id WHERE TCA_Tipo = 'D' AND ALC_idlineaentrada = AEL_IdLinea),0) as Destrio" & vbCrLf
        sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEN_IdAlbaran = AEL_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = AEL_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN SubFamilias ON GEN_idsubfamilia = SFA_Id" & vbCrLf
        sql = sql & " LEFT JOIN FamiliasGeneros ON FAG_idfamilia = SFA_IdFamilia" & vbCrLf
        sql = sql & " WHERE AEN_Fecha >= '" & TxDesdeFecha.Text & "'" & vbCrLf
        sql = sql & " AND AEN_Fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf
        sql = sql & CadenaWhereLista(AlbEntrada.AEN_IdPuntoVenta, ListadeCombo(cbPuntoVenta), " AND ") & vbCrLf
        If TxDesdeGenero.Text.Trim <> "" Then sql = sql & " AND AEL_IdGenero >= " & TxDesdeGenero.Text & vbCrLf
        If TxHastaGenero.Text.Trim <> "" Then sql = sql & " AND AEL_IdGenero <= " & TxHastaGenero.Text & vbCrLf
        sql = sql & " ) as B" & vbCrLf
        sql = sql & " GROUP BY IdFamilia, Familia, IdGenero, Genero, Controlado" & vbCrLf
        sql = sql & " ORDER BY IdFamilia, IdGenero" & vbCrLf



        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows

                Dim IdFamilia As Integer = VaInt(row("IdFamilia"))
                Dim Familia As String = (row("Familia").ToString & "").Trim

                Dim IdGeneroPrincipal As Integer = VaInt(row("IdGenero"))
                Dim GeneroPrincipal As String = (row("Genero").ToString & "").Trim
                Dim Controlado As String = (row("Controlado").ToString & "").Trim
                If Controlado <> "S" Then Controlado = "N"


                Dim BrutoTotal As Decimal = VaDec(row("Bruto"))
                Dim DestrioTotal As Decimal = VaDec(row("Destrio"))
                Dim NetoTotal As Decimal = BrutoTotal - DestrioTotal

                Dim AcumBruto As Decimal = 0
                Dim AcumDestrio As Decimal = 0
                Dim AcumNeto As Decimal = 0


                Dim dtc As DataTable = GenerosCompuestos.Composicion(IdGeneroPrincipal, GeneroPrincipal, IdFamilia) ' descompongo el genero en porcentajes
                If Not IsNothing(dtc) Then
                    If dtc.Rows.Count > 0 Then

                        For indice As Integer = 0 To dtc.Rows.Count - 1

                            Dim rowc As DataRow = dtc.Rows(indice)


                            Dim IdGenero As Integer = VaInt(rowc("IdGenero"))
                            Dim Genero As String = VaInt(IdGenero).ToString("00000") + " " + (rowc("Genero").ToString & "").Trim
                            Dim porcentaje As Decimal = VaDec(rowc("Porcentaje"))
                            Familia = VaInt(IdFamilia).ToString("00") & " " & Familia


                            Dim Bruto As Decimal = 0
                            Dim Destrio As Decimal = 0

                            If indice < dtc.Rows.Count - 1 Then
                                Bruto = BrutoTotal * porcentaje / 100
                                Destrio = DestrioTotal * porcentaje / 100
                                AcumBruto = AcumBruto + Bruto
                                AcumDestrio = AcumDestrio + Destrio
                            Else
                                'Ultima fila
                                Bruto = BrutoTotal - AcumBruto
                                Destrio = DestrioTotal - AcumDestrio
                            End If


                            Dim EntContBruto As Decimal = 0
                            Dim EntContDestrio As Decimal = 0
                            Dim EntNoContBruto As Decimal = 0
                            Dim EntNoContDestrio As Decimal = 0


                            If Controlado = "S" Then
                                EntContBruto = Bruto
                                EntContDestrio = Destrio
                            Else
                                EntNoContBruto = Bruto
                                EntNoContDestrio = Destrio
                            End If

                            Dim EntContNeto As Decimal = EntContBruto - EntContDestrio
                            Dim EntNoContNeto As Decimal = EntNoContBruto - EntNoContDestrio
                            Dim EntTotalBruto As Decimal = EntContBruto + EntNoContBruto
                            Dim EntTotalDestrio As Decimal = EntContDestrio + EntNoContDestrio
                            Dim EntTotalNeto As Decimal = EntTotalBruto - EntTotalDestrio



                            Dim stClaves As New stClaves_BalanceMasas(IdFamilia, Familia, IdGenero, Genero)
                            Dim stDatos As New stDatos_BalanceMasas(EntContBruto, EntContDestrio, EntContNeto, EntNoContBruto, EntNoContDestrio, EntNoContNeto,
                                                                    EntTotalBruto, EntTotalDestrio, EntTotalNeto, 0, 0, 0)
                            acum.Suma(stClaves, stDatos)

                        Next

                    End If
                End If



            Next
        End If


    End Sub


    Private Sub CargaSalidas(ByRef acum As Acumulador)

        Dim Palet As New E_palets(Idusuario, cn)
        'Entradas
        Dim sql As String = "SELECT IdFamilia, Familia, IdGenero, Genero, Controlado, SUM(Kilos) as Kilos" & vbCrLf
        sql = sql & " FROM ("
        sql = sql & " SELECT SFA_IdFamilia as IdFamilia, FAG_Nombre as Familia, PLL_IdGenero as IdGenero, GEN_NombreGenero as Genero, "
        sql = sql & " PLL_Controlado as Controlado, PLL_kilosCliente as Kilos"
        sql = sql & " FROM Palets_Lineas"
        sql = sql & " LEFT JOIN Palets ON PAL_IdPalet = PLL_IdPalet"
        sql = sql & " LEFT JOIN CategoriasSalida ON CAS_id = PLL_idcategoria "
        sql = sql & " LEFT JOIN TiposDeCategorias on TCA_Id = CAS_IdTipoCategoria"
        sql = sql & " LEFT JOIN Generos ON PLL_IdGenero = GEN_IdGenero"
        sql = sql & " LEFT JOIN SubFamilias ON SFA_Id = GEN_idSubFamilia "
        sql = sql & " LEFT JOIN FamiliasGeneros ON FAG_IdFamilia = SFA_IdFamilia"
        sql = sql & " WHERE PAL_Fecha >= '" & TxDesdeFecha.Text & "'"
        sql = sql & " AND PAL_Fecha <= '" & TxHastaFecha.Text & "'"
        sql = sql & CadenaWhereLista(Palet.PAL_idpuntoventa, ListadeCombo(cbPuntoVenta), " AND ") & vbCrLf

        If TxDesdeGenero.Text.Trim <> "" Then sql = sql & " AND PLL_IdGenero >= " & TxDesdeGenero.Text
        If TxHastaGenero.Text.Trim <> "" Then sql = sql & " AND PLL_IdGenero <= " & TxHastaGenero.Text
        sql = sql & " ) as P"
        sql = sql & " GROUP BY IdFamilia, Familia, IdGenero, Genero, Controlado"
        sql = sql & " ORDER BY IdFamilia, IdGenero" & vbCrLf


        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows

                Dim IdFamilia As Integer = VaInt(row("IdFamilia"))
                Dim Familia As String = (row("Familia").ToString & "").Trim

                Dim IdGeneroPrincipal As Integer = VaInt(row("IdGenero"))
                Dim GeneroPrincipal As String = (row("Genero").ToString & "").Trim
                Dim Controlado As String = (row("Controlado").ToString & "").Trim
                If Controlado <> "S" Then Controlado = "N"


                Dim KilosTotales As Decimal = VaDec(row("Kilos"))

                Dim AcumKilos As Decimal = 0


                Dim dtc As DataTable = GenerosCompuestos.Composicion(IdGeneroPrincipal, GeneroPrincipal, IdFamilia) ' descompongo el genero en porcentajes
                If Not IsNothing(dtc) Then
                    If dtc.Rows.Count > 0 Then

                        For indice As Integer = 0 To dtc.Rows.Count - 1

                            Dim rowc As DataRow = dtc.Rows(indice)


                            Dim IdGenero As Integer = VaInt(rowc("IdGenero"))
                            Dim Genero As String = VaInt(IdGenero).ToString("00000") + " " + (rowc("Genero").ToString & "").Trim
                            Dim porcentaje As Decimal = VaDec(rowc("Porcentaje"))
                            Familia = VaInt(IdFamilia).ToString("00") & " " & Familia


                            Dim Kilos As Decimal = 0

                            If indice < dtc.Rows.Count - 1 Then
                                Kilos = KilosTotales * porcentaje / 100
                                AcumKilos = AcumKilos + Kilos
                            Else
                                'Ultima fila
                                Kilos = KilosTotales - AcumKilos
                            End If


                            Dim SalCont As Decimal = 0
                            Dim SalNoCont As Decimal = 0


                            If Controlado = "S" Then
                                SalCont = Kilos
                            Else
                                SalNoCont = Kilos
                            End If

                            Dim SalTotal As Decimal = SalCont + SalNoCont


                            Dim stClaves As New stClaves_BalanceMasas(IdFamilia, Familia, IdGenero, Genero)
                            Dim stDatos As New stDatos_BalanceMasas(0, 0, 0, 0, 0, 0, 0, 0, 0, SalCont, SalNoCont, SalTotal)
                            acum.Suma(stClaves, stDatos)

                        Next

                    End If
                End If



            Next
        End If


    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewBalanceMasas.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "FAMILIA"
                    c.GroupIndex = 1
                Case "ENTCONTBRUTO", "ENTCONTDESTRIO", "ENTCONTNETO", "ENTNOCONTBRUTO", "ENTNOCONTDESTRIO", "ENTNOCONTNETO", "ENTTOTALBRUTO", "ENTTOTALDESTRIO", "ENTTOTALNETO", "SALCONT", "SALNOCONT", "SALTOTAL"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
            End Select
        Next

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()


        GridBalanceMasas.DataSource = Nothing


    End Sub


    Private Sub Fechaspordefecto()
        TxDesdeFecha.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxHastaFecha.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Private Sub GridViewBalanceMasas_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles GridViewBalanceMasas.KeyDown

        If e.KeyCode = Keys.F5 Or e.KeyCode = Keys.F12 Then
            Me.TeclaFuncion(e.KeyCode, GridView1)
            e.Handled = True
        End If

    End Sub


    Public Overrides Sub Imprimir()


        LineasDescripcion.Clear()


        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDesdeFecha.Text, TxHastaFecha.Text)
        Dim generos As String = FiltroDesdeHasta("Genero", TxDesdeGenero.Text, TxHastaGenero.Text)

        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If generos <> "" Then LineasDescripcion.Add(generos)



        MyBase.Imprimir()

    End Sub

End Class