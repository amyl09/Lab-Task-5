<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.lblErrorUser = New System.Windows.Forms.Label()
        Me.lblErrorPass = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.CheckBoxPass = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(38, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'lblErrorUser
        '
        Me.lblErrorUser.AutoSize = True
        Me.lblErrorUser.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorUser.ForeColor = System.Drawing.Color.Red
        Me.lblErrorUser.Location = New System.Drawing.Point(38, 171)
        Me.lblErrorUser.Name = "lblErrorUser"
        Me.lblErrorUser.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorUser.TabIndex = 3
        '
        'lblErrorPass
        '
        Me.lblErrorPass.AutoSize = True
        Me.lblErrorPass.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorPass.ForeColor = System.Drawing.Color.Red
        Me.lblErrorPass.Location = New System.Drawing.Point(38, 268)
        Me.lblErrorPass.Name = "lblErrorPass"
        Me.lblErrorPass.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorPass.TabIndex = 4
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Gainsboro
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Maroon
        Me.btnLogin.Location = New System.Drawing.Point(70, 342)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(85, 37)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(41, 142)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(150, 26)
        Me.txtUsername.TabIndex = 7
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(41, 236)
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(149, 29)
        Me.txtPass.TabIndex = 8
        '
        'CheckBoxPass
        '
        Me.CheckBoxPass.AutoSize = True
        Me.CheckBoxPass.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CheckBoxPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxPass.ForeColor = System.Drawing.Color.White
        Me.CheckBoxPass.Location = New System.Drawing.Point(41, 296)
        Me.CheckBoxPass.Name = "CheckBoxPass"
        Me.CheckBoxPass.Size = New System.Drawing.Size(114, 17)
        Me.CheckBoxPass.TabIndex = 9
        Me.CheckBoxPass.Text = "Show password"
        Me.CheckBoxPass.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.test.My.Resources.Resources.Hypocross_Sport
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(605, 405)
        Me.Controls.Add(Me.CheckBoxPass)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblErrorPass)
        Me.Controls.Add(Me.lblErrorUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.Name = "login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblErrorUser As Label
    Friend WithEvents lblErrorPass As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents CheckBoxPass As CheckBox
End Class
