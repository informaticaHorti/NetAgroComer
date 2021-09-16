Imports DevExpress.XtraEditors.Controls

Public Class FrmConfigDiversas

    Dim Centros As New E_centros(Idusuario, ConexCTB(Mimaletin.IdempresaCTB))

    Dim ConfigDiv As New E_ConfiguracionesDiversas(IdUsuario, Cn)

#Region "Inicio"

    Private Sub FrmConfigDiversas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Grid.Rows.Clear()

        ChequeaConfiguracionesDiversas()
        CargaConfiguracionesDiversas()

    End Sub


    Private Sub ChequeaConfiguracionesDiversas()

        'Parametros_AGRICULTORES()
        CrealosParametros()

    End Sub


    Private Sub CargaConfiguracionesDiversas()

        Dim dt As DataTable

        Grid.Rows.Clear()
        dt = ConfigDiv.xCargaConfiguraciones(0, 0)
        For Each fila As DataRow In dt.Rows
            Grid.Rows.Add(fila("Clave"), fila("Valor"), fila("IdCentro").ToString, fila("IdPuntoVenta").ToString, fila("IdUsuario").ToString)
        Next

    End Sub


#End Region

#Region "Varios"

    Private Sub EliminarConfiguracionesDiversas()

        Dim id As Integer = 0
        Dim clave As String = ""
        Dim centro As String = ""
        Dim ptoven As String = ""
        Dim usu As String = ""

        For Each fila As DataGridViewRow In Grid.SelectedRows

            clave = fila.Cells("Clave").Value.ToString.Trim
            centro = fila.Cells("IdCentro").Value.ToString.Trim
            ptoven = fila.Cells("IdPuntoVenta").Value.ToString.Trim
            usu = fila.Cells("Usuario").Value.ToString.Trim

            id = ConfigDiv.xLeerIdClave(clave, VaInt(centro), VaInt(ptoven), VaInt(usu))
            If ConfigDiv.LeerId(id) = True Then
                ConfigDiv.Eliminar()
            End If

        Next

    End Sub

    Private Sub GuardarConfiguracionesDiversas()

        Dim id As Integer = -1

        Dim clave As String = ""
        Dim valor As String = ""
        Dim centro As String = ""
        Dim ptoven As String = ""
        Dim usu As String = ""

        For Each fila As DataGridViewRow In Grid.Rows

            clave = fila.Cells("Clave").Value & ""
            valor = fila.Cells("Valor").Value & ""
            centro = fila.Cells("IdCentro").Value & ""
            ptoven = fila.Cells("IdPuntoVenta").Value & ""
            usu = fila.Cells("Usuario").Value & ""


            ConfigDiv.VaciaEntidad()
            id = ConfigDiv.xLeerIdClave(clave, VaInt(centro), VaInt(ptoven), VaInt(usu))
            If id < 0 Then
                ConfigDiv.Id.Valor = ConfigDiv.MaxId
                ConfigDiv.Clave.Valor = clave
                ConfigDiv.Valor.Valor = valor
                ConfigDiv.IdCentro.Valor = VaInt(centro)
                ConfigDiv.IdPuntoVenta.Valor = VaInt(ptoven)
                ConfigDiv.EUsuario.Valor = VaInt(usu)
                ConfigDiv.Insertar()
            Else
                ConfigDiv.Id.Valor = id
                ConfigDiv.Clave.Valor = clave
                ConfigDiv.Valor.Valor = valor
                ConfigDiv.IdCentro.Valor = VaInt(centro)
                ConfigDiv.IdPuntoVenta.Valor = VaInt(ptoven)
                ConfigDiv.EUsuario.Valor = VaInt(usu)
                ConfigDiv.Actualizar()
            End If

        Next

    End Sub

#End Region

#Region "Botones"

    Private Sub Bsalir_Click(sender As System.Object, e As System.EventArgs) Handles Bsalir.Click
        Me.Dispose()
    End Sub

    Private Sub BGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BGuardar.Click
        GuardarConfiguracionesDiversas()
        MsgBox("Configuración guardada.         ", vbInformation Or vbYes, " Atención")
        Me.Dispose()
    End Sub

    Private Sub BAnular_Click(sender As System.Object, e As System.EventArgs) Handles BAnular.Click
        EliminarConfiguracionesDiversas()
        MsgBox("Configuración eliminada.         ", vbInformation Or vbYes, " Atención")
        CargaConfiguracionesDiversas()
    End Sub

#End Region




    Private Sub CrealosParametros()
        Dim Claves As Array = E_ConfiguracionesDiversas.eClaves.GetValues(GetType(E_ConfiguracionesDiversas.eClaves))
        For Each item In Claves
            Dim c As String = item.ToString
            If ConfigDiv.xExisteClave(item, 0, 0) = False Then
                ConfigDiv.VaciaEntidad()
                ConfigDiv.Id.Valor = ConfigDiv.MaxId
                ConfigDiv.Clave.Valor = c
                ConfigDiv.Valor.Valor = ValorClave(c)

                ConfigDiv.Insertar()
            End If
        Next
    End Sub

    Private Function ValorClave(clave As String) As String
        Dim ret As String = ""
        For Each fila As DataGridViewRow In Grid.Rows

            If clave = fila.Cells("Clave").Value.ToString Then
                ret = fila.Cells("Valor").Value.ToString

            End If
        Next

        Return ret

    End Function
  


    ' ------------------------------ parametros LETRAS
    'Private Sub Parametros_AGRICULTORES()

    '    Dim c As String = ConfigDiv.xLstClaves(E_ConfiguracionesDiversas.eClaves.PATH_FOTOS_AGRICULTORES)

    '    If ConfigDiv.xExisteClave(c, 0, 0) = False Then
    '        ConfigDiv.VaciaEntidad()
    '        ConfigDiv.Id.Valor = ConfigDiv.MaxId
    '        ConfigDiv.Clave.Valor = c
    '        ConfigDiv.Valor.Valor = ""
    '        ConfigDiv.Insertar()
    '    End If
    'End Sub


  


    
    
    Private Sub Grid_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellValueChanged

    End Sub

End Class