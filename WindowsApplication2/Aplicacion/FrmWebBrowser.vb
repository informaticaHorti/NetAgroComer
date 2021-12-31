Imports CefSharp
Imports CefSharp.WinForms

Public Class FrmWebBrowser


    Private _Padre As _FrMPrincipal = Nothing
    'Private _browser As ChromiumWebBrowser = Nothing


    Private DcCompleted As New Dictionary(Of String, Boolean)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()


        Dim settings As New CefSettings()
        settings.CefCommandLineArgs.Add("disable-gpu", "1")
        settings.Locale = "es"

        CefSharp.Cef.Initialize(settings, True, Nothing)




    End Sub


    Public Sub New(parent As Form)
        Me.New()

        _Padre = parent

        AjustaFormulario()

    End Sub




    'Public Sub New(parent As Form)
    '    Me.New()


    '    Dim settings As New CefSettings()
    '    settings.CefCommandLineArgs.Add("disable-gpu", "1")
    '    CefSharp.Cef.Initialize(settings, True, Nothing)

    '    _browser = New ChromiumWebBrowser("")



    '    _Padre = parent

    '    AjustaFormulario()

    '    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    '    _browser.Dock = DockStyle.Fill
    '    _browser.BackColor = pnlWebBrowser.BackColor
    '    pnlWebBrowser.Controls.Add(_browser)

    '    AddHandler _browser.LoadingStateChanged, AddressOf _browser_LoadingStateChanged


    'End Sub


    Private Sub FrmWebBrowser_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated

        AjustaFormulario()

    End Sub


    Public Sub AjustaFormulario()

        Dim ancho As Single = GetMdiClientWindowSize.Width - 4
        Dim alto As Single = GetMdiClientWindowSize.Height - 4

        Me.Width = ancho
        Me.Height = alto

        Me.Top = 0
        Me.Left = 0

        Application.DoEvents()

    End Sub


    Private Sub FrmWebBrowser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        '_Padre = Me.MdiParent

        If Not IsNothing(_Padre) Then
            CargaNavegador()
        End If

    End Sub


    Private Sub CargaNavegador()


        'Navegador Menú Principal
        Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)
        If ValoresUsuario.LeerId(Idusuario.ToString) Then

            Dim Url1 As String = (ValoresUsuario.VUS_UrlNavegador1.Valor & "").Trim
            Dim Url2 As String = (ValoresUsuario.VUS_UrlNavegador2.Valor & "").Trim
            Dim Url3 As String = (ValoresUsuario.VUS_UrlNavegador3.Valor & "").Trim
            Dim Url4 As String = (ValoresUsuario.VUS_UrlNavegador4.Valor & "").Trim
            Dim Url5 As String = (ValoresUsuario.VUS_UrlNavegador5.Valor & "").Trim
            Dim Url6 As String = (ValoresUsuario.VUS_UrlNavegador6.Valor & "").Trim
            Dim Url7 As String = (ValoresUsuario.VUS_UrlNavegador7.Valor & "").Trim
            Dim Url8 As String = (ValoresUsuario.VUS_UrlNavegador8.Valor & "").Trim
            Dim Url9 As String = (ValoresUsuario.VUS_UrlNavegador9.Valor & "").Trim
            Dim Url10 As String = (ValoresUsuario.VUS_UrlNavegador10.Valor & "").Trim

            Dim DescUrl1 As String = (ValoresUsuario.VUS_DescNavegador1.Valor & "").Trim
            Dim DescUrl2 As String = (ValoresUsuario.VUS_DescNavegador2.Valor & "").Trim
            Dim DescUrl3 As String = (ValoresUsuario.VUS_DescNavegador3.Valor & "").Trim
            Dim DescUrl4 As String = (ValoresUsuario.VUS_DescNavegador4.Valor & "").Trim
            Dim DescUrl5 As String = (ValoresUsuario.VUS_DescNavegador5.Valor & "").Trim
            Dim DescUrl6 As String = (ValoresUsuario.VUS_DescNavegador6.Valor & "").Trim
            Dim DescUrl7 As String = (ValoresUsuario.VUS_DescNavegador7.Valor & "").Trim
            Dim DescUrl8 As String = (ValoresUsuario.VUS_DescNavegador8.Valor & "").Trim
            Dim DescUrl9 As String = (ValoresUsuario.VUS_DescNavegador9.Valor & "").Trim
            Dim DescUrl10 As String = (ValoresUsuario.VUS_DescNavegador10.Valor & "").Trim




            If Url1 <> "" Or Url2 <> "" Or Url3 <> "" Or Url4 <> "" Or Url5 <> "" Or Url6 <> "" Or Url7 <> "" Or Url8 <> "" Or Url9 <> "" Or Url10 <> "" Then

                If Url1 <> "" Then
                    Dim DesCripcion As String = DescUrl1
                    AñadeTabNavegador(1, DesCripcion, Url1)
                End If
                If Url2 <> "" Then
                    Dim DesCripcion As String = DescUrl2
                    AñadeTabNavegador(2, DesCripcion, Url2)
                End If
                If Url3 <> "" Then
                    Dim DesCripcion As String = DescUrl3
                    AñadeTabNavegador(3, DesCripcion, Url3)
                End If
                If Url4 <> "" Then
                    Dim DesCripcion As String = DescUrl4
                    AñadeTabNavegador(4, DesCripcion, Url4)
                End If
                If Url5 <> "" Then
                    Dim DesCripcion As String = DescUrl5
                    AñadeTabNavegador(5, DesCripcion, Url5)
                End If
                If Url6 <> "" Then
                    Dim DesCripcion As String = DescUrl6
                    AñadeTabNavegador(6, DesCripcion, Url6)
                End If
                If Url7 <> "" Then
                    Dim DesCripcion As String = DescUrl7
                    AñadeTabNavegador(7, DesCripcion, Url7)
                End If
                If Url8 <> "" Then
                    Dim DesCripcion As String = DescUrl8
                    AñadeTabNavegador(8, DesCripcion, Url8)
                End If
                If Url9 <> "" Then
                    Dim DesCripcion As String = DescUrl9
                    AñadeTabNavegador(9, DesCripcion, Url9)
                End If
                If Url10 <> "" Then
                    Dim DesCripcion As String = DescUrl10
                    AñadeTabNavegador(10, DesCripcion, Url10)
                End If


                'CargaPaginasNavegador()
                Dim bw As New System.ComponentModel.BackgroundWorker
                AddHandler bw.DoWork, AddressOf bw_DoWork


                pnlWebBrowser.Visible = True
                bw.RunWorkerAsync()


            End If

        End If


    End Sub


    Private Sub AñadeTabNavegador(indice As Integer, texto As String, url As String)

        Dim tab As New TabPage
        tab.Name = "Tab" & indice.ToString
        tab.Text = texto
        _Padre.TabWebBrowser.TabPages.Add(tab)


        Dim browser As New ChromiumWebBrowser("")

        'Dim browser As New WebBrowser
        browser.Name = "WebBrowser" & indice.ToString
        browser.Dock = DockStyle.Fill
        browser.BackColor = pnlWebBrowser.BackColor
        pnlWebBrowser.Controls.Add(browser)

        AddHandler browser.LoadingStateChanged, AddressOf _browser_LoadingStateChanged
        AddHandler browser.FrameLoadEnd, AddressOf _browser_FrameLoadEnd

        browser.KeyboardHandler = New KeyboardHandler()


        'browser.ScriptErrorsSuppressed = True
        'browser.ScrollBarsEnabled = True

        'AddHandler browser.Navigating, AddressOf InicioNavegacion
        'AddHandler browser.DocumentCompleted, addressof FinNavegacion

        'AddHandler browser.ProgressChanged, AddressOf ProgressChanged
        'AddHandler browser.DocumentCompleted, AddressOf DocumentCompleted


        pnlWebBrowser.Controls.Add(browser)

        _Padre.DcUrlNavegador(tab.Name) = url
        DcCompleted(tab.Name.Replace("Tab", "WebBrowser")) = False

    End Sub


    Private Sub FrmWebBrowser_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        '_Padre.pnlTabWebBrowser.Visible = True

    End Sub


    Private Sub bw_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw.DoWork

        Me.Invoke(New CargaPaginasNavegador_Delegate(AddressOf CargaPaginasNavegador))
        Application.DoEvents()

    End Sub


    'Private Sub ProgressChanged()
    '    Application.DoEvents()
    'End Sub


    'Private Sub DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

    '    Application.DoEvents()


    '    Dim Navegador As String = CType(sender, WebBrowser).Name
    '    DcCompleted(Navegador) = True


    '    Dim completo As Boolean = True

    '    For Each nav As String In DcCompleted.Keys
    '        If Not DcCompleted(nav) Then
    '            completo = False
    '            Exit For
    '        End If
    '    Next

    '    If completo Then
    '        _Padre.HabilitaPermisos()
    '    End If

    'End Sub


    Protected Delegate Sub CargaPaginasNavegador_Delegate()
    Private Sub CargaPaginasNavegador()


        For Each NombreTab As String In _Padre.DcUrlNavegador.Keys

            Dim url As String = _Padre.DcUrlNavegador(NombreTab)


            Dim navegador As String = NombreTab.Replace("Tab", "WebBrowser")
            Dim control As Control() = pnlWebBrowser.Controls.Find(navegador, False)

            If control.Length > 0 Then

                If TypeOf control(0) Is ChromiumWebBrowser Then

                    Application.DoEvents()

                    Dim browser As ChromiumWebBrowser = CType(control(0), ChromiumWebBrowser)
                    'browser.Navigate(_Padre.DcUrlNavegador(NombreTab))
                    browser.Load(_Padre.DcUrlNavegador(NombreTab))

                    Application.DoEvents()

                End If

            End If

        Next


    End Sub


    Private Sub FrmWebBrowser_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        e.Cancel = True
        Me.Hide()

    End Sub


    Public Function GetMdiClientWindowSize() As Size

        For Each ctl As Control In _Padre.Controls
            If TypeOf ctl Is MdiClient Then
                Return ctl.Size
            End If
        Next

        Return Nothing

    End Function


    Public Sub ActualizaUrl()

        Me.Invoke(New CargaPaginasNavegador_Delegate(AddressOf CargaPaginasNavegador))
        Application.DoEvents()

    End Sub


    Private Sub _browser_LoadingStateChanged(sender As Object, e As CefSharp.LoadingStateChangedEventArgs)

        If e.Browser.HasDocument Then

            'CType(sender, ChromiumWebBrowser).SetZoomLevel(0.25)

            Dim Navegador As String = CType(sender, ChromiumWebBrowser).Name
            DcCompleted(Navegador) = True


            Dim completo As Boolean = True

            For Each nav As String In DcCompleted.Keys
                If Not DcCompleted(nav) Then
                    completo = False
                    Exit For
                End If
            Next

            'If completo Then
            '    Me.Invoke(New __FrMPrincipal.HabilitaPermisos_Delegate(AddressOf _Padre.HabilitaPermisos))
            'End If

            Application.DoEvents()
            If completo Then
                Me.Invoke(New FrmWebBrowser.MuestraNavegador_Delegate(AddressOf Me.MuestraNavegador))
            End If



        Else
            Application.DoEvents()
        End If

    End Sub


    Private Sub _browser_FrameLoadEnd(ByVal sender As Object, ByVal frameLoadEndEventArgs As FrameLoadEndEventArgs)

        Dim browser As ChromiumWebBrowser = CType(sender, ChromiumWebBrowser)
        browser.SetZoomLevel(-0.5)

    End Sub





    Public Delegate Sub MuestraNavegador_Delegate()
    Public Sub MuestraNavegador()

        Application.DoEvents()
        _Padre.HabilitaPermisos()

    End Sub


    Public Sub CambiaZoom(ByVal valor As Decimal)



        Dim Tab As TabPage = _Padre.TabWebBrowser.SelectedTab
        If Not IsNothing(Tab) Then

            Dim NombreTab As String = Tab.Name


            Dim navegador As String = NombreTab.Replace("Tab", "WebBrowser")
            Dim control As Control() = pnlWebBrowser.Controls.Find(navegador, False)

            If control.Length > 0 Then

                If TypeOf control(0) Is ChromiumWebBrowser Then

                    Application.DoEvents()

                    Dim browser As ChromiumWebBrowser = CType(control(0), ChromiumWebBrowser)
                    browser.SetZoomLevel(valor)
                    Application.DoEvents()

                    _Padre.LbZoom.Text = valor.ToString


                End If

            End If


        End If


    End Sub





    Private Sub FrmWebBrowser_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim a As String = ""
    End Sub

    Private Sub FrmWebBrowser_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim a As String = ""
    End Sub

    Private Sub FrmWebBrowser_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles MyBase.PreviewKeyDown
        Dim a As String = ""
    End Sub
