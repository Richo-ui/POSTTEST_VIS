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
        Me.picProfil = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        rbCewe = New RadioButton()
        rbCowo = New RadioButton()
        GroupBox2 = New GroupBox()
        cbBaca = New CheckBox()
        cbMancing = New CheckBox()
        cbGame = New CheckBox()
        txtNama = New TextBox()
        txtNim = New TextBox()
        Me.btnGambar = New Button()
        btnCetak = New Button()
        dtpLahir = New DateTimePicker()
        CType(Me.picProfil, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' picProfil
        ' 
        Me.picProfil.Location = New Point(30, 29)
        Me.picProfil.Name = "picProfil"
        Me.picProfil.Size = New Size(197, 314)
        Me.picProfil.TabIndex = 0
        Me.picProfil.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(276, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 1
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(276, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 1
        Label2.Text = "Label1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(276, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 1
        Label3.Text = "Label1"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbCewe)
        GroupBox1.Controls.Add(rbCowo)
        GroupBox1.Location = New Point(276, 175)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(240, 168)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' rbCewe
        ' 
        rbCewe.AutoSize = True
        rbCewe.Location = New Point(23, 94)
        rbCewe.Name = "rbCewe"
        rbCewe.Size = New Size(86, 19)
        rbCewe.TabIndex = 5
        rbCewe.TabStop = True
        rbCewe.Text = "Perempuan"
        rbCewe.UseVisualStyleBackColor = True
        ' 
        ' rbCowo
        ' 
        rbCowo.AutoSize = True
        rbCowo.Location = New Point(23, 40)
        rbCowo.Name = "rbCowo"
        rbCowo.Size = New Size(72, 19)
        rbCowo.TabIndex = 5
        rbCowo.TabStop = True
        rbCowo.Text = "Laki-Laki"
        rbCowo.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbBaca)
        GroupBox2.Controls.Add(cbMancing)
        GroupBox2.Controls.Add(cbGame)
        GroupBox2.Location = New Point(544, 175)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(228, 168)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox1"
        ' 
        ' cbBaca
        ' 
        cbBaca.AutoSize = True
        cbBaca.Location = New Point(19, 65)
        cbBaca.Name = "cbBaca"
        cbBaca.Size = New Size(79, 19)
        cbBaca.TabIndex = 6
        cbBaca.Text = "Membaca"
        cbBaca.UseVisualStyleBackColor = True
        ' 
        ' cbMancing
        ' 
        cbMancing.AutoSize = True
        cbMancing.Location = New Point(19, 104)
        cbMancing.Name = "cbMancing"
        cbMancing.Size = New Size(73, 19)
        cbMancing.TabIndex = 6
        cbMancing.Text = "Mancing"
        cbMancing.UseVisualStyleBackColor = True
        ' 
        ' cbGame
        ' 
        cbGame.AutoSize = True
        cbGame.Location = New Point(19, 31)
        cbGame.Name = "cbGame"
        cbGame.Size = New Size(68, 19)
        cbGame.TabIndex = 6
        cbGame.Text = "Gaming"
        cbGame.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(416, 26)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(100, 23)
        txtNama.TabIndex = 3
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(416, 74)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(100, 23)
        txtNim.TabIndex = 3
        ' 
        ' btnGambar
        ' 
        Me.btnGambar.Location = New Point(30, 374)
        Me.btnGambar.Name = "btnGambar"
        Me.btnGambar.Size = New Size(197, 23)
        Me.btnGambar.TabIndex = 4
        Me.btnGambar.Text = "Ganti Gambar"
        Me.btnGambar.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(276, 374)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(496, 23)
        btnCetak.TabIndex = 4
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(416, 127)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(200, 23)
        dtpLahir.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dtpLahir)
        Controls.Add(btnCetak)
        Controls.Add(Me.btnGambar)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Me.picProfil)
        Name = "Form1"
        Text = "Form1"
        CType(Me.picProfil, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picProfil As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbCewe As RadioButton
    Friend WithEvents rbCowo As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbMancing As CheckBox
    Friend WithEvents cbBaca As CheckBox
    Friend WithEvents cbGame As CheckBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents btnGambar As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents dtpLahir As DateTimePicker

End Class
