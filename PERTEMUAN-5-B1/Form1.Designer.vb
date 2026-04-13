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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtKodeJenis = New TextBox()
        txtJenis = New TextBox()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvJenis = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        btnPindah = New Button()
        CType(dgvJenis, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 9.0F)
        Label1.Location = New Point(29, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 22)
        Label1.TabIndex = 0
        Label1.Text = "Kode Jenis"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 9.0F)
        Label2.Location = New Point(29, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 22)
        Label2.TabIndex = 0
        Label2.Text = "Jenis"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 9.0F)
        Label3.Location = New Point(29, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 22)
        Label3.TabIndex = 0
        Label3.Text = "Cari Buku"
        ' 
        ' txtKodeJenis
        ' 
        txtKodeJenis.Font = New Font("Poppins", 9.0F)
        txtKodeJenis.Location = New Point(119, 24)
        txtKodeJenis.Name = "txtKodeJenis"
        txtKodeJenis.PlaceholderText = "Kode Jenis"
        txtKodeJenis.Size = New Size(291, 25)
        txtKodeJenis.TabIndex = 1
        ' 
        ' txtJenis
        ' 
        txtJenis.Font = New Font("Poppins", 9.0F)
        txtJenis.Location = New Point(119, 72)
        txtJenis.Name = "txtJenis"
        txtJenis.PlaceholderText = "Jenis"
        txtJenis.Size = New Size(291, 25)
        txtJenis.TabIndex = 1
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Poppins", 9.0F)
        txtSearch.Location = New Point(119, 130)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search"
        txtSearch.Size = New Size(291, 25)
        txtSearch.TabIndex = 1
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Poppins", 9.0F)
        btnSimpan.Location = New Point(29, 192)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 2
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Font = New Font("Poppins", 9.0F)
        btnUbah.Location = New Point(131, 192)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 23)
        btnUbah.TabIndex = 2
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Poppins", 9.0F)
        btnHapus.Location = New Point(232, 192)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Font = New Font("Poppins", 9.0F)
        btnBatal.Location = New Point(335, 192)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 23)
        btnBatal.TabIndex = 2
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvJenis
        ' 
        dgvJenis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJenis.Location = New Point(29, 243)
        dgvJenis.Name = "dgvJenis"
        dgvJenis.Size = New Size(381, 171)
        dgvJenis.TabIndex = 3
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnPindah
        ' 
        btnPindah.Location = New Point(182, 217)
        btnPindah.Name = "btnPindah"
        btnPindah.Size = New Size(75, 23)
        btnPindah.TabIndex = 4
        btnPindah.Text = "Pindah"
        btnPindah.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(448, 450)
        Controls.Add(btnPindah)
        Controls.Add(dgvJenis)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearch)
        Controls.Add(txtJenis)
        Controls.Add(txtKodeJenis)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dgvJenis, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKodeJenis As TextBox
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvJenis As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnPindah As Button

End Class
