Public Class FrmWebBrowser


    Private _Padre As _FrMPrincipal = Nothing


    Private DcCompleted As New Dictionary(Of String, Boolean)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub





    Private Sub FrmWebBrowser_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated

        AjustaFormulario()

    End Sub


    Private Sub AjustaFormulario()

        Dim ancho As Single = MdiParent.ClientRectangle.Width - 4
        Dim alto As Single = MdiParent.ClientRectangle.Height - 114

        Me.Left = 0
        Me.Top = 0
        Me.Width = ancho
        Me.Height = alto


    End Sub


    Private Sub FrmWebBrowser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load





        _Padre = Me.MdiParent

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

            If Url1 <> "" Or Url2 <> "" Or Url3 <> "" Or Url4 <> "" Or Url5 <> "" Or Url6 <> "" Or Url7 <> "" Or Url8 <> "" Or Url9 <> "" Or Url10 <> "" Then

                If Url1 <> "" Then
                    Dim DesCripcion As String = (ValoresUsuario.VUS_DescNavegador1.Valor & "").Trim
                    AñadeTabNavegador(1, DesCripcion, Url1)
                End If
                If Url2 <> "" Then
                    Dim DesCripcion As String = (ValoresUsuario.VUS_DescNavegador2.Valor & "").Trim
                    AñadeTabNavegador(2, DesCripcion, Url2)
                End If
                If Url3 <> "" Then
                    Dim DesCripcion As String = (ValoresUsuario.VUS_DescNavegador3.Valor & "").Trim
                    AñadeTabNavegador(3, DesCripcion, Url3)
                End If
                If Url4 <> "" Then
                    Dim DesCripcion As String = (ValoresUsuario.VUS_DescNavegador4.Valor & "").Trim
                    AñadeTabNavegador(4, DesCripcion, Url4)
                End If
                If Url5 <> "" Then
                    Dim DesCripcion As String = (ValoresUsuario.VUS_DescNavegador5.Valor & "").Trim
                    AñadeTabNavegador(5, DesCripcion, Url5)
                End If
                If Url6 <> "" Then
                    Dim DesCripcion As String = (ValoresUsuario.VUS_DescNavegador6.Valor & "").Trim
                    AñadeTabNavegador(6, DesCripcion, Url6)
                End If
                If Url7 <> "" Then
                    Dim DesCripcion As String = (ValoresUsuario.VUS_DescNavegador7.Valor & "").Trim
                    AñadeTabNavegador(7, DesCripcion, Url7)
                End If
                If Url8 <> "" Then
                    Dim DesCripcion As String = (ValoresUsuario.VUS_DescNavegador8.Valor & "").Trim
                    AñadeTabNavegador(8, DesCripcion, Url8)
                End If
                If Url9 <> "" Then
                    Dim DesCripcion As String = (ValoresUsuario.VUS_DescNavegador9.Valor & "").Trim
                    AñadeTabNavegador(9, DesCripcion, Url9)
                End If
                If Url10 <> "" Then
                    Dim DesCripcion As String = (ValoresUsuario.VUS_DescNavegador10.Valor & "").Trim
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

        Dim browser As New WebBrowser
        browser.Name = "WebBrowser" & indice.ToString
        browser.Dock = DockStyle.Fill
        browser.ScriptErrorsSuppressed = True
        browser.ScrollBarsEnabled = True

        'AddHandler browser.Navigating, AddressOf InicioNavegacion
        'AddHandler browser.DocumentCompleted, addressof FinNavegacion

        AddHandler browser.ProgressChanged, AddressOf ProgressChanged
        AddHandler browser.DocumentCompleted, AddressOf DocumentCompleted


        pnlWebBrowser.Controls.Add(browser)

        _Padre.DcUrlNavegador(tab.Name) = url
        DcCompleted(tab.Name.Replace("Tab", "WebBrowser")) = False

    End Sub


    Private Sub bw_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs)

        Me.Invoke(New CargaPaginasNavegador_Delegate(AddressOf CargaPaginasNavegador))

        Application.DoEvents()

    End Sub


    Private Sub ProgressChanged()
        Application.DoEvents()
    End Sub


    Private Sub DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

        Application.DoEvents()


        Dim Navegador As String = CType(sender, WebBrowser).Name
        DcCompleted(Navegador) = True


        Dim completo As Boolean = True

        For Each nav As String In DcCompleted.Keys
            If Not DcCompleted(nav) Then
                completo = False
                Exit For
            End If
        Next

        If completo Then
            _Padre.HabilitaPermisos()
        End If

    End Sub


    Protected Delegate Sub CargaPaginasNavegador_Delegate()
    Private Sub CargaPaginasNavegador()

        For Each NombreTab As String In _Padre.DcUrlNavegador.Keys

            Dim url As String = _Padre.DcUrlNavegador(NombreTab)


            Dim navegador As String = NombreTab.Replace("Tab", "WebBrowser")
            Dim control As Control() = pnlWebBrowser.Controls.Find(navegador, False)

            If control.Length > 0 Then

                If TypeOf control(0) Is WebBrowser Then

                    Application.DoEvents()

                    Dim browser As WebBrowser = CType(control(0), WebBrowser)
                    browser.Navigate(_Padre.DcUrlNavegador(NombreTab))

                    Application.DoEvents()

                End If

            End If

        Next

    End Sub


    

    Private Sub FrmWebBrowser_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        e.Cancel = True
        Me.Hide()

    End Sub


End Class