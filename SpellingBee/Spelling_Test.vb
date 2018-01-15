Imports System.IO

Public Class Spelling_Test
    Dim answer(100) As String
    Dim Definition(100) As String
    Dim wordCounter As Integer = 0
    Dim QuestionNumber As Integer = 1
    Dim x As Integer = 0
    Dim score As Integer
    Dim time As String
    Private DefWords As New List(Of String())
    Private DefWords_SIZE As Integer

    Public Sub RefreshDefWords()
        Dim indexLoop1 As Integer = 0
        Dim fileToCheck As New FileInfo("n:\Computing\Year 2\Spelling Bee\SpellingBee\SpellingBee\bin\Debug\Spelling_Create.csv")

        If (fileToCheck.Length <> DefWords_SIZE) Then
            FileOpen(1, "n:\Computing\Year 2\Spelling Bee\SpellingBee\SpellingBee\bin\Debug\Spelling_Create.csv", OpenMode.Input)
            Do Until EOF(1)

                'DefWords = Split(LineInput(1), ",") 'This will read the entire line and store 

                DefWords.Add(Split(LineInput(1), ",")) 'This will read the entire line and store 

                indexLoop1 += 1
            Loop
            DefWords_SIZE = fileToCheck.Length
            FileClose(1)
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_start.Click
        cmd_start.Text = "Continue"
        lbl_Question.Text = "Question " & QuestionNumber
        Dim fullline As String = ""
        Dim answer As String = ""
        Dim x As Integer = 0
        Dim Def As String
        RefreshDefWords()
        DefWords(wordCounter)(0) = Def
        Do Until x = 10
            txt_Defination.Text = Def
            x = x + 1
            wordCounter += 1
            Cmd_Check.Enabled = True
        Loop

    End Sub

    Private Sub Spelling_Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmd_Check.Enabled = False
        Dim fullline As String = ""
        FileOpen(1, "n:\Computing\Year 2\Spelling Bee\SpellingBee\SpellingBee\bin\Debug\Spelling_Create.csv", OpenMode.Input)
        Do Until EOF(1)
            fullline = LineInput(1)
            Dim item() As String = Split(fullline, ",")
            time = item(2)
        Loop
        FileClose(1)
        time = txt_DateSet.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_Defination.TextChanged

    End Sub

    Private Sub Cmd_Check_Click(sender As Object, e As EventArgs) Handles Cmd_Check.Click
        Dim fullWord As String
        Dim AllLetters(10) As String
        Dim AllInputs(10) As String
        RefreshDefWords()
        Dim LetterArray() As Char = DefWords(x)(1)
        Dim CharArray() As Char = txt_answer.Text
        For control = 0 To LetterArray.Length - 1
            AllLetters(control) = LetterArray(control)
        Next
        For Order = 0 To CharArray.Length - 1
            AllInputs(Order) = CharArray(Order)
        Next
        fullWord = DefWords(x)(1)
        If fullWord = txt_answer.Text Then
            MsgBox("Full Marks")
            score = score + 5
        Else score = score + 0
            MsgBox("No Marks")
            If AllInputs(0) = AllLetters(0) And AllInputs(1) = AllLetters(1) And AllInputs(2) = AllLetters(2) Then
                MsgBox("3 Marks")
                score = score + 3
            ElseIf DefWords(x).ToString = txt_answer.Text Then
                score = score - 2
            End If
            If DefWords(x).ToString <> txt_answer.Text Then
                score = score + 0
            End If
        End If

        x += 1
        Cmd_score.Text = score
        Cmd_Check.Enabled = False
        Clear()
    End Sub
    Sub Clear()
        txt_answer.Text = ""
    End Sub
End Class