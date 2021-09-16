Imports DevExpress.XtraEditors


Module CMR_Nacional



    Private Sub ImprimeDatosCargador(ByRef miCMR As miFactura, Cliente As E_Clientes, altura As Integer)

        Dim Pais As String = ""
        Dim Paises As New E_Paises(Idusuario, CnComun)
        If Paises.LeerId(Cliente.CLI_IdPais.Valor) Then Pais = (Paises.Nombre.Valor & "").Trim


        miCMR.Titulo((Cliente.CLI_Nombre.Valor & "").Trim, 70, altura, 125, 4, milinea.stilos.Normal)                           'Nombre
        miCMR.Titulo((Cliente.CLI_Nif.Valor & "").Trim, 35, altura + 4, 160, 4, milinea.stilos.Normal)                          'NIF
        miCMR.Titulo((Cliente.CLI_Domicilio.Valor & "").Trim, 35, altura + 8, 160, 4, milinea.stilos.Normal)                    'Domicilio
        miCMR.Titulo((Cliente.CLI_CPostal.Valor & "").Trim & " - " & (Cliente.CLI_Poblacion.Valor & "").Trim, 35, altura + 12, 160, 4, milinea.stilos.Normal)  'CPostal - Poblacion
        miCMR.Titulo((Cliente.CLI_Provincia.Valor & "").Trim & " - " & Pais, 35, altura + 16, 160, 4, milinea.stilos.Normal)     'Provincia - Pais

    End Sub


    Private Sub ImprimeLugarDeOrigen(ByRef miCMR As miFactura, DatosEmpresa As DatosEmpresa)

        miCMR.Titulo(DatosEmpresa.Poblacion & ", " & DatosEmpresa.CPostal & " - " & DatosEmpresa.Provincia, 20, 124, 80, 4, milinea.stilos.Reducida)

    End Sub


    Private Sub ImprimeLugarDeDestino(ByRef miCMR As miFactura, Cliente As E_Clientes)

        Dim Pais As String = ""
        Dim Paises As New E_Paises(Idusuario, CnComun)

        If Paises.LeerId(Cliente.CLI_IdPais.Valor) Then
            Pais = (Paises.Nombre.Valor & "").Trim
        End If

        miCMR.Titulo((Cliente.CLI_Poblacion.Valor & "").Trim & ", " & (Cliente.CLI_Provincia.Valor & "").Trim & " - " & Pais, 110, 124, 80, 4, milinea.stilos.Reducida)

    End Sub




    Private Sub ImprimeFechaEnvio(ByRef miCMR As miFactura)

        'TODO: Esto es now o viene de la factura? Se guarda la hora en algún sitio?
        Dim Fecha As String = Now.ToString("dd/MM/yyyy")
        Dim Hora As String = Now.ToString("HH:mm")

        miCMR.Titulo(Fecha, 70, 182, 20, 4, milinea.stilos.Normal)
        miCMR.Titulo(Hora, 91, 182, 20, 4, milinea.stilos.Normal)

    End Sub



End Module
