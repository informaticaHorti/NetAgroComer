Imports System.ComponentModel

Public Structure CL_CONSULTA

    Public E_Select As Cdatos.E_select
    Public OrderBy As String
    Public Campo_Codigo As Cdatos.bdcampo
    Public Campo_Fecha As Cdatos.bdcampo
    Public Campo_Centro As Cdatos.bdcampo
    Public Campo_IdEmpresa As Cdatos.bdcampo


End Structure


Public Class BtBusca
    Inherits Button

    Dim _ControlAsociado As TxDato
    Public Event AntesdeEnlazar()


    Private _DcParametros As New Dictionary(Of String, Parametros)


    Private _CONSULTA As CL_CONSULTA = Nothing
    Public Property CL_CONSULTA As CL_CONSULTA
        Get
            Return _CONSULTA
        End Get
        Set(value As CL_CONSULTA)
            _CONSULTA = value
        End Set
    End Property




    <Browsable(True), EditorBrowsable(EditorBrowsableState.Always), Category("Data"), Description("Diccionario de Parametros"),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property CL_ParamBusqueda As Dictionary(Of String, Parametros)
        Get
            Return _DcParametros
        End Get
        Set(value As Dictionary(Of String, Parametros))
            _DcParametros = value
        End Set
    End Property



    Public Property CL_ControlAsociado As TxDato
        Set(ByVal value As TxDato)
            _ControlAsociado = value

        End Set
        Get
            Return _ControlAsociado

        End Get
    End Property

    Dim _ConsultaSql As String
    Public Property CL_ConsultaSql As String
        Set(ByVal value As String)
            _ConsultaSql = value

        End Set
        Get
            Return _ConsultaSql

        End Get
    End Property

    Dim _Filtro As String
    Public Property CL_Filtro As String
        Set(ByVal value As String)
            _Filtro = value

        End Set
        Get
            Return _Filtro

        End Get
    End Property

    Dim _ch1000 As Boolean
    Public Property CL_ch1000 As Boolean
        Set(ByVal value As Boolean)
            _ch1000 = value

        End Set
        Get
            Return _ch1000

        End Get
    End Property
    Dim _clBuscaAlb As Boolean
    Public Property CL_BuscaAlb As Boolean
        Set(ByVal value As Boolean)
            _clBuscaAlb = value

        End Set
        Get
            Return _clBuscaAlb

        End Get
    End Property

    Dim _clEsId As Boolean = True
    Public Property CL_EsId As Boolean
        Set(ByVal value As Boolean)
            _clEsId = value

        End Set
        Get
            Return _clEsId

        End Get
    End Property

    Dim _clxcentro As Boolean = False
    Public Property CL_xCentro As Boolean
        Set(ByVal value As Boolean)
            _clxcentro = value

        End Set
        Get
            Return _clxcentro

        End Get
    End Property

    Dim _clAncho As Integer
    Public Property CL_Ancho As Integer
        Set(ByVal value As Integer)
            _clAncho = value

        End Set
        Get
            Return _clAncho

        End Get
    End Property


    Dim _CampoOrden As String
    Public Property CL_CampoOrden As String
        Set(ByVal value As String)
            _CampoOrden = value

        End Set
        Get
            Return _CampoOrden

        End Get
    End Property

    Dim _DevuelveCampo As String
    Public Property CL_DevuelveCampo As String
        Set(ByVal value As String)
            _DevuelveCampo = value

        End Set
        Get
            Return _DevuelveCampo

        End Get
    End Property

    Dim _Entidad As Cdatos.Entidad
    Public Property CL_Entidad As Cdatos.Entidad
        Set(ByVal value As Cdatos.Entidad)
            _Entidad = value

        End Set
        Get
            Return _Entidad

        End Get
    End Property

    Private _Formu As String
    Public Property cl_formu As String
        Set(ByVal value As String)
            _Formu = value

        End Set
        Get
            Return _Formu

        End Get
    End Property


    'Private _Formulario As FrMantenimiento
    'Public Property CL_Formulario As FrMantenimiento
    '    Set(ByVal value As FrMantenimiento)
    '        _Formulario = value

    '    End Set
    '    Get
    '        Return _Formulario

    '    End Get
    'End Property

    Private _ListaW As List(Of Integer)
    Public Property cl_ListaW As List(Of Integer)

        Set(ByVal value As List(Of Integer))
            _ListaW = value

        End Set
        Get
            Return _ListaW

        End Get
    End Property

    Private _cl_campocodigo As Cdatos.bdcampo
    Public Property CL_campocodigo As Cdatos.bdcampo
        Set(ByVal value As Cdatos.bdcampo)
            _cl_campocodigo = value

        End Set
        Get
            Return _cl_campocodigo

        End Get
    End Property

    Private _cl_camponombre As Cdatos.bdcampo
    Public Property CL_camponombre As Cdatos.bdcampo
        Set(ByVal value As Cdatos.bdcampo)
            _cl_camponombre = value

        End Set
        Get
            Return _cl_camponombre

        End Get
    End Property

    Dim _dfecha As String
    Public Property CL_dfecha As String
        Set(ByVal value As String)
            _dfecha = value

        End Set
        Get
            Return _dfecha

        End Get
    End Property

    Dim _hfecha As String
    Public Property CL_hfecha As String
        Set(ByVal value As String)
            _hfecha = value

        End Set
        Get
            Return _hfecha

        End Get
    End Property



    Public Sub ParamConsultaAlb(E_Select As Cdatos.E_select, OrderBy As String, Campo_Codigo As Cdatos.bdcampo,
                             Campo_Fecha As Cdatos.bdcampo, Campo_Centro As Cdatos.bdcampo, Optional Campo_idempresa As Cdatos.bdcampo = Nothing)

        Dim CL_Consulta As New CL_CONSULTA
        CL_Consulta.E_Select = E_Select
        If (OrderBy & "").Trim <> "" Then CL_Consulta.OrderBy = " ORDER BY " & OrderBy
        CL_Consulta.Campo_Codigo = Campo_Codigo
        CL_Consulta.Campo_Fecha = Campo_Fecha
        CL_Consulta.Campo_Centro = Campo_Centro
        If Not Campo_idempresa Is Nothing Then
            CL_Consulta.Campo_IdEmpresa = Campo_idempresa
        End If
        Me.CL_CONSULTA = CL_Consulta

    End Sub


    Public Function TieneConsulta() As Boolean

        Dim bRes As Boolean = False

        If Not IsNothing(Me.CL_CONSULTA) Then
            If Not IsNothing(Me.CL_CONSULTA.E_Select) Then
                bRes = True
            End If
        End If


        Return bRes

    End Function



    ''' <summary>
    ''' Establece la forma en que se verán los campos en las columnas. 
    ''' </summary>
    ''' <param name="Campo">Nombre de la columna: distingue entre mayúsculas y minúsculas.</param>
    ''' <param name="Cabecera">Nombre que se mostrará en la cabecera de la columna. Si se deja en blanco, será el mismo valor que en Campo.</param>
    ''' <param name="Longitud">Ancho de la columna. Si se establece en 0, calculará el ancho automáticamente, si se establece en -1, la columna será invisible.</param>
    ''' <param name="EsResumen">True si se trata de un campo numérico del cual queremos que se muestre un total de la columna.</param>
    ''' <param name="Formato">Formato de la columna (sólo para columnas numéricas)</param>
    ''' <remarks></remarks>
    Public Sub Params(Campo As String, Optional Cabecera As String = "", Optional Longitud As Integer = 0,
                      Optional EsResumen As Boolean = False, Optional Formato As String = "",
                      Optional DcCondiciones As Dictionary(Of Object, Color) = Nothing)

        If Cabecera.Trim = "" Then Cabecera = Campo

        Dim param As New Parametros(Cabecera, EsResumen, Formato, Longitud, DcCondiciones)
        _DcParametros(Campo) = param

    End Sub


    Public Function Enlazar() As String
        RaiseEvent AntesdeEnlazar()
        Dim Sql As String
        Dim dt As New DataTable
        Dim v As String = ""
        Dim FRb As New FrBuscar
        Dim FrA As New FrBuscaAlb



        'If CL_ConsultaSql Is Nothing Then MsgBox("No existe consulta") : Return ""
        If CL_ConsultaSql Is Nothing And IsNothing(CL_CONSULTA) Then MsgBox("No existe consulta") : Return ""
		If CL_Entidad Is Nothing Then MsgBox("No existe consulta") : Return ""

        Select Case CL_BuscaAlb
            Case False

                If CL_Entidad.NombreTabla.ToUpper = "CUENTAS" And (CL_ControlAsociado.ClParam.Tipo = Cdatos.TiposCampo.Cuenta Or CL_ControlAsociado.ClParam.Tipo = Cdatos.TiposCampo.CuentaCliente) Then
                    CL_Filtro = "NUMEROCUENTA LIKE '" & CL_ControlAsociado.Text & "%'"
                End If

                Sql = CL_ConsultaSql
                dt = CL_Entidad.MiConexion.ConsultaSQL(Sql)

                'FRb.InitCol(cl_ListaW)
                FRb.InitCol(_DcParametros, _clAncho)
                FRb.InitDta(dt, CL_CampoOrden, CL_Filtro, CL_ch1000)
                FRb.ShowDialog()
                If Not BuscarRow Is Nothing Then

                    v = BuscarRow(CL_DevuelveCampo)
                End If
                Return v

            Case Else

                Sql = CL_ConsultaSql
                FrA.InitCodigo(Sql, CL_Entidad, CL_campocodigo, CL_camponombre, CL_dfecha, CL_hfecha, CL_ParamBusqueda, Me)
                FrA.InitFiltro(CL_Filtro)
                FrA.InitCentro(CL_xCentro)
                FrA.ShowDialog()
                If Not BuscarRow Is Nothing Then
                    Try
                        v = BuscarRow(CL_DevuelveCampo).ToString

                    Catch ex As Exception
                        v = ""
                    End Try

                End If
                Return v
        End Select

        ' BtBuscaCliente.CL_Filtro = "NUMEROCUENTA LIKE '" & TxDato3.Text & "%'"

    End Function


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


    Private Sub BtBusca_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Select Case e.Button
            Case System.Windows.Forms.MouseButtons.Left
                Dim v As String
                '        v = Busquedafrm(Me.Name)
                v = Enlazar()
                If v <> "" Then
                    Select Case CL_BuscaAlb
                        Case False
                            If Not CL_ControlAsociado Is Nothing Then
                                If CL_ControlAsociado.Enabled = True And CL_ControlAsociado.Visible = True Then
                                    CL_ControlAsociado.Text = v
                                    CL_ControlAsociado.Validar(True)
                                    If CL_ControlAsociado.MiError = False Then
                                        CL_ControlAsociado.ClForm.Siguiente(CL_ControlAsociado.Orden)
                                    End If
                                End If
                            End If

                        Case True

                            If Not CL_ControlAsociado Is Nothing Then
                                If Not CL_ControlAsociado.ClForm Is Nothing Then


                                    Select Case CType(CL_ControlAsociado.ClForm.tipofrm, Cdatos.ETipoFrm)
                                        Case Cdatos.ETipoFrm.Mantenimiento
                                            If _clEsId = True Then
                                                CType(CL_ControlAsociado.ClForm, FrMantenimiento).LbId.Text = v
                                                CType(CL_ControlAsociado.ClForm, FrMantenimiento).ControlAlb()
                                            Else
                                                If CL_ControlAsociado.Enabled = True And CL_ControlAsociado.Visible = True Then
                                                    CL_ControlAsociado.Text = v
                                                    CL_ControlAsociado.Validar(True)
                                                    If CL_ControlAsociado.MiError = False Then
                                                        CL_ControlAsociado.ClForm.Siguiente(CL_ControlAsociado.Orden)
                                                    End If
                                                End If

                                            End If

                                        Case Cdatos.ETipoFrm.Consulta
                                            If CL_ControlAsociado.Enabled = True And CL_ControlAsociado.Visible = True Then
                                                CL_ControlAsociado.Text = v
                                                CL_ControlAsociado.Validar(True)
                                                If CL_ControlAsociado.MiError = False Then
                                                    CL_ControlAsociado.ClForm.Siguiente(CL_ControlAsociado.Orden)
                                                End If
                                            End If


                                    End Select
                                End If
                            End If
                    End Select


                End If


            Case System.Windows.Forms.MouseButtons.Right
                Dim fr As Boolean = False
                If Not cl_formu Is Nothing Then
                    If Not CL_ControlAsociado Is Nothing Then
                        If Not CL_ControlAsociado.ClForm Is Nothing Then
                            If CL_ControlAsociado.ClForm.Name <> cl_formu Then
                                Dim d As String
                                d = CL_ControlAsociado.Text


                                Dim asm As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly
                                Try
                                    'Dim tipos As Type() = asm.GetTypes()
                                    Dim tipo As Type = asm.GetType(asm.GetName().Name & "." & cl_formu)
                                    Dim f As FrMantenimiento = DirectCast(Activator.CreateInstance(tipo), FrMantenimiento)
                                    f.init(d)
                                    f.ShowDialog()

                                    fr = True
                                Catch ex As Exception

                                End Try

                                'cl_formu.init(d)
                                'cl_formu.ShowDialog()

                            End If
                        End If
                    End If
                End If
                If fr = False Then
                    MsgBox("no se pudo enlazar con el formulario")
                End If
        End Select
    End Sub

End Class
