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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNickname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblErrorN = New System.Windows.Forms.Label()
        Me.lblErrorEm = New System.Windows.Forms.Label()
        Me.lblErrorCP = New System.Windows.Forms.Label()
        Me.lblErrorDN = New System.Windows.Forms.Label()
        Me.lblErrorFN = New System.Windows.Forms.Label()
        Me.lblErrorNick = New System.Windows.Forms.Label()
        Me.lblErrorLn = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Create User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(180, 89)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(183, 20)
        Me.txtUser.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(180, 131)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(183, 20)
        Me.txtEmail.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Email"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(180, 174)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(183, 20)
        Me.txtPass.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password"
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New System.Drawing.Point(180, 223)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(183, 20)
        Me.txtConfirm.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Confirm Password"
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(180, 268)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(183, 20)
        Me.txtDisplay.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(97, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Display Name"
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(180, 320)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(183, 20)
        Me.txtFirst.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(97, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Name"
        '
        'txtNickname
        '
        Me.txtNickname.Location = New System.Drawing.Point(180, 370)
        Me.txtNickname.Name = "txtNickname"
        Me.txtNickname.Size = New System.Drawing.Size(183, 20)
        Me.txtNickname.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 370)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Nickname"
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(405, 320)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(183, 20)
        Me.txtLast.TabIndex = 15
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(268, 423)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(205, 37)
        Me.btnCreate.TabIndex = 16
        Me.btnCreate.Text = "CREATE AND ACCESS"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(177, 197)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 17
        '
        'lblErrorN
        '
        Me.lblErrorN.AutoSize = True
        Me.lblErrorN.ForeColor = System.Drawing.Color.Red
        Me.lblErrorN.Location = New System.Drawing.Point(177, 115)
        Me.lblErrorN.Name = "lblErrorN"
        Me.lblErrorN.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorN.TabIndex = 18
        '
        'lblErrorEm
        '
        Me.lblErrorEm.AutoSize = True
        Me.lblErrorEm.ForeColor = System.Drawing.Color.Red
        Me.lblErrorEm.Location = New System.Drawing.Point(177, 158)
        Me.lblErrorEm.Name = "lblErrorEm"
        Me.lblErrorEm.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorEm.TabIndex = 19
        '
        'lblErrorCP
        '
        Me.lblErrorCP.AutoSize = True
        Me.lblErrorCP.ForeColor = System.Drawing.Color.Red
        Me.lblErrorCP.Location = New System.Drawing.Point(177, 246)
        Me.lblErrorCP.Name = "lblErrorCP"
        Me.lblErrorCP.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorCP.TabIndex = 20
        '
        'lblErrorDN
        '
        Me.lblErrorDN.AutoSize = True
        Me.lblErrorDN.ForeColor = System.Drawing.Color.Red
        Me.lblErrorDN.Location = New System.Drawing.Point(177, 291)
        Me.lblErrorDN.Name = "lblErrorDN"
        Me.lblErrorDN.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorDN.TabIndex = 21
        '
        'lblErrorFN
        '
        Me.lblErrorFN.AutoSize = True
        Me.lblErrorFN.ForeColor = System.Drawing.Color.Red
        Me.lblErrorFN.Location = New System.Drawing.Point(177, 343)
        Me.lblErrorFN.Name = "lblErrorFN"
        Me.lblErrorFN.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorFN.TabIndex = 22
        '
        'lblErrorNick
        '
        Me.lblErrorNick.AutoSize = True
        Me.lblErrorNick.ForeColor = System.Drawing.Color.Red
        Me.lblErrorNick.Location = New System.Drawing.Point(177, 393)
        Me.lblErrorNick.Name = "lblErrorNick"
        Me.lblErrorNick.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorNick.TabIndex = 23
        '
        'lblErrorLn
        '
        Me.lblErrorLn.AutoSize = True
        Me.lblErrorLn.ForeColor = System.Drawing.Color.Red
        Me.lblErrorLn.Location = New System.Drawing.Point(402, 353)
        Me.lblErrorLn.Name = "lblErrorLn"
        Me.lblErrorLn.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorLn.TabIndex = 24
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(493, 115)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(199, 20)
        Me.DateTimePicker1.TabIndex = 25
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBirthday.Location = New System.Drawing.Point(493, 157)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(29, 13)
        Me.lblBirthday.TabIndex = 26
        Me.lblBirthday.Text = "label"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 472)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblErrorLn)
        Me.Controls.Add(Me.lblErrorNick)
        Me.Controls.Add(Me.lblErrorFN)
        Me.Controls.Add(Me.lblErrorDN)
        Me.Controls.Add(Me.lblErrorCP)
        Me.Controls.Add(Me.lblErrorEm)
        Me.Controls.Add(Me.lblErrorN)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtNickname)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNickname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtLast As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents lblError As Label
    Friend WithEvents lblErrorN As Label
    Friend WithEvents lblErrorEm As Label
    Friend WithEvents lblErrorCP As Label
    Friend WithEvents lblErrorDN As Label
    Friend WithEvents lblErrorFN As Label
    Friend WithEvents lblErrorNick As Label
    Friend WithEvents lblErrorLn As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblBirthday As Label
End Class
