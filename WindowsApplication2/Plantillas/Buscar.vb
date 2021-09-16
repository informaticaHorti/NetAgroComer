Module Buscar

    Public BuscarRow As System.Data.DataRow


    Public Function Busquedafrm(ByVal NomBusca As String) As String
        Dim DT As DataTable = Nothing
        Dim sql As String
        Dim v As String = ""
        Dim FRb As New FrBuscar

        Select Case NomBusca.ToUpper
            Case "BTBUSCAFAMILIA"
                Dim Familia As New E_FamiliasGeneros(Idusuario, cn)
                sql = "Select * from familias"
                DT = Familia.MiConexion.ConsultaSQL(sql)
                FRb.InitDta(DT, "Nombre")
                FRb.ShowDialog()
                If Not BuscarRow Is Nothing Then
                    v = BuscarRow("idFamilia")
                End If

            Case "BTBUSCAGENERO"
                Dim Genero As New E_Generos(Idusuario, cn)
                sql = "Select * from Generos"
                DT = Genero.MiConexion.ConsultaSQL(sql)
                FRb.InitDta(DT, "GEN_NombreGenero")
                FRb.ShowDialog()
                If Not BuscarRow Is Nothing Then
                    v = BuscarRow("GEN_IdGenero")
                End If
            Case Else

        End Select

        Return v
    End Function
End Module
