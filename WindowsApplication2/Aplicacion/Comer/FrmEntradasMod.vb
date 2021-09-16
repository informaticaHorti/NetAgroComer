Imports DevExpress.XtraEditors

Public Class FrmEntradasMod

    Inherits FrMantenimiento


    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim AlbEntrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim AlbEntrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)
    Dim AlbEntrada_lineaskilos As New E_AlbEntrada_lineaskilos(Idusuario, cn)
    Dim AlbEntrada_gastos As New E_albentrada_gastos(Idusuario, cn)
    Dim PventaUsuario As New E_PventaUsuario(Idusuario, cn)

    Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim AgricultorGastos As New E_AgricultorGastos(Idusuario, cn)
    Dim Tiposdegastoagri As New E_TiposdeGastoAgri(Idusuario, cn)
    Dim Origengastos As New E_OrigenGastos(Idusuario, cn)
    Dim Medianeria As New E_Medianeria(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim Confecenvase As New E_ConfecEnvase(Idusuario, cn)
    Dim Confecpalet As New E_ConfecPalet(Idusuario, cn)
    Dim FamiliasCategorias As New E_FamiliasCategorias(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)

    Dim Lotes As New E_Lotes(Idusuario, cn)

    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Subfamilias As New E_Subfamilias(Idusuario, cn)
    Dim FamiliasDescuentos As New E_FamiliasDescuentos(Idusuario, cn)
    Dim Acreedores As New E_Acreedores(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)

    Dim Idmuestreo As Integer



    Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    'Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)
    Dim Mi_idcentro As String
    Dim Mi_idcentroRecogida As String

    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Idtarifa As Integer
    Dim DtoMerma As Double



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


        ParametrosFrm()


    End Sub


    Private Sub ParametrosFrm()

        EntidadFrm = AlbEntrada



        Dim lc As New List(Of Object)
        ListaControles = lc


        ParamTx(TxDato1, AlbEntrada.AEN_albaran, Lb1, True)
        TxDato1.Autonumerico = True
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato6, AlbEntrada.AEN_Fecha, Lb9, True)
        
        ParamTx(TxDato20, AlbEntrada.AEN_referencia, Lb60, False)
        ParamTx(TxDato3, AlbEntrada.AEN_IdAgricultor, Lb3, True)
        ParamTx(TxDato16, AlbEntrada.AEN_TipoFCS, Lb56, True, , , , "FCS")
        ParamTx(TxConf, AlbEntrada.AEN_EntradaConfeccionada, Lb2, True, , , , "SN")

        ParamTx(TxDato23, AlbEntrada.AEN_matricula, Lb64, False)
        ParamTx(TxDato18, AlbEntrada.AEN_IdMedianeria, Lb21, False)

        Lb3.Text = "Proveedor."


        ParamTx(TxIdGasto1, Nothing, Lb27, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxVgasto1, Nothing, Lb28, False, Cdatos.TiposCampo.Importe, 5, 18)
        ParamTx(TxAcreedor1, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)

        ParamTx(TxIdGasto2, Nothing, Lb27, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxVgasto2, Nothing, Lb28, False, Cdatos.TiposCampo.Importe, 5, 18)
        ParamTx(TxAcreedor2, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)

        ParamTx(TxIdGasto3, Nothing, Lb27, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)

        ParamTx(TxVgasto3, Nothing, Lb28, False, Cdatos.TiposCampo.Importe, 5, 18)
        ParamTx(TxAcreedor3, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)

        ParamTx(TxIdGasto4, Nothing, Lb27, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxVgasto4, Nothing, Lb28, False, Cdatos.TiposCampo.Importe, 5, 18)
        ParamTx(TxAcreedor4, Nothing, Nothing, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)


        'Género no es obligatorio, siempre y cuando pongamos el origen
        'ParamTx(TxDato4, AlbEntrada_lineas.AEL_idgenero, Lb5, True)
        ' ParamTx(LbPartida, AlbEntrada_lineas.AEL_muestreo, Lb30, True)



        AsociarControles(TxDato1, BtBuscaAlbaran, AlbEntrada.btBusca, EntidadFrm)
        AsociarControles(TxDato3, BtBuscaAgricultor, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lb19)
        AsociarControles(TxDato18, BtBuscaMedianero, Medianeria.btBusca, Medianeria, Medianeria.MED_Nombre, LbNomMedianero)

        AsociarControles(TxIdGasto1, BtBuscaGasto1, Tiposdegastoagri.btBusca, Tiposdegastoagri, Tiposdegastoagri.TGA_Nombre, LbNomGasto1)
        AsociarControles(TxIdGasto2, BtBuscaGasto2, Tiposdegastoagri.btBusca, Tiposdegastoagri, Tiposdegastoagri.TGA_Nombre, LbNomGasto2)
        AsociarControles(TxIdGasto3, BtBuscaGasto3, Tiposdegastoagri.btBusca, Tiposdegastoagri, Tiposdegastoagri.TGA_Nombre, LbNomGasto3)
        AsociarControles(TxIdGasto4, BtBuscaGasto4, Tiposdegastoagri.btBusca, Tiposdegastoagri, Tiposdegastoagri.TGA_Nombre, LbNomGasto4)

        AsociarControles(TxAcreedor1, BtBuscaAcreedor1, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomAcreedor1)
        AsociarControles(TxAcreedor2, BtBuscaAcreedor2, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomAcreedor2)
        AsociarControles(TxAcreedor3, BtBuscaAcreedor3, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomAcreedor3)
        AsociarControles(TxAcreedor4, BtBuscaAcreedor4, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomAcreedor4)




        tt.SetToolTip(BtDetallesAlbaran, "Ver detalles albarán")

        FiltroEntidad.Add(AlbEntrada.AEN_IdCentro.NombreCampo, MiMaletin.IdCentro.ToString)
        FiltroEntidad.Add(AlbEntrada.AEN_Campa.NombreCampo, MiMaletin.Ejercicio.ToString)

        BtBuscaAlbaran.CL_Filtro = Pventausuario.FiltroPventaGrid("PV", "")
        BtBuscaAlbaran.CL_xCentro = False
    End Sub


    Private Sub FrmBascula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BAnular.Visible = False
    End Sub



    Public Overrides Sub ControlClave()

        ' componemos la clave
        Dim i As Integer
        If TxDato1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = AlbEntrada.LeerAlb(CInt(LbCampa.Text), Mi_IdCentro, VaInt(TxDato1.Text))
            If i > 0 Then
                LbId.Text = i.ToString
            End If
        End If

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()


        LbCampa.Text = AlbEntrada.AEN_Campa.Valor
        Mi_idcentro = AlbEntrada.AEN_IdCentro.Valor
        Mi_idcentroRecogida = AlbEntrada.AEN_IdRecogida.Valor
       
        CargaGastosAlbaran()
        ' llenar el grid
        GridView.Columns.Clear()
        Grid.DataSource = Facturas()
        AjustaColumnas()

    End Sub



    Public Overrides Sub DespuesdeGuardar()

        GrabaGastosAlbaran()
        Agro_GeneraAlbaranEntrada(VaInt(LbId.Text))


        MyBase.DespuesdeGuardar()


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


        LbCampa.Text = MiMaletin.Ejercicio.ToString

        BModificar.Enabled = True
        BAnular.Enabled = True
        BGuardar.Enabled = True
        Mi_idcentro = MiMaletin.IdCentro
        Mi_idcentroRecogida = MiMaletin.IdCentroRecogida
        GridView.OptionsView.ShowGroupPanel = False
        GridView.OptionsBehavior.Editable = False
        GridView.OptionsView.ColumnAutoWidth = True

        Grid.DataSource = Nothing

    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If LbId.Text = "" Then Exit Sub



        Dim f As String = Albentrada_his.AlbaranFacturado(LbId.Text)
        If f <> "" Then
            MsgBox("Albaranes: " + f + " facturados ")
            Exit Sub
        End If


        f = Albentrada_his.GastosFacturados(LbId.Text)
        If f <> "" Then
            MsgBox("Gastos " + f + " facturados")
            Exit Sub

        End If

        MyBase.BAnular_Click(sender, e)

    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)


        If LbId.Text = "" Then Exit Sub



        Dim f As String = Albentrada_his.AlbaranFacturado(LbId.Text)
        If f <> "" Then
            MsgBox("Albaranes: " + f + " facturados ")
            Exit Sub

        End If


        f = Albentrada_his.GastosFacturados(LbId.Text)
        If f <> "" Then
            MsgBox("Gastos " + f + " facturados")
            Exit Sub

        End If


        MyBase.BModificar_Click(sender, e)

    End Sub


    Private Sub TxDato3_Valida(ByVal edicion As Boolean) Handles TxDato3.Valida


        BtBuscaMedianero.CL_Filtro = "IdAgricultor=" + TxDato3.Text

        If Agricultores.LeerId(TxDato3.Text) = True Then
            If edicion = True Then
                If TxDato16.Text = "" Then
                    TxDato16.Text = Agricultores.AGR_tipofcs.Valor
                End If
                DatosGasto()
                If Agricultores.AGR_TextoMensaje1.Valor.Trim <> "" Or Agricultores.AGR_TextoMensaje2.Valor.Trim <> "" Then
                    MsgBox(Agricultores.AGR_TextoMensaje1.Valor & Chr(13) & Chr(10) + Agricultores.AGR_TextoMensaje2.Valor)
                End If
                If Agricultores.AGR_Bloqueado.Valor = "S" Then
                    MsgBox("Código bloqueado")
                    TxDato3.MiError = True
                End If
            End If

        End If

    End Sub


    Public Overrides Sub Guardar()
        MyBase.Guardar()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtDetallesAlbaran.Click
        Dim frm As New VerAlba
        frm.init(LbId.Text)
        frm.ShowDialog()
    End Sub



    Private Function BuscaCultivo(ByVal Idagricultor As String, ByVal idsubfamilia As String) As Integer

        ' -1 no tiene fincas
        ' 0 tiene + de 1 cultivo
        ' devuelve el id de cultivo cuando tiene un solo cultivo

        Dim ret As Integer = -1


        Return ret


    End Function


    Private Sub BtBuscaCultivo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BuscaCultivos()
    End Sub


    Private Sub BuscaCultivos()


    End Sub


    Private Sub DatosGasto()

        Dim Consulta As New Cdatos.E_select
        Dim i As Integer = 0

        Consulta.SelCampo(AgricultorGastos.AGG_IdGasto)
        Consulta.SelCampo(Tiposdegastoagri.TGA_Nombre, "gasto", AgricultorGastos.AGG_IdGasto)
        Consulta.SelCampo(AgricultorGastos.AGG_Valor, "valor")
        Consulta.SelCampo(AgricultorGastos.AGG_TipoFC)
        Consulta.SelCampo(Tiposdegastoagri.TGA_Tipo, "tipo")
        Consulta.SelCampo(Origengastos.ORG_tipo, "origen", Tiposdegastoagri.TGA_idgrupo)
        Consulta.SelCampo(AgricultorGastos.AGG_IdAcreedor)
        Consulta.WheCampo(AgricultorGastos.AGG_IdAgricultor, "=", TxDato3.Text)
        Consulta.WheCampo(AgricultorGastos.AGG_PedirEntrada, "=", "S")

        Dim sql As String = Consulta.SQL
        sql = sql + " AND (AGG_idcentrorec=0 or AGG_Idcentrorec=" + Mi_idcentroRecogida + ") "
        sql = sql + " order by AGG_id"
        Dim dt As New DataTable
        dt = AgricultorGastos.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                i = i + 1
                Select Case i
                    Case 1
                        TxIdGasto1.Text = rw("AGG_idgasto").ToString
                        LbNomGasto1.Text = rw("gasto")
                        LbTipGasto1.Text = rw("tipo")
                        TxVgasto1.Text = rw("valor")
                        BtBuscaAcreedor1.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"

                        LbDto1.Text = rw("AGG_tipofc").ToString


                        TxAcreedor1.Text = rw("AGG_idacreedor").ToString
                        If VaInt(TxAcreedor1.Text) > 0 Then
                            TxAcreedor1.Validar(False)
                        Else
                            TxAcreedor1.Text = ""
                        End If
                        'BtBuscaGasto1.CL_Filtro = "ORIGEN='" + LbOrigenGasto1.Text + "'"
                    Case 2
                        TxIdGasto2.Text = rw("AGG_idgasto").ToString
                        LbNomGasto2.Text = rw("gasto")
                        LbTipGasto2.Text = rw("tipo")
                        TxVgasto2.Text = rw("valor")
                        BtBuscaAcreedor2.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"

                        LbDto2.Text = rw("AGG_tipofc").ToString

                        TxAcreedor2.Text = rw("AGG_idacreedor").ToString
                        If VaInt(TxAcreedor2.Text) > 0 Then
                            TxAcreedor2.Validar(False)
                        Else
                            TxAcreedor2.Text = ""

                        End If
                        'BtBuscaGasto2.CL_Filtro = "ORIGEN='" + LbOrigenGasto2.Text + "'"
                    Case 3
                        TxIdGasto3.Text = rw("AGG_idgasto").ToString
                        LbNomGasto3.Text = rw("gasto")
                        LbTipGasto3.Text = rw("tipo")
                        LbDto3.Text = rw("AGG_tipofc").ToString

                        TxVgasto3.Text = rw("valor")
                        BtBuscaAcreedor3.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"

                        TxAcreedor3.Text = rw("AGG_idacreedor").ToString
                        If VaInt(TxAcreedor3.Text) > 0 Then
                            TxAcreedor3.Validar(False)
                        Else
                            TxAcreedor3.Text = ""

                        End If

                        'BtBuscaGasto3.CL_Filtro = "ORIGEN='" + LbOrigenGasto3.Text + "'"
                    Case 4
                        TxIdGasto4.Text = rw("AGG_idgasto").ToString
                        LbNomGasto4.Text = rw("gasto")
                        LbTipGasto4.Text = rw("tipo")
                        TxVgasto4.Text = rw("valor")
                        BtBuscaAcreedor4.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"
                        LbDto4.Text = rw("AGG_tipofc").ToString

                        TxAcreedor4.Text = rw("AGG_idacreedor").ToString
                        If VaInt(TxAcreedor4.Text) > 0 Then
                            TxAcreedor4.Validar(False)
                        Else
                            TxAcreedor4.Text = ""
                        End If

                        'BtBuscaGasto4.CL_Filtro = "origen='" + LbOrigenGasto4.Text + "'"

                End Select
            Next
            Dim o As Integer = 0
            If TxIdGasto1.Text = "" Then
                o = TxIdGasto1.Orden
            End If
            If o = 0 Then
                If TxAcreedor1.Text = "" Then
                    o = TxAcreedor1.Orden
                End If
            End If
            If o = 0 Then
                If TxIdGasto2.Text = "" Then
                    o = TxIdGasto2.Orden
                End If
            End If

            If o = 0 Then
                If TxAcreedor2.Text = "" Then
                    o = TxAcreedor2.Orden
                End If
            End If
            If o = 0 Then
                If TxIdGasto3.Text = "" Then
                    o = TxIdGasto3.Orden
                End If
            End If
            If o = 0 Then
                If TxAcreedor3.Text = "" Then
                    o = TxAcreedor3.Orden
                End If
            End If
            If o = 0 Then
                If TxIdGasto4.Text = "" Then
                    o = TxIdGasto4.Orden
                End If
            End If
            If o = 0 Then
                If TxAcreedor4.Text = "" Then
                    o = TxAcreedor4.Orden
                End If
            End If
            If o > 0 Then

                TxDato6.Siguiente = o

            End If

        End If


    End Sub


    Private Sub TxIdGasto4_Valida(ByVal edicion As Boolean) Handles TxIdGasto4.Valida

        If VaInt(TxIdGasto4.Text) > 0 Then

            If Tiposdegastoagri.LeerId(TxIdGasto4.Text) = True Then
                If Origengastos.LeerId(Tiposdegastoagri.TGA_idgrupo.Valor) = True Then
                    BtBuscaAcreedor4.CL_Filtro = "TIPO='" + Origengastos.ORG_tipo.Valor + "'"
                End If
            End If
        End If

        If edicion = True Then
            If TxIdGasto4.Text = "" Then
                LbNomGasto4.Text = ""
                LbTipGasto4.Text = ""
                TxVgasto4.Text = ""
                LbDto4.Text = ""
                TxAcreedor4.Text = ""
                LbNomAcreedor4.Text = ""

            End If
        Else
            If VaInt(TxIdGasto4.Text) > 0 Then
                LbTipGasto4.Text = Tiposdegastoagri.TGA_Tipo.Valor
                LbDto4.Text = Tiposdegastoagri.TGA_tipogastofc.Valor
            End If
        End If


    End Sub


    Private Sub TxIdGasto3_Valida(ByVal edicion As Boolean) Handles TxIdGasto3.Valida

        If VaInt(TxIdGasto3.Text) > 0 Then

            If Tiposdegastoagri.LeerId(TxIdGasto3.Text) = True Then
                If Origengastos.LeerId(Tiposdegastoagri.TGA_idgrupo.Valor) = True Then
                    BtBuscaAcreedor3.CL_Filtro = "TIPO='" + Origengastos.ORG_tipo.Valor + "'"
                End If
            End If
        End If

        If edicion = True Then
            If TxIdGasto3.Text = "" Then
                LbNomGasto3.Text = ""
                LbTipGasto3.Text = ""
                TxVgasto3.Text = ""
                LbDto3.Text = ""
                TxAcreedor3.Text = ""
                LbNomAcreedor3.Text = ""

                TxIdGasto3.Siguiente = TxIdGasto4.Orden
            Else
                If VaInt(TxIdGasto3.Text) > 0 Then
                    LbTipGasto3.Text = Tiposdegastoagri.TGA_Tipo.Valor
                    LbDto3.Text = Tiposdegastoagri.TGA_tipogastofc.Valor
                End If
            End If

        End If

    End Sub


    Private Sub TxIdGasto2_Valida(ByVal edicion As Boolean) Handles TxIdGasto2.Valida
        If VaInt(TxIdGasto2.Text) > 0 Then

            If Tiposdegastoagri.LeerId(TxIdGasto2.Text) = True Then
                If Origengastos.LeerId(Tiposdegastoagri.TGA_idgrupo.Valor) = True Then
                    BtBuscaAcreedor1.CL_Filtro = "TIPO='" + Origengastos.ORG_tipo.Valor + "'"
                End If
            End If
        End If

        If edicion = True Then
            If TxIdGasto2.Text = "" Then
                LbNomGasto2.Text = ""
                LbTipGasto2.Text = ""
                TxVgasto2.Text = ""
                LbDto2.Text = ""
                TxAcreedor2.Text = ""
                LbNomAcreedor2.Text = ""

                TxIdGasto2.Siguiente = TxIdGasto3.Orden
        Else
            If VaInt(TxIdGasto2.Text) > 0 Then
                LbTipGasto2.Text = Tiposdegastoagri.TGA_Tipo.Valor
                LbDto2.Text = Tiposdegastoagri.TGA_tipogastofc.Valor
            End If
        End If

        End If

    End Sub


    Private Sub TxIdGasto1_Valida(ByVal edicion As Boolean) Handles TxIdGasto1.Valida

        If VaInt(TxIdGasto1.Text) > 0 Then

            If Tiposdegastoagri.LeerId(TxIdGasto1.Text) = True Then
                If Origengastos.LeerId(Tiposdegastoagri.TGA_idgrupo.Valor) = True Then
                    BtBuscaAcreedor1.CL_Filtro = "TIPO='" + Origengastos.ORG_tipo.Valor + "'"
                End If
            End If
        End If

        If edicion = True Then
            If TxIdGasto1.Text = "" Then
                LbNomGasto1.Text = ""
                LbTipGasto1.Text = ""
                TxVgasto1.Text = ""
                LbDto1.Text = ""
                TxAcreedor1.Text = ""
                LbNomAcreedor1.Text = ""

                TxIdGasto1.Siguiente = TxIdGasto2.Orden
            Else
                If VaInt(TxIdGasto1.Text) > 0 Then
                    LbTipGasto1.Text = Tiposdegastoagri.TGA_Tipo.Valor
                    LbDto1.Text = Tiposdegastoagri.TGA_tipogastofc.Valor
                End If
            End If

        End If
    End Sub


    Private Sub GrabaGastosAlbaran()

        If Val(LbId.Text) = 0 Then Exit Sub
        Dim sql As String = "Delete from albentrada_gastos where AEG_idalbaran=" + LbId.Text
        Dim i As Integer = 0
        AlbEntrada_gastos.MiConexion.OrdenSql(sql)

        If VaInt(TxIdGasto1.Text) > 0 Then
            AlbEntrada_gastos.VaciaEntidad()
            i = AlbEntrada_gastos.MaxId
            AlbEntrada_gastos.AEG_Id.Valor = i.ToString
            AlbEntrada_gastos.AEG_IdAlbaran.Valor = LbId.Text
            AlbEntrada_gastos.AEG_IdGasto.Valor = TxIdGasto1.Text
            AlbEntrada_gastos.AEG_Tipo.Valor = LbTipGasto1.Text
            AlbEntrada_gastos.AEG_Gasto.Valor = TxVgasto1.Text
            AlbEntrada_gastos.AEG_IdAcreedor.Valor = TxAcreedor1.Text
            AlbEntrada_gastos.AEG_TipoFC.Valor = LbDto1.Text

            AlbEntrada_gastos.Insertar()
        End If

        If VaInt(TxIdGasto2.Text) > 0 Then
            AlbEntrada_gastos.VaciaEntidad()
            i = AlbEntrada_gastos.MaxId
            AlbEntrada_gastos.AEG_Id.Valor = i.ToString
            AlbEntrada_gastos.AEG_IdAlbaran.Valor = LbId.Text
            AlbEntrada_gastos.AEG_IdGasto.Valor = TxIdGasto2.Text
            AlbEntrada_gastos.AEG_Tipo.Valor = LbTipGasto2.Text
            AlbEntrada_gastos.AEG_Gasto.Valor = TxVgasto2.Text
            AlbEntrada_gastos.AEG_IdAcreedor.Valor = TxAcreedor2.Text
            AlbEntrada_gastos.AEG_TipoFC.Valor = LbDto2.Text

            AlbEntrada_gastos.Insertar()
        End If

        If VaInt(TxIdGasto3.Text) > 0 Then
            AlbEntrada_gastos.VaciaEntidad()
            i = AlbEntrada_gastos.MaxId
            AlbEntrada_gastos.AEG_Id.Valor = i.ToString
            AlbEntrada_gastos.AEG_IdAlbaran.Valor = LbId.Text
            AlbEntrada_gastos.AEG_IdGasto.Valor = TxIdGasto3.Text
            AlbEntrada_gastos.AEG_Tipo.Valor = LbTipGasto3.Text
            AlbEntrada_gastos.AEG_Gasto.Valor = TxVgasto3.Text
            AlbEntrada_gastos.AEG_IdAcreedor.Valor = TxAcreedor3.Text
            AlbEntrada_gastos.AEG_TipoFC.Valor = LbDto3.Text

            AlbEntrada_gastos.Insertar()
        End If

        If VaInt(TxIdGasto4.Text) > 0 Then
            AlbEntrada_gastos.VaciaEntidad()
            i = AlbEntrada_gastos.MaxId
            AlbEntrada_gastos.AEG_Id.Valor = i.ToString
            AlbEntrada_gastos.AEG_IdAlbaran.Valor = LbId.Text
            AlbEntrada_gastos.AEG_IdGasto.Valor = TxIdGasto4.Text
            AlbEntrada_gastos.AEG_Tipo.Valor = LbTipGasto4.Text
            AlbEntrada_gastos.AEG_Gasto.Valor = TxVgasto4.Text
            AlbEntrada_gastos.AEG_IdAcreedor.Valor = TxAcreedor4.Text
            AlbEntrada_gastos.AEG_TipoFC.Valor = LbDto4.Text

            AlbEntrada_gastos.Insertar()
        End If

    End Sub


    Private Sub CargaGastosAlbaran()

        Dim dt As New DataTable
        Dim Consulta As New Cdatos.E_select
        Dim x As Integer = 0

        If Val(LbId.Text) = 0 Then Exit Sub


        Consulta.SelCampo(AlbEntrada_gastos.AEG_IdGasto, "IdGasto")
        Consulta.SelCampo(Tiposdegastoagri.TGA_Nombre, "gasto", AlbEntrada_gastos.AEG_IdGasto)
        Consulta.SelCampo(Origengastos.ORG_tipo, "origen", Tiposdegastoagri.TGA_idgrupo)
        Consulta.SelCampo(AlbEntrada_gastos.AEG_Tipo, "tipo")
        Consulta.SelCampo(AlbEntrada_gastos.AEG_Gasto, "valor")
        Consulta.SelCampo(AlbEntrada_gastos.AEG_IdAcreedor, "idacreedor")
        Consulta.SelCampo(AlbEntrada_gastos.AEG_TipoFC, "tipofc")
        Consulta.WheCampo(AlbEntrada_gastos.AEG_IdAlbaran, "=", LbId.Text)
        dt = AlbEntrada_gastos.MiConexion.ConsultaSQL(Consulta.SQL)

        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                x = x + 1
                Select Case x
                    Case 1
                        TxIdGasto1.Text = rw("idgasto").ToString
                        LbNomGasto1.Text = rw("gasto")
                        LbTipGasto1.Text = rw("tipo")
                        TxVgasto1.Text = rw("valor")
                        TxAcreedor1.Text = rw("idacreedor").ToString
                        If VaInt(TxAcreedor1.Text) = 0 Then
                            TxAcreedor1.Text = ""
                        Else
                            If Acreedores.LeerId(TxAcreedor1.Text) = True Then
                                LbNomAcreedor1.Text = Acreedores.ACR_Nombre.valor
                            End If
                        End If
                        BtBuscaAcreedor1.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"
                        LbDto1.Text = rw("tipofc").ToString

                    Case 2
                        TxIdGasto2.Text = rw("idgasto").ToString
                        LbNomGasto2.Text = rw("gasto")
                        LbTipGasto2.Text = rw("tipo")
                        TxVgasto2.Text = rw("valor")
                        TxAcreedor2.Text = rw("idacreedor").ToString
                        If VaInt(TxAcreedor2.Text) = 0 Then
                            TxAcreedor2.Text = ""
                        Else
                            If Acreedores.LeerId(TxAcreedor2.Text) = True Then
                                LbNomAcreedor2.Text = Acreedores.ACR_Nombre.Valor
                            End If
                        End If

                        BtBuscaAcreedor2.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"
                        LbDto2.Text = rw("tipofc").ToString

                    Case 3
                        TxIdGasto3.Text = rw("idgasto").ToString
                        LbNomGasto3.Text = rw("gasto")
                        LbTipGasto3.Text = rw("tipo")
                        TxVgasto3.Text = rw("valor")
                        TxAcreedor3.Text = rw("idacreedor").ToString
                        BtBuscaAcreedor3.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"
                        If VaInt(TxAcreedor3.Text) = 0 Then
                            TxAcreedor3.Text = ""
                        Else
                            If Acreedores.LeerId(TxAcreedor3.Text) = True Then
                                LbNomAcreedor3.Text = Acreedores.ACR_Nombre.Valor
                            End If

                        End If

                        LbDto3.Text = rw("tipofc").ToString
                    Case 4
                        TxIdGasto4.Text = rw("idgasto").ToString
                        LbNomGasto4.Text = rw("gasto")
                        LbTipGasto4.Text = rw("tipo")
                        TxVgasto4.Text = rw("valor")
                        TxAcreedor4.Text = rw("idacreedor").ToString
                        BtBuscaAcreedor4.CL_Filtro = "TIPO='" + rw("origen").ToString + "'"
                        If VaInt(TxAcreedor4.Text) = 0 Then
                            TxAcreedor4.Text = ""
                        Else
                            If Acreedores.LeerId(TxAcreedor4.Text) = True Then
                                LbNomAcreedor4.Text = Acreedores.ACR_Nombre.Valor
                            End If

                        End If
                        LbDto4.Text = rw("tipofc").ToString


                End Select

            Next
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()


        'Preliminar, no se usa printVB6
        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirAlbaraEntrada(LbId.Text, TipoImpresion.Preliminar, 0)
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaInt(LbId.Text) > 0 Then

            Dim CopiasAlbaranEntrada As Integer = 2
            Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)
            If CentrosRecogida.LeerId(AlbEntrada.AEN_IdRecogida.Valor) Then
                CopiasAlbaranEntrada = VaInt(CentrosRecogida.CER_CopiasAlbaranEntrada.Valor)
                If CopiasAlbaranEntrada = 0 Then CopiasAlbaranEntrada = 2
            End If

            C1_ImprimirAlbaraEntrada(LbId.Text, TipoImpresion.ImpresoraSeleccionada, CopiasAlbaranEntrada)

        End If


    End Sub


    'Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)

    '    If VaInt(LbId.Text) > 0 Then
    '        Dim frm As New FrmCrearPalets(LbId.Text)
    '        frm.ShowDialog()
    '    End If

    'End Sub


    Private Sub TxDato16_Valida(edicion As System.Boolean) Handles TxDato16.Valida

        If edicion Then
            If AlbEntrada.AEN_EntradaConfeccionada.Valor = "S" Then
                If TxDato16.Text.Trim.ToUpper <> "F" Then
                    MsgBox("Si la entrada es directa, el albarán tiene que ser en firme")
                    TxDato16.Text = "F"
                End If
            End If
        End If

    End Sub


    Private Sub TxDato18_Valida(edicion As Boolean) Handles TxDato18.Valida
        If edicion = True Then
            If TxDato18.Text <> "" Then
                If Medianeria.LeerId(TxDato18.Text) = False Then
                    MsgBox("Medianeria inexistente ")
                    TxDato18.MiError = True
                Else
                    If Medianeria.MED_IdAgricultor.Valor <> TxDato3.Text Then
                        MsgBox("Medianeria no coincide con proveedor")
                        TxDato18.MiError = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Function Facturas() As DataTable
        Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
        Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)
        Dim FacturaRecibidas As New E_Facturasrecibidas(Idusuario, cn)
        Dim consulta As New Cdatos.E_select
        Select Case TxDato16.Text
            Case "F"
                consulta.SelCampo(Albentrada_his.AEH_id, "id")
                consulta.SelCampo(FacturaRecibidas.FRR_numero, "Numero", Albentrada_his.AEH_idfacturafirme)
                consulta.SelCampo(FacturaRecibidas.FRR_numerofactura, "NumeroFactura")
                consulta.SelCampo(FacturaRecibidas.FRR_fechafactura, "Fecha")
                consulta.WheCampo(Albentrada_his.AEH_idalbaran, "=", LbId.Text)
            Case Else
                consulta.SelCampo(Albentrada_his.AEH_id, "id")
                consulta.SelCampo(FacturaAgr.FGR_serie, "Serie", Albentrada_his.AEH_idfactura)
                consulta.SelCampo(FacturaAgr.FGR_numerofactura, "Numerofactura")
                consulta.SelCampo(FacturaAgr.FGR_fecha, "Fecha")
                consulta.WheCampo(Albentrada_his.AEH_idalbaran, "=", LbId.Text)
        End Select
        Dim sql As String = consulta.SQL
        Dim dt As DataTable = Albentrada_his.MiConexion.ConsultaSQL(sql)
 
        Return dt
    End Function

    Private Sub AjustaColumnas()


        GridView.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "ID"
                    c.Visible = False
                Case "SERIE", "NUMERO", "FECHA", "NUMEROFACTURA"

                    c.Width = 200


            End Select

        Next


    End Sub


    Private Sub TxDato6_Valida(edicion As System.Boolean) Handles TxDato6.Valida

        If edicion = True Then
            Dim E As String = ControlaFecha(TxDato6.Text)
            If E <> "" Then
                MsgBox(E)
                TxDato6.MiError = True
            End If
        End If

    End Sub


End Class