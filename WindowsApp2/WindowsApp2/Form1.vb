Public Class Form1
    Dim IsFirstClick As Boolean = True
    Dim IsFirstClick2 As Boolean = True

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.Username And
                TextBox2.Text = My.Settings.Password Then
            Form3.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Username or Password.", MsgBoxStyle.Information, "Error")



        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click

        If IsFirstClick = True Then
            Me.TextBox1.ForeColor = Color.Black
            Me.TextBox1.Text = Nothing
            IsFirstClick = False
        End If
    End Sub
    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If Me.TextBox1.TextLength = 0 Then
            IsFirstClick = True
            Me.TextBox1.ForeColor = Color.Gray
            Me.TextBox1.Text = "Username"
        End If
    End Sub
    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click

        If IsFirstClick2 = True Then
            Me.TextBox2.ForeColor = Color.Black
            Me.TextBox2.Text = Nothing
            Me.TextBox2.PasswordChar = "*"
            IsFirstClick2 = False
        End If
    End Sub
    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If Me.TextBox2.TextLength = 0 Then
            IsFirstClick2 = True
            Me.TextBox2.ForeColor = Color.Gray
            Me.TextBox2.Text = "Password"
            Me.TextBox2.PasswordChar = ""
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        End

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class