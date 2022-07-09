Imports MySql.Data.MySqlClient

Public Class MataKuliah

    Private Sub MataKuliah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadTable()
    End Sub

    Sub aturDGV()
        Try
            DataMatakuliah.Columns(0).Width = 150
            DataMatakuliah.Columns(1).Width = 150
            DataMatakuliah.Columns(2).Width = 150
            DataMatakuliah.Columns(3).Width = 150
            DataMatakuliah.Columns(4).Width = 150
            DataMatakuliah.Columns(5).Width = 150

            DataMatakuliah.Columns(0).HeaderText = "KODE"
            DataMatakuliah.Columns(1).HeaderText = "NAMA"
            DataMatakuliah.Columns(2).HeaderText = "DOSEN"
            DataMatakuliah.Columns(3).HeaderText = "RUANGAN"
            DataMatakuliah.Columns(4).HeaderText = "SKS"
            DataMatakuliah.Columns(5).HeaderText = "SEMESTER"
        Catch ex As Exception
        End Try
    End Sub

    ' Tampilkan data matakuliah ke Data Grid View
    Sub tampilMatakuliah()

        Call Koneksi()

        da = New MySqlDataAdapter("SELECT * FROM tb_mata_kuliah", conn)
        ds = New DataSet
        da.Fill(ds, "matakuliah")
        DataMatakuliah.DataSource = ds.Tables("matakuliah")

    End Sub

    ' Load table
    Sub loadTable()
        Call tampilMatakuliah()
        Call aturDGV()
    End Sub

    ' clear text box
    Sub clear()

        kodeMatakuliah.Enabled = True
        namaMatakuliah.Enabled = True

        kodeMatakuliah.Clear()
        namaMatakuliah.Clear()
        dosen.Clear()
        ruangan.Text = ""
        sks.Clear()
        semester.Clear()
    End Sub

    ' simpan data mata kuliah
    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click

        Call Koneksi()
        Try
            Dim str As String

            str = $"
                INSERT INTO 
                `tb_mata_kuliah` (`id_mata_kuliah`, `nama`, `dosen`, `ruangan`, `sks`, `semester`) 
                VALUES (
                    '{kodeMatakuliah.Text}',
                    '{namaMatakuliah.Text}',
                    '{dosen.Text}',
                    '{ruangan.SelectedItem}',
                    '{sks.Text}',
                    '{semester.Text}'
                )"

            cmd = New MySqlCommand(str, conn)
            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("Insert Data Matakuliah Berhasil Dilakukan")
            Else
                Throw New System.Exception()
            End If

            Call clear()
            Call loadTable()

        Catch ex As Exception
            MessageBox.Show("Insert Data Matakuliah Gagal Dilakukan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
    End Sub

    ' Menampilkan data dari Grid View ke texbox dan combobox
    Private Sub DataMatakuliah_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataMatakuliah.CellContentClick
        kodeMatakuliah.Enabled = False
        namaMatakuliah.Enabled = False

        kodeMatakuliah.Text = DataMatakuliah.Rows(e.RowIndex).Cells(0).Value
        namaMatakuliah.Text = DataMatakuliah.Rows(e.RowIndex).Cells(1).Value
        dosen.Text = DataMatakuliah.Rows(e.RowIndex).Cells(2).Value
        ruangan.Text = DataMatakuliah.Rows(e.RowIndex).Cells(3).Value
        sks.Text = DataMatakuliah.Rows(e.RowIndex).Cells(4).Value
        semester.Text = DataMatakuliah.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub ubah_Click(sender As Object, e As EventArgs) Handles ubah.Click
        Call Koneksi()

        Try
            Dim str As String

            str = $"
                UPDATE `tb_mata_kuliah` 
                SET 
                    `dosen` = '{dosen.Text}', 
                    `ruangan` = '{ruangan.SelectedItem}', 
                    `sks` = '{sks.Text}',
                    `semester` = '{semester.Text}'
                    WHERE `tb_mata_kuliah`.`id_mata_kuliah` = '{kodeMatakuliah.Text}'"

            cmd = New MySqlCommand(str, conn)
            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("Update Data Matakuliah Berhasil Dilakukan")
            Else
                Throw New System.Exception()
            End If

            Call clear()
            Call loadTable()

        Catch ex As Exception
            MessageBox.Show("Update Data Matakuliah Gagal Dilakukan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Call Koneksi()

        Try
            Dim str As String

            str = $"DELETE FROM `tb_mata_kuliah` WHERE `tb_mata_kuliah`.`id_mata_kuliah` = '{kodeMatakuliah.Text}'"

            cmd = New MySqlCommand(str, conn)
            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("Data Matakuliah Berhasil Dihapus")
            Else
                Throw New System.Exception()
            End If

            Call clear()
            Call loadTable()

        Catch ex As Exception
            MessageBox.Show("Data Matakuliah Gagal Dihapus", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class