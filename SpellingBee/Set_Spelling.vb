Imports System.IO
Public Class Set_Spelling
    Dim SW As StreamWriter

    Private Sub Cmd_Sumbit_Click(sender As Object, e As EventArgs) Handles Cmd_Sumbit.Click

        FileOpen(1, "n:\Computing\Year 2\Spelling Bee\SpellingBee\SpellingBee\bin\Debug\Spelling_Create.csv", OpenMode.Append)
        Dim fullline As String
        'Do`

        fullline = txtDefinition.Text & "," & txtSpelling.Text
            PrintLine(1, FullLine)
        'Loop
        FileClose()
    End Sub

    Private Sub SFDWriter_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SFDWriter.FileOk
        Dim writestring(0) As String

        GC.Collect()
        System.IO.File.WriteAllLines(SFDWriter.FileName, writestring)
        GC.Collect()
    End Sub

    Private Sub Set_Spelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtDefinition_TextChanged(sender As Object, e As EventArgs) Handles txtDefinition.TextChanged

    End Sub
End Class
