Public Class FrmIBANAgricultores
    Inherits FrMantenimiento



    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Agricultores_IBAN As New E_Agricultores_IBAN(Idusuario, cn)


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

        ParamTx(TxAgricultor, Agricultores.AGR_IdAgricultor, LbAgricultor, True)
        CampoClave = 0 ' ultimo campo de la clave

        ParamTx(TxEntidad, Agricultores_IBAN.AIB_Entidad, LbEntidad, True)
        ParamTx(TxIBAN, Agricultores_IBAN.AIB_IBAN, LbIBAN, True)

        AsociarControles(TxAgricultor, BtBuscaAgricultor, Agricultores.btBusca, EntidadFrm, Agricultores.AGR_Nombre, LbNomAgricultor)


        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me

        AsociarGrid(ClGrid1, TxEntidad, TxIBAN, Agricultores_IBAN)

        PropiedadesCamposGr(ClGrid1, Agricultores_IBAN.AIB_Id.NombreCampo, "", False, 0)
        PropiedadesCamposGr(ClGrid1, "Entidad", "Entidad", True, 50)
        PropiedadesCamposGr(ClGrid1, "IBAN", "IBAN", True, 50)


    End Sub


    Public Overrides Sub ControlClave()

        ' componemos la clave
        LbId.Text = TxAgricultor.Text


    End Sub


    Private Sub FrmIBANAgricultores_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BAnular.Visible = False

    End Sub


    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()

        CargaLineasGrid()

    End Sub


    Private Sub CargaLineasGrid()


        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 
        Dim sql As String
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Agricultores_IBAN.AIB_Id, "AIB_Id")
        consulta.SelCampo(Agricultores_IBAN.AIB_Entidad, "Entidad")
        consulta.SelCampo(Agricultores_IBAN.AIB_IBAN, "IBAN")
        consulta.WheCampo(Agricultores_IBAN.AIB_IdAgricultor, "=", TxAgricultor.Text)

        sql = consulta.SQL
        ClGrid1.Consulta = sql
        ClGrid1.Nlinea = -1

        Cargalineas(ClGrid1)

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean

        'asociar cabecera con lineas
        Agricultores_IBAN.AIB_IdAgricultor.Valor = LbId.Text

        Return MyBase.GuardarLineas(Gr)

    End Function


    Private Sub TxIBAN_Valida(edicion As System.Boolean) Handles TxIBAN.Valida

        If edicion Then


            If Not CompruebaIBAN(TxIBAN.Text) Then
                TxIBAN.MiError = True
                MsgBox("El IBAN no tiene un formato correcto")
            Else
                TxIBAN.MiError = False
            End If


            If Not TxIBAN.MiError Then

                Dim row As DataRow = ClGrid1.GridView.GetFocusedDataRow()
                If Not IsNothing(row) Then

                    Dim IdLinea As String = (row("AIB_Id").ToString & "").Trim

                    Dim sql As String = "SELECT COUNT(AIB_Id) as Cont FROM Agricultores_IBAN WHERE AIB_IdAgricultor = " & LbId.Text & " AND AIB_IBAN = '" & TxIBAN.Text & "'"
                    If VaDec(IdLinea) > 0 Then
                        sql = sql & " AND AIB_Id <> " & IdLinea
                    End If

                    Dim dt As DataTable = Agricultores.MiConexion.ConsultaSQL(sql)

                    If Not IsNothing(dt) Then
                        If dt.Rows.Count > 0 Then

                            Dim cont As Integer = VaInt(dt.Rows(0)("Cont"))
                            If cont > 0 Then
                                MsgBox("El IBAN introducido ya existe para este agricultor")
                                TxIBAN.MiError = True
                            Else
                                TxIBAN.MiError = False
                            End If

                        End If

                    End If

                End If

            End If

            

        End If


    End Sub



    


End Class