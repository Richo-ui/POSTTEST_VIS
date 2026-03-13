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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        pbProfil = New PictureBox()
        btnCetak = New Button()
        btnFoto = New Button()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelpon = New TextBox()
        txtAlamat = New TextBox()
        gbKelamin = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        gbHobi = New GroupBox()
        cbGambar = New CheckBox()
        cbMasak = New CheckBox()
        cbNulis = New CheckBox()
        cbBaca = New CheckBox()
        cbKebun = New CheckBox()
        cbGaming = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMusik = New CheckBox()
        cbKaraoke = New CheckBox()
        cbBelanja = New CheckBox()
        dtpLahir = New DateTimePicker()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        CType(pbProfil, ComponentModel.ISupportInitialize).BeginInit()
        gbKelamin.SuspendLayout()
        gbHobi.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Eurostile", 13F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkRed
        Label1.Location = New Point(333, 131)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 20)
        Label1.TabIndex = 0
        Label1.Text = "NAMA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Eurostile", 13F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkRed
        Label2.Location = New Point(333, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 20)
        Label2.TabIndex = 0
        Label2.Text = "UMUR"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Eurostile", 13F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkRed
        Label3.Location = New Point(333, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 20)
        Label3.TabIndex = 0
        Label3.Text = "NO TELEPON"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Eurostile", 13F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkRed
        Label4.Location = New Point(333, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 20)
        Label4.TabIndex = 0
        Label4.Text = "ALAMAT"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Eurostile", 13F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkRed
        Label5.Location = New Point(333, 250)
        Label5.Name = "Label5"
        Label5.Size = New Size(149, 20)
        Label5.TabIndex = 0
        Label5.Text = "TANGGAL LAHIR"
        ' 
        ' pbProfil
        ' 
        pbProfil.Location = New Point(50, 135)
        pbProfil.Name = "pbProfil"
        pbProfil.Size = New Size(195, 268)
        pbProfil.SizeMode = PictureBoxSizeMode.StretchImage
        pbProfil.TabIndex = 1
        pbProfil.TabStop = False
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(81, 463)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(738, 34)
        btnCetak.TabIndex = 2
        btnCetak.Text = "CETAK KARTU"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' btnFoto
        ' 
        btnFoto.ForeColor = Color.Black
        btnFoto.Location = New Point(44, 421)
        btnFoto.Name = "btnFoto"
        btnFoto.Size = New Size(207, 27)
        btnFoto.TabIndex = 2
        btnFoto.Text = "Browse Photo"
        btnFoto.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.Black
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.ForeColor = Color.White
        txtNama.Location = New Point(571, 131)
        txtNama.MaxLength = 30
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(248, 23)
        txtNama.TabIndex = 3
        ' 
        ' txtUmur
        ' 
        txtUmur.BackColor = Color.Black
        txtUmur.BorderStyle = BorderStyle.FixedSingle
        txtUmur.ForeColor = Color.White
        txtUmur.Location = New Point(571, 160)
        txtUmur.MaxLength = 3
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(248, 23)
        txtUmur.TabIndex = 3
        ' 
        ' txtTelpon
        ' 
        txtTelpon.BackColor = Color.Black
        txtTelpon.BorderStyle = BorderStyle.FixedSingle
        txtTelpon.ForeColor = Color.White
        txtTelpon.Location = New Point(571, 189)
        txtTelpon.MaxLength = 13
        txtTelpon.Name = "txtTelpon"
        txtTelpon.Size = New Size(248, 23)
        txtTelpon.TabIndex = 3
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.Black
        txtAlamat.BorderStyle = BorderStyle.FixedSingle
        txtAlamat.ForeColor = Color.White
        txtAlamat.Location = New Point(571, 218)
        txtAlamat.MaxLength = 100
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(248, 23)
        txtAlamat.TabIndex = 3
        ' 
        ' gbKelamin
        ' 
        gbKelamin.Controls.Add(rbPerempuan)
        gbKelamin.Controls.Add(rbLaki)
        gbKelamin.Font = New Font("Eurostile", 15F)
        gbKelamin.ForeColor = Color.White
        gbKelamin.Location = New Point(333, 287)
        gbKelamin.Name = "gbKelamin"
        gbKelamin.Size = New Size(200, 150)
        gbKelamin.TabIndex = 4
        gbKelamin.TabStop = False
        gbKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Font = New Font("Eurostile", 12F, FontStyle.Bold)
        rbPerempuan.ForeColor = Color.White
        rbPerempuan.Location = New Point(21, 95)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(111, 21)
        rbPerempuan.TabIndex = 5
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.BackColor = Color.Transparent
        rbLaki.Font = New Font("Eurostile", 12F, FontStyle.Bold)
        rbLaki.ForeColor = Color.White
        rbLaki.Location = New Point(21, 46)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(90, 21)
        rbLaki.TabIndex = 5
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = False
        ' 
        ' gbHobi
        ' 
        gbHobi.Controls.Add(cbGambar)
        gbHobi.Controls.Add(cbMasak)
        gbHobi.Controls.Add(cbNulis)
        gbHobi.Controls.Add(cbBaca)
        gbHobi.Controls.Add(cbKebun)
        gbHobi.Controls.Add(cbGaming)
        gbHobi.Controls.Add(cbOlahraga)
        gbHobi.Controls.Add(cbMusik)
        gbHobi.Controls.Add(cbKaraoke)
        gbHobi.Controls.Add(cbBelanja)
        gbHobi.Font = New Font("Eurostile", 12F)
        gbHobi.ForeColor = Color.White
        gbHobi.Location = New Point(571, 287)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(248, 150)
        gbHobi.TabIndex = 4
        gbHobi.TabStop = False
        gbHobi.Text = "Hobi"
        ' 
        ' cbGambar
        ' 
        cbGambar.AutoSize = True
        cbGambar.ForeColor = Color.White
        cbGambar.Location = New Point(16, 122)
        cbGambar.Name = "cbGambar"
        cbGambar.Size = New Size(116, 21)
        cbGambar.TabIndex = 5
        cbGambar.Text = "Menggambar"
        cbGambar.UseVisualStyleBackColor = True
        ' 
        ' cbMasak
        ' 
        cbMasak.AutoSize = True
        cbMasak.ForeColor = Color.White
        cbMasak.Location = New Point(16, 97)
        cbMasak.Name = "cbMasak"
        cbMasak.Size = New Size(93, 21)
        cbMasak.TabIndex = 5
        cbMasak.Text = "Memasak"
        cbMasak.UseVisualStyleBackColor = True
        ' 
        ' cbNulis
        ' 
        cbNulis.AutoSize = True
        cbNulis.ForeColor = Color.White
        cbNulis.Location = New Point(16, 72)
        cbNulis.Name = "cbNulis"
        cbNulis.Size = New Size(79, 21)
        cbNulis.TabIndex = 5
        cbNulis.Text = "Menulis"
        cbNulis.UseVisualStyleBackColor = True
        ' 
        ' cbBaca
        ' 
        cbBaca.AutoSize = True
        cbBaca.ForeColor = Color.White
        cbBaca.Location = New Point(16, 47)
        cbBaca.Name = "cbBaca"
        cbBaca.Size = New Size(94, 21)
        cbBaca.TabIndex = 5
        cbBaca.Text = "Membaca"
        cbBaca.UseVisualStyleBackColor = True
        ' 
        ' cbKebun
        ' 
        cbKebun.AutoSize = True
        cbKebun.ForeColor = Color.White
        cbKebun.Location = New Point(142, 122)
        cbKebun.Name = "cbKebun"
        cbKebun.Size = New Size(90, 21)
        cbKebun.TabIndex = 5
        cbKebun.Text = "Berkebun"
        cbKebun.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.ForeColor = Color.White
        cbGaming.Location = New Point(16, 22)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(77, 21)
        cbGaming.TabIndex = 5
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.ForeColor = Color.White
        cbOlahraga.Location = New Point(142, 47)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(86, 21)
        cbOlahraga.TabIndex = 5
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.ForeColor = Color.White
        cbMusik.Location = New Point(142, 97)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(90, 21)
        cbMusik.TabIndex = 5
        cbMusik.Text = "Bermusik"
        cbMusik.UseVisualStyleBackColor = True
        ' 
        ' cbKaraoke
        ' 
        cbKaraoke.AutoSize = True
        cbKaraoke.ForeColor = Color.White
        cbKaraoke.Location = New Point(142, 22)
        cbKaraoke.Name = "cbKaraoke"
        cbKaraoke.Size = New Size(82, 21)
        cbKaraoke.TabIndex = 5
        cbKaraoke.Text = "Karaoke"
        cbKaraoke.UseVisualStyleBackColor = True
        ' 
        ' cbBelanja
        ' 
        cbBelanja.AutoSize = True
        cbBelanja.ForeColor = Color.White
        cbBelanja.Location = New Point(142, 72)
        cbBelanja.Name = "cbBelanja"
        cbBelanja.Size = New Size(97, 21)
        cbBelanja.TabIndex = 5
        cbBelanja.Text = "Berbelanja"
        cbBelanja.UseVisualStyleBackColor = True
        ' 
        ' dtpLahir
        ' 
        dtpLahir.AccessibleRole = AccessibleRole.None
        dtpLahir.Location = New Point(571, 247)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(248, 23)
        dtpLahir.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Eurostile", 50F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(-12, -10)
        Label6.Name = "Label6"
        Label6.Size = New Size(360, 72)
        Label6.TabIndex = 0
        Label6.Text = "UMBRELLA"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Eurostile", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(234, 62)
        Label7.Name = "Label7"
        Label7.Size = New Size(273, 43)
        Label7.TabIndex = 0
        Label7.Text = "CORPORATION"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Eurostile", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(539, 44)
        Label8.Name = "Label8"
        Label8.Size = New Size(338, 36)
        Label8.TabIndex = 0
        Label8.Text = "IDENTITY CARD ENTRY"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(12, 8)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(125, 121)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel1.Location = New Point(44, 128)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(207, 281)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(143, 61)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(390, 51)
        Panel2.TabIndex = 6
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Maroon
        Panel3.Location = New Point(143, 55)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(390, 55)
        Panel3.TabIndex = 6
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Black
        Panel4.Controls.Add(Label6)
        Panel4.Location = New Point(143, 8)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(390, 51)
        Panel4.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(885, 509)
        Controls.Add(Label7)
        Controls.Add(dtpLahir)
        Controls.Add(gbHobi)
        Controls.Add(gbKelamin)
        Controls.Add(txtTelpon)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(btnFoto)
        Controls.Add(btnCetak)
        Controls.Add(PictureBox2)
        Controls.Add(pbProfil)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label8)
        Controls.Add(Label1)
        Controls.Add(txtAlamat)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Name = "Form1"
        Text = "Form1"
        CType(pbProfil, ComponentModel.ISupportInitialize).EndInit()
        gbKelamin.ResumeLayout(False)
        gbKelamin.PerformLayout()
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pbProfil As PictureBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnFoto As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelpon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents gbKelamin As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents cbNulis As CheckBox
    Friend WithEvents cbBaca As CheckBox
    Friend WithEvents cbBelanja As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbKaraoke As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbGambar As CheckBox
    Friend WithEvents cbMasak As CheckBox
    Friend WithEvents cbKebun As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel

End Class
