Public Class TeacherLogin
    Private Sub TeacherLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub cmd_login_Click(sender As Object, e As EventArgs) Handles cmd_login.Click
        Dim fullline As String = ""
        FileOpen(1, "n:\Admin.csv", OpenMode.Input)

    End Sub
End Class