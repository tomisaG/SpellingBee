<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbl_Login = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmd_Username = New System.Windows.Forms.TextBox()
        Me.Cmd_Password = New System.Windows.Forms.TextBox()
        Me.Cmd_Login = New System.Windows.Forms.Button()
        Me.Teacher_Login = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Login
        '
        Me.lbl_Login.AutoSize = True
        Me.lbl_Login.Location = New System.Drawing.Point(36, 112)
        Me.lbl_Login.Name = "lbl_Login"
        Me.lbl_Login.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Login.TabIndex = 0
        Me.lbl_Login.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Cmd_Username
        '
        Me.Cmd_Username.Location = New System.Drawing.Point(156, 112)
        Me.Cmd_Username.Name = "Cmd_Username"
        Me.Cmd_Username.Size = New System.Drawing.Size(146, 20)
        Me.Cmd_Username.TabIndex = 2
        '
        'Cmd_Password
        '
        Me.Cmd_Password.Location = New System.Drawing.Point(156, 160)
        Me.Cmd_Password.Name = "Cmd_Password"
        Me.Cmd_Password.Size = New System.Drawing.Size(146, 20)
        Me.Cmd_Password.TabIndex = 3
        '
        'Cmd_Login
        '
        Me.Cmd_Login.Location = New System.Drawing.Point(359, 280)
        Me.Cmd_Login.Name = "Cmd_Login"
        Me.Cmd_Login.Size = New System.Drawing.Size(75, 23)
        Me.Cmd_Login.TabIndex = 4
        Me.Cmd_Login.Text = "Login"
        Me.Cmd_Login.UseVisualStyleBackColor = True
        '
        'Teacher_Login
        '
        Me.Teacher_Login.AutoSize = True
        Me.Teacher_Login.Location = New System.Drawing.Point(36, 38)
        Me.Teacher_Login.Name = "Teacher_Login"
        Me.Teacher_Login.Size = New System.Drawing.Size(79, 13)
        Me.Teacher_Login.TabIndex = 5
        Me.Teacher_Login.Text = "Teacher_Login"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 332)
        Me.Controls.Add(Me.Teacher_Login)
        Me.Controls.Add(Me.Cmd_Login)
        Me.Controls.Add(Me.Cmd_Password)
        Me.Controls.Add(Me.Cmd_Username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_Login)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Login As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cmd_Username As TextBox
    Friend WithEvents Cmd_Password As TextBox
    Friend WithEvents Cmd_Login As Button
    Friend WithEvents Teacher_Login As Label
End Class
