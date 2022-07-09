Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadTable()
        Call comboBoxMataKuliah()

    End Sub

    Sub comboBoxMataKuliah()
        Call Koneksi()

        Try
            Dim str As String
            str = $"SELECT nama FROM `tb_mata_kuliah`"
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            While rd.Read
                Dim nama = rd.GetString("nama")
                mtk.Items.Add(nama)
            End While

        Catch ex As Exception

        Finally
            rd.Close()
        End Try


    End Sub

    Function getIdMatakuliah()
        Call Koneksi()

        Try
            Dim str As String
            str = $"SELECT id_mata_kuliah FROM tb_mata_kuliah WHERE nama = '{mtk.SelectedItem}'"
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()

            Return rd.GetString("id_mata_kuliah")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            rd.Close()
        End Try
    End Function

    Sub aturDGV()
        Try
            DataJadwal.Columns(0).Width = 150
            DataJadwal.Columns(1).Width = 200
            DataJadwal.Columns(2).Width = 150
            DataJadwal.Columns(3).Width = 150
            DataJadwal.Columns(4).Width = 150

            DataJadwal.Columns(0).HeaderText = "HARI"
            DataJadwal.Columns(1).HeaderText = "MATA KULIAH"
            DataJadwal.Columns(2).HeaderText = "PUKUL"
            DataJadwal.Columns(3).HeaderText = "RUANGAN"
            DataJadwal.Columns(4).HeaderText = "DOSEN"
        Catch ex As Exception
        End Try
    End Sub

    ' Tampilkan data jadawal ke Data Grid View
    Sub tampilJadwal()

        Call Koneksi()
        Dim str As String

        str = "SELECT j.hari, m.nama, j.pukul, m.ruangan, m.dosen
                FROM tb_jadwal AS j
                JOIN tb_mata_kuliah AS m ON (j.id_mata_kuliah = m.id_mata_kuliah)
                ORDER BY j.hari, j.pukul
                "

        da = New MySqlDataAdapter(str, conn)
        ds = New DataSet
        da.Fill(ds, "jadwal")
        DataJadwal.DataSource = ds.Tables("jadwal")

    End Sub

    ' Load table
    Sub loadTable()
        Call tampilJadwal()
        Call aturDGV()
    End Sub

    Sub clear()

        mtk.Enabled = True
        simpan.Enabled = True

        hari.Text = ""
        mtk.Text = ""
        pukul.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MataKuliah.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Call Koneksi()
        Dim idMataKuliah = getIdMatakuliah()

        Try
            Dim str As String

            str = $"INSERT INTO 
                    `tb_jadwal` (`id_jadwal`, `hari`, `id_mata_kuliah`, `pukul`) 
                    VALUES (NULL, '{hari.SelectedItem}', '{idMataKuliah}', '{pukul.Text}');"
            cmd = New MySqlCommand(str, conn)
            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("Insert Data Jadwal Berhasil Dilakukan")
            Else
                Throw New System.Exception()
            End If

            Call clear()
            Call loadTable()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataJadwal_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataJadwal.CellMouseClick
        mtk.Enabled = False
        simpan.Enabled = False

        hari.Text = DataJadwal.Rows(e.RowIndex).Cells(0).Value
        mtk.Text = DataJadwal.Rows(e.RowIndex).Cells(1).Value
        pukul.Text = DataJadwal.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ubah.Click
        Call Koneksi()
        Dim idMatakul = getIdMatakuliah()

        Try
            Dim str As String

            str = $"
                UPDATE `tb_jadwal` 
                    SET 
                `hari` = '{hari.SelectedItem}', 
                `pukul` = '{pukul.Text}' 
                WHERE `tb_jadwal`.`id_mata_kuliah` = '{idMatakul}'"

            cmd = New MySqlCommand(str, conn)
            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("Update Data Jadwal Berhasil Dilakukan")
            Else
                Throw New System.Exception()
            End If

            Call clear()
            Call loadTable()

        Catch ex As Exception
            MessageBox.Show("Update Jadwal Gagal Dilakukan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Call Koneksi()
        Dim idMatakul = getIdMatakuliah()
        Try
            Dim str As String

            str = $"DELETE FROM `tb_jadwal` WHERE `tb_jadwal`.`id_mata_kuliah` = '{idMatakul}'"

            cmd = New MySqlCommand(str, conn)
            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("Data Jadwal Berhasil Dihapus")
            Else
                Throw New System.Exception()
            End If

            Call clear()
            Call loadTable()

        Catch ex As Exception
            MessageBox.Show("Data Jadwal Gagal Dihapus", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class
