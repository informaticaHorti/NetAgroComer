
Namespace EDI


    Public Class Comun


        'Formato proveedores
        Public Shared Proveedores_EDI As String() = {"SERES", "EDICOM"}


        Public Enum ProveedorEDI

            SERES
            EDICOM

        End Enum



        '----------------------------------------------------------------------------------
        'FACTURAS
        '----------------------------------------------------------------------------------

        Public Enum TipoRegistro

            'Basado en seres, indica el tipo de línea
            Registro_de_control
            Cabecera
            Informacion_partes_involucradas
            Observaciones_cabecera
            Vencimientos
            Descuentos_y_cargos_cabecera
            Linea_detalle
            Observaciones_linea_detalle
            Descuentos_y_cargos_linea_detalle
            Impuestos

            Cabecera_pedido
            Observaciones_cabecera_pedido
            Linea_detalle_pedido
            Observaciones_linea_detalle_pedido
            Desglose_linea_pedido

        End Enum


        'RECTL (Registro de control) --> SERES
        '   |
        '   ->  SINCC (Cabecera)
        '           |
        '           -> SINCP (Direcciones - Partes involucradas)
        '           |
        '           -> SINCT (Textos - Observaciones cabecera)
        '           |
        '           -> SINCD (Descuentos - y cargos cabecera)
        '           |
        '           -> SINCV (Vencimientos ?)
        '           |
        '           -> SINCI (Impuestos)
        '           |
        '           -> SINCL (Detalle)
        '               |
        '               -> SINCE (Descuentos - líneas)
        '               |
        '               -> SINCU (Textos - Observaciones líneas)





        '----------------------------------------------------------------------------------
        'PEDIDOS
        '----------------------------------------------------------------------------------

        Public Enum FuncionMensaje

            Vacio
            Original
            Reemplazo

        End Enum


        Public Shared Function ObtenerClienteGLN(ByVal GLN_Comprador As String, ByRef Comprador As String) As Integer

            Dim res As Integer = 0
            Comprador = ""


            If GLN_Comprador.Trim <> "" Then

                Dim sql As String = "SELECT CLI_IdCliente as IdCliente, CLI_Nombre as Cliente FROM Clientes WHERE CLI_CompradorEDI = '" & GLN_Comprador & "'"
                Dim dt As DataTable = cn.ConsultaSQL(sql)
                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 1 Then
                        MsgBox("ERROR: El código GLN de comprador " & GLN_Comprador & " está asignado a varios clientes")
                    ElseIf dt.Rows.Count > 0 Then
                        Dim row As DataRow = dt.Rows(0)
                        res = VaInt(row("IdCliente"))
                        Comprador = (row("Cliente").ToString & "").Trim
                    End If
                End If

            End If

            Return res

        End Function


        Public Shared Function ObtenerPresentacionEAN(ByRef IdGenero As Integer, ByRef Genero As String, ByRef IdTipoConfeccion As Integer, ByRef ConfeccionEnvase As String,
                                                      ByVal GLN_Comprador As String, ByVal EAN_Articulo As String, ByRef Presentacion As String) As Integer

            Dim res As Integer = 0
            IdGenero = 0
            Genero = ""
            IdTipoConfeccion = 0
            ConfeccionEnvase = ""
            Presentacion = ""

            If EAN_Articulo.Trim <> "" And GLN_Comprador <> "" Then

                Dim sql As String = "SELECT CED_IdGenero as IdGenero, GEN_NombreGenero as Genero, GES_IdConfec as IdTipoConfeccion, CEV_Nombre as Confeccion, CED_IdPresentacion as IdPresentacion, GES_Nombre as Presentacion " & vbCrLf
                sql = sql & " FROM ClientesEDI" & vbCrLf
                sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = CED_IdGenero" & vbCrLf
                sql = sql & " LEFT JOIN GenerosSalida ON GES_IdGenSal = CED_IdPresentacion" & vbCrLf
                sql = sql & " LEFT JOIN Clientes ON CLI_IdCliente = CED_IdCliente" & vbCrLf
                sql = sql & " LEFT JOIN ConfecEnvase ON CEV_IdConfec = GES_IdConfec" & vbCrLf
                sql = sql & " WHERE CED_CodigoEDI = '" & EAN_Articulo & "' AND CLI_CompradorEDI = '" & GLN_Comprador & "'" & vbCrLf


                Dim dt As DataTable = cn.ConsultaSQL(sql)
                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 1 Then
                        MsgBox("ERROR: El código EAN del artículo " & EAN_Articulo & " está asignado varias veces para el mismo cliente")
                    ElseIf dt.Rows.Count > 0 Then

                        Dim row As DataRow = dt.Rows(0)

                        IdGenero = VaInt(row("IdGenero"))
                        Genero = (row("Genero").ToString & "").Trim
                        IdTipoConfeccion = VaInt(row("IdTipoConfeccion"))
                        ConfeccionEnvase = (row("Confeccion").ToString & "").Trim
                        res = VaInt(row("IdPresentacion"))
                        Presentacion = (row("Presentacion").ToString & "").Trim

                    End If
                End If

            End If


            Return res

        End Function


        Public Shared Function ObtenerDomicilioDescarga(ByVal GLN_Comprador As String, ByVal GLN_Receptor As String, ByRef DomicilioDescarga As String) As Integer

            Dim res As Integer = 0
            DomicilioDescarga = ""


            If GLN_Comprador.Trim <> "" And GLN_Receptor <> "" Then

                Dim sql As String = "SELECT CLD_Id as IdDomicilio, CLD_NombreDomicilio as DomicilioDescarga" & vbCrLf
                sql = sql & " FROM ClientesDescargas" & vbCrLf
                sql = sql & " LEFT JOIN Clientes ON CLI_IdCliente = CLD_IdCliente" & vbCrLf
                sql = sql & " WHERE CLI_CompradorEDI = '" & GLN_Comprador & "' AND CLD_CodigoEDI = '" & GLN_Receptor & "'" & vbCrLf

                Dim dt As DataTable = cn.ConsultaSQL(sql)
                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 1 Then
                        MsgBox("ERROR: El código GLN del domiclio de descarga " & GLN_Receptor & " está asignado varias veces para el mismo cliente")
                    ElseIf dt.Rows.Count > 0 Then
                        Dim row As DataRow = dt.Rows(0)
                        res = VaInt(row("IdDomicilio"))
                        DomicilioDescarga = (row("DomicilioDescarga").ToString & "").Trim
                    End If
                End If


            End If


            Return res

        End Function



    End Class


End Namespace




