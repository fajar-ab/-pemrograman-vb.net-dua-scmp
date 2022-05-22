<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mahasiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbNama = New System.Windows.Forms.Label()
        Me.lbNim = New System.Windows.Forms.Label()
        Me.lbJenisKelamin = New System.Windows.Forms.Label()
        Me.nim = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.jenisKelamin = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.daftarMahasiswa = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.hapus = New System.Windows.Forms.Button()
        Me.ubah = New System.Windows.Forms.Button()
        Me.simpan = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.daftarMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbNama
        '
        Me.lbNama.AutoSize = True
        Me.lbNama.Location = New System.Drawing.Point(24, 70)
        Me.lbNama.Name = "lbNama"
        Me.lbNama.Size = New System.Drawing.Size(43, 15)
        Me.lbNama.TabIndex = 0
        Me.lbNama.Text = "NAMA"
        '
        'lbNim
        '
        Me.lbNim.AutoSize = True
        Me.lbNim.Location = New System.Drawing.Point(24, 28)
        Me.lbNim.Name = "lbNim"
        Me.lbNim.Size = New System.Drawing.Size(30, 15)
        Me.lbNim.TabIndex = 1
        Me.lbNim.Text = "NIM"
        '
        'lbJenisKelamin
        '
        Me.lbJenisKelamin.AutoSize = True
        Me.lbJenisKelamin.Location = New System.Drawing.Point(24, 112)
        Me.lbJenisKelamin.Name = "lbJenisKelamin"
        Me.lbJenisKelamin.Size = New System.Drawing.Size(88, 15)
        Me.lbJenisKelamin.TabIndex = 2
        Me.lbJenisKelamin.Text = "JENIS KELAMIN"
        '
        'nim
        '
        Me.nim.Location = New System.Drawing.Point(135, 25)
        Me.nim.Name = "nim"
        Me.nim.Size = New System.Drawing.Size(121, 23)
        Me.nim.TabIndex = 3
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(135, 67)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(233, 23)
        Me.nama.TabIndex = 4
        '
        'jenisKelamin
        '
        Me.jenisKelamin.FormattingEnabled = True
        Me.jenisKelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.jenisKelamin.Location = New System.Drawing.Point(135, 109)
        Me.jenisKelamin.Name = "jenisKelamin"
        Me.jenisKelamin.Size = New System.Drawing.Size(121, 23)
        Me.jenisKelamin.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.daftarMahasiswa)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(626, 262)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DAFTAR MAHASISWA"
        '
        'daftarMahasiswa
        '
        Me.daftarMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.daftarMahasiswa.Location = New System.Drawing.Point(6, 22)
        Me.daftarMahasiswa.Name = "daftarMahasiswa"
        Me.daftarMahasiswa.RowTemplate.Height = 25
        Me.daftarMahasiswa.Size = New System.Drawing.Size(614, 234)
        Me.daftarMahasiswa.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.hapus)
        Me.GroupBox2.Controls.Add(Me.ubah)
        Me.GroupBox2.Controls.Add(Me.simpan)
        Me.GroupBox2.Location = New System.Drawing.Point(472, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(178, 124)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Aksi"
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(13, 86)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(159, 23)
        Me.hapus.TabIndex = 2
        Me.hapus.Text = "HAPUS"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'ubah
        '
        Me.ubah.Location = New System.Drawing.Point(13, 54)
        Me.ubah.Name = "ubah"
        Me.ubah.Size = New System.Drawing.Size(159, 23)
        Me.ubah.TabIndex = 1
        Me.ubah.Text = "UBAH"
        Me.ubah.UseVisualStyleBackColor = True
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(13, 22)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(159, 23)
        Me.simpan.TabIndex = 0
        Me.simpan.Text = "SIMPAN"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'Mahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.jenisKelamin)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.nim)
        Me.Controls.Add(Me.lbJenisKelamin)
        Me.Controls.Add(Me.lbNim)
        Me.Controls.Add(Me.lbNama)
        Me.Name = "Mahasiswa"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.daftarMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbNama As Label
    Friend WithEvents lbNim As Label
    Friend WithEvents lbJenisKelamin As Label
    Friend WithEvents nim As TextBox
    Friend WithEvents nama As TextBox
    Friend WithEvents jenisKelamin As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents daftarMahasiswa As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents hapus As Button
    Friend WithEvents ubah As Button
    Friend WithEvents simpan As Button
End Class
