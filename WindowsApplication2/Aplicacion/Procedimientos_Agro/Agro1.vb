Module Agro1



    Public Function AgClasifiPartida(idpartida As Integer) As DataTable

        Dim ret As New DataTable

        Dim kconf As Decimal = 0

        ret.Columns.Add("idcat", GetType(System.Int32))
        ret.Columns.Add("Categoria", GetType(System.String))
        ret.Columns.Add("Kilos", GetType(System.Decimal))
        ret.Columns.Add("Porcentaje", GetType(System.Decimal))
        ret.Columns.Add("Numero", GetType(System.String))


        Dim lotes As New E_Lotes(Idusuario, cn)
        Dim lotes_lineas As New E_Lotes_lineas(Idusuario, cn)
        Dim Lotes_produccion As New E_LotesProduccion(Idusuario, cn)
        Dim lotes_produccion_lineas As New E_LotesProduccion_Lineas(Idusuario, cn)
        Dim Palets_lineas As New E_palets_lineas(Idusuario, cn)
        Dim Palets_traza As New E_palets_traza(Idusuario, cn)
        Dim Palets As New E_palets(Idusuario, cn)
        Dim CategoriaSalida As New E_CategoriasSalida(Idusuario, cn)
        Dim CategoriaEntrada As New E_CategoriasEntrada(Idusuario, cn)
        Dim Produccion As New E_Produccion(Idusuario, cn)
        Dim AlbEntrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)


        'aplico la clasificacion de los lotes de entrada a la parte de la partida que está en el lote
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(lotes_lineas.LTL_Kilos, "kilos")
        consulta.SelCampo(lotes_lineas.LTL_Idlote, "idlote")
        consulta.SelCampo(lotes.LTE_Lote, "numero", lotes_lineas.LTL_Idlote)
        consulta.WheCampo(lotes_lineas.LTL_Idlineaentrada, "=", idpartida.ToString)

        Dim dt As DataTable = lotes_lineas.MiConexion.ConsultaSQL(consulta.SQL)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                Dim kilos As Decimal = VaDec(rw("kilos"))
                Dim dtlote As DataTable = AgClasifiLote(VaInt(rw("idlote")), rw("numero").ToString)

                For Each rwl In dtlote.Rows
                    Dim porcentaje As Decimal = VaDec(rwl("porcentaje"))
                    ret = LineaClasif(ret, VaInt(rwl("idcat")), rwl("Categoria").ToString, kilos * porcentaje / 100, "L-" + rw("numero").ToString)
                    kconf = kconf + kilos * porcentaje / 100
                Next
            Next

        End If


        If AlbEntrada_lineas.LeerId(idpartida) = True Then

            Dim kdestrio As Decimal = Produccion.KilosDestrio_Partida(idpartida)
            If kdestrio <> 0 Then
                ret = LineaClasif(ret, 500, "DESTRIO", kdestrio, "E-" & AlbEntrada_lineas.AEL_muestreo.Valor)
                kconf = kconf + kdestrio
            End If
        End If

        ' precalibrados de la partida

        Dim consulta2 As New Cdatos.E_select
        consulta2.SelCampo(lotes_produccion_lineas.LPL_Bultos, "bultos")
        consulta2.SelCampo(lotes_produccion_lineas.LPL_Kilos, "Kilos")
        consulta2.SelCampo(Lotes_produccion.LPD_KilosxBulto, "kxb", lotes_produccion_lineas.LPL_Idlote)
        consulta2.SelCampo(Lotes_produccion.LPD_Lote, "Numero")
        consulta2.SelCampo(Lotes_produccion.LPD_Idlote, "idlote")
        consulta2.SelCampo(CategoriaSalida.CAS_IdCategoriaEntrada, "idcat", Lotes_produccion.LPD_IdCategoria)
        consulta2.SelCampo(CategoriaEntrada.CAE_CategoriaCalibre, "Categoria", CategoriaSalida.CAS_IdCategoriaEntrada)

        consulta2.WheCampo(lotes_produccion_lineas.LPL_IdlineaEntrada, "=", idpartida.ToString)

        Dim dt2 As DataTable = Lotes_produccion.MiConexion.ConsultaSQL(consulta2.SQL)
        If Not dt2 Is Nothing Then
            For Each rw In dt2.Rows


                ret = LineaClasif(ret, VaInt(rw("idcat")), rw("categoria").ToString, VaDec(rw("kilos")), "C-" + rw("numero").ToString)
                kconf = kconf + VaDec(rw("kilos"))

                Dim kdestriop As Decimal = Produccion.KilosDestrio_LoteProduccion(VaInt(rw("idlote")))
                If kdestriop <> 0 Then
                    ret = LineaClasif(ret, 500, "DESTRIO", kdestriop, "C-" & rw("numero").ToString)
                    kconf = kconf + kdestriop
                End If

            Next
        End If


        ' palets de la partida


        Dim consulta1 As New Cdatos.E_select
        consulta1.SelCampo(Palets_traza.PLT_bultos, "bultos")
        consulta1.SelCampo(Palets_lineas.PLL_kilosnetos, "kilosnetos", Palets_traza.PLT_idlineapalet)
        consulta1.SelCampo(Palets_lineas.PLL_bultos, "bultospalet")
        consulta1.SelCampo(Palets.PAL_palet, "Numero", Palets_lineas.PLL_idpalet)
        consulta1.SelCampo(CategoriaSalida.CAS_IdCategoriaEntrada, "idcat", Palets_lineas.PLL_idcategoria)
        consulta1.SelCampo(CategoriaEntrada.CAE_CategoriaCalibre, "Categoria", CategoriaSalida.CAS_IdCategoriaEntrada)
        consulta1.WheCampo(Palets_traza.PLT_idprogramacliente, "=", "0")
        consulta1.WheCampo(Palets_traza.PLT_IdLineaEntrada, "=", idpartida.ToString)

        Dim dt1 As DataTable = Palets_lineas.MiConexion.ConsultaSQL(consulta1.SQL)
        If Not dt1 Is Nothing Then
            For Each rw In dt1.Rows
                Dim kxb As Decimal = 0
                If VaDec(rw("bultospalet")) <> 0 Then
                    kxb = VaDec(rw("kilosnetos")) / VaDec(rw("bultospalet"))
                End If
                ret = LineaClasif(ret, VaInt(rw("idcat")), rw("Categoria").ToString, VaDec(rw("bultos")) * kxb, "P-" + rw("numero").ToString)
                kconf = kconf + VaDec(rw("bultos")) * kxb
            Next
        End If

        For Each rw In ret.Rows
            Dim p As Decimal = 0
            If kconf <> 0 Then
                p = VaDec(rw("kilos")) / kconf
                rw("porcentaje") = p * 100

            End If

        Next


        'Dim dv As New DataView(ret)
        'dv.Sort = "idcat"
        'ret = dv.ToTable


        Return ret


    End Function

    Public Function AgClasifiLote(idlote As Integer, NumeroLote As String) As DataTable
        Dim ret As New DataTable
        Dim kconf As Decimal = 0

        ret.Columns.Add("idcat", GetType(System.Int32))
        ret.Columns.Add("Categoria", GetType(System.String))
        ret.Columns.Add("Kilos", GetType(System.Decimal))
        ret.Columns.Add("Porcentaje", GetType(System.Decimal))
        ret.Columns.Add("Numero", GetType(System.String))


        Dim Lotes_produccion As New E_LotesProduccion(Idusuario, cn)
        Dim lotes_produccion_lineas As New E_LotesProduccion_Lineas(Idusuario, cn)
        Dim Palets_lineas As New E_palets_lineas(Idusuario, cn)
        Dim Palets_traza As New E_palets_traza(Idusuario, cn)
        Dim Palets As New E_palets(Idusuario, cn)
        Dim CategoriaSalida As New E_CategoriasSalida(Idusuario, cn)
        Dim CategoriaEntrada As New E_CategoriasEntrada(Idusuario, cn)
        Dim Produccion As New E_Produccion(Idusuario, cn)


        Dim sql As String = ""
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(lotes_produccion_lineas.LPL_Bultos, "bultos")
        consulta.SelCampo(lotes_produccion_lineas.LPL_Kilos, "Kilos")
        consulta.SelCampo(Lotes_produccion.LPD_KilosxBulto, "kxb", lotes_produccion_lineas.LPL_Idlote)
        consulta.SelCampo(Lotes_produccion.LPD_Lote, "Numero")
        consulta.SelCampo(Lotes_produccion.LPD_Idlote, "idlotep")
        consulta.SelCampo(CategoriaSalida.CAS_IdCategoriaEntrada, "idcat", Lotes_produccion.LPD_IdCategoria)
        consulta.SelCampo(CategoriaEntrada.CAE_CategoriaCalibre, "Categoria", CategoriaSalida.CAS_IdCategoriaEntrada)

        consulta.WheCampo(lotes_produccion_lineas.LPL_IdLotePartida, "=", idlote.ToString)

        Dim dt As DataTable = Lotes_produccion.MiConexion.ConsultaSQL(consulta.SQL)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                ret = LineaClasif(ret, VaInt(rw("idcat")), rw("categoria").ToString, VaDec(rw("kilos")), "C-" + rw("numero").ToString)
                kconf = kconf + VaDec(rw("kilos"))
                Dim kdestriop As Decimal = Produccion.KilosDestrio_LoteProduccion(VaInt(rw("idlotep")))
                If kdestriop <> 0 Then
                    ret = LineaClasif(ret, 500, "DESTRIO", kdestriop, "C-" & rw("numero").ToString)
                    kconf = kconf + kdestriop
                End If

            Next
        End If


        Dim consulta1 As New Cdatos.E_select
        consulta1.SelCampo(Palets_traza.PLT_bultos, "bultos")
        consulta1.SelCampo(Palets_lineas.PLL_kilosnetos, "kilosnetos", Palets_traza.PLT_idlineapalet)
        consulta1.SelCampo(Palets_lineas.PLL_bultos, "bultospalet")
        consulta1.SelCampo(Palets.PAL_palet, "Numero", Palets_lineas.PLL_idpalet)
        consulta1.SelCampo(CategoriaSalida.CAS_IdCategoriaEntrada, "idcat", Palets_lineas.PLL_idcategoria)
        consulta1.SelCampo(CategoriaEntrada.CAE_CategoriaCalibre, "Categoria", CategoriaSalida.CAS_IdCategoriaEntrada)
        consulta1.WheCampo(Palets_traza.PLT_idprogramacliente, "=", "0")
        consulta1.WheCampo(Palets_traza.PLT_idlote, "=", idlote.ToString)

        Dim dt2 As DataTable = Palets_lineas.MiConexion.ConsultaSQL(consulta1.SQL)
        If Not dt2 Is Nothing Then
            For Each rw In dt2.Rows
                Dim kxb As Decimal = 0
                If VaDec(rw("bultospalet")) <> 0 Then
                    kxb = VaDec(rw("kilosnetos")) / VaDec(rw("bultospalet"))
                End If
                ret = LineaClasif(ret, VaInt(rw("idcat")), rw("Categoria").ToString, VaDec(rw("bultos")) * kxb, "P-" + rw("numero").ToString)
                kconf = kconf + VaDec(rw("bultos")) * kxb
            Next
        End If


        Dim kdestrio As Decimal = Produccion.KilosDestrio_Lote(idlote)
        If kdestrio <> 0 Then
            ret = LineaClasif(ret, 500, "DESTRIO", kdestrio, "L-" & NumeroLote)
            kconf = kconf + kdestrio

        End If

        Dim kiloslote As Decimal = 0
        sql = "Select sum(LTL_kilos) as kilos from lotes_lineas where ltl_idlote=" + idlote.ToString
        Dim dtklote As DataTable = Lotes_produccion.MiConexion.ConsultaSQL(sql)
        If Not dtklote Is Nothing Then
            If dtklote.Rows.Count > 0 Then
                kiloslote = VaDec(dtklote.Rows(0)("kilos"))
            End If
        End If

        For Each rw In ret.Rows
            Dim p As Decimal = 0
            If kconf <> 0 Then
                p = VaDec(rw("kilos")) / kconf
                p = p * kconf / kiloslote
                rw("porcentaje") = p * 100

            End If

        Next

        Return ret

    End Function

    Private Function LineaClasif(dt As DataTable, idcat As Integer, Categoria As String, kilos As Decimal, Numero As String) As DataTable


        Dim s As Boolean = False
        For Each rw In dt.Rows
            If VaInt(rw("idcat")) = idcat And rw("numero").ToString = Numero Then
                rw("kilos") = VaDec(rw("kilos")) + kilos
                s = True
            End If
        Next

        If s = False Then
            dt.Rows.Add(idcat, Categoria, kilos, 0, Numero)
        End If
        Return dt

    End Function

End Module
