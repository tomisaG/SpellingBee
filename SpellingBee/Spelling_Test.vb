Public Class Spelling_Test
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_start.Click
        Dim fullline As String = ""
        Dim first As String = ""
        Dim second As String = ""
        Dim Third As String = ""
        Dim searchstring As String = Console.ReadLine()
        Dim filesave As New List(Of String())
        FileOpen(1, "n:\Computing\Year 2\Spelling Bee\SpellingBee\SpellingBee\bin\Debug\Spelling_Create.csv", OpenMode.Input)
        Do Until EOF(1)
            fullline = LineInput(1)
            Dim item() As String = Split(fullline, ",")
            filesave.Add(item)


        Loop
        FileClose(1)
    End Sub

    Private Sub Spelling_Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_Defination.TextChanged

    End Sub

    Private Sub Cmd_Check_Click(sender As Object, e As EventArgs) Handles Cmd_Check.Click

    End Sub
    Private Sub cmd_answer_TextChanged(sender As Object, e As EventArgs) Handles cmd_answer.TextChanged

    End Sub
End Class