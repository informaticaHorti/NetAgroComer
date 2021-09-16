Public Class FrmTransportistas

    Inherits FrMantenimiento

    Dim Pais As New E_Paises(Idusuario, CnComun)
    Dim NifDelegaciones As New E_NifDelegaciones(Idusuario, CnComun)
    Dim NifMail As New E_NifMail(Idusuario, CnComun)
    Dim Transportistas As New E_Transportistas(Idusuario, cn)


    Dim Primero As Boolean




    Private Sub TxDato3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxDato3.GotFocus
        'If TxDato3.Text <> "" Then
        ' TxDato2.Focus()
        ' End If
    End Sub



    Private Sub TxDato3_Valida(ByVal edicion As Boolean) Handles TxDato3.Valida

   

    End Sub
  
    Private Sub CargaDelegaciones()
        Dim dt As New DataTable
        Dim sql As String
        sql = "Select iddelegacion,nombre,domicilio,poblacion,provincia,telefono1,telefono2,fax,idpais from delegaciones where nif='" + TxDato3.Text + "' order by iddelegacion"

        dt = NifDelegaciones.MiConexion.ConsultaSQL(sql)
        GridDelegaciones.DataSource = dt

        GridViewDelegaciones.BestFitColumns()
    End Sub
    Private Sub CargaContactos()
        Dim dt As New DataTable
        Dim sql As String
        sql = "Select iddelegacion,nombre,email,personacontacto,movil,cargo,idproceso from mailnif where nif='" + TxDato3.Text + "' order by iddelegacion"

        dt = NifMail.MiConexion.ConsultaSQL(sql)
        GridContactos.DataSource = dt

        GridViewContactos.BestFitColumns()
    End Sub
    Public Overrides Sub borrapan()
        MyBase.BorraPan()
        GridContactos.DataSource = Nothing
        GridDelegaciones.DataSource = Nothing

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        ParametrosFrm()
    End Sub


    Private Sub parametrosfrm()
        EntidadFrm = Transportistas


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Transportistas.TTA_IdTransportista, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato3, Transportistas.TTA_Nif, Lb3)
        ParamTx(TxDato2, Transportistas.TTA_Nombre, Lb2)

        ParamCb_Copia(CbTipoPorte, Transportistas.TTA_TipoPorte, Lb7, Combos.ComboTipoPorte)


        AsociarControles(TxDato1, BtBuscaTransportista, Transportistas.btBusca, EntidadFrm)


        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


        GridViewDelegaciones.OptionsView.ShowGroupPanel = False
        GridViewDelegaciones.OptionsBehavior.Editable = False
        GridViewDelegaciones.OptionsView.ColumnAutoWidth = True

        GridViewContactos.OptionsView.ShowGroupPanel = False
        GridViewContactos.OptionsBehavior.Editable = False
        GridViewContactos.OptionsView.ColumnAutoWidth = True



    End Sub


    Protected Overrides Sub BModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MyBase.BModificar_Click(sender, e)
        TxDato3.Enabled = False
        TxDato2.Focus()
    End Sub

End Class