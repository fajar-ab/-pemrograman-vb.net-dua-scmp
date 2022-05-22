Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim tinggi As Integer
        Dim alas As Integer

        Dim total As Integer

        tinggi = TextBox1.Text
        alas = TextBox2.Text

        total = tinggi * alas / 2

        MessageBox.Show(total, "HASIL", MessageBoxButtons.OK)


    End Sub
End Class
