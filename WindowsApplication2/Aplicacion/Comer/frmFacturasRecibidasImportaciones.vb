

Public Class frmFacturasRecibidasImportaciones

    Private _IdFactura As String = ""
    Private _bExistente As Boolean = False


    Private FacturasRecibidasImportaciones As New E_FacturasRecibidasImportaciones(Idusuario, cn)
    Private Cuentas As New E_Cuentas(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Private CuentaSuplido As New E_Cuentas(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))

    Private TipoIvaSoportado As New E_TipoIvaSoportado(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))

    Dim err As New Errores



    Dim bCargado As Boolean = False


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub



    Public Sub New(IdFactura As String)
        Me.New()

        _IdFactura = IdFactura

        If VaInt(IdFactura) > 0 Then
            If FacturasRecibidasImportaciones.LeerId(IdFactura) Then
                _bExistente = True
            End If
        End If

        'Entidad_a_Datos()


    End Sub

    Public Sub New(importacion As E_FacturasRecibidasImportaciones)
        Me.New()

        'EntidadFrm = importacion

        For indice As Integer = 0 To FacturasRecibidasImportaciones.MiListadeCampos.Count - 1
            FacturasRecibidasImportaciones.MiListadeCampos(indice).Valor = importacion.MiListadeCampos(indice).Valor
        Next

        Entidad_a_Datos()

        _IdFactura = importacion.FRI_idfactura.Valor


    End Sub



    Private Sub ParametrosFrm()

        EntidadFrm = FacturasRecibidasImportaciones
        ListaControles = New List(Of Object)


        ParamTx(TxDato_1, FacturasRecibidasImportaciones.FRI_idfactura, Lb1)
        ParamTx(TxDato_2, FacturasRecibidasImportaciones.FRI_idcuenta, Lb2, , Cdatos.TiposCampo.Cuenta)
        ParamCbFIJO(CbTipoId, FacturasRecibidasImportaciones.FRI_TipoIdentificacion, Combos.ComboTipoIdentificacion, LbTipoId)
        ParamTx(TxPais, FacturasRecibidasImportaciones.FRI_CodigoPais, LbPais)
        ParamTx(TxNIF, FacturasRecibidasImportaciones.FRI_nif, Lb3, True)
        ParamTx(TxDato_4, FacturasRecibidasImportaciones.FRI_IdTipoIva, Lb4, True)
        ParamTx(TxDato_5, FacturasRecibidasImportaciones.FRI_Base, Lb5)
        ParamTx(TxDato_6, FacturasRecibidasImportaciones.FRI_PorcentajeIva, Lb6)
        ParamTx(TxDato_7, FacturasRecibidasImportaciones.FRI_CuotaIva, Lb7)
        ParamTx(TxDato_8, FacturasRecibidasImportaciones.FRI_Concepto, Lb8, True)
        ParamTx(TxDato_9, FacturasRecibidasImportaciones.FRI_Documento, Lb9, True)
        ParamTx(TxDato_10, FacturasRecibidasImportaciones.FRI_BaseSuplido, Lb10)
        ParamTx(TxDato_11, FacturasRecibidasImportaciones.FRI_CuentaSuplido, Lb11, , Cdatos.TiposCampo.Cuenta)


        AsociarControles(TxDato_2, BtBusca_2, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lb_2)

        AsociarControles(TxDato_4, BtBusca_4, TipoIvaSoportado.btBusca, TipoIvaSoportado, TipoIvaSoportado.Nombre, Lb_4)
        AsociarControles(TxDato_11, BtBusca_11, CuentaSuplido.btBusca, CuentaSuplido, CuentaSuplido.Nombre, Lb_11)


    End Sub


    Public Overrides Sub ControlClave()

        ' componemos la clave
        LbId.Text = TxDato_1.Text


    End Sub


    Public Overrides Sub Guardar()

        If TxDato_1.Text = "+" Then
            Datos_a_Entidad()
        Else
            FacturasRecibidasImportaciones.FRI_idfactura.Valor = LbId.Text
        End If

        EntidadDePaso = FacturasRecibidasImportaciones

        'If _IdFactura.Trim <> "" Then
        If VaInt(FacturasRecibidasImportaciones.FRI_idfactura.Valor) > 0 Then
            MyBase.Guardar()
        End If


        'TODO: Verificar si aún existe la entidad después de guardar (con IdFactura)
        Me.Close()

    End Sub



    Private Sub frmFacturasRecibidasImportaciones_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        InicioFrm()


        bCargado = True


        'If _IdFactura.Trim = "" Then
        If VaInt(_IdFactura) = 0 Then

            Button1.Visible = False
            BAnular.Visible = False
            BModificar.Visible = False

            TxDato_1.Text = _IdFactura
            TxDato_1.Validar(True)
            Siguiente(TxDato_1.Orden)

        Else

            BorraPan()

            TxDato_1.Text = _IdFactura
            TxDato_1.Validar(True)
            Siguiente(TxDato_1.Orden)

        End If


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
    End Sub


    Private Sub btSumar_Click(sender As System.Object, e As System.EventArgs) Handles btSumar.Click

        Dim sumador As New Sumador(TxDato_5)
        sumador.ShowDialog()

    End Sub

    Private Sub TxDato_4_Valida(edicion As System.Boolean) Handles TxDato_4.Valida

        If edicion Then
            If TxDato_4.Text <> "" Then
                If TipoIvaSoportado.LeerId(TxDato_4.Text) Then
                    TxDato_6.Text = TipoIvaSoportado.Iva1.Valor
                End If
            End If

        End If

    End Sub

    Private Sub TxDato_6_Valida(edicion As System.Boolean) Handles TxDato_6.Valida

        If edicion Then
            Dim iva As Decimal = 0

            Dim base As Decimal = VaDec(TxDato_5.Text)

            If VaDec(base) <> 0 Then
                If VaDec(TxDato_6.Text) <> 0 Then
                    iva = VaDec(TxDato_6.Text) / 100
                    TxDato_7.Text = (iva * base).ToString("#,0.00")
                    TxDato_7.Validar(True)
                End If
            Else
                TxDato_7.Text = "0"
                TxDato_7.Validar(True)

            End If
        End If

    End Sub


    Private Sub TxDato_2_Valida(edicion As System.Boolean) Handles TxDato_2.Valida

        If edicion Then

            Dim Cuenta As New E_Cuentas(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
            If Cuenta.LeerId(TxDato_2.Text) Then
                TxNIF.Text = Cuenta.Nif.Valor
                TxNIF.Validar(True)
            End If

        End If

    End Sub

    Public Overrides Sub Anular()
        MyBase.Anular()

        Me.Close()
    End Sub

   
    Private Sub TxDato_5_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato_5.KeyDown
        If e.KeyCode = Keys.F2 Then
            btSumar.PerformClick()
        End If
    End Sub


    Private Sub cbTipoId_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbTipoId.SelectedIndexChanged

        If bCargado Then

            Dim valor As Integer = cbTipoId.SelectedValue()
            If valor = 2 Then
                TxPais.Enabled = False
                TxPais.ClParam.Obligatorio = False
            Else
                TxPais.Enabled = True
                TxPais.ClParam.Obligatorio = True
            End If

        End If


    End Sub


    Private Sub cbTipoId_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbTipoId.KeyDown

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then


            Dim valor As Integer = cbTipoId.SelectedValue()
            If valor = 2 Then
                TxPais.Enabled = False
                TxPais.ClParam.Obligatorio = False
                TxNIF.Select()
                TxNIF.Focus()
            Else
                TxPais.Enabled = True
                TxPais.ClParam.Obligatorio = True
                TxPais.Select()
                TxPais.Focus()
            End If


        End If

    End Sub

End Class
