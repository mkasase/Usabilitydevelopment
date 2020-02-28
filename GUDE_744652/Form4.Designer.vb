<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBox10 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox9 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox8 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox7 = New System.Windows.Forms.RichTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.RichTextBox6 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HomepageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RewardsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GymAndClassesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(661, 71)
        Me.Panel1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(171, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 31)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Rewards and store"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 78)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(579, 263)
        Me.SplitContainer1.SplitterDistance = 192
        Me.SplitContainer1.TabIndex = 14
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button6.Location = New System.Drawing.Point(95, 208)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(58, 38)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = ">"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button4.Location = New System.Drawing.Point(35, 208)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(54, 38)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(15, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(365, 231)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.RichTextBox3)
        Me.TabPage1.Controls.Add(Me.RichTextBox2)
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(357, 205)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pure gym"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Location = New System.Drawing.Point(3, 115)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(163, 21)
        Me.RichTextBox3.TabIndex = 4
        Me.RichTextBox3.Text = "Refer a friend to join 800pts x 2 "
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(0, 65)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(309, 24)
        Me.RichTextBox2.TabIndex = 3
        Me.RichTextBox2.Text = "£14.99 when book a class involving weights and zumba. 650pts"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 21)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(306, 21)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "40 % of your membership when you have collected 800pts"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBox10)
        Me.TabPage2.Controls.Add(Me.RichTextBox9)
        Me.TabPage2.Controls.Add(Me.RichTextBox8)
        Me.TabPage2.Controls.Add(Me.RichTextBox7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(357, 205)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "24/7 fitness"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RichTextBox10
        '
        Me.RichTextBox10.Location = New System.Drawing.Point(7, 123)
        Me.RichTextBox10.Name = "RichTextBox10"
        Me.RichTextBox10.Size = New System.Drawing.Size(296, 34)
        Me.RichTextBox10.TabIndex = 4
        Me.RichTextBox10.Text = "Free club membersip when you sign-up with family member : 1600pts"
        '
        'RichTextBox9
        '
        Me.RichTextBox9.Location = New System.Drawing.Point(7, 76)
        Me.RichTextBox9.Name = "RichTextBox9"
        Me.RichTextBox9.Size = New System.Drawing.Size(306, 24)
        Me.RichTextBox9.TabIndex = 3
        Me.RichTextBox9.Text = "40 % of your membership when you have collected 800pts"
        '
        'RichTextBox8
        '
        Me.RichTextBox8.Location = New System.Drawing.Point(7, 33)
        Me.RichTextBox8.Name = "RichTextBox8"
        Me.RichTextBox8.Size = New System.Drawing.Size(306, 24)
        Me.RichTextBox8.TabIndex = 2
        Me.RichTextBox8.Text = "40 % of your membership when you have collected 800pts"
        '
        'RichTextBox7
        '
        Me.RichTextBox7.Location = New System.Drawing.Point(7, 6)
        Me.RichTextBox7.Name = "RichTextBox7"
        Me.RichTextBox7.Size = New System.Drawing.Size(344, 183)
        Me.RichTextBox7.TabIndex = 0
        Me.RichTextBox7.Text = ""
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.RichTextBox6)
        Me.TabPage3.Controls.Add(Me.RichTextBox5)
        Me.TabPage3.Controls.Add(Me.RichTextBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(357, 205)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Pyramids leisure centre"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'RichTextBox6
        '
        Me.RichTextBox6.Location = New System.Drawing.Point(6, 123)
        Me.RichTextBox6.Name = "RichTextBox6"
        Me.RichTextBox6.Size = New System.Drawing.Size(306, 24)
        Me.RichTextBox6.TabIndex = 3
        Me.RichTextBox6.Text = "40 % of your membership when join 500pts"
        '
        'RichTextBox5
        '
        Me.RichTextBox5.Location = New System.Drawing.Point(6, 82)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.Size = New System.Drawing.Size(306, 24)
        Me.RichTextBox5.TabIndex = 2
        Me.RichTextBox5.Text = "Spa session exclusive offer : 750pts"
        '
        'RichTextBox4
        '
        Me.RichTextBox4.Location = New System.Drawing.Point(6, 38)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(306, 24)
        Me.RichTextBox4.TabIndex = 1
        Me.RichTextBox4.Text = "Swimming sessions at reduced offer: 950pts"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomepageToolStripMenuItem, Me.RewardsToolStripMenuItem, Me.GymAndClassesToolStripMenuItem, Me.UserProfileToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(139, 114)
        '
        'HomepageToolStripMenuItem
        '
        Me.HomepageToolStripMenuItem.Name = "HomepageToolStripMenuItem"
        Me.HomepageToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.HomepageToolStripMenuItem.Text = "Homepage"
        '
        'RewardsToolStripMenuItem
        '
        Me.RewardsToolStripMenuItem.Name = "RewardsToolStripMenuItem"
        Me.RewardsToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.RewardsToolStripMenuItem.Text = "Rewards"
        '
        'GymAndClassesToolStripMenuItem
        '
        Me.GymAndClassesToolStripMenuItem.Name = "GymAndClassesToolStripMenuItem"
        Me.GymAndClassesToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.GymAndClassesToolStripMenuItem.Text = "Gym and Classes"
        '
        'UserProfileToolStripMenuItem
        '
        Me.UserProfileToolStripMenuItem.Name = "UserProfileToolStripMenuItem"
        Me.UserProfileToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.UserProfileToolStripMenuItem.Text = "User Profile"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(588, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Homepage"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(588, 199)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "Logout"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(588, 109)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Profile"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(587, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Gym"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(3, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(593, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(588, 167)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 30
        Me.Button7.Text = "Setting"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 376)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HomepageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RewardsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GymAndClassesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox10 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox9 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox8 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox7 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox6 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox5 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
