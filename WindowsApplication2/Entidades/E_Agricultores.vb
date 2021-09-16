Public Class E_Agricultores
    Inherits Cdatos.Entidad


    Public Enum FormasPago
        Talon = 1
        Pagare = 2
        Transferencia = 3
    End Enum



    Public AGR_IdAgricultor As Cdatos.bdcampo
    Public AGR_Nombre As Cdatos.bdcampo
    Public AGR_Nif As Cdatos.bdcampo
    Public AGR_Domicilio As Cdatos.bdcampo
    Public AGR_Poblacion As Cdatos.bdcampo
    Public AGR_Provincia As Cdatos.bdcampo
    Public AGR_Cpostal As Cdatos.bdcampo
    Public AGR_IdPais As Cdatos.bdcampo
    Public AGR_Telefono As Cdatos.bdcampo
    Public AGR_Movil As Cdatos.bdcampo
    Public AGR_Fax As Cdatos.bdcampo
    Public AGR_Mail As Cdatos.bdcampo
    Public AGR_PersonaContacto As Cdatos.bdcampo
    Public AGR_IdTipo As Cdatos.bdcampo
    Public AGR_IdPrincipal As Cdatos.bdcampo
    Public AGR_Bloqueado As Cdatos.bdcampo
    Public AGR_TextoMensaje1 As Cdatos.bdcampo
    Public AGR_TextoMensaje2 As Cdatos.bdcampo
    Public AGR_IdZona As Cdatos.bdcampo

    Public AGR_fechaalta As Cdatos.bdcampo
    Public AGR_marcaaviso As Cdatos.bdcampo
    Public AGR_tipofcs As Cdatos.bdcampo

    Public AGR_idenvases As Cdatos.bdcampo
    Public AGR_idcrecogida As Cdatos.bdcampo
    Public AGR_idempresa As Cdatos.bdcampo
    Public AGR_fechaaltaopfh As Cdatos.bdcampo

    Public AGR_serie As Cdatos.bdcampo

    Public AGR_NoFacturar As Cdatos.bdcampo
    Public AGR_idBanco As Cdatos.bdcampo
    Public AGR_idcentro As Cdatos.bdcampo

    Public AGR_IdFormaPago As Cdatos.bdcampo
    Public AGR_IBAN As Cdatos.bdcampo
    Public AGR_DiasVto As Cdatos.bdcampo
    Public AGR_SituacionCartera As Cdatos.bdcampo
    Public AGR_TipoDocumento As Cdatos.bdcampo

    Public AGR_EmailCalidad As Cdatos.bdcampo


    Public AGR_IdUsuarioLog As Cdatos.bdcampo
    Public AGR_FechaLog As Cdatos.bdcampo
    Public AGR_HoraLog As Cdatos.bdcampo


    Dim err As Errores
   
    Public Sub New()
        'MyBase.new()

        Me.New(0, Nothing)

    End Sub
    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Agricultores"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            AGR_IdAgricultor = New Cdatos.bdcampo(CodigoEntidad & "Idagricultor", Cdatos.TiposCampo.Entero, 5, 0, True)
            AGR_Nombre = New Cdatos.bdcampo(CodigoEntidad & "Nombre", Cdatos.TiposCampo.Cadena, 50)
            AGR_Nif = New Cdatos.bdcampo(CodigoEntidad & "Nif", Cdatos.TiposCampo.Cadena, 15)
            AGR_Domicilio = New Cdatos.bdcampo(CodigoEntidad & "Domicilio", Cdatos.TiposCampo.Cadena, 50)
            AGR_Poblacion = New Cdatos.bdcampo(CodigoEntidad & "Poblacion", Cdatos.TiposCampo.Cadena, 50)
            AGR_Provincia = New Cdatos.bdcampo(CodigoEntidad & "Provincia", Cdatos.TiposCampo.Cadena, 30)
            AGR_Cpostal = New Cdatos.bdcampo(CodigoEntidad & "Cpostal", Cdatos.TiposCampo.Cadena, 5)
            AGR_IdPais = New Cdatos.bdcampo(CodigoEntidad & "IdPais", Cdatos.TiposCampo.EnteroPositivo, 4)
            AGR_Telefono = New Cdatos.bdcampo(CodigoEntidad & "Telefono", Cdatos.TiposCampo.Cadena, 15)
            AGR_Movil = New Cdatos.bdcampo(CodigoEntidad & "Movil", Cdatos.TiposCampo.Cadena, 15)
            AGR_Fax = New Cdatos.bdcampo(CodigoEntidad & "Fax", Cdatos.TiposCampo.Cadena, 15)
            AGR_Mail = New Cdatos.bdcampo(CodigoEntidad & "Mail", Cdatos.TiposCampo.Cadena, 50)
            AGR_PersonaContacto = New Cdatos.bdcampo(CodigoEntidad & "PersonaContacto", Cdatos.TiposCampo.Cadena, 30)
            AGR_IdTipo = New Cdatos.bdcampo(CodigoEntidad & "idtipo", Cdatos.TiposCampo.EnteroPositivo, 4)
            AGR_IdPrincipal = New Cdatos.bdcampo(CodigoEntidad & "idprincipal", Cdatos.TiposCampo.Cadena, 5)
            AGR_Bloqueado = New Cdatos.bdcampo(CodigoEntidad & "bloqueado", Cdatos.TiposCampo.Cadena, 1)
            AGR_TextoMensaje1 = New Cdatos.bdcampo(CodigoEntidad & "Textomensaje1", Cdatos.TiposCampo.Cadena, 30)
            AGR_TextoMensaje2 = New Cdatos.bdcampo(CodigoEntidad & "Textomensaje2", Cdatos.TiposCampo.Cadena, 30)
            AGR_IdZona = New Cdatos.bdcampo(CodigoEntidad & "idzona", Cdatos.TiposCampo.EnteroPositivo, 4)
            AGR_fechaalta = New Cdatos.bdcampo(CodigoEntidad & "fechaalta", Cdatos.TiposCampo.Fecha, 10)
            AGr_marcaaviso = New Cdatos.bdcampo(CodigoEntidad & "marcaaviso", Cdatos.TiposCampo.Cadena, 1)
            AGR_tipofcs = New Cdatos.bdcampo(CodigoEntidad & "tipofcs", Cdatos.TiposCampo.Cadena, 1)
            AGR_idenvases = New Cdatos.bdcampo(CodigoEntidad & "idenvases", Cdatos.TiposCampo.Cadena, 5)
            AGR_idcrecogida = New Cdatos.bdcampo(CodigoEntidad & "idcrecogida", Cdatos.TiposCampo.Cadena, 5)
            AGR_idempresa = New Cdatos.bdcampo(CodigoEntidad & "idempresa", Cdatos.TiposCampo.Cadena, 3)
            AGR_fechaaltaopfh = New Cdatos.bdcampo(CodigoEntidad & "fechaaltaopfh", Cdatos.TiposCampo.Fecha, 10)
            AGR_serie = New Cdatos.bdcampo(CodigoEntidad & "serie", Cdatos.TiposCampo.Cadena, 5)
            AGR_NoFacturar = New Cdatos.bdcampo(CodigoEntidad & "NoFacturar", Cdatos.TiposCampo.Cadena, 1)
            AGR_idBanco = New Cdatos.bdcampo(CodigoEntidad & "idbanco", Cdatos.TiposCampo.EnteroPositivo, 3)
            AGR_idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.EnteroPositivo, 3)

            AGR_IdFormaPago = New Cdatos.bdcampo(CodigoEntidad & "IdFormaPago", Cdatos.TiposCampo.EnteroPositivo, 3)
            AGR_IBAN = New Cdatos.bdcampo("IBAN", Cdatos.TiposCampo.Cadena, 50)
            AGR_DiasVto = New Cdatos.bdcampo(CodigoEntidad & "DiasVto", Cdatos.TiposCampo.EnteroPositivo, 3)
            AGR_SituacionCartera = New Cdatos.bdcampo(CodigoEntidad & "SituacionCartera", Cdatos.TiposCampo.EnteroPositivo, 10)
            AGR_TipoDocumento = New Cdatos.bdcampo(CodigoEntidad & "TipoDocumento", Cdatos.TiposCampo.EnteroPositivo, 10)

            AGR_EmailCalidad = New Cdatos.bdcampo(CodigoEntidad & "EmailCalidad", Cdatos.TiposCampo.Cadena, 512)

            AGR_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            AGR_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            AGR_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)

        End Try


        _btBusca.CL_CampoOrden = "Nombre"
        _btBusca.CL_ConsultaSql = "Select AGR_IdAgricultor as IdAgricultor, AGR_Nombre as Nombre, AGR_Nif as NIF, AGR_idempresa as Emp,AGR_IdTipo as Tipo, TPA_TipoFactura as TipoFactura from Agricultores left join TipoAgricultor ON TPA_IdTipo = AGR_IdTipo"
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "IdAgricultor"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaAgricultor"
        _btBusca.CL_ch1000 = False
        _btBusca.cl_formu = "FrmAgricultores"
        _btBusca.Params("TipoFactura", , -1)

    End Sub

    Private Sub E_Agricultores_EliminaHijos() Handles Me.EliminaHijos


        Dim sql As String

        sql = "Delete from agricultorgastos where AGG_idagricultor=" + AGR_IdAgricultor.Valor
        Me.MiConexion.OrdenSql(sql)

        sql = "select MED_idmedianeria from medianeria where MED_idagricultor=" + AGR_IdAgricultor.Valor
        Dim DT As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not DT Is Nothing Then
            For Each RW In DT.Rows
                Dim Idmedianeria As Integer = VaInt(RW("med_idmedianeria"))
                Dim medianeria As New E_Medianeria(Idusuario, cn)
                If medianeria.LeerId(Idmedianeria) = True Then
                    medianeria.Eliminar()
                End If
            Next
        End If
    
        Dim Contactos As New E_Contactos(Idusuario, cn)
        Dim sqlContactos As String = "SELECT COT_Id as Id from Contactos WHERE COT_Fichero = 'Proveedor' and COT_idfichero=" & Me.AGR_IdAgricultor.Valor
        Dim dtContactos As DataTable = Contactos.MiConexion.ConsultaSQL(sqlContactos)

        For Each rowContactos As DataRow In dtContactos.Rows
            Dim IdContacto As String = rowContactos("Id").ToString & ""
            If Contactos.LeerId(IdContacto) Then
                Contactos.Eliminar()
            End If
        Next

        sql = "Delete from observaciones where OBS_Tipo = 'AGR' AND OBS_Codigo = " & Me.AGR_IdAgricultor.Valor
        Me.MiConexion.ConsultaSQL(sql)



    End Sub



End Class
