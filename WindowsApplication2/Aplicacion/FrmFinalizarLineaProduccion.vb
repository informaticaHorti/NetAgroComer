Imports DevExpress.XtraEditors


Public Class FrmFinalizarLineaProduccion


    Public Enum ResultadoFormulario
        Aceptar
        Cancelar
    End Enum


    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro


    Dim Produccion As New E_Produccion(Idusuario, cn)
    Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)


    
    Private err As New Errores
    Public ErrorGrave As Boolean = False


    Private _IdProduccion As String = ""

    Private _Resultado As ResultadoFormulario = ResultadoFormulario.Cancelar
    Public ReadOnly Property Resultado
        Get
            Return _Resultado
        End Get
    End Property


    Private _HoraFinalizacion As Date = VaDate("")
    Public ReadOnly Property HoraFinalizacion As Date
        Get
            Return _HoraFinalizacion
        End Get
    End Property

    
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub


    Public Sub New(IdProduccion As String, Fecha As String, dtLineas As DataTable)

        Me.New()

        LbFecha.Text = Fecha

        _IdProduccion = IdProduccion

        GridLineas.DataSource = dtLineas


        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim param As New Cdatos.PropiedadesTx
        param.Obligatorio = True

        param.CampoBd = Produccion.PRD_KilosConsumidos
        param.Tipo = Produccion.PRD_KilosConsumidos.TipoBd
        param.Longitud = Produccion.PRD_KilosConsumidos.Longitud

        TxKilosConsumidos.Orden = 0
        TxKilosConsumidos.ClParam = param
        TxKilosConsumidos.ClForm = Me


        param = New Cdatos.PropiedadesTx
        param.Obligatorio = False

        param.CampoBd = AlbEntrada_Lineas.AEL_observaciones
        param.Tipo = AlbEntrada_Lineas.AEL_observaciones.TipoBd
        param.Longitud = AlbEntrada_Lineas.AEL_observaciones.Longitud

        TxObservaciones.Orden = 1
        TxObservaciones.ClParam = param
        TxObservaciones.ClForm = Me


    End Sub



    Private Sub frmNuevaLineaProduccion_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        'TxKilosConsumidos.Text = _KilosLinea.ToString
        'TxKilosConsumidos.Validar(True)

        TxKilosConsumidos.Select()
        TxKilosConsumidos.Focus()


        AjustaColumnas()


        Dim bEncontrado As Boolean = False

        For indice As Integer = 0 To GridViewLineas.RowCount - 1
            Dim row As DataRow = GridViewLineas.GetDataRow(indice)
            If Not IsNothing(row) Then
                If VaInt("Id") = _IdProduccion Then
                    GridViewLineas.FocusedRowHandle = indice
                    bEncontrado = True
                    Exit For
                End If
            End If
        Next


        If Not bEncontrado Then
            If GridViewLineas.RowCount > 0 Then
                GridViewLineas.FocusedRowHandle = 0
            End If
        End If

        MuestraDatosLinea()


        Dim ahora As DateTime = Now
        TxHoraFin.Text = ahora.ToString("HH:mm")
        updownHora.Value = ahora.Hour
        updownMinutos.Value = ahora.Minute



    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewLineas.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "ID", "KILOSCONSUMIDOS", "KGXHORA", "TIEMPO", "IDLINEAENTRADA", "OBSERVACIONES", "MUESTREADA"
                    c.Visible = False
            End Select
        Next

        GridViewLineas.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridViewLineas.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "NUMERO"
                    c.Caption = "Partida/Lote/PreCalib."
                Case "TIPO"
                    c.MinWidth = 30
                    c.MaxWidth = 30
                Case "KILOS", "KILOSLINEA" ', "KILOSCONSUMIDOS"
                    c.MinWidth = 90
                    c.MaxWidth = 90
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                Case "INICIO", "FINAL"
                    c.MinWidth = 65
                    c.MaxWidth = 65
                    'Case "KGXHORA"
                    '    c.MinWidth = 80
                    '    c.MaxWidth = 80
                    '    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    '    c.DisplayFormat.FormatString = "#,##0.00"
                Case "CATEGORIA"
                    c.Width = 100
                Case "PCALIB"
                    c.MinWidth = 50
                    c.MaxWidth = 50
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    'Case "TIEMPO"
                    '    c.MinWidth = 65
                    '    c.MaxWidth = 65
                    '    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    '    c.DisplayFormat.FormatString = "#,##0.0000"
                    '    c.Caption = "Tiempo(H)"

            End Select
        Next


    End Sub


    Private Sub MuestraDatosLinea()

        LbTipo.Text = ""
        LbNumero.Text = ""
        LbKgLinea.Text = ""
        LbInicio.Text = ""
        LbFin.Text = ""
        LbObservaciones.Text = ""



        Dim row As DataRow = GridViewLineas.GetFocusedDataRow()
        If Not IsNothing(row) Then

            TxKilosConsumidos.Text = VaInt(row("KilosLinea")).ToString("#,##0")

            Dim Tipo As String = (row("Tipo").ToString & "").ToUpper.Trim
            Dim Numero As String = (row("Numero").ToString & "").Trim
            Dim KgLinea As String = VaInt(row("KilosLinea")).ToString("#,##0")
            Dim Inicio As String = (row("Inicio").ToString & "").Trim
            Dim Fin As String = (row("Final").ToString & "").Trim
            Dim Observaciones As String = (row("Observaciones").ToString & "").Trim

            LbTipo.Text = Tipo
            LbNumero.Text = Numero
            LbKgLinea.Text = KgLinea
            LbInicio.Text = Inicio
            LbFin.Text = Fin
            TxObservaciones.Text = Observaciones

            If Tipo = "P" Then
                LbObservaciones.Visible = True
                TxObservaciones.Visible = True
            Else
                LbObservaciones.Visible = False
                TxObservaciones.Visible = False
            End If

        Else
            MsgBox("Error al obtener el id de la línea de producción")
        End If

    End Sub


    Private Sub BtAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BtAceptar.Click


        If ChkNoFinalizar.Checked Then
            _Resultado = ResultadoFormulario.Aceptar
            Me.Close()
            Exit Sub
        End If


        Dim row As DataRow = GridViewLineas.GetFocusedDataRow()
        If IsNothing(row) Then
            MsgBox("Error al obtener el id de la linea")
            Exit Sub
        End If


        If XtraMessageBox.Show("¿Está seguro de finalizar la linea?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim Id As String = row("Id").ToString & ""

            Dim Produccion As New E_Produccion(Idusuario, cn)
            If Produccion.LeerId(Id) Then

                Dim HoraFin As Date = VaDate("")
                Dim texto_hora_fin As String() = Split(TxHoraFin.Text, ":")
                If texto_hora_fin.Length = 2 And VaInt(texto_hora_fin(0)) > -1 And VaInt(texto_hora_fin(0)) < 24 And VaInt(texto_hora_fin(1)) > -1 And VaInt(texto_hora_fin(1)) < 60 Then
                    HoraFin = New DateTime(Now.Year, Now.Month, Now.Day, VaInt(texto_hora_fin(0)), VaInt(texto_hora_fin(1)), 0)
                Else
                    HoraFin = New DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, 0)
                End If



                Produccion.PRD_KilosConsumidos.Valor = VaInt(TxKilosConsumidos.Text).ToString
                Produccion.PRD_HoraFinal.Valor = HoraFin.ToString("HH:mm:ss")
                Produccion.PRD_HoraFinalCompleta.Valor = HoraFin.ToString("dd/MM/yyyy HH:mm:ss")
                Produccion.Actualizar()

                Me.Close()

                _Resultado = ResultadoFormulario.Aceptar
                _HoraFinalizacion = HoraFin

            End If


            Dim IdLineaEntrada As String = (row("IdLineaEntrada").ToString & "").Trim

            If VaInt(IdLineaEntrada) Then
                Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
                If AlbEntrada_Lineas.LeerId(IdLineaEntrada) Then
                    AlbEntrada_Lineas.AEL_observaciones.Valor = TxObservaciones.Text
                    AlbEntrada_Lineas.Actualizar()
                End If
            End If


        End If

    End Sub


    Private Sub btCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub


    Private Sub TxKilosConsumidos_Valida(edicion As System.Boolean) Handles TxKilosConsumidos.Valida
        If edicion Then

            Dim KilosLinea As Integer = 0
            Dim row As DataRow = GridViewLineas.GetFocusedDataRow()
            If Not IsNothing(row) Then
                KilosLinea = VaInt(row("KilosLinea"))
            Else
                MsgBox("Error al obtener el id de la linea")
            End If


            If VaInt(TxKilosConsumidos.Text) > KilosLinea Then
                MsgBox("No pueden consumirse más kilos de los que hay en la linea")
                TxKilosConsumidos.MiError = True
            Else
                TxKilosConsumidos.MiError = False
            End If

            If Not TxObservaciones.Visible And Not TxKilosConsumidos.MiError Then
                BtAceptar.Select()
                BtAceptar.Focus()
            ElseIf Not TxKilosConsumidos.MiError Then
                TxObservaciones.Select()
                TxObservaciones.Focus()
            End If
            

        End If
    End Sub


    Private Sub GridViewLineas_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewLineas.FocusedRowChanged
        MuestraDatosLinea()
    End Sub


    Private Sub ChkNoFinalizar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkNoFinalizar.CheckedChanged

        If Not ChkNoFinalizar.Checked Then

            GridLineas.Enabled = True
            MuestraDatosLinea()

        Else

            LbTipo.Text = ""
            LbNumero.Text = ""
            LbKgLinea.Text = ""
            LbInicio.Text = ""
            LbFin.Text = ""
            TxKilosConsumidos.Text = ""

            GridLineas.Enabled = False

        End If

    End Sub


    Private Sub TxObservaciones_Valida(edicion As System.Boolean) Handles TxObservaciones.Valida
        If edicion Then

            If Not TxObservaciones.MiError Then
                BtAceptar.Select()
                BtAceptar.Focus()
            End If

        End If
    End Sub



    Private Sub updownHora_ValueChanged(sender As Object, e As EventArgs) Handles updownHora.ValueChanged

        If updownHora.Value > 23 Then
            updownHora.Value = 0
        ElseIf updownHora.Value < 0 Then
            updownHora.Value = 23
        End If

        MostrarHora()

    End Sub

    Private Sub updownMinutos_ValueChanged(sender As Object, e As EventArgs) Handles updownMinutos.ValueChanged

        If updownMinutos.Value > 59 Then
            updownMinutos.Value = 0
        ElseIf updownMinutos.Value < 0 Then
            updownMinutos.Value = 59
        End If

        MostrarHora()

    End Sub


    Private Sub MostrarHora()

        TxHoraFin.Text = updownHora.Value.ToString("00") & ":" & updownMinutos.Value.ToString("00")

    End Sub


End Class