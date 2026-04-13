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
        MenuStrip1 = New MenuStrip()
        InputData = New ToolStripMenuItem()
        BukaFile = New ToolStripMenuItem()
        Kembali = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        tcIdentitas = New TabPage()
        mtxtNoHp = New MaskedTextBox()
        txtAlamat = New TextBox()
        txtNama = New TextBox()
        tcRingkasan = New TabPage()
        lblRingkasan = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        btnSimpan = New Button()
        btnReset = New Button()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        tcIdentitas.SuspendLayout()
        tcRingkasan.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputData, BukaFile, Kembali})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputData
        ' 
        InputData.Name = "InputData"
        InputData.Size = New Size(47, 20)
        InputData.Text = "Input"
        ' 
        ' BukaFile
        ' 
        BukaFile.Name = "BukaFile"
        BukaFile.Size = New Size(66, 20)
        BukaFile.Text = "Buka File"
        ' 
        ' Kembali
        ' 
        Kembali.Name = "Kembali"
        Kembali.Size = New Size(62, 20)
        Kembali.Text = "Kembali"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tcIdentitas)
        TabControl1.Controls.Add(tcRingkasan)
        TabControl1.Location = New Point(23, 85)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(427, 232)
        TabControl1.TabIndex = 1
        ' 
        ' tcIdentitas
        ' 
        tcIdentitas.Controls.Add(mtxtNoHp)
        tcIdentitas.Controls.Add(txtAlamat)
        tcIdentitas.Controls.Add(txtNama)
        tcIdentitas.Location = New Point(4, 24)
        tcIdentitas.Name = "tcIdentitas"
        tcIdentitas.Padding = New Padding(3)
        tcIdentitas.Size = New Size(419, 204)
        tcIdentitas.TabIndex = 0
        tcIdentitas.Text = "Identitas"
        tcIdentitas.UseVisualStyleBackColor = True
        ' 
        ' mtxtNoHp
        ' 
        mtxtNoHp.Location = New Point(6, 120)
        mtxtNoHp.Mask = "0000-0000-0000"
        mtxtNoHp.Name = "mtxtNoHp"
        mtxtNoHp.Size = New Size(100, 23)
        mtxtNoHp.TabIndex = 1
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(6, 35)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat"
        txtAlamat.Size = New Size(210, 79)
        txtAlamat.TabIndex = 0
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(6, 6)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama "
        txtNama.Size = New Size(100, 23)
        txtNama.TabIndex = 0
        ' 
        ' tcRingkasan
        ' 
        tcRingkasan.Controls.Add(lblRingkasan)
        tcRingkasan.Location = New Point(4, 24)
        tcRingkasan.Name = "tcRingkasan"
        tcRingkasan.Padding = New Padding(3)
        tcRingkasan.Size = New Size(419, 204)
        tcRingkasan.TabIndex = 1
        tcRingkasan.Text = "Ringkasan"
        tcRingkasan.UseVisualStyleBackColor = True
        ' 
        ' lblRingkasan
        ' 
        lblRingkasan.AutoSize = True
        lblRingkasan.Location = New Point(23, 25)
        lblRingkasan.Name = "lblRingkasan"
        lblRingkasan.Size = New Size(41, 15)
        lblRingkasan.TabIndex = 0
        lblRingkasan.Text = "Label1"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(103, 339)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 2
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(287, 339)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 23)
        btnReset.TabIndex = 2
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnReset)
        Controls.Add(btnSimpan)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        tcIdentitas.ResumeLayout(False)
        tcIdentitas.PerformLayout()
        tcRingkasan.ResumeLayout(False)
        tcRingkasan.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputData As ToolStripMenuItem
    Friend WithEvents BukaFile As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tcIdentitas As TabPage
    Friend WithEvents mtxtNoHp As MaskedTextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents tcRingkasan As TabPage
    Friend WithEvents lblRingkasan As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Kembali As ToolStripMenuItem

End Class
