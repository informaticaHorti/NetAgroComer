Imports DevExpress.XtraEditors

Public Class FrmCmr
    Inherits FrMantenimiento


    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim Mi_IdCentro As Integer
    Dim TipoVale As String
    Dim Cmr As New E_Cmr(Idusuario, cn)
    Dim Cmr_lineas As New E_Cmr_lineas(Idusuario, cn)
    Dim Albsalida As New E_AlbSalida(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Domicilios As New E_ClientesDescargas(Idusuario, cn)
    Dim Familias As New E_FamiliasGeneros(Idusuario, cn)



    Dim Centros As New E_centros(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim Envases As New E_Envases(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = Cmr


        Dim lc As New List(Of Object)
        ListaControles = lc



        ParamTx(TxDato_1, Cmr.CMR_Albaran, Lb1, True)
        TxDato_1.Autonumerico = False
        LbCentro.CL_ControlAsociado = TxDato_1
        LbNomCentro.CL_ControlAsociado = TxDato_1
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato_2, Cmr.CMR_FechaSalida, Lb_2, True)
        'ParamTx(LbIdCliente, Cmr.CMR_Idcliente, Lb_3, True)
        'ParamTx(TxDato_4, Cmr.CMR_Iddestino, Lb_4, False)
        ParamTx(TxDato_4, Nothing, Lb_4, False)
        ParamTx(TxDato_5, Cmr.CMR_DocAnexos1, Lb_5, False)
        ParamTx(TxDato_6, Cmr.CMR_DocAnexos2, Lb_5, False)

        ParamTx(TxDato_7, Cmr.CMR_tipodoc, Lb_7, True, , , , "DCT")

        ParamTx(TxDato_13, Cmr.CMR_OD, Lb13, False, , , , "OD")


        ParamTx(TxDato_8, Cmr.CMR_Observaciones, Lb_8, False)
        ParamTx(TxMovilChofer, Albsalida.ASA_movilchofer, LbMovilChofer, False)
        ParamTx(TxNumRegTemp, Albsalida.ASA_numregtemperatura, LbNumRegTemp, False)


        ParamTx(TxDato_9, Cmr.CMR_Instrucciones1, Lb_9, False)
        ParamTx(TxDato_10, Cmr.CMR_Instrucciones2, Lb_9, False)
        ParamTx(TxDato_11, Cmr.CMR_Instrucciones3, Lb_9, False)
        ParamTx(TxDato_12, Cmr.CMR_Instrucciones4, Lb_9, False)

        ParamTx(TxDato_50, Cmr_lineas.CML_Idfamilia, Lb_50, True)
        ParamTx(TxDato_51, Cmr_lineas.CML_idmarca, Lb_51, True)
        ParamTx(TxDato_52, Cmr_lineas.CML_idpalet, Lb_52, True)

        ParamTx(TxDato_53, Cmr_lineas.CML_envase, Lb_53, False)
        ParamTx(TxDato_54, Cmr_lineas.CML_palets, Lb_54, False)
        ParamTx(TxDato_55, Cmr_lineas.CML_bultos, Lb_55, False)
        ParamTx(TxDato_56, Cmr_lineas.CML_kbrutos, Lb_56, False)
        ParamTx(TxDato_57, Cmr_lineas.CML_knetos, Lb_57, False)





        AsociarGrid(ClGrid1, TxDato_50, TxDato_57, Cmr_lineas)

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        PropiedadesCamposGr(ClGrid1, "CML_idcmrlin", "CML_idcmrlin", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Familia", "Familia", True, 50)
        PropiedadesCamposGr(ClGrid1, "Marca", "Marca", True, 30)
        PropiedadesCamposGr(ClGrid1, "Envase", "Envase", True, 30)
        PropiedadesCamposGr(ClGrid1, "Palets", "Palets", True, 10, True)
        PropiedadesCamposGr(ClGrid1, "Bultos", "Bultos", True, 10, True)
        PropiedadesCamposGr(ClGrid1, "Kbrutos", "Kbrutos", True, 10, True)
        PropiedadesCamposGr(ClGrid1, "Knetos", "Knetos", True, 10, True)


        AsociarControles(TxDato_1, BtBuscaAlbaran, Cmr.btBusca, EntidadFrm)
        BtBuscaAlbaran.CL_Filtro = "IdCentro=" + MiMaletin.IdCentro.ToString

        'AsociarControles(TxDato_3, BtBusca_3, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lbnom_3)
        'AsociarControles(TxDato_4, BtBusca_4, Domicilios.btBusca, Domicilios, Domicilios.CLD_Domicilio, Lbnom_4)


        AsociarControles(TxDato_52, BtBusca_52, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb_nom52)
        BtBusca_52.CL_Filtro = "TIPO='P'"
        AsociarControles(TxDato_51, BtBusca_51, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, Lbnom_51)
        AsociarControles(TxDato_50, BtBusca_50, Familias.btBusca, Familias, Familias.FAG_nombre, Lbnom_50)



        FiltroEntidad.Add(Cmr.CMR_Idcentro.NombreCampo, MiMaletin.IdCentro.ToString)
        FiltroEntidad.Add(Cmr.CMR_Campa.NombreCampo, MiMaletin.Ejercicio.ToString)



    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        Dim i As Integer


        If TxDato_1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = Cmr.LeerCmr(CInt(LbCampa.Text), VaInt(LbCentro.Text), CInt(TxDato_1.Text))
            If i > 0 Then
                LbId.Text = i.ToString
            Else
                LbId.Text = "+" 'AlbEntrada.MaxId

                'Albarán nuevo: importamos datos del albarán
                Dim AlbSalida As New E_AlbSalida(Idusuario, cn)

                If AlbSalida.LeerAlb(VaInt(LbCampa.Text), VaInt(LbCentro.Text), VaInt(TxDato_1.Text)) Then
                    ImportarDatosAlbaran(AlbSalida)
                Else
                    'TODO: Si no existe el albarán, permitimos seguir?
                End If




            End If

        End If
        CargaLineasGrid()

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)


        Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)

        Lbnom_4.Text = ""

        Dim IdDomicilio As Integer = ClientesDescargas.LeerDomi(LbIdCliente.Text, VaInt(TxDato_4.Text))
        If ClientesDescargas.LeerId(IdDomicilio) Then
            Lbnom_4.Text = ClientesDescargas.CLD_Domicilio.Valor
        End If



    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

        Mi_IdCentro = Cmr.CMR_Idcentro.Valor
        LbCampa.Text = Cmr.CMR_Campa.Valor
        PintaCentro(Mi_IdCentro)

        TxMovilChofer.Text = ""
        TxNumRegTemp.Text = ""


        Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
        If VaInt(Cmr.CMR_Iddestino.Valor) > 0 Then
            If ClientesDescargas.LeerId(Cmr.CMR_Iddestino.Valor) Then
                TxDato_4.Text = ClientesDescargas.CLD_numero.Valor
            End If
        End If


        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
        If AlbSalida.LeerId(TxDato_1.Text.Trim) = True Then

            TxMovilChofer.Text = AlbSalida.ASA_movilchofer.Valor & ""
            TxNumRegTemp.Text = AlbSalida.ASA_numregtemperatura.Valor & ""

        End If

        ' llenar el grid
        CargaLineasGrid()
        '  LbtotAlb.Text = Format(TotalAlbaran, "#,###0.00")

    End Sub

    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean

        If LbId.Text = "+" Then
            LbId.Text = Cmr.MaxId
        End If
        Cmr.CMR_IdCmr.Valor = LbId.Text
        Cmr.CMR_Campa.Valor = LbCampa.Text
        Cmr.CMR_Idcentro.Valor = LbCentro.Text


        Cmr_lineas.CML_Idcmr.Valor = LbId.Text
        SqlGrid()
        r = MyBase.GuardarLineas(Gr)
        Return r
    End Function

    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()



        If NuevoRegistro Then
            ImprimirDocumento(False)
        Else
            If XtraMessageBox.Show("¿Desea imprimir el Documento?", "CMR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ImprimirDocumento(False)
            End If
        End If

    End Sub
    Public Overrides Sub DespuesdeGuardarLinea(ByVal gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)

    End Sub
    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)

    End Sub
    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
        LbCampa.Text = MiMaletin.Ejercicio.ToString
        Mi_IdCentro = MiMaletin.IdCentro
        PintaCentro(Mi_IdCentro)


    End Sub

    Public Overrides Sub DespuesdeCargarLineas(ByVal gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)
    End Sub
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
        Dim sql As String
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim CONSULTA As New Cdatos.E_select


        CONSULTA.SelCampo(Cmr_lineas.CML_IdCmrlin, "CML_idcmrlin")
        CONSULTA.SelCampo(Familias.FAG_nombre, "Familia", Cmr_lineas.CML_Idfamilia)
        CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", Cmr_lineas.CML_idmarca)
        CONSULTA.SelCampo(Cmr_lineas.CML_envase, "Envase")
        CONSULTA.SelCampo(Cmr_lineas.CML_palets, "Palets")
        CONSULTA.SelCampo(Cmr_lineas.CML_bultos, "Bultos")
        CONSULTA.SelCampo(Cmr_lineas.CML_kbrutos, "Kbrutos")
        CONSULTA.SelCampo(Cmr_lineas.CML_knetos, "Knetos")
        CONSULTA.WheCampo(Cmr_lineas.CML_Idcmr, "=", id)

        sql = CONSULTA.SQL
        sql = sql + " order by cml_idcmrlin"

        ClGrid1.Consulta = sql

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()

        BTaux1.Visible = True
        BTaux1.Text = "Imprimir"
        BTaux1.Image = PictureBox1.Image

        BtAux2.Visible = True
        BtAux2.Text = "I.Directa"
        BtAux2.Image = PictureBox2.Image

        BtAux3.Visible = True
        BtAux3.Text = "Imp.Etiqueta"
        BtAux3.Width = 90
        BtAux3.Image = My.Resources._1464991114_barcode


    End Sub

    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MyBase.BAnular_Click(sender, e)
    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString Then
        ' MsgBox("no se puede modificar el albarán")
        ' Exit Sub
        ' End If

        MyBase.BModificar_Click(sender, e)

    End Sub

    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxDato_1.Text = "" And TxDato_1.Enabled = True Then
            TxDato_1.Text = "+"
            Siguiente(0)
        End If
    End Sub


    Private Sub TxDato2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_56.TextChanged

    End Sub

    Private Sub PintaCentro(ByVal Centro As Integer)

        LbCentro.Text = Centro.ToString
        If Centros.LeerId(LbCentro.Text) = True Then
            LbNomCentro.Text = Centros.Nombre.Valor
        Else
            LbNomCentro.Text = ""
        End If


    End Sub

    Public Overrides Sub Guardar()

        Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
        Dim IdDestino As Integer = ClientesDescargas.LeerDomi(VaInt(LbIdCliente.Text).ToString, VaInt(TxDato_4.Text).ToString)
        Cmr.CMR_Iddestino.Valor = IdDestino.ToString
        Cmr.CMR_Idcliente.Valor = LbIdCliente.Text


        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
        If AlbSalida.LeerId(TxDato_1.Text.Trim) = True Then
            AlbSalida.ASA_movilchofer.Valor = TxMovilChofer.Text.Trim
            AlbSalida.ASA_numregtemperatura.Valor = TxNumRegTemp.Text.Trim
            AlbSalida.Actualizar()
        End If

        MyBase.Guardar()

    End Sub


    

    'Private Sub TxDato_3_Valida(ByVal edicion As Boolean)
    '    BtBusca_4.CL_Filtro = "idcliente=" + LbIdCliente.Text
    'End Sub


    Private Sub ImportarDatosAlbaran(AlbSalida As E_AlbSalida)

        If XtraMessageBox.Show("¿Desea importar los datos del albarán de salida", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim IdDomicilio As Integer = 0
            Dim OD As String = ""

            TxDato_7.Text = "C"

            Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
            Dim Pedidos As New E_Pedidos(Idusuario, cn)
            If Pedidos.LeerId(AlbSalida.ASA_idpedido.Valor) Then

                IdDomicilio = VaInt(Pedidos.PED_iddestino.Valor)

                Dim TiposPorte As New E_TiposPorte(Idusuario, cn)
                If VaInt(Pedidos.PED_idporte.Valor) Then
                    If TiposPorte.LeerId(Pedidos.PED_idporte.Valor) Then
                        OD = (TiposPorte.TPO_OrigenDestino.Valor).Trim.ToUpper
                        TxDato_13.Text = OD
                    End If
                End If

            End If


            'Cabecera
            If VaInt(AlbSalida.ASA_idcliente.Valor) > 0 Then LbIdCliente.Text = AlbSalida.ASA_idcliente.Valor
            If IdDomicilio > 0 Then
                If ClientesDescargas.LeerId(IdDomicilio) Then
                    TxDato_4.Text = ClientesDescargas.CLD_numero.Valor
                End If
            End If
            If VaDate(AlbSalida.ASA_fechasalida.Valor) <> VaDate("") Then
                TxDato_2.Text = VaDate(AlbSalida.ASA_fechasalida.Valor).ToString("dd/MM/yyyy")
                TxDato_2.Validar(True)
            End If
            'LbIdCliente.Validar(True)
            TxDato_4.Validar(True)



            Dim IdCMR As String = CrearCMRDesdeAlbaran(AlbSalida)

            LbId.Text = IdCMR
            Modificando = True



            'Cargar grid de nuevo
            SqlGrid()
            ClGrid1.Nlinea = -1
            Cargalineas(ClGrid1)

            'TODO: Hay que marcar como 'modificando' para que no permita salir sin guardar o borrar





        End If

    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        ImprimirDocumento(True)

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        ImprimirDocumento(False)

    End Sub


    Private Sub ImprimirDocumento(bPreliminar As Boolean)

        Dim IdCMR As String = LbId.Text
        If VaInt(IdCMR) > 0 Then

            Dim ImpresoraCMRNacional As String = ""
            Dim ImpresoraCMRInterNacional As String = ""
            Dim ImpresoraEtiquetasCMR As String = ""

            Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)

            If ValoresUsuario.LeerId(Idusuario) Then
                ImpresoraCMRNacional = ValoresUsuario.VUS_ImpresoraCMRNacional.Valor
                ImpresoraCMRInterNacional = ValoresUsuario.VUS_ImpresoraCMRInternacional.Valor
                ImpresoraEtiquetasCMR = (ValoresUsuario.VUS_ImpresoraEtiquetaCMR.Valor & "").Trim
            End If


            If TxDato_7.Text = "C" Then

                'Internacional
                If bPreliminar Then
                    C1_ImprimirCMR_InterNacional(IdCMR, TipoImpresion.Preliminar, ChkImprimirEtiqueta.Checked)
                Else
                    C1_ImprimirCMR_InterNacional(IdCMR, TipoImpresion.ImpresoraPorDefecto, ChkImprimirEtiqueta.Checked)
                End If

            ElseIf TxDato_7.Text = "D" Then

                'Nacional
                If bPreliminar Then
                    C1_ImprimirDCTMC(IdCMR, TipoDCTMC.CMR, TipoImpresion.Preliminar)
                Else
                    C1_ImprimirDCTMC(IdCMR, TipoDCTMC.CMR, TipoImpresion.ImpresoraPorDefecto)
                End If

            End If
        End If

    End Sub


    Private Sub TxDato_7_Valida(edicion As System.Boolean) Handles TxDato_7.Valida
        If edicion Then
            If TxDato_7.Text.Trim = "" Then
                TxDato_7.Text = "C"
            End If
        End If
    End Sub


    Private Sub TxDato_4_Valida(ByVal edicion As System.Boolean) Handles TxDato_4.Valida

        Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)


        If edicion Then

            TxDato_4.MiError = False

            If TxDato_4.Text.Trim = "" Then

                Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
                Dim IdAlbaran As Integer = AlbSalida.LeerAlb(VaInt(LbCampa.Text), VaInt(LbCentro.Text), VaInt(Cmr.CMR_Albaran.Valor))

                If IdAlbaran > 0 Then

                    Dim Pedidos As New E_Pedidos(Idusuario, cn)
                    Dim IdPedido As Integer = VaInt(AlbSalida.ASA_idpedido.Valor)

                    If Pedidos.LeerId(IdPedido) Then

                        Dim IdDomicilio As Integer = VaInt(Pedidos.PED_iddestino.Valor)

                        If IdDomicilio > 0 Then
                            If ClientesDescargas.LeerId(IdDomicilio) Then
                                TxDato_4.Text = ClientesDescargas.CLD_numero.Valor
                                TxDato_4.Validar(True)
                            End If
                        End If

                    End If

                End If

            Else

                Lbnom_4.Text = ""


                Dim IdDomicilio As Integer = ClientesDescargas.LeerDomi(LbIdCliente.Text, VaInt(TxDato_4.Text))
                If ClientesDescargas.LeerId(IdDomicilio) Then
                    Lbnom_4.Text = ClientesDescargas.CLD_Domicilio.Valor
                Else
                    TxDato_4.MiError = True
                    MsgBox("El domicilio de descarga no es de este cliente")
                End If

            End If

        End If

    End Sub

    Private Sub TxDato_13_Valida(ByVal edicion As System.Boolean) Handles TxDato_13.Valida

        If edicion Then

            If TxDato_13.Text.Trim = "" Then

                Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
                Dim IdAlbaran As Integer = AlbSalida.LeerAlb(VaInt(LbCampa.Text), VaInt(LbCentro.Text), VaInt(Cmr.CMR_Albaran.Valor))

                If VaInt(IdAlbaran) > 0 Then

                    Dim Pedidos As New E_Pedidos(Idusuario, cn)
                    Dim IdPedido As Integer = VaInt(AlbSalida.ASA_idpedido.Valor)

                    If Pedidos.LeerId(IdPedido) Then

                        Dim TiposPorte As New E_TiposPorte(Idusuario, cn)
                        Dim IdPorte As Integer = VaInt(Pedidos.PED_idporte.Valor)

                        If IdPorte > 0 Then
                            If TiposPorte.LeerId(IdPorte) Then
                                TxDato_13.Text = TiposPorte.TPO_OrigenDestino.Valor
                                TxDato_13.Validar(True)
                            End If
                        End If

                    End If

                End If

            End If


        End If

    End Sub


    Private Sub TxDato_1_Valida(edicion As System.Boolean) Handles TxDato_1.Valida

        'If edicion Then
        If Not TxDato_1.MiError And VaDec(TxDato_1.Text) > 0 And VaInt(LbCentro.Text) > 0 Then


            Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
            If AlbSalida.LeerAlb(VaInt(LbCampa.Text), VaInt(LbCentro.Text), VaInt(TxDato_1.Text)) Then

                If VaInt(AlbSalida.ASA_idcliente.Valor) > 0 Then

                    LbIdCliente.Text = AlbSalida.ASA_idcliente.Valor
                    Dim Clientes As New E_Clientes(Idusuario, cn)
                    If Clientes.LeerId(AlbSalida.ASA_idcliente.Valor) Then
                        LbNom_Cliente.Text = Clientes.CLI_Nombre.Valor
                    End If


                End If

            End If

        End If
        'End If

    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        If TxDato_4.Enabled Then
            EnlazarDomicilio()
        End If

    End Sub

    Private Sub TxDato_4_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato_4.KeyDown
        If e.KeyCode = Keys.F2 Then
            EnlazarDomicilio()
        End If
    End Sub

    Private Sub EnlazarDomicilio()

        Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
        Dim v As String = ""


        With ClientesDescargas.btBusca

            .CL_Filtro = "IdCliente = " & VaInt(LbIdCliente.Text).ToString

            Dim sql As String = .CL_ConsultaSql
            Dim dt As DataTable = .CL_Entidad.MiConexion.ConsultaSQL(sql)

            Dim FRb As New FrBuscar
            FRb.InitCol(.CL_ParamBusqueda, .CL_Ancho)
            FRb.InitDta(dt, .CL_CampoOrden, .CL_Filtro, .CL_ch1000)
            FRb.ShowDialog()

            If Not BuscarRow Is Nothing Then
                v = BuscarRow(.CL_DevuelveCampo)
            End If

        End With


        TxDato_4.Text = v
        Siguiente(TxDato_4.Orden)


    End Sub


    Public Overrides Sub BotonAuxiliar3()
        MyBase.BotonAuxiliar3()

        If VaInt(LbId.Text) > 0 Then

            Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)
            If ValoresUsuario.LeerId(Idusuario.ToString) Then

                Dim Impresora As String = (ValoresUsuario.VUS_ImpresoraEtiquetaCMR.Valor & "").Trim
                If Impresora <> "" Then

                    Dim Ejercicio As String = VaInt(Cmr.CMR_Campa.Valor).ToString
                    Dim IdCentro As String = VaInt(Cmr.CMR_Idcentro.Valor).ToString
                    Dim Albaran As String = VaInt(Cmr.CMR_Albaran.Valor).ToString


                    'C1_ImprimirEtiquetaCMR(Ejercicio, IdCentro, Albaran, "", TipoImpresion.Preliminar)
                    C1_ImprimirEtiquetaCMR(Ejercicio, IdCentro, Albaran, Impresora, TipoImpresion.ImpresoraSeleccionada)

                End If

            End If

        End If

        

    End Sub

End Class

