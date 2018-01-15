Imports System.IO
Public Class Set_Spelling
    Dim SW As StreamWriter

    Private Sub Cmd_Sumbit_Click(sender As Object, e As EventArgs) Handles Cmd_Sumbit.Click
        Dim x As Integer = 0
        FileOpen(1, "n:\Computing\Year 2\Spelling Bee\SpellingBee\SpellingBee\bin\Debug\Spelling_Create.csv", OpenMode.Append)
        Dim time As String = cmd_Test.Value
        Dim timeDef As String = cmd_Definition.Value
        Dim fullline As String
        Do Until x = 1
            fullline = txtDefinition.Text & "," & time & "," & timeDef & "," & txt_YearGroup.Text
            PrintLine(1, fullline)
			x = x + 1
        Loop
        FileClose()
        Clear()
    End Sub
    Private Sub Clear()
        txtDefinition.Text = ""
        txtSpelling.Text = ""
    End Sub
    Private Sub Set_Spelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtSpelling_TextChanged(sender As Object, e As EventArgs) Handles txtSpelling.TextChanged

    End Sub
End Class
