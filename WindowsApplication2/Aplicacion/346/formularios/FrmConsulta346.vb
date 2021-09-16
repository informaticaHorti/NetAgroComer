Public Class FrmConsulta346


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
        AsociarControles(TxEjercicio, BtEjercicio, Ejercicios.btBusca, Ejercicios)
    End Sub

   



    Private Sub FrmConsultaSalidas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        BInforme.Visible = False

        'GridView1.OptionsView.ShowGroupPanel = False
        'GridView1.OptionsBehavior.Editable = False
        'GridView1.OptionsView.ColumnAutoWidth = True

    End Sub



    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        TxEjercicio.Text = MiMaletin.Ejercicio.ToString
    End Sub









    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim



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


     
        Dim dt As DataTable = Fichero346.DtRegistros(VaInt(TxEjercicio.Text), MiMaletin.IdEmpresaCTB, 0, 0)
        Grid.DataSource = dt
        AjustaColumnas()


    End Sub

   


    Public Overrides Sub Informe()
        MyBase.Informe()



    End Sub


End Class