Public Class E_Fichero346

    Inherits Cdatos.Entidad

    Public F46_id As Cdatos.bdcampo
    Public F46_ejercicio As Cdatos.bdcampo
    Public F46_idempresa As Cdatos.bdcampo
    Public F46_idagricultor As Cdatos.bdcampo
    Public F46_idconcepto As Cdatos.bdcampo
    Public F46_Importe As Cdatos.bdcampo

    Public F46_IdUsuarioLog As Cdatos.bdcampo
    Public F46_FechaLog As Cdatos.bdcampo
    Public F46_HoraLog As Cdatos.bdcampo



    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Fichero346"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            F46_id = New Cdatos.bdcampo(CodigoEntidad & "id", Cdatos.TiposCampo.EnteroPositivo, 5, 0, True)
            F46_ejercicio = New Cdatos.bdcampo(CodigoEntidad & "Ejercicio", Cdatos.TiposCampo.EnteroPositivo, 2)
            F46_idempresa = New Cdatos.bdcampo(CodigoEntidad & "IdEmpresa", Cdatos.TiposCampo.EnteroPositivo, 3)
            F46_idagricultor = New Cdatos.bdcampo(CodigoEntidad & "IdAgricultor", Cdatos.TiposCampo.EnteroPositivo, 6)
            F46_idconcepto = New Cdatos.bdcampo(CodigoEntidad & "IdConcepto", Cdatos.TiposCampo.EnteroPositivo, 5)
            F46_Importe = New Cdatos.bdcampo(CodigoEntidad & "Importe", Cdatos.TiposCampo.Importe, 12, 2)




            F46_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            F46_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            F46_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

       

    End Sub


    Public Function DtRegistros(ByVal ejercicio As Integer, ByVal empresa As Integer, ByVal DesdeAgricultor As Integer, ByVal HastaAgricultor As Integer) As DataTable
        Dim Agricultor As New E_Agricultores(Idusuario, cn)
        Dim Conceptos346 As New E_Conceptos346(Idusuario, cn)


        Dim consulta As New Cdatos.E_select

        consulta.SelCampo(Me.F46_idagricultor, "Codigo")
        consulta.SelCampo(Agricultor.AGR_Nombre, "Agricultor", Me.F46_idagricultor)
        consulta.SelCampo(Agricultor.AGR_Nif, "Nif")
        consulta.SelCampo(Agricultor.AGR_Poblacion, "Poblacion")
        consulta.SelCampo(Agricultor.AGR_Cpostal, "Cpostal")
        consulta.SelCampo(Conceptos346.C46_nombre, "Concepto", Me.F46_idconcepto)
        consulta.SelCampo(Conceptos346.C46_clave, "Clave")
        consulta.SelCampo(Conceptos346.C46_tipo, "Tipo")
        consulta.SelCampo(Me.F46_Importe, "Importe")

        consulta.WheCampo(Me.F46_ejercicio, "=", ejercicio.ToString)
        consulta.WheCampo(Me.F46_idempresa, "=", empresa.ToString)

        If DesdeAgricultor > 0 Then
            consulta.WheCampo(Me.F46_idagricultor, ">=", DesdeAgricultor)
        End If

        If HastaAgricultor > 0 Then
            consulta.WheCampo(Me.F46_idagricultor, "<=", HastaAgricultor)
        End If


        Dim sql As String = consulta.SQL
        sql = sql & " order by Codigo"
        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        Return dt

    End Function
End Class
