Imports System.Data.Odbc

Public Class Form5



    Private Sub Form5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



    End Sub


    Private Sub CargaGrid()

        Dim sql1 As String = "SELECT AEN_IdAlbaran, AEN_IdCentro, AEN_Campa, AEN_Albaran, AEN_Fecha FROM ALBENTRADA WHERE AEN_IDCENTRO = 1"
        Dim dtMaestro As DataTable = cn.ConsultaSQL(sql1)

        Dim sql2 As String = "SELECT AEL_IdAlbaran, AEL_Bultos, AEL_KilosNetos FROM ALBENTRADA_LINEAS LEFT JOIN ALBENTRADA ON AEN_IDALBARAN = AEL_IDALBARAN WHERE AEN_IDCENTRO = 1"
        Dim dtDetalle As DataTable = cn.ConsultaSQL(sql2)

        'Dim ds As New DataSet
        'ds.Tables.Add(dtMaestro)
        'ds.Tables.Add(dtDetalle)


        'Grid.DataSource = dtMaestro


        Dim data As New DataSet()
        data.Locale = System.Globalization.CultureInfo.InvariantCulture

        Dim conn As New Odbc.OdbcConnection(cn.CadenaConexion)


        ' Add data from the Customers table to the DataSet.
        Dim masterDataAdapter As New OdbcDataAdapter(sql1, conn)
        masterDataAdapter.Fill(data, "AlbEntrada")

        ' Add data from the Orders table to the DataSet.
        Dim detailsDataAdapter As New OdbcDataAdapter(sql2, conn)
        detailsDataAdapter.Fill(data, "AlbEntrada_Lineas")

        ' Establish a relationship between the two tables.
        Dim relation As New DataRelation("Albaranes", data.Tables("AlbEntrada").Columns("AEN_IdAlbaran"), data.Tables("AlbEntrada_Lineas").Columns("AEL_IdAlbaran"))
        data.Relations.Add(relation)

        ' Bind the master data connector to the Customers table.
        'masterBindingSource.DataSource = data
        'masterBindingSource.DataMember = "Customers"
        Grid.DataSource = data
        Grid.DataMember = "AlbEntrada"

        ' Bind the details data connector to the master data connector,
        ' using the DataRelation name to filter the information in the 
        ' details table based on the current row in the master table. 
        'detailsBindingSource.DataSource = masterBindingSource
        'detailsBindingSource.DataMember = "CustomersOrders"







    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        CargaGrid()

    End Sub
End Class