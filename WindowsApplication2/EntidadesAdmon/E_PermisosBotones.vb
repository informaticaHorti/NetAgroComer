Public Class E_PermisosBotones
    Inherits Cdatos.Entidad


    Private err As New Errores


    Public PBT_Id As Cdatos.bdcampo
    Public PBT_FormularioBoton As Cdatos.bdcampo
    Public PBT_Descripcion As Cdatos.bdcampo
    Public PBT_Clave As Cdatos.bdcampo


    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "PermisosBotones"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"



            PBT_Id = New Cdatos.bdcampo(CodigoEntidad & "Id", Cdatos.TiposCampo.Entero, 10, 0, True)
            PBT_FormularioBoton = New Cdatos.bdcampo(CodigoEntidad & "FormularioBoton", Cdatos.TiposCampo.Cadena, 200)
            PBT_Descripcion = New Cdatos.bdcampo(CodigoEntidad & "Descripcion", Cdatos.TiposCampo.Cadena, 50)
            PBT_Clave = New Cdatos.bdcampo(CodigoEntidad & "Clave", Cdatos.TiposCampo.Cadena, 20)

            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.MuestraError("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub


    ''' <summary>
    ''' Valida los permisos del botón en función de la clave pasada.
    ''' </summary>
    ''' <param name="FormularioBoton"></param>
    ''' <param name="Clave"></param>
    ''' <returns></returns>
    ''' <remarks>Ojo, en principio el campo PBT_FormularioBoton es en minúscula: nombreformulario.nombreboton</remarks>
    Public Function ValidaClave(FormularioBoton As String, Clave As String) As Boolean

        Dim bRes As Boolean = False


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(Me.PBT_Id, "Id")
        CONSULTA.WheCampo(Me.PBT_FormularioBoton, "=", FormularioBoton)
        CONSULTA.WheCampo(Me.PBT_Clave, "=", Clave)

        Dim dt As DataTable = MiConexion.ConsultaSQL(CONSULTA.SQL)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                bRes = True
            End If
        End If


        Return bRes

    End Function


    Public Function ExisteRegistro(FormularioBoton As String, Optional ByRef Clave As String = "", Optional ByRef Descripcion As String = "") As Boolean

        Dim bRes As Boolean = False

        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(Me.PBT_Descripcion, "Descripcion")
        CONSULTA.SelCampo(Me.PBT_Clave, "Clave")
        CONSULTA.WheCampo(Me.PBT_FormularioBoton, "=", FormularioBoton)

        Dim dt As DataTable = MiConexion.ConsultaSQL(CONSULTA.SQL)
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                bRes = True
                Descripcion = dt.Rows(0)("Descripcion").ToString & ""
                Clave = dt.Rows(0)("Clave").ToString & ""

            End If
        End If


        Return bRes

    End Function


    Public Sub BorrarClave(lstBotones As List(Of String))

        Dim PermisosBoton As New E_PermisosBotones(Idusuario, cn)


        For Each boton As String In lstBotones

            Dim CONSULTA As New Cdatos.E_select
            CONSULTA.SelCampo(Me.PBT_Id, "Id")
            CONSULTA.WheCampo(PBT_FormularioBoton, "=", boton)

            Dim dt As DataTable = MiConexion.ConsultaSQL(CONSULTA.SQL)
            If Not IsNothing(dt) Then

                For Each row As DataRow In dt.Rows

                    Dim Id As String = (row("Id").ToString & "").Trim
                    If PermisosBoton.LeerId(Id) Then
                        PermisosBoton.Eliminar()
                    End If

                Next

            End If

        Next

    End Sub



    Public Sub AñadirClave(lstBotones As List(Of String), clave As String, descripcion As String)

        BorrarClave(lstBotones)

        For Each boton As String In lstBotones

            Dim PermisosBotones As New E_PermisosBotones(Idusuario, cn)
            PermisosBotones.PBT_Id.Valor = PermisosBotones.MaxId()
            PermisosBotones.PBT_FormularioBoton.Valor = boton
            PermisosBotones.PBT_Clave.Valor = clave
            PermisosBotones.PBT_Descripcion.Valor = descripcion

            PermisosBotones.Insertar()

        Next

    End Sub



End Class
