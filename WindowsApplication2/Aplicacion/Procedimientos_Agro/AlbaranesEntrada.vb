Module AlbaranesEntrada


    Public Function Agro_HistorialCultivoAgricultor(IdAgricultor As String, IdCultivo As String, IdGenero As String) As DataTable

        Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)


        Dim sqlWhere As String = "WHERE AEL_IdCultivo = " & IdCultivo & vbCrLf
        If VaInt(IdGenero) > 0 Then sqlWhere = sqlWhere & " AND AEL_IdGenero = " & IdGenero & vbCrLf
        sqlWhere = sqlWhere & " AND AEN_IdAgricultor = " & IdAgricultor & vbCrLf


        Dim sql As String = "SELECT Fecha, IdLinea, Partida, IdGenero, Genero, SUM(KilosA) as KilosA, SUM(KilosB) as KilosB, SUM(KilosC) as KilosC, SUM(KilosD) as KilosD, SUM(Destrio) as Destrio," & vbCrLf
        sql = sql & " SUM(KilosA + KilosB + KilosC + KilosD + Destrio) as Total, Observaciones" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT IdLinea, Partida, Fecha, IdGenero, Genero, KilosA, 0 as KilosB, 0 as KilosC, 0 as KilosD, 0 as Destrio, Observaciones" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT AEL_IdLinea as IdLinea, AEL_Muestreo as Partida, AEN_Fecha as Fecha, AEL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN AEL_IdCategoria ELSE ALC_IdCategoria END as IdCategoria," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN COALESCE(AEL_KilosNetos,0) ELSE COALESCE(ALC_KilosNetos,0) END as KilosA," & vbCrLf
        sql = sql & " AEL_Observaciones as Observaciones" & vbCrLf
        sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada_LineasCla ON ALC_idlineaentrada = AEL_IdLinea" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON AEL_IdGenero = GEN_IdGenero" & vbCrLf
        sql = sql & sqlWhere
        sql = sql & " ) as A" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasEntrada ON CAE_Id = A.IdCategoria " & vbCrLf
        sql = sql & " WHERE CAE_IdTipoCategoria = 1" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT IdLinea, Partida, Fecha, IdGenero, Genero, 0 as KilosA, KilosB, 0 as KilosC, 0 as KilosD, 0 as Destrio, Observaciones" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT AEL_IdLinea as IdLinea, AEL_Muestreo as Partida, AEN_Fecha as Fecha, AEL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN AEL_IdCategoria ELSE ALC_IdCategoria END as IdCategoria," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN COALESCE(AEL_KilosNetos,0) ELSE COALESCE(ALC_KilosNetos,0) END as KilosB," & vbCrLf
        sql = sql & " AEL_Observaciones as Observaciones" & vbCrLf
        sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada_LineasCla ON ALC_idlineaentrada = AEL_IdLinea" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON AEL_IdGenero = GEN_IdGenero" & vbCrLf
        sql = sql & sqlWhere
        sql = sql & " ) as B" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasEntrada ON CAE_Id = B.IdCategoria " & vbCrLf
        sql = sql & " WHERE CAE_IdTipoCategoria = 2" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT IdLinea, Partida, Fecha, IdGenero, Genero, 0 as KilosA, 0 as KilosB, KilosC, 0 as KilosD, 0 as Destrio, Observaciones" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT AEL_IdLinea as IdLinea, AEL_Muestreo as Partida, AEN_Fecha as Fecha, AEL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN AEL_IdCategoria ELSE ALC_IdCategoria END as IdCategoria," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN COALESCE(AEL_KilosNetos,0) ELSE COALESCE(ALC_KilosNetos,0) END as KilosC," & vbCrLf
        sql = sql & " AEL_Observaciones as Observaciones" & vbCrLf
        sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada_LineasCla ON ALC_idlineaentrada = AEL_IdLinea" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON AEL_IdGenero = GEN_IdGenero" & vbCrLf
        sql = sql & sqlWhere
        sql = sql & " ) as C" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasEntrada ON CAE_Id = C.IdCategoria " & vbCrLf
        sql = sql & " WHERE CAE_IdTipoCategoria = 3" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT IdLinea, Partida, Fecha, IdGenero, Genero, 0 as KilosA, 0 as KilosB, 0 as KilosC, KilosD, 0 as Destrio, Observaciones" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT AEL_IdLinea as IdLinea, AEL_Muestreo as Partida, AEN_Fecha as Fecha, AEL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN AEL_IdCategoria ELSE ALC_IdCategoria END as IdCategoria," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN COALESCE(AEL_KilosNetos,0) ELSE COALESCE(ALC_KilosNetos,0) END as KilosD," & vbCrLf
        sql = sql & " AEL_Observaciones as Observaciones" & vbCrLf
        sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada_LineasCla ON ALC_idlineaentrada = AEL_IdLinea" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON AEL_IdGenero = GEN_IdGenero" & vbCrLf
        sql = sql & sqlWhere
        sql = sql & " ) as DX" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasEntrada ON CAE_Id = DX.IdCategoria " & vbCrLf
        sql = sql & " WHERE CAE_IdTipoCategoria = 4" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT IdLinea, Partida, Fecha, IdGenero, Genero, 0 as KilosA, 0 as KilosB, 0 as KilosC, 0 as KilosD, Destrio, Observaciones" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT AEL_IdLinea as IdLinea, AEL_Muestreo as Partida, AEN_Fecha as Fecha, AEL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN AEL_IdCategoria ELSE ALC_IdCategoria END as IdCategoria," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN COALESCE(AEL_KilosNetos,0) ELSE COALESCE(ALC_KilosNetos,0) END as Destrio," & vbCrLf
        sql = sql & " AEL_Observaciones as Observaciones" & vbCrLf
        sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada_LineasCla ON ALC_idlineaentrada = AEL_IdLinea" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON AEL_IdGenero = GEN_IdGenero" & vbCrLf
        sql = sql & sqlWhere
        sql = sql & " ) as DX" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasEntrada ON CAE_Id = DX.IdCategoria " & vbCrLf
        sql = sql & " WHERE CAE_IdTipoCategoria = 9" & vbCrLf
        sql = sql & " ) as X" & vbCrLf
        sql = sql & " GROUP BY IdLinea, Fecha, Partida, IdGenero, Genero, Observaciones" & vbCrLf
        sql = sql & " ORDER BY Fecha DESC, Partida DESC" & vbCrLf


        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
        Dim dtFinal As DataTable = dt.Clone
        dtFinal.Columns.Add("PorcenKilosA", GetType(Decimal)).SetOrdinal(6)
        dtFinal.Columns.Add("PorcenKilosB", GetType(Decimal)).SetOrdinal(8)
        dtFinal.Columns.Add("PorcenKilosC", GetType(Decimal)).SetOrdinal(10)
        dtFinal.Columns.Add("PorcenKilosD", GetType(Decimal)).SetOrdinal(12)
        dtFinal.Columns.Add("PorcenDestrio", GetType(Decimal)).SetOrdinal(14)

        Dim max_registros As Integer = 10

        Dim cont As Integer = 1

        For Each row As DataRow In dt.Rows

            If cont > 10 Then Exit For

            Dim Total As Decimal = VaDec(row("Total"))
            Dim KilosA As Decimal = VaDec(row("KilosA"))
            Dim KilosB As Decimal = VaDec(row("KilosB"))
            Dim KilosC As Decimal = VaDec(row("KilosC"))
            Dim KilosD As Decimal = VaDec(row("KilosD"))
            Dim Destrio As Decimal = VaDec(row("Destrio"))

            Dim PorcenA As Decimal = 0
            Dim PorcenB As Decimal = 0
            Dim PorcenC As Decimal = 0
            Dim PorcenD As Decimal = 0
            Dim PorcenDestrio As Decimal = 0

            If Total <> 0 Then
                PorcenA = KilosA / Total * 100
                PorcenB = KilosB / Total * 100
                PorcenC = KilosC / Total * 100
                PorcenD = KilosD / Total * 100
                PorcenDestrio = Destrio / Total * 100
            End If



            Dim fila As DataRow = dtFinal.NewRow
            fila("IdLinea") = row("IdLinea")
            fila("Partida") = row("Partida")
            fila("Fecha") = row("Fecha")

            fila("IdGenero") = row("IdGenero")
            fila("Genero") = row("Genero")

            fila("KilosA") = KilosA
            fila("KilosB") = KilosB
            fila("KilosC") = KilosC
            fila("KilosD") = KilosD
            fila("Destrio") = Destrio
            fila("Total") = row("Total")

            fila("PorcenKilosA") = PorcenA
            fila("PorcenKilosB") = PorcenB
            fila("PorcenKilosC") = PorcenC
            fila("PorcenKilosD") = PorcenD
            fila("PorcenDestrio") = PorcenDestrio

            fila("Observaciones") = row("Observaciones")
            dtFinal.Rows.Add(fila)


            cont = cont + 1

        Next


        Return dtFinal

    End Function


    Public Function Agro_HistorialCultivo(IdCultivo As String, IdGenero As String) As DataTable

        Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)


        'Dim sqlWhere As String = "WHERE AEL_CampaCultivo = " & CampaCultivo & vbCrLf
        'sqlWhere = sqlWhere & " AND AEL_IdCultivo = " & IdCultivo & vbCrLf
        'If VaInt(IdGenero) > 0 Then sqlWhere = sqlWhere & " AND AEL_IdGenero = " & IdGenero & vbCrLf

        Dim sqlWhere As String = "WHERE AEL_IdCultivo = " & IdCultivo & vbCrLf
        If VaInt(IdGenero) > 0 Then sqlWhere = sqlWhere & " AND AEL_IdGenero = " & IdGenero & vbCrLf



        Dim sql As String = "SELECT Fecha, IdLinea, Partida, IdGenero, Genero, IdAgricultor, Agricultor," & vbCrLf
        sql = sql & " SUM(KilosA) as KilosA, SUM(KilosB) as KilosB, SUM(KilosC) as KilosC, SUM(KilosD) as KilosD, SUM(Destrio) as Destrio," & vbCrLf
        sql = sql & " SUM(KilosA + KilosB + KilosC + KilosD + Destrio) as Total, Observaciones" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT IdLinea, Partida, Fecha, IdGenero, Genero, IdAgricultor, Agricultor," & vbCrLf
        sql = sql & " KilosA, 0 as KilosB, 0 as KilosC, 0 as KilosD, 0 as Destrio, Observaciones" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT AEL_IdLinea as IdLinea, AEL_Muestreo as Partida, AEN_Fecha as Fecha, AEL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
        sql = sql & " AEN_IdAgricultor as IdAgricultor, AGR_Nombre as Agricultor," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN AEL_IdCategoria ELSE ALC_IdCategoria END as IdCategoria," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN COALESCE(AEL_KilosNetos,0) ELSE COALESCE(ALC_KilosNetos,0) END as KilosA," & vbCrLf
        sql = sql & " AEL_Observaciones as Observaciones" & vbCrLf
        sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada_LineasCla ON ALC_idlineaentrada = AEL_IdLinea" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Agricultores ON AGR_IdAgricultor = AEN_IdAgricultor" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON AEL_IdGenero = GEN_IdGenero" & vbCrLf
        sql = sql & sqlWhere
        sql = sql & " ) as A" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasEntrada ON CAE_Id = A.IdCategoria " & vbCrLf
        sql = sql & " WHERE CAE_IdTipoCategoria = 1" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT IdLinea, Partida, Fecha, IdGenero, Genero, IdAgricultor, Agricultor," & vbCrLf
        sql = sql & " 0 as KilosA, KilosB, 0 as KilosC, 0 as KilosD, 0 as Destrio, Observaciones" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT AEL_IdLinea as IdLinea, AEL_Muestreo as Partida, AEN_Fecha as Fecha, AEL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
        sql = sql & " AEN_IdAgricultor as IdAgricultor, AGR_Nombre as Agricultor," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN AEL_IdCategoria ELSE ALC_IdCategoria END as IdCategoria," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN COALESCE(AEL_KilosNetos,0) ELSE COALESCE(ALC_KilosNetos,0) END as KilosB," & vbCrLf
        sql = sql & " AEL_Observaciones as Observaciones" & vbCrLf
        sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada_LineasCla ON ALC_idlineaentrada = AEL_IdLinea" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Agricultores ON AGR_IdAgricultor = AEN_IdAgricultor" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON AEL_IdGenero = GEN_IdGenero" & vbCrLf
        sql = sql & sqlWhere
        sql = sql & " ) as B" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasEntrada ON CAE_Id = B.IdCategoria " & vbCrLf
        sql = sql & " WHERE CAE_IdTipoCategoria = 2" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT IdLinea, Partida, Fecha, IdGenero, Genero, IdAgricultor, Agricultor," & vbCrLf
        sql = sql & " 0 as KilosA, 0 as KilosB, KilosC, 0 as KilosD, 0 as Destrio, Observaciones" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT AEL_IdLinea as IdLinea, AEL_Muestreo as Partida, AEN_Fecha as Fecha, AEL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
        sql = sql & " AEN_IdAgricultor as IdAgricultor, AGR_Nombre as Agricultor," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN AEL_IdCategoria ELSE ALC_IdCategoria END as IdCategoria," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN COALESCE(AEL_KilosNetos,0) ELSE COALESCE(ALC_KilosNetos,0) END as KilosC," & vbCrLf
        sql = sql & " AEL_Observaciones as Observaciones" & vbCrLf
        sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada_LineasCla ON ALC_idlineaentrada = AEL_IdLinea" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Agricultores ON AEN_IdAgricultor = AGR_IdAgricultor" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON AEL_IdGenero = GEN_IdGenero" & vbCrLf
        sql = sql & sqlWhere
        sql = sql & " ) as C" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasEntrada ON CAE_Id = C.IdCategoria " & vbCrLf
        sql = sql & " WHERE CAE_IdTipoCategoria = 3" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT IdLinea, Partida, Fecha, IdGenero, Genero, IdAgricultor, Agricultor," & vbCrLf
        sql = sql & " 0 as KilosA, 0 as KilosB, 0 as KilosC, KilosD, 0 as Destrio, Observaciones" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT AEL_IdLinea as IdLinea, AEL_Muestreo as Partida, AEN_Fecha as Fecha, AEL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
        sql = sql & " AEN_IdAgricultor as IdAgricultor, AGR_Nombre as Agricultor," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN AEL_IdCategoria ELSE ALC_IdCategoria END as IdCategoria," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN COALESCE(AEL_KilosNetos,0) ELSE COALESCE(ALC_KilosNetos,0) END as KilosD," & vbCrLf
        sql = sql & " AEL_Observaciones as Observaciones" & vbCrLf
        sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada_LineasCla ON ALC_idlineaentrada = AEL_IdLinea" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Agricultores ON AGR_IdAgricultor = AEN_IdAgricultor" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON AEL_IdGenero = GEN_IdGenero" & vbCrLf
        sql = sql & sqlWhere
        sql = sql & " ) as DX" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasEntrada ON CAE_Id = DX.IdCategoria " & vbCrLf
        sql = sql & " WHERE CAE_IdTipoCategoria = 4" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT IdLinea, Partida, Fecha, IdGenero, Genero, IdAgricultor, Agricultor," & vbCrLf
        sql = sql & " 0 as KilosA, 0 as KilosB, 0 as KilosC, 0 as KilosD, Destrio, Observaciones" & vbCrLf
        sql = sql & " FROM (" & vbCrLf
        sql = sql & " SELECT AEL_IdLinea as IdLinea, AEL_Muestreo as Partida, AEN_Fecha as Fecha, AEL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
        sql = sql & " AEN_IdAgricultor as IdAgricultor, AGR_Nombre as Agricultor," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN AEL_IdCategoria ELSE ALC_IdCategoria END as IdCategoria," & vbCrLf
        sql = sql & " CASE COALESCE(AEL_FechaMuestreo, '01/01/1900') WHEN '01/01/1900' THEN COALESCE(AEL_KilosNetos,0) ELSE COALESCE(ALC_KilosNetos,0) END as Destrio," & vbCrLf
        sql = sql & " AEL_Observaciones as Observaciones" & vbCrLf
        sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada_LineasCla ON ALC_idlineaentrada = AEL_IdLinea" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Agricultores ON AGR_IdAgricultor = AEN_IdAgricultor" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON AEL_IdGenero = GEN_IdGenero" & vbCrLf
        sql = sql & sqlWhere
        sql = sql & " ) as DX" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasEntrada ON CAE_Id = DX.IdCategoria " & vbCrLf
        sql = sql & " WHERE CAE_IdTipoCategoria = 9" & vbCrLf
        sql = sql & " ) as X" & vbCrLf
        sql = sql & " GROUP BY IdLinea, Fecha, Partida, IdGenero, Genero, IdAgricultor, Agricultor, Observaciones" & vbCrLf
        sql = sql & " ORDER BY Fecha DESC, Partida DESC" & vbCrLf


        Dim dt As DataTable = AlbEntrada.MiConexion.ConsultaSQL(sql)
        Dim dtFinal As DataTable = dt.Clone
        dtFinal.Columns.Add("PorcenKilosA", GetType(Decimal)).SetOrdinal(8)
        dtFinal.Columns.Add("PorcenKilosB", GetType(Decimal)).SetOrdinal(10)
        dtFinal.Columns.Add("PorcenKilosC", GetType(Decimal)).SetOrdinal(12)
        dtFinal.Columns.Add("PorcenKilosD", GetType(Decimal)).SetOrdinal(14)
        dtFinal.Columns.Add("PorcenDestrio", GetType(Decimal)).SetOrdinal(16)

        Dim max_registros As Integer = 10

        Dim cont As Integer = 1

        For Each row As DataRow In dt.Rows

            If cont > 10 Then Exit For

            Dim Total As Decimal = VaDec(row("Total"))
            Dim KilosA As Decimal = VaDec(row("KilosA"))
            Dim KilosB As Decimal = VaDec(row("KilosB"))
            Dim KilosC As Decimal = VaDec(row("KilosC"))
            Dim KilosD As Decimal = VaDec(row("KilosD"))
            Dim Destrio As Decimal = VaDec(row("Destrio"))

            Dim PorcenA As Decimal = 0
            Dim PorcenB As Decimal = 0
            Dim PorcenC As Decimal = 0
            Dim PorcenD As Decimal = 0
            Dim PorcenDestrio As Decimal = 0

            If Total <> 0 Then
                PorcenA = KilosA / Total * 100
                PorcenB = KilosB / Total * 100
                PorcenC = KilosC / Total * 100
                PorcenD = KilosD / Total * 100
                PorcenDestrio = Destrio / Total * 100
            End If



            Dim fila As DataRow = dtFinal.NewRow
            fila("IdLinea") = row("IdLinea")
            fila("Partida") = row("Partida")
            fila("Fecha") = row("Fecha")

            fila("IdGenero") = row("IdGenero")
            fila("Genero") = row("Genero")

            fila("IdAgricultor") = row("IdAgricultor")
            fila("Agricultor") = row("Agricultor")

            fila("KilosA") = KilosA
            fila("KilosB") = KilosB
            fila("KilosC") = KilosC
            fila("KilosD") = KilosD
            fila("Destrio") = Destrio
            fila("Total") = row("Total")

            fila("PorcenKilosA") = PorcenA
            fila("PorcenKilosB") = PorcenB
            fila("PorcenKilosC") = PorcenC
            fila("PorcenKilosD") = PorcenD
            fila("PorcenDestrio") = PorcenDestrio

            fila("Observaciones") = row("Observaciones")
            dtFinal.Rows.Add(fila)


            cont = cont + 1

        Next


        Return dtFinal

    End Function



    Public Function Agro_ConsultaClasificacionesProveedor(bDetallarPrecios As Boolean, sqlWhere As String) As String

        Dim sql As String = "SELECT AEN_IdAgricultor as IdAgricultor,AEN_TipoFCS as FCS, AGR_Nombre as Agricultor, AEN_IdAlbaran as IdAlbaran, AEN_Albaran as Albaran, AEN_Campa as Campa," & vbCrLf
        sql = sql & " RIGHT('00' + CAST (AEN_Campa as varchar), 2) + RIGHT('00000' + CAST (AEL_IdCultivo as varchar), 5) as Cultivo," & vbCrLf
        sql = sql & " AEL_Observaciones as Observaciones, AEL_ObservacionesProveedor as ObservacionesProveedor, AEL_Muestreo as Partida, AEN_Fecha as Fecha, " & vbCrLf
        sql = sql & " AEL_IdGenero as IdGenero, GEN_NombreGenero as Genero, AEL_KilosNetos as KilosEnt," & vbCrLf
        sql = sql & " ALC_IdCategoria as IdCategoria, CAE_CategoriaCalibre as Categoria, CAE_IdTipoCategoria as IdTipoCategoria, TCA_Nombre as TipoCategoria," & vbCrLf
        If Not bDetallarPrecios Then
            sql = sql & " SUM(ALC_KilosNetos) as Kilos" & vbCrLf
        Else
            sql = sql & " SUM(ALC_KilosNetos) as Kilos, ALC_Precio as Precio, SUM(COALESCE(CASE AEL_TipoPrecio WHEN 'B' THEN ALC_Bultos * ALC_Precio WHEN 'P' THEN ALC_piezas * ALC_Precio ELSE ALC_Precio * ALC_KilosNetos END,0)) as Importe" & vbCrLf
        End If
        sql = sql & " ,'S' as Clasif" & vbCrLf
        sql = sql & " FROM AlbEntrada_LineasCla" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada_Lineas ON AEL_IdLinea = ALC_IdLineaEntrada" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEL_IdAlbaran = AEN_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Agricultores ON AGR_IdAgricultor = AEN_IdAgricultor" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = AEL_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasEntrada ON CAE_Id = ALC_IdCategoria" & vbCrLf
        sql = sql & " LEFT JOIN TiposDeCategorias ON TCA_Id = CAE_IdTipoCategoria" & vbCrLf
        sql = sql & sqlWhere
        If bDetallarPrecios Then
            sql = sql & " GROUP BY AEN_IdAgricultor, AEN_TipoFCS, AGR_Nombre, AEN_IdAlbaran, AEN_Campa, AEN_Albaran, AEN_Fecha, AEL_Muestreo, AEL_IdCultivo, ALC_Precio," & vbCrLf
            sql = sql & " AEL_Observaciones, AEL_ObservacionesProveedor, AEL_IdGenero, AEL_KilosNetos," & vbCrLf
            sql = sql & " GEN_NombreGenero, ALC_IdCategoria, CAE_CategoriaCalibre, CAE_IdTipoCategoria, TCA_Nombre" & vbCrLf
        Else
            sql = sql & " GROUP BY AEN_IdAgricultor, AEN_TipoFCS, AGR_Nombre, AEN_IdAlbaran, AEN_Campa, AEN_Albaran, AEN_Fecha, AEL_Muestreo, AEL_IdCultivo," & vbCrLf
            sql = sql & " AEL_Observaciones, AEL_ObservacionesProveedor, AEL_IdGenero, AEL_KilosNetos," & vbCrLf
            sql = sql & " GEN_NombreGenero, ALC_IdCategoria, CAE_CategoriaCalibre, CAE_IdTipoCategoria, TCA_Nombre" & vbCrLf
        End If


        sql = sql & " UNION ALL " & vbCrLf
        sql = sql & " SELECT AEN_IdAgricultor as IdAgricultor,AEN_TipoFCS as FCS, AGR_Nombre as Agricultor, AEN_IdAlbaran as IdAlbaran, AEN_Albaran as Albaran, AEN_Campa as Campa," & vbCrLf
        sql = sql & " RIGHT('00' + CAST (AEN_Campa as varchar), 2) + RIGHT('00000' + CAST (AEL_IdCultivo as varchar), 5) as Cultivo," & vbCrLf
        sql = sql & " AEL_Observaciones as Observaciones, AEL_ObservacionesProveedor as ObservacionesProveedor, AEL_Muestreo as Partida, AEN_Fecha as Fecha, " & vbCrLf
        sql = sql & " AEL_IdGenero as IdGenero, GEN_NombreGenero as Genero, AEL_KilosNetos as KilosEnt," & vbCrLf
        sql = sql & " 0 as IdCategoria, '' as Categoria, 0 as IdTipoCategoria, '' as TipoCategoria," & vbCrLf
        If Not bDetallarPrecios Then
            sql = sql & " AEL_KilosNetos as Kilos" & vbCrLf
        Else
            sql = sql & " AEL_KilosNetos as Kilos, AEL_Precio as Precio, COALESCE(CASE AEL_TipoPrecio WHEN 'B' THEN AEL_Bultos * AEL_Precio WHEN 'P' THEN AEL_piezas * AEL_Precio ELSE AEL_Precio * AEL_KilosNetos END,0) as Importe" & vbCrLf
        End If
        sql = sql & " ,'N' as Clasif" & vbCrLf
        sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada ON AEN_IdAlbaran = AEL_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Agricultores ON AGR_IdAgricultor = AEN_IdAgricultor" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON AEL_IdGenero = GEN_IdGenero" & vbCrLf
        sql = sql & sqlWhere
        sql = sql & " AND AEL_IdLinea NOT IN (SELECT DISTINCT ALC_IdLineaEntrada FROM AlbEntrada_LineasCla)" & vbCrLf




        'If bDetallarPrecios Then
        '    sql = sql & " ORDER BY AEN_IdAgricultor, AEN_Albaran, AEL_IdGenero, AEL_Muestreo, ALC_IdCategoria, CAE_CategoriaCalibre" & vbCrLf
        'Else
        '    sql = sql & " ORDER BY AEN_IdAgricultor, AEL_IdGenero, AEN_Albaran, AEL_Muestreo, ALC_IdCategoria, CAE_CategoriaCalibre" & vbCrLf
        'End If


        If Not bDetallarPrecios Then
            sql = "SELECT IdAgricultor, FCS, Agricultor, IdAlbaran, Albaran, Campa, Cultivo, Observaciones, ObservacionesProveedor, Partida," & vbCrLf & _
                " Fecha, IdGenero, Genero, KilosEnt, IdCategoria, Categoria, IdTipoCategoria, TipoCategoria, Kilos, Clasif" & vbCrLf & _
                " FROM (" & vbCrLf & sql & vbCrLf & ") AS X " & vbCrLf & _
                " ORDER BY IdAgricultor, IdGenero, Albaran, Partida, IdCategoria, Categoria" & vbCrLf
        Else
            sql = "SELECT IdAgricultor, FCS, Agricultor, IdAlbaran, Albaran, Campa, Cultivo, Observaciones, ObservacionesProveedor, Partida," & vbCrLf & _
                " Fecha, IdGenero, Genero, KilosEnt, IdCategoria, Categoria, IdTipoCategoria, TipoCategoria, Kilos, Precio, Importe, Clasif" & vbCrLf & _
                " FROM (" & vbCrLf & sql & vbCrLf & ") AS X " & vbCrLf & _
                " ORDER BY IdAgricultor, IdGenero, Albaran, Partida, IdCategoria, Categoria" & vbCrLf

        End If




        Return sql

    End Function



    Public Sub Agro_GeneraAlbaranEntrada(ByVal Alb As Integer)

        Dim AlbEntrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)

        Dim AlbEntrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)
        Dim albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
        Dim Consulta As New Cdatos.E_select

        Dim Medianeria_lineas As New E_Medianeria_lineas(Idusuario, cn)


        Dim Sql As String
        Dim dt As New DataTable
        Dim porc As Double
        Dim npor As Double = 0
        Dim IdLineascla As Integer = 0
        Dim Idpartida As Integer = 0
        Dim Idlinea As Integer = 0
        Dim nmed As Integer = 0
        'cabeceras medianeros

        Dim f As String

        ' por si acaso

        f = albentrada_his.AlbaranFacturado(Alb)
        If f <> "" Then
            MsgBox("Albaran " + f + " facturado")
            Exit Sub
        End If



        If AlbEntrada.LeerId(Alb) = True Then
            Sql = "delete from albentrada_his where AEH_idalbaran=" + Alb.ToString
            AlbEntrada.MiConexion.OrdenSql(Sql)


            Consulta.SelCampo(Medianeria_lineas.MEL_Idagricultor, "idmedianero")
            Consulta.SelCampo(Medianeria_lineas.MEL_porcentaje, "porcentaje")
            Consulta.WheCampo(Medianeria_lineas.MEL_Idmedianeria, "=", AlbEntrada.AEN_IdMedianeria.Valor)
            Sql = Consulta.SQL
            dt = Medianeria_lineas.MiConexion.ConsultaSQL(Sql)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    For Each rw In dt.Rows
                        nmed = nmed + 1
                        GeneraAlbaranMedianero(Alb, VaInt(rw("idmedianero")), VaDec(rw("porcentaje")), VaInt(AlbEntrada.AEN_IdPuntoVenta.Valor), VaInt(AlbEntrada.AEN_IdRecogida.Valor), nmed, AlbEntrada.AEN_IdCentro.Valor)
                        npor = npor + VaDec(rw("porcentaje"))
                    Next
                End If
            End If
            porc = 100 - npor

            GeneraAlbaranMedianero(Alb, AlbEntrada.AEN_IdAgricultor.Valor, porc, VaInt(AlbEntrada.AEN_IdPuntoVenta.Valor), VaInt(AlbEntrada.AEN_IdRecogida.Valor), 0, AlbEntrada.AEN_IdCentro.Valor)
            Generalineasmedianero(AlbEntrada.AEN_Campa.Valor, Alb, AlbEntrada.AEN_TipoFCS.Valor, AlbEntrada.AEN_Fecha.Valor)
            Agro_ValoraAlbaranHis(Alb)

        End If

    End Sub



    Public Sub Agro_ValoraAlbaranHis(ByVal Alb As Integer)
        ' valorar las cabeceras de historicos a partir de las lineas y los gastos.
        Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
        Dim Albentrada_hisgastos As New E_albentrada_hisgastos(Idusuario, cn)
        Dim igenero As Decimal
        Dim ienvase As Decimal
        Dim tkilos As Decimal
        Dim tbultos As Decimal
        Dim tpiezas As Decimal
        Dim gfac As Decimal
        Dim gcom As Decimal
        Dim sql As String = "Select AEH_id  from albentrada_his where AEH_idalbaran=" + Alb.ToString
        Dim dt As DataTable = cn.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                igenero = 0
                ienvase = 0
                tkilos = 0
                tbultos = 0
                tpiezas = 0
                sql = "Select sum(AHL_importegenero) as igenero,sum(AHL_bultos*AHL_precioenvase) as ienvase,sum(AHL_kilos) as tkilos,sum(AHL_BULTOS) AS tbultos, sum(AHL_PIEZAS) AS Tpiezas from albentrada_hislineas where AHL_idalbhis=" + rw("AEH_id").ToString
                Dim dtl As DataTable = cn.ConsultaSQL(sql)
                If Not dtl Is Nothing Then
                    If dtl.Rows.Count > 0 Then
                        igenero = VaDec(dtl.Rows(0)(0))
                        ienvase = VaDec(dtl.Rows(0)(1))
                        tkilos = VaDec(dtl.Rows(0)(2))
                        tbultos = VaDec(dtl.Rows(0)(3))
                        tpiezas = VaDec(dtl.Rows(0)(4))
                    End If
                End If



                sql = "Select * from albentrada_hisgastos where AHG_idalbhis=" + rw("AEH_id").ToString
                Dim dtg As DataTable = cn.ConsultaSQL(sql)
                gfac = 0
                gcom = 0
                If Not dtg Is Nothing Then

                    For Each dr As DataRow In dtg.Rows
                        Dim i As Decimal = 0
                        Select Case dr("AHG_tipo")

                            Case "K"
                                i = tkilos * VaDec(dr("AHG_valor"))
                            Case "B"
                                i = tbultos * VaDec(dr("AHG_valor"))
                            Case "%"
                                i = igenero * VaDec(dr("AHG_valor")) / 100
                            Case "I"
                                i = VaDec(dr("AHG_valor"))

                        End Select

                        If dr("AHG_factura_comercial") = "F" Then
                            gfac = gfac + i
                        Else
                            gcom = gcom + i
                        End If

                        If i <> VaDec(dr("AHG_importe")) Then
                            If Albentrada_hisgastos.LeerId(dr("AHG_ID").ToString) = True Then
                                Albentrada_hisgastos.AHG_importe.Valor = i.ToString
                                Albentrada_hisgastos.Actualizar()
                            End If
                        End If
                    Next
                End If





                'sql = "Select AHG_factura_comercial as fc, sum(AHG_importe) AS IMPORTE from albentrada_hisgastos where AHG_idalbhis=" + rw("AEH_id").ToString + " group by AHG_factura_comercial"
                'Dim dtg As DataTable = cn.ConsultaSQL(sql)
                'If Not dtg Is Nothing Then
                '    For Each rwg In dtg.Rows
                '        Select Case rwg("fc")
                '            Case "F"
                '                gfac = VaDec(rwg("importe"))
                '            Case "C"
                '                gcom = VaDec(rwg("importe"))
                '        End Select

                '    Next
                'End If

                If Albentrada_his.LeerId(rw("AEH_id")) = True Then
                    Albentrada_his.AEH_importegenero.Valor = Format(igenero, "#,###0.00")
                    Albentrada_his.AEH_tgastosfac.Valor = Format(gfac, "#,###0.00")
                    Albentrada_his.AEH_tgastoscom.Valor = Format(gcom, "#,###0.00")

                    Albentrada_his.AEH_baseimponible.Valor = Format((igenero + ienvase - gfac), "#,###0.00")
                    Albentrada_his.AEH_kilos.Valor = tkilos.ToString
                    Dim Cuiva As Decimal = VaDec(Albentrada_his.AEH_baseimponible.Valor) * VaDec(Albentrada_his.AEH_tipoiva.Valor) / 100
                    Albentrada_his.AEH_cuotaiva.Valor = Format(Cuiva, "#,###0.00")
                    Dim baseret As Decimal
                    If Albentrada_his.AEH_tiporet.Valor = "B" Then
                        baseret = VaDec(Albentrada_his.AEH_baseimponible.Valor)
                    Else
                        baseret = VaDec(Albentrada_his.AEH_baseimponible.Valor) + VaDec(Albentrada_his.AEH_cuotaiva.Valor)
                    End If
                    Dim cuotaret As Decimal = baseret * VaDec(Albentrada_his.AEH_poret.Valor) / 100
                    Albentrada_his.AEH_cuotaret.Valor = Format(cuotaret, "#,###0.00")
                    Albentrada_his.AEH_totalalbaran.Valor = Format(VaDec(Albentrada_his.AEH_baseimponible.Valor) + VaDec(Albentrada_his.AEH_cuotaiva.Valor) + VaDec(Albentrada_his.AEH_cuotaret.Valor), "#,###0.00")
                    Albentrada_his.Actualizar()
                End If


            Next
        End If
    End Sub


    Public Function Agro_AlbEntradaGastos(idalbhis As Integer) As DataTable

        ' devuelve un datatable con el importe del albaran y los gastos aplicados por linea
        Dim dt As New DataTable
        Dim consulta As New Cdatos.E_select
        Dim Albentrada_hislineas As New E_AlbEntrada_hislineas(Idusuario, cn)
        Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim SubFamilias As New E_Subfamilias(Idusuario, cn)
        Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim Albentrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)


        consulta.SelCampo(Albentrada_hislineas.AHL_idalbhis, "IdAlbHis")
        consulta.SelCampo(Albentrada_hislineas.AHL_idgenero, "IdGenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albentrada_hislineas.AHL_idgenero, Generos.GEN_IdGenero)
        consulta.SelCampo(SubFamilias.SFA_idfamilia, "IdFamilia", Generos.GEN_IdsubFamilia, SubFamilias.SFA_id)
        consulta.SelCampo(Albentrada_hislineas.AHL_idcategoria, "idcategoria")
        consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", Albentrada_hislineas.AHL_idcategoria, Categorias.CAE_Id)
        consulta.SelCampo(Categorias.CAE_clasificacion, "Cla")
        consulta.SelCampo(Albentrada_hislineas.AHL_kilos, "Kilos")
        consulta.SelCampo(Albentrada_hislineas.AHL_bultos, "Bultos")
        consulta.SelCampo(Albentrada_hislineas.AHL_importegenero, "Importe")
        consulta.SelCampo(Albentrada_lineas.AEL_IdValoracion, "idvaloracion", Albentrada_hislineas.AHL_idlineaentrada)
        consulta.SelCampo(Albentrada_lineas.AEL_FechaValoracion, "fechavaloracion")
        consulta.SelCampo(Albentrada_lineas.AEL_idlinea, "idlineaentrada")
        consulta.SelCampo(Albentrada_lineas.AEL_fechamuestreo, "fechamuestreo")
        consulta.SelCampo(Albentrada_lineas.AEL_Idparte, "idparte")


        consulta.WheCampo(Albentrada_hislineas.AHL_idalbhis, "=", idalbhis.ToString)
        Dim sql As String = consulta.SQL

        dt = Albentrada_hislineas.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            dt.Columns.Add(New DataColumn("GastosF", GetType(Decimal)))
            dt.Columns.Add(New DataColumn("GastosC", GetType(Decimal)))



            For Each row As DataRow In dt.Rows

                Dim Kilos As Decimal = VaDec(row("Kilos"))
                Dim Bultos As Decimal = VaDec(row("Bultos"))

                Dim Importe As Decimal = VaDec(row("Importe"))


                Dim GastosF As Decimal = 0
                Dim GastosC As Decimal = 0
                Agro_ObtenerGastosHistorico(idalbhis, Kilos, Bultos, Importe, GastosF, GastosC)


                row("GastosF") = GastosF
                row("GastosC") = GastosC

            Next
        End If


        Return dt

    End Function

    Public Sub Agro_ObtenerGastosHistorico(IdAlbHis As String, Kilos As Decimal, Bultos As Decimal, Importe As Decimal,
                                       ByRef GastosFacturables As Decimal, ByRef GastosNOFacturables As Decimal)

        'Consulta los gastos aplicables a cada línea
        Dim Albentrada_hisgastos As New E_albentrada_hisgastos(Idusuario, cn)
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Albentrada_hisgastos.AHG_tipo, "Tipo")
        consulta.SelCampo(Albentrada_hisgastos.AHG_valor, "Valor")
        consulta.SelCampo(Albentrada_hisgastos.AHG_factura_comercial, "FC")
        consulta.WheCampo(Albentrada_hisgastos.AHG_idalbhis, "=", IdAlbHis)

        Dim sql As String = consulta.SQL
        Dim dt As DataTable = Albentrada_hisgastos.MiConexion.ConsultaSQL(sql)


        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows

                Dim Tipo As String = (row("Tipo").ToString & "").Trim.ToUpper
                Dim Valor As Decimal = VaDec(row("Valor"))
                Dim FC As String = (row("FC").ToString & "").Trim.ToUpper
                Dim val As Decimal = 0

                Select Case Tipo

                    Case "K"
                        val = (Valor * Kilos)

                    Case "B"
                        val = (Valor * Bultos)

                    Case "%"
                        val = (Valor * Importe / 100)

                    Case "I"

                        Dim TotalKilos As Decimal = 0
                        sql = "SELECT SUM(AHL_Kilos) as KNetos FROM Albentrada_hislineas WHERE AHL_IdAlbHIS = " & IdAlbHis
                        Dim dtk As DataTable = cn.ConsultaSQL(sql)

                        If Not IsNothing(dtk) Then
                            If dtk.Rows.Count > 0 Then
                                TotalKilos = VaDec(dtk.Rows(0)("Knetos"))
                            End If
                        End If

                        If TotalKilos <> 0 Then
                            val = Valor
                            val = val / TotalKilos * Kilos
                        End If

                        '  val = Valor

                End Select


                Select Case FC
                    Case "F"
                        GastosFacturables = GastosFacturables + val

                    Case Else
                        GastosNOFacturables = GastosNOFacturables + val

                End Select

            Next


        End If


    End Sub
    Private Sub Generalineasmedianero(campa As String, ByVal alb As Integer, fc As String, fecha As String)
        Dim dic As New Dictionary(Of Integer, Double)
        Dim sql As String = ""
        Dim dt As New DataTable
        Dim AlbEntrada_his As New E_AlbEntrada_his(Idusuario, cn)
        Dim AlbEntrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)
        Dim AlbEntrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)


        sql = "Select AEH_id as id, AEH_porcentaje as porcentaje from albentrada_his where AEH_idalbaran=" + alb.ToString + "order by AEH_Nmed"
        dt = AlbEntrada_his.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw As DataRow In dt.Rows
                'dic.Add(rw("id"), rw("porcentaje"))
                dic(rw("id")) = rw("porcentaje")
            Next

        End If
        'borrar las lineas his

        sql = "Delete from albentrada_hislineas where AHL_idalbaran=" + alb.ToString
        AlbEntrada_his.MiConexion.OrdenSql(sql)

        ' antes de borrar genera un diccionario con los gastos facturados por acreedor
        'acreedor,idfactura
        Dim DcFacturas As Dictionary(Of Integer, Integer) = GastosFacturados(alb)


        sql = "Delete from albentrada_hisgastos where AHG_idalbaran=" + alb.ToString
        AlbEntrada_his.MiConexion.ConsultaSQL(sql)

      

   
        Dim Dtlineas As New DataTable
        sql = "Select AEL_idlinea,AEL_tipoprecio,AEL_idenvase,AEL_muestreo from albentrada_lineas where AEL_idalbaran=" + alb.ToString
        dtLINEAS = AlbEntrada_lineas.MiConexion.ConsultaSQL(sql)
        If Not Dtlineas Is Nothing Then
            For Each rwl In Dtlineas.Rows
                Dim idlinea As String = rwl("AEL_idlinea").ToString
                Dim tipoprecio As String = rwl("AEL_tipoprecio").ToString
                Dim idenvase As String = rwl("AEL_idenvase").ToString
                Dim partida As String = rwl("AEL_muestreo").ToString

                sql = "Select * from albentrada_lineascla where ALC_idlineaentrada=" + idlinea
                dt = AlbEntrada_lineascla.MiConexion.ConsultaSQL(sql)
                Dim Muestreado As Boolean = False
                If Not dt Is Nothing Then
                    If dt.Rows.Count > 0 Then
                        Muestreado = True
                        For Each rw As DataRow In dt.Rows
                            AlbEntrada_lineascla.CargaCampos(rw)
                            ReparteLineasCla(tipoprecio, dic, AlbEntrada_lineascla.ALC_kilosnetos.Valor, AlbEntrada_lineascla.ALC_bultos.Valor, AlbEntrada_lineascla.ALC_piezas.Valor, AlbEntrada_lineascla.ALC_idalbaran.Valor, AlbEntrada_lineascla.ALC_idgenero.Valor, idenvase, AlbEntrada_lineascla.ALC_idcategoria.Valor, AlbEntrada_lineascla.ALC_precio.Valor, partida, AlbEntrada_lineascla.ALC_idlineaentrada.Valor, AlbEntrada_lineascla.ALC_id.Valor)
                        Next
                    End If
                End If
                If Muestreado = False Then
                    sql = "Select * from albentrada_lineas where AEL_idlinea=" + idlinea
                    dt = AlbEntrada_lineas.MiConexion.ConsultaSQL(sql)
                    If Not dt Is Nothing Then
                        If dt.Rows.Count > 0 Then
                            For Each rw As DataRow In dt.Rows
                                AlbEntrada_lineas.CargaCampos(rw)
                                ReparteLineasCla(tipoprecio, dic, AlbEntrada_lineas.AEL_kilosnetos.Valor, AlbEntrada_lineas.AEL_bultos.Valor, AlbEntrada_lineas.AEL_piezas.Valor, AlbEntrada_lineas.AEL_idalbaran.Valor, AlbEntrada_lineas.AEL_idgenero.Valor, idenvase, AlbEntrada_lineas.AEL_idcategoria.Valor, AlbEntrada_lineas.AEL_precio.Valor, partida, AlbEntrada_lineas.AEL_idlinea.Valor, "0")
                            Next
                        End If
                    End If
                End If

            Next
        End If


        sql = "Select AEH_id as id, AEH_Porcentaje as porcentaje from albentrada_his where AEH_idalbaran=" + alb.ToString
        dt = AlbEntrada_his.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw As DataRow In dt.Rows
                GeneraGastosAlbaranhis(rw("id"), DcFacturas, VaDec(rw("porcentaje")))
            Next
        End If

        ' si el diccionario de facturas tinen registros, actalizar los idfacturas


    End Sub

    Private Function GastosFacturados(idalbaran As Integer) As Dictionary(Of Integer, Integer)
        ' devuelve un diccionario con los id de las facturas por acrreedor
        Dim ret As New Dictionary(Of Integer, Integer)
        Dim sql As String
        ' AlbEntrada_hisgastos.AHG_idfacturaproveedor.Valor = 0
        ' AlbEntrada_hisgastos.AHG_idalbaran.Valor = idalbaran.ToString
        ' AlbEntrada_hisgastos.AHG_idacreedor.Valor = idacreedor.ToString

        sql = "Select ahg_idacreedor as idacreedor,ahg_idfacturaproveedor as idfacturaproveedor from albentrada_hisgastos where ahg_idalbaran=" + idalbaran.ToString
        Dim dt As DataTable = cn.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                Dim idfactura As Integer = VaInt(rw("idfacturaproveedor"))
                Dim idacreedor As Integer = VaInt(rw("idacreedor"))
                If idfactura > 0 Then
                    If ret.ContainsKey(idacreedor) = False Then
                        ret.Add(idacreedor, idfactura)
                    End If
                End If
            Next
        End If
        Return ret
    End Function

    Private Sub ReparteLineasCla(TipoPrecio As String, ByVal dic As Dictionary(Of Integer, Double), kilosLinea As String, bultosLinea As String, piezaslinea As String, idalbaran As String, idgenero As String, idenvase As String, idcategoria As String, precio As String, partida As String, idlineaentrada As String, idlineacla As String)
        Dim dicst As New Dictionary(Of Integer, StLmed)
        Dim Valores As StLmed
        Dim reparto As Double
        Dim Kilos As Double
        Dim Bultos As Integer
        Dim Piezas As Integer
        Dim r As Integer
        Dim x As Integer
        Dim tk As Double
        Dim tb As Integer
        Dim tz As Integer
        Dim mk As Double
        Dim mb As Integer
        Dim mz As Integer


        Dim ik As Integer
        Dim ib As Integer
        Dim iz As Integer

        Dim Albentrada_hislineas As New E_AlbEntrada_hislineas(Idusuario, cn)

        r = 0
        For Each id As Integer In dic.Keys
            reparto = dic(id)

            Bultos = VaDec(bultosLinea) * reparto / 100
            Bultos = Math.Round(Bultos, 0)

            Piezas = VaDec(piezaslinea) * reparto / 100
            Piezas = Math.Round(Piezas, 0)

            Kilos = VaDec(kilosLinea) * reparto / 100
            Kilos = Math.Round(Kilos, 2)


            Valores.Kilos = Kilos
            Valores.Bultos = Bultos
            Valores.Piezas = Piezas
            Valores.id = id
            r = r + 1
            dicst(r) = Valores
        Next

        For x = 1 To r

            tk = tk + dicst(x).Kilos
            tb = tb + dicst(x).Bultos
            tz = tz + dicst(x).Piezas

            If dicst(x).Kilos >= mk Then
                mk = dicst(x).Kilos
                ik = x

            End If

            If dicst(x).Bultos >= mb Then
                mb = dicst(x).Bultos
                ib = x

            End If


            If dicst(x).Piezas >= mz Then
                mz = dicst(x).Piezas
                iz = x

            End If


        Next
        If ik > 0 Then
            Valores = dicst(ik)
            Valores.Kilos = Valores.Kilos + VaDec(kilosLinea) - tk
            dicst(ik) = Valores
        End If

        If ib > 0 Then
            Valores = dicst(ib)
            Valores.Bultos = Valores.Bultos + VaInt(bultosLinea) - tb
            dicst(ib) = Valores
        End If


        If iz > 0 Then
            Valores = dicst(iz)
            Valores.Piezas = Valores.Piezas + VaInt(piezaslinea) - tz
            dicst(iz) = Valores
        End If




        For x = 1 To r
            Dim importegenero As Double = 0
            Select Case TipoPrecio
                Case "B"
                    importegenero = dicst(x).Bultos * precio
                Case "P"
                    importegenero = dicst(x).Piezas * precio
                Case Else
                    importegenero = dicst(x).Kilos * precio
            End Select
            Albentrada_hislineas.VaciaEntidad()
            Albentrada_hislineas.AHL_id.Valor = Albentrada_hislineas.MaxId
            Albentrada_hislineas.AHL_idalbhis.Valor = dicst(x).id
            Albentrada_hislineas.AHL_idalbaran.Valor = idalbaran
            Albentrada_hislineas.AHL_idgenero.Valor = idgenero
            Albentrada_hislineas.AHL_idenvase.Valor = idenvase
            Albentrada_hislineas.AHL_idpalet.Valor = 0
            Albentrada_hislineas.AHL_idcategoria.Valor = idcategoria
            Albentrada_hislineas.AHL_kilos.Valor = dicst(x).Kilos
            Albentrada_hislineas.AHL_bultos.Valor = dicst(x).Bultos
            Albentrada_hislineas.AHL_palets.Valor = ""
            Albentrada_hislineas.AHL_precio.Valor = precio
            Albentrada_hislineas.AHL_muestreo.Valor = partida
            Albentrada_hislineas.AHL_idlineaentrada.Valor = idlineaentrada
            Albentrada_hislineas.AHL_piezas.Valor = dicst(x).Piezas
            Albentrada_hislineas.AHL_tipoprecio.Valor = TipoPrecio
            Albentrada_hislineas.AHL_importegenero.Valor = importegenero
            Albentrada_hislineas.AHL_idlineacla.Valor = idlineacla
            Albentrada_hislineas.Insertar()

        Next
    End Sub

    'Private Sub ReparteLineas(ByVal dic As Dictionary(Of Integer, Double), ByVal Albentrada_lineas As E_AlbEntrada_lineas)
    '    Dim dicst As New Dictionary(Of Integer, StLmed)
    '    Dim Valores As StLmed
    '    Dim reparto As Double
    '    Dim Kilos As Double
    '    Dim Bultos As Integer
    '    Dim Palets As Integer
    '    Dim r As Integer
    '    Dim x As Integer
    '    Dim tk As Double
    '    Dim tb As Integer
    '    Dim tp As Integer
    '    Dim mk As Double
    '    Dim mb As Integer
    '    Dim mp As Integer

    '    Dim ik As Integer
    '    Dim ib As Integer
    '    Dim ip As Integer


    '    r = 0
    '    For Each id As Integer In dic.Keys
    '        reparto = dic(id)
    '        Kilos = VaDec(Albentrada_lineas.AEL_kilosnetos.Valor) * reparto / 100
    '        Kilos = Math.Round(Kilos, 2)
    '        If r = 0 Then
    '            Bultos = VaInt(Albentrada_lineas.AEL_bultos.Valor)
    '            Palets = VaInt(Albentrada_lineas.AEL_palets.Valor)
    '        Else
    '            Bultos = 0
    '            Palets = 0
    '        End If
    '        'Bultos = VaInt(Albentrada_lineas.AEL_bultos.Valor) * reparto / 100
    '        'Bultos = Math.Round(Bultos, 0)
    '        'Palets = VaInt(Albentrada_lineas.AEL_palets.Valor) * reparto / 100
    '        'Palets = Math.Round(Palets, 0)
    '        Valores.Kilos = Kilos
    '        Valores.Bultos = Bultos
    '        Valores.Palets = Palets
    '        Valores.id = id
    '        r = r + 1
    '        dicst(r) = Valores
    '    Next

    '    For x = 1 To r

    '        tk = tk + dicst(x).Kilos
    '        tb = tb + dicst(x).Bultos
    '        tp = tp + dicst(x).Palets

    '        If dicst(x).Kilos >= mk Then
    '            mk = dicst(x).Kilos
    '            ik = x

    '        End If

    '        If dicst(x).Bultos >= mb Then
    '            mb = dicst(x).Bultos
    '            ib = x

    '        End If

    '        If dicst(x).Palets >= mp Then
    '            mp = dicst(x).Palets
    '            ip = x

    '        End If

    '    Next
    '    If ik > 0 Then
    '        Valores = dicst(ik)
    '        Valores.Kilos = Valores.Kilos + VaDec(Albentrada_lineas.AEL_kilosnetos.Valor) - tk
    '        dicst(ik) = Valores
    '    End If

    '    If ib > 0 Then
    '        Valores = dicst(ib)
    '        Valores.Bultos = Valores.Bultos + VaInt(Albentrada_lineas.AEL_bultos.Valor) - tb
    '        dicst(ib) = Valores
    '    End If

    '    If ip > 0 Then
    '        Valores = dicst(ip)
    '        Valores.Palets = Valores.Palets + VaInt(Albentrada_lineas.AEL_palets.Valor) - tp
    '        dicst(ip) = Valores
    '    End If


    'End Sub


    Private Sub GeneraAlbaranMedianero(ByVal Alb As Integer, ByVal Cdag As Integer, ByVal Porc As Double, ByVal pv As Integer, ByVal cr As Integer, ByVal numed As Integer, ByVal Centro As String)

        Dim dt As New DataTable
        Dim AlbEntrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)
        Dim AlbEntrada_his As New E_AlbEntrada_his(Idusuario, cn)
        Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
        Dim Agricultor As New E_Agricultores(Idusuario, cn)
        Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)
        Dim ID As Integer
        Dim Tipoiva As Decimal = 0
        Dim tiporet As String = ""
        Dim poret As Decimal = 0
        Dim Campa As String = ""
        Dim Nualb As String = ""
        Dim FechaAlb As String = ""
        Dim idempresa As String = "1"


        If Agricultor.LeerId(Cdag.ToString) = True Then
            If TipoAgricultor.LeerId(Agricultor.AGR_IdTipo.Valor) = True Then
                Tipoiva = TipoAgricultor.TPA_poriva.Valor
                tiporet = TipoAgricultor.TPA_tiporet.Valor
                poret = TipoAgricultor.TPA_porret.Valor

            End If
            idempresa = Agricultor.AGR_idempresa.Valor
        End If
        If AlbEntrada.LeerId(Alb.ToString) = True Then
            Campa = AlbEntrada.AEN_Campa.Valor
            Nualb = AlbEntrada.AEN_Albaran.Valor
            FechaAlb = AlbEntrada.AEN_Fecha.Valor
        End If
        ID = AlbEntrada_his.MaxId
        AlbEntrada_his.AEH_id.Valor = ID.ToString

        AlbEntrada_his.AEH_idalbaran.Valor = Alb.ToString
        AlbEntrada_his.AEH_idproveedor.Valor = Cdag.ToString
        AlbEntrada_his.AEH_porcentaje.Valor = Porc.ToString
        AlbEntrada_his.AEH_tipoiva.Valor = Tipoiva.ToString
        AlbEntrada_his.AEH_tiporet.Valor = tiporet
        AlbEntrada_his.AEH_poret.Valor = poret.ToString
        If cr = 0 Then
            cr = pv
        End If
        AlbEntrada_his.AEH_nmed.Valor = numed.ToString
        AlbEntrada_his.AEH_idempresa.Valor = idempresa
        AlbEntrada_his.Insertar()


    End Sub


    Private Sub GeneraGastosAlbaranhis(ByVal idalbhis As Integer, dcfacturas As Dictionary(Of Integer, Integer), porcentaje As Decimal)

        Dim AlbEntrada_his As New E_AlbEntrada_his(Idusuario, cn)
        Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
        Dim AlbEntrada_hisgastos As New E_albentrada_hisgastos(Idusuario, cn)
        Dim AlbEntrada_hislineas As New E_AlbEntrada_hislineas(Idusuario, cn)
        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Dim AgricultorGastos As New E_AgricultorGastos(Idusuario, cn)
        Dim TiposdeGastoAgri As New E_TiposdeGastoAgri(Idusuario, cn)
        Dim AlbEntrada_gastos As New E_albentrada_gastos(Idusuario, cn)
        Dim Tipoagricultor As New E_TipoAgricultor(Idusuario, cn)
        Dim I As Double = 0

        Dim dt As New DataTable
        Dim sql As String = ""
        Dim Tk As Double = 0
        Dim Tb As Double = 0
        Dim Tp As Double = 0
        Dim Ti As Double = 0
        Dim IdAgricultor As String = ""
        Dim IdAlbaran As Integer = 0
        Dim Cr As Integer = 0
        Dim Pv As Integer = 0

        Dim IdTransportista As String = ""

        If AlbEntrada_his.LeerId(idalbhis.ToString) = True Then

            sql = "Select * from albentrada_hislineas where AHL_idalbhis=" + idalbhis.ToString
            dt = AlbEntrada_hislineas.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                For Each rw In dt.Rows
                    Tk = Tk + rw("AHL_Kilos")

                    Select Case rw("AHL_tipoprecio").ToString
                        Case "P"
                            Ti = Ti + rw("AHL_palets") * rw("AHL_precio")
                        Case "B"
                            Ti = Ti + rw("AHL_bultos") * rw("AHL_precio")
                        Case Else
                            Ti = Ti + rw("AHL_kilos") * rw("AHL_precio")

                    End Select

                    Tb = Tb + rw("AHL_bultos")
                    Tp = Tp + rw("AHL_palets")
                Next
            End If



            IdAgricultor = AlbEntrada_his.AEH_idproveedor.Valor
            IdAlbaran = AlbEntrada_his.AEH_idalbaran.Valor
            If AlbEntrada.LeerId(IdAlbaran) = True Then

                Cr = VaInt(AlbEntrada.AEN_IdRecogida.Valor)

                IdTransportista = AlbEntrada.AEN_IdTransportista.Valor

                Dim consulta3 As New Cdatos.E_select
                consulta3.SelCampo(AlbEntrada_gastos.AEG_IdGasto, "IdGasto")
                consulta3.SelCampo(AlbEntrada_gastos.AEG_Tipo, "Tipo")
                consulta3.SelCampo(AlbEntrada_gastos.AEG_Gasto, "Gasto")
                consulta3.SelCampo(AlbEntrada_gastos.AEG_IdAcreedor, "IdAcreedor")
                consulta3.SelCampo(AlbEntrada_gastos.AEG_TipoFC, "TipoFC")
                consulta3.WheCampo(AlbEntrada_gastos.AEG_IdAlbaran, "=", IdAlbaran.ToString)


                Dim dt3 As DataTable = AlbEntrada_gastos.MiConexion.ConsultaSQL(consulta3.SQL)

                If Not dt3 Is Nothing Then
                    For Each rw In dt3.Rows
                        I = 0
                        Dim vg As Decimal = VaDec(rw("gasto"))
                        Select Case rw("tipo")
                            Case "K"
                                I = Tk * rw("gasto")
                            Case "B"
                                I = Tb * rw("gasto")
                            Case "P"
                                I = Tp * rw("gasto")
                            Case "%"
                                I = Ti * rw("gasto") / 100
                            Case "I"
                                vg = vg * porcentaje / 100
                                I = vg

                        End Select
                        AñadirLineaGastoshis(idalbhis, IdAlbaran, VaInt(rw("idgasto")), vg, rw("tipo"), rw("TipoFc"), I, rw("idacreedor"), dcfacturas)

                    Next
                End If

            End If
        End If



        ' COMISION

        'If Agricultores.LeerId(IdAgricultor) = True Then
        '    Dim consulta1 As New Cdatos.E_select
        '    consulta1.SelCampo(Tipoagricultor.TPA_idgasto, "idgasto")
        '    consulta1.SelCampo(Tipoagricultor.TPA_porcomision, "valor")
        '    consulta1.SelCampo(TiposdeGastoAgri.TGA_tipogastofc, "tipofc", Tipoagricultor.TPA_idgasto)
        '    consulta1.SelCampo(TiposdeGastoAgri.TGA_Tipo, "tipo")
        '    consulta1.SelCampo(TiposdeGastoAgri.TGA_idacreedor, "idacreedor")
        '    consulta1.WheCampo(Tipoagricultor.TPA_idtipo, "=", Agricultores.AGR_IdTipo.Valor)
        '    Dim sqla As String = consulta1.SQL
        '    dt = Tipoagricultor.MiConexion.ConsultaSQL(sqla)
        '    If Not dt Is Nothing Then
        '        For Each rw In dt.Rows
        '            I = 0
        '            Select Case rw("tipo").ToString

        '                Case "K"
        '                    I = Tk * rw("valor")
        '                Case "B"
        '                    I = Tb * rw("valor")
        '                Case "P"
        '                    I = Tp * rw("valor")
        '                Case "%"
        '                    I = Ti * rw("valor") / 100
        '                Case "I"
        '                    I = rw("valor")
        '            End Select
        '            AñadirLineaGastoshis(idalbhis, IdAlbaran, rw("idgasto").ToString, rw("valor").ToString, rw("tipo").ToString, rw("tipofc").ToString, I, rw("idacreedor").ToString)


        '        Next
        '    End If

        'End If


        Dim Consulta As New Cdatos.E_select
        Consulta.SelCampo(AgricultorGastos.AGG_IdGasto, "idgasto")
        Consulta.SelCampo(AgricultorGastos.AGG_Valor, "valor")
        Consulta.SelCampo(TiposdeGastoAgri.TGA_Tipo, "tipo", AgricultorGastos.AGG_IdGasto)
        Consulta.SelCampo(AgricultorGastos.AGG_TipoFC, "tipofc")
        Consulta.SelCampo(AgricultorGastos.AGG_IdAcreedor, "idacreedor")
        Consulta.SelCampo(AgricultorGastos.AGG_AsignarAcreedorAlbaran, "AsignarAcreedor")
        Consulta.SelCampo(AgricultorGastos.AGG_idcentrorec, "IdCentroRecogida")
        Consulta.WheCampo(AgricultorGastos.AGG_IdAgricultor, "=", IdAgricultor)
        Consulta.WheCampo(AgricultorGastos.AGG_PedirEntrada, "<>", "S")

        Dim sqlg As String = Consulta.SQL
        sqlg = sqlg + " AND (AGG_idcentrorec=0 or AGG_Idcentrorec=" + Cr.ToString + ") "
        sqlg = sqlg + " order by AGG_id"


        dt = AgricultorGastos.MiConexion.ConsultaSQL(sqlg)



        'Explicación del comportamiento de la generación de los gastos (16/12/2021) según cambios pedidos por Manolo
        'Los gastos sin centro de recogida se aplican para todos los centros
        'Los gastos con centro de recogida se aplican sólo si el albarán de entrada tiene ese centro de recogida especificado
        'Si se da el caso de que hay un gasto con el mismo IdGasto y el mismo IdAcreeedor pero distinto centro de recogida y el centro de recogida es el mismo del albarán de entrada, se usa el que tiene el centro de recogida, el que no tiene centro de recogida no se usa
        'Se validará desde el grid de gastos de la ficha de agricultor que no pueda existir un gasto con mismo IdGasto, IdAcreedor e IdCentroRecogida

        Dim DcGastos As New Dictionary(Of String, DataRow)          'Almacena como clave el IdGasto y el IdAcreedor y guarda el Centro de recogida que tiene que aplicar
        If Not IsNothing(dt) Then

            Dim dtGastos As DataTable = dt.Copy


            'Primero añadimos todos los que no tengan centro de recogida
            For Each row As DataRow In dt.Rows

                Dim IdCentroRecogida As String = (row("IdCentroRecogida").ToString & "").Trim
                If VaInt(IdCentroRecogida) = 0 Then

                    Dim IdGasto As String = (row("IdGasto").ToString & "").Trim
                    Dim IdAcreedor As String = (row("IdAcreedor").ToString & "").Trim
                    Dim clave As String = IdGasto & "|" & IdAcreedor

                    DcGastos(clave) = row

                End If

            Next

            'Después sobreeescribimos los que tengan el mismo idgasto e idacreedor, pero con el centro de recogida actual
            For Each row As DataRow In dt.Rows

                Dim IdCentroRecogida As String = (row("IdCentroRecogida").ToString & "").Trim
                If VaInt(IdCentroRecogida) = Cr Then

                    Dim IdGasto As String = (row("IdGasto").ToString & "").Trim
                    Dim IdAcreedor As String = (row("IdAcreedor").ToString & "").Trim
                    Dim clave As String = IdGasto & "|" & IdAcreedor

                    DcGastos(clave) = row

                End If

            Next


        End If



        'If Not dt Is Nothing Then
        'For Each rw In dt.Rows

        For Each rw As DataRow In DcGastos.Values

            I = 0

            Dim vg As Decimal = VaDec(rw("valor"))
            Dim bAsignarAcreedor As Boolean = ((rw("AsignarAcreedor").ToString & "").Trim = "S")


            Select Case rw("tipo")
                Case "K"
                    I = Tk * rw("valor")
                Case "B"
                    I = Tb * rw("valor")
                Case "P"
                    I = Tp * rw("valor")
                Case "%"
                    I = Ti * rw("valor") / 100
                Case "I"
                    vg = vg * porcentaje / 100
                    I = vg
            End Select


            Dim IdAcreedor As String = rw("idacreedor").ToString

            If bAsignarAcreedor = True Then
                IdAcreedor = IdTransportista
            End If
            AñadirLineaGastoshis(idalbhis, IdAlbaran, rw("idgasto"), vg, rw("tipo"), rw("tipofc"), I, IdAcreedor, dcfacturas)

        Next
        'End If
    End Sub

    Private Sub AñadirLineaGastoshis(ByVal idalbhis As Integer, ByVal idalbaran As Integer, ByVal idgasto As Integer, ByVal valor As Decimal, ByVal tipo As String, ByVal tipofc As String, ByVal importe As Double, ByVal idacreedor As String, dcfacturas As Dictionary(Of Integer, Integer))

        Dim AlbEntrada_hisgastos As New E_albentrada_hisgastos(Idusuario, cn)


        Dim idfactura As Integer = 0
        If dcfacturas.ContainsKey(idacreedor) = True Then
            idfactura = dcfacturas(idacreedor)
        End If

        Dim id As Integer = AlbEntrada_hisgastos.MaxId
        AlbEntrada_hisgastos.VaciaEntidad()
        AlbEntrada_hisgastos.AHG_id.Valor = id.ToString
        AlbEntrada_hisgastos.AHG_idalbhis.Valor = idalbhis.ToString
        AlbEntrada_hisgastos.AHG_idgasto.Valor = idgasto.ToString
        AlbEntrada_hisgastos.AHG_valor.Valor = valor.ToString
        AlbEntrada_hisgastos.AHG_tipo.Valor = tipo
        AlbEntrada_hisgastos.AHG_importe.Valor = importe.ToString
        AlbEntrada_hisgastos.AHG_factura_comercial.Valor = tipofc
        AlbEntrada_hisgastos.AHG_idfacturaproveedor.Valor = idfactura.ToString
        AlbEntrada_hisgastos.AHG_idalbaran.Valor = idalbaran.ToString
        AlbEntrada_hisgastos.AHG_idacreedor.Valor = idacreedor.ToString
        AlbEntrada_hisgastos.Insertar()

    End Sub




    
End Module
