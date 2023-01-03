Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim intNumber1 As Integer
        Dim intNumber2 As Integer
        Dim intAnswer As Integer

        intNumber1 = txtNumber1.Text
        intNumber2 = txtNumber2.Text
        intAnswer = intNumber1 + intNumber2

        lblAnswer.Text = intAnswer

    End Sub
End Class
