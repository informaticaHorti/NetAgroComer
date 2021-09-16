Imports System.Drawing


Module C1_Reclamacion


    Dim ancho_linea As Decimal = 3
    Dim margen_izquierdo As Integer = 19

    Dim fuente_titulo As New Font("Courier New", 16, FontStyle.Bold)
    Dim fuente_negrita As New Font("Courier New", 12, FontStyle.Bold)
    Dim fuente_normal As New Font("Courier New", 12)
    Dim fuente_reducida As New Font("Courier New", 10)


    Public Sub C1_ImprimirReclamacion(IdReclamacion As String, TipoImpresion As TipoImpresion,
                                        Optional Impresora As String = "",
                                        Optional rutaPDF As String = "",
                                        Optional archivoPDF As String = "")


        Dim Reclama As New E_Reclama(Idusuario, cn)
        If Reclama.LeerId(IdReclamacion) Then

            Try

                Dim AlbSalida_Lineas As New E_AlbSalida_lineas(Idusuario, cn)
                Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
                Dim Clientes As New E_Clientes(Idusuario, cn)

                Dim IdLinea As String = (Reclama.RCL_Idlinalb.Valor & "").Trim
                If VaInt(IdLinea) > 0 Then AlbSalida_Lineas.LeerId(IdLinea)

                Dim IdAlbaran As String = (AlbSalida_Lineas.ASL_idalbaran.Valor & "").Trim
                If VaInt(IdAlbaran) > 0 Then AlbSalida.LeerId(IdAlbaran)

                Dim IdCliente As String = (AlbSalida.ASA_idcliente.Valor & "").Trim
                If VaInt(IdCliente) > 0 Then Clientes.LeerId(IdCliente)



                Dim Impreso As New Impreso
                Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
                Impreso.f.documento.PageLayout.PageSettings.Landscape = False


                Impreso.f.documento.PageLayout.PageSettings.TopMargin = "0mm"
                Impreso.f.documento.PageLayout.PageSettings.BottomMargin = "0mm"
                Impreso.f.documento.PageLayout.PageSettings.LeftMargin = "0mm"
                Impreso.f.documento.PageLayout.PageSettings.RightMargin = "0mm"

                Impreso.EstableceImpreso(TipoImpresion)


                Dim altura As Integer = 41


              
                Try

                    'Marco
                    ImprimeMarcoDocumento(Impreso)

                    'Cabecera
                    ImprimeCabecera(Impreso)

                    'Recepción
                    ImprimeRecepcion(Impreso, altura, Reclama)

                    'Datos Cliente
                    ImprimeDatosCliente(Impreso, altura, Reclama)

                    'Datos Reclamación
                    ImprimeDatosReclamacion(Impreso, altura, AlbSalida, Reclama)

                    'Acciones a desarrollar
                    ImprimeAcciones(Impreso, altura, Reclama)


                    'Impresión / previsualización / exportación
                    Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)

                Catch ex As Exception

                End Try


            Catch ex As Exception
                MsgBox("Error al imprimir el vale de gastos: " & ex.Message)
            End Try
        
        Else
            MsgBox("No puedo leer el albarán con Id: " & IdReclamacion)
        End If


    End Sub


    Private Sub ImprimeMarcoDocumento(ByRef Impreso As Impreso)

        Impreso.Cabecera.Cuadro(15, 15, 180, 275, ancho_linea, Color.Black)
        Impreso.Cabecera.LineaH(15, 35, 180, ancho_linea)
        Impreso.Cabecera.LineaV(55, 15, 20, ancho_linea)
        Impreso.Cabecera.LineaV(155, 15, 20, ancho_linea)
        Impreso.Cabecera.LineaH(15, 75, 180, ancho_linea)
        Impreso.Cabecera.LineaH(15, 105, 180, ancho_linea)
        Impreso.Cabecera.LineaH(15, 220, 180, ancho_linea)
        Impreso.Cabecera.LineaH(15, 290, 180, ancho_linea)

    End Sub


    Private Sub ImprimeCabecera(ByRef Impreso As Impreso)

        Try
            Dim fichero_logo As String = "logo.png"

            Select Case MiMaletin.IdEmpresaCTB
                Case 1
                    fichero_logo = "logo.png"
                Case Else
                    fichero_logo = "logo_" & MiMaletin.IdEmpresaCTB.ToString & ".png"
            End Select


            Dim Imagen As Image = Image.FromFile(Application.StartupPath & "\" & fichero_logo)
            Impreso.Cabecera.Imagen(Imagen, 16, 16, 38, 13)
        Catch ex As Exception

        End Try

        Impreso.Cabecera.Titulo("REGISTRO DE RECLAMACIÓN", 56, 21, 98, 6, Estilos.Custom, "=", , fuente_titulo)
        'Impreso.Cabecera.Titulo("PC-06/RR-02", 158, 18, 35, 4, Estilos.Custom, , , fuente_negrita)
        'Impreso.Cabecera.Titulo("Ed.01/Rev.02", 158, 22, 35, 4, Estilos.Custom, , , fuente_negrita)


    End Sub


    Private Sub ImprimeRecepcion(ByRef Impreso As Impreso, ByRef altura As Integer, Reclama As E_Reclama)

        'Dim Fecha As String = ""
        'If VaDate(Reclama.RCL_Fecha.Valor) > VaDate("") Then Fecha = VaDate(Reclama.RCL_Fecha.Valor).ToString("dd/MM/yyyy")
        'Dim Numero As String = Reclama.RCL_Numero.Valor & ""

        Impreso.Cabecera.Titulo("RECEPCIÓN:", margen_izquierdo, altura, 30, 6, Estilos.Custom, , , fuente_negrita)
        altura = altura + 7
        Impreso.Cabecera.Titulo("Fecha de recepción:", margen_izquierdo, altura, 50, 5, Estilos.Custom, , , fuente_negrita)
        'Impreso.Cabecera.Titulo(Fecha, margen_izquierdo + 60, altura, 30, 5, Estilos.Custom, , , fuente_negrita)
        Impreso.Cabecera.Titulo("Nº de registro:", margen_izquierdo + 110, altura, 40, 5, Estilos.Custom, , , fuente_negrita)
        'Impreso.Cabecera.Titulo(Numero, margen_izquierdo + 152, altura, 22, 5, Estilos.Custom, , , fuente_normal)
        altura = altura + 7
        Impreso.Cabecera.Titulo("Recibido por:", margen_izquierdo, altura, 35, 5, Estilos.Custom, , , fuente_negrita)
        Impreso.Cabecera.Cuadro(margen_izquierdo + 37, altura, 4, 4, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo("Gerencia", margen_izquierdo + 44, altura, 25, 5, Estilos.Custom, , , fuente_normal)
        Impreso.Cabecera.Cuadro(margen_izquierdo + 75, altura, 4, 4, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo("Dpto. Comercial", margen_izquierdo + 82, altura, 40, 5, Estilos.Custom, , , fuente_normal)
        Impreso.Cabecera.Cuadro(margen_izquierdo + 130, altura, 4, 4, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo("Dpto. Calidad", margen_izquierdo + 137, altura, 35, 5, Estilos.Custom, , , fuente_normal)
        altura = altura + 7
        Impreso.Cabecera.Titulo("Método de recepción:", margen_izquierdo, altura, 55, 5, Estilos.Custom, , , fuente_negrita)
        Impreso.Cabecera.Cuadro(margen_izquierdo + 58, altura, 4, 4, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo("Fax/Carta", margen_izquierdo + 65, altura, 25, 5, Estilos.Custom, , , fuente_normal)
        Impreso.Cabecera.Cuadro(margen_izquierdo + 104, altura, 4, 4, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo("E-Mail", margen_izquierdo + 111, altura, 20, 5, Estilos.Custom, , , fuente_normal)
        Impreso.Cabecera.Cuadro(margen_izquierdo + 143, altura, 4, 4, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo("Teléfono", margen_izquierdo + 150, altura, 22, 5, Estilos.Custom, , , fuente_normal)
        altura = altura + 15

    End Sub


    Private Sub ImprimeDatosCliente(ByRef Impreso As Impreso, ByRef altura As Integer, Reclama As E_Reclama)

        'Dim Empresa As String = ""
        'Dim IdLinea As String = Reclama.RCL_Idlinalb.Valor

        'If VaInt(IdLinea) > 0 Then

        '    Dim sql As String = "SELECT CLI_Nombre as Cliente FROM AlbSalida_Lineas LEFT JOIN AlbSalida ON ASA_IdAlbaran = ASL_IdAlbaran LEFT JOIN Clientes ON CLI_IdCliente = ASA_IdCliente WHERE ASL_IdLinea = " & IdLinea
        '    Dim dt As DataTable = Reclama.MiConexion.ConsultaSQL(sql)

        '    If Not IsNothing(dt) Then
        '        If dt.Rows.Count > 0 Then
        '            Empresa = (dt.Rows(0)("Cliente").ToString & "").Trim
        '        End If
        '    End If

        'End If


        Impreso.Cabecera.Titulo("DATOS DEL CLIENTE:", margen_izquierdo, altura, 50, 6, Estilos.Custom, , , fuente_negrita)
        altura = altura + 10
        Impreso.Cabecera.Titulo("Departamento/persona que efectúa la reclamación:", margen_izquierdo, altura, 125, 5, Estilos.Custom, , , fuente_negrita)
        altura = altura + 10
        Impreso.Cabecera.Titulo("Empresa:", margen_izquierdo, altura, 20, 5, Estilos.Custom, , , fuente_negrita)
        'Impreso.Cabecera.Titulo(Empresa, margen_izquierdo + 40, altura, 130, 5, Estilos.Custom, , , fuente_negrita)

        altura = altura + 12


    End Sub


    Private Sub ImprimeDatosReclamacion(ByRef Impreso As Impreso, ByRef altura As Integer, AlbSalida As E_AlbSalida, Reclama As E_Reclama)


        Dim Albaran As String = VaInt(AlbSalida.ASA_albaran.Valor).ToString("000000")
        Dim Fecha As String = ""
        If VaDate(AlbSalida.ASA_fechasalida.Valor) > VaDate("") Then Fecha = VaDate(AlbSalida.ASA_fechasalida.Valor).ToString("dd/MM/yyyy")
        Dim Remolque As String = (AlbSalida.ASA_matricularemolque.Valor & "").Trim

        Dim Descripcion1 As String = (Reclama.RCL_observaciones1.Valor)
        Dim Descripcion2 As String = (Reclama.RCL_observaciones2.Valor)
        Dim Descripcion3 As String = (Reclama.RCL_observaciones3.Valor)
        Dim Descripcion4 As String = (Reclama.RCL_observaciones4.Valor)

        Dim Conclusiones1 As String = (Reclama.RCL_Conclusiones1.Valor)
        Dim Conclusiones2 As String = (Reclama.RCL_Conclusiones2.Valor)
        Dim Conclusiones3 As String = (Reclama.RCL_Conclusiones3.Valor)
        Dim Conclusiones4 As String = (Reclama.RCL_Conclusiones4.Valor)


        Impreso.Cabecera.Titulo("DATOS DE LA RECLAMACIÓN:", margen_izquierdo, altura, 70, 6, Estilos.Custom, , , fuente_negrita)
        altura = altura + 6
        Impreso.Cabecera.Titulo("NºAlbarán:", margen_izquierdo, altura, 25, 5, Estilos.Custom, , , fuente_negrita)
        Impreso.Cabecera.Titulo(Albaran, margen_izquierdo + 25, altura, 17, 5, Estilos.Custom, , , fuente_normal)
        Impreso.Cabecera.Titulo("Fecha de carga:", margen_izquierdo + 45, altura, 40, 5, Estilos.Custom, , , fuente_negrita)
        Impreso.Cabecera.Titulo(Fecha, margen_izquierdo + 85, altura, 30, 5, Estilos.Custom, , , fuente_normal)
        Impreso.Cabecera.Titulo("Matrícula:", margen_izquierdo + 120, altura, 25, 5, Estilos.Custom, , , fuente_negrita)
        Impreso.Cabecera.Titulo(Remolque, margen_izquierdo + 120 + 25 + 5, altura, 25, 5, Estilos.Custom, , , fuente_normal)
        altura = altura + 6
        Impreso.Cabecera.Titulo("Departamento/centro al que se dirige:", margen_izquierdo, altura, 120, 5, Estilos.Custom, , , fuente_negrita)
        altura = altura + 7
        Impreso.Cabecera.Cuadro(margen_izquierdo + 5, altura, 4, 4, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo("COMERCIAL", margen_izquierdo + 12, altura, 25, 5, Estilos.Custom, , , fuente_normal)
        Impreso.Cabecera.Cuadro(margen_izquierdo + 40, altura, 4, 4, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo("PRODUCCIÓN", margen_izquierdo + 47, altura, 27, 5, Estilos.Custom, , , fuente_normal)
        Impreso.Cabecera.Cuadro(margen_izquierdo + 80, altura, 4, 4, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo("CALIDAD", margen_izquierdo + 87, altura, 25, 5, Estilos.Custom, , , fuente_normal)
        Impreso.Cabecera.Cuadro(margen_izquierdo + 115, altura, 4, 4, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo("TÉCNICO", margen_izquierdo + 122, altura, 25, 5, Estilos.Custom, , , fuente_normal)
        altura = altura + 20
        Impreso.Cabecera.Titulo("Descripción:", margen_izquierdo, altura, 120, 5, Estilos.Custom, , , fuente_negrita)
        altura = altura + 5
        Impreso.Cabecera.Titulo(Descripcion1, margen_izquierdo + 10, altura, 160, 5, Estilos.Custom, , , fuente_reducida)
        altura = altura + 5
        Impreso.Cabecera.Titulo(Descripcion2, margen_izquierdo + 10, altura, 160, 5, Estilos.Custom, , , fuente_reducida)
        altura = altura + 5
        Impreso.Cabecera.Titulo(Descripcion3, margen_izquierdo + 10, altura, 160, 5, Estilos.Custom, , , fuente_reducida)
        altura = altura + 5
        Impreso.Cabecera.Titulo(Descripcion4, margen_izquierdo + 10, altura, 160, 5, Estilos.Custom, , , fuente_reducida)
        altura = altura + 22
        Impreso.Cabecera.Titulo("Conclusiones:", margen_izquierdo, altura, 120, 5, Estilos.Custom, , , fuente_negrita)
        altura = altura + 5
        Impreso.Cabecera.Titulo(Conclusiones1, margen_izquierdo + 10, altura, 160, 5, Estilos.Custom, , , fuente_reducida)
        altura = altura + 5
        Impreso.Cabecera.Titulo(Conclusiones2, margen_izquierdo + 10, altura, 160, 5, Estilos.Custom, , , fuente_reducida)
        altura = altura + 5
        Impreso.Cabecera.Titulo(Conclusiones3, margen_izquierdo + 10, altura, 160, 5, Estilos.Custom, , , fuente_reducida)
        altura = altura + 5
        Impreso.Cabecera.Titulo(Conclusiones4, margen_izquierdo + 10, altura, 160, 5, Estilos.Custom, , , fuente_reducida)
        altura = altura + 15


    End Sub


    Private Sub ImprimeAcciones(ByRef Impreso As Impreso, ByRef altura As Integer, Reclama As E_Reclama)


        Dim Acciones1 As String = (Reclama.RCL_Acciones1.Valor & "").Trim
        Dim Acciones2 As String = (Reclama.RCL_Acciones2.Valor & "").Trim
        Dim Acciones3 As String = (Reclama.RCL_Acciones3.Valor & "").Trim
        Dim Acciones4 As String = (Reclama.RCL_Acciones4.Valor & "").Trim


        Impreso.Cabecera.Titulo("ACCIONES A DESARROLLAR:", margen_izquierdo, altura, 70, 6, Estilos.Custom, , , fuente_negrita)
        altura = altura + 5
        Impreso.Cabecera.Titulo(Acciones1, margen_izquierdo + 10, altura, 160, 5, Estilos.Custom, , , fuente_reducida)
        altura = altura + 5
        Impreso.Cabecera.Titulo(Acciones2, margen_izquierdo + 10, altura, 160, 5, Estilos.Custom, , , fuente_reducida)
        altura = altura + 5
        Impreso.Cabecera.Titulo(Acciones3, margen_izquierdo + 10, altura, 160, 5, Estilos.Custom, , , fuente_reducida)
        altura = altura + 5
        Impreso.Cabecera.Titulo(Acciones4, margen_izquierdo + 10, altura, 160, 5, Estilos.Custom, , , fuente_reducida)
        altura = altura + 20
        Impreso.Cabecera.Titulo("RESPONSABLE EJECUCIÓN:", margen_izquierdo, altura, 70, 6, Estilos.Custom, , , fuente_negrita)
        altura = altura + 5
        Impreso.Cabecera.Titulo("SEGUIMIENTO DE LAS ACCIONES:", margen_izquierdo, altura, 70, 6, Estilos.Custom, , , fuente_negrita)
        altura = altura + 5
        Impreso.Cabecera.Cuadro(margen_izquierdo + 10, altura, 4, 4, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo("Favorable", margen_izquierdo + 17, altura, 25, 6, Estilos.Custom, , , fuente_negrita)
        Impreso.Cabecera.Cuadro(margen_izquierdo + 50, altura, 4, 4, ancho_linea, Color.Black)
        Impreso.Cabecera.Titulo("Desfavorable", margen_izquierdo + 57, altura, 40, 6, Estilos.Custom, , , fuente_negrita)
        altura = altura + 5
        Impreso.Cabecera.Titulo("FECHA DE CIERRE:", margen_izquierdo, altura, 70, 6, Estilos.Custom, , , fuente_negrita)
        Impreso.Cabecera.Titulo("Fdo:Presidente Comisión Calidad", margen_izquierdo, altura, 170, 6, Estilos.Custom, ">", , fuente_negrita)


    End Sub


End Module
