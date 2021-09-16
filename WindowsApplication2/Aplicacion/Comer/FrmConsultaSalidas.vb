
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmConsultaSalidas
    Inherits FrConsulta


    Dim AlbSalida_Lineas As New E_AlbSalida_lineas(Idusuario, cn)
    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim Facturas As New E_Facturas(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, CnCtb)
    Dim SubFamilias As New E_Subfamilias(Idusuario, cn)
    Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)
    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)


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

        ParamTx(TxDato1, Clientes.CLI_Codigo, Lb1)
        ParamTx(TxDato2, Clientes.CLI_Codigo, Lb2)
        ParamTx(TxDato3, AlbSalida.ASA_fechasalida, Lb3)
        ParamTx(TxDato4, AlbSalida.ASA_fechasalida, Lb4)
        ParamTx(TxDato7, Facturas.FRA_fecha, Lb7)
        ParamTx(TxDato5, Facturas.FRA_fecha, Lb8)

        AsociarControles(TxDato1, BtBusca1, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb_1)
        AsociarControles(TxDato2, BtBusca2, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lb_2)

        cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)
        CbFamilias = ComboFamilias(CbFamilias)

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        BInforme.Visible = False

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxDato3.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato4.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Private Sub ConsultaCostes()
        Dim DcAlb As New Dictionary(Of String, String)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbSalida_Lineas.ASL_idlinea, "IdLinea")
        consulta.SelCampo(AlbSalida.ASA_idalbaran, "IdAlbaran")
        consulta.SelCampo(Nothing, "Cabecera")
        consulta.SelCampo(AlbSalida.ASA_albaran, "NAlbaran", AlbSalida_Lineas.ASL_idalbaran, AlbSalida.ASA_idalbaran)
        consulta.SelCampo(AlbSalida.ASA_fechasalida, "Fecha")
        consulta.SelCampo(PuntoVenta.Nombre, "PVenta", AlbSalida.ASA_idpuntoventa, PuntoVenta.IdPuntoVenta)
        consulta.SelCampo(Facturas.FRA_serie, "Serie", AlbSalida.ASA_idfactura, Facturas.FRA_idfactura)
        consulta.SelCampo(Facturas.FRA_factura, "Factura")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", AlbSalida.ASA_idcliente, Clientes.CLI_Codigo)
        consulta.SelCampo(AlbSalida_Lineas.ASL_idgenero, "IdGenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbSalida_Lineas.ASL_idgenero, Generos.GEN_IdGenero)
        consulta.SelCampo(SubFamilias.SFA_idfamilia, "Idfamilia", Generos.GEN_IdsubFamilia)
        consulta.SelCampo(AlbSalida_Lineas.ASL_idcategoria, "IdCategoria")
        consulta.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", AlbSalida_Lineas.ASL_idcategoria, CategoriasSalida.CAS_Id)
        consulta.SelCampo(AlbSalida_Lineas.ASL_idtipoconfeccion, "IdTipoConfeccion")
        consulta.SelCampo(ConfecEnvase.CEV_Nombre, "Confeccion", AlbSalida_Lineas.ASL_idtipoconfeccion, ConfecEnvase.CEV_Idconfec)
        consulta.SelCampo(AlbSalida_Lineas.ASL_palets, "Palets")
        consulta.SelCampo(AlbSalida_Lineas.ASL_bultos, "Bultos")
        consulta.SelCampo(AlbSalida_Lineas.ASL_piezas, "Piezas")
        consulta.SelCampo(AlbSalida_Lineas.ASL_kiloscliente, "KCliente")
        consulta.SelCampo(AlbSalida_Lineas.ASL_kilosnetos, "KNetos")
        Dim Diferencia As New Cdatos.bdcampo("@COALESCE(ASL_kiloscliente,0) - COALESCE(ASL_kilosnetos,0) ", Cdatos.TiposCampo.Entero, 10)
        consulta.SelCampo(Diferencia, "Dif")
        Dim Iventa As New Cdatos.bdcampo("@COALESCE(ASL_importegenerovta,0) * COALESCE(ASA_valorcambio,1) ", Cdatos.TiposCampo.Importe, 12, 2)
        consulta.SelCampo(Iventa, "Iventa")

        If TxDato1.Text.Trim <> "" Then consulta.WheCampo(Clientes.CLI_Codigo, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then consulta.WheCampo(Clientes.CLI_Codigo, "<=", TxDato2.Text)
        If TxDato3.Text.Trim <> "" Then consulta.WheCampo(AlbSalida.ASA_fechasalida, ">=", TxDato3.Text)
        If TxDato4.Text.Trim <> "" Then consulta.WheCampo(AlbSalida.ASA_fechasalida, "<=", TxDato4.Text)

        Dim WHE As String = consulta.Whe

        If RbFirme.Checked Then
            If WHE.Trim = "" Then
                WHE = " WHERE "
            Else
                WHE = WHE & " AND "
            End If
            WHE = WHE & " (ASA_TipoFC = 'F')  " & vbCrLf

        End If

        If RbComi.Checked Then
            If WHE.Trim = "" Then
                WHE = " WHERE "
            Else
                WHE = WHE & " AND "
            End If
            WHE = WHE & " (ASA_TipoFC = 'C')  " & vbCrLf

        End If


        If RbValorados.Checked Then
            If WHE.Trim = "" Then
                WHE = " WHERE "
            Else
                WHE = WHE & " AND "
            End If
            WHE = WHE & " (ASA_TipoFC = 'F' OR (ASA_TipoFC = 'C' AND ASA_FechaValoracion > '" & VaDate("").ToString("dd/MM/yyyy") & "')) " & vbCrLf

        End If



        If RbNoValorados.Checked Then
            If WHE.Trim = "" Then
                WHE = " WHERE "
            Else
                WHE = WHE & " AND "
            End If
            WHE = WHE & " ( ASA_TipoFC = 'C' AND ASA_FechaValoracion <= '" & VaDate("").ToString("dd/MM/yyyy") & "') " & vbCrLf

        End If




        'Facturado SN
        If RbSiFacturados.Checked Then
            If WHE = "" Then
                WHE = " WHERE COALESCE(AlbSalida.ASA_IdFactura,0) <> 0" & vbCrLf
            Else
                WHE = WHE & " AND COALESCE(AlbSalida.ASA_IdFactura,0) <> 0" & vbCrLf
            End If
        ElseIf RbNoFacturados.Checked Then
            If WHE = "" Then
                WHE = " WHERE COALESCE(AlbSalida.ASA_IdFactura,0) = 0" & vbCrLf
            Else
                WHE = WHE & " AND COALESCE(AlbSalida.ASA_IdFactura,0) = 0" & vbCrLf
            End If
        End If

        'Punto de venta
        If WHE = "" Then
            WHE = CadenaWhereLista(AlbSalida.ASA_idpuntoventa, ListadeCombo(cbPuntoVenta), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(AlbSalida.ASA_idpuntoventa, ListadeCombo(cbPuntoVenta), " AND ")
        End If
        'Familias
        If WHE = "" Then
            WHE = CadenaWhereLista(SubFamilias.SFA_idfamilia, ListadeCombo(CbFamilias), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(SubFamilias.SFA_idfamilia, ListadeCombo(CbFamilias), " AND ")
        End If

        If VaDate(TxDato7.Text) > VaDate("") Then
            If WHE = "" Then
                WHE = " WHERE" & vbCrLf
            Else
                WHE = WHE & " AND" & vbCrLf
            End If
            Dim v As String = VaDate("").ToString("dd/MM/yyyy")
            WHE = WHE & " (COALESCE(FRA_Fecha,'" & v & "') <= '" & v & "'" & vbCrLf & " OR (COALESCE(FRA_Fecha,'" & v & "') >= '" & v & "' AND COALESCE(FRA_Fecha,'" & v & "') >= '" & VaDate(TxDato7.Text).ToString("dd/MM/yyyy") & "'))" & vbCrLf
        End If
        

        If VaDate(TxDato5.Text) > VaDate("") Then
            If WHE = "" Then
                WHE = " WHERE" & vbCrLf
            Else
                WHE = WHE & " AND" & vbCrLf
            End If
            Dim v As String = VaDate("").ToString("dd/MM/yyyy")
            WHE = WHE & " (COALESCE(ASA_Fechavaloracion,'" & v & "') <= '" & v & "'" & vbCrLf & " OR (COALESCE(ASA_Fechavaloracion,'" & v & "') >= '" & v & "' AND COALESCE(ASA_Fechavaloracion,'" & v & "') >= '" & VaDate(TxDato5.Text).ToString("dd/MM/yyyy") & "'))" & vbCrLf
        End If


        Dim sql As String = consulta.Sel(_IncluirTodosLosCampos) & WHE & " order by Fecha, nAlbaran"


        GridView1.Columns.Clear()
        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)


        dt.Columns.Add(New DataColumn("GastosF", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("GastosC", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("Est", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("Mat", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("Conf", GetType(Decimal)))


        For Each rw In dt.Rows

            Dim gf As Double = 0
            Dim gc As Double = 0
            Dim est As Double = 0
            Dim mat As Double = 0
            Dim conf As Double = 0

            GastosAlbaran(rw("idlinea").ToString, gf, gc, est, mat, conf)

            rw("GastosF") = gf
            rw("GastosC") = gc
            rw("Est") = est
            rw("Mat") = mat
            rw("Conf") = conf

            If ChkKilo.CheckState = CheckState.Checked Then
                Dim k As Double = VaDec(rw("Knetos"))
                If k <> 0 Then
                    rw("GastosF") = gf / k
                    rw("GastosC") = gc / k
                    rw("Est") = est / k
                    rw("Mat") = mat / k
                    rw("Conf") = conf / k
                    rw("Iventa") = VaDec(rw("iventa")) / k
                End If
            End If
            If ChActu.CheckState = CheckState.Checked Then
                Dim idalbaran As String = rw("idalbaran").ToString
                If DcAlb.ContainsKey(idalbaran) = False Then
                    DcAlb.Add(idalbaran, idalbaran)
                End If

            End If
        Next


        PonCabecera(dt)
        Grid.DataSource = dt


        If Not IsNothing(GridView1.Columns.ColumnByFieldName("Cabecera")) Then
            GridView1.Columns.ColumnByFieldName("Cabecera").GroupIndex = 1
            GridView1.ExpandAllGroups()
        End If


        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Palets", "{0:n0}")
        AñadeResumenCampo("Bultos", "{0:n0}")
        AñadeResumenCampo("KCliente", "{0:n0}")
        AñadeResumenCampo("KNetos", "{0:n0}")
        AñadeResumenCampo("Dif", "{0:n0}")

        If ChkKilo.CheckState = CheckState.Unchecked Then
            AñadeResumenCampo("Iventa", "{0:n2}")
            AñadeResumenCampo("GastosC", "{0:n2}")
            AñadeResumenCampo("GastosF", "{0:n2}")
            AñadeResumenCampo("Est", "{0:n2}")
            AñadeResumenCampo("Mat", "{0:n2}")
            AñadeResumenCampo("Conf", "{0:n2}")
        End If


        AjustaColumnascostes()


        If ChActu.CheckState = CheckState.Checked Then
            For Each idalb In DcAlb.Keys
                AGRO_ActualizaGastosOrigenAlbaran(idalb)
            Next
            ChActu.Checked = False
        End If


    End Sub


    Private Sub ActualizaPrecioEstimado()
        Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)

        Dim IdAlbaran As String
        Dim Valorcambio As Decimal
        Dim sql As String = "update albsalida_lineas set asl_precioestimado=asl_precioventa where asl_precioestimado=0" ' igualo el precio estimado al de venta cuando es 0
        cn.OrdenSql(sql)


        sql = "Select asa_idalbaran,asa_valorcambio from albsalida where asa_tipofc='C' and asa_fechavaloracion='" & VaDate("").ToString("dd/MM/yyyy") + "'"
        Dim dt As DataTable = cn.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                IdAlbaran = rw("asa_idalbaran").ToString
                Valorcambio = VaDec(rw("asa_valorcambio"))
                sql = "Select asl_idlinea as idlinea,asl_kiloscliente as kilos,asl_bultos as bultos,asl_piezas as piezas,asl_precioestimado as precioestimado,asl_tipoprecio as tipoprecio"
                sql = sql + " from albsalida_lineas where asl_idalbaran=" + IdAlbaran
                Dim dtl As DataTable = cn.ConsultaSQL(sql)
                If Not dtl Is Nothing Then
                    For Each rwl In dtl.Rows
                        Dim i As Decimal = 0
                        Dim precio As Decimal = VaDec(rwl("precioestimado"))
                        Select Case rwl("tipoprecio").ToString
                            Case "K"
                                i = VaDec(rwl("kilos")) * precio
                            Case "B"
                                i = VaDec(rwl("bultos")) * precio
                            Case "P"
                                i = VaDec(rwl("piezas")) * precio

                        End Select

                        If Albsalida_lineas.LeerId(rwl("idlinea").ToString) = True Then
                            Albsalida_lineas.ASL_importegeneroestimado.Valor = i.ToString
                            Albsalida_lineas.ASL_importegenerovta.Valor = i.ToString
                            Albsalida_lineas.Actualizar()
                        End If
                    Next
                End If
                Agro_CalculoGastosTotalesAlbaran(IdAlbaran, Valorcambio)
            Next
        End If

    End Sub


    Private Sub ConsultaVentas()
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbSalida_Lineas.ASL_idlinea, "IdLinea")
        consulta.SelCampo(AlbSalida.ASA_idalbaran, "IdAlbaran")
        consulta.SelCampo(Nothing, "Cabecera")
        consulta.SelCampo(AlbSalida.ASA_albaran, "NAlbaran", AlbSalida_Lineas.ASL_idalbaran, AlbSalida.ASA_idalbaran)
        consulta.SelCampo(AlbSalida.ASA_fechasalida, "Fecha")
        consulta.SelCampo(PuntoVenta.Nombre, "PVenta", AlbSalida.ASA_idpuntoventa, PuntoVenta.IdPuntoVenta)
        consulta.SelCampo(Facturas.FRA_serie, "Serie", AlbSalida.ASA_idfactura, Facturas.FRA_idfactura)
        consulta.SelCampo(Facturas.FRA_factura, "Factura")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", AlbSalida.ASA_idcliente, Clientes.CLI_Codigo)
        consulta.SelCampo(AlbSalida_Lineas.ASL_idgenero, "IdGenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbSalida_Lineas.ASL_idgenero, Generos.GEN_IdGenero)
        consulta.SelCampo(SubFamilias.SFA_idfamilia, "Idfamilia", Generos.GEN_IdsubFamilia)
        consulta.SelCampo(AlbSalida_Lineas.ASL_idcategoria, "IdCategoria")
        consulta.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", AlbSalida_Lineas.ASL_idcategoria, CategoriasSalida.CAS_Id)
        consulta.SelCampo(AlbSalida_Lineas.ASL_idtipoconfeccion, "IdTipoConfeccion")
        consulta.SelCampo(ConfecEnvase.CEV_Nombre, "Confeccion", AlbSalida_Lineas.ASL_idtipoconfeccion, ConfecEnvase.CEV_Idconfec)
        consulta.SelCampo(AlbSalida_Lineas.ASL_palets, "Palets")
        consulta.SelCampo(AlbSalida_Lineas.ASL_bultos, "Bultos")
        consulta.SelCampo(AlbSalida_Lineas.ASL_piezas, "Piezas")
        consulta.SelCampo(AlbSalida_Lineas.ASL_kiloscliente, "KilosCliente")
        consulta.SelCampo(AlbSalida_Lineas.ASL_tipoprecio, "TipoPrecio")
        consulta.SelCampo(AlbSalida_Lineas.ASL_tipopreciovta, "TipoPrecioVta")
        Dim oPrecio As New Cdatos.bdcampo("@COALESCE(ASL_Precio,0) * COALESCE(ASA_ValorCambio,1)", AlbSalida_Lineas.ASL_precio.TipoBd, AlbSalida_Lineas.ASL_precio.Longitud, AlbSalida_Lineas.ASL_precio.Decimales)
        consulta.SelCampo(oPrecio, "Precio")
        'consulta.SelCampo(AlbSalida_Lineas.ASL_precio, "Precio")
        Dim oEstimado As New Cdatos.bdcampo("@COALESCE(ASL_PrecioEstimado,0) * COALESCE(ASA_ValorCambio,1)", AlbSalida_Lineas.ASL_precioestimado.TipoBd, AlbSalida_Lineas.ASL_precioestimado.Longitud, AlbSalida_Lineas.ASL_precioestimado.Decimales)
        consulta.SelCampo(oEstimado, "Estimado")
        'consulta.SelCampo(AlbSalida_Lineas.ASL_precioestimado, "Estimado")
        Dim oPrecioVen As New Cdatos.bdcampo("@COALESCE(ASL_PrecioVenta,0) * COALESCE(ASA_ValorCambio,1)", AlbSalida_Lineas.ASL_precioventa.TipoBd, AlbSalida_Lineas.ASL_precioventa.Longitud, AlbSalida_Lineas.ASL_precioventa.Decimales)
        consulta.SelCampo(oPrecioVen, "PrecioVen")
        'consulta.SelCampo(AlbSalida_Lineas.ASL_precioventa, "PrecioVen")
        consulta.SelCampo(AlbSalida.ASA_tipofc, "FC")
        consulta.SelCampo(AlbSalida.ASA_fechavaloracion, "FechaValoracion")

        Dim Diferencia As New Cdatos.bdcampo("@(COALESCE(ASL_Precio,0) * COALESCE(ASA_ValorCambio,1)) - (COALESCE(ASL_precioestimado,0) * COALESCE(ASA_ValorCambio,1)) ", Cdatos.TiposCampo.Importe, 10, 2)
        consulta.SelCampo(Diferencia, "Diferencia")

        Dim DifVen As New Cdatos.bdcampo("@(COALESCE(ASL_Precio,0) * COALESCE(ASA_ValorCambio,1)) - (COALESCE(ASL_precioestimado,0) * COALESCE(ASA_ValorCambio,1)) ", Cdatos.TiposCampo.Importe, 10, 2)
        consulta.SelCampo(DifVen, "DifVen")

        Dim oImporte As New Cdatos.bdcampo("@COALESCE(ASL_ImporteGeneroVta,0) * COALESCE(ASA_ValorCambio,1)", AlbSalida_Lineas.ASL_importegenerovta.TipoBd, AlbSalida_Lineas.ASL_importegenerovta.Longitud, AlbSalida_Lineas.ASL_importegenerovta.Decimales)
        consulta.SelCampo(oImporte, "Importe")
        'consulta.SelCampo(AlbSalida_Lineas.ASL_importegenerovta, "Importe")





        If TxDato1.Text.Trim <> "" Then consulta.WheCampo(Clientes.CLI_Codigo, ">=", TxDato1.Text)
        If TxDato2.Text.Trim <> "" Then consulta.WheCampo(Clientes.CLI_Codigo, "<=", TxDato2.Text)
        If TxDato3.Text.Trim <> "" Then consulta.WheCampo(AlbSalida.ASA_fechasalida, ">=", TxDato3.Text)
        If TxDato4.Text.Trim <> "" Then consulta.WheCampo(AlbSalida.ASA_fechasalida, "<=", TxDato4.Text)

        Dim WHE As String = consulta.Whe


        If RbFirme.Checked Then
            If WHE.Trim = "" Then
                WHE = " WHERE "
            Else
                WHE = WHE & " AND "
            End If
            WHE = WHE & " (ASA_TipoFC = 'F')  " & vbCrLf

        End If

        If RbComi.Checked Then
            If WHE.Trim = "" Then
                WHE = " WHERE "
            Else
                WHE = WHE & " AND "
            End If
            WHE = WHE & " (ASA_TipoFC = 'C')  " & vbCrLf

        End If



        If RbValorados.Checked Then
            If WHE.Trim = "" Then
                WHE = " WHERE "
            Else
                WHE = WHE & " AND "
            End If
            WHE = WHE & " (ASA_TipoFC = 'F' OR (ASA_TipoFC = 'C' AND ASA_FechaValoracion > '" & VaDate("").ToString("dd/MM/yyyy") & "')) " & vbCrLf

        End If


        If RbNoValorados.Checked Then
            If WHE.Trim = "" Then
                WHE = " WHERE "
            Else
                WHE = WHE & " AND "
            End If
            WHE = WHE & " ( ASA_TipoFC = 'C' AND ASA_FechaValoracion <= '" & VaDate("").ToString("dd/MM/yyyy") & "') " & vbCrLf

        End If




        'Facturado SN
        If RbSiFacturados.Checked Then
            If WHE = "" Then
                WHE = " WHERE COALESCE(AlbSalida.ASA_IdFactura,0) <> 0" & vbCrLf
            Else
                WHE = WHE & " AND COALESCE(AlbSalida.ASA_IdFactura,0) <> 0" & vbCrLf
            End If
        ElseIf RbNoFacturados.Checked Then
            If WHE = "" Then
                WHE = " WHERE COALESCE(AlbSalida.ASA_IdFactura,0) = 0" & vbCrLf
            Else
                WHE = WHE & " AND COALESCE(AlbSalida.ASA_IdFactura,0) = 0" & vbCrLf
            End If
        End If

        'Punto de venta
        If WHE = "" Then
            WHE = CadenaWhereLista(AlbSalida.ASA_idpuntoventa, ListadeCombo(cbPuntoVenta), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(AlbSalida.ASA_idpuntoventa, ListadeCombo(cbPuntoVenta), " AND ")
        End If
        'Familias
        If WHE = "" Then
            WHE = CadenaWhereLista(SubFamilias.SFA_idfamilia, ListadeCombo(CbFamilias), " WHERE ")
        Else
            WHE = WHE + CadenaWhereLista(SubFamilias.SFA_idfamilia, ListadeCombo(CbFamilias), " AND ")
        End If


        If VaDate(TxDato7.Text) > VaDate("") Then
            If WHE = "" Then
                WHE = " WHERE" & vbCrLf
            Else
                WHE = WHE & " AND" & vbCrLf
            End If
            Dim v As String = VaDate("").ToString("dd/MM/yyyy")
            WHE = WHE & " (COALESCE(FRA_Fecha,'" & v & "') <= '" & v & "'" & vbCrLf & " OR (COALESCE(FRA_Fecha,'" & v & "') >= '" & v & "' AND COALESCE(FRA_Fecha,'" & v & "') >= '" & VaDate(TxDato7.Text).ToString("dd/MM/yyyy") & "'))" & vbCrLf
        End If


        If VaDate(TxDato5.Text) > VaDate("") Then
            If WHE = "" Then
                WHE = " WHERE" & vbCrLf
            Else
                WHE = WHE & " AND" & vbCrLf
            End If
            Dim v As String = VaDate("").ToString("dd/MM/yyyy")
            WHE = WHE & " (COALESCE(ASA_Fechavaloracion,'" & v & "') <= '" & v & "'" & vbCrLf & " OR (COALESCE(ASA_Fechavaloracion,'" & v & "') >= '" & v & "' AND COALESCE(ASA_Fechavaloracion,'" & v & "') >= '" & VaDate(TxDato5.Text).ToString("dd/MM/yyyy") & "'))" & vbCrLf
        End If



        Dim sql As String = consulta.Sel(_IncluirTodosLosCampos) & WHE & "order by Fecha, nAlbaran"


        GridView1.Columns.Clear()
        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)
        'dt.Columns.Add(New DataColumn("Diferencia", GetType(Decimal)))


        For Each row As DataRow In dt.Rows

            Dim Precio As Decimal = VaDec(row("Precio"))
            Dim PrecioVen As Decimal = VaDec(row("PrecioVen"))
            Dim Estimado As Decimal = VaDec(row("Estimado"))
            Dim TipoPrecio As String = (row("TipoPrecio").ToString & "").Trim.ToUpper
            Dim TipoPrecioVta As String = (row("TipoPrecioVta").ToString & "").Trim.ToUpper

            'Si no es valorado, no tiene precio de venta
            Dim bValorado As Boolean = True
            Dim FC As String = (row("FC").ToString & "").Trim
            If FC = "C" And VaDate(row("FechaValoracion")) <= VaDate("") Then bValorado = False
            If Not bValorado Then PrecioVen = 0


            Dim Bultos As Decimal = VaDec(row("Bultos"))
            Dim Piezas As Decimal = VaDec(row("Piezas"))
            Dim KilosCliente As Decimal = VaDec(row("KilosCliente"))


            Select Case TipoPrecio

                Case "B"

                    Dim PrecioFinal As Decimal = 0
                    Dim EstimadoFinal As Decimal = 0
                    If KilosCliente <> 0 Then PrecioFinal = (Precio * Bultos) / KilosCliente
                    If KilosCliente <> 0 Then EstimadoFinal = (Estimado * Bultos) / KilosCliente

                    If ChkPbulto.CheckState = CheckState.Checked Then
                        If Bultos <> 0 Then PrecioFinal = (Precio * Bultos) / Bultos
                        If Bultos <> 0 Then EstimadoFinal = (Estimado * Bultos) / Bultos
                    End If
                    row("Precio") = PrecioFinal
                    row("Estimado") = EstimadoFinal

                    Precio = PrecioFinal
                    Estimado = EstimadoFinal

                    Dim DifSal As Decimal = PrecioFinal - EstimadoFinal
                    row("Diferencia") = DifSal
                    

                Case "P"
                    
                    Dim PrecioFinal As Decimal = 0
                    Dim EstimadoFinal As Decimal = 0
                    If KilosCliente <> 0 Then PrecioFinal = (Precio * Piezas) / KilosCliente
                    If KilosCliente <> 0 Then EstimadoFinal = (Estimado * Piezas) / KilosCliente

                    If ChkPbulto.CheckState = CheckState.Checked Then
                        If Bultos <> 0 Then PrecioFinal = (Precio * Piezas) / Bultos
                        If Bultos <> 0 Then EstimadoFinal = (Estimado * Piezas) / Bultos
                    End If

                    row("Precio") = PrecioFinal
                    row("Estimado") = EstimadoFinal

                    Dim DifSal As Decimal = PrecioFinal - EstimadoFinal
                    row("Diferencia") = DifSal
                    
                Case Else
                    'KILOS
                    Dim PrecioFinal As Decimal = Precio
                    Dim EstimadoFinal As Decimal = Estimado
                    If ChkPbulto.CheckState = CheckState.Checked Then
                        If Bultos <> 0 Then PrecioFinal = (Precio * KilosCliente) / Bultos
                        If Bultos <> 0 Then EstimadoFinal = (Estimado * KilosCliente) / Bultos
                    End If
                    row("Precio") = PrecioFinal
                    row("Estimado") = EstimadoFinal


                    row("Diferencia") = Precio - Estimado

            End Select



            Select Case TipoPrecioVta

                Case "B"
                    If ChkPbulto.CheckState = CheckState.Checked Then
                        If Bultos <> 0 Then PrecioVen = (PrecioVen * Bultos) / Bultos
                    Else
                        If KilosCliente <> 0 Then PrecioVen = (PrecioVen * Bultos) / KilosCliente
                    End If
                    row("PrecioVen") = PrecioVen

                    If bValorado Then
                        row("DifVen") = PrecioVen - VaDec(row("Precio"))
                    Else
                        row("DifVen") = 0
                    End If

                Case "P"
                    If ChkPbulto.CheckState = CheckState.Checked Then
                        If Bultos <> 0 Then PrecioVen = (PrecioVen * Piezas) / Bultos
                    Else
                        If KilosCliente <> 0 Then PrecioVen = (PrecioVen * Piezas) / KilosCliente
                    End If
                    row("PrecioVen") = PrecioVen

                    If bValorado Then
                        row("DifVen") = PrecioVen - VaDec(row("Precio"))
                    Else
                        row("DifVen") = 0
                    End If


                Case Else
                    'Kilos
                    If ChkPbulto.CheckState = CheckState.Checked Then
                        If Bultos <> 0 Then PrecioVen = (PrecioVen * KilosCliente) / Bultos
                    Else
                        If KilosCliente <> 0 Then PrecioVen = (PrecioVen * KilosCliente) / KilosCliente
                    End If

                    row("PrecioVen") = PrecioVen

                    If bValorado Then
                        row("DifVen") = PrecioVen - VaDec(row("Precio"))
                    Else
                        row("DifVen") = 0
                    End If


            End Select

        Next


        If dt.Columns.Contains("FC") Then dt.Columns.Remove("FC")
        If dt.Columns.Contains("FechaValoracion") Then dt.Columns.Remove("FechaValoracion")


        PonCabecera(dt)
        Grid.DataSource = dt


        If Not IsNothing(GridView1.Columns.ColumnByFieldName("Cabecera")) Then
            GridView1.Columns.ColumnByFieldName("Cabecera").GroupIndex = 1
            GridView1.ExpandAllGroups()
        End If


        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Palets", "{0:n0}")
        AñadeResumenCampo("Bultos", "{0:n0}")
        AñadeResumenCampo("KilosCliente", "{0:n0}")
        AñadeResumenCampo("Importe", "{0:n2}")
        AñadeResumenCampo("DifVen", "{0:n2}")


        AjustaColumnas()




    End Sub
    Private Sub GastosAlbaran(idLineaAlbaran As String, ByRef Gf As Double, ByRef Gc As Double, ByRef est As Double, ByRef Mat As Double, ByRef Conf As Double)

        Dim Sql As String
        Gf = 0
        Gc = 0
        est = 0
        Conf = 0
        Gf = 0
        Gc = 0
        Sql = "select SUM(ASC_estructura) as estructura, sum(ASC_materiales) as materiales,sum(asc_manipulacion) as manipulacion, "
        sql = sql + " sum(ASC_gastof) as gastof,sum(asc_gastoc) as gastoc from  albsalida_lineascostes where asc_idlinea=" + idLineaAlbaran
        Dim dtg As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)
        For Each rw In dtg.Rows
            est = est + VaDec(rw("estructura"))
            Mat = Mat + VaDec(rw("materiales"))
            Conf = Conf + VaDec(rw("manipulacion"))
            Gf = Gf + VaDec(rw("gastof"))
            Gc = Gc + VaDec(rw("gastoc"))
        Next



    End Sub

    Public Overrides Sub Consultar()
        MyBase.Consultar()



        If RbCostes.Checked = True Then
            If ChActu.CheckState = CheckState.Checked Then
                ConsultaCostes() ' hago la consulta actualizando
            End If
            ConsultaCostes()
        Else
            ConsultaVentas()
        End If
    End Sub


    Private Function PonCabecera(dt As DataTable) As DataTable

        For Each rw In dt.Rows
            rw("Cabecera") = rw("NAlbaran").ToString + " Fecha: " + FnLeft(rw("FECHA").ToString, 10) + " Cliente: " + rw("Cliente").ToString + " Pvta:" + rw("PVENTA") + " Factura: " + rw("SERIE") + " " + rw("FACTURA").ToString
        Next

        Return dt

    End Function


    Private Sub AjustaColumnas()

        Grid.ForceInitialize()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "GENERO", "CATEGORIA", "CONFECCION", "CONFECPALET", "PALETS", "BULTOS", "KILOSCLIENTE", "PRECIO", "ESTIMADO", "IMPORTE", "DIFERENCIA", "PRECIOVEN"
                    c.Visible = True
                Case "CABECERA"
                    c.Caption = "Albaran"
                    c.Visible = False
                Case "DIFVEN"
                    c.Caption = "Dif(Ven-Sal)"
                Case Else
                    c.Visible = False


            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "BULTOS", "PALETS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 100
                Case "KILOSCLIENTE",
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 100
                Case "CATEGORIA"
                    c.Width = 75
                Case "PVENTA"
                    c.MinWidth = 95
                    c.MaxWidth = 95
                Case "FECHA"
                    c.MinWidth = 85
                Case "PRECIO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 95
                    c.Caption = "PrecioSal"
                Case "ESTIMADO", "IMPORTE", "PRECIOVEN", "DIFVEN"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 95

                Case "DIFERENCIA"
                    c.Caption = "Dif(Sal-Est)"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 95


            End Select
        Next


    End Sub

    Private Sub AjustaColumnascostes()

        Grid.ForceInitialize()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "GENERO", "CATEGORIA", "CONFECCION", "CONFECPALET", "PALETS", "BULTOS", "KCLIENTE", "KNETOS", "DIF", "IVENTA", "GASTOSF", "GASTOSC", "EST", "MAT", "CONF"
                    c.Visible = True
                Case "CABECERA"
                    c.Caption = "Albaran"
                    c.Visible = False
                Case Else
                    c.Visible = False


            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "BULTOS", "PALETS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 100
                Case "KCLIENTE", "KNETOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 100
                Case "CATEGORIA"
                    c.Width = 75
                Case "PVENTA"
                    c.MinWidth = 95
                    c.MaxWidth = 95
                Case "FECHA"
                    c.MinWidth = 85
                Case "IVENTA", "GASTOSF", "GASTOSC", "EST", "MAT", "CONF"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    If ChkKilo.CheckState = CheckState.Checked Then
                        c.DisplayFormat.FormatString = "#,##0.0000"
                    Else
                        c.DisplayFormat.FormatString = "#,##0.00"

                    End If
                    c.Width = 100


            End Select
        Next


    End Sub



    Private Sub ChActu_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChActu.CheckedChanged
        If ChActu.CheckState = CheckState.Checked Then
            MsgBox("Atencion, se van a actualizar los costes de origen de las salidas y palets segun las tarifas de confección")
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If MsgBox("Actualizar importe estimado", vbYesNo) = vbYes Then
            ActualizaPrecioEstimado()
            MsgBox("Terminado!")
        End If
    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        Dim clientes As String = FiltroDesdeHasta("Cliente", TxDato1.Text, TxDato2.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato3.Text, TxDato4.Text)
        Dim puntosventa As String = FiltroCheckedComboBox("Puntos de venta", cbPuntoVenta)
        Dim familias As String = FiltroCheckedComboBox("Familias", CbFamilias)

        Dim RbTipoListado As RadioButton() = {RbPventa, RbCostes}
        Dim StrTipoListado As String() = {"Precio de venta", "Costes"}
        Dim TipoListado As String = FiltroRadioButton("Tipo listado", RbTipoListado, StrTipoListado)

        Dim RbAlbValorado As RadioButton() = {RbValorados, RbNoValorados}
        Dim StrAlbValorado As String() = {"SI", "NO"}
        Dim TipoAlbaranes As String = FiltroRadioButton("Albaranes valorados", RbAlbValorado, StrAlbValorado)

        Dim RbFacturados As RadioButton() = {RbSiFacturados, RbNoFacturados}
        Dim StrFacturados As String() = {"SI", "NO"}
        Dim Facturados As String = FiltroRadioButton("Facturados", RbFacturados, StrFacturados)

        Dim RbFC As RadioButton() = {RbFirme, RbComi, RbFcTodos}
        Dim StrFC As String() = {"FIRME", "COMISION", "FIRME Y COMISION"}
        Dim FC As String = FiltroRadioButton("Tipo de Albaran", RbFC, StrFC)

        Dim PVentaxBulto As String = FiltroCheckBox("", ChkPbulto, "Precio de Venta Por Bulto", "")
        Dim CostexKilo As String = FiltroCheckBox("", ChkKilo, "Coste por Kilo", "")


        If clientes <> "" Then LineasDescripcion.Add(clientes)
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If VaDate(TxDato7.Text) > VaDate("") Then LineasDescripcion.Add("Desde fecha factura: " & VaDate(TxDato7.Text).ToString("dd/MM/yyyy"))
        If puntosventa <> "" Then LineasDescripcion.Add(puntosventa)
        If familias <> "" Then LineasDescripcion.Add(familias)
        If TipoListado <> "" Then LineasDescripcion.Add(TipoListado)
        If TipoAlbaranes <> "" Then LineasDescripcion.Add(TipoAlbaranes)
        If Facturados <> "" Then LineasDescripcion.Add(Facturados)
        If FC <> "" Then LineasDescripcion.Add(FC)
        If PVentaxBulto <> "" Then LineasDescripcion.Add(PVentaxBulto)
        If CostexKilo <> "" Then LineasDescripcion.Add(CostexKilo)



        MyBase.Imprimir()

    End Sub


End Class