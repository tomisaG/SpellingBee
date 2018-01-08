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
		Me.txtSpelling = New System.Windows.Forms.TextBox()
		Me.Cmd_Sumbit = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.cmd_Test = New System.Windows.Forms.DateTimePicker()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtDefinition = New System.Windows.Forms.TextBox()
		Me.SFDWriter = New System.Windows.Forms.SaveFileDialog()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.cmd_Definition = New System.Windows.Forms.DateTimePicker()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txt_YearGroup = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(50, 138)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(63, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Set Spelling"
		'
		'txtSpelling
		'
		Me.txtSpelling.Location = New System.Drawing.Point(143, 135)
		Me.txtSpelling.Name = "txtSpelling"
		Me.txtSpelling.Size = New System.Drawing.Size(129, 20)
		Me.txtSpelling.TabIndex = 1
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
		Me.Label2.Location = New System.Drawing.Point(56, 216)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(45, 13)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Test set"
		'
		'cmd_Test
		'
		Me.cmd_Test.Location = New System.Drawing.Point(143, 210)
		Me.cmd_Test.Name = "cmd_Test"
		Me.cmd_Test.Size = New System.Drawing.Size(200, 20)
		Me.cmd_Test.TabIndex = 4
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(50, 101)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(55, 13)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Defination"
		'
		'txtDefinition
		'
		Me.txtDefinition.Location = New System.Drawing.Point(143, 98)
		Me.txtDefinition.Name = "txtDefinition"
		Me.txtDefinition.Size = New System.Drawing.Size(129, 20)
		Me.txtDefinition.TabIndex = 6
		'
		'SFDWriter
		'
		Me.SFDWriter.Filter = "CSV Files|*.csv"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(56, 157)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(0, 13)
		Me.Label4.TabIndex = 7
		'
		'cmd_Definition
		'
		Me.cmd_Definition.Location = New System.Drawing.Point(143, 173)
		Me.cmd_Definition.Name = "cmd_Definition"
		Me.cmd_Definition.Size = New System.Drawing.Size(200, 20)
		Me.cmd_Definition.TabIndex = 8
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(56, 179)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(70, 13)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Definition Set"
		'
		'txt_YearGroup
		'
		Me.txt_YearGroup.Location = New System.Drawing.Point(143, 236)
		Me.txt_YearGroup.Name = "txt_YearGroup"
		Me.txt_YearGroup.Size = New System.Drawing.Size(129, 20)
		Me.txt_YearGroup.TabIndex = 10
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(60, 239)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(61, 13)
		Me.Label6.TabIndex = 11
		Me.Label6.Text = "Year Group"
		'
		'Set_Spelling
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(496, 348)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txt_YearGroup)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.cmd_Definition)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtDefinition)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.cmd_Test)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Cmd_Sumbit)
		Me.Controls.Add(Me.txtSpelling)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Set_Spelling"
		Me.Text = "Set_Spelling"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents txtSpelling As TextBox
    Friend WithEvents Cmd_Sumbit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmd_Test As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDefinition As TextBox
    Friend WithEvents SFDWriter As SaveFileDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents cmd_Definition As DateTimePicker
    Friend WithEvents Label5 As Label
	Friend WithEvents txt_YearGroup As TextBox
	Friend WithEvents Label6 As Label
End Class
