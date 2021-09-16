Public Class Utilidades_miguel

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TxGasto.Text = "" Then
            MsgBox("Introducir codigo del gasto del porte")
            Exit Sub
        End If
        Dim paises As New E_Paises(Idusuario, CnComun)
        Dim tarifasportes As New E_TarifaPortes(Idusuario, cn)
        Dim consulta As New Cdatos.E_select
        Dim sql As String = ""
        consulta.SelCampo(paises.IdPais, "idpais")
        consulta.SelCampo(paises.Nombre, "nombre")
        sql = consulta.SQL
        Dim dt As DataTable = paises.MiConexion.ConsultaSQL(sql)
        If Not dt Is Nothing Then
            For Each rw In dt.Rows
                If tarifasportes.LeerId(rw("idpais").ToString) = False Then
                    tarifasportes.TPV_Id.Valor = rw("idpais").ToString
                    tarifasportes.TPV_Nombre.Valor = rw("nombre").ToString
                    tarifasportes.TPV_idgasto.Valor = TxGasto.Text
                    tarifasportes.Insertar()
                End If
            Next
        End If

        '        Dim clientesDescargas As New E_ClientesDescargas(Idusuario, cn)
        'clientesDescargas.CLD_IdTarifaPortes
        sql = "update clientesdescargas set CLD_idtarifaportes=CLD_idpais where cld_idtarifaportes=0"
        tarifasportes.MiConexion.OrdenSql(sql)


        sql = "update albsalida_lineas set asl_tipoprecioestimado=asl_tipoprecio where asl_tipoprecioestimado=''"
        tarifasportes.MiConexion.OrdenSql(sql)

    End Sub




    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        If MsgBox("desea calcular el coeficiente de porte del palet", vbYesNo) = vbYes Then

            Dim palets As New E_palets(Idusuario, cn)
            Dim palets_lineas As New E_palets_lineas(Idusuario, cn)
            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(palets.PAL_idpalet, "idpalet")
            consulta.WheCampo(palets.PAL_idpalet, ">", "0")
            Dim sql As String = consulta.SQL
            Dim dt As DataTable = palets.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                For Each rw In dt.Rows
                    Dim idpalet As String = rw("idpalet").ToString
                    palets_lineas.CoeficientePalet(idpalet)
                Next
            End If

            'Dim albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
            'albsalida_lineas.ASL_CoeficientePalet()

            '   sql = "update albsalida_lineas set asl_coeficientepalet=asl_palets where asl_coeficientepalet=0"
            '   palets.MiConexion.OrdenSql(sql)


        End If
        MsgBox("PROCESO TERMINADO")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If MsgBox("Desea generar los gastos de portes", vbYesNo) = vbYes Then

            Dim albsalida As New E_AlbSalida(Idusuario, cn)
            Dim albsalida_lineas As New E_AlbSalida_lineas(Idusuario, cn)
            Dim clientesdescargas As New E_ClientesDescargas(Idusuario, cn)
            Dim Tiposportes As New E_TiposPorte(Idusuario, cn)
            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(albsalida.ASA_idalbaran, "idalbaran")
            consulta.SelCampo(albsalida.ASA_idtransportista, "idtransportista")
            consulta.SelCampo(albsalida.ASA_valorcambio, "Valorcambio")
            consulta.SelCampo(albsalida.ASA_albaran, "Albaran")
            consulta.SelCampo(clientesdescargas.CLD_IdTarifaPortes, "idtarifaporte", albsalida.ASA_iddomicilio)
            consulta.SelCampo(Tiposportes.TPO_OrigenDestino, "OD", albsalida.ASA_idtipoporte)
            Dim oKilos As New Cdatos.bdcampo("@(SELECT SUM(ASL_KilosNetos) AS kilos FROM Albsalida_Lineas WHERE ASL_IdAlbaran = ASA_IdAlbaran)", Cdatos.TiposCampo.Entero, 10)
            consulta.SelCampo(oKilos, "Kilos")
            Dim obultos As New Cdatos.bdcampo("@(SELECT SUM(ASL_BULTOS) AS BULTOS FROM Albsalida_Lineas WHERE ASL_IdAlbaran = ASA_IdAlbaran)", Cdatos.TiposCampo.Entero, 10)
            consulta.SelCampo(obultos, "Bultos")
            Dim opalets As New Cdatos.bdcampo("@(SELECT SUM(ASL_PALETS) AS PALETS FROM Albsalida_Lineas WHERE ASL_IdAlbaran = ASA_IdAlbaran)", Cdatos.TiposCampo.Entero, 10)
            consulta.SelCampo(opalets, "Palets")

            Dim sql As String = consulta.SQL
            Dim dt As DataTable = albsalida.MiConexion.ConsultaSQL(sql)
            If Not dt Is Nothing Then
                For Each rw In dt.Rows
                    Dim idalbaran As Integer = VaInt(rw("idalbaran"))
                    Dim idtransportista As Integer = VaInt(rw("idtransportista"))
                    Dim idtarifaporte As Integer = VaInt(rw("idtarifaporte"))
                    Dim Valorcambio As Decimal = VaDec(rw("ValorCambio"))
                    If Valorcambio = 0 Then
                        Valorcambio = 1
                    End If
                    Dim Albaran As Integer = VaInt(rw("albaran"))
                    Dim od As String = rw("OD").ToString
                    Dim tk As Decimal = VaDec(rw("kilos"))
                    Dim tb As Decimal = VaDec(rw("bultos"))
                    Dim tp As Decimal = VaDec(rw("palets"))
                    If od = "O" And idtarifaporte > 0 Then
                        Agro_GeneraGastodePorte(idalbaran.ToString, idtarifaporte, tb, tk, tp, Valorcambio, idtransportista)
                        Agro_CalculoGastosTotalesAlbaran(idalbaran, Valorcambio)
                    End If
                Next
            End If

            MsgBox("TERMINADO")

        End If
    End Sub
End Class