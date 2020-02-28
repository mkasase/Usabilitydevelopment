Public Class Form4
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ContextMenuStrip1.Show(PictureBox2, 0, PictureBox2.Height)
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Form6.Show()
        Form3.Show()
        Form1.Show()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightBlue
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show()
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PictureBox1.Image = My.Resources.PUREGYM
        PictureBox1.Image = My.Resources.pyramids_PORTSMOUTH
        PictureBox1.Image = My.Resources._247FITNESS

        Dim puregym As Image = My.Resources.PUREGYM
        Dim pyramid As Image = My.Resources.pyramids_PORTSMOUTH
        Dim fitness247 As Image = My.Resources._247FITNESS
        If PictureBox1.Image Is puregym Then
            TabPage1.Show()
        ElseIf PictureBox1.Image Is puregym Then
            TabPage2.Show()
        ElseIf PictureBox1.Image Is fitness247 Then
            TabPage3.Show()
        End If
    End Sub

    Private Sub Button4_load(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image = My.Resources._247FITNESS
        PictureBox1.Image = My.Resources.pyramids_PORTSMOUTH
        PictureBox1.Image = My.Resources.PUREGYM
    End Sub
End Class