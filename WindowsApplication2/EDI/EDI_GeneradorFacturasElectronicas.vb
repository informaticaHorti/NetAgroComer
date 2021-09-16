Imports System.IO

Namespace EDI


    Public MustInherit Class EDI_GeneradorFacturasElectronicas


        Public Proveedor As EDI.Comun.ProveedorEDI
        Public Facturas As New List(Of EDI_Factura)
        Public Carpeta_destino As String = "C:\Temp\"

        Public DatosEmpresa As New DatosEmpresa


        Public Sub New(Proveedor As EDI.Comun.ProveedorEDI, carpeta_destino As String)

            Me.Proveedor = Proveedor
            If Not carpeta_destino.EndsWith("\") Then carpeta_destino = carpeta_destino & "\"
            Me.Carpeta_destino = carpeta_destino

        End Sub



        Protected MustOverride Function Datos_a_Factura(dt As DataTable, dtGastosFactura As DataTable, dtLineas As DataTable, dtOtrosConceptos As DataTable, Optional IdIdioma As Integer = 1) As EDI_Factura
        Public MustOverride Function Resultado() As List(Of EDI_ArchivoSalida)
        Public MustOverride Function SubirArchivoFTP(ByVal archivo As String, ByVal url_ftp As String, ByVal carpeta_destino As String, ByVal usuario As String, ByVal clave As String) As Boolean


        Public Shared Function ObtenerGeneradorFacturas(proveedor As String, carpeta_destino_txt As String) As EDI.EDI_GeneradorFacturasElectronicas

            Select Case proveedor
                'Case "SERES"
                '    Return New SERES.SERES_GeneradorFacturaElectronica(carpeta_destino_txt)
                Case "EDICOM"
                    Return New EDICOM.EDICOM_GeneradorFacturaElectronica(carpeta_destino_txt)
                Case Else
                    Return Nothing
            End Select

        End Function


        Public Overridable Sub AñadirFactura(ByVal IdFactura As String, ByVal IdMensaje As String, Optional IdIdioma As Integer = 1)

            Dim CampaAlb As String = ""
            Dim dt As DataTable = ConsultaFactura(IdFactura, IdMensaje, CampaAlb)
            Dim dtGastosFactura As DataTable = ConsultaGastosFactura(IdFactura, CampaAlb)

            Dim dtOtrosConceptos As DataTable = Nothing
            Dim dtLineas As DataTable = ConsultaLineasFactura(IdFactura, CampaAlb, dtOtrosConceptos)

            Dim Factura As EDI_Factura = Datos_a_Factura(dt, dtGastosFactura, dtLineas, dtOtrosConceptos, IdIdioma)
            If Not IsNothing(Factura) Then Facturas.Add(Factura)

        End Sub


        Protected Overridable Function ConsultaFactura(IdFactura As String, IdMensaje As String, ByRef CampaAlb As String) As DataTable

            CampaAlb = ""


            'Datos cabecera factura

            Dim dt As DataTable = Tabla_SQL_CabeceraFactura(IdFactura)


            If Not IsNothing(dt) Then

                dt.Columns.Add("IdMensajeEDI", GetType(String))
                dt.Columns.Add("Empresa", GetType(String))
                dt.Columns.Add("Domicilio_empresa", GetType(String))
                dt.Columns.Add("Poblacion_empresa", GetType(String))
                dt.Columns.Add("CPostal_empresa", GetType(String))
                dt.Columns.Add("Provincia_empresa", GetType(String))
                dt.Columns.Add("NIF_Empresa", GetType(String))
                dt.Columns.Add("GLN_Emisor", GetType(String))
                dt.Columns.Add("GLN_Vendedor", GetType(String))
                dt.Columns.Add("RegistroMercantil", GetType(String))
                dt.Columns.Add("Codigo_pais_empresa_EDI", GetType(String))
                dt.Columns.Add("Telefono_empresa", GetType(String))
                dt.Columns.Add("Fax_empresa", GetType(String))

                For Each row As DataRow In dt.Rows

                    row("IdMensajeEDI") = IdMensaje
                    row("Empresa") = DatosEmpresa.EmpresaDatosFiscales
                    row("Domicilio_empresa") = DatosEmpresa.Domicilio
                    row("Poblacion_empresa") = DatosEmpresa.Poblacion
                    row("CPostal_empresa") = DatosEmpresa.CPostal
                    row("Provincia_empresa") = DatosEmpresa.Provincia
                    row("NIF_Empresa") = DatosEmpresa.NIF
                    row("GLN_Emisor") = DatosEmpresa.GLN_Emisor
                    row("GLN_Vendedor") = DatosEmpresa.GLN_Vendedor
                    row("RegistroMercantil") = DatosEmpresa.RegistroMercantil
                    row("Codigo_pais_empresa_EDI") = DatosEmpresa.CodigoPais_EDI
                    row("Telefono_empresa") = DatosEmpresa.Telefono1
                    row("Fax_empresa") = DatosEmpresa.Fax

                    CampaAlb = (row("CampaAlb").ToString & "").Trim

                Next

            End If


            Return dt

        End Function


        Protected Overridable Function ConsultaGastosFactura(IdFactura As String, ByVal CampaAlb As String) As DataTable


            'Dim AlbSalida_Gastos As New E_albsalida_gastos(Idusuario, cn)
            'Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
            'Dim GastosComercio As New E_GastosComercio(Idusuario, cn)


            'SELECT SUM(ASG_ImporteGastoDivisa) FROM AlbSalida_Gastos INNER JOIN AlbSalida ON ASG_IdAlbaran = ASA_IdAlbaran WHERE ASG_TipoFC = 'F' AND ASA_IdFactura = " & IdFactura

            'Gastos de facturas normales
            'Dim CONSULTA As New Cdatos.E_select
            'CONSULTA.SelCampo(AlbSalida_Gastos.ASG_id, "Id")
            'CONSULTA.SelCampo(AlbSalida_Gastos.ASG_tipokbp, "TipoGasto")
            'CONSULTA.SelCampo(AlbSalida_Gastos.ASG_valorgasto, "ValorGasto")
            'CONSULTA.SelCampo(GastosComercio.GCO_Nombre, "Descripcion", AlbSalida_Gastos.ASG_idgasto, GastosComercio.GCO_Idgasto)
            'CONSULTA.SelCampo(AlbSalida_Gastos.ASG_importegastodivisa, "ImpGastoDivisa")
            'CONSULTA.SelCampo(AlbSalida_Gastos.ASG_importegastoeuros, "ImpGastoEuros")
            'CONSULTA.SelCampo(AlbSalida.ASA_idfactura, "IdFactura", AlbSalida_Gastos.ASG_idalbaran, AlbSalida.ASA_idalbaran)
            'CONSULTA.WheCampo(AlbSalida.ASA_idfactura, "=", IdFactura)
            'CONSULTA.WheCampo(AlbSalida_Gastos.ASG_tipofc, "=", "F")

            'Dim sql As String = CONSULTA.SQL



            Dim NombreBdAgro As String = ObtenerBaseDatosConexionNetAgro(CampaAlb)

            Dim sql As String = "SELECT ASG_Id as Id, ASG_TipoKBP as TipoGasto, ASG_ValorGasto as ValorGasto, GCO_Nombre as Descripcion, ASG_ImporteGastoDivisa as ImpGastoDivisa, ASG_ImporteGastoEuros as ImpGastoEuros, ASA_IdFactura as IdFactura" & vbCrLf
            sql = sql & " FROM " & NombreBdAgro & ".dbo.AlbSalida_Gastos" & vbCrLf
            sql = sql & " LEFT JOIN " & NombreBdAgro & ".dbo.GastosComercio ON GCO_IdGasto = ASG_IdGasto" & vbCrLf
            sql = sql & " LEFT JOIN " & NombreBdAgro & ".dbo.AlbSalida ON ASA_IdAlbaran = ASG_IdAlbaran" & vbCrLf
            sql = sql & " WHERE ASG_TipoFC = 'F'" & vbCrLf
            sql = sql & " AND ASA_IdFactura = " & IdFactura & vbCrLf


            Dim dt As DataTable = cn.ConsultaSQL(sql)


            Return dt

        End Function


        Protected Overridable Function ConsultaLineasFactura(ByVal IdFactura As String, ByVal CampaAlb As String, ByRef dtOtrosConceptos As DataTable) As DataTable

            'Estructura de las líneas de la factura (en la impresión en papel):
            'Factura
            '   |
            '   ->Albaranes
            '   |   |
            '   |    -> Líneas de producto
            '   |   |
            '   |   -> Líneas de envases
            '   |   |
            '   |   -> Líneas de observaciones
            '   |   |
            '   |   -> Líneas de gastos
            '   |
            '   -> Líneas de otros conceptos (en factura)




            Dim dtAlbaranes As DataTable = Tabla_SQL_LineasFactura_Albaranes(IdFactura, CampaAlb)
            dtOtrosConceptos = Tabla_SQL_LineasFactura_OtrosConceptos(IdFactura)


            Return dtAlbaranes

        End Function



        Public Overridable Function GuardarArchivos(Optional codificacion As System.Text.Encoding = Nothing) As Dictionary(Of EDI_ArchivoSalida, String)

            If IsNothing(codificacion) Then
                codificacion = System.Text.Encoding.ASCII
            End If


            Dim DcArchivos As New Dictionary(Of EDI_ArchivoSalida, String)


            If Directory.Exists(Carpeta_destino) Then

                For Each archivo_salida As EDI_ArchivoSalida In Resultado()

                    Dim fichero As String = archivo_salida.IdMensaje & "_" & archivo_salida.Formato & ".txt"
                    If archivo_salida.Guardar(Carpeta_destino, fichero) Then
                        DcArchivos(archivo_salida) = Carpeta_destino & fichero
                    End If

                Next

            Else
                MsgBox("No existe la carpeta de destino " & Carpeta_destino)
            End If



            Return DcArchivos

        End Function


        Public Sub EnviarArchivosFTP(ByVal bBorrar As Boolean, ByVal url_ftp As String, ByVal carpeta_destino_ftp As String, ByVal usuario As String, ByVal clave As String)



            If Directory.Exists(Carpeta_destino) = True Then

                Dim DcArchivos As Dictionary(Of EDI_ArchivoSalida, String) = GuardarArchivos()
                If DcArchivos.Keys.Count > 0 Then

                    For Each archivo As EDI_ArchivoSalida In DcArchivos.Keys

                        Dim destino As String = DcArchivos(archivo)

                        Dim destino_ftp As String = carpeta_destino_ftp
                        If archivo.Carpeta_formato_ftp.Trim <> "" Then destino_ftp = destino_ftp & "/" & archivo.Carpeta_formato_ftp

                        If SubirArchivoFTP(destino, url_ftp, destino_ftp, usuario, clave) Then

                            If bBorrar Then
                                Try
                                    IO.File.Delete(destino)
                                Catch ex As Exception

                                    Try
                                        My.Computer.FileSystem.RenameFile(destino, destino & ".enviado")
                                    Catch ex2 As Exception
                                        MsgBox("Error al borrar/renombrar el archivo " & destino & vbCrLf & vbCrLf & ex2.Message)
                                    End Try

                                End Try
                            End If

                        Else
                            MsgBox("Error al subir via FTP el archivo " & destino)
                        End If

                    Next

                Else
                    MsgBox("No hay archivos para enviar en la carpeta temporal")
                End If

            Else
                MsgBox("No existe la carpeta temporal de facturas electrónicas " & Carpeta_destino)
            End If

        End Sub



        Protected Function Tabla_SQL_CabeceraFactura(ByVal IdFactura As String) As DataTable

            Dim dt As DataTable = Nothing


            If VaDec(IdFactura) > 0 Then

                'TotalGastosFra:
                'strGastos = "SELECT SUM(ASG_importegastodivisa) as gastos FROM AlbSalida_Gastos inner join albsalida on albsalida_gastos.asg_idalbaran = albsalida.asa_idalbaran WHERE ASG_TipoFC = 'F' AND asa_idfactura = " & idfactura

                Dim sql As String = "SELECT TOP 1 FRA_IdFactura as IdFactura, FRA_Serie as SerieFac, FRA_Factura as Factura, CLI_CodigoEdi as GLN_Cliente, '' as GLN_Descarga, CLI_FormatoEdi as FormatoEDI, CLI_CompradorEDI as GLN_Comprador," & vbCrLf
                sql = sql & " CLI_PagadorEDI as GLN_Pagador, FRA_Fecha as FechaFra, CLI_Nombre as Nombre, CLI_Domicilio as Domicilio, CLI_Poblacion as Poblacion, CLI_CPostal as CPostal, CLI_NIF as CIF," & vbCrLf
                sql = sql & " CLI_UsarReceptorComoClienteEDI as UsarReceptorComoClienteEDI, 0.00 as TotalGastosFra, FRA_FechaVto as FechaVto," & vbCrLf
                sql = sql & " FRA_Base1 as Base1, FRA_Base2 as Base2, FRA_Base3 as Base3, FRA_Base4 as Base4, FRA_Iva1 as Iva1, FRA_Iva2 as Iva2, FRA_Iva3 as Iva3, FRA_Iva4 as Iva4," & vbCrLf
                sql = sql & " FRA_Cuota1 as Cuota1, FRA_Cuota2 as Cuota2, FRA_Cuota3 as Cuota3, FRA_Cuota4 as Cuota4, FRA_Re1 as Re1, FRA_Re2 as Re2, FRA_Re3 as Re3, FRA_Re4 as Re4, " & vbCrLf
                sql = sql & " FRA_CuotaRe1 as CuotaRe1, FRA_CuotaRe2 as CuotaRe2, FRA_CuotaRe3 as CuotaRe3, FRA_CuotaRe4 as CuotaRe4, FRA_TotalFactura as TotalFactura," & vbCrLf
                'sql = sql & " FRA_TotalFactura as TotalFactura, TPC_Porre as PorRetencion," & vbCrLf
                sql = sql & " FRA_CampaAlb as CampaAlb, 0 as SerieAlb, 0 as Alb, '' as FechaLlegada, '' as RefPedido, '' as Pedido, '' as Departamento, FRA_Obs1 as Obs1, FRA_Obs2 as Obs2, CLI_ObservacionesFactura as Obs3" & vbCrLf
                sql = sql & " FROM Facturas" & vbCrLf
                sql = sql & " LEFT JOIN Clientes ON FRA_IdCliente = CLI_IdCliente " & vbCrLf
                'sql = sql & " LEFT JOIN TiposClientes ON TPC_IdTipo = CLI_IdTipo" & vbCrLf
                sql = sql & " WHERE FRA_idfactura = " & IdFactura

                dt = cn.ConsultaSQL(sql)
                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 0 Then

                        Dim rowFactura As DataRow = dt.Rows(0)

                        Dim CampaAlb As String = (rowFactura("CampaAlb").ToString & "").Trim
                        Dim NombreBdAgro As String = ObtenerBaseDatosConexionNetAgro(CampaAlb)

                        Dim sqlAlb As String = "SELECT TOP 1 CLD_CodigoEdi as GLN_Descarga, ASA_IdPuntoVenta as SerieAlb, ASA_Albaran as Alb, ASA_FechaSalida as FechaLlegada, ASA_Referencia as RefPedido, PED_Pedido as Pedido, ASA_Departamento as Departamento," & vbCrLf
                        sqlAlb = sqlAlb & " (SELECT SUM(ASG_ImporteGastoDivisa) FROM " & NombreBdAgro & ".dbo.AlbSalida_Gastos INNER JOIN " & NombreBdAgro & ".dbo.AlbSalida ON ASG_IdAlbaran = ASA_IdAlbaran WHERE ASG_TipoFC = 'F' AND ASA_IdFactura = " & IdFactura & ") as TotalGastosFra" & vbCrLf
                        sqlAlb = sqlAlb & " FROM " & NombreBdAgro & ".dbo.AlbSalida" & vbCrLf
                        sqlAlb = sqlAlb & " LEFT JOIN " & NombreBdAgro & ".dbo.ClientesDescargas ON CLD_Id = ASA_IdDomicilio" & vbCrLf
                        sqlAlb = sqlAlb & " LEFT JOIN " & NombreBdAgro & ".dbo.Pedidos ON PED_IdPedido = ASA_IdPedido" & vbCrLf
                        sqlAlb = sqlAlb & " WHERE ASA_IdFactura = " & IdFactura & vbCrLf

                        Dim dtAlb As DataTable = cn.ConsultaSQL(sqlAlb)
                        If Not IsNothing(dtAlb) Then
                            If dtAlb.Rows.Count > 0 Then

                                Dim rowAlbaran As DataRow = dtAlb.Rows(0)
                                rowFactura("GLN_Descarga") = rowAlbaran("GLN_Descarga")
                                rowFactura("TotalGastosFra") = rowAlbaran("TotalGastosFra")
                                rowFactura("SerieAlb") = rowAlbaran("SerieAlb")
                                rowFactura("Alb") = rowAlbaran("Alb")
                                rowFactura("FechaLlegada") = rowAlbaran("FechaLlegada")
                                rowFactura("RefPedido") = rowAlbaran("RefPedido")
                                rowFactura("Departamento") = rowAlbaran("Departamento")
                                rowFactura("Pedido") = (rowAlbaran("Pedido").ToString & "").Trim

                            End If
                        End If

                    End If
                End If

            End If


            Return dt

        End Function



        Protected Function Tabla_SQL_LineasFactura_Envases(ByVal IdFactura As String, ByVal CampaAlb As String) As DataTable


            Dim NombreBdAgro As String = ObtenerBaseDatosConexionNetAgro(CampaAlb)

            Dim sql As String = "SELECT VEL_IdEnvase as IdEnvase, SUM(VEL_Retira) as UdsEnvase, ENV_Nombre as NombreEnvase, VEL_PrecioRetira as PrecioEnv, " & vbCrLf
            sql = sql & " SUM(COALESCE(VEL_Retira,0) * COALESCE(VEL_PrecioRetira,0)) as ImporteEnv" & vbCrLf
            sql = sql & " FROM " & NombreBdAgro & ".dbo.AlbSalida" & vbCrLf
            sql = sql & " INNER JOIN " & NombreBdAgro & ".dbo.ValeEnvases ON ASA_IdValeEnvase = VEV_IdVale " & vbCrLf
            sql = sql & " INNER JOIN " & NombreBdAgro & ".dbo.ValeEnvases_Lineas ON VEV_IdVale = VEL_IdVale" & vbCrLf
            sql = sql & " INNER JOIN " & NombreBdAgro & ".dbo.Envases ON VEL_IdEnvase = ENV_IdEnvase" & vbCrLf
            sql = sql & " WHERE ASA_IdFactura = " & IdFactura & vbCrLf
            sql = sql & " AND VEL_PrecioRetira <> 0 " & vbCrLf
            sql = sql & " GROUP BY VEL_IdEnvase, ENV_Nombre, VEL_PrecioRetira" & vbCrLf
            sql = sql & " HAVING SUM(VEL_Retira) > 0" & vbCrLf


            Dim dt As DataTable = cn.ConsultaSQL(sql)


            Return dt

        End Function



        Protected Function Tabla_SQL_LineasFactura_Albaranes(ByVal IdFactura As String, ByVal CampaAlb As String) As DataTable


            Dim NombreBdAgro As String = ObtenerBaseDatosConexionNetAgro(CampaAlb)


            Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
            'Dim AlbSalida_Lineas As New E_AlbSalida_lineas(Idusuario, cn)
            'Dim Pedido As New E_Pedidos(Idusuario, cn)
            'Dim Generos As New E_Generos(Idusuario, cn)
            'Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
            'Dim ConfecEnvase As New E_ConfecEnvase(Idusuario, cn)
            'Dim Marcas As New E_Marcas(Idusuario, cn)
            'Dim ClientesEDI As New E_ClientesEDI(Idusuario, cn)
            'Dim AlbSalida_Gastos As New E_albsalida_gastos(Idusuario, cn)
            'Dim Facturas As New E_Facturas(Idusuario, cn)
            'Dim Pedidos As New E_Pedidos(Idusuario, cn)



            'Carga Detalle
            'Dim consulta As New Cdatos.E_select
            'consulta.SelCampo(AlbSalida_Lineas.ASL_idalbaran, "IdAlbaran")
            'consulta.SelCampo(AlbSalida_Lineas.ASL_idlinea, "IdLinea")
            'consulta.SelCampo(AlbSalida_Lineas.ASL_idgensal, "IdPresentacion")
            'Dim oCodigoArticuloEDI As New Cdatos.bdcampo("@(SELECT TOP 1 CED_CodigoEdi FROM CLIENTESEDI WHERE CED_IdCliente = ASA_IdCliente AND CED_IdGenero = ASL_IdGenero AND CED_IdPresentacion = ASL_IdGenSal)", ClientesEDI.CED_CodigoEdi.TipoBd, ClientesEDI.CED_CodigoEdi.Longitud)
            'consulta.SelCampo(oCodigoArticuloEDI, "CodigoArticuloEDI")
            'Dim oReferenciaCliente As New Cdatos.bdcampo("@(SELECT TOP 1 CED_ReferenciaCliente FROM CLIENTESEDI WHERE CED_IdCliente = ASA_IdCliente AND CED_IdGenero = ASL_IdGenero AND CED_IdPresentacion = ASL_IdGenSal)", ClientesEDI.CED_ReferenciaCliente.TipoBd, ClientesEDI.CED_ReferenciaCliente.Longitud)
            'consulta.SelCampo(oReferenciaCliente, "ReferenciaCliente")
            'consulta.SelCampo(AlbSalida.ASA_idalbaran, "IdAlbaran", AlbSalida_Lineas.ASL_idalbaran, AlbSalida.ASA_idalbaran)
            'consulta.SelCampo(AlbSalida.ASA_idvaleenvase, "IdValeEnvase")
            'consulta.SelCampo(Pedido.PED_pedido, "Pedido", AlbSalida.ASA_idpedido)
            'consulta.SelCampo(AlbSalida.ASA_fechasalida, "Fecha")
            'consulta.SelCampo(Pedido.PED_fechapedido, "FechaPedido")
            'consulta.SelCampo(Generos.GEN_NombreGenero, "Genero", AlbSalida_Lineas.ASL_idgenero, Generos.GEN_IdGenero)
            'consulta.SelCampo(ConfecEnvase.CEV_Nombre, "Confeccion", AlbSalida_Lineas.ASL_idtipoconfeccion)
            'consulta.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", AlbSalida_Lineas.ASL_idgensal, GenerosSalida.GES_Idgensal)
            'consulta.SelCampo(AlbSalida_Lineas.ASL_categoria, "Categoria")
            'consulta.SelCampo(AlbSalida_Lineas.ASL_bultosvendidos, "Bultos")
            'consulta.SelCampo(AlbSalida_Lineas.ASL_paletsvendidos, "Palets")
            'consulta.SelCampo(AlbSalida_Lineas.ASL_piezasvendidas, "Piezas")
            'consulta.SelCampo(AlbSalida_Lineas.ASL_kilosvendidos, "Kilos")
            'consulta.SelCampo(AlbSalida_Lineas.ASL_precioventa, "Precio")
            'consulta.SelCampo(AlbSalida_Lineas.ASL_tipoprecio, "TipoPrecio")
            'consulta.SelCampo(AlbSalida_Lineas.ASL_importegenerovta, "Importe")
            'consulta.SelCampo(AlbSalida.ASA_observaciones, "Observaciones")
            'consulta.SelCampo(AlbSalida.ASA_referencia, "Referencia")
            'consulta.SelCampo(AlbSalida.ASA_refvaloracion, "ReferenciaValoracion")
            'Dim oTotalImporteGeneroAlbaran As New Cdatos.bdcampo("@(SELECT SUM(ASL_ImporteGeneroVta) FROM AlbSalida_Lineas WHERE ASL_IdAlbaran = ASA_IdAlbaran)", Cdatos.TiposCampo.Importe, AlbSalida_Lineas.ASL_importegenerovta.Longitud, AlbSalida_Lineas.ASL_importegenerovta.Decimales)
            'consulta.SelCampo(oTotalImporteGeneroAlbaran, "TotalImporteGeneroAlbaran")
            'consulta.WheCampo(AlbSalida.ASA_idfactura, "=", IdFactura)


            'Dim sql As String = consulta.SQL


            Dim sql As String = "SELECT ASA_IdAlbaran as IdAlbaran, ASL_IdLinea as IdLinea, ASL_IdGenSal as IdPresentacion, " & vbCrLf
            sql = sql & " (SELECT TOP 1 CED_CodigoEDI FROM " & NombreBdAgro & ".dbo.ClientesEDI WHERE CED_IdCliente = ASA_IdCliente AND CED_IdGenero = ASL_IdGenero AND CED_IdPresentacion = ASL_IdGenSal) as CodigoArticuloEDI, " & vbCrLf
            sql = sql & " (SELECT TOP 1 CED_ReferenciaCliente FROM " & NombreBdAgro & ".dbo.ClientesEDI WHERE CED_IdCliente = ASA_IdCliente AND CED_IdGenero = ASL_IdGenero AND CED_IdPresentacion = ASL_IdGenSal) as ReferenciaCliente, " & vbCrLf
            sql = sql & " ASA_IdValeEnvase as IdValeEnvase, PED_Pedido as Pedido, ASA_FechaSalida as Fecha, PED_FechaPedido as FechaPedido, GEN_NombreGenero as Genero, CEV_Nombre as Confeccion, GES_Nombre as Presentacion, " & vbCrLf
            sql = sql & " ASL_Categoria as Categoria, ASL_BultosVendidos as Bultos, ASL_PaletsVendidos as Palets, ASL_PiezasVendidas as Piezas, ASL_KilosVendidos as Kilos, ASL_PrecioVenta as Precio,  " & vbCrLf
            sql = sql & " ASL_TipoPrecio as TipoPrecio, ASL_ImporteGeneroVta as Importe, ASA_Observaciones as Observaciones, ASA_Referencia as Referencia, ASA_RefValoracion as ReferenciaValoracion, " & vbCrLf
            sql = sql & " (SELECT SUM(ASL_ImporteGeneroVta) FROM " & NombreBdAgro & ".dbo.AlbSalida_Lineas WHERE ASL_IdAlbaran = ASA_IdAlbaran) as TotalImporteGeneroAlbaran " & vbCrLf
            sql = sql & " FROM " & NombreBdAgro & ".dbo.AlbSalida_Lineas" & vbCrLf
            sql = sql & " LEFT JOIN " & NombreBdAgro & ".dbo.AlbSalida ON ASA_IdAlbaran = ASL_IdAlbaran" & vbCrLf
            sql = sql & " LEFT JOIN " & NombreBdAgro & ".dbo.Pedidos ON PED_IdPedido = ASA_IdPedido" & vbCrLf
            sql = sql & " LEFT JOIN " & NombreBdAgro & ".dbo.Generos ON GEN_IdGenero = ASL_IdGenero" & vbCrLf
            sql = sql & " LEFT JOIN " & NombreBdAgro & ".dbo.ConfecEnvase ON ASL_IdTipoConfeccion = CEV_IdConfec" & vbCrLf
            sql = sql & " LEFT JOIN " & NombreBdAgro & ".dbo.GenerosSalida ON GES_IdGenSal = ASL_IdGenSal" & vbCrLf
            sql = sql & " WHERE ASA_IdFactura = " & IdFactura & vbCrLf


            Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(sql)


            If Not IsNothing(dt) Then

                dt.Columns.Add("GastoLinea", GetType(Decimal))
                dt.Columns.Add("ImporteNeto", GetType(Decimal))
                dt.Columns.Add("Cuota1", GetType(Decimal))
                dt.Columns.Add("CuotaRe1", GetType(Decimal))
                dt.Columns.Add("PrecioNeto", GetType(Decimal))

                dt = CalculaGastosLineaFactura(IdFactura, CampaAlb, dt)
                dt = CalculaPrecioNeto(dt)
                dt = CalculaImpuestosLineaFactura(IdFactura, dt)

            End If

            Return dt

        End Function



        Private Function CalculaGastosLineaFactura(ByVal IdFactura As String, ByVal CampaAlb As String, ByVal dt As DataTable) As DataTable

            Dim dtLineas As DataTable = dt.Copy
            Dim AlbSalida_Gastos As New E_albsalida_gastos(Idusuario, cn)


            If Not IsNothing(dtLineas) And VaDec(IdFactura) > 0 Then

                Dim NombreBdAgro As String = ObtenerBaseDatosConexionNetAgro(CampaAlb)

                Dim sql As String = "SELECT ASG_IdAlbaran as IdAlbaran, ASG_ValorGasto as ValorGasto, ASG_TipoKBP as Tipo, ASG_ImporteGastoDivisa as Importe" & vbCrLf
                sql = sql & " FROM " & NombreBdAgro & ".dbo.AlbSalida_Gastos" & vbCrLf
                sql = sql & " INNER JOIN " & NombreBdAgro & ".dbo.AlbSalida ON ASG_IdAlbaran = ASA_IdAlbaran WHERE ASG_TipoFC = 'F' AND ASA_IdFactura = " & IdFactura

                Dim dtGasto As DataTable = AlbSalida_Gastos.MiConexion.ConsultaSQL(sql)
                If Not IsNothing(dtGasto) Then

                    If dtGasto.Rows.Count > 0 Then

                        For Each rowGasto As DataRow In dtGasto.Rows

                            Dim Tipo As String = (rowGasto("Tipo").ToString & "").Trim
                            Dim Valor As Decimal = VaDec(rowGasto("ValorGasto"))
                            Dim Importe As Decimal = VaDec(rowGasto("Importe"))

                            'Línea con máximo de gasto (para diferencias)
                            Dim max_gasto As Decimal = 0
                            Dim max_row As DataRow = Nothing
                            Dim acum_gasto As Decimal = 0


                            'Repartimos entre las líneas
                            For Each row As DataRow In dtLineas.Rows

                                If VaDec(row("IdAlbaran")) = VaDec(rowGasto("IdAlbaran")) Then

                                    Dim Kilos As Decimal = VaDec(row("Kilos"))
                                    Dim Bultos As Integer = VaInt(row("Bultos"))
                                    Dim Palets As Integer = VaInt(row("Palets"))
                                    Dim ImporteGenero As Decimal = VaDec(row("Importe"))
                                    Dim TotalImporteGeneroAlbaran As Decimal = VaDec(row("TotalImporteGeneroAlbaran"))

                                    Dim GastoLinea As Decimal = 0

                                    Select Case Tipo

                                        Case "K"
                                            GastoLinea = GastoLinea + (Kilos * Valor)

                                        Case "B"
                                            GastoLinea = GastoLinea + Bultos * Valor

                                        Case "P"
                                            GastoLinea = GastoLinea + Palets * Valor

                                        Case "%"
                                            GastoLinea = GastoLinea + ImporteGenero * Valor / 100

                                        Case "I"
                                            GastoLinea = GastoLinea + (Valor * (ImporteGenero / TotalImporteGeneroAlbaran))

                                    End Select


                                    row("GastoLinea") = VaDec(row("GastoLinea")) + GastoLinea
                                    row("ImporteNeto") = row("Importe") - row("GastoLinea")
                                    acum_gasto = acum_gasto + GastoLinea

                                    If VaDec(row("GastoLinea")) > max_gasto Then
                                        max_gasto = VaDec(row("GastoLinea"))
                                        max_row = row
                                    End If

                                End If

                            Next

                            If acum_gasto <> Importe Then
                                max_row("GastoLinea") = max_row("GastoLinea") + (Importe - acum_gasto)
                                max_row("ImporteNeto") = max_row("Importe") - max_row("GastoLinea")
                            End If

                        Next


                    Else

                        If Not IsNothing(dtLineas) Then

                            For Each row In dtLineas.Rows
                                row("ImporteNeto") = row("Importe")
                            Next

                        End If


                    End If



                End If

                End If


                Return dtLineas


        End Function


        Private Function CalculaImpuestosLineaFactura(ByVal IdFactura As String, ByVal dt As DataTable) As DataTable

            Dim dtLineas As DataTable = dt.Copy
            Dim Facturas As New E_Facturas(Idusuario, cn)


            If VaDec(IdFactura) > 0 And Not IsNothing(dtLineas) Then

                Dim sql As String = "SELECT FRA_Iva1 as Iva1, FRA_Re1 as Re1 FROM Facturas WHERE FRA_IdFactura = " & IdFactura

                Dim dtIva As DataTable = Facturas.MiConexion.ConsultaSQL(sql)
                If Not IsNothing(dtIva) Then
                    If dtIva.Rows.Count > 0 Then

                        Dim Iva1 As Decimal = VaDec(dtIva.Rows(0)("Iva1"))
                        Dim Re1 As Decimal = VaDec(dtIva.Rows(0)("Re1"))

                        For Each row As DataRow In dtLineas.Rows

                            Dim ImporteNeto As Decimal = VaDec(row("ImporteNeto"))
                            Dim CuotaIva As Decimal = ImporteNeto * Iva1 / 100
                            Dim CuotaRe As Decimal = ImporteNeto * Re1 / 100
                            row("Cuota1") = CuotaIva
                            row("CuotaRe1") = CuotaRe

                        Next

                    End If
                End If


            End If



            Return dtLineas

        End Function


        Private Function CalculaPrecioNeto(ByVal dt As DataTable) As DataTable

            Dim dtLineas As DataTable = dt.Copy

            If Not IsNothing(dt) Then


                For Each row As DataRow In dtLineas.Rows


                    Dim PrecioNeto As Decimal = VaDec(row("Precio"))
                    Dim TipoPrecio As String = (row("TipoPrecio").ToString & "").Trim
                    Dim ImporteNeto As Decimal = VaDec(row("ImporteNeto"))
                    Dim Kilos As Decimal = VaDec(row("Kilos"))
                    Dim Bultos As Integer = VaInt(row("Bultos"))
                    Dim Piezas As Integer = VaInt(row("Piezas"))


                    Select Case TipoPrecio

                        Case "K"
                            PrecioNeto = ImporteNeto / Kilos

                        Case "B"
                            PrecioNeto = ImporteNeto / Bultos

                        Case "P"
                            PrecioNeto = ImporteNeto / Piezas


                    End Select

                    row("PrecioNeto") = PrecioNeto

                Next


            End If


            Return dtLineas

        End Function




        Public Shared Function Tabla_SQL_LineasFactura_OtrosConceptos(ByVal IdFactura As String) As DataTable

            Dim dt As New DataTable


            If VaDec(IdFactura) > 0 Then

                Dim FacturasLineasVar As New E_FacturasLineasVar(Idusuario, cn)


                Dim sql As String = "SELECT Codigo, Tipo, Concepto as OtrosConcepto, SUM(Cantidad) as OtrosCantidad, Precio as OtrosPrecio, SUM(Cantidad * Precio) as OtrosImporte " & vbCrLf
                sql = sql & " FROM" & vbCrLf
                sql = sql & " (" & vbCrLf
                sql = sql & " SELECT FLV_Codigo as Codigo, FLV_TipoGEC as Tipo, ENV_Nombre as Concepto, FLV_Cantidad as Cantidad, FLV_Precio as Precio" & vbCrLf
                sql = sql & " FROM Facturaslineasvar " & vbCrLf
                sql = sql & " INNER JOIN Envases ON FLV_Codigo = ENV_IdEnvase" & vbCrLf
                sql = sql & " WHERE FLV_TipoGEC = 'E' AND FLV_IdFactura = " & IdFactura & vbCrLf
                sql = sql & " UNION ALL" & vbCrLf
                sql = sql & " SELECT FLV_Codigo as Codigo, FLV_TipoGEC as Tipo, GEN_NombreGenero as Concepto, FLV_Cantidad as Cantidad, FLV_Precio as Precio" & vbCrLf
                sql = sql & " FROM FacturasLineasVar" & vbCrLf
                sql = sql & " INNER JOIN Generos ON FLV_Codigo = GEN_IdGenero" & vbCrLf
                sql = sql & " WHERE FLV_TipoGEC = 'G' AND FLV_IdFactura = " & IdFactura & vbCrLf
                sql = sql & " UNION ALL" & vbCrLf
                sql = sql & " SELECT FLV_Codigo as Codigo, FLV_TipoGEC as Tipo, COF_Nombre as Concepto, FLV_Cantidad as cantidad, FLV_Precio as Precio" & vbCrLf
                sql = sql & " FROM FacturasLineasVar" & vbCrLf
                sql = sql & " INNER JOIN ConceptosFactura ON FLV_Codigo = COF_IdConcepto" & vbCrLf
                sql = sql & " WHERE FLV_TipoGEC = 'C' AND FLV_IdFactura = " & IdFactura & vbCrLf
                sql = sql & " ) AS L" & vbCrLf
                sql = sql & " GROUP BY Codigo, Tipo, Concepto, Precio" & vbCrLf

                dt = FacturasLineasVar.MiConexion.ConsultaSQL(sql)


            End If



            Return dt

        End Function


    End Class


End Namespace

