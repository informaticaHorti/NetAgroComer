Public Class E_TipoIvaRepercutido
    Inherits Cdatos.Entidad


    Private err As New Errores

    Public IdIva As Cdatos.bdcampo
    Public Nombre As Cdatos.bdcampo
    Public Iva1 As Cdatos.bdcampo
    Public Cuenta1 As Cdatos.bdcampo
    Public Iva2 As Cdatos.bdcampo
    Public Cuenta2 As Cdatos.bdcampo
    Public Iva3 As Cdatos.bdcampo
    Public Cuenta3 As Cdatos.bdcampo
    Public Iva4 As Cdatos.bdcampo
    Public Cuenta4 As Cdatos.bdcampo
    Public CuentaRe1 As Cdatos.bdcampo
    Public CuentaRe2 As Cdatos.bdcampo
    Public CuentaRe3 As Cdatos.bdcampo
    Public CuentaRe4 As Cdatos.bdcampo
    Public TipoRe1 As Cdatos.bdcampo
    Public TipoRe2 As Cdatos.bdcampo
    Public TipoRe3 As Cdatos.bdcampo
    Public TipoRe4 As Cdatos.bdcampo
    Public CuentaRet As Cdatos.bdcampo
    Public TipoReg340 As Cdatos.bdcampo
    Public Clave340 As Cdatos.bdcampo
    Public ClaveRegimenTrascendencia As Cdatos.bdcampo
    Public TipoOperacion As Cdatos.bdcampo
    Public TipoRectificativa As Cdatos.bdcampo


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "TipoIvaRepercutido"
            NombreBd = ObtenerBDConexion(conexion)

            MiConexion = conexion

            PrefijoContador = ""

            IdIva = New Cdatos.bdcampo(CodigoEntidad & "IdIva", Cdatos.TiposCampo.Entero, 10, , True)
            Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 30)
            Iva1 = New Cdatos.bdcampo(CodigoEntidad & "Iva1", Cdatos.TiposCampo.Importe, 19, 2)
            Cuenta1 = New Cdatos.bdcampo(CodigoEntidad & "Cuenta1", Cdatos.TiposCampo.Cuenta, 15)
            Iva2 = New Cdatos.bdcampo(CodigoEntidad & "Iva2", Cdatos.TiposCampo.Importe, 19, 2)
            Cuenta2 = New Cdatos.bdcampo(CodigoEntidad & "Cuenta2", Cdatos.TiposCampo.Cuenta, 15)
            Iva3 = New Cdatos.bdcampo(CodigoEntidad & "Iva3", Cdatos.TiposCampo.Importe, 19, 2)
            Cuenta3 = New Cdatos.bdcampo(CodigoEntidad & "Cuenta3", Cdatos.TiposCampo.Cuenta, 15)
            Iva4 = New Cdatos.bdcampo(CodigoEntidad & "Iva4", Cdatos.TiposCampo.Importe, 19, 2)
            Cuenta4 = New Cdatos.bdcampo(CodigoEntidad & "Cuenta4", Cdatos.TiposCampo.Cuenta, 15)
            CuentaRe1 = New Cdatos.bdcampo(CodigoEntidad & "CuentaRe1", Cdatos.TiposCampo.Cuenta, 15)
            CuentaRe2 = New Cdatos.bdcampo(CodigoEntidad & "CuentaRe2", Cdatos.TiposCampo.Cuenta, 15)
            CuentaRe3 = New Cdatos.bdcampo(CodigoEntidad & "CuentaRe3", Cdatos.TiposCampo.Cuenta, 15)
            CuentaRe4 = New Cdatos.bdcampo(CodigoEntidad & "CuentaRe4", Cdatos.TiposCampo.Cuenta, 15)
            TipoRe1 = New Cdatos.bdcampo(CodigoEntidad & "TipoRe1", Cdatos.TiposCampo.Importe, 19, 2)
            TipoRe2 = New Cdatos.bdcampo(CodigoEntidad & "TipoRe2", Cdatos.TiposCampo.Importe, 19, 2)
            TipoRe3 = New Cdatos.bdcampo(CodigoEntidad & "TipoRe3", Cdatos.TiposCampo.Importe, 19, 2)
            TipoRe4 = New Cdatos.bdcampo(CodigoEntidad & "TipoRe4", Cdatos.TiposCampo.Importe, 19, 2)
            CuentaRet = New Cdatos.bdcampo(CodigoEntidad & "CuentaRet", Cdatos.TiposCampo.Cuenta, 15)
            TipoReg340 = New Cdatos.bdcampo(CodigoEntidad & "TipoReg340", Cdatos.TiposCampo.Cadena, 1)
            Clave340 = New Cdatos.bdcampo(CodigoEntidad & "Clave340", Cdatos.TiposCampo.Cadena, 1)
			ClaveRegimenTrascendencia = New Cdatos.bdcampo("ClaveRegimenTrascendencia", Cdatos.TiposCampo.Entero, 2)
            TipoOperacion = New Cdatos.bdcampo("TipoOperacion", Cdatos.TiposCampo.Entero, 2)
			TipoRectificativa = New Cdatos.bdcampo("TipoRectificativa", Cdatos.TiposCampo.Cadena, 2)

            MiListadeCampos = ListadeCampos()


            btBusca.CL_CampoOrden = "nombre"
            btBusca.CL_ConsultaSql = "Select idiva,nombre, Iva1, Iva2, Iva3, Iva4 from TipoIvaRepercutido"
            btBusca.CL_ControlAsociado = Nothing
            btBusca.CL_DevuelveCampo = "idiva"
            btBusca.CL_Entidad = Nothing
            btBusca.CL_Filtro = Nothing
            btBusca.cl_formu = Nothing
            btBusca.Location = New System.Drawing.Point(134, 303)
            btBusca.Name = "BtBuscaTipoIvaRepercutido"
            btBusca.Size = New System.Drawing.Size(33, 23)
            btBusca.UseVisualStyleBackColor = True


        Catch ex As Exception
            err.MuestraError("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub

    Public Function Tabla() As DataTable
        Dim dt As New DataTable
        dt = MiConexion.ConsultaSQL("Select IdIva, Nombre from TIPOIVAREPERCUTIDO order by IdIva")
        Return dt
    End Function


	Public Function CbRegimenEspecialTrascendencia_FacturasEmitidas()

        Dim dt As New DataTable


        dt.Columns.Add(New DataColumn("Id", GetType(Integer)))
        dt.Columns.Add(New DataColumn("Nombre", GetType(String)))

        dt.Rows.Add("-1", "NO APLICAR")
        dt.Rows.Add("1", "Régimen común")
        dt.Rows.Add("2", "Exportación")
        dt.Rows.Add("3", "Bienes usados, antigüedades, etc. (135-139 LIVA)")
        dt.Rows.Add("4", "Rég. Esp. Oro de inversión")
        dt.Rows.Add("5", "Rég. Esp. Agencias de viajes")
        dt.Rows.Add("6", "Rég. Esp. Grupo entidades en IVA (Nivel Avanzado)")
        dt.Rows.Add("7", "Rég. Esp. Critero de caja")
        dt.Rows.Add("8", "Operaciones sujetas a IPSI / IGIC")
        dt.Rows.Add("9", "Agencias de viajes que actúan como mediadoras")
        dt.Rows.Add("10", "Cobros por cuenta de terceros")
        dt.Rows.Add("11", "Arrendamiento de local sujeto a retención")
        dt.Rows.Add("12", "Arrendamiento de local no sujeto a retención")
        dt.Rows.Add("13", "Arrendamiento de local sujeto y no sujeto a retención")
        dt.Rows.Add("14", "Factura con IVA pte. devengo (cert. obra Admón. Pública)")
        dt.Rows.Add("15", "Factura con IVA pte. devengo - tracto sucesivo")



        Return dt

    End Function


    Public Function CbTipoOperacion_FacturasEmitidas(Optional TipoFra As String = "") As DataTable

        Dim dt As New DataTable


        dt.Columns.Add(New DataColumn("Id", GetType(Integer)))
        dt.Columns.Add(New DataColumn("Nombre", GetType(String)))


        Select Case TipoFra

            Case "F1", "R1", "R2", "R3", "R4"                       'Facturas normales
                dt.Rows.Add("1", "Prestación de servicios")
                dt.Rows.Add("2", "Entrega de bienes")

            Case "F2"
                dt.Rows.Add("4", "Asiento resumen")

            Case "R5"
                dt.Rows.Add("3", "Factura simplificada")

            Case Else
                dt.Rows.Add("1", "Prestación de servicios")
                dt.Rows.Add("2", "Entrega de bienes")
                dt.Rows.Add("3", "Factura simplificada")
                dt.Rows.Add("4", "Asiento resumen")

        End Select


        Return dt

    End Function


End Class
