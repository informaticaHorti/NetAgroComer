Public Class FrmGasComer
    Inherits FrMantenimiento


    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Albsalida As New E_AlbSalida(Idusuario, cn)
    Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
    Dim Albsalida_gastos As New E_albsalida_gastos(Idusuario, cn)
    Dim GastosComercio As New E_GastosComercio(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Acreedores_Transportista As New E_Acreedores(Idusuario, cn)
    Dim OrigenGastos As New E_OrigenGastos(Idusuario, cn)
    Dim Tipoprecio As String = ""

    Dim Valorespventa As New E_valorespventa(Idusuario, cn)

    Dim FacturasRecibidas As New E_Facturasrecibidas(Idusuario, cn)
    Dim Moneda As New E_Moneda(Idusuario, cn)



    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim MiCentro As String


    Private _LineasDescripcion As New List(Of String)




    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Private Sub ParametrosFrm()
        EntidadFrm = Albsalida


        Dim lc As New List(Of Object)
        ListaControles = lc



        LbPuntoVenta.CL_ControlAsociado = TxDato_1
        LbNomPv.CL_ControlAsociado = TxDato_1
        CampoClave = 0 ' ultimo campo de la clave

        ParamTx(TxDato_1, Albsalida.ASA_albaran, Lb_1, True)
        TxDato_1.Autonumerico = False
        ParamTx(TxTransportista, Albsalida.ASA_idtransportista, LbTransportista, False)

        AsociarControles(TxDato_1, BtBuscaAlbaran, Albsalida.btBusca, Albsalida)
        AsociarControles(TxTransportista, BtBuscaTransportista, Acreedores_Transportista.BtBuscaXtipo, Acreedores_Transportista, Acreedores_Transportista.ACR_Nombre, LbNom_Transportista)
        BtBuscaTransportista.CL_Filtro = "TIPO='PV'"

        BtBuscaAlbaran.CL_Filtro = "EMP=" + MiMaletin.IdEmpresaCTB.ToString


        ParamTx(TxDato22, Albsalida_gastos.ASG_idgasto, Lb32, True)
        ParamCb_Copia(CbBox2, Albsalida_gastos.ASG_tipokbp, Lb8, Combos.ComboGastos)
        ParamTx(TxDato10, Albsalida_gastos.ASG_valorgasto, Lb12, False)
        ParamTx(TxDato11, Albsalida_gastos.ASG_idacreedor, Lb7, False)

        AsociarGrid(ClGrid2, TxDato22, TxDato11, Albsalida_gastos)

        PropiedadesCamposGr(ClGrid2, "ASG_id", "ASG_id", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid2, "Gasto", "Gasto", True, 30)
        PropiedadesCamposGr(ClGrid2, "Valor", "Valor", True, 10, False, "#0.0000")
        PropiedadesCamposGr(ClGrid2, "KBP", "KBP", True, 10)
        PropiedadesCamposGr(ClGrid2, "FC", "FC", True, 10)
        PropiedadesCamposGr(ClGrid2, "Acreedor", "Acreedor", True, 50)
        PropiedadesCamposGr(ClGrid2, "ImporteGasto", "ImporteGasto", True, 20, True, "#0.00")

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False






        AsociarControles(TxDato22, BtBuscaGasto, GastosComercio.btBusca, GastosComercio, GastosComercio.GCO_Nombre, Lb1)
        AsociarControles(TxDato11, BtBuscaAcreedor, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomAcreedor)

        ' BotonesAvance1.Mientidad = EntidadFrm
        ' BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        ' BotonesAvance1.Formulario = Me

        BAnular.Visible = False


        '     FiltroEntidad.Add(Albsalida.ASA_idcentro.NombreCampo, MiMaletin.IdCentro.ToString)
        FiltroEntidad.Add(Albsalida.ASA_ejercicio.NombreCampo, MiMaletin.Ejercicio.ToString)
        FiltroEntidad.Add(Albsalida.ASA_IdEmpresa.NombreCampo, MiMaletin.IdEmpresaCTB.ToString)

    End Sub



    Private Sub FrmGasComer_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BTaux1.Text = "Imprimir"
        BTaux1.Image = My.Resources.Action_file_print_16x16_32
        BTaux1.Visible = True

    End Sub



    Public Overrides Sub ControlClave()
        ' componemos la clave

        Dim i As Integer
        If TxDato_1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = Albsalida.LeerAlb(Lbejer.Text, MiCentro, VaInt(TxDato_1.Text))
            If i > 0 Then
                LbId.Text = i.ToString

            Else
                ' If MsgBox("Registro inexistente. Desea crear uno nuevo", vbYesNo) = vbYes Then
                '                    LbId.Text = Cobros.MaxId
                'LbId.Text = "+"
                'Else
                'LbId.Text = ""
                'End If

            End If

        End If

        If LbId.Text <> "" Then
            CargaLineasGrid()
        End If

    End Sub
    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()
        PintaPuntoVenta(Albsalida.ASA_idpuntoventa.Valor)
        Lbejer.Text = Albsalida.ASA_ejercicio.Valor
        If Clientes.LeerId(Albsalida.ASA_idcliente.Valor) = True Then
            LbCliente.Text = Clientes.CLI_Nombre.Valor
        End If
        If Moneda.LeerId(Albsalida.ASA_iddivisa.Valor) = True Then
            LbDivisa.Text = Moneda.MON_Nombre.Valor
        End If
        LbValorcambio.Text = Format(VaDec(Albsalida.ASA_valorcambio.Valor), "#0.000000")
        LbFecha.Text = Albsalida.ASA_fechasalida.Valor

        ' llenar el grid
        CargaLineasGrid()
    End Sub



    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)

        If Grid Is ClGrid2 Then

            Grid.LineaBloqueada = False
            If VaInt(Albsalida_gastos.ASG_idfactura.Valor) > 0 Then
                If FacturasRecibidas.LeerId(Albsalida_gastos.ASG_idfactura.Valor) = True Then
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



        If LbId.Text = "+" Then
            LbId.Text = Albsalida.MaxId
            If TxDato_1.Text = "+" Then
                TxDato_1.Text = Albsalida.MaxIdCampa(Val(Lbejer.Text), Val(MiCentro))
            End If
        End If
        If Gr Is ClGrid2 Then
            Albsalida_gastos.ASG_idalbaran.Valor = LbId.Text

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
            If VaDec(LbValorcambio.Text) = 0 Then
                LbValorcambio.Text = "1"
            End If
            Albsalida_gastos.ASG_importegastodivisa.Valor = igasto.ToString
            Albsalida_gastos.ASG_importegastoeuros.Valor = StDec(igasto * VaDec(LbValorcambio.Text))
            Albsalida_gastos.ASG_tipofc.Valor = "C"
        End If



        SqlGrid()
        r = MyBase.GuardarLineas(Gr)


        CalculoTotales()

        Return r

    End Function

    Public Overrides Sub DespuesdeGuardar()

        Agro_CalculoGastosTotalesAlbaran(LbId.Text, VaDec(LbValorcambio.Text))
        'Agro_GeneraGastosLineas(LbId.Text, VaDec(TxDato_7.Text))
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

        CONSULTA2.SelCampo(Albsalida_gastos.ASG_id, "ASG_id")
        CONSULTA2.SelCampo(GastosComercio.GCO_Nombre, "Gasto", Albsalida_gastos.ASG_idgasto)
        CONSULTA2.SelCampo(Albsalida_gastos.ASG_valorgasto, "Valor")
        CONSULTA2.SelCampo(Albsalida_gastos.ASG_tipokbp, "KBP")
        CONSULTA2.SelCampo(Albsalida_gastos.ASG_tipofc, "FC")
        CONSULTA2.SelCampo(Acreedores.ACR_Nombre, "Acreedor", Albsalida_gastos.ASG_idacreedor)
        CONSULTA2.SelCampo(Albsalida_gastos.ASG_importegastoeuros, "ImporteGasto")
        CONSULTA2.WheCampo(Albsalida_gastos.ASG_idalbaran, "=", id)
        CONSULTA2.WheCampo(Albsalida_gastos.ASG_tipofc, "=", "C")

        sql = CONSULTA2.SQL
        sql = sql + " order by ASG_id"

        ClGrid2.Consulta = sql


    End Sub



    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)



        MyBase.BModificar_Click(sender, e)

    End Sub

    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxDato_1.Text = "" And TxDato_1.Enabled = True Then
            TxDato_1.Text = "+"
            Siguiente(0)
        End If
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
        LbPaletsTransporte.Text = ""
        LbIgeneros.Text = ""
        LbDivisa.Text = ""
        LbValorcambio.Text = ""


    End Sub
    Private Sub CalculoTotales()

        Dim sql As String

        sql = "Select sum(ASL_kiloscliente) as kilos, "
        sql = sql + " sum(ASL_palets) as palets, "
        sql = sql + " sum(ASL_bultos) as bultos, "
        sql = sql + " sum(ASL_importegenero) as igenero, "
        sql = sql + " sum(ASL_importegenerovta) as igenerovta, "
        sql = sql + " (SELECT SUM(PAL_PaletsTransporte) FROM AlbSalida_Palets LEFT JOIN Palets ON PAL_IdPalet = ASP_IdPalet WHERE ASP_IdAlbaran = " & LbId.Text & " ) as PaletsTransporte"


        sql = sql + " from albsalida_lineas where ASL_idalbaran=" + LbId.Text

        Dim dt As DataTable = Albsalida_lineas.MiConexion.ConsultaSQL(sql)

        LbKilos.Text = ""
        LbBultos.Text = ""
        LbPalets.Text = ""
        LbPaletsTransporte.Text = ""
        LbIgeneros.Text = ""

        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                LbIgeneros.Text = Format(VaDec(dt.Rows(0)("igenerovta")), "#,###0.00")
                LbKilos.Text = Format(VaDec(dt.Rows(0)("kilos")), "#,###")
                LbBultos.Text = dt.Rows(0)("bultos").ToString
                LbPalets.Text = dt.Rows(0)("palets").ToString
                LbPaletsTransporte.Text = VaInt(dt.Rows(0)("paletstransporte")).ToString

            End If
        End If

        Dim gc As Double = 0

        sql = "Select * from albsalida_gastos where ASG_idalbaran=" + LbId.Text
        Dim dtg As DataTable = Albsalida_gastos.MiConexion.ConsultaSQL(sql)
        If Not dtg Is Nothing Then
            For Each rw In dtg.Rows
                Select Case rw("ASG_tipofc").ToString
                    Case "C"
                        gc = gc + VaDec(rw("ASG_importegastoeuros"))

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
        If GastosComercio.LeerId(TxDato22.Text) = True Then
            If OrigenGastos.LeerId(GastosComercio.GCO_idgrupo.Valor) Then
                BtBuscaAcreedor.CL_Filtro = "TIPO='" + OrigenGastos.ORG_tipo.Valor + "'"
            End If
            If edicion = True Then
                If CbBox2.SelectedValue Is Nothing Then
                    CbBox2.SelectedValue = GastosComercio.GCO_Tipobkp.Valor
                End If
                If TxDato11.Text = "" Then
                    TxDato11.Text = GastosComercio.GCO_idacreedor.Valor
                End If
                If GastosComercio.GCO_Tipogastofc.Valor <> "C" Then
                    MsgBox("Solo se pueden cambiar gastos comerciales")
                    TxDato22.MiError = True
                End If
            End If
        End If

    End Sub



    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If IsNothing(ClGrid2.Grid.DataSource) Then
            MsgBox("No hay datos que imprimir")
            Exit Sub
        Else

            Try

                Application.DoEvents()

                Dim dt As DataTable = CType(ClGrid2.Grid.DataSource, DataTable)
                If dt.Rows.Count <= 0 Then
                    MsgBox("No hay datos que imprimir")
                    Exit Sub
                End If

                Application.DoEvents()

            Catch ex As Exception

            End Try

        End If


        Application.DoEvents()


        If ClGrid2.Grid.IsPrintingAvailable Then


            _LineasDescripcion.Clear()
            _LineasDescripcion.Add("Albarán: " & TxDato_1.Text)
            _LineasDescripcion.Add("Fecha: " & LbFecha.Text)
            _LineasDescripcion.Add("Cliente: " & LbCliente.Text)
            _LineasDescripcion.Add("Bultos: " & LbBultos.Text)
            _LineasDescripcion.Add("Kilos: " & LbKilos.Text)
            _LineasDescripcion.Add("Palets: " & LbPalets.Text)
            _LineasDescripcion.Add("Palets transporte: " & LbPaletsTransporte.Text)
            _LineasDescripcion.Add("Imp. Generos: " & LbIgeneros.Text)
            _LineasDescripcion.Add("Cambio: " & LbValorcambio.Text)
            _LineasDescripcion.Add("Divisa: " & LbDivisa.Text)


            Dim psu As New DevExpress.XtraPrinting.PrinterSettingsUsing
            psu.UsePaperKind = True
            psu.UseMargins = False

            prtSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            prtSystem.PageSettings.AssignDefaultPrinterSettings(psu)


            Dim bErrorMargen As Boolean = True
            Dim imprime As DevExpress.XtraPrinting.PrintableComponentLink = CType(prtSystem.Links(0), DevExpress.XtraPrinting.PrintableComponentLink)
            imprime.Component = ClGrid2.Grid


            imprime.Margins.Top = 50
            imprime.Margins.Right = 50
            imprime.Margins.Bottom = 50
            imprime.Margins.Left = 50


            Application.DoEvents()

            imprime.ShowPreview()

            Application.DoEvents()

        End If

    End Sub


    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea

        Dim margen_izq_parametros As Integer = 10
        Dim base_parametros As Integer = 10

        Dim rec As RectangleF
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Arial", 13, FontStyle.Bold)




        Dim s As New SizeF(0, 0)

        Try

            'Logo
            Try

                Dim fichero_logo As String = "logo.png"

                Select Case MiMaletin.IdEmpresaCTB
                    Case 1
                        fichero_logo = "logo.png"
                    Case Else
                        fichero_logo = "logo_" & MiMaletin.IdEmpresaCTB.ToString & ".png"
                End Select


                If IO.File.Exists(Application.StartupPath & "\" & fichero_logo) Then

                    Dim logo As Image = Image.FromFile(Application.StartupPath & "\" & fichero_logo)
                    rec = New RectangleF(0, 0, logo.Size.Width, logo.Size.Height)
                    e.Graph.DrawImage(logo, rec, DevExpress.XtraPrinting.BorderSide.None, Color.Transparent)
                    s = logo.Size

                    margen_izq_parametros = margen_izq_parametros + logo.Size.Width

                End If

            Catch ex As Exception

            End Try



            'Separación debajo del logo
            e.Graph.DrawEmptyBrick(New RectangleF(0, s.Height, e.Graph.ClientPageSize.Width, 10))

            'Línea debajo del logo
            Dim c As System.Drawing.Color = Color.FromArgb(1, 70, 127)

            Dim p1f As New PointF(0, s.Height + 5)
            Dim p2f As New PointF(e.Graph.ClientPageSize.Width, s.Height + 5)
            e.Graph.DrawLine(p1f, p2f, c, 1)

            Dim base As Single = p1f.Y + 10

            'Nombre del listado
            Dim nombrelistado As String = "LISTADO " & ClGrid2.Grid.Text & " - " & Now.ToString("dd/MM/yyyy")
            If Me.Text.Trim <> "" Then nombrelistado = Me.Text & " - " & Now.ToString("dd/MM/yyyy")

            'Espacio en blanco debajo del nombre del listado
            rec = New RectangleF(0, base, e.Graph.ClientPageSize.Width, 25)
            e.Graph.DrawString(nombrelistado, c, rec, DevExpress.XtraPrinting.BorderSide.None)

            base = base + 25


            If _LineasDescripcion.Count > 0 Then


                e.Graph.Font = New Font("Arial", 9, FontStyle.Regular)


                Dim bp As Integer = base_parametros
                Dim alineacion As DevExpress.Utils.HorzAlignment = DevExpress.Utils.HorzAlignment.Near
                Dim ancho As Integer = e.Graph.ClientPageSize.Width - margen_izq_parametros - 5

                For indice As Integer = 0 To _LineasDescripcion.Count - 1

                    If indice <= 12 Then

                        If indice = 6 Then
                            '2ª columna
                            ancho = ancho / 2
                            margen_izq_parametros = margen_izq_parametros + ancho
                            bp = base_parametros
                            alineacion = DevExpress.Utils.HorzAlignment.Far

                        End If

                        Dim linea As String = _LineasDescripcion(indice)

                        rec = New RectangleF(margen_izq_parametros, bp, ancho, 20)
                        Dim tb As DevExpress.XtraPrinting.TextBrick = e.Graph.DrawString(linea, c, rec, DevExpress.XtraPrinting.BorderSide.None)
                        tb.HorzAlignment = alineacion
                        bp = bp + 15

                    End If


                Next



            End If


            'Último separador en blanco
            e.Graph.DrawEmptyBrick(New RectangleF(0, base, e.Graph.ClientPageSize.Width, 15))



        Catch ex As Exception


        End Try

    End Sub
    
    
 
End Class