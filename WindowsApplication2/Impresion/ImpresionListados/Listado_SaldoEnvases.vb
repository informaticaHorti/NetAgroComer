Public Class Listado_SaldoEnvases
    Inherits Listado_ImpresionBase


    Property Sujeto As String
    Property Codigo As String
    Property NombreSujeto As String
    Property FechaDesde As String
    Property FechaHasta As String
    Property SoloRetornables As Boolean
    Property Envases As List(Of String)
    Property TipoImpresion As TipoImpresion
    Property bMarcas As Boolean
    Property Almacenes As List(Of String)


    Dim Texto As String = ""
    Dim Formato As String = ""
    Dim FormatoTotales As String = ""
    Dim AnchoPagina As Integer = 200
    Dim Ancho As Integer = AnchoPagina


    Public Sub New(ByVal sujeto As String, ByVal bMarcas As Boolean, ByVal codigo As String, ByVal nombreSujeto As String, ByVal fechaDesde As String, _
                   ByVal fechaHasta As String, ByVal soloRetornables As Boolean, ByVal envases As List(Of String), ByVal lstAlmacenes As List(Of String),
                   ByVal TipoImpresion As TipoImpresion)
        Me.Sujeto = sujeto
        Me.Codigo = codigo
        Me.NombreSujeto = nombreSujeto
        Me.FechaDesde = fechaDesde
        Me.FechaHasta = fechaHasta
        Me.SoloRetornables = soloRetornables
        Me.Envases = envases
        Me.TipoImpresion = TipoImpresion
        Me.bMarcas = bMarcas
        Almacenes = lstAlmacenes
    End Sub


    Public Overrides Sub ImprimirListado()

        MargenIzq = 13
        Ancho = AnchoPagina - MargenIzq - MargenDer
        EstableceListado(Orientacion.Vertical, TipoImpresion)

        Try

            ConfiguraListado()
            Previsualiza()

        Catch ex As Exception

        End Try
        
    End Sub


    Private Sub ConfiguraListado()

        If bMarcas Then
            ConfiguraListadoConMarcas()
        Else
            ConfiguraListadoSinMarcas()
        End If

    End Sub

    Private Sub ConfiguraListadoSinMarcas()


        Dim dt As DataTable = GeneraDetalleSaldoEnvases()

        Dim TipoSujeto As String = ""

        If Sujeto = "A" Then
            TipoSujeto = "Agricultor: "
        ElseIf Sujeto = "C" Then
            TipoSujeto = "Cliente: "
        End If

        Texto = MiMaletin.NombreEmpresa
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.Cabecera)

        Texto = "LISTADO DE MOVIMIENTOS DE ENVASES"
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.GrandeBold)

        If Len(FechaDesde.Trim) > 0 Or Len(FechaHasta.Trim) > 0 Then
            Texto = TipoSujeto & Codigo & " - " & NombreSujeto
            Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)

            Texto = "Desde " & FechaDesde & " hasta " & FechaHasta & "|Fecha Impresión: " & Today.ToString("dd/MM/yyyy")
            Formato = (Ancho - 80).ToString & "|>80"
            Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)
        End If
        If bMarcas Then
            Listado.Cabecera.Linea("Detallar marcas: SI", Ancho.ToString, Estilos.NormalBold)
        Else
            Listado.Cabecera.Linea("Detallar marcas: NO", Ancho.ToString, Estilos.NormalBold)
        End If

        If SoloRetornables Then
            Texto = "Solo retornables"
            Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)
        End If

        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Normal)

        Texto = "Fecha|AL|Num||Referencia|Concepto|Retira|PrecioR|Entrega|PrecioE|Saldo|SaldoV"
        Formato = "=18|=6|>8|2|17|26|>18|>18|>18|>18|>18|>18"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.MinimaBoldLineaDebajo)

        Dim listaCampos As New List(Of String)
        listaCampos.Add("retira")
        listaCampos.Add("entrega")
        listaCampos.Add("saldo")
        listaCampos.Add("saldov")

        Dim totales As New AcumuladorTotales(listaCampos)

        Dim idEnvaseActual As String = ""

        For Each r As DataRow In dt.Rows

            Dim idEnvase As String = (r("IdEnvase").ToString & "").Trim
            Dim envase As String = (r("Envase").ToString & "").Trim
            Dim fecha As String = ""
            If VaDate(r("Fecha")) <> VaDate("") Then fecha = VaDate(r("Fecha"))
            Dim AL As String = (r("AL").ToString & "").Trim
            If VaInt(AL) = 0 Then AL = ""
            Dim numero As String = (r("Numero").ToString & "").Trim
            If VaInt(numero) = 0 Then numero = ""
            Dim referencia As String = (r("Referencia").ToString & "").Trim
            Dim concepto As String = (r("Concepto").ToString & "").Trim

            Dim retira As Decimal = VaDec(r("Retira"))
            Dim precioR As Decimal = VaDec(r("PrecioR"))
            Dim entrega As Decimal = VaDec(r("Entrega"))
            Dim precioE As Decimal = VaDec(r("PrecioE"))
            Dim saldo As Decimal = VaDec(r("Saldo"))
            Dim saldoV As Decimal = VaDec(r("SaldoV"))


            If idEnvaseActual.Equals(idEnvase) Then
                If Len(idEnvaseActual) > 0 Then
                    Texto = "|||||TOTAL ENVASE|"
                    Texto = Texto & totales.GetValor("retira").ToString("#,##0") & "||"
                    Texto = Texto & totales.GetValor("entrega").ToString("#,##0") & "||"
                    Texto = Texto & StSaldo(totales.GetValor("saldo")) & "|"
                    Texto = Texto & StSaldo(totales.GetValor("saldov"))
                    Listado.Detalle.Linea(Texto, Formato, Estilos.MinimaBoldLineaEncima)

                    totales.ReiniciarValores()
                End If

                Listado.Detalle.Linea("", Ancho.ToString, Estilos.Normal)

                Texto = VaInt(idEnvase).ToString("00000") & " " & envase
                Listado.Detalle.Linea(Texto, "70", Estilos.ReducidaBoldLineaDebajo)
            End If

            Dim listaValores As New List(Of Decimal)
            listaValores.Add(retira)
            listaValores.Add(entrega)
            listaValores.Add(saldo)
            listaValores.Add(saldoV)

            totales.Suma(listaValores)

            Texto = fecha & "|"
            Texto = Texto & AL & "|"
            Texto = Texto & numero & "||"
            Texto = Texto & referencia & "|"
            Texto = Texto & concepto & "|"
            Texto = Texto & retira.ToString("#,##0") & "|"
            Texto = Texto & precioR.ToString("#,##0.00") & "|"
            Texto = Texto & entrega.ToString("#,##0") & "|"
            Texto = Texto & precioE.ToString("#,##0.00") & "|"
            Texto = Texto & StSaldo(totales.GetValor("saldo")) & "|"
            Texto = Texto & StSaldo(totales.GetValor("saldov")) & "|"
            Listado.Detalle.Linea(Texto, Formato, Estilos.Minima)

            idEnvaseActual = idEnvase


            Application.DoEvents()

        Next

        Texto = "|||||TOTAL ENVASE|"
        Texto = Texto & totales.GetValor("retira").ToString("#,##0") & "||"
        Texto = Texto & totales.GetValor("entrega").ToString("#,##0") & "||"
        Texto = Texto & StSaldo(totales.GetValor("saldo")) & "|"
        Texto = Texto & StSaldo(totales.GetValor("saldov"))
        Listado.Detalle.Linea(Texto, Formato, Estilos.MinimaBoldLineaEncima)
    End Sub


    Private Sub ConfiguraListadoConMarcas()


        Dim dt As DataTable = GeneraDetalleSaldoEnvases()

        Dim TipoSujeto As String = ""

        If Sujeto = "A" Then
            TipoSujeto = "Agricultor: "
        ElseIf Sujeto = "C" Then
            TipoSujeto = "Cliente: "
        End If

        Texto = MiMaletin.NombreEmpresa
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.Cabecera)

        Texto = "LISTADO DE MOVIMIENTOS DE ENVASES"
        Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.GrandeBold)

        If Len(FechaDesde.Trim) > 0 Or Len(FechaHasta.Trim) > 0 Then
            Texto = TipoSujeto & Codigo & " - " & NombreSujeto
            Listado.Cabecera.Linea(Texto, Ancho.ToString, Estilos.NormalBold)

            Texto = "Desde " & FechaDesde & " hasta " & FechaHasta & "|Fecha Impresión: " & Today.ToString("dd/MM/yyyy")
            Formato = (Ancho - 80).ToString & "|>80"
            Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)
        End If
        If bMarcas Then
            Listado.Cabecera.Linea("Detallar marcas: SI", Ancho.ToString, Estilos.NormalBold)
        Else
            Listado.Cabecera.Linea("Detallar marcas: NO", Ancho.ToString, Estilos.NormalBold)
        End If

        If SoloRetornables Then
            Texto = "Solo retornables"
            Listado.Cabecera.Linea(Texto, Formato, Estilos.NormalBold)
        End If

        Listado.Cabecera.Linea("", Ancho.ToString, Estilos.Normal)

        Texto = "Fecha|AL|Num||Referencia|Concepto|Retira|PrecioR|Entrega|PrecioE|Saldo|SaldoV"
        Formato = "=18|=6|>8|2|17|26|>18|>18|>18|>18|>18|>18"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.MinimaBoldLineaDebajo)

        Dim listaCampos As New List(Of String)
        listaCampos.Add("retira")
        listaCampos.Add("entrega")
        listaCampos.Add("saldo")
        listaCampos.Add("saldov")

        Dim TotalesEnvases As New AcumuladorTotales(listaCampos)
        Dim TotalesMarcas As New AcumuladorTotales(listaCampos)


        Dim idEnvaseActual As String = ""
        Dim idMarcaActual As String = ""

        For Each r As DataRow In dt.Rows

            Dim idEnvase As String = (r("IdEnvase").ToString & "").Trim
            Dim envase As String = (r("Envase").ToString & "").Trim
            Dim IdMarca As String = (r("IdMarca").ToString & "").Trim
            Dim Marca As String = (r("Marca").ToString & "").Trim
            Dim fecha As String = ""
            If VaDate(r("Fecha")) <> VaDate("") Then fecha = VaDate(r("Fecha"))
            Dim AL As String = (r("AL").ToString & "").Trim
            If VaInt(AL) = 0 Then AL = ""
            Dim numero As String = (r("Numero").ToString & "").Trim
            If VaInt(numero) = 0 Then numero = ""
            Dim referencia As String = (r("Referencia").ToString & "").Trim
            Dim concepto As String = (r("Concepto").ToString & "").Trim

            Dim retira As Decimal = VaDec(r("Retira"))
            Dim precioR As Decimal = VaDec(r("PrecioR"))
            Dim entrega As Decimal = VaDec(r("Entrega"))
            Dim precioE As Decimal = VaDec(r("PrecioE"))
            Dim saldo As Decimal = VaDec(r("Saldo"))
            Dim saldoV As Decimal = VaDec(r("SaldoV"))


            Dim bCambioEnvase As Boolean = Not idEnvaseActual.Equals(idEnvase)
            Dim bCambioMarca As Boolean = Not idMarcaActual.Equals(idMarca)
            If bCambioEnvase Then bCambioMarca = True


            If bCambioMarca And idMarcaActual.Trim <> "" Then

                Texto = "|||||TOTAL Marca|"
                Texto = Texto & TotalesMarcas.GetValor("retira").ToString("#,##0") & "||"
                Texto = Texto & TotalesMarcas.GetValor("entrega").ToString("#,##0") & "||"
                Texto = Texto & StSaldo(TotalesMarcas.GetValor("saldo")) & "|"
                Texto = Texto & StSaldo(TotalesMarcas.GetValor("saldov"))
                Listado.Detalle.Linea(Texto, Formato, Estilos.MinimaBoldLineaEncima)

                TotalesMarcas.ReiniciarValores()

                'Listado.Detalle.Linea("", Ancho.ToString, Estilos.Normal)
                'Texto = VaInt(idEnvase).ToString("00000") & " " & envase & " - " & VaInt(IdMarca).ToString("000") & " " & Marca
                'Listado.Detalle.Linea(Texto, "70", Estilos.ReducidaBoldLineaDebajo)

            End If


            If bCambioEnvase And idEnvaseActual.Trim <> "" Then

                Texto = "|||||TOTAL ENVASE|"
                Texto = Texto & TotalesEnvases.GetValor("retira").ToString("#,##0") & "||"
                Texto = Texto & TotalesEnvases.GetValor("entrega").ToString("#,##0") & "||"
                Texto = Texto & StSaldo(TotalesEnvases.GetValor("saldo")) & "|"
                Texto = Texto & StSaldo(TotalesEnvases.GetValor("saldov"))
                Listado.Detalle.Linea(Texto, Formato, Estilos.MinimaBoldLineaEncima)

                TotalesEnvases.ReiniciarValores()

                'Listado.Detalle.Linea("", Ancho.ToString, Estilos.Normal)
                'Texto = VaInt(idEnvase).ToString("00000") & " " & envase & " - " & VaInt(IdMarca).ToString("000") & " " & Marca
                'Listado.Detalle.Linea(Texto, "70", Estilos.ReducidaBoldLineaDebajo)
            End If


            Dim TextoMarca As String = ""
            If VaInt(IdMarca) > 0 Then TextoMarca = " - " & VaInt(IdMarca).ToString("000") & " " & Marca

            If bCambioEnvase Or bCambioMarca Then
                Listado.Detalle.Linea("", Ancho.ToString, Estilos.Normal)
                Texto = VaInt(idEnvase).ToString("00000") & " " & envase & TextoMarca
                Listado.Detalle.Linea(Texto, Ancho.ToString, Estilos.ReducidaBoldLineaDebajo)
            End If


            Dim listaValores As New List(Of Decimal)
            listaValores.Add(retira)
            listaValores.Add(entrega)
            listaValores.Add(saldo)
            listaValores.Add(saldoV)

            TotalesEnvases.Suma(listaValores)
            TotalesMarcas.Suma(listaValores)


            Texto = fecha & "|"
            Texto = Texto & AL & "|"
            Texto = Texto & numero & "||"
            Texto = Texto & referencia & "|"
            Texto = Texto & concepto & "|"
            Texto = Texto & retira.ToString("#,##0") & "|"
            Texto = Texto & precioR.ToString("#,##0.00") & "|"
            Texto = Texto & entrega.ToString("#,##0") & "|"
            Texto = Texto & precioE.ToString("#,##0.00") & "|"
            Texto = Texto & StSaldo(saldo) & "|"
            Texto = Texto & StSaldo(saldoV) & "|"
            Listado.Detalle.Linea(Texto, Formato, Estilos.Minima)

            idEnvaseActual = idEnvase
            idMarcaActual = IdMarca


            Application.DoEvents()

        Next


        Texto = "|||||TOTAL Marca|"
        Texto = Texto & TotalesMarcas.GetValor("retira").ToString("#,##0") & "||"
        Texto = Texto & TotalesMarcas.GetValor("entrega").ToString("#,##0") & "||"
        Texto = Texto & StSaldo(TotalesMarcas.GetValor("saldo")) & "|"
        Texto = Texto & StSaldo(TotalesMarcas.GetValor("saldov"))
        Listado.Detalle.Linea(Texto, Formato, Estilos.MinimaBoldLineaEncima)


        Texto = "|||||TOTAL ENVASE|"
        Texto = Texto & TotalesEnvases.GetValor("retira").ToString("#,##0") & "||"
        Texto = Texto & TotalesEnvases.GetValor("entrega").ToString("#,##0") & "||"
        Texto = Texto & StSaldo(TotalesEnvases.GetValor("saldo")) & "|"
        Texto = Texto & StSaldo(TotalesEnvases.GetValor("saldov"))
        Listado.Detalle.Linea(Texto, Formato, Estilos.MinimaBoldLineaEncima)

    End Sub


    Private Function GeneraDetalleSaldoEnvases() As DataTable

        Dim dtInicial As DataTable = GeneraDetalleSaldoEnvasesInicial()

        'Movimientos de envases
        Dim entValeEnvase As New E_ValeEnvases(Idusuario, cn)
        Dim entValeEnvaseLineas As New E_ValeEnvases_Lineas(Idusuario, cn)
        Dim entEnvases As New E_Envases(Idusuario, cn)
        Dim entMarcas As New E_Marcas(Idusuario, cn)

        Dim consulta As New Cdatos.E_select

        consulta.SelCampo(entValeEnvaseLineas.VEL_idenvase, "IdEnvase")
        consulta.SelCampo(entEnvases.ENV_Nombre, "Envase", entValeEnvaseLineas.VEL_idenvase, entEnvases.ENV_IdEnvase)
        consulta.SelCampo(entValeEnvaseLineas.VEL_idmarca, "IdMarca")
        consulta.SelCampo(entMarcas.MAR_Nombre, "Marca", entValeEnvaseLineas.VEL_idmarca, entMarcas.MAR_Idmarca)
        consulta.SelCampo(entValeEnvase.VEV_Fecha, "Fecha", entValeEnvaseLineas.VEL_idvale)
        consulta.SelCampo(entValeEnvase.VEV_Idcentro, "CE")
        consulta.SelCampo(entValeEnvaseLineas.VEL_idalmacen, "AL")
        consulta.SelCampo(entValeEnvase.VEV_Operacion, "TV")
        consulta.SelCampo(entValeEnvase.VEV_Numero, "Numero")
        consulta.SelCampo(entValeEnvase.VEV_Referencia, "Referencia")
        consulta.SelCampo(entValeEnvase.VEV_Concepto, "Concepto")
        consulta.SelCampo(entValeEnvaseLineas.VEL_retira, "Retira")
        consulta.SelCampo(entValeEnvaseLineas.VEL_precioretira, "PrecioR")
        consulta.SelCampo(entValeEnvaseLineas.VEL_entrega, "Entrega")
        consulta.SelCampo(entValeEnvaseLineas.VEL_precioentrega, "PrecioE")
        consulta.WheCampo(entValeEnvase.VEV_TipoSujeto, "=", Sujeto)
        If Codigo.Trim <> "" Then consulta.WheCampo(entValeEnvase.VEV_Codigo, "=", Codigo)
        consulta.WheCampo(entValeEnvase.VEV_Fecha, ">=", FechaDesde)
        consulta.WheCampo(entValeEnvase.VEV_Fecha, "<=", FechaHasta)
        If SoloRetornables Then consulta.WheCampo(entEnvases.ENV_Retornable, "=", "S")


        Dim sql As String = consulta.SQL & vbCrLf

        If Envases.Count > 0 Then
            sql = sql & CadenaWhereLista(entValeEnvaseLineas.VEL_idenvase, Envases, " AND ") & vbCrLf
        End If
        If Almacenes.Count > 0 Then
            sql = sql & CadenaWhereLista(entValeEnvase.VEV_IdAlmacen, Almacenes, " AND ") & vbCrLf
        End If


        If bMarcas Then
            sql = sql + " order by VEL_IdEnvase, VEL_IdMarca, VEV_fecha, Numero, CE"
        Else
            sql = sql + " order by VEL_IdEnvase, VEV_fecha, Numero, CE"
        End If



        Dim dt As DataTable = entValeEnvase.MiConexion.ConsultaSQL(sql)

        'Fusionamos iniciales y movimientos
        If Not IsNothing(dtInicial) And Not IsNothing(dt) Then
            dt.Merge(dtInicial)
            Dim dv As New DataView(dt)
            If bMarcas Then
                dv.Sort = "IdEnvase, IdMarca, Fecha, Numero, CE"
            Else
                dv.Sort = "IdEnvase, Fecha, Numero, CE"
            End If
            dt = dv.ToTable
        End If



        'Las columnas Saldo y SaldoV podrían no existir si no hay envases iniciales, por si acaso, las añadimos
        If Not IsNothing(dt) Then
            If Not dt.Columns.Contains("Saldo") Then
                Dim col As New DataColumn("Saldo", GetType(Decimal))
                col.DefaultValue = 0.0
                dt.Columns.Add(col)
            End If
            If Not dt.Columns.Contains("SaldoV") Then
                Dim col As New DataColumn("SaldoV", GetType(Decimal))
                col.DefaultValue = 0.0
                dt.Columns.Add(col)
            End If
        End If


        Dim acum As New Acumulador


        

        For Each row As DataRow In dt.Rows

            Dim IdEnvase As String = (row("IdEnvase").ToString & "").Trim
            Dim Envase As String = (row("Envase").ToString & "").Trim
            Dim IdMarca As String = 0
            Dim Marca As String = ""
            If bMarcas Then
                IdMarca = VaInt(row("IdMarca"))
                Marca = (row("Marca").ToString & "").Trim
            End If
            Dim Fecha As Date = VaDate(row("Fecha"))
            Dim CE As String = (row("CE").ToString & "").Trim
            Dim AL As String = (row("AL").ToString & "").Trim
            Dim TV As String = (row("TV").ToString & "").Trim
            Dim Numero As String = (row("Numero").ToString & "").Trim
            Dim Referencia As String = (row("Referencia").ToString & "").Trim
            Dim Concepto As String = (row("Concepto").ToString & "").Trim
            Dim PrecioR As Decimal = VaDec(row("PrecioR"))
            Dim PrecioE As Decimal = VaDec(row("PrecioE"))

            Dim Retira As Decimal = VaDec(row("Retira"))
            Dim Entrega As Decimal = VaDec(row("Entrega"))

            Dim Saldo As Decimal = VaDec(row("Saldo"))
            Dim SaldoV As Decimal = VaDec(row("SaldoV"))


            If PrecioR = 0 Then
                Saldo = Saldo + Retira
            Else
                SaldoV = SaldoV + Retira
            End If
            If PrecioE = 0 Then
                Saldo = Saldo - Entrega
            Else
                SaldoV = SaldoV - Entrega
            End If

            Dim stClave As New stClave_MovimientoSaldos(VaInt(IdEnvase), Envase, IdMarca, Marca, Fecha, VaInt(CE), VaInt(AL), TV, VaInt(Numero), _
                                                        Referencia, Concepto, PrecioR, PrecioE)
            Dim stDatos As New stDatos_MovimientoSaldos(Retira, Entrega, Saldo, SaldoV)

            acum.Suma(stClave, stDatos)


            Application.DoEvents()

        Next

        dt = acum.DataTable

        Return dt
    End Function

    Private Function GeneraDetalleSaldoEnvasesInicial() As DataTable
        Dim Pref As String = ""
        Dim TipoInicial As String = ""

        If Sujeto = "C" Then
            Pref = "CLI_"
            TipoInicial = "CL"
        ElseIf Sujeto = "A" Then
            Pref = "AGR_"
            TipoInicial = "AG"
        End If

        Dim ValeEnvases_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
        Dim EnvasesInicial As New E_envasesInicial(Idusuario, cn)

        Dim sql1 As String = "SELECT VEL_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
        sql1 = sql1 & " COALESCE(VEL_Retira,0) - COALESCE(VEL_Entrega,0) as Inicial," & vbCrLf
        sql1 = sql1 & " (COALESCE(VEL_Retira,0) - COALESCE(VEL_Entrega,0)) as InicialV," & vbCrLf
        sql1 = sql1 & " COALESCE(VEL_PrecioRetira,0) + COALESCE(VEL_PrecioEntrega,0) as Precio" & vbCrLf
        sql1 = sql1 & " FROM ValeEnvases VE" & vbCrLf
        sql1 = sql1 & " LEFT JOIN ValeEnvases_Lineas VL ON VEV_IDVALE = VEL_IDVALE" & vbCrLf
        sql1 = sql1 & " LEFT JOIN Envases ON VEL_IdEnvase = ENV_IdEnvase" & vbCrLf
        sql1 = sql1 & " WHERE VEV_TipoSujeto = '" & Sujeto & "'" & vbCrLf
        If Codigo.Trim <> "" Then sql1 = sql1 & " AND VEV_Codigo = " & Codigo & vbCrLf
        sql1 = sql1 & " AND VEV_Fecha >= '" & MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy") & "'" & vbCrLf
        sql1 = sql1 & " AND VEV_Fecha < '" & FechaDesde & "'" & vbCrLf
        If SoloRetornables Then sql1 = sql1 & " AND ENV_Retornable = 'S'" & vbCrLf
        If Envases.Count > 0 Then sql1 = sql1 & CadenaWhereLista(ValeEnvases_Lineas.VEL_idenvase, Envases, " AND ") & vbCrLf

        Dim sql2 As String = " SELECT ENI_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
        'sql2 = sql2 & " ENI_Inicial as Inicial, (COALESCE(ENI_Inicial,0) * COALESCE(ENI_Precio,0)) as InicialV," & vbCrLf
        sql2 = sql2 & " ENI_Inicial as Inicial, ENI_Inicial as InicialV," & vbCrLf
        sql2 = sql2 & " ENI_Precio as Precio"
        sql2 = sql2 & " FROM EnvasesInicial"
        sql2 = sql2 & " LEFT JOIN Envases ON ENV_IdEnvase = ENI_IdEnvase" & vbCrLf
        sql2 = sql2 & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString
        sql2 = sql2 & " AND ENI_Tipo = '" & TipoInicial & "'"
        If Codigo.Trim <> "" Then sql2 = sql2 & " AND ENI_Codigo = " & Codigo & vbCrLf
        If SoloRetornables Then sql2 = sql2 & " AND ENV_Retornable = 'S'" & vbCrLf
        If Envases.Count > 0 Then sql2 = sql2 & CadenaWhereLista(EnvasesInicial.ENI_idenvase, Envases, " AND ") & vbCrLf

        Dim sql As String = "SELECT IdEnvase, Envase," & vbCrLf
        sql = sql & " SUM(Inicial) as Saldo, 0 as SaldoV" & vbCrLf
        sql = sql & " FROM (" & vbCrLf & sql1 & vbCrLf & ") as I" & vbCrLf
        sql = sql & " WHERE Precio = 0" & vbCrLf
        sql = sql & " GROUP BY IdEnvase, Envase" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT IdEnvase, Envase, 0 as Saldo, SUM(InicialV) as SaldoV" & vbCrLf
        sql = sql & " FROM (" & vbCrLf & sql1 & vbCrLf & ") as I" & vbCrLf
        sql = sql & " WHERE Precio <> 0" & vbCrLf
        sql = sql & " GROUP BY IdEnvase, Envase" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT IdEnvase, Envase, SUM(Inicial) as Saldo, 0 as SaldoV" & vbCrLf
        sql = sql & " FROM (" & vbCrLf & sql2 & vbCrLf & ") as I" & vbCrLf
        sql = sql & " WHERE Precio = 0" & vbCrLf
        sql = sql & " GROUP BY IdEnvase, Envase" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT IdEnvase, Envase, 0 as Saldo, SUM(InicialV) as SaldoV" & vbCrLf
        sql = sql & " FROM (" & vbCrLf & sql2 & vbCrLf & ") as I" & vbCrLf
        sql = sql & " WHERE Precio <> 0" & vbCrLf
        sql = sql & " GROUP BY IdEnvase, Envase" & vbCrLf

        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
        Dim dt As DataTable = ValeEnvases.MiConexion.ConsultaSQL(sql)

        Dim acum As New Acumulador

        Dim Fecha As Date = VaDate(FechaDesde)

        'Acumula los saldos iniciales en diccioniarios
        For Each row As DataRow In dt.Rows

            Dim IdEnvase As String = (row("IdEnvase").ToString & "").Trim
            Dim Envase As String = (row("Envase").ToString & "").Trim
            Dim IdMarca As Integer = 0
            Dim Marca As String = ""
            If bMarcas Then
                IdMarca = VaInt(row("IdMarca"))
                Marca = (row("Marca").ToString & "").Trim
            End If
            Dim Inicial As Integer = VaInt(row("Saldo"))
            Dim InicialV As Integer = VaInt(row("SaldoV"))

            Dim stClave As New stClave_MovimientoSaldos(VaInt(IdEnvase), Envase, IdMarca, Marca, Fecha, 0, 0, "", 0, "", "Saldo Inicial", 0, 0)
            Dim stDatos As New stDatos_MovimientoSaldos(0, 0, Inicial, InicialV)
            acum.Suma(stClave, stDatos)

            Application.DoEvents()

        Next

        Return acum.DataTable
    End Function


    Private Class stClave_MovimientoSaldos

        Public IdEnvase As Integer = 0
        Public Envase As String = ""
        Public IdMarca As Integer = 0
        Public Marca As String = ""
        Public Fecha As Date = VaDate("")
        Public CE As Integer = 0
        Public AL As Integer = 0
        Public TV As String = ""
        Public Numero As Integer = 0
        Public Referencia As String = ""
        Public Concepto As String = ""
        Public PrecioR As Decimal = 0
        Public PrecioE As Decimal = 0


        Public Sub New(IdEnvase As Integer, Envase As String, IdMarca As Integer, Marca As String, Fecha As Date, CE As Integer, AL As Integer, TV As String, Numero As Integer,
                       Referencia As String, Concepto As String, PrecioR As Decimal, PrecioE As Decimal)
            Me.IdEnvase = IdEnvase
            Me.Envase = Envase
            Me.IdMarca = IdMarca
            Me.Marca = Marca
            Me.Fecha = Fecha
            Me.CE = CE
            Me.AL = AL
            Me.TV = TV
            Me.Numero = Numero
            Me.Referencia = Referencia
            Me.Concepto = Concepto
            Me.PrecioR = PrecioR
            Me.PrecioE = PrecioE
        End Sub

    End Class

    Private Class stDatos_MovimientoSaldos

        Public Retira As Decimal = 0
        Public Entrega As Decimal = 0
        Public Saldo As Decimal = 0
        Public SaldoV As Decimal = 0

        Public Sub New(Retira As Decimal, Entrega As Decimal, Saldo As Decimal, SaldoV As Decimal)
            Me.Retira = Retira
            Me.Entrega = Entrega
            Me.Saldo = Saldo
            Me.SaldoV = SaldoV
        End Sub

    End Class

    
End Class
