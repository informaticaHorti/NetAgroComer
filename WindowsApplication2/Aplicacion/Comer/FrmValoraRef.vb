Public Class FrmValoraRef
    Inherits FrConsulta

    Dim Albsalida As New E_AlbSalida(Idusuario, cn)
    Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim PreciosRef As New E_PreciosRef(Idusuario, cn)
    Dim PreciosRef_lineas As New E_PreciosRef_Lineas(Idusuario, cn)

    Dim _idvalora As Integer = 0
    Dim _tipoprecio As String = "K"



    Private Class stClaves_Valora
        Public IdGenero As Integer = 0
        Public Genero As String = ""
        Public IdCat As Integer = 0
        Public Categoria As String = ""

        Public Sub New(IdGenero As Integer, Genero As String, IdCat As Integer, Categoria As String)
            Me.IdGenero = IdGenero
            Me.Genero = Genero
            Me.IdCat = IdCat
            Me.Categoria = Categoria
            Me.IdCat = IdCat
            Me.Categoria = Categoria
        End Sub

    End Class


    Private Class stDatos_Valora

        Public Bultos As Decimal = 0
        Public Kilos As Decimal = 0
        Public Piezas As Decimal = 0

        Public Sub New(bultos As Decimal, Kilos As Decimal, Piezas As Decimal)
            Me.Kilos = Kilos
            Me.Bultos = bultos
            Me.Piezas = Piezas
        End Sub

    End Class




    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxCliente, Albsalida.ASA_idcliente, Lb1, True)
        ParamTx(TxDFecha, Albsalida.ASA_fechasalida, Lb4, True)
        ParamTx(TxAfecha, Albsalida.ASA_fechasalida, Lb5, True)
        ParamTx(TxCambio, Albsalida.ASA_valorcambio, Lb2, False)

        AsociarControles(TxCliente, BtBuscaCli1, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomCli1)



    End Sub

    Private Sub TxDato_1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxCliente.TextChanged

    End Sub

    Private Sub Fechaspordefecto()
        TxDFecha.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxAfecha.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub

    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        GridEditable.DataSource = Nothing
        Fechaspordefecto()

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaKilosSalidas()


    End Sub



    Private Sub CargaKilosSalidas()

        Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
        Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Albsalida_lineas.ASL_idgensal, "idgensal")
        consulta.SelCampo(GenerosSalida.GES_DescripcionAlb, "Producto", Albsalida_lineas.ASL_idgensal)
        consulta.SelCampo(Albsalida_lineas.ASL_idcategoria, "idcat")
        consulta.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", Albsalida_lineas.ASL_idcategoria)
        Dim Bultos As New Cdatos.bdcampo("@SUM(asl_Bultos)", Cdatos.TiposCampo.Importe, 10)
        consulta.SelCampo(Bultos, "Bultos")
        Dim kilos As New Cdatos.bdcampo("@SUM(asl_Kilosnetos)", Cdatos.TiposCampo.Importe, 10)
        consulta.SelCampo(kilos, "Kilos")
        Dim Piezas As New Cdatos.bdcampo("@SUM(asl_Piezas)", Cdatos.TiposCampo.Importe, 10)
        consulta.SelCampo(Piezas, "Piezas")
        consulta.SelCampo(Albsalida.ASA_ejercicio, "Campa", Albsalida_lineas.ASL_idalbaran)
        consulta.WheCampo(Albsalida.ASA_fechasalida, ">=", TxDFecha.Text)
        consulta.WheCampo(Albsalida.ASA_fechasalida, "<=", TxAfecha.Text)
        consulta.WheCampo(Albsalida.ASA_ejercicio, "=", MiMaletin.Ejercicio.ToString)
        consulta.WheCampo(Albsalida.ASA_idcliente, "=", TxCliente.Text)
        consulta.WheCampo(Albsalida.ASA_tipofc, "=", "C")
        consulta.WheCampo(Albsalida.ASA_fechavaloracion, "=", "01/01/1900")

        Dim sql As String = consulta.SQL
        Dim cadena_where As String = consulta.Whe
        If cadena_where.ToUpper.Contains(" WHERE ") Then
            sql = sql & CadenaWhereLista(Albsalida.ASA_idcentro, ListadeCombo(cbCentro), " AND ")
        Else
            sql = sql & CadenaWhereLista(Albsalida.ASA_idcentro, ListadeCombo(cbCentro), " WHERE ")
        End If


        sql = sql + "group by asl_idgensal,ges_descripcionalb,asl_idcategoria,CAS_categoriacalibre,ASA_ejercicio"
        Dim dt As DataTable = albsalida_lineas.MiConexion.ConsultaSQL(sql)
        dt.Columns.Add("Precio", GetType(System.Decimal))
        dt.Columns.Add("BKP", GetType(System.String))

        If Not dt Is Nothing Then
            For Each rw In dt.Rows

                Dim Idgensal As Integer = VaInt(rw("idgensal"))
                Dim Idcategoria As Integer = VaInt(rw("idcat"))
                Dim precio As Decimal = 0
                Dim Tipo As String = ""

                rw("BKP") = _tipoprecio

                If _idvalora > 0 Then

                    If PreciosRef_lineas.LeerPrecio(_idvalora, Idgensal, Idcategoria, precio, Tipo) = True Then
                        rw("Precio") = precio
                        rw("BKP") = Tipo
                    End If

                End If


            Next
        End If

        GridEditable.DataSource = dt
        GridEditable.Campo("Precio", Albsalida_lineas.ASL_precioestimado, True, True, False, True, 200)
        GridEditable.Campo("BKP", Albsalida_lineas.ASL_tipoprecio, True, True, False, False, 120)

        AjustaColumnas(GridEditable.GridView)

    End Sub



    Private Sub Guardar()


        If MsgBox("Desea guardar los precios", vbYesNo) = vbYes Then
            Dim sql As String = ""
            Dim Alta As Boolean
            If _idvalora > 0 Then
                sql = "Delete from preciosref_lineas where PFL_idvalora=" + _idvalora.ToString
                PreciosRef.MiConexion.OrdenSql(sql)

            Else
                _idvalora = PreciosRef.MaxId
                PreciosRef.VaciaEntidad()
                Alta = True
            End If

            PreciosRef.PRF_idvalora.Valor = _idvalora
            PreciosRef.PRF_idcliente.Valor = TxCliente.Text
            PreciosRef.PRF_dfecha.Valor = TxDFecha.Text
            PreciosRef.PRF_afecha.Valor = TxAfecha.Text
            PreciosRef.PRF_cambio.Valor = TxCambio.Text
            If Alta = True Then
                PreciosRef.Insertar()
            Else
                PreciosRef.Actualizar()
            End If


            For Each rw In GridEditable.GridView.DataSource
                Dim Idgensal As Integer = VaInt(rw("idgensal"))
                Dim Idcategoria As Integer = VaInt(rw("idcat"))
                Dim precio As Decimal = VaDec(rw("Precio"))
                Dim tipo As String = rw("BKP").ToString

                Dim ID As Integer = PreciosRef_lineas.MaxId
                PreciosRef_lineas.VaciaEntidad()

                PreciosRef_lineas.PFL_IdLinea.Valor = ID.ToString
                PreciosRef_lineas.PFL_Idvalora.Valor = _idvalora
                PreciosRef_lineas.PFL_Idgensal.Valor = Idgensal.ToString
                PreciosRef_lineas.PFL_Idcategoria.Valor = Idcategoria.ToString
                PreciosRef_lineas.PFL_Precio.Valor = precio
                PreciosRef_lineas.PFL_BKP.Valor = tipo
                PreciosRef_lineas.Insertar()
            Next
            MsgBox("Registros guardados")

            ActualizaSalidas()

        End If

    End Sub

    Private Sub ActualizaSalidas()

        If MsgBox("Desea valorar los albaranes del cliente", vbYesNo) = vbNo Then
            Exit Sub
        End If
        Dim DcAlba As New Dictionary(Of String, String)


        Dim sql As String = ""
        Dim consulta As New Cdatos.E_select

        consulta.SelCampo(Albsalida_lineas.ASL_idlinea, "idlinea")
        consulta.SelCampo(Albsalida_lineas.ASL_idgensal, "idgensal")
        consulta.SelCampo(Albsalida_lineas.ASL_idcategoria, "idcat")
        consulta.SelCampo(Albsalida.ASA_idalbaran, "idalbaran", Albsalida_lineas.ASL_idalbaran)
        consulta.WheCampo(Albsalida.ASA_fechasalida, ">=", TxDFecha.Text)
        consulta.WheCampo(Albsalida.ASA_fechasalida, "<=", TxAfecha.Text)
        consulta.WheCampo(Albsalida.ASA_ejercicio, "=", MiMaletin.Ejercicio.ToString)
        consulta.WheCampo(Albsalida.ASA_idcliente, "=", TxCliente.Text)
        consulta.WheCampo(Albsalida.ASA_tipofc, "=", "C")
        consulta.WheCampo(Albsalida.ASA_fechavaloracion, "=", "01/01/1900")

        sql = consulta.SQL
        Dim dt As DataTable = Albsalida.MiConexion.ConsultaSQL(sql)
        Dim precio As Decimal = 0
        Dim tipo As String = ""
        Dim i As Integer = 0
        If Not dt Is Nothing Then
            Barra.Maximum = dt.Rows.Count + 1
            For Each rw In dt.Rows
                i = i + 1
                Barra.Value = i
                Dim idalbaran As Integer = VaInt(rw("idalbaran"))
                Dim Idlinea As Integer = VaInt(rw("idlinea"))
                Dim IdGensal As Integer = VaInt(rw("idgensal"))
                Dim IdCat As Integer = VaInt(rw("idcat"))
                precio = 0
                tipo = ""
                If PreciosRef_lineas.LeerPrecio(_idvalora, IdGensal, IdCat, precio, tipo) = True Then
                    If Albsalida_lineas.LeerId(Idlinea.ToString) = True Then
                        Albsalida_lineas.ASL_precioestimado.Valor = precio.ToString
                        Albsalida_lineas.ASL_tipoprecioestimado.Valor = tipo
                        Dim U As Decimal = 0
                        Dim igeneroestimado As Decimal = 0
                        U = 0
                        Select Case tipo
                            Case "K"
                                U = VaDec(Albsalida_lineas.ASL_kiloscliente.Valor)
                            Case "B"
                                U = VaDec(Albsalida_lineas.ASL_bultos.Valor)
                            Case "P"
                                U = VaDec(Albsalida_lineas.ASL_piezas.Valor)

                        End Select

                        igeneroestimado = U * precio

                        Albsalida_lineas.ASL_precioventa.Valor = precio.ToString ' igualo el precio vta del precio estimado
                        Albsalida_lineas.ASL_tipopreciovta.Valor = tipo
                        Albsalida_lineas.ASL_importegenerovta.Valor = igeneroestimado.ToString ' importe de vta = importe estimado
                        Albsalida_lineas.ASL_importegeneroestimado.Valor = igeneroestimado.ToString

                        Albsalida_lineas.Actualizar()
                        If Not DcAlba.ContainsKey(idalbaran.ToString) Then
                            DcAlba(idalbaran.ToString) = idalbaran.ToString
                        End If
                    End If
                End If

            Next
        End If

        Barra.Maximum = DcAlba.Count + 1
        i = 0
        For Each id In DcAlba.Keys
            i = i + 1
            Barra.Value = i
            If Albsalida.LeerId(id) = True Then
                Albsalida.ASA_valorcambio.Valor = TxCambio.Text
                Albsalida.Actualizar()

                Agro_CalculoGastosTotalesAlbaran(id, VaDec(TxCambio.Text))
            End If
        Next
        MsgBox("Albaranes valorados a precio de referencia")
        BorraPan()

    End Sub

    Public Overrides Sub Informe()
        MyBase.Informe()
        Guardar()
    End Sub

    Private Sub AjustaColumnas(g As DevExpress.XtraGrid.Views.Grid.GridView)


    

        g.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In g.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CAMPA", "IDGENSAL", "IDCAT"
                    c.Visible = False

                Case "BKP"
                    c.Width = 150

                Case "KILOS", "BULTOS", "PIEZAS"
                    c.Width = 250
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n0}"


                Case "PRECIO"
                    c.Width = 250
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n4}"


                Case "PRODUCTO"
                    c.Width = 600
                Case "CATEGORIA"
                    c.Width = 300

            End Select
        Next


        Funciones.AñadeResumenCampo(g, "Kilos", "{0:n0}")
        Funciones.AñadeResumenCampo(g, "Bultos", "{0:n0}")
        Funciones.AñadeResumenCampo(g, "Piezas", "{0:n0}")


    End Sub




    Private Sub TxDFecha_Valida(edicion As Boolean) Handles TxDFecha.Valida
        If edicion = True Then
            _idvalora = PreciosRef.LeerValora(VaInt(TxCliente.Text), TxDFecha.Text)
            If _idvalora > 0 Then
                If PreciosRef.LeerId(_idvalora) = True Then
                    TxAfecha.Text = PreciosRef.PRF_afecha.Valor
                    TxCambio.Text = PreciosRef.PRF_cambio.Valor
                End If
            End If
        End If
    End Sub

    Private Sub TxCambio_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxCambio.TextChanged

    End Sub

    Private Sub TxCambio_Valida(edicion As Boolean) Handles TxCambio.Valida
        If edicion = True Then
            If VaDec(TxCambio.Text) = 0 Then

                Dim Clientes As New E_Clientes(Idusuario, cn)
                If VaInt(TxCliente.Text) > 0 Then
                    If Clientes.LeerId(TxCliente.Text) Then

                        Dim IdDivisa As String = (Clientes.CLI_Iddivisa.Valor & "").Trim
                        If VaInt(IdDivisa) > 0 Then
                            Dim Moneda As New E_Moneda(Idusuario, cn)
                            If Moneda.LeerId(IdDivisa) Then
                                TxCambio.Text = VaDec(Moneda.MON_Cambio.Valor).ToString("#,##0.000000")
                            End If
                        End If

                    End If
                End If

                If VaInt(TxCambio.Text) = 0 Then
                    TxCambio.Text = "1"
                End If

            End If
        End If
    End Sub

    Private Sub GridEditable_Load(sender As System.Object, e As System.EventArgs) Handles GridEditable.Load

        GridEditable.NavegarSoloEditables = True

        cbCentro = ComboCentro(cbCentro, MiMaletin.IdCentro)

    End Sub

    Private Sub GridEditable_Valida(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn) Handles GridEditable.Valida
        If column.FieldName.ToUpper.Trim = "BKP" Then

            If row("BKP").ToString.Trim = "" Then
                row("BXP") = "K"
            End If
            If row("BKP").toupper.ToString <> "B" And row("BKP").ToString.ToUpper <> "P" Then
                row("BKP") = "K"
            Else
                row("BKP") = (row("BKP").ToString & "").ToUpper.Trim
            End If
        End If
    End Sub

    Private Sub TxCliente_Valida(edicion As Boolean) Handles TxCliente.Valida
        If edicion = True Then
            If Clientes.LeerId(TxCliente.Text) = True Then
                _tipoprecio = Clientes.CLI_KB.Valor
                If _tipoprecio = "" Then
                    _tipoprecio = "K"
                End If
            End If
        End If
    End Sub
End Class