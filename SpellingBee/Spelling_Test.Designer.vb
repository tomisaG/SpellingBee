<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Spelling_Test
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
        Me.txt_Defination = New System.Windows.Forms.TextBox()
        Me.cmd_start = New System.Windows.Forms.Button()
        Me.txt_answer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmd_Check = New System.Windows.Forms.Button()
        Me.txt_DateSet = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_Defination
        '
        Me.txt_Defination.Location = New System.Drawing.Point(112, 103)
        Me.txt_Defination.Name = "txt_Defination"
        Me.txt_Defination.Size = New System.Drawing.Size(209, 20)
        Me.txt_Defination.TabIndex = 0
        '
        'cmd_start
        '
        Me.cmd_start.Location = New System.Drawing.Point(339, 12)
        Me.cmd_start.Name = "cmd_start"
        Me.cmd_start.Size = New System.Drawing.Size(105, 40)
        Me.cmd_start.TabIndex = 1
        Me.cmd_start.Text = "Start"
        Me.cmd_start.UseVisualStyleBackColor = True
        '
        'txt_answer
        '
        Me.txt_answer.Location = New System.Drawing.Point(112, 164)
        Me.txt_answer.Name = "txt_answer"
        Me.txt_answer.Size = New System.Drawing.Size(209, 20)
        Me.txt_answer.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Defination"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Answer"
        '
        'Cmd_Check
        '
        Me.Cmd_Check.Location = New System.Drawing.Point(328, 305)
        Me.Cmd_Check.Name = "Cmd_Check"
        Me.Cmd_Check.Size = New System.Drawing.Size(105, 40)
        Me.Cmd_Check.TabIndex = 5
        Me.Cmd_Check.Text = "Check"
        Me.Cmd_Check.UseVisualStyleBackColor = True
        '
        'txt_DateSet
        '
        Me.txt_DateSet.Location = New System.Drawing.Point(112, 62)
        Me.txt_DateSet.Name = "txt_DateSet"
        Me.txt_DateSet.Size = New System.Drawing.Size(173, 20)
        Me.txt_DateSet.TabIndex = 6
        '
        'Spelling_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 405)
        Me.Controls.Add(Me.txt_DateSet)
        Me.Controls.Add(Me.Cmd_Check)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_answer)
        Me.Controls.Add(Me.cmd_start)
        Me.Controls.Add(Me.txt_Defination)
        Me.Name = "Spelling_Test"
        Me.Text = "Spelling_Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Defination As TextBox
    Friend WithEvents cmd_start As Button
    Friend WithEvents txt_answer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cmd_Check As Button
    Friend WithEvents txt_DateSet As TextBox
End Class
