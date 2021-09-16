Imports DevExpress.XtraEditors

Public Class FrmPreviones
    Inherits FrMantenimiento



    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Agriculores As New E_Agricultores(Idusuario, cn)
    Dim Previsiones As New E_Previsiones(Idusuario, cn)
    Dim Previsiones_lineas As New E_Previsiones_lineas(Idusuario, cn)
    Dim Fincas As New E_Fincas(Idusuario, cnFincasNET)

    Dim _IdAgricultor As String = ""



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()



    End Sub


    Public Sub InitAgricultor(IdAgricultor As String)

        _IdAgricultor = IdAgricultor

    End Sub


    Private Sub ParametrosFrm()
        EntidadFrm = Previsiones


        Dim lc As New List(Of Object)
        ListaControles = lc



        ParamTx(TxAgricultor, Previsiones.PVR_idagricultor, LbAgr, True)
        CampoClave = 1 ' ultimo campo de la clave
        ParamTx(TxFecha, Previsiones.PVR_fecha, LbFecha, True)
        ParamTx(TxObserva, Previsiones.PVR_observaciones, LbObserva)

        ParamTx(TxProducto, Previsiones_lineas.PRL_idgenero, LbProducto, True)
        ParamTx(TxKilos, Previsiones_lineas.PRL_KILOS, LbKilos, True)
        ParamTx(TxFinca, Previsiones_lineas.PRL_IDfinca, LbFinca)
        ParamTx(TxCultivo, Previsiones_lineas.PRL_IdCultivo, LbCultivo)
        ParamTx(TxObs, Previsiones_lineas.PRL_Observaciones, LbObs)




        'Líneas



        AsociarGrid(ClGrid1, TxProducto, TxObs, Previsiones_lineas)

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        PropiedadesCamposGr(ClGrid1, "PRL_id", "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 10)
        PropiedadesCamposGr(ClGrid1, "Genero", "Genero", True, 50)
        PropiedadesCamposGr(ClGrid1, "Kilos", "Kilos", True, 10, True)
        PropiedadesCamposGr(ClGrid1, "Observ", "Observ", True, 50)


        AsociarControles(TxAgricultor, BtAgr, Agriculores.btBusca, Agriculores, Agriculores.AGR_Nombre, LbNomAgr)

        AsociarControles(TxProducto, BtBuscaProducto, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomProducto)

        AsociarControles(TxFinca, BtBuscaFinca, Fincas.btBusca, Fincas, Fincas.FIN_Nombre, LbNombreFinca)



    End Sub

    Private Sub FrmPreviones_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated

        If VaInt(_IdAgricultor) > 0 Then

            TxAgricultor.Text = _IdAgricultor
            TxAgricultor.Focus()
            SendKeys.Send(Chr(13))

            TxFecha.Focus()
            SendKeys.Send(Chr(13))

        End If

        _IdAgricultor = ""


    End Sub


    Private Sub FrmPedidosMaterial_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        
    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        Dim i As Integer


        i = Previsiones.LeerPrevision(VaInt(TxAgricultor.Text), TxFecha.Text)
        If i > 0 Then
            LbId.Text = i.ToString
        Else
            LbId.Text = "+" 'AlbEntrada.MaxId
        End If

        CargaLineasGrid()

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)

        LbNombreFinca.Text = ""
        LbNomCultivo1.Text = ""
        LbNomCultivo2.Text = ""

        MyBase.Entidad_a_DatosLin(Grid)
    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()


        ' llenar el grid
        CargaLineasGrid()
    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean

        If LbId.Text = "+" Then
            LbId.Text = Previsiones.MaxId
        End If
        Previsiones.PVR_idprevision.Valor = LbId.Text
        Previsiones_lineas.PRL_idprevision.Valor = LbId.Text
        SqlGrid()
        r = MyBase.GuardarLineas(Gr)
        Return r
    End Function


    Public Overrides Sub DespuesdeGuardarLinea(gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)
    End Sub


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()

    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)

        LbNombreFinca.Text = ""
        LbNomCultivo1.Text = ""
        LbNomCultivo2.Text = ""

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbNombreFinca.Text = ""
        LbNomCultivo1.Text = ""
        LbNomCultivo2.Text = ""


    End Sub


    Private Sub CargaLineasGrid()

        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)

    End Sub





    Private Sub SqlGrid()


        Dim id As String
        If LbId.Text = "+" Then
            id = "-1"
        Else
            id = LbId.Text
        End If
        Dim sql As String
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim CONSULTA As New Cdatos.E_select


        CONSULTA.SelCampo(Previsiones_lineas.PRL_id, "PRL_id")
        CONSULTA.SelCampo(Previsiones_lineas.PRL_idgenero, "Codigo")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero", Previsiones_lineas.PRL_idgenero)
        CONSULTA.SelCampo(Previsiones_lineas.PRL_KILOS, "Kilos")
        CONSULTA.SelCampo(Previsiones_lineas.PRL_Observaciones, "Observ")

        CONSULTA.WheCampo(Previsiones_lineas.PRL_idprevision, "=", id)
        sql = CONSULTA.SQL
        sql = sql + " order by PRL_id"

        ClGrid1.Consulta = sql

    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MyBase.BAnular_Click(sender, e)
    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'If LbPuntoVenta.Text <> MiMaletin.IdPuntoVenta.ToString Then
        ' MsgBox("no se puede modificar el albarán")
        ' Exit Sub
        ' End If

        MyBase.BModificar_Click(sender, e)

    End Sub




    Public Overrides Sub Guardar()
        MyBase.Guardar()

    End Sub

    Private Sub BuscaCultivos()

        Dim frm As New FrmEntradaFincas
        frm.Init(TxAgricultor.Text, TxProducto.Text, TxFinca.Text)
        frm.ShowDialog()

        If Not RowDePaso Is Nothing Then
            If TxCultivo.Enabled = True Then
                TxCultivo.Text = VaInt(RowDePaso("idcultivo")).ToString
                TxCultivo.Focus()
            End If
        End If

    End Sub



    Private Sub TxIdCultivo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxCultivo.KeyDown
        If e.KeyCode = Keys.F2 Then
            BuscaCultivos()
        End If
    End Sub



    Private Sub TxCultivo_Valida(edicion As System.Boolean) Handles TxCultivo.Valida
        If VaInt(TxCultivo.Text) > 0 Then

            Dim idcultivo As String = TxCultivo.Text
            Dim Genero As String = ""
            Dim Variedad As String = ""
            Dim IdPrograma As String = ""
            Dim TipoCultivo As String = ""
            Dim Controlado As String = ""
            Dim Nave As String = ""
            Dim Campa As String = ""
            Dim CalidadEntradas As String = ""

            If DatosCultivo(idcultivo, Genero, Variedad, IdPrograma, Controlado, TipoCultivo, Nave, Campa, CalidadEntradas) Then

                LbNomCultivo1.Text = Genero
                LbNomCultivo2.Text = Variedad

            End If

        End If
    End Sub

    Private Sub TxAgricultor_Valida(edicion As System.Boolean) Handles TxAgricultor.Valida
        BtBuscaFinca.CL_Filtro = "CodAgr=" + TxAgricultor.Text
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        BuscaCultivos()
    End Sub

End Class
