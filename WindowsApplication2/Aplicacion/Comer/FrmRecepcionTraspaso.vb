
Imports DevExpress.XtraEditors

Public Class FrmRecepcionTraspaso
    Inherits FrConsulta

    Private TraspasosCentros As New E_TraspasosCentros(Idusuario, cn)
    Private TraspasosCentros_Lineas As New E_TraspasosCentros_Lineas(Idusuario, cn)
    Private ValoresPVenta As New E_valorespventa(Idusuario, cn)


    'Private _MiUbicacion As Integer = 0


    Private err As New Errores()


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDeFecha, Nothing, Lb3, , Cdatos.TiposCampo.Fecha)
        ParamTx(TxHastaFecha, Nothing, Lb4, , Cdatos.TiposCampo.Fecha)


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        FechasPorDefecto()

    End Sub


    Private Sub FechasPorDefecto()

        TxDeFecha.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxHastaFecha.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub


    Private Sub CargaGrid()


        'Dim ValoresPVenta As New E_valorespventa(Idusuario, cn)
        'If ValoresPVenta.LeerId(MiMaletin.IdPuntoVenta.ToString) Then
        '    Dim Destino As Integer = VaInt(ValoresPVenta.VPV_IdDestinoTransito.Valor)
        '    If Destino > 0 Then _MiUbicacion = Destino
        'End If


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(TraspasosCentros.TCE_IdTrapaso, "IdTraspaso")
        CONSULTA.SelCampo(TraspasosCentros.TCE_Ejercicio, "EJ")
        CONSULTA.SelCampo(TraspasosCentros.TCE_Numero, "Traspaso")
        CONSULTA.SelCampo(TraspasosCentros.TCE_Fecha, "Fecha")
        CONSULTA.SelCampo(TraspasosCentros.TCE_IdCentroOrigen, "Origen")
        CONSULTA.SelCampo(TraspasosCentros.TCE_FechaCarga, "FechaCarga")
        CONSULTA.SelCampo(TraspasosCentros.TCE_HoraCarga, "HoraCarga")
        CONSULTA.SelCampo(TraspasosCentros.TCE_IdCentroDestino, "Destino")
        CONSULTA.SelCampo(ValoresPVenta.VPV_IdDestinoTransito, "IdDestino", TraspasosCentros.TCE_IdCentroDestino, ValoresPVenta.VPV_idpventa)


        Dim sql As String = CONSULTA.SQL & vbCrLf
        sql = sql & " WHERE COALESCE(TCE_FechaDescarga,'01/01/1900') = '01/01/1900'" & vbCrLf
        'sql = sql & " AND TCE_IdCentroDestino = " & _MiUbicacion.ToString & vbCrLf
        sql = sql & " AND TCE_IdCentroDestino IN (SELECT VPV_IdPVenta FROM ValoresPVenta WHERE VPV_IdDestinoTransito = " & MiMaletin.IdPuntoVenta & " AND VPV_IdPVenta > 90 AND " & MiMaletin.IdPuntoVenta & " <= 90" & ")" & vbCrLf
        If TxDeFecha.Text.Trim <> "" Then sql = sql & " AND TCE_Fecha >= '" & TxDeFecha.Text & "'" & vbCrLf
        If TxHastaFecha.Text.Trim <> "" Then sql = sql & " AND TCE_Fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf



        Dim dt As DataTable = TraspasosCentros.MiConexion.ConsultaSQL(Sql)


        Dim colSel As New DataColumn("S", GetType(Boolean))
        colSel.DefaultValue = False
        dt.Columns.Add(colSel)


        Grid.DataSource = Nothing
        GridView1.Columns.Clear()

        Grid.DataSource = dt
        AjustaColumnas()



    End Sub



    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim
                Case "IDTRASPASO", "IDDESTINO"
                    c.Visible = False
            End Select
        Next



        GridView1.BestFitColumns()

        Try

            For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

                Select Case c.FieldName.ToUpper.Trim

                    Case "DESTINO"
                        c.Caption = "Ubicacion"

                    Case "FECHA", "FECHACARGA"
                        c.Width = 80

                    Case "S"
                        c.Width = 25
                        c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                        c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                End Select

            Next


        Catch ex As Exception
            err.Muestraerror("Error al ajustar la columna", "AjustaColumnas", ex.Message)
        End Try


    End Sub



    Private Sub FrmCambioAcreedor_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False


        BtAux.Text = "Recibir traspaso"
        BtAux.Width = 120
        BtAux.Image = NetAgro.My.Resources.Resources.App_kservices_16x16_32
        BtAux.Visible = True


        '_MiUbicacion = MiMaletin.IdPuntoVenta + 90


    End Sub



    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

        If column.FieldName.ToUpper.Trim = "S" Then

            If row("S") = True Then
                row("S") = False
            Else
                row("S") = True
            End If

        End If



    End Sub


    Private Sub BtSelNinguno_Click(sender As System.Object, e As System.EventArgs) Handles BtSelNinguno.Click, BSelNinguno.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = False
            End If
        Next

    End Sub

    Private Sub BtSelTodos_Click(sender As System.Object, e As System.EventArgs) Handles BtSelTodos.Click, BSelTodos.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = True
            End If
        Next

    End Sub


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()


        If XtraMessageBox.Show("¿Desea recibir los traspasos marcados?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


            Dim TraspasosCentros As New E_TraspasosCentros(Idusuario, cn)
            Dim TraspasosCentros_Lineas As New E_TraspasosCentros_Lineas(Idusuario, cn)


            For indice As Integer = 0 To GridView1.RowCount - 1

                Dim row As DataRow = GridView1.GetDataRow(indice)
                If Not IsNothing(row) Then

                    If row("S") = True Then


                        Dim IdTraspaso As String = (row("IdTraspaso").ToString & "").Trim


                        'Dim Destino As String = (row("Destino") & "").Trim
                        'Destino = Destino - 90

                        Dim IdDestino As String = (row("IdDestino").ToString & "").Trim


                        If TraspasosCentros.LeerId(IdTraspaso) Then

                            TraspasosCentros.TCE_FechaDescarga.Valor = Today.ToString("dd/MM/yyyy")
                            TraspasosCentros.TCE_HoraDescarga.Valor = Now.ToString("HH:mm")
                            TraspasosCentros.Actualizar()

                            'Actualizar ubicación líneas
                            Dim CONSULTA2 As New Cdatos.E_select
                            CONSULTA2.SelCampo(TraspasosCentros_Lineas.TLI_IdLinea, "IdLineaTraspaso")
                            CONSULTA2.SelCampo(TraspasosCentros_Lineas.TLI_Tipo, "Tipo")
                            CONSULTA2.SelCampo(TraspasosCentros_Lineas.TLI_Codigo, "Codigo")
                            CONSULTA2.WheCampo(TraspasosCentros_Lineas.TLI_IdTraspaso, "=", IdTraspaso)

                            Dim dtLineas As DataTable = TraspasosCentros.MiConexion.ConsultaSQL(CONSULTA2.SQL)
                            If Not IsNothing(dtLineas) Then

                                For Each rowLinea As DataRow In dtLineas.Rows

                                    Dim Tipo As String = (rowLinea("Tipo").ToString & "").Trim
                                    Dim Codigo As String = (rowLinea("Codigo").ToString & "").Trim

                                    Select Case Tipo
                                        Case "P"
                                            Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
                                            If AlbEntrada_Lineas.LeerId(Codigo) Then
                                                AlbEntrada_Lineas.AEL_IdUbicacionPV.Valor = IdDestino
                                                AlbEntrada_Lineas.Actualizar()
                                            End If

                                        Case "L"
                                            Dim Lotes As New E_Lotes(Idusuario, cn)
                                            If Lotes.LeerId(Codigo) Then
                                                Lotes.LTE_IdUbicacionPV.Valor = IdDestino
                                                Lotes.Actualizar()
                                            End If

                                        Case "C"
                                            Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
                                            If LotesProduccion.LeerId(Codigo) Then
                                                LotesProduccion.LPD_IdUbicacionPV.Valor = IdDestino
                                                LotesProduccion.Actualizar()
                                            End If

                                        Case "T"
                                            Dim Palets As New E_palets(Idusuario, cn)
                                            If Palets.LeerId(Codigo) Then
                                                Palets.PAL_idpvsituacion.Valor = IdDestino
                                                Palets.Actualizar()
                                            End If


                                    End Select

                                Next

                            End If


                            'Vales de envases del género recibido
                            Dim IdValeDestino As String = TraspasosCentros.TCE_IdValeDestino.Valor

                            If VaInt(IdValeDestino) > 0 Then

                                'Cabecera
                                Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
                                If ValeEnvases.LeerId(IdValeDestino) Then
                                    ValeEnvases.VEV_IdAlmacen.Valor = IdDestino
                                    ValeEnvases.Actualizar()
                                End If

                                'Lineas
                                Dim sql As String = "SELECT VEL_Id FROM ValeEnvases_Lineas WHERE VEL_IdVale = " & IdValeDestino
                                Dim dtVEL As DataTable = ValeEnvases.MiConexion.ConsultaSQL(sql)

                                If Not IsNothing(dtVEL) Then
                                    For Each rowVEL As DataRow In dtVEL.Rows

                                        Dim IdLinea As String = (rowVEL("VEL_Id").ToString & "").Trim
                                        Dim ValeEnvases_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
                                        If ValeEnvases_Lineas.LeerId(IdLinea) Then
                                            ValeEnvases_Lineas.VEL_idalmacen.Valor = IdDestino
                                            ValeEnvases_Lineas.Actualizar()
                                        End If

                                    Next
                                End If

                            End If


                        Else
                            MsgBox("Error al recibir el traspaso, imposible leer el traspaso con id " & IdTraspaso)
                        End If


                    End If

                End If

            Next

            If GridView1.RowCount = 0 Then
                MsgBox("No hay traspasos seleccionados")
            Else
                MsgBox("Terminado!")
                Consultar()
            End If

        End If


    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()


        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDeFecha.Text, TxHastaFecha.Text)
        If fechas <> "" Then LineasDescripcion.Add(fechas)


        MyBase.Imprimir()

    End Sub


End Class
