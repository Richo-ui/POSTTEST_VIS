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
        lblPredikat = New Label()
        txtIPS = New TextBox()
        txtIPK = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(292, 164)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 0
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(292, 222)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 0
        Label2.Text = "IP Kumulatif"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(375, 256)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(22, 15)
        lblPredikat.TabIndex = 0
        lblPredikat.Text = "....."
        ' 
        ' txtIPS
        ' 
        txtIPS.Location = New Point(375, 161)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(130, 23)
        txtIPS.TabIndex = 1
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(375, 219)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(130, 23)
        txtIPK.TabIndex = 1
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(375, 190)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(62, 23)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(443, 190)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(62, 23)
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
        Controls.Add(btnTambah)
        Controls.Add(txtIPK)
        Controls.Add(txtIPS)
        Controls.Add(lblPredikat)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button

End Class
