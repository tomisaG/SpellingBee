<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Set_Spelling
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_Spelling = New System.Windows.Forms.TextBox()
        Me.Cmd_Sumbit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Defination = New System.Windows.Forms.TextBox()
        Me.Cmd_ShowCSV = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Set Spelling"
        '
        'TB_Spelling
        '
        Me.TB_Spelling.Location = New System.Drawing.Point(143, 122)
        Me.TB_Spelling.Name = "TB_Spelling"
        Me.TB_Spelling.Size = New System.Drawing.Size(129, 20)
        Me.TB_Spelling.TabIndex = 1
        '
        'Cmd_Sumbit
        '
        Me.Cmd_Sumbit.Location = New System.Drawing.Point(374, 294)
        Me.Cmd_Sumbit.Name = "Cmd_Sumbit"
        Me.Cmd_Sumbit.Size = New System.Drawing.Size(110, 32)
        Me.Cmd_Sumbit.TabIndex = 2
        Me.Cmd_Sumbit.Text = "Submit"
        Me.Cmd_Sumbit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date Set"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(143, 161)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Defination"
        '
        'TB_Defination
        '
        Me.TB_Defination.Location = New System.Drawing.Point(143, 76)
        Me.TB_Defination.Name = "TB_Defination"
        Me.TB_Defination.Size = New System.Drawing.Size(129, 20)
        Me.TB_Defination.TabIndex = 6
        '
        'Cmd_ShowCSV
        '
        Me.Cmd_ShowCSV.Location = New System.Drawing.Point(12, 294)
        Me.Cmd_ShowCSV.Name = "Cmd_ShowCSV"
        Me.Cmd_ShowCSV.Size = New System.Drawing.Size(110, 32)
        Me.Cmd_ShowCSV.TabIndex = 7
        Me.Cmd_ShowCSV.Text = "Show CSV"
        Me.Cmd_ShowCSV.UseVisualStyleBackColor = True
        '
        'Set_Spelling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 348)
        Me.Controls.Add(Me.Cmd_ShowCSV)
        Me.Controls.Add(Me.TB_Defination)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cmd_Sumbit)
        Me.Controls.Add(Me.TB_Spelling)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Set_Spelling"
        Me.Text = "Set_Spelling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TB_Spelling As TextBox
    Friend WithEvents Cmd_Sumbit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_Defination As TextBox
    Friend WithEvents Cmd_ShowCSV As Button
End Class
