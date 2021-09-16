Imports DevExpress.XtraEditors


Public Class FrmPrecioFirme
    Inherits FrMantenimiento


    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim AlbEntrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    'Dim AlbEntrada_lineas_Busqueda As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim AlbEntrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)
    Dim AlbEntrada_lineaskilos As New E_AlbEntrada_lineaskilos(Idusuario, cn)
    Dim AlbEntrada_gastos As New E_albentrada_gastos(Idusuario, cn)

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
    Dim PventaUsuario As New E_PventaUsuario(Idusuario, cn)

    Dim Idmuestreo As Integer



    Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)
    Dim Mi_idcentro As String

    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Idtarifa As Integer
    Dim DtoMerma As Double



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub




    Private Sub ParametrosFrm()

        EntidadFrm = AlbEntrada


        Dim lc As New List(Of Object)
        ListaControles = lc


        ParamTx(TxDato1, AlbEntrada.AEN_albaran, Lb1, True)
        TxDato1.Autonumerico = True
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxFechaValoracion, Nothing, LbFechaValoracion, True, Cdatos.TiposCampo.Fecha, , 10)

        'Género no es obligatorio, siempre y cuando pongamos el origen
        ParamTx(TxPrecio, AlbEntrada_lineas.AEL_precio, Lb59, False)
        ' ParamTx(TxDato22, AlbEntrada_lineas.AEL_tipoprecio, Lb59, False, , , , "KBP")
        ParamTx(TxImporte, Nothing, Lb15, True, Cdatos.TiposCampo.Importe, 2, 18)


        TxBuscarPorPartida.ClForm = Me
        TxBuscarPorPartida.ClParam = New Cdatos.PropiedadesTx
        TxBuscarPorPartida.ClParam.Tipo = AlbEntrada_lineas.AEL_muestreo.TipoBd
        TxBuscarPorPartida.ClParam.Longitud = AlbEntrada_lineas.AEL_muestreo.Longitud
        TxBuscarPorPartida.ClParam.Exclusivos = "0123456789"



        'AsociarGrid(ClGrid1, TxPrecio, TxDato22, AlbEntrada_lineas)
        AsociarGrid(ClGrid1, TxPrecio, TxImporte, AlbEntrada_lineas)

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        PropiedadesCamposGr(ClGrid1, "AEL_idlinea", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Genero", "Genero", True, 10)
        PropiedadesCamposGr(ClGrid1, "NombreGenero", "Nombre_Genero", True, 50)
        PropiedadesCamposGr(ClGrid1, "Envase", "Envase", True, 50)
        PropiedadesCamposGr(ClGrid1, "Bultos", "Bultos", True, 10, True, "#0")
        PropiedadesCamposGr(ClGrid1, "Kilos", "Kilos", True, 10, True, "#0")
        PropiedadesCamposGr(ClGrid1, "Piezas", "Piezas", True, 10, True, "#0")
        PropiedadesCamposGr(ClGrid1, "Partida", "Partida", True, 10)
        PropiedadesCamposGr(ClGrid1, "KBP", "KBP", True, 10)
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 10, False, "#0.00")
        PropiedadesCamposGr(ClGrid1, "Importe", "Importe", True, 10, True, "#0.00")



        AsociarControles(TxDato1, BtBuscaAlbaran, AlbEntrada.btBusca, EntidadFrm)
        BtBuscaAlbaran.CL_Filtro = "(FC = 'F' OR FC = 'S') " + Pventausuario.FiltroPventaGrid("PV", "AND")
        BtBuscaAlbaran.CL_xCentro = False


        tt.SetToolTip(BtDetallesAlbaran, "Ver detalles albarán")

        FiltroEntidad.Add(AlbEntrada.AEN_IdCentro.NombreCampo, MiMaletin.IdCentro.ToString)
        FiltroEntidad.Add(AlbEntrada.AEN_Campa.NombreCampo, MiMaletin.Ejercicio.ToString)


    End Sub



    Private Sub FrmBascula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'BAnular.Visible = False
        BAnular.Text = "Anular valoración"
        BAnular.Width = 100

    End Sub


    Private Function CompruebaPartidasValoradas() As Boolean

        Dim bRes As Boolean = False

        Dim sql As String = "SELECT AEL_FechaValoracion FROM AlbEntrada_Lineas WHERE AEL_IdAlbaran = " & LbId.Text & " AND COALESCE(AEL_FechaValoracion,'" & VaDate("") & "') > '" & VaDate("") & "'"
        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then bRes = True
        End If


        Return bRes

    End Function




    Public Overrides Sub ControlClave()
        ' componemos la clave
        Dim i As Integer
        If TxDato1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = AlbEntrada.LeerAlb(CInt(LbCampa.Text), Mi_IdCentro, VaInt(TxDato1.Text))
            If i > 0 Then
                LbId.Text = i.ToString
            Else
                LbId.Text = AlbEntrada.MaxId
            End If

        End If
        CargaLineasGrid()

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)

        Idmuestreo = AlbEntrada_lineas.AEL_muestreo.Valor
        LBPARTIDA.Text = Idmuestreo.ToString


        LbIdCultivo.Text = AlbEntrada_lineas.AEL_idcultivo.Valor
        LbTipoPrecio.Text = AlbEntrada_lineas.AEL_tipoprecio.Valor

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbEntrada_lineas.AEL_bultos, "bultos")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbEntrada_lineas.AEL_idgenero)
        If AlbEntrada.AEN_EntradaConfeccionada.Valor = "S" Then
            consulta.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", AlbEntrada_lineas.AEL_idcategoria)
            consulta.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", AlbEntrada_lineas.AEL_idgensal)
            consulta.SelCampo(Confecpalet.CPA_Nombre, "Tipopalet", AlbEntrada_lineas.AEL_idtipopalet)
            consulta.SelCampo(Marcas.MAR_Nombre, "Marca", AlbEntrada_lineas.AEL_idmarca)
        Else
            consulta.SelCampo(CategoriasEntrada.CAE_CategoriaCalibre, "Categoria", AlbEntrada_lineas.AEL_idcategoria)
        End If
        consulta.SelCampo(Envases.ENV_Nombre, "Envase", AlbEntrada_lineas.AEL_idenvase)
        consulta.SelCampo(AlbEntrada_lineas.AEL_idpalet, "idpalet")
        consulta.SelCampo(AlbEntrada_lineas.AEL_kilosnetos, "kilos")
        consulta.SelCampo(AlbEntrada_lineas.AEL_piezas, "piezas")
        consulta.WheCampo(AlbEntrada_lineas.AEL_idlinea, "=", AlbEntrada_lineas.AEL_idlinea.Valor)
        Dim sql As String = consulta.SQL
        Dim dt As DataTable = AlbEntrada_lineas.MiConexion.ConsultaSQL(sql)

        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                LbGenero.Text = dt.Rows(0)("Genero").ToString
                LbCategoria.Text = dt.Rows(0)("Categoria").ToString
                LbEnvase.Text = dt.Rows(0)("Envase").ToString
                Dim idpalet As String = dt.Rows(0)("idpalet").ToString
                If idpalet <> "" Then
                    If Envases.LeerId(idpalet) = True Then
                        LbPalet.Text = Envases.ENV_Nombre.Valor
                    End If
                End If
                LbBultos.Text = Format(VaDec(dt.Rows(0)("Bultos")), "#,###")
                LbKilos.Text = Format(VaDec(dt.Rows(0)("Kilos")), "#,###")
                LbPiezas.Text = Format(VaDec(dt.Rows(0)("Piezas")), "#,###")
                Dim importe As Double = 0
                Select Case AlbEntrada_lineas.AEL_tipoprecio.Valor
                    Case "B"
                        importe = VaDec(LbBultos.Text) * VaDec(AlbEntrada_lineas.AEL_precio.Valor)

                    Case "P"
                        importe = VaDec(LbPiezas.Text) * VaDec(AlbEntrada_lineas.AEL_precio.Valor)

                    Case Else
                        importe = VaDec(LbKilos.Text) * VaDec(AlbEntrada_lineas.AEL_precio.Valor)

                End Select
                TxImporte.Text = Format(importe, "#,###0.00")

            End If
        End If


        If VaInt(AlbEntrada_lineas.AEL_IdValoracion.Valor) > 0 Then
            LbValorada.Visible = True
            Grid.LineaBloqueada = True
        Else
            LbValorada.Visible = False
            Grid.LineaBloqueada = False
        End If


    End Sub



    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

        LbCampa.Text = AlbEntrada.AEN_Campa.Valor
        Mi_idcentro = AlbEntrada.AEN_IdCentro.Valor
        LbFecha.Text = AlbEntrada.AEN_Fecha.Valor
        LbReferencia.Text = AlbEntrada.AEN_referencia.Valor
        LbMatricula.Text = AlbEntrada.AEN_matricula.Valor
        LbTipoFCS.Text = AlbEntrada.AEN_TipoFCS.Valor


        If Agricultores.LeerId(AlbEntrada.AEN_IdAgricultor.Valor) Then
            LbNomProve.Text = Agricultores.AGR_Nombre.Valor
        End If

        ' llenar el grid
        CargaLineasGrid()



        If CompruebaPartidasValoradas() Then
            BAnular.Visible = True
        Else
            BAnular.Visible = False
        End If


        TxFechaValoracion.Text = ObtenerFechaValoracion()


    End Sub


    Private Function ObtenerFechaValoracion() As String

        Dim res As String = ""

        Dim sql As String = "SELECT Top 1 AEL_FechaValoracion as Fecha FROM AlbEntrada_Lineas WHERE AEL_IdAlbaran = " & LbId.Text & " AND COALESCE(AEL_FechaValoracion,'" & VaDate("") & "') > '" & VaDate("") & "'"
        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                If VaDate(dt.Rows(0)("Fecha")) > VaDate("") Then res = VaDate(dt.Rows(0)("Fecha")).ToString("dd/MM/yyyy")
            End If
        End If


        Return res

    End Function


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas

        Dim r As Boolean


        AlbEntrada_lineas.AEL_idalbaran.Valor = LbId.Text
        AlbEntrada_lineas.AEL_FechaValoracion.Valor = VaDate(TxFechaValoracion.Text).ToString("dd/MM/yyyy")
        AlbEntrada_lineas.AEL_tipoprecio.Valor = LbTipoPrecio.Text

        SqlGrid()


        r = MyBase.GuardarLineas(Gr)
        Return r

    End Function


    Public Overrides Sub DespuesdeGuardarLinea(ByVal gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)

    End Sub


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()

        ActualizaPreciosFirme()

    End Sub


    Private Sub ActualizaPreciosFirme()

        Dim Albentrada_hislineas As New E_AlbEntrada_hislineas(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        Dim sql As String = ""
        Dim dt As New DataTable

        ' actualizo el precio de los muestreos en firme
        consulta.SelCampo(AlbEntrada_lineascla.ALC_id, "idlineacla")
        consulta.SelCampo(AlbEntrada_lineas.AEL_precio, "precio", AlbEntrada_lineascla.ALC_idlineaentrada)
        consulta.SelCampo(AlbEntrada_lineas.AEL_tipoprecio, "tipo")
        consulta.WheCampo(AlbEntrada_lineas.AEL_idalbaran, "=", LbId.Text)
        sql = consulta.SQL
        dt = AlbEntrada_lineascla.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                If AlbEntrada_lineascla.LeerId(rw("idlineacla")).ToString = True Then
                    AlbEntrada_lineascla.ALC_precio.Valor = rw("precio").ToString
                    AlbEntrada_lineascla.Actualizar()
                End If
            Next
        End If

        Dim consulta2 As New Cdatos.E_select
        ' actualizo el precio de los historicos
        consulta2.SelCampo(Albentrada_hislineas.AHL_id, "idlineahis")
        consulta2.SelCampo(AlbEntrada_lineas.AEL_precio, "precio", Albentrada_hislineas.AHL_idlineaentrada)
        consulta2.SelCampo(AlbEntrada_lineas.AEL_tipoprecio, "tipo")
        consulta2.WheCampo(AlbEntrada_lineas.AEL_idalbaran, "=", LbId.Text)
        sql = consulta2.SQL
        dt = Albentrada_hislineas.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                If Albentrada_hislineas.LeerId(rw("idlineahis")).ToString = True Then
                    Albentrada_hislineas.AHL_precio.Valor = rw("precio").ToString
                    Albentrada_hislineas.AHL_tipoprecio.Valor = rw("tipo").ToString

                    Dim Kilos As Decimal = VaDec(Albentrada_hislineas.AHL_kilos.Valor)
                    Dim Bultos As Decimal = VaDec(Albentrada_hislineas.AHL_bultos.Valor)
                    Dim Piezas As Decimal = VaDec(Albentrada_hislineas.AHL_piezas.Valor)
                    Dim Importe As Decimal = 0
                    Dim precio As Decimal = VaDec(rw("precio"))
                    Select Case rw("tipo").ToString

                        Case "B"
                            Importe = Bultos * precio
                        Case "P"
                            Importe = Piezas * precio
                        Case Else
                            Importe = Kilos * precio
                    End Select
                    Albentrada_hislineas.AHL_importegenero.Valor = Importe.ToString
                    Albentrada_hislineas.Actualizar()
                End If
            Next
        End If

        Agro_ValoraAlbaranHis(LbId.Text)


    End Sub

    Public Overrides Sub Borralin(ByVal gr As ClGrid)


        MyBase.Borralin(gr)
        LbCultivo.Text = ""
        LbPcalidad.Text = ""
        LbIdCalidad.Text = ""
        LbCultivo.Text = ""
        LbIdCultivo.Text = ""
        LBPARTIDA.Text = ""
        LbGenero.Text = ""
        LbEnvase.Text = ""
        LbCategoria.Text = ""
        LbBultos.Text = ""
        LbKilos.Text = ""
        LbPiezas.Text = ""
        LbPalet.Text = ""
        LbGensal.Text = ""
        LbMarca.Text = ""
        LbTpalet.Text = ""
        TxImporte.Text = ""
        LbTipoPrecio.Text = ""


        If gr.Nlinea = -2 Then
            gr.LineaBloqueada = True
        Else
            gr.LineaBloqueada = False
        End If

        LbValorada.Visible = False

    End Sub

    Public Overrides Sub DespuesdeCargarLineas(gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)

        For indice As Integer = 0 To ClGrid1.GridView.RowCount - 1
            Dim row As DataRow = ClGrid1.GridView.GetDataRow(indice)
            If Not IsNothing(row) Then

                Dim importe As Double = 0
                Select Case row("KBP").ToString
                    Case "B"
                        importe = VaDec(row("Bultos")) * VaDec(row("Precio"))
                    Case "P"
                        importe = VaDec(row("Piezas")) * VaDec(row("Precio"))
                    Case Else
                        importe = VaDec(row("Kilos")) * VaDec(row("Precio"))


                End Select
                ClGrid1.GridView.SetRowCellValue(indice, ClGrid1.GridView.Columns("Importe"), Format(importe, "#0.00"))
            End If
        Next



    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbCampa.Text = MiMaletin.Ejercicio.ToString

        LbNomProve.Text = ""
        LbFecha.Text = ""
        LbMatricula.Text = ""
        LbReferencia.Text = ""
        LbTipoFCS.Text = ""

        TxBuscarPorPartida.Text = ""


        BModificar.Enabled = True
        BAnular.Enabled = True
        BGuardar.Enabled = True
        Panel6.Visible = False

        Mi_idcentro = MiMaletin.IdCentro

        BAnular.Visible = True

    End Sub


    Private Sub CargaLineasGrid()
        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)
    End Sub


    Private Sub SqlGrid()


        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim id As String

        id = LbId.Text
        Dim sql As String
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim CONSULTA As New Cdatos.E_select


        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_idlinea, "")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_muestreo, "Partida")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_idgenero, "Genero")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "NombreGenero", AlbEntrada_lineas.AEL_idgenero)
        CONSULTA.SelCampo(Envases.ENV_Nombre, "Envase", AlbEntrada_lineas.AEL_idenvase)
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_bultos, "Bultos")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_kilosnetos, "Kilos")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_piezas, "Piezas")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_precio, "Precio")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_tipoprecio, "KBP")
        CONSULTA.SelCampo(AlbEntrada_lineas.AEL_precio, "Importe")
        CONSULTA.WheCampo(AlbEntrada_lineas.AEL_idalbaran, "=", id)

        sql = CONSULTA.SQL
        sql = sql + " order by AEL_Idlinea"

        ClGrid1.Consulta = sql

    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)


        If LbId.Text = "" Then Exit Sub


        Dim f As String = Albentrada_his.AlbaranFacturado(LbId.Text)
        If f <> "" Then
            MsgBox("Albaranes: " + f + " facturados ")
            Exit Sub
        End If


        'f = Albentrada_his.GastosFacturados(LbId.Text)
        'If f <> "" Then
        '    MsgBox("Gastos " + f + " facturados")
        '    Exit Sub

        'End If


        MyBase.BModificar_Click(sender, e)

    End Sub


    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxDato1.Text = "" And TxDato1.Enabled = True Then
            TxDato1.Text = "+"
            Siguiente(0)
        End If
    End Sub


    Public Overrides Sub Guardar()
        MyBase.Guardar()

    End Sub


    Public Overrides Sub Anular()
        'MyBase.Anular()


        If VaInt(LbId.Text) > 0 Then


            Dim f As String = Albentrada_his.AlbaranFacturado(LbId.Text)
            If f <> "" Then
                MsgBox("Albaranes: " + f + " facturados ")
                Exit Sub
            End If


            'f = Albentrada_his.GastosFacturados(LbId.Text)
            'If f <> "" Then
            '    MsgBox("Gastos " + f + " facturados")
            '    Exit Sub
            'End If


            If XtraMessageBox.Show("¿Desea anular la valoración?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim AlbEntrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
                Dim Albentrada_hislineas As New E_AlbEntrada_hislineas(Idusuario, cn)


                Dim CONSULTA As New Cdatos.E_select
                CONSULTA.SelCampo(AlbEntrada_lineas.AEL_idlinea)
                CONSULTA.WheCampo(AlbEntrada_lineas.AEL_idalbaran, "=", LbId.Text)

                Dim sql As String = CONSULTA.SQL

                Dim dt As DataTable = AlbEntrada_lineas.MiConexion.ConsultaSQL(sql)
                If Not IsNothing(dt) Then
                    For Each row As DataRow In dt.Rows

                        Dim IdLinea As String = (row("AEL_IdLinea").ToString & "").Trim
                        If AlbEntrada_lineas.LeerId(IdLinea) Then
                            AlbEntrada_lineas.AEL_FechaValoracion.Valor = VaDate("")
                            AlbEntrada_lineas.AEL_precio.Valor = "0"
                            AlbEntrada_lineas.Actualizar()
                        End If

                    Next
                End If




                CONSULTA = New Cdatos.E_select
                sql = ""
                dt = New DataTable

                ' actualizo el precio de los muestreos en firme
                CONSULTA.SelCampo(AlbEntrada_lineascla.ALC_id, "idlineacla")
                CONSULTA.SelCampo(AlbEntrada_lineas.AEL_precio, "precio", AlbEntrada_lineascla.ALC_idlineaentrada)
                CONSULTA.WheCampo(AlbEntrada_lineas.AEL_idalbaran, "=", LbId.Text)
                sql = CONSULTA.SQL
                dt = AlbEntrada_lineascla.MiConexion.ConsultaSQL(sql)
                If Not dt Is Nothing Then
                    For Each rw In dt.Rows
                        If AlbEntrada_lineascla.LeerId(rw("idlineacla")).ToString = True Then
                            AlbEntrada_lineascla.ALC_precio.Valor = "0"
                            AlbEntrada_lineascla.Actualizar()
                        End If
                    Next
                End If

                Dim consulta2 As New Cdatos.E_select
                ' actualizo el precio de los historicos
                consulta2.SelCampo(Albentrada_hislineas.AHL_id, "idlineahis")
                consulta2.SelCampo(AlbEntrada_lineas.AEL_precio, "precio", Albentrada_hislineas.AHL_idlineaentrada)
                consulta2.WheCampo(AlbEntrada_lineas.AEL_idalbaran, "=", LbId.Text)
                sql = consulta2.SQL
                dt = Albentrada_hislineas.MiConexion.ConsultaSQL(sql)
                If Not dt Is Nothing Then
                    For Each rw In dt.Rows
                        If Albentrada_hislineas.LeerId(rw("idlineahis")).ToString Then
                            Albentrada_hislineas.AHL_precio.Valor = "0"
                            Albentrada_hislineas.AHL_importegenero.Valor = "0"
                            Albentrada_hislineas.Actualizar()
                        End If
                    Next
                End If

                Agro_ValoraAlbaranHis(LbId.Text)


            End If

        End If


    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtDetallesAlbaran.Click
        Dim frm As New VerAlba
        frm.init(LbId.Text)
        frm.ShowDialog()
    End Sub


    Private Sub TxDato1_Valida(edicion As System.Boolean) Handles TxDato1.Valida

        If edicion Then
            Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
            Dim IdAlbaran As Integer = AlbEntrada.LeerAlb(CInt(LbCampa.Text), Mi_idcentro, VaInt(TxDato1.Text))

            If AlbEntrada.LeerId(IdAlbaran) Then

                If AlbEntrada.AEN_TipoFCS.Valor = "C" Then
                    MsgBox("ENTRADA EN COMISION")
                    LbId.Text = ""
                    TxDato1.MiError = True
                End If

                Dim f As String = Albentrada_his.AlbaranFacturado(IdAlbaran)
                If f <> "" Then
                    MsgBox("Albaranes: " + f + " facturados ")
                    TxDato1.MiError = True
                End If


            End If

        End If


    End Sub

  

    Private Sub TxBuscarPorPartida_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxBuscarPorPartida.KeyDown
        If e.KeyCode = Keys.F2 Then
            EnlazaBusquedaPartidas()
        End If
    End Sub


    Private Sub btBuscaPartidas_Click(sender As System.Object, e As System.EventArgs) Handles btBuscaPartidas.Click
        EnlazaBusquedaPartidas()
    End Sub


    Private Sub EnlazaBusquedaPartidas()

        Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim sql As String = AlbEntrada_Lineas.btBusca.CL_ConsultaSql
        AlbEntrada_Lineas.btBusca.CL_Filtro = "(Tipo = 'F' OR Tipo = 'S') " + PventaUsuario.FiltroPventaGrid("PV", "AND")
        Dim dt As DataTable = AlbEntrada_lineas.MiConexion.ConsultaSQL(sql)

        Dim Frb As New FrBuscar
        Frb.InitCol(AlbEntrada_lineas.btBusca.CL_ParamBusqueda, 0)
        Frb.InitDta(dt, AlbEntrada_lineas.btBusca.CL_CampoOrden, AlbEntrada_lineas.btBusca.CL_Filtro, AlbEntrada_lineas.btBusca.CL_ch1000)
        Frb.Width = 1024
        Frb.ShowDialog()

        If Not IsNothing(BuscarRow) Then
            Dim Partida As String = BuscarRow("Partida")
            TxBuscarPorPartida.Text = Partida
            TxBuscarPorPartida.Validar(True)
        End If

    End Sub


    Private Sub TxDato1_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxDato1.EnabledChanged
        TxBuscarPorPartida.Enabled = TxDato1.Enabled
        btBuscaPartidas.Enabled = TxDato1.Enabled
    End Sub


    Private Sub TxBuscarPorPartida_Valida(edicion As System.Boolean) Handles TxBuscarPorPartida.Valida

        If edicion Then

            If VaInt(TxBuscarPorPartida.Text) > 0 Then

                Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
                Dim id As Integer = AlbEntrada_Lineas.LeerMuestreo(LbCampa.Text, TxBuscarPorPartida.Text)

                If id > 0 Then

                    Dim CONSULTA As New Cdatos.E_select
                    CONSULTA.SelCampo(AlbEntrada_Lineas.AEL_idalbaran, "IdAlbaran")
                    CONSULTA.SelCampo(AlbEntrada.AEN_Albaran, "Albaran", AlbEntrada_Lineas.AEL_idalbaran, AlbEntrada.AEN_IdAlbaran)
                    CONSULTA.WheCampo(AlbEntrada_Lineas.AEL_idlinea, "=", id.ToString)
                    CONSULTA.WheCampo(AlbEntrada.AEN_IdCentro, "=", MiMaletin.IdCentro.ToString)


                    Dim sql As String = CONSULTA.SQL
                    Dim bEncontrado As Boolean = False

                    Dim dt As DataTable = AlbEntrada_Lineas.MiConexion.ConsultaSQL(sql)
                    If Not IsNothing(dt) Then
                        If dt.Rows.Count > 0 Then

                            bEncontrado = True



                            TxDato1.Text = (dt.Rows(0)("Albaran").ToString & "").Trim

                            TxDato1.MiError = False
                            QuitaError(TxDato1.Orden)

                            TxDato1.Validar(True)


                            If Not TxDato1.MiError And TxDato1.Text.Trim <> "" Then
                                Siguiente(TxDato1.Orden)
                            End If


                        End If
                    End If

                    If Not bEncontrado Then
                        MsgBox("La partida no existe para esta campaña/centro")
                    End If


                End If

            End If


        End If

    End Sub


    Private Sub TxPrecio_Valida(edicion As System.Boolean) Handles TxPrecio.Valida
        If edicion Then
            CalculaImporte()
        End If
    End Sub

    Private Sub TxDato22_Valida(edicion As System.Boolean)
        If edicion Then
            CalculaImporte()
        End If
    End Sub

    Private Sub TxImporte_Valida(edicion As System.Boolean) Handles TxImporte.Valida
        If edicion Then
            CalculaPrecio()
        End If
    End Sub

    Private Sub CalculaImporte()

        Dim Importe As Decimal = 0


        Dim Precio As Decimal = VaDec(TxPrecio.Text)
        Dim TipoPrecio As String = LbTipoPrecio.Text

        Select Case TipoPrecio
            Case "B"
                Importe = VaDec(LbBultos.Text) * VaDec(Precio)
            Case "P"
                Importe = VaDec(LbPiezas.Text) * VaDec(Precio)
            Case Else
                Importe = VaDec(LbKilos.Text) * VaDec(Precio)
        End Select

        TxImporte.Text = Format(importe, "#,###0.00")

    End Sub

    Private Sub CalculaPrecio()

        Dim Precio As Decimal = 0


        Dim Importe As Decimal = VaDec(TxImporte.Text)
        Dim TipoPrecio As String = LbTipoPrecio.Text

        Select Case TipoPrecio
            Case "B"
                Dim Bultos As Decimal = VaDec(LbBultos.Text)
                If Bultos <> 0 Then Precio = Importe / Bultos
            Case "P"
                Dim Piezas As Decimal = VaDec(LbPiezas.Text)
                If Piezas <> 0 Then Precio = Importe / Piezas
            Case Else
                Dim Kilos As Decimal = VaDec(LbKilos.Text)
                If Kilos <> 0 Then Precio = Importe / Kilos
        End Select

        TxPrecio.Text = Format(Precio, "#,##0.0000")


    End Sub


    Private Sub TxBuscarPorPartida_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxBuscarPorPartida.TextChanged

    End Sub
End Class