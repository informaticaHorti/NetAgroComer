
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic

Public Class FrmConsultaListadoProveedores
    Inherits FrConsulta

    Dim Proveedores As New E_Agricultores(Idusuario, cn)
    Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)
    Dim Zona As New E_Zonas(Idusuario, cn)
    Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)


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

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Proveedores.AGR_IdAgricultor, "codigo")
        consulta.SelCampo(Proveedores.AGR_Nombre, "nombre")
        consulta.SelCampo(Proveedores.AGR_Nif, "nif")
        consulta.SelCampo(Proveedores.AGR_Domicilio, "domicilio")
        consulta.SelCampo(Proveedores.AGR_IdZona, "idzona")
        consulta.SelCampo(Proveedores.AGR_Poblacion, "poblacion")
        consulta.SelCampo(Proveedores.AGR_Provincia, "provincia")
        consulta.SelCampo(Proveedores.AGR_Cpostal, "cp")
        consulta.SelCampo(Proveedores.AGR_fechaalta, "fechaalta")
        consulta.SelCampo(Proveedores.AGR_Telefono, "tlf1")
        consulta.SelCampo(Proveedores.AGR_Movil, "tlf2")
        consulta.SelCampo(Proveedores.AGR_IdTipo, "idtipo")
        consulta.SelCampo(TipoAgricultor.TPA_nombre, "tipo", Proveedores.AGR_IdTipo, TipoAgricultor.TPA_idtipo)
        consulta.SelCampo(Zona.ZON_Nombre, "zona", Proveedores.AGR_IdZona, Zona.ZON_Idzona)
        consulta.SelCampo(CentrosRecogida.CER_Nombre, "CRecogida", Proveedores.AGR_idcrecogida)



        Dim sql As String = consulta.Sel(_IncluirTodosLosCampos)

        GridView1.Columns.Clear()
        Dim dt As DataTable = Proveedores.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt

        AjustaColumnas()
    End Sub
    Private Sub AjustaColumnas()

        Grid.ForceInitialize()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CODIGO"
                    c.Visible = True
                    c.Width = 10
                Case "NOMBRE"
                    c.Visible = True
                    c.Width = 45
                Case "NIF"
                    c.Visible = True
                    c.Width = 15
                Case "DOMICILIO"
                    c.Visible = True
                    c.Width = 45
                Case "POBLACION"
                    c.Visible = True
                    c.Width = 35
                Case "PROVINCIA"
                    c.Visible = True
                    c.Width = 15
                Case "CP"
                    c.Visible = True
                    c.Width = 10
                Case "FECHAALTA"
                    c.Visible = True
                    c.Width = 25
                Case "TLF1"
                    c.Visible = True
                    c.Width = 20
                Case "TLF2"
                    c.Visible = True
                    c.Width = 20
                Case "IDTIPO"
                    c.Visible = True
                    c.Width = 10
                Case "TIPO"
                    c.Visible = True
                    c.Width = 40
                Case "ZONA", "CRECOGIDA"
                    c.Visible = True
                    c.Width = 40

                Case Else
                    c.Visible = False
            End Select
        Next
    End Sub
End Class