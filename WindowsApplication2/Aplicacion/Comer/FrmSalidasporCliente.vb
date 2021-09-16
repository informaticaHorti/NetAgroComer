
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic





Public Class FrmSalidasporcliente
    Inherits FrConsulta


    Private Class Totales

        Public Palets As Integer = 0
        Public Bultos As Integer = 0
        Public Kilos As Decimal = 0
        Public ImpRef As Decimal = 0
        Public ImpReal As Decimal = 0
        Public ImpVenta As Decimal = 0
        Public ImpPortes As Decimal = 0
        Public ImpGastosV As Decimal = 0
        Public ImpSalida As Decimal = 0
        Public ImpEstructura As Decimal = 0
        Public ImpMateriales As Decimal = 0
        Public ImpConfeccion As Decimal = 0
        Public ImpTotAlmacen As Decimal = 0
        Public ImpNeto As Decimal = 0
        Public ImpCompra As Decimal = 0
        Public ImpBeneficio As Decimal = 0

    End Class


    Private Enum TipoFila
        Normal = 0
        Total = 1
        xKilo = 2
    End Enum


    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Categorias As New E_CategoriasSalida(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
    Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)

    Dim err As New Errores


    Private Class stClaves_Salida

        Public TipoFila As Integer = 0
        Public IdAlbaran As Integer = 0
        Public Albaran As Integer = 0
        Public IdGenero As Integer = 0
        Public Genero As String = ""
        Public IdCliente As Integer = 0
        Public Cliente As String = ""
        Public IdConfec As Integer = 0
        Public Confec As String = ""
        Public IdCat As Integer = 0
        Public Categoria As String = ""
        Public IdMarca As Integer = 0
        Public Marca As String = ""
        

        Public Sub New(IdAlbaran As Integer, Albaran As Integer, IdGenero As Integer, Genero As String, Idcliente As Integer, Cliente As String, Idconfec As Integer, Confec As String, IdCat As Integer, Categoria As String, IdMarca As Integer, Marca As String)

            Me.IdAlbaran = IdAlbaran
            Me.Albaran = Albaran
            Me.IdGenero = IdGenero
            Me.Genero = Genero
            Me.IdCliente = Idcliente
            Me.Cliente = Cliente
            Me.IdConfec = Idconfec
            Me.Confec = Confec
            Me.IdCat = IdCat
            Me.Categoria = Categoria
            Me.IdMarca = IdMarca
            Me.Marca = Marca
        End Sub

    End Class


    Private Class stDatos_Salida

        Public Bultos As Decimal = 0
        Public Kilos As Decimal = 0
        Public Palets As Decimal = 0
        Public ImpRefe As Decimal = 0
        Public ImpReal As Decimal = 0
        Public Portes As Decimal = 0
        Public GastosV As Decimal = 0
        Public Estructura As Decimal = 0
        Public Materiales As Decimal = 0
        Public Confeccion As Decimal = 0
        Public Icompra As Decimal = 0


        Public Sub New(bultos As Decimal, Kilos As Decimal, Palets As Decimal, ImpRefe As Decimal, ImpReal As Decimal, Portes As Decimal, GastosV As Decimal, Estructura As Decimal, Materiales As Decimal, Confeccion As Decimal, Icompra As Decimal)
            Me.Kilos = Kilos
            Me.Bultos = bultos
            Me.Palets = Palets
            Me.ImpRefe = ImpRefe
            Me.ImpReal = ImpReal
            Me.Portes = Portes
            Me.GastosV = GastosV
            Me.Estructura = Estructura
            Me.Materiales = Materiales
            Me.Confeccion = Confeccion
            Me.Icompra = Icompra
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

        ParamTx(TxClienteDesde, Clientes.CLI_Codigo, LbDesdeAgricultor)
        ParamTx(TxClienteHasta, Clientes.CLI_Codigo, LbHastaAgricultor)
        ParamTx(TxFechaDesde, AlbSalida.ASA_fechasalida, LbDesdeFecha, True)
        ParamTx(TxFechaHasta, AlbSalida.ASA_fechasalida, LbHastaFecha, True)
        ParamTx(TxGeneroDesde, Generos.GEN_IdGenero, LbDesdeGenero)
        ParamTx(TxGeneroHasta, Generos.GEN_IdGenero, LbHastaGenero)
        ParamTx(TxCategDesde, Categorias.CAS_Id, LbDesdeCateg)
        ParamTx(TxCategHasta, Categorias.CAS_Id, LbHastaCateg)

        cbCentro = ComboCentro(cbCentro, MiMaletin.IdCentro)


        AsociarControles(TxClienteDesde, BtBuscaAgricultorDesde, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomAgricultorDesde)
        AsociarControles(TxClienteHasta, BtBuscaAgricultorHasta, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomAgricultorHasta)
        AsociarControles(TxGeneroDesde, BtBuscaGeneroDesde, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomGeneroDesde)
        AsociarControles(TxGeneroHasta, BtBuscaGeneroHasta, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomGeneroHasta)
        AsociarControles(TxCategDesde, BtBuscaCategDesde, Categorias.btBusca, Categorias, Categorias.CAS_CategoriaCalibre, LbNomCategDesde)
        AsociarControles(TxCategHasta, BtBuscaCategHasta, Categorias.btBusca, Categorias, Categorias.CAS_CategoriaCalibre, LbNomCategHasta)




    End Sub


    Private Sub FrmConsultaEntradas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        'BImprimir.Visible = False


        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxFechaDesde.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxFechaHasta.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        CalculaDatos()

    End Sub



    Private Sub CalculaDatos()

        GridView1.Columns.Clear()


        Dim sql As String = ""
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Albsalida_lineas.ASL_palets, "palets")
        consulta.SelCampo(Albsalida_lineas.ASL_bultos, "bultos")
        consulta.SelCampo(Albsalida_lineas.ASL_kilosnetos, "kilos")
        consulta.SelCampo(Albsalida_lineas.ASL_idgenero, "idgenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albsalida_lineas.ASL_idgenero)
        consulta.SelCampo(Albsalida_lineas.ASL_idtipoconfeccion, "idconfec")
        consulta.SelCampo(ConfecEnvase.CEV_Nombre, "Confeccion", Albsalida_lineas.ASL_idtipoconfeccion)
        consulta.SelCampo(Albsalida_lineas.ASL_idcategoria, "idcat")
        consulta.SelCampo(Categorias.CAS_CategoriaCalibre, "Categoria", Albsalida_lineas.ASL_idcategoria)
        consulta.SelCampo(Albsalida_lineas.ASL_idmarca, "idmarca")
        consulta.SelCampo(Marcas.MAR_Nombre, "Marca", Albsalida_lineas.ASL_idmarca)
        consulta.SelCampo(Albsalida_lineas.ASL_importegenerovta, "Importevta")
        consulta.SelCampo(Albsalida_lineas.ASL_idalbaran, "IdAlbaran")
        consulta.SelCampo(AlbSalida.ASA_tipofc, "tipofc", Albsalida_lineas.ASL_idalbaran)
        consulta.SelCampo(AlbSalida.ASA_albaran, "albaran")
        consulta.SelCampo(AlbSalida.ASA_fechavaloracion, "Valoracion")
        consulta.SelCampo(AlbSalida.ASA_valorcambio, "Cambio")
        consulta.SelCampo(AlbSalida.ASA_idcliente, "idcliente")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", AlbSalida.ASA_idcliente)
        consulta.SelCampo(Albsalida_lineas.ASL_gastoporte, "Portes")
        consulta.SelCampo(Albsalida_lineas.ASL_gastoF, "GastoF")
        consulta.SelCampo(Albsalida_lineas.ASL_gastoC, "GastoC")
        consulta.SelCampo(Albsalida_lineas.ASL_estructura, "Estructura")
        consulta.SelCampo(Albsalida_lineas.ASL_materiales, "Materiales")
        consulta.SelCampo(Albsalida_lineas.ASL_manipulacion, "Manipulacion")

        If TxClienteDesde.Text <> "" Then
            consulta.WheCampo(AlbSalida.ASA_idcliente, ">=", TxClienteDesde.Text)
        End If

        If TxClienteHasta.Text <> "" Then
            consulta.WheCampo(AlbSalida.ASA_idcliente, "<=", TxClienteHasta.Text)
        End If

        If TxGeneroDesde.Text <> "" Then
            consulta.WheCampo(Albsalida_lineas.ASL_idgenero, ">=", TxGeneroDesde.Text)
        End If

        If TxGeneroHasta.Text <> "" Then
            consulta.WheCampo(Albsalida_lineas.ASL_idgenero, "<=", TxGeneroHasta.Text)
        End If

        If TxFechaDesde.Text <> "" Then
            consulta.WheCampo(AlbSalida.ASA_fechasalida, ">=", TxFechaDesde.Text)
        End If

        If TxFechaHasta.Text <> "" Then
            consulta.WheCampo(AlbSalida.ASA_fechasalida, "<=", TxFechaHasta.Text)
        End If

        If TxCategDesde.Text <> "" Then
            consulta.WheCampo(Albsalida_lineas.ASL_idcategoria, ">=", TxCategDesde.Text)
        End If

        If TxCategHasta.Text <> "" Then
            consulta.WheCampo(Albsalida_lineas.ASL_idcategoria, "<=", TxCategHasta.Text)
        End If


        sql = consulta.SQL & vbCrLf
        sql = sql + CadenaWhereLista(AlbSalida.ASA_idcentro, ListadeCombo(cbCentro), " AND ")
        Select Case True
            Case RbCliente.Checked
                sql = sql & " ORDER BY ASA_idcliente"
            Case RbGenero.Checked
                sql = sql & " ORDER BY ASL_idgenero"
            Case RbClienteGenero.Checked
                sql = sql & " ORDER BY ASA_idcliente, ASL_idgenero"
            Case RbGeneroCliente.Checked
                sql = sql & " ORDER BY ASL_idgenero, ASA_idcliente"
        End Select




        Dim Acum As New Acumulador
        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)

        If Not dt Is Nothing Then

            For Each RW In dt.Rows

                Dim idgenero As Integer = VaInt(RW("idgenero"))
                Dim IdAlbaran As String = (RW("IdAlbaran").ToString & "").Trim
                Dim albaran As Integer = VaInt(RW("albaran"))
                Dim idconfec As Integer = VaInt(RW("idconfec"))
                Dim idcat As Integer = VaInt(RW("idcat"))
                Dim idmarca As Integer = VaInt(RW("idmarca"))
                Dim Genero As String = RW("Genero").ToString
                Dim Confec As String = RW("Confeccion").ToString
                Dim Cat As String = RW("Categoria").ToString
                Dim Marca As String = RW("Marca").ToString
                Dim Idcliente As Integer = VaInt(RW("idcliente"))
                Dim Cliente As String = RW("Cliente").ToString
                Dim Bultos As Decimal = VaDec(RW("bultos"))
                Dim Kilos As Decimal = VaDec(RW("kilos"))
                Dim Palets As Decimal = VaDec(RW("palets"))
                Dim Importe As Decimal = VaDec(RW("importevta"))

                If ChAlbaran.CheckState = CheckState.Unchecked Then
                    albaran = 0
                    IdAlbaran = 0
                End If

                If ChConfeccion.CheckState = CheckState.Unchecked Then
                    idconfec = 0
                    Confec = ""
                End If

                If ChMarca.CheckState = CheckState.Unchecked Then
                    idmarca = 0
                    Marca = ""
                End If

                If ChCategoria.CheckState = CheckState.Unchecked Then
                    idcat = 0
                    Cat = ""
                End If

                If RbGenero.Checked = True Then
                    Idcliente = 0
                    Cliente = ""
                End If

                If RbCliente.Checked = True Then
                    idgenero = 0
                    Genero = ""
                End If

                Dim clave As New stClaves_Salida(IdAlbaran, albaran, idgenero, Genero, Idcliente, Cliente, idconfec, Confec, idcat, Cat, idmarca, Marca)

                Dim Iref As Decimal = 0
                Dim Ivta As Decimal = 0
                Dim Cambio As Decimal = VaDec(RW("cambio"))

                If RW("tipofc").ToString = "F" Or Mid(RW("valoracion").ToString, 1, 10) <> "01/01/1900" Then
                    Ivta = Importe * Cambio
                    Iref = 0
                Else
                    Ivta = 0
                    Iref = Importe * Cambio
                End If

                If Not ChReferencia.Checked Then
                    Iref = 0
                End If

                Dim Portes As Decimal = VaDec(RW("Portes"))
                Dim Gastov As Decimal = VaDec(RW("GastoF")) * Cambio + VaDec(RW("gastoc"))
                Dim Estructura As Decimal = VaDec(RW("Estructura"))
                Dim Manipulacion As Decimal = VaDec(RW("Manipulacion"))
                Dim Materiales As Decimal = VaDec(RW("Materiales"))


                Dim datos As New stDatos_Salida(Bultos, Kilos, Palets, Iref, Ivta, Portes, Gastov, Estructura, Materiales, Manipulacion, 0)
                Acum.Suma(clave, datos)

                Application.DoEvents()

            Next

            Dim DtDatos As DataTable = Acum.DataTable
            PintarGrid(DtDatos)

        End If


        AñadeResumenCampo("Palets", "{0:n0}")
        AñadeResumenCampo("Bultos", "{0:n0}")
        AñadeResumenCampo("Kilos", "{0:n0}")
        AñadeResumenCampo("ImporteRef", "{0:n2}")
        AñadeResumenCampo("ImporteReal", "{0:n2}")

        AñadeResumenCampo("ImpPortes", "{0:n2}")
        AñadeResumenCampo("ImpGastosV", "{0:n2}")
        AñadeResumenCampo("ImpEstructura", "{0:n2}")
        AñadeResumenCampo("ImpMaterial", "{0:n2}")
        AñadeResumenCampo("ImpConfeccion", "{0:n2}")
        AñadeResumenCampo("ImpCompra", "{0:n2}")


        AñadeResumenCampo("PrecioVenta", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("Portes", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("GastosV", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("PrecioSalida", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("TotAlmacen", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("PrecioNeto", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("PCompra", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("Beneficio", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)

        AñadeResumenCampo("Estructura", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("Materiales", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("Confeccion", "{0:n2}", DevExpress.Data.SummaryItemType.Custom)


        'Para que no imprima el pie del grid !!!
        GridView1.OptionsPrint.PrintFooter = False


    End Sub


    Private Sub PintarGrid(Datos As DataTable)



        Dim dt As New DataTable
        dt.Columns.Add("TipoFila", GetType(Integer))
        dt.Columns.Add("IdAlbaran", GetType(System.Int32))
        dt.Columns.Add("Albaran", GetType(System.Int32))
        dt.Columns.Add("IdGenero", GetType(System.Int32))
        dt.Columns.Add("Genero", GetType(System.String))
        dt.Columns.Add("IdCliente", GetType(System.Int32))
        dt.Columns.Add("Cliente", GetType(System.String))
        dt.Columns.Add("IdConfec", GetType(System.Int32))
        dt.Columns.Add("Confec", GetType(System.String))
        dt.Columns.Add("IdCat", GetType(System.Int32))
        dt.Columns.Add("Categoria", GetType(System.String))
        dt.Columns.Add("IdMarca", GetType(System.Int32))
        dt.Columns.Add("Marca", GetType(System.String))
        dt.Columns.Add("Palets", GetType(System.Decimal))
        dt.Columns.Add("Bultos", GetType(System.Decimal))
        dt.Columns.Add("Kilos", GetType(System.Decimal))
        dt.Columns.Add("ImporteRef", GetType(System.Decimal))
        dt.Columns.Add("ImporteReal", GetType(System.Decimal))
        dt.Columns.Add("PrecioVenta", GetType(System.Decimal))
        dt.Columns.Add("Portes", GetType(Decimal))
        dt.Columns.Add("GastosV", GetType(System.Decimal))
        dt.Columns.Add("PrecioSalida", GetType(System.Decimal))
        dt.Columns.Add("Estructura", GetType(System.Decimal))
        dt.Columns.Add("Materiales", GetType(System.Decimal))
        dt.Columns.Add("Confeccion", GetType(System.Decimal))
        dt.Columns.Add("TotAlmacen", GetType(System.Decimal))
        dt.Columns.Add("PrecioNeto", GetType(System.Decimal))
        dt.Columns.Add("PCompra", GetType(System.Decimal))
        dt.Columns.Add("Beneficio", GetType(System.Decimal))

        dt.Columns.Add("ImpPortes", GetType(Decimal))
        dt.Columns.Add("ImpGastosV", GetType(Decimal))
        dt.Columns.Add("ImpEstructura", GetType(Decimal))
        dt.Columns.Add("ImpMaterial", GetType(Decimal))
        dt.Columns.Add("ImpConfeccion", GetType(Decimal))
        dt.Columns.Add("ImpCompra", GetType(Decimal))


        If Not IsNothing(Datos) Then
            If Datos.Rows.Count > 0 Then

                Select Case True

                    Case RbGenero.Checked, RbGeneroCliente.Checked
                        Dim dv As New DataView(Datos)
                        dv.Sort = "idgenero,idcliente"
                        Datos = dv.ToTable

                    Case RbCliente.Checked, RbClienteGenero.Checked
                        Dim dv As New DataView(Datos)
                        dv.Sort = "idcliente,idgenero"
                        Datos = dv.ToTable

                End Select


            End If
        End If

        


        Dim Total As New Totales



        For Each rw In Datos.Rows


            Dim row As DataRow = dt.NewRow()

            row("IdAlbaran") = rw("IdAlbaran")
            row("Albaran") = rw("Albaran")
            row("IdGenero") = rw("IdGenero")
            row("Genero") = rw("Genero")
            row("IdCliente") = rw("IdCliente")
            row("Cliente") = rw("Cliente")
            row("IdConfec") = rw("IdConfec")
            row("Confec") = rw("Confec")
            row("IdCat") = rw("IdCat")
            row("Categoria") = rw("Categoria")
            row("IdMarca") = rw("IdMarca")
            row("Marca") = rw("Marca")
            row("Palets") = rw("Palets")
            row("Bultos") = rw("Bultos")
            row("ImpPortes") = rw("Portes")
            row("ImpGastosV") = rw("GastosV")
            row("ImpEstructura") = rw("Estructura")
            row("ImpMaterial") = rw("Materiales")
            row("ImpConfeccion") = rw("Confeccion")
            row("ImpCompra") = rw("ICompra")

            Dim Kilos As Decimal = VaDec(rw("Kilos"))
            Dim ImpReferencia As Decimal = VaDec(rw("ImpRefe"))
            Dim ImpReal As Decimal = VaDec(rw("ImpReal"))
            Dim ICompra As Decimal = VaDec(rw("ICompra"))

            row("ImporteRef") = ImpReferencia
            row("ImporteReal") = ImpReal
            row("Kilos") = Kilos

            Dim PrecioRef As Decimal = 0
            Dim PrecioReal As Decimal = 0
            Dim PrecioCompra As Decimal = 0


            If Kilos <> 0 Then
                PrecioRef = ImpReferencia / Kilos
                PrecioReal = ImpReal / Kilos
                PrecioCompra = ICompra / Kilos
            End If


            Dim Portes As Decimal = VaDec(rw("Portes"))
            Dim GastosV As Decimal = VaDec(rw("GastosV"))
            Dim Estructura As Decimal = VaDec(rw("Estructura"))
            Dim Materiales As Decimal = VaDec(rw("Materiales"))
            Dim Confeccion As Decimal = VaDec(rw("Confeccion"))




            If ChKilo.Checked Then
                If Kilos <> 0 Then
                    Portes = Portes / Kilos
                    GastosV = GastosV / Kilos
                    Estructura = Estructura / Kilos
                    Materiales = Materiales / Kilos
                    Confeccion = Confeccion / Kilos
                Else
                    Portes = 0
                    GastosV = 0
                    Estructura = 0
                    Materiales = 0
                    Confeccion = 0
                End If
            End If


            Dim PrecioVenta As Decimal = 0
            If ChKilo.Checked Then
                PrecioVenta = PrecioRef + PrecioReal
            Else
                PrecioVenta = ImpReferencia + ImpReal
            End If
            Dim PrecioSalida As Decimal = PrecioVenta - Portes - GastosV
            Dim TotAlmacen As Decimal = Estructura + Materiales + Confeccion
            Dim PrecioNeto As Decimal = PrecioSalida - TotAlmacen
            Dim Beneficio As Decimal = PrecioNeto - PrecioCompra


            row("PrecioVenta") = PrecioVenta
            row("Portes") = Portes
            row("GastosV") = GastosV
            row("PrecioSalida") = PrecioSalida
            row("Estructura") = Estructura
            row("Materiales") = Materiales
            row("Confeccion") = Confeccion
            row("TotAlmacen") = TotAlmacen
            row("PrecioNeto") = PrecioNeto
            If ChKilo.Checked Then
                row("PCompra") = PrecioCompra
            Else
                row("PCompra") = ICompra
            End If
            row("Beneficio") = Beneficio


            AcumulaTotales(Total, rw)


            dt.Rows.Add(row)

            Application.DoEvents()

        Next


        If RbGeneroCliente.Checked Then
            If dt.Columns.Contains("IdGenero") Then dt.Columns("IdGenero").SetOrdinal(2)
            If dt.Columns.Contains("Genero") Then dt.Columns("Genero").SetOrdinal(3)
        ElseIf RbClienteGenero.Checked Then
            If dt.Columns.Contains("IdCliente") Then dt.Columns("IdCliente").SetOrdinal(2)
            If dt.Columns.Contains("Cliente") Then dt.Columns("Cliente").SetOrdinal(3)
        End If



        Grid.DataSource = dt
        AñadeTotal(dt, Total)
        AñadeTotalxKilo(dt, Total)


        AjustaColumnas()





    End Sub


    Private Sub AcumulaTotales(ByRef Total As Totales, row As DataRow)

        Total.Palets += VaInt(row("Palets"))
        Total.Bultos += VaInt(row("Bultos"))
        Total.Kilos += VaDec(row("Kilos"))
        Total.ImpRef += VaDec(row("ImpRefe"))
        Total.ImpReal += VaDec(row("ImpReal"))
        Total.ImpPortes += VaDec(row("Portes"))
        Total.ImpGastosV += VaDec(row("GastosV"))
        Total.ImpEstructura += VaDec(row("Estructura"))
        Total.ImpMateriales += VaDec(row("Materiales"))
        Total.ImpConfeccion += VaDec(row("Confeccion"))
        Total.ImpCompra += VaDec(row("ICompra"))

    End Sub


    Private Sub AñadeTotal(ByRef dt As DataTable, Total As Totales)

        Dim row As DataRow = dt.NewRow()

        Total.ImpVenta = Total.ImpRef + Total.ImpReal
        Total.ImpSalida = Total.ImpVenta - Total.ImpPortes - Total.ImpGastosV
        Total.ImpTotAlmacen = Total.ImpEstructura + Total.ImpMateriales + Total.ImpConfeccion
        Total.ImpNeto = Total.ImpSalida - Total.ImpTotAlmacen
        Total.ImpBeneficio = Total.ImpNeto - Total.ImpCompra


        row("Genero") = "TOTAL"
        row("TipoFila") = TipoFila.Total
        row("Palets") = Total.Palets
        row("Bultos") = Total.Bultos
        row("Kilos") = Total.Kilos
        row("ImporteRef") = Total.ImpRef
        row("ImporteReal") = Total.ImpReal
        row("PrecioVenta") = Total.ImpVenta
        row("Portes") = Total.ImpPortes
        row("GastosV") = Total.ImpGastosV
        row("PrecioSalida") = Total.ImpSalida
        row("Estructura") = Total.ImpEstructura
        row("Materiales") = Total.ImpMateriales
        row("Confeccion") = Total.ImpConfeccion
        row("TotAlmacen") = Total.ImpTotAlmacen
        row("PrecioNeto") = Total.ImpNeto
        row("PCompra") = Total.ImpCompra
        row("Beneficio") = Total.ImpBeneficio


        dt.Rows.Add(row)

    End Sub


    Private Sub AñadeTotalxKilo(ByRef dt As DataTable, Total As Totales)

        Dim row As DataRow = dt.NewRow()


        Total.ImpSalida = Total.ImpVenta - Total.ImpPortes - Total.ImpGastosV
        Total.ImpTotAlmacen = Total.ImpEstructura + Total.ImpMateriales + Total.ImpConfeccion
        Total.ImpNeto = Total.ImpSalida - Total.ImpTotAlmacen
        Total.ImpBeneficio = Total.ImpNeto - Total.ImpCompra
        Total.ImpVenta = Total.ImpRef + Total.ImpReal

        row("Genero") = "x Kilo"
        row("TipoFila") = TipoFila.xKilo

        Dim PrecioVenta As Decimal = 0
        Dim Portes As Decimal = 0
        Dim GastosV As Decimal = 0
        Dim PrecioSalida As Decimal = 0
        Dim Estructura As Decimal = 0
        Dim Materiales As Decimal = 0
        Dim Confeccion As Decimal = 0
        Dim TotAlmacen As Decimal = 0
        Dim PrecioNeto As Decimal = 0
        Dim PCompra As Decimal = 0
        Dim Beneficio As Decimal = 0

        If Total.Kilos <> 0 Then
            PrecioVenta = Total.ImpVenta / Total.Kilos
            Portes = Total.ImpPortes / Total.Kilos
            GastosV = Total.ImpGastosV / Total.Kilos
            PrecioSalida = Total.ImpSalida / Total.Kilos
            Estructura = Total.ImpEstructura / Total.Kilos
            Materiales = Total.ImpMateriales / Total.Kilos
            Confeccion = Total.ImpConfeccion / Total.Kilos
            TotAlmacen = Total.ImpTotAlmacen / Total.Kilos
            PrecioNeto = Total.ImpNeto / Total.Kilos
            PCompra = Total.ImpCompra / Total.Kilos
            Beneficio = Total.ImpBeneficio / Total.Kilos

        End If


        row("PrecioVenta") = PrecioVenta
        row("Portes") = Portes
        row("GastosV") = GastosV
        row("PrecioSalida") = PrecioSalida
        row("Estructura") = Estructura
        row("Materiales") = Materiales
        row("Confeccion") = Confeccion
        row("TotAlmacen") = TotAlmacen
        row("PrecioNeto") = PrecioNeto
        row("PCompra") = PCompra
        row("Beneficio") = Beneficio


        dt.Rows.Add(row)

    End Sub


    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDALBARAN"
                    c.Visible = False

                Case "IDCLIENTE", "CLIENTE"
                    If RbGenero.Checked Then
                        c.Visible = False
                    Else
                        c.Visible = True
                    End If

                Case "GENERO"
                    If RbCliente.Checked Then
                        c.Visible = False
                    Else
                        c.Visible = True
                    End If

                Case "IDGENERO", "IDCONFEC", "IDCAT", "IDMARCA", "TIPOFILA", "IMPPORTES", "IMPGASTOSV", "IMPESTRUCTURA", "IMPMATERIAL", "IMPCONFECCION", "IMPCOMPRA"
                    c.Visible = False

                Case "ALBARAN"
                    c.Visible = ChAlbaran.Checked
                Case "CONFEC"
                    c.Visible = ChConfeccion.Checked
                Case "CATEGORIA"
                    c.Visible = ChCategoria.Checked
                Case "MARCA"
                    c.Visible = ChMarca.Checked

                Case "ESTRUCTURA", "MATERIALES", "CONFECCION"
                    If ChAlmacen.Checked Then
                        c.Visible = True
                    Else
                        c.Visible = False
                    End If
                Case "TOTALMACEN"
                    If ChAlmacen.Checked Then
                        c.Visible = False
                    Else
                        c.Visible = True
                    End If

                Case "IMPORTEREF"
                    If ChReferencia.Checked Then
                        c.Visible = True
                    Else
                        c.Visible = False
                    End If

            End Select
        Next

            GridView1.BestFitColumns()

            For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "ALBARAN"
                    c.MinWidth = 50
                Case "IDCLIENTE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.Caption = "CodCli"
                    c.Width = 50
                Case "GENERO", "CLIENTE"
                    c.Width = 80
                Case "BULTOS", "PALETS", "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 70
                Case "IMPORTEREF", "IMPORTEREAL"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 80
                Case "PRECIOVENTA", "PORTES", "GASTOSV", "PRECIOSALIDA", "ESTRUCTURA", "MATERIALES", "CONFECCION", "TOTALMACEN", "PRECIONETO", "PCOMPRA", "BENEFICIO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.0000"
                    c.Width = 100
            End Select
            Next


    End Sub


    Protected Overrides Sub RowCellStyle(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn, sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        MyBase.RowCellStyle(row, column, sender, e)


        If Not IsNothing(row) Then

            Select Case VaInt(row("TipoFila"))

                Case TipoFila.Total

                    'Fila de resumen Total
                    Dim fuente As Font = e.Appearance.Font
                    fuente = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

                    e.Appearance.ForeColor = Color.Black
                    e.Appearance.Font = fuente

                    If column.FieldName.Trim.ToUpper = "BENEFICIO" Then
                        If VaDec(row("Beneficio")) < 0 Then e.Appearance.BackColor = Color.Yellow
                    End If


                Case TipoFila.xKilo
                    'Total (x Kilo)

                    Dim fuente As Font = e.Appearance.Font
                    fuente = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

                    e.Appearance.ForeColor = Color.Red
                    e.Appearance.Font = fuente

                    If column.FieldName.Trim.ToUpper = "BENEFICIO" Then
                        If VaDec(row("Beneficio")) < 0 Then e.Appearance.BackColor = Color.Yellow
                    End If

                Case Else

                    'Fila Normal
                    Select Case column.FieldName.ToUpper.Trim
                        Case "PRECIOVENTA", "GASTOSV", "PRECIOSALIDA", "ESTRUCTURA", "MATERIALES", "CONFECCION", "TOTALMACEN", "PRECIONETO", "PCOMPRA", "BENEFICIO"

                            If ChKilo.Checked Then
                                e.Appearance.ForeColor = Color.Red
                            Else
                                e.Appearance.ForeColor = Color.Blue
                            End If

                            If column.FieldName.Trim.ToUpper = "BENEFICIO" Then
                                If VaDec(row("Beneficio")) < 0 Then
                                    e.Appearance.BackColor = Color.Yellow
                                Else
                                    e.Appearance.BackColor = Color.White
                                End If
                            End If

                    End Select



            End Select


            

        End If



    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()


        Dim clientes As String = FiltroDesdeHasta("Cliente", TxClienteDesde.Text, TxClienteHasta.Text)
        Dim generos As String = FiltroDesdeHasta("Genero", TxGeneroDesde.Text, TxGeneroHasta.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxFechaDesde.Text, TxFechaHasta.Text)
        Dim categorias As String = FiltroDesdeHasta("Categoria", TxCategDesde.Text, TxCategHasta.Text)
        Dim referencia As String = FiltroCheckBox("Incluir salidas a precio de referencia", ChReferencia, "SI", "NO")
        Dim mostrarxkilo As String = FiltroCheckBox("Mostrar x kilo", ChKilo, "SI", "NO")

        Dim rbTipoListado As RadioButton() = {RbGenero, RbCliente, RbClienteGenero, RbGeneroCliente}
        Dim strTipoListado As String() = {"Por Género", "Por Cliente", "Cliente-Género", "Género-Cliente"}
        Dim TipoListado As String = FiltroRadioButton("Tipo de listado", rbTipoListado, strTipoListado)


        If TipoListado <> "" Then LineasDescripcion.Add(TipoListado)
        If clientes <> "" Then LineasDescripcion.Add(clientes)
        If generos <> "" Then LineasDescripcion.Add(generos)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If categorias <> "" Then LineasDescripcion.Add(categorias)
        If referencia <> "" Then LineasDescripcion.Add(referencia)
        If mostrarxkilo <> "" Then LineasDescripcion.Add(mostrarxkilo)


        MyBase.Imprimir()

    End Sub


    Public Overrides Sub CustomDrawFooterCell(sender As Object, e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs)
        MyBase.CustomDrawFooterCell(sender, e)

        e.Info.DisplayText = ""


    End Sub


    Public Overrides Sub CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs)
        MyBase.CustomSummaryCalculate(sender, e)


        Try

            If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

                If e.IsGroupSummary Then


                    Dim row As DataRow = GridView1.GetDataRow(e.RowHandle)
                    If Not IsNothing(row) Then
                        Dim Genero As String = (row("Genero").ToString & "").Trim
                        If Genero = "TOTAL" Or Genero = "X KILO" Then
                            e.TotalValue = DBNull.Value
                            Exit Sub
                        End If
                    End If


                    Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item
                    Dim NombreCampo As String = item.FieldName.ToUpper.Trim


                    If NombreCampo = "PRECIOVENTA" Then

                        Try
                            Dim precio As Decimal = 0

                            Dim ImpRef As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(3)))
                            Dim ImpReal As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(4)))
                            Dim ImpVenta As Decimal = ImpRef + ImpReal
                            Dim kilos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(2)))

                            'e.TotalValue = ImpVenta
                            If kilos <> 0 Then precio = ImpVenta / kilos
                            e.TotalValue = precio

                        Catch ex As Exception
                            Dim a As String = ""
                        End Try

                    End If

                    If NombreCampo = "PORTES" Then

                        Try
                            Dim precio As Decimal = 0

                            Dim ImpPortes As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(5)))
                            Dim kilos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(2)))

                            'e.TotalValue = ImpPortes
                            If kilos <> 0 Then precio = ImpPortes / kilos
                            e.TotalValue = precio


                        Catch ex As Exception
                            Dim a As String = ""
                        End Try

                    End If

                    If NombreCampo = "GASTOSV" Then

                        Try
                            Dim precio As Decimal = 0

                            Dim ImpGastosV As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(6)))
                            Dim kilos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(2)))

                            'e.TotalValue = ImpGastosV
                            If kilos <> 0 Then precio = ImpGastosV / kilos
                            e.TotalValue = precio

                        Catch ex As Exception
                            Dim a As String = ""
                        End Try

                    End If

                    If NombreCampo = "PRECIOSALIDA" Then

                        Try
                            Dim precio As Decimal = 0

                            Dim ImpRef As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(3)))
                            Dim ImpReal As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(4)))
                            Dim ImpPortes As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(5)))
                            Dim ImpGastosV As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(6)))
                            Dim kilos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(2)))

                            'e.TotalValue = ImpRef + ImpReal - ImpPortes - ImpGastosV
                            If kilos <> 0 Then precio = (ImpRef + ImpReal - ImpPortes - ImpGastosV) / kilos
                            e.TotalValue = precio

                        Catch ex As Exception
                            Dim a As String = ""
                        End Try

                    End If

                    If NombreCampo = "TOTALMACEN" Then

                        Try
                            Dim precio As Decimal = 0

                            Dim ImpEstructura As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(7)))
                            Dim ImpMateriales As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(8)))
                            Dim ImpConfeccion As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(9)))
                            Dim kilos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(2)))

                            'e.TotalValue = ImpEstructura + ImpMateriales + ImpConfeccion
                            If kilos <> 0 Then precio = (ImpEstructura + ImpMateriales + ImpConfeccion) / kilos
                            e.TotalValue = precio

                        Catch ex As Exception
                            Dim a As String = ""
                        End Try

                    End If

                    If NombreCampo = "ESTRUCTURA" Then

                        Try
                            Dim precio As Decimal = 0

                            Dim ImpEstructura As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(7)))
                            Dim kilos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(2)))

                            If kilos <> 0 Then precio = ImpEstructura / kilos
                            e.TotalValue = precio

                        Catch ex As Exception
                            Dim a As String = ""
                        End Try

                    End If

                    If NombreCampo = "MATERIALES" Then

                        Try
                            Dim precio As Decimal = 0

                            Dim ImpMateriales As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(8)))
                            Dim kilos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(2)))

                            If kilos <> 0 Then precio = ImpMateriales / kilos
                            e.TotalValue = precio

                        Catch ex As Exception
                            Dim a As String = ""
                        End Try

                    End If

                    If NombreCampo = "CONFECCION" Then

                        Try
                            Dim precio As Decimal = 0

                            Dim ImpConfeccion As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(9)))
                            Dim kilos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(2)))

                            If kilos <> 0 Then precio = ImpConfeccion / kilos
                            e.TotalValue = precio

                        Catch ex As Exception
                            Dim a As String = ""
                        End Try

                    End If


                    If NombreCampo = "PRECIONETO" Then

                        Try
                            Dim precio As Decimal = 0

                            Dim ImpRef As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(3)))
                            Dim ImpReal As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(4)))
                            Dim ImpPortes As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(5)))
                            Dim ImpGastosV As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(6)))
                            Dim ImpEstructura As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(7)))
                            Dim ImpMateriales As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(8)))
                            Dim ImpConfeccion As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(9)))
                            Dim kilos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(2)))

                            'e.TotalValue = ImpRef + ImpReal - ImpPortes - ImpGastosV - ImpEstructura - ImpMateriales - ImpConfeccion
                            If kilos <> 0 Then precio = (ImpRef + ImpReal - ImpPortes - ImpGastosV - ImpEstructura - ImpMateriales - ImpConfeccion) / kilos
                            e.TotalValue = precio

                        Catch ex As Exception
                            Dim a As String = ""
                        End Try

                    End If


                    If NombreCampo = "PCOMPRA" Then

                        Try
                            Dim precio As Decimal = 0

                            Dim ImpCompra As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(10)))
                            Dim kilos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(2)))

                            'e.TotalValue = ImpCompra
                            If kilos <> 0 Then precio = ImpCompra / kilos
                            e.TotalValue = precio

                        Catch ex As Exception
                            Dim a As String = ""
                        End Try

                    End If


                    If NombreCampo = "BENEFICIO" Then

                        Try
                            Dim precio As Decimal = 0

                            Dim ImpRef As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(3)))
                            Dim ImpReal As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(4)))
                            Dim ImpPortes As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(5)))
                            Dim ImpGastosV As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(6)))
                            Dim ImpEstructura As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(7)))
                            Dim ImpMateriales As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(8)))
                            Dim ImpConfeccion As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(9)))
                            Dim ImpCompra As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(10)))
                            Dim kilos As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(2)))

                            'e.TotalValue = ImpRef + ImpReal - ImpPortes - ImpGastosV - ImpEstructura - ImpMateriales - ImpConfeccion - ImpCompra
                            If kilos <> 0 Then precio = (ImpRef + ImpReal - ImpPortes - ImpGastosV - ImpEstructura - ImpMateriales - ImpConfeccion - ImpCompra) / kilos
                            e.TotalValue = precio

                        Catch ex As Exception
                            Dim a As String = ""
                        End Try

                    End If


                ElseIf e.IsTotalSummary Then

                    e.TotalValue = 0

                End If


            End If


        Catch ex As Exception

        End Try

    End Sub


    Public Overrides Sub CustomDrawRowFooterCell(sender As Object, e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs)
        MyBase.CustomDrawRowFooterCell(sender, e)


        Select Case e.Column.FieldName.ToUpper.Trim
            Case "PRECIOVENTA", "PORTES", "GASTOSV", "PRECIOSALIDA", "ESTRUCTURA", "MATERIALES", "CONFECCION", "PRECIONETO", "PCOMPRA", "BENEFICIO", "TOTALMACEN"
                e.Appearance.ForeColor = Color.Red
                e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold)
                e.Info.DisplayText = VaDec(e.Info.Value).ToString("#,##0.0000")
        End Select


    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

        If column.FieldName.Trim.ToUpper = "ALBARAN" Then

            Dim IdAlbaran As String = (row("IdAlbaran").ToString & "").Trim
            If VaDec(IdAlbaran) > 0 Then

                Dim frm As New FrmHiAlbSal
                frm.init(IdAlbaran)
                frm.ShowDialog()

            End If

        End If

    End Sub


End Class