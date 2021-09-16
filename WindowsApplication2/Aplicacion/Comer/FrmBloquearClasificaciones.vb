Public Class FrmBloqueoClasificaciones

    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro

    Private ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
    Private AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent()
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim cl As New Cdatos.PropiedadesTx
        cl.Tipo = Cdatos.TiposCampo.Fecha
        cl.Longitud = AlbEntrada.AEN_Fecha.Longitud


        cl.Obligatorio = True

        TxFecha.Orden = 0
        TxFecha.ClParam = cl
        TxFecha.ClForm = Me

        Lb1.CL_ControlAsociado = TxFecha
        Lb1.CL_ValorFijo = True

    End Sub


    Private Sub FrmBloquearClasificaciones_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim bloqueo As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.FECHA_BLOQUEO_CLASIFICACIONES)
        If VaDate(bloqueo) > VaDate("") Then
            TxFecha.Text = VaDate(bloqueo).ToString("dd/MM/yyyy")
        End If

        TxFecha.Select()
        TxFecha.Focus()

    End Sub


    Private Sub btQuitarBloqueo_Click(sender As System.Object, e As System.EventArgs) Handles btQuitarBloqueo.Click

        TxFecha.Text = ""
        ActualizaBloqueo("")
        MsgBox("Bloqueo quitado")

    End Sub


    Private Sub btValidar_Click(sender As System.Object, e As System.EventArgs) Handles btAceptar.Click

        ActualizaBloqueo(TxFecha.Text)

    End Sub


    Private Sub ActualizaBloqueo(valor As String)

        If Not TxFecha.MiError Then

            If Not ConfigDiv.xExisteClave(E_ConfiguracionesDiversas.eClaves.FECHA_BLOQUEO_CLASIFICACIONES, 0, 0, 0) Then
                ConfigDiv = New E_ConfiguracionesDiversas(Idusuario, cn)
                ConfigDiv.Id.Valor = ConfigDiv.MaxId
                ConfigDiv.Clave.Valor = E_ConfiguracionesDiversas.eClaves.FECHA_BLOQUEO_CLASIFICACIONES.ToString
                ConfigDiv.Valor.Valor = valor
                ConfigDiv.Insertar()
            Else

                Dim Id As String = ConfigDiv.xLeerIdClave(E_ConfiguracionesDiversas.eClaves.FECHA_BLOQUEO_CLASIFICACIONES.ToString, 0, 0, 0)
                If Id > 0 Then
                    If ConfigDiv.LeerId(Id) Then
                        ConfigDiv.Valor.Valor = valor
                        ConfigDiv.Actualizar()
                    End If

                End If

            End If


            Me.Close()

        End If


    End Sub



    Private Sub btSalir_Click(sender As System.Object, e As System.EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub


    Private Sub TxFecha_Valida(edicion As System.Boolean) Handles TxFecha.Valida
        If edicion Then
            btAceptar.Select()
            btAceptar.Focus()
        End If
    End Sub

    
End Class