Public Class Listado_ImprimirInformeCuadreKilos
    Inherits Listado_ImpresionBase


    Property Datos As DataTable
    Property Semana As String
    Property LstCentros As List(Of String)
    Property BMostrarCategorias As Boolean
    Property TipoImpresion As TipoImpresion


    Public Sub New(ByVal datos As DataTable, ByVal semana As String, lstCentros As List(Of String), bMostrarCategorias As Boolean, TipoImpresion As TipoImpresion)
        Me.Datos = datos
        Me.Semana = semana
        Me.LstCentros = lstCentros
        Me.BMostrarCategorias = bMostrarCategorias
        Me.TipoImpresion = TipoImpresion
    End Sub


    Public Overrides Sub ImprimirListado()

        MargenSup = 10
        MargenIzq = 10
        MargenInf = 10

        EstableceListado(Orientacion.Vertical, TipoImpresion)

        Try

            ConfigurarListado()
            Previsualiza()

        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub ConfigurarListado()

        Dim Centros As String = ""

        For Each s As String In LstCentros
            If Centros <> "" Then Centros = Centros & ","
            Centros = Centros & s
        Next


        'Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, "180", Estilos.Cabecera)
        Listado.Cabecera.Linea("CUADRE DE KILOS ENTRADOS/SALIDOS En la semana... " & Semana & "|Fecha: " & Now.ToString("dd/MM/yyyy - HH:mm"), "130|>60", Estilos.NormalBold)
        If Centros <> "" Then Listado.Cabecera.Linea("Centros: " & Centros, "195", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)
        Listado.Cabecera.Linea(" ", "180", Estilos.NormalBold)

        'Detalle
        Dim DLin As String = "32|20|>18|>18|>18|>18|>18|>18|>15|>15"
        Dim Cabecera As String = "GENERO|CAT/CALIB|K.E.INI.|KG.ENT|TOT.ENT|KG.SAL|K.E.FINAL|TOT.SAL|DIF|%"
        Listado.Cabecera.Linea(Cabecera, DLin, Estilos.ReducidaBoldLineaDebajo)
        Listado.Cabecera.Linea("", "", Estilos.ReducidaBold)

        Dim TotalIni As Decimal = 0
        Dim TotalEnt As Decimal = 0
        Dim TotalE As Decimal = 0
        Dim TotalSal As Decimal = 0
        Dim TotalFin As Decimal = 0
        Dim TotalS As Decimal = 0
        Dim TotalDif As Decimal = 0

        Dim TotalIniCat As Decimal = 0
        Dim TotalEntCat As Decimal = 0
        Dim TotalECat As Decimal = 0
        Dim TotalSalCat As Decimal = 0
        Dim TotalFinCat As Decimal = 0
        Dim TotalSCat As Decimal = 0
        Dim TotalDifCat As Decimal = 0

        Dim TotalIniGen As Decimal = 0
        Dim TotalEntGen As Decimal = 0
        Dim TotalEGen As Decimal = 0
        Dim TotalSalGen As Decimal = 0
        Dim TotalFinGen As Decimal = 0
        Dim TotalSGen As Decimal = 0
        Dim TotalDifGen As Decimal = 0

        Dim TotalIniSub As Decimal = 0
        Dim TotalEntSub As Decimal = 0
        Dim TotalESub As Decimal = 0
        Dim TotalSalSub As Decimal = 0
        Dim TotalFinSub As Decimal = 0
        Dim TotalSSub As Decimal = 0
        Dim TotalDifSub As Decimal = 0

        Dim AuxIdSub As String = ""
        Dim AuxSub As String = ""
        Dim AuxIdGenero As String = ""
        Dim AuxIdTipo As String = ""
        Dim AuxTipo As String = ""

        For Each row As DataRow In Datos.Rows

            Dim IdSubFamilia As String = (row("IdSubFa").ToString & "").Trim
            Dim IdGenero As String = (row("IdGenero").ToString & "").Trim
            Dim IdTipo As String = (row("IdTipo").ToString & "").Trim

            Dim tipo As String = (row("Tipo").ToString & "").Trim
            Dim Genero As String = (row("Genero").ToString & "").Trim
            Dim SubFamilia As String = (row("SubFamilia").ToString & "").Trim
            Dim Categoria As String = (row("Cat").ToString & "").Trim

            Dim Ini As Decimal = VaDec(row("Iniciales"))
            Dim Ent As Decimal = VaDec(row("Entradas"))
            Dim Sal As Decimal = VaDec(row("Salidas"))
            Dim Fin As Decimal = VaDec(row("Finales"))

            Dim E As Decimal = Ini + Ent
            Dim S As Decimal = Sal + Fin
            Dim Dif As Decimal = VaDec(row("Diferencia"))
            Dim Porcentaje As String = ""
            If VaDec(row("Porcentaje")) <> 0 Then Porcentaje = VaDec(row("Porcentaje")).ToString("#,##0.00") & "%"

            Dim bCambiaSub As Boolean = AuxIdSub <> IdSubFamilia And AuxIdSub <> ""
            Dim bCambiaGen As Boolean = AuxIdGenero <> IdGenero And AuxIdGenero <> ""
            Dim bCambiaTipo As Boolean = AuxIdTipo <> IdTipo And AuxIdTipo <> ""

            If bCambiaSub Then
                bCambiaGen = True
                bCambiaTipo = True
            End If

            If bCambiaGen Then
                bCambiaTipo = True
            End If

            If bCambiaTipo Then
                Dim Pct As Decimal = 0
                If TotalECat <> 0 Then Pct = TotalDifCat / TotalECat * 100
                Dim PctStr As String = ""
                If Pct <> 0 Then PctStr = Pct.ToString("#,##0.00") & "%"

                Dim ct As String = "|Total Cat: " & AuxTipo & "|" & _
                    TotalIniCat.ToString("#,###") & "|" & _
                    TotalEntCat.ToString("#,###") & "|" & _
                    TotalECat.ToString("#,###") & "|" & _
                    TotalSalCat.ToString("#,###") & "|" & _
                    TotalFinCat.ToString("#,###") & "|" & _
                    TotalSCat.ToString("#,###") & "|" & _
                    TotalDifCat.ToString("#,###") & "|" & _
                    PctStr
                Listado.Detalle.Linea(ct, DLin, Estilos.Minima)
                Listado.Detalle.Linea("", "200", Estilos.MinimaBold)

                TotalIniCat = 0
                TotalEntCat = 0
                TotalECat = 0
                TotalSalCat = 0
                TotalFinCat = 0
                TotalSCat = 0
                TotalDifCat = 0
            End If

            If bCambiaGen Then
                Dim Pct As Decimal = 0
                If TotalEGen <> 0 Then Pct = TotalDifGen / TotalEGen * 100
                Dim PctStr As String = ""
                If Pct <> 0 Then PctStr = Pct.ToString("#,##0.00") & "%"

                Dim ct As String = "Total Producto....||" & _
                    TotalIniGen.ToString("#,###") & "|" & _
                    TotalEntGen.ToString("#,###") & "|" & _
                    TotalEGen.ToString("#,###") & "|" & _
                    TotalSalGen.ToString("#,###") & "|" & _
                    TotalFinGen.ToString("#,###") & "|" & _
                    TotalSGen.ToString("#,###") & "|" & _
                    TotalDifGen.ToString("#,###") & "|" & _
                    PctStr
                Listado.Detalle.Linea(ct, DLin, Estilos.Minima)
                Listado.Detalle.Linea("", "200", Estilos.MinimaBold)

                TotalIniGen = 0
                TotalEntGen = 0
                TotalEGen = 0
                TotalSalGen = 0
                TotalFinGen = 0
                TotalSGen = 0
                TotalDifGen = 0
            End If

            If bCambiaSub Then
                Dim Pct As Decimal = 0
                If TotalESub <> 0 Then Pct = TotalDifSub / TotalESub * 100
                Dim PctStr As String = ""
                If Pct <> 0 Then PctStr = Pct.ToString("#,##0.00") & "%"

                Dim ct As String = AuxSub & "||" & _
                    TotalIniSub.ToString("#,###") & "|" & _
                    TotalEntSub.ToString("#,###") & "|" & _
                    TotalESub.ToString("#,###") & "|" & _
                    TotalSalSub.ToString("#,###") & "|" & _
                    TotalFinSub.ToString("#,###") & "|" & _
                    TotalSSub.ToString("#,###") & "|" & _
                    TotalDifSub.ToString("#,###") & "|" & _
                    PctStr
                Listado.Detalle.Linea(ct, DLin, Estilos.MinimaBoldLineaEncima)
                Listado.Detalle.Linea("", "200", Estilos.MinimaBold)
                Listado.Detalle.Linea("", "200", Estilos.MinimaBold)

                TotalIniSub = 0
                TotalEntSub = 0
                TotalESub = 0
                TotalSalSub = 0
                TotalFinSub = 0
                TotalSSub = 0
                TotalDifSub = 0
            End If

            Dim Gen As String = ""
            If AuxIdGenero <> IdGenero Then
                Gen = Genero
            End If

            Dim det As String = Gen & "|" & Categoria & "|" & _
                Ini.ToString("#,###") & "|" & _
                Ent.ToString("#,###") & "|" & _
                E.ToString("#,###") & "|" & _
                Sal.ToString("#,###") & "|" & _
                Fin.ToString("#,###") & "|" & _
                S.ToString("#,###") & "|" & _
                Dif.ToString("#,###") & "|" & _
                Porcentaje
            Listado.Detalle.Linea(det, DLin, Estilos.Minima)

            TotalIni = TotalIni + Ini
            TotalEnt = TotalEnt + Ent
            TotalSal = TotalSal + Sal
            TotalFin = TotalFin + Fin
            TotalE = TotalE + E
            TotalS = TotalS + Sal
            TotalDif = TotalDif + Dif

            TotalIniCat = TotalIniCat + Ini
            TotalEntCat = TotalEntCat + Ent
            TotalSalCat = TotalSalCat + Sal
            TotalFinCat = TotalFinCat + Fin
            TotalECat = TotalECat + E
            TotalSCat = TotalSCat + Sal
            TotalDifCat = TotalDifCat + Dif

            TotalIniGen = TotalIniGen + Ini
            TotalEntGen = TotalEntGen + Ent
            TotalSalGen = TotalSalGen + Sal
            TotalFinGen = TotalFinGen + Fin
            TotalEGen = TotalEGen + E
            TotalSGen = TotalSGen + Sal
            TotalDifGen = TotalDifGen + Dif

            TotalIniSub = TotalIniSub + Ini
            TotalEntSub = TotalEntSub + Ent
            TotalSalSub = TotalSalSub + Sal
            TotalFinSub = TotalFinSub + Fin
            TotalESub = TotalESub + E
            TotalSSub = TotalSSub + Sal
            TotalDifSub = TotalDifSub + Dif

            AuxIdSub = IdSubFamilia
            AuxSub = SubFamilia
            AuxIdGenero = IdGenero
            AuxIdTipo = IdTipo
            AuxTipo = tipo


            Application.DoEvents()

        Next

        'Última Cat
        Dim PctCat As Decimal = 0
        If TotalECat <> 0 Then PctCat = TotalDifCat / TotalECat * 100
        Dim PctT As String = ""
        If PctCat <> 0 Then PctT = PctCat.ToString("#,##0.00") & "%"

        Dim lin As String = "|Total Cat: " & AuxTipo & "|" & _
            TotalIniCat.ToString("#,###") & "|" & _
            TotalEntCat.ToString("#,###") & "|" & _
            TotalECat.ToString("#,###") & "|" & _
            TotalSalCat.ToString("#,###") & "|" & _
            TotalFinCat.ToString("#,###") & "|" & _
            TotalSCat.ToString("#,###") & "|" & _
            TotalDifCat.ToString("#,###") & "|" & _
            PctT
        Listado.Detalle.Linea(lin, DLin, Estilos.Minima)

        'Último Gen
        Dim PctGen As Decimal = 0
        If TotalEGen <> 0 Then PctGen = TotalDifGen / TotalEGen * 100
        PctT = ""
        If PctGen <> 0 Then PctT = PctGen.ToString("#,##0.00") & "%"

        lin = "Total Producto....||" & _
            TotalIniGen.ToString("#,###") & "|" & _
            TotalEntGen.ToString("#,###") & "|" & _
            TotalEGen.ToString("#,###") & "|" & _
            TotalSalGen.ToString("#,###") & "|" & _
            TotalFinGen.ToString("#,###") & "|" & _
            TotalSGen.ToString("#,###") & "|" & _
            TotalDifGen.ToString("#,###") & "|" & _
            PctT
        Listado.Detalle.Linea(lin, DLin, Estilos.Minima)

        'Última Sub 
        Dim PctSub As Decimal = 0
        If TotalESub <> 0 Then PctSub = TotalDifSub / TotalESub * 100
        PctT = ""
        If PctSub <> 0 Then PctT = PctSub.ToString("#,##0.00") & "%"

        lin = AuxSub & "||" & _
            TotalIniSub.ToString("#,###") & "|" & _
            TotalEntSub.ToString("#,###") & "|" & _
            TotalESub.ToString("#,###") & "|" & _
            TotalSalSub.ToString("#,###") & "|" & _
            TotalFinSub.ToString("#,###") & "|" & _
            TotalSSub.ToString("#,###") & "|" & _
            TotalDifSub.ToString("#,###") & "|" & _
            PctT
        Listado.Detalle.Linea("", "200", Estilos.MinimaBoldLineaDebajo)
        Listado.Detalle.Linea(lin, DLin, Estilos.MinimaBold)
        Listado.Detalle.Linea("", "200", Estilos.MinimaBold)

        'Gran Total
        Dim PctTot As Decimal = 0
        If TotalE <> 0 Then PctTot = TotalDif / TotalE * 100
        PctT = ""
        If PctTot <> 0 Then PctT = PctTot.ToString("#,##0.00") & "%"

        lin = "TOTAL LISTADO.....||" & _
            TotalIni.ToString("#,###") & "|" & _
            TotalEnt.ToString("#,###") & "|" & _
            TotalE.ToString("#,###") & "|" & _
            TotalSal.ToString("#,###") & "|" & _
            TotalFin.ToString("#,###") & "|" & _
            TotalS.ToString("#,###") & "|" & _
            TotalDif.ToString("#,###") & "|" & _
            PctT
        Listado.Detalle.Linea("", "200", Estilos.MinimaBoldLineaDebajo)
        Listado.Detalle.Linea(lin, DLin, Estilos.MinimaBold)
        Listado.Detalle.Linea("", "200", Estilos.MinimaBold)
    End Sub


End Class
