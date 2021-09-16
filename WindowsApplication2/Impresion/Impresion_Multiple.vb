
Public Class Impresion_documento


End Class

Public Class Impresion_AlbaranMedianero
    Inherits Impresion_documento

    Public IdAlbaran As String = ""
    Public bPreliminar As Boolean = False
    Public bMensaje As Boolean = False

    Public Sub New(IdAlbaran As String, bPreliminar As Boolean, bMensaje As Boolean)

        Me.IdAlbaran = IdAlbaran
        Me.bPreliminar = bPreliminar
        Me.bMensaje = bMensaje

    End Sub

End Class

Public Class Impresion_ValeGastosEntrada
    Inherits Impresion_documento

    Public IdAlbaran As String = ""
    Public TipoImpresion As TipoImpresion
    Public Impresora As String = ""
    Public RutaPDF As String = ""
    Public ArchivoPDF As String = ""

    Public Sub New(IdAlbaran As String, TipoImpresion As TipoImpresion,
                   Optional Impresora As String = "", Optional RutaPDF As String = "", Optional ArchivoPDF As String = "")

        Me.IdAlbaran = IdAlbaran
        Me.TipoImpresion = TipoImpresion
        Me.Impresora = Impresora
        Me.RutaPDF = RutaPDF
        Me.ArchivoPDF = ArchivoPDF

    End Sub

End Class


Public Class Impresion_ValeEnvases
    Inherits Impresion_documento

    Public IdVale As String = ""
    Public NumDev As String = ""
    Public bPreliminar As Boolean = False

    Public Sub New(IdVale As String, bPreliminar As Boolean, Optional NumDev As String = "")

        Me.IdVale = IdVale
        Me.NumDev = NumDev
        Me.bPreliminar = bPreliminar

    End Sub

End Class


Public Class Impresion_AlbaranFactura
    Inherits Impresion_documento

    Public AF As String = ""
    Public Id As String = ""
    Public TipoImpresion As TipoImpresion
    Public bCopia As Boolean = False
    Public Impresora As String
    Public rutaPDF As String
    Public archivoPDF As String

    Public Sub New(AF As String, Id As String, TipoImpresion As TipoImpresion, bCopia As Boolean,
                   Optional Impresora As String = "", Optional rutaPDF As String = "", Optional ArchivoPDF As String = "")

        Me.AF = AF
        Me.Id = Id
        Me.TipoImpresion = TipoImpresion
        Me.bCopia = bCopia
        Me.Impresora = Impresora
        Me.rutaPDF = rutaPDF
        Me.archivoPDF = ArchivoPDF

    End Sub


End Class


Public Class Impresion_CMR_Nacional
    Inherits Impresion_documento

    Public IdAlbaran As String = ""
    Public TipoImpresion As TipoImpresion
    Public Impresora As String = ""
    Public rutaPDF As String = ""

    Public Sub New(IdAlbaran As String, TipoImpresion As TipoImpresion, Optional Impresora As String = "", Optional rutaPDF As String = "")

        Me.IdAlbaran = IdAlbaran
        Me.TipoImpresion = TipoImpresion
        Me.Impresora = Impresora
        Me.rutaPDF = rutaPDF

    End Sub


End Class


Public Class Impresion_CMR_Internacional
    Inherits Impresion_documento

    Public IdAlbaran As String = ""
    Public TipoImpresion As TipoImpresion
    Public Impresora As String = ""
    Public rutaPDF As String = ""

    Public Sub New(IdAlbaran As String, TipoImpresion As TipoImpresion, Optional Impresora As String = "", Optional rutaPDF As String = "")

        Me.IdAlbaran = IdAlbaran
        Me.TipoImpresion = TipoImpresion
        Me.Impresora = Impresora
        Me.rutaPDF = rutaPDF

    End Sub


End Class



