Imports DevExpress.XtraEditors

Public Class FrmReclamacion
    Inherits FrMantenimiento


    Dim Mi_IdCentro As Integer
    Dim Reclama As New E_Reclama(Idusuario, cn)
    Dim Reclama_origen As New E_Reclama_origen(Idusuario, cn)
    Dim Reclama_resolucion As New E_Reclama_resolucion(Idusuario, cn)
    Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
    Dim Albsalida As New E_AlbSalida(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)

    Dim MotivosQueja As New E_MotivosQueja(Idusuario, cn)

    Dim Idlinalb As String



    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))


    Private Sub ParametrosFrm()
        EntidadFrm = Reclama


        Dim lc As New List(Of Object)
        ListaControles = lc



        ParamTx(TxDato_1, Reclama.RCL_Numero, Lb1, True)
        TxDato_1.Autonumerico = True
        LbCentro.CL_ControlAsociado = TxDato_1
        LbNomCentro.CL_ControlAsociado = TxDato_1
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato_2, Reclama.RCL_Fecha, Lb_2, True)
        ParamTx(TxDato_3, Nothing, Lb_3, True)
        ParamTx(TxDato_4, Reclama.RCL_observaciones1, Lb_4, False)
        ParamTx(TxDato_5, Reclama.RCL_observaciones2, Lb_4, False)
        ParamTx(TxDato_6, Reclama.RCL_observaciones3, Lb_4, False)
        ParamTx(TxDato_7, Reclama.RCL_observaciones4, Lb_4, False)
        ParamTx(TxDato_8, Reclama.RCL_idorigen, Lb_8, True)

        ParamTx(TxDato_19, Reclama.RCL_IdMotivoQueja, Lb_19, False)


        ParamTx(TxDato_9, Reclama.RCL_fechaestimada, Lb_9, False)
        ParamTx(TxDato_10, Reclama.RCL_kilosestimados, Lb_10, False)
        ParamTx(TxDato_11, Reclama.RCL_bultosestimados, Lb_11, False)
        ParamTx(TxDato_12, Reclama.RCL_importeestimado, Lb_12, False)


        ParamTx(TxDato_17, Reclama.RCL_fecharesolucion, Lb_17, False)
        ParamTx(TxDato_18, Reclama.RCL_idresolucion, Lb_18, False)


        ParamTx(TxConclusiones1, Reclama.RCL_Conclusiones1, Lb4)
        ParamTx(TxConclusiones2, Reclama.RCL_Conclusiones2, Lb4)
        ParamTx(TxConclusiones3, Reclama.RCL_Conclusiones3, Lb4)
        ParamTx(TxConclusiones4, Reclama.RCL_Conclusiones4, Lb4)

        ParamTx(TxAcciones1, Reclama.RCL_Acciones1, Lb6)
        ParamTx(TxAcciones2, Reclama.RCL_Acciones2, Lb6)
        ParamTx(TxAcciones3, Reclama.RCL_Acciones3, Lb6)
        ParamTx(TxAcciones4, Reclama.RCL_Acciones4, Lb6)


        AsociarControles(TxDato_1, BtBuscaAlbaran, Reclama.btBusca, EntidadFrm)


        AsociarControles(TxDato_3, BtBusca_3, Albsalida.btBusca, Albsalida)

        AsociarControles(TxDato_8, BtBusca_8, Reclama_origen.btBusca, Reclama_origen, Reclama_origen.RCO_Nombre, Lbnom_8)
        AsociarControles(TxDato_19, BtBusca_19, MotivosQueja.btBusca, MotivosQueja, MotivosQueja.MTQ_Nombre, Lbnom_19)
        AsociarControles(TxDato_18, BtBusca_18, Reclama_resolucion.btBusca, Reclama_resolucion, Reclama_resolucion.RCS_Nombre, Lbnom_18)

        BtBusca_3.CL_DevuelveCampo = "Albaran"
        BtBusca_3.CL_EsId = False
 

        tt.SetToolTip(BtNuevo, "Nuevo")
        FiltroEntidad.Add(Reclama.RCL_Idcentro.NombreCampo, MiMaletin.IdCentro.ToString)
        FiltroEntidad.Add(Reclama.RCL_Campa.NombreCampo, MiMaletin.Ejercicio.ToString)



    End Sub


    Private Sub FrmReclamacion_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BTaux1.Text = "Imprimir"
        BTaux1.Image = My.Resources.Action_file_print_16x16_32
        BTaux1.Visible = True

        BtAux2.Text = "I.Directa"
        BtAux2.Image = My.Resources.Action_file_quick_print_16x16_32
        BtAux2.Visible = True

    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        Dim i As Integer


        If TxDato_1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = Reclama.LeerReclama(CInt(LbCampa.Text), VaInt(LbCentro.Text), CInt(TxDato_1.Text))
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

    End Sub
    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()
        Mi_IdCentro = Reclama.RCL_Idcentro.Valor
        LbCampa.Text = Reclama.RCL_Campa.Valor
        PintaCentro(Mi_IdCentro)
        LbLinea.Text = Reclama.RCL_Idlinalb.Valor
        If Val(LbLinea.Text) > 0 Then
            If Albsalida_lineas.LeerId(LbLinea.Text) = True Then
                If Albsalida.LeerId(Albsalida_lineas.ASL_idalbaran.Valor) = True Then
                    TxDato_3.Text = Albsalida.ASA_albaran.Valor
                End If
                PintaGenero()
            End If
        End If

    End Sub

    Public Overrides Sub DespuesdeGuardarLinea(ByVal gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)

    End Sub
    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
        LbCampa.Text = MiMaletin.Ejercicio.ToString
        Mi_IdCentro = MiMaletin.IdCentro
        PintaCentro(Mi_IdCentro)
        LbCliente.Text = ""
        LbLinea.Text = ""
        LbProducto.Text = ""
        LbCategoria.Text = ""




    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        ParametrosFrm()



    End Sub


    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNuevo.Click
        If TxDato_1.Text = "" And TxDato_1.Enabled = True Then
            TxDato_1.Text = "+"
            Siguiente(0)
        End If
    End Sub


    Private Sub TxDato2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

        If LbId.Text = "+" Then
            LbId.Text = Reclama.MaxId
            If TxDato_1.Text = "+" Then
                TxDato_1.Text = Reclama.MaxIdCampa(Val(LbCampa.Text), LbCentro.Text)
            End If
        End If
        Reclama.RCL_Idcentro.Valor = LbCentro.Text
        Reclama.RCL_Campa.Valor = LbCampa.Text
        Reclama.RCL_Idlinalb.Valor = LbLinea.Text
        MyBase.Guardar()

    End Sub


    Private Sub TxDato_3_Valida(edicion As Boolean) Handles TxDato_3.Valida
        If edicion = True Then
            Dim IDALB As Integer = Albsalida.LeerAlb(LbCampa.Text, LbCentro.Text, TxDato_3.Text)
            If IDALB > 0 Then
                If Albsalida.LeerId(IDALB.ToString) = True Then
                    If Clientes.LeerId(Albsalida.ASA_idcliente.Valor) Then
                        LbCliente.Text = Clientes.CLI_Nombre.Valor
                    End If
                End If
                If LbLinea.Text = "" Then
                    CargalineasAlbaran()
                End If
            End If

        End If
    End Sub

    Private Sub BTLinea_Click(sender As System.Object, e As System.EventArgs) Handles BTLinea.Click

        CargalineasAlbaran()

    End Sub
    Private Sub CargalineasAlbaran()
        If TxDato_3.Enabled = False Then Exit Sub
        If TxDato_3.Text = "" Then Exit Sub
        Dim IDALB As Integer = Albsalida.LeerAlb(LbCampa.Text, LbCentro.Text, TxDato_3.Text)

        Dim Sql As String = ""
        Dim Consulta As New Cdatos.E_select
        Consulta.SelCampo(Albsalida_lineas.ASL_idlinea, "idlinea")
        Consulta.SelCampo(GenerosSalida.GES_Nombre, "Genero", Albsalida_lineas.ASL_idgensal)
        Consulta.SelCampo(Albsalida_lineas.ASL_categoria, "Categoria")
        Consulta.SelCampo(Albsalida_lineas.ASL_palets, "Palets")
        Consulta.SelCampo(Albsalida_lineas.ASL_bultos, "Bultos")
        Consulta.SelCampo(Albsalida_lineas.ASL_kiloscliente, "Kilos")
        Consulta.WheCampo(Albsalida_lineas.ASL_idalbaran, "=", IDALB.ToString)
        Sql = Consulta.SQL

        Dim lst As New List(Of Parametros)
        Dim dt As DataTable = Albsalida.MiConexion.ConsultaSQL(Sql)


        lst.Add(New Parametros("idlinea", False, "", -1))
        lst.Add(New Parametros("Genero", False, "", 200))
        lst.Add(New Parametros("Categoria", False, "", 100))
        lst.Add(New Parametros("Palets", True, "", 50))
        lst.Add(New Parametros("Bultos", False, "", 50))
        lst.Add(New Parametros("Kilos", False, "", 80))


        Dim f As New FrConsultaGenerica(dt, lst, "Lineas Albaran")
        f.ShowDialog()
        If Not RowDePaso Is Nothing Then
            LbLinea.Text = RowDePaso("idlinea").ToString
            PintaGenero()
        End If



    End Sub
    Private Sub PintaGenero()
        If Val(LbLinea.Text) = 0 Then Exit Sub
        If Albsalida_lineas.LeerId(LbLinea.Text) = True Then
            If GenerosSalida.LeerId(Albsalida_lineas.ASL_idgensal.Valor) = True Then
                LbProducto.Text = GenerosSalida.GES_Nombre.Valor
            End If
            LbCategoria.Text = Albsalida_lineas.ASL_categoria.Valor
        End If
    End Sub

    Private Sub TxDato_8_Valida(edicion As System.Boolean) Handles TxDato_8.Valida

        If edicion Then

            If VaInt(TxDato_8.Text) > 0 Then
                BtBusca_19.CL_Filtro = "IdOrigen = " & TxDato_8.Text
            Else
                BtBusca_19.CL_Filtro = ""
            End If

        End If

    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirReclamacion(LbId.Text, TipoImpresion.Preliminar)
        End If

    End Sub

    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirReclamacion(LbId.Text, TipoImpresion.ImpresoraPorDefecto)
        End If

    End Sub

End Class