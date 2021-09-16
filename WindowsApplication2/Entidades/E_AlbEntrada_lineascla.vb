Public Class E_AlbEntrada_lineascla
    Inherits Cdatos.Entidad

    Public ALC_id As Cdatos.bdcampo
    Public ALC_idlineaentrada As Cdatos.bdcampo
    Public ALC_idalbaran As Cdatos.bdcampo
    Public ALC_idgenero As Cdatos.bdcampo
    Public ALC_kilosnetos As Cdatos.bdcampo
    Public ALC_bultos As Cdatos.bdcampo
    Public ALC_idcategoria As Cdatos.bdcampo
    Public ALC_precio As Cdatos.bdcampo
    Public ALC_piezas As Cdatos.bdcampo

    Public ALC_IdUsuarioLog As Cdatos.bdcampo
    Public ALC_FechaLog As Cdatos.bdcampo
    Public ALC_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Dim Generos As New E_Generos(idUsuario, cn)
        Dim Envases As New E_Envases(idUsuario, cn)
        Dim Categoria As New E_CategoriasEntrada(idUsuario, cn)


        Try
            NombreTabla = "AlbEntrada_lineascla"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            ALC_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            ALC_idalbaran = New Cdatos.bdcampo(CodigoEntidad & "idalbaran", Cdatos.TiposCampo.EnteroPositivo, 6)
            ALC_idlineaentrada = New Cdatos.bdcampo(CodigoEntidad & "idlineaentrada", Cdatos.TiposCampo.EnteroPositivo, 6)
            ALC_idgenero = New Cdatos.bdcampo(CodigoEntidad & "idgenero", Cdatos.TiposCampo.EnteroPositivo, 5, 0, False, Generos, Generos.GEN_IdGenero, Generos.GEN_NombreGenero)
            ALC_kilosnetos = New Cdatos.bdcampo(CodigoEntidad & "kilosnetos", Cdatos.TiposCampo.Importe, 12, 2)
            ALC_bultos = New Cdatos.bdcampo(CodigoEntidad & "bultos", Cdatos.TiposCampo.Entero, 4)
            ALC_idcategoria = New Cdatos.bdcampo(CodigoEntidad & "idcategoria", Cdatos.TiposCampo.EnteroPositivo, 4, 0, False, Categoria, Categoria.CAE_Id, Categoria.CAE_CategoriaCalibre)
            ALC_precio = New Cdatos.bdcampo(CodigoEntidad & "precio", Cdatos.TiposCampo.Importe, 6, 4)
            ALC_piezas = New Cdatos.bdcampo(CodigoEntidad & "piezas", Cdatos.TiposCampo.Entero, 4)

            ALC_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            ALC_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            ALC_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


    'Public Sub ActualizaLineasMuestreo(ByVal idlineaentrada As String, ByVal muestreo As String)

    '    If Len(muestreo) < 3 Then
    '        MsgBox("no se pudo actualizar los numeros de muestreo")
    '        Exit Sub

    '    End If

    '    Dim sql As String = "Select ALC_id as id from albentrada_lineascla where ALC_idlineaentrada=" + idlineaentrada + " order by ALC_id"
    '    Dim dt As DataTable = MiConexion.ConsultaSQL(sql)
    '    Dim Nume As String = FnLeft(muestreo, Len(muestreo) - 2)
    '    Dim nMuestreo As String = ""
    '    Dim x As Integer = 0
    '    For Each rw In dt.Rows
    '        x = x + 1
    '        If Me.LeerId(rw("id")) = True Then
    '            nMuestreo = Nume + Format(x, "00")
    '            Me.ALC_muestreo.Valor = nMuestreo
    '            Me.Actualizar()
    '        End If
    '    Next

    'End Sub



   


   
  

End Class
