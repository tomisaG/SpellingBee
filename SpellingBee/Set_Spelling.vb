Imports Microsoft.VisualBasic.FileIO
Public Class Set_Spelling
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub CreateCSV(ByVal _Definition As String, ByVal _SetSpelling As String)
        Try
            Dim stline As String = ""
            Dim objectWriter As IO.StreamWriter = IO.File.AppendText("C:\\ TomOye161$ \ Computing \ Year 2\Spelling Bee\SpellingBee\SpellingBee\bin\Debug\Spelling_Create.csv")
            If IO.File.Exists("C:\\ TomOye161$ \ Computing \ Year 2\Spelling Bee\SpellingBee\SpellingBee\bin\Debug\Spelling_Create.csv") Then
                objectWriter.Write(_Definition & ",")
                objectWriter.Write(_SetSpelling & ",")
                objectWriter.Write(Environment.NewLine)
                stline = String.Format("{0}{1}," stline(), append)
                objectWriter.Write(stline)
            End If
            objectWriter.Close()
            ClearTextBox()
        Catch ex As Exception
        End Try
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
End Class