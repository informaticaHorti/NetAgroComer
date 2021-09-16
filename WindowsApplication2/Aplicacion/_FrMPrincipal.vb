Public Class _FrMPrincipal


    Private err As New Errores
    Private LogMenu As New E_LogMenu(Idusuario, cn)



    Public _frmWebBrowser As FrmWebBrowser = Nothing
    Private _ultimo_frm_activo As Form = Nothing
    Public DcUrlNavegador As New Dictionary(Of String, String)




    Public Event AñadeFormulario(Formulario As Form, Opcion As String)


    Private Sub FrMPrincipal_AñadeFormulario(Formulario As Form, Opcion As String) Handles Me.AñadeFormulario

        'TODO: Comprobar que no abra 2 veces la misma ventana

    End Sub


    Private Sub Familias_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Familias.ItemClick
        'Productos/Generos/Familias
        Dim frm As New FrmFamilias
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub FrMPrincipal_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed


        ' GuardaCopiaContadores()

        Try

            Dim usuarios_logs As New E_Usuarios_Logs(Idusuario, cn)
            usuarios_logs.CierraUsuario(Idusuario)

            Application.ExitThread()

        Catch ex As Exception

        End Try

    End Sub


    Private Sub FrMenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Dim numAleatorio As New Random()

        'For indice As Integer = 0 To 10
        '    Dim valorAleatorio As Integer = numAleatorio.Next(100, 1000)
        '    MsgBox(valorAleatorio.ToString)
        'Next


        'cadenaconexionodbc = LeerConfig(Application.StartupPath & "\Clave.dll", "ConexionNetAgro")
        'cn = New Cdatos.Conexion(cadenaconexionodbc)

        'cadenaconexionComun = LeerConfig(Application.StartupPath & "\Clave.dll", "ConexionComun")
        'CnComun = New Cdatos.Conexion(cadenaconexionComun)

        'cadenaconexionCtb = LeerConfig(Application.StartupPath & "\Clave.dll", "ConexionCtb")
        'CnCtb = New Cdatos.Conexion(cadenaconexionCtb)

        '        cnrrhh = New Cdatos.Conexion("Provider=SQLOLEDB.1;Password=Adminis;Persist Security Info=True;User ID=sa;Initial Catalog=Recursos_humanos;Data Source=W2003SERVERB\SQLEXPRESS")
        'cnrrhh = New Cdatos.Conexion("Driver={SQL Server Native Client 10.0};Server=W2003SERVERB\SQLEXPRESS;Database=Recursos_humanos;Uid=sa;Pwd=Adminis;")
        'cnrrhh = New Cdatos.Conexion("Driver={SQL Server Native Client 10.0};Server=HPMIGUEL\SQLEXPRESS;Database=Recursos_humanos;Uid=sa;Pwd=Adminis;")

        ' Driver={SQL Server Native Client 10.0};Server=W2003SERVERB\SQLEXPRESS;Database=Recursos_humanos;Uid=sa;Pwd=Adminis;

        'ribbon.Manager.UseF10KeyForMenu = false;



        Me.RibbonControl.Manager.UseF10KeyForMenu = False


        CompruebaVersionAplicacion()




        'Navegador Menú Principal
        CargaNavegador()




        If Idusuario <> Usuario_Maestro Then
            PermisosMenus()
        End If



        If bErrorFatal Then
            Application.ExitThread()
        End If


        If UsuarioAdministracion Or Idusuario = Usuario_Maestro Then
            pagAdministracion.Visible = True
        Else
            pagAdministracion.Visible = False
        End If







        Dim SQL As String = ""
        Dim Dt As New DataTable
        Dim Ntabla As String = ""
        ' cargamos las tablas que van a loguearse
        SQL = "Select * from logtablas"
        Dt = cn.ConsultaSQL(SQL)
        If Not Dt Is Nothing Then
            For Each rw As DataRow In Dt.Rows
                Ntabla = rw(0).ToString
                DcLogTablas(Ntabla.ToLower.Trim) = "S"
            Next
        End If


        SQL = "Select * from alertatablas"
        Dt = cn.ConsultaSQL(SQL)
        If Not Dt Is Nothing Then
            For Each rw As DataRow In Dt.Rows
                Ntabla = rw(0).ToString
                DcAltTablas(Ntabla.ToLower.Trim) = "S"
            Next
        End If

        'Carga los puntos de venta
        Dim pventausuario As New E_PventaUsuario(Idusuario, cn)
        Dt = pventausuario.Tabla(Idusuario, MiMaletin.IdEmpresaCTB)
        Dim x As Integer
        For x = 0 To Dt.Rows.Count - 1
            If Dt.Rows(x)(0) IsNot DBNull.Value Then
                BPventa.Strings.Add(Dt.Rows(x)("IdPuntoventa").ToString & " " & Dt.Rows(x)("Nombre").ToString)
            End If
        Next



        'Carga los ejercicios
        Dim Ejercicio As New E_Ejercicios(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        Dt = Ejercicio.Tabla
        For x = 0 To Dt.Rows.Count - 1
            If Dt.Rows(x)(0) IsNot DBNull.Value Then
                BEjercicio.Strings.Add(Dt.Rows(x)("Idejercicio").ToString & " " & Dt.Rows(x)("fechadesde").ToShortDateString & " " & Dt.Rows(x)("fechahasta").ToShortDateString)
            End If
        Next

        'Carga los centros de recogida
        Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)
        Dt = CentrosRecogida.Tabla
        For x = 0 To Dt.Rows.Count - 1
            If Dt.Rows(x)(0) IsNot DBNull.Value Then
                BarListItem1.Strings.Add(Dt.Rows(x)("Idrecogida").ToString & " " & Dt.Rows(x)("Nombre").ToString)
            End If
        Next

        'Carga los programas de calidad
        Dim NormasCalidad As New E_NormasCalidad(Idusuario, cn)
        Dt = NormasCalidad.Tabla
        For x = 0 To Dt.Rows.Count - 1
            If Dt.Rows(x)(0) IsNot DBNull.Value Then
                Bcalidad.Strings.Add(Dt.Rows(x)("IdNorma").ToString & " " & Dt.Rows(x)("Nombre").ToString)
            End If
        Next


        'Carga las empresas
        Dim empresas As New E_Empresas(Idusuario, cn)
        Dt = empresas.Tabla

        For x = 0 To Dt.Rows.Count - 1
            If Dt.Rows(x)(0) IsNot DBNull.Value Then
                BEmpresa.Strings.Add(Dt.Rows(x)("IdEmpresa").ToString & " " & Dt.Rows(x)("Nombre").ToString)
            End If
        Next


        PintaMaletin(MiMaletin.IdEmpresaCTB)


        Dim dia As String = My.Application.Info.Version.Major.ToString
        Dim mes As String = My.Application.Info.Version.Minor.ToString
        Dim año As String = My.Application.Info.Version.Build.ToString
        Dim version As String = My.Application.Info.Version.Revision.ToString


        LbVersion.Caption = "vs. " & dia & "/" & mes & "/" & año & "." & version


        'LbVersion.Caption = "v." & My.Application.Info.Version.ToString()


    End Sub


    Private Sub CompruebaVersionAplicacion()

        'Dim Aplicacion As New E_Aplicacion(Idaplicacion, CnComun)
        'If Aplicacion.LeerId(Idaplicacion) Then
        '    If (Aplicacion.Version.Valor & "").Trim <> LbNumVersion.Caption.Trim Then
        '        '    MsgBox("ATENCIÓN, VERSIÓN DISTINTA A LA EXISTENTE EN LA BASE DE DATOS: " & Aplicacion.Version.Valor)
        '    End If
        'End If

    End Sub




    Public Sub PintaMaletin(idempresa As Integer)

        'Hemos cargado previamente los valores de ejercicio y/o pventa del maletín 
        Dim TextoEjercicio As String = ""
        Dim TextoPVenta As String = ""
        Dim TextoCrecogida As String = ""
        Dim TextoCalidad As String = ""

        MiMaletin.CargaMaletin(idempresa, MiMaletin.Ejercicio, MiMaletin.IdPuntoVenta, MiMaletin.IdCentroRecogida, TextoEjercicio, TextoPVenta, TextoCrecogida, TextoCalidad)


        If VaInt(MiMaletin.IdOperario) = 0 Then

            Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)
            If ValoresUsuario.LeerId(Idusuario) Then
                Dim ValidarUsuario As Boolean = ((ValoresUsuario.VUS_ValidarOperario.Valor & "").Trim = "S")
                If ValidarUsuario Then

                    Dim frm As New FrmIntroducirOperario(Me)
                    frm.ShowDialog()

                    Select Case frm.Respuesta

                        Case FrmIntroducirOperario.RespuestaFormulario.Validar
                            MiMaletin.IdOperario = frm.IdOperario
                            lbOperador.Caption = frm.IdOperario.ToString

                        Case FrmIntroducirOperario.RespuestaFormulario.Salir
                            Application.ExitThread()

                    End Select

                End If
            End If

        End If


        LbEmpresa.Caption = MiMaletin.NombreEmpresa
        LbEjercicio.Caption = MiMaletin.Ejercicio.ToString & " " & TextoEjercicio
        LbPuntoVenta.Caption = MiMaletin.IdPuntoVenta.ToString & " " & TextoPVenta
        LbCrecogida.Caption = MiMaletin.IdCentroRecogida.ToString & " " & TextoCrecogida
        LbCalidad.Caption = MiMaletin.idprogramacliente.ToString & " " & TextoCalidad

        Try

            If Idusuario <> Usuario_Maestro Then

                Dim Usuario As New E_Usuarios(Idusuario, CnComun)
                If Usuario.LeerId(Idusuario) Then

                    Dim CambioEj As String = (Usuario.CambioEjercicio.Valor & "")
                    Dim CambioPV As String = (Usuario.CambioPV.Valor & "")
                    Dim CambioCR As String = (Usuario.CambioCR.Valor & "")

                    If CambioEj <> "S" Then
                        BEjercicio.Enabled = False
                        BEjercicio.AppearanceDisabled.ForeColor = BEjercicio.Appearance.ForeColor
                        BEjercicio.AppearanceDisabled.Font = BEjercicio.Appearance.Font
                    End If

                    If CambioPV <> "S" Then
                        BPventa.Enabled = False
                        BPventa.AppearanceDisabled.ForeColor = BEjercicio.Appearance.ForeColor
                        BPventa.AppearanceDisabled.Font = BEjercicio.Appearance.Font
                    End If

                    If CambioCR <> "S" Then
                        BarListItem1.Enabled = False
                        BarListItem1.AppearanceDisabled.ForeColor = BarListItem1.Appearance.ForeColor
                        BarListItem1.AppearanceDisabled.Font = BarListItem1.Appearance.Font
                    End If

                End If

            End If



        Catch ex As Exception

        End Try


    End Sub


    'Navegador Menú Principal
    Private Sub CargaNavegador()


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

                DesHabilitaPermisos()

                pnlTabWebBrowser.Visible = True

                _frmWebBrowser = New FrmWebBrowser
                _frmWebBrowser.MdiParent = Me
                _frmWebBrowser.Show()


                'HabilitaPermisos()

            End If
        End If

    End Sub


    Private Sub TabWebBrowser_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabWebBrowser.SelectedIndexChanged
        MuestraTab()
    End Sub


    Private Sub TabWebBrowser_Click(sender As System.Object, e As System.EventArgs) Handles TabWebBrowser.Click
        MuestraTab()
    End Sub


    Private Sub MuestraTab()

        If Not IsNothing(_frmWebBrowser) Then

            Dim bEncontrado As Boolean = False

            For Each frm As Form In Application.OpenForms
                If frm Is _frmWebBrowser Then
                    bEncontrado = True
                    Exit For
                End If
            Next


            'Application.DoEvents()
            If Not bEncontrado Then
                _frmWebBrowser.Show()
            Else
                _frmWebBrowser.BringToFront()
                _frmWebBrowser.Refresh()
            End If
            'Application.DoEvents()

        End If



        If Me.ActiveMdiChild IsNot _frmWebBrowser Then
            _ultimo_frm_activo = Me.ActiveMdiChild
        End If


        If TabWebBrowser.TabPages.Count > 0 Then


            Dim NombreTab As String = TabWebBrowser.SelectedTab.Name

            If DcUrlNavegador.ContainsKey(NombreTab) Then

                Dim navegador As String = TabWebBrowser.SelectedTab.Name.Replace("Tab", "WebBrowser")
                Dim control As Control() = _frmWebBrowser.pnlWebBrowser.Controls.Find(navegador, False)

                If control.Length > 0 Then

                    If TypeOf control(0) Is WebBrowser Then

                        Dim browser As WebBrowser = CType(control(0), WebBrowser)
                        browser.BringToFront()
                        Application.DoEvents()

                    End If

                End If

            End If

        End If

    End Sub


    Private Sub btActualizarWebBrowser_Click(sender As System.Object, e As System.EventArgs) Handles btActualizarWebBrowser.Click

        Dim pagina As TabPage = TabWebBrowser.SelectedTab
        If Not IsNothing(pagina) Then

            Dim NombreTab As String = pagina.Name
            Dim navegador As String = NombreTab.Replace("Tab", "WebBrowser")
            Dim control As Control() = _frmWebBrowser.pnlWebBrowser.Controls.Find(navegador, False)

            If control.Length > 0 Then

                If TypeOf control(0) Is WebBrowser Then

                    Application.DoEvents()

                    Dim browser As WebBrowser = CType(control(0), WebBrowser)
                    browser.Refresh()

                    Application.DoEvents()

                End If

            End If


        End If

    End Sub


    Private Sub btVolver_Click(sender As System.Object, e As System.EventArgs) Handles btVolver.Click

        If Not IsNothing(_ultimo_frm_activo) Then
            _ultimo_frm_activo.BringToFront()
            _ultimo_frm_activo.Update()
            'Application.DoEvents()
        End If

    End Sub


    Private Sub DesHabilitaPermisos()

        picCargandoWebBrowser.Visible = True

        'For Each pagina As DevExpress.XtraBars.Ribbon.RibbonPage In RibbonControl.Pages
        '    For Each grupo As DevExpress.XtraBars.Ribbon.RibbonPageGroup In pagina.Groups
        '        For Each item As DevExpress.XtraBars.BarItemLink In grupo.ItemLinks

        '            Dim boton As String = item.Item.Name.ToLower.Trim

        '            If item.Item.GetType().Name.ToLower.Trim = "barbuttonitem" Then
        '                item.Item.Enabled = False
        '            ElseIf item.Item.GetType.Name.ToLower.Trim = "barsubitem" Then

        '                Dim lista As DevExpress.XtraBars.BarSubItem = CType(item.Item, DevExpress.XtraBars.BarSubItem)
        '                For Each sitem As DevExpress.XtraBars.BarItemLink In lista.ItemLinks
        '                    Dim subBoton As String = sitem.Item.Name.ToLower.Trim
        '                    sitem.Item.Enabled = False
        '                Next

        '                item.Item.Enabled = False

        '            End If

        '        Next
        '    Next
        'Next

        RibbonControl.Enabled = False

    End Sub


    Public Sub HabilitaPermisos()

        picCargandoWebBrowser.Visible = False


        RibbonControl.Enabled = True

        'For Each pagina As DevExpress.XtraBars.Ribbon.RibbonPage In RibbonControl.Pages
        '    For Each grupo As DevExpress.XtraBars.Ribbon.RibbonPageGroup In pagina.Groups
        '        For Each item As DevExpress.XtraBars.BarItemLink In grupo.ItemLinks

        '            Dim boton As String = item.Item.Name.ToLower.Trim

        '            If item.Item.GetType().Name.ToLower.Trim = "barbuttonitem" Then
        '                item.Item.Enabled = True
        '            ElseIf item.Item.GetType.Name.ToLower.Trim = "barsubitem" Then

        '                Dim lista As DevExpress.XtraBars.BarSubItem = CType(item.Item, DevExpress.XtraBars.BarSubItem)
        '                For Each sitem As DevExpress.XtraBars.BarItemLink In lista.ItemLinks
        '                    Dim subBoton As String = sitem.Item.Name.ToLower.Trim
        '                    sitem.Item.Enabled = True
        '                Next

        '                item.Item.Enabled = True

        '            End If

        '        Next
        '    Next
        'Next

    End Sub


    Public Sub PermisosMenus()

        'Obtiene los elementos de los menús
        Dim TextoError As String = ""
        Dim dtBotones As DataTable = ObtenerBotonesMenu(Me, TextoError)
        If TextoError.Trim <> "" Then
            err.Muestraerror("Error al obtener los permisos del menú", "frmAdministracionMenus_Load", TextoError)
            bErrorFatal = True
            Exit Sub
        End If


        'Obtiene el perfil del usuario actual
        Dim Us As New E_Usuarios(Idusuario, CnComun)

        If Idusuario <> Usuario_Maestro Then

            Us.LeerId(Idusuario)

            Dim IdPerfil As Integer = VaInt(Us.IdPerfil.Valor)
            If IdPerfil < 1 Then
                err.Muestraerror("Error al obtener el perfil del usuario", "frmAdministracionMenus_Load", TextoError)
                bErrorFatal = True
                Exit Sub
            End If

        End If



        'Habilita / deshabilita los botones del menú
        Dim DcBotonesActivos As New Dictionary(Of String, String)

        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(LogMenu.LOM_Id, "Id")
        CONSULTA.SelCampo(LogMenu.LOM_NombreBoton, "NombreBoton")
        CONSULTA.WheCampo(LogMenu.LOM_IdPerfil, "=", Us.IdPerfil.Valor)

        Dim sql As String = CONSULTA.SQL
        Dim dt As DataTable = LogMenu.MiConexion.ConsultaSQL(sql)

        For Each row As DataRow In dt.Rows
            Dim boton As String = row("NombreBoton").ToString
            DcBotonesActivos(boton.ToLower.Trim) = boton.ToLower.Trim
        Next


        For Each pagina As DevExpress.XtraBars.Ribbon.RibbonPage In RibbonControl.Pages
            For Each grupo As DevExpress.XtraBars.Ribbon.RibbonPageGroup In pagina.Groups
                For Each item As DevExpress.XtraBars.BarItemLink In grupo.ItemLinks

                    Dim boton As String = item.Item.Name.ToLower.Trim

                    If item.Item.GetType().Name.ToLower.Trim = "barbuttonitem" Then
                        If DcBotonesActivos.ContainsKey(boton) Then
                            If item.Item.Enabled Then item.Item.Enabled = True
                        Else
                            item.Item.Enabled = False
                        End If
                    ElseIf item.Item.GetType.Name.ToLower.Trim = "barsubitem" Then

                        Dim bAlgunHijoHabilitado As Boolean = False

                        Dim lista As DevExpress.XtraBars.BarSubItem = CType(item.Item, DevExpress.XtraBars.BarSubItem)
                        For Each sitem As DevExpress.XtraBars.BarItemLink In lista.ItemLinks
                            Dim subBoton As String = sitem.Item.Name.ToLower.Trim
                            If DcBotonesActivos.ContainsKey(subBoton) Then
                                If sitem.Item.Enabled Then sitem.Item.Enabled = True
                                bAlgunHijoHabilitado = True
                            Else
                                sitem.Item.Enabled = False
                            End If
                        Next

                        If bAlgunHijoHabilitado Then
                            If item.Item.Enabled Then item.Item.Enabled = True
                        Else
                            item.Item.Enabled = False
                        End If

                    End If

                Next
            Next
        Next


    End Sub




    Private Sub CambiaEntrada(ByVal nb As Integer)
        Dim s As Integer

        For Each formulario As Form In MdiChildren
            If formulario.Text = "Entrada " + nb.ToString Then
                formulario.Focus()
                s = nb
            End If
        Next
        If s = 0 Then
            Dim frm As New FrmEntradas
            frm.MdiParent = Me
            frm.Text = "Entrada " + nb.ToString
            frm.Show()

            'Esto ya lo está haciendo
            'RaiseEvent AñadeFormulario(frm, "")
        End If

    End Sub


    Private Sub CambiaEntradaConf(ByVal nb As Integer)
        Dim s As Integer

        For Each formulario As Form In MdiChildren
            If formulario.Text = "Entrada Directa " + nb.ToString Then
                formulario.Focus()
                s = nb
            End If
        Next
        If s = 0 Then
            Dim frm As New FrmEntradasConfeccionadas
            frm.MdiParent = Me
            frm.Text = "Entrada Directa " + nb.ToString
            frm.Show()
            'Esto ya lo está haciendo
            'RaiseEvent AñadeFormulario(frm, "")
        End If

    End Sub


    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        'Productos/Generos/Generos
        Dim frm As New FrmGeneros
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub

    Private Sub Clientes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Clientes.ItemClick
        'Sujetos/Clientes/Clientes
        Dim frm As New FrmClientes
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        'Productos/Generos/Tipos de Categorias
        Dim Frm As New FrmTiposCat
        Frm.MdiParent = Me
        Frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub

    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        'Productos/Generos/Categorias Entrada
        Dim frm As New FrmCatEntrada
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        'Productos/Generos/Categorias Salida
        Dim frm As New FrmCatSalida
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        'Sujetos/Clientes/Tipos de Clientes
        Dim frm As New FrmTiposdeClientes
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        'Productos/Envases, materiales y palets/Familias
        Dim frm As New FrmFamiliaEnvases
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        'Productos/Envases, materiales y palets/Tipos de Iva
        Dim frm As New FrmIvaEnvases
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        'Productos/Envases, materiales y palets/Envases, materiales y Palets
        Dim frm As New FrmEnvases
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        'Productos/Envases, materiales y palets/Confección de Envases
        Dim frm As New FrmConfEnvases
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem14_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        'Productos/Envases, materiales y palets/Confección de Palets
        Dim frm As New FrmConfecPalet
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem8_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        'Sujetos/Proveedores de Género/Tipos de Gastos
        Dim frm As New FrmTiposdeGastosAgri
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        'Sujetos/Proveedores de Género/Tipos de Proveedores
        Dim frm As New FrmTiposdeAgricultores
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        'Productos/Envases, materiales y palets/Marcas
        Dim frm As New FrmMarcas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        'Sujetos/Clientes/Gastos Comercio
        Dim frm As New Frmgastoscomercio
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem21_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        'Sujetos/Proveedores de Género/Proveedores
        Dim frm As New FrmAgricultores
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem23_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        'Sujetos/Clientes/Vendedores
        Dim frm As New FrmVendedor
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem30_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        'Sujetos/Comunes/Centros Recogida
        Dim frm As New FrmCrecogida
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem37_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem37.ItemClick
        'Sujetos/Comunes/Conceptos Facturas
        Dim frm As New FrmConceptosFac
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub FrMPrincipal_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MdiChildActivate

        Me.RibbonControl.Minimized = True

        If Me.ActiveMdiChild IsNot _frmWebBrowser Then
            _ultimo_frm_activo = Me.ActiveMdiChild
        End If

    End Sub


    Private Sub BarButtonItem40_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem40.ItemClick
        'ADM Aplicacion/Permisos/Permisos sobre los elementos del menu
        Dim frm As New frmAdministracionMenus
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem41_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem41.ItemClick
        'ADM Aplicacion/Permisos/Permisos sobre formularios
        Dim frm As New frmAdministracionFormularios
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem42_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem42.ItemClick
        'ADM Aplicacion/Logs/Registros por tablas
        Dim frm As New frmLogueoTablas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem43_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem43.ItemClick
        'ADM Aplicacion/Logs/Ver logs
        Dim frm As New FrmLogs
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarListItem7_ListItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ListItemClickEventArgs) Handles BPventa.ListItemClick

        If CompruebaFormulariosCerrados() Then

            Dim N As String = BPventa.Strings(e.Index)
            MiMaletin.IdPuntoVenta = VaInt(Microsoft.VisualBasic.Left(N, InStr(N, " ") - 1))

            Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)
            If ValoresUsuario.LeerId(Idusuario) Then
                MiMaletin.IdCentroRecogida = VaInt(ValoresUsuario.VUS_IdCentroRecogida.Valor).ToString
            End If
            PintaMaletin(MiMaletin.IdEmpresaCTB)

            CambiaColor(MiMaletin.IdPuntoVenta.ToString, Me)

        End If

    End Sub



    Private Sub BEjercicio_ListItemClick(sender As System.Object, e As DevExpress.XtraBars.ListItemClickEventArgs) Handles BEjercicio.ListItemClick

        If CompruebaFormulariosCerrados() Then

            Dim N As String = BEjercicio.Strings(e.Index)
            MiMaletin.Ejercicio = VaInt(Microsoft.VisualBasic.Left(N, InStr(N, " ") - 1))
            PintaMaletin(MiMaletin.IdEmpresaCTB)

        End If

    End Sub


    Private Function CompruebaFormulariosCerrados() As Boolean

        Dim bFormulariosCerrados As Boolean = Me.MdiChildren.Length < 1

        If Not bFormulariosCerrados Then

            If DevExpress.XtraEditors.XtraMessageBox.Show("Para cambiar de Ejercicio o Punto de Venta debe cerrar los formularios abiertos. ¿Desea cerrarlos ahora mismo?", "Cambio de ejercicio",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Try

                    For Each formulario As Form In Me.MdiChildren
                        formulario.Close()
                    Next

                    bFormulariosCerrados = True

                Catch ex As Exception
                End Try

            End If

        End If

        Return bFormulariosCerrados

    End Function


    Private Sub BarButtonItem45_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem45.ItemClick
        'Envases/Almacenes/Almacenes envases
        Dim frm As New FrmAlmEnvases
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem46_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem46.ItemClick
        'Sujetos/Comunes/Valores Usuario
        Dim frm As New FrmValoresUsuario
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem47_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem47.ItemClick
        'Vales envases/Vales automáticos/Albaranes de entrada
        Dim frm As New FrmValeEnvase("EB")
        frm.MdiParent = Me
        'frm.InitTipoVale("EB")
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "EB")
    End Sub


    Private Sub BarButtonItem48_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem48.ItemClick
        'Vales envases/Vales manuales/Vales agricultores
        Dim frm As New FrmValeEnvase("AA")
        frm.MdiParent = Me
        'frm.InitTipoVale("AA")
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "AA")
    End Sub


    Private Sub BarButtonItem49_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem49.ItemClick
        'Productos/Envases, materiales y palets/Conceptos Vales
        Dim frm As New FrmConcepEnvases
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem22_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick

        'Sujetos/Comunes/Zonas
        Dim frm As New FrmZonas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")

    End Sub


    Private Sub BarButtonItem31_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        'Envases/Consultas/Saldos envases agricultores
        Dim frm As New FrmSaldoEnvases
        frm.MdiParent = Me
        frm.InitTipo("A")
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "A")
    End Sub


    Private Sub BarButtonItem39_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem39.ItemClick
        'Vales envases/Vales manuales/Movimientos almacen
        Dim frm As New FrmValeEnvaseTraspaso
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem50_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem50.ItemClick
        'Envases/Consultas/Existencias almacenes
        Dim frm As New FrmSaldoEnvasesAlmacen
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem69_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem69.ItemClick
        'Sujetos/Comunes/Valores Punto Venta
        Dim frm As New FrmValorespventa
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarListItem1_ListItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ListItemClickEventArgs) Handles BarListItem1.ListItemClick

        If CompruebaFormulariosCerrados() Then
            Dim N As String = BarListItem1.Strings(e.Index)
            MiMaletin.IdCentroRecogida = VaInt(Microsoft.VisualBasic.Left(N, InStr(N, " ") - 1))
            PintaMaletin(MiMaletin.IdEmpresaCTB)
        End If

    End Sub


    Private Sub BarButtonItem71_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem71.ItemClick
        'Envases/Consultas/Saldo envases clientes
        Dim frm As New FrmSaldoEnvases
        frm.MdiParent = Me
        frm.InitTipo("C")
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "C")

    End Sub


    Private Sub BarButtonItem72_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem72.ItemClick
        'Vales envases/Vales manuales/Vales clientes
        Dim frm As New FrmValeEnvase("CC")
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "CC")
    End Sub


    Private Sub BarButtonItem75_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem75.ItemClick
        'Sujetos/Acreedores de servicios/Origen Gastos
        Dim frm As New FrmOrigenGastos
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")

    End Sub


    Private Sub BarButtonItem76_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem76.ItemClick
        'Sujetos/Acreedores de servicios/Acreedores
        Dim frm As New FrmAcreedores
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")

    End Sub


    Private Sub BarButtonItem78_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem78.ItemClick
        'Produccion/Produccion/Palets
        Dim frm As New FrmPaletsComer
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem79_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem79.ItemClick
        'Productos/Generos/Tipos de Calibre
        Dim Frm As New FrmTiposCalibre
        Frm.MdiParent = Me
        Frm.Show()
        RaiseEvent AñadeFormulario(Frm, "")
    End Sub


    Private Sub BarButtonItem80_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem80.ItemClick
        'Comercial/Pedidos/Pedidos
        Dim Frm As New FrmPedidos
        Frm.MdiParent = Me
        Frm.Show()
        RaiseEvent AñadeFormulario(Frm, "")
    End Sub


    Private Sub BarButtonItem81_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem81.ItemClick
        'Produccion/Expediciones/Carga de palets
        Dim Frm As New FrmCargaPalets
        Frm.MdiParent = Me
        Frm.Show()
        RaiseEvent AñadeFormulario(Frm, "")
    End Sub


    Private Sub BarButtonItem82_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem82.ItemClick
        'Produccion/Produccion/Pedidos almacen
        Dim Frm As New FrmPedidosAlmacen
        Frm.MdiParent = Me
        Frm.Show()
        RaiseEvent AñadeFormulario(Frm, "")
    End Sub


    Private Sub BarButtonItem83_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs)

        'ADM Aplicacion/Test/Prueba grid editable
        Dim frm As New Form1
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem86_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem86.ItemClick
        'Produccion/Expediciones/Albaranes de salida
        Dim frm As New FrmHiAlbSal
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem87_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem87.ItemClick
        'Comercial/Facturacion/Valoracion Alb
        Dim frm As New FrmValoraAlb
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem88_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem88.ItemClick
        'Vales envases/Vales automáticos/Alb Salida Comercio (Retornables)
        Dim frm As New FrmValeEnvase("SC")
        frm.MdiParent = Me
        'frm.InitTipoVale("SC")
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "SC")
    End Sub


    Private Sub BarButtonItem89_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem89.ItemClick
        'Vales envases/Vales automáticos/Alb Salida Comercio (Materiales)
        Dim frm As New FrmValeEnvase("SM")
        frm.MdiParent = Me
        'frm.InitTipoVale("SM")
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "SM")

    End Sub


    Private Sub BarListVentanas_ListItemClick(sender As System.Object, e As DevExpress.XtraBars.ListItemClickEventArgs) Handles BarListVentanas.ListItemClick

        'Utiles/Ventanas abiertas/Ventanas abiertas
        For indice As Integer = 0 To Me.MdiChildren.Length - 1

            Dim f As Form = Me.MdiChildren(indice)

            If (indice + 1).ToString & " - " & f.Text = BarListVentanas.Strings(e.Index) Then
                f.Select()
                f.Focus()
            End If

        Next

    End Sub


    Private Sub BarListVentanas_GetItemData(sender As System.Object, e As System.EventArgs) Handles BarListVentanas.GetItemData
        ActualizaVentanas()
    End Sub


    Private Sub ActualizaVentanas()

        'Utilidades/Ventanas/Ventanas abiertas
        Dim childrens As New List(Of String)
        For indice As Integer = 0 To Me.MdiChildren.Length - 1
            Dim f As Form = Me.MdiChildren(indice)
            childrens.Add((indice + 1).ToString & " - " & f.Text)
        Next

        BarListVentanas.Strings.Clear()
        BarListVentanas.Strings.AddRange(childrens.ToArray)

        childrens = Nothing

    End Sub


    Private Sub BarButtonItem90_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem90.ItemClick
        'Compras/Entradas/Entrada Bascula
        IdBasculaEntrada = Idusuario
        If IdBasculaEntrada > 0 Then
            CambiaEntrada(1)
        Else
            MsgBox("Numero de bascula incorrecta")
        End If

    End Sub


    Private Sub BarButtonItem91_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem91.ItemClick
        'Compras/Entradas/Muestreo Partidas
        Dim frm As New FrmMuestreoComercio
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub



    Private Sub BarButtonItem95_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem95.ItemClick
        'ADM Aplicacion/Test/Bloqueo registros
        Dim frm As New FrmVactividad
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem96_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem96.ItemClick
        'Listados Comercializacion/Entradas/Albaranes de entrada
        Dim frm As New FrmListadoAlbaranesEntrada
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem97_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem97.ItemClick
        'ADM Aplicacion/Test/Actividad diaria
        Dim frm As New FrmVprocesosdia
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem333_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem333.ItemClick
        'Comercial/Facturacion/Facturación albaranes
        Dim frm As New FrmFacturacion
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem101_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem101.ItemClick
        'ADM Aplicacion/Utilidades/Configuraciones diversas
        Dim frm As New FrmConfigDiversas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem103_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem103.ItemClick
        'Envases/Materiales/Tarifas de precios
        Dim frm As New FrmTarifasMaterial
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem104_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem104.ItemClick
        'Envases/Materiales/Pedidos material
        Dim frm As New FrmPedidoMaterial
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem105_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem105.ItemClick
        'Envases/Materiales/Albaranes compra
        Dim frm As New FrmAlbMaterial
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem106_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem106.ItemClick
        'Sujetos/Comunes/Departamentos
        Dim frm As New FrmDepartamentos
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem107_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem107.ItemClick
        'Envases/Almacenes/Saldos iniciales
        Dim frm As New FrmEnvaseInicial
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem108_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem108.ItemClick
        'Envases/Consultas/Inventario materiales
        Dim frm As New FrmInventarioMateriales
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem111_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem111.ItemClick

        'Envases/Consultas/Extracto Envases
        Dim frm As New FrmExtractoEnvasesPorMaterial
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem114_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem114.ItemClick
        'Vales envases/Vales automáticos/Compra materiales
        Dim frm As New FrmValeEnvase("AC")
        frm.MdiParent = Me
        'frm.InitTipoVale("AC")
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "AC")
    End Sub


    Private Sub BarButtonItem115_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem115.ItemClick
        'ADM Aplicacion/Test/Alertas
        Dim frm As New FrmValertas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem116_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem116.ItemClick
        'ADM Aplicacion/Logs/Alerta por tablas
        Dim frm As New frmAlertaTablas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem117_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem117.ItemClick
        'Produccion/Expediciones/CMR / Carta de porte
        Dim frm As New FrmCmr
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem122_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem122.ItemClick
        'Envases/Consultas/Consulta Pedido Material
        Dim frm As New FrmConsultaPedidoMaterial
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")

    End Sub

    Private Sub BarButtonItem123_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem123.ItemClick
        'Envases/Consultas/Albaran material
        Dim frm As New FrmConsultaAlbaranPedido
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")

    End Sub


    'Private Sub BarButtonItem126_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem126.ItemClick
    '    'Listados Subasta/Ventas/Consulta facturas
    '    Dim frm As New FrmConsultaFacturas
    '    frm.MdiParent = Me
    '    frm.Show()
    '    RaiseEvent AñadeFormulario(frm, "")

    'End Sub


    Private Sub BarButtonItem127_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        'Productos/Generos/Asignar Confecciones
        Dim frm As New FrmAsignarConfecAGeneros
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")

    End Sub


    Private Sub BarButtonItem133_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem133.ItemClick
        'Sujetos/Listados/Listado Acreedores
        Dim frm As New FrmConsultaListadoAcreedores
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")

    End Sub


    Private Sub BarButtonItem134_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem134.ItemClick
        'Sujetos/Listados/Listado Clientes
        Dim frm As New FrmConsultaListadoClientes
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")

    End Sub


    Private Sub BarButtonItem135_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem135.ItemClick

        'Sujetos/Listados/Listado Proveedores
        Dim frm As New FrmConsultaListadoProveedores
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem136_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem136.ItemClick
        'Productos/Listados/List.Generos
        Dim frm As New FrmConsultaListadoGeneros
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem137_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem137.ItemClick
        'Productos/Listados/List. Generos Compuestos
        Dim frm As New FrmConsultaListadoGenerosCompuestos
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem138_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem138.ItemClick
        'Productos/Listados/List.Generos Salidas
        Dim frm As New FrmConsultaListadoGenerosSalidas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem139_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem139.ItemClick
        'Productos/Listados/List. Categorias Entrada
        Dim frm As New FrmConsultaListadoCatEntrada
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem140_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem140.ItemClick
        'Productos/Listados/List. Categorias Salida
        Dim frm As New FrmConsultaListadoCatSalida
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem141_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem141.ItemClick
        'Productos/Listados/List. Envases
        Dim frm As New FrmConsultaListadoEnvases
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem142_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem142.ItemClick
        'Productos/Listados/List. Confecciones Envases
        Dim frm As New FrmConsultaListadoConfecEnvase
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem143_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem143.ItemClick
        'Productos/Listados/List. Confecciones Palets
        Dim frm As New FrmConsultaListadoConfecPalets
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem144_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem144.ItemClick
        'Productos/Listados/List. Marcas
        Dim frm As New FrmConsultaListadoMarcas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem118_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem118.ItemClick
        'Administracion/Facturacion/Consulta gastos
        Dim frm As New FrmConsultaGastosEntrada
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem151_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem151.ItemClick
        'Comercial/Valoraciones/Introducción existencias
        Dim FRM As New FrmParteExistencias
        FRM.MdiParent = Me
        FRM.Show()
        RaiseEvent AñadeFormulario(FRM, "")
    End Sub


    Private Sub BarButtonItem154_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        'Sujetos/Proveedores de Género/Actualizar Cuentas
        Dim frm As New FrmGenerarCuentas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem157_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem157.ItemClick
        'Calidad/Trazabilidad/Por partida
        Dim frm As New FrmConsultaTrazabilidad
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem161_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem161.ItemClick
        'Produccion/Produccion/Trabajos etiquetas
        Dim frm As New FrmTrabajosEtiqueta
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem166_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem166.ItemClick

        'Envases/Materiales/Partes consumo
        Dim frm As New FrmConsumoAlm
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem167_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem167.ItemClick

        'Envases/Materiales/Recuento existencias
        Dim frm As New FrmRegularizacionExistencias
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem168_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem168.ItemClick

        'Comercial/Facturacion/Gastos comerciales por albaran
        Dim Frm As New FrmGasComer
        Frm.MdiParent = Me
        Frm.Show()
        RaiseEvent AñadeFormulario(Frm, "")
    End Sub


    Private Sub BarButtonItem175_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem175.ItemClick

        'Administracion/Facturacion/Gastos comerciales
        Dim frm As New FrmGasComerCompra
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem178_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem178.ItemClick

        'Envases/Materiales/Materiales por albarán
        Dim frm As New FrmValeEnvase("SM")
        frm.MdiParent = Me
        'frm.InitTipoVale("CC")
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "SM")
    End Sub


    Private Sub BarButtonItem182_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem182.ItemClick

        'Listado comercializacion/Facturacion/Listado Iva repercutido
        Dim frm As New FrmListadoIvaRepercutido
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")

    End Sub


    Private Sub BarButtonItem184_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem184.ItemClick

        'Calidad/Trazabilidad/Por lote
        Dim frm As New FrmConsultaTrazabilidadLote
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem185_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem185.ItemClick

        'Calidad/Trazabilidad/Precalibrado
        Dim frm As New FrmConsultaTrazabilidadPreca
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem190_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem190.ItemClick

        'Envases/Consultas/Saldos por tipo envase
        Dim frm As New FrmInventarioFueraAlmacen
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub

    Private Sub BarButtonItem191_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem191.ItemClick

        'Envases/Consultas/Saldo por sujeto
        Dim frm As New FrmConsultaSaldoEnvases
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem194_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem194.ItemClick

        'Administracion/Partes semanales/Semanas partes
        Dim frm As New FrmSemanasValoracion
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem203_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs)

        'ADM Aplicacion/Test/Actualizar VEV_PrecioCoste
        Dim frm As New FrmActualizarVEV_PrecioCoste
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem204_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem204.ItemClick

        'Envases/Consultas/Cons. Materiales Comp.
        Dim frm As New FrmConsumoMaterialesComparativo
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem206_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem206.ItemClick

        'Calidad/Reclamaciones/Reclamaciones
        Dim frm As New FrmReclamacion
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem207_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem207.ItemClick

        'Calidad/Reclamaciones/Origen
        Dim frm As New FrmReclama_origen
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem208_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem208.ItemClick

        'Calidad/Reclamaciones/Solucion
        Dim frm As New FrmReclama_solucion
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem210_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem210.ItemClick

        'Calidad/Reclamaciones/Consulta
        Dim frm As New FrmConsultaReclamaciones
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem205_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem205.ItemClick

        'Listado comercializacion/Facturacion/Listado Facturas recibidas
        Dim frm As New FrmConsultaFacturasRecibidas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem216_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem216.ItemClick

        'ADM Aplicacion/Permisos/Permisos botones formularios
        Dim frm As New FrmAsignarClaveBoton
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem219_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem219.ItemClick

        'ADM Aplicacion/Utiles/Consultas SQL
        Dim frm As New FrmEjecutarSql
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem221_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem221.ItemClick

        'Envases/Consulta/Saldos por Centro
        Dim frm As New FrmSaldosEnvasesPorCentro
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem223_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem223.ItemClick

        'ADM Aplicacion/Permisos/Permisos menú (perfiles)
        Dim frm As New FrmAdministracionMenusPorPerfiles
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem224_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem224.ItemClick

        'ADM Aplicacion/Permisos/Permisos formularios (perfiles)
        Dim frm As New FrmAdministracionFormulariosPorPerfiles
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem230_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem230.ItemClick

        'Calidad/Reclamaciones/Motivos de queja
        Dim frm As New FrmMotivosQueja
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem232_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem232.ItemClick

        'ADM Aplicacion/Test/Calendario
        Dim frm As New Form4
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem233_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem233.ItemClick

        'Utilidades/Otros/Ver IP
        Dim ip As String = ObtenerIpLocal()
        MsgBox(ip)

    End Sub


    Private Sub BarButtonItem2_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        'Sujetos/Proveedores de genero/Medianeria
        Dim Frm As New Frmmedianeria
        Frm.MdiParent = Me
        Frm.Show()
        RaiseEvent AñadeFormulario(Frm, "")
    End Sub


    Private Sub BarButtonItem3_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        'Sujetos/Clientes/Normas calidad
        Dim FRM As New FrmNormasCalidad
        FRM.MdiParent = Me
        FRM.Show()
        RaiseEvent AñadeFormulario(FRM, "")
    End Sub


    Private Sub BarButtonItem222_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem222.ItemClick
        'Produccion/Produccion/Lotes entrada
        Dim FRm As New FrmLotesPartida
        FRm.MdiParent = Me
        FRm.Show()
        RaiseEvent AñadeFormulario(FRm, "")
    End Sub


    Private Sub BarButtonItem4_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        'Productos/Generos/Categorias comerciales
        Dim frm As New FrmCatComercial
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem15_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        'Administracion/Valoraciones/Val. Albaranes Firme
        Dim frm As New FrmPrecioFirme
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem18_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        'Compras/Entradas/Modificación datos entrada
        Dim frm As New FrmEntradasMod
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub Bcalidad_ListItemClick(sender As System.Object, e As DevExpress.XtraBars.ListItemClickEventArgs) Handles Bcalidad.ListItemClick

        If CompruebaFormulariosCerrados() Then
            Dim N As String = Bcalidad.Strings(e.Index)
            MiMaletin.idprogramacliente = VaInt(Microsoft.VisualBasic.Left(N, InStr(N, " ") - 1))
            PintaMaletin(MiMaletin.IdEmpresaCTB)
        End If

    End Sub


    Private Sub BarButtonItem24_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        'Productos/Envases, materiales y palets/Medidas palets
        Dim Frm As New FrmMedidasPalets
        Frm.MdiParent = Me
        Frm.Show()
        RaiseEvent AñadeFormulario(Frm, "")
    End Sub


    Private Sub BarButtonItem26_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        'Productos/Envases, materiales y palets/Subfamilias
        Dim frm As New FrmSubFamiliaEnvases
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem27_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        'Sujetos/Clientes/Tipos de porte
        Dim frm As New FrmTiposPorte
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem28_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        'Productos/Envases, materiales y palets/Tipos de material
        Dim frm As New FrmTipoMaterial
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem29_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        'Productos/Generos/Confecciones por género
        Dim frm As New FrmConfecGenero
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem33_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem33.ItemClick
        'Productos/Generos/Lineas de producción
        Dim frm As New FrmLineas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem38_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem38.ItemClick
        'Productos/Envases, materiales y palets/U.Medida
        Dim frm As New FrmUmedida
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem51_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem51.ItemClick
        'Sujetos/Comunes/Grupos mensajes
        Dim frm As New FrmGruposMensajes
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem52_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem52.ItemClick
        Dim frm As New FrMMensajesUsuario
        frm.ShowDialog()
    End Sub


    Private Sub BarButtonItem53_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem53.ItemClick
        'Compras/Entradas/Entradas Confeccionadas
        IdBasculaEntrada = Idusuario
        If IdBasculaEntrada > 0 Then
            CambiaEntradaConf(1)
        Else
            MsgBox("Numero de bascula incorrecta")
        End If
    End Sub


    Private Sub BarButtonItem55_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem55.ItemClick
        'Produccion/Produccion/Produccion lineas
        Dim frm As New FrmProduccion
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem56_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem56.ItemClick
        'Produccion/Stock/Consulta existencias
        Dim frm As New FrmConsultaExistencias
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem57_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem57.ItemClick
        'Produccion/Gestion/Consulta produccion
        Dim frm As New FrmConsultaProduccion
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem58_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem58.ItemClick
        'Produccion/Gestion/Modificar produccion
        Dim frm As New FrmModProduccion
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem59_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem59.ItemClick
        'Produccion/Stock/Traspasos entre centros
        Dim frm As New FrmTraspasosCentros
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem60_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem60.ItemClick
        'Produccion/Palets/Precalibrado
        Dim frm As New FrmLotesProduccion
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem61_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem61.ItemClick
        'ADM Aplicacion/Utilidades/Desbloquear linea
        Dim frm As New FrmDesbloquearLinea
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem63_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem63.ItemClick
        'Produccion/Expediciones/Conceptos inspección
        Dim frm As New FrmCarga_Inspeccion
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem64_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem64.ItemClick
        'Produccion/Expediciones/Conceptos transporte
        Dim frm As New FrmConceptosTransporte
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem65_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem65.ItemClick
        'Produccion/Expediciones/Cargadores
        Dim FRM As New FrmCargadores
        FRM.MdiParent = Me
        FRM.Show()
        RaiseEvent AñadeFormulario(FRM, "")
    End Sub


    Private Sub BarButtonItem66_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem66.ItemClick

        'Produccion/Expediciones/Cargas

        LeerFicheroINI_Muelles()

        If NumeroMuelleDerecha > 0 Then
            Dim frmDerecha As New FrmCargas
            frmDerecha.MdiParent = Me
            frmDerecha.InitMuelle(NumeroMuelleDerecha, True)
            frmDerecha.Show()
        End If

        If NumeroMuelleIzquierda > 0 Then
            Dim frmizquierda As New FrmCargas
            frmizquierda.MdiParent = Me
            frmizquierda.InitMuelle(NumeroMuelleIzquierda, False)
            frmizquierda.Show()
        Else
            If NumeroMuelleDerecha = 0 Then
                NumeroMuelleIzquierda = 1
                Dim frmizquierda As New FrmCargas
                frmizquierda.MdiParent = Me
                frmizquierda.InitMuelle(NumeroMuelleIzquierda, False)
                frmizquierda.Show()
            End If
        End If


    End Sub


    Private Sub BarButtonItem67_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem67.ItemClick
        'Producción/Producción/Muestreo partidas
        Dim frm As New FrmMuestreoPartidas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem70_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem70.ItemClick
        'Financiero/Cobros/Conceptos cobros
        Dim frm As New FrmConceptosCobros
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem68_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem68.ItemClick
        'Financiero/Cobros/Cobros
        Dim frm As New FrmCobros
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem73_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem73.ItemClick
        'Financiero/Pagos/Facturas recibidas
        Dim frm As New FrmFacRecibidas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem85_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem85.ItemClick
        'Sujetos/Proveedores de genero/Empresas
        Dim frm As New FrmEmpresas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem94_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem94.ItemClick
        'Comercial/Pedidos/ConsultaPedidos
        Dim frm As New FrmConsultaPedidos
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem25_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        'Listado comercializacion/Salidas/Palets (nueva)
        Dim frm As New FrmListadoPalets
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem98_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem98.ItemClick
        'Financiero/Varios/Generar semanas año
        Dim frm As New FrmGeneraSemanas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem62_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem62.ItemClick
        'Listado comercializacion/Salidas/Albaranes de salida
        Dim frm As New FrmListadoAlbaranesSalida
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem74_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem74.ItemClick
        'Listado comercializacion/Salidas/Palets(antigua)
        Dim frm As New FrmConsultaPalets
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub

    Private Sub BarButtonItem99_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem99.ItemClick
        'Administracion/Partes semanales/Parte semanal
        Dim frm As New FrmParteSemanal
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")

    End Sub

    Private Sub BarButtonItem100_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem100.ItemClick
        'Produccion/Palets/Pesar palets
        Dim frm As New FrmPaletsRFID
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub

    Private Sub BarButtonItem124_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem124.ItemClick
        'Listados Comercializacion/Entradas/Clasificaciones proveedor
        Dim frm As New FrmClasificacionesProveedor
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub

    Private Sub BarButtonItem127_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem127.ItemClick
        'Administracion/Partes semanales/Gastos confeccion semanal
        'Dim frm As New FrmSemanaConf
        Dim frm As New FrmSemanaConfPorPalet
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem146_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem146.ItemClick
        'Administracion/Partes semanales/Cuadre kilos semanal
        Dim frm As New FrmCuadreKilos
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem147_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem147.ItemClick
        'Produccion/Stock/Recepción traspasos
        Dim frm As New FrmRecepcionTraspaso
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem148_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem148.ItemClick
        'Comercial/Valoraciones/Valoracion precios referencia
        Dim frm As New FrmValoraRef
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem149_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem149.ItemClick
        'Comercial/Valoraciones/Salidas por clientes
        Dim frm As New FrmSalidasporcliente
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem150_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem150.ItemClick
        'Sujetos/Clientes/Tarifas porte
        Dim frm As New FrmTarifaPortes
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem152_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem152.ItemClick
        'Utiles/Produccion/Procesos clave
        Dim frm As New Utilidades_miguel
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub

    Private Sub BarButtonItem153_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem153.ItemClick
        'Administracion/Valoraciones/Val. Albaranes S/Clasificación
        Dim frm As New FrmValoracionNoFirme
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem154_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem154.ItemClick
        'Administracion/Valoraciones/Val. Semanal S/Clasificacion
        Dim frm As New FrmValoracionSegunClasificacion
        frm.InitTipo("S")
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem155_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem155.ItemClick
        'Administracion/Facturacion/Generar medianería
        Dim frm As New FrmGeneraMedianeria
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem158_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem158.ItemClick
        'Administracion/Facturacion/Generar facturas
        Dim frm As New FrmGenerarFacturas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem160_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem160.ItemClick
        'Listado comercializacion/Ficheros maestros/Medianerias
        Dim frm As New FrmConsultaListadoMedianerias
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem164_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem164.ItemClick
        'Listados Comercializacion/Entradas/Verificaciones muestreo
        Dim frm As New FrmVerificacionMuestreo
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem165_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem165.ItemClick
        'Administracion/Partes semanales/Chequeo semanal
        Dim frm As New FrmChequeoSemana
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem170_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem170.ItemClick
        'Listado comercializacion/Ficheros maestros/Gastos agricultores
        Dim frm As New FrmListadoGastosPr
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem171_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem171.ItemClick
        'Compras/Entradas/Previsiones
        Dim frm As New FrmPreviones
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem174_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem174.ItemClick
        'Comercial/Facturacion/Gastos comerciales por acreedor
        Dim frm As New FrmGasComerSalidas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem176_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem176.ItemClick
        'Compras/Entradas/Consulta previsiones
        Dim frm As New FrmConsultaPrevisiones
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem177_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem177.ItemClick
        If MsgBox("Desea terminar", vbYesNo) = vbYes Then
            Me.Close()

        End If
    End Sub


    Private Sub BarButtonItem181_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem181.ItemClick
        'Utiles/Produccion/Arreglar duplicidades en lotes
        ArreglarDuplicacionesLotes()
        MsgBox("Terminado!")

    End Sub


    Private Sub BarButtonItem186_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem186.ItemClick
        'Administracion/Facturacion/Consulta facturas
        Dim frm As New FrmConsultaFacturasAgr
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BEmpresa_ListItemClick(sender As System.Object, e As DevExpress.XtraBars.ListItemClickEventArgs) Handles BEmpresa.ListItemClick
        ' PARA CAMBIAR DE EMPRESA HAY QUE CAMBIAR DE PUNTO DE VENTA

        'If CompruebaFormulariosCerrados() Then

        '    Dim N As String = BEmpresa.Strings(e.Index)

        '    MiMaletin.IdEmpresaCTB = VaInt(Microsoft.VisualBasic.Left(N, InStr(N, " ") - 1))


        '    Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)
        '    If ValoresUsuario.LeerId(Idusuario) Then
        '        MiMaletin.IdCentroRecogida = VaInt(ValoresUsuario.VUS_IdCentroRecogida.Valor).ToString
        '    End If
        '    PintaMaletin(MiMaletin.IdEmpresaCTB)

        '    CambiaColor(MiMaletin.IdPuntoVenta.ToString, Me)

        'End If
    End Sub


    Private Sub BarButtonItem188_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem188.ItemClick
        'Administracion/Facturacion/Historico facturas
        Dim frm As New FrmHisFactAgri
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem192_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem192.ItemClick
        'Utiles/Produccion/Arreglo precios valoracion 14-oct
        Dim frm As New ArregloValoracion
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")

    End Sub


    Private Sub BarButtonItem193_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem193.ItemClick
        'Utiles/Produccion/Actualizar programas calidad lineas
        Dim frm As New FrmActualizarAEL_IdPrograma
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem196_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem196.ItemClick
        'Financiero/Varios/Contadores
        Dim frm As New FrmMantenimientoContadores
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")

    End Sub


    Private Sub BarButtonItem195_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem195.ItemClick
        'Sujetos/Clientes/Prog. calidad tecnicos
        Dim frm As New FrmProgramasCalidadTecnicos
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")

    End Sub


    Private Sub BarButtonItem197_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem197.ItemClick
        'Administracion/Facturacion/Contabilizar facturas
        Dim frm As New FrmImprimirFacturasAgr
        frm.InitOper("CONTABILIZAR")
        frm.ShowDialog()
    End Sub


    Private Sub BarButtonItem198_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem198.ItemClick
        'Administracion/Facturacion/Anular facturas
        Dim frm As New FrmImprimirFacturasAgr
        frm.InitOper("ANULAR")
        frm.ShowDialog()
    End Sub


    Private Sub BarButtonItem199_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem199.ItemClick
        'Administracion/Facturacion/Imprimir facturas
        Dim frm As New FrmImprimirFacturasAgr
        frm.InitOper("IMPRIMIR")
        frm.ShowDialog()
    End Sub


    Private Sub BarButtonItem200_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem200.ItemClick
        'Comercial/Facturacion/Envio facturas por email
        Dim frm As New FrmEnvioMasivoEmail
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem201_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem201.ItemClick
        'Financiero/Liquidaciones/Generar liquidaciones
        Dim frm As New FrmGenerarLiquidaciones
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem202_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem202.ItemClick
        'Financiero/Liquidaciones/Emitir liquidaciones
        Dim frm As New FrmEmitirLiquidaciones
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem203_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem203.ItemClick
        'Financiero/Liquidaciones/Modificar liquidaciones
        Dim frm As New FrmLiquidacionAgr
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem214_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem214.ItemClick
        'Financiero/Liquidaciones/Contabilizar liquidaciones
        Dim frm As New FrmLiquidacionesCTB
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem215_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem215.ItemClick
        'ADM Aplicacion/Test/Escaner
        Dim frm As New NetAgro.TwainGui.FrmTwain
        frm.ShowDialog()
    End Sub


    Private Sub BarButtonItem218_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem218.ItemClick
        'Sujetos/Comunes/Documentos bancos
        Dim frm As New FrmDocumentosBancos
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem220_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem220.ItemClick
        'Administracion/Facturacion/Historico albaranes
        Dim frm As New FrmHiAlbCompra
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem225_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem225.ItemClick
        'Listado comercializacion/Salidas/Declaracion SOIVRE
        Dim frm As New FrmConsultaSOIVRE
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem229_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem229.ItemClick
        'Listado comercializacion/Salidas/Generos facturados de agricultores
        Dim frm As New FrmGenerosFacturadosAgricultores
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub

    
    Private Sub BarButtonItem32_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem32.ItemClick
        'Calidad/Trazabilidad/Trazabilidad Palet
        Dim frm As New FrmTrazabilidadPalet
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub

    Private Sub BarButtonItem54_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem54.ItemClick
        'Financiero/Riesgos/Riesgos de clientes
        Dim frm As New FrmRiesgoClientes
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub


    Private Sub BarButtonItem260_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem260.ItemClick
        'Financiero / Información financiera / Asignar IBAN a Agricultores
        Dim frm As New FrmIBANAgricultores
        frm.MdiParent = Me
        frm.Show()
    End Sub


    Private Sub BarButtonItem83_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem83.ItemClick
        'Listados Comercializacion/Facturacion/List. Facturas Clientes
        Dim frm As New FrmListadoFacturasClientes
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub

    Private Sub BarButtonItem93_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem93.ItemClick
        'Utiles/Produccion/Actualizar IdFacturaFirme
        Dim frm As New AsignarIdFacturaFirme
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem102_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem102.ItemClick
        'Administracion/Partes semanales/Bloqueo clasificaciones
        Dim frm As New FrmBloqueoClasificaciones
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem109_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem109.ItemClick
        'Financiero/Liquidaciones/Emision talones
        Dim frm As New FrmEmisionTalones
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem110_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem110.ItemClick
        'Comercial/Facturacion/Consulta gastos salida
        Dim frm As New FrmConsultaGastosAlbSalida
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem263_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem263.ItemClick
        'Comercial/Facturacion/Facturar vales envases
        Dim frm As New FrmFacturaEnvases
        frm.MdiParent = Me
        frm.Show()
    End Sub


    Private Sub BarButtonItem112_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem112.ItemClick


        ImpersonateLib.Impersonate.ImpersonateUser("test", "", "test")


        Dim fs As New IO.FileStream("C:\Permisos\hola2.txt", IO.FileMode.Create)
        Dim wr As New IO.StreamWriter(fs)


        wr.WriteLine("prueba de texto")

        wr.Close()
        fs.Close()



        'Dim usuario_aplicacion As New Impersonate_User("Administrador", "", "")
        ''usuario_aplicacion.ImpersonateUser("Administrador", "CLAVE-PC", "Admin")

        'Try

        '    Dim fs As New IO.FileStream("C:\Permisos\hola2.txt", IO.FileMode.Create)
        '    Dim wr As New IO.StreamWriter(fs)

        '    'For Each item In _parametros
        '    '    wr.WriteLine(item.Key.ToString & item.Value.ToString)
        '    'Next

        '    wr.WriteLine("prueba de texto")

        '    wr.Close()
        '    fs.Close()

        'Catch ex As Exception

        'End Try



        'Try
        '    'usuario_aplicacion.RemoveImpersonation()

        'Catch ex As Exception

        'End Try




    End Sub

    Private Sub BarButtonItem113_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem113.ItemClick
        'Administracion/Web/Noticias web
        Dim frm As New FrmNoticiasWeb
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub

    Private Sub BarButtonItem119_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem119.ItemClick
        'Administracion/Web/Usuarios web
        Dim frm As New FrmUsuariosWeb
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub

    Private Sub BarButtonItem120_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem120.ItemClick
        'ADM Aplicacion/Test/Paso de usuarios web
        Dim frm As New FrmPasoUsuariosWeb
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem121_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem121.ItemClick
        'Administracion/Partes semanales/Avance precios
        Dim frm As New FrmAvancePrecios
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub

    Private Sub BarButtonItem128_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem128.ItemClick
        'ADM Aplicacion / Test / Band View
        Dim frm As New FrmBandView
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem129_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem129.ItemClick
        'Listados comercializacion / Salidas / Balance de masas
        Dim frm As New FrmBalanceMasas
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub

    Private Sub BarButtonItem130_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem130.ItemClick
        'Calidad / Entradas / Incidencias clasificacion
        Dim frm As New FrmIncidenciasClasificacion
        frm.MdiParent = Me
        frm.Show()
        RaiseEvent AñadeFormulario(frm, "")
    End Sub

    Private Sub BarButtonItem131_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem131.ItemClick
        Dim frm As New FrmInicioFinalProduccion
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem132_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem132.ItemClick

        'Listados comercializacion / Salidas / Periodo Medio Expedicion
        Dim frm As New FrmPeriodoMedioExpedicion
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub BarButtonItem156_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem156.ItemClick

        'Calidad / Reclamaciones / Motivos de queja
        Dim frm As New FrmMotivosQueja
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub BarButtonItem159_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem159.ItemClick

        'Calidad / Reclamaciones / Origen
        Dim frm As New FrmReclama_origen
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub BarButtonItem162_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem162.ItemClick
        'Utiles / Produccion / Actualizar mermas
        Dim frm As New FrmActualizarMermas
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem163_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem163.ItemClick

        'Calidad / Reclamaciones / Solucion
        Dim frm As New FrmReclama_solucion
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub BarButtonItem169_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem169.ItemClick

        'Calidad / Reclamaciones / Consulta
        Dim frm As New FrmConsultaReclamaciones
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub BarButtonItem172_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem172.ItemClick

        'Calidad / Reclamaciones / Reclamaciones
        Dim frm As New FrmReclamacion
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub BarButtonItem173_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem173.ItemClick

        Dim frm As New FrmRecomponerTarasPalets
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub BarButtonItem179_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem179.ItemClick
        'Calidad / Trazabilidad / Alb. Salida
        Dim frm As New FrmTrazaSalida
        frm.Mdiparent = Me
        frm.show()
    End Sub

    Private Sub BarButtonItem180_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem180.ItemClick
        'Sujetos / Comunes / Divisas
        Dim frm As New frmMonedas
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem183_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem183.ItemClick
        'Utiles / Gestion documental / Escaneo por lotes
        Dim frm As New FrmEscaneoPorLotes
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem187_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem187.ItemClick
        'Utiles / Produccion / Generar inspecciones
        Dim frm As New FrmGenerarInspecciones
        frm.mdiparent = Me
        frm.show()
    End Sub

    'Private Sub BarButtonItem189_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem189.ItemClick

    '    For indice As Integer = 100 To 1100
    '        Dim nombrefichero As String = "AUTO_AS16." & indice.ToString & "." & (indice + 77).ToString & "." & Now.ToString("yyyyMMdd_HHmmss")
    '        IO.File.Copy("c:\temp\buzon\original.pdf", "c:\temp\buzon\" & nombrefichero & ".pdf")
    '    Next


    '    MsgBox("Terminado")

    'End Sub

    Private Sub BarButtonItem209_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem209.ItemClick

        'Sujetos / Comunes / Variables ejercicio
        Dim frm As New FrmValoresEjercicio
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub BarButtonItem211_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem211.ItemClick

        'Envases / Consultas / Materiales usados en Palets
        Dim frm As New FrmMaterialesEnPalets
        frm.mdiparent = Me
        frm.show()

    End Sub

    Private Sub BarButtonItem212_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem212.ItemClick
        Dim frm As New FrmConsultaTarifasPrecios
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem213_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem213.ItemClick
        Dim frm As New FrmCierreInventario
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem226_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem226.ItemClick
        Dim frm As New FrmRecomGastos
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem227_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem227.ItemClick
        'Calidad / Bloqueo Cultivos / Partes de Bloqueo de Cultivos
        Dim frm As New FrmBloqueoCultivos
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem228_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem228.ItemClick
        'Calidad / Bloqueo Cultivos / Consulta de Partes de Bloqueo
        Dim frm As New FrmConsultaPartesBloqueoCultivo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem231_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem231.ItemClick
        'Calidad / Bloqueo Cultivos / Entradas en Plazo de Seguridad
        Dim frm As New FrmConsultaEntradasEnPlazoSeguridad
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem234_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem234.ItemClick
        Dim frm As New FrmListadoVentasGastosAlbaran
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem235_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem235.ItemClick
        Dim frm As New FrmListadoVentasIntracomunitarias
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem236_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem236.ItemClick
        Dim frm As New FrmPortesSalida
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem237_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem237.ItemClick
        'Utiles / Gestion documental / Escaneo por lotes
        Dim frm As New FrmEscaneoPagos
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem238_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem238.ItemClick
        Dim frm As New FrmSalidasFianzasEnvases
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem239_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem239.ItemClick
        Dim frm As New FrmEnvioFianzasEnvases
        frm.MdiParent = Me
        frm.Show()

    End Sub


    Private Sub BarButtonItem242_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem242.ItemClick

        'Utiles / Gestión documental / Escaneo Pagos Liq.
        Dim frm As New FrmEscaneoPagosLiquidaciones
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub BarButtonItem243_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem243.ItemClick
        'Utiles / Producción / Generar Dom. Ped. Predefinidos
        Dim frm As New FrmActualizarDomicilioPedidosCliente()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    'Private Sub BarButtonItem244_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem244.ItemClick
    '    'Utiles / Amortizaciones / Paso datos registros
    '    Dim frm As New FrmImportarRegistrosAmortizaciones()
    '    frm.MdiParent = Me
    '    frm.Show()
    'End Sub

    Private Sub BarButtonItem244_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem244.ItemClick
        'Utiles / Produccion / Act. Linea Salida en Palet
        Dim frm As New FrmActualizarLineasSalidaPalets()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem245_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem245.ItemClick
        'Utiles / Produccion / Comprobar Lineas Sal. Palet
        Dim frm As New FrmComprobarLineasSalidaPalets()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem246_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem246.ItemClick
        'Administracion / Facturacion compras / Asientos retenciones
        Dim frm As New FrmAsientosRetencionesMes
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem247_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem247.ItemClick
        'ADM Aplicación / Utilidades / Indexar documental
        ActualizarDocumental()
        MsgBox("Terminado!")
    End Sub

    Private Sub BarButtonItem248_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem248.ItemClick
        'ADM Aplicacion / Utilidades / Acoplar iArchiva
        ActualizarDocumental_iArchiva()
        MsgBox("Terminado!")
    End Sub

    Private Sub BarButtonItem249_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem249.ItemClick

        'ADM Aplicacion / Utilidades / Año Fondo
        Dim frm As New FrmAnnoFondo
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub BarButtonItem250_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem250.ItemClick

        'Financiero / OPFH / Aportaciones Extra.
        Dim frm As New FrmAportacionesExtraordinarias
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub BarButtonItem251_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem251.ItemClick
        ''Comercial / Pedidos / Recepcion pedidos EDI
        'Dim frm As New FrmRecepcionPedidosEDI
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub BarButtonItem252_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem252.ItemClick
        'Listados comercialización / Entradas / Facturas de compras
        Dim frm As New FrmConsultaFacturasCompra
        frm.MdiParent = Me
        frm.Show()
    End Sub

   
    Private Sub BarButtonItem253_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem253.ItemClick
        'Sujetos / Proveedores de género / Modelo 346 / Conceptos
        Dim frm As New FrmConceptos346
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem254_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem254.ItemClick
        'Sujetos / Proveedores de género / Modelo 346 / Importes
        Dim frm As New FrmImporte346
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem255_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem255.ItemClick
        'Sujetos / Proveedores de género / Modelo 346 / Consulta
        Dim frm As New FrmConsulta346
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem256_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem256.ItemClick
        'Sujetos / Proveedores de género / Modelo 346 / Generar Fichero
        Dim frm As New FrmGenera346
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem257_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem257.ItemClick
        'Sujetos / Proveedores de género / Modelo 346 / Emitir Carta
        Dim frm As New FrmEmitirCarta346
        frm.MdiParent = Me
        frm.Show()
    End Sub


    Private Sub BarButtonItem258_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem258.ItemClick
        'ADM Aplicación / Utiles / Actualizar datos transf. agr.
        Dim frm As New FrmActualizarDatosTransferenciaAgricultores
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub BarButtonItem259_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem259.ItemClick
        'ADM Aplicación / Utiles / Actualizar datos transf. 2
        Dim frm As New FrmActualizarDatosTransferenciaAgricultores2
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem261_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem261.ItemClick
        'ADM Aplicacion / Utilidades / Cargar IBAN Agricultores
        Dim frm As New FrmCargarIBANAgricultores
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem262_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem262.ItemClick

        'ADM Aplicacion / Test / Actualizar referencia VEV
        Dim frm As New FrmActualizarReferenciaVEV
        frm.MdiParent = Me
        frm.Show()

    End Sub

    
End Class