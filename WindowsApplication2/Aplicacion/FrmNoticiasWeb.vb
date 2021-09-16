Public Class FrmNoticiasWeb
    Inherits FrMantenimiento


    Dim NoticiasWeb As New E_NoticiasWeb(Idusuario, cn)
    Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)


    Dim _directorio_defecto As String = ""


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub



    Private Sub ParametrosFrm()
        EntidadFrm = NoticiasWeb


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxId, NoticiasWeb.NWB_Id, Lb1, True)
        TxId.Autonumerico = True
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxFecha, NoticiasWeb.NWB_Fecha, LbFecha, True)
        ParamTx(TxTitular, NoticiasWeb.NWB_Titular, LbTitular, True)
        ParamTx(TxAdjunto, NoticiasWeb.NWB_Adjunto, LbAdjunto)
        ParamTx(TxNoticia, NoticiasWeb.NWB_Noticia, LbNoticia)

        AsociarControles(TxId, BtBuscaNoticias, NoticiasWeb.btBusca, EntidadFrm)

        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub


    Private Sub FrmNoticiasWeb_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        _directorio_defecto = (ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_ADJUNTOS_NOTICIAS) & "").Trim


    End Sub


    Public Overrides Sub ControlClave()

        ' componemos la clave
        LbId.Text = TxId.Text


    End Sub


    Public Overrides Sub Guardar()

        If TxId.Text = "+" Then
            LbId.Text = NoticiasWeb.MaxId
            TxId.Text = LbId.Text
        End If

        'NoticiasWeb.NWB_Adjunto.Valor = TxAdjunto.Text


        MyBase.Guardar()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
    End Sub



    Private Sub BtAdjunto_Click(sender As System.Object, e As System.EventArgs) Handles BtAdjunto.Click

        ObtenerFichero()

    End Sub


    Private Sub ObtenerFichero()


        If _directorio_defecto.Trim <> "" Then

            Dim ruta As String = _directorio_defecto & "\"

            If IO.Directory.Exists(ruta) Then
                dOpenFile.InitialDirectory = ruta
            Else
                MsgBox("No se encuentra la carpeta de noticias " & _directorio_defecto)
                Exit Sub
            End If
        Else
            MsgBox("No se encuentra la carpeta de noticias " & _directorio_defecto)
            Exit Sub
        End If


        dOpenFile.FileName = ""
        dOpenFile.Filter = "ficheros pdf (*.pdf)|*.pdf"
        dOpenFile.ShowDialog()

        If dOpenFile.FileName.Trim <> "" Then

            Try

                IO.File.Copy(dOpenFile.FileName, _directorio_defecto & "\" & dOpenFile.SafeFileName, True)

                Dim fichero As String = dOpenFile.SafeFileName
                TxAdjunto.Text = fichero
                TxAdjunto.Select()
                TxAdjunto.Focus()

            Catch ex As Exception
                MsgBox("Error al copiar el adjunto de noticas con destino " & _directorio_defecto & "\" & dOpenFile.SafeFileName)
            End Try

            
        End If


    End Sub


    
    Private Sub TxAdjunto_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxAdjunto.KeyDown

        If e.KeyCode = Keys.F2 Then
            ObtenerFichero()
        End If

    End Sub
End Class