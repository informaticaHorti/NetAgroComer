
Public Class FrmEscaneoPorLotes
    Inherits FrConsulta


    Public Class FileNameComparer
        Implements IComparer

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            Dim fi1 = DirectCast(x, IO.FileInfo)
            Dim fi2 = DirectCast(y, IO.FileInfo)

            If fi1.Name > fi2.Name Then Return 1
            If fi1.Name < fi2.Name Then Return -1
            Return 0
        End Function

    End Class




    Dim dt As New DataTable
    Dim cnDoc As New Cdatos.Conexion(cadenaconexiondoc)


    Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)

    Dim _ruta As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_BUZON_ENTRADA)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim Agricultores As New E_Agricultores(Idusuario, cn)
        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamChk(ChkBorrar, Nothing, "S", "N")


    End Sub


    Private Sub FrmEscaneoPorLotes_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        BtAux.Text = "Subir a G.Documental"
        BtAux.Width = 150
        BtAux.Image = My.Resources.App_ark_16x16_32
        BtAux.Visible = True

        LbRuta.Text = _ruta


        BInforme.Visible = False



    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        ChkBorrar.Checked = True

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()


        If IsNothing(dt) Then dt = New DataTable

        dt.Clear()


        If Not dt.Columns.Contains("Archivo") Then dt.Columns.Add("Archivo", GetType(String))
        If Not dt.Columns.Contains("Documento") Then dt.Columns.Add("Documento", GetType(String))
        If Not dt.Columns.Contains("Id") Then dt.Columns.Add("Id", GetType(Integer))
        If Not dt.Columns.Contains("Clave") Then dt.Columns.Add("Clave", GetType(String))
        If Not dt.Columns.Contains("S") Then
            Dim colSel As New DataColumn("S", GetType(Boolean))
            colSel.DefaultValue = True
            dt.Columns.Add(colSel)
        End If


        ProgressBar1.Value = 0


        If IO.Directory.Exists(_ruta) Then

            Dim Dir As New IO.DirectoryInfo(_ruta)
            Dim Archivos As IO.FileInfo() = Dir.GetFiles()

            Array.Sort(Archivos, New FileNameComparer)


            If Archivos.Length > 0 Then

                ProgressBar1.Maximum = Archivos.Length - 1

                For indice As Integer = 0 To Archivos.Length - 1

                    Dim archivo As IO.FileInfo = Archivos(indice)


                    Dim nombre As String = archivo.Name.Trim.ToString
                    If nombre.Trim.StartsWith("AUTO-") Then

                        Dim documento As String = ""
                        Dim id As String = ""
                        Dim clave As String = ""


                        If nombre.ToLower.Replace("auto-", "").Trim.Length > 2 Then
                            ObtenerDatosDocumento(nombre, documento, id, clave)
                        End If


                        Dim fila As DataRow = dt.NewRow()
                        fila("Archivo") = nombre
                        fila("Documento") = documento
                        fila("Id") = VaInt(id)
                        fila("Clave") = clave
                        dt.Rows.Add(fila)

                    End If


                    ProgressBar1.Value = indice

                    Application.DoEvents()

                Next


            End If

        End If




        Grid.DataSource = dt
        GridView1.BestFitColumns()


        'OJO con las mayúsculas / minúsculas



    End Sub


    Private Sub ObtenerDatosDocumento(nombre As String, ByRef documento As String, ByRef id As String, ByRef clave As String)

        documento = ""
        id = ""
        clave = ""


        Dim Tipo As String = ""
        If nombre.ToLower.StartsWith("auto-ver") Then
            Tipo = nombre.ToLower.Replace("auto-", "").Substring(0, 3).ToUpper()
        Else
            Tipo = nombre.ToLower.Replace("auto-", "").Substring(0, 2).ToUpper()
        End If


        Select Case Tipo

            Case "VER"

                Dim Versiones As New E_Versiones(Idusuario, cnFincasNET)
                Dim AgricultoresTec As New E_AgricultoresTec(Idusuario, cnFincasNET)
                documento = Versiones.DescripcionDocumental

                Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
                Dim Datos_guion As String() = Split(nombre_archivo, "-")
                Dim datos_archivo As String() = Split(Datos_guion(0).ToString, ".")

                Dim Campa As String = ""
                Dim IdAgricultor As String = ""
                Dim IdFamilia As String = ""
                Dim Version As String = ""


                If datos_archivo.Length > 0 Then Campa = VaInt(datos_archivo(0)).ToString
                If datos_archivo.Length > 1 Then IdAgricultor = (datos_archivo(1) & "").Trim
                If datos_archivo.Length > 2 Then IdFamilia = (datos_archivo(2) & "").Trim
                If datos_archivo.Length > 3 Then Version = (datos_archivo(3) & "").Trim

                If AgricultoresTec.LeerId(IdAgricultor) Then
                    id = (IdAgricultor & "").Trim
                    clave = AgricultoresTec.NombreBd & "|" & AgricultoresTec.NombreTabla & "|" & id
                End If


            Case "RT"
                'Visitas técnicos
                Dim Recetas As New E_RecetasTec(Idusuario, cnFincasNET)
                documento = Recetas.DescripcionDocumental

                Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
                Dim Datos_guion As String() = Split(nombre_archivo, "-")
                Dim datos_archivo As String() = Split(Datos_guion(0).ToString, ".")

                Dim Campa As String = ""
                Dim Serie As String = ""
                Dim Receta As Integer = 0

                If datos_archivo.Length > 0 Then Campa = VaInt(datos_archivo(0)).ToString
                If datos_archivo.Length > 1 Then Serie = (datos_archivo(1) & "").Trim
                If datos_archivo.Length > 2 Then Receta = VaInt(datos_archivo(2)).ToString


                If Recetas.LeerRecetaSerie(Serie, Receta) > 0 Then
                    id = (Recetas.RET_IdReceta.Valor & "").Trim
                    clave = Recetas.NombreBd & "|" & Recetas.NombreTabla & "|" & id
                End If


            Case "AE"

                Dim AlbEntrada As New E_AlbEntrada(Idusuario, cn)
                documento = AlbEntrada.DescripcionDocumental

                Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
                Dim Datos_guion As String() = Split(nombre_archivo, "-")
                Dim datos_archivo As String() = Split(Datos_guion(0).ToString, ".")

                Dim Campa As String = ""
                Dim Albaran As String = ""
                Dim Pagina As String = ""

                If datos_archivo.Length > 0 Then Campa = VaInt(datos_archivo(0)).ToString
                If datos_archivo.Length > 1 Then Albaran = VaInt(datos_archivo(1)).ToString
                If datos_archivo.Length > 2 Then Pagina = VaInt(datos_archivo(2)).ToString



                If AlbEntrada.LeerAlb(Campa, MiMaletin.IdCentro, Albaran) > 0 Then
                    id = (AlbEntrada.AEN_IdAlbaran.Valor & "").Trim
                    clave = AlbEntrada.NombreBd & "|" & AlbEntrada.NombreTabla & "|" & id
                End If

            Case "FC"

                Dim Facturas As New E_Facturas(Idusuario, cn)
                documento = Facturas.DescripcionDocumental

                Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower & ".", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
                Dim Datos_guion As String() = Split(nombre_archivo, "-")
                Dim datos_archivo As String() = Split(Datos_guion(0).ToString, ".")

                Dim IdEmpresa As String = ""
                Dim Campa As String = ""
                Dim Serie As String = ""
                Dim Factura As String = ""
                Dim Pagina As String = ""

                If datos_archivo.Length > 0 Then IdEmpresa = VaInt(datos_archivo(0)).ToString
                If datos_archivo.Length > 1 Then Campa = VaInt(datos_archivo(1)).ToString
                If datos_archivo.Length > 2 Then Serie = datos_archivo(2).ToString
                If datos_archivo.Length > 3 Then Factura = VaInt(datos_archivo(3)).ToString
                If datos_archivo.Length > 4 Then Pagina = VaInt(datos_archivo(4)).ToString

                If Facturas.LeerFac(IdEmpresa, Campa, Serie, Factura) > 0 Then
                    id = (Facturas.FRA_idfactura.Valor & "").Trim
                    clave = Facturas.NombreBd & "|" & Facturas.NombreTabla & "|" & id
                End If


            Case "FG"

                Dim FacturaAgr As New E_FacturaAgr(Idusuario, cn)
                documento = FacturaAgr.DescripcionDocumental

                Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower & ".", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
                Dim Datos_guion As String() = Split(nombre_archivo, "-")
                Dim datos_archivo As String() = Split(Datos_guion(0).ToString, ".")

                Dim IdEmpresa As String = ""
                Dim Campa As String = ""
                Dim Serie As String = ""
                Dim Factura As String = ""
                Dim Pagina As String = ""

                If datos_archivo.Length > 0 Then IdEmpresa = VaInt(datos_archivo(0)).ToString
                If datos_archivo.Length > 1 Then Campa = VaInt(datos_archivo(1)).ToString
                If datos_archivo.Length > 2 Then Serie = datos_archivo(2).ToString
                If datos_archivo.Length > 3 Then Factura = VaInt(datos_archivo(3)).ToString
                If datos_archivo.Length > 4 Then Pagina = VaInt(datos_archivo(4)).ToString


                If FacturaAgr.LeerFactura(IdEmpresa, Campa, Serie, Factura) > 0 Then
                    id = (FacturaAgr.FGR_Idfactura.Valor & "").Trim
                    clave = FacturaAgr.NombreBd & "|" & FacturaAgr.NombreTabla & "|" & id
                End If


            Case "LQ"

                documento = "Factura de Agricultor"

                Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower & ".", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
                Dim Datos_guion As String() = Split(nombre_archivo, "-")
                Dim datos_archivo As String() = Split(Datos_guion(0).ToString, ".")

                Dim IdEmpresa As String = ""
                Dim Campa As String = ""
                Dim Serie As String = ""
                Dim Factura As String = ""
                Dim Pagina As String = ""

                If datos_archivo.Length > 0 Then IdEmpresa = VaInt(datos_archivo(0)).ToString
                If datos_archivo.Length > 1 Then Campa = VaInt(datos_archivo(1)).ToString
                If datos_archivo.Length > 2 Then Serie = datos_archivo(2).ToString
                If datos_archivo.Length > 3 Then Factura = VaInt(datos_archivo(3)).ToString
                If datos_archivo.Length > 4 Then Pagina = VaInt(datos_archivo(4)).ToString


                Dim LiquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)
                If LiquidacionAgr.LeerLiquidacion(IdEmpresa, Campa, Serie, Factura) > 0 Then
                    id = (LiquidacionAgr.LIQ_Idliquidacion.Valor & "").Trim
                    clave = LiquidacionAgr.NombreBd & "|" & LiquidacionAgr.NombreTabla & "|" & id
                End If


            Case "AS"

                Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
                documento = AlbSalida.DescripcionDocumental

                Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
                Dim Datos_guion As String() = Split(nombre_archivo, "-")
                Dim datos_archivo As String() = Split(Datos_guion(0).ToString, ".")

                Dim Campa As String = ""
                Dim Albaran As String = ""
                Dim Pagina As String = ""

                If datos_archivo.Length > 0 Then Campa = VaInt(datos_archivo(0)).ToString
                If datos_archivo.Length > 1 Then Albaran = VaInt(datos_archivo(1)).ToString
                If datos_archivo.Length > 2 Then Pagina = VaInt(datos_archivo(2)).ToString



                If AlbSalida.LeerAlb(Campa, MiMaletin.IdCentro, Albaran) > 0 Then
                    id = (AlbSalida.ASA_idalbaran.Valor & "").Trim
                    clave = AlbSalida.NombreBd & "|" & AlbSalida.NombreTabla & "|" & id
                End If


            Case "PA"
                documento = "Boletín de Muestreo"

                Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
                Dim Datos_guion As String() = Split(nombre_archivo, "-")
                Dim datos_archivo As String() = Split(Datos_guion(0).ToString, ".")

                Dim Campa As String = ""
                Dim Muestreo As String = ""
                Dim Pagina As String = ""

                If datos_archivo.Length > 0 Then Campa = VaInt(datos_archivo(0)).ToString
                If datos_archivo.Length > 1 Then Muestreo = VaInt(datos_archivo(1)).ToString
                If datos_archivo.Length > 2 Then Pagina = VaInt(datos_archivo(2)).ToString


                Dim AlbEntrada_Lineas As New E_AlbEntrada_lineas(Idusuario, cn)

                Dim IdLinea As Integer = AlbEntrada_Lineas.LeerMuestreo(Campa, Muestreo)
                If IdLinea > 0 Then
                    If AlbEntrada_Lineas.LeerId(IdLinea) Then
                        id = (AlbEntrada_Lineas.AEL_idlinea.Valor & "").Trim
                        clave = AlbEntrada_Lineas.NombreBd & "|" & AlbEntrada_Lineas.NombreTabla & "|" & id
                    End If
                End If


            Case "LE"

                Dim Lotes As New E_Lotes(Idusuario, cn)
                documento = Lotes.DescripcionDocumental

                Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
                Dim Datos_guion As String() = Split(nombre_archivo, "-")
                Dim datos_archivo As String() = Split(Datos_guion(0).ToString, ".")

                Dim Campa As String = ""
                Dim NumLote As String = ""
                Dim Pagina As String = ""

                If datos_archivo.Length > 0 Then Campa = VaInt(datos_archivo(0)).ToString
                If datos_archivo.Length > 1 Then NumLote = VaInt(datos_archivo(1)).ToString
                If datos_archivo.Length > 2 Then Pagina = VaInt(datos_archivo(2)).ToString


                If Lotes.LeerLote(Campa, NumLote) > 0 Then
                    id = (Lotes.LTE_Idlote.Valor & "").Trim
                    clave = Lotes.NombreBd & "|" & Lotes.NombreTabla & "|" & id
                End If


            Case "PS"

                Dim LotesProduccion As New E_LotesProduccion(Idusuario, cn)
                documento = LotesProduccion.DescripcionDocumental

                Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
                Dim Datos_guion As String() = Split(nombre_archivo, "-")
                Dim datos_archivo As String() = Split(Datos_guion(0).ToString, ".")

                Dim Campa As String = ""
                Dim NumLote As String = ""
                Dim Pagina As String = ""

                If datos_archivo.Length > 0 Then Campa = VaInt(datos_archivo(0)).ToString
                If datos_archivo.Length > 1 Then NumLote = VaInt(datos_archivo(1)).ToString
                If datos_archivo.Length > 2 Then Pagina = VaInt(datos_archivo(2)).ToString


                If LotesProduccion.LeerLote(Campa, NumLote) > 0 Then
                    id = (LotesProduccion.LPD_Idlote.Valor & "").Trim
                    clave = LotesProduccion.NombreBd & "|" & LotesProduccion.NombreTabla & "|" & id
                End If


            Case "TP"
                documento = "Ticket Palet"

                Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
                Dim Datos_guion As String() = Split(nombre_archivo, "-")
                Dim datos_archivo As String() = Split(Datos_guion(0).ToString, ".")

                Dim Campa As String = ""
                Dim NumPalet As String = ""
                Dim Pagina As String = ""

                If datos_archivo.Length > 0 Then Campa = VaInt(datos_archivo(0)).ToString
                If datos_archivo.Length > 1 Then NumPalet = VaInt(datos_archivo(1)).ToString
                If datos_archivo.Length > 2 Then Pagina = VaInt(datos_archivo(2)).ToString


                Dim Palets As New E_palets(Idusuario, cn)
                If Palets.Leerpalet(Campa, MiMaletin.IdCentro, NumPalet) > 0 Then

                    id = (Palets.PAL_idpalet.Valor & "").Trim
                    clave = Palets.NombreBd & "|" & Palets.NombreTabla & "|" & id

                End If


            Case "VT"

                Dim ValeEnvases_Traspaso As New E_ValeEnvases_Traspaso(Idusuario, cn)
                documento = ValeEnvases_Traspaso.DescripcionDocumental

                Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
                Dim Datos_guion As String() = Split(nombre_archivo, "-")
                Dim datos_archivo As String() = Split(Datos_guion(0).ToString, ".")

                Dim Campa As String = ""
                Dim NumVale As String = ""
                Dim Pagina As String = ""

                If datos_archivo.Length > 0 Then Campa = VaInt(datos_archivo(0)).ToString
                If datos_archivo.Length > 1 Then NumVale = VaInt(datos_archivo(1)).ToString
                If datos_archivo.Length > 2 Then Pagina = VaInt(datos_archivo(2)).ToString


                If ValeEnvases_Traspaso.LeerVale(Campa, MiMaletin.IdCentro, NumVale) > 0 Then
                    id = (ValeEnvases_Traspaso.VET_Idvale.Valor & "").Trim
                    clave = ValeEnvases_Traspaso.NombreBd & "|" & ValeEnvases_Traspaso.NombreTabla & "|" & id
                End If


            Case "EB", "AA", "RI", "CC", "SA", "SC", "SM", "DV", "AC"

                Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
                documento = ValeEnvases.DescripcionDocumental

                Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
                Dim Datos_guion As String() = Split(nombre_archivo, "-")
                Dim datos_archivo As String() = Split(Datos_guion(0).ToString, ".")

                Dim Operacion As String = Tipo
                Dim Campa As String = ""
                Dim NumVale As String = ""
                Dim Pagina As String = ""

                'If datos_archivo.Length > 0 Then Operacion = datos_archivo(0)
                If datos_archivo.Length > 0 Then Campa = VaInt(datos_archivo(0)).ToString
                If datos_archivo.Length > 1 Then NumVale = VaInt(datos_archivo(1)).ToString
                'If datos_archivo.Length > 3 Then Pagina = VaInt(datos_archivo(3)).ToString


                If ValeEnvases.LeerVale(Campa, MiMaletin.IdCentro, Operacion, NumVale) > 0 Then
                    id = (ValeEnvases.VEV_Idvale.Valor & "").Trim
                    clave = ValeEnvases.NombreBd & "|" & ValeEnvases.NombreTabla & "|" & id
                End If


            Case "CM"

                'OJO: No asociar a la entidad CMR sino al albarán de salida

                Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
                documento = AlbSalida.DescripcionDocumental



                Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
                Dim Datos_guion As String() = Split(nombre_archivo, "-")
                Dim datos_archivo As String() = Split(Datos_guion(0).ToString, ".")


                Dim Campa As String = ""
                Dim IdCentro As String = ""
                Dim Albaran As String = ""
                Dim Pagina As String = ""

                If datos_archivo.Length > 0 Then Campa = VaInt(datos_archivo(0)).ToString
                If datos_archivo.Length > 1 Then IdCentro = VaInt(datos_archivo(1)).ToString
                If datos_archivo.Length > 2 Then Albaran = VaInt(datos_archivo(2)).ToString
                If datos_archivo.Length > 3 Then Pagina = VaInt(datos_archivo(3)).ToString


                If AlbSalida.LeerAlb(Campa, IdCentro, Albaran) > 0 Then
                    id = (AlbSalida.ASA_idalbaran.Valor & "").Trim
                    clave = AlbSalida.NombreBd & "|" & AlbSalida.NombreTabla & "|" & id
                End If



            Case "PP"

                Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
                Dim Datos_guion As String() = Split(nombre_archivo, "-")
                Dim datos_archivo As String() = Split(Datos_guion(0).ToString, "_")
                Dim datos_pago As String() = Split(datos_archivo(0).ToString, ".")


                Dim IdEmpresa As String = ""
                Dim IdPago As String = ""
                Dim cheque_pagare As String = ""

                If datos_pago.Length > 0 Then IdEmpresa = VaInt(datos_pago(0)).ToString
                If datos_pago.Length > 1 Then IdPago = VaInt(datos_pago(1)).ToString
                If datos_pago.Length > 2 Then cheque_pagare = (datos_pago(2) & "").Trim.ToUpper



                Dim Pagos As New E_Pagos(Idusuario, ConexCtb(VaInt(IdEmpresa)))
                documento = Pagos.DescripcionDocumental



                If Pagos.LeerId(IdPago) Then
                    id = (Pagos.IdPago.Valor & "").Trim
                    clave = Pagos.NombreBd & "|" & Pagos.NombreTabla & "|" & id
                End If



            Case "PE"

                Dim Pedidos As New E_Pedidos(Idusuario, cn)
                documento = Pedidos.DescripcionDocumental



                Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
                Dim Datos_guion As String() = Split(nombre_archivo, "-")
                Dim datos_archivo As String() = Split(Datos_guion(0).ToString, ".")


                Dim Campa As String = ""
                Dim IdCentro As String = ""
                Dim NumPedido As String = ""
                Dim Pagina As String = ""

                If datos_archivo.Length > 0 Then Campa = VaInt(datos_archivo(0)).ToString
                If datos_archivo.Length > 1 Then IdCentro = VaInt(datos_archivo(1)).ToString
                If datos_archivo.Length > 2 Then NumPedido = VaInt(datos_archivo(2)).ToString
                If datos_archivo.Length > 3 Then Pagina = VaInt(datos_archivo(3)).ToString


                If Pedidos.LeerPedido(Campa, IdCentro, NumPedido) > 0 Then
                    id = (Pedidos.PED_idpedido.Valor & "").Trim
                    clave = Pedidos.NombreBd & "|" & Pedidos.NombreTabla & "|" & id
                End If



        End Select




    End Sub


    Public Overrides Sub GridClik(row As System.Data.DataRow, column As DevExpress.XtraGrid.Columns.GridColumn)
        MyBase.GridClik(row, column)


        If Not IsNothing(row) Then

            If row("S") = True Then
                row("S") = False
            Else
                row("S") = True
            End If

        End If

    End Sub


    Private Sub btSelNinguno_Click(sender As System.Object, e As System.EventArgs) Handles btSelNinguno.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = False
            End If
        Next

    End Sub


    Private Sub btSelTodos_Click(sender As System.Object, e As System.EventArgs) Handles btSelTodos.Click

        For indice As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRow = GridView1.GetDataRow(indice)
            If Not IsNothing(row) Then
                row("S") = True
            End If
        Next

    End Sub


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()



        Try

            cnDoc.AbrirConexion()


            Dim cont As Integer = 0
            ProgressBar1.Value = 0


            If GridView1.RowCount > 0 Then

                ProgressBar1.Maximum = GridView1.RowCount - 1

                For indice As Integer = 0 To GridView1.RowCount - 1

                    Dim row As DataRow = GridView1.GetDataRow(indice)
                    If Not IsNothing(row) Then

                        If row("S") = True Then

                            SubirAGestionDocumental(row)


                            cont = cont + 1

                        End If

                    End If

                    ProgressBar1.Value = indice

                    Application.DoEvents()

                Next

            End If


            If cont > 0 Then
                MsgBox("Terminado!")
                Consultar()
            Else
                MsgBox("No hay ningún documento seleccionado")
            End If



        Catch ex As Exception
        Finally
            If cnDoc.conn.State = ConnectionState.Open Then
                cnDoc.CerrarConexion()
            End If
        End Try


    End Sub


    Private Sub SubirAGestionDocumental(ByRef row As DataRow)


        'Origen
        Dim ruta_completa_origen As String = _ruta
        If Not ruta_completa_origen.EndsWith("\") Then ruta_completa_origen = ruta_completa_origen & "\"

        Dim nombre_archivo As String = (row("Archivo").ToString & "").Trim
        ruta_completa_origen = ruta_completa_origen & nombre_archivo
        Dim clave As String = (row("Clave").ToString & "").Trim
        Dim documento As String = (row("Documento").ToString & "").Trim


        'Destino
        Dim ruta_completa_destino As String = PathDocumentos + "\" + nombre_archivo + ".pdf"


        If clave.Trim <> "" Then
            If IO.File.Exists(ruta_completa_origen) Then

                Try


                    'Subir fichero
                    If My.Computer.FileSystem.DirectoryExists(PathDocumentos) = False Then ' creo el directorio de documentos por si no existe
                        My.Computer.FileSystem.CreateDirectory(PathDocumentos)
                    End If
                    My.Computer.FileSystem.CopyFile(ruta_completa_origen, ruta_completa_destino, True)


                    Dim TablaDocumentos As String = "Documentos_" & MiMaletin.IdEmpresaCTB.ToString


                    'Registrar fichero en Gestión documental
                    Dim sql As String = "INSERT INTO " & TablaDocumentos & " (IdClave, IdNuxeo, Descripcion, TipoDocumento) "
                    sql = sql & " VALUES ('" & clave & "', '" & nombre_archivo & "', '" & nombre_archivo.Replace("AUTO-", "").Replace(".pdf", "").Replace(".PDF", "").Replace(".Pdf", "") & "', '" & documento & "')"
                    If cnDoc.OrdenSql(sql) Then

                        'Borrar archivo
                        If ChkBorrar.Checked Then
                            Try
                                My.Computer.FileSystem.DeleteFile(ruta_completa_origen)
                            Catch ex As Exception
                            End Try
                        End If


                    End If


                Catch ex As Exception
                    MsgBox("Error al subir el fichero " & nombre_archivo)
                End Try


            End If
        End If


    End Sub

    
End Class