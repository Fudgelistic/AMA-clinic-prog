Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Settings.Username = "" And My.Settings.Password = "" Then
            My.Settings.Username = TextBox1.Text
            My.Settings.Password = TextBox2.Text
            My.Settings.Save()
            MsgBox("Account Created!", MsgBoxStyle.Information, "Create")
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("Account Already Exists: Delete existing account before creating a new one.", MsgBoxStyle.Information, "Error")
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        End

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class