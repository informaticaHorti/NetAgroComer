Public Class FrmDescripcionGeneroPorIdioma
    Inherits FrConsulta



    Private _IdGenero As String = ""


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(IdGenero As String)
        Me.New()

        _IdGenero = IdGenero


    End Sub


    Private Sub ParametrosFrm()

        ListaControles = New List(Of Object)


    End Sub


    Private Sub FrmDescripcionGeneroPorIdioma_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        Dim Generos As New E_Generos(Idusuario, cn)
        If Generos.LeerId(_IdGenero) Then

            LbIdGenero.Text = _IdGenero
            LbNombreGenero.Text = Generos.GEN_NombreGenero.Valor

        End If


        Consultar()

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        If VaInt(_IdGenero) > 0 Then

            Dim DescripcionGeneroPorIdioma As New E_DescripcionGeneroPorIdioma(Idusuario, cn)
            Dim Idiomas As New E_Idiomas(Idusuario, CnComun)

            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(Idiomas.Ididioma, "IdIdioma")
            CONSULTA.SelCampo(Idiomas.Nombre, "Idioma")
            CONSULTA.WheCampo(Idiomas.Ididioma, "<>", "1")

            Dim sql As String = CONSULTA.SQL & vbCrLf
            sql = sql & " ORDER BY Nombre"


            Dim dt As DataTable = Idiomas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                dt.Columns.Add("Id", GetType(Integer))
                dt.Columns.Add("Descripcion", GetType(String))

                CONSULTA = New Cdatos.E_select
                CONSULTA.SelCampo(DescripcionGeneroPorIdioma.DGI_Id, "Id")
                CONSULTA.SelCampo(DescripcionGeneroPorIdioma.DGI_IdIdioma, "IdIdioma")
                CONSULTA.SelCampo(DescripcionGeneroPorIdioma.DGI_Descripcion, "Descripcion")
                CONSULTA.WheCampo(DescripcionGeneroPorIdioma.DGI_IdGenero, "=", _IdGenero)

                Dim dt2 As DataTable = DescripcionGeneroPorIdioma.MiConexion.ConsultaSQL(CONSULTA.SQL)
                If Not IsNothing(dt2) Then
                    For Each row As DataRow In dt.Rows
                        For Each row2 As DataRow In dt2.Rows

                            Dim IdIdioma1 As Integer = VaInt(row("IdIdioma"))
                            Dim IdIdioma2 As Integer = VaInt(row2("IdIdioma"))

                            If IdIdioma1 = IdIdioma2 And IdIdioma1 <> 0 Then
                                row("Id") = row2("Id")
                                row("Descripcion") = row2("Descripcion")
                            End If

                        Next
                    Next
                End If



            End If



            GridEditable.DataSource = dt
            GridEditable.Campo("Descripcion", DescripcionGeneroPorIdioma.DGI_Descripcion, True, True, False, False)
            AjustaColumnas(GridEditable.GridView)


        End If


    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()

        Guardar()

    End Sub


    Private Sub Guardar()


        For Each row In GridEditable.GridView.DataSource

            Dim Id As String = (row("Id").ToString & "").Trim
            Dim IdIdioma As String = (row("IdIdioma").ToString & "").Trim
            Dim Descripcion As String = (row("Descripcion").ToString & "").Trim

            If VaInt(Id) = 0 Then

                Dim DescripcionGeneroPorIdioma As New E_DescripcionGeneroPorIdioma(Idusuario, cn)
                DescripcionGeneroPorIdioma.DGI_Id.Valor = DescripcionGeneroPorIdioma.MaxId()
                DescripcionGeneroPorIdioma.DGI_IdGenero.Valor = _IdGenero
                DescripcionGeneroPorIdioma.DGI_IdIdioma.Valor = IdIdioma
                DescripcionGeneroPorIdioma.DGI_Descripcion.Valor = Descripcion
                DescripcionGeneroPorIdioma.Insertar()

            Else

                Dim DescripcionGeneroPorIdioma As New E_DescripcionGeneroPorIdioma(Idusuario, cn)
                If DescripcionGeneroPorIdioma.LeerId(Id) Then
                    DescripcionGeneroPorIdioma.DGI_Descripcion.Valor = Descripcion
                    DescripcionGeneroPorIdioma.Actualizar()
                End If

            End If

        Next


        MsgBox("Registros guardados")
        Me.Close()


    End Sub


    Private Sub AjustaColumnas(g As DevExpress.XtraGrid.Views.Grid.GridView)


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In g.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "IDIDIOMA", "ID"
                    c.Visible = False

            End Select
        Next

        g.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In g.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "IDIOMA"
                    c.Width = 150

            End Select
        Next


    End Sub




End Class