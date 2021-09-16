Public Class E_usuarios_procesos
    Inherits Cdatos.Entidad


    Public UPR_id As Cdatos.bdcampo
    Public UPR_idusuario As Cdatos.bdcampo
    Public UPR_idaplicacion As Cdatos.bdcampo
    Public UPR_formulario As Cdatos.bdcampo
    Public UPR_proceso As Cdatos.bdcampo
    Public UPR_entidad As Cdatos.bdcampo
    Public UPR_identidad As Cdatos.bdcampo
    Public UPR_fecha As Cdatos.bdcampo
    Public UPR_hora As Cdatos.bdcampo

    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)

    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)



        Try
            NombreTabla = "usuarios_procesos"
            MiConexion = conexion
            NombreBd = "NetAgroComer"


            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            UPR_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            UPR_idusuario = New Cdatos.bdcampo(CodigoEntidad & "idusuario", Cdatos.TiposCampo.EnteroPositivo, 5)
            UPR_idaplicacion = New Cdatos.bdcampo(CodigoEntidad & "idaplicacion", Cdatos.TiposCampo.EnteroPositivo, 3)
            UPR_formulario = New Cdatos.bdcampo(CodigoEntidad & "formulario", Cdatos.TiposCampo.Cadena, 50)
            UPR_proceso = New Cdatos.bdcampo(CodigoEntidad & "proceso", Cdatos.TiposCampo.Cadena, 50)
            UPR_entidad = New Cdatos.bdcampo(CodigoEntidad & "entidad", Cdatos.TiposCampo.Cadena, 50)
            UPR_identidad = New Cdatos.bdcampo(CodigoEntidad & "identidad", Cdatos.TiposCampo.Cadena, 50)
            UPR_fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 10)
            UPR_hora = New Cdatos.bdcampo(CodigoEntidad & "hora", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()
        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try




    End Sub

    Public Sub AñadirProceso(ByVal NombreFormulario As String, ByVal Proceso As String, ByVal NombreEntidad As String, ByVal idEntidad As String)

        'Exit Sub

        Dim id As String = Me.MaxId
        Me.VaciaEntidad()
        Me.UPR_id.Valor = id
        Me.UPR_idusuario.Valor = Idusuario.ToString
        Me.UPR_idaplicacion.Valor = Idaplicacion.ToString
        Me.UPR_formulario.Valor = Left(NombreFormulario, 50)
        Me.UPR_proceso.Valor = Proceso
        Me.UPR_entidad.Valor = NombreEntidad
        Me.UPR_identidad.Valor = idEntidad
        Me.UPR_fecha.Valor = Now.ToShortDateString
        Me.UPR_hora.Valor = Format(Now, "HH:mm:ss")
        Me.Insertar()

    End Sub

End Class
