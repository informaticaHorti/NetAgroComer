Public Class FrmDesbloquearLinea

    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro



    Dim Lineas As New E_Lineas(Idusuario, cn)
    Dim BloqueoLineaFecha As New E_BloqueoLineaFecha(Idusuario, cn)
    Dim Usuarios As New E_Usuarios(Idusuario, CnComun)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim cl As New Cdatos.PropiedadesTx
        cl.CampoBd = BloqueoLineaFecha.BLF_Fecha
        cl.Tipo = Cdatos.TiposCampo.Fecha
        cl.Longitud = BloqueoLineaFecha.BLF_Fecha.Longitud
        cl.Obligatorio = True

        TxFecha.Orden = 0
        TxFecha.ClParam = cl
        TxFecha.ClForm = Me
        LbFecha.CL_ControlAsociado = TxFecha


        cl = New Cdatos.PropiedadesTx
        cl.CampoBd = BloqueoLineaFecha.BLF_IdUsuario
        cl.Tipo = Cdatos.TiposCampo.EnteroPositivo
        cl.Longitud = BloqueoLineaFecha.BLF_IdUsuario.Longitud

        TxUsuario.Orden = 1
        TxUsuario.ClParam = cl
        TxUsuario.ClForm = Me
        LbUsuario.CL_ControlAsociado = TxUsuario

        AsociarControles(TxUsuario, BtBuscaUsuario, Usuarios.btBusca, Usuarios, Usuarios.Nombre, LbNomUsuario)


    End Sub


    Public Sub AsociarControles(ByRef tx As TxDato, ByRef boconsu As BtBusca, ByVal Origen As BtBusca, ByVal Tabla As Cdatos.Entidad,
                                Optional ByVal Campo As Cdatos.bdcampo = Nothing, Optional ByVal Etiq As Lb = Nothing,
                                Optional TextoToolTip As String = "Búsqueda alfabética")

        If Not boconsu Is Nothing Then

            If Not Origen Is Nothing Then
                boconsu.Image = Origen.Image
                boconsu.CL_CampoOrden = Origen.CL_CampoOrden
                boconsu.CL_DevuelveCampo = Origen.CL_DevuelveCampo
                boconsu.CL_ConsultaSql = Origen.CL_ConsultaSql
                boconsu.cl_formu = Origen.cl_formu
                boconsu.CL_ch1000 = Origen.CL_ch1000
                boconsu.cl_ListaW = Origen.cl_ListaW
                boconsu.CL_BuscaAlb = Origen.CL_BuscaAlb
                boconsu.CL_campocodigo = Origen.CL_campocodigo
                boconsu.CL_camponombre = Origen.CL_camponombre
                boconsu.CL_dfecha = Origen.CL_dfecha
                boconsu.CL_hfecha = Origen.CL_hfecha
                boconsu.CL_ParamBusqueda = Origen.CL_ParamBusqueda
                boconsu.CL_xCentro = Origen.CL_xCentro
                boconsu.CL_EsId = Origen.CL_EsId
                boconsu.CL_Ancho = Origen.CL_Ancho
                boconsu.CL_CONSULTA = Origen.CL_CONSULTA

            End If

            tx.ClParam.BtBusca = boconsu
            boconsu.CL_ControlAsociado = tx
            boconsu.CL_Entidad = Tabla

        End If


        If Not Campo Is Nothing Then

            tx.ClParam.CampoEnlace = Campo
            tx.ClParam.Entidadenlace = Tabla
            tx.ClParam.LabelEnlace = Etiq

            If Not IsNothing(Etiq) Then
                Etiq.CL_ValorFijo = False
                Etiq.CL_ControlAsociado = tx
            End If

        End If

    End Sub


    Private Sub FrmDesbloquearLinea_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        'Carga líneas
        Dim sql = "Select LIN_IdLinea as Id, LIN_nombre as Nombre from Lineas order by LIN_Nombre"
        Dim dt = Lineas.MiConexion.ConsultaSQL(sql)

        CbLineas.Properties.DataSource = dt
        CbLineas.Properties.ValueMember = "Id"
        CbLineas.Properties.DisplayMember = "Nombre"

        TxFecha.Text = Today.ToString("dd/MM/yyyy")

    End Sub


    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click

        Me.Close()

    End Sub


    Private Sub BGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BGuardar.Click

        Dim lst As List(Of String) = ListadeCombo(CbLineas)

        If VaDate(TxFecha.Text) > VaDate("") Then

            Dim sql As String = "DELETE FROM BloqueoLineaFecha " & vbCrLf
            sql = sql & " WHERE BLF_Fecha = '" & TxFecha.Text & "' " & vbCrLf
            If TxUsuario.Text.Trim <> "" Then sql = sql & " AND BLF_IdUsuario = " & TxUsuario.Text & vbCrLf
            sql = sql & CadenaWhereLista(BloqueoLineaFecha.BLF_IdLinea, lst, " AND ")

            BloqueoLineaFecha.MiConexion.OrdenSql(sql)


            MsgBox("Terminado!")

            For Each it As DevExpress.XtraEditors.Controls.CheckedListBoxItem In CbLineas.Properties.GetItems()
                it.CheckState = CheckState.Unchecked
            Next


        End If



    End Sub


    
    Private Sub CbLineas_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbLineas.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CbLineas.IsPopupOpen Then
                CbLineas.ClosePopup()
            Else
                TxFecha.Select()
                TxFecha.Focus()
            End If
        End If
    End Sub


    Private Sub TxFecha_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxFecha.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            TxUsuario.Select()
            TxUsuario.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            TxFecha.Select()
            TxFecha.Focus()
        End If
    End Sub


    Private Sub TxUsuario_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxUsuario.KeyDown

        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            BGuardar.Select()
            BGuardar.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            TxFecha.Select()
            TxFecha.Focus()
        End If

    End Sub
End Class