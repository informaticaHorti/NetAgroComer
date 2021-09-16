Public Class Frmmedianeria
    Inherits FrMantenimiento
    Dim Medianeria As New E_Medianeria(Idusuario, cn)
    Dim Medianeria_lineas As New E_Medianeria_lineas(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)

    Private Sub ParametrosFrm()
        EntidadFrm = Medianeria


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Medianeria.MED_IdAgricultor, Lb1, True)
        CampoClave = 1 ' ultimo campo de la clave
        ParamTx(TxDato2, Medianeria.MED_Numero, Lb2)

        ParamTx(TxDato3, Medianeria.MED_Nombre, Lb3)

        ParamTx(TxDato_15, Medianeria_lineas.MEL_Idagricultor, Lb_15, True)
        ParamTx(TxDato_16, Medianeria_lineas.MEL_porcentaje, Lb_16, True)

        AsociarControles(TxDato1, BtBuscaAgricultor, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNomAgri)
        AsociarControles(TxDato_15, BtBuscaMed1, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, Lbnom_15)

        AsociarGrid(ClGrid1, TxDato_15, TxDato_16, Medianeria_lineas)

        PropiedadesCamposGr(ClGrid1, "MEL_Id", "", False, 0)
        PropiedadesCamposGr(ClGrid1, "Codigo", "Codigo", True, 10)
        PropiedadesCamposGr(ClGrid1, "Medianero", "Medianero", True, 40)
        PropiedadesCamposGr(ClGrid1, "Porcentaje", "Porcentaje", True, 10, True, "#0.00", "{0:n2}")

     

    End Sub
    Public Overrides Sub ControlClave()
        Dim i As Integer
        i = Medianeria.LeerMedianeria(TxDato1.Text, TxDato2.Text)
        LbId.Text = i.ToString

        If i > 0 Then
            Medianeria.LeerId(i.ToString)
            CargaLineasGrid()
        Else
            LbId.Text = "+"
            CargaLineasGrid()
        End If




    End Sub
   

    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()
        ' llenar el grid
        CargaLineasGrid()
        CalculoPorcen()
    End Sub
    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas

        If LbId.Text = "+" Then
            LbId.Text = Medianeria.MaxId
        End If



        Medianeria_lineas.MEL_Idmedianeria.Valor = LbId.Text
        SqlGrid()

        Return MyBase.GuardarLineas(Gr)


    End Function

    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub

    Private Sub CargaLineasGrid()
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)
    End Sub
    Private Sub SqlGrid()
        Dim Consulta As New Cdatos.E_select
        Consulta.SelCampo(Medianeria_lineas.MEL_Id)
        Consulta.SelCampo(Medianeria_lineas.MEL_Idagricultor, "Codigo")
        Consulta.SelCampo(Agricultores.AGR_Nombre, "Medianero", Medianeria_lineas.MEL_Idagricultor)
        Consulta.SelCampo(Medianeria_lineas.MEL_porcentaje, "Porcentaje")
        Consulta.WheCampo(Medianeria_lineas.MEL_Idmedianeria, "=", LbId.Text)

        ClGrid1.Consulta = Consulta.SQL
    End Sub

    Public Overrides Sub DespuesdeCargarLineas(gr As ClGrid)
        MyBase.DespuesdeCargarLineas(gr)
        CalculoPorcen()
    End Sub

    Private Sub CalculoPorcen()

        Dim DT As DataTable = ClGrid1.Grid.DataSource
        Dim porcen As Double = 0

        If Not DT Is Nothing Then
            If DT.Rows.Count > 0 Then
                porcen = VaDec(DT.Compute("SUM(Porcentaje)", ""))
            End If
        End If


        LbPorAgri.Text = Format(100 - porcen, "###0.00")
    End Sub


    Private Sub ConsultaMedianeria()
        Dim lst As New List(Of Parametros)


        If TxDato1.Text <> "" Then
            Dim dt As DataTable = Medianeria.Medianerias(TxDato1.Text)
            lst.Add(New Parametros("medianeria", False, "", -1))

            lst.Add(New Parametros("numero", False, "", 50))
            lst.Add(New Parametros("Nombre", False, "", 200))


            Dim f As New FrConsultaGenerica(dt, lst, "Medianeria")
            f.ShowDialog()
            If Not RowDePaso Is Nothing Then
                TxDato2.Text = RowDePaso("Numero").ToString
                TxDato2.Focus()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TxDato1.Text <> "" Then
            ConsultaMedianeria()
        End If
    End Sub

    Private Sub TxDato2_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxDato2.EnabledChanged
        Button2.Enabled = TxDato2.Enabled
    End Sub
End Class