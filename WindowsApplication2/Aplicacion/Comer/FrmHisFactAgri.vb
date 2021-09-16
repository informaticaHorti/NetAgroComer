Imports DevExpress.XtraEditors

Public Class FrmHisFactAgri
    Inherits FrMantenimiento



    Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)
    Dim FacturaAgr_lineas As New E_FacturaAgr_lineas(Idusuario, cn)
    Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)

    Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)

    Dim Altas_AEAT As New E_Altas_AEAT(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim TipoIvaSoportado As New E_TipoIvaSoportado(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))


    Dim IdAsientonet As Integer
    Dim IdAsientoREA As Integer
    Dim IdAsientoREA_Ret As Integer






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



        CampoClave = 1 ' ultimo campo de la clave

        ParamTx(TxSerie, FacturaAgr.FGR_serie, LbFactura, True)
        ParamTx(TxFactura, FacturaAgr.FGR_numerofactura, LbFactura, True)
        TxFactura.Autonumerico = True

        ParamTx(TxFecha, FacturaAgr.FGR_fecha, LbFecha, True)
        ParamTx(TxAgricultor, FacturaAgr.FGR_Idagricultor, LbAgricultor, True)
        ParamTx(TxAgricultorAlb, FacturaAgr.FGR_IdagricultorALB, LbAgricultor2, True)
        ParamTx(TxRegimenIva, FacturaAgr.FGR_IdTipoIva, LbRegimenIva, True)
        ParamTx(TxCentro, FacturaAgr.FGR_idcentro, LbCentro, True)
        ParamTx(TxSemana, Nothing, Lbsemana, True)


        ParamTx(TxFechaAsientoREA, FacturaAgr.FGR_FechaAsientoREA, LbFechaAsientoREA)
        ParamTx(TxEjercicioREA, FacturaAgr.FGR_EjercicioREA, LbEjercicioREA)


        ParamTx(TxPartida, Nothing, LbPartida)
        ParamTx(TxGenero, FacturaAgr_lineas.FAL_idgenero, LbGenero, True)
        ParamTx(TxCategoria, FacturaAgr_lineas.FAL_idcategoria, LbCategoria, True)
        ParamTx(TxPresenta, FacturaAgr_lineas.FAL_IdGensal, LbPresenta, False)
        ParamTx(TxKilos, FacturaAgr_lineas.FAL_kilos, LbKilos, True)
        ParamTx(TxBultos, FacturaAgr_lineas.FAL_bultos, LbBultos, False)
        ParamTx(TxPiezas, FacturaAgr_lineas.FAL_Piezas, LbPiezas, False)
        ParamTx(TxPrecio, FacturaAgr_lineas.FAL_precio, LbPrecio, True)
        ParamTx(TxTipoPre, FacturaAgr_lineas.FAL_TipoPrecio, LbPrecio, False)


        AsociarControles(TxSerie, BtBuscaAlbaran, FacturaAgr.btBusca, FacturaAgr)
        AsociarControles(TxRegimenIva, BtBuscaRegimenIva, TipoIvaSoportado.btBusca, TipoIvaSoportado, TipoIvaSoportado.Nombre, LbNom_RegimenIva)


        AsociarGrid(ClGrid1, TxPartida, TxTipoPre, FacturaAgr_lineas)

        PropiedadesCamposGr(ClGrid1, "FAL_id", "FAL_id", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Partida", "Partida", True, 10)
        PropiedadesCamposGr(ClGrid1, "Albaran", "Albaran", True, 10)
        PropiedadesCamposGr(ClGrid1, "Fecha", "Fecha", True, 15)
        PropiedadesCamposGr(ClGrid1, "Genero", "Genero", True, 60, False)
        PropiedadesCamposGr(ClGrid1, "Categpria", "Categoria", True, 50, False)
        PropiedadesCamposGr(ClGrid1, "Kilos", "Kilos", True, 15, True)
        PropiedadesCamposGr(ClGrid1, "Bultos", "Bultos", True, 15, True)
        PropiedadesCamposGr(ClGrid1, "Piezas", "Piezas", True, 15, True)
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 15, False, "#0.000")
        PropiedadesCamposGr(ClGrid1, "Importe", "Importe", True, 20, True, "#,##0.00", "{0:n2}")


        ParamTx(TxPorCom, FacturaAgr.FGR_porcomision, Lbporcom, False)
        ParamTx(TxGastos, FacturaAgr.FGR_otrosgastos, Lbgastos, False)
        ParamTx(TxIva, FacturaAgr.FGR_iva, Lbiva, True)
        ParamTx(TxTipoRet, FacturaAgr.FGR_tiporetencion, Lbporret, False)
        ParamTx(TxPorRet, FacturaAgr.FGR_retencion, Lbporret, False)

        ParamTx(TxporFondo, FacturaAgr.FGR_fondo, lbporfondo, False)
        ParamTx(TxPorContingencia, FacturaAgr.FGR_PorContingencia, LbporContingencia, False)


        AsociarControles(TxAgricultor, BtAgri, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbnomAgr1)
        AsociarControles(TxAgricultorAlb, BtAgriAlb, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbnomAgr2)
        AsociarControles(TxSemana, BtSemana, SemanasPartes.btBusca, SemanasPartes)

        AsociarControles(TxGenero, BtGenero, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbnomGenero)
        AsociarControles(TxCategoria, BtCategoria, Categorias.btBusca, Categorias, Categorias.CAE_CategoriaCalibre, LbNomCate)
        AsociarControles(TxPresenta, BtPresenta, GenerosSalida.BtBuscaXconfec, GenerosSalida, GenerosSalida.GES_Nombre, LbNomPresenta)

        AsociarControles(TxCentro, BtCentro, Centros.btBusca, Centros, Centros.Nombre, LbNomCentro)


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
        If TxFactura.Text = "+" Then
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


        PintaPuntoVenta(FacturaAgr.FGR_idempresa.Valor, FacturaAgr.FGR_ejercicio.Valor, FacturaAgr.FGR_IdAsiento.Valor, FacturaAgr.FGR_IdAsientoREA.Valor, FacturaAgr.FGR_IdAsientoREA_Ret.Valor)
        Lbejer.Text = FacturaAgr.FGR_ejercicio.Valor
        LbNuCTB.Text = FacturaAgr.FGR_idempresa.Valor


        If VaInt(FacturaAgr.FGR_IdLiquidacion.Valor) > 0 Then
            Dim LiquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)
            If LiquidacionAgr.LeerId(FacturaAgr.FGR_IdLiquidacion.Valor) Then
                Dim NumLiq As String = LiquidacionAgr.LIQ_numero.Valor
                Dim Serie As String = (LiquidacionAgr.LIQ_serie.Valor & "").Trim
                If Serie <> "" Then NumLiq = Serie & "-" & NumLiq
                LbLiquidacion.Text = NumLiq
            End If
        End If


        LbImpGenero.Text = VaDec(FacturaAgr.FGR_Igenero.Valor).ToString("#,###0.00")
        LbImpComi.Text = VaDec(FacturaAgr.FGR_comision.Valor).ToString("#,###0.00")
        LbImpBase.Text = VaDec(FacturaAgr.FGR_BaseImponible.Valor).ToString("#,###0.00")
        LbimpCuota.Text = VaDec(FacturaAgr.FGR_CuotaIva.Valor).ToString("#,###0.00")
        Lbimpret.Text = VaDec(FacturaAgr.FGR_cuotaretencion.Valor).ToString("#,###0.00")
        LbImpFondo.Text = VaDec(FacturaAgr.FGR_cuotafondo.Valor).ToString("#,###0.00")
        LbAnnoFondo.Text = FacturaAgr.FGR_AnnoFondo.Valor
        LbImpTotal.Text = VaDec(FacturaAgr.FGR_TotalFactura.Valor).ToString("#,###0.00")
        LbImpContingencia.Text = VaDec(FacturaAgr.FGR_CuotaContingencia.Valor).ToString("#,##0.00")


        If FacturaAgr.FGR_Idsemana.Valor <> "" Then
            If SemanasPartes.LeerId(FacturaAgr.FGR_Idsemana.Valor) = True Then
                TxSemana.Text = SemanasPartes.SEV_Semana.Valor
            End If
        End If

        ' llenar el grid
        CargaLineasGrid()

        'CargaAlbaranes()


    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)

        MyBase.Entidad_a_DatosLin(Grid)
        If Grid Is ClGrid1 Then


            If Albentrada_lineas.LeerId(FacturaAgr_lineas.FAL_idpartida.Valor) = True Then
                TxPartida.Text = Albentrada_lineas.AEL_muestreo.Valor
                If Albentrada.LeerId(Albentrada_lineas.AEL_idalbaran.Valor) = True Then
                    LbNumAlb.Text = Albentrada.AEN_Albaran.Valor
                End If
            End If


        End If

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean




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
            FacturaAgr_lineas.FAL_idfactura.Valor = LbId.Text

            FacturaAgr_lineas.FAL_idpartida.Valor = Albentrada_lineas.LeerMuestreo(Lbejer.Text, TxPartida.Text).ToString
            Dim importe As Decimal = 0
            Select Case TxTipoPre.Text
                Case "P"
                    importe = VaDec(TxPiezas.Text) * VaDec(TxPrecio.Text)
                Case "B"
                    importe = VaDec(TxBultos.Text) * VaDec(TxPrecio.Text)
                Case Else
                    importe = VaDec(TxKilos.Text) * VaDec(TxPrecio.Text)

            End Select

            FacturaAgr_lineas.FAL_importe.Valor = importe.ToString("#,###0.00")
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
        consulta.SelCampo(FacturaAgr_lineas.FAL_bultos, "Bultos")
        consulta.SelCampo(FacturaAgr_lineas.FAL_Piezas, "Piezas")
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


        If VaDec(LbId.Text) > 0 Then

            Dim lstAsientos As New List(Of String)

            Dim IdAsiento As String = (FacturaAgr.FGR_IdAsiento.Valor & "").Trim
            Dim IdAsientoREA As String = (FacturaAgr.FGR_IdAsientoREA.Valor & "").Trim
            Dim IdAsientoREA_Ret As String = (FacturaAgr.FGR_IdAsientoREA_Ret.Valor & "").Trim


            If VaDec(IdAsiento) > 0 Then lstAsientos.Add(IdAsiento)
            If VaDec(IdAsientoREA) > 0 Then lstAsientos.Add(IdAsientoREA)
            If VaDec(IdAsientoREA_Ret) > 0 Then lstAsientos.Add(IdAsientoREA_Ret)


            If lstAsientos.Count > 0 Then

                If FacturaEnviada_AEAT(lstAsientos) Then
                    MsgBox("No se puede anular la factura debido a que ya ha sido presentada en Hacienda. Para cualquier cambio debe presentar una factura rectificativa.")
                Else
                    MyBase.BAnular_Click(sender, e)
                End If

            End If

        End If


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

        If VaDec(LbId.Text) > 0 Then

            Dim lstAsientos As New List(Of String)

            Dim IdAsiento As String = (FacturaAgr.FGR_IdAsiento.Valor & "").Trim
            Dim IdAsientoREA As String = (FacturaAgr.FGR_IdAsientoREA.Valor & "").Trim
            Dim IdAsientoREA_Ret As String = (FacturaAgr.FGR_IdAsientoREA_Ret.Valor & "").Trim


            If VaDec(IdAsiento) > 0 Then lstAsientos.Add(IdAsiento)
            If VaDec(IdAsientoREA) > 0 Then lstAsientos.Add(IdAsientoREA)
            If VaDec(IdAsientoREA_Ret) > 0 Then lstAsientos.Add(IdAsientoREA_Ret)


            Dim bModificar As Boolean = True

            If lstAsientos.Count > 0 Then

                If FacturaEnviada_AEAT(lstAsientos) Then
                    bModificar = False
                    MsgBox("No se puede modificar la factura debido a que ya ha sido presentada en Hacienda. Para cualquier cambio debe presentar una factura rectificativa.")
                End If

            End If


            If bModificar Then
                MyBase.BModificar_Click(sender, e)
            End If


        End If


    End Sub


    Private Sub PintaPuntoVenta(ByVal idempresa As Integer, ByVal ejer As String, ByVal idasiento As String, ByVal Id_AsientoREA As String, ByVal Id_AsientoREA_Ret As String)

        Dim asientos As New E_Asientos(Idusuario, ConexCtb(idempresa))
        Dim AsientosREA As New E_Asientos(Idusuario, ConexCtb(idempresa))
        Dim AsientoREA_Ret As New E_Asientos(Idusuario, ConexCtb(idempresa))


        IdAsientonet = VaInt(idasiento)
        If VaInt(idasiento) > 0 Then
            LbAsiento.Text = asientos.NumeroAsiento(idasiento)
        End If

        IdAsientoREA = VaInt(Id_AsientoREA)
        If VaInt(Id_AsientoREA) > 0 Then
            LbAsientoREA.Text = AsientosREA.NumeroAsiento(Id_AsientoREA)
        End If

        IdAsientoREA_Ret = VaInt(Id_AsientoREA_Ret)
        If VaInt(Id_AsientoREA_Ret) > 0 Then
            LbAsientoREA_Ret.Text = AsientoREA_Ret.NumeroAsiento(Id_AsientoREA_Ret)
        End If

        Lbejer.Text = ejer
        LbNuCTB.Text = idempresa


    End Sub



    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        LbNumAlb.Text = ""

        MyBase.Borralin(gr)
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        PintaPuntoVenta(MiMaletin.IdEmpresaCTB, MiMaletin.Ejercicio.ToString, "", "", "")
        Lbejer.Text = MiMaletin.Ejercicio
        LbNuCTB.Text = MiMaletin.IdEmpresaCTB
        IdAsientonet = 0
        IdAsientoREA = 0
        IdAsientoREA_Ret = 0

        LbImpGenero.Text = ""

        LbImpComi.Text = ""
        LbImpBase.Text = ""
        LbimpCuota.Text = ""
        Lbimpret.Text = ""
        LbImpFondo.Text = ""
        LbAnnoFondo.Text = ""
        LbImpTotal.Text = ""
        LbImpContingencia.Text = ""

        LbLiquidacion.Text = ""


    End Sub


    Private Sub CalculoTotales(ByVal bCalcula As Boolean)


        If bCalcula = True Then
            Dim igenero As Decimal = 0
            Dim sql As String = "Select sum(FAL_IMPORTE) AS IMPORTE FROM FACTURAAGR_LINEAS WHERE FAL_IDFACTURA=" + LbId.Text
            Dim DT As DataTable = FacturaAgr_lineas.MiConexion.ConsultaSQL(sql)
            If Not DT Is Nothing Then
                If DT.Rows.Count > 0 Then
                    igenero = VaDec(DT.Rows(0)("Importe"))
                End If
            End If
            LbImpGenero.Text = igenero.ToString("#,###0.00")
        End If

        LbImpComi.Text = (VaDec(LbImpGenero.Text) * VaDec(TxPorCom.Text) / 100).ToString("#,###0.00")
        LbImpBase.Text = (VaDec(LbImpGenero.Text) - VaDec(LbImpComi.Text) - VaDec(TxGastos.Text)).ToString("#,###0.00")
        LbimpCuota.Text = (VaDec(LbImpBase.Text) * VaDec(TxIva.Text) / 100).ToString("#,###0.00")

        Dim baseret As Decimal = 0
        Select Case TxTipoRet.Text
            Case "B"
                baseret = VaDec(LbImpBase.Text)
            Case Else
                baseret = VaDec(LbImpBase.Text) + VaDec(LbimpCuota.Text)
        End Select

        Lbimpret.Text = (baseret * VaDec(TxPorRet.Text) / 100).ToString("#,###0.00")
        LbImpFondo.Text = (VaDec(LbImpBase.Text) * VaDec(TxporFondo.Text) / 100).ToString("#,###0.00")
        'LbImpContingencia.Text = (VaDec(LbImpBase.Text) * VaDec(TxPorContingencia.Text) / 100).ToString("#,###0.00")
        LbImpContingencia.Text = (VaDec(LbImpGenero.Text) * VaDec(TxPorContingencia.Text) / 100).ToString("#,###0.00")
        LbImpTotal.Text = (VaDec(LbImpBase.Text) + VaDec(LbimpCuota.Text) - VaDec(Lbimpret.Text) - VaDec(LbImpFondo.Text) - VaDec(LbImpContingencia.Text)).ToString("#,###0.00")


    End Sub



    Public Overrides Sub Guardar()


        If LbId.Text = "+" Then
            FacturaAgr.FGR_Idfactura.Valor = FacturaAgr.MaxId()
            LbId.Text = FacturaAgr.FGR_Idfactura.Valor
            If TxFactura.Text = "+" Then
                TxFactura.Text = FacturaAgr.MaxIdCampa(VaInt(LbNuCTB.Text), VaInt(Lbejer.Text), TxSerie.Text)
            End If
        End If


        FacturaAgr.FGR_Idfactura.Valor = LbId.Text

        FacturaAgr.FGR_ejercicio.Valor = Lbejer.Text
        FacturaAgr.FGR_idempresa.Valor = LbNuCTB.Text
        FacturaAgr.FGR_Idsemana.Valor = SemanasPartes.LeerSemana(Lbejer.Text, TxSemana.Text)
        CalculoTotales(True)
        FacturaAgr.FGR_Igenero.Valor = LbImpGenero.Text
        FacturaAgr.FGR_comision.Valor = LbImpComi.Text
        FacturaAgr.FGR_BaseImponible.Valor = LbImpBase.Text

        FacturaAgr.FGR_CuotaIva.Valor = LbimpCuota.Text
        FacturaAgr.FGR_cuotaretencion.Valor = Lbimpret.Text
        FacturaAgr.FGR_cuotafondo.Valor = LbImpFondo.Text

        FacturaAgr.FGR_CuotaContingencia.Valor = LbImpContingencia.Text


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

            Dim lst As List(Of Integer) = FacturaAgr.Contabiliza(LbId.Text)
            If lst.Count > 0 Then

                Dim ListaAsientos As New List(Of Integer)
                ListaAsientos.AddRange(lst)
                Dim f As New frmVisualizadorAsiento(ListaAsientos, False, "")
                f.ShowDialog()

            Else
                MsgBox("no se generó asiento")
            End If


        End If





    End Sub


    Public Overrides Sub DespuesdeAnular()
        MyBase.DespuesdeAnular()


        Dim c As New Contabilizacion.clAsientos

        If IdAsientonet > 0 And VaInt(LbAsiento.Text) > 0 Then
            If c.AnularAsiento(ConexCtb(VaInt(LbNuCTB.Text)), IdAsientonet, LbAsiento.Text) <> 0 Then
                MsgBox("No se pudo anular el asiento ")
            Else
                MsgBox("Asiento anulado con exito")
            End If
        End If

        If IdAsientoREA > 0 And VaInt(LbAsientoREA.Text) > 0 Then
            If c.AnularAsiento(ConexCtb(VaInt(LbNuCTB.Text)), IdAsientoREA, LbAsientoREA.Text) <> 0 Then
                MsgBox("No se pudo anular el asiento REA")
            Else
                MsgBox("Asiento REA anulado con exito")
            End If
        End If

        If IdAsientoREA_Ret > 0 And VaInt(LbAsientoREA_Ret.Text) > 0 Then
            If c.AnularAsiento(ConexCtb(VaInt(LbNuCTB.Text)), IdAsientoREA_Ret, LbAsientoREA_Ret.Text) <> 0 Then
                MsgBox("No se pudo anular el asiento REA de retención")
            Else
                MsgBox("Asiento REA de retención anulado con exito")
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


    Private Sub LbAsientoREA_Click(sender As System.Object, e As System.EventArgs) Handles LbAsientoREA.Click

        If LbAsientoREA.Text <> "" Then

            Dim IdAsientoREA As Integer = VaInt(FacturaAgr.FGR_IdAsientoREA.Valor)

            Dim ListaAsientos As New List(Of Integer)
            ListaAsientos.Add(IdAsientoREA)
            Dim f As New FrmConsultaVisuAsiento(ListaAsientos, False)
            f.ShowDialog()



        End If

    End Sub


    Private Sub LbAsientoREA_Ret_Click(sender As System.Object, e As System.EventArgs) Handles LbAsientoREA_Ret.Click

        If LbAsientoREA_Ret.Text <> "" Then

            Dim IdAsientoREA_Ret As Integer = VaInt(FacturaAgr.FGR_IdAsientoREA_Ret.Valor)

            Dim ListaAsientos As New List(Of Integer)
            ListaAsientos.Add(IdAsientoREA_Ret)
            Dim f As New FrmConsultaVisuAsiento(ListaAsientos, False)
            f.ShowDialog()

        End If

    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaDec(LbId.Text) > 0 Then
            C1_ImprimirFacturaAgr(Nothing, LbId.Text, TipoImpresion.Preliminar, "")
        End If
    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaDec(LbId.Text) > 0 Then
            C1_ImprimirFacturaAgr(Nothing, LbId.Text, TipoImpresion.ImpresoraPorDefecto, "")
        End If
    End Sub


    Private Sub TxPorCom_Valida(edicion As Boolean) Handles TxPorCom.Valida

        If edicion = True Then
            CalculoTotales(False)
        End If

    End Sub


    Private Sub TxGastos_Valida(edicion As Boolean) Handles TxGastos.Valida

        If edicion = True Then
            CalculoTotales(False)
        End If

    End Sub

    Private Sub TxIva_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxIva.TextChanged

    End Sub

    Private Sub TxIva_Valida(edicion As Boolean) Handles TxIva.Valida
        If edicion = True Then
            CalculoTotales(False)

        End If

    End Sub

    Private Sub TxporFondo_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxporFondo.TextChanged

    End Sub

    Private Sub TxporFondo_Valida(edicion As Boolean) Handles TxporFondo.Valida
        If edicion = True Then
            CalculoTotales(False)
        End If
    End Sub

    Private Sub TxTipoRet_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxTipoRet.TextChanged

    End Sub

    Private Sub TxTipoRet_Valida(edicion As Boolean) Handles TxTipoRet.Valida
        If edicion = True Then
            CalculoTotales(False)

        End If

    End Sub

    Private Sub TxPorRet_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxPorRet.TextChanged

    End Sub

    Private Sub TxPorRet_Valida(edicion As Boolean) Handles TxPorRet.Valida
        If edicion = True Then
            CalculoTotales(False)

        End If

    End Sub

    Private Sub TxPartida_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxPartida.TextChanged

    End Sub

    Private Sub TxPartida_Valida(edicion As Boolean) Handles TxPartida.Valida
        If edicion = True Then
            If TxPartida.Text <> "" Then
                Dim idpartida As Integer = Albentrada_lineas.LeerMuestreo(Lbejer.Text, TxPartida.Text)
                If idpartida > 0 Then
                    If Albentrada_lineas.LeerId(idpartida) = True Then
                        If TxGenero.Text = "" Then
                            TxGenero.Text = Albentrada_lineas.AEL_idgenero.Valor
                        End If
                        If Albentrada.LeerId(Albentrada_lineas.AEL_idalbaran.Valor) = True Then
                            LbNumAlb.Text = Albentrada.AEN_Albaran.Valor
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TxPorContingencia_Valida(edicion As System.Boolean) Handles TxPorContingencia.Valida
        If edicion = True Then
            CalculoTotales(False)
        End If
    End Sub

    'Private Sub GroupBox2_Click(sender As Object, e As System.EventArgs) Handles GroupBox2.Click
    '    If Val(LbId.Text) > 0 Then
    '        If MsgBox("Desea contabilizar la factura", vbYesNo) = vbYes Then

    '            Dim lst As List(Of Integer) = FacturaAgr.Contabiliza(LbId.Text)
    '            If lst.Count > 0 Then

    '                Dim ListaAsientos As New List(Of Integer)
    '                ListaAsientos.AddRange(lst)
    '                Dim f As New frmVisualizadorAsiento(ListaAsientos, False, "")
    '                f.ShowDialog()

    '            Else
    '                MsgBox("no se generó asiento")
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    'End Sub

    'Private Sub TxTipoPre_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxTipoPre.TextChanged

    'End Sub

    Private Sub TxTipoPre_Valida(edicion As Boolean) Handles TxTipoPre.Valida
        If TxTipoPre.Text <> "B" And TxTipoPre.Text <> "P" Then
            TxTipoPre.Text = "K"
        End If
    End Sub

    Private Sub TxGenero_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxGenero.TextChanged

    End Sub

    Private Sub TxGenero_Valida(edicion As Boolean) Handles TxGenero.Valida
        BtPresenta.CL_Filtro = "idgenero=" + TxGenero.Text
    End Sub

    
    Private Sub TxFecha_Valida(edicion As System.Boolean) Handles TxFecha.Valida

        If edicion Then

            If TxFechaAsientoREA.Text.Trim = "" Then
                TxFechaAsientoREA.Text = TxFecha.Text
            End If

            If TxEjercicioREA.Text.Trim = "" Then
                TxEjercicioREA.Text = Lbejer.Text
            End If

        End If

    End Sub


    Private Sub TxAgricultor_Valida(edicion As System.Boolean) Handles TxAgricultor.Valida

        If edicion Then

            If Not TxAgricultor.MiError Then

                'Comprueba si el nuevo agricultor no es rea. Si no lo es y existe asiento rea, pedir confirmacion del cambio y borrar el asiento en ese momento


                Dim IdAsientoREA As Integer = VaInt(FacturaAgr.FGR_IdAsientoREA.Valor)
                Dim IdAsientoREA_Ret As Integer = VaInt(FacturaAgr.FGR_IdAsientoREA_Ret.Valor)

                If IdAsientoREA <> 0 Then


                    If Not Es_Rea(TxAgricultor.Text) Then

                        If XtraMessageBox.Show("El nuevo agricultor seleccionado no es REA. ¿Desea asignar el nuevo agricultor y ANULAR EL ASIENTO REA?", "¿ANULAR ASIENTO?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                            'Anular asiento
                            'Asignar 0 a IdAsientoREA de la Factura
                            'Actualizar la entidad en memoria en el formulario
                            'Actualizar el número de asiento en el formulario

                            'REA IVA
                            Dim AsientosREA As New E_Asientos(Idusuario, ConexCtb(Val(LbNuCTB.Text)))
                            If AsientosREA.LeerId(IdAsientoREA.ToString) Then
                                AsientosREA.Eliminar()
                            End If

                            If VaInt(IdAsientoREA_Ret) > 0 Then
                                Dim AsientosREA_Ret As New E_Asientos(Idusuario, ConexCtb(Val(LbNuCTB.Text)))
                                If AsientosREA_Ret.LeerId(IdAsientoREA_Ret.ToString) Then
                                    AsientosREA_Ret.Eliminar()
                                End If
                            End If



                            Dim FacturaAgr_2 As New E_FacturaAgr(Idusuario, cn)
                            If FacturaAgr_2.LeerId(LbId.Text) Then
                                FacturaAgr_2.FGR_IdAsientoREA.Valor = 0
                                FacturaAgr_2.FGR_IdAsientoREA_Ret.Valor = 0
                                FacturaAgr_2.Actualizar()
                            End If



                            FacturaAgr.FGR_IdAsientoREA.Valor = 0
                            FacturaAgr.FGR_IdAsientoREA_Ret.Valor = 0

                            LbAsientoREA.Text = ""
                            LbAsientoREA_Ret.Text = ""



                        Else
                            TxAgricultor.MiError = True
                            PonError(TxAgricultor.Orden)
                        End If

                    End If

                End If



                If TxRegimenIva.Text.Trim = "" Then

                    Dim Agricultor As New E_Agricultores(Idusuario, cn)
                    If Agricultor.LeerId(TxAgricultor.Text) Then

                        If VaInt(Agricultor.AGR_IdTipo.Valor) > 0 Then

                            Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)
                            If TipoAgricultor.LeerId(Agricultor.AGR_IdTipo.Valor) Then

                                TxRegimenIva.Text = TipoAgricultor.TPA_idtipoiva.Valor & ""
                                TxRegimenIva.Validar(True)

                            End If

                        End If

                    End If

                End If





            End If

        End If

    End Sub


    Private Function Es_Rea(IdAgricultor As String) As Boolean

        Dim bRes As Boolean = False


        If VaInt(IdAgricultor) > 0 Then

            Dim sql As String = "SELECT TPA_Compensa as EsREA FROM TipoAgricultor LEFT JOIN Agricultores ON TPA_IdTipo = AGR_IdTipo WHERE AGR_IdAgricultor = " & IdAgricultor
            Dim dt As DataTable = Agricultores.MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim row As DataRow = dt.Rows(0)
                    Dim REA As String = (row("EsREA").ToString & "").Trim.ToUpper

                    If REA = "S" Then
                        bRes = True
                    End If

                End If
            End If

        End If



        Return bRes

    End Function

End Class