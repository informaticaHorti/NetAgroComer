Public Class E_Pagos

    Inherits Cdatos.Entidad


    Private err As New Errores

    Public IdPago As Cdatos.bdcampo
    Public Numero As Cdatos.bdcampo
    Public Importe As Cdatos.bdcampo
    Public FechaEmision As Cdatos.bdcampo
    Public FechaVencimiento As Cdatos.bdcampo
    Public IdBanco As Cdatos.bdcampo
    Public IdTipo As Cdatos.bdcampo
    Public Cuenta As Cdatos.bdcampo
    Public Documento As Cdatos.bdcampo
    Public IdAsiento As Cdatos.bdcampo
    Public IdAsientoCancelacion As Cdatos.bdcampo
    Public IdRemesa As Cdatos.bdcampo




    Public Sub New()
        Me.New(0, Nothing)
    End Sub



    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "Pagos"
            NombreBd = ObtenerBDConexion(conexion)
            MiConexion = conexion

            IdPago = New Cdatos.bdcampo("IdPago", Cdatos.TiposCampo.Entero, 10, 0, True)
            Numero = New Cdatos.bdcampo("Numero", Cdatos.TiposCampo.Importe, 12)
            Importe = New Cdatos.bdcampo("Importe", Cdatos.TiposCampo.Importe, 10, 2)
            FechaEmision = New Cdatos.bdcampo("FechaEmision", Cdatos.TiposCampo.Fecha, 15)
            FechaVencimiento = New Cdatos.bdcampo("FechaVencimiento", Cdatos.TiposCampo.Fecha, 15)
            IdBanco = New Cdatos.bdcampo("Idbanco", Cdatos.TiposCampo.Entero, 10)
            IdTipo = New Cdatos.bdcampo("IdTipo", Cdatos.TiposCampo.Entero, 10)
            Cuenta = New Cdatos.bdcampo("Cuenta", Cdatos.TiposCampo.Cadena, 20)
            Documento = New Cdatos.bdcampo("Documento", Cdatos.TiposCampo.Cadena, 20)
            IdAsiento = New Cdatos.bdcampo("IdAsiento", Cdatos.TiposCampo.Entero, 10)
            IdAsientoCancelacion = New Cdatos.bdcampo("IdAsientoCancelacion", Cdatos.TiposCampo.Entero, 10)
            IdRemesa = New Cdatos.bdcampo("IdRemesa", Cdatos.TiposCampo.Entero, 10)




            MiListadeCampos = ListadeCampos()

            Dim Bancos As New E_Bancos(idUsuario, ConexCtb(MiMaletin.IdEmpresaCTB))


            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(Me.IdPago, "Id")
            CONSULTA.SelCampo(Me.Importe, "Importe")
            CONSULTA.SelCampo(Me.FechaEmision, "FechaEmision")
            CONSULTA.SelCampo(Me.FechaVencimiento, "FechaVencimiento")
            CONSULTA.SelCampo(Bancos.IdBanco, "IdBanco", Me.IdBanco)
            CONSULTA.SelCampo(Bancos.Nombre, "Banco")
            CONSULTA.SelCampo(Me.Cuenta, "Cuenta")
            CONSULTA.SelCampo(Me.Documento, "Documento")

            Dim Sql As String = CONSULTA.SQL

            _btBusca.CL_CampoOrden = "Banco"
            _btBusca.CL_ConsultaSql = CONSULTA.SQL + " order by Id"
            _btBusca.CL_ControlAsociado = Nothing
            _btBusca.CL_DevuelveCampo = "Id"
            _btBusca.CL_Entidad = Me
            _btBusca.CL_Filtro = Nothing
            _btBusca.cl_formu = Nothing
            _btBusca.Name = "BtBuscaPagos"
            _btBusca.CL_ch1000 = False




        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub

  
End Class
