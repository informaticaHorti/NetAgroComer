Imports System.Reflection
Imports System.IO

Public Class FrmListadoVentasIntracomunitarias
    Inherits FrConsulta


    Private Clientes As New E_Clientes(Idusuario, cn)
    Private Facturas As New E_Facturas(Idusuario, cn)
    Private Paises As New E_Paises(Idusuario, CnComun)
    Private Empresas As New E_Empresas(Idusuario, cn)
    Private Regiva As New E_TipoIvaSoportado(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Private IvaSoportado As New E_IvaSoportado(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Private Cuentas As New E_Cuentas(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Private Asientos As New E_Asientos(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Private AsientoLineas As New E_AsientoLineas(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Private TipoivaSoportado As New E_TipoIvaSoportado(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))

    Private AcumConcedido As Decimal = 0


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ' ParamCb_Copia(CbEmpresas, Empresas.EMP_Nombre, LbEmpresa, Combos.ComboEmp)
        ParamTx(TxDesdeCliente, Clientes.CLI_Codigo, LbDesdeCliente)
        ParamTx(TxHastaCliente, Clientes.CLI_Codigo, LbHastaCliente)
        ParamTx(TxDesdeFecha, Facturas.FRA_fecha, LbDesdeFecha)
        ParamTx(TxHastaFecha, Facturas.FRA_fecha, LbHastaFecha)

        ParamTx(TxRutafichero, Nothing, LbRutafichero, , Cdatos.TiposCampo.Cadena, , 1000)
        ParamTx(TxEjercicio, Nothing, LbEjercicio, , Cdatos.TiposCampo.Cadena)
        ParamTx(TxPeriodo, Nothing, LbPeriodo, , Cdatos.TiposCampo.Cadena)
        ParamTx(TxTelefono, Nothing, LbTelefono, , Cdatos.TiposCampo.Cadena, , 9)
        ParamTx(TxPersona, Nothing, LbPersona, , Cdatos.TiposCampo.Cadena, , 40)



        AsociarControles(TxDesdeCliente, BtBuscaDesdeCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomDesdeCliente)
        AsociarControles(TxHastaCliente, BtBuscaHastaCliente, Clientes.btBusca, Clientes, Clientes.CLI_Nombre, LbNomHastaCliente)

        '  AsignarCalendarioSemanalTxDato(TxDesdeFecha, TxHastaFecha)

    End Sub


    Private Sub FrmConsultaPalets_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        'CbEmpresas = Combos.ComboEmp()

        BtAux.Visible = True
        BtAux.Text = "Generar"
        BtAux.Image = NetAgro.My.Resources.Resources.App_kservices_16x16_32


        Dim fuente As Font = GridView1.Appearance.GroupRow.Font
        Dim nueva_fuente As New Font(fuente.Name, fuente.Size, FontStyle.Bold)

        GridView1.Appearance.GroupRow.Font = nueva_fuente

    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        Fechaspordefecto()

    End Sub


    Private Sub Fechaspordefecto()
        TxDesdeFecha.Text = MiMaletin.FechaInicioEjercicio.ToString("dd/MM/yyyy")
        TxHastaFecha.Text = MiMaletin.FechaFinEjercicio.ToString("dd/MM/yyyy")
    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()



        Dim sqlWhere As String = " WHERE Facturas.FRA_idempresa = '" & MiMaletin.IdEmpresaCTB & "'" & vbCrLf


        'Fechas
        If TxDesdeFecha.Text.Trim <> "" Then
            sqlWhere = sqlWhere & " AND FRA_Fecha >= '" & TxDesdeFecha.Text & "'" & vbCrLf
        End If
        If TxHastaFecha.Text.Trim <> "" Then
            sqlWhere = sqlWhere & " AND FRA_Fecha <= '" & TxHastaFecha.Text & "'" & vbCrLf
        End If



        'Clientes
        If TxDesdeCliente.Text.Trim <> "" Then
            sqlWhere = sqlWhere & " AND FRA_IdCliente >= " & TxDesdeCliente.Text & vbCrLf
        End If
        If TxHastaCliente.Text.Trim <> "" Then
                sqlWhere = sqlWhere & " AND FRA_IdCliente <= " & TxHastaCliente.Text & vbCrLf
        End If

        Dim SqlMercado As String = ""
        'Mercado Nacional
        If ChMercadoNacional.Checked Then
            SqlMercado = " IdPais = 1" & vbCrLf
        End If



        'Paises Comunitarios

        If ChPaisesComunitarios.Checked Then

            If SqlMercado = "" Then
                SqlMercado = "(Comunitario = 'S' "
            Else
                SqlMercado = SqlMercado + " or (Comunitario = 'S' "
            End If

            If ChMercadoNacional.Checked = False Then
                SqlMercado = SqlMercado & " AND IdPais <> 1 )" & vbCrLf
            Else
                SqlMercado = SqlMercado & " )" & vbCrLf
            End If


        End If


        If ChPaisesNoComunitarios.Checked Then

            'Paises no Comunitarios
            If SqlMercado = "" Then
                SqlMercado = "(Comunitario = 'N' "
            Else
                SqlMercado = SqlMercado + " or (Comunitario = 'N' "

            End If

            If ChMercadoNacional.Checked = False Then
                SqlMercado = SqlMercado & " AND IdPais <> 1 )" & vbCrLf
            Else
                SqlMercado = SqlMercado & " )" & vbCrLf
            End If

        End If

        If SqlMercado <> "" Then
            sqlWhere = sqlWhere + " and ( " + SqlMercado + " ) "
        Else
            sqlWhere = sqlWhere + " AND 1=0 " ' NO HA SELECCIONADO NINGUN TIPO DE CLIENTE

        End If


        Dim sql As String = "SELECT FRA_IdCliente as IdCliente, CLI_Nif as Nif, CLI_Nombre as Sujeto, FRA_Fecha as Fecha, Nombre as Pais, Siglas as PSiglas,"
        sql = sql & " (COALESCE(FRA_Base1,0) + COALESCE(FRA_Base2,0) + COALESCE(FRA_Base3,0) + COALESCE(FRA_Base4,0)) * COALESCE(FRA_valorcambio,0) as BaseImp" & vbCrLf
        'sql = sql & " FRA_totalfactura as TotalFactura," & vbCrLf
        'sql = sql & " COALESCE((SELECT SUM(CBL_ImporteCobradoDivisa * COALESCE(CBL_Cambio,1)) as Importe FROM CobrosLineas WHERE CBL_IdFactura = FRA_IdFactura),0) as Cobrado" & vbCrLf
        sql = sql & " FROM Facturas" & vbCrLf
        sql = sql & " LEFT JOIN Clientes ON FRA_IdCliente = CLI_IdCliente" & vbCrLf
        sql = sql & " LEFT JOIN comun.dbo.Paises ON FRA_CdPais = IdPais" & vbCrLf
        sql = sql & sqlWhere



        Dim sqlf As String = "SELECT 'E' as Tipo,  Nif, Sujeto, Pais, PSiglas, SUM(BaseImp) as BaseImp" & vbCrLf

        sqlf = sqlf & " FROM (" & sql & ") as F" & vbCrLf
        sqlf = sqlf & " GROUP BY  Nif, Sujeto, Pais, PSiglas"


        Dim dt As DataTable = Facturas.MiConexion.ConsultaSQL(sqlf)

        If ChKCompras.Checked = True Then
            dt = AñadirIvaSoportado(dt)
        End If
        Grid.DataSource = dt




        'OJO con las mayúsculas / minúsculas
        AñadeResumenCampo("BaseImp", "{0:n2}")
        AjustaColumnas()



    End Sub


    Private Function AñadirIvaSoportado(dt As DataTable) As DataTable

        Dim consulta As New Cdatos.E_select

        consulta.SelCampo(IvaSoportado.IdRegistro)
        consulta.SelCampo(Cuentas.Nif, "Nif", IvaSoportado.idcuenta)
        consulta.SelCampo(Cuentas.Nombre, "Sujeto")
        consulta.SelCampo(Paises.Nombre, "Pais", Cuentas.IdPais)
        consulta.SelCampo(Paises.Siglas, "PSiglas")
        Dim obase As New Cdatos.bdcampo("@ivasoportado.base1+ivasoportado.base2+ivasoportado.base3+ivasoportado.base4", Cdatos.TiposCampo.Importe, 10, 2)
        consulta.SelCampo(obase, "Baseimp")
        consulta.SelCampo(AsientoLineas.IdAsiento, "idasiento", IvaSoportado.IdRegistro)
        consulta.SelCampo(Asientos.Fecha, "fecha", AsientoLineas.IdAsiento)
        consulta.SelCampo(TipoivaSoportado.Clave340, "clave", IvaSoportado.idTipoIvaSoportado)

        consulta.WheCampo(Asientos.Fecha, ">=", TxDesdeFecha.Text)
        consulta.WheCampo(Asientos.Fecha, "<=", TxHastaFecha.Text)
        consulta.WheCampo(TipoivaSoportado.Adquisiciones, "=", "S")

        Dim sql As String = consulta.SQL

        Dim sqlf As String = "SELECT 'I' as Tipo, Nif, Sujeto, Pais, PSiglas, SUM(BaseImp) as BaseImp" & vbCrLf
        sqlf = sqlf & " FROM (" & sql & ") as F" & vbCrLf
        'sqlf = sqlf & " WHERE (COALESCE(TotalFactura,0) - COALESCE(Cobrado,0)) <= 0 " & vbCrLf
        sqlf = sqlf & " GROUP BY  Nif, Sujeto, Pais, PSiglas"


        Dim dts As DataTable = IvaSoportado.MiConexion.ConsultaSQL(sqlf)
        If Not dts Is Nothing Then
            If dts.Rows.Count > 0 Then
                dt.Merge(dts)
            End If
        End If
        Return dt


    End Function

    Private Sub AjustaColumnas()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "TIPO", "BASEIMP", "NIF", "SUJETO", "PAIS", "PSIGLAS"
                    c.Visible = True

                Case Else
                    c.Visible = False
            End Select
        Next


        GridView1.BestFitColumns()

        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Select Case c.FieldName.ToUpper.Trim
                Case "BASEIMP"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,##0.00"
            End Select
        Next


    End Sub


    Public Overrides Sub Imprimir()


        LineasDescripcion.Clear()

        Dim empresa As String = "Empresa " & MiMaletin.NombreEmpresa
        Dim clientes As String = FiltroDesdeHasta("Cliente", TxDesdeCliente.Text, TxHastaCliente.Text)
        Dim fechas As String = FiltroDesdeHasta("Fecha", TxDesdeFecha.Text, TxHastaFecha.Text)

        If empresa <> "" Then LineasDescripcion.Add(empresa)
        If clientes <> "" Then LineasDescripcion.Add(clientes)
        If fechas <> "" Then LineasDescripcion.Add(fechas)

        MyBase.Imprimir()

    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()


        Dim dt As DataTable = CType(Grid.DataSource, DataTable)



        Dim bDatos As Boolean = True

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then




                Dim Pais As String = ""
                If ChMercadoNacional.Checked Then
                    Pais = "Mercado Nacional"
                ElseIf ChPaisesComunitarios.Checked Then
                    If Pais <> "" Then
                        Pais = Pais & ", Paises Comunitarios"
                    Else
                        Pais = Pais & "Paises Comunitarios"
                    End If

                ElseIf ChPaisesNoComunitarios.Checked Then

                    If Pais <> "" Then
                        Pais = Pais & ", Paises No Comunitarios"
                    Else
                        Pais = Pais & "Paises No Comunitarios"
                    End If

                End If



                Dim listado As New Listado_VentasIntracomunitarias(dt, MiMaletin.NombreEmpresa, TxDesdeCliente.Text, TxHastaCliente.Text, TxDesdeFecha.Text, TxHastaFecha.Text, Pais, TipoImpresion.Preliminar)
                listado.ImprimirListado()


            Else
                bDatos = False
            End If
        Else
            bDatos = False
        End If


        If Not bDatos Then
            MessageBox.Show("No hay datos que imprimir")
        End If


    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        TxRutafichero.Text = ObtenerFichero()

    End Sub

    Private Function ObtenerFichero() As String

        Dim myStream As Stream = System.IO.Stream.Null
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "txt files (*.txt)|*.txt"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then

            myStream = saveFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then
                ' Code to write the stream goes here.
                myStream.Close()
            End If

        End If

        Dim resultado As String = Nothing
        Try
            resultado = DirectCast(myStream, System.IO.FileStream).Name.ToString
        Catch ex As Exception

        End Try


        Return resultado

    End Function



    Private Sub GeneraFichero()

        Dim Cadena As String = ""
       
        Dim Regi As Integer = 0

        Dim RegiNeg As Integer = 0
        Dim x As Integer = 0
        Dim ba As Decimal = 0
        Dim Re As Decimal = 0
        Dim cp As String = ""
        Dim i As Integer = 0
        Dim nue As String = ""
        Dim SiglasP As String = ""
        Dim P As Integer = 0
        Dim Bas As String = ""
        Dim ImporteTotal As Decimal = 0


        Dim nomemp As String = ""
        Dim NomOpe As String = ""
        Dim NifOpe As String = ""
        Dim NifEmp As String = ""
        Dim ImpEnt As String = ""
        Dim ImpDec As String = ""
        Dim TelCon As String = TxTelefono.Text
        Dim NomCon As String = ""

        If TxRutafichero.Text = "" Then

            TxRutafichero.MiError = True
            Exit Sub

        End If


        If TxPeriodo.Text = "" Then
            MsgBox("Falta por introducir el período")
            Exit Sub
        End If


        'Cargamos En variables los datos de la empresa seleccionada.
        Dim Empresas As New E_Empresas(Idusuario, cn)

        If Empresas.LeerId(MiMaletin.IdEmpresaCTB.ToString) Then

            nue = MiMaletin.IdEmpresaCTB.ToString
            NifEmp = Empresas.EMP_CIF.Valor
            nomemp = Empresas.EMP_Nombre.Valor

        Else

            Exit Sub


        End If


        NomCon = Mid(TxPersona.Text, 1, 50)



        Dim dtTabla As New DataTable


        dtTabla.Columns.Add(New DataColumn("TipoRegistro", GetType(String)))
        dtTabla.Columns.Add(New DataColumn("Modelo", GetType(String)))
        dtTabla.Columns.Add(New DataColumn("Ejercicio", GetType(String)))
        dtTabla.Columns.Add(New DataColumn("CifEmpresa", GetType(String)))
        dtTabla.Columns.Add(New DataColumn("CodPais", GetType(String)))
        dtTabla.Columns.Add(New DataColumn("CifCliente", GetType(String)))
        dtTabla.Columns.Add(New DataColumn("NombreCliente", GetType(String)))
        dtTabla.Columns.Add(New DataColumn("Entrega", GetType(String)))
        dtTabla.Columns.Add(New DataColumn("ImporteInt", GetType(Integer)))
        dtTabla.Columns.Add(New DataColumn("ImporteDec", GetType(Decimal)))

        Dim dt As DataTable = Grid.DataSource


        If Not IsNothing(dt) Then

            For Each row In dt.Rows



                NifOpe = (row("nif").ToString & "").Trim
                NomOpe = (row("sujeto").ToString & "").Trim
                SiglasP = (row("PSiglas").ToString & "").Trim
                Dim Importe As Decimal = VaDec(row("Baseimp"))
                Dim TotImporte As Decimal = Math.Abs(Importe)
                Dim ParteEntera As Decimal = Math.Truncate(TotImporte)
                Dim ParteDecimal As Decimal = (TotImporte - Math.Truncate(TotImporte)) * 100



                If Importe > 0 Then
                    ImpEnt = Format(ParteEntera, "0000000000000")
                    ImpDec = Format(ParteDecimal, "00")


                    importetotal = importetotal + Importe


                    Dim fila As DataRow = dtTabla.NewRow

                    fila("TipoRegistro") = "2"
                    fila("Modelo") = "349"
                    fila("Ejercicio") = FnSpace(TxEjercicio.Text, 4)
                    fila("CifEmpresa") = FnSpace(NifEmp, 9)
                    fila("CodPais") = FnSpace((row("PSiglas").ToString & "").Trim, 2)
                    fila("CifCliente") = FnSpace(NifOpe, 15)
                    fila("NombreCliente") = FnSpace(LIMPIANOMBRE(NomOpe), 40)
                    fila("Entrega") = FnSpace(row("tipo"), 1)
                    fila("ImporteInt") = ParteEntera
                    fila("ImporteDec") = ParteDecimal

                    dtTabla.Rows.Add(fila)
                    Regi = Regi + 1
                End If

            Next


            Dim TotImporte2 As Decimal = Math.Abs(importetotal)
            Dim ParteEntera2 As Decimal = Math.Truncate(ImporteTotal)
            Dim ParteDecimal2 As Decimal = (ImporteTotal - Math.Truncate(ImporteTotal)) * 100

            Cadena = "1"                                                '  1:  0-  1 TIPO REGISTRO
            Cadena = Cadena + "349"                                     '  3:  2-  4 modelo
            Cadena = Cadena + FnSpace(TxEjercicio.Text, 4)              '  4:  5-  8 ejercicio
            Cadena = Cadena + FnSpace(NifEmp, 9)                         '  9:  9- 17 cif
            Cadena = Cadena + FnSpace(nomemp, 40)                        ' 40: 18- 57 nombre empresa
            Cadena = Cadena + "T"                                       '  1: 58- 58 telemático
            Cadena = Cadena + FnSpace(TelCon, 9)                                    '  9: 59- 67 tff
            Cadena = Cadena + FnSpace(NomCon, 40)                                    ' 40: 68-107 nombre contacto
            Cadena = Cadena + "3490000000000"                                      ' 13:108-120 nºident.dec.
            Cadena = Cadena + Space(2)                                      '  2:121-122 Comp./Sust./
            Cadena = Cadena + "0000000000000"                                     ' 13:123-135 nºident.dec.comp./sus
            Cadena = Cadena + FnSpace(TxPeriodo.Text, 2)                            '  2:136-137 período
            Cadena = Cadena + Format(Regi, "000000000")                 '  9:138-146 nº operadores
            Cadena = Cadena + Format(ParteEntera2, "0000000000000")         ' 13:147-159 importe, ent.
            Cadena = Cadena + Format(ParteDecimal2, "00")                                  '  2:160-161 importe, dec.
            Cadena = Cadena + Format(RegiNeg, "000000000")              '  9:162-170 nº operadores negat.
            Cadena = Cadena + "0000000000000"                                    ' 13:171-183 importe, ent. neg.
            Cadena = Cadena + "00"                                    '  2:184-185 importe, dec. neg.
            Cadena = Cadena + " "                                       '  1:186-186 cambio periodicidad
            Cadena = Cadena + Space(204)                                '204:187-390 nada
            Cadena = Cadena + Space(9)                                  '  9:391-399 nif reo. legal
            Cadena = Cadena + Space(88)                                 ' 88:400-487 nada
            Cadena = Cadena + Space(13)                                 ' 13:488-500 sello electrónico

            Cadena = FnSpace(Cadena, 500)


            'ESCRIBIMOS LOS DATOS EN EL ARCHIVO TXT


            If (IO.File.Exists(TxRutafichero.Text)) Then


                Dim sw As System.IO.StreamWriter

                ' Try
                Dim col As Integer = 0

                sw = New IO.StreamWriter(TxRutafichero.Text, False, System.Text.Encoding.Default)

                'Escribimos el contenido de cadena


                sw.WriteLine(Cadena)
                Cadena = String.Empty

                For Each r In dtTabla.Rows

                    Dim CifCliente As String = (r("CifCliente").ToString & "").Trim

                    If Mid(CifCliente, 1, 2) = (r("CodPais").ToString & "").Trim Then

                        CifCliente = Mid(CifCliente, 3)

                    End If


                    Cadena = (r("TipoRegistro").ToString & "").Trim
                    Cadena = Cadena + (r("Modelo").ToString & "").Trim
                    Cadena = Cadena + (r("Ejercicio").ToString & "").Trim
                    Cadena = Cadena + FnSpace((r("CifEmpresa").ToString & "").Trim, 9)
                    Cadena = Cadena + Space(58)
                    Cadena = Cadena + FnSpace((r("CodPais").ToString & "").Trim, 2)
                    Cadena = Cadena + FnSpace(CifCliente, 15)
                    Cadena = Cadena + FnSpace((r("NombreCliente").ToString & "").Trim, 40)
                    Cadena = Cadena + FnSpace((r("Entrega").ToString & "").Trim, 1)
                    Cadena = Cadena + Format(r("ImporteInt"), "00000000000")
                    Cadena = Cadena + Format(r("ImporteDec"), "00")
                    Cadena = FnSpace(Cadena, 500)
                    sw.WriteLine(Cadena)
                    Cadena = String.Empty

                    Application.DoEvents()

                Next

                sw.Close()

                ' Catch ex As Exception

                '   End Try


            End If


            MsgBox("Fichero Generado Correctamente")


        Else

            MsgBox("No hay datos")


        End If



    End Sub

    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()
        Consultar()

        GeneraFichero()

    End Sub


    Public Function LIMPIANOMBRE(Nombre As String) As String

        Dim x As Integer
        Dim n As String
        Dim c As String
        Dim N2 As String
        Dim C2 As String

        n = ""
        For x = 1 To Len(Nombre)
            c = Mid(Nombre, x, 1)
            If InStr("¦ç,.-ºª()+*", c) > 0 Or Asc(c) > 122 Then
                n = n + " "
            Else
                n = n + UCase(c)
            End If
        Next


        'repaso para quitar los dobles espacios
        N2 = ""
        For x = 1 To Len(n)
            c = Mid(n, x, 1)
            If c = " " Then
                If x + 1 <= Len(n) Then
                    C2 = Mid(n, x + 1, 1)
                    If C2 = " " Then
                        N2 = N2 + ""
                    Else
                        N2 = N2 + c
                    End If
                Else
                    N2 = N2 + c
                End If
            Else
                N2 = N2 + c
            End If
        Next x

        Return N2

    End Function




 
End Class