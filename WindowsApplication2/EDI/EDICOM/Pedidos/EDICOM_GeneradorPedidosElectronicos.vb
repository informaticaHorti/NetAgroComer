Imports System.Net
Imports System.IO
Imports NetAgro.EDICOM
Imports NetAgro.EDI

Namespace EDICOM


    Public Class EDICOM_GeneradorPedidosElectronicos
        Inherits EDI.EDI_GeneradorPedidosElectronicos


        'Dim CABPED As String = Me.Carpeta_origen & "CABPED.TXT"
        'Dim OBSPED As String = Me.Carpeta_origen & "OBSPED.TXT"
        'Dim LINPED As String = Me.Carpeta_origen & "LINPED.TXT"
        'Dim OBSLPED As String = Me.Carpeta_origen & "OBSLPED.TXT"
        'Dim LOCLPED As String = Me.Carpeta_origen & "LOCLPED.TXT"


        Public Sub New(ByVal carpeta_origen As String)
            MyBase.New(EDI.Comun.ProveedorEDI.EDICOM, carpeta_origen)

        End Sub



        Public Overrides Function Resultado(DcFicheros As Dictionary(Of String, String)) As System.Collections.Generic.List(Of EDI.EDI_Pedido)

            Dim lstPedidos As List(Of String) = Nothing
            Dim DcPedidos As New Dictionary(Of String, EDICOM_Pedido)
            Dim DcLineas As New Dictionary(Of String, EDICOM_DetallePedido)


            Dim CABPED As String = "" : If DcFicheros.ContainsKey("CABPED.TXT") Then CABPED = DcFicheros("CABPED.TXT")
            Dim LINPED As String = "" : If DcFicheros.ContainsKey("LINPED.TXT") Then LINPED = DcFicheros("LINPED.TXT")
            Dim OBSPED As String = "" : If DcFicheros.ContainsKey("OBSPED.TXT") Then OBSPED = DcFicheros("OBSPED.TXT")
            Dim OBSLPED As String = "" : If DcFicheros.ContainsKey("OBSLPED.TXT") Then OBSLPED = DcFicheros("OBSLPED.TXT")
            Dim LOCLPED As String = "" : If DcFicheros.ContainsKey("LOCLPED.TXT") Then LOCLPED = DcFicheros("LOCLPED.TXT")

            Dim bExisteCabecera As Boolean = False
            Dim bExisteLineas As Boolean = False

            If CABPED.Trim <> "" Then bExisteCabecera = IO.File.Exists(CABPED)
            If LINPED.Trim <> "" Then bExisteLineas = IO.File.Exists(LINPED)

            If bExisteCabecera And bExisteLineas Then

                If CABPED.Trim <> "" Then lstPedidos = ObtenerPedidos(CABPED, DcPedidos) 'Crea cabeceras a partir de fichero
                If LINPED.Trim <> "" Then AñadirLineasPedido(LINPED, DcPedidos) 'Crea y añade líneas a partir de fichero
                If OBSPED.Trim <> "" Then AñadirObservacionesCabecera(OBSPED, DcPedidos) 'Crea y añade obs cabecera a partir de fichero
                If OBSLPED.Trim <> "" Then AñadirObservacionesLineas(OBSLPED, DcPedidos) 'Crea y añade obs líneas a partir de fichero
                If LOCLPED.Trim <> "" Then AñadirDesgloseLineas(LOCLPED, DcPedidos) 'Crea y añade líneas de desglose a partir de fichero

            Else

                If Not bExisteCabecera Then
                    MsgBox("Falta fichero CABPED.TXT")
                End If

                If Not bExisteLineas Then
                    MsgBox("Falta fichero LINPED.TXT")
                End If

            End If


            If IsNothing(lstPedidos) Then
                lstPedidos = New List(Of String)
            End If


            Dim lst As New List(Of EDI_Pedido)
            If lstPedidos.Count > 0 Then

                For Each NumeroPedido As String In lstPedidos

                    If DcPedidos.ContainsKey(NumeroPedido) Then
                        lst.Add(DcPedidos(NumeroPedido))
                    End If

                    Application.DoEvents()
                Next

            End If


            Return lst

        End Function


        Private Function ObtenerPedidos(ByVal CABPED As String, ByRef DcPedidos As Dictionary(Of String, EDICOM_Pedido)) As List(Of String)

            Dim lst As New List(Of String)
            DcPedidos.Clear()


            'Procesamos las cabeceras de los pedidos
            Try

                Dim fs As New IO.FileStream(CABPED, IO.FileMode.Open)
                Dim sr As New System.IO.StreamReader(fs)
                Dim linea_fichero As String = sr.ReadLine

                While linea_fichero <> Nothing

                    linea_fichero = linea_fichero.Replace(Chr(34), "")
                    If linea_fichero.Trim <> "" Then

                        'Genera y añade la cabecera del pedido al diccionario
                        Dim Pedido As New EDICOM_Pedido(linea_fichero)
                        DcPedidos(Pedido.ClavePedido) = Pedido
                        lst.Add(Pedido.ClavePedido)

                    End If

                    linea_fichero = sr.ReadLine()
                    Application.DoEvents()

                End While


                sr.Close()
                fs.Close()
                sr.Dispose()
                fs.Dispose()

                sr = Nothing
                fs = Nothing

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            



            Return lst

        End Function


        Private Sub AñadirLineasPedido(ByVal LINPED As String, ByRef DcPedidos As Dictionary(Of String, EDICOM_Pedido))

            'Procesamos las líneas de los pedidos
            Dim fs As New IO.FileStream(LINPED, IO.FileMode.Open)
            Dim sr As New System.IO.StreamReader(fs)
            Dim linea_fichero As String = sr.ReadLine

            While linea_fichero <> Nothing

                linea_fichero = linea_fichero.Replace(Chr(34), "")
                If linea_fichero.Trim <> "" Then

                    'Genera y añade la línea al pedido
                    Dim Linea As New EDICOM_DetallePedido(linea_fichero)

                    If DcPedidos.ContainsKey(Linea.ClavePedido) Then
                        DcPedidos(Linea.ClavePedido).AñadeLineasPedido(Linea)
                    End If

                End If

                linea_fichero = sr.ReadLine()
                Application.DoEvents()

            End While


            sr.Close()
            fs.Close()
            sr.Dispose()
            fs.Dispose()

            sr = Nothing
            fs = Nothing

        End Sub


        Private Sub AñadirObservacionesCabecera(ByVal OBSPED As String, ByRef DcPedidos As Dictionary(Of String, EDICOM_Pedido))

            'Procesamos las observaciones de la cabecera
            Dim fs As New IO.FileStream(OBSPED, IO.FileMode.Open)
            Dim sr As New System.IO.StreamReader(fs)
            Dim linea_fichero As String = sr.ReadLine

            While linea_fichero <> Nothing

                linea_fichero = linea_fichero.Replace(Chr(34), "")
                If linea_fichero.Trim <> "" Then

                    'Genera y añade la observación al pedido
                    Dim Observacion As New EDICOM_ObservacionesGlobalesPedido(linea_fichero)

                    If DcPedidos.ContainsKey(Observacion.ClavePedido) Then
                        DcPedidos(Observacion.ClavePedido).AñadeObservacionesGlobales(Observacion)
                    End If

                End If

                linea_fichero = sr.ReadLine()
                Application.DoEvents()

            End While


            sr.Close()
            fs.Close()
            sr.Dispose()
            fs.Dispose()

            sr = Nothing
            fs = Nothing

        End Sub


        Private Sub AñadirObservacionesLineas(ByVal OBSLPED As String, ByRef DcPedidos As Dictionary(Of String, EDICOM_Pedido))

            'Procesamos las observaciones de las líneas
            Dim fs As New IO.FileStream(OBSLPED, IO.FileMode.Open)
            Dim sr As New System.IO.StreamReader(fs)
            Dim linea_fichero As String = sr.ReadLine

            While linea_fichero <> Nothing

                linea_fichero = linea_fichero.Replace(Chr(34), "")
                If linea_fichero.Trim <> "" Then

                    'Genera y añade la observación al pedido
                    Dim ObservacionLinea As New EDICOM_ObservacionesLineasPedido(linea_fichero)

                    If DcPedidos.ContainsKey(ObservacionLinea.ClavePedido) Then
                        For Each LineaPedido As EDICOM_DetallePedido In DcPedidos(ObservacionLinea.ClavePedido).Lineas

                            If ObservacionLinea.NumeroLinea = LineaPedido.NumeroLinea Then
                                LineaPedido.ObservacionesLinea.Add(ObservacionLinea)
                                Exit For
                            End If

                            Application.DoEvents()

                        Next
                    End If

                End If

                linea_fichero = sr.ReadLine()
                Application.DoEvents()

            End While


            sr.Close()
            fs.Close()
            sr.Dispose()
            fs.Dispose()

            sr = Nothing
            fs = Nothing

        End Sub


        Private Sub AñadirDesgloseLineas(ByVal LOCLPED As String, ByRef DcPedidos As Dictionary(Of String, EDICOM_Pedido))

            'Procesamos el desglose de las líneas
            Dim fs As New IO.FileStream(LOCLPED, IO.FileMode.Open)
            Dim sr As New System.IO.StreamReader(fs)
            Dim linea_fichero As String = sr.ReadLine

            While linea_fichero <> Nothing

                linea_fichero = linea_fichero.Replace(Chr(34), "")
                If linea_fichero.Trim <> "" Then

                    'Genera y añade la observación al pedido
                    Dim DesgloseLinea As New EDICOM_DesgloseLineasPedido(linea_fichero)

                    If DcPedidos.ContainsKey(DesgloseLinea.ClavePedido) Then
                        For Each LineaPedido As EDICOM_DetallePedido In DcPedidos(DesgloseLinea.ClavePedido).Lineas

                            If DesgloseLinea.NumeroLinea = LineaPedido.NumeroLinea Then
                                LineaPedido.DesgloseLinea.Add(DesgloseLinea)
                                Exit For
                            End If

                            Application.DoEvents()

                        Next

                    End If

                End If


                linea_fichero = sr.ReadLine()
                Application.DoEvents()

            End While


            sr.Close()
            fs.Close()
            sr.Dispose()
            fs.Dispose()

            sr = Nothing
            fs = Nothing

        End Sub


        'Private Function BorrarFicheros() As Boolean

        '    Dim bRes As Boolean = True


        '    Dim bCABPED As Boolean = IO.File.Exists(CABPED)
        '    Dim bLINPED As Boolean = IO.File.Exists(LINPED)
        '    Dim bOBSPED As Boolean = IO.File.Exists(OBSPED)
        '    Dim bOBSLPED As Boolean = IO.File.Exists(OBSLPED)
        '    Dim bLOCLPED As Boolean = IO.File.Exists(LOCLPED)

        '    If bCABPED Then
        '        Try
        '            IO.File.Delete(CABPED)
        '        Catch ex As Exception
        '            bRes = False
        '            MsgBox("Error al borrar el fichero CABPED.TXT. Por favor, bórrelo a mano para poder seguir recibiendo pedidos vía electrónica")
        '        End Try
        '    End If

        '    If bLINPED Then
        '        Try
        '            IO.File.Delete(LINPED)
        '        Catch ex As Exception
        '            bRes = False
        '            MsgBox("Error al borrar el fichero LINPED.TXT. Por favor, bórrelo a mano para poder seguir recibiendo pedidos vía electrónica")
        '        End Try
        '    End If

        '    If bOBSPED Then
        '        Try
        '            IO.File.Delete(OBSPED)
        '        Catch ex As Exception
        '            bRes = False
        '            MsgBox("Error al borrar el fichero OBSPED.TXT. Por favor, bórrelo a mano para poder seguir recibiendo pedidos vía electrónica")
        '        End Try
        '    End If

        '    If bOBSLPED Then
        '        Try
        '            IO.File.Delete(OBSLPED)
        '        Catch ex As Exception
        '            bRes = False
        '            MsgBox("Error al borrar el fichero OBSLPED.TXT. Por favor, bórrelo a mano para poder seguir recibiendo pedidos vía electrónica")
        '        End Try
        '    End If

        '    If bLOCLPED Then
        '        Try
        '            IO.File.Delete(LOCLPED)
        '        Catch ex As Exception
        '            bRes = False
        '            MsgBox("Error al borrar el fichero LOCLPED.TXT. Por favor, bórrelo a mano para poder seguir recibiendo pedidos vía electrónica")
        '        End Try
        '    End If

        '    Return bRes

        'End Function


        'Public Overrides Sub AñadirPedido(DcPedidos As System.Collections.Generic.Dictionary(Of String, String))

        '    For Each archivo As String In DcPedidos.Keys

        '        Dim nombre_archivo As String = DcPedidos(archivo)
        '        Select Case archivo

        '            Case "CABPED.TXT"
        '                Me.CABPED = nombre_archivo
        '            Case "LINPED.TXT"
        '                Me.LINPED = nombre_archivo
        '            Case "OBSPED.TXT"
        '                Me.OBSPED = nombre_archivo
        '            Case "OBSLPED.TXT"
        '                Me.OBSLPED = nombre_archivo
        '            Case "LOCLPED.TXT"
        '                Me.LOCLPED = nombre_archivo

        '        End Select

        '    Next

        'End Sub


    End Class


End Namespace


