Public Class Spelling_Bee
    Private Sub Spelling_Bee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fullline As String
        FileOpen(1, "n:\Computing\Year 2\Spelling Bee\SpellingBee\SpellingBee\bin\Debug\Spelling_Create.csv", OpenMode.Append)
        'Opens the file
        Do Until EOF(1)
            fullline = LineInput(1)
            Dim item() As String = Split(fullline, ",")
            'Splits the blocks

        Loop

    End Sub
End Class