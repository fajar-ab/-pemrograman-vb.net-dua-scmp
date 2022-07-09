<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataJadwal = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.hari = New System.Windows.Forms.ComboBox()
        Me.mtk = New System.Windows.Forms.ComboBox()
        Me.pukul = New System.Windows.Forms.TextBox()
        Me.simpan = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ubah = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.Button()
        CType(Me.DataJadwal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(479, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(236, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jadwal Mata Kuliah"
        '
        'DataJadwal
        '
        Me.DataJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataJadwal.Location = New System.Drawing.Point(308, 103)
        Me.DataJadwal.Name = "DataJadwal"
        Me.DataJadwal.RowTemplate.Height = 25
        Me.DataJadwal.Size = New System.Drawing.Size(782, 376)
        Me.DataJadwal.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tambah Jadwal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hari"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Mata Kuliah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Pukul"
        '
        'hari
        '
        Me.hari.FormattingEnabled = True
        Me.hari.Items.AddRange(New Object() {"senin", "selasa", "rabu", "kamis", "jumat", "sabtu", "minggu"})
        Me.hari.Location = New System.Drawing.Point(12, 146)
        Me.hari.Name = "hari"
        Me.hari.Size = New System.Drawing.Size(248, 23)
        Me.hari.TabIndex = 6
        '
        'mtk
        '
        Me.mtk.FormattingEnabled = True
        Me.mtk.Location = New System.Drawing.Point(12, 202)
        Me.mtk.Name = "mtk"
        Me.mtk.Size = New System.Drawing.Size(248, 23)
        Me.mtk.TabIndex = 7
        '
        'pukul
        '
        Me.pukul.Location = New System.Drawing.Point(12, 258)
        Me.pukul.Name = "pukul"
        Me.pukul.Size = New System.Drawing.Size(248, 23)
        Me.pukul.TabIndex = 8
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(12, 301)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(248, 27)
        Me.simpan.TabIndex = 9
        Me.simpan.Text = "Simpan"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 441)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(248, 38)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Lihat Matakuliah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ubah
        '
        Me.ubah.Location = New System.Drawing.Point(12, 334)
        Me.ubah.Name = "ubah"
        Me.ubah.Size = New System.Drawing.Size(248, 27)
        Me.ubah.TabIndex = 11
        Me.ubah.Text = "Ubah"
        Me.ubah.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(12, 367)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(248, 27)
        Me.hapus.TabIndex = 12
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 491)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.ubah)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.pukul)
        Me.Controls.Add(Me.mtk)
        Me.Controls.Add(Me.hari)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataJadwal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Jadwal"
        CType(Me.DataJadwal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataJadwal As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents hari As ComboBox
    Friend WithEvents mtk As ComboBox
    Friend WithEvents pukul As TextBox
    Friend WithEvents simpan As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ubah As Button
    Friend WithEvents hapus As Button
End Class
