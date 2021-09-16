Public Class FrmGasComerCompra

    Inherits FrMantenimiento


    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
    Dim Albentrada_hislineas As New E_AlbEntrada_hislineas(Idusuario, cn)
    Dim Albentrada_hisgastos As New E_albentrada_hisgastos(Idusuario, cn)
    Dim TiposdegastoAgri As New E_TiposdeGastoAgri(Idusuario, cn)
    Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim OrigenGastos As New E_OrigenGastos(Idusuario, cn)
    Dim Tipoprecio As String = ""

    Dim Valorespventa As New E_valorespventa(Idusuario, cn)
    Dim PventaUsuario As New E_PventaUsuario(Idusuario, cn)
    Dim FacturasRecibidas As New E_Facturasrecibidas(Idusuario, cn)



    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim MiCentro As String
    'Dim Envases As New E_Envases(Idusuario, cn)





    Private Sub ParametrosFrm()
        EntidadFrm = Albentrada_his


        Dim lc As New List(Of Object)
        ListaControles = lc



        LbPuntoVenta.CL_ControlAsociado = TxDato_1
        LbNomPv.CL_ControlAsociado = TxDato_1
        CampoClave = 1 ' ultimo campo de la clave

        ParamTx(TxDato_1, Albentrada.AEN_Albaran, Lb_1, True)
        ParamTx(TxDato1, Albentrada_his.AEH_nmed, Lb_1, False)

        TxDato_1.Autonumerico = False

        AsociarControles(TxDato_1, BtBuscaAlbaran, Albentrada_his.btBusca, Albentrada_his)
        BtBuscaAlbaran.CL_Filtro = PventaUsuario.FiltroPventaGrid("PV", "")
        BtBuscaAlbaran.CL_xCentro = False



        ParamTx(TxDato22, Albentrada_hisgastos.AHG_idgasto, Lb32, True)
        ParamCb_Copia(CbBox2, Albentrada_hisgastos.AHG_tipo, Lb8, Combos.ComboGastos)
        ParamTx(TxDato10, Albentrada_hisgastos.AHG_valor, Lb12, False)
        ParamTx(TxDato11, Albentrada_hisgastos.AHG_idacreedor, Lb7, False)

        AsociarGrid(ClGrid2, TxDato22, TxDato11, Albentrada_hisgastos)

        PropiedadesCamposGr(ClGrid2, "AHG_id", "AHG_id", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid2, "Gasto", "Gasto", True, 30)
        PropiedadesCamposGr(ClGrid2, "Valor", "Valor", True, 10, False, "#0.0000")
        PropiedadesCamposGr(ClGrid2, "KBP", "KBP", True, 10)
        PropiedadesCamposGr(ClGrid2, "FC", "FC", True, 10)
        PropiedadesCamposGr(ClGrid2, "Acreedor", "Acreedor", True, 50)
        PropiedadesCamposGr(ClGrid2, "ImporteGasto", "ImporteGasto", True, 20, True, "#0.00")

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False






        AsociarControles(TxDato22, BtBuscaGasto, TiposdegastoAgri.btBusca, TiposdegastoAgri, TiposdegastoAgri.TGA_Nombre, Lb1)
        AsociarControles(TxDato11, BtBuscaAcreedor, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomAcreedor)

        ' BotonesAvance1.Mientidad = EntidadFrm
        ' BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        ' BotonesAvance1.Formulario = Me

        BAnular.Visible = False

        FiltroEntidad.Add(Albentrada_his.AEH_idempresa.NombreCampo, MiMaletin.IdEmpresaCTB.ToString)



    End Sub



    Public Overrides Sub ControlClave()
        ' componemos la clave
        Dim i As Integer
        '        If TxDato15.Text = "+" Then
        ' LbId.Text = "+"
        ' Else

        i = Albentrada_his.LeerAlb(MiMaletin.Ejercicio.ToString, TxDato_1.Text, TxDato1.Text)
        If i > 0 Then
            LbId.Text = i.ToString
        Else

        End If


        If LbId.Text <> "" Then
            CargaLineasGrid()
        End If


    End Sub
    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()


        Albentrada.LeerId(Albentrada_his.AEH_idalbaran.Valor)

        PintaPuntoVenta(Albentrada.AEN_IdPuntoVenta.Valor)
        Lbejer.Text = Albentrada.AEN_Campa.Valor
        If Agricultores.LeerId(Albentrada_his.AEH_idproveedor.Valor) = True Then
            LbCliente.Text = Agricultores.AGR_Nombre.Valor
        End If
        LbFecha.Text = Albentrada.AEN_Fecha.Valor
        ' llenar el grid
        CargaLineasGrid()
    End Sub



    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)

        If Grid Is ClGrid2 Then

            Grid.LineaBloqueada = False
            If VaInt(Albentrada_hisgastos.AHG_idfacturaproveedor.Valor) > 0 Then
                If FacturasRecibidas.LeerId(Albentrada_hisgastos.AHG_idfacturaproveedor.Valor) = True Then
                    Grid.LineaBloqueada = True

                    'Número factura
                    LbNuFactura.Text = FacturasRecibidas.FRR_numerofactura.Valor

                End If
            End If

        End If


        MyBase.Entidad_a_DatosLin(Grid)

    End Sub
    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean
        Dim igasto As Double



        If Gr Is ClGrid2 Then
            Albentrada_hisgastos.AHG_idalbhis.Valor = LbId.Text
            Albentrada_hisgastos.AHG_idalbaran.Valor = Albentrada_his.AEH_idalbaran.Valor

            Select Case CbBox2.SelectedValue
                Case "B"
                    igasto = VaDec(LbBultos.Text) * VaDec(TxDato10.Text)
                Case "K"
                    igasto = VaDec(LbKilos.Text) * VaDec(TxDato10.Text)
                Case "P"
                    igasto = VaDec(LbPalets.Text) * VaDec(TxDato10.Text)
                Case "%"
                    igasto = VaDec(LbIgeneros.Text) * VaDec(TxDato10.Text) / 100
                Case "I"
                    igasto = VaDec(TxDato10.Text)


            End Select
            Albentrada_hisgastos.AHG_importe.Valor = igasto.ToString
            Albentrada_hisgastos.AHG_factura_comercial.Valor = "C"
        End If



        SqlGrid()
        r = MyBase.GuardarLineas(Gr)


        CalculoTotales()

        Return r

    End Function

    Public Overrides Sub DespuesdeGuardar()

        Agro_ValoraAlbaranHis(Albentrada_his.AEH_idalbaran.Valor)
        MyBase.DespuesdeGuardar()

        'Dim frm As New FrmComprobarPalets(LbId.Text)
        'frm.MdiParent = Me.MdiParent
        'frm.Show()

    End Sub
    Private Sub CargaLineasGrid()
        SqlGrid()
        ClGrid2.Nlinea = -1
        Cargalineas(ClGrid2)
        CalculoTotales()


    End Sub


    Private Sub SqlGrid()
        Dim id As String

        If LbId.Text = "+" Then
            id = "-1"
        Else
            id = LbId.Text
        End If
        Dim sql As String
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable


        Dim CONSULTA2 As New Cdatos.E_select

        CONSULTA2.SelCampo(Albentrada_hisgastos.AHG_id, "AHG_id")
        CONSULTA2.SelCampo(TiposdegastoAgri.TGA_Nombre, "Gasto", Albentrada_hisgastos.AHG_idgasto)
        CONSULTA2.SelCampo(Albentrada_hisgastos.AHG_valor, "Valor")
        CONSULTA2.SelCampo(Albentrada_hisgastos.AHG_tipo, "KBP")
        CONSULTA2.SelCampo(Albentrada_hisgastos.AHG_factura_comercial, "FC")
        CONSULTA2.SelCampo(Acreedores.ACR_Nombre, "Acreedor", Albentrada_hisgastos.AHG_idacreedor)
        CONSULTA2.SelCampo(Albentrada_hisgastos.AHG_importe, "ImporteGasto")
        CONSULTA2.WheCampo(Albentrada_hisgastos.AHG_idalbhis, "=", id)
        CONSULTA2.WheCampo(Albentrada_hisgastos.AHG_factura_comercial, "=", "C")

        sql = CONSULTA2.SQL
        sql = sql + " order by AHG_id"

        ClGrid2.Consulta = sql


    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub

    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)



        MyBase.BModificar_Click(sender, e)

    End Sub



    Private Sub PintaPuntoVenta(ByVal idpv As String)
        LbPuntoVenta.Text = idpv

        If PuntoVenta.LeerId(idpv) = True Then
            LbNomPv.Text = PuntoVenta.Nombre.Valor
            micentro = PuntoVenta.IdCentro.Valor
        Else
            LbNomPv.Text = ""
            micentro = ""
        End If

    End Sub

    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)
        If gr Is ClGrid2 Then
            LbNuFactura.Text = ""
        End If

    End Sub
    Public Overrides Sub BorraPan()

        MyBase.BorraPan()

        PintaPuntoVenta(MiMaletin.IdPuntoVenta)
        Lbejer.Text = MiMaletin.Ejercicio
        LbFecha.Text = ""
        LbCliente.Text = ""
        LbKilos.Text = ""
        LbBultos.Text = ""
        LbPalets.Text = ""
        LbIgeneros.Text = ""

    End Sub
    Private Sub CalculoTotales()

        Dim sql As String

        sql = "Select sum(AHL_kilos) as kilos, "
        sql = sql + " sum(AHL_palets) as palets, "
        sql = sql + " sum(AHL_bultos) as bultos, "
        sql = sql + " sum(AHL_importegenero) as igenero "


        sql = sql + " from albentrada_hislineas where AHL_idalbhis=" + LbId.Text

        Dim dt As DataTable = Albentrada_hislineas.MiConexion.ConsultaSQL(sql)

        LbKilos.Text = ""
        LbBultos.Text = ""
        LbPalets.Text = ""
        LbIgeneros.Text = ""

        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                LbIgeneros.Text = Format(VaDec(dt.Rows(0)("igenero")), "#,###0.00")
                LbKilos.Text = Format(VaDec(dt.Rows(0)("kilos")), "#,###")
                LbBultos.Text = dt.Rows(0)("bultos").ToString
                LbPalets.Text = dt.Rows(0)("palets").ToString

            End If
        End If

        Dim gc As Double = 0

        sql = "Select * from albentrada_hisgastos where AHG_idalbhis=" + LbId.Text
        Dim dtg As DataTable = Albentrada_hisgastos.MiConexion.ConsultaSQL(sql)
        If Not dtg Is Nothing Then
            For Each rw In dtg.Rows
                Select Case rw("AHG_factura_comercial").ToString
                    Case "C"
                        gc = gc + VaDec(rw("AHG_importe"))

                End Select
            Next
        End If

        LbGastosCom.Text = Format(gc, "#,###0.00")


    End Sub


    Public Overrides Sub Guardar()

        MyBase.Guardar()

    End Sub



    Private Sub TxDato22_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato22.TextChanged

    End Sub

    Private Sub TxDato22_Valida(ByVal edicion As Boolean) Handles TxDato22.Valida
        If TiposdegastoAgri.LeerId(TxDato22.Text) = True Then
            If OrigenGastos.LeerId(TiposdegastoAgri.TGA_idgrupo.Valor) Then
                BtBuscaAcreedor.CL_Filtro = "TIPO='" + OrigenGastos.ORG_tipo.Valor + "'"
            End If
            If edicion = True Then
                If CbBox2.SelectedValue Is Nothing Then
                    CbBox2.SelectedValue = TiposdegastoAgri.TGA_Tipo.Valor
                End If
                If TxDato11.Text = "" Then
                    TxDato11.Text = TiposdegastoAgri.TGA_idacreedor.Valor
                End If
                If TiposdegastoAgri.TGA_tipogastofc.Valor <> "C" Then
                    MsgBox("Solo se pueden cambiar gastos comerciales")
                    TxDato22.MiError = True
                End If
            End If
        End If

    End Sub







End Class