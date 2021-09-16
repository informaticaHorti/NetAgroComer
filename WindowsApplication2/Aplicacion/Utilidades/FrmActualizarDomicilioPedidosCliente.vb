Imports DevExpress.XtraEditors


Public Class FrmActualizarDomicilioPedidosCliente
    Inherits FrConsulta


    Dim err As New Errores

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        BInforme.Visible = False
        GridView1.Appearance.HeaderPanel.BackColor = Color.Aquamarine

        BtAux.Image = My.Resources.App_kservices_16x16_32
        BtAux.Text = "Actualizar"
        BtAux.Visible = True

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub

    Public Overrides Sub Consultar()
        MyBase.Consultar()



        Dim sql As String = "SELECT *" & vbCrLf
        sql = sql & " FROM " & vbCrLf
        sql = sql & " ( " & vbCrLf
        sql = sql & " SELECT PCC_IdLinea as IdLinea, PCC_IdCliente as IdCliente," & vbCrLf
        sql = sql & " (SELECT TOP 1 CLD_Id FROM ClientesDescargas WHERE CLD_IdCliente = PCC_IdCliente) as IdDomicilio," & vbCrLf
        sql = sql & " PCC_IdGenero as IdGenero, GEN_NombreGenero as Genero, " & vbCrLf
        sql = sql & " PCC_IdGenSal as IdPresentacion, GES_Nombre as Presentacion, PCC_IdCategoria as IdCategoria, CAS_CategoriaCalibre as Categoria," & vbCrLf
        sql = sql & " PCC_IdTipoPalet as IdTipoPalet, CPA_Nombre as TipoPalet, PCC_IdMarca as IdMarca, MarcaEnv.MAR_Nombre as Marca," & vbCrLf
        sql = sql & " PCC_IdMarcaEtiqueta as IdMarcaEti, MarcaEti.MAR_Nombre as MarcaEti, PCC_IdMarcaMaterial as IdMarcaMat, MarcaMat.MAR_Nombre as MarcaMat," & vbCrLf
        sql = sql & " PCC_bultospalet as BxP, PCC_KilosBulto as KxB, PCC_PiezasBulto as PxB, 0 as Palets, PCC_FechaPedido as FechaPedido," & vbCrLf
        sql = sql & " PCC_Activo" & vbCrLf
        sql = sql & " FROM Pedidos_Clientes" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON PCC_IdGenero = GEN_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN GenerosSalida ON GES_IdGenSal = PCC_IdGenSal" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasSalida ON CAS_Id = PCC_IdCategoria" & vbCrLf
        sql = sql & " LEFT JOIN ConfecPalet ON CPA_IdConfec = PCC_IdTipoPalet" & vbCrLf
        sql = sql & " LEFT JOIN Marcas MarcaEnv ON MarcaEnv.MAR_IdMarca = PCC_IdMarca" & vbCrLf
        sql = sql & " LEFT JOIN Marcas MarcaEti ON MarcaEti.MAR_IdMarca = PCC_IdMarcaEtiqueta" & vbCrLf
        sql = sql & " LEFT JOIN Marcas MarcaMat ON MarcaMat.MAR_IdMarca = PCC_IdMarcaMaterial" & vbCrLf
        sql = sql & " WHERE PCC_Activo = 'S'" & vbCrLf
        sql = sql & " AND COALESCE(PCC_IdDomicilio,0) = 0" & vbCrLf
        sql = sql & " ) as X" & vbCrLf
        sql = sql & " ORDER BY IdCliente, IdGenero, IdPresentacion, FechaPedido DESC" & vbCrLf

        
        Dim dt As DataTable = cn.ConsultaSQL(sql)


        GridView1.Columns.Clear()
        Grid.DataSource = dt

        AjustaColumnas()

    End Sub


    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDLINEA", "IDPRESENTACION", "IDCATEGORIA", "IDTIPOPALET", "IDMARCA", "IDMARCAETI", "IDMARCAMAT", "PCC_ACTIVO", "IDGENERO"
                    c.Visible = False
            End Select
        Next


        GridView1.BestFitColumns()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "IDCLIENTE", "IDDOMICILIO"
                    c.MinWidth = 50

                Case "BORRAR"
                    c.Caption = ""
                    c.MinWidth = 20
                    c.MaxWidth = 20

                Case "CATEGORIA"
                    c.Width = 90

                Case "ACTIVO"
                    c.MinWidth = 50
                    c.MaxWidth = 50

                Case "FECHAPEDIDO"
                    c.MinWidth = 80
                    c.MaxWidth = 80

                Case "MARCA", "MARCAETI", "MARCAMAT"
                    c.Width = 90

                Case "TIPOPALET"
                    c.Width = 110

                Case "PALETS", "BXP", "PXB"
                    c.Width = 60
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"

                Case "KXB"
                    c.Width = 60
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"

            End Select

        Next



    End Sub



    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()


        If XtraMessageBox.Show("¿Desea generar el domicilio de descarga para los pedidos predefinidos de cliente? Se usará el primer domicilio existente en los centros de descarga", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

            Dim cont As Integer = 0


            ProgressBar1.Value = 0


            Dim dt As DataTable = CType(Grid.DataSource, DataTable)
            If Not IsNothing(dt) Then


                If dt.Rows.Count > 0 Then ProgressBar1.Maximum = dt.Rows.Count - 1


                Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)


                For indice As Integer = 0 To dt.Rows.Count - 1

                    Dim row As DataRow = dt.Rows(indice)

                    Dim IdLinea As String = (row("IdLinea").ToString & "").Trim
                    Dim IdDomicilio As String = (row("IdDomicilio").ToString & "").Trim

                    Dim Pedidos_Cliente As New E_Pedidos_Clientes(Idusuario, cn)
                    If Pedidos_Cliente.LeerId(IdLinea) Then

                        Pedidos_Cliente.PCC_IdDomicilio.Valor = IdDomicilio
                        Pedidos_Cliente.Actualizar()

                    End If

                    cont = cont + 1
                    ProgressBar1.Value = indice

                Next

            End If





            If cont = 0 Then
                MsgBox("No hay registros que actualizar")
            Else
                MsgBox("Terminado!")
                Consultar()
            End If


        End If

    End Sub

End Class