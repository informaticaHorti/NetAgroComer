Public Class FrmConsultaSql

    Inherits FrMantenimiento
    Dim ConsultasSql As New E_ConsultasSql(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = ConsultasSql


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, ConsultasSql.SQL_Id, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        TxDato1.Autonumerico = True
        ParamTx(TxDato2, ConsultasSql.SQL_Nombre, Lb2)
        ParamTx(TxDato3, ConsultasSql.SQL_Consulta, Lb3)

        AsociarControles(TxDato1, BtBuscaMarca, ConsultasSql.btBusca, EntidadFrm)



        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub
    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text


    End Sub
    Public Overrides Sub Guardar()
        MyBase.Guardar()
    End Sub




    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub

    Private Sub TxDato3_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato3.KeyDown

    End Sub



    Private Sub TxDato3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato3.TextChanged

    End Sub
End Class