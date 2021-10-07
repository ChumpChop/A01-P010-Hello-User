Public Class HelloUser

    Private Sub btnOK_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnOK.Click
        'Display a message box greeting to the user
        MessageBox.Show("Hello, " & txtName.Text & _
            "! Welcome to Visual Basic 2010.", _
            "Hello User Message")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnExit.Click
        'End the program and close the form
        Me.Close()
    End Sub
End Class
