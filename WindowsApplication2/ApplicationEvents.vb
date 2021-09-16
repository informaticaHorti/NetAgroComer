Imports DevExpress.XtraEditors

Namespace My

    ' Los siguientes eventos están disponibles para MyApplication:
    ' 
    ' Inicio: se desencadena cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: generado después de cerrar todos los formularios de la aplicación. Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: generado si la aplicación detecta una excepción no controlada.
    ' StartupNextInstance: se desencadena cuando se inicia una aplicación de instancia única y la aplicación ya está activa. 
    ' NetworkAvailabilityChanged: se desencadena cuando la conexión de red está conectada o desconectada.


    Partial Friend Class MyApplication


        Private err As New Errores

        Private Sub MyApplication_Shutdown(sender As Object, e As System.EventArgs) Handles Me.Shutdown

            Try
                My.Application.ApplicationContext.ExitThread()
            Catch ex As Exception

            End Try

        End Sub


        Private Sub MyApplication_Startup(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup

            Try
                MiMaletin.IdEmpresaCTB = 1

                LeerFicheroINI()
               
                cn.AbrirConexion()
                CnComun.AbrirConexion()
                For Each x As Integer In ConexCtb.Keys
                    If ConexCtb(x).CadenaConexion <> "" Then
                        ConexCtb(x).AbrirConexion()
                    End If
                Next
                cnFincasVB6.AbrirConexion()

                'Carga el diccionario con los códigos de las entidades
                CargaCodigosEntidad()

                'Carga el diccionario con los códigos de instalación
                CargaCodigosInstalacion()

            Catch ex As Exception
                err.Muestraerror("Imposible abrir conexión a base de datos", "Startup", ex.Message)
                bErrorFatal = True
            End Try


            Idaplicacion = 216



            'Actualizacion NetAgro
            ActuBaseDatos(cn)


            'Otras
            ActuBaseDatosComun(CnComun)


            Dim configuracionesdiversas As New E_ConfiguracionesDiversas(Idusuario, cn)

            Dim a As String = configuracionesdiversas.xDameValor(E_ConfiguracionesDiversas.eClaves.EJERCICIO_TECNICOS)

            MiMaletin.EjercicioTecnicos = VaInt(a)
            Try

                'Establecemos el IdUsuario
                Dim Argumentos As String = ""
                Dim nArgs As Integer = 0
                For Each argumento As String In Environment.GetCommandLineArgs()
                    Argumentos = Argumentos & argumento & " "
                    nArgs = nArgs + 1
                Next


                'Si nos llega el usuario desde el lanzador...
                If nArgs > 1 Then

                    Idusuario = VaInt(leerArgumentos("Usuario", Argumentos)).ToString

                    If VaInt(Idusuario) > 0 Then
                        Dim Usuario As New E_Usuarios(Idusuario, CnComun)
                        Usuario.LeerId(Idusuario.ToString)
                        If RealizaLogin(Idusuario, VaInt(Usuario.IdPerfil.Valor)) Then
                            Me.MainForm = _FrMPrincipal
                            CambiaColor(MiMaletin.IdPuntoVenta, Me.MainForm)
                        Else
                            Exit Sub
                        End If
                    End If

                End If


            Catch ex As Exception
                If Idusuario <> Usuario_Maestro Then
                    err.Muestraerror("Error al obtener los datos del usuario", "Startup", ex.Message)
                End If
            End Try

        End Sub


        Public Function leerArgumentos(ByVal campo As String, ByVal textoArgumentos As String) As String

            Try

                Dim resultado As String = ""
                Dim args As String() = textoArgumentos.Split(Convert.ToChar("|"))
                For Each linea As String In args

                    linea = linea.Trim
                    If Microsoft.VisualBasic.Left(linea, campo.Length).ToLower = campo.ToLower Then
                        resultado = linea.Substring(campo.Length, linea.Length - (campo.Length))
                    End If

                Next

                Return resultado


            Catch ex As Exception
                err.Muestraerror("", "", ex.Message)
                Return ""
            End Try

        End Function


        Private Function RealizaLogin(nIdUsuario As String, nIdPerfil As Integer) As Boolean

            'Comprueba que el usuario tenga permisos para ejecutar la aplicación
            Dim Configuracion As New E_Configuracion(Idusuario, CnComun)

            Dim Perfiles As New E_Perfiles(Idusuario, CnComun)
            Perfiles.LeerId(nIdPerfil)
            UsuarioAdministracion = ((Perfiles.Administrador.Valor & "").Trim.ToUpper = "S")


            Dim bTienePermiso As Boolean = Configuracion.PermisoAplicacion(nIdUsuario, nIdPerfil, Idaplicacion)
            If nIdUsuario = Usuario_Maestro Then
                bTienePermiso = True
                UsuarioAdministracion = True
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
                        Return False
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
                ' MsgBox(IdEmpresaPorDefecto.ToString)


                Dim usuarios_log As New E_Usuarios_Logs(Idusuario, cn)
                Dim Usuario As New E_Usuarios(Idusuario, CnComun)
                Dim nombreusuario As String = ""
                If Usuario.LeerId(Idusuario) = True Then
                    nombreusuario = Usuario.Nombre.Valor
                End If
                usuarios_log.NuevoUsuario(Idusuario.ToString, "", MiMaletin.IdCentro.ToString, "NetAgro", nombreusuario)


                Return True

            Else
                XtraMessageBox.Show("El usuario no tiene permisos para acceder a la aplicación")
                Return False
            End If


        End Function


        Private Sub CargaMaletin(Optional IdEmpresaAutorizada As Integer = 0)

            If VaInt(Idusuario) > 0 Then

                Dim DatosUsuario As New E_DatosUsuario(Idusuario, CnComun)
                Dim Valoresusuario As New E_valoresusuario(Idusuario, cn)
                If DatosUsuario.LeerId(Idusuario) Then

                    MiMaletin.Ejercicio = VaInt(DatosUsuario.IdEjercicio.Valor)
                    MiMaletin.IdPuntoVenta = VaInt(DatosUsuario.IdPVenta.Valor)
                    MiMaletin.IdCentroRecogida = MiMaletin.IdPuntoVenta
                    If Valoresusuario.LeerId(Idusuario) = True Then
                        MiMaletin.IdCentroRecogida = VaInt(Valoresusuario.VUS_IdCentroRecogida.Valor)
                    End If

                    Dim IdEmpresa = IdEmpresaAutorizada
                    If IdEmpresa = 0 Then IdEmpresa = PrimeraEmpresaDisponible()
                    MiMaletin.CargaMaletin(IdEmpresa, DatosUsuario.IdEjercicio.Valor, DatosUsuario.IdPVenta.Valor, Valoresusuario.VUS_IdCentroRecogida.Valor)

                Else
                    If Idusuario <> Usuario_Maestro Then
                        Throw New Exception("Error cuando se intentaban obtener los datos de usuario")
                    End If

                End If

            End If

        End Sub


    End Class





End Namespace

