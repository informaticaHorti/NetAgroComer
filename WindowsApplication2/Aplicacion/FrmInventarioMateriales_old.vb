Imports DevExpress.XtraEditors.Controls

Public Class FrmInventarioMateriales_OLD

    Inherits FrConsulta


    Private Class stClave_Inventario

        Public IdFamiliaEnvase As Integer = 0
        Public FamiliaEnvase As String = ""
        Public IdEnvase As Integer = 0
        Public Envase As String = ""
        Public IdMarca As Integer = 0
        Public Marca As String = ""
        Public Inventariable As String = ""


        Public Sub New(IdFamiliaEnvase As Integer, FamiliaEnvase As String, IdEnvase As Integer, Envase As String,
                       IdMarca As Integer, Marca As String, Inventariable As String)

            Me.IdFamiliaEnvase = IdFamiliaEnvase
            Me.FamiliaEnvase = FamiliaEnvase
            Me.IdEnvase = IdEnvase
            Me.Envase = Envase
            Me.IdMarca = IdMarca
            Me.Marca = Marca
            Me.Inventariable = Inventariable

        End Sub

    End Class


    Private Class stDatos_Inventario

        Public ExistIni As Decimal = 0
        Public ValIni As Decimal = 0
        Public UdsCom As Decimal = 0
        Public ValCom As Decimal = 0
        Public MovEnv As Decimal = 0
        Public Consum As Decimal = 0
        Public ExPalets As Decimal = 0
        Public Exist As Decimal = 0
        Public Recuento As Decimal = 0
        Public Difer As Decimal = 0
        Public PMC As Decimal = 0
        Public ValExist As Decimal = 0
        Public UdsInv As Decimal = 0
        Public ValInv As Decimal = 0
        Public ValRec As Decimal = 0
        Public Total As Decimal = 0


        Public Sub New(ExistIni As Decimal, ValIni As Decimal, UdsCom As Decimal, ValCom As Decimal, MovEnv As Decimal,
                Consum As Decimal, ExPalets As Decimal, Recuento As Decimal, UdsInv As Decimal)

            Me.ExistIni = ExistIni
            Me.ValIni = ValIni
            Me.UdsCom = UdsCom
            Me.ValCom = ValCom
            Me.MovEnv = MovEnv
            Me.Consum = Consum
            Me.ExPalets = ExPalets
            Me.Recuento = Recuento
            Me.UdsInv = UdsInv

        End Sub

    End Class



    Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim ValeEnvases_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
    Dim EnvasesIniciales As New E_envasesInicial(Idusuario, cn)
    Dim Palets As New E_palets(Idusuario, cn)
    Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
    Dim Recuento As New E_Recuento(Idusuario, cn)
    Dim Recuento_Lineas As New E_Recuento_Lineas(Idusuario, cn)


    Private err As New Errores()



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Nothing, Lb1, True, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato2, Nothing, Lb1, True, Cdatos.TiposCampo.Fecha)
        ParamChk(chkMarcas, Nothing, "S", "N")
        'ParamChk(ChkActuprecios, Nothing, "S", "N")


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()


        CbMarcas.Enabled = chkMarcas.Checked

    End Sub


    Private Sub Fechaspordefecto()
        TxDato1.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxDato2.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()

    End Sub


    Private Sub CargaGrid()


        'Dim IdAlmacen As String = ""
        'If VaInt(CbAlmacenes.SelectedValue) Then IdAlmacen = VaInt(CbAlmacenes.SelectedValue).ToString

        Dim lstAlmacenes As List(Of String) = ListadeCombo(cbAlmacenes)
        Dim lstFamilias As List(Of String) = ListadeCombo(CbFamilias)
        Dim lstMarcas As List(Of String)

        If chkMarcas.Checked Then
            lstMarcas = ListadeCombo(CbMarcas)
        Else
            lstMarcas = New List(Of String)
        End If



        Dim acum As New Acumulador

        'If ChkActuprecios.CheckState = CheckState.Checked Then
        '    ActualizaPreciosMateriales()
        'End If


        'Saldos ValeEnvases
        Dim dt As DataTable = SaldosValesEnvases(lstAlmacenes, lstFamilias, lstMarcas)

        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows

                Dim IdFamiliaEnvase As Integer = VaInt(row("IdFamiliaEnvase"))
                Dim FamiliaEnvase As String = (row("FamiliaEnvase").ToString & "").Trim
                Dim IdEnvase As Integer = VaInt(row("IdEnvase"))
                Dim Envase As String = (row("Envase").ToString & "").Trim
                Dim Inventariable As String = (row("Inventariable").ToString & "").Trim.ToUpper

                Dim IdMarca As Integer = 0
                Dim Marca As String = ""
                If chkMarcas.Checked Then
                    IdMarca = VaInt(row("IdMarca"))
                    Marca = (row("Marca").ToString & "").Trim
                End If


                Dim Operacion As String = (row("Operacion").ToString & "").Trim.ToUpper
                Dim Fecha As Date = VaDate(row("Fecha"))

                Dim UdsCom As Decimal = 0
                Dim ValCom As Decimal = 0
                Dim MovEnv As Decimal = 0
                Dim Consum As Decimal = 0
                Dim UdsInv As Decimal = 0

                'Dim Ts As String = (row("Ts").ToString & "").Trim.ToUpper
                'If Ts = "A" Then
                'End if



                If (Operacion = "RI" Or Operacion = "EB") And Fecha >= VaDate("01/01/2015") Then
                    UdsInv = VaDec(row("Retira")) - VaDec(row("Entrega"))
                End If


                Select Case Operacion

                    Case "AC"
                        UdsCom = VaDec(row("Entrega"))
                        ValCom = VaDec(row("VEntrega"))
                    Case "CN"
                        Consum = VaDec(row("Retira"))
                    Case Else
                        MovEnv = VaDec(row("Retira")) - VaDec(row("Entrega"))

                End Select



                Dim stClave As New stClave_Inventario(IdFamiliaEnvase, FamiliaEnvase, IdEnvase, Envase, IdMarca, Marca, Inventariable)
                Dim stDatos As New stDatos_Inventario(0, 0, UdsCom, ValCom, MovEnv, Consum, 0, 0, UdsInv)

                acum.Suma(stClave, stDatos)


            Next
        End If


        'Saldos iniciales
        dt = SaldosIniciales(lstAlmacenes, lstFamilias, lstMarcas)

        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows

                Dim IdFamiliaEnvase As Integer = VaInt(row("IdFamiliaEnvase"))
                Dim FamiliaEnvase As String = (row("FamiliaEnvase").ToString & "").Trim
                Dim IdEnvase As Integer = VaInt(row("IdEnvase"))
                Dim Envase As String = (row("Envase").ToString & "").Trim
                Dim Inventariable As String = (row("Inventariable").ToString & "").Trim.ToUpper


                Dim IdMarca As Integer = 0
                Dim Marca As String = ""
                If chkMarcas.Checked Then
                    IdMarca = VaInt(row("IdMarca"))
                    Marca = (row("Marca").ToString & "").Trim
                End If


                Dim ExistIni As Decimal = VaDec(row("ExistIni"))
                Dim ValIni As Decimal = VaDec(row("ValInI"))


                Dim stClave As New stClave_Inventario(IdFamiliaEnvase, FamiliaEnvase, IdEnvase, Envase, IdMarca, Marca, Inventariable)
                Dim stDatos As New stDatos_Inventario(ExistIni, ValIni, 0, 0, 0, 0, 0, 0, 0)

                acum.Suma(stClave, stDatos)

            Next
        End If


        'Existencias Palets
        dt = SaldosExistenciasPalets(lstAlmacenes, lstMarcas)

        'Aplicamos filtro en dataview porque en la consulta sql se enlentece muchisimo
        Dim dv As New DataView(dt)
        Dim Filtro As String = CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, ListadeCombo(CbFamilias), "")
        Filtro = Filtro.Replace("ENV_idfamiliaenvase", "IdFamiliaEnvase")
        dv.RowFilter = Filtro
        dt = dv.ToTable

        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows

                Dim IdFamiliaEnvase As Integer = VaInt(row("IdFamiliaEnvase"))
                Dim FamiliaEnvase As String = (row("FamiliaEnvase").ToString & "").Trim
                Dim IdEnvase As Integer = VaInt(row("IdEnvase"))
                Dim Envase As String = (row("Envase").ToString & "").Trim
                Dim Inventariable As String = (row("Inventariable").ToString & "").Trim.ToUpper

                Dim IdMarca As Integer = 0
                Dim Marca As String = ""
                If chkMarcas.Checked Then
                    IdMarca = VaInt(row("IdMarca"))
                    Marca = (row("Marca").ToString & "").Trim
                End If

                Dim ExPalets As Decimal = VaDec(row("ExPalets"))


                Dim stClave As New stClave_Inventario(IdFamiliaEnvase, FamiliaEnvase, IdEnvase, Envase, IdMarca, Marca, Inventariable)
                Dim stDatos As New stDatos_Inventario(0, 0, 0, 0, 0, 0, ExPalets, 0, 0)

                acum.Suma(stClave, stDatos)

            Next
        End If


        'Recuento existencias
        dt = SaldoRecuento(lstAlmacenes, lstFamilias, lstMarcas)

        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows

                Dim IdFamiliaEnvase As Integer = VaInt(row("IdFamiliaEnvase"))
                Dim FamiliaEnvase As String = (row("FamiliaEnvase").ToString & "").Trim
                Dim IdEnvase As Integer = VaInt(row("IdEnvase"))
                Dim Envase As String = (row("Envase").ToString & "").Trim
                Dim Inventariable As String = (row("Inventariable").ToString & "").Trim.ToUpper

                Dim IdMarca As Integer = 0
                Dim Marca As String = ""
                If chkMarcas.Checked Then
                    IdMarca = VaInt(row("IdMarca"))
                    Marca = (row("Marca").ToString & "").Trim
                End If

                Dim Recuento As Decimal = VaDec(row("Unidades"))

                Dim stClave As New stClave_Inventario(IdFamiliaEnvase, FamiliaEnvase, IdEnvase, Envase, IdMarca, Marca, Inventariable)
                Dim stDatos As New stDatos_Inventario(0, 0, 0, 0, 0, 0, 0, Recuento, 0)

                acum.Suma(stClave, stDatos)

            Next
        End If



        'Completamos los datos
        'MsgBox("Completa datatable")
        Dim dtFinal As DataTable = acum.DataTable

        For Each row As DataRow In dtFinal.Rows

            Dim ExistIni As Decimal = VaDec(row("ExistIni"))
            Dim UdsCom As Decimal = VaDec(row("UdsCom"))
            Dim MovEnv As Decimal = VaDec(row("MovEnv"))
            Dim Consum As Decimal = VaDec(row("Consum"))
            Dim ExPalets As Decimal = VaDec(row("ExPalets"))

            Dim ValIni As Decimal = VaDec(row("ValIni"))
            Dim ValCom As Decimal = VaDec(row("ValCom"))

            Dim Exist = ExistIni + UdsCom - MovEnv - Consum - ExPalets
            row("Exist") = Exist

            Dim Recuento As Decimal = VaDec(row("Recuento"))
            Dim Difer As Decimal = Exist - Recuento
            row("Difer") = Difer


            Dim PMC As Decimal = 0
            If (ExistIni + UdsCom) <> 0 Then
                PMC = (ValIni + ValCom) / (ExistIni + UdsCom)
            End If
            row("PMC") = PMC

            row("ValExist") = Exist * PMC
            row("ValRec") = Recuento * PMC

            Dim UdsInv As Decimal = VaDec(row("UdsInv"))
            row("ValInv") = UdsInv * PMC


            'Dim Total As Decimal = (Exist * PMC) + (UdsInv * PMC)
            'row("Total") = Total

            Dim Total As Decimal = (Recuento * PMC) + (UdsInv * PMC)
            row("Total") = Total



        Next
        'MsgBox("Fin")


        If Not chkMarcas.Checked Then
            If dtFinal.Columns.Contains("IdMarca") Then dtFinal.Columns.Remove("IdMarca")
            If dtFinal.Columns.Contains("Marca") Then dtFinal.Columns.Remove("Marca")
        End If


        If dtFinal.Rows.Count > 0 Then
            Dim dav As New DataView(dtFinal)
            dav.Sort = "FamiliaEnvase, IdFamiliaEnvase, IdEnvase"
            dtFinal = dav.ToTable
        End If




        GridView1.Columns.Clear()
        Grid.DataSource = dtFinal

        AjustaColumnas()


    End Sub


    Private Function SaldosValesEnvases(lstAlmacenes As List(Of String), lstFamilias As List(Of String),
                                        lstMarcas As List(Of String)) As DataTable

        'Saldos ValesEnvases
        Dim sql As String = "SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase," & vbCrLf
        sql = sql & " VEL_idenvase as IdEnvase,  ENV_nombre AS Envase, " & vbCrLf
        If chkMarcas.Checked Then sql = sql & " VEL_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql = sql & " VEL_entrega as Entrega, VEL_retira as Retira," & vbCrLf
        sql = sql & " (VEL_Entrega * VEL_precioentrega) as VEntrega, (VEL_Retira * VEL_precioretira) as VRetira," & vbCrLf
        sql = sql & " VEV_Operacion as Operacion, ENV_Inventariable as Inventariable, VEV_TipoSujeto as Ts," & vbCrLf
        sql = sql & " VEV_Fecha as Fecha" & vbCrLf
        sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Envases ON VEL_idenvase = ENV_idenvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN ValeEnvases ON VEL_idvale = VEV_idvale" & vbCrLf
        sql = sql & " LEFT JOIN Marcas on MAR_IdMarca = VEL_IdMarca" & vbCrLf
        sql = sql & " WHERE VEV_Fecha >= '" & TxDato1.Text & "'" & vbCrLf
        sql = sql & " AND VEV_fecha <= '" & TxDato2.Text & "'" & vbCrLf
        sql = sql & CadenaWhereLista(ValeEnvases_Lineas.VEL_idalmacen, lstAlmacenes, "AND")
        sql = sql & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, "AND")
        If chkMarcas.Checked Then
            sql = sql & CadenaWhereLista(ValeEnvases_Lineas.VEL_idmarca, lstMarcas, "AND")
        End If

        Dim dt As DataTable = AlmacenEnvases.MiConexion.ConsultaSQL(sql)

        Return dt

    End Function


    Private Function SaldosIniciales(lstAlmacenes As List(Of String), lstFamilias As List(Of String),
                                     lstMarcas As List(Of String)) As DataTable

        'Saldos iniciales
        Dim sql As String = "SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase," & vbCrLf
        sql = sql & " ENI_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
        If chkMarcas.Checked Then sql = sql & " ENI_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql = sql & " ENI_Inicial as ExistIni, ENI_inicial * ENI_precio as ValIni, ENV_Inventariable as Inventariable" & vbCrLf
        sql = sql & " FROM EnvasesInicial" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Envases ON ENI_idenvase = ENV_idenvase " & vbCrLf
        sql = sql & " LEFT OUTER JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Marcas on MAR_IdMarca = ENI_IdMarca" & vbCrLf
        sql = sql & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString & " AND ENI_Tipo = 'AL' " & vbCrLf
        'If IdAlmacen.Trim <> "" Then sql = sql & " AND ENI_Codigo = " & IdAlmacen & vbCrLf
        sql = sql & CadenaWhereLista(EnvasesIniciales.ENI_codigo, lstAlmacenes, "AND")
        sql = sql & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, "AND")
        If chkMarcas.Checked Then
            sql = sql & CadenaWhereLista(EnvasesIniciales.ENI_idmarca, lstMarcas, "AND")
        End If
        Dim dt As DataTable = AlmacenEnvases.MiConexion.ConsultaSQL(sql)

        Return dt

    End Function


    Private Function SaldosExistenciasPalets(lstAlmacenes As List(Of String),
                                             lstMarcas As List(Of String)) As DataTable


        Dim sql As String = "SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase, " & vbCrLf
        sql = sql & " ENV_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
        If chkMarcas.Checked Then sql = sql & " 0 as IdMarca, '' as Marca," & vbCrLf
        sql = sql & " CPL_Cantidad as ExPalets, ENV_Inventariable as Inventariable" & vbCrLf
        sql = sql & " FROM Palets" & vbCrLf
        sql = sql & " LEFT JOIN ConfecPalet on CPA_IdConfec = PAL_IdtipoPalet" & vbCrLf
        sql = sql & " LEFT JOIN ConfecPaletLineas on CPL_IdConfec = CPA_IdConfec" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = CPL_IdMaterial" & vbCrLf
        sql = sql & " LEFT JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida_Palets ON ASP_IdPalet = PAL_IdPalet" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida ON ASA_IdAlbaran = ASP_IdAlbaran" & vbCrLf
        sql = sql & " WHERE (COALESCE(ASP_IdAlbaran, 0) = 0 OR ASA_FechaSalida > '" & TxDato2.Text & "')" & vbCrLf
        sql = sql & " AND PAL_Fecha >= '" & TxDato1.Text & "' AND PAL_Fecha <= '" & TxDato2.Text & "'"
        sql = sql & " AND PAL_envasepropio='S' " & vbCrLf
        sql = sql & CadenaWhereLista(Palets.PAL_idpvsituacion, lstAlmacenes, "AND") & vbCrLf
        If chkMarcas.Checked Then
            sql = sql & CadenaWhereLista_CAMPO("0", Cdatos.TiposCampo.EnteroPositivo, lstMarcas, "AND") & vbCrLf
        End If
        sql = sql & " UNION ALL" & vbCrLf

        sql = sql & " SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase,"
        sql = sql & " ENV_IdEnvase as IdEnvase, ENV_Nombre as Envase, " & vbCrLf
        If chkMarcas.Checked Then
            sql = sql & " CASE ENV_Tipo WHEN 'E' THEN PLL_IdMarca WHEN 'Q' THEN PLL_IdMarcaEti WHEN 'M' THEN PLL_IdMarcaMat ELSE '' END as IdMarca," & vbCrLf
            sql = sql & " CASE ENV_Tipo WHEN 'E' THEN MarcasEnv.MAR_Nombre WHEN 'Q' THEN MarcasEti.MAR_Nombre WHEN 'M' THEN MarcasMat.MAR_Nombre ELSE '' END as Marca," & vbCrLf
        End If
        sql = sql & " (CEL_cantidad * PLL_Bultos) as ExPalets, ENV_Inventariable as Inventariable" & vbCrLf
        sql = sql & " FROM Palets_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN Palets ON PAL_IdPalet = PLL_IdPalet" & vbCrLf
        sql = sql & " LEFT JOIN ConfecEnvase on CEV_IdConfec = PLL_IdTipoConfeccion" & vbCrLf
        sql = sql & " LEFT JOIN ConfecEnvaseLineas ON CEV_IdConfec = CEL_IdConfec" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = CEL_idmaterial " & vbCrLf
        sql = sql & " LEFT JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql = sql & " LEFT JOIN Marcas MarcasEnv ON MarcasEnv.MAR_IdMarca = PLL_IdMarca" & vbCrLf
        sql = sql & " LEFT JOIN Marcas MarcasEti ON MarcasEti.MAR_IdMarca = PLL_IdMarcaEti" & vbCrLf
        sql = sql & " LEFT JOIN Marcas MarcasMat ON MarcasMat.MAR_IdMarca = PLL_IdMarcaMat" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida_Palets ON ASP_IdPalet = PAL_IdPalet" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida ON ASA_IdAlbaran = ASP_IdAlbaran" & vbCrLf
        sql = sql & " WHERE (COALESCE(ASP_IdAlbaran, 0) = 0 OR ASA_FechaSalida > '" & TxDato2.Text & "')" & vbCrLf
        sql = sql & " AND PAL_Fecha >= '" & TxDato1.Text & "' AND PAL_Fecha <= '" & TxDato2.Text & "'" & vbCrLf
        sql = sql & " AND PAL_envasepropio='S' " & vbCrLf
        sql = sql & CadenaWhereLista(Palets.PAL_idpvsituacion, lstAlmacenes, "AND") & vbCrLf
        If chkMarcas.Checked Then
            sql = sql & CadenaWhereLista(Palets_Lineas.PLL_idmarca, lstMarcas, "AND") & vbCrLf
        End If

        Dim dt As DataTable = AlmacenEnvases.MiConexion.ConsultaSQL(sql)

        Return dt

    End Function


    Private Function SaldoRecuento(lstAlmacenes As List(Of String), lstFamilias As List(Of String),
                                   lstMarcas As List(Of String)) As DataTable

        Dim sql As String = "SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase," & vbCrLf
        sql = sql & " REL_IdMaterial as IdEnvase, ENV_Nombre as Envase," & vbCrLf
        If chkMarcas.Checked Then sql = sql & " REL_IdMarca as IdMarca, MAR_Nombre as Marca," & vbCrLf
        sql = sql & " REL_Unidades as Unidades, " & vbCrLf
        sql = sql & " ENV_Inventariable as Inventariable" & vbCrLf
        sql = sql & " FROM Recuento_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN Recuento ON REC_IdRecuento = REL_IdRecuento" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = REL_IdMaterial" & vbCrLf
        sql = sql & " LEFT JOIN FamiliaEnvases ON ENV_IdFamiliaEnvase = FEV_IdFamilia" & vbCrLf
        sql = sql & " LEFT JOIN Marcas ON REL_IdMarca = MAR_IdMarca" & vbCrLf
        sql = sql & " WHERE REC_Fecha = '" & TxDato2.Text & "'" & vbCrLf
        sql = sql & CadenaWhereLista(Recuento.REC_IdCentro, lstAlmacenes, "AND")
        sql = sql & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, "AND")
        If chkMarcas.Checked Then
            sql = sql & CadenaWhereLista(Recuento_Lineas.REL_IdMarca, lstMarcas, "AND")
        End If
        Dim dt As DataTable = AlmacenEnvases.MiConexion.ConsultaSQL(sql)

        Return dt

    End Function


    Private Sub AjustaColumnas()

        With GridView1.Columns

            If Not IsNothing(.ColumnByFieldName("IdMarca")) Then .ColumnByFieldName("IdMarca").Visible = False
            If Not IsNothing(.ColumnByFieldName("Inventariable")) Then .ColumnByFieldName("Inventariable").Visible = False
            If Not IsNothing(.ColumnByFieldName("UdsInv")) Then .ColumnByFieldName("UdsInv").Visible = False
            If Not IsNothing(.ColumnByFieldName("ValInv")) Then .ColumnByFieldName("ValInv").Visible = False
            If Not IsNothing(.ColumnByFieldName("PMC_Recuento")) Then .ColumnByFieldName("PMC_Recuento").Visible = False
            If Not IsNothing(.ColumnByFieldName("Total")) Then .ColumnByFieldName("Total").Visible = False
            If Not IsNothing(.ColumnByFieldName("FamiliaEnvase")) Then
                .ColumnByFieldName("FamiliaEnvase").GroupIndex = 1
                .ColumnByFieldName("FamiliaEnvase").Visible = False
            End If

        End With


        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim

                Case "IDFAMILIAENVASE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#"
                    c.MaxWidth = 35

                Case "IDENVASE"
                    c.Caption = "Cod"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.MaxWidth = 50
                    c.MinWidth = 50

                Case "ENVASE"
                    c.Caption = "Material"

                Case "MARCA"


                Case "PMC", "PMC_RECUENTO"
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
        AñadeResumenCampo("ExPalets", "{0:n2}")
        AñadeResumenCampo("Exist", "{0:n2}")
        AñadeResumenCampo("Recuento", "{0:n2}")
        AñadeResumenCampo("Difer", "{0:n2}")
        Funciones.AñadeResumenCampo(GridView1, "PMC", "{0:n6}", DevExpress.Data.SummaryItemType.Custom)
        AñadeResumenCampo("ValExist", "{0:n2}")
        AñadeResumenCampo("ValRec", "{0:n2}")
        Funciones.AñadeResumenCampo(GridView1, "PMC_Recuento", "{0:n6}", DevExpress.Data.SummaryItemType.Custom)


    End Sub


    Public Overrides Sub CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs)
        MyBase.CustomSummaryCalculate(sender, e)


        Try


            If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

                If e.IsGroupSummary Then

                    Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = e.Item

                    If item.FieldName.ToUpper.Trim = "PMC" Then

                        Dim PMC As Decimal = 0

                        Dim ExistIni As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(0)))
                        Dim ValIni As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(1)))
                        Dim UdsCom As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(2)))
                        Dim ValCom As Decimal = VaDec(GridView1.GetGroupSummaryValue(e.GroupRowHandle, GridView1.GroupSummary(3)))

                        If (ExistIni + UdsCom) <> 0 Then PMC = (ValIni + ValCom) / (ExistIni + UdsCom)

                        e.TotalValue = PMC

                    End If


                End If


                If e.IsTotalSummary Then

                    Dim item As DevExpress.XtraGrid.GridColumnSummaryItem = e.Item
                    If item.FieldName.ToUpper.Trim = "PMC" Then

                        Dim PMC As Decimal = 0
                        Dim ExistIni As Decimal = 0
                        Dim UdsCom As Decimal = 0
                        Dim ValIni As Decimal = 0
                        Dim ValCom As Decimal = 0


                        Dim colExistIni As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("ExistIni")
                        If Not IsNothing(colExistIni) Then ExistIni = VaDec(colExistIni.SummaryItem.SummaryValue)

                        Dim colValIni As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("ValIni")
                        If Not IsNothing(colValIni) Then ValIni = VaDec(colValIni.SummaryItem.SummaryValue)

                        Dim colUdsCom As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("UdsCom")
                        If Not IsNothing(colUdsCom) Then UdsCom = VaDec(colUdsCom.SummaryItem.SummaryValue)

                        Dim colValCom As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.ColumnByFieldName("ValCom")
                        If Not IsNothing(colValCom) Then ValCom = VaDec(colValCom.SummaryItem.SummaryValue)


                        If (ExistIni + UdsCom) <> 0 Then PMC = (ValIni + ValCom) / (ExistIni + UdsCom)

                        e.TotalValue = PMC

                    End If


                End If

            End If




        Catch ex As Exception

        End Try


    End Sub


    Private Sub FrmInventarioMaterialesPorFecha_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim fuente_nueva As New Font(fuente.FontFamily, fuente.Size + 1, FontStyle.Bold)
        GridView1.Appearance.GroupRow.Font = fuente_nueva

        GridView1.OptionsView.ShowGroupPanel = False


        cbAlmacenes = ComboAlmacenEnvases(cbAlmacenes, MiMaletin.IdPuntoVenta)


        Dim dt As New DataTable
        Dim sql As String = "SELECT FEV_IdFamilia as Familia, FEV_Nombre as Nombre FROM FamiliaEnvases ORDER BY Familia"
        dt = cn.ConsultaSQL(sql)

        CbFamilias.Properties.DataSource = dt
        CbFamilias.Properties.ValueMember = "Familia"
        CbFamilias.Properties.DisplayMember = "Nombre"


        Dim dtMarcas As New DataTable
        sql = "SELECT MAR_IdMarca as IdMarca, MAR_Nombre as Nombre FROM Marcas ORDER BY MAR_Nombre"
        dt = cn.ConsultaSQL(sql)


        Dim RW As DataRow = dt.NewRow
        RW("Idmarca") = 0
        RW("Nombre") = "Sin marca"
        dt.Rows.Add(RW)
        CbMarcas.Properties.DataSource = dt
        CbMarcas.Properties.ValueMember = "IdMarca"
        CbMarcas.Properties.DisplayMember = "Nombre"
        CbMarcas.CheckAll()



    End Sub



    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()


        LineasDescripcion.Add("Desde fecha : " & TxDato1.Text & "  Hasta fecha : " & TxDato2.Text)

        Dim almacenes As String = FiltroCheckedComboBox("Almacen", cbAlmacenes)
        Dim familias As String = FiltroCheckedComboBox("Familia", CbFamilias)


        If familias <> "" Then LineasDescripcion.Add(familias)
        If almacenes <> "" Then LineasDescripcion.Add(almacenes)

        If chkMarcas.Checked Then

            LineasDescripcion.Add("Listado con marcas")

            Dim marcas As String = FiltroCheckedComboBox("Marcas", CbMarcas)
            If marcas <> "" Then LineasDescripcion.Add(marcas)

        End If


        MyBase.Imprimir()

    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()

        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim lstAlmacenes As New List(Of String)
                For Each it As CheckedListBoxItem In cbAlmacenes.Properties.GetItems()
                    If it.CheckState = CheckState.Checked Then
                        lstAlmacenes.Add(it.Value.ToString)
                    End If
                Next

                Dim lstFamilias As New List(Of String)
                For Each it As CheckedListBoxItem In CbFamilias.Properties.GetItems()
                    If it.CheckState = CheckState.Checked Then
                        lstFamilias.Add(it.Value.ToString)
                    End If
                Next

                Dim listado As New Listado_InventarioMateriales(dt, TxDato1.Text, TxDato2.Text, chkMarcas.Checked, lstAlmacenes, lstFamilias, TipoImpresion.Preliminar)
                listado.ImprimirListado()

            Else
                bDatos = False
            End If
        Else
            bDatos = False
        End If


        If Not bDatos Then
            MessageBox.Show("No hay datos que imprimir")
        End If

    End Sub

    Private Sub ClButton1_Click(sender As System.Object, e As System.EventArgs) Handles ClButton1.Click

        Dim sql As String = "SELECT IdAlbaran, IdVale, Albaran, CE, ImporteAlb, ROUND(ImporteVale,2) AS ImporteVale" & vbCrLf
        sql = sql & " FROM" & vbCrLf
        sql = sql & " (" & vbCrLf
        sql = sql & " SELECT AMA_IdAlb as IdAlbaran, AMA_Numero as Albaran, AMA_IdCentro as CE, AMA_IdValeEnvase as IdVale, " & vbCrLf
        sql = sql & " AMA_Importe as ImporteAlb," & vbCrLf
        sql = sql & " (SELECT SUM(COALESCE(VEL_Entrega,0) * COALESCE(VEL_PrecioEntrega,0)) as ImporteVale FROM ValeEnvases_Lineas WHERE VEL_IdVale = AMA_IdValeEnvase) as ImporteVale" & vbCrLf
        sql = sql & " FROM AlbMaterial" & vbCrLf
        sql = sql & " LEFT JOIN AlbMaterialLineas ON AMA_IdAlb = AML_IdAlb" & vbCrLf
        sql = sql & " GROUP BY AMA_IdAlb, AMA_IdCentro, AMA_Numero, AMA_IdValeEnvase, AMA_Importe" & vbCrLf
        sql = sql & " ) AS K" & vbCrLf
        sql = sql & " WHERE ABS(COALESCE(ImporteAlb, 0) - ROUND(COALESCE(ImporteVale, 0), 2)) > 0.02" & vbCrLf
        sql = sql & " ORDER BY Albaran" & vbCrLf

        Dim dt As DataTable = ValeEnvases_Lineas.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            Dim lstParametros As New List(Of Parametros)
            lstParametros.Add(New Parametros("IdAlbaran", False, "", -1))
            lstParametros.Add(New Parametros("IdVale", False, "", -1))
            lstParametros.Add(New Parametros("Albaran", False, "", 70))
            lstParametros.Add(New Parametros("CE", False, "", 25))
            lstParametros.Add(New Parametros("ImporteAlb", False, "#,##0.00", 80))
            lstParametros.Add(New Parametros("ImporteVale", False, "#,##0.00", 80))

            Dim frm As New FrConsultaGenerica(dt, lstParametros, "Comprobar precios de compra")
            frm.ShowDialog()
        Else
            MsgBox("No hay datos")
        End If


    End Sub


    Private Sub chkMarcas_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMarcas.CheckedChanged

        CbMarcas.Enabled = chkMarcas.Checked

    End Sub

End Class

