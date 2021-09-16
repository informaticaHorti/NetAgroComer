
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic

Public Class ArregloValoracion

    Inherits FrConsulta
 

    Dim err As New Errores

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

    End Sub


    Private Sub FrmConsultaSalidas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        GridView1.Appearance.GroupRow.Font = New Font(fuente.FontFamily, fuente.Size, FontStyle.Bold)

        BInforme.Visible = False
        GridView1.Appearance.HeaderPanel.BackColor = Color.Aquamarine

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

    End Sub

    Public Overrides Sub Consultar()
        MyBase.Consultar()

        Dim cncopia As New Cdatos.Conexion(TextBox1.Text)
        Dim albentrada As New E_AlbEntrada(Idusuario, cn)
        Dim albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim albentrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)

        Dim B_albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cncopia)
        Dim B_albentrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cncopia)
        cncopia.AbrirConexion()

    
        Dim consulta As New Cdatos.E_select

        consulta.SelCampo(albentrada_lineascla.ALC_id, "ID")
        consulta.SelCampo(albentrada_lineas.AEL_idlinea, "IDLINEA", albentrada_lineascla.ALC_idlineaentrada)
        consulta.SelCampo(albentrada_lineas.AEL_muestreo, "PARTIDA")
        consulta.SelCampo(albentrada.AEN_TipoFCS, "TIPO", albentrada_lineas.AEL_idalbaran)
        consulta.SelCampo(albentrada.AEN_IdAgricultor, "Codigo")
        consulta.SelCampo(albentrada_lineas.AEL_precio, "Precio_P")
        consulta.SelCampo(albentrada_lineascla.ALC_precio, "Precio_L")
        consulta.WheCampo(albentrada_lineas.AEL_FechaValoracion, "=", "14/10/2015")
        consulta.WheCampo(albentrada.AEN_TipoFCS, "<>", "C")


        Dim sql As String = consulta.SQL

        Dim dt As DataTable = albentrada.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then

            dt.Columns.Add("Precio_PAR", GetType(System.Decimal))
            dt.Columns.Add("Precio_CLA", GetType(System.Decimal))
            dt.Columns.Add("Valoracion", GetType(System.DateTime))

            For Each rw In dt.Rows
                If B_albentrada_lineas.LeerId(rw("IDLINEA").ToString) = True Then
                    rw("PRECIO_PAR") = VaDec(B_albentrada_lineas.AEL_precio.Valor)
                    rw("VALORACION") = VaDate(B_albentrada_lineas.AEL_FechaValoracion.Valor)
                Else
                    rw("PRECIO_PAR") = -1
                End If
                If B_albentrada_lineascla.LeerId(rw("ID").ToString) = True Then
                    rw("PRECIO_CLA") = VaDec(B_albentrada_lineascla.ALC_precio.Valor)
                Else
                    rw("PRECIO_CLA") = -1
                End If


            Next
        End If

        cncopia.CerrarConexion()


        GridView1.Columns.Clear()
        Grid.DataSource = dt

        AjustaColumnas()
    End Sub
    Private Sub AjustaColumnas()

        Grid.ForceInitialize()
       

        GridView1.BestFitColumns()
    End Sub

    Private Sub BConsultar_Click(sender As System.Object, e As System.EventArgs) Handles BConsultar.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        Dim albentrada As New E_AlbEntrada(Idusuario, cn)
        Dim albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim albentrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)

        If MsgBox("Desea actualizar los precios", vbYesNo) = vbYes Then
            Dim dt As DataTable = Grid.DataSource
            For Each rw In dt.Rows

                Dim idpar As String = rw("idlinea").ToString
                Dim idcla As String = rw("id").ToString

                Dim preciopar As Decimal = VaDec(rw("precio_par")) ' los buenos
                Dim preciocla As Decimal = VaDec(rw("precio_cla"))
                Dim FeValoracion As String = rw("valoracion").ToString
                Dim preciop As Decimal = VaDec(rw("precio_p")) ' los malos
                Dim preciol As Decimal = VaDec(rw("precio_l"))

                If preciopar <> -1 Then
                    ' If preciopar <> preciop Then
                    If albentrada_lineas.LeerId(idpar) = True Then
                        albentrada_lineas.AEL_precio.Valor = preciopar.ToString
                        albentrada_lineas.AEL_FechaValoracion.Valor = fevaloracion
                        albentrada_lineas.Actualizar()
                    End If
                    'End If
                End If

                If preciocla <> -1 Then
                    If preciocla <> preciol Then
                        If albentrada_lineascla.LeerId(idcla) = True Then
                            albentrada_lineascla.ALC_precio.Valor = preciocla.ToString
                            albentrada_lineascla.Actualizar()
                        End If
                    End If
                End If
            Next
        End If
    End Sub


    Private Sub BORRARCOMISION()
        Dim albentrada As New E_AlbEntrada(Idusuario, cn)
        Dim albentrada_lineas As New E_AlbEntrada_lineas(Idusuario, cn)
        Dim albentrada_lineascla As New E_AlbEntrada_lineascla(Idusuario, cn)


        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(albentrada_lineascla.ALC_id, "ID")
        consulta.SelCampo(albentrada_lineas.AEL_idlinea, "IDLINEA", albentrada_lineascla.ALC_idlineaentrada)
        consulta.SelCampo(albentrada_lineas.AEL_muestreo, "PARTIDA")
        consulta.SelCampo(albentrada.AEN_TipoFCS, "TIPO", albentrada_lineas.AEL_idalbaran)
        consulta.SelCampo(albentrada_lineas.AEL_precio, "Precio_P")
        consulta.SelCampo(albentrada_lineascla.ALC_precio, "Precio_L")
        consulta.WheCampo(albentrada_lineas.AEL_FechaValoracion, "=", "14/10/2015")
        consulta.WheCampo(albentrada.AEN_TipoFCS, "=", "C")


        Dim sql As String = consulta.SQL

        Dim dt As DataTable = albentrada.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                Dim idpar As String = rw("idlinea").ToString
                Dim idcla As String = rw("id").ToString

                If albentrada_lineas.LeerId(idpar) = True Then
                    albentrada_lineas.AEL_precio.Valor = "0"
                    albentrada_lineas.AEL_FechaValoracion.Valor = "01/01/1900"
                    albentrada_lineas.Actualizar()
                End If

                If albentrada_lineascla.LeerId(idcla) = True Then
                    albentrada_lineascla.ALC_precio.Valor = "0"
                    albentrada_lineascla.Actualizar()
                End If
            Next
        End If


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If MsgBox("Desea borrar valoracion a comision", vbYesNo) = vbYes Then
            BORRARCOMISION()
            MsgBox("terminado")
        End If
    End Sub
End Class