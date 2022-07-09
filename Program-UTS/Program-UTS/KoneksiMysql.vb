Imports MySql.Data.MySqlClient

Module KoneksiMysql

    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String

    Sub Koneksi()

        Try

            Dim str As String = "Server=localhost;user id=root; password=; database=crud_uts"
            conn = New MySqlConnection(str)

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Koneksi ke Database Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Module
