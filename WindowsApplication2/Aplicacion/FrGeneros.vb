
Public Class FrGeneros


    Inherits FrMantenimiento


    Private Sub FrGeneros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Genero As New E_Generos(Idusuario, cn)
        'Dim Familia As New E_FamiliasGeneros(Idusuario, cn)
        Dim SubFamilia As New E_Subfamilias(Idusuario, cn)
        EntidadFrm = Genero


        Dim lc As New List(Of Object)
        ListaControles = lc

        ParamTx(TxDato1, Genero.GEN_IdGenero, Lb1, True)
        CampoClave = 0 ' ultimo campo de la clave
        ParamTx(TxDato2, Genero.GEN_NombreGenero, Lb2)
        ParamTx(TxDato3, Genero.GEN_IdsubFamilia, Lb3, True)


        AsociarControles(TxDato1, BtBuscaGenero, Genero.btBusca, EntidadFrm)
        AsociarControles(TxDato3, BtBuscaFamilia, SubFamilia.btBusca, SubFamilia, SubFamilia.SFA_nombre, Lb4)

        BotonesAvance1.Mientidad = EntidadFrm
        BotonesAvance1.CampoOrden = EntidadFrm.ClavePrimaria
        BotonesAvance1.Formulario = Me

    End Sub

    Public Overrides Sub ControlClave()
        ' componemos la clave
        LbId.Text = TxDato1.Text


    End Sub
    Public Overrides Sub Borrapan()
        MyBase.BorraPan()


    End Sub
    Public Overrides Sub DespuesdeGuardar()
        MyBase.DespuesdeGuardar()
        'MsgBox("hola")

    End Sub

  
    
    Private Sub Lb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lb2.Click

    End Sub
End Class
