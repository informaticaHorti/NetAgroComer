
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls




Public Class FrmConsultaReclamaciones

    Inherits FrConsulta






    Dim Clientes As New E_Clientes(Idusuario, cn)
    Dim Reclama As New E_Reclama(Idusuario, cn)
    Dim Reclama_origen As New E_Reclama_origen(Idusuario, cn)
    Dim Reclama_resolucion As New E_Reclama_resolucion(Idusuario, cn)
    Dim Albsalida As New E_AlbSalida(Idusuario, cn)
    Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Subfamilias As New E_Subfamilias(Idusuario, cn)




    Dim err As New Errores



    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato_10, Clientes.CLI_Codigo, Lb_10)
        ParamTx(TxDato_11, Clientes.CLI_Codigo, Lb_11)
        ParamTx(TxDato3, Albsalida.ASA_fechasalida, Lb5)
        ParamTx(TxDato4, Albsalida.ASA_fechasalida, Lb6)

        AsociarControles(TxDato_10, BtBusca_10, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lbnom_10)
        AsociarControles(TxDato_11, BtBusca_11, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, Lbnom_11)
        CargaComboCentros()
        CargaComboOrigen()
        CargaComboSolucion()
        CbFamilias = ComboFamilias(CbFamilias)

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub FrmConsultaReclamaciones_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)


        GridView1.Appearance.GroupRow.Font = nueva_fuente

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxDato3.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato4.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim Consulta As New Cdatos.E_select
        Dim DT As New DataTable
        Dim sql As String
        Dim WHE As String

        GridView1.Columns.Clear()


        Consulta.SelCampo(Reclama.RCL_Idreclama, "idreclama")
        Consulta.SelCampo(Albsalida_lineas.ASL_idalbaran, "idalbaran", Reclama.RCL_Idlinalb)
        Consulta.SelCampo(Albsalida.ASA_albaran, "Albaran", Albsalida_lineas.ASL_idalbaran)
        Consulta.SelCampo(Albsalida.ASA_fechasalida, "FechaSalida")
        Consulta.SelCampo(Albsalida.ASA_idcliente, "Codigo")
        Consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", Albsalida.ASA_idcliente)
        Consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albsalida_lineas.ASL_idgenero)
        Consulta.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", Albsalida_lineas.ASL_idgensal)
        Consulta.SelCampo(Subfamilias.SFA_idfamilia, "idfamilia", Generos.GEN_IdsubFamilia)
        Consulta.SelCampo(Centros.Nombre, "Centro", Reclama.RCL_Idcentro)
        Consulta.SelCampo(Reclama.RCL_Numero)
        Consulta.SelCampo(Reclama.RCL_Fecha, "Fecha")
        Consulta.SelCampo(Reclama.RCL_importeestimado, "Estimado")
        Consulta.SelCampo(Reclama.RCL_importe, "Real")
        Consulta.SelCampo(Reclama.RCL_bultosestimados, "BultosReclamados")
        Consulta.SelCampo(Reclama_origen.RCO_Nombre, "Origen", Reclama.RCL_idorigen)
        Consulta.SelCampo(Reclama_resolucion.RCS_Nombre, "Solucion", Reclama.RCL_idresolucion)

        Consulta.WheCampo(Reclama.RCL_Fecha, ">=", TxDato3.Text)
        Consulta.WheCampo(Reclama.RCL_Fecha, "<=", TxDato4.Text)

        If TxDato_10.Text <> "" Then
            Consulta.WheCampo(Albsalida.ASA_idcliente, ">=", TxDato_10.Text)
        End If

        If TxDato_11.Text <> "" Then
            Consulta.WheCampo(Albsalida.ASA_idcliente, "<=", TxDato_11.Text)
        End If

        If RbNoValorados.Checked = True Then
            Consulta.WheCampo(Reclama.RCL_fechareal, "=", "01/01/1900")
        End If

        If RbValorados.Checked = True Then
            Consulta.WheCampo(Reclama.RCL_fechareal, "<>", "01/01/1900")
        End If

        If RbSolucinadosSI.Checked = True Then
            Consulta.WheCampo(Reclama.RCL_idresolucion, ">", "0")
        End If

        If RbSolucionadosNO.Checked = True Then
            Consulta.WheCampo(Reclama.RCL_idresolucion, "=", "0")
        End If

        WHE = Consulta.Whe

        WHE = WHE + CadenaWhereLista(Subfamilias.SFA_idfamilia, ListadeCombo(CbFamilias), " AND ", True)

        WHE = WHE + CadenaWhereLista(Reclama.RCL_Idcentro, ListadeCombo(cbCentros), " AND ")
        WHE = WHE + CadenaWhereLista(Reclama.RCL_idorigen, ListadeCombo(CBOrigen), " AND ", True)

        WHE = WHE + CadenaWhereLista(Reclama.RCL_idresolucion, ListadeCombo(CbSolucion), " AND ", True)


        sql = Consulta.Sel(_IncluirTodosLosCampos) + WHE + " order by fecha"




        DT = Reclama.MiConexion.ConsultaSQL(sql)



        Grid.DataSource = DT



        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("Estimado", "{0:n2}")
        AñadeResumenCampo("Real", "{0:n2}")
        AñadeResumenCampo("BultosReclamados", "{0:n0}")


        AjustaColumnas()


    End Sub


    Private Sub AjustaColumnas()

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "FECHA", "FECHASALIDA"
                    c.Width = 100

                Case "BULTOSRECLAMADOS"
                    c.Caption = "Bultos Rec."
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 65

                Case "ESTIMADO", "REAL"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 100

                Case "ALBARAN", "CODIGO"
                    c.Width = 60

                Case "CLIENTE", "GENERO"
                    c.Width = 150

                Case "PRESENTACION"
                    c.Width = 200

                Case "CENTRO", "ORIGEN", "SOLUCION"
                    c.Width = 120

                Case Else
                    c.Visible = False

            End Select
        Next




    End Sub




    Public Sub CargaComboCentros()

        Dim dt As DataTable = Centros.TablaCentros()

        cbCentros.Properties.DataSource = dt
        cbCentros.Properties.ValueMember = "IdCentro"
        cbCentros.Properties.DisplayMember = "Nombre"

        For Each it As CheckedListBoxItem In cbCentros.Properties.GetItems()
            If VaInt(it.Value) = MiMaletin.IdCentro Then
                it.CheckState = CheckState.Checked
            Else
                it.CheckState = CheckState.Unchecked
            End If
        Next

    End Sub

    Public Sub CargaComboOrigen()

        Dim dt As DataTable = Reclama_origen.MiConexion.ConsultaSQL("Select RCO_idorigen as idorigen,RCO_nombre as nombre from RECLAMA_ORIGEN order by RCO_IDORIGEN")


        CBOrigen.Properties.DataSource = dt
        CBOrigen.Properties.ValueMember = "idorigen"
        CBOrigen.Properties.DisplayMember = "nombre"


    End Sub

    Public Sub CargaComboSolucion()

        Dim dt As DataTable = Reclama_resolucion.MiConexion.ConsultaSQL("Select RCS_idsolucion as idsolucion,RCS_nombre as nombre from RECLAMA_RESOLUCION order by RCS_IDSOLUCION")


        CbSolucion.Properties.DataSource = dt
        CbSolucion.Properties.ValueMember = "idsolucion"
        CbSolucion.Properties.DisplayMember = "nombre"


    End Sub

End Class