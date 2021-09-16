Public Class E_Asientos

    Inherits Cdatos.Entidad


    Private err As New Errores

    Public IdAsiento As Cdatos.bdcampo
    Public Ejercicio As Cdatos.bdcampo
    Public Tipo As Cdatos.bdcampo
    Public Asiento As Cdatos.bdcampo
    Public Fecha As Cdatos.bdcampo
    Public Diario As Cdatos.bdcampo
    Public Generado As Cdatos.bdcampo
    Public Observaciones As Cdatos.bdcampo
    Public IdCentro As Cdatos.bdcampo
    Public CdOrigen As Cdatos.bdcampo
    Public IdOrigen As Cdatos.bdcampo


    Public Const AsientoFacturasEmitida As String = "FE"
    Public Const AsientoFacturasRecibida As String = "FR"
    Public Const AsientoCobro As String = "CO"
    Public Const AsientoRemesa As String = "RE"
    Public Const AsientoCancCobro As String = "CC"
    Public Const AsientoCancPago As String = "CP"
    Public Const AsientoOperacion As String = "OP"
    Public Const AsientoPago As String = "PA"
    Public Const AsientoLetras As String = "LE"
    Public Const AsientoAlbaranAgricultor = "AG"
    Public Const AsientoLiquidacion As String = "LQ"
    Public Const AsientoDesgloseAnticiposLiquidacion As String = "AQ"
    Public Const AsientoCambioCodigoLiquidacion As String = "CQ"
    Public Const AsientoTraspasoAlmacen As String = "TA"

    Public Const AsientoIRPFAgricultores As String = "IR"

    Public Const AsientoAportacionesExternas As String = "AX"

    Public Const AsientoFondoOperativo As String = "FO"


    Public Sub New()
        Me.New(0, Nothing)
    End Sub



    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try

            NombreTabla = "Asientos"
            NombreBd = ObtenerBDConexion(conexion)
            MiConexion = conexion

            PrefijoContador = ""

            IdAsiento = New Cdatos.bdcampo("IdAsiento", Cdatos.TiposCampo.Entero, 10, 0, True)
            Ejercicio = New Cdatos.bdcampo("Ejercicio", Cdatos.TiposCampo.Entero, 10)
            Tipo = New Cdatos.bdcampo("Tipo", Cdatos.TiposCampo.Cadena, 1)
            Asiento = New Cdatos.bdcampo("Asiento", Cdatos.TiposCampo.Entero, 10)
            Fecha = New Cdatos.bdcampo("Fecha", Cdatos.TiposCampo.Fecha, 8)
            Diario = New Cdatos.bdcampo("Diario", Cdatos.TiposCampo.Cadena, 6)
            Generado = New Cdatos.bdcampo("Generado", Cdatos.TiposCampo.Cadena, 1)
            Observaciones = New Cdatos.bdcampo("Observaciones", Cdatos.TiposCampo.Cadena, 200)
            IdCentro = New Cdatos.bdcampo("IdCentro", Cdatos.TiposCampo.Entero, 10)
            CdOrigen = New Cdatos.bdcampo("cdorigen", Cdatos.TiposCampo.Cadena, 2)
            IdOrigen = New Cdatos.bdcampo("Idorigen", Cdatos.TiposCampo.Entero, 10)

            MiListadeCampos = ListadeCampos()


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try

    End Sub

    Public Function MaxNumeroAsiento(ByVal Ejercicio As Integer, ByVal tipo As String, ByVal centro As String, ByVal vmax As Integer) As Integer

        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                max = ValorMaximo(Ejercicio.ToString & "_" & tipo & "_" & centro, vmax)
                existe = ValorIdNumeroAsiento(max.ToString, Ejercicio.ToString, tipo, centro)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de asiento", "Function ObtieneMaxNumeroAsiento", ex.Message)
            Return 0
        End Try


    End Function


    Public Function ValorIdNumeroAsiento(ByVal NumeroASiento As String, ByVal ejercicio As String, ByVal tipo As String, ByVal idcentro As String) As Integer
        Try
            Dim dt As New DataTable
            dt = MiConexion.ConsultaSQL("Select IdAsiento from Asientos WHERE Ejercicio=" & ejercicio & " AND Tipo='" & tipo & "' and Asiento=" & NumeroASiento & " and idcentro=" & idcentro)
            Dim existe As Boolean = False
            If dt.Rows.Count > 0 Then
                If dt.Rows(0)(0) IsNot DBNull.Value Then
                    existe = True
                    Return CInt(dt.Rows(0)("IdAsiento"))
                End If
            End If
            If existe = False Then
                Return 0
            Else
                Return 0
            End If

        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el numero de asiento  del id ", "Function ObtieneAsiento", ex.Message)
            Return 0
        End Try

    End Function


    Public Function ObtenerIdAsiento(ByVal NumeroASiento As Integer, ByVal ejercicio As Integer) As Integer
        Try
            Dim dt As New DataTable
            dt = MiConexion.ConsultaSQL("Select IdAsiento from Asientos WHERE Ejercicio=" & ejercicio.ToString & " and Asiento=" & NumeroASiento.ToString)
            Dim existe As Boolean = False
            If dt.Rows.Count > 0 Then
                If dt.Rows(0)(0) IsNot DBNull.Value Then
                    existe = True
                    Return CInt(dt.Rows(0)("IdAsiento"))
                End If
            End If
            If existe = False Then
                Return 0
            Else
                Return 0
            End If

        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el numero de asiento  del id ", "Function ObtieneAsiento", ex.Message)
            Return 0
        End Try

    End Function


    Private Sub Asientos_EliminaHijos() Handles Me.EliminaHijos
        If VaInt(IdAsiento.Valor) > 0 Then
            Dim dt As New DataTable
            dt = TablaAsientoLineas()

            For Each dr As DataRow In dt.Rows
                'Dim entiApunte As New E_AsientoLineas(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
                Dim entiApunte As New E_AsientoLineas(Idusuario, MiConexion)
                If entiApunte.LeerId(dr("IdApunte").ToString) Then
                    entiApunte.Eliminar()

                End If
            Next


        End If
    End Sub
    Public Function TablaAsientoLineas() As DataTable
        Try
            Dim csql As String = ""
            Dim dt As New DataTable

            csql = " SELECT Asientolineas.idapunte, Asientolineas.idasiento, Asientolineas.Numerocuenta, "
            csql = csql & " AsientoLineas.IdConcepto, AsientoLineas.Concepto, AsientoLineas.Documento, "
            csql = csql & " AsientoLineas.Debe, AsientoLineas.Haber, Asientolineas.SRPC, AsientoLineas.IdActividad, "
            csql = csql & " AsientoLineas.IdSeccion, AsientoLineas.IdDepartamento, AsientoLineas.IdSubdepartamento, "
            csql = csql & " AsientoLineas.IdRegistro, AsientoLineas.TipoSRPC, Asientolineas.Punteo "
            csql = csql & " FROM AsientoLineas "
            csql = csql & " WHERE IdAsiento=" & IdAsiento.Valor
            csql = csql & " ORDER BY IdApunte "
            dt = MiConexion.ConsultaSQL(csql)

            Return dt
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaron obtener las lineas de asiento", "Function TablaAsientoLineas", ex.Message)
            Return New DataTable
        End Try
        ' incluir todos los campos de las lineas ademas de los que queramos de otras tablas

    End Function
    Public Function ActuaLizaFechaTipoLineas(ByVal idAsiento As Integer, ByVal Fecha As Date, ByVal tipo As String) As Boolean
        Try
            Dim consulta As String = "Update Asientolineas set fecha='" + StDate(Fecha) + "',tipo='" + tipo + "' Where IdAsiento=" & idAsiento
            Dim dt As New DataTable

            MiConexion.OrdenSql(consulta)

        Catch ex As Exception
            err.Muestraerror("Error al actualizar las Lineas del asiento", "Functio ActuaLizaFechaTipoLineas", ex.Message)
            Return False
        End Try
        Return True
    End Function
    Private Sub Asientos_ActualizaHijos(ByVal nuevo As Boolean) Handles Me.ActualizaHijos
        If nuevo = False Then
            ActuaLizaFechaTipoLineas(VaInt(Me.IdAsiento.Valor), VaDate(Me.Fecha.Valor), Me.Tipo.Valor)
        End If

    End Sub

    Public Function ConsultaVisualizaAsiento(ByVal id As Integer) As DataTable
        Dim s As String = ""
        Dim dt As New DataTable



        s = " SELECT dbo.AsientoLineas.NumeroCuenta, "
        s = s & " isnull(dbo.Cuentas.Nombre, 'CUENTA INEXISTENTE') as Titulo, "
        s = s & " dbo.AsientoLineas.Concepto, dbo.AsientoLineas.Documento, "
        s = s & " dbo.Actividad.Nombre + ' ' + dbo.Seccion.Nombre as ActSecc, "
        s = s & " dbo.AsientoLineas.Debe, dbo.AsientoLineas.Haber "

        s = s & " FROM dbo.AsientoLineas INNER JOIN dbo.Asientos ON "
        s = s & " dbo.AsientoLineas.IdAsiento = dbo.Asientos.IdAsiento LEFT OUTER JOIN "
        s = s & " dbo.Cuentas ON dbo.AsientoLineas.NumeroCuenta = dbo.Cuentas.NumeroCuenta LEFT OUTER JOIN "
        s = s & " dbo.Actividad ON dbo.AsientoLineas.IdActividad = dbo.Actividad.IdActividad LEFT OUTER JOIN "
        s = s & " dbo.Seccion ON dbo.AsientoLineas.IdSeccion = dbo.Seccion.IdSeccion "

        s = s & " WHERE dbo.AsientoLineas.IdAsiento= " & StInt(id)

        dt = MiConexion.ConsultaSQL(s)

        Return dt
    End Function

    Public Sub RellenaNumero(ByVal id As String, ByRef Ejer As String, ByRef Numero As String)

        Ejer = ""
        Numero = ""
        If Val(id) > 0 Then
            If LeerId(id) = True Then
                Ejer = Ejercicio.Valor
                Numero = Asiento.Valor

            End If
        End If

    End Sub


    Public Function NumeroAsiento(IdAsiento As String) As String

        If LeerId(IdAsiento) Then
            Return Me.Asiento.Valor
        End If

        Return ""

    End Function


    Public Function AsientoPunteado(ByVal IdAsiento As String) As Boolean

        Dim bRes As Boolean = False


        If VaDec(IdAsiento) > 0 Then

            Dim sql As String = "SELECT IdApunte, Punteo, IdPunteo43 FROM AsientoLineas WHERE IdAsiento = " & IdAsiento & " AND (Punteo <> '' OR IdPunteo43 <> 0) "
            Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    bRes = True
                End If
            End If

        End If


        Return bRes

    End Function


End Class
