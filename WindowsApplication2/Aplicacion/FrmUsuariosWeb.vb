Public Class FrmUsuariosWeb
    Inherits FrMantenimiento


    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Asociado As New E_Agricultores(Idusuario, cn)
    Dim UsuariosWeb As New E_UsuariosWeb(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub



    Private Sub ParametrosFrm()
        EntidadFrm = Agricultores


        Dim lc As New List(Of Object)
        ListaControles = lc


        ParamTx(TxCodigo, Agricultores.AGR_IdAgricultor, LbCodigo, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxClave, UsuariosWeb.UWB_Password, LbClave, True)
        ParamTx(TxEmailCalidad, Agricultores.AGR_EmailCalidad, LbEmailCalidad)
        ParamTx(TxMail, Agricultores.AGR_Mail, LbMail)
        ParamTx(TxCenvases, Agricultores.AGR_idenvases, LbCenvases)

        ParamTx(TxAsociado, UsuariosWeb.UWB_IdAgricultor, LbAsociado, True)



        AsociarControles(TxCodigo, BtBuscaCodigo, Agricultores.btBusca, EntidadFrm, Agricultores.AGR_Nombre, LbNom_Codigo)
        AsociarControles(TxAsociado, BtBuscaAsociado, Asociado.btBusca, Asociado, Asociado.AGR_Nombre, LbNom_Asociado)
        AsociarControles(TxCenvases, BtBuscaCenvases, Agricultores.btBusca, Agricultores)


        AsociarGrid(ClGrid1, TxAsociado, TxAsociado, UsuariosWeb)

        PropiedadesCamposGr(ClGrid1, "UWB_Id", "", False, 0)
        PropiedadesCamposGr(ClGrid1, "CodAgr", "CodAgr", True, 5)
        PropiedadesCamposGr(ClGrid1, "Nombre", "Nombre", True, 100)


        'BotonesAvance1.Mientidad = EntidadFrm
        'BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        'BotonesAvance1.Formulario = Me


    End Sub


    Public Overrides Sub ControlClave()
        MyBase.ControlClave()

        CargaLineasGrid()

    End Sub


    Public Overrides Sub Guardar()

        GuardaCabecera()

        MyBase.Guardar()


    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

        Dim UsuariosWeb As New E_UsuariosWeb(Idusuario, cn)
        If UsuariosWeb.LeerUsuario(TxCodigo.Text) Then
            TxClave.Text = UsuariosWeb.UWB_Password.Valor
        End If


        ' llenar el grid
        CargaLineasGrid()


    End Sub


    Public Overrides Sub Entidad_a_DatosLin(Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)


    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas

        GuardaCabecera()


        UsuariosWeb.UWB_Codigo.Valor = LbId.Text
        UsuariosWeb.UWB_Password.Valor = TxClave.Text

        Dim nLinea As Integer = VaInt(UsuariosWeb.UWB_Linea.Valor)
        If nLinea = 0 Then
            If Not IsNothing(ClGrid1.Grid.DataSource) Then
                nLinea = CType(ClGrid1.Grid.DataSource, DataTable).Rows.Count
                If nLinea = 0 Then nLinea = 1
            Else
                nLinea = 1
            End If
        End If

        UsuariosWeb.UWB_Linea.Valor = nLinea.ToString


        Return MyBase.GuardarLineas(Gr)

        Return True

    End Function


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub


    Public Overrides Sub Borralin(gr As ClGrid)
        MyBase.Borralin(gr)
    End Sub


    Private Sub GuardaCabecera()


        Dim Principal As New E_UsuariosWeb(Idusuario, cn)
        If Principal.LeerUsuario(TxCodigo.Text) > 0 Then

            'Actualizo cabecera
            Principal.UWB_Password.Valor = TxClave.Text
            Principal.Actualizar()

            'Actualizo hijos
            Dim sql As String = "SELECT UWB_Id as Id FROM UsuariosWeb WHERE UWB_Codigo = " & TxCodigo.Text & " AND UWB_Linea > 0 "
            Dim dt As DataTable = UsuariosWeb.MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then

                Dim Asociado As New E_UsuariosWeb(Idusuario, cn)

                For Each row As DataRow In dt.Rows

                    Dim IdAsociado As String = (row("Id").ToString & "").Trim
                    If Asociado.LeerId(IdAsociado) Then
                        Asociado.UWB_Password.Valor = TxClave.Text
                        Asociado.Actualizar()
                    End If

                Next

            End If

        Else

            Principal = New E_UsuariosWeb(Idusuario, cn)
            Principal.UWB_Id.Valor = Principal.MaxId()
            Principal.UWB_Codigo.Valor = TxCodigo.Text
            Principal.UWB_Linea.Valor = "0"
            Principal.UWB_IdAgricultor.Valor = "0"
            Principal.UWB_Password.Valor = TxClave.Text
            Principal.Insertar()

        End If

        

    End Sub


    Private Sub CargaLineasGrid()
        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        Dim sql As String = "SELECT UWB_Id, UWB_IdAgricultor as CodAgr, AGR_Nombre as Nombre FROM UsuariosWeb LEFT JOIN Agricultores ON AGR_IdAgricultor = UWB_IdAgricultor WHERE UWB_Codigo = " & LbId.Text & " AND UWB_Linea > 0 "

        ClGrid1.Consulta = sql
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)

    End Sub



    Public Overrides Sub Anular()
        'MyBase.Anular()

        If VaInt(LbId.Text) > 0 Then

            If MsgBox("Desea anular el registro", vbYesNo) = vbYes Then

                'Borro cabecera
                Dim UsuariosWeb As New E_UsuariosWeb(Idusuario, cn)
                If UsuariosWeb.LeerUsuario(TxCodigo.Text) Then
                    UsuariosWeb.Eliminar()
                End If


                'Borro hijos
                Dim sql As String = "SELECT UWB_Id as Id FROM UsuariosWeb WHERE UWB_Codigo = " & TxCodigo.Text
                Dim dt As DataTable = UsuariosWeb.MiConexion.ConsultaSQL(sql)

                If Not IsNothing(dt) Then

                    Dim Asociado As New E_UsuariosWeb(Idusuario, cn)

                    For Each row As DataRow In dt.Rows

                        Dim IdAsociado As String = (row("Id").ToString & "").Trim
                        If Asociado.LeerId(IdAsociado) Then
                            Asociado.Eliminar()
                        End If

                    Next
                End If


                BorraPan()


            End If

        End If


    End Sub


    Private Sub TxCenvases_Valida(edicion As Boolean) Handles TxCenvases.Valida

        Dim Agricultor As New E_Agricultores(Idusuario, cn)

        If VaInt(TxCenvases.Text) = 0 Then
            TxCenvases.Text = TxCodigo.Text
        End If

        If VaInt(TxCenvases.Text) = VaInt(TxCodigo.Text) Then
            LbNomCenvases.Text = LbNom_Codigo.Text
        Else
            If Agricultor.LeerId(TxCenvases.Text) = True Then
                LbNomCenvases.Text = Agricultor.AGR_Nombre.Valor
            Else
                TxCenvases.MiError = True
            End If
        End If

    End Sub




End Class


