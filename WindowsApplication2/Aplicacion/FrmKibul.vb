Public Class FrmKiBul
    Inherits FrMantenimiento


    Private Sub FrmKiBul_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BModificar.Visible = False
        BAnular.Visible = False
        ' PanelId.Visible = False


    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()
    End Sub

    Private Sub ParametrosFrm()
        EntidadFrm = Nothing


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato16, Nothing, Lb34, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxDato17, Nothing, Lb34, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxDato19, Nothing, Lb35, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxDato18, Nothing, Lb35, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxDato21, Nothing, Lb36, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxDato20, Nothing, Lb36, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxDato23, Nothing, Lb37, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxDato22, Nothing, Lb37, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxDato25, Nothing, Lb38, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxDato24, Nothing, Lb38, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxDato27, Nothing, Lb39, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxDato26, Nothing, Lb39, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxDato29, Nothing, Lb40, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxDato28, Nothing, Lb40, False, Cdatos.TiposCampo.Importe, 2, 6)
        ParamTx(TxDato31, Nothing, Lb41, False, Cdatos.TiposCampo.Entero, 0, 4)
        ParamTx(TxDato30, Nothing, Lb41, False, Cdatos.TiposCampo.Importe, 2, 6)

        CampoClave = 100


    End Sub
End Class