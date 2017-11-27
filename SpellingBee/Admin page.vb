Public Class Admin_page
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fullline As String = ""
        FileOpen(1, "n:\Admin.csv", OpenMode.Append)
        Dim Name As String = txt_Name.Text
        Dim Username As String = txt_Username.Text
        Dim password As String = txt_Password.Text
        Dim Year As Integer = txt_year.Text
        Dim TS As String = txt_TS.Text

        fullline = Name & "," & Username & "," & password & "," & Year & "," & TS
        PrintLine(1, fullline)

        FileClose(1)
        Clearbox()

    End Sub
    Private Sub Clearbox()
        txt_Name.Text = ""
        txt_Username.Text = ""
        txt_Password.Text = ""
        txt_year.Text = ""
        txt_TS.Text = ""
    End Sub
    Private Sub Admin_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class