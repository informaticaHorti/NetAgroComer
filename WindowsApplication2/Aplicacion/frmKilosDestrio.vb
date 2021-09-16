Imports DevExpress.XtraEditors


Public Class frmKilosDestrio

    Public Enum ResultadoFormulario
        Aceptar
        Cancelar
    End Enum

    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro


    Private Produccion As New E_Produccion(Idusuario, cn)


    Private _IdProduccion As String = ""

    Private _Resultado As ResultadoFormulario = ResultadoFormulario.Cancelar
    Public ReadOnly Property Resultado As ResultadoFormulario
        Get
            Return _Resultado
        End Get
    End Property

    Private _KilosDestrio As Integer = 0
    Public ReadOnly Property KilosDestrio As Integer
        Get
            Return _KilosDestrio
        End Get
    End Property



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()


    End Sub


    Public Sub New(Id As String, Fecha As String, Tipo As String, Numero As String, Genero As String, Consumido As Integer, Inicio As String, Final As String, Destrio As Integer)
        Me.New()

        _IdProduccion = Id


        LbFecha.Text = Fecha
        LbTipo.Text = Tipo
        LbNumero.Text = Numero
        LbGenero.Text = Genero
        LbConsumido.Text = Consumido.ToString("#,##0")
        LbInicio.Text = Inicio
        LbFin.Text = Final

        TxKilosDestrio.Text = Destrio.ToString

    End Sub


    Private Sub ParametrosFrm()

        Dim param As New Cdatos.PropiedadesTx
        param.Obligatorio = True

        param.CampoBd = Produccion.PRD_KilosDestrio
        param.Tipo = Produccion.PRD_KilosDestrio.TipoBd
        param.Longitud = Produccion.PRD_KilosDestrio.Longitud
        param.Exclusivos = "0123456789"

        TxKilosDestrio.Orden = 0
        TxKilosDestrio.ClParam = param
        TxKilosDestrio.ClForm = Me

    End Sub


    Private Sub frmNuevaLineaProduccion_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        TxKilosDestrio.Select()
        TxKilosDestrio.Focus()

    End Sub


    Private Sub BtAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BtAceptar.Click


        If VaInt(LbConsumido.Text) < VaInt(TxKilosDestrio.Text) Then
            MsgBox("No puede haber más destrío que kilos consumidos")
            Exit Sub
        End If



        If XtraMessageBox.Show("¿Está seguro de que desea cambiar el destrio?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim Produccion As New E_Produccion(Idusuario, cn)
            If Produccion.LeerId(_IdProduccion) Then

                Produccion.PRD_KilosDestrio.Valor = TxKilosDestrio.Text
                Produccion.Actualizar()

                _Resultado = ResultadoFormulario.Aceptar
                _KilosDestrio = VaInt(TxKilosDestrio.Text)

            Else
                MsgBox("Error al leer el Id de producción")
            End If

            Me.Close()

        End If

    End Sub



    Private Sub btCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub




    Private Sub TxKilosDestrio_Valida(edicion As System.Boolean) Handles TxKilosDestrio.Valida

        If VaInt(LbConsumido.Text) < VaInt(TxKilosDestrio.Text) Then
            MsgBox("No puede haber más destrío que kilos consumidos")
            TxKilosDestrio.MiError = True
        Else
            TxKilosDestrio.MiError = False
            BtAceptar.Select()
            BtAceptar.Focus()
        End If

    End Sub


    Private Sub TxKilosDestrio_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxKilosDestrio.TextChanged

        Dim porcentaje As Decimal = 0

        Dim destrio As Integer = VaInt(TxKilosDestrio.Text)
        Dim consumidos As Integer = VaInt(LbConsumido.Text)

        If consumidos <> 0 Then porcentaje = destrio / consumidos

        LbPorcentaje.Text = porcentaje.ToString("P")

    End Sub

End Class