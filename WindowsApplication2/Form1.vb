Public Class Form1

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim lc As New List(Of Object)
        'ListaControles = lc



        Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)
        Dim Usuarios As New E_Usuarios(Idusuario, CnComun)
        'EntidadFrm = ValoresUsuario


        'ParamTx(TxDato1, ValoresUsuario.VUS_Iduser, Lb1, True)
        'CampoClave = 0 ' ultimo campo de la clave

        'AsociarControles(TxDato1, BtBuscaFRM, Usuarios.btBusca, Usuarios, Usuarios.Nombre, LbNomUsu)


    End Sub


    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        'En caso de pertenecer a un mantenimiento/consulta, para seguir el orden
        pnlBotonesGD.Orden = 1
        'ListaControles.Add(GridEditable1)

        CargaGridEditable()


        'MsgBox(DatePart(DateInterval.WeekOfYear, VaDate("31/12/2014"), FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek))

    End Sub


    Private Sub CargaGridEditable()

        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
        Dim PaletsLineas As New E_palets_lineas(Idusuario, cn)
        Dim _IdAlbaran As String = "8"

        Dim sql As String = "SELECT PLL_IdLinea, ASA_IdAlbaran as IdAlbaran, ASA_FechaSalida as FechaSalida, PLL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
        sql = sql & " PLL_KilosNetos as KgNetos, PLL_Bultos as Bultos, " & vbCrLf
        sql = sql & " PLL_CosteEstructura as Estructura, PLL_CosteConfeccion as Confeccion, PLL_CosteMaterial as Material" & vbCrLf
        sql = sql & " FROM Palets_Lineas " & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida_Palets ON ASP_IdPalet = PLL_IdPalet" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = PLL_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida ON ASA_IdAlbaran = ASP_IdAlbaran"
        'sql = sql & " WHERE ASP_IdAlbaran = " & _IdAlbaran & vbCrLf
        sql = sql & " ORDER BY Genero"

        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)

        pnlBotonesGD.DataSource = dt

        pnlBotonesGD.Campo("KgNetos", PaletsLineas.PLL_kilosnetos, True, True, True, True)
        pnlBotonesGD.Campo("FechaSalida", AlbSalida.ASA_fechasalida, True, True, True, True)

    End Sub


    Private Sub GridEditable1_GuardarCambios(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn) Handles pnlBotonesGD.GuardarCambios

        Select Case column.FieldName.ToUpper.Trim

            Case "KGNETOS"
                Dim IdLinea As String = row("PLL_IdLinea").ToString
                Dim Palets_lineas As New E_palets_lineas(Idusuario, cn)

                If Palets_lineas.LeerId(IdLinea) Then
                    Palets_lineas.PLL_kilosnetos.Valor = VaDec(row(column.FieldName))
                    Palets_lineas.Actualizar()
                End If

            Case "FECHASALIDA"
                Dim IdAlbaran As String = row("IdAlbaran").ToString
                Dim AlbSalida As New E_AlbSalida(Idusuario, cn)

                If AlbSalida.LeerId(IdAlbaran) Then
                    Dim FechaSalida As Date = VaDate(row("FechaSalida"))
                    If FechaSalida > VaDate("") Then
                        AlbSalida.ASA_fechasalida.Valor = FechaSalida
                    Else
                        AlbSalida.ASA_fechasalida.Valor = Nothing
                    End If
                    AlbSalida.Actualizar()

                End If

        End Select


        CargaGridEditable()

    End Sub

    Private Sub GridEditable1_Valida(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn) Handles pnlBotonesGD.Valida

        If column.FieldName.ToUpper.Trim = "KGNETOS" Then

            Dim KgNetos As Decimal = VaDec(row("KgNetos"))
            If KgNetos < 0 Then
                pnlBotonesGD.PonError(column, "KgNetos debe ser mayor o igual que cero")
            End If

        End If



    End Sub

    Private Sub GridEditable1_DespuesDeEditar(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn) Handles pnlBotonesGD.DespuesDeEditar



    End Sub

    Private Sub ClButton1_Click(sender As System.Object, e As System.EventArgs) Handles ClButton1.Click


        MsgBox("Hola")

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

    End Sub
End Class