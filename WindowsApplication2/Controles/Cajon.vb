Public Class Cajon
    Dim Centros As New E_centros(Idusuario, cn)
    Dim TiposdeCateogorias As New E_TiposdeCategoria(Idusuario, cn)
    Dim Idiomas As New E_Idiomas(Idusuario, cn)
    Dim Monedas As New E_Moneda(Idusuario, cn)
    Dim Vendedores As New E_Vendedores(Idusuario, cn)

    Private Sub Cajon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        ComboSiNo()
        ComboProcesoMail()
        ComboGastos()
        ComboCentros()
        ComboTiposCat()
        ComboCategorias()
        ComboTFactura()
        ComboFacEnvases()
        ComboTGasto()
        ComboIdioma()
        ComboMoneda()
        ComboIvaEnv()
        ComboTipoenvase()
        ComboAgriMay()
        ComboBaseTot()
        ComboTipoPorte()
        ComboFacCom()
        ComboOrigenGastos()
        ComboVendedor()
        ComboLogs()
        ComboTiposFac()
        ComboTiposProducto()

        Botones()

    End Sub
    Private Sub Botones()

        With BtBuscaCentros
            .CL_CampoOrden = "idcentro"
            .CL_ConsultaSql = "Select idcentro,nombre from centros"
            .CL_DevuelveCampo = "idcentro"
            .cl_formu = Nothing
        End With

        With BtBuscaTgasto
            .CL_CampoOrden = "idtipogasto"
            .CL_ConsultaSql = "Select * from tiposdegastos"
            .CL_DevuelveCampo = "idtipogasto"
            .cl_formu = New FrmTiposdeGastos
        End With

        With BtBuscaTgastoAgri
            .CL_CampoOrden = "idtipogasto"
            .CL_ConsultaSql = "Select * from tiposdegastosagri"
            .CL_DevuelveCampo = "idtipogasto"
            .cl_formu = New FrmTiposdeGastosAgri
        End With



        With BtBuscaFamilia

            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select * from FamiliasGeneros"
            .CL_DevuelveCampo = "idfamilia"
            .cl_formu = New FrmFamilias
        End With

        With BtBuscaFamEnvases
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select * from FamiliaEnvases"
            .CL_DevuelveCampo = "idfamilia"
            .cl_formu = New FrmFamiliaEnvases
        End With

        With BtBuscaCliente
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idcliente,nombre,nif from clientes"
            .CL_DevuelveCampo = "idcliente"
            .cl_formu = New FrmClientes
        End With

        With BtBuscaAgri
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idagricultor,nombre,nif from agricultores"
            .CL_DevuelveCampo = "idagricultor"
            .cl_formu = New FrmAgricultores
        End With


        With BtBuscaNif
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select nif,nombre,domicilio,poblacion,provincia from nif"
            .CL_DevuelveCampo = "nif"
            .cl_formu = New FrmNif
        End With


        With BtBuscaTarifaCliente
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select * from tarifasclientes"
            .CL_DevuelveCampo = "idtarifa"
            .cl_formu = New FrmTarifasClientes
        End With

        With BtBuscaTarifaAgri
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select * from tarifasagricultores"
            .CL_DevuelveCampo = "idtarifa"
            .cl_formu = New FrmTarifasAgricultores
        End With

        With BtBuscaTiposCat
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select * from tiposdecategorias"
            .CL_DevuelveCampo = "id"
            .cl_formu = New FrmTiposCat
        End With

        With BtBuscaCatEntrada
            .CL_CampoOrden = "categoriacalibre"
            .CL_ConsultaSql = "Select id,categoriacalibre from categoriasentrada"
            .CL_DevuelveCampo = "id"
            .cl_formu = New FrmCatEntrada
        End With

        With BtBuscaCatSalida
            .CL_CampoOrden = "categoriacalibre"
            .CL_ConsultaSql = "Select id,categoriacalibre from categoriasSalida"
            .CL_DevuelveCampo = "id"
            .cl_formu = New FrmCatSalida
        End With


        With BtBuscaSubFamilias
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select codigo,nombre,idfamilia from Subfamilias"
            .CL_DevuelveCampo = "codigo"
            .cl_formu = New FrmFamilias
        End With


        With BtBuscaTipoCli
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idtipo,nombre from tiposclientes"
            .CL_DevuelveCampo = "idtipo"
            .cl_formu = New FrmTiposdeClientes
        End With

        With BtBuscaTipoAgri
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idtipo,nombre from tipoagricultor"
            .CL_DevuelveCampo = "idtipo"
            .cl_formu = New FrmTiposdeAgricultores
        End With

        With BtBuscaEnvases
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idenvase,nombre,tipo from Envases"
            .CL_DevuelveCampo = "idenvase"
            .cl_formu = New FrmEnvases

        End With

        With BtBuscaTecnico
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idtecnico,nombre,email,movil from tecnicos"
            .CL_DevuelveCampo = "idtecnico"
            .cl_formu = New FrmTecnicos

        End With

        With BtPrgCalidad
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idprograma,nombre from programacalidad"
            .CL_DevuelveCampo = "idprograma"
            .cl_formu = New FrmPrgCalidad

        End With

        With BtRecogida
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idrecogida,nombre from centrosrecogida"
            .CL_DevuelveCampo = "idrecogida"
            .cl_formu = New FrmCrecogida

        End With

        With BtBusPvta
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idpuntoventa,nombre,idcentro from puntoventa"
            .CL_DevuelveCampo = "idpuntoventa"
            .cl_formu = Nothing

        End With

        With BtBuscaNaves
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idnave,nombre,m2,idfinca from naves"
            .CL_DevuelveCampo = "idnave"
            .cl_formu = Nothing

        End With

        With BtFincas

            Dim Consulta As New Cdatos.E_select
            Dim Fincas As New E_fincas(Idusuario, cn)
            Dim Agricultores As New E_Agricultores(Idusuario, cn)
            Consulta.SelCampo(Fincas.idfinca)
            Consulta.SelCampo(Fincas.nombre)
            Consulta.SelCampo(Fincas.m2)
            Consulta.SelCampo(Fincas.idagricultor, "Codigo")
            Consulta.SelCampo(Agricultores.Nombre, "Agricultor", Fincas.idagricultor)
            .CL_CampoOrden = "Agricultor"
            .CL_ConsultaSql = Consulta.SQL
            .CL_DevuelveCampo = "idfinca"
            ' .cl_formu = New FrmFincas

        End With

        With BtBuscaTconfec
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idconfec,nombre from confecenvase"
            .CL_DevuelveCampo = "idconfec"
            .cl_formu = New FrmConfEnvases
        End With

        With BtBuscaTConfecPalet
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idconfec,nombre from confecpalet"
            .CL_DevuelveCampo = "idconfec"
            .cl_formu = New FrmConfEnvases
        End With


        With BtBuscaMarca
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idmarca,nombre from marcas"
            .CL_DevuelveCampo = "idmarca"
            .cl_formu = New FrmMarcas



        End With


        With BtVendedor
            Dim Consulta As New Cdatos.E_select
            Dim Vendedores As New E_Vendedores(Idusuario, cn)
            Dim sql As String

            Consulta.SelCampo(Vendedores.idcomercial)
            Consulta.SelCampo(Vendedores.nombre)
            Consulta.SelCampo(Vendedores.telefono)
            Consulta.WheCampo(Vendedores.idcomercial, ">=", "1")
            sql = Consulta.SQL
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idcomercial,nombre,telefono from vendedores"
            .CL_DevuelveCampo = "idcomercial"
            .cl_formu = New FrmVendedor
        End With


        With BtTransportistas
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idtransportista,nombre from transportistas"
            .CL_DevuelveCampo = "idtransportista"
            .cl_formu = New FrmTransportistas
        End With

        With BtGrupoGasCli
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idgrupo,nombre from gruposgastoscli"
            .CL_DevuelveCampo = "idgrupo"
            .cl_formu = New FrmGrupoGastosCli
        End With

        With BtConcepFac
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idconcepto,nombre from Conceptosfactura"
            .CL_DevuelveCampo = "idconcepto"
            .cl_formu = New FrmConceptosFac
        End With


        With BtGrupoGasPro
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idgrupo,nombre from gruposgastospro"
            .CL_DevuelveCampo = "idgrupo"
            .cl_formu = New FrmGrupoGastosPro
        End With


        With BtMedianeria
            Dim sql As String
            sql = "SELECT     dbo.Medianeria.idmedianeria, dbo.Medianeria.idagricultor,"
            sql = sql + " dbo.agricultores.nombre as Agricultor, dbo.Medianeria.nombre AS nombre"
            sql = sql + " FROM         dbo.Medianeria INNER JOIN"
            sql = sql + " dbo.agricultores ON dbo.Medianeria.idagricultor = dbo.agricultores.idagricultor"
            .CL_CampoOrden = "agricultor"
            .CL_ConsultaSql = sql
            .CL_DevuelveCampo = "idmedianeria"
            .cl_formu = New FrmMedianeria
        End With


        With BtBuscaPalets
            .CL_CampoOrden = "nombre"
            .CL_ConsultaSql = "Select idenvase,nombre,tipo from Envases where tipo='P'"
            .CL_DevuelveCampo = "idenvase"
            .cl_formu = New FrmEnvases

        End With


        With BtBuscaAlbEnt
            Dim AlbEntrada As New E_AlbEntrada
            Dim Agricultores As New E_Agricultores

            Dim consulta As New Cdatos.E_select
            consulta.SelCampo(AlbEntrada.idalbaran)
            consulta.SelCampo(AlbEntrada.fecha)
            consulta.SelCampo(AlbEntrada.campa)
            consulta.SelCampo(AlbEntrada.albaran)
            consulta.SelCampo(AlbEntrada.idagricultor)
            consulta.SelCampo(Agricultores.Nombre, "Agricultor", AlbEntrada.idagricultor, Agricultores.idagricultor)
            .CL_CampoOrden = "Agricultor"
            .CL_ConsultaSql = consulta.SQL
            .CL_DevuelveCampo = "albaran"
            .cl_formu = New FrmBascula
        End With
    End Sub

    Private Sub ComboLogs()
        Dim Dtcol As New DataTable

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))

        Dtcol.Rows.Add("T", "TODOS")
        Dtcol.Rows.Add("1", "Miguel")
        Dtcol.Rows.Add("2", "Antonio")
        CbUsuario.DataSource = Dtcol
        CbUsuario.DisplayMember = "Nombre"
        CbUsuario.ValueMember = "id"

        Dim dtcol2 As New DataTable
        dtcol2.Columns.Add(New DataColumn("id"))
        dtcol2.Columns.Add(New DataColumn("Nombre"))
        dtcol2.Rows.Add("T", "TODAS")
        dtcol2.Rows.Add("A", "Altas")
        dtcol2.Rows.Add("M", "Modificaciones")
        dtcol2.Rows.Add("B", "Bajas")
        CbOperacion.DataSource = dtcol2
        CbOperacion.DisplayMember = "Nombre"
        CbOperacion.ValueMember = "id"

        Dim dtcol3 As New DataTable
        dtcol3.Columns.Add(New DataColumn("id"))
        dtcol3.Columns.Add(New DataColumn("Nombre"))
        dtcol3.Rows.Add("T", "TODAS")
        dtcol3.Rows.Add("214", "Alhondiga")
        dtcol3.Rows.Add("2", "Contabilidad")
        dtcol3.Rows.Add("3", "Financiero")
        CbAplicacion.DataSource = dtcol3
        CbAplicacion.DisplayMember = "Nombre"
        CbAplicacion.ValueMember = "id"

        Dim dtcol4 As New DataTable
        dtcol4.Columns.Add(New DataColumn("Nombre"))
        dtcol4.Rows.Add("TODAS")
        For Each enti As Cdatos.Entidad In Cdatos.ListaEntidades
            dtcol4.Rows.Add(enti.NombreTabla)
        Next


        CbTabla.DataSource = dtcol4
        CbTabla.DisplayMember = "Nombre"
        CbTabla.ValueMember = "Nombre"



    End Sub
    Private Sub ComboSiNo()
        Dim Dtcol As New DataTable

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("S", "Si")
        Dtcol.Rows.Add("N", "No")
        CbBoxSiNo.DataSource = Dtcol
        CbBoxSiNo.DisplayMember = "Nombre"
        CbBoxSiNo.ValueMember = "id"


    End Sub
    Private Sub ComboAgriMay()
        Dim Dtcol As New DataTable

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("A", "Agricultor")
        Dtcol.Rows.Add("M", "Mayorista")
        CbAgrMay.DataSource = Dtcol
        CbAgrMay.DisplayMember = "Nombre"
        CbAgrMay.ValueMember = "id"


    End Sub

    Private Sub ComboBaseTot()
        Dim Dtcol As New DataTable

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("B", "Base")
        Dtcol.Rows.Add("T", "Total")
        CbTipoREt.DataSource = Dtcol
        CbTipoREt.DisplayMember = "Nombre"
        CbTipoREt.ValueMember = "id"


    End Sub

    Private Sub ComboTipoPorte()
        Dim Dtcol As New DataTable

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("C", "Compras")
        Dtcol.Rows.Add("V", "Ventas")
        Dtcol.Rows.Add("CV", "Compras/Ventas")
        CbTipoPorte.DataSource = Dtcol
        CbTipoPorte.DisplayMember = "Nombre"
        CbTipoPorte.ValueMember = "id"


    End Sub

    Private Sub ComboFacCom()
        Dim Dtcol As New DataTable

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("F", "Descuenta en factura")
        Dtcol.Rows.Add("C", "Descuento comercial")
        CbFacCom.DataSource = Dtcol
        CbFacCom.DisplayMember = "Nombre"
        CbFacCom.ValueMember = "id"


    End Sub

    Private Sub ComboTiposCat()
        Dim Dtcol As New DataTable

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("C", "Comercial")
        Dtcol.Rows.Add("D", "Destrio")
        Dtcol.Rows.Add("R", "Retirada")
        CbTiposCat.DataSource = Dtcol
        CbTiposCat.DisplayMember = "Nombre"
        CbTiposCat.ValueMember = "id"


    End Sub

    Private Sub BtBusca1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ComboProcesoMail()
        Dim Dtcol As New DataTable

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add(1, "Facturas")
        Dtcol.Rows.Add(2, "Albaranes")
        Dtcol.Rows.Add(3, "Reclamacion cobros")
        Dtcol.Rows.Add(4, "Reclamacion cuenta ventas")
        CbProceso.DataSource = Dtcol
        CbProceso.DisplayMember = "Nombre"
        CbProceso.ValueMember = "id"


    End Sub
    Private Sub ComboGastos()
        Dim Dtcol As New DataTable

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("%", "Porcentaje")
        Dtcol.Rows.Add("K", "Kilos")
        Dtcol.Rows.Add("B", "Bultos")
        Dtcol.Rows.Add("P", "Palets")
        Dtcol.Rows.Add("I", "Importe")

        CbTiposdeGastos.DataSource = Dtcol
        CbTiposdeGastos.DisplayMember = "Nombre"
        CbTiposdeGastos.ValueMember = "id"


    End Sub

    Private Sub ComboTiposFac()
        Dim Dtcol As New DataTable

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("1", "Generos")
        Dtcol.Rows.Add("2", "Envases Retornables")
        Dtcol.Rows.Add("3", "Envases No Retornables")
        Dtcol.Rows.Add("4", "Devolucion envases")
        Dtcol.Rows.Add("5", "Facturas abono")

        CbTipFac.DataSource = Dtcol
        CbTipFac.DisplayMember = "Nombre"
        CbTipFac.ValueMember = "id"


    End Sub

    Private Sub ComboTiposProducto()
        Dim Dtcol As New DataTable

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("1", "Generos")
        Dtcol.Rows.Add("2", "Envases")
        Dtcol.Rows.Add("3", "Varios")

        CbTipPro.DataSource = Dtcol
        CbTipPro.DisplayMember = "Nombre"
        CbTipPro.ValueMember = "id"


    End Sub

    Private Sub ComboOrigenGastos()
        Dim Dtcol As New DataTable

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("PO", "Portes")
        Dtcol.Rows.Add("CO", "Comisionistas")
        Dtcol.Rows.Add("CT", "Cortador")
        Dtcol.Rows.Add("CG", "Cargador")
        Dtcol.Rows.Add("OO", "Otros")

        CbOrigenGastos.DataSource = Dtcol
        CbOrigenGastos.DisplayMember = "Nombre"
        CbOrigenGastos.ValueMember = "id"


    End Sub

    Private Sub ComboCentros()
        Dim dt As New DataTable
        Dim Sql As String
        Sql = "Select idcentro,nombre from centros order by idcentro"
        dt = Centros.MiConexion.ConsultaSQL(Sql)

        CbCentros.DataSource = dt
        CbCentros.DisplayMember = "Nombre"
        CbCentros.ValueMember = "idcentro"


    End Sub

    Private Sub ComboCategorias()
        Dim dt As New DataTable
        Dim Sql As String
        Sql = "Select id,nombre from tiposdecategorias order by id"
        dt = TiposdeCateogorias.MiConexion.ConsultaSQL(Sql)

        CbCategorias.DataSource = dt
        CbCategorias.DisplayMember = "Nombre"
        CbCategorias.ValueMember = "id"


    End Sub

    Private Sub ComboTFactura()
        Dim Dtcol As New DataTable

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("1", "Factura")
        Dtcol.Rows.Add("2", "Albaran interno")
        Dtcol.Rows.Add("3", "Dto Factura")
        Dtcol.Rows.Add("4", "Vta comision")
        Dtcol.Rows.Add("5", "Confeccion")

        CbTiFacturaCli.DataSource = Dtcol
        CbTiFacturaCli.DisplayMember = "Nombre"
        CbTiFacturaCli.ValueMember = "id"


    End Sub

    Private Sub ComboFacEnvases()
        Dim Dtcol As New DataTable

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("1", "No Facturar")
        Dtcol.Rows.Add("2", "Detallar venta")
        Dtcol.Rows.Add("3", "Incluir en precio")
        Dtcol.Rows.Add("4", "Facturar siempre")

        CbFacturaEnvase.DataSource = Dtcol
        CbFacturaEnvase.DisplayMember = "Nombre"
        CbFacturaEnvase.ValueMember = "id"


    End Sub

    Private Sub ComboTGasto()
        Dim Dtcol As New DataTable

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("1", "Detallar gasto")
        Dtcol.Rows.Add("2", "Incluir en precio")

        CbFacTgasto.DataSource = Dtcol
        CbFacTgasto.DisplayMember = "Nombre"
        CbFacTgasto.ValueMember = "id"


    End Sub

    Private Sub ComboIdioma()
        Dim dt As New DataTable
        Dim Sql As String
        Sql = "Select ididioma,nombre from idiomas order by ididioma"
        dt = Idiomas.MiConexion.ConsultaSQL(Sql)

        CbIdioma.DataSource = dt
        CbIdioma.DisplayMember = "Nombre"
        CbIdioma.ValueMember = "ididioma"


    End Sub
    Private Sub ComboIvaEnv()
        Dim dt As New DataTable
        Dim Sql As String
        Sql = "Select id,iva from tiposiva order by id"
        dt = Idiomas.MiConexion.ConsultaSQL(Sql)

        CbIvaEnv.DataSource = dt
        CbIvaEnv.DisplayMember = "iva"
        CbIvaEnv.ValueMember = "id"


    End Sub
    Private Sub ComboMoneda()
        Dim dt As New DataTable
        Dim Sql As String
        Sql = "Select idmoneda,nombre from moneda order by idmoneda"
        dt = Monedas.MiConexion.ConsultaSQL(Sql)

        CbMoneda.DataSource = dt
        CbMoneda.DisplayMember = "Nombre"
        CbMoneda.ValueMember = "idmoneda"


    End Sub

    Private Sub ComboVendedor()
        Dim dt As New DataTable
        Dim Sql As String
        Sql = "Select idcomercial,nombre from vendedores order by idcomercial"
        dt = Vendedores.MiConexion.ConsultaSQL(Sql)

        CbVendedor.DataSource = dt
        CbVendedor.DisplayMember = "nombre"
        CbVendedor.ValueMember = "idcomercial"


    End Sub


    Private Sub ComboTipoenvase()
        Dim Dtcol As New DataTable

        Dtcol.Columns.Add(New DataColumn("id"))
        Dtcol.Columns.Add(New DataColumn("Nombre"))


        Dtcol.Rows.Add("E", "Envase")
        Dtcol.Rows.Add("M", "Material")
        Dtcol.Rows.Add("P", "Palet")

        CbTipoEnvase.DataSource = Dtcol
        CbTipoEnvase.DisplayMember = "Nombre"
        CbTipoEnvase.ValueMember = "id"


    End Sub

    Private Sub BtBusCpostal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
   
    End Sub

    Private Sub BtBusca1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtBuscaTarifaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtBuscaTgasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtBuscaEnvases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtBuscaCatEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtBuscaTarifaCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Lb39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtBusca1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class