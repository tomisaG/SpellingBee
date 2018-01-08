<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeachersLogin
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
		Me.txt_Username = New System.Windows.Forms.TextBox()
		Me.txt_Password = New System.Windows.Forms.TextBox()
		Me.txt_year = New System.Windows.Forms.TextBox()
		Me.sdjfabd = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.cmd_login = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'txt_Username
		'
		Me.txt_Username.Location = New System.Drawing.Point(172, 87)
		Me.txt_Username.Name = "txt_Username"
		Me.txt_Username.Size = New System.Drawing.Size(135, 20)
		Me.txt_Username.TabIndex = 5
		'
		'txt_Password
		'
		Me.txt_Password.Location = New System.Drawing.Point(172, 127)
		Me.txt_Password.Name = "txt_Password"
		Me.txt_Password.Size = New System.Drawing.Size(135, 20)
		Me.txt_Password.TabIndex = 7
		'
		'txt_year
		'
		Me.txt_year.Location = New System.Drawing.Point(172, 165)
		Me.txt_year.Name = "txt_year"
		Me.txt_year.Size = New System.Drawing.Size(135, 20)
		Me.txt_year.TabIndex = 8
		'
		'sdjfabd
		'
		Me.sdjfabd.AutoSize = True
		Me.sdjfabd.Location = New System.Drawing.Point(38, 90)
		Me.sdjfabd.Name = "sdjfabd"
		Me.sdjfabd.Size = New System.Drawing.Size(55, 13)
		Me.sdjfabd.TabIndex = 9
		Me.sdjfabd.Text = "Username"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(38, 206)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(0, 13)
		Me.Label1.TabIndex = 10
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(38, 172)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(29, 13)
		Me.Label2.TabIndex = 11
		Me.Label2.Text = "Year"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(38, 130)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(53, 13)
		Me.Label3.TabIndex = 12
		Me.Label3.Text = "Password"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(268, 160)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(0, 13)
		Me.Label4.TabIndex = 13
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(276, 168)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(0, 13)
		Me.Label5.TabIndex = 14
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(38, 36)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(84, 13)
		Me.Label6.TabIndex = 15
		Me.Label6.Text = "Teachers_Login"
		'
		'cmd_login
		'
		Me.cmd_login.Location = New System.Drawing.Point(324, 236)
		Me.cmd_login.Name = "cmd_login"
		Me.cmd_login.Size = New System.Drawing.Size(84, 36)
		Me.cmd_login.TabIndex = 16
		Me.cmd_login.Text = "Login"
		Me.cmd_login.UseVisualStyleBackColor = True
		'
		'TeachersLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(476, 327)
		Me.Controls.Add(Me.cmd_login)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.sdjfabd)
		Me.Controls.Add(Me.txt_year)
		Me.Controls.Add(Me.txt_Password)
		Me.Controls.Add(Me.txt_Username)
		Me.Name = "TeachersLogin"
		Me.Text = "TeachersLogin"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txt_Username As TextBox
	Friend WithEvents txt_Password As TextBox
	Friend WithEvents txt_year As TextBox
	Friend WithEvents sdjfabd As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents cmd_login As Button
End Class
