Imports DevExpress.XtraEditors.Controls

Public Class FrmCierreInventario

    Inherits FrConsulta

    Private Class stClave_Inventario

        Public IdEnvase As Integer = 0
        Public Envase As String = ""
        Public IdMarca As Integer = 0
        Public Marca As String = ""
        Public IdAlmacen As Integer = 0


        Public Sub New(IdEnvase As Integer, Envase As String,
                       IdMarca As Integer, Marca As String, Idalmacen As Integer)

            Me.IdEnvase = IdEnvase
            Me.Envase = Envase
            Me.IdMarca = IdMarca
            Me.Marca = Marca
            Me.IdAlmacen = Idalmacen
        End Sub

    End Class


    Private Class stDatos_Inventario

      
        Public Exist As Decimal = 0
        Public PMC As Decimal = 0
        Public ValExist As Decimal = 0


        Public Sub New(Exist As Decimal,
                ValExist As Decimal)

            Me.Exist = Exist
            Me.ValExist = ValExist
        End Sub

    End Class

    Private Class stClave_Saldos

        Public Codigo As Integer = 0
        Public Nombre As String = ""
        Public IdEnvase As Integer = 0
        Public Envase As String = ""
        Public IdMarca As Integer = 0
        Public Marca As String = ""
        Public Precio As Decimal = 0


        Public Sub New(Codigo As Integer, Nombre As String, IdEnvase As Integer, Envase As String,
                       IdMarca As Integer, Marca As String, Precio As Decimal)

            Me.Codigo = Codigo
            Me.Nombre = Nombre
            Me.IdEnvase = IdEnvase
            Me.Envase = Envase
            Me.IdMarca = IdMarca
            Me.Marca = Marca
            Me.Precio = Precio
        End Sub

    End Class


    Private Class stDatos_Saldos

        Public Saldo As Decimal = 0


        Public Sub New(Saldo As Decimal)

            Me.Saldo = Saldo
 
        End Sub

    End Class

    Dim _dfecha As String
    Dim Palets As New E_palets(Idusuario, cn)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc


        ParamTx(TxHastaFecha, Nothing, Lb1, True, Cdatos.TiposCampo.Fecha)
        ParamTx(TxEjerini, Nothing, Lb1, True, Cdatos.TiposCampo.EnteroPositivo)

        BtAux.Visible = True
        BtAux.Text = "Generar"

    End Sub



    Private Sub FrmInventarioMaterialesPorFecha_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim fuente_nueva As New Font(fuente.FontFamily, fuente.Size + 1, FontStyle.Bold)
        GridView1.Appearance.GroupRow.Font = fuente_nueva
     
        BInforme.Visible = False



    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxHastaFecha.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
        TxEjerini.Text = MiMaletin.Ejercicio + 1
        _dfecha = Format(MiMaletin.FechaInicioEjercicio, "dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub


    Private Function CierreSujetos(Tipo As String) As DataTable
        Dim DT As New DataTable
        Dim acum As New Acumulador

        DT = SaldosInicialesSujetos(Tipo)

        If Not IsNothing(DT) Then
            Barra.Value = 0
            Barra.Maximum = DT.Rows.Count

            For Each row As DataRow In DT.Rows
                If Barra.Value < Barra.Maximum Then
                    Barra.Value = Barra.Value + 1
                End If

                Dim IdEnvase As Integer = VaInt(row("IdEnvase"))
                Dim Envase As String = (row("Envase").ToString & "").Trim


                Dim IdMarca As Integer = 0
                Dim Marca As String = ""
                IdMarca = VaInt(row("IdMarca"))
                Marca = (row("Marca").ToString & "").Trim


                Dim ExistIni As Decimal = VaDec(row("ExistIni"))
                Dim Precio As Decimal = VaDec(row("Precio"))
                Dim Codigo As Integer = VaInt(row("Codigo"))
                Dim Nombre As String = row("nombre").ToString

                Dim stClave As New stClave_Saldos(Codigo, Nombre, IdEnvase, Envase, IdMarca, Marca, Precio)
                Dim stDatos As New stDatos_Saldos(ExistIni)

                acum.Suma(stClave, stDatos)

            Next
        End If

        Select Case Tipo
            Case "CL"
                DT = SaldosValesEnvasesSujetos("C")
            Case "AG"
                DT = SaldosValesEnvasesSujetos("A")
        End Select
        If Not IsNothing(DT) Then
            Barra.Value = 0
            Barra.Maximum = DT.Rows.Count

            For Each row As DataRow In DT.Rows
                If Barra.Value < Barra.Maximum Then
                    Barra.Value = Barra.Value + 1
                End If

                Dim IdEnvase As Integer = VaInt(row("IdEnvase"))
                Dim Envase As String = (row("Envase").ToString & "").Trim


                Dim IdMarca As Integer = 0
                Dim Marca As String = ""
                IdMarca = VaInt(row("IdMarca"))
                Marca = (row("Marca").ToString & "").Trim


                Dim Entrega As Decimal = VaDec(row("Entrega"))
                Dim Retira As Decimal = VaDec(row("Retira"))
                Dim Pentrega As Decimal = VaDec(row("Pentrega"))
                Dim Pretira As Decimal = VaDec(row("Pretira"))
                Dim Codigo As Integer = VaInt(row("Codigo"))
                Dim Nombre As String = row("nombre").ToString

                If Pentrega <> 0 Or Pretira <> 0 Then
                    Dim A As String = ""
                End If
                Dim stClaveR As New stClave_Saldos(Codigo, Nombre, IdEnvase, Envase, IdMarca, Marca, Pretira)
                Dim stDatosR As New stDatos_Saldos(Retira)
                acum.Suma(stClaveR, stDatosR)

                Dim stClaveE As New stClave_Saldos(Codigo, Nombre, IdEnvase, Envase, IdMarca, Marca, Pentrega)
                Dim stDatosE As New stDatos_Saldos(-Entrega)

                acum.Suma(stClaveE, stDatosE)

            Next
        End If


        Return acum.DataTable

    End Function

    Private Function CierreAlmacenes() As DataTable



        Dim acum As New Acumulador

        'If ChkActuprecios.CheckState = CheckState.Checked Then
        '    ActualizaPreciosMateriales()
        'End If
        Dim LstCodigos As New List(Of String)
        Dim lstFamilias As New List(Of String)


        Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(AlmacenEnvases.AEV_Idalmacen, "id")
        consulta.SelCampo(AlmacenEnvases.AEV_Nombre, "Nombre")
        Dim sql As String = consulta.SQL
        Dim dt As DataTable = AlmacenEnvases.MiConexion.ConsultaSQL(sql)
        Barra.Value = 0
        Barra.Maximum = dt.Rows.Count
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                If Barra.Value < Barra.Maximum Then
                    Barra.Value = Barra.Value + 1
                End If
                Dim idalmacen As Integer = VaInt(rw("id"))
                Dim lstalmacenes As New List(Of String)
                lstalmacenes.Add(idalmacen.ToString)
               

                Dim dtfinal2 As DataTable = Agro_inventario(TxHastaFecha.Text, "", "", LstCodigos, lstalmacenes, lstFamilias, True)
                If Not dtfinal2 Is Nothing Then
                    For Each rwf In dtfinal2.Rows

                        Dim idenvase As Integer = VaInt(rwf("idenvase"))
                        Dim envase As String = rwf("envase").ToString
                        Dim idmarca As Integer = VaInt(rwf("idmarca"))
                        Dim marca As String = rwf("marca").ToString
                        Dim Exist As Decimal = VaDec(rwf("Exist"))
                        Dim Vexist As Decimal = VaDec(rwf("Valexist"))
                        Dim stClave As New stClave_Inventario(idenvase, envase, idmarca, marca, idalmacen)
                        Dim stDatos As New stDatos_Inventario(Exist, Vexist)

                        acum.Suma(stClave, stDatos)

                    Next
                End If

            Next
        End If



      

        Dim ret As DataTable = acum.DataTable
        For Each rw In ret.Rows
            Dim PMC As Decimal = 0
            Dim Exist As Decimal = VaDec(rw("Exist"))
            Dim ValExit As Decimal = VaDec(rw("ValExist"))
            If (Exist) <> 0 Then
                PMC = ValExit / Exist
            End If
            rw("PMC") = PMC


        Next
        Return ret



    End Function

    Private Function SaldosValesEnvases() As DataTable

        'Saldos ValesEnvases
        Dim sql As String = "SELECT " & vbCrLf
        sql = sql & " VEL_idenvase as IdEnvase,  ENV_nombre AS Envase, " & vbCrLf
        sql = sql & " VEL_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql = sql & " sum(VEL_entrega) as Entrega, sum(VEL_retira) as Retira," & vbCrLf
        sql = sql & " Sum(VEL_Entrega * VEL_precioentrega) as VEntrega, sum(VEL_Retira * VEL_precioretira) as VRetira," & vbCrLf
        sql = sql & " VEV_Operacion as Operacion, VEV_TipoSujeto as Ts," & vbCrLf
        sql = sql & " VEL_idalmacen as Idalmacen" & vbCrLf

        sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Envases ON VEL_idenvase = ENV_idenvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN ValeEnvases ON VEL_idvale = VEV_idvale" & vbCrLf
        sql = sql & " LEFT JOIN Marcas on MAR_IdMarca = VEL_IdMarca" & vbCrLf
        sql = sql & " WHERE VEV_Fecha >= '" & _dfecha & "'" & vbCrLf
        sql = sql & " AND VEV_fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf
        sql = sql & " Group by vel_idenvase,env_NOMBRE,Vel_IdMarca,Mar_Nombre,VeV_Operacion,Vev_tiposujeto,vel_Idalmacen "




        Dim dt As DataTable = Palets.MiConexion.ConsultaSQL(sql)

        Return dt

    End Function

    Private Function SaldosIniciales() As DataTable

        'Saldos iniciales
        Dim sql As String = "SELECT " & vbCrLf
        sql = sql & " ENI_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
        sql = sql & " ENI_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql = sql + " ENI_codigo as Idalmacen, " & vbCrLf
        sql = sql & " ENI_Inicial as ExistIni, ENI_inicial * ENI_precio as ValIni" & vbCrLf
        sql = sql & " FROM EnvasesInicial" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Envases ON ENI_idenvase = ENV_idenvase " & vbCrLf
        sql = sql & " LEFT OUTER JOIN Marcas on MAR_IdMarca = ENI_IdMarca" & vbCrLf
        sql = sql & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString & " AND ENI_Tipo = 'AL' " & vbCrLf

        Dim dt As DataTable = Palets.MiConexion.ConsultaSQL(sql)

        Return dt

    End Function

    Private Function SaldosInicialesSujetos(Tipo As String) As DataTable

        'Saldos iniciales
        Dim sql As String = "SELECT " & vbCrLf
        sql = sql & " ENI_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
        sql = sql & " ENI_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql = sql + " ENI_codigo as Codigo, " & vbCrLf
        sql = sql & " ENI_Inicial as ExistIni, ENI_precio as Precio," & vbCrLf
        Select Case Tipo
            Case "CL"
                sql = sql & " CLI_Nombre as Nombre " & vbCrLf

            Case "AG"
                sql = sql & " AGR_Nombre as Nombre " & vbCrLf

        End Select
        sql = sql & " FROM EnvasesInicial" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Envases ON ENI_idenvase = ENV_idenvase " & vbCrLf
        sql = sql & " LEFT OUTER JOIN Marcas on MAR_IdMarca = ENI_IdMarca" & vbCrLf
        Select Case Tipo
            Case "CL"
                sql = sql & " LEFT OUTER JOIN Clientes on CLI_Idcliente = ENI_codigo" & vbCrLf

            Case "AG"
                sql = sql & " LEFT OUTER JOIN Agricultores on AGR_Idagricultor = ENI_codigo" & vbCrLf


        End Select
        sql = sql & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString & " AND ENI_Tipo = '" + Tipo + "' " & vbCrLf
        sql = sql & "  AND ENI_PRECIO = 0 "
        sql = sql & " AND ENV_RETORNABLE='S' "

        Dim dt As DataTable = Palets.MiConexion.ConsultaSQL(sql)

        Return dt

    End Function
    Private Function SaldosValesEnvasesSujetos(Tipo As String) As DataTable

        'Saldos ValesEnvases
        Dim sql As String = "SELECT " & vbCrLf
        sql = sql & " VEL_idenvase as IdEnvase,  ENV_nombre AS Envase, " & vbCrLf
        sql = sql & " VEL_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql = sql & " sum(VEL_entrega) as Entrega, sum(VEL_retira) as Retira," & vbCrLf
        sql = sql & " VEL_precioentrega as PEntrega, VEL_precioretira as PRetira," & vbCrLf
        sql = sql & " VEV_Operacion as Operacion, VEV_TipoSujeto as Ts," & vbCrLf
        sql = sql & " VEV_Codigo as Codigo," & vbCrLf
        Select Case Tipo
            Case "C"
                sql = sql & " CLI_Nombre as Nombre " & vbCrLf

            Case "A"
                sql = sql & " AGR_Nombre as Nombre " & vbCrLf

        End Select

        sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Envases ON VEL_idenvase = ENV_idenvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN ValeEnvases ON VEL_idvale = VEV_idvale" & vbCrLf
        Select Case Tipo
            Case "C"
                sql = sql & " LEFT OUTER JOIN Clientes on CLI_Idcliente = VEV_codigo" & vbCrLf

            Case "A"
                sql = sql & " LEFT OUTER JOIN Agricultores on AGR_Idagricultor = VEV_codigo" & vbCrLf


        End Select



        sql = sql & " LEFT JOIN Marcas on MAR_IdMarca = VEL_IdMarca" & vbCrLf
        sql = sql & " WHERE VEV_Fecha >= '" & _dfecha & "'" & vbCrLf
        sql = sql & " AND VEV_fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf
        sql = sql & " AND VEL_PRECIOENTREGA=0 AND VEL_PRECIORETIRA=0 " & vbCrLf ' SOLO PASO LOS SIN PRECIO
        sql = sql & " AND VEV_TIPOSUJETO='" & Tipo & "' AND ENV_RETORNABLE='S'"
        sql = sql & " Group by vel_idenvase,env_NOMBRE,Vel_IdMarca,Mar_Nombre,VeV_Operacion,Vev_tiposujeto,vev_codigo,Vel_precioentrega,Vel_precioretira, "
        Select Case Tipo
            Case "C"
                sql = sql + " CLI_NOMBRE"
            Case "A"
                sql = sql + "AGR_NOMBRE"
        End Select




        Dim dt As DataTable = Palets.MiConexion.ConsultaSQL(sql)

        Return dt

    End Function



    Private Sub CargaGrid()

        GridView1.Columns.Clear()

        If RbInventario.Checked = True Then
            Grid.DataSource = CierreAlmacenes()
            AjustaColumnasAlmacenes()
        ElseIf RbClientes.Checked = True Then
            Grid.DataSource = CierreSujetos("CL")
            AjustaColumnasSUJETOS()
        ElseIf RbAgricultores.Checked = True Then
            Grid.DataSource = CierreSujetos("AG")
            AjustaColumnasSUJETOS()
        End If



    End Sub

    Private Sub AjustaColumnasAlmacenes()



        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim


                Case "IDENVASE"
                    c.Caption = "Cod"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.MaxWidth = 50
                    c.MinWidth = 50

                Case "ENVASE"
                    c.Caption = "Material"

                Case "IDALMACEN", "MARCA"


                Case "PMC"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.000000"
                    c.Width = 80

                Case Else
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 80

            End Select

        Next


        AñadeResumenCampo("ExistIni", "{0:n2}")
        AñadeResumenCampo("ValIni", "{0:n2}")
        AñadeResumenCampo("UdsCom", "{0:n2}")
        AñadeResumenCampo("ValCom", "{0:n2}")
        AñadeResumenCampo("MovEnv", "{0:n2}")
        AñadeResumenCampo("Consum", "{0:n2}")
        AñadeResumenCampo("Exist", "{0:n2}")
        Funciones.AñadeResumenCampo(GridView1, "PMC", "{0:n6}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("ValExist", "{0:n2}")


    End Sub

    Private Sub AjustaColumnasSUJETOS()



        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim


                Case "IDENVASE"
                    c.Caption = "Cod"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.MaxWidth = 50
                    c.MinWidth = 50

 

                Case "PRECIO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.000000"
                    c.Width = 80

                Case "SALDO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,###"
                    c.Width = 80

            End Select

        Next


        AñadeResumenCampo("Saldo", "{0:n0}")


    End Sub

    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()

        LineasDescripcion.Add("Desde fecha : " & TxEjerini.Text & "  Hasta fecha : " & TxHastaFecha.Text)





        MyBase.Imprimir()

    End Sub



    Private Sub BtAux_Click(sender As System.Object, e As System.EventArgs) Handles BtAux.Click
        If RbInventario.Checked = True Then
            GenerarAlmacenes()
        ElseIf RbClientes.Checked = True Then
            GeneraSujetos("CL")
        ElseIf RbAgricultores.Checked = True Then
            GeneraSujetos("AG")
        End If
    End Sub
    Private Sub GeneraSujetos(Tipo As String)
        Dim EnvasesInicial As New E_envasesInicial(Idusuario, cn)
        If MsgBox("Desea generar el inventario inicial", vbYesNo) = vbYes Then
            Dim dt As DataTable = CType(Grid.DataSource, DataTable)
            If Not dt Is Nothing Then
                Barra.Value = 0

                Dim sql As String
                sql = "Delete from envasesinicial where ENI_campa=" + TxEjerini.Text & " and eni_tipo='" + Tipo + "' "
                Palets.MiConexion.OrdenSql(sql)


                Barra.Maximum = dt.Rows.Count
                For Each rw In dt.Rows
                    If Barra.Value < Barra.Maximum Then
                        Barra.Value = Barra.Value + 1
                    End If

                    Dim saldo As Decimal = VaDec(rw("Saldo"))
                    Dim precio As Decimal = VaDec(rw("Precio"))
                    If saldo <> 0 Then
                        EnvasesInicial.VaciaEntidad()
                        Dim id As Integer = EnvasesInicial.MaxId
                        EnvasesInicial.ENI_id.Valor = id.ToString
                        EnvasesInicial.ENI_campa.Valor = TxEjerini.Text
                        EnvasesInicial.ENI_tipo.Valor = Tipo
                        EnvasesInicial.ENI_codigo.Valor = rw("Codigo").ToString
                        EnvasesInicial.ENI_idenvase.Valor = rw("IdEnvase").ToString
                        EnvasesInicial.ENI_idmarca.Valor = rw("IdMarca").ToString
                        EnvasesInicial.ENI_inicial.Valor = saldo.ToString
                        EnvasesInicial.ENI_precio.Valor = precio.ToString
                        EnvasesInicial.Insertar()
                    End If
                Next

            End If
            MsgBox("Terminado")
        End If

    End Sub
    Private Sub GenerarAlmacenes()
        Dim EnvasesInicial As New E_envasesInicial(Idusuario, cn)
        If MsgBox("Desea generar el inventario inicial", vbYesNo) = vbYes Then
            Dim dt As DataTable = CType(Grid.DataSource, DataTable)
            If Not dt Is Nothing Then
                Barra.Value = 0

                Dim sql As String
                sql = "Delete from envasesinicial where ENI_campa=" + TxEjerini.Text & " and eni_tipo='AL' "
                Palets.MiConexion.OrdenSql(sql)


                Barra.Maximum = dt.Rows.Count
                For Each rw In dt.Rows
                    If Barra.Value < Barra.Maximum Then
                        Barra.Value = Barra.Value + 1
                    End If
                
                    Dim exi As Decimal = VaDec(rw("exist"))
                    Dim pmc As Decimal = VaDec(rw("pmc"))
                    If exi <> 0 Then
                        EnvasesInicial.VaciaEntidad()
                        Dim id As Integer = EnvasesInicial.MaxId
                        EnvasesInicial.ENI_id.Valor = id.ToString
                        EnvasesInicial.ENI_campa.Valor = TxEjerini.Text
                        EnvasesInicial.ENI_tipo.Valor = "AL"
                        EnvasesInicial.ENI_codigo.Valor = rw("IdAlmacen").ToString
                        EnvasesInicial.ENI_idenvase.Valor = rw("IdEnvase").ToString
                        EnvasesInicial.ENI_idmarca.Valor = rw("IdMarca").ToString
                        EnvasesInicial.ENI_inicial.Valor = exi.ToString
                        EnvasesInicial.ENI_precio.Valor = pmc.ToString
                        EnvasesInicial.Insertar()
                    End If
                Next

            End If
            MsgBox("Terminado")
        End If
    End Sub
End Class

