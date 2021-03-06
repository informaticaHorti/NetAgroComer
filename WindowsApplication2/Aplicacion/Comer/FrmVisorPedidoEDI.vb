Public Class FrmVisorPedidoEDI


    Public Enum ResultadoFormulario

        Importar
        Salir

    End Enum


    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro

    Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)


    Private _Fichero As String = ""
    Private _Pedido As EDI.EDI_Pedido

    Private _Resultado As ResultadoFormulario = ResultadoFormulario.Salir
    Public ReadOnly Property Resultado As ResultadoFormulario
        Get
            Return _Resultado
        End Get
    End Property



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Public Sub New(ByVal Fichero As String, ByVal Pedido As EDI.EDI_Pedido)
        Me.New()

        _Fichero = Fichero
        _Pedido = Pedido


    End Sub


    Private Sub FrmVisorPedidoEDI_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        CargaDatosCabecera()
        CargaDatosObservacionesCabecera()
        CargaDatosLinea()

    End Sub


    Private Sub CargaDatosCabecera()

        Select Case _Pedido.Cabecera.FuncionMensaje

            Case EDI.Comun.FuncionMensaje.Reemplazo
                LbTipoMensaje.Text = "REEMPLAZO"
                LbTipoMensaje.BackColor = Color.Firebrick

            Case EDI.Comun.FuncionMensaje.Original
                LbTipoMensaje.Text = "PEDIDO NUEVO"
                LbTipoMensaje.BackColor = Color.SteelBlue

            Case Else
                LbTipoMensaje.Text = "DESCONOCIDO"
                LbTipoMensaje.BackColor = Color.Firebrick

        End Select

        LbNumeroOrden.Text = _Pedido.ClavePedido
        LbRefCliente.Text = _Pedido.NumeroPedido
        LbFecha.Text = _Pedido.FechaPedido

        Dim Cliente As String = ""
        Dim DomicilioDescarga As String = ""
        Dim IdCliente As Integer = EDI.Comun.ObtenerClienteGLN(_Pedido.Comprador, Cliente)
        Dim IdDomicilio As String = EDI.Comun.ObtenerDomicilioDescarga(_Pedido.Comprador, _Pedido.Receptor, DomicilioDescarga)

        LbIdClienteComprador.Text = IdCliente.ToString
        LbClienteComprador.Text = Cliente
        If IdDomicilio > 0 Then LbIdDomicilio.Text = IdDomicilio.ToString
        If DomicilioDescarga <> "" Then LbDomicilioDescarga.Text = DomicilioDescarga Else LbDomicilioDescarga.Text = _Pedido.Receptor
        LbBESTELLNR.Text = _Pedido.NumeroPedidoEmisor

        If VaDate(_Pedido.FechaEntregaRequerida) > VaDate("") Then LbFechaEntregaRequerida.Text = _Pedido.FechaEntregaRequerida.ToString("dd/MM/yyyy")


    End Sub


    Private Sub CargaDatosObservacionesCabecera()

        Dim dt As New DataTable
        dt.Columns.Add("Texto", GetType(String))


        Select Case _Pedido.Cabecera.ProveedorEDI
            Case EDI.Comun.ProveedorEDI.EDICOM

                For indice As Integer = 0 To CType(_Pedido, EDICOM.EDICOM_Pedido).ObservacionesGlobales.Count - 1

                    Dim Observacion As EDICOM.EDICOM_ObservacionesGlobalesPedido = CType(_Pedido, EDICOM.EDICOM_Pedido).ObservacionesGlobales(indice)
                    Dim Texto As String = ""

                    If Observacion.Texto1.Trim <> "" Then
                        Dim fila As DataRow = dt.NewRow()
                        fila("Texto") = Observacion.Texto1
                        dt.Rows.Add(fila)
                    End If

                    If Observacion.Texto2.Trim <> "" Then
                        Dim fila As DataRow = dt.NewRow()
                        fila("Texto") = Observacion.Texto2
                        dt.Rows.Add(fila)
                    End If

                    If Observacion.Texto3.Trim <> "" Then
                        Dim fila As DataRow = dt.NewRow()
                        fila("Texto") = Observacion.Texto3
                        dt.Rows.Add(fila)
                    End If

                    If Observacion.Texto4.Trim <> "" Then
                        Dim fila As DataRow = dt.NewRow()
                        fila("Texto") = Observacion.Texto4
                        dt.Rows.Add(fila)
                    End If

                    If Observacion.Texto5.Trim <> "" Then
                        Dim fila As DataRow = dt.NewRow()
                        fila("Texto") = Observacion.Texto5
                        dt.Rows.Add(fila)
                    End If

                    Application.DoEvents()

                Next

        End Select

        GridObservacionesCabecera.DataSource = dt


    End Sub


    Private Sub CargaDatosLinea()

        Dim dt As New DataTable
        dt.Columns.Add("EAN_Articulo", GetType(String))
        dt.Columns.Add("Descripcion", GetType(String))
        dt.Columns.Add("IdPresentacion", GetType(Integer))
        dt.Columns.Add("Presentacion", GetType(String))
        dt.Columns.Add("IdGenero", GetType(Integer))
        dt.Columns.Add("Genero", GetType(String))
        dt.Columns.Add("IdTipoConfeccion", GetType(Integer))
        dt.Columns.Add("Confeccion", GetType(String))
        dt.Columns.Add("Bultos", GetType(Decimal))
        dt.Columns.Add("UnidadesConsumo", GetType(Decimal))


        'Cuidado al tocar!! Ver comentario en GridViewLineas_FocusedRowChanged
        For Each linea As EDI.EDI_LineaPedido In _Pedido.Lineas

            Dim IdGenero As Integer = 0
            Dim Genero As String = ""
            Dim IdTipoConfeccion As Integer = 0
            Dim Confeccion As String = ""
            Dim Presentacion As String = ""


            Dim fila As DataRow = dt.NewRow()
            fila("EAN_Articulo") = linea.EAN_Articulo
            fila("Descripcion") = linea.Descripcion & " " & linea.descripcion2
            fila("IdPresentacion") = EDI.Comun.ObtenerPresentacionEAN(IdGenero, Genero, IdTipoConfeccion, Confeccion, _Pedido.Comprador, linea.EAN_Articulo, Presentacion)
            fila("Presentacion") = Presentacion
            fila("IdGenero") = IdGenero
            fila("Genero") = Genero
            fila("IdTipoConfeccion") = IdTipoConfeccion
            fila("Confeccion") = Confeccion
            fila("Bultos") = linea.Cantidad
            fila("UnidadesConsumo") = linea.UnidadesConsumo
            dt.Rows.Add(fila)

            Application.DoEvents()

        Next
        


        GridLineas.DataSource = dt
        AjustaColumnasLineas()

    End Sub


    Private Sub AjustaColumnasLineas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewLineas.Columns
            Select Case c.FieldName.Trim.ToUpper
                Case "DUN14", "IDPRESENTACION", "IDTIPOCONFECCION", "IDGENERO", "GENERO", "IDTIPOCONFECCION", "CONFECCION"
                    c.Visible = False
            End Select
        Next

        GridViewLineas.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewLineas.Columns
            Select Case c.FieldName.Trim.ToUpper

                Case "EAN_ARTICULO"
                    c.MinWidth = 130
                    c.MaxWidth = 130

                Case "DESCRIPCION"
                    c.Width = 150

                Case "CONFECCION"
                    c.MinWidth = 150

                Case "PRESENTACION"
                    c.MinWidth = 250

                Case "UNIDADESCONSUMO"
                    c.Caption = "UConsumo"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.MinWidth = 50
                    c.MaxWidth = 50

                Case "BULTOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.MinWidth = 60
                    c.MaxWidth = 60

            End Select
        Next

    End Sub


    Private Sub GridViewLineas_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewLineas.FocusedRowChanged

        Dim row As DataRow = GridViewLineas.GetDataRow(GridViewLineas.FocusedRowHandle)
        If Not IsNothing(row) Then

            'OJO: Esto funciona porque insertamos las líneas en el grid en el mismo orden en que están en el _Pedido. Cuidado al tocar!!
            Dim Linea As EDI.EDI_LineaPedido = _Pedido.Lineas(GridViewLineas.FocusedRowHandle)
            CargaDatosObservacionesLinea(Linea)
            CargaDatosDesgloseLinea(Linea)

        End If

    End Sub


    Private Sub CargaDatosObservacionesLinea(ByVal Linea As EDI.EDI_LineaPedido)

        Dim dt As New DataTable
        dt.Columns.Add("Texto", GetType(String))


        Select Case _Pedido.Cabecera.ProveedorEDI
            Case EDI.Comun.ProveedorEDI.EDICOM

                For indice As Integer = 0 To CType(Linea, EDICOM.EDICOM_DetallePedido).ObservacionesLinea.Count - 1

                    Dim Observacion As EDICOM.EDICOM_ObservacionesLineasPedido = CType(Linea, EDICOM.EDICOM_DetallePedido).ObservacionesLinea(indice)
                    Dim Texto As String = ""

                    If Observacion.Texto1.Trim <> "" Then
                        Dim fila As DataRow = dt.NewRow()
                        fila("Texto") = Observacion.Texto1
                        dt.Rows.Add(fila)
                    End If

                    If Observacion.Texto2.Trim <> "" Then
                        Dim fila As DataRow = dt.NewRow()
                        fila("Texto") = Observacion.Texto2
                        dt.Rows.Add(fila)
                    End If

                    If Observacion.Texto3.Trim <> "" Then
                        Dim fila As DataRow = dt.NewRow()
                        fila("Texto") = Observacion.Texto3
                        dt.Rows.Add(fila)
                    End If

                    If Observacion.Texto4.Trim <> "" Then
                        Dim fila As DataRow = dt.NewRow()
                        fila("Texto") = Observacion.Texto4
                        dt.Rows.Add(fila)
                    End If

                    If Observacion.Texto5.Trim <> "" Then
                        Dim fila As DataRow = dt.NewRow()
                        fila("Texto") = Observacion.Texto5
                        dt.Rows.Add(fila)
                    End If

                    Application.DoEvents()

                Next

        End Select

        GridObservacionesLínea.DataSource = dt

    End Sub


    Private Sub CargaDatosDesgloseLinea(ByVal Linea As EDI.EDI_LineaPedido)

        Dim dt As New DataTable


        Select Case _Pedido.Cabecera.ProveedorEDI
            Case EDI.Comun.ProveedorEDI.EDICOM


                dt.Columns.Add("Lugar", GetType(String))
                dt.Columns.Add("IdDomicilio", GetType(Integer))
                dt.Columns.Add("DomicilioDescarga", GetType(String))
                dt.Columns.Add("Bultos", GetType(Decimal))
                dt.Columns.Add("FechaEntrega", GetType(DateTime))

                For indice As Integer = 0 To CType(Linea, EDICOM.EDICOM_DetallePedido).DesgloseLinea.Count - 1

                    Dim Desglose As EDICOM.EDICOM_DesgloseLineasPedido = CType(Linea, EDICOM.EDICOM_DetallePedido).DesgloseLinea(indice)

                    Dim DomicilioDescarga As String = ""

                    Dim fila As DataRow = dt.NewRow()
                    fila("Lugar") = Desglose.Lugar
                    fila("IdDomicilio") = EDI.Comun.ObtenerDomicilioDescarga(_Pedido.Comprador, Desglose.Lugar, DomicilioDescarga)
                    fila("DomicilioDescarga") = DomicilioDescarga
                    fila("Bultos") = Desglose.Cantidad
                    If Desglose.FechaEntregaSolicitada > VaDate("") Then fila("FechaEntrega") = Desglose.FechaEntregaSolicitada
                    dt.Rows.Add(fila)
                    

                    Application.DoEvents()

                Next

        End Select

        GridDesglose.DataSource = dt
        AjustaColumnasDesglose()

    End Sub


    Private Sub AjustaColumnasDesglose()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewDesglose.Columns
            Select Case c.FieldName.Trim.ToUpper
                Case "IDDOMICILIO"
                    c.Visible = False
            End Select
        Next

        GridViewDesglose.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewDesglose.Columns
            Select Case c.FieldName.Trim.ToUpper

                Case "LUGAR"
                    c.MinWidth = 130
                    c.MaxWidth = 130

                Case "BULTOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.MinWidth = 60
                    c.MaxWidth = 60

            End Select
        Next

    End Sub


    Private Sub BtImportar_Click(sender As System.Object, e As System.EventArgs) Handles BtImportar.Click

        If MessageBox.Show("¿Desea importar el pedido?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


            'Una vez termina de procesar el fichero, lo movemos de carpeta a una de ficheros procesados
            'En primer lugar, creamos la carpeta si no existe
            Dim ruta_origen = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CARPETA_TEMPORAL_LLEGADA_PEDIDOS_EDI.ToString, 0, 0, 0)
            If Not ruta_origen.EndsWith("\") Then ruta_origen = ruta_origen & "\"
            Dim ruta_procesados As String = ruta_origen & "procesados\"


            'Verifica la creación de la carpeta
            Try
                If Not IO.Directory.Exists(ruta_procesados) Then
                    IO.Directory.CreateDirectory(ruta_procesados)
                End If
            Catch ex As Exception
                MsgBox("No se pudo crear la carpeta para los archivos procesados de pedidos")
            End Try


            Dim bExisteRuta As Boolean = IO.Directory.Exists(ruta_procesados)
            If bExisteRuta Then


                'Meollo de la importación
                If InsertarPedido() Then

                    'Procesar todos los ficheros del mismo pedido
                    Dim sufijo As String = _Fichero.ToLower.Replace("cabped", "")
                    Dim lst As New List(Of String)

                    Dim Dir As New IO.DirectoryInfo(ruta_origen)
                    Dim Archivos As IO.FileInfo() = Dir.GetFiles("*" & sufijo)
                    For Each archivo As IO.FileInfo In Archivos

                        If archivo.Name.ToLower.Contains(sufijo) Then

                            Dim nombre_archivo As String = archivo.Name.ToLower.Replace(sufijo, "") & ".txt"
                            Select Case nombre_archivo.ToUpper
                                Case "CABPED.TXT", "LINPED.TXT", "OBSPED.TXT", "OBSLPED.TXT", "LOCLPED.TXT"
                                    lst.Add(archivo.Name)
                            End Select

                        End If

                    Next


                    'Guardamos los archivos del pedido en la carpeta de procesados y los borramos de la carpeta original
                    For Each archivo As String In lst

                        Dim bCopiado As Boolean = True
                        'Verifica la copia de los ficheros al final de todo
                        Try
                            IO.File.Copy(ruta_origen & archivo, ruta_procesados & archivo)
                        Catch ex As Exception
                            MsgBox("No se pudo copiar el fichero " & archivo & " a la carpeta de ficheros procesados, por favor, cópielo manualmente a la carpeta de ficheros procesados y bórrelo manualmente")
                            bCopiado = False
                        End Try


                        'Y el borrado
                        If bCopiado Then
                            Try
                                IO.File.Delete(ruta_origen & archivo)
                            Catch ex As Exception
                                MsgBox("No se pudo borrar el fichero " & archivo & " de la carpeta de origen, por favor, bórrelo manualmente")
                            End Try
                        End If

                    Next

                    

                    _Resultado = ResultadoFormulario.Importar
                    Me.Close()

                Else
                    MsgBox("ERROR al insertar el pedido")
                End If



            End If


        End If

    End Sub


    Private Function InsertarPedido() As Boolean

        'Llama al formulario de pedidos para insertar un nuevo pedido con los datos que tenemos
        Dim bRes As Boolean = True


        'Crear pedido y cargarlo en FrmPedidos
        'NO DEJAR QUE SALGA SIN GUARDAR O BORRAR


        'Cabecera del pedido
        Dim Pedidos As New E_Pedidos(Idusuario, cn)
        Dim IdPedido As String = Pedidos.MaxId.ToString
        Pedidos.PED_idpedido.Valor = IdPedido
        Pedidos.PED_pedido.Valor = Pedidos.MaxIdCampa(MiMaletin.Ejercicio, MiMaletin.IdCentro)
        Pedidos.PED_ejercicio.Valor = MiMaletin.Ejercicio.ToString
        Pedidos.PED_idcentro.Valor = MiMaletin.IdCentro.ToString
        Pedidos.PED_idpuntoventa.Valor = MiMaletin.IdPuntoVenta.ToString
        Pedidos.PED_fechapedido.Valor = LbFecha.Text
        Pedidos.PED_idcliente.Valor = LbIdClienteComprador.Text
        Pedidos.PED_referencia.Valor = LbRefCliente.Text
        Pedidos.PED_iddivisa.Valor = "1"
        Pedidos.PED_valorcambio.Valor = "1"
        If VaInt(LbIdDomicilio.Text) > 0 Then Pedidos.PED_iddestino.Valor = LbIdDomicilio.Text
        Pedidos.PED_BESTELLNR.Valor = LbBESTELLNR.Text
        Pedidos.PED_FechaLlegada.Valor = LbFechaEntregaRequerida.Text


        'Observaciones cabecera
        If Not IsNothing(GridObservacionesCabecera.DataSource) Then

            Dim cont As Integer = 1

            For indice As Integer = 0 To GridViewObservacionesCabecera.RowCount - 1
                Dim row As DataRow = GridViewObservacionesCabecera.GetDataRow(indice)
                If Not IsNothing(row) Then

                    Dim texto As String = (row("Texto").ToString & "").Trim

                    Select Case cont
                        Case 1
                            Pedidos.PED_obs1.Valor = texto
                        Case 2
                            Pedidos.PED_obs2.Valor = texto
                        Case 3
                            Pedidos.PED_obs3.Valor = texto
                        Case 4
                            Pedidos.PED_obs4.Valor = texto
                    End Select

                    cont = cont + 1

                End If
            Next
        End If

        Pedidos.Insertar()


        'Líneas del pedido
        If Not IsNothing(GridLineas.DataSource) Then


            For indice As Integer = 0 To GridViewLineas.RowCount - 1

                Dim row As DataRow = GridViewLineas.GetDataRow(indice)
                If Not IsNothing(row) Then


                    'fila("EAN_Articulo") = linea.EAN_Articulo
                    'fila("DUN14") = linea.DUN14
                    'fila("Descripcion") = linea.Descripcion & " " & linea.descripcion2
                    'fila("IdPresentacion") = EDI.Comun.ObtenerPresentacionEAN(IdGenero, Genero, IdTipoConfeccion, Confeccion, _Pedido.Comprador, linea.EAN_Articulo, Presentacion)
                    'fila("Presentacion") = Presentacion
                    'fila("IdGenero") = IdGenero
                    'fila("Genero") = Genero
                    'fila("IdTipoConfeccion") = IdTipoConfeccion
                    'fila("Confeccion") = Confeccion
                    'fila("Bultos") = linea.Cantidad
                    'fila("UnidadesConsumo") = linea.UnidadesConsumo

                    Dim IdGenero As Integer = VaInt(row("IdGenero"))
                    Dim IdTipoConfeccion As Integer = VaInt(row("IdTipoConfeccion"))
                    Dim IdPresentacion As Integer = VaInt(row("IdPresentacion"))
                    Dim Bultos As Integer = VaInt(row("Bultos"))


                    Dim Pedidos_lineas As New E_Pedidos_lineas(Idusuario, cn)
                    Pedidos_lineas.PEL_idpedido.Valor = IdPedido
                    Pedidos_lineas.PEL_idlinea.Valor = Pedidos_lineas.MaxId.ToString
                    Pedidos_lineas.PEL_idgenero.Valor = IdGenero.ToString
                    Pedidos_lineas.PEL_idtipoconfeccion.Valor = IdTipoConfeccion.ToString
                    Pedidos_lineas.PEL_idgensal.Valor = IdPresentacion.ToString
                    Pedidos_lineas.PEL_Bultos.Valor = Bultos.ToString


                    Pedidos_lineas.Insertar()

                End If
            Next
        End If




        Dim frm As New FrmPedidos(_Pedido)
        frm.init(IdPedido)
        frm.MdiParent = Me.MdiParent
        frm.ShowDialog()

        'If frm.IdPedidoInsertado > 0 Then
        '    bRes = True
        'Else
        '    bRes = False
        'End If


        Return bRes

    End Function


    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click

        Me.Close()

    End Sub


    
End Class
