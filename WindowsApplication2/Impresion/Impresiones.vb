Imports System.Drawing
Imports DevExpress.XtraEditors

Module Impresiones



    '#Region "Listado Iva Repercutido"

    '    Public Sub ImprimirListadoIvaRepercutido(ByVal dt As DataTable, bDetallado As Boolean, Iva As Decimal,
    '                                             FechaDesde As String, FechaHasta As String, SerieDesde As String, SerieHasta As String,
    '                                             TipoCliente As String, lstPuntoVenta As List(Of String))


    '        'Cabecera
    '        Dim Informe As New miInforme(True)
    '        Informe.Contenedor.PaperKind = Printing.PaperKind.A4
    '        Informe.Contenedor.Margins.Left = 20

    '        Dim Clientes As String = "Todos"
    '        Select Case TipoCliente
    '            Case "N"
    '                Clientes = "Nacionales"
    '            Case "C"
    '                Clientes = "Comunitarios"
    '            Case "NC"
    '                Clientes = "No comunitarios"
    '        End Select

    '        Dim PuntoVenta As String = ""
    '        For Each s As String In lstPuntoVenta
    '            If PuntoVenta.Trim <> "" Then PuntoVenta = PuntoVenta & ","
    '            PuntoVenta = PuntoVenta & s
    '        Next


    '        Informe.Cabecera(MiMaletin.NombreEmpresa, "990", milinea.stilos.Cabecera)
    '        Informe.Cabecera("LISTADO IVA REPERCUTIDO", "990", milinea.stilos.GrandeBold)
    '        If Iva <> 0 Then Informe.Cabecera("Tipo de IVA: " & Iva.ToString("#,##0.00") & " %", "990", milinea.stilos.NormalBold)
    '        If FechaDesde.Trim <> "" Or FechaHasta.Trim <> "" Then Informe.Cabecera("Desde " & FechaDesde & " hasta " & FechaHasta & "|Fecha Impresión: " & Today.ToString("dd/MM/yyyy"), " 460|>250", milinea.stilos.NormalBold)
    '        If SerieDesde.Trim <> "" Or SerieHasta.Trim <> "" Then Informe.Cabecera("Desde serie " & SerieDesde & " hasta serie " & SerieHasta, "990", milinea.stilos.NormalBold)
    '        Informe.Cabecera("Clientes: " & Clientes, "990", milinea.stilos.NormalBold)
    '        If PuntoVenta.Trim <> "" Then Informe.Cabecera("Punto Venta: " & PuntoVenta, "990", milinea.stilos.NormalBold)
    '        If bDetallado Then
    '            Informe.Cabecera("Detallar Facturas: S", "990", milinea.stilos.NormalBold)
    '        Else
    '            Informe.Cabecera("Detallar Facturas: N", "990", milinea.stilos.NormalBold)
    '        End If

    '        Informe.Cabecera("", "200", milinea.stilos.Normal)
    '        Informe.Cabecera("", "200", milinea.stilos.Normal)


    '        'Líneas de detalle
    '        Dim midetalle As New subInforme()


    '        Dim Dlin As String = "82|=46|92|46|185|92|>92|>56|>82|>56|>92|>115"
    '        Informe.Cabecera("Nº.FACT.|CE|FECHA|COD|CLIENTE|NIF|BASE IMPONIBLE|% IVA|CUOTA IVA|% R.E.|CUOTA R.EQ.|T.FACTURA", Dlin, milinea.stilos.ReducidaBoldLineaDebajo)
    '        Informe.Cabecera("", "200", milinea.stilos.Normal)


    '        If bDetallado Then

    '            Dim dtResumen As New DataTable
    '            ImprimirListadoIvaRepercutidoDetallado(dt, Informe, midetalle, Dlin, dtResumen)
    '            midetalle.Detalle("", "200", milinea.stilos.Normal)

    '            ImprimirListadoIvaRepercutidoResumido(dtResumen, Informe, midetalle, Dlin)

    '        Else

    '            ImprimirListadoIvaRepercutidoResumido(dt, Informe, midetalle, Dlin)

    '        End If




    '        'Previsualizar
    '        Informe.AñadeDetalles(midetalle)
    '        Informe.Preliminar(DevExpress.LookAndFeel.UserLookAndFeel.Default)


    '        Informe.Dispose()

    '    End Sub



    '    Private Class stClaves_IvaRepercutido
    '        Public Iva As Decimal = 0

    '        Public Sub New(Iva As Decimal)
    '            Me.Iva = Iva
    '        End Sub
    '    End Class

    '    Public Class stDatos_IvaRepercutido
    '        Public Base As Decimal = 0
    '        Public CuotaIva As Decimal = 0
    '        Public Sub New(Base As Decimal, CuotaIva As Decimal)
    '            Me.Base = Base
    '            Me.CuotaIva = CuotaIva
    '        End Sub
    '    End Class



    '    Private Sub ImprimirListadoIvaRepercutidoDetallado(dt As DataTable, ByRef Informe As miInforme, ByRef midetalle As subInforme, DLin As String, ByRef dtResumen As DataTable)


    '        Dim acum As New Acumulador

    '        Dim TotalBase As Decimal = 0
    '        Dim TotalCuotaIva As Decimal = 0
    '        Dim TotalCuotaRe As Decimal = 0
    '        Dim TotalTotalFactura As Decimal = 0



    '        For Each row As DataRow In dt.Rows

    '            Dim Factura As String = (row("Factura").ToString & "").Trim
    '            Dim IdCentro As String = (row("IdCentro").ToString & "").Trim
    '            Dim Fecha As String = ""
    '            If VaDate(row("Fecha")) <> VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
    '            Dim IdCliente As String = (row("IdCliente").ToString & "").Trim
    '            Dim Cliente As String = (row("Cliente").ToString & "").Trim
    '            Dim NIF As String = (row("NIF").ToString & "").Trim
    '            Dim Base As Decimal = VaDec(row("Base"))
    '            Dim Iva As Decimal = VaDec(row("Iva"))
    '            Dim CuotaIva As Decimal = VaDec(row("CuotaIva"))
    '            Dim Ret As Decimal = VaDec(row("Re"))
    '            Dim CuotaRe As Decimal = VaDec(row("CuotaRe"))
    '            Dim TotalFactura As Decimal = VaDec(row("TotalFactura"))

    '            TotalBase = TotalBase + Base
    '            TotalCuotaIva = TotalCuotaIva + CuotaIva
    '            TotalCuotaRe = TotalCuotaRe + CuotaRe
    '            TotalTotalFactura = TotalTotalFactura + TotalFactura

    '            Dim stClave As New stClaves_IvaRepercutido(Iva)
    '            Dim stDatos As New stDatos_IvaRepercutido(Base, CuotaIva)
    '            acum.Suma(stClave, stDatos)


    '            Dim det As String = Factura & "|"
    '            det = det & IdCentro & "|"
    '            det = det & Fecha & "|"
    '            det = det & VaInt(IdCliente).ToString("00000") & "|"
    '            det = det & Cliente & "|"
    '            det = det & NIF & "|"
    '            det = det & VaDec(row("Base")).ToString("#,##0.00") & "|"
    '            det = det & VaDec(row("Iva")).ToString("#,##0.00") & "|"
    '            det = det & VaDec(row("CuotaIva")).ToString("#,##0.00") & "|"
    '            det = det & VaDec(row("Re")).ToString("#,##0.00") & "|"
    '            det = det & VaDec(row("CuotaRe")).ToString("#,##0.00") & "|"
    '            det = det & VaDec(row("TotalFactura")).ToString("#,##0.00")

    '            midetalle.Detalle(det, DLin, milinea.stilos.Reducida)

    '        Next

    '        Dim total As String = "||||TOTAL LISTADO||"
    '        total = total & TotalBase.ToString("#,##0.00") & "||"
    '        total = total & TotalCuotaIva.ToString("#,##0.00") & "||"
    '        total = total & TotalCuotaRe.ToString("#,##0.00") & "|"
    '        total = total & TotalTotalFactura.ToString("#,##0.00")
    '        midetalle.Detalle(total, DLin, milinea.stilos.ReducidaBoldLineaEncima)


    '        dtResumen = acum.DataTable

    '    End Sub


    '    Private Sub ImprimirListadoIvaRepercutidoResumido(dt As DataTable, ByRef Informe As miInforme, ByRef midetalle As subInforme, DLin As String)


    '        Dim dv As New DataView(dt)
    '        dv.Sort = "Iva"
    '        dt = dv.ToTable

    '        For Each row As DataRow In dt.Rows

    '            Dim Base As Decimal = VaDec(row("Base"))
    '            Dim Iva As Decimal = VaDec(row("Iva"))
    '            Dim CuotaIva As Decimal = VaDec(row("CuotaIva"))


    '            Dim det As String = "||||Base Imponible|%|Cuota|||||"
    '            midetalle.Detalle(det, DLin, milinea.stilos.ReducidaBold)


    '            det = "||||"
    '            det = det & VaDec(row("Base")).ToString("#,##0.00") & "|"
    '            det = det & VaDec(row("Iva")).ToString("#,##0.00") & "|"
    '            det = det & VaDec(row("CuotaIva")).ToString("#,##0.00") & "|||||"
    '            midetalle.Detalle(det, DLin, milinea.stilos.Reducida)

    '        Next

    '    End Sub


    '#End Region


    '#Region "Saldo envases"


    '    Public Sub ImprimeSaldoEnvases(Sujeto As String, Codigo As String, NombreSujeto As String, FechaDesde As String, FechaHasta As String,
    '                                   bSoloRetornables As Boolean, lstEnvases As List(Of String))


    '        Dim dt As DataTable = GeneraDetalleSaldoEnvases(Sujeto, Codigo, FechaDesde, FechaHasta, bSoloRetornables, lstEnvases)


    '        'Cabecera
    '        Dim Informe As New miInforme(False)
    '        Informe.Contenedor.PaperKind = Printing.PaperKind.A4
    '        Informe.Contenedor.Margins.Left = 50


    '        Dim TipoSujeto As String = ""
    '        If Sujeto = "A" Then
    '            TipoSujeto = "Agricultor: "
    '        ElseIf Sujeto = "C" Then
    '            TipoSujeto = "Cliente: "
    '        End If


    '        Informe.Cabecera(MiMaletin.NombreEmpresa, "710", milinea.stilos.Cabecera)
    '        Informe.Cabecera("LISTADO DE MOVIMIENTOS DE ENVASES", "710", milinea.stilos.GrandeBold)
    '        If FechaDesde.Trim <> "" Or FechaHasta.Trim <> "" Then
    '            Informe.Cabecera(TipoSujeto & Codigo & " - " & NombreSujeto, "710", milinea.stilos.NormalBold)
    '            If FechaDesde.Trim <> "" Or FechaHasta.Trim <> "" Then Informe.Cabecera("Desde " & FechaDesde & " hasta " & FechaHasta & "|Fecha Impresión: " & Today.ToString("dd/MM/yyyy"), " 460|>250", milinea.stilos.NormalBold)
    '        End If
    '        If bSoloRetornables Then Informe.Cabecera("Solo retornables", "710", milinea.stilos.NormalBold)
    '        Informe.Cabecera("", "200", milinea.stilos.Normal)


    '        'Líneas de detalle
    '        Dim midetalle As New subInforme()


    '        Dim Dlin As String = "=70|=20|>30|5|65|100|>70|>70|>70|>70|>70|>70"
    '        Informe.Cabecera("Fecha|AL|Num||Referencia|Concepto|Retira|PrecioR|Entrega|PrecioE|Saldo|SaldoV", Dlin, milinea.stilos.MinimaBoldLineaDebajo)


    '        Dim AuxIdenvase As String = ""
    '        Dim TotEnvRetira As Decimal = 0
    '        Dim TotEnvEntrega As Decimal = 0
    '        Dim TotEnvSaldo As Decimal = 0
    '        Dim TotEnvSaldoV As Decimal = 0


    '        For Each row As DataRow In dt.Rows

    '            Dim IdEnvase As String = (row("IdEnvase").ToString & "").Trim
    '            Dim Envase As String = (row("Envase").ToString & "").Trim
    '            Dim Fecha As String = ""
    '            If VaDate(row("Fecha")) <> VaDate("") Then Fecha = VaDate(row("Fecha"))
    '            Dim AL As String = (row("AL").ToString & "").Trim
    '            If VaInt(AL) = 0 Then AL = ""
    '            Dim Numero As String = (row("Numero").ToString & "").Trim
    '            If VaInt(Numero) = 0 Then Numero = ""
    '            Dim Referencia As String = (row("Referencia").ToString & "").Trim
    '            Dim Concepto As String = (row("Concepto").ToString & "").Trim

    '            Dim Retira As Decimal = VaDec(row("Retira"))
    '            Dim PrecioR As Decimal = VaDec(row("PrecioR"))
    '            Dim Entrega As Decimal = VaDec(row("Entrega"))
    '            Dim PrecioE As Decimal = VaDec(row("PrecioE"))
    '            Dim Saldo As Decimal = VaDec(row("Saldo"))
    '            Dim SaldoV As Decimal = VaDec(row("SaldoV"))


    '            If AuxIdenvase <> IdEnvase Then

    '                If AuxIdenvase <> "" Then
    '                    'Total envase
    '                    Dim total As String = "|||||TOTAL ENVASE|"
    '                    total = total & TotEnvRetira.ToString("#,##0") & "||"
    '                    total = total & TotEnvEntrega.ToString("#,##0") & "||"
    '                    total = total & StSaldo(TotEnvSaldo) & "|"
    '                    total = total & StSaldo(TotEnvSaldoV)
    '                    midetalle.Detalle(total, Dlin, milinea.stilos.MinimaBoldLineaEncima)


    '                    TotEnvRetira = 0
    '                    TotEnvEntrega = 0
    '                    TotEnvSaldo = 0
    '                    TotEnvSaldoV = 0


    '                End If

    '                'Cabecera envase
    '                midetalle.Detalle("", "200", milinea.stilos.Normal)
    '                midetalle.Detalle(VaInt(IdEnvase).ToString("00000") & " " & Envase, "710", milinea.stilos.MinimaBoldLineaDebajo)


    '            End If

    '            TotEnvRetira = TotEnvRetira + Retira
    '            TotEnvEntrega = TotEnvEntrega + Entrega
    '            TotEnvSaldo = TotEnvSaldo + Saldo
    '            TotEnvSaldoV = TotEnvSaldoV + SaldoV



    '            Dim det As String = Fecha & "|"
    '            det = det & AL & "|"
    '            det = det & Numero & "||"
    '            det = det & Referencia & "|"
    '            det = det & Concepto & "|"
    '            det = det & Retira.ToString("#,##0") & "|"
    '            det = det & PrecioR.ToString("#,##0.00") & "|"
    '            det = det & Entrega.ToString("#,##0") & "|"
    '            det = det & PrecioE.ToString("#,##0.00") & "|"
    '            'det = det & StSaldo(Saldo) & "|"
    '            'det = det & StSaldo(SaldoV) & "|"
    '            det = det & StSaldo(TotEnvSaldo) & "|"
    '            det = det & StSaldo(TotEnvSaldoV) & "|"
    '            midetalle.Detalle(det, Dlin, milinea.stilos.Minima)


    '            AuxIdenvase = IdEnvase

    '        Next


    '        'Último total envase
    '        Dim total2 As String = "|||||TOTAL ENVASE|"
    '        total2 = total2 & TotEnvRetira.ToString("#,##0") & "||"
    '        total2 = total2 & TotEnvEntrega.ToString("#,##0") & "||"
    '        total2 = total2 & StSaldo(TotEnvSaldo) & "|"
    '        total2 = total2 & StSaldo(TotEnvSaldoV)
    '        midetalle.Detalle(total2, Dlin, milinea.stilos.MinimaBoldLineaEncima)



    '        'Previsualizar
    '        Informe.AñadeDetalles(midetalle)
    '        Informe.Preliminar(DevExpress.LookAndFeel.UserLookAndFeel.Default)


    '        Informe.Dispose()



    '    End Sub


    '    Private Class stClave_MovimientoSaldos

    '        Public IdEnvase As Integer = 0
    '        Public Envase As String = ""
    '        Public Fecha As Date = VaDate("")
    '        Public CE As Integer = 0
    '        Public AL As Integer = 0
    '        Public TV As String = ""
    '        Public Numero As Integer = 0
    '        Public Referencia As String = ""
    '        Public Concepto As String = ""
    '        Public PrecioR As Decimal = 0
    '        Public PrecioE As Decimal = 0


    '        Public Sub New(IdEnvase As Integer, Envase As String, Fecha As Date, CE As Integer, AL As Integer, TV As String, Numero As Integer,
    '                       Referencia As String, Concepto As String, PrecioR As Decimal, PrecioE As Decimal)

    '            Me.IdEnvase = IdEnvase
    '            Me.Envase = Envase
    '            Me.Fecha = Fecha
    '            Me.CE = CE
    '            Me.AL = AL
    '            Me.TV = TV
    '            Me.Numero = Numero
    '            Me.Referencia = Referencia
    '            Me.Concepto = Concepto
    '            Me.PrecioR = PrecioR
    '            Me.PrecioE = PrecioE

    '        End Sub

    '    End Class


    '    Private Class stDatos_MovimientoSaldos

    '        Public Retira As Decimal = 0
    '        Public Entrega As Decimal = 0
    '        Public Saldo As Decimal = 0
    '        Public SaldoV As Decimal = 0

    '        Public Sub New(Retira As Decimal, Entrega As Decimal, Saldo As Decimal, SaldoV As Decimal)

    '            Me.Retira = Retira
    '            Me.Entrega = Entrega
    '            Me.Saldo = Saldo
    '            Me.SaldoV = SaldoV

    '        End Sub

    '    End Class


    '    Private Function GeneraDetalleSaldoEnvases(Sujeto As String, Codigo As String, FechaDesde As String, FechaHasta As String,
    '                                               bSoloRetornables As Boolean, lstEnvases As List(Of String)) As DataTable


    '        Dim dtInicial As DataTable = GeneraDetalleSaldoEnvasesInicial(Sujeto, Codigo, FechaDesde, FechaHasta, bSoloRetornables, lstEnvases)


    '        'Movimientos de envases
    '        Dim ValeEnvase As New E_ValeEnvases(Idusuario, cn)
    '        Dim ValeEnvase_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
    '        Dim Envases As New E_Envases(Idusuario, cn)

    '        Dim consulta As New Cdatos.E_select
    '        consulta.SelCampo(ValeEnvase_Lineas.VEL_idenvase, "IdEnvase")
    '        consulta.SelCampo(Envases.ENV_Nombre, "Envase", ValeEnvase_Lineas.VEL_idenvase, Envases.ENV_IdEnvase)
    '        consulta.SelCampo(ValeEnvase.VEV_Fecha, "Fecha", ValeEnvase_Lineas.VEL_idvale)
    '        consulta.SelCampo(ValeEnvase.VEV_Idcentro, "CE")
    '        consulta.SelCampo(ValeEnvase_Lineas.VEL_idalmacen, "AL")
    '        consulta.SelCampo(ValeEnvase.VEV_Operacion, "TV")
    '        consulta.SelCampo(ValeEnvase.VEV_Numero, "Numero")
    '        consulta.SelCampo(ValeEnvase.VEV_Referencia, "Referencia")
    '        consulta.SelCampo(ValeEnvase.VEV_Concepto, "Concepto")
    '        consulta.SelCampo(ValeEnvase_Lineas.VEL_retira, "Retira")
    '        consulta.SelCampo(ValeEnvase_Lineas.VEL_precioretira, "PrecioR")
    '        consulta.SelCampo(ValeEnvase_Lineas.VEL_entrega, "Entrega")
    '        consulta.SelCampo(ValeEnvase_Lineas.VEL_precioentrega, "PrecioE")
    '        consulta.WheCampo(ValeEnvase.VEV_TipoSujeto, "=", Sujeto)
    '        If Codigo.Trim <> "" Then consulta.WheCampo(ValeEnvase.VEV_Codigo, "=", Codigo)
    '        consulta.WheCampo(ValeEnvase.VEV_Fecha, ">=", FechaDesde)
    '        consulta.WheCampo(ValeEnvase.VEV_Fecha, "<=", FechaHasta)
    '        If bSoloRetornables Then consulta.WheCampo(Envases.ENV_Retornable, "=", "S")


    '        Dim sql As String = consulta.SQL & vbCrLf
    '        If lstEnvases.Count > 0 Then
    '            sql = sql & CadenaWhereLista(ValeEnvase_Lineas.VEL_idenvase, lstEnvases, " AND ") & vbCrLf
    '        End If
    '        sql = sql + " order by VEL_IdEnvase, VEV_fecha, Numero, CE"

    '        Dim dt As DataTable = ValeEnvase.MiConexion.ConsultaSQL(sql)


    '        'Fusionamos iniciales y movimientos
    '        If Not IsNothing(dtInicial) And Not IsNothing(dt) Then
    '            dt.Merge(dtInicial)
    '            Dim dv As New DataView(dt)
    '            dv.Sort = "IdEnvase, Fecha, Numero, CE"
    '            dt = dv.ToTable
    '        End If




    '        Dim acum As New Acumulador


    '        For Each row As DataRow In dt.Rows

    '            Dim IdEnvase As String = (row("IdEnvase").ToString & "").Trim
    '            Dim Envase As String = (row("Envase").ToString & "").Trim
    '            Dim Fecha As Date = VaDate(row("Fecha"))
    '            Dim CE As String = (row("CE").ToString & "").Trim
    '            Dim AL As String = (row("AL").ToString & "").Trim
    '            Dim TV As String = (row("TV").ToString & "").Trim
    '            Dim Numero As String = (row("Numero").ToString & "").Trim
    '            Dim Referencia As String = (row("Referencia").ToString & "").Trim
    '            Dim Concepto As String = (row("Concepto").ToString & "").Trim
    '            Dim PrecioR As Decimal = VaDec(row("PrecioR"))
    '            Dim PrecioE As Decimal = VaDec(row("PrecioE"))

    '            Dim Retira As Decimal = VaDec(row("Retira"))
    '            Dim Entrega As Decimal = VaDec(row("Entrega"))



    '            Dim Saldo As Decimal = VaDec(row("Saldo"))
    '            Dim SaldoV As Decimal = VaDec(row("SaldoV"))

    '            If PrecioR = 0 Then
    '                Saldo = Saldo + Retira
    '            Else
    '                SaldoV = SaldoV + Retira
    '            End If
    '            If PrecioE = 0 Then
    '                Saldo = Saldo - Entrega
    '            Else
    '                SaldoV = SaldoV - Entrega
    '            End If


    '            Dim stClave As New stClave_MovimientoSaldos(VaInt(IdEnvase), Envase, Fecha, VaInt(CE), VaInt(AL), TV, VaInt(Numero), Referencia, Concepto, PrecioR, PrecioE)
    '            Dim stDatos As New stDatos_MovimientoSaldos(Retira, Entrega, Saldo, SaldoV)
    '            acum.Suma(stClave, stDatos)

    '        Next


    '        dt = acum.DataTable


    '        Return dt

    '    End Function


    '    Private Function GeneraDetalleSaldoEnvasesInicial(Sujeto As String, Codigo As String, FechaDesde As String, FechaHasta As String,
    '                                                      bSoloRetornables As Boolean, lstEnvases As List(Of String)) As DataTable

    '        Dim Pref As String = ""
    '        Dim TipoInicial As String = ""

    '        If Sujeto = "C" Then
    '            Pref = "CLI_"
    '            TipoInicial = "CL"
    '        ElseIf Sujeto = "A" Then
    '            Pref = "AGR_"
    '            TipoInicial = "AG"
    '        End If


    '        Dim ValeEnvases_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
    '        Dim EnvasesInicial As New E_envasesInicial(Idusuario, cn)


    '        Dim sql1 As String = "SELECT VEL_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
    '        sql1 = sql1 & " COALESCE(VEL_Retira,0) - COALESCE(VEL_Entrega,0) as Inicial," & vbCrLf
    '        sql1 = sql1 & " (COALESCE(VEL_Retira,0) - COALESCE(VEL_Entrega,0)) as InicialV," & vbCrLf
    '        sql1 = sql1 & " COALESCE(VEL_PrecioRetira,0) + COALESCE(VEL_PrecioEntrega,0) as Precio" & vbCrLf
    '        sql1 = sql1 & " FROM ValeEnvases VE" & vbCrLf
    '        sql1 = sql1 & " LEFT JOIN ValeEnvases_Lineas VL ON VEV_IDVALE = VEL_IDVALE" & vbCrLf
    '        sql1 = sql1 & " LEFT JOIN Envases ON VEL_IdEnvase = ENV_IdEnvase" & vbCrLf
    '        sql1 = sql1 & " WHERE VEV_TipoSujeto = '" & Sujeto & "'" & vbCrLf
    '        If Codigo.Trim <> "" Then sql1 = sql1 & " AND VEV_Codigo = " & Codigo & vbCrLf
    '        sql1 = sql1 & " AND VEV_Fecha >= '" & MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy") & "'" & vbCrLf
    '        sql1 = sql1 & " AND VEV_Fecha < '" & FechaDesde & "'" & vbCrLf
    '        If bSoloRetornables Then sql1 = sql1 & " AND ENV_Retornable = 'S'" & vbCrLf
    '        If lstEnvases.Count > 0 Then sql1 = sql1 & CadenaWhereLista(ValeEnvases_Lineas.VEL_idenvase, lstEnvases, " AND ") & vbCrLf


    '        Dim sql2 As String = " SELECT ENI_IdEnvase as IdEnvase, ENV_Nombre as Envase," & vbCrLf
    '        'sql2 = sql2 & " ENI_Inicial as Inicial, (COALESCE(ENI_Inicial,0) * COALESCE(ENI_Precio,0)) as InicialV," & vbCrLf
    '        sql2 = sql2 & " ENI_Inicial as Inicial, ENI_Inicial as InicialV," & vbCrLf
    '        sql2 = sql2 & " ENI_Precio as Precio"
    '        sql2 = sql2 & " FROM EnvasesInicial"
    '        sql2 = sql2 & " LEFT JOIN Envases ON ENV_IdEnvase = ENI_IdEnvase" & vbCrLf
    '        sql2 = sql2 & " WHERE ENI_Campa = " & MiMaletin.Ejercicio.ToString
    '        sql2 = sql2 & " AND ENI_Tipo = '" & TipoInicial & "'"
    '        If Codigo.Trim <> "" Then sql2 = sql2 & " AND ENI_Codigo = " & Codigo & vbCrLf
    '        If bSoloRetornables Then sql2 = sql2 & " AND ENV_Retornable = 'S'" & vbCrLf
    '        If lstEnvases.Count > 0 Then sql2 = sql2 & CadenaWhereLista(EnvasesInicial.ENI_idenvase, lstEnvases, " AND ") & vbCrLf


    '        Dim sql As String = "SELECT IdEnvase, Envase," & vbCrLf
    '        sql = sql & " SUM(Inicial) as Saldo, 0 as SaldoV" & vbCrLf
    '        sql = sql & " FROM (" & vbCrLf & sql1 & vbCrLf & ") as I" & vbCrLf
    '        sql = sql & " WHERE Precio = 0" & vbCrLf
    '        sql = sql & " GROUP BY IdEnvase, Envase" & vbCrLf
    '        sql = sql & " UNION ALL" & vbCrLf
    '        sql = sql & " SELECT IdEnvase, Envase, 0 as Saldo, SUM(InicialV) as SaldoV" & vbCrLf
    '        sql = sql & " FROM (" & vbCrLf & sql1 & vbCrLf & ") as I" & vbCrLf
    '        sql = sql & " WHERE Precio <> 0" & vbCrLf
    '        sql = sql & " GROUP BY IdEnvase, Envase" & vbCrLf
    '        sql = sql & " UNION ALL" & vbCrLf
    '        sql = sql & " SELECT IdEnvase, Envase, SUM(Inicial) as Saldo, 0 as SaldoV" & vbCrLf
    '        sql = sql & " FROM (" & vbCrLf & sql2 & vbCrLf & ") as I" & vbCrLf
    '        sql = sql & " WHERE Precio = 0" & vbCrLf
    '        sql = sql & " GROUP BY IdEnvase, Envase" & vbCrLf
    '        sql = sql & " UNION ALL" & vbCrLf
    '        sql = sql & " SELECT IdEnvase, Envase, 0 as Saldo, SUM(InicialV) as SaldoV" & vbCrLf
    '        sql = sql & " FROM (" & vbCrLf & sql2 & vbCrLf & ") as I" & vbCrLf
    '        sql = sql & " WHERE Precio <> 0" & vbCrLf
    '        sql = sql & " GROUP BY IdEnvase, Envase" & vbCrLf


    '        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    '        Dim dt As DataTable = ValeEnvases.MiConexion.ConsultaSQL(sql)


    '        Dim acum As New Acumulador

    '        Dim Fecha As Date = VaDate(FechaDesde)

    '        'Acumula los saldos iniciales en diccioniarios
    '        For Each row As DataRow In dt.Rows

    '            Dim IdEnvase As String = (row("IdEnvase").ToString & "").Trim
    '            Dim Envase As String = (row("Envase").ToString & "").Trim
    '            Dim Inicial As Integer = VaInt(row("Saldo"))
    '            Dim InicialV As Integer = VaInt(row("SaldoV"))

    '            Dim stClave As New stClave_MovimientoSaldos(VaInt(IdEnvase), Envase, Fecha, 0, 0, "", 0, "", "Saldo Inicial", 0, 0)
    '            Dim stDatos As New stDatos_MovimientoSaldos(0, 0, Inicial, InicialV)
    '            acum.Suma(stClave, stDatos)

    '        Next


    '        Return acum.DataTable

    '    End Function





    '#End Region


    'Public Sub ImprimirListadoConsumoMaterialesComparativo(ByVal dt As DataTable,
    '                                                       ByVal FamEnvaseDesde As String, ByVal FamEnvaseHasta As String,
    '                                                       ByVal FechaDesde As String, ByVal FechaHasta As String,
    '                                                       lstCentros As List(Of String), bDetallarMarcas As Boolean)

    '    Dim Centros As String = ""
    '    For Each s As String In lstCentros
    '        If Centros.Trim <> "" Then Centros = Centros & ","
    '        Centros = Centros & s
    '    Next


    '    Dim Informe As New miInforme(False)


    '    'Cabecera
    '    Informe.Contenedor.PaperKind = Printing.PaperKind.A4
    '    Informe.Contenedor.Margins.Left = 50
    '    Informe.Cabecera(MiMaletin.NombreEmpresa, "710", milinea.stilos.Cabecera)
    '    Informe.Cabecera("Consumo de materiales por fecha - Comparativo", "710", milinea.stilos.GrandeBold)
    '    If FamEnvaseDesde.Trim <> "" Or FamEnvaseHasta.Trim <> "" Then Informe.Cabecera("Desde Familia Env. " & FamEnvaseDesde & " hasta Familia Env. " & FamEnvaseHasta & "|Fecha Impresión: " & Today.ToString("dd/MM/yyyy"), "460|>250", milinea.stilos.NormalBold)
    '    If FechaDesde.Trim <> "" Or FechaHasta.Trim <> "" Then Informe.Cabecera("Desde Fecha " & FechaDesde & " hasta Fecha " & FechaHasta, "710", milinea.stilos.NormalBold)
    '    If Centros.Trim <> "" Then Informe.Cabecera("Centros: " & Centros, "710", milinea.stilos.NormalBold)
    '    If bDetallarMarcas Then Informe.Cabecera("Detallar marcas", "710", milinea.stilos.NormalBold)
    '    Informe.Cabecera("", "200", milinea.stilos.Normal)
    '    Informe.Cabecera("", "200", milinea.stilos.Normal)


    '    'Detalle
    '    Dim Dlin As String = "40|166|86|>77|>77|>55|>77|>77|>55"
    '    Dim Dlin2 As String = "40|252|>77|>77|>55|>77|>77|>55"

    '    If bDetallarMarcas Then
    '        Informe.Cabecera("Cod|Material|Marca|CantComp|ImpComp|P.M.C.|UnidsSal|ImpSal|P.M.S.", Dlin, milinea.stilos.ReducidaBoldLineaDebajo)
    '    Else
    '        Informe.Cabecera("Cod|Material|CantComp|ImpComp|P.M.C.|UnidsSal|ImpSal|P.M.S.", Dlin2, milinea.stilos.ReducidaBoldLineaDebajo)
    '    End If


    '    'Líneas de detalle
    '    Dim midetalle As New subInforme()
    '    midetalle.Detalle("", "710", milinea.stilos.ReducidaBoldLineaEncima)


    '    Dim AuxFamiliaEnvase As String = ""

    '    Dim TotalCompFam As Decimal = 0
    '    Dim TotalImpCompFam As Decimal = 0
    '    Dim TotalSalFam As Decimal = 0
    '    Dim TotalImpSalFam As Decimal = 0

    '    Dim TotalComp As Decimal = 0
    '    Dim TotalImpComp As Decimal = 0
    '    Dim TotalSal As Decimal = 0
    '    Dim TotalImpSal As Decimal = 0


    '    For Each row As DataRow In dt.Rows

    '        Dim FamiliaEnvase As String = (row("NombreFamilia").ToString & "").Trim
    '        Dim CodEnv As String = VaInt(row("IdEnvase")).ToString("00000")
    '        Dim Envase As String = row("Envase").ToString & ""
    '        Dim Comp As Decimal = VaDec(row("CantComp"))
    '        Dim ImpComp As Decimal = VaDec(row("ImpComp"))
    '        Dim PMC As Decimal = VaDec(row("PMC"))
    '        Dim Sal As Decimal = VaDec(row("UnidsSal"))
    '        Dim ImpSal As Decimal = VaDec(row("ImpSal"))
    '        Dim PMS As Decimal = VaDec(row("PMS"))



    '        If AuxFamiliaEnvase <> FamiliaEnvase Then

    '            If AuxFamiliaEnvase <> "" Then

    '                'Total Familia
    '                Dim totalFam As String = "|TOTALES FAMILIA...||"
    '                totalFam = totalFam & TotalCompFam.ToString("#,##0.00") & "|"
    '                totalFam = totalFam & TotalImpCompFam.ToString("#,##0.00") & "||"
    '                totalFam = totalFam & TotalSalFam.ToString("#,##0.00") & "|"
    '                totalFam = totalFam & TotalImpSalFam.ToString("#,##0.00") & "||"
    '                midetalle.Detalle(totalFam, Dlin, milinea.stilos.ReducidaBoldLineaEncima)
    '                midetalle.Detalle("", "200", milinea.stilos.NormalBold)


    '                TotalCompFam = 0
    '                TotalImpCompFam = 0
    '                TotalSalFam = 0
    '                TotalImpSalFam = 0

    '            End If

    '            'Titulo Familia
    '            midetalle.Detalle(FamiliaEnvase, "710", milinea.stilos.NormalBold)

    '        End If



    '        Dim det As String = CodEnv & "|"
    '        det = det & Envase & "|"
    '        If bDetallarMarcas Then
    '            Dim Marca As String = row("Marca").ToString & ""
    '            det = det & Marca
    '        End If
    '        det = det & "|"
    '        det = det & Comp.ToString("#,##0.00") & "|"
    '        det = det & ImpComp.ToString("#,##0.00") & "|"
    '        det = det & PMC.ToString("#,##0.00000") & "|"
    '        det = det & Sal.ToString("#,##0.00") & "|"
    '        det = det & ImpSal.ToString("#,##0.00") & "|"
    '        det = det & PMS.ToString("#,##0.00000")
    '        midetalle.Detalle(det, Dlin, milinea.stilos.Reducida)




    '        TotalCompFam = TotalCompFam + Comp
    '        TotalImpCompFam = TotalImpCompFam + ImpComp
    '        TotalSalFam = TotalSalFam + Sal
    '        TotalImpSalFam = TotalImpSalFam + ImpSal

    '        TotalComp = TotalComp + Comp
    '        TotalImpComp = TotalImpComp + ImpComp
    '        TotalSal = TotalSal + Sal
    '        TotalImpSal = TotalImpSal + ImpSal


    '        AuxFamiliaEnvase = FamiliaEnvase

    '    Next


    '    'Último Total Familia
    '    Dim totalFam2 As String = "|TOTALES FAMILIA...||"
    '    totalFam2 = totalFam2 & TotalCompFam.ToString("#,##0.00") & "|"
    '    totalFam2 = totalFam2 & TotalImpCompFam.ToString("#,##0.00") & "||"
    '    totalFam2 = totalFam2 & TotalSalFam.ToString("#,##0.00") & "|"
    '    totalFam2 = totalFam2 & TotalImpSalFam.ToString("#,##0.00") & "||"
    '    midetalle.Detalle(totalFam2, Dlin, milinea.stilos.ReducidaBoldLineaEncima)
    '    midetalle.Detalle("", "200", milinea.stilos.NormalBold)


    '    'Gran total
    '    Dim total As String = "|TOTALES...||"
    '    total = total & TotalComp.ToString("#,##0.00") & "|"
    '    total = total & TotalImpComp.ToString("#,##0.00") & "||"
    '    total = total & TotalSal.ToString("#,##0.00") & "|"
    '    total = total & TotalImpSal.ToString("#,##0.00") & "||"
    '    midetalle.Detalle(total, Dlin, milinea.stilos.ReducidaBoldLineaEncima)
    '    midetalle.Detalle("", "200", milinea.stilos.NormalBold)




    '    'Previsualizar
    '    Informe.AñadeDetalles(midetalle)
    '    Informe.Preliminar(DevExpress.LookAndFeel.UserLookAndFeel.Default)


    '    Informe.Dispose()

    'End Sub


    'Public Sub ImprimirInformeConsultaFacturasRecibidas(ByVal dt As DataTable, ByVal FechaDesde As String, ByVal FechaHasta As String,
    '                                           CtaDesde As String, CtaHasta As String)


    '    'Cabecera
    '    Dim Informe As New miInforme(True)
    '    Dim centr As String = ""
    '    Informe.Contenedor.PaperKind = Printing.PaperKind.A4
    '    Informe.Contenedor.Margins.Left = 20
    '    Informe.Cabecera(MiMaletin.NombreEmpresa, "990", milinea.stilos.Cabecera)
    '    Informe.Cabecera("Listado Facturas Recibidas", "990", milinea.stilos.GrandeBold)
    '    Informe.Cabecera("Desde fecha " & FechaDesde & " hasta  " & FechaHasta, " 990", milinea.stilos.NormalBold)
    '    Informe.Cabecera("Desde Cta. Prov. " & CtaDesde & " hasta Cta. Prov. " & CtaHasta & "|Fecha Impresión: " & Today.ToString("dd/MM/yyyy"), "730|>260", milinea.stilos.NormalBold)
    '    Informe.Cabecera("", "200", milinea.stilos.Normal)
    '    Informe.Cabecera("", "200", milinea.stilos.Normal)


    '    'Detalle
    '    Dim Dlin As String = "90|20|=80|320|>120|>120|>120|>120"
    '    Dim DAlb As String = "90|90|=80|>120|200"
    '    Informe.Cabecera("Factura|CE|Fecha|Proveedor|Base|CuotaIva|Ret|Total", Dlin, milinea.stilos.ReducidaBoldLineaDebajo)
    '    Informe.Cabecera("", "200", milinea.stilos.Normal)

    '    'Líneas de detalle
    '    Dim midetalle As New subInforme()

    '    Dim AuxIdFactura As String = ""
    '    Dim AuxIdAlbaran As String = ""

    '    Dim TotalAlbaranes As Decimal = 0
    '    Dim TotalBase As Decimal = 0
    '    Dim TotalCuotaIva As Decimal = 0
    '    Dim TotalRet As Decimal = 0
    '    Dim Total As Decimal = 0
    '    For Each row As DataRow In dt.Rows

    '        Dim IdFactura As String = (row("IdFactura").ToString & "").Trim
    '        Dim IdAlbaran As String = (row("IdAlbaran").ToString & "").Trim


    '        'Nueva factura
    '        If AuxIdFactura <> IdFactura Then

    '            If AuxIdFactura <> "" Then

    '                If VaInt(AuxIdAlbaran) > 0 Then
    '                    'Total suma importe albaranes
    '                    Dim totfac As String = "|TOTAL ALB.:||"
    '                    totfac = totfac & TotalAlbaranes.ToString("#,##0.00") & "|"
    '                    midetalle.Detalle(totfac, DAlb, milinea.stilos.ReducidaBoldLineaEncima)
    '                End If

    '                midetalle.Detalle("", "200", milinea.stilos.Normal)
    '                TotalAlbaranes = 0

    '            End If

    '            'Nueva factura
    '            Dim Factura As String = row("Factura").ToString
    '            Dim CE As String = row("CE").ToString
    '            Dim Fecha As String = ""
    '            If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
    '            Dim Proveedor As String = row("Proveedor").ToString
    '            Dim Base As Decimal = VaDec(row("Base"))
    '            Dim CuotaIva As Decimal = VaDec(row("CuotaIva"))
    '            Dim CuotaRet As Decimal = VaDec(row("CuotaRet"))
    '            Dim TotalFactura As Decimal = VaDec(row("TotalFactura"))

    '            Dim fac As String = Factura & "|"
    '            fac = fac & CE & "|"
    '            fac = fac & Fecha & "|"
    '            fac = fac & Proveedor & "|"
    '            fac = fac & Base.ToString("#,##0.00") & "|"
    '            fac = fac & CuotaIva.ToString("#,##0.00") & "|"
    '            fac = fac & CuotaRet.ToString("#,##0.00") & "|"
    '            fac = fac & TotalFactura.ToString("#,##0.00")
    '            midetalle.Detalle(fac, Dlin, milinea.stilos.ReducidaBold)


    '            TotalBase = TotalBase + Base
    '            TotalCuotaIva = TotalCuotaIva + CuotaIva
    '            TotalRet = TotalRet + CuotaRet
    '            Total = Total + TotalFactura

    '        End If


    '        'Albaranes
    '        If VaInt(IdAlbaran) > 0 Then

    '            Dim Albaran As String = row("Albaran").ToString
    '            Dim FechaAlbaran As String = ""
    '            If VaDate(row("FechaAlbaran")) > VaDate("") Then FechaAlbaran = VaDate(row("FechaAlbaran")).ToString("dd/MM/yyyy")
    '            Dim Importe As Decimal = VaDec(row("TotalAlb"))
    '            Dim Referencia As String = row("Referencia").ToString

    '            Dim alb As String = "|Alb. nº: " & Albaran & "|"
    '            alb = alb & FechaAlbaran & "|"
    '            alb = alb & Importe.ToString("#,##0.00") & "|Ref.: "
    '            alb = alb & Referencia
    '            midetalle.Detalle(alb, DAlb, milinea.stilos.Reducida)

    '            TotalAlbaranes = TotalAlbaranes + Importe

    '        End If


    '        AuxIdFactura = IdFactura
    '        AuxIdAlbaran = IdAlbaran

    '    Next




    '    'Previsualizar
    '    Informe.AñadeDetalles(midetalle)
    '    Informe.Preliminar(DevExpress.LookAndFeel.UserLookAndFeel.Default)


    '    Informe.Dispose()

    'End Sub


    'Public Sub ImprimirInformeSaldosEnvasesPorCentroResumido(dt As DataTable, EnvDesde As String, EnvHasta As String,
    '                                            FechaDesde As String, FechaHasta As String,
    '                                            lstPuntoVenta As List(Of String))


    '    Dim PuntoVenta As String = ""
    '    For Each s As String In lstPuntoVenta
    '        If PuntoVenta.Trim <> "" Then PuntoVenta = PuntoVenta & ","
    '        PuntoVenta = PuntoVenta & s
    '    Next


    '    'Cabecera
    '    Dim Informe As New miInforme(False)
    '    Informe.Contenedor.PaperKind = Printing.PaperKind.A4
    '    Informe.Contenedor.Margins.Left = 50
    '    Informe.Cabecera(MiMaletin.NombreEmpresa, "710", milinea.stilos.Cabecera)
    '    Informe.Cabecera("Saldo de envases por centro resumido", "710", milinea.stilos.GrandeBold)
    '    If EnvDesde <> "" Or EnvHasta <> "" Then Informe.Cabecera("Desde Envase " & EnvDesde & " hasta Envase " & EnvHasta & "|Fecha Impresión: " & Today.ToString("dd/MM/yyyy"), "460|>250", milinea.stilos.NormalBold)
    '    If FechaDesde <> "" Or FechaHasta <> "" Then Informe.Cabecera("Desde Fecha " & FechaDesde & " hasta Fecha " & FechaHasta, "710", milinea.stilos.NormalBold)
    '    If PuntoVenta <> "" Then Informe.Cabecera("Punto de Venta: " & PuntoVenta, "710", milinea.stilos.NormalBold)
    '    Informe.Cabecera("", "200", milinea.stilos.Normal)
    '    Informe.Cabecera("", "200", milinea.stilos.Normal)


    '    'Detalle
    '    Dim Dlin As String = "70|400|>120|>120"
    '    Informe.Cabecera("Codigo|Envase|Saldo Inicial|Saldo Final", Dlin, milinea.stilos.NormalBoldLineaDebajo)
    '    Informe.Cabecera("", "200", milinea.stilos.NormalBold)



    '    'Líneas de detalle
    '    Dim midetalle As New subInforme()

    '    Dim TotalIni As Decimal = 0
    '    Dim TotalFin As Decimal = 0
    '    Dim TotalAlmIni As Decimal = 0
    '    Dim TotalAlmFin As Decimal = 0

    '    Dim AuxIdAlmacen As String = ""


    '    For Each row As DataRow In dt.Rows

    '        Dim IdAlmacen As String = (row("IdAlmacen").ToString & "").Trim
    '        Dim Almacen As String = row("Almacen").ToString & ""
    '        Dim Codigo As String = VaInt(row("IdEnvase")).ToString("00000")
    '        Dim Envase As String = row("Envase").ToString & ""
    '        Dim SaldoIni As Decimal = VaDec(row("SaldoIni"))
    '        Dim SaldoFin As Decimal = VaDec(row("SaldoFin"))


    '        If AuxIdAlmacen <> IdAlmacen Then

    '            If AuxIdAlmacen <> "" Then

    '                'Total por almacén
    '                Dim totalalm As String = "|TOTAL ALM.|"
    '                totalalm = totalalm & TotalAlmIni.ToString("#,##0.00") & "|"
    '                totalalm = totalalm & TotalAlmFin.ToString("#,##0.00")
    '                midetalle.Detalle(totalalm, Dlin, milinea.stilos.NormalBoldLineaEncima)
    '                midetalle.Detalle("", "200", milinea.stilos.Normal)

    '                TotalAlmIni = 0
    '                TotalAlmFin = 0

    '            End If

    '            'Línea de almacén
    '            midetalle.Detalle(Almacen, "710", milinea.stilos.GrandeBold)
    '            midetalle.Detalle("", "710", milinea.stilos.Normal)


    '        End If


    '        Dim det As String = Codigo & "|"
    '        det = det & Envase & "|"
    '        det = det & SaldoIni.ToString("#,##0.00") & "|"
    '        det = det & SaldoFin.ToString("#,##0.00")
    '        midetalle.Detalle(det, Dlin, milinea.stilos.Normal)


    '        TotalIni = TotalIni + SaldoIni
    '        TotalFin = TotalFin + SaldoFin
    '        TotalAlmIni = TotalAlmIni + SaldoIni
    '        TotalAlmFin = TotalAlmFin + SaldoFin



    '        AuxIdAlmacen = IdAlmacen

    '    Next


    '    'Último total
    '    Dim totalalm2 As String = "|TOTAL ALM.|"
    '    totalalm2 = totalalm2 & TotalAlmIni.ToString("#,##0.00") & "|"
    '    totalalm2 = totalalm2 & TotalAlmFin.ToString("#,##0.00")
    '    midetalle.Detalle(totalalm2, Dlin, milinea.stilos.NormalBoldLineaEncima)
    '    midetalle.Detalle("", "200", milinea.stilos.Normal)


    '    'Total
    '    Dim total As String = "|TOTAL|"
    '    total = total & TotalIni.ToString("#,##0.00") & "|"
    '    total = total & TotalFin.ToString("#,##0.00")

    '    midetalle.Detalle("", "200", milinea.stilos.Normal)
    '    midetalle.Detalle(total, Dlin, milinea.stilos.NormalBoldLineaEncima)




    '    'Previsualizar
    '    Informe.AñadeDetalles(midetalle)
    '    Informe.Preliminar(DevExpress.LookAndFeel.UserLookAndFeel.Default)


    '    Informe.Dispose()

    'End Sub


    'Public Sub ImprimirInformeSaldosEnvasesPorCentroDetallado(dt As DataTable, EnvDesde As String, EnvHasta As String,
    '                                            FechaDesde As String, FechaHasta As String,
    '                                            lstPuntoVenta As List(Of String))


    '    Dim PuntoVenta As String = ""
    '    For Each s As String In lstPuntoVenta
    '        If PuntoVenta.Trim <> "" Then PuntoVenta = PuntoVenta & ","
    '        PuntoVenta = PuntoVenta & s
    '    Next


    '    'Cabecera
    '    Dim Informe As New miInforme(False)
    '    Informe.Contenedor.PaperKind = Printing.PaperKind.A4
    '    Informe.Contenedor.Margins.Left = 50
    '    Informe.Cabecera(MiMaletin.NombreEmpresa, "710", milinea.stilos.Cabecera)
    '    Informe.Cabecera("Saldo de envases por centro detallado", "710", milinea.stilos.GrandeBold)
    '    If EnvDesde <> "" Or EnvHasta <> "" Then Informe.Cabecera("Desde Envase " & EnvDesde & " hasta Envase " & EnvHasta & "|Fecha Impresión: " & Today.ToString("dd/MM/yyyy"), "460|>250", milinea.stilos.NormalBold)
    '    If FechaDesde <> "" Or FechaHasta <> "" Then Informe.Cabecera("Desde Fecha " & FechaDesde & " hasta Fecha " & FechaHasta, "710", milinea.stilos.NormalBold)
    '    If PuntoVenta <> "" Then Informe.Cabecera("Punto de Venta: " & PuntoVenta, "710", milinea.stilos.NormalBold)
    '    Informe.Cabecera("", "200", milinea.stilos.Normal)
    '    Informe.Cabecera("", "200", milinea.stilos.Normal)


    '    'Detalle
    '    'Dim Dlin As String = "70|75|280|115|>85|>85"
    '    Dim Dlin As String = "70|75|120|160|115|>85|>85"
    '    Informe.Cabecera("Num.Vale|Fecha|TipoOp|Concepto|Referencia|Entrega|Retira", Dlin, milinea.stilos.ReducidaBoldLineaDebajo)
    '    Informe.Cabecera("", "200", milinea.stilos.Normal)



    '    'Líneas de detalle
    '    Dim midetalle As New subInforme()

    '    Dim TotalEntrega As Decimal = 0
    '    Dim TotalRetira As Decimal = 0
    '    Dim TotalAlmEntrega As Decimal = 0
    '    Dim TotalAlmRetira As Decimal = 0
    '    Dim TotalEnvEntrega As Decimal = 0
    '    Dim TotalEnvRetira As Decimal = 0



    '    Dim AuxIdAlmacen As String = ""
    '    Dim AuxIdEnvase As String = ""


    '    For Each row As DataRow In dt.Rows

    '        Dim IdAlmacen As String = (row("IdAlmacen").ToString & "").Trim
    '        Dim Almacen As String = row("Almacen").ToString & ""
    '        Dim IdEnvase As String = (row("IdEnvase").ToString & "").Trim
    '        Dim Envase As String = row("Envase").ToString & ""

    '        Dim NumVale As String = row("NumVale").ToString & ""
    '        Dim Fecha As String = ""
    '        If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
    '        Dim TipoOperacion As String = (row("TipoOperacion").ToString & "").Trim
    '        Dim Concepto As String = row("Concepto").ToString & ""
    '        Dim Referencia As String = row("Referencia").ToString & ""
    '        Dim Entrega As Decimal = VaDec(row("Entrega"))
    '        Dim Retira As Decimal = VaDec(row("Retira"))



    '        'Cambio de almacén
    '        If AuxIdAlmacen <> IdAlmacen Then

    '            If AuxIdAlmacen <> "" Then

    '                'Total por envase
    '                Dim totalenv As String = "||TOTAL ENV.|||"
    '                totalenv = totalenv & TotalEnvEntrega.ToString("#,##0.00") & "|"
    '                totalenv = totalenv & TotalEnvRetira.ToString("#,##0.00")
    '                midetalle.Detalle(totalenv, Dlin, milinea.stilos.ReducidaBoldLineaEncima)
    '                midetalle.Detalle("", "200", milinea.stilos.Normal)

    '                TotalEnvEntrega = 0
    '                TotalEnvRetira = 0


    '                'Total por almacén
    '                Dim totalalm As String = "||TOTAL ALM.|||"
    '                totalalm = totalalm & TotalAlmEntrega.ToString("#,##0.00") & "|"
    '                totalalm = totalalm & TotalAlmRetira.ToString("#,##0.00")
    '                midetalle.Detalle(totalalm, Dlin, milinea.stilos.ReducidaBoldLineaEncima)
    '                midetalle.Detalle("", "200", milinea.stilos.Normal)

    '                TotalAlmEntrega = 0
    '                TotalAlmRetira = 0

    '            End If

    '            'Línea de almacén
    '            midetalle.Detalle(Almacen, "710", milinea.stilos.NormalBoldLineaDebajo)
    '            midetalle.Detalle("", "710", milinea.stilos.Normal)

    '            'Linea de envase
    '            midetalle.Detalle(Envase, "710", milinea.stilos.NormalBold)
    '            midetalle.Detalle("", "710", milinea.stilos.Normal)

    '        Else

    '            'Cambio de envase
    '            If (AuxIdEnvase <> IdEnvase) Then

    '                If AuxIdEnvase <> "" Then

    '                    'Total por envase
    '                    Dim totalenv As String = "||TOTAL ENV.|||"
    '                    totalenv = totalenv & TotalEnvEntrega.ToString("#,##0.00") & "|"
    '                    totalenv = totalenv & TotalEnvRetira.ToString("#,##0.00")
    '                    midetalle.Detalle(totalenv, Dlin, milinea.stilos.ReducidaBoldLineaEncima)
    '                    midetalle.Detalle("", "200", milinea.stilos.Normal)

    '                    TotalEnvEntrega = 0
    '                    TotalEnvRetira = 0

    '                End If

    '                'Linea de envase
    '                midetalle.Detalle(Envase, "710", milinea.stilos.NormalBold)
    '                midetalle.Detalle("", "710", milinea.stilos.Normal)

    '            End If

    '        End If



    '        Dim det As String = NumVale & "|"
    '        det = det & Fecha & "|"
    '        det = det & TipoOperacion & "|"
    '        det = det & Concepto & "|"
    '        det = det & Referencia & "|"
    '        det = det & Entrega.ToString("#,##0.00") & "|"
    '        det = det & Retira.ToString("#,##0.00")
    '        midetalle.Detalle(det, Dlin, milinea.stilos.Reducida)


    '        TotalEntrega = TotalEntrega + Entrega
    '        TotalRetira = TotalRetira + Retira
    '        TotalAlmEntrega = TotalAlmEntrega + Entrega
    '        TotalAlmRetira = TotalAlmRetira + Retira
    '        TotalEnvEntrega = TotalEnvEntrega + Entrega
    '        TotalEnvRetira = TotalEnvRetira + Retira


    '        AuxIdAlmacen = IdAlmacen
    '        AuxIdEnvase = IdEnvase

    '    Next


    '    'Último total envases
    '    Dim totalenv2 As String = "||TOTAL ENV.|||"
    '    totalenv2 = totalenv2 & TotalEnvEntrega.ToString("#,##0.00") & "|"
    '    totalenv2 = totalenv2 & TotalEnvRetira.ToString("#,##0.00")
    '    midetalle.Detalle(totalenv2, Dlin, milinea.stilos.ReducidaBoldLineaEncima)
    '    midetalle.Detalle("", "200", milinea.stilos.Normal)


    '    'Ultimo total almacén
    '    Dim totalalm2 As String = "||TOTAL ALM.|||"
    '    totalalm2 = totalalm2 & TotalAlmEntrega.ToString("#,##0.00") & "|"
    '    totalalm2 = totalalm2 & TotalAlmRetira.ToString("#,##0.00")
    '    midetalle.Detalle(totalalm2, Dlin, milinea.stilos.ReducidaBoldLineaEncima)
    '    midetalle.Detalle("", "200", milinea.stilos.Normal)


    '    'Total
    '    Dim total As String = "||TOTAL|||"
    '    total = total & TotalEntrega.ToString("#,##0.00") & "|"
    '    total = total & TotalRetira.ToString("#,##0.00")

    '    midetalle.Detalle("", "200", milinea.stilos.Normal)
    '    midetalle.Detalle(total, Dlin, milinea.stilos.ReducidaBoldLineaEncima)




    '    'Previsualizar
    '    Informe.AñadeDetalles(midetalle)
    '    Informe.Preliminar(DevExpress.LookAndFeel.UserLookAndFeel.Default)


    '    Informe.Dispose()

    'End Sub


    'Public Sub ImprimirConsultaPalets(dt As DataTable, FechaDesde As String, FechaHasta As String,
    '                                  lstPuntoVenta As List(Of String), lstFamilias As List(Of String),
    '                                  ImprimirCliente As String, EnExistencias As String, Confeccionadas As String,
    '                                  EnvasePropio As String, bMostrarPartidas As Boolean)


    '    Dim PuntoVenta As String = ""
    '    For Each s As String In lstPuntoVenta
    '        If PuntoVenta.Trim <> "" Then PuntoVenta = PuntoVenta & ","
    '        PuntoVenta = PuntoVenta & s
    '    Next

    '    Dim Familias As String = ""
    '    For Each s As String In lstFamilias
    '        If Familias.Trim <> "" Then Familias = Familias & ","
    '        Familias = Familias & s
    '    Next


    '    'Cabecera
    '    Dim Informe As New miInforme(False)
    '    Informe.Contenedor.PaperKind = Printing.PaperKind.A4
    '    Informe.Contenedor.Margins.Left = 50
    '    Informe.Cabecera(MiMaletin.NombreEmpresa, "710", milinea.stilos.Cabecera)
    '    Informe.Cabecera("Listado de existencias de palets", "710", milinea.stilos.GrandeBold)
    '    If FechaDesde <> "" Or FechaHasta <> "" Then Informe.Cabecera("Desde Fecha " & FechaDesde & " hasta Fecha " & FechaHasta & "|Fecha Impresión: " & Today.ToString("dd/MM/yyyy"), "460|>250", milinea.stilos.NormalBold)
    '    If PuntoVenta <> "" Then Informe.Cabecera("Punto de Venta: " & PuntoVenta, "710", milinea.stilos.NormalBold)
    '    If Familias <> "" Then Informe.Cabecera("Familia: " & Familias, "710", milinea.stilos.NormalBold)
    '    Informe.Cabecera(ImprimirCliente & "|" & EnExistencias, "355|>355", milinea.stilos.NormalBold)
    '    Informe.Cabecera(Confeccionadas & "|" & EnvasePropio, "355|>355", milinea.stilos.NormalBold)
    '    If bMostrarPartidas Then Informe.Cabecera("Mostrar partidas", "710", milinea.stilos.NormalBold)

    '    Informe.Cabecera("", "200", milinea.stilos.Normal)
    '    Informe.Cabecera("", "200", milinea.stilos.Normal)


    '    'Detalle
    '    Dim DGenero As String = "112|598"
    '    'Dim DPalet As String = "52|60|60|>48|124|116|90|>80|>80|"
    '    'Informe.Cabecera("Palet|Fecha|Cat/Cal|Nº|TipoPalet|Envase|Marca|Bultos|Kilos", DPalet, milinea.stilos.ReducidaBoldLineaDebajo)
    '    'Dim DPalet As String = "52|60|60|>48|124|116|70|20|>40|>60|>60|"
    '    Dim DPalet As String = "48|60|60|>48|96|88|70|20|>40|>60|>60|>60"
    '    Informe.Cabecera("Palet|Fecha|Cat/Cal|Nº|TipoPalet|Envase|Marca|Cal|Dias|Bultos|Kilos|KBrutos", DPalet, milinea.stilos.ReducidaBoldLineaDebajo)
    '    Informe.Cabecera("", "200", milinea.stilos.Normal)

    '    Dim DPartida As String = "40|70|230"


    '    'Líneas de detalle
    '    Dim midetalle As New subInforme()


    '    Dim AuxGeneroConfeccion As String = ""
    '    Dim AuxIdPalet As String = ""

    '    Dim TotalBultos As Decimal = 0
    '    Dim TotalKilos As Decimal = 0
    '    Dim TotalBrutos As Decimal = 0

    '    Dim TotalBultosGen As Decimal = 0
    '    Dim TotalKilosGen As Decimal = 0
    '    Dim TotalBrutosGen As Decimal = 0
    '    Dim TotalPaletsGen As Decimal = 0

    '    Dim TotalBultosPal As Decimal = 0
    '    Dim TotalKilosPal As Decimal = 0
    '    Dim TotalBrutosPal As Decimal = 0



    '    For Each row As DataRow In dt.Rows

    '        Dim IdGenero As Integer = VaInt(row("IdGenero"))
    '        Dim IdConfec As Integer = VaInt(row("IdConfecEnvase"))
    '        Dim GeneroConfeccion As String = IdGenero.ToString("00000") & IdConfec.ToString("00000")
    '        Dim IdPalet As String = (row("IdPalet").ToString & "").Trim

    '        Dim Cal As String = (row("Cal").ToString & "").Trim
    '        Dim Dias As String = VaInt(row("Dias")).ToString

    '        Dim Bultos As Decimal = VaDec(row("Bultos"))
    '        Dim Kilos As Decimal = VaDec(row("KilosNetos"))
    '        Dim Brutos As Decimal = VaDec(row("KgBrutos"))


    '        If AuxGeneroConfeccion = "" Or AuxGeneroConfeccion <> GeneroConfeccion Then

    '            'Total por GeneroConfección
    '            If AuxGeneroConfeccion <> "" Then
    '                Dim totGen As String = "||T.Genero:|" & TotalPaletsGen.ToString("#,##0") & "|"
    '                totGen = totGen & "|||||" & TotalBultosGen.ToString("#,##0") & "|"
    '                totGen = totGen & TotalKilosGen.ToString("#,##0") & "|"
    '                totGen = totGen & TotalBrutosGen.ToString("#,##0")
    '                midetalle.Detalle(totGen, DPalet, milinea.stilos.ReducidaBoldLineaEncima)
    '                midetalle.Detalle("", "200".Trim, milinea.stilos.NormalBold)
    '            End If


    '            TotalBultosGen = 0
    '            TotalKilosGen = 0
    '            TotalBrutosGen = 0
    '            TotalPaletsGen = 0
    '            TotalBultosPal = 0
    '            TotalKilosPal = 0
    '            TotalBrutosPal = 0


    '            Dim ConfecEnvase As String = (row("ConfecEnvase").ToString & "").Trim
    '            midetalle.Detalle(GeneroConfeccion & "|" & ConfecEnvase, DGenero, milinea.stilos.GrandeBold)

    '            AuxIdPalet = ""

    '        End If




    '        Dim Palet As String = VaInt(row("Palet")).ToString("000000")
    '        Dim Fecha As String = ""
    '        If VaDate(row("Fecha")) > VaDate("") Then Fecha = VaDate(row("Fecha")).ToString("dd/MM/yyyy")
    '        Dim Categoria As String = (row("Categoria").ToString & "").Trim
    '        Dim TipoPalet As String = (row("ConfecPalet").ToString & "").Trim
    '        Dim Envase As String = (row("Envase").ToString & "")
    '        Dim Marca As String = (row("Marca").ToString & "")

    '        Dim det As String = Palet & "|"
    '        det = det & Fecha & "|"
    '        det = det & Categoria & "|"
    '        If AuxIdPalet <> IdPalet Then
    '            det = det & "1" & "|"
    '        Else
    '            det = det & "|"
    '        End If
    '        det = det & TipoPalet & "|"
    '        det = det & Envase & "|"
    '        det = det & Marca & "|"
    '        det = det & Cal & "|"
    '        det = det & Dias & "|"
    '        det = det & Bultos.ToString("#,##0") & "|"
    '        det = det & Kilos.ToString("#,##0") & "|"
    '        det = det & Brutos.ToString("#,##0")

    '        midetalle.Detalle(det, DPalet, milinea.stilos.Reducida)


    '        TotalBultos = TotalBultos + Bultos
    '        TotalKilos = TotalKilos + Kilos
    '        TotalBrutos = TotalBrutos + Brutos
    '        TotalBultosGen = TotalBultosGen + Bultos
    '        TotalKilosGen = TotalKilosGen + Kilos
    '        TotalBrutosGen = TotalBrutosGen + Brutos
    '        TotalBultosPal = TotalBultosPal + Bultos
    '        TotalKilosPal = TotalKilosPal + Kilos
    '        TotalBrutosPal = TotalBrutosPal + Brutos


    '        If AuxIdPalet <> IdPalet Then TotalPaletsGen = TotalPaletsGen + 1




    '        If bMostrarPartidas Then

    '            Dim IdLineaPalet As String = row("IdLinea").ToString & ""

    '            Dim sql As String = "SELECT 'P' as Tipo, AEL_Muestreo as Numero, AGR_Nombre as Agricultor" & vbCrLf
    '            sql = sql & " FROM Palets_Traza" & vbCrLf
    '            sql = sql & " INNER JOIN AlbEntrada_Lineas ON AEL_IdLinea = PLT_IdLineaEntrada" & vbCrLf
    '            sql = sql & " LEFT JOIN AlbEntrada ON AEN_IdAlbaran = AEL_IdAlbaran" & vbCrLf
    '            sql = sql & " LEFT JOIN Agricultores on AGR_IdAgricultor = AEN_IdAgricultor" & vbCrLf
    '            sql = sql & " WHERE PLT_IdLineaPalet = " & IdLineaPalet
    '            sql = sql & " AND COALESCE(PLT_IdProgramaCliente,0) = 0" & vbCrLf
    '            sql = sql & " UNION ALL" & vbCrLf
    '            sql = sql & " SELECT 'L' as Tipo, LTE_Lote as Numero, '' as Agricultor" & vbCrLf
    '            sql = sql & " FROM Palets_Traza" & vbCrLf
    '            sql = sql & " INNER JOIN Lotes ON LTE_IdLote = PLT_IdLote" & vbCrLf
    '            sql = sql & " WHERE PLT_IdLineaPalet = " & IdLineaPalet & vbCrLf
    '            sql = sql & " AND COALESCE(PLT_IdProgramaCliente,0) = 0" & vbCrLf
    '            sql = sql & " UNION ALL" & vbCrLf
    '            sql = sql & " SELECT 'C' as Tipo, LPD_Lote as Numero, '' as Agricultor" & vbCrLf
    '            sql = sql & " FROM Palets_Traza" & vbCrLf
    '            sql = sql & " INNER JOIN LotesProduccion ON LPD_IdLote = PLT_IdPrecalibrado" & vbCrLf
    '            sql = sql & " WHERE PLT_IdLineaPalet = " & IdLineaPalet & vbCrLf
    '            sql = sql & " AND COALESCE(PLT_IdProgramaCliente,0) = 0" & vbCrLf


    '            Dim dtPartida As DataTable = cn.ConsultaSQL(sql)
    '            If Not IsNothing(dtPartida) Then
    '                For Each rowPartida As DataRow In dtPartida.Rows

    '                    Dim Tipo As String = (rowPartida("Tipo").ToString & "").ToUpper.Trim
    '                    Dim Numero As String = (rowPartida("Numero").ToString & "").Trim
    '                    Dim Agricultor As String = (rowPartida("Agricultor").ToString & "").Trim

    '                    Select Case Tipo
    '                        Case "P"
    '                            Tipo = "Partida: "
    '                        Case "L"
    '                            Tipo = "Lote: "
    '                        Case "C"
    '                            Tipo = "P.Semi.: "
    '                    End Select

    '                    midetalle.Detalle(Tipo & "|" & Numero & "|" & Agricultor, DPartida, milinea.stilos.Minima)
    '                Next
    '            End If

    '        End If



    '        AuxGeneroConfeccion = GeneroConfeccion
    '        AuxIdPalet = IdPalet

    '    Next



    '    'Número de palets diferentes
    '    Dim TotalPalets As Integer = 0

    '    Dim DcPalet As New Dictionary(Of Integer, Integer)
    '    For indice As Integer = 0 To dt.Rows.Count - 1

    '        Dim row As DataRow = dt.Rows(indice)
    '        If Not IsNothing(row) Then
    '            Dim IdPalet As Integer = VaInt(row("IdPalet"))
    '            If Not DcPalet.ContainsKey(IdPalet) Then
    '                DcPalet(IdPalet) = IdPalet
    '                TotalPalets = TotalPalets + 1
    '            End If
    '        End If

    '    Next



    '    'Último total por género
    '    Dim totGen2 As String = "||T.Genero:|" & TotalPaletsGen.ToString("#,##0") & "|"
    '    totGen2 = totGen2 & "|||||" & TotalBultosGen.ToString("#,##0") & "|"
    '    totGen2 = totGen2 & TotalKilosGen.ToString("#,##0") & "|"
    '    totGen2 = totGen2 & TotalBrutosGen.ToString("#,##0")
    '    midetalle.Detalle(totGen2, DPalet, milinea.stilos.ReducidaBoldLineaEncima)
    '    midetalle.Detalle("", "200".Trim, milinea.stilos.NormalBold)


    '    'Gran total
    '    Dim tot As String = "||T.Genero:|" & TotalPalets.ToString("#,##0") & "|"
    '    tot = tot & "|||||" & TotalBultos.ToString("#,##0") & "|"
    '    tot = tot & TotalKilos.ToString("#,##0") & "|"
    '    tot = tot & TotalBrutos.ToString("#,##0")
    '    midetalle.Detalle(tot, DPalet, milinea.stilos.ReducidaBoldLineaEncima)
    '    midetalle.Detalle("", "200".Trim, milinea.stilos.NormalBold)




    '    'Previsualizar
    '    Informe.AñadeDetalles(midetalle)
    '    Informe.Preliminar(DevExpress.LookAndFeel.UserLookAndFeel.Default)


    '    Informe.Dispose()


    'End Sub



    ' ###COMPROBAR_INFORME###
    'Public Sub ImprimirInformeConsultaFacturas(ByVal dt As DataTable, ByVal ClienteDesde As String,
    '                                         ByVal ClienteHasta As String, ByVal FechaDesde As String, ByVal FechaHasta As String,
    '                                         MostrarContabilizadas As String, lstPuntoVenta As List(Of String))
    '    'Listado Cuadres
    '    If ClienteDesde.Trim = "" Then
    '        ClienteDesde = "00001"
    '    Else
    '        ClienteDesde = VaInt(ClienteDesde).ToString("00000")
    '    End If
    '    If ClienteHasta.Trim = "" Then
    '        ClienteHasta = "99999"
    '    Else
    '        ClienteHasta = VaInt(ClienteHasta).ToString("00000")
    '    End If

    '    Dim contabilizadas As String = ""
    '    If MostrarContabilizadas = "S" Then
    '        contabilizadas = "CONTABILIZADAS"
    '    ElseIf MostrarContabilizadas = "N" Then
    '        contabilizadas = "NO CONTABILIZADAS"
    '    End If


    '    Dim PuntoVenta As String = ""
    '    For Each s As String In lstPuntoVenta
    '        If PuntoVenta.Trim <> "" Then PuntoVenta = PuntoVenta & ","
    '        PuntoVenta = PuntoVenta & s
    '    Next


    '    'Cabecera
    '    Dim Informe As New miInforme(True)
    '    Dim centr As String = ""
    '    Informe.Contenedor.PaperKind = Printing.PaperKind.A4
    '    Informe.Contenedor.Margins.Left = 20
    '    Informe.Cabecera(MiMaletin.NombreEmpresa, "990", milinea.stilos.Cabecera)
    '    Informe.Cabecera("Listado Facturas", "990", milinea.stilos.GrandeBold)
    '    Informe.Cabecera("Desde Cliente " & ClienteDesde & " hasta  " & ClienteHasta & "|Fecha Impresión: " & Today.ToString("dd/MM/yyyy"), "730|>260", milinea.stilos.NormalBold)
    '    Informe.Cabecera("Desde fecha " & FechaDesde & " hasta  " & FechaHasta, " 990", milinea.stilos.NormalBold)
    '    If PuntoVenta.Trim <> "" Then Informe.Cabecera("Punto de Venta: " & PuntoVenta, " 990", milinea.stilos.NormalBold)
    '    If contabilizadas.Trim <> "" Then Informe.Cabecera(contabilizadas, " 990", milinea.stilos.NormalBold)


    '    ' Informe.Cabecera("Centros: " & centr, "990", milinea.stilos.NormalBold)
    '    Informe.Cabecera("", "200", milinea.stilos.Normal)
    '    Informe.Cabecera("", "200", milinea.stilos.Normal)
    '    'Detalle

    '    Dim Dlin As String = "70|100|60|160|200|>125|>120|>160"
    '    Informe.Cabecera("Serie|Factura|Fecha|Punto de Venta|Cliente|Base|CuotaIva|Total", Dlin, milinea.stilos.ReducidaBoldLineaDebajo)
    '    'Líneas de detalle

    '    Dim midetalle As New subInforme()
    '    Dim AuxCod As Integer = 0
    '    Dim Base As Decimal = 0
    '    Dim CuotaIva As Decimal = 0
    '    Dim Impor As Decimal = 0
    '    Dim TotalBase As Decimal = 0
    '    Dim TotalCuotaIva As Decimal = 0
    '    Dim TotalImpor As Decimal = 0
    '    For Each row As DataRow In dt.Rows

    '        'Cabecera por factura

    '        Dim IdPedido As Integer = VaInt(row("Factura"))
    '        If IdPedido = 0 Or IdPedido <> AuxCod Then

    '            'Linea total por factura
    '            If AuxCod <> 0 Then
    '                midetalle.Detalle("", "990", milinea.stilos.ReducidaBoldLineaEncima)
    '                midetalle.Detalle("TOTAL: |" & Base.ToString("#,##0.00") & "|" & _
    '                     CuotaIva.ToString("#,##0.00") & "|" &
    '                     Impor.ToString("#,##0.00") & "|", "60|>650|>120|>160|50", milinea.stilos.ReducidaBoldLineaEncima)
    '                Base = 0
    '                CuotaIva = 0
    '                Impor = 0
    '            End If

    '            'Cabecera nueva factura


    '        End If

    '        Dim det As String = row("Serie").ToString + "|"
    '        det = det + row("Factura").ToString + "|"
    '        det = det + row("Fecha").ToString + "|"
    '        det = det + row("PVenta").ToString + "|"
    '        det = det + row("Cliente").ToString + "|"
    '        det = det + Format(row("Base"), "#,##0.00") + "|"
    '        det = det + Format(row("CuotaIva"), "#,##0.00") + "|"
    '        det = det + Format(row("Total"), "#,##0.00") + "|"

    '        midetalle.Detalle(det, Dlin, milinea.stilos.Reducida)
    '        AuxCod = IdPedido

    '        Base = Base + VaDec(row("Base"))
    '        CuotaIva = CuotaIva + VaDec(row("CuotaIva"))
    '        Impor = Impor + VaDec(row("Total"))
    '        TotalBase = TotalBase + VaDec(row("Base"))
    '        TotalCuotaIva = TotalCuotaIva + VaDec(row("CuotaIva"))
    '        TotalImpor = TotalImpor + VaDec(row("Total"))
    '    Next

    '    midetalle.Detalle("TOTAL: |" & Base.ToString("#,##0.00") & "|" & _
    '                     CuotaIva.ToString("#,##0.00") & "|" &
    '                     Impor.ToString("#,##0.00") & "|", "60|>650|>120|>160|50", milinea.stilos.ReducidaBoldLineaEncima)
    '    midetalle.Detalle("", 200, milinea.stilos.Reducida)

    '    midetalle.Detalle("TOTAL: |" & TotalBase.ToString("#,##0.00") & "|" & _
    '                      TotalCuotaIva.ToString("#,##0.00") & "|" &
    '                      TotalImpor.ToString("#,##0.00") & "|", "60|>650|>120|>160|50", milinea.stilos.ReducidaBoldLineaEncima)

    '    'Previsualizar
    '    Informe.AñadeDetalles(midetalle)
    '    Informe.Preliminar(DevExpress.LookAndFeel.UserLookAndFeel.Default)


    '    Informe.Dispose()

    'End Sub



End Module

