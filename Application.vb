Public Class Application

    Private Sub Application_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchForm(View.GamePlay)
    End Sub

    Public Sub SwitchForm(form As Form)
        mainPanel.Controls.Clear()
        form.TopLevel = False
        mainPanel.Controls.Add(form)
        form.Show()
    End Sub
End Class
