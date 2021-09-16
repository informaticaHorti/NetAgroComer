Public Class FrmTiposdeAgricultores
    Inherits FrMantenimiento




    Dim TiposdeAgricultores As New E_TipoAgricultor(Idusuario, cn)
    Dim Cuentas As New E_Cuentas(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim TipoIva As New E_TipoIvaSoportado(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()


    End Sub



    Private Sub ParametrosFrm()
        EntidadFrm = TiposdeAgricultores


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, TiposdeAgricultores.TPA_idtipo, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, TiposdeAgricultores.TPA_nombre, Lb2)
        ParamChk(ChkSocioHortichuelas, TiposdeAgricultores.TPA_SocioHortichuelasSN, "S", "N")

        ParamTx(TxDato3, TiposdeAgricultores.TPA_poriva, Lb3)
        ParamTx(TxDato4, TiposdeAgricultores.TPA_porret, Lb4)
        ParamCb_Copia(CbTipoREt, TiposdeAgricultores.TPA_tiporet, Lb25, Combos.ComboBaseTot)
        ParamTx(TxDato5, TiposdeAgricultores.TPA_idtipoiva, Lb5)
        ParamChk(ChkCompensa, TiposdeAgricultores.TPA_compensa, "S", "N")

        ParamTx(TxDato6, TiposdeAgricultores.TPA_ctaprov, Lb6)
        ParamTx(TxDato7, TiposdeAgricultores.TPA_ctasumi, Lb7)
        ParamTx(TxDato8, TiposdeAgricultores.TPA_ctaanti, Lb8)
        ParamTx(TxDato9, TiposdeAgricultores.TPA_ctaotros, Lb9)
        ParamTx(TxCtaCartera, TiposdeAgricultores.TPA_CtaCartera, LbCtaCartera)


        ParamTx(TxDato15, TiposdeAgricultores.TPA_seriecomer, Lb27)
        ParamCb_Copia(CbAgrMay, TiposdeAgricultores.TPA_agrimayo, Lb26, Combos.ComboAgriMay)
        ParamCb_Copia(CbTipofac, TiposdeAgricultores.TPA_tipofactura, Lb23, Combos.ComboTipoFacAgri)

        ParamTx(TxDato12, TiposdeAgricultores.TPA_ctacompracomer, Lb21)
        ParamTx(TxDato10, TiposdeAgricultores.TPA_ctaivaalbcomer, Lb19)
        ParamTx(TxDato18, TiposdeAgricultores.TPA_ctaretcomer, Lb31)
        ParamTx(TxCtaFondo, TiposdeAgricultores.TPA_ctafondo, LbCtafondo)
        ParamTx(TxCtaContingencia, TiposdeAgricultores.TPA_CtaContingencia, LbCtaContingencia)

        ParamChk(ChkFondoOperativo, TiposdeAgricultores.TPA_FondoOperativoSN, "S", "N")
        ParamTx(TxComision, TiposdeAgricultores.TPA_porcomision, LbComision)
        ParamTx(TxFondo, TiposdeAgricultores.TPA_porfondo, LbFondo)
        ParamTx(TxContingencia, TiposdeAgricultores.TPA_PorContingencia, LbContingencia)



        AsociarControles(TxDato1, BtBuscaTipoAgr, TiposdeAgricultores.btBusca, EntidadFrm)
        AsociarControles(TxDato5, BtBuscaTipoIva, TipoIva.btBusca, TipoIva, TipoIva.Nombre, Lb10)
        AsociarControles(TxDato12, BtBuscaCtaIvaVtas, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lb17)
        AsociarControles(TxDato10, BtBuscaCtaIvaVar, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lb15)
        AsociarControles(TxDato18, BtBusca3, Cuentas.btBusca, Cuentas, Cuentas.Nombre, Lb30)
        AsociarControles(TxCtaFondo, BtBuscaCtafondo, Cuentas.btBusca, Cuentas, Cuentas.Nombre, LbNomFondo)
        AsociarControles(TxCtaContingencia, BtBuscaCtaContingencia, Cuentas.btBusca, Cuentas, Cuentas.Nombre, LbNomContingencia)


        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me
    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text

    End Sub


    Public Overrides Sub Guardar()
        MyBase.Guardar()
    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
    End Sub

    Private Sub TxDato6_Valida(ByVal edicion As Boolean) Handles TxDato6.Valida
        If edicion Then TxDato6.Text = ComprobarDigitos(TxDato6.Text)
    End Sub

    Private Sub TxDato7_Valida(ByVal edicion As System.Boolean) Handles TxDato7.Valida
        If edicion Then TxDato7.Text = ComprobarDigitos(TxDato7.Text)
    End Sub

    Private Sub TxDato8_Valida(ByVal edicion As System.Boolean) Handles TxDato8.Valida
        If edicion Then TxDato8.Text = ComprobarDigitos(TxDato8.Text)
    End Sub

    Private Function ComprobarDigitos(ByVal Campo As String) As String
        If Len(Campo) > 0 Then
            Dim Digitos As Integer = Campo.Length
            Dim Faltan As Integer = 6 - Digitos
            For i = 0 To Faltan - 1
                Campo = Campo & "0"
            Next
        End If
        Return Campo
    End Function

End Class