Public Class FrmSemanaConf
    Inherits FrConsulta

    Dim Semanaspartes As New E_SemanasPartes(Idusuario, cn)
    Dim Semanas_gastoconf As New E_Semanas_gastoconf(Idusuario, cn)
    Dim _idsemana As Integer


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato_1, Semanaspartes.SEV_Semana, Lb1, True)

        AsociarControles(TxDato_1, BtBuscaAlbaran, Semanaspartes.btBusca, Semanaspartes)
        LbCampa.Text = MiMaletin.IdCentro.ToString

    End Sub


    Private Sub TxDato_1_Valida(edicion As Boolean) Handles TxDato_1.Valida

        Dim id As Integer = Semanaspartes.LeerSemana(MiMaletin.Ejercicio, VaInt(TxDato_1.Text))
        _idsemana = id
        If id > 0 Then
            If Semanaspartes.LeerId(id) = True Then
                LbDesdeFecha.Text = Semanaspartes.SEV_FechaInicialSalida.Valor
                LbHastaFecha.Text = Semanaspartes.SEV_FechaFinalSalida.Valor

            End If

        End If
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        GridEditable.DataSource = Nothing
        LbDesdeFecha.Text = ""
        LbHastaFecha.Text = ""
        LbCampa.Text = MiMaletin.Ejercicio.ToString
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaKilosSalidas()
        CargaGridSobreCoste()

    End Sub


    'Private Sub CargaKilosPalets()
    '    Dim palets_lineas As New E_palets_lineas(Idusuario, cn)
    '    Dim palets As New E_palets(Idusuario, cn)
    '    Dim Generos As New E_Generos(Idusuario, cn)
    '    Dim consulta As New Cdatos.E_select
    '    consulta.SelCampo(palets_lineas.PLL_idgenero, "idgenero")
    '    consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", palets_lineas.PLL_idgenero)
    '    Dim kilos As New Cdatos.bdcampo("@SUM(PLL_Kilosnetos)", Cdatos.TiposCampo.Importe, 10)
    '    consulta.SelCampo(kilos, "Kilos")
    '    consulta.SelCampo(palets.PAL_campa, "Campa", palets_lineas.PLL_idpalet)
    '    consulta.WheCampo(palets.PAL_fecha, ">=", LbDesdeFecha.Text)
    '    consulta.WheCampo(palets.PAL_fecha, "<=", LbHastaFecha.Text)
    '    Dim sql As String = consulta.SQL

    '    sql = sql + "group by pll_idgenero,gen_nombregenero,pal_campa"
    '    Dim dt As DataTable = palets_lineas.MiConexion.ConsultaSQL(sql)
    '    dt.Columns.Add("Gasto", GetType(System.Decimal))

    '    If Not dt Is Nothing Then
    '        For Each rw In dt.Rows

    '            Dim Idgenero As Integer = VaInt(rw("idgenero"))
    '            Dim gasto As Decimal = Semanas_gastoconf.GastoGenero(_idsemana, Idgenero)
    '            If gasto = 0 Then
    '                If Generos.LeerId(Idgenero.ToString) = True Then
    '                    gasto = VaDec(Generos.GEN_GastoConfeccion.Valor)
    '                End If
    '            End If
    '            rw("Gasto") = gasto


    '        Next
    '    End If
    '    GridEditable.DataSource = dt
    '    GridEditable.Campo("Gasto", Semanas_gastoconf.SGK_gasto, True, True, False, False)

    '    AjustaColumnas(GridEditable.GridView)
    'End Sub


    Private Sub CargaKilosSalidas()

        Dim albsalida As New E_AlbSalida(Idusuario, cn)
        Dim albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)

        Dim Generos As New E_Generos(Idusuario, cn)
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(albsalida_lineas.ASL_idgenero, "idgenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", albsalida_lineas.ASL_idgenero)
        Dim kilos As New Cdatos.bdcampo("@SUM(asl_Kilosnetos)", Cdatos.TiposCampo.Importe, 10)
        consulta.SelCampo(kilos, "Kilos")
        consulta.SelCampo(albsalida.ASA_ejercicio, "Campa", albsalida_lineas.ASL_idalbaran)
        consulta.WheCampo(albsalida.ASA_fechasalida, ">=", LbDesdeFecha.Text)
        consulta.WheCampo(albsalida.ASA_fechasalida, "<=", LbHastaFecha.Text)
        Dim sql As String = consulta.SQL

        sql = sql + "group by asl_idgenero,gen_nombregenero,asa_ejercicio"
        Dim dt As DataTable = albsalida_lineas.MiConexion.ConsultaSQL(sql)
        dt.Columns.Add("Gasto", GetType(System.Decimal))
        dt.Columns.Add("Importe", GetType(System.Decimal))

        If Not dt Is Nothing Then
            For Each rw In dt.Rows

                Dim Idgenero As Integer = VaInt(rw("idgenero"))
                Dim gasto As Decimal = Semanas_gastoconf.GastoGenero(_idsemana, Idgenero)
                If gasto = 0 Then
                    If Generos.LeerId(Idgenero.ToString) = True Then
                        gasto = VaDec(Generos.GEN_GastoConfeccion.Valor)
                    End If
                End If
                rw("Gasto") = gasto
                rw("Importe") = gasto * VaDec(rw("kilos"))


            Next
        End If
        GridEditable.DataSource = dt
        GridEditable.Campo("Gasto", Semanas_gastoconf.SGK_gasto, True, True, False, False)

        AjustaColumnas(GridEditable.GridView)
    End Sub

    Private Sub Guardar()

        For Each rw In GridEditable.GridView.DataSource
            Dim Idgenero As Integer = VaInt(rw("idgenero"))

            Dim id As Integer = Semanas_gastoconf.LeerGasto(_idsemana, Idgenero)
            If id > 0 Then
                If Semanas_gastoconf.LeerId(id.ToString) = True Then
                    Semanas_gastoconf.SGK_gasto.Valor = rw("Gasto").ToString
                    Semanas_gastoconf.Actualizar()
                End If
            Else
                id = Semanas_gastoconf.MaxId
                Semanas_gastoconf.VaciaEntidad()
                Semanas_gastoconf.SGK_id.Valor = id.ToString
                Semanas_gastoconf.SGK_idgenero.Valor = Idgenero.ToString
                Semanas_gastoconf.SGK_idsemana.Valor = _idsemana.ToString
                Semanas_gastoconf.SGK_gasto.Valor = rw("Gasto").ToString
                Semanas_gastoconf.Insertar()
            End If


        Next
        ActualizaSalidas()
        MsgBox("Registros guardados")
    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()
        If MsgBox("Desea actualizar", vbYesNo) = vbYes Then
            Guardar()
        End If
    End Sub

    Private Sub AjustaColumnas(g As DevExpress.XtraGrid.Views.Grid.GridView)


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In g.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "CAMPA"
                    c.Visible = False

            End Select
        Next

        g.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In g.Columns
            Select Case c.FieldName.ToUpper.Trim


                Case "IDGENERO"
                    c.Width = 150

                Case "KILOS"
                    c.Width = 250
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n0}"

                Case "KILOS", "GASTO"
                    c.Width = 250
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n4}"

                Case "IMPORTE"
                    c.Width = 350
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "{0:n2}"


                Case "GENERO", "PRESENTACION"
                    c.Width = 500

            End Select
        Next


        Funciones.AñadeResumenCampo(g, "Kilos", "{0:n0}")
        Funciones.AñadeResumenCampo(g, "Importe", "{0:n2}")


    End Sub



    Private Sub ActualizaSalidas()

        Dim albsalida As New E_AlbSalida(Idusuario, cn)
        Dim albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
        Dim generosSalida As New E_GenerosSalida(Idusuario, cn)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(albsalida_lineas.ASL_idlinea, "idlinea")
        consulta.SelCampo(albsalida_lineas.ASL_idgenero, "idgenero")
        consulta.SelCampo(albsalida_lineas.ASL_kilosnetos, "kilos")
        consulta.SelCampo(generosSalida.GES_GtoXKilo, "gtoxkilo", albsalida_lineas.ASL_idgensal)
        consulta.SelCampo(albsalida.ASA_idalbaran, "Idalbaran", albsalida_lineas.ASL_idalbaran)
        consulta.WheCampo(albsalida.ASA_fechasalida, ">=", LbDesdeFecha.Text)
        consulta.WheCampo(albsalida.ASA_fechasalida, "<=", LbHastaFecha.Text)
        Dim sql As String = consulta.SQL
        Dim dt As DataTable = albsalida_lineas.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows

                Dim g As Decimal = GastoKilo(VaInt(rw("idgenero")))
                Dim k As Decimal = VaDec(rw("kilos"))
                g = g + VaDec(rw("gtoxkilo")) ' le sumo el sobrecoste de manipulacion de la presentacion

                If albsalida_lineas.LeerId(rw("idlinea").ToString) = True Then
                    albsalida_lineas.ASL_manipulacion.Valor = (g * k).ToString
                    albsalida_lineas.Actualizar()
                End If
            Next
        End If



    End Sub

    Private Function GastoKilo(idgenero As Integer) As Decimal
        Dim ret As Decimal
        Dim dt As DataTable = GridEditable.DataSource
        For Each rw In dt.Rows
            If VaInt(rw("idgenero")) = idgenero Then
                ret = VaDec(rw("gasto"))
                Exit For
            End If
        Next


        Return ret

    End Function


    Private Sub CargaGridSobreCoste()
        Dim albsalida As New E_AlbSalida(Idusuario, cn)
        Dim albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
        Dim generosSalida As New E_GenerosSalida(Idusuario, cn)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(albsalida_lineas.ASL_idgenero, "idgenero")
        consulta.SelCampo(generosSalida.GES_Nombre, "Presentacion", albsalida_lineas.ASL_idgensal)
        Dim kilos As New Cdatos.bdcampo("@SUM(asl_Kilosnetos)", Cdatos.TiposCampo.Importe, 10)
        consulta.SelCampo(kilos, "Kilos")
        consulta.SelCampo(generosSalida.GES_GtoXKilo, "Gasto")
        consulta.SelCampo(albsalida.ASA_ejercicio, "campa", albsalida_lineas.ASL_idalbaran)
        consulta.WheCampo(albsalida.ASA_fechasalida, ">=", LbDesdeFecha.Text)
        consulta.WheCampo(albsalida.ASA_fechasalida, "<=", LbHastaFecha.Text)
        consulta.WheCampo(generosSalida.GES_GtoXKilo, "<>", "0")
        Dim sql As String = consulta.SQL


        sql = sql + "group by asl_idgenero,ges_nombre,ges_gtoxkilo,asa_ejercicio"
        Dim dt As DataTable = albsalida_lineas.MiConexion.ConsultaSQL(sql)
        dt.Columns.Add("Importe", GetType(System.Decimal))

        If Not dt Is Nothing Then
            For Each rw In dt.Rows

                rw("Importe") = VaDec(rw("Gasto")) * VaDec(rw("kilos"))


            Next
        End If
        GridPresenta.DataSource = dt

        AjustaColumnas(GridViewPresenta)
    End Sub

    Private Sub GridEditable_Valida(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        Dim i As Decimal = 0
        i = VaDec(row("gasto")) * VaDec(row("kilos"))
        row("Importe") = i

    End Sub

    Private Sub LbHastaFecha_Click(sender As System.Object, e As System.EventArgs) Handles LbHastaFecha.Click

    End Sub

    Private Sub Lb4_Click(sender As System.Object, e As System.EventArgs) Handles Lb4.Click

    End Sub
End Class