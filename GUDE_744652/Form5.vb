Public Class Form5

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click

        If CheckBox1.Checked = True Then
            Form1.BackColor = Color.IndianRed()
            Form2.BackColor = Color.IndianRed()
            Form3.BackColor = Color.IndianRed()
            Form4.BackColor = Color.IndianRed()
            Me.BackColor = Color.IndianRed()
            Form6.BackColor = Color.IndianRed()
            CheckBox2.CheckState = False
            CheckBox3.CheckState = False


        ElseIf CheckBox2.Checked = True Then
            Form1.BackColor = Color.LawnGreen()
            Form2.BackColor = Color.LawnGreen()
            Form3.BackColor = Color.LawnGreen()
            Form4.BackColor = Color.LawnGreen()
            Me.BackColor = Color.LawnGreen()
            Form6.BackColor = Color.LawnGreen()
            CheckBox1.CheckState = False
            CheckBox3.CheckState = False

        ElseIf CheckBox3.Checked = True Then
            Form1.BackColor = Color.Aqua()
            Form2.BackColor = Color.Aqua()
            Form3.BackColor = Color.Aqua()
            Form4.BackColor = Color.Aqua()
            Me.BackColor = Color.Aqua()
            Form6.BackColor = Color.Aqua()
            CheckBox1.CheckState = False
            CheckBox2.CheckState = False

        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form1.BackColor = Color.LightBlue()
        Form2.BackColor = Color.LightBlue()
        Form3.BackColor = Color.LightBlue()
        Form4.BackColor = Color.LightBlue()
        Me.BackColor = Color.LightBlue()
        Form6.BackColor = Color.LightBlue()

        CheckBox1.CheckState = False
        CheckBox2.CheckState = False
        CheckBox3.CheckState = False
    End Sub
End Class