
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic

Public Class FrmConsultaListadoAcreedores
    Inherits FrConsulta

    Dim Acreedores As New E_Acreedores(Idusuario, cn)

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
        consulta.SelCampo(Acreedores.ACR_Codigo, "codigo")
        consulta.SelCampo(Acreedores.ACR_CPostal, "cp")
        consulta.SelCampo(Acreedores.ACR_Domicilio, "domicilio")
        consulta.SelCampo(Acreedores.ACR_Fax, "fax")
        consulta.SelCampo(Acreedores.ACR_IdCuenta, "idcuenta")
        consulta.SelCampo(Acreedores.ACR_Mail, "mail")
        consulta.SelCampo(Acreedores.ACR_Nif, "nif")
        consulta.SelCampo(Acreedores.ACR_Nombre, "nombre")
        consulta.SelCampo(Acreedores.ACR_Poblacion, "poblacion")
        consulta.SelCampo(Acreedores.ACR_Provincia, "provincia")
        consulta.SelCampo(Acreedores.ACR_Telefono1, "tlf1")
        consulta.SelCampo(Acreedores.ACR_Telefono2, "tlf2")


        Dim sql As String = consulta.Sel(_IncluirTodosLosCampos)
        GridView1.Columns.Clear()
        Dim dt As DataTable = Acreedores.MiConexion.ConsultaSQL(sql)
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
                Case "CP"
                    c.Visible = True
                    c.Width = 10
                Case "DOMICILIO"
                    c.Visible = True
                    c.Width = 70
                Case "FAX"
                    c.Visible = True
                    c.Width = 10
                Case "IDCUENTA"
                    c.Visible = True
                    c.Width = 25
                Case "MAIL"
                    c.Visible = True
                    c.Width = 20
                Case "NIF"
                    c.Visible = True
                    c.Width = 15
                Case "NOMBRE"
                    c.Visible = True
                    c.Width = 70
                Case "POBLACION"
                    c.Visible = True
                    c.Width = 25
                Case "PROVINCIA"
                    c.Visible = True
                    c.Width = 25
                Case "TLF1"
                    c.Visible = True
                    c.Width = 10
                Case "TLF2"
                    c.Visible = True
                    c.Width = 10
                Case Else
                    c.Visible = False
            End Select
        Next

    End Sub
End Class