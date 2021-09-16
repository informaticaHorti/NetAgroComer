Imports System.Drawing
Imports DevExpress.XtraEditors

Module C1_ImpresionPedidosMaterial

    Public Sub C1_ImprimirPedidosMaterial(IdPedido As String, TipoImpresion As TipoImpresion,
                                          Optional Impresora As String = "",
                                          Optional rutaPDF As String = "",
                                          Optional ArchivoPDF As String = "")

        If VaInt(IdPedido) > 0 Then

            Dim PedidosMaterial As New E_PedidosMaterial(Idusuario, cn)
            Dim Acreedores As New E_Acreedores(Idusuario, cn)

            If PedidosMaterial.LeerId(IdPedido) Then

                'DatosEmpresa
                Dim DatosEmpresa As New DatosEmpresa()
                DatosEmpresa.ObtenerDatosEmpresa()


                'DatosAcreedor
                If Acreedores.LeerId(PedidosMaterial.PMA_Idacreedor.Valor) Then

                    Dim Impreso As New Impreso
                    Impreso.f.Documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
                    Impreso.f.Documento.PageLayout.PageSettings.TopMargin = "0mm"
                    Impreso.f.Documento.PageLayout.PageSettings.BottomMargin = "0mm"
                    Impreso.f.Documento.PageLayout.PageSettings.LeftMargin = "0mm"
                    Impreso.f.documento.PageLayout.PageSettings.RightMargin = "0mm"

                    Impreso.EstableceImpreso(TipoImpresion)


                    Dim pag_actual As Integer = 1
                    Dim inicio_pag_actual As Integer = 24
                    Dim altura As Integer = 24
                    Dim miPedido As New miFactura()
                    Dim err As New Errores

                    'Meollo
                    Dim fuente As New Font("Courier New", 11, FontStyle.Bold)
                    Dim fuente_menor As New Font("Courier New", 8, FontStyle.Bold)


                    Try

                        'Datos Empresa
                        ImprimeDatosEmpresa(Impreso, DatosEmpresa, fuente, altura)
                        'Datos Acreedor
                        ImprimeDatosAcreedor(Impreso, Acreedores, PedidosMaterial, fuente, fuente_menor, altura)
                        'Imprime Cabecera Tabla
                        ImprimeCabeceraTabla(Impreso, fuente, altura)
                        'Tabla
                        ImprimeTabla(Impreso, fuente, IdPedido, PedidosMaterial, Acreedores, fuente_menor, DatosEmpresa, pag_actual, inicio_pag_actual, altura)


                        'Impresion
                        Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, ArchivoPDF)

                    Catch ex As Exception

                    End Try

                Else
                    XtraMessageBox.Show("No se encontró el Acreedor Id " & VaInt(Acreedores.ACR_Codigo).ToString, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Else
                XtraMessageBox.Show("No se pudo leer el pedido con Id " & IdPedido, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Else
            XtraMessageBox.Show("No hay datos que imprimir para el Pedido", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub


    Private Sub ImprimeDatosEmpresa(ByRef Impreso As Impreso, DatosEmpresa As DatosEmpresa, fuente As Font, ByRef altura As Integer)
        Impreso.Cabecera.Titulo(DatosEmpresa.NombreEmpresa, 10, altura, 95, 8, Estilos.GrandeBold, , , fuente)
        Impreso.Cabecera.Titulo(DatosEmpresa.Domicilio, 10, altura + 5, 95, 4, Estilos.Custom, , , fuente)
        Impreso.Cabecera.Titulo(DatosEmpresa.CPostal & "-" & DatosEmpresa.Poblacion & "(" & DatosEmpresa.Provincia & ")", 10, altura + 10, 95, 4, Estilos.Custom, , , fuente)
        Impreso.Cabecera.Titulo(DatosEmpresa.Telefonos & " - " & DatosEmpresa.Fax, 10, altura + 15, 120, 4, Estilos.Custom, , , fuente)
        Impreso.Cabecera.Titulo("*** ORDEN DE CARGA***", 133, altura, 60, 8, Estilos.GrandeBold, , , fuente)
        Impreso.Cabecera.Titulo("- salidas -", 133, altura + 7, 60, 4, Estilos.Reducida, "=", , fuente)
    End Sub


    Private Sub ImprimeDatosAcreedor(ByRef Impreso As Impreso, Acreedores As E_Acreedores, PedidosMaterial As E_PedidosMaterial,
                                    fuente As Font, fuente_menor As Font, ByRef altura As Integer)

        Dim Pais As String = ""
        altura = altura + 24
        Impreso.Cabecera.Titulo(Acreedores.ACR_Nombre.Valor & "", 133, altura, 70, 4, Estilos.Custom, , , fuente)

        Dim IdDestino As String = PedidosMaterial.PMA_Idacreedor.Valor

        'Orden fecha y acreedor
        Impreso.Cabecera.Titulo("Orden", 10, altura + 7, 30, 4, Estilos.NormalBold, "=", , fuente)
        Impreso.Cabecera.Titulo("Fecha", 40, altura + 7, 30, 4, Estilos.NormalBold, "=", , fuente)
        Impreso.Cabecera.Titulo("Acreedor", 70, altura + 7, 30, 4, Estilos.NormalBold, "=", , fuente)

        Impreso.Cabecera.Titulo(PedidosMaterial.PMA_Idpedido.Valor, 10, altura + 14, 30, 4, Estilos.Custom, "=", , fuente)
        Impreso.Cabecera.Titulo(PedidosMaterial.PMA_Fecha.Valor, 40, altura + 14, 30, 4, Estilos.Custom, "=", , fuente)
        Impreso.Cabecera.Titulo(PedidosMaterial.PMA_Idacreedor.Valor, 70, altura + 14, 30, 4, Estilos.Custom, "=", , fuente)

        Impreso.Cabecera.Titulo(Acreedores.ACR_Domicilio.Valor & "", 133, altura + 5, 70, 4, Estilos.Custom, , , fuente)
        Impreso.Cabecera.Titulo(Acreedores.ACR_Poblacion.Valor & "", 133, altura + 10, 70, 4, Estilos.Custom, , , fuente)

        'Marcos
        Impreso.Cabecera.Cuadro(130, altura - 3, 77, 20, 1, Color.Black)
        Impreso.Cabecera.Cuadro(10, altura + 7, 30, 12, 1, Color.Black)
        Impreso.Cabecera.Cuadro(40, altura + 7, 30, 12, 1, Color.Black)
        Impreso.Cabecera.Cuadro(70, altura + 7, 30, 12, 1, Color.Black)
        Impreso.Cabecera.LineaH(10, altura + 12.5, 90, 1, Color.Black)

        altura = altura + 22

    End Sub


    Private Sub ImprimeCabeceraTabla(ByRef Impreso As Impreso, fuente As Font, ByRef altura As Integer)
        'Cabecera de la tabla

        Impreso.Cabecera.LineaH(10.5, altura, 180, 1, Color.Black)
        Impreso.Cabecera.LineaH(10.5, altura + 5, 180, 1, Color.Black)
        Impreso.Cabecera.Titulo("Codigo", 10, altura + 0.5, 40, 4, Estilos.NormalBold, "=", , fuente)
        Impreso.Cabecera.Titulo("Material", 50, altura + 0.5, 50, 4, Estilos.NormalBold, "=", , fuente)
        Impreso.Cabecera.Titulo("Cantidad", 100, altura + 0.5, 30, 4, Estilos.NormalBold, "=", , fuente)
        Impreso.Cabecera.Titulo("Precio", 130, altura + 0.5, 30, 4, Estilos.NormalBold, "=", , fuente)
        Impreso.Cabecera.Titulo("Dto", 160, altura + 0.5, 30, 4, Estilos.NormalBold, "=", , fuente)

    End Sub


    Private Sub ImprimeTabla(ByRef Impreso As Impreso, fuente As Font, IdPedido As String, PedidosMaterial As E_PedidosMaterial, Acreedores As E_Acreedores,
                             fuente_menor As Font, Datosempresa As DatosEmpresa, pag_actual As Integer, inicio_pag_actual As Integer, ByRef altura As Integer)
        'Entidades
        Dim PedidosMaterialLineas As New E_PedidosMaterialLineas(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)
        Dim Usuarios As New E_Usuarios(Idusuario, CnComun)

        'Consulta
        Dim alturaMin As Integer = 75
        Dim py As Decimal = 70
        Dim topeAlturaMin As Integer = alturaMin + py
        Dim troz As Integer = alturaMin
        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(PedidosMaterialLineas.PML_idlinea, "idlinea")
        consulta.SelCampo(PedidosMaterialLineas.PML_idpedido, "idpedido")
        consulta.SelCampo(Envases.ENV_IdEnvase, "codmat", PedidosMaterialLineas.PML_idmaterial)
        consulta.SelCampo(Envases.ENV_Nombre, "material")
        consulta.SelCampo(PedidosMaterialLineas.PML_cantidad, "cantidad")
        consulta.SelCampo(PedidosMaterialLineas.PML_precio, "precio")
        consulta.SelCampo(PedidosMaterialLineas.PML_descuento, "dto")
        consulta.WheCampo(PedidosMaterialLineas.PML_idpedido, "=", IdPedido)


        Dim sql As String = consulta.SQL
        Dim dt As DataTable = PedidosMaterialLineas.MiConexion.ConsultaSQL(sql)

        ''Debug
        'Dim dtCopy As DataTable = dt.Copy
        'For indice As Integer = 0 To 30
        '    dt.Merge(dtCopy)
        'Next

        altura = altura + 7

        For Each row As DataRow In dt.Rows

            Dim Codigo As String = row("codmat").ToString & ""
            Dim Material As String = row("material").ToString & ""
            Dim Cantidad As String = row("cantidad").ToString & ""
            Dim Precio As String = row("precio").ToString & ""
            Dim Descuento As String = row("dto").ToString & ""


            Impreso.Detalle.Titulo(Codigo, 10, altura, 40, 4, Estilos.Custom, "=", , fuente)
            Impreso.Detalle.Titulo(Material, 50, altura, 50, 4, Estilos.Custom, "=", , fuente)
            Impreso.Detalle.Titulo(Cantidad, 100, altura, 29, 4, Estilos.Custom, ">", , fuente)
            Impreso.Detalle.Titulo(Precio, 130, altura, 29, 4, Estilos.Custom, ">", , fuente)
            Impreso.Detalle.Titulo(Descuento, 160, altura, 29, 4, Estilos.Custom, ">", , fuente)

            altura = altura + 4
            troz = troz + 4


            Application.DoEvents()

        Next

        If altura <= topeAlturaMin Then
            altura = topeAlturaMin
        End If

        troz = altura - py

        Impreso.Detalle.LineaV(10, py + 0.5, troz, 1, Color.Black)
        Impreso.Detalle.LineaV(50, py + 0.5, troz, 1, Color.Black)
        Impreso.Detalle.LineaV(100, py + 0.5, troz, 1, Color.Black)
        Impreso.Detalle.LineaV(130, py + 0.5, troz, 1, Color.Black)
        Impreso.Detalle.LineaV(160, py + 0.5, troz, 1, Color.Black)
        Impreso.Detalle.LineaV(190, py + 0.5, troz, 1, Color.Black)

        Impreso.Detalle.LineaH(10.5, altura, 180, 1, Color.Black)
        Impreso.Detalle.LineaH(10.5, altura + 0.5, 180, 1, Color.Black)

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


    Private Sub ImprimeSaltoPagina(ByRef Impreso As Impreso, ByRef altura As Integer,
                                         ByRef pag_actual As Integer, ByRef inicio_pag_actual As Integer,
                                         ByRef BaseLineas As Integer, DatosEmpresa As DatosEmpresa, fuente As Font, fuente_menor As Font,
                                         Acreedores As E_Acreedores, PedidosMaterial As E_PedidosMaterial)
        'Líneas laterales
        If BaseLineas > 0 Then
            Impreso.Detalle.LineaH(10.5, altura, 180, 0.25, Color.Black)
            Impreso.Detalle.LineaV(10, BaseLineas + 0.5, altura - BaseLineas, 1, Color.Black)
            Impreso.Detalle.LineaV(50, BaseLineas + 0.5, altura - BaseLineas, 1, Color.Black)
            Impreso.Detalle.LineaV(100, BaseLineas + 0.5, altura - BaseLineas, 1, Color.Black)
            Impreso.Detalle.LineaV(130, BaseLineas + 0.5, altura - BaseLineas, 1, Color.Black)
            Impreso.Detalle.LineaV(160, BaseLineas + 0.5, altura - BaseLineas, 1, Color.Black)
            Impreso.Detalle.LineaV(190, BaseLineas + 0.5, altura - BaseLineas, 1, Color.Black)
        End If


    End Sub



End Module
