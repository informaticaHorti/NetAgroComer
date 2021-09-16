
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic

Public Class AsignarIdFacturaFirme


    Inherits FrConsulta


    Dim err As New Errores

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        BInforme.Visible = False
        GridView1.Appearance.HeaderPanel.BackColor = Color.Aquamarine

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub

    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
        Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
        Dim Agricultor As New E_Agricultores(Idusuario, cn)
        Dim FacturasRecibidas As New E_Facturasrecibidas(Idusuario, cn)



        Dim consulta As New Cdatos.E_select

        consulta.SelCampo(Albentrada_his.AEH_id, "id")
        consulta.SelCampo(Albentrada.AEN_TipoFCS, "FC", Albentrada_his.AEH_idalbaran)
        consulta.SelCampo(Agricultor.AGR_Nombre, "Proveedor", Albentrada_his.AEH_idproveedor)
        consulta.SelCampo(Albentrada_his.AEH_idfactura, "idfactura")
        consulta.SelCampo(FacturasRecibidas.FRR_numero, "Numero", Albentrada_his.AEH_idfactura)
        consulta.WheCampo(Albentrada_his.AEH_idfactura, ">", "0")
        consulta.WheCampo(Albentrada_his.AEH_idfacturafirme, "=", "0")
        consulta.WheCampo(Albentrada.AEN_TipoFCS, "=", "F")


        Dim sql As String = consulta.SQL

        Dim dt As DataTable = albentrada.MiConexion.ConsultaSQL(sql)

        GridView1.Columns.Clear()
        Grid.DataSource = dt

        AjustaColumnas()
    End Sub
    Private Sub AjustaColumnas()

        Grid.ForceInitialize()


        GridView1.BestFitColumns()
    End Sub

    Private Sub BConsultar_Click(sender As System.Object, e As System.EventArgs) Handles BConsultar.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)

        If MsgBox("Desea actualizar el idfactura", vbYesNo) = vbYes Then
            Dim dt As DataTable = Grid.DataSource
            For Each rw In dt.Rows


                Dim id As String = rw("id").ToString
                Dim idfactura As String = rw("idfactura").ToString

                If Albentrada_his.LeerId(id) = True Then
                    Albentrada_his.AEH_idfacturafirme.Valor = idfactura
                    Albentrada_his.AEH_idfactura.Valor = "0"
                    Albentrada_his.Actualizar()
                End If
            Next
        End If
    End Sub


End Class