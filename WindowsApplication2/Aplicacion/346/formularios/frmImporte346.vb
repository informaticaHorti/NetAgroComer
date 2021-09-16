Imports DevExpress.XtraEditors

Public Class FrmImporte346
    Inherits FrMantenimiento



    Dim Ejercicios As New E_Ejercicios(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim Fichero346 As New E_Fichero346(Idusuario, cn)
    Dim Agricultor As New E_Agricultores(Idusuario, cn)
    Dim Conceptos346 As New E_Conceptos346(Idusuario, cn)





    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub

   

    Private Sub ParametrosFrm()

        EntidadFrm = Ejercicios



        ListaControles = New List(Of Object)

        ParamTx(TxEjercicio, Ejercicios.IdEjercicio, LbEjercicio, True)
        TxEjercicio.Autonumerico = False
        CampoClave = 0 ' ultimo campo de la clave

        ParamTx(TxAgricultor, Fichero346.F46_idagricultor, LbAgricultor, True)
        ParamTx(TxConcepto, Fichero346.F46_idconcepto, LbConcepto, True)
        ParamTx(TxImporte, Fichero346.F46_Importe, LbImporte, True)


        AsociarGrid(ClGrid1, TxAgricultor, TxImporte, Fichero346)
        PropiedadesCamposGr(ClGrid1, "F46_id", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 100)
        PropiedadesCamposGr(ClGrid1, "Agricultor", "Agricultor", True, 250)
        PropiedadesCamposGr(ClGrid1, "Nif", "Nif", True, 150)
        PropiedadesCamposGr(ClGrid1, "Importe", "Importe", True, 200, True)


        AsociarControles(TxEjercicio, BtEjercicio, Ejercicios.btBusca, Ejercicios)
        AsociarControles(TxAgricultor, BtAgricultor, Agricultor.btBusca, Agricultor, Agricultor.AGR_Nombre, LbNomAgricultor)
        AsociarControles(TxConcepto, BtConcepto, Conceptos346.btBusca, Conceptos346, Conceptos346.C46_nombre, LbNomConcepto)

        BAnular.Visible = False
    End Sub


    Private Sub FrmBascula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BAnular.Visible = False
    End Sub



    Public Overrides Sub ControlClave()

        ' componemos la clave
        If Ejercicios.LeerId(TxEjercicio.Text) Then

            LbId.Text = TxEjercicio.Text
            CargaLineasGrid()

        Else
            MsgBox("El ejercicio no existe")
            TxEjercicio.Select()
            TxEjercicio.Focus()
        End If
        

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

    End Sub



    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean

        'asociar cabecera con lineas
        Fichero346.F46_ejercicio.Valor = LbId.Text
        Fichero346.F46_idempresa.Valor = MiMaletin.IdEmpresaCTB.ToString
        SqlGrid()

        Dim r As Boolean = MyBase.GuardarLineas(Gr)
        Return r

    End Function


    Private Sub CargaLineasGrid()

        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)

    End Sub


    Private Sub SqlGrid()


        Dim Id As String = LbId.Text

        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim CONSULTA As New Cdatos.E_select
       
        CONSULTA.SelCampo(Fichero346.F46_id, "F46_id")
        CONSULTA.SelCampo(Fichero346.F46_idagricultor, "Codigo")
        CONSULTA.SelCampo(Agricultor.AGR_Nombre, "Agricultor", Fichero346.F46_idagricultor)
        CONSULTA.SelCampo(Agricultor.AGR_Nif, "Nif")
        CONSULTA.SelCampo(Fichero346.F46_Importe, "Importe")
        CONSULTA.WheCampo(Fichero346.F46_ejercicio, "=", Id)
        CONSULTA.WheCampo(Fichero346.F46_idempresa, "=", MiMaletin.IdEmpresaCTB)
        

        Dim sql As String = CONSULTA.SQL & vbCrLf & " ORDER BY F46_IdAgricultor"
        ClGrid1.Consulta = sql

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub


    Public Overrides Sub Guardar()
        MyBase.Guardar()

    End Sub




End Class