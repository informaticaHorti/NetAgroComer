Imports System.Drawing
Imports DevExpress.XtraEditors

Module C1_FacturasRecibidas

    Private fuente_envase As New Font("Tahoma", 8, FontStyle.Italic)
    Private fuente As New Font("Tahoma", 7, FontStyle.Regular)
    Private fuente_negrita As New Font("Tahoma", 7, FontStyle.Bold)

    Private impreso As Impreso
    Private altura As Integer
    Private margen_izquierdo As Integer
    Private ancho_linea As Decimal
    Private finDetalle As Integer
    Private datosEmpresa As DatosEmpresa
    Private col As List(Of Integer)


    Private AlbEntrada_His As New E_AlbEntrada_his(Idusuario, cn)
    Private AlbEntrada As New E_AlbEntrada(Idusuario, cn)
    Private AlbEntrada_HisGastos As New E_albentrada_hisgastos(Idusuario, cn)
    Private AlbMaterial As New E_AlbMaterial(Idusuario, cn)


    Public Sub C1_ImprimirFacturasRecibidas(ByVal IdFactura As String, ByVal IdProveedor As String, ByVal FacturaGenero As Boolean,
                                            ByVal tipoImpresion As TipoImpresion,
                                            Optional ByVal impresora As String = "", Optional ByVal rutaPDF As String = "",
                                            Optional ByVal archivoPDF As String = "")

        Dim FacturasRecibidas As New E_Facturasrecibidas(Idusuario, cn)

        If FacturasRecibidas.LeerId(IdFactura) Then
            impreso = New Impreso()
            altura = 7
            margen_izquierdo = 10
            ancho_linea = 2
            finDetalle = 195
            datosEmpresa = New DatosEmpresa

            col = New List(Of Integer)
            col.Add(0)
            col.Add(margen_izquierdo + 2)
            col.Add(col(1) + 30)
            col.Add(col(2) + 40)
            col.Add(col(3) + 30)
            col.Add(col(4) + 86)

            impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
            impreso.f.documento.PageLayout.PageSettings.Landscape = False
            impreso.f.documento.PageLayout.PageSettings.TopMargin = "10mm"
            impreso.f.documento.PageLayout.PageSettings.LeftMargin = "10mm"
            impreso.f.documento.PageLayout.PageSettings.BottomMargin = "10mm"

            impreso.EstableceImpreso(tipoImpresion)


            Try

                ImprimeCabecera(IdProveedor, FacturasRecibidas, FacturaGenero)

                'altura = altura + 7

                ImprimeDetalle(FacturasRecibidas, altura)

                altura = finDetalle + 9

                ImprimeTotales(FacturasRecibidas)

                ImprimePie()

                Select Case tipoImpresion
                    Case NetAgro.TipoImpresion.Preliminar
                        impreso.Imprimir(tipoImpresion, impresora, rutaPDF, archivoPDF)
                    Case NetAgro.TipoImpresion.ExportacionPDF
                        impreso.Imprimir(tipoImpresion, impresora, rutaPDF, archivoPDF)
                    Case Else
                        Dim valoresusuario As New E_valoresusuario(Idusuario, cn)

                        If valoresusuario.LeerId(Idusuario) Then
                            impresora = valoresusuario.VUS_ImpresoraFacturasClientes.Valor
                            impreso.Imprimir(NetAgro.TipoImpresion.ImpresoraSeleccionada, impresora, rutaPDF, archivoPDF)
                        Else
                            impreso.Imprimir(tipoImpresion, impresora, rutaPDF, archivoPDF)
                        End If
                End Select

            Catch ex As Exception

            End Try

        Else
            XtraMessageBox.Show("Error al leer la factura con id: " & IdFactura, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub ImprimeCabecera(ByVal idProveedor As String, ByVal facturasRecibidas As E_Facturasrecibidas, ByVal facturaGenero As Boolean)

        ImprimeLogo(facturasRecibidas)

        altura = altura + 30

        ImprimeDatosProveedor(idProveedor, facturasRecibidas, facturaGenero)

        altura = altura + 17

        If Not IsNothing(col) Then
            'impreso.Cabecera.Cuadro(margen_izquierdo, altura, 190, finDetalle - altura, ancho_linea, Color.Black)
            impreso.Cabecera.LineaH(margen_izquierdo, altura, 190, ancho_linea)

            impreso.Cabecera.Titulo("Albarán", col(1), altura + 1, col(2) - col(1), 5, Estilos.ReducidaBold)
            impreso.Cabecera.Titulo("Fecha", col(2), altura + 1, col(3) - col(2), 5, Estilos.ReducidaBold, "=")
            impreso.Cabecera.Titulo("Referencia", col(3), altura + 1, col(4) - col(3), 5, Estilos.ReducidaBold, "=")
            impreso.Cabecera.Titulo("Importe", col(4), altura + 1, col(5) - col(4), 5, Estilos.ReducidaBold, ">")

            impreso.Cabecera.LineaH(margen_izquierdo, altura + 6, 190, ancho_linea)
            impreso.Cabecera.LineaV(margen_izquierdo, altura, 6, ancho_linea)
            impreso.Cabecera.LineaV(margen_izquierdo + 190, altura, 6, ancho_linea)

            altura = altura + 6

        End If

    End Sub


    Private Sub ImprimeDetalle(FacturasRecibidas As E_Facturasrecibidas, ByRef h As Integer)

        Dim IdFactura As String = (FacturasRecibidas.FRR_Id.Valor & "").Trim
        Dim Tipo As String = (FacturasRecibidas.FRR_tipofactura.Valor & "").Trim
        Dim IdProveedor As String = (FacturasRecibidas.FRR_idproveedor.Valor & "").Trim


        Dim BaseLineas As Integer = altura

        altura = altura + 1


        Dim dt As DataTable = Nothing
        Dim consulta As New Cdatos.E_select


        Select Case Tipo
            Case TipoFacturaRecibida.ComprasGenero

                consulta.SelCampo(AlbEntrada_His.AEH_idalbaran, "IdAlbaran")
                consulta.SelCampo(AlbEntrada.AEN_Albaran, "Albaran", AlbEntrada_His.AEH_idalbaran, AlbEntrada.AEN_IdAlbaran)
                consulta.SelCampo(AlbEntrada.AEN_referencia, "Ref")
                consulta.SelCampo(AlbEntrada_His.AEH_baseimponible, "Importe")
                consulta.SelCampo(AlbEntrada.AEN_Fecha, "Fecha")
                consulta.SelCampo(AlbEntrada.AEN_IdCentro, "CE")
                consulta.WheCampo(AlbEntrada_His.AEH_idfacturafirme, "=", IdFactura)
                consulta.WheCampo(AlbEntrada_His.AEH_idproveedor, "=", IdProveedor)

                Dim sql As String = "SELECT IdAlbaran, Albaran, Ref," & vbCrLf
                sql = sql & " SUM(Importe) as Importe," & vbCrLf
                sql = sql & " Fecha, CE" & vbCrLf
                sql = sql & " FROM " & vbCrLf
                sql = sql & " (" & vbCrLf & consulta.SQL & vbCrLf & ") as G" & vbCrLf
                sql = sql & " GROUP BY IdAlbaran, Albaran, Ref, Fecha, CE" & vbCrLf
                sql = sql & " ORDER BY Fecha"

                dt = AlbEntrada.MiConexion.ConsultaSQL(sql)


            Case TipoFacturaRecibida.GastosCompras

                consulta.SelCampo(AlbEntrada_HisGastos.AHG_idalbaran, "IdAlbaran")
                consulta.SelCampo(AlbEntrada.AEN_Albaran, "Albaran", AlbEntrada_HisGastos.AHG_idalbaran, AlbEntrada.AEN_IdAlbaran)
                consulta.SelCampo(AlbEntrada.AEN_referencia, "Ref")
                consulta.SelCampo(AlbEntrada_HisGastos.AHG_importe, "Importe")
                consulta.SelCampo(AlbEntrada.AEN_Fecha, "Fecha")
                consulta.SelCampo(AlbEntrada.AEN_IdCentro, "CE")
                consulta.WheCampo(AlbEntrada_HisGastos.AHG_idfacturaproveedor, "=", IdFactura)
                consulta.WheCampo(AlbEntrada_HisGastos.AHG_idacreedor, "=", IdProveedor)

                Dim sql As String = "SELECT IdAlbaran, Albaran, Ref," & vbCrLf
                sql = sql & " SUM(Importe) as Importe," & vbCrLf
                sql = sql & " Fecha, CE" & vbCrLf
                sql = sql & " FROM " & vbCrLf
                sql = sql & " (" & vbCrLf & consulta.SQL & vbCrLf & ") as G" & vbCrLf
                sql = sql & " GROUP BY IdAlbaran, Albaran, Ref, Fecha, CE" & vbCrLf
                sql = sql & " ORDER BY Fecha"

                dt = AlbEntrada.MiConexion.ConsultaSQL(sql)


            Case TipoFacturaRecibida.GastosVentas

                Dim sqlConsulta As String = "SELECT 'S' as Tipo, ASG_IdAlbaran AS IdAlbaran, 'SAL ' +  CAST(ASA_Albaran AS Varchar) as Albaran, ASA_Referencia as Ref," & vbCrLf
                sqlConsulta = sqlConsulta & " ASG_Importegastoeuros as Importe, ASA_FechaSalida as Fecha, ASA_IdCentro as CE" & vbCrLf
                sqlConsulta = sqlConsulta & " FROM AlbSalida_Gastos" & vbCrLf
                sqlConsulta = sqlConsulta & " LEFT JOIN AlbSalida on ASA_IdAlbaran = ASG_IdAlbaran" & vbCrLf
                sqlConsulta = sqlConsulta & " WHERE ASG_IdFactura = " & IdFactura & vbCrLf
                sqlConsulta = sqlConsulta & " AND ASG_IdAcreedor = " & IdProveedor & vbCrLf
                sqlConsulta = sqlConsulta & " UNION ALL" & vbCrLf
                sqlConsulta = sqlConsulta & " SELECT 'A' as Tipo, AAG_IdAlbaran AS IdAlbaran, 'ALH ' + CAST(AAH_Albaran AS Varchar) as Albaran, '' as Ref," & vbCrLf
                sqlConsulta = sqlConsulta & " AAG_ImporteGasto as Importe, AAH_FechaSalida as Fecha, AAH_IdCentro as CE" & vbCrLf
                sqlConsulta = sqlConsulta & " FROM AlbSalidaALH_Gastos" & vbCrLf
                sqlConsulta = sqlConsulta & " LEFT JOIN AlbSalidaALH ON AAH_IdAlbaran = AAG_IdAlbaran " & vbCrLf
                sqlConsulta = sqlConsulta & " WHERE AAG_IdFactura = " & IdFactura & vbCrLf
                sqlConsulta = sqlConsulta & " AND AAG_IdAcreedor = " & IdProveedor & vbCrLf


                Dim sql As String = "SELECT IdAlbaran, Albaran, Ref, SUM(Importe) as Importe, Fecha, CE" & vbCrLf
                sql = sql & " FROM " & vbCrLf
                sql = sql & " (" & vbCrLf & sqlConsulta & vbCrLf & ") as G" & vbCrLf
                sql = sql & " GROUP BY Tipo, IdAlbaran, Albaran, Ref, Fecha, CE" & vbCrLf
                sql = sql & " ORDER BY Fecha"

                dt = AlbEntrada.MiConexion.ConsultaSQL(sql)


            Case TipoFacturaRecibida.Materiales

                consulta.SelCampo(AlbMaterial.AMA_Idalb, "IdAlbaran")
                consulta.SelCampo(AlbMaterial.AMA_Numero, "Albaran")
                consulta.SelCampo(AlbMaterial.AMA_referencia, "Ref")
                consulta.SelCampo(AlbMaterial.AMA_Fecha, "Fecha")
                consulta.SelCampo(AlbMaterial.AMA_Idcentro, "CE")
                consulta.SelCampo(AlbMaterial.AMA_importe, "Importe")
                consulta.WheCampo(AlbMaterial.AMA_idfactura, "=", IdFactura)
                consulta.WheCampo(AlbMaterial.AMA_Idacreedor, "=", IdProveedor)

                Dim sqlConsulta As String = consulta.SQL


                Dim sql As String = "SELECT IdAlbaran, Albaran, Ref, " & vbCrLf
                sql = sql & " SUM(Importe) as Importe, Fecha, CE" & vbCrLf
                sql = sql & " FROM " & vbCrLf
                sql = sql & " (" & vbCrLf & sqlConsulta & vbCrLf & ") as G" & vbCrLf
                sql = sql & " GROUP BY IdAlbaran, Albaran, Ref, Fecha, CE" & vbCrLf
                sql = sql & " ORDER BY Fecha"

                dt = AlbEntrada.MiConexion.ConsultaSQL(sql)


                'Case TipoFacturaRecibida.Otros


        End Select




        Dim hInicial As Integer = h
        Dim totalBase As Decimal = 0

        If Not IsNothing(dt) Then

            For Each r As DataRow In dt.Rows
                If CompruebaSaltoPagina(h, 5) Then
                    impreso.Detalle.SaltoPagina()
                    h = hInicial
                End If

                Dim numero As Integer = VaInt(r("Albaran"))
                Dim albaran As String = r("CE").ToString & "-" & numero.ToString("000000")
                Dim fecha As String = VaDate(r("Fecha")).ToString("dd/MM/yyyy")
                Dim referencia As String = r("Ref").ToString
                Dim base As Decimal = VaDec(r("Importe"))

                impreso.Detalle.Titulo(albaran, col(1), h, col(2) - col(1), 5, Estilos.Normal)
                impreso.Detalle.Titulo(fecha, col(2), h, col(3) - col(2), 5, Estilos.Normal, "=")
                impreso.Detalle.Titulo(referencia, col(3), h, col(4) - col(3), 5, Estilos.Normal, "=")
                impreso.Detalle.Titulo(base.ToString("#,##0.00"), col(4), h, col(5) - col(4), 5, Estilos.Normal, ">")

                totalBase = totalBase + base
                h = h + 5

                Application.DoEvents()

            Next

        End If


        altura = altura + 1


        Dim alto_detalle As Integer = altura - BaseLineas
        If alto_detalle < 150 Then
            altura = BaseLineas + 150
        End If


        impreso.Cabecera.LineaH(margen_izquierdo, altura, 190, ancho_linea)
        impreso.Cabecera.LineaV(margen_izquierdo, BaseLineas, altura - BaseLineas, ancho_linea)
        impreso.Cabecera.LineaV(margen_izquierdo + 190, BaseLineas, altura - BaseLineas, ancho_linea)


        altura = altura + 2
        finDetalle = altura

        impreso.Detalle.Cuadro(col(5) - 30, finDetalle, 32, 5, ancho_linea, Color.Black)
        impreso.Detalle.Titulo(totalBase.ToString("#,##0.00"), col(5) - 28, finDetalle, 28, 5, Estilos.NormalBold, ">")

        altura = finDetalle




    End Sub


    Private Sub ImprimeTotales(FacturasRecibidas As E_Facturasrecibidas)


        If CompruebaSaltoPagina(altura, 35) Then
            impreso.Detalle.SaltoPagina()
            altura = 7
        End If


        impreso.Detalle.Titulo("Base imponible", 92, altura, 32, 3, Estilos.ReducidaBold, "=")
        impreso.Detalle.Titulo("%", 124, altura, 10, 3, Estilos.ReducidaBold, "=")
        impreso.Detalle.Titulo("IVA", 134, altura, 32, 3, Estilos.ReducidaBold, "=")
        impreso.Detalle.Titulo("Importe", 168, altura, 32, 3, Estilos.ReducidaBold, "=")

        impreso.Detalle.Cuadro(92, altura + 4, 32, 20, ancho_linea, Color.Black)
        impreso.Detalle.Cuadro(124, altura + 4, 10, 20, ancho_linea, Color.Black)
        impreso.Detalle.Cuadro(134, altura + 4, 32, 20, ancho_linea, Color.Black)
        impreso.Detalle.Cuadro(168, altura + 4, 32, 20, ancho_linea, Color.Black)


        Dim base1 As Decimal = VaDec(FacturasRecibidas.FRR_base1.Valor)
        Dim base2 As Decimal = VaDec(FacturasRecibidas.FRR_base2.Valor)
        Dim base3 As Decimal = VaDec(FacturasRecibidas.FRR_base3.Valor)
        Dim base4 As Decimal = VaDec(FacturasRecibidas.FRR_base4.Valor)

        Dim iva1 As Decimal = VaDec(FacturasRecibidas.FRR_iva1.Valor)
        Dim iva2 As Decimal = VaDec(FacturasRecibidas.FRR_iva2.Valor)
        Dim iva3 As Decimal = VaDec(FacturasRecibidas.FRR_iva3.Valor)
        Dim iva4 As Decimal = VaDec(FacturasRecibidas.FRR_iva4.Valor)

        Dim CuotaIva1 As Decimal = VaDec(FacturasRecibidas.FRR_cuota1.Valor)
        Dim CuotaIva2 As Decimal = VaDec(FacturasRecibidas.FRR_cuota2.Valor)
        Dim CuotaIva3 As Decimal = VaDec(FacturasRecibidas.FRR_cuota3.Valor)
        Dim CuotaIva4 As Decimal = VaDec(FacturasRecibidas.FRR_cuota4.Valor)

        Dim ret As Decimal = VaDec(FacturasRecibidas.FRR_ret.Valor)
        Dim CuotaRet As Decimal = VaDec(FacturasRecibidas.FRR_cuotaret.Valor)

        Dim TotalImporte As Decimal = VaDec(FacturasRecibidas.FRR_totalfac.Valor)


        altura = altura + 5


        'Bases
        If VaDec(base1) <> 0 Then impreso.Detalle.Titulo(VaDec(base1).ToString("#,##0.00"), 95, altura + 1, 24, 5, Estilos.Reducida, ">")
        If VaDec(base2) <> 0 Then impreso.Detalle.Titulo(VaDec(base2).ToString("#,##0.00"), 95, altura + 5, 24, 5, Estilos.Reducida, ">")
        If VaDec(base3) <> 0 Then impreso.Detalle.Titulo(VaDec(base3).ToString("#,##0.00"), 95, altura + 9, 24, 5, Estilos.Reducida, ">")
        If VaDec(base4) <> 0 Then impreso.Detalle.Titulo(VaDec(base4).ToString("#,##0.00"), 95, altura + 13, 24, 5, Estilos.Reducida, ">")

        '%IVA
        If VaDec(iva1) <> 0 And VaDec(CuotaIva1) <> 0 Then impreso.Detalle.Titulo(VaDec(iva1).ToString("#,##0.00"), 123, altura + 1, 10, 5, Estilos.Reducida, ">")
        If VaDec(iva2) <> 0 And VaDec(CuotaIva2) <> 0 Then impreso.Detalle.Titulo(VaDec(iva2).ToString("#,##0.00"), 123, altura + 5, 10, 5, Estilos.Reducida, ">")
        If VaDec(iva3) <> 0 And VaDec(CuotaIva3) <> 0 Then impreso.Detalle.Titulo(VaDec(iva3).ToString("#,##0.00"), 123, altura + 9, 10, 5, Estilos.Reducida, ">")
        If VaDec(iva4) <> 0 And VaDec(CuotaIva4) <> 0 Then impreso.Detalle.Titulo(VaDec(iva4).ToString("#,##0.00"), 123, altura + 13, 10, 5, Estilos.Reducida, ">")

        'CuotaIVA
        If VaDec(CuotaIva1) <> 0 Then impreso.Detalle.Titulo(VaDec(CuotaIva1).ToString("#,##0.00"), 137, altura + 1, 22, 5, Estilos.Reducida, ">")
        If VaDec(CuotaIva2) <> 0 Then impreso.Detalle.Titulo(VaDec(CuotaIva2).ToString("#,##0.00"), 137, altura + 5, 22, 5, Estilos.Reducida, ">")
        If VaDec(CuotaIva3) <> 0 Then impreso.Detalle.Titulo(VaDec(CuotaIva3).ToString("#,##0.00"), 137, altura + 9, 22, 5, Estilos.Reducida, ">")
        If VaDec(CuotaIva4) <> 0 Then impreso.Detalle.Titulo(VaDec(CuotaIva4).ToString("#,##0.00"), 137, altura + 13, 22, 5, Estilos.Reducida, ">")


        

        Dim TotalBase1 As Decimal = VaDec(base1) + VaDec(CuotaIva1)
        Dim TotalBase2 As Decimal = VaDec(base2) + VaDec(CuotaIva2)
        Dim TotalBase3 As Decimal = VaDec(base3) + VaDec(CuotaIva3)
        Dim TotalBase4 As Decimal = VaDec(base4) + VaDec(CuotaIva4)

        'Dim TotalFactura As Decimal = TotalBase1 + TotalBase2 + TotalBase3 + TotalBase4

        If TotalBase1 <> 0 Then impreso.Detalle.Titulo(TotalBase1.ToString("#,##0.00"), margen_izquierdo + 157, altura + 1, 25, 5, Estilos.Reducida, ">")
        If TotalBase2 <> 0 Then impreso.Detalle.Titulo(TotalBase2.ToString("#,##0.00"), margen_izquierdo + 157, altura + 5, 25, 5, Estilos.Reducida, ">")
        If TotalBase3 <> 0 Then impreso.Detalle.Titulo(TotalBase3.ToString("#,##0.00"), margen_izquierdo + 157, altura + 9, 25, 5, Estilos.Reducida, ">")
        If TotalBase4 <> 0 Then impreso.Detalle.Titulo(TotalBase4.ToString("#,##0.00"), margen_izquierdo + 157, altura + 13, 25, 5, Estilos.Reducida, ">")

        altura = altura + 22
        impreso.Detalle.Cuadro(97, altura, 24, 7, ancho_linea, Color.Black)
        impreso.Detalle.Cuadro(168, altura, 32, 7, ancho_linea, Color.Black)
        altura = altura + 1


        'Retención
        impreso.Detalle.Titulo("Ret.", 74, altura, 20, 6, Estilos.NormalBold, ">")
        impreso.Detalle.Titulo(CuotaRet.ToString("#,##0.00"), 98, altura, 22, 6, Estilos.Normal, ">")



        'Total factura
        impreso.Detalle.Titulo("TOTAL FACTURA", 121, altura, 40, 6, Estilos.GrandeBold, ">")
        impreso.Detalle.Titulo(TotalImporte.ToString("#,##0.00"), 169, altura, 30, 6, Estilos.Grande, ">")


    End Sub


    Private Sub ImprimePie()

    End Sub


    Private Sub ImprimeLogo(ByVal facturasRecibidas As E_Facturasrecibidas)
        Dim urlLogo As String = "logo.png"

        Select Case VaInt(facturasRecibidas.FRR_IdEmpresa.Valor)
            Case 0, 1
                urlLogo = "logo.png"
            Case Else
                urlLogo = "logo_" & facturasRecibidas.FRR_IdEmpresa.Valor & ".png"
        End Select

        If IO.File.Exists(Application.StartupPath & "\" & urlLogo) Then
            Try
                Dim logo As Image = Image.FromFile(Application.StartupPath & "\" & urlLogo)
                Dim w As Integer = Math.Round(logo.Width * 0.2646)
                Dim h As Integer = Math.Round(logo.Height * 0.2646)
                impreso.Cabecera.Imagen(logo, margen_izquierdo, altura, w, h)
            Catch ex As Exception
            End Try
        End If
    End Sub


    Private Sub ImprimeDatosProveedor(ByVal idProveedor As String, ByVal facturasRecibidas As E_Facturasrecibidas, _
                                      ByVal facturaGenero As Boolean)
        Dim nombre As String = ""
        Dim domicilio As String = ""
        Dim cPostal As String = ""
        Dim poblacion As String = ""
        Dim provincia As String = ""
        Dim pais As String = ""
        Dim fechaFactura As String = ""
        Dim numFactura As String = ""
        Dim referencia As String = ""
        Dim nif As String = ""
        Dim codigo As Integer = 0

        impreso.Cabecera.Cuadro(margen_izquierdo, altura, 100, 32, ancho_linea, Color.Black)

        If facturaGenero Then
            Dim agricultores As New E_Agricultores(Idusuario, cn)

            If agricultores.LeerId(idProveedor) Then
                nombre = agricultores.AGR_Nombre.Valor.ToString
                domicilio = agricultores.AGR_Domicilio.Valor.ToString
                cPostal = agricultores.AGR_Cpostal.Valor.ToString
                poblacion = agricultores.AGR_Poblacion.Valor.ToString
                provincia = agricultores.AGR_Provincia.Valor.ToString

                Dim idPais As String = agricultores.AGR_IdPais.Valor.ToString
                Dim paises As New E_Paises(Idusuario, CnComun)

                If paises.LeerId(idPais) Then
                    pais = paises.Nombre.Valor.ToString
                End If

                nif = agricultores.AGR_Nif.Valor.ToString
                codigo = VaInt(agricultores.AGR_IdAgricultor.Valor)
            End If
        Else
            Dim acreedores As New E_Acreedores(Idusuario, cn)

            If acreedores.LeerId(idProveedor) Then
                nombre = acreedores.ACR_Nombre.Valor.ToString
                domicilio = acreedores.ACR_Domicilio.Valor.ToString
                cPostal = acreedores.ACR_CPostal.Valor.ToString
                poblacion = acreedores.ACR_Poblacion.Valor.ToString
                provincia = acreedores.ACR_Provincia.Valor.ToString
                pais = ""
                nif = acreedores.ACR_Nif.Valor.ToString
                codigo = VaInt(acreedores.ACR_Codigo.Valor)
            End If
        End If

        impreso.Cabecera.Titulo(nombre, margen_izquierdo + 5, altura + 1, 91, 5, Estilos.GrandeBold)
        impreso.Cabecera.Titulo(domicilio, margen_izquierdo + 5, altura + 7, 91, 5, Estilos.GrandeBold)
        impreso.Cabecera.Titulo(cPostal & " " & poblacion & "", margen_izquierdo + 5, altura + 13, 91, 5, Estilos.GrandeBold)
        impreso.Cabecera.Titulo(provincia, margen_izquierdo + 5, altura + 19, 91, 5, Estilos.GrandeBold)
        impreso.Cabecera.Titulo(pais, margen_izquierdo + 5, altura + 25, 91, 5, Estilos.GrandeBold)

        altura = altura + 4

        If VaDate(facturasRecibidas.FRR_fechafactura.Valor.ToString) > VaDate("") Then
            fechaFactura = VaDate(facturasRecibidas.FRR_fechafactura.Valor.ToString).ToString("dd/MM/yyyy")
        End If

        numFactura = facturasRecibidas.FRR_idcentro.Valor.ToString & "-" & facturasRecibidas.FRR_numero.Valor.ToString
        referencia = facturasRecibidas.FRR_numerofactura.Valor.ToString

        impreso.Cabecera.Cuadro(120 + 25, altura, 50, 10, ancho_linea, Color.Black)
        impreso.Cabecera.LineaH(120 + 25, altura + 5, 50, ancho_linea, Color.Black)
        impreso.Cabecera.LineaV(170, altura, 10, ancho_linea, Color.Black)
        impreso.Cabecera.Titulo("FECHA FRA.", 148, altura + 1, 22, 5, Estilos.ReducidaBold)
        impreso.Cabecera.Titulo(fechaFactura, 146, altura + 6, 23, 5, Estilos.Reducida, "=")
        impreso.Cabecera.Titulo("FACTURA", 175, altura + 1, 22, 5, Estilos.ReducidaBold)
        impreso.Cabecera.Titulo(numFactura, 175, altura + 6, 26, 5, Estilos.Reducida, "=")

        altura = altura + 13

        impreso.Cabecera.Cuadro(120, altura, 75, 10, ancho_linea, Color.Black)
        impreso.Cabecera.LineaH(120, altura + 5, 75, ancho_linea, Color.Black)
        impreso.Cabecera.LineaV(145, altura, 10, ancho_linea, Color.Black)
        impreso.Cabecera.LineaV(170, altura, 10, ancho_linea, Color.Black)
        impreso.Cabecera.Titulo("REF. FACTURA", 123, altura + 1, 22, 5, Estilos.ReducidaBold)
        impreso.Cabecera.Titulo(referencia, 121, altura + 6, 23, 5, Estilos.Reducida, "=")
        impreso.Cabecera.Titulo("N.I.F.", 148, altura + 1, 22, 5, Estilos.ReducidaBold)
        impreso.Cabecera.Titulo(nif, 146, altura + 6, 23, 5, Estilos.Reducida, "=")
        impreso.Cabecera.Titulo("CODIGO", 175, altura + 1, 22, 5, Estilos.ReducidaBold)
        impreso.Cabecera.Titulo(codigo.ToString("00000"), 171, altura + 6, 24, 5, Estilos.Reducida, "=")
    End Sub

    Private Function CompruebaSaltoPagina(altura As Integer, hLinea As Integer) As Boolean
        Dim salto As Boolean = False

        If altura + hLinea > 282 Then
            salto = True
        End If

        Return salto
    End Function

End Module
