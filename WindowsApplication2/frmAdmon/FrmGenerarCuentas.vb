Imports DevExpress.XtraEditors


Public Class FrmGenerarCuentas
    Inherits FrConsulta



    Private Agricultores As New E_Agricultores(Idusuario, cn)


    Dim _dtFinal As New DataTable
    Dim _DcCuentas As New Dictionary(Of String, String)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()



    End Sub



    Private Sub FrmConsultaCuentasAgricultoresClientes_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        _dtFinal.Columns.Add(New DataColumn("Tipo", GetType(String)))
        _dtFinal.Columns.Add(New DataColumn("Sujeto", GetType(String)))
        _dtFinal.Columns.Add(New DataColumn("Codigo", GetType(String)))
        _dtFinal.Columns.Add(New DataColumn("Nombre", GetType(String)))
        _dtFinal.Columns.Add(New DataColumn("Cuenta", GetType(String)))
        _dtFinal.Columns.Add(New DataColumn("NIF", GetType(String)))
        _dtFinal.Columns.Add(New DataColumn("IdPais", GetType(Integer)))

        Dim colSel As New DataColumn("S", GetType(Boolean))
        colSel.DefaultValue = True
        _dtFinal.Columns.Add(colSel)


        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)
        GridView1.Appearance.GroupRow.Font = nueva_fuente

        BtAux.Text = "Generar cuentas"
        BtAux.Width = 120
        BtAux.Visible = True

        BInforme.Visible = False


    End Sub



    Public Overrides Sub Consultar()
        MyBase.Consultar()


        GridView1.Columns.Clear()
        Grid.DataSource = Nothing


        If chkDetallarClasificacion.Checked Then
            CargaSoloNIF()
        Else
            CargaSinNIF()
        End If
        

    End Sub


    Private Sub CargaSoloNIF()

        'NIF Clientes
        Dim sql As String = "SELECT CLI_IdCliente as Codigo, NumeroCuenta as Cuenta," & vbCrLf
        sql = sql & " CLI_Nombre as Nombre, CU.NIF as NIF_Cuenta, CLI_NIF as NIF_Cliente, Cli_IdPais as IdPais" & vbCrLf
        sql = sql & " FROM ContabilidadCosta.dbo.Cuentas CU" & vbCrLf
        sql = sql & " LEFT JOIN NetAgroComer.dbo.Clientes ON RIGHT(NumeroCuenta,5) = RIGHT('00000' + CAST (CLI_IdCliente as varchar), 5)" & vbCrLf
        sql = sql & " WHERE NumeroCuenta like '430000%'" & vbCrLf
        sql = sql & " AND COALESCE(CU.NIF, '') = ''" & vbCrLf
        sql = sql & " AND COALESCE(CLI_NIF, '') <> ''" & vbCrLf
        sql = sql & " AND CU.Interna <> 'S'" & vbCrLf

        Dim dt As DataTable = Agricultores.MiConexion.ConsultaSQL(sql)

        Dim colsel As New DataColumn("S", GetType(Boolean))
        colsel.DefaultValue = True
        dt.Columns.Add(colsel)


        Grid.DataSource = dt
        AjustaColumnasNIF()


    End Sub


    Private Sub CargaSinNIF()

        _dtFinal.Clear()
        _DcCuentas.Clear()


        Dim sql As String = ""
        Dim dtCuentas As DataTable



        'AGRICULTORES
        sql = "SELECT RIGHT('00000' + CAST(AGR_idagricultor AS VARCHAR), 5) as CodAgricultor, AGR_Nombre as Nombre, AGR_NIF as NIF, '' as IdPais " & vbCrLf
        sql = sql & " FROM AGRICULTORES" & vbCrLf
        sql = sql & " LEFT JOIN TipoAgricultor ON AGR_idtipo = TPA_idtipo " & vbCrLf
        sql = sql & " WHERE AGR_Bloqueado <> 'S' " & vbCrLf
        sql = sql & " AND TPA_Generico <> 'S'" & vbCrLf
        sql = sql & " ORDER BY AGR_IdAgricultor" & vbCrLf
        Dim dtAgricultores As DataTable = Agricultores.MiConexion.ConsultaSQL(sql)


        sql = "SELECT RIGHT('00000' + CAST(AGR_idagricultor AS VARCHAR), 5) as CodAgricultor, NUMEROCUENTA, AGR_NIF as NIF FROM AGRICULTORES" & vbCrLf
        sql = sql & " INNER JOIN " & ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".DBO.CUENTAS ON NumeroCuenta = '400000' + RIGHT('00000' + CAST(AGR_idagricultor AS VARCHAR), 5)" & vbCrLf
        sql = sql & " WHERE AGR_Bloqueado <> 'S'" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT RIGHT('00000' + CAST(AGR_idagricultor AS VARCHAR), 5) as CodAgricultor, NUMEROCUENTA, AGR_NIF as NIF FROM AGRICULTORES" & vbCrLf
        sql = sql & " INNER JOIN " & ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".DBO.CUENTAS ON NumeroCuenta = '401000' + RIGHT('00000' + CAST(AGR_idagricultor AS VARCHAR), 5)" & vbCrLf
        sql = sql & " WHERE AGR_Bloqueado <> 'S'" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT RIGHT('00000' + CAST(AGR_idagricultor AS VARCHAR), 5) as CodAgricultor, NUMEROCUENTA, AGR_NIF as NIF FROM AGRICULTORES" & vbCrLf
        sql = sql & " INNER JOIN " & ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".DBO.CUENTAS ON NumeroCuenta = '401100' + RIGHT('00000' + CAST(AGR_idagricultor AS VARCHAR), 5)" & vbCrLf
        sql = sql & " WHERE AGR_Bloqueado <> 'S'" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT RIGHT('00000' + CAST(AGR_idagricultor AS VARCHAR), 5) as CodAgricultor, NUMEROCUENTA, AGR_NIF as NIF FROM AGRICULTORES" & vbCrLf
        sql = sql & " INNER JOIN " & ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".DBO.CUENTAS ON NumeroCuenta = '407000' + RIGHT('00000' + CAST(AGR_idagricultor AS VARCHAR), 5)" & vbCrLf
        sql = sql & " WHERE AGR_Bloqueado <> 'S'" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT RIGHT('00000' + CAST(AGR_idagricultor AS VARCHAR), 5) as CodAgricultor, NUMEROCUENTA, AGR_NIF as NIF FROM AGRICULTORES" & vbCrLf
        sql = sql & " INNER JOIN " & ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".DBO.CUENTAS ON NumeroCuenta = '407700' + RIGHT('00000' + CAST(AGR_idagricultor AS VARCHAR), 5)" & vbCrLf
        sql = sql & " WHERE AGR_Bloqueado <> 'S'" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT RIGHT('00000' + CAST(AGR_idagricultor AS VARCHAR), 5) as CodAgricultor, NUMEROCUENTA, AGR_NIF as NIF FROM AGRICULTORES" & vbCrLf
        sql = sql & " INNER JOIN " & ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".DBO.CUENTAS ON NumeroCuenta = '441000' + RIGHT('00000' + CAST(AGR_idagricultor AS VARCHAR), 5)" & vbCrLf
        sql = sql & " WHERE AGR_Bloqueado <> 'S'" & vbCrLf


        'Almacena las cuentas existentes
        dtCuentas = Agricultores.MiConexion.ConsultaSQL(sql)
        For Each row As DataRow In dtCuentas.Rows

            Dim CodAgricultor As String = (row("CodAgricultor").ToString & "").Trim
            Dim Cuenta As String = (row("NumeroCuenta").ToString & "").Trim

            _DcCuentas(Cuenta) = CodAgricultor

            Application.DoEvents()

        Next


        'Buscamos las cuentas para crearlas si no existen
        For Each row As DataRow In dtAgricultores.Rows

            Dim CodAgricultor As String = (row("CodAgricultor").ToString & "").Trim
            Dim Nombre As String = (row("Nombre").ToString & "").Trim

            'Cuentas que deberían existir
            Dim CtaProveedor As String = "400000" & CodAgricultor
            Dim CtaEfecAcreedores As String = "401000" & CodAgricultor
            Dim CtaEfecProveedores As String = "401100" & CodAgricultor
            Dim CtaAnticipos As String = "407000" & CodAgricultor
            Dim CtaAntSumi As String = "407700" & CodAgricultor
            Dim CtaSuminis As String = "441000" & CodAgricultor
            Dim NIF As String = row("NIF").ToString & ""

            CompruebaGeneraCuenta("Agricultor", CtaProveedor, CodAgricultor, Nombre, NIF, 0)
            CompruebaGeneraCuenta("Agricultor", CtaEfecAcreedores, CodAgricultor, Nombre, NIF, 0)
            CompruebaGeneraCuenta("Agricultor", CtaEfecProveedores, CodAgricultor, Nombre, NIF, 0)
            CompruebaGeneraCuenta("Agricultor", CtaAnticipos, CodAgricultor, Nombre, NIF, 0)
            CompruebaGeneraCuenta("Agricultor", CtaAntSumi, CodAgricultor, Nombre, NIF, 0)
            CompruebaGeneraCuenta("Agricultor", CtaSuminis, CodAgricultor, Nombre, NIF, 0)

            Application.DoEvents()

        Next



        _DcCuentas.Clear()


        'CLIENTES
        sql = "SELECT RIGHT('00000' + CAST(CLI_IdCliente AS VARCHAR), 5) as CodCliente, CLI_Nombre as Nombre, CLI_NIF as NIF, CLI_IdPais as IdPais" & vbCrLf
        sql = sql & " FROM CLIENTES " & vbCrLf
        sql = sql & " LEFT JOIN tiposclientes ON TPC_idtipo = CLI_Idtipo " & vbCrLf
        sql = sql & " WHERE CLI_Bloqueo <> 'S'" & vbCrLf
        sql = sql & " AND TPC_clienteinterno <> 'S'" & vbCrLf
        sql = sql & " ORDER BY CLI_IdCliente" & vbCrLf
        Dim dtClientes As DataTable = Agricultores.MiConexion.ConsultaSQL(sql)

        sql = "SELECT RIGHT('00000' + CAST(CLI_IdCliente AS VARCHAR), 5) as CodCliente, NUMEROCUENTA, CLI_NIF as NIF, CLI_IdPais as IdPais FROM CLIENTES" & vbCrLf
        sql = sql & " INNER JOIN " & ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".DBO.CUENTAS ON NumeroCuenta = '430000' + RIGHT('00000' + CAST(CLI_IdCliente AS VARCHAR), 5)" & vbCrLf
        sql = sql & " WHERE CLI_Bloqueo <> 'S'" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT RIGHT('00000' + CAST(CLI_IdCliente AS VARCHAR), 5) as CodCliente, NUMEROCUENTA, CLI_NIF as NIF, CLI_IdPais as IdPais FROM CLIENTES" & vbCrLf
        sql = sql & " INNER JOIN " & ObtenerBDConexion(ConexCtb(MiMaletin.IdEmpresaCTB)) & ".DBO.CUENTAS ON NumeroCuenta = '437000' + RIGHT('00000' + CAST(CLI_IdCliente AS VARCHAR), 5)" & vbCrLf
        sql = sql & " WHERE CLI_Bloqueo <> 'S'" & vbCrLf


        'Almacena las cuentas existentes
        dtCuentas = Agricultores.MiConexion.ConsultaSQL(sql)
        For Each row As DataRow In dtCuentas.Rows

            Dim CodCliente As String = (row("CodCliente").ToString & "").Trim
            Dim Cuenta As String = (row("NumeroCuenta").ToString & "").Trim

            _DcCuentas(Cuenta) = CodCliente

            Application.DoEvents()

        Next


        'Buscamos las cuentas para crearlas si no existen
        For Each row As DataRow In dtClientes.Rows

            Dim CodCliente As String = (row("CodCliente").ToString & "").Trim
            Dim Nombre As String = (row("Nombre").ToString & "").Trim

            'Cuentas que deberían existir
            Dim CtaProveedor As String = "430000" & CodCliente
            Dim CtaEfecAcreedores As String = "437000" & CodCliente
            Dim NIF As String = row("NIF").ToString

            Dim IdPais As Integer = VaInt(row("IdPais"))

            CompruebaGeneraCuenta("Cliente", CtaProveedor, CodCliente, Nombre, NIF, IdPais)
            CompruebaGeneraCuenta("Cliente", CtaEfecAcreedores, CodCliente, Nombre, NIF, IdPais)


            Application.DoEvents()

        Next



        Dim dv As New DataView(_dtFinal)
        dv.Sort = "Tipo, Codigo, Cuenta"
        _dtFinal = dv.ToTable

        Grid.DataSource = _dtFinal
        AjustaColumnas()

    End Sub


    Private Sub CompruebaGeneraCuenta(Tipo As String, NumeroCuenta As String, Codigo As String, Nombre As String, NIF As String, IdPais As Integer)

        If Not _DcCuentas.ContainsKey(NumeroCuenta) Then

            Dim row As DataRow = _dtFinal.NewRow()
            row("Tipo") = Tipo
            row("Sujeto") = Codigo & " - " & Nombre
            row("Codigo") = Codigo
            row("Nombre") = Nombre
            row("Cuenta") = NumeroCuenta
            row("NIF") = NIF

            If VaInt(row("IdPais")) = 0 Then
                If IdPais > 0 Then
                    row("IdPais") = IdPais
                End If
            End If


            _dtFinal.Rows.Add(row)

            _DcCuentas(NumeroCuenta) = Codigo

        End If

    End Sub


    Private Sub AjustaColumnas()

        If Not IsNothing(GridView1.Columns.ColumnByFieldName("Sujeto")) Then
            GridView1.Columns.ColumnByFieldName("Sujeto").GroupIndex = 1
            GridView1.ExpandAllGroups()
        End If

        If Not IsNothing(GridView1.Columns.ColumnByFieldName("S")) Then
            GridView1.Columns.ColumnByFieldName("S").MinWidth = 25
            GridView1.Columns.ColumnByFieldName("S").MaxWidth = 25
        End If



        GridView1.BestFitColumns()


    End Sub


    Private Sub AjustaColumnasNIF()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.Trim.ToUpper

                Case "CODIGO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.Width = 60

                Case "NIF_CLIENTE", "NIF_CUENTA"
                    c.Width = 80

                Case "S"
                    c.MaxWidth = 25

                Case "CUENTA"
                    c.Width = 90


            End Select

        Next

    End Sub


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()

        If chkDetallarClasificacion.Checked Then
            GenerarNIFCuentas()
        Else
            GenerarCuentasSinNIF()
        End If

    End Sub


    Private Sub GenerarNIFCuentas()

        ProgressBar1.Value = 0

        If XtraMessageBox.Show("¿Desea generar los NIFs de las cuentas selecionadas?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim bDatos As Boolean = True
            Dim dt As DataTable = CType(Grid.DataSource, DataTable)

            If Not IsNothing(dt) Then
                If dt.Rows.Count = 0 Then bDatos = False

                Dim cont As Integer = 0
                For Each row As DataRow In dt.Rows
                    If row("S") = True Then
                        cont = cont + 1
                    End If
                Next

                ProgressBar1.Maximum = cont

                If cont = 0 Then bDatos = False

            Else
                bDatos = False
            End If


            If bDatos Then
                GenerarNIFCuentas(dt)
            Else
                XtraMessageBox.Show("No hay cuentas para generar")
            End If


        End If

    End Sub

    Private Sub GenerarCuentasSinNIF()

        ProgressBar1.Value = 0

        If XtraMessageBox.Show("¿Desea generar las cuentas seleccionadas en el grid?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim bDatos As Boolean = True
            Dim dt As DataTable = CType(Grid.DataSource, DataTable)

            If Not IsNothing(dt) Then
                If dt.Rows.Count = 0 Then bDatos = False

                Dim cont As Integer = 0
                For Each row As DataRow In dt.Rows
                    If row("S") = True Then
                        cont = cont + 1
                    End If
                Next

                ProgressBar1.Maximum = cont

                If cont = 0 Then bDatos = False

            Else
                bDatos = False
            End If


            If bDatos Then
                GenerarCuentas(dt)
            Else
                XtraMessageBox.Show("No hay cuentas para generar")
            End If


        End If

    End Sub


    Private Sub GenerarNIFCuentas(dt As DataTable)

        Dim Cuenta As New E_Cuentas(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))

        For Each row As DataRow In dt.Rows

            If row("S") = True Then

                Dim NumeroCuenta As String = (row("Cuenta").ToString & "").Trim
                Dim NIF As String = (row("NIF_Cliente").ToString & "").Trim
                Dim IdPais As Integer = VaInt(row("IdPais"))

                If Cuenta.LeerId(NumeroCuenta) Then

                    Cuenta.Nif.Valor = NIF
                    'TODO: Sobreescribir país o sólo si no tiene idpais la cuenta?
                    'TODO: Ojo, esto es para los dos casos
                    If IdPais > 0 Then
                        If VaInt(Cuenta.IdPais.Valor) = 0 Then
                            Cuenta.IdPais.Valor = IdPais.ToString
                        End If
                    End If
                    Cuenta.Actualizar()

                    Application.DoEvents()

                    If ProgressBar1.Value < ProgressBar1.Maximum Then ProgressBar1.Value = ProgressBar1.Value + 1

                End If

            End If

        Next


        XtraMessageBox.Show("Terminado!")

        Consultar()

    End Sub

    Private Sub GenerarCuentas(dt As DataTable)

        For Each row As DataRow In dt.Rows

            If row("S") = True Then

                Dim NumeroCuenta As String = (row("Cuenta").ToString & "").Trim
                Dim Nombre As String = (row("Nombre").ToString & "").Trim
                Dim IdPais As Integer = VaInt(row("IdPais"))

                Dim Cuenta As New E_Cuentas(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
                If Not Cuenta.LeerId(NumeroCuenta) Then

                    Cuenta.NumeroCuenta.Valor = NumeroCuenta
                    Cuenta.Nombre.Valor = Nombre
                    Cuenta.Nif.Valor = row("NIF").ToString & ""
                    If IdPais > 0 Then Cuenta.IdPais.Valor = IdPais.ToString
                    Cuenta.Insertar()

                    Application.DoEvents()

                    If ProgressBar1.Value < ProgressBar1.Maximum Then ProgressBar1.Value = ProgressBar1.Value + 1

                End If

                Cuenta = Nothing

            End If

        Next


        XtraMessageBox.Show("Terminado!")

        Consultar()

    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)


        If column.FieldName.Trim.ToUpper = "S" Then

            If row("S") = False Then
                row("S") = True
            Else
                row("S") = False
            End If

        End If

    End Sub


    Private Sub BtSelNinguno_Click(sender As System.Object, e As System.EventArgs) Handles BtSelNinguno.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = False
            End If
        Next

    End Sub

    Private Sub BtSelTodos_Click(sender As System.Object, e As System.EventArgs) Handles BtSelTodos.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = True
            End If
        Next

    End Sub

    Private Sub chkDetallarClasificacion_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDetallarClasificacion.CheckedChanged
        Consultar()
    End Sub
End Class