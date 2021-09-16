Public Class FrmValoresEjercicio
    Inherits FrMantenimiento


    Dim ValoresEjercicio As New E_ValoresEjercicio(Idusuario, cn)
    Dim Ejercicios As New E_Ejercicios(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Private Sub ParametrosFrm()
        EntidadFrm = ValoresEjercicio


        ListaControles = New List(Of Object)

        ParamTx(TxDato1, ValoresEjercicio.VEJ_IdEjercicio, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamCb_Copia(CbTipoConexionTecnicos, ValoresEjercicio.VEJ_TipoConexion, LbTipoConexionTecnicos, Combos.ComboTipoConexionTecnicos)
        ParamChk(ChkBloquear, ValoresEjercicio.VEJ_Bloqueada, "S", "N")


        AsociarControles(TxDato1, BtBuscaFRM, Ejercicios.btBusca, Ejercicios, Ejercicios.Nombre, LbNomUsu)


        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me

    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text
    End Sub


    Private Sub FrmValorespventa_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(0)

    End Sub


    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()

    End Sub


    Protected Overrides Sub Datos_a_Entidad()
        MyBase.Datos_a_Entidad()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub


   
    Private Sub CbTipoConexionTecnicos_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbTipoConexionTecnicos.KeyDown
        If e.KeyCode = Keys.Enter Then
            ChkBloquear.Select()
            ChkBloquear.Focus()
            'BGuardar.Select()
            'BGuardar.Focus()
        End If
    End Sub
End Class