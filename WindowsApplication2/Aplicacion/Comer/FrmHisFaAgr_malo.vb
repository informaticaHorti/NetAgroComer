Imports DevExpress.XtraEditors
Imports System.Drawing


Public Class FrmHisfaAgr_malo




    Inherits FrMantenimiento


    Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)
    Dim FacturaAgr_lineas As New E_FacturaAgr_lineas(Idusuario, cn)
    Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Albentrada As New E_AlbEntrada(Idusuario, cn)

    Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)



    Dim IdAsientonet As Integer






    Dim MiCentro As String


    Dim acum As New Acumulador


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Private Sub ParametrosFrm()
        EntidadFrm = FacturaAgr


        Dim lc As New List(Of Object)
        ListaControles = lc



        CampoClave = 2 ' ultimo campo de la clave

        ParamTx(TxSerie, FacturaAgr.FGR_serie, LbFactura, True)
        ParamTx(TxFactura, FacturaAgr.FGR_numerofactura, LbFactura, True)
        TxFactura.Autonumerico = True

        ParamTx(TxFecha, FacturaAgr.FGR_fecha, LbFecha, True)
        ParamTx(TxAgricultor, FacturaAgr.FGR_Idagricultor, LbAgricultor, True)
        ParamTx(TxAgricultorAlb, FacturaAgr.FGR_IdagricultorALB, LbAgricultor2, True)

        ParamTx(TxSemana, Nothing, LbSemana, True)



        ParamTx(TxPartida, Nothing, LbPartida)
        ParamTx(TxGenero, FacturaAgr_lineas.FAL_idgenero, LbGenero, True)
        ParamTx(TxCategoria, FacturaAgr_lineas.FAL_idcategoria, LbCategoria, True)
        ParamTx(TxKilos, FacturaAgr_lineas.FAL_kilos, LbKilos, True)
        ParamTx(TxPrecio, FacturaAgr_lineas.FAL_precio, LbPrecio, True)


        AsociarControles(TxSerie, BtBuscaAlbaran, FacturaAgr.btBusca, FacturaAgr)


        AsociarGrid(ClGrid1, TxPartida, TxPrecio, FacturaAgr_lineas)

        PropiedadesCamposGr(ClGrid1, "FAL_id", "FAL_id", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Partida", "Partida", True, 10)
        PropiedadesCamposGr(ClGrid1, "Albaran", "Albaran", True, 10)
        PropiedadesCamposGr(ClGrid1, "Fecha", "Fecha", True, 15)
        PropiedadesCamposGr(ClGrid1, "Genero", "Genero", True, 60, False)
        PropiedadesCamposGr(ClGrid1, "Categpria", "Categoria", True, 50, False)
        PropiedadesCamposGr(ClGrid1, "Kilos", "Kilos", True, 15, True)
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 15, False, "#0.000")
        PropiedadesCamposGr(ClGrid1, "Importe", "Importe", True, 20, True, "#,##0.00", "{0:n2}")


        ParamTx(TxPorCom, FacturaAgr.FGR_porcomision, Lbporcom, False)
        ParamTx(TxGastos, FacturaAgr.FGR_otrosgastos, Lbgastos, False)
        ParamTx(TxIva, FacturaAgr.FGR_iva, Lbiva, True)
        ParamTx(TxTipoRet, FacturaAgr.FGR_tiporetencion, Lbporret, False)
        ParamTx(TxPorRet, FacturaAgr.FGR_retencion, Lbporret, False)

        ParamTx(TxporFondo, FacturaAgr.FGR_fondo, lbporfondo, False)


        AsociarControles(TxAgricultor, BtAgri, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbnomAgr1)
        AsociarControles(TxAgricultorAlb, BtAgriAlb, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbnomAgr2)
        AsociarControles(TxSemana, BtSemana, SemanasPartes.btBusca, SemanasPartes)

        AsociarControles(TxGenero, BtGenero, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbnomGenero)
        AsociarControles(TxCategoria, BtCategoria, Categorias.btBusca, Categorias, Categorias.CAE_CategoriaCalibre, LbNomCate)



        FiltroEntidad.Add(FacturaAgr.FGR_idempresa.NombreCampo, MiMaletin.IdEmpresaCTB.ToString)
        FiltroEntidad.Add(FacturaAgr.FGR_ejercicio.NombreCampo, MiMaletin.Ejercicio.ToString)

    End Sub


    Private Sub FrmFacturacion_Load(sender As Object, e As System.EventArgs) Handles Me.Load



        BTaux1.Text = "Imprimir"
        BTaux1.Image = NetAgro.My.Resources.Resources.Action_file_print_16x16_32
        BTaux1.Visible = True

        BtAux2.Text = "I.Directa"
        BtAux2.Image = NetAgro.My.Resources.Resources.Action_file_quick_print_16x16_32
        BtAux2.Visible = True


    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave

        Dim i As Integer
        If TxDato_1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = FacturaAgr.LeerFactura(LbNuCTB.Text, Lbejer.Text, TxSerie.Text, VaInt(TxFactura.Text))
            If i > 0 Then
                LbId.Text = i.ToString
            Else
                LbId.Text = "+"
            End If
        End If

        If LbId.Text <> "" Then
            CargaLineasGrid()
        End If

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()


        PintaPuntoVenta(FacturaAgr.FGR_idempresa.Valor, FacturaAgr.FGR_ejercicio.Valor, FacturaAgr.FGR_IdAsiento.Valor)
        Lbejer.Text = FacturaAgr.FGR_ejercicio.Valor
        LbNuCTB.Text = FacturaAgr.FGR_idempresa.Valor

        ' llenar el grid
        CargaLineasGrid()

        'CargaAlbaranes()

        BtSelNinguno.Enabled = False
        BtSelTodos.Enabled = False

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)

        MyBase.Entidad_a_DatosLin(Grid)
        If Grid Is ClGrid1 Then


        End If

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean
        'Dim importe As Double



        If LbId.Text = "+" Then
            LbId.Text = FacturaAgr.MaxId
            If TxFactura.Text = "+" Then
                TxFactura.Text = FacturaAgr.MaxIdCampa(Val(LbNuCTB.Text), Val(Lbejer.Text), TxSerie.Text)
            End If
        End If

        If Gr Is ClGrid1 Then
            FacturaAgr.FGR_Idfactura.Valor = LbId.Text
            FacturaAgr.FGR_ejercicio.Valor = Lbejer.Text
            FacturaAgr.FGR_idempresa.Valor = LbNuCTB.Text
        End If



        SqlGrid()
        r = MyBase.GuardarLineas(Gr)

        'Si estamos guardando líneas en el grid de otros gastos, debe recalcular todos los importes
        CalculoTotales(True)

        Return r

    End Function


    Private Sub CargaLineasGrid()

        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)


        CalculoTotales(False)

    End Sub




    Private Sub SqlGrid()
        Dim id As String

        If LbId.Text = "+" Then
            id = "-1"
        Else
            id = LbId.Text
        End If

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(FacturaAgr_lineas.FAL_id, "FAL_id")
        consulta.SelCampo(Albentrada_lineas.AEL_muestreo, "Partida", FacturaAgr_lineas.FAL_idpartida)
        consulta.SelCampo(Albentrada.AEN_Albaran, "Albaran", Albentrada_lineas.AEL_idalbaran)
        consulta.SelCampo(Albentrada.AEN_Fecha, "Fecha")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", FacturaAgr_lineas.FAL_idgenero)
        consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", FacturaAgr_lineas.FAL_idcategoria)
        consulta.SelCampo(FacturaAgr_lineas.FAL_kilos, "Kilos")
        consulta.SelCampo(FacturaAgr_lineas.FAL_precio, "Precio")
        consulta.SelCampo(FacturaAgr_lineas.FAL_importe, "Importe")

        consulta.WheCampo(FacturaAgr_lineas.FAL_idfactura, "=", id)
        Dim sql As String = consulta.SQL + " order by FAL_id"

        ClGrid1.Consulta = sql


    End Sub


    Public Overrides Sub Anular()
        MyBase.Anular()

    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If CDate(FacturaAgr.FGR_fecha.Valor) < MiMaletin.FechaCtbIva Then
            MsgBox("Fecha contabilidad bloqueada")
            Exit Sub
        End If

        If VaInt(FacturaAgr.FGR_IdLiquidacion.Valor) > 0 Then
            MsgBox("Factura liquidada")
            Exit Sub

        End If
        MyBase.BAnular_Click(sender, e)

    End Sub

    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If CDate(FacturaAgr.FGR_fecha.Valor) < MiMaletin.FechaCtbIva Then
            MsgBox("Fecha contabilidad bloqueada")
            Exit Sub
        End If

        If VaInt(FacturaAgr.FGR_IdLiquidacion.Valor) > 0 Then
            MsgBox("Factura liquidada")
            Exit Sub

        End If


        MyBase.BModificar_Click(sender, e)

        BtSelNinguno.Enabled = True
        BtSelTodos.Enabled = True

    End Sub


    Private Sub PintaPuntoVenta(ByVal idempresa As Integer, ByVal ejer As String, ByVal idasiento As String)

        Dim asientos As New E_Asientos(Idusuario, ConexCtb(idempresa))

        IdAsientonet = VaInt(idasiento)
        If VaInt(idasiento) > 0 Then
            LbAsiento.Text = asientos.NumeroAsiento(idasiento)
        End If
        Lbejer.Text = ejer
        LbNuCTB.Text = idempresa


    End Sub



    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        PintaPuntoVenta(MiMaletin.IdEmpresaCTB, MiMaletin.Ejercicio.ToString, "")
        Lbejer.Text = MiMaletin.Ejercicio
        LbNuCTB.Text = MiMaletin.IdEmpresaCTB
        IdAsientonet = 0



    End Sub


    Private Sub CalculoTotales(ByVal bCalcula As Boolean)




    End Sub









    Public Overrides Sub Guardar()


        If LbId.Text = "+" Then
            FacturaAgr.FGR_Idfactura.Valor = FacturaAgr.MaxId()
            LbId.Text = FacturaAgr.FGR_Idfactura.Valor
            If TxDato_1.Text = "+" Then
                TxDato_1.Text = FacturaAgr.MaxIdCampa(VaInt(LbNuCTB.Text), VaInt(Lbejer.Text), TxSerie.Text)
            End If
        End If


        FacturaAgr.FGR_Idfactura.Valor = LbId.Text

        FacturaAgr.FGR_ejercicio.Valor = Lbejer.Text
        FacturaAgr.FGR_idempresa.Valor = LbNuCTB.Text


        FacturaAgr.FGR_Igenero.Valor = LbImpGenero.Text
        FacturaAgr.FGR_comision.Valor = LbImpComi.Text
        FacturaAgr.FGR_BaseImponible.Valor = LbImpBase.Text

        FacturaAgr.FGR_CuotaIva.Valor = LbimpCuota.Text
        FacturaAgr.FGR_cuotaretencion.Valor = Lbimpret.Text
        FacturaAgr.FGR_cuotafondo.Valor = LbImpFondo.Text

        If TxTipoRet.Text = "B" Then
            FacturaAgr.FGR_Baseretencion.Valor = LbImpBase.Text
        Else
            FacturaAgr.FGR_Baseretencion.Valor = VaDec(LbImpBase.Text) + VaDec(LbimpCuota.Text)
        End If
        FacturaAgr.FGR_TotalFactura.Valor = LbImpTotal.Text


        MyBase.Guardar()


    End Sub


    Public Overrides Sub DespuesdeGuardar()
        Dim TxError As String = ""
        MyBase.DespuesdeGuardar()


        If VaDec(LbId.Text) > 0 Then
            If XtraMessageBox.Show("¿Desea imprimir la factura?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                ' C1_ImprimirFacturaComercializacion(LbId.Text, TipoImpresion.Preliminar)
            End If
        End If


        If ConectarFinancieroContabilidad = "S" Then

            ' Dim i As Integer = Facturas.Contabiliza(LbId.Text)
            Dim i As Integer = 0
            If i > 0 Then

                Dim ListaAsientos As New List(Of Integer)
                ListaAsientos.Add(i)
                Dim f As New frmVisualizadorAsiento(ListaAsientos, False, "")
                f.ShowDialog()

            Else
                MsgBox("no se generó asiento")
            End If


        End If





    End Sub

    Public Overrides Sub DespuesdeAnular()
        Dim c As New Contabilizacion.clAsientos

        MyBase.DespuesdeAnular()
        If IdAsientonet > 0 And VaInt(LbAsiento.Text) > 0 Then
            If c.AnularAsiento(ConexCtb(VaInt(LbNuCTB.Text)), IdAsientonet, LbAsiento.Text) <> 0 Then
                MsgBox("No se pudo anular el asiento ")
            Else
                MsgBox("Asiento anulado con exito")
            End If
        End If

    End Sub

    Private Sub LbAsiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbAsiento.Click
        If LbAsiento.Text <> "" Then

            Dim IdAsientoNET As Integer = VaInt(FacturaAgr.FGR_IdAsiento.Valor)
            Dim ListaAsientos As New List(Of Integer)
            ListaAsientos.Add(IdAsientoNET)
            Dim F As New FrmConsultaVisuAsiento(ListaAsientos, False)
            F.ShowDialog()

        End If
    End Sub



    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaDec(LbId.Text) > 0 Then
            '            C1_ImprimirFacturaComercializacion(LbId.Text, TipoImpresion.Preliminar)
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaDec(LbId.Text) > 0 Then
            C1_ImprimirFacturaComercializacion(LbId.Text, TipoImpresion.ImpresoraPorDefecto)
        End If

    End Sub


End Class