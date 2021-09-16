
Module Funciones_SII

    Public Enum TipoIdentificacion

        NIF = 2
        Pasaporte = 3
        DocumentoPaisResidencia = 4
        CertificadoResidencia = 5
        Otro = 6

    End Enum



    'Public Function SII_ExisteFacturaEnAEAT(IdAsiento As String) As Boolean

    '    Dim lstAsientos As New List(Of String)
    '    lstAsientos.Add(IdAsiento)

    '    Return SII_ExisteFacturaEnAEAT(lstAsientos)

    'End Function



    'Public Function SII_ExisteFacturaEnAEAT(lstAsientos As List(Of String)) As Boolean


    '    Dim bRes As Boolean = False


    '    If lstAsientos.Count > 0 Then

    '        Dim AsientoLineas As New E_AsientoLineas(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    '        Dim sqlAsiento As String = CadenaWhereLista(AsientoLineas.IdAsiento, lstAsientos, " WHERE ")


    '        Dim sql As String = "SELECT 'R' as Tipo, IvaRepercutido.IdRegistro as IdRegistro" & vbCrLf
    '        sql = sql & " FROM AsientoLineas" & vbCrLf
    '        sql = sql & " INNER JOIN IvaRepercutido ON (SRPC = 'R' AND IdApunte = IvaRepercutido.IdRegistro)" & vbCrLf
    '        sql = sql & sqlAsiento & vbCrLf
    '        sql = sql & " AND COALESCE(FechaHoraSubida_AEAT, '') <> '' " & vbCrLf
    '        sql = sql & " UNION ALL" & vbCrLf
    '        sql = sql & " SELECT 'S' as Tipo, IvaSoportado.IdRegistro as IdRegistro" & vbCrLf
    '        sql = sql & " FROM AsientoLineas" & vbCrLf
    '        sql = sql & " INNER JOIN IvaSoportado ON (SRPC = 'S' AND IdApunte = IvaSoportado.IdRegistro)" & vbCrLf
    '        sql = sql & sqlAsiento & vbCrLf
    '        sql = sql & " AND COALESCE(FechaHoraSubida_AEAT, '') <> '' " & vbCrLf


    '        Dim dt As DataTable = ConexCtb(MiMaletin.IdEmpresaCTB).ConsultaSQL(sql)
    '        If Not IsNothing(dt) Then
    '            If dt.Rows.Count > 0 Then

    '                bRes = True

    '            End If
    '        End If

    '    End If


    '    Return bRes

    'End Function


    'Public Function SII_ComprobarFacturaEnviadaAEAT(IdAsiento As String) As Boolean

    '    Dim lstAsientos As New List(Of String)
    '    lstAsientos.Add(IdAsiento)

    '    Return SII_ComprobarFacturaEnviadaAEAT(lstAsientos)

    'End Function


    'Public Function SII_ComprobarFacturaEnviadaAEAT(lstAsientos As List(Of String)) As Boolean

    '    Dim bRes As Boolean = False


    '    Dim bExisteEnAEAT As Boolean = SII_ExisteFacturaEnAEAT(lstAsientos)

    '    If bExisteEnAEAT Then

    '        'Comprobar si hay que pedir PIN
    '        Dim DatosEmpresa As New E_DatosEmpresa(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    '        If MiMaletin.IdEmpresaCTB > 0 Then

    '            If DatosEmpresa.LeerId(MiMaletin.IdEmpresaCTB.ToString) Then

    '                Dim PIN As String = (DatosEmpresa.PINFacturas.Valor & "").Trim
    '                If PIN <> "" Then

    '                    'Pedir PIN
    '                    Dim frm As New FrmPINFacturas(PIN)
    '                    frm.ShowDialog()
    '                    If frm.Resultado = FrmPINFacturas.ResultadoClave.PIN_Ok Then
    '                        bRes = True
    '                    End If

    '                Else
    '                    bRes = True
    '                End If

    '            End If

    '        End If


    '    Else
    '        bRes = True
    '    End If



    '    Return bRes

    'End Function


    Public Function FacturaEnviada_AEAT(IdRegistro As String, SR As String) As Boolean

        Dim bRes As Boolean = False


        Select Case SR

            Case "S"

                'Soportado
                Dim sql As String = "SELECT FechaHoraSubida_AEAT " & vbCrLf
                sql = sql & " FROM IvaSoportado" & vbCrLf
                sql = sql & " WHERE IdRegistro = " & IdRegistro & vbCrLf
                sql = sql & " AND COALESCE(FechaHoraSubida_AEAT, '') <> '' " & vbCrLf

                Dim dt As DataTable = ConexCtb(MiMaletin.IdEmpresaCTB).ConsultaSQL(sql)
                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 0 Then bRes = True
                End If

            Case "R"

                'Repercutido
                Dim sql As String = "SELECT FechaHoraSubida_AEAT " & vbCrLf
                sql = sql & " FROM IvaRepercutido" & vbCrLf
                sql = sql & " WHERE IdRegistro = " & IdRegistro & vbCrLf
                sql = sql & " AND COALESCE(FechaHoraSubida_AEAT, '') <> '' " & vbCrLf

                Dim dt As DataTable = ConexCtb(MiMaletin.IdEmpresaCTB).ConsultaSQL(sql)
                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 0 Then bRes = True
                End If

        End Select


        Return bRes

    End Function



    Public Function FacturaEnviada_AEAT(IdAsiento As String) As Boolean

        Dim lstAsientos As New List(Of String)
        If VaDec(IdAsiento) > 0 Then lstAsientos.Add(IdAsiento)

        Return FacturaEnviada_AEAT(lstAsientos)

    End Function



    Public Function FacturaEnviada_AEAT(lst As List(Of String)) As Boolean

        Dim bRes As Boolean = False


        Dim lstAsientos As New List(Of String)
        For Each asiento As String In lst
            If VaDec(asiento) > 0 Then
                lstAsientos.Add(asiento)
            End If
        Next


        If lstAsientos.Count > 0 Then


            Dim AsientoLineas As New E_AsientoLineas(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
            Dim sqlAsiento As String = CadenaWhereLista(AsientoLineas.IdAsiento, lstAsientos, " WHERE ")


            Dim sql As String = "SELECT FechaHoraSubida_AEAT " & vbCrLf
            sql = sql & " FROM IvaSoportado" & vbCrLf
            sql = sql & " LEFT JOIN AsientoLineas ON (IdApunte = IvaSoportado.IdRegistro AND SRPC = 'S')" & vbCrLf
            sql = sql & sqlAsiento & vbCrLf
            sql = sql & " AND COALESCE(FechaHoraSubida_AEAT, '') <> ''" & vbCrLf
            sql = sql & " UNION ALL" & vbCrLf
            sql = sql & " Select FechaHoraSubida_AEAT" & vbCrLf
            sql = sql & " FROM IvaRepercutido" & vbCrLf
            sql = sql & " LEFT JOIN AsientoLineas ON (IdApunte = IvaRepercutido.IdRegistro AND SRPC = 'R')" & vbCrLf
            sql = sql & sqlAsiento & vbCrLf
            sql = sql & " AND COALESCE(FechaHoraSubida_AEAT, '') <> ''" & vbCrLf


            Dim dt As DataTable = ConexCtb(MiMaletin.IdEmpresaCTB).ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then bRes = True
            End If

        End If


        Return bRes

    End Function



    Public Function SII_ObtenerDatosProveedor(ByVal IdProveedor As String, ByVal Serie As String, ByVal Numero As String,
                                              ByRef Descripcion As String) As String

        Dim siglas As String = ""
        Descripcion = ""


        If VaInt(IdProveedor) > 0 Then

            Dim sql As String = "SELECT Siglas, AGR_Nombre as Nombre " & vbCrLf
            sql = sql & " FROM Agricultores" & vbCrLf
            sql = sql & " LEFT JOIN Comun.dbo.Paises ON Paises.IdPais = Agricultores.AGR_IdPais" & vbCrLf
            sql = sql & " WHERE AGR_IdAgricultor = " & IdProveedor & vbCrLf

            Dim dt As DataTable = cn.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                If dt.Rows.Count > 0 Then

                    Dim row As DataRow = dt.Rows(0)
                    siglas = (row("Siglas").ToString & "").Trim.ToUpper
                    Descripcion = SII_ObtenerDescripcionFactura(Serie, Numero, (row("Nombre").ToString & "").Trim)

                End If

            End If

        End If


        Return siglas

    End Function


    Public Function SII_ObtenerDatosAcreedor(ByVal IdAcreedor As String, ByVal Serie As String, ByVal Numero As String,
                                             ByRef Descripcion As String) As String

        Dim siglas As String = ""
        Descripcion = ""


        If VaInt(IdAcreedor) > 0 Then

            Dim sql As String = "SELECT Siglas, ACR_Nombre as Nombre " & vbCrLf
            sql = sql & " FROM Acreedores" & vbCrLf
            sql = sql & " LEFT JOIN Contabilidad.dbo.Cuentas ON ACR_IdCuenta = Cuentas.NumeroCuenta" & vbCrLf
            sql = sql & " LEFT JOIN Comun.dbo.Paises ON Paises.IdPais = Cuentas.IdPais" & vbCrLf
            sql = sql & " WHERE ACR_Codigo = " & IdAcreedor & vbCrLf

            Dim dt As DataTable = cn.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                If dt.Rows.Count > 0 Then

                    Dim row As DataRow = dt.Rows(0)
                    siglas = (row("Siglas").ToString & "").Trim.ToUpper
                    Descripcion = SII_ObtenerDescripcionFactura(Serie, Numero, (row("Nombre").ToString & "").Trim)

                End If

            End If

        End If



        Return siglas

    End Function


    Public Function SII_ObtenerDatosCliente(ByVal IdCliente As String, ByVal Serie As String, ByVal Numero As String,
                                             ByRef Descripcion As String) As String

        Dim siglas As String = ""


        If VaInt(IdCliente) > 0 Then

            Dim sql As String = "SELECT Siglas, CLI_Nombre as Nombre" & vbCrLf
            sql = sql & " FROM Clientes" & vbCrLf
            sql = sql & " LEFT JOIN Comun.dbo.Paises ON Clientes.CLI_IdPais = Paises.IdPais " & vbCrLf
            sql = sql & " WHERE CLI_IdCliente = " & IdCliente & vbCrLf

            Dim dt As DataTable = cn.ConsultaSQL(sql)
            If Not IsNothing(dt) Then

                If dt.Rows.Count > 0 Then

                    Dim row As DataRow = dt.Rows(0)
                    siglas = (row("Siglas").ToString & "").Trim.ToUpper
                    Descripcion = SII_ObtenerDescripcionFactura(Serie, Numero, (row("Nombre").ToString & "").Trim)

                End If

            End If

        End If



        Return siglas

    End Function


    Private Function SII_ObtenerDescripcionFactura(Serie As String, Numero As String, Nombre As String) As String

        Dim descripcion As String = "FRA. "

        If Serie.Trim <> "" Then
            descripcion = descripcion & Serie & "-"
        End If

        descripcion = descripcion & Numero
        descripcion = descripcion & " " & Nombre
        descripcion = FnLeft(descripcion, 500)


        Return descripcion

    End Function


End Module
