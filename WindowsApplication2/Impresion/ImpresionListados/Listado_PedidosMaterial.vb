Imports System.Drawing

Public Class Listado_PedidosMaterial
    Inherits Listado_ImpresionBase

#Region "Propiedades"

    Property IdPedido As String
    Property TipoImpresion As TipoImpresion
    Property Impresora As String
    Property RutaPDF As String

#End Region

#Region "Constructores"

    Public Sub New(IdPedido As String, TipoImpresion As TipoImpresion, Optional Impresora As String = "", Optional rutaPDF As String = "")
        Me.IdPedido = IdPedido
        Me.TipoImpresion = TipoImpresion
        Me.Impresora = Impresora
        Me.RutaPDF = rutaPDF
    End Sub

#End Region

#Region "Métodos"

    Public Overrides Sub ImprimirListado()
        ConfigurarListado()
        Select Case TipoImpresion
            Case NetAgro.TipoImpresion.Preliminar
                Previsualiza()
            Case NetAgro.TipoImpresion.ImpresoraPorDefecto
                ImprimeDirecto()
        End Select
    End Sub

    Private Sub ConfigurarListado()
        If VaInt(IdPedido) > 0 Then

            Dim PedidosMaterial As New E_PedidosMaterial(Idusuario, cn)
            Dim Acreedores As New E_Acreedores(Idusuario, cn)

            If PedidosMaterial.LeerId(IdPedido) Then

                'DatosEmpresa
                Dim DatosEmpresa As New DatosEmpresa()
                DatosEmpresa.ObtenerDatosEmpresa()

                'DatosAcreedor

                If Acreedores.LeerId(PedidosMaterial.PMA_Idacreedor.Valor) Then

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
                    Dim fuente As New Font("Courier New", 11, FontStyle.Bold)
                    Dim fuente_menor As New Font("Courier New", 8, FontStyle.Bold)

                    'Datos Empresa
                    ImprimeDatosEmpresa(miPedido, DatosEmpresa, fuente, altura)
                    'Datos Acreedor
                    ImprimeDatosAcreedor(miPedido, Acreedores, PedidosMaterial, fuente, fuente_menor, altura)
                    'Imprime Cabecera Tabla
                    ImprimeCabeceraTabla(miPedido, fuente, altura)
                    'Tabla
                    ImprimeTabla(miPedido, fuente, IdPedido, PedidosMaterial, Acreedores, fuente_menor, DatosEmpresa, pag_actual, inicio_pag_actual, altura)

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
                            If RutaPDF.Trim <> "" Then
                                Informe.Contenedor.CreateDocument()
                                Try
                                    Dim options As New DevExpress.XtraPrinting.PdfExportOptions
                                    options.Compressed = True
                                    Informe.Contenedor.ExportToPdf(RutaPDF, options)

                                Catch ex As Exception
                                    err.Muestraerror("Error al exportar el documento con id" & IdPedido & " a PDF", "Imprimir Pedido", ex.Message)
                                End Try
                            Else
                                Informe.ImpresionDirecta()
                            End If
                        Case Else
                            Informe.ImpresionDirecta()
                    End Select
                Else
                    MessageBox.Show("No se encontró el Acreedor Id " & VaInt(Acreedores.ACR_Codigo).ToString, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Else
                MessageBox.Show("No se pudo leer el pedido con Id " & IdPedido, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Else
            MessageBox.Show("No hay datos que imprimir para el Pedido", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region


End Class
