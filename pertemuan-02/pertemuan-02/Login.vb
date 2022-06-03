Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub login()

        Dim username As String = inputUsername.Text
        Dim password As String = inputPassword.Text
        Dim str As String

        Call koneksi()

        str = $"SELECT * FROM tb_user WHERE username='{username}'"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            If password = rd.Item("password") Then
                Mahasiswa.Show()
            Else
                MessageBox.Show("password salah")
            End If
        Else
            MessageBox.Show("username tidak valid")
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call login()
    End Sub
End Class