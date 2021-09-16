Public Class E_TraspasosCentros_Lineas
    Inherits Cdatos.Entidad

    Public TLI_IdLinea As Cdatos.bdcampo
    Public TLI_IdTraspaso As Cdatos.bdcampo
    Public TLI_Tipo As Cdatos.bdcampo
    Public TLI_Codigo As Cdatos.bdcampo

    Public TLI_IdUsuarioLog As Cdatos.bdcampo
    Public TLI_FechaLog As Cdatos.bdcampo
    Public TLI_HoraLog As Cdatos.bdcampo

    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "TraspasosCentros_Lineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            TLI_IdLinea = New Cdatos.bdcampo(CodigoEntidad & "IdLinea", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            TLI_IdTraspaso = New Cdatos.bdcampo(CodigoEntidad & "IdTraspaso", Cdatos.TiposCampo.EnteroPositivo, 10)
            TLI_Tipo = New Cdatos.bdcampo(CodigoEntidad & "Tipo", Cdatos.TiposCampo.Cadena, 1)
            TLI_Codigo = New Cdatos.bdcampo(CodigoEntidad & "Codigo", Cdatos.TiposCampo.EnteroPositivo, 10)
            'TLI_Codigo: P = Partida, L = Lote, T = Palet

            TLI_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            TLI_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            TLI_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


    Public Overrides Function Eliminar() As Boolean

        Me.ActualizaCodigos(True)

        Return MyBase.Eliminar()

    End Function


    Public Sub ActualizaCodigos(bBorrando As Boolean)


        Dim IdTraspaso As String = Me.TLI_IdTraspaso.Valor & ""


        If VaInt(IdTraspaso) > 0 Then

            Dim TraspasosCentros As New E_TraspasosCentros(Idusuario, cn)
            If TraspasosCentros.LeerId(IdTraspaso) Then

                Dim Campa As String = TraspasosCentros.TCE_Ejercicio.Valor & ""
                Dim Tipo As String = Me.TLI_Tipo.Valor & ""
                Dim Codigo As String = Me.TLI_Codigo.Valor & ""


                Dim IdUbicacion As Integer = UltimoCentroDestino(Tipo, Campa, Codigo, bBorrando, IdTraspaso)
                If IdUbicacion > 0 Then

                    Select Case Tipo
                        Case "P"
                            Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(IdUbicacion, cn)
                            If AlbEntrada_Lineas.LeerId(Codigo) Then
                                AlbEntrada_Lineas.AEL_IdUbicacionPV.Valor = IdUbicacion.ToString
                                AlbEntrada_Lineas.Actualizar()
                            End If

                        Case "L"
                            Dim Lotes As New E_Lotes(Idusuario, cn)
                            If Lotes.LeerId(Codigo) Then
                                Lotes.LTE_IdUbicacionPV.Valor = IdUbicacion.ToString
                                Lotes.Actualizar()
                            End If

                        Case "T"
                            Dim Palets As New E_palets(Idusuario, cn)
                            If Palets.LeerId(Codigo) Then
                                Palets.PAL_idpvsituacion.Valor = IdUbicacion.ToString
                                Palets.Actualizar()
                            End If

                        Case "C"
                            Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
                            If LotesProduccion.LeerId(Codigo) Then
                                LotesProduccion.LPD_IdUbicacionPV.Valor = IdUbicacion.ToString
                                LotesProduccion.Actualizar()
                            End If

                    End Select

                Else
                    MsgBox("Error al modificar la ubicación de las lineas del traspaso")
                End If

            End If


        End If


    End Sub



    Public Function UltimoCentroDestino(Tipo As String, Campa As Integer, Codigo As String, bBorrando As Boolean, IdTraspaso As String) As Integer

        'Para usar modificando o borrando un traspaso

        Dim res As Integer = 0


        Dim Destino As Integer = 0
        Dim Filas As Integer = 0


        Select Case Tipo

            Case "P"
                If VaInt(Codigo) > 0 Then

                    Dim sql As String = "SELECT TOP 2 TCE_IdTraspaso as IdTraspaso, TCE_IdCentroOrigen as Origen, TCE_IdCentroDestino as Destino" & vbCrLf
                    sql = sql & " FROM TraspasosCentros_Lineas" & vbCrLf
                    sql = sql & " LEFT JOIN TraspasosCentros ON TCE_IdTraspaso = TLI_IdTraspaso" & vbCrLf
                    sql = sql & " WHERE TLI_Tipo = 'P' AND COALESCE(TCE_IdTraspaso,0) > 0  AND TLI_Codigo = " & Codigo
                    sql = sql & " ORDER BY TCE_Fecha DESC, TCE_IdTraspaso DESC"

                    Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
                    If Not IsNothing(dt) Then
                        If dt.Rows.Count > 0 Then

                            Filas = dt.Rows.Count

                            'Si estamos modificando me tiene que devolver un registro al menos
                            Dim row As DataRow = dt.Rows(0)
                            Destino = VaInt(row("Destino"))

                        End If
                    End If

                End If

            Case "L"
                If VaInt(Codigo) > 0 Then

                    Dim sql As String = "SELECT TOP 2 TCE_IdTraspaso as IdTraspaso, TCE_IdCentroOrigen as Origen, TCE_IdCentroDestino as Destino" & vbCrLf
                    sql = sql & " FROM TraspasosCentros_Lineas" & vbCrLf
                    sql = sql & " LEFT JOIN TraspasosCentros ON TCE_IdTraspaso = TLI_IdTraspaso" & vbCrLf
                    sql = sql & " WHERE TLI_Tipo = 'L' AND COALESCE(TCE_IdTraspaso,0) > 0  AND TLI_Codigo = " & Codigo
                    sql = sql & " ORDER BY TCE_Fecha DESC, TCE_IdTraspaso DESC"

                    Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
                    If Not IsNothing(dt) Then
                        If dt.Rows.Count > 0 Then

                            Filas = dt.Rows.Count

                            'Si estamos modificando me tiene que devolver un registro al menos
                            Dim row As DataRow = dt.Rows(0)
                            Destino = VaInt(row("Destino"))

                        End If
                    End If

                End If

            Case "T"
                If VaInt(Codigo) > 0 Then

                    Dim sql As String = "SELECT TOP 2 TCE_IdTraspaso as IdTraspaso, TCE_IdCentroOrigen as Origen, TCE_IdCentroDestino as Destino" & vbCrLf
                    sql = sql & " FROM TraspasosCentros_Lineas" & vbCrLf
                    sql = sql & " LEFT JOIN TraspasosCentros ON TCE_IdTraspaso = TLI_IdTraspaso" & vbCrLf
                    sql = sql & " WHERE TLI_Tipo = 'T' AND COALESCE(TCE_IdTraspaso,0) > 0  AND TLI_Codigo = " & Codigo
                    sql = sql & " ORDER BY TCE_Fecha DESC, TCE_IdTraspaso DESC"

                    Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
                    If Not IsNothing(dt) Then
                        If dt.Rows.Count > 0 Then

                            Filas = dt.Rows.Count

                            'Si estamos modificando me tiene que devolver un registro al menos
                            Dim row As DataRow = dt.Rows(0)
                            Destino = VaInt(row("Destino"))

                        End If
                    End If

                End If


            Case "C"
                If VaInt(Codigo) > 0 Then

                    Dim sql As String = "SELECT TOP 2 TCE_IdTraspaso as IdTraspaso, TCE_IdCentroOrigen as Origen, TCE_IdCentroDestino as Destino" & vbCrLf
                    sql = sql & " FROM TraspasosCentros_Lineas" & vbCrLf
                    sql = sql & " LEFT JOIN TraspasosCentros ON TCE_IdTraspaso = TLI_IdTraspaso" & vbCrLf
                    sql = sql & " WHERE TLI_Tipo = 'C' AND COALESCE(TCE_IdTraspaso,0) > 0  AND TLI_Codigo = " & Codigo & vbCrLf
                    If bBorrando Then
                        sql = sql & " AND TLI_IdTraspaso <> " & IdTraspaso & vbCrLf
                    End If
                    sql = sql & " ORDER BY TCE_Fecha DESC, TCE_IdTraspaso DESC"

                    Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
                    If Not IsNothing(dt) Then
                        If dt.Rows.Count > 0 Then

                            Filas = dt.Rows.Count

                            'Si estamos modificando me tiene que devolver un registro al menos
                            Dim row As DataRow = dt.Rows(0)
                            Destino = VaInt(row("Destino"))

                        End If
                    End If

                End If



        End Select



        If bBorrando Then
            If Filas > 1 Then
                res = Destino
            Else
                Dim TraspasosCentros As New E_TraspasosCentros(Idusuario, cn)
                If TraspasosCentros.LeerId(IdTraspaso) Then
                    If VaInt(TraspasosCentros.TCE_IdCentroOrigen.Valor) > 0 Then
                        res = VaInt(TraspasosCentros.TCE_IdCentroOrigen.Valor)
                    End If
                End If
            End If
        Else
            res = Destino
        End If



        Return res

    End Function


End Class
