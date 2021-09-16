
Public Class FrmExtractoEnvases

    Inherits FrConsulta

    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Tsujeto As String
    Dim _Inicial As Integer
    Dim _InicialV As Integer
    Dim _Saldo As Integer
    Dim _SaldoV As Integer


    Public Sub InitDatos(ByVal TipoSujeto As String, ByVal Codigo As String, ByVal Nombre As String, ByVal idenvase As String, ByVal NombreEnvase As String, ByVal dfecha As String, ByVal hfecha As String, ByVal inicial As Double, ByVal inicialv As Double, ByVal final As Double, ByVal finalv As Double)
        Tsujeto = TipoSujeto
        Select Case TipoSujeto
            Case "A"
                LbTipo.Text = "Agricultores"
            Case "C"
                LbTipo.Text = "CLIENTES"

        End Select

        LbCodigo.Text = Codigo
        LbNombre.Text = Nombre
        LbEnvase.Text = idenvase
        LbNomEnvase.Text = NombreEnvase
        LbDfecha.Text = dfecha
        LbHfecha.Text = hfecha
        _Inicial = inicial
        _InicialV = inicialv
        _Saldo = final
        _SaldoV = finalv
        LbSaldoini.Text = StSaldo(inicial)
        LbSaldoiniV.Text = StSaldo(inicialv)
        LbSaldoFin.Text = StSaldo(final)

        LbSaldoFinV.Text = StSaldo(finalv)
        Me.Text = "Movimiento envases: " + NombreEnvase + " de " + Nombre

    End Sub
    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(ByVal Titulo As String)

        Me.New()

        Me.Text = Titulo

    End Sub



    Public Overrides Sub Consultar()

        MyBase.Consultar()

        Dim Valeenvase As New E_ValeEnvases(Idusuario, cn)
        Dim Valeenvase_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
        Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
        Dim Consulta As New Cdatos.E_select
        Dim DT As New DataTable
        Dim sql As String

        Consulta.SelCampo(Valeenvase_lineas.VEL_Id, "Id")
        Consulta.SelCampo(Valeenvase.VEV_Idvale, "IdVale", Valeenvase_lineas.VEL_idvale)
        'Consulta.SelCampo(Valeenvase.VEV_Operacion, "tipovale")
        Consulta.SelCampo(Valeenvase.VEV_Fecha, "Fecha")
        'Consulta.SelCampo(AlmacenEnvases.AEV_Nombre, "Almacen", Valeenvase_lineas.VEL_idalmacen)
        Consulta.SelCampo(Valeenvase.VEV_Idcentro, "CE")
        Consulta.SelCampo(Valeenvase_lineas.VEL_idalmacen, "AL")
        Consulta.SelCampo(Valeenvase.VEV_Operacion, "TV")
        Consulta.SelCampo(Valeenvase.VEV_Numero, "Numero")
        Consulta.SelCampo(Valeenvase.VEV_Referencia, "Referencia")
        Consulta.SelCampo(Valeenvase.VEV_Concepto, "Concepto")
        Consulta.SelCampo(Valeenvase_lineas.VEL_retira, "Retira")
        Consulta.SelCampo(Valeenvase_lineas.VEL_precioretira, "PrecioR")
        Consulta.SelCampo(Valeenvase_lineas.VEL_entrega, "Entrega")
        Consulta.SelCampo(Valeenvase_lineas.VEL_precioentrega, "PrecioE")
        Consulta.WheCampo(Valeenvase.VEV_TipoSujeto, "=", Tsujeto)
        Consulta.WheCampo(Valeenvase.VEV_Codigo, "=", LbCodigo.Text)
        Consulta.WheCampo(Valeenvase_lineas.VEL_idenvase, "=", LbEnvase.Text)
        Consulta.WheCampo(Valeenvase.VEV_Fecha, ">=", LbDfecha.Text)
        Consulta.WheCampo(Valeenvase.VEV_Fecha, "<=", LbHfecha.Text)
        sql = Consulta.SQL
        sql = sql + " order by VEV_fecha"
        DT = Valeenvase.MiConexion.ConsultaSQL(sql)

        Dim Saldo As Integer = _Inicial
        Dim SaldoV As Integer = _InicialV
        DT.Columns.Add(New DataColumn("Saldo", GetType(String)))
        DT.Columns.Add(New DataColumn("SaldoV", GetType(String)))

        DT.Rows.Add(0, 0, LbDfecha.Text, 0, 0, "", 0, "", "Saldo Inicial", 0, 0, 0, 0, StSaldo(Saldo), StSaldo(SaldoV))
        Dim DV As New DataView(DT)
        DV.Sort = "FECHA,NUMERO"
        DT = DV.ToTable

        For Each row As DataRow In DT.Rows
            If VaDec(row("PrecioR")) = 0 Then
                Saldo = Saldo + VaDec(row("retira"))
            Else
                SaldoV = SaldoV + VaDec(row("retira"))
            End If
            If VaDec(row("PrecioE")) = 0 Then
                Saldo = Saldo - VaDec(row("entrega"))
            Else
                SaldoV = SaldoV - VaDec(row("entrega"))
            End If
            row("Saldo") = StSaldo(Saldo)
            row("SaldoV") = StSaldo(SaldoV)
        Next


        Grid.DataSource = DT
        GridView1.BestFitColumns()
        AjustaColumnas()

        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Entrega", "{0:n0}")
        AñadeResumenCampo("Retira", "{0:n0}")



    End Sub

    Private Sub AjustaColumnas()

        Try

            For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

                Select Case c.FieldName.ToUpper.Trim
                    Case "ID", "IDVALE", "TIPOVALE"

                        c.Visible = False

                        '                    Case "INICIALVALORADO", "RETIRAVALORADO", "ENTREGAVALORADO", "SALDOVALORADO"
                        '                        c.Width = 75

                    Case "CONCEPTO"
                        c.Width = 200
                        c.MaxWidth = 200

                    Case "PRECIOR", "PRECIOE"
                        c.Width = 50
                        c.MaxWidth = 50
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,###0.00"



                    Case "RETIRA", "ENTREGA"
                        c.Width = 50
                        c.MaxWidth = 50
                        c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        c.DisplayFormat.FormatString = "#,###"

                    Case "SALDO", "SALDOV"
                        c.Width = 50
                        c.MaxWidth = 50
                        c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far


                    Case "CE", "TV", "AL"
                        c.Width = 40
                        c.MaxWidth = 40
                    Case "NUMERO", "FECHA", "REFERENCIA"
                        c.Width = 100
                        c.MaxWidth = 100

                End Select

            Next

            'AñadeResumenCampo("Importe", "{0:n2}")


        Catch ex As Exception
            MsgBox("error")
        End Try


    End Sub



    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub

    Private Sub FrmExtractoEnvases_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Consultar()
    End Sub
 

    Private Sub FrmExtractoEnvases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Overrides Sub GridClik(ByVal row As System.Data.DataRow, ByVal column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)
        Dim I As Integer = 0

        I = VaInt(row("idvale"))
        If I > 0 Then
            Dim fr As New FrmValeEnvase(row("tv").ToString)
            'fr.InitTipoVale(row("tipovale"))
            fr.init(I.ToString)
            fr.ShowDialog()
        End If


    End Sub

End Class