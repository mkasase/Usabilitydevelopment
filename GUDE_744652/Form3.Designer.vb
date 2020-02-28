<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HomepageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RewardsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GymAndClassesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(661, 71)
        Me.Panel1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(148, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 31)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Gym and Leisure Classes"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 95)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MonthCalendar1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.RichTextBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(564, 251)
        Me.SplitContainer1.SplitterDistance = 230
        Me.SplitContainer1.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button1.Location = New System.Drawing.Point(71, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(0, 28)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(37, 46)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(231, 165)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        ListViewGroup1.Header = "ListViewGroup"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "ListViewGroup"
        ListViewGroup2.Name = "ListViewGroup2"
        ListViewGroup3.Header = "ListViewGroup"
        ListViewGroup3.Name = "ListViewGroup3"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListView1.Location = New System.Drawing.Point(21, 17)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(286, 211)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
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
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(585, 208)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Logout"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(585, 141)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Rewards"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(585, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Profile"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(585, 79)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Homepage"
        Me.Button2.UseVisualStyleBackColor = True
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
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(585, 179)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "Setting"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 376)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HomepageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RewardsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GymAndClassesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
