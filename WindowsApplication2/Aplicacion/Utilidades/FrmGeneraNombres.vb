Imports DevExpress.XtraEditors


Public Class FrmGeneraNombres

    Inherits FrConsulta

    Dim _reg As Integer
    Dim _dt As DataTable
    Dim err As New Errores
    Dim Aleatorio As New Random()

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        BInforme.Visible = False
        GridView1.Appearance.HeaderPanel.BackColor = Color.Aquamarine

        BtAux.Image = My.Resources.App_kservices_16x16_32
        BtAux.Text = "Actualizar"
        BtAux.Visible = True

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub

    Public Overrides Sub Consultar()
        MyBase.Consultar()


        Dim sql As String = "Select * from nombres"


        _dt = cn.ConsultaSQL(sql)
        _reg = _dt.Rows.Count - 2

        GridView1.Columns.Clear()
        Grid.DataSource = _dt

        GridView1.BestFitColumns()

    End Sub


    Private Function Vnombre(min As Integer, max As Integer) As String

        Dim n As String = ""
        Dim Correcto As Boolean = False

        While Correcto = False


            Dim r As Integer = Aleatorio.Next(min, max)

            n = _dt.Rows(r)(0).ToString

            If Len(n) > 8 And Len(n) < 50 Then
                Correcto = True
            End If

        End While
        Return n
    End Function
    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()

        Dim clientes As New E_Clientes(Idusuario, cn)
        Dim Agricultores As New E_Agricultores(Idusuario, cn)

        If XtraMessageBox.Show("¿Desea generar los nombres ", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

            Dim cont As Integer = 0
            Dim sql As String = "Select Cli_idcliente as codigo from clientes "
            Dim dt As DataTable = cn.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                For Each rw In dt.Rows
                    Dim c As Integer = VaInt(rw("Codigo"))
                    Dim n As String = Vnombre(1, _reg / 2)
                    If clientes.LeerId(c) = True Then
                        If AlbaranesCliente(c) = True Then
                            clientes.CLI_Nombre.Valor = n
                            clientes.Actualizar()
                        Else
                            clientes.Eliminar()
                        End If
                    End If
                Next
            End If
            sql = "Select agr_idagricultor as codigo from agricultores"
            dt = cn.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                For Each rw In dt.Rows
                    Dim c As Integer = VaInt(rw("Codigo"))
                    Dim n As String = Vnombre(_reg / 2 + 1, _reg)
                    If Agricultores.LeerId(c) = True Then
                        If AlbaranesProveedor(c) = True Then
                            Agricultores.AGR_Nombre.Valor = n
                            Agricultores.Actualizar()
                        Else
                            Agricultores.Eliminar()
                        End If
                    End If
                Next
            End If

            MsgBox("Terminado")
        End If


    End Sub

    Private Function AlbaranesProveedor(idproveedor As Integer) As Boolean

        Dim AlbEntrada_his As New E_AlbEntrada_his(Idusuario, cn)
        Dim consulta As New Cdatos.E_select
        Dim ret As Boolean = False
        consulta.SelCampo(AlbEntrada_his.AEH_id)
        consulta.WheCampo(AlbEntrada_his.AEH_idproveedor, "=", idproveedor.ToString)
        Dim dt As DataTable = AlbEntrada_his.MiConexion.ConsultaSQL(consulta.SQL)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = True
            End If
        End If


        Return ret

    End Function

    Private Function AlbaranesCliente(idcliente As Integer) As Boolean
        Dim AlbSalida As New E_AlbSalida(Idusuario, cn)
        Dim consulta As New Cdatos.E_select

        Dim ret As Boolean = False

        consulta.SelCampo(AlbSalida.ASA_idalbaran)
        consulta.WheCampo(AlbSalida.ASA_idcliente, "=", idcliente.ToString)
        Dim dt As DataTable = AlbSalida.MiConexion.ConsultaSQL(consulta.SQL)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                ret = True
            End If
        End If
        Return ret

    End Function
End Class