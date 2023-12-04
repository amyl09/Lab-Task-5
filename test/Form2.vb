Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = Form1.nameX
        'lblFirst.Text = Form1.first
        'lblLast.Text = Form1.last
        txtName1.Text = Form1.first
        txtlastname.Text = Form1.last
    End Sub

    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click

    End Sub
End Class