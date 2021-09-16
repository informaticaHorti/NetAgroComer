

Public Class Sumador
    Inherits Form


    Private _TxDato As TxDato
    Private _dt As DataTable
    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub CargaGrid()

        Me.ControlGrid.DataSource = _dt

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In Grid.Columns

            Select Case c.FieldName.ToUpper
                Case "DATO"
                    c.Width = 120
                    c.Caption = "Total"
                    c.SummaryItem.DisplayFormat = "{0:n2}"
                    c.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,###.00;-#,###.00; "
                Case Else
                    c.Width = 0

            End Select

        Next

        TxDato_1.Text = ""

    End Sub


    Public Sub New(Tx As TxDato)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()


        _TxDato = Tx
        _dt = New DataTable

        TxDato_1.ClForm = Me
        TxDato_1.ClParam = New Cdatos.PropiedadesTx
        TxDato_1.ClParam.Tipo = Cdatos.TiposCampo.Importe
        TxDato_1.ClParam.Longitud = 10
        TxDato_1.ClParam.Decimales = 2
        'TxDato_1.ClParam.Obligatorio = True
        TxDato_1.Orden = 1

    End Sub

    Private Sub TxDato_1_Valida(ByVal edicion As System.Boolean) Handles TxDato_1.Valida
        If edicion = True Then

            If TxDato_1.Text.Trim = "" Then
                Me.Close()
            End If

            _dt.Rows.Add(VaDec(TxDato_1.Text))
            CargaGrid()
        End If
    End Sub



    Private Sub clSumaElementos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        _dt.Columns.Add("Dato", GetType(System.Decimal))
        Me.Text = ""

    End Sub


    Private Sub Sumador_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        If _TxDato IsNot Nothing Then

            Dim suma As Decimal = 0
            For Each dr As DataRow In _dt.Rows
                suma = suma + VaDec(dr(0))
            Next

            If suma > 0 Then
                _TxDato.Text = suma.ToString("#,0.00")
            End If


        End If

    End Sub

    
End Class
