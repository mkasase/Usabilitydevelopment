Public Class Form1

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightBlue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = My.Settings.Username And
            TextBox1.Text = My.Settings.Password Then
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("Invalid access try again")
        End If
        Form2.Label2.Text = TextBox3.Text
        Form6.Label7.Text = TextBox3.Text
        Form6.Label8.Text = TextBox4.Text
        Form6.Label9.Text = TextBox5.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Please insert values")
        Else
            My.Settings.Username = TextBox5.Text
            My.Settings.Password = TextBox7.Text
            My.Settings.Save()
            MsgBox("Registered into the system")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = ""
        MsgBox("Values reset")
    End Sub
End Class
