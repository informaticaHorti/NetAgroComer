Public Class FrmComprobarPalets


    Private _IdAlbaran As String = ""

    Private AlbSalida As New E_AlbSalida(Idusuario, cn)


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub


    Public Sub New(IdAlbaranSalida As String)

        Me.New()
        Me._IdAlbaran = IdAlbaranSalida

    End Sub


    Private Sub FrmComprobarPalets_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        CargaGrid()

    End Sub


    Private Sub CargaGrid()

        CargaGridGastosPalets()
        CargaGridGastosTotales()
        CargaGridLineasAlbaran()

     
    End Sub


    Private Sub CargaGridGastosPalets()

        Dim sql As String = "SELECT PLL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
        sql = sql & " PLL_KilosNetos as KgNetos, PLL_Bultos as Bultos, " & vbCrLf
        sql = sql & " PLL_CosteEstructura as Estructura, PLL_CosteConfeccion as Confeccion, PLL_CosteMaterial as Material" & vbCrLf
        sql = sql & " FROM Palets_Lineas " & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida_Palets ON ASP_IdPalet = PLL_IdPalet" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = PLL_IdGenero" & vbCrLf
        sql = sql & " WHERE ASP_IdAlbaran = " & _IdAlbaran & vbCrLf
        sql = sql & " ORDER BY Genero"

        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)

        GridGastosPalets.DataSource = dt
        AjustaColumnas(GridViewGastosPalets)

    End Sub


    Private Sub CargaGridGastosTotales()

        Dim sql As String = "SELECT GCO_Nombre as Gasto, " & vbCrLf
        sql = sql & " ASG_ValorGasto as Vgasto,ASG_TipoKBP as KBP, ASG_tipofc as FC," & vbCrLf
        sql = sql & " ASG_ImporteGastoEuros as Importe" & vbCrLf
        sql = sql & " FROM ALBSALIDA_GASTOS ASG" & vbCrLf
        sql = sql & " LEFT JOIN GASTOSCOMERCIO GCO ON GCO_IDGASTO = ASG_IDGASTO" & vbCrLf
        sql = sql & " WHERE ASG_IDALBARAN = " & _IdAlbaran

        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)

        GridGastosTotales.DataSource = dt
        AjustaColumnas(GridViewGastosTotales)

    End Sub


    Private Sub CargaGridLineasAlbaran()

        Dim sql As String = "SELECT ASL_IdLinea as Linea, ASL_IdGenero as IdGenero, GEN_NombreGenero as Genero," & vbCrLf
        sql = sql & " ASL_KilosNetos as KgNetos,ASL_KilosCliente as KgCliente,ASL_kilosvendidos as KgVta,ASL_BultosVendidos as Bultos, ASL_ImporteGeneroVta as ImporteGenero," & vbCrLf
        sql = sql & " ASL_Estructura as Estructura,ASL_Manipulacion as Confeccion,ASL_Materiales as Material,ASL_GastoF as GastoF, ASL_GastoC as GastoC,ASL_GastoPorte as GPorte " & vbCrLf
        sql = sql & " FROM AlbSalida_Lineas ASL" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = ASL_IdGenero" & vbCrLf
        sql = sql & " WHERE ASL_IdAlbaran = " & _IdAlbaran & vbCrLf
        sql = sql & " ORDER BY Genero" & vbCrLf

        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)

        GridLineasAlbaran.DataSource = dt
        AjustaColumnas(GridViewLineasAlbaran)

    End Sub




  

    Private Sub AjustaColumnas(gv As DevExpress.XtraGrid.Views.Grid.GridView)

        gv.BestFitColumns()

        With gv.Columns

            If Not IsNothing(.ColumnByFieldName("IdGenero")) Then .ColumnByFieldName("IdGenero").Visible = False
            If Not IsNothing(.ColumnByFieldName("KgNetos")) Then
                With .ColumnByFieldName("KgNetos")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0"
                End With
                AñadeResumenCampo(gv, "KgNetos", "{0:n0}")
            End If
            If Not IsNothing(.ColumnByFieldName("KgCliente")) Then
                With .ColumnByFieldName("KgCliente")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0"
                End With
                AñadeResumenCampo(gv, "KgCliente", "{0:n0}")
            End If

            If Not IsNothing(.ColumnByFieldName("KgVta")) Then
                With .ColumnByFieldName("KgVta")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0"
                End With
                AñadeResumenCampo(gv, "KgVta", "{0:n0}")
            End If

            If Not IsNothing(.ColumnByFieldName("Kilos")) Then
                With .ColumnByFieldName("Kilos")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0"
                End With
                AñadeResumenCampo(gv, "Kilos", "{0:n0}")
            End If
            If Not IsNothing(.ColumnByFieldName("Bultos")) Then
                With .ColumnByFieldName("Bultos")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0"
                End With
                AñadeResumenCampo(gv, "Bultos", "{0:n0}")
            End If
            If Not IsNothing(.ColumnByFieldName("Estructura")) Then
                With .ColumnByFieldName("Estructura")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "Estructura", "{0:n2}")
            End If
            If Not IsNothing(.ColumnByFieldName("Confeccion")) Then
                With .ColumnByFieldName("Confeccion")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "Confeccion", "{0:n2}")
            End If
            If Not IsNothing(.ColumnByFieldName("Material")) Then
                With .ColumnByFieldName("Material")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "Material", "{0:n2}")
            End If
            If Not IsNothing(.ColumnByFieldName("Manipulacion")) Then
                With .ColumnByFieldName("Manipulacion")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "Manipulacion", "{0:n2}")
            End If
            If Not IsNothing(.ColumnByFieldName("GastoF")) Then
                With .ColumnByFieldName("GastoF")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "GastoF", "{0:n2}")
            End If
            If Not IsNothing(.ColumnByFieldName("GastoC")) Then
                With .ColumnByFieldName("GastoC")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "GastoC", "{0:n2}")
            End If

            If Not IsNothing(.ColumnByFieldName("GPorte")) Then
                With .ColumnByFieldName("GPorte")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "GPorte", "{0:n2}")
            End If

            If Not IsNothing(.ColumnByFieldName("%")) Then
                With .ColumnByFieldName("%")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "%", "{0:n2}")
            End If

            If Not IsNothing(.ColumnByFieldName("Importe")) Then
                With .ColumnByFieldName("Importe")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                End With
                AñadeResumenCampo(gv, "Importe", "{0:n2}")
            End If
            If Not IsNothing(.ColumnByFieldName("ImporteGenero")) Then
                With .ColumnByFieldName("ImporteGenero")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.00"
                    .Caption = "ImpGenero"
                End With
                AñadeResumenCampo(gv, "ImporteGenero", "{0:n2}")
            End If
            If Not IsNothing(.ColumnByFieldName("ValorGasto")) Then
                With .ColumnByFieldName("ValorGasto")
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "#,##0.0000"
                End With
            End If


        End With


    End Sub


    Private Sub BConsultar_Click(sender As System.Object, e As System.EventArgs) Handles BConsultar.Click
        CargaGrid()
    End Sub


    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub

    
End Class