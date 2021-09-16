Imports DevExpress.XtraEditors.Controls

Public Class FrmGenerarFacturas
    Inherits FrConsulta




    Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
    Dim Agricultor As New E_Agricultores(Idusuario, cn)
    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim AlbEntrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
    Dim AlbEntrada_hislineas As New E_AlbEntrada_hislineas(Idusuario, cn)
    Dim Partes As New E_Partes(Idusuario, cn)
    Dim Valoracion As New E_ValoracionSemanal(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))

    Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)
    Dim FacturaAgr_lineas As New E_FacturaAgr_lineas(Idusuario, cn)
    Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)

    Dim Empresas As New E_Empresas(Idusuario, cn)

    Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)


    Dim _idsemana As Integer = 0





    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxEjAlbaranes, Nothing, LbEjeAlbaranes, True, Cdatos.TiposCampo.EnteroPositivo, 0, 2)
        ParamTx(TxSemana, Nothing, LbSemana, True, Cdatos.TiposCampo.EnteroPositivo, 0, 3)
        ParamTx(TxDeFecha, Nothing, LbDFecha, True, Cdatos.TiposCampo.Fecha, True)
        ParamTx(TxaFecha, Nothing, LbAFecha, True, Cdatos.TiposCampo.Fecha, True)

        ParamTx(TxAnnoFondo, Nothing, LbAnoFondo, , Cdatos.TiposCampo.Cadena, , 4, "0123456789")

        ParamTx(TxDAgricultor, Nothing, LbdAgricultor, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxAAgricultor, Nothing, LbaAgricultor, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxEmpresa, Nothing, Lbempresa, True, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxCentro, Nothing, LbCentro, True, Cdatos.TiposCampo.EnteroPositivo, 0, 3)
        ParamTx(TxFecha, Nothing, LbFecha, True, Cdatos.TiposCampo.Fecha, 0, 10)
        ParamTx(TxFechaAsientoREA, Nothing, LbFechaAsientoREA, , Cdatos.TiposCampo.Fecha, 0, 10)
        ParamTx(TxEjercicioREA, Nothing, LbEjercicioREA, , Cdatos.TiposCampo.EnteroPositivo, 0, 2)





        ParamChk(ChkComision, Nothing, "S", "N")
        ParamChk(ChSc, Nothing, "S", "N")


        AsociarControles(TxSemana, BtBuscaSemana, SemanasPartes.btBusca, SemanasPartes)
        AsociarControles(TxDAgricultor, BtBuscaagr1, Agricultor.btBusca, Agricultor, Agricultor.AGR_Nombre, LbnomAgr1)
        AsociarControles(TxAAgricultor, BtBuscaAgr2, Agricultor.btBusca, Agricultor, Agricultor.AGR_Nombre, LbNomAgr2)
        AsociarControles(TxEmpresa, BtEmpresa, Empresas.btBusca, Empresas, Empresas.EMP_Nombre, LbNomEmpresa)
        AsociarControles(TxCentro, BtCentro, Centros.btBusca, Centros, Centros.Nombre, LbNomCentro)



    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        TxEjAlbaranes.Text = MiMaletin.Ejercicio.ToString
        TxAnnoFondo.Text = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.AÑO_POR_DEFECTO_FONDO_OPERATIVO)

    End Sub





    Private Sub FrmExtractoEnvasesPorMaterial_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        BInforme.Visible = False
        BtAux.Visible = True
        BtAux.Text = "Facturar"

        CbCentroRecogida = ComboCentrosRecogida(CbCentroRecogida)
        CbFamilias = ComboFamilias(CbFamilias)


        CbFamilias.CheckAll()
        CbCentroRecogida.CheckAll()

        '  GridView1.Appearance.GroupRow.Font = nueva_fuente


    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub



    Private Sub CargaGrid()


        Dim Generos As New E_Generos(Idusuario, cn)
        Dim SubFamilias As New E_Subfamilias(Idusuario, cn)
        Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
        Dim Agricultores As New E_Agricultores(Idusuario, cn)

        Dim DtGrid As New DataTable

        DtGrid.Columns.Add("Albaran", GetType(System.Int32))
        DtGrid.Columns.Add("Partida", GetType(System.Int32))
        DtGrid.Columns.Add("Fecha", GetType(System.DateTime))
        DtGrid.Columns.Add("Agricultor", GetType(System.String))
        DtGrid.Columns.Add("EsREA", GetType(String))
        DtGrid.Columns.Add("Genero", GetType(System.String))
        DtGrid.Columns.Add("Categoria", GetType(System.String))
        DtGrid.Columns.Add("Kilos", GetType(System.Int32))
        DtGrid.Columns.Add("Bultos", GetType(System.Int32))
        DtGrid.Columns.Add("Piezas", GetType(System.Int32))
        DtGrid.Columns.Add("Precio", GetType(System.Decimal))
        DtGrid.Columns.Add("TP", GetType(System.String))
        DtGrid.Columns.Add("Importe", GetType(System.Decimal))
        DtGrid.Columns.Add("idalbhis", GetType(System.Int32))
        DtGrid.Columns.Add("idagricultor", GetType(System.Int32))
        DtGrid.Columns.Add("idgenero", GetType(System.Int32))
        DtGrid.Columns.Add("idcategoria", GetType(System.Int32))
        DtGrid.Columns.Add("idpartida", GetType(System.Int32))
        DtGrid.Columns.Add("idgensal", GetType(System.Int32))


        Dim Consulta As New Cdatos.E_select

        Consulta.SelCampo(AlbEntrada_hislineas.AHL_idlineaentrada, "idpartida")
        Consulta.SelCampo(AlbEntrada_lineas.AEL_idalbaran, "idalbaran", AlbEntrada_hislineas.AHL_idlineaentrada)
        Consulta.SelCampo(AlbEntrada.AEN_Albaran, "Albaran", AlbEntrada_lineas.AEL_idalbaran)
        Consulta.SelCampo(AlbEntrada.AEN_TipoFCS, "FCS")
        Consulta.SelCampo(AlbEntrada.AEN_EntradaConfeccionada, "EsConfec")
        Consulta.SelCampo(AlbEntrada.AEN_Fecha, "Fecha")
        Consulta.SelCampo(AlbEntrada_lineas.AEL_muestreo, "Partida")
        Consulta.SelCampo(Albentrada_his.AEH_idproveedor, "idagricultor", AlbEntrada_hislineas.AHL_idalbhis)
        Consulta.SelCampo(Agricultor.AGR_Nombre, "Agricultor", Albentrada_his.AEH_idproveedor)
        Consulta.SelCampo(TipoAgricultor.TPA_tipofactura, "TipoFactura", Agricultores.AGR_IdTipo)
        Consulta.SelCampo(TipoAgricultor.TPA_compensa, "EsREA")
        Consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbEntrada_hislineas.AHL_idgenero)
        Consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", AlbEntrada_hislineas.AHL_idcategoria)
        Consulta.SelCampo(AlbEntrada_hislineas.AHL_kilos, "Kilos")
        Consulta.SelCampo(AlbEntrada_hislineas.AHL_bultos, "Bultos")
        Consulta.SelCampo(AlbEntrada_hislineas.AHL_piezas, "Piezas")
        Consulta.SelCampo(AlbEntrada_hislineas.AHL_precio, "Precio")
        Consulta.SelCampo(AlbEntrada_hislineas.AHL_tipoprecio, "TP")
        Consulta.SelCampo(AlbEntrada_hislineas.AHL_importegenero, "Importe")
        Consulta.SelCampo(AlbEntrada_lineas.AEL_fechamuestreo, "FechaMuestreo")
        Consulta.SelCampo(AlbEntrada_lineas.AEL_FechaValoracion, "FechaValoracion")
        Consulta.SelCampo(AlbEntrada_lineas.AEL_IdValoracion, "idvaloracion")
        Consulta.SelCampo(Albentrada_his.AEH_id, "idalbhis")
        Consulta.SelCampo(AlbEntrada_lineas.AEL_idgenero, "idgenero")
        Consulta.SelCampo(AlbEntrada_hislineas.AHL_idcategoria, "idcategoria")
        Consulta.SelCampo(SubFamilias.SFA_idfamilia, "idfamilia", Generos.GEN_IdsubFamilia)
        Consulta.SelCampo(AlbEntrada_lineas.AEL_idlinea, "idpartida")
        Consulta.SelCampo(AlbEntrada_lineas.AEL_idgensal, "idgensal")


        Consulta.WheCampo(Albentrada_his.AEH_idfactura, "=", "0")
        Consulta.WheCampo(Albentrada_his.AEH_idfacturafirme, "=", "0") ' por si acaso
        Consulta.WheCampo(AlbEntrada.AEN_IdCentro, "=", TxCentro.Text) ' FILTRAR POR CENTRO ECOPARCK

        'Juanjo 22/10/2015 ( no generar facturas para los agricultores que estén marcados como 'no facturar' en la ficha de agricultores ) 
        Consulta.WheCampo(Agricultor.AGR_NoFacturar, "<>", "S")
        Consulta.WheCampo(TipoAgricultor.TPA_tipofactura, "=", "1")

        If TxDeFecha.Text <> "" Then
            Consulta.WheCampo(AlbEntrada.AEN_Fecha, ">=", TxDeFecha.Text)
        End If

        If TxaFecha.Text <> "" Then
            Consulta.WheCampo(AlbEntrada.AEN_Fecha, "<=", TxaFecha.Text)
        End If
        If TxDAgricultor.Text <> "" Then
            Consulta.WheCampo(Albentrada_his.AEH_idproveedor, ">=", TxDAgricultor.Text)
        End If

        If TxAAgricultor.Text <> "" Then
            Consulta.WheCampo(Albentrada_his.AEH_idproveedor, "<=", TxAAgricultor.Text)
        End If


        Consulta.WheCampo(Albentrada_his.AEH_idempresa, "=", TxEmpresa.Text)

        'If ChFirme.CheckState = CheckState.Unchecked Then
        Consulta.WheCampo(AlbEntrada.AEN_TipoFCS, "<>", "F")
        'End If

        If ChSc.CheckState = CheckState.Unchecked Then
            Consulta.WheCampo(AlbEntrada.AEN_TipoFCS, "<>", "S")
        End If

        If ChkComision.CheckState = CheckState.Unchecked Then
            Consulta.WheCampo(AlbEntrada.AEN_TipoFCS, "<>", "C")
        End If






        Dim sql As String = Consulta.SQL + CadenaWhereLista(Agricultores.AGR_idcrecogida, ListadeCombo(CbCentroRecogida), " AND ")
        sql = sql & " ORDER BY AEH_idproveedor" & vbCrLf


        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)

        Dim DcNOAlba As New Dictionary(Of Integer, Integer) ' los albaranes que NO puedo facturar
        If Not dt Is Nothing Then

            For Each rw In dt.Rows

                'Dim idalbaran As Integer = VaInt(rw("idalbaran"))
                Dim IdAlbHis As Integer = VaInt(rw("IdAlbHis"))
                Dim fmuestreo As Date = rw("FechaMuestreo")
                Dim Fvalor As Date = rw("FechaValoracion")
                Dim Esconfec As String = rw("Esconfec").ToString
                Dim e As Boolean = True
                Select Case rw("FCS").ToString

                    Case "S", "C"
                        If fmuestreo <= VaDate("01/01/1900") Then
                            e = False
                        End If
                        If Fvalor <= VaDate("01/01/1900") Then
                            e = False
                        End If

                End Select

                Dim idfamilia As Integer = VaInt(rw("idfamilia"))
                If FiltroFamilia(idfamilia) = False Then
                    e = False
                End If


                Dim kilos As Decimal = VaDec(rw("kilos"))
                Dim importe As Decimal = VaDec(rw("importe"))
                'If kilos = 0 And importe = 0 Then
                '    e = False
                'End If

                If e = True Then

                    If kilos = 0 And importe = 0 Then

                        Dim KilosAlbHis As Decimal = 0
                        Dim ImporteAlbHis As Decimal = 0
                        ObtenerKilosImporteAlbaranHis(IdAlbHis, KilosAlbHis, ImporteAlbHis)
                        If KilosAlbHis = 0 And ImporteAlbHis = 0 Then
                            e = False
                        End If
                    End If

                End If


                If e = False Then
                    If DcNOAlba.ContainsKey(IdAlbHis) = False Then
                        DcNOAlba.Add(IdAlbHis, IdAlbHis)
                    End If
                End If

                If DcNOAlba.ContainsKey(IdAlbHis) = False Then
                    DtGrid.Rows.Add(VaInt(rw("Albaran")), VaInt(rw("partida")), rw("Fecha"), rw("Agricultor").ToString, rw("EsREA").ToString, rw("Genero").ToString, rw("Categoria").ToString, VaDec(rw("Kilos")), VaInt(rw("Bultos")), VaInt(rw("Piezas")), VaDec(rw("Precio")), rw("tp").ToString, VaDec(rw("Importe")), VaInt(rw("idalbhis")), VaInt(rw("idagricultor")), VaInt(rw("idgenero")), VaInt(rw("idcategoria")), VaInt(rw("idpartida")), VaInt(rw("idgensal")))
                End If
            Next
        End If

        Grid.DataSource = DtGrid
        AjustaColumnas()



    End Sub


    Private Sub ObtenerKilosImporteAlbaranHis(IdAlbHis As String, ByRef KilosAlbHis As Decimal, ByRef ImporteAlbHis As Decimal)

        KilosAlbHis = 0
        ImporteAlbHis = 0

        If VaDec(IdAlbHis) > 0 Then

            Dim sql As String = "SELECT SUM(AHL_Kilos) as Kilos, SUM(AHL_ImporteGenero) as Importe FROM AlbEntrada_HisLineas WHERE AHL_IdAlbHis = " & IdAlbHis
            Dim dt As DataTable = Albentrada_his.MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    KilosAlbHis = VaDec(dt.Rows(0)("Kilos"))
                    ImporteAlbHis = VaDec(dt.Rows(0)("Importe"))

                End If
            End If

        End If



    End Sub


    Private Function FiltroFamilia(idfamilia As Integer) As Boolean
        Dim ret As Boolean = False

        For Each it As CheckedListBoxItem In CbFamilias.Properties.GetItems()

            If it.Value = idfamilia And it.CheckState = CheckState.Checked Then
                ret = True
            End If

        Next

        Return ret


    End Function



    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDALBHIS", "IDGENERO", "IDCATEGORIA", "IDAGRICULTOR", "IDPARTIDA", "IDGENSAL", "ESREA"
                    c.Visible = False
            End Select
        Next



        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                
                Case "FECHA"
                    c.Width = 200
                Case "KILOS", "PIEZAS", "BULTOS"
                    c.Width = 200
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n0}"

                Case "IMPORTE"
                    c.Width = 200
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n2}"

                Case "PRECIO"
                    c.Width = 200
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n3}"
                Case "TP"
                    c.Width = 50
                Case "ALBARAN", "PARTIDA", "FECHA"
                    c.Width = 150
                Case "AGRICULTOR"
                    c.Width = 400

                Case "GENERO"
                    c.Width = 300

                Case "CATEGORIA"
                    c.Width = 200

                Case "ESCONFEC"
                    c.Caption = "EsDirecta"

            End Select

        Next

        AñadeResumenCampo("Kilos", "{0:n0}")
        AñadeResumenCampo("Importe", "{0:n2}")

    End Sub


    Private Sub BtAux_Click(sender As System.Object, e As System.EventArgs) Handles BtAux.Click

     
        'If Mid(TxDato3.Text, 7, 4) <> Mid(TxDato4.Text, 7, 4) Then
        '    MsgBox("Solo se pueden generar semanas dentro del mismo año. Revise las fechas")
        '    Exit Sub
        'End If


        If VaDate(TxFecha.Text) = VaDate("") Then
            MsgBox("Debe introducir un valor en el campo 'Fecha facturas'")
            Exit Sub
        End If

        If TxCentro.Text = "" Then
            MsgBox("Debe introducir un centro")
            Exit Sub
        End If

        If TxEmpresa.Text = "" Then
            MsgBox("Debe introducir una empresa")
            Exit Sub
        End If



        Dim DT As DataTable = Grid.DataSource
        Dim dv As New DataView(DT)
        dv.Sort = "Idagricultor, Fecha,Genero,Precio desc"
        DT = dv.ToTable





        If VaDate(TxFechaAsientoREA.Text) = VaDate("") Or TxEjercicioREA.Text.Trim = "" Then

            If Not IsNothing(dt) Then
                For Each row As DataRow In dt.Rows
                    Dim EsREA As String = (row("EsREA").ToString & "").Trim
                    If EsREA = "S" Then
                        MsgBox("Hay agricultores marcados como REA. Debe introducir una fecha de asiento REA y un EjercicioREA")
                        Exit Sub
                    End If
                Next
            End If

        End If





        If MsgBox("Desea facturar  ", vbYesNo) = vbNo Then Exit Sub
        Barra.Visible = True

        
        Dim DcAlba As New Dictionary(Of Integer, Integer)
        Barra.Maximum = DT.Rows.Count
        Barra.Value = 0
        
        Dim auxAgr As Integer = 0
        Dim lineafac As Integer = 0
        Dim idfactura As Integer = 0
        Dim Tgenero As Decimal = 0


        For Each RW In DT.Rows

            Dim idagricultor As Integer = VaInt(RW("idagricultor"))
            Dim idalbhis As Integer = VaInt(RW("idalbhis"))
            Dim Albaran As Integer = VaInt(RW("albaran"))
            Dim FechaAlb As String = RW("Fecha").ToString
            Dim idpartida As Integer = VaInt(RW("idpartida"))
            Dim idgenero As Integer = VaInt(RW("idgenero"))
            Dim idcategoria As Integer = VaInt(RW("idcategoria"))
            Dim Kilos As Decimal = VaDec(RW("kilos"))
            Dim Bultos As Integer = VaInt(RW("bultos"))
            Dim Precio As Decimal = VaDec(RW("precio"))
            Dim IGenero As Decimal = VaDec(RW("importe"))
            Dim IdGensal As Integer = VaInt(RW("idgensal"))
            Dim piezas As Integer = VaInt(RW("piezas"))
            Dim TipoPrecio As String = RW("TP").ToString
            Dim bEsREA As Boolean = ((RW("EsREA").ToString & "").Trim = "S")


            IGenero = Math.Round(IGenero, 2)
            If Barra.Value < Barra.Maximum Then
                Barra.Value = Barra.Value + 1
            End If

            If auxAgr <> idagricultor And auxAgr > 0 And lineafac > 0 Then
                GrabaFactura(idfactura, DcAlba, Tgenero)
                lineafac = 0
                idfactura = 0
                Tgenero = 0
                DcAlba.Clear()
            End If

            auxAgr = idagricultor


            If lineafac = 0 Then

                idfactura = FacturaAgr.MaxId
                FacturaAgr.VaciaEntidad()
                FacturaAgr.FGR_Idfactura.Valor = idfactura.ToString
                FacturaAgr.FGR_ejercicio.Valor = MiMaletin.Ejercicio.ToString
                FacturaAgr.FGR_fecha.Valor = TxFecha.Text
                FacturaAgr.FGR_Idagricultor.Valor = idagricultor.ToString
                FacturaAgr.FGR_IdagricultorALB.Valor = idagricultor.ToString
                FacturaAgr.FGR_Idsemana.Valor = _idsemana.ToString
                FacturaAgr.FGR_idempresa.Valor = TxEmpresa.Text
                FacturaAgr.FGR_idcentro.Valor = TxCentro.Text
                If bEsREA Then
                    FacturaAgr.FGR_FechaAsientoREA.Valor = TxFechaAsientoREA.Text
                    FacturaAgr.FGR_EjercicioREA.Valor = TxEjercicioREA.Text
                End If
                FacturaAgr.FGR_AnnoFondo.Valor = TxAnnoFondo.Text
                FacturaAgr.Insertar()

            End If


            lineafac = lineafac + 1

            Dim idlinea As Integer = FacturaAgr_lineas.MaxId
            FacturaAgr_lineas.VaciaEntidad()
            FacturaAgr_lineas.FAL_id.Valor = idlinea.ToString
            FacturaAgr_lineas.FAL_idfactura.Valor = idfactura

            FacturaAgr_lineas.FAL_idpartida.Valor = idpartida.ToString
            FacturaAgr_lineas.FAL_idgenero.Valor = idgenero.ToString
            FacturaAgr_lineas.FAL_idcategoria.Valor = idcategoria.ToString
            FacturaAgr_lineas.FAL_bultos.Valor = Bultos.ToString
            FacturaAgr_lineas.FAL_kilos.Valor = Kilos.ToString
            FacturaAgr_lineas.FAL_precio.Valor = Precio.ToString
            FacturaAgr_lineas.FAL_importe.Valor = IGenero
            FacturaAgr_lineas.FAL_IdGensal.Valor = IdGensal.ToString
            FacturaAgr_lineas.FAL_Piezas.Valor = piezas.ToString
            FacturaAgr_lineas.FAL_TipoPrecio.Valor = TipoPrecio
            FacturaAgr_lineas.Insertar()

            Tgenero = Tgenero + IGenero


            If DcAlba.ContainsKey(idalbhis) = False Then
                DcAlba.Add(idalbhis, idfactura)
            End If

        Next


        If lineafac > 0 Then
            GrabaFactura(idfactura, DcAlba, Tgenero)
        End If

        MsgBox("Finalizado")
        Grid.DataSource = Nothing


    End Sub


    Private Sub GrabaFactura(idfactura As Integer, dcalba As Dictionary(Of Integer, Integer), tgenero As Decimal)

        Dim serieagr As String = ""
        Dim serietipo As String = ""
        Dim porcomision As Decimal = 0
        Dim porfondo As Decimal = 0
        Dim porret As Decimal = 0
        Dim poriva As Decimal = 0
        Dim IdTipoIva As String = ""
        Dim tiporet As String = ""
        Dim Gastos As Decimal = 0
        Dim porcontingencia As Decimal = 0


        If FacturaAgr.LeerId(idfactura) = True Then

            If Agricultor.LeerId(FacturaAgr.FGR_Idagricultor.Valor) = True Then
                serieagr = Agricultor.AGR_serie.Valor
                If TipoAgricultor.LeerId(Agricultor.AGR_IdTipo.Valor) = True Then

                    serietipo = TipoAgricultor.TPA_seriecomer.Valor
                    porcomision = VaDec(TipoAgricultor.TPA_porcomision.Valor)
                    porfondo = VaDec(TipoAgricultor.TPA_porfondo.Valor)
                    porret = VaDec(TipoAgricultor.TPA_porret.Valor)
                    poriva = VaDec(TipoAgricultor.TPA_poriva.Valor)

                    IdTipoIva = TipoAgricultor.TPA_idtipoiva.Valor & ""

                    tiporet = TipoAgricultor.TPA_tiporet.Valor
                    For Each IDALBHIS In dcalba.Keys
                        Gastos = Gastos + GastosAlbaranes(IDALBHIS)
                    Next
                    porcontingencia = VaDec(TipoAgricultor.TPA_PorContingencia.Valor)

                End If
            End If

            Dim seriefac As String = ""
            If serieagr = "" Then
                seriefac = serietipo
            Else
                seriefac = serieagr
            End If

            Dim nfactura As Integer = FacturaAgr.MaxIdCampa(VaInt(FacturaAgr.FGR_idempresa.Valor), VaInt(FacturaAgr.FGR_ejercicio.Valor), seriefac)
            Gastos = Math.Round(Gastos, 2)
            Dim comision As Decimal = tgenero * porcomision / 100
            comision = Math.Round(comision, 2)
            Dim Base As Decimal = tgenero - comision - Gastos
            Dim CuotaIva As Decimal = Base * poriva / 100
            CuotaIva = Math.Round(CuotaIva, 2)
            Dim baseret As Decimal = 0
            If tiporet = "B" Then
                baseret = Base
            Else
                baseret = Base + CuotaIva
            End If

            Dim retencion As Decimal = baseret * porret / 100
            retencion = Math.Round(retencion, 2)

            Dim cuotafondo As Decimal = Base * porfondo / 100
            cuotafondo = Math.Round(cuotafondo, 2)

            'Dim cuotacontingencia As Decimal = Base * porcontingencia / 100
            Dim cuotacontingencia As Decimal = tgenero * porcontingencia / 100
            cuotacontingencia = Math.Round(cuotacontingencia, 2)

            FacturaAgr.FGR_serie.Valor = seriefac
            FacturaAgr.FGR_numerofactura.Valor = nfactura.ToString
            FacturaAgr.FGR_Igenero.Valor = tgenero.ToString
            FacturaAgr.FGR_BaseImponible.Valor = Base.ToString
            FacturaAgr.FGR_porcomision.Valor = porcomision.ToString
            FacturaAgr.FGR_comision.Valor = comision.ToString
            FacturaAgr.FGR_fondo.Valor = porfondo.ToString
            FacturaAgr.FGR_cuotafondo.Valor = cuotafondo.ToString
            FacturaAgr.FGR_IdTipoIva.Valor = IdTipoIva
            FacturaAgr.FGR_iva.Valor = poriva.ToString
            FacturaAgr.FGR_CuotaIva.Valor = CuotaIva.ToString
            FacturaAgr.FGR_Baseretencion.Valor = baseret.ToString
            FacturaAgr.FGR_tiporetencion.Valor = tiporet
            FacturaAgr.FGR_retencion.Valor = porret.ToString
            FacturaAgr.FGR_cuotaretencion.Valor = retencion.ToString
            FacturaAgr.FGR_otrosgastos.Valor = Gastos.ToString
            FacturaAgr.FGR_PorContingencia.Valor = porcontingencia
            FacturaAgr.FGR_CuotaContingencia.Valor = cuotacontingencia

            Dim tf As Decimal = Base + CuotaIva - retencion - cuotafondo - cuotacontingencia
            FacturaAgr.FGR_TotalFactura.Valor = tf.ToString
            FacturaAgr.Actualizar()



            For Each IDALBHIS In dcalba.Keys
                If Albentrada_his.LeerId(IDALBHIS) = True Then
                    Albentrada_his.AEH_idfactura.Valor = idfactura.ToString
                    Albentrada_his.Actualizar()
                End If
            Next


        End If

    End Sub


    Private Function GastosAlbaranes(idalbhis As Integer) As Decimal

        Dim ret As Decimal

        Dim sql As String = ""
        sql = "Select sum(AHG_IMPORTE) AS IGASTO FROM albentrada_hisgastos where ahg_idalbhis=" + idalbhis.ToString + " and AHG_FACTURA_COMERCIAL ='F'"
        Dim DT As DataTable = cn.ConsultaSQL(sql)
        If Not DT Is Nothing Then
            If DT.Rows.Count > 0 Then
                ret = VaDec(DT.Rows(0)(0))
            End If
        End If
        Return ret

    End Function

    Private Sub TxSemana_Valida(edicion As Boolean) Handles TxSemana.Valida
        _idsemana = SemanasPartes.LeerSemana(TxEjAlbaranes.Text, VaInt(TxSemana.Text))
        If _idsemana > 0 Then
            If SemanasPartes.LeerId(_idsemana) = True Then
                TxDeFecha.Text = SemanasPartes.SEV_FechaInicialEntrada.Valor
                TxaFecha.Text = SemanasPartes.SEV_FechaFinalEntrada.Valor
            End If

            'If TxFecha.Text.Trim = "" Then TxFecha.Text = TxaFecha.Text
            If TxCentro.Text.Trim = "" Then TxCentro.Text = MiMaletin.IdCentro.ToString

        Else
            MsgBox("Semana inexistente")
            TxSemana.MiError = True
        End If

    End Sub







    Private Sub TxCentro_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxCentro.TextChanged

    End Sub

    Private Sub TxCentro_Valida(edicion As Boolean) Handles TxCentro.Valida
        If VaInt(TxCentro.Text) <> MiMaletin.IdCentro Then
            MsgBox("el centro debe ser " & MiMaletin.IdCentro.ToString)
            TxCentro.MiError = True
        End If
    End Sub

    Private Sub TxEjAlbaranes_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxEjAlbaranes.TextChanged

    End Sub

    Private Sub TxEjAlbaranes_Valida(edicion As Boolean) Handles TxEjAlbaranes.Valida
        If edicion = True Then
            BtBuscaSemana.CL_Filtro = "Campa=" + TxEjAlbaranes.Text
        End If

    End Sub


    Private Sub TxAnnoFondo_Valida(edicion As System.Boolean) Handles TxAnnoFondo.Valida

        If edicion Then

            If TxAnnoFondo.Text.Trim <> "" Then

                Dim anno As Integer = VaInt(TxAnnoFondo.Text)
                If anno = 0 Or (anno > 2000 And anno <= 2999) Then
                    TxAnnoFondo.MiError = False
                Else
                    MsgBox("Año no válido")
                    TxAnnoFondo.MiError = True
                End If

            End If

        End If

    End Sub

End Class