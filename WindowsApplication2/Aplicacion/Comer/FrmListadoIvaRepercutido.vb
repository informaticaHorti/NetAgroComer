Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmListadoIvaRepercutido
    Inherits FrConsulta


    Dim Facturas As New E_Facturas(Idusuario, cn)
    Dim TiposIva As New E_tiposiva(Idusuario, cn)
    Dim Paises As New E_Paises(Idusuario, CnComun)


    Dim err As New Errores

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)

        ListaControles = lc
        ParamTx(TxDato1, TiposIva.TIV_iva, Lb1)
        ParamTx(TxDato2, Facturas.FRA_fecha, Lb2)
        ParamTx(TxDato3, Facturas.FRA_fecha, Lb3)
        ParamTx(TxDato4, Facturas.FRA_serie, Lb4)
        ParamTx(TxDato5, Facturas.FRA_serie, Lb5)

        'AsociarControles(TxDato1, BtBusca1, TiposIva.btBusca, TiposIva, TiposIva.TIV_iva, TxDato1.Text)


    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        cbPuntoVenta = ComboPuntoventa(cbPuntoVenta, MiMaletin.IdPuntoVenta)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub

    Public Overrides Sub Consultar()
        MyBase.Consultar()

        Dim sqlWhere As String = ""


        'Tipo de clientes
        Dim sqlClientes As String = ""
        If RbNacionales.Checked Then
            sqlClientes = " WHERE CLI_IdPais = 1" & vbCrLf
        ElseIf RbComunitarios.Checked Then
            sqlClientes = " WHERE P.Comunitario = 'S' AND CLI_IdPais <> 1" & vbCrLf
        ElseIf RbNoComunitarios.Checked Then
            sqlClientes = " WHERE COALESCE(P.Comunitario,'') <> 'S'" & vbCrLf
        End If


        sqlWhere = sqlClientes & vbCrLf


        'Tipo de IVA
        If VaDec(TxDato1.Text) <> 0 Then
            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE @@IVA@@ = " & VaDec(TxDato1.Text).ToString.Replace(",", ".") & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND @@IVA@@ = " & VaDec(TxDato1.Text).ToString.Replace(",", ".") & vbCrLf
            End If
        End If


        'Fechas
        If TxDato2.Text.Trim <> "" Then
            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE FRA_Fecha >= '" & TxDato2.Text & "'" & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND FRA_Fecha >= '" & TxDato2.Text & "'" & vbCrLf
            End If
        End If
        If TxDato3.Text.Trim <> "" Then
            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE FRA_Fecha <= '" & TxDato3.Text & "'" & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND FRA_Fecha <= '" & TxDato3.Text & "'" & vbCrLf
            End If
        End If


        'Series
        If TxDato4.Text.Trim <> "" Then
            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE FRA_Serie >= '" & TxDato4.Text & "'" & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND FRA_Serie >= '" & TxDato4.Text & "'" & vbCrLf
            End If
        End If
        If TxDato5.Text.Trim <> "" Then
            If sqlWhere.Trim = "" Then
                sqlWhere = " WHERE FRA_Serie <= '" & TxDato5.Text & "'" & vbCrLf
            Else
                sqlWhere = sqlWhere & " AND FRA_Serie <= '" & TxDato5.Text & "'" & vbCrLf
            End If
        End If

        'If sqlWhere.Trim = "" Then
        '    sqlWhere = " WHERE COALESCE(@@BASE@@,0.00) <> 0"
        'Else
        '    sqlWhere = sqlWhere & " AND COALESCE(@@BASE@@,0.00) <> 0"
        'End If


        If sqlWhere.Trim = "" Then
            sqlWhere = CadenaWhereLista(Facturas.FRA_idpuntoventa, ListadeCombo(cbPuntoVenta), "WHERE") & vbCrLf
        Else
            sqlWhere = sqlWhere & " " & CadenaWhereLista(Facturas.FRA_idpuntoventa, ListadeCombo(cbPuntoVenta), "AND") & vbCrLf
        End If





        Dim sql As String = "SELECT FRA_IdFactura as IdFactura, FRA_Serie, FRA_Factura, CAST(FRA_Serie AS varchar) + '-' + CAST(FRA_Factura as varchar) as Factura," & vbCrLf
        sql = sql & " FRA_Fecha as Fecha, FRA_IdCentro as IdCentro, " & vbCrLf
        sql = sql & " FRA_IdCliente as IdCliente, CLI_Nombre as Cliente, CLI_NIF as NIF, " & vbCrLf
        sql = sql & " COALESCE(FRA_Base1,0.00) * COALESCE(FRA_ValorCambio, 1) as Base, COALESCE(FRA_Iva1,0.00) as Iva, COALESCE(FRA_Cuota1,0.00) as CuotaIva," & vbCrLf
        sql = sql & " COALESCE(FRA_Re1,0.00) as Re, COALESCE(FRA_CuotaRe1,0.00) as CuotaRe, COALESCE(FRA_TotalFactura,0) * COALESCE(FRA_ValorCambio,1) as TotalFactura" & vbCrLf
        sql = sql & " FROM Facturas" & vbCrLf
        sql = sql & " LEFT JOIN Clientes ON FRA_IdCliente = CLI_IdCliente" & vbCrLf
        sql = sql & " LEFT JOIN Comun.dbo.Paises P ON P.Idpais = Clientes.CLI_IdPais" & vbCrLf
        sql = sql & sqlWhere.Replace("@@IVA@@", "FRA_Iva1")
        'La Base 1 la mostramos si tiene valor o si todas las bases están a 0
        'El resto de las bases solo las mostraremos si tienen valor
        If sqlWhere = "" Then
            sql = sql & " WHERE (COALESCE(FRA_Base1,0) <> 0 OR (COALESCE(FRA_Base1,0) = 0 AND COALESCE(FRA_Base2,0) = 0 AND COALESCE(FRA_Base3,0) = 0) AND COALESCE(FRA_Base4,0) = 0)"
        Else
            sql = sql & " AND (COALESCE(FRA_Base1,0) <> 0 OR (COALESCE(FRA_Base1,0) = 0 AND COALESCE(FRA_Base2,0) = 0 AND COALESCE(FRA_Base3,0) = 0) AND COALESCE(FRA_Base4,0) = 0)"
        End If
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT FRA_IdFactura as IdFactura, FRA_Serie, FRA_Factura, CAST(FRA_Serie AS varchar) + '-' + CAST(FRA_Factura as varchar) as Factura," & vbCrLf
        sql = sql & " FRA_Fecha as Fecha, FRA_IdCentro as IdCentro, " & vbCrLf
        sql = sql & " FRA_IdCliente as IdCliente, CLI_Nombre as Cliente, CLI_NIF as NIF, " & vbCrLf
        sql = sql & " COALESCE(FRA_Base2,0.00) * COALESCE(FRA_ValorCambio,1) as Base, COALESCE(FRA_Iva2,0.00) as Iva, COALESCE(FRA_Cuota2,0.00) as CuotaIva," & vbCrLf
        sql = sql & " COALESCE(FRA_Re2,0.00) as Re, COALESCE(FRA_CuotaRe2,0.00) as CuotaRe, COALESCE(FRA_TotalFactura,0) * COALESCE(FRA_ValorCambio,1) as TotalFactura" & vbCrLf
        sql = sql & " FROM Facturas" & vbCrLf
        sql = sql & " LEFT JOIN Clientes ON FRA_IdCliente = CLI_IdCliente" & vbCrLf
        sql = sql & " LEFT JOIN Comun.dbo.Paises P ON P.Idpais = Clientes.CLI_IdPais" & vbCrLf
        sql = sql & sqlWhere.Replace("@@IVA@@", "FRA_Iva2")
        If sqlWhere = "" Then
            sql = sql & " WHERE COALESCE(FRA_Base2,0) <> 0"
        Else
            sql = sql & " AND COALESCE(FRA_Base2,0) <> 0"
        End If
        sql = sql & " UNION ALL" & vbCrLf.Trim
        sql = sql & " SELECT FRA_IdFactura as IdFactura, FRA_Serie, FRA_Factura, CAST(FRA_Serie AS varchar) + '-' + CAST(FRA_Factura as varchar) as Factura," & vbCrLf
        sql = sql & " FRA_Fecha as Fecha, FRA_IdCentro as IdCentro, " & vbCrLf
        sql = sql & " FRA_IdCliente as IdCliente, CLI_Nombre as Cliente, CLI_NIF as NIF, " & vbCrLf
        sql = sql & " COALESCE(FRA_Base3,0.00) * COALESCE(FRA_ValorCambio,1) as Base, COALESCE(FRA_Iva3,0.00) as Iva, COALESCE(FRA_Cuota3,0.00) as CuotaIva," & vbCrLf
        sql = sql & " COALESCE(FRA_Re3,0.00) as Re, COALESCE(FRA_CuotaRe3,0.00) as CuotaRe, COALESCE(FRA_TotalFactura,0) * COALESCE(FRA_ValorCambio,1) as TotalFactura" & vbCrLf
        sql = sql & " FROM Facturas" & vbCrLf
        sql = sql & " LEFT JOIN Clientes ON FRA_IdCliente = CLI_IdCliente" & vbCrLf
        sql = sql & " LEFT JOIN Comun.dbo.Paises P ON P.Idpais = Clientes.CLI_IdPais" & vbCrLf
        sql = sql & sqlWhere.Replace("@@IVA@@", "FRA_Iva3")
        If sqlWhere = "" Then
            sql = sql & " WHERE COALESCE(FRA_Base3,0) <> 0"
        Else
            sql = sql & " AND COALESCE(FRA_Base3,0) <> 0"
        End If
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT FRA_IdFactura as IdFactura, FRA_Serie, FRA_Factura, CAST(FRA_Serie AS varchar) + '-' + CAST(FRA_Factura as varchar) as Factura," & vbCrLf
        sql = sql & " FRA_Fecha as Fecha, FRA_IdCentro as IdCentro, " & vbCrLf
        sql = sql & " FRA_IdCliente as IdCliente, CLI_Nombre as Cliente, CLI_NIF as NIF, " & vbCrLf
        sql = sql & " COALESCE(FRA_Base4,0.00) * COALESCE(FRA_ValorCambio,1) as Base, COALESCE(FRA_Iva4,0.00) as Iva, COALESCE(FRA_Cuota4,0.00) as CuotaIva," & vbCrLf
        sql = sql & " COALESCE(FRA_Re4,0.00) as Re, COALESCE(FRA_CuotaRe4,0.00) as CuotaRe, COALESCE(FRA_TotalFactura,0) * COALESCE(FRA_ValorCambio,1) as TotalFactura" & vbCrLf
        sql = sql & " FROM Facturas" & vbCrLf
        sql = sql & " LEFT JOIN Clientes ON FRA_IdCliente = CLI_IdCliente" & vbCrLf
        sql = sql & " LEFT JOIN Comun.dbo.Paises P ON P.Idpais = Clientes.CLI_IdPais" & vbCrLf
        sql = sql & sqlWhere.Replace("@@IVA@@", "FRA_Iva4")
        If sqlWhere = "" Then
            sql = sql & " WHERE COALESCE(FRA_Base4,0) <> 0"
        Else
            sql = sql & " AND COALESCE(FRA_Base4,0) <> 0"
        End If


        If RbResumido.Checked Then

            sql = "SELECT SUM(Base) as Base, Iva, SUM(CuotaIva) as CuotaIva" & vbCrLf & _
                " FROM (" & vbCrLf & _
                sql & vbCrLf & ") as G" & vbCrLf & _
                " GROUP BY Iva" & vbCrLf & _
                " ORDER BY Iva"
        Else

            sql = "SELECT IdFactura, Factura, FRA_Serie, FRA_Factura, IdCentro, Fecha, IdCliente, Cliente, NIF, SUM(Base) as Base, Iva, SUM(CuotaIva) as CuotaIva," & vbCrLf & _
                " Re, SUM(CuotaRE) as CuotaRe, TotalFactura" & vbCrLf & _
                " FROM (" & vbCrLf & _
                sql & vbCrLf & ") as G" & vbCrLf & _
                " GROUP BY IdFactura, Factura, FRA_Serie, FRA_Factura, Fecha, IdCentro, IdCliente, Cliente, NIF, Iva, Re, TotalFactura" & vbCrLf & _
                " ORDER BY Fecha, FRA_Serie, FRA_Factura"

        End If



        GridView1.Columns.Clear()
        Dim dt As DataTable = Facturas.MiConexion.ConsultaSQL(sql)
        dt.Columns.Add("Albaran", GetType(String)).SetOrdinal(5)

        If Not RbResumido.Checked Then
            For Each row As DataRow In dt.Rows
                row("Albaran") = ColumnaAlbaran(row("IdFactura"))
            Next
        End If

        Grid.DataSource = dt

        AjustaColumnas()



        AñadeResumenCampo("Base", "{0:n2}")
        AñadeResumenCampo("CuotaIva", "{0:n2}")
        AñadeResumenCampo("CuotaRe", "{0:n2}")
        AñadeResumenCampo("TotalFactura", "{0:n2}")

    End Sub


    Private Function ColumnaAlbaran(IdFactura As String) As String

        Dim res As String = ""

        If VaInt(IdFactura) > 0 Then

            Dim sql As String = "SELECT ASA_Albaran as Albaran FROM AlbSalida WHERE ASA_IdFactura = " & IdFactura

            Dim dt As DataTable = Facturas.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    If dt.Rows.Count = 1 Then
                        res = dt.Rows(0)("Albaran").ToString & ""
                    Else
                        res = "Varios"
                    End If
                End If
            End If


        End If


        Return res

    End Function


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "FRA_SERIE", "FRA_FACTURA", "IDFACTURA"
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "BASE"
                    c.Caption = "BaseImp"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 80

                Case "CUOTAIVA"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 80

                Case "IVA"
                    c.Caption = "Iva(%)"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 55

                Case "RE"
                    c.Caption = "R.Eq.(%)"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 55

                Case "CUOTARE"
                    c.Caption = "Cuota R.Eq."
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 80

                Case "TOTALFACTURA"
                    c.Caption = "T.Factura"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 80

                Case "FECHA", "NIF"
                    c.MaxWidth = 80

                Case "FACTURA"
                    c.Width = 80

                Case "IDCLIENTE"
                    c.Caption = "CodCli"
                    c.Width = 55

                Case "IDCENTRO"
                    c.Caption = "CE"
                    c.Width = 30



            End Select
        Next

    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()

        Dim bDatos As Boolean = True
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim TipoCliente As String = ""
                If RbNacionales.Checked Then
                    TipoCliente = "N"
                ElseIf RbComunitarios.Checked Then
                    TipoCliente = "C"
                ElseIf RbNoComunitarios.Checked Then
                    TipoCliente = "NC"
                End If

                Dim lstPuntoVenta As List(Of String) = ListadeCombo(cbPuntoVenta)

                Dim listado As New Listado_IvaRepercutido(dt, RbDetallado.Checked, VaDec(TxDato1.Text), TxDato2.Text, TxDato3.Text, TxDato4.Text, TxDato5.Text, TipoCliente, lstPuntoVenta, TipoImpresion.Preliminar)
                listado.ImprimirListado()

            Else
                bDatos = False
            End If
        Else
            bDatos = False
        End If
        If Not bDatos Then
            MessageBox.Show("No hay datos que imprimir")
        End If

    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()


        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato2.Text, TxDato3.Text)
        Dim serie As String = FiltroDesdeHasta("Serie", TxDato4.Text, TxDato5.Text)
        Dim puntosventa As String = FiltroCheckedComboBox("Puntos de venta", cbPuntoVenta)

        Dim RbClientes As RadioButton() = {RbNacionales, RbComunitarios, RbNoComunitarios, RbTodos}
        Dim StrClientes As String() = {"Nacionales", "Comunitarios", "No comunitarios", "Todos"}
        Dim Clientes As String = FiltroRadioButton("Clientes", RbClientes, StrClientes)

        Dim RbDetalle As RadioButton() = {RbDetallado, RbResumido}
        Dim StrDetalle As String() = {"Detallar facturas", "Resumir facturas"}
        Dim Detalle As String = FiltroRadioButton("Tipo listado", RbDetalle, StrDetalle)


        If VaDec(TxDato1.Text) <> 0 Then LineasDescripcion.Add("Tipo de IVA: " & VaDec(TxDato1.Text).ToString("#,##0.00") & " %")
        If fechas <> "" Then LineasDescripcion.Add(fechas)
        If serie <> "" Then LineasDescripcion.Add(serie)
        If puntosventa <> "" Then LineasDescripcion.Add(puntosventa)
        If Clientes <> "" Then LineasDescripcion.Add(Clientes)
        If Detalle <> "" Then LineasDescripcion.Add(Detalle)


        MyBase.Imprimir()

    End Sub

End Class