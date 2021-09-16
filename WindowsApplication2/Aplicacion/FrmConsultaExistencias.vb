Imports DevExpress.XtraEditors.Controls

Public Class FrmConsultaExistencias
    Inherits FrConsulta


    Dim Produccion As New E_Produccion(Idusuario, cn)
    Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Dim Lotes As New E_Lotes(Idusuario, cn)
    Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim pventausuario As New E_PventaUsuario(Idusuario, cn)
    Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)




    Private Class stClaves_Existencias

        Public Producto As String
        Public Calidad As String
        Public Categoria As String
        Public Color As String
        Public GP As String
        Public Almacen As Integer
        Public Dias As Integer
        Public Precalibrado As String

        Public Sub New(Producto As String, Calidad As String, Categoria As String, Color As String, GP As String, Almacen As Integer, Dias As Integer, Precalibrado As String)
            Me.Producto = Producto
            Me.Calidad = Calidad
            Me.Categoria = Categoria
            Me.Color = Color
            Me.GP = GP
            Me.Almacen = Almacen
            Me.Dias = Dias
            Me.Precalibrado = Precalibrado
        End Sub

    End Class

    Private Class stDatos_Existencias

        Public Kilos As Decimal = 0

        Public Sub New(Kilos As Decimal)
            Me.Kilos = Kilos
        End Sub

    End Class



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()


        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc


        Dim sql As String = "SELECT GEN_IdGenero as Id, GEN_NombreGenero as Nombre FROM Generos"

        Dim dt As DataTable = cn.ConsultaSQL(sql)

        CbGeneros.Properties.DataSource = dt
        CbGeneros.Properties.ValueMember = "Id"
        CbGeneros.Properties.DisplayMember = "Nombre"

        ParamTx(TxDesdeFechaEntrada, AlbEntrada.AEN_Fecha, LbDesdeFechaEntrada)


    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridViewPartidas.Appearance.GroupRow.Font
        Dim Fuente_titulo As New Font("Verdana", 10, FontStyle.Bold)
        GridViewPartidas.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        GridViewPartidas.Appearance.HeaderPanel.BackColor = Color.Aquamarine
        GridViewLotes.Appearance.HeaderPanel.BackColor = Color.SkyBlue
        GridViewPrecalibrado.Appearance.HeaderPanel.BackColor = Color.NavajoWhite

        GridViewPartidas.OptionsBehavior.Editable = False
        GridViewLotes.OptionsBehavior.Editable = False
        GridViewPrecalibrado.OptionsBehavior.Editable = False
        GridViewResumen.OptionsBehavior.Editable = False

        GridViewPartidas.OptionsView.ShowViewCaption = True
        GridViewLotes.OptionsView.ShowViewCaption = True
        GridViewPartidas.ViewCaption = "PARTIDAS"
        GridViewLotes.ViewCaption = "LOTES"

        GridViewPartidas.Appearance.ViewCaption.ForeColor = Color.Blue
        GridViewPartidas.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(224, 224, 224)
        GridViewPartidas.Appearance.ViewCaption.Font = Fuente_titulo
        GridViewPartidas.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        GridViewLotes.Appearance.ViewCaption.ForeColor = Color.Blue
        GridViewLotes.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(224, 224, 224)
        GridViewLotes.Appearance.ViewCaption.Font = Fuente_titulo
        GridViewLotes.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        GridViewPartidas.OptionsPrint.PrintDetails = True
        GridViewPartidas.OptionsPrint.ExpandAllDetails = False
        GridViewPartidas.OptionsPrint.ExpandAllGroups = False
        GridViewLotes.OptionsPrint.PrintDetails = True
        GridViewLotes.OptionsPrint.ExpandAllDetails = False
        GridViewLotes.OptionsPrint.ExpandAllGroups = False
        GridViewPrecalibrado.OptionsPrint.PrintDetails = True
        GridViewPrecalibrado.OptionsPrint.ExpandAllDetails = False
        GridViewPrecalibrado.OptionsPrint.ExpandAllGroups = False
        GridViewResumen.OptionsPrint.PrintDetails = True
        GridViewResumen.OptionsPrint.ExpandAllDetails = False
        GridViewResumen.OptionsPrint.ExpandAllGroups = False

        CbPventa = ComboPuntoventa(CbPventa, MiMaletin.IdPuntoVenta)




        Dim dtNormas As DataTable = ObtenerTablaNormasCalidad()
        Dim fila As DataRow = dtNormas.NewRow()
        fila("Id") = "00"
        fila("Nombre") = ""
        dtNormas.Rows.InsertAt(fila, 0)

        CbNormas.Properties.DataSource = dtNormas
        CbNormas.Properties.DisplayMember = "Nombre"
        CbNormas.Properties.ValueMember = "Id"



        BInforme.Visible = False
        BImprimir.Visible = True


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()


    End Sub

    Public Overrides Sub Consultar()
        MyBase.Consultar()


        GridViewPartidas.Columns.Clear()

        Dim lstPventa As List(Of String) = ListadeCombo(CbPventa)
        Dim lstGeneros As List(Of String) = ListadeCombo(CbGeneros)
        Dim lstNormas As List(Of String) = ListadeCombo(CbNormas)
        Dim acum As New Acumulador


        If Not rbNOMuestreadas.Checked Then
            If VaDate(TxDesdeFechaEntrada.Text) = VaDate("") Then
                MsgBox("Debe indicar una fecha de entrada desde la que consultar para las partidas muestreadas")
                Exit Sub
            End If
        End If



        'Partidas
        Dim sql1 As String = "SELECT IdAlbaran, Albaran, Partida, Alm, Producto, Color, Cal," & vbCrLf
        If chkMostrarAgricultorYCultivo.Checked Or lstNormas.Count > 0 Then
            sql1 = sql1 & " CodAgr,Agricultor, Cultivo, IdProgramaCalidad, Programa, '' as ListaNormas," & vbCrLf
        End If
        sql1 = sql1 & " CP, Variedad, Con as Controlado, Fecha, DATEDIFF(day, Fecha, GETDATE()) as Dias," & vbCrLf
        sql1 = sql1 & " KilosPartida, KilosEnLotes, KilosConsumidos," & vbCrLf
        sql1 = sql1 & " COALESCE(KilosPartida,0) - COALESCE(KilosEnLotes,0) - COALESCE(KilosConsumidos,0) as Neto," & vbCrLf
        sql1 = sql1 & " TCE_IdCentroOrigen as Origen, TCE_Numero as Traspaso, TCE_Matricula as Matricula" & vbCrLf
        sql1 = sql1 & " FROM" & vbCrLf
        sql1 = sql1 & " (" & vbCrLf
        sql1 = sql1 & " SELECT AEN_IdAlbaran as IdAlbaran, AEN_Albaran as Albaran, AEL_Muestreo as Partida, AEL_IdUbicacionPV as Alm, AEL_Calidad as Cal," & vbCrLf
        sql1 = sql1 & " AEN_idAgricultor as CodAgr,AGR_Nombre as Agricultor,AEL_IdCultivo as Cultivo, AEL_IdPrograma as IdProgramaCalidad, AEL_Calidad as programa, AEL_ControlPresuntivoMP as CP," & vbCrLf
        'sql1 = sql1 & " (SELECT (SELECT RTRIM(variedades.nombre) FROM TecnicosSQL.dbo.variedades WHERE cdcultivo=CL.cdgenero and cdvariedad=CL.cdvariedad) as Variedad FROM TecnicosSql.dbo.cultivos_lineas CL WHERE CL.idcultivo = AEL_IdCultivo AND CL.cdcampa = AEL_CampaCultivo ) AS Variedad," & vbCrLf
        sql1 = sql1 & " (SELECT VAR_Nombre FROM TecnicosNet.dbo.Variedades LEFT JOIN TecnicosNet.dbo.Cultivos ON CUL_IdVariedad = VAR_IdVariedad WHERE CUL_IdCultivo = AEL_IdCultivo) AS Variedad," & vbCrLf
        sql1 = sql1 & " AEL_Controlado as Con, GEN_NombreGenero as Producto, AEL_Color as Color," & vbCrLf
        sql1 = sql1 & " AEN_Fecha as Fecha, AEL_KilosNetos as KilosPartida," & vbCrLf
        sql1 = sql1 & " (SELECT SUM(LTL_Kilos) FROM Lotes_Lineas WHERE LTL_IdLineaEntrada = AEL_IdLinea) as KilosEnLotes," & vbCrLf
        sql1 = sql1 & " (SELECT SUM(PRD_KilosConsumidos) FROM Produccion WHERE PRD_IdLineaEntrada = AEL_IdLinea) as KilosConsumidos," & vbCrLf
        sql1 = sql1 & " (SELECT TOP 1 TLI_IdTraspaso FROM TraspasosCentros_Lineas WHERE TLI_Tipo = 'P' AND TLI_Codigo = AEL_IdLinea ORDER BY TLI_IdLinea DESC) as IdTraspaso" & vbCrLf
        sql1 = sql1 & " FROM AlbEntrada_Lineas" & vbCrLf
        sql1 = sql1 & " LEFT JOIN AlbEntrada ON AEN_IdAlbaran = AEL_IdAlbaran" & vbCrLf
        sql1 = sql1 & " LEFT JOIN Generos ON GEN_IdGenero = AEL_IdGenero " & vbCrLf
        sql1 = sql1 & " LEFT JOIN Agricultores ON AEN_IdAgricultor = AGR_IdAgricultor" & vbCrLf
        sql1 = sql1 & " WHERE AEN_entradaconfeccionada<>'S'"

        If RbSIMuestreadas.Checked Then
            'Sólo muestreadas
            sql1 = sql1 & " AND COALESCE(AEL_FechaMuestreo, '01/01/1900') > '01/01/1900'" & vbCrLf
            sql1 = sql1 & " AND AEN_Fecha >= '" & TxDesdeFechaEntrada.Text & "'" & vbCrLf
        ElseIf rbNOMuestreadas.Checked Then
            'Sólo NO muestreadas
            sql1 = sql1 & " AND COALESCE(AEL_FechaMuestreo, '01/01/1900') <= '01/01/1900'" & vbCrLf
        Else
            'Ambas, muestreadas y no muestreadas
            sql1 = sql1 & " AND (COALESCE(AEL_FechaMuestreo, '01/01/1900') <= '01/01/1900' OR (COALESCE(AEL_FechaMuestreo, '01/01/1900') > '01/01/1900' AND AEN_Fecha >= '" & TxDesdeFechaEntrada.Text & "'))" & vbCrLf
        End If

        sql1 = sql1 & CadenaWhereLista(AlbEntrada_Lineas.AEL_IdUbicacionPV, lstPventa, " AND ") & vbCrLf
        If lstGeneros.Count > 0 Then
            sql1 = sql1 & CadenaWhereLista(AlbEntrada_Lineas.AEL_idgenero, lstGeneros, " AND ")
        End If

        sql1 = sql1 & " ) as P" & vbCrLf
        sql1 = sql1 & " LEFT JOIN TraspasosCentros ON TCE_IdTraspaso = P.IdTraspaso" & vbCrLf
        sql1 = sql1 & " WHERE COALESCE(KilosPartida, 0) - COALESCE(KilosEnLotes, 0) - COALESCE(KilosConsumidos, 0) <> 0" & vbCrLf

        Dim dt1 As DataTable = Produccion.MiConexion.ConsultaSQL(sql1)

        If chkMostrarAgricultorYCultivo.Checked Or lstNormas.Count > 0 Then

            If Not IsNothing(dt1) Then
                For Each row As DataRow In dt1.Rows
                    If VaDec(row("cultivo")) > 0 Then
                        Dim idcultivo As Integer = VaInt(row("cultivo"))
                        Dim idagricultor As Integer = VaInt(row("codagr"))
                        Dim IdProgramaCalidad As String = (row("IdProgramaCalidad").ToString & "").Trim
                        Dim l1 As String = ""
                        Dim l2 As String = ""
                        Dim Normas As String = ""
                        'GGNBoletin("", idagricultor, idcultivo, l1, l2, Normas)
                        GGNBoletinPrograma(idagricultor, IdProgramaCalidad, l1, l2, Normas)
                        row("programa") = l1.Trim
                        row("ListaNormas") = Normas
                    End If

                Next
            End If
        End If

        GridViewPartidas.Columns.Clear()


        'Dim lstProgramas As New List(Of String) '= ListadeCombo(CbNormas, False)
        'If lstNormas.Count > 0 Then
        '    lstProgramas.Add(CbNormas.SelectedValue.ToString)
        'End If


        If lstNormas.Count > 0 Then
            Dim dv As New DataView(dt1)
            dv.RowFilter = CadenaWhereListaProgramas(AlbEntrada_Lineas.AEL_Calidad, lstNormas, "").Replace("AEL_Calidad", "ListaNormas")
            dt1 = dv.ToTable
        End If

        GridPartidas.DataSource = dt1
        AjustaColumnas(GridViewPartidas)





        'LOTES
        Dim sql2 As String = "SELECT Lote, Alm, Producto, IdProgramaCalidad, PCalidad, Color, Categoria, Cal, Con as Controlado, Fecha, DATEDIFF(day, Fecha, GETDATE()) as Dias," & vbCrLf
        sql2 = sql2 & " KilosLote, KilosConsumidos, COALESCE(KilosLote,0) - COALESCE(KilosConsumidos,0) as Neto," & vbCrLf
        sql2 = sql2 & " TCE_IdCentroOrigen as Origen, TCE_Numero as Traspaso, TCE_Matricula as Matricula, ListaNormas" & vbCrLf
        sql2 = sql2 & " FROM" & vbCrLf
        sql2 = sql2 & " (" & vbCrLf
        sql2 = sql2 & " SELECT LTE_Lote as Lote, LTE_IdUbicacionPV as Alm, GEN_NombreGenero as Producto, LTE_Color as Color, '' as Categoria," & vbCrLf
        sql2 = sql2 & " LTE_Calidad as Cal, LTE_Controlado as Con," & vbCrLf
        sql2 = sql2 & " LTE_Fechaproducto as Fecha, LTE_IdProgramaCalidad as IdProgramaCalidad, PCT_Nombre as PCalidad," & vbCrLf
        sql2 = sql2 & " (SELECT SUM(LTL_Kilos) FROM Lotes_Lineas WHERE LTL_IdLote = LTE_IdLote) as KilosLote," & vbCrLf
        sql2 = sql2 & " (SELECT SUM(PRD_KilosConsumidos) FROM Produccion WHERE PRD_IdLote = LTE_IdLote) as KilosConsumidos," & vbCrLf
        sql2 = sql2 & " (SELECT TOP 1 TLI_IdTraspaso FROM TraspasosCentros_Lineas WHERE TLI_Tipo = 'L' AND TLI_Codigo = LTE_IdLote ORDER BY TLI_IdLinea DESC) as IdTraspaso," & vbCrLf
        If EsTecnicosNet() Then
            sql2 = sql2 & "(SELECT DISTINCT CAST(CAN_IdNorma as nvarchar) + '|' FROM TecnicosNet.dbo.CalidadNorma WHERE CAN_IdPrograma = LTE_IdProgramaCalidad FOR XML PATH('')) as ListaNormas" & vbCrLf
        Else
            sql2 = sql2 & "(SELECT DISTINCT CAST(cdnorma as nvarchar) + '|' FROM TecnicosSql.dbo.calidad_norma WHERE cdprogcalidad = LTE_IdProgramaCalidad FOR XML PATH('')) as ListaNormas" & vbCrLf
        End If
        sql2 = sql2 & " FROM Lotes" & vbCrLf
        sql2 = sql2 & " LEFT JOIN Generos ON GEN_IdGenero = LTE_IdGenero" & vbCrLf
        sql2 = sql2 & " LEFT JOIN ProgramaCalidadTecnicos ON PCT_Idprograma = LTE_IdProgramaCalidad" & vbCrLf
        If lstGeneros.Count > 0 Then
            sql2 = sql2 & CadenaWhereLista(Lotes.LTE_Idgenero, lstGeneros, " WHERE ")
            sql2 = sql2 & CadenaWhereLista(Lotes.LTE_IdUbicacionPV, lstPventa, " AND ") & vbCrLf
        Else
            sql2 = sql2 & CadenaWhereLista(Lotes.LTE_IdUbicacionPV, lstPventa, " WHERE ") & vbCrLf
        End If
        sql2 = sql2 & " ) as L" & vbCrLf
        sql2 = sql2 & " LEFT JOIN TraspasosCentros ON TCE_IdTraspaso = L.IdTraspaso" & vbCrLf
        sql2 = sql2 & " WHERE COALESCE(KilosLote,0) - COALESCE(KilosConsumidos,0) <> 0" & vbCrLf

        Dim dt2 As DataTable = Produccion.MiConexion.ConsultaSQL(sql2)

        'If (chkMostrarAgricultorYCultivo.Checked Or lstNormas.Count) And Not EsTecnicosNet() > 0 Then
        '    If Not IsNothing(dt2) Then
        '        For Each row As DataRow In dt2.Rows
        '            If VaDec(row("IdProgramaCalidad")) > 0 Then
        '                Dim IdProgramaCalidad As String = (row("IdProgramaCalidad").ToString & "").Trim
        '                'Dim idagricultor As Integer = VaInt(row("codagr"))
        '                Dim l1 As String = ""
        '                Dim l2 As String = ""
        '                Dim Normas As String = ""

        '                'Sólo nos interesan las normas, no hace falta agricultor
        '                GGNBoletinPrograma(0, IdProgramaCalidad, l1, l2, Normas)
        '                row("ListaNormas") = Normas
        '            End If

        '        Next
        '    End If
        'End If

        If lstNormas.Count > 0 Then
            Dim dv As New DataView(dt2)
            dv.RowFilter = CadenaWhereListaProgramas(Lotes.LTE_IdProgramaCalidad, lstNormas, "").Replace("LTE_IdProgramaCalidad", "ListaNormas")
            dt2 = dv.ToTable
        End If

        GridLotes.DataSource = dt2
        AjustaColumnas(GridViewLotes)





        'PRECALIBRADOS
        Dim sql3 As String = "SELECT Lote, Alm, Producto, IdProgramaCalidad, PCalidad, Color, Categoria, Cal, GP, Con as Controlado, Fecha, DATEDIFF(day, Fecha, GETDATE()) as Dias," & vbCrLf
        sql3 = sql3 & " KilosLote, KilosConsumidos, COALESCE(KilosLote,0) - COALESCE(KilosConsumidos,0) as Neto," & vbCrLf
        sql3 = sql3 & " TCE_IdCentroOrigen as Origen, TCE_Numero as Traspaso, TCE_Matricula as Matricula, ListaNormas" & vbCrLf
        sql3 = sql3 & " FROM" & vbCrLf
        sql3 = sql3 & " (" & vbCrLf
        sql3 = sql3 & " SELECT LPD_Lote as Lote, LPD_IdUbicacionPV as Alm, GEN_NombreGenero as Producto, LPD_Color as Color, CAS_CategoriaCalibre as Categoria," & vbCrLf
        sql3 = sql3 & " LPD_GP as GP, LPD_Calidad as Cal, LPD_Controlado as Con," & vbCrLf
        sql3 = sql3 & " LPD_Fechaproducto as Fecha, LPD_IdProgramaCalidad as IdProgramaCalidad, PCT_Nombre as PCalidad," & vbCrLf
        sql3 = sql3 & " (SELECT SUM(LPL_Kilos) FROM LotesProduccion_Lineas WHERE LPL_IdLote = LPD_IdLote) as KilosLote," & vbCrLf
        sql3 = sql3 & " (SELECT SUM(PRD_KilosConsumidos) FROM Produccion WHERE PRD_IdLoteProduccion = LPD_IdLote) as KilosConsumidos," & vbCrLf
        sql3 = sql3 & " (SELECT TOP 1 TLI_IdTraspaso FROM TraspasosCentros_Lineas WHERE TLI_Tipo = 'C' AND TLI_Codigo = LPD_IdLote ORDER BY TLI_IdLinea DESC) as IdTraspaso," & vbCrLf
        If EsTecnicosNet() Then
            sql3 = sql3 & "(SELECT DISTINCT CAST(CAN_IdNorma as nvarchar) + '|' FROM TecnicosNet.dbo.CalidadNorma WHERE CAN_IdPrograma = LPD_IdProgramaCalidad FOR XML PATH('')) as ListaNormas" & vbCrLf
        Else
            sql3 = sql3 & "(SELECT DISTINCT CAST(cdnorma as nvarchar) + '|' FROM TecnicosSql.dbo.calidad_norma WHERE cdprogcalidad = LPD_IdProgramaCalidad FOR XML PATH('')) as ListaNormas" & vbCrLf
        End If
        sql3 = sql3 & " FROM LotesProduccion" & vbCrLf
        sql3 = sql3 & " LEFT JOIN Generos ON GEN_IdGenero = LPD_IdGenero" & vbCrLf
        sql3 = sql3 & " LEFT JOIN CategoriasSalida ON CAS_Id = LPD_IdCategoria" & vbCrLf
        sql3 = sql3 & " LEFT JOIN ProgramaCalidadTecnicos ON PCT_Idprograma = LPD_IdProgramaCalidad" & vbCrLf
        If lstGeneros.Count > 0 Then
            sql3 = sql3 & CadenaWhereLista(LotesProduccion.LPD_Idgenero, lstGeneros, " WHERE ")
            sql3 = sql3 & CadenaWhereLista(LotesProduccion.LPD_IdUbicacionPV, lstPventa, " AND ") & vbCrLf
        Else
            sql3 = sql3 & CadenaWhereLista(LotesProduccion.LPD_IdUbicacionPV, lstPventa, " WHERE ") & vbCrLf
        End If
        sql3 = sql3 & " ) as C" & vbCrLf
        sql3 = sql3 & " LEFT JOIN TraspasosCentros ON TCE_IdTraspaso = C.IdTraspaso" & vbCrLf
        sql3 = sql3 & " WHERE COALESCE(KilosLote,0) - COALESCE(KilosConsumidos,0) <> 0" & vbCrLf

        Dim dt3 As DataTable = Produccion.MiConexion.ConsultaSQL(sql3)

        'If (chkMostrarAgricultorYCultivo.Checked Or lstNormas.Count) And Not EsTecnicosNet() > 0 Then
        '    If Not IsNothing(dt3) Then
        '        For Each row As DataRow In dt3.Rows
        '            If VaDec(row("IdProgramaCalidad")) > 0 Then
        '                Dim IdProgramaCalidad As String = (row("IdProgramaCalidad").ToString & "").Trim
        '                'Dim idagricultor As Integer = VaInt(row("codagr"))
        '                Dim l1 As String = ""
        '                Dim l2 As String = ""
        '                Dim Normas As String = ""

        '                'Sólo nos interesan las normas, no hace falta agricultor
        '                GGNBoletinPrograma(0, IdProgramaCalidad, l1, l2, Normas)
        '                row("ListaNormas") = Normas
        '            End If

        '        Next
        '    End If
        'End If

        If lstNormas.Count > 0 Then
            Dim dv As New DataView(dt3)
            dv.RowFilter = CadenaWhereListaProgramas(LotesProduccion.LPD_IdProgramaCalidad, lstNormas, "").Replace("LPD_IdProgramaCalidad", "ListaNormas")
            dt3 = dv.ToTable
        End If

        GridPrecalibrado.DataSource = dt3
        AjustaColumnas(GridViewPrecalibrado)



        acum.Borrar()
        For Each rw In dt1.Rows
            Dim Producto As String = rw("producto").ToString
            Dim Calidad As String = rw("cal").ToString
            Dim Color As String = rw("color").ToString
            Dim Almacen As Integer = VaInt(rw("alm"))
            Dim Dias As Integer = VaInt(rw("dias"))
            Dim Kilos As Decimal = VaDec(rw("neto"))
            Dim clave As New stClaves_Existencias(Producto, Calidad, "", Color, "", Almacen, Dias, "SIN CONFECCIONAR")
            Dim datos As New stDatos_Existencias(Kilos)

            acum.Suma(clave, datos)

        Next

        For Each rw In dt2.Rows
            Dim Producto As String = rw("producto").ToString
            Dim Calidad As String = rw("cal").ToString
            Dim Categoria As String = rw("categoria").ToString
            Dim Color As String = rw("color").ToString
            Dim Almacen As Integer = VaInt(rw("alm"))
            Dim Dias As Integer = VaInt(rw("dias"))
            Dim Kilos As Decimal = VaDec(rw("neto"))
            Dim clave As New stClaves_Existencias(Producto, Calidad, Categoria, Color, "", Almacen, Dias, "SIN CONFECCIONAR")
            Dim datos As New stDatos_Existencias(Kilos)

            acum.Suma(clave, datos)

        Next

        For Each rw In dt3.Rows
            Dim Producto As String = rw("producto").ToString
            Dim Calidad As String = rw("cal").ToString
            Dim Categoria As String = rw("categoria").ToString
            Dim Color As String = rw("color").ToString
            Dim Almacen As Integer = VaInt(rw("alm"))
            Dim Dias As Integer = VaInt(rw("dias"))
            Dim Kilos As Decimal = VaDec(rw("neto"))
            Dim GP As String = (rw("GP").ToString & "").Trim
            Dim clave As New stClaves_Existencias(Producto, Calidad, Categoria, Color, GP, Almacen, Dias, "SEMITERMINADO")
            Dim datos As New stDatos_Existencias(Kilos)

            acum.Suma(clave, datos)

        Next


        Dim dtResumen As DataTable = acum.DataTable


        GridResumen.DataSource = acum.DataTable
        AjustaColumnas(GridViewResumen)

    End Sub


    Public Function CadenaWhereListaProgramas(ByVal campoClave As Cdatos.bdcampo, ByVal LST As List(Of String), Optional ByVal Prefijo As String = "") As String

        Dim resultado As String = ""
        Dim ntabla As String = ""


        If Not LST Is Nothing Then
            For i As Integer = 0 To LST.Count - 1
                If LST(i) <> "" Then
                    If i = 0 Then
                        Select Case campoClave.TipoBd
                            Case Else
                                'resultado = ntabla & campoClave.NombreCampo & " LIKE '*" & LST(i).Trim & "|*' "
                                resultado = ntabla & campoClave.NombreCampo & " LIKE '" & LST(i).Trim & "|*' OR " & ntabla & campoClave.NombreCampo & " LIKE '*|" & LST(i).Trim & "|*'"
                        End Select
                    Else
                        Select Case campoClave.TipoBd
                            Case Else
                                'resultado = resultado & " OR " & ntabla & campoClave.NombreCampo & " LIKE '*" & LST(i).Trim & "|*' "
                                resultado = resultado & " OR " & ntabla & campoClave.NombreCampo & " LIKE '" & LST(i).Trim & "|*' OR " & ntabla & campoClave.NombreCampo & " LIKE '*|" & LST(i).Trim & "|*'"
                        End Select
                    End If
                End If
            Next
        End If

        If resultado <> "" Then
            resultado = Prefijo + " ( " + resultado + " )"
        End If

        Return resultado

    End Function


    Private Sub AjustaColumnas(gridview As DevExpress.XtraGrid.Views.Grid.GridView)

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In gridview.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "LISTANORMAS", "IDALBARAN", "IDPROGRAMACALIDAD"
                    c.Visible = False
            End Select
        Next

        gridview.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In gridview.Columns
            Select Case c.FieldName.ToUpper.Trim

                Case "PARTIDA", "LOTE", "ALBARAN", "VARIEDAD", "PROGRAMA"

                    c.MinWidth = 75
                    c.MaxWidth = 75
                Case "PRODUCTO", "AGRICULTOR"
                    c.Width = 200

                Case "FECHA"
                    c.MinWidth = 75
                    c.MaxWidth = 75
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                Case "DIAS", "CODAGR", "CULTIVO"
                    c.MinWidth = 60
                    c.MaxWidth = 60
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"

                Case "KILOSPARTIDA", "KILOSLOTE", "KILOSCONSUMIDOS", "KILOSENLOTES", "KILOS"
                    c.MinWidth = 80
                    c.MaxWidth = 80
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    Funciones.AñadeResumenCampo(gridview, c.FieldName, "{0:n0}")

                Case "NETO"
                    c.Caption = "Existencias"
                    c.MinWidth = 80
                    c.MaxWidth = 80
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0"
                    Funciones.AñadeResumenCampo(gridview, c.FieldName, "{0:n0}")

                Case "PRE"
                    c.MinWidth = 35
                    c.MaxWidth = 35
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                Case "PRECALIBRADO"
                    c.Caption = "Tipo"
                    c.MinWidth = 150
                    c.MaxWidth = 150
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                Case "CALIDAD", "ALMACEN", "CATEGORIA", "CONTROLADO"
                    c.MinWidth = 70
                    c.MaxWidth = 70
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                Case "CAL", "CONTROL", "ALM"
                    c.MinWidth = 30
                    c.MaxWidth = 30
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                Case "COLOR"
                    c.MinWidth = 45
                    c.MaxWidth = 45
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

                Case "GP"
                    c.MinWidth = 30
                    c.MaxWidth = 30
                    c.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    c.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            End Select

        Next

    End Sub

    

    'Private Sub btVerResumen_Click(sender As System.Object, e As System.EventArgs) Handles btVerResumen.Click

    '    Dim x As Integer = 0
    '    Dim y As Integer = 0

    '    x = btVerResumen.Location.X + btVerResumen.Size.Width - FrmResumenConsultaExistencias.Width - 8
    '    y = btVerResumen.Location.Y + btVerResumen.Size.Height + 74


    '    Dim frm As New FrmResumenConsultaExistencias(_dtResumen, x, y)
    '    frm.ShowDialog()


    'End Sub



    Private Sub GridViewPartidas_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles GridViewPartidas.KeyDown
        Me.TeclaFuncion(e.KeyCode, GridViewPartidas)
        e.Handled = True
    End Sub

    Private Sub GridViewLotes_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles GridViewLotes.KeyDown
        Me.TeclaFuncion(e.KeyCode, GridViewLotes)
        e.Handled = True
    End Sub

    Private Sub GridViewPrecalibrado_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles GridViewPrecalibrado.KeyDown
        Me.TeclaFuncion(e.KeyCode, GridViewPrecalibrado)
        e.Handled = True
    End Sub

    Private Sub GridViewResumen_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles GridViewResumen.KeyDown
        Me.TeclaFuncion(e.KeyCode, GridViewResumen)
        e.Handled = True
    End Sub


    Public Overrides Sub Imprimir()

        LineasDescripcion.Clear()
        LineasDescripcion.Add("")
        LineasDescripcion.Add("CONSULTA EXISTENCIAS: " & XtraTabControl1.SelectedTabPage.Text)

        Select Case XtraTabControl1.SelectedTabPageIndex

            Case 0

                'Partidas y Lotes
                ImprimirPartidasYLotes()
                
            Case 1
                'Precalibrado
                Dim informe As DevExpress.XtraPrinting.PrintableComponentLink = CType(prtSystem.Links(0), DevExpress.XtraPrinting.PrintableComponentLink)
                informe.Component = GridPrecalibrado
                Grid = GridPrecalibrado
                ImprimirGrid(GridPrecalibrado)

            Case 2
                'Resumen
                Dim informe As DevExpress.XtraPrinting.PrintableComponentLink = CType(prtSystem.Links(0), DevExpress.XtraPrinting.PrintableComponentLink)
                informe.Component = GridResumen
                Grid = GridResumen
                ImprimirGrid(GridResumen)

        End Select




    End Sub


    Private Sub CompositeLink_CreateInnerPageHeaderArea(sender As System.Object, e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles CompositeLink1.CreateDetailHeaderArea


        'Dim fuente_defecto As Font = e.Graph.Font
        'Dim c As System.Drawing.Color = Color.FromArgb(1, 70, 127)
        'Dim titulo As String = Me.Text
        ''Dim titulo2 As String = _Cuenta & " - " & _NombreCta
        'Dim xpos As Integer = 10
        'Dim al As DevExpress.Utils.HorzAlignment = DevExpress.Utils.HorzAlignment.Near

        'Try

        '    'Logo
        '    Dim ficheroLogo As String = Application.StartupPath & "\logo.png"
        '    If System.IO.File.Exists(ficheroLogo) Then
        '        Dim logo As Image = Image.FromFile(ficheroLogo)
        '        If Not IsNothing(logo) Then
        '            e.Graph.DrawImage(logo, New RectangleF(0, 0, logo.Width, logo.Height), DevExpress.XtraPrinting.BorderSide.None, Color.Transparent)
        '        End If

        '        xpos = 350
        '        al = DevExpress.Utils.HorzAlignment.Far
        '    Else

        '        e.Graph.Font = New Font("Arial", 15, FontStyle.Bold)
        '        Dim recf As New RectangleF(xpos, 10, 343, 25)
        '        Dim empresa As DevExpress.XtraPrinting.TextBrick = e.Graph.DrawString("COSTA DE ALMERÍA", c, recf, DevExpress.XtraPrinting.BorderSide.None)

        '    End If


        '    e.Graph.Font = New Font("Arial", 12, FontStyle.Bold)
        '    Dim rec As New RectangleF(xpos, 45, 600, 25)
        '    Dim brick As DevExpress.XtraPrinting.TextBrick = e.Graph.DrawString(titulo, c, rec, DevExpress.XtraPrinting.BorderSide.None)
        '    brick.HorzAlignment = DevExpress.Utils.HorzAlignment.Near

        '    'rec = New RectangleF(xpos, 65, 600, 25)
        '    'brick = e.Graph.DrawString(titulo2, c, rec, DevExpress.XtraPrinting.BorderSide.None)
        '    'brick.HorzAlignment = DevExpress.Utils.HorzAlignment.Near


        'Catch ex As Exception
        '    MsgBox("Error al imprimir zona cabecera: " & ex.Message)
        'End Try


        'e.Graph.Font = fuente_defecto


        Dim margen_izq_parametros As Integer = 10
        Dim base_parametros As Integer = 10

        Dim rec As RectangleF
        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Arial", 13, FontStyle.Bold)




        Dim s As New SizeF(0, 0)

        Try

            'Logo
            Try

                Dim fichero_logo As String = "logo.png"

                Select Case MiMaletin.IdEmpresaCTB
                    Case 1
                        fichero_logo = "logo.png"
                    Case Else
                        fichero_logo = "logo_" & MiMaletin.IdEmpresaCTB.ToString & ".png"
                End Select

                If IO.File.Exists(Application.StartupPath & "\" & fichero_logo) Then

                    Dim logo As Image = Image.FromFile(Application.StartupPath & "\" & fichero_logo)
                    rec = New RectangleF(0, 0, logo.Size.Width, logo.Size.Height)
                    e.Graph.DrawImage(logo, rec, DevExpress.XtraPrinting.BorderSide.None, Color.Transparent)
                    s = logo.Size

                    margen_izq_parametros = margen_izq_parametros + logo.Size.Width

                End If

            Catch ex As Exception

            End Try



            'Separación debajo del logo
            e.Graph.DrawEmptyBrick(New RectangleF(0, s.Height, e.Graph.ClientPageSize.Width, 10))

            'Línea debajo del logo
            Dim c As System.Drawing.Color = Color.FromArgb(1, 70, 127)

            Dim p1f As New PointF(0, s.Height + 5)
            Dim p2f As New PointF(e.Graph.ClientPageSize.Width, s.Height + 5)
            e.Graph.DrawLine(p1f, p2f, c, 1)

            Dim base As Single = p1f.Y + 10

            'Nombre del listado
            Dim nombrelistado As String = "LISTADO " & Grid.Text & " - " & Now.ToString("dd/MM/yyyy")
            If Me.Text.Trim <> "" Then nombrelistado = Me.Text & " - " & Now.ToString("dd/MM/yyyy")

            'Espacio en blanco debajo del nombre del listado
            rec = New RectangleF(0, base, e.Graph.ClientPageSize.Width, 25)
            e.Graph.DrawString(nombrelistado, c, rec, DevExpress.XtraPrinting.BorderSide.None)

            base = base + 25


            If LineasDescripcion.Count > 0 Then

                'e.Graph.Font = New Font("Arial", 11, FontStyle.Regular)

                'For Each linea As String In _LineasDescripcion

                '    rec = New RectangleF(0, base, e.Graph.ClientPageSize.Width, 20)
                '    e.Graph.DrawString(linea, c, rec, DevExpress.XtraPrinting.BorderSide.None)
                '    base = base + 20

                'Next




                e.Graph.Font = New Font("Arial", 9, FontStyle.Regular)


                Dim bp As Integer = base_parametros
                Dim alineacion As DevExpress.Utils.HorzAlignment = DevExpress.Utils.HorzAlignment.Near
                Dim ancho As Integer = e.Graph.ClientPageSize.Width - margen_izq_parametros - 5

                For indice As Integer = 0 To LineasDescripcion.Count - 1

                    If indice <= 12 Then

                        If indice = 6 Then
                            '2ª columna
                            ancho = ancho / 2
                            margen_izq_parametros = margen_izq_parametros + ancho
                            bp = base_parametros
                            alineacion = DevExpress.Utils.HorzAlignment.Far

                        End If

                        Dim linea As String = LineasDescripcion(indice)

                        rec = New RectangleF(margen_izq_parametros, bp, ancho, 20)
                        Dim tb As DevExpress.XtraPrinting.TextBrick = e.Graph.DrawString(linea, c, rec, DevExpress.XtraPrinting.BorderSide.None)
                        tb.HorzAlignment = alineacion
                        bp = bp + 15

                    End If


                Next



            End If


            'Último separador en blanco
            e.Graph.DrawEmptyBrick(New RectangleF(0, base, e.Graph.ClientPageSize.Width, 15))



        Catch ex As Exception


        End Try


    End Sub


    Private Sub ImprimirGrid(g As DevExpress.XtraGrid.GridControl)

        If IsNothing(g.DataSource) Then
            MsgBox("No hay datos que imprimir")
            Exit Sub
        Else

            Try

                Application.DoEvents()

                Dim dt As DataTable = CType(g.DataSource, DataTable)
                If dt.Rows.Count <= 0 Then
                    MsgBox("No hay datos que imprimir")
                    Exit Sub
                End If

                Application.DoEvents()

            Catch ex As Exception

            End Try

        End If


        Application.DoEvents()


        If g.IsPrintingAvailable Then

            Dim psu As New DevExpress.XtraPrinting.PrinterSettingsUsing
            psu.UsePaperKind = True
            psu.UseMargins = False

            prtSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            prtSystem.PageSettings.AssignDefaultPrinterSettings(psu)


            Dim bErrorMargen As Boolean = True
            Dim imprime As DevExpress.XtraPrinting.PrintableComponentLink = CType(prtSystem.Links(0), DevExpress.XtraPrinting.PrintableComponentLink)


            imprime.Margins.Top = 50
            imprime.Margins.Right = 50
            imprime.Margins.Bottom = 50
            imprime.Margins.Left = 50


            Application.DoEvents()

            imprime.ShowPreview()

            Application.DoEvents()

        End If

    End Sub


    Private Sub ImprimirPartidasYLotes()


        Try

            Application.DoEvents()

            Dim dt1 As DataTable = CType(GridPartidas.DataSource, DataTable)
            Dim dt2 As DataTable = CType(GridLotes.DataSource, DataTable)

            If dt1.Rows.Count <= 0 And dt2.Rows.Count <= 0 Then
                MsgBox("No hay datos que imprimir")
                Exit Sub
            End If

            Application.DoEvents()

        Catch ex As Exception

        End Try


        Application.DoEvents()


        If GridPartidas.IsPrintingAvailable And GridLotes.IsPrintingAvailable Then

            Dim psu As New DevExpress.XtraPrinting.PrinterSettingsUsing
            psu.UsePaperKind = True
            psu.UseMargins = False

            prtSystem2.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            prtSystem2.PageSettings.AssignDefaultPrinterSettings(psu)


            Dim bErrorMargen As Boolean = True
            Dim contenedor As DevExpress.XtraPrintingLinks.CompositeLink = CType(prtSystem2.Links(2), DevExpress.XtraPrintingLinks.CompositeLink)


            contenedor.Margins.Top = 50
            contenedor.Margins.Right = 50
            contenedor.Margins.Bottom = 50
            contenedor.Margins.Left = 50


            Application.DoEvents()

            contenedor.ShowPreview()

            Application.DoEvents()

        Else
            MsgBox("Error, una de las tablas no está disponible para imprimir")
        End If

    End Sub


   
    Private Sub GridViewPartidas_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridViewPartidas.RowCellStyle
        CustomizaCalidad(sender, e)
        CustomizaColorProducto(sender, e)
    End Sub

    Private Sub GridViewLotes_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridViewLotes.RowCellStyle
        CustomizaCalidad(sender, e)
        CustomizaColorProducto(sender, e)
    End Sub

    Private Sub GridViewPrecalibrado_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridViewPrecalibrado.RowCellStyle
        CustomizaCalidad(sender, e)
        CustomizaColorProducto(sender, e)
    End Sub

    Private Sub GridViewResumen_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridViewResumen.RowCellStyle
        CustomizaCalidad(sender, e)
        CustomizaColorProducto(sender, e)
    End Sub


    Private Sub CustomizaCalidad(gv As DevExpress.XtraGrid.Views.Grid.GridView, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)


        Dim row As DataRow = gv.GetDataRow(e.RowHandle)
        If Not IsNothing(row) Then

            If e.Column.FieldName.Trim.ToUpper = "CAL" Or e.Column.FieldName.Trim.ToUpper = "CALIDAD" Then

                If grid Is GridViewResumen Then
                    Dim a As String = ""
                End If

                Dim color As Color
                Dim forecolor As Color = Drawing.Color.Black

                Select Case (e.CellValue.ToString & "").Trim.ToUpper
                    Case "A"
                        color = color.FromArgb(92, 166, 68)
                    Case "B"
                        color = Drawing.Color.Gold
                    Case "C"
                        color = Drawing.Color.DarkOrange
                    Case "D"
                        color = Drawing.Color.Salmon
                    Case "E"
                        color = Drawing.Color.Red
                        forecolor = Drawing.Color.White
                    Case Is > "E"
                        color = Drawing.Color.Red
                        forecolor = Drawing.Color.White
                    Case Else
                        color = Drawing.Color.White

                End Select


                e.Appearance.BackColor = color
                e.Appearance.ForeColor = forecolor

            End If

        End If

    End Sub


    Private Sub CustomizaColorProducto(gv As DevExpress.XtraGrid.Views.Grid.GridView, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)

        Dim row As DataRow = gv.GetDataRow(e.RowHandle)
        If Not IsNothing(row) Then

            If e.Column.FieldName.Trim.ToUpper = "COLOR" Then

                Dim color As Color
                Dim forecolor As Color = Drawing.Color.Black

                Select Case (e.CellValue.ToString & "").Trim.ToUpper
                    Case "P"
                        color = color.FromArgb(92, 166, 68)
                    Case "S"
                        color = Drawing.Color.Red
                        forecolor = Drawing.Color.White
                    Case Else
                        color = Drawing.Color.White
                End Select


                e.Appearance.BackColor = color
                e.Appearance.ForeColor = forecolor

            End If

        End If

    End Sub


    Private Sub GridViewPartidas_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridViewPartidas.RowCellClick


        Dim row As DataRow = GridViewPartidas.GetDataRow(e.RowHandle)
        If Not IsNothing(row) Then

            If e.Column.FieldName.Trim.ToUpper = "CP" Then

                Dim IdAlbaran As String = (row("IdAlbaran").ToString & "").Trim

                Dim fr As New FrDocs
                fr.Init(AlbEntrada.NombreBd, AlbEntrada.NombreTabla, IdAlbaran)
                fr.ShowDialog()

            End If

        End If

    End Sub


    Private Sub rbNOMuestreadas_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbNOMuestreadas.CheckedChanged

        If rbNOMuestreadas.Checked Then
            LbDesdeFechaEntrada.Enabled = False
            TxDesdeFechaEntrada.Enabled = False
        Else
            LbDesdeFechaEntrada.Enabled = True
            TxDesdeFechaEntrada.Enabled = True
            If VaDate(TxDesdeFechaEntrada.Text) = VaDate("") Then
                TxDesdeFechaEntrada.Text = Today.ToString("dd/MM/yyyy")
            End If
        End If

    End Sub

End Class