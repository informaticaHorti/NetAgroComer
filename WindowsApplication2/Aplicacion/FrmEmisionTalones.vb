Imports NetAgro.Cdatos
Imports System.Drawing


Public Class FrmEmisionTalones


    Public tipofrm As Cdatos.ETipoFrm = Cdatos.ETipoFrm.Otro
    Dim ListaControles As New List(Of Object)
    Public Ncontrol As Integer = 0

    Dim _bCargando As Boolean = True


    Public DocumentosBancos As New E_DocumentosBancos(Idusuario, cn)
    Dim Bancos As New E_Bancos(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        ParamTx(TxFechaVto, Nothing, Nothing, True, Cdatos.TiposCampo.Fecha, 0, 8)
        ParamTx(TxImporte, Nothing, Nothing, True, Cdatos.TiposCampo.Importe, 2, 18)
        ParamTx(TxDestinatario, Nothing, Nothing, True, Cdatos.TiposCampo.Cadena, 0, 255)
        ParamTx(TxImporteLetra1, Nothing, Nothing, True, Cdatos.TiposCampo.Cadena, , 255)
        ParamTx(TxImporteLetra2, Nothing, Nothing, False, Cdatos.TiposCampo.Cadena, , 255)
        ParamTx(TxFecha, Nothing, Nothing, True, Cdatos.TiposCampo.Fecha, 0, 8)


        'AsociarControles(TxBanco, BtBanco, Bancos.btBusca, Bancos, Bancos.Nombre, LbNomBanco)

    End Sub


    Private Sub FrmSeleccionImpresora_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        'Carga documentos
        Dim dt As DataTable = DocumentosBancos.Tabla(Nothing)
        CbDocumentoTalon.DataSource = dt
        CbDocumentoTalon.ValueMember = "Id"
        CbDocumentoTalon.DisplayMember = "Nombre"


        CbDocumentoTalon.SelectedIndex = -1

        CbDocumentoTalon.Select()
        CbDocumentoTalon.Focus()


        _bCargando = False

    End Sub


    Private Sub btCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub

    Private Sub btAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btAceptar.Click


        Dim IdDoc As String = CbDocumentoTalon.SelectedValue & ""


        Dim DocumentosBancos As New E_DocumentosBancos(Idusuario, cn)
        If VaInt(IdDoc) > 0 Then
            If DocumentosBancos.LeerId(IdDoc) Then


                'Impresora por defecto
                Dim ImpresoraTalones As String = ""
                Dim TipoImpresion As TipoImpresion = TipoImpresion.ImpresoraSeleccionada

                Dim ValoresUsuario As New E_valoresusuario(Idusuario, cn)
                If ValoresUsuario.LeerId(Idusuario) Then
                    ImpresoraTalones = (ValoresUsuario.VUS_ImpresoraTalones.Valor & "").Trim
                End If


                'Selecciona impresora para talones
                Dim frm As New FrmSeleccionImpresora(ImpresoraTalones)
                frm.Text = "Seleccionar impresora para Talones"
                frm.ShowDialog()

                If frm.TipoImpresion = TipoImpresion.Cancelar Then
                    Exit Sub
                Else
                    ImpresoraTalones = frm.Impresora
                End If





                Dim archivo As String = DocumentosBancos.DDB_Archivo.Valor
                Dim ruta As String = Application.StartupPath & "\" & ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.CARPETA_DOCUMENTOS_BANCARIOS) & "\"

                If IO.File.Exists(ruta & archivo) Then


                    Dim DatosEmpresa As New DatosEmpresa


                    Dim dt As New DataTable
                    dt.Columns.Add("DiaPag", GetType(String))
                    dt.Columns.Add("MesPag", GetType(String))
                    dt.Columns.Add("AnoPag", GetType(String))
                    dt.Columns.Add("Nombre", GetType(String))
                    dt.Columns.Add("Importe", GetType(String))
                    dt.Columns.Add("NumletA", GetType(String))
                    dt.Columns.Add("NumletB", GetType(String))
                    dt.Columns.Add("Poblacion", GetType(String))
                    dt.Columns.Add("DiaFin", GetType(String))
                    dt.Columns.Add("MesFin", GetType(String))
                    dt.Columns.Add("AnoFin", GetType(String))

                    Dim fila As DataRow = dt.NewRow()

                    If VaDate(TxFechaVto.Text) > VaDate("") Then
                        fila("DiaPag") = VaDate(TxFechaVto.Text).ToString("dd")
                        fila("MesPag") = NombreMes(VaDate(TxFechaVto.Text).Month)
                        fila("AnoPag") = VaDate(TxFechaVto.Text).ToString("yyyy")
                    End If
                    fila("Nombre") = TxDestinatario.Text
                    fila("Importe") = "# " & VaDec(TxImporte.Text).ToString("#,##0.00") & " #"
                    fila("NumletA") = TxImporteLetra1.Text
                    fila("NumletB") = TxImporteLetra2.Text
                    fila("Poblacion") = DatosEmpresa.Poblacion
                    If VaDate(TxFecha.Text) > VaDate("") Then
                        fila("DiaFin") = NumLetra(VaDate(TxFecha.Text).Day, True, True)
                        fila("MesFin") = NombreMes(VaDate(TxFecha.Text).Month)
                        fila("AnoFin") = VaDate(TxFecha.Text).ToString("yyyy")
                    End If

                    dt.Rows.Add(fila)



                    Dim doc As New DocumentoTalonXML(ruta & archivo, dt)


                    If ImpresoraTalones.Trim <> "" Then
                        doc.Imprimir(TipoImpresion.ImpresoraSeleccionada, ImpresoraTalones)
                    Else
                        doc.Imprimir(NetAgro.TipoImpresion.ImpresoraPorDefecto)
                    End If

                Else
                    MsgBox("No se encuentra la plantilla del talón")
                End If

            Else
                MsgBox("Imposible leer el archivo del documento bancario")
            End If

        End If


        'BorraPan()

    End Sub


    Private Sub BorraPan()

        TxFechaVto.Text = ""
        TxImporte.Text = ""
        TxDestinatario.Text = ""
        TxImporteLetra1.Text = ""
        TxImporteLetra2.Text = ""
        TxFecha.Text = ""


    End Sub


    Overloads Sub ParamTx(ByVal Control As TxDato, ByVal CampoBd As bdcampo, Optional ByVal LbFija As Lb = Nothing, Optional ByVal Obl As Boolean = False, Optional ByVal tipo As Cdatos.TiposCampo = -1, Optional ByVal ndec As Integer = -1, Optional ByVal lg As Integer = -1, Optional ByVal ex As String = "")


        Dim cl As New Cdatos.PropiedadesTx
        cl.CampoBd = CampoBd

        If tipo = -1 Then
            If Not CampoBd Is Nothing Then
                cl.Tipo = CampoBd.TipoBd
            Else
                cl.Tipo = TiposCampo.Cadena
            End If
        Else
            cl.Tipo = tipo
        End If
        If cl.Tipo = TiposCampo.Importe Then
            Control.TextAlign = LeftRightAlignment.Right
        End If
        If lg = -1 Then
            If Not CampoBd Is Nothing Then
                cl.Longitud = CampoBd.Longitud
            Else
                cl.Longitud = 10
            End If
        Else
            cl.Longitud = lg
        End If
        If ndec = -1 Then
            If Not CampoBd Is Nothing Then
                cl.Decimales = CampoBd.Decimales
            Else
                cl.Decimales = 0
            End If
        Else
            cl.Decimales = ndec
        End If
        cl.Exclusivos = ex
        cl.Obligatorio = Obl
        Control.Orden = Ncontrol
        Control.ClParam = cl
        Control.ClForm = Me
        If Not LbFija Is Nothing Then
            LbFija.CL_ControlAsociado = Control
            LbFija.CL_ValorFijo = True
        End If

        Me.ListaControles.Add(Control)

        Ncontrol = Ncontrol + 1

    End Sub


    Public Sub AsociarControles(ByRef tx As TxDato, ByRef boconsu As BtBusca, ByVal Origen As BtBusca, ByVal Tabla As Entidad,
                                Optional ByVal Campo As bdcampo = Nothing, Optional ByVal Etiq As Lb = Nothing,
                                Optional ByVal TextoToolTip As String = "Búsqueda alfabética")

        If Not boconsu Is Nothing Then
            If Not Origen Is Nothing Then
                boconsu.Image = Origen.Image
                boconsu.CL_CampoOrden = Origen.CL_CampoOrden
                boconsu.CL_DevuelveCampo = Origen.CL_DevuelveCampo
                boconsu.CL_ConsultaSql = Origen.CL_ConsultaSql
                boconsu.cl_formu = Origen.cl_formu
                boconsu.CL_BuscaAlb = Origen.CL_BuscaAlb
                boconsu.CL_campocodigo = Origen.CL_campocodigo
                boconsu.CL_camponombre = Origen.CL_camponombre
                boconsu.CL_dfecha = Origen.CL_dfecha
                boconsu.CL_hfecha = Origen.CL_hfecha
                boconsu.CL_ParamBusqueda = Origen.CL_ParamBusqueda
                boconsu.CL_xCentro = Origen.CL_xCentro
                boconsu.CL_EsId = Origen.CL_EsId
                boconsu.CL_CONSULTA = Origen.CL_CONSULTA

            End If
            tx.ClParam.BtBusca = boconsu
            'tt.SetToolTip(tx.ClParam.BtBusca, TextoToolTip)
            boconsu.CL_ControlAsociado = tx
            boconsu.CL_Entidad = Tabla

        End If
        If Not Campo Is Nothing Then
            tx.ClParam.CampoEnlace = Campo
            tx.ClParam.Entidadenlace = Tabla
            tx.ClParam.LabelEnlace = Etiq
            If Not IsNothing(Etiq) Then
                Etiq.CL_ValorFijo = False
                Etiq.CL_ControlAsociado = tx
            End If
        End If
    End Sub


    Private Sub ParamCb_Copia(ByVal Cb As CbBox, ByVal CampoBd As bdcampo, ByVal lbfija As Lb, ByVal CbCajon As CbBox)

        Cb.ClForm = Me
        Cb.Campobd = CampoBd
        If Not lbfija Is Nothing Then
            lbfija.CL_ControlAsociado = Cb
            lbfija.CL_ValorFijo = True
        End If
        Cb.DataSource = CbCajon.DataSource
        Cb.DisplayMember = CbCajon.DisplayMember
        Cb.ValueMember = CbCajon.ValueMember

    End Sub


    Private Sub CbDocumentoTalon_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbDocumentoTalon.SelectedIndexChanged

        If Not _bCargando Then

            Dim Id As String = CbDocumentoTalon.SelectedValue
            If VaInt(Id) > 0 Then

                Dim DocumentosBancos As New E_DocumentosBancos(Idusuario, cn)
                If DocumentosBancos.LeerId(Id) Then

                    Dim Tipo As String = (DocumentosBancos.DDB_TipoDocumento.Valor & "").Trim.ToUpper
                    If Tipo = "TALON" Then
                        TxFechaVto.Visible = False
                        TxFechaVto.Enabled = False
                    Else
                        TxFechaVto.Enabled = True
                        TxFechaVto.Visible = True
                    End If

                End If

            End If


            If TxFechaVto.Visible Then
                TxFechaVto.Select()
                TxFechaVto.Focus()
            Else
                TxImporte.Select()
                TxImporte.Focus()
            End If


        End If

    End Sub


    Private Sub CbDocumentoTalon_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles CbDocumentoTalon.KeyDown

        If e.KeyCode = Keys.Enter Then
            If CbDocumentoTalon.DroppedDown Then
                CbDocumentoTalon.DroppedDown = False
            Else
                If TxFechaVto.Visible Then
                    TxFechaVto.Select()
                    TxFechaVto.Focus()
                Else
                    TxImporte.Select()
                    TxImporte.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub TxFechaVto_Valida(edicion As System.Boolean) Handles TxFechaVto.Valida
        If edicion Then
            If Not TxFechaVto.MiError Then
                TxImporte.Select()
                TxImporte.Focus()
            End If
        End If
    End Sub

    Private Sub TxImporte_Valida(edicion As System.Boolean) Handles TxImporte.Valida
        If edicion Then
            If Not TxImporte.MiError Then

                Dim Importe As Decimal = VaDec(TxImporte.Text)
                Dim Numlet As String = NumLetra(Importe, True, False, "Euros", "Céntimos")
                Dim Numlet1 As String = ""
                Dim Numlet2 As String = ""
                parte2Cadena(Numlet, Numlet1, Numlet2, 50)

                TxImporteLetra1.Text = Numlet1
                TxImporteLetra2.Text = Numlet2

                TxDestinatario.Select()
                TxDestinatario.Focus()
            End If
        End If
    End Sub

    Private Sub TxDestinatario_Valida(edicion As System.Boolean) Handles TxDestinatario.Valida
        If edicion Then
            If Not TxDestinatario.MiError Then
                TxImporteLetra1.Select()
                TxImporteLetra1.Focus()
            End If
        End If
    End Sub

    Private Sub TxImporteLetra1_Valida(edicion As System.Boolean) Handles TxImporteLetra1.Valida
        If edicion Then
            If Not TxImporteLetra1.MiError Then
                TxImporteLetra2.Select()
                TxImporteLetra2.Focus()
            End If
        End If
    End Sub

    Private Sub TxImporteLetra2_Valida(edicion As System.Boolean) Handles TxImporteLetra2.Valida
        If edicion Then
            If Not TxImporteLetra2.MiError Then
                TxFecha.Select()
                TxFecha.Focus()
            End If
        End If
    End Sub

    Private Sub TxFecha_Valida(edicion As System.Boolean) Handles TxFecha.Valida
        If edicion Then
            If Not TxFecha.MiError Then
                btAceptar.Select()
                btAceptar.Focus()
            End If
        End If
    End Sub

    Private Sub TxFechaVto_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxFechaVto.KeyDown
        If e.KeyCode = Keys.Up Then
            CbDocumentoTalon.Select()
            CbDocumentoTalon.Focus()
            CbDocumentoTalon.DroppedDown = True
        End If
    End Sub

    Private Sub TxImporte_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImporte.KeyDown
        If e.KeyCode = Keys.Up Then
            If TxFechaVto.Visible Then
                TxFechaVto.Select()
                TxFechaVto.Focus()
            Else
                CbDocumentoTalon.Select()
                CbDocumentoTalon.Focus()
                CbDocumentoTalon.DroppedDown = True
            End If
        End If
    End Sub

    Private Sub TxDestinatario_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxDestinatario.KeyDown
        If e.KeyCode = Keys.Up Then
            TxImporte.Select()
            TxImporte.Focus()
        End If
    End Sub

    Private Sub TxImporteLetra1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImporteLetra1.KeyDown
        If e.KeyCode = Keys.Up Then
            TxImporteLetra1.Select()
            TxImporteLetra1.Focus()
        End If
    End Sub

    Private Sub TxImporteLetra2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxImporteLetra2.KeyDown
        If e.KeyCode = Keys.Up Then
            TxImporteLetra1.Select()
            TxImporteLetra1.Focus()
        End If
    End Sub

    Private Sub TxFecha_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxFecha.KeyDown
        If e.KeyCode = Keys.Up Then
            TxImporteLetra2.Select()
            TxImporteLetra2.Focus()
        End If
    End Sub
End Class