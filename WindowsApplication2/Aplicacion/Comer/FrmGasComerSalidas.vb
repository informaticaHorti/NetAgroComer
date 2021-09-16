Public Class FrmGasComerSalidas


    Inherits FrMantenimiento


    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Albsalida As New E_AlbSalida(Idusuario, cn)
    Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
    Dim Albsalida_gastos As New E_albsalida_gastos(Idusuario, cn)
    Dim GastosComercio As New E_GastosComercio(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim OrigenGastos As New E_OrigenGastos(Idusuario, cn)
    Dim Tipoprecio As String = ""

    Dim Valorespventa As New E_valorespventa(Idusuario, cn)

    Dim FacturasRecibidas As New E_Facturasrecibidas(Idusuario, cn)



    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim MiCentro As String
    'Dim Envases As New E_Envases(Idusuario, cn)





    Private Sub ParametrosFrm()
        EntidadFrm = Acreedores


        Dim lc As New List(Of Object)
        ListaControles = lc



        CampoClave = 0 ' ultimo campo de la clave

        ParamTx(TxAcreedor, Acreedores.ACR_Codigo, LbAcreedor, True)
        TxAcreedor.Autonumerico = False

        ParamTx(TxFechaFac, Nothing, LbFechaFac, True, Cdatos.TiposCampo.Fecha, 0, 10)
        ParamTx(TxNumfac, Nothing, LbNumFAc, True, Cdatos.TiposCampo.Cadena, 20)

        AsociarControles(TxAcreedor, BtAcreedor, Acreedores.btBusca, Acreedores, Acreedores.ACR_Nombre, LbNomAcreedor)



        ParamTx(TxImporte, Albsalida_gastos.ASG_importefactura, LbImporte, False)

        AsociarGrid(ClGrid2, TxImporte, TxImporte, Albsalida_gastos)

        PropiedadesCamposGr(ClGrid2, "ASG_id", "ASG_id", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid2, "Albaran", "Albaran", True, 20)
        PropiedadesCamposGr(ClGrid2, "Fecha", "Fecha", True, 30)
        PropiedadesCamposGr(ClGrid2, "Matricula", "Matricula", True, 40)
        PropiedadesCamposGr(ClGrid2, "Referencia", "Referencia", True, 40)
        PropiedadesCamposGr(ClGrid2, "Cliente", "Cliente", True, 100)
        PropiedadesCamposGr(ClGrid2, "ImpEstimado", "ImpEstimado", True, 30, True, "#0.00")
        PropiedadesCamposGr(ClGrid2, "ImpFactura", "ImpFactura", True, 30, True, "#0.00")

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False






        AsociarControles(TxAcreedor, BtAcreedor, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomAcreedor)

        ' BotonesAvance1.Mientidad = EntidadFrm
        ' BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        ' BotonesAvance1.Formulario = Me

        BAnular.Visible = False



    End Sub



    Public Overrides Sub ControlClave()
        ' componemos la clave

        'Dim i As Integer
        LbId.Text = TxAcreedor.Text


        If LbId.Text <> "" Then
            CargaLineasGrid()
        End If

    End Sub
    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

        ' llenar el grid
        CargaLineasGrid()
    End Sub



    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)

        If Grid Is ClGrid2 Then

            If Albsalida.LeerId(Albsalida_gastos.ASG_idalbaran.Valor) = True Then

                LbAlba.Text = Albsalida.ASA_albaran.Valor
                LbMatricula.Text = Albsalida.ASA_matricularemolque.Valor
                LbReferencia.Text = Albsalida.ASA_referencia.Valor
                LbFechaSal.Text = Albsalida.ASA_fechasalida.Valor
                If Clientes.LeerId(Albsalida.ASA_idcliente.Valor) = True Then
                    LbCliente.Text = Clientes.CLI_Nombre.Valor
                End If
                If GastosComercio.LeerId(Albsalida_gastos.ASG_idgasto.Valor) = True Then
                    LbNomGasto.Text = GastosComercio.GCO_Nombre.Valor
                End If
                LbTipo.Text = Albsalida_gastos.ASG_tipokbp.Valor
            End If

            LbIgasto.Text = Albsalida_gastos.ASG_importegastoeuros.Valor

        End If


        MyBase.Entidad_a_DatosLin(Grid)

    End Sub
    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean
        'Dim igasto As Double



        If Gr Is ClGrid2 Then

            Dim idalb As Integer = Albsalida.LeerAlb(MiMaletin.Ejercicio, MiMaletin.IdCentro, LbAlba.Text)

            Albsalida_gastos.ASG_tipofc.Valor = "C"
            Albsalida_gastos.ASG_suplido.Valor = "0"
            Albsalida_gastos.ASG_idfactura.Valor = "0"

          

        End If



        SqlGrid()
        r = MyBase.GuardarLineas(Gr)


        Return r

    End Function


    Public Overrides Sub DespuesdeGuardarLinea(gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)

    End Sub


    Private Sub GenerarFactura()

        Dim facturasrecibidas As New E_Facturasrecibidas(Idusuario, cn)
        Dim IdFacturaRecibida As Integer = 0

        Dim consulta As New Cdatos.E_select
        Dim DcGasto As New Dictionary(Of String, Decimal)
        Dim CuentaGasto As String = ""

        consulta.SelCampo(Albsalida_gastos.ASG_id, "id")
        consulta.SelCampo(Albsalida_gastos.ASG_idalbaran, "idalbaran")
        consulta.SelCampo(Albsalida.ASA_valorcambio, "valorcambio", Albsalida_gastos.ASG_idalbaran)
        consulta.SelCampo(Albsalida_gastos.ASG_importefactura, "ifactura")
        consulta.SelCampo(GastosComercio.GCO_idgrupo, "idgrupo", Albsalida_gastos.ASG_idgasto)
        consulta.SelCampo(GastosComercio.GCO_Tipobkp, "tipo")
        consulta.SelCampo(OrigenGastos.ORG_cuenta, "Cuenta", GastosComercio.GCO_idgrupo)
        consulta.WheCampo(Albsalida_gastos.ASG_idacreedor, "=", LbId.Text)
        consulta.WheCampo(Albsalida_gastos.ASG_tipofc, "=", "C")
        consulta.WheCampo(Albsalida_gastos.ASG_idfactura, "=", "0")
        Dim sql As String = consulta.SQL
        Dim dt As DataTable = Albsalida.MiConexion.ConsultaSQL(sql)
        Dim TBASE As Decimal = 0
        If Not dt Is Nothing Then
            Dim n As Integer = 0


            For Each rw In dt.Rows
                Dim ifactura As Decimal = VaDec(rw("ifactura"))
                If ifactura <> 0 Then
                    n = n + 1
                    If n = 1 Then
                        Dim nfac As Integer = facturasrecibidas.MaxIdCampa(MiMaletin.IdEmpresaCTB, MiMaletin.Ejercicio, MiMaletin.IdCentro)
                        IdFacturaRecibida = facturasrecibidas.MaxId
                        facturasrecibidas.VaciaEntidad()
                        facturasrecibidas.FRR_Id.Valor = IdFacturaRecibida.ToString
                        facturasrecibidas.FRR_ejercicio.Valor = MiMaletin.Ejercicio.ToString
                        facturasrecibidas.FRR_fechactb.Valor = TxFechaFac.Text
                        facturasrecibidas.FRR_fechafactura.Valor = TxFechaFac.Text
                        facturasrecibidas.FRR_idcentro.Valor = MiMaletin.IdCentro.ToString
                        facturasrecibidas.FRR_IdCuenta.Valor = Acreedores.ACR_IdCuenta.Valor
                        facturasrecibidas.FRR_idproveedor.Valor = TxAcreedor.Text
                        facturasrecibidas.FRR_IdPuntoVenta.Valor = MiMaletin.IdPuntoVenta.ToString
                        facturasrecibidas.FRR_idregimen.Valor = "1"
                        facturasrecibidas.FRR_numerofactura.Valor = TxNumfac.Text
                        facturasrecibidas.FRR_numero.Valor = nfac.ToString
                        facturasrecibidas.FRR_tipofactura.Valor = "GV"

                        If Acreedores.ACR_CuentaGasto.Valor.Trim <> "" Then
                            CuentaGasto = Acreedores.ACR_CuentaGasto.Valor
                        Else
                            CuentaGasto = rw("cuenta").ToString.trim
                        End If
                        If DcGasto.ContainsKey(CuentaGasto) = False Then
                            DcGasto.Add(CuentaGasto, ifactura)
                        Else
                            DcGasto(CuentaGasto) = DcGasto(CuentaGasto) + ifactura
                        End If
                        facturasrecibidas.Insertar()

                    End If
                    ' generar la factura recibidad en el primer registro
                    If Albsalida_gastos.LeerId(rw("id").ToString) = True Then
                        Albsalida_gastos.ASG_importegastoeuros.Valor = ifactura.ToString
                        Albsalida_gastos.ASG_importegastodivisa.Valor = ifactura.ToString
                        Albsalida_gastos.ASG_idfactura.Valor = IdFacturaRecibida


                        Dim kilos As Decimal
                        Dim palets As Decimal
                        Dim bultos As Decimal

                        Dim idalbaran As String = rw("idalbaran").ToString
                        TotalesAlbaran(idalbaran, kilos, bultos, palets)
                        Dim igasto As Decimal = 0

                        Dim TIPO As String = ""
                        Select Case rw("tipo").ToString
                            Case "B"
                                If bultos > 0 Then
                                    igasto = VaDec(ifactura) / bultos
                                    TIPO = "B"
                                End If

                            Case "P"
                                If palets > 0 Then
                                    igasto = VaDec(ifactura) / palets
                                    TIPO = "P"
                                End If
                            Case "K"
                                If kilos > 0 Then
                                    igasto = VaDec(ifactura) / kilos
                                    TIPO = "K"
                                End If

                            Case "%", "I"
                                igasto = VaDec(ifactura)
                                TIPO = "I"

                        End Select


                        Albsalida_gastos.ASG_importegastoeuros.Valor = ifactura.ToString
                        Albsalida_gastos.ASG_valorgasto.Valor = igasto.ToString
                        TBASE = TBASE + ifactura

                        Albsalida_gastos.Actualizar()
                        Dim valorcambio As Decimal = VaDec(rw("valorcambio"))
                        Agro_CalculoGastosTotalesAlbaran(rw("idalbaran").ToString, valorcambio)


                    End If
                End If
            Next
        End If

        If IdFacturaRecibida > 0 Then
            If facturasrecibidas.LeerId(IdFacturaRecibida) = True Then
                facturasrecibidas.FRR_base1.Valor = TBASE.ToString
                Dim c As Int32 = 0

                For Each cta In DcGasto.Keys
                    c = c + 1
                    Select Case c
                        Case 1
                            facturasrecibidas.FRR_ctagasto1.Valor = cta
                            facturasrecibidas.FRR_igasto1.Valor = DcGasto(cta).ToString

                        Case 2
                            facturasrecibidas.FRR_ctagasto2.Valor = cta
                            facturasrecibidas.FRR_igasto2.Valor = DcGasto(cta).ToString

                        Case 3
                            facturasrecibidas.FRR_ctagasto3.Valor = cta
                            facturasrecibidas.FRR_igasto3.Valor = DcGasto(cta).ToString

                        Case 4
                            facturasrecibidas.FRR_ctagasto4.Valor = cta
                            facturasrecibidas.FRR_igasto4.Valor = DcGasto(cta).ToString

                        Case Else
                            Dim i As Decimal = VaDec(facturasrecibidas.FRR_igasto1.Valor) 'LO SUMO AL PRIMERO SI ES MAYOR QUE 4
                            i = i + DcGasto(cta)
                            facturasrecibidas.FRR_igasto1.Valor = i

                    End Select
                

                Next

                facturasrecibidas.Actualizar()
            End If
            Dim frm As New FrmFacRecibidas
            frm.init(IdFacturaRecibida)
            frm.ShowDialog()

        End If


    End Sub

    Private Sub TotalesAlbaran(idalbaran As Integer, ByRef Kilos As Decimal, ByRef bultos As Decimal, ByRef palets As Decimal)


        Dim sql As String

        sql = "Select sum(ASL_kiloscliente) as kilos, "
        sql = sql + " sum(ASL_palets) as palets, "
        sql = sql + " sum(ASL_bultos) as bultos "


        sql = sql + " from albsalida_lineas where ASL_idalbaran=" + idalbaran.ToString

        Dim dt As DataTable = Albsalida_lineas.MiConexion.ConsultaSQL(sql)
        Kilos = 0
        bultos = 0
        palets = 0


        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                Kilos = VaDec(dt.Rows(0)("kilos"))
                bultos = VaDec(dt.Rows(0)("bultos"))
                palets = VaDec(dt.Rows(0)("palets"))

            End If
        End If

    End Sub




    Public Overrides Sub DespuesdeGuardar()

        MyBase.DespuesdeGuardar()
        GenerarFactura()

    End Sub
    Private Sub CargaLineasGrid()
        SqlGrid()
        ClGrid2.Nlinea = -1
        Cargalineas(ClGrid2)
      

    End Sub


    Private Sub SqlGrid()

        Dim sql As String
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable


        Dim CONSULTA2 As New Cdatos.E_select

        CONSULTA2.SelCampo(Albsalida_gastos.ASG_id, "ASG_id")
        CONSULTA2.SelCampo(Albsalida.ASA_albaran, "Albaran", Albsalida_gastos.ASG_idalbaran)
        CONSULTA2.SelCampo(Albsalida.ASA_fechasalida, "Fecha")
        CONSULTA2.SelCampo(Albsalida.ASA_matricularemolque, "Matricula")
        CONSULTA2.SelCampo(Albsalida.ASA_referencia, "Referencia")
        CONSULTA2.SelCampo(Clientes.CLI_Nombre, "Cliente", Albsalida.ASA_idcliente)
        CONSULTA2.SelCampo(Albsalida_gastos.ASG_importegastoeuros, "ImpEstimado")
        CONSULTA2.SelCampo(Albsalida_gastos.ASG_importefactura, "ImpFactura")
        CONSULTA2.WheCampo(Albsalida_gastos.ASG_idacreedor, "=", LbId.Text)
        CONSULTA2.WheCampo(Albsalida_gastos.ASG_tipofc, "=", "C")
        CONSULTA2.WheCampo(Albsalida_gastos.ASG_idfactura, "=", "0")
        CONSULTA2.WheCampo(Albsalida.ASA_IdEmpresa, "=", MiMaletin.IdEmpresaCTB.ToString)
        sql = CONSULTA2.SQL
        sql = sql + " order by ASG_id"

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

  
  

    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)
        LbCliente.Text = ""
        LbMatricula.Text = ""
        LbAlba.Text = ""
        LbNomGasto.Text = ""
        LbReferencia.Text = ""
        LbIgasto.Text = ""
        LbTipo.Text = ""
        LbFechaSal.Text = ""


    End Sub
    Public Overrides Sub BorraPan()

        MyBase.BorraPan()

    

    End Sub
    
    Public Overrides Sub Guardar()
        If MsgBox("Desea generar la factura recibida", vbYesNo) = vbYes Then
            MyBase.Guardar()
        End If
    End Sub



    Private Sub TxDato22_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxGASTO_Valida(ByVal edicion As Boolean)

    End Sub







    Private Sub ClGrid2_Load(sender As System.Object, e As System.EventArgs) Handles ClGrid2.Load

    End Sub


  
    Private Sub BGuardar_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub
End Class