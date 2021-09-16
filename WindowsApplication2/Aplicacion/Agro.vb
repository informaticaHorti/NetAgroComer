Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Module Agro



    Public Const CentroAsientos As Integer = 1

    Public Const Usuario_Maestro As Integer = 999
    Public bErrorFatal As Boolean = False
    Public UsuarioAdministracion As Boolean = False
    Public Idaplicacion As Integer = 214
    Public UsuarioTalon As Boolean = False
    Public BloqueoUsuarios As Integer = 0
    Public procesosUsuarios As Integer = 0
    Public NombreUsuario As String = ""


    Public cadenaconexionodbc As String
    Public cadenaconexionComun As String
    Public cadenaconexionCtb As String
    'Public cadenaconexionCtb_1 As String
    'Public cadenaconexionCtb_2 As String
    'Public cadenaconexionCtb_3 As String
    'Public cadenaconexionCtb_4 As String
    'Public cadenaconexionCtb_5 As String
    'Public cadenaconexionCtb_6 As String
    'Public cadenaconexionCtb_7 As String
    'Public cadenaconexionCtb_8 As String
    'Public cadenaconexionCtb_9 As String
    'Public cadenaconexionCtb_10 As String
    'Public cadenaconexionCtb_11 As String
    'Public cadenaconexionCtb_12 As String
    'Public cadenaconexionCtb_13 As String
    'Public cadenaconexionCtb_14 As String
    'Public cadenaconexionCtb_15 As String
    'Public cadenaconexionCtb_16 As String
    'Public cadenaconexionCtb_17 As String
    'Public cadenaconexionCtb_18 As String
    'Public cadenaconexionCtb_19 As String
    'Public cadenaconexionCtb_20 As String



    Public cadenaconexiondoc As String
    Public cadenaconexionFinanciero As String
    Public cadenaconexionFincas As String
    Public cadenaconexionFincasNET As String
    Public cadenaconexionCalidad As String

    Public ConectarFinancieroContabilidad As String
    Public ImpresionDePrueba As String
    Public ImpresionDirectaVB6 As String

    Public cn As Cdatos.Conexion
    Public CnComun As Cdatos.Conexion
    'Public ConexCtb(20) As Cdatos.Conexion

    Public ConexCtb As New Dictionary(Of Integer, Cdatos.Conexion)
    Public LstEmpresas As New List(Of Integer)
    Public RaizCtb As String = ""
    Public SeparadorCtb As String = ""
    Public cnFincasVB6 As Cdatos.Conexion
    Public cnFincasNET As Cdatos.Conexion
    Public cnCalidad As Cdatos.Conexion

    'Public NombreBdCtb As String = ""
    'Public NombreBdCtb_1 As String = ""
    'Public NombreBdCtb_2 As String = ""
    'Public NombreBdCtb_3 As String = ""
    'Public NombreBdCtb_4 As String = ""
    'Public NombreBdCtb_5 As String = ""

    Public MiMaletin As New Maletin
    Public Color_PV_Principal As Color
    Public Color_PV_BarraEstado As Color

    Public Idusuario As Integer
    Public DcLogTablas As New Dictionary(Of String, String)
    Public DcAltTablas As New Dictionary(Of String, String)

    Public EnlaceCodigo As String = ""
    Public Ventorno As StEntorno

    Public RowDePaso As DataRow = Nothing
    Public EntidadDePaso As Cdatos.Entidad = Nothing

    Public DcCodigosEntidad As New Dictionary(Of String, String)
    Public DcCodigosInstalacion As New Dictionary(Of String, String)

    Public CnDoc As Cdatos.Conexion '("Driver={SQL Server Native Client 10.0};server=192.168.24.13\sa;database=DocClave;uid=sa;pwd=Adminis;Persist Security Info=true;")
    Public PathDocumentos As String '= "C:\BdDocs"
    Public TipDocumental As Integer ' 0=clave, 1=nuxeo
    Public IdBasculaEntrada As Integer = 0

    Public TimeOutConsulta As Integer = 0

    Public DigitosRfid As Integer = 14


    Public NumeroMuelleIzquierda As String = ""
    Public NumeroMuelleDerecha As String = ""
    Public PuertoLector As String = ""
    Public PuertoImpresoraRFID As String = ""

    Public AjusteTag As String = ""




    Public Class Maletin

        Public Ejercicio As Integer
        Public NombreEmpresa As String
        Public NIF_Empresa As String
        Public IdPuntoVenta As Integer
        Public IdCentro As Integer
        Public IdCentroRecogida As Integer
        Public IdActividad As Integer
        Public IdSeccion As Integer
        Public FechaInicioEjercicio As Date
        Public FechaFinEjercicio As Date
        Public ConectaSuministros As Boolean = False
        Public ConectaExportacion As Boolean = False
        Public FechaCtbIva As Date
        Public FechaCtbPagos As Date
        Public idprogramacliente As Integer
        Public EjercicioTecnicos As Integer
        Public IdEmpresaCTB As Integer

        Public IdOperario As Integer




        Public Sub CargaMaletin(ByVal IdEmpresa As String, ByVal IdEjercicio As String, ByVal IdPuntoVenta As String, ByVal IdCentroRe As String, Optional ByRef TextoEjercicio As String = "", Optional ByRef TextoPVenta As String = "", Optional ByRef TextoCrecogida As String = "", Optional ByRef TextoCalidad As String = "")

            Dim Ejercicio As New E_Ejercicios(Idusuario, ConexCtb(IdEmpresa))
            Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(IdEmpresa))
            Dim Centros As New E_centros(Idusuario, ConexCtb(IdEmpresa))
            Dim Empresas As New E_Empresas(Idusuario, cn)
            Dim CentroRecogida As New E_centrosrecogida(Idusuario, cn)
            'Dim ProgramaCalidad As New E_ProgramaCalidad(Idusuario, cn)
            Dim NormasCalidad As New E_NormasCalidad(Idusuario, cn)
            Dim Valorespventa As New E_valorespventa(Idusuario, cn)


            Ejercicio.LeerId(IdEjercicio)
            MiMaletin.FechaInicioEjercicio = VaDate(Ejercicio.FechaDesde.Valor)
            MiMaletin.FechaFinEjercicio = VaDate(Ejercicio.FechaHasta.Valor)
            'MiMaletin.FechaCtbIva = VaDate(Ejercicio.FechaTrabDesde.Valor)
            MiMaletin.FechaCtbIva = VaDate(Ejercicio.FechaBloqueoIva.Valor)
            TextoEjercicio = Ejercicio.FechaDesde.Valor & " " & Ejercicio.FechaHasta.Valor

            PuntoVenta.LeerId(IdPuntoVenta)
            MiMaletin.IdCentro = VaInt(PuntoVenta.IdCentro.Valor)
            MiMaletin.IdActividad = VaInt(PuntoVenta.IdActividad.Valor)
            MiMaletin.IdSeccion = VaInt(PuntoVenta.IdSeccion.Valor)
            TextoPVenta = PuntoVenta.Nombre.Valor & ""


            Centros.LeerId(PuntoVenta.IdCentro.Valor)
            MiMaletin.ConectaSuministros = (Centros.Suministros.Valor & "").Trim.ToUpper = "S"
            MiMaletin.ConectaExportacion = (Centros.Exportacion.Valor & "").Trim.ToUpper = "S"

            If Valorespventa.LeerId(IdPuntoVenta) = True Then
                If VaInt(Valorespventa.VPV_IdEmpresa.Valor) > 0 Then
                    IdEmpresa = VaInt(Valorespventa.VPV_IdEmpresa.Valor)
                End If
            End If


            Empresas.LeerId(IdEmpresa)
            MiMaletin.NombreEmpresa = Empresas.EMP_Nombre.Valor
            MiMaletin.IdEmpresaCTB = VaInt(IdEmpresa)
            CentroRecogida.LeerId(IdCentroRecogida)
            TextoCrecogida = CentroRecogida.CER_Nombre.Valor


            Dim DatosEmpresa As New E_DatosEmpresa(Idusuario, ConexCtb(IdEmpresa))
            If DatosEmpresa.LeerId(IdEmpresa) Then
                MiMaletin.NIF_Empresa = (DatosEmpresa.NifDeclarante.Valor & "").Trim
            End If


            If idprogramacliente = 0 Then
                TextoCalidad = "General"
            Else
                'ProgramaCalidad.LeerId(idprogramacliente)
                'TextoCalidad = ProgramaCalidad.PRO_Nombre.Valor
                NormasCalidad.LeerId(idprogramacliente)
                TextoCalidad = NormasCalidad.NOR_Nombre.Valor
            End If


            DcEmpresaPventa.Clear()
            Dim sql As String = "Select vpv_idpventa,vpv_idempresa from valorespventa "
            Dim dt As DataTable = Valorespventa.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                For Each rw In dt.Rows
                    DcEmpresaPventa.Add(VaInt(rw("vpv_idpventa")), VaInt(rw("vpv_idempresa")))
                Next
            End If


        End Sub

    End Class


    Public Function CompruebaIBAN(ByVal cuenta As String) As Boolean

        Dim esValido As Boolean = False
        Dim i As Integer = 2
        Dim cadenaLetras As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim caracterAcii As Integer = 0, resto As Integer = 0, dc As Integer = 0
        Dim cuentaNumero As Decimal
        Dim cadenaDC = ""

        If (cuenta.Length = 24 And InStr(cadenaLetras, cuenta.Substring(0, 1).ToUpper) > 0 And _
            InStr(cadenaLetras, cuenta.Substring(1, 1).ToUpper) > 0) Then

            Do
                caracterAcii = Asc(cuenta.Substring(i, 1))
                esValido = (caracterAcii > 47 And caracterAcii < 58)
                i += 1
            Loop While (i < cuenta.Length And esValido)

            If (esValido) Then
                cuentaNumero = Decimal.Parse(cuenta.Substring(4, 20) + "142800")
                resto = cuentaNumero Mod 97
                dc = 98 - resto
                cadenaDC = Str(dc).Trim
            End If

            If (dc < 10) Then
                cadenaDC = "0" + cadenaDC
            End If

            If String.Compare(cuenta.Substring(2, 2), cadenaDC) = 0 Then
                esValido = True
            Else
                esValido = False
            End If
        End If

        Return esValido

    End Function


    Public Sub CambiaColor(ByVal IdPuntoVenta As String, ByVal frmPrincipal As _FrMPrincipal)

        Color_PV_Principal = Color.FromArgb(224, 224, 224)
        Color_PV_BarraEstado = SystemColors.Control


        Dim ValoresPVenta As New E_valorespventa(Idusuario, cn)
        If ValoresPVenta.LeerId(IdPuntoVenta) Then

            Dim R As Integer = 0
            Dim G As Integer = 0
            Dim B As Integer = 0

            Dim texto_color As String = (ValoresPVenta.VPV_Color.Valor & "").Trim
            Dim rgb As String() = texto_color.Split(Convert.ToChar(";"))

            If rgb.Length > 0 Then R = VaInt(rgb(0))
            If rgb.Length > 1 Then G = VaInt(rgb(1))
            If rgb.Length > 2 Then B = VaInt(rgb(2))

            Color_PV_Principal = Color.FromArgb(R, G, B)
            Color_PV_BarraEstado = Color.FromArgb(155, R, G, B)

        End If


        For Each ctl As Control In frmPrincipal.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                Dim ctlMDI As MdiClient = DirectCast(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Color_PV_Principal
                ' Catch and ignore the error if casting failed.
            Catch exc As InvalidCastException
            End Try
        Next


    End Sub


    Public Structure StLmed
        Public Kilos As Double
        Public Bultos As Double
        Public Piezas As Double
        Public id As Integer

    End Structure


    Public Structure StEntorno
        Public pventa As Integer
        Public crecogida As Integer
        Public subasta As Integer
        Public centro As Integer
        Public fechasubasta As Date
        Public Normalizada As Boolean

    End Structure


    ''' <summary>
    ''' variables cargadas desde el fichero ini
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LeerFicheroINI()

        Dim inifile As String = Application.StartupPath & "\ClaveAgro.dll"

        ' -----------------------------------------------------------------------------------------
        cadenaconexionodbc = LeerConfig(inifile, "ConexionNetAgro")
        cn = New Cdatos.Conexion(cadenaconexionodbc)

        cadenaconexionComun = LeerConfig(inifile, "ConexionComun")
        CnComun = New Cdatos.Conexion(cadenaconexionComun)

        cadenaconexionCtb = LeerConfig(inifile, "ConexionCtb") ' dejo esta por si acaso
        ' CnCtb = New Cdatos.Conexion(cadenaconexionCtb)


        RaizCtb = LeerConfig(inifile, "NombreBdCtb")
        SeparadorCtb = LeerConfig(inifile, "SeparadorCtb")


        LeerConexCtb(inifile)
        If Not ConexCtb.ContainsKey(1) Then ConexCtb(1) = New Cdatos.Conexion(cadenaconexionCtb)


        'cadenaconexionCtb_1 = LeerConfig(inifile, "ConexionCtb_1")
        'If cadenaconexionCtb_1 = "" Then
        '    ConexCtb(1) = New Cdatos.Conexion(cadenaconexionCtb)
        'Else
        '    ConexCtb(1) = New Cdatos.Conexion(cadenaconexionCtb_1)
        'End If




        'cadenaconexionCtb_2 = LeerConfig(inifile, "ConexionCtb_2")
        'ConexCtb(2) = New Cdatos.Conexion(cadenaconexionCtb_2)


        'cadenaconexionCtb_3 = LeerConfig(inifile, "ConexionCtb_3")
        'ConexCtb(3) = New Cdatos.Conexion(cadenaconexionCtb_3)


        'cadenaconexionCtb_4 = LeerConfig(inifile, "ConexionCtb_4")
        'ConexCtb(4) = New Cdatos.Conexion(cadenaconexionCtb_4)


        'cadenaconexionCtb_5 = LeerConfig(inifile, "ConexionCtb_5")
        'ConexCtb(5) = New Cdatos.Conexion(cadenaconexionCtb_5)




        cadenaconexiondoc = LeerConfig(inifile, "ConexionDoc")
        CnDoc = New Cdatos.Conexion(cadenaconexiondoc)


        cadenaconexionFincas = LeerConfig(inifile, "ConexionFincas")
        cnFincasVB6 = New Cdatos.Conexion(cadenaconexionFincas)

        cadenaconexionFincasNET = LeerConfig(inifile, "ConexionFincasNET")
        cnFincasNET = New Cdatos.Conexion(cadenaconexionFincasNET)


        cadenaconexionCalidad = LeerConfig(inifile, "ConexionCalidad")
        cnCalidad = New Cdatos.Conexion(cadenaconexionCalidad)


        'NombreBdCtb_1 = LeerConfig(inifile, "NombreBdCtb_1")
        'NombreBdCtb_2 = LeerConfig(inifile, "NombreBdCtb_2")
        'NombreBdCtb_3 = LeerConfig(inifile, "NombreBdCtb_3")
        'NombreBdCtb_4 = LeerConfig(inifile, "NombreBdCtb_4")
        'NombreBdCtb_5 = LeerConfig(inifile, "NombreBdCtb_5")

        'NombreBdCtb = NombreBdCtb_1 ' por defecto la 1 

        'If NombreBdCtb = "" Then
        '    NombreBdCtb = LeerConfig(inifile, "NombreBdCtb")
        'End If



        PathDocumentos = LeerConfig(inifile, "PathDocumentos")
        TipDocumental = VaInt(LeerConfig(inifile, "Documental"))

        BloqueoUsuarios = VaInt(LeerConfig(inifile, "BloqueoUsuarios"))
        procesosUsuarios = VaInt(LeerConfig(inifile, "ProcesosUsuarios"))

        ConectarFinancieroContabilidad = LeerConfig(inifile, "ConectarFinancieroContabilidad")

        ImpresionDePrueba = LeerConfig(inifile, "ImpresionDePrueba")

        ImpresionDirectaVB6 = LeerConfig(inifile, "ImpresionDirectaVB6")

        TimeOutConsulta = VaInt(LeerConfig(inifile, "TimeOutConsulta"))

        DigitosRfid = VaInt(LeerConfig(inifile, "DigitosRfid"))


    End Sub


    Public Sub LeerConexCtb(ByVal fichero As String)

        ConexCtb.Clear()

        Try

            Dim fs As New IO.FileStream(fichero, IO.FileMode.Open)
            Dim sr As New System.IO.StreamReader(fs)
            Dim valor As String = ""
            Dim linea As String = sr.ReadLine

            While linea <> Nothing

                If linea.Contains("=") Then

                    Dim posSeparador As Integer = linea.IndexOf("=") + 1
                    Dim param As String = linea.Substring(0, posSeparador - 1)

                    If param.ToLower.StartsWith("conexionctb_") Then
                        If linea.Length - posSeparador > 0 Then

                            Dim numero As String = param.ToUpper.Replace("CONEXIONCTB_", "")
                            valor = linea.Substring(posSeparador, linea.Length - posSeparador)

                            If IsNumeric(numero) Then

                                Dim conexion As New Cdatos.Conexion(valor)
                                ConexCtb(VaInt(numero)) = conexion

                            End If

                        End If
                    End If

                End If

                linea = sr.ReadLine

            End While

            sr.Dispose()
            fs.Close()
            sr.Close()



        Catch ex As Exception
            MsgBox("Error al tratar de leer las conexiones a contabilidad")
        End Try

    End Sub


    Public Function LeerConfig(ByVal fichero As String, ByVal campo As String) As String

        Try

            Dim fs As New IO.FileStream(fichero, IO.FileMode.Open)
            Dim sr As New System.IO.StreamReader(fs)
            Dim valor As String = ""
            Dim linea As String = sr.ReadLine

            While linea <> Nothing

                If linea.Contains("=") Then

                    Dim posSeparador As Integer = linea.IndexOf("=") + 1
                    Dim param As String = linea.Substring(0, posSeparador - 1)

                    If param.ToLower = campo.ToLower() Then
                        If linea.Length - posSeparador > 0 Then
                            valor = linea.Substring(posSeparador, linea.Length - posSeparador)
                        End If
                    End If

                End If

                linea = sr.ReadLine

            End While

            sr.Dispose()
            fs.Close()
            sr.Close()


            Return valor

        Catch ex As Exception
            MsgBox("Error al tratar de leer la configuración (" & campo & ")")
            Return ""
        End Try

    End Function


    Public Sub AñadirColumnaAlGrid(ByRef Grid As ClGrid, ByVal NombreColumna As String, ByVal tipo As System.Type)

        'Para Llamar: AñadirColumnaAlGrid(ClGrid1, "P1", GetType(System.Drawing.Image))

        AñadirColumnaAlGridView(Grid.Grid, Grid.GridView, NombreColumna, tipo)



    End Sub


    Public Sub AñadirColumnaAlGridView(ByRef Grid As DevExpress.XtraGrid.GridControl, ByRef GridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal NombreColumna As String, ByVal tipo As System.Type)

        'Para Llamar: AñadirColumnaAlGrid(ClGrid1, "P1", GetType(System.Drawing.Image))


        If Not IsNothing(Grid.DataSource) Then

            If TypeOf Grid.DataSource Is DataTable Then

                If Not CType(Grid.DataSource, DataTable).Columns.Contains(NombreColumna) Then
                    Dim col As New DataColumn(NombreColumna, GetType(Image))
                    CType(Grid.DataSource, DataTable).Columns.Add(col)
                    'Grid.GridView.FocusedRowHandle = Grid.GridView.RowCount - 2
                End If


                If IsNothing(GridView.Columns.ColumnByFieldName(NombreColumna)) Then

                    Dim unb As DevExpress.XtraGrid.Columns.GridColumn = GridView.Columns.AddField(NombreColumna)
                    unb.Visible = True

                End If

                If IsNothing(GridView.Columns(NombreColumna).ColumnEdit) Then

                    If tipo = GetType(Image) Then
                        Dim rep As New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
                        rep.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
                        rep.NullText = " "
                        rep.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image
                        GridView.Columns(NombreColumna).ColumnEdit = rep
                    End If

                End If

            End If

        End If

    End Sub


    Public Function PermisoFormulario(ByVal IdUsuario As Integer, ByVal NombreFormulario As String, ByRef TextoError As String) As String


        If IdUsuario = Usuario_Maestro Then
            Return PermisosFormularios.Alta & PermisosFormularios.Modificaciones & PermisosFormularios.Bajas
        End If


        Dim resultado As String = ""

        Try

            Dim LogFormularios As New E_LogFormularios(IdUsuario, cn)
            Dim Usuarios As New E_Usuarios(IdUsuario, CnComun)
            If Usuarios.LeerId(IdUsuario) Then

                Dim CONSULTA As New Cdatos.E_select
                CONSULTA.SelCampo(LogFormularios.LOF_Id, "Id")
                CONSULTA.SelCampo(LogFormularios.LOF_Permisos, "Permisos")
                CONSULTA.WheCampo(LogFormularios.LOF_IdPerfil, "=", VaInt(Usuarios.IdPerfil.Valor))

                Dim sql As String = CONSULTA.SQL & vbCrLf & _
                " AND UPPER(LOF_NombreFormulario) = UPPER('" & NombreFormulario & "')" & vbCrLf & _
                " ORDER BY LOF_Id DESC"  'Y si hay más de uno? No deberia
                Dim dt As DataTable = LogFormularios.MiConexion.ConsultaSQL(sql)

                If dt.Rows.Count > 0 Then
                    resultado = dt.Rows(0)("Permisos").ToString & ""
                End If

            End If


        Catch ex As Exception
            TextoError = ex.Message
        End Try



        Return resultado

    End Function


    Public Function ObtenerBotonesMenu(ByVal padre As _FrMPrincipal, ByRef TextoError As String) As DataTable

        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("Pestaña", GetType(System.String)))
        dt.Columns.Add(New DataColumn("Grupo", GetType(System.String)))
        dt.Columns.Add(New DataColumn("SubGrupo", GetType(String)))
        dt.Columns.Add(New DataColumn("NombreControl", GetType(System.String)))
        dt.Columns.Add(New DataColumn("NombreBoton", GetType(System.String)))


        Try


            For Each pagina As DevExpress.XtraBars.Ribbon.RibbonPage In padre.RibbonControl.Pages

                For Each grupo As DevExpress.XtraBars.Ribbon.RibbonPageGroup In pagina.Groups

                    For Each item As DevExpress.XtraBars.BarItemLink In grupo.ItemLinks

                        If item.Item.GetType.Name.ToLower = "barbuttonitem" Then

                            Dim fila As DataRow = dt.NewRow()
                            fila("Pestaña") = pagina.Text
                            fila("Grupo") = grupo.Text
                            'fila("SubGrupo") = grupo.Text
                            fila("NombreControl") = item.Item.Name
                            fila("NombreBoton") = item.Caption
                            dt.Rows.Add(fila)

                        ElseIf item.Item.GetType.Name.ToLower = "barsubitem" Then

                            Dim lst As DevExpress.XtraBars.BarSubItem = CType(item.Item, DevExpress.XtraBars.BarSubItem)
                            For Each sitem As DevExpress.XtraBars.BarItemLink In lst.ItemLinks

                                Dim fila As DataRow = dt.NewRow()
                                fila("Pestaña") = pagina.Text
                                fila("Grupo") = grupo.Text
                                fila("SubGrupo") = item.Caption
                                fila("NombreControl") = sitem.Item.Name
                                fila("NombreBoton") = sitem.Caption
                                dt.Rows.Add(fila)

                            Next

                        End If

                    Next

                Next

            Next



            Dim colSel As New DataColumn("S", GetType(System.Boolean))
            colSel.DefaultValue = False
            dt.Columns.Add(colSel)


            Dim dv As New DataView(dt)
            dv.Sort = "Pestaña, Grupo, SubGrupo, NombreBoton"
            dt = dv.ToTable


        Catch ex As Exception
            TextoError = ex.Message
        End Try


        Return dt

    End Function


    Public Function ObtenerFormulariosMantenimiento(ByRef TextoError As String) As DataTable


        Dim dt As New DataTable

        Try

            dt.Columns.Add(New DataColumn("NombreFormulario", GetType(System.String)))      'Se refiere al nombre del control
            dt.Columns.Add(New DataColumn("Formulario", GetType(System.String)))            'Se refiere al texto del formulario

            Dim colAltas As New DataColumn("Altas", GetType(System.Boolean))
            Dim colModificaciones As New DataColumn("Modificaciones", GetType(System.Boolean))
            Dim colBajas As New DataColumn("Bajas", GetType(System.Boolean))

            colAltas.DefaultValue = False
            colModificaciones.DefaultValue = False
            colBajas.DefaultValue = False

            dt.Columns.Add(colAltas)
            dt.Columns.Add(colModificaciones)
            dt.Columns.Add(colBajas)




            Dim asm As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly

            For Each ty As Type In asm.GetTypes()

                Dim NombreFormulario As Type = asm.GetType(ty.FullName)

                'If NombreFormulario.FullName.Equals("Microsoft.Office.Interop.Outlook.Account") Then
                '    Dim a As String = ""
                'End If

                ' System.IO.File.AppendAllText("c:\temp\MyTest.txt", NombreFormulario.FullName.ToString & vbCrLf)

                If Not NombreFormulario.FullName.StartsWith("Microsoft.") Then


                    If ty.BaseType.Name.ToLower = "frmantenimiento" Then


                        Try

                            Dim f As FrMantenimiento = DirectCast(Activator.CreateInstance(NombreFormulario), FrMantenimiento)

                            Dim fila As DataRow = dt.NewRow()
                            fila("NombreFormulario") = f.Name
                            fila("Formulario") = f.Text
                            dt.Rows.Add(fila)

                        Catch ex As Exception

                            Dim a As String = ""

                        End Try


                    End If
                End If

            Next


            Dim dv As New DataView(dt)
            dv.Sort = "Formulario"
            dt = dv.ToTable

        Catch ex As Exception
            TextoError = ex.Message
        End Try



        Return dt

    End Function



    Public Function ObtenerFormularios(ByRef TextoError As String) As DataTable


        Dim dt As New DataTable

        Try

            dt.Columns.Add(New DataColumn("NombreFormulario", GetType(System.String)))      'Se refiere al nombre del control
            dt.Columns.Add(New DataColumn("Formulario", GetType(System.String)))            'Se refiere al texto del formulario

            Dim asm As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly

            For Each ty As Type In asm.GetTypes()

                Dim NombreFormulario As Type = asm.GetType(ty.FullName)

                If Not NombreFormulario.FullName.StartsWith("Microsoft.") Then

                    If ty.BaseType.Name.ToLower = "frmantenimiento" Or
                        ty.BaseType.Name.ToLower = "frconsulta" Or
                        ty.BaseType.Name.ToLower = "form" Then


                        Dim f As Form = DirectCast(Activator.CreateInstance(NombreFormulario), Form)
                        Dim fila As DataRow = dt.NewRow()
                        fila("NombreFormulario") = ty.Name
                        fila("Formulario") = f.Text & " (" & f.Name & ")"
                        dt.Rows.Add(fila)

                    End If

                End If

            Next


            Dim dv As New DataView(dt)
            dv.Sort = "Formulario"
            dt = dv.ToTable

        Catch ex As Exception
            TextoError = ex.Message
        End Try



        Return dt

    End Function



    Public Function ObtenerTablasAplicacion() As DataTable

        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("Tabla", GetType(System.String)))
        dt.Columns.Add(New DataColumn("Prefijo", GetType(System.String)))

        Dim txt As String = ""

        Try

            Dim asm As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly

            For Each ty As Type In asm.GetTypes()

                If Not ty.FullName.StartsWith("Microsoft.") Then

                    If ty.BaseType.Name.ToLower = "entidad" Then

                        Dim p As New List(Of Object)
                        p.Add(Idusuario)
                        p.Add(cn)

                        txt = ty.FullName


                        Dim Entidad As Cdatos.Entidad = DirectCast(Activator.CreateInstance(asm.GetType(ty.FullName), p.ToArray), Cdatos.Entidad)

                        If Entidad.NombreBd.ToUpper.Trim = "NETAGROCOMER" And Not Entidad.EsVista Then
                            Dim fila As DataRow = dt.NewRow()
                            fila("Tabla") = Entidad.NombreTabla
                            If DcCodigosEntidad.ContainsKey(Entidad.NombreTabla.ToUpper.Trim) Then
                                fila("Prefijo") = DcCodigosEntidad(Entidad.NombreTabla.ToUpper.Trim)
                            End If
                            dt.Rows.Add(fila)
                        End If


                    End If

                End If

            Next

            Dim dv As New DataView(dt)
            dv.Sort = "Tabla"
            dt = dv.ToTable


        Catch ex As Exception
            MsgBox(txt)
            dt = Nothing
        End Try


        Dim colSel As New DataColumn("LogSN", GetType(System.Boolean))
        colSel.DefaultValue = False
        dt.Columns.Add(colSel)


        Return dt

    End Function



    Public Function ObtenerPermisosFormularios(ByVal IdPerfil As Integer, ByRef TextoError As String) As DataTable


        Dim dt As DataTable

        Try

            Dim LogFormularios As New E_LogFormularios(Idusuario, cn)

            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(LogFormularios.LOF_Id, "Id")
            CONSULTA.SelCampo(LogFormularios.LOF_NombreFormulario, "NombreFormulario")
            CONSULTA.SelCampo(LogFormularios.LOF_Permisos, "Permisos")
            CONSULTA.WheCampo(LogFormularios.LOF_IdPerfil, "=", IdPerfil.ToString)

            Dim sql As String = CONSULTA.SQL & " ORDER BY LOF_Id DESC"  'Y si hay más de uno? No deberia
            dt = LogFormularios.MiConexion.ConsultaSQL(sql)

        Catch ex As Exception
            dt = New DataTable
            TextoError = ex.Message
        End Try



        Return dt

    End Function





    Public Function GuardaCopiaContadores() As Boolean

        Dim bRes As Boolean = True


        Dim err As New Errores



        Try
            Dim ContadoresUsuario As New E_ContadoresUsuario(Idusuario, cn)

            'Borra los existentes del usuario
            Dim sql As String = "DELETE FROM ContadoresUsuario WHERE COU_IdUsuarioCopia = " & Idusuario
            ContadoresUsuario.MiConexion.ConsultaSQL(sql)


            'Inserta una copia de los contadores existentes 
            sql = "SELECT CON_NombreTabla, CON_TipoContador, CON_UltimoNumero, CON_IdUsuario FROM Contadores"
            Dim dt As DataTable = ContadoresUsuario.MiConexion.ConsultaSQL(sql)

            For Each row As DataRow In dt.Rows
                ContadoresUsuario = New E_ContadoresUsuario(Idusuario, cn)
                ContadoresUsuario.COU_Id.Valor = ContadoresUsuario.MaxId()
                ContadoresUsuario.COU_IdUsuarioCopia.Valor = Idusuario
                ContadoresUsuario.COU_FechaCopia.Valor = Today
                ContadoresUsuario.COU_HoraCopia.Valor = Now.ToString("HH:mm:ss")
                ContadoresUsuario.COU_Tabla.Valor = row("CON_NombreTabla").ToString
                ContadoresUsuario.COU_TipoContador.Valor = row("CON_TipoContador").ToString
                ContadoresUsuario.COU_UltimoNumero.Valor = row("CON_UltimoNumero").ToString
                ContadoresUsuario.COU_IdUsuario.Valor = row("CON_IdUsuario").ToString
                ContadoresUsuario.Insertar()
            Next



        Catch ex As Exception
            err.Muestraerror("No se puedieron guardar los contadores del usuario " & Idusuario, "GuardaCopiaContadores", ex.Message)
        End Try


        Return bRes

    End Function


    Public Sub CargaCodigosInstalacion()

        DcCodigosInstalacion.Clear()


        DcCodigosInstalacion("HOR") = "HORTICHUELAS"
        DcCodigosInstalacion("BSB") = "BIOSABOR"
        DcCodigosInstalacion("BSO") = "BIOSOL PORTOCARRERO"
        DcCodigosInstalacion("ESC") = "FRUTAS ESCOBI"
        DcCodigosInstalacion("NCC") = "NATURCHARC"




        'Comprueba que no haya dos instalaciones con el mismo código
        Dim DcCodigos As New Dictionary(Of String, String)
        For Each instalacion As String In DcCodigosInstalacion.Keys

            Dim codigo As String = DcCodigosInstalacion(instalacion)

            If Not DcCodigos.ContainsKey(codigo) Then
                DcCodigos(codigo) = instalacion
            Else
                Dim err As New Errores
                err.Muestraerror("Código de instalación repetido: " & codigo, "CargaCodigosInstalacion", "El código asignado a la instalación " & instalacion & " ya está asignado")
                Exit Sub
            End If

        Next


    End Sub


    Public Sub CargaCodigosEntidad()

        DcCodigosEntidad.Clear()


        'A mano más visible, siempre en mayúsculas y sin espacios


        '----------------------------------------------------------------------------------------------------------------------------------------------
        'ORDENADO POR ORDEN ALFABÉTICO DEL CÓDIGO (ABE, ACG, ETC...), NO DE LA ENTIDAD, Y SEPARADO POR LETRA INICIAL (A, B, C...)
        '----------------------------------------------------------------------------------------------------------------------------------------------

        'A
        DcCodigosEntidad("ALBSALIDAALH_GASTOS") = "AAG"
        DcCodigosEntidad("ALBSALIDAALH") = "AAH"
        DcCodigosEntidad("ALBSALIDAALH_LINEAS") = "AAL"
        DcCodigosEntidad("ABONOENVASESALH") = "ABE"
        DcCodigosEntidad("ACREEDORES_GASTOS") = "ACG"
        DcCodigosEntidad("ACREEDORES") = "ACR"
        DcCodigosEntidad("ALBENTRADA_GASTOS") = "AEG"
        DcCodigosEntidad("ALBENTRADA_HIS") = "AEH"
        DcCodigosEntidad("ALBENTRADA_LINEAS") = "AEL"
        DcCodigosEntidad("ALBENTRADA_MEDIANERIA") = "AEM"
        DcCodigosEntidad("ALBENTRADA") = "AEN"
        DcCodigosEntidad("ALMACENENVASES") = "AEV"
        DcCodigosEntidad("AGRICULTORGASTOS") = "AGG"
        DcCodigosEntidad("AGRICULTORESMEDIANERIA") = "AGM"
        DcCodigosEntidad("AGRICULTORES") = "AGR"
        DcCodigosEntidad("ALBENTRADA_HISGASTOS") = "AHG"
        DcCodigosEntidad("ALBENTRADA_HISLINEAS") = "AHL"
        DcCodigosEntidad("AGRICULTORES_IBAN") = "AIB"
        DcCodigosEntidad("ALBENTRADA_LINEASKILOS") = "ALK"
        DcCodigosEntidad("ALBENTRADA_LINEASCLA") = "ALC"
        DcCodigosEntidad("ALERTAS") = "ALE"
        DcCodigosEntidad("ALBSALIDA_LINEASGASTOS") = "ALG"
        DcCodigosEntidad("ALERTATABLAS") = "ALT"
        DcCodigosEntidad("ALBMATERIAL") = "AMA"
        DcCodigosEntidad("ALBMATERIALLINEAS") = "AML"
        DcCodigosEntidad("APORTACIONESEXTRAORDINARIAS") = "APX"
        DcCodigosEntidad("ALBSALIDA") = "ASA"
        DcCodigosEntidad("ALBSALIDA_LINEAS_DESGLOSE") = "ASD"
        DcCodigosEntidad("ALBSALIDA_GASTOS") = "ASG"
        DcCodigosEntidad("ALBSALIDA_LINEAS") = "ASL"
        DcCodigosEntidad("ALBSALIDA_PALETS") = "ASP"
        DcCodigosEntidad("ALBSALIDA_LINEASVENTAS") = "ASV"

        'B
        DcCodigosEntidad("BLOQUEOLINEAFECHA") = "BLF"
        DcCodigosEntidad("BLOQUEOCULTIVOS") = "BCU"

        'C
        DcCodigosEntidad("CONCEPTOS346") = "C46"
        DcCodigosEntidad("CATEGORIASCOMERCIAL") = "CAC"
        DcCodigosEntidad("CATEGORIASENTRADA") = "CAE"
        DcCodigosEntidad("CARGAS") = "CAR"
        DcCodigosEntidad("CATEGORIASSALIDA") = "CAS"
        DcCodigosEntidad("COBROSLINEAS") = "CBL"
        DcCodigosEntidad("CONFIGURACIONESDIVERSAS") = "CDV"
        DcCodigosEntidad("CONFECENVASELINEAS") = "CEL"
        DcCodigosEntidad("CENTROSRECOGIDA") = "CER"
        DcCodigosEntidad("CONFECENVASE") = "CEV"
        DcCodigosEntidad("CULTIVOSGENERO") = "CGE"
        DcCodigosEntidad("CARGAS_INSPECCION") = "CGI"
        DcCodigosEntidad("CARGAS_PALETS") = "CGL"
        DcCodigosEntidad("CARGAS_PEDIDO") = "CGP"
        DcCodigosEntidad("CARGADORES") = "CGR"
        DcCodigosEntidad("CONCEPTOSINSPECCION") = "CIS"
        DcCodigosEntidad("CLIENTESDESCARGAS") = "CLD"
        DcCodigosEntidad("CLIENTES") = "CLI"
        DcCodigosEntidad("CMR_LINEAS") = "CML"
        DcCodigosEntidad("COSTEMANIPULADO") = "CMP"
        DcCodigosEntidad("CMR") = "CMR"
        DcCodigosEntidad("CONSULTASALIDAS") = "CNS"
        DcCodigosEntidad("COBROS") = "COB"
        DcCodigosEntidad("CONCEPTOSCOBROS") = "COC"
        DcCodigosEntidad("CONCEPTOSENVASES") = "COE"
        DcCodigosEntidad("CONCEPTOSFACTURA") = "COF"
        DcCodigosEntidad("COMPRAS") = "COM"
        DcCodigosEntidad("CONTADORES") = "CON"
        DcCodigosEntidad("CONTACTOS") = "COT"
        DcCodigosEntidad("CONTADORESUSUARIO") = "COU"
        DcCodigosEntidad("CONFECPALET") = "CPA"
        DcCodigosEntidad("CONFECPALETLINEAS") = "CPL"
        DcCodigosEntidad("CLIENTESPROGRAMA") = "CPR"
        DcCodigosEntidad("CENTROSPVENTA") = "CRP"
        DcCodigosEntidad("CORREDORES") = "CRR"
        DcCodigosEntidad("CATSALIDACOMERCIAL") = "CSC"
        DcCodigosEntidad("CONCEPTOSTRANSPORTE") = "CTR"
        DcCodigosEntidad("COBROSVENCIMIENTOS") = "CVT"
        DcCodigosEntidad("CULTIVOS") = "CUL"

        'D
        DcCodigosEntidad("DAT_ENTRADAS") = "DAT"
        DcCodigosEntidad("DOCUMENTOSBANCOS") = "DDB"
        DcCodigosEntidad("DEVENVASES_LINEAS") = "DEL"
        DcCodigosEntidad("DEVENVASES") = "DEV"
        DcCodigosEntidad("DOMICILIOSFIANZAS") = "DFZ"
        DcCodigosEntidad("DESCRIPCIONGENEROPORIDIOMA") = "DGI"
        DcCodigosEntidad("DOMICILIOS") = "DOM"
        DcCodigosEntidad("DAT_OPERADORES") = "DOP"
        DcCodigosEntidad("DEPARTAMENTOSCONTACTOS") = "DPT"

        'E
        DcCodigosEntidad("ENVASESINICIALTIPO") = "EIT"
        DcCodigosEntidad("EMPRESAS") = "EMP"
        DcCodigosEntidad("ENVASESINICIAL") = "ENI"
        DcCodigosEntidad("ENVASESPALETS") = "ENP"
        DcCodigosEntidad("ENVASES") = "ENV"
        DcCodigosEntidad("EXISTENCIASTERCEROSLINEAS") = "EXL"
        DcCodigosEntidad("EXISTENCIASTERCEROS") = "EXT"

        'F
        DcCodigosEntidad("FICHERO346") = "F46"
        DcCodigosEntidad("FAMILIASCATEGORIAS") = "FAC"
        DcCodigosEntidad("FAMILIASDESCUENTOS") = "FAD"
        DcCodigosEntidad("FAMILIASGENEROS") = "FAG"
        DcCodigosEntidad("FACTURAAGR_LINEAS") = "FAL"
        DcCodigosEntidad("FORMATOSEDI") = "FED"
        DcCodigosEntidad("FAMILIAENVASES") = "FEV"
        DcCodigosEntidad("FACTURAAGR") = "FGR"
        DcCodigosEntidad("FINCAS") = "FIN"
        DcCodigosEntidad("FACTURASLINEASVAR") = "FLV"
        DcCodigosEntidad("FACTURAS") = "FRA"
        DcCodigosEntidad("FACTURASRECIBIDASIMPORTACIONES") = "FRI"
        DcCodigosEntidad("FACTURASRECIBIDAS") = "FRR"
        DcCodigosEntidad("FIANZASENVASES") = "FZE"

        'G
        DcCodigosEntidad("GENEROSCATEGORIAS") = "GCA"
        DcCodigosEntidad("GASTOSCLIENTES") = "GCL"
        DcCodigosEntidad("GASTOSCOMERCIO") = "GCO"
        DcCodigosEntidad("GENEROSCOMPUESTOS") = "GEC"
        DcCodigosEntidad("GENEROS") = "GEN"
        DcCodigosEntidad("GENEROSTECNICOS") = "GEN"
        DcCodigosEntidad("GENEROPESOS") = "GEP"
        DcCodigosEntidad("GENEROSSALIDA") = "GES"
        DcCodigosEntidad("GRUPOSMENSAJES") = "GRM"

        'L
        DcCodigosEntidad("LINEAS") = "LIN"
        DcCodigosEntidad("LIQUIDACIONAGR") = "LIQ"
        DcCodigosEntidad("LINEAS_PRODUCTO") = "LNP"
        DcCodigosEntidad("LOGFORMULARIOS") = "LOF"
        DcCodigosEntidad("LOGMENU") = "LOM"
        DcCodigosEntidad("LOGTABLAS") = "LOT"
        DcCodigosEntidad("LOTESPRODUCCION") = "LPD"
        DcCodigosEntidad("LOTESPRODUCCION_LINEAS") = "LPL"
        DcCodigosEntidad("LOTES") = "LTE"
        DcCodigosEntidad("LOTES_LINEAS") = "LTL"

        'M
        DcCodigosEntidad("MARCAS") = "MAR"
        DcCodigosEntidad("MEDIANERIA") = "MED"
        DcCodigosEntidad("MEDIANERIA_LINEAS") = "MEL"
        DcCodigosEntidad("MONEDA") = "MON"
        DcCodigosEntidad("MOZOS") = "MOZ"
        DcCodigosEntidad("MOTIVOSQUEJA") = "MTQ"

        'N
        DcCodigosEntidad("NAVES") = "NAV"
        DcCodigosEntidad("NORMASCALIDAD") = "NOR"
        DcCodigosEntidad("NOTICIASWEB") = "NWB"

        'O
        DcCodigosEntidad("OBSERVACIONES") = "OBS"
        DcCodigosEntidad("OPERARIOS") = "OPE"
        DcCodigosEntidad("ORIGENGASTOS") = "ORG"

        'P
        DcCodigosEntidad("PEDIDOS_ALMACEN") = "PAC"
        DcCodigosEntidad("PALETS") = "PAL"
        DcCodigosEntidad("PERMISOSBOTONES") = "PBT"
        DcCodigosEntidad("PEDIDOS_CLIENTES") = "PCC"
        DcCodigosEntidad("PROGRAMASCALIDAD") = "PCL"
        DcCodigosEntidad("PROGRAMACALIDADTECNICOS") = "PCT"
        DcCodigosEntidad("PRECIOSDECORTE") = "PDC"
        DcCodigosEntidad("PARTES_COMPRAS") = "PDL"
        DcCodigosEntidad("PARTES") = "PDS"
        DcCodigosEntidad("PEDIDOS") = "PED"
        DcCodigosEntidad("PEDIDOS_LINEAS") = "PEL"
        DcCodigosEntidad("PRECIOSREF_LINEAS") = "PFL"
        DcCodigosEntidad("PARTES_FAMILIAS") = "PFM"
        DcCodigosEntidad("PALETS_LINEAS") = "PLL"
        DcCodigosEntidad("MEDIDASPALET") = "PLM"
        DcCodigosEntidad("PALETS_TRAZA") = "PLT"
        DcCodigosEntidad("PEDIDOSMATERIAL") = "PMA"
        DcCodigosEntidad("MENSAJESENTIDADES") = "PMJ"
        DcCodigosEntidad("PEDIDOSMATERIALLINEAS") = "PML"
        DcCodigosEntidad("PAGOSMOZOS") = "PMZ"
        DcCodigosEntidad("PRODUCCION") = "PRD"
        DcCodigosEntidad("PRECIOSREF") = "PRF"
        DcCodigosEntidad("PREVISIONES_LINEAS") = "PRL"
        DcCodigosEntidad("PROGRAMASMUESTRAS") = "PRM"
        'DcCodigosEntidad("PROGRAMACALIDAD") = "PRO"
        DcCodigosEntidad("PARTEEXISTENCIAS_LINEAS") = "PSL"
        DcCodigosEntidad("PARTEEXISTENCIAS") = "PSM"
        DcCodigosEntidad("PARTES_VENTAS") = "PVL"
        DcCodigosEntidad("PREVISIONES") = "PVR"
        DcCodigosEntidad("PVENTAUSUARIO") = "PVU"
        DcCodigosEntidad("PAGOSMOZOS_LINEAS") = "PZL"

        'R
        DcCodigosEntidad("RECLAMA") = "RCL"
        DcCodigosEntidad("RECLAMA_ORIGEN") = "RCO"
        DcCodigosEntidad("RECLAMA_RESOLUCION") = "RCS"
        DcCodigosEntidad("RECUENTO") = "REC"
        DcCodigosEntidad("RECINTOSSIGPAC") = "REC"
        DcCodigosEntidad("REMESASFACTORING") = "REF"
        DcCodigosEntidad("RECUENTO_LINEAS") = "REL"
        DcCodigosEntidad("RECETASTEC") = "RET"                                  'Técnicos
        DcCodigosEntidad("REMESASFACTORING_LINEAS") = "RFL"
        DcCodigosEntidad("RECOGIDAMUESTRAS") = "RMU"

        'S
        DcCodigosEntidad("SEMANASPARTES") = "SEV"
        DcCodigosEntidad("SUBFAMILIAS") = "SFA"
        DcCodigosEntidad("SUBFAMILIAENVASES") = "SFE"
        DcCodigosEntidad("SEMANAS_GASTOCONF") = "SGK"
        DcCodigosEntidad("CONSULTASSQL") = "SQL"

        'T
        DcCodigosEntidad("TARIFASCLIENTES") = "TAC"
        DcCodigosEntidad("TARIFASAGRICULTORES") = "TAG"
        DcCodigosEntidad("TARIFASAGRICULTORESLINEAS") = "TAL"
        DcCodigosEntidad("TIPOSDECATEGORIAS") = "TCA"
        DcCodigosEntidad("TIPOSDECALIBRE") = "TCB"
        DcCodigosEntidad("TARIFASCLIENTESCENTRO") = "TCC"
        DcCodigosEntidad("TRASPASOSCENTROS") = "TCE"
        DcCodigosEntidad("TARIFASCLIENTESLINEAS") = "TCL"
        DcCodigosEntidad("TECNICOS") = "TEC"
        DcCodigosEntidad("TIPOSDEGASTOSAGRI") = "TGA"
        DcCodigosEntidad("TIPOSIVA") = "TIV"
        DcCodigosEntidad("TRASPASOSCENTROS_LINEAS") = "TLI"
        DcCodigosEntidad("TARIFASMATERIAL") = "TMA"
        DcCodigosEntidad("TARIFASMATERIALLINEAS") = "TML"
        DcCodigosEntidad("TIPOMATERIAL") = "TMT"
        DcCodigosEntidad("TIPOAGRICULTOR") = "TPA"
        DcCodigosEntidad("TIPOSCLIENTES") = "TPC"
        DcCodigosEntidad("TIPOSPORTE") = "TPO"
        DcCodigosEntidad("TARIFAPORTES") = "TPV"
        DcCodigosEntidad("TRAZACONF") = "TRC"
        DcCodigosEntidad("TRAZAPALETS") = "TRP"
        DcCodigosEntidad("TRANSPORTISTAS") = "TTA"

        'U
        DcCodigosEntidad("UMEDIDA") = "UME"
        DcCodigosEntidad("USUARIOS_PROCESOS") = "UPR"
        DcCodigosEntidad("USUARIOS_LOGS") = "USL"
        DcCodigosEntidad("USUARIOSWEB") = "UWB"

        'V
        DcCodigosEntidad("VALORAIMPORTACIONES") = "VAI"
        DcCodigosEntidad("VARIEDADES") = "VAR"
        DcCodigosEntidad("VENDEDORES") = "VED"
        DcCodigosEntidad("VALORESEJERCICIO") = "VEJ"
        DcCodigosEntidad("VALEENVASES_LINEAS") = "VEL"
        DcCodigosEntidad("VENTAS") = "VEN"
        DcCodigosEntidad("VERSIONES") = "VER"
        DcCodigosEntidad("VALEENVASES") = "VEV"
        DcCodigosEntidad("VALEENVASES_TRASPASO") = "VET"
        DcCodigosEntidad("VENTASGASTOS") = "VNG"
        DcCodigosEntidad("VENTASLINEAS") = "VNL"
        DcCodigosEntidad("VALORESPVENTA") = "VPV"
        DcCodigosEntidad("VALORACIONSEMANAL") = "VSC"
        DcCodigosEntidad("VALORACIONSEMANAL_LINEAS") = "VSL"
        DcCodigosEntidad("VALEENVASES_TRASPASO_LINEAS") = "VTL"
        DcCodigosEntidad("VALORESUSUARIO") = "VUS"

        'Z
        DcCodigosEntidad("ZONAS") = "ZON"




        ''Comprueba que no haya dos tablas con el mismo código
        'Dim DcCodigos As New Dictionary(Of String, String)
        'For Each tabla As String In DcCodigosEntidad.Keys

        '    Dim codigo As String = DcCodigosEntidad(tabla)

        '    If Not DcCodigos.ContainsKey(codigo) Then
        '        DcCodigos(codigo) = tabla
        '    Else
        '        Dim err As New Errores
        '        err.Muestraerror("Código de entidad repetido: " & codigo, "CargaCodigosEntidad", "El código asignado a la entidad " & tabla & " ya está asignado")
        '        Exit Sub
        '    End If

        'Next


        'Comprueba que no haya dos tablas con el mismo código
        Dim DcCodigos As New Dictionary(Of String, String)
        For Each tabla As String In DcCodigosEntidad.Keys

            Dim codigo As String = DcCodigosEntidad(tabla)

            If Not DcCodigos.ContainsKey(codigo) Then
                DcCodigos(codigo) = tabla
            Else
                If tabla.Trim.ToUpper <> "GENEROSTECNICOS" And
                    tabla.Trim.ToUpper <> "RECINTOSSIGPAC" Then
                    Dim err As New Errores
                    err.Muestraerror("Código de entidad repetido: " & codigo, "CargaCodigosEntidad", "El código asignado a la entidad " & tabla & " ya está asignado")
                    Exit Sub
                End If
            End If

        Next


    End Sub


    Public Function ComboCentrosRecogida(ByVal cb As CheckedComboBoxEdit) As CheckedComboBoxEdit

        Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)

        Dim sql As String = "SELECT CER_IdRecogida as Id, CER_Nombre as Nombre FROM CentrosRecogida"
        Dim dt As DataTable = CentrosRecogida.MiConexion.ConsultaSQL(sql)

        cb.Properties.DataSource = dt
        cb.Properties.ValueMember = "Id"
        cb.Properties.DisplayMember = "Nombre"


        Return cb

    End Function


    Public Function ComboPuntoventa(ByVal cb As CheckedComboBoxEdit, ByVal idpv As Integer) As CheckedComboBoxEdit
        Dim pventausuario As New E_PventaUsuario(Idusuario, cn)
        Dim dt As New DataTable


        dt = pventausuario.Tabla(Idusuario, MiMaletin.IdEmpresaCTB)

        cb.Properties.DataSource = dt
        cb.Properties.ValueMember = "IdPuntoventa"
        cb.Properties.DisplayMember = "Nombre"

        cb.CheckAll()

        'For Each it As CheckedListBoxItem In cb.Properties.GetItems()
        '    If it.Value = idpv Then
        '        it.CheckState = CheckState.Checked
        '    Else
        '        it.CheckState = CheckState.Unchecked
        '    End If
        'Next


        Return cb
    End Function


    Public Function ComboTiposDePorte(ByVal cb As CheckedComboBoxEdit) As CheckedComboBoxEdit
        Dim TiposPorte As New E_TiposPorte(Idusuario, cn)
        Dim dt As New DataTable


        Dim sql As String = "SELECT TPO_Id as Id, TPO_Nombre as Nombre FROM TiposPorte order by TPO_id"
        dt = TiposPorte.MiConexion.ConsultaSQL(sql)

        cb.Properties.DataSource = dt
        cb.Properties.ValueMember = "Id"
        cb.Properties.DisplayMember = "Nombre"


        For Each it As CheckedListBoxItem In cb.Properties.GetItems()
            it.CheckState = CheckState.Checked
        Next

        Return cb
    End Function


    Public Function ComboEmpresas(ByVal cb As CheckedComboBoxEdit, idempresa As Integer) As CheckedComboBoxEdit

        Dim Empresas As New E_Empresas(Idusuario, cn)

        Dim sql As String = "SELECT EMP_IdEmpresa as IdEmpresa, EMP_Nombre as Nombre FROM Empresas"
        Dim dt As DataTable = Empresas.MiConexion.ConsultaSQL(sql)

        cb.Properties.DataSource = dt
        cb.Properties.ValueMember = "IdEmpresa"
        cb.Properties.DisplayMember = "Nombre"


        For Each it As CheckedListBoxItem In cb.Properties.GetItems()
            If it.Value = idempresa Then
                it.CheckState = CheckState.Checked
            Else
                it.CheckState = CheckState.Unchecked
            End If
        Next


        Return cb

    End Function

    Public Function ComboCentro(ByVal cb As CheckedComboBoxEdit, ByVal idcentro As Integer) As CheckedComboBoxEdit


        Dim pventausuario As New E_PventaUsuario(Idusuario, cn)
        Dim dt As New DataTable


        dt = pventausuario.CentrosPermitidos(Idusuario, MiMaletin.IdEmpresaCTB)

        cb.Properties.DataSource = dt
        cb.Properties.ValueMember = "IdCentro"
        cb.Properties.DisplayMember = "Nombre"


        For Each it As CheckedListBoxItem In cb.Properties.GetItems()
            If it.Value = idcentro Then
                it.CheckState = CheckState.Checked
            Else
                it.CheckState = CheckState.Unchecked
            End If
        Next


        Return cb
    End Function



    Public Function ComboCentroTodos(ByVal cb As CheckedComboBoxEdit, ByVal idcentro As Integer) As CheckedComboBoxEdit
        Dim Centros As New E_centros(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        Dim dt As New DataTable
        Dim sql As String

        sql = "Select Idcentro,Nombre from centros order by idcentro"
        dt = ConexCtb(MiMaletin.IdEmpresaCTB).ConsultaSQL(sql)

        cb.Properties.DataSource = dt
        cb.Properties.ValueMember = "Idcentro"
        cb.Properties.DisplayMember = "Nombre"


        For Each it As CheckedListBoxItem In cb.Properties.GetItems()
            If it.Value = idcentro Then
                it.CheckState = CheckState.Checked
            Else
                it.CheckState = CheckState.Unchecked
            End If
        Next


        Return cb
    End Function


    Public Function ComboAlmacenEnvases(ByVal cb As CheckedComboBoxEdit, ByVal IdAlmacen As Integer) As CheckedComboBoxEdit
        Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
        Dim dt As New DataTable


        dt = AlmacenEnvases.MiConexion.ConsultaSQL("Select AEV_Idalmacen as IdAlmacen, AEV_Nombre as Nombre from almacenenvases order by AEV_idalmacen")

        cb.Properties.DataSource = dt
        cb.Properties.ValueMember = "IdAlmacen"
        cb.Properties.DisplayMember = "Nombre"


        For Each it As CheckedListBoxItem In cb.Properties.GetItems()
            If it.Value = IdAlmacen Then
                it.CheckState = CheckState.Checked
            Else
                it.CheckState = CheckState.Unchecked
            End If
        Next


        Return cb
    End Function

    Public Function ComboFamilias(ByVal cb As CheckedComboBoxEdit) As CheckedComboBoxEdit

        Dim dt As New DataTable
        Dim Sql As String = ""

        Sql = "Select FAG_IdFamilia as Familia, FAG_Nombre as Nombre from FamiliasGeneros order by Familia"
        dt = cn.ConsultaSQL(Sql)

        cb.Properties.DataSource = dt
        cb.Properties.ValueMember = "Familia"
        cb.Properties.DisplayMember = "Nombre"


        Return cb
    End Function

    Public Function ComboFamiliasEnvases(ByVal cb As CheckedComboBoxEdit) As CheckedComboBoxEdit

        Dim dt As New DataTable
        Dim Sql As String = ""


        Sql = "Select FEV_idfamilia as Id, FEV_nombre as Familia from FamiliaEnvases order by FEV_idfamilia"
        dt = cn.ConsultaSQL(Sql)



        dt = cn.ConsultaSQL(Sql)

        cb.Properties.DataSource = dt
        cb.Properties.ValueMember = "Id"
        cb.Properties.DisplayMember = "Familia"


        Return cb
    End Function


    Public Function ListadeCombo(ByVal Combo As CheckedComboBoxEdit) As List(Of String)
        Dim resultado As New List(Of String)
        Dim i As Integer = 0
        Dim s As Integer = 0
        Dim n As Integer = 0
        If Combo IsNot Nothing Then

            For Each it As CheckedListBoxItem In Combo.Properties.GetItems()
                If it.CheckState = CheckState.Checked Then
                    resultado.Add(it.Value)
                    s = s + 1
                Else
                    n = n + 1
                End If
                i = i + 1
            Next

        End If

        If n = i Then
            resultado.Clear() ' todas checked
        End If

        '        If bTodosIgualVacio Then
        ' If s = i Then
        ' resultado.Clear() ' todas checked
        ' End If
        ' End If


        Return resultado

    End Function


    Public Function ListaDeListBox(ByVal chlb As CheckedListBoxControl, Optional bTodosIgualVacio As Boolean = True) As List(Of String)


        Dim resultado As New List(Of String)
        Dim i As Integer = 0
        Dim s As Integer = 0
        Dim n As Integer = 0

        If chlb IsNot Nothing Then

            For indice As Integer = 0 To chlb.ItemCount - 1
                If chlb.GetItemChecked(indice) Then
                    Dim valor As Integer = VaInt(chlb.GetItemValue(indice))
                    resultado.Add(valor)
                    s = s + 1
                Else
                    n = n + 1
                End If
                i = i + 1
            Next

        End If

        If n = i Then
            resultado.Clear() ' todas checked
        End If

        If bTodosIgualVacio Then
            If s = i Then
                resultado.Clear() ' todas checked
            End If
        End If



        Return resultado

    End Function



    Public Function DiccionariodeCombo(ByVal Combo As CheckedComboBoxEdit, Optional bTodosIgualVacio As Boolean = True) As Dictionary(Of Integer, String)

        Dim resultado As New Dictionary(Of Integer, String)

        If Combo IsNot Nothing Then

            For Each it As CheckedListBoxItem In Combo.Properties.GetItems()
                If it.CheckState = CheckState.Checked Then
                    resultado(VaInt(it.Value)) = it.Description
                End If
            Next

        End If


        Return resultado

    End Function


    Public Function DiccionarioDeListBox(ByVal chlb As CheckedListBoxControl) As Dictionary(Of Integer, String)

        Dim resultado As New Dictionary(Of Integer, String)

        Dim i As Integer = 0
        Dim s As Integer = 0
        Dim n As Integer = 0

        If chlb IsNot Nothing Then

            For indice As Integer = 0 To chlb.ItemCount - 1
                If chlb.GetItemChecked(indice) Then
                    Dim valor As Integer = VaInt(chlb.GetItemValue(indice))
                    Dim descripcion As String = chlb.GetItemText(indice)
                    resultado(valor) = descripcion
                End If
            Next


        End If



        Return resultado

    End Function


    Public Function CadenaWhereLista(ByVal campoClave As Cdatos.bdcampo, ByVal LST As List(Of String), Optional ByVal Prefijo As String = "", Optional Vaciaestodos As Boolean = False) As String

        Dim resultado As String = ""
        Dim ntabla As String = ""


        If Not LST Is Nothing Then
            For i As Integer = 0 To LST.Count - 1
                If LST(i) <> "" Then
                    If i = 0 Then
                        Select Case campoClave.TipoBd
                            Case Cdatos.TiposCampo.Entero, Cdatos.TiposCampo.EnteroPositivo, Cdatos.TiposCampo.Importe
                                resultado = ntabla & campoClave.NombreCampo & "=" & LST(i).Trim
                            Case Else
                                resultado = ntabla & campoClave.NombreCampo & "='" & LST(i).Trim & "'"
                        End Select
                    Else
                        Select Case campoClave.TipoBd
                            Case Cdatos.TiposCampo.Entero, Cdatos.TiposCampo.EnteroPositivo, Cdatos.TiposCampo.Importe
                                resultado = resultado & " OR " & ntabla & campoClave.NombreCampo & "=" & LST(i).Trim
                            Case Else
                                resultado = resultado & " OR " & ntabla & campoClave.NombreCampo & "='" & LST(i).Trim & "'"
                        End Select
                    End If
                End If
            Next
        End If

        If resultado <> "" Then
            resultado = Prefijo + " ( " + resultado + " )"
        Else
            If Vaciaestodos = False Then ' 
                resultado = Prefijo + " ( 1 = 0 ) " ' no hay nada en la lista
            End If
        End If

        Return resultado

    End Function


    Public Function CadenaWhereLista_CAMPO(ByVal NombreCampo As String, Tipo As Cdatos.TiposCampo, ByVal LST As List(Of String), Optional ByVal Prefijo As String = "") As String

        Dim resultado As String = ""
        Dim ntabla As String = ""


        If Not LST Is Nothing Then
            For i As Integer = 0 To LST.Count - 1
                If LST(i) <> "" Then
                    If i = 0 Then
                        Select Case Tipo
                            Case Cdatos.TiposCampo.Entero, Cdatos.TiposCampo.EnteroPositivo, Cdatos.TiposCampo.Importe
                                resultado = ntabla & NombreCampo & "=" & LST(i).Trim
                            Case Else
                                resultado = ntabla & NombreCampo & "='" & LST(i).Trim & "'"
                        End Select
                    Else
                        Select Case Tipo
                            Case Cdatos.TiposCampo.Entero, Cdatos.TiposCampo.EnteroPositivo, Cdatos.TiposCampo.Importe
                                resultado = resultado & " OR " & ntabla & NombreCampo & "=" & LST(i).Trim
                            Case Else
                                resultado = resultado & " OR " & ntabla & NombreCampo & "='" & LST(i).Trim & "'"
                        End Select
                    End If
                End If
            Next
        End If

        If resultado <> "" Then
            resultado = Prefijo + " ( " + resultado + " )"
        End If

        Return resultado

    End Function


    Public Function StSaldo(s As Decimal) As String
        If s >= 0 Then
            Return Format(s, "#,###") + " D"
        Else
            Return Format(-s, "#,###") + " H"
        End If
    End Function

    Public Function StSaldoDec(s As Decimal) As String
        If s >= 0 Then
            Return Format(s, "#,##0.00") + " D"
        Else
            Return Format(-s, "#,##0.00") + " H"
        End If
    End Function


    Public Function CompruebaBloqueoCuenta(cta As String) As Boolean

        Dim bRes As Boolean = True
        Dim texto As String = ""


        'Comprueba si está bloqueada la cuenta
        Dim BloqueoCuentas As New E_BloqueoCuentas(Idusuario, cn)
        If BloqueoCuentas.LeerId(cta) Then

            'Si el campo Aviso tiene contenido es un aviso, si no, es un bloqueo
            'If (BloqueoCuentas.Aviso.Valor & "").Trim = "" Then
            If (BloqueoCuentas.BloqueoSN.Valor & "").Trim.ToUpper = "S" Then
                texto = "CUENTA BLOQUEADA: NO SE PERMITEN REALIZAR PAGOS" & vbCrLf & vbCrLf
                bRes = False
                'Else
            End If

            If (BloqueoCuentas.Aviso.Valor & "").Trim <> "" Then
                texto = texto & BloqueoCuentas.Aviso.Valor.Trim
            End If

        End If

        If texto.Trim <> "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show(texto, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If


        Return bRes

    End Function


    Public Sub EtiquetasCestaCaja(ByVal IdLineaPedido As String, ByRef EtiquetaCesta As String, ByRef EtiquetaCaja As String,
                                  ByRef MarcaEtiqueta As String, ByRef MarcaMaterial As String)


        EtiquetaCesta = ""
        EtiquetaCaja = ""
        MarcaEtiqueta = ""
        MarcaMaterial = ""


        If VaInt(IdLineaPedido) > 0 Then

            Dim ConfecEnvaseLineas As New E_ConfecEnvaseLineas(Idusuario, cn)
            Dim Envases As New E_Envases(Idusuario, cn)
            Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)
            Dim Marcas As New E_Marcas(Idusuario, cn)


            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(Pedidos_Lineas.PEL_idlinea, "IdLinea")
            CONSULTA.SelCampo(ConfecEnvaseLineas.CEL_Idmaterial, "Id", Pedidos_Lineas.PEL_idtipoconfeccion, ConfecEnvaseLineas.CEL_Idconfec)
            CONSULTA.SelCampo(Envases.ENV_Nombre, "Nombre", ConfecEnvaseLineas.CEL_Idmaterial, Envases.ENV_IdEnvase)
            CONSULTA.SelCampo(ConfecEnvaseLineas.CEL_TipoEtiqueta, "TipoEtiqueta")
            Dim oMarcaEtiqueta As New Cdatos.bdcampo("@(SELECT MAR_Nombre FROM Marcas WHERE MAR_IdMarca = PEL_IdMarcaEtiqueta)", Marcas.MAR_Nombre.TipoBd, Marcas.MAR_Nombre.Longitud)
            CONSULTA.SelCampo(oMarcaEtiqueta, "MarcaEtiqueta")
            Dim oMarcaMaterial As New Cdatos.bdcampo("@(SELECT MAR_Nombre FROM Marcas WHERE MAR_IdMarca = PEL_IdMarcaMaterial)", Marcas.MAR_Nombre.TipoBd, Marcas.MAR_Nombre.Longitud)
            CONSULTA.SelCampo(oMarcaMaterial, "MarcaMaterial")
            CONSULTA.WheCampo(Pedidos_Lineas.PEL_idlinea, "=", IdLineaPedido)


            Dim sql As String = CONSULTA.SQL
            Dim dt As DataTable = ConfecEnvaseLineas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                For Each row As DataRow In dt.Rows
                    Dim TipoEtiqueta As String = (row("TipoEtiqueta").ToString & "").ToUpper.Trim

                    If TipoEtiqueta = "C" Then
                        EtiquetaCesta = VaInt(row("Id")).ToString & " - " & row("Nombre").ToString
                        MarcaEtiqueta = row("MarcaEtiqueta").ToString
                    ElseIf TipoEtiqueta = "J" Then
                        EtiquetaCaja = VaInt(row("Id")).ToString & " - " & row("Nombre").ToString
                        MarcaMaterial = row("MarcaMaterial").ToString
                    End If

                Next

            End If


        End If


    End Sub


    Public Sub EtiquetasCestaCajaPalet(ByVal IdLineaPalet As String, ByRef EtiquetaCesta As String, ByRef EtiquetaCaja As String,
                                  ByRef MarcaEtiqueta As String, ByRef MarcaMaterial As String)


        EtiquetaCesta = ""
        EtiquetaCaja = ""
        MarcaEtiqueta = ""
        MarcaMaterial = ""


        If VaInt(IdLineaPalet) > 0 Then

            Dim ConfecEnvaseLineas As New E_ConfecEnvaseLineas(Idusuario, cn)
            Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)

            Dim Envases As New E_Envases(Idusuario, cn)
            Dim Marcas As New E_Marcas(Idusuario, cn)


            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(Palets_Lineas.PLL_idlinea, "IdLinea")
            CONSULTA.SelCampo(ConfecEnvaseLineas.CEL_Idmaterial, "Id", Palets_Lineas.PLL_idtipoconfeccion, ConfecEnvaseLineas.CEL_Idconfec)
            CONSULTA.SelCampo(Envases.ENV_Nombre, "Nombre", ConfecEnvaseLineas.CEL_Idmaterial, Envases.ENV_IdEnvase)
            CONSULTA.SelCampo(ConfecEnvaseLineas.CEL_TipoEtiqueta, "TipoEtiqueta")
            Dim oMarcaEtiqueta As New Cdatos.bdcampo("@(SELECT MAR_Nombre FROM Marcas WHERE MAR_IdMarca = PLL_IdMarcaEti)", Marcas.MAR_Nombre.TipoBd, Marcas.MAR_Nombre.Longitud)
            CONSULTA.SelCampo(oMarcaEtiqueta, "MarcaEtiqueta")
            Dim oMarcaMaterial As New Cdatos.bdcampo("@(SELECT MAR_Nombre FROM Marcas WHERE MAR_IdMarca = PLL_IdMarcaMat)", Marcas.MAR_Nombre.TipoBd, Marcas.MAR_Nombre.Longitud)
            CONSULTA.SelCampo(oMarcaMaterial, "MarcaMaterial")
            CONSULTA.WheCampo(Palets_Lineas.PLL_idlinea, "=", IdLineaPalet)


            Dim sql As String = CONSULTA.SQL
            Dim dt As DataTable = ConfecEnvaseLineas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                For Each row As DataRow In dt.Rows
                    Dim TipoEtiqueta As String = (row("TipoEtiqueta").ToString & "").ToUpper.Trim

                    If TipoEtiqueta = "C" Then
                        EtiquetaCesta = VaInt(row("Id")).ToString & " - " & row("Nombre").ToString
                        MarcaEtiqueta = row("MarcaEtiqueta").ToString
                    ElseIf TipoEtiqueta = "J" Then
                        EtiquetaCaja = VaInt(row("Id")).ToString & " - " & row("Nombre").ToString
                        MarcaMaterial = row("MarcaMaterial").ToString
                    End If

                Next

            End If


        End If


    End Sub


    Public Function PrecioEstimadoEntrada(IdLineasCla As String) As Decimal

        Dim res As Decimal = 0

        Dim AlbEntrada_LineasCla As New E_AlbEntrada_lineascla(Idusuario, cn)


        Dim sql As String = "SELECT ALC_IdLineaEntrada FROM AlbEntrada_LineasCla WHERE ALC_Id = " & IdLineasCla
        Dim dt As DataTable = AlbEntrada_LineasCla.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim IdLineaEntrada As String = dt.Rows(0)("ALC_IdlineaEntrada").ToString & ""

                Dim sql2 As String = "SELECT SUM(ALC_KilosNetos) as Kilos, SUM(ALC_KilosNetos * ALC_PrecioEstimado) as Importe " & vbCrLf
                sql2 = sql2 & " FROM AlbEntrada_LineasCla WHERE ALC_IdLineaEntrada = " & IdLineaEntrada & vbCrLf

                Dim dt2 As DataTable = AlbEntrada_LineasCla.MiConexion.ConsultaSQL(sql2)
                If Not IsNothing(dt2) Then
                    If dt2.Rows.Count > 0 Then

                        Dim Kilos As Decimal = VaDec(dt2.Rows(0)("Kilos"))
                        Dim Importe As Decimal = VaDec(dt2.Rows(0)("Importe"))

                        If Kilos > 0 Then res = Importe / Kilos

                    End If
                End If

            End If
        End If



        Return res

    End Function


    Public Sub SincronizarProveedores(IdAgricultor As String)


        If VaInt(IdAgricultor) > 0 Then

            Dim agricultores As New E_Agricultores(Idusuario, cn)
            Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)

            If agricultores.LeerId(IdAgricultor) Then
                Dim listacuentas As New List(Of String)

                If TipoAgricultor.LeerId(agricultores.AGR_IdTipo.Valor) = True Then
                    listacuentas.Add(TipoAgricultor.TPA_ctaprov.Valor)
                    listacuentas.Add(TipoAgricultor.TPA_ctasumi.Valor)
                    listacuentas.Add(TipoAgricultor.TPA_ctaanti.Valor)
                    listacuentas.Add(TipoAgricultor.TPA_CtaCartera.Valor)
                End If
                AltaCuentas(listacuentas, IdAgricultor, agricultores.AGR_Nombre.Valor, agricultores.AGR_Domicilio.Valor, agricultores.AGR_Poblacion.Valor, agricultores.AGR_Provincia.Valor, agricultores.AGR_Cpostal.Valor, agricultores.AGR_Nif.Valor, agricultores.AGR_IdPais.Valor, "", TipoAgricultor.TPA_idtipoiva.Valor, "", "", (agricultores.AGR_IBAN.Valor & "").Trim)

            End If
        End If


    End Sub


    Public Sub SincronizarClientes(IdCliente As String)


        If VaInt(IdCliente) > 0 Then

            Dim Clientes As New E_Clientes(Idusuario, cn)
            Dim Tiposclientes As New E_Tiposclientes(Idusuario, cn)

            If Clientes.LeerId(IdCliente) Then
                Dim listacuentas As New List(Of String)

                If Tiposclientes.LeerId(Clientes.CLI_IdTipo.Valor) = True Then
                    listacuentas.Add(Tiposclientes.TPC_ctacliente.Valor)
                End If
                AltaCuentas(listacuentas, IdCliente, Clientes.CLI_Nombre.Valor, Clientes.CLI_Domicilio.Valor, Clientes.CLI_Poblacion.Valor, Clientes.CLI_Provincia.Valor, Clientes.CLI_CPostal.Valor, Clientes.CLI_Nif.Valor, Clientes.CLI_IdPais.Valor, "", "", Tiposclientes.TPC_idtipoiva.Valor, "", "")

            End If
        End If

    End Sub



    'Public Sub SincronizarProveedores(IdAgricultor As String)


    '    If VaInt(IdAgricultor) > 0 Then

    '        Dim Cuentas As New E_Cuentas(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    '        Dim Agricultores As New E_Agricultores(Idusuario, cn)


    '        If Agricultores.LeerId(IdAgricultor) Then

    '            Dim NIF_Agr As String = (Agricultores.AGR_Nif.Valor & "").Trim

    '            'Cuentas
    '            Dim sql As String = "SELECT CDV_Valor as Valor FROM ConfiguracionesDiversas WHERE CDV_Clave Like 'CTA_ASOCIADA_PROVEEDOR%'"
    '            Dim dt As DataTable = cn.ConsultaSQL(sql)
    '            If Not IsNothing(dt) Then

    '                For Each row As DataRow In dt.Rows

    '                    'Actualiza datos proveedor
    '                    Dim Cta As String = (row("Valor").ToString & "").Trim & VaInt(IdAgricultor).ToString("00000")
    '                    Dim bExisteCuenta As Boolean = False

    '                    If Cuentas.LeerId(Cta) Then
    '                        bExisteCuenta = True
    '                    Else
    '                        Cuentas = New E_Cuentas(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    '                    End If


    '                    'Corrige los datos del agricultor
    '                    Cuentas.NumeroCuenta.Valor = Cta
    '                    Cuentas.Nombre.Valor = Agricultores.AGR_Nombre.Valor
    '                    If NIF_Agr <> "" Then
    '                        Cuentas.Nif.Valor = Agricultores.AGR_Nif.Valor
    '                    Else
    '                        Cuentas.Nif.Valor = ""
    '                    End If
    '                    Cuentas.Domicilio.Valor = Agricultores.AGR_Domicilio.Valor
    '                    Cuentas.Poblacion.Valor = Agricultores.AGR_Poblacion.Valor
    '                    Cuentas.Provincia.Valor = Agricultores.AGR_Provincia.Valor
    '                    Cuentas.CodPostal.Valor = Agricultores.AGR_Cpostal.Valor
    '                    Cuentas.IdPais.Valor = Agricultores.AGR_IdPais.Valor



    '                    If bExisteCuenta Then
    '                        Cuentas.Actualizar()
    '                    Else
    '                        Cuentas.Insertar()
    '                    End If


    '                Next

    '            End If



    '        End If

    '    End If


    'End Sub


    'Public Sub SincronizarClientes(IdCliente As String)


    '    If VaInt(IdCliente) > 0 Then

    '        Dim Cuentas As New E_Cuentas(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    '        Dim Clientes As New E_Clientes(Idusuario, cn)


    '        If Clientes.LeerId(IdCliente) Then

    '            Dim NIF_Cli As String = (Clientes.CLI_Nif.Valor & "").Trim

    '            'Cuentas
    '            Dim sql As String = "SELECT CDV_Valor as Valor FROM ConfiguracionesDiversas WHERE CDV_Clave Like 'CTA_ASOCIADA_CLIENTE%'"
    '            Dim dt As DataTable = cn.ConsultaSQL(sql)
    '            If Not IsNothing(dt) Then

    '                For Each row As DataRow In dt.Rows

    '                    'Actualiza datos proveedor
    '                    Dim Cta As String = (row("Valor").ToString & "").Trim & VaInt(IdCliente).ToString("00000")
    '                    Dim bExisteCuenta As Boolean = False

    '                    If Cuentas.LeerId(Cta) Then
    '                        bExisteCuenta = True
    '                    Else
    '                        Cuentas = New E_Cuentas(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    '                    End If


    '                    'Corrige los datos del agricultor
    '                    Cuentas.NumeroCuenta.Valor = Cta
    '                    Cuentas.Nombre.Valor = Clientes.CLI_Nombre.Valor
    '                    If NIF_Cli <> "" Then
    '                        Cuentas.Nif.Valor = Clientes.CLI_Nif.Valor
    '                    Else
    '                        Cuentas.Nif.Valor = ""
    '                    End If
    '                    Cuentas.Domicilio.Valor = Clientes.CLI_Domicilio.Valor
    '                    Cuentas.Poblacion.Valor = Clientes.CLI_Poblacion.Valor
    '                    Cuentas.Provincia.Valor = Clientes.CLI_Provincia.Valor
    '                    Cuentas.CodPostal.Valor = Clientes.CLI_CPostal.Valor
    '                    Cuentas.IdPais.Valor = Clientes.CLI_IdPais.Valor



    '                    If bExisteCuenta Then
    '                        Cuentas.Actualizar()
    '                    Else
    '                        Cuentas.Insertar()
    '                    End If


    '                Next

    '            End If




    '        End If

    '    End If


    'End Sub


    Public Sub LeerFicheroINI_Muelles()

        Dim inifile As String = "c:\MuellesNet\Muelles.dll"

        ' -----------------------------------------------------------------------------------------
        NumeroMuelleIzquierda = VaInt(LeerConfig(inifile, "NumeroMuelleIzquierda"))
        NumeroMuelleDerecha = VaInt(LeerConfig(inifile, "NumeroMuelleDerecha"))
        PuertoLector = LeerConfig(inifile, "PuertoLector")
        PuertoImpresoraRFID = LeerConfig(inifile, "PuertoImpresoraRFID")
        AjusteTag = LeerConfig(inifile, "AjusteTag")



    End Sub


    'Public Sub Log(ByVal texto As String)

    '    Dim sw As IO.StreamWriter = IO.File.AppendText("LOG_" & Idusuario.ToString & "_" & Now.ToString("yyyyMMdd") & ".TXT")
    '    Dim separador As String = "----------------------------------------------------------------------------"
    '    sw.WriteLine(separador)
    '    sw.WriteLine(Now.ToString("HH:mm:ss - ") & texto)

    '    sw.Close()
    '    sw.Dispose()
    '    sw = Nothing

    'End Sub


    Public Sub ArreglarDuplicacionesLotes()

        Dim Lotes As New E_Lotes(Idusuario, cn)


        Dim sql As String = "DELETE FROM LotesProduccion WHERE LPD_IdLote = 0"
        Lotes.MiConexion.OrdenSql(sql)


        sql = "DELETE FROM Lotes WHERE LTE_IdLote = 0"
        Lotes.MiConexion.OrdenSql(sql)


    End Sub


    Public Function PrimeraEmpresaDisponible() As Integer

        Dim res As Integer = 0

        Dim IdEmpresa As Integer = 0


        'Comprueba la empresa por defecto del usuario
        Dim DatosUsuario As New E_DatosUsuario(Idusuario, CnComun)
        If DatosUsuario.LeerId(Idusuario) Then

            IdEmpresa = VaInt(DatosUsuario.IdEmpresa.Valor)
            If LstEmpresas.Contains(IdEmpresa) Then
                If IdEmpresa > 0 Then
                    res = IdEmpresa
                End If
            Else
                IdEmpresa = 0
            End If

        End If



        'Si no tiene, asignamos la primera de la lista de autorizadas
        If IdEmpresa = 0 Then
            If LstEmpresas.Count > 0 Then
                res = LstEmpresas(0)
            End If
        End If



        Return res

    End Function



