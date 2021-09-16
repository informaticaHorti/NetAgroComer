Imports System.Drawing

Public Module ValeEnvases


    Public Function ObtenerValeEnvases(IdVale As String, Optional NumDev As String = "") As List(Of miFactura)

        Dim lst As New List(Of miFactura)


        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
        Dim err As New Errores


        If ValeEnvases.LeerId(IdVale) Then

            Try

                Dim Vale As New miFactura()
                ImprimeValeEnvases_Uno(Vale, ValeEnvases, 20, False, False, NumDev)
                ImprimeValeEnvases_Uno(Vale, ValeEnvases, 165, True, False, NumDev)
                lst.Add(Vale)

            Catch ex As Exception
                err.Muestraerror("Error al leer el vale de envases id: " & IdVale, "ImprimirValeEnvases", ex.Message)
            End Try

        Else
            err.Muestraerror("Error al leer el vale de envases con id: " & IdVale, "ImprimirValeEnvases", "Error al leer el albarán de entrada con id: " & IdVale)
        End If




        Return lst

    End Function




    Public Sub ImprimirValeEnvases(IdVale As String, bPreliminar As Boolean, Optional NumDev As String = "")

        Dim ValeEnvases As New E_ValeEnvases(Idusuario, cn)
        Dim err As New Errores


        If ValeEnvases.LeerId(IdVale) Then

            Try


                Dim Informe As New miInforme(False)
                Informe.Contenedor.PaperKind = Printing.PaperKind.A4
                Informe.Contenedor.PrintingSystem.ShowMarginsWarning = False

                Informe.Contenedor.MinMargins.Top = 0
                Informe.Contenedor.MinMargins.Left = 0
                Informe.Contenedor.MinMargins.Right = 0
                Informe.Contenedor.MinMargins.Bottom = 0

                Informe.Contenedor.Margins.Top = 0
                Informe.Contenedor.Margins.Left = 0
                Informe.Contenedor.Margins.Right = 0
                Informe.Contenedor.Margins.Bottom = 0

                Dim Vale As New miFactura()
                ImprimeValeEnvases_Uno(Vale, ValeEnvases, 20, False, bPreliminar, NumDev)
                ImprimeValeEnvases_Uno(Vale, ValeEnvases, 165, True, bPreliminar, NumDev)
                Informe.AñadeDetalles(Vale)


                If bPreliminar Then
                    Informe.Preliminar(DevExpress.LookAndFeel.UserLookAndFeel.Default)
                Else
                    Informe.ImpresionDirecta()
                End If


                Informe.Dispose()


            Catch ex As Exception
                err.Muestraerror("Error al leer el vale de envases id: " & IdVale, "ImprimirValeEnvases", ex.Message)
            End Try

        Else
            err.Muestraerror("Error al leer el vale de envases con id: " & IdVale, "ImprimirValeEnvases", "Error al leer el albarán de entrada con id: " & IdVale)
        End If


    End Sub


    Private Sub ImprimeValeEnvases_Uno(ByRef Vale As miFactura, ValeEnvases As E_ValeEnvases, altura As Integer, bCopia As Boolean, bPreliminar As Boolean,
                                   Optional NumDev As String = "")

        Dim margen_izquierdo As Integer = 10


        Dim Col As New List(Of Integer)
        Col.Add(0)
        Col.Add(margen_izquierdo + 2)
        Col.Add(margen_izquierdo + 15)
        Col.Add(margen_izquierdo + 15 + 103)
        Col.Add(margen_izquierdo + 15 + 103 + 18)
        Col.Add(margen_izquierdo + 15 + 103 + 18 + 18)
        Col.Add(margen_izquierdo + 15 + 103 + 18 + 18 + 18)



        'Cabecera
        ImprimeCabeceraValeEnvases(Vale, ValeEnvases, altura, margen_izquierdo, Col, bCopia, NumDev)

        'Detalle
        ImprimeDetalleValeEnvases(Vale, ValeEnvases, altura, margen_izquierdo, Col)


    End Sub


    Private Sub ImprimeCabeceraValeEnvases(ByRef Vale As miFactura, ValeEnvases As E_ValeEnvases, ByRef altura As Integer,
                                           margen_izquierdo As Integer, Col As List(Of Integer), bCopia As Boolean,
                                           Optional NumDev As String = "")


        Dim AlmacenEnvases As New E_AlmacenEnvases(Idusuario, cn)

        'Cabecera
        Vale.Titulo("VALE DE ENVASES", margen_izquierdo + 2, altura, 85, 6, milinea.stilos.GrandeBold)
        If bCopia Then Vale.Titulo("###Copia###", 190 - 50, altura, 45, 6, milinea.stilos.NormalBold, ">")
        altura = altura + 9
        Vale.Cuadro(margen_izquierdo, altura, 190, 100, 0.25, Color.Black)
        Vale.LineaH(margen_izquierdo, altura + 21, 190, 0.25, Color.Black)
        Vale.LineaH(margen_izquierdo, altura + 28, 190, 0.25, Color.Black)


        'Código de barras con el siguiente formato
        'Operacion (2 digitos) + campa (2 digitos) + centro(2 digitos) + nºvale (6 digitos)
        Dim Operacion As String = ValeEnvases.VEV_Operacion.Valor.ToUpper.Trim
        Dim Campa As String = VaInt(ValeEnvases.VEV_Campa.Valor).ToString("00")
        Dim Centro As String = VaInt(ValeEnvases.VEV_Idcentro.Valor).ToString("00")
        Dim NumeroVale As String = VaInt(ValeEnvases.VEV_Numero.Valor).ToString("000000")

        Dim cod_barras As String = "*" & Operacion & Campa & Centro & NumeroVale & "*"
        Dim Code39 As New Font("C39HrP24DhTt", 25)
        Vale.Titulo(cod_barras, margen_izquierdo, altura + 100 + 2, 70, 12, milinea.stilos.Custom, , Code39)




        altura = altura + 5


        Dim NombreAlmacen As String = ""
        If AlmacenEnvases.LeerId(ValeEnvases.VEV_IdAlmacen.Valor) Then
            NombreAlmacen = AlmacenEnvases.AEV_Nombre.Valor
        End If




        'Obtenemos datos
        Dim NumVale As String = (ValeEnvases.VEV_Campa.Valor & "").Trim & "/" & VaInt(ValeEnvases.VEV_Numero.Valor).ToString("000000")
        Dim Almacen As String = VaInt(ValeEnvases.VEV_IdAlmacen.Valor).ToString("00")
        If NombreAlmacen.Trim <> "" Then Almacen = Almacen & " - " & NombreAlmacen
        Dim Fecha As String = ""
        If VaDate(ValeEnvases.VEV_Fecha.Valor) <> VaDate("") Then Fecha = VaDate(ValeEnvases.VEV_Fecha.Valor).ToString("dd/MM/yyyy")
        Dim Codigo As String = VaInt(ValeEnvases.VEV_Codigo.Valor).ToString("00000")
        Dim Nombre As String = ""
        Select Case (ValeEnvases.VEV_TipoSujeto.Valor & "").Trim.ToUpper

            Case "A"
                Dim Agricultores As New E_Agricultores(Idusuario, cn)
                If Agricultores.LeerId(ValeEnvases.VEV_Codigo.Valor) Then
                    Nombre = Agricultores.AGR_Nombre.Valor & ""
                End If

            Case "C"
                Dim Clientes As New E_Clientes(Idusuario, cn)
                If Clientes.LeerId(ValeEnvases.VEV_Codigo.Valor) Then
                    Nombre = Clientes.CLI_Nombre.Valor & ""
                End If

            Case "R"
                Dim Acreedores As New E_Acreedores(Idusuario, cn)
                If Acreedores.LeerId(ValeEnvases.VEV_Codigo.Valor) Then
                    Nombre = Acreedores.ACR_Nombre.Valor & ""
                End If

        End Select
        Dim Referencia As String = ValeEnvases.VEV_Referencia.Valor & ""
        Dim Concepto As String = ValeEnvases.VEV_Concepto.Valor & ""


        'Imprimimos
        Vale.Titulo("N. Vale: ", margen_izquierdo + 2, altura, 19, 4, milinea.stilos.ReducidaBold)
        Vale.Titulo(NumVale, margen_izquierdo + 2 + 17, altura, 35, 4, milinea.stilos.Reducida)
        Vale.Titulo("Almacen: ", margen_izquierdo + 2 + 37, altura, 19, 4, milinea.stilos.ReducidaBold)
        Vale.Titulo(Almacen, margen_izquierdo + 2 + 54, altura, 45, 4, milinea.stilos.Reducida)
        Vale.Titulo("Fecha: ", margen_izquierdo + 2 + 150, altura, 19, 4, milinea.stilos.ReducidaBold)
        Vale.Titulo(Fecha, margen_izquierdo + 2 + 163, altura, 35, 4, milinea.stilos.Reducida)
        altura = altura + 4
        Vale.Titulo("Codigo: ", margen_izquierdo + 2, altura, 19, 4, milinea.stilos.ReducidaBold)
        Vale.Titulo(Codigo, margen_izquierdo + 2 + 17, altura, 18, 4, milinea.stilos.Reducida)
        Vale.Titulo("Nombre: ", margen_izquierdo + 2 + 37, altura, 19, 4, milinea.stilos.ReducidaBold)
        Vale.Titulo(Nombre, margen_izquierdo + 2 + 54, altura, 65, 4, milinea.stilos.Reducida)
        Vale.Titulo("Ref: ", margen_izquierdo + 2 + 150, altura, 19, 4, milinea.stilos.ReducidaBold)
        Vale.Titulo(Referencia, margen_izquierdo + 2 + 163, altura, 35, 4, milinea.stilos.Reducida)
        altura = altura + 4
        Vale.Titulo("Concepto: ", margen_izquierdo + 2, altura, 17, 4, milinea.stilos.ReducidaBold)
        Vale.Titulo(Concepto, margen_izquierdo + 2 + 17, altura, 150, 4, milinea.stilos.Reducida)
        If NumDev.Trim <> "" Then
            Vale.Titulo("Dev nº: " & NumDev, margen_izquierdo + 2 + 150, altura, 40, 4, milinea.stilos.Reducida)
        End If


        altura = altura + 9

        'Cabecera detalle
        Vale.Titulo("CodEnvase", Col(1), altura, 13, 4, milinea.stilos.ReducidaBold)
        Vale.Titulo("Envase ", Col(2), altura, 102, 4, milinea.stilos.ReducidaBold)
        Vale.Titulo("Retira", Col(3), altura, 17, 4, milinea.stilos.ReducidaBold, ">")
        Vale.Titulo("Precio Ret.", Col(4), altura, 17, 4, milinea.stilos.ReducidaBold, ">")
        Vale.Titulo("Entrega", Col(5), altura, 13, 17, milinea.stilos.ReducidaBold, ">")
        Vale.Titulo("Precio Ent.", Col(6), altura, 17, 4, milinea.stilos.ReducidaBold, ">")


    End Sub


    Private Sub ImprimeDetalleValeEnvases(ByRef Vale As miFactura, ValeEnvases As E_ValeEnvases, ByRef altura As Integer, margen_izquierdo As Integer, Col As List(Of Integer))

        altura = altura + 8

        Dim ValeEnvase_Lineas As New E_ValeEnvases_Lineas(Idusuario, cn)
        Dim Envases As New E_Envases(Idusuario, cn)

        Dim consulta As New Cdatos.E_select
        consulta.SelCampo(ValeEnvase_Lineas.VEL_idenvase, "IdEnvase")
        consulta.SelCampo(Envases.ENV_Nombre, "Envase", ValeEnvase_Lineas.VEL_idenvase, Envases.ENV_IdEnvase)
        consulta.SelCampo(ValeEnvase_Lineas.VEL_retira, "Retira")
        consulta.SelCampo(ValeEnvase_Lineas.VEL_precioretira, "PrecioRetira")
        consulta.SelCampo(ValeEnvase_Lineas.VEL_entrega, "Entrega")
        consulta.SelCampo(ValeEnvase_Lineas.VEL_precioentrega, "PrecioEntrega")
        consulta.WheCampo(ValeEnvase_Lineas.VEL_idvale, "=", ValeEnvases.VEV_Idvale.Valor)


        Dim dtLineas As DataTable = ValeEnvase_Lineas.MiConexion.ConsultaSQL(consulta.SQL)


        For Each row As DataRow In dtLineas.Rows

            Dim IdEnvase As String = row("IdEnvase")
            Dim Envase As String = row("Envase")
            Dim Retira As Integer = VaInt(row("Retira"))
            Dim Entrega As Integer = VaInt(row("Entrega"))
            Dim PrecioRetira As Decimal = VaDec(row("PrecioRetira"))
            Dim PrecioEntrega As Decimal = VaDec(row("PrecioEntrega"))

            Vale.Titulo(IdEnvase, Col(1), altura, 13, 4, milinea.stilos.Reducida, ">")
            Vale.Titulo(Envase, Col(2), altura, 102, 4, milinea.stilos.Reducida)
            Vale.Titulo(Retira.ToString, Col(3), altura, 17, 4, milinea.stilos.Reducida, ">")
            Vale.Titulo(PrecioRetira.ToString("#,##0.000000"), Col(4), altura, 17, 4, milinea.stilos.Reducida, ">")
            Vale.Titulo(Entrega.ToString, Col(5), altura, 13, 17, milinea.stilos.Reducida, ">")
            Vale.Titulo(PrecioEntrega.ToString("#,##0.000000"), Col(6), altura, 17, 4, milinea.stilos.Reducida, ">")

            altura = altura + 4


        Next



    End Sub


End Module
