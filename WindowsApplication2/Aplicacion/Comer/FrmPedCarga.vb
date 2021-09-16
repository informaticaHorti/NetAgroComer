Public Class FrmPedCarga
    Dim _idpedido As Integer
    Dim _idalbaran As Integer
    Dim dtg As New DataTable

    Public Sub InitPedido(idpedido As Integer, idalbaran As Integer)
        Dim clientes As New E_Clientes(Idusuario, cn)
        Dim pedidos As New E_Pedidos(Idusuario, cn)
        Dim albsalida As New E_AlbSalida(Idusuario, cn)
        _idpedido = idpedido
        _idalbaran = idalbaran
        If pedidos.LeerId(idpedido) = True Then
            Lbpedido.Text = pedidos.PED_pedido.Valor
            If clientes.LeerId(pedidos.PED_idcliente.Valor) = True Then
                LbCliente.Text = clientes.CLI_Nombre.Valor
            End If
        End If
        If albsalida.LeerId(idalbaran) = True Then
            LbAlbaran.Text = albsalida.ASA_albaran.Valor
        End If
        dtg.Columns.Add("idgensal", GetType(System.Int32))
        dtg.Columns.Add("idcat", GetType(System.Int32))
        dtg.Columns.Add("idmarca", GetType(System.Int32))
        dtg.Columns.Add("Genero", GetType(System.String))
        dtg.Columns.Add("Categoria", GetType(System.String))
        dtg.Columns.Add("Marca", GetType(System.String))
        dtg.Columns.Add("PED", GetType(System.Int32))
        dtg.Columns.Add("CAR", GetType(System.Int32))
        dtg.Columns.Add("DIF", GetType(System.Int32))
       
        ActualizaDatos()
    End Sub

    Private Sub ActualizaDatos()
        Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)
        Dim palets As New E_palets(Idusuario, cn)
        Dim palets_lineas As New E_palets_lineas(Idusuario, cn)
        Dim albsalida_palets As New E_albsalida_palets(Idusuario, cn)
        Dim GeneroSalida As New E_GenerosSalida(Idusuario, cn)
        Dim CategoriasComercial As New E_CategoriasComercial(Idusuario, cn)
        Dim Categoriassalida As New E_CategoriasSalida(Idusuario, cn)
        Dim Marcas As New E_Marcas(Idusuario, cn)
        Dim consulta1 As New Cdatos.E_select




        For Each RW In dtg.Rows
            RW("PED") = 0
            RW("CAR") = 0
            RW("DIF") = 0
        Next
        LbPalped.Text = ""
        LbPalPte.Text = ""
        LbParCar.Text = ""

        consulta1.SelCampo(Pedidos_Lineas.PEL_idgensal, "idgensal")
        consulta1.SelCampo(Pedidos_Lineas.PEL_idcategoria, "idcat")
        consulta1.SelCampo(Pedidos_Lineas.PEL_idmarca, "idmarca")
        consulta1.SelCampo(GeneroSalida.GES_Nombre, "Genero", Pedidos_Lineas.PEL_idgensal)
        consulta1.SelCampo(CategoriasComercial.CAC_Nombre, "Categoria", Pedidos_Lineas.PEL_idcategoria)
        consulta1.SelCampo(Marcas.MAR_Nombre, "Marca", Pedidos_Lineas.PEL_idmarca)
        consulta1.SelCampo(Pedidos_Lineas.PEL_palets, "palets")
        consulta1.WheCampo(Pedidos_Lineas.PEL_idpedido, "=", _idpedido.ToString)
        Dim sql As String = consulta1.SQL
        Dim dt As DataTable = Pedidos_Lineas.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                Lgrid(VaInt(rw("idgensal")), VaInt(rw("idcat")), VaInt(rw("idmarca")), rw("genero").ToString, rw("Categoria").ToString, rw("Marca").ToString, VaInt(rw("palets")), 0)
                LbPalped.Text = (VaInt(LbPalped.Text) + VaInt(rw("PALETS"))).ToString
                LbPalPte.Text = (VaInt(LbPalped.Text) - VaInt(LbParCar.Text)).ToString
            Next
        End If

        Dim consulta2 As New Cdatos.E_select
        consulta2.SelCampo(palets_lineas.PLL_idpalet, "idpalet")
        consulta2.SelCampo(palets_lineas.PLL_idgensal, "idgensal")
        consulta2.SelCampo(palets_lineas.PLL_idcategoria, "idcat")
        consulta2.SelCampo(palets_lineas.PLL_idmarca, "idmarca")
        consulta2.SelCampo(palets_lineas.PLL_idmarca, "idmarca")
        consulta2.SelCampo(GeneroSalida.GES_Nombre, "Genero", palets_lineas.PLL_idgensal)
        consulta2.SelCampo(Categoriassalida.CAS_CategoriaCalibre, "Categoria", palets_lineas.PLL_idcategoria)
        consulta2.SelCampo(Marcas.MAR_Nombre, "Marca", palets_lineas.PLL_idmarca)
        consulta2.SelCampo(albsalida_palets.ASP_IdAlbaran, "idalbaran", palets_lineas.PLL_idpalet, albsalida_palets.ASP_Idpalet)
        consulta2.WheCampo(albsalida_palets.ASP_IdAlbaran, "=", _idalbaran.ToString)
        sql = consulta2.SQL
        sql = sql + " order by pll_idpalet "
        dt = palets_lineas.MiConexion.ConsultaSQL(sql)
        Dim idp As Integer = 0
        Dim p As Integer = 0
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                If VaInt(rw("idpalet")) <> idp Then
                    p = 1
                Else
                    p = 0
                End If

                Lgrid(VaInt(rw("idgensal")), VaInt(rw("idcat")), VaInt(rw("idmarca")), rw("genero").ToString, rw("Categoria").ToString, rw("Marca").ToString, 0, p)
                LbParCar.Text = (VaInt(LbParCar.Text) + 1).ToString
                LbPalPte.Text = (VaInt(LbPalped.Text) - VaInt(LbParCar.Text)).ToString

            Next
        End If
        Grid.DataSource = dtg
        AjustaColumnas()
    End Sub
    Private Sub Lgrid(idgensal As Integer, idcategoria As Integer, idmarca As Integer, Genero As String, Categoria As String, Marca As String, pedidos As Integer, cargados As Integer)

        Dim s As Boolean = False
        Dim CatSalidaComercial As New E_CatSalidaComercial(Idusuario, cn)

        If pedidos > 0 Then
            For Each RW In dtg.Rows
                If VaInt(RW("idgensal")) = idgensal And VaInt(RW("idcat")) = idcategoria And VaInt(RW("idmarca")) = idmarca Then
                    RW("PED") = VaInt(RW("PED")) + pedidos
                    RW("CAR") = VaInt(RW("CAR")) + cargados
                    RW("DIF") = VaInt(RW("PED")) - VaInt(RW("CAR"))
                    s = True
                End If
            Next
            If s = False Then
                dtg.Rows.Add(idgensal, idcategoria, idmarca, Genero, Categoria, Marca, pedidos, cargados, pedidos - cargados)
            End If
        ElseIf cargados > 0 Then
            For Each RW In dtg.Rows
                If VaInt(RW("idgensal")) = idgensal And VaInt(RW("idmarca")) = idmarca Then
                    If CatSalidaComercial.LeerCat(RW("idcat"), idcategoria) > 0 Then ' si pertenece a la misma categoria comercial
                        RW("PED") = VaInt(RW("PED")) + pedidos
                        RW("CAR") = VaInt(RW("CAR")) + cargados
                        RW("DIF") = VaInt(RW("PED")) - VaInt(RW("CAR"))
                        s = True
                    End If
                End If
            Next
            If s = False Then
                dtg.Rows.Add(idgensal, idcategoria, idmarca, Genero, Categoria, Marca, pedidos, cargados, pedidos - cargados)
            End If

        End If



    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ActualizaDatos()
    End Sub

    Private Sub AjustaColumnas()
        GridView.BestFitColumns()
        GridView.OptionsView.ShowGroupPanel = False


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "GENERO"
                    c.Width = 200
                Case "CATEGORIA", "MARCA"
                    c.Width = 100
                Case "PED", "CAR", "DIF"
                    c.Width = 50
                Case Else
                    c.Visible = False
            End Select
        Next


    End Sub
End Class