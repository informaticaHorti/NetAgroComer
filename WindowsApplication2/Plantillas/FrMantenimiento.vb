Imports NetAgro.Cdatos
Imports DevExpress.XtraEditors

Public Class FrMantenimiento


    Public Enum TipoMantenimiento

        Guardar
        Modificar
        Anular
        Buscar
        Auxiliar1
        Auxiliar2
        Auxiliar3

    End Enum



    Public _AccionCompletadaConExito As Boolean = False


    Public Ncontrol As Integer
    Public HamodificadoGrid As Boolean
    Public Modificando As Boolean

    Dim _ListaControles As List(Of Object)
    Dim _ListaEtiquetas As List(Of Object)
    Dim _EntidadFrm As Entidad
    Private _ImprimirDespuesDeGuardar As Boolean = False
    Private _textoImpresion As String = "¿Desea imprimir el registro?"
    Private _respuestaImpresionDefecto As MessageBoxDefaultButton = MessageBoxDefaultButton.Button1
    Protected NuevoRegistro As Boolean
    Dim Primero As Boolean
    Protected OperFrm As String


    Protected _PanelCargando As New PanelCargando
    Protected _TipoMantenimiento As TipoMantenimiento = Nothing

    Dim BloqueoGenerado As Boolean
    Protected usuarios_procesos As E_usuarios_procesos = Nothing

    Public Event AccionTerminada(ByRef TipoAccion As TipoMantenimiento)
    Public Event DespuesDeSiguiente(Orden As Integer)
    Public Event NoImpresionDirecta()


    Public Const tipofrm As ETipoFrm = ETipoFrm.Mantenimiento


    'Private _DocumentarAlImprimir As Boolean = False
    'Public Property DocumentarAlImprimir As Boolean
    '    Get
    '        Return _DocumentarAlImprimir
    '    End Get
    '    Set(value As Boolean)
    '        _DocumentarAlImprimir = value
    '    End Set
    'End Property


    Dim _PrimerCampoEdicion As Integer

    Public Property PrimerCampoEdicion As Integer
        Set(ByVal value As Integer)
            _PrimerCampoEdicion = value
        End Set
        Get
            Return _PrimerCampoEdicion

        End Get

    End Property


    Private _InicioDespuesDeGuardar As Boolean = True
    Public Property InicioDespuesDeGuardar As Boolean
        Get
            Return _InicioDespuesDeGuardar
        End Get
        Set(value As Boolean)
            _InicioDespuesDeGuardar = value
        End Set
    End Property


    Private _InicioDespuesDeAuxiliar As Boolean = False
    Public Property InicioDespuesDeAuxiliar As Boolean
        Get
            Return _InicioDespuesDeAuxiliar
        End Get
        Set(value As Boolean)
            _InicioDespuesDeAuxiliar = value
        End Set
    End Property

    Private _InicioDespuesDeAuxiliar2 As Boolean = False
    Public Property InicioDespuesDeAuxiliar2 As Boolean
        Get
            Return _InicioDespuesDeAuxiliar2
        End Get
        Set(value As Boolean)
            _InicioDespuesDeAuxiliar2 = value
        End Set
    End Property

    Private _InicioDespuesDeAuxiliar3 As Boolean = False
    Public Property InicioDespuesDeAuxiliar3 As Boolean
        Get
            Return _InicioDespuesDeAuxiliar3
        End Get
        Set(value As Boolean)
            _InicioDespuesDeAuxiliar3 = value
        End Set
    End Property


    Dim _UltimaClave As String = ""
    Public Property UltimaClave As String
        Set(ByVal value As String)
            _UltimaClave = value
        End Set
        Get
            Return _UltimaClave

        End Get

    End Property


    Public Property RespuestaImpresionDefecto As MessageBoxDefaultButton
        Get
            Return _respuestaImpresionDefecto
        End Get
        Set(value As MessageBoxDefaultButton)
            _respuestaImpresionDefecto = value
        End Set
    End Property



    Public Property TextoPreguntaImpresion As String
        Get
            Return _textoImpresion
        End Get
        Set(ByVal value As String)
            _textoImpresion = value
        End Set
    End Property



    Public Property ImprimirDespuesDeGuardar As Boolean
        Get
            Return _ImprimirDespuesDeGuardar
        End Get
        Set(ByVal value As Boolean)
            _ImprimirDespuesDeGuardar = value
        End Set
    End Property



    Public Property EntidadFrm As Entidad
        Set(ByVal value As Entidad)
            _EntidadFrm = value
        End Set
        Get
            Return _EntidadFrm

        End Get

    End Property





    Dim _BtAvance As BotonesAvance
    Public Property BtAvance As BotonesAvance
        Set(ByVal value As BotonesAvance)
            _BtAvance = value
        End Set
        Get
            Return _BtAvance

        End Get

    End Property


    Public Property ListaControles As List(Of Object)
        ' lista de controles editables
        Set(ByVal value As List(Of Object))
            _ListaControles = value

        End Set
        Get
            Return _ListaControles

        End Get
    End Property

    Public Property ListaEtiquetas As List(Of Object)
        ' lista de etiquetas variables
        Set(ByVal value As List(Of Object))
            _ListaEtiquetas = value

        End Set
        Get
            Return _ListaEtiquetas

        End Get
    End Property
    '  Dim _Id As String
    '  Public Property Id As String
    '      Set(ByVal value As String)
    '          _Id = value
    '      End Set
    '      Get
    '          Return _Id
    '
    '        End Get

    'End Property

    Dim _IdInit As String = ""
    Public Property Idinit As String
        Set(ByVal value As String)
            _IdInit = value
        End Set
        Get
            Return _IdInit

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



    Dim _Registros As DataTable
    Public Property Registros As DataTable
        Set(ByVal value As DataTable)
            _Registros = value
        End Set
        Get
            Return _Registros

        End Get

    End Property

    Dim _IdRegistro As Integer
    Public Property Idregistro As Integer
        Set(ByVal value As Integer)
            _IdRegistro = value
        End Set
        Get
            Return _IdRegistro

        End Get

    End Property


    Dim _CampoClave As Integer

    Public Property CampoClave As Integer
        Set(ByVal value As Integer)
            _CampoClave = value
        End Set
        Get
            Return _CampoClave

        End Get

    End Property


    Dim _filtroEntidad As New Dictionary(Of String, String)

    Public Property FiltroEntidad As Dictionary(Of String, String)

        Set(ByVal value As Dictionary(Of String, String))
            _filtroEntidad = value
        End Set

        Get

            Return _filtroEntidad

        End Get
    End Property


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Panel1.BackColor = Color_PV_BarraEstado

    End Sub


    Private Sub FrMantenimiento_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        If Primero = True Then
            InicioFrm()
            Primero = False
        End If

    End Sub

    Private Sub FrMantenimiento_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Not IsNothing(usuarios_procesos) Then
            usuarios_procesos.AñadirProceso(Me.Text, "Cerrando formulario", Me.EntidadFrm.NombreTabla, "")
        End If

        'Libera memoria
        ClearMemory()

    End Sub

    Private Sub FrMantenimiento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If HamodificadoGrid = True Then
            MsgBox("Debe guardar los cambios")
            e.Cancel = True
        End If
    End Sub


    Protected Overridable Sub InicializaCargando()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not IsNothing(_PanelCargando) Then

            _PanelCargando.Visible = False

            'Si yo añado en diseño el PanelCargando, se me va a acoplar a uno de los dos paneles, por eso lo añado a mano aquí,
            'para que pertenezca al formulario. De esta forma, yo controlo su posición exacta
            Me.Controls.Add(_PanelCargando)

            Dim x As Integer = 0
            Dim y As Integer = 0

            x = Me.Size.Width / 2 - _PanelCargando.Size.Width / 2
            y = Me.Size.Height / 2 - _PanelCargando.Size.Height / 2

            _PanelCargando.Location = New Point(x, y)

        End If

    End Sub


    Private Sub FrMantenimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(0, 0)

        InicializaCargando()

        If PathDocumentos <> "" Then
            tt.SetToolTip(BtDoc, "Gestion documental")
            BtDoc.Visible = True
        Else
            BtDoc.Visible = False
        End If

        tt.SetToolTip(BtImprimirForm, "Imprimir pantalla")

        Ncontrol = 0

        Dim lc As New List(Of Object)
        ListaEtiquetas = lc

        CreaListaEtiquetas(Me)
        Primero = True

        If procesosUsuarios = 1 Then
            usuarios_procesos = New E_usuarios_procesos(Idusuario, cn)
            usuarios_procesos.AñadirProceso(Me.Text, "Abriendo formulario", Me.EntidadFrm.NombreTabla, "")
        End If


    End Sub
    Dim _OrdenControl As Integer

    Public Property OrdenControl As Integer
        Set(ByVal value As Integer)
            _OrdenControl = value
        End Set
        Get
            Return _OrdenControl

        End Get
    End Property

    Overloads Sub ParamTx(ByVal Control As TxDato, ByVal CampoBd As bdcampo, Optional ByVal LbFija As Lb = Nothing, Optional ByVal Obl As Boolean = False, Optional ByVal tipo As Cdatos.TiposCampo = -1, Optional ByVal ndec As Integer = -1, Optional ByVal lg As Integer = -1, Optional ByVal ex As String = "", Optional ByVal Añadirlista As Boolean = True)


        Dim cl As New Cdatos.PropiedadesTx
        cl.CampoBd = CampoBd

        If tipo = -1 Then
            If Not CampoBd Is Nothing Then
                cl.Tipo = CampoBd.TipoBd
            Else
                cl.Tipo = TiposCampo.Cadena
            End If
        Else
            cl.Tipo = tipo
        End If
        If cl.Tipo = TiposCampo.Importe Then
            Control.TextAlign = LeftRightAlignment.Right
        End If
        If lg = -1 Then
            If Not CampoBd Is Nothing Then
                cl.Longitud = CampoBd.Longitud
            Else
                cl.Longitud = 10
            End If
        Else
            cl.Longitud = lg
        End If
        If ndec = -1 Then
            If Not CampoBd Is Nothing Then
                cl.Decimales = CampoBd.Decimales
            Else
                cl.Decimales = 0
            End If
        Else
            cl.Decimales = ndec
        End If
        cl.Exclusivos = ex
        cl.Obligatorio = Obl
        Control.Orden = Ncontrol
        Control.ClParam = cl
        Control.ClForm = Me
        If Not LbFija Is Nothing Then
            LbFija.CL_ControlAsociado = Control
            LbFija.CL_ValorFijo = True
            LbFija.ClForm = Me
            Control.lbbusca = LbFija
        End If

        If Añadirlista = True Then

            Me.ListaControles.Add(Control)
            Ncontrol = Ncontrol + 1
        End If
    End Sub


    Overloads Sub ParamCb(ByVal Cb As CbBox, ByVal CampoBd As bdcampo, ByVal Enti As Entidad, ByVal CampoId As bdcampo, ByVal CampoNombre As bdcampo, ByVal lbfija As Lb, Optional ByVal Dt As DataTable = Nothing)
        Dim sql As String = ""
        Cb.ClForm = Me
        Cb.Orden = Ncontrol
        Cb.Campobd = CampoBd
        If Not lbfija Is Nothing Then
            lbfija.CL_ControlAsociado = Cb
            lbfija.CL_ValorFijo = True
        End If
        Cb.MiEntidad = Enti
        Cb.DisplayMember = CampoNombre.NombreCampo
        Cb.ValueMember = CampoId.NombreCampo

        If Not Dt Is Nothing Then
            Cb.DataSource = Dt
        ElseIf Not Enti Is Nothing Then
            Cb.MiEntidad = Enti
            sql = "Select "
            sql = sql + CampoId.NombreCampo + "," + CampoNombre.NombreCampo + " from "
            sql = sql + Enti.NombreTabla
            sql = sql + " order by " + CampoId.NombreCampo
            Cb.DataSource = Enti.MiConexion.ConsultaSQL(sql)


        End If

        Me.ListaControles.Add(Cb)

        Ncontrol = Ncontrol + 1


    End Sub
    Overloads Sub ParamCbFIJO(ByVal Cb As CbBox, ByVal CampoBd As bdcampo, ByVal dT As DataTable, ByVal lbfija As Lb)
        Dim sql As String = ""
        Cb.ClForm = Me
        Cb.Orden = Ncontrol
        Cb.Campobd = CampoBd
        If Not lbfija Is Nothing Then
            lbfija.CL_ControlAsociado = Cb
            lbfija.CL_ValorFijo = True
        End If
        Cb.DisplayMember = "nombre"
        Cb.ValueMember = "id"

        If Not dT Is Nothing Then
            Cb.DataSource = dT
        End If

        Me.ListaControles.Add(Cb)

        Ncontrol = Ncontrol + 1


    End Sub

    Overloads Sub ParamCb_Copia(ByVal Cb As CbBox, ByVal CampoBd As bdcampo, ByVal lbfija As Lb, ByVal CbCajon As CbBox)
        Cb.ClForm = Me
        Cb.Orden = Ncontrol
        Cb.Campobd = CampoBd
        If Not lbfija Is Nothing Then
            lbfija.CL_ControlAsociado = Cb
            lbfija.CL_ValorFijo = True
        End If
        Cb.DataSource = CbCajon.DataSource
        Cb.DisplayMember = CbCajon.DisplayMember
        Cb.ValueMember = CbCajon.ValueMember
        Me.ListaControles.Add(Cb)

        Ncontrol = Ncontrol + 1

    End Sub


    Overloads Sub ParamChk(ByVal Cb As Chk, ByVal CampoBd As bdcampo, ByVal ValorTrue As String, ByVal ValorFalse As String)
        Dim sql As String = ""
        Cb.ClForm = Me
        Cb.Orden = Ncontrol
        Cb.Campobd = CampoBd
        Cb.ValorCampoTrue = ValorTrue
        Cb.ValorCampoFalse = ValorFalse
        Me.ListaControles.Add(Cb)

        Ncontrol = Ncontrol + 1


    End Sub

    Overloads Sub Siguiente(ByVal Orden As Integer)
        Dim GRid As ClGrid
        If Orden = CampoClave Then
            ControlClave()
            If LbId.Text <> "" Then
                If LbId.Text = "+" Then
                    If InStr(OperFrm, PermisosFormularios.Alta) = 0 Then
                        MsgBox("No tiene permisos para insertar")
                    Else
                        BloquearCampos(False)
                        BloquearClaves(False)
                        NuevoRegistro = True
                        Modificando = True
                        If Orden + 1 <= ListaControles.Count - 1 Then
                            ListaControles(Orden + 1).select()
                            If TypeOf ListaControles(Orden + 1) Is CbBox Then
                                CType(ListaControles(Orden + 1), CbBox).DroppedDown = True
                            End If
                        End If
                    End If

                    Exit Sub
                End If
                If Not EntidadFrm Is Nothing Then
                    If EntidadFrm.LeerId(LbId.Text) = True Then
                        NuevoRegistro = False
                        Entidad_a_Datos()
                        BloquearCampos(True)
                        BloquearClaves(True)
                        If BModificar.Enabled = True And BModificar.Visible = True Then
                            BModificar.Select()
                        ElseIf BGuardar.Enabled = True And BGuardar.Visible = True Then
                            BGuardar.Select()
                        ElseIf Bsalir.Enabled = True And Bsalir.Visible = True Then
                            Bsalir.Select()
                        End If
                    Else
                        If InStr(OperFrm, PermisosFormularios.Alta) = 0 Then
                            MsgBox("no tiene permisos para insertar")
                        Else
                            BloquearCampos(False)
                            BloquearClaves(False)
                            NuevoRegistro = True
                            Modificando = True
                            If Orden + 1 <= ListaControles.Count - 1 Then
                                ListaControles(Orden + 1).select()
                                If TypeOf ListaControles(Orden + 1) Is CbBox Then
                                    CType(ListaControles(Orden + 1), CbBox).DroppedDown = True
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Else
            GRid = ListaControles(Orden).gridlin

            If Not GRid Is Nothing Then
                If GRid.Saliendo = False Then
                    If Orden = GRid.UltimoControl Then ' es el ultimo control de un grid.

                        If HayQueGuardarLinea(ListaControles(Orden)) Then

                            If Grabalineas(ListaControles(Orden).gridlin) = True Then
                                GRid.Grid.Select()

                                If GRid.GridEnterAutomatico Then
                                    ListaControles(GRid.PrimerControl).select()
                                    ListaControles(GRid.PrimerControl).focus()
                                End If

                                Exit Sub

                            End If

                        Else
                            Borralin(GRid)
                            BGuardar.Select()
                            BGuardar.Focus()
                            Exit Sub

                        End If



                    End If
                Else
                    GRid.Saliendo = False
                End If
            End If

            If TypeOf ListaControles(Orden) Is TxDato Then
                If CType(ListaControles(Orden), TxDato).SaltoAlfinal = True Then
                    If BGuardar.Enabled = True Then
                        BGuardar.Select()
                    ElseIf Bsalir.Enabled = True Then
                        Bsalir.Select()
                    End If
                    Exit Sub

                End If
            ElseIf TypeOf ListaControles(Orden) Is CbBox Then
                If CType(ListaControles(Orden), CbBox).SaltoAlfinal = True Then
                    If BGuardar.Enabled = True Then
                        BGuardar.Select()
                    ElseIf Bsalir.Enabled = True Then
                        Bsalir.Select()
                    End If
                    Exit Sub

                End If

            ElseIf TypeOf ListaControles(Orden) Is Chk Then
                If CType(ListaControles(Orden), Chk).SaltoAlfinal = True Then
                    If BGuardar.Enabled = True Then
                        BGuardar.Select()
                    ElseIf Bsalir.Enabled = True Then
                        Bsalir.Select()
                    End If
                    Exit Sub

                End If
            End If

            If Orden + 1 <= ListaControles.Count - 1 Then
                ActivarTab(ListaControles(Orden + 1))
                ListaControles(Orden + 1).select() ' LE PASO EL FOCO
                ListaControles(Orden + 1).focus() ' LE PASO EL FOCO

                GRid = ListaControles(Orden + 1).gridlin
                If Not GRid Is Nothing Then
                    If Orden + 1 = GRid.PrimerControl Then
                        GRid.Grid.Select()
                        GRid.GridView.FocusedRowHandle = GRid.GridView.RowCount - 1
                        'Entidad_a_DatosLin(GRid)
                        'ojo
                    End If
                End If
            Else
                If BGuardar.Enabled = True Then
                    BGuardar.Select()
                ElseIf Bsalir.Enabled = True Then
                    Bsalir.Select()
                End If

            End If

        End If


        RaiseEvent DespuesDeSiguiente(Orden)

    End Sub


    Protected Overridable Function HayQueGuardarLinea(Control As Control) As Boolean

        Return True

    End Function


    Private Sub ActivarTab(ByVal Control As Object)

        If TypeOf (Control.Parent) Is DevExpress.XtraTab.IXtraTabPage Then

            Dim pagina As DevExpress.XtraTab.XtraTabPage
            pagina = CType(Control.Parent, DevExpress.XtraTab.XtraTabPage)
            CType(pagina.Parent, DevExpress.XtraTab.XtraTabControl).SelectedTabPage = pagina

        End If

    End Sub


    Public Sub ControlAlb()
        EntidadFrm.VaciaEntidad()
        If EntidadFrm.LeerId(LbId.Text) = True Then
            NuevoRegistro = False
            Entidad_a_Datos()
            BloquearCampos(True)
            BloquearClaves(True)
            If BModificar.Enabled = True Then
                BModificar.Select()
            ElseIf Bsalir.Enabled = True Then
                Bsalir.Select()
            End If
        Else
            NuevoRegistro = True
        End If

    End Sub

    Public Overridable Sub ControlClave()

        'If LbId.Text = "" Then
        LbId.Text = ListaControles(0).text
        'End If

    End Sub
    Overloads Sub Anterior(ByVal Orden As Integer)
        If Orden > 0 Then
            ActivarTab(ListaControles(Orden - 1))
            ListaControles(Orden - 1).select()
            If TypeOf ListaControles(Orden - 1) Is CbBox Then
                CType(ListaControles(Orden - 1), CbBox).DroppedDown = True
            End If
        End If
    End Sub


    Public Overridable Sub BorraPan()

        Try

            'Log("Inicio borrapan")

            For Each l As Lb In ListaEtiquetas
                If l.CL_ValorFijo = False Then
                    l.Text = ""
                End If
            Next
            'Log("Terminado borrado etiquetas")


            Modificando = False
            BloqueoGenerado = False

            For Each l As Object In ListaControles

                'Log("Inicio borrado control " & l.name)

                If TypeOf (l) Is TxDato Then

                    CType(l, TxDato).Text = ""
                    CType(l, TxDato).Bloqueado = False
                    CType(l, TxDato).BackColor = Color.White

                    If CType(l, TxDato).MiError = True Then
                        QuitaError(CType(l, TxDato).Orden)
                        CType(l, TxDato).MiError = False
                    End If

                    Dim gr As New ClGrid
                    gr = CType(l, TxDato).GridLin


                    'Log("Borrado grid")

                    If Not gr Is Nothing Then
                        If gr.GridView.RowCount > 0 Then
                            'Application.DoEvents()
                            gr.Grid.DataSource = Nothing
                            'Log("Borralin")
                            Borralin(gr)
                        End If
                    End If
                    'Log("Fin borrado grid")


                    CType(l, TxDato)._UltimoValorCambiado = Nothing

                ElseIf TypeOf (l) Is CbBox Then
                    CType(l, CbBox).SelectedValue = 0

                ElseIf TypeOf (l) Is Chk Then
                    CType(l, Chk).Checked = CType(l, Chk).ValorDefecto
                    CType(l, Chk).HaCambiado = False

                End If

            Next

            'Log("Terminado borrado de controles")


            LbId.Text = ""
            'Log("Inicio bloquearcampos")
            BloquearCampos(True)
            'Log("Inicio bloquearclaves")
            BloquearClaves(False)
            HamodificadoGrid = False
            'Log("Inicio bloquearbotones")
            BloquearBotones(False)

            'Log("Inicio Vaciaentidad")
            If Not IsNothing(EntidadFrm) Then EntidadFrm.VaciaEntidad()
            'Log("Inicio Foco primer control de la lista")
            If ListaControles.Count > 0 Then ListaControles(0).focus()


        Catch ex As Exception
            Dim err As New Errores
            err.Muestraerror("Error al borrar los datos de la pantalla", "Borrapan", ex.Message)
        End Try


        NuevoRegistro = False

        'Log("Inicio liberación de memoria")
        'Libera memoria
        ClearMemory()


        'Log("Cambio imagen botón")
        BtDoc.Image = My.Resources.GD_INACTIVO
        'Log("Fin de cambio imagen botón")


    End Sub


    Public Overridable Sub BloquearBotones(ByVal Bloqueo As Boolean)
        BGuardar.Enabled = Not Bloqueo
        BModificar.Enabled = Not Bloqueo
        BAnular.Enabled = Not Bloqueo
    End Sub


    Public Overridable Sub Borralin(ByVal gr As ClGrid)

        gr.EntidadLinea.VaciaEntidad()
        LimpiarCamposlin(gr)
        gr.IdLinea = ""

        'ListaControles(gr.PrimerControl).select()
    End Sub


    Public Overridable Sub LimpiarCamposlin(ByVal gr As ClGrid)

        For Each l As Lb In ListaEtiquetas
            If l.CL_ValorFijo = False Then
                If Not l.CL_ControlAsociado Is Nothing Then
                    If l.CL_ControlAsociado.orden >= gr.PrimerControl And l.CL_ControlAsociado.orden <= gr.UltimoControl Then
                        l.Text = ""
                    End If
                End If
            End If
        Next

        For Each l As Object In ListaControles
            If l.orden >= gr.PrimerControl And l.orden <= gr.UltimoControl Then
                If TypeOf (l) Is TxDato Then
                    CType(l, TxDato).Text = ""
                    CType(l, TxDato).Bloqueado = False
                    If CType(l, TxDato).MiError = True Then
                        QuitaError(CType(l, TxDato).Orden)
                        CType(l, TxDato).MiError = False
                    End If
                    'CType(l, TxDato).UltimoValorValidado = Nothing
                    CType(l, TxDato)._UltimoValorCambiado = Nothing
                ElseIf TypeOf (l) Is CbBox Then
                    CType(l, CbBox).SelectedValue = 0
                ElseIf TypeOf (l) Is Chk Then
                    CType(l, Chk).Checked = CType(l, Chk).ValorDefecto
                End If
            End If
        Next
    End Sub


    Public Overridable Sub InicioFrm()
        If Idinit = "" Then
            BorraPan()
        End If
        'OperFrm = "ABM" ' FUNCION DEPENDIENDO DEL FORMULARIO Y EL PERFIL DEVUELVE LOS DERECHOS AMB

        Dim TextoError As String = ""
        OperFrm = PermisoFormulario(Idusuario, Me.Name, TextoError)
        If TextoError.Trim <> "" Then
            MsgBox(TextoError)
        End If
        Dim FBOTON As New Font(BGuardar.Font.FontFamily, BGuardar.Font.Size, FontStyle.Strikeout)
        If InStr(OperFrm, PermisosFormularios.Alta) = 0 Then
            BGuardar.Font = FBOTON
        End If
        If InStr(OperFrm, PermisosFormularios.Modificaciones) = 0 Then
            BModificar.Font = FBOTON
        End If
        If InStr(OperFrm, PermisosFormularios.Bajas) = 0 Then
            BAnular.Font = FBOTON
        End If

    End Sub
    Public Overridable Sub DespuesdeGuardar()

    End Sub
    Public Overridable Sub DespuesdeAnular()

    End Sub

    Public Overridable Sub DespuesdeGuardarLinea(ByVal gr As ClGrid)

    End Sub
    Public Overridable Sub DespuesdeCargarLineas(ByVal gr As ClGrid)

    End Sub

    Overloads Sub PonError(ByVal orden As Integer)
        Try
            ListaControles(orden).BACKCOLOR = Color.PaleVioletRed
            If TypeOf ListaControles(orden) Is TxDato Then ListaControles(orden).select()
            '            Dim Ic As New Windows.Forms.PictureBox
            '            Ic.Parent = ListaControles(orden).parent
            '
            '            Ic.Image = IconoError.Image
            '            Ic.Width = IconoError.Width
            '            Ic.Height = ListaControles(orden).Height
            '            Ic.Top = ListaControles(orden).top + 1
            '            Ic.Left = ListaControles(orden).left + ListaControles(orden).width - Ic.Width - 1
            '            Ic.Visible = True
            '            Ic.Name = "IC" & orden.ToString
            '            Ic.Parent.Controls.Add(Ic)
            '            Ic.BringToFront()
        Catch ex As Exception

        End Try

    End Sub
    Overloads Sub QuitaError(ByVal Orden As Integer)


        If ListaControles(Orden).ENABLED = True Then
            ListaControles(Orden).BACKCOLOR = Color.White
        End If

        '       Dim c As Control
        '       c = BuscaObj(Me, "IC" & Orden.ToString)
        '       If Not c Is Nothing Then
        ' c.Visible = False
        ' c.Parent.Controls.Remove(c)
        ' End If




    End Sub

    Overloads Function BuscaObj(ByVal Panel As Control, ByVal Nombre As String) As Control
        Dim C As Control = Nothing
        Try
            For Each ic As Object In Panel.Controls
                If ic.Name = Nombre Then
                    C = ic
                Else
                    C = BuscaObj(ic, Nombre)
                End If
                If Not C Is Nothing Then
                    Exit For
                End If
            Next
        Catch ex As Exception

        End Try
        Return C
    End Function

    Private Sub CreaListaEtiquetas(ByVal Panel As Control)
        'crea una lista con las etiquetas variables del formulario
        Try

            For Each CC As Object In Panel.Controls
                If TypeOf (CC) Is Lb Then

                    ListaEtiquetas.Add(CC)
                Else
                    CreaListaEtiquetas(CC)
                End If

            Next
        Catch ex As Exception
            Dim a
            a = ""
        End Try

    End Sub


    Protected Overridable Sub BGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGuardar.Click

        _AccionCompletadaConExito = False

        If Modificando = True Then
            _TipoMantenimiento = TipoMantenimiento.Guardar
            MuestraCargando(False)
            _BackgroundWorker.RunWorkerAsync()
            'Guardar()
        End If
    End Sub


    Protected Overridable Sub BModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BModificar.Click
        Modificar()
    End Sub


    Protected Overridable Sub BAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAnular.Click
        If LbId.Text = "" Then Exit Sub
        _TipoMantenimiento = TipoMantenimiento.Anular
        MuestraCargando(False)
        _BackgroundWorker.RunWorkerAsync()
        'Anular()
    End Sub


    Protected Overridable Sub BTaux1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTaux1.Click

        _TipoMantenimiento = TipoMantenimiento.Auxiliar1
        MuestraCargando(True)
        _BackgroundWorker.RunWorkerAsync()
        'botonauxiliar1()
    End Sub


    Protected Overridable Sub BtAux2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAux2.Click

        _TipoMantenimiento = TipoMantenimiento.Auxiliar2
        MuestraCargando(True)
        _BackgroundWorker.RunWorkerAsync()
        'botonAuxiliar2()
    End Sub


    Protected Overridable Sub BtAux3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAux3.Click

        _TipoMantenimiento = TipoMantenimiento.Auxiliar3
        MuestraCargando(True)
        _BackgroundWorker.RunWorkerAsync()
        'botonAuxiliar3()
    End Sub


    Protected Overridable Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Button1_CLick()

        'Dim dt As New DataTable
        'Dim sql As String = ""
        'Dim id As String
        'Dim f As String = ""
        'Registros = Nothing
        'Idregistro = 0

        ''If Buscando = True Then
        ''    Buscando = False
        ''    BModificar.Visible = True
        ''    BAnular.Visible = True
        ''    BGuardar.Visible = True
        ''    If Not EntidadFrm.ClavePrimaria Is Nothing Then
        ''        f = FiltroBusqueda()
        ''        BorraPan()
        ''        If f <> "" Then
        ''            If Not BtAvance Is Nothing Then
        ''                If Not BtAvance.Filtro Is Nothing Then
        ''                    If BtAvance.Filtro <> "" Then
        ''                        f = f + " AND " + BtAvance.Filtro
        ''                    End If
        ''                End If
        ''            End If
        ''            sql = "Select " + EntidadFrm.ClavePrimaria.NombreCampo + " from " + EntidadFrm.NombreTabla + " where " + f
        ''            dt = EntidadFrm.MiConexion.ConsultaSQL(sql)
        ''            Registros = dt
        ''            Idregistro = 0
        ''            If Not BtAvance Is Nothing Then
        ''                'BtAvance.Width = 101
        ''                BtAvance.Chfiltro.Visible = False
        ''            End If
        ''            If dt.Rows.Count > 0 Then
        ''                Idregistro = 1
        ''                id = dt.Rows(0)(0).ToString
        ''                If Not BtAvance Is Nothing Then
        ''                    'BtAvance.Width = 137
        ''                    BtAvance.Chfiltro.Visible = True
        ''                    BtAvance.Width = BtAvance.Button1.Width + BtAvance.Button2.Width + BtAvance.Button3.Width + BtAvance.Button4.Width + BtAvance.Chfiltro.Width + 25

        ''                    BtAvance.Chfiltro.Checked = True
        ''                End If
        ''                If EntidadFrm.LeerId(id) = True Then
        ''                    LbId.Text = id
        ''                    ControlAlb()
        ''                End If
        ''            End If
        ''        End If
        ''    Else
        ''        BorraPan()
        ''    End If

        ''Else
        'If OrdenControl = 0 Then
        '    BModificar.Visible = False
        '    BAnular.Visible = False
        '    BGuardar.Visible = False
        '    BorraPan()
        '    Buscando = True
        '    BloquearCamposCabecera(False)
        '    BloquearClaves(True)

        '    Me.ListaControles(CampoClave + 1).focus()
        'End If
        '' End If

    End Sub


    Protected Overridable Sub Button1_CLick()

    End Sub


    Protected Overridable Sub Bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsalir.Click

        Registros = Nothing
        Idregistro = 0
        If Not BtAvance Is Nothing Then
            BtAvance.Chfiltro.Visible = False
            '            BtAvance.Width = 101
        End If

        Salir()

    End Sub



    Protected Delegate Sub Guardar_Delegate()
    Public Overridable Sub Guardar()

        If InStr(OperFrm, PermisosFormularios.Modificaciones) = 0 And InStr(OperFrm, PermisosFormularios.Alta) = 0 Then
            MsgBox("No tiene permisos para guardar")
            Exit Sub
        End If


        HamodificadoGrid = False


        If GuardarCabecera(ListaControles.Count - 1, True) = True Then

            'Pregunta si imprime después de guardar
            If ImprimirDespuesDeGuardar Then

                If XtraMessageBox.Show(TextoPreguntaImpresion, "¿Desea imprimir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _respuestaImpresionDefecto) = Windows.Forms.DialogResult.Yes Then
                    ImpresionDirecta()
                Else
                    RaiseEvent NoImpresionDirecta()
                End If

            End If



            If LbId.Text = "" Then
                Me.Close()
            Else
                If Idinit <> "" Then
                    Me.Close()
                Else
                    BorraPan()
                End If
            End If


            _AccionCompletadaConExito = True

        Else

            _AccionCompletadaConExito = False

        End If


    End Sub


    Protected Delegate Sub Modificar_Delegate()
    Public Overridable Sub Modificar()

        If LbId.Text = "" Then Exit Sub
        If InStr(OperFrm, PermisosFormularios.Modificaciones) = 0 Then
            MsgBox("No tiene permisos para modificar")
            Exit Sub
        End If
        If EstaBloqueado() = True Then
            Exit Sub
        End If




        If CumpleFiltro(True, "MODIFICAR") = False Then
            Exit Sub
        End If

        BloquearClaves(True)
        'BloquearCampos(False)
        BloquearCamposCabecera(False)



        ListaControles(CampoClave + 1).select()
        If Not ListaControles(CampoClave + 1).gridlin Is Nothing Then
            ListaControles(CampoClave + 1).GRIDLIN.Grid.Select()
        End If
        Modificando = True
        BloquearRegistro()

        If Not IsNothing(usuarios_procesos) Then
            If Not EntidadFrm Is Nothing Then
                usuarios_procesos.AñadirProceso(Me.Text, "Modificacion", Me.EntidadFrm.NombreTabla, Me.EntidadFrm.ClavePrimaria.Valor)

            End If
        End If



    End Sub


    Protected Delegate Sub Anular_Delegate()
    Public Overridable Sub Anular()

        If LbId.Text = "" Then Exit Sub
        If InStr(OperFrm, PermisosFormularios.Bajas) = 0 Then
            MsgBox("No tiene permisos para anular")
        Else
            If EstaBloqueado() = False Then
                If CumpleFiltro(True, "ANULAR") = True Then

                    If MsgBox("Desea anular el registro", vbYesNo) = vbYes Then
                        EntidadFrm.LoguearXFormulario("B")
                        EntidadFrm.Eliminar()
                        DespuesdeAnular()
                        QuitarBloqueo()

                        If Not IsNothing(usuarios_procesos) Then
                            usuarios_procesos.AñadirProceso(Me.Text, "BAJA", Me.EntidadFrm.NombreTabla, LbId.Text)
                        End If


                        BorraPan()
                        If ListaControles.Count > 0 Then ListaControles(0).select()
                    End If
                End If
            End If

        End If
    End Sub


    Protected Delegate Sub BotonAuxiliar1_Delegate()
    Public Overridable Sub BotonAuxiliar1()

    End Sub


    Protected Delegate Sub BotonAuxiliar2_Delegate()
    Public Overridable Sub BotonAuxiliar2()

    End Sub


    Protected Delegate Sub BotonAuxiliar3_Delegate()
    Public Overridable Sub BotonAuxiliar3()

    End Sub




    Public Function GuardarCabecera(ByVal Ultimo As Integer, ByVal final As Boolean) As Boolean
        Dim x As Integer
        Dim grabar As Boolean = True
        Dim Nregistro As Boolean



        If Not EntidadFrm Is Nothing Then
            If LbId.Text = "" Then
                MsgBox("no se generó id ")
                Return False
            End If
        End If
        For x = 0 To Ultimo
            If ListaControles(x).gridlin Is Nothing Then
                ListaControles(x).validar(False)
            End If
        Next
        Dim txerr As String = ""
        For x = 0 To Ultimo
            If ListaControles(x).mierror = True Then

                grabar = False
                Dim l As Object = ListaControles(x)
                If txerr = "" Then
                    If TypeOf l Is TxDato Then
                        If Not CType(l, TxDato).ClParam.CampoBd Is Nothing Then
                            If Not CType(l, TxDato).ClParam.CampoBd.NombreCampo Is Nothing Then
                                txerr = CType(l, TxDato).ClParam.CampoBd.NombreCampo
                            End If
                        End If

                    ElseIf TypeOf (l) Is CbBox Then
                        If Not CType(l, CbBox).Campobd Is Nothing Then
                            If Not CType(l, CbBox).Campobd.NombreCampo Is Nothing Then
                                txerr = CType(l, CbBox).Campobd.NombreCampo
                            End If
                        End If

                    ElseIf TypeOf (l) Is Chk Then
                        If Not CType(l, Chk).Campobd Is Nothing Then
                            If Not CType(l, Chk).Campobd.NombreCampo Is Nothing Then
                                txerr = CType(l, Chk).Campobd.NombreCampo
                            End If
                        End If

                    End If
                End If

            End If
        Next


        If grabar = True Then

            If Not EntidadFrm Is Nothing Then

                'If EntidadFrm.ExisteId(EntidadFrm.ValorClavePrimaria) = True Then
                If EntidadFrm.ExisteId(LbId.Text) = True Then
                    Nregistro = False
                Else
                    Nregistro = True
                End If

                If Nregistro = True Then
                    Datos_a_Entidad()
                    EntidadFrm.Insertar()
                    BloquearClaves(True)

                    If Not IsNothing(usuarios_procesos) Then
                        usuarios_procesos.AñadirProceso(Me.Text, "Alta", Me.EntidadFrm.NombreTabla, Me.EntidadFrm.ClavePrimaria.Valor)
                    End If

                Else
                    If NuevoRegistro = False Then
                        EntidadFrm.LoguearXFormulario("M")
                    End If
                    Datos_a_Entidad()
                    EntidadFrm.Actualizar()
                End If

            End If

            If final = True Then

                DespuesdeGuardar()
                QuitarBloqueo()
            Else
                If BloqueoGenerado = False Then
                    BloquearRegistro()
                End If
            End If


        Else
            MsgBox("Corregir errores. Campo: " + txerr)
        End If
        Return grabar

    End Function



    Public Overridable Sub ImpresionDirecta()

        BotonAuxiliar2()

    End Sub



    Public Overridable Sub Salir()
        If LbId.Text = "" And Buscando = False Then
            Me.Close()
        Else

            Buscando = False

            If HamodificadoGrid = False Then
                QuitarBloqueo()
                If Idinit <> "" Then
                    Me.Close()
                Else
                    BorraPan()
                    If ListaControles.Count > 0 Then ListaControles(0).select()
                End If
            Else
                MsgBox("Debe guardar los datos")

            End If
        End If

    End Sub


    Public Overridable Function GuardarLineas(ByVal Gr As ClGrid) As Boolean

        Dim x As Integer
        Dim grabar As Boolean = True
        For x = 0 To ListaControles.Count - 1
            If ListaControles(x).orden >= Gr.PrimerControl And ListaControles(x).orden <= Gr.UltimoControl Then
                If ListaControles(x).GRIDLIN Is Gr Then
                    ListaControles(x).validar(False)
                End If
            End If
        Next
        For x = 0 To ListaControles.Count - 1
            If ListaControles(x).orden >= Gr.PrimerControl And ListaControles(x).orden <= Gr.UltimoControl Then
                If ListaControles(x).GRIDLIN Is Gr Then

                    If ListaControles(x).mierror = True Then
                        grabar = False
                    End If
                End If
            End If
        Next

        If grabar = True Then
            If GuardarCabecera(Gr.PrimerControl - 1, False) = True Then
                If Gr.IdLinea Is Nothing Then
                    Gr.IdLinea = ""
                End If
                If Gr.IdLinea = "" Then
                    If Gr.AñadirLinea = False Then
                        Return True
                    End If
                    DatosLin_a_Entidad(Gr, Gr.EntidadLinea)
                    Gr.IdLinea = Gr.EntidadLinea.MaxId()
                    Gr.EntidadLinea.AsignarClavePrimaria(Gr.IdLinea)
                    Gr.EntidadLinea.Insertar()
                Else
                    ' Gr.EntidadLinea.AsignarClavePrimaria(Gr.IdLinea)
                    DatosLin_a_Entidad(Gr, Gr.EntidadLinea, False)
                    Gr.EntidadLinea.LoguearXFormulario("M")
                    Gr.EntidadLinea.Actualizar()
                End If
                DespuesdeGuardarLinea(Gr)
                If Gr.MismaLinea = False Then
                    Borralin(Gr)
                    ListaControles(Gr.PrimerControl).select()
                End If
                Cargalineas(Gr)
                Return True
            Else
                MsgBox("Corregir errores")
                Return False
            End If

        Else
            Return False
        End If
    End Function

    Public Overridable Sub Entidad_a_Datos()


        For Each bdcampo In EntidadFrm.MiListadeCampos

            For Each Tx In ListaControles

                If TypeOf (Tx) Is TxDato Then
                    If CType(Tx, TxDato).ClParam.CampoBd Is bdcampo Then
                        Select Case CType(Tx, TxDato).ClParam.Tipo
                            Case TiposCampo.Fecha
                                Tx.Text = bdcampo.Valor.Substring(0, 10)
                            Case TiposCampo.Hora
                                Tx.text = VaTime(bdcampo.Valor).ToString("HH:mm:ss")
                            Case TiposCampo.Importe
                                Tx.TEXT = Mascara(bdcampo.Valor, TiposCampo.Importe, CType(Tx, TxDato).ClParam.Decimales)
                                If VaDec(Tx.TEXT) = 0 Then
                                    Tx.TEXT = ""
                                End If
                            Case TiposCampo.Entero, TiposCampo.EnteroPositivo
                                Tx.TEXT = Mascara(bdcampo.Valor, CType(Tx, TxDato).ClParam.Tipo)
                                If VaInt(Tx.TEXT) = 0 Then
                                    Tx.TEXT = ""
                                End If
                            Case Else
                                Tx.Text = bdcampo.Valor
                        End Select
                        If Tx.TEXT <> "" Then
                            CType(Tx, TxDato).Validar(False)
                        End If
                    End If
                ElseIf TypeOf (Tx) Is CbBox Then
                    If CType(Tx, CbBox).Campobd Is bdcampo Then
                        CType(Tx, CbBox).SelectedValue = bdcampo.Valor
                    End If
                ElseIf TypeOf (Tx) Is Chk Then
                    If CType(Tx, Chk).Campobd Is bdcampo Then
                        If bdcampo.Valor = CType(Tx, Chk).ValorCampoTrue Then
                            CType(Tx, Chk).Checked = True
                        Else
                            CType(Tx, Chk).Checked = False
                        End If
                    End If

                End If

            Next
        Next

        If Not IsNothing(usuarios_procesos) Then
            usuarios_procesos.AñadirProceso(Me.Text, "Consulta", Me.EntidadFrm.NombreTabla, Me.EntidadFrm.ClavePrimaria.Valor)
        End If


        If Not BtAvance Is Nothing Then
            If Not BtAvance.CampoOrden Is Nothing Then
                UltimaClave = EntidadFrm.ValorCampo(BtAvance.CampoOrden)
            End If
        End If


        Try

            ActualizaBotonGestionDocumental(BtDoc, Me.EntidadFrm, LbId.Text)

        Catch ex As Exception

        End Try



    End Sub


    Public Overridable Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)


        'LimpiarCamposlin(Grid)
        For Each Tx In ListaControles
            For Each bdcampo In Grid.EntidadLinea.MiListadeCampos

                If TypeOf (Tx) Is TxDato Then
                    If CType(Tx, TxDato).GridLin Is Grid Then
                        If CType(Tx, TxDato).ClParam.CampoBd Is bdcampo Then
                            Select Case CType(Tx, TxDato).ClParam.Tipo
                                Case TiposCampo.Fecha
                                    Tx.Text = bdcampo.Valor.Substring(0, 10)
                                Case TiposCampo.Hora
                                    Tx.text = VaDate(bdcampo.Valor).ToString("HH:mm:ss")
                                Case TiposCampo.Importe
                                    Tx.TEXT = Mascara(bdcampo.Valor, TiposCampo.Importe, CType(Tx, TxDato).ClParam.Decimales)
                                    ' If VaDec(Tx.TEXT) = 0 Then
                                    ' Tx.TEXT = ""
                                    ' End If
                                Case TiposCampo.Entero, TiposCampo.EnteroPositivo
                                    Tx.TEXT = Mascara(bdcampo.Valor, CType(Tx, TxDato).ClParam.Tipo)
                                    'If VaInt(Tx.TEXT) = 0 Then
                                    ' Tx.TEXT = ""
                                    ' End If
                                Case Else
                                    Tx.Text = bdcampo.Valor
                            End Select
                            If Tx.TEXT <> "" Then
                                CType(Tx, TxDato).Validar(False)
                            End If
                        End If
                    End If
                ElseIf TypeOf (Tx) Is CbBox Then
                    If CType(Tx, CbBox).GridLin Is Grid Then
                        If CType(Tx, CbBox).Campobd Is bdcampo Then
                            CType(Tx, CbBox).SelectedValue = bdcampo.Valor
                        End If
                    End If
                ElseIf TypeOf (Tx) Is Chk Then
                    If CType(Tx, Chk).GridLin Is Grid Then
                        If CType(Tx, Chk).Campobd Is bdcampo Then
                            If bdcampo.Valor = CType(Tx, Chk).ValorCampoTrue Then
                                CType(Tx, Chk).Checked = True
                            Else
                                CType(Tx, Chk).Checked = False
                            End If
                        End If
                    End If
                End If
            Next
        Next
    End Sub

    Protected Overridable Sub Datos_a_Entidad()
        For Each bdcampo In EntidadFrm.MiListadeCampos
            For Each Tx In ListaControles
                If TypeOf (Tx) Is TxDato Then
                    If CType(Tx, TxDato).ClParam.CampoBd Is bdcampo Then
                        bdcampo.Valor = Tx.text
                    End If
                ElseIf TypeOf (Tx) Is CbBox Then
                    If CType(Tx, CbBox).Campobd Is bdcampo Then
                        bdcampo.Valor = CType(Tx, CbBox).SelectedValue.ToString
                    End If
                ElseIf TypeOf (Tx) Is Chk Then
                    If CType(Tx, Chk).Campobd Is bdcampo Then
                        If CType(Tx, Chk).Checked = True Then
                            bdcampo.Valor = CType(Tx, Chk).ValorCampoTrue
                        Else
                            bdcampo.Valor = CType(Tx, Chk).ValorCampoFalse
                        End If
                    End If

                End If

            Next
        Next
    End Sub
    Protected Overridable Sub DatosLin_a_Entidad(ByVal gr As ClGrid, ByVal EntidadLin As Entidad, Optional AsignarClavePrimariaLinea As Boolean = True)

        HamodificadoGrid = True

        For Each bdcampo In EntidadLin.MiListadeCampos

            If AsignarClavePrimariaLinea Then
                If bdcampo Is EntidadLin.ClavePrimaria Then
                    bdcampo.Valor = gr.IdLinea
                End If
            End If


            For Each Tx In ListaControles

                If Not Tx.gridlin Is Nothing Then
                    If CType(Tx.gridlin, ClGrid) Is gr Then

                        If TypeOf (Tx) Is TxDato Then
                            If CType(Tx, TxDato).ClParam.CampoBd Is bdcampo Then
                                bdcampo.Valor = Tx.text
                            End If
                        ElseIf TypeOf (Tx) Is CbBox Then
                            If CType(Tx, CbBox).Campobd Is bdcampo Then
                                If Not CType(Tx, CbBox).SelectedValue Is Nothing Then
                                    bdcampo.Valor = CType(Tx, CbBox).SelectedValue.ToString
                                End If
                            End If
                        ElseIf TypeOf (Tx) Is Chk Then
                            If CType(Tx, Chk).Campobd Is bdcampo Then
                                If CType(Tx, Chk).Checked = True Then
                                    bdcampo.Valor = CType(Tx, Chk).ValorCampoTrue
                                Else
                                    bdcampo.Valor = CType(Tx, Chk).ValorCampoFalse
                                End If
                            End If

                        End If

                    End If
                End If
            Next
        Next
    End Sub





    Protected Sub BloquearClaves(ByVal Bloqueo As Boolean)
        Dim x As Integer
        For x = 0 To ListaControles.Count - 1
            If x <= CampoClave Then
                ListaControles(x).enabled = Not Bloqueo
            End If
        Next

    End Sub
    Protected Overridable Sub BloquearCampos(ByVal Bloqueo As Boolean)
        Dim x As Integer
        For x = 0 To ListaControles.Count - 1
            If x > CampoClave Then
                ListaControles(x).enabled = Not Bloqueo
            End If
        Next

    End Sub

    Private Sub BloquearCamposCabecera(ByVal Bloqueo As Boolean)
        Dim x As Integer
        For x = 0 To ListaControles.Count - 1
            If x > CampoClave Then
                If ListaControles(x).gridlin Is Nothing Then

                    ListaControles(x).enabled = Not Bloqueo

                End If
            End If
        Next

    End Sub

    Public Sub BloquearCamposLineas(ByVal Bloqueo As Boolean, ByVal gr As ClGrid)
        Dim x As Integer
        For x = 0 To ListaControles.Count - 1
            If x > CampoClave Then
                If Not ListaControles(x).gridlin Is Nothing Then
                    If Not ListaControles(x).gridlin Is Nothing Then
                        If CType(ListaControles(x).gridlin, ClGrid) Is gr Then
                            ListaControles(x).enabled = Not Bloqueo
                        End If
                    End If
                End If
            End If

        Next

    End Sub

    Private Sub BGuardar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BGuardar.GotFocus
        BGuardar.BackColor = Color.Yellow
    End Sub

    Private Sub BGuardar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BGuardar.LostFocus
        BGuardar.BackColor = SystemColors.Control
    End Sub

    Private Sub BModificar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BModificar.GotFocus
        BModificar.BackColor = Color.Yellow
    End Sub

    Private Sub BModificar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BModificar.LostFocus
        BModificar.BackColor = SystemColors.Control
    End Sub

    Private Sub BAnular_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BAnular.GotFocus
        BAnular.BackColor = Color.Yellow
    End Sub

    Private Sub BAnular_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BAnular.LostFocus
        BAnular.BackColor = SystemColors.Control
    End Sub

    Private Sub Bsalir_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bsalir.GotFocus
        Bsalir.BackColor = Color.Yellow
    End Sub

    Private Sub Bsalir_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bsalir.LostFocus
        Bsalir.BackColor = SystemColors.Control
    End Sub


    Public Sub AsociarControles(ByRef tx As TxDato, ByRef boconsu As BtBusca, ByVal Origen As BtBusca, ByVal Tabla As Entidad,
                                Optional ByVal Campo As bdcampo = Nothing, Optional ByVal Etiq As Lb = Nothing,
                                Optional TextoToolTip As String = "Búsqueda alfabética")

        If Not boconsu Is Nothing Then

            If Not Origen Is Nothing Then
                boconsu.Image = Origen.Image
                boconsu.CL_CampoOrden = Origen.CL_CampoOrden
                boconsu.CL_DevuelveCampo = Origen.CL_DevuelveCampo
                boconsu.CL_ConsultaSql = Origen.CL_ConsultaSql
                boconsu.cl_formu = Origen.cl_formu
                boconsu.CL_ch1000 = Origen.CL_ch1000
                boconsu.cl_ListaW = Origen.cl_ListaW
                boconsu.CL_BuscaAlb = Origen.CL_BuscaAlb
                boconsu.CL_campocodigo = Origen.CL_campocodigo
                boconsu.CL_camponombre = Origen.CL_camponombre
                boconsu.CL_dfecha = Origen.CL_dfecha
                boconsu.CL_hfecha = Origen.CL_hfecha
                boconsu.CL_ParamBusqueda = Origen.CL_ParamBusqueda
                boconsu.CL_xCentro = Origen.CL_xCentro
                boconsu.CL_EsId = Origen.CL_EsId
                boconsu.CL_Ancho = Origen.CL_Ancho
                boconsu.CL_CONSULTA = Origen.CL_CONSULTA

            End If

            tx.ClParam.BtBusca = boconsu
            tt.SetToolTip(tx.ClParam.BtBusca, TextoToolTip)
            boconsu.CL_ControlAsociado = tx
            boconsu.CL_Entidad = Tabla

        End If


        If Not Campo Is Nothing Then

            tx.ClParam.CampoEnlace = Campo
            tx.ClParam.Entidadenlace = Tabla
            tx.ClParam.LabelEnlace = Etiq

            If Not IsNothing(Etiq) Then
                Etiq.CL_ValorFijo = False
                Etiq.CL_ControlAsociado = tx
            End If

        End If

    End Sub


    Public Sub PropiedadesCamposGr(ByVal grid As ClGrid, ByVal CampoBd As String, Optional ByVal NombreCabecera As String = "", Optional ByVal visible As Boolean = True, Optional ByVal tamaño As Integer = 0, Optional ByVal suma As Boolean = False, Optional ByVal formato As String = "", Optional ByVal FormatoSuma As String = "")
        Dim Propiedades As New Cdatos.PropiedadesCamposGrid
        Propiedades.CampoBd = CampoBd
        Propiedades.NombreCabecera = NombreCabecera
        Propiedades.Visible = visible
        Propiedades.Tamaño = tamaño
        Propiedades.Suma = suma
        Propiedades.Formato = formato
        Propiedades.FormatoSuma = FormatoSuma


        grid.ListaCamposGr.Add(Propiedades)

    End Sub

    Public Sub AsociarGrid(ByVal grid As ClGrid, ByVal Desde As Object, ByVal hasta As Object, ByVal EntidadLineas As Entidad)
        Dim x As Integer
        For x = Desde.orden To hasta.orden
            If TypeOf (ListaControles(x)) Is TxDato Then
                CType(ListaControles(x), TxDato).GridLin = grid
            End If
            If TypeOf (ListaControles(x)) Is CbBox Then
                CType(ListaControles(x), CbBox).GridLin = grid
            End If
            If TypeOf (ListaControles(x)) Is Chk Then
                CType(ListaControles(x), Chk).GridLin = grid
            End If


        Next
        grid.PrimerControl = Desde.orden
        grid.UltimoControl = hasta.orden
        grid.EntidadLinea = EntidadLineas
        grid.GridView.OptionsView.ShowGroupPanel = False
        grid.GridView.OptionsBehavior.Editable = False
        'grid.GridView.OptionsView.ColumnAutoWidth = True
        grid.Formu = Me
    End Sub
    Public Overridable Function Grabalineas(ByVal Grid As ClGrid) As Boolean
        Return GuardarLineas(Grid)
    End Function

    Public Sub Cargalineas(ByVal gr As ClGrid)
        Dim dt As New DataTable
        gr.Cargando = True
        dt = gr.EntidadLinea.MiConexion.ConsultaSQL(gr.Consulta)
        gr.Grid.DataSource = EstableceDatatable(dt, gr)
        'gr.Grid.DataSource = dt
        gr.GridView.AddNewRow()
        gr.Cargando = False
        If gr.Nlinea = -1 Then ' la primera vez se va a la primera
            gr.Nlinea = 0
            PintaColumnas(gr)
            gr.GridView.SelectRow(0) ' a la primera
            gr.GridView.FocusedRowHandle = gr.Nlinea
            Borralin(gr)
            If gr.GridView.RowCount >= 0 Then
                gr.Subirlinea(gr.Nlinea)
            End If
        ElseIf gr.Nlinea = -2 Then ' está añadiendo
            If gr.MismaLinea = False Then
                gr.Nlinea = gr.GridView.RowCount - 1
                gr.GridView.SelectRow(gr.Nlinea) ' a la ultima
                gr.GridView.FocusedRowHandle = gr.Nlinea
                Borralin(gr)

            End If

        Else
            If gr.MismaLinea = False Then
                gr.Nlinea = gr.Nlinea + 1
            End If
            gr.GridView.SelectRow(gr.Nlinea)
            gr.GridView.FocusedRowHandle = gr.Nlinea
        End If
        ' gr.GridView.TopRowIndex = gr.GridView.FocusedRowHandle
        DespuesdeCargarLineas(gr)
    End Sub

    Public Overridable Sub DespuesAnularLinea(ByVal gr As ClGrid)

    End Sub

    Public Overridable Function EstableceDatatable(dt As DataTable, gr As ClGrid) As DataTable

        Return dt

    End Function

    Private Sub PintaColumnas(ByVal Grid As ClGrid)
        Dim columna As New DevExpress.XtraGrid.Columns.GridColumn
        If Not Grid.ListaCamposGr Is Nothing Then
            For Each columna In Grid.GridView.Columns
                columna.Visible = False
                For Each campo As Cdatos.PropiedadesCamposGrid In Grid.ListaCamposGr



                    If columna.FieldName.ToString.ToUpper = campo.CampoBd.ToUpper Then
                        columna.Caption = campo.NombreCabecera
                        columna.Visible = True
                        If campo.Visible = False Then
                            columna.Visible = False
                        End If
                        If campo.Tamaño > 0 Then
                            columna.Width = campo.Tamaño
                        End If
                        If campo.Formato <> "" Then
                            columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
                            columna.DisplayFormat.FormatString = campo.Formato

                        End If
                        If campo.Suma = True Then
                            columna.SummaryItem.FieldName = columna.FieldName
                            columna.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum


                            Grid.GridView.OptionsView.ShowFooter = True
                            Grid.GridView.OptionsView.ShowGroupedColumns = True
                            columna.SummaryItem.DisplayFormat = campo.FormatoSuma
                        End If

                    End If
                Next
            Next
        End If

    End Sub

    Public Overridable Sub init(ByVal Id As String)

        Me.LbId.Text = Id
        Me.Idinit = Id

        If EntidadFrm.LeerId(Id) = True Then
            ControlAlb()
            NuevoRegistro = False
        Else
            If TypeOf (ListaControles(0)) Is TxDato Then
                ListaControles(0).text = Id
            End If
            BloquearCampos(False)
            BloquearClaves(True)
            NuevoRegistro = True
            If CampoClave + 1 <= ListaControles.Count - 1 Then
                ListaControles(CampoClave + 1).select()
            End If
        End If

    End Sub





    'Public Sub AsociarBusca()
    '    For Each BtBusca As BtBusca In Me.Controls
    '        If Not BtBusca.CL_ControlAsociado Is Nothing Then
    '            Try
    '                BtBusca.CL_ControlAsociado.ClParam.BtBusca = BtBusca
    '
    '                Catch ex As Exception
    '    Dim a
    '                    a = ""
    '
    '                End Try
    '            End If
    '        Next
    '   End Sub






    Private Function FiltroBusqueda() As String
        Dim ret As String = ""
        Dim v As String = ""
        Dim NombreCampo As String = ""
        Dim Campo As bdcampo = Nothing
        Dim Tipo As Cdatos.TiposCampo
        Dim Orden As String = ""



        For Each Tx In ListaControles
            v = ""
            If TypeOf (Tx) Is TxDato Then
                If Not CType(Tx, TxDato).ClParam.CampoBd Is Nothing Then
                    If CType(Tx, TxDato).ClParam.CampoBd.MiEntidad.NombreTabla = EntidadFrm.NombreTabla Then
                        v = Tx.text
                        NombreCampo = CType(Tx, TxDato).ClParam.CampoBd.NombreCampo
                        Tipo = CType(Tx, TxDato).ClParam.CampoBd.TipoBd
                        Campo = CType(Tx, TxDato).ClParam.CampoBd
                    End If
                End If

            ElseIf TypeOf (Tx) Is CbBox Then
                If Not CType(Tx, CbBox).Campobd Is Nothing Then

                    If CType(Tx, CbBox).Campobd.MiEntidad.NombreTabla = EntidadFrm.NombreTabla Then
                        If Not CType(Tx, CbBox).SelectedValue Is Nothing Then
                            v = CType(Tx, CbBox).SelectedValue.ToString
                            NombreCampo = CType(Tx, CbBox).Campobd.NombreCampo
                            Tipo = CType(Tx, CbBox).Campobd.TipoBd
                            Campo = CType(Tx, CbBox).Campobd

                        End If

                    End If
                End If
            ElseIf TypeOf (Tx) Is Chk Then
                If Not CType(Tx, Chk).Campobd Is Nothing Then
                    If CType(Tx, Chk).Campobd.MiEntidad.NombreTabla Is EntidadFrm.NombreTabla Then
                        If CType(Tx, Chk).HaCambiado = True Then
                            If CType(Tx, Chk).Checked = True Then
                                v = CType(Tx, Chk).ValorCampoTrue
                            Else
                                v = CType(Tx, Chk).ValorCampoFalse
                            End If
                            NombreCampo = CType(Tx, Chk).Campobd.NombreCampo
                            Tipo = CType(Tx, Chk).Campobd.TipoBd
                            Campo = CType(Tx, Chk).Campobd
                        End If
                    End If
                End If


            End If

            If v <> "" Then
                If ret <> "" Then
                    ret = ret + " AND "

                End If
                ret = ret + NombreCampo + icampo(Campo, v, Tipo)

                If Orden <> "" Then
                    Orden = Orden + ", "
                End If
                Orden = Orden + NombreCampo
            End If
        Next


        Return ret

    End Function

    Private Function icampo(ByVal campo As bdcampo, ByVal Dato As String, ByVal Tipo As Cdatos.TiposCampo) As String
        Dim ret As String = ""
        Select Case Tipo
            Case Cdatos.TiposCampo.Entero, Cdatos.TiposCampo.EnteroPositivo
                If VaInt(Dato) <> 0 Then
                    campo.Valor = Dato
                    ret = " = " + EntidadFrm.ValorCampo(campo)
                End If
            Case Cdatos.TiposCampo.Importe
                If VaDec(Dato) <> 0 Then
                    campo.Valor = Dato
                    ret = " = " + EntidadFrm.ValorCampo(campo)
                End If
            Case Cdatos.TiposCampo.Fecha
                If Dato <> "" Then
                    campo.Valor = Dato
                    ret = " = " + EntidadFrm.ValorCampo(campo)
                End If
            Case TiposCampo.Hora
                If Dato <> "" Then
                    campo.Valor = Dato
                    ret = " = " + EntidadFrm.ValorCampo(campo)
                End If
            Case TiposCampo.FechaHora
                If Dato <> "" Then
                    campo.Valor = Dato
                    ret = " = " + EntidadFrm.ValorCampo(campo)
                End If

            Case Else
                If Dato <> "" Then
                    ret = " LIKE '" + Dato + "%'"

                End If
        End Select
        Return ret
    End Function



    Protected Overridable Sub MuestraCargando(ByVal bMostrarCargando As Boolean)

        'Deshabilita botones
        For Each obj In Me.Controls

            Try
                If Not TypeOf obj Is PanelCargando Then obj.Enabled = False
            Catch ex As Exception

            End Try

        Next

        If bMostrarCargando Then
            _PanelCargando.Visible = True
            _PanelCargando.BringToFront()
        End If


    End Sub


    Protected Overridable Sub OcultaCargando()

        _PanelCargando.Visible = False


        'Habilita botones
        For Each obj In Me.Controls

            Try
                obj.Enabled = True
            Catch ex As Exception

            End Try

        Next

    End Sub



    Private Sub _BackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles _BackgroundWorker.DoWork

        Application.DoEvents()


        Select Case _TipoMantenimiento

            Case TipoMantenimiento.Guardar
                Me.Invoke(New Guardar_Delegate(AddressOf Guardar))

            Case TipoMantenimiento.Anular
                Me.Invoke(New Anular_Delegate(AddressOf Anular))

            Case TipoMantenimiento.Auxiliar1
                Me.Invoke(New BotonAuxiliar1_Delegate(AddressOf BotonAuxiliar1))

            Case TipoMantenimiento.Auxiliar2
                Me.Invoke(New BotonAuxiliar2_Delegate(AddressOf BotonAuxiliar2))

            Case TipoMantenimiento.Auxiliar3
                Me.Invoke(New BotonAuxiliar3_Delegate(AddressOf BotonAuxiliar3))

        End Select


        Application.DoEvents()

    End Sub


    Private Sub _BackgroundWorker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles _BackgroundWorker.RunWorkerCompleted

        OcultaCargando()

        Select Case _TipoMantenimiento

            Case TipoMantenimiento.Anular

                Try
                    BorraPan()
                Catch ex As Exception
                    Dim A As String = ""
                End Try


        End Select


        'If ListaControles.Count > 0 Then ListaControles(0).focus()


        If _TipoMantenimiento = TipoMantenimiento.Guardar Then
            If _AccionCompletadaConExito Then
                If _InicioDespuesDeGuardar Then
                    PosicionarseInicio()
                End If
            Else
                If _OrdenControl > 0 Then
                    ListaControles(_OrdenControl).select()
                    ListaControles(_OrdenControl).focus()
                End If

            End If
        ElseIf _TipoMantenimiento = TipoMantenimiento.Auxiliar1 Then
            If _InicioDespuesDeAuxiliar Then
                PosicionarseInicio()
            End If
        ElseIf _TipoMantenimiento = TipoMantenimiento.Auxiliar2 Then
            If _InicioDespuesDeAuxiliar2 Then
                PosicionarseInicio()
            End If
        ElseIf _TipoMantenimiento = TipoMantenimiento.Auxiliar3 Then
            If _InicioDespuesDeAuxiliar3 Then
                PosicionarseInicio()
            End If
        Else
            PosicionarseInicio()
        End If



        RaiseEvent AccionTerminada(_TipoMantenimiento)

    End Sub


    Public Sub PosicionarseInicio()

        If ListaControles.Count > 0 Then
            If Me.PrimerCampoEdicion > 0 Then
                ListaControles(Me.PrimerCampoEdicion).focus()
            Else
                ListaControles(0).focus()
            End If
        End If

    End Sub


    Public Overridable Sub TeclaFuncion(ByVal Tecla As System.Windows.Forms.Keys, ByVal obj As Object)

        'MsgBox("ha pulsado " + Tecla.ToString + " en " + tx.Name)

        Select Case Tecla

            Case Keys.F9
                'MsgBox("Modificar")
                'BModificar.PerformClick()
                Modificar()

            Case Keys.F10
                'MsgBox("Guardar")
                'BGuardar.PerformClick()
                Guardar()

            Case Keys.F12
                'MsgBox("Salir")
                'Bsalir.PerformClick()
                Salir()


        End Select


    End Sub

    Private Sub BtDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtDoc.Click

        BotonDocumental()

    End Sub


    Protected Overridable Sub BotonDocumental()

        If LbId.Text <> "" Then

            Dim fr As New FrDocs
            fr.Init(_EntidadFrm.NombreBd, _EntidadFrm.NombreTabla, LbId.Text)
            fr.ShowDialog()

            ActualizaBotonGestionDocumental(BtDoc, _EntidadFrm, LbId.Text)

        End If

    End Sub


    Protected Function EstaBloqueado() As Boolean

        Dim ret As Boolean

        If VaInt(LbId.Text) = 0 Then Return False
        If BloqueoUsuarios = 0 Then Return False


        Dim Sql As String



        Sql = "Select BLQ_idusuario as idusuario,BLQ_nombreusuario as nombreusuario from bloqueos where BLQ_entidad='" + EntidadFrm.NombreTabla + "' and BLQ_id='" + LbId.Text + "'"
        Dim dt As DataTable = cn.ConsultaSQL(Sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                If VaInt(dt.Rows(0)(0)) <> Idusuario Then



                    MsgBox("Registro bloqueado por el usuario " + dt.Rows(0)(0).ToString + " " + dt.Rows(0)("nombreusuario"))
                    ret = True
                End If
            End If
        End If

        Return ret

    End Function

    Private Sub BloquearRegistro()
        If VaInt(LbId.Text) = 0 Then Exit Sub
        If BloqueoUsuarios = 0 Then Exit Sub

        Dim sql As String


        sql = "Delete from bloqueos where BLQ_entidad='" + EntidadFrm.NombreTabla + "' and BLQ_id='" + LbId.Text + "'"
        cn.OrdenSql(sql)

        sql = "insert into Bloqueos (BLQ_Entidad,BLQ_id,BLQ_idusuario,BLQ_fecha,BLQ_proceso,BLQ_Nombreusuario)"
        sql = sql + " values ('" + EntidadFrm.NombreTabla + "','" + LbId.Text + "'," + Idusuario.ToString + ",'" + Format(Now, "dd/MM/yyyy hh:mm:ss") + "','" + Me.Text + "','" + NombreUsuario + "')"
        cn.OrdenSql(sql)
        BloqueoGenerado = True

    End Sub

    Protected Sub QuitarBloqueo()
        If VaInt(LbId.Text) = 0 Then Exit Sub
        If BloqueoUsuarios = 0 Then Exit Sub
        If BloqueoGenerado = False Then Exit Sub
        Dim sql As String
        sql = "Delete from bloqueos where BLQ_entidad='" + EntidadFrm.NombreTabla + "' and BLQ_id='" + LbId.Text + "'"
        cn.OrdenSql(sql)


    End Sub

    Protected Overridable Function CumpleFiltro(Mostrar As Boolean, TipoOperacion As String) As Boolean
        If Not EntidadFrm Is Nothing Then
            For Each campo In EntidadFrm.MiListadeCampos
                If FiltroEntidad.ContainsKey(campo.NombreCampo) = True Then
                    If campo.Valor <> FiltroEntidad(campo.NombreCampo) Then
                        If Mostrar = True Then
                            MsgBox("Registro no modificable. " + campo.NombreCampo + " incorrecto ")
                        End If
                        Return False
                    End If
                End If
            Next
            Return True
        Else
            Return True
        End If
    End Function


    Private Sub BtImprimirForm_Click(sender As System.Object, e As System.EventArgs) Handles BtImprimirForm.Click

        ImprimirFormulario()

    End Sub


    Public Overridable Sub ImprimirFormulario()

        If VaInt(LbId.Text) > 0 Then

            If XtraMessageBox.Show("¿Desea imprimir la pantalla del formulario?", "Imprimir formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
                PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 50
                PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 0
                PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 50
                PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 0



                'Dim ps As System.Drawing.Printing.PaperSize
                'For i = 0 To PrintForm1.PrinterSettings.PaperSizes.Count - 1
                '    ps = PrintForm1.PrinterSettings.PaperSizes.Item(i)
                '    If ps.PaperName = "A4" Then
                '        PrintForm1.PrinterSettings.DefaultPageSettings.PaperSize = ps
                '        Exit For
                '    End If
                'Next

                PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeFullWindow)



                'Dim pd As New Printing.PrintDocument()
                'AddHandler pd.PrintPage, AddressOf Me.ImprimeFormulario
                'pd.Print()

            End If

        End If

    End Sub


    'Private Sub ImprimeFormulario(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)

    '    e.Graphics.PageUnit = GraphicsUnit.Pixel

    '    Dim w As Integer = PrintForm1.PrinterSettings.DefaultPageSettings.PaperSize.Width
    '    Dim h As Integer = PrintForm1.PrinterSettings.DefaultPageSettings.PaperSize.Height

    '    Dim bm_source As New Bitmap(Me.Width, Me.Height)
    '    Me.DrawToBitmap(bm_source, New Rectangle(0, 0, Me.Width, Me.Height))


    '    Dim scale_factor As Single = 0.6

    '    ' Get the source bitmap.
    '    'Dim bm_source As New Bitmap(picSource.Image)

    '    ' Make a bitmap for the result.
    '    Dim bm_dest As New Bitmap(CInt(bm_source.Width * scale_factor), CInt(bm_source.Height * scale_factor))

    '    ' Make a Graphics object for the result Bitmap.
    '    Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)

    '    ' Copy the source image into the destination bitmap.
    '    gr_dest.DrawImage(bm_source, 0, 0, _
    '        bm_dest.Width + 1, _
    '        bm_dest.Height + 1)

    '    ' Display the result.
    '    e.Graphics.DrawImage(bm_dest, 0, 0)
    '    'picDest.Image = bm_dest


    '    'Dim imagen_destino As New Bitmap(w, h)


    '    '' Make a Graphics object for the result Bitmap.
    '    ''Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)

    '    'Dim gr_dest As Graphics = Graphics.FromImage(imagen_destino)

    '    '' Copy the source image into the destination bitmap.
    '    'gr_dest.DrawImage(imagen, 0, 0, imagen_destino.Width + 1, imagen_destino.Height + 1)

    '    '' Display the result.
    '    ''picDest.Image = imagen_destino


    '    'e.Graphics.DrawImage(imagen_destino, 0, 0)

    'End Sub




    Private Sub BTTraza_Click(sender As System.Object, e As System.EventArgs) Handles BTTraza.Click
        If LbId.Text <> "" Then
            FrTrazaReg.initClave(EntidadFrm, LbId.Text)
            FrTrazaReg.ShowDialog()
        End If
    End Sub


End Class