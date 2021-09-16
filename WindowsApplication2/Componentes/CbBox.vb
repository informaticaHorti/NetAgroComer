﻿Public Class CbBox
    Inherits ComboBox

    Dim _ClForm As Object
    Dim err As New Errores
    Public Event Valida(ByVal edicion As Boolean)


    Private _DesHabilitarRuedaRaton As Boolean = False
    Public Property DeshabilitarRuedaRaton As Boolean
        Get
            Return _DesHabilitarRuedaraton
        End Get
        Set(value As Boolean)
            _DesHabilitarRuedaraton = value
        End Set
    End Property



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

    Private Sub CbBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.BackColor = Color.Yellow
        'Me.DroppedDown = True
    End Sub


    Private Sub CbBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Validar(True)
            If MiError = False Then

                If Not ClForm Is Nothing Then
                    Select Case CType(Me.ClForm.tipofrm, Cdatos.ETipoFrm)
                        Case Cdatos.ETipoFrm.Mantenimiento
                            CType(Me.ClForm, FrMantenimiento).Siguiente(Orden)
                        Case Cdatos.ETipoFrm.Consulta
                            CType(Me.ClForm, FrConsulta).Siguiente(Orden)

                    End Select

                    'ClForm.Siguiente(Orden)
                End If
            End If

        Else

            Select Case e.KeyCode

                Case Keys.F1, Keys.F2, Keys.F3, Keys.F4, Keys.F5, Keys.F6, Keys.F7, Keys.F8, Keys.F9, Keys.F10, Keys.F11, Keys.F12

                    Dim frm As Form = Me.FindForm()
                    If Not IsNothing(frm) Then

                        If TypeOf frm Is FrMantenimiento Then
                            CType(frm, FrMantenimiento).TeclaFuncion(e.KeyCode, Me)
                        ElseIf TypeOf frm Is FrConsulta Then
                            CType(frm, FrConsulta).TeclaFuncion(e.KeyCode, Me)
                        End If

                    End If

            End Select

        End If

    End Sub

    Public Sub Validar(ByVal Edicion As Boolean)
        If Me.SelectedItem Is Nothing Then
            Me.MiError = True
        End If
        If Me.MiError = False Then
            RaiseEvent Valida(Edicion)
        End If

    End Sub

    Private Sub CbBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.BackColor = Color.White
    End Sub

    Private Sub CbBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedValueChanged
        MiError = False
    End Sub


    Protected Overrides Sub OnMouseWheel(ByVal e As MouseEventArgs)
        If _DesHabilitarRuedaraton Then
            Dim mwe As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
            mwe.Handled = True
        End If
    End Sub

End Class
