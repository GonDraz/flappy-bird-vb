<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuScreen
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
        Me.playButton = New Guna.UI2.WinForms.Guna2Button()
        Me.base = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnScore = New Guna.UI2.WinForms.Guna2Button()
        Me.btnQuit = New Guna.UI2.WinForms.Guna2Button()
        Me.textUser = New System.Windows.Forms.Label()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.base, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'playButton
        '
        Me.playButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.playButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.playButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.playButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.playButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.playButton.ForeColor = System.Drawing.Color.White
        Me.playButton.Location = New System.Drawing.Point(533, 184)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(180, 45)
        Me.playButton.TabIndex = 0
        Me.playButton.Text = "Chơi"
        '
        'base
        '
        Me.base.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.base.Image = Global.flappy_bird_vb.My.Resources.Resources.base
        Me.base.ImageRotate = 0!
        Me.base.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.base.Location = New System.Drawing.Point(0, 508)
        Me.base.Name = "base"
        Me.base.Size = New System.Drawing.Size(1280, 180)
        Me.base.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.base.TabIndex = 3
        Me.base.TabStop = False
        '
        'btnScore
        '
        Me.btnScore.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnScore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnScore.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnScore.ForeColor = System.Drawing.Color.White
        Me.btnScore.Location = New System.Drawing.Point(533, 249)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(180, 45)
        Me.btnScore.TabIndex = 4
        Me.btnScore.Text = "Điểm"
        '
        'btnQuit
        '
        Me.btnQuit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnQuit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnQuit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnQuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnQuit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnQuit.ForeColor = System.Drawing.Color.White
        Me.btnQuit.Location = New System.Drawing.Point(533, 379)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(180, 45)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "Thoát"
        '
        'textUser
        '
        Me.textUser.AutoSize = True
        Me.textUser.Location = New System.Drawing.Point(12, 9)
        Me.textUser.Name = "textUser"
        Me.textUser.Size = New System.Drawing.Size(39, 13)
        Me.textUser.TabIndex = 6
        Me.textUser.Text = "Label1"
        '
        'btnLogout
        '
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(533, 457)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(180, 45)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Đăng xuất"
        '
        'MenuScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.flappy_bird_vb.My.Resources.Resources.background_day
        Me.ClientSize = New System.Drawing.Size(1280, 688)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.textUser)
        Me.Controls.Add(Me.btnScore)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.base)
        Me.Controls.Add(Me.playButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuScreen"
        Me.Text = "Menu"
        CType(Me.base, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents playButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents base As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnScore As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnQuit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents textUser As Label
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
End Class
