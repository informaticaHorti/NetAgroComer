Imports DevExpress.XtraEditors

Public Class FrmCambioPreciosAlbaran
    Inherits FrConsulta


    Dim _IdAlbaran As String = ""
    Dim _bPrimero As Boolean = True
    Dim _ValorCambio As Decimal = 0



    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim AlbSalida_Lineas As New E_AlbSalida_lineas(Idusuario, cn)
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(IdAlbaran As String)
        Me.New()

        _IdAlbaran = IdAlbaran

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc


    End Sub

   


    Private Sub FrmPedidosPredefinidos_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        GridEditable.pnlDerecha.Visible = False
        _bPrimero = False



        If Not AlbSalida.LeerId(_IdAlbaran) Then
            MsgBox("Error al leer el albarán con Id: " & _IdAlbaran)
            Me.Close()
        End If


        CargaDatosAlbaran()
        BConsultar.PerformClick()


    End Sub


    Private Sub CargaDatosAlbaran()

        LbAlbaran.Text = AlbSalida.ASA_albaran.Valor
        If VaDate(AlbSalida.ASA_fechasalida.Valor) > VaDate("") Then LbFecha.Text = VaDate(AlbSalida.ASA_fechasalida.Valor).ToString("dd/MM/yyyy")
        LbFC.Text = AlbSalida.ASA_tipofc.Valor
        LbNom_Referencia.Text = AlbSalida.ASA_referencia.Valor

        Dim Clientes As New E_Clientes(Idusuario, cn)
        Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)


        If Clientes.LeerId(AlbSalida.ASA_idcliente.Valor) Then
            LbNom_Cliente.Text = (Clientes.CLI_Nombre.Valor)
        End If


        If ClientesDescargas.LeerId(AlbSalida.ASA_iddomicilio.Valor) Then
            LbNom_Domicilio.Text = ClientesDescargas.CLD_Domicilio.Valor
        End If


        _ValorCambio = VaDec(AlbSalida.ASA_valorcambio.Valor)


    End Sub




    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        GridEditable.DataSource = Nothing

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(AlbSalida_Lineas.ASL_idlinea, "IdLinea")
        CONSULTA.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", AlbSalida_Lineas.ASL_idgensal)
        CONSULTA.SelCampo(AlbSalida_Lineas.ASL_categoria, "Categoria")
        CONSULTA.SelCampo(Marcas.MAR_Nombre, "Marca", AlbSalida_Lineas.ASL_idmarca)
        CONSULTA.SelCampo(AlbSalida_Lineas.ASL_palets, "Palets")
        CONSULTA.SelCampo(AlbSalida_Lineas.ASL_bultos, "Bultos")
        CONSULTA.SelCampo(AlbSalida_Lineas.ASL_kilosbrutos, "KgBrutos")
        CONSULTA.SelCampo(AlbSalida_Lineas.ASL_kilosnetos, "KgNetos")
        CONSULTA.SelCampo(AlbSalida_Lineas.ASL_kiloscliente, "KgCliente")
        CONSULTA.SelCampo(AlbSalida_Lineas.ASL_piezas, "Piezas")
        CONSULTA.SelCampo(AlbSalida_Lineas.ASL_precio, "Precio")
        CONSULTA.SelCampo(AlbSalida_Lineas.ASL_tipoprecio, "TipoPrecio")
        CONSULTA.WheCampo(AlbSalida_Lineas.ASL_idalbaran, "=", _IdAlbaran)

        Dim sql As String = CONSULTA.SQL & " ORDER BY ASL_IdGenero, ASL_IdTipoConfeccion, ASL_IdCategoria, ASL_IdMarca"
        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)


        GridEditable.DataSource = dt
        GridEditable.Campo("Precio", AlbSalida_Lineas.ASL_precio, True, True, , False, 80)
        GridEditable.Campo("TipoPrecio", AlbSalida_Lineas.ASL_tipoprecio, True, True, , False, 40)


        AjustaColumnas(GridEditable.GridView)


    End Sub


    Private Sub AjustaColumnas(g As DevExpress.XtraGrid.Views.Grid.GridView)


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In g.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDLINEA"
                    c.Visible = False
            End Select
        Next


        g.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In g.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "PALETS", "BULTOS", "PIEZAS", "BXP"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"

                Case "KGNETOS", "KGBRUTOS", "KGCLIENTE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"

                Case "PRECIO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.0000"

            End Select

        Next


        Funciones.AñadeResumenCampo(g, "Palets", "{0:n0}")
        Funciones.AñadeResumenCampo(g, "Bultos", "{0:n0}")
        Funciones.AñadeResumenCampo(g, "KgNetos", "{0:n0}")
        Funciones.AñadeResumenCampo(g, "KgBrutos", "{0:n0}")
        Funciones.AñadeResumenCampo(g, "KgCliente", "{0:n0}")
        Funciones.AñadeResumenCampo(g, "Piezas", "{0:n0}")

    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()

        ActualizarPrecios()

    End Sub


    Private Sub ActualizarPrecios()

        If XtraMessageBox.Show("¿Desea actualizar los precios del albarán?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            For indice As Integer = 0 To GridEditable.GridView.RowCount - 1
                Dim row As DataRow = GridEditable.GridView.GetDataRow(indice)
                If Not IsNothing(row) Then

                    Dim IdLinea As String = (row("IdLinea").ToString & "").Trim
                    Dim Precio As Decimal = VaDec(row("Precio"))
                    Dim TipoPrecio As String = (row("TipoPrecio").ToString & "").Trim

                    Dim AlbSalida_Lineas As New E_AlbSalida_lineas(Idusuario, cn)
                    If AlbSalida_Lineas.LeerId(IdLinea) Then

                        AlbSalida_Lineas.ASL_precio.Valor = Precio.ToString
                        AlbSalida_Lineas.ASL_tipoprecio.Valor = TipoPrecio


                        Dim u As Decimal
                        Dim igenero As Decimal
                        Dim igeneroestimado As Decimal
                        u = 0
                        Select Case TipoPrecio
                            Case "K"
                                u = VaDec(AlbSalida_Lineas.ASL_kiloscliente.Valor)
                            Case "B"
                                u = VaDec(AlbSalida_Lineas.ASL_bultos.Valor)
                            Case "P"
                                u = VaDec(AlbSalida_Lineas.ASL_piezas.Valor)

                        End Select
                        igenero = u * Precio

                        igeneroestimado = igenero


                        AlbSalida_Lineas.ASL_importegenero.Valor = igenero.ToString


                        AlbSalida_Lineas.ASL_precioventa.Valor = Precio.ToString ' igualo el precio vta del precio estimado
                        AlbSalida_Lineas.ASL_tipopreciovta.Valor = TipoPrecio
                        AlbSalida_Lineas.ASL_importegenerovta.Valor = igeneroestimado.ToString ' importe de vta = importe estimado
                        AlbSalida_Lineas.ASL_importegeneroestimado.Valor = igeneroestimado.ToString


                        AlbSalida_Lineas.Actualizar()

                    End If

                End If


                Application.DoEvents()
            Next



            Agro_CalculoGastosTotalesAlbaran(_IdAlbaran, _ValorCambio)


            Me.Close()




        End If

    End Sub


   
    'Private Sub GridEditable_Valida(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn) Handles GridEditable.Valida
    '    If Not IsNothing(row) Then

    '        If column.FieldName.Trim.ToUpper = "TIPOPRECIO" Then
    '            row(column.FieldName) = (row(column.FieldName).ToString & "").Trim.ToUpper
    '        End If

    '    End If
    'End Sub






    Private Sub GridEditable1_ColumnaSiguiente(IndiceFila As System.Int32, IndiceColumna As System.Int32, ByRef NuevaFila As System.Int32, ByRef NuevaColumna As System.Int32) Handles GridEditable.ColumnaSiguiente


        Try

            Dim rowActual As DataRow = GridEditable.GridView.GetDataRow(IndiceFila)
            Dim colActual As DevExpress.XtraGrid.Columns.GridColumn = GridEditable.GridView.GetVisibleColumn(IndiceColumna)

            If colActual.FieldName.ToUpper.Trim = "PRECIO" Then
                GridEditable1_Valida(rowActual, colActual)
            End If

            If colActual.FieldName.ToUpper.Trim = "TIPOPRECIO" Then
                GridEditable1_Valida(rowActual, colActual)

                NuevaColumna = IndiceColumna - 1
                NuevaFila = IndiceFila + 1

            End If

           

        Catch ex As Exception

        End Try

    End Sub

  


    Private Sub GridEditable1_Valida(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn) Handles GridEditable.Valida

        If column.FieldName.Trim.ToUpper = "TIPOPRECIO" Then
            row(column.FieldName) = (row(column.FieldName).ToString & "").Trim.ToUpper
        End If

    End Sub

    Protected Overrides Sub OcultaCargando()
        MyBase.OcultaCargando()

        FocoAPrecio()
      


    End Sub

    Private Sub FocoAPrecio()
        If GridEditable.GridView.RowCount > 0 Then

            Dim col As DevExpress.XtraGrid.Columns.GridColumn = GridEditable.GridView.Columns.ColumnByFieldName("Precio")
            If Not IsNothing(col) Then

                GridEditable.GridView.FocusedRowHandle = 0
                GridEditable.GridView.FocusedColumn = col
                GridEditable.GridView.ShowEditor()

            End If

        End If
    End Sub

 
   
End Class