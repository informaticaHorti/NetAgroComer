Imports DevExpress.XtraEditors

Public Class FrmAlbMaterial
    Inherits FrMantenimiento


    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim Mi_IdCentro As Integer
    Dim TipoSujeto As String
    Dim PedidosMaterial As New E_PedidosMaterial(Idusuario, cn)
    Dim PedidosMaterialLineas As New E_PedidosMaterialLineas(Idusuario, cn)
    Dim AlbMaterial As New E_AlbMaterial(Idusuario, cn)
    Dim AlbMaterialLineas As New E_AlbMaterialLineas(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim TarifaMaterialLineas As New E_TarifasMaterialLineas(Idusuario, cn)
    Dim Puntoventa As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim FacturasRecibidas As New E_Facturasrecibidas(Idusuario, cn)

    Dim IdPedidolinea As String



    Dim Centros As New E_centros(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim Envases As New E_Envases(Idusuario, cn)


    Private Sub ParametrosFrm()

        EntidadFrm = AlbMaterial


        Dim lc As New List(Of Object)
        ListaControles = lc



        ParamTx(TxDato_1, AlbMaterial.AMA_Numero, Lb1, True)
        TxDato_1.Autonumerico = True
        LbCentro.CL_ControlAsociado = TxDato_1
        LbNomCentro.CL_ControlAsociado = TxDato_1
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato_2, AlbMaterial.AMA_Fecha, Lb_2, True)
        ParamTx(TxDato_3, AlbMaterial.AMA_Idacreedor, Lb_3, True)
        ParamTx(TxDato_7, AlbMaterial.AMA_referencia, Lb_7, False)
        ParamTx(TxDato_8, AlbMaterial.AMA_idpuntoventa, Lb_8, True)

        ParamTx(TxDato_6, AlbMaterial.AMA_observaciones, Lb_5, False)


        ParamTx(TxDato_10, AlbMaterialLineas.AML_idmaterial, Lb_10, True)
        ParamTx(TxDato_15, AlbMaterialLineas.AML_idmarca, Lb_15, False)

        ParamTx(TxDato_11, AlbMaterialLineas.AML_cantidad, Lb_11, True)
        ParamTx(TxDato_12, AlbMaterialLineas.AML_precio, Lb_12, False)
        ParamTx(TxDato_13, AlbMaterialLineas.AML_descuento, Lb_13, False)
        ParamTx(TxDato_14, AlbMaterialLineas.AML_referencia, Lb_14, False)
        ParamTx(TxDato_16, AlbMaterialLineas.AML_finpedido, Lb_16, False, , , , "SN")



        AsociarGrid(ClGrid1, TxDato_10, TxDato_16, AlbMaterialLineas)

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        PropiedadesCamposGr(ClGrid1, "PML_Idlinea", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 10)
        PropiedadesCamposGr(ClGrid1, "Material", "Material", True, 50)
        PropiedadesCamposGr(ClGrid1, "Marca", "Marca", True, 40)
        PropiedadesCamposGr(ClGrid1, "Cantidad", "Cantidad", True, 10, False, "#0.0000")
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 10, False, "#0.000000")
        PropiedadesCamposGr(ClGrid1, "Importe", "Importe", True, 13, True, "#,##0.00", "{0:n2}")
        PropiedadesCamposGr(ClGrid1, "Dto", "Dto", True, 10, False, "#0.00")


        AsociarControles(TxDato_1, BtBuscaAlbaran, AlbMaterial.btBusca, EntidadFrm)


        AsociarControles(TxDato_3, BtBusca_3, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, Lbnom_3)
        AsociarControles(TxDato_8, BtBusca_8, Puntoventa.btBusca, Puntoventa, Puntoventa.Nombre, Lbnom_8)

        BtBusca_3.CL_Filtro = "TIPO='MA'"
        AsociarControles(TxDato_10, BtBusca_10, Envases.btBusca, Envases, Envases.ENV_Nombre, Lbnom_10)
        AsociarControles(TxDato_15, BtBusca_15, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, Lbnom_15)


        tt.SetToolTip(BtNuevo, "Nuevo")
        FiltroEntidad.Add(AlbMaterial.AMA_Idcentro.NombreCampo, MiMaletin.IdCentro.ToString)
        FiltroEntidad.Add(AlbMaterial.AMA_Campa.NombreCampo, MiMaletin.Ejercicio.ToString)



    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        Dim i As Integer


        If TxDato_1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = AlbMaterial.LeerAlb(CInt(LbCampa.Text), VaInt(LbCentro.Text), CInt(TxDato_1.Text))
            If i > 0 Then
                LbId.Text = i.ToString

                'If VaInt(AlbEntrada.idpuntoventa.Valor) <> VaInt(LbCentro.Text) Then
                ' MsgBox("No coincide el punto de venta")
                ' LbId.Text = ""
                ' TxDato_1.Text = ""
                ' Exit Sub
                'End If

            Else
                LbId.Text = "+" 'AlbEntrada.MaxId
            End If

        End If
        CargaLineasGrid()

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)


        LbPedido.Text = ""
        IdPedidolinea = ""

        Dim i As String = AlbMaterialLineas.AML_idlineapedido.Valor
        If VaInt(i) > 0 Then
            If PedidosMaterialLineas.LeerId(i) = True Then
                If PedidosMaterial.LeerId(PedidosMaterialLineas.PML_idpedido.Valor) = True Then
                    LbPedido.Text = PedidosMaterial.PMA_Numero.Valor
                    IdPedidolinea = i
                End If
            End If
        End If
    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()


        Mi_IdCentro = AlbMaterial.AMA_Idcentro.Valor
        LbCampa.Text = AlbMaterial.AMA_Campa.Valor
        PintaCentro(Mi_IdCentro)
        LbFactura.Text = ""

        If VaInt(AlbMaterial.AMA_idfactura.Valor) > 0 Then
            If FacturasRecibidas.LeerId(AlbMaterial.AMA_idfactura.Valor) = True Then
                LbFactura.Text = FacturasRecibidas.FRR_numerofactura.Valor
            End If
        End If


        ' llenar el grid
        CargaLineasGrid()
        '  LbtotAlb.Text = Format(TotalAlbaran, "#,###0.00")

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean

        'asociar cabecera con lineas
        Dim r As Boolean

        If LbId.Text = "+" Then
            LbId.Text = AlbMaterial.MaxId
            If TxDato_1.Text = "+" Then
                TxDato_1.Text = AlbMaterial.MaxIdCampa(Val(LbCampa.Text), LbCentro.Text)
            End If
        End If
        AlbMaterial.AMA_Idalb.Valor = LbId.Text
        AlbMaterial.AMA_Campa.Valor = LbCampa.Text
        AlbMaterial.AMA_Idcentro.Valor = LbCentro.Text
        AlbMaterialLineas.AML_idlineapedido.Valor = IdPedidolinea


        AlbMaterialLineas.AML_idalb.Valor = LbId.Text
        If VaInt(IdPedidolinea) > 0 Then
            If TxDato_16.Text = "S" Then
                If PedidosMaterialLineas.LeerId(IdPedidolinea) = True Then
                    PedidosMaterialLineas.PML_finalizado.Valor = "S"
                    PedidosMaterialLineas.Actualizar()
                End If
            End If
        End If

        SqlGrid()


        r = MyBase.GuardarLineas(Gr)
        Return r

    End Function


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()

        AlbMaterial.CrearValeEnvasesMaterial(LbId.Text)


        If XtraMessageBox.Show("¿Desea imprimir el albarán?", "Albarán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            C1_ImprimirAlbaranMaterial(LbId.Text, TipoImpresion.ImpresoraPorDefecto)
        End If

    End Sub


    Public Overrides Sub DespuesdeGuardarLinea(ByVal gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)

    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)

        LbPedido.Text = ""
        IdPedidolinea = ""

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbCampa.Text = MiMaletin.Ejercicio.ToString
        Mi_IdCentro = MiMaletin.IdCentro
        PintaCentro(Mi_IdCentro)
        LbtotAlb.Text = ""
        LbFactura.Text = ""

    End Sub


    Public Overrides Sub DespuesdeCargarLineas(ByVal gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)
        LbtotAlb.Text = Format(TotalAlbaran, "#,###0.00")
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


        CONSULTA.SelCampo(AlbMaterialLineas.AML_idlinea, "AML_idlinea")
        CONSULTA.SelCampo(AlbMaterialLineas.AML_idmaterial, "Codigo")
        CONSULTA.SelCampo(Envases.ENV_Nombre, "Material", AlbMaterialLineas.AML_idmaterial)
        CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", AlbMaterialLineas.AML_idmarca)
        CONSULTA.SelCampo(AlbMaterialLineas.AML_cantidad, "Cantidad")
        CONSULTA.SelCampo(AlbMaterialLineas.AML_precio, "Precio")
        Dim oImporte As New Cdatos.bdcampo("@COALESCE(AML_Cantidad,0) * COALESCE(AML_Precio,0)", Cdatos.TiposCampo.Importe, 18, AlbMaterialLineas.AML_precio.Decimales)
        CONSULTA.SelCampo(oImporte, "Importe")
        CONSULTA.SelCampo(AlbMaterialLineas.AML_descuento, "Dto")
        CONSULTA.SelCampo(AlbMaterialLineas.AML_referencia, "Referencia")

        CONSULTA.WheCampo(AlbMaterialLineas.AML_idalb, "=", id)
        sql = CONSULTA.SQL
        sql = sql + " order by aml_idlinea"

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

    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If LbFactura.Text <> "" Then
            MsgBox("no se puede ANULAR el albarán. FACTURADO")
            Exit Sub
        End If

        MyBase.BAnular_Click(sender, e)
    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If LbFactura.Text <> "" Then
            MsgBox("no se puede modificar el albarán. FACTURADO")
            Exit Sub
        End If

        MyBase.BModificar_Click(sender, e)

    End Sub

    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNuevo.Click
        If TxDato_1.Text = "" And TxDato_1.Enabled = True Then
            TxDato_1.Text = "+"
            Siguiente(0)
        End If
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

        AlbMaterial.AMA_importe.Valor = LbtotAlb.Text
        MyBase.Guardar()

    End Sub


    Private Sub PrecioTarifa()

        Dim sql As String = ""
        Dim sql1 As String = ""
        Dim Precio As String = "*"
        Dim Dto As String = ""
        Dim Ref As String = ""

        sql1 = "Select TML_precio as precio,TML_descuento as descuento,TML_referencia as referencia "
        sql1 = sql1 + " from tarifasmateriallineas where TML_idmaterial=" + TxDato_10.Text
        sql1 = sql1 + " AND TML_idacreedor=" + TxDato_3.Text
        If VaInt(TxDato_15.Text) > 0 Then
            sql = sql1 + " and TML_idmarca=" + TxDato_15.Text
        Else
            sql = sql1
        End If
        Dim dt As DataTable = TarifaMaterialLineas.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                Precio = dt.Rows(0)("precio").ToString
                Dto = dt.Rows(0)("descuento").ToString
                Ref = dt.Rows(0)("referencia").ToString
            End If
        End If
        If Precio = "*" Then
            sql = sql1 + " and TML_idmarca=0"
            dt = TarifaMaterialLineas.MiConexion.ConsultaSQL(sql) ' sin marca
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    Precio = dt.Rows(0)("precio").ToString
                    Dto = dt.Rows(0)("descuento").ToString
                    Ref = dt.Rows(0)("referencia").ToString
                End If
            End If

        End If
        If Precio <> "*" Then
            TxDato_12.Text = Precio
            TxDato_13.Text = Dto
            TxDato_14.Text = Ref

        Else

            'Dim Envases As New E_Envases(Idusuario, cn)
            'If VaInt(TxDato_10.Text) > 0 Then
            '    If Envases.LeerId(TxDato_10.Text) Then

            '        If TxDato_12.Text.Trim = "" Then
            '            TxDato_12.Text = VaDec(Envases.ENV_CosteSalida.Valor).ToString("#,##0.000000")
            '        End If

            '    End If
            'End If

        End If



    End Sub

   
    Private Function TotalAlbaran() As Double
        Dim Tot As Double = 0

        For indice As Integer = 0 To ClGrid1.GridView.RowCount - 1
            Dim row As DataRow = ClGrid1.GridView.GetDataRow(indice)
            If Not IsNothing(row) Then


                Dim Importe As Decimal = VaDec(row("Cantidad")) * VaDec(row("Precio"))

                Dim Dto As Decimal = Importe * VaDec(row("Dto")) / 100

                Tot = Tot + Importe - Dto

            End If

        Next
        Return Tot

    End Function

  
    Private Sub CargaPedidos()
        Dim sql As String
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(PedidosMaterialLineas.PML_idlinea, "idlinea")
        consulta.SelCampo(PedidosMaterial.PMA_Numero, "Pedido", PedidosMaterialLineas.PML_idpedido)
        consulta.SelCampo(PedidosMaterial.PMA_referencia, "Referencia")
        consulta.SelCampo(PedidosMaterial.PMA_Fecha, "Fecha")
        consulta.SelCampo(Centros.Nombre, "Centro", PedidosMaterial.PMA_Idcentro)
        consulta.SelCampo(PedidosMaterialLineas.PML_idmaterial, "IdMaterial")
        consulta.SelCampo(Envases.ENV_Nombre, "Material", PedidosMaterialLineas.PML_idmaterial)
        consulta.SelCampo(PedidosMaterialLineas.PML_idmarca, "IdMarca")
        consulta.SelCampo(Marcas.MAR_Nombre, "Marca", PedidosMaterialLineas.PML_idmarca)
        consulta.SelCampo(PedidosMaterialLineas.PML_cantidad, "Cantidad")
        consulta.SelCampo(PedidosMaterialLineas.PML_precio, "Precio")
        consulta.SelCampo(PedidosMaterialLineas.PML_descuento, "Dto")

        consulta.WheCampo(PedidosMaterialLineas.PML_finalizado, "<>", "S")
        consulta.WheCampo(PedidosMaterial.PMA_Idacreedor, "=", TxDato_3.Text)
        sql = consulta.SQL

        Dim lst As New List(Of Parametros)
        Dim dt As DataTable = PedidosMaterialLineas.MiConexion.ConsultaSQL(sql)
        lst.Add(New Parametros("idlinea", False, "", -1))
        lst.Add(New Parametros("Pedido", False, "", 100))
        lst.Add(New Parametros("Referencia", False, "", 150))
        lst.Add(New Parametros("Fecha", False, "", 150))
        lst.Add(New Parametros("Centro", False, "", 150))
        lst.Add(New Parametros("IdMaterial", False, "", -1))
        lst.Add(New Parametros("Material", False, "", 200))
        lst.Add(New Parametros("IdMarca", False, "", -1))
        lst.Add(New Parametros("Marca", False, "", 150))
        lst.Add(New Parametros("Cantidad", False, "{0:n4}", 100))
        lst.Add(New Parametros("Precio", False, "{0:n6}", 100))
        lst.Add(New Parametros("Dto", False, "{0:n2}", 60))

       
        Dim f As New FrConsultaGenerica(dt, lst, "Pedidos pendientes")
        f.ShowDialog()
        If Not RowDePaso Is Nothing Then
            If TxDato_10.Text <> "" Then
                If MsgBox("Desea asociar esta linea de pedido", vbYesNo) = vbNo Then
                    TxDato_10.Focus()
                    Exit Sub
                End If
            End If
            LbPedido.Text = RowDePaso("Pedido").ToString
            IdPedidolinea = RowDePaso("idlinea").ToString
            If PedidosMaterialLineas.LeerId(idpedidolinea) = True Then
                TxDato_10.Text = PedidosMaterialLineas.PML_idmaterial.Valor
                TxDato_15.Text = PedidosMaterialLineas.PML_idmarca.Valor
                TxDato_12.Text = PedidosMaterialLineas.PML_precio.Valor
                TxDato_13.Text = PedidosMaterialLineas.PML_descuento.Valor
                TxDato_14.Text = PedidosMaterialLineas.PML_referencia.Valor
                TxDato_10.Validar(False)
                TxDato_15.Validar(False)
                TxDato_12.Validar(False)
                TxDato_13.Validar(False)
                TxDato_14.Validar(False)
                TxDato_11.Focus()

            End If
        End If


    End Sub
   

    Private Sub TxDato_15_Valida(ByVal edicion As Boolean) Handles TxDato_15.Valida
        If edicion = True Then
            PrecioTarifa()
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TxDato_10.Enabled = True And TxDato_3.Text <> "" Then
            CargaPedidos()
        End If
    End Sub


    Private Sub TxDato_16_Valida(ByVal edicion As Boolean) Handles TxDato_16.Valida
        If edicion = True Then
            If TxDato_16.Text <> "N" Then
                TxDato_16.Text = "S"

            End If
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        C1_ImprimirAlbaranMaterial(LbId.Text, TipoImpresion.Preliminar)

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        C1_ImprimirAlbaranMaterial(LbId.Text, TipoImpresion.ImpresoraPorDefecto)

    End Sub



    Private Sub TxDato_10_Valida(edicion As System.Boolean) Handles TxDato_10.Valida

        If edicion Then


            If VaInt(TxDato_10.Text) > 0 Then

                Dim Envases As New E_Envases(Idusuario, cn)
                If Envases.LeerId(TxDato_10.Text) Then

                    If (Envases.ENV_EnvaseObsoleto.Valor & "").Trim = "S" Then

                        'Obsoleto
                        If XtraMessageBox.Show("Material obsoleto. ¿Está seguro?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                            'Marcar como no obsoleto
                            TxDato_10.MiError = False
                            Envases.ENV_EnvaseObsoleto.Valor = "N"
                            Envases.Actualizar()

                        Else

                            TxDato_10.MiError = True

                        End If


                    End If

                End If

            End If

        End If


    End Sub



End Class