Public Class TeachersLogin
	Dim password(100) As String
	Dim username(100) As String
	Private Sub TeachersLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub cmd_login_Click(sender As Object, e As EventArgs) Handles cmd_login.Click
		Dim x As Integer = 0
		Dim fullline As String = ""
		FileOpen(1, "n:\admin.csv", OpenMode.Input)
		Do Until EOF(1)
			fullline = LineInput(1)
			Dim item() As String = Split(fullline, ",")
			Password(x) = item(1)
			Username(x) = item(2)
			If txt_Username.Text = Username(x) And txt_Password.Text = Password(x) Then
				My.Forms.Set_Spelling.Text = Now.ToString
				My.Forms.Set_Spelling.Show()
			End If
		Loop
		FileClose(1)
	End Sub
End Class