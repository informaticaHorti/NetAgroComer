
Public Class FrmLogs

    Inherits FrConsulta


    Private Usuarios As New E_Usuarios(Idusuario, Cncomun)
    Private LogUsuarios As New E_LogusuariosApl(Idusuario, cn)




    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato_1, Nothing, Lb1, True, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDato_2, Nothing, Lb2, True, Cdatos.TiposCampo.Fecha)


        Dim dtUsuarios As DataTable = Usuarios.Tabla
        Dim dtTablas As DataTable = ObtenerTablasAplicacion()
        Dim dtOperaciones As DataTable = PermisosFormularios.Tabla


        Dim row As DataRow = dtUsuarios.NewRow
        row("IdUsuario") = 0
        row("Nombre") = "TODOS"
        dtUsuarios.Rows.InsertAt(row, 0)

        'row = dtTablas.NewRow()
        'row("Tabla") = "TODAS"
        'dtTablas.Rows.InsertAt(row, 0)

        row = dtOperaciones.NewRow()
        row("Id") = "TODAS"
        row("Nombre") = "TODAS"
        dtOperaciones.Rows.InsertAt(row, 0)


        ParamCbFIJO(CbUsuario, Usuarios.IdUsuario, dtUsuarios, Lb3)
        CbUsuario.DisplayMember = "Nombre"
        CbUsuario.ValueMember = "IdUsuario"
        ParamCbFIJO(CbTabla, LogUsuarios.tabla, dtTablas, Lb4)
        CbTabla.DisplayMember = "Tabla"
        CbTabla.ValueMember = "Tabla"
        ParamCbFIJO(CbOperacion, LogUsuarios.operacion, dtOperaciones, Lb5)
        CbOperacion.DisplayMember = "Nombre"
        CbOperacion.ValueMember = "Id"

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub



    Public Overrides Sub Consultar()

        MyBase.Consultar()

        Dim logusuarios As New E_LogusuariosApl(Idusuario, cn)
        Dim usuarios As New E_Usuarios(Idusuario, CnComun)

        Dim Consulta As New Cdatos.E_select
        Dim DT As New DataTable
        Dim sql As String

        Consulta.SelCampo(logusuarios.Id, "Id")
        Consulta.SelCampo(logusuarios.Iduser, "iduser")
        Consulta.SelCampo(usuarios.Nombre, "Usuario", logusuarios.Iduser)
        Consulta.SelCampo(logusuarios.Fecha, "Fecha")
        Consulta.SelCampo(logusuarios.hora, "Hora")
        Consulta.SelCampo(logusuarios.operacion, "Operacion")
        Consulta.SelCampo(logusuarios.idaplicacion, "Aplicacion")
        Consulta.SelCampo(logusuarios.tabla, "Tabla")
        Consulta.SelCampo(logusuarios.clave, "Clave")
        Consulta.SelCampo(logusuarios.datosregistro, "DatosRegistro")
        If VaDate(TxDato_1.Text) > VaDate("") Then Consulta.WheCampo(logusuarios.Fecha, ">=", TxDato_1.Text)
        If VaDate(TxDato_2.Text) > VaDate("") Then Consulta.WheCampo(logusuarios.Fecha, "<=", TxDato_2.Text)

        If VaInt(CbUsuario.SelectedValue) > 0 Then
            Consulta.WheCampo(logusuarios.Iduser, "=", CbUsuario.SelectedValue.ToString)
        End If

        If CbOperacion.SelectedValue <> "TODAS" Then
            Consulta.WheCampo(logusuarios.operacion, "=", CbOperacion.SelectedValue.ToString)
        End If

        If CbTabla.SelectedValue.ToString.Trim.ToUpper <> "TODAS" Then
            Consulta.WheCampo(logusuarios.tabla, "=", CbTabla.SelectedValue.ToString)
        End If

        sql = Consulta.SQL
        DT = logusuarios.MiConexion.ConsultaSQL(Consulta.SQL)


        If CbOperacion.SelectedValue = "TODAS" Or CbOperacion.SelectedValue = "ALTAS" Then
            DT = AñadirAltas(DT, CbTabla.SelectedValue.ToString)
        End If



        Dim dv As New DataView(DT)
        dv.Sort = "Fecha DESC,HORA DESC"
        DT = dv.ToTable

        Grid.DataSource = DT
        'GridView1.BestFitColumns()
        AjustaTamañoColumnas()

        PlantillaConsulta1.AplicaConfiguracionPlantilla()

    End Sub

    Private Function AñadirAltas(dt As DataTable, Tabla As String) As DataTable
        Dim usuarios As New E_Usuarios(Idusuario, CnComun)

        For Each enti In Cdatos.ListaEntidades
            If enti.NombreTabla.ToUpper = Tabla.ToUpper And enti.NombreBd.ToUpper = "NETAGROCOMER" Then
                Dim prefijo As String = ""
                Dim I As Integer = InStr(enti.ClavePrimaria.NombreCampo, "_")
                If I = 4 Then
                    prefijo = Mid(enti.ClavePrimaria.NombreCampo, 1, 4)
                End If
                Dim clave As String = enti.ClavePrimaria.NombreCampo
                Dim uLOG As String = prefijo + "idusuariolog"
                Dim fLOG As String = prefijo + "fechalog"
                Dim HLOG As String = prefijo + "horalog"
                Dim sql As String = "Select " + clave + " , " + uLOG + " , " + fLOG + " , " + HLOG + " from " + enti.NombreTabla + " WHERE " + fLOG + ">='" + TxDato_1.Text + "' AND " + fLOG + "<='" + TxDato_2.Text + "' "
                If VaInt(CbUsuario.SelectedValue) > 0 Then
                    sql = sql + " AND " + uLOG + "=" + CbUsuario.SelectedValue.ToString
                End If
                sql = sql + " ORDER BY " + fLOG + "," + HLOG
                Dim dtaltas As DataTable = enti.MiConexion.ConsultaSQL(sql)
                If Not dtaltas Is Nothing Then
                    For Each rw In dtaltas.Rows
                        Dim iduser As Integer = VaInt(rw(uLOG))
                        Dim vclave As String = rw(clave).ToString
                        Dim fecha As String = Format(CDate(rw(fLOG)), "dd-MM-yyyy")
                        Dim hora As String = rw(HLOG).ToString
                        Dim usuario As String = ""
                        If usuarios.LeerId(iduser) = True Then
                            usuario = usuarios.Nombre.Valor
                        End If

                        dt.Rows.Add(0, iduser, usuario, fecha, hora, "A", 0, enti.NombreTabla, vclave, "")
                    Next
                End If
            End If
        Next
        Return dt
    End Function

    Private Sub AjustaTamañoColumnas()

        GridView1.BestFitColumns()

        With GridView1.Columns

            If Not IsNothing(.ColumnByFieldName("Id")) Then
                With .ColumnByFieldName("Id")
                    .MinWidth = 60
                    
                End With
            End If

            If Not IsNothing(.ColumnByFieldName("IdUser")) Then
                With .ColumnByFieldName("IdUser")
                    .MinWidth = 45
                    .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                End With
            End If

            If Not IsNothing(.ColumnByFieldName("Fecha")) Then
                With .ColumnByFieldName("Fecha")
                    .MinWidth = 95
                    .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                End With
            End If

            If Not IsNothing(.ColumnByFieldName("Hora")) Then
                With .ColumnByFieldName("Hora")
                    .MinWidth = 70
                    .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                End With
            End If

            If Not IsNothing(.ColumnByFieldName("Operacion")) Then
                With .ColumnByFieldName("Operacion")
                    .MinWidth = 65
                    .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                End With
            End If

            If Not IsNothing(.ColumnByFieldName("IdAplicacion")) Then
                With .ColumnByFieldName("IdAplicacion")
                    .MinWidth = 45
                    .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                End With
            End If

            If Not IsNothing(.ColumnByFieldName("Tabla")) Then
                With .ColumnByFieldName("Tabla")
                    .MinWidth = 100
                End With
            End If

            If Not IsNothing(.ColumnByFieldName("Usuario")) Then
                With .ColumnByFieldName("Usuario")
                    .MinWidth = 100
                End With
            End If



            If Not IsNothing(.ColumnByFieldName("Clave")) Then
                With .ColumnByFieldName("Clave")
                    .MinWidth = 60
                    .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                End With
            End If


            'If Not IsNothing(.ColumnByFieldName("Fecha")) Then .ColumnByFieldName("Fecha").MinWidth = 95
            'If Not IsNothing(.ColumnByFieldName("Hora")) Then .ColumnByFieldName("Hora").MinWidth = 70
            'If Not IsNothing(.ColumnByFieldName("Operacion")) Then .ColumnByFieldName("Operacion").MinWidth = 65
            'If Not IsNothing(.ColumnByFieldName("IdAplicacion")) Then .ColumnByFieldName("IdAplicacion").MinWidth = 45
            'If Not IsNothing(.ColumnByFieldName("Tabla")) Then .ColumnByFieldName("Tabla").MinWidth = 100
            'If Not IsNothing(.ColumnByFieldName("Clave")) Then .ColumnByFieldName("Clave").MinWidth = 60

        End With

    End Sub

    
    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)

        Dim frm As New FrVerLog
        frm.init(CInt(row("Id")))
        frm.ShowDialog()

    End Sub


    Private Sub FrmLogs_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        CbUsuario.SelectedIndex = 0
        CbTabla.SelectedIndex = 0
        CbOperacion.SelectedIndex = 0

        FechasPorDefecto()

        Consultar()

    End Sub


    Private Sub FechasPorDefecto()

        TxDato_1.Text = Today.ToString("dd/MM/yyyy")
        TxDato_2.Text = Today.ToString("dd/MM/yyyy")

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        FechasPorDefecto()

    End Sub


    Private Sub Grid_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class