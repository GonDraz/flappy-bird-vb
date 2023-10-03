<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameScreen))
        Me.base = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pauseButton = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.scoreLB = New System.Windows.Forms.Label()
        Me.pnlPause = New System.Windows.Forms.Panel()
        Me.pnlMenuInGame = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnScore = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlGameOver = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnReplay = New Guna.UI2.WinForms.Guna2Button()
        Me.btnResume = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.base, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPause.SuspendLayout()
        Me.pnlMenuInGame.SuspendLayout()
        Me.pnlGameOver.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'base
        '
        Me.base.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.base.Image = Global.flappy_bird_vb.My.Resources.Resources.base
        Me.base.ImageRotate = 0!
        Me.base.Location = New System.Drawing.Point(0, 508)
        Me.base.Name = "base"
        Me.base.Size = New System.Drawing.Size(1280, 180)
        Me.base.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.base.TabIndex = 0
        Me.base.TabStop = False
        '
        'pauseButton
        '
        Me.pauseButton.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.pauseButton.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.pauseButton.Image = CType(resources.GetObject("pauseButton.Image"), System.Drawing.Image)
        Me.pauseButton.ImageOffset = New System.Drawing.Point(0, 0)
        Me.pauseButton.ImageRotate = 0!
        Me.pauseButton.Location = New System.Drawing.Point(12, 12)
        Me.pauseButton.Name = "pauseButton"
        Me.pauseButton.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.pauseButton.Size = New System.Drawing.Size(64, 54)
        Me.pauseButton.TabIndex = 1
        '
        'scoreLB
        '
        Me.scoreLB.AutoSize = True
        Me.scoreLB.BackColor = System.Drawing.Color.Transparent
        Me.scoreLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreLB.Location = New System.Drawing.Point(468, 12)
        Me.scoreLB.Name = "scoreLB"
        Me.scoreLB.Size = New System.Drawing.Size(226, 73)
        Me.scoreLB.TabIndex = 2
        Me.scoreLB.Text = "Label1"
        '
        'pnlPause
        '
        Me.pnlPause.BackColor = System.Drawing.Color.Transparent
        Me.pnlPause.Controls.Add(Me.pnlMenuInGame)
        Me.pnlPause.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPause.Location = New System.Drawing.Point(0, 0)
        Me.pnlPause.Name = "pnlPause"
        Me.pnlPause.Size = New System.Drawing.Size(1280, 508)
        Me.pnlPause.TabIndex = 3
        '
        'pnlMenuInGame
        '
        Me.pnlMenuInGame.BackColor = System.Drawing.Color.White
        Me.pnlMenuInGame.BorderColor = System.Drawing.Color.White
        Me.pnlMenuInGame.BorderRadius = 24
        Me.pnlMenuInGame.Controls.Add(Me.btnResume)
        Me.pnlMenuInGame.Controls.Add(Me.Label1)
        Me.pnlMenuInGame.Controls.Add(Me.btnScore)
        Me.pnlMenuInGame.Controls.Add(Me.btnBack)
        Me.pnlMenuInGame.Location = New System.Drawing.Point(470, 50)
        Me.pnlMenuInGame.Name = "pnlMenuInGame"
        Me.pnlMenuInGame.Size = New System.Drawing.Size(340, 400)
        Me.pnlMenuInGame.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 55)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Tạm Đừng"
        '
        'btnScore
        '
        Me.btnScore.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnScore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnScore.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnScore.ForeColor = System.Drawing.Color.White
        Me.btnScore.Location = New System.Drawing.Point(83, 262)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(180, 45)
        Me.btnScore.TabIndex = 5
        Me.btnScore.Text = "Điểm"
        '
        'btnBack
        '
        Me.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(83, 352)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(180, 45)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Quay lại menu"
        '
        'pnlGameOver
        '
        Me.pnlGameOver.BackColor = System.Drawing.Color.Transparent
        Me.pnlGameOver.Controls.Add(Me.Guna2PictureBox1)
        Me.pnlGameOver.Controls.Add(Me.btnReplay)
        Me.pnlGameOver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGameOver.Location = New System.Drawing.Point(0, 0)
        Me.pnlGameOver.Name = "pnlGameOver"
        Me.pnlGameOver.Size = New System.Drawing.Size(1280, 508)
        Me.pnlGameOver.TabIndex = 1
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.flappy_bird_vb.My.Resources.Resources.gameover
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(186, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(624, 236)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'btnReplay
        '
        Me.btnReplay.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReplay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReplay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReplay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReplay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReplay.ForeColor = System.Drawing.Color.White
        Me.btnReplay.Location = New System.Drawing.Point(418, 312)
        Me.btnReplay.Name = "btnReplay"
        Me.btnReplay.Size = New System.Drawing.Size(180, 45)
        Me.btnReplay.TabIndex = 0
        Me.btnReplay.Text = "Replay"
        '
        'btnResume
        '
        Me.btnResume.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnResume.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnResume.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnResume.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnResume.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnResume.ForeColor = System.Drawing.Color.White
        Me.btnResume.Location = New System.Drawing.Point(83, 122)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(180, 45)
        Me.btnResume.TabIndex = 7
        Me.btnResume.Text = "Chơi tiếp "
        '
        'GameScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.flappy_bird_vb.My.Resources.Resources.background_day
        Me.ClientSize = New System.Drawing.Size(1280, 688)
        Me.Controls.Add(Me.pnlPause)
        Me.Controls.Add(Me.pnlGameOver)
        Me.Controls.Add(Me.scoreLB)
        Me.Controls.Add(Me.pauseButton)
        Me.Controls.Add(Me.base)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GameScreen"
        Me.Text = "ViewGamePlay"
        CType(Me.base, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPause.ResumeLayout(False)
        Me.pnlMenuInGame.ResumeLayout(False)
        Me.pnlMenuInGame.PerformLayout()
        Me.pnlGameOver.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents base As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pauseButton As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents scoreLB As Label
    Friend WithEvents pnlPause As Panel
    Friend WithEvents pnlMenuInGame As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlGameOver As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnReplay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnScore As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnResume As Guna.UI2.WinForms.Guna2Button
End Class
