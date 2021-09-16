Module Combos


    Public Function ComboFacturasRectificativas() As DataTable

        Dim dt As New DataTable

        dt.Columns.Add("Id", GetType(Integer))
        dt.Columns.Add("Nombre", GetType(String))

        dt.Rows.Add(-1, "NO ES FRA. RECTIFICATIVA")
        dt.Rows.Add(1, "Art. 80.1 y 80.2 y error fundado en derecho")
        dt.Rows.Add(2, "Art. 80.3")
        dt.Rows.Add(3, "Art. 80.4")
        dt.Rows.Add(4, "Resto")
        dt.Rows.Add(5, "De Fras. Simplificadas")


        Return dt

    End Function


    Public Function ComboTipoIdentificacion() As DataTable
        Dim dt As New DataTable


        dt.Columns.Add(New DataColumn("Id", GetType(Integer)))
        dt.Columns.Add(New DataColumn("Nombre"))
        dt.Rows.Add(VaInt(Funciones_SII.TipoIdentificacion.NIF), "NIF")
        dt.Rows.Add(VaInt(Funciones_SII.TipoIdentificacion.Pasaporte), "Pasaporte")
        dt.Rows.Add(VaInt(Funciones_SII.TipoIdentificacion.DocumentoPaisResidencia), "Documento del país de residencia")
        dt.Rows.Add(VaInt(Funciones_SII.TipoIdentificacion.CertificadoResidencia), "Certificado residencia")
        dt.Rows.Add(VaInt(Funciones_SII.TipoIdentificacion.Otro), "Otro documento probatorio")


        Return dt

    End Function


    Public Function ComboDocumentosCartera() As CbBox

        Dim Cb As New CbBox

        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("Id"))
        dt.Columns.Add(New DataColumn("Nombre"))

        dt.Rows.Add("0", "")
        dt.Rows.Add("1", "TALÓN")
        dt.Rows.Add("2", "PAGARÉ")
        dt.Rows.Add("3", "TRANSFERENCIA")

        Cb.DataSource = dt
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "Id"


        Return Cb

    End Function


    Public Function ComboQuincenas(ByRef FechasQuincenas(,) As String) As CbBox

        Dim Dtcol As New DataTable
        Dim Cb As New CbBox
        Dim DiasFebrero As String = ""

        Dtcol.Columns.Add(New DataColumn("Id"))
        Dtcol.Columns.Add(New DataColumn("Quincena"))


        ReDim FechasQuincenas(23, 2)


        Dtcol.Rows.Add(0, "1ª Enero      01/01 a 15/01")
        FechasQuincenas(0, 0) = "01/01"
        FechasQuincenas(0, 1) = "15/01"

        Dtcol.Rows.Add(1, "2ª Enero      16/01 a 31/01")
        FechasQuincenas(1, 0) = "16/01"
        FechasQuincenas(1, 1) = "31/01"

        Dtcol.Rows.Add(2, "1ª Febrero    01/02 a 15/02")
        FechasQuincenas(2, 0) = "01/02"
        FechasQuincenas(2, 1) = "15/02"

        If Val(Year(Now)) Mod 4 = 0 Then
            DiasFebrero = "29"
        Else
            DiasFebrero = "28"
        End If

        Dtcol.Rows.Add(3, "2ª Febrero    16/02 a " + DiasFebrero + "/02")
        FechasQuincenas(3, 0) = "16/02"
        FechasQuincenas(3, 1) = DiasFebrero + "/02"

        Dtcol.Rows.Add(4, "1ª Marzo      01/03 a 15/03")
        FechasQuincenas(4, 0) = "01/03"
        FechasQuincenas(4, 1) = "15/03"
        Dtcol.Rows.Add(5, "2ª Marzo      16/03 a 31/03")
        FechasQuincenas(5, 0) = "16/03"
        FechasQuincenas(5, 1) = "31/03"

        Dtcol.Rows.Add(6, "1ª Abril      01/01 a 15/01")
        FechasQuincenas(6, 0) = "01/04"
        FechasQuincenas(6, 1) = "15/04"
        Dtcol.Rows.Add(7, "2ª Abril      16/04 a 30/04")
        FechasQuincenas(7, 0) = "16/04"
        FechasQuincenas(7, 1) = "30/04"

        Dtcol.Rows.Add(8, "1ª Mayo       01/05 a 15/05")
        FechasQuincenas(8, 0) = "01/05"
        FechasQuincenas(8, 1) = "15/05"
        Dtcol.Rows.Add(9, "2ª Mayo       16/05 a 31/05")
        FechasQuincenas(9, 0) = "16/05"
        FechasQuincenas(9, 1) = "31/05"

        Dtcol.Rows.Add(10, "1ª Junio      01/06 a 15/06")
        FechasQuincenas(10, 0) = "01/06"
        FechasQuincenas(10, 1) = "15/06"
        Dtcol.Rows.Add(11, "2ª Junio      16/06 a 30/06")
        FechasQuincenas(11, 0) = "16/06"
        FechasQuincenas(11, 1) = "30/06"

        Dtcol.Rows.Add(12, "1ª Julio      01/07 a 15/07")
        FechasQuincenas(12, 0) = "01/07"
        FechasQuincenas(12, 1) = "15/07"
        Dtcol.Rows.Add(13, "2ª Julio      16/07 a 31/07")
        FechasQuincenas(13, 0) = "16/07"
        FechasQuincenas(13, 1) = "31/07"

        Dtcol.Rows.Add(14, "1ª Agosto     01/08 a 15/08")
        FechasQuincenas(14, 0) = "01/08"
        FechasQuincenas(14, 1) = "15/08"
        Dtcol.Rows.Add(15, "2ª Agosto     16/08 a 31/08")
        FechasQuincenas(15, 0) = "16/08"
        FechasQuincenas(15, 1) = "31/08"

        Dtcol.Rows.Add(16, "1ª Septiembre 01/09 a 15/09")
        FechasQuincenas(16, 0) = "01/09"
        FechasQuincenas(16, 1) = "15/09"
        Dtcol.Rows.Add(17, "2ª Septiembre 16/09 a 30/09")
        FechasQuincenas(17, 0) = "16/09"
        FechasQuincenas(17, 1) = "30/09"

        Dtcol.Rows.Add(18, "1ª Octubre    01/10 a 15/10")
        FechasQuincenas(18, 0) = "01/10"
        FechasQuincenas(18, 1) = "15/10"
        Dtcol.Rows.Add(19, "2ª Octubre    16/10 a 31/10")
        FechasQuincenas(19, 0) = "16/10"
        FechasQuincenas(19, 1) = "31/10"

        Dtcol.Rows.Add(20, "1ª Noviembre  01/11 a 15/11")
        FechasQuincenas(20, 0) = "01/11"
        FechasQuincenas(20, 1) = "15/11"
        Dtcol.Rows.Add(21, "2ª Noviembre  16/11 a 30/11")
        FechasQuincenas(21, 0) = "16/11"
        FechasQuincenas(21, 1) = "30/11"

        Dtcol.Rows.Add(22, "1ª Diciembre  01/12 a 15/12")
        FechasQuincenas(22, 0) = "01/12"
        FechasQuincenas(22, 1) = "15/12"
        Dtcol.Rows.Add(23, "2ª Diciembre  16/12 a 31/12")
        FechasQuincenas(23, 0) = "16/12"
        FechasQuincenas(23, 1) = "31/12"


        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Quincena"
        Cb.ValueMember = "Id"
        Return Cb

    End Function


    Public Function ComboSiNo() As CbBox
        Dim Dtcol As New DataTable
        Dim CB As New CbBox

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("S", "Si")
        Dtcol.Rows.Add("N", "No")
        CB.DataSource = Dtcol
        CB.DisplayMember = "Nombre"
        CB.ValueMember = "id"
        Return CB

    End Function


    Public Function ComboAgriMay() As CbBox
        Dim Dtcol As New DataTable
        Dim Cb As New CbBox
        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("A", "Agricultor")
        Dtcol.Rows.Add("M", "Mayorista")
        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"
        Return Cb


    End Function


    Public Function ComboTipoEntrada() As CbBox

        Dim Dtcol As New DataTable
        Dim Cb As New CbBox

        Dtcol.Columns.Add(New DataColumn("Id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("", "TODAS")
        Dtcol.Rows.Add("N", "Entradas Báscula")
        Dtcol.Rows.Add("S", "Entradas Directas")
        Cb.DataSource = Dtcol

        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "Id"
        Return Cb


    End Function

    Public Function ComboTipoFacAgri() As CbBox
        Dim Dtcol As New DataTable
        Dim Cb As New CbBox
        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        'Dtcol.Rows.Add("1", "Factura")
        'Dtcol.Rows.Add("2", "Albaran")
        'Dtcol.Rows.Add("3", "No Emitir")

        Dtcol.Rows.Add("1", "Emitir facturas")
        Dtcol.Rows.Add("2", "Recibir facturas")


        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"
        Return Cb


    End Function

    Public Function ComboTipoactividad() As CbBox
        Dim Dtcol As New DataTable
        Dim Cb As New CbBox
        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("C", "Comercialización")
        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"
        Return Cb


    End Function

    Public Function ComboBaseTot() As CbBox
        Dim Dtcol As New DataTable
        Dim Cb As New CbBox
        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("B", "Base")
        Dtcol.Rows.Add("T", "Total")
        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"


        Return Cb
    End Function

    Public Function ComboTipoPorte() As CbBox
        Dim Dtcol As New DataTable
        Dim Cb As New CbBox
        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("C", "Compras")
        Dtcol.Rows.Add("V", "Ventas")
        Dtcol.Rows.Add("CV", "Compras/Ventas")
        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"

        Return Cb

    End Function

    Public Function ComboFacCom() As CbBox
        Dim Dtcol As New DataTable
        Dim Cb As New CbBox

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("F", "Facturable")
        Dtcol.Rows.Add("C", "Gasto comercial")
        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"

        Return Cb

    End Function

    Public Function ComboFacComAgri() As CbBox
        Dim Dtcol As New DataTable
        Dim Cb As New CbBox

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("F", "Descuento en factura")
        Dtcol.Rows.Add("C", "Descuento comercial")
        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"

        Return Cb

    End Function

    Public Function ComboTiposCat() As CbBox
        Dim Dtcol As New DataTable
        Dim Cb As New CbBox
        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("C", "Comercial")
        Dtcol.Rows.Add("D", "Destrio")
        Dtcol.Rows.Add("R", "Retirada")
        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"
        Return Cb

    End Function


    Public Function ComboProcesoMail() As CbBox
        Dim Dtcol As New DataTable
        Dim Cb As New CbBox

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add(1, "Facturas")
        Dtcol.Rows.Add(2, "Albaranes")
        Dtcol.Rows.Add(3, "Reclamacion cobros")
        Dtcol.Rows.Add(4, "Reclamacion cuenta ventas")
        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"

        Return Cb
    End Function
    Public Function ComboGastos() As CbBox
        Dim Dtcol As New DataTable
        Dim cb As New CbBox

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("%", "Porcentaje")
        Dtcol.Rows.Add("K", "Kilos")
        Dtcol.Rows.Add("B", "Bultos")
        Dtcol.Rows.Add("P", "Palets")
        Dtcol.Rows.Add("I", "Importe")

        cb.DataSource = Dtcol
        cb.DisplayMember = "Nombre"
        cb.ValueMember = "id"
        Return cb

    End Function

    Public Function ComboTiposFac() As CbBox
        Dim Dtcol As New DataTable
        Dim Cb As New CbBox

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("1", "Generos")
        Dtcol.Rows.Add("2", "Envases Retornables")
        Dtcol.Rows.Add("3", "Envases No Retornables")
        Dtcol.Rows.Add("4", "Devolucion envases")
        Dtcol.Rows.Add("5", "Facturas abono")
        Dtcol.Rows.Add("6", "Albaran comision")

        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"
        Return Cb

    End Function

    Public Function ComboTiposProducto() As CbBox
        Dim Dtcol As New DataTable
        Dim Cb As New CbBox
        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("1", "Generos")
        Dtcol.Rows.Add("2", "Envases")
        Dtcol.Rows.Add("3", "Varios")

        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"
        Return Cb


    End Function

    Public Function ComboOrigenGastos() As CbBox
        Dim Dtcol As New DataTable
        Dim Cb As New CbBox
        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("PO", "Portes COMPRAS")
        Dtcol.Rows.Add("PV", "Portes VENTAS")
        Dtcol.Rows.Add("CO", "Comisionistas COMPRAS")
        Dtcol.Rows.Add("CV", "Comisionistas VENTAS")
        Dtcol.Rows.Add("CT", "Cortador")
        Dtcol.Rows.Add("CG", "Cargador")
        Dtcol.Rows.Add("MA", "Materiales")

        Dtcol.Rows.Add("OO", "Otros")

        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"
        Return Cb


    End Function

    Public Function ComboCentros() As CbBox
        Dim dt As New DataTable
        Dim Sql As String
        Dim Cb As New CbBox
        Sql = "Select idcentro,nombre from centros order by idcentro"
        dt = cn.ConsultaSQL(Sql)

        Cb.DataSource = dt
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "idcentro"

        Return Cb

    End Function

    Public Function ComboCategorias() As CbBox
        Dim dt As New DataTable
        Dim Sql As String
        Dim Cb As New CbBox
        Sql = "Select TCA_id as id, TCA_nombre as Nombre from tiposdecategorias order by TCA_id"
        dt = cn.ConsultaSQL(Sql)

        Cb.DataSource = dt
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"

        Return Cb
    End Function

    Public Function ComboTFactura() As CbBox
        Dim Dtcol As New DataTable
        Dim Cb As New CbBox
        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("1", "Factura")
        Dtcol.Rows.Add("2", "Albaran interno")
        Dtcol.Rows.Add("3", "Dto Factura")
        Dtcol.Rows.Add("4", "Vta comision")
        Dtcol.Rows.Add("5", "Confeccion")

        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"

        Return Cb
    End Function

    Public Function ComboFacEnvases() As CbBox
        Dim Dtcol As New DataTable
        Dim Cb As New CbBox
        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("1", "No Facturar")
        Dtcol.Rows.Add("2", "Detallar venta")
        Dtcol.Rows.Add("3", "Incluir en precio")
        '   Dtcol.Rows.Add("4", "Facturar siempre")

        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"

        Return Cb
    End Function

    Public Function ComboTGasto() As CbBox
        Dim Dtcol As New DataTable
        Dim Cb As New CbBox
        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("1", "Detallar gasto")
        Dtcol.Rows.Add("2", "Incluir en precio")

        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"

        Return Cb
    End Function

    Public Function ComboIdioma() As CbBox
        Dim dt As New DataTable
        Dim Sql As String
        Dim cb As New CbBox
        Sql = "Select ididioma,nombre from idiomas order by ididioma"
        dt = CnComun.ConsultaSQL(Sql)

        cb.DataSource = dt
        cb.DisplayMember = "Nombre"
        cb.ValueMember = "ididioma"

        Return cb
    End Function
    Public Function ComboIvaEnv() As CbBox
        Dim dt As New DataTable
        Dim Sql As String
        Dim Cb As New CbBox
        Sql = "Select TIV_id as id, TIV_iva as iva from tiposiva order by TIV_id"
        dt = cn.ConsultaSQL(Sql)

        Cb.DataSource = dt
        Cb.DisplayMember = "iva"
        Cb.ValueMember = "id"

        Return Cb

    End Function
    Public Function ComboMoneda() As CbBox
        Dim dt As New DataTable
        Dim Sql As String
        Dim Cb As New CbBox
        Sql = "Select idmoneda,nombre from moneda order by idmoneda"
        dt = CnComun.ConsultaSQL(Sql)

        Cb.DataSource = dt
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "idmoneda"

        Return Cb
    End Function

    Public Function ComboVendedor() As CbBox
        Dim dt As New DataTable
        Dim Sql As String
        Dim Cb As New CbBox
        Sql = "Select VED_idcomercial as IdComercial, VED_nombre as Nombre from vendedores order by VED_idcomercial"
        dt = cn.ConsultaSQL(Sql)

        Cb.DataSource = dt
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "IdComercial"


        Return Cb

    End Function




    Public Function ComboAlmacenesEnvases() As CbBox
        Dim dt As New DataTable
        Dim Sql As String
        Dim Cb As New CbBox

        Sql = "Select AEV_IdAlmacen as Id, AEV_nombre as Almacen from AlmacenEnvases order by AEV_IdAlmacen"
        dt = cn.ConsultaSQL(Sql)

        Cb.DataSource = dt
        Cb.DisplayMember = "Almacen"
        Cb.ValueMember = "Id"


        Return Cb

    End Function


    Public Function ComboTipoenvase() As CbBox
        Dim Dtcol As New DataTable
        Dim Cb As New CbBox
        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("E", "Envase")
        Dtcol.Rows.Add("M", "Material")
        Dtcol.Rows.Add("P", "Palet")
        Dtcol.Rows.Add("Q", "Etiqueta")

        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"

        Return Cb

    End Function


    Public Function ComboInicialEnvase() As CbBox
        Dim Dtcol As New DataTable
        Dim Cb As New CbBox
        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("AG", "Agricultores")
        Dtcol.Rows.Add("CL", "Clientes")
        Dtcol.Rows.Add("AL", "Almacenes")

        Cb.DataSource = Dtcol
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "id"

        Return Cb

    End Function


    Public Function ComboTipoConexionTecnicos() As CbBox

        Dim Cb As New CbBox
        Dim dt As New DataTable

        dt.Columns.Add(New DataColumn("Id", GetType(String)))
        dt.Columns.Add(New DataColumn("Nombre", GetType(String)))


        Dim row As DataRow = dt.NewRow()
        row("Id") = VaInt(E_ValoresEjercicio.TipoConexionTecnicos.TecnicosSQL)
        row("Nombre") = "TecnicosSQL"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Id") = VaInt(E_ValoresEjercicio.TipoConexionTecnicos.TecnicosNet)
        row("Nombre") = "TecnicosNet"
        dt.Rows.Add(row)


        Cb.DataSource = dt
        Cb.DisplayMember = "Nombre"
        Cb.ValueMember = "Id"


        Return Cb


    End Function


    Public Function ComboImpresoras() As CbBox

        Dim CbImpresoras As New CbBox
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("Id", GetType(String)))
        dt.Columns.Add(New DataColumn("Nombre", GetType(String)))

        Dim lst As List(Of String) = ListaImpresorasDelSistema()
        lst.Sort()

        'Sin impresora
        lst.Insert(0, "")

        For Each item As String In lst
            Dim row As DataRow = dt.NewRow()
            row("Id") = item
            row("Nombre") = item
            dt.Rows.Add(row)
        Next


        CbImpresoras.DataSource = dt
        CbImpresoras.DisplayMember = "Nombre"
        CbImpresoras.ValueMember = "Id"


        Return CbImpresoras

    End Function


    Public Function ComboOrigenReclamaciones() As CbBox

        Dim dt As New DataTable
        Dim Sql As String
        Dim Cb As New CbBox

        Sql = "Select RCO_IdOrigen as Id, RCO_nombre as Origen from Reclama_Origen order by RCO_IdOrigen"
        dt = cn.ConsultaSQL(Sql)

        Cb.DataSource = dt
        Cb.DisplayMember = "Origen"
        Cb.ValueMember = "Id"


        Return Cb

    End Function


    'Public Function ComboLineas() As CbBox

    '    Dim dt As New DataTable
    '    Dim Sql As String
    '    Dim Cb As New CbBox
    '    Sql = "Select LIN_IdLinea as Id, LIN_nombre as Nombre from Lineas order by LIN_Nombre"
    '    dt = cn.ConsultaSQL(Sql)

    '    Cb.DataSource = dt
    '    Cb.DisplayMember = "Nombre"
    '    Cb.ValueMember = "Id"

    '    Return Cb


    'End Function


End Module
