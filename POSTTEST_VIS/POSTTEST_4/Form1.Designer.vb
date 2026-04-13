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
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        cmbDivisi = New ComboBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        dtpLahir = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        mtbNoHp = New MaskedTextBox()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        TabPage3 = New TabPage()
        gbJabatan = New GroupBox()
        rbAdmin = New RadioButton()
        rbViceLeader = New RadioButton()
        rbMember = New RadioButton()
        rbIntel = New RadioButton()
        rbLeader = New RadioButton()
        gbHobi = New GroupBox()
        cbMenggambar = New CheckBox()
        cbMenulis = New CheckBox()
        cbMembaca = New CheckBox()
        cbBelanja = New CheckBox()
        cbOlahraga = New CheckBox()
        cbBermusik = New CheckBox()
        cbMemasak = New CheckBox()
        cbGaming = New CheckBox()
        btnCetak = New Button()
        btnSimpan = New Button()
        btnCari = New Button()
        pbPfp = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        PictureBox1 = New PictureBox()
        Label9 = New Label()
        Label10 = New Label()
        Panel1 = New Panel()
        Label11 = New Label()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        gbJabatan.SuspendLayout()
        gbHobi.SuspendLayout()
        CType(pbPfp, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Black
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(587, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Font = New Font("Eurostile", 10F, FontStyle.Bold)
        InputDataToolStripMenuItem.ForeColor = Color.White
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(90, 20)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Font = New Font("Eurostile", 10F, FontStyle.Bold)
        LihatKartuToolStripMenuItem.ForeColor = Color.White
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(96, 20)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Font = New Font("Eurostile", 10F, FontStyle.Bold)
        SimpanDataToolStripMenuItem.ForeColor = Color.White
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(106, 20)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Font = New Font("Eurostile", 10F, FontStyle.Bold)
        BukaDataToolStripMenuItem.ForeColor = Color.White
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(89, 20)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Font = New Font("Eurostile", 10F, FontStyle.Bold)
        KeluarToolStripMenuItem.ForeColor = Color.White
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(63, 20)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("Eurostile", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(12, 145)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(563, 357)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Black
        TabPage1.Controls.Add(cmbDivisi)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(dtpLahir)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 23)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(555, 330)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' cmbDivisi
        ' 
        cmbDivisi.BackColor = Color.Black
        cmbDivisi.ForeColor = Color.White
        cmbDivisi.FormattingEnabled = True
        cmbDivisi.Items.AddRange(New Object() {"Research and Development (B.O.W. Division)", "Security and Paramilitary Forces (Red Umbrella)", "Corporate and Industrial", "Special Projects"})
        cmbDivisi.Location = New Point(211, 278)
        cmbDivisi.Name = "cmbDivisi"
        cmbDivisi.Size = New Size(312, 22)
        cmbDivisi.TabIndex = 4
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.ForeColor = Color.White
        rbPerempuan.Location = New Point(211, 235)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(93, 19)
        rbPerempuan.TabIndex = 3
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.ForeColor = Color.White
        rbLaki.Location = New Point(211, 199)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(74, 19)
        rbLaki.TabIndex = 3
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(211, 141)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(312, 22)
        dtpLahir.TabIndex = 2
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.Black
        txtID.BorderStyle = BorderStyle.FixedSingle
        txtID.ForeColor = Color.White
        txtID.Location = New Point(211, 83)
        txtID.Name = "txtID"
        txtID.Size = New Size(312, 22)
        txtID.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.Black
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.ForeColor = Color.White
        txtNama.Location = New Point(211, 25)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(312, 22)
        txtNama.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Eurostile", 13F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkRed
        Label5.Location = New Point(19, 278)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 20)
        Label5.TabIndex = 0
        Label5.Text = "Divisi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Eurostile", 13F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkRed
        Label4.Location = New Point(19, 198)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 20)
        Label4.TabIndex = 0
        Label4.Text = "Jenis Kelamin"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Eurostile", 13F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkRed
        Label3.Location = New Point(19, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 20)
        Label3.TabIndex = 0
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Eurostile", 13F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkRed
        Label2.Location = New Point(19, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 20)
        Label2.TabIndex = 0
        Label2.Text = "ID Anggota"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Eurostile", 13F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkRed
        Label1.Location = New Point(19, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama Anggota"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Black
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(mtbNoHp)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Location = New Point(4, 23)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(555, 330)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Eurostile", 13F, FontStyle.Bold)
        Label8.ForeColor = Color.DarkRed
        Label8.Location = New Point(26, 149)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 20)
        Label8.TabIndex = 2
        Label8.Text = "Alamat"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Eurostile", 13F, FontStyle.Bold)
        Label7.ForeColor = Color.DarkRed
        Label7.Location = New Point(26, 91)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 20)
        Label7.TabIndex = 2
        Label7.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Eurostile", 13F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkRed
        Label6.Location = New Point(26, 33)
        Label6.Name = "Label6"
        Label6.Size = New Size(137, 20)
        Label6.TabIndex = 2
        Label6.Text = "Nomor Telepon"
        ' 
        ' mtbNoHp
        ' 
        mtbNoHp.BackColor = Color.Black
        mtbNoHp.BorderStyle = BorderStyle.FixedSingle
        mtbNoHp.ForeColor = Color.White
        mtbNoHp.Location = New Point(209, 33)
        mtbNoHp.Mask = "0000-0000-0000"
        mtbNoHp.Name = "mtbNoHp"
        mtbNoHp.Size = New Size(270, 22)
        mtbNoHp.TabIndex = 1
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.Black
        txtAlamat.BorderStyle = BorderStyle.FixedSingle
        txtAlamat.ForeColor = Color.White
        txtAlamat.Location = New Point(209, 149)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(270, 90)
        txtAlamat.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.Black
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.ForeColor = Color.White
        txtEmail.Location = New Point(209, 91)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(270, 22)
        txtEmail.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.Black
        TabPage3.Controls.Add(gbJabatan)
        TabPage3.Controls.Add(gbHobi)
        TabPage3.Controls.Add(btnCetak)
        TabPage3.Controls.Add(btnSimpan)
        TabPage3.Controls.Add(btnCari)
        TabPage3.Controls.Add(pbPfp)
        TabPage3.Location = New Point(4, 23)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(555, 330)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        ' 
        ' gbJabatan
        ' 
        gbJabatan.Controls.Add(rbAdmin)
        gbJabatan.Controls.Add(rbViceLeader)
        gbJabatan.Controls.Add(rbMember)
        gbJabatan.Controls.Add(rbIntel)
        gbJabatan.Controls.Add(rbLeader)
        gbJabatan.Font = New Font("Eurostile", 10F)
        gbJabatan.ForeColor = Color.White
        gbJabatan.Location = New Point(219, 163)
        gbJabatan.Name = "gbJabatan"
        gbJabatan.Size = New Size(316, 118)
        gbJabatan.TabIndex = 2
        gbJabatan.TabStop = False
        gbJabatan.Text = "Jabatan/Peran"
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Font = New Font("Eurostile", 10F)
        rbAdmin.Location = New Point(20, 72)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(63, 19)
        rbAdmin.TabIndex = 0
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbViceLeader
        ' 
        rbViceLeader.AutoSize = True
        rbViceLeader.Font = New Font("Eurostile", 10F)
        rbViceLeader.Location = New Point(20, 47)
        rbViceLeader.Name = "rbViceLeader"
        rbViceLeader.Size = New Size(95, 19)
        rbViceLeader.TabIndex = 0
        rbViceLeader.TabStop = True
        rbViceLeader.Text = "Vice Leader"
        rbViceLeader.UseVisualStyleBackColor = True
        ' 
        ' rbMember
        ' 
        rbMember.AutoSize = True
        rbMember.Font = New Font("Eurostile", 10F)
        rbMember.Location = New Point(144, 47)
        rbMember.Name = "rbMember"
        rbMember.Size = New Size(76, 19)
        rbMember.TabIndex = 0
        rbMember.TabStop = True
        rbMember.Text = "Member"
        rbMember.UseVisualStyleBackColor = True
        ' 
        ' rbIntel
        ' 
        rbIntel.AutoSize = True
        rbIntel.Font = New Font("Eurostile", 10F)
        rbIntel.Location = New Point(144, 22)
        rbIntel.Name = "rbIntel"
        rbIntel.Size = New Size(50, 19)
        rbIntel.TabIndex = 0
        rbIntel.TabStop = True
        rbIntel.Text = "Intel"
        rbIntel.UseVisualStyleBackColor = True
        ' 
        ' rbLeader
        ' 
        rbLeader.AutoSize = True
        rbLeader.Font = New Font("Eurostile", 10F)
        rbLeader.Location = New Point(19, 22)
        rbLeader.Name = "rbLeader"
        rbLeader.Size = New Size(66, 19)
        rbLeader.TabIndex = 0
        rbLeader.TabStop = True
        rbLeader.Text = "Leader"
        rbLeader.UseVisualStyleBackColor = True
        ' 
        ' gbHobi
        ' 
        gbHobi.Controls.Add(cbMenggambar)
        gbHobi.Controls.Add(cbMenulis)
        gbHobi.Controls.Add(cbMembaca)
        gbHobi.Controls.Add(cbBelanja)
        gbHobi.Controls.Add(cbOlahraga)
        gbHobi.Controls.Add(cbBermusik)
        gbHobi.Controls.Add(cbMemasak)
        gbHobi.Controls.Add(cbGaming)
        gbHobi.Font = New Font("Eurostile", 10F)
        gbHobi.ForeColor = Color.White
        gbHobi.Location = New Point(219, 6)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(316, 140)
        gbHobi.TabIndex = 2
        gbHobi.TabStop = False
        gbHobi.Text = "Hobi"
        ' 
        ' cbMenggambar
        ' 
        cbMenggambar.AutoSize = True
        cbMenggambar.Font = New Font("Eurostile", 10F)
        cbMenggambar.Location = New Point(20, 96)
        cbMenggambar.Name = "cbMenggambar"
        cbMenggambar.Size = New Size(105, 19)
        cbMenggambar.TabIndex = 2
        cbMenggambar.Text = "Menggambar"
        cbMenggambar.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Font = New Font("Eurostile", 10F)
        cbMenulis.Location = New Point(20, 71)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(72, 19)
        cbMenulis.TabIndex = 2
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Font = New Font("Eurostile", 10F)
        cbMembaca.Location = New Point(20, 46)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(85, 19)
        cbMembaca.TabIndex = 2
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbBelanja
        ' 
        cbBelanja.AutoSize = True
        cbBelanja.Font = New Font("Eurostile", 10F)
        cbBelanja.Location = New Point(145, 96)
        cbBelanja.Name = "cbBelanja"
        cbBelanja.Size = New Size(89, 19)
        cbBelanja.TabIndex = 2
        cbBelanja.Text = "Berbelanja"
        cbBelanja.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Font = New Font("Eurostile", 10F)
        cbOlahraga.Location = New Point(145, 71)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(79, 19)
        cbOlahraga.TabIndex = 2
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbBermusik
        ' 
        cbBermusik.AutoSize = True
        cbBermusik.Font = New Font("Eurostile", 10F)
        cbBermusik.Location = New Point(145, 46)
        cbBermusik.Name = "cbBermusik"
        cbBermusik.Size = New Size(83, 19)
        cbBermusik.TabIndex = 2
        cbBermusik.Text = "Bermusik"
        cbBermusik.UseVisualStyleBackColor = True
        ' 
        ' cbMemasak
        ' 
        cbMemasak.AutoSize = True
        cbMemasak.Font = New Font("Eurostile", 10F)
        cbMemasak.Location = New Point(145, 21)
        cbMemasak.Name = "cbMemasak"
        cbMemasak.Size = New Size(84, 19)
        cbMemasak.TabIndex = 2
        cbMemasak.Text = "Memasak"
        cbMemasak.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Font = New Font("Eurostile", 10F)
        cbGaming.Location = New Point(20, 21)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(71, 19)
        cbGaming.TabIndex = 2
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(261, 300)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(263, 23)
        btnCetak.TabIndex = 1
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(6, 300)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(249, 23)
        btnSimpan.TabIndex = 1
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(21, 258)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(150, 23)
        btnCari.TabIndex = 1
        btnCari.Text = "Cari Foto"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' pbPfp
        ' 
        pbPfp.BorderStyle = BorderStyle.FixedSingle
        pbPfp.Image = My.Resources.Resources._480690444_671460888544455_6426701177921750932_n
        pbPfp.Location = New Point(6, 6)
        pbPfp.Name = "pbPfp"
        pbPfp.Size = New Size(183, 246)
        pbPfp.SizeMode = PictureBoxSizeMode.Zoom
        pbPfp.TabIndex = 0
        pbPfp.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.peakpx_copy
        PictureBox1.Location = New Point(12, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(110, 102)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Eurostile", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(128, 31)
        Label9.Name = "Label9"
        Label9.Size = New Size(234, 45)
        Label9.TabIndex = 3
        Label9.Text = "UMBRELLA"
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Eurostile", 20F)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(137, 78)
        Label10.Name = "Label10"
        Label10.Size = New Size(225, 29)
        Label10.TabIndex = 3
        Label10.Text = "CORPORATION"
        Label10.TextAlign = ContentAlignment.TopRight
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Maroon
        Panel1.Location = New Point(137, 32)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(225, 74)
        Panel1.TabIndex = 4
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Eurostile", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(380, 67)
        Label11.Name = "Label11"
        Label11.Size = New Size(198, 21)
        Label11.TabIndex = 3
        Label11.Text = "Community Data Entry"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(587, 514)
        Controls.Add(Label10)
        Controls.Add(Label11)
        Controls.Add(Label9)
        Controls.Add(PictureBox1)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        Controls.Add(Panel1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        gbJabatan.ResumeLayout(False)
        gbJabatan.PerformLayout()
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        CType(pbPfp, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents cmbDivisi As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents mtbNoHp As MaskedTextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents pbPfp As PictureBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents gbJabatan As GroupBox
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbViceLeader As RadioButton
    Friend WithEvents rbMember As RadioButton
    Friend WithEvents rbIntel As RadioButton
    Friend WithEvents rbLeader As RadioButton
    Friend WithEvents cbMenggambar As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbBelanja As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbBermusik As CheckBox
    Friend WithEvents cbMemasak As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label

End Class
