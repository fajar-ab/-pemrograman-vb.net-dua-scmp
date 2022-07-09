<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MataKuliah
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.kodeMatakuliah = New System.Windows.Forms.TextBox()
        Me.namaMatakuliah = New System.Windows.Forms.TextBox()
        Me.dosen = New System.Windows.Forms.TextBox()
        Me.ruangan = New System.Windows.Forms.ComboBox()
        Me.sks = New System.Windows.Forms.TextBox()
        Me.semester = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.simpan = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataMatakuliah = New System.Windows.Forms.DataGridView()
        Me.ubah = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataMatakuliah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Matakuliah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Matakuliah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Dosen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ruangan"
        '
        'kodeMatakuliah
        '
        Me.kodeMatakuliah.Location = New System.Drawing.Point(12, 76)
        Me.kodeMatakuliah.Name = "kodeMatakuliah"
        Me.kodeMatakuliah.Size = New System.Drawing.Size(226, 23)
        Me.kodeMatakuliah.TabIndex = 5
        '
        'namaMatakuliah
        '
        Me.namaMatakuliah.Location = New System.Drawing.Point(12, 136)
        Me.namaMatakuliah.Name = "namaMatakuliah"
        Me.namaMatakuliah.Size = New System.Drawing.Size(226, 23)
        Me.namaMatakuliah.TabIndex = 6
        '
        'dosen
        '
        Me.dosen.Location = New System.Drawing.Point(12, 191)
        Me.dosen.Name = "dosen"
        Me.dosen.Size = New System.Drawing.Size(226, 23)
        Me.dosen.TabIndex = 7
        '
        'ruangan
        '
        Me.ruangan.FormattingEnabled = True
        Me.ruangan.Items.AddRange(New Object() {"RUANG01", "RUANG02", "LABOR01"})
        Me.ruangan.Location = New System.Drawing.Point(12, 242)
        Me.ruangan.Name = "ruangan"
        Me.ruangan.Size = New System.Drawing.Size(227, 23)
        Me.ruangan.TabIndex = 8
        '
        'sks
        '
        Me.sks.Location = New System.Drawing.Point(13, 299)
        Me.sks.Name = "sks"
        Me.sks.Size = New System.Drawing.Size(110, 23)
        Me.sks.TabIndex = 9
        '
        'semester
        '
        Me.semester.Location = New System.Drawing.Point(129, 299)
        Me.semester.Name = "semester"
        Me.semester.Size = New System.Drawing.Size(109, 23)
        Me.semester.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "SKS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(129, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Semester"
        '
        'simpan
        '
        Me.simpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.simpan.Location = New System.Drawing.Point(13, 342)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(225, 23)
        Me.simpan.TabIndex = 13
        Me.simpan.Text = "Simpan"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(12, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Tambah Mata Kuliah"
        '
        'DataMatakuliah
        '
        Me.DataMatakuliah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataMatakuliah.Location = New System.Drawing.Point(266, 76)
        Me.DataMatakuliah.Name = "DataMatakuliah"
        Me.DataMatakuliah.RowTemplate.Height = 25
        Me.DataMatakuliah.Size = New System.Drawing.Size(695, 357)
        Me.DataMatakuliah.TabIndex = 15
        '
        'ubah
        '
        Me.ubah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ubah.Location = New System.Drawing.Point(13, 376)
        Me.ubah.Name = "ubah"
        Me.ubah.Size = New System.Drawing.Size(225, 23)
        Me.ubah.TabIndex = 16
        Me.ubah.Text = "Ubah"
        Me.ubah.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hapus.Location = New System.Drawing.Point(13, 410)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(225, 23)
        Me.hapus.TabIndex = 17
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(497, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 21)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Mata Kuliah"
        '
        'MataKuliah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 459)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.ubah)
        Me.Controls.Add(Me.DataMatakuliah)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.semester)
        Me.Controls.Add(Me.sks)
        Me.Controls.Add(Me.ruangan)
        Me.Controls.Add(Me.dosen)
        Me.Controls.Add(Me.namaMatakuliah)
        Me.Controls.Add(Me.kodeMatakuliah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MataKuliah"
        Me.Text = "MataKuliah"
        CType(Me.DataMatakuliah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents kodeMatakuliah As TextBox
    Friend WithEvents namaMatakuliah As TextBox
    Friend WithEvents dosen As TextBox
    Friend WithEvents ruangan As ComboBox
    Friend WithEvents sks As TextBox
    Friend WithEvents semester As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents simpan As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents DataMatakuliah As DataGridView
    Friend WithEvents ubah As Button
    Friend WithEvents hapus As Button
    Friend WithEvents Label8 As Label
End Class
