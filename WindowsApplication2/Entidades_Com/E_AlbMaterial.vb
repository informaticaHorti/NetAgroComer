Public Class E_AlbMaterial
    Inherits Cdatos.Entidad

    Public AMA_Idalb As Cdatos.bdcampo
    Public AMA_Campa As Cdatos.bdcampo
    Public AMA_Idcentro As Cdatos.bdcampo
    Public AMA_Numero As Cdatos.bdcampo
    Public AMA_Fecha As Cdatos.bdcampo
    Public AMA_Idacreedor As Cdatos.bdcampo
    Public AMA_referencia As Cdatos.bdcampo
    Public AMA_observaciones As Cdatos.bdcampo
    Public AMA_importe As Cdatos.bdcampo
    Public AMA_idfactura As Cdatos.bdcampo
    Public AMA_idpuntoventa As Cdatos.bdcampo
    Public AMA_idvaleenvase As Cdatos.bdcampo

    Public AMA_IdUsuarioLog As Cdatos.bdcampo
    Public AMA_FechaLog As Cdatos.bdcampo
    Public AMA_HoraLog As Cdatos.bdcampo


    Private ValeEnvases As New E_ValeEnvases(Idusuario, cn)
    Private ValeEnvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)

    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "albMaterial"
            NombreBd = "NetAgroComer"
            MiConexion = conexion

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"

            AMA_Idalb = New Cdatos.bdcampo(CodigoEntidad & "idalb", Cdatos.TiposCampo.Entero, 8, 0, True)
            AMA_Campa = New Cdatos.bdcampo(CodigoEntidad & "campa", Cdatos.TiposCampo.Entero, 2)
            AMA_Idcentro = New Cdatos.bdcampo(CodigoEntidad & "idcentro", Cdatos.TiposCampo.Entero, 3)
            AMA_Numero = New Cdatos.bdcampo(CodigoEntidad & "numero", Cdatos.TiposCampo.Entero, 8)
            AMA_Fecha = New Cdatos.bdcampo(CodigoEntidad & "fecha", Cdatos.TiposCampo.Fecha, 10)
            AMA_Idacreedor = New Cdatos.bdcampo(CodigoEntidad & "idacreedor", Cdatos.TiposCampo.Entero, 5)
            AMA_referencia = New Cdatos.bdcampo(CodigoEntidad & "referencia", Cdatos.TiposCampo.Cadena, 25)
            AMA_observaciones = New Cdatos.bdcampo(CodigoEntidad & "observaciones", Cdatos.TiposCampo.Cadena, 50)
            AMA_importe = New Cdatos.bdcampo(CodigoEntidad & "importe", Cdatos.TiposCampo.Importe, 12, 2)
            AMA_idfactura = New Cdatos.bdcampo(CodigoEntidad & "idfactura", Cdatos.TiposCampo.Entero, 10)
            AMA_idpuntoventa = New Cdatos.bdcampo(CodigoEntidad & "idpuntoventa", Cdatos.TiposCampo.Entero, 10)
            AMA_idvaleenvase = New Cdatos.bdcampo(CodigoEntidad & "idvaleenvase", Cdatos.TiposCampo.Entero, 10)

            AMA_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            AMA_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            AMA_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()



            'Campos que forman el número del documento
            _lstCamposDocumento.Add(Me.AMA_Numero)


        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


        Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))
        Dim Acreedores As New E_Acreedores(idUsuario, cn)
        Dim FacturasRecibidas As New E_Facturasrecibidas(idUsuario, cn)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.AMA_Idalb, "Idalb")
        consulta.SelCampo(Me.AMA_Campa, "Campa")
        consulta.SelCampo(Me.AMA_Idcentro, "IdCentro")
        consulta.SelCampo(Centros.Nombre, "Centro", Me.AMA_Idcentro)
        consulta.SelCampo(Me.AMA_Numero, "Numero")
        consulta.SelCampo(Me.AMA_Fecha, "Fecha")
        consulta.SelCampo(Me.AMA_Idacreedor, "Codigo")
        consulta.SelCampo(Acreedores.ACR_Nombre, "Nombre", Me.AMA_Idacreedor)
        consulta.SelCampo(Me.AMA_referencia, "Referencia")
        consulta.SelCampo(Me.AMA_importe, "Importe")
        consulta.SelCampo(FacturasRecibidas.FRR_numerofactura, "Factura", Me.AMA_idfactura)
        _btBusca.Params("IdCentro", , -1)
        _btBusca.Params("Idalb", , -1)

        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_CampoOrden = "Fecha"
        '_btBusca.CL_ConsultaSql = "Select VEV_Idvale as IdVale, VEV_operacion as Operacion, VEV_codigo as Codigo, VEV_campa as Campa, VEV_idcentro as IdCentro, VEV_numero as Numero, VEV_fecha as Fecha from Valeenvases"
        _btBusca.CL_ConsultaSql = consulta.SQL
        _btBusca.CL_ControlAsociado = Nothing
        _btBusca.CL_DevuelveCampo = "Idalb"
        _btBusca.CL_Entidad = Me
        _btBusca.CL_Filtro = Nothing
        _btBusca.Name = "BtBuscaAlbMaterial"
        _btBusca.CL_ch1000 = False


        _btBusca.CL_BuscaAlb = True ' busqueda por codigo
        _btBusca.CL_campocodigo = Acreedores.ACR_Codigo
        _btBusca.CL_camponombre = Acreedores.ACR_Nombre
        _btBusca.CL_dfecha = MiMaletin.FechaInicioEjercicio
        _btBusca.CL_hfecha = MiMaletin.FechaFinEjercicio


    End Sub

    Public Function LeerAlb(ByVal Campa As Integer, ByVal Centro As Integer, ByVal albaran As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.AMA_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.AMA_Idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.AMA_Numero, "=", albaran.ToString)

        Dt = Me.MiConexion.ConsultaSQL(CONSULTA.SQL)
        If Not Dt Is Nothing Then
            If Dt.Rows.Count > 0 Then
                If Dt.Rows(0)(0) IsNot DBNull.Value Then
                    ret = Dt.Rows(0)(0)
                    CargaCampos(Dt.Rows(0))
                End If
            End If
        End If
        Return ret
    End Function


    Public Function ExisteAlb(ByVal Campa As Integer, ByVal Centro As Integer, ByVal albaran As Integer) As Integer

        Dim CONSULTA As New Cdatos.E_select
        Dim Dt As New DataTable
        Dim ret As Integer = 0



        CONSULTA.SelTodos(Me)

        CONSULTA.WheCampo(Me.AMA_Campa, "=", Campa.ToString)
        If ContadorxCentro = True Then
            CONSULTA.WheCampo(Me.AMA_Idcentro, "=", Centro.ToString)
        End If
        CONSULTA.WheCampo(Me.AMA_Numero, "=", albaran.ToString)

        Dt = Me.MiConexion.ConsultaSQL(CONSULTA.SQL)
        If Not Dt Is Nothing Then
            If Dt.Rows.Count > 0 Then
                If Dt.Rows(0)(0) IsNot DBNull.Value Then
                    ret = Dt.Rows(0)(0)
                End If
            End If
        End If
        Return ret
    End Function


    Public Function MaxIdCampa(ByVal Campa As Integer, ByVal Centro As Integer, Optional ByVal vmax As Integer = 0) As Integer
        Try
            Dim max As Integer = 0
            Dim existe As Integer = -1

            While existe <> 0
                If ContadorxCentro = True Then
                    max = ValorMaximo(Campa.ToString + "_" + Centro.ToString, vmax)
                Else
                    max = ValorMaximo(Campa.ToString, vmax)

                End If
                existe = ExisteAlb(Campa, Centro, max)
            End While

            Return max
        Catch ex As Exception
            err.Muestraerror("Error cuando se intentaba obtener el ultimo id de albaranes", "Function MaxIdcampa", ex.Message)
            Return 0
        End Try


    End Function


    Private Sub E_Almmaterial_EliminaHijos() Handles Me.EliminaHijos
        Dim sql As String
        sql = "Delete from albmateriallineas where AML_idalb = " + Me.AMA_Idalb.Valor
        MiConexion.OrdenSql(sql)


        If VaInt(Me.AMA_idvaleenvase.Valor) > 0 Then
            If ValeEnvases.LeerId(Me.AMA_idvaleenvase.Valor) = True Then
                ValeEnvases.Eliminar()
            End If
        End If

    End Sub



    Public Sub CrearValeEnvasesMaterial(ByVal Nalbaran As String)

        Dim sql As String
        Dim dt As New DataTable
        Dim Albmaterial_lineas As New E_AlbMaterialLineas(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)
        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
        Dim ValeEnvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
        Dim ConsultaB As New Cdatos.E_select
        Dim x As Integer = 0
        Dim Operacion As String = "AC"
        Dim IdVale As Integer = 0



        If Me.LeerId(Nalbaran) = True Then

            IdVale = VaInt(Me.AMA_idvaleenvase.Valor)
            If IdVale > 0 Then
                
                'Borra sólo las líneas automáticas
                Dim VEL As New E_ValeEnvases_Lineas(Idusuario, cn)

                Dim sqlL As String = "SELECT VEL_Id FROM ValeEnvases_Lineas WHERE VEL_IdVale = " & IdVale & " AND VEL_Automatica = 'S'"
                Dim dtL As DataTable = ValeEnvases_lineas.MiConexion.ConsultaSQL(sqlL)
                If Not IsNothing(dtL) Then
                    For Each rowL As DataRow In dtL.Rows
                        If VEL.LeerId(rowL("VEL_Id")) Then
                            VEL.Eliminar()
                        End If
                    Next
                End If

            End If



            Dim Precio As Double = 0

            sql = "Select AML_idmaterial as idenvase,AML_idmarca as idmarca, AML_cantidad as uds, AML_precio as precio,AML_descuento as descuento from albmateriallineas where AML_idalb=" + Nalbaran
            dt = Me.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                For Each rw As DataRow In dt.Rows
                    If Envases.LeerId(rw("idenvase")) = True Then
                        If rw("uds") <> 0 Then
                            IdVale = CrearCabeceraEnvases(Operacion, IdVale)
                            Precio = VaDec(rw("precio")) - VaDec(rw("precio")) * VaDec(rw("descuento")) / 100
                            CreaLineaEnvases(IdVale, rw("idenvase"), rw("uds").ToString, Precio.ToString, rw("idmarca").ToString)
                        End If
                    End If

                Next
            End If


            Me.AMA_idvaleenvase.Valor = IdVale
            Me.Actualizar()
        End If


    End Sub

    Private Sub CreaLineaEnvases(ByVal idvale As Integer, ByVal idenvase As Integer, ByVal uds As String, ByVal Precio As String, ByVal idmarca As String)
        Dim idLinea As Integer = 0

        ValeEnvases_lineas.VaciaEntidad()
        idLinea = ValeEnvases_lineas.MaxId
        ValeEnvases_lineas.VEL_Id.Valor = idLinea.ToString
        ValeEnvases_lineas.VEL_idvale.Valor = idvale.ToString
        ValeEnvases_lineas.VEL_idenvase.Valor = idenvase
        ValeEnvases_lineas.VEL_retira.Valor = "0"
        ValeEnvases_lineas.VEL_entrega.Valor = uds
        ValeEnvases_lineas.VEL_precioretira.Valor = 0
        ValeEnvases_lineas.VEL_precioentrega.Valor = Precio
        ValeEnvases_lineas.VEL_idmarca.Valor = idmarca
        ValeEnvases_lineas.VEL_idalmacen.Valor = Me.AMA_idpuntoventa.Valor
        ValeEnvases_lineas.VEL_Automatica.Valor = "S"
        ValeEnvases_lineas.Insertar()

    End Sub


    Private Function CrearCabeceraEnvases(ByVal Operacion As String, IdVale As Integer) As Integer

        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)

        Dim bNuevo As Boolean = (IdVale = 0)


        If bNuevo Then
            IdVale = ValeEnvases.MaxId
        ElseIf Not ValeEnvases.LeerId(IdVale) Then
            bNuevo = True
        End If

        ValeEnvases.VEV_Idvale.Valor = IdVale.ToString
        ValeEnvases.VEV_Operacion.Valor = Operacion
        ValeEnvases.VEV_Campa.Valor = Me.AMA_Campa.Valor
        ValeEnvases.VEV_Idcentro.Valor = Me.AMA_Idcentro.Valor
        ValeEnvases.VEV_Numero.Valor = Me.AMA_Numero.Valor
        ValeEnvases.VEV_Fecha.Valor = Me.AMA_Fecha.Valor
        ValeEnvases.VEV_IdAlmacen.Valor = Me.AMA_idpuntoventa.Valor
        ValeEnvases.VEV_IdConcepto.Valor = "0"
        ValeEnvases.VEV_Concepto.Valor = "ALBARAN COMPRA " + Me.AMA_Numero.Valor
        ValeEnvases.VEV_TipoSujeto.Valor = "R"
        ValeEnvases.VEV_Codigo.Valor = Me.AMA_Idacreedor.Valor
        ValeEnvases.VEV_Referencia.Valor = Me.AMA_referencia.Valor


        If bNuevo Then
            ValeEnvases.Insertar()
        Else
            ValeEnvases.Actualizar()
        End If


        Return IdVale

    End Function



End Class
