

Imports ContaNet.Cdatos





Public Class TxDato
    
    Inherits TextBox


    Dim err As Errores


    Public Event Valida(ByVal edicion As Boolean)
    Public Event Atras()



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

    Dim _Autonumerico As Boolean

    Public Property Autonumerico As Boolean
        Set(ByVal value As Boolean)
            _Autonumerico = value

        End Set
        Get
            Return _Autonumerico

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
    Dim _HaCambiado As Boolean

    Public Property HaCambiado As Boolean
        Set(ByVal value As Boolean)
            _HaCambiado = value

        End Set
        Get
            Return _HaCambiado

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
              Select ClParam.Tipo
                Case TiposCampo.Entero, TiposCampo.CadenaNumero, TiposCampo.Fecha, TiposCampo.Cuenta, TiposCampo.CuentaCliente
                    _Mcadena = "0123456789"
                Case TiposCampo.EnteroPositivo
                    _Mcadena = "01234567890-"
                Case TiposCampo.Importe
                    _Mcadena = "0123456789.,-"
                Case Else
                    _Mcadena = ""

            End Select


            Return _Mcadena

        End Get
    End Property

    Dim _ClParam As PropiedadesTx
    Public Property ClParam As PropiedadesTx

        Set(ByVal value As PropiedadesTx)
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
        Select CType(Me.ClForm.tipofrm, ETipoFrm)
            Case ETipoFrm.Mantenimiento
                If CType(Me.ClForm, FrMantenimiento).Buscando = False Then
                    Me.BackColor = Color.Yellow
                Else
                    Me.BackColor = Color.Aquamarine
                End If
            Case Else
                Me.BackColor = Color.Yellow

        End Select
        Me.Text = SinMascara(Me.ClParam.Tipo, Me.Text)
        Me.SelectionLength = 0
        Me.SelectionStart = Me.Text.Length
        Siguiente = 0
        Me.HaCambiado = False
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

        If MiError = True Then
            MiError = False
            PintaError()
        End If
        If e.KeyCode = Keys.F2 Then
            If Not ClParam.BtBusca Is Nothing Then
                v = ClParam.BtBusca.Enlazar
                If v <> "" Then
                    Me.Text = v
                    s = True
                End If
            End If
        End If
     

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
    End Sub

    Private Sub TxDato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If Autonumerico = True And e.KeyChar = "+" Then
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

                If Me.Text.Length >= ClParam.Longitud Then
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
                If Me.Text.Length >= ClParam.Longitud Then
                    e.KeyChar = CChar(String.Empty)
                End If

            End If
        End If

    End Sub
    Private Function EsPunto() As Boolean
        Dim ret As Boolean = False
        If Not Me.GridLin Is Nothing Then

            If Me.Orden = Me.GridLin.PrimerControl And Me.GridLin.GridView.FocusedRowHandle = Me.GridLin.GridView.RowCount - 1 Then
                ret = True

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
                    Me.Text = FnFecha(SinMascara(TiposCampo.Fecha, Me.Text))
                    If Me.Text <> "" Then
                        Me.Text = Mascara(Me.Text, TiposCampo.Fecha)
                    End If
                Case TiposCampo.Cuenta
                    If Me.Text <> "" Then
                        Me.Text = fncuenta11(Me.Text)
                    End If
                Case TiposCampo.CuentaCliente
                    If Me.Text <> "" Then
                        Me.Text = fncuentaCliente(Me.Text)
                    End If

            End Select
        End If
        If ClParam.Obligatorio = True And Me.Text = "" Then
            MiError = True
        Else
            ValidarEnlace()
            If MiError = False Then
                RaiseEvent Valida(Edicion)
            End If
        End If

        PintaError()

    End Sub
    Private Sub ValidarEnlace()
        If Me.Text = "" Then Exit Sub
        If Not ClParam.Entidadenlace Is Nothing Then
            If ClParam.Entidadenlace.LeerId(Me.Text) = True Then
                ' ClParam.LabelEnlace.Text = ClParam.Entidadenlace.ValorCampoTxt(ClParam.CampoEnlace.NombreCampo)
                ClParam.LabelEnlace.Text = ClParam.CampoEnlace.Valor
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
End Class

