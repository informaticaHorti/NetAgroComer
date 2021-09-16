Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Public Class FrmParteSemanal

    Inherits FrConsulta

    Dim Partes As New E_Partes(Idusuario, cn)
    Dim Partes_compras As New E_partes_Compras(Idusuario, cn)
    Dim Partes_ventas As New E_partes_Ventas(Idusuario, cn)
    Dim Partes_familias As New E_Partes_familias(Idusuario, cn)
    Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
    Dim ParteExistencias As New E_ParteExistencias(Idusuario, cn)
    Dim ParteExistencias_lineas As New E_ParteExistencias_lineas(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
    Dim Generoscompuestos As New E_GenerosCompuestos(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim _idparte As Integer = 0

    Dim SubFamilias As New E_Subfamilias(Idusuario, cn)

    Class stClave_Valoracion

        Public IdGenero As Integer = 0
        Public IdCategoria As Integer = 0

        'Public Sub New(IdGenero As Integer, IdCategoria As Integer)

        '    Me.IdGenero = IdGenero
        '    Me.IdCategoria = IdCategoria

        'End Sub

    End Class




    Dim DcLentrada As New Dictionary(Of Integer, Integer) ' dicionario para las partidas que van en el parte

    Private Class stClaves_Parte
        Public IdGenero As Integer = 0
        Public Genero As String = ""
        Public IdCategoria As Integer = 0
        Public Categoria As String = ""
        Public Clasificacion As String = ""

        Public Sub New(ByVal IdGenero As Integer, ByVal Genero As String, ByVal IdCategoria As Integer, ByVal Categoria As String, ByVal clasificacion As String)
            Me.Clasificacion = clasificacion
            Me.IdGenero = IdGenero
            Me.Genero = Genero
            Me.IdCategoria = IdCategoria
            Me.Categoria = Categoria
        End Sub
    End Class

    Private Class stDatos_Parte
        Public KilosF As Integer = 0
        Public ImporteF As Decimal = 0
        Public KilosS As Integer = 0
        Public ImporteS As Decimal = 0
        Public GastosC As Decimal = 0
        Public KilosV As Decimal = 0
        Public Iventa As Decimal = 0
        Public GastosV As Decimal = 0
        Public GastosO As Decimal = 0
        Public VExiIni As Decimal = 0
        Public VExiFin As Decimal = 0
        Public KilosC As Decimal = 0
        Public ImporteC As Decimal = 0
        Public KexiIni As Decimal = 0
        Public KexiFin As Decimal = 0
        Public Valorado As Decimal = 0
        Public Iliqui As Decimal = 0



        Public Sub New(ByVal KilosF As Integer, ByVal KilosS As Integer, ByVal ImporteF As Decimal, _
                       ByVal ImporteS As Decimal, ByVal GastosC As Decimal, ByVal KilosV As Integer, _
                       ByVal Iventa As Decimal, ByVal GastosV As Decimal, ByVal GastosO As Decimal, ByVal KilosC As Integer, _
                       ByVal VexiIni As Decimal, ByVal VexiFin As Decimal, ByVal ImporteC As Decimal, KexiIni As Decimal, KexiFin As Decimal, Valorado As Decimal, iliqui As Decimal)
            Me.KilosF = KilosF
            Me.KilosS = KilosS
            Me.ImporteF = ImporteF
            Me.ImporteS = ImporteS
            Me.GastosC = GastosC
            Me.KilosV = KilosV
            Me.Iventa = Iventa
            Me.GastosV = GastosV
            Me.GastosO = GastosO
            Me.KilosC = KilosC
            Me.VExiIni = VexiIni
            Me.VExiFin = VexiFin
            Me.ImporteC = ImporteC
            Me.KexiIni = KexiIni
            Me.KexiFin = KexiFin
            Me.Valorado = Valorado
            Me.Iliqui = iliqui
        End Sub
    End Class


    Private Class stClaves_ParteVentas
        Public IdGenero As Integer = 0
        Public IdCategoria As Integer = 0
        Public IdAlbaran As Integer = 0

        Public Sub New(ByVal IdGenero As Integer, ByVal IdCategoria As Integer, ByVal IdAlbaran As Integer)
            Me.IdGenero = IdGenero
            Me.IdCategoria = IdCategoria
            Me.IdAlbaran = IdAlbaran
        End Sub
    End Class


    Private Class stDatos_ParteVentas
        Public KilosSal As Decimal = 0
        Public IVenta As Decimal = 0
        Public GastosF As Decimal = 0
        Public GastosC As Decimal = 0
        Public Estructura As Decimal = 0
        Public Materiales As Decimal = 0
        Public Manipulacion As Decimal = 0

        Public Sub New(ByVal KilosSal As Decimal, ByVal IVenta As Decimal, ByVal GastosF As Decimal, ByVal GastosC As Decimal, _
                       ByVal Estructura As Decimal, ByVal Materiales As Decimal, ByVal Manipulacion As Decimal)
            Me.KilosSal = KilosSal
            Me.IVenta = IVenta
            Me.GastosF = GastosF
            Me.GastosC = GastosC
            Me.Estructura = Estructura
            Me.Materiales = Materiales
            Me.Manipulacion = Manipulacion
        End Sub
    End Class

    Dim Acum As New Acumulador
    Dim AcumVenta As New Acumulador




    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()
    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxNuparte, Nothing, Lb3, True, Cdatos.TiposCampo.EnteroPositivo, 0, 6)
        ParamTx(TxSemana, Nothing, Lb1, True, Cdatos.TiposCampo.EnteroPositivo, 0, 2)
        ParamTx(TxCentro, Nothing, LbCentro, True, Cdatos.TiposCampo.EnteroPositivo, 0, 3)
        ParamTx(TxDeFechaEnt, Nothing, Lb4, True, Cdatos.TiposCampo.Fecha)
        ParamTx(TxAFechaEnt, Nothing, Lb2, True, Cdatos.TiposCampo.Fecha)
        ParamTx(TxDeFechaSal, Nothing, Lb8, True, Cdatos.TiposCampo.Fecha)
        ParamTx(TxAFechaSal, Nothing, Lb7, True, Cdatos.TiposCampo.Fecha)

        RbPorImporte.Checked = True


        AsociarControles(TxNuparte, BtBuscaParte, Partes.btBusca, Partes)
        AsociarControles(TxCentro, BtCentro, Centros.btBusca, Centros, Centros.Nombre, LbNomCentro)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Acum.Borrar()
        AcumVenta.Borrar()
        BtRegenerar.Visible = False
        btPrecios.Visible = False
        Balbaranes.Visible = False
        LbValorado.Visible = False

        Banular.Visible = False

    End Sub


    Private Sub FrmExtractoEnvasesPorMaterial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BtAux.Visible = True
        BtAux.Text = "Guardar Parte"
        BtAux.Width = 90
        BtAux.Image = NetAgro.My.Resources.Resources.App_kservices_16x16_32
    End Sub

    Public Overrides Sub Consultar()
        MyBase.Consultar()

        CargaGrid(False)
    End Sub

    Private Sub CargaGrid(ByVal bNuevo As Boolean)
        Acum.Borrar()
        AcumVenta.Borrar()
        DcLentrada.Clear()
        Grid.DataSource = Nothing


        Dim idparte As Integer = Partes.LeerParte(MiMaletin.Ejercicio, VaInt(TxNuparte.Text))
        Dim bTodos As Boolean = TodosLosGeneros()
        Dim DcFamilias As Dictionary(Of Integer, String) = DiccionarioDeListBox(lstFamilias)


        If idparte > 0 And bNuevo = False Then
            CargaCompras_ParteExistente(idparte)
            CargaPreciosLiqui(idparte)
            CargaVentas_ParteExistente(idparte)
        Else
            CargaCompras_NuevoParte(bTodos, DcFamilias)
            CargaVentas_NuevoParte(bTodos, DcFamilias)
            CargaExistencias(True, bTodos, DcFamilias)
            CargaExistencias(False, bTodos, DcFamilias)
            If idparte > 0 Then
                CargaPreciosLiqui(idparte)
            End If
        End If


            Dim DTa As New DataTable

            DTa = Acum.DataTable

            If DTa.Rows.Count > 0 Then
                DTa.Columns.Add("NetoVenta", GetType(System.Decimal)).SetOrdinal(15)
                DTa.Columns.Add("Disponible", GetType(System.Decimal)).SetOrdinal(18)
                DTa.Columns.Add("Pmedio", GetType(System.Decimal))


                ' Añado la familia del género #20150827_vicent#
                DTa.Columns.Add("IdSubFam", GetType(System.Int32))
                DTa.Columns.Add("SubFam", GetType(System.String))
                DTa.Columns.Add("IdFam", GetType(System.Int32))
                DTa.Columns.Add("Fam", GetType(System.String))
                Barra.Maximum = DTa.Rows.Count
                Barra.Value = 0
                For Each RW In DTa.Rows
                    If Barra.Value < Barra.Maximum Then
                        Barra.Value = Barra.Value + 1
                    End If
                    Dim NETO As Decimal = VaDec(RW("Iventa")) - VaDec(RW("GastosV")) - VaDec(RW("GastosO"))
                    RW("NetoVenta") = NETO
                    Dim Disponible As Decimal = NETO - VaDec(RW("ImporteF")) - VaDec(RW("ImporteS")) - VaDec(RW("GastosC")) - VaDec(RW("Valorado"))
                    Disponible = Disponible + VaDec(RW("VEXIFIN")) - VaDec(RW("VEXIINI"))
                    RW("Disponible") = Disponible
                    If VaDec(RW("kilosc")) > 0 Then
                        RW("pmedio") = Disponible / VaDec(RW("kilosc"))
                    End If

                    Dim Familia As New E_FamiliasGeneros(Idusuario, cn)

                    Dim Sql As String = "SELECT SF.SFA_id as SFamId, " _
                                        & "SF.SFA_nombre as SFamNombre, " _
                                        & "F.FAG_idfamilia as FamId, " _
                                        & "F.FAG_nombre as FamNombre " _
                                        & "FROM NetAgroComer.dbo.Generos G " _
                                        & "LEFT OUTER JOIN NetAgroComer.dbo.Subfamilias SF " _
                                        & "ON G.GEN_idsubfamilia = SF.SFA_id " _
                                        & "LEFT OUTER JOIN NetAgroComer.dbo.FamiliasGeneros F " _
                                        & "ON F.FAG_idfamilia = SF.SFA_idfamilia " _
                                        & "WHERE G.GEN_idgenero = '" & RW("IdGenero") & "'"

                    Dim Datos As DataTable = Familia.MiConexion.ConsultaSQL(Sql)
                    RW("IdSubFam") = Datos.Rows(0)("SFamId")
                    RW("SubFam") = Datos.Rows(0)("SFamNombre")
                    RW("IdFam") = Datos.Rows(0)("FamId")
                    RW("Fam") = Datos.Rows(0)("FamNombre")
                Next
            End If

            If Not IsNothing(DTa) Then
                If DTa.Rows.Count > 0 Then

                    Dim dv As New DataView(DTa)
                    dv.Sort = "IdGenero, IdCategoria"
                    DTa = dv.ToTable

                End If
            End If

            Grid.DataSource = DTa
            AjustaColumnas()

    End Sub


    Private Sub CargaCompras_ParteExistente(ByVal IdParte As Integer)
        Dim consulta As New Cdatos.E_select

        consulta.SelCampo(Partes_compras.PDL_idgenero, "IdGenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Partes_compras.PDL_idgenero, Generos.GEN_IdGenero)
        consulta.SelCampo(Partes_compras.PDL_idcategoria, "IdCategoria")
        consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", Partes_compras.PDL_idcategoria, Categorias.CAE_Id)
        consulta.SelCampo(Categorias.CAE_clasificacion, "Cla")
        consulta.SelCampo(Partes_compras.PDL_kilosF, "KilosF")
        consulta.SelCampo(Partes_compras.PDL_ImporteF, "ImporteF")
        consulta.SelCampo(Partes_compras.PDL_kilosS, "KilosS")
        consulta.SelCampo(Partes_compras.PDL_ImporteS, "ImporteS")
        consulta.SelCampo(Partes_compras.PDL_GastosCom, "GastosC")
        consulta.SelCampo(Partes_compras.PDL_kilosC, "KilosC")
        'consulta.SelCampo(Partes_compras.PDL_ImporteC, "ImporteC")
        consulta.SelCampo(Partes_compras.PDL_ImporteFAC, "Valorado")
        consulta.SelCampo(Partes_compras.PDL_KilosExIni, "Kexini")
        consulta.SelCampo(Partes_compras.PDL_KilosExFin, "Kexfin")
        consulta.SelCampo(Partes_compras.PDL_ImpExIni, "Vexini")
        consulta.SelCampo(Partes_compras.PDL_ImpExFin, "Vexfin")


        '        Dim iliqui As New Cdatos.bdcampo("@PDL_precioliquid*PDL_kilosc", Cdatos.TiposCampo.Importe, 15, 2)
        '        consulta.SelCampo(iliqui, "ImpLiqui")

        consulta.WheCampo(Partes_compras.PDL_idparte, "=", IdParte.ToString)


        Dim sql As String = consulta.SQL

        Dim dt As DataTable = Partes.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows

                Dim IdGenero As Integer = VaInt(row("IdGenero"))
                Dim Genero As String = (row("Genero").ToString & "").Trim
                Dim IdCategoria As Integer = VaInt(row("IdCategoria"))
                Dim Categoria As String = (row("Categoria").ToString & "").Trim
                Dim Cla As String = (row("Cla").ToString & "").Trim
                Dim KilosF As Decimal = VaDec(row("KilosF"))
                Dim KilosS As Decimal = VaDec(row("KilosS"))
                Dim KilosC As Decimal = VaDec(row("KilosC"))
                Dim ImporteF As Decimal = VaDec(row("ImporteF"))
                Dim ImporteS As Decimal = VaDec(row("ImporteS"))
                ' Dim ImporteC As Decimal = VaDec(row("ImporteC"))
                Dim GastosC As Decimal = VaDec(row("GastosC"))
                Dim Valorado As Decimal = VaDec(row("Valorado"))
                Dim KexIni As Decimal = VaDec(row("kexini"))
                Dim Kexfin As Decimal = VaDec(row("kexfin"))
                Dim vexIni As Decimal = VaDec(row("vexini"))
                Dim vexfin As Decimal = VaDec(row("vexfin"))
                '                Dim impliqui As Decimal = VaDec(row("impliqui"))


                Dim stClaves As New stClaves_Parte(IdGenero, Genero, IdCategoria, Categoria, Cla)
                Dim stDatos As New stDatos_Parte(KilosF, KilosS, ImporteF, ImporteS, GastosC, 0, 0, 0, 0, KilosC, vexIni, vexfin, 0, KexIni, Kexfin, Valorado, 0)
                Acum.Suma(stClaves, stDatos)


            Next

        End If



    End Sub


    Private Sub CargaPreciosLiqui(ByVal IdParte As Integer)
        Dim consulta As New Cdatos.E_select

        consulta.SelCampo(Partes_compras.PDL_idgenero, "IdGenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Partes_compras.PDL_idgenero, Generos.GEN_IdGenero)
        consulta.SelCampo(Partes_compras.PDL_idcategoria, "IdCategoria")
        consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", Partes_compras.PDL_idcategoria, Categorias.CAE_Id)
        consulta.SelCampo(Categorias.CAE_clasificacion, "Cla")


        Dim iliqui As New Cdatos.bdcampo("@PDL_precioliquid*PDL_kilosc", Cdatos.TiposCampo.Importe, 15, 2)
        consulta.SelCampo(iliqui, "ImpLiqui")

        consulta.WheCampo(Partes_compras.PDL_idparte, "=", IdParte.ToString)


        Dim sql As String = consulta.SQL

        Dim dt As DataTable = Partes.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows

                Dim IdGenero As Integer = VaInt(row("IdGenero"))
                Dim Genero As String = (row("Genero").ToString & "").Trim
                Dim IdCategoria As Integer = VaInt(row("IdCategoria"))
                Dim Categoria As String = (row("Categoria").ToString & "").Trim
                Dim Cla As String = (row("Cla").ToString & "").Trim
                Dim impliqui As Decimal = VaDec(row("impliqui"))

                If impliqui > 0 Then
                    Dim A As String = ""

                End If
                Dim stClaves As New stClaves_Parte(IdGenero, Genero, IdCategoria, Categoria, Cla)
                Dim stDatos As New stDatos_Parte(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, impliqui)
                Acum.Suma(stClaves, stDatos)


            Next

        End If



    End Sub



    Private Sub CargaCompras_NuevoParte(bTodos As Boolean, DcFamilias As Dictionary(Of Integer, String))


        Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
        Dim albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
        Dim Albentrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)
        Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim Subfamilias As New E_Subfamilias(Idusuario, cn)


        Dim consulta As New Cdatos.E_select


        consulta.SelCampo(Albentrada_lineascla.ALC_idcategoria, "idcategoria")
        consulta.SelCampo(Albentrada_lineas.AEL_idgenero, "idgenero", Albentrada_lineascla.ALC_idlineaentrada)
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albentrada_lineas.AEL_idgenero)
        consulta.SelCampo(Subfamilias.SFA_idfamilia, "IdFamilia", Generos.GEN_IdsubFamilia, Subfamilias.SFA_id)
        consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", Albentrada_lineascla.ALC_idcategoria)
        consulta.SelCampo(Categorias.CAE_clasificacion, "Cla")
        consulta.SelCampo(Albentrada_lineascla.ALC_kilosnetos, "Kilos")
        consulta.SelCampo(Albentrada_lineascla.ALC_bultos, "Bultos")
        consulta.SelCampo(Albentrada_lineascla.ALC_piezas, "Piezas")
        consulta.SelCampo(Albentrada_lineascla.ALC_precio, "Precio")
        consulta.SelCampo(Albentrada_lineas.AEL_tipoprecio, "TipoPrecio")
        consulta.SelCampo(Albentrada_lineas.AEL_IdValoracion, "idvaloracion")
        consulta.SelCampo(Albentrada_lineas.AEL_FechaValoracion, "fechavaloracion")
        consulta.SelCampo(Albentrada_lineas.AEL_idlinea, "idlineaentrada")
        consulta.SelCampo(Albentrada_lineas.AEL_fechamuestreo, "fechamuestreo")
        consulta.SelCampo(Albentrada_lineas.AEL_Idparte, "idparte")
        consulta.SelCampo(Albentrada_lineas.AEL_idalbaran, "idalbaran")
        consulta.SelCampo(Albentrada.AEN_TipoFCS, "FCS", Albentrada_lineas.AEL_idalbaran)
        consulta.SelCampo(Albentrada.AEN_IdAlbaran, "idalbaran")
        consulta.WheCampo(Albentrada.AEN_Fecha, ">=", TxDeFechaEnt.Text)
        consulta.WheCampo(Albentrada.AEN_Fecha, "<=", TxAFechaEnt.Text)
        consulta.WheCampo(Albentrada.AEN_IdCentro, "=", TxCentro.Text)


        Dim sql As String = consulta.SQL


        Dim dt As DataTable = Partes.MiConexion.ConsultaSQL(sql)

        If Not dt Is Nothing Then

            Barra.Maximum = dt.Rows.Count
            Barra.Value = 0
            For Each rwl In dt.Rows
                If Barra.Value < Barra.Maximum Then
                    Barra.Value = Barra.Value + 1
                End If



                Dim IdGeneroPrincipal As Integer = VaInt(rwl("idgenero"))
                Dim GeneroPrincipal As String = (rwl("Genero").ToString & "").Trim
                Dim IdFamilia As String = (rwl("IdFamilia").ToString & "").Trim
                Dim IdCategoria As Integer = VaInt(rwl("idcategoria"))
                Dim Categoria As String = (rwl("Categoria").ToString & "").Trim
                Dim Cla As String = (rwl("Cla").ToString & "").Trim
                Dim kilos As Integer = VaDec(rwl("kilos"))
                Dim Precio As Decimal = VaDec(rwl("Precio"))
                Dim TipoPrecio As String = (rwl("TipoPrecio").ToString & "").Trim
                Dim Bultos As Integer = VaInt(rwl("Bultos"))
                Dim Piezas As Integer = VaInt(rwl("Piezas"))

                'Dim importe As Decimal = VaDec(rwl("kilos")) * VaDec(rwl("precio"))
                Dim Importe As Decimal = 0
                Select Case TipoPrecio
                    Case "K"
                        Importe = Precio * kilos
                    Case "B"
                        Importe = Precio * Bultos
                    Case "P"
                        Importe = Precio * Piezas
                End Select

                Dim gastosF As Decimal = 0
                Dim gastosC As Decimal = GastoComercialLinea(VaInt(rwl("idalbaran")), kilos, Importe)
                Dim idlineaentrada As Integer = VaInt(rwl("idlineaentrada"))
                Dim FechaMuestreo As Date = VaDate(rwl("fechamuestreo"))
                Dim Fechavaloracion As Date = VaDate(rwl("fechavaloracion"))
                Dim IdParte As Integer = VaInt(rwl("idparte"))
                Dim idalbaran As Integer = VaInt(rwl("idalbaran"))

                Dim dtc As DataTable = Generoscompuestos.Composicion(IdGeneroPrincipal, GeneroPrincipal, IdFamilia) ' descompongo el genero en porcentajes
                For Each rwg In dtc.Rows


                    Dim IdFamiliaCompuesto As Integer = VaInt(rwg("IdFamilia"))
                    If bTodos Or DcFamilias.ContainsKey(IdFamiliaCompuesto) Then


                        Dim IdGenero As Integer = VaInt(rwg("idgenero"))
                        Dim Genero As String = (rwg("Genero").ToString & "").Trim
                        Dim porcen As Decimal = VaDec(rwg("porcentaje"))

                        If porcen <> 100 Then
                            Dim a As String = ""
                        End If
                        kilos = kilos * porcen / 100
                        importe = importe * porcen / 100
                        gastosF = gastosF * porcen / 100
                        gastosC = gastosC * porcen / 100


                        Select Case rwl("FCS").ToString

                            Case "F"

                                Dim stClaves As New stClaves_Parte(IdGenero, Genero, IdCategoria, Categoria, Cla)
                                'Dim stDatos As New stDatos_Parte(kilos, 0, 0, importe + gastosC, 0, 0, gastosC, 0, 0, 0, 0, 0, 0, 0)
                                Dim stDatos As New stDatos_Parte(kilos, 0, importe, 0, gastosC, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)

                                Acum.Suma(stClaves, stDatos)

                                ' si no está facturado deberiamos avisar

                            Case "S"

                                If FechaMuestreo > CDate("01/01/1900") Then
                                    Dim stClaves As New stClaves_Parte(IdGenero, Genero, IdCategoria, Categoria, Cla)
                                    Dim stDatos As New stDatos_Parte(0, kilos, 0, importe, gastosC, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)

                                    Acum.Suma(stClaves, stDatos)
                                End If

                                ' si no está facturado deberiamos avisar

                            Case Else

                                If albentrada_his.AlbaranFacturado(idalbaran) <> "" Or Fechavaloracion > CDate("01/01/1900") Then ' si están facturados ó valorados 
                                    Dim stClaves As New stClaves_Parte(IdGenero, Genero, IdCategoria, Categoria, Cla)
                                    Dim stDatos As New stDatos_Parte(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, importe + gastosC, 0)
                                    Acum.Suma(stClaves, stDatos)

                                Else

                                    If FechaMuestreo > CDate("01/01/1900") Then

                                        ' acumulo todos los kilos a comision pendientes de valorar para que haga la media,aunque sean de otros partes
                                        Dim stClaves As New stClaves_Parte(IdGenero, Genero, IdCategoria, Categoria, Cla)
                                        Dim stDatos As New stDatos_Parte(0, 0, 0, 0, gastosC, 0, 0, 0, 0, kilos, 0, 0, 0, 0, 0, 0, 0)

                                        Acum.Suma(stClaves, stDatos)
                                        If IdGenero = 9101 Then
                                            Dim a As String = ""
                                        End If

                                        If IdParte = 0 Or IdParte = _idparte Then
                                            If DcLentrada.ContainsKey(idlineaentrada) = False Then
                                                DcLentrada.Add(idlineaentrada, idlineaentrada) ' las partidas que voy a actualizar 
                                            End If
                                        End If

                                        ' partidas para valorar

                                    End If

                                End If
                        End Select

                    End If

                Next

            Next

        End If


    End Sub




    Private Function GastoComercialLinea(Idalbaran As Integer, kilos As Decimal, importe As Decimal) As Decimal
        Dim ret As Decimal = 0

        If VaInt(Idalbaran) = 2034 Then
            Dim a As String = ""
        End If

        Dim sql As String = "SELECT AHG_Valor, AHG_Tipo, AEH_Porcentaje FROM AlbEntrada_HisGastos LEFT JOIN AlbEntrada_His ON AEH_Id = AHG_IdAlbHis WHERE AHG_Idalbaran = " & Idalbaran.ToString + " AND AHG_Factura_Comercial = 'C'"
        Dim DT As DataTable = cn.ConsultaSQL(sql)

        If Not DT Is Nothing Then

            For Each RW In DT.Rows

                Dim porcentaje As Decimal = VaDec(RW("AEH_Porcentaje"))

                Select Case RW("AHG_Tipo").ToString
                    Case "K"
                        Dim Gasto As Decimal = kilos * VaDec(RW("AHG_Valor"))
                        ret = ret + (Gasto * porcentaje) / 100
                    Case "%"
                        Dim Gasto As Decimal = importe * VaDec(RW("AHG_Valor")) / 100
                        ret = ret + (Gasto * porcentaje) / 100
                End Select

            Next
        End If


        Return ret

    End Function



    Private Function GastoComercialLinea_OLD(Idalbaran As Integer, kilos As Decimal, importe As Decimal) As Decimal
        Dim ret As Decimal = 0

        Dim sql As String = "Select AEG_gasto,AEG_tipo from albentrada_gastos where AEG_idalbaran=" + Idalbaran.ToString + " and AEG_tipofc='C'"
        Dim DT As DataTable = cn.ConsultaSQL(sql)
        If Not DT Is Nothing Then
            For Each RW In DT.Rows
                Select Case RW("AEG_tipo").ToString
                    Case "K"
                        ret = ret + kilos * VaDec(RW("AEG_GASTO"))
                    Case "%"
                        ret = ret + importe * VaDec(RW("aeg_gasto")) / 100
                End Select
            Next
        End If


        Return ret

    End Function




    Private Sub CargaVentas_ParteExistente(ByVal IdParte As Integer)


        Dim sql As String = "SELECT PVL_IdGenero as IdGenero, GEN_NombreGenero as Genero, PVL_IdCategoria as IdCategoria, CAE_CategoriaCalibre as Categoria, CAE_clasificacion as Cla," & vbCrLf
        sql = sql & " PVL_IdAlbaran as IdAlbaran, SUM(PVL_KIlosSalida) as KilosV, SUM(PVL_IVenta) as IVenta," & vbCrLf
        sql = sql & " SUM(PVL_GastosF) as GastosF, SUM(PVL_GastosC) as GastosC," & vbCrLf
        sql = sql & " SUM(PVL_Estructura) as Estructura, SUM(PVL_Materiales) as Materiales, SUM(PVL_Manipulacion) as Manipulacion" & vbCrLf
        sql = sql & " FROM Partes_ventas" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = PVL_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasEntrada ON CAE_Id = PVL_IdCategoria" & vbCrLf
        sql = sql & " WHERE PVL_IdParte = " & IdParte.ToString & vbCrLf
        sql = sql & " GROUP BY PVL_IdGenero, GEN_NombreGenero, PVL_IdAlbaran, PVL_IdCategoria, CAE_CategoriaCalibre, CAE_clasificacion" & vbCrLf


        Dim dt As DataTable = Partes.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows

                Dim IdGenero As Integer = VaInt(row("IdGenero"))
                Dim Genero As String = (row("Genero").ToString & "").Trim
                Dim IdCategoria As Integer = VaInt(row("IdCategoria"))
                Dim Categoria As String = (row("Categoria").ToString & "").Trim
                Dim Cla As String = (row("Cla").ToString & "").Trim

                Dim IdAlbaran As Integer = VaInt(row("IdAlbaran"))
                Dim KilosV As Decimal = VaDec(row("KilosV"))
                Dim IVenta As Decimal = VaDec(row("IVenta"))
                Dim GastosF As Decimal = VaDec(row("GastosF"))
                Dim GastosC As Decimal = VaDec(row("GastosC"))
                Dim Estructura As Decimal = VaDec(row("Estructura"))
                Dim Materiales As Decimal = VaDec(row("Materiales"))
                Dim Manipulacion As Decimal = VaDec(row("Manipulacion"))


                Dim stClaves As New stClaves_Parte(IdGenero, Genero, IdCategoria, Categoria, Cla)
                Dim stDatos As New stDatos_Parte(0, 0, 0, 0, 0, KilosV, IVenta, GastosF + GastosC, Estructura + Materiales + Manipulacion, 0, 0, 0, 0, 0, 0, 0, 0)
                Acum.Suma(stClaves, stDatos)

                Dim stClavesVentas As New stClaves_ParteVentas(IdGenero, IdCategoria, IdAlbaran)
                Dim stDatosVentas As New stDatos_ParteVentas(KilosV, IVenta, GastosF, GastosC, Estructura, Materiales, Manipulacion)
                AcumVenta.Suma(stClavesVentas, stDatosVentas)


            Next

        End If



    End Sub


    Private Sub CargaVentas_NuevoParte(bTodos As Boolean, DcFamilias As Dictionary(Of Integer, String))

        Dim Albsalida As New E_AlbSalida(Idusuario, cn)
        Dim Albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
        Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)



        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Albsalida_lineas.ASL_idalbaran, "idalbaran")
        consulta.SelCampo(Albsalida_lineas.ASL_idgenero, "idgenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albsalida_lineas.ASL_idgenero, Generos.GEN_IdGenero)
        consulta.SelCampo(SubFamilias.SFA_idfamilia, "IdFamilia", Generos.GEN_IdsubFamilia, SubFamilias.SFA_id)
        consulta.SelCampo(CategoriasSalida.CAS_IdCategoriaEntrada, "idcategoria", Albsalida_lineas.ASL_idcategoria)
        consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", CategoriasSalida.CAS_IdCategoriaEntrada, Categorias.CAE_Id)
        consulta.SelCampo(Categorias.CAE_clasificacion, "Cla")
        consulta.SelCampo(Albsalida_lineas.ASL_kilosnetos, "kilos")
        consulta.SelCampo(Albsalida_lineas.ASL_importegenerovta, "importe")
        consulta.SelCampo(Albsalida_lineas.ASL_gastoC, "GastoC")
        consulta.SelCampo(Albsalida_lineas.ASL_gastoF, "GastoF")
        consulta.SelCampo(Albsalida_lineas.ASL_GastoPorte, "Porte")
        consulta.SelCampo(Albsalida_lineas.ASL_estructura, "Estructura")
        consulta.SelCampo(Albsalida_lineas.ASL_manipulacion, "Manipulacion")
        consulta.SelCampo(Albsalida_lineas.ASL_materiales, "Materiales")
        consulta.SelCampo(Albsalida.ASA_idalbaran, "idalbaran")
        consulta.SelCampo(Albsalida.ASA_valorcambio, "valorcambio", Albsalida_lineas.ASL_idalbaran)
        consulta.WheCampo(Albsalida.ASA_fechasalida, ">=", TxDeFechaSal.Text)
        consulta.WheCampo(Albsalida.ASA_fechasalida, "<=", TxAFechaSal.Text)
        consulta.WheCampo(Albsalida.ASA_idcentro, "=", TxCentro.Text)


        Dim sql As String = consulta.SQL
        Dim dt As DataTable = Albsalida.MiConexion.ConsultaSQL(sql)


        If Not dt Is Nothing Then
            Barra.Maximum = dt.Rows.Count
            Barra.Value = 0
            For Each rw In dt.Rows
                If Barra.Value < Barra.Maximum Then
                    Barra.Value = Barra.Value + 1
                End If

                Dim IdGeneroPrincipal As Integer = VaInt(rw("idgenero"))
                Dim GeneroPrincipal As String = (rw("Genero").ToString & "").Trim
                Dim IdFamilia As Integer = VaInt(rw("IdFamilia"))
                Dim idcategoria As Integer = VaInt(rw("idcategoria"))
                Dim Categoria As String = (rw("Categoria").ToString & "").Trim
                Dim Cla As String = (rw("Cla").ToString & "").Trim
                Dim kilos As Integer = VaInt(rw("kilos"))
                Dim Importe As Decimal = VaDec(rw("importe")) * VaDec(rw("valorcambio"))
                Dim gastof As Decimal = VaDec(rw("gastof")) * VaDec(rw("valorcambio"))
                Dim gastoc As Decimal = VaDec(rw("gastoc")) + VaDec(rw("porte"))
                Dim gastoo As Decimal = VaDec(rw("estructura")) + VaDec(rw("manipulacion")) + VaDec(rw("Materiales"))

                Dim IdAlbaran As Integer = VaInt(rw("IdAlbaran"))
                Dim Estructura As Decimal = VaDec(rw("Estructura"))
                Dim Materiales As Decimal = VaDec(rw("Materiales"))
                Dim Manipulacion As Decimal = VaDec(rw("Manipulacion"))


                Dim dtc As DataTable = Generoscompuestos.Composicion(IdGeneroPrincipal, GeneroPrincipal, IdFamilia) ' descompongo el genero en porcentajes
                For Each rwg In dtc.Rows

                    Dim IdGenero = VaInt(rwg("idgenero"))
                    Dim Genero As String = (rwg("Genero").ToString & "").Trim


                    Dim IdFamiliaCompuesto As Integer = VaInt(rwg("IdFamilia"))
                    If bTodos Or DcFamilias.ContainsKey(IdFamiliaCompuesto) Then

                        Dim porcen As Decimal = VaDec(rwg("porcentaje"))

                        kilos = kilos * porcen / 100
                        Importe = Importe * porcen / 100
                        gastof = gastof * porcen / 100
                        gastoc = gastoc * porcen / 100
                        gastoo = gastoo * porcen / 100

                        Estructura = Estructura * porcen / 100
                        Materiales = Materiales * porcen / 100
                        Manipulacion = Manipulacion * porcen / 100


                        Dim stClaves As New stClaves_Parte(IdGenero, Genero, idcategoria, Categoria, Cla)
                        Dim stDatos As New stDatos_Parte(0, 0, 0, 0, 0, kilos, Importe, gastof + gastoc, gastoo, 0, 0, 0, 0, 0, 0, 0, 0)
                        Acum.Suma(stClaves, stDatos)

                        Dim stClavesVentas As New stClaves_ParteVentas(IdGenero, idcategoria, IdAlbaran)
                        Dim stDatosVentas As New stDatos_ParteVentas(kilos, Importe, gastof, gastoc, Estructura, Materiales, Manipulacion)
                        AcumVenta.Suma(stClavesVentas, stDatosVentas)


                    End If

                Next





                'Dim stClaves As New stClaves_Parte(idgenero, Genero, idcategoria, Categoria)
                'Dim stDatos As New stDatos_Parte(0, 0, 0, 0, 0, 0, 0, kilos, Importe, gastof + gastoc, gastoo, 0, 0, 0)

                'Acum.Suma(stClaves, stDatos)





            Next
        End If

    End Sub


    Private Sub CargaExistencias(ByVal Inicial As Boolean, bTodos As Boolean, DcFamilias As Dictionary(Of Integer, String))

        Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(ParteExistencias_lineas.PSL_idgenero, "idgenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "NombreGenero", ParteExistencias_lineas.PSL_idgenero)
        consulta.SelCampo(SubFamilias.SFA_idfamilia, "IdFamilia", Generos.GEN_IdsubFamilia, SubFamilias.SFA_id)
        consulta.SelCampo(ParteExistencias_lineas.PSL_idtipoconfeccion, "idconfeccion")
        consulta.SelCampo(CategoriasSalida.CAS_IdCategoriaEntrada, "idcategoria", ParteExistencias_lineas.PSL_idcategoria)
        consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", CategoriasSalida.CAS_IdCategoriaEntrada, Categorias.CAE_Id)
        consulta.SelCampo(Categorias.CAE_clasificacion, "Cla")
        consulta.SelCampo(ParteExistencias_lineas.PSL_kilos, "kilos")
        consulta.SelCampo(ParteExistencias_lineas.PSL_precio, "Precio")
        consulta.SelCampo(ParteExistencias.PSM_idparte, "idparte", ParteExistencias_lineas.PSL_idparte)
        If Inicial = True Then
            consulta.WheCampo(ParteExistencias.PSM_fechainicial, "=", TxDeFechaSal.Text)
        Else
            consulta.WheCampo(ParteExistencias.PSM_fechafinal, "=", TxAFechaSal.Text)

        End If
        consulta.WheCampo(ParteExistencias.PSM_idcentro, "=", TxCentro.Text)
        Dim sql As String = consulta.SQL
        Dim dt As DataTable = ParteExistencias.MiConexion.ConsultaSQL(sql)

        If Not dt Is Nothing Then


            For Each rw In dt.Rows

                Dim IdGeneroPrincipal As Integer = VaInt(rw("idgenero"))
                Dim NombreGenero As String = (rw("NombreGenero").ToString & "").Trim
                Dim IdFamilia As Integer = VaInt(rw("IdFamilia"))
                Dim idconfeccion As Integer = VaInt(rw("idconfeccion"))
                Dim idcategoria As Integer = VaInt(rw("idcategoria"))
                Dim Categoria As String = (rw("Categoria").ToString & "").Trim
                Dim Cla As String = (rw("Cla").ToString & "").Trim
                Dim kilos As Integer = VaInt(rw("kilos"))
                Dim Importe As Decimal = kilos * VaDec(rw("Precio"))


                Dim dtc As DataTable = Generoscompuestos.Composicion(IdGeneroPrincipal, NombreGenero, IdFamilia) ' descompongo el genero en porcentajes
                For Each rwg In dtc.Rows

                    Dim IdGenero = VaInt(rwg("idgenero"))
                    Dim Genero As String = (rwg("Genero").ToString & "").Trim



                    Dim IdFamiliaCompuesto As Integer = VaInt(rwg("IdFamilia"))
                    If bTodos Or DcFamilias.ContainsKey(IdFamiliaCompuesto) Then

                        Dim porcen As Decimal = VaDec(rwg("porcentaje"))
                        Importe = Importe * porcen / 100
                        kilos = kilos * porcen / 100


                        Dim stClaves As New stClaves_Parte(IdGenero, Genero, idcategoria, Categoria, Cla)
                        If Inicial = True Then
                            Dim stDatos As New stDatos_Parte(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Importe, 0, 0, kilos, 0, 0, 0)
                            Acum.Suma(stClaves, stDatos)
                        Else
                            Dim stDatos As New stDatos_Parte(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Importe, 0, 0, kilos, 0, 0)
                            Acum.Suma(stClaves, stDatos)
                        End If

                    End If



                Next

                'Dim stClaves As New stClaves_Parte(idgenero, Genero, idcategoria, Categoria)

                'If Inicial = True Then
                '    Dim stDatos As New stDatos_Parte(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Importe, 0)
                '    Acum.Suma(stClaves, stDatos)
                'Else
                '    Dim stDatos As New stDatos_Parte(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Importe)
                '    Acum.Suma(stClaves, stDatos)
                'End If
            Next
        End If
    End Sub

    Public Overrides Sub Informe()
        MyBase.Informe()

        Dim Dt As DataTable = Grid.DataSource

        Dim Dv As New DataView(Dt)
        Dv.Sort = "SubFam, Genero, Clasificacion, Categoria"
        Dt = Dv.ToTable

        If Not IsNothing(Dt) Then
            Dim listado As New Listado_ParteSemanal(Dt, TxSemana.Text, RbPorImporte.Checked, TipoImpresion.Preliminar)
            listado.ImprimirListado()
        Else
            MsgBox("No hay datos que visualizar.")
        End If
    End Sub

    Private Sub AjustaColumnas()
        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDGENERO", "IDCATEGORIA", "IMPORTEC", "IDSUBFAM", "SUBFAM", "IDFAM", "FAM"
                    c.Visible = False
                Case "IMPORTEF", "IMPORTES", "GASTOSC", "IVENTA", "GASTOSV", "GASTOSO", "NETOVENTA", "DISPONIBLE", "VEXIINI", "VEXIFIN", "VALORADO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.Width = 65

                Case "KILOSF", "KILOSS", "KILOSV", "KILOSC", "KEXIINI", "KEXIFIN"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,###"
                    c.Width = 50

                Case "PMEDIO"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "###0.0000"
                    c.Width = 50
                Case "GENERO"
                    c.Width = 200
                Case "CATEGORIA"
                    c.Width = 100
            End Select
        Next

        AñadeResumenCampo("KilosF", "{0:n0}")
        AñadeResumenCampo("KilosS", "{0:n0}")
        AñadeResumenCampo("KilosC", "{0:n0}")
        AñadeResumenCampo("KilosV", "{0:n0}")
        AñadeResumenCampo("KexiIni", "{0:n0}")
        AñadeResumenCampo("KexiFin", "{0:n0}")
        AñadeResumenCampo("ImporteF", "{0:n2}")
        AñadeResumenCampo("ImporteS", "{0:n2}")
        AñadeResumenCampo("Iventa", "{0:n2}")
        AñadeResumenCampo("GastosV", "{0:n2}")
        AñadeResumenCampo("GastosO", "{0:n2}")
        AñadeResumenCampo("GastosC", "{0:n2}")
        AñadeResumenCampo("NetoVenta", "{0:n2}")
        AñadeResumenCampo("Disponible", "{0:n2}")
        AñadeResumenCampo("VExiIni", "{0:n2}")
        AñadeResumenCampo("VExiFin", "{0:n2}")
        AñadeResumenCampo("Valorado", "{0:n2}")
    End Sub


    Private Sub TxNuparte_Valida(ByVal edicion As Boolean) Handles TxNuparte.Valida

        If edicion = True Then

            Dim idparte As Integer = Partes.LeerParte(MiMaletin.Ejercicio, VaInt(TxNuparte.Text))
            _idparte = idparte
            If idparte > 0 Then


                If Partes.LeerId(idparte.ToString) = True Then
                    Dim idsemana As Integer = VaInt(Partes.PDS_idsemana.Valor)
                    If idsemana > 0 Then
                        If SemanasPartes.LeerId(idsemana) = True Then
                            TxSemana.Text = SemanasPartes.SEV_Semana.Valor
                        End If
                    End If
                    'TxSemana.Text = SemanasPartes.SEV_Semana.Valor
                    TxDeFechaEnt.Text = Partes.PDS_defecha.Valor
                    TxAFechaEnt.Text = Partes.PDS_afecha.Valor
                    TxDeFechaSal.Text = Partes.PDS_defechasal.Valor
                    TxAFechaSal.Text = Partes.PDS_afechasal.Valor
                    TxCentro.Text = Partes.PDS_idcentro.Valor
                    CargaGrid(False)
                    PintaBoton(Partes.PDS_valorada.Valor)
                    '  ActivacionCampos(False)
                    BConsultar.Focus()

                End If


            Else
                CargaFamilias(0)
                BtRegenerar.Visible = False
                'ActivacionCampos(True)
                TxSemana.Focus()
            End If


        End If

    End Sub

    Private Sub ActivacionCampos(Activar As Boolean)
        TxSemana.Enabled = Activar
        TxDeFechaEnt.Enabled = Activar
        TxDeFechaSal.Enabled = Activar
        TxAFechaEnt.Enabled = Activar
        TxAFechaSal.Enabled = Activar
        lstFamilias.Enabled = Activar
        TxCentro.Enabled = Activar
        chkTodos.Enabled = Activar

    End Sub
    Private Sub TxSemana_Valida(ByVal edicion As Boolean) Handles TxSemana.Valida

        If edicion = True Then


            Dim idparte As Integer = Partes.LeerParte(MiMaletin.Ejercicio, VaInt(TxNuparte.Text))
            If idparte > 0 Then
                'Lee las fechas del parte
            Else
                'Si no existe el parte, lee las fechas de la semana

                Dim idsemana As Integer = SemanasPartes.LeerSemana(MiMaletin.Ejercicio, TxSemana.Text)
                If SemanasPartes.LeerId(idsemana) = True Then
                    TxDeFechaEnt.Text = SemanasPartes.SEV_FechaInicialEntrada.Valor
                    TxAFechaEnt.Text = SemanasPartes.SEV_FechaFinalEntrada.Valor
                    TxDeFechaSal.Text = SemanasPartes.SEV_FechaInicialSalida.Valor
                    TxAFechaSal.Text = SemanasPartes.SEV_FechaFinalSalida.Valor
                    If TxCentro.Text = "" Then
                        TxCentro.Text = MiMaletin.IdCentro.ToString
                    End If

                End If

                End If


        End If

    End Sub

    Private Function CargarLosPrecios() As Dictionary(Of stClave_Valoracion, Decimal)

        Dim consulta As New Cdatos.E_select
        Dim ret As New Dictionary(Of stClave_Valoracion, Decimal)

        consulta.SelCampo(Partes_compras.PDL_idgenero, "idgenero")
        consulta.SelCampo(Partes_compras.PDL_idcategoria, "idcategoria")
        consulta.SelCampo(Partes_compras.PDL_PrecioLiquid, "precio")
        consulta.WheCampo(Partes_compras.PDL_idparte, "=", _idparte.ToString)
        Dim sql As String = consulta.SQL
        Dim dt As DataTable = Partes_compras.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                Dim idgenero As Integer = VaInt(rw("idgenero"))
                Dim idcategoria As Integer = VaInt(rw("idcategoria"))
                Dim precio As Decimal = VaDec(rw("precio"))
                Dim kprecio As New stClave_Valoracion
                kprecio.IdCategoria = idcategoria
                kprecio.IdGenero = idgenero
                If ret.ContainsKey(kprecio) = False Then
                    ret.Add(kprecio, precio)
                End If
            Next
        End If
        Return ret


    End Function

    Private Sub PintaBarra()
        If Barra.Value < Barra.Maximum Then
            Barra.Value = Barra.Value + 1
        End If
    End Sub

    Private Sub GuardarParte(ConservaPrecios As Boolean)

        Dim dt As DataTable = CType(Grid.DataSource, DataTable)
        Dim DcPreci As New Dictionary(Of stClave_Valoracion, Decimal) ' diccionario para almacenar los precios de liquiacion
        If IsNothing(dt) Then
            MsgBox("No hay datos para guardar")
            Exit Sub
        Else
            If dt.Rows.Count = 0 Then
                MsgBox("No hay datos para guardar")
                Exit Sub
            End If
        End If


        If VaDate(TxDeFechaEnt.Text) = VaDate("") Or
                VaDate(TxAFechaEnt.Text) = VaDate("") Or
                VaDate(TxDeFechaSal.Text) = VaDate("") Or
                VaDate(TxAFechaSal.Text) = VaDate("") Then
            MsgBox("Debe introducir fechas correctas")
            Exit Sub
        End If



        Dim Partes As New E_Partes(Idusuario, cn)
        Dim idparte As Integer = Partes.LeerParte(MiMaletin.Ejercicio, VaInt(TxNuparte.Text))

        'Si no existe el parte, lo crea
        If idparte <= 0 Then
            ' Partes = New E_Partes(Idusuario, cn)
            Partes.PDS_idparte.Valor = Partes.MaxId()
            Partes.PDS_numero.Valor = TxNuparte.Text
            Partes.PDS_campa.Valor = MiMaletin.Ejercicio.ToString
        End If


        'Actualiza la cabecera
        Dim idsemana As Integer = SemanasPartes.LeerSemana(MiMaletin.Ejercicio, TxSemana.Text)
        Partes.PDS_idsemana.Valor = idsemana.ToString
        Partes.PDS_defecha.Valor = TxDeFechaEnt.Text
        Partes.PDS_afecha.Valor = TxAFechaEnt.Text
        Partes.PDS_defechasal.Valor = TxDeFechaSal.Text
        Partes.PDS_afechasal.Valor = TxAFechaSal.Text
        Partes.PDS_idcentro.Valor = TxCentro.Text



        If idparte > 0 Then
            Partes.Actualizar()
        Else
            idparte = VaInt(Partes.PDS_idparte.Valor)
            Partes.Insertar()
        End If

        _idparte = idparte


        If idparte > 0 Then
            If ConservaPrecios = True Then
                DcPreci = CargarLosPrecios()
            End If


            AnularLineasParte(idparte)

            'Genera compras
            If Not IsNothing(dt) Then
                Barra.Maximum = dt.Rows.Count
                Barra.Value = 0
                For Each row As DataRow In dt.Rows
                    PintaBarra()
                    Dim IdGenero As String = row("IdGenero").ToString & ""
                    Dim IdCategoria As String = row("IdCategoria").ToString & ""
                    Dim KilosF As Decimal = VaDec(row("KilosF"))
                    Dim KilosC As Decimal = VaDec(row("KilosC"))
                    Dim KilosS As Decimal = VaDec(row("KilosS"))
                    Dim ImporteF As Decimal = VaDec(row("ImporteF"))
                    Dim ImporteC As Decimal = VaDec(row("ImporteC"))
                    Dim ImporteS As Decimal = VaDec(row("ImporteS"))
                    Dim GastosCom As Decimal = VaDec(row("GastosC"))
                    Dim Disponible As Decimal = VaDec(row("Disponible"))
                    Dim PMedio As Decimal = VaDec(row("PMedio"))
                    Dim KExiIni As Decimal = VaDec(row("Kexiini"))
                    Dim KExifin As Decimal = VaDec(row("Kexifin"))
                    Dim vExiIni As Decimal = VaDec(row("Vexiini"))
                    Dim vExifin As Decimal = VaDec(row("Vexifin"))
                    Dim Valorado As Decimal = VaDec(row("Valorado"))



                    Dim Partes_Compras As New E_partes_Compras(Idusuario, cn)
                    Partes_Compras.PDL_idlinea.Valor = Partes_Compras.MaxId()
                    Partes_Compras.PDL_idparte.Valor = idparte.ToString
                    Partes_Compras.PDL_idgenero.Valor = IdGenero
                    Partes_Compras.PDL_idcategoria.Valor = IdCategoria
                    Partes_Compras.PDL_kilosF.Valor = KilosF.ToString
                    Partes_Compras.PDL_kilosC.Valor = KilosC.ToString
                    Partes_Compras.PDL_kilosS.Valor = KilosS.ToString
                    Partes_Compras.PDL_ImporteF.Valor = ImporteF.ToString
                    'Partes_Compras.PDL_ImporteC.Valor = ImporteC.ToString
                    Partes_Compras.PDL_ImporteS.Valor = ImporteS.ToString
                    Partes_Compras.PDL_GastosCom.Valor = GastosCom.ToString
                    Partes_Compras.PDL_Disponible.Valor = Disponible.ToString
                    Partes_Compras.PDL_PrecioAprox.Valor = PMedio.ToString
                    Partes_Compras.PDL_KilosExIni.Valor = KExiIni.ToString
                    Partes_Compras.PDL_KilosExFin.Valor = KExifin.ToString
                    Partes_Compras.PDL_ImpExIni.Valor = vExiIni.ToString
                    Partes_Compras.PDL_ImpExFin.Valor = vExifin.ToString
                    Partes_Compras.PDL_ImporteFAC.Valor = Valorado.ToString

                    Dim idfamilia As Integer = 0
                    If Generos.LeerId(IdGenero) = True Then
                        If SubFamilias.LeerId(Generos.GEN_IdsubFamilia.Valor) = True Then
                            idfamilia = VaInt(SubFamilias.SFA_idfamilia.Valor)
                        End If
                    End If
                    Partes_Compras.PDL_idfamilia.Valor = idfamilia.ToString

                    Dim kprecio As New stClave_Valoracion
                    kprecio.IdCategoria = IdCategoria
                    kprecio.IdGenero = IdGenero
                    Partes_Compras.PDL_PrecioLiquid.Valor = "0"
                    If ConservaPrecios = True Then
                        For Each clave In DcPreci.Keys
                            If clave.IdCategoria = IdCategoria And clave.IdGenero = IdGenero Then
                                Partes_Compras.PDL_PrecioLiquid.Valor = DcPreci(clave)
                            End If
                        Next
                    End If
                    Partes_Compras.Insertar()

                Next


            End If


            'Genera ventas
            Dim dtVentas As DataTable = AcumVenta.DataTable()
            If Not IsNothing(dtVentas) Then
                Barra.Maximum = dtVentas.Rows.Count
                Barra.Value = 0
                For Each row As DataRow In dtVentas.Rows
                    PintaBarra()
                    Dim IdGenero As String = row("IdGenero").ToString & ""
                    Dim IdCategoria As String = row("IdCategoria").ToString & ""
                    Dim IdAlbaran As String = row("IdAlbaran").ToString & ""
                    Dim KilosSal As Decimal = VaDec(row("KilosSal"))
                    Dim IVenta As Decimal = VaDec(row("IVenta"))
                    Dim GastosC As Decimal = VaDec(row("GastosC"))
                    Dim GastosF As Decimal = VaDec(row("GastosF"))
                    Dim Estructura As Decimal = VaDec(row("Estructura"))
                    Dim Materiales As Decimal = VaDec(row("Materiales"))
                    Dim Manipulacion As Decimal = VaDec(row("Manipulacion"))

                    Dim Partes_Ventas As New E_partes_Ventas(Idusuario, cn)
                    Partes_Ventas.PVL_idlinea.Valor = Partes_Ventas.MaxId()
                    Partes_Ventas.PVL_idparte.Valor = idparte.ToString
                    Partes_Ventas.PVL_idgenero.Valor = IdGenero
                    Partes_Ventas.PVL_idcategoria.Valor = IdCategoria
                    Partes_Ventas.PVL_idalbaran.Valor = IdAlbaran
                    Partes_Ventas.PVL_kilossalida.Valor = KilosSal.ToString
                    Partes_Ventas.PVL_iventa.Valor = IVenta.ToString
                    Partes_Ventas.PVL_GastosF.Valor = GastosF.ToString
                    Partes_Ventas.PVL_GastosC.Valor = GastosC.ToString
                    Partes_Ventas.PVL_Estructura.Valor = Estructura.ToString
                    Partes_Ventas.PVL_Materiales.Valor = Materiales.ToString
                    Partes_Ventas.PVL_Manipulacion.Valor = Manipulacion.ToString
                    Partes_Ventas.Insertar()

                Next
            End If



            ' GENERA FAMILIAS
            For indice As Integer = 0 To lstFamilias.ItemCount - 1
                If lstFamilias.GetItemChecked(indice) Then

                    Dim ID As Integer = Partes_familias.MaxId
                    Partes_familias.VaciaEntidad()
                    Partes_familias.PFM_id.Valor = ID.ToString
                    Partes_familias.PFM_idparte.Valor = idparte.ToString
                    Partes_familias.PFM_IDfamilia.Valor = lstFamilias.GetItemValue(indice).ToString
                    Partes_familias.Insertar()

                End If
            Next

            Dim albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)

            ' actualizo las partidas.
            For Each idlineaentrada In DcLentrada.Keys
                If albentrada_lineas.LeerId(idlineaentrada) = True Then
                    albentrada_lineas.AEL_Idparte.Valor = idparte.ToString
                    albentrada_lineas.Actualizar()
                End If
            Next


        Else
            MsgBox("Error al guardar los datos de la cabecera del parte")
        End If



    End Sub


    Private Sub AnularParte(idparte As Integer)
        If Partes.LeerId(idparte) = True Then
            AnularLineasParte(idparte)
            Partes.Eliminar()
        End If
        Dim sql As String = "update albentrada_lineas set AEL_IDPARTE=0 where AEL_idparte=" + idparte.ToString
        Partes.MiConexion.OrdenSql(sql)
        MsgBox("Parte anulado")
        BorraPan()




    End Sub
    Private Sub AnularLineasParte(idparte As Integer)
        'Borra las líneas de compras y ventas
        Dim sql As String = "DELETE FROM Partes_Compras WHERE PDL_IdParte = " & idparte.ToString
        Partes.MiConexion.OrdenSql(sql)

        sql = "DELETE FROM Partes_Ventas WHERE PVL_IdParte = " & idparte.ToString
        Partes.MiConexion.OrdenSql(sql)


        sql = "DELETE FROM Partes_Familias where PFM_idparte = " & idparte.ToString
        Partes.MiConexion.OrdenSql(sql)


    End Sub

    Private Sub BtRegenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtRegenerar.Click

        Dim conservarprecios As Boolean = MsgBox("Desea conservar los precios de liquidación", vbYesNo)

        If MsgBox("Desea generar las líneas del parte", vbYesNo) = vbYes Then
            
            CargaGrid(True)
            GuardarParte(conservarprecios)
            MsgBox("Parte Generado")

        End If


    End Sub

    Private Sub PintaBoton(Valorada As String)
        If Valorada = "S" Then
            BtRegenerar.Visible = False
            btPrecios.Visible = True
            Balbaranes.Visible = True

            LbValorado.Visible = True
            Banular.Visible = False
        Else
            BtRegenerar.Visible = True
            btPrecios.Visible = True
            Balbaranes.Visible = True
            LbValorado.Visible = False
            Banular.Visible = True
        End If
    End Sub

    Private Sub btPrecios_Click(sender As System.Object, e As System.EventArgs) Handles btPrecios.Click

        If _idparte > 0 Then
            Dim frm As New FrmValoracionComision(_idparte)
            frm.ShowDialog()
            If Partes.LeerId(_idparte.ToString) = True Then
                PintaBoton(Partes.PDS_valorada.Valor)
            End If
        Else
            MsgBox("Número de parte erróneo")
        End If




    End Sub

    Private Sub CargaFamilias(idparte As Integer)

        Dim Familias As New E_FamiliasGeneros(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Familias.FAG_idfamilia, "idfamilia")
        consulta.SelCampo(Familias.FAG_nombre, "Familia")

        Dim sql As String = consulta.SQL
        sql = sql & " order by fag_idfamilia"

        Dim dt As DataTable = Familias.MiConexion.ConsultaSQL(sql)

        lstFamilias.DataSource = dt
        lstFamilias.ValueMember = "idfamilia"
        lstFamilias.DisplayMember = "Familia"


        If dt.Rows.Count = 0 Then
            chkTodos.Visible = False
        Else
            chkTodos.Visible = True
        End If


        If idparte = 0 Then
            chkTodos.CheckState = CheckState.Checked
        Else

            For indice As Integer = 0 To lstFamilias.ItemCount - 1

                Dim valor As Integer = VaInt(lstFamilias.GetItemValue(indice))

                If Partes_familias.LeerParte_Familia(idparte.ToString, valor.ToString) > 0 Then
                    lstFamilias.SetItemChecked(indice, True)
                Else
                    lstFamilias.SetItemChecked(indice, False)
                End If
            Next

        End If


    End Sub

    Private Function TodosLosGeneros() As Boolean

        Dim contChecked As Integer = 0
        Dim contUnChecked As Integer = 0

        For indice As Integer = 0 To lstFamilias.ItemCount - 1
            If lstFamilias.GetItemChecked(indice) Then
                contChecked = contChecked + 1
            Else
                contUnChecked = contUnChecked + 1
            End If
        Next


        If contChecked = lstFamilias.ItemCount Or contUnChecked = lstFamilias.ItemCount Then
            Return True
        Else
            Return False
        End If


    End Function


    Private Sub chkTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTodos.CheckedChanged

        If chkTodos.Checked Then
            lstFamilias.CheckAll()
        Else
            lstFamilias.UnCheckAll()
        End If


    End Sub

    Private Sub TxNuparte_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxNuparte.TextChanged

    End Sub

    Private Sub BConsultar_Click(sender As System.Object, e As System.EventArgs) Handles BConsultar.Click

    End Sub

    Private Sub BtAux_Click(sender As System.Object, e As System.EventArgs) Handles BtAux.Click
        If MsgBox("Desea guardar el parte", vbYesNo) = vbYes Then
            Dim conservarprecios As Boolean = MsgBox("Desea conservar los precios de liquidación", vbYesNo)
            GuardarParte(conservarprecios)
            MsgBox("Terminado")
            BtRegenerar.Visible = True
            btPrecios.Visible = True
            Balbaranes.Visible = True


            LbValorado.Visible = False
            Banular.Visible = True
        End If

    End Sub

    Private Sub Banular_Click(sender As System.Object, e As System.EventArgs) Handles Banular.Click
        If _idparte > 0 Then
            If MsgBox("Desea anular el parte", vbYesNo) = vbYes Then
                AnularParte(_idparte)
            End If
        End If
    End Sub

    Private Sub VerAlbaranes()

        Dim Albentrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)
        Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
        Dim Agricultores As New E_Agricultores(Idusuario, cn)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Albentrada_lineascla.ALC_idlineaentrada, "idlineaentrada")
        consulta.SelCampo(Albentrada_lineas.AEL_muestreo, "Partida", Albentrada_lineascla.ALC_idlineaentrada)
        consulta.SelCampo(Albentrada.AEN_Albaran, "Albaran", Albentrada_lineas.AEL_idalbaran)
        consulta.SelCampo(Albentrada.AEN_Fecha, "Fecha")
        consulta.SelCampo(Agricultores.AGR_Nombre, "Agricultor", Albentrada.AEN_IdAgricultor)
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albentrada_lineascla.ALC_idgenero)
        consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", Albentrada_lineascla.ALC_idcategoria)
        consulta.SelCampo(Albentrada_lineascla.ALC_kilosnetos, "Kilos")
        consulta.SelCampo(Albentrada_lineascla.ALC_precio, "Precio")

        Dim Importe As New Cdatos.bdcampo("@(alc_Kilosnetos*Alc_precio)", Cdatos.TiposCampo.Importe, 10, 2)
        consulta.SelCampo(Importe, "Importe")

        consulta.WheCampo(Albentrada_lineas.AEL_IdParte, "=", _idparte.ToString)
        Dim sql As String = consulta.SQL
        sql = sql + " order by aen_fecha"
        Dim dt As DataTable = Albentrada.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then

            Dim lst As New List(Of Parametros)

            lst.Add(New Parametros("idlineaentrada", False, "", -1))
            lst.Add(New Parametros("Partida", False, "", 100))
            lst.Add(New Parametros("Albaran", False, "", 100))
            lst.Add(New Parametros("Fecha", False, "", 150))
            lst.Add(New Parametros("Agricultor", False, "", 300))
            lst.Add(New Parametros("Genero", False, "", 250))
            lst.Add(New Parametros("Categoria", False, "", 150))
            lst.Add(New Parametros("Kilos", True, "", 150))
            lst.Add(New Parametros("Precio", False, "{0:n4}", 150))
            lst.Add(New Parametros("Importe", True, "{0:n2}", 150))


            Dim f As New FrConsultaGenerica(dt, lst, "Albaranes del parte")
            f.ShowDialog()

        End If



    End Sub

    Private Sub PendienteValorar()

        Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim Albentrada As New E_AlbEntrada(Idusuario, cn)
        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Dim Partes As New E_Partes(Idusuario, cn)

        Dim Dtt As New DataTable

        Dtt.Columns.Add("Partida", GetType(System.Int32))
        Dtt.Columns.Add("Albaran", GetType(System.Int32))
        Dtt.Columns.Add("Fecha", GetType(System.DateTime))
        Dtt.Columns.Add("FCS", GetType(System.String))
        Dtt.Columns.Add("Agricultor", GetType(System.String))
        Dtt.Columns.Add("Genero", GetType(System.String))
        Dtt.Columns.Add("Kilos", GetType(System.Int32))
        Dtt.Columns.Add("Idparte", GetType(System.Int32))
        Dtt.Columns.Add("Parte", GetType(System.Int32))

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Albentrada_lineas.AEL_muestreo, "Partida")
        consulta.SelCampo(Albentrada.AEN_Albaran, "Albaran", Albentrada_lineas.AEL_idalbaran)
        consulta.SelCampo(Albentrada.AEN_Fecha, "Fecha")
        consulta.SelCampo(Albentrada.AEN_TipoFCS, "FCS")
        consulta.SelCampo(Agricultores.AGR_Nombre, "Agricultor", Albentrada.AEN_IdAgricultor)
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Albentrada_lineas.AEL_idgenero)
        consulta.SelCampo(Albentrada_lineas.AEL_kilosnetos, "Kilos")
        consulta.SelCampo(Albentrada_lineas.AEL_precio, "Precio")
        consulta.SelCampo(Albentrada_lineas.AEL_Idparte, "idparte")
        consulta.SelCampo(Partes.PDS_numero, "Parte", Albentrada_lineas.AEL_Idparte)
        consulta.SelCampo(Albentrada_lineas.AEL_FechaValoracion, "Valoracion")

        consulta.WheCampo(Albentrada.AEN_Fecha, ">=", TxDeFechaEnt.Text)
        consulta.WheCampo(Albentrada.AEN_Fecha, "<=", TxAFechaEnt.Text)
        consulta.WheCampo(Albentrada.AEN_IdCentro, "=", TxCentro.Text)
        Dim sql As String = consulta.SQL
        sql = sql + " order by aen_fecha"
        Dim dt As DataTable = Albentrada.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then

            For Each rw In dt.Rows
                Dim e As Boolean = True
                Select Case rw("FCS").ToString
                    Case "F"
                        If VaDec(rw("Precio")) > 0 Then
                            e = False
                        End If
                    Case "S", "C"
                        If CDate(rw("valoracion")) > CDate("01/01/1900") Then
                            e = False
                        End If

                End Select
                If e = True Then
                    Dtt.Rows.Add(VaInt(rw("Partida")), VaInt(rw("albaran")), rw("fecha").ToString, rw("FCS").ToString, rw("Agricultor").ToString, rw("Genero").ToString, VaInt(rw("Kilos")), VaInt(rw("idparte")), VaInt(rw("parte")))
                End If
            Next

            Dim lst As New List(Of Parametros)

            lst.Add(New Parametros("Partida", False, "", 100))
            lst.Add(New Parametros("Albaran", False, "", 100))
            lst.Add(New Parametros("Fecha", False, "", 150))
            lst.Add(New Parametros("FCS", False, "", 80))
            lst.Add(New Parametros("Agricultor", False, "", 300))
            lst.Add(New Parametros("Genero", False, "", 250))
            lst.Add(New Parametros("Kilos", True, "", 150))
            lst.Add(New Parametros("IdParte", False, "", 100))
            lst.Add(New Parametros("Parte", False, "", 100))


            Dim f As New FrConsultaGenerica(Dtt, lst, "Pendiente de valorar")
            f.ShowDialog()

        End If



    End Sub

    Private Sub PendienteValorarVentas()


        Dim Albsalida As New E_AlbSalida(Idusuario, cn)
        Dim Clientes As New E_Clientes(Idusuario, cn)

        Dim Dtt As New DataTable

        Dtt.Columns.Add("Albaran", GetType(System.Int32))
        Dtt.Columns.Add("Fecha", GetType(System.DateTime))
        Dtt.Columns.Add("FC", GetType(System.String))
        Dtt.Columns.Add("Cliente", GetType(System.String))
       
    
        Dim consulta As New Cdatos.E_select

        consulta.SelCampo(Albsalida.ASA_albaran, "Albaran")
        consulta.SelCampo(Albsalida.ASA_fechasalida, "Fecha")
        consulta.SelCampo(Albsalida.ASA_tipofc, "Fc")
        consulta.SelCampo(Clientes.CLI_Nombre, "Cliente", Albsalida.ASA_idcliente)
        consulta.SelCampo(Albsalida.ASA_idfactura, "idfactura")
        consulta.SelCampo(Albsalida.ASA_fechavaloracion, "Valoracion")
        consulta.WheCampo(Albsalida.ASA_fechasalida, ">=", TxDeFechaSal.Text)
        consulta.WheCampo(Albsalida.ASA_fechasalida, "<=", TxAFechaSal.Text)
        consulta.WheCampo(Albsalida.ASA_idcentro, "=", TxCentro.Text)

        Dim sql As String = consulta.SQL
        sql = sql + " order by asa_fechasalida"
        Dim dt As DataTable = Albsalida.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then

            For Each rw In dt.Rows
                Dim e As Boolean = True
                Select Case rw("FC").ToString
                    Case "F"
                        If VaDec(rw("idfactura")) > 0 Then
                            e = False
                        End If
                    Case "C"
                        If CDate(rw("valoracion")) > CDate("01/01/1900") Then
                            e = False
                        End If

                End Select
                If e = True Then
                    Dtt.Rows.Add(VaInt(rw("albaran")), rw("fecha").ToString, rw("FC").ToString, rw("Cliente").ToString)
                End If
            Next

            Dim lst As New List(Of Parametros)

            lst.Add(New Parametros("Albaran", False, "", 100))
            lst.Add(New Parametros("Fecha", False, "", 150))
            lst.Add(New Parametros("FCS", False, "", 80))
            lst.Add(New Parametros("Cliente", False, "", 300))


            Dim f As New FrConsultaGenerica(Dtt, lst, "Pendiente de valorar")
            f.ShowDialog()

        End If



    End Sub

    Private Sub Balbaranes_Click(sender As System.Object, e As System.EventArgs) Handles Balbaranes.Click
        If _idparte > 0 Then
            VerAlbaranes()
        End If
    End Sub

    Private Sub BtPendiente_Click(sender As System.Object, e As System.EventArgs) Handles BtPendiente.Click
        If TxDeFechaEnt.Text <> "" And TxAFechaEnt.Text <> "" Then
            PendienteValorar()
        End If
    End Sub

    Private Sub ClButton1_Click(sender As System.Object, e As System.EventArgs) Handles ClButton1.Click
        If TxDeFechaSal.Text <> "" And TxAFechaSal.Text <> "" Then
            PendienteValorarVentas()
        End If
    End Sub

    
End Class