Public Class FrmConfecGenero

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
        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        Me.MinimumSize = Me.Size
        parametrosfrm()

    End Sub


    Private Sub parametrosfrm()

        EntidadFrm = Genero


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Genero.GEN_IdGenero, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave

        AsociarControles(TxDato1, BtBuscaGenero, Genero.btBusca, EntidadFrm)




        ParamTx(TxDato8, GeneroSalida.GES_Idconfec, Lb12, True)
        ParamTx(TxDato10, GeneroSalida.GES_KilosXBulto, Lb14)
        ParamTx(TxDato11, GeneroSalida.GES_PiezasXBulto, Lb15)
        ParamChk(ChPesoFijo, GeneroSalida.GES_PesoFijo, "S", "N")
        ParamChk(ChActivo, GeneroSalida.GES_Activo, "S", "N")
        ParamChk(chkGeneroQS, GeneroSalida.GES_GeneroQS, "S", "N")
        ParamChk(chkDemeter, GeneroSalida.GES_DEMETER, "S", "N")
        ParamTx(TxDato9, GeneroSalida.GES_Nombre, Lb13)
        ParamTx(TxDato20, GeneroSalida.GES_DescripcionAlb, Lb3)
        ChActivo.ValorDefecto = True
        ParamTx(TxDato12, GeneroSalida.GES_GtoXKilo, Lb17)
        ParamTx(TxDato14, GeneroSalida.GES_SobrecosteMat, Lb25)
        ParamTx(TxDato13, GeneroSalida.GES_idmarcaenvase, Lb22)
        ParamTx(TxDato15, GeneroSalida.GES_idmarcamaterial, Lb27)
        ParamChk(ChMarcaMatPal, GeneroSalida.GES_pedirmarcamat, "S", "N")

        ParamTx(TxDato16, GeneroSalida.GES_idmarcaetiqueta, Lb29)
        ParamChk(ChMarcaEtiPal, GeneroSalida.GES_pedirmarcaeti, "S", "N")

        AsociarControles(TxDato8, BtBuscaConfec, ConfecEnvase.btBusca, ConfecEnvase, ConfecEnvase.CEV_Nombre, Lb11)
        AsociarControles(TxDato13, BtBuscaMarcaEnv, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, LbMarcaEnv)
        AsociarControles(TxDato15, BtBuscaMarcaMat, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, LbMarcaMat)
        AsociarControles(TxDato16, BtBuscaMarcaEti, Marcas.btBusca, Marcas, Marcas.MAR_Nombre, LbMarcaEti)

        BtBuscaMarcaEnv.CL_Filtro = "Env='S'"
        BtBuscaMarcaMat.CL_Filtro = "Mat='S'"
        BtBuscaMarcaEti.CL_Filtro = "Eti='S'"



        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


        AsociarGrid(ClGrid2, TxDato8, ChMarcaEtiPal, GeneroSalida)




        PropiedadesCamposGr(ClGrid2, "GES_idgensal", "Id", True, 30)
        PropiedadesCamposGr(ClGrid2, "Confec", "Confec", True, 30)
        PropiedadesCamposGr(ClGrid2, "Nombre", "Nombre", True, 100)
        PropiedadesCamposGr(ClGrid2, "KxBulto", "KxB", True, 25)
        PropiedadesCamposGr(ClGrid2, "Gto", "Gto", True, 25, False, "#0.0000")
        PropiedadesCamposGr(ClGrid2, "Act", "Act", True, 25)


        BAnular.Visible = False

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)


        If Grid Is ClGrid2 Then
            Calculcostekilo()
            CargaChCategoria(GeneroSalida.GES_Idgensal.Valor, IdFamilia)
            CargaChMarca(GeneroSalida.GES_Idgensal.Valor)
        End If

    End Sub
    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
        LbGastoManiGenero.Text = ""
    End Sub

    Public Overrides Sub Borralin(gr As ClGrid)

        MyBase.Borralin(gr)
        If gr Is ClGrid2 Then
            LbTcosteKilo.Text = ""
            LbTcosteBulto.Text = ""
            LbMarcaEnv.Text = ""
            LbMarcaEti.Text = ""
            LbMarcaMat.Text = ""
            CargaChCategoria(GeneroSalida.GES_Idgensal.Valor, IdFamilia)
            CargaChMarca(GeneroSalida.GES_Idgensal.Valor)
        End If

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()
        ' llenar el grid

        CargaLineasGridConfec()
    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas
        ' Dim total As Double
        ' total = VaDec(ClGrid1.GridView.Columns("porcentaje").SummaryItem.SummaryValue)
        GeneroSalida.GES_IdGenero.Valor = TxDato1.Text

        Return MyBase.GuardarLineas(Gr)
    End Function


    Public Overrides Sub Guardar()
        Dim a = ""
        MyBase.Guardar()

    End Sub



    Private Sub CargaLineasGridConfec()

        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 
        Dim sql As String
        sql = "Select  GES_idgensal, GES_idconfec as Confec,GES_nombre as Nombre, GES_kilosxbulto as Kxbulto, GES_gtoxkilo as Gto, GES_activo as Act  from generossalida where GES_idgenero=" + TxDato1.Text + " order by GES_idconfec"
        ClGrid2.Consulta = sql
        ClGrid2.Nlinea = -1
        Cargalineas(ClGrid2)

    End Sub



    Private Sub TxDato1_Valida(ByVal edicion As Boolean) Handles TxDato1.Valida
        If Genero.LeerId(TxDato1.Text) = True Then
            LbNombre.Text = Genero.GEN_NombreGenero.Valor
            If SubFamilias.LeerId(Genero.GEN_IdsubFamilia.Valor) = True Then
                IdFamilia = SubFamilias.SFA_idfamilia.Valor
            End If
            LbGastoManiGenero.Text = Format(VaDec(Genero.GEN_GastoConfeccion.Valor), "#0.0000")
        End If
        If edicion = True Then
            CargaLineasGridConfec()
        End If

    End Sub




    Private Sub Calculcostekilo()
        Dim Gb As Double = 0
        LbTcosteKilo.Text = ""
        LbTcosteBulto.Text = ""
        If VaDec(TxDato10.Text) > 0 Then
            Gb = VaDec(TxDato12.Text) * VaDec(TxDato10.Text)
            Gb = Gb + VaDec(LbGastoManiGenero.Text) * VaDec(TxDato10.Text)
            Gb = Gb + VaDec(LbCosteConf.Text)
            Gb = Gb + VaDec(TxDato14.Text)
            LbTcosteBulto.Text = Format(Gb, "#0.00000")
            LbTcosteKilo.Text = Format(Gb / VaDec(TxDato10.Text), "#0.00000")
        End If
    End Sub



    Private Sub CargaChCategoria(idpresentacion As String, idfamilia As String)

        Dim dt As New DataTable
        Dim sql As String
        Dim FamiliasCategorias As New E_FamiliasCategorias(Idusuario, cn)
        Dim CategoriasComercial As New E_CategoriasComercial(Idusuario, cn)


        Dim Consulta2 As New Cdatos.E_select

        If Val(idfamilia) = 0 Then Exit Sub

        Consulta2.SelCampo(FamiliasCategorias.FAC_idCategoriaComercial, "Codigo")
        Consulta2.SelCampo(CategoriasComercial.CAC_Nombre, "Categoria", FamiliasCategorias.FAC_idCategoriaComercial)

        Consulta2.WheCampo(FamiliasCategorias.FAC_idCategoriaComercial, ">", "0")
        Consulta2.WheCampo(FamiliasCategorias.FAC_Idfamilia, "=", idfamilia)


        sql = Consulta2.SQL
        dt = CategoriasComercial.MiConexion.ConsultaSQL(sql)

        ChCategoria.DataSource = dt
        ChCategoria.ValueMember = "Codigo"
        ChCategoria.DisplayMember = "Categoria"


        ChCategoria.CheckOnClick = True

        CargandoCategoria = True
        If Val(LbId.Text) > 0 And Val(TxDato8.Text) > 0 Then
            For indice As Integer = 0 To ChCategoria.ItemCount - 1

                '   If ChOrigen.GetItemChecked(indice) = True Then
                ' MsgBox("Checked: " & row("Nombre").ToString)
                ' End If

                Dim row As DataRowView = ChCategoria.GetItem(indice)
                Dim a As String = row("Codigo").ToString
                If GenerosCategorias.LeerGenero_Categoria(idpresentacion, a) > 0 Then

                    ChCategoria.SetItemChecked(indice, True)
                End If
            Next
        End If
        CargandoCategoria = False


    End Sub

    Private Sub GuardarChCategoria(idpresentacion As String, idcategoria As String, V As Boolean)
        If CargandoCategoria = True Then Exit Sub

        If V = False Then
            BorraChCategoria(idpresentacion, idcategoria)
        Else

            GenerosCategorias.VaciaEntidad()
            Dim id As Integer = GenerosCategorias.MaxId
            GenerosCategorias.GCA_id.Valor = id.ToString
            GenerosCategorias.GCA_idpresentacion.Valor = idpresentacion
            GenerosCategorias.GCA_tipo.Valor = "C"
            GenerosCategorias.GCA_codigo.Valor = idcategoria
            GenerosCategorias.Insertar()

        End If

    End Sub

    Private Sub BorraChCategoria(idpresentacion As String, idcategoria As String)
        If Val(LbId.Text) > 0 Then
            Dim sql As String = "delete from generoscategorias where GCA_idpresentacion=" + idpresentacion + "  and GCA_tipo='C' and GCA_codigo=" + idcategoria
            GenerosCategorias.MiConexion.ConsultaSQL(sql)
        End If

    End Sub

    Private Sub TxDato1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato1.TextChanged

    End Sub







   


    Private Sub CargaChMarca(Idpresentacion As String)

        Dim dt As New DataTable
        Dim sql As String
        Dim Marcas As New E_Marcas(Idusuario, cn)


        Dim Consulta2 As New Cdatos.E_select



        Consulta2.SelCampo(Marcas.MAR_Idmarca, "Codigo")
        Consulta2.SelCampo(Marcas.MAR_Nombre, "Marca")





        sql = Consulta2.SQL + " order by MAR_IDMARCA"
        dt = Marcas.MiConexion.ConsultaSQL(sql)

        ChMarcas.DataSource = dt
        ChMarcas.ValueMember = "Codigo"
        ChMarcas.DisplayMember = "Marca"


        ChMarcas.CheckOnClick = True

        CargandoMarca = True

        If Val(LbId.Text) > 0 And Val(TxDato8.Text) > 0 Then
            For indice As Integer = 0 To ChMarcas.ItemCount - 1

                '   If ChOrigen.GetItemChecked(indice) = True Then
                ' MsgBox("Checked: " & row("Nombre").ToString)
                ' End If

                Dim row As DataRowView = ChMarcas.GetItem(indice)
                Dim a As String = row("Codigo").ToString
                If GenerosCategorias.LeerGenero_Marca(Idpresentacion, a) > 0 Then
                    ChMarcas.SetItemChecked(indice, True)
                End If
            Next
        End If

        CargandoMarca = False

    End Sub

    Private Sub GuardarChMarca(idpresentacion As String, idmarca As String, V As Boolean)
        If CargandoMarca = True Then Exit Sub

        If V = False Then
            BorraChMarca(idpresentacion, idmarca)
        Else

            GenerosCategorias.VaciaEntidad()
            Dim id As Integer = GenerosCategorias.MaxId
            GenerosCategorias.GCA_id.Valor = id.ToString
            GenerosCategorias.GCA_idpresentacion.Valor = idpresentacion
            GenerosCategorias.GCA_tipo.Valor = "M"
            GenerosCategorias.GCA_codigo.Valor = idmarca
            GenerosCategorias.Insertar()

        End If

    End Sub

    Private Sub BorraChMarca(idpresentacion As String, idmarca As String)
        If Val(LbId.Text) > 0 Then
            Dim sql As String = "delete from generoscategorias where GCA_idpresentacion=" + idpresentacion + " and GCA_tipo='M' and GCA_codigo=" + idmarca
            GenerosCategorias.MiConexion.ConsultaSQL(sql)
        End If

    End Sub

  

 

   
    

   

   

 
    Private Sub ChCategoria_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ChCategoria.SelectedIndexChanged

    End Sub

    Private Sub TxDato15_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato15.TextChanged

    End Sub

    Public Overrides Sub DespuesdeGuardarLinea(gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)
        For indice As Integer = 0 To ChCategoria.ItemCount - 1

            Dim row As DataRowView = ChCategoria.GetItem(indice)
            Dim a As String = row("Codigo").ToString
            If ChCategoria.GetItemChecked(indice) = True Then
                GuardarChCategoria(GeneroSalida.GES_Idgensal.Valor, a, True)
            Else
                GuardarChCategoria(GeneroSalida.GES_Idgensal.Valor, a, False)

            End If

        Next


        For indice As Integer = 0 To ChMarcas.ItemCount - 1

            Dim row As DataRowView = ChMarcas.GetItem(indice)
            Dim a As String = row("Codigo").ToString
            If ChMarcas.GetItemChecked(indice) = True Then
                GuardarChMarca(GeneroSalida.GES_Idgensal.Valor, a, True)
            Else
                GuardarChMarca(GeneroSalida.GES_Idgensal.Valor, a, False)

            End If

        Next


    End Sub

    Private Sub ChMarcas_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ChMarcas.SelectedIndexChanged

    End Sub

    Private Sub TxDato8_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato8.TextChanged

    End Sub

    Private Sub TxDato16_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato16.TextChanged

    End Sub

    Private Sub TxDato8_Valida1(edicion As Boolean) Handles TxDato8.Valida

        If ConfecEnvase.LeerId(TxDato8.Text) = True Then
            LbCosteConf.Text = Format(VaDec(ConfecEnvase.CEV_TotalCoste.Valor), "#0.00000")

        End If
        'If edicion = True Then
        '    Calculcostekilo()
        '    If TxDato9.Text = "" Then
        '        TxDato9.Text = LbNombre.Text + " " + Lb11.Text
        '    End If
        '    If TxDato20.Text = "" Then
        '        TxDato20.Text = LbNombre.Text + " " + Lb11.Text
        '    End If
        '    CargaChCategoria(GeneroSalida.GES_Idgensal.Valor, IdFamilia)
        '    CargaChMarca(GeneroSalida.GES_Idgensal.Valor)
        'End If

        If edicion = True Then
            Dim C1 As String = ""
            Dim C2 As String = ""
            Calculcostekilo()
            If TxDato9.Text = "" Then
                C1 = LbNombre.Text
                C2 = Lb11.Text
                If TxDato1.Text <> "" And TxDato8.Text <> "" Then
                    If Genero.LeerId(TxDato1.Text) = True Then
                        If Genero.GEN_Abreviacion.Valor <> "" Then
                            C1 = Genero.GEN_Abreviacion.Valor
                        End If
                    End If
                    If ConfecEnvase.LeerId(TxDato8.Text) = True Then
                        If ConfecEnvase.CEV_Abreviatura.Valor <> "" Then
                            C2 = ConfecEnvase.CEV_Abreviatura.Valor
                        End If
                    End If
                End If
                TxDato9.Text = C1 + " " + C2
            End If
        End If
    End Sub

    Private Sub TxDato9_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxDato9.TextChanged

    End Sub

    Private Sub TxDato9_Valida(edicion As Boolean) Handles TxDato9.Valida
        If edicion = True Then
            If TxDato20.Text = "" Then
                TxDato20.Text = TxDato9.Text
            End If
        End If
    End Sub

    Private Sub LbMarcaMat_TextChanged(sender As System.Object, e As System.EventArgs) Handles LbMarcaMat.TextChanged
        Dim a As String = ""
    End Sub

    Private Sub TxDato10_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles TxDato10.TextChanged

    End Sub

    Private Sub TxDato10_Valida1(edicion As Boolean) Handles TxDato10.Valida
        If edicion = True Then
            Calculcostekilo()

        End If

    End Sub

    Private Sub TxDato12_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles TxDato12.TextChanged

    End Sub

    Private Sub TxDato12_Valida1(edicion As Boolean) Handles TxDato12.Valida
        If edicion = True Then
            Calculcostekilo()

        End If
    End Sub

    Private Sub TxDato14_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles TxDato14.TextChanged

    End Sub

    Private Sub TxDato14_Valida1(edicion As Boolean) Handles TxDato14.Valida
        If edicion = True Then
            Calculcostekilo()

        End If

    End Sub
End Class

