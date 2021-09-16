Public Class E_Pedidos_Clientes
    Inherits Cdatos.Entidad



    Public PCC_idlinea As Cdatos.bdcampo
    Public PCC_idcliente As Cdatos.bdcampo
    Public PCC_IdDomicilio As Cdatos.bdcampo
    Public PCC_IdGenero As Cdatos.bdcampo
    Public PCC_idgensal As Cdatos.bdcampo
    Public PCC_idcategoria As Cdatos.bdcampo
    Public PCC_nomcate As Cdatos.bdcampo
    Public PCC_idmarca As Cdatos.bdcampo
    Public PCC_idtipopalet As Cdatos.bdcampo
    Public PCC_palets As Cdatos.bdcampo
    Public PCC_bultospalet As Cdatos.bdcampo
    Public PCC_kilosbulto As Cdatos.bdcampo
    Public PCC_piezasbulto As Cdatos.bdcampo
    Public PCC_precio As Cdatos.bdcampo
    Public PCC_tipoprecio As Cdatos.bdcampo
    Public PCC_obslote As Cdatos.bdcampo
    Public PCC_obsconfec1 As Cdatos.bdcampo
    Public PCC_obsconfec2 As Cdatos.bdcampo
    Public PCC_obseti1 As Cdatos.bdcampo
    Public PCC_obseti2 As Cdatos.bdcampo
    Public PCC_generatrabajo As Cdatos.bdcampo
    Public PCC_requiereaprobacion As Cdatos.bdcampo
    Public PCC_idmarcaetiqueta As Cdatos.bdcampo
    Public PCC_idmarcamaterial As Cdatos.bdcampo
    Public PCC_calidad As Cdatos.bdcampo
    Public PCC_maxdias As Cdatos.bdcampo
    Public PCC_reservapalets As Cdatos.bdcampo
    Public PCC_activo As Cdatos.bdcampo
    Public PCC_FechaPedido As Cdatos.bdcampo

    Public PCC_IdUsuarioLog As Cdatos.bdcampo
    Public PCC_FechaLog As Cdatos.bdcampo
    Public PCC_HoraLog As Cdatos.bdcampo

    Dim err As Errores

    Public Sub New()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)


        Try
            NombreTabla = "Pedidos_Clientes"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            PCC_idlinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            PCC_idcliente = New Cdatos.bdcampo(CodigoEntidad & "idcliente", Cdatos.TiposCampo.EnteroPositivo, 6)
            PCC_IdDomicilio = New Cdatos.bdcampo(CodigoEntidad & "IdDomicilio", Cdatos.TiposCampo.Entero, 10)
            PCC_idgensal = New Cdatos.bdcampo(CodigoEntidad & "idgensal", Cdatos.TiposCampo.EnteroPositivo, 6)
            PCC_IdGenero = New Cdatos.bdcampo(CodigoEntidad & "IdGenero", Cdatos.TiposCampo.EnteroPositivo, 5)
            PCC_idcategoria = New Cdatos.bdcampo(CodigoEntidad & "idcategoria", Cdatos.TiposCampo.EnteroPositivo, 5)
            PCC_nomcate = New Cdatos.bdcampo(CodigoEntidad & "nomcate", Cdatos.TiposCampo.Cadena, 50)
            PCC_idmarca = New Cdatos.bdcampo(CodigoEntidad & "idmarca", Cdatos.TiposCampo.EnteroPositivo, 5)
            PCC_idtipopalet = New Cdatos.bdcampo(CodigoEntidad & "idtipopalet", Cdatos.TiposCampo.EnteroPositivo, 5)
            PCC_palets = New Cdatos.bdcampo(CodigoEntidad & "palets", Cdatos.TiposCampo.Importe, 6, 2)
            PCC_bultospalet = New Cdatos.bdcampo(CodigoEntidad & "bultospalet", Cdatos.TiposCampo.Entero, 4)
            PCC_kilosbulto = New Cdatos.bdcampo(CodigoEntidad & "kilosbulto", Cdatos.TiposCampo.Importe, 5, 2)
            PCC_piezasbulto = New Cdatos.bdcampo(CodigoEntidad & "piezasbulto", Cdatos.TiposCampo.Entero, 4)
            PCC_precio = New Cdatos.bdcampo(CodigoEntidad & "precio", Cdatos.TiposCampo.Importe, 6, 4)
            PCC_tipoprecio = New Cdatos.bdcampo(CodigoEntidad & "tipoprecio", Cdatos.TiposCampo.Cadena, 1)
            PCC_obslote = New Cdatos.bdcampo(CodigoEntidad & "obslote", Cdatos.TiposCampo.Cadena, 50)
            PCC_obsconfec1 = New Cdatos.bdcampo(CodigoEntidad & "obsconfec1", Cdatos.TiposCampo.Cadena, 50)
            PCC_obsconfec2 = New Cdatos.bdcampo(CodigoEntidad & "obsconfec2", Cdatos.TiposCampo.Cadena, 50)
            PCC_obseti1 = New Cdatos.bdcampo(CodigoEntidad & "obseti1", Cdatos.TiposCampo.Cadena, 50)
            PCC_obseti2 = New Cdatos.bdcampo(CodigoEntidad & "obseti2", Cdatos.TiposCampo.Cadena, 50)
            PCC_generatrabajo = New Cdatos.bdcampo(CodigoEntidad & "generatrabajo", Cdatos.TiposCampo.Cadena, 1)
            PCC_requiereaprobacion = New Cdatos.bdcampo(CodigoEntidad & "requiereaprobacion", Cdatos.TiposCampo.Cadena, 1)
            PCC_idmarcaetiqueta = New Cdatos.bdcampo(CodigoEntidad & "idmarcaetiqueta", Cdatos.TiposCampo.EnteroPositivo, 5)
            PCC_idmarcamaterial = New Cdatos.bdcampo(CodigoEntidad & "idmarcamaterial", Cdatos.TiposCampo.EnteroPositivo, 5)
            PCC_calidad = New Cdatos.bdcampo(CodigoEntidad & "calidad", Cdatos.TiposCampo.Cadena, 1)
            PCC_maxdias = New Cdatos.bdcampo(CodigoEntidad & "maxdias", Cdatos.TiposCampo.CadenaNumero, 1)
            PCC_reservapalets = New Cdatos.bdcampo(CodigoEntidad & "reservapalets", Cdatos.TiposCampo.Cadena, 1)
            PCC_activo = New Cdatos.bdcampo(CodigoEntidad & "activo", Cdatos.TiposCampo.Cadena, 1)
            PCC_FechaPedido = New Cdatos.bdcampo(CodigoEntidad & "fechapedido", Cdatos.TiposCampo.Fecha, 10)


            PCC_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PCC_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PCC_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)


            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub


    Public Sub InsertarLinea(IdCliente As Integer, IdDomicilio As Integer, IdLineaPedido As Integer, Fecha As String)

        Dim pedidos_lineas As New E_Pedidos_lineas(Idusuario, cn)
        If pedidos_lineas.LeerId(idlineapedido.ToString) = False Then Exit Sub
        Dim idlinea As Integer = 0
        Dim IdGenero As Integer = VaInt(pedidos_lineas.PEL_idgenero.Valor)
        Dim idgensal As Integer = VaInt(pedidos_lineas.PEL_idgensal.Valor)
        Dim idcategoria As Integer = VaInt(pedidos_lineas.PEL_idcategoria.Valor)
        Dim categoria As String = pedidos_lineas.PEL_nomcate.Valor
        Dim idtipopalet As Integer = VaInt(pedidos_lineas.PEL_idtipopalet.Valor)
        Dim idmarcaenvase As Integer = VaInt(pedidos_lineas.PEL_idmarca.Valor)
        Dim bxp As Integer = VaInt(pedidos_lineas.PEL_bultospalet.Valor)
        Dim kxb As Decimal = VaDec(pedidos_lineas.PEL_kilosbulto.Valor)
        Dim pzxb As Integer = VaInt(pedidos_lineas.PEL_piezasbulto.Valor)
        Dim idmarcaeti As Integer = VaInt(pedidos_lineas.PEL_idmarcaetiqueta.Valor)
        Dim idmarcamat As Integer = VaInt(pedidos_lineas.PEL_idmarcamaterial.Valor)

        idlinea = ExisteLinea(IdCliente, IdDomicilio, IdGenero, idgensal, idcategoria, categoria, idtipopalet, idmarcaenvase, bxp, kxb, pzxb, idmarcaeti, idmarcamat)

        If idlinea = 0 Then
            idlinea = Me.MaxId
            Me.VaciaEntidad()
            Me.PCC_idlinea.Valor = idlinea.ToString
            Me.PCC_idcliente.Valor = IdCliente.ToString
            Me.PCC_IdDomicilio.Valor = IdDomicilio.ToString
            Me.PCC_IdGenero.Valor = IdGenero.ToString
            Me.PCC_idgensal.Valor = idgensal.ToString
            Me.PCC_idcategoria.Valor = idcategoria.ToString
            Me.PCC_nomcate.Valor = categoria
            Me.PCC_idtipopalet.Valor = idtipopalet.ToString
            Me.PCC_idmarca.Valor = idmarcaenvase.ToString
            Me.PCC_idmarcaetiqueta.Valor = idmarcaeti.ToString
            Me.PCC_idmarcamaterial.Valor = idmarcamat.ToString
            Me.PCC_bultospalet.Valor = bxp.ToString
            Me.PCC_kilosbulto.Valor = kxb.ToString
            Me.PCC_piezasbulto.Valor = pzxb.ToString
            Me.PCC_tipoprecio.Valor = pedidos_lineas.PEL_tipoprecio.Valor
            Me.PCC_precio.Valor = pedidos_lineas.PEL_precio.Valor
            Me.PCC_obsconfec1.Valor = pedidos_lineas.PEL_obsconfec1.Valor
            Me.PCC_obsconfec2.Valor = pedidos_lineas.PEL_obsconfec2.Valor
            Me.PCC_obseti1.Valor = pedidos_lineas.PEL_obseti1.Valor
            Me.PCC_obseti2.Valor = pedidos_lineas.PEL_obseti2.Valor
            Me.PCC_obslote.Valor = pedidos_lineas.PEL_obslote.Valor
            Me.PCC_calidad.Valor = pedidos_lineas.PEL_calidad.Valor
            Me.PCC_generatrabajo.Valor = pedidos_lineas.PEL_generatrabajo.Valor
            Me.PCC_maxdias.Valor = pedidos_lineas.PEL_maxdias.Valor
            Me.PCC_requiereaprobacion.Valor = pedidos_lineas.PEL_requiereaprobacion.Valor
            Me.PCC_palets.Valor = pedidos_lineas.PEL_palets.Valor
            Me.PCC_activo.Valor = "S"
            Me.PCC_FechaPedido.Valor = Fecha
            Me.PCC_reservapalets.Valor = pedidos_lineas.PEL_reservapalets.Valor
            Me.Insertar()

        End If


    End Sub



    Private Function ExisteLinea(idcliente As Integer, IdDomicilio As Integer, IdGenero As Integer, idpresentacion As Integer, idcategoria As Integer, Categoria As String, idtipopalet As Integer, idmarcaenvase As Integer, Bxp As Integer, kxb As Decimal, pzxb As Integer, idmarcaetiqueta As Integer, idmarcamaterial As Integer) As Integer

        Dim ret As Integer


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Me.PCC_idlinea, "idlinea")
        consulta.WheCampo(Me.PCC_idcliente, "=", idcliente.ToString)
        consulta.WheCampo(Me.PCC_IdDomicilio, "=", IdDomicilio.ToString)
        consulta.WheCampo(Me.PCC_IdGenero, "=", IdGenero.ToString)
        consulta.WheCampo(Me.PCC_idgensal, "=", idpresentacion.ToString)
        consulta.WheCampo(Me.PCC_idcategoria, "=", idcategoria.ToString)
        consulta.WheCampo(Me.PCC_nomcate, "=", Categoria)
        consulta.WheCampo(Me.PCC_idtipopalet, "=", idtipopalet.ToString)
        consulta.WheCampo(Me.PCC_idmarca, "=", idmarcaenvase.ToString)
        consulta.WheCampo(Me.PCC_kilosbulto, "=", kxb.ToString)
        consulta.WheCampo(Me.PCC_idmarcaetiqueta, "=", idmarcaetiqueta.ToString)
        consulta.WheCampo(Me.PCC_idmarcamaterial, "=", idmarcamaterial.ToString)

        Dim sql As String = consulta.SQL

        Dim dt As DataTable = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = VaInt(dt.Rows(0)("idlinea"))
            End If
        End If



        Return ret

    End Function


End Class
