Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt64(TextBox3.Text)

        If a > b And a > c Then GoTo a_mayor
        If b > a And b > c Then GoTo b_mayor
        If c > a And c > b Then GoTo c_mayor
a_mayor:
        TextBox4.Text = "a es mayor"
        GoTo final
b_mayor:
        TextBox4.Text = "b es mayor"
        GoTo final
c_mayor:
        TextBox4.Text = "c es mayor"
        GoTo final
final:

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
