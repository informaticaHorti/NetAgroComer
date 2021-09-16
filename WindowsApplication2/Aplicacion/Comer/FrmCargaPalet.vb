Imports DevExpress.XtraEditors.Controls
Imports System.IO.Ports

Public Class FrmCargaPalet

    Inherits FrMantenimiento
    Dim Palets As New E_palets(Idusuario, cn)
    Dim Palets_lineas As New E_palets_lineas(Idusuario, cn)
    Dim albsalida_palets As New E_albsalida_palets(Idusuario, cn)
    Dim Cargas As New E_Cargas(Idusuario, cn)
    Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
    Dim Categorias As New E_CategoriasSalida(Idusuario, cn)
    Dim cargas_palets As New E_Cargas_Palets(Idusuario, cn)

    Dim Marcas As New E_Marcas(Idusuario, cn)
    Dim _Idmuelle As Integer

    Dim _texto As String = ""



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        '        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
        '        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Private Sub FrmCargaPalet_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Try

            SerialPort1.PortName = PuertoLector
            SerialPort1.BaudRate = 9600
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.DataBits = 8
            SerialPort1.Handshake = Handshake.None
            SerialPort1.RtsEnable = True

            If SerialPort1.PortName.Trim <> "" Then
                SerialPort1.Open()
            End If

        Catch ex As Exception

        End Try
        

    End Sub


    Public Sub initcarga(idmuelle As Integer)
        _Idmuelle = idmuelle
        LbMuelle.Text = idmuelle.ToString

    End Sub


    Private Sub ParametrosFrm()
        EntidadFrm = Palets


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxPalet, Cargas.CAR_Numero, LbCarga, True)
        CampoClave = 0 ' ultimo campo de la clave
        BModificar.Visible = False
        BAnular.Visible = False
        BModificar.Enabled = False
        BAnular.Enabled = False

    End Sub


    Public Overrides Sub ControlClave()
        ' componemos la clave
        Dim i As Integer


        i = Palets.Leerpalet(MiMaletin.Ejercicio, MiMaletin.IdCentro, CInt(TxPalet.Text))
        If i > 0 Then

            Dim idalbaran = albsalida_palets.AlbaranPalet(i)
            If VaInt(idalbaran) > 0 Then
                MsgBox("Palet ya cargado")
            ElseIf cargas_palets.LeerId(i) = True Then
                MsgBox("Palet en proceso de carga")
            ElseIf Palets.PAL_finalizado.Valor = "N" Then

                MsgBox("Palet sin terminar")

            Else

                LbId.Text = i.ToString
                Modificando = True
                BGuardar.Select()
                BGuardar.Focus()
            End If
        Else
            MsgBox("Inexistente")
        End If


    End Sub

    Public Overrides Sub Guardar()

        If VaInt(LbId.Text) > 0 Then

            If cargas_palets.LeerId(LbId.Text) = False Then
                cargas_palets.CGL_idpalet.Valor = LbId.Text
                cargas_palets.CGL_idmuelle.Valor = _Idmuelle
                cargas_palets.Insertar()
            Else
                cargas_palets.CGL_idpalet.Valor = LbId.Text
                cargas_palets.CGL_idmuelle.Valor = _Idmuelle
                cargas_palets.Actualizar()


            End If

        End If
        MyBase.Guardar()

    End Sub


    Public Overrides Sub Entidad_a_Datos()
        MyBase.Entidad_a_Datos()
        LbFecha.Text = Palets.PAL_fecha.Valor
        If VaInt(LbId.Text) > 0 Then
            cargarlineas()
        End If
    End Sub


    Private Sub cargarlineas()

        Dim sql As String
        Dim consulta As New Cdatos.E_select



        consulta.SelCampo(Palets_lineas.PLL_idgensal, "idgensal")

        consulta.SelCampo(GenerosSalida.GES_Nombre, "Presentacion", Palets_lineas.PLL_idgensal)
        consulta.SelCampo(Categorias.CAS_CategoriaCalibre, "Categoria", Palets_lineas.PLL_idcategoria)
        consulta.SelCampo(Marcas.MAR_Nombre, "Marca", Palets_lineas.PLL_idmarca)
        consulta.SelCampo(Palets_lineas.PLL_bultos, "Bultos")
        consulta.SelCampo(Palets_lineas.PLL_kilosnetos, "Kilos")
        consulta.WheCampo(Palets_lineas.PLL_idpalet, "=", LbId.Text)
        sql = consulta.SQL
        Dim dt As DataTable = Palets_lineas.MiConexion.ConsultaSQL(sql)
        Grid.DataSource = dt
        AjustaColumnas()



    End Sub



    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Grid.DataSource = Nothing
        _texto = ""

    End Sub


    Private Sub AjustaColumnas()


        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "PRESENTACION"
                    c.Width = 400
                Case "CATEGORIA", "MARCA"
                    c.Width = 150
                Case "KILOS", "BULTOS"
                    c.Width = 100
                Case Else
                    c.Visible = False
            End Select
        Next


    End Sub


    Private Sub FrmCargaPalet_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try
            SerialPort1.Close()
        Catch ex As Exception

        End Try


    End Sub


    Private Sub SerialPort1_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        Dim sp As SerialPort = CType(sender, SerialPort)
        Dim datos As String = sp.ReadExisting()

        _texto = _texto & datos

        If datos.Contains(vbCrLf) Then

            Replace(_texto, vbCrLf, "")

            Dim parametros As String = _texto
            Me.Invoke(New LeerCodigoBarras_Delegate(AddressOf LeerCodigoBarras), New Object() {Parametros})
            _texto = ""


        End If

    End Sub


    Private Delegate Sub LeerCodigoBarras_Delegate(datos As String)
    Private Sub LeerCodigoBarras(datos As String)

        Dim codigo As String() = Split(datos, ".")
        If codigo.Length = 2 Then
            If codigo(0).StartsWith("TP") Then
                Dim Campa As String = codigo(0).Replace("TP", "")
                If VaInt(Campa) <> MiMaletin.Ejercicio Then
                    MsgBox("El palet introducido pertenece a otra campaña")
                    Exit Sub
                Else
                    Dim NumPalet As String = codigo(1)
                    Dim I As Integer = 0
                    If VaInt(NumPalet) > 0 Then
                        I = Palets.Leerpalet(MiMaletin.Ejercicio, MiMaletin.IdCentro, CInt(NumPalet))
                        If I > 0 Then
                            Dim idalbaran = albsalida_palets.AlbaranPalet(I)
                            If VaInt(idalbaran) > 0 Then
                                MsgBox("Palet ya cargado")
                            ElseIf cargas_palets.LeerId(I) = True Then
                                MsgBox("Palet en proceso de carga")
                            Else
                                If cargas_palets.LeerId(I) = False Then
                                    cargas_palets.CGL_idpalet.Valor = I
                                    cargas_palets.CGL_idmuelle.Valor = _Idmuelle
                                    cargas_palets.CGL_nupalet.Valor = NumPalet
                                    cargas_palets.CGL_hora.Valor = Format(Now, "hh:mm:ss")
                                    cargas_palets.Insertar()
                                Else
                                    cargas_palets.CGL_idpalet.Valor = I
                                    cargas_palets.CGL_idmuelle.Valor = _Idmuelle
                                    cargas_palets.CGL_nupalet.Valor = NumPalet
                                    cargas_palets.CGL_hora.Valor = Format(Now, "hh:mm:ss")
                                    cargas_palets.Actualizar()
                                End If
                            End If
                        Else
                            MsgBox("Inexistente")
                        End If

                    End If

                End If

            End If

        End If

 



    End Sub



    Private Sub TxPalet_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxPalet.TextChanged

    End Sub
End Class