
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic



Public Class FrmConsultaSOIVRE
    Inherits FrConsulta


    Private AlbSalida As New E_AlbSalida(Idusuario, cn)
    Private AlbSalida_Lineas As New E_AlbSalida_lineas(Idusuario, cn)
    Private SemanasPartes As New E_SemanasPartes(Idusuario, cn)
    Private Generos As New E_Generos(Idusuario, cn)
    Private SubFamilias As New E_Subfamilias(Idusuario, cn)
    Private Familias As New E_FamiliasGeneros(Idusuario, cn)
    Private Paises As New E_Paises(Idusuario, CnComun)
    Private Clientes As New E_Clientes(Idusuario, cn)




    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc


        ParamTx(TxSemana, SemanasPartes.SEV_Semana, LbSemana)
        ParamTx(TxDeFecha, AlbSalida.ASA_fechasalida, LbDeFecha, True)
        ParamTx(TxAFecha, AlbSalida.ASA_fechasalida, LbAFecha, True)


       


    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        BInforme.Visible = False
        GridView1.Appearance.HeaderPanel.BackColor = Color.Aquamarine

        cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()



        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(AlbSalida_Lineas.ASL_idlinea, "IdLinea")
        CONSULTA.SelCampo(AlbSalida.ASA_fechasalida, "Fecha", AlbSalida_Lineas.ASL_idalbaran)
        CONSULTA.SelCampo(Clientes.CLI_IdPais, "IdPais", AlbSalida.ASA_idcliente)
        CONSULTA.SelCampo(Paises.Nombre, "Pais", Clientes.CLI_IdPais)
        CONSULTA.SelCampo(Generos.GEN_IdsubFamilia, "IdSubFamilia", AlbSalida_Lineas.ASL_idgenero)
        CONSULTA.SelCampo(SubFamilias.SFA_nombre, "SubFamilia", Generos.GEN_IdsubFamilia)
        CONSULTA.SelCampo(SubFamilias.SFA_idfamilia, "IdFamilia")
        CONSULTA.SelCampo(Familias.FAG_nombre, "Familia", SubFamilias.SFA_idfamilia)
        CONSULTA.SelCampo(AlbSalida_Lineas.ASL_kilosnetos, "Kilos")
        CONSULTA.WheCampo(AlbSalida.ASA_idcliente, ">", "0")

        If TxDeFecha.Text.Trim <> "" Then CONSULTA.WheCampo(AlbSalida.ASA_fechasalida, ">=", TxDeFecha.Text)
        If TxAFecha.Text.Trim <> "" Then CONSULTA.WheCampo(AlbSalida.ASA_fechasalida, "<=", TxAFecha.Text)


        'Comunitario / NO comunitario / Todos
        Dim sql As String = CONSULTA.SQL & vbCrLf
        sql = sql + CadenaWhereLista(AlbSalida.ASA_idpuntoventa, ListadeCombo(cbPuntoVenta), " AND ")
        If rbComunitario.Checked Then
            sql = sql & " AND COALESCE(Paises.Comunitario,'') = 'S' " & vbCrLf
        ElseIf rbNoComunitario.Checked Then
            sql = sql & " AND COALESCE(Paises.Comunitario,'') <> 'S' " & vbCrLf
        End If



        'Familias / SubFamilias
        If rbFamilias.Checked Then
            sql = "SELECT IdPais, Pais, IdFamilia, Familia, SUM(Kilos) as Kilos" & vbCrLf & _
            " FROM ( " & vbCrLf & sql & " ) as G" & vbCrLf & _
            " GROUP BY IdPais, Pais, IdFamilia, Familia" & vbCrLf & _
            " ORDER BY IdPais, IdFamilia"

        Else
            sql = "SELECT IdPais, Pais, IdSubFamilia, SubFamilia, SUM(Kilos) as Kilos" & vbCrLf & _
            " FROM ( " & vbCrLf & sql & " ) as G" & vbCrLf & _
            " GROUP BY IdPais, Pais, IdSubFamilia, SubFamilia" & vbCrLf & _
            " ORDER BY IdPais, IdSubFamilia"

        End If



        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)

        GridView1.Columns.Clear()
        Grid.DataSource = dt

        AjustaColumnas()


    End Sub



    Private Sub AjustaColumnas()

        Grid.ForceInitialize()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDPAIS", "IDFAMILIA", "IDSUBFAMILIA"
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "PAIS"
                    c.GroupIndex = 1
                Case "KILOS"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
            End Select
        Next


        AñadeResumenCampo("Kilos", "{0:n0}")


    End Sub

    Private Sub TxSemana_Valida(edicion As System.Boolean) Handles TxSemana.Valida

        Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
        Dim IdSemana As Integer = SemanasPartes.LeerSemana(MiMaletin.Ejercicio, VaInt(TxSemana.Text))

        If IdSemana > 0 Then
            TxDeFecha.Text = VaDate(SemanasPartes.SEV_FechaInicialSalida.Valor).ToString("dd/MM/yyyy")
            TxAFecha.Text = VaDate(SemanasPartes.SEV_FechaFinalSalida.Valor).ToString("dd/MM/yyyy")
        End If



    End Sub
End Class