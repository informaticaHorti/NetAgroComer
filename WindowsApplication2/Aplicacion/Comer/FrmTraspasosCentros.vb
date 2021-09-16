Imports DevExpress.XtraEditors


Public Class FrmTraspasosCentros
    Inherits FrMantenimiento


    Private Class stClave_LineasVale

        Public IdEnvase As Integer = 0
        Public IdMarca As Integer = 0

        Public Sub New(IdEnvase As Integer, IdMarca As Integer)
            Me.IdEnvase = IdEnvase
            Me.IdMarca = IdMarca
        End Sub

    End Class


    Private Class stDatos_LineasVale

        Public Cantidad As Decimal = 0

        Public Sub New(Cantidad As Decimal)
            Me.Cantidad = Cantidad
        End Sub

    End Class



    Private TraspasosCentros As New E_TraspasosCentros(Idusuario, cn)
    Private TraspasosCentros_Lineas As New E_TraspasosCentros_Lineas(Idusuario, cn)
    Private AlbEntrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
    Private Lotes As New E_Lotes(Idusuario, cn)
    Private LotesProduccion As New E_LotesProduccion(Idusuario, cn)
    Private Palets As New E_palets(Idusuario, cn)
    '  Private Centros As New E_centros(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Private Puntoventa As New E_PuntoVenta(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))

    Private Acreedores As New E_Acreedores(Idusuario, cn)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub



    Private Sub ParametrosFrm()
        EntidadFrm = TraspasosCentros


        Dim lc As New List(Of Object)
        ListaControles = lc



        CampoClave = 0 ' ultimo campo de la clave

        ParamTx(TxNumero, TraspasosCentros.TCE_Numero, LbNumero, True)
        TxNumero.Autonumerico = True
        ParamTx(TxFecha, TraspasosCentros.TCE_Fecha, LbFecha, True)
        ParamTx(TxCentroOrigen, TraspasosCentros.TCE_IdCentroOrigen, LbCentroOrigen, True)
        ParamTx(TxCentroDestino, TraspasosCentros.TCE_IdCentroDestino, LbCentroDestino, True)
        ParamTx(TxTransportista, TraspasosCentros.TCE_IdTransportista, LbTransportista)
        ParamTx(TxMatricula, TraspasosCentros.TCE_Matricula, LbMatricula)
        ParamTx(TxTractora, TraspasosCentros.TCE_Tractora, LbTractora)
        ParamTx(TxObservaciones, TraspasosCentros.TCE_Observaciones, LbObservaciones)

        'ParamTx(TxTipo, TraspasosCentros_Lineas.TLI_Tipo, LbTipo, True, , , , "PLTC")
        ParamTx(TxTipo, TraspasosCentros_Lineas.TLI_Tipo, LbTipo, True, , , 20, "PALETSC.0123456789")
        'ParamTx(TxCodigo, AlbEntrada_lineas.AEL_muestreo, LbTipo, True)
        ParamTx(TxCodigo, AlbEntrada_lineas.AEL_muestreo, LbTipo, True, , , 20, "PALETSC.0123456789")


        AsociarControles(TxNumero, BtBuscaTraspaso, TraspasosCentros.btBusca, TraspasosCentros)
        AsociarControles(TxCentroOrigen, BtBuscaCentroOrigen, Puntoventa.btBusca, Puntoventa, Puntoventa.Nombre, LbNomCentroOrigen)
        AsociarControles(TxCentroDestino, BtBuscaCentroDestino, Puntoventa.btBusca, Puntoventa, Puntoventa.Nombre, LbNomCentroDestino)
        AsociarControles(TxTransportista, BtBuscaTransportista, Acreedores.BtBuscaXtipo, Acreedores, Acreedores.ACR_Nombre, LbNomTransportista)
        BtBuscaTransportista.CL_Filtro = "TIPO='PO'"


        AsociarGrid(ClGrid1, TxTipo, TxCodigo, TraspasosCentros_Lineas)

        PropiedadesCamposGr(ClGrid1, "TLI_IdLinea", "TLI_IdLinea", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, "Tipo", "Tipo", True, 60)
        PropiedadesCamposGr(ClGrid1, "Numero", "Numero", True, 90)
        PropiedadesCamposGr(ClGrid1, "Producto", "Producto", True, 150)
        PropiedadesCamposGr(ClGrid1, "KilosNetos", "KilosNetos", True, 100, True, "#,##0", "{0:n0}")


        tt.SetToolTip(BtNuevo, "Nuevo")

        FiltroEntidad.Add(TraspasosCentros.TCE_Ejercicio.NombreCampo, MiMaletin.Ejercicio.ToString)

    End Sub


    Private Sub FrmPedidos_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BTaux1.Visible = True
        BTaux1.Text = "Imprimir"
        BTaux1.Image = PictureBox1.Image

        BtAux2.Visible = True
        BtAux2.Text = "I.Directa"
        BtAux2.Image = PictureBox2.Image

    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave

        Dim i As Integer
        If TxNumero.Text = "+" Then
            LbId.Text = "+"
        Else
            i = TraspasosCentros.LeerTraspaso(Lbejer.Text, TxNumero.Text)
            If i > 0 Then
                LbId.Text = i.ToString

            Else
                If MsgBox("Registro inexistente. Desea crear uno nuevo", vbYesNo) = vbYes Then
                    LbId.Text = "+"
                Else
                    LbId.Text = ""
                End If

            End If

        End If

        If LbId.Text <> "" Then
            CargaLineasGrid()
        End If

    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()


        Lbejer.Text = TraspasosCentros.TCE_Ejercicio.Valor


        ' llenar el grid
        CargaLineasGrid()


        If VaDate(TraspasosCentros.TCE_FechaDescarga.Valor) > VaDate("") Then
            btAnularRecepcion.Visible = True
        Else
            btAnularRecepcion.Visible = False
        End If

    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)


        Dim Producto As String = ""
        Dim Numero As String = ""
        Dim idUbicacion As String = ""

        Dim Codigo As String = (TraspasosCentros_Lineas.TLI_Codigo.Valor & "").ToUpper.Trim
        Dim Tipo As String = (TraspasosCentros_Lineas.TLI_Tipo.Valor & "").ToUpper.Trim

        ObtenerProducto(Tipo, Codigo, Producto, Numero, idUbicacion)

        TxCodigo.Text = Numero
        LbNomProducto.Text = Producto

    End Sub


    Private Sub ObtenerProducto(Tipo As String, Codigo As String, ByRef Producto As String, ByRef Numero As String, ByRef IdUbicacion As String)

        Producto = ""
        Numero = ""


        Select Case Tipo

            Case "P"
                'Partidas
                Dim sql As String = "SELECT GEN_NombreGenero as Genero, AEL_Muestreo as Partida, AEL_IdUbicacionPV as IdUbicacion" & vbCrLf
                sql = sql & " FROM AlbEntrada_Lineas" & vbCrLf
                sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = AEL_IdGenero" & vbCrLf
                sql = sql & " WHERE AEL_IdLinea = " & Codigo & vbCrLf
                Dim dt As DataTable = TraspasosCentros.MiConexion.ConsultaSQL(sql)
                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 0 Then
                        Producto = dt.Rows(0)("Genero").ToString
                        Numero = dt.Rows(0)("Partida").ToString
                        IdUbicacion = dt.Rows(0)("IdUbicacion").ToString
                    End If
                End If

            Case "L"
                'Lotes
                Dim sql As String = "SELECT GEN_NombreGenero as Genero, LTE_Lote as Lote, LTE_IdUbicacionPV as IdUbicacion" & vbCrLf
                sql = sql & " FROM Lotes" & vbCrLf
                sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = LTE_IdGenero" & vbCrLf
                sql = sql & " WHERE LTE_IdLote = " & Codigo & vbCrLf
                Dim dt As DataTable = TraspasosCentros.MiConexion.ConsultaSQL(sql)
                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 0 Then
                        Producto = dt.Rows(0)("Genero").ToString
                        Numero = dt.Rows(0)("Lote").ToString
                        IdUbicacion = dt.Rows(0)("IdUbicacion").ToString
                    End If
                End If

            Case "T"
                'Palets
                'Dim sql As String = "SELECT GEN_NombreGenero as Genero, Palet" & vbCrLf
                'sql = sql & " FROM (" & vbCrLf
                'sql = sql & " SELECT (SELECT TOP 1 PLL_IdGenero FROM Palets_Lineas WHERE PLL_IdPalet = PAL_IdPalet) as IdGenero, PAL_Palet as Palet, PAL_IdPVSituacion as IdUbicacion" & vbCrLf
                'sql = sql & " FROM TraspasosCentros_Lineas" & vbCrLf
                'sql = sql & " LEFT JOIN Palets ON TLI_Codigo = PAL_IdPalet" & vbCrLf
                'sql = sql & " WHERE PAL_IdPalet = " & Codigo & vbCrLf
                'sql = sql & " ) as T" & vbCrLf
                'sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = T.IdGenero" & vbCrLf

                Dim sql As String = "SELECT TOP 1 PLL_IdGenero as IdGenero, GEN_NombreGenero as Genero, PAL_Palet as Palet, PAL_IdPVSituacion as IdUbicacion" & vbCrLf
                sql = sql & " FROM Palets_Lineas" & vbCrLf
                sql = sql & " LEFT JOIN Palets ON PLL_IdPalet = PAL_IdPalet" & vbCrLf
                sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = PLL_IdGenero" & vbCrLf
                sql = sql & " WHERE PAL_IdPalet = " & Codigo & vbCrLf

                Dim dt As DataTable = TraspasosCentros.MiConexion.ConsultaSQL(sql)
                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 0 Then
                        Producto = dt.Rows(0)("Genero").ToString
                        Numero = dt.Rows(0)("Palet").ToString
                        IdUbicacion = dt.Rows(0)("IdUbicacion").ToString
                    End If
                End If


            Case "C"
                'Precalibrado
                Dim sql As String = "SELECT GEN_NombreGenero as Genero, LPD_Lote as Lote, LPD_IdUbicacionPV as IdUbicacion" & vbCrLf
                sql = sql & " FROM LotesProduccion" & vbCrLf
                sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = LPD_IdGenero" & vbCrLf
                sql = sql & " WHERE LPD_IdLote = " & Codigo & vbCrLf
                Dim dt As DataTable = TraspasosCentros.MiConexion.ConsultaSQL(sql)
                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 0 Then
                        Producto = dt.Rows(0)("Genero").ToString
                        Numero = dt.Rows(0)("Lote").ToString
                        IdUbicacion = dt.Rows(0)("IdUbicacion").ToString
                    End If
                End If


        End Select




    End Sub



    Private Function ObtenerIdPartidaLote(Ejercicio As String, Tipo As String, Codigo As String, ByRef bError As Boolean) As String

        Dim res As String = ""
        bError = False


        Select Case Tipo.ToUpper.Trim

            Case "P"
                'Partidas
                Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
                res = AlbEntrada_Lineas.LeerMuestreo(VaInt(Ejercicio), Codigo)
                If res = 0 Then
                    MsgBox("No existe la partida para este ejercicio")
                    bError = True
                End If

            Case "L"
                'Lotes
                Dim Lotes As New E_Lotes(Idusuario, cn)
                res = Lotes.LeerLote(VaInt(Ejercicio), VaInt(Codigo))
                If res = 0 Then
                    MsgBox("No existe el lote para este ejercicio")
                    bError = True
                End If

            Case "T"
                'Palet
                Dim Palets As New E_palets(Idusuario, cn)
                res = Palets.Leerpalet(Ejercicio, MiMaletin.IdCentro, VaInt(Codigo))     'El Centro lo ignora, aquí no se usa
                If res = 0 Then
                    MsgBox("No existe el palet para este ejercicio")
                    bError = True
                End If

            Case "C"
                'Precalibrado
                Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
                res = LotesProduccion.LeerLote(VaInt(Ejercicio), VaInt(Codigo))
                If res = 0 Then
                    MsgBox("No existe el lote (precalibrado) para este ejercicio")
                    bError = True
                End If

        End Select



        Return res

    End Function



    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        'asociar cabecera con lineas

        Dim r As Boolean


        If LbId.Text = "+" Then
            LbId.Text = TraspasosCentros.MaxId
            If TxNumero.Text = "+" Then
                TxNumero.Text = TraspasosCentros.MaxIdCampa(VaInt(Lbejer.Text))
            End If
        End If


        Dim Tipo As String = TxTipo.Text.ToUpper.Trim
        Dim NuevaUbicacion As String = TxCentroDestino.Text

        TraspasosCentros.TCE_Ejercicio.Valor = Lbejer.Text

        'Calcular id del codigo que hemos introducido en el textbox numero
        Dim bError As Boolean = False
        Dim Codigo As String = ObtenerIdPartidaLote(Lbejer.Text, TxTipo.Text, TxCodigo.Text, bError)
        TxCodigo.MiError = bError

        TraspasosCentros_Lineas.TLI_Codigo.Valor = Codigo
        TraspasosCentros_Lineas.TLI_IdTraspaso.Valor = LbId.Text


        SqlGrid()



        r = MyBase.GuardarLineas(Gr)


        'Guardamos la nueva ubicacion
        Select Case Tipo
            Case "P"
                Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
                If AlbEntrada_Lineas.LeerId(Codigo) Then
                    AlbEntrada_Lineas.AEL_IdUbicacionPV.Valor = NuevaUbicacion
                    AlbEntrada_Lineas.Actualizar()
                End If
            Case "L"
                Dim Lotes As New E_Lotes(Idusuario, cn)
                If Lotes.LeerId(Codigo) Then
                    Lotes.LTE_IdUbicacionPV.Valor = NuevaUbicacion
                    Lotes.Actualizar()
                End If
            Case "T"
                Dim Palet As New E_palets(Idusuario, cn)
                If Palet.LeerId(Codigo) Then
                    Palet.PAL_idpvsituacion.Valor = NuevaUbicacion
                    Palet.Actualizar()
                End If
            Case "C"
                Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
                If LotesProduccion.LeerId(Codigo) Then
                    LotesProduccion.LPD_IdUbicacionPV.Valor = NuevaUbicacion
                    LotesProduccion.Actualizar()
                End If
        End Select



        Return r

    End Function


    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()


        If XtraMessageBox.Show("¿Desea imprimir el traspaso?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            C1_ImprimirDCTMC(LbId.Text, TipoDCTMC.Traspasos, TipoImpresion.ImpresoraPorDefecto)
        End If

        'Crear vales de envases según las líneas del traspaso
        CrearValeEnvases(LbId.Text)


    End Sub


    Private Sub CrearValeEnvases(IdTraspasoCentro As String)


        Dim TraspasosCentros As New E_TraspasosCentros(Idusuario, cn)
        If TraspasosCentros.LeerId(IdTraspasoCentro) Then


            Dim IdValeOrigen As String = (TraspasosCentros.TCE_IdValeOrigen.Valor & "").Trim
            Dim IdValeDestino As String = (TraspasosCentros.TCE_IdValeDestino.Valor & "").Trim



            Dim dt As DataTable = ObtenerDatosValeEnvases(IdTraspasoCentro)
            If Not IsNothing(dt) Then

                'Creamos vale de origen
                Dim ValeEnvaseOrigen As New E_ValeEnvases(Idusuario, cn)
                Dim bNuevoOrigen As Boolean = (IdValeOrigen = 0)


                If bNuevoOrigen Then
                    IdValeOrigen = ValeEnvaseOrigen.MaxId.ToString
                ElseIf Not ValeEnvaseOrigen.LeerId(IdValeOrigen) Then
                    bNuevoOrigen = True
                    ValeEnvaseOrigen = New E_ValeEnvases(Idusuario, cn)
                Else
                    Dim sql As String = "DELETE FROM ValeEnvases_Lineas WHERE VEL_IdVale = " & IdValeOrigen
                    TraspasosCentros.MiConexion.OrdenSql(sql)
                End If


                ValeEnvaseOrigen.VEV_Idvale.Valor = IdValeOrigen.ToString
                ValeEnvaseOrigen.VEV_Operacion.Valor = "TO"
                ValeEnvaseOrigen.VEV_Campa.Valor = TraspasosCentros.TCE_Ejercicio.Valor
                ValeEnvaseOrigen.VEV_Idcentro.Valor = MiMaletin.IdCentro.ToString
                ValeEnvaseOrigen.VEV_Numero.Valor = "1000" & TraspasosCentros.TCE_Numero.Valor
                ValeEnvaseOrigen.VEV_Fecha.Valor = TraspasosCentros.TCE_Fecha.Valor
                ValeEnvaseOrigen.VEV_IdAlmacen.Valor = TraspasosCentros.TCE_IdCentroOrigen.Valor
                ValeEnvaseOrigen.VEV_IdConcepto.Valor = "0"
                ValeEnvaseOrigen.VEV_Concepto.Valor = "TRASPASO DE GENERO"
                ValeEnvaseOrigen.VEV_TipoSujeto.Valor = ""
                ValeEnvaseOrigen.VEV_Codigo.Valor = ""

                If bNuevoOrigen Then
                    ValeEnvaseOrigen.Insertar()
                Else
                    ValeEnvaseOrigen.Actualizar()
                End If



                'Creamos vale de destino
                Dim ValeEnvaseDestino As New E_ValeEnvases(Idusuario, cn)
                Dim bNuevoDestino As Boolean = (IdValeDestino = 0)


                If bNuevoDestino Then
                    IdValeDestino = ValeEnvaseDestino.MaxId.ToString
                ElseIf Not ValeEnvaseDestino.LeerId(IdValeDestino) Then
                    bNuevoDestino = True
                Else
                    Dim sql As String = "DELETE FROM ValeEnvases_Lineas WHERE VEL_IdVale = " & IdValeDestino
                    TraspasosCentros.MiConexion.OrdenSql(sql)
                End If

                ValeEnvaseDestino.VEV_Idvale.Valor = IdValeDestino.ToString
                ValeEnvaseDestino.VEV_Operacion.Valor = "TD"
                ValeEnvaseDestino.VEV_Campa.Valor = TraspasosCentros.TCE_Ejercicio.Valor
                ValeEnvaseDestino.VEV_Idcentro.Valor = MiMaletin.IdCentro.ToString
                ValeEnvaseDestino.VEV_Numero.Valor = "1000" & TraspasosCentros.TCE_Numero.Valor
                ValeEnvaseDestino.VEV_Fecha.Valor = TraspasosCentros.TCE_Fecha.Valor
                ValeEnvaseDestino.VEV_IdAlmacen.Valor = TraspasosCentros.TCE_IdCentroDestino.Valor
                ValeEnvaseDestino.VEV_IdConcepto.Valor = "0"
                ValeEnvaseDestino.VEV_Concepto.Valor = "TRASPASO DE GENERO"
                ValeEnvaseDestino.VEV_TipoSujeto.Valor = ""
                ValeEnvaseDestino.VEV_Codigo.Valor = ""

                If bNuevoDestino Then
                    ValeEnvaseDestino.Insertar()
                Else
                    ValeEnvaseDestino.Actualizar()
                End If



                'Líneas (Origen y destino)
                For Each row As DataRow In dt.Rows

                    Dim IdEnvase As String = VaInt(row("IdEnvase")).ToString
                    Dim IdMarca As String = VaInt(row("IdMarca")).ToString
                    Dim Cantidad As Decimal = VaDec(row("Cantidad"))


                    'Origen
                    Dim ValeEnvases_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
                    ValeEnvases_Lineas.VEL_Id.Valor = ValeEnvases_Lineas.MaxId.ToString
                    ValeEnvases_Lineas.VEL_idvale.Valor = IdValeOrigen
                    ValeEnvases_Lineas.VEL_idenvase.Valor = IdEnvase
                    ValeEnvases_Lineas.VEL_retira.Valor = Cantidad.ToString
                    ValeEnvases_Lineas.VEL_entrega.Valor = "0"
                    ValeEnvases_Lineas.VEL_precioretira.Valor = "0"
                    ValeEnvases_Lineas.VEL_precioentrega.Valor = "0"
                    ValeEnvases_Lineas.VEL_idmarca.Valor = IdMarca
                    ValeEnvases_Lineas.VEL_idalmacen.Valor = TraspasosCentros.TCE_IdCentroOrigen.Valor
                    ValeEnvases_Lineas.Insertar()

                    'Destino
                    ValeEnvases_Lineas = New E_ValeEnvases_Lineas(Idusuario, cn)
                    ValeEnvases_Lineas.VEL_Id.Valor = ValeEnvases_Lineas.MaxId.ToString
                    ValeEnvases_Lineas.VEL_idvale.Valor = IdValeDestino
                    ValeEnvases_Lineas.VEL_idenvase.Valor = IdEnvase
                    ValeEnvases_Lineas.VEL_retira.Valor = 0
                    ValeEnvases_Lineas.VEL_entrega.Valor = Cantidad.ToString
                    ValeEnvases_Lineas.VEL_precioretira.Valor = "0"
                    ValeEnvases_Lineas.VEL_precioentrega.Valor = "0"
                    ValeEnvases_Lineas.VEL_idmarca.Valor = IdMarca
                    ValeEnvases_Lineas.VEL_idalmacen.Valor = TraspasosCentros.TCE_IdCentroDestino.Valor
                    ValeEnvases_Lineas.Insertar()

                Next



                'Actualiza Traspaso con los ids de los vales
                TraspasosCentros.TCE_IdValeOrigen.Valor = IdValeOrigen
                TraspasosCentros.TCE_IdValeDestino.Valor = IdValeDestino
                TraspasosCentros.Actualizar()



            End If


        End If


    End Sub


    Private Function ObtenerDatosValeEnvases(IdTraspasoCentro As String) As DataTable


        Dim acum As New Acumulador


        Dim CONSULTA As New Cdatos.E_select
        CONSULTA.SelCampo(TraspasosCentros_Lineas.TLI_Tipo, "Tipo")
        CONSULTA.SelCampo(TraspasosCentros_Lineas.TLI_Codigo, "Codigo")
        CONSULTA.WheCampo(TraspasosCentros_Lineas.TLI_IdTraspaso, "=", IdTraspasoCentro)


        Dim sql As String = CONSULTA.SQL
        Dim dt As DataTable = TraspasosCentros.MiConexion.ConsultaSQL(sql)

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then


                'Obtenemos los datos para las líneas
                For Each row As DataRow In dt.Rows

                    Dim Tipo As String = (row("Tipo").ToString & "").Trim
                    Dim Codigo As String = (row("Codigo").ToString & "").Trim

                    Select Case Tipo

                        Case "P"
                            'Partidas
                            Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
                            If AlbEntrada_Lineas.LeerId(Codigo) Then

                                If VaInt(AlbEntrada_Lineas.AEL_idenvase.Valor) > 0 Then

                                    Dim IdEnvase As Integer = VaInt(AlbEntrada_Lineas.AEL_idenvase.Valor)
                                    Dim IdMarca As Integer = VaInt(AlbEntrada_Lineas.AEL_idmarca.Valor)
                                    Dim Cantidad As Integer = VaInt(AlbEntrada_Lineas.AEL_bultos.Valor)

                                    Dim stClave As New stClave_LineasVale(IdEnvase, IdMarca)
                                    Dim stDatos As New stDatos_LineasVale(Cantidad)
                                    acum.Suma(stClave, stDatos)

                                End If

                            End If


                        Case "L"
                            'Lotes
                            Dim Lotes As New E_Lotes(Idusuario, cn)
                            If Lotes.LeerId(Codigo) Then

                                If VaInt(Lotes.LTE_IdEnvase.Valor) > 0 Then

                                    Dim IdEnvase As Integer = VaInt(Lotes.LTE_IdEnvase.Valor)
                                    Dim Cantidad As Decimal = 0

                                    If VaInt(Lotes.LTE_Idlote.Valor) > 0 Then

                                        Dim sqlL As String = "SELECT SUM(LTL_Bultos) as Bultos FROM Lotes_Lineas WHERE LTL_IdLote = " & Lotes.LTE_Idlote.Valor
                                        Dim dtL As DataTable = Lotes.MiConexion.ConsultaSQL(sqlL)
                                        If Not IsNothing(dtL) Then
                                            If dtL.Rows.Count > 0 Then
                                                Cantidad = VaDec(dtL.Rows(0)("Bultos"))
                                            End If
                                        End If

                                    End If

                                    Dim stClave As New stClave_LineasVale(IdEnvase, 0)
                                    Dim stDatos As New stDatos_LineasVale(Cantidad)
                                    acum.Suma(stClave, stDatos)

                                End If

                            End If


                        Case "T"
                            'Palets
                            Dim Palets As New E_palets(Idusuario, cn)
                            If Palets.LeerId(Codigo) Then

                                'Envases de la cabecera del palet
                                If VaInt(Palets.PAL_idtipopalet.Valor) > 0 Then

                                    Dim sqlP As String = "SELECT CPL_IdMaterial as IdMaterial, CPL_Cantidad as Cantidad FROM ConfecPaletLineas WHERE CPL_IdConfec = " & Palets.PAL_idtipopalet.Valor
                                    Dim dtP As DataTable = Palets.MiConexion.ConsultaSQL(sqlP)

                                    If Not IsNothing(dtP) Then
                                        For Each rowP As DataRow In dtP.Rows

                                            Dim IdEnvase As Integer = VaInt(rowP("IdMaterial"))
                                            Dim Cantidad As Decimal = VaDec(rowP("Cantidad"))

                                            Dim stClave As New stClave_LineasVale(IdEnvase, 0)
                                            Dim stDatos As New stDatos_LineasVale(Cantidad)
                                            acum.Suma(stClave, stDatos)

                                        Next
                                    End If

                                End If


                                'Envases de las líneas de palets
                                Dim sqlF As String = "SELECT PLL_Bultos as Bultos, CEL_IdMaterial as IdMaterial, CEL_Cantidad as Cantidad," & vbCrLf
                                sqlF = sqlF & " CASE ENV_Tipo WHEN 'E' THEN MarcasEnv.MAR_IdMarca WHEN 'Q' THEN MarcasEti.MAR_IdMarca WHEN 'M' THEN MarcasMat.MAR_IdMarca ELSE '' END as IdMarca" & vbCrLf
                                sqlF = sqlF & " FROM Palets_Lineas" & vbCrLf
                                sqlF = sqlF & " INNER JOIN ConfecEnvaseLineas ON PLL_IdTipoConfeccion = CEL_IdConfec" & vbCrLf
                                sqlF = sqlF & " LEFT JOIN Envases ON ENV_IdEnvase = CEL_IdMaterial" & vbCrLf
                                sqlF = sqlF & " LEFT JOIN Marcas as MarcasEnv ON MarcasEnv.MAR_IdMarca = PLL_IdMarca" & vbCrLf
                                sqlF = sqlF & " LEFT JOIN Marcas as MarcasEti ON MarcasEti.MAR_IdMarca = PLL_IdMarcaEti" & vbCrLf
                                sqlF = sqlF & " LEFT JOIN Marcas as MarcasMat ON MarcasMat.MAR_IdMarca = PLL_IdMarcaMat" & vbCrLf
                                sqlF = sqlF & " WHERE PLL_IdPalet = " & Palets.PAL_idpalet.Valor

                                Dim dtF As DataTable = Palets.MiConexion.ConsultaSQL(sqlF)

                                If Not IsNothing(dtF) Then
                                    For Each rowF As DataRow In dtF.Rows

                                        Dim IdEnvase As Integer = VaInt(rowF("IdMaterial"))
                                        Dim IdMarca As Integer = VaInt(rowF("IdMarca"))
                                        Dim Bultos As Integer = VaInt(rowF("Bultos"))
                                        Dim Cantidad As Decimal = VaDec(rowF("Cantidad"))
                                        Cantidad = Cantidad * Bultos

                                        Dim stClave As New stClave_LineasVale(IdEnvase, IdMarca)
                                        Dim stDatos As New stDatos_LineasVale(Cantidad)
                                        acum.Suma(stClave, stDatos)

                                    Next
                                End If


                            End If


                        Case "C"
                            'Precalibrado
                            Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
                            If LotesProduccion.LeerId(Codigo) Then

                                If VaInt(LotesProduccion.LPD_IdEnvase.Valor) > 0 Then

                                    Dim IdEnvase As Integer = VaInt(LotesProduccion.LPD_IdEnvase.Valor)
                                    Dim Cantidad As Decimal = 0

                                    If VaInt(LotesProduccion.LPD_Idlote.Valor) > 0 Then

                                        Dim sqlC As String = "SELECT SUM(LPL_Bultos) as Bultos FROM LotesProduccion_Lineas WHERE LPL_IdLote = " & LotesProduccion.LPD_Idlote.Valor
                                        Dim dtC As DataTable = LotesProduccion.MiConexion.ConsultaSQL(sqlC)
                                        If Not IsNothing(dtC) Then
                                            If dtC.Rows.Count > 0 Then
                                                Cantidad = VaDec(dtC.Rows(0)("Bultos"))
                                            End If
                                        End If

                                    End If

                                    Dim stClave As New stClave_LineasVale(IdEnvase, 0)
                                    Dim stDatos As New stDatos_LineasVale(Cantidad)
                                    acum.Suma(stClave, stDatos)

                                End If

                            End If

                    End Select

                Next


            End If

        End If



        Return acum.DataTable


    End Function


    Private Sub CargaLineasGrid()

        SqlGrid()
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)

    End Sub


    Private Sub SqlGrid()
        Dim id As String

        If LbId.Text = "+" Then
            id = "-1"
        Else
            id = LbId.Text
        End If


        'Atencion a las mayusculas !!!! El primer campo siempre la clave 
        Dim sql As String = "SELECT TLI_IdLinea, TLI_Tipo as Tipo, TLI_Codigo as Codigo, AEL_Muestreo as Numero, GEN_NombreGenero as Producto, AEL_KilosNetos as KilosNetos " & vbCrLf
        sql = sql & " FROM TraspasosCentros_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN AlbEntrada_Lineas ON TLI_Codigo = AEL_IdLinea" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = AEL_IdGenero" & vbCrLf
        sql = sql & " WHERE TLI_IdTraspaso = " & id & vbCrLf
        sql = sql & " AND TLI_Tipo = 'P'" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT TLI_IdLinea, TLI_Tipo as Tipo, TLI_Codigo as Codigo, LTE_Lote as Numero, GEN_NombreGenero as Producto, " & vbCrLf
        sql = sql & " (SELECT SUM(LTL_KIlos) FROM Lotes_Lineas WHERE LTL_IdLote = LTE_IdLote) as KilosNetos" & vbCrLf
        sql = sql & " FROM TraspasosCentros_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN Lotes ON TLI_Codigo = LTE_IdLote" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = LTE_IdGenero" & vbCrLf
        sql = sql & " WHERE TLI_IdTraspaso = " & id & vbCrLf
        sql = sql & " AND TLI_Tipo = 'L'" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT TLI_IdLinea, Tipo, Codigo, Numero, GEN_NombreGenero as Producto, KilosNetos" & vbCrLf
        sql = sql & " FROM(" & vbCrLf
        sql = sql & " SELECT TLI_IdLinea, TLI_Tipo as Tipo, TLI_Codigo as Codigo, PAL_Palet as Numero," & vbCrLf
        sql = sql & " (SELECT SUM(PLL_KilosNetos) FROM Palets_Lineas WHERE PLL_IdPalet = PAL_IdPalet) as KilosNetos," & vbCrLf
        sql = sql & " (SELECT TOP 1 PLL_IdGenero FROM Palets_Lineas WHERE PLL_IdPalet = PAL_IdPalet) as IdGenero" & vbCrLf
        sql = sql & " FROM TraspasosCentros_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN Palets ON TLI_Codigo = PAL_IdPalet" & vbCrLf
        sql = sql & " WHERE TLI_IdTraspaso = " & id & vbCrLf
        sql = sql & " AND TLI_Tipo = 'T'" & vbCrLf
        sql = sql & " ) as T" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = T.IdGenero" & vbCrLf
        sql = sql & " UNION ALL" & vbCrLf
        sql = sql & " SELECT TLI_IdLinea, TLI_Tipo as Tipo, TLI_Codigo as Codigo, LPD_Lote as Numero, GEN_NombreGenero as Producto, " & vbCrLf
        sql = sql & " (SELECT SUM(LPL_Kilos) FROM LotesProduccion_Lineas WHERE LPL_IdLote = LPD_IdLote) as KilosNetos" & vbCrLf
        sql = sql & " FROM TraspasosCentros_Lineas" & vbCrLf
        sql = sql & " LEFT JOIN LotesProduccion ON TLI_Codigo = LPD_IdLote" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = LPD_IdGenero" & vbCrLf
        sql = sql & " WHERE TLI_IdTraspaso = " & id & vbCrLf
        sql = sql & " AND TLI_Tipo = 'C'" & vbCrLf
        sql = sql & " ORDER BY TLI_IdLinea" & vbCrLf




        ClGrid1.Consulta = sql


    End Sub


    Private Sub BtNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNuevo.Click
        If TxNumero.Text = "" And TxNumero.Enabled = True Then
            TxNumero.Text = "+"
            Siguiente(0)
        End If
    End Sub


    Public Overrides Sub Borralin(gr As ClGrid)
        MyBase.Borralin(gr)

        LbNomProducto.Text = ""

    End Sub


    Public Overrides Sub BorraPan()

        MyBase.BorraPan()

        Lbejer.Text = MiMaletin.Ejercicio

        btAnularRecepcion.Visible = False

    End Sub


    Public Overrides Sub Guardar()


        Dim hoy As Date = Now

        TraspasosCentros.TCE_FechaCarga.Valor = hoy.ToString("dd/MM/yyyy")
        TraspasosCentros.TCE_HoraCarga.Valor = hoy.ToString("HH:mm")


        Dim IdSemana As String = ObtenerIdSemanaSalida(TxFecha.Text)
        TraspasosCentros.TCE_IdSemana.Valor = IdSemana

        MyBase.Guardar()

    End Sub


    Public Overrides Sub DespuesdeGuardarLinea(gr As ClGrid)
        MyBase.DespuesdeGuardarLinea(gr)
    End Sub


    Private Sub TxCodigo_Valida(edicion As System.Boolean) Handles TxCodigo.Valida

        Dim Producto As String = ""
        Dim Numero As String = ""
        Dim IdUbicacion As String = ""
        Dim bError As Boolean = False


        Dim Id As String = ObtenerIdPartidaLote(Lbejer.Text, TxTipo.Text, TxCodigo.Text, bError)
        If bError Then
            MsgBox("Error al procesar la partida, lote o palet solicitados")
            TxCodigo.MiError = True
            Exit Sub
        End If


        ObtenerProducto(TxTipo.Text, Id, Producto, Numero, IdUbicacion)


        If edicion Then

            If Not CompruebaTraspasoAbierto(TxTipo.Text, TxCodigo.Text) Then
                MsgBox("No se puede realizar el traspaso, la mercancía ya está en un traspaso")
                TxCodigo.MiError = True
                Exit Sub
            Else
                TxCodigo.MiError = False
            End If

            'Comprueba que la partida no provenga de una entrada directa
            If TxTipo.Text = "P" Then
                If EntradaDirecta(Lbejer.Text, Id) Then
                    MsgBox("La partida proviene de una entrada directa")
                    TxCodigo.MiError = True
                    Exit Sub
                End If
            End If


        End If


        If VaInt(IdUbicacion) <> VaInt(TxCentroOrigen.Text) Then
            MsgBox("La partida, el lote, o el palet deben pertenecer al centro de origen")
            TxCodigo.MiError = True
            Exit Sub
        Else
            TxCodigo.MiError = False
        End If


        LbNomProducto.Text = Producto

    End Sub


    Private Function EntradaDirecta(Ejercicio As String, IdLineaEntrada As String) As Boolean

        Dim bRes As Boolean = False

        If VaInt(IdLineaEntrada) > 0 Then

            Dim sql As String = "SELECT AEN_EntradaConfeccionada as Directa FROM AlbEntrada_Lineas LEFT JOIN AlbEntrada ON AEN_IdAlbaran = AEL_IdAlbaran WHERE AEL_IdLinea = " & IdLineaEntrada
            Dim dt As DataTable = AlbEntrada_lineas.MiConexion.ConsultaSQL(sql)

            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    Dim row As DataRow = dt.Rows(0)
                    Dim directa As String = (row("Directa").ToString & "").Trim

                    bRes = (directa = "S")

                End If
            End If


        End If


        Return bRes

    End Function


    Private Function CompruebaTraspasoAbierto(Tipo As String, Numero As String) As Boolean

        Dim bRes As Boolean = True


        Dim sql As String = ""


        Select Case Tipo

            Case "P"

                Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
                Dim IdLinea As Integer = AlbEntrada_Lineas.LeerMuestreo(Lbejer.Text, Numero)
                If IdLinea > 0 Then
                    sql = "SELECT TCE_Numero as Traspaso FROM TraspasosCentros_Lineas " & vbCrLf
                    sql = sql & " LEFT JOIN TraspasosCentros ON TCE_IdTraspaso = TLI_IdTraspaso" & vbCrLf
                    sql = sql & " WHERE TLI_Tipo = 'P' AND TLI_Codigo = " & IdLinea & " AND COALESCE(TCE_FechaDescarga,'01/01/1900') = '01/01/1900'" & vbCrLf
                End If

            Case "L"

                Dim Lotes As New E_Lotes(Idusuario, cn)
                Dim IdLote As Integer = Lotes.LeerLote(VaInt(Lbejer.Text), VaInt(Numero))
                If IdLote > 0 Then
                    sql = "SELECT TCE_Numero as Traspaso FROM TraspasosCentros_Lineas " & vbCrLf
                    sql = sql & " LEFT JOIN TraspasosCentros ON TCE_IdTraspaso = TLI_IdTraspaso" & vbCrLf
                    sql = sql & " WHERE TLI_Tipo = 'L' AND TLI_Codigo = " & IdLote & " AND COALESCE(TCE_FechaDescarga,'01/01/1900') = '01/01/1900'" & vbCrLf
                End If

            Case "C"

                Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
                Dim IdLoteProduccion As Integer = LotesProduccion.LeerLote(VaInt(Lbejer.Text), VaInt(Numero))
                If IdLoteProduccion > 0 Then
                    sql = "SELECT TCE_Numero as Traspaso FROM TraspasosCentros_Lineas " & vbCrLf
                    sql = sql & " LEFT JOIN TraspasosCentros ON TCE_IdTraspaso = TLI_IdTraspaso" & vbCrLf
                    sql = sql & " WHERE TLI_Tipo = 'C' AND TLI_Codigo = " & IdLoteProduccion & " AND COALESCE(TCE_FechaDescarga,'01/01/1900') = '01/01/1900'" & vbCrLf
                End If

        End Select


        If sql <> "" Then

            Dim dt As DataTable = TraspasosCentros.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    bRes = False
                End If
            End If

        End If


        Return bRes

    End Function


    Private Sub BtBuscaPartidaLote_Click(sender As System.Object, e As System.EventArgs) Handles BtBuscaPartidaLote.Click
        BuscaPartidaLote()
    End Sub

    Private Sub TxCodigo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxCodigo.KeyDown
        If e.KeyCode = Keys.F2 Then
            BuscaPartidaLote()
        End If
    End Sub

    Private Sub TxCodigo_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxCodigo.EnabledChanged
        BtBuscaPartidaLote.Enabled = TxCodigo.Enabled
    End Sub

    Private Sub BuscaPartidaLote()

        Dim FrBuscaAlb As FrBuscaAlb
        Dim BtBusca As BtBusca


        Select Case TxTipo.Text.ToUpper.Trim

            Case "P"
                FrBuscaAlb = New FrBuscaAlb("Partidas")
                BtBusca = AlbEntrada_lineas.btBusca
                FrBuscaAlb.InitCodigo(BtBusca.CL_ConsultaSql, AlbEntrada_lineas, BtBusca.CL_campocodigo, BtBusca.CL_camponombre, BtBusca.CL_dfecha, BtBusca.CL_hfecha, BtBusca.CL_ParamBusqueda, Nothing)
                FrBuscaAlb.ShowDialog()

            Case "L"
                FrBuscaAlb = New FrBuscaAlb("Lotes")
                BtBusca = Lotes.btBusca
                FrBuscaAlb.InitCodigo(BtBusca.CL_ConsultaSql, Lotes, BtBusca.CL_campocodigo, BtBusca.CL_camponombre, BtBusca.CL_dfecha, BtBusca.CL_hfecha, BtBusca.CL_ParamBusqueda, Nothing)
                FrBuscaAlb.ShowDialog()

            Case "T"
                FrBuscaAlb = New FrBuscaAlb("Palets")
                BtBusca = Palets.btBusca
                FrBuscaAlb.InitCodigo(BtBusca.CL_ConsultaSql, Palets, BtBusca.CL_campocodigo, BtBusca.CL_camponombre, BtBusca.CL_dfecha, BtBusca.CL_hfecha, BtBusca.CL_ParamBusqueda, Nothing)
                FrBuscaAlb.ShowDialog()

            Case "C"
                FrBuscaAlb = New FrBuscaAlb("Precalibrado")
                BtBusca = LotesProduccion.btBusca
                FrBuscaAlb.InitCodigo(BtBusca.CL_ConsultaSql, LotesProduccion, BtBusca.CL_campocodigo, BtBusca.CL_camponombre, BtBusca.CL_dfecha, BtBusca.CL_hfecha, BtBusca.CL_ParamBusqueda, Nothing)
                FrBuscaAlb.ShowDialog()


        End Select



        If Not BuscarRow Is Nothing Then

            Try
                Select Case TxTipo.Text.ToUpper.Trim
                    Case "P"
                        TxCodigo.Text = BuscarRow("Partida").ToString
                    Case "L"
                        TxCodigo.Text = BuscarRow("Lote").ToString
                    Case "T"
                        TxCodigo.Text = BuscarRow("Numero").ToString
                    Case "C"
                        TxCodigo.Text = BuscarRow("Lote").ToString
                End Select


            Catch ex As Exception
                TxCodigo.Text = ""
            End Try


            TxCodigo.Validar(True)

        End If

    End Sub



    Public Overrides Sub BotonAuxiliar1()
        MyBase.BotonAuxiliar1()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirDCTMC(LbId.Text, TipoDCTMC.Traspasos, TipoImpresion.Preliminar)
        End If

    End Sub


    Public Overrides Sub BotonAuxiliar2()
        MyBase.BotonAuxiliar2()

        If VaInt(LbId.Text) > 0 Then
            C1_ImprimirDCTMC(LbId.Text, TipoDCTMC.Traspasos, TipoImpresion.ImpresoraPorDefecto)
        End If


    End Sub


    Private Sub TxTipo_Valida(edicion As System.Boolean) Handles TxTipo.Valida

        Select Case TxTipo.Text
            Case "P"
                TxTipo.MiError = False
            Case "L"
                TxTipo.MiError = False
            Case "T"
                TxTipo.MiError = False
            Case "C"
                TxTipo.MiError = False
            Case Else
                TxTipo.MiError = True
        End Select

    End Sub


    Private Sub TxTipo_AntesDeValidar(edicion As System.Boolean) Handles TxTipo.AntesDeValidar

        If edicion Then
            ValidaCodigoBarras(TxTipo.Text)
        End If

    End Sub


    Private Sub TxCodigo_AntesDeValidar(edicion As System.Boolean) Handles TxCodigo.AntesDeValidar

        If edicion Then
            ValidaCodigoBarras(TxCodigo.Text)
        End If

    End Sub


    Private Sub ValidaCodigoBarras(codigo As String)

        Dim Campa As Integer = 0
        Dim Numero As String = ""

        Dim bPartida As Boolean = False
        Dim bLote As Boolean = False
        Dim bPalet As Boolean = False
        Dim bPrecalibrado As Boolean = False


        Dim datos As String() = Split(codigo, ".")
        If datos.Length = 2 Then

            If codigo.StartsWith("PA") Then
                'Partida
                bPartida = True
                Campa = VaInt(datos(0).Replace("PA", ""))
                If Campa <> VaInt(Lbejer.Text) Then
                    MsgBox("La campaña no coincide con la campaña actual")
                    TxTipo.Text = ""
                    TxCodigo.Text = ""
                    Exit Sub
                End If
                Numero = datos(1)
                TxTipo.Text = "P"
                TxCodigo.Text = Numero
            ElseIf codigo.StartsWith("LE") Then
                'Lote
                bLote = True
                Campa = VaInt(datos(0).Replace("LE", ""))
                If Campa <> VaInt(Lbejer.Text) Then
                    MsgBox("La campaña no coincide con la campaña actual")
                    TxTipo.Text = ""
                    TxCodigo.Text = ""
                    Exit Sub
                End If
                Numero = datos(1)
                TxTipo.Text = "L"
                TxCodigo.Text = Numero
            ElseIf codigo.StartsWith("TP") Then
                'Palet
                bPalet = True
                Campa = VaInt(datos(0).Replace("TP", ""))
                If Campa <> VaInt(Lbejer.Text) Then
                    MsgBox("La campaña no coincide con la campaña actual")
                    TxTipo.Text = ""
                    TxCodigo.Text = ""
                    Exit Sub
                End If
                Numero = datos(1)
                TxTipo.Text = "T"
                TxCodigo.Text = Numero
            ElseIf codigo.StartsWith("PS") Then
                'Precalibrado
                bPrecalibrado = True
                Campa = VaInt(datos(0).Replace("PS", ""))
                If Campa <> VaInt(Lbejer.Text) Then
                    MsgBox("La campaña no coincide con la campaña actual")
                    TxTipo.Text = ""
                    TxCodigo.Text = ""
                    Exit Sub
                End If
                Numero = datos(1)
                TxTipo.Text = "C"
                TxCodigo.Text = Numero
            Else
                TxTipo.Text = ""
                TxCodigo.Text = ""
                Exit Sub
            End If


            Siguiente(TxCodigo.Orden)



        ElseIf TxTipo.Text <> "P" And TxTipo.Text <> "L" And TxTipo.Text <> "T" And TxTipo.Text <> "C" Then
            TxTipo.Text = ""
            TxCodigo.Text = ""
            Exit Sub
        End If


    End Sub


    Private Sub TxFecha_EnabledChanged(sender As System.Object, e As System.EventArgs) Handles TxFecha.EnabledChanged
        btAnularRecepcion.Enabled = TxFecha.Enabled
    End Sub


    Private Sub btAnularRecepcion_Click(sender As System.Object, e As System.EventArgs) Handles btAnularRecepcion.Click


        If XtraMessageBox.Show("¿Desea anular la recepción del traspaso?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            TraspasosCentros.TCE_FechaDescarga.Valor = VaDate("").ToString("dd/MM/yyyy")
            TraspasosCentros.TCE_HoraDescarga.Valor = "00:00"


            AnulaRecepcionTraspaso()

        End If



        TxFecha.Select()
        TxFecha.Focus()

    End Sub


    Private Sub AnulaRecepcionTraspaso()

        Try

            Dim Traspaso As New E_TraspasosCentros(Idusuario, cn)
            If Traspaso.LeerId(LbId.Text) Then

                Traspaso.TCE_FechaDescarga.Valor = VaDate("").ToString("dd/MM/yyyy")
                Traspaso.TCE_HoraDescarga.Valor = "00:00"
                Traspaso.Actualizar()

                'Crear vales de envases según las líneas del traspaso
                CrearValeEnvases(LbId.Text)
                'TODO: Esto lo debe hacer al guardar (o anular)??

            End If

            MsgBox("Recepción anulada")
            btAnularRecepcion.Visible = False


        Catch ex As Exception
            MsgBox("Error al anular la recepción")
        End Try



    End Sub


    Private Function ObtenerIdSemanaSalida(ByVal Fecha As String) As String

        Dim res As String = ""

        If VaDate(Fecha) > VaDate("") Then

            Dim sql As String = "SELECT SEV_IdSemana as IdSemana FROM SemanasPartes WHERE '" & Fecha & "' BETWEEN SEV_FechaInicialSalida AND SEV_FechaFinalSalida AND SEV_Ejercicio = " & Lbejer.Text
            Dim dt As DataTable = TraspasosCentros.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    res = VaInt(dt.Rows(0)("IdSemana"))

                End If
            End If

        End If


        Return res

    End Function

End Class