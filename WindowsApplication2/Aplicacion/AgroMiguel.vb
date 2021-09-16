Module AgroMiguel

    Dim Valorespventa As New E_valorespventa(Idusuario, cn)
    Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
    Dim Albsalida_gastos As New E_albsalida_gastos(Idusuario, cn)
    Dim GastosClientes As New E_GastosClientes(Idusuario, cn)
    Dim Tarifalineas As New E_TarifaClientesLineas(Idusuario, cn)

   

    Private Sub CopiarGastosCliente(ByVal idalbaran As String, ByVal idcliente As String, ByVal centro As String)
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(GastosClientes.GCL_IdGasto, "IdGasto")
        consulta.SelCampo(GastosClientes.GCL_ValorGasto, "ValorGasto")
        consulta.WheCampo(GastosClientes.GCL_IdCliente, "=", idcliente)
        consulta.WheCampo(GastosClientes.GCL_IdCentro, "=", centro)
        consulta.WheCampo(GastosClientes.GCL_TipoAFC, "=", "A")
        Dim dt As DataTable = GastosClientes.MiConexion.ConsultaSQL(consulta.SQL)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                Dim id As String = Albsalida_gastos.MaxId
                Albsalida_gastos.VaciaEntidad()
                Albsalida_gastos.ASG_id.Valor = id
                Albsalida_gastos.ASG_idgasto.Valor = rw("idgasto").ToString
                Albsalida_gastos.ASG_valorgasto.Valor = rw("valorgasto").ToString
                Albsalida_gastos.ASG_idalbaran.Valor = idalbaran
                Albsalida_gastos.Insertar()

            Next
        End If


    End Sub
    Private Sub CopiarTarifaCliente(ByVal idalbaran As String, ByVal idtarifa As String)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Tarifalineas.TCL_IdGasto)
        consulta.SelCampo(Tarifalineas.TCL_ValorGasto)
        consulta.WheCampo(Tarifalineas.TCL_IdTarifa, "=", idtarifa)
        Dim dt As DataTable = Tarifalineas.MiConexion.ConsultaSQL(consulta.SQL)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                Dim id As String = Albsalida_gastos.MaxId
                Albsalida_gastos.VaciaEntidad()
                Albsalida_gastos.ASG_id.Valor = id
                Albsalida_gastos.ASG_idgasto.Valor = rw("idgasto").ToString
                Albsalida_gastos.ASG_valorgasto.Valor = rw("valorgasto").ToString
                Albsalida_gastos.ASG_idalbaran.Valor = idalbaran
                Albsalida_gastos.Insertar()

            Next
        End If

    End Sub

End Module
