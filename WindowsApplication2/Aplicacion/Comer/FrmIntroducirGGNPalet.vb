Public Class FrmIntroducirGGNPalet
    Inherits FrMantenimiento

    Dim Palets As New E_palets(Idusuario, cn)
    Dim _IdPalet As String = ""
    Dim _IdCliente As String = ""
    Dim _IdAgricultor As String = ""


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Public Sub New(IdPalet As String, IdCliente As String)
        Me.New()

        _IdPalet = IdPalet
        _IdCliente = IdCliente

    End Sub



    Private Sub ParametrosFrm()
        EntidadFrm = Palets


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxIdPalet, Palets.PAL_idpalet, LbIdPalet, True)
        TxIdPalet.Autonumerico = False
        CampoClave = 0 ' ultimo campo de la clave

        ParamTx(TxGGN1, Palets.PAL_GGN1, LbGGN1, True)
        ParamTx(TxSufijoGGN1, Palets.PAL_SufijoGGN1, LbSufijoGGN1)
        ParamTx(TxGGN2, Palets.PAL_GGN2, LbGGN2)
        ParamTx(TxSufijoGGN2, Palets.PAL_SufijoGGN2, LbSufijoGGN2)
        ParamTx(TxGGN3, Palets.PAL_GGN3, LbGGN3)
        ParamTx(TxSufijoGGN3, Palets.PAL_SufijoGGN3, LbSufijoGGN3)
        ParamTx(TxGGN4, Palets.PAL_GGN4, LbGGN4)
        ParamTx(TxSufijoGGN4, Palets.PAL_SufijoGGN4, LbSufijoGGN4)

    End Sub


    Private Sub FrmIntroducirGGNPalet_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BAnular.Visible = False

        TxIdPalet.Text = _IdPalet
        Siguiente(TxIdPalet.Orden)

    End Sub


    Public Overrides Sub ControlClave()

        ' componemos la clave
        LbId.Text = TxIdPalet.Text


    End Sub


    Public Overrides Sub Guardar()


        TxGGN1.Validar(True)
        TxGGN2.Validar(True)
        TxGGN3.Validar(True)
        TxGGN4.Validar(True)


        MyBase.Guardar()

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
    End Sub


    Private Sub TxGGN1_Valida(edicion As System.Boolean) Handles TxGGN1.Valida
        If edicion Then
            If Not CompruebaGGN(_IdCliente, TxGGN1.Text) Then
                TxGGN1.MiError = True
                MsgBox("El GGN introducido no es válido (1)")
            End If
        End If
    End Sub

    Private Sub TxGGN2_Valida(edicion As System.Boolean) Handles TxGGN2.Valida
        If edicion Then
            If edicion Then
                If Not CompruebaGGN(_IdCliente, TxGGN2.Text) Then
                    TxGGN2.MiError = True
                    MsgBox("El GGN introducido no es válido (2)")
                End If
            End If
        End If
    End Sub

    Private Sub TxGGN3_Valida(edicion As System.Boolean) Handles TxGGN3.Valida
        If edicion Then
            If edicion Then
                If Not CompruebaGGN(_IdCliente, TxGGN3.Text) Then
                    TxGGN3.MiError = True
                    MsgBox("El GGN introducido no es válido (3)")
                End If
            End If
        End If
    End Sub

    Private Sub TxGGN4_Valida(edicion As System.Boolean) Handles TxGGN4.Valida
        If edicion Then
            If edicion Then
                If Not CompruebaGGN(_IdCliente, TxGGN4.Text) Then
                    TxGGN4.MiError = True
                    MsgBox("El GGN introducido no es válido (4)")
                End If
            End If
        End If
    End Sub


    

End Class