Module AlbaranesSalidaComercio


    Public DcEmpresaPventa As New Dictionary(Of Integer, Integer) ' asignamos la empresa para cada punto de venta


    Public Class stClave_lineasAlbaran

        Public IdGenero As Integer = 0
        Public IdConfecEnvase As Integer = 0
        Public IdCategoria As Integer = 0
        Public idConfecPalet As Integer = 0
        Public Categoria As String = ""
        Public IdMarca As Integer = 0
        Public IdGensal As Integer = 0
        Public BultosxPalet As Integer = 0


        Public Sub New(ByVal Idgenero As Integer, ByVal Idconfecenvase As Integer, ByVal IdCategoria As Integer, ByVal Idconfecpalet As Integer, ByVal Categoria As String, ByVal Idmarca As Integer, ByVal IdGensal As Integer, ByVal BultosXPalet As Integer)
            Me.IdGenero = Idgenero
            Me.IdConfecEnvase = Idconfecenvase
            Me.IdCategoria = IdCategoria
            Me.idConfecPalet = Idconfecpalet
            Me.Categoria = Categoria
            Me.IdMarca = Idmarca
            Me.IdGensal = IdGensal
            Me.BultosxPalet = BultosXPalet
        End Sub

    End Class

    Public Class stDatos_lineasAlbaran
        Public Palets As Integer = 0
        Public Bultos As Decimal = 0
        Public KilosNetos As Decimal = 0
        Public KilosBrutos As Decimal = 0
        Public KilosSalidos As Decimal = 0
        Public piezas As Decimal = 0
        Public CosteEstructura As Decimal = 0
        Public CosteConfeccion As Decimal = 0
        Public CosteMaterial As Decimal = 0
        Public CoeficientePalet As Decimal = 0

        Public Sub New(ByVal palets As Integer, ByVal Bultos As Decimal, ByVal kilosnetos As Decimal, ByVal kilosbrutos As Decimal, ByVal kilossalidos As Decimal, ByVal piezas As Decimal, ByVal CosteEstructura As Decimal, ByVal CosteConfeccion As Decimal, ByVal CosteMaterial As Decimal, ByVal CoeficientePalet As Decimal)
            Me.Palets = palets
            Me.Bultos = Bultos
            Me.KilosNetos = kilosnetos
            Me.KilosBrutos = kilosbrutos
            Me.KilosSalidos = kilossalidos
            Me.piezas = piezas
            Me.CosteEstructura = CosteEstructura
            Me.CosteMaterial = CosteMaterial
            Me.CosteConfeccion = CosteConfeccion
            Me.CoeficientePalet = CoeficientePalet
        End Sub

    End Class


    Public Class stDatos_precioAlbaran
        Public tipoprecio As String = ""
        Public precio As Decimal = 0
        Public Sub New(ByVal Tipoprecio As String, ByVal Precio As Decimal)
            Me.tipoprecio = Tipoprecio
            Me.precio = Precio
        End Sub
    End Class


    Private Class stClaves_CMR

        Public IdPalet As Integer = 0
        Public IdFamilia As Integer = 0
        Public IdMarca As Integer = 0
        Public Envase As String = ""

        Public Sub New(IdPalet As Integer, IdFamilia As Integer, IdMarca As Integer, Envase As String)

            Me.IdPalet = IdPalet
            Me.IdFamilia = IdFamilia
            Me.IdMarca = IdMarca
            Me.Envase = Envase

        End Sub

    End Class

    Private Class stDatos_CMR

        Public Palets As Integer = 0
        Public PaletsTransporte As Decimal = 0
        Public Bultos As Decimal = 0
        Public KgNetos As Decimal = 0
        Public KgBrutos As Decimal = 0

        Public Sub New(Palets As Integer, PaletsTransporte As Decimal, Bultos As Decimal, KgNetos As Decimal, KgBrutos As Decimal)

            Me.Palets = Palets
            Me.PaletsTransporte = PaletsTransporte
            Me.Bultos = Bultos
            Me.KgNetos = KgNetos
            Me.KgBrutos = KgBrutos

        End Sub

    End Class


    Dim acum As New Acumulador
    Dim acumCoste As New Acumulador
    Dim AcumPrecio As New Acumulador

    Private Property Albsalidalineas_gastos As Object



    Dim DcPalets As New Dictionary(Of Integer, stClave_lineasAlbaran)



    Private Sub AsociarLineasPaletASalidas(IdLineaSalida As String, clave As stClave_lineasAlbaran)

        Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)

        For Each IdLineaPalet As Integer In DcPalets.Keys

            Dim valor As stClave_lineasAlbaran = DcPalets(IdLineaPalet)
            If valor Is clave Then

                If Palets_Lineas.LeerId(IdLineaPalet) Then
                    Palets_Lineas.PLL_IdLineaSalida.Valor = IdLineaSalida
                    Palets_Lineas.Actualizar()
                End If

            End If
        Next

    End Sub


    Public Sub Agro_asociarpaletsalineas(idalbaran As Integer)

        ' asociamos las lineas de los palets con las lineas de salidas por presentacion, categoria, nombrecategoria y marca
        Dim DcLineasPaletsAsociadas As New Dictionary(Of Integer, Integer)

        Dim Palets_lineas As New E_palets_lineas(Idusuario, cn)
        Dim Palets As New E_palets(Idusuario, cn)
        Dim Albsalida_palets As New E_albsalida_palets(Idusuario, cn)
        Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)


        Dim consulta1 As New Cdatos.E_select
        consulta1.SelCampo(Albsalida_lineas.ASL_idlinea, "linealabaran")
        consulta1.SelCampo(Albsalida_lineas.ASL_idgensal, "idgensal")
        consulta1.SelCampo(Albsalida_lineas.ASL_idcategoria, "idcategoria")
        consulta1.SelCampo(Albsalida_lineas.ASL_categoria, "categoria")
        consulta1.SelCampo(Albsalida_lineas.ASL_idmarca, "idmarca")
        consulta1.SelCampo(Albsalida_lineas.ASL_idtipopalet, "idtipopalet")
        consulta1.SelCampo(Albsalida_lineas.ASL_bultos, "Bultos")
        consulta1.SelCampo(Albsalida_lineas.ASL_palets, "Palets")
        consulta1.WheCampo(Albsalida_lineas.ASL_idalbaran, "=", idalbaran.ToString)


        Dim sql1 As String = consulta1.SQL

        Dim dt1 As DataTable = Albsalida_lineas.MiConexion.ConsultaSQL(sql1)
        If Not dt1 Is Nothing Then
            If dt1.Rows.Count > 0 Then


                Dim Consulta As New Cdatos.E_select
                Consulta.SelCampo(Palets_lineas.PLL_idlinea, "idlineapalet")
                Consulta.SelCampo(Palets_lineas.PLL_idgensal, "idgensal")
                Consulta.SelCampo(Palets_lineas.PLL_idcategoria, "idcategoria")
                Consulta.SelCampo(Palets_lineas.PLL_categoria, "categoria")
                Consulta.SelCampo(Palets_lineas.PLL_idmarca, "idmarca")
                Consulta.SelCampo(Palets_lineas.PLL_IdLineaSalida, "idlineasalida")
                Consulta.SelCampo(Palets_lineas.PLL_bultos, "BxP")
                Consulta.SelCampo(Palets_lineas.PLL_idmarcaeti, "idmarcaeti")
                Consulta.SelCampo(Palets_lineas.PLL_idmarcamat, "idmarcamat")
                Consulta.SelCampo(Albsalida_palets.ASP_Idpalet, "idpalet", Palets_lineas.PLL_idpalet, Albsalida_palets.ASP_Idpalet)
                Consulta.SelCampo(Palets.PAL_Lote, "LotePalet", Palets_lineas.PLL_idpalet)
                Consulta.WheCampo(Albsalida_palets.ASP_IdAlbaran, "=", idalbaran.ToString)

                Dim sql As String = Consulta.SQL
                Dim dt As DataTable = Palets_lineas.MiConexion.ConsultaSQL(sql)

                If Not dt Is Nothing Then

                    For Each rw In dt.Rows

                        Dim idlineapalet As Integer = VaInt(rw("idlineapalet"))


                        'Sólo intentamos asociar el palet si no lo hemos asociado antes
                        If Not DcLineasPaletsAsociadas.ContainsKey(idlineapalet) Then

                            Dim idgensal As Integer = VaInt(rw("idgensal"))
                            Dim idcategoria As Integer = VaInt(rw("idcategoria"))
                            Dim categoria As String = rw("categoria").ToString.Trim
                            Dim idmarca As Integer = VaInt(rw("idmarca"))

                            Dim BxP As Integer = VaInt(rw("BxP"))


                            For Each rw1 In dt1.Rows

                                Dim encontrado As Boolean = False

                                Dim Bultos_Albaran As Integer = VaInt(rw1("Bultos"))
                                Dim Palets_Albaran As Integer = VaInt(rw1("Palets"))
                                Dim BxP_Albaran As Decimal = 0
                                If Palets_Albaran > 0 Then
                                    BxP_Albaran = Bultos_Albaran / Palets_Albaran
                                Else
                                    BxP_Albaran = Bultos_Albaran
                                End If

                                If idgensal = VaInt(rw1("idgensal")) And _
                                    idcategoria = VaInt(rw1("idcategoria")) And _
                                    categoria = rw1("categoria").ToString.Trim And _
                                    idmarca = VaInt(rw1("idmarca")) And _
                                    BxP = BxP_Albaran Then
                                    encontrado = True
                                End If


                                If encontrado = True Then
                                    Dim idlineaalbaran As Integer = VaInt(rw1("linealabaran"))
                                    If Palets_lineas.LeerId(idlineapalet.ToString) = True Then
                                        Palets_lineas.PLL_IdLineaSalida.Valor = idlineaalbaran.ToString
                                        Palets_lineas.Actualizar()
                                        DcLineasPaletsAsociadas(idlineapalet) = idlineapalet
                                        Exit For
                                    End If
                                Else
                                    If Palets_lineas.LeerId(idlineapalet) = True Then
                                        Palets_lineas.PLL_IdLineaSalida.Valor = "0"
                                        Palets_lineas.Actualizar()
                                    End If
                                End If

                            Next

                        End If


                    Next

                End If

            End If

        End If


    End Sub



    Public Function CrearCMRDesdeAlbaran(IdAlbaran As String) As String

        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
        If AlbSalida.LeerId(IdAlbaran) Then
            Return CrearCMRDesdeAlbaran(AlbSalida)
        Else
            MsgBox("Imposible leer albarán de salida con id " & IdAlbaran)
            Return ""
        End If

    End Function


    Public Function CrearCMRDesdeAlbaran(AlbSalida As E_AlbSalida) As String

        Dim IdDomicilio As Integer = 0
        Dim OD As String = ""


        Dim IdAlbaran As String = AlbSalida.ASA_idalbaran.Valor




        Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
        Dim Pedidos As New E_Pedidos(Idusuario, cn)
        If Pedidos.LeerId(AlbSalida.ASA_idpedido.Valor) Then

            IdDomicilio = VaInt(Pedidos.PED_iddestino.Valor)

            Dim TiposPorte As New E_TiposPorte(Idusuario, cn)
            If VaInt(Pedidos.PED_idporte.Valor) Then
                If TiposPorte.LeerId(Pedidos.PED_idporte.Valor) Then
                    OD = (TiposPorte.TPO_OrigenDestino.Valor).Trim.ToUpper
                End If
            End If

        End If



        'Cabecera
        Dim CMR As New E_Cmr(Idusuario, cn)
        Dim IdCMR As String = CMR.MaxId()
        CMR.CMR_IdCmr.Valor = IdCMR
        CMR.CMR_Campa.Valor = AlbSalida.ASA_ejercicio.Valor
        CMR.CMR_Albaran.Valor = AlbSalida.ASA_albaran.Valor
        CMR.CMR_FechaSalida.Valor = AlbSalida.ASA_fechasalida.Valor
        CMR.CMR_Idcliente.Valor = AlbSalida.ASA_idcliente.Valor
        If IdDomicilio > 0 Then CMR.CMR_Iddestino.Valor = IdDomicilio
        CMR.CMR_OD.Valor = OD
        CMR.CMR_tipodoc.Valor = "C"
        CMR.CMR_Idcentro.Valor = AlbSalida.ASA_idcentro.Valor
        CMR.Insertar()



        'Líneas
        Dim sql As String = "SELECT PAL_IdPalet, PAL_PaletsTransporte as PaletsTransporte, SFA_IdFamilia as idFamilia," & vbCrLf
        sql = sql & " PLL_IdMarca as IdMarca," & vbCrLf
        sql = sql & " CPA_IdPalet as IdPalet, ENV_Nombre as Envase, " & vbCrLf
        sql = sql & " COALESCE(PLL_Bultos,0) as Bultos," & vbCrLf
        sql = sql & " COALESCE(PLL_KilosNetos,0) as KgNetos," & vbCrLf
        sql = sql & " COALESCE(PLL_KilosBrutos,0) as KgBrutos" & vbCrLf
        sql = sql & " FROM Palets_Lineas " & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = PLL_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN SubFamilias ON GEN_IdSubfamilia = SFA_Id" & vbCrLf
        sql = sql & " LEFT JOIN ConfecEnvase ON CEV_IdConfec = PLL_IdTipoConfeccion" & vbCrLf
        sql = sql & " LEFT JOIN Palets ON PAL_IdPalet = PLL_IdPalet " & vbCrLf
        sql = sql & " LEFT JOIN ConfecPalet ON CPA_IdConfec = PAL_IdTipoPalet" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON CEV_IdEnvase = ENV_IdEnvase" & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida_Palets ON PLL_IdPalet = ASP_IdPalet" & vbCrLf
        sql = sql & " WHERE ASP_IdAlbaran = " & IdAlbaran & vbCrLf
        sql = sql & " ORDER BY PAL_IdPalet" & vbCrLf


        Dim dtPalets As DataTable = CMR.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dtPalets) Then

            Dim acum As New Acumulador
            Dim AuxPalet As Integer = 0

            For Each row As DataRow In dtPalets.Rows

                Dim coeficiente As Decimal = VaDec(row("PaletsTransporte"))
                Dim var As Integer = 0

                If AuxPalet <> VaInt(row("PAL_IdPalet")) Then
                    var = 1
                Else
                    var = 0
                End If

                Dim IdEnvasePalet As Integer = VaInt(row("IdPalet"))
                Dim IdFamilia As Integer = VaInt(row("IdFamilia"))
                Dim IdMarca As Integer = VaInt(row("IdMarca"))
                Dim Envase As String = (row("Envase").ToString & "").Trim

                Dim Bultos As Integer = VaInt(row("Bultos"))
                Dim KgNetos As Decimal = VaDec(row("KgNetos"))
                Dim KgBrutos As Decimal = VaDec(row("KgBrutos"))

                Dim stClaves As New stClaves_CMR(IdEnvasePalet, IdFamilia, IdMarca, Envase)
                Dim stDatos As New stDatos_CMR(var, var * coeficiente, Bultos, KgNetos, KgBrutos)

                acum.Suma(stClaves, stDatos)


                AuxPalet = VaInt(row("PAL_IdPalet"))

            Next


            Dim dt As DataTable = acum.DataTable

            If Not IsNothing(dt) Then

                For Each row As DataRow In dt.Rows

                    Dim IdFamilia As String = row("IdFamilia").ToString
                    Dim IdMarca As String = row("IdMarca").ToString
                    Dim IdPalet As String = row("IdPalet").ToString
                    Dim Envase As String = row("Envase").ToString

                    'Palets, Bultos, KNetos y KBrutos los sacamos de las líneas de palets
                    Dim Palets As Integer = VaInt(row("Palets"))
                    Dim PaletsTransporte As Decimal = VaDec(row("PaletsTransporte"))
                    Dim Bultos As Integer = VaInt(row("Bultos"))
                    Dim KgNetos As Decimal = VaDec(row("KgNetos"))
                    Dim KgBrutos As Decimal = VaDec(row("KgBrutos"))



                    Dim CMR_Linea As New E_Cmr_lineas(Idusuario, cn)
                    CMR_Linea.CML_IdCmrlin.Valor = CMR_Linea.MaxId()
                    CMR_Linea.CML_Idcmr.Valor = IdCMR
                    CMR_Linea.CML_Idfamilia.Valor = IdFamilia
                    CMR_Linea.CML_idmarca.Valor = IdMarca
                    CMR_Linea.CML_idpalet.Valor = IdPalet
                    CMR_Linea.CML_envase.Valor = Envase
                    CMR_Linea.CML_palets.Valor = Palets
                    CMR_Linea.CML_PaletsTransporte.Valor = PaletsTransporte
                    CMR_Linea.CML_bultos.Valor = Bultos
                    CMR_Linea.CML_knetos.Valor = KgNetos
                    CMR_Linea.CML_kbrutos.Valor = KgBrutos
                    CMR_Linea.Insertar()

                Next

            End If



        End If




        Return IdCMR

    End Function



    Public Sub Agro_GeneraLineasAlbaran(ByVal idalbaran As String, ByVal Ccalidad As Boolean)
        ' genera las lineas de ventas desde la carga de palets.

        Dim albsalida_palets As New E_albsalida_palets(Idusuario, cn)
        Dim albsalida As New E_AlbSalida(Idusuario, cn)
        Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)
        Dim Clientes As New E_Clientes(Idusuario, cn)
        Dim Clientesdescargas As New E_ClientesDescargas(Idusuario, cn)
        Dim albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
        Dim dTL0 As New DataTable
        Dim ConservaPrecios As Boolean
        Dim palets As New E_palets(Idusuario, cn)
        Dim palets_lineas As New E_palets_lineas(Idusuario, cn)
        Dim Generoscompuestos As New E_GenerosCompuestos(Idusuario, cn)
        Dim CatSalidaComercial As New E_CatSalidaComercial(Idusuario, cn)
        Dim TiposPortes As New E_TiposPorte(Idusuario, cn)

        Dim sql As String
        Dim np As String = ""
        Dim palet As Integer
        Dim ValorCambio As Decimal = 0

        Dim Tknetos As Double = 0
        Dim Tbultos As Double = 0
        Dim Tpalets As Double = 0
        Dim Igenero As Double = 0
        Dim ImporteLinea As Double = 0
        Dim ImporteLineaEstimado As Double = 0


        DcPalets.Clear()
        acum.Borrar()





        If albsalida.LeerId(idalbaran) = False Then Exit Sub

        ValorCambio = VaDec(albsalida.ASA_valorcambio.Valor)
        If ValorCambio = 0 Then
            ValorCambio = 1
            albsalida.ASA_valorcambio.Valor = "1"
            albsalida.Actualizar()
        End If


        sql = "Select * from albsalida_lineas where ASL_idalbaran=" + idalbaran
        dTL0 = albsalida_lineas.MiConexion.ConsultaSQL(sql)
        ConservaPrecios = False
        If Not dTL0 Is Nothing Then
            If dTL0.Rows.Count > 0 Then
                If MsgBox("Albaran ya generado. ¿ Desea conservar los precios ?", vbYesNo) = vbYes Then
                    ConservaPrecios = True
                End If
            End If
        End If
        Dim consulta1 As New Cdatos.E_select

        consulta1.SelCampo(albsalida_palets.ASP_Idpalet)
        consulta1.SelCampo(palets.PAL_idtipopalet, "idtipopalet", albsalida_palets.ASP_Idpalet)
        consulta1.SelCampo(palets_lineas.PLL_idgenero, "idgenero", albsalida_palets.ASP_Idpalet, palets_lineas.PLL_idpalet)
        consulta1.SelCampo(palets_lineas.PLL_idtipoconfeccion, "idtipoconfeccion")
        consulta1.SelCampo(palets_lineas.PLL_idcategoria, "idcategoria")
        consulta1.SelCampo(palets_lineas.PLL_idmarca, "idmarca")
        consulta1.SelCampo(palets_lineas.PLL_categoria, "categoria")
        consulta1.SelCampo(palets_lineas.PLL_kilosbrutos, "kilosbrutos")
        consulta1.SelCampo(palets_lineas.PLL_kilosnetos, "kilosnetos")
        consulta1.SelCampo(palets_lineas.PLL_kiloscliente, "kiloscliente")
        consulta1.SelCampo(palets_lineas.PLL_bultos, "bultos")
        consulta1.SelCampo(palets_lineas.PLL_piezasxbulto, "piezasxbulto")
        consulta1.SelCampo(palets_lineas.PLL_costeestructura, "costeestructura")
        consulta1.SelCampo(palets_lineas.PLL_costeconfeccion, "costeconfeccion")
        consulta1.SelCampo(palets_lineas.PLL_costematerial, "costematerial")
        consulta1.SelCampo(palets_lineas.PLL_idgensal, "idgensal")
        consulta1.SelCampo(palets_lineas.PLL_idpedidolinea, "IdLineaPedido")
        consulta1.SelCampo(palets_lineas.PLL_CoeficientePalet, "CoeficientePalet")
        consulta1.SelCampo(palets_lineas.PLL_idlinea, "IdLineaPalet")

        consulta1.WheCampo(albsalida_palets.ASP_IdAlbaran, "=", idalbaran)

        sql = consulta1.SQL + " order by asp_idpalet"
        np = ""

        Dim dtp As DataTable = albsalida.MiConexion.ConsultaSQL(sql)

        For Each rwp In dtp.Rows

            If np <> rwp("asp_idpalet").ToString Then
                palet = 1
            Else
                palet = 0
            End If


            Dim IdLineaPalet As Integer = VaInt(rwp("IdLineaPalet"))


            Dim clave As stClave_lineasAlbaran = Acumular(palet, rwp("idgenero").ToString, rwp("idtipopalet").ToString, rwp("idtipoconfeccion").ToString, rwp("idcategoria").ToString, rwp("categoria").ToString, rwp("idmarca").ToString, rwp("idgensal").ToString, VaDec(rwp("kilosbrutos")), VaDec(rwp("kilosnetos")), VaDec(rwp("kiloscliente")), VaDec(rwp("bultos")), VaDec(rwp("piezasxbulto")), VaDec(rwp("costeestructura")), VaDec(rwp("costeconfeccion")), VaDec(rwp("costematerial")), VaInt(rwp("Bultos")), VaDec(rwp("coeficientepalet")))
            np = rwp("asp_idpalet").ToString

            DcPalets(IdLineaPalet) = clave


        Next

        ' generamos la tabla de ventaslineas 


        For Each clave As stClave_lineasAlbaran In acum.Dc.Keys
            Dim dato As stDatos_lineasAlbaran = acum.Dc(clave)
            Tknetos = Tknetos + dato.KilosNetos
            Tbultos = Tbultos + dato.Bultos
            Tpalets = Tpalets + dato.Palets

        Next




        If ConservaPrecios = False Then
            Dim OrigenDestino As String = "O"
            Dim IdTarifporte As Integer
            If TiposPortes.LeerId(albsalida.ASA_idtipoporte.Valor) = True Then
                OrigenDestino = TiposPortes.TPO_OrigenDestino.Valor
            End If
            If Clientesdescargas.LeerId(albsalida.ASA_iddomicilio.Valor) = True Then
                IdTarifporte = VaInt(Clientesdescargas.CLD_IdTarifaPortes.Valor)
            End If

            Agro_CopiarGastosCliente(idalbaran, albsalida.ASA_idcliente.Valor, albsalida.ASA_idcentro.Valor, ValorCambio, Tknetos, Tbultos, Tpalets, 0, OrigenDestino, IdTarifporte, VaInt(albsalida.ASA_idtransportista.Valor))

            dTL0 = Nothing
        End If
        sql = "Delete from albsalida_lineas where ASL_idalbaran=" + idalbaran
        cn.OrdenSql(sql)




        'sql = "select * from albsalida_gastos where ASG_idalbaran=" + idalbaran
        'Dim dtgastos As DataTable = albsalida.MiConexion.ConsultaSQL(sql)



        '        Dim dt As DataTable = acum.DataTable()
        For Each clave As stClave_lineasAlbaran In acum.Dc.Keys

            Dim dato As stDatos_lineasAlbaran = acum.Dc(clave)
            Dim id As String = albsalida_lineas.MaxId

            albsalida_lineas.VaciaEntidad()
            albsalida_lineas.ASL_idlinea.Valor = id
            albsalida_lineas.ASL_idalbaran.Valor = idalbaran
            albsalida_lineas.ASL_idgenero.Valor = clave.IdGenero.ToString
            albsalida_lineas.ASL_idtipoconfeccion.Valor = clave.IdConfecEnvase.ToString
            albsalida_lineas.ASL_idcategoria.Valor = clave.IdCategoria.ToString
            albsalida_lineas.ASL_idmarca.Valor = clave.IdMarca.ToString
            albsalida_lineas.ASL_idtipopalet.Valor = clave.idConfecPalet.ToString
            albsalida_lineas.ASL_categoria.Valor = clave.Categoria
            albsalida_lineas.ASL_kilosbrutos.Valor = dato.KilosBrutos.ToString
            albsalida_lineas.ASL_kilosnetos.Valor = dato.KilosNetos.ToString
            albsalida_lineas.ASL_kiloscliente.Valor = dato.KilosSalidos.ToString
            albsalida_lineas.ASL_palets.Valor = dato.Palets.ToString
            albsalida_lineas.ASL_bultos.Valor = dato.Bultos.ToString
            albsalida_lineas.ASL_piezas.Valor = dato.piezas.ToString
            albsalida_lineas.ASL_CoeficientePalet.Valor = dato.CoeficientePalet.ToString

            'If dTL0 Is Nothing Then
            '    albsalida_lineas.ASL_precio.Valor = "0"
            '    albsalida_lineas.ASL_tipoprecio.Valor = ""
            '    albsalida_lineas.ASL_importegenero.Valor = "0"
            'Else
            '    Dim Precio As Decimal = 0
            '    Dim PrecioEnvase As Decimal = 0
            '    Dim PrecioPalet As Decimal = 0
            '    Dim Tipoprecio As String = ""
            '    Dim PrecioEstimado As Decimal = 0

            '    PrecioLinea(dTL0, clave.IdGensal, clave.IdGenero, clave.IdConfecEnvase, clave.IdMarca, clave.IdCategoria, clave.Categoria, clave.idConfecPalet, Tipoprecio, Precio, PrecioEnvase, PrecioPalet, PrecioEstimado)
            '    ImporteLinea = 0
            '    ImporteLineaEstimado = 0
            '    If PrecioEstimado = 0 Then PrecioEstimado = Precio
            '    Select Case Tipoprecio
            '        Case "K"
            '            ImporteLinea = dato.KilosSalidos * Precio
            '            ImporteLineaEstimado = dato.KilosSalidos * PrecioEstimado
            '        Case "B"
            '            ImporteLinea = dato.Bultos * Precio
            '            ImporteLineaEstimado = dato.Bultos * PrecioEstimado
            '        Case "P"
            '            ImporteLinea = dato.piezas * Precio
            '            ImporteLineaEstimado = dato.piezas * PrecioEstimado

            '    End Select
            '    albsalida_lineas.ASL_precio.Valor = Precio.ToString
            '    albsalida_lineas.ASL_tipoprecio.Valor = Tipoprecio
            '    albsalida_lineas.ASL_importegenero.Valor = ImporteLinea
            '    albsalida_lineas.ASL_precioestimado.Valor = PrecioEstimado.ToString
            '    albsalida_lineas.ASL_importegeneroestimado.Valor = ImporteLineaEstimado.ToString
            '    albsalida_lineas.ASL_precioventa.Valor = PrecioEstimado.ToString
            '    albsalida_lineas.ASL_tipopreciovta.Valor = albsalida_lineas.ASL_tipoprecio.Valor
            '    albsalida_lineas.ASL_importegenerovta.Valor = ImporteLineaEstimado.ToString

            '    ' albsalida_lineas.ASL_precioventa.Valor = albsalida_lineas.ASL_precio.Valor
            '    'albsalida_lineas.ASL_importegenerovta.Valor = albsalida_lineas.ASL_importegenero.Valor

            'End If


            Dim Precio As Decimal = 0
            Dim PrecioEnvase As Decimal = 0
            Dim PrecioPalet As Decimal = 0
            Dim Tipoprecio As String = ""
            Dim Tipoprecioestimado As String = ""
            Dim PrecioEstimado As Decimal = 0


            If dTL0 Is Nothing Then
                PrecioLineaPedido(albsalida.ASA_idpedido.Valor, clave.IdGensal, clave.IdCategoria, clave.IdMarca, clave.idConfecPalet, Tipoprecio, Precio, PrecioEnvase, PrecioPalet, PrecioEstimado, albsalida.ASA_idcliente.Valor, Tipoprecioestimado)
            Else
                PrecioLinea(dTL0, clave.IdGensal, clave.IdGenero, clave.IdConfecEnvase, clave.IdMarca, clave.IdCategoria, clave.Categoria, clave.idConfecPalet, Tipoprecio, Precio, PrecioEnvase, PrecioPalet, PrecioEstimado, Tipoprecioestimado)
            End If


            ImporteLinea = 0
            ImporteLineaEstimado = 0
            If PrecioEstimado = 0 Then PrecioEstimado = Precio
            Select Case Tipoprecio
                Case "K"
                    ImporteLinea = dato.KilosSalidos * Precio
                Case "B"
                    ImporteLinea = dato.Bultos * Precio
                Case "P"
                    ImporteLinea = dato.piezas * Precio

            End Select

            Select Case Tipoprecioestimado
                Case "K"
                    ImporteLineaEstimado = dato.KilosSalidos * PrecioEstimado
                Case "B"
                    ImporteLineaEstimado = dato.Bultos * PrecioEstimado
                Case "P"
                    ImporteLineaEstimado = dato.piezas * PrecioEstimado
            End Select

            albsalida_lineas.ASL_precio.Valor = Precio.ToString
            albsalida_lineas.ASL_tipoprecio.Valor = Tipoprecio
            albsalida_lineas.ASL_tipoprecioestimado.Valor = Tipoprecioestimado
            albsalida_lineas.ASL_importegenero.Valor = ImporteLinea
            albsalida_lineas.ASL_precioestimado.Valor = PrecioEstimado.ToString
            albsalida_lineas.ASL_importegeneroestimado.Valor = ImporteLineaEstimado.ToString
            albsalida_lineas.ASL_precioventa.Valor = PrecioEstimado.ToString
            albsalida_lineas.ASL_tipopreciovta.Valor = albsalida_lineas.ASL_tipoprecio.Valor
            albsalida_lineas.ASL_importegenerovta.Valor = ImporteLineaEstimado.ToString

            albsalida_lineas.ASL_bultosvendidos.Valor = albsalida_lineas.ASL_bultos.Valor
            albsalida_lineas.ASL_kilosvendidos.Valor = albsalida_lineas.ASL_kiloscliente.Valor
            albsalida_lineas.ASL_paletsvendidos.Valor = albsalida_lineas.ASL_palets.Valor
            albsalida_lineas.ASL_piezasvendidas.Valor = albsalida_lineas.ASL_piezas.Valor
            albsalida_lineas.ASL_idgensal.Valor = clave.IdGensal.ToString

            albsalida_lineas.ASL_estructura.Valor = dato.CosteEstructura.ToString
            albsalida_lineas.ASL_manipulacion.Valor = dato.CosteConfeccion.ToString
            albsalida_lineas.ASL_materiales.Valor = dato.CosteMaterial.ToString


            albsalida_lineas.Insertar()


            AsociarLineasPaletASalidas(id, clave)

        Next



        Agro_CalculoGastosTotalesAlbaran(idalbaran, ValorCambio)


    End Sub



    Public Sub PrecioLinea(ByVal dt As DataTable, ByVal idgensal As Integer, ByVal idgenero As Integer, ByVal idconfec As Integer, ByVal idmarca As Integer, ByVal idcate As Integer, ByVal cate As String, ByVal idtipopal As Integer, ByRef Tipoprecio As String, ByRef precio As Decimal, ByRef PrecioEnvase As Decimal, ByRef PrecioPalet As Decimal, ByRef PrecioEstimado As Decimal, ByRef TipoPrecioEstimado As String)

        Tipoprecio = ""
        TipoPrecioEstimado = ""
        precio = 0
        PrecioEnvase = 0
        PrecioPalet = 0


        For Each rw In dt.Rows

            If idgenero = VaInt(rw("ASL_IDGENERO")) And _
                idconfec = VaInt(rw("ASL_IDTIPOCONFECCION")) And _
                idmarca = VaInt(rw("ASL_IDMARCA")) And _
                idcate = VaInt(rw("ASL_IDCATEGORIA")) And _
                cate = rw("ASL_CATEGORIA").ToString And _
                idgensal = VaInt(rw("ASL_IDGENSAL")) And _
                idtipopal = VaInt(rw("ASL_IDTIPOPALET")) Then


                Tipoprecio = rw("ASL_TIPOPRECIO").ToString
                precio = VaDec(rw("ASL_PRECIO"))
                PrecioEstimado = VaDec(rw("ASL_PRECIOESTIMADO"))
                TipoPrecioEstimado = rw("ASL_TIPOPRECIOESTIMADO").ToString
                Exit Sub

            End If

        Next



    End Sub


    Public Sub PrecioLineaPedido(ByVal IdPedido As String, ByVal IdGenSal As Integer, ByVal IdCateg As Integer, ByVal IdMarca As Integer, ByVal IdTipoPalet As Integer,
                                  ByRef Tipoprecio As String, ByRef precio As Decimal, ByRef PrecioEnvase As Decimal, ByRef PrecioPalet As Decimal, ByRef PrecioEstimado As Decimal,
                                  ByVal IdCliente As String, ByRef tipoprecioestimado As String)


        Tipoprecio = ""
        tipoprecioestimado = ""
        precio = 0
        PrecioEnvase = 0
        PrecioPalet = 0

        If VaInt(IdPedido) > 0 Then

            Dim Pedidos As New E_Pedidos(Idusuario, cn)

            Dim sql As String = "SELECT * FROM Pedidos_Lineas WHERE PEL_IdPedido = " & IdPedido
            Dim dt As DataTable = Pedidos.MiConexion.ConsultaSQL(sql)


            Dim DcCategorias As New Dictionary(Of Integer, Integer)


            For Each rw In dt.Rows

                DcCategorias.Clear()


                sql = "Select CSC_idcatcomercial as id from CatSalidaComercial where CSC_idCatSalida=" & IdCateg
                Dim dt2 As DataTable = Pedidos.MiConexion.ConsultaSQL(sql)
                If Not dt2 Is Nothing Then
                    For Each row2 As DataRow In dt2.Rows
                        Dim id As Integer = VaInt(row2("id"))
                        DcCategorias(id) = id
                    Next
                End If


                'If IdGenSal = VaInt(rw("PEL_IDGENSAL")) And IdMarca = VaInt(rw("PEL_IDMARCA")) And IdCateg = VaInt(rw("PEL_IDCATEGORIA")) Then
                If IdGenSal = VaInt(rw("PEL_IDGENSAL")) And IdMarca = VaInt(rw("PEL_IDMARCA")) And DcCategorias.ContainsKey(VaInt(rw("PEL_IDCATEGORIA"))) Then
                    'And Categ = rw("PEL_NOMCATE").ToString And
                    'IdTipoPalet = VaInt(rw("PEL_IDTIPOPALET")) Then

                    Tipoprecio = rw("PEL_TIPOPRECIO").ToString
                    tipoprecioestimado = Tipoprecio
                    'Tipoprecio = tipoprecioestimado
                    precio = VaDec(rw("PEL_PRECIO"))
                    PrecioEstimado = VaDec(rw("PEL_PRECIO"))
                    Exit Sub

                End If
            Next

        End If


        'Si no encuentra el tipo de precio en el pedido, coger el que tiene el cliente por defecto
        If Tipoprecio.Trim = "" Then
            If VaInt(IdCliente) > 0 Then

                Dim Cliente As New E_Clientes(Idusuario, cn)
                If Cliente.LeerId(IdCliente) Then
                    Tipoprecio = (Cliente.CLI_KB.Valor).Trim.ToUpper
                End If

            End If
        End If

    End Sub



    Private Function Acumular(ByVal Npalets As Integer, ByVal genero As String, ByVal tipopalet As String, ByVal tipoconfeccion As String, ByVal idcat As String, ByVal categoria As String, ByVal marca As String,
                         ByVal idgensal As String, ByVal kilosbrutos As Double, ByVal kilosnetos As Double, ByVal kiloscliente As Double, ByVal bultos As Double, ByVal piezasxbulto As Double,
                         ByVal CosteEstructura As Double, ByVal CosteManipulacion As Double, ByVal CosteMaterial As Double, ByVal BultosxPalet As Integer, ByVal CoeficientePalet As Decimal) As stClave_lineasAlbaran

        'Dim clave As New stClave_lineasAlbaran(VaInt(genero), VaInt(tipoconfeccion), VaInt(idcat), 0, categoria, VaInt(marca), VaInt(idgensal), BultosxPalet)
        Dim clave As New stClave_lineasAlbaran(VaInt(genero), VaInt(tipoconfeccion), VaInt(idcat), tipopalet, categoria, VaInt(marca), VaInt(idgensal), BultosxPalet)
        Dim datos As New stDatos_lineasAlbaran(Npalets, bultos, kilosnetos, kilosbrutos, kiloscliente, piezasxbulto * bultos, CosteEstructura, CosteManipulacion, CosteMaterial, CoeficientePalet)
        acum.Suma(clave, datos)

        Return clave

    End Function



    Public Sub Agro_CopiarGastosCliente(ByVal idalbaran As String, ByVal idcliente As String, ByVal idcentro As String, ByVal ValorCambio As Double, ByVal Tk As Double, ByVal Tb As Double, ByVal Tp As Double, ByVal Ti As Double, OrigenDestino As String, IdTarifaporte As Integer, IdTransportista As Integer)

        Dim consulta As New Cdatos.E_select
        Dim GastosClientes As New E_GastosClientes(Idusuario, cn)
        Dim gastoscomercio As New E_GastosComercio(Idusuario, cn)
        Dim Albsalida_gastos As New E_albsalida_gastos(Idusuario, cn)
        Dim Tarifaportes As New E_TarifaPortes(Idusuario, cn)
        Dim ClientesDescarga As New E_ClientesDescargas(Idusuario, cn)

        Dim i As Double = 0

        Dim Sql As String = "Delete from albsalida_gastos where ASG_idalbaran=" + idalbaran
        cn.OrdenSql(Sql)


        consulta.SelCampo(GastosClientes.GCL_IdGasto, "IdGasto")
        consulta.SelCampo(GastosClientes.GCL_ValorGasto, "ValorGasto")
        consulta.SelCampo(GastosClientes.GCL_TipoAFC, "Tipofc")
        consulta.SelCampo(gastoscomercio.GCO_Tipobkp, "Tipobkp", GastosClientes.GCL_IdGasto)
        consulta.SelCampo(GastosClientes.GCL_IdAcreedor, "idacreedor")
        consulta.WheCampo(GastosClientes.GCL_IdCliente, "=", idcliente)

        consulta.WheCampo(GastosClientes.GCL_TipoAFC, "<>", "A")
        Dim dt As DataTable = GastosClientes.MiConexion.ConsultaSQL(consulta.SQL)

        If Not dt Is Nothing Then
            For Each rw In dt.Rows

                'If VaDec(rw("valorgasto")) <> 0 Then

                Dim id As String = Albsalida_gastos.MaxId
                Albsalida_gastos.VaciaEntidad()
                Albsalida_gastos.ASG_id.Valor = id
                Albsalida_gastos.ASG_idgasto.Valor = rw("idgasto").ToString
                Albsalida_gastos.ASG_valorgasto.Valor = rw("valorgasto").ToString

                Albsalida_gastos.ASG_idalbaran.Valor = idalbaran
                Albsalida_gastos.ASG_tipofc.Valor = rw("tipofc").ToString
                Albsalida_gastos.ASG_tipokbp.Valor = rw("tipobkp").ToString
                i = VaDec(rw("valorgasto"))
                Select Case rw("tipobkp").ToString
                    Case "B"
                        i = i * Tb
                    Case "P"
                        i = i * Tp
                    Case "%"
                        i = Ti * i / 100
                    Case "K"
                        i = i * Tk
                End Select
                Albsalida_gastos.ASG_importegastoeuros.Valor = (i * ValorCambio).ToString
                If rw("tipofc").ToString = "C" Then
                    Albsalida_gastos.ASG_importegastodivisa.Valor = (i / ValorCambio).ToString ' si el gasto es comercial divido el importe por la divisa
                Else
                    Albsalida_gastos.ASG_importegastodivisa.Valor = (i.ToString)

                End If
                If VaInt(rw("idacreedor")) > 0 Then
                    Albsalida_gastos.ASG_idacreedor.Valor = rw("idacreedor").ToString
                Else
                    Albsalida_gastos.ASG_idacreedor.Valor = ""
                End If
                Albsalida_gastos.Insertar()

                'End If


            Next
        End If

        If OrigenDestino = "O" And IdTarifaporte > 0 Then
            Agro_GeneraGastodePorte(idalbaran, IdTarifaporte, Tb, Tk, Tp, ValorCambio, IdTransportista)

        End If

    End Sub

    Public Sub Agro_GeneraGastodePorte(idalbaran As String, idtarifa As Integer, tb As Double, tk As Double, tp As Double, ValorCambio As Decimal, idtransportista As Integer)

        Dim AlbSalida_palets As New E_albsalida_palets(Idusuario, cn)
        Dim Palets As New E_palets(Idusuario, cn)
        Dim Confecpalet As New E_ConfecPalet(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)
        Dim Medidaspalet As New E_MedidasPalet(Idusuario, cn)
        Dim TarifaPortes As New E_TarifaPortes(Idusuario, cn)
        Dim Albsalida_Gastos As New E_albsalida_gastos(Idusuario, cn)
        Dim GastosComercio As New E_GastosComercio(Idusuario, cn)
        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
        Dim Pedidos As New E_Pedidos(Idusuario, cn)


        Dim sql As String
        Dim consulta As New Cdatos.E_select


        'Usar el campo CPA_Coeficiente
        consulta.SelCampo(AlbSalida_palets.ASP_IdAlbaran, "idalbaran")
        consulta.SelCampo(Palets.PAL_idtipopalet, "idtipopalet", AlbSalida_palets.ASP_Idpalet)
        consulta.SelCampo(Confecpalet.CPA_IdPalet, "idpalet", Palets.PAL_idtipopalet)
        consulta.SelCampo(Envases.ENV_idmedida, "idmedida", Confecpalet.CPA_IdPalet)
        consulta.SelCampo(Confecpalet.CPA_Coeficiente, "Coeficiente")
        consulta.SelCampo(AlbSalida.ASA_idpedido, "IdPedido", AlbSalida_palets.ASP_IdAlbaran, AlbSalida.ASA_idalbaran)
        consulta.SelCampo(Pedidos.PED_TransporteRapidoSN, "TransporteRapido", AlbSalida.ASA_idpedido, Pedidos.PED_idpedido)
        consulta.WheCampo(AlbSalida_palets.ASP_IdAlbaran, "=", idalbaran)


        'ASA_IdPedido

        sql = consulta.SQL


        Dim bTransporteRapido As Boolean = False


        Dim dt As DataTable = Palets.MiConexion.ConsultaSQL(sql)
        Dim Dc As New Dictionary(Of Integer, Decimal)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows

                Dim medida As Integer = VaInt(rw("idmedida"))
                Dim coeficiente As Decimal = VaDec(rw("Coeficiente"))
                Dim TransporteRapido As String = (rw("TransporteRapido").ToString & "").Trim

                bTransporteRapido = (TransporteRapido = "S")

                If Dc.ContainsKey(medida) = False Then
                    'Dc.Add(medida, 1)
                    Dc.Add(medida, coeficiente)
                Else
                    'Dc(medida) = Dc(medida) + 1
                    Dc(medida) = Dc(medida) + coeficiente
                End If
            Next
        End If

        Dim gastoporte As Decimal = 0

        If TarifaPortes.LeerId(idtarifa.ToString) = True Then

            gastoporte = VaDec(TarifaPortes.TPV_PrecioEnvio.Valor)

            For Each m As Integer In Dc.Keys

                Dim Precio1 As Decimal = VaDec(TarifaPortes.TPV_Precio1.Valor)
                Dim Precio2 As Decimal = VaDec(TarifaPortes.TPV_Precio2.Valor)
                Dim Precio3 As Decimal = VaDec(TarifaPortes.TPV_Precio3.Valor)
                Dim Precio4 As Decimal = VaDec(TarifaPortes.TPV_Precio4.Valor)
                'Dim Precio5 As Decimal = VaDec(TarifaPortes.TPV_Precio5.Valor)


                Select Case m
                    Case 1
                        If bTransporteRapido And Precio3 <> 0 Then
                            gastoporte = gastoporte + Dc(m) * Precio3
                        Else
                            gastoporte = gastoporte + Dc(m) * Precio1
                        End If
                    Case 2
                        If bTransporteRapido And Precio4 <> 0 Then
                            gastoporte = gastoporte + Dc(m) * Precio4
                        Else
                            gastoporte = gastoporte + Dc(m) * Precio2
                        End If
                        'Case 3
                        '    gastoporte = gastoporte + Dc(m) * Precio3
                        'Case 4
                        '    gastoporte = gastoporte + Dc(m) * Precio4
                        'Case 5
                        '    gastoporte = gastoporte + Dc(m) * Precio5
                End Select

            Next

        End If


        '        If gastoporte <> 0 Then
        Dim tipogasto As String = "P"
        Dim tipofc As String = "C"
        Dim acreedor As String = idtransportista

        'If GastosComercio.LeerId(TarifaPortes.TPV_idgasto.Valor) = True Then
        '    tipogasto = "P" ' GastosComercio.GCO_Tipobkp.Valor
        '    tipofc = "C" 'GastosComercio.GCO_Tipogastofc.Valor
        '    acreedor = idtransportista
        'End If


        Dim id As String = Albsalida_Gastos.MaxId
        Albsalida_Gastos.VaciaEntidad()
        Albsalida_Gastos.ASG_id.Valor = id
        Albsalida_Gastos.ASG_idgasto.Valor = TarifaPortes.TPV_idgasto.Valor
        Dim vGASTO As Decimal = 0



        If vGASTO = 0 Then
            If tp <> 0 Then
                vGASTO = gastoporte / tp
            ElseIf tb <> 0 Then
                vGASTO = gastoporte / tb
            ElseIf tk <> 0 Then
                vGASTO = gastoporte / tk
            End If
        End If

        ' If vGASTO <> 0 Then
        Albsalida_Gastos.ASG_valorgasto.Valor = vGASTO.ToString

        Albsalida_Gastos.ASG_idalbaran.Valor = idalbaran
        Albsalida_Gastos.ASG_tipofc.Valor = tipofc
        Albsalida_Gastos.ASG_tipokbp.Valor = tipogasto
        Albsalida_Gastos.ASG_importegastoeuros.Valor = (gastoporte * ValorCambio).ToString
        If tipofc = "C" Then
            Albsalida_Gastos.ASG_importegastodivisa.Valor = (gastoporte / ValorCambio).ToString ' si el gasto es comercial divido el importe por la divisa
        Else
            Albsalida_Gastos.ASG_importegastodivisa.Valor = (gastoporte.ToString)

        End If
        If VaInt(acreedor) > 0 Then
            Albsalida_Gastos.ASG_idacreedor.Valor = acreedor
        Else
            Albsalida_Gastos.ASG_idacreedor.Valor = ""
        End If
        Albsalida_Gastos.Insertar()



        'End If

    End Sub


    Public Sub Agro_CalculoGastosTotalesAlbaran(ByVal idalbaran As String, ByVal ValorCambio As Double)
        Dim consulta As New Cdatos.E_select
        Dim Albsalida_gastos As New E_albsalida_gastos(Idusuario, cn)
        Dim GastosComercio As New E_GastosComercio(Idusuario, cn)
        Dim OrigenGastos As New E_OrigenGastos(Idusuario, cn)
        Dim i As Double = 0
        Dim tb As Double = 0
        Dim tp As Double = 0
        Dim ti As Double = 0
        Dim tk As Double = 0
        Dim tc As Decimal = 0
        Dim sql As String

        Dim GastoF As Double = 0
        Dim GastoC As Double = 0
        Dim GastoP As Double = 0


        Dim C_kilos As Double = 0
        Dim C_bultos As Double = 0
        Dim C_palets As Double = 0
        Dim C_porcen As Double = 0
        Dim C_fijo As Double = 0

        Dim F_kilos As Double = 0
        Dim F_bultos As Double = 0
        Dim F_palets As Double = 0
        Dim F_porcen As Double = 0
        Dim F_fijo As Double = 0


        Dim P_kilos As Double = 0
        Dim P_bultos As Double = 0
        Dim P_palets As Double = 0
        Dim P_porcen As Double = 0
        Dim P_fijo As Double = 0


        sql = "Select sum(ASL_kilosvendidos) as kilos, " & vbCrLf
        sql = sql + " sum(ASL_paletsvendidos) as palets, " & vbCrLf
        sql = sql + " sum(ASL_bultosvendidos) as bultos, " & vbCrLf
        sql = sql + " sum(ASL_importegenerovta) as igenero, " & vbCrLf
        sql = sql + " sum(ASL_paletsvendidos * CPA_Coeficiente) as Coeficiente," & vbCrLf
        sql = sql + " CPA_Coeficiente as TipoCoeficiente" & vbCrLf
        sql = sql + " from albsalida_lineas" & vbCrLf
        sql = sql + " left join confecpalet on CPA_Idconfec = ASL_idtipopalet" & vbCrLf
        sql = sql + " where ASL_idalbaran=" + idalbaran & vbCrLf
        sql = sql + " group by CPA_Coeficiente" & vbCrLf


        Dim dtk As DataTable = Albsalida_gastos.MiConexion.ConsultaSQL(sql)
        If Not dtk Is Nothing Then

            'If dtk.Rows.Count > 0 Then
            For Each row As DataRow In dtk.Rows

                tk = tk + VaDec(row("kilos"))
                tb = tb + VaDec(row("bultos"))
                tp = tp + VaDec(row("palets"))
                ti = ti + VaDec(row("igenero"))
                tc = tc + VaDec(row("Coeficiente"))

            Next
            'End If

        End If


        'Si la suma de los coeficientes es distinta a la de los palets, se trata de un "palet mixto virtual", así que el gasto hay que recalcularlo por kilo
        Dim PorteKilo As Boolean = False
        If tc <> tp Then
            PorteKilo = True
        End If



        consulta.SelCampo(Albsalida_gastos.ASG_id, "id")
        consulta.SelCampo(Albsalida_gastos.ASG_idgasto, "IdGasto")
        consulta.SelCampo(Albsalida_gastos.ASG_valorgasto, "ValorGasto")
        consulta.SelCampo(Albsalida_gastos.ASG_tipofc, "Tipofc")
        consulta.SelCampo(Albsalida_gastos.ASG_tipokbp, "Tipobkp")
        consulta.SelCampo(Albsalida_gastos.ASG_importegastodivisa, "importegastodivisa")
        consulta.SelCampo(GastosComercio.GCO_idgrupo, "idgrupo", Albsalida_gastos.ASG_idgasto)
        consulta.SelCampo(OrigenGastos.ORG_tipo, "origen", GastosComercio.GCO_idgrupo)

        consulta.WheCampo(Albsalida_gastos.ASG_idalbaran, "=", idalbaran)
        Dim dt As DataTable = Albsalida_gastos.MiConexion.ConsultaSQL(consulta.SQL)


        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                i = VaDec(rw("valorgasto"))
                Dim origen As String = rw("origen").ToString
                Select Case rw("tipobkp")
                    Case "B"
                        If origen = "PV" Then
                            P_bultos = P_bultos + i
                        Else
                            If rw("TIPOFC").ToString = "F" Then
                                F_bultos = F_bultos + i
                            Else
                                C_bultos = C_bultos + i
                            End If
                        End If
                        i = i * tb
                    Case "P"
                        If origen = "PV" Then
                            If PorteKilo = False Or tk = 0 Then
                                P_palets = P_palets + i
                            Else
                                'Recalculamos el gasto a kilos
                                Dim tgasto As Decimal
                                Dim gkilo As Decimal
                                'tgasto = i * tc
                                tgasto = i * tp
                                gkilo = tgasto / tk
                                P_kilos = P_kilos + gkilo
                            End If
                        Else

                            If rw("TIPOFC").ToString = "F" Then
                                F_palets = F_palets + i
                            Else
                                C_palets = C_palets + i
                            End If
                        End If
                        i = i * tp



                    Case "%"
                        If origen = "PV" Then
                            P_porcen = P_porcen + i
                        Else
                            If rw("TIPOFC").ToString = "F" Then
                                F_porcen = F_porcen + i
                            Else
                                C_porcen = C_porcen + i
                            End If

                        End If
                        i = ti * i / 100
                    Case "K"
                        If origen = "PV" Then
                            P_kilos = P_kilos + i
                        Else
                            If rw("TIPOFC").ToString = "F" Then
                                F_kilos = F_kilos + i
                            Else
                                C_kilos = C_kilos + i
                            End If

                        End If
                        i = i * tk

                    Case "I"
                        If origen = "PV" Then
                            P_fijo = P_fijo + i

                        Else

                            If rw("TIPOFC").ToString = "F" Then
                                F_fijo = F_fijo + i
                            Else
                                C_fijo = C_fijo + i
                            End If

                        End If

                End Select


                ' If i <> VaDec(rw("importegastodivisa")) Then
                If Albsalida_gastos.LeerId(rw("id")) = True Then
                    If origen = "PV" Then ' SIEMPRE ES COMERCIAL
                        GastoP = GastoP + i
                        Albsalida_gastos.ASG_importegastoeuros.Valor = (i).ToString
                        Albsalida_gastos.ASG_importegastodivisa.Valor = (i / ValorCambio).ToString ' si el gasto es comercial divido el importe por la divisa

                    Else
                        If Albsalida_gastos.ASG_tipofc.Valor = "F" Then
                            GastoF = GastoF + i * ValorCambio

                        Else
                            GastoC = GastoC + i
                        End If

                        If rw("tipofc").ToString = "C" Then
                            Albsalida_gastos.ASG_importegastoeuros.Valor = (i).ToString
                            Albsalida_gastos.ASG_importegastodivisa.Valor = (i / ValorCambio).ToString ' si el gasto es comercial divido el importe por la divisa
                        Else
                            Albsalida_gastos.ASG_importegastoeuros.Valor = (i * ValorCambio).ToString
                            Albsalida_gastos.ASG_importegastodivisa.Valor = (i.ToString)
                        End If

                    End If

                    Albsalida_gastos.Actualizar()
                End If
                'End If
            Next
        End If

        ' REPARTO EL IMPORTE FIJO COMO COEFICIENTE
        If tk <> 0 Then
            C_kilos = C_kilos + C_fijo / tk
            F_kilos = F_kilos + F_fijo / tk
            P_kilos = P_kilos + P_fijo / tk
        ElseIf tb <> 0 Then
            C_bultos = C_bultos + C_fijo / tb
            F_bultos = F_bultos + F_fijo / tb
            P_bultos = P_bultos + P_fijo / tb
        ElseIf tp <> 0 Then
            C_palets = C_palets + C_fijo / tp
            F_palets = F_palets + F_fijo / tp
            P_palets = P_palets + P_fijo / tp
        ElseIf ti <> 0 Then
            C_porcen = C_porcen + C_fijo / ti * 100
            F_porcen = F_porcen + F_fijo / ti * 100
            P_porcen = P_porcen + P_fijo / ti * 100

        End If

        ' CALCULO EL GASTO COMERCIAL Y EL DE FACTURA POR LINEA DE SALIDA EN FUNCION DE LOS KILOS, BULTOS , PALETS ,IMPORTE .. DE CADA LINEA


        Dim Gf As Double = 0
        Dim Gc As Double = 0
        Dim Gporte As Double = 0
        sql = "Select ASL_idlinea as idlinea,ASL_kilosnetos as kilosnetos, "
        sql = sql + " ASL_kilosvendidos as kilosvendidos, "
        sql = sql + " ASL_bultos as bultos, "
        sql = sql + " ASL_bultosvendidos as bultosvendidos, "
        sql = sql + " ASL_coeficientepalet as palets, "
        sql = sql + " ASL_paletsvendidos as paletsvendidos, "
        sql = sql + " ASL_importegenerovta as importegenerovta"
        sql = sql + " from albsalida_lineas where ASL_idalbaran=" + idalbaran + " order by kilosvendidos"
        Dim dtl As DataTable = Albsalida_gastos.MiConexion.ConsultaSQL(sql)
        If Not dtl Is Nothing Then
            Dim l As Integer = 0
            Dim lf As Double = 0
            Dim lc As Double = 0
            Dim lp As Double = 0





            For Each rwl In dtl.Rows

                l = l + 1

                If l < dtl.Rows.Count Then

                    Gf = VaDec(rwl("kilosvendidos")) * F_kilos + VaDec(rwl("bultosvendidos")) * F_bultos + VaDec(rwl("paletsvendidos")) * F_palets + VaDec(rwl("importegenerovta")) * F_porcen / 100
                    Gf = Gf * ValorCambio


                    Gc = VaDec(rwl("kilosnetos")) * C_kilos + VaDec(rwl("bultos")) * C_bultos + VaDec(rwl("palets")) * C_palets + VaDec(rwl("importegenerovta")) * C_porcen / 100

                    Gporte = VaDec(rwl("kilosnetos")) * P_kilos + VaDec(rwl("bultos")) * P_bultos + VaDec(rwl("palets")) * P_palets + VaDec(rwl("importegenerovta")) * P_porcen / 100

                    Gf = Math.Round(Gf, 2)
                    Gc = Math.Round(Gc, 2)
                    Gporte = Math.Round(Gporte, 2)
                    ActualizalineaGasto(rwl("idlinea").ToString, Gf, Gc, Gporte)

                    lf = lf + Gf
                    lc = lc + Gc
                    lp = lp + Gporte
                Else
                    ActualizalineaGasto(rwl("idlinea").ToString, GastoF - lf, GastoC - lc, GastoP - lp) ' en la ultima le aplico la diferencia

                End If


            Next
        End If



    End Sub



    Private Class stClaves_LineasAlb

        Public Idgenero As Integer = 0
        Public Idcategoria As Integer = 0


        Public Sub New(Idgenero As Integer, Idcategoria As Integer)

            Me.Idgenero = Idgenero
            Me.Idcategoria = Idcategoria

        End Sub

    End Class


    Private Class stDatos_LineasAlb

        Public Kilos As Integer = 0
        Public Iventa As Decimal = 0
        Public GastosV As Decimal = 0
        Public GastosO As Decimal = 0


        Public Sub New(Kilos As Integer, Iventa As Decimal, GastosV As Decimal, GastosO As Decimal)

            Me.Kilos = Kilos
            Me.Iventa = Iventa
            Me.GastosV = GastosV
            Me.GastosO = GastosO


        End Sub

    End Class


    Public Function Agro_AlbSalidaGastos(idalbsalida As Integer) As DataTable

        Dim acum As New Acumulador
        ' devuelve un datatable con el importe del albaran y los gastos aplicados por linea

        Dim dt As New DataTable
        Dim Albsalida As New E_AlbSalida(Idusuario, cn)
        Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
        Dim Cat As New E_CategoriasSalida(Idusuario, cn)
        Dim valorcambio As Decimal = 0






        If Albsalida.LeerId(idalbsalida.ToString) = True Then
            valorcambio = VaDec(Albsalida.ASA_valorcambio.Valor)
        End If

        If valorcambio = 0 Then
            valorcambio = 1
        End If

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Albsalida_lineas.ASL_idgenero, "idgenero")
        consulta.SelCampo(Cat.CAS_IdCategoriaEntrada, "idcategoria", Albsalida_lineas.ASL_idcategoria)
        consulta.SelCampo(Albsalida_lineas.ASL_kilosnetos, "kilos")
        consulta.SelCampo(Albsalida_lineas.ASL_importegenerovta, "importe")
        consulta.SelCampo(Albsalida_lineas.ASL_gastoF, "gastof")
        consulta.SelCampo(Albsalida_lineas.ASL_gastoC, "gastoc")
        consulta.SelCampo(Albsalida_lineas.ASL_estructura, "estructura")
        consulta.SelCampo(Albsalida_lineas.ASL_manipulacion, "manipulacion")
        consulta.SelCampo(Albsalida_lineas.ASL_materiales, "materiales")

        consulta.WheCampo(Albsalida_lineas.ASL_idalbaran, "=", idalbsalida)
        Dim dtl As DataTable = Albsalida_lineas.MiConexion.ConsultaSQL(consulta.SQL)
        If Not dtl Is Nothing Then
            For Each rw In dtl.Rows
                Dim idgenero As Integer = VaInt(rw("idgenero"))
                Dim idcat As Integer = VaInt(rw("idcagegoria"))
                Dim iventa As Decimal = VaDec(rw("importe")) * valorcambio
                Dim kilos As Decimal = VaDec(rw("kilos"))
                Dim gastov As Decimal = VaDec(rw("gastof")) + VaDec(rw("gastoc"))
                Dim gastoo As Decimal = VaDec(rw("estructura")) + VaDec(rw("manipulacion")) + VaDec(rw("materiales"))


                Dim stclaves As New stClaves_LineasAlb(idgenero, idcat)
                Dim stdatos As New stDatos_LineasAlb(kilos, iventa, gastov, gastoo)
            Next
        End If

        Return dt

    End Function


    Private Sub ActualizalineaGasto(ByVal idlinea As String, ByVal GastoF As Double, ByVal gastoc As Double, ByVal GastoPorte As Double)
        Dim albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
        Dim gf As String = albsalida_lineas.SqlCampo(GastoF.ToString, Cdatos.TiposCampo.Importe)
        Dim gc As String = albsalida_lineas.SqlCampo(gastoc.ToString, Cdatos.TiposCampo.Importe)
        Dim gporte As String = albsalida_lineas.SqlCampo(GastoPorte.ToString, Cdatos.TiposCampo.Importe)
        Dim sql As String = "Update albsalida_lineas set ASL_GASTOF=" + gf + ", ASL_GASTOC=" + gc + ", ASL_GASTOPORTE=" + GPORTE + " WHERE ASL_IDLINEA=" + idlinea
        albsalida_lineas.MiConexion.OrdenSql(sql)

    End Sub




    Public Sub AGRO_ActualizaGastosOrigenAlbaran(idalbaran As String, GrabaCosteConfeccion As Boolean, IdSemana As Integer)
        ' recalcular los gastos de origen del albaran y los palets asociados segun los precios ACTUALES de los materiales,confeccion y estructura

        Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
        Dim Palets As New E_palets(Idusuario, cn)
        Dim Palets_lineas As New E_palets_lineas(Idusuario, cn)
        Dim Albsalida_palets As New E_albsalida_palets(Idusuario, cn)
        Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
        Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)


        Dim consulta1 As New Cdatos.E_select
        consulta1.SelCampo(Albsalida_lineas.ASL_idlinea, "idlinea")
        consulta1.SelCampo(Albsalida_lineas.ASL_idgensal, "idgensal")
        consulta1.SelCampo(Albsalida_lineas.ASL_idmarca, "idmarca")
        consulta1.SelCampo(Albsalida_lineas.ASL_idcategoria, "idcategoria")
        consulta1.SelCampo(Albsalida_lineas.ASL_categoria, "categoria")
        consulta1.SelCampo(Albsalida_lineas.ASL_bultos, "bultos")
        consulta1.SelCampo(Albsalida_lineas.ASL_palets, "palets")
        consulta1.SelCampo(Albsalida_lineas.ASL_idtipopalet, "IdTipoPalet")

        consulta1.WheCampo(Albsalida_lineas.ASL_idalbaran, "=", idalbaran)
        Dim dt1 As DataTable = Albsalida_lineas.MiConexion.ConsultaSQL(consulta1.SQL)
        If Not dt1 Is Nothing Then

            For Each rw1 In dt1.Rows


                Dim Bxp As Integer = 0
                Dim nb As Integer = VaInt(rw1("bultos"))
                Dim np As Integer = VaInt(rw1("palets"))
                If np > 0 Then
                    Bxp = nb / np
                Else
                    Bxp = nb
                End If

                Dim IdLineaSalida As String = (rw1("IdLinea").ToString & "").Trim

                Dim consulta2 As New Cdatos.E_select
                consulta2.SelCampo(Albsalida_palets.ASP_Idpalet, "idpalet")
                consulta2.SelCampo(Palets_lineas.PLL_idlinea, "idlinea", Albsalida_palets.ASP_Idpalet, Palets_lineas.PLL_idpalet)
                'consulta2.SelCampo(Palets_lineas.PLL_idlinea, "idlinea")
                consulta2.SelCampo(Palets_lineas.PLL_costeconfeccion, "costeconfeccion")
                consulta2.SelCampo(Palets_lineas.PLL_costematerial, "costematerial")
                consulta2.SelCampo(Palets_lineas.PLL_costeestructura, "costeestructura")
                consulta2.SelCampo(Palets.PAL_idtipopalet, "IdTipoPalet", Palets_lineas.PLL_idpalet, Palets.PAL_idpalet)

                '   consulta2.WheCampo(Palets_lineas.PLL_IdLineaSalida, "=", IdLineaSalida)

                consulta2.WheCampo(Albsalida_palets.ASP_IdAlbaran, "=", idalbaran)
                consulta2.WheCampo(Palets_lineas.PLL_idgensal, "=", rw1("idgensal").ToString)
                consulta2.WheCampo(Palets_lineas.PLL_idmarca, "=", rw1("idmarca").ToString)
                consulta2.WheCampo(Palets_lineas.PLL_idcategoria, "=", rw1("idcategoria").ToString)
                consulta2.WheCampo(Palets_lineas.PLL_categoria, "=", rw1("categoria").ToString)
                consulta2.WheCampo(Palets_lineas.PLL_bultos, "=", Bxp.ToString)

                consulta2.WheCampo(Palets.PAL_idtipopalet, "=", rw1("IdTipoPalet").ToString)


                Dim dt2 As DataTable = Albsalida_palets.MiConexion.ConsultaSQL(consulta2.SQL)
                If Not dt2 Is Nothing Then
                    Dim CosteConf As Decimal = 0
                    Dim CosteMat As Decimal = 0
                    Dim CosteEstr As Decimal = 0

                    For Each rw2 In dt2.Rows
                        Dim lconf As Decimal = 0
                        Dim lmat As Decimal = 0
                        Dim lest As Decimal = 0




                        AGRO_GastosLineaPalet(rw2("idlinea").ToString, lconf, lmat, lest, True, IdSemana)

                        CosteConf = CosteConf + lconf
                        CosteMat = CosteMat + lmat
                        CosteEstr = CosteEstr + lest
                    Next

                    ' CALCULO LOS GASTOS DE VENTA POR ALBARAN




                    ActualizaLineasCoste(rw1("idlinea").ToString, CosteConf, CosteMat, CosteEstr, GrabaCosteConfeccion)

                End If
            Next
        End If

    End Sub



    'Public Sub AGRO_ActualizaGastosOrigenAlbaran_OLD(idalbaran As String, GrabaCosteConfeccion As Boolean)
    '    ' recalcular los gastos de origen del albaran y los palets asociados segun los precios ACTUALES de los materiales,confeccion y estructura

    '    Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
    '    Dim Palets As New E_palets(Idusuario, cn)
    '    Dim Palets_lineas As New E_palets_lineas(Idusuario, cn)
    '    Dim Albsalida_palets As New E_albsalida_palets(Idusuario, cn)
    '    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
    '    Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)


    '    Dim consulta1 As New Cdatos.E_select
    '    consulta1.SelCampo(Albsalida_lineas.ASL_idlinea, "idlinea")
    '    consulta1.SelCampo(Albsalida_lineas.ASL_idgensal, "idgensal")
    '    consulta1.SelCampo(Albsalida_lineas.ASL_idmarca, "idmarca")
    '    consulta1.SelCampo(Albsalida_lineas.ASL_idcategoria, "idcategoria")
    '    consulta1.SelCampo(Albsalida_lineas.ASL_categoria, "categoria")
    '    consulta1.SelCampo(Albsalida_lineas.ASL_bultos, "bultos")
    '    consulta1.SelCampo(Albsalida_lineas.ASL_palets, "palets")

    '    consulta1.WheCampo(Albsalida_lineas.ASL_idalbaran, "=", idalbaran)
    '    Dim dt1 As DataTable = Albsalida_lineas.MiConexion.ConsultaSQL(consulta1.SQL)
    '    If Not dt1 Is Nothing Then
    '        For Each rw1 In dt1.Rows
    '            Dim Bxp As Integer = 0
    '            Dim nb As Integer = VaInt(rw1("bultos"))
    '            Dim np As Integer = VaInt(rw1("palets"))
    '            If np > 0 Then
    '                Bxp = nb / np
    '            Else
    '                Bxp = nb
    '            End If
    '            Dim consulta2 As New Cdatos.E_select
    '            consulta2.SelCampo(Albsalida_palets.ASP_Idpalet, "idpalet")
    '            consulta2.SelCampo(Palets_lineas.PLL_idlinea, "idlinea", Albsalida_palets.ASP_Idpalet, Palets_lineas.PLL_idpalet)
    '            consulta2.SelCampo(Palets_lineas.PLL_costeconfeccion, "costeconfeccion")
    '            consulta2.SelCampo(Palets_lineas.PLL_costematerial, "costematerial")
    '            consulta2.SelCampo(Palets_lineas.PLL_costeestructura, "costeestructura")
    '            consulta2.WheCampo(Albsalida_palets.ASP_IdAlbaran, "=", idalbaran)
    '            consulta2.WheCampo(Palets_lineas.PLL_idgensal, "=", rw1("idgensal").ToString)
    '            consulta2.WheCampo(Palets_lineas.PLL_idmarca, "=", rw1("idmarca").ToString)
    '            consulta2.WheCampo(Palets_lineas.PLL_idcategoria, "=", rw1("idcategoria").ToString)
    '            consulta2.WheCampo(Palets_lineas.PLL_categoria, "=", rw1("categoria").ToString)
    '            consulta2.WheCampo(Palets_lineas.PLL_bultos, "=", Bxp.ToString)

    '            Dim dt2 As DataTable = Albsalida_palets.MiConexion.ConsultaSQL(consulta2.SQL)
    '            If Not dt2 Is Nothing Then
    '                Dim CosteConf As Decimal = 0
    '                Dim CosteMat As Decimal = 0
    '                Dim CosteEstr As Decimal = 0

    '                For Each rw2 In dt2.Rows
    '                    Dim lconf As Decimal = 0
    '                    Dim lmat As Decimal = 0
    '                    Dim lest As Decimal = 0




    '                    AGRO_GastosLineaPalet(rw2("idlinea").ToString, lconf, lmat, lest, True, 0)

    '                    CosteConf = CosteConf + lconf
    '                    CosteMat = CosteMat + lmat
    '                    CosteEstr = CosteEstr + lest
    '                Next

    '                ' CALCULO LOS GASTOS DE VENTA POR ALBARAN




    '                ActualizaLineasCoste(rw1("idlinea").ToString, CosteConf, CosteMat, CosteEstr, GrabaCosteConfeccion)

    '            End If
    '        Next
    '    End If

    'End Sub

    Private Sub GastosVenta(Idalbaran As String)

        Dim sql As String

        sql = "Select sum(ASL_kilosnetos) as kilos, "
        sql = sql + " sum(ASL_palets) as palets, "
        sql = sql + " sum(ASL_bultos) as bultos, "
        sql = sql + " sum(ASL_importegenero) as igenero "

        sql = sql + " from albsalida_lineas where ASL_idalbaran=" + Idalbaran

        Dim dt As DataTable = cn.ConsultaSQL(sql)

        Dim kilos As Decimal = 0
        Dim palets As Decimal = 0
        Dim bultos As Decimal = 0
        Dim igenero As Decimal = 0


        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                igenero = VaDec(dt.Rows(0)("igenero"))
                kilos = VaDec(dt.Rows(0)("kilos"))
                bultos = VaDec(dt.Rows(0)("bultos"))
                palets = VaDec(dt.Rows(0)("palets"))

            End If
        End If

        Dim gf As Double = 0
        Dim gc As Double = 0

        sql = "Select * from albsalida_gastos where ASG_idalbaran=" + Idalbaran
        Dim dtg As DataTable = cn.ConsultaSQL(sql)
        If Not dtg Is Nothing Then
            For Each rw In dtg.Rows
                Select Case rw("ASG_tipofc").ToString
                    Case "F"
                        gf = gf + VaDec(rw("ASG_importegastodivisa"))

                    Case "C"
                        gc = gc + VaDec(rw("ASG_importegastoeuros"))

                End Select
            Next
        End If




    End Sub
    Private Sub ActualizaLineasCoste(idlinea As String, costeconf As Decimal, costemat As Decimal, costeestr As Decimal, GrabaCosteConfeccion As Boolean)

        'grabo los costes en la linea
        Dim consulta As New Cdatos.E_select
        Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
        If Albsalida_lineas.LeerId(idlinea) = True Then
            Albsalida_lineas.ASL_estructura.Valor = costeestr.ToString
            If GrabaCosteConfeccion = True Then
                Albsalida_lineas.ASL_manipulacion.Valor = costeconf.ToString
            End If
            Albsalida_lineas.ASL_materiales.Valor = costemat.ToString
            Albsalida_lineas.Actualizar()
        End If
    End Sub


    Public Sub AGRO_GastosLineaPalet(ByVal idlineapalet As String, ByRef GtoConf As Double, ByRef GtoMat As Double, ByRef GtoEstr As Double, Actualizalinea As Boolean, IdSemana As Integer)

        Dim consulta As New Cdatos.E_select
        Dim palets As New E_palets(Idusuario, cn)
        Dim Palets_lineas As New E_palets_lineas(Idusuario, cn)
        Dim generos As New E_Generos(Idusuario, cn)
        Dim subfamilias As New E_Subfamilias(Idusuario, cn)
        Dim familiasdescuentos As New E_FamiliasDescuentos(Idusuario, cn)
        Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)
        Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
        Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)
        Dim sql As String = ""
        Dim CostePal As Double
        Dim CosteLin As Double
        Dim Tobul As Double
        Dim EnvasePropio As String = ""
        Dim MaterialPropio As String = ""
        Dim idpalet As String = ""
        Dim Bultoslinea As Decimal = 0
        Dim suplemento As Decimal = 0
        Dim IdTipoPalet As Integer
        Dim IdTipoConfeccion As Integer



        GtoEstr = 0
        GtoConf = 0
        GtoMat = 0
        Dim EntradaConfeccionada As Integer = 0

        consulta.SelCampo(Palets_lineas.PLL_kilosnetos, "Kilos")
        consulta.SelCampo(palets.PAL_idcentro, "Centro", Palets_lineas.PLL_idpalet)
        consulta.SelCampo(palets.PAL_idpuntoventa, "IdPuntoVenta")
        consulta.SelCampo(palets.PAL_envasepropio, "envasepropio")
        consulta.SelCampo(palets.PAL_materialpropio, "materialpropio")
        consulta.SelCampo(palets.PAL_idpalet, "idpalet")
        consulta.SelCampo(palets.PAL_idtipopalet, "idtipopalet")
        consulta.SelCampo(ConfecPalet.CPA_TotalCoste, "CostePalet", palets.PAL_idtipopalet)
        consulta.SelCampo(generos.GEN_IdsubFamilia, , Palets_lineas.PLL_idgenero)
        If IdSemana = 0 Then
            consulta.SelCampo(generos.GEN_GastoConfeccion, "Gconf")
        Else
            Dim oGastoConf As New Cdatos.bdcampo("@(SELECT TOP 1 SGK_gasto FROM Semanas_GastoConf WHERE SGK_IdGenero = PLL_IdGenero AND SGK_IdSemana = " & IdSemana & " )", Cdatos.TiposCampo.Importe, 10, 4)
            consulta.SelCampo(oGastoConf, "Gconf")
        End If
        consulta.SelCampo(GenerosSalida.GES_GtoXKilo, "SupC", Palets_lineas.PLL_idgensal)
        consulta.SelCampo(GenerosSalida.GES_SobrecosteMat, "SupM")
        consulta.SelCampo(subfamilias.SFA_idfamilia, "idfamilia", generos.GEN_IdsubFamilia)
        consulta.SelCampo(Palets_lineas.PLL_bultos, "bultos")
        consulta.SelCampo(Palets_lineas.PLL_idgensal, "idgensal")
        consulta.SelCampo(Palets_lineas.PLL_idlineaentradaconfeccionada, "IdLineaEntradaConfeccionada")
        consulta.SelCampo(Palets_lineas.PLL_idtipoconfeccion, "idtipoconfeccion")
        consulta.SelCampo(ConfecEnvase.CEV_TotalCoste, "CosteEnvase", Palets_lineas.PLL_idtipoconfeccion)
        consulta.WheCampo(Palets_lineas.PLL_idlinea, "=", idlineapalet)

        sql = consulta.SQL
        Dim dt1 As DataTable = Palets_lineas.MiConexion.ConsultaSQL(sql)
        If Not dt1 Is Nothing Then
            If dt1.Rows.Count = 1 Then

                idpalet = dt1.Rows(0)("idpalet").ToString
                CostePal = VaDec(dt1.Rows(0)("Costepalet"))
                CosteLin = VaDec(dt1.Rows(0)("CosteEnvase")) * VaDec(dt1.Rows(0)("bultos"))
                EnvasePropio = dt1.Rows(0)("Envasepropio").ToString
                MaterialPropio = dt1.Rows(0)("Materialpropio").ToString
                Bultoslinea = VaDec(dt1.Rows(0)("bultos"))
                EntradaConfeccionada = VaInt(dt1.Rows(0)("IdLineaEntradaConfeccionada"))
                IdTipoPalet = VaInt(dt1.Rows(0)("idtipopalet"))
                IdTipoConfeccion = VaInt(dt1.Rows(0)("idtipoconfeccion"))
                'If GenerosSalida.LeerId(dt1.Rows(0)("idgensal").ToString) = True Then
                '    GtoConf = VaDec(GenerosSalida.GES_GtoXKilo.Valor) * VaDec(dt1.Rows(0)("KILOS"))
                '    suplemento = VaDec(GenerosSalida.GES_SobrecosteMat.Valor) * VaDec(dt1.Rows(0)("BULTOS"))
                'End If
                GtoConf = VaDec(dt1.Rows(0)("Gconf")) * VaDec(dt1.Rows(0)("KILOS"))
                GtoConf = GtoConf + VaDec(dt1.Rows(0)("SupC")) * VaDec(dt1.Rows(0)("KILOS"))
                suplemento = VaDec(dt1.Rows(0)("SupM")) * VaDec(dt1.Rows(0)("BULTOS"))


                'Dim dt As DataTable = familiasdescuentos.LeerDescuentos(VaInt(dt1.Rows(0)("idfamilia")), VaInt(dt1.Rows(0)("centro")))
                Dim dt As DataTable = familiasdescuentos.LeerDescuentos(VaInt(dt1.Rows(0)("idfamilia")), VaInt(dt1.Rows(0)("IdPuntoVenta")))
                If Not dt Is Nothing Then
                    If dt.Rows.Count = 1 Then
                        GtoEstr = VaDec(dt.Rows(0)("FAD_estructura")) * VaDec(dt1.Rows(0)("KILOS"))
                    End If
                End If
            End If
        End If


        sql = "Select sum(pll_bultos) from palets_lineas where PLL_idpalet=" + idpalet
        Dim dt5 As DataTable = Palets_lineas.MiConexion.ConsultaSQL(sql)
        If Not dt5 Is Nothing Then
            If dt5.Rows.Count > 0 Then
                Tobul = dt5.Rows(0)(0)
            End If
        End If

        If MaterialPropio = "N" Then
            suplemento = 0
        End If

        If EnvasePropio = "N" Or MaterialPropio = "N" Then 'recalculo el coste del material cuando el envase o el material no es propio
            CalculoCosteMaterial(EnvasePropio, MaterialPropio, IdTipoPalet, IdTipoConfeccion, Bultoslinea, CosteLin, CostePal)
        End If

        If Tobul > 0 Then
            'TODO: SUM(PLL_Bultos) * PLL_Bultos ??
            CosteLin = CosteLin + CostePal / Tobul * Bultoslinea
        End If

        GtoMat = CosteLin + suplemento


        If EntradaConfeccionada > 0 Then
            GtoConf = 0
        End If


        If Actualizalinea = True Then
            If Palets_lineas.LeerId(idlineapalet) = True Then
                Palets_lineas.PLL_costeconfeccion.Valor = GtoConf.ToString
                Palets_lineas.PLL_costeestructura.Valor = GtoEstr.ToString
                Palets_lineas.PLL_costematerial.Valor = GtoMat.ToString
                Palets_lineas.Actualizar()
            End If
        End If

    End Sub


    Private Sub CalculoCosteMaterial(envasepropio As String, materialpropio As String, idtipopalet As Integer, idtipoconfeccion As Integer, bultospalet As Integer, ByRef CosteLin As Decimal, ByRef costepal As Decimal)
        CosteLin = 0
        costepal = 0


        Dim confecpaletlineas As New E_ConfecPaletLineas(Idusuario, cn)
        Dim confecenvaselineas As New E_ConfecEnvaseLineas(Idusuario, cn)

        Dim envases As New E_Envases(Idusuario, cn)

        If envasepropio = "N" And materialpropio = "N" Then
            Exit Sub

        End If

        Dim consulta2 As New Cdatos.E_select
        consulta2.SelCampo(confecpaletlineas.CPL_Cantidad, "Cantidad")
        consulta2.SelCampo(envases.ENV_TaraSalida, "Tara", confecpaletlineas.CPL_Idmaterial)
        consulta2.SelCampo(envases.ENV_CosteSalida, "Coste")
        consulta2.SelCampo(envases.ENV_Tipo, "tipo")
        consulta2.WheCampo(confecpaletlineas.CPL_Idconfec, "=", idtipopalet.ToString)
        Dim dt2 As DataTable = confecpaletlineas.MiConexion.ConsultaSQL(consulta2.SQL)
        If Not dt2 Is Nothing Then
            For Each rw2 In dt2.Rows
                '                If envasepropio = "S" And rw2("tipo").ToString = "P" Then
                costepal = costepal + VaDec(rw2("Cantidad")) * VaDec(rw2("Coste"))
                '                End If
                ' If materialpropio = "S" And rw2("tipo").ToString <> "P" Then
                ' costepal = costepal + VaDec(rw2("Cantidad")) * VaDec(rw2("Coste"))
                ' End If
            Next
        End If

        Dim consulta3 As New Cdatos.E_select
        consulta3.SelCampo(confecenvaselineas.CEL_Cantidad, "Cantidad")
        consulta3.SelCampo(envases.ENV_TaraSalida, "Tara", confecenvaselineas.CEL_Idmaterial)
        consulta3.SelCampo(envases.ENV_CosteSalida, "Coste")
        consulta3.SelCampo(envases.ENV_Tipo, "tipo")
        consulta3.WheCampo(confecenvaselineas.CEL_Idconfec, "=", idtipoconfeccion.ToString)
        Dim dt3 As DataTable = confecenvaselineas.MiConexion.ConsultaSQL(consulta3.SQL)
        If Not dt3 Is Nothing Then
            For Each rw3 In dt3.Rows
                If envasepropio = "S" And rw3("tipo").ToString = "E" Then
                    CosteLin = CosteLin + VaDec(rw3("Cantidad")) * VaDec(rw3("Coste")) * bultospalet
                End If
                If materialpropio = "S" And rw3("tipo").ToString <> "E" Then
                    CosteLin = CosteLin + VaDec(rw3("Cantidad")) * VaDec(rw3("Coste")) * bultospalet
                End If
            Next
        End If




    End Sub

End Module
