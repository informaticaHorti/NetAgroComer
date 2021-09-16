Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrintingLinks

Public Class FrmEmitirCarta346


    Inherits FrConsulta

    Dim Agricultor As New E_Agricultores(Idusuario, cn)
    Dim Fichero346 As New E_Fichero346(Idusuario, cn)
    Dim Conceptos346 As New E_Conceptos346(Idusuario, cn)
    Dim Ejercicios As New E_Ejercicios(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))

    Dim err As New Errores

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub

    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxEjercicio, Ejercicios.IdEjercicio, LbEjercicio, True)
        ParamTx(TxAgricultorDesde, Agricultor.AGR_IdAgricultor, LbDesdeAgricultor)
        ParamTx(TxAgricultorHasta, Agricultor.AGR_IdAgricultor, LbHastaAgricultor)

        AsociarControles(TxEjercicio, BtEjercicio, Ejercicios.btBusca, Ejercicios)

        AsociarControles(TxAgricultorDesde, BtBuscaAgricultorDesde, Agricultor.btBusca, Agricultor, Agricultor.AGR_Nombre, LbNomAgricultorDesde)
        AsociarControles(TxAgricultorHasta, BtBuscaAgricultorHasta, Agricultor.btBusca, Agricultor, Agricultor.AGR_Nombre, LbNomAgricultorHasta)

    End Sub

    Private Sub FrmConsultaSalidas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False
        PlantillaConsulta1.Visible = False

    End Sub

    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        TxEjercicio.Text = MiMaletin.Ejercicio.ToString

    End Sub

    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "POBLACION", "CPOSTAL", "CONCEPTO", "CLAVE", "TIPO"
                    c.Visible = False


                Case "IMPORTE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,###0.00"

            End Select

        Next

        GridView1.BestFitColumns()

        AñadeResumenCampo("Importe", "{0:n2}")

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()



        Dim dt As DataTable = Fichero346.DtRegistros(VaInt(TxEjercicio.Text), MiMaletin.IdEmpresaCTB, VaInt(TxAgricultorDesde.Text), VaInt(TxAgricultorHasta.Text))
        Grid.DataSource = dt
        AjustaColumnas()


    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()



    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        OpenFileDialog1.Filter = "*.rtf|*.rtf"
        OpenFileDialog1.Title = "Fichero de plantilla"
        OpenFileDialog1.FileName = ""

        If TxNombreFichero.Text.Contains("\") Then
            Dim carpeta As String = TxNombreFichero.Text.Substring(0, TxNombreFichero.Text.LastIndexOf("\"))
            If IO.File.Exists(TxNombreFichero.Text) Then
                OpenFileDialog1.InitialDirectory = carpeta
            End If
        End If

        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName <> "" Then
            TxNombreFichero.Text = OpenFileDialog1.FileName
            RichTextBox1.LoadFile(TxNombreFichero.Text)

            RichTextBox1.ZoomFactor = 0.5

        End If

    End Sub

    Private Function GenerarCartas(ByVal dt As DataTable) As List(Of RichTextBox)


        Dim lstRtf As New List(Of RichTextBox)


        Try

            'Carga el rtf
            Dim rtf As RichTextBox = RichTextBox1
            rtf.SelectAll()
            Dim s As String = rtf.SelectedRtf

            For Each row As DataRow In dt.Rows

                Dim Agricultor As String = row("Agricultor").ToString
                Dim Nif As String = row("Nif").ToString
                Dim Importe As String = row("Importe").ToString


                Dim NuevaLinea As String = s

                NuevaLinea = NuevaLinea.Replace("@@NOMBRE", Agricultor)
                NuevaLinea = NuevaLinea.Replace("@@NIF", Nif)
                NuevaLinea = NuevaLinea.Replace("@@IMPORTE", Importe)

                Application.DoEvents()

                'Crea un rtf con las líneas corregidas
                Dim rtfDestino As RichTextBox = New RichTextBox
                rtfDestino.Rtf = NuevaLinea
                lstRtf.Add(rtfDestino)

            Next


        Catch ex As Exception
            err.Muestraerror("Error al generar las cartas del modelo 346", "GenerarCartas", ex.Message)
        End Try


        Return lstRtf


    End Function

    Public Overrides Sub Imprimir()
        'MyBase.Imprimir()


        'Comprueba que hallamos intrucido el fichero de plantilla y que éste exista
        If TxNombreFichero.Text.Trim <> "" Then

            If Not IO.File.Exists(TxNombreFichero.Text) Then
                XtraMessageBox.Show("El fichero de plantilla no existe")
                Exit Sub
            End If

        Else
            XtraMessageBox.Show("Debe especificar un fichero de plantilla en formato .rtf", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        Dim bDatos As Boolean = True

        If TypeOf Grid.DataSource Is DataTable Then

            If Not IsNothing(Grid.DataSource) Then


                'Genera el informe y le añade como subinformes todos los ficheros rtf
                Dim MiInforme As New miInforme(False)

                MiInforme.Contenedor.Margins = New System.Drawing.Printing.Margins(100, 100, 100, 100)
                'MiInforme.Contenedor.PaperKind = Printing.PaperKind.A4
                If Not IsNothing(MiInforme.Contenedor.PageHeaderFooter) Then CType(MiInforme.Contenedor.PageHeaderFooter, DevExpress.XtraPrinting.PageHeaderFooter).Footer.Content.Clear()

                Dim dt As DataTable = CType(Grid.DataSource, DataTable)
                Dim lstRtf As List(Of RichTextBox) = GenerarCartas(dt)

                For Each rtf As RichTextBox In lstRtf

                    'Añade rtf a PrtSystem
                    Dim rtfLink As New RichTextBoxLink(prtSystem)
                    rtfLink.RichTextBox = New RichTextBox
                    rtfLink.RichTextBox = rtf
                    MiInforme.AñadeDetalles(rtfLink)

                Next

                MiInforme.Preliminar(DevExpress.LookAndFeel.UserLookAndFeel.Default)
                'MiInforme.Finalizar()

            Else
                bDatos = False
            End If

        Else
            bDatos = False
        End If


        If bDatos Then
        Else
            XtraMessageBox.Show("No hay nada que imprimir")
        End If


    End Sub


End Class