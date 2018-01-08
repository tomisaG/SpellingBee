Public Class Spelling_Test
	Dim answer(100) As String
	Dim Definition(100) As String
    Dim c As Integer = 0
    Dim x As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_start.Click
		cmd_start.Text = "Continue"
		lbl_Question.Text = "Question " & c
		Dim fullline As String = ""
		Dim answer As String = ""
		Dim time As String
		FileOpen(1, "n:\Computing\Year 2\Spelling Bee\SpellingBee\SpellingBee\bin\Debug\Spelling_Create.csv", OpenMode.Input)
		Do Until EOF(1)
			fullline = LineInput(1)
			Dim item() As String = Split(fullline, ",")
            Definition(x) = item(0)
            time = item(3)
			x += 1
		Loop
		FileClose(1)
		txt_Defination.Text = Definition(c)
		c += 1
	End Sub

	Private Sub Spelling_Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_Defination.TextChanged

    End Sub

    Private Sub Cmd_Check_Click(sender As Object, e As EventArgs) Handles Cmd_Check.Click
        Dim fullline As String = ""
        Dim words As String
        Dim ThreeLetters As String = ""
        Dim ThreeInputs As String = ""
        FileOpen(1, "n:\Computing\Year 2\Spelling Bee\SpellingBee\SpellingBee\bin\Debug\Spelling_Create.csv", OpenMode.Input)
		Do Until EOF(1)
            fullline = LineInput(1)
			Dim item() As String = Split(fullline, ",")
            answer(x) = item(1)
            x += 1
		Loop
        FileClose(1)

        Dim letters() = answer(c).ToCharArray()
        words = txt_answer.Text
        Dim inputs() = words.ToCharArray()

        For Orderletter = 2 To (letters.Length) - 1
            ThreeLetters = letters(Orderletter)
        Next
        For Orderinputs = 2 To (inputs.Length) - 1
            ThreeLetters = inputs(Orderinputs)
        Next

        If ThreeLetters = ThreeInputs Then
            MsgBox("3 Marks")
        Else
            MsgBox("incorrect")
		End If
		If txt_answer.Text = answer(c) Then
			MsgBox("5 Marks")
		Else
			MsgBox("3 Marks")
		End If
		c += 1
		Clear()
	End Sub
    Private Sub cmd_answer_TextChanged(sender As Object, e As EventArgs) Handles txt_answer.TextChanged

    End Sub

	Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txt_DateSet.TextChanged
		Dim fullline As String = ""
		Dim time As String
		FileOpen(1, "n:\Computing\Year 2\Spelling Bee\SpellingBee\SpellingBee\bin\Debug\Spelling_Create.csv", OpenMode.Input)
		Do Until EOF(1)
			fullline = LineInput(1)
			Dim item() As String = Split(fullline, ",")
			txt_Defination.Text = item(0)
			time = item(3)

		Loop
		FileClose(1)
		time = txt_DateSet.Text
	End Sub
	Sub Clear()
		txt_answer.Text = ""
	End Sub
End Class