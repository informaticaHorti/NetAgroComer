Imports NetAgro.Cdatos


Public Class TxDato
    Inherits TextBox


    Dim err As Errores

    Public Event AntesDeValidarEnlace()
    Public Event AntesDeValidar(ByVal edicion As Boolean)
    Public Event Valida(ByVal edicion As Boolean)
    Public Event Atras()



    Protected _DcNoEnviarTecla As New Dictionary(Of System.Windows.Forms.Keys, Boolean)
    

    Protected _ValorAnterior As String = ""
    Protected _UltimoValorValidado As String = Nothing
    Public _UltimoValorCambiado As String = Nothing

    Public Property UltimoValorValidado As String
        Get
            Return _UltimoValorValidado
        End Get
        Set(value As String)
            _UltimoValorValidado = value
            _UltimoValorCambiado = value
        End Set
    End Property


    Private _TxDatoInicioSemana As TxDato = Nothing
    Public Property TxDatoInicioSemana As TxDato
        Get
            Return _TxDatoInicioSemana
        End Get
        Set(value As TxDato)
            _TxDatoInicioSemana = value
        End Set
    End Property


    Private _TxDatoFinalSemana As TxDato = Nothing
    Public Property TxDatoFinalSemana As TxDato
        Get
            Return _TxDatoFinalSemana
        End Get
        Set(value As TxDato)
            _TxDatoFinalSemana = value
        End Set
    End Property


    Dim _ClForm As Object
    Public Property ClForm As Object
        Set(ByVal value As Object)
            Try
                _ClForm = value

            Catch ex As Exception
                err.Muestraerror("No se pudo guardar clform", "Set Property clform", ex.Message)
                _ClForm = Nothing
            End Try

        End Set
        Get
            Try
                Return _ClForm
            Catch ex As Exception
                err.Muestraerror("No se pudo devolver clform", "Get Property clform", ex.Message)
                Return Nothing
            End Try

        End Get
    End Property
    Dim _Error As Boolean

    Public Property MiError As Boolean
        Set(ByVal value As Boolean)
            _Error = value

        End Set
        Get
            Return _Error

        End Get
    End Property

    Dim _SaltoAlfinal As Boolean

    Public Property SaltoAlfinal As Boolean
        Set(ByVal value As Boolean)
            _SaltoAlfinal = value

        End Set
        Get
            Return _SaltoAlfinal

        End Get
    End Property


    Dim _TeclaRepetida As Boolean

    Public Property TeclaRepetida As Boolean
        Set(ByVal value As Boolean)
            _TeclaRepetida = value

        End Set
        Get
            Return _TeclaRepetida

        End Get
    End Property

    Dim _Autonumerico As Boolean

    Public Property Autonumerico As Boolean
        Set(ByVal value As Boolean)
            _Autonumerico = value

        End Set
        Get
            Return _Autonumerico

        End Get
    End Property


    Dim _Bloqueado As Boolean
    Public Property Bloqueado As Boolean
        Set(ByVal value As Boolean)
            _Bloqueado = value

        End Set
        Get
            Return _Bloqueado

        End Get
    End Property


    Dim _Buscando As Boolean
    Public Property Buscando As Boolean
        Set(ByVal value As Boolean)
            _Buscando = value
        End Set
        Get
            Return _Buscando

        End Get

    End Property


    Public Property HaCambiado As Boolean
        Set(value As Boolean)
            'Sin uso
        End Set
        Get
            If Not IsNothing(_UltimoValorCambiado) Then
                Return _UltimoValorCambiado.ToUpper.Trim <> Me.Text.ToUpper.Trim
            Else
                Return Me.Text.ToUpper.Trim <> ""
            End If
        End Get
    End Property


    Dim _GridLin As ClGrid
    Public Property GridLin As ClGrid
        Set(ByVal value As ClGrid)
            _GridLin = value

        End Set
        Get
            Return _GridLin

        End Get
    End Property


    Dim _LBBusca As Lb

    Public Property lbbusca As Lb
        Set(ByVal value As Lb)
            _LBBusca = value

        End Set
        Get
            Return _LBBusca

        End Get
    End Property


    Dim _Orden As Integer

    Public Property Orden As Integer
        Set(ByVal value As Integer)
            _Orden = value

        End Set
        Get
            Return _Orden

        End Get
    End Property

    Dim _Siguiente As Integer

    Public Property Siguiente As Integer
        Set(ByVal value As Integer)
            _Siguiente = value

        End Set
        Get
            Return _Siguiente

        End Get
    End Property


    Dim _Mcadena As String

    Private Property Mcadena As String
        Set(ByVal value As String)
            _Mcadena = value

        End Set
        Get

            _Mcadena = ""
            Select Case ClParam.Tipo
                Case Cdatos.TiposCampo.EnteroPositivo, Cdatos.TiposCampo.CadenaNumero, Cdatos.TiposCampo.Fecha, TiposCampo.Hora, Cdatos.TiposCampo.Cuenta, Cdatos.TiposCampo.CuentaCliente
                    _Mcadena = "0123456789"
                Case Cdatos.TiposCampo.Entero
                    _Mcadena = "01234567890-"
                Case Cdatos.TiposCampo.Importe
                    _Mcadena = "0123456789.,-"
                Case TiposCampo.FechaHora
                    _Mcadena = "0123456789:/ "
                Case Else
                    _Mcadena = ""

            End Select


            Return _Mcadena

        End Get
    End Property

    Dim _ClParam As Cdatos.PropiedadesTx
    Public Property ClParam As Cdatos.PropiedadesTx

        Set(ByVal value As Cdatos.PropiedadesTx)
            _ClParam = value


        End Set
        Get
            Return _ClParam

        End Get
    End Property


    Protected Overrides Sub [Select](directed As Boolean, forward As Boolean)
        MyBase.[Select](directed, forward)

        Me.SelectAll()

    End Sub



    Private Sub TxDato_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click

    End Sub

    Private Sub TxDato_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus


        If Me.Bloqueado = True Then
            Me.BackColor = Color.Gray
        Else

            Select Case CType(Me.ClForm.tipofrm, ETipoFrm)
                Case ETipoFrm.Mantenimiento
                    If CType(Me.ClForm, FrMantenimiento).Buscando = False Then
                        Me.BackColor = Color.Yellow
                    Else
                        Me.BackColor = Color.Aquamarine
                    End If
                Case Else
                    Me.BackColor = Color.Yellow

            End Select

        End If


        Me.Text = SinMascara(Me.ClParam.Tipo, Me.Text)
        Me.SelectionLength = 0
        Me.SelectionStart = Me.Text.Length
        Siguiente = 0
        If Me._ClParam.Tipo = Cdatos.TiposCampo.Importe Then
            If VaDec(Me.Text) = 0 Then
                Me.Text = ""
            End If
        End If

        Select Case CType(Me.ClForm.tipofrm, ETipoFrm)
            Case ETipoFrm.Mantenimiento
                CType(Me.ClForm, FrMantenimiento).OrdenControl = Me.Orden
            Case ETipoFrm.Consulta
                CType(Me.ClForm, FrConsulta).OrdenControl = Me.Orden

        End Select
        '        Me.ClForm.OrdenControl = Me.Orden


    End Sub

    Private Sub TxDato_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim v As String
        Dim s As Boolean = False


        If Bloqueado = True Then
            If e.KeyCode <> Keys.Down And e.KeyCode <> Keys.Enter And e.KeyCode <> Keys.Tab Then
                e.Handled = True
                Return
            End If
        End If


        If Me.TeclaRepetida = False Then
            Me.TeclaRepetida = True ' no hacer mas opciones hasta que salga del bucle

            If MiError = True Then
                MiError = False
                PintaError()
            End If
            Select Case e.KeyCode
                Case Keys.F2



                    If ClParam.Tipo = TiposCampo.Fecha Then

                        If Not IsNothing(_TxDatoFinalSemana) Then
                            'Selector de semanas
                            Dim frm As New CalendarioSemanal(_TxDatoInicioSemana, _TxDatoFinalSemana)
                            frm.ShowDialog()
                            If frm.Accion <> CalendarioSemanal.Acciones.Cancelar Then
                                s = True
                            End If

                        Else
                            'Selector de fecha
                            Dim frm As New CalendarioSemanal(Me)
                            frm.ShowDialog()
                            If frm.Accion <> CalendarioSemanal.Acciones.Cancelar Then
                                s = True
                            End If

                        End If


                    ElseIf Not ClParam.BtBusca Is Nothing Then
                        v = ClParam.BtBusca.Enlazar

                        If v <> "" Then
                            Select Case ClParam.BtBusca.CL_BuscaAlb
                                Case False
                                    Me.Text = v
                                    s = True

                                Case True



                                    Select Case CType(Me.ClForm.tipofrm, Cdatos.ETipoFrm)
                                        Case Cdatos.ETipoFrm.Mantenimiento
                                            If ClParam.BtBusca.CL_EsId = True Then
                                                CType(Me.ClForm, FrMantenimiento).LbId.Text = v
                                                CType(Me.ClForm, FrMantenimiento).ControlAlb()
                                            Else
                                                Me.Text = v
                                                s = True

                                            End If

                                        Case Cdatos.ETipoFrm.Consulta
                                            Me.Text = v
                                            s = True


                                    End Select
                            End Select


                        End If


                    End If

                Case Keys.F4
                    'Repetición último dato
                    'If Me.Text = "" And Not IsNothing(_UltimoValorValidado) Then
                    '    Me.Text = _UltimoValorValidado
                    '    s = True
                    'End If

                    If Not IsNothing(_UltimoValorValidado) Then

                        Me.Text = _UltimoValorValidado
                        s = True

                        Select Case CType(Me.ClForm.tipofrm, ETipoFrm)
                            Case ETipoFrm.Mantenimiento
                                CType(Me.ClForm, FrMantenimiento).Siguiente(Me.Orden)
                            Case ETipoFrm.Consulta
                                CType(Me.ClForm, FrConsulta).Siguiente(Me.Orden)
                        End Select


                    End If



                Case Keys.F1, Keys.F3, Keys.F5, Keys.F6, Keys.F7, Keys.F8, Keys.F9, Keys.F10, Keys.F11, Keys.F12

                    If Not _DcNoEnviarTecla.ContainsKey(e.KeyCode) Then

                        Select Case CType(Me.ClForm.tipofrm, ETipoFrm)
                            Case ETipoFrm.Mantenimiento
                                CType(Me.ClForm, FrMantenimiento).TeclaFuncion(e.KeyCode, Me)
                            Case ETipoFrm.Consulta
                                CType(Me.ClForm, FrConsulta).TeclaFuncion(e.KeyCode, Me)

                        End Select

                    End If

                Case Keys.Escape
                    If Me.Text = "" Then
                        Me.Text = Me._ValorAnterior
                        Me.SelectAll()
                    Else
                        Me._ValorAnterior = Me.Text
                        Me.Text = ""
                    End If


            End Select


            If e.KeyCode = Keys.Down OrElse e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Tab Then
                s = True
            End If
            If s = True Then


                If Me.Text = "." Then
                    If EsPunto() = True Then
                        Me.Text = ""
                        Me.GridLin.Saliendo = True

                        Select Case CType(Me.ClForm.tipofrm, ETipoFrm)
                            Case ETipoFrm.Mantenimiento
                                CType(Me.ClForm, FrMantenimiento).Siguiente(Me.GridLin.UltimoControl)
                            Case ETipoFrm.Consulta
                                CType(Me.ClForm, FrConsulta).Siguiente(Me.GridLin.UltimoControl)

                        End Select

                        'Me.ClForm.Siguiente(Me.GridLin.UltimoControl)
                        Me.TeclaRepetida = False
                        Exit Sub
                    End If
                End If

                Validar(True)
                If MiError = False Then
                    If Siguiente = 0 Then
                        Select Case CType(Me.ClForm.tipofrm, ETipoFrm)
                            Case ETipoFrm.Mantenimiento
                                CType(Me.ClForm, FrMantenimiento).Siguiente(Orden)
                            Case ETipoFrm.Consulta
                                CType(Me.ClForm, FrConsulta).Siguiente(Orden)

                        End Select

                        ' ClForm.Siguiente(Orden)
                    Else
                        Select Case CType(Me.ClForm.tipofrm, ETipoFrm)
                            Case ETipoFrm.Mantenimiento
                                CType(Me.ClForm, FrMantenimiento).Siguiente(Siguiente - 1)
                            Case ETipoFrm.Consulta
                                CType(Me.ClForm, FrConsulta).Siguiente(Siguiente - 1)

                        End Select

                        '                    ClForm.Siguiente(Siguiente - 1)
                    End If
                End If
            ElseIf e.KeyCode = Keys.Up Then

                Dim mov As Boolean = True
                If Not Me.GridLin Is Nothing Then
                    If Me.GridLin.PrimerControl = Orden Then
                        mov = False

                        Me.GridLin.GridView.Focus()

                    End If
                End If
                If mov = True Then
                    RaiseEvent Atras()
                    If Siguiente = 0 Then
                        Select Case CType(Me.ClForm.tipofrm, ETipoFrm)
                            Case ETipoFrm.Mantenimiento
                                CType(Me.ClForm, FrMantenimiento).Anterior(Orden)
                            Case ETipoFrm.Consulta
                                CType(Me.ClForm, FrConsulta).Anterior(Orden)

                        End Select

                        ' ClForm.Anterior(Orden)
                    Else
                        Select Case CType(Me.ClForm.tipofrm, ETipoFrm)
                            Case ETipoFrm.Mantenimiento
                                CType(Me.ClForm, FrMantenimiento).Anterior(Siguiente + 1)
                            Case ETipoFrm.Consulta
                                CType(Me.ClForm, FrConsulta).Anterior(Siguiente + 1)

                        End Select

                        '                    ClForm.Anterior(Siguiente + 1)
                    End If
                End If
            End If
            Me.TeclaRepetida = False

        End If
    End Sub

    Private Sub TxDato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress


        If Bloqueado = True Then
            If Asc(e.KeyChar) <> Keys.Return Then
                e.KeyChar = ""
                Exit Sub
            End If
        End If


        If Me.TeclaRepetida = False Then

            Me.TeclaRepetida = True ' no hacer mas opciones hasta que salga del bucle


            If Autonumerico = True And e.KeyChar = "+" Then
                Me.TeclaRepetida = False
                Exit Sub
            End If

            If Asc(e.KeyChar) <> Keys.Return Then
                HaCambiado = True
            End If


            If Asc(e.KeyChar) <> Keys.Return And Asc(e.KeyChar) <> 8 Then
                If EsPunto() = False Then ' deja que pulse . por ser primer control de un grid

                    If ClParam.Exclusivos <> "" Then
                        If InStr(ClParam.Exclusivos.ToUpper, e.KeyChar.ToString.ToUpper) = 0 Then
                            e.KeyChar = CChar(String.Empty)
                        Else
                            e.KeyChar = CChar(e.KeyChar.ToString.ToUpper)
                        End If
                    Else
                        If ClParam.Tipo = TiposCampo.Importe Then
                            If e.KeyChar = "." Then
                                e.KeyChar = ","
                            End If
                        End If

                        If Mcadena <> "" And InStr(Mcadena, e.KeyChar) = 0 Then
                            e.KeyChar = CChar(String.Empty)
                        End If

                    End If

                    If Me.Text.Length >= ClParam.Longitud And Me.SelectionLength = 0 Then
                        e.KeyChar = CChar(String.Empty)
                    End If

                Else

                    If ClParam.Exclusivos <> "" Then
                        If InStr(ClParam.Exclusivos.ToUpper + ".", e.KeyChar.ToString.ToUpper) = 0 Then
                            e.KeyChar = CChar(String.Empty)
                        Else
                            e.KeyChar = CChar(e.KeyChar.ToString.ToUpper)
                        End If

                    End If
                    Dim _mcadena As String
                    _mcadena = Mcadena + "."
                    If Mcadena <> "" And InStr(_mcadena, e.KeyChar) = 0 Then
                        e.KeyChar = CChar(String.Empty)
                    End If

                    If Me.Text.Length >= ClParam.Longitud Then
                        e.KeyChar = CChar(String.Empty)
                    End If

                End If
            End If
            Me.TeclaRepetida = False

        End If


        If Asc(e.KeyChar) = Keys.Return Then
            e.Handled = True
        End If

    End Sub


    Private Function EsPunto() As Boolean

        Dim ret As Boolean = False
        If Not Me.GridLin Is Nothing Then

            If Me.Orden = Me.GridLin.PrimerControl And (Me.GridLin.GridView.FocusedRowHandle = Me.GridLin.GridView.RowCount - 1 Or Me.GridLin.GridView.RowCount = 0) Then
                If Me.Text = "" Or Me.Text = "." Then
                    ret = True
                End If
            End If

        End If


        Return ret

    End Function


    Private Sub TxDato_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        If Me.MiError = False Then
            Me.BackColor = Color.White
        End If

        If Autonumerico = False Or Me.Text <> "+" Then
            Me.Text = Mascara(Me.Text, ClParam.Tipo, ClParam.Decimales)
        End If
    End Sub


    Public Sub Validar(ByVal Edicion As Boolean)
        If Autonumerico = True And Me.Text = "+" Then
            MiError = False
        Else
            Select Case ClParam.Tipo
                Case TiposCampo.Fecha
                    If Edicion = True And Me.ClParam.Obligatorio = True And Me.Text = "" Then
                        Me.Text = SinMascara(TiposCampo.Fecha, FnFechaHoy)
                    End If
                    Dim dfecha As String = ""
                    Dim hfecha As String = ""
                    Select Case ClParam.FiltroFecha
                        Case "E"
                            dfecha = MiMaletin.FechaInicioEjercicio.ToShortDateString
                            hfecha = MiMaletin.FechaFinEjercicio.ToShortDateString
                        Case "I" ' iva
                            dfecha = MiMaletin.FechaCtbIva.AddDays(+1).ToShortDateString
                            hfecha = MiMaletin.FechaFinEjercicio.ToShortDateString
                        Case "P" ' cobros / pagos
                            dfecha = MiMaletin.FechaCtbPagos.AddDays(+1).ToShortDateString
                            hfecha = MiMaletin.FechaFinEjercicio.ToShortDateString
                        Case "" ' no comprueba
                            dfecha = ""
                            hfecha = ""
                    End Select
                    Me.Text = FnFecha(SinMascara(TiposCampo.Fecha, Me.Text), dfecha, hfecha)
                    'Dim ff As Date = MiMaletin.FechaCtbIva
                    If Me.Text <> "" Then
                        Me.Text = Mascara(Me.Text, TiposCampo.Fecha)
                    End If

                Case TiposCampo.Hora

                    If Edicion = True And Me.ClParam.Obligatorio = True And Me.Text = "" Then
                        Me.Text = SinMascara(TiposCampo.Hora, Now.ToString("HH:mm:ss"))
                    End If
                    If Me.Text <> "" Then
                        Me.Text = Mascara(Me.Text, TiposCampo.Hora)
                    End If

                Case TiposCampo.FechaHora

                    If Edicion = True And Me.ClParam.Obligatorio = True And Me.Text = "" Then
                        Me.Text = SinMascara(TiposCampo.FechaHora, Now.ToString("dd/MM/yyyy HH:mm:ss"))
                    End If
                    If Me.Text <> "" Then
                        Me.Text = Mascara(Me.Text, TiposCampo.FechaHora)
                    End If

                Case TiposCampo.Cuenta
                    If Me.Text <> "" Then
                        Me.Text = FnCuenta11(Me.Text)
                    End If
                Case TiposCampo.CuentaCliente
                    If Me.Text <> "" Then
                        Me.Text = FnCuentaCliente(Me.Text)
                    End If

            End Select
        End If


        RaiseEvent AntesDeValidar(Edicion)

        If ClParam.Obligatorio = True And Me.Text = "" Then
            MiError = True
        Else
            ValidarEnlace()
            If MiError = False Then
                RaiseEvent Valida(Edicion)
            End If
        End If

        PintaError()


        If Not MiError Then
            _UltimoValorValidado = Me.Text
            _UltimoValorCambiado = Me.Text
            '_UltimoValorValidadoFormulario = Me.Text
        End If

    End Sub



    Private Sub ValidarEnlace()

        RaiseEvent AntesDeValidarEnlace()

        If Not IsNothing(ClParam.LabelEnlace) Then ClParam.LabelEnlace.Text = ""
        If Me.Text = "" Then Exit Sub


        If Not ClParam.Entidadenlace Is Nothing Then
            If ClParam.Entidadenlace.LeerId(Me.Text) = True Then
                ' ClParam.LabelEnlace.Text = ClParam.Entidadenlace.ValorCampoTxt(ClParam.CampoEnlace.NombreCampo)
                If Not IsNothing(ClParam.LabelEnlace) Then
                    ClParam.LabelEnlace.Text = ClParam.CampoEnlace.Valor
                End If
            Else
                MiError = True
            End If
        End If

    End Sub
    Private Sub PintaError()
        If MiError = True Then
            Select Case CType(Me.ClForm.tipofrm, ETipoFrm)
                Case ETipoFrm.Mantenimiento
                    CType(Me.ClForm, FrMantenimiento).PonError(Orden)

                Case ETipoFrm.Consulta
                    CType(Me.ClForm, FrConsulta).PonError(Orden)
            End Select
            Me.HaCambiado = True
            'ClForm.PonError(Orden)
        Else
            Select Case CType(Me.ClForm.tipofrm, ETipoFrm)
                Case ETipoFrm.Mantenimiento
                    CType(Me.ClForm, FrMantenimiento).QuitaError(Orden)
                Case ETipoFrm.Consulta
                    CType(Me.ClForm, FrConsulta).QuitaError(Orden)

            End Select
            ' ClForm.QuitaError(Orden)
        End If
    End Sub


    Public Sub EnviarTecla(tecla As System.Windows.Forms.Keys, enviar As Boolean)

        If Not enviar Then
            _DcNoEnviarTecla(tecla) = True
        Else
            If _DcNoEnviarTecla.ContainsKey(tecla) Then
                _DcNoEnviarTecla.Remove(tecla)
            End If
        End If

    End Sub

End Class

