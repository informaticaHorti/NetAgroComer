Public Class FrmBloqueoCultivos
    Inherits FrMantenimiento


    Dim BloqueoCultivos As New E_BloqueoCultivos(Idusuario, cn)
    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Cultivos As New E_Cultivos(Idusuario, cnFincasNET)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub



    Private Sub ParametrosFrm()
        EntidadFrm = BloqueoCultivos


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxId, BloqueoCultivos.BCU_IdBloqueo, LbCodigo, True)
        TxId.Autonumerico = True
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxFecha, BloqueoCultivos.BCU_Fecha, LbFecha, True)
        ParamTx(TxHora, BloqueoCultivos.BCU_Hora, LbHora)
        ParamTx(TxAgricultor, BloqueoCultivos.BCU_IdAgricultor, LbAgricultor, True)
        ParamTx(TxCultivo, BloqueoCultivos.BCU_IdCultivo, LbCultivo, True)
        ParamTx(TxDeFecha, BloqueoCultivos.BCU_DeFecha, LbDeFecha, True)
        ParamTx(TxDeHora, BloqueoCultivos.BCU_DeHora, LbDeHora, True)
        ParamTx(TxAFecha, BloqueoCultivos.BCU_AFecha, LbAFecha, True)
        ParamTx(TxAHora, BloqueoCultivos.BCU_AHora, LbAHora, True)
        ParamTx(TxMotivo, BloqueoCultivos.BCU_Motivo, LbMotivo)


        AsociarControles(TxId, BtBuscaBloqueos, BloqueoCultivos.btBusca, EntidadFrm)
        AsociarControles(TxAgricultor, BtBuscaAgricultor, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNom_Agricultor)


        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub


    Public Overrides Sub ControlClave()

        ' componemos la clave
        LbId.Text = TxId.Text


    End Sub


    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()

    End Sub


    Public Overrides Sub Guardar()

        If TxId.Text = "+" Then
            LbId.Text = BloqueoCultivos.MaxId
            TxId.Text = LbId.Text
        End If

        MyBase.Guardar()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbPrincipal.Text = ""
        LbNom_Principal.Text = ""

    End Sub



    Private Sub TxCultivo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxCultivo.KeyDown
        If e.KeyCode = Keys.F2 Then
            BuscaCultivos()
        End If
    End Sub


    Private Sub BtBuscaCultivo_Click(sender As System.Object, e As System.EventArgs) Handles BtBuscaCultivo.Click
        BuscaCultivos()
    End Sub


    Private Sub BuscaCultivos()

        If EsTecnicosNet() Then
            Dim frm As New FrmEntradaFincas_NET
            frm.Init(TxAgricultor.Text, "", "")
            frm.ShowDialog()
        End If


        If Not RowDePaso Is Nothing Then
            If TxCultivo.Enabled = True Then
                TxCultivo.Text = VaInt(RowDePaso("idcultivo")).ToString
            End If
        End If

    End Sub


    Private Sub TxCultivo_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxCultivo.EnabledChanged
        BtBuscaCultivo.Enabled = TxCultivo.Enabled
    End Sub


    Private Sub TxHora_Valida(edicion As System.Boolean) Handles TxHora.Valida
        If edicion Then

            If TxHora.Text.Trim = "" Then TxHora.Text = Now.ToString("HH:mm")

            If Not ValidaHora(TxHora) Then
                TxHora.MiError = True
            End If

        End If
    End Sub


    Private Sub TxDeHora_Valida(edicion As System.Boolean) Handles TxDeHora.Valida
        If edicion Then
            If Not ValidaHora(TxDeHora) Then
                TxDeHora.MiError = True
            End If
        End If
    End Sub


    Private Sub TxAHora_Valida(edicion As System.Boolean) Handles TxAHora.Valida
        If edicion Then
            If Not ValidaHora(TxAHora) Then
                TxAHora.MiError = True
            End If
        End If
    End Sub


    Private Function ValidaHora(tx As TxDato) As Boolean

        Dim hora As String = tx.Text

        If hora.Length = 1 Or hora.Length = 2 Then
            hora = hora.PadRight(4, "0")
        End If

        If hora.Length = 3 And IsNumeric(hora) Then
            hora = hora.PadLeft(4, "0")
        End If

        If IsDate(hora) Then
            hora = hora.PadLeft(5, "0")
            tx.Text = hora
        End If

        If hora.Length = 4 And IsNumeric(hora) Then
            hora = VaInt(hora.Substring(0, 2)).ToString("00") & ":" & VaInt(hora.Substring(2, 2)).ToString("00")
            tx.Text = hora
        End If

        hora = Today.ToString("dd/MM/yyyy") & " " & hora & ":00"



        Return IsDate(hora)

    End Function


    Private Sub LeerPrincipal()

        Dim IdAgricultor As String = TxAgricultor.Text

        If VaInt(IdAgricultor) > 0 Then

            Dim sql As String = "SELECT AGR2.AGR_IdAgricultor as IdPrincipal, AGR2.AGR_Nombre as Principal " & vbCrLf
            sql = sql & " FROM Agricultores AGR1" & vbCrLf
            sql = sql & " LEFT JOIN Agricultores AGR2 ON AGR1.AGR_IdPrincipal = AGR2.AGR_IdAgricultor"
            sql = sql & " WHERE AGR1.AGR_IdAgricultor = " & IdAgricultor & vbCrLf

            Dim dt As DataTable = Agricultores.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    LbPrincipal.Text = (dt.Rows(0)("IdPrincipal").ToString & "").Trim
                    LbNom_Principal.Text = (dt.Rows(0)("Principal").ToString & "").Trim

                End If
            End If

        End If

    End Sub


    Private Sub TxAgricultor_Valida(edicion As System.Boolean) Handles TxAgricultor.Valida

        LeerPrincipal()

    End Sub


    Private Sub TxCultivo_Valida(edicion As System.Boolean) Handles TxCultivo.Valida


        TxCultivo.MiError = False
        LbNomCultivo.Text = ""


        Dim Cultivos As New E_Cultivos(Idusuario, cnFincasNET)
        If Cultivos.LeerId(TxCultivo.Text) Then

            Dim Activo As String = (Cultivos.CUL_Activo.Valor & "").Trim.ToUpper
            If Activo = "S" Then

                Dim IdFinca As String = (Cultivos.CUL_IdFinca.Valor & "").Trim

                Dim Fincas As New E_Fincas(IdFinca, cnFincasNET)
                If Fincas.LeerId(IdFinca) Then

                    Dim IdAgricultor As String = (Fincas.FIN_IdAgricultor.Valor & "").Trim
                    If VaInt(IdAgricultor) <> VaInt(TxAgricultor.Text) Then
                        TxCultivo.MiError = True
                        MsgBox("El cultivo no es de este agricultor")
                    Else
                        LbNomCultivo.Text = NombreGeneroCultivoNET(TxCultivo.Text)
                    End If

                Else
                    TxCultivo.MiError = True
                    MsgBox("Error al leer la finca")
                End If

            Else
                TxCultivo.MiError = True
                MsgBox("El cultivo no está activo")
            End If

        Else
            TxCultivo.MiError = True
        End If


    End Sub
End Class