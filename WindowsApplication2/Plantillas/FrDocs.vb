Imports DevExpress.XtraEditors
Imports SharpSsh
Imports NetAgro.TwainLib
Imports NetAgro.GdiPlusLib
Imports PdfSharp.Pdf
Imports PdfSharp.Drawing
Imports PdfSharp
Imports System.Runtime.InteropServices



Public Enum tipoGD
    Liquidaciones
    Liquidaciones_Transportistas
    CuentasContables
    Pagos
    Cobros
    Agricultores
    Transportistas
    Clientes
End Enum


Public Class FrDocs
    Implements IMessageFilter



    <DllImport("kernel32.dll", ExactSpelling:=True)> Friend Shared Function GlobalLock(ByVal handle As IntPtr) As IntPtr
    End Function



    Private Class GeneraConsulta

        Public _LeftJoin As New List(Of RelacionEntidad)
        Public _Tabla As String = ""

        Private DcContTabla As New Dictionary(Of String, Integer)


        Public Sub New(Tabla As String)

            _Tabla = Tabla

        End Sub


        Public Function Añadir_Campo(relacion As RelacionEntidad) As String

            Dim res As String = ""


            If Not IsNothing(relacion) Then

                Dim CampoClaveHijo As String = ClavePrimaria(relacion.HijoBD, relacion.HijoEntidad)
                relacion.ClavePrimaria = CampoClaveHijo

                _LeftJoin.Add(relacion)

                res = CampoClaveHijo

            End If


            Return res

        End Function


        Public Function ObtenerSQL(CampoWhere As String, IdWhere As String, ByRef DcAliasCampo As Dictionary(Of String, List(Of String)),
                                   Optional HastaCampo As String = "") As String


            Dim sqlSelect As String = ""
            Dim sqlLeftJoin As String = ""


            For indice As Integer = 0 To _LeftJoin.Count - 1

                Dim bContinuar As Boolean = True

                If HastaCampo <> "" Then
                    bContinuar = QuedaCampo(HastaCampo, indice)
                End If


                If bContinuar Then

                    Dim relacion As RelacionEntidad = _LeftJoin(indice)

                    Dim PadreBd As String = relacion.PadreBD
                    Dim PadreEntidad As String = relacion.PadreEntidad
                    Dim PadreCampo As String = relacion.PadreCampo

                    Dim HijoBd As String = relacion.HijoBD
                    Dim HijoEntidad As String = relacion.HijoEntidad
                    Dim HijoCampo As String = relacion.HijoCampo

                    'Dim CampoClaveHijo As String = ClavePrimaria(HijoBd, HijoEntidad)
                    Dim CampoClaveHijo As String = relacion.ClavePrimaria


                    If indice = 0 Then

                        sqlSelect = PadreEntidad & "." & PadreCampo & " " & PadreCampo & "1"

                        Dim lst As New List(Of String)
                        lst.Add(PadreCampo & "1")
                        DcAliasCampo(PadreCampo) = lst

                    Else

                        'Alias Hijo
                        If Not DcContTabla.ContainsKey(HijoEntidad.ToLower) Then
                            DcContTabla(HijoEntidad.ToLower) = 1
                        Else
                            DcContTabla(HijoEntidad.ToLower) = DcContTabla(HijoEntidad.ToLower) + 1
                        End If
                        Dim HijoEntidadAlias As String = HijoEntidad & DcContTabla(HijoEntidad.ToLower).ToString
                        Dim CampoClaveHijoAlias = CampoClaveHijo & DcContTabla(HijoEntidad.ToLower).ToString


                        'Añadimos clave de alias 
                        If Not DcAliasCampo.ContainsKey(CampoClaveHijo) Then
                            Dim lst As New List(Of String)
                            lst.Add(CampoClaveHijoAlias)
                            DcAliasCampo(CampoClaveHijo) = lst
                        Else
                            DcAliasCampo(CampoClaveHijo).Add(CampoClaveHijoAlias)
                        End If


                        'Campos select
                        If sqlSelect <> "" Then sqlSelect = sqlSelect & ", " & vbCrLf
                        sqlSelect = sqlSelect & HijoEntidadAlias & "." & CampoClaveHijo & " " & CampoClaveHijoAlias


                        'Alias Padre
                        Dim PadreEntidadAlias As String = PadreEntidad
                        If DcContTabla.ContainsKey(PadreEntidad.ToLower) Then
                            PadreEntidadAlias = PadreEntidadAlias & DcContTabla(PadreEntidad.ToLower).ToString
                        End If

                        sqlLeftJoin = sqlLeftJoin & " LEFT JOIN " & HijoBd & ".dbo." & HijoEntidad & " " & HijoEntidadAlias & " ON " & HijoEntidadAlias & "." & HijoCampo & " = " & PadreEntidadAlias & "." & PadreCampo & vbCrLf

                    End If

                Else
                    Exit For
                End If


            Next


            Dim sql As String = "SELECT " & sqlSelect & vbCrLf & " FROM " & _Tabla & vbCrLf & sqlLeftJoin & vbCrLf & " WHERE " & CampoWhere & " = " & IdWhere


            Return sql


        End Function


        Private Function QuedaCampo(HastaCampo As String, indice_relacion As Integer) As Boolean

            Dim bRes As Boolean = False


            For indice As Integer = indice_relacion To _LeftJoin.Count - 1

                Dim relacion As RelacionEntidad = _LeftJoin(indice)
                
                If HastaCampo.ToUpper.Trim = relacion.ClavePrimaria.ToLower.Trim Then
                    bRes = True
                    Exit For
                End If

            Next


            Return bRes

        End Function


    End Class



    Dim ClaveDocumento As String = ""
    Dim TipoDoc As Integer = 0
    Dim IdFic As String = ""
    Dim IdPdf As String = ""
    Dim NuevoFichero As String = ""


    Dim oEnlace As EnlaceNuxeo
    Dim oConfig As New ConfiguracionEnlace
    Dim err As New Errores()


    Private _NombreBd As String
    Private _NombreEntidad As String
    Private _IdEntidad As String



    'Escáner
    Private tw As Twain
    Private msgfilter As Boolean
    Private picnumber As Integer = 0

    Private _ruta_escaner As String = ""
    Private ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
    Private _fichero_escaner As String = ""



    Private _TablaDocumentos As String = "Documentos_" & MiMaletin.IdEmpresaCTB.ToString


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        tw = New Twain()
        tw.Init(Me.Handle)


    End Sub


    Public Sub Init(ByVal NombreBd As String, ByVal NombreEntidad As String, ByVal IdEntidad As String)

        _NombreBd = NombreBd
        _NombreEntidad = NombreEntidad
        _IdEntidad = IdEntidad


        LbBasedatos.Text = NombreBd
        Lbentidad.Text = NombreEntidad
        LbidEntidad.Text = IdEntidad
        TipoDoc = TipDocumental
        'ClaveDocumento = Trim(NombreBd) + "_" + Trim(NombreEntidad) + "_" + Trim(IdEntidad)
        ClaveDocumento = Trim(NombreBd) + SeparadorCtb + Trim(NombreEntidad) + SeparadorCtb + Trim(IdEntidad)



        

    End Sub


    Private Sub FrDocs_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        _ruta_escaner = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_ARCHIVOS_ADJUNTOS_TEMP) & "\"

    End Sub


    Private Sub FrDocs_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

      
        CnDoc.AbrirConexion()
        Cargadocumentos()


        oConfig.CargaXML()
        oConfig.MiId = ClaveDocumento
        oEnlace = New EnlaceNuxeo(oConfig, _TablaDocumentos)


        'Muestra el nif y los documentos asociados
        Me.Refresh()

        'Muestra el documento seleccionado (si existe)
        CargaUnDocumento()

        If GridView1.RowCount = 0 Then
            AñadirDocumento()
        End If

        Lbbuzon.Text = PathDocumentos + "\buzonentrada\" + LbBasedatos.Text + "\" + Lbentidad.Text


    End Sub


    Private Sub Cargadocumentos()


        Me.Enabled = False
        LbCargando.Visible = True


        Try

            Dim Campo As String = ClavePrimaria(_NombreBd, _NombreEntidad)
            If Campo.Trim = "" Then
            End If


            Dim lst As New List(Of RelacionEntidad)
            Dim lstDocs As List(Of RelacionEntidad) = Doc_ObtenerRelaciones(_NombreBd, _NombreEntidad, Campo, "", "", "", lst)


            Dim dt As DataTable = Nothing


            'Si no tiene relaciones
            If lstDocs.Count = 0 Or Campo.Trim = "" Then

                Dim IdClave As String = LbBasedatos.Text & SeparadorCtb & Lbentidad.Text & SeparadorCtb & LbidEntidad.Text
                Dim sql As String = "SELECT DISTINCT Id, IdClave, IdNuxeo, Descripcion, Tipodocumento as Documento, IdiArchiva FROM Documentos.dbo." & _TablaDocumentos & " WHERE IdClave = '" & IdClave & "'"
                dt = CnDoc.ConsultaSQL(sql)

            Else

                Dim lstCamposUtiles As New List(Of String)
                Dim DcDocumentos As New Dictionary(Of String, List(Of String))
                Dim DcAliasCampo As New Dictionary(Of String, List(Of String))


                'Carga la consulta base
                Dim consulta As New GeneraConsulta(_NombreBd & ".dbo." & _NombreEntidad)

                For Each relacion As RelacionEntidad In lstDocs

                    'Almaceno los datos sobre las relaciones
                    Dim ClavePrimaria As String = consulta.Añadir_Campo(relacion)
                    If Not lstCamposUtiles.Contains(ClavePrimaria) Then
                        lstCamposUtiles.Add(relacion.HijoBD & SeparadorCtb & relacion.HijoEntidad & SeparadorCtb & ClavePrimaria)
                    End If

                Next


                Dim sqlBase As String = consulta.ObtenerSQL(Campo, _IdEntidad, DcAliasCampo)
                'Dim sqlB As String = consulta.ObtenerSQL(Campo, _IdEntidad, DcAliasCampo)



                'Obtengo todos los documentos de cada campo
                Dim sql As String = ""

                For Each IdClave As String In lstCamposUtiles

                    Dim clave As String() = Split(IdClave, SeparadorCtb)
                    If clave.Length = 3 Then

                        Dim NombreBd As String = clave(0)
                        Dim Entidad As String = clave(1)
                        Dim ClavePrimaria As String = clave(2)

                        If DcAliasCampo.ContainsKey(ClavePrimaria) Then
                            For Each campoclave As String In DcAliasCampo(ClavePrimaria)


                                'Dim sqlBase As String = consulta.ObtenerSQL(Campo, _IdEntidad, New Dictionary(Of String, List(Of String)), campoclave)


                                Dim sqlConsulta As String = "SELECT DISTINCT Id, IdClave, IdNuxeo, Descripcion, Tipodocumento as Documento, IdiArchiva" & vbCrLf
                                sqlConsulta = sqlConsulta & " FROM ( " & vbCrLf
                                sqlConsulta = sqlConsulta & sqlBase & vbCrLf
                                sqlConsulta = sqlConsulta & " ) as A" & vbCrLf
                                sqlConsulta = sqlConsulta & " INNER JOIN Documentos.dbo." & _TablaDocumentos & " ON '" & NombreBd & SeparadorCtb & Entidad & SeparadorCtb & "' + cast(" & campoclave & " as varchar) = IdClave" & vbCrLf

                                If sql.Trim = "" Then
                                    sql = sqlConsulta
                                Else
                                    sql = sql & " UNION ALL " & vbCrLf
                                    sql = sql & sqlConsulta
                                End If

                                'Dim sql As String = "SELECT DISTINCT Id, IdClave, IdNuxeo, Descripcion, Tipodocumento as Documento" & vbCrLf
                                'sql = sql & " FROM ( " & vbCrLf
                                'sql = sql & sqlBase & vbCrLf
                                'sql = sql & " ) as A" & vbCrLf
                                'sql = sql & " INNER JOIN Documentos.dbo." & _TablaDocumentos & " ON '" & NombreBd & SeparadorCtb & Entidad & SeparadorCtb & "' + cast(" & campoclave & " as varchar) = IdClave"

                                'Dim dtConsulta As DataTable = CnDoc.ConsultaSQL(sql)
                                'If Not IsNothing(dtConsulta) Then
                                '    If IsNothing(dt) Then
                                '        dt = dtConsulta
                                '    Else
                                '        dt.Merge(dtConsulta)
                                '    End If
                                'End If

                            Next
                        End If

                    End If

                Next

                sql = "SELECT DISTINCT Id, IdClave, IdNuxeo, Descripcion, Documento, IdiArchiva" & vbCrLf & _
                    "FROM ( " & vbCrLf & sql & vbCrLf & ") as Z"

                dt = CnDoc.ConsultaSQL(sql)

            End If




            If Not dt Is Nothing Then
                Grid.DataSource = dt
            End If


            AjustaColumnas()

            GridView1.ExpandAllGroups()

        Catch ex As Exception

        End Try



        LbCargando.Visible = False
        Me.Enabled = True
        


    End Sub


    Private Sub CargaUnDocumento(Optional indice As Integer = -1)

        Try


            If indice = -1 Then indice = GridView1.FocusedRowHandle


            IdFic = ""
            IdPdf = ""
            TxTipoDoc.Text = ""
            TxDato_2.Text = ""
            VisualizaDoc("", False)


            If GridView1.RowCount > indice And indice >= 0 Then

                Dim row As DataRow = GridView1.GetDataRow(indice)
                If Not IsNothing(row) Then

                    If (row("idclave") & "").trim <> "" Then

                        If (row("idclave").ToString() & "").Trim <> "" Then

                            TxDato_2.Text = (row("descripcion").ToString & "").Trim
                            TxTipoDoc.Text = (row("documento").ToString & "").Trim

                            If TxTipoDoc.Text.Trim = "DOCUMENTO_ERP" Then
                                TxTipoDoc.ReadOnly = True
                                TxDato_2.ReadOnly = True
                            Else
                                TxTipoDoc.ReadOnly = False
                                TxDato_2.ReadOnly = False
                            End If

                            IdFic = (row("Id").ToString & "").Trim
                            IdPdf = (row("idnuxeo").ToString & "").Trim

                            Dim url_iArchiva As String = (row("IdiArchiva").ToString & "").Trim
                            If url_iArchiva <> "" Then
                                MostrarUrl(url_iArchiva)
                            Else
                                MostrarFichero(IdPdf)
                            End If


                            GridView1.FocusedRowHandle = indice

                        End If


                    End If

                End If

            End If

        Catch ex As Exception

        End Try


    End Sub


    Private Sub VisualizaDoc(ByVal direccionUrl As String, ByVal bUrl As Boolean)

        If TipoDoc = 0 Then

            If System.IO.File.Exists(direccionUrl) Or bUrl Then
                WebBrowser1.Navigate(direccionUrl)
            Else
                WebBrowser1.DocumentText = ""
            End If
        ElseIf TipoDoc = 1 Then
            WebBrowser1.Navigate(direccionUrl)
        End If

    End Sub


    Private Sub BPrevisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrevisualizar.Click
        BuscarFichero()
        If NuevoFichero <> "" Then
            If MsgBox("Desea añadir este documento", vbYesNo) = vbYes Then
                Guardar()
            End If
        End If


    End Sub


    Private Sub BuscarFichero()

        NuevoFichero = ""
        Dim RutaFichero As String = ""


        If RbBuzon.Checked = True Then
            RutaFichero = ObtenerFicheroBuzon()
        ElseIf RbMiequipo.Checked = True Then
            RutaFichero = ObtenerFichero()
        ElseIf RbScaner.Checked Then
            If System.IO.File.Exists(_fichero_escaner) Then
                RutaFichero = _fichero_escaner
            End If
        End If


        If RutaFichero.Trim <> "" Then
            VisualizaDoc(RutaFichero, False)
            NuevoFichero = RutaFichero
        End If

    End Sub


    Private Sub Bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub


    Private Sub BAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAñadir.Click
        Guardar()
    End Sub


    Private Sub Guardar()

        If NuevoFichero = "" Then
            MsgBox("Debe seleccionar un fichero")
            Exit Sub
        End If



        Dim tipo As String = Lbentidad.Text
        Dim NombreDocumento As String = LbidEntidad.Text



        If TxDato_2.Text.Trim = "" Then

            Try

                Dim lstParams As New List(Of Object)
                lstParams.Add(Idusuario)
                lstParams.Add(cn)
                lstParams.ToArray()
                Dim params As Object() = lstParams.ToArray


                Dim asm As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly
                Dim entidad As Cdatos.Entidad = DirectCast(Activator.CreateInstance(asm.GetType("NetAgro.E_" & Lbentidad.Text), params), Cdatos.Entidad)
                If entidad.NombreBd.ToUpper.Trim = "NETAGROCOMER" And Not entidad.EsVista Then


                    tipo = entidad.DescripcionDocumental




                    If VaInt(LbidEntidad.Text) > 0 Then

                        If entidad.LeerId(LbidEntidad.Text) Then

                            If entidad.CamposDocumento.Count > 0 Then

                                NombreDocumento = ""
                                For Each campo As Cdatos.bdcampo In entidad.CamposDocumento
                                    If NombreDocumento.Trim <> "" Then NombreDocumento = NombreDocumento & "-"
                                    NombreDocumento = NombreDocumento & campo.Valor
                                Next

                            Else
                                NombreDocumento = entidad.ClavePrimaria.Valor
                            End If

                        End If

                    End If

                End If


            Catch ex As Exception

            End Try




            

        End If


        tipo = InputBox("Introduzca el tipo de documento", , tipo)
        TxTipoDoc.Text = tipo

        NombreDocumento = tipo & " " & NombreDocumento
        NombreDocumento = InputBox("Introduzca un nombre para el documento", , NombreDocumento)
        TxDato_2.Text = NombreDocumento



        If NuevoFichero <> "" Then
            'Copia el fichero físicamente
            IdPdf = SubirFichero(ClaveDocumento, NuevoFichero)
        End If

        If IdPdf <> "" Then

            If TipoDoc = 0 Then
                'Insert en tabla documentos
                GuardarFichero(IdFic, IdPdf, tipo)
            End If

            Cargadocumentos()

            Dim fila As Integer = 0
            Dim max As Decimal = -1
            For indice As Integer = 0 To GridView1.RowCount - 1
                Dim row As DataRow = GridView1.GetDataRow(indice)
                If Not IsNothing(row) Then
                    If VaDec(row("Id")) > max Then
                        max = VaDec(row("Id"))
                        fila = indice
                    End If
                End If
            Next
            CargaUnDocumento(fila)


            If RbBuzon.Checked = True Then
                If MsgBox("Borrar documento del buzon de entrada", vbYesNo) = vbYes Then
                    My.Computer.FileSystem.DeleteFile(NuevoFichero)
                End If
            End If
        End If

        NuevoFichero = ""


    End Sub



    Private Sub GuardarFichero(ByVal id As String, ByVal idpdf As String, ByVal tipodocumento As String)

        Dim dt As New DataTable
        Dim sql As String = ""

        If id <> "" Then
            sql = "delete from " & _TablaDocumentos & " where id=" + id
            CnDoc.OrdenSql(sql)
        End If

        sql = "insert into " & _TablaDocumentos & " (idclave, idnuxeo, descripcion, tipodocumento) "
        sql = sql + " values ('" + ClaveDocumento + "','" + idpdf + "','" + TxDato_2.Text + " ', '" & tipodocumento & "')"

        CnDoc.OrdenSql(sql)


    End Sub


    Private Sub Limpiame()

        TxDato_2.Text = ""
        TxTipoDoc.Text = ""

    End Sub


    Private Function ObtenerFichero() As String

        Dim resultado As String = ""

        dOpenFile.FileName = ""
        dOpenFile.Filter = "ficheros pdf (*.pdf)|*.pdf"
        dOpenFile.ShowDialog()

        If dOpenFile.FileName.Trim <> "" Then
            resultado = dOpenFile.FileName

        End If

        Return resultado

    End Function


    Private Function ObtenerFicheroBuzon() As String

        Dim resultado As String = ""

        dOpenFileBuzon.FileName = ""
        dOpenFileBuzon.InitialDirectory = PathDocumentos + "\buzonentrada\" + LbBasedatos.Text + "\" + Lbentidad.Text

        If My.Computer.FileSystem.DirectoryExists(dOpenFileBuzon.InitialDirectory) = False Then
            My.Computer.FileSystem.CreateDirectory(dOpenFileBuzon.InitialDirectory)
        End If

        dOpenFileBuzon.Filter = "ficheros pdf (*.pdf)|*.pdf"
        dOpenFileBuzon.ShowDialog()

        If dOpenFileBuzon.FileName.Trim <> "" Then
            resultado = dOpenFileBuzon.FileName
        End If

        Return resultado

    End Function


    Private Sub BAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAnular.Click


        Dim row As DataRow = GridView1.GetFocusedDataRow()


        If Not IsNothing(row) Then

            Dim id As String = (row("Id").ToString & "").Trim
            Dim descripcion As String = (row("descripcion").ToString & "").Trim

            If VaInt(id) > 0 Then
                If XtraMessageBox.Show("Se va a eliminar el documento " & descripcion & " de la gestión documental. ¿Desea continuar?", "Eliminar documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    Dim sql As String = ""

                    sql = "delete from " & _TablaDocumentos & " where id=" + id
                    CnDoc.OrdenSql(sql)


                    Limpiame()
                    Cargadocumentos()
                End If
            Else
                MsgBox("no existe el documento")
            End If

        Else
            XtraMessageBox.Show("No hay ningun documento seleccionado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


        CargaUnDocumento()

    End Sub


    Private Sub TxDato_2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then
            BAñadir.Select()
            BAñadir.Focus()
        End If

    End Sub


    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "IDCLAVE", "IDNUXEO", "ID", "IDIARCHIVA"
                    c.Visible = False
                Case "DOCUMENTO"
                    c.Caption = ""
                    c.Visible = False
                    c.GroupIndex = 1
            End Select
        Next

        GridView1.BestFitColumns()

    End Sub


    Private Sub FrDocs_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CnDoc.CerrarConexion()
    End Sub


    Private Sub MostrarFichero(ByVal idpdf As String)

        Select Case TipoDoc

            Case 0 ' clave
                VisualizaDoc(PathDocumentos + "\" + idpdf + ".pdf", False)

            Case 1 ' NUXEO
                VisualizaDoc(oEnlace.VisualizaFichero(idpdf), False)

        End Select

    End Sub


    Private Sub MostrarUrl(ByVal url As String)

        VisualizaDoc(url, True)

    End Sub


    Private Function SubirFichero(ByVal clavedoc As String, ByVal Fichero As String) As String
        ' desde aqui mandamos a nuxeo/clave


        Dim ret As String = ""
        Dim NomFichero As String
        Dim PathFichero As String
        Dim nfic As String



        Select Case TipoDoc

            Case 0 ' clave 


                PathFichero = PathDocumentos
                nfic = Format(Now, "yyyyMMddhhmmssfff")
                NomFichero = PathFichero + "\" + nfic + ".pdf"

                If My.Computer.FileSystem.DirectoryExists(PathFichero) = False Then ' creo el directorio de documentos por si no existe
                    My.Computer.FileSystem.CreateDirectory(PathFichero)
                End If
                My.Computer.FileSystem.CopyFile(Fichero, NomFichero, True)
                ret = nfic

                'Copio a carpeta de iArchiva
                Dim ruta_iArchiva As String = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_CARPETA_IARCHIVA, MiMaletin.IdPuntoVenta, MiMaletin.IdCentro, Idusuario)
                If ruta_iArchiva.Trim <> "" Then

                    If Not ruta_iArchiva.EndsWith("\") Then
                        ruta_iArchiva = ruta_iArchiva & "\"
                    End If


                    Try

                        Dim fichero_iArchiva As String = ruta_iArchiva & nfic & ".pdf"

                        If My.Computer.FileSystem.DirectoryExists(ruta_iArchiva) Then
                            My.Computer.FileSystem.CopyFile(Fichero, fichero_iArchiva, True)
                        Else
                            MsgBox("La ruta para almacenar en la carpeta de iArchiva no existe")
                        End If

                    Catch ex As Exception
                        MsgBox("Error al tratar de copiar el fichero a la carpeta de iArchiva" & vbCrLf & vbCrLf & ex.Message)
                    End Try

                End If
                


            Case 1 ' nuxeo

                Try

                    oEnlace.AñadirArchivo(Fichero, TxDato_2.Text, TxTipoDoc.Text, ret)

                Catch ex As Exception
                    err.Muestraerror("Error al subir el documento a gestión documental. Clave fichero: " & ClaveDocumento, "FrDocs.SubirFichero", ex.Message)
                End Try


                Return ret

        End Select


        Return ret

    End Function


    Private Sub TxDato_2_KeyDown_1(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDato_2.KeyDown

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            BAñadir.Select()
            BAñadir.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            TxTipoDoc.Select()
            TxTipoDoc.Focus()
        End If

    End Sub




    Private Sub ClButton2_Click(sender As System.Object, e As System.EventArgs) Handles ClButton2.Click

        IdFic = ""
        AñadirDocumento()

    End Sub


    Private Sub AñadirDocumento()

        TxDato_2.Text = ""
        TxTipoDoc.Text = ""

        BuscarFichero()

        If NuevoFichero <> "" Then
            If MsgBox("Desea añadir este documento", vbYesNo) = vbYes Then
                Guardar()
            End If
        End If

    End Sub


    Private Sub AñadirDocumentoEscaneado()


        BuscarFichero()

        Dim temp As String = NuevoFichero

        If NuevoFichero <> "" Then

            If MsgBox("Desea añadir este documento", vbYesNo) = vbYes Then
                Guardar()
            Else
                WebBrowser1.DocumentText = ""
                WebBrowser1.Navigate("")
            End If


            Application.DoEvents()
            Threading.Thread.Sleep(2000)
            Application.DoEvents()



            Try
                If System.IO.File.Exists(temp) Then
                    System.IO.File.Delete(temp)
                End If
            Catch ex As Exception
            End Try



        End If


    End Sub



    Private Sub RbScaner_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbScaner.CheckedChanged

        TxTipoDoc.Text = ""
        TxDato_2.Text = ""


        btCapturar.Enabled = RbScaner.Checked
        btSeleccionarEscaner.Enabled = RbScaner.Checked

        If RbScaner.Checked Then
            If (Twain.ScreenBitDepth < 15) Then
                MessageBox.Show("Error en el modo de video!", "Modo de video", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btCapturar.Enabled = False
                btSeleccionarEscaner.Enabled = False
            End If
        End If


    End Sub


    Private Sub btCapturar_Click(sender As System.Object, e As System.EventArgs) Handles btCapturar.Click

        IdFic = ""
        TxTipoDoc.Text = ""
        TxDato_2.Text = ""

        If (Not msgfilter) Then
            Me.Enabled = False
            msgfilter = True
            Application.AddMessageFilter(Me)
        End If
        tw.Acquire()

    End Sub


    Private Sub btSeleccionarEscaner_Click(sender As System.Object, e As System.EventArgs) Handles btSeleccionarEscaner.Click
        tw.Select()
    End Sub


    Private Sub EndingScan()
        If (msgfilter) Then
            Application.RemoveMessageFilter(Me)
            msgfilter = False
            Me.Enabled = True
            Me.Activate()
        End If
    End Sub


    Public Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage

        Dim cmd As TwainCommand = tw.PassMessage(m)
        If (cmd = TwainCommand.Not) Then
            Return False
        End If

        Select Case cmd

            'Case TwainCommand.Not
            '    EndingScan()
            '    tw.CloseSrc()

            Case TwainCommand.Null
                EndingScan()
                tw.CloseSrc()

            Case TwainCommand.CloseRequest
                EndingScan()
                tw.CloseSrc()
            Case TwainCommand.CloseOk
                EndingScan()
                tw.CloseSrc()
            Case TwainCommand.DeviceEvent
            Case TwainCommand.TransferReady

                _fichero_escaner = ""

                Dim pics As ArrayList = tw.TransferPictures()
                Dim lstArchivos As New List(Of String)

                EndingScan()
                tw.CloseSrc()

                picnumber += 1



                For i As Integer = 0 To pics.Count - 1 Step 1

                    Dim img As IntPtr = CType(pics(i), IntPtr)


                    Dim bmprect As New Rectangle(0, 0, 0, 0)
                    Dim bmpptr As IntPtr = GlobalLock(img)
                    Dim pixptr As IntPtr = GetPixelInfo(bmpptr, bmprect)


                    Dim fichero As String = _ruta_escaner & "Scan_Temp_" & i.ToString & ".png"

                    If System.IO.Directory.Exists(_ruta_escaner) Then
                        Gdip.Save(fichero, bmpptr, pixptr)
                        lstArchivos.Add(fichero)
                    Else
                        MsgBox("Error en la ruta de creación del archivo temporal")
                        Return False
                    End If


                    'Gdip.SaveDIBAs(Me.Text, bmpptr, pixptr)

                    'Dim newpic As PicForm = New PicForm(img)
                    'newpic.MdiParent = Me
                    'Dim picnum As Integer = i + 1
                    'newpic.Text = "ScanPass" + picnumber.ToString() + "_Pic" + picnum.ToString()
                    'newpic.Show()


                Next


                If lstArchivos.Count > 0 Then


                    If lstArchivos.Count > 0 Then

                        Dim num As Integer = 0


                        Dim doc As New PdfDocument()



                        For Each fichero As String In lstArchivos


                            Dim page As New PdfPage

                            'Dim img As XImage = XImage.FromFile(fichero)
                            Dim imagen As Image = Image.FromFile(fichero)
                            Dim img As XImage = XImage.FromGdiPlusImage(imagen)


                            doc.Pages.Add(page)
                            Dim xgr As XGraphics = XGraphics.FromPdfPage(doc.Pages(num))

                            page.Size = PageSize.A4
                            Dim rect As XRect = New XRect(0, 0, page.Width, page.Height)



                            xgr.DrawImage(img, rect)
                            'xgr.DrawImage(img, 0, 0, img.Width, img.Height)


                            imagen.Dispose()
                            xgr.Dispose()

                            imagen = Nothing
                            xgr = Nothing


                            If System.IO.File.Exists(fichero) Then
                                System.IO.File.Delete(fichero)
                            End If



                            num = num + 1



                        Next


                        Dim pdf As String = _ruta_escaner & "Scan_Temp_" & Now.ToString("yyyyMMdd-HHmmssfff") & ".pdf"
                        _fichero_escaner = pdf

                        doc.Save(pdf)
                        doc.Close()

                        doc.Dispose()
                        doc = Nothing


                        AñadirDocumentoEscaneado()


                    End If



                End If




        End Select



        Return True

    End Function


    Private Sub TxTipoDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxTipoDoc.KeyDown

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            TxDato_2.Select()
            TxDato_2.Focus()
        End If

    End Sub


    Private Sub btCambiarTipoDoc_Click(sender As System.Object, e As System.EventArgs) Handles btCambiarTipoDoc.Click

        If XtraMessageBox.Show("¿Desea cambiar el tipo de documento a '" & TxTipoDoc.Text.Trim.ToUpper & "' para el documento '" & TxDato_2.Text.Trim & "'?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim row As DataRow = GridView1.GetFocusedDataRow()
            If Not IsNothing(row) Then

                Dim Id As String = (row("Id").ToString & "").Trim

                If VaInt(Id) > 0 Then

                    Dim sql As String = "UPDATE " & _TablaDocumentos & " SET TipoDocumento = '" & TxTipoDoc.Text & "' WHERE Id = " & Id
                    CnDoc.OrdenSql(sql)

                    Cargadocumentos()
                    Dim fila As Integer = 0
                    For indice As Integer = 0 To GridView1.RowCount - 1
                        Dim row2 As DataRow = GridView1.GetDataRow(indice)
                        If Not IsNothing(row2) Then
                            If VaDec(row2("Id")) = VaDec(Id) Then
                                fila = indice
                            End If
                        End If
                    Next
                    CargaUnDocumento(fila)

                End If

            End If

        End If



    End Sub


    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        If e.FocusedRowHandle >= 0 Then
            CargaUnDocumento(e.FocusedRowHandle)
        End If

    End Sub


    Private Sub GridView1_CustomDrawGroupRow(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GridView1.CustomDrawGroupRow

        Dim info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo = TryCast(e.Info, DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo)
        Dim texto As String = info.GroupValueText & ""
        info.GroupText = texto.ToUpper

    End Sub

    
End Class