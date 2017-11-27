<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherLogin
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sdjfabd = New System.Windows.Forms.Label()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_Teacher = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "T/S"
        '
        'sdjfabd
        '
        Me.sdjfabd.AutoSize = True
        Me.sdjfabd.Location = New System.Drawing.Point(29, 79)
        Me.sdjfabd.Name = "sdjfabd"
        Me.sdjfabd.Size = New System.Drawing.Size(55, 13)
        Me.sdjfabd.TabIndex = 3
        Me.sdjfabd.Text = "Username"
        '
        'txt_Username
        '
        Me.txt_Username.Location = New System.Drawing.Point(124, 79)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(135, 20)
        Me.txt_Username.TabIndex = 4
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(124, 117)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(135, 20)
        Me.txt_password.TabIndex = 5
        '
        'txt_Teacher
        '
        Me.txt_Teacher.Location = New System.Drawing.Point(124, 164)
        Me.txt_Teacher.Name = "txt_Teacher"
        Me.txt_Teacher.Size = New System.Drawing.Size(135, 20)
        Me.txt_Teacher.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Teacher_Login"
        '
        'cmd_login
        '
        Me.cmd_login.Location = New System.Drawing.Point(288, 214)
        Me.cmd_login.Name = "cmd_login"
        Me.cmd_login.Size = New System.Drawing.Size(84, 36)
        Me.cmd_login.TabIndex = 8
        Me.cmd_login.Text = "Login"
        Me.cmd_login.UseVisualStyleBackColor = True
        '
        'TeacherLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 262)
        Me.Controls.Add(Me.cmd_login)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Teacher)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.sdjfabd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "TeacherLogin"
        Me.Text = "TeacherLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents sdjfabd As Label
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_Teacher As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_login As Button
End Class
