Imports System.IO

Public Class FrmGenera346


    Inherits FrConsulta




    Dim Agricultor As New E_Agricultores(Idusuario, cn)
    Dim Fichero346 As New E_Fichero346(Idusuario, cn)
    Dim Conceptos346 As New E_Conceptos346(Idusuario, cn)
    Dim Ejercicios As New E_Ejercicios(Idusuario, ConexCtb(MiMaletin.IdEmpresaCTB))
    Dim Empresas As New E_Empresas(Idusuario, cn)



    Dim err As New Errores





    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ParametrosFrm()

    End Sub


    Private Sub ParametrosFrm()

        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxEjercicio, Ejercicios.IdEjercicio, LbEjercicio, True)
        ParamTx(TxAno, Nothing, LbAno, True, Cdatos.TiposCampo.EnteroPositivo, , 4)
        ParamTx(TxEjerDevengo, Nothing, LbEjerDevengo, True, Cdatos.TiposCampo.EnteroPositivo, , 4)

        ParamTx(TxNif, Nothing, LbNif, True, Cdatos.TiposCampo.Cadena, , 9)
        ParamTx(TxNombre, Nothing, LbNombre, True, Cdatos.TiposCampo.Cadena, , 40)
        ParamTx(TxContacto, Nothing, LbContacto, False, Cdatos.TiposCampo.Cadena, , 40)
        ParamTx(TxTelefono, Nothing, LbTelefono, False, Cdatos.TiposCampo.Cadena, , 40)


        ParamTx(TxDeclaracion, Nothing, LbDeclaracion, False, Cdatos.TiposCampo.Cadena, , 13)
        ParamTx(TxAnterior, Nothing, LbAnterior, False, Cdatos.TiposCampo.Cadena, , 13)
        ParamTx(TxNombreFichero, Nothing, , False, Cdatos.TiposCampo.Cadena, , 1000)

        AsociarControles(TxEjercicio, BtEjercicio, Ejercicios.btBusca, Ejercicios)
    End Sub





    Private Sub FrmConsultaSalidas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        BInforme.Visible = False

        'GridView1.OptionsView.ShowGroupPanel = False
        'GridView1.OptionsBehavior.Editable = False
        'GridView1.OptionsView.ColumnAutoWidth = True
        BtAux.Visible = True
        BtAux.Text = "Generar"
        BtAux.Image = NetAgro.My.Resources.Resources.Copy_16

    End Sub



    Public Overrides Sub BorraPan()
        MyBase.BorraPan()
        TxEjercicio.Text = MiMaletin.Ejercicio.ToString
        If Empresas.LeerId(MiMaletin.IdEmpresaCTB) = True Then
            TxNif.Text = Empresas.EMP_CIF.Valor
            TxNombre.Text = Empresas.EMP_Nombre.Valor
            TxTelefono.Text = Empresas.EMP_Telefono.Valor
        End If

    End Sub




    Private Sub AjustaColumnas()


        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns

            Select Case c.FieldName.ToUpper.Trim



                Case "IMPORTE"
                    c.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    c.DisplayFormat.FormatString = "#,###0.00"






            End Select

        Next

        GridView1.BestFitColumns()

        AñadeResumenCampo("Importe", "{0:n2}")

    End Sub


    Public Overrides Sub Consultar()
        MyBase.Consultar()

        Dim dt As DataTable = Fichero346.DtRegistros(VaInt(TxEjercicio.Text), MiMaletin.IdEmpresaCTB, 0, 0)

        Grid.DataSource = dt
        AjustaColumnas()


    End Sub


    Public Overrides Sub Informe()
        MyBase.Informe()

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TxNombreFichero.Text = ObtenerFichero()
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


    Public Overrides Sub Auxiliar()
        MyBase.Auxiliar()
      
        GeneraFichero()

    End Sub



    Private Sub GeneraFichero()



        If IsNothing(Grid.DataSource) Then
            MsgBox("No hay datos que exportar")
            Exit Sub
        End If

        If GridView1.RowCount = 0 Then
            MsgBox("No hay datos que exportar")
            Exit Sub
        End If


        If TxNombreFichero.Text = "" Then MsgBox("Fichero incorrecto")
        If TxAno.Text = "" Then MsgBox("Año incorrecto")
        'If TxEjerDevengo.Text = "" Then MsgBox("Ejercicio devengo incorrecto")

        Dim Declaracion As String = "0000000000000"
        If TxDeclaracion.Text <> "" Then
            Declaracion = Mid(TxDeclaracion.Text & "0000000000000", 1, 13)
        End If

        Dim Anterior As String = "0000000000000"
        If TxAnterior.Text <> "" Then
            Anterior = Mid(TxAnterior.Text & "0000000000000", 1, 13)
        End If


        Dim dt As DataTable = Fichero346.DtRegistros(VaInt(TxEjercicio.Text), MiMaletin.IdEmpresaCTB, 0, 0)
        Dim suma1 As Decimal = 0
        Dim regi As Integer = 0
        Dim Cadena As String = ""

        'SUMATORIA IMPORTE

        For Each rw In dt.Rows
            Dim impor As Decimal = VaDec(rw("importe"))
            If impor <> 0 Then
                suma1 = suma1 + impor
                regi = regi + 1
            End If

        Next


        Dim sw As System.IO.StreamWriter

        sw = New IO.StreamWriter(TxNombreFichero.Text, False, System.Text.Encoding.Default)


        Dim TipoSoporte As String = ""
        If RbCdRom.Checked = True Then
            TipoSoporte = "C"
        Else
            TipoSoporte = "T"
        End If


        Dim comp As String = " "
        Dim sust As String = " "
        If ChkComplementaria.Checked = True Then
            comp = "X"
        End If
        If ChkSustitutiva.Checked = True Then
            sust = "X"
        End If

        Cadena = "1"                                                                                                '1-1    TIPO REGISTRO
        Cadena = Cadena + "346"                                                                                     '2-4    Nº MODELO
        Cadena = Cadena + TxAno.Text                                                                                '5-8    ej
        Cadena = Cadena + Mid(TxNif.Text + Space(9), 1, 9)                                                          '9-17   nif
        Cadena = Cadena + Mid(TxNombre.Text.Replace(".", "").Replace(",", "") + Space(40), 1, 40)                   '18-57  empresa
        Cadena = Cadena + TipoSoporte                                                                               '58-58  tipo soporte
        Cadena = Cadena + Mid(TxTelefono.Text + Space(9), 1, 9)                                                     '59-67  tfno
        Cadena = Cadena + Mid(TxContacto.Text + Space(40), 1, 40)                                                   '68-107 contacto
        Cadena = Cadena + Declaracion                                                                               '108-120 nºidentif.
        Cadena = Cadena + comp                                                                                      '121-121 complementaria
        Cadena = Cadena + sust                                                                                      '122-122 sustitutiva
        Cadena = Cadena + Anterior                                                                                  '123-135 nºdeclar.anter.
        Cadena = Cadena + Format(regi, "000000000")                                                                 '136-144 nº percept.
        Cadena = Cadena + " "                                                                                       '145-145 signo
        Cadena = Cadena + Format(Math.Abs(Int(suma1)), "000000000000000")                                           '146-160 total p.ent.
        Cadena = Cadena + Format(Math.Abs((suma1 - Int(suma1))) * 100, "00")                                        '161-162 decimales
        Cadena = Cadena + Space(338)                                                                                '163-500 nada
        sw.WriteLine(Cadena)
        Cadena = String.Empty



        For Each rw In dt.Rows
            Dim impor As Decimal = VaDec(rw("importe"))
            If impor <> 0 Then

                Dim Intervencion As String
                If RbNombrePropio.Checked = True Then
                    Intervencion = "1"
                Else
                    Intervencion = "2"
                End If
                Cadena = "2"                                           'TIPO REGISTRO
                Cadena = Cadena + "346"                                'Nº MODELO
                Cadena = Cadena + TxAno.Text                            'AÑO
                Cadena = Cadena + Mid(TxNif.Text + Space(9), 1, 9)          'NIF EMPRESA
                Cadena = Cadena + Mid(rw("nif").ToString + Space(9), 1, 9)   'NIF AGRICULTOR
                Cadena = Cadena + Space(9)                             'NIF REPRESENTANTE
                Cadena = Cadena + Mid(rw("agricultor").ToString + Space(40), 1, 40) 'NOMBRE AGRICULTOR
                Cadena = Cadena + Format(Val(Mid(rw("cpostal").ToString, 1, 2)), "00") 'CODIGO PROVINCIA
                Cadena = Cadena + rw("clave").ToString        'CLAVE PERCEPCION
                Cadena = Cadena + rw("tipo").ToString        'TIPO DE PERCEPCION
                Cadena = Cadena + " " ' signo
                Cadena = Cadena + Format(Math.Abs(Int(impor)), "000000000000") 'BASE PARTE ENTERA
                Cadena = Cadena + Format(Math.Abs(impor - Int(impor)) * 100, "00") 'BASE PARTE DECIMAL
                Cadena = Cadena + Fnc0(TxEjerDevengo.Text, 4)                              'ej.dvgo
                Cadena = Cadena + Mid(rw("Concepto").ToString + Space(57), 1, 57) 'concepto
                Cadena = Cadena + Intervencion 'caracter de intevencion
                Cadena = Cadena + Space(344)

                sw.WriteLine(Cadena)
                Cadena = String.Empty
                regi = regi + 1

            End If
        Next

        'Dim TipoSoporte As String = ""
        'If RbCdRom.Checked = True Then
        '    TipoSoporte = "C"
        'Else
        '    TipoSoporte = "T"
        'End If


        'Dim comp As String = " "
        'Dim sust As String = " "
        'If ChkComplementaria.Checked = True Then
        '    comp = "X"
        'End If
        'If ChkSustitutiva.Checked = True Then
        '    sust = "X"
        'End If

        'cadena = "1"                                                            '1-1    TIPO REGISTRO
        'cadena = cadena + "346"                                                 '2-4    Nº MODELO
        'Cadena = Cadena + TxAno.Text                                             '5-8    ej
        'Cadena = Cadena + Mid(TxNif.Text + Space(9), 1, 9)                           '9-17   nif
        'Cadena = Cadena + Mid(TxNombre.Text + Space(40), 1, 40)                         '18-57  empresa
        'Cadena = Cadena + TipoSoporte                                             '58-58  tipo soporte
        'Cadena = Cadena + Mid(TxTelefono.Text + Space(9), 1, 9)                           '59-67  tfno
        'Cadena = Cadena + Mid(TxContacto.Text + Space(40), 1, 40)                         '68-107 contacto
        'Cadena = Cadena + Fnc0(TxDeclaracion.Text, 13)                                              '108-120 nºidentif.
        'cadena = cadena + Comp                                                  '121-121 complementaria
        'cadena = cadena + Sust                                                  '122-122 sustitutiva
        'Cadena = Cadena + Fnc0(TxDeclaracion.Text, 13)                                             '123-135 nºdeclar.anter.
        'cadena = cadena + Format(regi, "000000000")                             '136-144 nº percept.
        'cadena = cadena + " " '145-145 signo
        'Cadena = Cadena + Format(Math.Abs(Int(suma1)), "000000000000000")            '146-160 total p.ent.
        'cadena = cadena + Format(Math.Abs((suma1 - Int(suma1))) * 100, "00")         '161-162 decimales
        'Cadena = Cadena + Space(337)                                            '163-500 nada
        'sw.WriteLine(Cadena)
        'Cadena = String.Empty

        sw.Close()

        MsgBox("Fichero Generado Correctamente")

    End Sub

End Class