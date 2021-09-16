Imports DevExpress.XtraEditors
Imports System.Drawing


Module C1_CMR_Internacional

    Dim fuente_media As New Font("Courier New", 10, FontStyle.Regular)
    Dim fuente As New Font("Courier New", 11, FontStyle.Regular)
    Dim fuente_menor As New Font("Courier New", 8, FontStyle.Regular)
    Dim fuente_negrita As New Font("Courier New", 11, FontStyle.Bold)
    Dim fuente_negrita_peque As New Font("Courier New", 10, FontStyle.Bold)
    Dim fuente_menor_negrita As New Font("Courier New", 8, FontStyle.Bold)
    Dim fuente_mayor As New Font("Courier New", 14, FontStyle.Regular)
    Dim fuente_mayor_negrita As New Font("Courier New", 14, FontStyle.Bold)

    Dim margen_izquierdo As Integer = 16


    Private Class stClaves_Medidas

        Public IdMedida As Integer = 0
        Public Medida As String = ""

        Public Sub New(IdMedida As Integer, Medida As String)
            Me.IdMedida = IdMedida
            Me.Medida = Medida
        End Sub

    End Class

    Private Class stDatos_Medidas

        Public Cont As Integer = 0
        Public ContTransporte As Integer = 0

        Public Sub New(Cont As Integer, ContTransporte As Integer)
            Me.Cont = Cont
            Me.ContTransporte = ContTransporte
        End Sub

    End Class


    Public Sub C1_ImprimirCMR_InterNacional(ByVal IdCMR As String, TipoImpresion As TipoImpresion, bEtiqueta As Boolean,
                                          Optional Impresora As String = "",
                                          Optional rutaPDF As String = "",
                                          Optional archivoPDF As String = "")


        If VaInt(IdCMR) > 0 Then

            Dim CMR As New E_Cmr(Idusuario, cn)
            If CMR.LeerId(IdCMR) Then

                'DatosEmpresa
                Dim DatosEmpresa As New DatosEmpresa()
                DatosEmpresa.ObtenerDatosEmpresa()


                'DatosCliente
                Dim Cliente As New E_Clientes(Idusuario, cn)
                If Not Cliente.LeerId(CMR.CMR_Idcliente.Valor) Then
                    XtraMessageBox.Show("No se encontró el cliente Id " & CMR.CMR_Idcliente.Valor, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                Dim bDatosClienteEnCMR As Boolean = ((Cliente.CLI_DatosEnCMR.Valor & "").Trim = "S")


                Dim Idioma As String = (Cliente.CLI_Ididioma.Valor & "").Trim


                Dim Paises As New E_Paises(Idusuario, CnComun)
                Dim Pais As String = ""
                If Paises.LeerId(Cliente.CLI_IdPais.Valor) Then
                    Pais = Paises.Nombre.Valor
                End If


                'Datos albarán
                Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
                Dim IdAlbaran As Integer = AlbSalida.LeerAlb(VaInt(CMR.CMR_Campa.Valor), VaInt(CMR.CMR_Idcentro.Valor), VaInt(CMR.CMR_Albaran.Valor))
                If IdAlbaran = 0 Then
                    XtraMessageBox.Show("No se encontró el albarán nº" & CMR.CMR_Albaran.Valor & " para esta camapaña y centro", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If


                'Datos Pedido
                Dim Pedidos As New E_Pedidos(Idusuario, cn)
                If VaInt(AlbSalida.ASA_idpedido.Valor) > 0 Then
                    Pedidos.LeerId(AlbSalida.ASA_idpedido.Valor)
                End If



                'Meollo
                Dim Impreso As New Impreso
                Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.A4
                Impreso.f.documento.PageLayout.PageSettings.Landscape = False
                Impreso.f.documento.PageLayout.PageSettings.TopMargin = "0mm"
                Impreso.f.documento.PageLayout.PageSettings.BottomMargin = "0mm"
                Impreso.f.documento.PageLayout.PageSettings.LeftMargin = "0mm"
                Impreso.f.documento.PageLayout.PageSettings.RightMargin = "0mm"


                Impreso.EstableceImpreso(TipoImpresion)


                'Meollo

                Try

                    'Datos Remitente
                    ImprimeDatosRemitente(Impreso, DatosEmpresa, bDatosClienteEnCMR, Cliente, Pais)

                    'Datos Consignatario
                    ImprimeDatosConsignatario(Impreso, Cliente, Pais)

                    ' Datos Porteador
                    ImprimePorteadores(Impreso, AlbSalida)

                    'Lugar de entrega
                    ImprimeDestinoMercancia(Impreso, Cliente, AlbSalida, Pais)

                    'Nº Albaran y matrículas
                    ImprimeAlbaranMatriculas(Impreso, AlbSalida)

                    'Lugar y fecha de carga
                    ImprimeLugarFechaCarga(Impreso, DatosEmpresa, AlbSalida.ASA_fechasalida.Valor)

                    'Detalle
                    ImprimeDetalle(Impreso, AlbSalida, IdCMR, Idioma)

                    'País de Origen  y Temperatura
                    ImprimeInstrucciones(Impreso, AlbSalida, Pedidos)

                    'Formalizado en 
                    ImprimeFormalizado(Impreso, DatosEmpresa)

                    'Firma y sello
                    ImprimeFirmaSello(Impreso, DatosEmpresa)



                    Dim ImpresoraPorDefecto As String = ""
                    Dim ImpresoraEtiquetas As String = ""
                    Dim bValorUsuario As Boolean = False

                    Dim valoresusuario As New E_valoresusuario(Idusuario, cn)
                    If valoresusuario.LeerId(Idusuario) = True Then
                        ImpresoraPorDefecto = valoresusuario.VUS_ImpresoraCMRInternacional.Valor
                        ImpresoraEtiquetas = (valoresusuario.VUS_ImpresoraEtiquetaCMR.Valor & "").Trim
                        bValorUsuario = True
                    End If


                    'Impresión / previsualización / exportación
                    Select Case TipoImpresion

                        Case NetAgro.TipoImpresion.ImpresoraPorDefecto

                            If bValorUsuario Then
                                Impreso.Imprimir(NetAgro.TipoImpresion.ImpresoraSeleccionada, ImpresoraPorDefecto, rutaPDF, archivoPDF)
                            Else
                                Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)
                            End If

                        Case Else
                            Impreso.Imprimir(TipoImpresion, Impresora, rutaPDF, archivoPDF)

                    End Select



                    Dim Ejercicio As String = VaInt(CMR.CMR_Campa.Valor).ToString
                    Dim IdCentro As String = VaInt(CMR.CMR_Idcentro.Valor).ToString
                    Dim Albaran As String = VaInt(CMR.CMR_Albaran.Valor).ToString


                    If bEtiqueta Then
                        C1_ImprimirEtiquetaCMR(Ejercicio, IdCentro, Albaran, ImpresoraEtiquetas, TipoImpresion)
                    End If


                Catch ex As Exception

                End Try


            Else
                XtraMessageBox.Show("No se pudo leer el CMR con Id " & IdCMR, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Else
            XtraMessageBox.Show("No se encontró el CMR con Id: " & IdCMR, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub


    Private Sub ImprimeDatosRemitente(ByRef Impreso As Impreso, ByVal DatosEmpresa As DatosEmpresa, ByVal bDatosClienteEnCMR As Boolean, ByVal Cliente As E_Clientes, ByVal PaisCliente As String)
        Dim Altura As Integer = 25

        If bDatosClienteEnCMR Then

            Impreso.Detalle.Titulo(Cliente.CLI_Nombre.Valor & "", margen_izquierdo, Altura, 80, 4, Estilos.Custom, , , fuente)
            Impreso.Detalle.Titulo(Cliente.CLI_Domicilio.Valor & "", margen_izquierdo, Altura + 4, 80, 4, Estilos.Custom, , , fuente)
            Impreso.Detalle.Titulo(Cliente.CLI_Poblacion.Valor & " - " & PaisCliente, margen_izquierdo, Altura + 4 + 4, 80, 4, Estilos.Custom, , , fuente_menor)

        Else
            Impreso.Detalle.Titulo(DatosEmpresa.NombreEmpresa, margen_izquierdo, Altura, 80, 4, Estilos.Custom, , , fuente)
            Impreso.Detalle.Titulo(DatosEmpresa.Domicilio, margen_izquierdo, Altura + 4, 80, 4, Estilos.Custom, , , fuente)
            Impreso.Detalle.Titulo(DatosEmpresa.CPostal & "-" & DatosEmpresa.Poblacion & "(" & DatosEmpresa.Provincia & ")", margen_izquierdo, Altura + 4 + 4, 80, 4, Estilos.Custom, , , fuente_menor)
        End If


    End Sub


    Private Sub ImprimeDatosConsignatario(ByRef Impreso As Impreso, ByVal Cliente As E_Clientes, ByVal Pais As String)
        Dim Altura As Integer = 51

        Impreso.Detalle.Titulo(Cliente.CLI_Nombre.Valor & "", margen_izquierdo, Altura, 85, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo(Cliente.CLI_Domicilio.Valor & "", margen_izquierdo, Altura + 4, 85, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo(Cliente.CLI_Poblacion.Valor & " - " & Pais, margen_izquierdo, Altura + 4 + 4, 85, 4, Estilos.Custom, , , fuente_menor)

    End Sub


    Private Sub ImprimeDestinoMercancia(ByRef Impreso As Impreso, Cliente As E_Clientes, AlbSalida As E_AlbSalida, Pais As String)

        Dim Domicilio As String = Cliente.CLI_Domicilio.Valor
        Dim Poblacion As String = Cliente.CLI_Poblacion.Valor & " - " & Pais
        Dim LugarEntrega As String = ""

        Dim IdDomicilio As String = AlbSalida.ASA_iddomicilio.Valor
        If VaInt(IdDomicilio) > 0 Then

            Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
            If ClientesDescargas.LeerId(IdDomicilio) Then
                Pais = ""
                Dim Paises As New E_Paises(Idusuario, CnComun)
                If Paises.LeerId(ClientesDescargas.CLD_IdPais.Valor) Then
                    Pais = Paises.Nombre.Valor
                End If
                Domicilio = ClientesDescargas.CLD_Domicilio.Valor
                Poblacion = ClientesDescargas.CLD_Poblacion.Valor & " - " & Pais
                If (Cliente.CLI_DatosEnCMR.Valor & "").Trim = "S" Then
                    LugarEntrega = ClientesDescargas.CLD_LugarEntregaCMR.Valor
                Else
                    LugarEntrega = ClientesDescargas.CLD_Provincia.Valor
                End If

            End If

        End If

        Dim Altura As Integer = 73

        Impreso.Detalle.Titulo(Domicilio, margen_izquierdo, Altura, 85, 4, Estilos.Custom, , , fuente_menor)
        Impreso.Detalle.Titulo(Poblacion, margen_izquierdo, Altura + 4, 85, 4, Estilos.Custom, , , fuente_menor)
        Impreso.Detalle.Titulo(LugarEntrega, margen_izquierdo, Altura + 8, 85, 4, Estilos.Custom, , , fuente_menor)

    End Sub


    Private Sub ImprimePorteadores(ByVal Impreso As Impreso, ByVal AlbSalida As E_AlbSalida)

        Dim Altura As Integer = 53
        Dim Margen As Integer = 110

        Dim Acreedores As New E_Acreedores(Idusuario, cn)

        Acreedores.LeerId(AlbSalida.ASA_idtransportista.Valor)

        Impreso.Detalle.Titulo(Acreedores.ACR_Nombre.Valor & "", Margen, Altura, 85, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo(Acreedores.ACR_Domicilio.Valor & "", Margen, Altura + 4, 85, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo(Acreedores.ACR_Poblacion.Valor & " - " & Acreedores.ACR_Provincia.Valor, Margen, Altura + 4 + 4, 85, 4, Estilos.Custom, , , fuente_menor)
    End Sub


    Private Sub ImprimeAlbaranMatriculas(ByRef Impreso As Impreso, AlbSalida As E_AlbSalida)
        Dim Mat_vehiculo As String = AlbSalida.ASA_matriculacamion.Valor & ""
        Dim Mat_remolque As String = AlbSalida.ASA_matricularemolque.Valor & ""

        Dim Altura As Integer = 72

        Impreso.Detalle.Titulo(Mat_vehiculo, margen_izquierdo + 135, Altura, 36, 5, Estilos.Custom, ">", , fuente_mayor_negrita)
        Impreso.Detalle.Titulo(Mat_remolque, margen_izquierdo + 135, Altura + 5, 36, 5, Estilos.Custom, ">", , fuente_mayor_negrita)
    End Sub


    Private Sub ImprimeLugarFechaCarga(ByRef Impreso As Impreso, DatosEmpresa As DatosEmpresa, FechaSalida As String)

        Dim fecha As String = FechaSalida
        Dim LugarCarga As String = DatosEmpresa.Poblacion & " - " & DatosEmpresa.Provincia
        Dim Altura As Integer = 95

        Impreso.Detalle.Titulo(LugarCarga & " " & fecha, margen_izquierdo, Altura, 80, 4, Estilos.Custom, , , fuente_menor)

    End Sub



    Private Sub ImprimeDetalle(ByRef Impreso As Impreso, ByVal AlbSalida As E_AlbSalida, ByVal IdCMR As String, ByVal Idioma As String)

        Dim altura As Integer = 132

        Dim sql As String = "SELECT MAR_Nombre as Marca, GES_GeneroQS as QS, SUM(ASL_Bultos) as Bultos, ENV_Nombre as Envase, ASL_IdGenero as IdGenero," & vbCrLf
        sql = sql & " GEN_NombreGenero as Genero, SUM(ASL_KilosBrutos) as Kilos" & vbCrLf
        sql = sql & " FROM AlbSalida " & vbCrLf
        sql = sql & " LEFT JOIN AlbSalida_Lineas ON ASA_IdAlbaran = ASL_IdAlbaran" & vbCrLf
        sql = sql & " LEFT JOIN Generos ON GEN_IdGenero = ASL_IdGenero" & vbCrLf
        sql = sql & " LEFT JOIN ConfecEnvase ON CEV_IdConfec = ASL_IdTipoConfeccion" & vbCrLf
        sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = CEV_IdEnvase" & vbCrLf
        sql = sql & " LEFT JOIN Marcas ON MAR_IdMarca = ASL_IdMarca" & vbCrLf
        sql = sql & " LEFT JOIN GenerosSalida ON ASL_IdGenSal = GES_IdGenSal" & vbCrLf
        sql = sql & " WHERE ASA_Idalbaran = " & AlbSalida.ASA_idalbaran.Valor & vbCrLf
        sql = sql & " GROUP BY ASL_IdGenero, GEN_NombreGenero, CEV_IdEnvase, ENV_Nombre, GES_GeneroQS, ASL_IdMarca, MAR_Nombre" & vbCrLf
        sql = sql & " ORDER BY GEN_NombreGenero, ENV_Nombre" & vbCrLf

        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)


        Dim TotalBultos As Integer = 0
        Dim TotalKilos As Decimal = 0


        For Each row As DataRow In dt.Rows

            Dim QS As String = ""
            If (row("QS").ToString & "").Trim = "S" Then
                QS = "QS "
            End If
            Dim Marca As String = QS & (row("Marca").ToString & "").Trim
            Dim Bultos As Integer = VaInt(row("Bultos"))
            Dim Kilos As Decimal = VaDec(row("Kilos"))
            Dim Envase As String = row("Envase").ToString & ""
            'Dim Categoria As String = (row("Categoria").ToString & "").Trim
            Dim Genero As String = row("Genero").ToString & ""


            Dim GeneroIdioma As String = ObtenerGeneroIdioma(Idioma, row("IdGenero").ToString)
            If GeneroIdioma <> "" Then
                Genero = GeneroIdioma
            End If


            Impreso.Detalle.Titulo(Marca, margen_izquierdo, altura, 20, 4, Estilos.Custom, , , fuente_menor)
            Impreso.Detalle.Titulo(Bultos.ToString("#,##0"), 45, altura, 20, 4, Estilos.Custom, ">", , fuente_menor)
            Impreso.Detalle.Titulo(Envase, 74, altura, 25, 4, Estilos.Custom, , , fuente_menor)
            Impreso.Detalle.Titulo(Genero, 103, altura, 35, 4, Estilos.Custom, , , fuente_menor)
            'Impreso.Detalle.Titulo(Categoria, 133, altura, 15, 4, Estilos.Custom, , , fuente_menor)
            Impreso.Detalle.Titulo(Kilos.ToString("#,##0"), 153, altura, 20, 4, Estilos.Custom, ">", , fuente_menor)
            altura = altura + 3

            TotalBultos = TotalBultos + Bultos
            TotalKilos = TotalKilos + Kilos


            Application.DoEvents()

        Next

        'Cond. Venta y Posición
        Dim CondVenta As String = ""
        Dim TiposPorte As New E_TiposPorte(Idusuario, cn)
        If VaInt(AlbSalida.ASA_idtipoporte.Valor) > 0 Then
            If TiposPorte.LeerId(AlbSalida.ASA_idtipoporte.Valor) Then
                CondVenta = TiposPorte.TPO_Nombre.Valor
            End If
        End If

        Impreso.Detalle.Titulo("-----", 46, altura, 20, 4, Estilos.Custom, ">", , fuente_menor)
        Impreso.Detalle.Titulo("-------", 154, altura, 20, 4, Estilos.Custom, ">", , fuente_menor)
        altura = altura + 3

        Impreso.Detalle.Titulo(TotalBultos.ToString("#,##0"), 45, altura, 20, 4, Estilos.Custom, ">", , fuente_menor)
        altura = altura + 3


        ' Albarán y Pedido
        Dim Pedido As String = ""
        Dim Pedidos As New E_Pedidos(Idusuario, cn)
        If VaInt(AlbSalida.ASA_idpedido.Valor) > 0 Then
            If Pedidos.LeerId(AlbSalida.ASA_idpedido.Valor) Then
                Pedido = VaInt(Pedidos.PED_pedido.Valor).ToString("00")
            End If
        End If


        Dim Albaran As String = VaInt(AlbSalida.ASA_idcentro.Valor).ToString("00") & "-" & VaDec(AlbSalida.ASA_albaran.Valor).ToString
        Impreso.Detalle.Titulo("ALB: ", margen_izquierdo, altura, 8, 4, Estilos.Custom, , , fuente_menor_negrita)
        Impreso.Detalle.Titulo(Albaran, margen_izquierdo + 7, altura - 1, 18, 4, Estilos.Custom, "<", , fuente_negrita_peque)
        Impreso.Detalle.Titulo("PEDIDO: ", margen_izquierdo + 10 + 20, altura, 18, 4, Estilos.Custom, , , fuente_menor)
        Impreso.Detalle.Titulo(Pedido, margen_izquierdo + 8 + 18 + 18, altura, 18, 4, Estilos.Custom, "<", , fuente_menor)
        altura = altura + 3




        altura = altura + 3

        'Resumen palets
        Impreso.Detalle.Titulo("TIPO DE PALET", margen_izquierdo, altura, 34, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("RET.", margen_izquierdo + 34 + 2, altura, 13, 4, Estilos.Custom, ">", , fuente)
        Impreso.Detalle.Titulo("ENT.", margen_izquierdo + 34 + 2 + 13 + 2, altura, 13, 4, Estilos.Custom, ">", , fuente)
        altura = altura + 3

        Impreso.Detalle.Titulo("----------------------", margen_izquierdo, altura, 34, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("-------", margen_izquierdo + 34 + 2, altura, 13, 4, Estilos.Custom, ">", , fuente)
        Impreso.Detalle.Titulo("-------", margen_izquierdo + 34 + 2 + 13 + 2, altura, 13, 4, Estilos.Custom, ">", , fuente)

        altura = altura + 3

        Dim BaseTamaño As Integer = altura


        If VaInt(AlbSalida.ASA_idvaleenvase.Valor) > 0 Then

            sql = "SELECT ENV_Nombre as Envase, SUM(VEL_Retira) as Retira, SUM(VEL_Entrega) as Entrega" & vbCrLf
            sql = sql & " FROM ValeEnvases_Lineas" & vbCrLf
            sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = VEL_IdEnvase" & vbCrLf
            sql = sql & " WHERE VEL_IdVale = " & AlbSalida.ASA_idvaleenvase.Valor & vbCrLf
            sql = sql & " AND ENV_Tipo = 'P'" & vbCrLf
            sql = sql & " GROUP BY VEL_IdEnvase, ENV_Nombre" & vbCrLf

            Dim dtTiposPalets As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dtTiposPalets) Then

                For Each row As DataRow In dtTiposPalets.Rows

                    Dim TipoPalet As String = (row("Envase").ToString & "").Trim
                    Dim Retira As Integer = VaInt(row("Retira"))
                    Dim Entrega As Integer = VaInt(row("Entrega"))

                    Impreso.Detalle.Titulo(TipoPalet, margen_izquierdo, altura, 34, 4, Estilos.Custom, , , fuente)
                    If Retira <> 0 Then Impreso.Detalle.Titulo(Retira.ToString("#,##0"), margen_izquierdo + 34 + 2, altura, 13, 4, Estilos.Custom, ">", , fuente)
                    If Entrega <> 0 Then Impreso.Detalle.Titulo(Entrega.ToString("#,##0"), margen_izquierdo + 34 + 2 + 13 + 2, altura, 13, 4, Estilos.Custom, ">", , fuente)

                    altura = altura + 3


                    Application.DoEvents()

                Next

            End If


        End If


        'Totales grandes y pequeños
        altura = BaseTamaño


        Dim acumMedidas As New Acumulador


        If VaInt(IdCMR) > 0 Then

            sql = "SELECT ENV_IdMedida as IdMedida, PLM_Medidas as Medida, CML_Palets as Palets, CML_PaletsTransporte as PaletsTransporte" & vbCrLf
            sql = sql & " FROM CMR_Lineas" & vbCrLf
            sql = sql & " LEFT JOIN Envases ON ENV_IdEnvase = CML_IdPalet" & vbCrLf
            sql = sql & " LEFT JOIN MedidasPalet ON PLM_Id = ENV_IdMedida" & vbCrLf
            sql = sql & " WHERE CML_IdCMR = " & IdCMR & vbCrLf

            Dim dtMedidas As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)
            If Not IsNothing(dtMedidas) Then

                For Each row As DataRow In dtMedidas.Rows

                    Dim IdMedida As Integer = VaInt(row("IdMedida"))
                    Dim Medida As String = (row("Medida").ToString & "").Trim
                    Dim Palets As Integer = VaInt(row("Palets"))
                    Dim PaletsTransporte As Decimal = VaDec(row("PaletsTransporte"))

                    Dim stClave As New stClaves_Medidas(IdMedida, Medida)
                    Dim stDatos As New stDatos_Medidas(Palets, PaletsTransporte)
                    acumMedidas.Suma(stClave, stDatos)


                    Application.DoEvents()

                Next

            End If


        End If


        Dim dtAcumMedidas As DataTable = acumMedidas.DataTable
        Dim TotalPalets As Integer = 0

        If Not IsNothing(dtAcumMedidas) Then

            For Each row As DataRow In dtAcumMedidas.Rows

                Dim Nombre As String = (row("Medida").ToString & "").Trim
                Dim Cont As Integer = VaInt(row("Cont"))
                Dim ContTransporte As Integer = VaInt(row("ContTransporte"))

                If ContTransporte <> 0 Then
                    Impreso.Detalle.Titulo("TOT." & Nombre.ToUpper, margen_izquierdo + 78, altura, 21, 4, Estilos.Custom, , , fuente)
                    If ContTransporte <> 0 Then Impreso.Detalle.Titulo(ContTransporte.ToString("#,##0"), margen_izquierdo + 91, altura, 18, 4, Estilos.Custom, ">", , fuente)
                End If

                'Impreso.Detalle.Titulo("TOT." & Nombre.ToUpper, margen_izquierdo + 78, altura, 21, 4, Estilos.Custom, , , fuente)
                'If Cont <> 0 Then Impreso.Detalle.Titulo(Cont.ToString("#,##0"), margen_izquierdo + 91, altura, 18, 4, Estilos.Custom, ">", , fuente)
                altura = altura + 3

                TotalPalets = TotalPalets + Cont


                Application.DoEvents()

            Next

        End If

        Impreso.Detalle.Titulo("POSICION: " & AlbSalida.ASA_referencia.Valor, margen_izquierdo, altura, 60, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo("C.V.: " & CondVenta, margen_izquierdo + 60 + 2, altura, 50, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo(TotalKilos.ToString("#,##0"), 133, altura, 40, 4, Estilos.Custom, ">", , fuente)


        'TODO: Detallar palets
        'Impreso.Detalle.Titulo("TOTAL PALETS: ", margen_izquierdo, altura + 4, 30, 4, Estilos.Custom, "<", , fuente)
        'Impreso.Detalle.Titulo(TotalPalets.ToString("#,##0"), margen_izquierdo + 91, altura + 4, 18, 4, Estilos.Custom, ">", , fuente)

        If Not IsNothing(dtAcumMedidas) Then

            For Each row As DataRow In dtAcumMedidas.Rows

                Dim Nombre As String = (row("Medida").ToString & "").Trim
                Dim ContTransporte As Integer = VaInt(row("ContTransporte"))

                If ContTransporte <> 0 Then

                    Impreso.Detalle.Titulo("TOTAL PALET " & Nombre & ": ", margen_izquierdo, altura + 4, 80, 4, Estilos.Custom, "<", , fuente)
                    Impreso.Detalle.Titulo(ContTransporte.ToString("#,##0"), margen_izquierdo + 91, altura + 4, 18, 4, Estilos.Custom, ">", , fuente)

                    altura = altura + 4

                End If

            Next

        End If



    End Sub


    Private Sub ImprimeInstrucciones(ByRef Impreso As Impreso, ByVal AlbSalida As E_AlbSalida, ByVal Pedidos As E_Pedidos)
        Dim configuracionesdiversas As New E_ConfiguracionesDiversas(Idusuario, cn)

        Dim TEXTO_PAIS As String = "PAÍS DE ORIGEN: ESPAÑA"
        Dim Temperatura As String = configuracionesdiversas.xDameValor(E_ConfiguracionesDiversas.eClaves.TEMPERATURA_TRANSPORTE_CMR)
        Dim NumRegTemperatura As String = AlbSalida.ASA_numregtemperatura.Valor
        Dim Altura As Integer = 215
        Dim Ancho As Integer = 86

        Impreso.Detalle.Titulo(Temperatura, margen_izquierdo, Altura, Ancho, 5, Estilos.Custom, "<", , fuente)
        Impreso.Detalle.Titulo(TEXTO_PAIS, margen_izquierdo, Altura + 4, Ancho, 5, Estilos.Custom, "<", , fuente)
        Impreso.Detalle.Titulo("Nº REG. TEMPERATURA / RYAN: ", margen_izquierdo, Altura + 4 + 4, 70, 5, Estilos.Custom, "<", , fuente)
        Impreso.Detalle.Titulo(NumRegTemperatura, margen_izquierdo + 65, Altura + 4 + 4, 20, 8, Estilos.Custom, "<", , fuente_mayor_negrita)

        Dim BESTELLNR As String = (Pedidos.PED_BESTELLNR.Valor & "").Trim
        If BESTELLNR <> "" Then
            Impreso.Detalle.Titulo("BESTELLNR: " & BESTELLNR, margen_izquierdo, Altura + 4 + 4 + 4, Ancho, 5, Estilos.Custom, "<", , fuente_mayor_negrita)
        End If


        Altura = Altura + 4 + 4 + 4 + 4



        Dim bProductoEcologico As Boolean = False
        Dim NumRegistro As String = ""



        Dim IdPuntoVenta As String = (AlbSalida.ASA_idpuntoventa.Valor & "").Trim
        If VaInt(IdPuntoVenta) > 0 Then

            Dim ValoresPVenta As New E_valorespventa(Idusuario, cn)
            If ValoresPVenta.LeerId(IdPuntoVenta) Then

                Dim Ecologico As String = (ValoresPVenta.VPV_EcologicoSN.Valor & "").Trim
                bProductoEcologico = (Ecologico = "S")
                NumRegistro = (ValoresPVenta.VPV_NumRegistroEco.Valor & "").Trim

            End If

        End If

        If bProductoEcologico Then
            Impreso.Detalle.Titulo("PROCEDENTE DEL CULTIVO ECOLOGICO, ", margen_izquierdo, Altura, Ancho, 5, Estilos.Custom, "<", , fuente_media)
            Altura = Altura + 4
            Impreso.Detalle.Titulo("SISTEMA DE CONTROL UE: " & NumRegistro, margen_izquierdo, Altura, Ancho, 5, Estilos.Custom, "<", , fuente_media)
            Altura = Altura + 4
            Impreso.Detalle.Titulo("REGLAMENTO UE-834/2007", margen_izquierdo, Altura, Ancho, 5, Estilos.Custom, "<", , fuente_media)
        End If


    End Sub


    Private Sub ImprimeFormalizado(ByRef Impreso As Impreso, ByVal DatosEmpresa As DatosEmpresa)

        Dim Altura As Integer = 262

        Dim fecha As String = Today.ToString("dd-MM-yyyy")
        Impreso.Detalle.Titulo(DatosEmpresa.Poblacion & " " & fecha, 38, Altura, 77, 4, Estilos.Custom, , , fuente)

    End Sub

    Private Sub ImprimeFirmaSello(ByVal Impreso As Impreso, ByVal DatosEmpresa As DatosEmpresa)
        Dim Altura As Integer = 268

        Impreso.Detalle.Titulo(DatosEmpresa.NombreEmpresa, margen_izquierdo, Altura, 60, 4, Estilos.Custom, , , fuente)
        Impreso.Detalle.Titulo(DatosEmpresa.Domicilio, margen_izquierdo, Altura + 4, 60, 3, Estilos.Custom, , , fuente_menor)
        Impreso.Detalle.Titulo(DatosEmpresa.CPostal & "-" & DatosEmpresa.Poblacion & "(" & DatosEmpresa.Provincia & ")", margen_izquierdo, Altura + 4 + 3, 80, 3, Estilos.Custom, , , fuente_menor)

        Dim CIF As String = ""
        Dim Empresas As New E_Empresas(Idusuario, cn)
        If Empresas.LeerId(MiMaletin.IdEmpresaCTB.ToString) Then
            CIF = (Empresas.EMP_CIF.Valor & "").Trim
        End If
        Impreso.Detalle.Titulo("CIF: " & CIF, margen_izquierdo, Altura + 4 + 3 + 3, 80, 4, Estilos.Custom, , , fuente_menor)

    End Sub


    Public Sub C1_ImprimirEtiquetaCMR(Ejercicio As String, IdCentro As String, Albaran As String, Impresora As String, TipoImpresion As TipoImpresion)

        'Meollo
        Dim Impreso As New Impreso
        Impreso.f.documento.PageLayout.PageSettings.PaperKind = Printing.PaperKind.Custom
        Impreso.f.documento.PageLayout.PageSettings.Landscape = False
        Impreso.f.documento.PageLayout.PageSettings.SetPaperSizes("69mm", "29mm")
        Impreso.f.documento.PageLayout.PageSettings.TopMargin = "0mm"
        Impreso.f.documento.PageLayout.PageSettings.BottomMargin = "0mm"
        Impreso.f.documento.PageLayout.PageSettings.LeftMargin = "0mm"
        Impreso.f.documento.PageLayout.PageSettings.RightMargin = "0mm"


        Impreso.EstableceImpreso(TipoImpresion)


        Dim Code39 As New Font("C39HrP24DhTt", 37)
        'Dim Code39 As New Font("IDAutomationHC39M", 27)
        Dim CodBar As String = "*CM" & Ejercicio & "." & IdCentro & "." & Albaran & "*"
        'CodBar = "*CM" & Ejercicio & "." & IdCentro & ".999999*"
        Impreso.Detalle.Titulo(CodBar, 0, 2, 68, 25, Estilos.Custom, "=", , Code39)


        'Impresión / previsualización / exportación
        If TipoImpresion = NetAgro.TipoImpresion.Preliminar Then
            Impreso.Imprimir(TipoImpresion, Impresora)
        Else
            Impreso.Imprimir(TipoImpresion.ImpresoraSeleccionada, Impresora)
        End If



    End Sub


End Module
