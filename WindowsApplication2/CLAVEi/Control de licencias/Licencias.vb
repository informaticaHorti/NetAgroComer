Imports System.Net
Imports System.Linq
Imports System.Net.NetworkInformation

Module Licencias


    Public Function CadenaConexionComun_UsuarioEscritorioRemoto(ByVal cadenaconexion As String) As String

        If EsEscritorioRemoto(cadenaconexion) Then

            Dim usuario As String = Environment.UserName
            If Not cadenaconexion.EndsWith(";") Then cadenaconexion += ";"
            cadenaconexion += "WSID="
            cadenaconexion += Environment.MachineName.ToString()
            cadenaconexion += "#"
            cadenaconexion += usuario


        End If


        Return cadenaconexion

    End Function


    Public Function EsEscritorioRemoto(ByVal cadenaconexion As String) As Boolean

        Dim bRes As Boolean = False

        bRes = System.Windows.Forms.SystemInformation.TerminalServerSession


        '    Dim NombreServidor As String = ObtenerServidorConexion(cadenaconexion)
        '    Dim cadenaservidor As String() = Split(NombreServidor, "\")
        '    If cadenaservidor.Length > 0 Then
        '        NombreServidor = cadenaservidor(0)
        '    End If


        '    Dim IP_Servidor As String = ObtenerIP(NombreServidor)


        '    Try

        '        Dim Host As String = Dns.GetHostName

        '        Dim IPs As IPHostEntry = Dns.GetHostEntry(Host)
        '        Dim Direcciones As IPAddress() = IPs.AddressList


        '        For Each ip As IPAddress In Direcciones
        '            If ip.AddressFamily = Sockets.AddressFamily.InterNetwork Then
        '                If ip.ToString = IP_Servidor Then
        '                    bRes = True
        '                    Exit For
        '                End If
        '            End If
        '        Next


        '    Catch ex As Exception

        '    End Try




        Return bRes

    End Function


    'Public Function ObtenerServidorConexion(ByVal conexion As Cdatos.Conexion) As String

    '    Dim res As String = ""


    '    Dim cadenaconexion As String = conexion.CadenaConexion.ToLower
    '    Return ObtenerServidorConexion(cadenaconexion)


    'End Function



    'Public Function ObtenerServidorConexion(ByVal cadenaconexion As String) As String

    '    Dim res As String = ""


    '    Dim params As String() = Split(cadenaconexion.ToLower(), ";")

    '    For Each param As String In params
    '        If param.StartsWith("server=") Then

    '            Dim valor As String() = Split(param, "=")
    '            If valor.Length = 2 Then
    '                res = valor(1)
    '            End If

    '        End If
    '    Next



    '    Return res

    'End Function


    'Public Function ObtenerIP(ByVal nombre As String) As String

    '    Dim ip As String = ""
    '    Dim bEsIP As Boolean = False


    '    Dim digitos() As String = Split(nombre, ".")
    '    If digitos.Length = 4 AndAlso IsNumeric(digitos(0)) AndAlso IsNumeric(digitos(1)) AndAlso IsNumeric(digitos(2)) AndAlso IsNumeric(digitos(3)) AndAlso
    '        VaInt(digitos(0)) >= 0 AndAlso VaInt(digitos(0)) <= 255 AndAlso
    '        VaInt(digitos(1)) >= 0 AndAlso VaInt(digitos(1)) <= 255 AndAlso
    '        VaInt(digitos(2)) >= 0 AndAlso VaInt(digitos(2)) <= 255 AndAlso
    '        VaInt(digitos(3)) >= 0 AndAlso VaInt(digitos(3)) <= 255 Then

    '        Return nombre
    '    End If


    '    Dim bLocal As Boolean = False
    '    If nombre.Trim.ToUpper = Dns.GetHostName().Trim.ToUpper Then
    '        bLocal = True
    '    End If



    '    If nombre.Trim <> "" Then

    '        If Not bLocal Then

    '            Dim IPs_Servidor As IPHostEntry = Dns.GetHostEntry(nombre)
    '            ip = IPs_Servidor.AddressList.Where(Function(a As IPAddress) Not a.IsIPv6LinkLocal AndAlso Not a.IsIPv6Multicast AndAlso Not a.IsIPv6SiteLocal AndAlso a.AddressFamily = Sockets.AddressFamily.InterNetwork).First().ToString()

    '        Else

    '            For Each networkCard As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces
    '                ' Find network cards with gateway information (this may show more than one network card depending on computer)

    '                For Each gatewayAddr As GatewayIPAddressInformation In networkCard.GetIPProperties.GatewayAddresses
    '                    ' if gateway address is NOT 0.0.0.0 and the network card status is UP then we've found the main network card
    '                    If gatewayAddr.Address.ToString <> "0.0.0.0" And networkCard.OperationalStatus.ToString() = "Up" Then

    '                        If Not IsNothing(networkCard.GetIPProperties.UnicastAddresses) Then

    '                            For Each IpAddressAndSubnet In networkCard.GetIPProperties.UnicastAddresses
    '                                If IpAddressAndSubnet.DuplicateAddressDetectionState = DuplicateAddressDetectionState.Preferred Then
    '                                    ip = IpAddressAndSubnet.Address.ToString
    '                                    Return ip
    '                                End If
    '                            Next

    '                        End If

    '                    End If

    '                Next

    '            Next

    '        End If


    '    End If



    '    Return ip

    'End Function


End Module
