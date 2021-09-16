Module Varios


    Function ObtenerGeneroIdioma(IdIdioma As String, IdGenero As String) As String

        Dim Genero As String = ""


        If VaInt(IdIdioma) > 0 And VaInt(IdGenero) > 0 And VaInt(IdIdioma) <> 1 Then

            Dim DescripcionGeneroPorIdioma As New E_DescripcionGeneroPorIdioma(Idusuario, cn)
            Dim sql As String = "SELECT DGI_Descripcion as Genero FROM DescripcionGeneroPorIdioma WHERE DGI_IdGenero = " & IdGenero & " AND DGI_IdIdioma = " & IdIdioma & vbCrLf

            Dim dt As DataTable = descripcionGeneroporidioma.MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then
                For Each r As DataRow In dt.Rows

                    Genero = (r("Genero").ToString & "").Trim

                Next
            End If
        End If



        Return Genero

    End Function



    Public Sub Agro_ActualizaTarasEnvase(ByVal idmaterial As String)
        Dim sql As String
        Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
        Dim ConfecEnvaseLineas As New E_ConfecEnvaseLineas(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)
        Dim Ttara As Double = 0
        Dim Tcoste As Double = 0

        Dim consulta1 As New Cdatos.E_select
        consulta1.SelCampo(ConfecEnvaseLineas.CEL_Idconfec, "Idconfec")
        consulta1.WheCampo(ConfecEnvaseLineas.CEL_Idmaterial, "=", idmaterial)
        sql = consulta1.SQL
        Dim dt As DataTable = ConfecEnvaseLineas.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                Dim consulta2 As New Cdatos.E_select
                consulta2.SelCampo(ConfecEnvaseLineas.CEL_Cantidad, "Cantidad")
                consulta2.SelCampo(ConfecEnvaseLineas.CEL_Idmaterial, "idmaterial")
                consulta2.SelCampo(Envases.ENV_TaraSalida, "Tara", ConfecEnvaseLineas.CEL_Idmaterial)
                consulta2.SelCampo(Envases.ENV_CosteSalida, "Coste")
                consulta2.WheCampo(ConfecEnvaseLineas.CEL_Idconfec, "=", rw("Idconfec").ToString)
                Dim dt2 As DataTable = ConfecEnvaseLineas.MiConexion.ConsultaSQL(consulta2.SQL)
                Ttara = 0
                Tcoste = 0
                If Not dt2 Is Nothing Then
                    For Each rw2 In dt2.Rows
                        Ttara = Ttara + (VaDec(rw2("Tara")) * VaDec(rw2("Cantidad")))
                        Tcoste = Tcoste + VaDec(rw2("Cantidad")) * VaDec(rw2("Coste"))
                    Next
                End If

                If ConfecEnvase.LeerId(rw("idconfec").ToString) = True Then
                    ConfecEnvase.CEV_TotalTara.Valor = (Ttara + VaDec(ConfecEnvase.CEV_IncrementoTara.Valor)).ToString
                    ConfecEnvase.CEV_TotalCoste.Valor = Tcoste.ToString
                    ConfecEnvase.Actualizar()
                End If

            Next
        End If


    End Sub

    Public Sub Agro_ActualizaTarasPalet(ByVal idmaterial As String)
        Dim sql As String
        Dim Confecpalet As New E_ConfecPalet(Idusuario, cn)
        Dim ConfecpaletLineas As New E_ConfecPaletLineas(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)
        Dim Ttara As Double = 0
        Dim Tcoste As Double = 0
        
        Dim consulta1 As New Cdatos.E_select
        consulta1.SelCampo(ConfecpaletLineas.CPL_Idconfec, "Idconfec")
        consulta1.WheCampo(ConfecpaletLineas.CPL_Idmaterial, "=", idmaterial)
        sql = consulta1.SQL + " order by CPL_idlinea"
        Dim dt As DataTable = ConfecpaletLineas.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
              
                Dim consulta2 As New Cdatos.E_select
                consulta2.SelCampo(ConfecpaletLineas.CPL_Cantidad, "Cantidad")
                consulta2.SelCampo(Envases.ENV_TaraSalida, "Tara", ConfecpaletLineas.CPL_Idmaterial)
                consulta2.SelCampo(Envases.ENV_CosteSalida, "Coste")
                consulta2.WheCampo(ConfecpaletLineas.CPL_Idconfec, "=", rw("Idconfec").ToString)
                Dim dt2 As DataTable = ConfecpaletLineas.MiConexion.ConsultaSQL(consulta2.SQL)
                Ttara = 0
                Tcoste = 0
                If Not dt2 Is Nothing Then
                    For Each rw2 In dt2.Rows
                        Ttara = Ttara + (VaDec(rw2("Tara")) * VaDec(rw2("Cantidad")))
                        Tcoste = Tcoste + VaDec(rw2("Cantidad")) * VaDec(rw2("Coste"))
                    Next
                End If

                If Confecpalet.LeerId(rw("idconfec").ToString) = True Then
                    Confecpalet.CPA_TotalTara.Valor = (Ttara + VaDec(Confecpalet.CPA_IncrementoTara.Valor)).ToString
                    Confecpalet.CPA_TotalCoste.Valor = Tcoste.ToString
                    Confecpalet.Actualizar()
                End If

            Next
        End If


    End Sub


    Public Function AGRO_DevolucionClientes(ByVal Idcliente As String, ByVal idenvase As String, ByVal fecha As String, ByVal Cantidad As Integer) As DataTable


        ' devuelve un dt con las devoluciones asignadas por precio

        Dim Envasesinicial As New E_envasesInicial(Idusuario, cn)
        Dim ret As New DataTable
        Dim sql As String = ""

        'creamos el datatable

        ret.Columns.Add(New DataColumn("Precio", GetType(Decimal)))
        ret.Columns.Add(New DataColumn("Saldo", GetType(Integer)))
        ret.Columns.Add(New DataColumn("Devolucion", GetType(Integer)))


        ' obtenemos un datatable con los saldos iniciales del cliente

        Dim Consulta1 As New Cdatos.E_select
        Consulta1.SelCampo(Envasesinicial.ENI_inicial, "Cantidad")
        Consulta1.SelCampo(Envasesinicial.ENI_precio, "Precio")
        Consulta1.WheCampo(Envasesinicial.ENI_campa, "=", MiMaletin.Ejercicio.ToString)
        Consulta1.WheCampo(Envasesinicial.ENI_tipo, "=", "CL")
        Consulta1.WheCampo(Envasesinicial.ENI_codigo, "=", Idcliente)
        Consulta1.WheCampo(Envasesinicial.ENI_idenvase, "=", idenvase)
        sql = Consulta1.SQL
        Dim dti As DataTable = Envasesinicial.MiConexion.ConsultaSQL(sql)

        If Not dti Is Nothing Then
            For Each rw In dti.Rows
                Dim precio As Decimal = VaDec(rw("precio"))
                Dim uds As Decimal = VaDec(rw("cantidad"))
                ret = agrupadevolucion(ret, precio, uds)
            Next
        End If


        'obtenemos un datatable con el saldo de este envase y cliente agrupado por precio
        sql = "SELECT     SUM(valeenvases_lineas.VEL_retira) AS Retira, "
        sql = sql + " SUM(valeenvases_lineas.VEL_entrega) AS Entrega, "
        sql = sql + " valeenvases_lineas.VEL_precioretira as PrecioRetira, "
        sql = sql + " valeenvases_lineas.VEL_precioentrega as PrecioEntrega "
        sql = sql + " FROM         valeenvases_lineas INNER JOIN"
        sql = sql + " valeenvases ON valeenvases_lineas.VEL_idvale = valeenvases.VEV_idvale "
        sql = sql + " where VEL_idenvase=" + idenvase
        sql = sql + " and VEV_codigo=" + Idcliente
        sql = sql + " and VEV_tiposujeto='C'"
        sql = sql + " and VEV_fecha<='" + fecha + "'"
        sql = sql + " GROUP BY valeenvases_lineas.VEL_precioretira, valeenvases_lineas.VEL_precioentrega"
        Dim dte As DataTable = Envasesinicial.MiConexion.ConsultaSQL(sql)

        If Not dte Is Nothing Then
            For Each rw In dte.Rows
                Dim retira As Decimal = VaDec(rw("Retira"))
                Dim entrega As Decimal = VaDec(rw("Entrega"))
                Dim Precioretira As Decimal = VaDec(rw("PrecioRetira"))
                Dim Precioentrega As Decimal = VaDec(rw("PrecioEntrega"))
                ret = AgrupaDevolucion(ret, Precioretira, retira)
                ret = AgrupaDevolucion(ret, Precioentrega, -entrega)

            Next
        End If

        Dim dv As New DataView(ret)
        dv.Sort = "Precio DESC"
        ret = dv.ToTable

        Dim c As Decimal = Cantidad
        For Each rw In ret.Rows
            If VaDec(rw("Saldo")) > c Then
                rw("Devolucion") = c
                c = 0
            ElseIf VaDec(rw("Saldo")) > 0 Then
                rw("Devolucion") = rw("Saldo")
                c = c - VaDec(rw("saldo"))
            End If
        Next
        If c > 0 Then

            Dim row As DataRow = ret.NewRow()
            row("Precio") = 0
            row("Saldo") = c
            row("Devolucion") = c
            ret.Rows.Add(row)


        End If

        Dim dv2 As New DataView(ret)
        dv2.RowFilter = "Saldo<>0"
        ret = dv2.ToTable


        Return ret

    End Function

    Private Function AgrupaDevolucion(ByVal dt As DataTable, ByVal Precio As Decimal, ByVal Cantidad As Decimal) As DataTable

        If Cantidad = 0 Then
            Return dt
        End If

        Dim saldo As Decimal = 0
        Dim Existe As Boolean = False

        For Each rw In dt.Rows
            If VaDec(rw("Precio")) = Precio Then
                saldo = VaDec(rw("saldo"))
                rw("Saldo") = saldo + Cantidad
                Existe = True
            End If
        Next

        If Existe = False Then
            Dim row As DataRow = dt.NewRow()
            row("Precio") = Precio
            row("Saldo") = Cantidad
            row("Devolucion") = 0
            dt.Rows.Add(row)

        End If

        Return dt


    End Function

    Private Class stClaves_genero3

        Public Idgenero As Integer = 0
        Public IdCliente As Integer = 0

        Public Sub New(ByVal Idgenero As Integer, ByVal IdCliente As Integer)
            Me.Idgenero = Idgenero
            Me.IdCliente = IdCliente
        End Sub

    End Class


    Private Class stdatos_genero3

        Public Bultos As Double = 0
        Public Kilos As Double = 0
        Public Importe As Double = 0
        Public KilosConf As Double = 0

        Public Sub New(ByVal bultos As Double, kilos As Double, Importe As Double, kilosConf As Double)
            Me.Bultos = bultos
            Me.Kilos = kilos
            Me.Importe = Importe
            Me.KilosConf = kilosConf
        End Sub

    End Class



    Public Function ControlaFecha(Fecha As String) As String

        Dim ret As String = ""


        If Fecha <> "" Then

            If VaDate(Fecha) < MiMaletin.FechaInicioEjercicio Or VaDate(Fecha) > MiMaletin.FechaFinEjercicio Then
                ret = "Fecha fuera del ejercicio"
            End If

        End If



        Return ret

    End Function
    


End Module
