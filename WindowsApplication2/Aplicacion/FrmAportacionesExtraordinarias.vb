
Public Class FrmAportacionesExtraordinarias
    Inherits FrMantenimiento


    Dim AportacionesExtraordinarias As New E_AportacionesExtraordinarias(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Bancos As New E_Bancos(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        EntidadFrm = AportacionesExtraordinarias


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxNumero, AportacionesExtraordinarias.APX_Id, LbNumero, True)
        CampoClave = 0 ' ultimo campo de la clave
        TxNumero.Autonumerico = True
        ParamTx(TxFecha, AportacionesExtraordinarias.APX_FechaAportacion, LbFecha, True)
        ParamTx(TxAgricultor, AportacionesExtraordinarias.APX_IdAgricultor, LbAgricultor, True)
        ParamTx(TxAnnoFondo, AportacionesExtraordinarias.APX_AnnoFondo, LbAnnoFondo, True)
        ParamTx(TxTotalAportacion, AportacionesExtraordinarias.APX_TotalAportacion, LbTotalAportacion, True)
        ParamTx(TxAportacionFondo, AportacionesExtraordinarias.APX_AportacionFondo, LbAportacionFondo, True)
        ParamTx(TxBanco, AportacionesExtraordinarias.APX_IdBanco, LbBanco, True)
        ParamTx(TxConcepto, AportacionesExtraordinarias.APX_Concepto, LbConcepto, True)


        AsociarControles(TxNumero, BtBuscaAportacion, AportacionesExtraordinarias.btBusca, EntidadFrm)
        AsociarControles(TxAgricultor, BtBuscaAgricultor, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNom_Agricultor)
        AsociarControles(TxBanco, BtBuscaBanco, Bancos.btBusca, Bancos, Bancos.Nombre, LbNom_Banco)

        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me

    End Sub


    Private Sub FrGeneros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Public Overrides Sub ControlClave()

        ' componemos la clave
        LbId.Text = TxNumero.Text

    End Sub


    Public Overrides Sub Borrapan()
        MyBase.BorraPan()


        LbAsientoHortichuelas.Text = ""
        LbAsientoHortiHorto.Text = ""

    End Sub


    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()


        LbImporteAportacionNoFondoMasIVA.Text = VaDec(AportacionesExtraordinarias.APX_AportacionNoFondoMasIVA.Valor).ToString("#,##0.00")

        Dim IdAsientoHortichuelas As Integer = VaInt(AportacionesExtraordinarias.APX_IdAsiento_Hortichuelas.Valor)
        Dim IdAsientosHortiHorto As Integer = VaInt(AportacionesExtraordinarias.APX_IdAsiento_HortiHorto.Valor)

        If IdAsientoHortichuelas <> 0 Then
            Dim Asientos As New E_Asientos(Idusuario, ConexCtb(1))
            If Asientos.LeerId(IdAsientoHortichuelas.ToString) Then
                LbAsientoHortichuelas.Text = Asientos.NumeroAsiento(IdAsientoHortichuelas)
            Else
                MsgBox("Error al leer el asiento de Hortichuelas")
            End If
        End If


        If IdAsientosHortiHorto <> 0 Then
            Dim Asientos As New E_Asientos(Idusuario, ConexCtb(2))
            If Asientos.LeerId(IdAsientosHortiHorto.ToString) Then
                LbAsientoHortiHorto.Text = Asientos.NumeroAsiento(IdAsientosHortiHorto)
            Else
                MsgBox("Error al leer el asiento de HortiHorto")
            End If
        End If



    End Sub


    Public Overrides Sub Guardar()

        If TxNumero.Text = "+" Then
            LbId.Text = AportacionesExtraordinarias.MaxId.ToString
            TxNumero.Text = LbId.Text
        End If

        AportacionesExtraordinarias.APX_AportacionNoFondoMasIVA.Valor = VaDec(LbImporteAportacionNoFondoMasIVA.Text).ToString

        MyBase.Guardar()

    End Sub


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()


        If Not ChkNoContabilizar.Checked Then

            If ConectarFinancieroContabilidad = "S" Then

                Dim IdAsientoHortiHorto As Integer = 0
                Dim IdAsientoHortichuelas As Integer = AportacionesExtraordinarias.Contabiliza(LbId.Text, IdAsientoHortiHorto)


                If IdAsientoHortichuelas > 0 Then

                    Dim ListaAsientos As New List(Of Integer)
                    ListaAsientos.Add(IdAsientoHortichuelas)
                    Dim f As New frmVisualizadorAsiento(ListaAsientos, False, "", 1)
                    f.ShowDialog()

                Else
                    MsgBox("No se generó asiento en Hortichuelas")
                End If


                If IdAsientoHortiHorto > 0 Then
                    Dim ListaAsientos As New List(Of Integer)
                    ListaAsientos.Add(IdAsientoHortiHorto)
                    Dim f As New frmVisualizadorAsiento(ListaAsientos, False, "", 2)
                    f.ShowDialog()
                End If


            End If

        End If

    End Sub


    Public Overrides Sub Anular()

        Dim IdAsientoHortichuelas As Integer = VaInt(AportacionesExtraordinarias.APX_IdAsiento_Hortichuelas.Valor)
        Dim IdAsientoHortiHorto As Integer = VaInt(AportacionesExtraordinarias.APX_IdAsiento_HortiHorto.Valor)
        Dim NumeroAsientoHortichuelas As Integer = VaInt(LbAsientoHortichuelas.Text)
        Dim NumeroAsientoHortiHorto As Integer = VaInt(LbAsientoHortiHorto.Text)


        MyBase.Anular()


        If IdAsientoHortichuelas > 0 And NumeroAsientoHortichuelas > 0 Then
            Dim c As New Contabilizacion.clAsientos
            If c.AnularAsiento(ConexCtb(1), IdAsientoHortichuelas, NumeroAsientoHortichuelas) <> 0 Then
                MsgBox("No se pudo anular el asiento de Hortichuelas")
            Else
                MsgBox("Asiento anulado con exito")
            End If
        End If


        If IdAsientoHortiHorto > 0 And NumeroAsientoHortiHorto > 0 Then
            Dim c As New Contabilizacion.clAsientos
            If c.AnularAsiento(ConexCtb(2), IdAsientoHortiHorto, NumeroAsientoHortiHorto) <> 0 Then
                MsgBox("No se pudo anular el asiento de HortiHorto")
            Else
                MsgBox("Asiento anulado con exito")
            End If
        End If

    End Sub


    Private Sub LbAsientoHortichuelas_Click(sender As System.Object, e As System.EventArgs) Handles LbAsientoHortichuelas.Click

        If LbAsientoHortichuelas.Text <> "" Then

            Dim IdAsientoNET As Integer = VaInt(AportacionesExtraordinarias.APX_IdAsiento_Hortichuelas.Valor)
            Dim ListaAsientos As New List(Of Integer)
            ListaAsientos.Add(IdAsientoNET)
            Dim F As New FrmConsultaVisuAsiento(ListaAsientos, False, , 1)
            F.ShowDialog()

        End If

    End Sub


    Private Sub LbAsientoHortiHorto_Click(sender As System.Object, e As System.EventArgs) Handles LbAsientoHortiHorto.Click

        If LbAsientoHortiHorto.Text <> "" Then

            Dim IdAsientoNET As Integer = VaInt(AportacionesExtraordinarias.APX_IdAsiento_HortiHorto.Valor)
            Dim ListaAsientos As New List(Of Integer)
            ListaAsientos.Add(IdAsientoNET)
            Dim F As New FrmConsultaVisuAsiento(ListaAsientos, False, , 2)
            F.ShowDialog()

        End If

    End Sub


    Private Sub TxTotalAportacion_Valida(edicion As System.Boolean) Handles TxTotalAportacion.Valida
        If edicion Then
            CalculaAportacionNoFondoMasIVA()
        End If
    End Sub

    Private Sub TxAportacionFondo_Valida(edicion As System.Boolean) Handles TxAportacionFondo.Valida
        If edicion Then
            CalculaAportacionNoFondoMasIVA()
        End If
    End Sub

    Private Sub CalculaAportacionNoFondoMasIVA()

        Dim AportacionNoFondoMasIVA As Decimal = VaDec(TxTotalAportacion.Text) - VaDec(TxAportacionFondo.Text)
        LbImporteAportacionNoFondoMasIVA.Text = AportacionNoFondoMasIVA.ToString("#,##0.00")

    End Sub


    Private Sub TxFecha_Valida(edicion As System.Boolean) Handles TxFecha.Valida

        If edicion Then
            If NuevoRegistro Then
                If TxAnnoFondo.Text.Trim = "" Then TxAnnoFondo.Text = Today.ToString("yyyy")
            End If
        End If

    End Sub

End Class

