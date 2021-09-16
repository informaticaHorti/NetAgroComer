Imports DevExpress.XtraEditors
Imports System.Drawing


Public Class FrmCrearPalets



    Private _IdAlbaran As String = ""

    Private Albentrada As New E_AlbEntrada(Idusuario, cn)
    Private Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    'Private Albentrada_lineasCla As New E_AlbEntrada_lineascla(Idusuario, cn)
    Private Generos As New E_Generos(Idusuario, cn)
    Private CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Private Marcas As New E_Marcas(Idusuario, cn)
    Private Confecenvase As New E_ConfecEnvase(Idusuario, cn)
    Private ConfecPalet As New E_ConfecPalet(Idusuario, cn)
    Private Palets As New E_palets(Idusuario, cn)
    Private Palets_lineas As New E_palets_lineas(Idusuario, cn)
    Private Palets_traza As New E_palets_traza(Idusuario, cn)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub


    Public Sub New(ByVal IdAlbaranEntrada As String)

        Me.New()
        Me._IdAlbaran = IdAlbaranEntrada

    End Sub


    Private Sub FrmComprobarPalets_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        BImprimir.Visible = False

        CargaGrid()

    End Sub


    Private Sub CargaGrid()

        CargaGridNuevosPalets()
        CargaGridPaletsTrazabilidad()

    End Sub


    Private Sub CargaGridNuevosPalets()
        Dim consulta As New Cdatos.E_select
        Dim sql As String = ""



        consulta.SelCampo(Albentrada_lineas.AEL_idlinea, "IdLinea")
        consulta.SelCampo(Albentrada_lineas.AEL_muestreo, "Partida")
        consulta.SelCampo(Albentrada.AEN_Fecha, "Fecha", Albentrada_lineas.AEL_idalbaran)
        consulta.SelCampo(Albentrada_lineas.AEL_idgenero, "IdGenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albentrada_lineas.AEL_idgenero)
        consulta.SelCampo(Albentrada_lineas.AEL_idtipoconfeccion, "IdTipoConfeccion")
        consulta.SelCampo(Confecenvase.CEV_Nombre, "Confeccion", Albentrada_lineas.AEL_idtipoconfeccion)
        consulta.SelCampo(Albentrada_lineas.AEL_idcategoria, "IdCategoria")
        consulta.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", Albentrada_lineas.AEL_idcategoria)
        consulta.SelCampo(Albentrada_lineas.AEL_idenvase, "IdEnvase")
        consulta.SelCampo(Albentrada_lineas.AEL_idmarca, "IdMarca")
        consulta.SelCampo(Marcas.MAR_Nombre, "Marca", Albentrada_lineas.AEL_idmarca)
        consulta.SelCampo(Albentrada_lineas.AEL_idtipopalet, "IdTipoPalet")
        consulta.SelCampo(ConfecPalet.CPA_Nombre, "Tipopalet", Albentrada_lineas.AEL_idtipopalet)
        consulta.SelCampo(ConfecPalet.CPA_Coeficiente, "Coeficiente")
        consulta.SelCampo(Albentrada_lineas.AEL_palets, "Palets")
        consulta.SelCampo(Albentrada_lineas.AEL_bultos, "Bultos")
        consulta.SelCampo(Albentrada_lineas.AEL_kilosnetos, "Kilos")
        consulta.SelCampo(Albentrada_lineas.AEL_kilosbrutos, "KilosBrutos")
        consulta.SelCampo(Albentrada_lineas.AEL_KilosxBulto, "KxB")
        consulta.SelCampo(Albentrada_lineas.AEL_PiezasxBulto, "PxB")
        consulta.SelCampo(Albentrada_lineas.AEL_idgensal, "idgensal")
        consulta.SelCampo(Albentrada.AEN_Campa, "Campa")
        'consulta.SelCampo(Albentrada.AEN_Campa, "Campa", Albentrada_lineas.AEL_idalbaran)
        consulta.SelCampo(Albentrada.AEN_IdCentro, "IdCentro")
        consulta.SelCampo(Albentrada_lineas.AEL_envasepropio, "Envasepropio")
        consulta.SelCampo(Albentrada_lineas.AEL_materialpropio, "Materialpropio")
        consulta.SelCampo(Albentrada_lineas.AEL_IdMarcaEtiqueta, "IdMarcaEti")
        consulta.SelCampo(Albentrada_lineas.AEL_IdMarcaMaterial, "IdMarcaMat")
        consulta.SelCampo(Palets_lineas.PLL_idpalet, "idpalet", Albentrada_lineas.AEL_idlinea, Palets_lineas.PLL_idlineaentradaconfeccionada)
        consulta.SelCampo(Albentrada_lineas.AEL_Controlado, "Controlado")

        consulta.WheCampo(Albentrada_lineas.AEL_idalbaran, "=", _IdAlbaran)

        sql = consulta.SQL ' " and coalesce(idpalet)=0 "
        sql = sql + " order by AEL_idlinea"


        Dim dt As DataTable = Albentrada_lineas.MiConexion.ConsultaSQL(sql)


        Dim dtpalet As New DataTable
        Dim dv As New DataView(dt)
        dv.RowFilter = "isnull(idpalet,0)=0"

        dtpalet = dv.ToTable
        Dim colSel As New DataColumn("S", GetType(Boolean))
        colSel.DefaultValue = False
        dtpalet.Columns.Add(colSel)


        GridNuevosPalets.DataSource = dtpalet
        AjustaColumnas(GridViewNuevosPalets)



    End Sub

    Private Sub CargaGridPaletsTrazabilidad()

        Dim Albentrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)


        Dim CONSULTA2 As New Cdatos.E_select
        CONSULTA2.SelCampo(Albentrada_Lineas.AEL_muestreo, "Partida")
        CONSULTA2.SelCampo(Palets_lineas.PLL_idgenero, "IdGenero", Albentrada_Lineas.AEL_idlinea, Palets_lineas.PLL_idlineaentradaconfeccionada)
        CONSULTA2.SelCampo(Palets.PAL_palet, "Palet", Palets_lineas.PLL_idpalet)
        CONSULTA2.SelCampo(Palets.PAL_idpalet, "IdPalet")
        CONSULTA2.SelCampo(Generos.GEN_NombreGenero, "Genero", Palets_lineas.PLL_idgenero)
        CONSULTA2.SelCampo(Palets_lineas.PLL_idtipoconfeccion, "IdTipoConfeccion")
        CONSULTA2.SelCampo(Confecenvase.CEV_Nombre, "Confeccion", Palets_lineas.PLL_idtipoconfeccion)
        CONSULTA2.SelCampo(Palets_lineas.PLL_idcategoria, "IdCategoria")
        CONSULTA2.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", Palets_lineas.PLL_idcategoria)
        CONSULTA2.SelCampo(Palets_lineas.PLL_idmarca, "IdMarca")
        CONSULTA2.SelCampo(Marcas.MAR_Nombre, "Marca", Palets_lineas.PLL_idmarca)
        CONSULTA2.SelCampo(Palets.PAL_idtipopalet, "IdTipoPalet")
        CONSULTA2.SelCampo(ConfecPalet.CPA_Nombre, "Tipopalet", Palets.PAL_idtipopalet)
        CONSULTA2.SelCampo(Palets_lineas.PLL_bultos, "Bultos")
        CONSULTA2.SelCampo(Palets_lineas.PLL_kilosnetos, "Kilos")
        CONSULTA2.SelCampo(Palets_lineas.PLL_costeestructura, "Estruc")
        CONSULTA2.SelCampo(Palets_lineas.PLL_costeconfeccion, "Confec")
        CONSULTA2.SelCampo(Palets_lineas.PLL_costematerial, "Material")

        CONSULTA2.WheCampo(Albentrada_Lineas.AEL_idalbaran, "=", _IdAlbaran)

        Dim sql = CONSULTA2.SQL & vbCrLf & " AND COALESCE(PLL_IdPalet,0) <> 0"

        Dim dt As DataTable = Albentrada_Lineas.MiConexion.ConsultaSQL(sql)



        GridPalets.DataSource = dt
        AjustaColumnas(GridViewpalets)


    End Sub


    Private Sub AjustaColumnas(ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView)

        gv.BestFitColumns()

        With gv.Columns

            If Not IsNothing(.ColumnByFieldName("IdGenero")) Then .ColumnByFieldName("IdGenero").Visible = False
            If Not IsNothing(.ColumnByFieldName("IdTipoConfeccion")) Then .ColumnByFieldName("IdTipoConfeccion").Visible = False
            If Not IsNothing(.ColumnByFieldName("IdCategoria")) Then .ColumnByFieldName("IdCategoria").Visible = False
            If Not IsNothing(.ColumnByFieldName("IdEnvase")) Then .ColumnByFieldName("IdEnvase").Visible = False
            If Not IsNothing(.ColumnByFieldName("IdTipoPalet")) Then .ColumnByFieldName("IdTipoPalet").Visible = False
            If Not IsNothing(.ColumnByFieldName("Campa")) Then .ColumnByFieldName("Campa").Visible = False
            If Not IsNothing(.ColumnByFieldName("IdCentro")) Then .ColumnByFieldName("IdCentro").Visible = False
            If Not IsNothing(.ColumnByFieldName("IdLineaPalet")) Then .ColumnByFieldName("IdLineaPalet").Visible = False
            If Not IsNothing(.ColumnByFieldName("IdPartida")) Then .ColumnByFieldName("IdPartida").Visible = False
            If Not IsNothing(.ColumnByFieldName("IdMarca")) Then .ColumnByFieldName("IdMarca").Visible = False
            If Not IsNothing(.ColumnByFieldName("IdLinea")) Then .ColumnByFieldName("IdLinea").Visible = False
            If Not IsNothing(.ColumnByFieldName("IdPalet")) Then .ColumnByFieldName("IdPalet").Visible = False


            If Not IsNothing(.ColumnByFieldName("KgNetos")) Then
                With .ColumnByFieldName("KgNetos")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0"
                End With
                AñadeResumenCampo(gv, "KgNetos", "{0:n0}")
            End If
            If Not IsNothing(.ColumnByFieldName("KgCliente")) Then
                With .ColumnByFieldName("KgCliente")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0"
                End With
                AñadeResumenCampo(gv, "KgCliente", "{0:n0}")
            End If

            If Not IsNothing(.ColumnByFieldName("KgVta")) Then
                With .ColumnByFieldName("KgVta")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0"
                End With
                AñadeResumenCampo(gv, "KgVta", "{0:n0}")
            End If

            If Not IsNothing(.ColumnByFieldName("Kilos")) Then
                With .ColumnByFieldName("Kilos")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "Kilos", "{0:n2}")
            End If
            If Not IsNothing(.ColumnByFieldName("Palets")) Then
                With .ColumnByFieldName("Palets")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0"
                End With
                AñadeResumenCampo(gv, "Palets", "{0:n0}")
            End If
            If Not IsNothing(.ColumnByFieldName("Bultos")) Then
                With .ColumnByFieldName("Bultos")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0"
                End With
                AñadeResumenCampo(gv, "Bultos", "{0:n0}")
            End If
            If Not IsNothing(.ColumnByFieldName("Estructura")) Then
                With .ColumnByFieldName("Estructura")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "Estructura", "{0:n2}")
            End If
            If Not IsNothing(.ColumnByFieldName("KilosBrutos")) Then
                With .ColumnByFieldName("KilosBrutos")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "KilosBrutos", "{0:n2}")
            End If
            If Not IsNothing(.ColumnByFieldName("Material")) Then
                With .ColumnByFieldName("Material")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "Material", "{0:n2}")
            End If
            If Not IsNothing(.ColumnByFieldName("Manipulacion")) Then
                With .ColumnByFieldName("Manipulacion")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "Manipulacion", "{0:n2}")
            End If
            If Not IsNothing(.ColumnByFieldName("GastoF")) Then
                With .ColumnByFieldName("GastoF")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "GastoF", "{0:n2}")
            End If
            If Not IsNothing(.ColumnByFieldName("GastoC")) Then
                With .ColumnByFieldName("GastoC")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "GastoC", "{0:n2}")
            End If

            If Not IsNothing(.ColumnByFieldName("%")) Then
                With .ColumnByFieldName("%")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "%", "{0:n2}")
            End If

            If Not IsNothing(.ColumnByFieldName("Importe")) Then
                With .ColumnByFieldName("Importe")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "Importe", "{0:n2}")
            End If
            If Not IsNothing(.ColumnByFieldName("ImporteGenero")) Then
                With .ColumnByFieldName("ImporteGenero")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                    .Caption = "ImpGenero"
                End With
                AñadeResumenCampo(gv, "ImporteGenero", "{0:n2}")
            End If
            If Not IsNothing(.ColumnByFieldName("ValorGasto")) Then
                With .ColumnByFieldName("ValorGasto")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.0000"
                End With
            End If
            If Not IsNothing(.ColumnByFieldName("Controlado")) Then
                With .ColumnByFieldName("Controlado")
                    .Caption = "Con"
                    .MinWidth = 30
                    .MaxWidth = 30
                End With
            End If


        End With


    End Sub


    Private Sub BConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BConsultar.Click
        CargaGrid()
    End Sub


    Private Sub Bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub


    Private Sub BtGenerarPalets_Click(sender As System.Object, e As System.EventArgs) Handles BtGenerarPalets.Click

        If GridViewNuevosPalets.RowCount < 1 Then
            XtraMessageBox.Show("No hay entradas directas", "ATENCIÓN")
            Exit Sub
        End If


        Dim cont As Integer = 0
        For indice As Integer = 0 To GridViewNuevosPalets.RowCount - 1
            If GridViewNuevosPalets.GetDataRow(indice)("S") = True Then
                cont = cont + 1
            End If
        Next
        If cont = 0 Then
            XtraMessageBox.Show("No hay ninguna entrada directa seleccionada", "ATENCIÓN")
            Exit Sub
        End If


        If XtraMessageBox.Show("¿Desea generar los palets?", "¿Generar palets?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            GenerarPalets()
        End If


        BtImprimirTickets.Select()
        BtImprimirTickets.Focus()

    End Sub


    Private Sub GenerarPalets()

        Dim Idpartida As String = ""

        For indice As Integer = 0 To GridViewNuevosPalets.RowCount - 1

            Dim rowNuevo As DataRow = GridViewNuevosPalets.GetDataRow(indice)
            If Not IsNothing(rowNuevo) Then

                If rowNuevo("S") = True Then

                    Dim Campa As Integer = VaInt(rowNuevo("Campa"))
                    Dim Fecha As String = ""
                    If VaDate(rowNuevo("Fecha")) > VaDate("") Then Fecha = VaDate(rowNuevo("Fecha")).ToString("dd/MM/yyyy")
                    Dim IdCentro As Integer = VaInt(rowNuevo("IdCentro"))
                    Dim IdTipoPalet As Integer = VaInt(rowNuevo("IdTipoPalet"))
                    Dim IdGenero As Integer = VaInt(rowNuevo("IdGenero"))
                    Dim IdTipoConfeccion As Integer = VaInt(rowNuevo("IdTipoConfeccion"))
                    Dim IdCategoria As Integer = VaInt(rowNuevo("IdCategoria"))
                    Dim Categoria As String = (rowNuevo("Categoria").ToString & "").Trim
                    Dim IdMarca As Integer = VaInt(rowNuevo("IdMarca"))
                    Dim IdEnvase As Integer = VaInt(rowNuevo("IdEnvase"))
                    Dim IdLineaEntrada As String = rowNuevo("IdLinea").ToString
                    Dim EnvasePropio As String = (rowNuevo("EnvasePropio").ToString & "").ToUpper.Trim
                    Dim MaterialPropio As String = (rowNuevo("MaterialPropio").ToString & "").ToUpper.Trim
                    Dim partida As String = rowNuevo("partida").ToString
                    Dim idgensal As Integer = VaInt(rowNuevo("idgensal"))
                    Dim KxB As Decimal = VaDec(rowNuevo("KxB"))
                    Dim PxB As Integer = VaInt(rowNuevo("PxB"))
                    Dim IdMarcaEti As Integer = VaInt(rowNuevo("IdMarcaEti"))
                    Dim IdMarcaMat As Integer = VaInt(rowNuevo("IdMarcaMat"))
                    Dim Controlado As String = (rowNuevo("Controlado").ToString & "").Trim.ToUpper
                    Dim Coeficiente As Decimal = VaDec(rowNuevo("Coeficiente"))


                    Dim TotalBultos As Decimal = 0
                    Dim TotalKilos As Decimal = 0
                    Dim TotalKilosBrutos As Decimal = 0

                    Dim bultos_palet As Decimal = 0
                    Dim kilos_palet As Decimal = 0
                    Dim kilosbrutos_palet As Decimal = 0



                    'Datos de las líneas del palet
                    Dim nPalets As Integer = VaInt(rowNuevo("Palets"))
                    If nPalets <> 0 Then bultos_palet = Math.Round(VaDec(rowNuevo("Bultos")) / nPalets, 0)
                    If nPalets <> 0 Then kilos_palet = Math.Round(VaDec(rowNuevo("Kilos")) / nPalets, 0)
                    If nPalets <> 0 Then kilosbrutos_palet = Math.Round(VaDec(rowNuevo("KilosBrutos")) / nPalets, 0)



                    For indicePalet As Integer = 1 To nPalets

                        'Crea Palet
                        Dim Palet As New E_palets(Idusuario, cn)
                        Dim IdPalet As String = Palet.MaxId()

                        Palet.PAL_idpalet.Valor = IdPalet
                        Palet.PAL_campa.Valor = Campa
                        Palet.PAL_idcentro.Valor = IdCentro
                        Palet.PAL_palet.Valor = Palet.MaxIdCampa(Campa, IdCentro)
                        'Palet.PAL_fecha.Valor = Today.ToString("dd/MM/yyyy")
                        Palet.PAL_fecha.Valor = Fecha
                        Palet.PAL_idpuntoventa.Valor = MiMaletin.IdPuntoVenta
                        Palet.PAL_idtipopalet.Valor = IdTipoPalet
                        Palet.PAL_tarapalet.Valor = 0
                        Palet.PAL_idpvsituacion.Valor = MiMaletin.IdPuntoVenta
                        Palet.PAL_envasepropio.Valor = EnvasePropio
                        Palet.PAL_materialpropio.Valor = MaterialPropio
                        Palet.PAL_finalizado.Valor = "S"
                        Palet.PAL_PaletsTransporte.Valor = VaInt(Coeficiente).ToString
                        Palet.Insertar()



                        'Crea Palet_Linea
                        Dim Palet_Linea As New E_palets_lineas(Idusuario, cn)
                        Dim IdLineaPalet As String = Palet_Linea.MaxId()
                        Palet_Linea.PLL_idlinea.Valor = IdLineaPalet
                        Palet_Linea.PLL_idpalet.Valor = IdPalet


                        Palet_Linea.PLL_idgenero.Valor = IdGenero
                        Palet_Linea.PLL_idtipoconfeccion.Valor = IdTipoConfeccion
                        Palet_Linea.PLL_idenvase.Valor = IdEnvase
                        Palet_Linea.PLL_idcategoria.Valor = IdCategoria
                        Palet_Linea.PLL_categoria.Valor = Categoria
                        Palet_Linea.PLL_idmarca.Valor = IdMarca


                        'Para todos, menos para el último los datos se dividen entre el número de palets
                        'Para el último, le ponemos los restantes
                        If indicePalet <> nPalets Then
                            TotalBultos = TotalBultos + bultos_palet
                            TotalKilos = TotalKilos + kilos_palet
                            TotalKilosBrutos = TotalKilosBrutos + kilosbrutos_palet
                        Else
                            'El resto para que cuadren
                            bultos_palet = VaDec(rowNuevo("Bultos")) - TotalBultos
                            kilos_palet = VaDec(rowNuevo("Kilos")) - TotalKilos
                            kilosbrutos_palet = VaDec(rowNuevo("KilosBrutos")) - TotalKilosBrutos
                        End If

                        Palet_Linea.PLL_bultos.Valor = bultos_palet
                        Palet_Linea.PLL_kilosnetos.Valor = kilos_palet
                        Palet_Linea.PLL_kiloscliente.Valor = kilos_palet
                        Palet_Linea.PLL_kilosbrutos.Valor = kilosbrutos_palet


                        'TODO: PxB, KxB, MarcaEti, MarcaMat
                        Palet_Linea.PLL_kilosxbulto.Valor = KxB.ToString
                        Palet_Linea.PLL_piezasxbulto.Valor = PxB.ToString
                        Palet_Linea.PLL_idmarcaeti.Valor = IdMarcaEti.ToString
                        Palet_Linea.PLL_idmarcamat.Valor = IdMarcaMat.ToString
                        'Palet_Linea.PLL_piezasxbulto.Valor = ""
                        'Palet_Linea.PLL_kilosxbulto.Valor = 0



                        Palet_Linea.PLL_costeconfeccion.Valor = 0       'Se actualizan al crear el palet
                        Palet_Linea.PLL_costeestructura.Valor = 0       'Se actualizan al crear el palet
                        Palet_Linea.PLL_idsituacion.Valor = MiMaletin.IdPuntoVenta
                        Palet_Linea.PLL_costematerial.Valor = 0         'Se actualizan al crear el palet
                        Palet_Linea.PLL_idlineaentradaconfeccionada.Valor = IdLineaEntrada
                        Palet_Linea.PLL_idgensal.Valor = idgensal.ToString
                        Palet_Linea.PLL_Controlado.Valor = Controlado
                        'Palet_Linea.Insertar()


                        'Crea Palet_traza
                        Dim Palet_Traza As New E_palets_traza(Idusuario, cn)
                        Palet_Traza.PLT_idtraza.Valor = Palet_Traza.MaxId()
                        Palet_Traza.PLT_idlineapalet.Valor = IdLineaPalet
                        Palet_Traza.PLT_IdLineaEntrada.Valor = IdLineaEntrada
                        Palet_Traza.PLT_bultos.Valor = bultos_palet
                        Palet_Traza.PLT_kilos.Valor = kilos_palet
                        Palet_Traza.PLT_idprogramacliente.Valor = "0"
                        Palet_Traza.Insertar()

                        'TODO: Comprobar con Miguel
                        Palet_Linea.Insertar()

                        Palet.Actualizar()

                    Next

                End If

            End If
        Next


        'Muestra resultados
        If GridViewNuevosPalets.RowCount > 0 Then MsgBox("Palets generados")

        CargaGrid()


    End Sub


    Private Sub GridViewNuevosPalets_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridViewNuevosPalets.RowCellClick

        If e.Column.FieldName.ToUpper.Trim = "S" Then

            Dim row As DataRow = GridViewNuevosPalets.GetFocusedDataRow()
            If Not IsNothing(row) Then

                If row("S") = True Then
                    row("S") = False
                Else
                    If ComprobarDatosOrigen(row) Then
                        row("S") = True
                    Else
                        MsgBox("Faltan datos necesarios para generar el albarán. IdLinea: " & row("IdLinea").ToString & ", Partida: " & row("Partida").ToString)
                    End If
                End If

            End If

        End If

    End Sub


    Private Function ComprobarDatosOrigen(rowNuevo As DataRow) As Boolean

        Dim bRes As Boolean = True

        Dim Campa As Integer = VaInt(rowNuevo("Campa"))
        Dim IdCentro As Integer = VaInt(rowNuevo("IdCentro"))
        Dim IdTipoPalet As Integer = VaInt(rowNuevo("IdTipoPalet"))
        Dim IdGenero As Integer = VaInt(rowNuevo("IdGenero"))
        Dim IdTipoConfeccion As Integer = VaInt(rowNuevo("IdTipoConfeccion"))
        Dim IdCategoria As Integer = VaInt(rowNuevo("IdCategoria"))
        Dim IdMarca As Integer = VaInt(rowNuevo("IdMarca"))
        Dim IdEnvase As Integer = VaInt(rowNuevo("IdEnvase"))
        Dim IdLineaEntrada As String = rowNuevo("IdLInea").ToString


        If Campa <= 0 Then bRes = False
        If IdCentro <= 0 Then bRes = False
        If IdTipoPalet <= 0 Then bRes = False 'TODO: ??
        If IdGenero <= 0 Then bRes = False
        If IdTipoConfeccion <= 0 Then bRes = False 'TODO: ??
        If IdCategoria <= 0 Then bRes = False
        If IdMarca <= 0 Then bRes = False 'TODO: ??
        If IdEnvase <= 0 Then bRes = False
        If VaInt(IdLineaEntrada) <= 0 Then bRes = False


        Return bRes

    End Function


    Private Sub BtImprimirTickets_Click(sender As System.Object, e As System.EventArgs) Handles BtImprimirTickets.Click

        If GridViewpalets.RowCount > 0 Then

            If XtraMessageBox.Show("¿Desea imprimir todos los tickets de palets?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                'Dim prn As New Printing.PrinterSettings
                'Dim impresora As String = prn.PrinterName

                'Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)
                'If ValoresUsuario.LeerId(Idusuario) Then
                '    Dim impresora_palets As String = (ValoresUsuario.VUS_ImpresoraPalets.Valor & "").Trim
                '    If impresora_palets <> "" Then impresora = impresora_palets
                'End If


                'For indice As Integer = 0 To GridViewpalets.RowCount - 1
                '    Dim row As DataRow = GridViewpalets.GetDataRow(indice)
                '    If Not IsNothing(row) Then
                '        Dim IdPalet As String = (row("IdPalet").ToString & "").Trim
                '        If VaInt(IdPalet) > 0 Then
                '            ImprimirTicketPalet(IdPalet, TipoImpresion.ImpresoraSeleccionada, False, impresora, "", "")
                '            ' VB6_ImprimirTicketPalet(IdPalet, TipoImpresion.ImpresoraSeleccionada, False, impresora, "", "")
                '        End If
                '    End If
                'Next



                For indice As Integer = 0 To GridViewpalets.RowCount - 1
                    Dim row As DataRow = GridViewpalets.GetDataRow(indice)
                    If Not IsNothing(row) Then
                        Dim IdPalet As String = (row("IdPalet").ToString & "").Trim
                        If VaInt(IdPalet) > 0 Then
                            C1_ImprimirTicketPalet(IdPalet, TipoImpresion.ImpresoraPorDefecto)
                        End If
                    End If
                Next

            End If

        End If


    End Sub
End Class