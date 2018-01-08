<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherCheck
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
		Me.Button2 = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Col_Definition = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Col_Spelling = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Col_Year = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.cmd_check = New System.Windows.Forms.Button()
		Me.Col_Definition_Set = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.col_Test_Set = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(206, 268)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(93, 49)
		Me.Button2.TabIndex = 1
		Me.Button2.Text = "Confirm"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Definition, Me.Col_Spelling, Me.Col_Year, Me.Col_Definition_Set, Me.col_Test_Set})
		Me.DataGridView1.Location = New System.Drawing.Point(49, 12)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(395, 235)
		Me.DataGridView1.TabIndex = 2
		'
		'Col_Definition
		'
		Me.Col_Definition.HeaderText = "Definition"
		Me.Col_Definition.Name = "Col_Definition"
		'
		'Col_Spelling
		'
		Me.Col_Spelling.HeaderText = "Spelling"
		Me.Col_Spelling.Name = "Col_Spelling"
		'
		'Col_Year
		'
		Me.Col_Year.HeaderText = "Year"
		Me.Col_Year.Name = "Col_Year"
		'
		'cmd_check
		'
		Me.cmd_check.Location = New System.Drawing.Point(60, 268)
		Me.cmd_check.Name = "cmd_check"
		Me.cmd_check.Size = New System.Drawing.Size(93, 49)
		Me.cmd_check.TabIndex = 3
		Me.cmd_check.Text = "Check"
		Me.cmd_check.UseVisualStyleBackColor = True
		'
		'Col_Definition_Set
		'
		Me.Col_Definition_Set.HeaderText = "Definition Set"
		Me.Col_Definition_Set.Name = "Col_Definition_Set"
		'
		'col_Test_Set
		'
		Me.col_Test_Set.HeaderText = "Test_Set"
		Me.col_Test_Set.Name = "col_Test_Set"
		'
		'TeacherCheck
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(498, 358)
		Me.Controls.Add(Me.cmd_check)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Button2)
		Me.Name = "TeacherCheck"
		Me.Text = "TeacherCheck"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Button2 As Button
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents cmd_check As Button
	Friend WithEvents Col_Definition As DataGridViewTextBoxColumn
	Friend WithEvents Col_Spelling As DataGridViewTextBoxColumn
	Friend WithEvents Col_Year As DataGridViewTextBoxColumn
	Friend WithEvents Col_Definition_Set As DataGridViewTextBoxColumn
	Friend WithEvents col_Test_Set As DataGridViewTextBoxColumn
End Class
