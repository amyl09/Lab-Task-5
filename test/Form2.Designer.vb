<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName1 = New System.Windows.Forms.TextBox()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(235, 57)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(137, 33)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(378, 57)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 33)
        Me.lblName.TabIndex = 1
        '
        'txtName1
        '
        Me.txtName1.Location = New System.Drawing.Point(233, 127)
        Me.txtName1.Name = "txtName1"
        Me.txtName1.ReadOnly = True
        Me.txtName1.Size = New System.Drawing.Size(156, 20)
        Me.txtName1.TabIndex = 2
        '
        'btnClick
        '
        Me.btnClick.Location = New System.Drawing.Point(308, 168)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(81, 28)
        Me.btnClick.TabIndex = 3
        Me.btnClick.Text = "Click here"
        Me.btnClick.UseVisualStyleBackColor = True
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(409, 127)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.ReadOnly = True
        Me.txtlastname.Size = New System.Drawing.Size(156, 20)
        Me.txtlastname.TabIndex = 4
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.Location = New System.Drawing.Point(201, 227)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(0, 33)
        Me.lblFirst.TabIndex = 5
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast.Location = New System.Drawing.Point(353, 227)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(0, 33)
        Me.lblLast.TabIndex = 6
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 467)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.btnClick)
        Me.Controls.Add(Me.txtName1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName1 As TextBox
    Friend WithEvents btnClick As Button
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblLast As Label
End Class
