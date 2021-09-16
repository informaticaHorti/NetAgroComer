Imports DevExpress.XtraEditors

Public Class FrmPartedestrio
    Inherits FrMantenimiento



    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim Mi_IdCentro As Integer
    Dim Partedestrio As New E_ParteDestrio(Idusuario, cn)
    Dim Partedestrio_lineas As New E_partedestrio_lineas(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
    Dim Subfamilias As New E_Subfamilias(Idusuario, cn)





    Dim Centros As New E_centros(Idusuario, CnCtb)
    Dim Envases As New E_Envases(Idusuario, cn)


    Private Sub ParametrosFrm()
        EntidadFrm = Partedestrio


        Dim lc As New List(Of Object)
        ListaControles = lc



        ParamTx(TxDato_1, Partedestrio.PDS_numero, Lb1, True)
        TxDato_1.Autonumerico = True
        LbCentro.CL_ControlAsociado = TxDato_1
        LbNomCentro.CL_ControlAsociado = TxDato_1
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato_2, Partedestrio.PDS_fecha, Lb_2, True)

        ParamTx(TxDato_50, Partedestrio_lineas.PDL_idgenero, Lb_50, True)
        ParamTx(TxDato_56, Partedestrio_lineas.PDL_kilos, Lb_56, False)



        AsociarGrid(ClGrid1, TxDato_50, TxDato_56, Partedestrio_lineas)

        ' ClGrid1.GridView.OptionsView.ColumnAutoWidth = False

        PropiedadesCamposGr(ClGrid1, "PDL_idlinea", "PDL_idlinea", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Genero", "Genero", True, 50)
        PropiedadesCamposGr(ClGrid1, "Kilos", "Kilos", True, 10, True)


        AsociarControles(TxDato_1, BtBuscaAlbaran, Partedestrio.btBusca, EntidadFrm)



        AsociarControles(TxDato_50, BtBusca_50, Generos.btBusca, Generos, Generos.GEN_NombreGenero, Lbnom_50)



        FiltroEntidad.Add(Partedestrio.PDS_idcentro.NombreCampo, MiMaletin.IdCentro.ToString)
        FiltroEntidad.Add(Partedestrio.PDS_campa.NombreCampo, MiMaletin.Ejercicio.ToString)



    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        Dim i As Integer


        If TxDato_1.Text = "+" Then
            LbId.Text = "+"
        Else
            i = Partedestrio.LeerParte(CInt(LbCampa.Text), VaInt(LbCentro.Text), CInt(TxDato_1.Text))
            If i > 0 Then
                LbId.Text = i.ToString
            Else
                LbId.Text = "+" 'AlbEntrada.MaxId


            End If

        End If
        CargaLineasGrid()

    End Sub
    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)

    End Sub
    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()
        Mi_IdCentro = Partedestrio.PDS_idcentro.Valor
        LbCampa.Text = Partedestrio.PDS_campa.Valor
        PintaCentro(Mi_IdCentro)

        ' llenar el grid
        CargaLineasGrid()
        '  LbtotAlb.Text = Format(TotalAlbaran, "#,###0.00")

    End Sub
    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        Dim r As Boolean

        If LbId.Text = "+" Then
            LbId.Text = Partedestrio.MaxId
        End If
        If TxDato_1.Text = "+" Then
            TxDato_1.Text = Partedestrio.MaxIdCampa(LbCampa.Text, LbCentro.Text)
        End If
        Partedestrio.PDS_idparte.Valor = LbId.Text
        Partedestrio.PDS_campa.Valor = LbCampa.Text
        Partedestrio.PDS_idcentro.Valor = LbCentro.Text


        Partedestrio_lineas.PDL_idparte.Valor = LbId.Text
        SqlGrid()
        r = MyBase.GuardarLineas(Gr)
        Return r
    End Function

    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()



        'If NuevoRegistro Then
        '    ImprimirDocumento(False)
        'Else
        '    If XtraMessageBox.Show("¿Desea imprimir el Documento?", "CMR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '        ImprimirDocumento(False)
        '    End If
        'End If

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
        PintaCentro(Mi_IdCentro)


    End Sub

    Public Overrides Sub DespuesdeCargarLineas(ByVal gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)
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


        CONSULTA.SelCampo(Partedestrio_lineas.PDL_idlinea, "PDL_idlinea")
        CONSULTA.SelCampo(Generos.GEN_NombreGenero, "Genero", Partedestrio_lineas.PDL_idgenero)
        CONSULTA.SelCampo(Partedestrio_lineas.PDL_kilos, "Kilos")


        CONSULTA.WheCampo(Partedestrio_lineas.PDL_idparte, "=", id)
        sql = CONSULTA.SQL
        sql = sql + " order by pDl_idlinea"

        ClGrid1.Consulta = sql

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()

        'BTaux1.Visible = True
        'BTaux1.Text = "Imprimir"
        'BTaux1.Image = PictureBox1.Image

        'BtAux2.Visible = True
        'BtAux2.Text = "I.Directa"
        'BtAux2.Image = PictureBox2.Image



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

    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxDato_1.Text = "" And TxDato_1.Enabled = True Then
            TxDato_1.Text = "+"
            Siguiente(0)
        End If
    End Sub


    Private Sub TxDato2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_56.TextChanged

    End Sub

    Private Sub PintaCentro(ByVal Centro As Integer)

        LbCentro.Text = Centro.ToString
        If Centros.LeerId(LbCentro.Text) = True Then
            LbNomCentro.Text = Centros.Nombre.Valor
        Else
            LbNomCentro.Text = ""
        End If


    End Sub

    Public Overrides Sub Guardar()

        MyBase.Guardar()

    End Sub


    Private Sub TxDato_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub TxDato_50_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato_50.TextChanged

    End Sub

    Private Sub TxDato_50_Valida(edicion As Boolean) Handles TxDato_50.Valida

    End Sub

    Private Sub TxDato_2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato_2.TextChanged

    End Sub

    Private Sub Lb_2_Click(sender As System.Object, e As System.EventArgs) Handles Lb_2.Click

    End Sub

    Private Sub BtBuscaAlbaran_Click(sender As System.Object, e As System.EventArgs) Handles BtBuscaAlbaran.Click

    End Sub

    Private Sub TxDato_1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato_1.TextChanged

    End Sub

    Private Sub LbCampa_Click(sender As System.Object, e As System.EventArgs) Handles LbCampa.Click

    End Sub

    Private Sub Lb1_Click(sender As System.Object, e As System.EventArgs) Handles Lb1.Click

    End Sub
End Class

