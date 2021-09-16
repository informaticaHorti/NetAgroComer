Imports DevExpress.XtraEditors.Controls


Public Class FrmEjecutarSql

    Inherits FrConsulta


    Dim Consultassql As New E_ConsultasSql(Idusuario, cn)

    Dim _consulta As String
    Dim _nvar As Integer



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

        ParamTx(TxDato1, Consultassql.SQL_Id, Lb1, True)
        ParamTx(TxDato3, Nothing, NombreVar1, True, Cdatos.TiposCampo.Cadena)
        ParamTx(TxDato4, Nothing, NombreVar2, True, Cdatos.TiposCampo.Cadena)
        ParamTx(TxDato5, Nothing, NombreVar3, True, Cdatos.TiposCampo.Cadena)
        ParamTx(TxDato6, Nothing, NombreVar4, True, Cdatos.TiposCampo.Cadena)
        ParamTx(TxDato7, Nothing, NombreVar5, True, Cdatos.TiposCampo.Cadena)
        ParamTx(TxDato8, Nothing, NombreVar6, True, Cdatos.TiposCampo.Cadena)
        ParamTx(TxDato9, Nothing, NombreVar7, True, Cdatos.TiposCampo.Cadena)
        ParamTx(TxDato2, Nothing, Lb1, True, Cdatos.TiposCampo.Cadena, 0, 1024)


        AsociarControles(TxDato1, BtBuscaCliente, Consultassql.btBusca, Consultassql, Consultassql.SQL_Nombre, Lb26)

    End Sub


    Private Sub FrmEjecutarSql_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


    End Sub




    Public Overrides Sub Consultar()
        MyBase.Consultar()

        Grid.DataSource = Nothing
        GridView1.Columns.Clear()

        Dim dt As DataTable = Consultassql.MiConexion.ConsultaSQL(TxDato2.Text)
        Grid.DataSource = dt

    End Sub


    Private Sub TxDato1_Valida(edicion As Boolean) Handles TxDato1.Valida

        If edicion = True Then
            If Consultassql.LeerId(TxDato1.Text) = True Then
                _consulta = Consultassql.SQL_Consulta.Valor
                PonerTextoVariables()
                TxDato2.Text = _consulta
            End If
        End If

    End Sub


    Private Sub PonerTextoVariables()

        Dim a As String = _consulta
        Dim tipo As Integer = 0
        Dim v As Integer = 0
        NombreVar1.Visible = False
        NombreVar2.Visible = False
        NombreVar3.Visible = False
        NombreVar4.Visible = False
        NombreVar5.Visible = False
        NombreVar6.Visible = False
        NombreVar7.Visible = False
        TxDato3.Visible = False
        TxDato4.Visible = False
        TxDato5.Visible = False
        TxDato6.Visible = False
        TxDato7.Visible = False
        TxDato8.Visible = False
        TxDato9.Visible = False

        TxDato3.Enabled = False
        TxDato4.Enabled = False
        TxDato5.Enabled = False
        TxDato6.Enabled = False
        TxDato7.Enabled = False
        TxDato8.Enabled = False
        TxDato9.Enabled = False

        _nvar = 0
        BuscaVariables(_consulta, "#F_", Cdatos.TiposCampo.Fecha)
        BuscaVariables(_consulta, "#S_", Cdatos.TiposCampo.Cadena)
        BuscaVariables(_consulta, "#N_", Cdatos.TiposCampo.Importe)

    End Sub


    Private Sub BuscaVariables(Cadena As String, TipoVariable As String, tipo As Integer)

        Dim a As String = Cadena

        While InStr(a, TipoVariable)
            Dim i As Integer = 0
            i = InStr(a, TipoVariable)
            If i > 0 Then
                Dim b As String = Mid(a, i + 3)
                Dim n As String = Mid(b, 1, InStr(b, "#") - 1)

                b = Mid(b, InStr(b, "#") + 1)
                a = Trim(b)

                Dim S As Integer = 0
                For Each Eti In PanelVariables.Controls
                    If TypeOf Eti Is Lb Then
                        If InStr(CType(Eti, Lb).Name.ToUpper, "NOMBREVAR") > 0 Then
                            If Trim(CType(Eti, Lb).Text) = Trim(n) Then
                                S = Val(Mid(CType(Eti, Lb).Name, 10, 1))
                            End If

                        End If
                    End If

                Next
                If S = 0 Then
                    _nvar = _nvar + 1
                Else
                    _nvar = S
                End If
                PintaEti(_nvar, n, tipo)
            End If

        End While

    End Sub


    Private Sub PintaEti(Neti As Integer, n As String, tipo As Integer)

        Select Case Neti
            Case 1
                NombreVar1.Text = n
                NombreVar1.Visible = True
                TxDato3.Visible = True
                TxDato3.Enabled = True
                TxDato3.ClParam.Tipo = tipo

            Case 2
                NombreVar2.Text = n
                NombreVar2.Visible = True
                TxDato4.Visible = True
                TxDato4.Enabled = True
                TxDato4.ClParam.Tipo = tipo

            Case 3
                NombreVar3.Text = n
                NombreVar3.Visible = True
                TxDato5.Visible = True
                TxDato5.Enabled = True
                TxDato5.ClParam.Tipo = tipo

            Case 4
                NombreVar4.Text = n
                NombreVar4.Visible = True
                TxDato6.Visible = True
                TxDato6.Enabled = True
                TxDato6.ClParam.Tipo = tipo

            Case 5
                NombreVar5.Text = n
                NombreVar5.Visible = True
                TxDato7.Visible = True
                TxDato7.Enabled = True
                TxDato7.ClParam.Tipo = tipo

            Case 6
                NombreVar6.Text = n
                NombreVar6.Visible = True
                TxDato8.Visible = True
                TxDato8.ClParam.Tipo = tipo
                TxDato8.Enabled = True

            Case 7
                NombreVar7.Text = n
                NombreVar7.Visible = True
                TxDato9.Visible = True
                TxDato9.ClParam.Tipo = tipo
                TxDato9.Enabled = True

        End Select

    End Sub


    Private Sub CambiarLaConsulta()

        Dim c As String = _consulta
        If TxDato3.Text <> "" Then
            c = CambiaTexto(c, TxDato3.ClParam.Tipo, NombreVar1.Text, TxDato3.Text)
        End If

        If TxDato4.Text <> "" Then
            c = CambiaTexto(c, TxDato4.ClParam.Tipo, NombreVar2.Text, TxDato4.Text)
        End If

        If TxDato5.Text <> "" Then
            c = CambiaTexto(c, TxDato5.ClParam.Tipo, NombreVar3.Text, TxDato5.Text)
        End If

        If TxDato6.Text <> "" Then
            c = CambiaTexto(c, TxDato6.ClParam.Tipo, NombreVar4.Text, TxDato6.Text)
        End If

        If TxDato7.Text <> "" Then
            c = CambiaTexto(c, TxDato7.ClParam.Tipo, NombreVar5.Text, TxDato7.Text)
        End If

        If TxDato8.Text <> "" Then
            c = CambiaTexto(c, TxDato8.ClParam.Tipo, NombreVar6.Text, TxDato8.Text)
        End If

        TxDato2.Text = c

    End Sub


    Private Function CambiaTexto(Cadena As String, Tipo As Integer, Nombre As String, dato As String) As String

        Dim lg As Integer = Len(Nombre) + 4
        Dim I As Integer
        Dim CadenaInicial As String = Cadena

        Cadena = Cadena + " "
        I = 1

        While I
            Select Case Tipo
                Case Cdatos.TiposCampo.Fecha
                    I = InStr(Cadena, "#F_" + Trim(Nombre))
                    If I > 0 Then
                        Cadena = Mid(Cadena, 1, I - 1) + "'" + dato + "' " + Mid(Cadena, I + lg)
                    End If

                Case Cdatos.TiposCampo.Cadena
                    I = InStr(Cadena, "#S_" + Trim(Nombre))
                    If I > 0 Then
                        Cadena = Mid(Cadena, 1, I - 1) + "'" + dato + "' " + Mid(Cadena, I + lg)
                    End If

                Case Cdatos.TiposCampo.Importe
                    I = InStr(Cadena, "#N_" + Trim(Nombre))
                    If I > 0 Then
                        Cadena = Mid(Cadena, 1, I - 1) + " " + Str(Val(dato)) + " " + Mid(Cadena, I + lg)
                    End If

            End Select
        End While

        Return Cadena

    End Function


    Private Sub TxDato3_Valida(edicion As Boolean) Handles TxDato3.Valida

        If edicion = True Then
            CambiarLaConsulta()
        End If

    End Sub


    Private Sub TxDato4_Valida(edicion As Boolean) Handles TxDato4.Valida

        If edicion = True Then
            CambiarLaConsulta()

        End If

    End Sub


    Private Sub TxDato5_Valida(edicion As Boolean) Handles TxDato5.Valida

        If edicion = True Then
            CambiarLaConsulta()

        End If

    End Sub

    Private Sub TxDato6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato6.TextChanged

    End Sub

    Private Sub TxDato6_Valida(edicion As Boolean) Handles TxDato6.Valida
        If edicion = True Then
            CambiarLaConsulta()

        End If


    End Sub

    Private Sub TxDato7_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato7.TextChanged

    End Sub

    Private Sub TxDato7_Valida(edicion As Boolean) Handles TxDato7.Valida
        If edicion = True Then
            CambiarLaConsulta()

        End If


    End Sub

    Private Sub TxDato8_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato8.TextChanged

    End Sub

    Private Sub TxDato8_Valida(edicion As Boolean) Handles TxDato8.Valida
        If edicion = True Then
            CambiarLaConsulta()

        End If


    End Sub

    Private Sub TxDato9_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato9.TextChanged

    End Sub

    Private Sub TxDato9_Valida(edicion As Boolean) Handles TxDato9.Valida
        If edicion = True Then
            CambiarLaConsulta()

        End If


    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim frm As New FrmConsultaSql
        frm.ShowDialog()

    End Sub

    
End Class