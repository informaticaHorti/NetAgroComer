Public Class FrmSerieNumeroFactura


    Private Facturas As E_Facturas = Nothing
    Private err As New Errores
    Public ErrorGrave As Boolean = False

    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub


    Public Sub New(serie As String, nfactura As Integer, Factura As E_Facturas, fecha As String)

        Me.New()

        If IsNothing(Factura) Then
            err.Muestraerror("Se paso una factura vacía", "FrmSerieNumeroFactura.New", "Factura vacía con serie-numero: " & serie & "-" & nfactura.ToString)
            ErrorGrave = True
            Exit Sub
        End If

        If Not IsNothing(serie) Then TxSerie.Text = serie
        If nfactura > -1 Then TxFactura.Text = nfactura.ToString
        If Not IsNothing(fecha) Then TxFecha.Text = fecha

        Me.Facturas = Factura


        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim param As New Cdatos.PropiedadesTx
        param.CampoBd = Facturas.FRA_serie
        param.Tipo = Facturas.FRA_serie.TipoBd
        param.Longitud = Facturas.FRA_serie.Longitud
        param.Obligatorio = True

        TxSerie.Orden = 0
        TxSerie.ClParam = param
        TxSerie.ClForm = Me


        param = New Cdatos.PropiedadesTx
        param.CampoBd = Facturas.FRA_factura
        param.Tipo = Facturas.FRA_factura.TipoBd
        param.Longitud = Facturas.FRA_factura.Longitud
        param.Exclusivos = "0123456789"
        param.Obligatorio = False

        TxFactura.Orden = 1
        TxFactura.ClParam = param
        TxFactura.ClForm = Me


        param = New Cdatos.PropiedadesTx
        param.CampoBd = Facturas.FRA_fecha
        param.Tipo = Facturas.FRA_fecha.TipoBd
        param.Longitud = Facturas.FRA_fecha.Longitud
        param.Obligatorio = True

        TxFecha.Orden = 1
        TxFecha.ClParam = param
        TxFecha.ClForm = Me


    End Sub


    Private Sub BtAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BtAceptar.Click

        'Comprueba que no existe la serie y el número de factura
        Dim bValido As Boolean = True
        Dim Fra As New E_Facturas(Idusuario, cn)

        Dim NumeroCandidato As String = Fra.LeerFac(MiMaletin.IdEmpresaCTB, Facturas.FRA_campa.Valor, TxSerie.Text, VaInt(TxFactura.Text))
        If VaInt(NumeroCandidato) > 0 Then
            MsgBox("La factura con serie y número: " & TxSerie.Text & " - " & TxFactura.Text & " ya existe para la campaña " & Facturas.FRA_campa.Valor)
            bValido = False
        End If

        If IsDate(TxFecha.Text) = False Then
            MsgBox("Fecha no valida")
            bValido = False
        End If
        If bValido Then
            CrearFactura(TxSerie.Text, VaInt(TxFactura.Text), Facturas, TxFecha.Text)
            Me.Close()
        End If

    End Sub


    Private Sub CrearFactura(serie As String, nfactura As Integer, Facturas As E_Facturas, fecha As String)

        If Not IsNothing(Facturas) Then

            Dim idfactura As Integer = Facturas.MaxId
            If nfactura = 0 Then nfactura = Facturas.MaxIdCampa(MiMaletin.IdEmpresaCTB, MiMaletin.Ejercicio, serie)


            Facturas.FRA_idfactura.Valor = idfactura.ToString
            Facturas.FRA_serie.Valor = serie
            Facturas.FRA_factura.Valor = nfactura
            Facturas.FRA_fecha.Valor = fecha
            Facturas.Insertar()



            RowDePaso = Nothing
            If VaInt(idfactura) > 0 Then
                Dim dt As DataTable = Facturas.MiConexion.ConsultaSQL("SELECT * FROM Facturas WHERE FRA_IdFactura = " & idfactura)
                If dt.Rows.Count > 0 Then
                    RowDePaso = dt.Rows(0)
                End If
            End If

        End If


    End Sub


    Private Sub TxFactura_Valida(edicion As System.Boolean) Handles TxFactura.Valida

        If edicion Then
            If Not TxFactura.MiError Then
                BtAceptar.Select()
                BtAceptar.Focus()
            End If
        End If

    End Sub

    Private Sub TxSerie_Valida(edicion As System.Boolean) Handles TxSerie.Valida

        If edicion Then
            If Not TxSerie.MiError Then
                TxFactura.Select()
                TxFactura.Focus()
            End If
        End If

    End Sub

    Private Sub FrmSerieNumeroFactura_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        If TxSerie.Text.Trim <> "" Then
            BtAceptar.Select()
            BtAceptar.Focus()
        Else
            TxSerie.Select()
            TxSerie.Focus()
        End If

    End Sub

    Private Sub BtAceptar_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles BtAceptar.KeyDown

        If e.KeyCode = Keys.Up Then
            TxFactura.Select()
            TxFactura.Focus()
        End If

    End Sub

    Private Sub TxFactura_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxFactura.KeyDown

        If e.KeyCode = Keys.Up Then
            TxSerie.Select()
            TxSerie.Focus()
        End If

    End Sub

    Private Sub TxFactura_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxFactura.TextChanged

    End Sub
End Class