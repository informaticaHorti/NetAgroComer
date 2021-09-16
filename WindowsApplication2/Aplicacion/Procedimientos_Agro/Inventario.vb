Module Inventario



    Dim Envases As New E_Envases(Idusuario, cn)
    Dim Valeenvases As New E_ValeEnvases(Idusuario, cn)
    Dim ValeEnvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)

    Public Function Agro_inventario(Hfecha As String, DCodigo As String, HCodigo As String, LstCodigos As List(Of String), LstAlmacenes As List(Of String), lstFamilias As List(Of String), CalculoPmc As Boolean) As DataTable
        Dim dtfinal1 As DataTable = Calculo_inventario(MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy"), Hfecha, DCodigo, HCodigo, LstCodigos, LstAlmacenes, lstFamilias, False, True) ' ARTICULO SIN MARCA
        Dim dtfinal2 As DataTable = Calculo_inventario(MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy"), Hfecha, DCodigo, HCodigo, LstCodigos, LstAlmacenes, lstFamilias, True, True) ' ARTICULOS CON MARCA

        dtfinal2.Merge(dtfinal1)

        Return dtfinal2
    End Function

    Private Function Calculo_inventario(Dfecha As String, Hfecha As String, DCodigo As String, HCodigo As String, LstCodigos As List(Of String), LstAlmacenes As List(Of String), lstFamilias As List(Of String), DtMarca As Boolean, CalculoPmc As Boolean) As DataTable
        Dim Ret As New DataTable

        Dim SqlInicial As String = SaldosIniciales(DCodigo, HCodigo, LstCodigos, LstAlmacenes, lstFamilias, DtMarca)
        Dim sqlcompras0 As String = AlbaranesCompra(Dfecha, Hfecha, DtMarca, DCodigo, HCodigo, LstCodigos, LstAlmacenes, lstFamilias, False)
        Dim sqlcompras As String = AlbaranesCompra(Dfecha, Hfecha, DtMarca, DCodigo, HCodigo, LstCodigos, LstAlmacenes, lstFamilias, True)
        Dim sqlvales As String = SaldosValesEnvases(Dfecha, Hfecha, DtMarca, DCodigo, HCodigo, LstCodigos, LstAlmacenes, lstFamilias)

        Dim SqlPalets As String = SaldosExistenciasPalets(DCodigo, HCodigo, Dfecha, Hfecha, DtMarca, LstCodigos, LstAlmacenes, lstFamilias)
        Dim sqlRecuento As String = SaldoRecuento(DCodigo, HCodigo, Hfecha, DtMarca, LstCodigos, LstAlmacenes, lstFamilias)
        Dim sqlinicialtotal As String = ""
        Dim sqlcomprastotal As String = ""

        If CalculoPmc = True Then
            sqlinicialtotal = SaldosInicialesTotal(DCodigo, HCodigo, LstCodigos, lstFamilias, DtMarca)
            sqlcomprastotal = AlbaranesCompraTOTAL(Dfecha, Hfecha, DtMarca, DCodigo, HCodigo, LstCodigos, lstFamilias)
        End If
        '  Dim sqlpmc As String = CalculoPmc(DCodigo, HCodigo, Dfecha, Hfecha, lstFamilias, DtMarca)

        Dim sql As String = "select IdfamiliaEnvase,FamiliaEnvase,IdEnvase,Envase,StMarca, "
        If DtMarca = True Then
            sql = sql + "idmarca,marca,"
        End If
        sql = sql & " sum(ExiIni) as ExiIni, sum(VexiIni) as VExiIni, " & vbCrLf
        sql = sql + " sum(udscom0) as UdsCom0,sum(UdsCom) as UdsCom,sum(Vcom)  as VCom, " & vbCrLf
        sql = sql & " Sum(MovEnv) as MovEnv," & vbCrLf
        sql = sql + " sum(ExiPal) as ExiPal, " & vbCrLf
        sql = sql + " sum(exiini+udscom0+udscom-movenv-exipal) AS Exist, " & vbCrLf
        sql = sql + " sum(Recuento) as Recuento, " & vbCrLf
        sql = sql + " sum(exiini+udscom0+udscom-movenv-exipal-Recuento) as Difer, " & vbCrLf
        sql = sql + " 0.00 as Pmc, " & vbCrLf
        ' sql = sql & " CASE SUM(ExiIni + UdsCom) WHEN 0 THEN 0 ELSE SUM(VCom + VExiIni)/SUM(ExiIni + UdsCom) END as PMC," & vbCrLf
        sql = sql + " 0.00 as ValExist, " & vbCrLf
        ' sql = sql & " CASE SUM(ExiIni + UdsCom) WHEN 0 THEN 0 ELSE sum(exiini++udscom0+udscom-movenv-exipal) * (SUM(VCom + VExiIni)/SUM(ExiIni + UdsCom)) END as ValExist," & vbCrLf
        sql = sql + " SUM(Vrecuento) as ValRec, " & vbCrLf
        'sql = sql + " 0.00 as Pmc_Recuento " & vbCrLf
        sql = sql & " CASE SUM(Recuento) WHEN 0 THEN 0 ELSE SUM(VRecuento) / SUM(Recuento) END as PMC_Recuento," & vbCrLf
        sql = sql & " sum(ExiIniTotal) as ExiIniTotal, sum(VexiIniTotal) as VExiIniTotal, " & vbCrLf
        sql = sql + " sum(UdsComTotal) as UdsComTotal,sum(VcomTotal)  as VComTotal " & vbCrLf

        sql = sql + " from ("
        sql = sql + SqlInicial & vbCrLf
        sql = sql + " union all " & vbCrLf
        sql = sql + sqlcompras0 & vbCrLf
        sql = sql + " union all " & vbCrLf
        sql = sql + sqlcompras & vbCrLf
        sql = sql + " union all " & vbCrLf
        sql = sql + sqlvales & vbCrLf
        sql = sql + " union all " & vbCrLf
        sql = sql + SqlPalets & vbCrLf
        sql = sql + " union all " & vbCrLf
        sql = sql + sqlRecuento & vbCrLf
        If CalculoPmc = True Then
            sql = sql + " union all " & vbCrLf
            sql = sql + sqlinicialtotal & vbCrLf
            sql = sql + " union all " & vbCrLf
            sql = sql + sqlcomprastotal & vbCrLf
        End If
        sql = sql + " ) as Existencias " & vbCrLf
        sql = sql + " WHERE COALESCE(IdEnvase,0) > 0" & vbCrLf
        If DtMarca = True Then
            sql = sql + " AND stmarca='S'"
        Else
            sql = sql + " and stmarca<>'S'"
        End If
        sql = sql + " GROUP BY idfamiliaenvase,FamiliaEnvase,idenvase,envase,stmarca "
        If DtMarca Then sql = sql + ",idmarca,marca "
        sql = sql + " order by idfamiliaenvase "




        Ret = Envases.MiConexion.ConsultaSQL(sql, , 500)


        For Each RW In Ret.Rows
            Dim U As Decimal = VaDec(RW("EXIINITOTAL")) + VaDec(RW("UDSCOMTOTAL"))
            Dim I As Decimal = VaDec(RW("VEXIINITOTAL")) + VaDec(RW("VCOMTOTAL"))
            If U <> 0 Then
                Dim PMC As Decimal = I / U
                RW("PMC") = PMC
                RW("VALEXIST") = PMC * RW("EXIST")
            End If
        Next


        Return Ret


    End Function




    Private Function CalculoPmc(Dcodigo As String, Hcodigo As String, Dfecha As String, Hfecha As String, lstFamilias As List(Of String), DtMarca As Boolean) As String



        Dim sql As String = ""

        sql = sql & " SELECT H.IDFAMILIAENVASE AS idfamiliaenvase,H.FamiliaEnvase as FamiliaEnvase,  " & vbCrLf
        sql = sql & " H.IDENVASE AS IDENVASE,H.ENVASE AS ENVASE, H.STMARCA AS STMARCA," & vbCrLf
        If DtMarca Then sql = sql & " H.IDMARCA AS IDMARCA,H.MARCA AS MARCA, " & vbCrLf
        sql = sql & " 0.00 as ExiIni, 0.00 as VexiIni, " & vbCrLf
        sql = sql & " 0.00 as UdsCom0,0.00 AS UdsCom,0.00  as VCom, " & vbCrLf
        sql = sql & " 0.00 as MovEnv," & vbCrLf
        sql = sql & " 0.00 as ExiPal, " & vbCrLf
        sql = sql & " 0.00 as Recuento, " & vbCrLf
        sql = sql & " 0.00 as VRecuento ," & vbCrLf
        sql = sql & " H.PMC AS PMC FROM (" & vbCrLf
        sql = sql & " SELECT G.IDFAMILIAENVASE AS IDFAMILIAENVASE,G.FAMILIAENVASE AS FAMILIAENVASE, " & vbCrLf
        sql = sql & " G.IDENVASE AS IDENVASE,G.ENVASE AS ENVASE,G.STMARCA AS STMARCA," & vbCrLf
        If DtMarca Then sql = sql & " G.IDMARCA AS IDMARCA,G.MARCA AS MARCA, " & vbCrLf
        sql = sql & " SUM(G.EXIINI) AS EXIINI,SUM(G.VEXIINI) AS VEXIINI,SUM(G.UCOMPRA) AS UCOMPRA,SUM(G.VCOMPRA) AS VCOMPRA," & vbCrLf
        sql = sql & " CASE SUM(G.EXIINI + G.UCOMPRA) WHEN 0 THEN 0 ELSE SUM(G.VCOMPRA + G.VEXIINI)/SUM(G.EXIINI + G.UCOMPRA) END as PMC" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " select env_idfamiliaenvase as idfamiliaenvase,FEV_Nombre as FamiliaEnvase, " & vbCrLf
        sql = sql & " eni_idenvase as idenvase,env_nombre as envase,env_stockmarca as Stmarca," & vbCrLf
        If DtMarca Then
            sql = sql & " eni_idmarca as idmarca,COALESCE(mar_NOMBRE,'') as marca, " & vbCrLf
        End If
        sql = sql & " sum(Eni_inicial) as ExiIni," & vbCrLf
        sql = sql & " sum(Eni_inicial*eni_precio) as Vexiini," & vbCrLf
        sql = sql & " 0.0 as Ucompra," & vbCrLf
        sql = sql & " 0.0 as Vcompra" & vbCrLf
        sql = sql & " from(envasesinicial)" & vbCrLf
        sql = sql & " LEFT OUTER JOIN eNvases ON eni_idenvase = env_idenvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Marcas on MAR_IdMarca = ENI_IdMarca" & vbCrLf
        sql = sql & " where eni_campa=" & MiMaletin.Ejercicio.ToString & "  and eni_tipo='AL'" & vbCrLf
        If DtMarca = True Then
            sql = sql & " and env_stockmarca='S'" & vbCrLf
        Else
            sql = sql & " and env_stockmarca<>'S'" & vbCrLf

        End If
        sql = sql + CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, " AND ")
        sql = sql & " GROUP BY ENI_IDENVASE" & vbCrLf
        If DtMarca = True Then
            sql = sql & ",eni_idmarca" & vbCrLf
        End If
        sql = sql & "         union all" & vbCrLf

        sql = sql & "  select env_idfamiliaenvase as idfamiliaenvase,FEV_Nombre as FamiliaEnvase, " & vbCrLf
        sql = sql & " vel_idenvase as idenvase,env_nombre as envase,env_stockmarca as stmarca," & vbCrLf
        If DtMarca = True Then sql = sql & " vel_idmarca as idmarca,COALESCE(MAR_NOMBRE,'') as marca," & vbCrLf
        sql = sql & " 0.0 as exiini," & vbCrLf
        sql = sql & " 0.0 as Vexiini," & vbCrLf
        sql = sql & " sum(vel_entrega) AS Ucompra," & vbCrLf
        sql = sql & " sum(vel_entrega*vel_precioentrega) as Vcompra" & vbCrLf
        sql = sql & " from(ValeEnvases_lineas)" & vbCrLf
        sql = sql & " LEFT OUTER JOIN ValeEnvases ON VEL_idvale = VEV_idvale" & vbCrLf
        sql = sql & " LEFT OUTER JOIN eNvases ON vel_idenvase = env_idenvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Marcas on MAR_IdMarca = VEL_IdMarca" & vbCrLf
        sql = sql & " Where vev_operacion='AC' and VEL_PRECIOENTREGA<>0" & vbCrLf
        sql = sql & " AND VEV_Fecha >= '" & Dfecha & "' " & vbCrLf
        sql = sql & " AND VEV_fecha <= '" & Hfecha & "' " & vbCrLf
        If DtMarca = True Then
            sql = sql & " and env_stockmarca='S'" & vbCrLf
        Else
            sql = sql & " and env_stockmarca<>'S'" & vbCrLf

        End If
        sql = sql + CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, " AND ")

        sql = sql & " GROUP BY VEL_IDENVASE" & vbCrLf
        If DtMarca = True Then sql = sql + ", VEL_IDMARCA" & vbCrLf
        sql = sql & " ) AS G " & vbCrLf
        sql = sql & " GROUP BY  G.IDFAMILIAENVASE,G.FAMILIAENVASE, G.IDENVASE,G.ENVASE,G.STMARCA" & vbCrLf
        If DtMarca = True Then sql = sql + ",G.IDMARCA,G.MARCA" & vbCrLf
        sql = sql & " ) AS H" & vbCrLf


        Return sql



    End Function


    Private Function SaldosValesEnvases(Dfecha As String, Hfecha As String, Dtmarca As Boolean, dcodigo As String, Hcodigo As String, lstcodigos As List(Of String), lstalmacenes As List(Of String), lstFamilias As List(Of String)) As String

        'Saldos ValesEnvases
        Dim sql As String = "SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase," & vbCrLf
        sql = sql & " VEL_idenvase as IdEnvase,  ENV_nombre AS Envase, ENV_StockMarca as STMarca, " & vbCrLf
        If Dtmarca Then sql = sql & " VEL_IdMarca as IdMarca, COALESCE(MAR_Nombre,'') as Marca," & vbCrLf
        sql = sql + " 0.00 as ExiIni,0.00  as Vexiini, " & vbCrLf
        sql = sql + " 0.00 as UdsCom0,0.00 AS UdsCom,0.00  as VCom, " & vbCrLf
        sql = sql & " sum(VEL_Retira-VEL_Entrega) as MovEnv," & vbCrLf
        sql = sql + " 0.00 as ExiPal, " & vbCrLf
        sql = sql + " 0.00 as Recuento, " & vbCrLf
        sql = sql + " 0.00 as VRecuento, " & vbCrLf
        sql = sql & " 0.00 as ExiIniTotal, 0.00 as VexiIniTotal, " & vbCrLf
        sql = sql + " 0.00 as UdsComTotal, " & vbCrLf
        sql = sql + " 0.00 as VComTotal " & vbCrLf



        sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Envases ON VEL_idenvase = ENV_idenvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN ValeEnvases ON VEL_idvale = VEV_idvale" & vbCrLf
        If Dtmarca Then sql = sql & " LEFT JOIN Marcas on MAR_IdMarca = VEL_IdMarca" & vbCrLf
        sql = sql & " WHERE VEV_FECHA BETWEEN '" & Dfecha & "' AND '" & Hfecha & "' "
        '  sql = sql & " WHERE VEV_Fecha >= '" & Dfecha & "'" & vbCrLf
        '  sql = sql & " AND VEV_fecha <= '" & Hfecha & "'" & vbCrLf
        sql = sql & " AND VEV_OPERACION<>'AC' " & vbCrLf

        If dcodigo <> "" Then
            sql = sql & " AND VEL_IDENVASE >= " & dcodigo
        End If
        If Hcodigo <> "" Then
            sql = sql & " AND VEL_IDENVASE <= " & Hcodigo
        End If
        If lstcodigos.Count > 0 Then
            sql = sql & CadenaWhereLista(ValeEnvases_lineas.VEL_idenvase, lstcodigos, "AND")
        End If
        sql = sql & CadenaWhereLista(ValeEnvases_lineas.VEL_idalmacen, lstalmacenes, "AND")
        If lstFamilias.Count > 0 Then
            sql = sql & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, "AND")
        End If
        If Dtmarca = True Then
            sql = sql & " AND ENV_STOCKMARCA='S' "
        Else
            sql = sql & " AND ENV_STOCKMARCA<>'S' "
        End If
        sql = sql + " GROUP BY ENV_idfamiliaenvase,FEV_nombre,VEL_idenvase,ENV_NOMBRE,ENV_StockMarca "
        If Dtmarca Then sql = sql + ",VEL_idmarca,MAR_Nombre"
        Return sql

    End Function


    Private Function AlbaranesCompra(Dfecha As String, Hfecha As String, Dtmarca As Boolean, dcodigo As String, Hcodigo As String, lstcodigos As List(Of String), lstAlmacenes As List(Of String), lstFamilias As List(Of String), Valoradas As Boolean) As String

        'Saldos ValesEnvases
        Dim sql As String = "SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase," & vbCrLf
        sql = sql & " VEL_idenvase as IdEnvase,  ENV_nombre AS Envase,ENV_StockMarca as STMarca, " & vbCrLf
        If Dtmarca Then sql = sql & " VEL_IdMarca as IdMarca, COALESCE(MAR_Nombre,'') as Marca," & vbCrLf
        sql = sql + " 0.00 as ExiIni,0.00  as Vexiini, " & vbCrLf
        If Valoradas = True Then
            sql = sql + " 0.00 as UdsCom0, " & vbCrLf
            sql = sql + " sum(VEL_Entrega) as UdsCom, " & vbCrLf

        Else
            sql = sql + " sum(VEL_Entrega) as UdsCom0, " & vbCrLf
            sql = sql + " 0.00 as UdsCom, " & vbCrLf
        End If
        sql = sql + " sum(VEL_Entrega * VEL_precioentrega)  as VCom, " & vbCrLf
        sql = sql & " 0.00 as MovEnv," & vbCrLf
        sql = sql + " 0.00 as ExiPal, " & vbCrLf
        sql = sql + " 0.00 as Recuento, " & vbCrLf
        sql = sql + " 0.00 as VRecuento, " & vbCrLf
        sql = sql & " 0.00 as ExiIniTotal, 0.00 as VexiIniTotal, " & vbCrLf
        sql = sql + " 0.00 as UdsComTotal, " & vbCrLf
        sql = sql + " 0.00 as VComTotal " & vbCrLf


        sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Envases ON VEL_idenvase = ENV_idenvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN ValeEnvases ON VEL_idvale = VEV_idvale" & vbCrLf
        If Dtmarca Then sql = sql & " LEFT JOIN Marcas on MAR_IdMarca = VEL_IdMarca" & vbCrLf
        sql = sql & " WHERE VEV_FECHA BETWEEN '" & Dfecha & "' AND '" & Hfecha & "' "
        '        sql = sql & " WHERE VEV_Fecha >= '" & Dfecha & "'" & vbCrLf
        '        sql = sql & " AND VEV_fecha <= '" & Hfecha & "'" & vbCrLf
        sql = sql & " AND VEV_OPERACION='AC' " & vbCrLf

        If dcodigo <> "" Then
            sql = sql & " AND VEL_IDENVASE >= " & dcodigo
        End If
        If Hcodigo <> "" Then
            sql = sql & " AND VEL_IDENVASE <= " & Hcodigo
        End If
        If lstcodigos.Count > 0 Then
            sql = sql & CadenaWhereLista(ValeEnvases_lineas.VEL_idenvase, lstcodigos, "AND")
        End If
        sql = sql & CadenaWhereLista(ValeEnvases_lineas.VEL_idalmacen, lstAlmacenes, "AND")
        If lstFamilias.Count > 0 Then
            sql = sql & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, "AND")
        End If
        If Dtmarca = True Then
            sql = sql & " AND ENV_STOCKMARCA='S' "
        Else
            sql = sql & " AND ENV_STOCKMARCA<>'S' "
        End If
        If Valoradas = True Then
            sql = sql & " and VEL_precioentrega<>0 "
        Else
            sql = sql & " and VEL_precioentrega=0 "

        End If
        sql = sql + " GROUP BY ENV_idfamiliaenvase,FEV_nombre,VEL_idenvase,ENV_NOMBRE,ENV_StockMarca "
        If Dtmarca Then sql = sql + ",VEL_idmarca,MAR_Nombre"
        Return sql

    End Function


    Private Function SaldosIniciales(Dcodigo As String, Hcodigo As String, lstcodigos As List(Of String), lstAlmacenes As List(Of String), lstFamilias As List(Of String), DtMarca As Boolean) As String

        'Saldos iniciales
        Dim EnvasesIniciales As New E_envasesInicial(Idusuario, cn)
        Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
        Dim sql As String = "SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase," & vbCrLf
        sql = sql & " ENI_IdEnvase as IdEnvase, ENV_Nombre as Envase,ENV_StockMarca as StMarca, " & vbCrLf
        If DtMarca Then sql = sql & " ENI_IdMarca as IdMarca, COALESCE(MAR_Nombre,'') as Marca," & vbCrLf
        sql = sql & " sum(ENI_Inicial) as ExiIni, sum(ENI_inicial * ENI_precio) as VexiIni, " & vbCrLf
        sql = sql + " 0.00 as UdsCom0,0.00 AS UdsCom,0.00  as VCom, " & vbCrLf
        sql = sql & " 0.00 as MovEnv," & vbCrLf
        sql = sql + " 0.00 as ExiPal, " & vbCrLf
        sql = sql + " 0.00 as Recuento, " & vbCrLf
        sql = sql + " 0.00 as VRecuento, " & vbCrLf
        sql = sql & " 0.00 as ExiIniTotal, 0.00 as VexiIniTotal, " & vbCrLf
        sql = sql + " 0.00 as UdsComTotal, " & vbCrLf
        sql = sql + " 0.00 as VComTotal " & vbCrLf



        sql = sql & " FROM EnvasesInicial" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Envases ON ENI_idenvase = ENV_idenvase " & vbCrLf
        sql = sql & " LEFT OUTER JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Marcas on MAR_IdMarca = ENI_IdMarca" & vbCrLf
        sql = sql & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString & " AND ENI_Tipo = 'AL' " & vbCrLf
        'If IdAlmacen.Trim <> "" Then sql = sql & " AND ENI_Codigo = " & IdAlmacen & vbCrLf
        If Dcodigo <> "" Then
            sql = sql & " AND ENI_IDENVASE >= " & Dcodigo
        End If
        If Hcodigo <> "" Then
            sql = sql & " AND ENI_IDENVASE <= " & Hcodigo
        End If
        If lstcodigos.Count > 0 Then
            sql = sql & CadenaWhereLista(EnvasesIniciales.ENI_idenvase, lstcodigos, "AND")
        End If
        sql = sql & CadenaWhereLista(EnvasesIniciales.ENI_codigo, lstAlmacenes, "AND")
        If lstFamilias.Count > 0 Then
            sql = sql & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, "AND")
        End If
        If DtMarca = True Then
            sql = sql & " AND ENV_STOCKMARCA='S' "
        Else
            sql = sql & " AND ENV_STOCKMARCA<>'S' "
        End If
        sql = sql + " GROUP BY ENV_idfamiliaenvase,FEV_nombre,ENI_idenvase,ENV_NOMBRE,ENV_StockMarca "
        If DtMarca Then sql = sql + ",ENI_idmarca,MAR_Nombre"

        Return sql

    End Function


    Private Function SaldosExistenciasPalets(Dcodigo As String, HCodigo As String, Dfecha As String, Hfecha As String, dtmarcas As Boolean, lstcodigos As List(Of String), lstAlmacenes As List(Of String), lstFamilias As List(Of String)) As String
        'Private Function SaldosExistenciasPalets(lstAlmacenes As List(Of String), lstFamilias As List(Of String)) As DataTable
        Dim sql1 As String = ExiPalets_Palets(Dcodigo, HCodigo, Dfecha, Hfecha, dtmarcas, lstcodigos, lstAlmacenes, lstFamilias)
        Dim sql2 As String = ExiPalets_Envases(Dcodigo, HCodigo, Dfecha, Hfecha, dtmarcas, lstcodigos, lstAlmacenes, lstFamilias)


        Dim sql As String = "select IdfamiliaEnvase,FamiliaEnvase,IdEnvase,Envase,StMarca, "
        If dtmarcas = True Then
            sql = sql + "idmarca,marca,"
        End If
        sql = sql & " 0.00 as ExiIni, 0.00 as VexiIni, " & vbCrLf
        sql = sql + " 0.00 as UdsCom0, 0.00 AS UdsCom, 0.00  as VCom, " & vbCrLf
        sql = sql & " 0.00 as MovEnv," & vbCrLf
        sql = sql + " sum(Expalets) as ExiPal, " & vbCrLf
        sql = sql + " 0.00 as Recuento, " & vbCrLf
        sql = sql + " 0.00 as VRecuento, " & vbCrLf
        sql = sql & " 0.00 as ExiIniTotal, 0.00 as VexiIniTotal, " & vbCrLf
        sql = sql + " 0.00 as UdsComTotal, " & vbCrLf
        sql = sql + " 0.00 as VComTotal " & vbCrLf


        sql = sql + " from ("
        sql = sql + sql1 & vbCrLf
        sql = sql + " union all " & vbCrLf
        sql = sql + sql2 & vbCrLf

        sql = sql + " ) as Mpalets " & vbCrLf


        sql = sql + " GROUP BY idfamiliaenvase,FamiliaEnvase,idenvase,envase,stmarca "
        If dtmarcas Then sql = sql + ",idmarca,marca"

        ' Dim DT As DataTable = Envases.MiConexion.ConsultaSQL(sql)

        Return sql




    End Function

    Private Function ExiPalets_Palets(Dcodigo As String, HCodigo As String, Dfecha As String, Hfecha As String, dtmarcas As Boolean, lstcodigos As List(Of String), lstAlmacenes As List(Of String), lstFamilias As List(Of String)) As String

        Dim Palets As New E_palets(Idusuario, cn)
        Dim SQL As String = " SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase,"
        SQL = SQL & " ENV_IdEnvase as IdEnvase, ENV_Nombre as Envase,ENV_StockMarca as STMarca, "
        If dtmarcas Then SQL = SQL & " 0 as IdMarca, '' as Marca,"
        SQL = SQL & " sum(CPL_cantidad ) as ExPalets"
        SQL = SQL & " FROM Palets_Lineas"
        SQL = SQL & " LEFT JOIN Palets ON PAL_IdPalet = PLL_IdPalet"
        SQL = SQL & " LEFT JOIN ConfecPalet on CPA_IdConfec = PAL_IdTipoPalet"
        SQL = SQL & " LEFT JOIN ConfecPaletLineas ON CPL_IdConfec = CPA_IdConfec"
        SQL = SQL & " LEFT JOIN Envases ON ENV_IdEnvase = CPL_idmaterial "
        SQL = SQL & " LEFT JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase"
        SQL = SQL & " LEFT JOIN AlbSalida_Palets ON ASP_IdPalet = PAL_IdPalet"
        SQL = SQL & " LEFT JOIN AlbSalida ON ASA_IdAlbaran = ASP_IdAlbaran" & vbCrLf
        SQL = SQL & " WHERE (COALESCE(ASP_IdAlbaran, 0) = 0 OR ASA_FechaSalida > '" & Hfecha & "')" & vbCrLf
        SQL = SQL & " AND PAL_Fecha >= '" & Dfecha & "' AND PAL_Fecha <= '" & Hfecha & "'"
        SQL = SQL & " AND PAL_envasepropio='S' " & vbCrLf
        SQL = SQL & " AND PAL_idtipopalet > 0 "
        If Dcodigo <> "" Then
            SQL = SQL & " AND CPL_IDMATERIAL >= " & Dcodigo
        End If
        If HCodigo <> "" Then
            SQL = SQL & " AND CPL_IDMATERIAL <= " & HCodigo
        End If
        If lstcodigos.Count > 0 Then
            SQL = SQL & CadenaWhereLista(Envases.ENV_IdEnvase, lstcodigos, "AND")
        End If
        SQL = SQL & CadenaWhereLista(Palets.PAL_idpvsituacion, lstAlmacenes, "AND")
        If lstFamilias.Count > 0 Then
            SQL = SQL & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, "AND") & vbCrLf
        End If
        SQL = SQL + " GROUP BY ENV_idfamiliaenvase,FEV_nombre,ENV_idenvase,ENV_NOMBRE,ENV_StockMarca "
        ' If dtmarcas Then SQL = SQL + ",idmarca,marca"


        Return SQL

    End Function

    Private Function ExiPalets_Envases(Dcodigo As String, HCodigo As String, Dfecha As String, Hfecha As String, dtmarcas As Boolean, lstcodigos As List(Of String), lstAlmacenes As List(Of String), lstFamilias As List(Of String)) As String
        Dim Palets As New E_palets(Idusuario, cn)
        Dim sql As String = "Select idfamiliaenvase,Familiaenvase,Idenvase,Envase,Stmarca,"
        If dtmarcas Then sql = sql + " idmarca,Marca,"
        sql = sql + " sum(Expalets) as ExPalets "
        sql = sql + " From ( "
        sql = sql + " SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase,"
        sql = sql & " ENV_IdEnvase as IdEnvase, ENV_Nombre as Envase,ENV_StockMarca as StMarca, "
        If dtmarcas Then
            sql = sql & sqlMarcas()
        End If
        sql = sql & " CEL_cantidad * PLL_Bultos as ExPalets"
        sql = sql & " FROM Palets_Lineas"
        sql = sql & " LEFT JOIN Palets ON PAL_IdPalet = PLL_IdPalet"
        sql = sql & " LEFT JOIN ConfecEnvase on CEV_IdConfec = PLL_IdTipoConfeccion"
        sql = sql & " LEFT JOIN ConfecEnvaseLineas ON CEV_IdConfec = CEL_IdConfec"
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = CEL_idmaterial "
        sql = sql & " LEFT JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase"
        sql = sql & " LEFT JOIN Marcas MarcaEnv ON MarcaEnv.MAR_IdMarca = PLL_IdMarca"
        sql = sql & " LEFT JOIN Marcas MarcaEti ON MarcaEti.MAR_IdMarca = PLL_IdMarcaEti" & vbCrLf
        sql = sql & " LEFT JOIN Marcas MarcaMat ON MarcaMat.MAR_IdMarca = PLL_IdMarcaMat" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida_Palets ON ASP_IdPalet = PAL_IdPalet"
        sql = sql & " LEFT JOIN AlbSalida ON ASA_IdAlbaran = ASP_IdAlbaran" & vbCrLf
        sql = sql & " WHERE (COALESCE(ASP_IdAlbaran, 0) = 0 OR ASA_FechaSalida > '" & Hfecha & "')" & vbCrLf
        sql = sql & " AND PAL_Fecha >= '" & Dfecha & "' AND PAL_Fecha <= '" & Hfecha & "'"
        sql = sql & " AND PAL_envasepropio='S' " & vbCrLf
        If Dcodigo <> "" Then
            sql = sql & " AND CEL_IDMATERIAL >= " & Dcodigo
        End If
        If HCodigo <> "" Then
            sql = sql & " AND CEL_IDMATERIAL <= " & HCodigo
        End If


        sql = sql & CadenaWhereLista(Palets.PAL_idpvsituacion, lstAlmacenes, "AND")
        If lstFamilias.Count > 0 Then
            sql = sql & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, "AND") & vbCrLf
        End If
        If lstcodigos.Count > 0 Then
            sql = sql & CadenaWhereLista(Envases.ENV_IdEnvase, lstcodigos, "AND")
        End If

        If dtmarcas = True Then
            sql = sql & " AND ENV_STOCKMARCA='S' "
        Else
            sql = sql & " AND ENV_STOCKMARCA<>'S' "
        End If
        sql = sql + ") as G "
        sql = sql + " GROUP BY idfamiliaenvase,familiaenvase,idenvase,envase,STMARCA "
        If dtmarcas Then sql = sql + ",idmarca,marca"


        Return sql

    End Function



    Private Function sqlMarcas() As String

        Dim sql As String = ""


        sql = sql & " CASE ENV_StockMarca WHEN 'S' THEN " & vbCrLf
        sql = sql & " CASE ENV_Tipo WHEN 'E' THEN PLL_IdMarca WHEN 'Q' THEN PLL_IdMarcaEti WHEN 'M' THEN PLL_IdMarcaMat END " & vbCrLf
        sql = sql & " ELSE 0 END as IdMarca," & vbCrLf

        sql = sql & " CASE ENV_StockMarca WHEN 'S' THEN " & vbCrLf
        sql = sql & " CASE ENV_Tipo WHEN 'E' THEN COALESCE(MarcaEnv.MAR_Nombre,'') WHEN 'Q' THEN COALESCE(MarcaEti.MAR_Nombre,'') WHEN 'M' THEN COALESCE(MarcaMat.MAR_Nombre,'') END " & vbCrLf
        sql = sql & " ELSE '' END as Marca," & vbCrLf
        'sql = sql & " CASE ENV_Tipo WHEN 'E' THEN PLL_IdMarca WHEN 'Q' THEN PLL_IdMarcaEti WHEN 'M' THEN PLL_IdMarcaMat END as IdMarca,"
        'sql = sql & " CASE ENV_Tipo WHEN 'E' THEN COALESCE(MarcaEnv.MAR_Nombre,'') WHEN 'Q' THEN COALESCE(MarcaEti.MAR_Nombre,'') WHEN 'M' THEN COALESCE(MarcaMat.MAR_Nombre,'') END as Marca,"


        Return sql

    End Function





    Private Function sqlMarcasEti() As String

        Dim sql As String = ""


        sql = sql & " CASE ENV_StockMarca WHEN 'S' THEN " & vbCrLf
        sql = sql & " COALESCE(Marcas.MAR_IDMARCA,0)  " & vbCrLf
        sql = sql & " ELSE 0 END  AS idmarca, " & vbCrLf

        sql = sql & " CASE ENV_StockMarca WHEN 'S' THEN " & vbCrLf
        sql = sql & " COALESCE(Marcas.MAR_Nombre,'') " & vbCrLf
        sql = sql & " ELSE '' END as Marca, " & vbCrLf


        Return sql

    End Function


    Private Function SaldoRecuento(Dcodigo As String, Hcodigo As String, hfecha As String, dtmarcas As Boolean, lstcodigos As List(Of String), lstAlmacenes As List(Of String), lstFamilias As List(Of String)) As String

        Dim REcuento As New E_Recuento(Idusuario, cn)
        Dim sql As String = "SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase," & vbCrLf
        sql = sql & " REL_IdMaterial as IdEnvase, ENV_Nombre as Envase,ENV_StockMarca as StMarca, " & vbCrLf
        If dtmarcas Then sql = sql & " REL_IdMarca as IdMarca, COALESCE(MAR_Nombre, '') as Marca," & vbCrLf
        sql = sql & " 0.00 as ExiIni, 0.00 as VexiIni, " & vbCrLf
        sql = sql + " 0.00 as UdsCom0,0.00 AS UdsCom,0.00  as VCom, " & vbCrLf
        sql = sql & " 0.00 as MovEnv," & vbCrLf
        sql = sql + " 0.00 as ExiPal, " & vbCrLf
        sql = sql + " sum(Rel_unidades) as Recuento, " & vbCrLf
        sql = sql + " sum(Rel_unidades*Rel_PMC) as Vrecuento, " & vbCrLf
        sql = sql & " 0.00 as ExiIniTotal, 0.00 as VexiIniTotal, " & vbCrLf
        sql = sql + " 0.00 as UdsComTotal, " & vbCrLf
        sql = sql + " 0.00 as VComTotal " & vbCrLf


        sql = sql & " FROM Recuento_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN Recuento ON REC_IdRecuento = REL_IdRecuento" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = REL_IdMaterial" & vbCrLf
        sql = sql & " LEFT JOIN FamiliaEnvases ON ENV_IdFamiliaEnvase = FEV_IdFamilia" & vbCrLf
        sql = sql & " LEFT JOIN Marcas ON REL_IdMarca = MAR_IdMarca" & vbCrLf
        sql = sql & " WHERE REC_Fecha = '" & hfecha & "'" & vbCrLf
        If Dcodigo <> "" Then
            sql = sql & " AND REL_IDMATERIAL >= " & Dcodigo
        End If
        If Hcodigo <> "" Then
            sql = sql & " AND REL_IDMATERIAL <= " & Hcodigo
        End If


        'sql = sql & " AND REC_IdCentro = " & IdAlmacen & vbCrLf
        If lstcodigos.Count > 0 Then
            sql = sql & CadenaWhereLista(Envases.ENV_IdEnvase, lstcodigos, "AND")
        End If
        sql = sql & CadenaWhereLista(REcuento.REC_IdCentro, lstAlmacenes, "AND")
        If lstFamilias.Count > 0 Then
            sql = sql & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, "AND")
        End If
        sql = sql + " GROUP BY ENV_idfamiliaenvase,FEV_nombre,REL_idmaterial,ENV_NOMBRE,ENV_STOCKMARCA "
        If dtmarcas Then sql = sql + ",REL_idmarca,MAR_Nombre"

        Return sql




    End Function


    Private Function SaldosInicialesTotal(Dcodigo As String, Hcodigo As String, lstcodigos As List(Of String), lstFamilias As List(Of String), DtMarca As Boolean) As String

        'Saldos iniciales sin tener en cuenta el almacén para calcular el precio medio

        Dim EnvasesIniciales As New E_envasesInicial(Idusuario, cn)
        Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
        Dim sql As String = "SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase," & vbCrLf
        sql = sql & " ENI_IdEnvase as IdEnvase, ENV_Nombre as Envase,ENV_StockMarca as StMarca, " & vbCrLf
        If DtMarca Then sql = sql & " ENI_IdMarca as IdMarca, COALESCE(MAR_Nombre,'') as Marca," & vbCrLf
        sql = sql & " 0.00 as ExiIni, 0.00 as VexiIni, " & vbCrLf
        sql = sql + " 0.00 as UdsCom0,0.00 AS UdsCom,0.00  as VCom, " & vbCrLf
        sql = sql & " 0.00 as MovEnv," & vbCrLf
        sql = sql + " 0.00 as ExiPal, " & vbCrLf
        sql = sql + " 0.00 as Recuento, " & vbCrLf
        sql = sql + " 0.00 as VRecuento, " & vbCrLf
        sql = sql & " sum(ENI_Inicial) as ExiIniTotal, sum(ENI_inicial * ENI_precio) as VexiIniTotal, " & vbCrLf
        sql = sql + " 0.00 as UdsComTotal, " & vbCrLf
        sql = sql + " 0.00  as VComTotal " & vbCrLf



        sql = sql & " FROM EnvasesInicial" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Envases ON ENI_idenvase = ENV_idenvase " & vbCrLf
        sql = sql & " LEFT OUTER JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Marcas on MAR_IdMarca = ENI_IdMarca" & vbCrLf
        sql = sql & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString & " AND ENI_Tipo = 'AL' " & vbCrLf
        'If IdAlmacen.Trim <> "" Then sql = sql & " AND ENI_Codigo = " & IdAlmacen & vbCrLf
        If Dcodigo <> "" Then
            sql = sql & " AND ENI_IDENVASE >= " & Dcodigo
        End If
        If Hcodigo <> "" Then
            sql = sql & " AND ENI_IDENVASE <= " & Hcodigo
        End If
        If lstcodigos.Count > 0 Then
            sql = sql & CadenaWhereLista(Envases.ENV_IdEnvase, lstcodigos, "AND")
        End If
        If lstFamilias.Count > 0 Then
            sql = sql & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, "AND")
        End If
        If DtMarca = True Then
            sql = sql & " AND ENV_STOCKMARCA='S' "
        Else
            sql = sql & " AND ENV_STOCKMARCA<>'S' "
        End If
        sql = sql + " and ENI_PRECIO <> 0 " 'solo valorados

        sql = sql + " GROUP BY ENV_idfamiliaenvase,FEV_nombre,ENI_idenvase,ENV_NOMBRE,ENV_StockMarca "
        If DtMarca Then sql = sql + ",ENI_idmarca,MAR_Nombre"

        Return sql

    End Function

    Private Function AlbaranesCompraTOTAL(Dfecha As String, Hfecha As String, Dtmarca As Boolean, dcodigo As String, Hcodigo As String, lstcodigos As List(Of String), lstFamilias As List(Of String)) As String

        'suma de todas las compras VALORADAS, sin tener en cuenta el almacén para calcular el pmc

        Dim sql As String = "SELECT ENV_IdFamiliaEnvase as IdFamiliaEnvase, FEV_Nombre as FamiliaEnvase," & vbCrLf
        sql = sql & " VEL_idenvase as IdEnvase,  ENV_nombre AS Envase,ENV_StockMarca as STMarca, " & vbCrLf
        If Dtmarca Then sql = sql & " VEL_IdMarca as IdMarca, COALESCE(MAR_Nombre,'') as Marca," & vbCrLf
        sql = sql + " 0.00 as ExiIni,0.00  as Vexiini, " & vbCrLf
        sql = sql + " 0.00 as UdsCom0,0.00 AS UdsCom,0.00  as VCom, " & vbCrLf
        sql = sql & " 0.00 as MovEnv," & vbCrLf
        sql = sql + " 0.00 as ExiPal, " & vbCrLf
        sql = sql + " 0.00 as Recuento, " & vbCrLf
        sql = sql + " 0.00 as VRecuento, " & vbCrLf
        sql = sql & " 0.00 as ExiIniTotal, 0.00 as VexiIniTotal, " & vbCrLf
        sql = sql + " sum(VEL_Entrega) as UdsComTotal, " & vbCrLf
        sql = sql + " sum(VEL_Entrega * VEL_precioentrega)  as VComTotal " & vbCrLf


        sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
        sql = sql & " LEFT OUTER JOIN Envases ON VEL_idenvase = ENV_idenvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN FamiliaEnvases ON FEV_IdFamilia = ENV_IdFamiliaEnvase" & vbCrLf
        sql = sql & " LEFT OUTER JOIN ValeEnvases ON VEL_idvale = VEV_idvale" & vbCrLf
        If Dtmarca Then sql = sql & " LEFT JOIN Marcas on MAR_IdMarca = VEL_IdMarca" & vbCrLf
        sql = sql & " WHERE VEV_FECHA BETWEEN '" & Dfecha & "' AND '" & Hfecha & "' "
        '        sql = sql & " WHERE VEV_Fecha >= '" & Dfecha & "'" & vbCrLf
        '        sql = sql & " AND VEV_fecha <= '" & Hfecha & "'" & vbCrLf
        sql = sql & " AND VEV_OPERACION='AC' " & vbCrLf

        If dcodigo <> "" Then
            sql = sql & " AND VEL_IDENVASE >= " & dcodigo
        End If
        If Hcodigo <> "" Then
            sql = sql & " AND VEL_IDENVASE <= " & Hcodigo
        End If
        If lstcodigos.Count > 0 Then
            sql = sql & CadenaWhereLista(Envases.ENV_IdEnvase, lstcodigos, "AND")
        End If
        If lstFamilias.Count > 0 Then
            sql = sql & CadenaWhereLista(Envases.ENV_IdfamiliaEnvase, lstFamilias, "AND")
        End If
        If Dtmarca = True Then
            sql = sql & " AND ENV_STOCKMARCA='S' "
        Else
            sql = sql & " AND ENV_STOCKMARCA<>'S' "
        End If
        sql = sql & " and VEL_precioentrega<>0 "
        sql = sql + " GROUP BY ENV_idfamiliaenvase,FEV_nombre,VEL_idenvase,ENV_NOMBRE,ENV_StockMarca "
        If Dtmarca Then sql = sql + ",VEL_idmarca,MAR_Nombre"
        Return sql

    End Function



End Module
