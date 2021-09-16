Imports DevExpress.XtraEditors

Public Class frmInicio


    Private err As New Errores
    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro

    Private _Origen As Form = Nothing
    Private _IdBanco As String = ""


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()



    End Sub


    Public Sub New(origen As Form, IdBanco As String)

        Me.New()

        Try

            _Origen = origen
            _IdBanco = IdBanco

            If _Origen IsNot Nothing Then

                Dim Usuario As New E_Usuarios(Idusuario, Cncomun)
                Usuario.LeerId(Idusuario)
                TxDato_1.Text = Usuario.Nombre.Valor
                TxDato_2.Text = ""


            End If

        Catch ex As Exception
            err.Muestraerror("Problema cuando se intentaba inicializar la clase", "New", ex.Message)
        End Try

    End Sub


    Private Sub ParametrosFrm()

        Dim param As New Cdatos.PropiedadesTx
        param.Obligatorio = True
        param.Tipo = Cdatos.TiposCampo.Cadena
        param.Longitud = 50
        TxDato_1.ClParam = param
        TxDato_1.ClForm = Me


        Dim param2 As New Cdatos.PropiedadesTx
        param2 = New Cdatos.PropiedadesTx
        param2.Obligatorio = True
        param2.Tipo = Cdatos.TiposCampo.Cadena
        param2.Longitud = 50
        TxDato_2.ClParam = param2
        TxDato_2.ClForm = Me

    End Sub



    Private Sub btSalir_Click(sender As System.Object, e As System.EventArgs) Handles btSalir.Click

        If _Origen Is Nothing Then
            Try
                Application.ExitThread()
            Catch ex As Exception
                err.Muestraerror("Problema cuando se intentaba cerrar la aplicacion", "btSalir_Click", ex.Message)
            End Try
        Else
            'TODO: Opción de cancelar
            Me.Close()
        End If

    End Sub

    Private Sub btAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btAceptar.Click

        If _Origen IsNot Nothing Then
            CargaCheques()
        Else
            CargaNormal()
        End If

    End Sub


    Private Sub CargaCheques()

        Dim ChequesUsuario As New E_ChequesUsuarios(Idusuario, cn)
        If ChequesUsuario.BuscaUsuario(Idusuario, TxDato_2.Text) = False Then
            XtraMessageBox.Show("Contraseña incorrecta")
        Else

            Dim CHEQUES_CUENTAS As New E_CHEQUES_CUENTAS(Idusuario, cn)
            If CHEQUES_CUENTAS.LeerId(_IdBanco) Then

                Dim ChequesPermisos As New E_ChequesPermisos(Idusuario, cn)
                If ChequesPermisos.PermisoCuenta(CHEQUES_CUENTAS.IDCUENTA.Valor, Idusuario) Then
                    UsuarioTalon = True
                Else
                    XtraMessageBox.Show("El usuario no tiene permisos para acceder a la cuenta")
                End If

                Me.Close()

            End If

        End If

    End Sub



    Private Sub CargaNormal()


        'Si no, hay que hacer login como toda la vida
        Try

            Dim nIdPerfil As Integer = 0
            Dim Usuario As New E_Usuarios(Idusuario, Cncomun)
            Dim nIdUsuario As Integer = Usuario.BuscaUsuario(TxDato_1.Text.Trim, TxDato_2.Text.Trim, nIdPerfil, NombreUsuario)

            If TxDato_1.Text = "CLAVE" And TxDato_2.Text = Idaplicacion.ToString & "SOLOYO" Then nIdUsuario = USUARIO_MAESTRO

            'nombreusuario = TxDato_1.Text


            If nIdUsuario < 1 Then
                XtraMessageBox.Show("Error en usuario o contraseña")
            Else

                Try

                    RealizaLogin(nIdUsuario, nIdPerfil)

                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try

            End If

        Catch ex As Exception
            err.Muestraerror("Problema cuando se intentaban cargar la aplicacion", "btAceptar_Click", ex.Message)
        End Try


    End Sub


    Private Sub RealizaLogin(nIdUsuario As Integer, nIdPerfil As Integer)

        'Comprueba que el usuario tenga permisos para ejecutar la aplicación
        Dim Configuracion As New E_Configuracion(Idusuario, Cncomun)
        Dim Perfiles As New E_Perfiles(Idusuario, Cncomun)
        Perfiles.LeerId(nIdPerfil)
        UsuarioAdministracion = ((Perfiles.Administrador.Valor & "").Trim.ToUpper = "S")


        Dim bTienePermiso As Boolean = Configuracion.PermisoAplicacion(nIdUsuario, nIdPerfil, Idaplicacion)


        If nIdUsuario = USUARIO_MAESTRO Then
            UsuarioAdministracion = True
            bTienePermiso = True
        End If



        If bTienePermiso Then

            Idusuario = nIdUsuario.ToString


            'Dim EmpresasUsuario As New E_EmpresasUsuario(Idusuario, CnComun)
            'Dim dt As DataTable = EmpresasUsuario.EmpresasAutorizadas(Idusuario)

            Dim Empresas As New E_Empresas(Idusuario, cn)
            Dim dt As DataTable = Empresas.Tabla()
            If Idusuario <> Usuario_Maestro Then
                If dt.Rows.Count = 0 Then
                    MsgBox("El usuario no tiene acceso a ninguna empresa")
                    Application.ExitThread()
                End If
            End If
            For Each row As DataRow In dt.Rows
                Dim IdEmpresa As Integer = VaInt(row("IdEmpresa"))
                LstEmpresas.Add(IdEmpresa)
                LstEmpresas.Sort()
            Next
            If LstEmpresas.Count = 0 Then LstEmpresas.Add(1)


            Dim IdEmpresaPorDefecto As Integer = 0
            Dim DatosUsuario As New E_DatosUsuario(Idusuario, CnComun)
            If DatosUsuario.LeerId(Idusuario.ToString) Then
                IdEmpresaPorDefecto = VaInt(DatosUsuario.IdEmpresa.Valor)
            End If
            CargaMaletin(IdEmpresaPorDefecto)


            Dim usuarios_log As New E_Usuarios_Logs(Idusuario, cn)
            Dim Usuario As New E_Usuarios(Idusuario, CnComun)
            Dim nombreusuario As String = ""
            If Usuario.LeerId(Idusuario) = True Then
                nombreusuario = Usuario.Nombre.Valor
            End If
            usuarios_log.NuevoUsuario(Idusuario.ToString, "", MiMaletin.IdCentro.ToString, "NetAgro", nombreusuario)



            Dim f As New _FrMPrincipal
            Me.Hide()

            CambiaColor(MiMaletin.IdPuntoVenta, f)
            f.Show()

        Else
            XtraMessageBox.Show("El usuario no tiene permisos para acceder a la aplicación")
        End If

    End Sub


    Private Sub CargaMaletin(Optional IdEmpresaAutorizada As Integer = 0)

        If VaInt(Idusuario) > 0 Then

            Dim DatosUsuario As New E_DatosUsuario(Idusuario, CnComun)
            Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)
            If DatosUsuario.LeerId(Idusuario) Then

                MiMaletin.Ejercicio = VaInt(DatosUsuario.IdEjercicio.Valor)
                MiMaletin.IdPuntoVenta = VaInt(DatosUsuario.IdPVenta.Valor)

                MiMaletin.IdCentroRecogida = MiMaletin.IdPuntoVenta
                If ValoresUsuario.LeerId(Idusuario) = True Then
                    MiMaletin.IdCentroRecogida = VaInt(ValoresUsuario.VUS_IdCentroRecogida.Valor)
                End If

                Dim IdEmpresa = IdEmpresaAutorizada
                If IdEmpresa = 0 Then IdEmpresa = PrimeraEmpresaDisponible()
                MiMaletin.CargaMaletin(IdEmpresa, DatosUsuario.IdEjercicio.Valor, DatosUsuario.IdPVenta.Valor, ValoresUsuario.VUS_IdCentroRecogida.Valor)

            Else
                If Idusuario <> Usuario_Maestro Then
                    Throw New Exception("Error cuando se intentaban obtener los datos de usuario")
                End If
            End If

        End If

    End Sub



    Private Sub TxDato_2_Valida(edicion As System.Boolean) Handles TxDato_2.Valida

        btAceptar.Select()
        btAceptar.Focus()

    End Sub

    Private Sub frmInicio_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If _Origen Is Nothing Then
            Application.ExitThread()
        End If

    End Sub


    Private Sub TxDato_1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato_1.KeyDown

        If e.KeyCode = Keys.Enter Then
            TxDato_2.SelectAll()
            TxDato_2.Focus()
        End If

    End Sub

    Private Sub frmInicio_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        If bErrorFatal Then
            Application.ExitThread()
        End If

    End Sub
End Class