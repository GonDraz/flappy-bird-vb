<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameScreen))
        Me.base = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pauseButton = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.scoreLB = New System.Windows.Forms.Label()
        CType(Me.base, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GameScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.flappy_bird_vb.My.Resources.Resources.background_day
        Me.ClientSize = New System.Drawing.Size(1280, 688)
        Me.Controls.Add(Me.scoreLB)
        Me.Controls.Add(Me.pauseButton)
        Me.Controls.Add(Me.base)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GameScreen"
        Me.Text = "ViewGamePlay"
        CType(Me.base, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents base As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pauseButton As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents scoreLB As Label
End Class
