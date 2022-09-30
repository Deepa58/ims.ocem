Public Class Login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text = "Deepa" And txtpassword.Text = "1234" Then
            MsgBox("You Login Sucessfully")
        Else
            MsgBox("Wrong username or Password")

        End If
    End Sub
End Class
