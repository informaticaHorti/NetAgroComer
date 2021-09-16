Imports DevExpress.XtraEditors


Public Class FrmValoracionNoFirme
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
    Dim PventaUsuario As New E_PventaUsuario(Idusuario, cn)




    Dim Micentro As String



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


    Private Sub ParametrosFrm()

        EntidadFrm = AlbEntrada_lineas


        Dim lc As New List(Of Object)
        ListaControles = lc



        ParamTx(TxDato1, AlbEntrada_lineas.AEL_muestreo, Lb1, True, Cdatos.TiposCampo.EnteroPositivo, 0, 12)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxFechaValoracion, AlbEntrada_lineas.AEL_FechaValoracion, LbFechaValoracion, True)
        ParamTx(TxTipoPrecio, AlbEntrada_lineas.AEL_tipoprecio, Nothing, True)
        'ParamTx(LbFechaMuestreo, AlbEntrada_lineas.AEL_fechamuestreo, Lb26, False, Cdatos.TiposCampo.Fecha, 0, 10)
        LbPuntoVenta.CL_ControlAsociado = TxDato1
        LbNomPv.CL_ControlAsociado = TxDato1
        'ParamTx(LbCategoria, AlbEntrada_lineascla.ALC_idcategoria, Lb4, True)

        'ParamTx(TxPrecio, Nothing, Lbuds_1, True)
        ParamTx(TxPrecio, AlbEntrada_lineascla.ALC_precio, Lb5, False)

        AsociarControles(TxDato1, BtBuscaAlbaran, AlbEntrada_lineas.BtBuscaPar, AlbEntrada_lineas)
        BtBuscaAlbaran.CL_Filtro = "Tipo = 'S' AND FechaMuestreo<>'01/01/1900' " + Pventausuario.FiltroPventaGrid("PV", "AND")
        'AsociarGrid(ClGrid1, TxDato13, LbPrecio, AlbEntrada_lineascla)
        AsociarGrid(ClGrid1, TxPrecio, TxPrecio, AlbEntrada_lineascla)


        PropiedadesCamposGr(ClGrid1, "ALC_id", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Categoria", "Categoria", True, 50)
        PropiedadesCamposGr(ClGrid1, "Cantidad", "Cantidad", True, 20, True, "#,###")
        PropiedadesCamposGr(ClGrid1, "Porcentaje", "%", True, 20, False, "#,##0.00")
        PropiedadesCamposGr(ClGrid1, "Precio", "Precio", True, 20, False, "#,##0.0000")
        PropiedadesCamposGr(ClGrid1, "Importe", "Importe", True, 30, True, "#,##0.0000")



        ParamTx(TxObservaciones, AlbEntrada_lineas.AEL_observaciones, LbObservaciones)
        ParamTx(TxObsProveedor, AlbEntrada_lineas.AEL_ObservacionesProveedor, LbObsProveedor)




        'AsociarControles(LbCategoria, BtBuscaCat, Categorias.btBuscaent, Categorias, Categorias.CAE_CategoriaCalibre, Lb2)



        tt.SetToolTip(LbBascu1, "Cambiar a báscula 1")
        tt.SetToolTip(LbBascu2, "Cambiar a báscula 2")
        tt.SetToolTip(LbBascu3, "Cambiar a báscula 3")
        tt.SetToolTip(LbBascu4, "Cambiar a báscula 4")


    End Sub


    Private Sub FrmValoracionNoFirme_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BAnular.Text = "Anular valoración"
        BAnular.Width = 110

    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave


        Dim i As Integer= AlbEntrada_lineas.LeerMuestreo(LbCampa.Text, TxDato1.Text)

        If i > 0 Then

            LbId.Text = i.ToString



            If AlbEntrada_lineas.LeerId(i) Then
                If VaDate(AlbEntrada_lineas.AEL_fechamuestreo.Valor) = VaDate("") Then
                    MsgBox("PARTIDA NO MUESTREADA")
                    LbId.Text = ""

                End If


                If VaDec(AlbEntrada_lineas.AEL_idalbaran.Valor) > 0 Then
                    If AlbEntrada.LeerId(AlbEntrada_lineas.AEL_idalbaran.Valor) = True Then
                        If AlbEntrada.AEN_TipoFCS.Valor <> "S" Then
                            MsgBox("SOLO ALBARANES TIPO S ")
                            LbId.Text = ""
                        Else
                            If VaInt(AlbEntrada.AEN_IdCentro.Valor) <> MiMaletin.IdCentro Then
                                MsgBox("No pertence al centro")
                                LbId.Text = ""

                            End If
                        End If

                    End If
                End If
            End If


            If LbId.Text <> "" Then
                LbPrecioCompra.Text = AlbEntrada_lineas.AEL_precio.Valor


                CargaLineasGrid()
            End If


        Else
            MsgBox("Partida inexistente")
            TxDato1.Text = ""
            LbId.Text = ""
            Exit Sub

        End If



    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)


        Select Case TxTipoPrecio.Text
            Case "B"
                LbKilos.Text = AlbEntrada_lineascla.ALC_bultos.Valor
            Case "P"
                LbKilos.Text = AlbEntrada_lineascla.ALC_piezas.Valor
            Case Else
                LbKilos.Text = AlbEntrada_lineascla.ALC_kilosnetos.Valor
        End Select


        'LbKilos.Text = VaDec(AlbEntrada_lineascla.ALC_precio.Valor).ToString("#,##0.00")
        LbCategoria.Text = AlbEntrada_lineascla.ALC_idcategoria.Valor

        Dim FechaMuestreo As String = ""
        If VaDate(AlbEntrada_lineas.AEL_fechamuestreo.Valor) > VaDate("") Then FechaMuestreo = VaDate(AlbEntrada_lineas.AEL_fechamuestreo.Valor).ToString("dd/MM/yyyy")
        LbFechaMuestreo.Text = FechaMuestreo

        Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)
        If VaInt(LbCategoria.Text) > 0 Then
            If CategoriasEntrada.LeerId(LbCategoria.Text) Then
                LbNomCategoria.Text = CategoriasEntrada.CAE_CategoriaCalibre.Valor
            End If
        End If



        Calculoimporte()

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles

        MyBase.Entidad_a_Datos()

        'Select Case TxTipoPrecio.Text
        '    Case "B"
        '        LbUdsPartida_1.Text = "Bultos partida"
        '        Lbuds_1.Text = "BULTOS"
        '        LbUdsPartida.Text = VaDec(AlbEntrada_lineas.AEL_bultos.Valor).ToString("#,###")
        '    Case "P"
        '        LbUdsPartida_1.Text = "Piezas partida"
        '        Lbuds_1.Text = "PIEZAS"
        '        LbUdsPartida.Text = VaDec(AlbEntrada_lineas.AEL_piezas.Valor).ToString("#,###")
        '    Case Else
        '        LbUdsPartida_1.Text = "Kilos partida"
        '        Lbuds_1.Text = "KILOS"
        '        LbUdsPartida.Text = VaDec(AlbEntrada_lineas.AEL_kilosnetos.Valor).ToString("#,###")

        'End Select
        Lb31.Text = AlbEntrada_lineas.AEL_idgenero.Valor
        If Generos.LeerId(Lb31.Text) = True Then
            Lb32.Text = Generos.GEN_NombreGenero.Valor
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

        If VaInt(AlbEntrada_lineas.AEL_IdValoracion.Valor) > 0 Then
            Dim valoracionsemanal As New E_ValoracionSemanal(Idusuario, cn)
            If valoracionsemanal.LeerId(AlbEntrada_lineas.AEL_IdValoracion.Valor) = True Then
                LbNuvalora.Text = valoracionsemanal.VSC_Valoracion.Valor
            End If

        End If

        PintaPuntoVenta(AlbEntrada.AEN_IdPuntoVenta.Valor)
        ' llenar el grid

        CargaLineasGrid()
        difekilos()
    End Sub



    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean


        'asociar cabecera con lineas
        Dim r As Boolean
        AlbEntrada_lineascla.ALC_idlineaentrada.Valor = LbId.Text
        AlbEntrada_lineas.AEL_IdValoracion.Valor = "0"

        
        SqlGrid()
        r = MyBase.GuardarLineas(Gr)
        difekilos()


        Return r
    End Function


    Public Overrides Sub DespuesdeGuardarLinea(ByVal gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)

    End Sub


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()

        Dim PMC As Decimal = ObtenerPrecioMedioLineas(LbId.Text)
        AlbEntrada_lineas.AEL_precio.Valor = PMC
        Dim Albentrada_hislineas As New E_AlbEntrada_hislineas(Idusuario, cn)


        Dim consulta2 As New Cdatos.E_select
        ' actualizo el precio de los historicos
        consulta2.SelCampo(Albentrada_hislineas.AHL_id, "IdLineaHis")
        consulta2.SelCampo(AlbEntrada_lineascla.ALC_precio, "Precio", Albentrada_hislineas.AHL_idlineacla)
        consulta2.WheCampo(AlbEntrada_lineascla.ALC_idlineaentrada, "=", LbId.Text)

        Dim sql As String = consulta2.SQL
        Dim dt As DataTable = Albentrada_hislineas.MiConexion.ConsultaSQL(sql)

        If Not dt Is Nothing Then
            For Each rw In dt.Rows

                If Albentrada_hislineas.LeerId(rw("IdLineaHis").ToString) Then

                    Dim Kilos As Double = VaDec(Albentrada_hislineas.AHL_kilos.Valor)
                    Dim Bultos As Double = VaDec(Albentrada_hislineas.AHL_bultos.Valor)
                    Dim Piezas As Double = VaDec(Albentrada_hislineas.AHL_piezas.Valor)
                    Dim Importe As Double = 0
                    Dim precio As Double = VaDec(rw("precio"))
                    Select Case TxTipoPrecio.Text
                        Case "K"
                            Importe = Kilos * precio
                        Case "B"
                            Importe = Bultos * precio
                        Case "P"
                            Importe = Piezas * precio

                    End Select

                    Albentrada_hislineas.AHL_precio.Valor = rw("Precio").ToString
                    Albentrada_hislineas.AHL_tipoprecio.Valor = TxTipoPrecio.Text
                    Albentrada_hislineas.AHL_importegenero.Valor = Importe.ToString
                    Albentrada_hislineas.Actualizar()

                End If
            Next
        End If


        Agro_ValoraAlbaranHis(AlbEntrada_lineas.AEL_idalbaran.Valor)

    End Sub




    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)

        LbImporte.Text = ""

        LbKilos.Text = ""
        LbCategoria.Text = ""
        LbNomCategoria.Text = ""


        If gr.Nlinea = -2 Then
            gr.LineaBloqueada = True
        Else
            gr.LineaBloqueada = False
        End If

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


        LbCampa.Text = MiMaletin.Ejercicio.ToString
        PintaPuntoVenta(MiMaletin.IdPuntoVenta.ToString)
        PintaNbascula(Val(FnRight(Me.Text, 1)))
        LbFechaMuestreo.Text = ""
        LbNuvalora.Text = ""

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


        'Actualizar el precio de la línea de entrada
        Dim PMC As Decimal = ObtenerPrecioMedioLineas(LbId.Text)
        LbPrecioCompra.Text = PMC.ToString("#,##0.0000")


    End Sub


    Private Function ObtenerPrecioMedioLineas(IdLinea As String) As Decimal

        Dim res As Decimal = 0

        If VaInt(IdLinea) > 0 Then

            Dim sql As String = "SELECT SUM(Cantidad) as Cantidad, SUM(Cantidad * Precio) as Importe" & vbCrLf
            sql = sql & " FROM(" & vbCrLf
            sql = sql & " SELECT CASE AEL_TipoPrecio WHEN 'B' THEN COALESCE(ALC_Bultos,0) WHEN 'P' THEN COALESCE(ALC_Piezas,0) ELSE COALESCE(ALC_KilosNetos,0) END as Cantidad," & vbCrLf
            sql = sql & " COALESCE(ALC_Precio,0) as Precio" & vbCrLf
            sql = sql & " FROM AlbEntrada_lineascla" & vbCrLf
            sql = sql & " LEFT JOIN AlbEntrada_Lineas ON AEL_IdLinea = ALC_idlineaentrada " & vbCrLf
            sql = sql & " WHERE AEL_IdLinea = " & IdLinea & vbCrLf
            sql = sql & " ) as A" & vbCrLf


            Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim Cantidad As Decimal = VaDec(dt.Rows(0)("Cantidad"))
                    Dim Importe As Decimal = VaDec(dt.Rows(0)("Importe"))
                    If Cantidad <> 0 Then res = Importe / Cantidad

                End If
            End If


        End If


        Return res

    End Function


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
        Select Case TxTipoPrecio.Text
            Case "B"
                CONSULTA.SelCampo(AlbEntrada_lineascla.ALC_bultos, "Cantidad")
            Case "P"
                CONSULTA.SelCampo(AlbEntrada_lineascla.ALC_piezas, "Cantidad")
            Case Else
                CONSULTA.SelCampo(AlbEntrada_lineascla.ALC_kilosnetos, "Cantidad")
        End Select
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
                Dim importe As Double = 0
            

                importe = VaDec(row("Cantidad")) * VaDec(row("Precio"))

                ClGrid1.GridView.SetRowCellValue(indice, ClGrid1.GridView.Columns("Importe"), Format(importe, "#0.00"))
            End If
        Next


        If gr Is ClGrid1 Then CalculaPorcentaje()


    End Sub



    Public Overrides Sub Anular()


        If VaInt(LbId.Text) > 0 Then

            If XtraMessageBox.Show("¿Desea anular la valoración?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim Albentrada_hislineas As New E_AlbEntrada_hislineas(Idusuario, cn)
                Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
                Dim AlbEntrada_LineasCla As New E_AlbEntrada_lineascla(Idusuario, cn)

                If AlbEntrada_Lineas.LeerId(LbId.Text) Then

                    AlbEntrada_Lineas.AEL_FechaValoracion.Valor = VaDate("").ToString("dd/MM/yyyy")
                    AlbEntrada_Lineas.AEL_IdValoracion.Valor = "0"
                    AlbEntrada_Lineas.Actualizar()


                    Dim consulta As New Cdatos.E_select
                    consulta.SelCampo(AlbEntrada_lineascla.ALC_id, "Id")
                    consulta.WheCampo(AlbEntrada_lineascla.ALC_idlineaentrada, "=", LbId.Text)

                    Dim sql As String = consulta.SQL
                    Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
                    If Not IsNothing(dt) Then
                        For Each row As DataRow In dt.Rows
                            If AlbEntrada_LineasCla.LeerId(row("Id").ToString) Then
                                AlbEntrada_LineasCla.ALC_precio.Valor = "0"
                                AlbEntrada_LineasCla.Actualizar()
                            End If
                        Next
                    End If



                    Dim consulta2 As New Cdatos.E_select
                    ' actualizo el precio de los historicos
                    consulta2.SelCampo(Albentrada_hislineas.AHL_id, "IdLineaHis")
                    consulta2.SelCampo(AlbEntrada_lineascla.ALC_precio, "Precio", Albentrada_hislineas.AHL_idlineacla)
                    consulta2.WheCampo(AlbEntrada_lineascla.ALC_idlineaentrada, "=", LbId.Text)

                    sql = consulta2.SQL
                    dt = Albentrada_hislineas.MiConexion.ConsultaSQL(sql)

                    If Not dt Is Nothing Then
                        For Each rw In dt.Rows

                            If Albentrada_hislineas.LeerId(rw("IdLineaHis").ToString) Then
                                Albentrada_hislineas.AHL_precio.Valor = "0"
                                Albentrada_hislineas.AHL_tipoprecio.Valor = "K"
                                Albentrada_hislineas.AHL_importegenero.Valor = "0"
                                Albentrada_hislineas.Actualizar()
                            End If
                        Next
                    End If

                    Agro_ValoraAlbaranHis(AlbEntrada_Lineas.AEL_idalbaran.Valor)

                End If


            End If

        End If

    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)


        Dim f As String = AlbEntrada_his.AlbaranFacturado(AlbEntrada_lineas.AEL_idalbaran.Valor)
        If f <> "" Then
            MsgBox("Albaranes: " + f + " facturados ")
            Exit Sub
        End If

        'f = AlbEntrada_His.GastosFacturados(AlbEntrada_lineas.AEL_idalbaran.Valor)
        'If f <> "" Then
        '    MsgBox("Gastos " + f + " facturados")
        '    Exit Sub

        'End If



        If Validarlapartida(LbId.Text) = False Then
            Exit Sub
        End If



        MyBase.BAnular_Click(sender, e)
    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)



        Dim f As String = AlbEntrada_His.AlbaranFacturado(AlbEntrada_lineas.AEL_idalbaran.Valor)
        If f <> "" Then
            MsgBox("Albaranes: " + f + " facturados ")
            Exit Sub
        End If

        'f = AlbEntrada_His.GastosFacturados(AlbEntrada_lineas.AEL_idalbaran.Valor)
        'If f <> "" Then
        '    MsgBox("Gastos " + f + " facturados")
        '    Exit Sub

        'End If





        If Validarlapartida(LbId.Text) = False Then
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
    End Sub



    Public Overrides Sub Guardar()

      

        MyBase.Guardar()

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


    Private Sub TxPrecio_Valida(ByVal edicion As Boolean) Handles TxPrecio.Valida

        If edicion = True Then
            If TxPrecio.Text = "" Then
                TxPrecio.Text = LbPrecioCompra.Text
            End If

            Calculoimporte()

        End If

    End Sub

    Private Sub Calculoimporte()
        Dim i As Double = VaDec(TxPrecio.Text) * VaDec(LbKilos.Text)
        LbImporte.Text = Format(i, "#,###0.00")
    End Sub

    Private Sub TxDato2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxDato2_Valida(ByVal edicion As Boolean)
        If edicion = True Then
            If TxPrecio.Text = "" Then
                TxPrecio.Text = LbPrecioCompra.Text
            End If

            Calculoimporte()

        End If

    End Sub


    
    Private Sub TxDato1_Valida(edicion As System.Boolean) Handles TxDato1.Valida


    

      
    End Sub

    Private Function Validarlapartida(Idlinea As Integer) As Boolean

        If Idlinea > 0 Then
            If AlbEntrada_lineas.LeerId(Idlinea) Then
                If VaDate(AlbEntrada_lineas.AEL_fechamuestreo.Valor) = VaDate("") Then
                    MsgBox("PARTIDA NO MUESTREADA")
                    Return False

                End If


                If VaDec(AlbEntrada_lineas.AEL_idalbaran.Valor) > 0 Then
                    If AlbEntrada.LeerId(AlbEntrada_lineas.AEL_idalbaran.Valor) = True Then
                        If AlbEntrada.AEN_TipoFCS.Valor <> "S" Then
                            MsgBox("SOLO ALBARANES TIPO S ")
                            Return False
                        End If
                    End If
                    'Dim f As String = AlbEntrada_His.AlbaranFacturado(AlbEntrada_lineas.AEL_idalbaran.Valor)
                    'If f <> "" Then
                    '    MsgBox("Albaranes: " + f + " facturados ")
                    '    Return False
                    'End If
                End If


                If VaDec(AlbEntrada_lineas.AEL_IdValoracion.Valor) > 0 Then
                    Dim ValoracionSemanal As New E_ValoracionSemanal(Idusuario, cn)
                    If ValoracionSemanal.LeerId(AlbEntrada_lineas.AEL_IdValoracion.Valor) Then
                        MsgBox("La partida ya está valorada en la valoración " & ValoracionSemanal.VSC_Valoracion.Valor)
                    Else
                        MsgBox("La partida ya está valorada en la valoración con id: " & AlbEntrada_lineas.AEL_IdValoracion.Valor)
                    End If
                    If MsgBox("Desea desvincular la partida de la valoración", vbYesNo) = vbNo Then
                        Return False
                    End If

                End If

            End If
        End If

        Return True
    End Function

    Private Sub TxDato1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato1.TextChanged

    End Sub

    Private Sub TxTipoprecio_Valida(edicion As Boolean) Handles TxTipoPrecio.Valida
        If edicion = True Then
            If TxTipoprecio.Text <> "B" And TxTipoprecio.Text <> "P" Then
                TxTipoprecio.Text = "K"
            End If
            CargaLineasGrid()
        End If
        PintaTipoPrecio()
        CalculaPorcentaje()
    End Sub

    Private Sub PintaTipoPrecio()
        Select Case TxTipoprecio.Text
            Case "B"
                LbUdsPartida_1.Text = "Bultos partida"
                Lbuds_1.Text = "BULTOS"
                LbUdsPartida.Text = VaDec(AlbEntrada_lineas.AEL_bultos.Valor).ToString("#,###")
            Case "P"
                LbUdsPartida_1.Text = "Piezas partida"
                Lbuds_1.Text = "PIEZAS"
                LbUdsPartida.Text = VaDec(AlbEntrada_lineas.AEL_piezas.Valor).ToString("#,###")
            Case Else
                LbUdsPartida_1.Text = "Kilos partida"
                Lbuds_1.Text = "KILOS"
                LbUdsPartida.Text = VaDec(AlbEntrada_lineas.AEL_kilosnetos.Valor).ToString("#,###")

        End Select
    End Sub

    Private Sub TxTipoPrecio_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxTipoPrecio.TextChanged

    End Sub
End Class