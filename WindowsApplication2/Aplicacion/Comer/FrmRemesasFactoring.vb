Imports DevExpress.XtraEditors

Public Class FrmRemesasFactoring
    Inherits FrMantenimiento


    Dim RemesasFactoring As New E_RemesasFactoring(Idusuario, cn)
    Dim RemesasFactoring_Lineas As New E_RemesasFactoring_Lineas(Idusuario, cn)
    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, CnCtb)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Facturas As New E_Facturas(Idusuario, cn)


    Dim Mi_IdCentro As Integer
    Dim _lstAlbaranes As New List(Of String)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Private Sub ParametrosFrm()

        EntidadFrm = RemesasFactoring


        Dim lc As New List(Of Object)
        ListaControles = lc



        ParamTx(TxDato1, RemesasFactoring.REF_Remesa, Lb1, True)
        TxDato1.Autonumerico = True
        LbCentro.CL_ControlAsociado = TxDato1
        LbNomCentro.CL_ControlAsociado = TxDato1
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, RemesasFactoring.REF_Fecha, Lb2, True)
        ParamTx(TxDato3, AlbSalida.ASA_albaran, Lb3, True)

        AsociarGrid(ClGrid1, TxDato3, TxDato3, RemesasFactoring_Lineas)

        'ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        PropiedadesCamposGr(ClGrid1, "RFL_Id", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Albaran", "Albaran", True, 5)
        PropiedadesCamposGr(ClGrid1, "Fecha", "Fecha", True, 6)
        PropiedadesCamposGr(ClGrid1, "CodCli", "CodCli", True, 4)
        PropiedadesCamposGr(ClGrid1, "Cliente", "Cliente", True, 50)
        PropiedadesCamposGr(ClGrid1, "Importe", "Importe", True, 13, True, "#,##0.00", "{0:n2}")
        PropiedadesCamposGr(ClGrid1, "GastosF", "GastosF", True, 13, True, "#,##0.00", "{0:n2}")
        PropiedadesCamposGr(ClGrid1, "Total", "Total", True, 13, True, "#,##0.00", "{0:n2}")


        AsociarControles(TxDato1, BtBusca1, RemesasFactoring.btBusca, EntidadFrm)
        'AsociarControles(TxDato3, BtBusca3, AlbSalida.btBusca, AlbSalida, AlbSalida.ASA_albaran, Nothing)


        tt.SetToolTip(BtNuevo, "Nuevo")
        FiltroEntidad.Add(RemesasFactoring.REF_IdCentro.NombreCampo, MiMaletin.IdCentro.ToString)
        FiltroEntidad.Add(RemesasFactoring.REF_Campa.NombreCampo, MiMaletin.Ejercicio.ToString)


    End Sub


    Public Sub InitAlbaranes(lstAlbaranes As List(Of String))

        _lstAlbaranes = lstAlbaranes

        InicioFrm()


        LbCampa.Text = MiMaletin.Ejercicio.ToString
        Mi_IdCentro = MiMaletin.IdCentro
        PintaCentro(Mi_IdCentro)

        LbTotalRemesa.Text = ""

    End Sub


    Private Sub FrmRemesasFactoring_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        BTaux1.Text = "Imprimir"
        BTaux1.Image = PictureBox1.Image
        BTaux1.Visible = True

        BtAux2.Text = "I.Directa"
        BtAux2.Image = PictureBox2.Image
        BtAux2.Visible = True


        If Not IsNothing(_lstAlbaranes) Then
            If _lstAlbaranes.Count > 0 Then

                TxDato1.Text = "+"
                TxDato1.Validar(True)
                Siguiente(0)

                TxDato2.Text = ""
                TxDato2.Validar(True)
                Siguiente(1)


                If LbId.Text = "+" Then
                    LbId.Text = RemesasFactoring.MaxId
                    If TxDato1.Text = "+" Then
                        TxDato1.Text = RemesasFactoring.MaxIdCampa(VaInt(LbCampa.Text), VaInt(LbCentro.Text))
                    End If
                End If

                RemesasFactoring.REF_IdRemesa.Valor = LbId.Text
                RemesasFactoring.REF_Campa.Valor = LbCampa.Text
                RemesasFactoring.REF_IdCentro.Valor = LbCentro.Text
                RemesasFactoring.REF_Remesa.Valor = TxDato1.Text
                RemesasFactoring.REF_Fecha.Valor = TxDato2.Text
                RemesasFactoring.Insertar()


                For Each IdAlbaran As String In _lstAlbaranes
                    If CompruebaAlbaran(IdAlbaran) Then

                        Dim RemesasFactoring_Lineas As New E_RemesasFactoring_Lineas(Idusuario, cn)
                        RemesasFactoring_Lineas.RFL_Id.Valor = RemesasFactoring_Lineas.MaxId
                        RemesasFactoring_Lineas.RFL_IdRemesa.Valor = LbId.Text
                        RemesasFactoring_Lineas.RFL_IdAlbaran.Valor = IdAlbaran

                        If VaInt(IdAlbaran) > 0 Then

                            Dim sql As String = "SELECT (COALESCE((SELECT SUM(COALESCE(ASL_ImporteGeneroVta,0)) FROM AlbSalida_Lineas WHERE ASL_IdAlbaran = ASA_IdAlbaran),0) + " & vbCrLf
                            sql = sql & " COALESCE((SELECT SUM(COALESCE(VEL_Retira,0) * COALESCE(VEL_PrecioRetira,0)) - SUM(COALESCE(VEL_Entrega,0) * COALESCE(VEL_PrecioEntrega,0)) FROM ValeEnvases_Lineas WHERE VEL_IdVale = ASA_IdValeEnvase),0) - " & vbCrLf
                            sql = sql & " COALESCE((SELECT SUM(COALESCE(ASG_ImporteGastoDivisa,0)) FROM AlbSalida_Gastos WHERE ASG_TipoFC = 'F' AND ASG_IdAlbaran = ASA_IdAlbaran),0)) * COALESCE(ASA_ValorCambio,1) as Total" & vbCrLf
                            sql = sql & " FROM AlbSalida" & vbCrLf
                            sql = sql & " WHERE ASA_IdAlbaran = " & IdAlbaran & vbCrLf

                            Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)
                            If Not IsNothing(dt) Then
                                If dt.Rows.Count > 0 Then
                                    RemesasFactoring_Lineas.RFL_Importe.Valor = VaDec(dt.Rows(0)("Total")).ToString
                                End If
                            End If

                        End If


                        RemesasFactoring_Lineas.Insertar()


                    End If
                Next

                CargaLineasGrid()

            End If
        End If



        _lstAlbaranes.Clear()

        Me.init(LbId.Text)

        HamodificadoGrid = True

    End Sub


    Public Overrides Sub BorraPan()

        If _lstAlbaranes.Count = 0 Then
            MyBase.BorraPan()
            LbTotalRemesa.Text = ""
        End If


        LbCampa.Text = MiMaletin.Ejercicio.ToString
        Mi_IdCentro = MiMaletin.IdCentro
        PintaCentro(Mi_IdCentro)


    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)

        LbFechaSalida.Text = ""
        LbCodCliente.Text = ""
        LbCliente.Text = ""
        LbImporte.Text = ""
        LbGastos.Text = ""
        LbTotalAlb.Text = ""

    End Sub



    Public Overrides Sub ControlClave()
        ' componemos la clave


        If TxDato1.Text = "+" Then
            LbId.Text = "+"
        Else

            Dim i As Integer = RemesasFactoring.LeerRemesa(VaInt(LbCampa.Text), VaInt(LbCentro.Text), VaInt(TxDato1.Text))
            If i > 0 Then
                LbId.Text = i.ToString
            Else
                LbId.Text = "+" 'RemesasFactoring.MaxId
            End If

        End If

        CargaLineasGrid()

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

        'Atencion a las mayusculas !!!!         ' el primer campo siempre la clave 
        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(RemesasFactoring_Lineas.RFL_Id, "RFL_Id")
        CONSULTA.SelCampo(RemesasFactoring_Lineas.RFL_IdAlbaran, "IdAlbaran")
        CONSULTA.SelCampo(AlbSalida.ASA_albaran, "Albaran", RemesasFactoring_Lineas.RFL_IdAlbaran, AlbSalida.ASA_idalbaran)
        CONSULTA.SelCampo(AlbSalida.ASA_fechasalida, "Fecha")
        CONSULTA.SelCampo(AlbSalida.ASA_idcliente, "CodCli")
        CONSULTA.SelCampo(Clientes.CLI_Nombre, "Cliente", AlbSalida.ASA_idcliente, Clientes.CLI_Codigo)
        Dim oImporte As New Cdatos.bdcampo("@(SELECT SUM(ASL_ImporteGeneroVta) FROM AlbSalida_Lineas WHERE ASL_IdAlbaran = ASA_IdAlbaran) * COALESCE(ASA_ValorCambio,1)", Cdatos.TiposCampo.Importe, 18, 2)
        CONSULTA.SelCampo(oImporte, "Importe")
        Dim oGastos As New Cdatos.bdcampo("@(SELECT SUM(ASC_GastoF) FROM AlbSalida_LineasCostes WHERE ASC_IdAlbaran = ASA_IdAlbaran)", Cdatos.TiposCampo.Importe, 18, 2)
        CONSULTA.SelCampo(oGastos, "GastosF")
        Dim strTotal As String = "(COALESCE((SELECT SUM(COALESCE(ASL_ImporteGeneroVta,0)) FROM AlbSalida_Lineas WHERE ASL_IdAlbaran = ASA_IdAlbaran),0) + " & _
        " COALESCE((SELECT SUM(COALESCE(VEL_Retira,0) * COALESCE(VEL_PrecioRetira,0)) - SUM(COALESCE(VEL_Entrega,0) * COALESCE(VEL_PrecioEntrega,0)) FROM ValeEnvases_Lineas WHERE VEL_IdVale = ASA_IdValeEnvase),0) - " & _
        " COALESCE((SELECT SUM(COALESCE(ASG_ImporteGastoDivisa,0)) FROM AlbSalida_Gastos WHERE ASG_TipoFC = 'F' AND ASG_IdAlbaran = ASA_IdAlbaran),0)) * COALESCE(ASA_ValorCambio,1)"
        Dim oTotal As New Cdatos.bdcampo("@" & strTotal, Cdatos.TiposCampo.Importe, 18, 2)
        CONSULTA.SelCampo(oTotal, "Total")
        CONSULTA.WheCampo(RemesasFactoring_Lineas.RFL_IdRemesa, "=", id)
        Dim sql As String = CONSULTA.SQL
        sql = sql + " ORDER BY RFL_Id"

        ClGrid1.Consulta = sql

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)

        LbFechaSalida.Text = ""
        LbCodCliente.Text = ""
        LbCliente.Text = ""
        LbImporte.Text = ""
        LbGastos.Text = ""
        LbTotalAlb.Text = ""

        Dim dt As DataTable = ClGrid1.Grid.DataSource
        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows
                If VaInt(row("RFL_Id")) = VaInt(RemesasFactoring_Lineas.RFL_Id.Valor) Then

                    Dim Fecha As String = ""
                    If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")

                    TxDato3.Text = (row("Albaran").ToString & "").Trim

                    LbFechaSalida.Text = Fecha
                    LbCodCliente.Text = row("CodCli").ToString
                    LbCliente.Text = row("Cliente").ToString

                    LbImporte.Text = VaDec(row("Importe")).ToString("#,##0.00")
                    LbGastos.Text = VaDec(row("GastosF")).ToString("#,##0.00")
                    LbTotalAlb.Text = VaDec(row("Total")).ToString("#,##0.00")

                    Exit For
                End If
            Next
        End If


    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

        Mi_IdCentro = RemesasFactoring.REF_IdCentro.Valor
        LbCampa.Text = RemesasFactoring.REF_Campa.Valor
        PintaCentro(Mi_IdCentro)

        ' llenar el grid
        CargaLineasGrid()

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
        MyBase.Guardar()
    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean

        If LbId.Text = "+" Then
            LbId.Text = RemesasFactoring.MaxId
            If TxDato1.Text = "+" Then
                TxDato1.Text = RemesasFactoring.MaxIdCampa(VaInt(LbCampa.Text), VaInt(LbCentro.Text))
            End If
        End If

        RemesasFactoring.REF_IdRemesa.Valor = LbId.Text
        RemesasFactoring.REF_Campa.Valor = LbCampa.Text
        RemesasFactoring.REF_IdCentro.Valor = LbCentro.Text
        RemesasFactoring.REF_Fecha.Valor = TxDato2.Text


        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
        If AlbSalida.LeerAlb(VaInt(LbCampa.Text), VaInt(LbCentro.Text), TxDato3.Text) Then
            RemesasFactoring_Lineas.RFL_IdAlbaran.Valor = AlbSalida.ASA_idalbaran.Valor
        End If

        RemesasFactoring_Lineas.RFL_IdRemesa.Valor = LbId.Text

        Dim IdAlbaran As String = AlbSalida.ASA_idalbaran.Valor & ""
        If VaInt(IdAlbaran) > 0 Then

            Dim sql As String = "SELECT (COALESCE((SELECT SUM(COALESCE(ASL_ImporteGeneroVta,0)) FROM AlbSalida_Lineas WHERE ASL_IdAlbaran = ASA_IdAlbaran),0) + " & vbCrLf
            sql = sql & " COALESCE((SELECT SUM(COALESCE(VEL_Retira,0) * COALESCE(VEL_PrecioRetira,0)) - SUM(COALESCE(VEL_Entrega,0) * COALESCE(VEL_PrecioEntrega,0)) FROM ValeEnvases_Lineas WHERE VEL_IdVale = ASA_IdValeEnvase),0) - " & vbCrLf
            sql = sql & " COALESCE((SELECT SUM(COALESCE(ASG_ImporteGastoDivisa,0)) FROM AlbSalida_Gastos WHERE ASG_TipoFC = 'F' AND ASG_IdAlbaran = ASA_IdAlbaran),0)) * COALESCE(ASA_ValorCambio,1) as Total" & vbCrLf
            sql = sql & " FROM AlbSalida" & vbCrLf
            sql = sql & " WHERE ASA_IdAlbaran = " & IdAlbaran & vbCrLf

            Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    RemesasFactoring_Lineas.RFL_Importe.Valor = VaDec(dt.Rows(0)("Total")).ToString
                End If
            End If

        End If

        



        SqlGrid()


        



        r = MyBase.GuardarLineas(Gr)
        Return r

    End Function


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()
        'Imprimir?
    End Sub


    Public Overrides Sub DespuesdeGuardarLinea(ByVal gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)
    End Sub


    Public Overrides Sub DespuesdeCargarLineas(ByVal gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)
        LbTotalRemesa.Text = Format(TotalRemesa, "#,###0.00")
    End Sub


    Private Function TotalRemesa() As Double

        Dim total As Decimal = 0

        For indice As Integer = 0 To ClGrid1.GridView.RowCount - 1
            Dim row As DataRow = ClGrid1.GridView.GetDataRow(indice)
            If Not IsNothing(row) Then
                total = total + VaDec(row("Total"))
            End If

        Next


        Return total

    End Function


    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNuevo.Click
        If TxDato1.Text = "" And TxDato1.Enabled = True Then
            TxDato1.Text = "+"
            Siguiente(0)
        End If
    End Sub


    Private Sub TxDato3_Valida(edicion As System.Boolean) Handles TxDato3.Valida

        If edicion Then

            Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
            If AlbSalida.LeerAlb(VaInt(LbCampa.Text), VaInt(LbCentro.Text), VaInt(TxDato3.Text)) Then

                If Not CompruebaAlbaran(AlbSalida) Then
                    TxDato3.MiError = True
                End If

            Else
                MsgBox("El albarán " & TxDato3.Text & " no existe para este centro y esta campaña")
                TxDato3.MiError = True
            End If

        End If


    End Sub


    Private Function CompruebaAlbaran(IdAlbaran As String) As Boolean

        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)

        If AlbSalida.LeerId(IdAlbaran) Then
            Return CompruebaAlbaran(AlbSalida)
        Else
            MsgBox("Error al leer el albarán de salida con Id " & IdAlbaran)
            Return False
        End If


    End Function


    Private Function CompruebaAlbaran(AlbSalida As E_AlbSalida) As Boolean


        'Comprobar que sea de factoring
        If (AlbSalida.ASA_Factoring.Valor & "").Trim.ToUpper <> "S" Then
            MsgBox("El albarán " & TxDato3.Text & " no está marcado como factoring")
            Return False
        End If


        'Comprobar que no esté ya incluído en la remesa
        Dim bEncontrado As Boolean = False
        For indice As Integer = 0 To ClGrid1.GridView.RowCount - 1
            Dim row As DataRow = ClGrid1.GridView.GetDataRow(indice)
            If Not IsNothing(row) Then
                If VaInt(row("IdAlbaran")) = VaInt(AlbSalida.ASA_idalbaran.Valor) Then
                    bEncontrado = True
                    Exit For
                End If
            End If
        Next
        If bEncontrado Then
            MsgBox("El albarán ya está incluido en esta remesa")
            Return False
        End If


        'Comprobar que no esté ya en una remesa
        Dim sql As String = "SELECT REF_Remesa as Remesa, RFL_IdRemesa as IdRemesa, REF_Campa as Campa, REF_IdCentro as CE FROM RemesasFactoring_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN RemesasFactoring ON REF_IdRemesa = RFL_IdRemesa" & vbCrLf
        sql = sql & " WHERE COALESCE(RFL_IdAlbaran,0) > 0 AND RFL_IdAlbaran = " & AlbSalida.ASA_idalbaran.Valor
        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim IdRemesa As Integer = VaInt(dt.Rows(0)("IdRemesa"))
                If IdRemesa <> VaInt(LbId.Text) Then

                    Dim Remesa As String = (dt.Rows(0)("Remesa").ToString & "").Trim
                    Dim Campa As String = VaInt(dt.Rows(0)("Campa")).ToString
                    Dim CE As String = VaInt(dt.Rows(0)("CE")).ToString

                    MsgBox("El albarán " & TxDato3.Text & " ya se encuentra en la remesa " & Remesa & ", centro " & CE & ", campaña " & Campa)
                    Return False

                End If

            End If
        End If


        Return True

    End Function

   
    Private Sub BtBusca3_Click(sender As System.Object, e As System.EventArgs) Handles BtBusca3.Click
        If TxDato3.Enabled Then
            Enlazar()
        End If
    End Sub

    Private Sub Enlazar()

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbSalida.ASA_idalbaran, "IdAlbaran")
        consulta.SelCampo(AlbSalida.ASA_albaran, "Albaran")
        consulta.SelCampo(AlbSalida.ASA_ejercicio, "Ejercicio")
        consulta.SelCampo(AlbSalida.ASA_idcentro, "IdCentro")
        consulta.SelCampo(Centros.Nombre, "CE", AlbSalida.ASA_idcentro, Centros.IdCentro)
        consulta.SelCampo(AlbSalida.ASA_fechasalida, "Fecha")
        consulta.SelCampo(AlbSalida.ASA_idcliente, "Codigo")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", AlbSalida.ASA_idcliente)
        consulta.SelCampo(facturas.FRA_serie, "Serie", AlbSalida.ASA_idfactura)
        consulta.SelCampo(facturas.FRA_factura, "Factura")
        consulta.SelCampo(AlbSalida.ASA_referencia, "RefCliente")
        consulta.SelCampo(AlbSalida.ASA_matriculacamion, "MatCamion")
        consulta.SelCampo(RemesasFactoring_Lineas.RFL_Importe, "TotalRemesa", AlbSalida.ASA_idalbaran, RemesasFactoring_Lineas.RFL_IdAlbaran)
        consulta.SelCampo(RemesasFactoring.REF_Remesa, "Remesa", RemesasFactoring_Lineas.RFL_IdRemesa, RemesasFactoring.REF_IdRemesa)
        consulta.WheCampo(AlbSalida.ASA_Factoring, "=", "S")
        consulta.WheCampo(AlbSalida.ASA_idcentro, "=", LbCentro.Text)
        consulta.WheCampo(AlbSalida.ASA_ejercicio, "=", LbCampa.Text)



        Dim sql As String = consulta.SQL
        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)

        Dim Frb As New FrBuscar
        Frb.InitCol(AlbSalida.btBusca.CL_ParamBusqueda, 0)
        Frb.InitDta(dt, AlbSalida.btBusca.CL_CampoOrden, AlbSalida.btBusca.CL_Filtro, AlbSalida.btBusca.CL_ch1000)
        Frb.Width = 1024
        Frb.ShowDialog()

        If Not IsNothing(BuscarRow) Then
            Dim Albaran As String = BuscarRow("Albaran")
            TxDato3.Text = Albaran
            TxDato3.Validar(True)
            Siguiente(TxDato3.Orden)
        End If


    End Sub


    Private Sub TxDato3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato3.KeyDown
        If e.KeyCode = Keys.F2 Then
            Enlazar()
        End If
    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaInt(LbId.Text) > 0 Then
            ImprimirRemesaFactoring(LbId.Text, TipoImpresion.Preliminar, "", "", "")
        End If

    End Sub

    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaInt(LbId.Text) > 0 Then
            ImprimirRemesaFactoring(LbId.Text, TipoImpresion.ImpresoraPorDefecto, "", "", "")
        End If

    End Sub

End Class