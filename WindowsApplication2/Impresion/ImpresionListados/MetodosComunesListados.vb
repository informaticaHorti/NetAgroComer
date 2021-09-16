Public Enum TipoImpresion
    Preliminar
    ImpresoraPorDefecto
    ImpresoraSeleccionada
    ExportacionPDF
    Email
    Fax
    Cancelar
End Enum

Public Enum Estilos
    MuyGrandeBold
    Cabecera
    Grande
    GrandeBold
    Normal
    NormalBold
    NormalBoldLineaEncima
    NormalBoldLineaDebajo
    Reducida
    ReducidaLineaEncima
    ReducidaLineaDebajo
    ReducidaBold
    ReducidaBoldLineaEncima
    ReducidaBoldLineaDebajo
    Minima
    MinimaCursiva
    MinimaBold
    MinimaBoldLineaEncima
    MinimaBoldLineaDebajo
    Custom
End Enum

Public Enum Orientacion
    Vertical
    Horizontal
End Enum

Public Enum LimiteFiltro
    Superior
    Inferior
End Enum

Public Structure Margen
    Public Izquierdo As Integer
    Public Derecho As Integer
    Public Superior As Integer
    Public Inferior As Integer
End Structure

Module MetodosComunesListados

    Public _Fuente_MuyGrandeBold As New Font("Tahoma", 20, FontStyle.Bold)
    Public _Fuente_Cabecera As New Font("Tahoma", 16, FontStyle.Bold)
    Public _Fuente_Grande As New Font("Tahoma", 12)
    Public _Fuente_GrandeBold As New Font("Tahoma", 12, FontStyle.Bold)
    Public _Fuente_Normal As New Font("Tahoma", 10)
    Public _Fuente_NormalBold As New Font("Tahoma", 10, FontStyle.Bold)
    Public _Fuente_Reducida As New Font("Tahoma", 8)
    Public _Fuente_ReducidaBold As New Font("Tahoma", 8, FontStyle.Bold)
    Public _Fuente_Minima As New Font("Tahoma", 6)
    Public _Fuente_Minima_Cursiva As New Font("Tahoma", 6, FontStyle.Italic)
    Public _Fuente_MinimaBold As New Font("Tahoma", 6, FontStyle.Bold)

    Public Const Documento_Factura As String = "F"
    Public Const Documento_Albaran As String = "A"
    Public Const Documento_CMR_Nacional As String = "N"
    Public Const Documento_CMR_Internacional As String = "I"
    Public Const Documento_CopiaFactura As String = "C"

    Public Function ListaIntegerToString(ByVal lista As List(Of Integer)) As List(Of String)
        Dim listaString As New List(Of String)

        For Each e As Integer In lista
            listaString.Add(e.ToString)
        Next

        Return listaString
    End Function

    Public Function ObtenerListaFiltros(ByVal lista As List(Of String)) As String
        Dim cadena As String = ""
        Dim conector As String = ""

        For Each e As String In lista
            cadena = cadena & conector
            If Len(e.Trim) > 0 Then
                cadena = cadena & e
                conector = ", "
            End If
        Next

        Return cadena
    End Function

    Public Sub FormatoFiltro(ByRef filtro As String, Optional ByVal numeroDigitos As Integer = 5, Optional ByVal limite As LimiteFiltro = LimiteFiltro.Inferior)
        If Len(filtro.Trim) = 0 Then
            Select Case limite
                Case LimiteFiltro.Inferior
                    For i = 1 To numeroDigitos
                        filtro = filtro & "0"
                    Next
                Case LimiteFiltro.Superior
                    For i = 1 To numeroDigitos
                        filtro = filtro & "9"
                    Next
            End Select
        Else
            filtro = filtro.PadLeft(numeroDigitos, "0")
        End If
    End Sub

End Module
