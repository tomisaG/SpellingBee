Imports Microsoft.VisualBasic.FileIO
Public Class Set_Spelling
    Dim Database(1000) As IDataRecord
    Dim Filename As String = "database.txt"
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub TB_Defination_TextChanged(sender As Object, e As EventArgs) Handles TB_Defination.TextChanged

    End Sub

    Private Sub Cmd_Sumbit_Click(sender As Object, e As EventArgs) Handles Cmd_Sumbit.Click
        CreateCSV(Application.StartupPath & "")
    End Sub
    Private Sub ClearTextBox()
        TB_Defination.Text = ""
        TB_Spelling.Text = ""

    End Sub

    Private Sub Cmd_ShowCSV_Click(sender As Object, e As EventArgs) Handles Cmd_ShowCSV.Click

        Read.show()
    End Sub

    Private Sub Set_Spelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub writefile()
        Dim File As String = ""
        Dim FieldSeperator As String = ","
        Dim RecordSeperator As String = ";"
        For i As Integer = 0 To Database.Length - 1
            If ((Database(i).IsDBNull) <> False) Then

            End If

        Next
    End Sub
End Class