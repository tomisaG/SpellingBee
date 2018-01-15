
Public Class Student_Login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Username As String = ""
        Dim Password As String = ""
        Dim YearGroup As Integer = ""
        Dim Fullline As String = ""
        Dim Searchstring As String = Txt_Username.Text
        FileOpen(1, "n:\TomOye161$\Computing\Year 2\Spelling Bee\SpellingBee\SpellingBee\bin\Debug\Student_Details", OpenMode.Input)
        Do Until EOF(1)
            Fullline = LineInput(1)
            Dim item() As String = Split(Fullline, ",")
            If Searchstring = item(1) Then
                Username = item(1)
                Password = item(2)
                YearGroup = item(3)
            End If
        Loop
        If Txt_Username.Text = Username And txt_Password.Text = Password And YearGroup = YearGroup Then
            My.Forms.Login.Text = Now.ToString
            My.Forms.Spelling_Test.Show()
        Else
            MsgBox("This login is Incorrect")
            Clear()
        End If
    End Sub
    Public Sub Clear()
        Txt_Username.Text = ""
        txt_Password.Text = ""
    End Sub

    Private Sub Student_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class