Imports System.Drawing


Public Enum Tcampo
    Texto
    Cuadro
    LineaV
    LineaH
    Logo
End Enum

Public Enum Alineacion
    Izquierda
    Derecha
    Centrado
End Enum


Public Class Valores_defecto_documento

    Public Fuente As String = "Arial"
    Public TamañoFuente As String = "10"
    Public Alineacion As Alineacion = Alineacion.Izquierda
    Public TCampo As Tcampo = TCampo.Texto
    Public Negrita As String = "N"
    Public Subrayada As String = "N"
    Public Cursiva As String = "N"
    Public AltoLineas As Integer = 5

End Class


Public Class Mfuente
    Dim _Fuente As String
    Public Property Fuente As String
        Set(ByVal value As String)
            _Fuente = value
        End Set
        Get
            Return _Fuente
        End Get
    End Property

    Dim _Tamaño As Double
    Public Property Tamaño As Single
        Set(ByVal value As Single)
            _Tamaño = value
        End Set
        Get
            Return _Tamaño
        End Get
    End Property

    Dim _Negrita As Boolean
    Public Property Negrita As Boolean
        Set(ByVal value As Boolean)
            _Negrita = value
        End Set
        Get
            Return _Negrita
        End Get
    End Property

    Dim _Subrayada As Boolean
    Public Property Subrayada As Boolean
        Set(ByVal value As Boolean)
            _Subrayada = value
        End Set
        Get
            Return _Subrayada
        End Get
    End Property

    Dim _Cursiva As Boolean
    Public Property Cursiva As Boolean
        Set(ByVal value As Boolean)
            _Cursiva = value
        End Set
        Get
            Return _Cursiva
        End Get
    End Property




End Class

Public Class CampoImp

    Dim _Nombre As String
    Public Property Nombre As String
        Set(ByVal value As String)
            _Nombre = value
        End Set
        Get
            Return _Nombre
        End Get
    End Property

    Dim _TipoCampo As Integer
    Public Property tipocampo As Tcampo
        Set(ByVal value As Tcampo)
            _TipoCampo = value
        End Set
        Get
            Return _TipoCampo
        End Get
    End Property


    Dim _Valor As String = ""
    Public Property Valor As String
        Set(ByVal value As String)
            _Valor = value
        End Set
        Get
            Return _Valor
        End Get
    End Property

    Dim _PosX As String
    Public Property PosX As Integer
        Set(ByVal value As Integer)
            _PosX = value
        End Set
        Get
            Return _PosX
        End Get
    End Property

    Dim _PosY As String
    Public Property PosY As Integer
        Set(ByVal value As Integer)
            _PosY = value
        End Set
        Get
            Return _PosY
        End Get
    End Property
    Dim _Longitud As String
    Public Property Longitud As Integer
        Set(ByVal value As Integer)
            _Longitud = value
        End Set
        Get
            Return _Longitud
        End Get
    End Property

    Dim _Altura As String
    Public Property Altura As Integer
        Get
            Return _Altura
        End Get
        Set(value As Integer)
            _Altura = value
        End Set
    End Property


    Dim _Alineacion As Integer
    Public Property Alineacion As Alineacion
        Set(ByVal value As Alineacion)
            _Alineacion = value
        End Set
        Get
            Return _Alineacion
        End Get
    End Property


    Public _Fuente As New Mfuente
    Public Property fuente As Mfuente
        Set(ByVal value As Mfuente)
            _Fuente = value
        End Set
        Get
            Return _Fuente
        End Get
    End Property

    Public _sublinea As Integer
    Public Property Sublinea As Integer
        Set(ByVal value As Integer)
            _sublinea = value
        End Set
        Get
            Return _sublinea
        End Get
    End Property


    Public Sub New()

    End Sub

    Public Sub New(valores_defecto As Valores_defecto_documento)

        Me.fuente.Fuente = valores_defecto.Fuente
        Me.fuente.Tamaño = valores_defecto.TamañoFuente
        Me.fuente.Negrita = (valores_defecto.Negrita = "S")
        Me.fuente.Subrayada = (valores_defecto.Subrayada = "S")
        Me.fuente.Cursiva = (valores_defecto.Cursiva = "S")
        Me.Alineacion = valores_defecto.Alineacion
        Me.tipocampo = valores_defecto.TCampo
        Me.Altura = valores_defecto.AltoLineas

    End Sub

End Class


