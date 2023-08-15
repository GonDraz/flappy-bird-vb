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
        Me.playButton.Location = New System.Drawing.Point(301, 216)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(180, 45)
        Me.playButton.TabIndex = 0
        Me.playButton.Text = "Guna2Button1"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 688)
        Me.Controls.Add(Me.playButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents playButton As Guna.UI2.WinForms.Guna2Button
End Class
