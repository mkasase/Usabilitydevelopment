Public Class Form2

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightBlue
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim queryAddress As New System.Text.StringBuilder
        queryAddress.Append("http://maps.google.com/?q=")

        If ComboBox1.Text = ("Puregym") Then
            queryAddress.Append("PureGym Portsmouth")
        End If
        If ComboBox1.Text = ("pyramids") Then
            queryAddress.Append("Pyramids centre portsmouth")
        End If
        If ComboBox1.Text = ("Mountbatten") Then
            queryAddress.Append("Mountbatten Centre portsmouth")
        End If
            WebBrowser1.Navigate(queryAddress.ToString)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ContextMenuStrip1.Show(PictureBox2, 0, PictureBox2.Height)
    End Sub

    Private Sub GymAndClassesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GymAndClassesToolStripMenuItem.Click

    End Sub

    Private Sub UserProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserProfileToolStripMenuItem.Click

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class