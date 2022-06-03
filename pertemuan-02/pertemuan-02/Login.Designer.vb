<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.inputUsername = New System.Windows.Forms.TextBox()
        Me.inputPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'inputUsername
        '
        Me.inputUsername.Location = New System.Drawing.Point(63, 110)
        Me.inputUsername.Name = "inputUsername"
        Me.inputUsername.Size = New System.Drawing.Size(274, 23)
        Me.inputUsername.TabIndex = 1
        '
        'inputPassword
        '
        Me.inputPassword.Location = New System.Drawing.Point(63, 166)
        Me.inputPassword.Name = "inputPassword"
        Me.inputPassword.Size = New System.Drawing.Size(274, 23)
        Me.inputPassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(161, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 310)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.inputPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.inputUsername)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents inputUsername As TextBox
    Friend WithEvents inputPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
