<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Panel1 = New Panel()
        txtTahun = New TextBox()
        txtGenre = New TextBox()
        txtPenulis = New TextBox()
        txtJudul1 = New TextBox()
        Label7 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        dgvBuku = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        btnTambah = New Button()
        Label4 = New Label()
        Panel2 = New Panel()
        Label5 = New Label()
        txtJudul2 = New TextBox()
        btnHapus = New Button()
        Label6 = New Label()
        Panel1.SuspendLayout()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(txtTahun)
        Panel1.Controls.Add(txtGenre)
        Panel1.Controls.Add(txtPenulis)
        Panel1.Controls.Add(txtJudul1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(47, 271)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(229, 193)
        Panel1.TabIndex = 0
        ' 
        ' txtTahun
        ' 
        txtTahun.Location = New Point(105, 139)
        txtTahun.MaxLength = 20
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New Size(100, 23)
        txtTahun.TabIndex = 4
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(105, 97)
        txtGenre.MaxLength = 20
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(100, 23)
        txtGenre.TabIndex = 4
        ' 
        ' txtPenulis
        ' 
        txtPenulis.Location = New Point(105, 56)
        txtPenulis.MaxLength = 20
        txtPenulis.Name = "txtPenulis"
        txtPenulis.Size = New Size(100, 23)
        txtPenulis.TabIndex = 4
        ' 
        ' txtJudul1
        ' 
        txtJudul1.Location = New Point(105, 17)
        txtJudul1.MaxLength = 20
        txtJudul1.Name = "txtJudul1"
        txtJudul1.Size = New Size(100, 23)
        txtJudul1.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(13, 142)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 15)
        Label7.TabIndex = 2
        Label7.Text = "Tahun Terbit"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 2
        Label3.Text = "Genre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 15)
        Label2.TabIndex = 2
        Label2.Text = "Penulis"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 2
        Label1.Text = "Judul Buku"
        ' 
        ' dgvBuku
        ' 
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        dgvBuku.Location = New Point(68, 53)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.Size = New Size(443, 150)
        dgvBuku.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Judul Buku"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Penulis"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Genre"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Tahun Terbit"
        Column4.Name = "Column4"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(182, 449)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(81, 29)
        btnTambah.TabIndex = 3
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(111, 262)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 15)
        Label4.TabIndex = 2
        Label4.Text = "Tambah Buku"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txtJudul2)
        Panel2.Location = New Point(304, 271)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(229, 100)
        Panel2.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(14, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 15)
        Label5.TabIndex = 5
        Label5.Text = "Judul Buku"
        ' 
        ' txtJudul2
        ' 
        txtJudul2.Location = New Point(106, 29)
        txtJudul2.MaxLength = 20
        txtJudul2.Name = "txtJudul2"
        txtJudul2.Size = New Size(100, 23)
        txtJudul2.TabIndex = 7
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(439, 356)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(81, 29)
        btnHapus.TabIndex = 6
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(378, 262)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 15)
        Label6.TabIndex = 5
        Label6.Text = "Hapus Buku"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(586, 514)
        Controls.Add(Label6)
        Controls.Add(btnHapus)
        Controls.Add(Panel2)
        Controls.Add(Label4)
        Controls.Add(btnTambah)
        Controls.Add(dgvBuku)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents txtJudul1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtJudul2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn

End Class
