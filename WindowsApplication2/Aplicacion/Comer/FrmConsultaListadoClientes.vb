
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic

Public Class FrmConsultaListadoClientes
    Inherits FrConsulta

    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Zona As New E_Zonas(Idusuario, cn)
    Dim TipoCliente As New E_Tiposclientes(Idusuario, cn)
    Dim Paises As New E_Paises(Idusuario, cn)

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
        consulta.SelCampo(Clientes.CLI_Codigo, "codigo")
        consulta.SelCampo(Clientes.CLI_Nombre, "nombre")
        consulta.SelCampo(Clientes.CLI_Nif, "nif")
        consulta.SelCampo(Clientes.CLI_Domicilio, "domicilio")
        consulta.SelCampo(Clientes.CLI_IdZona, "idzona")
        consulta.SelCampo(Clientes.CLI_Poblacion, "poblacion")
        consulta.SelCampo(Clientes.CLI_Provincia, "provincia")
        consulta.SelCampo(Clientes.CLI_CPostal, "cp")
        consulta.SelCampo(Clientes.CLI_FechaAlta, "fechaalta")
        consulta.SelCampo(Clientes.CLI_Telefono1, "tlf1")
        consulta.SelCampo(Clientes.CLI_Telefono2, "tlf2")
        consulta.SelCampo(Clientes.CLI_IdTipo, "idtipo")
        consulta.SelCampo(Clientes.CLI_Mail, "mail")
        consulta.SelCampo(Clientes.CLI_IdPais, "idpais")
        consulta.SelCampo(Zona.ZON_Nombre, "zona", Clientes.CLI_IdZona, Zona.ZON_Idzona)
        consulta.SelCampo(TipoCliente.TPC_nombre, "tipo", Clientes.CLI_IdTipo, TipoCliente.TPC_idtipo)
        consulta.SelCampo(Paises.Nombre, "pais", Clientes.CLI_IdPais, Paises.IdPais)

        Dim sql As String = consulta.Sel(_IncluirTodosLosCampos)


        GridView1.Columns.Clear()
        Dim dt As DataTable = Clientes.MiConexion.ConsultaSQL(sql)
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
                    c.Width = 10
                Case "DOMICILIO"
                    c.Visible = True
                    c.Width = 45
                Case "POBLACION"
                    c.Visible = True
                    c.Width = 10
                Case "PROVINCIA"
                    c.Visible = True
                    c.Width = 10
                Case "CP"
                    c.Visible = True
                    c.Width = 15
                Case "FECHAALTA"
                    c.Visible = True
                    c.Width = 25
                Case "TLF1"
                    c.Visible = True
                    c.Width = 15
                Case "TLF2"
                    c.Visible = True
                    c.Width = 15
                Case "IDTIPO"
                    c.Visible = True
                    c.Width = 10
                Case "MAIL"
                    c.Visible = True
                    c.Width = 25
                Case "ZONA"
                    c.Visible = True
                    c.Width = 25
                Case "TIPO"
                    c.Visible = True
                    c.Width = 25
                Case "PAIS"
                    c.Visible = True
                    c.Width = 15
                Case Else
                    c.Visible = False
            End Select
        Next

    End Sub
End Class