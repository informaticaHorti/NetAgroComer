Public Class FrmCuadreKilos
    Inherits FrConsulta

    Dim Semanaspartes As New E_SemanasPartes(Idusuario, cn)
    Private Class stClaves_Kilos

        Public IdGenero As Integer = 0
        Public Genero As String = ""
        Public IdSubfa As Integer = 0
        Public SubFamilia As String = ""
        Public IdTipo As Integer = 0
        Public Tipo As String = ""
        Public IdCat As Integer = 0
        Public Cat As String = ""


        Public Sub New(ByVal IdSubFa As Integer, ByVal Subfamilia As String, ByVal IdGenero As Integer, ByVal Genero As String, _
                       ByVal IdTipo As Integer, ByVal Tipo As String, ByVal IdCat As Integer, ByVal Cat As String)
            Me.IdGenero = IdGenero
            Me.Genero = Genero
            Me.IdSubfa = IdSubFa
            Me.SubFamilia = Subfamilia
            Me.IdTipo = IdTipo
            Me.Tipo = Tipo
            Me.IdCat = IdCat
            Me.Cat = Cat
        End Sub

    End Class

    Private Class stDatos_Kilos

        Public Iniciales As Decimal = 0
        Public Entradas As Decimal = 0
        Public Salidas As Decimal = 0
        Public Finales As Decimal = 0
        Public Diferencia As Decimal = 0
        Public Porcentaje As Decimal = 0



        Public Sub New(ByVal Iniciales As Decimal, ByVal Entradas As Decimal, ByVal Salidas As Decimal, ByVal Finales As Decimal)

            Me.Iniciales = Iniciales
            Me.Entradas = Entradas
            Me.Salidas = Salidas
            Me.Finales = Finales

        End Sub

    End Class

    Dim AcumKilos As New Acumulador


    Dim _idsemana As Integer


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato_1, Semanaspartes.SEV_Semana, Lb1, True)

        AsociarControles(TxDato_1, BtBuscaAlbaran, Semanaspartes.btBusca, Semanaspartes)
        LbCampa.Text = MiMaletin.IdCentro.ToString
        cbCentro = ComboCentro(cbCentro, MiMaletin.IdCentro)

    End Sub

    Private Sub TxDato_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato_1.TextChanged

    End Sub

    Private Sub TxDato_1_Valida(ByVal edicion As Boolean) Handles TxDato_1.Valida
        Dim id As Integer = Semanaspartes.LeerSemana(MiMaletin.Ejercicio, VaInt(TxDato_1.Text))
        _idsemana = id
        If id > 0 Then
            If Semanaspartes.LeerId(id) = True Then
                LbDesdeFechaSal.Text = Semanaspartes.SEV_FechaInicialSalida.Valor
                LbHastaFechaSal.Text = Semanaspartes.SEV_FechaFinalSalida.Valor
                LbDfechaEnt.Text = Semanaspartes.SEV_FechaInicialEntrada.Valor
                LbHFechaEnt.Text = Semanaspartes.SEV_FechaFinalEntrada.Valor

            End If

        End If
    End Sub

    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


        LbDesdeFechaSal.Text = ""
        LbHastaFechaSal.Text = ""
        LbCampa.Text = MiMaletin.Ejercicio.ToString
    End Sub

    Public Overrides Sub Consultar()
        MyBase.Consultar()


        AcumKilos.Borrar()


        CargaKilosEntrada()
        CargaKilosExistencias(True)
        CargaKilosExistencias(False)
        CargaKilosSalidas()


        Dim dt As DataTable = AcumKilos.DataTable
        For Each row As DataRow In dt.Rows

            Dim Iniciales As Decimal = VaDec(row("Iniciales"))
            Dim Entradas As Decimal = VaDec(row("Entradas"))
            Dim Salidas As Decimal = VaDec(row("Salidas"))
            Dim Finales As Decimal = VaDec(row("Finales"))

            Dim Diferencia As Decimal = Salidas + Finales - Iniciales - Entradas
            Dim Porcentaje As Decimal = 0
            If (Iniciales + Entradas) <> 0 Then Porcentaje = Diferencia / (Iniciales + Entradas) * 100

            row("Diferencia") = Diferencia
            row("Porcentaje") = Porcentaje

        Next


        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                Dim dv As New DataView(dt)
                dv.Sort = "IdSubFa, IdGenero, IdTipo, IdCat"
                dt = dv.ToTable
            End If
        End If


        Grid.DataSource = dt

        AjustaColumnas()

        AñadeResumenCampo("Iniciales", "{0:n0}")
        AñadeResumenCampo("Finales", "{0:n0}")
        AñadeResumenCampo("Entradas", "{0:n0}")
        AñadeResumenCampo("Salidas", "{0:n0}")
        AñadeResumenCampo("Diferencia", "{0:n0}")

    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDTIPO"
                    c.Visible = False
                Case "IDCAT", "CAT"
                    If ChkMostrarCategorias.Checked Then
                        c.Visible = True
                    Else
                        c.Visible = False
                    End If

            End Select
        Next

        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "INICIALES", "ENTRADAS", "SALIDAS", "FINALES", "DIFERENCIA"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                Case "PORCENTAJE"
                    c.Caption = "%"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.Width = 50
            End Select
        Next


    End Sub


    Private Sub CargaKilosExistencias(ByVal Inicial As Boolean)

        Dim ParteExistencias As New E_ParteExistencias(Idusuario, cn)
        Dim ParteExistenias_lineas As New E_ParteExistencias_lineas(Idusuario, cn)
        Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)
        Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
        Dim TiposdeCategoria As New E_TiposdeCategoria(Idusuario, cn)
        Dim SubFamilias As New E_Subfamilias(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)

        Dim consulta As New Cdatos.E_select

        consulta.SelCampo(ParteExistenias_lineas.PSL_idgenero, "idgenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", ParteExistenias_lineas.PSL_idgenero)
        consulta.SelCampo(Generos.GEN_IdsubFamilia, "idsub")
        consulta.SelCampo(SubFamilias.SFA_nombre, "Subfamilia", Generos.GEN_IdsubFamilia)
        consulta.SelCampo(CategoriasEntrada.CAE_Id, "Cat", ParteExistenias_lineas.PSL_idcategoria)
        consulta.SelCampo(CategoriasEntrada.CAE_CategoriaCalibre, "Categoria")
        consulta.SelCampo(CategoriasEntrada.CAE_IdTipoCategoria, "IdTipo")
        consulta.SelCampo(TiposdeCategoria.TCA_Abreviatura, "Tipo", CategoriasEntrada.CAE_IdTipoCategoria)
        consulta.SelCampo(ParteExistenias_lineas.PSL_kilos, "Kilos")

        If Inicial = True Then
            consulta.SelCampo(ParteExistencias.PSM_fechainicial, "Fecha", ParteExistenias_lineas.PSL_idparte)
            consulta.WheCampo(ParteExistencias.PSM_fechainicial, "=", LbDesdeFechaSal.Text)
        Else
            consulta.SelCampo(ParteExistencias.PSM_fechafinal, "Fecha", ParteExistenias_lineas.PSL_idparte)
            consulta.WheCampo(ParteExistencias.PSM_fechafinal, "=", LbHastaFechaSal.Text)

        End If

        Dim sql As String = consulta.SQL

        sql = sql & CadenaWhereLista(ParteExistencias.PSM_idcentro, ListadeCombo(cbCentro), " AND ") & vbCrLf
        sql = sql & " ORDER BY GEN_IdSubFamilia, PSL_IdGenero, CAE_IdTipoCategoria" & vbCrLf


        Dim dt As DataTable = ParteExistencias.MiConexion.ConsultaSQL(sql)

        For Each rw In dt.Rows

            Dim IdGenero As Integer = VaInt(rw("idgenero"))
            Dim IdSub As Integer = VaInt(rw("Idsub"))
            Dim IdTipo As Integer = VaInt(rw("IdTipo"))
            Dim Tipo As String = rw("tipo").ToString
            Dim Kilos As Decimal = VaDec(rw("kilos"))
            Dim Genero As String = rw("Genero").ToString
            Dim Subfamilia As String = rw("Subfamilia").ToString
            Dim IdCat As Integer = VaInt(rw("Cat"))
            Dim Cat As String = rw("Categoria").ToString

            If Not ChkMostrarCategorias.Checked Then
                IdCat = 0
                Cat = ""
            End If

            Dim stClave As New stClaves_Kilos(IdSub, Subfamilia, IdGenero, Genero, IdTipo, Tipo, IdCat, Cat)
            If Inicial = True Then
                Dim stDatos As New stDatos_Kilos(Kilos, 0, 0, 0)
                AcumKilos.Suma(stClave, stDatos)

            Else
                Dim stDatos As New stDatos_Kilos(0, 0, 0, Kilos)
                AcumKilos.Suma(stClave, stDatos)

            End If

        Next


    End Sub

    Private Sub CargaKilosSalidas()
        Dim albsalida As New E_AlbSalida(Idusuario, cn)
        Dim albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
        Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)
        Dim CategoriasSalida As New E_CategoriasSalida(Idusuario, cn)
        Dim TiposdeCategoria As New E_TiposdeCategoria(Idusuario, cn)
        Dim SubFamilias As New E_Subfamilias(Idusuario, cn)


        Dim Generos As New E_Generos(Idusuario, cn)
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(albsalida_lineas.ASL_idgenero, "idgenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", albsalida_lineas.ASL_idgenero)
        consulta.SelCampo(Generos.GEN_IdsubFamilia, "idsub")
        consulta.SelCampo(SubFamilias.SFA_nombre, "Subfamilia", Generos.GEN_IdsubFamilia)
        consulta.SelCampo(CategoriasSalida.CAS_IdCategoriaEntrada, "Cat", albsalida_lineas.ASL_idcategoria)
        consulta.SelCampo(CategoriasEntrada.CAE_CategoriaCalibre, "Categoria", CategoriasSalida.CAS_IdCategoriaEntrada)
        consulta.SelCampo(CategoriasEntrada.CAE_IdTipoCategoria, "IdTipo")
        consulta.SelCampo(TiposdeCategoria.TCA_Abreviatura, "Tipo", CategoriasEntrada.CAE_IdTipoCategoria)
        consulta.SelCampo(albsalida_lineas.ASL_kilosnetos, "Kilos")
        consulta.SelCampo(albsalida.ASA_fechasalida, "Fecha", albsalida_lineas.ASL_idalbaran)
        consulta.WheCampo(albsalida.ASA_fechasalida, ">=", LbDesdeFechaSal.Text)
        consulta.WheCampo(albsalida.ASA_fechasalida, "<=", LbHastaFechaSal.Text)
        Dim sql As String = consulta.SQL

        sql = sql + CadenaWhereLista(albsalida.ASA_idcentro, ListadeCombo(cbCentro), " AND ")


        Dim dt As DataTable = albsalida_lineas.MiConexion.ConsultaSQL(sql)

        For Each rw In dt.Rows

            Dim IdGenero As Integer = VaInt(rw("idgenero"))
            Dim IdSub As Integer = VaInt(rw("Idsub"))
            Dim IdTipo As Integer = VaInt(rw("IdTipo"))
            Dim Tipo As String = rw("tipo").ToString
            Dim Kilos As Decimal = VaDec(rw("kilos"))
            Dim Genero As String = rw("Genero").ToString
            Dim Subfamilia As String = rw("Subfamilia").ToString
            Dim IdCat As Integer = VaInt(rw("Cat"))
            Dim Cat As String = rw("Categoria").ToString

            If Not ChkMostrarCategorias.Checked Then
                IdCat = 0
                Cat = ""
            End If

            Dim stClave As New stClaves_Kilos(IdSub, Subfamilia, IdGenero, Genero, IdTipo, Tipo, IdCat, Cat)
            Dim stDatos As New stDatos_Kilos(0, 0, Kilos, 0)
            AcumKilos.Suma(stClave, stDatos)

        Next

    End Sub

 

 
 

    Private Sub CargaKilosEntrada()

        Dim albentrada As New E_AlbEntrada(Idusuario, cn)
        Dim albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
        Dim albentrada_hislineas As New E_AlbEntrada_hislineas(Idusuario, cn)
        Dim CategoriasEntrada As New E_CategoriasEntrada(Idusuario, cn)
        Dim TiposdeCategoria As New E_TiposdeCategoria(Idusuario, cn)
        Dim SubFamilias As New E_Subfamilias(Idusuario, cn)


        Dim Generos As New E_Generos(Idusuario, cn)
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(albentrada_hislineas.AHL_idgenero, "idgenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", albentrada_hislineas.AHL_idgenero)
        consulta.SelCampo(Generos.GEN_IdsubFamilia, "idsub")
        consulta.SelCampo(SubFamilias.SFA_nombre, "Subfamilia", Generos.GEN_IdsubFamilia)
        consulta.SelCampo(CategoriasEntrada.CAE_Id, "Cat", albentrada_hislineas.AHL_idcategoria)
        consulta.SelCampo(CategoriasEntrada.CAE_CategoriaCalibre, "Categoria")
        consulta.SelCampo(CategoriasEntrada.CAE_IdTipoCategoria, "IdTipo")
        consulta.SelCampo(TiposdeCategoria.TCA_Abreviatura, "Tipo", CategoriasEntrada.CAE_IdTipoCategoria)
        consulta.SelCampo(albentrada_hislineas.AHL_kilos, "Kilos")
        consulta.SelCampo(albentrada.AEN_Fecha, "Fecha", albentrada_hislineas.AHL_idalbaran)
        consulta.WheCampo(albentrada.AEN_Fecha, ">=", LbDfechaEnt.Text)
        consulta.WheCampo(albentrada.AEN_Fecha, "<=", LbHFechaEnt.Text)

        Dim sql As String = consulta.SQL

        sql = sql + CadenaWhereLista(albentrada.AEN_IdCentro, ListadeCombo(cbCentro), " AND ")


        Dim dt As DataTable = albentrada.MiConexion.ConsultaSQL(sql)

        For Each rw In dt.Rows

            Dim IdGenero As Integer = VaInt(rw("idgenero"))
            Dim IdSub As Integer = VaInt(rw("Idsub"))
            Dim IdTipo As Integer = VaInt(rw("IdTipo"))
            Dim Tipo As String = rw("tipo").ToString
            Dim Kilos As Decimal = VaDec(rw("kilos"))
            Dim Genero As String = rw("Genero").ToString
            Dim Subfamilia As String = rw("Subfamilia").ToString
            Dim IdCat As Integer = VaInt(rw("Cat"))
            Dim Cat As String = rw("Categoria").ToString

            If Not ChkMostrarCategorias.Checked Then
                IdCat = 0
                Cat = ""
            End If

            Dim stClave As New stClaves_Kilos(IdSub, Subfamilia, IdGenero, Genero, IdTipo, Tipo, IdCat, Cat)
            Dim stDatos As New stDatos_Kilos(0, Kilos, 0, 0)
            AcumKilos.Suma(stClave, stDatos)

        Next

    End Sub
 
    Public Overrides Sub Informe()
        MyBase.Informe()

        Dim Dt As DataTable = Grid.DataSource

        Dim Dv As New DataView(Dt)
        Dv.Sort = "IdSubfa, IdGenero, IdTipo, IdCat"

        Dim Semana As String = TxDato_1.Text.ToString

        If Not IsNothing(Dt) Then

            Dim lstCentros As List(Of String) = ListadeCombo(cbCentro)

            Dim Listado As New Listado_ImprimirInformeCuadreKilos(Dt, Semana, lstCentros, ChkMostrarCategorias.Checked, TipoImpresion.Preliminar)
            Listado.ImprimirListado()

        Else
            MsgBox("No hay elementos que mostrar")
        End If

    End Sub


End Class