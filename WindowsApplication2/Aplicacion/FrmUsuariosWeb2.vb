Public Class FrmUsuariosWeb2
    Inherits FrMantenimiento


    Dim UsuariosWeb As New E_UsuariosWeb(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()


    End Sub


    Private Sub ParametrosFrm()
        EntidadFrm = Agricultores


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxCodigo, Agricultores.AGR_IdAgricultor, LbCodigo, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxClave, UsuariosWeb.UWB_Password, LbClave, True)


        AsociarControles(TxCodigo, BtBuscaCodigo, Agricultores.btBusca, EntidadFrm)

        '    BotonesAvance1.Mientidad = EntidadFrm
        '    BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        '    BotonesAvance1.Formulario = Me


    End Sub


    Public Overrides Sub ControlClave()
        MyBase.ControlClave()

    End Sub


    Public Overrides Sub Guardar()
        'MyBase.Guardar()

        If TxClave.Text.Trim = "" Then
            MsgBox("Debe introducir una clave")
            Exit Sub
        End If


        If VaInt(LbId.Text) > 0 Then

            'Borramos los que había
            Dim sql As String = "DELETE FROM UsuariosWeb WHERE UWB_Codigo = " & LbId.Text
            UsuariosWeb.MiConexion.OrdenSql(sql)

            'Creamos la cabecera
            Dim UsuarioPrincipal As New E_UsuariosWeb(Idusuario, cn)
            UsuarioPrincipal.UWB_Id.Valor = UsuarioPrincipal.MaxId()
            UsuarioPrincipal.UWB_Codigo.Valor = LbId.Text
            UsuarioPrincipal.UWB_Linea.Valor = "0"
            UsuarioPrincipal.UWB_IdAgricultor.Valor = LbId.Text
            UsuarioPrincipal.UWB_Password.Valor = TxClave.Text
            UsuarioPrincipal.Insertar()


            'Creamos los asociados
            Dim nLinea As Integer = 1

            For indice As Integer = 0 To GridView1.RowCount - 1
                Dim row As DataRow = GridView1.GetDataRow(indice)
                If Not IsNothing(row) Then
                    If row("S") Then

                        Dim IdAgricultor As String = (row("CodAgr").ToString & "").Trim

                        Dim Asociado As New E_UsuariosWeb(Idusuario, cn)
                        Asociado.UWB_Id.Valor = Asociado.MaxId()
                        Asociado.UWB_Codigo.Valor = LbId.Text
                        Asociado.UWB_Linea.Valor = nLinea.ToString
                        Asociado.UWB_IdAgricultor.Valor = IdAgricultor
                        Asociado.UWB_Password.Valor = TxClave.Text
                        Asociado.Insertar()

                        nLinea = nLinea + 1

                    End If
                End If
            Next


        End If



    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

        ' llenar el grid
        CargaGrid()


    End Sub


    Public Sub CargaGrid()

        Grid.DataSource = Nothing

        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(UsuariosWeb.UWB_Id, "Id")
        CONSULTA.SelCampo(UsuariosWeb.UWB_IdAgricultor, "CodAgr")
        CONSULTA.SelCampo(Agricultores.AGR_Nombre, "Nombre", UsuariosWeb.UWB_IdAgricultor, Agricultores.AGR_IdAgricultor)
        CONSULTA.WheCampo(UsuariosWeb.UWB_Codigo, "=", LbId.Text)
        CONSULTA.WheCampo(UsuariosWeb.UWB_IdAgricultor, "<>", LbId.Text)

        Dim sql As String = CONSULTA.SQL & vbCrLf
        sql = sql & " ORDER BY UWB_IdAgricultor "

        Dim dt As DataTable = UsuariosWeb.MiConexion.ConsultaSQL(sql)

        Dim col As New DataColumn("S", GetType(Boolean))
        col.DefaultValue = False
        dt.Columns.Add(col)

        Grid.DataSource = dt

        AjustaColumnas()


    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "ID"
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "CODAGR"
                    c.MinWidth = 50
                    c.MaxWidth = 50
                Case "S"
                    c.MinWidth = 25
                    c.MaxWidth = 25
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            End Select
        Next


    End Sub



    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Grid.DataSource = Nothing

    End Sub


    Public Overrides Sub Anular()
        'MyBase.Anular()

        If MsgBox("Desea anular el registro", vbYesNo) = vbYes Then

            Dim UsuariosWeb As New E_UsuariosWeb(Idusuario, cn)


            If VaInt(LbId.Text) > 0 Then

                Dim CONSULTA As New Cdatos.E_select
                CONSULTA.SelCampo(UsuariosWeb.UWB_Id, "Id")
                CONSULTA.WheCampo(UsuariosWeb.UWB_Codigo, "=", LbId.Text)

                Dim sql As String = CONSULTA.SQL
                Dim dt As DataTable = UsuariosWeb.MiConexion.ConsultaSQL(sql)

                If Not IsNothing(dt) Then

                    For Each row As DataRow In dt.Rows
                        Dim Id As String = (row("Id").ToString & "").Trim
                        If UsuariosWeb.LeerId(Id) Then
                            UsuariosWeb.Eliminar()
                        End If
                    Next

                End If

            End If

            BorraPan()


        End If



    End Sub

End Class