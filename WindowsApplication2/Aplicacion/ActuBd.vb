Module ActuBd

    Private Class indice

        Public tabla As String
        Public campo As String
        Public nombre_indice As String

        Public Sub New(campo As Cdatos.bdcampo, nombre_indice As String)

            Me.tabla = campo.MiEntidad.NombreTabla
            Me.campo = campo.NombreCampo
            Me.nombre_indice = nombre_indice

        End Sub

    End Class


    Public Sub ActuBaseDatos(ByVal conexion As NetAgro.Cdatos.Conexion)

        Dim Actualizador As New Actualizador(conexion)


        Dim TraspasosCentros As New E_TraspasosCentros(Idusuario, cn)
        Actualizador.CreaCampo(TraspasosCentros.TCE_IdValeOrigen)
        Actualizador.CreaCampo(TraspasosCentros.TCE_IdValeDestino)

        Dim AgricultorGastos As New E_AgricultorGastos(Idusuario, cn)
        Actualizador.CreaCampo(AgricultorGastos.AGG_AsignarAcreedorAlbaran)


        Dim LogUsuariosApl As New E_LogusuariosApl(Idusuario, cn)
        Actualizador.CreaTabla(LogUsuariosApl)


        Dim AlbSalida_Lineas As New E_AlbSalida_lineas(Idusuario, cn)
        Actualizador.CreaCampo(AlbSalida_Lineas.ASL_IdUsuarioLog)
        Actualizador.CreaCampo(AlbSalida_Lineas.ASL_FechaLog)
        Actualizador.CreaCampo(AlbSalida_Lineas.ASL_HoraLog)

        Dim Produccion As New E_Produccion(Idusuario, cn)
        Actualizador.CreaCampo(Produccion.PRD_HoraInicialCompleta)
        Actualizador.CreaCampo(Produccion.PRD_HoraFinalCompleta)

        Dim FacturasAgr_Lineas As New E_FacturaAgr_lineas(Idusuario, cn)
        Actualizador.LongitudCampo(FacturasAgr_Lineas.FAL_kilos)


        Dim Envases As New E_Envases(Idusuario, cn)
        Actualizador.CreaCampo(Envases.ENV_CtaDevFianzas, "56500000000")


        Dim Lineas As New E_Lineas(Idusuario, cn)
        Actualizador.CreaCampo(Lineas.LIN_IdLineaCalidad)


        Dim Palets As New E_palets(Idusuario, cn)
        Actualizador.CreaCampo(Palets.PAL_HoraConfeccion)
        Actualizador.CreaCampo(Palets.PAL_IdUsuario)
        Actualizador.CreaCampo(Palets.PAL_IdOperario)

        Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
        Actualizador.CreaCampo(Palets_Lineas.PLL_Merma)

        Dim Reclamaciones As New E_Reclama(Idusuario, cn)
        Actualizador.CreaCampo(Reclamaciones.RCL_Conclusiones1)
        Actualizador.CreaCampo(Reclamaciones.RCL_Conclusiones2)
        Actualizador.CreaCampo(Reclamaciones.RCL_Conclusiones3)
        Actualizador.CreaCampo(Reclamaciones.RCL_Conclusiones4)
        Actualizador.CreaCampo(Reclamaciones.RCL_Acciones1)
        Actualizador.CreaCampo(Reclamaciones.RCL_Acciones2)
        Actualizador.CreaCampo(Reclamaciones.RCL_Acciones3)
        Actualizador.CreaCampo(Reclamaciones.RCL_Acciones4)


        Dim Moneda As New E_Moneda(Idusuario, cn)
        Dim sql As String = "INSERT INTO NetAgroComer.dbo.Moneda(MON_IdMoneda, MON_Nombre, MON_Cambio, MON_Simbolo) SELECT IdMoneda, Nombre, Cambio, Simbolo FROM Comun.dbo.Moneda "
        Actualizador.CreaTabla(Moneda, sql)

        Actualizador.CreaCampo(Moneda.MON_Abreviatura)


        Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)
        Actualizador.CreaCampo(ValoresUsuario.VUS_ImpresoraEtiquetaCMR)


        Dim PreciosRef As New E_PreciosRef(Idusuario, cn)
        Actualizador.LongitudCampo(PreciosRef.PRF_cambio)


        Dim ValoresEjercicio As New E_ValoresEjercicio(Idusuario, cn)
        Actualizador.CreaTabla(ValoresEjercicio)


        Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)
        Actualizador.CreaCampo(AlmacenEnvases.AEV_Domicilio)
        Actualizador.CreaCampo(AlmacenEnvases.AEV_CPostal)
        Actualizador.CreaCampo(AlmacenEnvases.AEV_Poblacion)
        Actualizador.CreaCampo(AlmacenEnvases.AEV_Provincia)

        Dim Albsalida As New E_AlbSalida(Idusuario, cn)

        Actualizador.CreaCampo(Albsalida.ASA_IdEmpresa, "1")

        Dim Valorespventa As New E_valorespventa(Idusuario, cn)
        Actualizador.CreaCampo(Valorespventa.VPV_IdEmpresa, "1")


        Dim Pventausuario As New E_PventaUsuario(Idusuario, cn)
        Actualizador.CreaTabla(Pventausuario)


        Dim ValoracionSemanal As New E_ValoracionSemanal(Idusuario, cn)
        Actualizador.CreaCampo(ValoracionSemanal.VSC_idcentro, "1")

        Dim Partes As New E_Partes(Idusuario, cn)
        Actualizador.CreaCampo(Partes.PDS_idcentro, "1")

        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Actualizador.CreaCampo(Agricultores.AGR_idcentro, "1")

        Actualizador.CreaCampo(FacturasAgr_Lineas.FAL_Piezas)
        Actualizador.CreaCampo(FacturasAgr_Lineas.FAL_TipoPrecio, "K")
        Actualizador.CreaCampo(FacturasAgr_Lineas.FAL_IdGensal)

        Actualizador.CreaCampo(Valorespventa.VPV_Nif)

        Actualizador.CreaCampo(Valorespventa.VPV_GGN)


        Dim BloqueoCultivos As New E_BloqueoCultivos(Idusuario, cn)
        Actualizador.CreaTabla(BloqueoCultivos)

        Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
        Actualizador.CreaCampo(AlbEntrada.AEN_HoraEntrada, , "UPDATE AlbEntrada SET AEN_HoraEntrada = LEFT(AEN_HoraLog,5)")


        Actualizador.CreaCampo(Valorespventa.VPV_EcologicoSN)
        Actualizador.CreaCampo(Valorespventa.VPV_NumRegistroEco)

        Dim Pedidos_Clientes As New E_Pedidos_Clientes(Idusuario, cn)
        Actualizador.CreaTabla(Pedidos_Clientes)


        Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)
        Actualizador.CreaCampo(FacturaAgr.FGR_FechaAsientoREA, , "UPDATE FacturaAgr SET FGR_FechaAsientoREA = FGR_Fecha")
        Actualizador.CreaCampo(FacturaAgr.FGR_EjercicioREA, , "UPDATE FacturaAgr SET FGR_EjercicioREA = FGR_Ejercicio")
        Actualizador.CreaCampo(FacturaAgr.FGR_IdAsientoREA)


        Dim Pedidos As New E_Pedidos(Idusuario, cn)
        Actualizador.CreaCampo(Pedidos.PED_MovilChofer)


        Dim Pedidos_Lineas As New E_Pedidos_lineas(Idusuario, cn)
        Actualizador.CreaCampo(Pedidos_Lineas.PEL_KilosBrutos)


        Actualizador.LongitudCampo(Envases.ENV_TaraEntrada)

        Actualizador.CreaCampo(Pedidos_Clientes.PCC_IdGenero)

        Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)
        Actualizador.CreaCampo(TipoAgricultor.TPA_CtaCartera)


        'Cartera
        Actualizador.CreaCampo(Agricultores.AGR_IdFormaPago)
        Actualizador.CreaCampo(Agricultores.AGR_IBAN)
        Actualizador.CreaCampo(Agricultores.AGR_DiasVto)
        Actualizador.CreaCampo(Agricultores.AGR_SituacionCartera)
        Actualizador.CreaCampo(Agricultores.AGR_TipoDocumento)

        Dim LiquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)
        Actualizador.CreaCampo(LiquidacionAgr.LIQ_IdFormaPago)
        Actualizador.CreaCampo(LiquidacionAgr.LIQ_FechaVto)
        Actualizador.CreaCampo(LiquidacionAgr.LIQ_SituacionCartera)
        Actualizador.CreaCampo(LiquidacionAgr.LIQ_TipoDocumento)


        Dim Clientes As New E_Clientes(Idusuario, cn)
        Actualizador.CreaCampo(Clientes.CLI_GGNEnFacturas)
        Actualizador.CreaCampo(Clientes.CLI_ForzarGGNEnFacturas)



        Actualizador.CreaCampo(FacturaAgr.FGR_IdAsientoREA_Ret)


        Dim DescripcionGeneroPorIdioma As New E_DescripcionGeneroPorIdioma(Idusuario, cn)
        Actualizador.CreaTabla(DescripcionGeneroPorIdioma)


        Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
        Actualizador.CreaCampo(GenerosSalida.GES_GeneroQS)

        Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Actualizador.LongitudCampo(AlbEntrada_Lineas.AEL_idcultivo)


        Dim FacturasRecibidasImportaciones As New E_FacturasRecibidasImportaciones(Idusuario, cn)
        Actualizador.CreaCampo(FacturasRecibidasImportaciones.FRI_TipoIdentificacion)
        Actualizador.CreaCampo(FacturasRecibidasImportaciones.FRI_CodigoPais)



        Dim Facturas As New E_Facturas(Idusuario, cn)
        Actualizador.CreaCampo(Facturas.FRA_IdTipoIva, "0")

        Actualizador.CreaCampo(FacturaAgr.FGR_IdTipoIva, "0")




        Actualizador.CreaCampo(Valorespventa.VPV_CentroCtb)


        Dim Previsiones_lineas As New E_Previsiones_lineas(Idusuario, cn)
        Actualizador.CreaCampo(Previsiones_lineas.PRL_IDfinca)
        Actualizador.CreaCampo(Previsiones_lineas.PRL_IdCultivo)
        Actualizador.CreaCampo(Previsiones_lineas.PRL_Observaciones)


        Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
        Actualizador.CreaCampo(SemanasPartes.SEV_LiquidadoSN)



        Actualizador.LongitudCampo(Palets_Lineas.PLL_kilosbrutos)
        Actualizador.LongitudCampo(Palets_Lineas.PLL_kiloscliente)
        Actualizador.LongitudCampo(Palets_Lineas.PLL_kilosnetos)

        Actualizador.CreaCampo(AlbEntrada_Lineas.AEL_ControlPresuntivoMP, "0")

        Actualizador.CreaCampo(Envases.ENV_IdAcreedorFianza)
        Actualizador.CreaCampo(Envases.ENV_CodigoFianza)
        Actualizador.CreaCampo(Envases.ENV_PrecioFianza)
        Dim ValeEnvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)

        Actualizador.CreaCampo(ValeEnvases_Lineas.VEL_IdFacturaRecibida)


        Dim Acreedores As New E_Acreedores(Idusuario, cn)
        Actualizador.CreaCampo(Acreedores.ACR_CodigoFianza)

        Dim DomiciliosFianza As New E_DomiciliosFianzas(Idusuario, cn)
        Actualizador.CreaTabla(DomiciliosFianza)






		Actualizador.CreaCampo(ValoresUsuario.VUS_DescNavegador1)
        Actualizador.CreaCampo(ValoresUsuario.VUS_DescNavegador2)
        Actualizador.CreaCampo(ValoresUsuario.VUS_DescNavegador3)
        Actualizador.CreaCampo(ValoresUsuario.VUS_DescNavegador4)
        Actualizador.CreaCampo(ValoresUsuario.VUS_DescNavegador5)
        Actualizador.CreaCampo(ValoresUsuario.VUS_DescNavegador6)
        Actualizador.CreaCampo(ValoresUsuario.VUS_DescNavegador7)
        Actualizador.CreaCampo(ValoresUsuario.VUS_DescNavegador8)
        Actualizador.CreaCampo(ValoresUsuario.VUS_DescNavegador9)
        Actualizador.CreaCampo(ValoresUsuario.VUS_DescNavegador10)

        Actualizador.CreaCampo(ValoresUsuario.VUS_UrlNavegador1)
        Actualizador.CreaCampo(ValoresUsuario.VUS_UrlNavegador2)
        Actualizador.CreaCampo(ValoresUsuario.VUS_UrlNavegador3)
        Actualizador.CreaCampo(ValoresUsuario.VUS_UrlNavegador4)
        Actualizador.CreaCampo(ValoresUsuario.VUS_UrlNavegador5)
        Actualizador.CreaCampo(ValoresUsuario.VUS_UrlNavegador6)
        Actualizador.CreaCampo(ValoresUsuario.VUS_UrlNavegador7)
        Actualizador.CreaCampo(ValoresUsuario.VUS_UrlNavegador8)
        Actualizador.CreaCampo(ValoresUsuario.VUS_UrlNavegador9)
        Actualizador.CreaCampo(ValoresUsuario.VUS_UrlNavegador10)



        Actualizador.CreaCampo(Agricultores.AGR_EmailCalidad)

        Actualizador.CreaCampo(Pedidos_Clientes.PCC_IdDomicilio)
        Actualizador.CreaCampo(GenerosSalida.GES_DEMETER)


        Actualizador.CreaCampo(Palets_Lineas.PLL_IdLineaSalida)

        Actualizador.CreaCampo(ValoresUsuario.VUS_ImpresoraClasificacionesProveedor)

        Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)
        Actualizador.CreaCampo(CentrosRecogida.CER_CopiasBoletinMuestreo)
        Actualizador.CreaCampo(CentrosRecogida.CER_CopiasAlbaranEntrada)

        Dim Lotes As New E_Lotes(Idusuario, cn)
        Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
        Actualizador.CreaCampo(Lotes.LTE_Color)
        Actualizador.CreaCampo(LotesProduccion.LPD_Color)
        Actualizador.CreaCampo(AlbEntrada_Lineas.AEL_Color)


        Dim Cobros As New E_Cobros(Idusuario, cn)
        Actualizador.CreaCampo(Cobros.COB_IdSituacion)


        Dim ConfecPalet As New E_ConfecPalet(Idusuario, cn)
        Actualizador.CreaCampo(ConfecPalet.CPA_Coeficiente)
        Actualizador.CreaCampo(Pedidos_Lineas.PEL_PaletsTransporte)
        Actualizador.CreaCampo(Palets.PAL_PaletsTransporte)


        Dim CMR_Lineas As New E_Cmr_lineas(Idusuario, cn)
        Actualizador.CreaCampo(CMR_Lineas.CML_PaletsTransporte, , "UPDATE CMR_Lineas SET CML_PaletsTransporte = CML_Palets")


        'Dim CentrosRecogida As New E_centrosrecogida(Idusuario, cn)
        'Actualizador.CreaCampo(CentrosRecogida.CER_CopiasValeAgricultor, "2")

        Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
        Actualizador.CreaCampo(ClientesDescargas.CLD_IdTransportista)

        Actualizador.CreaCampo(Palets_Lineas.PLL_IdCliente)

        Actualizador.CreaCampo(Clientes.CLI_NumeroRegistro)

        Actualizador.CreaCampo(TraspasosCentros.TCE_IdSemana, , "UPDATE TraspasosCentros SET TCE_IdSemana = COALESCE((SELECT SEV_IdSemana FROM SemanasPartes WHERE TCE_Fecha BETWEEN SEV_FechaInicialSalida AND SEV_FechaFinalSalida AND SEV_Ejercicio = TCE_Ejercicio),0)")

        Actualizador.CreaCampo(Pedidos.PED_TransporteRapidoSN, "N")

        Actualizador.CreaCampo(ClientesDescargas.CLD_TransporteRapidoSN, "N")


        'Actualizador.CreaCampo(Envases.ENV_Revisado, "N")
        Actualizador.CreaCampo(Envases.ENV_EnvaseRevisado, "0")

        Actualizador.CreaCampo(Lotes.LTE_IdProgramaCalidad)
        Actualizador.CreaCampo(LotesProduccion.LPD_IdProgramaCalidad)



        Actualizador.CreaCampo(ValoresUsuario.VUS_ImpresoraLotesControlados)
        Actualizador.CreaCampo(ValoresUsuario.VUS_ImpresoraLotesNoControlados)
        Actualizador.CreaCampo(ValoresUsuario.VUS_ImpresoraPaletSemitControlados)
        Actualizador.CreaCampo(ValoresUsuario.VUS_ImpresoraPaletSemitNoControlados)


        Actualizador.LongitudCampo(GenerosSalida.GES_Nombre)
        Actualizador.LongitudCampo(GenerosSalida.GES_DescripcionAlb)


        Actualizador.CreaCampo(FacturaAgr.FGR_AnnoFondo)


        Dim AportacionesExtraordinarias As New E_AportacionesExtraordinarias(Idusuario, cn)
        Actualizador.CreaTabla(AportacionesExtraordinarias)

        Actualizador.LongitudCampo(Envases.ENV_TaraEntrada)
        Actualizador.CreaCampo(Envases.ENV_EnvaseObsoleto, "N")



        Actualizador.CreaCampo(Palets.PAL_SufijoGGN1)
        Actualizador.CreaCampo(Palets.PAL_SufijoGGN2)
        Actualizador.CreaCampo(Palets.PAL_SufijoGGN3)
        Actualizador.CreaCampo(Palets.PAL_SufijoGGN4)


        Dim Conceptos346 As New E_Conceptos346(Idusuario, cn)
        Dim Fichero346 As New E_Fichero346(Idusuario, cn)


        Actualizador.CreaTabla(Conceptos346)
        Actualizador.CreaTabla(Fichero346)


        Dim Empresas As New E_Empresas(Idusuario, cn)
        Actualizador.CreaCampo(Empresas.EMP_Telefono)


        Actualizador.CreaCampo(AportacionesExtraordinarias.APX_AnnoFondo)


        Dim FacturasRecibidas As New E_Facturasrecibidas(Idusuario, cn)
        Actualizador.CreaCampo(FacturasRecibidas.FRR_FondoOperativo, "N")


        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
        'Dim lstVEV As New List(Of Cdatos.bdcampo)
        'lstVEV.Add(ValeEnvases.VEV_TipoSujeto)
        'lstVEV.Add(ValeEnvases.VEV_Codigo)
        'Actualizador.CreaIndice(lstVEV, "VEV_TipoSujeto_Codigo")


        Actualizador.CreaIndice(ValeEnvases.VEV_IdAlmacen, "VEV_IdAlmacen")
        Actualizador.CreaIndice(ValeEnvases.VEV_Fecha, "VEV_Fecha")
        Actualizador.CreaIndice(ValeEnvases_lineas.VEL_idenvase, "VEL_IdEnvase")
        Actualizador.CreaIndice(ValeEnvases_lineas.VEL_idvale, "VEL_IdVale")


        Dim Agricultores_IBAN As New E_Agricultores_IBAN(Idusuario, cn)
        Actualizador.CreaTabla(Agricultores_IBAN)


        'DAT
        Actualizador.CreaCampo(AlbEntrada.AEN_LocalizadorDAT)


        Actualizador.CreaCampo(Clientes.CLI_DatosEnCMR, "N")


        Actualizador.CreaCampo(ClientesDescargas.CLD_LugarEntregaCMR)


        Actualizador.CreaIndice(ValeEnvases.VEV_Fecha, "idx_VEV_Fecha")
        Actualizador.CreaIndice(Envases.ENV_IdAcreedorFianza, "idx_ENV_IdAcreedorFianza")


        Actualizador.LongitudCampo(ValeEnvases.VEV_Referencia)

		Dim FianzasEnvases As New E_FianzasEnvases(Idusuario, cn)
        Actualizador.CreaTabla(FianzasEnvases)

        Actualizador.CreaCampo(ValeEnvases_lineas.VEL_IdFacturaEnvase)
        Actualizador.CreaCampo(ValeEnvases_lineas.VEL_TipoEnvase)
        Actualizador.CreaCampo(ValeEnvases_lineas.VEL_PrecioFianza)


        Actualizador.LongitudCampo(CMR_Lineas.CML_envase)


        Actualizador.CreaCampo(Valorespventa.VPV_IdDestinoTransito, "", "UPDATE ValoresPVenta SET VPV_IdDestinoTransito = (CASE WHEN VPV_IdPVenta = 11 THEN 10 WHEN VPV_IdPVenta = 93 THEN 2 WHEN VPV_IdPVenta = 94 THEN 1 WHEN VPV_IdPVenta = 95 THEN 10 WHEN VPV_IdPVenta > 90 THEN VPV_IdPVenta - 90 WHEN VPV_IdPVenta < 90 THEN VPV_IdPVenta ELSE 0 END) ")


        Actualizador.CreaCampo(ValoresEjercicio.VEJ_Bloqueada, "N")


        If Not Actualizador.RealizaActualizaciones() Then
            bErrorFatal = True
        End If



        'CrearCamposLog(cn)


    End Sub


    Public Sub ActualizarDocumental_iArchiva()

        Dim Actualizador As New Actualizador(CnDoc)
        Dim ActualizadorAgro As New Actualizador(cn)


        Dim sql As String = "SELECT Name as Tabla FROM SYSOBJECTS WHERE xtype='U' AND Name Like 'Documentos_%'"
        Dim dt As DataTable = CnDoc.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows

                Dim tabla As String = (row("Tabla").ToString & "").Trim
                Dim tabla_empresa As String() = tabla.Split("_")
                If tabla_empresa.Length = 2 Then

                    Dim numero As String = tabla_empresa(1)
                    Dim nombre_campo As String = "IdiArchiva"


                    'Comprobamos si existe el índice
                    Dim bExisteCampo As Boolean = ExisteCampo(CnDoc, tabla, nombre_campo)


                    'Lo creamos si no existe
                    If Not bExisteCampo Then

                        sql = "ALTER TABLE " & tabla & " ADD " & nombre_campo & " NVARCHAR(250) COLLATE Modern_Spanish_CI_AS NOT NULL DEFAULT ''"
                        Actualizador.InstruccionSQL(sql)
                    End If


                End If
            Next
        End If


        If Not Actualizador.RealizaActualizaciones() Then
            bErrorFatal = True
        End If



        Actualizador = Nothing

    End Sub


    Public Sub ActualizarDocumental()


        Dim Actualizador As New Actualizador(CnDoc)
        Dim ActualizadorAgro As New Actualizador(cn)


        Dim sql As String = "SELECT Name as Tabla FROM SYSOBJECTS WHERE xtype='U' AND Name Like 'Documentos_%'"
        Dim dt As DataTable = CnDoc.ConsultaSQL(sql)
        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows

                Dim tabla As String = (row("Tabla").ToString & "").Trim
                Dim tabla_empresa As String() = tabla.Split("_")
                If tabla_empresa.Length = 2 Then

                    Dim numero As String = tabla_empresa(1)
                    Dim nombre_indice As String = "idx_DOC_" & numero & "_IdClave"


                    'Comprobamos si existe el índice
                    Dim bExisteIndice As Boolean = ExisteIndice(CnDoc, tabla, nombre_indice)
                    

                    'Lo creamos si no existe
                    If Not bExisteIndice Then
                        sql = "CREATE INDEX " & nombre_indice & " ON " & tabla & " (IdClave)"
                        Actualizador.InstruccionSQL(sql)
                    End If


                End If
            Next
        End If


        If Not Actualizador.RealizaActualizaciones() Then
            bErrorFatal = True
        End If




        Dim AlbSalida_Gastos As New E_albsalida_gastos(Idusuario, cn)
        Dim AlbSalida_Palets As New E_albsalida_palets(Idusuario, cn)
        Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
        Dim Palets_Traza As New E_palets_traza(Idusuario, cn)
        Dim Lotes_Lineas As New E_Lotes_lineas(Idusuario, cn)
        Dim LotesProduccion_Lineas As New E_LotesProduccion_Lineas(Idusuario, cn)


        Dim lst As New List(Of indice)
        lst.Add(New indice(AlbSalida_Gastos.ASG_idfactura, "idx_ASG_IdFactura"))
        lst.Add(New indice(AlbSalida_Gastos.ASG_idalbaran, "idx_ASG_IdAlbaran"))
        lst.Add(New indice(AlbSalida_Palets.ASP_IdAlbaran, "idx_ASP_IdAlbaran"))
        lst.Add(New indice(Palets_Lineas.PLL_idpalet, "idx_PLL_IdPalet"))
        lst.Add(New indice(Palets_Traza.PLT_idlineapalet, "idx_PLT_IdLineaPalet"))
        lst.Add(New indice(Palets_Traza.PLT_IdLineaEntrada, "idx_PLT_IdLineaEntrada"))
        lst.Add(New indice(Palets_Traza.PLT_idlote, "idx_PLT_IdLote"))
        lst.Add(New indice(Lotes_Lineas.LTL_Idlote, "idx_LTL_IdLote"))
        lst.Add(New indice(Lotes_Lineas.LTL_Idlineaentrada, "idx_LTL_IdLineaEntrada"))
        lst.Add(New indice(Palets_Traza.PLT_idprecalibrado, "idx_PLT_IdPrecalibrado"))
        lst.Add(New indice(LotesProduccion_Lineas.LPL_Idlote, "idx_LPL_IdLote"))
        lst.Add(New indice(LotesProduccion_Lineas.LPL_IdlineaEntrada, "idx_LPL_IdLineaEntrada"))
        lst.Add(New indice(LotesProduccion_Lineas.LPL_IdLotePartida, "idx_LPL_IdLotePartida"))



        For Each indice As indice In lst
            If Not ExisteIndice(cn, indice.tabla, indice.nombre_indice) Then
                sql = "CREATE INDEX " & indice.nombre_indice & " ON " & indice.tabla & " (" & indice.campo & ")"
                ActualizadorAgro.InstruccionSQL(sql)
            End If
        Next

        If Not ActualizadorAgro.RealizaActualizaciones() Then
            bErrorFatal = True
        End If


        

        Actualizador = Nothing


    End Sub


    Private Function ExisteIndice(conexion As Cdatos.Conexion, tabla As String, nombre_indice As String) As Boolean

        Dim bRes As Boolean = False


        Dim Sql As String = "SELECT ind.Name" & vbCrLf
        Sql = Sql & " FROM sys.columns cols, sys.indexes ind, sys.index_columns ind_cols"
        Sql = Sql & " WHERE (cols.object_id = ind.object_id And cols.object_id = ind_cols.object_id And cols.column_id = ind_cols.column_id)"
        Sql = Sql & " AND ind.index_id = ind_cols.index_id AND object_name(cols.object_id) = '" & tabla & "'"
        Sql = Sql & " AND ind.Name = '" & nombre_indice & "'"
        Sql = Sql & " ORDER BY key_ordinal"

        Dim dtIndice As DataTable = conexion.ConsultaSQL(Sql)
        If Not IsNothing(dtIndice) Then
            If dtIndice.Rows.Count > 0 Then
                bRes = True
            End If
        End If


        Return bRes


    End Function


    Private Function ExisteCampo(conexion As Cdatos.Conexion, tabla As String, nombre_campo As String) As Boolean

        Dim bRes As Boolean = False


        Dim sql As String = "Select syscolumns.length from syscolumns,sysobjects where sysobjects.name='" & _
                tabla & "' AND sysobjects.xtype='U' and syscolumns.id=sysobjects.id and syscolumns.name='" & _
                nombre_campo & "'"


        Dim dtIndice As DataTable = conexion.ConsultaSQL(sql)
        If Not IsNothing(dtIndice) Then
            If dtIndice.Rows.Count > 0 Then
                bRes = True
            End If
        End If


        Return bRes


    End Function


    'Private Sub CrearCamposLog(ByVal Conexion As Cdatos.Conexion)

    '    Dim Actualizador As New Actualizador(Conexion)
    '    For Each enti In Cdatos.ListaEntidades
    '        For Each c In enti.MiListadeCampos

    '            If InStr(c.NombreCampo, "IdUsuarioLog") > 0 Then
    '                Actualizador.CreaCampo(c)
    '            End If

    '            If InStr(c.NombreCampo, "FechaLog") > 0 Then
    '                Actualizador.CreaCampo(c)
    '            End If

    '            If InStr(c.NombreCampo, "HoraLog") > 0 Then
    '                Actualizador.CreaCampo(c)
    '            End If

    '        Next
    '    Next

    '    If Not Actualizador.RealizaActualizaciones() Then
    '        bErrorFatal = True
    '    End If

    'End Sub


    Public Sub ActuBaseDatos_ENERO(ByVal conexion As NetAgro.Cdatos.Conexion)

        Dim Actualizador As New Actualizador(conexion)



        Dim DocumentosBancos As New E_DocumentosBancos(Idusuario, cn)
        Actualizador.CreaTabla(DocumentosBancos)


        Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)
        Actualizador.CreaCampo(ValoresUsuario.VUS_ImpresoraLiquidaciones)
        Actualizador.CreaCampo(ValoresUsuario.VUS_ImpresoraTalones)


        Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)
        Actualizador.CreaCampo(TipoAgricultor.TPA_CtaContingencia)
        Actualizador.CreaCampo(TipoAgricultor.TPA_PorContingencia)


        Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)
        Actualizador.CreaCampo(FacturaAgr.FGR_PorContingencia)
        Actualizador.CreaCampo(FacturaAgr.FGR_CuotaContingencia)

        Dim Facturas As New E_Facturas(Idusuario, cn)
        Actualizador.CreaCampo(Facturas.FRA_Suplido)
        Actualizador.CreaCampo(Facturas.FRA_idacreedor)

        Dim palets_traza As New E_palets_traza(Idusuario, cn)
        Actualizador.CreaCampo(palets_traza.PLT_idprogramacliente)

        Dim Operarios As New E_Operarios(Idusuario, cn)
        Actualizador.CreaTabla(Operarios)

        Actualizador.CreaCampo(ValoresUsuario.VUS_ValidarOperario)


        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
        Dim ValeEnvases_Traspaso As New E_ValeEnvases_Traspaso(Idusuario, cn)
        Dim TraspasosCentros As New E_TraspasosCentros(Idusuario, cn)

        Actualizador.CreaCampo(ValeEnvases.VEV_Tractora)
        Actualizador.CreaCampo(ValeEnvases_Traspaso.VET_Tractora)
        Actualizador.CreaCampo(TraspasosCentros.TCE_Tractora)


        Dim Clientes As New E_Clientes(Idusuario, cn)
        Actualizador.CreaCampo(Clientes.CLI_Asegurado, "N")
        Actualizador.CreaCampo(Clientes.CLI_NumeroContrato)
        Actualizador.CreaCampo(Clientes.CLI_FechaSolicitud)
        Actualizador.CreaCampo(Clientes.CLI_ImporteSolicitado)
        Actualizador.CreaCampo(Clientes.CLI_ImporteConcedido)
        Actualizador.CreaCampo(Clientes.CLI_RiesgoMaximo)

        Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
        Actualizador.CreaCampo(Albentrada_his.AEH_idfacturafirme)


        Actualizador.CreaCampo(ValoresUsuario.VUS_ImpresoraCartelones)

        Dim Alertas As New E_Alertas(Idusuario, cn)
        Actualizador.LongitudCampo(Alertas.ALE_Email)


        Dim Pedidos As New E_Pedidos(Idusuario, cn)
        Actualizador.CreaCampo(Pedidos.PED_BESTELLNR)

        Actualizador.LongitudCampo(Clientes.CLI_CPostal)

        Actualizador.CreaCampo(Clientes.CLI_DesglosarLotes)

        Dim Palets As New E_palets(Idusuario, cn)
        Actualizador.CreaCampo(Palets.PAL_Lote)

        Dim Empresas As New E_Empresas(Idusuario, cn)
        Actualizador.CreaCampo(Empresas.EMP_Domicilio)
        Actualizador.CreaCampo(Empresas.EMP_CIF)

        Actualizador.CreaCampo(Palets.PAL_GGN1)
        Actualizador.CreaCampo(Palets.PAL_GGN2)
        Actualizador.CreaCampo(Palets.PAL_GGN3)
        Actualizador.CreaCampo(Palets.PAL_GGN4)

        Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Actualizador.CreaCampo(AlbEntrada_Lineas.AEL_RevisadaWeb, "N")

        Dim NoticiasWeb As New E_NoticiasWeb(Idusuario, cn)
        Actualizador.CreaTabla(NoticiasWeb)

        Dim UsuariosWeb As New E_UsuariosWeb(Idusuario, cn)
        Actualizador.CreaTabla(UsuariosWeb)

        Dim AlbEntrada_LineasCla As New E_AlbEntrada_lineascla(Idusuario, cn)
        Actualizador.LongitudCampo(AlbEntrada_LineasCla.ALC_kilosnetos)


        If Not Actualizador.RealizaActualizaciones() Then
            bErrorFatal = True
        End If


    End Sub




    Public Sub ActuBaseDatos_NOVIEMBRE(ByVal conexion As NetAgro.Cdatos.Conexion)

        Dim Actualizador As New Actualizador(conexion)



        Dim Cobros As New E_Cobros(Idusuario, cn)
        Actualizador.CreaTabla(Cobros)

        Dim CobrosLineas As New E_CobrosLineas(Idusuario, cn)
        Actualizador.CreaTabla(CobrosLineas)

        Dim ConceptosCobros As New E_ConceptosCobros(Idusuario, cn)
        Actualizador.CreaTabla(ConceptosCobros)

        Dim CobrosVencimientos As New E_CobrosVencimientos(Idusuario, cn)
        Actualizador.CreaTabla(CobrosVencimientos)


        Dim Empresas As New E_Empresas(Idusuario, cn)
        Actualizador.CreaTabla(Empresas)

        Dim albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
        Actualizador.CreaCampo(albentrada_his.AEH_idempresa, "1")




        ' borrar las tablas partesemanal y partesemanal_lineas

        Dim parteExistencias As New E_ParteExistencias(Idusuario, cn)
        Actualizador.CreaTabla(parteExistencias)
        Dim parteexistencias_lineas As New E_ParteExistencias_lineas(Idusuario, cn)
        Actualizador.CreaTabla(parteexistencias_lineas)


        ' borrar la tabla semanasvaloracion

        Dim SemanasPartes As New E_SemanasPartes(Idusuario, cn)
        Actualizador.CreaTabla(SemanasPartes)


        Dim albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
        Actualizador.CreaCampo(albsalida_lineas.ASL_estructura)
        Actualizador.CreaCampo(albsalida_lineas.ASL_manipulacion)
        Actualizador.CreaCampo(albsalida_lineas.ASL_materiales)
        Actualizador.CreaCampo(albsalida_lineas.ASL_gastoF)
        Actualizador.CreaCampo(albsalida_lineas.ASL_gastoC)
        ' borrar albsalida_lineascostes


        Dim Partes As New E_Partes(Idusuario, cn)
        Dim Partes_compras As New E_partes_Compras(Idusuario, cn)
        Dim Partes_ventas As New E_partes_Ventas(Idusuario, cn)

        Actualizador.CreaTabla(Partes)
        Actualizador.CreaTabla(Partes_compras)
        Actualizador.CreaTabla(Partes_ventas)


        Dim Facturas As New E_Facturas(Idusuario, cn)
        Actualizador.CreaCampo(Facturas.FRA_RefCliente)

        Dim Semanas_gastoconf As New E_Semanas_gastoconf(Idusuario, cn)
        Actualizador.CreaTabla(Semanas_gastoconf)

        Dim Generos As New E_Generos(Idusuario, cn)
        Actualizador.CreaCampo(Generos.GEN_GastoConfeccion)

        Dim CategoriaEntrada As New E_CategoriasEntrada(Idusuario, cn)
        Actualizador.CreaCampo(CategoriaEntrada.CAE_clasificacion)


        Dim ClientesDescargas As New E_ClientesDescargas(Idusuario, cn)
        Actualizador.CreaCampo(ClientesDescargas.CLD_OpcionEnvio, "E")

        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
        Actualizador.CreaCampo(AlbSalida.ASA_movilchofer)
        Actualizador.CreaCampo(AlbSalida.ASA_numregtemperatura)


        Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Actualizador.CreaCampo(AlbEntrada_Lineas.AEL_ObservacionesProveedor)


        Dim TiposDeCategoria As New E_TiposdeCategoria(Idusuario, cn)
        Actualizador.CreaCampo(TiposDeCategoria.TCA_Abreviatura)

        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Actualizador.CreaCampo(Agricultores.AGR_serie)


        Dim TraspasosCentros As New E_TraspasosCentros(Idusuario, cn)
        Actualizador.CreaCampo(TraspasosCentros.TCE_FechaCarga)
        Actualizador.CreaCampo(TraspasosCentros.TCE_HoraCarga)
        Actualizador.CreaCampo(TraspasosCentros.TCE_FechaDescarga)
        Actualizador.CreaCampo(TraspasosCentros.TCE_HoraDescarga)


        Dim Valeenvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
        Actualizador.CreaCampo(Valeenvases_lineas.VEL_MaterialPropio, "S")

        Dim PreciosRef As New E_PreciosRef(Idusuario, cn)
        Dim PreciosRef_lineas As New E_PreciosRef_Lineas(Idusuario, cn)

        Actualizador.CreaTabla(PreciosRef)
        Actualizador.CreaTabla(PreciosRef_lineas)

        Dim TarifasPortes As New E_TarifaPortes(Idusuario, cn)
        Actualizador.CreaTabla(TarifasPortes)


        Actualizador.CreaCampo(albsalida_lineas.ASL_tipoprecioestimado)
        ' ejecutar consulta update albsalida_lineas set asl_tipoprecioestimado=asl_tipoprecio where asl_tipoprecioestimado=''

        Dim Palets_lineas As New E_palets_lineas(Idusuario, cn)
        Actualizador.CreaCampo(Palets_lineas.PLL_CoeficientePalet)

        Actualizador.CreaCampo(ClientesDescargas.CLD_IdTarifaPortes)



        Actualizador.CreaCampo(albsalida_lineas.ASL_GastoPorte)
        Actualizador.CreaCampo(albsalida_lineas.ASL_CoeficientePalet)

        Actualizador.CreaCampo(ClientesDescargas.CLD_IdConfecPalet)

        Dim Clientes As New E_Clientes(Idusuario, cn)
        Actualizador.CreaCampo(Clientes.CLI_DatosActualizadosSN, "N")

        Dim ValoracionClasif As New E_ValoracionSemanal(Idusuario, cn)
        Actualizador.CreaTabla(ValoracionClasif)

        Dim ValoracionClasif_Lineas As New E_ValoracionSemanal_Lineas(Idusuario, cn)
        Actualizador.CreaTabla(ValoracionClasif_Lineas)

        Actualizador.CreaCampo(AlbEntrada_Lineas.AEL_IdValoracion)
        Actualizador.CreaCampo(AlbEntrada_Lineas.AEL_FechaValoracion)

        Actualizador.CreaCampo(Partes.PDS_IdValoracion)

        Actualizador.CreaCampo(Partes_compras.PDL_PrecioAprox)
        Actualizador.CreaCampo(Partes_compras.PDL_Disponible)
        Actualizador.CreaCampo(Partes_compras.PDL_PrecioLiquid)


        Actualizador.CreaCampo(ValoracionClasif.VSC_idgenero)

        Actualizador.CreaCampo(ValoracionClasif_Lineas.VSL_Kilos)


        Dim Previsiones As New E_Previsiones(Idusuario, cn)
        Dim Previsiones_Lineas As New E_Previsiones_lineas(Idusuario, cn)
        Actualizador.CreaTabla(Previsiones)
        Actualizador.CreaTabla(Previsiones_Lineas)
        Dim Albsalida_gastos As New E_albsalida_gastos(Idusuario, cn)

        Actualizador.CreaCampo(Albsalida_gastos.ASG_importefactura)

        Dim acreedores As New E_Acreedores(Idusuario, cn)


        Actualizador.CreaCampo(acreedores.ACR_CuentaGasto)

        Dim origengastos As New E_OrigenGastos(Idusuario, cn)
        Actualizador.CreaCampo(origengastos.ORG_cuenta)


        Dim ValeEnvases_Traspaso As New E_ValeEnvases_Traspaso(Idusuario, cn)
        Actualizador.CreaCampo(ValeEnvases_Traspaso.VET_IdTransportista)
        Actualizador.CreaCampo(ValeEnvases_Traspaso.VET_Matricula)

        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
        Actualizador.CreaCampo(ValeEnvases.VEV_IdTransportista)
        Actualizador.CreaCampo(ValeEnvases.VEV_Matricula)


        Dim Cargas_palet As New E_Cargas_Palets(Idusuario, cn)
        Actualizador.CreaCampo(Cargas_palet.CGL_hora)
        Actualizador.CreaCampo(Cargas_palet.CGL_nupalet)

        Dim cargas As New E_Cargas(Idusuario, cn)
        Actualizador.CreaCampo(cargas.CAR_idalbaran1)
        Actualizador.CreaCampo(cargas.CAR_idalbaran2)
        Actualizador.CreaCampo(cargas.CAR_idalbaran3)
        Actualizador.CreaCampo(cargas.CAR_idalbaran4)
        Actualizador.CreaCampo(cargas.CAR_idalbaran5)
        Actualizador.CreaCampo(cargas.CAR_idalbaran6)


        Actualizador.CreaCampo(AlbSalida.ASA_idcarga)

        Dim TipoAgricultor As New E_TipoAgricultor
        Actualizador.CreaCampo(TipoAgricultor.TPA_SocioHortichuelasSN)
        Actualizador.CreaCampo(TipoAgricultor.TPA_FondoOperativoSN)

        Dim partes_familias As New E_Partes_familias(Idusuario, cn)
        Actualizador.CreaTabla(partes_familias)

        Actualizador.CreaCampo(AlbEntrada_Lineas.AEL_Idparte)

        Dim palets As New E_palets(Idusuario, cn)

        Actualizador.CreaCampo(palets.PAL_finalizado, "S")



        Actualizador.CreaCampo(Partes_compras.PDL_KilosExIni)
        Actualizador.CreaCampo(Partes_compras.PDL_ImpExIni)
        Actualizador.CreaCampo(Partes_compras.PDL_KilosExFin)
        Actualizador.CreaCampo(Partes_compras.PDL_ImpExFin)

        Actualizador.CreaCampo(Partes_compras.PDL_idfamilia)

        Actualizador.CreaCampo(Partes.PDS_valorada, "N")

        Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)
        Actualizador.CreaTabla(FacturaAgr)

        Dim FacturaAgr_lineas As New E_FacturaAgr_lineas(Idusuario, cn)
        Actualizador.CreaTabla(FacturaAgr_lineas)


        Actualizador.CreaCampo(Facturas.FRA_idempresa, "1")
        Actualizador.CreaCampo(Cobros.COB_IdEmpresa, "1")
        Dim facturasrecibidas As New E_Facturasrecibidas(Idusuario, cn)
        Actualizador.CreaCampo(facturasrecibidas.FRR_IdEmpresa, "1")

        Actualizador.CreaCampo(Partes_compras.PDL_ImporteFAC)


        'TODO: Quitar programas de calidad
        Dim NormasCalidad As New E_NormasCalidad(Idusuario, cn)
        Actualizador.CreaTabla(NormasCalidad)

        Dim ProgramasCalidadTecnicos As New E_ProgramaCalidadTecnicos(Idusuario, cn)
        Actualizador.CreaTabla(ProgramasCalidadTecnicos)


        Dim Centrosrecogida As New E_centrosrecogida(Idusuario, cn)
        Actualizador.CreaCampo(Centrosrecogida.CER_IdAlmacenEnvases)


        Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)
        Actualizador.CreaCampo(ValoresUsuario.VUS_ImpresoraPartidaControlada)
        Actualizador.CreaCampo(ValoresUsuario.VUS_ImpresoraPartidaNoControlada)

        Actualizador.CreaCampo(AlbSalida.ASA_HoraSalida)


        Dim Pedidos As New E_Pedidos(Idusuario, cn)
        Actualizador.CreaCampo(Pedidos.PED_FechaLlegada)

        Actualizador.CreaCampo(FacturaAgr.FGR_idcentro, "1")

        Actualizador.CreaCampo(TipoAgricultor.TPA_ctaotros, "440100")

        Actualizador.CreaCampo(Agricultores.AGR_NoFacturar, "N")

        Dim AlbEntrada_HisLineas As New E_AlbEntrada_hislineas(Idusuario, cn)
        Actualizador.LongitudCampo(AlbEntrada_HisLineas.AHL_kilos)

        Actualizador.CreaCampo(Agricultores.AGR_idBanco, "1")

        Dim liquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)
        Actualizador.CreaTabla(liquidacionAgr)

        Actualizador.CreaCampo(acreedores.ACR_IdBanco)
        Actualizador.CreaCampo(acreedores.ACR_IdTipo)
        Actualizador.CreaCampo(acreedores.ACR_Dias)


        Actualizador.CreaCampo(liquidacionAgr.LIQ_DeFecha)
        Actualizador.CreaCampo(liquidacionAgr.LIQ_Afecha)


        

        If Not Actualizador.RealizaActualizaciones() Then
            bErrorFatal = True
        End If

    End Sub


    Public Sub ActuBaseDatos_Julio(ByVal conexion As NetAgro.Cdatos.Conexion)

        Dim Actualizador As New Actualizador(conexion)

        Dim Produccion As New E_Produccion(Idusuario, cn)
        Actualizador.CreaTabla(Produccion)

        Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Actualizador.CreaCampo(AlbEntrada_Lineas.AEL_IdUbicacionPV)

        Dim Lotes As New E_Lotes(Idusuario, cn)
        Actualizador.CreaCampo(Lotes.LTE_IdUbicacionPV)
        Actualizador.CreaCampo(Lotes.LTE_Calidad)
        Actualizador.CreaCampo(Lotes.LTE_FechaProducto)

        Dim TraspasosCentros As New E_TraspasosCentros(Idusuario, cn)
        Actualizador.CreaTabla(TraspasosCentros)

        Dim TraspasosCentros_Lineas As New E_TraspasosCentros_Lineas(Idusuario, cn)
        Actualizador.CreaTabla(TraspasosCentros_Lineas)

        Actualizador.CreaCampo(Lotes.LTE_IdEnvase)
        'Actualizador.CreaCampo(Lotes.LTE_KilosxBulto)


        Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
        Actualizador.CreaTabla(LotesProduccion)

        Dim LotesProduccion_Lineas As New E_LotesProduccion_Lineas(Idusuario, cn)
        Actualizador.CreaTabla(LotesProduccion_Lineas)

        Dim Lineas As New E_Lineas(Idusuario, cn)
        Actualizador.CreaCampo(Lineas.LIN_SoloPrecalibradoSN)

        Actualizador.CreaCampo(Produccion.PRD_IdLoteProduccion)


        Dim Palets_traza As New E_palets_traza(Idusuario, cn)
        Actualizador.CreaCampo(Palets_traza.PLT_idprecalibrado)

        Actualizador.CreaCampo(AlbEntrada_Lineas.AEL_campacultivo)


        Dim bloqueoCuentas As New E_BloqueoCuentas(Idusuario, cn)
        Actualizador.CreaTabla(bloqueoCuentas)


        Dim Valoresusuario As New E_valoresusuario(Idusuario, cn)
        Actualizador.CreaCampo(Valoresusuario.VUS_ImpresoraMuestreo)
        Actualizador.CreaCampo(Valoresusuario.VUS_ImpresoraAlbEntrada)


        Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
        Actualizador.CreaCampo(AlbEntrada.AEN_IdTransportista)

        Actualizador.CreaCampo(AlbEntrada_Lineas.AEL_Controlado)


        Actualizador.CreaCampo(Valoresusuario.VUS_ImpresoraValeEnvases)
        Actualizador.CreaCampo(Valoresusuario.VUS_ImpresoraLoteEntrada)
        Actualizador.CreaCampo(Valoresusuario.VUS_ImpresoraPaletSemiterminado)

        Actualizador.CreaCampo(LotesProduccion.LPD_Controlado)

        Actualizador.CreaCampo(Lotes.LTE_Controlado)

        Dim Palets_Lineas As New E_palets_lineas(Idusuario, cn)
        Actualizador.CreaCampo(Palets_Lineas.PLL_Controlado)


        Dim ValeEnvases_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
        Actualizador.CreaCampo(ValeEnvases_Lineas.VEL_Automatica)


        Dim BloqueoLineaFecha As New E_BloqueoLineaFecha(Idusuario, cn)
        Actualizador.CreaTabla(BloqueoLineaFecha)

        Actualizador.BorraCampo("Lotes", "LTE_KilosxBulto")


        'Dim Generos As New E_Generos(Idusuario, cn)
        'Actualizador.CreaCampo(Generos.GEN_IdGeneroTecnicos)


        Dim Cargas As New E_Cargas(Idusuario, cn)
        Dim Cargadores As New E_Cargadores(Idusuario, cn)
        Dim Conceptosinspeccion As New E_ConceptosInspeccion(Idusuario, cn)
        Dim ConceptosTransporte As New E_ConceptosTransporte(Idusuario, cn)
        'Dim Cargas_pedido As New E_Cargas_Pedido(Idusuario, cn)

        Dim Cargas_inspeccion As New E_Cargas_inspeccion(Idusuario, cn)

        Actualizador.CreaTabla(Cargas)
        Actualizador.CreaTabla(Cargadores)
        Actualizador.CreaTabla(Conceptosinspeccion)
        Actualizador.CreaTabla(ConceptosTransporte)
        'Actualizador.CreaTabla(Cargas_pedido)

        Actualizador.CreaTabla(Cargas_inspeccion)


        Dim cargas_palets As New E_Cargas_Palets(Idusuario, cn)
        Actualizador.CreaTabla(cargas_palets)


        Dim FamiliasDescuentos As New E_FamiliasDescuentos(Idusuario, cn)
        Actualizador.CreaCampo(FamiliasDescuentos.FAD_DtoBasculaFirmeSinClasif)

        Actualizador.CreaCampo(LotesProduccion.LPD_GP)


        Actualizador.CreaCampo(Cargas.CAR_idpedido1)
        Actualizador.CreaCampo(Cargas.CAR_idpedido2)
        Actualizador.CreaCampo(Cargas.CAR_idpedido3)
        Actualizador.CreaCampo(Cargas.CAR_idpedido4)
        Actualizador.CreaCampo(Cargas.CAR_idpedido5)
        Actualizador.CreaCampo(Cargas.CAR_idpedido6)

        Actualizador.CreaCampo(Lineas.LIN_PermitirPrecalibradoSN)

        Actualizador.CreaCampo(Produccion.PRD_KilosDestrio)


        Dim Albsalida As New E_AlbSalida(Idusuario, cn)
        Actualizador.CreaCampo(Albsalida.ASA_idtipoporte)




        If Not Actualizador.RealizaActualizaciones() Then
            bErrorFatal = True
        End If

    End Sub


    Public Sub ActuBaseDatosComun(ByVal conexion As NetAgro.Cdatos.Conexion)

        Dim Actualizador As New Actualizador(conexion)


        Dim Usuarios As New E_Usuarios(Idusuario, CnComun)
        Actualizador.CreaCampo(Usuarios.Login)
        Actualizador.LongitudCampo(Usuarios.Nombre)
        Actualizador.LongitudCampo(Usuarios.Pw)

        'Dim Configuracion As New E_Configuracion(Idusuario, CnComun)
        'Actualizador.CreaCampo(Configuracion.XmlDefectoSN, "N")


        If Not Actualizador.RealizaActualizaciones() Then
            bErrorFatal = True
        End If

    End Sub


    Public Sub ActuBaseDatos_JUNIO(ByVal conexion As NetAgro.Cdatos.Conexion)

        Dim Actualizador As New Actualizador(conexion)
        Dim valoresusuario As New E_valoresusuario(Idusuario, cn)
        Actualizador.CreaTabla(valoresusuario)



        Dim medianeria As New E_Medianeria(Idusuario, cn)
        Actualizador.CreaTabla(medianeria)

        Dim medianeria_lineas As New E_Medianeria_lineas(Idusuario, cn)
        Actualizador.CreaTabla(medianeria_lineas)

        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Actualizador.CreaTabla(Agricultores)


        Dim Observaciones As New E_Observaciones(Idusuario, cn)
        Actualizador.CreaTabla(Observaciones)

        Dim TipoAgricultor As New E_TipoAgricultor(Idusuario, cn)
        Actualizador.CreaTabla(TipoAgricultor)

        Dim GastosClientes As New E_GastosClientes(Idusuario, cn)
        Actualizador.CreaTabla(GastosClientes)




        Dim Lotes As New E_Lotes(Idusuario, cn)
        Actualizador.CreaTabla(Lotes)

        Dim Lotes_lineas As New E_Lotes_lineas(Idusuario, cn)
        Actualizador.CreaTabla(Lotes_lineas)

        'Dim Programacalidad As New E_ProgramaCalidad(Idusuario, cn)
        'Actualizador.CreaTabla(Programacalidad)

        Dim ClientesPrograma As New E_ClientesPrograma(Idusuario, cn)
        Actualizador.CreaTabla(ClientesPrograma)

        'Actualizador.CreaCampo(Programacalidad.PRO_Controlado)

        Actualizador.CreaCampo(Agricultores.AGR_tipofcs)
        ' borrar campo AEL_IDLOTE
        ' borrar campo LTE_tipolote

        Dim generoscategorias As New E_GenerosCategorias(Idusuario, cn)
        Actualizador.CreaTabla(generoscategorias)


        Dim Albentrada_hislineas As New E_AlbEntrada_hislineas(Idusuario, cn)
        Actualizador.CreaTabla(Albentrada_hislineas)

        Dim Albentrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)
        Actualizador.CreaTabla(Albentrada_lineascla)

        Dim albentrada As New E_AlbEntrada(Idusuario, cn)
        Actualizador.CreaTabla(albentrada)

        Dim albentrada_gastos As New E_albentrada_gastos(Idusuario, cn)
        Actualizador.CreaTabla(albentrada_gastos)

        Dim Albentrada_his As New E_AlbEntrada_his(Idusuario, cn)
        Actualizador.CreaTabla(Albentrada_his)

        Dim Albentrada_hisgastos As New E_albentrada_hisgastos(Idusuario, cn)
        Actualizador.CreaTabla(Albentrada_hisgastos)


        Dim Albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Actualizador.CreaTabla(Albentrada_lineas)


        Dim FamiliasCategorias As New E_FamiliasCategorias(Idusuario, cn)
        Actualizador.CreaCampo(FamiliasCategorias.FAC_idCategoriaComercial)

        Dim CatSalidaComercial As New E_CatSalidaComercial(Idusuario, cn)
        Actualizador.CreaTabla(CatSalidaComercial)

        Dim CategoriasComercial As New E_CategoriasComercial(Idusuario, cn)
        Actualizador.CreaTabla(CategoriasComercial)


        Dim Palets As New E_palets(Idusuario, cn)
        Actualizador.CreaTabla(Palets)

        Dim Palets_lineas As New E_palets_lineas(Idusuario, cn)
        Actualizador.CreaTabla(Palets_lineas)


        Dim palets_traza As New E_palets_traza(Idusuario, cn)
        Actualizador.CreaTabla(palets_traza)


        Actualizador.CreaCampo(Albentrada_hislineas.AHL_idlineacla)


        Dim Medidaspalets As New E_MedidasPalet(Idusuario, cn)
        Actualizador.CreaTabla(Medidaspalets)

        Dim SubfamiliaEnvases As New E_SubFamiliaEnvases(Idusuario, cn)
        Actualizador.CreaTabla(SubfamiliaEnvases)

        Dim EnvasesPalets As New E_EnvasesPalets(Idusuario, cn)
        Actualizador.CreaTabla(EnvasesPalets)


        Dim Envases As New E_Envases(Idusuario, cn)
        Actualizador.CreaCampo(Envases.ENV_idsubfamilia)
        Actualizador.CreaCampo(Envases.ENV_idmedida)
        Actualizador.CreaCampo(Envases.ENV_largo)
        Actualizador.CreaCampo(Envases.ENV_ancho)
        Actualizador.CreaCampo(Envases.ENV_alto)

        'BORRAR LA TABLA CONTACTOS
        Dim Contactos As New E_Contactos(Idusuario, cn)
        Actualizador.CreaTabla(Contactos)


        Dim CLIENTES As New E_Clientes(Idusuario, cn)
        Actualizador.CreaCampo(CLIENTES.CLI_idtipoporte)
        Actualizador.CreaCampo(CLIENTES.CLI_origendestino)
        Actualizador.CreaCampo(CLIENTES.CLI_emailalba1)
        Actualizador.CreaCampo(CLIENTES.CLI_emailalba2)
        Actualizador.CreaCampo(CLIENTES.CLI_emailalba3)
        Actualizador.CreaCampo(CLIENTES.CLI_emailped1)
        Actualizador.CreaCampo(CLIENTES.CLI_emailped2)
        Actualizador.CreaCampo(CLIENTES.CLI_emailped3)


        Dim clientesdescargas As New E_ClientesDescargas(Idusuario, cn)
        Actualizador.CreaCampo(clientesdescargas.CLD_idtipoporte)
        Actualizador.CreaCampo(clientesdescargas.CLD_origendestino)
        Actualizador.CreaCampo(clientesdescargas.CLD_emailalba1)
        Actualizador.CreaCampo(clientesdescargas.CLD_emailalba2)
        Actualizador.CreaCampo(clientesdescargas.CLD_emailalba3)
        Actualizador.CreaCampo(clientesdescargas.CLD_emailped1)
        Actualizador.CreaCampo(clientesdescargas.CLD_emailped2)
        Actualizador.CreaCampo(clientesdescargas.CLD_emailped3)


        Dim tiposporte As New E_TiposPorte(Idusuario, cn)
        Actualizador.CreaTabla(tiposporte)

        Actualizador.CreaCampo(clientesdescargas.CLD_numero)

        Dim TipoMaterial As New E_TipoMaterial(Idusuario, cn)
        Actualizador.CreaTabla(TipoMaterial)

        Actualizador.CreaCampo(Envases.ENV_idtipomaterial)

        Actualizador.CreaCampo(Contactos.COT_cargo)

        Dim marcas As New E_Marcas(Idusuario, cn)
        Actualizador.CreaCampo(marcas.MAR_Envase, "S")
        Actualizador.CreaCampo(marcas.MAR_Etiqueta, "S")
        Actualizador.CreaCampo(marcas.MAR_Material, "S")

        Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)

        Actualizador.CreaCampo(GenerosSalida.GES_idmarcaenvase)
        Actualizador.CreaCampo(GenerosSalida.GES_idmarcamaterial)
        Actualizador.CreaCampo(GenerosSalida.GES_idmarcaetiqueta)


        Actualizador.CreaCampo(Palets.PAL_materialpropio, "S")
        Actualizador.CreaCampo(Albentrada_lineas.AEL_materialpropio, "S")

        Dim pedidos As New E_Pedidos(Idusuario, cn)
        Dim pedidos_lineas As New E_Pedidos_lineas(Idusuario, cn)
        Dim pedidos_almacen As New E_pedidos_almacen(Idusuario, cn)
        Dim MensajesEntidades As New E_mensajesentidades(Idusuario, cn)
        Actualizador.CreaTabla(pedidos)
        Actualizador.CreaTabla(pedidos_lineas)
        Actualizador.CreaTabla(pedidos_almacen)
        Actualizador.CreaTabla(MensajesEntidades)

        Dim Lineas As New E_Lineas(Idusuario, cn)
        Dim Lineas_producto As New E_Lineas_producto(Idusuario, cn)

        Actualizador.CreaTabla(Lineas)
        Actualizador.CreaTabla(Lineas_producto)

        Actualizador.CreaCampo(TipoAgricultor.TPA_ctafondo)
        Actualizador.CreaCampo(TipoAgricultor.TPA_porfondo)
        Actualizador.CreaCampo(TipoAgricultor.TPA_porcomision)
        Actualizador.CreaCampo(TipoAgricultor.TPA_idgasto)
        Actualizador.CreaCampo(TipoAgricultor.TPA_tipofactura)
        Actualizador.CreaCampo(TipoAgricultor.TPA_compensa)


        Actualizador.CreaCampo(Agricultores.AGR_idenvases)
        Actualizador.CreaCampo(Agricultores.AGR_idcrecogida)
        Actualizador.CreaCampo(Agricultores.AGR_idempresa)
        Actualizador.CreaCampo(Agricultores.AGR_fechaaltaopfh)


        Dim Umedida As New E_Umedida(Idusuario, cn)
        Actualizador.CreaTabla(Umedida)

        Actualizador.CreaCampo(pedidos_lineas.PEL_generatrabajo)
        Actualizador.CreaCampo(pedidos_lineas.PEL_requiereaprobacion)

        Actualizador.CreaCampo(Envases.ENV_Udmedida)



        Actualizador.CreaCampo(pedidos_lineas.PEL_idgensal)


        Actualizador.CreaCampo(pedidos_lineas.PEL_idmarcaetiqueta)
        Actualizador.CreaCampo(pedidos_lineas.PEL_idmarcamaterial)

        Dim GruposMensajes As New E_GruposMensajes(Idusuario, cn)
        Actualizador.CreaTabla(GruposMensajes)

        Actualizador.CreaCampo(valoresusuario.VUS_idgrupomensajes)
        Actualizador.CreaCampo(MensajesEntidades.PMJ_Referencia)



        Actualizador.CreaCampo(GenerosSalida.GES_pedirmarcamat)
        Actualizador.CreaCampo(GenerosSalida.GES_pedirmarcaeti)

        Actualizador.CreaCampo(Palets_lineas.PLL_idpedidolinea)
        Actualizador.CreaCampo(Palets_lineas.PLL_calidad)
        ' borrar tabla generoscategorias.



        Actualizador.CreaCampo(clientesdescargas.CLD_calidad)
        Actualizador.CreaCampo(clientesdescargas.CLD_maxdias)
        Actualizador.CreaCampo(clientesdescargas.CLD_reservapalets)

        Actualizador.CreaCampo(pedidos_lineas.PEL_calidad)
        Actualizador.CreaCampo(pedidos_lineas.PEL_maxdias)
        Actualizador.CreaCampo(pedidos_lineas.PEL_reservapalets)


        Actualizador.CreaCampo(Palets_lineas.PLL_idmarcaeti)
        Actualizador.CreaCampo(Palets_lineas.PLL_idmarcamat)


        Actualizador.CreaCampo(Palets_lineas.PLL_TipoReserva)
        Actualizador.CreaCampo(GenerosSalida.GES_DescripcionAlb)


        Dim ConfecEnvaseLineas As New E_ConfecEnvaseLineas(Idusuario, cn)
        Actualizador.CreaCampo(ConfecEnvaseLineas.CEL_TipoEtiqueta)


        Actualizador.CreaCampo(Albentrada_lineas.AEL_IdPedidoLinea)
        Actualizador.CreaCampo(Albentrada_lineas.AEL_IdMarcaEtiqueta)
        Actualizador.CreaCampo(Albentrada_lineas.AEL_IdMarcaMaterial)
        Actualizador.CreaCampo(Albentrada_lineas.AEL_BultosxPalet)
        Actualizador.CreaCampo(Albentrada_lineas.AEL_KilosxBulto)
        Actualizador.CreaCampo(Albentrada_lineas.AEL_PiezasxBulto)
        Actualizador.CreaCampo(Albentrada_lineas.AEL_KilosCliente)
        Actualizador.CreaCampo(Albentrada_lineas.AEL_Calidad)


        If Not Actualizador.RealizaActualizaciones() Then
            bErrorFatal = True
        End If

    End Sub




    Public Sub ActuBaseDatos_FEB2015(ByVal Conexion As NetAgro.Cdatos.Conexion)


        Dim Actualizador As New Actualizador(Conexion)

        Dim ValeEnvases_lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
        Actualizador.CreaCampo(ValeEnvases_lineas.VEL_preciocoste)

        Dim Reclama As New E_Reclama(Idusuario, cn)
        Dim Reclama_origen As New E_Reclama_origen(Idusuario, cn)
        Dim Reclama_resolucion As New E_Reclama_resolucion(Idusuario, cn)

        Actualizador.CreaTabla(Reclama)
        Actualizador.CreaTabla(Reclama_origen)
        Actualizador.CreaTabla(Reclama_resolucion)

        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Dim Clientes As New E_Clientes(Idusuario, cn)
        Actualizador.CreaCampo(Clientes.CLI_Contrato)

        Dim ValoraImportaciones As New E_ValoraImportaciones(Idusuario, cn)
        Actualizador.CreaCampo(ValoraImportaciones.VAI_ImporteComision)

        Dim TiposClientes As New E_Tiposclientes(Idusuario, cn)
        Actualizador.CreaCampo(TiposClientes.TPC_GeneraAsiento, "S")


        Actualizador.CreaCampo(TiposClientes.TPC_ctanoretfac, "")
        Actualizador.CreaCampo(TiposClientes.TPC_ctanoretabo, "")


        Dim PermisosBotones As New E_PermisosBotones(Idusuario, cn)
        Actualizador.CreaTabla(PermisosBotones)


        Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)
        Actualizador.CreaCampo(ValoresUsuario.VUS_ImpresoraEmail_PDF)

        Dim FacturasLineasVar As New E_FacturasLineasVar(Idusuario, cn)
        Actualizador.LongitudCampo(FacturasLineasVar.FLV_precio)

        Dim ConsultasSql As New E_ConsultasSql(Idusuario, cn)
        Actualizador.CreaTabla(ConsultasSql)

        Dim Envases As New E_Envases(Idusuario, cn)
        Actualizador.CreaCampo(Envases.ENV_Inventariable)

        Dim ValeEnvases_Traspaso As New E_ValeEnvases_Traspaso(Idusuario, cn)
        Actualizador.CreaCampo(ValeEnvases_Traspaso.VET_IdAsientoNet)

        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
        Actualizador.LongitudCampo(ValeEnvases.VEV_Referencia)


        Dim RemesasFactoring As New E_RemesasFactoring(Idusuario, cn)
        Actualizador.CreaTabla(RemesasFactoring)

        Dim RemesasFactoring_Lineas As New E_RemesasFactoring_Lineas(Idusuario, cn)
        Actualizador.CreaTabla(RemesasFactoring_Lineas)


        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
        Actualizador.CreaCampo(AlbSalida.ASA_Factoring)

        Actualizador.CreaCampo(Clientes.CLI_IdFormaPago)

        Actualizador.CreaCampo(AlbSalida.ASA_IdVendedor)




        Dim ConsultaSalidas As New E_ConsultaSalidas(Idusuario, cn)
        Actualizador.CreaTabla(ConsultaSalidas)


        Dim Usuarios_logs As New E_Usuarios_Logs(Idusuario, cn)
        Actualizador.CreaTabla(Usuarios_logs)





        Dim Recuento_Lineas As New E_Recuento_Lineas(Idusuario, cn)
        Actualizador.CreaCampo(Recuento_Lineas.REL_PMC)

        Dim MotivosQueja As New E_MotivosQueja(Idusuario, cn)
        Actualizador.CreaTabla(MotivosQueja)

        Actualizador.CreaCampo(Reclama.RCL_IdMotivoQueja)

        Actualizador.LongitudCampo(Recuento_Lineas.REL_PMC)

        Dim ValoresPVenta As New E_valorespventa(Idusuario, cn)
        Actualizador.CreaCampo(ValoresPVenta.VPV_TextoContrato)



        If Not Actualizador.RealizaActualizaciones() Then
            bErrorFatal = True
        End If

        ' nueva tabla de grupos en comun
        ' nuevo campo idgrupo en datosusuarios de comun. Actualizar las entidades datosusuarios en contabilidad y financiero.

    End Sub


End Module
