Public Class FrmContactos
    Inherits FrMantenimiento

    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Contactos As New E_Contactos(Idusuario, cn)

    Dim err As New Errores()


    Private _fichero As String = ""
    Private _idfichero As String = ""
    Private _departamento As String = ""




    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)


        Dim lc As New List(Of Object)
        ListaControles = lc

        InicioFrm()

        BAnular.Visible = False
        Button1.Visible = False


    End Sub


    Public Sub New(Fichero As String, Idfichero As String)

        Me.New()
        _fichero = Fichero
        _idfichero = Idfichero
        _departamento = "A"
        Lb0.Text = Fichero


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub



    Private Sub ParametrosFrm()


        ClGrid1.GridView.Appearance.Row.ForeColor = Color.Black

        If _fichero.ToLower = "cliente" Then
            EntidadFrm = Clientes
            ParamTx(TxDato0, Clientes.CLI_Codigo, Lb0, True)
        ElseIf _fichero.ToLower = "proveedor" Then
            EntidadFrm = Agricultores
            ParamTx(TxDato0, Agricultores.AGR_IdAgricultor, Lb0, True)
        Else
            err.Muestraerror("Error en el tipo de contacto", "FrmContactos.ParametrosFrm", "Tipo de contacto desconocido")
        End If





        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato3, Contactos.COT_Contacto, Lb3)
        ParamTx(TxDato1, Contactos.COT_cargo, Lb1)
        ParamTx(TxDato4, Contactos.COT_Telefono, Lb4)
        ParamTx(TxDato5, Contactos.COT_Movil, Lb5)
        ParamTx(TxDato6, Contactos.COT_Fax, Lb6)
        ParamTx(TxDato7, Contactos.COT_Mail, Lb7)
        ParamTx(TxDato8, Contactos.COT_claveemail, Lb8)
        ParamTx(TxDato9, Contactos.COT_Observaciones1, Lb9)
        ParamTx(TxDato10, Contactos.COT_Observaciones2)


        AsociarGrid(ClGrid1, TxDato3, TxDato10, Contactos)

        PropiedadesCamposGr(ClGrid1, "COT_Id", "", False, 0)
        PropiedadesCamposGr(ClGrid1, "Contacto", "Contacto", True, 150)
        PropiedadesCamposGr(clgrid1, "Cargo", "Cargo", True, 80)
        PropiedadesCamposGr(clgrid1, "Telefono", "Telefono", True, 80)
        PropiedadesCamposGr(ClGrid1, "Movil", "Movil", True, 80)




    End Sub


    Public Overrides Sub ControlClave()

        ' componemos la clave
        'LbId.Text = TxDato1.Text



    End Sub


    Public Overrides Sub Guardar()


        Contactos.COT_fichero.Valor = _fichero
        Contactos.COT_idfichero.Valor = _idfichero
        Contactos.COT_departamento.Valor = _departamento
        MyBase.Guardar()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
    End Sub


    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()

        CargaLineasGrid()

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas

        Contactos.COT_fichero.Valor = _fichero
        Contactos.COT_idfichero.Valor = _idfichero
        Contactos.COT_departamento.Valor = _departamento

        CargaLineasGrid(False)

        Return MyBase.GuardarLineas(Gr)

    End Function



    Private Sub FrmContactos_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        Try

            If _idfichero.Trim <> "" Then

                TxDato0.Text = _idfichero
                TxDato0.Validar(True)

                Siguiente(TxDato0.Orden)

                clgrid1.Grid.Select()
                clgrid1.Grid.Focus()

            End If

        Catch ex As Exception
            err.Muestraerror("Error al cargar el " & _fichero.ToString & " con id " & _idfichero, "FrmContactos_Load", ex.Message)
        End Try



    End Sub


    Private Sub CargaLineasGrid(Optional bCargar As Boolean = True)
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim sql As String = "Select COT_Id , COT_Contacto as Contacto,COT_cargo as Cargo, COT_Telefono as Telefono, COT_Movil as Movil,"
        sql = sql & " COT_Fax as Fax, COT_Mail as Mail, COT_Observaciones1 as Observaciones1, COT_Observaciones2 as Observaciones2"
        sql = sql & " from contactos " & vbCrLf
        sql = sql & " " & vbCrLf
        sql = sql & " where COT_fichero = '" & _fichero & "' and COT_idfichero='" + _idfichero + "' and COT_departamento='" + _departamento + "'  order by COT_id"

        ClGrid1.Consulta = sql

        If bCargar Then
            ClGrid1.Nlinea = -1
            Cargalineas(ClGrid1)
        End If

        Badmon.BackColor = Color.Gray
        Bcomercial.BackColor = Color.Gray
        BLogistica.BackColor = Color.Gray
        Botros.BackColor = Color.Gray
        Select Case _departamento
            Case "A"
                Badmon.BackColor = Color.Yellow
            Case "C"
                Bcomercial.BackColor = Color.Yellow
            Case "L"
                BLogistica.BackColor = Color.Yellow
            Case "O"
                Botros.BackColor = Color.Yellow
        End Select

    End Sub


    Private Sub TxDato0_Valida(edicion As System.Boolean) Handles TxDato0.Valida

        If _fichero.ToLower = "cliente" Then
            If Clientes.LeerId(TxDato0.Text) Then
                Lb_0.Text = Clientes.CLI_Nombre.Valor
            Else
                TxDato0.MiError = True
            End If
        ElseIf _fichero.ToLower = "proveedor" Then
            If Agricultores.LeerId(TxDato0.Text) Then
                Lb_0.Text = Agricultores.AGR_Nombre.Valor
            Else
                TxDato0.MiError = True
            End If
        End If



    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Badmon.Click
        _departamento = "A"
        CargaLineasGrid(True)
    End Sub

    Private Sub ClButton1_Click(sender As System.Object, e As System.EventArgs) Handles Bcomercial.Click
        _departamento = "C"
        CargaLineasGrid(True)

    End Sub

    Private Sub ClButton2_Click(sender As System.Object, e As System.EventArgs) Handles BLogistica.Click
        _departamento = "L"
        CargaLineasGrid(True)

    End Sub

    Private Sub ClButton3_Click(sender As System.Object, e As System.EventArgs) Handles Botros.Click
        _departamento = "O"
        CargaLineasGrid(True)

    End Sub
End Class