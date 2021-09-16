Public Class FrmTarifaPortes
    Inherits FrMantenimiento
    Dim TarifaPortes As New E_TarifaPortes(Idusuario, cn)
    Dim GastoComercio As New E_GastosComercio(Idusuario, cn)
    Dim MedidasPalet As New E_MedidasPalet(Idusuario, cn)
    Dim OrigenGastos As New E_OrigenGastos(Idusuario, cn)
  




    Private Sub ParametrosFrm()
        EntidadFrm = TarifaPortes


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxCodigo, TarifaPortes.TPV_Id, LbCodigo, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxNombre, TarifaPortes.TPV_Nombre, LbNombre)
        ParamTx(TxPalet1, TarifaPortes.TPV_Precio1, LbPalet1)
        ParamTx(TxPalet2, TarifaPortes.TPV_Precio2, LbPalet2)
        ParamTx(TxPalet3, TarifaPortes.TPV_Precio3, LbPalet3)
        ParamTx(TxPalet4, TarifaPortes.TPV_Precio4, LbPalet4)
        'ParamTx(TxPalet5, TarifaPortes.TPV_Precio5, LbPalet5)
        ParamTx(TxEnvio, TarifaPortes.TPV_PrecioEnvio, LbEnvio)
        ParamTx(TxGasto, TarifaPortes.TPV_idgasto, LbGasto, True)




        AsociarControles(TxCodigo, BtBusca, TarifaPortes.btBusca, EntidadFrm)
        AsociarControles(TxGasto, BtGasto, GastoComercio.btBusca, GastoComercio, GastoComercio.GCO_Nombre, LbNomGasto)



        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me
        PintaPalets()



    End Sub


    Private Sub PintaPalets()

        Dim sql As String = "Select PLM_id as id,PLM_medidas as Medidas from MEDIDASPALET ORDER BY PLM_ID"

        Dim dt As DataTable = MedidasPalet.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then

            For Each RW In dt.Rows

                Dim Id As Integer = VaInt(RW("ID"))

                Select Case Id

                    Case 1
                        LbPalet1.Text = RW("MEDIDAS").ToString
                        If LbPalet1.Text <> "" Then LbPalet3.Text = LbPalet1.Text & " RAPIDO"

                    Case 2
                        LbPalet2.Text = RW("MEDIDAS").ToString
                        If LbPalet2.Text <> "" Then LbPalet4.Text = LbPalet2.Text & " RAPIDO"

                        'Case 3
                        '    LbPalet3.Text = RW("MEDIDAS").ToString
                        'Case 4
                        '    LbPalet4.Text = RW("MEDIDAS").ToString
                        'Case 5
                        '    LbPalet5.Text = RW("MEDIDAS").ToString
                End Select

            Next

        End If

    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxCodigo.Text


    End Sub
    Public Overrides Sub Guardar()
        Dim a = ""
      
        MyBase.Guardar()


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub






    Private Sub TxGasto_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxGasto.TextChanged

    End Sub

    Private Sub TxGasto_Valida(edicion As Boolean) Handles TxGasto.Valida
        Dim TipoGasto As String = ""
        If edicion = True Then
            If GastoComercio.LeerId(TxGasto.Text) = True Then
                If OrigenGastos.LeerId(GastoComercio.GCO_idgrupo.Valor) = True Then
                    TipoGasto = OrigenGastos.ORG_tipo.Valor
                End If
            End If
            If TipoGasto <> "PV" Then
                MsgBox("Debe asignar un gasto de porte de venta")
                TxGasto.MiError = True
            End If

        End If
    End Sub
End Class