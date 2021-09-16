Public Class DatosEmpresa

    Public IdEmpresa As String = ""

    Public NombreEmpresa As String = ""
    Public DatosFiscalesEmpresa As String = ""

    Public Domicilio As String = ""
    Public CPostal As String = ""
    Public Poblacion As String = ""
    Public Provincia As String = ""
    Public Pais As String = "España"
    Public ApartadoCorreos As String = ""
    Public Telefonos As String = ""
    Public Fax As String = ""
    Public Email As String = ""
    Public Web As String = ""

    Public NombreBanco As String = ""
    Public EntidadSucursal As String = ""
    Public IBAN As String = ""
    Public Swift As String = ""
    Public GGN As String = ""

    Public NIF As String = ""

    Public TelfComercial As String = ""
    Public TelfAdmon As String = ""
    Public TelfCalidad As String = ""
    Public TelfSalidas As String = ""



    Public Sub New(Optional IdEmpresa As String = "")

        ObtenerDatosEmpresa()

    End Sub


    Public Sub ObtenerDatosEmpresa()




        Dim VPV As New E_valorespventa(Idusuario, cn)
        If VPV.LeerId(MiMaletin.IdPuntoVenta.ToString) Then

            'Datos empresa
            NombreEmpresa = (VPV.VPV_EmpresaFacturacion.Valor & "").Trim
            Domicilio = (VPV.VPV_DomicilioFacturacion.Valor & "").Trim
            CPostal = (VPV.VPV_CPostalFacturacion.Valor & "").Trim
            Poblacion = (VPV.VPV_PoblacionFacturacion.Valor & "").Trim
            Provincia = (VPV.VPV_ProvinciaFacturacion.Valor & "").Trim

            Dim CD As New E_ConfiguracionesDiversas(Idusuario, cn)
            TelfComercial = CD.xDameValor(E_ConfiguracionesDiversas.eClaves.TELEFONO_COMERCIAL)
            TelfCalidad = CD.xDameValor(E_ConfiguracionesDiversas.eClaves.TELEFONO_CALIDAD)
            TelfSalidas = CD.xDameValor(E_ConfiguracionesDiversas.eClaves.TELEFONO_SALIDAS)
            TelfAdmon = CD.xDameValor(E_ConfiguracionesDiversas.eClaves.TELEFONO_ADMINISTRACION)
            Fax = CD.xDameValor(E_ConfiguracionesDiversas.eClaves.FAX_ADMINISTRACION)

            Dim IdPais As Integer = VaInt(VPV.VPV_IdPaisFacturacion)
            Dim Paises As New E_Paises(Idusuario, CnComun)
            If Paises.LeerId(IdPais) Then Pais = (Paises.Nombre.Valor & "").Trim

            If (VPV.VPV_AptdoCorreosFacturacion.Valor & "").Trim <> "" Then ApartadoCorreos = "Apartado de Correos " & (VPV.VPV_AptdoCorreosFacturacion.Valor & "").Trim

            Telefonos = "Tels. " & (VPV.VPV_TelefonosFacturacion.Valor & "").Trim
            Email = "Email: " & (VPV.VPV_EmailFacturacion.Valor & "").Trim
            Web = "Web: " & (VPV.VPV_WebFacturacion.Valor & "").Trim

            'Datos fiscales
            DatosFiscalesEmpresa = (VPV.VPV_LineaDatosFiscales.Valor & "").Trim

            'Datos de pago
            NombreBanco = (VPV.VPV_NombreBanco.Valor & "").Trim
            EntidadSucursal = (VPV.VPV_EntidadSucursal.Valor & "").Trim
            IBAN = (VPV.VPV_IBAN.Valor & "").Trim
            Swift = (VPV.VPV_SWIFT.Valor & "").Trim
            NIF = (VPV.VPV_Nif.Valor & "").Trim
            GGN = (VPV.VPV_GGN.Valor & "").Trim

            'Dim Empresa As New E_DatosEmpresa(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
            'If Empresa.LeerId("1") Then
            '    NIF = (Empresa.NifDeclarante.Valor & "").Trim
            'End If

        End If



    End Sub


    Public Function FilaDatos() As String

        Dim res As String = ""

        res = Domicilio & " . " & CPostal & " . " & Poblacion & " . " & Provincia & " . " & vbCrLf & _
            Pais & " . " & ApartadoCorreos & " . " & Telefonos & " . " & Fax & " . " & vbCrLf & _
            Email & " . " & Web & vbCrLf & _
            "C.I.F.: " & Me.NIF


        Return res

    End Function

End Class
