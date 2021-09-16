Public Class E_IvaRepercutido
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdRegistro AS Cdatos.bdcampo
    Public FechaFac As Cdatos.bdcampo
    Public SerieDocumento As Cdatos.bdcampo
	Public Documento AS Cdatos.bdcampo
    Public idcuenta As Cdatos.bdcampo
    Public TipoIdentificacion As Cdatos.bdcampo
    Public nif As Cdatos.bdcampo
    Public CodigoPais As Cdatos.bdcampo
    Public FechaHora_AEAT As Cdatos.bdcampo
	Public nombre AS Cdatos.bdcampo
	Public Base1 AS Cdatos.bdcampo
	Public Iva1 AS Cdatos.bdcampo
	Public Cuota1 AS Cdatos.bdcampo
	Public Base2 AS Cdatos.bdcampo
	Public Iva2 AS Cdatos.bdcampo
	Public Cuota2 AS Cdatos.bdcampo
	Public Base3 AS Cdatos.bdcampo
	Public Iva3 AS Cdatos.bdcampo
	Public Cuota3 AS Cdatos.bdcampo
	Public Base4 AS Cdatos.bdcampo
	Public Iva4 AS Cdatos.bdcampo
	Public Cuota4 AS Cdatos.bdcampo
	Public BaseRetencion AS Cdatos.bdcampo
	Public TipoRetencion AS Cdatos.bdcampo
	Public CuotaRetencion AS Cdatos.bdcampo
	Public ClaveRetencion AS Cdatos.bdcampo
	Public TotalFactura AS Cdatos.bdcampo
	Public Re1 AS Cdatos.bdcampo
	Public CuotaRe1 AS Cdatos.bdcampo
	Public Re2 AS Cdatos.bdcampo
	Public CuotaRe2 AS Cdatos.bdcampo
	Public Re3 AS Cdatos.bdcampo
	Public CuotaRe3 AS Cdatos.bdcampo
	Public Re4 AS Cdatos.bdcampo
	Public CuotaRe4 AS Cdatos.bdcampo
	Public idTipoIvaRepercutido AS Cdatos.bdcampo
    Public EditarDatosSujeto As Cdatos.bdcampo
    Public Descripcion_AEAT As Cdatos.bdcampo
    Public SujetoIVA As Cdatos.bdcampo
    Public ExentoIVA As Cdatos.bdcampo
    Public Ignorar_AEAT As Cdatos.bdcampo
    Public FechaHoraSubida_AEAT As Cdatos.bdcampo
    Public NumSerieFin As Cdatos.bdcampo
    Public CSV As Cdatos.bdcampo





    Public Class valores
        Public base As Decimal
        Public cuota As Decimal
        Public cuotaRE As Decimal
        Public BaseRE As Decimal
        Public IdTipoIva As Integer
        Public Nombre As String

    End Class
    Public Class ValoresIva
        Public IdTipo As Integer
        Public Base As Decimal
        Public PorIva As Decimal
        Public CuotaIva As Decimal
        Public PorRec As Decimal
        Public CuotaRec As Decimal

    End Class

    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "IvaRepercutido"
            NombreBd = ObtenerBDConexion(conexion)

            MiConexion = conexion

            PrefijoContador = ""

            IdRegistro = New Cdatos.bdcampo("IdRegistro", Cdatos.TiposCampo.Entero, 10, 0, True)
            FechaFac = New Cdatos.bdcampo("FechaFac", Cdatos.TiposCampo.Fecha, 8)
            SerieDocumento = New Cdatos.bdcampo("SerieDocumento", Cdatos.TiposCampo.Cadena, 10)
            Documento = New Cdatos.bdcampo("Documento", Cdatos.TiposCampo.Cadena, 15)
            idcuenta = New Cdatos.bdcampo("idcuenta", Cdatos.TiposCampo.Cadena, 15)
            TipoIdentificacion = New Cdatos.bdcampo("TipoIdentificacion", Cdatos.TiposCampo.Cadena, 2)
            nif = New Cdatos.bdcampo("nif", Cdatos.TiposCampo.Cadena, 20)
            CodigoPais = New Cdatos.bdcampo("CodigoPais", Cdatos.TiposCampo.Cadena, 2)
            FechaHora_AEAT = New Cdatos.bdcampo("FechaHora_AEAT", Cdatos.TiposCampo.Cadena, 14)
            nombre = New Cdatos.bdcampo("nombre", Cdatos.TiposCampo.Cadena, 50)
            Base1 = New Cdatos.bdcampo("Base1", Cdatos.TiposCampo.Importe, 18, 2)
            Iva1 = New Cdatos.bdcampo("Iva1", Cdatos.TiposCampo.Importe, 18, 2)
            Cuota1 = New Cdatos.bdcampo("Cuota1", Cdatos.TiposCampo.Importe, 18, 2)
            Base2 = New Cdatos.bdcampo("Base2", Cdatos.TiposCampo.Importe, 18, 2)
            Iva2 = New Cdatos.bdcampo("Iva2", Cdatos.TiposCampo.Importe, 18, 2)
            Cuota2 = New Cdatos.bdcampo("Cuota2", Cdatos.TiposCampo.Importe, 18, 2)
            Base3 = New Cdatos.bdcampo("Base3", Cdatos.TiposCampo.Importe, 18, 2)
            Iva3 = New Cdatos.bdcampo("Iva3", Cdatos.TiposCampo.Importe, 18, 2)
            Cuota3 = New Cdatos.bdcampo("Cuota3", Cdatos.TiposCampo.Importe, 18, 2)
            Base4 = New Cdatos.bdcampo("Base4", Cdatos.TiposCampo.Importe, 18, 2)
            Iva4 = New Cdatos.bdcampo("Iva4", Cdatos.TiposCampo.Importe, 18, 2)
            Cuota4 = New Cdatos.bdcampo("Cuota4", Cdatos.TiposCampo.Importe, 18, 2)
            BaseRetencion = New Cdatos.bdcampo("BaseRetencion", Cdatos.TiposCampo.Importe, 18, 2)
            TipoRetencion = New Cdatos.bdcampo("TipoRetencion", Cdatos.TiposCampo.Importe, 18, 2)
            CuotaRetencion = New Cdatos.bdcampo("CuotaRetencion", Cdatos.TiposCampo.Importe, 18, 2)
            ClaveRetencion = New Cdatos.bdcampo("ClaveRetencion", Cdatos.TiposCampo.Cadena, 10)
            TotalFactura = New Cdatos.bdcampo("TotalFactura", Cdatos.TiposCampo.Importe, 18, 2)
            Re1 = New Cdatos.bdcampo("Re1", Cdatos.TiposCampo.Importe, 18, 2)
            CuotaRe1 = New Cdatos.bdcampo("CuotaRe1", Cdatos.TiposCampo.Importe, 18, 2)
            Re2 = New Cdatos.bdcampo("Re2", Cdatos.TiposCampo.Importe, 18, 2)
            CuotaRe2 = New Cdatos.bdcampo("CuotaRe2", Cdatos.TiposCampo.Importe, 18, 2)
            Re3 = New Cdatos.bdcampo("Re3", Cdatos.TiposCampo.Importe, 18, 2)
            CuotaRe3 = New Cdatos.bdcampo("CuotaRe3", Cdatos.TiposCampo.Importe, 18, 2)
            Re4 = New Cdatos.bdcampo("Re4", Cdatos.TiposCampo.Importe, 18, 2)
            CuotaRe4 = New Cdatos.bdcampo("CuotaRe4", Cdatos.TiposCampo.Importe, 18, 2)
            idTipoIvaRepercutido = New Cdatos.bdcampo("idTipoIvaRepercutido", Cdatos.TiposCampo.Entero, 10)
            EditarDatosSujeto = New Cdatos.bdcampo("EditarDatosSujeto", Cdatos.TiposCampo.Cadena, 1)
            Descripcion_AEAT = New Cdatos.bdcampo("Descripcion_AEAT", Cdatos.TiposCampo.Cadena, 100)
            SujetoIVA = New Cdatos.bdcampo("SujetoIVA", Cdatos.TiposCampo.Cadena, 1)
            ExentoIVA = New Cdatos.bdcampo("ExentoIVA", Cdatos.TiposCampo.Cadena, 1)
            Ignorar_AEAT = New Cdatos.bdcampo("Ignorar_AEAT", Cdatos.TiposCampo.Cadena, 1)
            FechaHoraSubida_AEAT = New Cdatos.bdcampo("FechaHoraSubida_AEAT", Cdatos.TiposCampo.Cadena, 14)
            NumSerieFin = New Cdatos.bdcampo("NumSerieFin", Cdatos.TiposCampo.Cadena, 30)
            CSV = New Cdatos.bdcampo("CSV", Cdatos.TiposCampo.Cadena, 20)


            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.MuestraError("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub

    Public Function ResumendeIva(ByVal desde As Date, ByVal hasta As Date, ByVal SqlCentro As String, ByVal SqlTipoIva As String) As DataTable
        Dim cadena As String = ""
        Dim Dt As New DataTable
        cadena = "SELECT     IvaRepercutido.*, Asientos.IdCentro, asientos.ejercicio,Asientos.Asiento, Asientos.Fecha AS FechaAsiento"
        cadena = cadena + " FROM         IvaRepercutido INNER JOIN"
        cadena = cadena + " AsientoLineas ON IvaRepercutido.IdRegistro = AsientoLineas.Idapunte INNER JOIN"
        cadena = cadena + " Asientos ON AsientoLineas.IdAsiento = Asientos.IdAsiento"
        cadena = cadena + " where (Asientos.fecha>='" & StDate(desde) & "' and Asientos.fecha<='" & StDate(hasta) & "')"
        If SqlCentro <> "" Then
            cadena = cadena + " and  " + SqlCentro
        End If
        If SqlTipoIva <> "" Then
            cadena = cadena + " and " + SqlTipoIva
        End If

        Dt = MiConexion.ConsultaSQL(cadena)
        Return Dt
    End Function

    Public Function Resumen340(ByVal desde As Date, ByVal hasta As Date) As DataTable
        Dim cadena As String = ""
        Dim Dt As New DataTable
        cadena = "SELECT     dbo.IvaRepercutido.*, Asientos.IdCentro, Asientos.Asiento, Asientos.Fecha AS FechaAsiento, dbo.TipoIvaRepercutido.TipoReg340, dbo.tipoivarepercutido.clave340, "
        cadena = cadena + " repercutido340.situacion,repercutido340.refcatastral,repercutido340.metalico,repercutido340.ejermetalico,repercutido340.transmisiones, "
        cadena = cadena + " dbo.cuentas.nombre as NombreCuenta,dbo.cuentas.nif as NifCuenta, "
        cadena = cadena + " comun.dbo.paises.siglas,comun.dbo.paises.comunitario "

        cadena = cadena + " FROM         dbo.IvaRepercutido "
        cadena = cadena + " INNER JOIN AsientoLineas ON IvaRepercutido.IdRegistro = AsientoLineas.Idapunte "
        cadena = cadena + " INNER JOIN Asientos ON AsientoLineas.IdAsiento = Asientos.IdAsiento"
        cadena = cadena + " INNER JOIN dbo.TipoIvaRepercutido ON dbo.IvaRepercutido.idTipoIvaRepercutido = dbo.TipoIvaRepercutido.IdIva"
        cadena = cadena + " LEFT OUTER JOIN dbo.Repercutido340 ON dbo.IvaRepercutido.idregistro = dbo.repercutido340.Idregistro"
        cadena = cadena + " LEFT OUTER JOIN dbo.cuentas ON dbo.IvaRepercutido.idcuenta = dbo.cuentas.numerocuenta"
        cadena = cadena + " LEFT OUTER JOIN comun.dbo.paises ON dbo.cuentas.idpais = comun.dbo.paises.idpais"

        cadena = cadena + " where (Asientos.fecha>='" & StDate(desde) & "' and Asientos.fecha<='" & StDate(hasta) & "') and tipoivarepercutido.tiporeg340<>'' order by asientos.fecha "
        Dt = MiConexion.ConsultaSQL(cadena)
        Return Dt
    End Function


    Public Function TablaImportacion347(ByVal FechaDesde As String, ByVal FechaHasta As String, ByVal TipoCtb As String) As DataTable

        'TODO: Revisar

        Dim sql As String = "SELECT IDCUENTA, IvaRepercutido.nif, Cuentas.nif as NIFCUENTA, Asientos.Fecha as FechaAsiento, BASE1, CUOTA1, CUOTARE1, BASE2, CUOTA2, CUOTARE2, BASE3, CUOTA3, CUOTARE3, BASE4, CUOTA4, CUOTARE4"
        sql = sql & " FROM IvaRepercutido"
        sql = sql & " LEFT JOIN AsientoLineas ON IvaRepercutido.IdRegistro = AsientoLineas.IdApunte "
        sql = sql & " LEFT JOIN Asientos ON Asientos.IdAsiento = AsientoLineas.IdAsiento"
        sql = sql & " LEFT JOIN Cuentas on IvaRepercutido.IdCuenta = Cuentas.Numerocuenta"
        sql = sql & " WHERE Asientos.Fecha BETWEEN '" & FechaDesde & "' AND '" & FechaHasta & "' "
        sql = sql & " AND Asientos.Tipo = '" & TipoCtb & "'"
        sql = sql & " ORDER BY Cuentas.NIF"


        Return MiConexion.ConsultaSQL(sql)

    End Function


    Public Overrides Function Eliminar() As Boolean


        'If (Me.Ignorar_AEAT.Valor & "").Trim.ToUpper <> "S" And (Me.FechaHora_AEAT.Valor & "").Trim = "" Then
        '    TramitarBaja_AEAT(Me.IdRegistro.Valor)
        'End If

        Return MyBase.Eliminar()

    End Function


    'Public Sub TramitarBaja_AEAT(IdRegistro As String)

    '    Dim IvaRepercutido As New E_IvaRepercutido(Idusuario, Me.MiConexion)
    '    If IvaRepercutido.LeerId(IdRegistro) Then


    '        'Primero comprobamos si se trata de un registro de iva que ya hayamos enviado a Hacienda, si no es así, no tramitamos la baja
    '        Dim bTramitar As Boolean = True

    '        Dim Altas_AEAT As New E_Altas_AEAT(Idusuario, MiConexion)
    '        If Altas_AEAT.ExisteFactura("R", IvaRepercutido.SerieDocumento.Valor, IvaRepercutido.Documento.Valor, IvaRepercutido.FechaFac.Valor, MiMaletin.NIF_Empresa, "2", "") Then
    '            bTramitar = True
    '        Else
    '            bTramitar = False
    '        End If



    '        If bTramitar Then

    '            Dim Bajas_AEAT As New E_Bajas_AEAT(Idusuario, Me.MiConexion)


    '            If Bajas_AEAT.LeerId(IdRegistro) Then
    '                Bajas_AEAT.FechaHora_AEAT.Valor = Now.ToString("yyyyMMddHHmmss")
    '                Bajas_AEAT.Actualizar()
    '            Else
    '                Bajas_AEAT = New E_Bajas_AEAT(Idusuario, Me.MiConexion)
    '                Bajas_AEAT.IdRegistro.Valor = IdRegistro
    '                Bajas_AEAT.Tipo.Valor = "R"
    '                Bajas_AEAT.NIF.Valor = MiMaletin.NIF_Empresa
    '                Bajas_AEAT.Emisor.Valor = IvaRepercutido.nombre.Valor
    '                Bajas_AEAT.SerieDocumento.Valor = IvaRepercutido.SerieDocumento.Valor
    '                Bajas_AEAT.Documento.Valor = IvaRepercutido.Documento.Valor
    '                Bajas_AEAT.FechaFac.Valor = IvaRepercutido.FechaFac.Valor
    '                Bajas_AEAT.TipoIdentificacion.Valor = "2"
    '                Bajas_AEAT.CodigoPais.Valor = ""
    '                Bajas_AEAT.FechaHora_AEAT.Valor = Now.ToString("yyyyMMddHHmmss")
    '                Bajas_AEAT.Insertar()
    '            End If

    '        End If



    '    Else
    '        MsgBox("Error al leer el registro de iva repercutido con Id " & IdRegistro)
    '    End If


    'End Sub


End Class
