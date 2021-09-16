Imports DevExpress.XtraEditors

Public Class FrmSemanasValoracion
    Inherits FrMantenimiento


    Private SemanasPartes As New E_SemanasPartes(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))

    Dim Mi_IdCentro As Integer


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()


        EntidadFrm = SemanasPartes

        Dim lc As New List(Of Object)
        ListaControles = lc



        ParamTx(TxDato_1, SemanasPartes.SEV_Semana, Lb1, True)
        CampoClave = 0

        ParamChk(ChkLiquidadado, SemanasPartes.SEV_LiquidadoSN, "S", "N")
        ParamTx(TxDato_2, SemanasPartes.SEV_FechaInicialEntrada, Lb_2, True)
        ParamTx(TxDato_3, SemanasPartes.SEV_FechaFinalEntrada, Lb_3, True)
        ParamTx(TxDato_4, SemanasPartes.SEV_FechaInicialSalida, Lb5, True)
        ParamTx(TxDato_5, SemanasPartes.SEV_FechaFinalSalida, Lb4, True)

        AsociarControles(TxDato_1, BtBuscaAlbaran, SemanasPartes.btBusca, EntidadFrm)


        FiltroEntidad.Add(SemanasPartes.SEV_Ejercicio.NombreCampo, MiMaletin.Ejercicio.ToString)


        

    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        Dim i As Integer


        If TxDato_1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = SemanasPartes.LeerSemana(CInt(LbCampa.Text), CInt(TxDato_1.Text))
            If i > 0 Then
                LbId.Text = i.ToString
            Else
                LbId.Text = "+" '
            End If

        End If

    End Sub

    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)
    End Sub

    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

        LbCampa.Text = SemanasPartes.SEV_Ejercicio.Valor
     
    End Sub


    Public Overrides Sub DespuesdeGuardar()


        MyBase.DespuesdeGuardar()
    End Sub


    Public Overrides Sub DespuesdeGuardarLinea(ByVal gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)
    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbCampa.Text = MiMaletin.Ejercicio.ToString
        Mi_IdCentro = MiMaletin.IdCentro
       
    End Sub


    Protected Overrides Sub BAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MyBase.BAnular_Click(sender, e)
    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MyBase.BModificar_Click(sender, e)
    End Sub

    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxDato_1.Text = "" And TxDato_1.Enabled = True Then
            TxDato_1.Text = "+"
            Siguiente(0)
        End If
    End Sub


   

    Public Overrides Sub Guardar()

        SemanasPartes.SEV_Ano.Valor = Mid(TxDato_2.Text, 7, 4)
        SemanasPartes.SEV_Ejercicio.Valor = VaInt(LbCampa.Text)

        If LbId.Text = "+" Then

            LbId.Text = SemanasPartes.MaxId
            SemanasPartes.SEV_IdSemana.Valor = LbId.Text


        End If


        MyBase.Guardar()
    End Sub

   
End Class

