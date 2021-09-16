
Public Class FrmEscaneoPagosLiquidaciones
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

    Dim _ruta As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_BUZON_ENTRADA_PAGOS_LIQUIDACIONES)



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


        Dim Tipo As String = nombre.ToLower.Replace("auto-", "").Substring(0, 2).ToUpper

        Select Case Tipo


            'Case "PP"

            '    Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
            '    Dim Datos_guion As String() = Split(nombre_archivo, "-")
            '    Dim datos_archivo As String() = Split(Datos_guion(0).ToString, "_")
            '    Dim datos_pago As String() = Split(datos_archivo(0).ToString, ".")


            '    Dim IdEmpresa As String = ""
            '    Dim IdPago As String = ""
            '    Dim cheque_pagare As String = ""

            '    If datos_pago.Length > 0 Then IdEmpresa = VaInt(datos_pago(0)).ToString
            '    If datos_pago.Length > 1 Then IdPago = VaInt(datos_pago(1)).ToString
            '    If datos_pago.Length > 2 Then cheque_pagare = (datos_pago(2) & "").Trim.ToUpper



            '    Dim Pagos As New E_Pagos(Idusuario, ConexCtb(VaInt(IdEmpresa)))
            '    documento = Pagos.DescripcionDocumental



            '    If Pagos.LeerId(IdPago) Then
            '        id = (Pagos.IdPago.Valor & "").Trim
            '        clave = Pagos.NombreBd & "|" & Pagos.NombreTabla & "|" & id
            '    End If


            Case "LQ"

                documento = "Factura de Agricultor"

                Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
                Dim datos_fecha_hora As String() = Split(nombre_archivo, "-")
                Dim datos_bancarios As String() = Split(datos_fecha_hora(0), "_")
                Dim datos_liquidacion As String() = Split(datos_bancarios(0), ".")



                Dim IdEmpresa As String = ""
                Dim Campa As String = ""
                Dim Serie As String = ""
                Dim Factura As String = ""

                If datos_liquidacion.Length > 0 Then IdEmpresa = VaInt(datos_liquidacion(0)).ToString
                If datos_liquidacion.Length > 1 Then Campa = VaInt(datos_liquidacion(1)).ToString
                If datos_liquidacion.Length > 2 Then Serie = datos_liquidacion(2).ToString
                If datos_liquidacion.Length > 3 Then Factura = VaInt(datos_liquidacion(3)).ToString


                Dim LiquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)
                If LiquidacionAgr.LeerLiquidacion(IdEmpresa, Campa, Serie, Factura) > 0 Then
                    id = (LiquidacionAgr.LIQ_Idliquidacion.Valor & "").Trim
                    clave = LiquidacionAgr.NombreBd & "|" & LiquidacionAgr.NombreTabla & "|" & id
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

                            Dim nombre_archivo As String = (row("Archivo").ToString & "").Trim
                            If nombre_archivo.ToLower.StartsWith("auto-lq") Then

                                'Carta de pago
                                Dim clave As String = ""
                                Dim documento As String = ""

                                ActualizarDatosPagoAsiento(row, clave, documento)
                                SubirAGestionDocumental(nombre_archivo, clave, documento)

                            End If


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


        SubirAGestionDocumental(nombre_archivo, clave, documento)


    End Sub


    Private Sub SubirAGestionDocumental(nombre_archivo As String, clave As String, documento As String)


        'Origen
        Dim ruta_completa_origen As String = _ruta
        If Not ruta_completa_origen.EndsWith("\") Then ruta_completa_origen = ruta_completa_origen & "\"
        ruta_completa_origen = ruta_completa_origen & nombre_archivo


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


    Private Sub ActualizarDatosPagoAsiento(row As DataRow, ByRef clave As String, ByRef documento As String)


        clave = ""
        documento = ""



        Dim nombre As String = (row("Archivo").ToString & "").Trim
        Dim Tipo As String = nombre.ToLower.Replace("auto-", "").Substring(0, 2).ToUpper


        'TODO: Sacar estos datos del nombre del archivo
        documento = "Factura de Agricultor"

        'Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
        'Dim Datos_guion As String() = Split(nombre_archivo, "-")
        'Dim datos_liq As String() = Split(Datos_guion(0).ToString, ".")


        Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace(Tipo.ToLower, "").Replace(".pdf", "")
        Dim datos_fecha_hora As String() = Split(nombre_archivo, "-")
        Dim datos_bancarios As String() = Split(datos_fecha_hora(0), "_")
        Dim datos_liquidacion As String() = Split(datos_bancarios(0), ".")


        Dim IdEmpresa As String = ""
        Dim Campa As String = ""
        Dim Serie As String = ""
        Dim Factura As String = ""
        Dim IdLiquidacion As String = ""
        Dim documento_pago As String = ""
        Dim IBAN As String = ""
        Dim IdBanco As String = ""

        If datos_liquidacion.Length > 0 Then IdEmpresa = VaInt(datos_liquidacion(0)).ToString
        If datos_liquidacion.Length > 1 Then Campa = VaInt(datos_liquidacion(1)).ToString
        If datos_liquidacion.Length > 2 Then Serie = datos_liquidacion(2).ToString
        If datos_liquidacion.Length > 3 Then Factura = VaInt(datos_liquidacion(3)).ToString
        If datos_bancarios.Length > 1 Then documento_pago = datos_bancarios(1)
        If datos_bancarios.Length > 2 Then IBAN = datos_bancarios(2)


        Dim LiquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)
        If LiquidacionAgr.LeerLiquidacion(IdEmpresa, Campa, Serie, Factura) > 0 Then
            IdLiquidacion = (LiquidacionAgr.LIQ_Idliquidacion.Valor & "").Trim
        End If


        'Dim nombre_archivo As String = nombre.ToLower.Replace("auto-", "").Replace("lq", "").Replace(".pdf", "")
        'Dim Datos_guion As String() = Split(nombre_archivo, "-")
        'Dim datos_guion_bajo As String() = Split(Datos_guion(0).ToString, "_")
        'Dim datos_liq As String() = Split(datos_guion_bajo(0).ToString, ".")
        'Dim IdEmpresa As String = "" : If datos_liq.Length > 0 Then IdEmpresa = VaInt(datos_liq(0)).ToString
        'Dim IdLiquidacion As String = "" : If datos_liq.Length > 1 Then IdLiquidacion = VaInt(datos_liq(1)).ToString

        'Dim documento_pago As String = "" : If datos_guion_bajo.Length > 1 Then documento_pago = datos_guion_bajo(1)
        'Dim IBAN As String = "" : If datos_guion_bajo.Length > 2 Then IBAN = datos_guion_bajo(2)
        'Dim IdBanco As String = ""

        If IBAN.Trim <> "" Then

            'Obtiene el IdBanco a partir del IBAN
            Dim sql As String = "SELECT IdBanco FROM Bancos WHERE IBAN = '" & IBAN & "'"
            Dim dt As DataTable = ConexCtb(VaInt(IdEmpresa)).ConsultaSQL(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then

                    IdBanco = (dt.Rows(0)("IdBanco").ToString & "").Trim

                End If
            End If

        End If


        If VaDec(IdLiquidacion) > 0 Then

            Dim IdAsiento As String = ""


            'Obtenemos el asiento del pago
            'Dim LiquidacionAgr As New E_LiquidacionAgr(Idusuario, cn)
            'If LiquidacionAgr.LeerId(IdLiquidacion) Then
            IdAsiento = (LiquidacionAgr.LIQ_IdAsiento.Valor & "").Trim
            'End If


            If VaDec(IdAsiento) > 0 Then

                Dim Asientos As New E_Asientos(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
                clave = Asientos.NombreBd & "|" & Asientos.NombreTabla & "|" & IdAsiento

                documento = Asientos.NombreTabla


                'OJO: ver en que contabilidad se está contabilizando cada cosa...

                Dim sql As String = "SELECT IdApunte FROM AsientoLineas WHERE IdAsiento = " & IdAsiento
                Dim dt As DataTable = ConexCtb(VaInt(IdEmpresa)).ConsultaSQL(sql)

                If Not IsNothing(dt) Then

                    For Each rowA As DataRow In dt.Rows

                        Dim IdApunte As String = (rowA("IdApunte").ToString & "").Trim
                        If VaDec(IdApunte) > 0 Then

                            Dim AsientoLineas As New E_AsientoLineas(Idusuario, ConexCtb(IdEmpresa))
                            If AsientoLineas.LeerId(IdApunte) Then

                                Dim SRPC As String = (AsientoLineas.SRPC.Valor & "").Trim




                                If VaDec(IdApunte) > 0 And SRPC = "P" Then


                                    'Actualiza el documento del asiento
                                    AsientoLineas.Documento.Valor = documento_pago
                                    AsientoLineas.Actualizar()


                                    'Actualiza el documento de la cartera
                                    sql = "UPDATE Cartera SET NumeroDocumento = '" & documento_pago & "' WHERE IdRegistro = " & IdApunte
                                    ConexCtb(IdEmpresa).OrdenSql(sql)


                                    'Obtiene las líneas de cartera que corresponden a la línea de asiento del pago
                                    sql = "SELECT IdLinea FROM Cartera_Lineas WHERE IdRegistro = " & IdApunte

                                    Dim dtC As DataTable = ConexCtb(IdEmpresa).ConsultaSQL(sql)
                                    If Not IsNothing(dtC) Then
                                        For Each rowC As DataRow In dtC.Rows

                                            Dim IdLineaCartera As String = (rowC("IdLinea").ToString & "").Trim
                                            If VaDec(IdLineaCartera) > 0 Then

                                                'Actualiza el banco de la cartera
                                                Dim Cartera_Lineas As New E_Cartera_lineas(Idusuario, ConexCtb(IdEmpresa))
                                                If Cartera_Lineas.LeerId(IdLineaCartera) Then
                                                    Cartera_Lineas.Idbanco.Valor = IdBanco
                                                    Cartera_Lineas.Actualizar()
                                                End If


                                            End If

                                        Next
                                    End If




                                End If

                            End If

                        End If

                    Next

                End If


            End If

        End If


    End Sub


End Class