Public Class I_formato

    Public _MiInforme As New miInforme(False)
    Public _MiFactura As New miFactura()


    Public Sub New()

        _MiInforme.Contenedor.PaperKind = Printing.PaperKind.A4
        _MiInforme.Contenedor.PrintingSystem.ShowMarginsWarning = False

        _MiInforme.Contenedor.MinMargins.Top = 0
        _MiInforme.Contenedor.MinMargins.Left = 0
        _MiInforme.Contenedor.MinMargins.Right = 0
        _MiInforme.Contenedor.MinMargins.Bottom = 0

        _MiInforme.Contenedor.Margins.Top = 0
        _MiInforme.Contenedor.Margins.Left = 0
        _MiInforme.Contenedor.Margins.Right = 0
        _MiInforme.Contenedor.Margins.Bottom = 0

    End Sub
    Public Class Cabecera

        Public Altura As Integer
        Public Campos As New Dictionary(Of String, CampoImp)

        Public Sub NuevoCampo(campo As CampoImp)
            Campos(campo.Nombre) = campo
        End Sub

        Public Sub ValorCampo(NombreCampo As String, VCampo As String)
            Campos(NombreCampo).Valor = VCampo
        End Sub

    End Class

    Public Class Lineas

        Public Class SubLinea

            Public Altura As Integer = 0
            Public Campos As New Dictionary(Of String, CampoImp)

            'Para crear la definición de los campos
            Public Sub NuevoCampo(campo As CampoImp)
                Campos(campo.Nombre) = campo
            End Sub

            Public Sub New()

            End Sub

            Public Sub New(DcCampos As Dictionary(Of String, CampoImp))
                Me.Campos = DcCampos
            End Sub

        End Class


        Public Altura As Integer
        Public Filas As New List(Of Dictionary(Of String, String))
        Public SubLineasOcultasPorFila As New List(Of Boolean)
        Public SubLineas As New List(Of SubLinea)


        'Crea una nueva definición de sublinea para cada linea
        Public Sub NuevaSubLinea(sl As SubLinea)
            SubLineas.Add(sl)
        End Sub


        'Crea una nueva fila con un diccionario del tipo NombreCampo = ValorCampo
        Public Sub NuevaFila(DcValores As Dictionary(Of String, String), Optional lst As List(Of Boolean) = Nothing) 'lista de sublineas a ocultar
            Filas.Add(DcValores)
        End Sub


        'Crea una nueva fila de valores a partir de un datarow y una definición de columnas de un datatable
        Public Sub NuevaFila(dt As DataTable, row As DataRow, Optional lst As List(Of Integer) = Nothing) 'lista de sublineas a ocultar

            Dim DcValores As New Dictionary(Of String, String)


            For Each columna As DataColumn In dt.Columns

                Dim NombreColumna As String = columna.ColumnName.Trim
                Dim Valor As String = row(NombreColumna).ToString & ""

                DcValores(NombreColumna) = Valor

            Next


            NuevaFila(DcValores)

        End Sub


    End Class


    Public Class Pie
        Public Altura As Integer
        Public Campos As New Dictionary(Of String, CampoImp)

        Public Sub NuevoCampo(campo As CampoImp)
            Campos(campo.Nombre) = campo
        End Sub

        Public Sub ValorCampo(NombreCampo As String, VCampo As String)
            Campos(NombreCampo).Valor = VCampo
        End Sub

    End Class


    Public MiCabecera As New Cabecera
    Public MiLineas As New Lineas
    Public MiPie As New Pie


    Public Sub Imprimir(Optional TipoImpresion As TipoImpresion = TipoImpresion.ImpresoraPorDefecto,
                        Optional Impresora As String = "",
                        Optional rutaPDF As String = "",
                        Optional archivoPDF As String = "")


        Dim err As New Errores


        Try


            'Creamos las líneas de impresión
            GenerarLineasImpresion()


            'Añadimos el documento al informe
            _MiInforme.AñadeDetalles(_MiFactura)

            'Impresión / previsualización / exportación
            Select Case TipoImpresion

                Case TipoImpresion.Preliminar
                    _MiInforme.Preliminar(DevExpress.LookAndFeel.UserLookAndFeel.Default)

                Case TipoImpresion.ImpresoraSeleccionada
                    If Impresora.Trim <> "" Then
                        _MiInforme.ImpresionDirecta(Impresora)
                    Else
                        _MiInforme.ImpresionDirecta()
                    End If

                Case TipoImpresion.ExportacionPDF
                    If rutaPDF.Trim <> "" And archivoPDF.Trim <> "" Then
                        _MiInforme.Contenedor.CreateDocument()
                        Try
                            Dim options As New DevExpress.XtraPrinting.PdfExportOptions
                            options.Compressed = True
                            _MiInforme.Contenedor.ExportToPdf(rutaPDF & archivoPDF, options)

                        Catch ex As Exception
                            err.Muestraerror("Error al exportar el documento a PDF", "I_Formato.Imprimir", ex.Message)
                        End Try

                    Else
                        _MiInforme.ImpresionDirecta()
                    End If

                Case Else
                    _MiInforme.ImpresionDirecta()
            End Select


        Catch ex As Exception
            err.Muestraerror("Error al imprimir documento", "I_Formato.Imprimir", ex.Message())
        End Try


    End Sub


    Private Sub GenerarLineasImpresion()

        Dim altura_seccion As Integer = 0


        'Cabecera
        For Each clave As String In MiCabecera.Campos.Keys
            Dim campo As CampoImp = MiCabecera.Campos(clave)
            ImprimeCampo(campo, altura_seccion)
        Next

        altura_seccion = altura_seccion + MiCabecera.Altura


        'Lineas
        Dim altura_sublinea As Integer = altura_seccion

        'Valores fijos
        For Each fila As Dictionary(Of String, String) In MiLineas.Filas
            For Each sublinea As Lineas.SubLinea In MiLineas.SubLineas
                For Each clave As String In sublinea.Campos.Keys

                    Dim campo As CampoImp = sublinea.Campos(clave)
                    campo.Altura = sublinea.Altura
                    ImprimeCampo(campo, altura_sublinea)

                Next

                altura_sublinea = altura_sublinea + sublinea.Altura

            Next
        Next


        'Valores variables
        altura_sublinea = altura_seccion

        For Each fila As Dictionary(Of String, String) In MiLineas.Filas
            For Each sublinea As Lineas.SubLinea In MiLineas.SubLineas
                For Each nombrecampo As String In fila.Keys
                    If sublinea.Campos.ContainsKey(nombrecampo) Then

                        Dim campo As CampoImp = sublinea.Campos(nombrecampo)
                        campo.Altura = sublinea.Altura
                        campo.Valor = fila(nombrecampo)

                        ImprimeCampo(campo, altura_sublinea)

                    End If
                Next

                altura_sublinea = altura_sublinea + sublinea.Altura

            Next
        Next


        altura_seccion = altura_seccion + MiLineas.Altura


        'Pie
        For Each clave As String In MiPie.Campos.Keys
            Dim campo As CampoImp = MiPie.Campos(clave)
            ImprimeCampo(campo, altura_seccion)
        Next

    End Sub


    Private Sub ImprimeCampo(campo As CampoImp, altura_seccion As Integer)


        Dim x As Integer = campo.PosX
        Dim y As Integer = campo.PosY + altura_seccion
        Dim l As Integer = campo.Longitud
        Dim a As Integer = campo.Altura
        Dim texto As String = campo.Valor


        'Alineación
        Dim alineacion As String = ""
        Select Case campo.Alineacion
            Case NetAgro.Alineacion.Centrado
                alineacion = "="
            Case NetAgro.Alineacion.Derecha
                alineacion = ">"
        End Select

        'Fuente
        Dim estilo As New System.Drawing.FontStyle
        estilo = FontStyle.Regular
        If campo.fuente.Negrita Then estilo = FontStyle.Bold
        If campo.fuente.Subrayada Then estilo = estilo Xor FontStyle.Underline
        If campo.fuente.Cursiva Then estilo = estilo Xor FontStyle.Italic

        Dim fuente As New Font(campo.fuente.Fuente, campo.fuente.Tamaño, estilo)


        'TODO: Logo
        Select Case campo.tipocampo

            Case Tcampo.Texto
                _MiFactura.Titulo(texto, x, y, l, a, milinea.stilos.Custom, alineacion, fuente)

            Case Tcampo.LineaH
                _MiFactura.LineaH(x, y, l, 0.25, Color.Black)

            Case Tcampo.LineaV

                'Hasta final de la sección de detalle
                _MiFactura.LineaV(x, y, l, 0.25, Color.Black)

            Case Tcampo.Cuadro
                _MiFactura.Cuadro(x, y, l, a, 0.25, Color.Black)

        End Select


    End Sub



End Class

