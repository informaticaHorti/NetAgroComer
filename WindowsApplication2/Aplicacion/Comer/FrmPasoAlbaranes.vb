
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic




Public Class FrmPasoAlbaranes



    Inherits FrConsulta

    Dim _Campa As Integer
    Dim _Centro As Integer




    Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
    Dim New_albentrada As New E_AlbEntrada(Idusuario, CnAuditoria)

    Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim new_Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, CnAuditoria)

    Dim Albentrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)
    Dim new_Albentrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, CnAuditoria)


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


    End Sub


    Private Sub FrmCuadreKilosComer_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BInforme.Visible = False

    End Sub



    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid()


    End Sub


    Private Sub CargaGrid()

        _Campa = MiMaletin.Ejercicio
        _Centro = MiMaletin.IdCentro



        If cadenaconexionAuditoria = "" Then
            MsgBox("No existe cadena conexion auditoria")
            Exit Sub
        End If

        CnAuditoria.AbrirConexion()

        Dim dt As New DataTable

        dt.Columns.Add(New DataColumn("Tipo", GetType(System.String)))
        dt.Columns.Add(New DataColumn("Numero", GetType(System.String)))
        dt.Columns.Add(New DataColumn("Fecha", GetType(System.String)))
        dt.Columns.Add(New DataColumn("Id", GetType(System.String)))


        ' compras

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Albentrada.AEN_Albaran, "Numero")
        consulta.SelCampo(Albentrada.AEN_Fecha, "Fecha")
        consulta.selcampo(Albentrada.AEN_IdAlbaran, "Id")
        consulta.WheCampo(Albentrada.AEN_Fecha, ">=", TxDato1.Text)
        consulta.WheCampo(Albentrada.AEN_Fecha, "<=", TxDato2.Text)
        consulta.WheCampo(Albentrada.AEN_IdCentro, "=", MiMaletin.IdCentro.ToString)
        consulta.WheCampo(Albentrada.AEN_Campa, "=", MiMaletin.Ejercicio.ToString)
        Dim sql As String = consulta.SQL

        Dim dtcom As DataTable = Albentrada.MiConexion.ConsultaSQL(sql)

        If Not dtcom Is Nothing Then
            For Each rw In dtcom.Rows

                dt.Rows.Add("ENTRADA", rw("numero").ToString, FnLeft(rw("fecha").ToString, 10), rw("id").ToString)
                Dim Albaran As Integer = VaInt(rw("numero"))

                Dim idnew As Integer = New_albentrada.LeerAlb(_Campa, _Centro, Albaran)
                If idnew = 0 Or ChkAltas.CheckState = CheckState.Unchecked Then

                    pasoentradas(VaInt(rw("id").ToString), idnew)


                End If

            Next
        End If

        Grid.DataSource = dt
        AjustaColumnas()



    End Sub



    Private Sub PasoEntradas(idalbaran As Integer, idalbarannew As Integer)

        Dim NuevoidAlbaran As String = ""
        Dim NuevoidAlbhis As String = ""
        If idalbarannew > 0 Then
            BorrarEntradas(idalbarannew)
        End If
        NuevoidAlbaran = PasoEntidadEntradas(Albentrada, New_albentrada, idalbaran, "", "").ToString

        Dim sql As String = "Select AEL_idlinea from albentrada_lineas where AEL_idalbaran" = idalbaran.ToString
        Dim dt As DataTable = CnAuditoria.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                PasoEntidadEntradas(Albentrada_lineas, new_Albentrada_lineas, rw("ael_idlinea").ToString, NuevoidAlbaran, "")
            Next
        End If

        sql = "Select AEL_idlinea from albentrada_lineas where AEL_idalbaran" = idalbaran.ToString
        dt = CnAuditoria.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                PasoEntidadEntradas(Albentrada_lineascla, new_Albentrada_lineascla, rw("ael_idlinea").ToString, NuevoidAlbaran, "")
            Next
        End If


    End Sub

    Private Function PasoEntidadEntradas(Origen As Cdatos.Entidad, Destino As Cdatos.Entidad, idorigen As String, NuevoIdalbaran As String, NuevoIdAlbhis As String) As Integer
        Dim ret As Integer = 0
        If Origen.LeerId(idorigen) = True Then
            Dim idnew As Integer = Destino.MaxId
            ret = idnew
            For Each campo In Destino.ListadeCampos
                campo.Valor = Origen.ValorCampoTxt(campo.NombreCampo)
                Select Case campo.NombreCampo.ToUpper
                    Case "AEG_IDALBARAN", "AEH_IDALBARAN", "AHG_IDALBARAN", "AHL_IDALBARAN", "AEL_IDALBARAN", "ALC_IDALBARAN"
                        campo.Valor = NuevoIdalbaran


                End Select
            Next
            Destino.ClavePrimaria.Valor = idnew.ToString
            Destino.Insertar()
        End If
        Return ret
    End Function

    Private Sub BorrarEntradas(idalbarannew As Integer)

        Dim sql As String = ""
        sql = "Delete from albentrada where AEN_idalbaran=" + idalbarannew.ToString
        CnAuditoria.OrdenSql(sql)

        sql = "Delete from albentrada_gastos where AEG_idalbaran=" + idalbarannew.ToString
        CnAuditoria.OrdenSql(sql)

        sql = "Delete from albentrada_his where AEH_idalbaran=" + idalbarannew.ToString
        CnAuditoria.OrdenSql(sql)

        sql = "Delete from albentrada_hisgastos where AHG_idalbaran=" + idalbarannew.ToString
        CnAuditoria.OrdenSql(sql)

        sql = "Delete from albentrada_hislineas where AHL_idalbaran=" + idalbarannew.ToString
        CnAuditoria.OrdenSql(sql)

        sql = "Delete from albentrada_lineas where AEL_idalbaran=" + idalbarannew.ToString
        CnAuditoria.OrdenSql(sql)

        sql = "Delete from albentrada_lineascla where ALC_idalbaran=" + idalbarannew.ToString
        CnAuditoria.OrdenSql(sql)


    End Sub
    Private Sub AjustaColumnas()

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim




            End Select


        Next




    End Sub




End Class