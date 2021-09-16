Imports DevExpress.XtraEditors


Public Class FrmAsignarConfecAGeneros
    Inherits FrConsulta


    Private Class ClaveGenero

        Public IdGenero As String = ""
        Public Nombre As String = ""

        Public Sub New(IdGenero As String, Nombre As String)
            Me.IdGenero = IdGenero
            Me.Nombre = Nombre
        End Sub

    End Class


    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)



    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, ConfecEnvase.CEV_Idconfec, Lb1, True)
        ParamTx(TxDato2, GenerosSalida.GES_KilosXBulto, Lb2, True)
        ParamTx(TxDato3, GenerosSalida.GES_PiezasXBulto, Lb3, True)
        ParamTx(TxDato4, GenerosSalida.GES_GtoXKilo, Lb4, True)
        ParamChk(ChPesoFijo, GenerosSalida.GES_PesoFijo, "S", "N")
        ParamChk(ChActivo, GenerosSalida.GES_Activo, "S", "N")


        AsociarControles(TxDato1, BtBusca1, ConfecEnvase.btBusca, ConfecEnvase, ConfecEnvase.CEV_Nombre, Lb_1)


    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub FrmAsignarConfecAGeneros_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BtAux.Text = "Asociar"
        BtAux.Image = NetAgro.My.Resources.Resources.App_kservices_16x16_32
        BtAux.Visible = True

        GridView1.OptionsView.ShowGroupPanel = False


        BImprimir.Visible = False
        BInforme.Visible = False

    End Sub



    Public Overrides Sub Consultar()
        MyBase.Consultar()


        If TxDato1.Text.Trim = "" Then
            MsgBox("Debe introducir el tipo de confección")
            Exit Sub
        End If

        CargaGridExistentes()
        CargaGrid()

    End Sub


    Private Sub CargaGrid()

        Dim sql As String = "SELECT DISTINCT GEN_IdGenero as IdGenero, GEN_NombreGenero as Genero" & vbCrLf
        sql = sql & " FROM Generos" & vbCrLf
        sql = sql & " LEFT JOIN GenerosSalida ON GEN_IdGenero = GES_IdGenero" & vbCrLf
        sql = sql & " WHERE GEN_IdGenero NOT IN " & vbCrLf
        sql = sql & " (SELECT GES_IdGenero FROM GenerosSalida WHERE COALESCE(GES_IdConfec, 0) = " & VaInt(TxDato1.Text) & ")" & vbCrLf
        sql = sql & " ORDER BY GEN_IdGenero, GEN_NombreGenero" & vbCrLf


        Dim dt As DataTable = GenerosSalida.MiConexion.ConsultaSQL(sql)

        Dim colSel As New DataColumn("S", GetType(Boolean))
        colSel.DefaultValue = False
        dt.Columns.Add(colSel)


        Grid.DataSource = dt
        AjustaColumnas(GridView1)


    End Sub


    Private Sub AjustaColumnas(gr As DevExpress.XtraGrid.Views.Grid.GridView)

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In gr.Columns

            Select Case c.FieldName.ToUpper

                Case "IDGENERO"
                    c.Caption = "Codigo"
                    c.Width = 60
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"

                Case "S"
                    c.Width = 20

            End Select

        Next


    End Sub


    Private Sub CargaGridExistentes()

        Dim sql As String = "SELECT DISTINCT GEN_IdGenero as IdGenero, GEN_NombreGenero as Genero" & vbCrLf
        sql = sql & " FROM Generos" & vbCrLf
        sql = sql & " LEFT JOIN GenerosSalida ON GEN_IdGenero = GES_IdGenero" & vbCrLf
        sql = sql & " WHERE GEN_IdGenero IN " & vbCrLf
        sql = sql & " (SELECT GES_IdGenero FROM GenerosSalida WHERE COALESCE(GES_IdConfec, 0) = " & VaInt(TxDato1.Text) & ")" & vbCrLf
        sql = sql & " ORDER BY GEN_IdGenero, GEN_NombreGenero" & vbCrLf


        Dim dt As DataTable = GenerosSalida.MiConexion.ConsultaSQL(sql)

        Dim colSel As New DataColumn("S", GetType(Boolean))
        colSel.DefaultValue = True
        dt.Columns.Add(colSel)


        GridExistentes.DataSource = dt
        AjustaColumnas(GridViewExistentes)


    End Sub


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()


        Dim lstGenero As New List(Of ClaveGenero)

        For indice As Integer = 0 To GridView1.RowCount - 1

            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then

                If row("S") = True Then

                    Dim IdGenero As String = row("IdGenero").ToString
                    Dim NombreGenero As String = (row("Genero").ToString & "").Trim
                    lstGenero.Add(New ClaveGenero(IdGenero, NombreGenero))

                End If

            End If

        Next

        If TxDato1.Text.Trim = "" Then
            MsgBox("Debe introducir el tipo de confección")
            Exit Sub
        End If


        If lstGenero.Count = 0 Then
            MsgBox("No ha seleccionado ningún genero")
            Exit Sub
        End If


        If XtraMessageBox.Show("¿Desea asociar los datos de la confección al género?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            AsociarConfeccionAGeneros(lstGenero)

            CargaGridExistentes()
            CargaGrid()

        End If

    End Sub


    
    Private Sub TxDato1_Valida(edicion As System.Boolean) Handles TxDato1.Valida
        If edicion Then
            CargaGridExistentes()
            CargaGrid()
        End If
    End Sub


    Private Sub ChActivo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ChActivo.KeyDown

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            BtAux.Select()
            BtAux.Focus()
        End If

    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

        If column.FieldName.ToUpper.Trim = "S" Then

            If row("S") = True Then
                row("S") = False
            Else
                row("S") = True
            End If

        End If

    End Sub


    Private Sub AsociarConfeccionAGeneros(lst As List(Of ClaveGenero))

        Dim IdConfec As String = TxDato1.Text
        Dim NombreConfec As String = Lb_1.Text

        Dim PesoFijo As String = ""
        If ChPesoFijo.Checked Then
            PesoFijo = ChPesoFijo.ValorCampoTrue
        Else
            PesoFijo = ChPesoFijo.ValorCampoFalse
        End If

        Dim Activo As String = ""
        If ChActivo.Checked Then
            Activo = ChActivo.ValorCampoTrue
        Else
            Activo = ChActivo.ValorCampoFalse
        End If

        Dim KxB As Decimal = VaDec(TxDato2.Text)
        Dim PxB As Decimal = VaDec(TxDato3.Text)
        Dim GxK As Decimal = VaDec(TxDato4.Text)


        For Each cg As ClaveGenero In lst

            Dim IdGenero As String = cg.IdGenero
            Dim NombreGenero As String = cg.Nombre

            Dim GeneroSalidas As New E_GenerosSalida(Idusuario, cn)
            GeneroSalidas.GES_Idgensal.Valor = GeneroSalidas.MaxId()
            GeneroSalidas.GES_IdGenero.Valor = IdGenero
            GeneroSalidas.GES_Idconfec.Valor = IdConfec
            GeneroSalidas.GES_Nombre.Valor = FnLeft(NombreGenero & " " & NombreConfec, GeneroSalidas.GES_Nombre.Longitud)
            GeneroSalidas.GES_PesoFijo.Valor = PesoFijo
            GeneroSalidas.GES_Activo.Valor = Activo
            GeneroSalidas.GES_KilosXBulto.Valor = KxB
            GeneroSalidas.GES_PiezasXBulto.Valor = PxB
            GeneroSalidas.GES_GtoXKilo.Valor = GxK
            GeneroSalidas.Insertar()

        Next


    End Sub

End Class