End Class


Public Class KeyboardHandler
    Implements IKeyboardHandler


    Public Function OnPreKeyEvent(ByVal chromiumWebBrowser As CefSharp.IWebBrowser, ByVal browser As CefSharp.IBrowser, ByVal type As CefSharp.KeyType, ByVal windowsKeyCode As Integer,
                                 ByVal nativeKeyCode As Integer, ByVal modifiers As CefSharp.CefEventFlags, ByVal isSystemKey As Boolean, ByRef isKeyboardShortcut As Boolean) As Boolean Implements IKeyboardHandler.OnPreKeyEvent


        Const WM_SYSKEYDOWN As Integer = &H104
        Const WM_KEYDOWN As Integer = &H100
        Const WM_KEYUP As Integer = &H101
        Const WM_SYSKEYUP As Integer = &H105
        Const WM_CHAR As Integer = &H102
        Const WM_SYSCHAR As Integer = &H106
        Const VK_TAB As Integer = &H9
        Dim result As Boolean = False
        isKeyboardShortcut = False

        Dim bCtrlTab As Boolean = False


        If windowsKeyCode = VK_TAB Then
            If modifiers = CefEventFlags.ControlDown Then
                bCtrlTab = True
            End If
            'Return result
        End If


        Dim control As Control = TryCast(chromiumWebBrowser, Control)
        Dim msgType As Integer = 0

        Select Case type
            Case KeyType.RawKeyDown

                If isSystemKey Then
                    msgType = WM_SYSKEYDOWN
                Else
                    msgType = WM_KEYDOWN
                End If

            Case KeyType.KeyUp

                If isSystemKey Then
                    msgType = WM_SYSKEYUP
                Else
                    msgType = WM_KEYUP
                End If

            Case KeyType.Char

                If isSystemKey Then
                    msgType = WM_SYSCHAR
                Else
                    msgType = WM_CHAR
                End If

            Case Else
                Trace.Assert(False)
        End Select

        Dim state As PreProcessControlState = PreProcessControlState.MessageNotNeeded
        control.Invoke(New Action(Function()
                                      Dim msg As Message = New Message() With {
                                          .HWnd = control.Handle,
                                          .Msg = msgType,
                                          .WParam = New IntPtr(windowsKeyCode),
                                          .LParam = New IntPtr(nativeKeyCode)
                                      }
                                      Dim processed As Boolean = Application.FilterMessage(msg)

                                      If processed Then
                                          state = PreProcessControlState.MessageProcessed
                                      Else
                                          state = control.PreProcessControlMessage(msg)
                                      End If

                                      Return True

                                  End Function))

        If state = PreProcessControlState.MessageNeeded Then
            isKeyboardShortcut = True
        ElseIf state = PreProcessControlState.MessageProcessed Then
            result = True
        End If

        Debug.WriteLine(String.Format("OnPreKeyEvent: KeyType: {0} 0x{1:X} Modifiers: {2}", type, windowsKeyCode, modifiers))
        Debug.WriteLine(String.Format("OnPreKeyEvent PreProcessControlState: {0}", state))


        'Return True
        If bCtrlTab Then
            Return True
        Else
            Return False
        End If


    End Function


    Public Function OnKeyEvent(ByVal chromiumWebBrowser As CefSharp.IWebBrowser, ByVal browser As CefSharp.IBrowser, ByVal type As CefSharp.KeyType, ByVal windowsKeyCode As Integer,
                        ByVal nativeKeyCode As Integer, ByVal modifiers As CefSharp.CefEventFlags, ByVal isSystemKey As Boolean) As Boolean Implements IKeyboardHandler.OnKeyEvent

        Dim result As Boolean = False
        Debug.WriteLine(String.Format("OnKeyEvent: KeyType: {0} 0x{1:X} Modifiers: {2}", type, windowsKeyCode, modifiers))
        Return result

    End Function







    'Public Function OnKeyEvent(ByVal browserControl As IWebBrowser, ByVal browser As IBrowser, ByVal type As KeyType, ByVal windowsKeyCode As Integer, ByVal nativeKeyCode As Integer, ByVal modifiers As CefEventFlags, ByVal isSystemKey As Boolean) As Boolean
    '    Dim result As Boolean = False
    '    Debug.WriteLine(String.Format("OnKeyEvent: KeyType: {0} 0x{1:X} Modifiers: {2}", type, windowsKeyCode, modifiers))
    '    Return result
    'End Function







    'Public Function OnPreKeyEvent(ByVal browserControl As IWebBrowser, ByVal browser As IBrowser, ByVal type As KeyType, ByVal windowsKeyCode As Integer, ByVal nativeKeyCode As Integer,
    '                              ByVal modifiers As CefEventFlags, ByVal isSystemKey As Boolean, ByRef isKeyboardShortcut As Boolean) As Boolean

    '    Const WM_SYSKEYDOWN As Integer = &H104
    '    Const WM_KEYDOWN As Integer = &H100
    '    Const WM_KEYUP As Integer = &H101
    '    Const WM_SYSKEYUP As Integer = &H105
    '    Const WM_CHAR As Integer = &H102
    '    Const WM_SYSCHAR As Integer = &H106
    '    Const VK_TAB As Integer = &H9
    '    Dim result As Boolean = False
    '    isKeyboardShortcut = False

    '    If windowsKeyCode = VK_TAB Then
    '        Return result
    '    End If

    '    Dim control As Control = TryCast(browserControl, Control)
    '    Dim msgType As Integer = 0

    '    Select Case type
    '        Case KeyType.RawKeyDown

    '            If isSystemKey Then
    '                msgType = WM_SYSKEYDOWN
    '            Else
    '                msgType = WM_KEYDOWN
    '            End If

    '        Case KeyType.KeyUp

    '            If isSystemKey Then
    '                msgType = WM_SYSKEYUP
    '            Else
    '                msgType = WM_KEYUP
    '            End If

    '        Case KeyType.Char

    '            If isSystemKey Then
    '                msgType = WM_SYSCHAR
    '            Else
    '                msgType = WM_CHAR
    '            End If

    '        Case Else
    '            Trace.Assert(False)
    '    End Select

    '    Dim state As PreProcessControlState = PreProcessControlState.MessageNotNeeded
    '    control.Invoke(New Action(Function()
    '                                  Dim msg As Message = New Message() With {
    '                                      .HWnd = control.Handle,
    '                                      .Msg = msgType,
    '                                      .WParam = New IntPtr(windowsKeyCode),
    '                                      .LParam = New IntPtr(nativeKeyCode)
    '                                  }
    '                                  Dim processed As Boolean = Application.FilterMessage(msg)

    '                                  If processed Then
    '                                      state = PreProcessControlState.MessageProcessed
    '                                  Else
    '                                      state = control.PreProcessControlMessage(msg)
    '                                  End If
    '                              End Function))

    '    If state = PreProcessControlState.MessageNeeded Then
    '        isKeyboardShortcut = True
    '    ElseIf state = PreProcessControlState.MessageProcessed Then
    '        result = True
    '    End If

    '    Debug.WriteLine(String.Format("OnPreKeyEvent: KeyType: {0} 0x{1:X} Modifiers: {2}", type, windowsKeyCode, modifiers))
    '    Debug.WriteLine(String.Format("OnPreKeyEvent PreProcessControlState: {0}", state))


    '    Return result

    'End Function

End Class

