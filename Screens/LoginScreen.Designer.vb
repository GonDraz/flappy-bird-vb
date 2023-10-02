<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginScreen))
        Me.base = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlLogin = New Guna.UI2.WinForms.Guna2Panel()
        Me.toRegiter = New System.Windows.Forms.LinkLabel()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbLoginPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.save = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.tbLoginName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlRegister = New Guna.UI2.WinForms.Guna2Panel()
        Me.toLogin = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbRegainPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnRegister = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbRegisterPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbRegisterName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.base, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLogin.SuspendLayout()
        Me.pnlRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'base
        '
        resources.ApplyResources(Me.base, "base")
        Me.base.Image = Global.flappy_bird_vb.My.Resources.Resources.base
        Me.base.ImageRotate = 0!
        Me.base.Name = "base"
        Me.base.TabStop = False
        '
        'pnlLogin
        '
        resources.ApplyResources(Me.pnlLogin, "pnlLogin")
        Me.pnlLogin.Controls.Add(Me.toRegiter)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.Label3)
        Me.pnlLogin.Controls.Add(Me.tbLoginPassword)
        Me.pnlLogin.Controls.Add(Me.Label2)
        Me.pnlLogin.Controls.Add(Me.save)
        Me.pnlLogin.Controls.Add(Me.tbLoginName)
        Me.pnlLogin.Controls.Add(Me.Label1)
        Me.pnlLogin.Name = "pnlLogin"
        '
        'toRegiter
        '
        resources.ApplyResources(Me.toRegiter, "toRegiter")
        Me.toRegiter.Name = "toRegiter"
        Me.toRegiter.TabStop = True
        '
        'btnLogin
        '
        resources.ApplyResources(Me.btnLogin, "btnLogin")
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Name = "btnLogin"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'tbLoginPassword
        '
        resources.ApplyResources(Me.tbLoginPassword, "tbLoginPassword")
        Me.tbLoginPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbLoginPassword.DefaultText = ""
        Me.tbLoginPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbLoginPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbLoginPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLoginPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLoginPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLoginPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLoginPassword.Name = "tbLoginPassword"
        Me.tbLoginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLoginPassword.PlaceholderText = ""
        Me.tbLoginPassword.SelectedText = ""
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'save
        '
        resources.ApplyResources(Me.save, "save")
        Me.save.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.save.CheckedState.BorderRadius = 0
        Me.save.CheckedState.BorderThickness = 0
        Me.save.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.save.Name = "save"
        Me.save.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.save.UncheckedState.BorderRadius = 0
        Me.save.UncheckedState.BorderThickness = 0
        Me.save.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'tbLoginName
        '
        resources.ApplyResources(Me.tbLoginName, "tbLoginName")
        Me.tbLoginName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbLoginName.DefaultText = ""
        Me.tbLoginName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbLoginName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbLoginName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLoginName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLoginName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLoginName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLoginName.Name = "tbLoginName"
        Me.tbLoginName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLoginName.PlaceholderText = ""
        Me.tbLoginName.SelectedText = ""
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'pnlRegister
        '
        resources.ApplyResources(Me.pnlRegister, "pnlRegister")
        Me.pnlRegister.Controls.Add(Me.toLogin)
        Me.pnlRegister.Controls.Add(Me.Label7)
        Me.pnlRegister.Controls.Add(Me.tbRegainPassword)
        Me.pnlRegister.Controls.Add(Me.btnRegister)
        Me.pnlRegister.Controls.Add(Me.Label4)
        Me.pnlRegister.Controls.Add(Me.tbRegisterPassword)
        Me.pnlRegister.Controls.Add(Me.Label5)
        Me.pnlRegister.Controls.Add(Me.tbRegisterName)
        Me.pnlRegister.Controls.Add(Me.Label6)
        Me.pnlRegister.Name = "pnlRegister"
        '
        'toLogin
        '
        resources.ApplyResources(Me.toLogin, "toLogin")
        Me.toLogin.Name = "toLogin"
        Me.toLogin.TabStop = True
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'tbRegainPassword
        '
        resources.ApplyResources(Me.tbRegainPassword, "tbRegainPassword")
        Me.tbRegainPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbRegainPassword.DefaultText = ""
        Me.tbRegainPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbRegainPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbRegainPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbRegainPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbRegainPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbRegainPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbRegainPassword.Name = "tbRegainPassword"
        Me.tbRegainPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbRegainPassword.PlaceholderText = ""
        Me.tbRegainPassword.SelectedText = ""
        '
        'btnRegister
        '
        resources.ApplyResources(Me.btnRegister, "btnRegister")
        Me.btnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Name = "btnRegister"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'tbRegisterPassword
        '
        resources.ApplyResources(Me.tbRegisterPassword, "tbRegisterPassword")
        Me.tbRegisterPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbRegisterPassword.DefaultText = ""
        Me.tbRegisterPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbRegisterPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbRegisterPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbRegisterPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbRegisterPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbRegisterPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbRegisterPassword.Name = "tbRegisterPassword"
        Me.tbRegisterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbRegisterPassword.PlaceholderText = ""
        Me.tbRegisterPassword.SelectedText = ""
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'tbRegisterName
        '
        resources.ApplyResources(Me.tbRegisterName, "tbRegisterName")
        Me.tbRegisterName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbRegisterName.DefaultText = ""
        Me.tbRegisterName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbRegisterName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbRegisterName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbRegisterName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbRegisterName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbRegisterName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbRegisterName.Name = "tbRegisterName"
        Me.tbRegisterName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbRegisterName.PlaceholderText = ""
        Me.tbRegisterName.SelectedText = ""
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'LoginScreen
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.flappy_bird_vb.My.Resources.Resources.background_night
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.pnlRegister)
        Me.Controls.Add(Me.base)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginScreen"
        CType(Me.base, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.pnlRegister.ResumeLayout(False)
        Me.pnlRegister.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents base As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pnlLogin As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbLoginPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents save As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents tbLoginName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlRegister As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents tbRegainPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRegister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tbRegisterPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbRegisterName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents toRegiter As LinkLabel
    Friend WithEvents toLogin As LinkLabel
End Class
