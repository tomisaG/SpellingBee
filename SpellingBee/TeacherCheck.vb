Imports System.IO
Imports System.Text
Public Class TeacherCheck
	Dim names(100) As String
	Dim x As Integer = 0
	Private Sub cmd_check_Click(sender As Object, e As EventArgs) Handles cmd_check.Click
        Dim filename As String = "\\file-home1\TomOye161$\Computing\Year 2\Spelling Bee\SpellingBee\SpellingBee\bin\Debug\Student_Results.csv"
        Dim reader As New StreamReader(filename, Encoding.Default)
		Dim fullline As String = ""
		Do
			fullline = reader.ReadLine
			If fullline Is Nothing Then Exit Do
			Dim parts() As String = fullline.Split(",")
			names(x) = parts(0)
			x += 1
			DataGridView1.Rows.Add("")
			For counter As Integer = 0 To 4
				DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(counter).Value = parts(counter)
			Next
		Loop
		cmd_check.Visible = False
		reader.Close()

	End Sub

	Private Sub TeacherCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

End Class