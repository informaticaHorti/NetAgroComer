
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic


Public Class FrmCuadreKilosComer
    Inherits FrConsulta


    Private Class stClaves_cuadre

        Public Idgenero As Integer = 0
        Public Genero As String = ""

        Public Sub New(ByVal Idgenero As Integer, Genero As String)
            Me.Idgenero = Idgenero
            Me.Genero = Genero
        End Sub

    End Class


    Private Class stdatos_cuadre

        Public Iniciales As Decimal = 0
        Public Compras As Decimal = 0
        Public Ventas As Decimal = 0
        Public Destrio As Decimal = 0
        Public Existencias As Decimal = 0
        Public Finales As Decimal = 0
        Public Diferencia As Decimal = 0

        Public Sub New(ByVal iniciales As Decimal, Compras As Decimal, Ventas As Decimal, Destrio As Decimal, Finales As Decimal)

            Me.Iniciales = iniciales
            Me.Compras = Compras
            Me.Ventas = Ventas
            Me.Destrio = Destrio
            Me.Finales = Finales

        End Sub

    End Class


    Dim ParteSemanal As New E_Partesemanal(Idusuario, cn)
    Dim ParteSemanal_lineas As New E_partesemanal_lineas(Idusuario, cn)
    Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
    Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Albsalida As New E_AlbSalida(Idusuario, cn)
    Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
    Dim ParteDestrio As New E_ParteDestrio(Idusuario, cn)
    Dim ParteDestrio_Lineas As New E_partedestrio_lineas(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)


    Dim err As New Errores


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Nothing, Lb1, True, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato2, Nothing, Lb2, True, Cdatos.TiposCampo.Fecha)

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub FrmCuadreKilosComer_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False

    End Sub


    Private Sub Fechaspordefecto()

        'Usamos del lunes al domingo de la semana
        Dim FechaInicio As Date
        Dim FechaFinal As Date
        ObtenerSemana(FechaInicio, FechaFinal)


        TxDato1.Text = FechaInicio.ToString("dd/MM/yyyy")
        TxDato2.Text = FechaFinal.ToString("dd/MM/yyyy")

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()


    End Sub


    Private Sub CargaGrid()


        Dim acum As New Acumulador


        'INICIALES
        Dim consulta As New Cdatos.E_select
        Dim KilosIni As New Cdatos.bdcampo("@SUM(PSL_Kilos)", Cdatos.TiposCampo.Importe, 10)
        consulta.SelCampo(ParteSemanal_lineas.PSL_idgenero, "IdGenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", ParteSemanal_lineas.PSL_idgenero)
        consulta.SelCampo(KilosIni, "Kilos")
        consulta.SelCampo(ParteSemanal.PSM_fechainicial, "FechaInicial", ParteSemanal_lineas.PSL_idparte, ParteSemanal.PSM_idparte)
        consulta.WheCampo(ParteSemanal.PSM_fechainicial, "=", TxDato1.Text)
        consulta.WheCampo(ParteSemanal.PSM_idcentro, "=", MiMaletin.IdCentro.ToString)
        Dim sql As String = consulta.SQL
        sql = sql & " GROUP BY PSL_IdGenero, GEN_NombreGenero, PSM_FechaInicial" & vbCrLf

        Dim dt As DataTable = Albentrada.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows

                Dim clave As New stClaves_cuadre(VaInt(row("idgenero")), (row("Genero").ToString & "").Trim)
                Dim datos As New stdatos_cuadre(VaDec(row("kilos")), 0, 0, 0, 0)
                acum.Suma(clave, datos)

            Next
        End If



        'COMPRAS
        consulta = New Cdatos.E_select
        Dim KilosCom As New Cdatos.bdcampo("@SUM(AEL_KILOSNETOS)", Cdatos.TiposCampo.Importe, 10)
        consulta.SelCampo(Albentrada_lineas.AEL_idgenero, "idgenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albentrada_lineas.AEL_idgenero)
        consulta.SelCampo(KilosCom, "kilos")
        consulta.SelCampo(Albentrada.AEN_Fecha, "fecha", Albentrada_lineas.AEL_idalbaran)
        consulta.WheCampo(Albentrada.AEN_Fecha, ">=", TxDato1.Text)
        consulta.WheCampo(Albentrada.AEN_Fecha, "<=", TxDato2.Text)
        consulta.WheCampo(Albentrada.AEN_IdCentro, "=", MiMaletin.IdCentro.ToString)
        sql = consulta.SQL
        sql = sql + " GROUP BY ael_idgenero, GEN_NombreGenero,aen_fecha"

        dt = Albentrada.MiConexion.ConsultaSQL(sql)

        If Not dt Is Nothing Then
            For Each rw In dt.Rows

                Dim clave As New stClaves_cuadre(VaInt(rw("idgenero")), (rw("Genero").ToString & "").Trim)
                Dim datos As New stdatos_cuadre(0, VaDec(rw("kilos")), 0, 0, 0)
                acum.Suma(clave, datos)

            Next
        End If


        'VENTAS
        consulta = New Cdatos.E_select
        Dim KilosSal As New Cdatos.bdcampo("@SUM(ASL_KILOSNETOS)", Cdatos.TiposCampo.Importe, 10)
        consulta.SelCampo(Albsalida_lineas.ASL_idgenero, "idgenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albsalida_lineas.ASL_idgenero)
        consulta.SelCampo(KilosSal, "kilos")
        consulta.SelCampo(Albsalida.ASA_fechasalida, "fecha", Albsalida_lineas.ASL_idalbaran)
        consulta.WheCampo(Albsalida.ASA_fechasalida, ">=", TxDato1.Text)
        consulta.WheCampo(Albsalida.ASA_fechasalida, "<=", TxDato2.Text)
        consulta.WheCampo(Albsalida.ASA_idcentro, "=", MiMaletin.IdCentro.ToString)
        sql = consulta.SQL
        sql = sql + " GROUP BY asl_idgenero, GEN_NombreGenero,asa_fechasalida"

        dt = Albsalida.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows

                Dim clave As New stClaves_cuadre(VaInt(rw("idgenero")), (rw("Genero").ToString & "").Trim)
                Dim datos As New stdatos_cuadre(0, 0, VaDec(rw("kilos")), 0, 0)
                acum.Suma(clave, datos)

            Next
        End If



        'DESTRIO
        consulta = New Cdatos.E_select
        Dim KilosDes As New Cdatos.bdcampo("@SUM(PDL_Kilos)", Cdatos.TiposCampo.Importe, 10)
        consulta.SelCampo(ParteDestrio_Lineas.PDL_idgenero, "idgenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", ParteDestrio_Lineas.PDL_idgenero)
        consulta.SelCampo(KilosDes, "kilos")
        consulta.SelCampo(ParteDestrio.PDS_fecha, "fecha", ParteDestrio_Lineas.PDL_idparte, ParteDestrio.PDS_idparte)
        consulta.WheCampo(ParteDestrio.PDS_fecha, ">=", TxDato1.Text)
        consulta.WheCampo(ParteDestrio.PDS_fecha, "<=", TxDato2.Text)
        consulta.WheCampo(ParteDestrio.PDS_idcentro, "=", MiMaletin.IdCentro.ToString)
        sql = consulta.SQL
        sql = sql + " GROUP BY PDL_idgenero, GEN_NombreGenero,PDS_fecha"

        dt = Albsalida.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows

                Dim clave As New stClaves_cuadre(VaInt(rw("idgenero")), (rw("Genero").ToString & "").Trim)
                Dim datos As New stdatos_cuadre(0, 0, 0, VaDec(rw("kilos")), 0)
                acum.Suma(clave, datos)

            Next
        End If

       

        'FINALES
        consulta = New Cdatos.E_select
        Dim KilosFin As New Cdatos.bdcampo("@SUM(PSL_Kilos)", Cdatos.TiposCampo.Importe, 10)
        consulta.SelCampo(ParteSemanal_lineas.PSL_idgenero, "IdGenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", ParteSemanal_lineas.PSL_idgenero)
        consulta.SelCampo(KilosFin, "Kilos")
        consulta.SelCampo(ParteSemanal.PSM_fechafinal, "FechaFinal", ParteSemanal_lineas.PSL_idparte, ParteSemanal.PSM_idparte)
        consulta.WheCampo(ParteSemanal.PSM_fechafinal, "=", TxDato2.Text)
        consulta.WheCampo(ParteSemanal.PSM_idcentro, "=", MiMaletin.IdCentro.ToString)
        sql = consulta.SQL
        sql = sql & " GROUP BY PSL_IdGenero, GEN_NombreGenero, PSM_FechaFinal" & vbCrLf

        dt = Albentrada.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows

                Dim clave As New stClaves_cuadre(VaInt(row("idgenero")), (row("Genero").ToString & "").Trim)
                Dim datos As New stdatos_cuadre(0, 0, 0, 0, VaDec(row("kilos")))
                acum.Suma(clave, datos)

            Next
        End If



        Dim dtFinal As DataTable = acum.DataTable

        For Each row As DataRow In dtFinal.Rows

            Dim Existencias As Decimal = VaDec(row("Iniciales")) + VaDec(row("Compras")) - VaDec(row("Ventas")) - VaDec(row("Destrio"))
            row("Existencias") = Existencias

            Dim Finales As Decimal = VaDec(row("Finales"))

            If Finales <> Existencias Then
                row("Diferencia") = Finales - Existencias
            End If


        Next


        Grid.DataSource = dtFinal
        AjustaColumnas()

        AñadeResumenCampo("Iniciales", "{0:n0}")
        AñadeResumenCampo("Compras", "{0:n0}")
        AñadeResumenCampo("Ventas", "{0:n0}")
        AñadeResumenCampo("Destrio", "{0:n0}")
        AñadeResumenCampo("Existencias", "{0:n0}")
        AñadeResumenCampo("Finales", "{0:n0}")
        AñadeResumenCampo("Diferencia", "{0:n0}")


    End Sub


    Private Sub AjustaColumnas()

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "IDGENERO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "00000"
                    c.Width = 60

                Case "GENERO"


                Case Else
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    c.Width = 85

            End Select

                
        Next




    End Sub


    Public Overrides Sub Imprimir()


        LineasDescripcion.Clear()

        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDato1.Text, TxDato2.Text)

        If fechas <> "" Then LineasDescripcion.Add(fechas)


        MyBase.Imprimir()

    End Sub

    
End Class