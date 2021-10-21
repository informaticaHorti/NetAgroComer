Public Class FrmDATPeriodosAgricultor
    Inherits FrMantenimiento


    Dim Agricultores As New E_Agricultores(Idusuario, cn)
    Dim Generos As New E_Generos(Idusuario, cn)
    Dim DAT_PERIODOS As New E_DAT_PERIODOS(Idusuario, cn)
    



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ListaControles = New List(Of Object)
        ClGrid2.ListaCamposGr = New List(Of Cdatos.PropiedadesCamposGrid)

        ParametrosFrm()


    End Sub


    Private Sub ParametrosFrm()

        EntidadFrm = Agricultores


        CampoClave = 0 ' ultimo campo de la clave

        ParamTx(TxAgricultor, Agricultores.AGR_IdAgricultor, LbAgricultor, True)
        TxAgricultor.Autonumerico = False

        ParamTx(TxGenero, DAT_PERIODOS.DPE_IDGENERO, LbGenero, True)
        ParamTx(TxFechaInicio, DAT_PERIODOS.DPE_FECHAINICIO, Lb55, True)
        ParamTx(TxFechaFin, DAT_PERIODOS.DPE_FECHAFIN, Lb3, True)


        AsociarControles(TxAgricultor, BtBuscaAgricultor, Agricultores.btBusca, Agricultores, Agricultores.AGR_Nombre, LbNomAgricultor)
        AsociarControles(TxGenero, BtBuscaGenero, Generos.btBusca, Generos, Generos.GEN_NombreGenero, LbNomGenero)
        
        AsociarGrid(ClGrid2, TxGenero, TxFechaFin, DAT_PERIODOS)

        PropiedadesCamposGr(ClGrid2, "DPE_ID", "DPE_ID", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid2, "IdGenero", "CodGen", True, 50)
        PropiedadesCamposGr(ClGrid2, "Genero", "Genero", True, 200)
        PropiedadesCamposGr(ClGrid2, "Inicio", "Inicio", True, 75)
        PropiedadesCamposGr(ClGrid2, "Fin", "Fin", True, 75)
        

        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me


    End Sub



    Private Sub FrmDATPeriodosAgricultor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        BAnular.Visible = False


    End Sub


    Public Overrides Sub BorraPan()
        MyBase.BorraPan()

        LbNIF.Text = ""

    End Sub


    Public Overrides Sub ControlClave()
        MyBase.ControlClave()

        'CargaLineasGrid()

    End Sub


    Private Sub CargaLineasGrid()

        SqlGrid()
        ClGrid2.Nlinea = -1
        Cargalineas(ClGrid2)

    End Sub


    Private Sub SqlGrid()
        Dim id As String

        If LbId.Text = "+" Then
            id = "-1"
        Else
            id = LbId.Text
        End If

        'Atencion a las mayusculas !!!!
        ' el primer campo siempre la clave 

        PropiedadesCamposGr(ClGrid2, "DPE_ID", "DPE_ID", False) ' la clave de la linea que ponerla siempre en el primer campo
        PropiedadesCamposGr(ClGrid2, "IdGenero", "CodGen", True, 50)
        PropiedadesCamposGr(ClGrid2, "Genero", "Genero", True, 200)
        PropiedadesCamposGr(ClGrid2, "Inicio", "Inicio", True, 75)
        PropiedadesCamposGr(ClGrid2, "Fin", "Fin", True, 75)


        Dim CONSULTA2 As New Cdatos.E_select
        CONSULTA2.SelCampo(DAT_PERIODOS.DPE_ID, "DPE_ID")
        CONSULTA2.SelCampo(DAT_PERIODOS.DPE_IDGENERO, "CodGen")
        CONSULTA2.SelCampo(Generos.GEN_NombreGenero, "Genero", DAT_PERIODOS.DPE_IDGENERO)
        CONSULTA2.SelCampo(DAT_PERIODOS.DPE_FECHAINICIO, "Inicio")
        CONSULTA2.SelCampo(DAT_PERIODOS.DPE_FECHAFIN, "Fin")
        CONSULTA2.WheCampo(DAT_PERIODOS.DPE_IDAGRICULTOR, "=", id)

        Dim sql As String = CONSULTA2.SQL
        sql = sql + " ORDER BY DPE_FechaInicio DESC"


        ClGrid2.Consulta = sql


    End Sub


    Public Overrides Sub Entidad_a_Datos() ' despues de cargar los controles
        MyBase.Entidad_a_Datos()

        CargaLineasGrid()

        LbNIF.Text = Agricultores.AGR_Nif.Valor

    End Sub


    Public Overrides Sub Borralin(ByVal gr As ClGrid)
        MyBase.Borralin(gr)


    End Sub


    Public Overrides Sub Entidad_a_DatosLin(ByVal Grid As ClGrid)
        MyBase.Entidad_a_DatosLin(Grid)

    End Sub


    Public Overrides Function GuardarLineas(ByVal Gr As ClGrid) As Boolean

        'asociar cabecera con lineas
        Dim r As Boolean

        If Gr Is ClGrid2 Then
            DAT_PERIODOS.DPE_IDAGRICULTOR.Valor = LbId.Text
        End If



        SqlGrid()
        r = MyBase.GuardarLineas(Gr)


        Return r

    End Function

  

    Private Sub TxFechaInicio_Valida(ByVal edicion As System.Boolean) Handles TxFechaInicio.Valida

        If edicion Then
            If Not TxFechaInicio.MiError AndAlso VaDate(TxFechaInicio.Text) > VaDate("") AndAlso TxFechaFin.Text.Trim = "" Then
                TxFechaFin.Text = VaDate(TxFechaInicio.Text).AddDays(180).ToString("dd/MM/yyyy")
            End If
        End If

    End Sub

End Class