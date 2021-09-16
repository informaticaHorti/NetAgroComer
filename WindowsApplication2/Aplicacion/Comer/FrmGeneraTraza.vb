
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic





Public Class FrmGeneraTraza

    Inherits FrConsulta




    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim _idcliente As Integer = 0

    Dim err As New Errores





    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()


        Dim lc As New List(Of Object)
        ListaControles = lc


        ParamTx(TxFechaDesde, AlbSalida.ASA_fechasalida, LbDesdeFecha, True)
        ParamTx(TxFechaHasta, AlbSalida.ASA_fechasalida, LbHastaFecha, True)



       



    End Sub


    Private Sub FrmConsultaEntradas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        'BImprimir.Visible = False


        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente




    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()
        If Clientes.LeerId(_idcliente) = True Then
            LbNomAgricultorDesde.Text = Clientes.CLI_Nombre.Valor
        End If
    End Sub




    Private Sub Fechaspordefecto()
        TxFechaDesde.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxFechaHasta.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub








    Public Overrides Sub Consultar()
        MyBase.Consultar()

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbSalida.ASA_idalbaran, "idalbaran")
        consulta.SelCampo(AlbSalida.ASA_albaran, "Numero")
        consulta.SelCampo(AlbSalida.ASA_fechasalida, "Fecha")
        consulta.SelCampo(AlbSalida.ASA_referencia, "Referencia")
        consulta.WheCampo(AlbSalida.ASA_idcliente, "=", _idcliente.ToString)
        If TxFechaDesde.Text <> "" Then
            consulta.WheCampo(AlbSalida.ASA_fechasalida, ">=", TxFechaDesde.Text)
        End If
        If TxFechaHasta.Text <> "" Then
            consulta.WheCampo(AlbSalida.ASA_fechasalida, "<=", TxFechaHasta.Text)
        End If
        Dim sql As String = consulta.SQL
        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt
        AjustaColumnas()
    End Sub





    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDALBARAN"
                    c.Visible = False
 
 
            End Select
        Next

        GridView1.BestFitColumns()


    End Sub


    Public Sub initCliente(idcliente As Integer)
        _idcliente = idcliente
    End Sub

   


    Private Sub BInforme_Click(sender As System.Object, e As System.EventArgs) Handles BInforme.Click

        Dim palets_traza As New E_palets_traza(Idusuario, cn)
        If MsgBox("Desea generar las trazabilidades", vbYesNo) = vbYes Then

            Barra.Value = 0
            Dim DT As DataTable = Grid.DataSource
            Barra.Maximum = DT.Rows.Count

            For Each rw In DT.Rows
                If Barra.Value < Barra.Maximum Then
                    Barra.Value = Barra.Value + 1
                End If
                Dim idalbaran As Integer = VaInt(rw("idalbaran"))
                palets_traza.DuplicaTrazabilidad(idalbaran)
            Next
            MsgBox("Terminado")
            Me.Close()
        End If
    End Sub
End Class