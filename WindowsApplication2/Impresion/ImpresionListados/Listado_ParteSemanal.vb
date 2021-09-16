Public Class Listado_ParteSemanal
    Inherits Listado_ImpresionBase


    Property Datos As DataTable
    Property Semana As String
    Property PorImporte As Boolean
    Property Avance As Boolean
    Property ParteDesde As String
    Property ParteHasta As String
    Property TipoImpresion As TipoImpresion


    Public Sub New(ByVal datos As DataTable, ByVal semana As String, ByVal porImporte As Boolean, ByVal TipoImpresion As TipoImpresion)
        Me.Datos = datos
        Me.Semana = semana
        Me.PorImporte = porImporte
        Me.TipoImpresion = TipoImpresion
    End Sub

    Public Sub New(ByVal datos As DataTable, ByVal ParteDesde As String, ParteHasta As String, ByVal TipoImpresion As TipoImpresion)
        Me.Datos = datos
        Me.PorImporte = PorImporte
        Me.Avance = True
        Me.ParteDesde = ParteDesde
        Me.ParteHasta = ParteHasta
        Me.PorImporte = True
        Me.TipoImpresion = TipoImpresion
    End Sub


    Public Overrides Sub ImprimirListado()

        Try

            If PorImporte Then
                EstableceListado(Orientacion.Horizontal, TipoImpresion)
                ConfigurarListadoPorImporte()
            Else
                EstableceListado(Orientacion.Vertical, TipoImpresion)
                ConfigurarListadoPorKilos()
            End If

            Previsualiza()


        Catch ex As Exception

        End Try


    End Sub


    Private Sub ConfigurarListadoPorImporte()


        Dim TITULO As String = ""
        If Not Avance Then
            TITULO = "Avance Precios de Liquidación - Por Importe. Semana: " + Semana
        Else
            TITULO = "Avance Precios de Liquidación. Desde parte " & ParteDesde & " hasta parte " & ParteHasta
        End If

        Dim SIZE As String = "273"


        ' Titulos Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, SIZE, Estilos.Cabecera)
        Dim FormatoCabecera As String = "200|>73"
        Listado.Cabecera.Linea(TITULO & " | " & " Fecha: " & Today.ToString("dd/MM/yyyy"), FormatoCabecera, Estilos.GrandeBold)

        Listado.Cabecera.Linea("", SIZE, Estilos.Normal)
        Listado.Cabecera.Linea("", SIZE, Estilos.Normal)

        Dim Formato As String = ""
        Dim Texto As String = ""


        If Not Avance Then
            Formato = "<30|<15|>15|>15|>15|>15|>15|>15|>15|>15|>15|>15|>15|>15|>15"
            Texto = "GENERO | CAT | FIRME | S/CLAS | GASTOSC | VENTA NETA | V. INI | V. FIN | VALORADO | DISPONIBLE | KILOSC | P. AVANCE | P.LIQ |IMP.LIQ|RESULTADO"
        Else
            Formato = "<30|<15|>15|>15|>15|>15|>15|>15|>15|>15|>15|>15|>15|>15"
            Texto = "GENERO | CAT | FIRME | S/CLAS | GASTOSC | VENTA NETA | V. INI | V. FIN | VALORADO | DISPONIBLE | KILOSC | P.LIQ |IMP.LIQ|RESULTADO"
        End If


        Listado.Cabecera.Linea(Texto, Formato, Estilos.MinimaBoldLineaDebajo)
        Listado.Cabecera.Linea("", SIZE, Estilos.MinimaBold)

        ' Se totalizan los siguientes conceptos:
        '   1. SubFamilias
        '   2. Géneros
        '   3. Clasificación
        '   4. Categoría

        Dim AcumSFam As New AcumuladorParteSemanalImporte
        Dim AcumGenero As New AcumuladorParteSemanalImporte
        Dim AcumCla As New AcumuladorParteSemanalImporte
        Dim AcumTot As New AcumuladorParteSemanalImporte

        Dim ControlSubFamilia As String = ""
        Dim ControlGenero As String = ""
        Dim ControlClasificacion As String = ""
        Dim ControlTotal As String = ""

        Dim RompeSubFamilia As Boolean = False
        Dim RompeGenero As Boolean = False
        Dim RompeClasificacion As Boolean = False

        Dim RompeAlguno As Boolean = False

        Dim Primera As Boolean = True

        Dim FormatoTotales As String = ""
        If Not Avance Then
            FormatoTotales = "<45|>15|>15|>15|>15|>15|>15|>15|>15|>15|>15|>15|>15|>15"
        Else
            FormatoTotales = "<45|>15|>15|>15|>15|>15|>15|>15|>15|>15|>15|>15|>15"
        End If


        Dim Genero As String = ""
        Dim Categoria As String = ""
        Dim Clasificacion As String = ""
        Dim Firme As Decimal = 0
        Dim SClas As Decimal = 0
        Dim Comision As Decimal = 0
        Dim GastosC As Decimal = 0
        Dim NetoVenta As Decimal = 0
        Dim VExiINI As Decimal = 0
        Dim VExiFIN As Decimal = 0
        Dim Disponible As Decimal = 0
        Dim Valorado As Decimal = 0
        Dim KilosC As Decimal = 0
        Dim Iliqui As Decimal = 0
        Dim SubFamilia As String = ""

        For Each r As DataRow In Datos.Rows
            ' Obtengo los campos
            Genero = r("Genero").ToString
            Categoria = r("Categoria").ToString
            Clasificacion = r("Clasificacion").ToString
            Firme = VaDec(r("ImporteF"))
            SClas = VaDec(r("ImporteS"))
            GastosC = VaDec(r("GastosC"))
            NetoVenta = VaDec(r("NetoVenta"))
            VExiINI = VaDec(r("VExiIni"))
            VExiFIN = VaDec(r("VExiFin"))
            Disponible = VaDec(r("Disponible"))
            Valorado = VaDec(r("Valorado"))
            KilosC = VaDec(r("KilosC"))
            Iliqui = VaDec(r("iliqui"))

            SubFamilia = r("SubFam").ToString

            ' Compruebo si se debe romper el acumulado
            If Not ControlSubFamilia.Equals(r("SubFam")) And Not Primera Then
                RompeSubFamilia = True
                RompeGenero = True
                RompeClasificacion = True
                'RompeCategoria = True
            End If
            If Not ControlGenero.Equals(r("Genero")) And Not Primera Then
                RompeGenero = True
                RompeClasificacion = True
                'RompeCategoria = True
            End If
            If Not ControlClasificacion.Equals(Clasificacion) And Not Primera Then
                RompeClasificacion = True
                ' RompeCategoria = True
            End If
            '    If Not ControlCategoria.Equals(r("Categoria")) And Not Primera Then
            'RompeCategoria = True
            'End If

            If RompeSubFamilia Or RompeGenero Or RompeClasificacion Then RompeAlguno = True

            If RompeClasificacion Then
                DibujarLineasTotalesParteSemanalImporte(Listado, AcumCla, "Total Clase: " & ControlClasificacion, FormatoTotales)
            End If

            If RompeGenero Then
                DibujarLineasTotalesParteSemanalImporte(Listado, AcumGenero, "Total Genero: " & ControlGenero, FormatoTotales)
            End If

            If RompeSubFamilia Then
                DibujarLineasTotalesParteSemanalImporte(Listado, AcumSFam, "Total SubFamilia: " & ControlSubFamilia, FormatoTotales)
            End If

            If RompeAlguno Then Listado.Detalle.Linea("", "273", Estilos.MinimaBold)

            ' Dibujo la linea de la iteración actual
            Dim precioavance As Decimal = 0
            Dim precioliqui As Decimal = 0
            If KilosC <> 0 Then
                precioavance = Disponible / KilosC
                precioliqui = Iliqui / KilosC
            End If

            If Not Avance Then
                Texto = ObtenerLineaParteSemanalImporte(Genero & " | " & Categoria, Firme, SClas, GastosC, NetoVenta, VExiINI, VExiFIN, Valorado, _
                                                            Disponible, KilosC, precioavance, precioliqui)
            Else
                Texto = ObtenerLineaAvanceImporte(Genero & " | " & Categoria, Firme, SClas, GastosC, NetoVenta, VExiINI, VExiFIN, Valorado, _
                                                            Disponible, KilosC, precioliqui)
            End If

            Listado.Detalle.Linea(Texto, Formato, Estilos.Minima)

            ' Actualizo los acumuladores
            AcumSFam.SumarCampos(Firme, SClas, Comision, GastosC, NetoVenta, VExiINI, VExiFIN, Valorado, Disponible, KilosC, Iliqui)
            AcumGenero.SumarCampos(Firme, SClas, Comision, GastosC, NetoVenta, VExiINI, VExiFIN, Valorado, Disponible, KilosC, Iliqui)
            AcumCla.SumarCampos(Firme, SClas, Comision, GastosC, NetoVenta, VExiINI, VExiFIN, Valorado, Disponible, KilosC, Iliqui)
            AcumTot.SumarCampos(Firme, SClas, Comision, GastosC, NetoVenta, VExiINI, VExiFIN, Valorado, Disponible, KilosC, Iliqui)

            ' Actualizo los identificadores
            ControlSubFamilia = r("SubFam").ToString
            ControlGenero = r("Genero").ToString
            ControlClasificacion = Clasificacion
            ControlTotal = ""

            RompeAlguno = False
            RompeSubFamilia = False
            RompeGenero = False
            RompeClasificacion = False

            Primera = False


            Application.DoEvents()

        Next

        DibujarLineasTotalesParteSemanalImporte(Listado, AcumCla, "Total Clase: " & ControlClasificacion, FormatoTotales)
        DibujarLineasTotalesParteSemanalImporte(Listado, AcumGenero, "Total Genero: " & ControlGenero, FormatoTotales)
        DibujarLineasTotalesParteSemanalImporte(Listado, AcumSFam, "Total SubFamilia: " & ControlSubFamilia, FormatoTotales)
        DibujarLineasTotalesParteSemanalImporte(Listado, AcumTot, "Total SEMANA: " & ControlTotal, FormatoTotales)

    End Sub


    Private Sub ConfigurarListadoPorKilos()
        Dim TITULO As String = "Avance Precios de Liquidación - Por Kilos. Semana:  " + Semana
        Dim SIZE As String = "185"


        ' Titulos Cabecera
        Listado.Cabecera.Linea(MiMaletin.NombreEmpresa, SIZE, Estilos.Cabecera)
        Dim FormatoCabecera As String = "120|>75"
        Listado.Cabecera.Linea(TITULO & " | " & " Fecha: " & Today.ToString("dd/MM/yyyy"), FormatoCabecera, Estilos.GrandeBold)

        Listado.Cabecera.Linea("", SIZE, Estilos.Normal)
        Listado.Cabecera.Linea("", SIZE, Estilos.Normal)

        Dim Texto As String = ""

        Dim Formato As String = "<40|<28|>16|>16|>16|>17|>17|>17|>18"
        Texto = "GENERO | CAT | FIRME | S/CLAS | COMISION | EXI INI | EXI FIN | KILOS SALIDOS | DIFERENCIA"
        Listado.Cabecera.Linea(Texto, Formato, Estilos.MinimaBoldLineaDebajo)
        Listado.Cabecera.Linea("", SIZE, Estilos.MinimaBold)


        ' Se totalizan los siguientes conceptos:
        '   1. SubFamilias
        '   2. Géneros
        '   3. Clasificación
        '   4. Categoría

        Dim AcumSFam As New AcumuladorParteSemanalKilos
        Dim AcumGenero As New AcumuladorParteSemanalKilos
        Dim AcumCla As New AcumuladorParteSemanalKilos
        Dim AcumTotal As New AcumuladorParteSemanalKilos

        Dim ControlSubFamilia As String = ""
        Dim ControlGenero As String = ""
        Dim ControlClasificacion As String = ""
        Dim ControlCategoria As String = ""

        Dim RompeSubFamilia As Boolean = False
        Dim RompeGenero As Boolean = False
        Dim RompeClasificacion As Boolean = False
        Dim RompeCategoria As Boolean = False

        Dim RompeAlguno As Boolean = False

        Dim Primera As Boolean = True

        Dim FormatoTotales As String = "<68|>16|>16|>16|>17|>17|>17|>18"

        Dim Genero As String = ""
        Dim Categoria As String = ""
        Dim Clasificacion As String = ""
        Dim Firme As Decimal = 0
        Dim SClas As Decimal = 0
        Dim Comision As Decimal = 0
        Dim ExiINI As Decimal = 0
        Dim ExiFIN As Decimal = 0
        Dim KilosSalidos As Decimal = 0
        Dim Diferencia As Decimal = 0
        Dim SubFamilia As String = ""

        For Each r As DataRow In Datos.Rows
            ' Obtengo los campos
            Genero = r("Genero").ToString
            Categoria = r("Categoria").ToString
            Clasificacion = r("Clasificacion").ToString
            Firme = VaDec(r("KilosF"))
            SClas = VaDec(r("KilosS"))
            Comision = VaDec(r("KilosC"))
            ExiINI = VaDec(r("kexiini"))                                                 ' TODO: Introducir la variable
            ExiFIN = VaDec(r("kexifin"))                                                  ' TODO: Introducir la variable
            KilosSalidos = VaDec(r("KilosV"))
            Diferencia = 0                                              ' TODO: Introducir la variable
            SubFamilia = r("SubFam").ToString

            ' Compruebo si se debe romper el acumulado
            If Not ControlSubFamilia.Equals(r("SubFam")) And Not Primera Then
                RompeSubFamilia = True
                RompeGenero = True
                RompeClasificacion = True
                '        RompeCategoria = True
            End If
            If Not ControlGenero.Equals(r("Genero")) And Not Primera Then
                RompeGenero = True
                RompeClasificacion = True
                '     RompeCategoria = True
            End If
            If Not ControlClasificacion.Equals(r("clasificacion")) And Not Primera Then
                RompeClasificacion = True
                '     RompeCategoria = True
            End If
            '   If Not ControlCategoria.Equals(r("Categoria")) And Not Primera Then
            ' RompeCategoria = True
            ' End If

            If RompeSubFamilia Or RompeGenero Or RompeClasificacion Then RompeAlguno = True

            ' Se dibujan los acumulados que sean necesarios
            'If RompeCategoria Then
            '    DibujarLineasTotalesParteSemanalKilos(Listado, AcumCat, "Total Cat: " & ControlCategoria, FormatoTotales)
            'End If

            If RompeClasificacion Then
                DibujarLineasTotalesParteSemanalKilos(Listado, AcumCla, "Total Clase: " & ControlClasificacion, FormatoTotales)
            End If

            If RompeGenero Then
                DibujarLineasTotalesParteSemanalKilos(Listado, AcumGenero, "Total Genero: " & ControlGenero, FormatoTotales)
            End If

            If RompeSubFamilia Then
                DibujarLineasTotalesParteSemanalKilos(Listado, AcumSFam, "Total SubFamilia: " & ControlSubFamilia, FormatoTotales)
            End If

            If RompeAlguno Then Listado.Detalle.Linea("", "273", Estilos.MinimaBold)

            ' Dibujo la linea de la iteración actual
            Texto = ObtenerLineaParteSemanalKilos(Genero & " | " & Categoria, Firme, SClas, Comision, ExiINI, ExiFIN, KilosSalidos, Diferencia)
            Listado.Detalle.Linea(Texto, Formato, Estilos.Minima)
            Diferencia = Firme + SClas + Comision + ExiINI - ExiFIN - KilosSalidos
            ' Actualizo los acumuladores
            AcumSFam.SumarCampos(Firme, SClas, Comision, ExiINI, ExiFIN, KilosSalidos, Diferencia)
            AcumGenero.SumarCampos(Firme, SClas, Comision, ExiINI, ExiFIN, KilosSalidos, Diferencia)
            AcumCla.SumarCampos(Firme, SClas, Comision, ExiINI, ExiFIN, KilosSalidos, Diferencia)
            AcumTotal.SumarCampos(Firme, SClas, Comision, ExiINI, ExiFIN, KilosSalidos, Diferencia)

            ' Actualizo los identificadores
            ControlSubFamilia = r("SubFam").ToString
            ControlGenero = r("Genero").ToString
            ControlClasificacion = r("clasificacion").ToString
            ControlCategoria = r("Categoria").ToString

            RompeAlguno = False
            RompeSubFamilia = False
            RompeGenero = False
            RompeClasificacion = False
            RompeCategoria = False

            Primera = False


            Application.DoEvents()

        Next

        DibujarLineasTotalesParteSemanalKilos(Listado, AcumCla, "Total Clase: " & ControlClasificacion, FormatoTotales)
        DibujarLineasTotalesParteSemanalKilos(Listado, AcumGenero, "Total Genero: " & ControlGenero, FormatoTotales)
        DibujarLineasTotalesParteSemanalKilos(Listado, AcumSFam, "Total SubFamilia: " & ControlSubFamilia, FormatoTotales)
        DibujarLineasTotalesParteSemanalKilos(Listado, AcumTotal, "Total SEMANA: " & Semana, FormatoTotales)
    End Sub


    Private Sub DibujarLineasTotalesParteSemanalImporte(ByVal Listado As Listado, ByRef Acum As AcumuladorParteSemanalImporte, ByVal Titulos As String, ByVal Formato As String)

        Dim precio As Decimal = 0
        Dim precioliqui As Decimal = 0
        If Acum.KilosC <> 0 Then
            precio = Acum.Disponible / Acum.KilosC
            precioliqui = Acum.ImporteLiqui / Acum.KilosC
        End If
        Dim texto As String = ""
        If Not Avance Then
            texto = ObtenerLineaParteSemanalImporte(Titulos, Acum.Firme, Acum.SClas, Acum.GastosC, Acum.VentaNeta, Acum.VExiINI,
                                             Acum.VExiFIN, Acum.Valorado, Acum.Disponible, Acum.KilosC, precio, precioliqui)
        Else
            texto = ObtenerLineaAvanceImporte(Titulos, Acum.Firme, Acum.SClas, Acum.GastosC, Acum.VentaNeta, Acum.VExiINI,
                                             Acum.VExiFIN, Acum.Valorado, Acum.Disponible, Acum.KilosC, precioliqui)

        End If

        Listado.Detalle.Linea(texto, Formato, Estilos.MinimaBold)
        Acum.Reiniciar()

    End Sub


    Private Function ObtenerLineaParteSemanalImporte(ByVal Texto As String, ByVal Firme As Decimal, _
                                                         ByVal SClas As Decimal, ByVal GastosC As Decimal, _
                                                         ByVal NetoVenta As Decimal, ByVal VExiINI As Decimal, ByVal VExiFIN As Decimal, ByVal Valorado As Decimal, _
                                                         ByVal Disponible As Decimal, ByVal KilosC As Decimal, ByVal PrecioAvance As Decimal, ByVal PrecioLiqui As Decimal) As String

        Dim Cadena As String = Texto & " | "
        Dim Iliqui As Decimal = KilosC * PrecioLiqui
        Dim resultado As Decimal = Disponible - Iliqui
        Cadena &= Fnusing(Firme, "#,##0.00") & " | " _
               & Fnusing(SClas, "#,##0.00") & " | " _
               & Fnusing(GastosC, "#,##0.00") & " | " _
               & Fnusing(NetoVenta, "#,##0.00") & " | " _
               & Fnusing(VExiINI, "#,##0.00") & " | " _
               & Fnusing(VExiFIN, "#,##0.00") & " | " _
               & Fnusing(Valorado, "#,##0.00") & " | " _
               & Fnusing(Disponible, "#,##0.00") & " | " _
               & Fnusing(KilosC, "#,##0.00") & " | " _
               & Fnusing(PrecioAvance, "#,##0.00") & " | " _
               & Fnusing(PrecioLiqui, "#,##0.00") & " | " _
               & Fnusing(Iliqui, "#,##0.00") & " | " _
              & Fnusing(resultado, "#,##0.00") & " | "

        Return Cadena
    End Function


    Private Function ObtenerLineaAvanceImporte(ByVal Texto As String, ByVal Firme As Decimal, _
                                                         ByVal SClas As Decimal, ByVal GastosC As Decimal, _
                                                         ByVal NetoVenta As Decimal, ByVal VExiINI As Decimal, ByVal VExiFIN As Decimal, ByVal Valorado As Decimal, _
                                                         ByVal Disponible As Decimal, ByVal KilosC As Decimal, ByVal PrecioLiqui As Decimal) As String

        Dim Cadena As String = Texto & " | "
        Dim Iliqui As Decimal = KilosC * PrecioLiqui
        Dim resultado As Decimal = Disponible - Iliqui
        Cadena &= Fnusing(Firme, "#,##0.00") & " | " _
               & Fnusing(SClas, "#,##0.00") & " | " _
               & Fnusing(GastosC, "#,##0.00") & " | " _
               & Fnusing(NetoVenta, "#,##0.00") & " | " _
               & Fnusing(VExiINI, "#,##0.00") & " | " _
               & Fnusing(VExiFIN, "#,##0.00") & " | " _
               & Fnusing(Valorado, "#,##0.00") & " | " _
               & Fnusing(Disponible, "#,##0.00") & " | " _
               & Fnusing(KilosC, "#,##0.00") & " | " _
               & Fnusing(PrecioLiqui, "#,##0.00") & " | " _
               & Fnusing(Iliqui, "#,##0.00") & " | " _
              & Fnusing(resultado, "#,##0.00") & " | "

        Return Cadena
    End Function


    Private Function Fnusing(dato As Decimal, formato As String) As String
        Dim ret As String
        If dato = 0 Then
            ret = ""
        Else
            ret = dato.ToString(formato)
        End If

        Return ret
    End Function

    Private Sub DibujarLineasTotalesParteSemanalKilos(ByVal Listado As Listado, ByRef Acum As AcumuladorParteSemanalKilos, ByVal Titulos As String, ByVal Formato As String)
        Dim Texto As String = ObtenerLineaParteSemanalKilos(Titulos, Acum.Firme, Acum.SClas, Acum.Comision, Acum.ExiINI, Acum.ExiFIN, Acum.KilosSalidos, _
                                         Acum.Diferencia)
        Listado.Detalle.Linea(Texto, Formato, Estilos.MinimaBold)
        Acum.Reiniciar()
    End Sub

    Private Function ObtenerLineaParteSemanalKilos(ByVal Texto As String, ByVal Firme As Decimal, _
                                                         ByVal SClas As Decimal, ByVal Comision As Decimal, ByVal ExiINI As Decimal, _
                                                         ByVal ExiFIN As Decimal, ByVal KilosSalidos As Decimal, ByVal Diferencia As Decimal) As String

        Dim Cadena As String = Texto & " | "

        Cadena &= Firme.ToString("#,##0.00") & " | " _
               & SClas.ToString("#,##0.00") & " | " _
               & Comision.ToString("#,##0.00") & " | " _
               & ExiINI.ToString("#,##0.00") & " | " _
               & ExiFIN.ToString("#,##0.00") & " | " _
               & KilosSalidos.ToString("#,##0.00") & " | " _
               & Diferencia.ToString("#,##0.00")

        Return Cadena
    End Function


    Private Class AcumuladorParteSemanalImporte
        Public Firme As Decimal
        Public SClas As Decimal
        Public Comision As Decimal
        Public GastosC As Decimal
        Public VentaNeta As Decimal
        Public VExiINI As Decimal
        Public VExiFIN As Decimal
        Public Valorado As Decimal
        Public Disponible As Decimal
        Public KilosC As Decimal
        Public ImporteLiqui As Decimal

        Public Sub New()
            Me.New(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
        End Sub

        Public Sub New(ByVal Firme As Decimal, ByVal SClas As Decimal, ByVal Comision As Decimal, ByVal GastosC As Decimal, ByVal VentaNeta As Decimal, _
                       ByVal VExiINI As Decimal, ByVal VExiFIN As Decimal, ByVal Valorado As Decimal, ByVal Disponible As Decimal, ByVal KilosC As Decimal, ByVal ImporteLiqui As Decimal)
            Me.Firme = Firme
            Me.SClas = SClas
            Me.Comision = Comision
            Me.GastosC = GastosC
            Me.VentaNeta = VentaNeta
            Me.VExiINI = VExiINI
            Me.VExiFIN = VExiFIN
            Me.Valorado = Valorado
            Me.Disponible = Disponible
            Me.KilosC = KilosC
            Me.ImporteLiqui = ImporteLiqui

        End Sub

        Public Sub SumarCampos(ByVal F As Decimal, ByVal SC As Decimal, ByVal C As Decimal, ByVal GC As Decimal, ByVal VN As Decimal, _
                       ByVal VEI As Decimal, ByVal VEF As Decimal, ByVal V As Decimal, ByVal D As Decimal, ByVal KC As Decimal, ByVal iliqui As Decimal)
            Firme += F
            SClas += SC
            Comision += C
            GastosC += GC
            VentaNeta += VN
            VExiINI += VEI
            VExiFIN += VEF
            Valorado += V
            Disponible += D
            KilosC += KC
            ImporteLiqui += iliqui


        End Sub

        Public Sub Reiniciar()
            Firme = 0
            SClas = 0
            Comision = 0
            GastosC = 0
            VentaNeta = 0
            VExiINI = 0
            VExiFIN = 0
            Valorado = 0
            Disponible = 0
            KilosC = 0
            ImporteLiqui = 0
        End Sub
    End Class

    Private Class AcumuladorParteSemanalKilos
        Public Firme As Decimal
        Public SClas As Decimal
        Public Comision As Decimal
        Public ExiINI As Decimal
        Public ExiFIN As Decimal
        Public KilosSalidos As Decimal
        Public Diferencia As Decimal

        Public Sub New()
            Me.New(0, 0, 0, 0, 0, 0, 0)
        End Sub

        Public Sub New(ByVal Firme As Decimal, ByVal SClas As Decimal, ByVal Comision As Decimal, ByVal ExiINI As Decimal, ByVal ExiFIN As Decimal, _
                       ByVal KilosSalidos As Decimal, ByVal Diferencia As Decimal)
            Me.Firme = Firme
            Me.SClas = SClas
            Me.Comision = Comision
            Me.ExiINI = ExiINI
            Me.ExiFIN = ExiFIN
            Me.KilosSalidos = KilosSalidos
            Me.Diferencia = Diferencia
        End Sub

        Public Sub SumarCampos(ByVal F As Decimal, ByVal SC As Decimal, ByVal C As Decimal, ByVal EI As Decimal, ByVal EF As Decimal, _
                       ByVal KS As Decimal, ByVal D As Decimal)
            Firme += F
            SClas += SC
            Comision += C
            ExiINI += EI
            ExiFIN += EF
            KilosSalidos += KS
            Diferencia += D
        End Sub

        Public Sub Reiniciar()
            Firme = 0
            SClas = 0
            Comision = 0
            ExiINI = 0
            ExiFIN = 0
            KilosSalidos = 0
            Diferencia = 0
        End Sub
    End Class


End Class
