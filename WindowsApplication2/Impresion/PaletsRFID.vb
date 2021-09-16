Imports System.IO.Ports

Module PaletsRFID
    Public Sub ImprimirPaletRFID(idpalet As String)




        LeerFicheroINI_Muelles()

        If PuertoImpresoraRFID = "" Then
            MsgBox("No se asigno ningun puerto para la impresora")
            Exit Sub
        End If


        Dim dt As DataTable = Dtpalet(idpalet)
        Dim puertoCom As New System.IO.Ports.SerialPort
        Try

            puertoCom.PortName = PuertoImpresoraRFID

            puertoCom.BaudRate = 9600
            puertoCom.Parity = Parity.None
            puertoCom.StopBits = StopBits.One
            puertoCom.DataBits = 8
            puertoCom.Handshake = Handshake.None
            puertoCom.RtsEnable = True

            puertoCom.Open()

        Catch ex As Exception
            MsgBox("no puedo abrir el puerto " + PuertoImpresoraRFID)
            Exit Sub

        End Try

      

        Dim li As Integer = dt.Rows.Count


        ' ------------------------------------------------------------
        ' --- IMPRIME PALET NORMAL - 1 linea por palet
        If li = 1 Then

            Dim row As DataRow = dt.Rows(0)
            Dim Presentacion As String = (row("Presentacion").ToString & "").Trim
            Dim Categoria As String = (row("Categoria").ToString & "").Trim
            Dim Marca As String = (row("Marca").ToString & "").Trim
            Dim Bultos As String = (row("Bultos").ToString & "").Trim
            Dim KgNetos As String = VaDec(row("KgNetos")).ToString("###0")
            Dim Nupalet As String = (row("Palet").ToString & "").Trim


            Presentacion = LIMPIANOMBRE(Presentacion)
            Categoria = LIMPIANOMBRE(Categoria)
            Marca = LIMPIANOMBRE(Marca)


            Enviar(puertoCom, "{U2;0030|}")
            ' Enviar "{D0790,1000,0750|}"
            Enviar(puertoCom, "{D0750,1000,0750|}")
            Enviar(puertoCom, "{AX;+000,+000,+00|}")
            Enviar(puertoCom, "{AY;+00,0|}")
            Enviar(puertoCom, "{C|}")

            ' Enviar "{@003;+0100|}"
            Enviar(puertoCom, "{@003;" + AjusteTag + "|}")

            Enviar(puertoCom, "{XB00;0050,0550,B,1,03,03,06,06,03,0,0100,+0000000000,0,00=" + "PAL" + idpalet + "|}") ' CODIGO DE BARRAS
            '             X    Y    ALT  ANC   RT
            Enviar(puertoCom, "{PV01;0925,0005,0035,0035,B,11,B=" + MiMaletin.NombreEmpresa + "|}")
            Enviar(puertoCom, "{PV02;0800,0005,0035,0035,B,11,B=PALET N.:|}")
            Enviar(puertoCom, "{PV03;0800,0350,0070,0070,B,11,B=" + Nupalet + "|}")
            Enviar(puertoCom, "{LC;0750,0001,0750,0699,0,4|}")
            Enviar(puertoCom, "{PV04;0670,0005,0020,0070,B,11,B=" + Presentacion + "|}")
            Enviar(puertoCom, "{PV05;0600,0005,0035,0035,B,11,B=CAT.|}")
            Enviar(puertoCom, "{PV06;0600,0170,0050,0050,B,11,B=" + Categoria + "|}")
            Enviar(puertoCom, "{PV07;0500,0005,0035,0035,B,11,B=MARCA|}")
            Enviar(puertoCom, "{PV08;0500,0170,0050,0050,B,11,B=" + Marca + "|}")
            Enviar(puertoCom, "{PV09;0400,0005,0035,0035,B,11,B=BULTOS|}")
            Enviar(puertoCom, "{PV10;0400,0170,0050,0050,B,11,B=" + Bultos + "|}")
            Enviar(puertoCom, "{PV11;0300,0005,0035,0035,B,11,B=KILOS|}")
            Enviar(puertoCom, "{PV12;0300,0170,0050,0050,B,11,B=" + KgNetos + "|}")

            Enviar(puertoCom, "{XB01;0000,0000,r,T24,B01=" + "321" + VaDec(idpalet).ToString("0000000") + "|}") ' ESTO ES LO QUE GRABA
            Enviar(puertoCom, "{XS;I,0001,0003C3100|}")
            Enviar(puertoCom, "{U1;0030|}")

            ' ------------------------------------------------------------
            ' --- IMPRIME PALET MIXTO - hasta 4 lineas por palet (resto se ignoran)
        Else

          

            Dim r As Integer = 810
            For q As Integer = 0 To dt.Rows.Count - 1


                Dim row As DataRow = dt.Rows(q)
                Dim Presentacion As String = (row("Presentacion").ToString & "").Trim
                Dim Categoria As String = (row("Categoria").ToString & "").Trim
                Dim Marca As String = (row("Marca").ToString & "").Trim
                Dim Bultos As String = (row("Bultos").ToString & "").Trim
                Dim KgNetos As String = VaDec(row("KgNetos")).ToString("###0")
                Dim Nupalet As String = (row("Palet").ToString & "").Trim
                Presentacion = LIMPIANOMBRE(Presentacion)
                Categoria = LIMPIANOMBRE(Categoria)
                Marca = LIMPIANOMBRE(Marca)

                If q = 0 Then
                    Enviar(puertoCom, "{U2;0030|}")
                    ' Enviar "{D0790,1000,0750|}"
                    Enviar(puertoCom, "{D0750,1000,0750|}")
                    Enviar(puertoCom, "{AX;+000,+000,+00|}")
                    Enviar(puertoCom, "{AY;+00,0|}")
                    Enviar(puertoCom, "{C|}")

                    ' Enviar "{@003;+0100|}"
                    Enviar(puertoCom, "{@003;" + AjusteTag + "|}")

                    Enviar(puertoCom, "{XB00;0050,0660,B,1,03,03,06,06,03,0,0060,+0000000000,0,00=" + "PAL" + idpalet + "|}") ' CODIGO DE BARRAS

                    '             X    Y    ALT  ANC   RT
                    Enviar(puertoCom, "{PV01;0925,0005,0035,0035,B,11,B=" + MiMaletin.NombreEmpresa + "|}")
                    Enviar(puertoCom, "{PV02;0850,0005,0035,0035,B,11,B=PALET N.:|}")
                    Enviar(puertoCom, "{PV03;0850,0350,0070,0070,B,11,B=" + Nupalet + "|}")
                End If

                If q > 3 Then Exit For



 


                Enviar(puertoCom, "{LC;" + Format(r, "0000") + ",0005," + Format(r, "0000") + ",0500,0,4|}")
                r = r - 60
                Enviar(puertoCom, "{PV04;" + Format(r, "0000") + ",0005,0020,0060,B,11,B=" + Presentacion + "|}")
                r = r - 50
                Enviar(puertoCom, "{PV06;" + Format(r, "0000") + ",0005,0030,0030,B,11,B=" + Categoria + "|}")
                Enviar(puertoCom, "{PV08;" + Format(r, "0000") + ",0300,0030,0030,B,11,B=" + Marca + "|}")
                r = r - 50
                Enviar(puertoCom, "{PV10;" + Format(r, "0000") + ",0005,0030,0030,B,11,B=" + Bultos + " Bultos.|}")
                Enviar(puertoCom, "{PV12;" + Format(r, "0000") + ",0300,0030,0030,B,11,B=" + KgNetos + " Kilos.|}")
                r = r - 50

            Next q

            Enviar(puertoCom, "{XB01;0000,0000,r,T24,B01=" + "321" + VaDec(idpalet).ToString("0000000") + "|}") ' ESTO ES LO QUE GRABA
            Enviar(puertoCom, "{XS;I,0001,0003C3100|}")
            Enviar(puertoCom, "{U1;0030|}")

        End If

        puertoCom.Close()
    End Sub

    Private Function Dtpalet(idpalet As String) As DataTable
        Dim ret As New DataTable

        Dim Palets_lineas As New E_palets_lineas(Idusuario, cn)
        Dim GenerosSalida As New E_GenerosSalida(Idusuario, cn)
        Dim Marca As New E_Marcas(Idusuario, cn)
        Dim Palets As New E_palets(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(Palets_lineas.PLL_idlinea, "IdLinea")
        consulta.SelCampo(Palets.PAL_palet, "Palet", Palets_lineas.PLL_idpalet)
        consulta.SelCampo(GenerosSalida.GES_DescripcionAlb, "Presentacion", Palets_Lineas.PLL_idgensal, GenerosSalida.GES_Idgensal)
        consulta.SelCampo(Palets_Lineas.PLL_categoria, "Categoria")
        consulta.SelCampo(Marca.MAR_Nombre, "Marca", Palets_Lineas.PLL_idmarca, Marca.MAR_Idmarca)
        consulta.SelCampo(Palets_Lineas.PLL_bultos, "Bultos")
        consulta.SelCampo(Palets_Lineas.PLL_kilosbrutos, "KgBrutos")
        consulta.SelCampo(Palets_Lineas.PLL_kilosnetos, "KgNetos")
        consulta.SelCampo(Palets_Lineas.PLL_idtipoconfeccion, "IdConfeccion")
        consulta.WheCampo(Palets_Lineas.PLL_idpalet, "=", idpalet)

        Dim sql As String = consulta.SQL & vbCrLf

        ret = Palets.MiConexion.ConsultaSQL(sql)


        Return ret


    End Function

    Private Sub Enviar(PuertoCom As System.IO.Ports.SerialPort, Tx As String)
        '        ' On Error GoTo coderror

        '        Err.Clear()

        '        With ExPaleco
        '            If .MsComm.PortOpen = True Then
        '                .MsComm.Output = Tx
        '            End If
        '        End With

        '        Exit Sub

        'coderror:
        '        Err.Clear()
        '        Resume Next

        Try

            If PuertoCom.IsOpen Then
                PuertoCom.Write(Tx)
                ' AñadirLista(Tx)
            End If

        Catch ex As Exception

        End Try

    End Sub




End Module
