Public Class FrmDocumentosBancos
    Inherits FrMantenimiento


    Dim Bancos As New E_Bancos(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim DocumentosBancos As New E_DocumentosBancos(Idusuario, cn)
    Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)


    Private _directorio_defecto As String = ""



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Private Sub ParametrosFrm()
        EntidadFrm = Bancos


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxBanco, Bancos.IdBanco, LbBanco, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxAlias, DocumentosBancos.DDB_Alias, LbAlias, True)
        ParamTx(TxNombreArchivo, DocumentosBancos.DDB_Archivo, LbNombreArchivo, True)
        ParamTx(TxTipoDocumento, DocumentosBancos.DDB_TipoDocumento, LbTipoDocumento, True)



        AsociarControles(TxBanco, BtBuscaBanco, Bancos.btBusca, EntidadFrm)


        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


        AsociarGrid(ClGrid1, TxAlias, TxTipoDocumento, DocumentosBancos)

        PropiedadesCamposGr(ClGrid1, DocumentosBancos.DDB_Id.NombreCampo, "", False, 0)
        PropiedadesCamposGr(ClGrid1, "Alias", "Alias", True, 50)
        PropiedadesCamposGr(ClGrid1, "TipoDocumento", "Documento", True, 50)
        PropiedadesCamposGr(ClGrid1, "Archivo", "Archivo", True, 50)


    End Sub


    Private Sub FrmCrecogida_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        _directorio_defecto = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CARPETA_DOCUMENTOS_BANCARIOS)


    End Sub


    Public Overrides Sub ControlClave()

        ' componemos la clave
        LbId.Text = TxBanco.Text

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Lb_NombreBanco.Text = ""
        Lb_NumeroCuenta.Text = ""

    End Sub


    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()

        Lb_NombreBanco.Text = Bancos.Nombre.Valor
        Lb_NumeroCuenta.Text = Bancos.Numerocuenta.Valor


        CargaLineasGrid()

    End Sub


    Private Sub CargaLineasGrid()

        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim sql As String
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(DocumentosBancos.DDB_Id)
        consulta.SelCampo(DocumentosBancos.DDB_Alias, "Alias")
        consulta.SelCampo(DocumentosBancos.DDB_TipoDocumento, "Documento")
        consulta.SelCampo(DocumentosBancos.DDB_Archivo, "Archivo")
        consulta.WheCampo(DocumentosBancos.DDB_IdBanco, "=", TxBanco.Text)

        sql = consulta.SQL
        ClGrid1.Consulta = sql
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean

        DocumentosBancos.DDB_IdBanco.Valor = TxBanco.Text

        Return MyBase.GuardarLineas(Gr)

    End Function



    Private Sub TxNombreArchivo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxNombreArchivo.KeyDown
        If TxNombreArchivo.Enabled Then
            If e.KeyCode = Keys.F2 Then
                btArchivo.PerformClick()
            End If
        End If
    End Sub


    Private Sub btArchivo_Click(sender As System.Object, e As System.EventArgs) Handles btArchivo.Click

        ObtenerFichero()

    End Sub


    Private Sub ObtenerFichero()


        If _directorio_defecto.Trim <> "" Then

            Dim ruta As String = Application.StartupPath & "\" & _directorio_defecto & "\"

            If IO.Directory.Exists(ruta) Then
                dOpenFile.InitialDirectory = ruta
            Else
                MsgBox("No se encuentra la carpeta de documentos " & _directorio_defecto)
                Exit Sub
            End If
        Else
            MsgBox("No se encuentra la carpeta de documentos " & _directorio_defecto)
            Exit Sub
        End If


        dOpenFile.FileName = ""
        dOpenFile.Filter = "ficheros xml (*.xml)|*.xml"
        dOpenFile.ShowDialog()

        If dOpenFile.FileName.Trim <> "" Then

            Dim fichero As String = dOpenFile.SafeFileName
            TxNombreArchivo.Text = fichero

            TxTipoDocumento.Select()
            TxTipoDocumento.Focus()

        End If


    End Sub


    Public Overrides Sub Anular()
        'MyBase.Anular()

        If VaInt(LbId.Text) Then


            Dim DocumentosBancos As New E_DocumentosBancos(Idusuario, cn)

            'Borrar los documentos del banco, no el banco
            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(DocumentosBancos.DDB_Id, "Id")
            CONSULTA.WheCampo(DocumentosBancos.DDB_IdBanco, "=", LbId.Text)




            Dim dt As DataTable = DocumentosBancos.MiConexion.ConsultaSQL(CONSULTA.SQL)
            If Not IsNothing(dt) Then

                For Each row As DataRow In dt.Rows
                    Dim Id As String = (row("Id").ToString & "").Trim
                    If DocumentosBancos.LeerId(Id) Then
                        DocumentosBancos.Eliminar()
                    End If
                Next

            End If


        End If

    End Sub

    
End Class