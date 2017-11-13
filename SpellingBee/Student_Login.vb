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
        Do Until Txt_Username.Text = Username(x) And txt_Password.Text = Password(x)
            If Txt_Username.Text = Username(x) And txt_Password.Text = Password(x) Then
                MsgBox("This is correct")
            Else
                MsgBox("This is incorrect")
            End If
        Loop
    End Sub

End Class