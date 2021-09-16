Public Class FrClientesNew
    Inherits FrMantenimiento
    Dim Cliente As New E_Clientes(Idusuario, cn)
    Dim Pais As New E_Paises(Idusuario, CnComun)
    Dim Domicilio As New E_Domicilios(Idusuario, cn)


    Private Sub FrClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EntidadFrm = Cliente


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Cliente.CLI_Codigo, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, Cliente.CLI_Nombre, Lb2)

        ParamTx(TxDato5, Domicilio.DOM_Domicilio, Lb6)
        ParamTx(TxDato6, Domicilio.DOM_Poblacion, Lb7)
        ParamTx(TxDato7, Domicilio.DOM_Provincia, Lb9)
        ParamTx(TxDato8, Domicilio.DOM_Kilos, Lb10)
        ParamTx(TxDato9, Domicilio.DOM_Precio, Lb11)


        'ParamTx(TxDato4, Cliente.Observaciones, Lb4)

        AsociarControles(TxDato1, BtBuscaCliente, Cliente.btBusca, EntidadFrm)
        'AsociarBusca()

        PropiedadesCamposGr(ClGrid1, Domicilio.DOM_Id.NombreCampo, "", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid1, Domicilio.DOM_Domicilio.NombreCampo, "Domicilio", True, 40)
        PropiedadesCamposGr(ClGrid1, Domicilio.DOM_Poblacion.NombreCampo, "Poblacion", True, 50)
        PropiedadesCamposGr(ClGrid1, Domicilio.DOM_Provincia.NombreCampo, "Provincia", True, 60)

        PropiedadesCamposGr(ClGrid1, Domicilio.DOM_Kilos.NombreCampo, "Kilos", True, 10, True, "#,###", "{0:n0}")
        PropiedadesCamposGr(ClGrid1, Domicilio.DOM_Precio.NombreCampo, "Precio", True, 20)
        PropiedadesCamposGr(ClGrid1, "Importe", "IMPORTE", True, 30, True, "#,###0.00", "{0:n2}")


        AsociarGrid(ClGrid1, TxDato5, TxDato9, Domicilio)




        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub

    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text


    End Sub
    Public Overrides Sub Guardar()
        Dim a = ""

        MyBase.Guardar()

    End Sub
    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()
        CargaLineasGridDomicilios()
    End Sub
    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean
        Domicilio.DOM_IdCliente.Valor = TxDato1.Text ' 
        Return MyBase.GuardarLineas(Gr)
    End Function

    Private Sub TxDato1_Valida(ByVal edicion As Boolean) Handles TxDato1.Valida
        If edicion = True Then
            CargaLineasGridDomicilios()
        End If
    End Sub
    Private Sub CargaLineasGridDomicilios()
        Dim sql As String
        sql = "Select DOM_iddomicilio AD IdDomicilio, DOM_domicilio as Domicilio, DOM_poblacion as Poblacion, DOM_provincia as Provincia, DOM_kilos as Kilos, DOM_precio as Precio, DOM_kilos*DOM_precio as importe from domicilios where DOM_idcliente=" + TxDato1.Text + " order by DOM_iddomicilio"
        ClGrid1.Consulta = sql
        ClGrid1.Nlinea = -1
        Cargalineas(ClGrid1)
    End Sub

    Private Sub TxDato8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato8.TextChanged

    End Sub

    Private Sub TxDato3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxDato3.TextChanged

    End Sub

    Private Sub TxDato8_Valida(ByVal edicion As Boolean) Handles TxDato8.Valida
        LbImporte.Text = Format(VaDec(TxDato8.Text) * VaDec(TxDato9.Text), "#,###0.00")

    End Sub
    Private Sub TxDato9_Valida(ByVal edicion As Boolean) Handles TxDato9.Valida
        LbImporte.Text = Format(VaDec(TxDato8.Text) * VaDec(TxDato9.Text), "#,###0.00")

    End Sub

    Private Sub ClGrid1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClGrid1.Load

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ClGrid1.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class