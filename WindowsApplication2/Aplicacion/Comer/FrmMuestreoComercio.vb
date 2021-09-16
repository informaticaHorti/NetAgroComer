Imports DevExpress.XtraEditors


Public Class FrmMuestreoComercio
    Inherits FrMantenimiento



    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim AlbEntrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim AlbEntrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)
    Dim AlbEntrada_His As New E_AlbEntrada_his(Idusuario, cn)

    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
    Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Envases As New E_Envases(Idusuario, cn)

    Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)

    Dim Micentro As String



    Private Sub ParametrosFrm()

        EntidadFrm = AlbEntrada_lineas


        Dim lc As New List(Of Object)
        ListaControles = lc



        ParamTx(TxDato1, AlbEntrada_lineas.AEL_muestreo, Lb1, True, Cdatos.TiposCampo.EnteroPositivo, 0, 12)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato6, AlbEntrada_lineas.AEL_fechamuestreo, Lb26, False, Cdatos.TiposCampo.Fecha, 0, 10)
        LbPuntoVenta.CL_ControlAsociado = TxDato1
        LbNomPv.CL_ControlAsociado = TxDato1
        ParamTx(TxDato13, AlbEntrada_lineascla.ALC_idcategoria, Lb4, True)

        ParamTx(TxDato9, Nothing, Lbuds_1, True)
        'ParamTx(LbPrecio, AlbEntrada_lineascla.ALC_precio, Lb5, False)


        'AsociarGrid(ClGrid1, TxDato13, LbPrecio, AlbEntrada_lineascla)
        AsociarGrid(ClGrid1, TxDato13, TxDato9, AlbEntrada_lineascla)


        PropiedadesCamposGr(ClGrid1, "ALC_id", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Categoria", "Categoria", True, 50)
        PropiedadesCamposGr(ClGrid1, "Cantidad", "Cantidad", True, 20, True, "#,###")
        PropiedadesCamposGr(ClGrid1, "Porcentaje", "%", True, 20, False, "#,##0.00")
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 20, False, "#,##0.0000")
        PropiedadesCamposGr(ClGrid1, "Importe", "Importe", True, 30, True, "#,##0.0000")



        ParamTx(TxObservaciones, AlbEntrada_lineas.AEL_observaciones, LbObservaciones)
        ParamTx(TxObsProveedor, AlbEntrada_lineas.AEL_ObservacionesProveedor, LbObsProveedor)




        AsociarControles(TxDato13, BtBuscaCat, Categorias.bTBuscaEnt, Categorias, Categorias.CAE_CategoriaCalibre, Lb2)



        tt.SetToolTip(LbBascu1, "Cambiar a báscula 1")
        tt.SetToolTip(LbBascu2, "Cambiar a báscula 2")
        tt.SetToolTip(LbBascu3, "Cambiar a báscula 3")
        tt.SetToolTip(LbBascu4, "Cambiar a báscula 4")



    End Sub


    Private Sub FrmMuestreoComercio_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BTaux1.Visible = True
        BTaux1.Text = "Imprimir"
        BTaux1.Image = PictureBox1.Image

        BtAux2.Visible = True
        BtAux2.Text = "I.Directa"
        BtAux2.Image = PictureBox2.Image

    End Sub


    Public Overrides Sub Anular()
        If LbId.Text <> "" Then
            If MsgBox("Desea anular el muestreo", vbYesNo) = vbYes Then
                Dim sql As String = "Delete from albentrada_lineascla where ALC_idlineaentrada=" + LbId.Text
                AlbEntrada_lineascla.MiConexion.OrdenSql(sql)

                If AlbEntrada_lineas.LeerId(LbId.Text) = True Then
                    AlbEntrada_lineas.AEL_fechamuestreo.Valor = "01/01/1900"
                    AlbEntrada_lineas.Actualizar()
                    'Agro_ActualizaLineaCla(LbCampa.Text, LbId.Text, AlbEntrada.AEN_TipoFCS.Valor, LbFecha.Text) ' vuelvo a genera una linea por el total

                End If
                Agro_GeneraAlbaranEntrada(AlbEntrada_lineas.AEL_idalbaran.Valor)


            End If
        End If
    End Sub

    Public Overrides Sub ControlClave()
        ' componemos la clave



        Dim i As Integer

        i = AlbEntrada_lineas.LeerMuestreo(LbCampa.Text, TxDato1.Text)

        LbId.Text = i.ToString

        If i > 0 Then
            AlbEntrada_lineas.LeerId(i.ToString)
            AlbEntrada.LeerId(AlbEntrada_lineas.AEL_idalbaran.Valor)

            'Dim EntradaConfeccionada As String = (AlbEntrada.AEN_EntradaConfeccionada.Valor & "").Trim.ToUpper
            'If EntradaConfeccionada = "S" Then
            '    MsgBox("Entrada directa, no se puede muestrear")
            '    TxDato1.MiError = True
            '    Exit Sub
            'End If



            LbPrecioCompra.Text = AlbEntrada_lineas.AEL_precio.Valor
            LbTipoPrecio.Text = AlbEntrada_lineas.AEL_tipoprecio.Valor

            CargaLineasGrid()
            If VaInt(AlbEntrada.AEN_IdCentro.Valor) <> MiMaletin.IdCentro Then
                MsgBox("Partida de otro centro ")
                LbId.Text = ""
                TxDato1.Text = ""
                Exit Sub
            End If
            'If VaInt(AlbEntrada.AEN_campa.Valor) <> MiMaletin.Ejercicio Then
            ' MsgBox("No coincide la campaña")
            ' LbId.Text = ""
            ' TxDato1.Text = ""
            ' Exit Sub
            ' End If
            ' Else
            '     LbId.Text = AlbEntrada.AEN_MaxId
        Else
            MsgBox("Partida inexistente")
            TxDato1.Text = ""
            LbId.Text = ""
            Exit Sub

        End If



    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)


        Select Case LbTipoPrecio.Text
            Case "B"
                TxDato9.Text = AlbEntrada_lineascla.ALC_bultos.Valor
            Case "P"
                TxDato9.Text = AlbEntrada_lineascla.ALC_piezas.Valor
            Case Else
                TxDato9.Text = AlbEntrada_lineascla.ALC_kilosnetos.Valor
        End Select


        LbPrecio.Text = VaDec(AlbEntrada_lineascla.ALC_precio.Valor).ToString("#,##0.00")


        Calculoimporte()




    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles

        MyBase.Entidad_a_Datos()

        Select Case LbTipoPrecio.Text
            Case "B"
                LbUdsPartida_1.Text = "Bultos partida"
                LbUdsPte_1.Text = "Bultos pte"
                Lbuds_1.Text = "BULTOS"
                LbUdsPartida.Text = VaDec(AlbEntrada_lineas.AEL_bultos.Valor).ToString("#,###")
            Case "P"
                LbUdsPartida_1.Text = "Piezas partida"
                LbUdsPte_1.Text = "Piezas pte"
                Lbuds_1.Text = "PIEZAS"
                LbUdsPartida.Text = VaDec(AlbEntrada_lineas.AEL_piezas.Valor).ToString("#,###")
            Case Else
                LbUdsPartida_1.Text = "Kilos partida"
                LbUdsPte_1.Text = "Kilos pte"
                Lbuds_1.Text = "KILOS"
                LbUdsPartida.Text = VaDec(AlbEntrada_lineas.AEL_kilosnetos.Valor).ToString("#,###")

        End Select

        Lb31.Text = AlbEntrada_lineas.AEL_idgenero.Valor


        If Generos.LeerId(Lb31.Text) = True Then
            Lb32.Text = Generos.GEN_NombreGenero.Valor
            BtBuscaCat.CL_Filtro = "idfamilia=" + Generos.idfamiliagenero
        End If

        If AlbEntrada.LeerId(AlbEntrada_lineas.AEL_idalbaran.Valor) = True Then
            Lb27.Text = AlbEntrada.AEN_IdAgricultor.Valor
            LbFecha.Text = AlbEntrada.AEN_Fecha.Valor
            If Agricultores.LeerId(Lb27.Text) = True Then
                Lb19.Text = Agricultores.AGR_Nombre.Valor
            End If
            LbAlba.Text = AlbEntrada.AEN_Campa.Valor + "/ " + AlbEntrada.AEN_IdCentro.Valor + " " + AlbEntrada.AEN_Albaran.Valor
            LbFc.Text = AlbEntrada.AEN_TipoFCS.Valor
        End If


        PintaPuntoVenta(AlbEntrada.AEN_IdPuntoVenta.Valor)
        ' llenar el grid

        CargaLineasGrid()
        difekilos()


        If VaDate(AlbEntrada_lineas.AEL_fechamuestreo.Valor) > VaDate("") Then

            Dim bloqueo As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.FECHA_BLOQUEO_CLASIFICACIONES)
            If VaDate(AlbEntrada.AEN_Fecha.Valor) <= VaDate(bloqueo) Then
                BModificar.Visible = False
                BAnular.Visible = False
                MsgBox("Clasificación bloqueada")
            Else
                BModificar.Visible = True
                BAnular.Visible = True
            End If

        End If

        pnlRevisada.Visible = ((AlbEntrada_lineas.AEL_RevisadaWeb.Valor & "").Trim = "S")

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean


        'asociar cabecera con lineas
        Dim r As Boolean
        AlbEntrada_lineascla.ALC_idlineaentrada.Valor = LbId.Text

        AlbEntrada_lineascla.ALC_idgenero.Valor = Lb31.Text
        AlbEntrada_lineascla.ALC_idalbaran.Valor = AlbEntrada_lineas.AEL_idalbaran.Valor
        AlbEntrada_lineascla.ALC_piezas.Valor = "0"
        AlbEntrada_lineascla.ALC_bultos.Valor = "0"
        AlbEntrada_lineascla.ALC_kilosnetos.Valor = "0"
        Select Case LbTipoPrecio.Text
            Case "B"
                AlbEntrada_lineascla.ALC_bultos.Valor = TxDato9.Text
            Case "P"
                AlbEntrada_lineascla.ALC_piezas.Valor = TxDato9.Text
            Case Else
                AlbEntrada_lineascla.ALC_kilosnetos.Valor = TxDato9.Text
        End Select

        'AlbEntrada_lineascla.ALC_precio.Valor = LbPrecioCompra.Text
        'TxDato2.Text = LbPrecioCompra.Text



        SqlGrid()
        r = MyBase.GuardarLineas(Gr)
        difekilos()


        Return r
    End Function


    Public Overrides Sub DespuesdeGuardarLinea(ByVal gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)
        '        GeneraAlbaranEntrada(VaInt(AlbEntrada_lineas.AEL_idalbaran.Valor))


        ClGrid1.GridView.RefreshData()

    End Sub
    Public Overrides Sub DespuesdeGuardar()


        ' por si acaso
        Repartolineas()
        Agro_GeneraAlbaranEntrada(VaInt(AlbEntrada_lineas.AEL_idalbaran.Valor))

        MyBase.DespuesdeGuardar()

    End Sub

    Private Sub Repartolineas()
        Dim consulta As New Cdatos.E_select
        Dim sql As String
        Dim Tk As Double = 0
        Dim Tb As Double = 0
        Dim Tp As Double = 0
        Dim kilos As Double = 0
        Dim bultos As Double = 0
        Dim piezas As Double = 0


        Dim dicst As New Dictionary(Of Integer, StLmed)
        Dim Valores As StLmed


        If AlbEntrada_lineas.LeerId(LbId.Text) Then
            bultos = VaDec(AlbEntrada_lineas.AEL_bultos.Valor)
            kilos = VaDec(AlbEntrada_lineas.AEL_kilosnetos.Valor)
            piezas = VaDec(AlbEntrada_lineas.AEL_piezas.Valor)
        End If

        consulta.SelCampo(AlbEntrada_lineascla.ALC_id, "id")
        consulta.SelCampo(AlbEntrada_lineascla.ALC_kilosnetos, "Kilos")
        consulta.SelCampo(AlbEntrada_lineascla.ALC_bultos, "bultos")
        consulta.SelCampo(AlbEntrada_lineascla.ALC_piezas, "piezas")

        consulta.WheCampo(AlbEntrada_lineascla.ALC_idlineaentrada, "=", LbId.Text)

        sql = consulta.SQL

        Dim r As Integer = 0
        Dim dt As DataTable = AlbEntrada_lineascla.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                Dim id As Integer = VaInt(rw("id"))
                Valores.Kilos = VaDec(rw("kilos"))
                Valores.Bultos = VaDec(rw("bultos"))
                Valores.Piezas = VaDec(rw("piezas"))
                Valores.id = id


                r = r + 1
                dicst(r) = Valores
            Next
        End If

        Dim mk As Double
        Dim ik As Integer
        Dim mb As Double
        Dim ib As Integer
        Dim mp As Double
        Dim ip As Integer

        For x = 1 To r


            Valores = dicst(x)
            Dim reparto As Double = 0
            Select Case LbTipoPrecio.Text
                Case "B"
                    If bultos <> 0 Then
                        reparto = Valores.Bultos / bultos
                    End If
                    Valores.Piezas = Math.Round(piezas * reparto, 0)
                    Valores.Kilos = Math.Round(kilos * reparto, 0)
                Case "P"
                    If piezas <> 0 Then
                        reparto = Valores.Piezas / piezas
                    End If
                    Valores.Bultos = Math.Round(bultos * reparto)
                    Valores.Kilos = Math.Round(kilos * reparto)
                Case Else
                    If kilos <> 0 Then
                        reparto = Valores.Kilos / kilos
                    End If
                    Valores.Bultos = Math.Round(bultos * reparto)
                    Valores.Piezas = Math.Round(piezas * reparto)
            End Select


            Tk = Tk + Valores.Kilos
            Tb = Tb + Valores.Bultos
            Tp = Tp + Valores.Piezas


            dicst(x) = Valores




            If dicst(x).Kilos >= mk Then
                mk = dicst(x).Kilos
                ik = x

            End If

            If dicst(x).Bultos >= mb Then
                mb = dicst(x).Bultos
                ib = x

            End If


            If dicst(x).Piezas >= mp Then
                mp = dicst(x).Piezas
                ip = x

            End If




        Next
        If ik > 0 Then
            Valores = dicst(ik)
            Valores.Kilos = Valores.Kilos + kilos - Tk
            dicst(ik) = Valores
        End If

        If ib > 0 Then
            Valores = dicst(ib)
            Valores.Bultos = Valores.Bultos + bultos - Tb
            dicst(ib) = Valores
        End If


        If ip > 0 Then
            Valores = dicst(ip)
            Valores.Piezas = Valores.Piezas + piezas - Tp
            dicst(ip) = Valores
        End If

        For x = 1 To r
            Valores = dicst(x)
            If AlbEntrada_lineascla.LeerId(dicst(x).id) = True Then
                AlbEntrada_lineascla.ALC_kilosnetos.Valor = Valores.Kilos.ToString
                AlbEntrada_lineascla.ALC_bultos.Valor = Valores.Bultos.ToString
                AlbEntrada_lineascla.ALC_piezas.Valor = Valores.Piezas.ToString
                AlbEntrada_lineascla.Actualizar()
            End If
        Next



    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)

        Lb6.Text = ""

        LbPrecio.Text = ""

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbCampa.Text = MiMaletin.Ejercicio.ToString
        PintaPuntoVenta(MiMaletin.IdPuntoVenta.ToString)
        PintaNbascula(Val(FnRight(Me.Text, 1)))

        BModificar.Visible = True
        BAnular.Visible = True

        pnlRevisada.Visible = False

    End Sub

    Private Sub CargaLineasGrid()

        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)

        If Not IsNothing(ClGrid1.GridView.Columns.ColumnByFieldName("Porcentaje")) Then
            ClGrid1.GridView.Columns.ColumnByFieldName("Porcentaje").MaxWidth = 50
            ClGrid1.GridView.Columns.ColumnByFieldName("Porcentaje").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            ClGrid1.GridView.Columns.ColumnByFieldName("Porcentaje").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        End If

    End Sub


    Private Sub CalculaPorcentaje()

        Dim KilosPartida As Decimal = VaDec(LbUdsPartida.Text)

        For indice As Integer = 0 To ClGrid1.GridView.RowCount - 1

            Dim row As DataRow = ClGrid1.GridView.GetDataRow(indice)
            If Not IsNothing(row) Then

                Dim porcentaje As Decimal = 0
                If KilosPartida <> 0 Then porcentaje = Math.Round(VaDec(row("Cantidad")) / KilosPartida * 100, 2)
                row("Porcentaje") = porcentaje

            End If

        Next


        ClGrid1.GridView.RefreshData()


    End Sub


    Private Sub SqlGrid()
        Dim id As String

        id = LbId.Text
        Dim sql As String
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim CONSULTA As New Cdatos.E_select

        CONSULTA.SelCampo(AlbEntrada_lineascla.ALC_id, "")
        CONSULTA.SelCampo(AlbEntrada_lineascla.ALC_idcategoria, "Cat")
        CONSULTA.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", AlbEntrada_lineascla.ALC_idcategoria)
        Select Case LbTipoPrecio.Text
            Case "B"
                CONSULTA.SelCampo(AlbEntrada_lineascla.ALC_bultos, "Cantidad")
            Case "P"
                CONSULTA.SelCampo(AlbEntrada_lineascla.ALC_piezas, "Cantidad")
            Case Else
                CONSULTA.SelCampo(AlbEntrada_lineascla.ALC_kilosnetos, "Cantidad")
        End Select
        CONSULTA.SelCampo(AlbEntrada_lineascla.ALC_kilosnetos, "Kilos")
        CONSULTA.SelCampo(Nothing, "Porcentaje")
        CONSULTA.SelCampo(AlbEntrada_lineascla.ALC_precio, "Precio")
        CONSULTA.SelCampo(AlbEntrada_lineascla.ALC_precio, "Importe")
        CONSULTA.WheCampo(AlbEntrada_lineascla.ALC_idlineaentrada, "=", id)
        '            CONSULTA.WheCampo(AlbEntrada_lineascla.ALC_idcategoria, ">", 0)

        sql = CONSULTA.SQL
        sql = sql + " order by ALC_id"

        ClGrid1.Consulta = sql

    End Sub

    Public Overrides Sub DespuesdeCargarLineas(ByVal gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)


        For indice As Integer = 0 To ClGrid1.GridView.RowCount - 1
            Dim row As DataRow = ClGrid1.GridView.GetDataRow(indice)
            If Not IsNothing(row) Then

                Dim importe As Double = VaDec(row("Cantidad")) * VaDec(row("Precio"))
                ClGrid1.GridView.SetRowCellValue(indice, ClGrid1.GridView.Columns("Importe"), Format(importe, "#0.00"))
            End If
        Next


        If gr Is ClGrid1 Then CalculaPorcentaje()


    End Sub



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()

        '     BTaux1.Visible = True
        '     BTaux1.Text = "Imprimir"
        '     BTaux1.Image = PictureBox1.Image
        '
        '       BtAux2.Visible = True
        '       BtAux2.Text = "I.Directa"
        '      BtAux2.Image = PictureBox2.Image


    End Sub

    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        'If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString Then
        '    MsgBox("No se puede modificar el albarán de otro punto de venta")
        '    Exit Sub
        'End If

        Dim f As String = AlbEntrada_his.AlbaranFacturado(AlbEntrada_lineas.AEL_idalbaran.Valor)
        If f <> "" Then
            MsgBox("Albaranes: " + f + " facturados ")
            Exit Sub
        End If

        f = AlbEntrada_His.GastosFacturados(AlbEntrada_lineas.AEL_idalbaran.Valor)
        If f <> "" Then
            MsgBox("Gastos " + f + " facturados")
            Exit Sub

        End If



        f = AlbEntrada_His.AlbaranFacturado(AlbEntrada_lineas.AEL_idalbaran.Valor)
        If f <> "" Then
            MsgBox("Albaran" + f + " facturado")
            Exit Sub
        End If



        MyBase.BAnular_Click(sender, e)
    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        'If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString Then
        '    MsgBox("No se puede modificar el albarán de otro punto de venta")
        '    Exit Sub
        'End If

        Dim f As String = AlbEntrada_His.AlbaranFacturado(AlbEntrada_lineas.AEL_idalbaran.Valor)
        If f <> "" Then
            MsgBox("Albaranes: " + f + " facturados ")
            Exit Sub
        End If

        f = AlbEntrada_His.GastosFacturados(AlbEntrada_lineas.AEL_idalbaran.Valor)
        If f <> "" Then
            MsgBox("Gastos " + f + " facturados")
            Exit Sub

        End If



        f = AlbEntrada_His.AlbaranFacturado(AlbEntrada_lineas.AEL_idalbaran.Valor)
        If f <> "" Then
            MsgBox("Albaran" + f + " facturado")
            Exit Sub
        End If

        MyBase.BModificar_Click(sender, e)

    End Sub








    Private Sub PintaPuntoVenta(ByVal idpv As String)
        LbPuntoVenta.Text = idpv

        If PuntoVenta.LeerId(idpv) = True Then
            LbNomPv.Text = PuntoVenta.Nombre.Valor
            micentro = PuntoVenta.IdCentro.Valor
        Else
            LbNomPv.Text = ""
        End If

    End Sub





    Private Sub difekilos()
        Dim tk As Double
        tk = VaDec(ClGrid1.GridView.Columns("Cantidad").SummaryItem.SummaryValue)
        LbUdsPte.Text = (VaDec(LbUdsPartida.Text) - tk).ToString("#,###")
    End Sub



    Public Overrides Sub Guardar()
        If VaDec(LbUdsPte.Text) <> 0 Then
            MsgBox("Error en cantidad")

        Else
            MyBase.Guardar()

        End If
    End Sub



    Private Sub TxDato6_Valida(ByVal edicion As Boolean) Handles TxDato6.Valida
        If edicion = True Then
            If TxDato6.Text = "" Then
                TxDato6.Text = FnFechaHoy()
            End If
            TxDato6.Text = FnFecha(TxDato6.Text)
            If TxDato6.Text = "" Then
                TxDato6.MiError = True
            End If
        End If
    End Sub

    Private Sub CambiaBascula(ByVal nb As Integer)
        Dim s As Integer

        For Each formulario As Form In Me.MdiParent.MdiChildren
            If formulario.Text = "Muestreo " + nb.ToString Then
                formulario.Focus()
                s = nb
            End If
        Next
        If s = 0 Then
            Dim frm As New FrmMuestreoComercio
            frm.MdiParent = Me.MdiParent
            frm.Text = "Muestreo " + nb.ToString
            frm.Show()
        End If

    End Sub

    Private Sub LbBascu1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbBascu1.Click
        CambiaBascula(1)

    End Sub

    Private Sub LbBascu2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbBascu2.Click
        CambiaBascula(2)
    End Sub

    Private Sub LbBascu3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbBascu3.Click
        CambiaBascula(3)

    End Sub

    Private Sub LbBascu4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbBascu4.Click
        CambiaBascula(4)

    End Sub

    Private Sub PintaNbascula(ByVal Bascula As Integer)

        LbBascu1.BackColor = Color.White
        LbBascu2.BackColor = Color.White
        LbBascu3.BackColor = Color.White
        LbBascu4.BackColor = Color.White
        Select Case Bascula
            Case 1
                LbBascu1.BackColor = Color.LightGreen
            Case 2
                LbBascu2.BackColor = Color.LightGreen
            Case 3
                LbBascu3.BackColor = Color.LightGreen
            Case 4
                LbBascu4.BackColor = Color.LightGreen
        End Select
    End Sub

    Public Overrides Sub TeclaFuncion(ByVal Tecla As System.Windows.Forms.Keys, ByVal obj As Object)
        MyBase.TeclaFuncion(Tecla, obj)
        Select Case Tecla
            Case Keys.F5
                CambiaBascula(1)
            Case Keys.F6
                CambiaBascula(2)
            Case Keys.F7
                CambiaBascula(3)
            Case Keys.F8
                CambiaBascula(4)

        End Select
    End Sub









    Private Sub TxDato9_Valida(ByVal edicion As Boolean) Handles TxDato9.Valida
        If edicion = True Then
            If LbPrecio.Text = "" Then
                LbPrecio.Text = LbPrecioCompra.Text
            End If
            Calculoimporte()

            'If LbPrecio.Visible = False Then
            '    ClGrid1.UltimoControl = TxDato9.Orden
            'Else
            '    ClGrid1.UltimoControl = LbPrecio.Orden
            'End If

        End If

    End Sub

    Private Sub Calculoimporte()
        Dim i As Double = VaDec(TxDato9.Text) * VaDec(LbPrecio.Text)
        Lb6.Text = Format(i, "#,###0.00")
    End Sub

    Private Sub TxDato2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxDato2_Valida(ByVal edicion As Boolean)
        If edicion = True Then
            If LbPrecio.Text = "" Then
                LbPrecio.Text = LbPrecioCompra.Text
            End If

            Calculoimporte()

        End If

    End Sub


    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaInt(LbId.Text) > 0 Then

            Dim dt As DataTable = CType(ClGrid1.Grid.DataSource, DataTable)

            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    C1_ImprimirClasificacionPartida(TipoImpresion.Preliminar, dt, TxDato1.Text, Lb19.Text, Lb32.Text, LbUdsPartida.Text, TxObsProveedor.Text)
                Else
                    MsgBox("No hay datos que imprimir")
                End If
            Else
                MsgBox("No hay datos que imprimir")
            End If


        End If

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()


        If VaInt(LbId.Text) > 0 Then

            Dim dt As DataTable = CType(ClGrid1.Grid.DataSource, DataTable)

            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    C1_ImprimirClasificacionPartida(TipoImpresion.ImpresoraPorDefecto, dt, TxDato1.Text, Lb19.Text, Lb32.Text, LbUdsPartida.Text, TxObsProveedor.Text)
                Else
                    MsgBox("No hay datos que imprimir")
                End If
            Else
                MsgBox("No hay datos que imprimir")
            End If


        End If

    End Sub



    Private Sub btDocumental_Click(sender As System.Object, e As System.EventArgs) Handles btDocumental.Click

        Dim IdAlbaran As String = AlbEntrada_lineas.AEL_idalbaran.Valor

        If VaDec(LbId.Text) > 0 And VaDec(IdAlbaran) > 0 Then

            Dim fr As New FrDocs
            fr.Init(AlbEntrada.NombreBd, AlbEntrada.NombreTabla, IdAlbaran)
            fr.ShowDialog()

        End If

    End Sub

End Class