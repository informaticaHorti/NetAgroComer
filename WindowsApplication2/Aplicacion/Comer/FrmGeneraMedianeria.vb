
Public Class FrmGeneraMedianeria

    Inherits FrConsulta




    Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
    Dim Agricultor As New E_Agricultores(Idusuario, cn)
    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Dim AlbEntrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
    Dim AlbEntrada_hislineas As New E_AlbEntrada_hislineas(Idusuario, cn)

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxSemana, Nothing, LbSemana, True, Cdatos.TiposCampo.EnteroPositivo, 0, 3)
        ParamTx(TxDeFecha, Nothing, LbDFecha, True, Cdatos.TiposCampo.Fecha, True)
        ParamTx(TxaFecha, Nothing, LbAFecha, True, Cdatos.TiposCampo.Fecha, True)
        ParamTx(TxDAgricultor, Nothing, LbdAgricultor, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)
        ParamTx(TxAAgricultor, Nothing, LbaAgricultor, False, Cdatos.TiposCampo.EnteroPositivo, 0, 5)


        AsociarControles(TxSemana, BtBuscaSemana, SemanasPartes.btBusca, SemanasPartes)
        AsociarControles(TxDAgricultor, BtBuscaagr1, Agricultor.btBusca, Agricultor, Agricultor.AGR_Nombre, LbnomAgr1)
        AsociarControles(TxAAgricultor, BtBuscaAgr2, Agricultor.btBusca, Agricultor, Agricultor.AGR_Nombre, LbNomAgr2)


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


    End Sub


   


    Private Sub FrmExtractoEnvasesPorMaterial_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        BInforme.Visible = False
        BtAux.Visible = True
        BtAux.Text = "Generar"


        CbCentroRecogida = ComboCentrosRecogida(CbCentroRecogida)


        '  GridView1.Appearance.GroupRow.Font = nueva_fuente

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub



    Private Sub CargaGrid()

        Dim Consulta As New Cdatos.E_select

        Consulta.SelCampo(AlbEntrada.AEN_IdAlbaran, "idalbaran")
        Consulta.SelCampo(AlbEntrada.AEN_Albaran, "Albaran")
        Consulta.SelCampo(AlbEntrada.AEN_Fecha, "Fecha")
        Consulta.SelCampo(AlbEntrada.AEN_TipoFCS, "FCS")
        Consulta.SelCampo(AlbEntrada.AEN_IdAgricultor, "Codigo")
        Consulta.SelCampo(Agricultor.AGR_Nombre, "Agricultor", AlbEntrada.AEN_IdAgricultor)
        '        AlbEntrada_lineas.AEL_kilosnetos()
        Dim oKilos As New Cdatos.bdcampo("@(SELECT SUM(AEL_KilosNetos) FROM Albentrada_Lineas WHERE AEL_IdAlbaran = AEN_IdAlbaran)", Cdatos.TiposCampo.Entero, 10)
        Consulta.SelCampo(oKilos, "Kilos")
        If TxDAgricultor.Text <> "" Then
            Consulta.WheCampo(AlbEntrada.AEN_IdAgricultor, ">=", TxDAgricultor.Text)
        End If
        If TxAAgricultor.Text <> "" Then
            Consulta.WheCampo(AlbEntrada.AEN_IdAgricultor, "<=", TxAAgricultor.Text)
        End If
        If TxDeFecha.Text <> "" Then
            Consulta.WheCampo(AlbEntrada.AEN_Fecha, ">=", TxDeFecha.Text)
        End If
        If TxaFecha.Text <> "" Then
            Consulta.WheCampo(AlbEntrada.AEN_Fecha, "<=", TxaFecha.Text)
        End If

        Dim sql As String = Consulta.SQL
        If Consulta.Whe.Trim = "" Then
            sql = sql & CadenaWhereLista(Agricultor.AGR_idcrecogida, ListadeCombo(CbCentroRecogida), " WHERE ") & vbCrLf
        Else
            sql = sql & CadenaWhereLista(Agricultor.AGR_idcrecogida, ListadeCombo(CbCentroRecogida), " AND ") & vbCrLf
        End If

        sql = sql + " order by AEN_FECHA"


        Dim DT As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)

      
        DT.Columns.Add("Kmed", GetType(System.Int32))
        DT.Columns.Add("Fac", GetType(System.String))
        DT.Columns.Add("FacG", GetType(System.String))

     

        Grid.DataSource = Dt
        AjustaColumnas()



    End Sub


    Private Sub AjustaColumnas()


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDALBARAN"
                    c.Visible = False
                Case "FECHA"
                    c.Width = 200
                Case "KILOS", "KMED"
                    c.Width = 200
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n0}"
                Case "ALBARAN", "CODIGO", "FAC", "FACG", "FCS"
                    c.Width = 150
                Case "AGRICULTOR"
                    c.Width = 400

            End Select

        Next

        AñadeResumenCampo("Kilos", "{0:n0}")
        AñadeResumenCampo("Kmed", "{0:n0}")

    End Sub


    Private Sub BtAux_Click(sender As System.Object, e As System.EventArgs) Handles BtAux.Click

        Dim Facturados As Boolean = False

        'If Mid(TxDato3.Text, 7, 4) <> Mid(TxDato4.Text, 7, 4) Then
        '    MsgBox("Solo se pueden generar semanas dentro del mismo año. Revise las fechas")
        '    Exit Sub
        'End If
        If MsgBox("Desea generar las medianerias ", vbYesNo) = vbNo Then Exit Sub
        Barra.Visible = True

        Dim DT As DataTable = Grid.DataSource
        Barra.Maximum = DT.Rows.Count
        Barra.Value = 0
        For Each RW In DT.Rows

            Dim IDalbaran As Integer = VaInt(RW("idalbaran"))
            Dim IdAgricultor As Integer = VaInt(RW("codigo"))

            If Barra.Value < Barra.Maximum Then
                Barra.Value = Barra.Value + 1
            End If

            If IDalbaran > 0 Then
                If Albentrada_his.AlbaranFacturado(IDalbaran.ToString) <> "" Then
                    RW("FAC") = "SI"
                    Facturados = True
                Else
                    If Albentrada_his.GastosFacturados(IDalbaran.ToString) <> "" Then
                        RW("FACG") = "SI"
                    End If
                    ActualizaMedianeriaAlbaran(IDalbaran, IdAgricultor)
                    Agro_GeneraAlbaranEntrada(IDalbaran)
                End If
            End If

            Dim sql As String = "Select sum(ahl_kilos) as kilos from albentrada_hislineas where ahl_idalbaran=" + IDalbaran.ToString
            Dim dtk As DataTable = AlbEntrada_hislineas.MiConexion.ConsultaSQL(sql)
            If Not dtk Is Nothing Then
                If dtk.Rows.Count > 0 Then
                    Dim k As Decimal = VaDec(dtk.Rows(0)("Kilos"))
                    RW("Kmed") = k
                End If
            End If




        Next


        If Facturados = True Then

            MsgBox("ATENCION. Hay albaranes ya que ya están facturados")
        Else
            MsgBox("Finalizado")

        End If




    End Sub

    Private Sub ActualizaMedianeriaAlbaran(idalbaran As Integer, idagricultor As Integer)

        ' asigno la primera medianeria del agricultor al albaran de entrada
        Dim Medianeria As New E_Medianeria(Idusuario, cn)
        Dim Medianeria_lineas As New E_Medianeria_lineas(Idusuario, cn)
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Medianeria_lineas.MEL_Idmedianeria, "idmedianeria")
        consulta.SelCampo(Medianeria.MED_IdAgricultor, "idagricultor", Medianeria_lineas.MEL_Idmedianeria)
        consulta.WheCampo(Medianeria.MED_IdAgricultor, "=", idagricultor.ToString)
        Dim sql As String = consulta.SQL
        sql = sql + " order by med_numero"

        Dim dt As DataTable = Medianeria.MiConexion.ConsultaSQL(sql)
        Dim idmedianeria As Integer = 0
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                idmedianeria = VaInt(dt.Rows(0)("idmedianeria"))
            End If
        End If


        If AlbEntrada.LeerId(idalbaran) = True Then
            If VaInt(AlbEntrada.AEN_IdMedianeria.Valor) <> idmedianeria Then
                AlbEntrada.AEN_IdMedianeria.Valor = idmedianeria.ToString
                AlbEntrada.Actualizar()
            End If
        End If
    End Sub
    Private Sub TxSemana_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxSemana.TextChanged

    End Sub

    Private Sub TxSemana_Valida(edicion As Boolean) Handles TxSemana.Valida
        Dim IdSemana As Integer = SemanasPartes.LeerSemana(MiMaletin.Ejercicio.ToString, VaInt(TxSemana.Text))
        If IdSemana > 0 Then
            If SemanasPartes.LeerId(IdSemana) = True Then
                TxDeFecha.Text = SemanasPartes.SEV_FechaInicialEntrada.Valor
                TxaFecha.Text = SemanasPartes.SEV_FechaFinalEntrada.Valor
            End If

        Else
            MsgBox("Semana inexistente")
            TxSemana.MiError = True
        End If

    End Sub
End Class