Public Class E_Clientes
    Inherits Cdatos.Entidad

    Public CLI_Codigo As Cdatos.bdcampo
    Public CLI_Nombre As Cdatos.bdcampo
    Public CLI_Nif As Cdatos.bdcampo
    Public CLI_IdTipo As Cdatos.bdcampo
    Public CLI_Ididioma As Cdatos.bdcampo
    Public CLI_Iddivisa As Cdatos.bdcampo
    Public CLI_IdVendedor As Cdatos.bdcampo

    Public CLI_Domicilio As Cdatos.bdcampo
    Public CLI_Poblacion As Cdatos.bdcampo
    Public CLI_Provincia As Cdatos.bdcampo
    Public CLI_CPostal As Cdatos.bdcampo
    Public CLI_IdZona As Cdatos.bdcampo
    Public CLI_Telefono1 As Cdatos.bdcampo
    Public CLI_Telefono2 As Cdatos.bdcampo
    Public CLI_Fax As Cdatos.bdcampo
    Public CLI_Mail As Cdatos.bdcampo
    Public CLI_IdPais As Cdatos.bdcampo

    Public CLI_FechaAlta As Cdatos.bdcampo
    Public CLI_Bloqueo As Cdatos.bdcampo
    Public CLI_Bloqueocausa As Cdatos.bdcampo
    Public CLI_IdComisionista As Cdatos.bdcampo

    Public CLI_FC As Cdatos.bdcampo
    Public CLI_Quincenasfax As Cdatos.bdcampo
    Public CLI_KB As Cdatos.bdcampo
    Public CLI_FacturaEnvaseComercio As Cdatos.bdcampo
    Public CLI_observacionesfactura As Cdatos.bdcampo

    Public CLI_Contrato As Cdatos.bdcampo
    Public CLI_IdFormaPago As Cdatos.bdcampo

    Public CLI_idtipoporte As Cdatos.bdcampo
    Public CLI_origendestino As Cdatos.bdcampo
    Public CLI_emailalba1 As Cdatos.bdcampo
    Public CLI_emailalba2 As Cdatos.bdcampo
    Public CLI_emailalba3 As Cdatos.bdcampo

    Public CLI_emailped1 As Cdatos.bdcampo
    Public CLI_emailped2 As Cdatos.bdcampo
    Public CLI_emailped3 As Cdatos.bdcampo

    Public CLI_DatosActualizadosSN As Cdatos.bdcampo

    Public CLI_Asegurado As Cdatos.bdcampo
    Public CLI_NumeroContrato As Cdatos.bdcampo
    Public CLI_FechaSolicitud As Cdatos.bdcampo
    Public CLI_ImporteSolicitado As Cdatos.bdcampo
    Public CLI_ImporteConcedido As Cdatos.bdcampo
    Public CLI_RiesgoMaximo As Cdatos.bdcampo
    Public CLI_DesglosarLotes As Cdatos.bdcampo

    Public CLI_GGNEnFacturas As Cdatos.bdcampo
    Public CLI_ForzarGGNEnFacturas As Cdatos.bdcampo

    Public CLI_NumeroRegistro As Cdatos.bdcampo

    Public CLI_DatosEnCMR As Cdatos.bdcampo


    Public CLI_IdUsuarioLog As Cdatos.bdcampo
    Public CLI_FechaLog As Cdatos.bdcampo
    Public CLI_HoraLog As Cdatos.bdcampo



    Dim err As Errores
    Public Sub New()
         Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Dim Vendedor As New E_Vendedores(idUsuario, cn)
        Try
            NombreTabla = "Clientes"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            CLI_Codigo = New Cdatos.bdcampo(CodigoEntidad & "Idcliente", Cdatos.TiposCampo.Entero, 5, 0, True)
            CLI_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 100)
            CLI_Nif = New Cdatos.bdcampo(CodigoEntidad & "Nif", Cdatos.TiposCampo.Cadena, 15)
            CLI_IdTipo = New Cdatos.bdcampo(CodigoEntidad & "Idtipo", Cdatos.TiposCampo.EnteroPositivo, 4)
            CLI_Ididioma = New Cdatos.bdcampo(CodigoEntidad & "ididioma", Cdatos.TiposCampo.EnteroPositivo, 4)
            CLI_Iddivisa = New Cdatos.bdcampo(CodigoEntidad & "iddivisa", Cdatos.TiposCampo.EnteroPositivo, 4)
            CLI_IdVendedor = New Cdatos.bdcampo(CodigoEntidad & "idvendedor", Cdatos.TiposCampo.EnteroPositivo, 4, 0, False, Vendedor, Vendedor.VED_idcomercial, Vendedor.VED_nombre)

            CLI_Domicilio = New Cdatos.bdcampo(CodigoEntidad & "Domicilio", Cdatos.TiposCampo.Cadena, 150)
            CLI_Poblacion = New Cdatos.bdcampo(CodigoEntidad & "Poblacion", Cdatos.TiposCampo.Cadena, 50)
            CLI_Provincia = New Cdatos.bdcampo(CodigoEntidad & "Provincia", Cdatos.TiposCampo.Cadena, 50)
            CLI_CPostal = New Cdatos.bdcampo(CodigoEntidad & "CPostal", Cdatos.TiposCampo.Cadena, 8)
            CLI_IdZona = New Cdatos.bdcampo(CodigoEntidad & "IdZona", Cdatos.TiposCampo.EnteroPositivo, 4)
            CLI_Telefono1 = New Cdatos.bdcampo(CodigoEntidad & "Telefono1", Cdatos.TiposCampo.Cadena, 15)
            CLI_Telefono2 = New Cdatos.bdcampo(CodigoEntidad & "Telefono2", Cdatos.TiposCampo.Cadena, 15)
            CLI_Fax = New Cdatos.bdcampo(CodigoEntidad & "Fax", Cdatos.TiposCampo.Cadena, 15)
            CLI_Mail = New Cdatos.bdcampo(CodigoEntidad & "Mail", Cdatos.TiposCampo.Cadena, 250)
            CLI_IdPais = New Cdatos.bdcampo(CodigoEntidad & "IdPais", Cdatos.TiposCampo.EnteroPositivo, 4)

            CLI_FechaAlta = New Cdatos.bdcampo(CodigoEntidad & "fechaalta", Cdatos.TiposCampo.Fecha, 10)
            CLI_Bloqueo = New Cdatos.bdcampo(CodigoEntidad & "bloqueo", Cdatos.TiposCampo.Cadena, 1)
            CLI_Bloqueocausa = New Cdatos.bdcampo(CodigoEntidad & "bloqueocausa", Cdatos.TiposCampo.Cadena, 50)
            CLI_IdComisionista = New Cdatos.bdcampo(CodigoEntidad & "idcomisionista", Cdatos.TiposCampo.EnteroPositivo, 5)

            CLI_FC = New Cdatos.bdcampo(CodigoEntidad & "FC", Cdatos.TiposCampo.Cadena, 1)
            CLI_Quincenasfax = New Cdatos.bdcampo(CodigoEntidad & "QuincenasFax", Cdatos.TiposCampo.Cadena, 1)
            CLI_KB = New Cdatos.bdcampo(CodigoEntidad & "KB", Cdatos.TiposCampo.Cadena, 1)
            CLI_FacturaEnvaseComercio = New Cdatos.bdcampo(CodigoEntidad & "Facturaenvasecomercio", Cdatos.TiposCampo.Cadena, 1)
            CLI_observacionesfactura = New Cdatos.bdcampo(CodigoEntidad & "observacionesfactura", Cdatos.TiposCampo.Cadena, 50)

            CLI_Contrato = New Cdatos.bdcampo(CodigoEntidad & "Contrato", Cdatos.TiposCampo.Cadena, 1)

            CLI_IdFormaPago = New Cdatos.bdcampo(CodigoEntidad & "IdFormaPago", Cdatos.TiposCampo.Entero, 3)

            CLI_idtipoporte = New Cdatos.bdcampo(CodigoEntidad & "Idtipoporte", Cdatos.TiposCampo.Entero, 3)
            CLI_origendestino = New Cdatos.bdcampo(CodigoEntidad & "origendestino", Cdatos.TiposCampo.Cadena, 1)

            CLI_emailalba1 = New Cdatos.bdcampo(CodigoEntidad & "emailalba1", Cdatos.TiposCampo.Cadena, 50)
            CLI_emailalba2 = New Cdatos.bdcampo(CodigoEntidad & "emailalba2", Cdatos.TiposCampo.Cadena, 50)
            CLI_emailalba3 = New Cdatos.bdcampo(CodigoEntidad & "emailalba3", Cdatos.TiposCampo.Cadena, 50)

            CLI_emailped1 = New Cdatos.bdcampo(CodigoEntidad & "emailped1", Cdatos.TiposCampo.Cadena, 50)
            CLI_emailped2 = New Cdatos.bdcampo(CodigoEntidad & "emailped2", Cdatos.TiposCampo.Cadena, 50)
            CLI_emailped3 = New Cdatos.bdcampo(CodigoEntidad & "emailped3", Cdatos.TiposCampo.Cadena, 50)

            CLI_DatosActualizadosSN = New Cdatos.bdcampo(CodigoEntidad & "DatosActualizadosSN", Cdatos.TiposCampo.Cadena, 1)
            CLI_Asegurado = New Cdatos.bdcampo(CodigoEntidad & "Asegurado", Cdatos.TiposCampo.Cadena, 1)
            CLI_NumeroContrato = New Cdatos.bdcampo(CodigoEntidad & "Numerocontrato", Cdatos.TiposCampo.Cadena, 20)
            CLI_FechaSolicitud = New Cdatos.bdcampo(CodigoEntidad & "FechaSolicitud", Cdatos.TiposCampo.Fecha, 10)
            CLI_ImporteSolicitado = New Cdatos.bdcampo(CodigoEntidad & "ImporteSolicitado", Cdatos.TiposCampo.Importe, 12, 2)
            CLI_ImporteConcedido = New Cdatos.bdcampo(CodigoEntidad & "ImporteConcedido", Cdatos.TiposCampo.Importe, 12, 2)
            CLI_RiesgoMaximo = New Cdatos.bdcampo(CodigoEntidad & "RiesgoMaximo", Cdatos.TiposCampo.Importe, 12, 2)

            CLI_DesglosarLotes = New Cdatos.bdcampo(CodigoEntidad & "DesglosarLotes", Cdatos.TiposCampo.Cadena, 1)

            CLI_GGNEnFacturas = New Cdatos.bdcampo(CodigoEntidad & "GGNEnFacturas", Cdatos.TiposCampo.Cadena, 1)
            CLI_ForzarGGNEnFacturas = New Cdatos.bdcampo(CodigoEntidad & "ForzarGGNEnFacturas", Cdatos.TiposCampo.Cadena, 1)

            CLI_NumeroRegistro = New Cdatos.bdcampo(CodigoEntidad & "NumeroRegistro", Cdatos.TiposCampo.Cadena, 30)

            CLI_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            CLI_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            CLI_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)

            CLI_DatosEnCMR = New Cdatos.bdcampo(CodigoEntidad & "DatosEnCMR", Cdatos.TiposCampo.Cadena, 1)


            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim sql As String = "Select CLI_Idcliente as IdCliente," & vbCrLf
        sql = sql & " CASE COALESCE(CLI_Bloqueo, 'N') WHEN 'S' THEN 'S' ELSE 'N' END as Bloqueado," & vbCrLf
        sql = sql & " CLI_Nombre as Nombre, CLI_Nif as NIF," & vbCrLf
        sql = sql & " MON_Nombre as Divisa" & vbCrLf
        sql = sql & " from Clientes" & vbCrLf
        sql = sql & " left join moneda on MON_IdMoneda = CLI_IdDivisa"
        'sql = sql & " left join comun.dbo.moneda as M on M.IdMoneda = CLI_IdDivisa"



        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = sql
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idcliente"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaClientes"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmClientes"

        Dim Dc As New Dictionary(Of Object, Color)
        Dc("S") = Color.Red
        Dc("N") = Color.LimeGreen
        _btBusca.Params("Bloqueado", "B", 15, , , Dc)



    End Sub


    Private Sub E_Clientes_EliminaHijos() Handles Me.EliminaHijos

        Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
        Dim GastosClientes As New E_GastosClientes(Idusuario, cn)
        Dim Contactos As New E_Contactos(Idusuario, cn)
        Dim Observaciones As New E_Observaciones(Idusuario, cn)


        Dim sql As String = "SELECT CLD_Id FROM ClientesDescargas WHERE CLD_IdCliente = " & Me.CLI_Codigo.Valor

        Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
        For Each row As DataRow In dt.Rows

            Dim Id As String = row("CLD_Id").ToString & ""


            'Domicilios de descargas
            Try
                If ClientesDescargas.LeerId(Id) Then
                    ClientesDescargas.Eliminar()
                End If
            Catch ex As Exception
                err.Muestraerror("Error al eliminar los domicilios de descargas del cliente " & Me.CLI_Codigo.Valor, "E_Clientes.EliminaHijos", ex.Message)
            End Try


            'Observaciones
            Try
                Dim idobs As String = Observaciones.LeerCodigo("CLI", Me.CLI_Codigo.Valor)
                If VaInt(idobs) > 0 Then
                    If Observaciones.LeerId(idobs) = True Then
                        Observaciones.Eliminar()
                    End If
                End If
            Catch ex As Exception
                err.Muestraerror("Error al eliminar las observaciones del cliente " & Me.CLI_Codigo.Valor, "E_Clientes.EliminaHijos", ex.Message)
            End Try


            'GastosClientes
            Try
                Dim sqlGC As String = "Select GCL_Idlinea from gastosclientes where GCL_idcliente = " & Me.CLI_Codigo.Valor
                Dim dtGC As DataTable = GastosClientes.MiConexion.ConsultaSQL(sqlGC)

                For Each rowGC As DataRow In dtGC.Rows
                    Dim IdLinea As String = rowGC("GCL_IdLinea").ToString & ""
                    If GastosClientes.LeerId(IdLinea) Then
                        GastosClientes.Eliminar()
                    End If
                Next
            Catch ex As Exception
                err.Muestraerror("Error al eliminar los gastos del cliente " & Me.CLI_Codigo.Valor, "E_Clientes.EliminaHijos", ex.Message)
            End Try


            'Contactos
            Try
                Dim clave As String = "Cliente" & Me.CLI_Codigo.Valor
                Dim sqlContactos As String = "SELECT COT_Id as Id from Contactos WHERE COT_Fichero = 'Cliente' and COT_idfichero=" & Me.CLI_Codigo.Valor
                Dim dtContactos As DataTable = Contactos.MiConexion.ConsultaSQL(sqlContactos)

                For Each rowContactos As DataRow In dtContactos.Rows
                    Dim IdContacto As String = rowContactos("Id").ToString & ""
                    If Contactos.LeerId(IdContacto) Then
                        Contactos.Eliminar()
                    End If
                Next
            Catch ex As Exception
                err.Muestraerror("Error al eliminar los contactos del cliente " & Me.CLI_Codigo.Valor, "E_Clientes.EliminaHijos", ex.Message)
            End Try




        Next


    End Sub



End Class
