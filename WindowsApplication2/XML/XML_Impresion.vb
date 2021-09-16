Imports System.Xml
Imports System.IO

Public Class XML_Impresion


    Private _documento As New I_formato
    Public ReadOnly Property Documento As I_formato
        Get
            Return _documento
        End Get
    End Property


    Public Sub New(fichero_xml As String)

        LeerXMLImpresion(fichero_xml)

    End Sub


    Private Sub LeerXMLImpresion(fichero_xml As String)


        Try

            'Cargamos el archivo XML
            Dim m_xmld As New XmlDocument()
            m_xmld.Load(fichero_xml)


            'Obtenemos la configuracion por defecto
            Dim valores_defecto_documento As Valores_defecto_documento = ObtenerValoresDefecto(m_xmld)


            'Cargamos Cabecera
            ObtenerCabecera(m_xmld, _documento, valores_defecto_documento)


            'Cargamos definición de las líneas de detalle
            ObtenerLineas(m_xmld, _documento, valores_defecto_documento)


            'Cargamos Pie
            ObtenerPie(m_xmld, _documento, valores_defecto_documento)


        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try


    End Sub


    Private Function ObtenerValoresDefecto(m_xmld As XmlDocument) As Valores_defecto_documento


        Dim valores_defecto_documento As New Valores_defecto_documento


        Dim nodos_default As XmlNodeList = m_xmld.SelectNodes("documento/default")
        If nodos_default.Count > 0 Then

            If nodos_default.Count > 1 Then
                Throw New Exception("Sólo puede haber un nodo <default>")
            End If

            Dim nodo_default As XmlNode = nodos_default(0)

            For Each nodo As XmlNode In nodo_default.ChildNodes
                Select Case nodo.Name.ToUpper.Trim
                    Case "FUENTE"
                        valores_defecto_documento.Fuente = nodo.InnerText
                    Case "TAMAÑOFUENTE"
                        valores_defecto_documento.TamañoFuente = nodo.InnerText
                    Case "ALINEACION"
                        valores_defecto_documento.Alineacion = CType(nodo.InnerText, Alineacion)
                    Case "TCAMPO"
                        valores_defecto_documento.TCampo = CType(nodo.InnerText, Tcampo)
                    Case "NEG"
                        valores_defecto_documento.Negrita = nodo.InnerText
                    Case "SUB"
                        valores_defecto_documento.Subrayada = nodo.InnerText
                    Case "CUR"
                        valores_defecto_documento.Cursiva = nodo.InnerText
                    Case "ALTOLINEAS"
                        valores_defecto_documento.AltoLineas = VaInt(nodo.InnerText)

                End Select
            Next

        End If


        Return valores_defecto_documento

    End Function


    Private Sub ObtenerCabecera(m_xmld As XmlDocument, ByRef documento As I_formato, valores_defecto_documento As Valores_defecto_documento)

        'Campos de cabecera
        Dim nodos_cabecera As XmlNodeList = m_xmld.SelectNodes("documento/cabecera")
        If nodos_cabecera.Count > 0 Then

            If nodos_cabecera.Count > 1 Then
                Throw New Exception("Sólo puede haber un nodo <cabecera>")
            End If

            Dim nodo_cabecera As XmlNode = nodos_cabecera(0)

            Dim altura As String = ValorAtributo(nodo_cabecera, "altura")
            documento.MiCabecera.Altura = VaInt(altura)
            

            For Each nodo_campo As XmlNode In nodo_cabecera.ChildNodes
                If nodo_campo.Name.Trim.ToUpper = "CAMPO" Then

                    Dim campo As New CampoImp(valores_defecto_documento)
                    ObtenerAtributosCampo(nodo_campo, campo)
                    documento.MiCabecera.NuevoCampo(campo)

                End If
            Next
        End If

    End Sub


    Private Sub ObtenerLineas(m_xmld As XmlDocument, ByRef documento As I_formato, valores_defecto_documento As Valores_defecto_documento)

        'Campos de detalle
        Dim nodos_lineas As XmlNodeList = m_xmld.SelectNodes("documento/lineas")
        If nodos_lineas.Count > 0 Then

            If nodos_lineas.Count > 1 Then
                Throw New Exception("Sólo puede haber un nodo <lineas>")
            End If

            Dim nodo_linea As XmlNode = nodos_lineas(0)

            Dim altura As String = ValorAtributo(nodo_linea, "altura")
            documento.MiLineas.Altura = VaInt(altura)


            'Obtiene todas las sublineas
            Dim nodos_sublineas As XmlNodeList = m_xmld.SelectNodes("documento/lineas/sublinea")

            For Each nodo_sublinea As XmlNode In nodos_sublineas

                'Crea una sublinea por cada nodo sublinea
                Dim SubLinea As New I_formato.Lineas.SubLinea
                Dim altura_sublinea As String = ValorAtributo(nodo_sublinea, "altura")
                SubLinea.Altura = VaInt(altura_sublinea)


                'Lee los campos de la sublinea
                For Each nodo_campo As XmlNode In nodo_sublinea.ChildNodes
                    If nodo_campo.Name.Trim.ToUpper = "CAMPO" Then

                        Dim campo As New CampoImp(valores_defecto_documento)
                        ObtenerAtributosCampo(nodo_campo, campo)
                        SubLinea.NuevoCampo(campo)

                    End If
                Next

                'Incorpora la sublinea a la definición de sublíneas de la línea
                documento.MiLineas.NuevaSubLinea(SubLinea)

            Next


        End If

    End Sub


    Private Sub ObtenerPie(m_xmld As XmlDocument, ByRef documento As I_formato, valores_defecto_documento As Valores_defecto_documento)

        'Campos de pie
        Dim nodos_pie As XmlNodeList = m_xmld.SelectNodes("documento/pie")
        If nodos_pie.Count > 0 Then

            If nodos_pie.Count > 1 Then
                Throw New Exception("Sólo puede haber un nodo <pie>")
            End If

            Dim nodo_pie As XmlNode = nodos_pie(0)

            Dim altura As String = ValorAtributo(nodo_pie, "altura")
            documento.MiPie.Altura = VaInt(altura)

            For Each nodo_campo As XmlNode In nodo_pie.ChildNodes
                If nodo_campo.Name.Trim.ToUpper = "CAMPO" Then

                    Dim campo As New CampoImp(valores_defecto_documento)
                    ObtenerAtributosCampo(nodo_campo, campo)
                    documento.MiPie.NuevoCampo(campo)

                End If
            Next
        End If

    End Sub


    Private Sub ObtenerAtributosCampo(nodo_campo As XmlNode, ByRef campo As CampoImp)

        If Not IsNothing(nodo_campo) Then

            Dim n As XmlNode = nodo_campo.Attributes.GetNamedItem("fuente")
            If Not IsNothing(n) Then campo.fuente.Fuente = n.Value

            n = nodo_campo.Attributes.GetNamedItem("tamañofuente")
            If Not IsNothing(n) Then campo.fuente.Tamaño = VaDec(n.Value)

            n = nodo_campo.Attributes.GetNamedItem("alineacion")
            If Not IsNothing(n) Then campo.Alineacion = VaInt(n.Value)

            n = nodo_campo.Attributes.GetNamedItem("tcampo")
            If Not IsNothing(n) Then campo.tipocampo = VaInt(n.Value)

            n = nodo_campo.Attributes.GetNamedItem("neg")
            If Not IsNothing(n) Then campo.fuente.Negrita = ((n.Value & "").Trim.ToUpper = "S")

            n = nodo_campo.Attributes.GetNamedItem("sub")
            If Not IsNothing(n) Then campo.fuente.Subrayada = ((n.Value & "").Trim.ToUpper = "S")

            n = nodo_campo.Attributes.GetNamedItem("cur")
            If Not IsNothing(n) Then campo.fuente.Cursiva = ((n.Value & "").Trim.ToUpper = "S")

            n = nodo_campo.Attributes.GetNamedItem("nombre")
            If Not IsNothing(n) Then campo.Nombre = n.Value

            n = nodo_campo.Attributes.GetNamedItem("posx")
            If Not IsNothing(n) Then campo.PosX = VaInt(n.Value)

            n = nodo_campo.Attributes.GetNamedItem("posy")
            If Not IsNothing(n) Then campo.PosY = VaInt(n.Value)

            n = nodo_campo.Attributes.GetNamedItem("longitud")
            If Not IsNothing(n) Then campo.Longitud = VaInt(n.Value)

            n = nodo_campo.Attributes.GetNamedItem("altura")
            If Not IsNothing(n) Then campo.Altura = VaInt(n.Value)

            n = nodo_campo.Attributes.GetNamedItem("sublinea")
            If Not IsNothing(n) Then campo.Sublinea = VaInt(n.Value)


            If nodo_campo.InnerText.Trim <> "" Then campo.Valor = nodo_campo.InnerText

        End If


    End Sub


    Public Function ValorAtributo(nodo As XmlNode, atributo As String) As String

        Dim valor As String = ""

        Dim nodo_atributo As XmlNode = nodo.Attributes.GetNamedItem(atributo)
        If Not IsNothing(nodo_atributo) Then
            valor = nodo_atributo.Value
        End If

        Return valor

    End Function


    Public Sub Imprimir(Optional TipoImpresion As TipoImpresion = TipoImpresion.ImpresoraPorDefecto,
                        Optional Impresora As String = "",
                        Optional rutaPDF As String = "",
                        Optional archivoPDF As String = "")

        _documento.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)

    End Sub


End Class

