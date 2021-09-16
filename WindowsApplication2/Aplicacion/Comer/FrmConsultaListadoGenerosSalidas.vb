
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic

Public Class FrmConsultaListadoGenerosSalidas
    Inherits FrConsulta

    Dim GenerosSalidas As New E_GenerosSalida(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Confec As New E_ConfecEnvase(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim SubFamilias As New E_Subfamilias(Idusuario, cn)
    Dim FamiliasDescuentos As New E_FamiliasDescuentos(Idusuario, cn)



    Dim err As New Errores

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ParametrosFrm()
    End Sub
    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Generos.GEN_IdGenero, Lb1)
        ParamChk(ChkActivo, Nothing, "S", "N")

        AsociarControles(TxDato1, BtBusca1, Generos.btBusca, Generos, Generos.GEN_NombreGenero, Lb_1)

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        'BInforme.Visible = False
        GridView1.Appearance.HeaderPanel.BackColor = Color.Aquamarine

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub

    Public Overrides Sub Consultar()
        MyBase.Consultar()

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(GenerosSalidas.GES_IdGenero, "genero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "nombregenero", GenerosSalidas.GES_IdGenero, Generos.GEN_IdGenero)
        consulta.SelCampo(GenerosSalidas.GES_Idconfec, "idconfec")
        consulta.SelCampo(Confec.CEV_Nombre, "Confeccion", GenerosSalidas.GES_Idconfec)
        consulta.SelCampo(GenerosSalidas.GES_Nombre, "Presentacion")
        consulta.SelCampo(GenerosSalidas.GES_SobrecosteMat, "SobreM")
        consulta.SelCampo(GenerosSalidas.GES_KilosXBulto, "KxB")
        consulta.SelCampo(Generos.GEN_GastoConfeccion, "GtoConf")
        consulta.SelCampo(GenerosSalidas.GES_GtoXKilo, "SobreC")
        consulta.SelCampo(Confec.CEV_TotalCoste, "GtoMat")

        consulta.SelCampo(SubFamilias.SFA_idfamilia, "idfamilia", Generos.GEN_IdsubFamilia)
        
        If TxDato1.Text.Trim <> "" Then consulta.WheCampo(Generos.GEN_IdGenero, "=", TxDato1.Text)
        If ChkActivo.CheckState = CheckState.Checked Then
            consulta.WheCampo(GenerosSalidas.GES_Activo, "=", "S")
        End If

        Dim sql As String = consulta.Sel(_IncluirTodosLosCampos) & consulta.Whe
        GridView1.Columns.Clear()
        Dim dt As DataTable = GenerosSalidas.MiConexion.ConsultaSQL(sql)

        dt.Columns.Add(New DataColumn("MatXBul", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("ConXBul", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("EstXBul", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("TotXBul", GetType(Decimal)))

        dt.Columns.Add(New DataColumn("MatXKil", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("ConXKil", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("EstXKil", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("TotXKil", GetType(Decimal)))

        For Each RW In dt.Rows
            Dim K_B As Decimal = VaDec(RW("KXB"))
            Dim Mat_bul As Decimal = VaDec(RW("GtoMat")) + VaDec(RW("SobreC"))
            Dim Con_Kil As Decimal = VaDec(RW("Gtoconf"))
            Dim Est_Kil As Decimal = 0

            Dim dtf As DataTable = FamiliasDescuentos.LeerDescuentos(VaInt(RW("idfamilia")), MiMaletin.IdCentro.ToString)
            If Not dtf Is Nothing Then
                If dtf.Rows.Count > 0 Then
                    Est_Kil = dtf.Rows(0)("FAD_estructura")
                End If
            End If

            Dim Con_bul As Decimal = 0
            Dim Est_bul As Decimal = 0
            Dim Tot_bul As Decimal = 0
            Dim tot_kil As Decimal = 0

            Dim Mat_kil As Decimal = 0

            If K_B <> 0 Then
                Con_bul = Con_Kil * K_B
                Est_bul = Est_Kil * K_B
                Tot_bul = Con_bul + Est_bul + Mat_bul

                Mat_kil = Mat_bul / K_B
                tot_kil = Con_Kil + Mat_kil + Est_Kil


            End If

            RW("MatXbul") = Mat_bul
            RW("ConXbul") = Con_bul
            RW("EstXbul") = Est_bul
            RW("TotXbul") = Tot_bul

            RW("MatXkil") = Mat_kil
            RW("ConXkil") = Con_Kil
            RW("EstXkil") = Est_Kil
            RW("TotXkil") = tot_kil


        Next

        Grid.DataSource = dt




        AjustaColumnas()
    End Sub
    Private Sub AjustaColumnas()

        Grid.ForceInitialize()
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "GENERO"
                    c.Visible = True
                    c.Width = 10
                Case "IDCONFEC"
                    c.Visible = True
                    c.Width = 10
                Case "CONFECCION"
                    c.Visible = True
                    c.Width = 60
                Case "PRESENTACION"
                    c.Visible = True
                    c.Width = 60
                Case "GTOCONF", "GTOMAT"
                    c.Visible = False
                Case "NOMBREGENERO"
                    c.Visible = True
                    c.Width = 40
                Case "KXB", "SOBREC", "MATXBUL", "CONXBUL", "ESTXBUL", "TOTXBUL"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#0.00"
                    c.Visible = True
                    c.Width = 20
                Case "MATXKIL", "CONXKIL", "ESTXKIL", "TOTXKIL"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#0.00"
                    c.Visible = True
                    c.Width = 20

                Case Else
                    c.Visible = False
            End Select
        Next
        GridView1.BestFitColumns()

    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim listado As New Listado_ConsultaListadoGenerosSalidas(dt, TxDato1.Text, ChkActivo.Checked, TipoImpresion.Preliminar)
                listado.ImprimirListado()
            Else
                bDatos = False
            End If
        Else
            bDatos = False
        End If
        If Not bDatos Then
            MessageBox.Show("No hay datos que imprimir")
        End If

    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()
        If TxDato1.Text.Trim <> "" Then LineasDescripcion.Add("GENERO: " & VaInt(TxDato1.Text).ToString("00000") & " " & Lb_1.Text)
        If ChkActivo.Checked Then LineasDescripcion.Add("SOLO ACTIVOS")

        MyBase.Imprimir()

    End Sub


End Class