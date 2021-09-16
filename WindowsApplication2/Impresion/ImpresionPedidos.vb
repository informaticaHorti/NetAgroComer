Imports System.Drawing
Imports DevExpress.XtraEditors

Module ImpresionPedidos

    Public Sub Imprimir_Pedidos(IdPedido As String, TipoImpresion As TipoImpresion, Impresora As String, Optional rutaPDF As String = "")

        If VaInt(IdPedido) > 0 Then

            Dim Pedidos As New E_Pedidos(Idusuario, cn)
            Dim Cliente As New E_Clientes(Idusuario, cn)
            Dim FamGen As New E_FamiliasGeneros(Idusuario, cn)
            Dim Pais As String = ""

            If Pedidos.LeerId(IdPedido) Then

                'DatosEmpresa
                Dim DatosEmpresa As New DatosEmpresa()
                DatosEmpresa.ObtenerDatosEmpresa()

                'DatosCliente
                If Cliente.LeerId(Pedidos.PED_idcliente.Valor) Then

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


                    Dim pag_actual As Integer = 1
                    Dim inicio_pag_actual As Integer = 24
                    Dim altura As Integer = 24
                    Dim miPedido As New miFactura()
                    Dim err As New Errores

                    'Meollo
                    Dim fuente As New Font("Courier New", 9, FontStyle.Bold)
                    Dim fuente_menor As New Font("Courier New", 8, FontStyle.Bold)

                    'Datos Empresa
                    ImprimeDatosEmpresa(miPedido, DatosEmpresa, fuente, altura)

                    'Datos Cliente
                    ImprimeDatosCliente(miPedido, Cliente, Pedidos, fuente, fuente_menor, altura)
                    'Imprime Cabecera Tabla
                    ImprimeCabeceraTabla(miPedido, fuente, altura)
                    'Tabla
                    ImprimeTabla(miPedido, fuente, IdPedido, Pedidos, Cliente, fuente_menor, DatosEmpresa, pag_actual, inicio_pag_actual, altura)

                    'Añadimos el documento al informe
                    Informe.AñadeDetalles(miPedido)

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
                                    err.Muestraerror("Error al exportar el documento con id" & IdPedido & " a PDF", "Imprimir Pedido", ex.Message)
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
                XtraMessageBox.Show("No se pudo leer el pedido con Id " & IdPedido, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            XtraMessageBox.Show("No hay datos que imprimir para el Pedido", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ImprimeDatosEmpresa(ByRef miPedido As miFactura, DatosEmpresa As DatosEmpresa, fuente As Font, ByRef altura As Integer)
        miPedido.Titulo(DatosEmpresa.NombreEmpresa, 10, altura, 95, 8, milinea.stilos.GrandeBold, , fuente)
        miPedido.Titulo(DatosEmpresa.Domicilio, 10, altura + 5, 95, 4, milinea.stilos.Custom, , fuente)
        miPedido.Titulo(DatosEmpresa.CPostal & "-" & DatosEmpresa.Poblacion & "(" & DatosEmpresa.Provincia & ")", 10, altura + 10, 95, 4, milinea.stilos.Custom, , fuente)
        miPedido.Titulo(DatosEmpresa.Telefonos & " - " & DatosEmpresa.Fax, 10, altura + 15, 120, 4, milinea.stilos.Custom, , fuente)
        miPedido.Titulo("*** ORDEN DE CARGA***", 133, altura, 60, 8, milinea.stilos.GrandeBold, , fuente)
        miPedido.Titulo("- salidas -", 133, altura + 7, 60, 4, milinea.stilos.Reducida, "=", fuente)
    End Sub

    Private Sub ImprimeDatosCliente(ByRef miPedido As miFactura, Cliente As E_Clientes, Pedidos As E_Pedidos,
                                    fuente As Font, fuente_menor As Font, ByRef altura As Integer)

        Dim Paises As New E_Paises(Idusuario, CnComun)
        Dim clientesDescargas As New E_ClientesDescargas(Idusuario, cn)
        Dim Pais As String = ""
        altura = altura + 24
        miPedido.Titulo(Cliente.CLI_Nombre.Valor & "", 128, altura, 70, 4, milinea.stilos.Custom, , fuente)

        Dim IdDestino As String = Pedidos.PED_idcliente.Valor
        If clientesDescargas.LeerId(IdDestino) Then

            Dim IdPais As String = clientesDescargas.CLD_IdPais.Valor
            If Paises.LeerId(IdPais) Then
                Pais = Paises.Nombre.Valor
            End If

            miPedido.Titulo(clientesDescargas.CLD_Domicilio.Valor & "", 128, altura + 5, 70, 4, milinea.stilos.Custom, , fuente)
            miPedido.Titulo(clientesDescargas.CLD_Poblacion.Valor & " - " & Pais, 128, altura + 10, 70, 4, milinea.stilos.Custom, , fuente_menor)
            'Orden fecha y cliente
            miPedido.Titulo("Orden", 10, altura + 9, 30, 4, milinea.stilos.NormalBold, "=", fuente)
            miPedido.Titulo("Fecha", 40, altura + 9, 30, 4, milinea.stilos.NormalBold, "=", fuente)
            miPedido.Titulo("Cliente", 70, altura + 9, 30, 4, milinea.stilos.NormalBold, "=", fuente)
            miPedido.Titulo(Pedidos.PED_pedido.Valor, 10, altura + 14, 30, 4, milinea.stilos.Custom, "=", fuente)
            miPedido.Titulo(Pedidos.PED_fechapedido.Valor, 40, altura + 14, 30, 4, milinea.stilos.Custom, "=", fuente)
            miPedido.Titulo(Pedidos.PED_idcliente.Valor, 70, altura + 14, 30, 4, milinea.stilos.Custom, "=", fuente)

        Else

            If Paises.LeerId(Cliente.CLI_IdPais.Valor) Then
                Pais = Paises.Nombre.Valor
            End If

            miPedido.Titulo(Cliente.CLI_Domicilio.Valor & "", 128, altura + 5, 70, 4, milinea.stilos.Custom, , fuente)
            miPedido.Titulo(Cliente.CLI_Poblacion.Valor & " - " & Pais, 128, altura + 10, 70, 4, milinea.stilos.Custom, , fuente_menor)
            'Orden fecha y cliente
            miPedido.Titulo("Orden", 10, altura + 9, 30, 4, milinea.stilos.NormalBold, "=", fuente)
            miPedido.Titulo("Fecha", 40, altura + 9, 30, 4, milinea.stilos.NormalBold, "=", fuente)
            miPedido.Titulo("Cliente", 70, altura + 9, 30, 4, milinea.stilos.NormalBold, "=", fuente)
            miPedido.Titulo(Pedidos.PED_pedido.Valor, 10, altura + 14, 30, 4, milinea.stilos.Custom, "=", fuente)
            miPedido.Titulo(Pedidos.PED_fechapedido.Valor, 40, altura + 14, 30, 4, milinea.stilos.Custom, "=", fuente)
            miPedido.Titulo(Pedidos.PED_idcliente.Valor, 70, altura + 14, 30, 4, milinea.stilos.Custom, "=", fuente)

            Dim destino As String = Pedidos.PED_iddestino.Valor & ""
            If destino.Trim <> "" Then
                miPedido.Titulo("Destino: " & destino, 125, altura + 18, 75, 4, milinea.stilos.Reducida)
            End If


        End If

            'Marcos
        miPedido.Cuadro(125, altura - 3, 77, 20, 1, Color.Black)
        miPedido.Cuadro(10, altura + 7, 30, 12, 1, Color.Black)
        miPedido.Cuadro(40, altura + 7, 30, 12, 1, Color.Black)
        miPedido.Cuadro(70, altura + 7, 30, 12, 1, Color.Black)
        miPedido.LineaH(10, altura + 12.5, 90, 1, Color.Black)
        altura = altura + 22

    End Sub


    Private Sub ImprimeCabeceraTabla(ByRef miPedido As miFactura, fuente As Font, ByRef altura As Integer)
        'Cabecera de la tabla

        miPedido.LineaH(10.5, altura, 190, 1, Color.Black)
        miPedido.LineaH(10.5, altura + 5, 190, 1, Color.Black)
        miPedido.Titulo("Prod", 10, altura + 0.5, 12, 4, milinea.stilos.NormalBold, "=", fuente)
        miPedido.Titulo("Descripcion", 22, altura + 0.5, 52, 4, milinea.stilos.NormalBold, "=", fuente)
        miPedido.Titulo("Categoria", 74 + 1, altura + 0.5, 50, 4, milinea.stilos.NormalBold, "<", fuente)
        miPedido.Titulo("Marca", 114, altura + 0.5, 15, 4, milinea.stilos.NormalBold, "=", fuente)
        miPedido.Titulo("T.Palet", 129, altura + 0.5, 15, 4, milinea.stilos.NormalBold, "=", fuente)
        miPedido.Titulo("Palets", 144, altura + 0.5, 15, 4, milinea.stilos.NormalBold, "=", fuente)
        miPedido.Titulo("Bultos", 159, altura + 0.5, 15, 4, milinea.stilos.NormalBold, "=", fuente)
        miPedido.Titulo("Precio", 174, altura + 0.5, 15, 4, milinea.stilos.NormalBold, "=", fuente)

    End Sub

    Private Sub ImprimeTabla(ByRef miPedido As miFactura, fuente As Font, IdPedido As String, Pedidos As E_Pedidos, Cliente As E_Clientes,
                             fuente_menor As Font, Datosempresa As DatosEmpresa, pag_actual As Integer, inicio_pag_actual As Integer, ByRef altura As Integer)
        'Entidades
        Dim Pedidoslineas As New E_Pedidos_lineas(Idusuario, cn)
        Dim CategoriasSalidas As New E_CategoriasSalida(Idusuario, cn)
        Dim Paises As New E_Paises(Idusuario, CnComun)
        Dim Usuarios As New E_Usuarios(Idusuario, CnComun)
        Dim clientesDescargas As New E_ClientesDescargas(Idusuario, cn)
        Dim Generos As New E_Generos(Idusuario, cn)
        Dim Marcas As New E_Marcas(Idusuario, cn)
        Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)

        'Consulta
        Dim alturaMin As Integer = 75
        Dim py As Decimal = 70
        Dim topeAlturaMin As Integer = alturaMin + py
        Dim troz As Integer = alturaMin
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Pedidoslineas.PEL_idlinea, "idlinea")
        consulta.SelCampo(Pedidoslineas.PEL_idpedido, "idpedido")
        consulta.SelCampo(Pedidoslineas.PEL_idgenero, "idgenero")
        consulta.SelCampo(Generos.GEN_NombreGenero, "descripcion", Pedidoslineas.PEL_idgenero)
        consulta.SelCampo(Pedidoslineas.PEL_nomcate, "Categoria")
        consulta.SelCampo(Marcas.MAR_Nombre, "marca", Pedidoslineas.PEL_idmarca)
        consulta.SelCampo(ConfecPalet.CPA_Nombre, "palet", Pedidoslineas.PEL_idtipopalet)
        consulta.SelCampo(Pedidoslineas.PEL_palets, "canpalet")
        consulta.SelCampo(Pedidoslineas.PEL_Bultos, "Bultos")
        consulta.SelCampo(Pedidoslineas.PEL_precio, "precio")
        consulta.WheCampo(Pedidoslineas.PEL_idpedido, "=", IdPedido)

        Dim sql As String = consulta.SQL
        Dim dt As DataTable = Pedidoslineas.MiConexion.ConsultaSQL(sql)



        altura = altura + 7

        For Each row As DataRow In dt.Rows

            Dim Producto As String = row("idgenero").ToString & ""
            Dim Descripcion As String = row("descripcion").ToString & ""
            Dim Categoria As String = row("categoria").ToString & ""
            Dim Marca As String = row("marca").ToString & ""
            Dim Palet As String = row("palet").ToString & ""
            Dim Cantidad As String = row("canpalet").ToString & ""
            Dim Bultos As String = VaInt(row("Bultos")).ToString("#,###")
            'Dim Precio As String = VaDec(row("precio")).ToString("#,##0.00") & ""
            Dim Precio As String = VaDec((row("Precio").ToString & "").Replace(".", ",")).ToString("#,##0.00")



            If CompruebaSaltoPagina(altura, 4, pag_actual) Then
                pag_actual = pag_actual + 1
                ImprimeSaltoPagina(miPedido, altura, pag_actual, inicio_pag_actual, py, Datosempresa, fuente, fuente_menor, Cliente, Pedidos)

            End If

            miPedido.Titulo(Producto, 10 + 1, altura, 11, 4, milinea.stilos.Custom, "=", fuente)
            miPedido.Titulo(Descripcion, 22 + 1, altura, 51, 4, milinea.stilos.Custom, "<", fuente)
            miPedido.Titulo(Categoria, 74 + 1, altura, 49, 4, milinea.stilos.Custom, "<", fuente)
            miPedido.Titulo(Marca, 114 + 1, altura, 14, 4, milinea.stilos.Custom, "=", fuente)
            miPedido.Titulo(Palet, 129 + 1, altura, 14, 4, milinea.stilos.Custom, "=", fuente)
            miPedido.Titulo(Cantidad, 144 + 1, altura, 14, 4, milinea.stilos.Custom, ">", fuente)
            miPedido.Titulo(Bultos, 159 + 1, altura, 14, 4, milinea.stilos.Custom, ">", fuente)
            miPedido.Titulo(Precio, 174 + 1, altura, 24, 4, milinea.stilos.Custom, ">", fuente)

            altura = altura + 4
            troz = troz + 4
        Next

        If altura <= topeAlturaMin Then
            altura = topeAlturaMin
        End If

        troz = altura - py

        miPedido.LineaV(10, py + 0.5, troz, 1, Color.Black)
        miPedido.LineaV(22, py + 0.5, troz, 1, Color.Black)
        miPedido.LineaV(74, py + 0.5, troz, 1, Color.Black)
        miPedido.LineaV(114, py + 0.5, troz, 1, Color.Black)
        miPedido.LineaV(129, py + 0.5, troz, 1, Color.Black)
        miPedido.LineaV(144, py + 0.5, troz, 1, Color.Black)
        miPedido.LineaV(159, py + 0.5, troz, 1, Color.Black)
        miPedido.LineaV(174, py + 0.5, troz, 1, Color.Black)
        miPedido.LineaV(200, py + 0.5, troz, 1, Color.Black)

        miPedido.LineaH(10.5, altura, 190, 1, Color.Black)
        miPedido.LineaH(10.5, altura + 0.5, 190, 1, Color.Black)
        'End If

        'Pie de Pagina
        Dim IdDestino As String = Pedidos.PED_idcliente.Valor
        Dim Pais As String = ""
        If clientesDescargas.LeerId(IdDestino) Then

            Dim IdPais As String = clientesDescargas.CLD_IdPais.Valor
            If Paises.LeerId(IdPais) Then
                Pais = Paises.Nombre.Valor
            End If
            miPedido.Titulo("Pais: " & Pais, 18, altura + 13, 90, 4, milinea.stilos.Custom, , fuente)
        Else
        End If
        If Paises.LeerId(Cliente.CLI_IdPais.Valor) Then
            Pais = Paises.Nombre.Valor
        End If


        Dim Transportista As String = Pedidos.PED_idtransportista.Valor
        Dim Acreedores As New E_Acreedores(Idusuario, cn)
        If Acreedores.LeerId(Pedidos.PED_idtransportista.Valor) Then
            Transportista = Transportista & " " & Acreedores.ACR_Nombre.Valor
        End If

        'Tabla pie de pagina
        miPedido.Titulo("Pais: " & Pais, 18, altura + 13, 70, 4, milinea.stilos.Custom, , fuente)
        miPedido.Titulo("Transp: " & Transportista, 18, altura + 9, 70, 4, milinea.stilos.Custom, , fuente)
        miPedido.Titulo("Usuario: " & Idusuario & " " & NombreUsuario, 18, altura + 17, 70, 4, milinea.stilos.Custom, , fuente)
        miPedido.Titulo("Matrícula: " & Pedidos.PED_matriculacamion.Valor, 150, altura + 5, 50, 4, milinea.stilos.Custom, , fuente)
        'miPedido.Titulo("Cerrada: ", 150, altura + 9, 50, 4, milinea.stilos.Custom, , fuente)
    End Sub

    Private Function CompruebaSaltoPagina(altura As Integer, altura_linea As Integer, pag_actual As Integer) As Boolean

        Dim bRes As Boolean = False
        'Detectamos si debe efectuarse un salto de página
        Dim pagina As Integer = ((altura + altura_linea) \ 282) + 1
        If pagina > pag_actual Then
            bRes = True
        End If
        Return bRes
    End Function


    Private Sub ImprimeSaltoPagina(ByRef miPedido As miFactura, ByRef altura As Integer,
                                         ByRef pag_actual As Integer, ByRef inicio_pag_actual As Integer,
                                         ByRef BaseLineas As Integer, DatosEmpresa As DatosEmpresa, fuente As Font, fuente_menor As Font,
                                         Cliente As E_Clientes, Pedidos As E_Pedidos)
        'Líneas laterales
        If BaseLineas > 0 Then
            miPedido.LineaH(10.5, altura, 190, 0.25, Color.Black)
            miPedido.LineaV(10, BaseLineas + 0.5, altura - BaseLineas, 1, Color.Black)
            miPedido.LineaV(29, BaseLineas + 0.5, altura - BaseLineas, 1, Color.Black)
            miPedido.LineaV(79, BaseLineas + 0.5, altura - BaseLineas, 1, Color.Black)
            miPedido.LineaV(89, BaseLineas + 0.5, altura - BaseLineas, 1, Color.Black)
            miPedido.LineaV(104, BaseLineas + 0.5, altura - BaseLineas, 1, Color.Black)
            miPedido.LineaV(119, BaseLineas + 0.5, altura - BaseLineas, 1, Color.Black)
            miPedido.LineaV(134, BaseLineas + 0.5, altura - BaseLineas, 1, Color.Black)
            miPedido.LineaV(149, BaseLineas + 0.5, altura - BaseLineas, 1, Color.Black)
            miPedido.LineaV(169, BaseLineas + 0.5, altura - BaseLineas, 1, Color.Black)
            miPedido.LineaV(200, BaseLineas + 0.5, altura - BaseLineas, 1, Color.Black)
        End If

        Dim salto As Integer = ((297 - 15) * (pag_actual - 1))

        'Para asegurarnos de que el pie de página no suba
        miPedido.LineaH(0, salto - 1, 210, 0.25, Color.Transparent)
        miPedido.SaltoPagina(salto)

        altura = salto
        altura = altura + 7

        ImprimeDatosEmpresa(miPedido, DatosEmpresa, fuente, altura)
        ImprimeDatosCliente(miPedido, Cliente, Pedidos, fuente, fuente_menor, altura)
        ImprimeCabeceraTabla(miPedido, fuente, altura)

        BaseLineas = altura
        altura = altura + 7

    End Sub
End Module
