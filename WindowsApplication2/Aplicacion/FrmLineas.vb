Public Class FrmLineas
    Inherits FrMantenimiento



    Dim Lineas As New E_Lineas(Idusuario, cn)
    Dim Lineas_producto As New E_Lineas_producto(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim LineasCalidad As New E_LineasCalidad(Idusuario, cnCalidad)

    Dim CargandoSubfamilia As Boolean



    Private Sub ParametrosFrm()
        EntidadFrm = Lineas



        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Lineas.LIN_Idlinea, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, Lineas.LIN_Nombre, Lb2)
        ParamTx(TxDato3, Lineas.LIN_Idcentro, Lb3)
        ParamTx(TxDato4, Lineas.LIN_ResponsableCalidad, Lb4)
        ParamTx(TxDato5, Lineas.LIN_ResponsableLimpieza, Lb5)
        ParamChk(chkSoloPrecalibrado, Lineas.LIN_SoloPrecalibradoSN, "S", "N")
        ParamChk(ChkPermitirPrecalibrado, Lineas.LIN_PermitirPrecalibradoSN, "S", "N")
        ParamTx(TxLineaCalidad, Lineas.LIN_IdLineaCalidad, LbLineaCalidad)


        AsociarControles(TxDato1, BtBuscaMarca, Lineas.btBusca, EntidadFrm)
        AsociarControles(TxDato3, BtBuscaCentro, PuntoVenta.btBusca, PuntoVenta, PuntoVenta.Nombre, LbCentro)
        AsociarControles(TxLineaCalidad, BtBuscaLineaCalidad, LineasCalidad.btBusca, LineasCalidad, LineasCalidad.LIN_NOMBRE, LbNombreLineaCalidad)


        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text


    End Sub


    Public Overrides Sub Guardar()
        MyBase.Guardar()
    End Sub


    
    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()
        CargaChSubFamila()
    End Sub

    Public Overrides Sub BorraPan()


        MyBase.BorraPan()
        CargaChSubFamila()
    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()
        Me.MinimumSize = Me.Size

    End Sub


   

    Private Sub FrmMarcas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    

    Private Sub CargaChSubFamila()

        Dim dt As New DataTable
        Dim sql As String
        Dim subfamilias As New E_Subfamilias(Idusuario, cn)


        Dim Consulta2 As New Cdatos.E_select


        Consulta2.SelCampo(subfamilias.SFA_id, "Codigo")
        Consulta2.SelCampo(subfamilias.SFA_nombre, "Nombre")


        sql = Consulta2.SQL + " order by sfa_idfamilia"
        dt = subfamilias.MiConexion.ConsultaSQL(sql)

        ChSubFamilias.DataSource = dt
        ChSubFamilias.ValueMember = "Codigo"
        ChSubFamilias.DisplayMember = "Nombre"


        ChSubFamilias.CheckOnClick = True

        CargandoSubfamilia = True
        If Val(LbId.Text) > 0 Then
            For indice As Integer = 0 To ChSubFamilias.ItemCount - 1


                Dim row As DataRowView = ChSubFamilias.GetItem(indice)
                Dim a As String = row("Codigo").ToString
                If Lineas_producto.LeerLineaProducto(LbId.Text, a) > 0 Then
                    ChSubFamilias.SetItemChecked(indice, True)
                End If
            Next
        End If
        CargandoSubfamilia = False


    End Sub

    Private Sub GuardarChSubfamilia(Codigo As String, V As Boolean)
        If CargandoSubfamilia = True Then Exit Sub

        If V = False Then
            BorraChSubfamilia(Codigo)
        Else

            Lineas_producto.VaciaEntidad()
            Dim id As Integer = Lineas_producto.MaxId
            Lineas_producto.LNP_Id.Valor = id.ToString
            Lineas_producto.LNP_idlinea.Valor = LbId.Text
            Lineas_producto.LNP_idsubfamilia.Valor = Codigo
            Lineas_producto.Insertar()

        End If

    End Sub

    Private Sub BorraChSubfamilia(codigo)
        If Val(LbId.Text) > 0 Then
            Dim sql As String = "delete from lineas_producto where lnp_idlinea=" + LbId.Text + " and lnp_idsubfamilia=" + codigo
            Lineas_producto.MiConexion.ConsultaSQL(sql)
        End If

    End Sub

    Private Sub ChSubFamilias_ItemCheck(sender As Object, e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles ChSubFamilias.ItemCheck
        Dim v As Boolean
        If e.State = CheckState.Checked Then
            v = True
        Else
            v = False
        End If
        Dim C As String = ChSubFamilias.GetItemValue(e.Index)
        GuardarChSubfamilia(C, v)
    End Sub


    Private Sub chkSoloPrecalibrado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSoloPrecalibrado.CheckedChanged
        If chkSoloPrecalibrado.Checked Then
            ChkPermitirPrecalibrado.Checked = False
        End If
    End Sub


    Private Sub ChkPermitirPrecalibrado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkPermitirPrecalibrado.CheckedChanged
        If ChkPermitirPrecalibrado.Checked Then
            chkSoloPrecalibrado.Checked = False
        End If
    End Sub
End Class