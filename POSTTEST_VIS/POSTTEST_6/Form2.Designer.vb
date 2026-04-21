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
        pbPhoto = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        lblJudul = New Label()
        lblGenre = New Label()
        lblEpisode = New Label()
        lblStudio = New Label()
        lblRating = New Label()
        lblStatus = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel8 = New Panel()
        Panel3 = New Panel()
        Panel10 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel9 = New Panel()
        Panel11 = New Panel()
        Panel12 = New Panel()
        Panel13 = New Panel()
        Panel14 = New Panel()
        lblAnime = New Label()
        Panel15 = New Panel()
        CType(pbPhoto, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel9.SuspendLayout()
        Panel11.SuspendLayout()
        Panel12.SuspendLayout()
        Panel13.SuspendLayout()
        Panel14.SuspendLayout()
        SuspendLayout()
        ' 
        ' pbPhoto
        ' 
        pbPhoto.Image = My.Resources.Resources._882391
        pbPhoto.Location = New Point(12, 87)
        pbPhoto.Name = "pbPhoto"
        pbPhoto.Size = New Size(236, 241)
        pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage
        pbPhoto.TabIndex = 0
        pbPhoto.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkSlateBlue
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 21)
        Label1.TabIndex = 1
        Label1.Text = "Anime:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DarkSlateBlue
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(299, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 19)
        Label2.TabIndex = 1
        Label2.Text = "Judul"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.DarkSlateBlue
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(299, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 19)
        Label3.TabIndex = 1
        Label3.Text = "Genre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.DarkSlateBlue
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(0, 5)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 19)
        Label4.TabIndex = 1
        Label4.Text = "Episode"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.DarkSlateBlue
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(299, 195)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 19)
        Label5.TabIndex = 1
        Label5.Text = "Studio"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.DarkSlateBlue
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(299, 228)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 19)
        Label6.TabIndex = 1
        Label6.Text = "Rating"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.DarkSlateBlue
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(299, 264)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 19)
        Label7.TabIndex = 1
        Label7.Text = "Status"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblJudul.Font = New Font("Segoe UI", 10F)
        lblJudul.Location = New Point(364, 91)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(41, 19)
        lblJudul.TabIndex = 1
        lblJudul.Text = "Judul"
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Font = New Font("Segoe UI", 10F)
        lblGenre.Location = New Point(8, 5)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(46, 19)
        lblGenre.TabIndex = 1
        lblGenre.Text = "Genre"
        ' 
        ' lblEpisode
        ' 
        lblEpisode.AutoSize = True
        lblEpisode.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblEpisode.Font = New Font("Segoe UI", 10F)
        lblEpisode.Location = New Point(9, 5)
        lblEpisode.Name = "lblEpisode"
        lblEpisode.Size = New Size(56, 19)
        lblEpisode.TabIndex = 1
        lblEpisode.Text = "Episode"
        ' 
        ' lblStudio
        ' 
        lblStudio.AutoSize = True
        lblStudio.BackColor = Color.Silver
        lblStudio.Font = New Font("Segoe UI", 10F)
        lblStudio.Location = New Point(6, 4)
        lblStudio.Name = "lblStudio"
        lblStudio.Size = New Size(48, 19)
        lblStudio.TabIndex = 1
        lblStudio.Text = "Studio"
        ' 
        ' lblRating
        ' 
        lblRating.AutoSize = True
        lblRating.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblRating.Font = New Font("Segoe UI", 10F)
        lblRating.Location = New Point(6, 4)
        lblRating.Name = "lblRating"
        lblRating.Size = New Size(48, 19)
        lblRating.TabIndex = 1
        lblRating.Text = "Rating"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.BackColor = Color.Silver
        lblStatus.Font = New Font("Segoe UI", 10F)
        lblStatus.Location = New Point(5, 4)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(47, 19)
        lblStatus.TabIndex = 1
        lblStatus.Text = "Status"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateBlue
        Panel1.Location = New Point(299, 87)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(56, 28)
        Panel1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkSlateBlue
        Panel2.Controls.Add(Panel8)
        Panel2.Location = New Point(299, 118)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(56, 33)
        Panel2.TabIndex = 2
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel8.Location = New Point(55, 1)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(56, 19)
        Panel8.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkSlateBlue
        Panel3.Controls.Add(Panel10)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(299, 154)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(56, 34)
        Panel3.TabIndex = 2
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Yellow
        Panel10.Location = New Point(55, 0)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(269, 19)
        Panel10.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.DarkSlateBlue
        Panel4.Location = New Point(299, 191)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(59, 30)
        Panel4.TabIndex = 2
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.DarkSlateBlue
        Panel5.Location = New Point(299, 224)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(59, 33)
        Panel5.TabIndex = 2
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.DarkSlateBlue
        Panel6.Location = New Point(299, 260)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(59, 35)
        Panel6.TabIndex = 2
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel7.Location = New Point(354, 87)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(434, 28)
        Panel7.TabIndex = 2
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Silver
        Panel9.Controls.Add(lblGenre)
        Panel9.Location = New Point(355, 118)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(433, 33)
        Panel9.TabIndex = 2
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel11.Controls.Add(lblEpisode)
        Panel11.Location = New Point(355, 154)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(433, 34)
        Panel11.TabIndex = 2
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel12.Controls.Add(lblRating)
        Panel12.Location = New Point(358, 224)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(430, 33)
        Panel12.TabIndex = 2
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.Silver
        Panel13.Controls.Add(lblStudio)
        Panel13.Location = New Point(358, 191)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(430, 30)
        Panel13.TabIndex = 2
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.Silver
        Panel14.Controls.Add(lblStatus)
        Panel14.Location = New Point(358, 260)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(430, 35)
        Panel14.TabIndex = 2
        ' 
        ' lblAnime
        ' 
        lblAnime.AutoSize = True
        lblAnime.BackColor = Color.DarkSlateBlue
        lblAnime.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAnime.ForeColor = Color.White
        lblAnime.Location = New Point(76, 22)
        lblAnime.Name = "lblAnime"
        lblAnime.Size = New Size(60, 21)
        lblAnime.TabIndex = 1
        lblAnime.Text = "Anime"
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.DarkSlateBlue
        Panel15.Location = New Point(12, 18)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(776, 31)
        Panel15.TabIndex = 2
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 355)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(lblJudul)
        Controls.Add(Label2)
        Controls.Add(lblAnime)
        Controls.Add(Label1)
        Controls.Add(pbPhoto)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel14)
        Controls.Add(Panel13)
        Controls.Add(Panel9)
        Controls.Add(Panel12)
        Controls.Add(Panel11)
        Controls.Add(Panel7)
        Controls.Add(Panel15)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        CType(pbPhoto, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbPhoto As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblEpisode As Label
    Friend WithEvents lblStudio As Label
    Friend WithEvents lblRating As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents lblAnime As Label
    Friend WithEvents Panel15 As Panel
End Class
