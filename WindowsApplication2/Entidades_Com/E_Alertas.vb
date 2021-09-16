Public Class E_Alertas

    Inherits Cdatos.Entidad

    Public ALE_id As Cdatos.bdcampo
    Public ALE_fecha As Cdatos.bdcampo
    Public ALE_hora As Cdatos.bdcampo
    Public ALE_idusuario As Cdatos.bdcampo
    Public ALE_NombreUsuario As Cdatos.bdcampo
    Public ALE_Alerta As Cdatos.bdcampo
    Public ALE_Email As Cdatos.bdcampo


    Dim err As Errores
    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "alertas"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            ALE_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 10, 0, True)
            ALE_fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 2)
            ALE_hora = New Cdatos.bdcampo(CodigoEntidad & "hora", Cdatos.TiposCampo.Cadena, 10)
            ALE_idusuario = New Cdatos.bdcampo(CodigoEntidad & "idusuario", Cdatos.TiposCampo.EnteroPositivo, 6)
            ALE_NombreUsuario = New Cdatos.bdcampo(CodigoEntidad & "nombreusuario", Cdatos.TiposCampo.Cadena, 50)
            ALE_Alerta = New Cdatos.bdcampo(CodigoEntidad & "alerta", Cdatos.TiposCampo.Cadena, 50)
            ALE_Email = New Cdatos.bdcampo(CodigoEntidad & "email", Cdatos.TiposCampo.Cadena, 255)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub

    Public Sub NuevaAlerta(ByVal Alerta As String)
        Dim id As Integer = Me.MaxId
        Me.ALE_id.Valor = id.ToString
        Me.ALE_fecha.Valor = Format(Now, "dd/MM/yyyy")
        Me.ALE_hora.Valor = Format(Now, "HH:mm:ss")
        Me.ALE_idusuario.Valor = Idusuario
        Me.ALE_NombreUsuario.Valor = NombreUsuario
        Me.ALE_Alerta.Valor = Alerta
        Me.Insertar()

        MsgBox("Se generó la alerta " + id.ToString)
        EnviaMail(id, Alerta + ". Usuario: " + NombreUsuario)

    End Sub

    Public Sub EnviaMail(ByVal idalerta As String, ByVal Alerta As String)
        Dim Idgrupo As String
        Dim DatosUsuario As New E_DatosUsuario(Idusuario, CnComun)
        Dim Grupos As New E_Grupos(Idusuario, CnComun)
        Dim Email1 As String = ""
        Dim Email2 As String = ""
        Dim Email3 As String = ""

        If DatosUsuario.LeerId(Idusuario.ToString) = True Then
            Idgrupo = DatosUsuario.idgrupo.Valor
            If Grupos.LeerId(Idgrupo) = True Then
                If VaInt(Grupos.Idresponsable1.Valor) > 0 Then
                    If DatosUsuario.LeerId(Grupos.Idresponsable1.Valor) = True Then
                        Email1 = DatosUsuario.Email.Valor
                        EnviaMensaje(Email1, Alerta)
                    End If
                    If DatosUsuario.LeerId(Grupos.IdResponsable2.Valor) = True Then
                        Email2 = DatosUsuario.Email.Valor
                        EnviaMensaje(Email2, Alerta)
                    End If
                    If DatosUsuario.LeerId(Grupos.IdResponsable3.Valor) = True Then
                        Email3 = DatosUsuario.Email.Valor
                        EnviaMensaje(Email3, Alerta)

                    End If

                End If
            End If
        End If
        If Me.LeerId(idalerta) = True Then
            Me.ALE_Email.Valor = Email1 + "; " + Email2 + "; " + Email3
            Me.Actualizar()
        End If

    End Sub

    Private Sub EnviaMensaje(ByVal para As String, ByVal asunto As String)

        Dim config As New Configuracion
        Dim Adj As New List(Of String)
        If para <> "" Then
            config.Puerto = "587"
            config.Servidor = "mail.clavesis.com"
            config.SSL = False
            config.Usuario = "mgarcia-clavesis-com"
            config.Clave = "indalo"
            Dim mail As New ClvMail("mgarcia@clavesis.com", para, "Alerta ERP CLAVE", asunto, Adj, Nothing)
            mail.Configuracion = config
            mail.Enviar()
        End If
    End Sub
End Class
