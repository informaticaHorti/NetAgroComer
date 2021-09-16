Imports DevExpress.XtraEditors


Public Class FrmCartelones

    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro



    Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
    Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
    Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
    Dim CategoriaComercial As New E_CategoriasComercial(Idusuario, cn)
    Dim Palet As New E_palets(Idusuario, cn)
    Dim Pedidos As New E_Pedidos(Idusuario, cn)
    Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)



    Private _IdLineaPalet As String = ""
    Private _IdLineaPedido As String = ""


    Dim fuente_presentacion As New Font("Arial Narrow", 30, FontStyle.Bold)
    Dim fuente_categoria As New Font("Tahoma", 45, FontStyle.Bold)
    Dim fuente_fechasalida As New Font("Tahoma", 40)
    Dim fuente_fechaconfeccion As New Font("Tahoma", 40)
    Dim fuente_bultos As New Font("Tahoma", 45, FontStyle.Bold)



    
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub InitPalet(IdLinea As String)

        _IdLineaPalet = IdLinea

    End Sub


    Public Sub InitPedido(IdLinea As String)

        _IdLineaPedido = IdLinea

    End Sub


    Private Sub ParametrosFrm()

        Dim param As Cdatos.PropiedadesTx

        'Presentacion
        param = New Cdatos.PropiedadesTx
        param.Tipo = Cdatos.TiposCampo.Cadena
        param.Longitud = 100
        TxPresentacion.Orden = 0
        TxPresentacion.ClParam = param
        TxPresentacion.ClForm = Me

        'Categoria
        param = New Cdatos.PropiedadesTx
        param.Tipo = Cdatos.TiposCampo.Cadena
        param.Longitud = 100
        TxCategoria.Orden = 1
        TxCategoria.ClParam = param
        TxCategoria.ClForm = Me

        'Fecha salida
        param = New Cdatos.PropiedadesTx
        param.Tipo = Cdatos.TiposCampo.Cadena
        param.Longitud = 100
        TxFechaSalida.Orden = 2
        TxFechaSalida.ClParam = param
        TxFechaSalida.ClForm = Me

        'Fecha confeccion
        param = New Cdatos.PropiedadesTx
        param.Tipo = Cdatos.TiposCampo.Cadena
        param.Longitud = 100
        TxFechaConfeccion.Orden = 3
        TxFechaConfeccion.ClParam = param
        TxFechaConfeccion.ClForm = Me

        'Bultos
        param = New Cdatos.PropiedadesTx
        param.Tipo = Cdatos.TiposCampo.Cadena
        param.Longitud = 100
        TxBultos.Orden = 4
        TxBultos.ClParam = param
        TxBultos.ClForm = Me


        'Nº copias
        param = New Cdatos.PropiedadesTx
        param.Obligatorio = True
        param.Tipo = Cdatos.TiposCampo.EnteroPositivo
        param.Longitud = 3
        param.Exclusivos = "0123456789"

        TxCopias.Orden = 5
        TxCopias.ClParam = param
        TxCopias.ClForm = Me

    End Sub


    Private Sub frmCartelones_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Borrapan()


        Dim copias As Integer = VaInt(ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.COPIAS_POR_DEFECTO_CARTELONES))
        If copias = 0 Then copias = 1


        CargaDatos()


        FontDialog1.Font = fuente_presentacion
        FontDialog2.Font = fuente_categoria
        FontDialog3.Font = fuente_fechasalida
        FontDialog4.Font = fuente_fechaconfeccion
        FontDialog5.Font = fuente_bultos


        ToolTip1.SetToolTip(btFuentePresentacion, "Cambiar fuente")
        ToolTip1.SetToolTip(btFuentePresentacion, "Cambiar fuente")
        ToolTip1.SetToolTip(btFuentePresentacion, "Cambiar fuente")
        ToolTip1.SetToolTip(btFuentePresentacion, "Cambiar fuente")
        ToolTip1.SetToolTip(btFuentePresentacion, "Cambiar fuente")


        TxCopias.Text = copias.ToString
        TxCopias.Select()
        TxCopias.Focus()


    End Sub


    Private Sub CargaDatos()

        If VaInt(_IdLineaPalet) > 0 Then

            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(Palets_Lineas.PLL_bultos, "Bultos")
            consulta.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", Palets_Lineas.PLL_idgensal)
            consulta.SelCampo(CategoriasSalida.CAS_CategoriaCalibre, "Categoria", Palets_Lineas.PLL_idcategoria)
            consulta.SelCampo(Pedidos_Lineas.PEL_idpedido, "IdPedido", Palets_Lineas.PLL_idpedidolinea)
            consulta.SelCampo(Pedidos.PED_fechasalida, "FechaSalida", Pedidos_Lineas.PEL_idpedido)
            consulta.SelCampo(Palet.PAL_fecha, "FechaConfeccion", Palets_Lineas.PLL_idpalet)
            consulta.WheCampo(Palets_Lineas.PLL_idlinea, "=", _IdLineaPalet)

            Dim sql As String = consulta.SQL


            Dim dt As DataTable = Palets_Lineas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    TxPresentacion.Text = (dt.Rows(0)("Presentacion"))
                    TxCategoria.Text = (dt.Rows(0)("Categoria"))
                    If VaDate(dt.Rows(0)("FechaSalida")) > VaDate("") Then TxFechaSalida.Text = "Salida: " & VaDate(dt.Rows(0)("FechaSalida")).ToString("dd/MM/yyyy")
                    If VaDate(dt.Rows(0)("FechaConfeccion")) > VaDate("") Then TxFechaConfeccion.Text = "Confección: " & VaDate(dt.Rows(0)("FechaConfeccion")).ToString("dd/MM/yyyy")
                    TxBultos.Text = VaInt(dt.Rows(0)("Bultos")) & " Bultos"

                End If
            End If

        ElseIf VaInt(_IdLineaPedido) Then

            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(Pedidos_Lineas.PEL_bultospalet, "Bultos")
            consulta.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", Pedidos_Lineas.PEL_idgensal)
            consulta.SelCampo(CategoriaComercial.CAC_Nombre, "Categoria", Pedidos_Lineas.PEL_idcategoria)
            consulta.SelCampo(Pedidos.PED_fechasalida, "FechaSalida", Pedidos_Lineas.PEL_idpedido)
            'consulta.SelCampo(New Cdatos.bdcampo("@'" & VaDate("") & "'", Cdatos.TiposCampo.Fecha, Pedidos.PED_fechasalida.Longitud), "FechaConfeccion")
            consulta.WheCampo(Pedidos_Lineas.PEL_idlinea, "=", _IdLineaPedido)

            Dim sql As String = consulta.SQL


            Dim dt As DataTable = Pedidos_Lineas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    TxPresentacion.Text = (dt.Rows(0)("Presentacion"))
                    TxCategoria.Text = (dt.Rows(0)("Categoria"))
                    If VaDate(dt.Rows(0)("FechaSalida")) > VaDate("") Then TxFechaSalida.Text = "Salida: " & VaDate(dt.Rows(0)("FechaSalida")).ToString("dd/MM/yyyy")
                    'If VaDate(dt.Rows(0)("FechaConfeccion")) > VaDate("") Then TxFechaConfeccion.Text = VaDate(dt.Rows(0)("FechaConfeccion")).ToString("dd/MM/yyyy")
                    TxFechaConfeccion.Text = "Confeccion: " & Now.ToString("dd/MM/yyyy")
                    TxBultos.Text = VaInt(dt.Rows(0)("Bultos")) & " Bultos"

                End If
            End If


        End If

    End Sub


    Private Sub BtAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BtAceptar.Click

        If VaInt(TxCopias.Text) <= 0 Then
            MsgBox("Debe introducir un número de copias a imprimir")
            Exit Sub
        End If


        If XtraMessageBox.Show("¿Desea imprimir el cartelón?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            C1_ImprimirCartelon(TxPresentacion.Text, TxCategoria.Text, TxFechaSalida.Text, TxFechaConfeccion.Text, TxBultos.Text,
                            FontDialog1.Font, FontDialog2.Font, FontDialog3.Font, FontDialog4.Font, FontDialog5.Font,
                            TipoImpresion.ImpresoraPorDefecto, VaInt(TxCopias.Text))

        End If

    End Sub



    Private Sub btCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub


    Private Sub Borrapan()


    End Sub


    Private Sub TxPresentacion_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxPresentacion.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            TxCategoria.Select()
            TxCategoria.Focus()
        End If
    End Sub

    Private Sub TxCategoria_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxCategoria.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            TxFechaSalida.Select()
            TxFechaSalida.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            TxPresentacion.Select()
            TxPresentacion.Focus()
        End If
    End Sub

    Private Sub TxFechaSalida_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxFechaSalida.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            TxFechaConfeccion.Select()
            TxFechaConfeccion.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            TxCategoria.Select()
            TxCategoria.Focus()
        End If
    End Sub

    Private Sub TxFechaConfeccion_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxFechaConfeccion.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            TxBultos.Select()
            TxBultos.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            TxFechaSalida.Select()
            TxFechaSalida.Focus()
        End If
    End Sub

    Private Sub TxBultos_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxBultos.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            TxCopias.Select()
            TxCopias.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            TxFechaConfeccion.Select()
            TxFechaConfeccion.Focus()
        End If
    End Sub



    Private Sub TxCopias_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxCopias.KeyDown

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            BtAceptar.Select()
            BtAceptar.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            TxBultos.Select()
            TxBultos.Focus()
        End If

    End Sub

    Private Sub ClButton1_Click(sender As System.Object, e As System.EventArgs) Handles ClButton1.Click

        If VaInt(TxCopias.Text) <= 0 Then
            MsgBox("Debe introducir un número de copias a imprimir")
            Exit Sub
        End If


        C1_ImprimirCartelon(TxPresentacion.Text, TxCategoria.Text, TxFechaSalida.Text, TxFechaConfeccion.Text, TxBultos.Text,
                            FontDialog1.Font, FontDialog2.Font, FontDialog3.Font, FontDialog4.Font, FontDialog5.Font,
                            TipoImpresion.Preliminar, 0)

    End Sub


    Private Sub btFuentePresentacion_Click(sender As System.Object, e As System.EventArgs) Handles btFuentePresentacion.Click
        FontDialog1.ShowDialog()
    End Sub

    Private Sub btFuenteCategoria_Click(sender As System.Object, e As System.EventArgs) Handles btFuenteCategoria.Click
        FontDialog2.ShowDialog()
    End Sub

    Private Sub btFuenteFechaSalida_Click(sender As System.Object, e As System.EventArgs) Handles btFuenteFechaSalida.Click
        FontDialog3.ShowDialog()
    End Sub

    Private Sub btFuenteFechaConfeccion_Click(sender As System.Object, e As System.EventArgs) Handles btFuenteFechaConfeccion.Click
        FontDialog4.ShowDialog()
    End Sub

    Private Sub btFuenteBultos_Click(sender As System.Object, e As System.EventArgs) Handles btFuenteBultos.Click
        FontDialog5.ShowDialog()
    End Sub
End Class