Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Runtime.InteropServices
' DllImport
Imports System.Security.Principal
' WindowsImpersonationContext
Imports System.Security.Permissions
' PermissionSetAttribute
Imports System.IO

Namespace ImpersonateLib
    ' group type enum
    Public Enum SECURITY_IMPERSONATION_LEVEL As Integer
        SecurityAnonymous = 0
        SecurityIdentification = 1
        SecurityImpersonation = 2
        SecurityDelegation = 3
    End Enum

    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public NotInheritable Class Impersonate
        Public Sub New()
        End Sub
        ' obtains user token
        <DllImport("advapi32.dll", SetLastError:=True)> _
        Private Shared Function LogonUser(pszUsername As String, pszDomain As String, pszPassword As String, dwLogonType As Integer, dwLogonProvider As Integer, ByRef phToken As IntPtr) As Boolean
        End Function

        ' closes open handes returned by LogonUser
        <DllImport("kernel32.dll", CharSet:=CharSet.Auto)> _
        Private Shared Function CloseHandle(handle As IntPtr) As Boolean
        End Function

        ' creates duplicate token handle
        <DllImport("advapi32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
        Private Shared Function DuplicateToken(ExistingTokenHandle As IntPtr, SECURITY_IMPERSONATION_LEVEL As Integer, ByRef DuplicateTokenHandle As IntPtr) As Boolean
        End Function

        ''' <summary>
        ''' Attempts to impersonate a user.  If successful, returns
        ''' a WindowsImpersonationContext of the new users identity.
        ''' </summary>
        ''' <param name="sUsername">Username you want to impersonate</param>
        ''' <param name="sDomain">Logon domain</param>
        ''' <param name="sPassword">User's password to logon with</param>
        ''' <returns></returns>
        Public Shared Function ImpersonateUser(sUsername As String, sDomain As String, sPassword As String) As WindowsImpersonationContext
            ' initialize tokens
            Dim pExistingTokenHandle As New IntPtr(0)
            Dim pDuplicateTokenHandle As New IntPtr(0)
            pExistingTokenHandle = IntPtr.Zero
            pDuplicateTokenHandle = IntPtr.Zero

            ' if domain name was blank, assume local machine
            If sDomain = "" Then
                sDomain = System.Environment.MachineName
            End If

            Try
                Dim sResult As String = Nothing

                Const LOGON32_PROVIDER_DEFAULT As Integer = 0
                ' create token
                Const LOGON32_LOGON_INTERACTIVE As Integer = 2

                ' get handle to token
                Dim bImpersonated As Boolean = LogonUser(sUsername, sDomain, sPassword, LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, pExistingTokenHandle)

                ' did impersonation fail?
                If False = bImpersonated Then
                    Dim nErrorCode As Integer = Marshal.GetLastWin32Error()
                    sResult = "LogonUser() failed with error code: " + nErrorCode + vbCr & vbLf

                    ' show the reason why LogonUser failed
                    Throw New Exception(sResult)
                End If

                ' Get identity before impersonation
                sResult += "Before impersonation: " + WindowsIdentity.GetCurrent().Name + vbCr & vbLf

                Dim bRetVal As Boolean = DuplicateToken(pExistingTokenHandle, CInt(SECURITY_IMPERSONATION_LEVEL.SecurityImpersonation), pDuplicateTokenHandle)

                ' did DuplicateToken fail?
                If False = bRetVal Then
                    Dim nErrorCode As Integer = Marshal.GetLastWin32Error()
                    CloseHandle(pExistingTokenHandle)
                    ' close existing handle
                    sResult += "DuplicateToken() failed with error code: " + nErrorCode + vbCr & vbLf

                    ' show the reason why DuplicateToken failed
                    Throw New Exception(sResult)
                Else
                    ' create new identity using new primary token
                    Dim newId As New WindowsIdentity(pDuplicateTokenHandle)
                    Dim impersonatedUser As WindowsImpersonationContext = newId.Impersonate()


                    ' check the identity after impersonation
                    'sResult += "After impersonation: " + WindowsIdentity.GetCurrent().Name + "\r\n";

                    'throw new Exception(sResult);
                    Return impersonatedUser
                End If
            Catch ex As Exception
                Throw ex
            Finally
                ' close handle(s)
                If pExistingTokenHandle <> IntPtr.Zero Then
                    CloseHandle(pExistingTokenHandle)
                End If
                If pDuplicateTokenHandle <> IntPtr.Zero Then
                    CloseHandle(pDuplicateTokenHandle)
                End If
            End Try
        End Function
    End Class
End Namespace


'Imports System.Runtime.InteropServices
'Imports System.Security.Permissions
'Imports System.Security.Principal
'Imports Microsoft.Win32.SafeHandles
'Imports System.Runtime.ConstrainedExecution
'Imports System.Security

'Module Module1



'    Public Class Impersonate_User

'        'Private Declare Auto Function LogonUser Lib "advapi32.dll" (ByVal lpszUsername As [String], _
'        '    ByVal lpszDomain As [String], ByVal lpszPassword As [String], _
'        '    ByVal dwLogonType As Integer, ByVal dwLogonProvider As Integer, _
'        '    ByRef phToken As IntPtr) As Boolean

'        Private Declare Auto Function LogonUser Lib "advapi32.dll" (ByVal lpszUsername As [String], _
'            ByVal lpszDomain As [String], ByVal lpszPassword As [String], _
'            ByVal dwLogonType As Integer, ByVal dwLogonProvider As Integer, _
'            <Out()> ByRef phToken As SafeTokenHandle) As Boolean

'        Public Declare Auto Function CloseHandle Lib "kernel32.dll" (ByVal handle As IntPtr) As Boolean


'        <PermissionSetAttribute(SecurityAction.Demand, Name:="FullTrust")> _
'        Public Sub New(userName As String, domainName As String, password As String)
'            Dim safeTokenHandle As SafeTokenHandle
'            Dim tokenHandle As New IntPtr(0)
'            Try


'                'Dim userName, domainName As String

'                ' Get the user token for the specified user, domain, and password using the 
'                ' unmanaged LogonUser method.  
'                ' The local machine name can be used for the domain name to impersonate a user on this machine.
'                'Console.Write("Enter the name of a domain on which to log on: ")
'                'domainName = Console.ReadLine()

'                'Console.Write("Enter the login of a user on {0} that you wish to impersonate: ", domainName)
'                'userName = Console.ReadLine()

'                'Console.Write("Enter the password for {0}: ", userName)

'                Const LOGON32_PROVIDER_DEFAULT As Integer = 0
'                'This parameter causes LogonUser to create a primary token.
'                Const LOGON32_LOGON_INTERACTIVE As Integer = 2

'                ' Call LogonUser to obtain a handle to an access token.
'                Dim returnValue As Boolean = LogonUser(userName, domainName, password, LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, safeTokenHandle)

'                Console.WriteLine("LogonUser called.")

'                If False = returnValue Then
'                    Dim ret As Integer = Marshal.GetLastWin32Error()
'                    Console.WriteLine("LogonUser failed with error code : {0}", ret)
'                    Throw New System.ComponentModel.Win32Exception(ret)

'                    Return
'                End If
'                Using safeTokenHandle
'                    Dim success As String
'                    If returnValue Then success = "Yes" Else success = "No"
'                    Console.WriteLine(("Did LogonUser succeed? " + success))
'                    Console.WriteLine(("Value of Windows NT token: " + safeTokenHandle.DangerousGetHandle().ToString()))

'                    ' Check the identity.
'                    Console.WriteLine(("Before impersonation: " + WindowsIdentity.GetCurrent().Name))

'                    ' Use the token handle returned by LogonUser.
'                    Dim newId As New WindowsIdentity(safeTokenHandle.DangerousGetHandle())
'                    Using impersonatedUser As WindowsImpersonationContext = newId.Impersonate()

'                        ' Check the identity.
'                        Console.WriteLine(("After impersonation: " + WindowsIdentity.GetCurrent().Name))

'                        ' Free the tokens.
'                    End Using
'                End Using
'            Catch ex As Exception
'                Console.WriteLine(("Exception occurred. " + ex.Message))
'            End Try
'        End Sub 'Main 


'        ' Test harness.
'        ' If you incorporate this code into a DLL, be sure to demand FullTrust.
'        '<PermissionSetAttribute(SecurityAction.Demand, Name:="FullTrust")> _
'        'Public Overloads Shared Sub Main(ByVal args() As String)
'        '    Dim safeTokenHandle As SafeTokenHandle
'        '    Dim tokenHandle As New IntPtr(0)
'        '    Try


'        '        Dim userName, domainName As String

'        '        ' Get the user token for the specified user, domain, and password using the 
'        '        ' unmanaged LogonUser method.  
'        '        ' The local machine name can be used for the domain name to impersonate a user on this machine.
'        '        Console.Write("Enter the name of a domain on which to log on: ")
'        '        domainName = Console.ReadLine()

'        '        Console.Write("Enter the login of a user on {0} that you wish to impersonate: ", domainName)
'        '        userName = Console.ReadLine()

'        '        Console.Write("Enter the password for {0}: ", userName)

'        '        Const LOGON32_PROVIDER_DEFAULT As Integer = 0
'        '        'This parameter causes LogonUser to create a primary token.
'        '        Const LOGON32_LOGON_INTERACTIVE As Integer = 2

'        '        ' Call LogonUser to obtain a handle to an access token.
'        '        Dim returnValue As Boolean = LogonUser(userName, domainName, Console.ReadLine(), LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, safeTokenHandle)

'        '        Console.WriteLine("LogonUser called.")

'        '        If False = returnValue Then
'        '            Dim ret As Integer = Marshal.GetLastWin32Error()
'        '            Console.WriteLine("LogonUser failed with error code : {0}", ret)
'        '            Throw New System.ComponentModel.Win32Exception(ret)

'        '            Return
'        '        End If
'        '        Using safeTokenHandle
'        '            Dim success As String
'        '            If returnValue Then success = "Yes" Else success = "No"
'        '            Console.WriteLine(("Did LogonUser succeed? " + success))
'        '            Console.WriteLine(("Value of Windows NT token: " + safeTokenHandle.DangerousGetHandle().ToString()))

'        '            ' Check the identity.
'        '            Console.WriteLine(("Before impersonation: " + WindowsIdentity.GetCurrent().Name))

'        '            ' Use the token handle returned by LogonUser.
'        '            Dim newId As New WindowsIdentity(safeTokenHandle.DangerousGetHandle())
'        '            Using impersonatedUser As WindowsImpersonationContext = newId.Impersonate()

'        '                ' Check the identity.
'        '                Console.WriteLine(("After impersonation: " + WindowsIdentity.GetCurrent().Name))

'        '                ' Free the tokens.
'        '            End Using
'        '        End Using
'        '    Catch ex As Exception
'        '        Console.WriteLine(("Exception occurred. " + ex.Message))
'        '    End Try
'        'End Sub 'Main 
'    End Class 'Class1
'End Module

'Public NotInheritable Class SafeTokenHandle
'    Inherits SafeHandleZeroOrMinusOneIsInvalid

'    Private Sub New()
'        MyBase.New(True)

'    End Sub 'New

'    Private Declare Auto Function LogonUser Lib "advapi32.dll" (ByVal lpszUsername As [String], _
'            ByVal lpszDomain As [String], ByVal lpszPassword As [String], _
'            ByVal dwLogonType As Integer, ByVal dwLogonProvider As Integer, _
'            ByRef phToken As IntPtr) As Boolean
'    <DllImport("kernel32.dll"), ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success), SuppressUnmanagedCodeSecurity()> _
'    Private Shared Function CloseHandle(ByVal handle As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean

'    End Function
'    Protected Overrides Function ReleaseHandle() As Boolean
'        Return CloseHandle(handle)

'    End Function 'ReleaseHandle
'End Class 'SafeTokenHandle


''Imports System.Runtime.InteropServices
''Imports System.Security.Principal
''Imports System.Security.Permissions

''Public Class Impersonate_User

''    <DllImport("advapi32.dll")> _
''    Private Shared Function LogonUser(ByVal lpszUsername As String, _
''                               ByVal lpszDomain As String, _
''                               ByVal lpszPassword As String, _
''                               ByVal dwLogonType As Integer, _
''                               ByVal dwLogonProvider As Integer, _
''                               ByRef phToken As Integer) As Boolean
''    End Function

''    <DllImport("Kernel32.dll")> _
''    Private Shared Function GetLastError() As Integer
''    End Function

''    Private Enum Logon
''        Interactive = 2
''        Network = 3
''        Batch = 4
''        Service = 5
''        Unlock = 7
''        NetworkCleartext = 8
''        NewCredentials = 9
''    End Enum

''    Private Enum Provider
''        UserDefault = 0
''        WindowsNT35 = 1
''        WindowsNT40 = 2
''        Windows2000 = 3
''    End Enum

''    Private NewContext As WindowsImpersonationContext

''    <SecurityPermission(SecurityAction.Demand, ControlPrincipal:=True, UnmanagedCode:=True)> _
''    Private Shared Function GetWindowsIdentity(ByVal Username As String, _
''                                        ByVal Domain As String, _
''                                        ByVal Password As String) As WindowsIdentity
''        Dim SecurityToken As Integer
''        Dim Success As Boolean

''        'possible to extend program to allow changes to the logon type and provider 
''        'as Ineractive is slower and caches the information compared to the Logon.Network type. 
''        'Though that leaves open the private enumeration information. 
''        Success = LogonUser(Username, Domain, Password, _
''                            Logon.Network, Provider.UserDefault, _
''                            SecurityToken)

''        If Not Success Then
''            Throw New System.Exception("Logon Failed. Error: " & GetLastError())
''            Err.Clear()
''        Else
''            GetWindowsIdentity = New WindowsIdentity(New IntPtr(SecurityToken))
''        End If
''    End Function

''    Public Function ImpersonateUser(ByVal username As String, _
''                    ByVal domain As String, ByVal pwd As String) As Boolean



''        Dim NewIdentity As WindowsIdentity
''        Dim CurIdentity As WindowsIdentity

''        Try
''            NewIdentity = GetWindowsIdentity(username, domain, pwd)

''            If Not NewIdentity Is Nothing Then
''                NewContext = NewIdentity.Impersonate
''                CurIdentity = WindowsIdentity.GetCurrent

''                'Debug.WriteLine("Impersonated ID: " & CurIdentity.Name) ‘used for demo/example

''                'RemoveImpersonation()

''                'just removing impersonation for demo/example 
''                'would comment out for actual use and call the 
''                'the RemoveImpersonation() method if all went well 
''                'else it gets called upon error event

''                CurIdentity = WindowsIdentity.GetCurrent 'used for demo/example 
''                'Debug.WriteLine("Logon ID: " & CurIdentity.Name) ‘used for demo/example

''                ImpersonateUser = True
''            Else
''                Err.Raise(7000, ImpersonateUser)
''            End If

''        Catch ex As Exception
''            RemoveImpersonation()
''            ImpersonateUser = False
''            Throw New System.Exception("IM Error: " & ex.Message)
''            Err.Clear()
''        End Try

''        Return ImpersonateUser
''    End Function

''    Public Function RemoveImpersonation() As Boolean
''        Try
''            If Not NewContext Is Nothing Then 'test if object was ever created/referenced 
''                NewContext.Undo() 'if so, then undo impersonation. 
''                RemoveImpersonation = True
''            Else
''                RemoveImpersonation = True 'never created object, so no impersonation to revert. 
''            End If
''        Catch ex As Exception 'something happened during removal, so warn calling app to handle 
''            RemoveImpersonation = False
''            Throw New System.Exception("Removal Failure: " & ex.Message)
''            Err.Clear()
''        End Try
''        Return RemoveImpersonation
''    End Function

''End Class