Public Class FrmIntroducirLote


    Public Enum Resultado
        Aceptar
        Cancelar
    End Enum

    Private _ResultadoFormulario As Resultado = Resultado.Cancelar
    Public ReadOnly Property ResultadoFormulario As Resultado
        Get
            Return _ResultadoFormulario
        End Get
    End Property



    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro


    Private Palets As New E_palets(Idusuario, cn)
    Private _IdPalet As String = ""
    Private _Lote As String = ""


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub


    Public Sub New(IdPalet As String, Lote As String)
        Me.New()

        ParametrosFrm()

        _IdPalet = IdPalet
        _Lote = Lote

    End Sub


    Private Sub ParametrosFrm()

        Dim param As New Cdatos.PropiedadesTx
        param.CampoBd = Palets.PAL_Lote
        param.Tipo = Palets.PAL_Lote.TipoBd
        param.Longitud = Palets.PAL_Lote.Longitud
        param.Obligatorio = True

        TxLote.Orden = 0
        TxLote.ClParam = param
        TxLote.ClForm = Me

    End Sub


    Private Sub FrmSerieNumeroFactura_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        TxLote.Text = _Lote

        TxLote.Select()
        TxLote.Focus()

    End Sub


    Private Sub BtAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BtAceptar.Click

        TxLote.Validar(False)
        If Not TxLote.MiError Then

            Dim Palet As New E_palets(Idusuario, cn)
            If Palet.LeerId(_IdPalet) Then

                Palet.PAL_Lote.Valor = TxLote.Text
                Palet.Actualizar()

                _ResultadoFormulario = Resultado.Aceptar

                Me.Close()

            Else
                MsgBox("Error al leer el palet con Id: " & _IdPalet)
            End If

        End If

    End Sub


    Private Sub btSalir_Click(sender As System.Object, e As System.EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub


    Private Sub TxLote_Valida(edicion As System.Boolean) Handles TxLote.Valida
        If edicion Then
            If Not TxLote.MiError Then
                BtAceptar.Select()
                BtAceptar.Focus()
            End If
        End If
    End Sub


End Class