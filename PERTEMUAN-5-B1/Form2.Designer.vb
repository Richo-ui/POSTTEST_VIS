<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtKode = New TextBox()
        txtJudul = New TextBox()
        txtPengarang = New TextBox()
        txtPenerbit = New TextBox()
        txtJumlahBuku = New TextBox()
        Label7 = New Label()
        txtDeskripsi = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        cbJenis = New ComboBox()
        txtCari = New TextBox()
        dgvBuku = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 0
        Label1.Text = "Kode Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 0
        Label2.Text = "Judul"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(34, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 0
        Label3.Text = "Pengarang"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(34, 146)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 0
        Label4.Text = "Penerbit"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(34, 195)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 15)
        Label5.TabIndex = 0
        Label5.Text = "Jumlah Buku"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(294, 27)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 15)
        Label6.TabIndex = 0
        Label6.Text = "Jenis Buku"
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(133, 24)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(100, 23)
        txtKode.TabIndex = 1
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(133, 61)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(355, 23)
        txtJudul.TabIndex = 1
        ' 
        ' txtPengarang
        ' 
        txtPengarang.Location = New Point(133, 100)
        txtPengarang.Name = "txtPengarang"
        txtPengarang.Size = New Size(355, 23)
        txtPengarang.TabIndex = 1
        ' 
        ' txtPenerbit
        ' 
        txtPenerbit.Location = New Point(133, 143)
        txtPenerbit.Name = "txtPenerbit"
        txtPenerbit.Size = New Size(355, 23)
        txtPenerbit.TabIndex = 1
        ' 
        ' txtJumlahBuku
        ' 
        txtJumlahBuku.Location = New Point(133, 192)
        txtJumlahBuku.Name = "txtJumlahBuku"
        txtJumlahBuku.Size = New Size(355, 23)
        txtJumlahBuku.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(597, 27)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 15)
        Label7.TabIndex = 0
        Label7.Text = "Deskripsi"
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Location = New Point(521, 64)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(213, 151)
        txtDeskripsi.TabIndex = 1
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(52, 261)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 2
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(210, 261)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 23)
        btnUbah.TabIndex = 2
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(388, 261)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(576, 261)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 23)
        btnBatal.TabIndex = 2
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' cbJenis
        ' 
        cbJenis.FormattingEnabled = True
        cbJenis.Location = New Point(367, 24)
        cbJenis.Name = "cbJenis"
        cbJenis.Size = New Size(121, 23)
        cbJenis.TabIndex = 3
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(34, 310)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Cari Data..."
        txtCari.Size = New Size(700, 23)
        txtCari.TabIndex = 4
        ' 
        ' dgvBuku
        ' 
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Location = New Point(34, 350)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.Size = New Size(700, 150)
        dgvBuku.TabIndex = 5
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(767, 513)
        Controls.Add(dgvBuku)
        Controls.Add(txtCari)
        Controls.Add(cbJenis)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtDeskripsi)
        Controls.Add(txtJumlahBuku)
        Controls.Add(txtPenerbit)
        Controls.Add(txtPengarang)
        Controls.Add(txtJudul)
        Controls.Add(txtKode)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtPengarang As TextBox
    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents txtJumlahBuku As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
