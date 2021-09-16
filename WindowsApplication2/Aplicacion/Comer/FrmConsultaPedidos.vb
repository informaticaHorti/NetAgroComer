Imports DevExpress.XtraEditors.Controls
Imports System.Reflection


Public Class FrmConsultaPedidos
    Inherits FrConsulta



    Private Class stClaves_PedidosAlmacen

        Public IdLinea As Integer = 0
        Public IdPedido As Integer = 0
        Public Pedido As String = ""
        Public Fecha As Date
        Public CE As Integer = 0
        Public IdGenero As Integer = 0
        Public Genero As String = ""
        Public IdCliente As Integer = 0
        Public Cliente As String = ""
        Public Referencia As String = ""
        Public IdSubFamilia As Integer = 0
        Public IdPresentacion As Integer = 0
        Public Presentacion As String = ""
        Public IdEnvase As Integer = 0
        Public Envase As String = ""
        Public IdCategoria As Integer = 0
        Public Categoria As String = ""
        Public IdMarca As Integer = 0
        Public Marca As String = ""
        Public IdTipoPalet As Integer = 0
        Public TipoPalet As String = ""
        Public BxP As Integer = 0
        Public Calidad As String = ""
        Public Dias As Integer = 0

        Public DcIdLineasPedido As New Dictionary(Of Integer, stDatosAdicionalesPedido)


        Public Sub New(IdLinea As Integer, IdPedido As Integer, Pedido As String, Fecha As Date, CE As Integer,
                       IdGenero As Integer, Genero As String, IdCliente As Integer, Cliente As String, Referencia As String, IdSubFamilia As Integer,
                       IdPresentacion As Integer, Presentacion As String, IdEnvase As Integer, Envase As String, IdCategoria As Integer, Categoria As String,
                       IdMarca As Integer, Marca As String, IdTipoPalet As Integer, TipoPalet As String, BxP As Integer, Calidad As String, Dias As Integer)


            Me.IdLinea = IdLinea
            Me.IdPedido = IdPedido
            Me.Pedido = Pedido
            Me.Fecha = Fecha
            Me.CE = CE
            Me.IdGenero = IdGenero : Me.Genero = Genero
            Me.IdCliente = IdCliente : Me.Cliente = Cliente
            Me.Referencia = Referencia
            Me.IdSubFamilia = IdSubFamilia
            Me.IdPresentacion = IdPresentacion : Me.Presentacion = Presentacion
            Me.IdEnvase = IdEnvase : Me.Envase = Envase
            Me.IdCategoria = IdCategoria : Me.Categoria = Categoria
            Me.IdMarca = IdMarca : Me.Marca = Marca
            Me.IdTipoPalet = IdTipoPalet : Me.TipoPalet = TipoPalet
            Me.BxP = BxP
            Me.Calidad = Calidad
            Me.Dias = Dias


        End Sub


    End Class


    Public Class stDatos_PedidosAlmacen

        Public Palets As Integer = 0
        Public Reservados As Integer = 0
        Public Stock As Integer = 0
        Public Pendientes As Integer = 0
        Public Sobrantes As Integer = 0
        Public Mensajes As String = ""


        Public Sub New(Palets As Integer, Reservados As Integer, Stock As Integer)
            Me.Palets = Palets
            Me.Reservados = Reservados
            Me.Stock = Stock
        End Sub

    End Class



    Public Class AcumuladorPedidos
        Inherits Acumulador


        Public Overrides Function DataTable() As DataTable

            Dim dt As New DataTable


            '1) Crea las columnas de la estructura
            If Dc.Keys.Count > 0 Then


                Dim indice As Integer = 0

                For Each clave As Object In Dc.Keys
                    If indice = 0 Then

                        'If Not VarClaves(indice).FieldType.Name.StartsWith("Dictionary") Then

                        'End If


                        Dim VarClaves() As FieldInfo = clave.GetType.GetFields(BindingFlags.Instance Or BindingFlags.Public)
                        For Each var As FieldInfo In VarClaves
                            If Not var.FieldType.Name.StartsWith("Dictionary") Then
                                CreaColumna(dt, var)
                            End If
                        Next

                        '2) Crea las columnas de los datos
                        Dim datos As Object = Dc(clave)
                        Dim VarDatos() As FieldInfo = datos.GetType.GetFields(BindingFlags.Instance Or BindingFlags.Public)
                        For Each var As FieldInfo In VarDatos
                            If Not var.FieldType.Name.StartsWith("Dictionary") Then
                                CreaColumna(dt, var, True)
                            End If
                        Next

                        Dim colListaPedidos As New DataColumn("ListaLineas", GetType(String))
                        dt.Columns.Add(colListaPedidos)

                    Else
                        Exit For
                    End If

                    indice = indice + 1
                Next


                dt.Columns.Add("ListaIdPedidos", GetType(String))
                dt.Columns.Add("ListaNumPedidos", GetType(String))
                dt.Columns.Add("ListaReferencias", GetType(String))
                dt.Columns.Add("Lote", GetType(String))
                dt.Columns.Add("PxB", GetType(String))
                dt.Columns.Add("Conf1", GetType(String))
                dt.Columns.Add("Conf2", GetType(String))
                dt.Columns.Add("EtiquetaCesta", GetType(String))
                dt.Columns.Add("EtiquetaCaja", GetType(String))
                dt.Columns.Add("MarcaCesta", GetType(String))
                dt.Columns.Add("MarcaMaterial", GetType(String))
                dt.Columns.Add("EstadoEtiqueta", GetType(String))


            End If





            '3) Ya existen las columnas si no estaban creadas. Ahora introducimos los datos
            For Each clave As Object In Dc.Keys

                'Creamos la fila una vez que tenemos todas las columnas
                Dim row As DataRow = dt.NewRow()


                'Añadimos los valores de la estructura
                Dim VarClaves() As FieldInfo = clave.GetType.GetFields(BindingFlags.Instance Or BindingFlags.Public)
                For Each var As FieldInfo In VarClaves
                    If dt.Columns.Contains(var.Name) Then
                        row(var.Name) = var.GetValue(clave)
                    End If
                Next


                'Añadimos los valores de los datos
                Dim datos As Object = Dc(clave)
                Dim VarDatos() As FieldInfo = datos.GetType.GetFields(BindingFlags.Instance Or BindingFlags.Public)
                For Each var As FieldInfo In VarDatos
                    If dt.Columns.Contains(var.Name) Then
                        row(var.Name) = var.GetValue(datos)
                    End If
                Next


                Dim strListaLineas As String = ""
                Dim strListaIdPedidos As String = ""
                Dim strListaNumPedidos As String = ""
                Dim strListaReferencias As String = ""

                Dim strLotes As String = ""
                Dim strPxB As String = ""
                Dim strConf1 As String = ""
                Dim strConf2 As String = ""
                Dim strEtiquetaCesta As String = ""
                Dim strEtiquetaCaja As String = ""
                Dim strMarcaCesta As String = ""
                Dim strMarcaMaterial As String = ""
                Dim strEstadoEtiqueta As String = ""

                Dim stClave As stClaves_PedidosAlmacen = CType(clave, stClaves_PedidosAlmacen)
                For Each idlinea As Integer In stClave.DcIdLineasPedido.Keys
                    If VaInt(idlinea) > 0 Then


                        If strListaLineas.Trim <> "" Then strListaLineas = strListaLineas & "|;|"
                        strListaLineas = strListaLineas & idlinea.ToString


                        Dim dato As stDatosAdicionalesPedido = stClave.DcIdLineasPedido(idlinea)
                        Dim IdPedido As String = dato.IdPedido : If IdPedido = "" Then IdPedido = " "
                        Dim NumPedido As String = dato.NumPedido : If NumPedido = "" Then NumPedido = " "
                        Dim Referencia As String = dato.Referencias : If Referencia = "" Then Referencia = " "
                        Dim Lotes As String = dato.Lote : If Lotes = "" Then Lotes = " "
                        Dim PxB As String = dato.PxB.ToString : If PxB = "" Then PxB = " "
                        Dim Conf1 As String = dato.Conf1 : If Conf1 = "" Then Conf1 = " "
                        Dim Conf2 As String = dato.Conf2 : If Conf2 = "" Then Conf2 = " "


                        Dim EtiquetaCesta As String = dato.EtiquetaCesta : If EtiquetaCesta = "" Then EtiquetaCesta = " "
                        Dim EtiquetaCaja As String = dato.EtiquetaCaja : If EtiquetaCaja = "" Then EtiquetaCaja = " "
                        Dim MarcaCesta As String = dato.MarcaCesta : If MarcaCesta = "" Then MarcaCesta = " "
                        Dim MarcaMaterial As String = dato.MarcaMaterial : If MarcaMaterial = "" Then MarcaMaterial = " "
                        Dim EstadoEtiqueta As String = dato.EstadoEtiqueta : If EstadoEtiqueta = "" Then EstadoEtiqueta = " "



                        If strListaIdPedidos <> "" Then strListaIdPedidos = strListaIdPedidos & "|;|"
                        strListaIdPedidos = strListaIdPedidos & IdPedido

                        If strListaNumPedidos <> "" Then strListaNumPedidos = strListaNumPedidos & "|;|"
                        strListaNumPedidos = strListaNumPedidos & NumPedido

                        If strListaReferencias <> "" Then strListaReferencias = strListaReferencias & "|;|"
                        strListaReferencias = strListaReferencias & Referencia


                        If strLotes <> "" Then strLotes = strLotes & "|;|"
                        strLotes = strLotes & Lotes

                        If strPxB <> "" Then strPxB = strPxB & "|;|"
                        strPxB = strPxB & PxB

                        If strConf1 <> "" Then strConf1 = strConf1 & "|;|"
                        strConf1 = strConf1 & Conf1

                        If strConf2 <> "" Then strConf2 = strConf2 & "|;|"
                        strConf2 = strConf2 & Conf2

                        If strEtiquetaCesta <> "" Then strEtiquetaCesta = strEtiquetaCesta & "|;|"
                        strEtiquetaCesta = strEtiquetaCesta & EtiquetaCesta

                        If strEtiquetaCaja <> "" Then strEtiquetaCaja = strEtiquetaCaja & "|;|"
                        strEtiquetaCaja = strEtiquetaCaja & EtiquetaCaja

                        If strMarcaCesta <> "" Then strMarcaCesta = strMarcaCesta & "|;|"
                        strMarcaCesta = strMarcaCesta & MarcaCesta

                        If strMarcaMaterial <> "" Then strMarcaMaterial = strMarcaMaterial & "|;|"
                        strMarcaMaterial = strMarcaMaterial & MarcaMaterial

                        If strEstadoEtiqueta <> "" Then strEstadoEtiqueta = strEstadoEtiqueta & "|;|"
                        strEstadoEtiqueta = strEstadoEtiqueta & EstadoEtiqueta


                    End If
                Next

                row("ListaLineas") = strListaLineas

                row("ListaIdPedidos") = strListaIdPedidos
                row("ListaNumPedidos") = strListaNumPedidos
                row("ListaReferencias") = strListaReferencias

                row("Lote") = strLotes
                row("PxB") = strPxB
                row("Conf1") = strConf1
                row("Conf2") = strConf2
                row("EtiquetaCesta") = strEtiquetaCesta
                row("EtiquetaCaja") = strEtiquetaCaja
                row("MarcaCesta") = strMarcaCesta
                row("MarcaMaterial") = strMarcaMaterial
                row("EstadoEtiqueta") = strEstadoEtiqueta


                dt.Rows.Add(row)

            Next


            Return dt

        End Function


        Public Sub SumaPedido(stClave As Object, stDatos As Object, IdLineaOriginalPedido As Integer, stDatosAdicionalesPedido As stDatosAdicionalesPedido)

            Dim ClaveEncontrada As stClaves_PedidosAlmacen = Suma(stClave, stDatos)
            ClaveEncontrada.DcIdLineasPedido(IdLineaOriginalPedido) = stDatosAdicionalesPedido

        End Sub


    End Class



    Public Structure stDatosAdicionalesPedido

        Public IdPedido As String
        Public NumPedido As String
        Public Referencias As String
        Public Lote As String
        Public PxB As Integer
        Public Conf1 As String
        Public Conf2 As String
        Public EtiquetaCaja As String
        Public EtiquetaCesta As String
        Public MarcaMaterial As String
        Public MarcaCesta As String
        Public EstadoEtiqueta As String

    End Structure



    Dim Pedidos As New E_Pedidos(Idusuario, cn)
    Dim pedidos_lineas As New E_Pedidos_lineas(Idusuario, cn)
    Dim Pedidos_Almacen As New E_pedidos_almacen(Idusuario, cn)
    Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
    Dim Palets As New E_palets(Idusuario, cn)
    Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim Marca As New E_Marcas(Idusuario, cn)
    Dim AlbSalida_Palets As New E_albsalida_palets(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)


    Dim IdPedido As Integer


    Private _bCargado As Boolean = False

    Private _dtDesglose As DataTable
    Private _filtros As String = ""


    Dim err As New Errores




    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxFechaSalida, Pedidos.PED_fechapedido, Lb1)
        cbCentro = ComboCentro(cbCentro, MiMaletin.IdCentro)
        ParamTx(TxCliente, Pedidos.PED_idcliente, Lb_4)
        ParamTx(TxGenero, pedidos_lineas.PEL_idgenero, Lb27)


        AsociarControles(TxCliente, BtBuscaCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomCliente)
        AsociarControles(TxGenero, BtBuscaGenero, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomGenero)



        CargaLineas()

    End Sub


    Private Sub CargaLineas()

        Dim sql As String
        Dim lineas As New E_Lineas(Idusuario, cn)
        Dim consulta As New Cdatos.E_select
        Dim dT As New DataTable
        consulta.SelCampo(lineas.LIN_Idlinea, "Codigo")
        consulta.SelCampo(lineas.LIN_Nombre, "Nombre")
        sql = consulta.SQL
        sql = sql + CadenaWhereLista(lineas.LIN_Idcentro, ListadeCombo(cbCentro), " where ")

        dT = ConexCtb(MiMaletin.IdEmpresaCTB).ConsultaSQL(sql)

        CbLineas.Properties.DataSource = dT
        CbLineas.Properties.ValueMember = "Codigo"
        CbLineas.Properties.DisplayMember = "Nombre"


        For Each it As CheckedListBoxItem In CbLineas.Properties.GetItems()
            it.CheckState = CheckState.Checked
        Next

    End Sub



    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub FrmConsultaPaletsResumida_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente
        nueva_fuente = New Font("Verdana", 10, FontStyle.Bold)
        GridView1.Appearance.Row.Font = nueva_fuente

        _bCargado = True


        _dtDesglose = New DataTable
        _dtDesglose.Columns.Add("Pedido", GetType(String))
        _dtDesglose.Columns.Add("Referencia", GetType(String))



        If UsuarioAdministracion Then
            chkRefrescar.Visible = True
        Else
            chkRefrescar.Visible = False
        End If


        BInforme.Visible = False

    End Sub


    Private Sub Fechaspordefecto()
        TxFechaSalida.Text = Now.ToShortDateString

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        IdPedido = 0


        Grid.DataSource = Nothing
        GridView1.Columns.Clear()

        Dim consulta As New Cdatos.E_select
        Dim pedidos_lineas As New E_Pedidos_lineas(Idusuario, cn)
        Dim pedidos_almacen As New E_pedidos_almacen(Idusuario, cn)
        Dim pedidos As New E_Pedidos(Idusuario, cn)
        Dim Clientes As New E_Clientes(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim Generossalida As New E_GenerosSalida(Idusuario, cn)
        Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim CategoriasComercial As New E_CategoriasComercial(Idusuario, cn)
        Dim Marcas As New E_Marcas(Idusuario, cn)
        Dim MensajesEntidades As New E_mensajesentidades(Idusuario, cn)


        consulta.SelCampo(pedidos_almacen.PAC_id, "id")
        consulta.SelCampo(pedidos_lineas.PEL_idlinea, "idlinea", pedidos_almacen.PAC_idlineapedido)
        consulta.SelCampo(pedidos.PED_idpedido, "idpedido", pedidos_lineas.PEL_idpedido)
        consulta.SelCampo(pedidos.PED_pedido, "pedido")
        consulta.SelCampo(pedidos.PED_fechasalida, "Fecha")
        'consulta.SelCampo(Centros.Nombre, "Centro", pedidos_almacen.PAC_idalmacen)
        consulta.SelCampo(pedidos_almacen.PAC_idalmacen, "CE")
        consulta.SelCampo(pedidos_lineas.PEL_idgenero, "IdGenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", pedidos_lineas.PEL_idgenero, Generos.GEN_IdGenero)
        consulta.SelCampo(pedidos.PED_idcliente, "IdCliente")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", pedidos.PED_idcliente)
        consulta.SelCampo(pedidos.PED_referencia, "referencia")
        consulta.SelCampo(Generos.GEN_IdsubFamilia, "idsubfamilia")
        consulta.SelCampo(pedidos_lineas.PEL_idgensal, "IdPresentacion")
        consulta.SelCampo(Generossalida.GES_Nombre, "Presentacion", pedidos_lineas.PEL_idgensal)
        consulta.SelCampo(ConfecEnvase.CEV_IdEnvase, "IdEnvase", pedidos_lineas.PEL_idtipoconfeccion, ConfecEnvase.CEV_Idconfec)
        consulta.SelCampo(Envases.ENV_Nombre, "Envase", ConfecEnvase.CEV_IdEnvase, Envases.ENV_IdEnvase)
        consulta.SelCampo(pedidos_lineas.PEL_idcategoria, "IdCategoria")
        consulta.SelCampo(CategoriasComercial.CAC_Nombre, "Categoria", pedidos_lineas.PEL_idcategoria)
        consulta.SelCampo(pedidos_lineas.PEL_idmarca, "IdMarca")
        consulta.SelCampo(Marcas.MAR_Nombre, "Marca", pedidos_lineas.PEL_idmarca)
        consulta.SelCampo(pedidos_lineas.PEL_idtipopalet, "IdTipoPalet")
        consulta.SelCampo(ConfecPalet.CPA_Nombre, "TipoPalet", pedidos_lineas.PEL_idtipopalet, ConfecPalet.CPA_Idconfec)
        consulta.SelCampo(pedidos_lineas.PEL_bultospalet, "BxP")
        consulta.SelCampo(pedidos_lineas.PEL_calidad, "AB")
        consulta.SelCampo(pedidos_lineas.PEL_maxdias, "Dias")
        consulta.SelCampo(pedidos_almacen.PAC_palets, "Palets")
        consulta.SelCampo(pedidos_lineas.PEL_reservapalets, "ReservaPalets")

        consulta.SelCampo(pedidos_lineas.PEL_obslote, "Lote")
        consulta.SelCampo(pedidos_lineas.PEL_piezasbulto, "PxB")
        consulta.SelCampo(pedidos_lineas.PEL_obsconfec1, "Conf1")
        consulta.SelCampo(pedidos_lineas.PEL_obsconfec2, "Conf2")


        consulta.WheCampo(pedidos.PED_fechasalida, ">=", TxFechaSalida.Text)

        If TxCliente.Text.Trim <> "" Then consulta.WheCampo(pedidos.PED_idcliente, "=", TxCliente.Text)
        If TxGenero.Text.Trim <> "" Then consulta.WheCampo(pedidos_lineas.PEL_idgenero, "=", TxGenero.Text)


        Dim WHE As String = consulta.Whe
        'Dim WHE As String = " WHERE (PED_FechaSalida >= '" & TxDato1.Text & "' OR COALESCE(PED_FechaSalida, '01/01/1900') = '01/01/1900')" & vbCrLf
        WHE = WHE + CadenaWhereLista(pedidos_almacen.PAC_idalmacen, ListadeCombo(cbCentro), " AND ") & vbCrLf
        WHE = WHE + CadenaWhereLista(Generos.GEN_IdsubFamilia, FiltroSubfamilia, "AND ") & vbCrLf
        If rbSalidos.Checked Then

            WHE = WHE & " AND (SELECT COUNT(ASA_IdAlbaran) FROM AlbSalida WHERE ASA_IdPedido = PEL_IdPedido) > 0 " & vbCrLf

        End If


        Dim sql As String = consulta.Sel + WHE
        Dim dt As DataTable = pedidos.MiConexion.ConsultaSQL(sql)

        'Líneas de pedido
        Dim acum As New AcumuladorPedidos

        For Each row As DataRow In dt.Rows

            Dim IdLinea As Integer = VaInt(row("IdLinea"))
            Dim IdPedido As Integer = VaInt(row("IdPedido"))
            Dim Pedido As String = (row("Pedido").ToString & "").Trim
            'Dim Fecha As String = "" : If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
            Dim Fecha As Date = VaDate(row("Fecha"))
            Dim CE As Integer = VaInt(row("CE"))
            Dim IdGenero As Integer = VaInt(row("IdGenero"))
            Dim Genero As String = (row("Genero").ToString & "").Trim
            Dim IdCliente As String = VaInt(row("IdCliente"))
            Dim Cliente As String = (row("Cliente").ToString & "").Trim
            Dim Referencia As String = (row("Referencia").ToString & "").Trim
            Dim IdSubFamilia As Integer = VaInt(row("IdSubFamilia"))
            Dim IdPresentacion As Integer = VaInt(row("IdPresentacion"))
            Dim Presentacion As String = (row("Presentacion").ToString & "").Trim
            Dim IdEnvase As Integer = VaInt(row("IdEnvase"))
            Dim Envase As String = (row("Envase").ToString & "").Trim
            Dim IdCategoria As Integer = VaInt(row("IdCategoria"))
            Dim Categoria As String = (row("Categoria").ToString & "").Trim
            Dim IdMarca As Integer = VaInt(row("IdMarca"))
            Dim Marca As String = (row("Marca").ToString & "").Trim
            Dim IdTipoPalet As Integer = VaInt(row("IdTipoPalet"))
            Dim TipoPalet As String = (row("TipoPalet").ToString & "").Trim
            Dim BxP As Integer = VaInt(row("BxP"))
            Dim Calidad As String = (row("AB").ToString & "").Trim
            Dim Dias As Integer = VaInt(row("Dias"))
            Dim Palets As Integer = VaInt(row("Palets"))
            Dim ReservaPalets As Boolean = (row("ReservaPalets").ToString & "").ToUpper.Trim = "S"
            Dim IdLineaOriginalPedido As Integer = IdLinea
            Dim IdPedidoOriginal As Integer = IdPedido
            Dim NumPedido As Integer = VaInt(Pedido)
            'Dim ReferenciaOrig As String = Referencia


            Dim Lote As String = row("Lote").ToString
            Dim PxB As Integer = VaDec(row("PxB"))
            Dim Conf1 As String = row("Conf1").ToString
            Dim Conf2 As String = row("Conf2").ToString

            Dim EtiquetaCaja As String = ""
            Dim EtiquetaCesta As String = ""
            Dim MarcaMaterial As String = ""
            Dim MarcaCesta As String = ""
            Dim Estado As Integer = 0
            Dim EstadoEtiquetaStr As String = EstadoEtiqueta(IdLinea, Estado)
            EtiquetasCestaCaja(IdLinea, EtiquetaCesta, EtiquetaCaja, MarcaCesta, MarcaMaterial)



            Dim stDatosAdicionalesPedido As New stDatosAdicionalesPedido
            stDatosAdicionalesPedido.IdPedido = IdPedido.ToString
            stDatosAdicionalesPedido.NumPedido = NumPedido.ToString
            stDatosAdicionalesPedido.Referencias = Referencia
            stDatosAdicionalesPedido.Lote = Lote
            stDatosAdicionalesPedido.PxB = PxB
            stDatosAdicionalesPedido.Conf1 = Conf1
            stDatosAdicionalesPedido.Conf2 = Conf2
            stDatosAdicionalesPedido.EtiquetaCaja = EtiquetaCaja
            stDatosAdicionalesPedido.EtiquetaCesta = EtiquetaCesta
            stDatosAdicionalesPedido.MarcaMaterial = MarcaMaterial
            stDatosAdicionalesPedido.MarcaCesta = MarcaCesta
            stDatosAdicionalesPedido.EstadoEtiqueta = EstadoEtiquetaStr


            If Not ReservaPalets Then
                IdLinea = 0
                IdPedido = 0
                Pedido = "VARIOS"
                Referencia = "VARIAS"
            End If



            Dim stClave As New stClaves_PedidosAlmacen(IdLinea, IdPedido, Pedido, Fecha, CE, IdGenero, Genero, IdCliente, Cliente, Referencia,
                                                       IdSubFamilia, IdPresentacion, Presentacion, IdEnvase, Envase, IdCategoria, Categoria, IdMarca, Marca,
                                                       IdTipoPalet, TipoPalet, BxP, Calidad, Dias)
            Dim stDatos As New stDatos_PedidosAlmacen(Palets, 0, 0)
            acum.SumaPedido(stClave, stDatos, IdLineaOriginalPedido, stDatosAdicionalesPedido)


        Next


        dt = acum.DataTable

        For Each row As DataRow In dt.Rows

            'corregimos los que no sean varios
            Dim Pedido As String = (row("pedido").ToString & "").ToUpper.Trim
            If Pedido = "VARIOS" Then

                Dim ListaLineas As String = (row("ListaLineas").ToString & "").Trim
                Dim ListaIdPedidos As String = (row("ListaIdPedidos").ToString & "").Trim
                Dim ListaNumPedidos As String = (row("ListaNumPedidos").ToString & "").Trim
                Dim ListaReferencias As String = (row("ListaReferencias").ToString & "").Trim


                Dim IdLineasPedidos As String() = Split(ListaLineas, "|;|")
                If IdLineasPedidos.Length = 1 Then row("idlinea") = VaInt(IdLineasPedidos(0))

                Dim IdPedidos As String() = Split(ListaIdPedidos, "|;|")
                If IdPedidos.Length = 1 Then row("idpedido") = VaInt(IdPedidos(0))

                Dim NumPedidos As String() = Split(ListaNumPedidos, "|;|")
                If NumPedidos.Length = 1 Then row("pedido") = VaInt(NumPedidos(0))

                Dim Referencias As String() = Split(ListaReferencias, "|;|")
                If Referencias.Length = 1 Then row("referencia") = Referencias(0)


            End If

            ActualizaPendientesFila(row)

        Next

        dt = CompletarGrid(dt)



        Dim filtros As String = ""

        If rbTerminados.Checked Then
            filtros = "PALETS > 0 AND Pendientes = 0"
        ElseIf rbPendientes.Checked Then
            filtros = "Pendientes > 0"
        ElseIf rbSalidos.Checked Then
            'TODO: 
        End If

        If ChkSoloStock.Checked Then
            If filtros.Trim <> "" Then filtros = filtros & " AND "
            filtros = filtros & "ISNULL(Pedido,'') = ''"
        End If


        If filtros.Trim <> "" Then
            Dim dv As New DataView(dt)
            dv.RowFilter = filtros
            dt = dv.ToTable
        End If



        Grid.DataSource = dt
        AjustaColumnas()


    End Sub


    Private Sub MuestraDesglose(row As DataRow)


        'Borramos
        If Not IsNothing(_dtDesglose) Then

            If Not IsNothing(row) Then

                Dim Pedidos As String() = Split(row("ListaNumPedidos").ToString & "", "|;|")
                Dim Referencias As String() = Split(row("ListaReferencias").ToString & "", "|;|")

                Dim dt As DataTable = _dtDesglose.Copy
                For indice As Integer = 0 To Pedidos.Length - 1

                    Dim fila As DataRow = dt.NewRow
                    fila("Pedido") = Pedidos(indice)
                    If indice <= Referencias.Length - 1 Then
                        fila("Referencia") = Referencias(indice)
                    End If
                    dt.Rows.Add(fila)
                Next

            End If

        End If




    End Sub


    Private Function CompletarGrid(ByRef dt As DataTable) As DataTable


        If dt.Rows.Count = 0 Then
            Dim col As New DataColumn("IdLinea", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("IdPedido", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("Pedido", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("Fecha", GetType(Date))
            dt.Columns.Add(col)
            col = New DataColumn("CE", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("IdGenero", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("Genero", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("IdCliente", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("Cliente", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("Referencia", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("IdSubFamilia", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("IdPresentacion", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("Presentacion", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("IdEnvase", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("Envase", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("IdCategoria", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("Categoria", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("IdMarca", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("Marca", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("IdTipoPalet", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("TipoPalet", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("BxP", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("Calidad", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("Dias", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("Palets", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("Reservados", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("Stock", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("Pendientes", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("Sobrantes", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("Mensajes", GetType(Integer))
            dt.Columns.Add(col)
            col = New DataColumn("ListaLineas", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("ListaIdPedidos", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("ListaNumPedidos", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("ListaReferencias", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("Lote", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("PxB", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("Conf1", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("Conf2", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("EtiquetaCesta", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("EtiquetaCaja", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("MarcaCesta", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("MarcaMaterial", GetType(String))
            dt.Columns.Add(col)
            col = New DataColumn("EstadoEtiqueta", GetType(String))
            dt.Columns.Add(col)

        End If


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(Palets_Lineas.PLL_idpedidolinea, "idlinea")
        CONSULTA.SelCampo(Palets_Lineas.PLL_TipoReserva, "TipoReserva")
        CONSULTA.SelCampo(pedidos_lineas.PEL_idlinea, "IdPedidoLinea", Palets_Lineas.PLL_idpedidolinea, pedidos_lineas.PEL_idlinea)
        CONSULTA.SelCampo(pedidos_lineas.PEL_palets, "Palets")
        CONSULTA.SelCampo(Pedidos.PED_idpedido, "idpedido", pedidos_lineas.PEL_idpedido)
        CONSULTA.SelCampo(Pedidos.PED_pedido, "pedido")
        CONSULTA.SelCampo(Palets.PAL_fecha, "Fecha", Palets_Lineas.PLL_idpalet)
        'CONSULTA.SelCampo(Centros.Nombre, "Centro", Palets.PAL_idcentro, Centros.IdCentro)
        CONSULTA.SelCampo(Palets.PAL_idcentro, "CE")
        CONSULTA.SelCampo(Palets_Lineas.PLL_idgenero, "IdGenero")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero", Palets_Lineas.PLL_idgenero, Generos.GEN_IdGenero)
        CONSULTA.SelCampo(Pedidos.PED_idcliente, "IdCliente")
        CONSULTA.SelCampo(Clientes.CLI_Nombre, "Cliente", Pedidos.PED_idcliente)
        CONSULTA.SelCampo(Pedidos.PED_referencia, "referencia")
        CONSULTA.SelCampo(Generos.GEN_IdsubFamilia, "idsubfamilia")
        CONSULTA.SelCampo(Palets_Lineas.PLL_idgensal, "IdPresentacion")
        CONSULTA.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", Palets_Lineas.PLL_idgensal)
        CONSULTA.SelCampo(Palets_Lineas.PLL_idenvase, "IdEnvase")
        CONSULTA.SelCampo(Envases.ENV_Nombre, "Envase", Palets_Lineas.PLL_idenvase, Envases.ENV_IdEnvase)
        CONSULTA.SelCampo(Palets_Lineas.PLL_idcategoria, "IdCategoria")
        CONSULTA.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", Palets_Lineas.PLL_idcategoria)
        CONSULTA.SelCampo(Palets_Lineas.PLL_idmarca, "IdMarca")
        CONSULTA.SelCampo(Marca.MAR_Nombre, "Marca", Palets_Lineas.PLL_idmarca)
        CONSULTA.SelCampo(Palets.PAL_idtipopalet, "IdTipoPalet")
        CONSULTA.SelCampo(ConfecPalet.CPA_Nombre, "TipoPalet", Palets.PAL_idtipopalet, ConfecPalet.CPA_Idconfec)
        CONSULTA.SelCampo(Palets_Lineas.PLL_bultos, "BxP")
        Dim oCalidad As New Cdatos.bdcampo("@COALESCE(PLL_Calidad,'A')", Cdatos.TiposCampo.Cadena, 1)
        CONSULTA.SelCampo(oCalidad, "Calidad")
        Dim oDias As New Cdatos.bdcampo("@DATEDIFF(day, PAL_Fecha, GETDATE())", Cdatos.TiposCampo.Entero, 10)
        CONSULTA.SelCampo(oDias, "Dias")
        CONSULTA.SelCampo(AlbSalida_Palets.ASP_IdAlbaran, "IdAlbaran", Palets.PAL_idpalet, AlbSalida_Palets.ASP_Idpalet)
        CONSULTA.SelCampo(pedidos_lineas.PEL_obslote, "Lote")
        CONSULTA.SelCampo(pedidos_lineas.PEL_piezasbulto, "PxB")
        CONSULTA.SelCampo(pedidos_lineas.PEL_obsconfec1, "Conf1")
        CONSULTA.SelCampo(pedidos_lineas.PEL_obsconfec2, "Conf2")


        Dim sql As String = CONSULTA.SQL & vbCrLf

        'Salidos
        If Not rbSalidos.Checked Then
            sql = sql & " WHERE COALESCE(ASP_IdPalet, 0) = 0" & vbCrLf
        Else
            sql = sql & " WHERE COALESCE(ASP_IdAlbaran,0) > 0 " & vbCrLf
        End If


        'Cliente
        If TxCliente.Text <> "" Then
            sql = sql & " AND PAL_IdClientePedido = " & TxCliente.Text & vbCrLf
        End If

        'Genero 
        If TxGenero.Text <> "" Then
            sql = sql & " AND PLL_IdGenero = " & TxGenero.Text & vbCrLf
        End If



        sql = "SELECT * FROM " & vbCrLf & " (" & vbCrLf & sql & vbCrLf & " ) AS X" & vbCrLf
        sql = sql & " ORDER BY IdLinea DESC, Dias DESC, TipoReserva DESC" & vbCrLf
        'sql = sql & " ORDER BY PLL_IdPedidoLinea DESC" & vbCrLf


        Dim dtPalets As DataTable = pedidos_lineas.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dtPalets) Then

            'Recorremos los palets
            For Each rowPalet As DataRow In dtPalets.Rows

                'Recorremos el grid
                Dim TotFilas As Integer = dt.Rows.Count - 1



                Dim rowEncontradoReserv As DataRow = Nothing
                Dim rowEncontradoStock As DataRow = Nothing
                Dim IdPedidoLinea_Palet As String = (rowPalet("idlinea").ToString & "").Trim
                Dim TipoReserva As String = (rowPalet("TipoReserva").ToString & "").ToUpper.Trim


                For indice As Integer = 0 To TotFilas
                    Dim row As DataRow = dt.Rows(indice)
                    If Not IsNothing(row) Then



                        Dim IdPedidoLinea As String = (row("idlinea").ToString & "").Trim

                        If VaInt(IdPedidoLinea_Palet) > 0 Then

                            If IdPedidoLinea_Palet = IdPedidoLinea And VaInt(IdPedidoLinea_Palet) > 0 And TipoReserva = "R" Then

                                'Reservados
                                rowEncontradoReserv = row
                                Exit For

                            ElseIf IdPedidoLinea_Palet = IdPedidoLinea And VaInt(IdPedidoLinea_Palet) > 0 And TipoReserva = "A" Then

                                'Stock directo
                                rowEncontradoStock = row
                                Exit For

                            End If

                        ElseIf CoincideLinea(rowPalet, row, False) And (row("Pedido").ToString & "").Trim <> "" And (row("Pedido").ToString & "").Trim <> "STOCK" Then

                            'Stock (con o sin pendientes  )
                            rowEncontradoStock = row
                            Exit For

                        End If

                        ActualizaPendientesFila(row)

                    End If


                Next




                If VaInt(IdPedidoLinea_Palet) > 0 And TipoReserva = "R" Then

                    If Not IsNothing(rowEncontradoReserv) Then
                        rowEncontradoReserv("Reservados") = VaInt(rowEncontradoReserv("Reservados")) + 1
                        ActualizaPendientesFila(rowEncontradoReserv)
                    Else
                        NuevaFila(rowPalet, dt, "R")
                    End If

                ElseIf Not IsNothing(rowEncontradoStock) Then

                    Dim Pendientes As Integer = VaInt(rowEncontradoStock("Palets")) - VaInt(rowEncontradoStock("Reservados")) - VaInt(rowEncontradoStock("Stock"))

                    If chkMostrarStock.Checked Then
                        'Si existe la fila y tiene pendientes, suma el stock, si no, suma en la columna de exceso
                        If Pendientes > 0 Then
                            rowEncontradoStock("Stock") = VaInt(rowEncontradoStock("Stock")) + 1
                        Else
                            rowEncontradoStock("Sobrantes") = VaInt(rowEncontradoStock("Sobrantes")) + 1
                        End If
                    End If
                    ActualizaPendientesFila(rowEncontradoStock)

                Else

                    If chkMostrarStock.Checked Then

                        'Fuera de Stock
                        Dim rowEncontradoExistencias As DataRow = Nothing

                        'Comprobar que si coincide con alguna línea de fuera de stock
                        For indice As Integer = 0 To TotFilas
                            Dim row As DataRow = dt.Rows(indice)
                            If Not IsNothing(row) Then

                                'Busca entre las existencias, por si existe ya una fila con las mismas características
                                If (row("Pedido").ToString & "").Trim = "" Then
                                    If CoincideLinea(rowPalet, row, True) Then
                                        rowEncontradoExistencias = row
                                        Exit For
                                    End If
                                End If

                            End If

                        Next


                        If Not IsNothing(rowEncontradoExistencias) Then
                            If chkMostrarStock.Checked Then
                                rowEncontradoExistencias("Sobrantes") = VaInt(rowEncontradoExistencias("Sobrantes")) + 1
                            End If
                            ActualizaPendientesFila(rowEncontradoExistencias)
                        Else
                            NuevaFila(rowPalet, dt, "E")
                        End If


                    End If

                End If


            Next


        End If




        Return dt

    End Function


    Private Sub NuevaFila(ByVal rowPalet As DataRow, ByRef dt As DataTable, Tipo As String)


        Dim fila As DataRow = dt.NewRow()
        fila("IdLinea") = rowPalet("IdLinea")
        fila("IdPedido") = rowPalet("IdPedido")
        fila("Pedido") = rowPalet("Pedido")
        fila("Fecha") = rowPalet("Fecha")
        fila("CE") = rowPalet("CE")
        fila("IdGenero") = rowPalet("IdGenero")
        fila("Genero") = rowPalet("Genero")
        fila("IdCliente") = rowPalet("IdCliente")
        fila("Cliente") = rowPalet("Cliente")
        fila("Referencia") = rowPalet("Referencia")
        fila("IdSubFamilia") = rowPalet("IdSubFamilia")
        fila("IdPresentacion") = rowPalet("IdPresentacion")
        fila("Presentacion") = rowPalet("Presentacion")
        fila("IdEnvase") = rowPalet("IdEnvase")
        fila("Envase") = rowPalet("Envase")
        fila("IdCategoria") = rowPalet("IdCategoria")
        fila("Categoria") = rowPalet("Categoria")
        fila("IdMarca") = rowPalet("IdMarca")
        fila("Marca") = rowPalet("Marca")
        fila("IdTipoPalet") = rowPalet("IdTipoPalet")
        fila("TipoPalet") = rowPalet("TipoPalet")
        fila("Calidad") = rowPalet("Calidad")
        fila("BxP") = rowPalet("BxP")
        fila("Dias") = rowPalet("Dias")



        Dim IdPedidoLinea As String = rowPalet("IdLinea").ToString

        If VaInt(IdPedidoLinea) > 0 Then

            Dim EtiquetaCaja As String = ""
            Dim EtiquetaCesta As String = ""
            Dim MarcaMaterial As String = ""
            Dim MarcaCesta As String = ""
            Dim Estado As Integer = 0
            Dim EstadoEtiquetaStr As String = EstadoEtiqueta(IdPedidoLinea, Estado)
            EtiquetasCestaCaja(IdPedidoLinea, EtiquetaCesta, EtiquetaCaja, MarcaCesta, MarcaMaterial)

            fila("EtiquetaCesta") = EtiquetaCesta
            fila("EtiquetaCaja") = EtiquetaCaja
            fila("MarcaCesta") = MarcaCesta
            fila("MarcaMaterial") = MarcaMaterial
            fila("EstadoEtiqueta") = EstadoEtiquetaStr

        End If


        ActualizaPendientesFila(fila)


        If Tipo = "R" Then
            fila("Palets") = rowPalet("Palets")
            fila("Reservados") = 1
        ElseIf Tipo = "S" Then
            If chkMostrarStock.Checked Then
                fila("Stock") = 1
            End If

        Else
            If chkMostrarStock.Checked Then
                fila("Sobrantes") = 1
            End If
        End If

        dt.Rows.Add(fila)

    End Sub


    Private Sub ActualizaPendientesFila(row As DataRow)

        'Pendientes
        Dim Ptes As Integer = VaInt(row("Palets")) - VaInt(row("Reservados")) - VaInt(row("Stock"))
        If Ptes < 0 Then Ptes = 0
        row("Pendientes") = Ptes

    End Sub


    Private Function CoincideLinea(rowPalet As DataRow, row As DataRow, b As Boolean) As Boolean

        Dim bRes As Boolean = False


        Dim IdPresentacion_Palet As String = VaInt(rowPalet("IdPresentacion")).ToString
        Dim IdCatSalida As String = VaInt(rowPalet("IdCategoria")).ToString
        Dim lstCategorias As List(Of String) = CategoriaComercial(IdCatSalida)
        Dim DcCateg As New Dictionary(Of String, String)
        For Each cat As String In lstCategorias
            DcCateg(cat) = cat
        Next
        Dim IdMarca_Palet As String = VaInt(rowPalet("IdMarca")).ToString
        Dim IdTipoPalet_Palet As String = VaInt(rowPalet("IdTipoPalet")).ToString
        Dim Calidad_Palet As String = (rowPalet("Calidad").ToString & "").ToUpper.Trim
        Dim NumDias_Palet As String = VaInt(rowPalet("Dias")).ToString
        Dim BxP_Palet As String = VaInt(rowPalet("BxP")).ToString


        'Comprobar si coincide con la línea del grid
        Dim IdPresentacion As String = VaInt(row("IdPresentacion")).ToString
        Dim IdCategoria As String = VaInt(row("IdCategoria")).ToString
        Dim IdMarca As String = VaInt(row("IdMarca")).ToString
        Dim IdTipoPalet As String = VaInt(row("IdTipoPalet")).ToString
        Dim Calidad As String = (row("Calidad").ToString & "").ToUpper.Trim
        Dim NumDias As String = VaInt(row("Dias")).ToString
        Dim BxP As String = VaInt(row("BxP")).ToString


        If Calidad_Palet = "C" Then
            Dim a As String = ""
        End If


        If IdPresentacion = IdPresentacion_Palet And
            DcCateg.ContainsKey(IdCategoria) And
            IdMarca = IdMarca_Palet And
            IdTipoPalet = IdTipoPalet_Palet And
            Calidad >= Calidad_Palet And
            NumDias >= NumDias_Palet And
            BxP = BxP_Palet Then

            'Coincide!
            bRes = True

        End If



        Return bRes

    End Function


    Public Function CategoriaSalida(IdCatComercial As String) As List(Of String)

        Dim lst As New List(Of String)

        Dim sql As String = "SELECT CSC_IdCatSalida as Id FROM CatSalidaComercial WHERE CSC_IdCatComercial = " + IdCatComercial
        Dim dt As DataTable = pedidos_lineas.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each row As DataRow In dt.Rows
                Dim Id As String = (row("Id").ToString & "").Trim
                lst.Add(Id)
            Next
        End If

        Return lst

    End Function


    Public Function CategoriaComercial(IdCatSalida As String) As List(Of String)

        Dim lst As New List(Of String)

        Dim sql As String = "SELECT CSC_IdCatComercial as Id FROM CatSalidaComercial WHERE CSC_IdCatSalida = " + IdCatSalida
        Dim dt As DataTable = pedidos_lineas.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each row As DataRow In dt.Rows
                Dim Id As String = (row("Id").ToString & "").Trim
                lst.Add(Id)
            Next
        End If

        Return lst

    End Function



    Private Function FiltroSubfamilia() As List(Of String)

        ' devuelvo una lista con las subfamilias de las lineas
        Dim sql As String
        Dim lineas_producto As New E_Lineas_producto(Idusuario, cn)
        Dim lst As New List(Of String)
        For Each it As CheckedListBoxItem In CbLineas.Properties.GetItems()
            Dim Consulta As New Cdatos.E_select
            If it.CheckState = CheckState.Checked Then
                Consulta.SelCampo(lineas_producto.LNP_idsubfamilia, "idsubfamilia")
                Consulta.WheCampo(lineas_producto.LNP_idlinea, "=", it.Value.ToString)
                sql = Consulta.SQL
                Dim dt As DataTable = lineas_producto.MiConexion.ConsultaSQL(sql)
                If Not dt Is Nothing Then
                    For Each rw In dt.Rows
                        lst.Add(rw("idsubfamilia").ToString)
                    Next
                End If
            End If
        Next



        Return lst

    End Function


    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "PALETS", "BULTOS", "PIEZAS", "MENSAJES", "PTES", "RESERV", "STOCK", "BXP"
                    c.Width = 60

                Case "PEDIDO"
                    c.MinWidth = 65

                Case "RESERVADOS"
                    c.Caption = "Reserv"
                    c.Width = 60

                Case "PENDIENTES"
                    c.Caption = "Ptes"
                    c.Width = 60

                Case "EXCESO", "SOBRANTES"
                    c.Caption = "Sobrante"
                    c.Width = 60

                Case "CE"
                    c.MinWidth = 25
                    c.MaxWidth = 25

                Case "CATEGORIA", "ESTADO", "REFERENCIA", "MARCA", "TIPOPALET"
                    c.Width = 100

                Case "FECHA"
                    c.Width = 100
                    c.Visible = False
                    'c.GroupIndex = 0

                    GridView1.ExpandAllGroups()

                Case "CLIENTE", "PRESENTACION", "GENERO"
                    c.Width = 150


                Case "CALIDAD"
                    c.Caption = "AB"
                    c.Width = 40

                Case "AB", "DIAS"
                    c.Width = 40

                Case Else
                    c.Visible = False
            End Select
        Next





    End Sub


    Private Function EstadoEtiqueta(IdLineaPedido As String, ByRef CodEstado As Integer) As String

        Dim res As String = ""
        CodEstado = -1
        'ReqAprobacion = False


        If VaInt(IdLineaPedido) > 0 Then

            Dim sql As String = "SELECT PAC_EstadoEtiqueta as Estado, PEL_requiereaprobacion as Aprobacion" & vbCrLf
            sql = sql & " FROM Pedidos_Lineas" & vbCrLf
            sql = sql & " LEFT JOIN Pedidos_Almacen ON PAC_IdLineaPedido = PEL_IdLinea" & vbCrLf
            sql = sql & " WHERE PEL_IdLinea = " & IdLineaPedido & vbCrLf
            sql = sql & " AND PEL_GeneraTrabajo = 'S'" & vbCrLf

            Dim dt As DataTable = Pedidos_Almacen.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim estado As Integer = VaInt(dt.Rows(0)("Estado"))
                    Dim ReqAprobacion As Boolean = ((dt.Rows(0)("Aprobacion").ToString & "").ToUpper.Trim = "S")
                    Select Case estado

                        Case 9
                            res = "FINALIZADA"
                            CodEstado = estado

                        Case 2
                            res = "PTE. IMPRIMIR"
                            CodEstado = estado

                        Case 1
                            res = "PTE. CONF. CLIENTE"
                            CodEstado = estado

                        Case 0
                            If ReqAprobacion Then
                                res = "PTE. ENVIO MUESTRA"
                                CodEstado = estado
                            Else
                                res = "PTE. IMPRIMIR"
                                CodEstado = 2
                            End If

                    End Select


                End If
            End If


        End If



        Return res

    End Function


    Protected Overrides Sub RowCellStyle(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn, sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        MyBase.RowCellStyle(row, column, sender, e)


        If Not IsNothing(row) Then

            'Color columna mensajes según haya o no
            If e.Column.FieldName.Trim.ToUpper = "MENSAJES" Then
                Select Case VaInt(row("mensajes"))
                    Case 0
                        e.Appearance.BackColor = Color.LightGreen
                    Case Else
                        e.Appearance.BackColor = Color.Red
                End Select

            End If


            'Color de fuente según sea línea de pedido o de palet
            Dim Pedido As String = (row("Pedido").ToString & "").Trim
            If Pedido = "" Or Pedido = "STOCK" Then
                e.Appearance.ForeColor = Color.SaddleBrown
            Else
                e.Appearance.ForeColor = Color.Blue
            End If


            'Color columna Pendientes según número de palets pendientes
            If e.Column.FieldName.Trim.ToUpper = "PENDIENTES" Then

                Dim Palets As Integer = VaInt(row("Palets"))
                Select Case VaInt(row("PENDIENTES"))
                    Case 0
                        e.Appearance.BackColor = Color.LightGreen
                    Case Palets
                        e.Appearance.BackColor = Color.Red
                    Case Is > 0
                        e.Appearance.BackColor = Color.Yellow
                End Select

            End If


            'Color de marca según estado etiqueta
            If e.Column.FieldName.ToUpper.Trim = "MARCA" Then

                Dim Estado As Integer = 0
                EstadoEtiqueta(row("IdLinea").ToString & "", Estado)
                Select Case Estado

                    Case 9
                        e.Appearance.BackColor = Color.LightGreen
                    Case 2
                        e.Appearance.BackColor = Color.Cyan
                    Case 1
                        e.Appearance.BackColor = Color.Yellow
                    Case 0
                        e.Appearance.BackColor = Color.Red
                    Case Else
                        e.Appearance.BackColor = Color.White

                End Select

            End If


        End If


    End Sub


    Protected Overrides Sub GridView1_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs)
        MyBase.GridView1_CustomColumnDisplayText(sender, e)

        If e.Column.FieldName.ToUpper.Trim = "PEDIDO" Then
            If e.DisplayText = "" Then e.DisplayText = "STOCK"
        End If


    End Sub


    Private Sub cbCentro_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbCentro.EditValueChanged
        CargaLineas()
    End Sub


    Private Sub chkMostrarStock_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMostrarStock.CheckedChanged
        If _bCargado Then
            Consultar()
        End If
    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        Dim indice As Integer = GridView1.FocusedRowHandle

        _filtros = GridView1.ActiveFilterString
        BConsultar.PerformClick()
        'GridView1.ActiveFilterString = filtros

        GridView1.FocusedRowHandle = indice

    End Sub


    Protected Overrides Sub OcultaCargando()
        MyBase.OcultaCargando()

        GridView1.ActiveFilterString = _filtros

    End Sub


    Private Sub BConsultar_Click(sender As System.Object, e As System.EventArgs) Handles BConsultar.Click

        If chkRefrescar.Checked Then
            Timer1.Start()
        End If

    End Sub


    Private Sub btNuevoPaletStock_Click(sender As System.Object, e As System.EventArgs)

        Dim frm As New FrmPaletsComer
        frm.MdiParent = Me.MdiParent
        frm.Show()

    End Sub

    Private Function Valor(dato As String) As String

        dato = dato & ""
        Dim res As String = dato


        If dato.Contains("|;|") Then

            Dim bMismo As Boolean = True

            'Si son todos el mismo valor, podemos mostrar el valor
            Dim datos As String() = Split(dato, "|;|")
            For Each d As String In datos
                If d <> datos(0) Then
                    bMismo = False
                    Exit For
                End If
            Next

            If bMismo Then
                res = datos(0)
            Else
                res = "VARIOS"
            End If

        End If



        Return res

    End Function


    Private Sub chkRefrescar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkRefrescar.CheckedChanged

        If chkRefrescar.Checked Then
            Timer1.Start()
        Else
            Timer1.Stop()
        End If

    End Sub


    Public Overrides Sub Imprimir()


        LineasDescripcion.Clear()


        Dim centros As String = FiltroCheckedComboBox("Centros", cbCentro)
        Dim lineas As String = FiltroCheckedComboBox("Linea", CbLineas)

        Dim RbMostrar As RadioButton() = {rbTerminados, rbPendientes, rbSalidos, rbTodos}
        Dim StrMostrar As String() = {"Terminados", "Pendientes", "Salidos", "Todos"}
        Dim mostrar As String = FiltroRadioButton("Mostrar", RbMostrar, StrMostrar)


        LineasDescripcion.Add("Fecha salida: " & TxFechaSalida.Text)
        If centros <> "" Then LineasDescripcion.Add(centros)
        If lineas <> "" Then LineasDescripcion.Add(lineas)
        If mostrar <> "" Then LineasDescripcion.Add(mostrar)
        If TxCliente.Text.Trim <> "" Then LineasDescripcion.Add("Cliente: " & VaInt(TxCliente.Text).ToString("00000") & " - " & LbNomCliente.Text)
        If TxGenero.Text.Trim <> "" Then LineasDescripcion.Add("Genero: " & VaInt(TxGenero.Text).ToString("00000") & " - " & LbNomGenero.Text)
        If chkMostrarStock.Checked Then LineasDescripcion.Add("Mostrar stock")
        If ChkSoloStock.Checked Then LineasDescripcion.Add("Mostrar solo stock")


        MyBase.Imprimir()

    End Sub


    Public Function FiltroCheckedComboBoxValue(Parametro As String, cb As DevExpress.XtraEditors.CheckedComboBoxEdit) As String

        Dim res As String = ""


        Dim lst As List(Of String) = ListadeCombo(cb)
        For Each s As String In lst
            If res.Trim <> "" Then res = res & ","
            res = res & s
        Next
        If res <> "" Then
            res = Parametro & ": " & res
        Else
            res = Parametro & ": TODOS"
        End If

        Return res

    End Function

End Class