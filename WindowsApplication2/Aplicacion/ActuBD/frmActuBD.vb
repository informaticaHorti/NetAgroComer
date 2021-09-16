Imports NetAgro.Constructor
Imports NetAgro.ProveedorDatos
Imports System.Windows.Forms

Public Class frmActuBD

    Protected _Completado As Boolean = False
    Protected _Iniciado As Boolean = False
    Protected _lstConstructores As New List(Of Cl_ConstructorConsultas)
    Protected _Resultado As Windows.Forms.DialogResult = Windows.Forms.DialogResult.Cancel

    ''' <summary>
    ''' Inicializa la lista de las sentencias sql a mostrar en el grid y ejecutar
    ''' </summary>
    ''' <param name="constructor">Constructor con la conexión a la BBDD</param>
    ''' <remarks></remarks>
    Public Sub EstablecerActualizaciones(ByVal Constructor As Cl_ConstructorConsultas)

        _lstConstructores.Add(Constructor)
        Dim indice As Integer = _lstConstructores.Count - 1

        For Each sql As String In Constructor.Actualizaciones
            grid.Rows.Add(New Object() {sql, imgIconos.Images(0), indice})
        Next

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim bCompletado As Boolean = False

        If MsgBox("¿Desea realizar los cambios?", vbOKCancel + vbQuestion, " Atención") = vbOK Then

            _Iniciado = True
            bCompletado = True

            For Each row As DataGridViewRow In grid.Rows

                'Desplaza las filas para mostrar por dónde va
                row.Selected = True
                grid.FirstDisplayedScrollingRowIndex = row.Index


                Dim indice_constructor As Integer = CType(row.Cells("CONSTRUCTOR").Value.ToString(), Integer)
                Dim constructor As Cl_ConstructorConsultas = _lstConstructores(indice_constructor)


                'Mostramos tick o equis según el resultado de la consulta
                If EjecutarSql(row.Cells("CONSULTA").Value.ToString(), constructor) Then
                    row.Cells("IMAGEN").Value = imgIconos.Images(1)
                Else
                    row.Cells("IMAGEN").Value = imgIconos.Images(2)
                    bCompletado = False
                End If

                Application.DoEvents()

            Next


            If bCompletado Then
                MsgBox("¡Cambios realizados con éxito!", vbOKOnly + vbInformation, " Atención")
            Else
                MsgBox("¡No se pudo actualizar la base de datos!", vbOKOnly + vbExclamation, " Atención")
                'btnAceptar.Enabled = False
            End If

            _Completado = bCompletado

            If bCompletado Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.No
            End If


        End If


    End Sub


    ''' <summary>
    ''' Envía la cadena SQL para su ejecución por el proveedor de datos
    ''' </summary>
    ''' <param name="sql">Cadena SQL ya preprocesada</param>
    ''' <returns>Resultado de la operación</returns>
    ''' <remarks>Se entiende que la operación se ha efectuado si no reporta error, aunque no devuelva ningún registro modificado</remarks>
    Protected Function EjecutarSql(ByVal sql As String, ByVal constructor As Cl_ConstructorConsultas) As Boolean

        Dim bResultado As Boolean = True

        Try
            constructor.EjecutarComando(sql)

        Catch ex As Exception
            bResultado = False
        End Try

        'TODO: Comprobar que se han efectuado los cambios??
        Return bResultado

    End Function

    Private Sub frmActuBD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For Each row As DataGridViewRow In grid.Rows
            grid.AutoResizeRow(row.Index)
        Next

        'grid.Refresh()
        grid.Update()

    End Sub

    Private Sub frmActuBD_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        If _Completado Then
            'Resultado OK
            Me.DialogResult = Windows.Forms.DialogResult.OK
        ElseIf Not _Iniciado Then
            'Cancelado
            MsgBox("¡No se pudo actualizar la base de datos!", vbOKOnly + vbExclamation, " Atención")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            'Con errores
            Me.DialogResult = Windows.Forms.DialogResult.No
        End If

        Me.Dispose()

    End Sub

End Class