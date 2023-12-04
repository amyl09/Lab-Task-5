Public Class Form1
    Public nameX As String

    Public first As String
    Public last As String

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim num As Integer
        Dim pass As String
        pass = txtPass.Text
        num = pass.Length 'kira aksara
        Dim temp = pass.Trim 'buang space bar
        Dim tempNum As Integer = temp
        '  MsgBox("char" & num & 'kira character yg dimasukan termasuk space
        '      " char" & tempNum) 'display balik input tanpa space 
        If num < 8 Then
            lblError.Text = "Please enter a password more than 8 characters"
        Else
            nameX = txtUser.Text.Remove(4)
            'Form2.Show()
            'Me.Hide()

        End If

        'If num < 8 Then
        '    MsgBox("Please enter a password more than 8 characters", MessageBoxIcon.Error)
        'Else
        '    Form2.Show()
        '    Me.Hide()

        'End If

        'password
        Dim firstnname As String = txtFirst.Text
        first = txtFirst.Text.Insert(0, "Ms. ")
        Dim lastname As String = txtFirst.Text
        last = txtLast.Text.Insert(0, "")

        'phone
        'Dim phone As String = ""
        'phone = InputBox("Enter phone number starts with 082", phone)
        'If phone.Contains("082") Then
        '    MsgBox("Yes, your phone number is correct!")
        'Else
        '    MsgBox("Enter Again!")
        '    phone = InputBox("Enter phone number starts with 082", phone)
        'End If

        lblBirthday.Text = DateTimePicker1.Value
        Form2.Show()

    End Sub



    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        Dim currentYear As Int16 = System.DateTime.Now.Year
        Dim tempYear As String = CStr(lblBirthday.Text)
        Dim tempVal = tempYear.Substring(5, 4)
        If currentYear - Val(tempVal) < 18 Then
            MsgBox("x cukup umur")
        Else
            MsgBox("layak mendaftar")
        End If
    End Sub
End Class
