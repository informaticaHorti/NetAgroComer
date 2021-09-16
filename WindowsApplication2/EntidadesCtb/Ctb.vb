Module Ctb


    Public Function SaldoCuentas(cuenta As String, Empresa As Integer, Optional HastaFecha As String = "") As DataTable

        Dim lst As New List(Of String)
        lst.Add(cuenta)

        Return SaldoCuentas(lst, Empresa)

    End Function


    Public Function SaldoCuentas(lstCuentas As List(Of String), Empresa As Integer, Optional HastaFecha As String = "") As DataTable

        Dim dt As DataTable

        Dim sqlWhere As String = ""
        Dim cuentas As String = ""

        For Each cuenta As String In lstCuentas
            'Si empieza por 999999 es que no existe la cuenta
            If cuenta.Trim <> "" And Not cuenta.StartsWith("999999") Then
                If cuentas.Trim <> "" Then cuentas = cuentas & " OR "
                cuentas = cuentas & "NumeroCuenta = '" & cuenta & "'"
            End If
        Next

        If cuentas.Trim <> "" Then sqlWhere = " WHERE (" & cuentas & ")"

        If HastaFecha <> "" Then
            If sqlWhere <> "" Then
                sqlWhere = sqlWhere + " and fecha<='" + HastaFecha + "' "
            Else
                sqlWhere = " where fecha<='" + HastaFecha + "' "

            End If
        End If

        Dim sql As String = ""

        If Empresa > 0 Then
            sql = "SELECT NumeroCuenta, SUM(Debe - Haber) as SaldoTotal FROM " & ObtenerBDConexion(ConexCtb(Empresa)) & ".dbo.AsientoLineas " & sqlWhere
            sql = sql & " GROUP BY NumeroCuenta"
        Else
            For Each numero As Integer In ConexCtb.Keys
                Dim cn As Cdatos.Conexion = ConexCtb(numero)

                If Not IsNothing(cn) Then

                    Dim ctrnombre As String = ObtenerBDConexion(cn)
                    ctrnombre = (ctrnombre & "").Trim

                    If ctrnombre <> "" Then

                        If sql.Trim <> "" Then
                            sql = sql & " UNION ALL " & vbCrLf
                        End If
                        sql = sql & " SELECT NumeroCuenta, SUM(Debe - Haber) as SaldoTotal FROM " & ctrnombre & ".dbo.AsientoLineas " & sqlWhere & vbCrLf
                        sql = sql & " GROUP BY NumeroCuenta" & vbCrLf

                    End If

                End If

            Next

            sql = "SELECT NumeroCuenta, SUM(SaldoTotal) as SaldoTotal" & vbCrLf & _
                " FROM (" & vbCrLf & _
                sql & vbCrLf & _
                " ) AS G " & vbCrLf & _
                " GROUP BY NumeroCuenta" & vbCrLf

        End If


        dt = ConexCtb(MiMaletin.IdEmpresaCTB).ConsultaSQL(sql)

        Return dt

    End Function


    Public Sub AltaCuentas(CuCtb As List(Of String), codigo As String, Nombre As String, Domicilio As String, Poblacion As String, Provincia As String, Cpostal As String, Nif As String,
                           idpais As String, ClaveIrpf As String, Idivasoportado As String, idivarepercutido As String, PorcenIrpf As String, IBAN As String)



        For Each X In ConexCtb.Keys
            If Not ConexCtb(X) Is Nothing Then

                If ConexCtb(X).CadenaConexion <> "" Then
                    Dim Cuentas As New E_Cuentas(Idusuario, ConexCtb(X))
                    For Each grupo In CuCtb
                        Dim cuenta As String = ""
                        If grupo.Trim <> "" Then
                            cuenta = Fnc0(grupo, 6) + Fnc0(codigo, 5)
                            If Len(cuenta.Trim) = 11 Then
                                Dim alta As Boolean = False
                                If Cuentas.LeerId(cuenta.Trim) = False Then
                                    alta = True
                                End If
                                Cuentas.NumeroCuenta.Valor = cuenta
                                Cuentas.Nombre.Valor = Mid(Nombre, 1, Cuentas.Nombre.Longitud)
                                Cuentas.Domicilio.Valor = Mid(Domicilio, 1, Cuentas.Domicilio.Longitud)
                                Cuentas.Poblacion.Valor = Mid(Poblacion, 1, Cuentas.Poblacion.Longitud)
                                Cuentas.Provincia.Valor = Mid(Provincia, 1, Cuentas.Provincia.Longitud)
                                Cuentas.Poblacion.Valor = Mid(Poblacion, 1, Cuentas.Poblacion.Longitud)
                                Cuentas.CodPostal.Valor = Mid(Cpostal, 1, Cuentas.CodPostal.Longitud)
                                Cuentas.Nif.Valor = Mid(Nif, 1, Cuentas.Nif.Longitud)
                                Cuentas.IdPais.Valor = idpais
                                Cuentas.ClaveIrpf.Valor = Mid(ClaveIrpf, 1, Cuentas.ClaveIrpf.Longitud)
                                Cuentas.IdIvaSoportado.Valor = Idivasoportado
                                Cuentas.IdIvaRepercutido.Valor = idivarepercutido
                                Cuentas.PorcenIrpf.Valor = PorcenIrpf
                                If IBAN.Trim <> "" Then Cuentas.CuentaBancaria.Valor = IBAN
                                If alta = True Then
                                    Cuentas.Insertar()
                                Else
                                    Cuentas.Actualizar()
                                End If
                            End If
                        End If
                    Next
                End If
            End If

        Next
    End Sub


End Module


