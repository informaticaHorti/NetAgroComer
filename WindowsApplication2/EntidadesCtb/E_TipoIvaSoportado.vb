Public Class E_TipoIvaSoportado
	Inherits Cdatos.Entidad


	Private err As New Errores

	Public IdIva AS Cdatos.bdcampo
	Public Nombre AS Cdatos.bdcampo
	Public Iva1 AS Cdatos.bdcampo
	Public Cuenta1 AS Cdatos.bdcampo
	Public Iva2 AS Cdatos.bdcampo
	Public Cuenta2 AS Cdatos.bdcampo
	Public Iva3 AS Cdatos.bdcampo
	Public Cuenta3 AS Cdatos.bdcampo
	Public Iva4 AS Cdatos.bdcampo
	Public Cuenta4 AS Cdatos.bdcampo
	Public CuentaIc1 AS Cdatos.bdcampo
	Public CuentaIc2 AS Cdatos.bdcampo
	Public CuentaIc3 AS Cdatos.bdcampo
	Public CuentaIc4 AS Cdatos.bdcampo
	Public Adquisiciones AS Cdatos.bdcampo
	Public CuentaRet AS Cdatos.bdcampo
	Public TipoReg340 AS Cdatos.bdcampo
    Public Clave340 As Cdatos.bdcampo
    Public InvSujetoPasivo As Cdatos.bdcampo
    Public ClaveRegimenTrascendencia As Cdatos.bdcampo
    Public TipoRectificativa As Cdatos.bdcampo
    Public InversionesInmobilizado As Cdatos.bdcampo



    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "TipoIvaSoportado"
            NombreBd = ObtenerBDConexion(conexion)

            MiConexion = conexion

            PrefijoContador = ""

            IdIva = New Cdatos.bdcampo("IdIva", Cdatos.TiposCampo.Entero, 10, , True)
            Nombre = New Cdatos.bdcampo("Nombre", Cdatos.TiposCampo.Cadena, 30)
            Iva1 = New Cdatos.bdcampo("Iva1", Cdatos.TiposCampo.Importe, 19, 2)
            Cuenta1 = New Cdatos.bdcampo("Cuenta1", Cdatos.TiposCampo.Cuenta, 15)
            Iva2 = New Cdatos.bdcampo("Iva2", Cdatos.TiposCampo.Importe, 19, 2)
            Cuenta2 = New Cdatos.bdcampo("Cuenta2", Cdatos.TiposCampo.Cuenta, 15)
            Iva3 = New Cdatos.bdcampo("Iva3", Cdatos.TiposCampo.Importe, 19, 2)
            Cuenta3 = New Cdatos.bdcampo("Cuenta3", Cdatos.TiposCampo.Cuenta, 15)
            Iva4 = New Cdatos.bdcampo("Iva4", Cdatos.TiposCampo.Importe, 19, 2)
            Cuenta4 = New Cdatos.bdcampo("Cuenta4", Cdatos.TiposCampo.Cuenta, 15)
            CuentaIc1 = New Cdatos.bdcampo("CuentaIc1", Cdatos.TiposCampo.Cuenta, 15)
            CuentaIc2 = New Cdatos.bdcampo("CuentaIc2", Cdatos.TiposCampo.Cuenta, 15)
            CuentaIc3 = New Cdatos.bdcampo("CuentaIc3", Cdatos.TiposCampo.Cuenta, 15)
            CuentaIc4 = New Cdatos.bdcampo("CuentaIc4", Cdatos.TiposCampo.Cuenta, 15)
            Adquisiciones = New Cdatos.bdcampo("Adquisiciones", Cdatos.TiposCampo.Cadena, 1)
            CuentaRet = New Cdatos.bdcampo("CuentaRet", Cdatos.TiposCampo.Cuenta, 15)
            TipoReg340 = New Cdatos.bdcampo("TipoReg340", Cdatos.TiposCampo.Cadena, 1)
            Clave340 = New Cdatos.bdcampo("Clave340", Cdatos.TiposCampo.Cadena, 1)
            InvSujetoPasivo = New Cdatos.bdcampo("InvSujetoPasivo", Cdatos.TiposCampo.Cadena, 1)
            ClaveRegimenTrascendencia = New Cdatos.bdcampo("ClaveRegimenTrascendencia", Cdatos.TiposCampo.Entero, 2)
            TipoRectificativa = New Cdatos.bdcampo("TipoRectificativa", Cdatos.TiposCampo.Cadena, 2)
            InversionesInmobilizado = New Cdatos.bdcampo("InversionesInmobilizado", Cdatos.TiposCampo.Cadena, 1)



            MiListadeCampos = ListadeCampos()

            btBusca.CL_CampoOrden = "nombre"
            btBusca.CL_ConsultaSql = "Select idiva,nombre, Iva1, Iva2, Iva3, Iva4 from TipoIvasoportado"
            btBusca.CL_ControlAsociado = Nothing
            btBusca.CL_DevuelveCampo = "idiva"
            btBusca.CL_Entidad = Nothing
            btBusca.CL_Filtro = Nothing
            btBusca.cl_formu = Nothing
            btBusca.Location = New System.Drawing.Point(134, 303)
            btBusca.Name = "BtBuscaTipoIvasSoportado"
            btBusca.Size = New System.Drawing.Size(33, 23)
            btBusca.UseVisualStyleBackColor = True


        Catch ex As Exception
            err.MuestraError("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub

    Public Function CbTipoLibro() As DataTable
        Dim dT As New DataTable



        dt.Columns.Add(New DataColumn("Id"))
        dT.Columns.Add(New DataColumn("Nombre"))
        dt.Rows.Add("E", "Emitida")
        dt.Rows.Add("R", "Recibida")
        dt.Rows.Add("I", "Intracomunitario")
        dt.Rows.Add("U", "Adquisiciones")


        Return dT

    End Function


    Public Function CbRegimenEspecialTrascendencia_FacturasRecibidas()

        Dim dt As New DataTable


        dt.Columns.Add(New DataColumn("Id", GetType(Integer)))
        dt.Columns.Add(New DataColumn("Nombre", GetType(String)))

        dt.Rows.Add("-1", "NO APLICAR")
        dt.Rows.Add("1", "Régimen común")
        dt.Rows.Add("2", "Compensaciones REAGYP")
        dt.Rows.Add("3", "Bienes usados, antigüedades, etc. (135-139 LIVA)")
        dt.Rows.Add("4", "Rég. Esp. Oro de inversión")
        dt.Rows.Add("5", "Rég. Esp. Agencias de viajes")
        dt.Rows.Add("6", "Rég. Esp. Grupo entidades en IVA (Nivel Avanzado)")
        dt.Rows.Add("7", "Rég. Esp. Critero de caja")
        dt.Rows.Add("8", "Operaciones sujetas a IPSI / IGIC")
        dt.Rows.Add("9", "Adquisiciones intracomunitarias de bienes y servicios")
        dt.Rows.Add("10", "Compra de Agencia de viajes")
        dt.Rows.Add("11", "Agencias de viajes que actúan como mediadoras")
        dt.Rows.Add("12", "Arrendamiento de local de negocio")
        dt.Rows.Add("13", "Importaciones (no asociada a un DUA)")


        Return dt

    End Function



    Public Function Tabla() As DataTable
        Dim dt As New DataTable
        dt = MiConexion.ConsultaSQL("Select IdIva, Nombre from TIPOIVASOPORTADO order by IdIva")
        Return dt
    End Function



End Class
