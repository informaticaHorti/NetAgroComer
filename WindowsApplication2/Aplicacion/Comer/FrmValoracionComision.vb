Imports DevExpress.XtraEditors


Public Class FrmValoracionComision
    Inherits FrMantenimiento


 

    'Class stClave_Valoracion

    '    Public IdGenero As Integer = 0
    '    Public IdCategoria As Integer = 0

    '    Public Sub New(IdGenero As Integer, IdCategoria As Integer)

    '        Me.IdGenero = IdGenero
    '        Me.IdCategoria = IdCategoria

    '    End Sub

    'End Class


    'Class stDatos_Valoracion

    '    Public Precio As Decimal = 0

    '    Public Sub New(Precio As Decimal)

    '        Me.Precio = Precio

    '    End Sub

    'End Class


    Dim Partes As New E_Partes(Idusuario, cn)
    Dim Partes_Compras As New E_partes_Compras(Idusuario, cn)
    Dim Partes_Familias As New E_Partes_familias(Idusuario, cn)

    Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim AlbEntrada_LineasCla As New E_AlbEntrada_lineascla(Idusuario, cn)
    Dim AlbEntrada_HisLineas As New E_AlbEntrada_hislineas(Idusuario, cn)
    Dim Familias As New E_FamiliasGeneros(Idusuario, cn)


    Dim _IdParte As String = ""
    Dim _iDfamilia As Integer = 0



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()

    End Sub


    Public Sub New(IdParte As String)
        Me.New()

        _IdParte = IdParte
        Idinit = _IdParte

        'Dim Partes As New E_Partes(Idusuario, cn)
        'If Partes.LeerId(_IdParte) Then
        '    Idinit = _IdParte
        'Else
        '    Idinit = "+"
        'End If


        LbEjer.Text = MiMaletin.Ejercicio.ToString
        DatosInicio()

    End Sub


    Private Sub ParametrosFrm()
        EntidadFrm = Partes


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxNuParte, Partes.PDS_numero, LbNuParte, True)
        CampoClave = 0 ' ultimo campo de la clave



        ParamTx(TxPrecioLiquidacion, Partes_Compras.PDL_PrecioLiquid, LbPrecioLiquidacion, False)

        AsociarGrid(ClGrid1, TxPrecioLiquidacion, TxPrecioLiquidacion, Partes_Compras)


        PropiedadesCamposGr(ClGrid1, "PDL_idlinea", "PDL_idlinea", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "IdGenero", "Cod", True, 10)
        PropiedadesCamposGr(ClGrid1, "Genero", "Producto", True, 60)
        PropiedadesCamposGr(ClGrid1, "Categoria", "Categoria", True, 30)
        PropiedadesCamposGr(ClGrid1, "Kilos", "Kilos", True, 20, True, "#,##")
        PropiedadesCamposGr(ClGrid1, "Disponible", "Disponible", True, 30, True, "#,##0.00")
        PropiedadesCamposGr(ClGrid1, "PrAprox", "PrAprox", True, 20, False, "#,##0.0000")
        PropiedadesCamposGr(ClGrid1, "PrLiqui", "PrLiqui", True, 20, False, "#,##0.0000")
        PropiedadesCamposGr(ClGrid1, "ImpLiqui", "ImpLiqui", True, 30, True, "#,##0.00", "{0:n2}")
        PropiedadesCamposGr(ClGrid1, "Diferencia", "Diferencia", True, 30, True, "#,##0.00", "{0:n2}")

        GridView.OptionsView.ShowGroupPanel = False
        GridView.OptionsBehavior.Editable = False
        GridView.OptionsView.ColumnAutoWidth = True
    End Sub



    Private Sub DatosInicio()
        If VaInt(_IdParte) > 0 Then

            InicioFrm()

            BAnular.Visible = False

            Dim Partes As New E_Partes(Idusuario, cn)
            If Partes.LeerId(_IdParte) Then
                CargaFamilias(_IdParte)

                LbDesdeEnt.Text = Partes.PDS_defecha.Valor
                LbHastaEnt.Text = Partes.PDS_afecha.Valor
                LbDesdeSal.Text = Partes.PDS_defechasal.Valor
                LbHastaSal.Text = Partes.PDS_afechasal.Valor
                TxNuParte.Text = Partes.PDS_numero.Valor
                LbId.Text = _IdParte
                CargaLineasGrid()
                PintaBoton(Partes.PDS_valorada.Valor)
            Else
                MsgBox("Error al leer el número de parte")
            End If



        Else

            MsgBox("Error al leer el número de parte")
            Me.Close()

        End If
    End Sub
    Private Sub PintaBoton(Valorada As String)
        btPrecios.Visible = False
        BtAnula.Visible = False
        If Valorada = "S" Then
            btPrecios.Visible = False
            BtAnula.Visible = True
        Else
            btPrecios.Visible = True
            BtAnula.Visible = False
        End If


    End Sub
    Private Sub FrmValoracionSegunClasificacion_Load(sender As Object, e As System.EventArgs) Handles Me.Load





    End Sub

    Private Sub CargaFamilias(idparte As String)
        Dim r As Long = GridView.FocusedRowHandle
        Dim sql As String
        sql = "select distinct PDL_idfamilia as id,FAG_nombre as Familia,SUM(PDL_KILOSC) AS Kilos,SUM(PDL_KILOSC*PDL_PRECIOLIQUID) AS ImpLiqui,sum(PDL_DISPONIBLE-(PDL_KILOSC*PDL_PRECIOLIQUID)) AS Resultado from partes_compras "
        sql = sql + " left join familiasgeneros on  fag_idfamilia=pdl_idfamilia  "
        sql = sql + " where PDL_idparte = " + idparte
        sql = sql + " group by pdl_idfamilia,FAG_nombre"

        Dim dt As DataTable = Partes.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt
        GridView.FocusedRowHandle = r
        AjustaColumnas()
        If Not dt Is Nothing Then
            If _iDfamilia = 0 Then
                If dt.Rows.Count > 0 Then
                    _iDfamilia = VaInt(dt.Rows(0)("ID"))
                End If
            End If
        End If
    End Sub
    Private Sub TxNuParte_Valida(edicion As System.Boolean) Handles TxNuParte.Valida


        Dim Partes As New E_Partes(Idusuario, cn)
        If Partes.LeerParte(VaInt(LbEjer.Text), VaInt(TxNuParte.Text)) > 0 Then

            'Actualizamos fechas
          

        End If

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbEjer.Text = MiMaletin.Ejercicio.ToString

        LbKilosGen.Text = ""
        LbMediaGen.Text = ""
        LbDiferenciaGen.Text = ""


    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave


        Dim i As Integer = Partes.LeerParte(VaInt(LbEjer.Text), VaInt(TxNuParte.Text))

        If i > 0 Then
            Partes.LeerId(i.ToString)
            LbId.Text = i.ToString
        Else
            MsgBox("No existe el parte")
            TxNuParte.MiError = True
            Exit Sub
        End If


        If LbId.Text <> "" Then
            CargaLineasGrid()
        End If


    End Sub


    Private Sub CargaLineasGrid()


        SqlGrid()

        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)


        CalculaTotales()


    End Sub


    Private Sub SqlGrid()

        Dim id As String = LbId.Text

        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 




        Dim sql As String = ConsultaSQL_Valoracion()

        ClGrid1.Consulta = sql


    End Sub



    Private Sub CalculaTotales()

        If _IdParte > 0 Then
            CargaFamilias(_IdParte)
        End If
    End Sub

   

    Private Function ConsultaSQL_Valoracion() As String

        Dim sql As String
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Partes_Compras.PDL_idlinea, "")
        consulta.SelCampo(Partes_Compras.PDL_idgenero, "Codigo")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Partes_Compras.PDL_idgenero)
        consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", Partes_Compras.PDL_idcategoria)
        consulta.SelCampo(Partes_Compras.PDL_kilosC, "Kilos")
        consulta.SelCampo(Partes_Compras.PDL_Disponible, "Disponible")
        consulta.SelCampo(Partes_Compras.PDL_PrecioAprox, "PrAprox")
        consulta.SelCampo(Partes_Compras.PDL_PrecioLiquid, "PrLiqui")
        Dim imp As New Cdatos.bdcampo("@PDL_KILOSC*(PDL_PRECIOLIQUID)", Cdatos.TiposCampo.Importe, 10)
        consulta.SelCampo(imp, "ImpLiqui")

        Dim dif As New Cdatos.bdcampo("@PDL_DISPONIBLE-(PDL_KILOSC*PDL_PRECIOLIQUID)", Cdatos.TiposCampo.Importe, 10)
        consulta.SelCampo(dif, "Diferencia")

        consulta.WheCampo(Partes_Compras.PDL_idparte, "=", _IdParte)
        If _iDfamilia > 0 Then
            consulta.WheCampo(Partes_Compras.PDL_idfamilia, "=", _iDfamilia.ToString)
        End If
        sql = consulta.SQL

        sql = sql + " order by PDL_IDGENERO"

        Return sql

    End Function


    Private Sub BloqueaBotonesGrid(bBloquear As Boolean)

        ClGrid1.BotonAnular.Enabled = bBloquear
        ClGrid1.BotonGuardar.Enabled = bBloquear
        ClGrid1.BotonNuevo.Enabled = bBloquear

    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)

        LbGenero.Text = ""
        LbNomGenero.Text = ""

        LbCategoria.Text = ""
        LbNomCategoria.Text = ""

        LbKilos.Text = ""
        LbDisponible.Text = ""
        LbPrecioAprox.Text = ""
        LbDiferencia.Text = ""



        If NuevoRegistro Then
            If gr.Nlinea = -2 Then
                gr.LineaBloqueada = True
            Else
                gr.LineaBloqueada = False
            End If
        End If

        LbKilosGen.Text = ""
        LbMediaGen.Text = ""
        LbDiferenciaGen.Text = ""


    End Sub

    Private Sub AjustaColumnas()
        GridView.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView.Columns
            Select Case c.FieldName.ToUpper.Trim
              
                Case "RESULTADO", "IMPLIQUI"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 65

                Case "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,###"
                    c.Width = 50

                Case "ID"
                    c.Width = 50
                Case "FAMILIA"
                    c.Width = 200
            End Select
        Next

        Funciones.AñadeResumenCampo(GridView, "Kilos", "{0:n0}")
        Funciones.AñadeResumenCampo(GridView, "ImpLiqui", "{0:n2}")
        Funciones.AñadeResumenCampo(GridView, "Resultado", "{0:n2}")
    End Sub
    Public Overrides Sub Modificar()
        MyBase.Modificar()

        BloqueaBotonesGrid(False)

        TxNuParte.Enabled = False
        LbDesdeEnt.Enabled = False
        LbHastaEnt.Enabled = False


    End Sub


    Public Overrides Sub Guardar()


        'TODO: IdParte en AEL


        If VaInt(LbId.Text) > 0 Then

            'Actualizar IdValoracion del parte
            If VaInt(_IdParte) > 0 Then
                Dim Parte As New E_Partes(Idusuario, cn)
                If Parte.LeerId(_IdParte) Then
                    Parte.PDS_IdValoracion.Valor = " 1"
                    Parte.Actualizar()
                End If
            End If

            'Genera valoraciones
            'TODO: Botón para volver a valorar

        End If

        HamodificadoGrid = False
        'MyBase.Guardar()
        Me.Close()

    End Sub


    Public Overrides Sub Anular()

     
        MyBase.Anular()

    End Sub


    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)


        'Genero
        LbGenero.Text = Partes_Compras.PDL_idgenero.Valor
        Dim Generos As New E_Generos(Idusuario, cn)
        If VaInt(LbGenero.Text) > 0 Then
            If Generos.LeerId(LbGenero.Text) Then
                LbNomGenero.Text = Generos.GEN_NombreGenero.Valor
            End If
        End If


        'Categoría
        LbCategoria.Text = Partes_Compras.PDL_idcategoria.Valor

        Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)
        If VaInt(LbCategoria.Text) > 0 Then
            If CategoriasEntrada.LeerId(LbCategoria.Text) Then
                LbNomCategoria.Text = CategoriasEntrada.CAE_CategoriaCalibre.Valor
            End If
        End If


        'Kilos
        Dim Kilos As Decimal = VaDec(Partes_Compras.PDL_kilosC.Valor)
        LbKilos.Text = Kilos.ToString("#,##0")



        'Disponible
        Dim Disponible As Decimal = VaDec(Partes_Compras.PDL_Disponible.Valor)
        LbDisponible.Text = Disponible.ToString("#,##0.00")

        'Precio Aprox
        LbPrecioAprox.Text = VaDec(Partes_Compras.PDL_PrecioAprox.Valor).ToString("#,##0.0000")

        Dim Liquido As Decimal = (Kilos * VaDec(Partes_Compras.PDL_PrecioLiquid.Valor))

        'Diferencia
        Dim Diferencia As Decimal = Kilos * (VaDec(Partes_Compras.PDL_PrecioAprox.Valor) - VaDec(Partes_Compras.PDL_PrecioLiquid.Valor))
        LbDiferencia.Text = Diferencia.ToString("#,##0.00")


        If VaInt(LbKilos.Text) = 0 Then
            LbKilos.BackColor = Color.Red
            Grid.LineaBloqueada = True

        Else
            LbKilos.BackColor = Color.GreenYellow
            Grid.LineaBloqueada = False

        End If


        Dim KilosGen As Decimal = 0
        Dim MediaGen As Decimal = 0
        Dim DifGen As Decimal = 0

        Dim IdGenero As String = (Partes_Compras.PDL_idgenero.Valor & "").Trim

        CapturaValoresGenero(IdGenero, _IdParte, KilosGen, MediaGen, DifGen)


        LbKilosGen.Text = KilosGen.ToString("#,##0")
        LbMediaGen.Text = MediaGen.ToString("#,##0.00")
        LbDiferenciaGen.Text = DifGen.ToString("#,##0.00")
    

    End Sub


    Private Sub CapturaValoresGenero(IdGenero As String, IdParte As String, ByRef KilosGen As Decimal, ByRef MediaGen As Decimal, ByRef DifGen As Decimal)

        KilosGen = 0
        MediaGen = 0
        DifGen = 0


        Dim sql As String = "SELECT DISTINCT PDL_IdGenero as Id, GEN_NombreGenero as Genero, SUM(PDL_KilosC) AS Kilos, " & vbCrLf
        sql = sql & " SUM(PDL_KilosC * PDL_PrecioLiquid) AS ImpLiqui, SUM(PDL_Disponible - (PDL_KilosC * PDL_PrecioLiquid)) AS Resultado " & vbCrLf
        sql = sql & " FROM Partes_Compras" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = PDL_IdGenero" & vbCrLf
        sql = sql & " WHERE PDL_IdParte = " & _IdParte & " AND PDL_IdGenero = " & IdGenero & vbCrLf
        sql = sql & " GROUP BY PDL_IdGenero, GEN_NombreGenero" & vbCrLf

        Dim dt As DataTable = Partes.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim row As DataRow = dt.Rows(0)

                KilosGen = VaDec(row("Kilos"))

                Dim Importe As Decimal = VaDec(row("ImpLiqui"))
                If KilosGen <> 0 Then MediaGen = Importe / KilosGen

                DifGen = VaDec(row("Resultado"))


            End If
        End If




    End Sub


    Private Sub TxPrecio_Valida(edicion As System.Boolean) Handles TxPrecioLiquidacion.Valida

        Dim Importe As Decimal = VaDec(LbKilos.Text) * (VaDec(LbPrecioAprox.Text) - VaDec(TxPrecioLiquidacion.Text))
        LbDiferencia.Text = Importe.ToString("#,##0.00")

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean

        Dim x As Integer
        Dim grabar As Boolean = True
        For x = 0 To ListaControles.Count - 1
            If ListaControles(x).orden >= Gr.PrimerControl And ListaControles(x).orden <= Gr.UltimoControl Then
                If ListaControles(x).GRIDLIN Is Gr Then
                    ListaControles(x).validar(False)
                End If
            End If
        Next
        For x = 0 To ListaControles.Count - 1
            If ListaControles(x).orden >= Gr.PrimerControl And ListaControles(x).orden <= Gr.UltimoControl Then
                If ListaControles(x).GRIDLIN Is Gr Then
                    If ListaControles(x).mierror = True Then
                        grabar = False
                    End If
                End If
            End If
        Next

        If grabar = True Then

            'If GuardarCabecera(Gr.PrimerControl - 1, False) = True Then


            If Gr.IdLinea Is Nothing Then
                Gr.IdLinea = ""
            End If
            If Gr.IdLinea = "" Then
                If Gr.AñadirLinea = False Then
                    Return True
                End If
                DatosLin_a_Entidad(Gr, Gr.EntidadLinea)
                Gr.IdLinea = Gr.EntidadLinea.MaxId()
                Gr.EntidadLinea.AsignarClavePrimaria(Gr.IdLinea)
                Gr.EntidadLinea.Insertar()
            Else
                DatosLin_a_Entidad(Gr, Gr.EntidadLinea)
                Gr.EntidadLinea.LoguearXFormulario("M")
                Gr.EntidadLinea.Actualizar()
            End If
            DespuesdeGuardarLinea(Gr)
            If Gr.MismaLinea = False Then
                Borralin(Gr)
                ListaControles(Gr.PrimerControl).select()
            End If
            Cargalineas(Gr)
            Return True


            'Else
            '    MsgBox("Corregir errores")
            '    Return False
            'End If

        Else
            Return False
        End If
    End Function


    Public Overrides Sub DespuesdeGuardarLinea(gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)


        CalculaTotales()

    End Sub




    Private Sub GridView_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
        Dim row As DataRow = GridView.GetFocusedDataRow
        If Not row Is Nothing Then
            _iDfamilia = VaInt(row("id"))
            If _iDfamilia <> 0 Then
                CargaLineasGrid()
            End If

        End If
    End Sub

    Private Sub TxNuParte_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxNuParte.TextChanged

    End Sub

    Private Sub btPrecios_Click(sender As System.Object, e As System.EventArgs) Handles btPrecios.Click
        If MsgBox("Desea valorar los albaranes", vbYesNo) = vbYes Then
            GenerarValoracionesParte(False)
        End If
    End Sub



    'Private Sub GenerarValoraciones_old(Anular As Boolean)


    '    Dim DcLcla As New Dictionary(Of Integer, Integer)
    '    Dim DcAlba As New Dictionary(Of Integer, Integer)

    '    Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)


    '    Dim consulta As New Cdatos.E_select
    '    consulta.SelCampo(Partes_Compras.PDL_idgenero, "idgenero")
    '    consulta.SelCampo(Partes_Compras.PDL_idcategoria, "idcategoria")
    '    consulta.SelCampo(Partes_Compras.PDL_PrecioLiquid, "precio")
    '    consulta.WheCampo(Partes_Compras.PDL_idparte, "=", _IdParte.ToString)
    '    Dim sql As String = consulta.SQL
    '    sql = sql + " order by pdl_idgenero,pdl_idcategoria"
    '    Dim dt As DataTable = Partes_Compras.MiConexion.ConsultaSQL(sql)
    '    If Not dt Is Nothing Then
    '        Barra.Maximum = dt.Rows.Count
    '        Barra.Value = 0
    '        For Each rw In dt.Rows
    '            If Barra.Value < Barra.Maximum Then
    '                Barra.Value = Barra.Value + 1
    '            End If
    '            Dim idgenero As Integer = VaInt(rw("idgenero"))
    '            Dim idcategoria As Integer = VaInt(rw("idcategoria"))
    '            Dim precio As Decimal = VaDec(rw("precio"))

    '            Dim consulta2 As New Cdatos.E_select
    '            consulta2.SelCampo(AlbEntrada_LineasCla.ALC_id, "id")
    '            consulta2.SelCampo(AlbEntrada_LineasCla.ALC_idgenero, "idgenero")
    '            consulta2.SelCampo(AlbEntrada_LineasCla.ALC_idcategoria, "idcategoria")
    '            consulta2.SelCampo(AlbEntrada_Lineas.AEL_idalbaran, "idalbaran", AlbEntrada_LineasCla.ALC_idlineaentrada)
    '            consulta2.SelCampo(AlbEntrada_Lineas.AEL_idlinea, "idpartida")

    '            consulta2.WheCampo(AlbEntrada_LineasCla.ALC_idgenero, "=", idgenero.ToString)
    '            consulta2.WheCampo(AlbEntrada_LineasCla.ALC_idcategoria, "=", idcategoria.ToString)


    '            sql = consulta2.SQL
    '            Dim dt2 As DataTable = AlbEntrada_LineasCla.MiConexion.ConsultaSQL(sql)
    '            If Not dt2 Is Nothing Then
    '                For Each rw2 In dt2.Rows
    '                    Dim idalbaran As Integer = VaInt(rw2("idalbaran"))
    '                    Dim id As Integer = VaInt(rw2("id"))
    '                    Dim idpartida As Integer = VaInt(rw2("idpartida"))
    '                    If Albentrada_his.AlbaranFacturado(idalbaran) = "" Then

    '                        If AlbEntrada_LineasCla.LeerId(id.ToString) = True Then
    '                            If Anular = False Then
    '                                AlbEntrada_LineasCla.ALC_precio.Valor = precio.ToString
    '                                ActualizaHis(id, precio)
    '                            Else
    '                                AlbEntrada_LineasCla.ALC_precio.Valor = "0"
    '                                ActualizaHis(id, 0)
    '                            End If
    '                            AlbEntrada_LineasCla.Actualizar()

    '                            If DcLcla.ContainsKey(idpartida) = False Then
    '                                DcLcla.Add(idpartida, idpartida)
    '                            End If

    '                            If DcAlba.ContainsKey(idalbaran) = False Then
    '                                DcAlba.Add(idalbaran, idalbaran)
    '                            End If


    '                        End If
    '                    End If
    '                Next
    '            End If



    '        Next

    '        Barra.Maximum = DcLcla.Count
    '        Barra.Value = 0
    '        For Each idpartida In DcLcla.Keys
    '            If Barra.Value < Barra.Maximum Then
    '                Barra.Value = Barra.Value + 1
    '            End If
    '            If AlbEntrada_Lineas.LeerId(idpartida) = True Then
    '                If Anular = False Then
    '                    AlbEntrada_Lineas.AEL_FechaValoracion.Valor = Format(Now, "dd/MM/yyyy")
    '                Else
    '                    AlbEntrada_Lineas.AEL_FechaValoracion.Valor = "01/01/1900"
    '                End If
    '                AlbEntrada_Lineas.Actualizar()
    '            End If

    '        Next


    '        Barra.Maximum = DcAlba.Count
    '        Barra.Value = 0
    '        For Each idalbaran In DcAlba.Keys
    '            If Barra.Value < Barra.Maximum Then
    '                Barra.Value = Barra.Value + 1
    '            End If

    '            Agro_ValoraAlbaranHis(idalbaran)

    '        Next

    '    End If


    '    If Partes.LeerId(_IdParte) = True Then
    '        If Anular = False Then
    '            Partes.PDS_valorada.Valor = "S"
    '        Else
    '            Partes.PDS_valorada.Valor = "N"
    '        End If
    '        PintaBoton(Partes.PDS_valorada.Valor)
    '        Partes.Actualizar()
    '    End If



    '    MsgBox("Terminado")

    'End Sub
    Private Sub GenerarValoracionesParte(Anular As Boolean)


        Dim DcLcla As New Dictionary(Of Integer, Integer)
        Dim DcAlba As New Dictionary(Of Integer, Integer)

        Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
        Dim Albentrada As New E_AlbEntrada(Idusuario, cn)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Partes_Compras.PDL_idgenero, "idgenero")
        consulta.SelCampo(Partes_Compras.PDL_idcategoria, "idcategoria")
        consulta.SelCampo(Partes_Compras.PDL_PrecioLiquid, "precio")
        consulta.WheCampo(Partes_Compras.PDL_idparte, "=", _IdParte.ToString)
        Dim sql As String = consulta.SQL
        sql = sql + " order by pdl_idgenero,pdl_idcategoria"
        Dim dt As DataTable = Partes_Compras.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            Barra.Maximum = dt.Rows.Count
            Barra.Value = 0
            For Each rw In dt.Rows
                If Barra.Value < Barra.Maximum Then
                    Barra.Value = Barra.Value + 1
                End If
                Dim idgenero As Integer = VaInt(rw("idgenero"))
                Dim idcategoria As Integer = VaInt(rw("idcategoria"))
                Dim precio As Decimal = VaDec(rw("precio"))

                Dim consulta2 As New Cdatos.E_select
                consulta2.SelCampo(AlbEntrada_LineasCla.ALC_id, "id")
                consulta2.SelCampo(AlbEntrada_LineasCla.ALC_idgenero, "idgenero")
                consulta2.SelCampo(AlbEntrada_LineasCla.ALC_idcategoria, "idcategoria")
                consulta2.SelCampo(AlbEntrada_Lineas.AEL_idalbaran, "idalbaran", AlbEntrada_LineasCla.ALC_idlineaentrada)
                consulta2.SelCampo(AlbEntrada_Lineas.AEL_idlinea, "idpartida")
                consulta2.SelCampo(Albentrada.AEN_TipoFCS, "FCS", AlbEntrada_Lineas.AEL_idalbaran)

                consulta2.WheCampo(AlbEntrada_Lineas.AEL_Idparte, "=", _IdParte.ToString)
                consulta2.WheCampo(AlbEntrada_LineasCla.ALC_idgenero, "=", idgenero.ToString)
                consulta2.WheCampo(AlbEntrada_LineasCla.ALC_idcategoria, "=", idcategoria.ToString)
                consulta2.WheCampo(Albentrada.AEN_TipoFCS, "=", "C")


                sql = consulta2.SQL
                Dim dt2 As DataTable = AlbEntrada_LineasCla.MiConexion.ConsultaSQL(sql)
                If Not dt2 Is Nothing Then
                    For Each rw2 In dt2.Rows
                        Dim idalbaran As Integer = VaInt(rw2("idalbaran"))
                        Dim id As Integer = VaInt(rw2("id"))
                        Dim idpartida As Integer = VaInt(rw2("idpartida"))
                        If Albentrada_his.AlbaranFacturado(idalbaran) = "" Then

                            If AlbEntrada_LineasCla.LeerId(id.ToString) = True Then
                                If Anular = False Then
                                    AlbEntrada_LineasCla.ALC_precio.Valor = precio.ToString
                                    ActualizaHis(id, precio)
                                Else
                                    AlbEntrada_LineasCla.ALC_precio.Valor = "0"
                                    ActualizaHis(id, 0)
                                End If
                                AlbEntrada_LineasCla.Actualizar()

                                If DcLcla.ContainsKey(idpartida) = False Then
                                    DcLcla.Add(idpartida, idpartida)
                                End If

                                If DcAlba.ContainsKey(idalbaran) = False Then
                                    DcAlba.Add(idalbaran, idalbaran)
                                End If


                            End If
                        End If
                    Next
                End If



            Next

            Barra.Maximum = DcLcla.Count
            Barra.Value = 0
            For Each idpartida In DcLcla.Keys
                If Barra.Value < Barra.Maximum Then
                    Barra.Value = Barra.Value + 1
                End If
                If AlbEntrada_Lineas.LeerId(idpartida) = True Then
                    If Anular = False Then
                        AlbEntrada_Lineas.AEL_FechaValoracion.Valor = Format(Now, "dd/MM/yyyy")
                    Else
                        AlbEntrada_Lineas.AEL_FechaValoracion.Valor = "01/01/1900"
                        AlbEntrada_Lineas.AEL_precio.Valor = "0"
                    End If
                    AlbEntrada_Lineas.Actualizar()
                End If

            Next


            Barra.Maximum = DcAlba.Count
            Barra.Value = 0
            For Each idalbaran In DcAlba.Keys
                If Barra.Value < Barra.Maximum Then
                    Barra.Value = Barra.Value + 1
                End If

                Agro_ValoraAlbaranHis(idalbaran)

            Next

        End If


        If Partes.LeerId(_IdParte) = True Then
            If Anular = False Then
                Partes.PDS_valorada.Valor = "S"
            Else
                Partes.PDS_valorada.Valor = "N"
            End If
            PintaBoton(Partes.PDS_valorada.Valor)
            Partes.Actualizar()
        End If



        MsgBox("Terminado")

    End Sub



    Private Function ObtenerHis(IdCla As String) As DataTable

        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(AlbEntrada_HisLineas.AHL_id, "IdLineaHis")
        CONSULTA.WheCampo(AlbEntrada_HisLineas.AHL_idlineacla, "=", IdCla)

        Dim sql As String = CONSULTA.SQL
        Return AlbEntrada_LineasCla.MiConexion.ConsultaSQL(sql)


    End Function


    Private Sub ActualizaHis(id As Integer, Precio As Decimal)
        Dim dtHis As DataTable = ObtenerHis(id)
        If Not IsNothing(dtHis) Then
            For Each rowHis As DataRow In dtHis.Rows

                Dim IdLineaHis As String = (rowHis("IdLineaHis").ToString & "").Trim
                If AlbEntrada_HisLineas.LeerId(IdLineaHis) Then

                    Dim Kilos As Double = VaDec(AlbEntrada_HisLineas.AHL_kilos.Valor)
                    Dim Importe As Decimal = Kilos * Precio

                    AlbEntrada_HisLineas.AHL_precio.Valor = Precio.ToString
                    AlbEntrada_HisLineas.AHL_tipoprecio.Valor = "K"
                    AlbEntrada_HisLineas.AHL_importegenero.Valor = Importe.ToString
                    AlbEntrada_HisLineas.Actualizar()

                End If

            Next
        End If

    End Sub


    
    Private Sub BtAnula_Click(sender As System.Object, e As System.EventArgs) Handles BtAnula.Click
        If MsgBox("Desea anular la valoracion de los albaranes", vbYesNo) = vbYes Then
            GenerarValoracionesParte(True)

        End If
    End Sub

    
    Private Sub LbDesdeEnt_TextChanged(sender As System.Object, e As System.EventArgs) Handles LbDesdeEnt.TextChanged
        If VaDate(LbDesdeEnt.Text) = VaDate("") Then
            Dim a As String = ""
        End If
    End Sub
End Class