Imports System.Data.SQLite
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports flappy_bird_vb.Managers

Public Class LoginScreen
    Private Sub LoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlLogin.Visible = True
        pnlRegister.Visible = False

    End Sub

    Private Sub toLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles toLogin.LinkClicked
        pnlLogin.Visible = True
        pnlRegister.Visible = False
    End Sub
    Private Sub toRegiter_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles toRegiter.LinkClicked
        pnlLogin.Visible = False
        pnlRegister.Visible = True
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If Store.CheckNull(tbRegisterName.Text) Or Store.CheckNull(tbRegisterPassword.Text) Or Store.CheckNull(tbRegainPassword.Text) Then
            MsgBox("Vui lòng điền đầy đủ thông tin!")
            Return
        End If

        If tbRegisterPassword.Text <> tbRegainPassword.Text Then
            MessageBox.Show("vui long nhập đúng mật khẩu!", "Thất Bại")
            tbRegisterPassword.Clear()
            tbRegainPassword.Clear()
            Return
        End If


        DataManager.connection.Open()
        DataManager.command.Connection = DataManager.connection



        DataManager.command.CommandText = "SELECT * FROM user WHERE name = @name"
        DataManager.command.Parameters.AddWithValue("@name", tbRegisterName.Text)

        Dim da As New SQLiteDataAdapter(DataManager.command)
        Dim dt As New DataTable

        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            MessageBox.Show("Đăng ký thất bại!", "Thất Bại")
            tbRegisterName.Clear()
            tbRegisterPassword.Clear()
            tbRegainPassword.Clear()
            DataManager.connection.Close()
            Return
        Else
            MessageBox.Show("Đăng ký thành công!", "Thành Công")


            DataManager.command.CommandText = "insert into user(name,password) values (@name,@password)"
            DataManager.command.Parameters.AddWithValue("@name", tbRegisterName.Text)
            DataManager.command.Parameters.AddWithValue("@password", tbRegainPassword.Text)

            DataManager.command.ExecuteNonQuery()
            DataManager.connection.Close()

            pnlLogin.Visible = True
            pnlRegister.Visible = False
        End If
        DataManager.connection.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If Store.CheckNull(tbLoginName.Text) Or Store.CheckNull(tbLoginPassword.Text) Then
            MsgBox("Vui lòng điền đầy đủ thông tin!")
            Return
        End If


        DataManager.connection.Open()
        DataManager.command.Connection = DataManager.connection

        DataManager.command.CommandText = "SELECT * FROM user WHERE name = @name and password = @password"
        DataManager.command.Parameters.AddWithValue("@name", tbLoginName.Text)
        DataManager.command.Parameters.AddWithValue("@password", tbLoginPassword.Text)
        DataManager.connection.Close()

        Dim da As New SQLiteDataAdapter(DataManager.command)
        Dim dt As New DataTable

        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            DataManager.connection.Open()

            MessageBox.Show("Đăng nhập thành công!", "Thành công")
            DataManager.command.CommandText = "update application SET name=@name, save = @save"
            DataManager.command.Parameters.AddWithValue("@name", tbLoginName.Text)
            DataManager.command.Parameters.AddWithValue("@save", Store.ChangeBoolToNum(save.Checked))

            DataManager.command.ExecuteNonQuery()
            DataManager.connection.Close()

            StateManager.ChangeState(StateManager.State.Menu)
            Return
        Else
            MessageBox.Show("Đăng nhập thất bại!", "Thất bại")
            tbLoginName.Clear()
            tbLoginPassword.Clear()
        End If

    End Sub
End Class