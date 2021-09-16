Public Class FrmGeneros
    Inherits FrMantenimiento

    Dim Genero As New E_Generos(Idusuario, cn)
    Dim SubFamilias As New E_Subfamilias(Idusuario, cn)
    Dim Envases As New E_Envases(Idusuario, cn)
    Dim GeneroSalida As New E_GenerosSalida(Idusuario, cn)
    Dim GenerosCategorias As New E_GenerosCategorias(Idusuario, cn)
    Dim Marcas As New E_Marcas(Idusuario, cn)

    Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)

    Dim GenerosCompuestos As New E_GenerosCompuestos(Idusuario, cn)
    Dim IdFamilia As String

    Dim CargandoCategoria As Boolean
    Dim CargandoMarca As Boolean
    Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)


        parametrosfrm()
    End Sub


    Private Sub parametrosfrm()

        EntidadFrm = Genero


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Genero.GEN_IdGenero, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, Genero.GEN_NombreGenero, Lb2)
        ParamTx(TxDato4, Genero.GEN_Abreviacion, Lb5)
        'ParamTx(TxGenTecnicos, Genero.GEN_IdGeneroTecnicos, LbGenTecnicos)
        ParamTx(TxDato3, Genero.GEN_IdsubFamilia, Lb3, True)
        ParamTx(TxDato5, Genero.GEN_IdEnvase, Lb7)
        ParamTx(TxGasto, Genero.GEN_GastoConfeccion, Lb11)

        AsociarControles(TxDato1, BtBuscaGenero, Genero.btBusca, EntidadFrm)
        AsociarControles(TxDato3, BtBuscaFamilia, SubFamilias.btBusca, SubFamilias, SubFamilias.SFA_nombre, Lb4)
        AsociarControles(TxDato5, BtBuscaEnvase, Envases.btBusca, Envases, Envases.ENV_Nombre, Lb6)
        'AsociarControles(TxGenTecnicos, BtBuscaGenTecnicos, Cultivos.btBusca, Cultivos, Cultivos.Nombre, LbNomGenTecnicos)
        BtBuscaEnvase.CL_Filtro = "tipo = 'E'"




        ParamTx(TxDato6, GenerosCompuestos.GEC_IdGeneroCompuesto, Lb9, True)
        ParamTx(TxDato7, GenerosCompuestos.GEC_Porcentaje, Lb10)
        AsociarControles(TxDato6, BtBuscaCompuesto, Genero.btBusca, EntidadFrm, Genero.GEN_NombreGenero, Lb8)




        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


        AsociarGrid(ClGrid1, TxDato6, TxDato7, GenerosCompuestos)


        PropiedadesCamposGr(ClGrid1, GenerosCompuestos.GEC_IdLinea.NombreCampo, "", False, 0)
        PropiedadesCamposGr(ClGrid1, "Nombre", "Genero", True, 50)
        PropiedadesCamposGr(ClGrid1, "Porcentaje", "%", True, 20, True)






    End Sub


    Public Overrides Sub Entidad_a_DatosLin(Grid As ClGrid)

        MyBase.Entidad_a_DatosLin(Grid)
    End Sub


    Public Overrides Sub Borralin(gr As ClGrid)
        MyBase.Borralin(gr)
    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

        ' llenar el grid
        CargaLineasGrid()
    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean

        'asociar cabecera con lineas
        ' Dim total As Double
        ' total = VaDec(ClGrid1.GridView.Columns("porcentaje").SummaryItem.SummaryValue)
        GenerosCompuestos.GEC_IdGenero.Valor = TxDato1.Text
        GeneroSalida.GES_IdGenero.Valor = TxDato1.Text

        Return MyBase.GuardarLineas(Gr)
    End Function


    Public Overrides Sub Guardar()

        Dim total As Double
        total = VaDec(ClGrid1.GridView.Columns("porcentaje").SummaryItem.SummaryValue)
        If total <> 0 And total <> 100 Then
            MsgBox("Error en porcentaje")
            TxDato6.MiError = True
        End If


        MyBase.Guardar()

    End Sub


    Private Sub CargaLineasGrid()

        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 
        Dim sql As String
        sql = "Select GEC_idlinea , GEC_idgenerocompuesto as IdGeneroCompuesto, Generos.GEN_nombregenero as nombre, GEC_porcentaje as porcentaje from generoscompuestos,generos where generoscompuestos.GEC_idgenero=" + TxDato1.Text + " And generoscompuestos.GEC_idgenerocompuesto = Generos.GEN_IdGenero"
        ClGrid1.Consulta = sql
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)

    End Sub


    Private Sub TxDato1_Valida(ByVal edicion As Boolean) Handles TxDato1.Valida
        If edicion = True Then
            CargaLineasGrid()
        End If
    End Sub


    Private Sub TxDato3_Valida(edicion As Boolean) Handles TxDato3.Valida
        If SubFamilias.LeerId(TxDato3.Text) Then
            IdFamilia = SubFamilias.SFA_idfamilia.Valor
        End If
    End Sub




    Private Sub BtDescripcionPaises_Click(sender As System.Object, e As System.EventArgs) Handles BtDescripcionPaises.Click

        If VaInt(LbId.Text) > 0 Then

            Dim frm As New FrmDescripcionGeneroPorIdioma(LbId.Text)
            frm.ShowDialog()

        End If

    End Sub

End Class

