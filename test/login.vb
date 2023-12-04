'AMYLIANA DARA
'20DDT21F2006

Public Class login
    Public name1 As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim pass As String
            pass = txtPass.Text.Trim 'trim = remove the space
            Dim num As Integer
            num = pass.Length 'length = count the length
            Dim user As String
            user = txtUsername.Text
            Dim num2 As Integer
            num2 = user.Length

            If num < 8 And num2 < 6 Then
                'display the error
                lblErrorPass.Text = "Please enter password more than 8 characters"

                'display the error
                lblErrorUser.Text = "Please enter at least 6 characters of username"
            ElseIf num < 8 Then
                'display the error
                lblErrorPass.Text = "Please enter password more than 8 characters"

                'clear the error labels
                lblErrorUser.Text = ""
            ElseIf num2 < 6 Then
                'display the error
                lblErrorUser.Text = "Please enter at least 6 characters of username"

                'clear the error labels
                lblErrorPass.Text = ""
            Else
                'clear the error labels
                lblErrorUser.Text = ""
                lblErrorPass.Text = ""

                '' Remove first 4 characters from txtUsername.Text and insert "Ms. " at the beginning, assign the result to name1.
                name1 = txtUsername.Text.Remove(4).Insert(0, "Ms. ")

                'open home form
                home.Show()
                Me.Hide()

            End If
        Catch ex As Exception
            'Display the error message in a message box.
            MsgBox("ex.Message")
        End Try
    End Sub

    Private Sub CheckBoxPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPass.CheckedChanged
        Try
            'if the checkbox is checked then the password will be shown
            If CheckBoxPass.Checked = True Then
                txtPass.UseSystemPasswordChar = True
            Else
                'if the checkbox is unchecked then the password will not be shown
                txtPass.UseSystemPasswordChar = False
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class