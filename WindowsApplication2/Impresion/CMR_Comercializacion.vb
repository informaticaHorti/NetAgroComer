Imports DevExpress.XtraEditors
Imports System.Drawing

Module CMR_Comercializacion

    Public Sub ImprimirCMR_Comercializacion(IdCMR As String, TipoImpresion As TipoImpresion, Impresora As String, Optional rutaPDF As String = "")

        If VaInt(IdCMR) > 0 Then

            Dim Cmr As New E_Cmr(Idusuario, cn)
            Dim Cmr_lineas As New E_Cmr_lineas(Idusuario, cn)
            Dim FamGen As New E_FamiliasGeneros(Idusuario, cn)
            Dim Pais As String = ""

            If Cmr.LeerId(IdCMR) Then

                'DatosEmpresa
                Dim DatosEmpresa As New DatosEmpresa()
                DatosEmpresa.ObtenerDatosEmpresa()

                Dim Cliente As New E_Clientes(Idusuario, cn)
                If Cliente.LeerId(Cmr.CMR_Idcliente.Valor) Then

                    'Meollo
                    Dim Informe As New miInforme(False)
                    Informe.Contenedor.PaperKind = Printing.PaperKind.A4
                    Informe.Contenedor.PrintingSystem.ShowMarginsWarning = False

                    Informe.Contenedor.MinMargins.Top = 0
                    Informe.Contenedor.MinMargins.Left = 0
                    Informe.Contenedor.MinMargins.Right = 0
                    Informe.Contenedor.MinMargins.Bottom = 0

                    Informe.Contenedor.Margins.Top = 0
                    Informe.Contenedor.Margins.Left = 0
                    Informe.Contenedor.Margins.Right = 0
                    Informe.Contenedor.Margins.Bottom = 0


                    Dim miCMRComercializacion As New miFactura()
                    Dim err As New Errores

                    'Meollo
                    Dim fuente As New Font("Courier New", 11, FontStyle.Bold)
                    Dim fuente_menor As New Font("Courier New", 8, FontStyle.Bold)

                    'Datos Remitente
                    ImprimeDatosRemitente(miCMRComercializacion, DatosEmpresa, fuente)

                    'Datos Consignatario
                    ImprimeDatosConsignatario(miCMRComercializacion, Cliente, Cmr, fuente, fuente_menor)

                    'Lugar de entrega
                    ImprimeDestinoMercancia(miCMRComercializacion, Cliente, Cmr, fuente)

                    'Lugar y fecha de carga
                    ImprimeLugarFechaCarga(miCMRComercializacion, Cmr, DatosEmpresa, fuente)

                    'Documentos anexos
                    ImprimeDocumentosAnexos(miCMRComercializacion, Cmr, fuente)

                    'Detalle
                    ImprimeDetalle(miCMRComercializacion, Cmr, fuente)

                    'Imprime Instrucciones
                    ImprimeInstrucciones(miCMRComercializacion, Cmr, fuente)

                    'Formalizado en 
                    ImprimeFormalizado(miCMRComercializacion, DatosEmpresa, fuente)

                    'Añadimos el documento al informe
                    Informe.AñadeDetalles(miCMRComercializacion)

                    'Impresión / previsualización / exportación
                    Select Case TipoImpresion

                        Case TipoImpresion.Preliminar
                            Informe.Preliminar(DevExpress.LookAndFeel.UserLookAndFeel.Default)

                        Case TipoImpresion.ImpresoraSeleccionada
                            If Impresora.Trim <> "" Then
                                Informe.ImpresionDirecta(Impresora)
                            Else
                                Informe.ImpresionDirecta()
                            End If

                        Case TipoImpresion.ExportacionPDF
                            If rutaPDF.Trim <> "" Then
                                Informe.Contenedor.CreateDocument()
                                Try
                                    Dim options As New DevExpress.XtraPrinting.PdfExportOptions
                                    options.Compressed = True
                                    Informe.Contenedor.ExportToPdf(rutaPDF, options)

                                Catch ex As Exception
                                    err.Muestraerror("Error al exportar el documento con id" & IdCMR & " a PDF", "ImprimirCMR_Comercializacion", ex.Message)
                                End Try

                            Else
                                Informe.ImpresionDirecta()
                            End If

                        Case Else
                            Informe.ImpresionDirecta()
                    End Select


                    Informe.Dispose()

                Else
                    XtraMessageBox.Show("No se encontró el Cliente Id " & VaInt(Cliente.CLI_Codigo.Valor).ToString, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Else
                XtraMessageBox.Show("No se encontró el CMR Id " & VaInt(Cmr.CMR_Idcliente.Valor).ToString, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Else
            XtraMessageBox.Show("No hay datos que imprimir para el CMR Comercialización", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub ImprimeDatosRemitente(ByRef miCMRComercializacion As miFactura, DatosEmpresa As DatosEmpresa, fuente As Font)

        'miCMRComercializacion.Titulo(DatosEmpresa.NombreEmpresa, 18, 24, 95, 4, milinea.stilos.Custom, , fuente)
        miCMRComercializacion.Titulo(MiMaletin.NombreEmpresa, 18, 24, 95, 4, milinea.stilos.Custom, , fuente)
        miCMRComercializacion.Titulo(DatosEmpresa.Domicilio, 18, 29, 95, 4, milinea.stilos.Custom, , fuente)
        miCMRComercializacion.Titulo(DatosEmpresa.CPostal & "-" & DatosEmpresa.Poblacion & "(" & DatosEmpresa.Provincia & ")", 18, 34, 95, 4, milinea.stilos.Custom, , fuente)

    End Sub

    Private Sub ImprimeDatosConsignatario(ByRef miCMRComercializacion As miFactura, Cliente As E_Clientes, CMR As E_Cmr, fuente As Font, fuente_menor As Font)

        Dim Paises As New E_Paises(Idusuario, CnComun)
        Dim clientesDescargas As New E_ClientesDescargas(Idusuario, cn)
        Dim Pais As String = ""


        miCMRComercializacion.Titulo(Cliente.CLI_Nombre.Valor & "", 18, 48, 85, 4, milinea.stilos.Custom, , fuente)


        Dim IdDestino As String = CMR.CMR_Iddestino.Valor
        If clientesDescargas.LeerId(IdDestino) Then

            Dim IdPais As String = clientesDescargas.CLD_IdPais.Valor
            If Paises.LeerId(IdPais) Then
                Pais = Paises.Nombre.Valor
            End If

            miCMRComercializacion.Titulo(clientesDescargas.CLD_Domicilio.Valor & "", 18, 53, 85, 4, milinea.stilos.Custom, , fuente)
            miCMRComercializacion.Titulo(clientesDescargas.CLD_Poblacion.Valor & " - " & Pais, 18, 58, 85, 4, milinea.stilos.Custom, , fuente_menor)

        Else

            If Paises.LeerId(Cliente.CLI_IdPais.Valor) Then
                Pais = Paises.Nombre.Valor
            End If

            miCMRComercializacion.Titulo(Cliente.CLI_Domicilio.Valor & "", 18, 53, 85, 4, milinea.stilos.Custom, , fuente)
            miCMRComercializacion.Titulo(Cliente.CLI_Poblacion.Valor & " - " & Pais, 18, 58, 85, 4, milinea.stilos.Custom, , fuente_menor)
        End If
    End Sub

    Private Sub ImprimeDestinoMercancia(ByRef miCMRComercializacion As miFactura, Cliente As E_Clientes, CMR As E_Cmr, fuente_menor As Font)
        Dim Paises As New E_Paises(Idusuario, CnComun)
        Dim clientesDescargas As New E_ClientesDescargas(Idusuario, cn)
        Dim Pais As String = ""



        Dim IdDestino As String = CMR.CMR_Iddestino.Valor

        If clientesDescargas.LeerId(IdDestino) Then

            Dim IdPais As String = clientesDescargas.CLD_IdPais.Valor
            If Paises.LeerId(IdPais) Then
                Pais = Paises.Nombre.Valor
            End If

            'miCMRComercializacion.Titulo(clientesDescargas.CLD_Poblacion.Valor & "", 18, 77, 85, 4, milinea.stilos.Custom, , fuente_menor)
            miCMRComercializacion.Titulo(clientesDescargas.CLD_Poblacion.Valor & " - " & Pais, 18, 77, 85, 4, milinea.stilos.Custom, , fuente_menor)
        Else

            If Paises.LeerId(Cliente.CLI_IdPais.Valor) Then
                Pais = Paises.Nombre.Valor
            End If

            'miCMRComercializacion.Titulo(Cliente._Poblacion.Valor & "", 18, 77, 85, 4, milinea.stilos.Custom, , fuente_menor)
            miCMRComercializacion.Titulo(Cliente.CLI_Poblacion.Valor & " - " & Pais, 18, 77, 85, 4, milinea.stilos.Custom, , fuente_menor)
        End If

    End Sub

    Private Sub ImprimeLugarFechaCarga(miCMRComercializacion As miFactura, Cmr As E_Cmr, DatosEmpresa As DatosEmpresa, fuente As Font)

        Dim fecha As String = Today.ToString("dd-MM-yyyy")
        Dim LugarCarga As String = DatosEmpresa.Poblacion & " - " & DatosEmpresa.Provincia

        miCMRComercializacion.Titulo(fecha, 70, 90, 30, 4, milinea.stilos.Custom, , fuente)
        miCMRComercializacion.Titulo(LugarCarga, 18, 95, 82, 4, milinea.stilos.Custom, "=", fuente)

    End Sub

    Private Sub ImprimeDocumentosAnexos(miCMRComercializacion As miFactura, Cmr As E_Cmr, fuente As Font)

        Dim doc1 As String = Cmr.CMR_DocAnexos1.Valor
        Dim doc2 As String = Cmr.CMR_DocAnexos2.Valor

        miCMRComercializacion.Titulo(doc1, 18, 105, 70, 4, milinea.stilos.Custom, "=", fuente)
        miCMRComercializacion.Titulo(doc2, 18, 110, 70, 4, milinea.stilos.Custom, "=", fuente)

    End Sub

    Private Sub ImprimeDetalle(miCMRComercializacion As miFactura, Cmr As E_Cmr, fuente As Font)

        Dim altura As Integer = 130
        Dim sql As String = "Select cmr_lineas.CML_idcmrlin AS IdCmrlin, " & vbCrLf
        sql = sql & "cmr.CMR_idcmr AS IdCmr, " & vbCrLf
        sql = sql & "SUM(cmr_lineas.CML_bultos) as Bultos," & vbCrLf
        sql = sql & " cmr_lineas.CML_envase AS Envase," & vbCrLf
        sql = sql & "FamiliasGeneros.FAG_nombre AS Familia, MAR_Nombre as Marca," & vbCrLf
        sql = sql & "SUM(cmr_lineas.CML_kbrutos) AS Kilos  from Cmr_lineas" & vbCrLf
        sql = sql & "LEFT OUTER JOIN cmr ON cmr_lineas.CML_idcmrlin = cmr.CMR_idcmr" & vbCrLf
        sql = sql & "LEFT OUTER JOIN FamiliasGeneros ON cmr_lineas.CML_idfamilia = FamiliasGeneros.FAG_idfamilia" & vbCrLf
        sql = sql & " LEFT JOIN Marcas ON MAR_IdMarca = CML_IdMarca" & vbCrLf
        sql = sql & "where Cmr_lineas.CML_Idcmr = " & Cmr.CMR_IdCmr.Valor & vbCrLf
        sql = sql & "group by CML_IdCMRLin, CMR_IdCmr, CML_Envase, FAG_Nombre, MAR_Nombre" & vbCrLf
        sql = sql & " ORDER BY FAG_Nombre, CML_Envase" & vbCrLf

        Dim dt As DataTable = Cmr.MiConexion.ConsultaSQL(sql)

        '18-37 = 19
        '42-66 = 24
        '68-127 = 59
        '(kg) 152-170 = 18

        For Each row As DataRow In dt.Rows

            Dim Bultos As String = VaDec(row("Bultos")).ToString("#,##0")
            Dim Kilos As String = VaDec(row("Kilos")).ToString("#,##0")
            Dim Envase As String = row("Envase").ToString & ""
            Dim Genero As String = row("Familia").ToString & ""
            Dim Marca As String = row("Marca").ToString & ""

            
            'miCMRComercializacion.Titulo(Bultos, 18, altura, 19, 4, milinea.stilos.Custom, ">", fuente)
            'miCMRComercializacion.Titulo(Envase, 42, altura, 24, 4, milinea.stilos.Custom, "", fuente)
            'miCMRComercializacion.Titulo(Genero, 68, altura, 59, 4, milinea.stilos.Custom, "", fuente)
            'miCMRComercializacion.Titulo(Marca, 128, altura, 23, 4, milinea.stilos.Custom, "", fuente)
            'miCMRComercializacion.Titulo(Kilos, 152, altura, 18, 4, milinea.stilos.Custom, ">", fuente)


            miCMRComercializacion.Titulo(Marca, 18, altura, 23, 4, milinea.stilos.Custom, "", fuente)
            miCMRComercializacion.Titulo(Bultos, 42, altura, 19, 4, milinea.stilos.Custom, ">", fuente)
            miCMRComercializacion.Titulo(Envase, 62, altura, 24, 4, milinea.stilos.Custom, "", fuente)
            miCMRComercializacion.Titulo(Genero, 87, altura, 59, 4, milinea.stilos.Custom, "", fuente)
            miCMRComercializacion.Titulo(Kilos, 148, altura, 18, 4, milinea.stilos.Custom, ">", fuente)



            
            altura = altura + 4
        Next

    End Sub


    Private Sub ImprimeInstrucciones(ByRef miCMRComercializacion As miFactura, Cmr As E_Cmr, fuente As Font)

        Dim ins1 As String = Cmr.CMR_Instrucciones1.Valor
        Dim ins2 As String = Cmr.CMR_Instrucciones2.Valor
        Dim ins3 As String = Cmr.CMR_Instrucciones3.Valor
        Dim ins4 As String = Cmr.CMR_Instrucciones4.Valor

        miCMRComercializacion.Titulo(ins1, 18, 200, 100, 4, milinea.stilos.Custom, "=", fuente)
        miCMRComercializacion.Titulo(ins2, 18, 205, 100, 4, milinea.stilos.Custom, "=", fuente)
        miCMRComercializacion.Titulo(ins3, 18, 210, 100, 4, milinea.stilos.Custom, "=", fuente)
        miCMRComercializacion.Titulo(ins4, 18, 215, 100, 4, milinea.stilos.Custom, "=", fuente)
    End Sub
    Private Sub ImprimeFormalizado(ByRef miCMRComercializacion As miFactura, DatosEmpresa As DatosEmpresa, fuente As Font)
        Dim fecha As String = Today.ToString("dd-MM-yyyy")
        miCMRComercializacion.Titulo(DatosEmpresa.Poblacion & " " & fecha, 33, 253, 77, 4, milinea.stilos.Custom, , fuente)
    End Sub
End Module
