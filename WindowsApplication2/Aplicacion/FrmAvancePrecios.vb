Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls


Public Class FrmAvancePrecios
    Inherits FrConsulta


    Dim PartesInicio As New E_Partes(Idusuario, cn)
    Dim PartesFin As New E_Partes(Idusuario, cn)
    Dim Partes_compras As New E_partes_Compras(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim Categorias As New E_CategoriasEntrada(Idusuario, cn)
    Dim SubFamilias As New E_Subfamilias(Idusuario, cn)
    Dim FamiliasGeneros As New E_FamiliasGeneros(Idusuario, cn)



    Private Class stClaves_Parte

        Public IdFam As Integer = 0
        Public Fam As String = ""
        Public IdSubFam As Integer = 0
        Public SubFam As String = ""
        Public IdGenero As Integer = 0
        Public Genero As String = ""
        Public IdCategoria As Integer = 0
        Public Categoria As String = ""
        Public Clasificacion As String = ""

        Public Sub New(ByVal IdFam As Integer, ByVal Fam As String, ByVal IdSubFam As Integer, ByVal SubFam As String,
                       ByVal IdGenero As Integer, ByVal Genero As String, ByVal IdCategoria As Integer, ByVal Categoria As String,
                       ByVal clasificacion As String)


            Me.IdFam = IdFam
            Me.Fam = Fam
            Me.IdSubFam = IdSubFam
            Me.SubFam = SubFam
            Me.IdGenero = IdGenero
            Me.Genero = Genero
            Me.IdCategoria = IdCategoria
            Me.Categoria = Categoria
            Me.Clasificacion = clasificacion

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


    Dim Acum As New Acumulador


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDesdeParte, Nothing, LbDesdeParte, True, Cdatos.TiposCampo.EnteroPositivo, , 6)
        ParamTx(TxHastaParte, Nothing, LbHastaParte, True, Cdatos.TiposCampo.EnteroPositivo, , 6)
        cbCentro = ComboCentro(cbCentro, MiMaletin.IdCentro)
        AsociarControles(TxDesdeParte, BtBuscaParteDesde, PartesInicio.btBusca, PartesInicio)
        AsociarControles(TxHastaParte, BtBuscaParteHasta, PartesFin.btBusca, PartesFin)

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Acum.Borrar()
        'AcumVenta.Borrar()

    End Sub


    Private Sub FrmAvancePrecios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        BtAux.Visible = True
        BtAux.Text = "Guardar Parte"
        BtAux.Width = 90
        BtAux.Image = NetAgro.My.Resources.Resources.App_kservices_16x16_32

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        If VaInt(TxDesdeParte.Text) = 0 Or VaInt(TxHastaParte.Text) = 0 Then
            MsgBox("Debe introducir un parte de inicio y otro de final para realizar la consulta")
            Exit Sub
        End If


        CargaGrid()

    End Sub


    Private Sub CargaGrid()

        Acum.Borrar()


        Grid.DataSource = Nothing


        
        CargaCompras()
        CargaPreciosLiqui()
        CargaVentas()



        Dim dt As DataTable = Acum.DataTable

        If dt.Rows.Count > 0 Then

            dt.Columns.Add("NetoVenta", GetType(System.Decimal)).SetOrdinal(15)
            dt.Columns.Add("Disponible", GetType(System.Decimal)).SetOrdinal(18)
            dt.Columns.Add("Pmedio", GetType(System.Decimal))

      
            Barra.Value = 0
            Barra.Maximum = dt.Rows.Count - 1


            For indice As Integer = 0 To dt.Rows.Count - 1
                Dim row As DataRow = dt.Rows(indice)

                Dim Neto As Decimal = VaDec(row("Iventa")) - VaDec(row("GastosV")) - VaDec(row("GastosO"))
                row("NetoVenta") = Neto

                Dim Disponible As Decimal = Neto - VaDec(row("ImporteF")) - VaDec(row("ImporteS")) - VaDec(row("GastosC")) - VaDec(row("Valorado"))
                Disponible = Disponible + VaDec(row("VEXIFIN")) - VaDec(row("VEXIINI"))
                row("Disponible") = Disponible

                If VaDec(row("kilosc")) > 0 Then row("pmedio") = Disponible / VaDec(row("kilosc"))

                Barra.Value = indice

            Next

        End If


        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                Dim dv As New DataView(dt)
                dv.Sort = "IdGenero, IdCategoria"
                dt = dv.ToTable

            End If
        End If

        Grid.DataSource = dt
        AjustaColumnas()

    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDGENERO", "IDCATEGORIA", "IMPORTEC", "IDSUBFAM", "SUBFAM", "IDFAM", "FAM"
                    c.Visible = False
            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim

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


    Private Sub CargaCompras()

        Dim Partes As New E_Partes(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Partes_compras.PDL_idgenero, "IdGenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Partes_compras.PDL_idgenero, Generos.GEN_IdGenero)
        consulta.SelCampo(Generos.GEN_IdsubFamilia, "IdSubFam")
        consulta.SelCampo(SubFamilias.SFA_nombre, "SubFam", Generos.GEN_IdsubFamilia)
        consulta.SelCampo(SubFamilias.SFA_idfamilia, "IdFam")
        consulta.SelCampo(FamiliasGeneros.FAG_nombre, "Fam", SubFamilias.SFA_idfamilia)
        consulta.SelCampo(Partes_compras.PDL_idcategoria, "IdCategoria")
        consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", Partes_compras.PDL_idcategoria, Categorias.CAE_Id)
        consulta.SelCampo(Categorias.CAE_clasificacion, "Cla")
        consulta.SelCampo(Partes_compras.PDL_kilosF, "KilosF")
        consulta.SelCampo(Partes_compras.PDL_ImporteF, "ImporteF")
        consulta.SelCampo(Partes_compras.PDL_kilosS, "KilosS")
        consulta.SelCampo(Partes_compras.PDL_ImporteS, "ImporteS")
        consulta.SelCampo(Partes_compras.PDL_GastosCom, "GastosC")
        consulta.SelCampo(Partes_compras.PDL_kilosC, "KilosC")
        consulta.SelCampo(Partes_compras.PDL_ImporteFAC, "Valorado")
        consulta.SelCampo(Partes_compras.PDL_KilosExIni, "Kexini")
        consulta.SelCampo(Partes_compras.PDL_KilosExFin, "Kexfin")
        consulta.SelCampo(Partes_compras.PDL_ImpExIni, "Vexini")
        consulta.SelCampo(Partes_compras.PDL_ImpExFin, "Vexfin")
        consulta.SelCampo(Partes.PDS_numero, "Parte", Partes_compras.PDL_idparte)
        consulta.WheCampo(Partes.PDS_numero, ">=", TxDesdeParte.Text)
        consulta.WheCampo(Partes.PDS_numero, "<=", TxHastaParte.Text)



        Dim sql As String = consulta.SQL & vbCrLf
        sql = sql + CadenaWhereLista(Partes.PDS_idcentro, ListadeCombo(cbCentro), " AND ")
        sql = sql & " ORDER BY PDS_Numero" & vbCrLf



        Dim dt As DataTable = Partes.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            For indice As Integer = 0 To dt.Rows.Count - 1
                Dim row As DataRow = dt.Rows(indice)

                Dim IdFam As Integer = VaInt(row("IdFam"))
                Dim Fam As String = (row("Fam").ToString & "").Trim
                Dim IdSubFam As Integer = VaInt(row("IdSubFam"))
                Dim SubFam As String = (row("SubFam").ToString & "").Trim
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
                Dim GastosC As Decimal = VaDec(row("GastosC"))
                Dim Valorado As Decimal = VaDec(row("Valorado"))
                Dim KexIni As Decimal = VaDec(row("kexini"))
                Dim Kexfin As Decimal = VaDec(row("kexfin"))
                Dim vexIni As Decimal = VaDec(row("vexini"))
                Dim vexfin As Decimal = VaDec(row("vexfin"))
                Dim Parte As Integer = VaInt(row("Parte"))

                If Parte <> VaInt(TxDesdeParte.Text) Then
                    vexIni = 0
                End If
                If Parte <> VaInt(TxHastaParte.Text) Then
                    vexfin = 0
                End If


                Dim stClaves As New stClaves_Parte(IdFam, Fam, IdSubFam, SubFam, IdGenero, Genero, IdCategoria, Categoria, Cla)
                Dim stDatos As New stDatos_Parte(KilosF, KilosS, ImporteF, ImporteS, GastosC, 0, 0, 0, 0, KilosC, vexIni, vexfin, 0, KexIni, Kexfin, Valorado, 0)
                Acum.Suma(stClaves, stDatos)

            Next

        End If


    End Sub


    Private Sub CargaPreciosLiqui()

        Dim Partes As New E_Partes(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Partes_compras.PDL_idgenero, "IdGenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", Partes_compras.PDL_idgenero, Generos.GEN_IdGenero)
        consulta.SelCampo(Generos.GEN_IdsubFamilia, "IdSubFam")
        consulta.SelCampo(SubFamilias.SFA_nombre, "SubFam", Generos.GEN_IdsubFamilia)
        consulta.SelCampo(SubFamilias.SFA_idfamilia, "IdFam")
        consulta.SelCampo(FamiliasGeneros.FAG_nombre, "Fam", SubFamilias.SFA_idfamilia)
        consulta.SelCampo(Partes_compras.PDL_idcategoria, "IdCategoria")
        consulta.SelCampo(Categorias.CAE_CategoriaCalibre, "Categoria", Partes_compras.PDL_idcategoria, Categorias.CAE_Id)
        consulta.SelCampo(Categorias.CAE_clasificacion, "Cla")
        Dim iliqui As New Cdatos.bdcampo("@PDL_precioliquid*PDL_kilosc", Cdatos.TiposCampo.Importe, 15, 2)
        consulta.SelCampo(iliqui, "ImpLiqui")
        consulta.SelCampo(Partes.PDS_idparte, "IdParte", Partes_compras.PDL_idparte)
        consulta.WheCampo(Partes.PDS_numero, ">=", TxDesdeParte.Text)
        consulta.WheCampo(Partes.PDS_numero, "<=", TxHastaParte.Text)


        Dim sql As String = consulta.SQL

        Dim dt As DataTable = Partes_compras.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows

                Dim IdFam As Integer = VaInt(row("IdFam"))
                Dim Fam As String = (row("Fam").ToString & "").Trim
                Dim IdSubFam As Integer = VaInt(row("IdSubFam"))
                Dim SubFam As String = (row("SubFam").ToString & "").Trim
                Dim IdGenero As Integer = VaInt(row("IdGenero"))
                Dim Genero As String = (row("Genero").ToString & "").Trim
                Dim IdCategoria As Integer = VaInt(row("IdCategoria"))
                Dim Categoria As String = (row("Categoria").ToString & "").Trim
                Dim Cla As String = (row("Cla").ToString & "").Trim
                Dim impliqui As Decimal = VaDec(row("impliqui"))


                Dim stClaves As New stClaves_Parte(IdFam, Fam, IdSubFam, SubFam, IdGenero, Genero, IdCategoria, Categoria, Cla)
                Dim stDatos As New stDatos_Parte(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, impliqui)
                Acum.Suma(stClaves, stDatos)

            Next

        End If

    End Sub


    Private Sub CargaVentas()


        Dim sql As String = "SELECT SFA_IdFamilia as IdFam, FAG_Nombre as Fam, GEN_IdSubFamilia as IdSubFam, SFA_Nombre as SubFam," & vbCrLf
        sql = sql & " PVL_IdGenero as IdGenero, GEN_NombreGenero as Genero, PVL_IdCategoria as IdCategoria, CAE_CategoriaCalibre as Categoria, CAE_clasificacion as Cla," & vbCrLf
        sql = sql & " PVL_IdAlbaran as IdAlbaran, SUM(PVL_KIlosSalida) as KilosV, SUM(PVL_IVenta) as IVenta," & vbCrLf
        sql = sql & " SUM(PVL_GastosF) as GastosF, SUM(PVL_GastosC) as GastosC," & vbCrLf
        sql = sql & " SUM(PVL_Estructura) as Estructura, SUM(PVL_Materiales) as Materiales, SUM(PVL_Manipulacion) as Manipulacion" & vbCrLf
        sql = sql & " FROM Partes_ventas" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = PVL_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN SubFamilias ON GEN_IdSubFamilia = SFA_Id" & vbCrLf
        sql = sql & " LEFT JOIN FamiliasGeneros ON SFA_IdFamilia = FAG_IdFamilia" & vbCrLf
        sql = sql & " LEFT JOIN CategoriasEntrada ON CAE_Id = PVL_IdCategoria" & vbCrLf
        sql = sql & " LEFT JOIN Partes ON PVL_IdParte = PDS_IdParte" & vbCrLf
        sql = sql & " WHERE PDS_Numero >= " & TxDesdeParte.Text & vbCrLf
        sql = sql & " AND PDS_Numero <= " & TxHastaParte.Text & vbCrLf
        sql = sql & " GROUP BY SFA_IdFamilia, FAG_Nombre, GEN_IdSubFamilia, SFA_Nombre, PVL_IdGenero, GEN_NombreGenero, PVL_IdAlbaran, PVL_IdCategoria, CAE_CategoriaCalibre, CAE_clasificacion" & vbCrLf


        Dim dt As DataTable = FamiliasGeneros.MiConexion.ConsultaSQL(sql)
        If Not IsNothing(dt) Then

            For Each row As DataRow In dt.Rows

                Dim IdFam As Integer = VaInt(row("IdFam"))
                Dim Fam As String = (row("Fam").ToString & "").Trim
                Dim IdSubFam As Integer = VaInt(row("IdSubFam"))
                Dim SubFam As String = (row("SubFam").ToString & "").Trim
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


                Dim stClaves As New stClaves_Parte(IdFam, Fam, IdSubFam, SubFam, IdGenero, Genero, IdCategoria, Categoria, Cla)
                Dim stDatos As New stDatos_Parte(0, 0, 0, 0, 0, KilosV, IVenta, GastosF + GastosC, Estructura + Materiales + Manipulacion, 0, 0, 0, 0, 0, 0, 0, 0)
                Acum.Suma(stClaves, stDatos)

            Next

        End If


    End Sub


    Private Sub TxDesdeParte_Valida(edicion As System.Boolean) Handles TxDesdeParte.Valida

        If VaInt(TxDesdeParte.Text) > 0 Then
            If PartesInicio.LeerParte(MiMaletin.Ejercicio, VaInt(TxDesdeParte.Text)) Then
                LbFechaDesde.Text = PartesInicio.PDS_defecha.Valor
            End If
        End If

    End Sub


    Private Sub TxHastaParte_Valida(edicion As System.Boolean) Handles TxHastaParte.Valida

        If VaInt(TxHastaParte.Text) > 0 Then
            If PartesFin.LeerParte(MiMaletin.Ejercicio, VaInt(TxHastaParte.Text)) Then
                LbFechaHasta.Text = PartesFin.PDS_afecha.Valor
            End If
        End If

    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim Dt As DataTable = Grid.DataSource

        Dim Dv As New DataView(Dt)
        Dv.Sort = "SubFam, Genero, Clasificacion, Categoria"
        Dt = Dv.ToTable

        If Not IsNothing(Dt) Then
            Dim listado As New Listado_ParteSemanal(Dt, TxDesdeParte.Text, TxHastaParte.Text, TipoImpresion.Preliminar)
            listado.ImprimirListado()
        Else
            MsgBox("No hay datos que visualizar.")
        End If
    End Sub

End Class