#Region "Funciones nuevas en .NET"


    Public Function ObtenerCultivos(IdAgricultor As String, IdGeneroCultivo As String, bComprobar As Boolean, Optional IdFinca As String = "", Optional IdCultivo As String = "") As DataTable


        Dim Cultivos As New E_Cultivos(Idusuario, cnFincasNET)
        Dim Fincas As New E_Fincas(Idusuario, cnFincasNET)
        Dim Naves As New E_Naves(Idusuario, cnFincasNET)
        Dim Variedades As New E_Variedades(Idusuario, cnFincasNET)
        Dim CultivosGenero As New E_CultivosGenero(Idusuario, cnFincasNET)
        Dim GenerosTecnicos As New E_GenerosTecnicos(Idusuario, cnFincasNET)
        Dim ProgramasCalidad As New E_ProgramasCalidad(Idusuario, cnFincasNET)
        Dim RecintosSigPac As New E_RecintosSigPac(Idusuario, cnFincasNET)
        Dim Agricultor As New E_Agricultores(Idusuario, cn)


        'Dim consulta As New Cdatos.E_select
        'consulta.SelCampo(Cultivos.CUL_IdCultivo, "IdCultivo")
        'consulta.SelCampo(CultivosGenero.CGE_IdGenero, "IdGeneroAgro", Cultivos.CUL_IdGenero, CultivosGenero.CGE_IdCultivo)
        'consulta.SelCampo(Cultivos.CUL_IdFinca, "IdFinca")
        'consulta.SelCampo(Fincas.FIN_Nombre, "Finca", Cultivos.CUL_IdFinca, Fincas.FIN_IdFinca)
        'consulta.SelCampo(Fincas.FIN_IdAgricultor, "Codigo")
        'consulta.SelCampo(Agricultor.AGR_Nombre, "Agricultor", Fincas.FIN_IdAgricultor)
        'consulta.SelCampo(Naves.NAV_Nombre, "Nave", Cultivos.CUL_IdNave, Naves.NAV_IdNave)
        'consulta.SelCampo(Cultivos.CUL_FechaSiembraReal, "SiembraReal")
        'consulta.SelCampo(GenerosTecnicos.GEN_Nombre, "Genero", Cultivos.CUL_IdGenero, GenerosTecnicos.GEN_IdGenero)
        'consulta.SelCampo(Variedades.VAR_Nombre, "Variedad", Cultivos.CUL_IdVariedad, Variedades.VAR_IdVariedad)
        'consulta.SelCampo(ProgramasCalidad.PCL_Nombre, "Programa", Cultivos.CUL_IdProgramaCalidad, ProgramasCalidad.PCL_IdPrograma)
        'consulta.SelCampo(Cultivos.CUL_Bloquear, "Blq")
        'consulta.SelCampo(Cultivos.CUL_Observaciones, "Observaciones")
        'consulta.WheCampo(Cultivos.CUL_Activo, "=", "S")

        'If IdGeneroCultivo.Trim <> "" Then consulta.WheCampo(CultivosGenero.CGE_IdGenero, "=", IdGeneroCultivo)
        'consulta.WheCampo(Fincas.FIN_IdAgricultor, "=", IdAgricultor)


        'If VaInt(IdFinca) > 0 Then
        '    consulta.WheCampo(Fincas.FIN_IdFinca, "=", IdFinca)
        'End If

        'Dim sql1 As String = consulta.SQL




        Dim sql1 As String = " SELECT CUL_IdCultivo as IdCultivo, CGE_IdGenero as IdGeneroAgro, CUL_IdFinca as IdFinca, FIN_Nombre as Finca, FIN_IdAgricultor as Codigo, AGR_Nombre as Agricultor," & vbCrLf
        sql1 = sql1 & " NAV_Nombre as Nave, CUL_FechaSiembraReal as SiembraReal, GEN_Nombre as Genero, VAR_Nombre as Variedad, PCL_Nombre as Programa, CUL_Bloquear as Blq, " & vbCrLf
        sql1 = sql1 & " CUL_Observaciones as Observaciones" & vbCrLf
        sql1 = sql1 & " FROM TecnicosNet.dbo.Cultivos" & vbCrLf
        sql1 = sql1 & " LEFT JOIN TecnicosNet.dbo.CultivosGenero ON CGE_IdCultivo = CUL_IdGenero" & vbCrLf
        sql1 = sql1 & " LEFT JOIN TecnicosNet.dbo.Fincas ON FIN_IdFinca = CUL_IdFinca" & vbCrLf
        sql1 = sql1 & " LEFT JOIN Agricultores ON FIN_IdAgricultor = AGR_IdAgricultor" & vbCrLf
        sql1 = sql1 & " LEFT JOIN TecnicosNet.dbo.Naves ON NAV_IdNave = CUL_IdNave" & vbCrLf
        sql1 = sql1 & " LEFT JOIN TecnicosNet.dbo.Generos ON GEN_IdGenero = CUL_IdGenero" & vbCrLf
        sql1 = sql1 & " LEFT JOIN TecnicosNet.dbo.Variedades ON VAR_IdVariedad = CUL_IdVariedad" & vbCrLf
        sql1 = sql1 & " LEFT JOIN TecnicosNet.dbo.ProgramasCalidad ON CUL_IdProgramaCalidad = PCL_IdPrograma" & vbCrLf
        sql1 = sql1 & " WHERE " & vbCrLf
        sql1 = sql1 & " (CUL_Activo = 'S'" & vbCrLf
        If IdGeneroCultivo.Trim <> "" Then sql1 = sql1 & " AND CGE_IdGenero = " & IdGeneroCultivo & vbCrLf
        sql1 = sql1 & " AND FIN_IdAgricultor = " & IdAgricultor & vbCrLf
        If VaInt(IdFinca) > 0 Then sql1 = sql1 & " AND FIN_IdFinca = " & IdFinca & vbCrLf
        sql1 = sql1 & " )" & vbCrLf
        If VaDec(IdCultivo) > 0 Then
            sql1 = sql1 & " OR CUL_IdCultivo = " & IdCultivo & vbCrLf
        End If



        'consulta = New Cdatos.E_select
        'consulta.SelCampo(RecintosSigPac.REC_Id, "IdSigPac")
        'consulta.SelCampo(Cultivos.CUL_IdCultivo, "IdCultivo", RecintosSigPac.REC_IdFinca, Cultivos.CUL_IdFinca)
        'consulta.SelCampo(Cultivos.CUL_IdFinca, "IdFinca")
        'consulta.SelCampo(Fincas.FIN_Nombre, "Finca", Cultivos.CUL_IdFinca, Fincas.FIN_IdFinca)
        'consulta.SelCampo(Fincas.FIN_IdAgricultor, "Codigo")
        'consulta.SelCampo(Agricultor.AGR_Nombre, "Agricultor", Fincas.FIN_IdAgricultor)
        'consulta.SelCampo(Naves.NAV_Nombre, "Nave", Cultivos.CUL_IdNave, Naves.NAV_IdNave)
        'consulta.SelCampo(CultivosGenero.CGE_IdGenero, "IdGeneroAgro", Cultivos.CUL_IdGenero, CultivosGenero.CGE_IdCultivo)
        'consulta.SelCampo(Cultivos.CUL_FechaSiembraReal, "SiembraReal")
        'consulta.SelCampo(GenerosTecnicos.GEN_Nombre, "Genero", Cultivos.CUL_IdGenero, GenerosTecnicos.GEN_IdGenero)
        'consulta.SelCampo(Variedades.VAR_Nombre, "Variedad", Cultivos.CUL_IdVariedad, Variedades.VAR_IdVariedad)
        'consulta.SelCampo(ProgramasCalidad.PCL_Nombre, "Programa", Cultivos.CUL_IdProgramaCalidad, ProgramasCalidad.PCL_IdPrograma)
        'consulta.SelCampo(Cultivos.CUL_Bloquear, "Blq")
        'consulta.SelCampo(Cultivos.CUL_Observaciones, "Observaciones")
        'consulta.WheCampo(Cultivos.CUL_Activo, "=", "S")
        'If IdGeneroCultivo.Trim <> "" Then consulta.WheCampo(CultivosGenero.CGE_IdGenero, "=", IdGeneroCultivo)
        'consulta.WheCampo(RecintosSigPac.REC_IdAgricultor, "=", IdAgricultor)

        'If VaInt(IdFinca) > 0 Then
        '    consulta.WheCampo(Fincas.FIN_IdFinca, "=", IdFinca)
        'End If

        'Dim sql2 As String = "SELECT IdCultivo, IdGeneroAgro,Idfinca, Finca,Codigo,Agricultor ,Nave, SiembraReal, Genero, Variedad, Programa, Blq, Observaciones" & vbCrLf
        'sql2 = sql2 & " FROM ( " & vbCrLf & consulta.SQL & " ) as R" & vbCrLf


        Dim sql3 As String = " SELECT REC_Id as IdSigPac, CUL_IdCultivo as IdCultivo, CUL_IdFinca as IdFinca, FIN_Nombre as Finca, FIN_IdAgricultor as Codigo, " & vbCrLf
        sql3 = sql3 & " AGR_Nombre as Agricultor, NAV_Nombre as Nave, CGE_IdGenero as IdGeneroAgro, CUL_FechaSiembraReal as SiembraReal, GEN_Nombre as Genero," & vbCrLf
        sql3 = sql3 & " VAR_Nombre as Variedad, PCL_Nombre as Programa, CUL_Bloquear as Blq, CUL_Observaciones as Observaciones" & vbCrLf
        sql3 = sql3 & " FROM TecnicosNet.dbo.RecintosSigPac" & vbCrLf
        sql3 = sql3 & " LEFT JOIN TecnicosNet.dbo.Cultivos ON CUL_IdFinca = REC_IdFinca" & vbCrLf
        sql3 = sql3 & " LEFT JOIN TecnicosNet.dbo.Fincas ON FIN_IdFinca = CUL_IdFinca" & vbCrLf
        sql3 = sql3 & " LEFT JOIN Agricultores ON FIN_IdAgricultor = AGR_IdAgricultor" & vbCrLf
        sql3 = sql3 & " LEFT JOIN TecnicosNet.dbo.Naves ON NAV_IdNave = CUL_IdNave" & vbCrLf
        sql3 = sql3 & " LEFT JOIN TecnicosNet.dbo.CultivosGenero ON CGE_IdCultivo = CUL_IdGenero" & vbCrLf
        sql3 = sql3 & " LEFT JOIN TecnicosNet.dbo.Generos ON GEN_IdGenero = CUL_IdGenero" & vbCrLf
        sql3 = sql3 & " LEFT JOIN TecnicosNet.dbo.Variedades ON VAR_IdVariedad = CUL_IdVariedad" & vbCrLf
        sql3 = sql3 & " LEFT JOIN TecnicosNet.dbo.ProgramasCalidad ON PCL_IdPrograma = CUL_IdProgramaCalidad" & vbCrLf
        sql3 = sql3 & " WHERE (CUL_Activo = 'S'" & vbCrLf
        If IdGeneroCultivo.Trim <> "" Then sql3 = sql3 & " AND CGE_IdGenero = " & IdGeneroCultivo & vbCrLf
        sql3 = sql3 & " AND REC_IdAgricultor = " & IdAgricultor & vbCrLf
        If VaInt(IdFinca) > 0 Then sql3 = sql3 & " AND FIN_IdFinca = " & IdFinca & vbCrLf
        sql3 = sql3 & " )" & vbCrLf
        If VaDec(IdCultivo) > 0 Then
            sql3 = sql3 & " OR CUL_IdCultivo = " & IdCultivo & vbCrLf
        End If




        Dim sql2 As String = "SELECT IdCultivo, IdGeneroAgro,Idfinca, Finca,Codigo,Agricultor ,Nave, SiembraReal, Genero, Variedad, Programa, Blq, Observaciones" & vbCrLf
        sql2 = sql2 & " FROM ( " & vbCrLf & sql3 & " ) as R" & vbCrLf



        Dim sql As String = ""
        If Not bComprobar Then
            sql = "SELECT DISTINCT IdCultivo, idfinca,Finca,Codigo,Agricultor, Nave, SiembraReal, Genero, Variedad, Programa, Blq, Observaciones" & vbCrLf
        Else
            sql = "SELECT DISTINCT IdCultivo, IdGeneroAgro" & vbCrLf
        End If
        sql = sql & " FROM ( " & vbCrLf
        sql = sql & sql1
        sql = sql & " UNION ALL " & vbCrLf
        sql = sql & sql2
        sql = sql & " ) as D"


        Return Cultivos.MiConexion.ConsultaSQL(sql)

    End Function


#End Region


End Module
