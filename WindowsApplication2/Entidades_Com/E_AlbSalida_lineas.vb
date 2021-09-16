Public Class E_AlbSalida_lineas
    Inherits Cdatos.Entidad

    Public ASL_idlinea As Cdatos.bdcampo
    Public ASL_idalbaran As Cdatos.bdcampo
    Public ASL_idgenero As Cdatos.bdcampo
    Public ASL_idtipoconfeccion As Cdatos.bdcampo
    Public ASL_idcategoria As Cdatos.bdcampo
    Public ASL_idmarca As Cdatos.bdcampo
    Public ASL_idtipopalet As Cdatos.bdcampo
    Public ASL_categoria As Cdatos.bdcampo
    Public ASL_kilosbrutos As Cdatos.bdcampo
    Public ASL_kilosnetos As Cdatos.bdcampo
    Public ASL_kiloscliente As Cdatos.bdcampo
    Public ASL_palets As Cdatos.bdcampo
    Public ASL_bultos As Cdatos.bdcampo
    Public ASL_piezas As Cdatos.bdcampo
    Public ASL_precio As Cdatos.bdcampo
    Public ASL_tipoprecio As Cdatos.bdcampo
    Public ASL_importegenero As Cdatos.bdcampo
    Public ASL_bultosvendidos As Cdatos.bdcampo
    Public ASL_paletsvendidos As Cdatos.bdcampo
    Public ASL_kilosvendidos As Cdatos.bdcampo
    Public ASL_piezasvendidas As Cdatos.bdcampo
    Public ASL_precioventa As Cdatos.bdcampo
    Public ASL_tipopreciovta As Cdatos.bdcampo
    Public ASL_importegenerovta As Cdatos.bdcampo
    Public ASL_precioestimado As Cdatos.bdcampo
    Public ASL_observaciones As Cdatos.bdcampo
    Public ASL_idgensal As Cdatos.bdcampo
    Public ASL_importegeneroestimado As Cdatos.bdcampo
    Public ASL_estructura As Cdatos.bdcampo
    Public ASL_manipulacion As Cdatos.bdcampo
    Public ASL_materiales As Cdatos.bdcampo
    Public ASL_gastoF As Cdatos.bdcampo
    Public ASL_gastoC As Cdatos.bdcampo
    Public ASL_tipoprecioestimado As Cdatos.bdcampo
    Public ASL_GastoPorte As Cdatos.bdcampo
    Public ASL_CoeficientePalet As Cdatos.bdcampo

    Public ASL_IdUsuarioLog As Cdatos.bdcampo
    Public ASL_FechaLog As Cdatos.bdcampo
    Public ASL_HoraLog As Cdatos.bdcampo


    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub


    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "Albsalida_lineas"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            ASL_idlinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            ASL_idalbaran = New Cdatos.bdcampo(CodigoEntidad & "idalbaran", Cdatos.TiposCampo.EnteroPositivo, 6)
            ASL_idgenero = New Cdatos.bdcampo(CodigoEntidad & "idgenero", Cdatos.TiposCampo.EnteroPositivo, 5)
            ASL_idtipoconfeccion = New Cdatos.bdcampo(CodigoEntidad & "idtipoconfeccion", Cdatos.TiposCampo.EnteroPositivo, 5)
            ASL_idcategoria = New Cdatos.bdcampo(CodigoEntidad & "idcategoria", Cdatos.TiposCampo.EnteroPositivo, 5)
            ASL_idmarca = New Cdatos.bdcampo(CodigoEntidad & "idmarca", Cdatos.TiposCampo.EnteroPositivo, 5)
            ASL_idtipopalet = New Cdatos.bdcampo(CodigoEntidad & "idtipopalet", Cdatos.TiposCampo.EnteroPositivo, 5)
            ASL_categoria = New Cdatos.bdcampo(CodigoEntidad & "categoria", Cdatos.TiposCampo.Cadena, 50)
            ASL_kilosbrutos = New Cdatos.bdcampo(CodigoEntidad & "kilosbrutos", Cdatos.TiposCampo.Importe, 10, 2)
            ASL_kilosnetos = New Cdatos.bdcampo(CodigoEntidad & "kilosnetos", Cdatos.TiposCampo.Importe, 10, 2)
            ASL_kiloscliente = New Cdatos.bdcampo(CodigoEntidad & "kiloscliente", Cdatos.TiposCampo.Importe, 10, 2)
            ASL_palets = New Cdatos.bdcampo(CodigoEntidad & "palets", Cdatos.TiposCampo.Entero, 4)
            ASL_bultos = New Cdatos.bdcampo(CodigoEntidad & "bultos", Cdatos.TiposCampo.Entero, 4)
            ASL_piezas = New Cdatos.bdcampo(CodigoEntidad & "piezas", Cdatos.TiposCampo.Entero, 6)
            ASL_tipoprecio = New Cdatos.bdcampo(CodigoEntidad & "tipoprecio", Cdatos.TiposCampo.Cadena, 1)
            ASL_precio = New Cdatos.bdcampo(CodigoEntidad & "precio", Cdatos.TiposCampo.Importe, 10, 4)
            ASL_importegenero = New Cdatos.bdcampo(CodigoEntidad & "importegenero", Cdatos.TiposCampo.Importe, 12, 4)

            ASL_bultosvendidos = New Cdatos.bdcampo(CodigoEntidad & "bultosvendidos", Cdatos.TiposCampo.Entero, 10)
            ASL_paletsvendidos = New Cdatos.bdcampo(CodigoEntidad & "paletsvendidos", Cdatos.TiposCampo.Entero, 10)
            ASL_kilosvendidos = New Cdatos.bdcampo(CodigoEntidad & "kilosvendidos", Cdatos.TiposCampo.Importe, 10, 2)
            ASL_piezasvendidas = New Cdatos.bdcampo(CodigoEntidad & "piezasvendidas", Cdatos.TiposCampo.Entero, 10)
            ASL_precioventa = New Cdatos.bdcampo(CodigoEntidad & "precioventa", Cdatos.TiposCampo.Importe, 10, 4)
            ASL_tipopreciovta = New Cdatos.bdcampo(CodigoEntidad & "tipopreciovta", Cdatos.TiposCampo.Cadena, 1)
            ASL_importegenerovta = New Cdatos.bdcampo(CodigoEntidad & "importegenerovta", Cdatos.TiposCampo.Importe, 12, 4)
            ASL_precioestimado = New Cdatos.bdcampo(CodigoEntidad & "precioestimado", Cdatos.TiposCampo.Importe, 12, 4)
            ASL_observaciones = New Cdatos.bdcampo(CodigoEntidad & "observaciones", Cdatos.TiposCampo.Cadena, 250)
            ASL_idgensal = New Cdatos.bdcampo(CodigoEntidad & "idgensal", Cdatos.TiposCampo.EnteroPositivo, 5)
            ASL_importegeneroestimado = New Cdatos.bdcampo(CodigoEntidad & "importegeneroestimado", Cdatos.TiposCampo.Importe, 12, 4)
            ASL_estructura = New Cdatos.bdcampo(CodigoEntidad & "estructura", Cdatos.TiposCampo.Importe, 12, 4)
            ASL_manipulacion = New Cdatos.bdcampo(CodigoEntidad & "manipulacion", Cdatos.TiposCampo.Importe, 12, 4)
            ASL_materiales = New Cdatos.bdcampo(CodigoEntidad & "materiales", Cdatos.TiposCampo.Importe, 12, 4)
            ASL_gastoF = New Cdatos.bdcampo(CodigoEntidad & "gastof", Cdatos.TiposCampo.Importe, 12, 4)
            ASL_gastoC = New Cdatos.bdcampo(CodigoEntidad & "gastoc", Cdatos.TiposCampo.Importe, 12, 4)
            ASL_tipoprecioestimado = New Cdatos.bdcampo(CodigoEntidad & "tipoprecioestimado", Cdatos.TiposCampo.Cadena, 1)
            ASL_GastoPorte = New Cdatos.bdcampo(CodigoEntidad & "gastoporte", Cdatos.TiposCampo.Importe, 12, 4)
            ASL_CoeficientePalet = New Cdatos.bdcampo(CodigoEntidad & "CoeficientePalet", Cdatos.TiposCampo.Importe, 12, 4)

            ASL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            ASL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            ASL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)

            ' todos los gastos ya van calculados en euros

            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub

    Private Sub E_AlbSalida_lineas_ActualizaHijos(nuevo As Boolean) Handles Me.ActualizaHijos

    End Sub
   

    Private Sub E_AlbSalida_Lineas_EliminaHijos() Handles Me.EliminaHijos

        Dim AlbSalida_Lineas_Desglose As New E_AlbSalida_Lineas_Desglose(Idusuario, cn)

        Dim IdLineaAlbSalida As String = (Me.ASL_idlinea.Valor & "").Trim
        If VaInt(IdLineaAlbSalida) > 0 Then
            AlbSalida_Lineas_Desglose.BorrarDesgloseLinea(IdLineaAlbSalida)
        End If

    End Sub


    

End Class
