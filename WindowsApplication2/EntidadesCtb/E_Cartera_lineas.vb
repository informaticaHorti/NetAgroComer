Public Class E_Cartera_lineas
    Inherits Cdatos.Entidad


    Private err As New Errores

    Public Idlinea As Cdatos.bdcampo
    Public Idregistro As Cdatos.bdcampo
    Public Vencimiento As Cdatos.bdcampo
    Public Importe As Cdatos.bdcampo
    Public Estado As Cdatos.bdcampo
    Public Idbanco As Cdatos.bdcampo
    Public IdTipodoc As Cdatos.bdcampo
    Public DocPago As Cdatos.bdcampo
    Public FechaCancelacion As Cdatos.bdcampo
    Public IdRegistroPago As Cdatos.bdcampo


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "Cartera_lineas"
            NombreBd = ObtenerBDConexion(conexion)

            MiConexion = conexion
            PrefijoContador = ""

            Idlinea = New Cdatos.bdcampo("Idlinea", Cdatos.TiposCampo.Entero, 10, 0, True)
            Idregistro = New Cdatos.bdcampo("Idregistro", Cdatos.TiposCampo.Entero, 10)
            Vencimiento = New Cdatos.bdcampo("Vencimiento", Cdatos.TiposCampo.Fecha, 10)
            Importe = New Cdatos.bdcampo("Importe", Cdatos.TiposCampo.Importe, 15, 2)
            Estado = New Cdatos.bdcampo("Estado", Cdatos.TiposCampo.Cadena, 1)
            Idbanco = New Cdatos.bdcampo("IdBanco", Cdatos.TiposCampo.EnteroPositivo, 3)
            IdTipodoc = New Cdatos.bdcampo("Idtipodoc", Cdatos.TiposCampo.EnteroPositivo, 3)
            DocPago = New Cdatos.bdcampo("Docpago", Cdatos.TiposCampo.Cadena, 15)
            FechaCancelacion = New Cdatos.bdcampo("FechaCancelacion", Cdatos.TiposCampo.Fecha, 10)
            IdRegistroPago = New Cdatos.bdcampo("IdRegistroPago", Cdatos.TiposCampo.EnteroPositivo, 10)



            MiListadeCampos = ListadeCampos()



        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub





End Class
