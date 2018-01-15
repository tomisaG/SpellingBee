Public Class TeachersLogin
    Private Sub cmd_login_Click(sender As Object, e As EventArgs) Handles cmd_login.Click
        Dim Username As String = ""
        Dim Password As String = ""
        Dim YearGroup As Integer = ""
        Dim Fullline As String = ""
        Dim Searchstring As String = txt_Username.Text
        FileOpen(1, "n:\TomOye161$\Computing\Year 2\Spelling Bee\SpellingBee\SpellingBee\bin\Debug\Student_Details", OpenMode.Input)
        Do Until EOF(1)
            Fullline = LineInput(1)
            Dim item() As String = Split(Fullline, ",")
            If Searchstring = item(1) Then
                Username = item(1)
                Password = item(2)
                YearGroup = item(3)
            End If
        Loop
        If txt_Username.Text = Username And txt_Password.Text = Password And YearGroup = YearGroup Then
            My.Forms.Login.Text = Now.ToString
            My.Forms.Set_Spelling.Show()
        Else
            MsgBox("This login is Incorrect")
            Clear()
        End If
    End Sub
    Public Sub Clear()
        txt_Username.Text = ""
        txt_Password.Text = ""
    End Sub
End Class