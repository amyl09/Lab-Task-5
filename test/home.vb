Public Class home
    'AMYLIANA DARA
    '20DDT21F2006

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'displayed the name that user enter
            lblName.Text = UCase(login.name1 + "!")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        'will go to login form
        login.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'exit the app
        Application.Exit()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'will go to sports form
        sport.Show()
        Me.Hide()
    End Sub
End Class