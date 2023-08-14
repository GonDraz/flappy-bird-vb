Public Class Application
    Private applicationManager As ApplicationManager
    Private Sub Application_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        applicationManager = New ApplicationManager
    End Sub

    Public Sub SwitchForm(form As Form)
        mainPanel.Controls.Clear()
        form.TopLevel = False
        mainPanel.Controls.Add(form)
        form.Show()
    End Sub
End Class
