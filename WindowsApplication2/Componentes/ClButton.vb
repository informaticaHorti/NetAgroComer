Public Class ClButton


    Private _Orden As Integer = 0
    Public Property Orden
        Get
            Return _Orden
        End Get
        Set(value)
            _Orden = value
        End Set
    End Property


    ''' <summary>
    ''' Para poder anular la petición de clave desde el formulario
    ''' </summary>
    ''' <remarks></remarks>
    Private _PedirClave As Boolean = True
    Public Property PedirClave As Boolean
        Get
            Return _PedirClave
        End Get
        Set(value As Boolean)
            _PedirClave = value
        End Set
    End Property



    Public Overridable Function ValidaPermiso() As Boolean

        Dim bRes As Boolean = False

        Dim Formulario As Form = Nothing


        Try

            Formulario = Me.FindForm()

            If Not IsNothing(Formulario) Then

                Dim PermisosBotones As New E_PermisosBotones(Idusuario, cn)
                If PermisosBotones.ExisteRegistro(Formulario.Name.ToLower & "." & Me.Name.ToLower) Then

                    Formulario.Enabled = False

                    Dim frm As New FrmClaveBoton(Formulario.Name.ToLower & "." & Me.Name.ToLower)
                    frm.ShowDialog()


                    Select Case frm.Resultado

                        Case FrmClaveBoton.ResultadoClave.Correcta
                            bRes = True

                        Case FrmClaveBoton.ResultadoClave.Incorrecta
                            MsgBox("Clave incorrecta")
                            bRes = False

                        Case FrmClaveBoton.ResultadoClave.Cancelado
                            bRes = False

                    End Select

                Else
                    'Si no existe formulario.boton en la BBDD, no hace falta pedir la clave, le damos permiso
                    bRes = True
                End If

            End If



        Catch ex As Exception

        End Try



        If Not IsNothing(Formulario) Then
            Formulario.Enabled = True
        End If


        Return bRes

    End Function


    Protected Overrides Sub OnClick(e As System.EventArgs)

        Dim bPermitirClick As Boolean = True

        If PedirClave Then
            If ValidaPermiso() Then
                bPermitirClick = True
            Else
                bPermitirClick = False
            End If
        End If


        If bPermitirClick Then
            MyBase.OnClick(e)
        End If

    End Sub


    Protected Overrides Sub OnKeyDown(kevent As System.Windows.Forms.KeyEventArgs)
        MyBase.OnKeyDown(kevent)


        Select Case kevent.KeyCode

            Case Keys.F1, Keys.F2, Keys.F3, Keys.F4, Keys.F5, Keys.F6, Keys.F7, Keys.F8, Keys.F9, Keys.F10, Keys.F11, Keys.F12

                Dim frm As Form = Me.FindForm()
                If Not IsNothing(frm) Then

                    If TypeOf frm Is FrMantenimiento Then
                        CType(frm, FrMantenimiento).TeclaFuncion(kevent.KeyCode, Me)
                    ElseIf TypeOf frm Is FrConsulta Then
                        CType(frm, FrConsulta).TeclaFuncion(kevent.KeyCode, Me)
                    End If

                End If

        End Select

    End Sub



End Class
