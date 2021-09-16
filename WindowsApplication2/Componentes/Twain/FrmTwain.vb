Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports NetAgro.TwainLib
Imports NetAgro.GdiPlusLib
Imports System.Runtime.InteropServices
Imports PdfSharp.Pdf
Imports PdfSharp.Drawing
Imports PdfSharp


Namespace TwainGui

    Public Class FrmTwain
        Inherits System.Windows.Forms.Form
        Implements IMessageFilter


        <DllImport("kernel32.dll", ExactSpelling:=True)> Friend Shared Function GlobalLock(ByVal handle As IntPtr) As IntPtr
        End Function


        Private msgfilter As Boolean
        Private tw As Twain


        Dim ConfigDiv As New E_ConfiguracionesDiversas(Idusuario, cn)
        Private picnumber As Integer = 0
        Dim bmi As BITMAPINFOHEADER



        Private _ruta As String = ""



        <STAThread()> Shared Sub Main()
            If (Twain.ScreenBitDepth < 15) Then
                MessageBox.Show("Need high/true-color video mode!", "Screen Bit Depth", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim mf As FrmTwain = New FrmTwain()
            Application.Run(mf)
        End Sub

        Public Sub New()
            InitializeComponent()
            tw = New Twain()
            tw.Init(Me.Handle)
        End Sub


        Private Sub FrmTwain_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            _ruta = ConfigDiv.xDameValor(E_ConfiguracionesDiversas.eClaves.RUTA_ARCHIVOS_ADJUNTOS_TEMP) & "\"


        End Sub


        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
        Private components As System.ComponentModel.IContainer

#Region " Windows Form Designer generated code "

        Private mdiClient1 As System.Windows.Forms.MdiClient
        Private menuMainFile As System.Windows.Forms.MenuItem
        Friend WithEvents menuItemScan As System.Windows.Forms.MenuItem
        Friend WithEvents menuItemSelSrc As System.Windows.Forms.MenuItem
        Private menuMainWindow As System.Windows.Forms.MenuItem
        Friend WithEvents menuItemExit As System.Windows.Forms.MenuItem
        Private menuItemSepr As System.Windows.Forms.MenuItem
        Private mainFrameMenu As System.Windows.Forms.MainMenu
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.menuMainFile = New System.Windows.Forms.MenuItem()
            Me.menuItemSelSrc = New System.Windows.Forms.MenuItem()
            Me.menuItemScan = New System.Windows.Forms.MenuItem()
            Me.menuItemSepr = New System.Windows.Forms.MenuItem()
            Me.menuItemExit = New System.Windows.Forms.MenuItem()
            Me.mainFrameMenu = New System.Windows.Forms.MainMenu(Me.components)
            Me.menuMainWindow = New System.Windows.Forms.MenuItem()
            Me.mdiClient1 = New System.Windows.Forms.MdiClient()
            Me.SuspendLayout()
            '
            'menuMainFile
            '
            Me.menuMainFile.Index = 0
            Me.menuMainFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemSelSrc, Me.menuItemScan, Me.menuItemSepr, Me.menuItemExit})
            Me.menuMainFile.MergeType = System.Windows.Forms.MenuMerge.MergeItems
            Me.menuMainFile.Text = "Archivo"
            '
            'menuItemSelSrc
            '
            Me.menuItemSelSrc.Index = 0
            Me.menuItemSelSrc.MergeOrder = 11
            Me.menuItemSelSrc.Text = "Selecionar escaner"
            '
            'menuItemScan
            '
            Me.menuItemScan.Index = 1
            Me.menuItemScan.MergeOrder = 12
            Me.menuItemScan.Text = "Capturar"
            '
            'menuItemSepr
            '
            Me.menuItemSepr.Index = 2
            Me.menuItemSepr.MergeOrder = 19
            Me.menuItemSepr.Text = "-"
            '
            'menuItemExit
            '
            Me.menuItemExit.Index = 3
            Me.menuItemExit.MergeOrder = 21
            Me.menuItemExit.Text = "Salir"
            '
            'mainFrameMenu
            '
            Me.mainFrameMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuMainFile, Me.menuMainWindow})
            '
            'menuMainWindow
            '
            Me.menuMainWindow.Index = 1
            Me.menuMainWindow.MdiList = True
            Me.menuMainWindow.Text = "Ventana"
            '
            'mdiClient1
            '
            Me.mdiClient1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mdiClient1.Location = New System.Drawing.Point(0, 0)
            Me.mdiClient1.Name = "mdiClient1"
            Me.mdiClient1.Size = New System.Drawing.Size(961, 548)
            Me.mdiClient1.TabIndex = 0
            '
            'FrmTwain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(961, 548)
            Me.Controls.Add(Me.mdiClient1)
            Me.IsMdiContainer = True
            Me.Menu = Me.mainFrameMenu
            Me.Name = "FrmTwain"
            Me.Text = "Capturar documento"
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Sub menuItemExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItemExit.Click
            Close()
        End Sub

        Private Sub menuItemScan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItemScan.Click
            If (Not msgfilter) Then
                Me.Enabled = False
                msgfilter = True
                Application.AddMessageFilter(Me)
            End If
            tw.Acquire()
        End Sub

        Private Sub menuItemSelSrc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItemSelSrc.Click
            tw.Select()
        End Sub


        Public Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
            Dim cmd As TwainCommand = tw.PassMessage(m)
            If (cmd = TwainCommand.Not) Then
                Return False
            End If

            Select Case cmd
                Case TwainCommand.Null
                    EndingScan()
                    tw.CloseSrc()

                Case TwainCommand.CloseRequest
                    EndingScan()
                    tw.CloseSrc()
                Case TwainCommand.CloseOk
                    EndingScan()
                    tw.CloseSrc()
                Case TwainCommand.DeviceEvent
                Case TwainCommand.TransferReady

                    Dim pics As ArrayList = tw.TransferPictures()
                    Dim lstArchivos As New List(Of String)

                    EndingScan()
                    tw.CloseSrc()
                    picnumber += 1

                    Dim i As Integer


                    For i = 0 To pics.Count - 1 Step 1

                        Dim img As IntPtr = CType(pics(i), IntPtr)


                        'Guardar imagen a archivo en carpeta temporal
                        'TODO: Borrar el PDF una vez usado


                        Dim bmprect As New Rectangle(0, 0, 0, 0)
                        Dim bmpptr As IntPtr = GlobalLock(img)
                        Dim pixptr As IntPtr = GetPixelInfo(bmpptr, bmprect)


                        Dim fichero As String = _ruta & "Scan_Temp_" & i.ToString & ".png"

                        If System.IO.Directory.Exists(_ruta) Then
                            Gdip.Save(fichero, bmpptr, pixptr)
                            lstArchivos.Add(fichero)
                        Else
                            MsgBox("Error en la ruta de creación del archivo temporal")
                            Return False
                        End If


                        'Gdip.SaveDIBAs(Me.Text, bmpptr, pixptr)

                        'Dim newpic As PicForm = New PicForm(img)
                        'newpic.MdiParent = Me
                        'Dim picnum As Integer = i + 1
                        'newpic.Text = "ScanPass" + picnumber.ToString() + "_Pic" + picnum.ToString()
                        'newpic.Show()


                    Next


                    If lstArchivos.Count > 0 Then


                        If lstArchivos.Count > 0 Then

                            Dim num As Integer = 0


                            Dim doc As New PdfDocument()



                            For Each fichero As String In lstArchivos


                                Dim page As New PdfPage

                                'Dim img As XImage = XImage.FromFile(fichero)
                                Dim imagen As Image = Image.FromFile(fichero)
                                Dim img As XImage = XImage.FromGdiPlusImage(imagen)


                                doc.Pages.Add(page)
                                Dim xgr As XGraphics = XGraphics.FromPdfPage(doc.Pages(num))

                                page.Size = PageSize.A4
                                Dim rect As XRect = New XRect(0, 0, page.Width, page.Height)



                                xgr.DrawImage(img, rect)
                                'xgr.DrawImage(img, 0, 0, img.Width, img.Height)


                                imagen.Dispose()
                                xgr.Dispose()

                                imagen = Nothing
                                xgr = Nothing


                                If System.IO.File.Exists(fichero) Then
                                    System.IO.File.Delete(fichero)
                                End If



                                num = num + 1



                            Next

                            doc.Save(_ruta & "Scan_Temp_" & Now.ToString("yyyyMMdd-HHmmssfff") & ".pdf")
                            doc.Close()


                        End If



                    End If




            End Select



            Return True

        End Function


        Private Sub EndingScan()
            If (msgfilter) Then
                Application.RemoveMessageFilter(Me)
                msgfilter = False
                Me.Enabled = True
                Me.Activate()
            End If
        End Sub


        Protected Function GetPixelInfo(ByVal bmpptr As IntPtr, bmprect As Rectangle) As IntPtr

            bmi = New BITMAPINFOHEADER()
            Marshal.PtrToStructure(bmpptr, bmi)

            bmprect.X = bmprect.Y = 0
            bmprect.Width = bmi.biWidth
            bmprect.Height = bmi.biHeight

            If (bmi.biSizeImage = 0) Then
                bmi.biSizeImage = Int((((bmi.biWidth * bmi.biBitCount) + 31) & Hex(Not (31))) / 2 ^ 3) * bmi.biHeight
            End If

            Dim p As Integer = bmi.biClrUsed
            If ((p = 0) And (bmi.biBitCount <= 8)) Then
                p = Int(1 * 2 ^ bmi.biBitCount)
            End If
            p = (p * 4) + bmi.biSize + CType(bmpptr.ToInt32, Integer)


            Return New IntPtr(p)

        End Function


    End Class





End Namespace
