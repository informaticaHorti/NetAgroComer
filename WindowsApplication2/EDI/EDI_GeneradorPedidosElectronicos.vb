Imports System.IO

Namespace EDI


    Public MustInherit Class EDI_GeneradorPedidosElectronicos


        Public Proveedor As EDI.Comun.ProveedorEDI
        Public Pedidos As New List(Of EDI_Pedido)
        Public Carpeta_origen As String = "C:\Temp\"

        Public DatosEmpresa As New DatosEmpresa


        Public Sub New(Proveedor As EDI.Comun.ProveedorEDI, carpeta_origen As String)

            Me.Proveedor = Proveedor
            If Not carpeta_origen.EndsWith("\") Then carpeta_origen = carpeta_origen & "\"
            Me.Carpeta_origen = carpeta_origen

        End Sub



        Public MustOverride Function Resultado(DcFicheros As Dictionary(Of String, String)) As System.Collections.Generic.List(Of EDI.EDI_Pedido)
        'Public MustOverride Sub AñadirPedido(DcPedidos As Dictionary(Of String, String))


        Public Shared Function ObtenerGeneradorPedidos(proveedor As String, carpeta_origen_txt As String) As EDI.EDI_GeneradorPedidosElectronicos

            Select Case proveedor
                'Case "SERES"
                '    Return New SERES.SERES_GeneradorPedidosElectronicos(carpeta_origen_txt)
                Case "EDICOM"
                    Return New EDICOM.EDICOM_GeneradorPedidosElectronicos(carpeta_origen_txt)
                Case Else
                    Return Nothing
            End Select

        End Function



    End Class


End Namespace

