Public Class BotonesAvance
    Dim _Entidad As Cdatos.Entidad
    Public Property Mientidad As Cdatos.Entidad
        Set(ByVal value As Cdatos.Entidad)
            _Entidad = value

        End Set
        Get
            Return _Entidad
        End Get
    End Property

    Dim _Udato As String
    Public Property Udato As String
        Set(ByVal value As String)
            _Udato = value

        End Set
        Get
            Return _Udato
        End Get
    End Property
    Dim _Filtro As String
    Public Property Filtro As String
        Set(ByVal value As String)
            _Filtro = value

        End Set
        Get
            Return _Filtro
        End Get
    End Property


    Dim _Formulario As FrMantenimiento
    Public Property Formulario As FrMantenimiento
        Set(ByVal value As FrMantenimiento)
            _Formulario = value
            If Not value Is Nothing Then
                Formulario.BtAvance = Me
            End If

        End Set
        Get
            Return _Formulario
        End Get
    End Property

    Dim _CampoOrden As Cdatos.bdcampo

    Public Property CampoOrden As Cdatos.bdcampo
        Set(ByVal value As Cdatos.bdcampo)
            _CampoOrden = value

        End Set
        Get
            Return _CampoOrden
        End Get
    End Property

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' primero

        Dim sql As String
        Dim dt As New DataTable
        Dim id As String
        Dim Fi As String = ""

        If Formulario.Buscando = True Then
            Exit Sub

        End If

        If Not Formulario.Registros Is Nothing Then
            If Formulario.Registros.Rows.Count > 0 Then
                id = Formulario.Registros.Rows(0)(0).ToString
                Formulario.Idregistro = 1
                Conectar(id)
            End If
            Exit Sub
        End If


        If Filtro <> "" Then
            Fi = " where " + Filtro
        End If
        If Not Mientidad.ClavePrimaria Is Nothing Then
            sql = "Select " + Mientidad.ClavePrimaria.NombreCampo + " from " + Mientidad.NombreTabla + " " + Fi + " order by " + CampoOrden.NombreCampo
            dt = Mientidad.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    id = dt.Rows(0)(0).ToString

                    Conectar(id)
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'siguiente


        Dim sql As String
        Dim dt As New DataTable
        Dim id As String
        Dim fi As String = ""

        If Formulario.Buscando = True Then
            Exit Sub

        End If

        If Not Formulario.Registros Is Nothing Then
            If Formulario.Idregistro < Formulario.Registros.Rows.Count Then
                Formulario.Idregistro = Formulario.Idregistro + 1
                id = Formulario.Registros.Rows(Formulario.Idregistro - 1)(0).ToString
                Conectar(id)
            End If
            Exit Sub
        End If

        'Udato = Mientidad.ValorCampo(CampoOrden)
        Udato = Formulario.UltimaClave
        If Udato <> "" Then
            fi = " where " + CampoOrden.NombreCampo + " > " + Udato
        End If
        If Filtro <> "" Then
            If fi <> "" Then
                fi = fi + " and " + Filtro
            Else
                fi = " where " + Filtro
            End If
        End If

        If Not Mientidad.ClavePrimaria Is Nothing Then
            sql = "Select " + Mientidad.ClavePrimaria.NombreCampo + " from " + Mientidad.NombreTabla + " " + fi + " order by " + CampoOrden.NombreCampo
            dt = Mientidad.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    id = dt.Rows(0)(0).ToString

                    Conectar(id)
                End If
            End If
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ' anterior

        Dim sql As String
        Dim dt As New DataTable
        Dim id As String
        Dim fi As String = ""

        If Formulario.Buscando = True Then
            Exit Sub

        End If

        If Not Formulario.Registros Is Nothing Then
            If Formulario.Idregistro > 1 Then
                Formulario.Idregistro = Formulario.Idregistro - 1
                id = Formulario.Registros.Rows(Formulario.Idregistro - 1)(0).ToString
                Conectar(id)
            End If
            Exit Sub
        End If

        ' Udato = Mientidad.ValorCampo(CampoOrden)
        Udato = Formulario.UltimaClave

        If Udato <> "" Then
            fi = " where " + CampoOrden.NombreCampo + " < " + Udato
        End If
        If Filtro <> "" Then
            If fi <> "" Then
                fi = fi + " and " + Filtro
            Else
                fi = " where " + Filtro
            End If
        End If

        If Not Mientidad.ClavePrimaria Is Nothing Then
            sql = "Select " + Mientidad.ClavePrimaria.NombreCampo + " from " + Mientidad.NombreTabla + " " + fi + " order by " + CampoOrden.NombreCampo + " desc"
            dt = Mientidad.MiConexion.ConsultaSQL(sql)
            If dt.Rows.Count > 0 Then
                id = dt.Rows(0)(0).ToString

                Conectar(id)
            End If
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        ' ultimo

        Dim sql As String
        Dim dt As New DataTable
        Dim id As String
        Dim Fi As String = ""

        If Formulario.Buscando = True Then
            Exit Sub

        End If


        If Not Formulario.Registros Is Nothing Then
            If Formulario.Registros.Rows.Count > 0 Then
                id = Formulario.Registros.Rows(Formulario.Registros.Rows.Count - 1)(0).ToString
                Formulario.Idregistro = Formulario.Registros.Rows.Count
                Conectar(id)
            End If
            Exit Sub
        End If


        If Filtro <> "" Then
            Fi = " where " + Filtro
        End If
        If Not Mientidad.ClavePrimaria Is Nothing Then
            sql = "Select " + Mientidad.ClavePrimaria.NombreCampo + " from " + Mientidad.NombreTabla + " " + Fi + " order by " + CampoOrden.NombreCampo + " desc"
            dt = Mientidad.MiConexion.ConsultaSQL(sql)
            If dt.Rows.Count > 0 Then
                id = dt.Rows(0)(0).ToString
                Conectar(id)
            End If
        End If
    End Sub

    Private Sub Conectar(ByVal id As String)
        If Mientidad.LeerId(id) = True Then
            Dim FRm As New FrMantenimiento
            FRm = Formulario

            FRm.BorraPan()
            FRm.LbId.Text = id
            FRm.ControlAlb()
        End If

    End Sub

    Private Sub BotonesAvance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Chfiltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chfiltro.CheckedChanged


    End Sub

    Private Sub Chfiltro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chfiltro.Click
        Formulario.Idregistro = 0
        Formulario.Registros = Nothing
        Formulario.Buscando = False
        Chfiltro.Visible = False
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.Width = Button1.Width + Button2.Width + Button3.Width + Button4.Width + Chfiltro.Width + 25
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
End Class
