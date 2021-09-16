Public Class FrmClaveBloqueoImportaciones

    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro


    Public Enum ResultadoClave
        Correcta
        Incorrecta
        Bloqueado
        BloqueoCancelado
    End Enum


    Private _Bloquear As Boolean = False
    Private _IdAlbEntrada As String = ""

    Private _Resultado As ResultadoClave = ResultadoClave.Incorrecta
    Public ReadOnly Property Resultado As ResultadoClave
        Get
            Return _Resultado
        End Get
    End Property



    Private ValoraImportaciones As New E_ValoraImportaciones(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Public Sub New(IdAlbEntrada As String, bBloquear As Boolean)

        Me.New()

        _IdAlbEntrada = IdAlbEntrada
        _Bloquear = bBloquear


        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim cl As New Cdatos.PropiedadesTx
        cl.CampoBd = ValoraImportaciones.VAI_ClaveBloqueo
        cl.Tipo = Cdatos.TiposCampo.Cadena
        cl.Longitud = ValoraImportaciones.VAI_ClaveBloqueo.Longitud
        'cl.Obligatorio = True

        TxDato1.Orden = 0
        TxDato1.ClParam = cl

        TxDato1.ClForm = Me
        Lb1.CL_ControlAsociado = TxDato1
        Lb1.CL_ValorFijo = True

    End Sub


    Private Sub TxDato1_Valida(edicion As System.Boolean) Handles TxDato1.Valida

        Dim ValoraImportaciones As New E_ValoraImportaciones(Idusuario, cn)
        If ValoraImportaciones.LeerId(_IdAlbEntrada) Then


            If _Bloquear Then

                'Bloquea
                _Resultado = ResultadoClave.Bloqueado

                ValoraImportaciones.VAI_CerradoSN.Valor = "S"
                ValoraImportaciones.VAI_ClaveBloqueo.Valor = TxDato1.Text
                ValoraImportaciones.Actualizar()

            Else
                If EncuentraClave() Then

                    'Desbloquea
                    _Resultado = ResultadoClave.Correcta

                    ValoraImportaciones.VAI_CerradoSN.Valor = "N"
                    ValoraImportaciones.VAI_ClaveBloqueo.Valor = ""
                    ValoraImportaciones.Actualizar()

                Else
                    _Resultado = ResultadoClave.Incorrecta
                End If
            End If

            Me.Close()

        Else
            MsgBox("Error al leer del albaran de entrada")
        End If


    End Sub


    Private Function EncuentraClave() As Boolean

        Dim bRes As Boolean = False

        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(ValoraImportaciones.VAI_IdAlbEntrada, "IdAlbaran")
        CONSULTA.WheCampo(ValoraImportaciones.VAI_IdAlbEntrada, "=", _IdAlbEntrada)
        CONSULTA.WheCampo(ValoraImportaciones.VAI_ClaveBloqueo, "=", TxDato1.Text)

        Dim dt As DataTable = ValoraImportaciones.MiConexion.ConsultaSQL(CONSULTA.SQL)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                bRes = True
            End If
        End If


        Return bRes

    End Function

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        _Resultado = ResultadoClave.BloqueoCancelado
        Me.Close()

    End Sub

    Private Sub TxDato1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato1.KeyDown

        If e.KeyCode = Keys.F2 Then
            _Resultado = ResultadoClave.BloqueoCancelado
            Me.Close()
        End If

    End Sub

    Private Sub FrmClaveBloqueoImportaciones_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        TxDato1.Select()
        TxDato1.Focus()

    End Sub
End Class