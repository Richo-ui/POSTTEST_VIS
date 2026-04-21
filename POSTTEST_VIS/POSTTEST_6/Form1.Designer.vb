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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtJudul = New TextBox()
        txtEpisode = New TextBox()
        txtStudio = New TextBox()
        txtRating = New TextBox()
        gbGenre = New GroupBox()
        cbMusic = New CheckBox()
        cbShoujo = New CheckBox()
        cbFantasy = New CheckBox()
        cbRomance = New CheckBox()
        cbPhsyco = New CheckBox()
        cbMagic = New CheckBox()
        cbGame = New CheckBox()
        cbHorror = New CheckBox()
        cbHarem = New CheckBox()
        cbDrama = New CheckBox()
        cbComedy = New CheckBox()
        cbAdventure = New CheckBox()
        cbSport = New CheckBox()
        cbSoL = New CheckBox()
        cbSciFi = New CheckBox()
        cbShounen = New CheckBox()
        cbSeinen = New CheckBox()
        cbSchool = New CheckBox()
        cbMystery = New CheckBox()
        cbAction = New CheckBox()
        DataGridView1 = New DataGridView()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        pbPhoto = New PictureBox()
        btnCari = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        Label6 = New Label()
        cmbStatus = New ComboBox()
        btnLihat = New Button()
        gbGenre.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbPhoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Ketchum", 9.75F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(265, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 15)
        Label1.TabIndex = 0
        Label1.Text = "Judul Anime"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Ketchum", 9.75F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(265, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 0
        Label2.Text = "Genre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Ketchum", 9.75F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(265, 195)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 15)
        Label3.TabIndex = 0
        Label3.Text = "Episode"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Ketchum", 9.75F)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(265, 238)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 15)
        Label4.TabIndex = 0
        Label4.Text = "Studio"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Ketchum", 9.75F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(626, 195)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 15)
        Label5.TabIndex = 0
        Label5.Text = "Rating"
        ' 
        ' txtJudul
        ' 
        txtJudul.BackColor = Color.WhiteSmoke
        txtJudul.Location = New Point(350, 21)
        txtJudul.Name = "txtJudul"
        txtJudul.PlaceholderText = "ex. Ao Hana"
        txtJudul.Size = New Size(541, 23)
        txtJudul.TabIndex = 1
        ' 
        ' txtEpisode
        ' 
        txtEpisode.BackColor = Color.WhiteSmoke
        txtEpisode.Location = New Point(350, 192)
        txtEpisode.Name = "txtEpisode"
        txtEpisode.PlaceholderText = "ex. 12"
        txtEpisode.Size = New Size(239, 23)
        txtEpisode.TabIndex = 1
        ' 
        ' txtStudio
        ' 
        txtStudio.Location = New Point(350, 235)
        txtStudio.Name = "txtStudio"
        txtStudio.PlaceholderText = "ex. A-1 Pictures"
        txtStudio.Size = New Size(239, 23)
        txtStudio.TabIndex = 1
        ' 
        ' txtRating
        ' 
        txtRating.Location = New Point(693, 192)
        txtRating.Name = "txtRating"
        txtRating.PlaceholderText = "ex. 7.5"
        txtRating.Size = New Size(198, 23)
        txtRating.TabIndex = 1
        ' 
        ' gbGenre
        ' 
        gbGenre.BackColor = Color.Transparent
        gbGenre.Controls.Add(cbMusic)
        gbGenre.Controls.Add(cbShoujo)
        gbGenre.Controls.Add(cbFantasy)
        gbGenre.Controls.Add(cbRomance)
        gbGenre.Controls.Add(cbPhsyco)
        gbGenre.Controls.Add(cbMagic)
        gbGenre.Controls.Add(cbGame)
        gbGenre.Controls.Add(cbHorror)
        gbGenre.Controls.Add(cbHarem)
        gbGenre.Controls.Add(cbDrama)
        gbGenre.Controls.Add(cbComedy)
        gbGenre.Controls.Add(cbAdventure)
        gbGenre.Controls.Add(cbSport)
        gbGenre.Controls.Add(cbSoL)
        gbGenre.Controls.Add(cbSciFi)
        gbGenre.Controls.Add(cbShounen)
        gbGenre.Controls.Add(cbSeinen)
        gbGenre.Controls.Add(cbSchool)
        gbGenre.Controls.Add(cbMystery)
        gbGenre.Controls.Add(cbAction)
        gbGenre.Location = New Point(350, 50)
        gbGenre.Name = "gbGenre"
        gbGenre.Size = New Size(541, 125)
        gbGenre.TabIndex = 3
        gbGenre.TabStop = False
        ' 
        ' cbMusic
        ' 
        cbMusic.AutoSize = True
        cbMusic.Location = New Point(329, 49)
        cbMusic.Name = "cbMusic"
        cbMusic.Size = New Size(58, 19)
        cbMusic.TabIndex = 2
        cbMusic.Text = "Music"
        cbMusic.UseVisualStyleBackColor = True
        ' 
        ' cbShoujo
        ' 
        cbShoujo.AutoSize = True
        cbShoujo.Location = New Point(6, 95)
        cbShoujo.Name = "cbShoujo"
        cbShoujo.Size = New Size(63, 19)
        cbShoujo.TabIndex = 2
        cbShoujo.Text = "Shoujo"
        cbShoujo.UseVisualStyleBackColor = True
        ' 
        ' cbFantasy
        ' 
        cbFantasy.AutoSize = True
        cbFantasy.Location = New Point(433, 22)
        cbFantasy.Name = "cbFantasy"
        cbFantasy.Size = New Size(66, 19)
        cbFantasy.TabIndex = 2
        cbFantasy.Text = "Fantasy"
        cbFantasy.UseVisualStyleBackColor = True
        ' 
        ' cbRomance
        ' 
        cbRomance.AutoSize = True
        cbRomance.Location = New Point(102, 72)
        cbRomance.Name = "cbRomance"
        cbRomance.Size = New Size(76, 19)
        cbRomance.TabIndex = 2
        cbRomance.Text = "Romance"
        cbRomance.UseVisualStyleBackColor = True
        ' 
        ' cbPhsyco
        ' 
        cbPhsyco.AutoSize = True
        cbPhsyco.ForeColor = Color.Black
        cbPhsyco.Location = New Point(433, 95)
        cbPhsyco.Name = "cbPhsyco"
        cbPhsyco.Size = New Size(99, 19)
        cbPhsyco.TabIndex = 2
        cbPhsyco.Text = "Pshycological"
        cbPhsyco.UseVisualStyleBackColor = True
        ' 
        ' cbMagic
        ' 
        cbMagic.AutoSize = True
        cbMagic.Location = New Point(6, 70)
        cbMagic.Name = "cbMagic"
        cbMagic.Size = New Size(59, 19)
        cbMagic.TabIndex = 2
        cbMagic.Text = "Magic"
        cbMagic.UseVisualStyleBackColor = True
        ' 
        ' cbGame
        ' 
        cbGame.AutoSize = True
        cbGame.Location = New Point(6, 47)
        cbGame.Name = "cbGame"
        cbGame.Size = New Size(57, 19)
        cbGame.TabIndex = 2
        cbGame.Text = "Game"
        cbGame.UseVisualStyleBackColor = True
        ' 
        ' cbHorror
        ' 
        cbHorror.AutoSize = True
        cbHorror.Location = New Point(215, 49)
        cbHorror.Name = "cbHorror"
        cbHorror.Size = New Size(61, 19)
        cbHorror.TabIndex = 2
        cbHorror.Text = "Horror"
        cbHorror.UseVisualStyleBackColor = True
        ' 
        ' cbHarem
        ' 
        cbHarem.AutoSize = True
        cbHarem.Location = New Point(102, 49)
        cbHarem.Name = "cbHarem"
        cbHarem.Size = New Size(62, 19)
        cbHarem.TabIndex = 2
        cbHarem.Text = "Harem"
        cbHarem.UseVisualStyleBackColor = True
        ' 
        ' cbDrama
        ' 
        cbDrama.AutoSize = True
        cbDrama.Location = New Point(329, 24)
        cbDrama.Name = "cbDrama"
        cbDrama.Size = New Size(61, 19)
        cbDrama.TabIndex = 2
        cbDrama.Text = "Drama"
        cbDrama.UseVisualStyleBackColor = True
        ' 
        ' cbComedy
        ' 
        cbComedy.AutoSize = True
        cbComedy.Location = New Point(215, 24)
        cbComedy.Name = "cbComedy"
        cbComedy.Size = New Size(71, 19)
        cbComedy.TabIndex = 2
        cbComedy.Text = "Comedy"
        cbComedy.UseVisualStyleBackColor = True
        ' 
        ' cbAdventure
        ' 
        cbAdventure.AutoSize = True
        cbAdventure.Location = New Point(102, 24)
        cbAdventure.Name = "cbAdventure"
        cbAdventure.Size = New Size(81, 19)
        cbAdventure.TabIndex = 2
        cbAdventure.Text = "Adventure"
        cbAdventure.UseVisualStyleBackColor = True
        ' 
        ' cbSport
        ' 
        cbSport.AutoSize = True
        cbSport.Location = New Point(329, 97)
        cbSport.Name = "cbSport"
        cbSport.Size = New Size(59, 19)
        cbSport.TabIndex = 2
        cbSport.Text = "Sports"
        cbSport.UseVisualStyleBackColor = True
        ' 
        ' cbSoL
        ' 
        cbSoL.AutoSize = True
        cbSoL.Location = New Point(215, 97)
        cbSoL.Name = "cbSoL"
        cbSoL.Size = New Size(86, 19)
        cbSoL.TabIndex = 2
        cbSoL.Text = "Slice of Life"
        cbSoL.UseVisualStyleBackColor = True
        ' 
        ' cbSciFi
        ' 
        cbSciFi.AutoSize = True
        cbSciFi.Location = New Point(215, 72)
        cbSciFi.Name = "cbSciFi"
        cbSciFi.Size = New Size(55, 19)
        cbSciFi.TabIndex = 2
        cbSciFi.Text = "Sci-Fi"
        cbSciFi.UseVisualStyleBackColor = True
        ' 
        ' cbShounen
        ' 
        cbShounen.AutoSize = True
        cbShounen.Location = New Point(102, 97)
        cbShounen.Name = "cbShounen"
        cbShounen.Size = New Size(73, 19)
        cbShounen.TabIndex = 2
        cbShounen.Text = "Shounen"
        cbShounen.UseVisualStyleBackColor = True
        ' 
        ' cbSeinen
        ' 
        cbSeinen.AutoSize = True
        cbSeinen.ForeColor = Color.Black
        cbSeinen.Location = New Point(433, 70)
        cbSeinen.Name = "cbSeinen"
        cbSeinen.Size = New Size(61, 19)
        cbSeinen.TabIndex = 2
        cbSeinen.Text = "Seinen"
        cbSeinen.UseVisualStyleBackColor = True
        ' 
        ' cbSchool
        ' 
        cbSchool.AutoSize = True
        cbSchool.Location = New Point(329, 72)
        cbSchool.Name = "cbSchool"
        cbSchool.Size = New Size(62, 19)
        cbSchool.TabIndex = 2
        cbSchool.Text = "School"
        cbSchool.UseVisualStyleBackColor = True
        ' 
        ' cbMystery
        ' 
        cbMystery.AutoSize = True
        cbMystery.ForeColor = Color.Black
        cbMystery.Location = New Point(433, 47)
        cbMystery.Name = "cbMystery"
        cbMystery.Size = New Size(68, 19)
        cbMystery.TabIndex = 2
        cbMystery.Text = "Mystery"
        cbMystery.UseVisualStyleBackColor = True
        ' 
        ' cbAction
        ' 
        cbAction.AutoSize = True
        cbAction.Location = New Point(6, 22)
        cbAction.Name = "cbAction"
        cbAction.Size = New Size(61, 19)
        cbAction.TabIndex = 2
        cbAction.Text = "Action"
        cbAction.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.WhiteSmoke
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 354)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(879, 150)
        DataGridView1.TabIndex = 4
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Transparent
        btnSimpan.Font = New Font("Ketchum", 9.75F)
        btnSimpan.Location = New Point(293, 288)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 5
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.Transparent
        btnUbah.Font = New Font("Ketchum", 9.75F)
        btnUbah.Location = New Point(471, 288)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 23)
        btnUbah.TabIndex = 5
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Transparent
        btnHapus.Font = New Font("Ketchum", 9.75F)
        btnHapus.Location = New Point(635, 288)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 5
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Transparent
        btnBatal.Font = New Font("Ketchum", 9.75F)
        btnBatal.Location = New Point(793, 288)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 23)
        btnBatal.TabIndex = 5
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' pbPhoto
        ' 
        pbPhoto.BorderStyle = BorderStyle.FixedSingle
        pbPhoto.Image = My.Resources.Resources._882391
        pbPhoto.Location = New Point(12, 21)
        pbPhoto.Name = "pbPhoto"
        pbPhoto.Size = New Size(211, 261)
        pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage
        pbPhoto.TabIndex = 3
        pbPhoto.TabStop = False
        ' 
        ' btnCari
        ' 
        btnCari.BackColor = Color.Transparent
        btnCari.Font = New Font("Ketchum", 9.75F)
        btnCari.Location = New Point(74, 288)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(75, 23)
        btnCari.TabIndex = 5
        btnCari.Text = "Cari Foto"
        btnCari.UseVisualStyleBackColor = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Ketchum", 9.75F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(626, 238)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 15)
        Label6.TabIndex = 0
        Label6.Text = "Status"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(693, 238)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(198, 23)
        cmbStatus.TabIndex = 6
        ' 
        ' btnLihat
        ' 
        btnLihat.BackColor = Color.Transparent
        btnLihat.Font = New Font("Ketchum", 9.75F)
        btnLihat.Location = New Point(471, 325)
        btnLihat.Name = "btnLihat"
        btnLihat.Size = New Size(95, 23)
        btnLihat.TabIndex = 5
        btnLihat.Text = "Lihat Anime"
        btnLihat.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(919, 526)
        Controls.Add(cmbStatus)
        Controls.Add(pbPhoto)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnLihat)
        Controls.Add(btnUbah)
        Controls.Add(btnCari)
        Controls.Add(btnSimpan)
        Controls.Add(DataGridView1)
        Controls.Add(gbGenre)
        Controls.Add(txtRating)
        Controls.Add(txtStudio)
        Controls.Add(txtEpisode)
        Controls.Add(txtJudul)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Form1"
        gbGenre.ResumeLayout(False)
        gbGenre.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbPhoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtEpisode As TextBox
    Friend WithEvents txtStudio As TextBox
    Friend WithEvents cbAction As CheckBox
    Friend WithEvents gbGenre As GroupBox
    Friend WithEvents cbFantasy As CheckBox
    Friend WithEvents cbGame As CheckBox
    Friend WithEvents cbAdventure As CheckBox
    Friend WithEvents cbMystery As CheckBox
    Friend WithEvents txtRating As TextBox
    Friend WithEvents cbRomance As CheckBox
    Friend WithEvents cbPhsyco As CheckBox
    Friend WithEvents cbMagic As CheckBox
    Friend WithEvents cbMusic As CheckBox
    Friend WithEvents cbHorror As CheckBox
    Friend WithEvents cbHarem As CheckBox
    Friend WithEvents cbDrama As CheckBox
    Friend WithEvents cbComedy As CheckBox
    Friend WithEvents cbSport As CheckBox
    Friend WithEvents cbSchool As CheckBox
    Friend WithEvents cbSoL As CheckBox
    Friend WithEvents cbShoujo As CheckBox
    Friend WithEvents cbSciFi As CheckBox
    Friend WithEvents cbShounen As CheckBox
    Friend WithEvents cbSeinen As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents pbPhoto As PictureBox
    Friend WithEvents btnCari As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnLihat As Button

End Class
