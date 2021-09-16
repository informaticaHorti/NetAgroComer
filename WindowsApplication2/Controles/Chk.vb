Public Class Chk
    Inherits CheckBox
    Dim _clForm As Object
    Dim _ValorDefecto As Boolean

    Public Event Valida(ByVal edicion As Boolean)
    Public Property ClForm As Object
        Set(ByVal value As Object)
            Try
                _clForm = value

            Catch ex As Exception
                _clForm = Nothing
            End Try

        End Set
        Get
            Try
                Return _clForm
            Catch ex As Exception
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

    Dim _Orden As Integer

    Public Property Orden As Integer
        Set(ByVal value As Integer)
            _Orden = value

        End Set
        Get
            Return _Orden

        End Get
    End Property

    Dim _Entidad As Cdatos.Entidad

    Public Property MiEntidad As Cdatos.Entidad
        Set(ByVal value As Cdatos.Entidad)
            _Entidad = value

        End Set
        Get
            Return _Entidad

        End Get
    End Property

    Dim _CampoBd As Cdatos.bdcampo

    Public Property Campobd As Cdatos.bdcampo
        Set(ByVal value As Cdatos.bdcampo)
            _CampoBd = value

        End Set
        Get
            Return _CampoBd

        End Get
    End Property
    Dim _ValorCampoTrue As String
    Public Property ValorCampoTrue As String
        Set(ByVal value As String)
            _ValorCampoTrue = value

        End Set
        Get
            Return _ValorCampoTrue

        End Get
    End Property

    Dim _ValorCampoFalse As String
    Public Property ValorCampoFalse As String
        Set(ByVal value As String)
            _ValorCampoFalse = value

        End Set
        Get
            Return _ValorCampoFalse

        End Get
    End Property

    Public Property ValorDefecto As Boolean
        Set(ByVal value As Boolean)
            _ValorDefecto = value

        End Set
        Get
            Return _ValorDefecto

        End Get
    End Property

    Public Sub Validar(ByVal Edicion As Boolean)
        RaiseEvent Valida(Edicion)

    End Sub

    Private Sub Chk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        HaCambiado = True
    End Sub

    Private Sub Chk_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus

        Me.BackColor = Color.Yellow


    End Sub
    Private Sub Chk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Down OrElse e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Tab Then
            'Validar(True)
            If MiError = False Then

                Select Case CType(Me.ClForm.tipofrm, Cdatos.ETipoFrm)
                    Case Cdatos.ETipoFrm.Mantenimiento
                        CType(Me.ClForm, FrMantenimiento).Siguiente(Orden)
                    Case Cdatos.ETipoFrm.Consulta
                        CType(Me.ClForm, FrConsulta).Siguiente(Orden)


                End Select

                '                ClForm.Siguiente(Orden)
            End If
        ElseIf e.KeyCode = Keys.Up Then
            Select Case CType(Me.ClForm.tipofrm, Cdatos.ETipoFrm)
                Case Cdatos.ETipoFrm.Mantenimiento
                    CType(Me.ClForm, FrMantenimiento).Anterior(Orden)
                Case Cdatos.ETipoFrm.Consulta
                    CType(Me.ClForm, FrConsulta).Anterior(Orden)

            End Select

            'ClForm.Anterior(Orden)
        End If

    End Sub

    Private Sub Chk_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.BackColor = Color.Transparent
    End Sub
End Class
