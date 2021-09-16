
Public Class FrmTrazabilidadPalet
    Inherits FrConsulta


    Dim Palets As New E_palets(Idusuario, cn)
    Dim Palets_lineas As New E_palets_lineas(Idusuario, cn)
    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim AlbSalida_Palets As New E_albsalida_palets(Idusuario, cn)
    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)
    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxPalet, Palets.PAL_palet, LbPalet, False)
        ParamTx(TxAlbaran, AlbSalida.ASA_albaran, LbAlbaran, False)


        AsociarControles(TxPalet, BtBuscaPalet, Palets.btBusca, Palets)
        BtBuscaPalet.CL_DevuelveCampo = "Numero"
        AsociarControles(TxAlbaran, BtBuscaAlbaran, AlbSalida.btBusca, AlbSalida)
        BtBuscaAlbaran.CL_DevuelveCampo = "Albaran"

    End Sub


    Private Sub FrmTrazabilidadPalet_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False
        BConsultar.Visible = False

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

    End Sub


    Private Sub CargaGrid(bPalet As Boolean)

        If TxPalet.Text.Trim = "" And TxAlbaran.Text.Trim = "" Then
            MsgBox("Debe introducir un palet o un albarán")
            Exit Sub
        End If

        Grid.DataSource = Nothing
        GridView1.Columns.Clear()
        GridView1.ClearGrouping()


        Dim IdCentro As Integer = 0
        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        If PuntoVenta.LeerId(LbPuntoVenta.Text) Then
            IdCentro = VaInt(PuntoVenta.IdCentro.Valor)
        End If


        If bPalet Then

            Dim IdPalet As Integer = Palets.Leerpalet(VaInt(Lbejer.Text), VaInt(LbPuntoVenta.Text), VaInt(TxPalet.Text))
            If IdPalet > 0 Then

                Dim consulta As New Cdatos.E_select
                consulta.SelCampo(Palets_lineas.PLL_idlinea, "IdLinea")
                consulta.SelCampo(Generos.GEN_NombreGenero, "Producto", Palets_lineas.PLL_idgenero)
                consulta.SelCampo(ConfecEnvase.CEV_Nombre, "Confeccion", Palets_lineas.PLL_idtipoconfeccion)
                consulta.SelCampo(Palets_lineas.PLL_categoria, "Categoria")
                consulta.SelCampo(Marcas.MAR_Nombre, "Marca", Palets_lineas.PLL_idmarca)
                consulta.SelCampo(Palets_lineas.PLL_bultos, "Bultos")
                consulta.SelCampo(Palets_lineas.PLL_kilosnetos, "Kilos")
                consulta.SelCampo(Palets_lineas.PLL_Controlado, "Controlado")
                consulta.WheCampo(Palets_lineas.PLL_idpalet, "=", IdPalet)
                Dim sql As String = consulta.SQL
                sql = sql + " order by PLL_idlinea"


                Dim dt As DataTable = Palets.MiConexion.ConsultaSQL(sql)

                Grid.DataSource = dt
                AjustaColumnas(bPalet)

            End If

        Else

            Dim AlbSalida As New E_AlbSalida(Idusuario, cn)

            Dim IdAlbaran As Integer = AlbSalida.LeerAlb(VaInt(Lbejer.Text), IdCentro, VaInt(TxAlbaran.Text))
            If IdAlbaran > 0 Then


                Dim consulta As New Cdatos.E_select
                consulta.SelCampo(AlbSalida_Palets.ASP_Idpalet, "IdPalet")
                consulta.SelCampo(Palets.PAL_palet, "Palet", AlbSalida_Palets.ASP_Idpalet)
                consulta.SelCampo(Palets_lineas.PLL_idlinea, "IdLinea", Palets.PAL_idpalet, Palets_lineas.PLL_idpalet)
                consulta.SelCampo(Generos.GEN_NombreGenero, "Producto", Palets_lineas.PLL_idgenero)
                consulta.SelCampo(ConfecEnvase.CEV_Nombre, "Confeccion", Palets_lineas.PLL_idtipoconfeccion)
                consulta.SelCampo(Palets_lineas.PLL_categoria, "Categoria")
                consulta.SelCampo(Marcas.MAR_Nombre, "Marca", Palets_lineas.PLL_idmarca)
                consulta.SelCampo(Palets_lineas.PLL_bultos, "Bultos")
                consulta.SelCampo(Palets_lineas.PLL_kilosnetos, "Kilos")
                consulta.SelCampo(Palets_lineas.PLL_Controlado, "Controlado")
                consulta.WheCampo(AlbSalida_Palets.ASP_IdAlbaran, "=", IdAlbaran.ToString)
                Dim sql As String = consulta.SQL
                sql = sql + " order by PAL_Palet, PLL_idlinea"



                Dim dt As DataTable = Palets.MiConexion.ConsultaSQL(sql)

                Grid.DataSource = dt
                AjustaColumnas(bPalet)

                GridView1.ExpandAllGroups()

            End If

        End If



    End Sub


    Private Sub AjustaColumnas(bPalet As Boolean)

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDLINEA", "IDPALET"
                    c.Visible = False
                Case "PALET"

                    If bPalet Then
                        c.GroupIndex = -1
                    Else
                        c.GroupIndex = 1
                    End If
                    c.Visible = False

            End Select
        Next


        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                'Case "PRESENTACION"
                '    c.Width = 400
                'Case "CATEGORIA", "MARCA"
                '    c.Width = 150
                Case "KILOS", "BULTOS"
                    c.Width = 100
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
            End Select
        Next


        AñadeResumenCampo("Bultos", "{0:n0}")
        AñadeResumenCampo("Kilos", "{0:n0}")


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


        Lbejer.Text = MiMaletin.Ejercicio.ToString
        LbPuntoVenta.Text = MiMaletin.IdPuntoVenta.ToString

        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        If PuntoVenta.LeerId(LbPuntoVenta.Text) Then
            LbNomPv.Text = PuntoVenta.Nombre.Valor
        End If

        LbNumAlb.Text = ""
        LbCliAlb.Text = ""
        LbNomTipoPalet.Text = ""


        Grid.DataSource = Nothing

    End Sub


    Private Sub TxPalet_Valida(edicion As System.Boolean) Handles TxPalet.Valida

        BorraDatos(True)


        Dim IdCentro As Integer = 0
        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        If PuntoVenta.LeerId(LbPuntoVenta.Text) Then
            IdCentro = VaInt(PuntoVenta.IdCentro.Valor)
        End If


        Dim IdPalet = Palets.Leerpalet(VaInt(Lbejer.Text), VaInt(LbPuntoVenta.Text), VaInt(TxPalet.Text))
        If VaInt(IdPalet) > 0 Then
            CargaDatosPalet(Palets)
        End If


    End Sub


    Private Sub CargaDatosPalet(Palets As E_palets)

        Lbejer.Text = Palets.PAL_campa.Valor
        LbPuntoVenta.Text = Palets.PAL_idpuntoventa.Valor

        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        If PuntoVenta.LeerId(LbPuntoVenta.Text) Then
            LbNomPv.Text = PuntoVenta.Nombre.Valor
        End If

        LbFecha.Text = Palets.PAL_fecha.Valor


        LbNumAlb.Text = ""
        LbCliAlb.Text = ""
        NumeroAlbaran(Palets.PAL_idpalet.Valor)

        LbNomTipoPalet.Text = ""
        NombreConfecPalet(Palets.PAL_idtipopalet.Valor)


        CargaGrid(True)

    End Sub


    Private Sub BorraDatos(bPalet As Boolean)

        Lbejer.Text = MiMaletin.Ejercicio.ToString
        LbPuntoVenta.Text = MiMaletin.IdPuntoVenta.ToString

        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        If PuntoVenta.LeerId(LbPuntoVenta.Text) Then
            LbNomPv.Text = PuntoVenta.Nombre.Valor
        End If

        LbFecha.Text = ""
        LbNumAlb.Text = ""
        LbCliAlb.Text = ""
        LbNomTipoPalet.Text = ""

        Grid.DataSource = Nothing

        If bPalet Then
            TxAlbaran.Text = ""
            LbFechaAlbaran.Text = ""
        Else
            TxPalet.Text = ""
            LbFecha.Text = ""
            LbNumAlb.Text = ""
            LbNomTipoPalet.Text = ""
        End If


    End Sub


    Private Sub NumeroAlbaran(IdPalet As String)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlbSalida_Palets.ASP_IdAlbaran)
        consulta.SelCampo(AlbSalida.ASA_albaran, "Albaran", AlbSalida_Palets.ASP_IdAlbaran)
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", AlbSalida.ASA_idcliente)
        consulta.WheCampo(AlbSalida_Palets.ASP_Idpalet, "=", IdPalet)

        Dim sql As String = consulta.SQL

        Dim dt As DataTable = AlbSalida_Palets.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                LbNumAlb.Text = dt.Rows(0)("Albaran").ToString
                LbCliAlb.Text = dt.Rows(0)("Cliente").ToString
            End If
        End If


    End Sub


    Private Sub NombreConfecPalet(IdTipPalet As String)

        If VaInt(IdTipPalet) > 0 Then

            Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)
            If ConfecPalet.LeerId(IdTipPalet) Then
                LbNomTipoPalet.Text = ConfecPalet.CPA_Nombre.Valor
            End If

        End If

    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

        If Not IsNothing(row) Then

            Dim IdLinea As String = (row("IdLinea").ToString & "").Trim
            Dim bLineaControlada As Boolean = ((row("Controlado").ToString & "").Trim = "S")

            MuestraTrazabilidad(IdLinea, bLineaControlada)

        End If

    End Sub


    Private Sub MuestraTrazabilidad(IdLinea As String, bLineaControlada As Boolean)

        Dim frm As New FrmDesgloseTrazabilidadPalet(bLineaControlada)
        frm.init(IdLinea)
        frm.ShowDialog()

    End Sub


    Private Sub TxAlbaran_Valida(edicion As System.Boolean) Handles TxAlbaran.Valida

        BorraDatos(False)


        Dim IdCentro As Integer = 0
        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        If PuntoVenta.LeerId(LbPuntoVenta.Text) Then
            IdCentro = VaInt(PuntoVenta.IdCentro.Valor)
        End If


        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
        Dim IdAlbaran As Integer = AlbSalida.LeerAlb(VaInt(Lbejer.Text), IdCentro, VaInt(TxAlbaran.Text))
        If VaInt(IdAlbaran) > 0 Then
            CargaDatosAlbaran(AlbSalida)
        End If

    End Sub



    Private Sub CargaDatosAlbaran(AlbSalida As E_AlbSalida)

        Lbejer.Text = AlbSalida.ASA_ejercicio.Valor
        LbPuntoVenta.Text = AlbSalida.ASA_idpuntoventa.Valor

        Dim PuntoVenta As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
        If PuntoVenta.LeerId(LbPuntoVenta.Text) Then
            LbNomPv.Text = PuntoVenta.Nombre.Valor
        End If

        LbFechaAlbaran.Text = AlbSalida.ASA_fechasalida.Valor

        LbNumAlb.Text = ""
        LbCliAlb.Text = ""
        If Clientes.LeerId(AlbSalida.ASA_idcliente.Valor) Then
            LbCliAlb.Text = Clientes.CLI_Nombre.Valor
        End If

        LbNomTipoPalet.Text = ""

        CargaGrid(False)

    End Sub

End Class