Public Class Student_Login
    Dim Username(100) As String
    Dim Password(100) As String
    Private Sub Student_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As Integer = 0
        Dim fullline As String = ""
        FileOpen(1, "n:\admin.csv", OpenMode.Input)
        Do Until EOF(1)
            fullline = LineInput(1)
            Dim item() As String = Split(fullline, ",")
            Password(x) = item(1)
            Username(x) = item(2)
        Loop
        Do Until x = 1
            If Txt_Username.Text = Username(x) And txt_Password.Text = Password(x) Then
                My.Forms.Set_Spelling.Text = Now.ToString
                My.Forms.Set_Spelling.Show()
            Else
                x = 1
            End If
        Loop
        FileClose(1)
    End Sub

End Class