
Public Class BtBusca
    Inherits Button
    Dim _ControlAsociado As TxDato
    Public Event AntesdeEnlazar()

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

    Private _Formu As FrMantenimiento
    Public Property cl_formu As FrMantenimiento
        Set(ByVal value As FrMantenimiento)
            _Formu = value

        End Set
        Get
            Return _Formu

        End Get
    End Property

    Private _ListaW As List(Of Integer)
    Public Property cl_ListaW As List(Of Integer)

        Set(ByVal value As List(Of Integer))
            _listaw = value

        End Set
        Get
            Return _ListaW

        End Get
    End Property



    Public Function Enlazar() As String
        RaiseEvent AntesdeEnlazar()
        Dim Sql As String
        Dim dt As New DataTable
        Dim v As String = ""
        Dim FRb As New FrBuscar

        ' BtBuscaCliente.CL_Filtro = "NUMEROCUENTA LIKE '" & TxDato3.Text & "%'"

        If CL_Entidad.NombreTabla.ToUpper = "CUENTAS" And (CL_ControlAsociado.ClParam.Tipo = Cdatos.TiposCampo.Cuenta Or CL_ControlAsociado.ClParam.Tipo = Cdatos.TiposCampo.CuentaCliente) Then
            CL_Filtro = "NUMEROCUENTA LIKE '" & CL_ControlAsociado.Text & "%'"
        End If

        Sql = CL_ConsultaSql
        dt = CL_Entidad.MiConexion.ConsultaSQL(Sql)

        FRb.InitCol(cl_ListaW)
        FRb.InitDta(dt, CL_CampoOrden, CL_Filtro, CL_ch1000)
        FRb.ShowDialog()
        If Not BuscarRow Is Nothing Then
            v = BuscarRow(CL_DevuelveCampo)
        End If
        Return v
    End Function

    Private Sub BtBusca_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Select Case e.Button
            Case System.Windows.Forms.MouseButtons.Left
                Dim v As String
                '        v = Busquedafrm(Me.Name)
                v = Enlazar()
                If v <> "" Then
                    If Not CL_ControlAsociado Is Nothing Then
                        If CL_ControlAsociado.Enabled = True And CL_ControlAsociado.Visible = True Then
                            CL_ControlAsociado.Text = v
                            CL_ControlAsociado.Validar(True)
                            If CL_ControlAsociado.MiError = False Then
                                CL_ControlAsociado.ClForm.Siguiente(CL_ControlAsociado.Orden)
                            End If
                        End If
                    End If
                End If


            Case System.Windows.Forms.MouseButtons.Right

                If Not cl_formu Is Nothing Then
                    If Not CL_ControlAsociado Is Nothing Then
                        If Not CL_ControlAsociado.ClForm Is Nothing Then
                            If CL_ControlAsociado.ClForm.Name <> cl_formu.Name Then
                                Dim d As String
                                d = CL_ControlAsociado.Text




                                cl_formu.init(d)
                                cl_formu.ShowDialog()
                            End If
                        End If
                    End If
                End If
        End Select
    End Sub

End Class
