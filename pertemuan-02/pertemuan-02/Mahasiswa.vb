Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Threading

Public Class Mahasiswa

    ' Load form
    Private Sub Mahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadTable()
    End Sub

    ' Mengatur tampilan Data Grid View
    Sub aturDGV()

        Try
            daftarMahasiswa.Columns(0).Width = 150
            daftarMahasiswa.Columns(1).Width = 250
            daftarMahasiswa.Columns(2).Width = 171

            daftarMahasiswa.Columns(0).HeaderText = "NIM"
            daftarMahasiswa.Columns(1).HeaderText = "NAMA MAHASISWA"
            daftarMahasiswa.Columns(2).HeaderText = "JENIS KELAMIN"
        Catch ex As Exception
        End Try

    End Sub

    ' Tampilkan data mahasiswa ke Data Grid View
    Sub tampilMahasiswa()

        Call koneksi()

        da = New MySqlDataAdapter("SELECT * FROM tb_mahasiswa", conn)
        ds = New DataSet
        da.Fill(ds, "mahasiswa")
        daftarMahasiswa.DataSource = ds.Tables("mahasiswa")

    End Sub

    ' Load table
    Sub loadTable()
        Call tampilMahasiswa()
        Call aturDGV()
    End Sub

    ' Clear textbox dan combobox
    Sub clear()
        nim.Enabled = True
        nim.Clear()
        nama.Clear()
        jenisKelamin.Text = ""
    End Sub

    ' Membuat textbox nama menjadi capital
    Function namaCapital() As String
        Dim cultureInfo As CultureInfo = Thread.CurrentThread.CurrentCulture
        Dim textInfo As TextInfo = cultureInfo.TextInfo

        Return textInfo.ToTitleCase(nama.Text)
    End Function

    ' Insert data kedalam database
    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Call koneksi()

        Try
            Dim str As String

            str = $"INSERT INTO tb_mahasiswa VALUES ('{nim.Text}', '{namaCapital()}', '{jenisKelamin.Text}')"
            cmd = New MySqlCommand(str, conn)
            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("Insert Data Mahasiswa Berhasil Dilakukan")
            Else
                Throw New System.Exception()
            End If

            Call clear()
            Call loadTable()

        Catch ex As Exception
            MessageBox.Show("Insert Data Mahasiswa Gagal Dilakukan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    ' Menampilkan data dari Grid View ke texbox dan combobox
    Private Sub daftarMahasiswa_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles daftarMahasiswa.CellMouseClick
        nim.Enabled = False
        nim.Text = daftarMahasiswa.Rows(e.RowIndex).Cells(0).Value
        nama.Text = daftarMahasiswa.Rows(e.RowIndex).Cells(1).Value
        jenisKelamin.Text = daftarMahasiswa.Rows(e.RowIndex).Cells(2).Value
    End Sub

    ' Ubah data mahasiswa
    Private Sub ubah_Click(sender As Object, e As EventArgs) Handles ubah.Click

        Call koneksi()

        Try
            Dim str As String

            str = $"UPDATE tb_mahasiswa set nama = '{namaCapital()}', jenis_kelamin = '{jenisKelamin.Text}' WHERE nim = '{nim.Text}'"
            cmd = New MySqlCommand(str, conn)
            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("Update Data Mahasiswa Berhasil Dilakukan")
            Else
                Throw New System.Exception()
            End If

            Call clear()
            Call loadTable()

        Catch ex As Exception
            MessageBox.Show("Update Data Mahasiswa Gagal Dilakukan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    ' Hapus data mahasiswa
    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click

        Call koneksi()

        Try
            Dim str As String

            str = $"DELETE FROM tb_mahasiswa WHERE nim = '{nim.Text}'"
            cmd = New MySqlCommand(str, conn)
            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("Data Mahasiswa Berhasil Dihapus")
            Else
                Throw New System.Exception()
            End If

            Call clear()
            Call loadTable()

        Catch ex As Exception
            MessageBox.Show("Data Mahasiswa Gagal Dihapus", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub
End Class
