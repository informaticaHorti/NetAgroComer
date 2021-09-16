Public Class E_DescripcionGeneroPorIdioma
    Inherits Cdatos.Entidad

    Public DGI_Id As Cdatos.bdcampo
    Public DGI_IdGenero As Cdatos.bdcampo
    Public DGI_IdIdioma As Cdatos.bdcampo
    Public DGI_Descripcion As Cdatos.bdcampo
    Public DGI_IdUsuarioLog As Cdatos.bdcampo
    Public DGI_FechaLog As Cdatos.bdcampo
    Public DGI_HoraLog As Cdatos.bdcampo


    Public BtBuscaXtipo As BtBusca

    Dim err As Errores


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Dim Vendedor As New E_Vendedores(idUsuario, cn)
        Try

            NombreTabla = "DescripcionGeneroPorIdioma"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            DGI_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.Entero, 10, 0, True)
            DGI_IdGenero = New Cdatos.bdcampo(CodigoEntidad & "IdGenero", Cdatos.TiposCampo.Entero, 5)
            DGI_IdIdioma = New Cdatos.bdcampo(CodigoEntidad & "IdIdioma", Cdatos.TiposCampo.EnteroPositivo, 3)
            DGI_Descripcion = New Cdatos.bdcampo(CodigoEntidad & "Descripcion", Cdatos.TiposCampo.Cadena, 40)
            DGI_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            DGI_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            DGI_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try



    End Sub


    Public Sub ActualizarDescripcionGenero(IdIdioma As String, IdGenero As String, Descripcion As String)

        If VaInt(IdIdioma) > 0 And VaInt(IdGenero) > 0 Then


            Dim Id As String = ""


            Dim sql As String = "SELECT DGI_Id FROM DescripcionGeneroPorIdioma WHERE DGI_IdIdioma = " & IdIdioma & " AND DGI_IdGenero = " & IdGenero
            Dim dt As DataTable = MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Id = (dt.Rows(0)("DGI_Id").ToString & "").Trim

                End If
            End If


            Dim DescripcionGeneroPorIdioma As New E_DescripcionGeneroPorIdioma(Idusuario, cn)

            If VaInt(Id) = 0 Then
                DescripcionGeneroPorIdioma.DGI_Id.Valor = DescripcionGeneroPorIdioma.MaxId()
                DescripcionGeneroPorIdioma.DGI_IdIdioma.Valor = IdIdioma
                DescripcionGeneroPorIdioma.DGI_IdGenero.Valor = IdGenero
                DescripcionGeneroPorIdioma.DGI_Descripcion.Valor = Descripcion
                DescripcionGeneroPorIdioma.Insertar()
            Else

                If DescripcionGeneroPorIdioma.LeerId(Id) Then
                    DescripcionGeneroPorIdioma.DGI_Descripcion.Valor = Descripcion
                    DescripcionGeneroPorIdioma.Actualizar()
                End If

            End If


        End If

    End Sub


End Class
