Public Class E_palets_lineas
    Inherits Cdatos.Entidad

    Public PLL_idlinea As Cdatos.bdcampo
    Public PLL_idpalet As Cdatos.bdcampo
    Public PLL_idgenero As Cdatos.bdcampo
    Public PLL_idtipoconfeccion As Cdatos.bdcampo
    Public PLL_idenvase As Cdatos.bdcampo
    Public PLL_idcategoria As Cdatos.bdcampo
    Public PLL_categoria As Cdatos.bdcampo
    Public PLL_idmarca As Cdatos.bdcampo
    Public PLL_kilosbrutos As Cdatos.bdcampo
    Public PLL_kilosnetos As Cdatos.bdcampo
    Public PLL_bultos As Cdatos.bdcampo
    Public PLL_piezasxbulto As Cdatos.bdcampo
    Public PLL_kilosxbulto As Cdatos.bdcampo
    Public PLL_kiloscliente As Cdatos.bdcampo
    Public PLL_costeconfeccion As Cdatos.bdcampo
    Public PLL_costeestructura As Cdatos.bdcampo
    Public PLL_idsituacion As Cdatos.bdcampo
    Public PLL_costematerial As Cdatos.bdcampo
    Public PLL_idlineaentradaconfeccionada As Cdatos.bdcampo
    Public PLL_idgensal As Cdatos.bdcampo
    Public PLL_observaciones As Cdatos.bdcampo
    Public PLL_idpedidolinea As Cdatos.bdcampo
    Public PLL_calidad As Cdatos.bdcampo
    Public PLL_idmarcaeti As Cdatos.bdcampo
    Public PLL_idmarcamat As Cdatos.bdcampo
    Public PLL_TipoReserva As Cdatos.bdcampo
    Public PLL_Controlado As Cdatos.bdcampo
    Public PLL_CoeficientePalet As Cdatos.bdcampo
    Public PLL_Merma As Cdatos.bdcampo
    Public PLL_IdLineaSalida As Cdatos.bdcampo

    Public PLL_IdCliente As Cdatos.bdcampo


    Public PLL_IdUsuarioLog As Cdatos.bdcampo
    Public PLL_FechaLog As Cdatos.bdcampo
    Public PLL_HoraLog As Cdatos.bdcampo



    Dim err As Errores
    Public Sub New()
        'MyBase.new()
        Me.New(0, Nothing)
    End Sub

    Public Sub New(ByVal idUsuario As Integer, ByVal conexion As Cdatos.Conexion)
        MyBase.New(idUsuario)

        Try
            NombreTabla = "palets_lineas"
            MiConexion = conexion
            NombreBd = "NetAgroComer"

            'Si no existe, que pete. Podemos comprobar si hay alguna tabla sin código desde el formulario de LogTablas, PERO SOLO DE NETAGRO
            If DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim).Trim <> "" Then CodigoEntidad = DcCodigosEntidad(Me.NombreTabla.ToUpper.Trim) & "_"


            PLL_idlinea = New Cdatos.bdcampo(CodigoEntidad & "idlinea", Cdatos.TiposCampo.EnteroPositivo, 6, 0, True)
            PLL_idpalet = New Cdatos.bdcampo(CodigoEntidad & "idpalet", Cdatos.TiposCampo.EnteroPositivo, 6)
            PLL_idgenero = New Cdatos.bdcampo(CodigoEntidad & "idgenero", Cdatos.TiposCampo.EnteroPositivo, 5)
            PLL_idtipoconfeccion = New Cdatos.bdcampo(CodigoEntidad & "idtipoconfeccion", Cdatos.TiposCampo.EnteroPositivo, 5)
            PLL_idenvase = New Cdatos.bdcampo(CodigoEntidad & "idenvase", Cdatos.TiposCampo.EnteroPositivo, 5)
            PLL_idcategoria = New Cdatos.bdcampo(CodigoEntidad & "idcategoria", Cdatos.TiposCampo.EnteroPositivo, 5)
            PLL_idmarca = New Cdatos.bdcampo(CodigoEntidad & "idmarca", Cdatos.TiposCampo.EnteroPositivo, 5)
            PLL_categoria = New Cdatos.bdcampo(CodigoEntidad & "categoria", Cdatos.TiposCampo.Cadena, 50)
            PLL_kilosbrutos = New Cdatos.bdcampo(CodigoEntidad & "kilosbrutos", Cdatos.TiposCampo.Importe, 12, 2)
            PLL_kilosxbulto = New Cdatos.bdcampo(CodigoEntidad & "kilosxbulto", Cdatos.TiposCampo.Importe, 6, 2)
            PLL_kilosnetos = New Cdatos.bdcampo(CodigoEntidad & "kilosnetos", Cdatos.TiposCampo.Importe, 12, 2)
            PLL_kiloscliente = New Cdatos.bdcampo(CodigoEntidad & "kiloscliente", Cdatos.TiposCampo.Importe, 12, 2)
            PLL_bultos = New Cdatos.bdcampo(CodigoEntidad & "bultos", Cdatos.TiposCampo.Entero, 4)
            PLL_piezasxbulto = New Cdatos.bdcampo(CodigoEntidad & "piezasxbulto", Cdatos.TiposCampo.Entero, 6)
            PLL_costeconfeccion = New Cdatos.bdcampo(CodigoEntidad & "costeconfeccion", Cdatos.TiposCampo.Importe, 12, 2)
            PLL_costeestructura = New Cdatos.bdcampo(CodigoEntidad & "costeestructura", Cdatos.TiposCampo.Importe, 12, 2)
            PLL_costematerial = New Cdatos.bdcampo(CodigoEntidad & "costematerial", Cdatos.TiposCampo.Importe, 12, 2)
            PLL_idsituacion = New Cdatos.bdcampo(CodigoEntidad & "idsituacion", Cdatos.TiposCampo.EnteroPositivo, 5)
            PLL_idlineaentradaconfeccionada = New Cdatos.bdcampo(CodigoEntidad & "idlineaentradaconfeccionada", Cdatos.TiposCampo.EnteroPositivo, 10)
            PLL_idgensal = New Cdatos.bdcampo(CodigoEntidad & "idgensal", Cdatos.TiposCampo.EnteroPositivo, 10)
            PLL_observaciones = New Cdatos.bdcampo(CodigoEntidad & "observaciones", Cdatos.TiposCampo.Cadena, 30)
            PLL_idpedidolinea = New Cdatos.bdcampo(CodigoEntidad & "idpedidolinea", Cdatos.TiposCampo.EnteroPositivo, 10)
            PLL_calidad = New Cdatos.bdcampo(CodigoEntidad & "calidad", Cdatos.TiposCampo.Cadena, 1)
            PLL_idmarcaeti = New Cdatos.bdcampo(CodigoEntidad & "idmarcaeti", Cdatos.TiposCampo.EnteroPositivo, 5)
            PLL_idmarcamat = New Cdatos.bdcampo(CodigoEntidad & "idmarcamat", Cdatos.TiposCampo.EnteroPositivo, 5)
            PLL_TipoReserva = New Cdatos.bdcampo(CodigoEntidad & "TipoReserva", Cdatos.TiposCampo.Cadena, 1)
            PLL_Controlado = New Cdatos.bdcampo(CodigoEntidad & "Controlado", Cdatos.TiposCampo.Cadena, 1)
            PLL_CoeficientePalet = New Cdatos.bdcampo(CodigoEntidad & "CoeficientePalet", Cdatos.TiposCampo.Importe, 10, 4)
            PLL_Merma = New Cdatos.bdcampo(CodigoEntidad & "Merma", Cdatos.TiposCampo.Importe, 10, 4)
            PLL_IdLineaSalida = New Cdatos.bdcampo(CodigoEntidad & "IdLineaSalida", Cdatos.TiposCampo.EnteroPositivo, 6)

            PLL_IdCliente = New Cdatos.bdcampo(CodigoEntidad & "IdCliente", Cdatos.TiposCampo.EnteroPositivo, 5)


            PLL_IdUsuarioLog = New Cdatos.bdcampo(CodigoEntidad & "IdUsuarioLog", Cdatos.TiposCampo.EnteroPositivo, 4)
            PLL_FechaLog = New Cdatos.bdcampo(CodigoEntidad & "FechaLog", Cdatos.TiposCampo.Fecha, 15)
            PLL_HoraLog = New Cdatos.bdcampo(CodigoEntidad & "HoraLog", Cdatos.TiposCampo.Cadena, 8)



            MiListadeCampos = ListadeCampos()

        Catch ex As Exception
            err.Muestraerror("Error cuando se inicializo la clase", "New", ex.Message)
        End Try


    End Sub

    Private Sub E_palets_lineas_ActualizaHijos(ByVal nuevo As Boolean) Handles Me.ActualizaHijos

    End Sub


    Private Sub E_palets_lineas_EliminaHijos() Handles Me.EliminaHijos

        Dim sql As String
        Dim dt As New DataTable
        Dim palets_traza As New E_palets_traza(Idusuario, cn)

        sql = "select * from palets_traza where PLT_idlineapalet=" + Me.PLL_idlinea.Valor

        dt = Me.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw As DataRow In dt.Rows
                palets_traza.CargaCampos(rw)
                palets_traza.Eliminar()
            Next
        End If




    End Sub



    Public Sub CoeficientePalet(Idpalet As String)

        Dim consulta2 As New Cdatos.E_select
        consulta2.SelCampo(Me.PLL_idlinea, "idlinea")
        consulta2.SelCampo(Me.PLL_bultos, "bultos")
        consulta2.WheCampo(Me.PLL_idpalet, "=", Idpalet)

        Dim sql2 As String = consulta2.SQL
        Dim dt2 As DataTable = Me.MiConexion.ConsultaSQL(sql2)
        If Not dt2 Is Nothing Then


            Dim maxLinea As Decimal = 0
            Dim totalC As Decimal = 0
            Dim auxIdLinea As Integer = 0

            Dim tb As Integer = 0
            Dim lista As New Dictionary(Of String, Integer)

            For Each rw2 In dt2.Rows
                tb = tb + VaInt(rw2("bultos"))
                lista.Add(rw2("idlinea").ToString, VaInt(rw2("bultos")))
            Next

            For Each idlinea As String In lista.Keys
                If tb <> 0 Then

                    Dim C As Decimal = VaDec(lista(idlinea)) / tb
                    C = Math.Round(C, 4)

                    totalC = totalC + C

                    If C > maxLinea Then
                        maxLinea = C
                        auxIdLinea = idlinea
                    End If

                    If Me.LeerId(idlinea) = True Then
                        If VaDec(Me.PLL_CoeficientePalet.Valor) <> C Then
                            Me.PLL_CoeficientePalet.Valor = C.ToString
                            Me.Actualizar()
                        End If
                    End If



                End If

            Next


            If totalC <> 1 Then
                Me.LeerId(auxIdLinea)
                Me.PLL_CoeficientePalet.Valor = VaDec(Me.PLL_CoeficientePalet.Valor) + 1 - totalC
                Me.Actualizar()
            End If

        End If

    End Sub



End Class
